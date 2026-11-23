Namespace Global.SplitBill.App
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class OwnerDataPage
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
            Me.HeaderLayout = New System.Windows.Forms.TableLayoutPanel()
            Me.TitleStack = New System.Windows.Forms.FlowLayoutPanel()
            Me.TitleLabel = New System.Windows.Forms.Label()
            Me.SubtitleLabel = New System.Windows.Forms.Label()
            Me.BtnReload = New System.Windows.Forms.Button()
            Me.TabsControl = New System.Windows.Forms.TabControl()
            Me.PeopleTab = New System.Windows.Forms.TabPage()
            Me.PeopleLayout = New System.Windows.Forms.TableLayoutPanel()
            Me.PeopleSearchSide = New System.Windows.Forms.TableLayoutPanel()
            Me.PeopleSearchText = New System.Windows.Forms.TextBox()
            Me.PeopleList = New System.Windows.Forms.ListBox()
            Me.PeopleEditorCard = New System.Windows.Forms.Panel()
            Me.PeopleEditorFlow = New System.Windows.Forms.FlowLayoutPanel()
            Me.PeopleNameLabel = New System.Windows.Forms.Label()
            Me.PeopleNameText = New System.Windows.Forms.TextBox()
            Me.PeopleNoteLabel = New System.Windows.Forms.Label()
            Me.PeopleNoteText = New System.Windows.Forms.TextBox()
            Me.PeopleButtonsFlow = New System.Windows.Forms.FlowLayoutPanel()
            Me.BtnSavePerson = New System.Windows.Forms.Button()
            Me.BtnDeletePerson = New System.Windows.Forms.Button()
            Me.BtnClearPerson = New System.Windows.Forms.Button()
            Me.PeopleStatusLabel = New System.Windows.Forms.Label()
            Me.PlacesTab = New System.Windows.Forms.TabPage()
            Me.PlacesLayout = New System.Windows.Forms.TableLayoutPanel()
            Me.PlacesSearchSide = New System.Windows.Forms.TableLayoutPanel()
            Me.PlacesSearchText = New System.Windows.Forms.TextBox()
            Me.PlacesList = New System.Windows.Forms.ListBox()
            Me.PlacesEditorCard = New System.Windows.Forms.Panel()
            Me.PlacesEditorFlow = New System.Windows.Forms.FlowLayoutPanel()
            Me.PlacesNameLabel = New System.Windows.Forms.Label()
            Me.PlacesNameText = New System.Windows.Forms.TextBox()
            Me.PlacesCategoryLabel = New System.Windows.Forms.Label()
            Me.PlacesCategoryText = New System.Windows.Forms.TextBox()
            Me.PlacesAddressLabel = New System.Windows.Forms.Label()
            Me.PlacesAddressText = New System.Windows.Forms.TextBox()
            Me.PlacesButtonsFlow = New System.Windows.Forms.FlowLayoutPanel()
            Me.BtnSavePlace = New System.Windows.Forms.Button()
            Me.BtnDeletePlace = New System.Windows.Forms.Button()
            Me.BtnClearPlace = New System.Windows.Forms.Button()
            Me.PlacesStatusLabel = New System.Windows.Forms.Label()
            Me.RootLayout.SuspendLayout()
            Me.HeaderLayout.SuspendLayout()
            Me.TitleStack.SuspendLayout()
            Me.TabsControl.SuspendLayout()
            Me.PeopleTab.SuspendLayout()
            Me.PeopleLayout.SuspendLayout()
            Me.PeopleSearchSide.SuspendLayout()
            Me.PeopleEditorCard.SuspendLayout()
            Me.PeopleEditorFlow.SuspendLayout()
            Me.PeopleButtonsFlow.SuspendLayout()
            Me.PlacesTab.SuspendLayout()
            Me.PlacesLayout.SuspendLayout()
            Me.PlacesSearchSide.SuspendLayout()
            Me.PlacesEditorCard.SuspendLayout()
            Me.PlacesEditorFlow.SuspendLayout()
            Me.PlacesButtonsFlow.SuspendLayout()
            Me.SuspendLayout()
            '
            'RootLayout
            '
            Me.RootLayout.BackColor = System.Drawing.Color.FromArgb(246, 248, 246)
            Me.RootLayout.ColumnCount = 1
            Me.RootLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.RootLayout.Controls.Add(Me.HeaderLayout, 0, 0)
            Me.RootLayout.Controls.Add(Me.TabsControl, 0, 1)
            Me.RootLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.RootLayout.Location = New System.Drawing.Point(0, 0)
            Me.RootLayout.Name = "RootLayout"
            Me.RootLayout.Padding = New System.Windows.Forms.Padding(24, 20, 24, 20)
            Me.RootLayout.RowCount = 2
            Me.RootLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68.0F))
            Me.RootLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.RootLayout.Size = New System.Drawing.Size(950, 650)
            Me.RootLayout.TabIndex = 0
            '
            'HeaderLayout
            '
            Me.HeaderLayout.ColumnCount = 2
            Me.HeaderLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.HeaderLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130.0F))
            Me.HeaderLayout.Controls.Add(Me.TitleStack, 0, 0)
            Me.HeaderLayout.Controls.Add(Me.BtnReload, 1, 0)
            Me.HeaderLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.HeaderLayout.Location = New System.Drawing.Point(24, 20)
            Me.HeaderLayout.Margin = New System.Windows.Forms.Padding(0)
            Me.HeaderLayout.Name = "HeaderLayout"
            Me.HeaderLayout.RowCount = 1
            Me.HeaderLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.HeaderLayout.Size = New System.Drawing.Size(902, 68)
            Me.HeaderLayout.TabIndex = 0
            '
            'TitleStack
            '
            Me.TitleStack.Controls.Add(Me.TitleLabel)
            Me.TitleStack.Controls.Add(Me.SubtitleLabel)
            Me.TitleStack.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TitleStack.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
            Me.TitleStack.Location = New System.Drawing.Point(0, 0)
            Me.TitleStack.Margin = New System.Windows.Forms.Padding(0)
            Me.TitleStack.Name = "TitleStack"
            Me.TitleStack.Size = New System.Drawing.Size(772, 68)
            Me.TitleStack.TabIndex = 0
            Me.TitleStack.WrapContents = False
            '
            'TitleLabel
            '
            Me.TitleLabel.AutoSize = True
            Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI", 20.0F, System.Drawing.FontStyle.Bold)
            Me.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.TitleLabel.Location = New System.Drawing.Point(0, 0)
            Me.TitleLabel.Margin = New System.Windows.Forms.Padding(0)
            Me.TitleLabel.Name = "TitleLabel"
            Me.TitleLabel.Size = New System.Drawing.Size(215, 37)
            Me.TitleLabel.TabIndex = 0
            Me.TitleLabel.Text = "Data Tersimpan"
            '
            'SubtitleLabel
            '
            Me.SubtitleLabel.AutoSize = True
            Me.SubtitleLabel.Font = New System.Drawing.Font("Segoe UI", 9.5F)
            Me.SubtitleLabel.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128)
            Me.SubtitleLabel.Location = New System.Drawing.Point(0, 37)
            Me.SubtitleLabel.Margin = New System.Windows.Forms.Padding(0)
            Me.SubtitleLabel.Name = "SubtitleLabel"
            Me.SubtitleLabel.Size = New System.Drawing.Size(496, 17)
            Me.SubtitleLabel.TabIndex = 1
            Me.SubtitleLabel.Text = "Kelola daftar kontak anggota dan tempat/lokasi kegiatan yang sering digunakan."
            '
            'BtnReload
            '
            Me.BtnReload.Anchor = System.Windows.Forms.AnchorStyles.Right
            Me.BtnReload.AutoSize = True
            Me.BtnReload.BackColor = System.Drawing.Color.White
            Me.BtnReload.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnReload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 231, 235)
            Me.BtnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnReload.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.BtnReload.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.BtnReload.Location = New System.Drawing.Point(789, 15)
            Me.BtnReload.Margin = New System.Windows.Forms.Padding(0)
            Me.BtnReload.Name = "BtnReload"
            Me.BtnReload.Size = New System.Drawing.Size(113, 38)
            Me.BtnReload.TabIndex = 1
            Me.BtnReload.Text = "Muat Ulang"
            Me.BtnReload.UseVisualStyleBackColor = False
            '
            'TabsControl
            '
            Me.TabsControl.Controls.Add(Me.PeopleTab)
            Me.TabsControl.Controls.Add(Me.PlacesTab)
            Me.TabsControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabsControl.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.TabsControl.Location = New System.Drawing.Point(24, 88)
            Me.TabsControl.Margin = New System.Windows.Forms.Padding(0)
            Me.TabsControl.Name = "TabsControl"
            Me.TabsControl.SelectedIndex = 0
            Me.TabsControl.Size = New System.Drawing.Size(902, 542)
            Me.TabsControl.TabIndex = 1
            '
            'PeopleTab
            '
            Me.PeopleTab.BackColor = System.Drawing.Color.FromArgb(246, 248, 246)
            Me.PeopleTab.Controls.Add(Me.PeopleLayout)
            Me.PeopleTab.Location = New System.Drawing.Point(4, 26)
            Me.PeopleTab.Name = "PeopleTab"
            Me.PeopleTab.Padding = New System.Windows.Forms.Padding(12)
            Me.PeopleTab.Size = New System.Drawing.Size(894, 512)
            Me.PeopleTab.TabIndex = 0
            Me.PeopleTab.Text = "Teman"
            '
            'PeopleLayout
            '
            Me.PeopleLayout.ColumnCount = 2
            Me.PeopleLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.0F))
            Me.PeopleLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.0F))
            Me.PeopleLayout.Controls.Add(Me.PeopleSearchSide, 0, 0)
            Me.PeopleLayout.Controls.Add(Me.PeopleEditorCard, 1, 0)
            Me.PeopleLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PeopleLayout.Location = New System.Drawing.Point(12, 12)
            Me.PeopleLayout.Name = "PeopleLayout"
            Me.PeopleLayout.RowCount = 1
            Me.PeopleLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.PeopleLayout.Size = New System.Drawing.Size(870, 488)
            Me.PeopleLayout.TabIndex = 0
            '
            'PeopleSearchSide
            '
            Me.PeopleSearchSide.ColumnCount = 1
            Me.PeopleSearchSide.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.PeopleSearchSide.Controls.Add(Me.PeopleSearchText, 0, 0)
            Me.PeopleSearchSide.Controls.Add(Me.PeopleList, 0, 1)
            Me.PeopleSearchSide.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PeopleSearchSide.Location = New System.Drawing.Point(0, 0)
            Me.PeopleSearchSide.Margin = New System.Windows.Forms.Padding(0, 0, 12, 0)
            Me.PeopleSearchSide.Name = "PeopleSearchSide"
            Me.PeopleSearchSide.RowCount = 2
            Me.PeopleSearchSide.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0F))
            Me.PeopleSearchSide.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.PeopleSearchSide.Size = New System.Drawing.Size(379, 488)
            Me.PeopleSearchSide.TabIndex = 0
            '
            'PeopleSearchText
            '
            Me.PeopleSearchText.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PeopleSearchText.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.PeopleSearchText.Location = New System.Drawing.Point(0, 0)
            Me.PeopleSearchText.Margin = New System.Windows.Forms.Padding(0, 0, 0, 8)
            Me.PeopleSearchText.Name = "PeopleSearchText"
            Me.PeopleSearchText.PlaceholderText = "Cari nama teman..."
            Me.PeopleSearchText.Size = New System.Drawing.Size(379, 25)
            Me.PeopleSearchText.TabIndex = 0
            '
            'PeopleList
            '
            Me.PeopleList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PeopleList.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PeopleList.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.PeopleList.IntegralHeight = False
            Me.PeopleList.ItemHeight = 17
            Me.PeopleList.Location = New System.Drawing.Point(0, 38)
            Me.PeopleList.Margin = New System.Windows.Forms.Padding(0)
            Me.PeopleList.Name = "PeopleList"
            Me.PeopleList.Size = New System.Drawing.Size(379, 450)
            Me.PeopleList.TabIndex = 1
            '
            'PeopleEditorCard
            '
            Me.PeopleEditorCard.BackColor = System.Drawing.Color.White
            Me.PeopleEditorCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PeopleEditorCard.Controls.Add(Me.PeopleEditorFlow)
            Me.PeopleEditorCard.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PeopleEditorCard.Location = New System.Drawing.Point(403, 0)
            Me.PeopleEditorCard.Margin = New System.Windows.Forms.Padding(12, 0, 0, 0)
            Me.PeopleEditorCard.Name = "PeopleEditorCard"
            Me.PeopleEditorCard.Padding = New System.Windows.Forms.Padding(20)
            Me.PeopleEditorCard.Size = New System.Drawing.Size(467, 488)
            Me.PeopleEditorCard.TabIndex = 1
            '
            'PeopleEditorFlow
            '
            Me.PeopleEditorFlow.Controls.Add(Me.PeopleNameLabel)
            Me.PeopleEditorFlow.Controls.Add(Me.PeopleNameText)
            Me.PeopleEditorFlow.Controls.Add(Me.PeopleNoteLabel)
            Me.PeopleEditorFlow.Controls.Add(Me.PeopleNoteText)
            Me.PeopleEditorFlow.Controls.Add(Me.PeopleButtonsFlow)
            Me.PeopleEditorFlow.Controls.Add(Me.PeopleStatusLabel)
            Me.PeopleEditorFlow.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PeopleEditorFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
            Me.PeopleEditorFlow.Location = New System.Drawing.Point(20, 20)
            Me.PeopleEditorFlow.Name = "PeopleEditorFlow"
            Me.PeopleEditorFlow.Size = New System.Drawing.Size(425, 446)
            Me.PeopleEditorFlow.TabIndex = 0
            Me.PeopleEditorFlow.WrapContents = False
            '
            'PeopleNameLabel
            '
            Me.PeopleNameLabel.AutoSize = True
            Me.PeopleNameLabel.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.PeopleNameLabel.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.PeopleNameLabel.Location = New System.Drawing.Point(0, 0)
            Me.PeopleNameLabel.Margin = New System.Windows.Forms.Padding(0, 0, 0, 4)
            Me.PeopleNameLabel.Name = "PeopleNameLabel"
            Me.PeopleNameLabel.Size = New System.Drawing.Size(78, 15)
            Me.PeopleNameLabel.TabIndex = 0
            Me.PeopleNameLabel.Text = "Nama Teman"
            '
            'PeopleNameText
            '
            Me.PeopleNameText.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.PeopleNameText.Location = New System.Drawing.Point(0, 19)
            Me.PeopleNameText.Margin = New System.Windows.Forms.Padding(0, 0, 0, 12)
            Me.PeopleNameText.Name = "PeopleNameText"
            Me.PeopleNameText.Size = New System.Drawing.Size(410, 25)
            Me.PeopleNameText.TabIndex = 1
            '
            'PeopleNoteLabel
            '
            Me.PeopleNoteLabel.AutoSize = True
            Me.PeopleNoteLabel.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.PeopleNoteLabel.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.PeopleNoteLabel.Location = New System.Drawing.Point(0, 56)
            Me.PeopleNoteLabel.Margin = New System.Windows.Forms.Padding(0, 0, 0, 4)
            Me.PeopleNoteLabel.Name = "PeopleNoteLabel"
            Me.PeopleNoteLabel.Size = New System.Drawing.Size(234, 15)
            Me.PeopleNoteLabel.TabIndex = 2
            Me.PeopleNoteLabel.Text = "Catatan Teman (Nomor HP, Panggilan, dll)"
            '
            'PeopleNoteText
            '
            Me.PeopleNoteText.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.PeopleNoteText.Location = New System.Drawing.Point(0, 75)
            Me.PeopleNoteText.Margin = New System.Windows.Forms.Padding(0, 0, 0, 16)
            Me.PeopleNoteText.Multiline = True
            Me.PeopleNoteText.Name = "PeopleNoteText"
            Me.PeopleNoteText.Size = New System.Drawing.Size(410, 100)
            Me.PeopleNoteText.TabIndex = 3
            '
            'PeopleButtonsFlow
            '
            Me.PeopleButtonsFlow.Controls.Add(Me.BtnSavePerson)
            Me.PeopleButtonsFlow.Controls.Add(Me.BtnDeletePerson)
            Me.PeopleButtonsFlow.Controls.Add(Me.BtnClearPerson)
            Me.PeopleButtonsFlow.Location = New System.Drawing.Point(0, 191)
            Me.PeopleButtonsFlow.Margin = New System.Windows.Forms.Padding(0)
            Me.PeopleButtonsFlow.Name = "PeopleButtonsFlow"
            Me.PeopleButtonsFlow.Size = New System.Drawing.Size(410, 44)
            Me.PeopleButtonsFlow.TabIndex = 4
            '
            'BtnSavePerson
            '
            Me.BtnSavePerson.AutoSize = True
            Me.BtnSavePerson.BackColor = System.Drawing.Color.FromArgb(47, 107, 79)
            Me.BtnSavePerson.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnSavePerson.FlatAppearance.BorderSize = 0
            Me.BtnSavePerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnSavePerson.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.BtnSavePerson.ForeColor = System.Drawing.Color.White
            Me.BtnSavePerson.Location = New System.Drawing.Point(0, 0)
            Me.BtnSavePerson.Margin = New System.Windows.Forms.Padding(0, 0, 8, 0)
            Me.BtnSavePerson.Name = "BtnSavePerson"
            Me.BtnSavePerson.Size = New System.Drawing.Size(100, 38)
            Me.BtnSavePerson.TabIndex = 0
            Me.BtnSavePerson.Text = "Simpan"
            Me.BtnSavePerson.UseVisualStyleBackColor = False
            '
            'BtnDeletePerson
            '
            Me.BtnDeletePerson.AutoSize = True
            Me.BtnDeletePerson.BackColor = System.Drawing.Color.White
            Me.BtnDeletePerson.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnDeletePerson.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 231, 235)
            Me.BtnDeletePerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnDeletePerson.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.BtnDeletePerson.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.BtnDeletePerson.Location = New System.Drawing.Point(108, 0)
            Me.BtnDeletePerson.Margin = New System.Windows.Forms.Padding(0, 0, 8, 0)
            Me.BtnDeletePerson.Name = "BtnDeletePerson"
            Me.BtnDeletePerson.Size = New System.Drawing.Size(100, 38)
            Me.BtnDeletePerson.TabIndex = 1
            Me.BtnDeletePerson.Text = "Hapus"
            Me.BtnDeletePerson.UseVisualStyleBackColor = False
            '
            'BtnClearPerson
            '
            Me.BtnClearPerson.AutoSize = True
            Me.BtnClearPerson.BackColor = System.Drawing.Color.White
            Me.BtnClearPerson.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnClearPerson.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 231, 235)
            Me.BtnClearPerson.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnClearPerson.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.BtnClearPerson.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.BtnClearPerson.Location = New System.Drawing.Point(216, 0)
            Me.BtnClearPerson.Margin = New System.Windows.Forms.Padding(0)
            Me.BtnClearPerson.Name = "BtnClearPerson"
            Me.BtnClearPerson.Size = New System.Drawing.Size(100, 38)
            Me.BtnClearPerson.TabIndex = 2
            Me.BtnClearPerson.Text = "Baru"
            Me.BtnClearPerson.UseVisualStyleBackColor = False
            '
            'PeopleStatusLabel
            '
            Me.PeopleStatusLabel.AutoSize = True
            Me.PeopleStatusLabel.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128)
            Me.PeopleStatusLabel.Location = New System.Drawing.Point(0, 243)
            Me.PeopleStatusLabel.Margin = New System.Windows.Forms.Padding(0, 8, 0, 0)
            Me.PeopleStatusLabel.MaximumSize = New System.Drawing.Size(410, 0)
            Me.PeopleStatusLabel.Name = "PeopleStatusLabel"
            Me.PeopleStatusLabel.Size = New System.Drawing.Size(0, 15)
            Me.PeopleStatusLabel.TabIndex = 5
            '
            'PlacesTab
            '
            Me.PlacesTab.BackColor = System.Drawing.Color.FromArgb(246, 248, 246)
            Me.PlacesTab.Controls.Add(Me.PlacesLayout)
            Me.PlacesTab.Location = New System.Drawing.Point(4, 26)
            Me.PlacesTab.Name = "PlacesTab"
            Me.PlacesTab.Padding = New System.Windows.Forms.Padding(12)
            Me.PlacesTab.Size = New System.Drawing.Size(894, 512)
            Me.PlacesTab.TabIndex = 1
            Me.PlacesTab.Text = "Tempat"
            '
            'PlacesLayout
            '
            Me.PlacesLayout.ColumnCount = 2
            Me.PlacesLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.0F))
            Me.PlacesLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.0F))
            Me.PlacesLayout.Controls.Add(Me.PlacesSearchSide, 0, 0)
            Me.PlacesLayout.Controls.Add(Me.PlacesEditorCard, 1, 0)
            Me.PlacesLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PlacesLayout.Location = New System.Drawing.Point(12, 12)
            Me.PlacesLayout.Name = "PlacesLayout"
            Me.PlacesLayout.RowCount = 1
            Me.PlacesLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.PlacesLayout.Size = New System.Drawing.Size(870, 488)
            Me.PlacesLayout.TabIndex = 0
            '
            'PlacesSearchSide
            '
            Me.PlacesSearchSide.ColumnCount = 1
            Me.PlacesSearchSide.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.PlacesSearchSide.Controls.Add(Me.PlacesSearchText, 0, 0)
            Me.PlacesSearchSide.Controls.Add(Me.PlacesList, 0, 1)
            Me.PlacesSearchSide.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PlacesSearchSide.Location = New System.Drawing.Point(0, 0)
            Me.PlacesSearchSide.Margin = New System.Windows.Forms.Padding(0, 0, 12, 0)
            Me.PlacesSearchSide.Name = "PlacesSearchSide"
            Me.PlacesSearchSide.RowCount = 2
            Me.PlacesSearchSide.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38.0F))
            Me.PlacesSearchSide.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.PlacesSearchSide.Size = New System.Drawing.Size(379, 488)
            Me.PlacesSearchSide.TabIndex = 0
            '
            'PlacesSearchText
            '
            Me.PlacesSearchText.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PlacesSearchText.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.PlacesSearchText.Location = New System.Drawing.Point(0, 0)
            Me.PlacesSearchText.Margin = New System.Windows.Forms.Padding(0, 0, 0, 8)
            Me.PlacesSearchText.Name = "PlacesSearchText"
            Me.PlacesSearchText.PlaceholderText = "Cari tempat..."
            Me.PlacesSearchText.Size = New System.Drawing.Size(379, 25)
            Me.PlacesSearchText.TabIndex = 0
            '
            'PlacesList
            '
            Me.PlacesList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PlacesList.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PlacesList.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.PlacesList.IntegralHeight = False
            Me.PlacesList.ItemHeight = 17
            Me.PlacesList.Location = New System.Drawing.Point(0, 38)
            Me.PlacesList.Margin = New System.Windows.Forms.Padding(0)
            Me.PlacesList.Name = "PlacesList"
            Me.PlacesList.Size = New System.Drawing.Size(379, 450)
            Me.PlacesList.TabIndex = 1
            '
            'PlacesEditorCard
            '
            Me.PlacesEditorCard.BackColor = System.Drawing.Color.White
            Me.PlacesEditorCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.PlacesEditorCard.Controls.Add(Me.PlacesEditorFlow)
            Me.PlacesEditorCard.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PlacesEditorCard.Location = New System.Drawing.Point(403, 0)
            Me.PlacesEditorCard.Margin = New System.Windows.Forms.Padding(12, 0, 0, 0)
            Me.PlacesEditorCard.Name = "PlacesEditorCard"
            Me.PlacesEditorCard.Padding = New System.Windows.Forms.Padding(20)
            Me.PlacesEditorCard.Size = New System.Drawing.Size(467, 488)
            Me.PlacesEditorCard.TabIndex = 1
            '
            'PlacesEditorFlow
            '
            Me.PlacesEditorFlow.Controls.Add(Me.PlacesNameLabel)
            Me.PlacesEditorFlow.Controls.Add(Me.PlacesNameText)
            Me.PlacesEditorFlow.Controls.Add(Me.PlacesCategoryLabel)
            Me.PlacesEditorFlow.Controls.Add(Me.PlacesCategoryText)
            Me.PlacesEditorFlow.Controls.Add(Me.PlacesAddressLabel)
            Me.PlacesEditorFlow.Controls.Add(Me.PlacesAddressText)
            Me.PlacesEditorFlow.Controls.Add(Me.PlacesButtonsFlow)
            Me.PlacesEditorFlow.Controls.Add(Me.PlacesStatusLabel)
            Me.PlacesEditorFlow.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PlacesEditorFlow.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
            Me.PlacesEditorFlow.Location = New System.Drawing.Point(20, 20)
            Me.PlacesEditorFlow.Name = "PlacesEditorFlow"
            Me.PlacesEditorFlow.Size = New System.Drawing.Size(425, 446)
            Me.PlacesEditorFlow.TabIndex = 0
            Me.PlacesEditorFlow.WrapContents = False
            '
            'PlacesNameLabel
            '
            Me.PlacesNameLabel.AutoSize = True
            Me.PlacesNameLabel.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.PlacesNameLabel.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.PlacesNameLabel.Location = New System.Drawing.Point(0, 0)
            Me.PlacesNameLabel.Margin = New System.Windows.Forms.Padding(0, 0, 0, 4)
            Me.PlacesNameLabel.Name = "PlacesNameLabel"
            Me.PlacesNameLabel.Size = New System.Drawing.Size(86, 15)
            Me.PlacesNameLabel.TabIndex = 0
            Me.PlacesNameLabel.Text = "Nama Tempat"
            '
            'PlacesNameText
            '
            Me.PlacesNameText.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.PlacesNameText.Location = New System.Drawing.Point(0, 19)
            Me.PlacesNameText.Margin = New System.Windows.Forms.Padding(0, 0, 0, 12)
            Me.PlacesNameText.Name = "PlacesNameText"
            Me.PlacesNameText.Size = New System.Drawing.Size(410, 25)
            Me.PlacesNameText.TabIndex = 1
            '
            'PlacesCategoryLabel
            '
            Me.PlacesCategoryLabel.AutoSize = True
            Me.PlacesCategoryLabel.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.PlacesCategoryLabel.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.PlacesCategoryLabel.Location = New System.Drawing.Point(0, 56)
            Me.PlacesCategoryLabel.Margin = New System.Windows.Forms.Padding(0, 0, 0, 4)
            Me.PlacesCategoryLabel.Name = "PlacesCategoryLabel"
            Me.PlacesCategoryLabel.Size = New System.Drawing.Size(100, 15)
            Me.PlacesCategoryLabel.TabIndex = 2
            Me.PlacesCategoryLabel.Text = "Kategori / Jenis"
            '
            'PlacesCategoryText
            '
            Me.PlacesCategoryText.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.PlacesCategoryText.Location = New System.Drawing.Point(0, 75)
            Me.PlacesCategoryText.Margin = New System.Windows.Forms.Padding(0, 0, 0, 12)
            Me.PlacesCategoryText.Name = "PlacesCategoryText"
            Me.PlacesCategoryText.Size = New System.Drawing.Size(410, 25)
            Me.PlacesCategoryText.TabIndex = 3
            '
            'PlacesAddressLabel
            '
            Me.PlacesAddressLabel.AutoSize = True
            Me.PlacesAddressLabel.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.PlacesAddressLabel.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.PlacesAddressLabel.Location = New System.Drawing.Point(0, 112)
            Me.PlacesAddressLabel.Margin = New System.Windows.Forms.Padding(0, 0, 0, 4)
            Me.PlacesAddressLabel.Name = "PlacesAddressLabel"
            Me.PlacesAddressLabel.Size = New System.Drawing.Size(102, 15)
            Me.PlacesAddressLabel.TabIndex = 4
            Me.PlacesAddressLabel.Text = "Alamat / Lokasi"
            '
            'PlacesAddressText
            '
            Me.PlacesAddressText.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.PlacesAddressText.Location = New System.Drawing.Point(0, 131)
            Me.PlacesAddressText.Margin = New System.Windows.Forms.Padding(0, 0, 0, 16)
            Me.PlacesAddressText.Multiline = True
            Me.PlacesAddressText.Name = "PlacesAddressText"
            Me.PlacesAddressText.Size = New System.Drawing.Size(410, 80)
            Me.PlacesAddressText.TabIndex = 5
            '
            'PlacesButtonsFlow
            '
            Me.PlacesButtonsFlow.Controls.Add(Me.BtnSavePlace)
            Me.PlacesButtonsFlow.Controls.Add(Me.BtnDeletePlace)
            Me.PlacesButtonsFlow.Controls.Add(Me.BtnClearPlace)
            Me.PlacesButtonsFlow.Location = New System.Drawing.Point(0, 227)
            Me.PlacesButtonsFlow.Margin = New System.Windows.Forms.Padding(0)
            Me.PlacesButtonsFlow.Name = "PlacesButtonsFlow"
            Me.PlacesButtonsFlow.Size = New System.Drawing.Size(410, 44)
            Me.PlacesButtonsFlow.TabIndex = 6
            '
            'BtnSavePlace
            '
            Me.BtnSavePlace.AutoSize = True
            Me.BtnSavePlace.BackColor = System.Drawing.Color.FromArgb(47, 107, 79)
            Me.BtnSavePlace.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnSavePlace.FlatAppearance.BorderSize = 0
            Me.BtnSavePlace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnSavePlace.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.BtnSavePlace.ForeColor = System.Drawing.Color.White
            Me.BtnSavePlace.Location = New System.Drawing.Point(0, 0)
            Me.BtnSavePlace.Margin = New System.Windows.Forms.Padding(0, 0, 8, 0)
            Me.BtnSavePlace.Name = "BtnSavePlace"
            Me.BtnSavePlace.Size = New System.Drawing.Size(100, 38)
            Me.BtnSavePlace.TabIndex = 0
            Me.BtnSavePlace.Text = "Simpan"
            Me.BtnSavePlace.UseVisualStyleBackColor = False
            '
            'BtnDeletePlace
            '
            Me.BtnDeletePlace.AutoSize = True
            Me.BtnDeletePlace.BackColor = System.Drawing.Color.White
            Me.BtnDeletePlace.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnDeletePlace.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 231, 235)
            Me.BtnDeletePlace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnDeletePlace.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.BtnDeletePlace.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.BtnDeletePlace.Location = New System.Drawing.Point(108, 0)
            Me.BtnDeletePlace.Margin = New System.Windows.Forms.Padding(0, 0, 8, 0)
            Me.BtnDeletePlace.Name = "BtnDeletePlace"
            Me.BtnDeletePlace.Size = New System.Drawing.Size(100, 38)
            Me.BtnDeletePlace.TabIndex = 1
            Me.BtnDeletePlace.Text = "Hapus"
            Me.BtnDeletePlace.UseVisualStyleBackColor = False
            '
            'BtnClearPlace
            '
            Me.BtnClearPlace.AutoSize = True
            Me.BtnClearPlace.BackColor = System.Drawing.Color.White
            Me.BtnClearPlace.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnClearPlace.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 231, 235)
            Me.BtnClearPlace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnClearPlace.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.BtnClearPlace.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.BtnClearPlace.Location = New System.Drawing.Point(216, 0)
            Me.BtnClearPlace.Margin = New System.Windows.Forms.Padding(0)
            Me.BtnClearPlace.Name = "BtnClearPlace"
            Me.BtnClearPlace.Size = New System.Drawing.Size(100, 38)
            Me.BtnClearPlace.TabIndex = 2
            Me.BtnClearPlace.Text = "Baru"
            Me.BtnClearPlace.UseVisualStyleBackColor = False
            '
            'PlacesStatusLabel
            '
            Me.PlacesStatusLabel.AutoSize = True
            Me.PlacesStatusLabel.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128)
            Me.PlacesStatusLabel.Location = New System.Drawing.Point(0, 279)
            Me.PlacesStatusLabel.Margin = New System.Windows.Forms.Padding(0, 8, 0, 0)
            Me.PlacesStatusLabel.MaximumSize = New System.Drawing.Size(410, 0)
            Me.PlacesStatusLabel.Name = "PlacesStatusLabel"
            Me.PlacesStatusLabel.Size = New System.Drawing.Size(0, 15)
            Me.PlacesStatusLabel.TabIndex = 7
            '
            'OwnerDataPage
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(246, 248, 246)
            Me.Controls.Add(Me.RootLayout)
            Me.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.Name = "OwnerDataPage"
            Me.Size = New System.Drawing.Size(950, 650)
            Me.RootLayout.ResumeLayout(False)
            Me.HeaderLayout.ResumeLayout(False)
            Me.TitleStack.ResumeLayout(False)
            Me.TitleStack.PerformLayout()
            Me.TabsControl.ResumeLayout(False)
            Me.PeopleTab.ResumeLayout(False)
            Me.PeopleLayout.ResumeLayout(False)
            Me.PeopleSearchSide.ResumeLayout(False)
            Me.PeopleSearchSide.PerformLayout()
            Me.PeopleEditorCard.ResumeLayout(False)
            Me.PeopleEditorFlow.ResumeLayout(False)
            Me.PeopleEditorFlow.PerformLayout()
            Me.PeopleButtonsFlow.ResumeLayout(False)
            Me.PeopleButtonsFlow.PerformLayout()
            Me.PlacesTab.ResumeLayout(False)
            Me.PlacesLayout.ResumeLayout(False)
            Me.PlacesSearchSide.ResumeLayout(False)
            Me.PlacesSearchSide.PerformLayout()
            Me.PlacesEditorCard.ResumeLayout(False)
            Me.PlacesEditorFlow.ResumeLayout(False)
            Me.PlacesEditorFlow.PerformLayout()
            Me.PlacesButtonsFlow.ResumeLayout(False)
            Me.PlacesButtonsFlow.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents RootLayout As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents HeaderLayout As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents TitleStack As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents TitleLabel As System.Windows.Forms.Label
        Friend WithEvents SubtitleLabel As System.Windows.Forms.Label
        Friend WithEvents BtnReload As System.Windows.Forms.Button
        Friend WithEvents TabsControl As System.Windows.Forms.TabControl
        Friend WithEvents PeopleTab As System.Windows.Forms.TabPage
        Friend WithEvents PeopleLayout As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents PeopleSearchSide As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents PeopleSearchText As System.Windows.Forms.TextBox
        Friend WithEvents PeopleList As System.Windows.Forms.ListBox
        Friend WithEvents PeopleEditorCard As System.Windows.Forms.Panel
        Friend WithEvents PeopleEditorFlow As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents PeopleNameLabel As System.Windows.Forms.Label
        Friend WithEvents PeopleNameText As System.Windows.Forms.TextBox
        Friend WithEvents PeopleNoteLabel As System.Windows.Forms.Label
        Friend WithEvents PeopleNoteText As System.Windows.Forms.TextBox
        Friend WithEvents PeopleButtonsFlow As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents BtnSavePerson As System.Windows.Forms.Button
        Friend WithEvents BtnDeletePerson As System.Windows.Forms.Button
        Friend WithEvents BtnClearPerson As System.Windows.Forms.Button
        Friend WithEvents PeopleStatusLabel As System.Windows.Forms.Label
        Friend WithEvents PlacesTab As System.Windows.Forms.TabPage
        Friend WithEvents PlacesLayout As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents PlacesSearchSide As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents PlacesSearchText As System.Windows.Forms.TextBox
        Friend WithEvents PlacesList As System.Windows.Forms.ListBox
        Friend WithEvents PlacesEditorCard As System.Windows.Forms.Panel
        Friend WithEvents PlacesEditorFlow As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents PlacesNameLabel As System.Windows.Forms.Label
        Friend WithEvents PlacesNameText As System.Windows.Forms.TextBox
        Friend WithEvents PlacesCategoryLabel As System.Windows.Forms.Label
        Friend WithEvents PlacesCategoryText As System.Windows.Forms.TextBox
        Friend WithEvents PlacesAddressLabel As System.Windows.Forms.Label
        Friend WithEvents PlacesAddressText As System.Windows.Forms.TextBox
        Friend WithEvents PlacesButtonsFlow As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents BtnSavePlace As System.Windows.Forms.Button
        Friend WithEvents BtnDeletePlace As System.Windows.Forms.Button
        Friend WithEvents BtnClearPlace As System.Windows.Forms.Button
        Friend WithEvents PlacesStatusLabel As System.Windows.Forms.Label
    End Class
End Namespace
