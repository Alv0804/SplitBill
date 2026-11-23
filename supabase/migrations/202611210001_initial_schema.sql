create table public.profiles (
	id uuid primary key references auth.users (id) on delete cascade,
	display_name text not null check (length(btrim(display_name)) > 0),
	created_at timestamptz not null default now()
);

create table public.people (
	id uuid primary key default gen_random_uuid(),
	owner_id uuid not null references auth.users (id) on delete cascade,
	name text not null check (length(btrim(name)) > 0),
	note text,
	created_at timestamptz not null default now(),
	unique (owner_id, name)
);

create table public.places (
	id uuid primary key default gen_random_uuid(),
	owner_id uuid not null references auth.users (id) on delete cascade,
	name text not null check (length(btrim(name)) > 0),
	category text,
	address text,
	created_at timestamptz not null default now(),
	unique (owner_id, name)
);

create table public.groups (
	id uuid primary key default gen_random_uuid(),
	owner_id uuid not null references auth.users (id),
	type text not null check (type in ('hangout', 'trip', 'purchase_rental')),
	name text not null check (length(btrim(name)) > 0),
	event_date date not null,
	place_id uuid references public.places (id) on delete set null,
	status text not null default 'active' check (status in ('active', 'completed')),
	invite_code text not null unique check (invite_code ~ '^[A-Z0-9]{8}$'),
	invite_enabled boolean not null default true,
	finalized_at timestamptz,
	created_at timestamptz not null default now(),
	check ((status = 'active' and finalized_at is null) or (status = 'completed' and finalized_at is not null))
);

create table public.group_members (
	id uuid primary key default gen_random_uuid(),
	group_id uuid not null references public.groups (id) on delete cascade,
	person_id uuid not null references public.people (id),
	user_id uuid references auth.users (id) on delete set null,
	role text not null default 'member' check (role in ('owner', 'member')),
	created_at timestamptz not null default now(),
	unique (group_id, person_id),
	unique (id, group_id)
);

create unique index group_members_group_user_unique
	on public.group_members (group_id, user_id)
	where user_id is not null;

create table public.join_requests (
	id uuid primary key default gen_random_uuid(),
	group_id uuid not null references public.groups (id) on delete cascade,
	user_id uuid not null references auth.users (id) on delete cascade,
	claimed_member_id uuid,
	proposed_name text,
	status text not null default 'pending' check (status in ('pending', 'approved', 'rejected')),
	created_at timestamptz not null default now(),
	foreign key (claimed_member_id, group_id) references public.group_members (id, group_id),
	check (
		(claimed_member_id is not null and nullif(btrim(proposed_name), '') is null)
		or (claimed_member_id is null and nullif(btrim(proposed_name), '') is not null)
	)
);

create table public.expenses (
	id uuid primary key default gen_random_uuid(),
	group_id uuid not null references public.groups (id) on delete cascade,
	name text not null check (length(btrim(name)) > 0),
	total_amount bigint not null check (total_amount > 0),
	adjustment_amount bigint not null default 0,
	expense_date date not null,
	split_method text not null check (split_method in ('equal', 'order', 'percentage', 'fixed')),
	note text,
	created_by uuid not null references auth.users (id),
	created_at timestamptz not null default now(),
	unique (id, group_id)
);

create table public.expense_payers (
	id uuid primary key default gen_random_uuid(),
	expense_id uuid not null references public.expenses (id) on delete cascade,
	member_id uuid not null references public.group_members (id),
	amount bigint not null check (amount > 0),
	created_at timestamptz not null default now(),
	unique (expense_id, member_id)
);

create table public.expense_shares (
	id uuid primary key default gen_random_uuid(),
	expense_id uuid not null references public.expenses (id) on delete cascade,
	member_id uuid not null references public.group_members (id),
	amount bigint not null check (amount >= 0),
	percent numeric(5, 2) check (percent between 0 and 100),
	created_at timestamptz not null default now(),
	unique (expense_id, member_id)
);

create table public.expense_items (
	id uuid primary key default gen_random_uuid(),
	expense_id uuid not null references public.expenses (id) on delete cascade,
	member_id uuid not null references public.group_members (id),
	name text not null check (length(btrim(name)) > 0),
	unit_price bigint not null check (unit_price > 0),
	qty integer not null check (qty > 0),
	created_at timestamptz not null default now()
);

create table public.order_submissions (
	id uuid primary key default gen_random_uuid(),
	group_id uuid not null references public.groups (id) on delete cascade,
	member_id uuid not null references public.group_members (id),
	expense_id uuid references public.expenses (id) on delete set null,
	item_name text not null check (length(btrim(item_name)) > 0),
	unit_price bigint not null check (unit_price > 0),
	qty integer not null check (qty > 0),
	note text,
	status text not null default 'submitted' check (status in ('submitted', 'approved', 'rejected')),
	reviewed_by uuid references auth.users (id),
	reviewed_at timestamptz,
	created_at timestamptz not null default now()
);

create table public.group_balances (
	id uuid primary key default gen_random_uuid(),
	group_id uuid not null references public.groups (id) on delete cascade,
	member_id uuid not null references public.group_members (id),
	paid bigint not null check (paid >= 0),
	owed bigint not null check (owed >= 0),
	balance bigint not null,
	created_at timestamptz not null default now(),
	unique (group_id, member_id),
	check (balance = paid - owed)
);

create table public.settlements (
	id uuid primary key default gen_random_uuid(),
	group_id uuid not null references public.groups (id) on delete cascade,
	from_member_id uuid not null references public.group_members (id),
	to_member_id uuid not null references public.group_members (id),
	amount bigint not null check (amount > 0),
	status text not null default 'pending' check (status in ('pending', 'marked', 'confirmed')),
	marked_at timestamptz,
	confirmed_at timestamptz,
	confirmed_by uuid references auth.users (id),
	created_at timestamptz not null default now(),
	check (from_member_id <> to_member_id)
);

create function public.is_group_owner(p_group_id uuid)
returns boolean
language sql
stable
security definer
set search_path = ''
as $$
	select exists (
		select 1
		from public.groups g
		where g.id = p_group_id
		  and g.owner_id = auth.uid()
	);
$$;

create function public.is_group_member(p_group_id uuid)
returns boolean
language sql
stable
security definer
set search_path = ''
as $$
	select exists (
		select 1
		from public.group_members gm
		where gm.group_id = p_group_id
		  and gm.user_id = auth.uid()
	);
$$;

revoke all on function public.is_group_owner(uuid) from public, anon;
revoke all on function public.is_group_member(uuid) from public, anon;
grant execute on function public.is_group_owner(uuid) to authenticated;
grant execute on function public.is_group_member(uuid) to authenticated;

do $$
declare
	table_name text;
begin
	foreach table_name in array array[
		'profiles', 'people', 'places', 'groups', 'group_members', 'join_requests',
		'expenses', 'expense_payers', 'expense_shares', 'expense_items',
		'order_submissions', 'group_balances', 'settlements'
	] loop
		execute format('alter table public.%I enable row level security', table_name);
	end loop;
end;
$$;

create policy profiles_self_access on public.profiles
	for all to authenticated
	using (id = (select auth.uid()))
	with check (id = (select auth.uid()));

create policy people_owner_access on public.people
	for all to authenticated
	using (owner_id = (select auth.uid()))
	with check (owner_id = (select auth.uid()));

create policy places_owner_access on public.places
	for all to authenticated
	using (owner_id = (select auth.uid()))
	with check (owner_id = (select auth.uid()));

create policy groups_visible_to_participants on public.groups
	for select to authenticated
	using (owner_id = (select auth.uid()) or public.is_group_member(id));

create policy groups_owner_insert on public.groups
	for insert to authenticated
	with check (owner_id = (select auth.uid()) and status = 'active');

create policy groups_owner_update on public.groups
	for update to authenticated
	using (owner_id = (select auth.uid()) and status = 'active')
	with check (owner_id = (select auth.uid()) and status = 'active');

create policy group_members_self_read on public.group_members
	for select to authenticated
	using (user_id = (select auth.uid()));

create policy group_members_owner_access on public.group_members
	for all to authenticated
	using (
		public.is_group_owner(group_id)
		and exists (select 1 from public.groups g where g.id = group_id and g.status = 'active')
	)
	with check (
		public.is_group_owner(group_id)
		and exists (select 1 from public.groups g where g.id = group_id and g.status = 'active')
	);

create policy join_requests_visible_to_requester_or_owner on public.join_requests
	for select to authenticated
	using (user_id = (select auth.uid()) or public.is_group_owner(group_id));

create policy expenses_owner_read on public.expenses
	for select to authenticated
	using (public.is_group_owner(group_id));

create policy expense_payers_owner_read on public.expense_payers
	for select to authenticated
	using (exists (
		select 1 from public.expenses e
		where e.id = expense_id and public.is_group_owner(e.group_id)
	));

create policy expense_shares_owner_read on public.expense_shares
	for select to authenticated
	using (exists (
		select 1 from public.expenses e
		where e.id = expense_id and public.is_group_owner(e.group_id)
	));

create policy expense_items_owner_read on public.expense_items
	for select to authenticated
	using (exists (
		select 1 from public.expenses e
		where e.id = expense_id and public.is_group_owner(e.group_id)
	));

create policy order_submissions_self_or_owner_read on public.order_submissions
	for select to authenticated
	using (
		public.is_group_owner(group_id)
		or exists (
			select 1 from public.group_members gm
			where gm.id = member_id
			  and gm.group_id = order_submissions.group_id
			  and gm.user_id = (select auth.uid())
		)
	);

create policy group_balances_owner_read on public.group_balances
	for select to authenticated
	using (public.is_group_owner(group_id));

create policy settlements_owner_read on public.settlements
	for select to authenticated
	using (public.is_group_owner(group_id));
