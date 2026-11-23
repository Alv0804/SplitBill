-- Migration: 202611250002_unique_member_names.sql
-- Enforces unique member names per group and updates join_group_with_code RPC

-- 1. Trigger function to enforce unique member names (case-insensitive) per group
create or replace function public.check_group_member_name_unique()
returns trigger
language plpgsql
security definer
set search_path = ''
as $$
declare
    v_name text;
    v_dup_id uuid;
begin
    select lower(btrim(name)) into v_name
    from public.people
    where id = new.person_id;

    if v_name is not null then
        select gm.id into v_dup_id
        from public.group_members gm
        join public.people p on p.id = gm.person_id
        where gm.group_id = new.group_id
          and gm.id <> coalesce(new.id, '00000000-0000-0000-0000-000000000000'::uuid)
          and lower(btrim(p.name)) = v_name
        limit 1;

        if v_dup_id is not null then
            raise exception 'Nama anggota "%" sudah ada di dalam kegiatan ini. Nama anggota dalam satu kegiatan tidak boleh sama.', (select name from public.people where id = new.person_id);
        end if;
    end if;

    return new;
end;
$$;

drop trigger if exists trg_check_group_member_name_unique on public.group_members;
create trigger trg_check_group_member_name_unique
before insert or update on public.group_members
for each row
execute function public.check_group_member_name_unique();

-- 2. Update join_group_with_code RPC to handle duplicate names & claim logic cleanly
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
	v_existing_member_user_id uuid;
	v_my_member_id uuid;
	v_my_member_name text;
	v_new_person_id uuid;
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

	if length(v_clean_name) < 2 then
		return jsonb_build_object('success', false, 'message', 'Nama anggota minimal 2 karakter.');
	end if;

	-- Find active group by invite code
	select g.id, g.name, g.owner_id into v_group_id, v_group_name, v_group_owner_id
	from public.groups g
	where g.invite_code = v_clean_code
	  and g.invite_enabled = true
	  and g.status = 'active';

	if v_group_id is null then
		return jsonb_build_object('success', false, 'message', 'Kode undangan tidak valid atau kegiatan sudah tidak aktif.');
	end if;

	-- A. Check if this authenticated user is ALREADY a member of this group
	select gm.id, p.name into v_my_member_id, v_my_member_name
	from public.group_members gm
	join public.people p on p.id = gm.person_id
	where gm.group_id = v_group_id and gm.user_id = v_user_id
	limit 1;

	if v_my_member_id is not null then
		return jsonb_build_object(
			'success', true,
			'groupId', v_group_id,
			'groupName', v_group_name,
			'message', 'Anda sudah terdaftar dalam kegiatan ini sebagai "' || v_my_member_name || '".'
		);
	end if;

	-- B. Check if ANY member in this group already has this name (case-insensitive)
	select gm.id, gm.user_id into v_existing_member_id, v_existing_member_user_id
	from public.group_members gm
	join public.people p on p.id = gm.person_id
	where gm.group_id = v_group_id
	  and lower(btrim(p.name)) = lower(v_clean_name)
	limit 1;

	if v_existing_member_id is not null then
		-- If this member is already claimed by another user:
		if v_existing_member_user_id is not null then
			return jsonb_build_object(
				'success', false,
				'message', 'Nama "' || v_clean_name || '" sudah digunakan oleh anggota lain di kegiatan ini. Silakan gunakan nama panggilan atau inisial yang berbeda (contoh: ' || v_clean_name || ' 2).'
			);
		end if;

		-- If this member was added by the owner as an unlinked placeholder:
		-- The invited person successfully claims this spot!
		update public.group_members
		set user_id = v_user_id
		where id = v_existing_member_id;

		return jsonb_build_object(
			'success', true,
			'groupId', v_group_id,
			'groupName', v_group_name,
			'message', 'Selamat bergabung! Anda terhubung ke anggota "' || v_clean_name || '".'
		);
	end if;

	-- C. Name does not exist yet in this group: check or create person, then add as new member
	select p.id into v_new_person_id
	from public.people p
	where p.owner_id = v_group_owner_id
	  and lower(btrim(p.name)) = lower(v_clean_name)
	limit 1;

	if v_new_person_id is null then
		insert into public.people (owner_id, name, note)
		values (v_group_owner_id, v_clean_name, 'Bergabung via kode undangan')
		returning id into v_new_person_id;
	end if;

	insert into public.group_members (group_id, person_id, user_id, role)
	values (v_group_id, v_new_person_id, v_user_id, 'member');

	return jsonb_build_object(
		'success', true,
		'groupId', v_group_id,
		'groupName', v_group_name,
		'message', 'Selamat datang! Anda berhasil bergabung ke kegiatan "' || v_group_name || '" sebagai "' || v_clean_name || '".'
	);
end;
$$;

revoke all on function public.join_group_with_code(text, text) from public, anon;
grant execute on function public.join_group_with_code(text, text) to authenticated;

