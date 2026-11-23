Namespace Global.SplitBill.App
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class DashboardPage
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
            Me.RootLayout = New System.Windows.Forms.TableLayoutPanel()
            Me.TopBarLayout = New System.Windows.Forms.TableLayoutPanel()
            Me.TitleLabel = New System.Windows.Forms.Label()
            Me.TopActionsFlow = New System.Windows.Forms.FlowLayoutPanel()
            Me.BtnTopCreate = New System.Windows.Forms.Button()
            Me.BtnTopJoin = New System.Windows.Forms.Button()
            Me.SearchTextBox = New System.Windows.Forms.TextBox()
            Me.BannerPanel = New System.Windows.Forms.Panel()
            Me.BannerLayout = New System.Windows.Forms.TableLayoutPanel()
            Me.BannerLeftStack = New System.Windows.Forms.FlowLayoutPanel()
            Me.BannerDateLabel = New System.Windows.Forms.Label()
            Me.BannerWelcomeLabel = New System.Windows.Forms.Label()
            Me.BannerDescLabel = New System.Windows.Forms.Label()
            Me.BannerRightStack = New System.Windows.Forms.FlowLayoutPanel()
            Me.RunningBadgeLabel = New System.Windows.Forms.Label()
            Me.BtnBannerCreate = New System.Windows.Forms.Button()
            Me.MetricsRowLayout = New System.Windows.Forms.TableLayoutPanel()
            Me.MetricCardActive = New System.Windows.Forms.Panel()
            Me.ActiveCardLayout = New System.Windows.Forms.TableLayoutPanel()
            Me.IconBadgeActive = New System.Windows.Forms.Label()
            Me.ContentStackActive = New System.Windows.Forms.FlowLayoutPanel()
            Me.TitleMetricActive = New System.Windows.Forms.Label()
            Me.ActiveGroupsCountLabel = New System.Windows.Forms.Label()
            Me.DescMetricActive = New System.Windows.Forms.Label()
            Me.MetricCardDone = New System.Windows.Forms.Panel()
            Me.DoneCardLayout = New System.Windows.Forms.TableLayoutPanel()
            Me.IconBadgeDone = New System.Windows.Forms.Label()
            Me.ContentStackDone = New System.Windows.Forms.FlowLayoutPanel()
            Me.TitleMetricDone = New System.Windows.Forms.Label()
            Me.CompletedGroupsCountLabel = New System.Windows.Forms.Label()
            Me.DescMetricDone = New System.Windows.Forms.Label()
            Me.MetricCardFriends = New System.Windows.Forms.Panel()
            Me.FriendsCardLayout = New System.Windows.Forms.TableLayoutPanel()
            Me.IconBadgeFriends = New System.Windows.Forms.Label()
            Me.ContentStackFriends = New System.Windows.Forms.FlowLayoutPanel()
            Me.TitleMetricFriends = New System.Windows.Forms.Label()
            Me.PeopleCountLabel = New System.Windows.Forms.Label()
            Me.DescMetricFriends = New System.Windows.Forms.Label()
            Me.MetricCardPlaces = New System.Windows.Forms.Panel()
            Me.PlacesCardLayout = New System.Windows.Forms.TableLayoutPanel()
            Me.IconBadgePlaces = New System.Windows.Forms.Label()
            Me.ContentStackPlaces = New System.Windows.Forms.FlowLayoutPanel()
            Me.TitleMetricPlaces = New System.Windows.Forms.Label()
            Me.PlacesCountLabel = New System.Windows.Forms.Label()
            Me.DescMetricPlaces = New System.Windows.Forms.Label()
            Me.MiddleLayout = New System.Windows.Forms.TableLayoutPanel()
            Me.LeftCard = New System.Windows.Forms.Panel()
            Me.LeftCardLayout = New System.Windows.Forms.TableLayoutPanel()
            Me.LeftHeaderLayout = New System.Windows.Forms.TableLayoutPanel()
            Me.LeftTitleStack = New System.Windows.Forms.FlowLayoutPanel()
            Me.LblActiveTitle = New System.Windows.Forms.Label()
            Me.LblActiveSub = New System.Windows.Forms.Label()
            Me.BtnViewAllActive = New System.Windows.Forms.Button()
            Me.ActiveGroupsContainer = New System.Windows.Forms.FlowLayoutPanel()
            Me.RightCard = New System.Windows.Forms.Panel()
            Me.RightCardLayout = New System.Windows.Forms.FlowLayoutPanel()
            Me.LblRightTitle = New System.Windows.Forms.Label()
            Me.LblRightSub = New System.Windows.Forms.Label()
            Me.BtnOptionHangout = New System.Windows.Forms.Button()
            Me.BtnOptionTrip = New System.Windows.Forms.Button()
            Me.BtnOptionRental = New System.Windows.Forms.Button()
            Me.LblMethodHint = New System.Windows.Forms.Label()
            Me.BottomLayout = New System.Windows.Forms.TableLayoutPanel()
            Me.BottomCardHistory = New System.Windows.Forms.Panel()
            Me.HistoryCardLayout = New System.Windows.Forms.TableLayoutPanel()
            Me.HistoryHeaderStack = New System.Windows.Forms.FlowLayoutPanel()
            Me.IconHistory = New System.Windows.Forms.Label()
            Me.LblHistoryTitle = New System.Windows.Forms.Label()
            Me.CompletedGroupsContainer = New System.Windows.Forms.FlowLayoutPanel()
            Me.BtnBottomHistory = New System.Windows.Forms.Button()
            Me.BottomCardFriends = New System.Windows.Forms.Panel()
            Me.FriendsBottomLayout = New System.Windows.Forms.TableLayoutPanel()
            Me.FriendsHeaderStack = New System.Windows.Forms.FlowLayoutPanel()
            Me.IconFriends = New System.Windows.Forms.Label()
            Me.LblFriendsTitle = New System.Windows.Forms.Label()
            Me.PeoplePreviewContainer = New System.Windows.Forms.FlowLayoutPanel()
            Me.BtnBottomFriends = New System.Windows.Forms.Button()
            Me.BottomCardPlaces = New System.Windows.Forms.Panel()
            Me.PlacesBottomLayout = New System.Windows.Forms.TableLayoutPanel()
            Me.PlacesHeaderStack = New System.Windows.Forms.FlowLayoutPanel()
            Me.IconPlaces = New System.Windows.Forms.Label()
            Me.LblPlacesTitle = New System.Windows.Forms.Label()
            Me.PlacesPreviewContainer = New System.Windows.Forms.FlowLayoutPanel()
            Me.BtnBottomPlaces = New System.Windows.Forms.Button()
            Me.BottomCardJoin = New System.Windows.Forms.Panel()
            Me.JoinBottomLayout = New System.Windows.Forms.TableLayoutPanel()
            Me.JoinHeaderStack = New System.Windows.Forms.FlowLayoutPanel()
            Me.IconJoin = New System.Windows.Forms.Label()
            Me.LblJoinTitle = New System.Windows.Forms.Label()
            Me.LblJoinDesc = New System.Windows.Forms.Label()
            Me.BtnBottomJoin = New System.Windows.Forms.Button()
            Me.RootLayout.SuspendLayout()
            Me.TopBarLayout.SuspendLayout()
            Me.TopActionsFlow.SuspendLayout()
            Me.BannerPanel.SuspendLayout()
            Me.BannerLayout.SuspendLayout()
            Me.BannerLeftStack.SuspendLayout()
            Me.BannerRightStack.SuspendLayout()
            Me.MetricsRowLayout.SuspendLayout()
            Me.MetricCardActive.SuspendLayout()
            Me.ActiveCardLayout.SuspendLayout()
            Me.ContentStackActive.SuspendLayout()
            Me.MetricCardDone.SuspendLayout()
            Me.DoneCardLayout.SuspendLayout()
            Me.ContentStackDone.SuspendLayout()
            Me.MetricCardFriends.SuspendLayout()
            Me.FriendsCardLayout.SuspendLayout()
            Me.ContentStackFriends.SuspendLayout()
            Me.MetricCardPlaces.SuspendLayout()
            Me.PlacesCardLayout.SuspendLayout()
            Me.ContentStackPlaces.SuspendLayout()
            Me.MiddleLayout.SuspendLayout()
            Me.LeftCard.SuspendLayout()
            Me.LeftCardLayout.SuspendLayout()
            Me.LeftHeaderLayout.SuspendLayout()
            Me.LeftTitleStack.SuspendLayout()
            Me.RightCard.SuspendLayout()
            Me.RightCardLayout.SuspendLayout()
            Me.BottomLayout.SuspendLayout()
            Me.BottomCardHistory.SuspendLayout()
            Me.HistoryCardLayout.SuspendLayout()
            Me.HistoryHeaderStack.SuspendLayout()
            Me.BottomCardFriends.SuspendLayout()
            Me.FriendsBottomLayout.SuspendLayout()
            Me.FriendsHeaderStack.SuspendLayout()
            Me.BottomCardPlaces.SuspendLayout()
            Me.PlacesBottomLayout.SuspendLayout()
            Me.PlacesHeaderStack.SuspendLayout()
            Me.BottomCardJoin.SuspendLayout()
            Me.JoinBottomLayout.SuspendLayout()
            Me.JoinHeaderStack.SuspendLayout()
            Me.SuspendLayout()
            '
            'RootLayout
            '
            Me.RootLayout.AutoSize = True
            Me.RootLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.RootLayout.BackColor = System.Drawing.Color.FromArgb(246, 248, 246)
            Me.RootLayout.ColumnCount = 1
            Me.RootLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.RootLayout.Controls.Add(Me.TopBarLayout, 0, 0)
            Me.RootLayout.Controls.Add(Me.BannerPanel, 0, 1)
            Me.RootLayout.Controls.Add(Me.MetricsRowLayout, 0, 2)
            Me.RootLayout.Controls.Add(Me.MiddleLayout, 0, 3)
            Me.RootLayout.Controls.Add(Me.BottomLayout, 0, 4)
            Me.RootLayout.Dock = System.Windows.Forms.DockStyle.Top
            Me.RootLayout.Location = New System.Drawing.Point(0, 0)
            Me.RootLayout.Name = "RootLayout"
            Me.RootLayout.Padding = New System.Windows.Forms.Padding(24, 20, 24, 24)
            Me.RootLayout.RowCount = 5
            Me.RootLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize))
            Me.RootLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize))
            Me.RootLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize))
            Me.RootLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize))
            Me.RootLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize))
            Me.RootLayout.Size = New System.Drawing.Size(1000, 960)
            Me.RootLayout.TabIndex = 0
            '
            'TopBarLayout
            '
            Me.TopBarLayout.ColumnCount = 2
            Me.TopBarLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.0F))
            Me.TopBarLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.0F))
            Me.TopBarLayout.Controls.Add(Me.TitleLabel, 0, 0)
            Me.TopBarLayout.Controls.Add(Me.TopActionsFlow, 1, 0)
            Me.TopBarLayout.Dock = System.Windows.Forms.DockStyle.Top
            Me.TopBarLayout.Location = New System.Drawing.Point(24, 20)
            Me.TopBarLayout.Margin = New System.Windows.Forms.Padding(0, 0, 0, 16)
            Me.TopBarLayout.Name = "TopBarLayout"
            Me.TopBarLayout.RowCount = 1
            Me.TopBarLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.TopBarLayout.Size = New System.Drawing.Size(952, 44)
            Me.TopBarLayout.TabIndex = 0
            '
            'TitleLabel
            '
            Me.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI", 20.0F, System.Drawing.FontStyle.Bold)
            Me.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.TitleLabel.Location = New System.Drawing.Point(0, 0)
            Me.TitleLabel.Margin = New System.Windows.Forms.Padding(0)
            Me.TitleLabel.Name = "TitleLabel"
            Me.TitleLabel.Size = New System.Drawing.Size(428, 44)
            Me.TitleLabel.TabIndex = 0
            Me.TitleLabel.Text = "Dashboard"
            Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'TopActionsFlow
            '
            Me.TopActionsFlow.Controls.Add(Me.BtnTopCreate)
            Me.TopActionsFlow.Controls.Add(Me.BtnTopJoin)
            Me.TopActionsFlow.Controls.Add(Me.SearchTextBox)
            Me.TopActionsFlow.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TopActionsFlow.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
            Me.TopActionsFlow.Location = New System.Drawing.Point(428, 0)
            Me.TopActionsFlow.Margin = New System.Windows.Forms.Padding(0)
            Me.TopActionsFlow.Name = "TopActionsFlow"
            Me.TopActionsFlow.Size = New System.Drawing.Size(524, 44)
            Me.TopActionsFlow.TabIndex = 1
            Me.TopActionsFlow.WrapContents = False
            '
            'BtnTopCreate
            '
            Me.BtnTopCreate.AutoSize = True
            Me.BtnTopCreate.BackColor = System.Drawing.Color.FromArgb(47, 107, 79)
            Me.BtnTopCreate.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnTopCreate.FlatAppearance.BorderSize = 0
            Me.BtnTopCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnTopCreate.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.BtnTopCreate.ForeColor = System.Drawing.Color.White
            Me.BtnTopCreate.Location = New System.Drawing.Point(424, 3)
            Me.BtnTopCreate.Margin = New System.Windows.Forms.Padding(8, 3, 0, 3)
            Me.BtnTopCreate.Name = "BtnTopCreate"
            Me.BtnTopCreate.Size = New System.Drawing.Size(100, 36)
            Me.BtnTopCreate.TabIndex = 0
            Me.BtnTopCreate.Text = "＋ Buat Grup"
            Me.BtnTopCreate.UseVisualStyleBackColor = False
            '
            'BtnTopJoin
            '
            Me.BtnTopJoin.AutoSize = True
            Me.BtnTopJoin.BackColor = System.Drawing.Color.White
            Me.BtnTopJoin.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnTopJoin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 231, 235)
            Me.BtnTopJoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnTopJoin.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.BtnTopJoin.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.BtnTopJoin.Location = New System.Drawing.Point(313, 3)
            Me.BtnTopJoin.Margin = New System.Windows.Forms.Padding(8, 3, 0, 3)
            Me.BtnTopJoin.Name = "BtnTopJoin"
            Me.BtnTopJoin.Size = New System.Drawing.Size(103, 36)
            Me.BtnTopJoin.TabIndex = 1
            Me.BtnTopJoin.Text = "↗ Gabung Grup"
            Me.BtnTopJoin.UseVisualStyleBackColor = False
            '
            'SearchTextBox
            '
            Me.SearchTextBox.Font = New System.Drawing.Font("Segoe UI", 9.5F)
            Me.SearchTextBox.Location = New System.Drawing.Point(125, 8)
            Me.SearchTextBox.Margin = New System.Windows.Forms.Padding(0, 8, 0, 0)
            Me.SearchTextBox.Name = "SearchTextBox"
            Me.SearchTextBox.PlaceholderText = "🔍 Cari kegiatan, teman, atau tempat..."
            Me.SearchTextBox.Size = New System.Drawing.Size(180, 24)
            Me.SearchTextBox.TabIndex = 2
            '
            'BannerPanel
            '
            Me.BannerPanel.BackColor = System.Drawing.Color.White
            Me.BannerPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.BannerPanel.Controls.Add(Me.BannerLayout)
            Me.BannerPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.BannerPanel.Location = New System.Drawing.Point(24, 80)
            Me.BannerPanel.Margin = New System.Windows.Forms.Padding(0, 0, 0, 20)
            Me.BannerPanel.Name = "BannerPanel"
            Me.BannerPanel.Padding = New System.Windows.Forms.Padding(24, 20, 24, 20)
            Me.BannerPanel.Size = New System.Drawing.Size(952, 120)
            Me.BannerPanel.TabIndex = 1
            '
            'BannerLayout
            '
            Me.BannerLayout.ColumnCount = 2
            Me.BannerLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.0F))
            Me.BannerLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0F))
            Me.BannerLayout.Controls.Add(Me.BannerLeftStack, 0, 0)
            Me.BannerLayout.Controls.Add(Me.BannerRightStack, 1, 0)
            Me.BannerLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.BannerLayout.Location = New System.Drawing.Point(24, 20)
            Me.BannerLayout.Margin = New System.Windows.Forms.Padding(0)
            Me.BannerLayout.Name = "BannerLayout"
            Me.BannerLayout.RowCount = 1
            Me.BannerLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.BannerLayout.Size = New System.Drawing.Size(902, 78)
            Me.BannerLayout.TabIndex = 0
            '
            'BannerLeftStack
            '
            Me.BannerLeftStack.Controls.Add(Me.BannerDateLabel)
            Me.BannerLeftStack.Controls.Add(Me.BannerWelcomeLabel)
            Me.BannerLeftStack.Controls.Add(Me.BannerDescLabel)
            Me.BannerLeftStack.Dock = System.Windows.Forms.DockStyle.Fill
            Me.BannerLeftStack.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
            Me.BannerLeftStack.Location = New System.Drawing.Point(0, 0)
            Me.BannerLeftStack.Margin = New System.Windows.Forms.Padding(0)
            Me.BannerLeftStack.Name = "BannerLeftStack"
            Me.BannerLeftStack.Size = New System.Drawing.Size(631, 78)
            Me.BannerLeftStack.TabIndex = 0
            Me.BannerLeftStack.WrapContents = False
            '
            'BannerDateLabel
            '
            Me.BannerDateLabel.AutoSize = True
            Me.BannerDateLabel.Font = New System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold)
            Me.BannerDateLabel.ForeColor = System.Drawing.Color.FromArgb(47, 107, 79)
            Me.BannerDateLabel.Location = New System.Drawing.Point(0, 0)
            Me.BannerDateLabel.Margin = New System.Windows.Forms.Padding(0, 0, 0, 3)
            Me.BannerDateLabel.Name = "BannerDateLabel"
            Me.BannerDateLabel.Size = New System.Drawing.Size(130, 15)
            Me.BannerDateLabel.TabIndex = 0
            Me.BannerDateLabel.Text = "HARI INI, 23 NOV 2026"
            '
            'BannerWelcomeLabel
            '
            Me.BannerWelcomeLabel.AutoSize = True
            Me.BannerWelcomeLabel.Font = New System.Drawing.Font("Segoe UI", 18.0F, System.Drawing.FontStyle.Bold)
            Me.BannerWelcomeLabel.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.BannerWelcomeLabel.Location = New System.Drawing.Point(0, 18)
            Me.BannerWelcomeLabel.Margin = New System.Windows.Forms.Padding(0, 0, 0, 3)
            Me.BannerWelcomeLabel.Name = "BannerWelcomeLabel"
            Me.BannerWelcomeLabel.Size = New System.Drawing.Size(326, 32)
            Me.BannerWelcomeLabel.TabIndex = 1
            Me.BannerWelcomeLabel.Text = "Selamat datang di SplitBill!"
            '
            'BannerDescLabel
            '
            Me.BannerDescLabel.AutoSize = True
            Me.BannerDescLabel.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.BannerDescLabel.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128)
            Me.BannerDescLabel.Location = New System.Drawing.Point(0, 53)
            Me.BannerDescLabel.Margin = New System.Windows.Forms.Padding(0)
            Me.BannerDescLabel.Name = "BannerDescLabel"
            Me.BannerDescLabel.Size = New System.Drawing.Size(462, 15)
            Me.BannerDescLabel.TabIndex = 2
            Me.BannerDescLabel.Text = "Kelola kegiatan, catat pengeluaran, dan hitung pembagian biaya dengan lebih mudah."
            '
            'BannerRightStack
            '
            Me.BannerRightStack.Controls.Add(Me.RunningBadgeLabel)
            Me.BannerRightStack.Controls.Add(Me.BtnBannerCreate)
            Me.BannerRightStack.Dock = System.Windows.Forms.DockStyle.Fill
            Me.BannerRightStack.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
            Me.BannerRightStack.Location = New System.Drawing.Point(631, 0)
            Me.BannerRightStack.Margin = New System.Windows.Forms.Padding(0)
            Me.BannerRightStack.Name = "BannerRightStack"
            Me.BannerRightStack.Size = New System.Drawing.Size(271, 78)
            Me.BannerRightStack.TabIndex = 1
            Me.BannerRightStack.WrapContents = False
            '
            'RunningBadgeLabel
            '
            Me.RunningBadgeLabel.AutoSize = True
            Me.RunningBadgeLabel.BackColor = System.Drawing.Color.FromArgb(240, 253, 244)
            Me.RunningBadgeLabel.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.RunningBadgeLabel.ForeColor = System.Drawing.Color.FromArgb(22, 101, 52)
            Me.RunningBadgeLabel.Location = New System.Drawing.Point(0, 4)
            Me.RunningBadgeLabel.Margin = New System.Windows.Forms.Padding(0, 4, 0, 6)
            Me.RunningBadgeLabel.Name = "RunningBadgeLabel"
            Me.RunningBadgeLabel.Padding = New System.Windows.Forms.Padding(10, 5, 10, 5)
            Me.RunningBadgeLabel.Size = New System.Drawing.Size(195, 25)
            Me.RunningBadgeLabel.TabIndex = 0
            Me.RunningBadgeLabel.Text = "• 0 kegiatan sedang berjalan"
            '
            'BtnBannerCreate
            '
            Me.BtnBannerCreate.AutoSize = True
            Me.BtnBannerCreate.BackColor = System.Drawing.Color.FromArgb(47, 107, 79)
            Me.BtnBannerCreate.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnBannerCreate.FlatAppearance.BorderSize = 0
            Me.BtnBannerCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnBannerCreate.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.BtnBannerCreate.ForeColor = System.Drawing.Color.White
            Me.BtnBannerCreate.Location = New System.Drawing.Point(0, 38)
            Me.BtnBannerCreate.Margin = New System.Windows.Forms.Padding(0)
            Me.BtnBannerCreate.Name = "BtnBannerCreate"
            Me.BtnBannerCreate.Size = New System.Drawing.Size(120, 36)
            Me.BtnBannerCreate.TabIndex = 1
            Me.BtnBannerCreate.Text = "＋ Buat Kegiatan"
            Me.BtnBannerCreate.UseVisualStyleBackColor = False
            '
            'MetricsRowLayout
            '
            Me.MetricsRowLayout.ColumnCount = 4
            Me.MetricsRowLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0F))
            Me.MetricsRowLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0F))
            Me.MetricsRowLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0F))
            Me.MetricsRowLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0F))
            Me.MetricsRowLayout.Controls.Add(Me.MetricCardActive, 0, 0)
            Me.MetricsRowLayout.Controls.Add(Me.MetricCardDone, 1, 0)
            Me.MetricsRowLayout.Controls.Add(Me.MetricCardFriends, 2, 0)
            Me.MetricsRowLayout.Controls.Add(Me.MetricCardPlaces, 3, 0)
            Me.MetricsRowLayout.Dock = System.Windows.Forms.DockStyle.Top
            Me.MetricsRowLayout.Location = New System.Drawing.Point(24, 220)
            Me.MetricsRowLayout.Margin = New System.Windows.Forms.Padding(0, 0, 0, 20)
            Me.MetricsRowLayout.Name = "MetricsRowLayout"
            Me.MetricsRowLayout.RowCount = 1
            Me.MetricsRowLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.MetricsRowLayout.Size = New System.Drawing.Size(952, 120)
            Me.MetricsRowLayout.TabIndex = 2
            '
            'MetricCardActive
            '
            Me.MetricCardActive.BackColor = System.Drawing.Color.White
            Me.MetricCardActive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.MetricCardActive.Controls.Add(Me.ActiveCardLayout)
            Me.MetricCardActive.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MetricCardActive.Location = New System.Drawing.Point(4, 0)
            Me.MetricCardActive.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.MetricCardActive.Name = "MetricCardActive"
            Me.MetricCardActive.Padding = New System.Windows.Forms.Padding(14, 12, 14, 12)
            Me.MetricCardActive.Size = New System.Drawing.Size(230, 120)
            Me.MetricCardActive.TabIndex = 0
            '
            'ActiveCardLayout
            '
            Me.ActiveCardLayout.ColumnCount = 2
            Me.ActiveCardLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44.0F))
            Me.ActiveCardLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.ActiveCardLayout.Controls.Add(Me.IconBadgeActive, 0, 0)
            Me.ActiveCardLayout.Controls.Add(Me.ContentStackActive, 1, 0)
            Me.ActiveCardLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ActiveCardLayout.Location = New System.Drawing.Point(14, 12)
            Me.ActiveCardLayout.Margin = New System.Windows.Forms.Padding(0)
            Me.ActiveCardLayout.Name = "ActiveCardLayout"
            Me.ActiveCardLayout.RowCount = 1
            Me.ActiveCardLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.ActiveCardLayout.Size = New System.Drawing.Size(200, 94)
            Me.ActiveCardLayout.TabIndex = 0
            '
            'IconBadgeActive
            '
            Me.IconBadgeActive.BackColor = System.Drawing.Color.FromArgb(240, 253, 244)
            Me.IconBadgeActive.Font = New System.Drawing.Font("Segoe UI", 13.0F, System.Drawing.FontStyle.Bold)
            Me.IconBadgeActive.ForeColor = System.Drawing.Color.FromArgb(22, 101, 52)
            Me.IconBadgeActive.Location = New System.Drawing.Point(0, 4)
            Me.IconBadgeActive.Margin = New System.Windows.Forms.Padding(0, 4, 0, 0)
            Me.IconBadgeActive.Name = "IconBadgeActive"
            Me.IconBadgeActive.Size = New System.Drawing.Size(38, 38)
            Me.IconBadgeActive.TabIndex = 0
            Me.IconBadgeActive.Text = "⚡"
            Me.IconBadgeActive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'ContentStackActive
            '
            Me.ContentStackActive.Controls.Add(Me.TitleMetricActive)
            Me.ContentStackActive.Controls.Add(Me.ActiveGroupsCountLabel)
            Me.ContentStackActive.Controls.Add(Me.DescMetricActive)
            Me.ContentStackActive.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ContentStackActive.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
            Me.ContentStackActive.Location = New System.Drawing.Point(44, 0)
            Me.ContentStackActive.Margin = New System.Windows.Forms.Padding(0)
            Me.ContentStackActive.Name = "ContentStackActive"
            Me.ContentStackActive.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
            Me.ContentStackActive.Size = New System.Drawing.Size(156, 94)
            Me.ContentStackActive.TabIndex = 1
            Me.ContentStackActive.WrapContents = False
            '
            'TitleMetricActive
            '
            Me.TitleMetricActive.AutoSize = True
            Me.TitleMetricActive.Font = New System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold)
            Me.TitleMetricActive.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128)
            Me.TitleMetricActive.Location = New System.Drawing.Point(2, 0)
            Me.TitleMetricActive.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
            Me.TitleMetricActive.Name = "TitleMetricActive"
            Me.TitleMetricActive.Size = New System.Drawing.Size(89, 12)
            Me.TitleMetricActive.TabIndex = 0
            Me.TitleMetricActive.Text = "KEGIATAN AKTIF"
            '
            'ActiveGroupsCountLabel
            '
            Me.ActiveGroupsCountLabel.AutoSize = True
            Me.ActiveGroupsCountLabel.Font = New System.Drawing.Font("Segoe UI", 18.0F, System.Drawing.FontStyle.Bold)
            Me.ActiveGroupsCountLabel.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.ActiveGroupsCountLabel.Location = New System.Drawing.Point(2, 13)
            Me.ActiveGroupsCountLabel.Margin = New System.Windows.Forms.Padding(0, 0, 0, 2)
            Me.ActiveGroupsCountLabel.Name = "ActiveGroupsCountLabel"
            Me.ActiveGroupsCountLabel.Size = New System.Drawing.Size(28, 32)
            Me.ActiveGroupsCountLabel.TabIndex = 1
            Me.ActiveGroupsCountLabel.Text = "0"
            '
            'DescMetricActive
            '
            Me.DescMetricActive.AutoSize = True
            Me.DescMetricActive.Font = New System.Drawing.Font("Segoe UI", 7.5F)
            Me.DescMetricActive.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128)
            Me.DescMetricActive.Location = New System.Drawing.Point(2, 47)
            Me.DescMetricActive.Margin = New System.Windows.Forms.Padding(0)
            Me.DescMetricActive.Name = "DescMetricActive"
            Me.DescMetricActive.Size = New System.Drawing.Size(126, 12)
            Me.DescMetricActive.TabIndex = 2
            Me.DescMetricActive.Text = "Kegiatan yang masih berjalan"
            '
            'MetricCardDone
            '
            Me.MetricCardDone.BackColor = System.Drawing.Color.White
            Me.MetricCardDone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.MetricCardDone.Controls.Add(Me.DoneCardLayout)
            Me.MetricCardDone.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MetricCardDone.Location = New System.Drawing.Point(242, 0)
            Me.MetricCardDone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.MetricCardDone.Name = "MetricCardDone"
            Me.MetricCardDone.Padding = New System.Windows.Forms.Padding(14, 12, 14, 12)
            Me.MetricCardDone.Size = New System.Drawing.Size(230, 120)
            Me.MetricCardDone.TabIndex = 1
            '
            'DoneCardLayout
            '
            Me.DoneCardLayout.ColumnCount = 2
            Me.DoneCardLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44.0F))
            Me.DoneCardLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.DoneCardLayout.Controls.Add(Me.IconBadgeDone, 0, 0)
            Me.DoneCardLayout.Controls.Add(Me.ContentStackDone, 1, 0)
            Me.DoneCardLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.DoneCardLayout.Location = New System.Drawing.Point(14, 12)
            Me.DoneCardLayout.Margin = New System.Windows.Forms.Padding(0)
            Me.DoneCardLayout.Name = "DoneCardLayout"
            Me.DoneCardLayout.RowCount = 1
            Me.DoneCardLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.DoneCardLayout.Size = New System.Drawing.Size(200, 94)
            Me.DoneCardLayout.TabIndex = 0
            '
            'IconBadgeDone
            '
            Me.IconBadgeDone.BackColor = System.Drawing.Color.FromArgb(239, 246, 255)
            Me.IconBadgeDone.Font = New System.Drawing.Font("Segoe UI", 13.0F, System.Drawing.FontStyle.Bold)
            Me.IconBadgeDone.ForeColor = System.Drawing.Color.FromArgb(30, 64, 175)
            Me.IconBadgeDone.Location = New System.Drawing.Point(0, 4)
            Me.IconBadgeDone.Margin = New System.Windows.Forms.Padding(0, 4, 0, 0)
            Me.IconBadgeDone.Name = "IconBadgeDone"
            Me.IconBadgeDone.Size = New System.Drawing.Size(38, 38)
            Me.IconBadgeDone.TabIndex = 0
            Me.IconBadgeDone.Text = "✓"
            Me.IconBadgeDone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'ContentStackDone
            '
            Me.ContentStackDone.Controls.Add(Me.TitleMetricDone)
            Me.ContentStackDone.Controls.Add(Me.CompletedGroupsCountLabel)
            Me.ContentStackDone.Controls.Add(Me.DescMetricDone)
            Me.ContentStackDone.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ContentStackDone.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
            Me.ContentStackDone.Location = New System.Drawing.Point(44, 0)
            Me.ContentStackDone.Margin = New System.Windows.Forms.Padding(0)
            Me.ContentStackDone.Name = "ContentStackDone"
            Me.ContentStackDone.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
            Me.ContentStackDone.Size = New System.Drawing.Size(156, 94)
            Me.ContentStackDone.TabIndex = 1
            Me.ContentStackDone.WrapContents = False
            '
            'TitleMetricDone
            '
            Me.TitleMetricDone.AutoSize = True
            Me.TitleMetricDone.Font = New System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold)
            Me.TitleMetricDone.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128)
            Me.TitleMetricDone.Location = New System.Drawing.Point(2, 0)
            Me.TitleMetricDone.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
            Me.TitleMetricDone.Name = "TitleMetricDone"
            Me.TitleMetricDone.Size = New System.Drawing.Size(91, 12)
            Me.TitleMetricDone.TabIndex = 0
            Me.TitleMetricDone.Text = "RIWAYAT SELESAI"
            '
            'CompletedGroupsCountLabel
            '
            Me.CompletedGroupsCountLabel.AutoSize = True
            Me.CompletedGroupsCountLabel.Font = New System.Drawing.Font("Segoe UI", 18.0F, System.Drawing.FontStyle.Bold)
            Me.CompletedGroupsCountLabel.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.CompletedGroupsCountLabel.Location = New System.Drawing.Point(2, 13)
            Me.CompletedGroupsCountLabel.Margin = New System.Windows.Forms.Padding(0, 0, 0, 2)
            Me.CompletedGroupsCountLabel.Name = "CompletedGroupsCountLabel"
            Me.CompletedGroupsCountLabel.Size = New System.Drawing.Size(28, 32)
            Me.CompletedGroupsCountLabel.TabIndex = 1
            Me.CompletedGroupsCountLabel.Text = "0"
            '
            'DescMetricDone
            '
            Me.DescMetricDone.AutoSize = True
            Me.DescMetricDone.Font = New System.Drawing.Font("Segoe UI", 7.5F)
            Me.DescMetricDone.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128)
            Me.DescMetricDone.Location = New System.Drawing.Point(2, 47)
            Me.DescMetricDone.Margin = New System.Windows.Forms.Padding(0)
            Me.DescMetricDone.Name = "DescMetricDone"
            Me.DescMetricDone.Size = New System.Drawing.Size(130, 12)
            Me.DescMetricDone.TabIndex = 2
            Me.DescMetricDone.Text = "Kegiatan yang sudah ditutup"
            '
            'MetricCardFriends
            '
            Me.MetricCardFriends.BackColor = System.Drawing.Color.White
            Me.MetricCardFriends.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.MetricCardFriends.Controls.Add(Me.FriendsCardLayout)
            Me.MetricCardFriends.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MetricCardFriends.Location = New System.Drawing.Point(480, 0)
            Me.MetricCardFriends.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.MetricCardFriends.Name = "MetricCardFriends"
            Me.MetricCardFriends.Padding = New System.Windows.Forms.Padding(14, 12, 14, 12)
            Me.MetricCardFriends.Size = New System.Drawing.Size(230, 120)
            Me.MetricCardFriends.TabIndex = 2
            '
            'FriendsCardLayout
            '
            Me.FriendsCardLayout.ColumnCount = 2
            Me.FriendsCardLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44.0F))
            Me.FriendsCardLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.FriendsCardLayout.Controls.Add(Me.IconBadgeFriends, 0, 0)
            Me.FriendsCardLayout.Controls.Add(Me.ContentStackFriends, 1, 0)
            Me.FriendsCardLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.FriendsCardLayout.Location = New System.Drawing.Point(14, 12)
            Me.FriendsCardLayout.Margin = New System.Windows.Forms.Padding(0)
            Me.FriendsCardLayout.Name = "FriendsCardLayout"
            Me.FriendsCardLayout.RowCount = 1
            Me.FriendsCardLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.FriendsCardLayout.Size = New System.Drawing.Size(200, 94)
            Me.FriendsCardLayout.TabIndex = 0
            '
            'IconBadgeFriends
            '
            Me.IconBadgeFriends.BackColor = System.Drawing.Color.FromArgb(243, 232, 255)
            Me.IconBadgeFriends.Font = New System.Drawing.Font("Segoe UI", 13.0F, System.Drawing.FontStyle.Bold)
            Me.IconBadgeFriends.ForeColor = System.Drawing.Color.FromArgb(107, 33, 168)
            Me.IconBadgeFriends.Location = New System.Drawing.Point(0, 4)
            Me.IconBadgeFriends.Margin = New System.Windows.Forms.Padding(0, 4, 0, 0)
            Me.IconBadgeFriends.Name = "IconBadgeFriends"
            Me.IconBadgeFriends.Size = New System.Drawing.Size(38, 38)
            Me.IconBadgeFriends.TabIndex = 0
            Me.IconBadgeFriends.Text = "👥"
            Me.IconBadgeFriends.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'ContentStackFriends
            '
            Me.ContentStackFriends.Controls.Add(Me.TitleMetricFriends)
            Me.ContentStackFriends.Controls.Add(Me.PeopleCountLabel)
            Me.ContentStackFriends.Controls.Add(Me.DescMetricFriends)
            Me.ContentStackFriends.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ContentStackFriends.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
            Me.ContentStackFriends.Location = New System.Drawing.Point(44, 0)
            Me.ContentStackFriends.Margin = New System.Windows.Forms.Padding(0)
            Me.ContentStackFriends.Name = "ContentStackFriends"
            Me.ContentStackFriends.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
            Me.ContentStackFriends.Size = New System.Drawing.Size(156, 94)
            Me.ContentStackFriends.TabIndex = 1
            Me.ContentStackFriends.WrapContents = False
            '
            'TitleMetricFriends
            '
            Me.TitleMetricFriends.AutoSize = True
            Me.TitleMetricFriends.Font = New System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold)
            Me.TitleMetricFriends.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128)
            Me.TitleMetricFriends.Location = New System.Drawing.Point(2, 0)
            Me.TitleMetricFriends.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
            Me.TitleMetricFriends.Name = "TitleMetricFriends"
            Me.TitleMetricFriends.Size = New System.Drawing.Size(95, 12)
            Me.TitleMetricFriends.TabIndex = 0
            Me.TitleMetricFriends.Text = "TEMAN TERSIMPAN"
            '
            'PeopleCountLabel
            '
            Me.PeopleCountLabel.AutoSize = True
            Me.PeopleCountLabel.Font = New System.Drawing.Font("Segoe UI", 18.0F, System.Drawing.FontStyle.Bold)
            Me.PeopleCountLabel.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.PeopleCountLabel.Location = New System.Drawing.Point(2, 13)
            Me.PeopleCountLabel.Margin = New System.Windows.Forms.Padding(0, 0, 0, 2)
            Me.PeopleCountLabel.Name = "PeopleCountLabel"
            Me.PeopleCountLabel.Size = New System.Drawing.Size(28, 32)
            Me.PeopleCountLabel.TabIndex = 1
            Me.PeopleCountLabel.Text = "0"
            '
            'DescMetricFriends
            '
            Me.DescMetricFriends.AutoSize = True
            Me.DescMetricFriends.Font = New System.Drawing.Font("Segoe UI", 7.5F)
            Me.DescMetricFriends.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128)
            Me.DescMetricFriends.Location = New System.Drawing.Point(2, 47)
            Me.DescMetricFriends.Margin = New System.Windows.Forms.Padding(0)
            Me.DescMetricFriends.Name = "DescMetricFriends"
            Me.DescMetricFriends.Size = New System.Drawing.Size(135, 12)
            Me.DescMetricFriends.TabIndex = 2
            Me.DescMetricFriends.Text = "Kontak teman dalam database"
            '
            'MetricCardPlaces
            '
            Me.MetricCardPlaces.BackColor = System.Drawing.Color.White
            Me.MetricCardPlaces.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.MetricCardPlaces.Controls.Add(Me.PlacesCardLayout)
            Me.MetricCardPlaces.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MetricCardPlaces.Location = New System.Drawing.Point(718, 0)
            Me.MetricCardPlaces.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.MetricCardPlaces.Name = "MetricCardPlaces"
            Me.MetricCardPlaces.Padding = New System.Windows.Forms.Padding(14, 12, 14, 12)
            Me.MetricCardPlaces.Size = New System.Drawing.Size(230, 120)
            Me.MetricCardPlaces.TabIndex = 3
            '
            'PlacesCardLayout
            '
            Me.PlacesCardLayout.ColumnCount = 2
            Me.PlacesCardLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44.0F))
            Me.PlacesCardLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.PlacesCardLayout.Controls.Add(Me.IconBadgePlaces, 0, 0)
            Me.PlacesCardLayout.Controls.Add(Me.ContentStackPlaces, 1, 0)
            Me.PlacesCardLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PlacesCardLayout.Location = New System.Drawing.Point(14, 12)
            Me.PlacesCardLayout.Margin = New System.Windows.Forms.Padding(0)
            Me.PlacesCardLayout.Name = "PlacesCardLayout"
            Me.PlacesCardLayout.RowCount = 1
            Me.PlacesCardLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.PlacesCardLayout.Size = New System.Drawing.Size(200, 94)
            Me.PlacesCardLayout.TabIndex = 0
            '
            'IconBadgePlaces
            '
            Me.IconBadgePlaces.BackColor = System.Drawing.Color.FromArgb(254, 243, 199)
            Me.IconBadgePlaces.Font = New System.Drawing.Font("Segoe UI", 13.0F, System.Drawing.FontStyle.Bold)
            Me.IconBadgePlaces.ForeColor = System.Drawing.Color.FromArgb(146, 64, 14)
            Me.IconBadgePlaces.Location = New System.Drawing.Point(0, 4)
            Me.IconBadgePlaces.Margin = New System.Windows.Forms.Padding(0, 4, 0, 0)
            Me.IconBadgePlaces.Name = "IconBadgePlaces"
            Me.IconBadgePlaces.Size = New System.Drawing.Size(38, 38)
            Me.IconBadgePlaces.TabIndex = 0
            Me.IconBadgePlaces.Text = "📍"
            Me.IconBadgePlaces.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'ContentStackPlaces
            '
            Me.ContentStackPlaces.Controls.Add(Me.TitleMetricPlaces)
            Me.ContentStackPlaces.Controls.Add(Me.PlacesCountLabel)
            Me.ContentStackPlaces.Controls.Add(Me.DescMetricPlaces)
            Me.ContentStackPlaces.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ContentStackPlaces.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
            Me.ContentStackPlaces.Location = New System.Drawing.Point(44, 0)
            Me.ContentStackPlaces.Margin = New System.Windows.Forms.Padding(0)
            Me.ContentStackPlaces.Name = "ContentStackPlaces"
            Me.ContentStackPlaces.Padding = New System.Windows.Forms.Padding(2, 0, 0, 0)
            Me.ContentStackPlaces.Size = New System.Drawing.Size(156, 94)
            Me.ContentStackPlaces.TabIndex = 1
            Me.ContentStackPlaces.WrapContents = False
            '
            'TitleMetricPlaces
            '
            Me.TitleMetricPlaces.AutoSize = True
            Me.TitleMetricPlaces.Font = New System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold)
            Me.TitleMetricPlaces.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128)
            Me.TitleMetricPlaces.Location = New System.Drawing.Point(2, 0)
            Me.TitleMetricPlaces.Margin = New System.Windows.Forms.Padding(0, 0, 0, 1)
            Me.TitleMetricPlaces.Name = "TitleMetricPlaces"
            Me.TitleMetricPlaces.Size = New System.Drawing.Size(99, 12)
            Me.TitleMetricPlaces.TabIndex = 0
            Me.TitleMetricPlaces.Text = "TEMPAT TERSIMPAN"
            '
            'PlacesCountLabel
            '
            Me.PlacesCountLabel.AutoSize = True
            Me.PlacesCountLabel.Font = New System.Drawing.Font("Segoe UI", 18.0F, System.Drawing.FontStyle.Bold)
            Me.PlacesCountLabel.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.PlacesCountLabel.Location = New System.Drawing.Point(2, 13)
            Me.PlacesCountLabel.Margin = New System.Windows.Forms.Padding(0, 0, 0, 2)
            Me.PlacesCountLabel.Name = "PlacesCountLabel"
            Me.PlacesCountLabel.Size = New System.Drawing.Size(28, 32)
            Me.PlacesCountLabel.TabIndex = 1
            Me.PlacesCountLabel.Text = "0"
            '
            'DescMetricPlaces
            '
            Me.DescMetricPlaces.AutoSize = True
            Me.DescMetricPlaces.Font = New System.Drawing.Font("Segoe UI", 7.5F)
            Me.DescMetricPlaces.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128)
            Me.DescMetricPlaces.Location = New System.Drawing.Point(2, 47)
            Me.DescMetricPlaces.Margin = New System.Windows.Forms.Padding(0)
            Me.DescMetricPlaces.Name = "DescMetricPlaces"
            Me.DescMetricPlaces.Size = New System.Drawing.Size(142, 12)
            Me.DescMetricPlaces.TabIndex = 2
            Me.DescMetricPlaces.Text = "Tempat yang pernah digunakan"
            '
            'MiddleLayout
            '
            Me.MiddleLayout.AutoSize = True
            Me.MiddleLayout.ColumnCount = 2
            Me.MiddleLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.0F))
            Me.MiddleLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.0F))
            Me.MiddleLayout.Controls.Add(Me.LeftCard, 0, 0)
            Me.MiddleLayout.Controls.Add(Me.RightCard, 1, 0)
            Me.MiddleLayout.Dock = System.Windows.Forms.DockStyle.Top
            Me.MiddleLayout.Location = New System.Drawing.Point(24, 360)
            Me.MiddleLayout.Margin = New System.Windows.Forms.Padding(0, 0, 0, 20)
            Me.MiddleLayout.Name = "MiddleLayout"
            Me.MiddleLayout.RowCount = 1
            Me.MiddleLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.MiddleLayout.Size = New System.Drawing.Size(952, 280)
            Me.MiddleLayout.TabIndex = 3
            '
            'LeftCard
            '
            Me.LeftCard.AutoSize = True
            Me.LeftCard.BackColor = System.Drawing.Color.White
            Me.LeftCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LeftCard.Controls.Add(Me.LeftCardLayout)
            Me.LeftCard.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LeftCard.Location = New System.Drawing.Point(0, 0)
            Me.LeftCard.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
            Me.LeftCard.Name = "LeftCard"
            Me.LeftCard.Padding = New System.Windows.Forms.Padding(20)
            Me.LeftCard.Size = New System.Drawing.Size(580, 280)
            Me.LeftCard.TabIndex = 0
            '
            'LeftCardLayout
            '
            Me.LeftCardLayout.AutoSize = True
            Me.LeftCardLayout.ColumnCount = 1
            Me.LeftCardLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.LeftCardLayout.Controls.Add(Me.LeftHeaderLayout, 0, 0)
            Me.LeftCardLayout.Controls.Add(Me.ActiveGroupsContainer, 0, 1)
            Me.LeftCardLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LeftCardLayout.Location = New System.Drawing.Point(20, 20)
            Me.LeftCardLayout.Margin = New System.Windows.Forms.Padding(0)
            Me.LeftCardLayout.Name = "LeftCardLayout"
            Me.LeftCardLayout.RowCount = 2
            Me.LeftCardLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0F))
            Me.LeftCardLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.LeftCardLayout.Size = New System.Drawing.Size(538, 238)
            Me.LeftCardLayout.TabIndex = 0
            '
            'LeftHeaderLayout
            '
            Me.LeftHeaderLayout.ColumnCount = 2
            Me.LeftHeaderLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.LeftHeaderLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0F))
            Me.LeftHeaderLayout.Controls.Add(Me.LeftTitleStack, 0, 0)
            Me.LeftHeaderLayout.Controls.Add(Me.BtnViewAllActive, 1, 0)
            Me.LeftHeaderLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LeftHeaderLayout.Location = New System.Drawing.Point(0, 0)
            Me.LeftHeaderLayout.Margin = New System.Windows.Forms.Padding(0)
            Me.LeftHeaderLayout.Name = "LeftHeaderLayout"
            Me.LeftHeaderLayout.RowCount = 1
            Me.LeftHeaderLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.LeftHeaderLayout.Size = New System.Drawing.Size(538, 46)
            Me.LeftHeaderLayout.TabIndex = 0
            '
            'LeftTitleStack
            '
            Me.LeftTitleStack.Controls.Add(Me.LblActiveTitle)
            Me.LeftTitleStack.Controls.Add(Me.LblActiveSub)
            Me.LeftTitleStack.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LeftTitleStack.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
            Me.LeftTitleStack.Location = New System.Drawing.Point(0, 0)
            Me.LeftTitleStack.Margin = New System.Windows.Forms.Padding(0)
            Me.LeftTitleStack.Name = "LeftTitleStack"
            Me.LeftTitleStack.Size = New System.Drawing.Size(428, 46)
            Me.LeftTitleStack.TabIndex = 0
            Me.LeftTitleStack.WrapContents = False
            '
            'LblActiveTitle
            '
            Me.LblActiveTitle.AutoSize = True
            Me.LblActiveTitle.Font = New System.Drawing.Font("Segoe UI", 12.0F, System.Drawing.FontStyle.Bold)
            Me.LblActiveTitle.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.LblActiveTitle.Location = New System.Drawing.Point(0, 0)
            Me.LblActiveTitle.Margin = New System.Windows.Forms.Padding(0)
            Me.LblActiveTitle.Name = "LblActiveTitle"
            Me.LblActiveTitle.Size = New System.Drawing.Size(120, 21)
            Me.LblActiveTitle.TabIndex = 0
            Me.LblActiveTitle.Text = "Kegiatan Aktif"
            '
            'LblActiveSub
            '
            Me.LblActiveSub.AutoSize = True
            Me.LblActiveSub.Font = New System.Drawing.Font("Segoe UI", 8.5F)
            Me.LblActiveSub.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128)
            Me.LblActiveSub.Location = New System.Drawing.Point(0, 21)
            Me.LblActiveSub.Margin = New System.Windows.Forms.Padding(0)
            Me.LblActiveSub.Name = "LblActiveSub"
            Me.LblActiveSub.Size = New System.Drawing.Size(262, 15)
            Me.LblActiveSub.TabIndex = 1
            Me.LblActiveSub.Text = "Kegiatan yang masih berjalan dan dapat dikelola."
            '
            'BtnViewAllActive
            '
            Me.BtnViewAllActive.AutoSize = True
            Me.BtnViewAllActive.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnViewAllActive.Dock = System.Windows.Forms.DockStyle.Right
            Me.BtnViewAllActive.FlatAppearance.BorderSize = 0
            Me.BtnViewAllActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnViewAllActive.Font = New System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold)
            Me.BtnViewAllActive.ForeColor = System.Drawing.Color.FromArgb(47, 107, 79)
            Me.BtnViewAllActive.Location = New System.Drawing.Point(432, 0)
            Me.BtnViewAllActive.Margin = New System.Windows.Forms.Padding(0)
            Me.BtnViewAllActive.Name = "BtnViewAllActive"
            Me.BtnViewAllActive.Size = New System.Drawing.Size(106, 46)
            Me.BtnViewAllActive.TabIndex = 1
            Me.BtnViewAllActive.Text = "Lihat semua →"
            Me.BtnViewAllActive.UseVisualStyleBackColor = True
            '
            'ActiveGroupsContainer
            '
            Me.ActiveGroupsContainer.AutoSize = True
            Me.ActiveGroupsContainer.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ActiveGroupsContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
            Me.ActiveGroupsContainer.Location = New System.Drawing.Point(0, 46)
            Me.ActiveGroupsContainer.Margin = New System.Windows.Forms.Padding(0)
            Me.ActiveGroupsContainer.Name = "ActiveGroupsContainer"
            Me.ActiveGroupsContainer.Size = New System.Drawing.Size(538, 192)
            Me.ActiveGroupsContainer.TabIndex = 1
            Me.ActiveGroupsContainer.WrapContents = False
            '
            'RightCard
            '
            Me.RightCard.AutoSize = True
            Me.RightCard.BackColor = System.Drawing.Color.White
            Me.RightCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.RightCard.Controls.Add(Me.RightCardLayout)
            Me.RightCard.Dock = System.Windows.Forms.DockStyle.Fill
            Me.RightCard.Location = New System.Drawing.Point(590, 0)
            Me.RightCard.Margin = New System.Windows.Forms.Padding(0)
            Me.RightCard.Name = "RightCard"
            Me.RightCard.Padding = New System.Windows.Forms.Padding(20)
            Me.RightCard.Size = New System.Drawing.Size(362, 280)
            Me.RightCard.TabIndex = 1
            '
            'RightCardLayout
            '
            Me.RightCardLayout.AutoSize = True
            Me.RightCardLayout.Controls.Add(Me.LblRightTitle)
            Me.RightCardLayout.Controls.Add(Me.LblRightSub)
            Me.RightCardLayout.Controls.Add(Me.BtnOptionHangout)
            Me.RightCardLayout.Controls.Add(Me.BtnOptionTrip)
            Me.RightCardLayout.Controls.Add(Me.BtnOptionRental)
            Me.RightCardLayout.Controls.Add(Me.LblMethodHint)
            Me.RightCardLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.RightCardLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
            Me.RightCardLayout.Location = New System.Drawing.Point(20, 20)
            Me.RightCardLayout.Margin = New System.Windows.Forms.Padding(0)
            Me.RightCardLayout.Name = "RightCardLayout"
            Me.RightCardLayout.Size = New System.Drawing.Size(320, 238)
            Me.RightCardLayout.TabIndex = 0
            Me.RightCardLayout.WrapContents = False
            '
            'LblRightTitle
            '
            Me.LblRightTitle.AutoSize = True
            Me.LblRightTitle.Font = New System.Drawing.Font("Segoe UI", 12.0F, System.Drawing.FontStyle.Bold)
            Me.LblRightTitle.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.LblRightTitle.Location = New System.Drawing.Point(0, 0)
            Me.LblRightTitle.Margin = New System.Windows.Forms.Padding(0, 0, 0, 2)
            Me.LblRightTitle.Name = "LblRightTitle"
            Me.LblRightTitle.Size = New System.Drawing.Size(150, 21)
            Me.LblRightTitle.TabIndex = 0
            Me.LblRightTitle.Text = "Buat Kegiatan Baru"
            '
            'LblRightSub
            '
            Me.LblRightSub.AutoSize = True
            Me.LblRightSub.Font = New System.Drawing.Font("Segoe UI", 8.5F)
            Me.LblRightSub.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128)
            Me.LblRightSub.Location = New System.Drawing.Point(0, 23)
            Me.LblRightSub.Margin = New System.Windows.Forms.Padding(0, 0, 0, 14)
            Me.LblRightSub.Name = "LblRightSub"
            Me.LblRightSub.Size = New System.Drawing.Size(193, 15)
            Me.LblRightSub.TabIndex = 1
            Me.LblRightSub.Text = "Pilih jenis kegiatan yang ingin dicatat."
            '
            'BtnOptionHangout
            '
            Me.BtnOptionHangout.BackColor = System.Drawing.Color.FromArgb(250, 250, 250)
            Me.BtnOptionHangout.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnOptionHangout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 231, 235)
            Me.BtnOptionHangout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnOptionHangout.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.BtnOptionHangout.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.BtnOptionHangout.Location = New System.Drawing.Point(0, 52)
            Me.BtnOptionHangout.Margin = New System.Windows.Forms.Padding(0, 0, 0, 8)
            Me.BtnOptionHangout.Name = "BtnOptionHangout"
            Me.BtnOptionHangout.Padding = New System.Windows.Forms.Padding(12, 6, 12, 6)
            Me.BtnOptionHangout.Size = New System.Drawing.Size(310, 46)
            Me.BtnOptionHangout.TabIndex = 2
            Me.BtnOptionHangout.Text = "☕  Nongkrong / Makan Bersama"
            Me.BtnOptionHangout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.BtnOptionHangout.UseVisualStyleBackColor = False
            '
            'BtnOptionTrip
            '
            Me.BtnOptionTrip.BackColor = System.Drawing.Color.FromArgb(250, 250, 250)
            Me.BtnOptionTrip.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnOptionTrip.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 231, 235)
            Me.BtnOptionTrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnOptionTrip.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.BtnOptionTrip.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.BtnOptionTrip.Location = New System.Drawing.Point(0, 106)
            Me.BtnOptionTrip.Margin = New System.Windows.Forms.Padding(0, 0, 0, 8)
            Me.BtnOptionTrip.Name = "BtnOptionTrip"
            Me.BtnOptionTrip.Padding = New System.Windows.Forms.Padding(12, 6, 12, 6)
            Me.BtnOptionTrip.Size = New System.Drawing.Size(310, 46)
            Me.BtnOptionTrip.TabIndex = 3
            Me.BtnOptionTrip.Text = "🚗  Perjalanan Bersama"
            Me.BtnOptionTrip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.BtnOptionTrip.UseVisualStyleBackColor = False
            '
            'BtnOptionRental
            '
            Me.BtnOptionRental.BackColor = System.Drawing.Color.FromArgb(250, 250, 250)
            Me.BtnOptionRental.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnOptionRental.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 231, 235)
            Me.BtnOptionRental.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnOptionRental.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.BtnOptionRental.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.BtnOptionRental.Location = New System.Drawing.Point(0, 160)
            Me.BtnOptionRental.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
            Me.BtnOptionRental.Name = "BtnOptionRental"
            Me.BtnOptionRental.Padding = New System.Windows.Forms.Padding(12, 6, 12, 6)
            Me.BtnOptionRental.Size = New System.Drawing.Size(310, 46)
            Me.BtnOptionRental.TabIndex = 4
            Me.BtnOptionRental.Text = "🛍️  Pembelian / Sewa"
            Me.BtnOptionRental.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.BtnOptionRental.UseVisualStyleBackColor = False
            '
            'LblMethodHint
            '
            Me.LblMethodHint.AutoSize = True
            Me.LblMethodHint.Font = New System.Drawing.Font("Segoe UI", 7.5F)
            Me.LblMethodHint.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128)
            Me.LblMethodHint.Location = New System.Drawing.Point(0, 216)
            Me.LblMethodHint.Margin = New System.Windows.Forms.Padding(0)
            Me.LblMethodHint.Name = "LblMethodHint"
            Me.LblMethodHint.Size = New System.Drawing.Size(262, 12)
            Me.LblMethodHint.TabIndex = 5
            Me.LblMethodHint.Text = "⚡ Metode pembagian (rata/pesanan/persen) dipilih pada tiap transaksi."
            '
            'BottomLayout
            '
            Me.BottomLayout.ColumnCount = 4
            Me.BottomLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0F))
            Me.BottomLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0F))
            Me.BottomLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0F))
            Me.BottomLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0F))
            Me.BottomLayout.Controls.Add(Me.BottomCardHistory, 0, 0)
            Me.BottomLayout.Controls.Add(Me.BottomCardFriends, 1, 0)
            Me.BottomLayout.Controls.Add(Me.BottomCardPlaces, 2, 0)
            Me.BottomLayout.Controls.Add(Me.BottomCardJoin, 3, 0)
            Me.BottomLayout.Dock = System.Windows.Forms.DockStyle.Top
            Me.BottomLayout.Location = New System.Drawing.Point(24, 660)
            Me.BottomLayout.Margin = New System.Windows.Forms.Padding(0)
            Me.BottomLayout.Name = "BottomLayout"
            Me.BottomLayout.RowCount = 1
            Me.BottomLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.BottomLayout.Size = New System.Drawing.Size(952, 210)
            Me.BottomLayout.TabIndex = 4
            '
            'BottomCardHistory
            '
            Me.BottomCardHistory.BackColor = System.Drawing.Color.White
            Me.BottomCardHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.BottomCardHistory.Controls.Add(Me.HistoryCardLayout)
            Me.BottomCardHistory.Dock = System.Windows.Forms.DockStyle.Fill
            Me.BottomCardHistory.Location = New System.Drawing.Point(4, 0)
            Me.BottomCardHistory.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.BottomCardHistory.Name = "BottomCardHistory"
            Me.BottomCardHistory.Padding = New System.Windows.Forms.Padding(16)
            Me.BottomCardHistory.Size = New System.Drawing.Size(230, 210)
            Me.BottomCardHistory.TabIndex = 0
            '
            'HistoryCardLayout
            '
            Me.HistoryCardLayout.ColumnCount = 1
            Me.HistoryCardLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.HistoryCardLayout.Controls.Add(Me.HistoryHeaderStack, 0, 0)
            Me.HistoryCardLayout.Controls.Add(Me.CompletedGroupsContainer, 0, 1)
            Me.HistoryCardLayout.Controls.Add(Me.BtnBottomHistory, 0, 2)
            Me.HistoryCardLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.HistoryCardLayout.Location = New System.Drawing.Point(16, 16)
            Me.HistoryCardLayout.Margin = New System.Windows.Forms.Padding(0)
            Me.HistoryCardLayout.Name = "HistoryCardLayout"
            Me.HistoryCardLayout.RowCount = 3
            Me.HistoryCardLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0F))
            Me.HistoryCardLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.HistoryCardLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0F))
            Me.HistoryCardLayout.Size = New System.Drawing.Size(196, 176)
            Me.HistoryCardLayout.TabIndex = 0
            '
            'HistoryHeaderStack
            '
            Me.HistoryHeaderStack.Controls.Add(Me.IconHistory)
            Me.HistoryHeaderStack.Controls.Add(Me.LblHistoryTitle)
            Me.HistoryHeaderStack.Dock = System.Windows.Forms.DockStyle.Fill
            Me.HistoryHeaderStack.Location = New System.Drawing.Point(0, 0)
            Me.HistoryHeaderStack.Margin = New System.Windows.Forms.Padding(0)
            Me.HistoryHeaderStack.Name = "HistoryHeaderStack"
            Me.HistoryHeaderStack.Size = New System.Drawing.Size(196, 32)
            Me.HistoryHeaderStack.TabIndex = 0
            Me.HistoryHeaderStack.WrapContents = False
            '
            'IconHistory
            '
            Me.IconHistory.AutoSize = True
            Me.IconHistory.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.IconHistory.Location = New System.Drawing.Point(0, 0)
            Me.IconHistory.Margin = New System.Windows.Forms.Padding(0, 0, 6, 0)
            Me.IconHistory.Name = "IconHistory"
            Me.IconHistory.Size = New System.Drawing.Size(26, 19)
            Me.IconHistory.TabIndex = 0
            Me.IconHistory.Text = "⏱️"
            '
            'LblHistoryTitle
            '
            Me.LblHistoryTitle.AutoSize = True
            Me.LblHistoryTitle.Font = New System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold)
            Me.LblHistoryTitle.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.LblHistoryTitle.Location = New System.Drawing.Point(32, 0)
            Me.LblHistoryTitle.Margin = New System.Windows.Forms.Padding(0)
            Me.LblHistoryTitle.Name = "LblHistoryTitle"
            Me.LblHistoryTitle.Size = New System.Drawing.Size(107, 17)
            Me.LblHistoryTitle.TabIndex = 1
            Me.LblHistoryTitle.Text = "Riwayat Terbaru"
            '
            'CompletedGroupsContainer
            '
            Me.CompletedGroupsContainer.AutoScroll = True
            Me.CompletedGroupsContainer.Dock = System.Windows.Forms.DockStyle.Fill
            Me.CompletedGroupsContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
            Me.CompletedGroupsContainer.Location = New System.Drawing.Point(0, 32)
            Me.CompletedGroupsContainer.Margin = New System.Windows.Forms.Padding(0)
            Me.CompletedGroupsContainer.Name = "CompletedGroupsContainer"
            Me.CompletedGroupsContainer.Size = New System.Drawing.Size(196, 106)
            Me.CompletedGroupsContainer.TabIndex = 1
            Me.CompletedGroupsContainer.WrapContents = False
            '
            'BtnBottomHistory
            '
            Me.BtnBottomHistory.BackColor = System.Drawing.Color.FromArgb(240, 253, 244)
            Me.BtnBottomHistory.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnBottomHistory.Dock = System.Windows.Forms.DockStyle.Fill
            Me.BtnBottomHistory.FlatAppearance.BorderSize = 0
            Me.BtnBottomHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnBottomHistory.Font = New System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold)
            Me.BtnBottomHistory.ForeColor = System.Drawing.Color.FromArgb(47, 107, 79)
            Me.BtnBottomHistory.Location = New System.Drawing.Point(0, 138)
            Me.BtnBottomHistory.Margin = New System.Windows.Forms.Padding(0)
            Me.BtnBottomHistory.Name = "BtnBottomHistory"
            Me.BtnBottomHistory.Size = New System.Drawing.Size(196, 38)
            Me.BtnBottomHistory.TabIndex = 2
            Me.BtnBottomHistory.Text = "Kelola Riwayat"
            Me.BtnBottomHistory.UseVisualStyleBackColor = False
            '
            'BottomCardFriends
            '
            Me.BottomCardFriends.BackColor = System.Drawing.Color.White
            Me.BottomCardFriends.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.BottomCardFriends.Controls.Add(Me.FriendsBottomLayout)
            Me.BottomCardFriends.Dock = System.Windows.Forms.DockStyle.Fill
            Me.BottomCardFriends.Location = New System.Drawing.Point(242, 0)
            Me.BottomCardFriends.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.BottomCardFriends.Name = "BottomCardFriends"
            Me.BottomCardFriends.Padding = New System.Windows.Forms.Padding(16)
            Me.BottomCardFriends.Size = New System.Drawing.Size(230, 210)
            Me.BottomCardFriends.TabIndex = 1
            '
            'FriendsBottomLayout
            '
            Me.FriendsBottomLayout.ColumnCount = 1
            Me.FriendsBottomLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.FriendsBottomLayout.Controls.Add(Me.FriendsHeaderStack, 0, 0)
            Me.FriendsBottomLayout.Controls.Add(Me.PeoplePreviewContainer, 0, 1)
            Me.FriendsBottomLayout.Controls.Add(Me.BtnBottomFriends, 0, 2)
            Me.FriendsBottomLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.FriendsBottomLayout.Location = New System.Drawing.Point(16, 16)
            Me.FriendsBottomLayout.Margin = New System.Windows.Forms.Padding(0)
            Me.FriendsBottomLayout.Name = "FriendsBottomLayout"
            Me.FriendsBottomLayout.RowCount = 3
            Me.FriendsBottomLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0F))
            Me.FriendsBottomLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.FriendsBottomLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0F))
            Me.FriendsBottomLayout.Size = New System.Drawing.Size(196, 176)
            Me.FriendsBottomLayout.TabIndex = 0
            '
            'FriendsHeaderStack
            '
            Me.FriendsHeaderStack.Controls.Add(Me.IconFriends)
            Me.FriendsHeaderStack.Controls.Add(Me.LblFriendsTitle)
            Me.FriendsHeaderStack.Dock = System.Windows.Forms.DockStyle.Fill
            Me.FriendsHeaderStack.Location = New System.Drawing.Point(0, 0)
            Me.FriendsHeaderStack.Margin = New System.Windows.Forms.Padding(0)
            Me.FriendsHeaderStack.Name = "FriendsHeaderStack"
            Me.FriendsHeaderStack.Size = New System.Drawing.Size(196, 32)
            Me.FriendsHeaderStack.TabIndex = 0
            Me.FriendsHeaderStack.WrapContents = False
            '
            'IconFriends
            '
            Me.IconFriends.AutoSize = True
            Me.IconFriends.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.IconFriends.Location = New System.Drawing.Point(0, 0)
            Me.IconFriends.Margin = New System.Windows.Forms.Padding(0, 0, 6, 0)
            Me.IconFriends.Name = "IconFriends"
            Me.IconFriends.Size = New System.Drawing.Size(26, 19)
            Me.IconFriends.TabIndex = 0
            Me.IconFriends.Text = "👥"
            '
            'LblFriendsTitle
            '
            Me.LblFriendsTitle.AutoSize = True
            Me.LblFriendsTitle.Font = New System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold)
            Me.LblFriendsTitle.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.LblFriendsTitle.Location = New System.Drawing.Point(32, 0)
            Me.LblFriendsTitle.Margin = New System.Windows.Forms.Padding(0)
            Me.LblFriendsTitle.Name = "LblFriendsTitle"
            Me.LblFriendsTitle.Size = New System.Drawing.Size(111, 17)
            Me.LblFriendsTitle.TabIndex = 1
            Me.LblFriendsTitle.Text = "Teman Tersimpan"
            '
            'PeoplePreviewContainer
            '
            Me.PeoplePreviewContainer.AutoScroll = True
            Me.PeoplePreviewContainer.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PeoplePreviewContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
            Me.PeoplePreviewContainer.Location = New System.Drawing.Point(0, 32)
            Me.PeoplePreviewContainer.Margin = New System.Windows.Forms.Padding(0)
            Me.PeoplePreviewContainer.Name = "PeoplePreviewContainer"
            Me.PeoplePreviewContainer.Size = New System.Drawing.Size(196, 106)
            Me.PeoplePreviewContainer.TabIndex = 1
            Me.PeoplePreviewContainer.WrapContents = False
            '
            'BtnBottomFriends
            '
            Me.BtnBottomFriends.BackColor = System.Drawing.Color.FromArgb(240, 253, 244)
            Me.BtnBottomFriends.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnBottomFriends.Dock = System.Windows.Forms.DockStyle.Fill
            Me.BtnBottomFriends.FlatAppearance.BorderSize = 0
            Me.BtnBottomFriends.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnBottomFriends.Font = New System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold)
            Me.BtnBottomFriends.ForeColor = System.Drawing.Color.FromArgb(47, 107, 79)
            Me.BtnBottomFriends.Location = New System.Drawing.Point(0, 138)
            Me.BtnBottomFriends.Margin = New System.Windows.Forms.Padding(0)
            Me.BtnBottomFriends.Name = "BtnBottomFriends"
            Me.BtnBottomFriends.Size = New System.Drawing.Size(196, 38)
            Me.BtnBottomFriends.TabIndex = 2
            Me.BtnBottomFriends.Text = "Kelola Teman"
            Me.BtnBottomFriends.UseVisualStyleBackColor = False
            '
            'BottomCardPlaces
            '
            Me.BottomCardPlaces.BackColor = System.Drawing.Color.White
            Me.BottomCardPlaces.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.BottomCardPlaces.Controls.Add(Me.PlacesBottomLayout)
            Me.BottomCardPlaces.Dock = System.Windows.Forms.DockStyle.Fill
            Me.BottomCardPlaces.Location = New System.Drawing.Point(480, 0)
            Me.BottomCardPlaces.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.BottomCardPlaces.Name = "BottomCardPlaces"
            Me.BottomCardPlaces.Padding = New System.Windows.Forms.Padding(16)
            Me.BottomCardPlaces.Size = New System.Drawing.Size(230, 210)
            Me.BottomCardPlaces.TabIndex = 2
            '
            'PlacesBottomLayout
            '
            Me.PlacesBottomLayout.ColumnCount = 1
            Me.PlacesBottomLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.PlacesBottomLayout.Controls.Add(Me.PlacesHeaderStack, 0, 0)
            Me.PlacesBottomLayout.Controls.Add(Me.PlacesPreviewContainer, 0, 1)
            Me.PlacesBottomLayout.Controls.Add(Me.BtnBottomPlaces, 0, 2)
            Me.PlacesBottomLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PlacesBottomLayout.Location = New System.Drawing.Point(16, 16)
            Me.PlacesBottomLayout.Margin = New System.Windows.Forms.Padding(0)
            Me.PlacesBottomLayout.Name = "PlacesBottomLayout"
            Me.PlacesBottomLayout.RowCount = 3
            Me.PlacesBottomLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0F))
            Me.PlacesBottomLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.PlacesBottomLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0F))
            Me.PlacesBottomLayout.Size = New System.Drawing.Size(196, 176)
            Me.PlacesBottomLayout.TabIndex = 0
            '
            'PlacesHeaderStack
            '
            Me.PlacesHeaderStack.Controls.Add(Me.IconPlaces)
            Me.PlacesHeaderStack.Controls.Add(Me.LblPlacesTitle)
            Me.PlacesHeaderStack.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PlacesHeaderStack.Location = New System.Drawing.Point(0, 0)
            Me.PlacesHeaderStack.Margin = New System.Windows.Forms.Padding(0)
            Me.PlacesHeaderStack.Name = "PlacesHeaderStack"
            Me.PlacesHeaderStack.Size = New System.Drawing.Size(196, 32)
            Me.PlacesHeaderStack.TabIndex = 0
            Me.PlacesHeaderStack.WrapContents = False
            '
            'IconPlaces
            '
            Me.IconPlaces.AutoSize = True
            Me.IconPlaces.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.IconPlaces.Location = New System.Drawing.Point(0, 0)
            Me.IconPlaces.Margin = New System.Windows.Forms.Padding(0, 0, 6, 0)
            Me.IconPlaces.Name = "IconPlaces"
            Me.IconPlaces.Size = New System.Drawing.Size(26, 19)
            Me.IconPlaces.TabIndex = 0
            Me.IconPlaces.Text = "📍"
            '
            'LblPlacesTitle
            '
            Me.LblPlacesTitle.AutoSize = True
            Me.LblPlacesTitle.Font = New System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold)
            Me.LblPlacesTitle.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.LblPlacesTitle.Location = New System.Drawing.Point(32, 0)
            Me.LblPlacesTitle.Margin = New System.Windows.Forms.Padding(0)
            Me.LblPlacesTitle.Name = "LblPlacesTitle"
            Me.LblPlacesTitle.Size = New System.Drawing.Size(117, 17)
            Me.LblPlacesTitle.TabIndex = 1
            Me.LblPlacesTitle.Text = "Tempat Tersimpan"
            '
            'PlacesPreviewContainer
            '
            Me.PlacesPreviewContainer.AutoScroll = True
            Me.PlacesPreviewContainer.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PlacesPreviewContainer.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
            Me.PlacesPreviewContainer.Location = New System.Drawing.Point(0, 32)
            Me.PlacesPreviewContainer.Margin = New System.Windows.Forms.Padding(0)
            Me.PlacesPreviewContainer.Name = "PlacesPreviewContainer"
            Me.PlacesPreviewContainer.Size = New System.Drawing.Size(196, 106)
            Me.PlacesPreviewContainer.TabIndex = 1
            Me.PlacesPreviewContainer.WrapContents = False
            '
            'BtnBottomPlaces
            '
            Me.BtnBottomPlaces.BackColor = System.Drawing.Color.FromArgb(240, 253, 244)
            Me.BtnBottomPlaces.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnBottomPlaces.Dock = System.Windows.Forms.DockStyle.Fill
            Me.BtnBottomPlaces.FlatAppearance.BorderSize = 0
            Me.BtnBottomPlaces.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnBottomPlaces.Font = New System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold)
            Me.BtnBottomPlaces.ForeColor = System.Drawing.Color.FromArgb(47, 107, 79)
            Me.BtnBottomPlaces.Location = New System.Drawing.Point(0, 138)
            Me.BtnBottomPlaces.Margin = New System.Windows.Forms.Padding(0)
            Me.BtnBottomPlaces.Name = "BtnBottomPlaces"
            Me.BtnBottomPlaces.Size = New System.Drawing.Size(196, 38)
            Me.BtnBottomPlaces.TabIndex = 2
            Me.BtnBottomPlaces.Text = "Kelola Tempat"
            Me.BtnBottomPlaces.UseVisualStyleBackColor = False
            '
            'BottomCardJoin
            '
            Me.BottomCardJoin.BackColor = System.Drawing.Color.White
            Me.BottomCardJoin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.BottomCardJoin.Controls.Add(Me.JoinBottomLayout)
            Me.BottomCardJoin.Dock = System.Windows.Forms.DockStyle.Fill
            Me.BottomCardJoin.Location = New System.Drawing.Point(718, 0)
            Me.BottomCardJoin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
            Me.BottomCardJoin.Name = "BottomCardJoin"
            Me.BottomCardJoin.Padding = New System.Windows.Forms.Padding(16)
            Me.BottomCardJoin.Size = New System.Drawing.Size(230, 210)
            Me.BottomCardJoin.TabIndex = 3
            '
            'JoinBottomLayout
            '
            Me.JoinBottomLayout.ColumnCount = 1
            Me.JoinBottomLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.JoinBottomLayout.Controls.Add(Me.JoinHeaderStack, 0, 0)
            Me.JoinBottomLayout.Controls.Add(Me.LblJoinDesc, 0, 1)
            Me.JoinBottomLayout.Controls.Add(Me.BtnBottomJoin, 0, 2)
            Me.JoinBottomLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.JoinBottomLayout.Location = New System.Drawing.Point(16, 16)
            Me.JoinBottomLayout.Margin = New System.Windows.Forms.Padding(0)
            Me.JoinBottomLayout.Name = "JoinBottomLayout"
            Me.JoinBottomLayout.RowCount = 3
            Me.JoinBottomLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0F))
            Me.JoinBottomLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.JoinBottomLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0F))
            Me.JoinBottomLayout.Size = New System.Drawing.Size(196, 176)
            Me.JoinBottomLayout.TabIndex = 0
            '
            'JoinHeaderStack
            '
            Me.JoinHeaderStack.Controls.Add(Me.IconJoin)
            Me.JoinHeaderStack.Controls.Add(Me.LblJoinTitle)
            Me.JoinHeaderStack.Dock = System.Windows.Forms.DockStyle.Fill
            Me.JoinHeaderStack.Location = New System.Drawing.Point(0, 0)
            Me.JoinHeaderStack.Margin = New System.Windows.Forms.Padding(0)
            Me.JoinHeaderStack.Name = "JoinHeaderStack"
            Me.JoinHeaderStack.Size = New System.Drawing.Size(196, 32)
            Me.JoinHeaderStack.TabIndex = 0
            Me.JoinHeaderStack.WrapContents = False
            '
            'IconJoin
            '
            Me.IconJoin.AutoSize = True
            Me.IconJoin.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.IconJoin.Location = New System.Drawing.Point(0, 0)
            Me.IconJoin.Margin = New System.Windows.Forms.Padding(0, 0, 6, 0)
            Me.IconJoin.Name = "IconJoin"
            Me.IconJoin.Size = New System.Drawing.Size(26, 19)
            Me.IconJoin.TabIndex = 0
            Me.IconJoin.Text = "↗"
            '
            'LblJoinTitle
            '
            Me.LblJoinTitle.AutoSize = True
            Me.LblJoinTitle.Font = New System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold)
            Me.LblJoinTitle.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.LblJoinTitle.Location = New System.Drawing.Point(32, 0)
            Me.LblJoinTitle.Margin = New System.Windows.Forms.Padding(0)
            Me.LblJoinTitle.Name = "LblJoinTitle"
            Me.LblJoinTitle.Size = New System.Drawing.Size(109, 17)
            Me.LblJoinTitle.TabIndex = 1
            Me.LblJoinTitle.Text = "Gabung Kegiatan"
            '
            'LblJoinDesc
            '
            Me.LblJoinDesc.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LblJoinDesc.Font = New System.Drawing.Font("Segoe UI", 8.5F)
            Me.LblJoinDesc.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128)
            Me.LblJoinDesc.Location = New System.Drawing.Point(0, 32)
            Me.LblJoinDesc.Margin = New System.Windows.Forms.Padding(0)
            Me.LblJoinDesc.Name = "LblJoinDesc"
            Me.LblJoinDesc.Size = New System.Drawing.Size(196, 106)
            Me.LblJoinDesc.TabIndex = 1
            Me.LblJoinDesc.Text = "Punya kode undangan teman? Masukkan kode 8 karakter untuk ikut bergabung."
            '
            'BtnBottomJoin
            '
            Me.BtnBottomJoin.BackColor = System.Drawing.Color.FromArgb(240, 253, 244)
            Me.BtnBottomJoin.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnBottomJoin.Dock = System.Windows.Forms.DockStyle.Fill
            Me.BtnBottomJoin.FlatAppearance.BorderSize = 0
            Me.BtnBottomJoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnBottomJoin.Font = New System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold)
            Me.BtnBottomJoin.ForeColor = System.Drawing.Color.FromArgb(47, 107, 79)
            Me.BtnBottomJoin.Location = New System.Drawing.Point(0, 138)
            Me.BtnBottomJoin.Margin = New System.Windows.Forms.Padding(0)
            Me.BtnBottomJoin.Name = "BtnBottomJoin"
            Me.BtnBottomJoin.Size = New System.Drawing.Size(196, 38)
            Me.BtnBottomJoin.TabIndex = 2
            Me.BtnBottomJoin.Text = "Masukkan Kode"
            Me.BtnBottomJoin.UseVisualStyleBackColor = False
            '
            'DashboardPage
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.AutoScroll = True
            Me.BackColor = System.Drawing.Color.FromArgb(246, 248, 246)
            Me.Controls.Add(Me.RootLayout)
            Me.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.Name = "DashboardPage"
            Me.Size = New System.Drawing.Size(1000, 960)
            Me.RootLayout.ResumeLayout(False)
            Me.RootLayout.PerformLayout()
            Me.TopBarLayout.ResumeLayout(False)
            Me.TopActionsFlow.ResumeLayout(False)
            Me.TopActionsFlow.PerformLayout()
            Me.BannerPanel.ResumeLayout(False)
            Me.BannerLayout.ResumeLayout(False)
            Me.BannerLeftStack.ResumeLayout(False)
            Me.BannerLeftStack.PerformLayout()
            Me.BannerRightStack.ResumeLayout(False)
            Me.BannerRightStack.PerformLayout()
            Me.MetricsRowLayout.ResumeLayout(False)
            Me.MetricCardActive.ResumeLayout(False)
            Me.ActiveCardLayout.ResumeLayout(False)
            Me.ContentStackActive.ResumeLayout(False)
            Me.ContentStackActive.PerformLayout()
            Me.MetricCardDone.ResumeLayout(False)
            Me.DoneCardLayout.ResumeLayout(False)
            Me.ContentStackDone.ResumeLayout(False)
            Me.ContentStackDone.PerformLayout()
            Me.MetricCardFriends.ResumeLayout(False)
            Me.FriendsCardLayout.ResumeLayout(False)
            Me.ContentStackFriends.ResumeLayout(False)
            Me.ContentStackFriends.PerformLayout()
            Me.MetricCardPlaces.ResumeLayout(False)
            Me.PlacesCardLayout.ResumeLayout(False)
            Me.ContentStackPlaces.ResumeLayout(False)
            Me.ContentStackPlaces.PerformLayout()
            Me.MiddleLayout.ResumeLayout(False)
            Me.MiddleLayout.PerformLayout()
            Me.LeftCard.ResumeLayout(False)
            Me.LeftCard.PerformLayout()
            Me.LeftCardLayout.ResumeLayout(False)
            Me.LeftCardLayout.PerformLayout()
            Me.LeftHeaderLayout.ResumeLayout(False)
            Me.LeftHeaderLayout.PerformLayout()
            Me.LeftTitleStack.ResumeLayout(False)
            Me.LeftTitleStack.PerformLayout()
            Me.RightCard.ResumeLayout(False)
            Me.RightCard.PerformLayout()
            Me.RightCardLayout.ResumeLayout(False)
            Me.RightCardLayout.PerformLayout()
            Me.BottomLayout.ResumeLayout(False)
            Me.BottomCardHistory.ResumeLayout(False)
            Me.HistoryCardLayout.ResumeLayout(False)
            Me.HistoryHeaderStack.ResumeLayout(False)
            Me.HistoryHeaderStack.PerformLayout()
            Me.BottomCardFriends.ResumeLayout(False)
            Me.FriendsBottomLayout.ResumeLayout(False)
            Me.FriendsHeaderStack.ResumeLayout(False)
            Me.FriendsHeaderStack.PerformLayout()
            Me.BottomCardPlaces.ResumeLayout(False)
            Me.PlacesBottomLayout.ResumeLayout(False)
            Me.PlacesHeaderStack.ResumeLayout(False)
            Me.PlacesHeaderStack.PerformLayout()
            Me.BottomCardJoin.ResumeLayout(False)
            Me.JoinBottomLayout.ResumeLayout(False)
            Me.JoinHeaderStack.ResumeLayout(False)
            Me.JoinHeaderStack.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Friend WithEvents RootLayout As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents TopBarLayout As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents TitleLabel As System.Windows.Forms.Label
        Friend WithEvents TopActionsFlow As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents BtnTopCreate As System.Windows.Forms.Button
        Friend WithEvents BtnTopJoin As System.Windows.Forms.Button
        Friend WithEvents SearchTextBox As System.Windows.Forms.TextBox
        Friend WithEvents BannerPanel As System.Windows.Forms.Panel
        Friend WithEvents BannerLayout As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents BannerLeftStack As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents BannerDateLabel As System.Windows.Forms.Label
        Friend WithEvents BannerWelcomeLabel As System.Windows.Forms.Label
        Friend WithEvents BannerDescLabel As System.Windows.Forms.Label
        Friend WithEvents BannerRightStack As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents RunningBadgeLabel As System.Windows.Forms.Label
        Friend WithEvents BtnBannerCreate As System.Windows.Forms.Button
        Friend WithEvents MetricsRowLayout As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents MetricCardActive As System.Windows.Forms.Panel
        Friend WithEvents ActiveCardLayout As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents IconBadgeActive As System.Windows.Forms.Label
        Friend WithEvents ContentStackActive As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents TitleMetricActive As System.Windows.Forms.Label
        Friend WithEvents ActiveGroupsCountLabel As System.Windows.Forms.Label
        Friend WithEvents DescMetricActive As System.Windows.Forms.Label
        Friend WithEvents MetricCardDone As System.Windows.Forms.Panel
        Friend WithEvents DoneCardLayout As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents IconBadgeDone As System.Windows.Forms.Label
        Friend WithEvents ContentStackDone As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents TitleMetricDone As System.Windows.Forms.Label
        Friend WithEvents CompletedGroupsCountLabel As System.Windows.Forms.Label
        Friend WithEvents DescMetricDone As System.Windows.Forms.Label
        Friend WithEvents MetricCardFriends As System.Windows.Forms.Panel
        Friend WithEvents FriendsCardLayout As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents IconBadgeFriends As System.Windows.Forms.Label
        Friend WithEvents ContentStackFriends As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents TitleMetricFriends As System.Windows.Forms.Label
        Friend WithEvents PeopleCountLabel As System.Windows.Forms.Label
        Friend WithEvents DescMetricFriends As System.Windows.Forms.Label
        Friend WithEvents MetricCardPlaces As System.Windows.Forms.Panel
        Friend WithEvents PlacesCardLayout As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents IconBadgePlaces As System.Windows.Forms.Label
        Friend WithEvents ContentStackPlaces As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents TitleMetricPlaces As System.Windows.Forms.Label
        Friend WithEvents PlacesCountLabel As System.Windows.Forms.Label
        Friend WithEvents DescMetricPlaces As System.Windows.Forms.Label
        Friend WithEvents MiddleLayout As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents LeftCard As System.Windows.Forms.Panel
        Friend WithEvents LeftCardLayout As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents LeftHeaderLayout As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents LeftTitleStack As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents LblActiveTitle As System.Windows.Forms.Label
        Friend WithEvents LblActiveSub As System.Windows.Forms.Label
        Friend WithEvents BtnViewAllActive As System.Windows.Forms.Button
        Friend WithEvents ActiveGroupsContainer As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents RightCard As System.Windows.Forms.Panel
        Friend WithEvents RightCardLayout As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents LblRightTitle As System.Windows.Forms.Label
        Friend WithEvents LblRightSub As System.Windows.Forms.Label
        Friend WithEvents BtnOptionHangout As System.Windows.Forms.Button
        Friend WithEvents BtnOptionTrip As System.Windows.Forms.Button
        Friend WithEvents BtnOptionRental As System.Windows.Forms.Button
        Friend WithEvents LblMethodHint As System.Windows.Forms.Label
        Friend WithEvents BottomLayout As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents BottomCardHistory As System.Windows.Forms.Panel
        Friend WithEvents HistoryCardLayout As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents HistoryHeaderStack As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents IconHistory As System.Windows.Forms.Label
        Friend WithEvents LblHistoryTitle As System.Windows.Forms.Label
        Friend WithEvents CompletedGroupsContainer As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents BtnBottomHistory As System.Windows.Forms.Button
        Friend WithEvents BottomCardFriends As System.Windows.Forms.Panel
        Friend WithEvents FriendsBottomLayout As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents FriendsHeaderStack As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents IconFriends As System.Windows.Forms.Label
        Friend WithEvents LblFriendsTitle As System.Windows.Forms.Label
        Friend WithEvents PeoplePreviewContainer As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents BtnBottomFriends As System.Windows.Forms.Button
        Friend WithEvents BottomCardPlaces As System.Windows.Forms.Panel
        Friend WithEvents PlacesBottomLayout As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents PlacesHeaderStack As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents IconPlaces As System.Windows.Forms.Label
        Friend WithEvents LblPlacesTitle As System.Windows.Forms.Label
        Friend WithEvents PlacesPreviewContainer As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents BtnBottomPlaces As System.Windows.Forms.Button
        Friend WithEvents BottomCardJoin As System.Windows.Forms.Panel
        Friend WithEvents JoinBottomLayout As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents JoinHeaderStack As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents IconJoin As System.Windows.Forms.Label
        Friend WithEvents LblJoinTitle As System.Windows.Forms.Label
        Friend WithEvents LblJoinDesc As System.Windows.Forms.Label
        Friend WithEvents BtnBottomJoin As System.Windows.Forms.Button
    End Class
End Namespace
