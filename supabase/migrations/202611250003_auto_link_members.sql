-- Migration: 202611250003_auto_link_members.sql
-- Automatically link user_id to group_members when added via add_group_member or create_group
-- And provide claim_my_memberships RPC so users immediately see groups they were added to

-- 1. Update add_group_member to auto-link user_id by matching person.name with profiles.display_name
create or replace function public.add_group_member(p_group_id uuid, p_person_id uuid)
returns uuid
language plpgsql
security definer
set search_path = ''
as $$
declare
	v_member_id uuid;
	v_person_name text;
	v_matched_user_id uuid;
begin
	if not exists (
		select 1 from public.groups g where g.id = p_group_id and g.owner_id = auth.uid() and g.status = 'active'
	) then
		raise exception 'Grup aktif tidak ditemukan atau Anda bukan owner.' using errcode = '42501';
	end if;

	select p.name into v_person_name
	from public.people p
	where p.id = p_person_id and p.owner_id = auth.uid();

	if v_person_name is null then
		raise exception 'Anggota tidak ditemukan pada database orang Anda.' using errcode = '22023';
	end if;

	-- Look up matching registered user in profiles
	select pr.id into v_matched_user_id
	from public.profiles pr
	where lower(btrim(pr.display_name)) = lower(btrim(v_person_name))
	limit 1;

	insert into public.group_members (group_id, person_id, user_id, role)
	values (p_group_id, p_person_id, v_matched_user_id, 'member')
	returning id into v_member_id;

	return v_member_id;
exception
	when unique_violation then
		raise exception 'Orang tersebut sudah menjadi anggota grup.' using errcode = '22023';
end;
$$;

-- 2. Update create_group to also auto-link user_id for each member
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

	insert into public.group_members (group_id, person_id, user_id, role)
	select
		v_group_id,
		p.id,
		(select pr.id from public.profiles pr where lower(btrim(pr.display_name)) = lower(btrim(p.name)) limit 1),
		'member'
	from unnest(coalesce(p_person_ids, array[]::uuid[])) as selected(person_id)
	join public.people p on p.id = selected.person_id and p.owner_id = v_user_id;

	return v_group_id;
end;
$$;

-- 3. Function to claim any unlinked group memberships matching the authenticated user's display_name
create or replace function public.claim_my_memberships()
returns void
language plpgsql
security definer
set search_path = ''
as $$
declare
	v_user_id uuid := auth.uid();
	v_name text;
begin
	if v_user_id is null then return; end if;

	select display_name into v_name
	from public.profiles
	where id = v_user_id;

	if v_name is null or btrim(v_name) = '' then return; end if;

	update public.group_members gm
	set user_id = v_user_id
	from public.people p
	where gm.person_id = p.id
	  and gm.user_id is null
	  and lower(btrim(p.name)) = lower(btrim(v_name))
	  and not exists (
		  select 1 from public.group_members existing
		  where existing.group_id = gm.group_id and existing.user_id = v_user_id
	  );
end;
$$;

revoke all on function public.claim_my_memberships() from public, anon;
grant execute on function public.claim_my_memberships() to authenticated;

-- 4. Immediately link all existing unlinked group_members whose person name matches a user profile
update public.group_members gm
set user_id = pr.id
from public.people p
join public.profiles pr on lower(btrim(pr.display_name)) = lower(btrim(p.name))
where gm.person_id = p.id
  and gm.user_id is null
  and not exists (
	  select 1 from public.group_members existing
	  where existing.group_id = gm.group_id and existing.user_id = pr.id
  );

