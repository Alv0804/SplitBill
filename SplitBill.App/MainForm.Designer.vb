Namespace Global.SplitBill.App
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class MainForm
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
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
            Me.RootLayout = New System.Windows.Forms.TableLayoutPanel()
            Me.SidebarPanel = New System.Windows.Forms.Panel()
            Me.SidebarLayout = New System.Windows.Forms.TableLayoutPanel()
            Me.BrandContainer = New System.Windows.Forms.TableLayoutPanel()
            Me.LogoBadge = New System.Windows.Forms.Label()
            Me.BrandTextStack = New System.Windows.Forms.FlowLayoutPanel()
            Me.BrandTitle = New System.Windows.Forms.Label()
            Me.BrandSubtitle = New System.Windows.Forms.Label()
            Me.MenuContainer = New System.Windows.Forms.FlowLayoutPanel()
            Me.MenuCategoryLabel = New System.Windows.Forms.Label()
            Me.BtnNavDashboard = New System.Windows.Forms.Button()
            Me.BtnNavKegiatan = New System.Windows.Forms.Button()
            Me.BtnNavTeman = New System.Windows.Forms.Button()
            Me.BtnNavTempat = New System.Windows.Forms.Button()
            Me.BtnNavRiwayat = New System.Windows.Forms.Button()
            Me.GuestCard = New System.Windows.Forms.Panel()
            Me.GuestStack = New System.Windows.Forms.FlowLayoutPanel()
            Me.GuestTitle = New System.Windows.Forms.Label()
            Me.GuestSub = New System.Windows.Forms.Label()
            Me.ProfileContainer = New System.Windows.Forms.TableLayoutPanel()
            Me.UserAvatarLabel = New System.Windows.Forms.Label()
            Me.UserTextStack = New System.Windows.Forms.FlowLayoutPanel()
            Me.UserNameLabel = New System.Windows.Forms.Label()
            Me.RoleLabel = New System.Windows.Forms.Label()
            Me.SignOutButton = New System.Windows.Forms.Button()
            Me.ContentHost = New System.Windows.Forms.Panel()
            Me.RootLayout.SuspendLayout()
            Me.SidebarPanel.SuspendLayout()
            Me.SidebarLayout.SuspendLayout()
            Me.BrandContainer.SuspendLayout()
            Me.BrandTextStack.SuspendLayout()
            Me.MenuContainer.SuspendLayout()
            Me.GuestCard.SuspendLayout()
            Me.GuestStack.SuspendLayout()
            Me.ProfileContainer.SuspendLayout()
            Me.UserTextStack.SuspendLayout()
            Me.SuspendLayout()
            '
            'RootLayout
            '
            Me.RootLayout.BackColor = System.Drawing.Color.FromArgb(246, 248, 246)
            Me.RootLayout.ColumnCount = 2
            Me.RootLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260.0F))
            Me.RootLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.RootLayout.Controls.Add(Me.SidebarPanel, 0, 0)
            Me.RootLayout.Controls.Add(Me.ContentHost, 1, 0)
            Me.RootLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.RootLayout.Location = New System.Drawing.Point(0, 0)
            Me.RootLayout.Margin = New System.Windows.Forms.Padding(0)
            Me.RootLayout.Name = "RootLayout"
            Me.RootLayout.RowCount = 1
            Me.RootLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.RootLayout.Size = New System.Drawing.Size(1264, 801)
            Me.RootLayout.TabIndex = 0
            '
            'SidebarPanel
            '
            Me.SidebarPanel.BackColor = System.Drawing.Color.White
            Me.SidebarPanel.Controls.Add(Me.SidebarLayout)
            Me.SidebarPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SidebarPanel.Location = New System.Drawing.Point(0, 0)
            Me.SidebarPanel.Margin = New System.Windows.Forms.Padding(0)
            Me.SidebarPanel.Name = "SidebarPanel"
            Me.SidebarPanel.Size = New System.Drawing.Size(260, 801)
            Me.SidebarPanel.TabIndex = 0
            '
            'SidebarLayout
            '
            Me.SidebarLayout.BackColor = System.Drawing.Color.White
            Me.SidebarLayout.ColumnCount = 1
            Me.SidebarLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.SidebarLayout.Controls.Add(Me.BrandContainer, 0, 0)
            Me.SidebarLayout.Controls.Add(Me.MenuContainer, 0, 1)
            Me.SidebarLayout.Controls.Add(Me.GuestCard, 0, 2)
            Me.SidebarLayout.Controls.Add(Me.ProfileContainer, 0, 3)
            Me.SidebarLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SidebarLayout.Location = New System.Drawing.Point(0, 0)
            Me.SidebarLayout.Name = "SidebarLayout"
            Me.SidebarLayout.Padding = New System.Windows.Forms.Padding(14, 16, 14, 14)
            Me.SidebarLayout.RowCount = 4
            Me.SidebarLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68.0F))
            Me.SidebarLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.SidebarLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76.0F))
            Me.SidebarLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68.0F))
            Me.SidebarLayout.Size = New System.Drawing.Size(260, 801)
            Me.SidebarLayout.TabIndex = 0
            '
            'BrandContainer
            '
            Me.BrandContainer.BackColor = System.Drawing.Color.White
            Me.BrandContainer.ColumnCount = 2
            Me.BrandContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46.0F))
            Me.BrandContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.BrandContainer.Controls.Add(Me.LogoBadge, 0, 0)
            Me.BrandContainer.Controls.Add(Me.BrandTextStack, 1, 0)
            Me.BrandContainer.Dock = System.Windows.Forms.DockStyle.Fill
            Me.BrandContainer.Location = New System.Drawing.Point(14, 16)
            Me.BrandContainer.Margin = New System.Windows.Forms.Padding(0)
            Me.BrandContainer.Name = "BrandContainer"
            Me.BrandContainer.RowCount = 1
            Me.BrandContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.BrandContainer.Size = New System.Drawing.Size(232, 68)
            Me.BrandContainer.TabIndex = 0
            '
            'LogoBadge
            '
            Me.LogoBadge.BackColor = System.Drawing.Color.FromArgb(47, 107, 79)
            Me.LogoBadge.Font = New System.Drawing.Font("Segoe UI", 15.0F, System.Drawing.FontStyle.Bold)
            Me.LogoBadge.ForeColor = System.Drawing.Color.White
            Me.LogoBadge.Location = New System.Drawing.Point(0, 4)
            Me.LogoBadge.Margin = New System.Windows.Forms.Padding(0, 4, 0, 0)
            Me.LogoBadge.Name = "LogoBadge"
            Me.LogoBadge.Size = New System.Drawing.Size(40, 40)
            Me.LogoBadge.TabIndex = 0
            Me.LogoBadge.Text = "👛"
            Me.LogoBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'BrandTextStack
            '
            Me.BrandTextStack.BackColor = System.Drawing.Color.White
            Me.BrandTextStack.Controls.Add(Me.BrandTitle)
            Me.BrandTextStack.Controls.Add(Me.BrandSubtitle)
            Me.BrandTextStack.Dock = System.Windows.Forms.DockStyle.Fill
            Me.BrandTextStack.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
            Me.BrandTextStack.Location = New System.Drawing.Point(46, 0)
            Me.BrandTextStack.Margin = New System.Windows.Forms.Padding(0)
            Me.BrandTextStack.Name = "BrandTextStack"
            Me.BrandTextStack.Padding = New System.Windows.Forms.Padding(6, 2, 0, 0)
            Me.BrandTextStack.Size = New System.Drawing.Size(186, 68)
            Me.BrandTextStack.TabIndex = 1
            Me.BrandTextStack.WrapContents = False
            '
            'BrandTitle
            '
            Me.BrandTitle.AutoSize = True
            Me.BrandTitle.Font = New System.Drawing.Font("Segoe UI", 15.5F, System.Drawing.FontStyle.Bold)
            Me.BrandTitle.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.BrandTitle.Location = New System.Drawing.Point(6, 2)
            Me.BrandTitle.Margin = New System.Windows.Forms.Padding(0)
            Me.BrandTitle.Name = "BrandTitle"
            Me.BrandTitle.Size = New System.Drawing.Size(100, 30)
            Me.BrandTitle.TabIndex = 0
            Me.BrandTitle.Text = "SplitBill"
            '
            'BrandSubtitle
            '
            Me.BrandSubtitle.AutoSize = True
            Me.BrandSubtitle.Font = New System.Drawing.Font("Segoe UI", 8.0F)
            Me.BrandSubtitle.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128)
            Me.BrandSubtitle.Location = New System.Drawing.Point(6, 32)
            Me.BrandSubtitle.Margin = New System.Windows.Forms.Padding(0)
            Me.BrandSubtitle.Name = "BrandSubtitle"
            Me.BrandSubtitle.Size = New System.Drawing.Size(135, 13)
            Me.BrandSubtitle.TabIndex = 1
            Me.BrandSubtitle.Text = "Group Expense Manager"
            '
            'MenuContainer
            '
            Me.MenuContainer.AutoScroll = False
            Me.MenuContainer.BackColor = System.Drawing.Color.White
            Me.MenuContainer.Controls.Add(Me.MenuCategoryLabel)
            Me.MenuContainer.Controls.Add(Me.BtnNavDashboard)
            Me.MenuContainer.Controls.Add(Me.BtnNavKegiatan)
            Me.MenuContainer.Controls.Add(Me.BtnNavTeman)
            Me.MenuContainer.Controls.Add(Me.BtnNavTempat)
            Me.MenuContainer.Controls.Add(Me.BtnNavRiwayat)
            Me.MenuContainer.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MenuContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
            Me.MenuContainer.Location = New System.Drawing.Point(14, 84)
            Me.MenuContainer.Margin = New System.Windows.Forms.Padding(0)
            Me.MenuContainer.Name = "MenuContainer"
            Me.MenuContainer.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
            Me.MenuContainer.Size = New System.Drawing.Size(232, 559)
            Me.MenuContainer.TabIndex = 1
            Me.MenuContainer.WrapContents = False
            '
            'MenuCategoryLabel
            '
            Me.MenuCategoryLabel.AutoSize = True
            Me.MenuCategoryLabel.Font = New System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold)
            Me.MenuCategoryLabel.ForeColor = System.Drawing.Color.FromArgb(156, 163, 175)
            Me.MenuCategoryLabel.Location = New System.Drawing.Point(12, 10)
            Me.MenuCategoryLabel.Margin = New System.Windows.Forms.Padding(12, 0, 0, 10)
            Me.MenuCategoryLabel.Name = "MenuCategoryLabel"
            Me.MenuCategoryLabel.Size = New System.Drawing.Size(76, 12)
            Me.MenuCategoryLabel.TabIndex = 0
            Me.MenuCategoryLabel.Text = "MENU UTAMA"
            '
            'BtnNavDashboard
            '
            Me.BtnNavDashboard.BackColor = System.Drawing.Color.White
            Me.BtnNavDashboard.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnNavDashboard.FlatAppearance.BorderSize = 0
            Me.BtnNavDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(243, 244, 246)
            Me.BtnNavDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnNavDashboard.Font = New System.Drawing.Font("Segoe UI", 9.5F)
            Me.BtnNavDashboard.ForeColor = System.Drawing.Color.FromArgb(75, 85, 99)
            Me.BtnNavDashboard.Location = New System.Drawing.Point(0, 24)
            Me.BtnNavDashboard.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
            Me.BtnNavDashboard.Name = "BtnNavDashboard"
            Me.BtnNavDashboard.Padding = New System.Windows.Forms.Padding(14, 0, 0, 0)
            Me.BtnNavDashboard.Size = New System.Drawing.Size(226, 44)
            Me.BtnNavDashboard.TabIndex = 1
            Me.BtnNavDashboard.Text = "⊞   Dashboard"
            Me.BtnNavDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.BtnNavDashboard.UseVisualStyleBackColor = False
            '
            'BtnNavKegiatan
            '
            Me.BtnNavKegiatan.BackColor = System.Drawing.Color.White
            Me.BtnNavKegiatan.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnNavKegiatan.FlatAppearance.BorderSize = 0
            Me.BtnNavKegiatan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(243, 244, 246)
            Me.BtnNavKegiatan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnNavKegiatan.Font = New System.Drawing.Font("Segoe UI", 9.5F)
            Me.BtnNavKegiatan.ForeColor = System.Drawing.Color.FromArgb(75, 85, 99)
            Me.BtnNavKegiatan.Location = New System.Drawing.Point(0, 72)
            Me.BtnNavKegiatan.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
            Me.BtnNavKegiatan.Name = "BtnNavKegiatan"
            Me.BtnNavKegiatan.Padding = New System.Windows.Forms.Padding(14, 0, 0, 0)
            Me.BtnNavKegiatan.Size = New System.Drawing.Size(226, 44)
            Me.BtnNavKegiatan.TabIndex = 2
            Me.BtnNavKegiatan.Text = "📅   Kegiatan"
            Me.BtnNavKegiatan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.BtnNavKegiatan.UseVisualStyleBackColor = False
            '
            'BtnNavTeman
            '
            Me.BtnNavTeman.BackColor = System.Drawing.Color.White
            Me.BtnNavTeman.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnNavTeman.FlatAppearance.BorderSize = 0
            Me.BtnNavTeman.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(243, 244, 246)
            Me.BtnNavTeman.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnNavTeman.Font = New System.Drawing.Font("Segoe UI", 9.5F)
            Me.BtnNavTeman.ForeColor = System.Drawing.Color.FromArgb(75, 85, 99)
            Me.BtnNavTeman.Location = New System.Drawing.Point(0, 120)
            Me.BtnNavTeman.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
            Me.BtnNavTeman.Name = "BtnNavTeman"
            Me.BtnNavTeman.Padding = New System.Windows.Forms.Padding(14, 0, 0, 0)
            Me.BtnNavTeman.Size = New System.Drawing.Size(226, 44)
            Me.BtnNavTeman.TabIndex = 3
            Me.BtnNavTeman.Text = "👥   Teman"
            Me.BtnNavTeman.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.BtnNavTeman.UseVisualStyleBackColor = False
            '
            'BtnNavTempat
            '
            Me.BtnNavTempat.BackColor = System.Drawing.Color.White
            Me.BtnNavTempat.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnNavTempat.FlatAppearance.BorderSize = 0
            Me.BtnNavTempat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(243, 244, 246)
            Me.BtnNavTempat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnNavTempat.Font = New System.Drawing.Font("Segoe UI", 9.5F)
            Me.BtnNavTempat.ForeColor = System.Drawing.Color.FromArgb(75, 85, 99)
            Me.BtnNavTempat.Location = New System.Drawing.Point(0, 168)
            Me.BtnNavTempat.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
            Me.BtnNavTempat.Name = "BtnNavTempat"
            Me.BtnNavTempat.Padding = New System.Windows.Forms.Padding(14, 0, 0, 0)
            Me.BtnNavTempat.Size = New System.Drawing.Size(226, 44)
            Me.BtnNavTempat.TabIndex = 4
            Me.BtnNavTempat.Text = "📍   Tempat"
            Me.BtnNavTempat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.BtnNavTempat.UseVisualStyleBackColor = False
            '
            'BtnNavRiwayat
            '
            Me.BtnNavRiwayat.BackColor = System.Drawing.Color.White
            Me.BtnNavRiwayat.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnNavRiwayat.FlatAppearance.BorderSize = 0
            Me.BtnNavRiwayat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(243, 244, 246)
            Me.BtnNavRiwayat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnNavRiwayat.Font = New System.Drawing.Font("Segoe UI", 9.5F)
            Me.BtnNavRiwayat.ForeColor = System.Drawing.Color.FromArgb(75, 85, 99)
            Me.BtnNavRiwayat.Location = New System.Drawing.Point(0, 216)
            Me.BtnNavRiwayat.Margin = New System.Windows.Forms.Padding(0, 2, 0, 2)
            Me.BtnNavRiwayat.Name = "BtnNavRiwayat"
            Me.BtnNavRiwayat.Padding = New System.Windows.Forms.Padding(14, 0, 0, 0)
            Me.BtnNavRiwayat.Size = New System.Drawing.Size(226, 44)
            Me.BtnNavRiwayat.TabIndex = 5
            Me.BtnNavRiwayat.Text = "⏱️   Riwayat"
            Me.BtnNavRiwayat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.BtnNavRiwayat.UseVisualStyleBackColor = False
            '
            'GuestCard
            '
            Me.GuestCard.BackColor = System.Drawing.Color.FromArgb(240, 253, 244)
            Me.GuestCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.GuestCard.Controls.Add(Me.GuestStack)
            Me.GuestCard.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GuestCard.Location = New System.Drawing.Point(14, 647)
            Me.GuestCard.Margin = New System.Windows.Forms.Padding(0, 4, 0, 8)
            Me.GuestCard.Name = "GuestCard"
            Me.GuestCard.Padding = New System.Windows.Forms.Padding(10, 8, 10, 8)
            Me.GuestCard.Size = New System.Drawing.Size(232, 64)
            Me.GuestCard.TabIndex = 2
            '
            'GuestStack
            '
            Me.GuestStack.BackColor = System.Drawing.Color.FromArgb(240, 253, 244)
            Me.GuestStack.Controls.Add(Me.GuestTitle)
            Me.GuestStack.Controls.Add(Me.GuestSub)
            Me.GuestStack.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GuestStack.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
            Me.GuestStack.Location = New System.Drawing.Point(10, 8)
            Me.GuestStack.Margin = New System.Windows.Forms.Padding(0)
            Me.GuestStack.Name = "GuestStack"
            Me.GuestStack.Size = New System.Drawing.Size(210, 46)
            Me.GuestStack.TabIndex = 0
            Me.GuestStack.WrapContents = False
            '
            'GuestTitle
            '
            Me.GuestTitle.AutoSize = True
            Me.GuestTitle.Font = New System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold)
            Me.GuestTitle.ForeColor = System.Drawing.Color.FromArgb(22, 101, 52)
            Me.GuestTitle.Location = New System.Drawing.Point(0, 0)
            Me.GuestTitle.Margin = New System.Windows.Forms.Padding(0)
            Me.GuestTitle.Name = "GuestTitle"
            Me.GuestTitle.Size = New System.Drawing.Size(107, 15)
            Me.GuestTitle.TabIndex = 0
            Me.GuestTitle.Text = "🛡️  Guest Member"
            '
            'GuestSub
            '
            Me.GuestSub.AutoSize = True
            Me.GuestSub.Font = New System.Drawing.Font("Segoe UI", 7.5F)
            Me.GuestSub.ForeColor = System.Drawing.Color.FromArgb(21, 128, 61)
            Me.GuestSub.Location = New System.Drawing.Point(0, 18)
            Me.GuestSub.Margin = New System.Windows.Forms.Padding(0, 3, 0, 0)
            Me.GuestSub.Name = "GuestSub"
            Me.GuestSub.Size = New System.Drawing.Size(175, 12)
            Me.GuestSub.TabIndex = 1
            Me.GuestSub.Text = "Gabung kegiatan dengan kode teman."
            '
            'ProfileContainer
            '
            Me.ProfileContainer.BackColor = System.Drawing.Color.White
            Me.ProfileContainer.ColumnCount = 3
            Me.ProfileContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 38.0F))
            Me.ProfileContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.ProfileContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78.0F))
            Me.ProfileContainer.Controls.Add(Me.UserAvatarLabel, 0, 0)
            Me.ProfileContainer.Controls.Add(Me.UserTextStack, 1, 0)
            Me.ProfileContainer.Controls.Add(Me.SignOutButton, 2, 0)
            Me.ProfileContainer.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ProfileContainer.Location = New System.Drawing.Point(14, 719)
            Me.ProfileContainer.Margin = New System.Windows.Forms.Padding(0)
            Me.ProfileContainer.Name = "ProfileContainer"
            Me.ProfileContainer.RowCount = 1
            Me.ProfileContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.ProfileContainer.Size = New System.Drawing.Size(232, 68)
            Me.ProfileContainer.TabIndex = 3
            '
            'UserAvatarLabel
            '
            Me.UserAvatarLabel.BackColor = System.Drawing.Color.FromArgb(240, 253, 244)
            Me.UserAvatarLabel.Font = New System.Drawing.Font("Segoe UI", 11.0F, System.Drawing.FontStyle.Bold)
            Me.UserAvatarLabel.ForeColor = System.Drawing.Color.FromArgb(47, 107, 79)
            Me.UserAvatarLabel.Location = New System.Drawing.Point(0, 6)
            Me.UserAvatarLabel.Margin = New System.Windows.Forms.Padding(0, 6, 0, 0)
            Me.UserAvatarLabel.Name = "UserAvatarLabel"
            Me.UserAvatarLabel.Size = New System.Drawing.Size(34, 34)
            Me.UserAvatarLabel.TabIndex = 0
            Me.UserAvatarLabel.Text = "P"
            Me.UserAvatarLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'UserTextStack
            '
            Me.UserTextStack.BackColor = System.Drawing.Color.White
            Me.UserTextStack.Controls.Add(Me.UserNameLabel)
            Me.UserTextStack.Controls.Add(Me.RoleLabel)
            Me.UserTextStack.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UserTextStack.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
            Me.UserTextStack.Location = New System.Drawing.Point(38, 0)
            Me.UserTextStack.Margin = New System.Windows.Forms.Padding(0)
            Me.UserTextStack.Name = "UserTextStack"
            Me.UserTextStack.Padding = New System.Windows.Forms.Padding(4, 4, 0, 0)
            Me.UserTextStack.Size = New System.Drawing.Size(116, 68)
            Me.UserTextStack.TabIndex = 1
            Me.UserTextStack.WrapContents = False
            '
            'UserNameLabel
            '
            Me.UserNameLabel.AutoEllipsis = True
            Me.UserNameLabel.AutoSize = True
            Me.UserNameLabel.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.UserNameLabel.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.UserNameLabel.Location = New System.Drawing.Point(4, 4)
            Me.UserNameLabel.Margin = New System.Windows.Forms.Padding(0)
            Me.UserNameLabel.MaximumSize = New System.Drawing.Size(110, 0)
            Me.UserNameLabel.Name = "UserNameLabel"
            Me.UserNameLabel.Size = New System.Drawing.Size(61, 15)
            Me.UserNameLabel.TabIndex = 0
            Me.UserNameLabel.Text = "Pengguna"
            '
            'RoleLabel
            '
            Me.RoleLabel.AutoSize = True
            Me.RoleLabel.Font = New System.Drawing.Font("Segoe UI", 7.5F)
            Me.RoleLabel.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128)
            Me.RoleLabel.Location = New System.Drawing.Point(4, 19)
            Me.RoleLabel.Margin = New System.Windows.Forms.Padding(0)
            Me.RoleLabel.Name = "RoleLabel"
            Me.RoleLabel.Size = New System.Drawing.Size(53, 12)
            Me.RoleLabel.TabIndex = 1
            Me.RoleLabel.Text = "Akun Aktif"
            '
            'SignOutButton
            '
            Me.SignOutButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.SignOutButton.BackColor = System.Drawing.Color.FromArgb(254, 242, 242)
            Me.SignOutButton.Cursor = System.Windows.Forms.Cursors.Hand
            Me.SignOutButton.FlatAppearance.BorderSize = 0
            Me.SignOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.SignOutButton.Font = New System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold)
            Me.SignOutButton.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38)
            Me.SignOutButton.Location = New System.Drawing.Point(160, 6)
            Me.SignOutButton.Margin = New System.Windows.Forms.Padding(0, 6, 0, 0)
            Me.SignOutButton.Name = "SignOutButton"
            Me.SignOutButton.Size = New System.Drawing.Size(72, 32)
            Me.SignOutButton.TabIndex = 2
            Me.SignOutButton.Text = "Keluar"
            Me.SignOutButton.UseVisualStyleBackColor = False
            '
            'ContentHost
            '
            Me.ContentHost.BackColor = System.Drawing.Color.FromArgb(246, 248, 246)
            Me.ContentHost.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ContentHost.Location = New System.Drawing.Point(260, 0)
            Me.ContentHost.Margin = New System.Windows.Forms.Padding(0)
            Me.ContentHost.Name = "ContentHost"
            Me.ContentHost.Size = New System.Drawing.Size(1004, 801)
            Me.ContentHost.TabIndex = 1
            '
            'MainForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(246, 248, 246)
            Me.ClientSize = New System.Drawing.Size(1264, 801)
            Me.Controls.Add(Me.RootLayout)
            Me.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.MinimumSize = New System.Drawing.Size(1100, 700)
            Me.Name = "MainForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "SplitBill - Group Expense Manager"
            Me.RootLayout.ResumeLayout(False)
            Me.SidebarPanel.ResumeLayout(False)
            Me.SidebarLayout.ResumeLayout(False)
            Me.BrandContainer.ResumeLayout(False)
            Me.BrandTextStack.ResumeLayout(False)
            Me.BrandTextStack.PerformLayout()
            Me.MenuContainer.ResumeLayout(False)
            Me.MenuContainer.PerformLayout()
            Me.GuestCard.ResumeLayout(False)
            Me.GuestStack.ResumeLayout(False)
            Me.GuestStack.PerformLayout()
            Me.ProfileContainer.ResumeLayout(False)
            Me.UserTextStack.ResumeLayout(False)
            Me.UserTextStack.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents RootLayout As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents SidebarPanel As System.Windows.Forms.Panel
        Friend WithEvents SidebarLayout As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents BrandContainer As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents LogoBadge As System.Windows.Forms.Label
        Friend WithEvents BrandTextStack As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents BrandTitle As System.Windows.Forms.Label
        Friend WithEvents BrandSubtitle As System.Windows.Forms.Label
        Friend WithEvents MenuContainer As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents MenuCategoryLabel As System.Windows.Forms.Label
        Friend WithEvents BtnNavDashboard As System.Windows.Forms.Button
        Friend WithEvents BtnNavKegiatan As System.Windows.Forms.Button
        Friend WithEvents BtnNavTeman As System.Windows.Forms.Button
        Friend WithEvents BtnNavTempat As System.Windows.Forms.Button
        Friend WithEvents BtnNavRiwayat As System.Windows.Forms.Button
        Friend WithEvents GuestCard As System.Windows.Forms.Panel
        Friend WithEvents GuestStack As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents GuestTitle As System.Windows.Forms.Label
        Friend WithEvents GuestSub As System.Windows.Forms.Label
        Friend WithEvents ProfileContainer As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents UserAvatarLabel As System.Windows.Forms.Label
        Friend WithEvents UserTextStack As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents UserNameLabel As System.Windows.Forms.Label
        Friend WithEvents RoleLabel As System.Windows.Forms.Label
        Friend WithEvents SignOutButton As System.Windows.Forms.Button
        Friend WithEvents ContentHost As System.Windows.Forms.Panel
    End Class
End Namespace
