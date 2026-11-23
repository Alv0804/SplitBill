create table public.invite_code_attempts (
	id uuid primary key default gen_random_uuid(),
	user_id uuid not null references auth.users (id) on delete cascade,
	created_at timestamptz not null default now()
);

create index invite_code_attempts_user_created_at_idx
	on public.invite_code_attempts (user_id, created_at desc);

alter table public.invite_code_attempts enable row level security;

drop policy if exists groups_owner_insert on public.groups;
drop policy if exists groups_owner_update on public.groups;
drop policy if exists group_members_owner_access on public.group_members;

create policy group_members_owner_read on public.group_members
	for select to authenticated
	using (public.is_group_owner(group_id));

alter table public.join_requests
	add column reviewed_by uuid references auth.users (id),
	add column reviewed_at timestamptz;

create unique index join_requests_one_pending_per_user_group_idx
	on public.join_requests (group_id, user_id)
	where status = 'pending';

create or replace function public.handle_new_user()
returns trigger
language plpgsql
security definer
set search_path = ''
as $$
declare
	v_display_name text;
begin
	v_display_name := coalesce(
		nullif(btrim(new.raw_user_meta_data ->> 'display_name'), ''),
		nullif(split_part(coalesce(new.email, ''), '@', 1), ''),
		'Pengguna'
	);
	insert into public.profiles (id, display_name)
	values (new.id, v_display_name)
	on conflict (id) do update set display_name = excluded.display_name;
	return new;
end;
$$;

create trigger on_auth_user_created
	after insert on auth.users
	for each row execute function public.handle_new_user();

create or replace function public.consume_invite_attempt()
returns boolean
language plpgsql
security definer
set search_path = ''
as $$
declare
	v_user_id uuid := auth.uid();
	v_recent_attempts bigint;
begin
	if v_user_id is null then
		return false;
	end if;

	perform pg_advisory_xact_lock(hashtextextended(v_user_id::text, 0));
	select count(*) into v_recent_attempts
	from public.invite_code_attempts a
	where a.user_id = v_user_id
	  and a.created_at >= now() - interval '15 minutes';

	if v_recent_attempts >= 5 then
		return false;
	end if;

	insert into public.invite_code_attempts (user_id) values (v_user_id);
	return true;
end;
$$;

create or replace function public.create_group(
	p_type text,
	p_name text,
	p_event_date date,
	p_place_id uuid,
	p_owner_person_id uuid,
	p_person_ids uuid[]
)
returns uuid
language plpgsql
security definer
set search_path = ''
as $$
declare
	v_user_id uuid := auth.uid();
	v_group_id uuid := gen_random_uuid();
	v_invite_code text;
	v_person_count integer;
	v_distinct_person_count integer;
begin
	if v_user_id is null then
		raise exception 'Sesi login tidak valid.' using errcode = '28000';
	end if;
	if p_type not in ('hangout', 'trip', 'purchase_rental') then
		raise exception 'Jenis kegiatan tidak valid.' using errcode = '22023';
	end if;
	if nullif(btrim(p_name), '') is null then
		raise exception 'Nama grup wajib diisi.' using errcode = '22023';
	end if;
	if p_event_date is null then
		raise exception 'Tanggal kegiatan wajib diisi.' using errcode = '22023';
	end if;
	if p_owner_person_id is null or not exists (
		select 1 from public.people p
		where p.id = p_owner_person_id and p.owner_id = v_user_id
	) then
		raise exception 'Pilih nama owner dari database orang milik Anda.' using errcode = '22023';
	end if;
	if p_place_id is not null and not exists (
		select 1 from public.places p
		where p.id = p_place_id and p.owner_id = v_user_id
	) then
		raise exception 'Tempat tidak ditemukan pada database Anda.' using errcode = '22023';
	end if;

	select count(*), count(distinct selected.person_id)
	into v_person_count, v_distinct_person_count
	from unnest(coalesce(p_person_ids, array[]::uuid[])) as selected(person_id);
	if v_person_count <> v_distinct_person_count then
		raise exception 'Anggota grup tidak boleh dipilih lebih dari sekali.' using errcode = '22023';
	end if;
	if exists (
		select 1
		from unnest(coalesce(p_person_ids, array[]::uuid[])) as selected(person_id)
		left join public.people p on p.id = selected.person_id and p.owner_id = v_user_id
		where p.id is null or selected.person_id = p_owner_person_id
	) then
		raise exception 'Semua anggota harus berasal dari database orang milik Anda dan owner tidak boleh duplikat.' using errcode = '22023';
	end if;

	loop
		v_invite_code := upper(substr(replace(gen_random_uuid()::text, '-', ''), 1, 8));
		exit when not exists (select 1 from public.groups g where g.invite_code = v_invite_code);
	end loop;

	insert into public.groups (id, owner_id, type, name, event_date, place_id, invite_code)
	values (v_group_id, v_user_id, p_type, btrim(p_name), p_event_date, p_place_id, v_invite_code);

	insert into public.group_members (group_id, person_id, user_id, role)
	values (v_group_id, p_owner_person_id, v_user_id, 'owner');

	insert into public.group_members (group_id, person_id, role)
	select v_group_id, selected.person_id, 'member'
	from unnest(coalesce(p_person_ids, array[]::uuid[])) as selected(person_id);

	return v_group_id;
end;
$$;

create or replace function public.preview_invite(p_invite_code text)
returns jsonb
language plpgsql
security definer
set search_path = ''
as $$
declare
	v_group public.groups%rowtype;
	v_owner_name text;
	v_members jsonb;
begin
	if auth.uid() is null then
		return jsonb_build_object('valid', false, 'message', 'Login terlebih dahulu.');
	end if;
	if not public.consume_invite_attempt() then
		return jsonb_build_object('valid', false, 'message', 'Terlalu banyak percobaan kode. Coba lagi dalam 15 menit.');
	end if;

	select g.* into v_group
	from public.groups g
	where g.invite_code = upper(btrim(coalesce(p_invite_code, '')))
	  and g.invite_enabled
	  and g.status = 'active';
	if not found then
		return jsonb_build_object('valid', false, 'message', 'Kode undangan tidak valid atau sudah dinonaktifkan.');
	end if;

	select p.display_name into v_owner_name
	from public.profiles p where p.id = v_group.owner_id;

	select coalesce(jsonb_agg(jsonb_build_object('memberId', gm.id, 'name', p.name) order by gm.created_at, gm.id), '[]'::jsonb)
	into v_members
	from public.group_members gm
	join public.people p on p.id = gm.person_id
	where gm.group_id = v_group.id and gm.user_id is null;

	return jsonb_build_object(
		'valid', true,
		'groupId', v_group.id,
		'groupName', v_group.name,
		'ownerName', coalesce(v_owner_name, 'Owner'),
		'members', v_members
	);
end;
$$;

create or replace function public.request_to_join(
	p_invite_code text,
	p_claimed_member_id uuid,
	p_proposed_name text
)
returns jsonb
language plpgsql
security definer
set search_path = ''
as $$
declare
	v_user_id uuid := auth.uid();
	v_group_id uuid;
	v_request_id uuid;
begin
	if v_user_id is null then
		return jsonb_build_object('submitted', false, 'message', 'Login terlebih dahulu.');
	end if;
	if not public.consume_invite_attempt() then
		return jsonb_build_object('submitted', false, 'message', 'Terlalu banyak percobaan kode. Coba lagi dalam 15 menit.');
	end if;

	select g.id into v_group_id
	from public.groups g
	where g.invite_code = upper(btrim(coalesce(p_invite_code, '')))
	  and g.invite_enabled
	  and g.status = 'active';
	if v_group_id is null then
		return jsonb_build_object('submitted', false, 'message', 'Kode undangan tidak valid atau sudah dinonaktifkan.');
	end if;
	if exists (select 1 from public.group_members gm where gm.group_id = v_group_id and gm.user_id = v_user_id) then
		return jsonb_build_object('submitted', false, 'message', 'Akun ini sudah menjadi anggota grup.');
	end if;
	if (p_claimed_member_id is null) = (nullif(btrim(coalesce(p_proposed_name, '')), '') is null) then
		return jsonb_build_object('submitted', false, 'message', 'Pilih nama anggota atau isi nama baru.');
	end if;
	if p_claimed_member_id is not null and not exists (
		select 1 from public.group_members gm
		where gm.id = p_claimed_member_id and gm.group_id = v_group_id and gm.user_id is null
	) then
		return jsonb_build_object('submitted', false, 'message', 'Nama tersebut sudah tertaut atau bukan anggota grup ini.');
	end if;
	if exists (
		select 1 from public.join_requests r
		where r.group_id = v_group_id and r.user_id = v_user_id and r.status = 'pending'
	) then
		return jsonb_build_object('submitted', false, 'message', 'Permintaan Anda masih menunggu persetujuan owner.');
	end if;

	insert into public.join_requests (group_id, user_id, claimed_member_id, proposed_name)
	values (v_group_id, v_user_id, p_claimed_member_id, nullif(btrim(coalesce(p_proposed_name, '')), ''))
	returning id into v_request_id;

	return jsonb_build_object('submitted', true, 'requestId', v_request_id, 'status', 'pending');
end;
$$;

create or replace function public.review_join_request(p_request_id uuid, p_approve boolean)
returns uuid
language plpgsql
security definer
set search_path = ''
as $$
declare
	v_owner_id uuid := auth.uid();
	v_request public.join_requests%rowtype;
	v_group_owner_id uuid;
	v_person_id uuid;
	v_member_id uuid;
begin
	select g.owner_id into v_group_owner_id
	from public.groups g
	join public.join_requests r on r.group_id = g.id
	where r.id = p_request_id and g.status = 'active'
	for update of r;
	if v_group_owner_id is null or v_group_owner_id <> v_owner_id then
		raise exception 'Permintaan tidak ditemukan atau Anda bukan owner grup.' using errcode = '42501';
	end if;

	select * into v_request from public.join_requests r where r.id = p_request_id;
	if v_request.status <> 'pending' then
		raise exception 'Permintaan ini sudah diputuskan.' using errcode = '22023';
	end if;

	if p_approve then
		if v_request.claimed_member_id is not null then
			select gm.person_id into v_person_id
			from public.group_members gm
			where gm.id = v_request.claimed_member_id
			  and gm.group_id = v_request.group_id
			  and (gm.user_id is null or gm.user_id = v_request.user_id)
			for update;
			if v_person_id is null then
				raise exception 'Nama anggota sudah tertaut ke akun lain.' using errcode = '22023';
			end if;
		else
			insert into public.people (owner_id, name)
			values (v_group_owner_id, v_request.proposed_name)
			on conflict (owner_id, name) do update set name = excluded.name
			returning id into v_person_id;

			select gm.id into v_member_id
			from public.group_members gm
			where gm.group_id = v_request.group_id and gm.person_id = v_person_id
			for update;
			if v_member_id is not null and exists (
				select 1 from public.group_members gm where gm.id = v_member_id and gm.user_id is not null and gm.user_id <> v_request.user_id
			) then
				raise exception 'Nama tersebut sudah tertaut ke akun lain.' using errcode = '22023';
			end if;
		end if;

		insert into public.group_members (group_id, person_id, user_id, role)
		values (v_request.group_id, v_person_id, v_request.user_id, 'member')
		on conflict (group_id, person_id) do update set user_id = excluded.user_id
		returning id into v_member_id;
		update public.join_requests
		set status = 'approved', reviewed_by = v_owner_id, reviewed_at = now()
		where id = p_request_id;
	else
		update public.join_requests
		set status = 'rejected', reviewed_by = v_owner_id, reviewed_at = now()
		where id = p_request_id;
	end if;

	return v_member_id;
end;
$$;

create or replace function public.set_invite_enabled(p_group_id uuid, p_enabled boolean)
returns void
language plpgsql
security definer
set search_path = ''
as $$
begin
	update public.groups
	set invite_enabled = p_enabled
	where id = p_group_id
	  and owner_id = auth.uid()
	  and status = 'active';
	if not found then
		raise exception 'Grup aktif tidak ditemukan atau Anda bukan owner.' using errcode = '42501';
	end if;
end;
$$;

create or replace function public.regenerate_invite_code(p_group_id uuid)
returns text
language plpgsql
security definer
set search_path = ''
as $$
declare
	v_invite_code text;
begin
	if not exists (
		select 1 from public.groups g
		where g.id = p_group_id and g.owner_id = auth.uid() and g.status = 'active'
	) then
		raise exception 'Grup aktif tidak ditemukan atau Anda bukan owner.' using errcode = '42501';
	end if;

	loop
		v_invite_code := upper(substr(replace(gen_random_uuid()::text, '-', ''), 1, 8));
		exit when not exists (select 1 from public.groups g where g.invite_code = v_invite_code);
	end loop;

	update public.groups set invite_code = v_invite_code, invite_enabled = true where id = p_group_id;
	return v_invite_code;
end;
$$;

revoke all on function public.handle_new_user() from public, anon, authenticated;
revoke all on function public.consume_invite_attempt() from public, anon, authenticated;
revoke all on function public.create_group(text, text, date, uuid, uuid, uuid[]) from public, anon;
revoke all on function public.preview_invite(text) from public, anon;
revoke all on function public.request_to_join(text, uuid, text) from public, anon;
revoke all on function public.review_join_request(uuid, boolean) from public, anon;
revoke all on function public.set_invite_enabled(uuid, boolean) from public, anon;
revoke all on function public.regenerate_invite_code(uuid) from public, anon;
grant execute on function public.create_group(text, text, date, uuid, uuid, uuid[]) to authenticated;
grant execute on function public.preview_invite(text) to authenticated;
grant execute on function public.request_to_join(text, uuid, text) to authenticated;
grant execute on function public.review_join_request(uuid, boolean) to authenticated;
grant execute on function public.set_invite_enabled(uuid, boolean) to authenticated;
grant execute on function public.regenerate_invite_code(uuid) to authenticated;
