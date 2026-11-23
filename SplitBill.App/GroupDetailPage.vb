Option Explicit On
Option Strict On
Option Infer On

Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports SplitBill.Data

Namespace Global.SplitBill.App
    Partial Class GroupDetailPage
        Private ReadOnly _repository As SplitBillRepository
        Private ReadOnly _session As SupabaseSession
        Private ReadOnly _groupId As Guid

        Private _group As GroupRecord
        Private _groupMembers As New List(Of GroupMemberRecord)()
        Private _expenses As New List(Of ExpenseRecord)()
        Private _orders As New List(Of OrderSubmissionRecord)()
        Private _balances As New List(Of GroupBalanceRecord)()
        Private _settlements As New List(Of SettlementRecord)()
        Private _loading As Boolean

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub New(repository As SplitBillRepository, session As SupabaseSession, groupId As Guid)
            Me.New()
            _repository = repository
            _session = session
            _groupId = groupId

            AddHandler BtnEditGroup.Click, AddressOf EditGroupClickedAsync
            AddHandler BtnCopyInvite.Click, AddressOf CopyInviteClicked
            AddHandler BtnRotateInvite.Click, AddressOf RotateInviteAsync
            AddHandler InviteEnabledCheck.CheckedChanged, AddressOf InviteEnabledChangedAsync
            AddHandler BtnAddMember.Click, AddressOf AddMemberClickedAsync
            AddHandler BtnRemoveMember.Click, AddressOf RemoveSelectedMemberAsync
            AddHandler BtnReloadMembers.Click, AddressOf ReloadButtonClicked

            AddHandler BtnSubmitOrder.Click, AddressOf SubmitOrderClickedAsync
            AddHandler BtnApproveOrder.Click, Sub(s, a) ReviewOrderClickedAsync(True)
            AddHandler BtnRejectOrder.Click, Sub(s, a) ReviewOrderClickedAsync(False)
            AddHandler BtnReloadOrders.Click, AddressOf ReloadButtonClicked

            AddHandler ExpensesListBox.SelectedIndexChanged, AddressOf ExpenseSelectedChangedAsync
            AddHandler BtnBillFromOrders.Click, AddressOf BillFromOrdersClickedAsync
            AddHandler BtnAddExpense.Click, AddressOf AddExpenseClickedAsync
            AddHandler BtnDeleteExpense.Click, AddressOf DeleteExpenseClickedAsync
            AddHandler BtnReloadExpenses.Click, AddressOf ReloadButtonClicked

            AddHandler BtnFinalize.Click, AddressOf FinalizeSettlementClickedAsync
            AddHandler BtnMarkPaid.Click, AddressOf MarkSettlementPaidClickedAsync
            AddHandler BtnConfirmPaid.Click, AddressOf ConfirmSettlementPaidClickedAsync
            AddHandler BtnReloadSettlements.Click, AddressOf ReloadButtonClicked

            AddHandler BtnApproveRequest.Click, Sub(s, a) ReviewSelectedRequestAsync(True)
            AddHandler BtnRejectRequest.Click, Sub(s, a) ReviewSelectedRequestAsync(False)

            AddHandler Load, AddressOf LoadAsync
        End Sub

        Private Sub CopyInviteClicked(sender As Object, e As EventArgs)
            If _group IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(_group.InviteCode) Then
                Clipboard.SetText(_group.InviteCode)
                MessageBox.Show($"Kode undangan '{_group.InviteCode}' berhasil disalin ke clipboard! Bagikan kode ini ke teman Anda.", "Kode Disalin", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Sub

        Private Async Sub LoadAsync(sender As Object, e As EventArgs)
            Await ReloadAsync()
        End Sub

        Private Async Sub ReloadButtonClicked(sender As Object, e As EventArgs)
            Await ReloadAsync()
        End Sub

        Private Async Function ReloadAsync() As Task
            If _repository Is Nothing OrElse _session Is Nothing Then Return
            Try
                _loading = True
                StatusLabel.Text = "Memuat data grup..."
                _group = Await _repository.GetGroupAsync(_session, _groupId, CancellationToken.None)
                If _group Is Nothing Then Throw New InvalidOperationException("Grup tidak ditemukan atau Anda tidak memiliki akses.")
                Dim isOwner = _group.OwnerId = _session.UserId
                Dim isActive = _group.Status = "active"

                TitleLabel.Text = _group.Name
                SubtitleLabel.Text = $"{FormatType(_group.Type)} · {_group.EventDate:dd MMMM yyyy} · {If(isActive, "Aktif", "Selesai (Telah Difinalisasi)")}"
                BtnEditGroup.Visible = isOwner AndAlso isActive
                BtnAddMember.Visible = isOwner AndAlso isActive
                BtnRemoveMember.Visible = isOwner AndAlso isActive

                ' Invite controls: strictly Owner only
                InviteBarFlow.Visible = isOwner
                BtnCopyInvite.Visible = isOwner
                BtnRotateInvite.Visible = isOwner
                InviteLabel.Visible = isOwner
                InviteEnabledCheck.Visible = isOwner
                InviteEnabledCheck.Checked = _group.InviteEnabled
                InviteLabel.Text = If(_group.InviteEnabled, $"Kode: {_group.InviteCode}", "Undangan dinonaktifkan")
                InviteEnabledCheck.Enabled = isOwner AndAlso isActive

                If isOwner Then
                    MembersLayout.RowStyles(0).Height = 56.0F
                Else
                    MembersLayout.RowStyles(0).Height = 0F
                End If

                ' Requests tab: strictly Owner only
                If isOwner Then
                    If Not TabsControl.TabPages.Contains(RequestsTab) Then TabsControl.TabPages.Add(RequestsTab)
                Else
                    If TabsControl.TabPages.Contains(RequestsTab) Then TabsControl.TabPages.Remove(RequestsTab)
                End If

                BtnBillFromOrders.Visible = isOwner AndAlso isActive
                BtnAddExpense.Visible = isOwner AndAlso isActive
                BtnDeleteExpense.Visible = isOwner AndAlso isActive
                BtnSubmitOrder.Visible = isActive
                BtnApproveOrder.Visible = isOwner AndAlso isActive
                BtnRejectOrder.Visible = isOwner AndAlso isActive

                ' 1. Members
                MembersListBox.Items.Clear()
                _groupMembers = Await _repository.GetGroupMembersAsync(_session, _groupId, CancellationToken.None)
                For Each member In _groupMembers
                    MembersListBox.Items.Add(member)
                Next

                ' 2. Join requests
                RequestsListBox.Items.Clear()
                If isOwner AndAlso isActive Then
                    For Each request In Await _repository.GetPendingJoinRequestsAsync(_session, _groupId, CancellationToken.None)
                        RequestsListBox.Items.Add(request)
                    Next
                End If

                ' 3. Expenses
                ExpensesListBox.Items.Clear()
                ExpenseDetailsTextBox.Clear()
                _expenses = Await _repository.GetExpensesAsync(_session, _groupId, CancellationToken.None)
                For Each exp In _expenses
                    ExpensesListBox.Items.Add(exp)
                Next

                ' 4. Orders (hanya tampilkan pesanan yang belum ditagihkan ke pembayaran)
                OrdersListBox.Items.Clear()
                _orders = Await _repository.GetOrderSubmissionsAsync(_session, _groupId, CancellationToken.None)
                Dim unbilledCount = 0
                For Each ord In _orders
                    If Not ord.ExpenseId.HasValue Then
                        unbilledCount += 1
                        Dim memberName = GetMemberName(ord.MemberId)
                        OrdersListBox.Items.Add(New OrderListItem(ord, $"{ord.ItemName} x{ord.Qty} (Rp{ord.UnitPrice:N0}) — {memberName} [{FormatOrderStatus(ord.Status)}]"))
                    End If
                Next
                If unbilledCount = 0 Then
                    If _orders.Count > 0 Then
                        OrdersListBox.Items.Add("Semua pesanan sebelumnya telah berhasil ditagihkan ke pembayaran.")
                    Else
                        OrdersListBox.Items.Add("Belum ada pesanan menu. Anggota dapat menambahkan pesanan dengan tombol di bawah.")
                    End If
                End If

                ' 5. Balances & Settlements (Role-based visibility)
                BalancesListBox.Items.Clear()
                SettlementsListBox.Items.Clear()
                _balances = Await _repository.GetGroupBalancesAsync(_session, _groupId, CancellationToken.None)

                If isOwner Then
                    BalanceHeaderLabel.Text = "Rekap Saldo Anggota"
                    For Each b In _balances
                        Dim memberName = GetMemberName(b.MemberId)
                        Dim saldoLabel = If(b.Balance > 0, $"+Rp{b.Balance:N0} (Piutang)", If(b.Balance < 0, $"-Rp{-b.Balance:N0} (Hutang)", "Rp0 (Lunas)"))
                        BalancesListBox.Items.Add($"{memberName} | Bayar: Rp{b.Paid:N0} | Tanggungan: Rp{b.Owed:N0} | Saldo: {saldoLabel}")
                    Next
                Else
                    BalanceHeaderLabel.Text = "Saldo Belum Lunas"
                    Dim hasActiveBalance = False
                    For Each b In _balances
                        ' Sembunyikan saldo yang sudah 0 / lunas untuk member biasa
                        If b.Balance <> 0 Then
                            hasActiveBalance = True
                            Dim memberName = GetMemberName(b.MemberId)
                            Dim saldoLabel = If(b.Balance > 0, $"+Rp{b.Balance:N0} (Piutang)", $"-Rp{-b.Balance:N0} (Hutang)")
                            BalancesListBox.Items.Add($"{memberName} | Saldo: {saldoLabel}")
                        End If
                    Next
                    If Not hasActiveBalance Then
                        BalancesListBox.Items.Add("Semua saldo kegiatan telah lunas / selesai.")
                    End If
                End If

                _settlements = Await _repository.GetSettlementsAsync(_session, _groupId, CancellationToken.None)
                Dim hasSettlements = _settlements IsNot Nothing AndAlso _settlements.Count > 0

                ' Finalize button: only owner, and only when active
                BtnFinalize.Visible = isOwner AndAlso isActive

                ' Mark paid button: visible whenever settlements exist
                BtnMarkPaid.Visible = hasSettlements
                If isOwner Then
                    BtnMarkPaid.Text = "✓ Tandai Sudah Bayar"
                Else
                    BtnMarkPaid.Text = "✓ Saya Sudah Bayar"
                End If

                ' Confirm paid button: only owner, when settlements exist
                BtnConfirmPaid.Visible = isOwner AndAlso hasSettlements

                If isOwner Then
                    TransferHeaderLabel.Text = "Rekomendasi Transfer & Konfirmasi Pembayaran"
                    For Each s In _settlements
                        Dim fromName = GetMemberName(s.FromMemberId)
                        Dim toName = GetMemberName(s.ToMemberId)
                        SettlementsListBox.Items.Add(New SettlementListItem(s, $"{fromName}  ->  {toName} : Rp{s.Amount:N0} [{FormatSettlementStatus(s.Status)}]"))
                    Next
                    If _settlements.Count = 0 Then
                        If isActive Then
                            SettlementsListBox.Items.Add("Kegiatan masih aktif. Klik '⚡ Selesaikan & Kunci Tagihan' di bawah setelah semua pengeluaran selesai dicatat.")
                        Else
                            SettlementsListBox.Items.Add("Belum ada transfer pembayaran yang perlu diselesaikan.")
                        End If
                    End If
                Else
                    TransferHeaderLabel.Text = "Tagihan Yang Harus Dibayar"
                    Dim myMember = _groupMembers.FirstOrDefault(Function(m) m.UserId.HasValue AndAlso m.UserId.Value = _session.UserId)
                    Dim myMemberId = If(myMember IsNot Nothing, myMember.Id, Guid.Empty)

                    Dim pendingCount = 0
                    For Each s In _settlements
                        ' Pada tampilan member: Cukup tampilkan tagihan yang harus dibayar oleh member ini yang masih berstatus 'pending'
                        If String.Equals(s.Status, "pending", StringComparison.OrdinalIgnoreCase) Then
                            If myMemberId = Guid.Empty OrElse s.FromMemberId = myMemberId Then
                                pendingCount += 1
                                Dim fromName = GetMemberName(s.FromMemberId)
                                Dim toName = GetMemberName(s.ToMemberId)
                                SettlementsListBox.Items.Add(New SettlementListItem(s, $"{fromName}  ->  {toName} : Rp{s.Amount:N0} [Belum Dibayar]"))
                            End If
                        End If
                    Next
                    If pendingCount = 0 Then
                        If isActive Then
                            SettlementsListBox.Items.Add("Kegiatan masih berlangsung. Pemilik kegiatan belum mengunci tagihan akhir.")
                        Else
                            SettlementsListBox.Items.Add("Tidak ada tagihan yang harus dibayar. Tagihan Anda sudah ditransfer atau lunas.")
                        End If
                    End If
                End If

                StatusLabel.Text = String.Empty
                StatusLabel.ForeColor = UiTheme.MutedTextColor
            Catch ex As Exception
                StatusLabel.Text = ex.Message
                StatusLabel.ForeColor = UiTheme.ErrorColor
            Finally
                _loading = False
            End Try
        End Function

        Private Async Sub ExpenseSelectedChangedAsync(sender As Object, e As EventArgs)
            Dim exp = TryCast(ExpensesListBox.SelectedItem, ExpenseRecord)
            If exp Is Nothing Then
                ExpenseDetailsTextBox.Clear()
                Return
            End If

            Try
                ExpenseDetailsTextBox.Text = "Memuat rincian..."
                Dim payers = Await _repository.GetExpensePayersAsync(_session, exp.Id, CancellationToken.None)
                Dim shares = Await _repository.GetExpenseSharesAsync(_session, exp.Id, CancellationToken.None)
                Dim items = Await _repository.GetExpenseItemsAsync(_session, exp.Id, CancellationToken.None)

                Dim sb As New StringBuilder()
                sb.AppendLine($"PENGELUARAN: {exp.Name}")
                sb.AppendLine($"Tanggal : {exp.ExpenseDate:dd MMMM yyyy}")
                sb.AppendLine($"Total   : Rp{exp.TotalAmount:N0}")
                sb.AppendLine($"Metode  : {FormatSplitMethod(exp.SplitMethod)}")
                If Not String.IsNullOrWhiteSpace(exp.Note) Then sb.AppendLine($"Catatan : {exp.Note}")
                sb.AppendLine()
                sb.AppendLine("--- PEMBAYAR (DITALANGI OLEH) ---")
                For Each p In payers
                    sb.AppendLine($" • {GetMemberName(p.MemberId)}: Rp{p.Amount:N0}")
                Next
                sb.AppendLine()
                sb.AppendLine("--- TANGGUNGAN (BAGIAN ANGGOTA) ---")
                For Each s In shares
                    sb.AppendLine($" • {GetMemberName(s.MemberId)}: Rp{s.Amount:N0}")
                Next
                If items.Count > 0 Then
                    sb.AppendLine()
                    sb.AppendLine("--- RINCIAN ITEM PESANAN ---")
                    For Each itm In items
                        sb.AppendLine($" • {itm.Name} x{itm.Qty} @ Rp{itm.UnitPrice:N0} ({GetMemberName(itm.MemberId)})")
                    Next
                End If

                ExpenseDetailsTextBox.Text = sb.ToString()
            Catch ex As Exception
                ExpenseDetailsTextBox.Text = $"Gagal memuat rincian: {ex.Message}"
            End Try
        End Sub

        Private Async Sub BillFromOrdersClickedAsync(sender As Object, e As EventArgs)
            If _group Is Nothing OrElse _group.OwnerId <> _session.UserId OrElse _group.Status <> "active" Then Return
            Try
                Dim approvedOrders = _orders.Where(Function(o) o.Status = "approved" AndAlso Not o.ExpenseId.HasValue).ToList()
                If approvedOrders.Count = 0 Then
                    MessageBox.Show("Tidak ada pesanan baru yang disetujui untuk ditagihkan." & Environment.NewLine & Environment.NewLine & "Seluruh pesanan yang disetujui sebelumnya telah berhasil dimasukkan ke daftar tagihan & pembayaran.", "Tidak Ada Pesanan Baru", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                End If

                Using dialog As New BillFromOrdersDialog(_groupMembers, approvedOrders, $"Pesanan - {_group.Name}")
                    If dialog.ShowDialog(FindForm()) = DialogResult.OK Then
                        SetStatus($"Membuat tagihan '{dialog.ExpenseName}' dari pesanan menu...", False)
                        Dim orderIds = approvedOrders.Select(Function(o) o.Id).ToArray()
                        Await _repository.CreateExpenseAsync(_session, _groupId, dialog.ExpenseName, dialog.TotalAmount, dialog.AdjustmentAmount, dialog.ExpenseDate, dialog.SplitMethod, dialog.Note, dialog.Payers, dialog.Shares, dialog.Items, CancellationToken.None, orderIds)
                        SetStatus($"Tagihan '{dialog.ExpenseName}' berhasil dibuat dari pesanan menu!", False)
                        Await ReloadAsync()
                    End If
                End Using
            Catch ex As Exception
                SetStatus(ex.Message, True)
            End Try
        End Sub

        Private Async Sub AddExpenseClickedAsync(sender As Object, e As EventArgs)
            If _group Is Nothing OrElse _group.OwnerId <> _session.UserId OrElse _group.Status <> "active" Then Return
            Try
                Dim approvedOrders = _orders.Where(Function(o) o.Status = "approved" AndAlso Not o.ExpenseId.HasValue).ToList()
                Using dialog As New ExpenseCreateDialog(_groupMembers, approvedOrders)
                    If dialog.ShowDialog(FindForm()) = DialogResult.OK Then
                        SetStatus($"Menyimpan pengeluaran '{dialog.ExpenseName}'...", False)
                        Dim orderIds = If(dialog.SplitMethod = "order" AndAlso approvedOrders.Count > 0, approvedOrders.Select(Function(o) o.Id).ToArray(), Nothing)
                        Await _repository.CreateExpenseAsync(_session, _groupId, dialog.ExpenseName, dialog.TotalAmount, dialog.AdjustmentAmount, dialog.ExpenseDate, dialog.SplitMethod, dialog.Note, dialog.Payers, dialog.Shares, dialog.Items, CancellationToken.None, orderIds)
                        SetStatus($"Pengeluaran '{dialog.ExpenseName}' berhasil ditambahkan.", False)
                        Await ReloadAsync()
                    End If
                End Using
            Catch ex As Exception
                SetStatus(ex.Message, True)
            End Try
        End Sub

        Private Async Sub DeleteExpenseClickedAsync(sender As Object, e As EventArgs)
            Dim exp = TryCast(ExpensesListBox.SelectedItem, ExpenseRecord)
            If exp Is Nothing OrElse _group Is Nothing OrElse _group.OwnerId <> _session.UserId OrElse _group.Status <> "active" Then
                SetStatus("Pilih pengeluaran yang ingin dihapus terlebih dahulu.", True)
                Return
            End If

            If MessageBox.Show($"Hapus pengeluaran '{exp.Name}' senilai Rp{exp.TotalAmount:N0}?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return

            Try
                SetStatus("Menghapus pengeluaran...", False)
                Await _repository.DeleteExpenseAsync(_session, exp.Id, CancellationToken.None)
                SetStatus("Pengeluaran berhasil dihapus.", False)
                Await ReloadAsync()
            Catch ex As Exception
                SetStatus(ex.Message, True)
            End Try
        End Sub

        Private Async Sub SubmitOrderClickedAsync(sender As Object, e As EventArgs)
            If _group Is Nothing OrElse _group.Status <> "active" Then Return
            Try
                Dim myMember = _groupMembers.FirstOrDefault(Function(m) m.UserId.HasValue AndAlso m.UserId.Value = _session.UserId)
                Dim defaultId = If(myMember IsNot Nothing, CType(myMember.Id, Guid?), Nothing)

                Using dialog As New OrderSubmitDialog(_groupMembers, defaultId)
                    If dialog.ShowDialog(FindForm()) = DialogResult.OK Then
                        SetStatus("Mengirim pesanan...", False)
                        Await _repository.SubmitOrderAsync(_session, _groupId, dialog.SelectedMemberId, dialog.ItemName, dialog.UnitPrice, dialog.Qty, dialog.Note, CancellationToken.None)
                        SetStatus($"Pesanan '{dialog.ItemName}' berhasil diajukan.", False)
                        Await ReloadAsync()
                    End If
                End Using
            Catch ex As Exception
                SetStatus(ex.Message, True)
            End Try
        End Sub

        Private Async Sub ReviewOrderClickedAsync(approve As Boolean)
            Dim item = TryCast(OrdersListBox.SelectedItem, OrderListItem)
            If item Is Nothing OrElse _group Is Nothing OrElse _group.OwnerId <> _session.UserId Then
                SetStatus("Pilih pesanan yang ingin ditinjau terlebih dahulu.", True)
                Return
            End If

            Try
                SetStatus("Memperbarui status pesanan...", False)
                Await _repository.ReviewOrderSubmissionAsync(_session, item.Record.Id, approve, CancellationToken.None)
                SetStatus(If(approve, "Pesanan disetujui.", "Pesanan ditolak."), False)
                Await ReloadAsync()
            Catch ex As Exception
                SetStatus(ex.Message, True)
            End Try
        End Sub

        Private Async Sub FinalizeSettlementClickedAsync(sender As Object, e As EventArgs)
            If _group Is Nothing OrElse _group.OwnerId <> _session.UserId OrElse _group.Status <> "active" Then Return
            If _expenses.Count = 0 Then
                MessageBox.Show("Belum ada pengeluaran yang dicatat. Tambahkan minimal satu pengeluaran sebelum finalisasi.", "Finalisasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            If MessageBox.Show("Finalisasi kegiatan akan mengunci seluruh pengeluaran dan menghitung saldo akhir serta rekomendasi transfer secara otomatis dan permanen." & Environment.NewLine & Environment.NewLine & "Apakah Anda yakin ingin menyelesaikan kegiatan ini?", "Konfirmasi Finalisasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return

            Try
                SetStatus("Memproses finalisasi saldo secara atomik di server...", False)
                Await _repository.FinalizeGroupSettlementAsync(_session, _groupId, CancellationToken.None)
                SetStatus("Kegiatan berhasil diselesaikan! Saldo dan transfer pembayaran telah terkunci.", False)
                Await ReloadAsync()
            Catch ex As Exception
                SetStatus(ex.Message, True)
            End Try
        End Sub

        Private Async Sub MarkSettlementPaidClickedAsync(sender As Object, e As EventArgs)
            If _group Is Nothing Then Return

            Dim item = TryCast(SettlementsListBox.SelectedItem, SettlementListItem)
            Dim targetSettlement As SettlementRecord = Nothing

            If item IsNot Nothing Then
                targetSettlement = item.Record
            Else
                ' Cari tagihan milik user yang sedang login secara otomatis jika tidak ada yang dipilih
                Dim myMember = _groupMembers.FirstOrDefault(Function(m) m.UserId.HasValue AndAlso m.UserId.Value = _session.UserId)
                If myMember IsNot Nothing Then
                    targetSettlement = _settlements.FirstOrDefault(Function(s) s.FromMemberId = myMember.Id AndAlso String.Equals(s.Status, "pending", StringComparison.OrdinalIgnoreCase))
                End If

                If targetSettlement Is Nothing AndAlso _group.OwnerId = _session.UserId Then
                    ' Jika pemilik kegiatan, ambil tagihan pertama yang berstatus belum dibayar
                    targetSettlement = _settlements.FirstOrDefault(Function(s) String.Equals(s.Status, "pending", StringComparison.OrdinalIgnoreCase))
                End If
            End If

            If targetSettlement Is Nothing Then
                Dim isOwner = _group.OwnerId = _session.UserId
                If isOwner Then
                    MessageBox.Show("Pilih transfer pembayaran dari daftar yang ingin ditandai sudah dibayar.", "Pilih Tagihan", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Anda tidak memiliki tagihan yang belum dibayar.", "Informasi Tagihan", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                Return
            End If

            If Not String.Equals(targetSettlement.Status, "pending", StringComparison.OrdinalIgnoreCase) Then
                SetStatus("Hanya tagihan dengan status 'Belum Dibayar' yang dapat ditandai sudah dibayar.", True)
                Return
            End If

            Dim fromName = GetMemberName(targetSettlement.FromMemberId)
            Dim toName = GetMemberName(targetSettlement.ToMemberId)
            If MessageBox.Show($"Tandai pembayaran transfer Rp{targetSettlement.Amount:N0} dari {fromName} ke {toName} sudah dibayar?", "Konfirmasi Pembayaran", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
                Return
            End If

            Try
                SetStatus("Menandai transfer...", False)
                Await _repository.MarkSettlementPaidAsync(_session, targetSettlement.Id, CancellationToken.None)
                SetStatus("Transfer berhasil ditandai sudah dibayar. Menunggu konfirmasi penerimaan oleh pemilik kegiatan / moderator.", False)
                Await ReloadAsync()
            Catch ex As Exception
                SetStatus(ex.Message, True)
            End Try
        End Sub

        Private Async Sub ConfirmSettlementPaidClickedAsync(sender As Object, e As EventArgs)
            If _group Is Nothing OrElse _group.OwnerId <> _session.UserId Then
                SetStatus("Hanya pemilik grup / moderator yang dapat mengonfirmasi penerimaan pembayaran.", True)
                Return
            End If

            Dim item = TryCast(SettlementsListBox.SelectedItem, SettlementListItem)
            Dim targetSettlement As SettlementRecord = Nothing

            If item IsNot Nothing Then
                targetSettlement = item.Record
            Else
                ' Ambil pembayaran pertama yang sedang menunggu konfirmasi
                targetSettlement = _settlements.FirstOrDefault(Function(s) String.Equals(s.Status, "marked", StringComparison.OrdinalIgnoreCase))
            End If

            If targetSettlement Is Nothing Then
                MessageBox.Show("Belum ada transfer pembayaran anggota yang menunggu konfirmasi penerimaan." & Environment.NewLine & Environment.NewLine & "Anggota dapat menekan tombol '✓ Saya Sudah Bayar' terlebih dahulu setelah mentransfer.", "Belum Ada Pembayaran Menunggu", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return
            End If

            If Not String.Equals(targetSettlement.Status, "marked", StringComparison.OrdinalIgnoreCase) Then
                SetStatus("Hanya transfer yang berstatus 'Menunggu Konfirmasi' yang dapat dikonfirmasi penerimaannya.", True)
                Return
            End If

            Dim fromName = GetMemberName(targetSettlement.FromMemberId)
            Dim toName = GetMemberName(targetSettlement.ToMemberId)
            If MessageBox.Show($"Konfirmasi bahwa pembayaran transfer Rp{targetSettlement.Amount:N0} dari {fromName} ke {toName} sudah diterima?", "Konfirmasi Penerimaan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
                Return
            End If

            Try
                SetStatus("Mengonfirmasi penerimaan pembayaran...", False)
                Await _repository.ConfirmSettlementPaymentAsync(_session, targetSettlement.Id, CancellationToken.None)
                SetStatus("Pembayaran berhasil dikonfirmasi telah diterima. Status tagihan kini lunas.", False)
                Await ReloadAsync()
            Catch ex As Exception
                SetStatus(ex.Message, True)
            End Try
        End Sub

        Private Async Sub EditGroupClickedAsync(sender As Object, e As EventArgs)
            If _group Is Nothing OrElse _group.OwnerId <> _session.UserId OrElse _group.Status <> "active" Then Return
            Try
                SetStatus("Memuat data tempat...", False)
                Dim places = Await _repository.GetPlacesAsync(_session, CancellationToken.None)
                Using dialog As New GroupEditDialog(_group, places)
                    If dialog.ShowDialog(FindForm()) = DialogResult.OK Then
                        SetStatus("Menyimpan perubahan kegiatan...", False)
                        Await _repository.UpdateGroupAsync(_session, _groupId, dialog.GroupName, dialog.EventDate, dialog.PlaceId, CancellationToken.None)
                        SetStatus("Data kegiatan berhasil diperbarui.", False)
                        Await ReloadAsync()
                    Else
                        SetStatus(String.Empty, False)
                    End If
                End Using
            Catch ex As Exception
                SetStatus(ex.Message, True)
            End Try
        End Sub

        Private Async Sub AddMemberClickedAsync(sender As Object, e As EventArgs)
            If _group Is Nothing OrElse _group.OwnerId <> _session.UserId OrElse _group.Status <> "active" Then Return
            Try
                Dim allPeople = Await _repository.GetPeopleAsync(_session, CancellationToken.None)
                Dim existingPersonIds As New HashSet(Of Guid)()
                For Each member In _groupMembers
                    existingPersonIds.Add(member.PersonId)
                Next
                Dim availablePeople = allPeople.Where(Function(p) Not existingPersonIds.Contains(p.Id)).ToList()

                Using dialog As New AddMemberDialog(_repository, _session, _groupId, availablePeople, _groupMembers)
                    If dialog.ShowDialog(FindForm()) = DialogResult.OK Then
                        SetStatus("Anggota berhasil ditambahkan.", False)
                        Await ReloadAsync()
                    End If
                End Using
            Catch ex As Exception
                SetStatus(ex.Message, True)
            End Try
        End Sub

        Private Async Sub InviteEnabledChangedAsync(sender As Object, e As EventArgs)
            If _loading OrElse _group Is Nothing OrElse _group.OwnerId <> _session.UserId Then Return
            Try
                Await _repository.SetInviteEnabledAsync(_session, _groupId, InviteEnabledCheck.Checked, CancellationToken.None)
                InviteLabel.Text = If(InviteEnabledCheck.Checked, $"Kode: {_group.InviteCode}", "Undangan dinonaktifkan")
                SetStatus("Pengaturan undangan tersimpan.", False)
            Catch ex As Exception
                SetStatus(ex.Message, True)
                _loading = True
                InviteEnabledCheck.Checked = Not InviteEnabledCheck.Checked
                _loading = False
            End Try
        End Sub

        Private Async Sub RotateInviteAsync(sender As Object, e As EventArgs)
            If _group Is Nothing OrElse _group.OwnerId <> _session.UserId Then Return
            If MessageBox.Show("Kode lama tidak akan berlaku lagi. Ganti kode undangan?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
            Try
                Await _repository.RegenerateInviteCodeAsync(_session, _groupId, CancellationToken.None)
                Await ReloadAsync()
                SetStatus("Kode undangan berhasil diganti.", False)
            Catch ex As Exception
                SetStatus(ex.Message, True)
            End Try
        End Sub

        Private Async Sub RemoveSelectedMemberAsync(sender As Object, e As EventArgs)
            Dim member = TryCast(MembersListBox.SelectedItem, GroupMemberRecord)
            If member Is Nothing OrElse _group Is Nothing OrElse _group.OwnerId <> _session.UserId Then Return
            If MessageBox.Show("Hapus anggota dari grup? Anggota yang sudah tercatat pada pengeluaran tidak dapat dihapus.", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
            Try
                Await _repository.RemoveGroupMemberAsync(_session, _groupId, member.Id, CancellationToken.None)
                Await ReloadAsync()
                SetStatus("Anggota dihapus.", False)
            Catch ex As Exception
                SetStatus(ex.Message, True)
            End Try
        End Sub

        Private Async Sub ReviewSelectedRequestAsync(approve As Boolean)
            Dim request = TryCast(RequestsListBox.SelectedItem, JoinRequestRecord)
            If request Is Nothing Then
                SetStatus("Pilih permintaan bergabung terlebih dahulu.", True)
                Return
            End If
            Try
                Await _repository.ReviewJoinRequestAsync(_session, request.RequestId, approve, CancellationToken.None)
                Await ReloadAsync()
                SetStatus(If(approve, "Permintaan disetujui dan akun ditautkan.", "Permintaan ditolak."), False)
            Catch ex As Exception
                SetStatus(ex.Message, True)
            End Try
        End Sub

        Private Function GetMemberName(memberId As Guid) As String
            For Each m In _groupMembers
                If m.Id = memberId Then
                    Return If(m.Person IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(m.Person.Name), m.Person.Name, "Anggota")
                End If
            Next
            Return "Anggota"
        End Function

        Private Sub SetStatus(message As String, isError As Boolean)
            StatusLabel.Text = message
            StatusLabel.ForeColor = If(isError, UiTheme.ErrorColor, UiTheme.PrimaryDarkColor)
        End Sub

        Private Shared Function FormatType(value As String) As String
            Select Case value
                Case "hangout" : Return "Nongkrong atau makan bersama"
                Case "trip" : Return "Perjalanan"
                Case "purchase_rental" : Return "Pembelian atau penyewaan"
                Case Else : Return value
            End Select
        End Function

        Private Shared Function FormatSplitMethod(value As String) As String
            Select Case value
                Case "equal" : Return "Sama Rata"
                Case "order" : Return "Berdasarkan Pesanan"
                Case "percentage" : Return "Persentase"
                Case "fixed" : Return "Nominal Tetap"
                Case Else : Return value
            End Select
        End Function

        Private Shared Function FormatOrderStatus(value As String) As String
            Select Case value
                Case "submitted" : Return "Menunggu Persetujuan"
                Case "approved" : Return "Disetujui"
                Case "rejected" : Return "Ditolak"
                Case Else : Return value
            End Select
        End Function

        Private Shared Function FormatSettlementStatus(value As String) As String
            Select Case value
                Case "pending" : Return "Belum Dibayar"
                Case "marked" : Return "Telah Ditransfer (Menunggu Konfirmasi)"
                Case "confirmed" : Return "Lunas & Dikonfirmasi"
                Case Else : Return value
            End Select
        End Function

        Private NotInheritable Class OrderListItem
            Public Sub New(record As OrderSubmissionRecord, displayText As String)
                Me.Record = record
                Me.DisplayText = displayText
            End Sub
            Public ReadOnly Property Record As OrderSubmissionRecord
            Public ReadOnly Property DisplayText As String
            Public Overrides Function ToString() As String
                Return DisplayText
            End Function
        End Class

        Private NotInheritable Class SettlementListItem
            Public Sub New(record As SettlementRecord, displayText As String)
                Me.Record = record
                Me.DisplayText = displayText
            End Sub
            Public ReadOnly Property Record As SettlementRecord
            Public ReadOnly Property DisplayText As String
            Public Overrides Function ToString() As String
                Return DisplayText
            End Function
        End Class
    End Class
End Namespace
