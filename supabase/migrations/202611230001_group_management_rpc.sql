create or replace function public.update_group_details(
	p_group_id uuid,
	p_name text,
	p_event_date date,
	p_place_id uuid
)
returns void
language plpgsql
security definer
set search_path = ''
as $$
begin
	if nullif(btrim(p_name), '') is null or p_event_date is null then
		raise exception 'Nama dan tanggal kegiatan wajib diisi.' using errcode = '22023';
	end if;
	if p_place_id is not null and not exists (
		select 1 from public.places p where p.id = p_place_id and p.owner_id = auth.uid()
	) then
		raise exception 'Tempat tidak ditemukan pada database Anda.' using errcode = '22023';
	end if;

	update public.groups
	set name = btrim(p_name), event_date = p_event_date, place_id = p_place_id
	where id = p_group_id and owner_id = auth.uid() and status = 'active';
	if not found then
		raise exception 'Grup aktif tidak ditemukan atau Anda bukan owner.' using errcode = '42501';
	end if;
end;
$$;

create or replace function public.add_group_member(p_group_id uuid, p_person_id uuid)
returns uuid
language plpgsql
security definer
set search_path = ''
as $$
declare
	v_member_id uuid;
begin
	if not exists (
		select 1 from public.groups g where g.id = p_group_id and g.owner_id = auth.uid() and g.status = 'active'
	) then
		raise exception 'Grup aktif tidak ditemukan atau Anda bukan owner.' using errcode = '42501';
	end if;
	if not exists (
		select 1 from public.people p where p.id = p_person_id and p.owner_id = auth.uid()
	) then
		raise exception 'Anggota tidak ditemukan pada database orang Anda.' using errcode = '22023';
	end if;

	insert into public.group_members (group_id, person_id, role)
	values (p_group_id, p_person_id, 'member')
	returning id into v_member_id;
	return v_member_id;
exception
	when unique_violation then
		raise exception 'Orang tersebut sudah menjadi anggota grup.' using errcode = '22023';
end;
$$;

create or replace function public.remove_group_member(p_group_id uuid, p_member_id uuid)
returns void
language plpgsql
security definer
set search_path = ''
as $$
declare
	v_member_role text;
	v_user_id uuid;
begin
	if not exists (
		select 1 from public.groups g where g.id = p_group_id and g.owner_id = auth.uid() and g.status = 'active'
	) then
		raise exception 'Grup aktif tidak ditemukan atau Anda bukan owner.' using errcode = '42501';
	end if;

	select gm.role, gm.user_id into v_member_role, v_user_id
	from public.group_members gm
	where gm.id = p_member_id and gm.group_id = p_group_id
	for update;
	if not found then
		raise exception 'Anggota tidak ditemukan.' using errcode = '22023';
	end if;
	if v_member_role = 'owner' or v_user_id = auth.uid() then
		raise exception 'Owner grup tidak dapat dikeluarkan dari kegiatan.' using errcode = '22023';
	end if;
	if exists (
		select 1 from public.join_requests r
		where r.group_id = p_group_id and r.claimed_member_id = p_member_id and r.status = 'pending'
	) then
		raise exception 'Putuskan permintaan bergabung anggota ini terlebih dahulu.' using errcode = '22023';
	end if;

	delete from public.group_members where id = p_member_id;
exception
	when foreign_key_violation then
		raise exception 'Anggota sudah tercatat pada pengeluaran atau riwayat dan tidak dapat dihapus.' using errcode = '23503';
end;
$$;

create or replace function public.get_group_join_requests(p_group_id uuid)
returns jsonb
language plpgsql
stable
security definer
set search_path = ''
as $$
declare
	v_requests jsonb;
begin
	if not public.is_group_owner(p_group_id) then
		raise exception 'Hanya owner grup yang dapat melihat pengajuan.' using errcode = '42501';
	end if;

	select coalesce(jsonb_agg(
		jsonb_build_object(
			'requestId', r.id,
			'requesterUserId', r.user_id,
			'requesterName', coalesce(profile.display_name, 'Pengguna'),
			'memberId', r.claimed_member_id,
			'memberName', coalesce(person.name, r.proposed_name),
			'status', r.status,
			'createdAt', r.created_at
		) order by r.created_at, r.id
	), '[]'::jsonb)
	into v_requests
	from public.join_requests r
	left join public.profiles profile on profile.id = r.user_id
	left join public.group_members gm on gm.id = r.claimed_member_id
	left join public.people person on person.id = gm.person_id
	where r.group_id = p_group_id and r.status = 'pending';

	return v_requests;
end;
$$;

revoke all on function public.update_group_details(uuid, text, date, uuid) from public, anon;
revoke all on function public.add_group_member(uuid, uuid) from public, anon;
revoke all on function public.remove_group_member(uuid, uuid) from public, anon;
revoke all on function public.get_group_join_requests(uuid) from public, anon;
grant execute on function public.update_group_details(uuid, text, date, uuid) to authenticated;
grant execute on function public.add_group_member(uuid, uuid) to authenticated;
grant execute on function public.remove_group_member(uuid, uuid) to authenticated;
grant execute on function public.get_group_join_requests(uuid) to authenticated;
