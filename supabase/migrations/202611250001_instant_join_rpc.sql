-- Migration: 202611250001_instant_join_rpc.sql
-- Direct instant join with invite code (Google Classroom style)

create or replace function public.join_group_with_code(
	p_invite_code text,
	p_member_name text
)
returns jsonb
language plpgsql
security definer
set search_path = ''
as $$
declare
	v_user_id uuid := auth.uid();
	v_group_id uuid;
	v_group_name text;
	v_group_owner_id uuid;
	v_existing_member_id uuid;
	v_new_person_id uuid;
	v_member_id uuid;
	v_clean_name text := btrim(coalesce(p_member_name, ''));
	v_clean_code text := upper(btrim(coalesce(p_invite_code, '')));
begin
	if v_user_id is null then
		return jsonb_build_object('success', false, 'message', 'Sesi login tidak valid. Silakan masuk kembali.');
	end if;

	if v_clean_code = '' then
		return jsonb_build_object('success', false, 'message', 'Kode undangan wajib diisi.');
	end if;

	if v_clean_name = '' then
		return jsonb_build_object('success', false, 'message', 'Nama anggota wajib diisi.');
	end if;

	select g.id, g.name, g.owner_id into v_group_id, v_group_name, v_group_owner_id
	from public.groups g
	where g.invite_code = v_clean_code
	  and g.invite_enabled = true
	  and g.status = 'active';

	if v_group_id is null then
		return jsonb_build_object('success', false, 'message', 'Kode undangan tidak valid atau kegiatan sudah tidak aktif.');
	end if;

	-- If already a member of this group, return success immediately
	select gm.id into v_member_id
	from public.group_members gm
	where gm.group_id = v_group_id and gm.user_id = v_user_id;

	if v_member_id is not null then
		return jsonb_build_object('success', true, 'groupId', v_group_id, 'groupName', v_group_name, 'message', 'Anda sudah bergabung dalam kegiatan ini.');
	end if;

	-- Check if there is an unlinked member with the claimed name
	select gm.id into v_existing_member_id
	from public.group_members gm
	join public.people p on p.id = gm.person_id
	where gm.group_id = v_group_id
	  and gm.user_id is null
	  and lower(p.name) = lower(v_clean_name)
	limit 1;

	if v_existing_member_id is not null then
		update public.group_members
		set user_id = v_user_id
		where id = v_existing_member_id;

		return jsonb_build_object('success', true, 'groupId', v_group_id, 'groupName', v_group_name, 'message', 'Berhasil bergabung dengan kegiatan!');
	end if;

	-- Create person owned by the group owner so all group members can see it
	insert into public.people (owner_id, name, note)
	values (v_group_owner_id, v_clean_name, 'Bergabung via kode undangan')
	returning id into v_new_person_id;

	insert into public.group_members (group_id, person_id, user_id, role)
	values (v_group_id, v_new_person_id, v_user_id, 'member')
	returning id into v_member_id;

	return jsonb_build_object('success', true, 'groupId', v_group_id, 'groupName', v_group_name, 'message', 'Berhasil bergabung dengan kegiatan!');
end;
$$;

revoke all on function public.join_group_with_code(text, text) from public, anon;
grant execute on function public.join_group_with_code(text, text) to authenticated;

