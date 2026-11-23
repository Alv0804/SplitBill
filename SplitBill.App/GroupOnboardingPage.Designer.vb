Namespace Global.SplitBill.App
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class GroupOnboardingPage
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
            Me.TitleLabel = New System.Windows.Forms.Label()
            Me.PageContainer = New System.Windows.Forms.Panel()
            Me.CreateCard = New System.Windows.Forms.TableLayoutPanel()
            Me.TypeLabel = New System.Windows.Forms.Label()
            Me.TypeCombo = New System.Windows.Forms.ComboBox()
            Me.NameLabel = New System.Windows.Forms.Label()
            Me.NameText = New System.Windows.Forms.TextBox()
            Me.DateLabel = New System.Windows.Forms.Label()
            Me.EventDatePicker = New System.Windows.Forms.DateTimePicker()
            Me.PlaceLabel = New System.Windows.Forms.Label()
            Me.PlaceRow = New System.Windows.Forms.TableLayoutPanel()
            Me.PlaceCombo = New System.Windows.Forms.ComboBox()
            Me.BtnAddPlace = New System.Windows.Forms.Button()
            Me.OwnerLabel = New System.Windows.Forms.Label()
            Me.OwnerRow = New System.Windows.Forms.TableLayoutPanel()
            Me.OwnerPersonCombo = New System.Windows.Forms.ComboBox()
            Me.BtnAddOwnerPerson = New System.Windows.Forms.Button()
            Me.MembersLabel = New System.Windows.Forms.Label()
            Me.MembersRow = New System.Windows.Forms.TableLayoutPanel()
            Me.MembersCheckList = New System.Windows.Forms.CheckedListBox()
            Me.BtnAddMemberPerson = New System.Windows.Forms.Button()
            Me.CreateActionBar = New System.Windows.Forms.FlowLayoutPanel()
            Me.BtnCreateSubmit = New System.Windows.Forms.Button()
            Me.BtnCreateBack = New System.Windows.Forms.Button()
            Me.CreateStatusLabel = New System.Windows.Forms.Label()
            Me.JoinCard = New System.Windows.Forms.FlowLayoutPanel()
            Me.CodeLabel = New System.Windows.Forms.Label()
            Me.CodeRow = New System.Windows.Forms.FlowLayoutPanel()
            Me.InviteCodeText = New System.Windows.Forms.TextBox()
            Me.BtnPreviewCode = New System.Windows.Forms.Button()
            Me.PreviewTextLabel = New System.Windows.Forms.Label()
            Me.ExistingMemberRadio = New System.Windows.Forms.RadioButton()
            Me.AvailableMembersCombo = New System.Windows.Forms.ComboBox()
            Me.NewMemberRadio = New System.Windows.Forms.RadioButton()
            Me.ProposedNameText = New System.Windows.Forms.TextBox()
            Me.JoinActionBar = New System.Windows.Forms.FlowLayoutPanel()
            Me.BtnJoinSubmit = New System.Windows.Forms.Button()
            Me.BtnJoinBack = New System.Windows.Forms.Button()
            Me.JoinStatusLabel = New System.Windows.Forms.Label()
            Me.ShellLayout.SuspendLayout()
            Me.PageContainer.SuspendLayout()
            Me.CreateCard.SuspendLayout()
            Me.PlaceRow.SuspendLayout()
            Me.OwnerRow.SuspendLayout()
            Me.MembersRow.SuspendLayout()
            Me.CreateActionBar.SuspendLayout()
            Me.JoinCard.SuspendLayout()
            Me.CodeRow.SuspendLayout()
            Me.JoinActionBar.SuspendLayout()
            Me.SuspendLayout()
            '
            'ShellLayout
            '
            Me.ShellLayout.BackColor = System.Drawing.Color.FromArgb(246, 248, 246)
            Me.ShellLayout.ColumnCount = 1
            Me.ShellLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.ShellLayout.Controls.Add(Me.TitleLabel, 0, 0)
            Me.ShellLayout.Controls.Add(Me.PageContainer, 0, 1)
            Me.ShellLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ShellLayout.Location = New System.Drawing.Point(0, 0)
            Me.ShellLayout.Name = "ShellLayout"
            Me.ShellLayout.Padding = New System.Windows.Forms.Padding(12)
            Me.ShellLayout.RowCount = 2
            Me.ShellLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64.0F))
            Me.ShellLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.ShellLayout.Size = New System.Drawing.Size(860, 680)
            Me.ShellLayout.TabIndex = 0
            '
            'TitleLabel
            '
            Me.TitleLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI", 21.0F, System.Drawing.FontStyle.Bold)
            Me.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.TitleLabel.Location = New System.Drawing.Point(12, 12)
            Me.TitleLabel.Name = "TitleLabel"
            Me.TitleLabel.Size = New System.Drawing.Size(836, 64)
            Me.TitleLabel.TabIndex = 0
            Me.TitleLabel.Text = "Buat Kegiatan Baru"
            Me.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'PageContainer
            '
            Me.PageContainer.Controls.Add(Me.CreateCard)
            Me.PageContainer.Controls.Add(Me.JoinCard)
            Me.PageContainer.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PageContainer.Location = New System.Drawing.Point(12, 76)
            Me.PageContainer.Margin = New System.Windows.Forms.Padding(0)
            Me.PageContainer.Name = "PageContainer"
            Me.PageContainer.Size = New System.Drawing.Size(836, 592)
            Me.PageContainer.TabIndex = 1
            '
            'CreateCard
            '
            Me.CreateCard.AutoScroll = True
            Me.CreateCard.BackColor = System.Drawing.Color.White
            Me.CreateCard.ColumnCount = 2
            Me.CreateCard.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160.0F))
            Me.CreateCard.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.CreateCard.Controls.Add(Me.TypeLabel, 0, 0)
            Me.CreateCard.Controls.Add(Me.TypeCombo, 1, 0)
            Me.CreateCard.Controls.Add(Me.NameLabel, 0, 1)
            Me.CreateCard.Controls.Add(Me.NameText, 1, 1)
            Me.CreateCard.Controls.Add(Me.DateLabel, 0, 2)
            Me.CreateCard.Controls.Add(Me.EventDatePicker, 1, 2)
            Me.CreateCard.Controls.Add(Me.PlaceLabel, 0, 3)
            Me.CreateCard.Controls.Add(Me.PlaceRow, 1, 3)
            Me.CreateCard.Controls.Add(Me.OwnerLabel, 0, 4)
            Me.CreateCard.Controls.Add(Me.OwnerRow, 1, 4)
            Me.CreateCard.Controls.Add(Me.MembersLabel, 0, 5)
            Me.CreateCard.Controls.Add(Me.MembersRow, 1, 5)
            Me.CreateCard.Controls.Add(Me.CreateActionBar, 1, 6)
            Me.CreateCard.Dock = System.Windows.Forms.DockStyle.Fill
            Me.CreateCard.Location = New System.Drawing.Point(0, 0)
            Me.CreateCard.Name = "CreateCard"
            Me.CreateCard.Padding = New System.Windows.Forms.Padding(24)
            Me.CreateCard.RowCount = 7
            Me.CreateCard.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize))
            Me.CreateCard.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize))
            Me.CreateCard.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize))
            Me.CreateCard.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize))
            Me.CreateCard.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize))
            Me.CreateCard.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize))
            Me.CreateCard.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize))
            Me.CreateCard.Size = New System.Drawing.Size(836, 592)
            Me.CreateCard.TabIndex = 0
            '
            'TypeLabel
            '
            Me.TypeLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TypeLabel.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.TypeLabel.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.TypeLabel.Location = New System.Drawing.Point(24, 32)
            Me.TypeLabel.Margin = New System.Windows.Forms.Padding(0, 8, 12, 4)
            Me.TypeLabel.Name = "TypeLabel"
            Me.TypeLabel.Size = New System.Drawing.Size(148, 25)
            Me.TypeLabel.TabIndex = 0
            Me.TypeLabel.Text = "Jenis kegiatan"
            '
            'TypeCombo
            '
            Me.TypeCombo.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.TypeCombo.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.TypeCombo.Location = New System.Drawing.Point(184, 28)
            Me.TypeCombo.Margin = New System.Windows.Forms.Padding(0, 4, 0, 8)
            Me.TypeCombo.Name = "TypeCombo"
            Me.TypeCombo.Size = New System.Drawing.Size(628, 25)
            Me.TypeCombo.TabIndex = 1
            '
            'NameLabel
            '
            Me.NameLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.NameLabel.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.NameLabel.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.NameLabel.Location = New System.Drawing.Point(24, 69)
            Me.NameLabel.Margin = New System.Windows.Forms.Padding(0, 8, 12, 4)
            Me.NameLabel.Name = "NameLabel"
            Me.NameLabel.Size = New System.Drawing.Size(148, 25)
            Me.NameLabel.TabIndex = 2
            Me.NameLabel.Text = "Nama grup"
            '
            'NameText
            '
            Me.NameText.Dock = System.Windows.Forms.DockStyle.Fill
            Me.NameText.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.NameText.Location = New System.Drawing.Point(184, 65)
            Me.NameText.Margin = New System.Windows.Forms.Padding(0, 4, 0, 8)
            Me.NameText.Name = "NameText"
            Me.NameText.PlaceholderText = "Contoh: Perjalanan Bandung"
            Me.NameText.Size = New System.Drawing.Size(628, 25)
            Me.NameText.TabIndex = 3
            '
            'DateLabel
            '
            Me.DateLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.DateLabel.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.DateLabel.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.DateLabel.Location = New System.Drawing.Point(24, 106)
            Me.DateLabel.Margin = New System.Windows.Forms.Padding(0, 8, 12, 4)
            Me.DateLabel.Name = "DateLabel"
            Me.DateLabel.Size = New System.Drawing.Size(148, 24)
            Me.DateLabel.TabIndex = 4
            Me.DateLabel.Text = "Tanggal"
            '
            'EventDatePicker
            '
            Me.EventDatePicker.Dock = System.Windows.Forms.DockStyle.Left
            Me.EventDatePicker.Font = New System.Drawing.Font("Segoe UI", 9.5F)
            Me.EventDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
            Me.EventDatePicker.Location = New System.Drawing.Point(184, 102)
            Me.EventDatePicker.Margin = New System.Windows.Forms.Padding(0, 4, 0, 8)
            Me.EventDatePicker.Name = "EventDatePicker"
            Me.EventDatePicker.Size = New System.Drawing.Size(300, 24)
            Me.EventDatePicker.TabIndex = 5
            '
            'PlaceLabel
            '
            Me.PlaceLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PlaceLabel.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.PlaceLabel.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.PlaceLabel.Location = New System.Drawing.Point(24, 142)
            Me.PlaceLabel.Margin = New System.Windows.Forms.Padding(0, 8, 12, 4)
            Me.PlaceLabel.Name = "PlaceLabel"
            Me.PlaceLabel.Size = New System.Drawing.Size(148, 38)
            Me.PlaceLabel.TabIndex = 6
            Me.PlaceLabel.Text = "Tempat"
            '
            'PlaceRow
            '
            Me.PlaceRow.ColumnCount = 2
            Me.PlaceRow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.PlaceRow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0F))
            Me.PlaceRow.Controls.Add(Me.PlaceCombo, 0, 0)
            Me.PlaceRow.Controls.Add(Me.BtnAddPlace, 1, 0)
            Me.PlaceRow.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PlaceRow.Location = New System.Drawing.Point(184, 138)
            Me.PlaceRow.Margin = New System.Windows.Forms.Padding(0, 4, 0, 8)
            Me.PlaceRow.Name = "PlaceRow"
            Me.PlaceRow.RowCount = 1
            Me.PlaceRow.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.PlaceRow.Size = New System.Drawing.Size(628, 38)
            Me.PlaceRow.TabIndex = 7
            '
            'PlaceCombo
            '
            Me.PlaceCombo.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PlaceCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.PlaceCombo.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.PlaceCombo.Location = New System.Drawing.Point(0, 6)
            Me.PlaceCombo.Margin = New System.Windows.Forms.Padding(0, 6, 8, 0)
            Me.PlaceCombo.Name = "PlaceCombo"
            Me.PlaceCombo.Size = New System.Drawing.Size(490, 25)
            Me.PlaceCombo.TabIndex = 0
            '
            'BtnAddPlace
            '
            Me.BtnAddPlace.AutoSize = True
            Me.BtnAddPlace.BackColor = System.Drawing.Color.White
            Me.BtnAddPlace.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnAddPlace.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 231, 235)
            Me.BtnAddPlace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnAddPlace.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.BtnAddPlace.Location = New System.Drawing.Point(498, 0)
            Me.BtnAddPlace.Margin = New System.Windows.Forms.Padding(0)
            Me.BtnAddPlace.Name = "BtnAddPlace"
            Me.BtnAddPlace.Size = New System.Drawing.Size(120, 38)
            Me.BtnAddPlace.TabIndex = 1
            Me.BtnAddPlace.Text = "Tambah tempat"
            Me.BtnAddPlace.UseVisualStyleBackColor = False
            '
            'OwnerLabel
            '
            Me.OwnerLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.OwnerLabel.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.OwnerLabel.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.OwnerLabel.Location = New System.Drawing.Point(24, 192)
            Me.OwnerLabel.Margin = New System.Windows.Forms.Padding(0, 8, 12, 4)
            Me.OwnerLabel.Name = "OwnerLabel"
            Me.OwnerLabel.Size = New System.Drawing.Size(148, 38)
            Me.OwnerLabel.TabIndex = 8
            Me.OwnerLabel.Text = "Nama owner"
            '
            'OwnerRow
            '
            Me.OwnerRow.ColumnCount = 2
            Me.OwnerRow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.OwnerRow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0F))
            Me.OwnerRow.Controls.Add(Me.OwnerPersonCombo, 0, 0)
            Me.OwnerRow.Controls.Add(Me.BtnAddOwnerPerson, 1, 0)
            Me.OwnerRow.Dock = System.Windows.Forms.DockStyle.Fill
            Me.OwnerRow.Location = New System.Drawing.Point(184, 188)
            Me.OwnerRow.Margin = New System.Windows.Forms.Padding(0, 4, 0, 8)
            Me.OwnerRow.Name = "OwnerRow"
            Me.OwnerRow.RowCount = 1
            Me.OwnerRow.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.OwnerRow.Size = New System.Drawing.Size(628, 38)
            Me.OwnerRow.TabIndex = 9
            '
            'OwnerPersonCombo
            '
            Me.OwnerPersonCombo.Dock = System.Windows.Forms.DockStyle.Fill
            Me.OwnerPersonCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.OwnerPersonCombo.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.OwnerPersonCombo.Location = New System.Drawing.Point(0, 6)
            Me.OwnerPersonCombo.Margin = New System.Windows.Forms.Padding(0, 6, 8, 0)
            Me.OwnerPersonCombo.Name = "OwnerPersonCombo"
            Me.OwnerPersonCombo.Size = New System.Drawing.Size(490, 25)
            Me.OwnerPersonCombo.TabIndex = 0
            '
            'BtnAddOwnerPerson
            '
            Me.BtnAddOwnerPerson.AutoSize = True
            Me.BtnAddOwnerPerson.BackColor = System.Drawing.Color.White
            Me.BtnAddOwnerPerson.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnAddOwnerPerson.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 231, 235)
            Me.BtnAddOwnerPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnAddOwnerPerson.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.BtnAddOwnerPerson.Location = New System.Drawing.Point(498, 0)
            Me.BtnAddOwnerPerson.Margin = New System.Windows.Forms.Padding(0)
            Me.BtnAddOwnerPerson.Name = "BtnAddOwnerPerson"
            Me.BtnAddOwnerPerson.Size = New System.Drawing.Size(120, 38)
            Me.BtnAddOwnerPerson.TabIndex = 1
            Me.BtnAddOwnerPerson.Text = "Tambah nama"
            Me.BtnAddOwnerPerson.UseVisualStyleBackColor = False
            '
            'MembersLabel
            '
            Me.MembersLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MembersLabel.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.MembersLabel.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.MembersLabel.Location = New System.Drawing.Point(24, 242)
            Me.MembersLabel.Margin = New System.Windows.Forms.Padding(0, 8, 12, 4)
            Me.MembersLabel.Name = "MembersLabel"
            Me.MembersLabel.Size = New System.Drawing.Size(148, 206)
            Me.MembersLabel.TabIndex = 10
            Me.MembersLabel.Text = "Teman lain"
            '
            'MembersRow
            '
            Me.MembersRow.ColumnCount = 1
            Me.MembersRow.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.MembersRow.Controls.Add(Me.MembersCheckList, 0, 0)
            Me.MembersRow.Controls.Add(Me.BtnAddMemberPerson, 0, 1)
            Me.MembersRow.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MembersRow.Location = New System.Drawing.Point(184, 238)
            Me.MembersRow.Margin = New System.Windows.Forms.Padding(0, 4, 0, 8)
            Me.MembersRow.Name = "MembersRow"
            Me.MembersRow.RowCount = 2
            Me.MembersRow.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160.0F))
            Me.MembersRow.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize))
            Me.MembersRow.Size = New System.Drawing.Size(628, 206)
            Me.MembersRow.TabIndex = 11
            '
            'MembersCheckList
            '
            Me.MembersCheckList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.MembersCheckList.CheckOnClick = True
            Me.MembersCheckList.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MembersCheckList.Font = New System.Drawing.Font("Segoe UI", 9.5F)
            Me.MembersCheckList.Location = New System.Drawing.Point(0, 0)
            Me.MembersCheckList.Margin = New System.Windows.Forms.Padding(0, 0, 0, 6)
            Me.MembersCheckList.Name = "MembersCheckList"
            Me.MembersCheckList.Size = New System.Drawing.Size(628, 154)
            Me.MembersCheckList.TabIndex = 0
            '
            'BtnAddMemberPerson
            '
            Me.BtnAddMemberPerson.AutoSize = True
            Me.BtnAddMemberPerson.BackColor = System.Drawing.Color.White
            Me.BtnAddMemberPerson.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnAddMemberPerson.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 231, 235)
            Me.BtnAddMemberPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnAddMemberPerson.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.BtnAddMemberPerson.Location = New System.Drawing.Point(0, 160)
            Me.BtnAddMemberPerson.Margin = New System.Windows.Forms.Padding(0)
            Me.BtnAddMemberPerson.Name = "BtnAddMemberPerson"
            Me.BtnAddMemberPerson.Size = New System.Drawing.Size(160, 38)
            Me.BtnAddMemberPerson.TabIndex = 1
            Me.BtnAddMemberPerson.Text = "Tambah nama teman"
            Me.BtnAddMemberPerson.UseVisualStyleBackColor = False
            '
            'CreateActionBar
            '
            Me.CreateActionBar.AutoSize = True
            Me.CreateActionBar.Controls.Add(Me.BtnCreateSubmit)
            Me.CreateActionBar.Controls.Add(Me.BtnCreateBack)
            Me.CreateActionBar.Controls.Add(Me.CreateStatusLabel)
            Me.CreateActionBar.Dock = System.Windows.Forms.DockStyle.Fill
            Me.CreateActionBar.Location = New System.Drawing.Point(184, 452)
            Me.CreateActionBar.Margin = New System.Windows.Forms.Padding(0)
            Me.CreateActionBar.Name = "CreateActionBar"
            Me.CreateActionBar.Size = New System.Drawing.Size(628, 44)
            Me.CreateActionBar.TabIndex = 12
            Me.CreateActionBar.WrapContents = True
            '
            'BtnCreateSubmit
            '
            Me.BtnCreateSubmit.AutoSize = True
            Me.BtnCreateSubmit.BackColor = System.Drawing.Color.FromArgb(47, 107, 79)
            Me.BtnCreateSubmit.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnCreateSubmit.FlatAppearance.BorderSize = 0
            Me.BtnCreateSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnCreateSubmit.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.BtnCreateSubmit.ForeColor = System.Drawing.Color.White
            Me.BtnCreateSubmit.Location = New System.Drawing.Point(0, 3)
            Me.BtnCreateSubmit.Margin = New System.Windows.Forms.Padding(0, 3, 10, 3)
            Me.BtnCreateSubmit.Name = "BtnCreateSubmit"
            Me.BtnCreateSubmit.Size = New System.Drawing.Size(130, 38)
            Me.BtnCreateSubmit.TabIndex = 0
            Me.BtnCreateSubmit.Text = "Buat Grup Aktif"
            Me.BtnCreateSubmit.UseVisualStyleBackColor = False
            '
            'BtnCreateBack
            '
            Me.BtnCreateBack.AutoSize = True
            Me.BtnCreateBack.BackColor = System.Drawing.Color.White
            Me.BtnCreateBack.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnCreateBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 231, 235)
            Me.BtnCreateBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnCreateBack.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.BtnCreateBack.Location = New System.Drawing.Point(140, 3)
            Me.BtnCreateBack.Margin = New System.Windows.Forms.Padding(0, 3, 10, 3)
            Me.BtnCreateBack.Name = "BtnCreateBack"
            Me.BtnCreateBack.Size = New System.Drawing.Size(85, 38)
            Me.BtnCreateBack.TabIndex = 1
            Me.BtnCreateBack.Text = "Kembali"
            Me.BtnCreateBack.UseVisualStyleBackColor = False
            '
            'CreateStatusLabel
            '
            Me.CreateStatusLabel.AutoSize = True
            Me.CreateStatusLabel.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128)
            Me.CreateStatusLabel.Location = New System.Drawing.Point(235, 14)
            Me.CreateStatusLabel.Margin = New System.Windows.Forms.Padding(0, 14, 0, 0)
            Me.CreateStatusLabel.MaximumSize = New System.Drawing.Size(350, 0)
            Me.CreateStatusLabel.Name = "CreateStatusLabel"
            Me.CreateStatusLabel.Size = New System.Drawing.Size(0, 15)
            Me.CreateStatusLabel.TabIndex = 2
            '
            'JoinCard
            '
            Me.JoinCard.AutoScroll = True
            Me.JoinCard.BackColor = System.Drawing.Color.White
            Me.JoinCard.Controls.Add(Me.CodeLabel)
            Me.JoinCard.Controls.Add(Me.CodeRow)
            Me.JoinCard.Controls.Add(Me.PreviewTextLabel)
            Me.JoinCard.Controls.Add(Me.ExistingMemberRadio)
            Me.JoinCard.Controls.Add(Me.AvailableMembersCombo)
            Me.JoinCard.Controls.Add(Me.NewMemberRadio)
            Me.JoinCard.Controls.Add(Me.ProposedNameText)
            Me.JoinCard.Controls.Add(Me.JoinActionBar)
            Me.JoinCard.Dock = System.Windows.Forms.DockStyle.Fill
            Me.JoinCard.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
            Me.JoinCard.Location = New System.Drawing.Point(0, 0)
            Me.JoinCard.Name = "JoinCard"
            Me.JoinCard.Padding = New System.Windows.Forms.Padding(24)
            Me.JoinCard.Size = New System.Drawing.Size(836, 592)
            Me.JoinCard.TabIndex = 1
            Me.JoinCard.Visible = False
            Me.JoinCard.WrapContents = False
            '
            'CodeLabel
            '
            Me.CodeLabel.AutoSize = True
            Me.CodeLabel.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.CodeLabel.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.CodeLabel.Location = New System.Drawing.Point(24, 24)
            Me.CodeLabel.Name = "CodeLabel"
            Me.CodeLabel.Size = New System.Drawing.Size(161, 15)
            Me.CodeLabel.TabIndex = 0
            Me.CodeLabel.Text = "Kode undangan (8 karakter)"
            '
            'CodeRow
            '
            Me.CodeRow.AutoSize = True
            Me.CodeRow.Controls.Add(Me.InviteCodeText)
            Me.CodeRow.Controls.Add(Me.BtnPreviewCode)
            Me.CodeRow.Location = New System.Drawing.Point(24, 42)
            Me.CodeRow.Margin = New System.Windows.Forms.Padding(0, 3, 0, 10)
            Me.CodeRow.Name = "CodeRow"
            Me.CodeRow.Size = New System.Drawing.Size(350, 44)
            Me.CodeRow.TabIndex = 1
            Me.CodeRow.WrapContents = True
            '
            'InviteCodeText
            '
            Me.InviteCodeText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.InviteCodeText.Font = New System.Drawing.Font("Segoe UI", 12.0F)
            Me.InviteCodeText.Location = New System.Drawing.Point(0, 3)
            Me.InviteCodeText.Margin = New System.Windows.Forms.Padding(0, 3, 10, 0)
            Me.InviteCodeText.MaxLength = 8
            Me.InviteCodeText.Name = "InviteCodeText"
            Me.InviteCodeText.Size = New System.Drawing.Size(220, 29)
            Me.InviteCodeText.TabIndex = 0
            '
            'BtnPreviewCode
            '
            Me.BtnPreviewCode.AutoSize = True
            Me.BtnPreviewCode.BackColor = System.Drawing.Color.FromArgb(47, 107, 79)
            Me.BtnPreviewCode.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnPreviewCode.FlatAppearance.BorderSize = 0
            Me.BtnPreviewCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnPreviewCode.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.BtnPreviewCode.ForeColor = System.Drawing.Color.White
            Me.BtnPreviewCode.Location = New System.Drawing.Point(230, 0)
            Me.BtnPreviewCode.Margin = New System.Windows.Forms.Padding(0)
            Me.BtnPreviewCode.Name = "BtnPreviewCode"
            Me.BtnPreviewCode.Size = New System.Drawing.Size(120, 38)
            Me.BtnPreviewCode.TabIndex = 1
            Me.BtnPreviewCode.Text = "Periksa Kode"
            Me.BtnPreviewCode.UseVisualStyleBackColor = False
            '
            'PreviewTextLabel
            '
            Me.PreviewTextLabel.AutoSize = True
            Me.PreviewTextLabel.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.PreviewTextLabel.Location = New System.Drawing.Point(24, 108)
            Me.PreviewTextLabel.Margin = New System.Windows.Forms.Padding(0, 12, 0, 10)
            Me.PreviewTextLabel.MaximumSize = New System.Drawing.Size(700, 0)
            Me.PreviewTextLabel.Name = "PreviewTextLabel"
            Me.PreviewTextLabel.Size = New System.Drawing.Size(0, 15)
            Me.PreviewTextLabel.TabIndex = 2
            '
            'ExistingMemberRadio
            '
            Me.ExistingMemberRadio.AutoSize = True
            Me.ExistingMemberRadio.Checked = True
            Me.ExistingMemberRadio.Enabled = False
            Me.ExistingMemberRadio.Location = New System.Drawing.Point(24, 136)
            Me.ExistingMemberRadio.Margin = New System.Windows.Forms.Padding(0, 3, 0, 4)
            Me.ExistingMemberRadio.Name = "ExistingMemberRadio"
            Me.ExistingMemberRadio.Size = New System.Drawing.Size(155, 19)
            Me.ExistingMemberRadio.TabIndex = 3
            Me.ExistingMemberRadio.TabStop = True
            Me.ExistingMemberRadio.Text = "Pilih nama yang tersedia"
            Me.ExistingMemberRadio.UseVisualStyleBackColor = True
            '
            'AvailableMembersCombo
            '
            Me.AvailableMembersCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.AvailableMembersCombo.Enabled = False
            Me.AvailableMembersCombo.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.AvailableMembersCombo.Location = New System.Drawing.Point(24, 162)
            Me.AvailableMembersCombo.Margin = New System.Windows.Forms.Padding(0, 3, 0, 12)
            Me.AvailableMembersCombo.Name = "AvailableMembersCombo"
            Me.AvailableMembersCombo.Size = New System.Drawing.Size(360, 25)
            Me.AvailableMembersCombo.TabIndex = 4
            '
            'NewMemberRadio
            '
            Me.NewMemberRadio.AutoSize = True
            Me.NewMemberRadio.Enabled = False
            Me.NewMemberRadio.Location = New System.Drawing.Point(24, 202)
            Me.NewMemberRadio.Margin = New System.Windows.Forms.Padding(0, 3, 0, 4)
            Me.NewMemberRadio.Name = "NewMemberRadio"
            Me.NewMemberRadio.Size = New System.Drawing.Size(120, 19)
            Me.NewMemberRadio.TabIndex = 5
            Me.NewMemberRadio.Text = "Ajukan nama baru"
            Me.NewMemberRadio.UseVisualStyleBackColor = True
            '
            'ProposedNameText
            '
            Me.ProposedNameText.Enabled = False
            Me.ProposedNameText.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.ProposedNameText.Location = New System.Drawing.Point(24, 228)
            Me.ProposedNameText.Margin = New System.Windows.Forms.Padding(0, 3, 0, 16)
            Me.ProposedNameText.Name = "ProposedNameText"
            Me.ProposedNameText.PlaceholderText = "Nama yang diajukan"
            Me.ProposedNameText.Size = New System.Drawing.Size(360, 25)
            Me.ProposedNameText.TabIndex = 6
            '
            'JoinActionBar
            '
            Me.JoinActionBar.AutoSize = True
            Me.JoinActionBar.Controls.Add(Me.BtnJoinSubmit)
            Me.JoinActionBar.Controls.Add(Me.BtnJoinBack)
            Me.JoinActionBar.Controls.Add(Me.JoinStatusLabel)
            Me.JoinActionBar.Location = New System.Drawing.Point(24, 269)
            Me.JoinActionBar.Margin = New System.Windows.Forms.Padding(0)
            Me.JoinActionBar.Name = "JoinActionBar"
            Me.JoinActionBar.Size = New System.Drawing.Size(350, 44)
            Me.JoinActionBar.TabIndex = 7
            Me.JoinActionBar.WrapContents = True
            '
            'BtnJoinSubmit
            '
            Me.BtnJoinSubmit.AutoSize = True
            Me.BtnJoinSubmit.BackColor = System.Drawing.Color.FromArgb(47, 107, 79)
            Me.BtnJoinSubmit.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnJoinSubmit.Enabled = False
            Me.BtnJoinSubmit.FlatAppearance.BorderSize = 0
            Me.BtnJoinSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnJoinSubmit.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.BtnJoinSubmit.ForeColor = System.Drawing.Color.White
            Me.BtnJoinSubmit.Location = New System.Drawing.Point(0, 3)
            Me.BtnJoinSubmit.Margin = New System.Windows.Forms.Padding(0, 3, 10, 3)
            Me.BtnJoinSubmit.Name = "BtnJoinSubmit"
            Me.BtnJoinSubmit.Size = New System.Drawing.Size(185, 38)
            Me.BtnJoinSubmit.TabIndex = 0
            Me.BtnJoinSubmit.Text = "Kirim Permintaan Bergabung"
            Me.BtnJoinSubmit.UseVisualStyleBackColor = False
            '
            'BtnJoinBack
            '
            Me.BtnJoinBack.AutoSize = True
            Me.BtnJoinBack.BackColor = System.Drawing.Color.White
            Me.BtnJoinBack.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnJoinBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 231, 235)
            Me.BtnJoinBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnJoinBack.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.BtnJoinBack.Location = New System.Drawing.Point(195, 3)
            Me.BtnJoinBack.Margin = New System.Windows.Forms.Padding(0, 3, 10, 3)
            Me.BtnJoinBack.Name = "BtnJoinBack"
            Me.BtnJoinBack.Size = New System.Drawing.Size(85, 38)
            Me.BtnJoinBack.TabIndex = 1
            Me.BtnJoinBack.Text = "Kembali"
            Me.BtnJoinBack.UseVisualStyleBackColor = False
            '
            'JoinStatusLabel
            '
            Me.JoinStatusLabel.AutoSize = True
            Me.JoinStatusLabel.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128)
            Me.JoinStatusLabel.Location = New System.Drawing.Point(290, 14)
            Me.JoinStatusLabel.Margin = New System.Windows.Forms.Padding(0, 14, 0, 0)
            Me.JoinStatusLabel.MaximumSize = New System.Drawing.Size(350, 0)
            Me.JoinStatusLabel.Name = "JoinStatusLabel"
            Me.JoinStatusLabel.Size = New System.Drawing.Size(0, 15)
            Me.JoinStatusLabel.TabIndex = 2
            '
            'GroupOnboardingPage
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(246, 248, 246)
            Me.Controls.Add(Me.ShellLayout)
            Me.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.Name = "GroupOnboardingPage"
            Me.Size = New System.Drawing.Size(860, 680)
            Me.ShellLayout.ResumeLayout(False)
            Me.PageContainer.ResumeLayout(False)
            Me.CreateCard.ResumeLayout(False)
            Me.CreateCard.PerformLayout()
            Me.PlaceRow.ResumeLayout(False)
            Me.PlaceRow.PerformLayout()
            Me.OwnerRow.ResumeLayout(False)
            Me.OwnerRow.PerformLayout()
            Me.MembersRow.ResumeLayout(False)
            Me.MembersRow.PerformLayout()
            Me.CreateActionBar.ResumeLayout(False)
            Me.CreateActionBar.PerformLayout()
            Me.JoinCard.ResumeLayout(False)
            Me.JoinCard.PerformLayout()
            Me.CodeRow.ResumeLayout(False)
            Me.CodeRow.PerformLayout()
            Me.JoinActionBar.ResumeLayout(False)
            Me.JoinActionBar.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents ShellLayout As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents TitleLabel As System.Windows.Forms.Label
        Friend WithEvents PageContainer As System.Windows.Forms.Panel
        Friend WithEvents CreateCard As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents TypeLabel As System.Windows.Forms.Label
        Friend WithEvents TypeCombo As System.Windows.Forms.ComboBox
        Friend WithEvents NameLabel As System.Windows.Forms.Label
        Friend WithEvents NameText As System.Windows.Forms.TextBox
        Friend WithEvents DateLabel As System.Windows.Forms.Label
        Friend WithEvents EventDatePicker As System.Windows.Forms.DateTimePicker
        Friend WithEvents PlaceLabel As System.Windows.Forms.Label
        Friend WithEvents PlaceRow As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents PlaceCombo As System.Windows.Forms.ComboBox
        Friend WithEvents BtnAddPlace As System.Windows.Forms.Button
        Friend WithEvents OwnerLabel As System.Windows.Forms.Label
        Friend WithEvents OwnerRow As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents OwnerPersonCombo As System.Windows.Forms.ComboBox
        Friend WithEvents BtnAddOwnerPerson As System.Windows.Forms.Button
        Friend WithEvents MembersLabel As System.Windows.Forms.Label
        Friend WithEvents MembersRow As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents MembersCheckList As System.Windows.Forms.CheckedListBox
        Friend WithEvents BtnAddMemberPerson As System.Windows.Forms.Button
        Friend WithEvents CreateActionBar As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents BtnCreateSubmit As System.Windows.Forms.Button
        Friend WithEvents BtnCreateBack As System.Windows.Forms.Button
        Friend WithEvents CreateStatusLabel As System.Windows.Forms.Label
        Friend WithEvents JoinCard As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents CodeLabel As System.Windows.Forms.Label
        Friend WithEvents CodeRow As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents InviteCodeText As System.Windows.Forms.TextBox
        Friend WithEvents BtnPreviewCode As System.Windows.Forms.Button
        Friend WithEvents PreviewTextLabel As System.Windows.Forms.Label
        Friend WithEvents ExistingMemberRadio As System.Windows.Forms.RadioButton
        Friend WithEvents AvailableMembersCombo As System.Windows.Forms.ComboBox
        Friend WithEvents NewMemberRadio As System.Windows.Forms.RadioButton
        Friend WithEvents ProposedNameText As System.Windows.Forms.TextBox
        Friend WithEvents JoinActionBar As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents BtnJoinSubmit As System.Windows.Forms.Button
        Friend WithEvents BtnJoinBack As System.Windows.Forms.Button
        Friend WithEvents JoinStatusLabel As System.Windows.Forms.Label
    End Class
End Namespace
