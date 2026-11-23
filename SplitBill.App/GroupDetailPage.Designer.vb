Namespace Global.SplitBill.App
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class GroupDetailPage
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.ShellLayout = New System.Windows.Forms.TableLayoutPanel()
            Me.HeaderLayout = New System.Windows.Forms.TableLayoutPanel()
            Me.TitleLabel = New System.Windows.Forms.Label()
            Me.SubtitleLabel = New System.Windows.Forms.Label()
            Me.BtnEditGroup = New System.Windows.Forms.Button()
            Me.TabsControl = New System.Windows.Forms.TabControl()
            Me.MembersTab = New System.Windows.Forms.TabPage()
            Me.MembersLayout = New System.Windows.Forms.TableLayoutPanel()
            Me.InviteBarFlow = New System.Windows.Forms.FlowLayoutPanel()
            Me.InviteLabel = New System.Windows.Forms.Label()
            Me.BtnCopyInvite = New System.Windows.Forms.Button()
            Me.InviteEnabledCheck = New System.Windows.Forms.CheckBox()
            Me.BtnRotateInvite = New System.Windows.Forms.Button()
            Me.MembersListBox = New System.Windows.Forms.ListBox()
            Me.MemberActionsFlow = New System.Windows.Forms.FlowLayoutPanel()
            Me.BtnAddMember = New System.Windows.Forms.Button()
            Me.BtnRemoveMember = New System.Windows.Forms.Button()
            Me.BtnReloadMembers = New System.Windows.Forms.Button()
            Me.OrdersTab = New System.Windows.Forms.TabPage()
            Me.OrdersLayout = New System.Windows.Forms.TableLayoutPanel()
            Me.OrdersListBox = New System.Windows.Forms.ListBox()
            Me.OrderActionsFlow = New System.Windows.Forms.FlowLayoutPanel()
            Me.BtnSubmitOrder = New System.Windows.Forms.Button()
            Me.BtnApproveOrder = New System.Windows.Forms.Button()
            Me.BtnRejectOrder = New System.Windows.Forms.Button()
            Me.BtnReloadOrders = New System.Windows.Forms.Button()
            Me.BillingTab = New System.Windows.Forms.TabPage()
            Me.BillingLayout = New System.Windows.Forms.TableLayoutPanel()
            Me.ExpensesPanel = New System.Windows.Forms.TableLayoutPanel()
            Me.ExpensesTitleLabel = New System.Windows.Forms.Label()
            Me.ExpensesListBox = New System.Windows.Forms.ListBox()
            Me.ExpenseDetailsTitleLabel = New System.Windows.Forms.Label()
            Me.ExpenseDetailsTextBox = New System.Windows.Forms.TextBox()
            Me.ExpenseActionsFlow = New System.Windows.Forms.FlowLayoutPanel()
            Me.BtnBillFromOrders = New System.Windows.Forms.Button()
            Me.BtnAddExpense = New System.Windows.Forms.Button()
            Me.BtnDeleteExpense = New System.Windows.Forms.Button()
            Me.BtnReloadExpenses = New System.Windows.Forms.Button()
            Me.SettlementsPanel = New System.Windows.Forms.TableLayoutPanel()
            Me.BalanceHeaderLabel = New System.Windows.Forms.Label()
            Me.BalancesListBox = New System.Windows.Forms.ListBox()
            Me.TransferHeaderLabel = New System.Windows.Forms.Label()
            Me.SettlementsListBox = New System.Windows.Forms.ListBox()
            Me.SettlementActionsFlow = New System.Windows.Forms.FlowLayoutPanel()
            Me.BtnFinalize = New System.Windows.Forms.Button()
            Me.BtnMarkPaid = New System.Windows.Forms.Button()
            Me.BtnConfirmPaid = New System.Windows.Forms.Button()
            Me.BtnReloadSettlements = New System.Windows.Forms.Button()
            Me.RequestsTab = New System.Windows.Forms.TabPage()
            Me.RequestsLayout = New System.Windows.Forms.TableLayoutPanel()
            Me.RequestsListBox = New System.Windows.Forms.ListBox()
            Me.RequestActionsFlow = New System.Windows.Forms.FlowLayoutPanel()
            Me.BtnApproveRequest = New System.Windows.Forms.Button()
            Me.BtnRejectRequest = New System.Windows.Forms.Button()
            Me.StatusLabel = New System.Windows.Forms.Label()
            Me.ShellLayout.SuspendLayout()
            Me.HeaderLayout.SuspendLayout()
            Me.TabsControl.SuspendLayout()
            Me.MembersTab.SuspendLayout()
            Me.MembersLayout.SuspendLayout()
            Me.InviteBarFlow.SuspendLayout()
            Me.MemberActionsFlow.SuspendLayout()
            Me.OrdersTab.SuspendLayout()
            Me.OrdersLayout.SuspendLayout()
            Me.OrderActionsFlow.SuspendLayout()
            Me.BillingTab.SuspendLayout()
            Me.BillingLayout.SuspendLayout()
            Me.ExpensesPanel.SuspendLayout()
            Me.ExpenseActionsFlow.SuspendLayout()
            Me.SettlementsPanel.SuspendLayout()
            Me.SettlementActionsFlow.SuspendLayout()
            Me.RequestsTab.SuspendLayout()
            Me.RequestsLayout.SuspendLayout()
            Me.RequestActionsFlow.SuspendLayout()
            Me.SuspendLayout()
            '
            'ShellLayout
            '
            Me.ShellLayout.BackColor = System.Drawing.Color.FromArgb(246, 248, 246)
            Me.ShellLayout.ColumnCount = 1
            Me.ShellLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.ShellLayout.Controls.Add(Me.HeaderLayout, 0, 0)
            Me.ShellLayout.Controls.Add(Me.TabsControl, 0, 1)
            Me.ShellLayout.Controls.Add(Me.StatusLabel, 0, 2)
            Me.ShellLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ShellLayout.Location = New System.Drawing.Point(0, 0)
            Me.ShellLayout.Name = "ShellLayout"
            Me.ShellLayout.Padding = New System.Windows.Forms.Padding(24, 20, 24, 20)
            Me.ShellLayout.RowCount = 3
            Me.ShellLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85.0F))
            Me.ShellLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.ShellLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0F))
            Me.ShellLayout.Size = New System.Drawing.Size(950, 700)
            Me.ShellLayout.TabIndex = 0
            '
            'HeaderLayout
            '
            Me.HeaderLayout.ColumnCount = 2
            Me.HeaderLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.HeaderLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize))
            Me.HeaderLayout.Controls.Add(Me.TitleLabel, 0, 0)
            Me.HeaderLayout.Controls.Add(Me.SubtitleLabel, 0, 1)
            Me.HeaderLayout.Controls.Add(Me.BtnEditGroup, 1, 0)
            Me.HeaderLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.HeaderLayout.Location = New System.Drawing.Point(24, 20)
            Me.HeaderLayout.Margin = New System.Windows.Forms.Padding(0)
            Me.HeaderLayout.Name = "HeaderLayout"
            Me.HeaderLayout.RowCount = 2
            Me.HeaderLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60.0F))
            Me.HeaderLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0F))
            Me.HeaderLayout.Size = New System.Drawing.Size(902, 85)
            Me.HeaderLayout.TabIndex = 0
            '
            'TitleLabel
            '
            Me.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI", 20.0F, System.Drawing.FontStyle.Bold)
            Me.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.TitleLabel.Location = New System.Drawing.Point(0, 0)
            Me.TitleLabel.Margin = New System.Windows.Forms.Padding(0)
            Me.TitleLabel.Name = "TitleLabel"
            Me.TitleLabel.Size = New System.Drawing.Size(777, 51)
            Me.TitleLabel.TabIndex = 0
            Me.TitleLabel.Text = "Nama Kegiatan"
            Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'SubtitleLabel
            '
            Me.SubtitleLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SubtitleLabel.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.SubtitleLabel.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128)
            Me.SubtitleLabel.Location = New System.Drawing.Point(0, 51)
            Me.SubtitleLabel.Margin = New System.Windows.Forms.Padding(0)
            Me.SubtitleLabel.Name = "SubtitleLabel"
            Me.SubtitleLabel.Size = New System.Drawing.Size(777, 34)
            Me.SubtitleLabel.TabIndex = 1
            Me.SubtitleLabel.Text = "Informasi Kegiatan"
            Me.SubtitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'BtnEditGroup
            '
            Me.BtnEditGroup.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.BtnEditGroup.AutoSize = True
            Me.BtnEditGroup.BackColor = System.Drawing.Color.White
            Me.BtnEditGroup.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnEditGroup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 231, 235)
            Me.BtnEditGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnEditGroup.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.BtnEditGroup.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.BtnEditGroup.Location = New System.Drawing.Point(777, 23)
            Me.BtnEditGroup.Margin = New System.Windows.Forms.Padding(0)
            Me.BtnEditGroup.Name = "BtnEditGroup"
            Me.HeaderLayout.SetRowSpan(Me.BtnEditGroup, 2)
            Me.BtnEditGroup.Size = New System.Drawing.Size(125, 38)
            Me.BtnEditGroup.TabIndex = 2
            Me.BtnEditGroup.Text = "✎ Ubah Kegiatan"
            Me.BtnEditGroup.UseVisualStyleBackColor = False
            '
            'TabsControl
            '
            Me.TabsControl.Controls.Add(Me.MembersTab)
            Me.TabsControl.Controls.Add(Me.OrdersTab)
            Me.TabsControl.Controls.Add(Me.BillingTab)
            Me.TabsControl.Controls.Add(Me.RequestsTab)
            Me.TabsControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabsControl.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.TabsControl.Location = New System.Drawing.Point(24, 105)
            Me.TabsControl.Margin = New System.Windows.Forms.Padding(0)
            Me.TabsControl.Name = "TabsControl"
            Me.TabsControl.SelectedIndex = 0
            Me.TabsControl.Size = New System.Drawing.Size(902, 550)
            Me.TabsControl.TabIndex = 1
            '
            'MembersTab
            '
            Me.MembersTab.BackColor = System.Drawing.Color.FromArgb(246, 248, 246)
            Me.MembersTab.Controls.Add(Me.MembersLayout)
            Me.MembersTab.Location = New System.Drawing.Point(4, 26)
            Me.MembersTab.Name = "MembersTab"
            Me.MembersTab.Padding = New System.Windows.Forms.Padding(10)
            Me.MembersTab.Size = New System.Drawing.Size(894, 520)
            Me.MembersTab.TabIndex = 0
            Me.MembersTab.Text = "Anggota"
            '
            'MembersLayout
            '
            Me.MembersLayout.ColumnCount = 1
            Me.MembersLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.MembersLayout.Controls.Add(Me.InviteBarFlow, 0, 0)
            Me.MembersLayout.Controls.Add(Me.MembersListBox, 0, 1)
            Me.MembersLayout.Controls.Add(Me.MemberActionsFlow, 0, 2)
            Me.MembersLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MembersLayout.Location = New System.Drawing.Point(10, 10)
            Me.MembersLayout.Margin = New System.Windows.Forms.Padding(0)
            Me.MembersLayout.Name = "MembersLayout"
            Me.MembersLayout.RowCount = 3
            Me.MembersLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56.0F))
            Me.MembersLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.MembersLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0F))
            Me.MembersLayout.Size = New System.Drawing.Size(874, 500)
            Me.MembersLayout.TabIndex = 0
            '
            'InviteBarFlow
            '
            Me.InviteBarFlow.Controls.Add(Me.InviteLabel)
            Me.InviteBarFlow.Controls.Add(Me.BtnCopyInvite)
            Me.InviteBarFlow.Controls.Add(Me.InviteEnabledCheck)
            Me.InviteBarFlow.Controls.Add(Me.BtnRotateInvite)
            Me.InviteBarFlow.Dock = System.Windows.Forms.DockStyle.Fill
            Me.InviteBarFlow.Location = New System.Drawing.Point(0, 0)
            Me.InviteBarFlow.Margin = New System.Windows.Forms.Padding(0)
            Me.InviteBarFlow.Name = "InviteBarFlow"
            Me.InviteBarFlow.Padding = New System.Windows.Forms.Padding(2, 8, 2, 8)
            Me.InviteBarFlow.Size = New System.Drawing.Size(874, 56)
            Me.InviteBarFlow.TabIndex = 0
            '
            'InviteLabel
            '
            Me.InviteLabel.AutoSize = True
            Me.InviteLabel.Font = New System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold)
            Me.InviteLabel.ForeColor = System.Drawing.Color.FromArgb(32, 73, 54)
            Me.InviteLabel.Location = New System.Drawing.Point(6, 14)
            Me.InviteLabel.Margin = New System.Windows.Forms.Padding(4, 6, 10, 6)
            Me.InviteLabel.Name = "InviteLabel"
            Me.InviteLabel.Size = New System.Drawing.Size(107, 19)
            Me.InviteLabel.TabIndex = 0
            Me.InviteLabel.Text = "Kode Undangan"
            '
            'BtnCopyInvite
            '
            Me.BtnCopyInvite.AutoSize = True
            Me.BtnCopyInvite.BackColor = System.Drawing.Color.FromArgb(47, 107, 79)
            Me.BtnCopyInvite.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnCopyInvite.FlatAppearance.BorderSize = 0
            Me.BtnCopyInvite.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnCopyInvite.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.BtnCopyInvite.ForeColor = System.Drawing.Color.White
            Me.BtnCopyInvite.Location = New System.Drawing.Point(127, 11)
            Me.BtnCopyInvite.Margin = New System.Windows.Forms.Padding(4, 3, 10, 3)
            Me.BtnCopyInvite.Name = "BtnCopyInvite"
            Me.BtnCopyInvite.Size = New System.Drawing.Size(105, 34)
            Me.BtnCopyInvite.TabIndex = 1
            Me.BtnCopyInvite.Text = "📋 Salin Kode"
            Me.BtnCopyInvite.UseVisualStyleBackColor = False
            '
            'InviteEnabledCheck
            '
            Me.InviteEnabledCheck.AutoSize = True
            Me.InviteEnabledCheck.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.InviteEnabledCheck.Location = New System.Drawing.Point(246, 16)
            Me.InviteEnabledCheck.Margin = New System.Windows.Forms.Padding(4, 8, 10, 4)
            Me.InviteEnabledCheck.Name = "InviteEnabledCheck"
            Me.InviteEnabledCheck.Size = New System.Drawing.Size(155, 23)
            Me.InviteEnabledCheck.TabIndex = 2
            Me.InviteEnabledCheck.Text = "Kode undangan aktif"
            Me.InviteEnabledCheck.UseVisualStyleBackColor = True
            '
            'BtnRotateInvite
            '
            Me.BtnRotateInvite.AutoSize = True
            Me.BtnRotateInvite.BackColor = System.Drawing.Color.White
            Me.BtnRotateInvite.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnRotateInvite.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 231, 235)
            Me.BtnRotateInvite.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnRotateInvite.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.BtnRotateInvite.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.BtnRotateInvite.Location = New System.Drawing.Point(415, 11)
            Me.BtnRotateInvite.Margin = New System.Windows.Forms.Padding(4, 3, 10, 3)
            Me.BtnRotateInvite.Name = "BtnRotateInvite"
            Me.BtnRotateInvite.Size = New System.Drawing.Size(95, 34)
            Me.BtnRotateInvite.TabIndex = 3
            Me.BtnRotateInvite.Text = "Ganti Kode"
            Me.BtnRotateInvite.UseVisualStyleBackColor = False
            '
            'MembersListBox
            '
            Me.MembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.MembersListBox.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MembersListBox.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.MembersListBox.IntegralHeight = False
            Me.MembersListBox.ItemHeight = 17
            Me.MembersListBox.Location = New System.Drawing.Point(0, 62)
            Me.MembersListBox.Margin = New System.Windows.Forms.Padding(0, 6, 0, 6)
            Me.MembersListBox.Name = "MembersListBox"
            Me.MembersListBox.Size = New System.Drawing.Size(874, 382)
            Me.MembersListBox.TabIndex = 1
            '
            'MemberActionsFlow
            '
            Me.MemberActionsFlow.Controls.Add(Me.BtnAddMember)
            Me.MemberActionsFlow.Controls.Add(Me.BtnRemoveMember)
            Me.MemberActionsFlow.Controls.Add(Me.BtnReloadMembers)
            Me.MemberActionsFlow.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MemberActionsFlow.Location = New System.Drawing.Point(0, 450)
            Me.MemberActionsFlow.Margin = New System.Windows.Forms.Padding(0)
            Me.MemberActionsFlow.Name = "MemberActionsFlow"
            Me.MemberActionsFlow.Size = New System.Drawing.Size(874, 50)
            Me.MemberActionsFlow.TabIndex = 2
            '
            'BtnAddMember
            '
            Me.BtnAddMember.AutoSize = True
            Me.BtnAddMember.BackColor = System.Drawing.Color.FromArgb(47, 107, 79)
            Me.BtnAddMember.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnAddMember.FlatAppearance.BorderSize = 0
            Me.BtnAddMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnAddMember.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.BtnAddMember.ForeColor = System.Drawing.Color.White
            Me.BtnAddMember.Location = New System.Drawing.Point(0, 4)
            Me.BtnAddMember.Margin = New System.Windows.Forms.Padding(0, 4, 8, 4)
            Me.BtnAddMember.Name = "BtnAddMember"
            Me.BtnAddMember.Size = New System.Drawing.Size(130, 38)
            Me.BtnAddMember.TabIndex = 0
            Me.BtnAddMember.Text = "＋ Tambah Teman"
            Me.BtnAddMember.UseVisualStyleBackColor = False
            '
            'BtnRemoveMember
            '
            Me.BtnRemoveMember.AutoSize = True
            Me.BtnRemoveMember.BackColor = System.Drawing.Color.White
            Me.BtnRemoveMember.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnRemoveMember.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 231, 235)
            Me.BtnRemoveMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnRemoveMember.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.BtnRemoveMember.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.BtnRemoveMember.Location = New System.Drawing.Point(138, 4)
            Me.BtnRemoveMember.Margin = New System.Windows.Forms.Padding(0, 4, 8, 4)
            Me.BtnRemoveMember.Name = "BtnRemoveMember"
            Me.BtnRemoveMember.Size = New System.Drawing.Size(110, 38)
            Me.BtnRemoveMember.TabIndex = 1
            Me.BtnRemoveMember.Text = "Hapus Anggota"
            Me.BtnRemoveMember.UseVisualStyleBackColor = False
            '
            'BtnReloadMembers
            '
            Me.BtnReloadMembers.AutoSize = True
            Me.BtnReloadMembers.BackColor = System.Drawing.Color.White
            Me.BtnReloadMembers.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnReloadMembers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 231, 235)
            Me.BtnReloadMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnReloadMembers.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.BtnReloadMembers.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.BtnReloadMembers.Location = New System.Drawing.Point(256, 4)
            Me.BtnReloadMembers.Margin = New System.Windows.Forms.Padding(0, 4, 8, 4)
            Me.BtnReloadMembers.Name = "BtnReloadMembers"
            Me.BtnReloadMembers.Size = New System.Drawing.Size(95, 38)
            Me.BtnReloadMembers.TabIndex = 2
            Me.BtnReloadMembers.Text = "Muat Ulang"
            Me.BtnReloadMembers.UseVisualStyleBackColor = False
            '
            'OrdersTab
            '
            Me.OrdersTab.BackColor = System.Drawing.Color.FromArgb(246, 248, 246)
            Me.OrdersTab.Controls.Add(Me.OrdersLayout)
            Me.OrdersTab.Location = New System.Drawing.Point(4, 26)
            Me.OrdersTab.Name = "OrdersTab"
            Me.OrdersTab.Padding = New System.Windows.Forms.Padding(10)
            Me.OrdersTab.Size = New System.Drawing.Size(894, 520)
            Me.OrdersTab.TabIndex = 1
            Me.OrdersTab.Text = "Pengeluaran & Pesanan"
            '
            'OrdersLayout
            '
            Me.OrdersLayout.ColumnCount = 1
            Me.OrdersLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.OrdersLayout.Controls.Add(Me.OrdersListBox, 0, 0)
            Me.OrdersLayout.Controls.Add(Me.OrderActionsFlow, 0, 1)
            Me.OrdersLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.OrdersLayout.Location = New System.Drawing.Point(10, 10)
            Me.OrdersLayout.Margin = New System.Windows.Forms.Padding(0)
            Me.OrdersLayout.Name = "OrdersLayout"
            Me.OrdersLayout.RowCount = 2
            Me.OrdersLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.OrdersLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0F))
            Me.OrdersLayout.Size = New System.Drawing.Size(874, 500)
            Me.OrdersLayout.TabIndex = 0
            '
            'OrdersListBox
            '
            Me.OrdersListBox.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.OrdersListBox.Dock = System.Windows.Forms.DockStyle.Fill
            Me.OrdersListBox.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.OrdersListBox.IntegralHeight = False
            Me.OrdersListBox.ItemHeight = 17
            Me.OrdersListBox.Location = New System.Drawing.Point(0, 0)
            Me.OrdersListBox.Margin = New System.Windows.Forms.Padding(0)
            Me.OrdersListBox.Name = "OrdersListBox"
            Me.OrdersListBox.Size = New System.Drawing.Size(874, 450)
            Me.OrdersListBox.TabIndex = 0
            '
            'OrderActionsFlow
            '
            Me.OrderActionsFlow.Controls.Add(Me.BtnSubmitOrder)
            Me.OrderActionsFlow.Controls.Add(Me.BtnApproveOrder)
            Me.OrderActionsFlow.Controls.Add(Me.BtnRejectOrder)
            Me.OrderActionsFlow.Controls.Add(Me.BtnReloadOrders)
            Me.OrderActionsFlow.Dock = System.Windows.Forms.DockStyle.Fill
            Me.OrderActionsFlow.Location = New System.Drawing.Point(0, 450)
            Me.OrderActionsFlow.Margin = New System.Windows.Forms.Padding(0)
            Me.OrderActionsFlow.Name = "OrderActionsFlow"
            Me.OrderActionsFlow.Size = New System.Drawing.Size(874, 50)
            Me.OrderActionsFlow.TabIndex = 1
            '
            'BtnSubmitOrder
            '
            Me.BtnSubmitOrder.AutoSize = True
            Me.BtnSubmitOrder.BackColor = System.Drawing.Color.FromArgb(47, 107, 79)
            Me.BtnSubmitOrder.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnSubmitOrder.FlatAppearance.BorderSize = 0
            Me.BtnSubmitOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnSubmitOrder.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.BtnSubmitOrder.ForeColor = System.Drawing.Color.White
            Me.BtnSubmitOrder.Location = New System.Drawing.Point(0, 4)
            Me.BtnSubmitOrder.Margin = New System.Windows.Forms.Padding(0, 4, 8, 4)
            Me.BtnSubmitOrder.Name = "BtnSubmitOrder"
            Me.BtnSubmitOrder.Size = New System.Drawing.Size(165, 38)
            Me.BtnSubmitOrder.TabIndex = 0
            Me.BtnSubmitOrder.Text = "＋ Catat Menu / Pesanan"
            Me.BtnSubmitOrder.UseVisualStyleBackColor = False
            '
            'BtnApproveOrder
            '
            Me.BtnApproveOrder.AutoSize = True
            Me.BtnApproveOrder.BackColor = System.Drawing.Color.FromArgb(47, 107, 79)
            Me.BtnApproveOrder.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnApproveOrder.FlatAppearance.BorderSize = 0
            Me.BtnApproveOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnApproveOrder.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.BtnApproveOrder.ForeColor = System.Drawing.Color.White
            Me.BtnApproveOrder.Location = New System.Drawing.Point(163, 4)
            Me.BtnApproveOrder.Margin = New System.Windows.Forms.Padding(0, 4, 8, 4)
            Me.BtnApproveOrder.Name = "BtnApproveOrder"
            Me.BtnApproveOrder.Size = New System.Drawing.Size(130, 38)
            Me.BtnApproveOrder.TabIndex = 1
            Me.BtnApproveOrder.Text = "✓ Setujui Pesanan"
            Me.BtnApproveOrder.UseVisualStyleBackColor = False
            '
            'BtnRejectOrder
            '
            Me.BtnRejectOrder.AutoSize = True
            Me.BtnRejectOrder.BackColor = System.Drawing.Color.White
            Me.BtnRejectOrder.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnRejectOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 231, 235)
            Me.BtnRejectOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnRejectOrder.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.BtnRejectOrder.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.BtnRejectOrder.Location = New System.Drawing.Point(301, 4)
            Me.BtnRejectOrder.Margin = New System.Windows.Forms.Padding(0, 4, 8, 4)
            Me.BtnRejectOrder.Name = "BtnRejectOrder"
            Me.BtnRejectOrder.Size = New System.Drawing.Size(115, 38)
            Me.BtnRejectOrder.TabIndex = 2
            Me.BtnRejectOrder.Text = "✗ Tolak Pesanan"
            Me.BtnRejectOrder.UseVisualStyleBackColor = False
            '
            'BtnReloadOrders
            '
            Me.BtnReloadOrders.AutoSize = True
            Me.BtnReloadOrders.BackColor = System.Drawing.Color.White
            Me.BtnReloadOrders.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnReloadOrders.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 231, 235)
            Me.BtnReloadOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnReloadOrders.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.BtnReloadOrders.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.BtnReloadOrders.Location = New System.Drawing.Point(424, 4)
            Me.BtnReloadOrders.Margin = New System.Windows.Forms.Padding(0, 4, 8, 4)
            Me.BtnReloadOrders.Name = "BtnReloadOrders"
            Me.BtnReloadOrders.Size = New System.Drawing.Size(95, 38)
            Me.BtnReloadOrders.TabIndex = 3
            Me.BtnReloadOrders.Text = "Muat Ulang"
            Me.BtnReloadOrders.UseVisualStyleBackColor = False
            '
            'BillingTab
            '
            Me.BillingTab.BackColor = System.Drawing.Color.FromArgb(246, 248, 246)
            Me.BillingTab.Controls.Add(Me.BillingLayout)
            Me.BillingTab.Location = New System.Drawing.Point(4, 26)
            Me.BillingTab.Name = "BillingTab"
            Me.BillingTab.Padding = New System.Windows.Forms.Padding(10)
            Me.BillingTab.Size = New System.Drawing.Size(894, 520)
            Me.BillingTab.TabIndex = 2
            Me.BillingTab.Text = "Tagihan & Pembayaran"
            '
            'BillingLayout
            '
            Me.BillingLayout.ColumnCount = 2
            Me.BillingLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0F))
            Me.BillingLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0F))
            Me.BillingLayout.Controls.Add(Me.ExpensesPanel, 0, 0)
            Me.BillingLayout.Controls.Add(Me.SettlementsPanel, 1, 0)
            Me.BillingLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.BillingLayout.Location = New System.Drawing.Point(10, 10)
            Me.BillingLayout.Margin = New System.Windows.Forms.Padding(0)
            Me.BillingLayout.Name = "BillingLayout"
            Me.BillingLayout.RowCount = 1
            Me.BillingLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.BillingLayout.Size = New System.Drawing.Size(874, 500)
            Me.BillingLayout.TabIndex = 0
            '
            'ExpensesPanel
            '
            Me.ExpensesPanel.ColumnCount = 1
            Me.ExpensesPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.ExpensesPanel.Controls.Add(Me.ExpensesTitleLabel, 0, 0)
            Me.ExpensesPanel.Controls.Add(Me.ExpensesListBox, 0, 1)
            Me.ExpensesPanel.Controls.Add(Me.ExpenseDetailsTitleLabel, 0, 2)
            Me.ExpensesPanel.Controls.Add(Me.ExpenseDetailsTextBox, 0, 3)
            Me.ExpensesPanel.Controls.Add(Me.ExpenseActionsFlow, 0, 4)
            Me.ExpensesPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ExpensesPanel.Location = New System.Drawing.Point(0, 0)
            Me.ExpensesPanel.Margin = New System.Windows.Forms.Padding(0, 0, 8, 0)
            Me.ExpensesPanel.Name = "ExpensesPanel"
            Me.ExpensesPanel.RowCount = 5
            Me.ExpensesPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0F))
            Me.ExpensesPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0F))
            Me.ExpensesPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0F))
            Me.ExpensesPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0F))
            Me.ExpensesPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0F))
            Me.ExpensesPanel.Size = New System.Drawing.Size(429, 500)
            Me.ExpensesPanel.TabIndex = 0
            '
            'ExpensesTitleLabel
            '
            Me.ExpensesTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ExpensesTitleLabel.Font = New System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold)
            Me.ExpensesTitleLabel.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.ExpensesTitleLabel.Location = New System.Drawing.Point(0, 0)
            Me.ExpensesTitleLabel.Margin = New System.Windows.Forms.Padding(0)
            Me.ExpensesTitleLabel.Name = "ExpensesTitleLabel"
            Me.ExpensesTitleLabel.Size = New System.Drawing.Size(429, 28)
            Me.ExpensesTitleLabel.TabIndex = 0
            Me.ExpensesTitleLabel.Text = "Daftar Tagihan & Pengeluaran"
            '
            'ExpensesListBox
            '
            Me.ExpensesListBox.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.ExpensesListBox.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ExpensesListBox.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.ExpensesListBox.IntegralHeight = False
            Me.ExpensesListBox.ItemHeight = 17
            Me.ExpensesListBox.Location = New System.Drawing.Point(0, 28)
            Me.ExpensesListBox.Margin = New System.Windows.Forms.Padding(0)
            Me.ExpensesListBox.Name = "ExpensesListBox"
            Me.ExpensesListBox.Size = New System.Drawing.Size(429, 197)
            Me.ExpensesListBox.TabIndex = 1
            '
            'ExpenseDetailsTitleLabel
            '
            Me.ExpenseDetailsTitleLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ExpenseDetailsTitleLabel.Font = New System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold)
            Me.ExpenseDetailsTitleLabel.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.ExpenseDetailsTitleLabel.Location = New System.Drawing.Point(0, 225)
            Me.ExpenseDetailsTitleLabel.Margin = New System.Windows.Forms.Padding(0)
            Me.ExpenseDetailsTitleLabel.Name = "ExpenseDetailsTitleLabel"
            Me.ExpenseDetailsTitleLabel.Size = New System.Drawing.Size(429, 28)
            Me.ExpenseDetailsTitleLabel.TabIndex = 2
            Me.ExpenseDetailsTitleLabel.Text = "Rincian Tagihan Terpilih"
            '
            'ExpenseDetailsTextBox
            '
            Me.ExpenseDetailsTextBox.BackColor = System.Drawing.Color.White
            Me.ExpenseDetailsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.ExpenseDetailsTextBox.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ExpenseDetailsTextBox.Font = New System.Drawing.Font("Segoe UI", 9.5F)
            Me.ExpenseDetailsTextBox.Location = New System.Drawing.Point(0, 253)
            Me.ExpenseDetailsTextBox.Margin = New System.Windows.Forms.Padding(0)
            Me.ExpenseDetailsTextBox.Multiline = True
            Me.ExpenseDetailsTextBox.Name = "ExpenseDetailsTextBox"
            Me.ExpenseDetailsTextBox.ReadOnly = True
            Me.ExpenseDetailsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
            Me.ExpenseDetailsTextBox.Size = New System.Drawing.Size(429, 197)
            Me.ExpenseDetailsTextBox.TabIndex = 3
            '
            'ExpenseActionsFlow
            '
            Me.ExpenseActionsFlow.Controls.Add(Me.BtnBillFromOrders)
            Me.ExpenseActionsFlow.Controls.Add(Me.BtnAddExpense)
            Me.ExpenseActionsFlow.Controls.Add(Me.BtnDeleteExpense)
            Me.ExpenseActionsFlow.Controls.Add(Me.BtnReloadExpenses)
            Me.ExpenseActionsFlow.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ExpenseActionsFlow.Location = New System.Drawing.Point(0, 450)
            Me.ExpenseActionsFlow.Margin = New System.Windows.Forms.Padding(0)
            Me.ExpenseActionsFlow.Name = "ExpenseActionsFlow"
            Me.ExpenseActionsFlow.Size = New System.Drawing.Size(429, 50)
            Me.ExpenseActionsFlow.TabIndex = 4
            '
            'BtnBillFromOrders
            '
            Me.BtnBillFromOrders.AutoSize = True
            Me.BtnBillFromOrders.BackColor = System.Drawing.Color.FromArgb(47, 107, 79)
            Me.BtnBillFromOrders.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnBillFromOrders.FlatAppearance.BorderSize = 0
            Me.BtnBillFromOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnBillFromOrders.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.BtnBillFromOrders.ForeColor = System.Drawing.Color.White
            Me.BtnBillFromOrders.Location = New System.Drawing.Point(0, 4)
            Me.BtnBillFromOrders.Margin = New System.Windows.Forms.Padding(0, 4, 6, 4)
            Me.BtnBillFromOrders.Name = "BtnBillFromOrders"
            Me.BtnBillFromOrders.Size = New System.Drawing.Size(155, 38)
            Me.BtnBillFromOrders.TabIndex = 0
            Me.BtnBillFromOrders.Text = "🧾 Tagih dari Pesanan"
            Me.BtnBillFromOrders.UseVisualStyleBackColor = False
            '
            'BtnAddExpense
            '
            Me.BtnAddExpense.AutoSize = True
            Me.BtnAddExpense.BackColor = System.Drawing.Color.White
            Me.BtnAddExpense.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnAddExpense.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 231, 235)
            Me.BtnAddExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnAddExpense.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.BtnAddExpense.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.BtnAddExpense.Location = New System.Drawing.Point(161, 4)
            Me.BtnAddExpense.Margin = New System.Windows.Forms.Padding(0, 4, 6, 4)
            Me.BtnAddExpense.Name = "BtnAddExpense"
            Me.BtnAddExpense.Size = New System.Drawing.Size(190, 38)
            Me.BtnAddExpense.TabIndex = 1
            Me.BtnAddExpense.Text = "＋ Tambah Pengeluaran Manual"
            Me.BtnAddExpense.UseVisualStyleBackColor = False
            '
            'BtnDeleteExpense
            '
            Me.BtnDeleteExpense.AutoSize = True
            Me.BtnDeleteExpense.BackColor = System.Drawing.Color.White
            Me.BtnDeleteExpense.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnDeleteExpense.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 231, 235)
            Me.BtnDeleteExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnDeleteExpense.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.BtnDeleteExpense.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.BtnDeleteExpense.Location = New System.Drawing.Point(297, 4)
            Me.BtnDeleteExpense.Margin = New System.Windows.Forms.Padding(0, 4, 6, 4)
            Me.BtnDeleteExpense.Name = "BtnDeleteExpense"
            Me.BtnDeleteExpense.Size = New System.Drawing.Size(130, 38)
            Me.BtnDeleteExpense.TabIndex = 2
            Me.BtnDeleteExpense.Text = "Hapus Pengeluaran"
            Me.BtnDeleteExpense.UseVisualStyleBackColor = False
            '
            'BtnReloadExpenses
            '
            Me.BtnReloadExpenses.AutoSize = True
            Me.BtnReloadExpenses.BackColor = System.Drawing.Color.White
            Me.BtnReloadExpenses.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnReloadExpenses.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 231, 235)
            Me.BtnReloadExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnReloadExpenses.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.BtnReloadExpenses.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.BtnReloadExpenses.Location = New System.Drawing.Point(433, 4)
            Me.BtnReloadExpenses.Margin = New System.Windows.Forms.Padding(0, 4, 6, 4)
            Me.BtnReloadExpenses.Name = "BtnReloadExpenses"
            Me.BtnReloadExpenses.Size = New System.Drawing.Size(95, 38)
            Me.BtnReloadExpenses.TabIndex = 3
            Me.BtnReloadExpenses.Text = "Muat Ulang"
            Me.BtnReloadExpenses.UseVisualStyleBackColor = False
            '
            'SettlementsPanel
            '
            Me.SettlementsPanel.ColumnCount = 1
            Me.SettlementsPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.SettlementsPanel.Controls.Add(Me.BalanceHeaderLabel, 0, 0)
            Me.SettlementsPanel.Controls.Add(Me.BalancesListBox, 0, 1)
            Me.SettlementsPanel.Controls.Add(Me.TransferHeaderLabel, 0, 2)
            Me.SettlementsPanel.Controls.Add(Me.SettlementsListBox, 0, 3)
            Me.SettlementsPanel.Controls.Add(Me.SettlementActionsFlow, 0, 4)
            Me.SettlementsPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SettlementsPanel.Location = New System.Drawing.Point(445, 0)
            Me.SettlementsPanel.Margin = New System.Windows.Forms.Padding(8, 0, 0, 0)
            Me.SettlementsPanel.Name = "SettlementsPanel"
            Me.SettlementsPanel.RowCount = 5
            Me.SettlementsPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0F))
            Me.SettlementsPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0F))
            Me.SettlementsPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0F))
            Me.SettlementsPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0F))
            Me.SettlementsPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0F))
            Me.SettlementsPanel.Size = New System.Drawing.Size(429, 500)
            Me.SettlementsPanel.TabIndex = 1
            '
            'BalanceHeaderLabel
            '
            Me.BalanceHeaderLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.BalanceHeaderLabel.Font = New System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold)
            Me.BalanceHeaderLabel.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.BalanceHeaderLabel.Location = New System.Drawing.Point(0, 0)
            Me.BalanceHeaderLabel.Margin = New System.Windows.Forms.Padding(0)
            Me.BalanceHeaderLabel.Name = "BalanceHeaderLabel"
            Me.BalanceHeaderLabel.Size = New System.Drawing.Size(429, 28)
            Me.BalanceHeaderLabel.TabIndex = 0
            Me.BalanceHeaderLabel.Text = "Rekap Saldo Anggota"
            '
            'BalancesListBox
            '
            Me.BalancesListBox.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.BalancesListBox.Dock = System.Windows.Forms.DockStyle.Fill
            Me.BalancesListBox.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.BalancesListBox.IntegralHeight = False
            Me.BalancesListBox.ItemHeight = 17
            Me.BalancesListBox.Location = New System.Drawing.Point(0, 28)
            Me.BalancesListBox.Margin = New System.Windows.Forms.Padding(0)
            Me.BalancesListBox.Name = "BalancesListBox"
            Me.BalancesListBox.Size = New System.Drawing.Size(429, 197)
            Me.BalancesListBox.TabIndex = 1
            '
            'TransferHeaderLabel
            '
            Me.TransferHeaderLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TransferHeaderLabel.Font = New System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold)
            Me.TransferHeaderLabel.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.TransferHeaderLabel.Location = New System.Drawing.Point(0, 225)
            Me.TransferHeaderLabel.Margin = New System.Windows.Forms.Padding(0)
            Me.TransferHeaderLabel.Name = "TransferHeaderLabel"
            Me.TransferHeaderLabel.Size = New System.Drawing.Size(429, 28)
            Me.TransferHeaderLabel.TabIndex = 2
            Me.TransferHeaderLabel.Text = "Rekomendasi Transfer Pembayaran"
            '
            'SettlementsListBox
            '
            Me.SettlementsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.SettlementsListBox.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SettlementsListBox.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.SettlementsListBox.IntegralHeight = False
            Me.SettlementsListBox.ItemHeight = 17
            Me.SettlementsListBox.Location = New System.Drawing.Point(0, 253)
            Me.SettlementsListBox.Margin = New System.Windows.Forms.Padding(0)
            Me.SettlementsListBox.Name = "SettlementsListBox"
            Me.SettlementsListBox.Size = New System.Drawing.Size(429, 197)
            Me.SettlementsListBox.TabIndex = 3
            '
            'SettlementActionsFlow
            '
            Me.SettlementActionsFlow.Controls.Add(Me.BtnFinalize)
            Me.SettlementActionsFlow.Controls.Add(Me.BtnMarkPaid)
            Me.SettlementActionsFlow.Controls.Add(Me.BtnConfirmPaid)
            Me.SettlementActionsFlow.Controls.Add(Me.BtnReloadSettlements)
            Me.SettlementActionsFlow.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SettlementActionsFlow.Location = New System.Drawing.Point(0, 450)
            Me.SettlementActionsFlow.Margin = New System.Windows.Forms.Padding(0)
            Me.SettlementActionsFlow.Name = "SettlementActionsFlow"
            Me.SettlementActionsFlow.Size = New System.Drawing.Size(429, 50)
            Me.SettlementActionsFlow.TabIndex = 4
            '
            'BtnFinalize
            '
            Me.BtnFinalize.AutoSize = True
            Me.BtnFinalize.BackColor = System.Drawing.Color.FromArgb(47, 107, 79)
            Me.BtnFinalize.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnFinalize.FlatAppearance.BorderSize = 0
            Me.BtnFinalize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnFinalize.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.BtnFinalize.ForeColor = System.Drawing.Color.White
            Me.BtnFinalize.Location = New System.Drawing.Point(0, 4)
            Me.BtnFinalize.Margin = New System.Windows.Forms.Padding(0, 4, 6, 4)
            Me.BtnFinalize.Name = "BtnFinalize"
            Me.BtnFinalize.Size = New System.Drawing.Size(185, 38)
            Me.BtnFinalize.TabIndex = 0
            Me.BtnFinalize.Text = "⚡ Selesaikan & Kunci Tagihan"
            Me.BtnFinalize.UseVisualStyleBackColor = False
            '
            'BtnMarkPaid
            '
            Me.BtnMarkPaid.AutoSize = True
            Me.BtnMarkPaid.BackColor = System.Drawing.Color.FromArgb(47, 107, 79)
            Me.BtnMarkPaid.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnMarkPaid.FlatAppearance.BorderSize = 0
            Me.BtnMarkPaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnMarkPaid.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.BtnMarkPaid.ForeColor = System.Drawing.Color.White
            Me.BtnMarkPaid.Location = New System.Drawing.Point(161, 4)
            Me.BtnMarkPaid.Margin = New System.Windows.Forms.Padding(0, 4, 6, 4)
            Me.BtnMarkPaid.Name = "BtnMarkPaid"
            Me.BtnMarkPaid.Size = New System.Drawing.Size(155, 38)
            Me.BtnMarkPaid.TabIndex = 1
            Me.BtnMarkPaid.Text = "✓ Tandai Sudah Bayar"
            Me.BtnMarkPaid.UseVisualStyleBackColor = False
            '
            'BtnConfirmPaid
            '
            Me.BtnConfirmPaid.AutoSize = True
            Me.BtnConfirmPaid.BackColor = System.Drawing.Color.FromArgb(47, 107, 79)
            Me.BtnConfirmPaid.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnConfirmPaid.FlatAppearance.BorderSize = 0
            Me.BtnConfirmPaid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnConfirmPaid.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.BtnConfirmPaid.ForeColor = System.Drawing.Color.White
            Me.BtnConfirmPaid.Location = New System.Drawing.Point(322, 4)
            Me.BtnConfirmPaid.Margin = New System.Windows.Forms.Padding(0, 4, 6, 4)
            Me.BtnConfirmPaid.Name = "BtnConfirmPaid"
            Me.BtnConfirmPaid.Size = New System.Drawing.Size(155, 38)
            Me.BtnConfirmPaid.TabIndex = 2
            Me.BtnConfirmPaid.Text = "✓ Konfirmasi Diterima"
            Me.BtnConfirmPaid.UseVisualStyleBackColor = False
            '
            'BtnReloadSettlements
            '
            Me.BtnReloadSettlements.AutoSize = True
            Me.BtnReloadSettlements.BackColor = System.Drawing.Color.White
            Me.BtnReloadSettlements.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnReloadSettlements.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 231, 235)
            Me.BtnReloadSettlements.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnReloadSettlements.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.BtnReloadSettlements.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.BtnReloadSettlements.Location = New System.Drawing.Point(483, 4)
            Me.BtnReloadSettlements.Margin = New System.Windows.Forms.Padding(0, 4, 6, 4)
            Me.BtnReloadSettlements.Name = "BtnReloadSettlements"
            Me.BtnReloadSettlements.Size = New System.Drawing.Size(95, 38)
            Me.BtnReloadSettlements.TabIndex = 3
            Me.BtnReloadSettlements.Text = "Muat Ulang"
            Me.BtnReloadSettlements.UseVisualStyleBackColor = False
            '
            'RequestsTab
            '
            Me.RequestsTab.BackColor = System.Drawing.Color.FromArgb(246, 248, 246)
            Me.RequestsTab.Controls.Add(Me.RequestsLayout)
            Me.RequestsTab.Location = New System.Drawing.Point(4, 26)
            Me.RequestsTab.Name = "RequestsTab"
            Me.RequestsTab.Padding = New System.Windows.Forms.Padding(10)
            Me.RequestsTab.Size = New System.Drawing.Size(894, 520)
            Me.RequestsTab.TabIndex = 3
            Me.RequestsTab.Text = "Permintaan bergabung"
            '
            'RequestsLayout
            '
            Me.RequestsLayout.ColumnCount = 1
            Me.RequestsLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.RequestsLayout.Controls.Add(Me.RequestsListBox, 0, 0)
            Me.RequestsLayout.Controls.Add(Me.RequestActionsFlow, 0, 1)
            Me.RequestsLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.RequestsLayout.Location = New System.Drawing.Point(10, 10)
            Me.RequestsLayout.Margin = New System.Windows.Forms.Padding(0)
            Me.RequestsLayout.Name = "RequestsLayout"
            Me.RequestsLayout.RowCount = 2
            Me.RequestsLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.RequestsLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0F))
            Me.RequestsLayout.Size = New System.Drawing.Size(874, 500)
            Me.RequestsLayout.TabIndex = 0
            '
            'RequestsListBox
            '
            Me.RequestsListBox.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.RequestsListBox.Dock = System.Windows.Forms.DockStyle.Fill
            Me.RequestsListBox.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.RequestsListBox.IntegralHeight = False
            Me.RequestsListBox.ItemHeight = 17
            Me.RequestsListBox.Location = New System.Drawing.Point(0, 0)
            Me.RequestsListBox.Margin = New System.Windows.Forms.Padding(0)
            Me.RequestsListBox.Name = "RequestsListBox"
            Me.RequestsListBox.Size = New System.Drawing.Size(874, 450)
            Me.RequestsListBox.TabIndex = 0
            '
            'RequestActionsFlow
            '
            Me.RequestActionsFlow.Controls.Add(Me.BtnApproveRequest)
            Me.RequestActionsFlow.Controls.Add(Me.BtnRejectRequest)
            Me.RequestActionsFlow.Dock = System.Windows.Forms.DockStyle.Fill
            Me.RequestActionsFlow.Location = New System.Drawing.Point(0, 450)
            Me.RequestActionsFlow.Margin = New System.Windows.Forms.Padding(0)
            Me.RequestActionsFlow.Name = "RequestActionsFlow"
            Me.RequestActionsFlow.Size = New System.Drawing.Size(874, 50)
            Me.RequestActionsFlow.TabIndex = 1
            '
            'BtnApproveRequest
            '
            Me.BtnApproveRequest.AutoSize = True
            Me.BtnApproveRequest.BackColor = System.Drawing.Color.FromArgb(47, 107, 79)
            Me.BtnApproveRequest.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnApproveRequest.FlatAppearance.BorderSize = 0
            Me.BtnApproveRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnApproveRequest.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.BtnApproveRequest.ForeColor = System.Drawing.Color.White
            Me.BtnApproveRequest.Location = New System.Drawing.Point(0, 4)
            Me.BtnApproveRequest.Margin = New System.Windows.Forms.Padding(0, 4, 8, 4)
            Me.BtnApproveRequest.Name = "BtnApproveRequest"
            Me.BtnApproveRequest.Size = New System.Drawing.Size(100, 38)
            Me.BtnApproveRequest.TabIndex = 0
            Me.BtnApproveRequest.Text = "Setujui"
            Me.BtnApproveRequest.UseVisualStyleBackColor = False
            '
            'BtnRejectRequest
            '
            Me.BtnRejectRequest.AutoSize = True
            Me.BtnRejectRequest.BackColor = System.Drawing.Color.White
            Me.BtnRejectRequest.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnRejectRequest.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 231, 235)
            Me.BtnRejectRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnRejectRequest.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.BtnRejectRequest.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.BtnRejectRequest.Location = New System.Drawing.Point(108, 4)
            Me.BtnRejectRequest.Margin = New System.Windows.Forms.Padding(0, 4, 8, 4)
            Me.BtnRejectRequest.Name = "BtnRejectRequest"
            Me.BtnRejectRequest.Size = New System.Drawing.Size(100, 38)
            Me.BtnRejectRequest.TabIndex = 1
            Me.BtnRejectRequest.Text = "Tolak"
            Me.BtnRejectRequest.UseVisualStyleBackColor = False
            '
            'StatusLabel
            '
            Me.StatusLabel.AutoSize = True
            Me.StatusLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.StatusLabel.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128)
            Me.StatusLabel.Location = New System.Drawing.Point(24, 635)
            Me.StatusLabel.Name = "StatusLabel"
            Me.StatusLabel.Size = New System.Drawing.Size(902, 45)
            Me.StatusLabel.TabIndex = 2
            '
            'GroupDetailPage
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(246, 248, 246)
            Me.Controls.Add(Me.ShellLayout)
            Me.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.Name = "GroupDetailPage"
            Me.Size = New System.Drawing.Size(950, 700)
            Me.ShellLayout.ResumeLayout(False)
            Me.HeaderLayout.ResumeLayout(False)
            Me.HeaderLayout.PerformLayout()
            Me.TabsControl.ResumeLayout(False)
            Me.MembersTab.ResumeLayout(False)
            Me.MembersLayout.ResumeLayout(False)
            Me.InviteBarFlow.ResumeLayout(False)
            Me.InviteBarFlow.PerformLayout()
            Me.MemberActionsFlow.ResumeLayout(False)
            Me.MemberActionsFlow.PerformLayout()
            Me.OrdersTab.ResumeLayout(False)
            Me.OrdersLayout.ResumeLayout(False)
            Me.OrderActionsFlow.ResumeLayout(False)
            Me.OrderActionsFlow.PerformLayout()
            Me.BillingTab.ResumeLayout(False)
            Me.BillingLayout.ResumeLayout(False)
            Me.ExpensesPanel.ResumeLayout(False)
            Me.ExpensesPanel.PerformLayout()
            Me.ExpenseActionsFlow.ResumeLayout(False)
            Me.ExpenseActionsFlow.PerformLayout()
            Me.SettlementsPanel.ResumeLayout(False)
            Me.SettlementActionsFlow.ResumeLayout(False)
            Me.SettlementActionsFlow.PerformLayout()
            Me.RequestsTab.ResumeLayout(False)
            Me.RequestsLayout.ResumeLayout(False)
            Me.RequestActionsFlow.ResumeLayout(False)
            Me.RequestActionsFlow.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents ShellLayout As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents HeaderLayout As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents TitleLabel As System.Windows.Forms.Label
        Friend WithEvents SubtitleLabel As System.Windows.Forms.Label
        Friend WithEvents BtnEditGroup As System.Windows.Forms.Button
        Friend WithEvents TabsControl As System.Windows.Forms.TabControl
        Friend WithEvents MembersTab As System.Windows.Forms.TabPage
        Friend WithEvents MembersLayout As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents InviteBarFlow As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents InviteLabel As System.Windows.Forms.Label
        Friend WithEvents BtnCopyInvite As System.Windows.Forms.Button
        Friend WithEvents InviteEnabledCheck As System.Windows.Forms.CheckBox
        Friend WithEvents BtnRotateInvite As System.Windows.Forms.Button
        Friend WithEvents MembersListBox As System.Windows.Forms.ListBox
        Friend WithEvents MemberActionsFlow As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents BtnAddMember As System.Windows.Forms.Button
        Friend WithEvents BtnRemoveMember As System.Windows.Forms.Button
        Friend WithEvents BtnReloadMembers As System.Windows.Forms.Button
        Friend WithEvents OrdersTab As System.Windows.Forms.TabPage
        Friend WithEvents OrdersLayout As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents OrdersListBox As System.Windows.Forms.ListBox
        Friend WithEvents OrderActionsFlow As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents BtnSubmitOrder As System.Windows.Forms.Button
        Friend WithEvents BtnApproveOrder As System.Windows.Forms.Button
        Friend WithEvents BtnRejectOrder As System.Windows.Forms.Button
        Friend WithEvents BtnReloadOrders As System.Windows.Forms.Button
        Friend WithEvents BillingTab As System.Windows.Forms.TabPage
        Friend WithEvents BillingLayout As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents ExpensesPanel As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents ExpensesTitleLabel As System.Windows.Forms.Label
        Friend WithEvents ExpensesListBox As System.Windows.Forms.ListBox
        Friend WithEvents ExpenseDetailsTitleLabel As System.Windows.Forms.Label
        Friend WithEvents ExpenseDetailsTextBox As System.Windows.Forms.TextBox
        Friend WithEvents ExpenseActionsFlow As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents BtnBillFromOrders As System.Windows.Forms.Button
        Friend WithEvents BtnAddExpense As System.Windows.Forms.Button
        Friend WithEvents BtnDeleteExpense As System.Windows.Forms.Button
        Friend WithEvents BtnReloadExpenses As System.Windows.Forms.Button
        Friend WithEvents SettlementsPanel As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents BalanceHeaderLabel As System.Windows.Forms.Label
        Friend WithEvents BalancesListBox As System.Windows.Forms.ListBox
        Friend WithEvents TransferHeaderLabel As System.Windows.Forms.Label
        Friend WithEvents SettlementsListBox As System.Windows.Forms.ListBox
        Friend WithEvents SettlementActionsFlow As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents BtnFinalize As System.Windows.Forms.Button
        Friend WithEvents BtnMarkPaid As System.Windows.Forms.Button
        Friend WithEvents BtnConfirmPaid As System.Windows.Forms.Button
        Friend WithEvents BtnReloadSettlements As System.Windows.Forms.Button
        Friend WithEvents RequestsTab As System.Windows.Forms.TabPage
        Friend WithEvents RequestsLayout As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents RequestsListBox As System.Windows.Forms.ListBox
        Friend WithEvents RequestActionsFlow As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents BtnApproveRequest As System.Windows.Forms.Button
        Friend WithEvents BtnRejectRequest As System.Windows.Forms.Button
        Friend WithEvents StatusLabel As System.Windows.Forms.Label
    End Class
End Namespace
