-- Migration: 202611250004_link_orders_to_expense.sql
-- Links order submissions to expenses so billed orders disappear from unbilled orders and bill creation options

-- 1. Create or replace public.link_orders_to_expense RPC
create or replace function public.link_orders_to_expense(p_expense_id uuid, p_order_ids uuid[])
returns void
language plpgsql
security definer
set search_path = ''
as $$
begin
	if not exists (select 1 from public.expenses where id = p_expense_id and public.is_group_owner(group_id)) then
		raise exception 'Pengeluaran tidak ditemukan atau Anda bukan owner.' using errcode = '42501';
	end if;

	if p_order_ids is not null and array_length(p_order_ids, 1) > 0 then
		update public.order_submissions
		set expense_id = p_expense_id
		where id = any(p_order_ids);
	end if;
end;
$$;

revoke all on function public.link_orders_to_expense(uuid, uuid[]) from public, anon;
grant execute on function public.link_orders_to_expense(uuid, uuid[]) to authenticated;

-- 2. Update create_expense RPC to accept p_order_ids optionally
create or replace function public.create_expense(
	p_group_id uuid,
	p_name text,
	p_total_amount bigint,
	p_adjustment_amount bigint,
	p_expense_date date,
	p_split_method text,
	p_note text,
	p_payers jsonb,
	p_shares jsonb,
	p_items jsonb default '[]'::jsonb,
	p_order_ids uuid[] default null
)
returns uuid
language plpgsql
security definer
set search_path = ''
as $$
declare
	v_expense_id uuid := gen_random_uuid();
	v_payer record;
	v_share record;
	v_item record;
	v_sum_payers bigint := 0;
	v_sum_shares bigint := 0;
begin
	if not public.is_group_owner(p_group_id) then
		raise exception 'Hanya owner grup yang dapat menambahkan pengeluaran.' using errcode = '42501';
	end if;

	if not exists (select 1 from public.groups where id = p_group_id and status = 'active') then
		raise exception 'Pengeluaran hanya dapat ditambahkan pada kegiatan yang aktif.' using errcode = '22023';
	end if;

	if nullif(btrim(p_name), '') is null then
		raise exception 'Nama pengeluaran wajib diisi.' using errcode = '22023';
	end if;

	if p_total_amount <= 0 then
		raise exception 'Total pengeluaran harus lebih dari Rp0.' using errcode = '22023';
	end if;

	if p_split_method not in ('equal', 'order', 'percentage', 'fixed') then
		raise exception 'Metode pembagian tidak valid.' using errcode = '22023';
	end if;

	-- Insert expense header
	insert into public.expenses (
		id, group_id, name, total_amount, adjustment_amount, expense_date, split_method, note, created_by
	)
	values (
		v_expense_id, p_group_id, btrim(p_name), p_total_amount, coalesce(p_adjustment_amount, 0),
		p_expense_date, p_split_method, nullif(btrim(p_note), ''), auth.uid()
	);

	-- Insert payers
	for v_payer in
		select
			(elem->>'member_id')::uuid as member_id,
			(elem->>'amount')::bigint as amount
		from jsonb_array_elements(p_payers) as elem
	loop
		if not exists (select 1 from public.group_members where id = v_payer.member_id and group_id = p_group_id) then
			raise exception 'Pembayar bukan anggota kegiatan ini.' using errcode = '22023';
		end if;
		if v_payer.amount <= 0 then
			raise exception 'Nominal pembayaran harus lebih dari Rp0.' using errcode = '22023';
		end if;
		v_sum_payers := v_sum_payers + v_payer.amount;

		insert into public.expense_payers (expense_id, member_id, amount)
		values (v_expense_id, v_payer.member_id, v_payer.amount);
	end loop;

	if v_sum_payers <> p_total_amount then
		raise exception 'Total pembayaran (Rp%) tidak sama dengan total struk (Rp%).', v_sum_payers, p_total_amount using errcode = '22023';
	end if;

	-- Insert shares
	for v_share in
		select
			(elem->>'member_id')::uuid as member_id,
			(elem->>'amount')::bigint as amount,
			case when elem ? 'percent' and (elem->>'percent') is not null
				 then (elem->>'percent')::numeric(5, 2)
				 else null
			end as percent
		from jsonb_array_elements(p_shares) as elem
	loop
		if not exists (select 1 from public.group_members where id = v_share.member_id and group_id = p_group_id) then
			raise exception 'Penerima tanggungan bukan anggota kegiatan ini.' using errcode = '22023';
		end if;
		if v_share.amount < 0 then
			raise exception 'Nominal tanggungan tidak boleh negatif.' using errcode = '22023';
		end if;
		v_sum_shares := v_sum_shares + v_share.amount;

		insert into public.expense_shares (expense_id, member_id, amount, percent)
		values (v_expense_id, v_share.member_id, v_share.amount, v_share.percent);
	end loop;

	if v_sum_shares <> p_total_amount then
		raise exception 'Total pembagian tanggungan (Rp%) tidak sama dengan total struk (Rp%).', v_sum_shares, p_total_amount using errcode = '22023';
	end if;

	-- Insert line items if present
	if p_items is not null and jsonb_array_length(p_items) > 0 then
		for v_item in
			select
				(elem->>'member_id')::uuid as member_id,
				btrim(elem->>'name') as name,
				(elem->>'unit_price')::bigint as unit_price,
				(elem->>'qty')::integer as qty
			from jsonb_array_elements(p_items) as elem
		loop
			if not exists (select 1 from public.group_members where id = v_item.member_id and group_id = p_group_id) then
				raise exception 'Pemilik item bukan anggota kegiatan ini.' using errcode = '22023';
			end if;
			if nullif(v_item.name, '') is null or v_item.unit_price <= 0 or v_item.qty <= 0 then
				raise exception 'Rincian item tidak valid.' using errcode = '22023';
			end if;

			insert into public.expense_items (expense_id, member_id, name, unit_price, qty)
			values (v_expense_id, v_item.member_id, v_item.name, v_item.unit_price, v_item.qty);
		end loop;
	end if;

	-- Link order submissions to this expense if provided
	if p_order_ids is not null and array_length(p_order_ids, 1) > 0 then
		update public.order_submissions
		set expense_id = v_expense_id
		where id = any(p_order_ids) and group_id = p_group_id;
	end if;

	return v_expense_id;
end;
$$;

revoke all on function public.create_expense(uuid, text, bigint, bigint, date, text, text, jsonb, jsonb, jsonb, uuid[]) from public, anon;
grant execute on function public.create_expense(uuid, text, bigint, bigint, date, text, text, jsonb, jsonb, jsonb, uuid[]) to authenticated;

-- 3. Retroactively link past billed orders in existing groups
update public.order_submissions
set expense_id = 'a7a64646-1df4-4ac9-99be-274aae1e2c45'
where id in (
	'87779926-a973-4998-baef-a4a5ae2d48da',
	'3e167fbc-2b4b-4acd-ba3f-d7b7d24cb5b5',
	'f929b803-2435-4d1a-a61f-30b03843de6b'
);

