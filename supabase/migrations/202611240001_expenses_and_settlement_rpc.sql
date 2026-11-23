-- Migration: 202611240001_expenses_and_settlement_rpc.sql
-- Enables expense management, order submissions, atomic finalization, and settlement tracking

-- 1. Update RLS policies to allow group members to read relevant group data

drop policy if exists expenses_owner_read on public.expenses;
create policy expenses_participant_read on public.expenses
	for select to authenticated
	using (public.is_group_owner(group_id) or public.is_group_member(group_id));

drop policy if exists expense_payers_owner_read on public.expense_payers;
create policy expense_payers_participant_read on public.expense_payers
	for select to authenticated
	using (exists (
		select 1 from public.expenses e
		where e.id = expense_id and (public.is_group_owner(e.group_id) or public.is_group_member(e.group_id))
	));

drop policy if exists expense_shares_owner_read on public.expense_shares;
create policy expense_shares_participant_read on public.expense_shares
	for select to authenticated
	using (exists (
		select 1 from public.expenses e
		where e.id = expense_id and (public.is_group_owner(e.group_id) or public.is_group_member(e.group_id))
	));

drop policy if exists expense_items_owner_read on public.expense_items;
create policy expense_items_participant_read on public.expense_items
	for select to authenticated
	using (exists (
		select 1 from public.expenses e
		where e.id = expense_id and (public.is_group_owner(e.group_id) or public.is_group_member(e.group_id))
	));

drop policy if exists group_balances_owner_read on public.group_balances;
create policy group_balances_participant_read on public.group_balances
	for select to authenticated
	using (public.is_group_owner(group_id) or public.is_group_member(group_id));

drop policy if exists settlements_owner_read on public.settlements;
create policy settlements_participant_read on public.settlements
	for select to authenticated
	using (public.is_group_owner(group_id) or public.is_group_member(group_id));

-- Allow members to submit their own orders
create policy order_submissions_member_insert on public.order_submissions
	for insert to authenticated
	with check (
		exists (
			select 1 from public.group_members gm
			join public.groups g on g.id = gm.group_id
			where gm.id = member_id
			  and gm.group_id = order_submissions.group_id
			  and gm.user_id = (select auth.uid())
			  and g.status = 'active'
		)
	);

-- 2. RPC: create_expense
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
	p_items jsonb default '[]'::jsonb
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

	return v_expense_id;
end;
$$;

-- 3. RPC: delete_expense
create or replace function public.delete_expense(p_expense_id uuid)
returns void
language plpgsql
security definer
set search_path = ''
as $$
declare
	v_group_id uuid;
begin
	select group_id into v_group_id
	from public.expenses
	where id = p_expense_id;

	if v_group_id is null then
		raise exception 'Pengeluaran tidak ditemukan.' using errcode = '22023';
	end if;

	if not public.is_group_owner(v_group_id) then
		raise exception 'Hanya owner grup yang dapat menghapus pengeluaran.' using errcode = '42501';
	end if;

	if not exists (select 1 from public.groups where id = v_group_id and status = 'active') then
		raise exception 'Tidak dapat menghapus pengeluaran pada kegiatan yang sudah selesai.' using errcode = '22023';
	end if;

	delete from public.expenses where id = p_expense_id;
end;
$$;

-- 4. RPC: submit_order
create or replace function public.submit_order(
	p_group_id uuid,
	p_member_id uuid,
	p_item_name text,
	p_unit_price bigint,
	p_qty integer,
	p_note text default null
)
returns uuid
language plpgsql
security definer
set search_path = ''
as $$
declare
	v_submission_id uuid := gen_random_uuid();
begin
	if not exists (
		select 1 from public.groups where id = p_group_id and status = 'active'
	) then
		raise exception 'Kegiatan sudah selesai atau tidak aktif.' using errcode = '22023';
	end if;

	if not exists (
		select 1 from public.group_members gm
		where gm.id = p_member_id
		  and gm.group_id = p_group_id
		  and (gm.user_id = auth.uid() or public.is_group_owner(p_group_id))
	) then
		raise exception 'Anda tidak memiliki wewenang mengirim pesanan untuk anggota ini.' using errcode = '42501';
	end if;

	if nullif(btrim(p_item_name), '') is null or p_unit_price <= 0 or p_qty <= 0 then
		raise exception 'Nama item, harga satuan, dan jumlah pesanan wajib valid.' using errcode = '22023';
	end if;

	insert into public.order_submissions (
		id, group_id, member_id, item_name, unit_price, qty, note, status
	)
	values (
		v_submission_id, p_group_id, p_member_id, btrim(p_item_name), p_unit_price, p_qty, nullif(btrim(p_note), ''), 'submitted'
	);

	return v_submission_id;
end;
$$;

-- 5. RPC: review_order_submission
create or replace function public.review_order_submission(
	p_submission_id uuid,
	p_approve boolean
)
returns void
language plpgsql
security definer
set search_path = ''
as $$
declare
	v_group_id uuid;
begin
	select group_id into v_group_id
	from public.order_submissions
	where id = p_submission_id and status = 'submitted';

	if v_group_id is null then
		raise exception 'Pengajuan pesanan tidak ditemukan atau sudah ditinjau.' using errcode = '22023';
	end if;

	if not public.is_group_owner(v_group_id) then
		raise exception 'Hanya owner grup yang dapat meninjau pesanan.' using errcode = '42501';
	end if;

	update public.order_submissions
	set
		status = case when p_approve then 'approved' else 'rejected' end,
		reviewed_by = auth.uid(),
		reviewed_at = now()
	where id = p_submission_id;
end;
$$;

-- 6. RPC: finalize_group_settlement (Atomic finalization)
create or replace function public.finalize_group_settlement(p_group_id uuid)
returns jsonb
language plpgsql
security definer
set search_path = ''
as $$
declare
	v_member record;
	v_total_paid bigint;
	v_total_owed bigint;
	v_net_sum bigint := 0;
	v_expense_count integer;

	-- Greedy settlement variables
	type_member_balance record;
	v_debtors record;
	v_creditors record;
	v_transfer_amount bigint;
	v_settlements_count integer := 0;
begin
	if not public.is_group_owner(p_group_id) then
		raise exception 'Hanya owner grup yang dapat menyelesaikan kegiatan.' using errcode = '42501';
	end if;

	if not exists (select 1 from public.groups where id = p_group_id and status = 'active') then
		raise exception 'Kegiatan sudah selesai atau tidak aktif.' using errcode = '22023';
	end if;

	select count(*) into v_expense_count
	from public.expenses where group_id = p_group_id;

	if v_expense_count = 0 then
		raise exception 'Kegiatan belum memiliki pengeluaran untuk difinalisasi.' using errcode = '22023';
	end if;

	-- Delete any existing balances/settlements if re-calculating
	delete from public.settlements where group_id = p_group_id;
	delete from public.group_balances where group_id = p_group_id;

	-- Calculate paid, owed, and balance for each group member
	for v_member in
		select gm.id as member_id, gm.created_at
		from public.group_members gm
		where gm.group_id = p_group_id
		order by gm.created_at, gm.id
	loop
		select coalesce(sum(p.amount), 0) into v_total_paid
		from public.expense_payers p
		join public.expenses e on e.id = p.expense_id
		where e.group_id = p_group_id and p.member_id = v_member.member_id;

		select coalesce(sum(s.amount), 0) into v_total_owed
		from public.expense_shares s
		join public.expenses e on e.id = s.expense_id
		where e.group_id = p_group_id and s.member_id = v_member.member_id;

		v_net_sum := v_net_sum + (v_total_paid - v_total_owed);

		insert into public.group_balances (group_id, member_id, paid, owed, balance)
		values (p_group_id, v_member.member_id, v_total_paid, v_total_owed, v_total_paid - v_total_owed);
	end loop;

	if v_net_sum <> 0 then
		raise exception 'Total saldo tidak seimbang (selisih Rp%). Periksa kembali pengeluaran.', v_net_sum using errcode = '22023';
	end if;

	-- Greedy settlement algorithm in temporary tables
	create temp table if not exists temp_debtors (
		member_id uuid primary key,
		remaining bigint not null,
		join_order timestamptz not null
	) on commit drop;
	truncate temp_debtors;

	create temp table if not exists temp_creditors (
		member_id uuid primary key,
		remaining bigint not null,
		join_order timestamptz not null
	) on commit drop;
	truncate temp_creditors;

	insert into temp_debtors (member_id, remaining, join_order)
	select b.member_id, -b.balance, gm.created_at
	from public.group_balances b
	join public.group_members gm on gm.id = b.member_id
	where b.group_id = p_group_id and b.balance < 0;

	insert into temp_creditors (member_id, remaining, join_order)
	select b.member_id, b.balance, gm.created_at
	from public.group_balances b
	join public.group_members gm on gm.id = b.member_id
	where b.group_id = p_group_id and b.balance > 0;

	-- Match debtors and creditors
	loop
		select * into v_debtors
		from temp_debtors
		where remaining > 0
		order by remaining desc, join_order asc, member_id asc
		limit 1;

		select * into v_creditors
		from temp_creditors
		where remaining > 0
		order by remaining desc, join_order asc, member_id asc
		limit 1;

		exit when v_debtors is null or v_creditors is null;

		v_transfer_amount := least(v_debtors.remaining, v_creditors.remaining);

		insert into public.settlements (group_id, from_member_id, to_member_id, amount, status)
		values (p_group_id, v_debtors.member_id, v_creditors.member_id, v_transfer_amount, 'pending');

		update temp_debtors
		set remaining = remaining - v_transfer_amount
		where member_id = v_debtors.member_id;

		update temp_creditors
		set remaining = remaining - v_transfer_amount
		where member_id = v_creditors.member_id;

		v_settlements_count := v_settlements_count + 1;
	end loop;

	-- Mark group as completed
	update public.groups
	set status = 'completed', finalized_at = now()
	where id = p_group_id;

	return jsonb_build_object(
		'success', true,
		'settlementsCount', v_settlements_count,
		'finalizedAt', now()
	);
end;
$$;

-- 7. RPC: mark_settlement_paid
create or replace function public.mark_settlement_paid(p_settlement_id uuid)
returns void
language plpgsql
security definer
set search_path = ''
as $$
declare
	v_settlement public.settlements%rowtype;
begin
	select * into v_settlement
	from public.settlements
	where id = p_settlement_id;

	if v_settlement.id is null then
		raise exception 'Catatan transfer tidak ditemukan.' using errcode = '22023';
	end if;

	if not (
		public.is_group_owner(v_settlement.group_id)
		or exists (
			select 1 from public.group_members gm
			where gm.id in (v_settlement.from_member_id, v_settlement.to_member_id)
			  and gm.user_id = auth.uid()
		)
	) then
		raise exception 'Anda tidak memiliki hak untuk memperbarui status transfer ini.' using errcode = '42501';
	end if;

	update public.settlements
	set status = 'marked', marked_at = now()
	where id = p_settlement_id and status = 'pending';
end;
$$;

-- 8. RPC: confirm_settlement_payment
create or replace function public.confirm_settlement_payment(p_settlement_id uuid)
returns void
language plpgsql
security definer
set search_path = ''
as $$
declare
	v_settlement public.settlements%rowtype;
begin
	select * into v_settlement
	from public.settlements
	where id = p_settlement_id;

	if v_settlement.id is null then
		raise exception 'Catatan transfer tidak ditemukan.' using errcode = '22023';
	end if;

	if not (
		public.is_group_owner(v_settlement.group_id)
		or exists (
			select 1 from public.group_members gm
			where gm.id = v_settlement.to_member_id
			  and gm.user_id = auth.uid()
		)
	) then
		raise exception 'Hanya penerima dana atau owner yang dapat mengonfirmasi pembayaran.' using errcode = '42501';
	end if;

	update public.settlements
	set status = 'confirmed', confirmed_at = now(), confirmed_by = auth.uid()
	where id = p_settlement_id;
end;
$$;

-- Permissions
revoke all on function public.create_expense(uuid, text, bigint, bigint, date, text, text, jsonb, jsonb, jsonb) from public, anon;
revoke all on function public.delete_expense(uuid) from public, anon;
revoke all on function public.submit_order(uuid, uuid, text, bigint, integer, text) from public, anon;
revoke all on function public.review_order_submission(uuid, boolean) from public, anon;
revoke all on function public.finalize_group_settlement(uuid) from public, anon;
revoke all on function public.mark_settlement_paid(uuid) from public, anon;
revoke all on function public.confirm_settlement_payment(uuid) from public, anon;

grant execute on function public.create_expense(uuid, text, bigint, bigint, date, text, text, jsonb, jsonb, jsonb) to authenticated;
grant execute on function public.delete_expense(uuid) to authenticated;
grant execute on function public.submit_order(uuid, uuid, text, bigint, integer, text) to authenticated;
grant execute on function public.review_order_submission(uuid, boolean) to authenticated;
grant execute on function public.finalize_group_settlement(uuid) to authenticated;
grant execute on function public.mark_settlement_paid(uuid) to authenticated;
grant execute on function public.confirm_settlement_payment(uuid) to authenticated;

