do $$
declare
	v_owner_id uuid;
	v_group_id constant uuid := '00000000-0000-4000-8000-000000000001';
	v_expense_id constant uuid := '00000000-0000-4000-8000-000000000002';
	v_owner_person_id uuid;
	v_bima_person_id uuid;
	v_citra_person_id uuid;
	v_dimas_person_id uuid;
	v_place_id uuid;
	v_owner_member_id uuid;
	v_bima_member_id uuid;
	v_citra_member_id uuid;
	v_dimas_member_id uuid;
begin
	select u.id into v_owner_id
	from auth.users u
	where u.email = 'demo-owner@splitbill.local'
	limit 1;

	if v_owner_id is null then
		raise notice 'Create demo-owner@splitbill.local in local Supabase Auth, then run this seed script again.';
		return;
	end if;

	insert into public.profiles (id, display_name)
	values (v_owner_id, 'Demo Owner')
	on conflict (id) do update set display_name = excluded.display_name;

	insert into public.people (owner_id, name, note)
	values (v_owner_id, 'Ayu', 'Demo owner and group participant')
	on conflict (owner_id, name) do update set note = excluded.note
	returning id into v_owner_person_id;

	insert into public.people (owner_id, name, note)
	values (v_owner_id, 'Bima', 'Demo placeholder member')
	on conflict (owner_id, name) do update set note = excluded.note
	returning id into v_bima_person_id;

	insert into public.people (owner_id, name, note)
	values (v_owner_id, 'Citra', 'Demo placeholder member')
	on conflict (owner_id, name) do update set note = excluded.note
	returning id into v_citra_person_id;

	insert into public.people (owner_id, name, note)
	values (v_owner_id, 'Dimas', 'Demo placeholder member')
	on conflict (owner_id, name) do update set note = excluded.note
	returning id into v_dimas_person_id;

	insert into public.places (owner_id, name, category, address)
	values (v_owner_id, 'Rute Demo', 'Perjalanan', 'Alamat contoh')
	on conflict (owner_id, name) do update set category = excluded.category, address = excluded.address
	returning id into v_place_id;

	insert into public.groups (id, owner_id, type, name, event_date, place_id, invite_code)
	values (v_group_id, v_owner_id, 'trip', 'Perjalanan Demo', current_date, v_place_id, 'DEMO2026')
	on conflict (id) do update
		set owner_id = excluded.owner_id,
			type = excluded.type,
			name = excluded.name,
			event_date = excluded.event_date,
			place_id = excluded.place_id,
			status = 'active',
			invite_code = excluded.invite_code,
			invite_enabled = true,
			finalized_at = null;

	insert into public.group_members (group_id, person_id, user_id, role)
	values (v_group_id, v_owner_person_id, v_owner_id, 'owner')
	on conflict (group_id, person_id) do update set user_id = excluded.user_id, role = excluded.role
	returning id into v_owner_member_id;

	insert into public.group_members (group_id, person_id, role)
	values (v_group_id, v_bima_person_id, 'member')
	on conflict (group_id, person_id) do update set role = excluded.role
	returning id into v_bima_member_id;

	insert into public.group_members (group_id, person_id, role)
	values (v_group_id, v_citra_person_id, 'member')
	on conflict (group_id, person_id) do update set role = excluded.role
	returning id into v_citra_member_id;

	insert into public.group_members (group_id, person_id, role)
	values (v_group_id, v_dimas_person_id, 'member')
	on conflict (group_id, person_id) do update set role = excluded.role
	returning id into v_dimas_member_id;

	insert into public.expenses (id, group_id, name, total_amount, expense_date, split_method, created_by)
	values (v_expense_id, v_group_id, 'Sewa mobil', 500000, current_date, 'percentage', v_owner_id)
	on conflict (id) do update
		set name = excluded.name,
			total_amount = excluded.total_amount,
			expense_date = excluded.expense_date,
			split_method = excluded.split_method;

	insert into public.expense_payers (expense_id, member_id, amount)
	values
		(v_expense_id, v_citra_member_id, 300000),
		(v_expense_id, v_dimas_member_id, 200000)
	on conflict (expense_id, member_id) do update set amount = excluded.amount;

	insert into public.expense_shares (expense_id, member_id, amount, percent)
	values
		(v_expense_id, v_owner_member_id, 200000, 40.00),
		(v_expense_id, v_bima_member_id, 150000, 30.00),
		(v_expense_id, v_citra_member_id, 100000, 20.00),
		(v_expense_id, v_dimas_member_id, 50000, 10.00)
	on conflict (expense_id, member_id) do update
		set amount = excluded.amount, percent = excluded.percent;
end;
$$;
