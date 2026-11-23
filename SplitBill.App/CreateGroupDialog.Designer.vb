Namespace Global.SplitBill.App
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class CreateGroupDialog
        Inherits System.Windows.Forms.Form

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

        Private components As System.ComponentModel.IContainer

        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.MainPanel = New System.Windows.Forms.Panel()
            Me.LblHeader = New System.Windows.Forms.Label()
            Me.LblSubheader = New System.Windows.Forms.Label()
            Me.LblGroupName = New System.Windows.Forms.Label()
            Me.TxtGroupName = New System.Windows.Forms.TextBox()
            Me.LblType = New System.Windows.Forms.Label()
            Me.CmbType = New System.Windows.Forms.ComboBox()
            Me.LblDate = New System.Windows.Forms.Label()
            Me.DtEvent = New System.Windows.Forms.DateTimePicker()
            Me.LblPlace = New System.Windows.Forms.Label()
            Me.TxtPlace = New System.Windows.Forms.TextBox()
            Me.LblOwnerName = New System.Windows.Forms.Label()
            Me.TxtOwnerName = New System.Windows.Forms.TextBox()
            Me.LblInitialMembers = New System.Windows.Forms.Label()
            Me.TxtInitialMembers = New System.Windows.Forms.TextBox()
            Me.LblValidation = New System.Windows.Forms.Label()
            Me.BtnCreate = New System.Windows.Forms.Button()
            Me.BtnCancel = New System.Windows.Forms.Button()
            Me.MainPanel.SuspendLayout()
            Me.SuspendLayout()
            '
            'MainPanel
            '
            Me.MainPanel.AutoScroll = True
            Me.MainPanel.BackColor = System.Drawing.Color.White
            Me.MainPanel.Controls.Add(Me.LblHeader)
            Me.MainPanel.Controls.Add(Me.LblSubheader)
            Me.MainPanel.Controls.Add(Me.LblGroupName)
            Me.MainPanel.Controls.Add(Me.TxtGroupName)
            Me.MainPanel.Controls.Add(Me.LblType)
            Me.MainPanel.Controls.Add(Me.CmbType)
            Me.MainPanel.Controls.Add(Me.LblDate)
            Me.MainPanel.Controls.Add(Me.DtEvent)
            Me.MainPanel.Controls.Add(Me.LblPlace)
            Me.MainPanel.Controls.Add(Me.TxtPlace)
            Me.MainPanel.Controls.Add(Me.LblOwnerName)
            Me.MainPanel.Controls.Add(Me.TxtOwnerName)
            Me.MainPanel.Controls.Add(Me.LblInitialMembers)
            Me.MainPanel.Controls.Add(Me.TxtInitialMembers)
            Me.MainPanel.Controls.Add(Me.LblValidation)
            Me.MainPanel.Controls.Add(Me.BtnCreate)
            Me.MainPanel.Controls.Add(Me.BtnCancel)
            Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MainPanel.Location = New System.Drawing.Point(0, 0)
            Me.MainPanel.Name = "MainPanel"
            Me.MainPanel.Padding = New System.Windows.Forms.Padding(26)
            Me.MainPanel.Size = New System.Drawing.Size(520, 560)
            Me.MainPanel.TabIndex = 0
            '
            'LblHeader
            '
            Me.LblHeader.AutoSize = True
            Me.LblHeader.Font = New System.Drawing.Font("Segoe UI", 16.0F, System.Drawing.FontStyle.Bold)
            Me.LblHeader.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39)
            Me.LblHeader.Location = New System.Drawing.Point(24, 20)
            Me.LblHeader.Name = "LblHeader"
            Me.LblHeader.Size = New System.Drawing.Size(248, 30)
            Me.LblHeader.TabIndex = 0
            Me.LblHeader.Text = "Buat Grup / Kegiatan"
            '
            'LblSubheader
            '
            Me.LblSubheader.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.LblSubheader.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128)
            Me.LblSubheader.Location = New System.Drawing.Point(26, 52)
            Me.LblSubheader.Name = "LblSubheader"
            Me.LblSubheader.Size = New System.Drawing.Size(460, 24)
            Me.LblSubheader.TabIndex = 1
            Me.LblSubheader.Text = "Buat grup untuk mencatat pengeluaran bersama dan dapatkan kode undangan."
            '
            'LblGroupName
            '
            Me.LblGroupName.AutoSize = True
            Me.LblGroupName.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.LblGroupName.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81)
            Me.LblGroupName.Location = New System.Drawing.Point(26, 82)
            Me.LblGroupName.Name = "LblGroupName"
            Me.LblGroupName.Size = New System.Drawing.Size(126, 15)
            Me.LblGroupName.TabIndex = 2
            Me.LblGroupName.Text = "Nama Grup / Kegiatan *"
            '
            'TxtGroupName
            '
            Me.TxtGroupName.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.TxtGroupName.Location = New System.Drawing.Point(28, 102)
            Me.TxtGroupName.MaxLength = 100
            Me.TxtGroupName.Name = "TxtGroupName"
            Me.TxtGroupName.PlaceholderText = "Contoh: Nongkrong di Cafe Senja, Trip ke Bali"
            Me.TxtGroupName.Size = New System.Drawing.Size(460, 25)
            Me.TxtGroupName.TabIndex = 3
            '
            'LblType
            '
            Me.LblType.AutoSize = True
            Me.LblType.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.LblType.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81)
            Me.LblType.Location = New System.Drawing.Point(26, 138)
            Me.LblType.Name = "LblType"
            Me.LblType.Size = New System.Drawing.Size(89, 15)
            Me.LblType.TabIndex = 4
            Me.LblType.Text = "Jenis Kegiatan"
            '
            'CmbType
            '
            Me.CmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.CmbType.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.CmbType.FormattingEnabled = True
            Me.CmbType.Location = New System.Drawing.Point(28, 158)
            Me.CmbType.Name = "CmbType"
            Me.CmbType.Size = New System.Drawing.Size(460, 25)
            Me.CmbType.TabIndex = 5
            '
            'LblDate
            '
            Me.LblDate.AutoSize = True
            Me.LblDate.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.LblDate.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81)
            Me.LblDate.Location = New System.Drawing.Point(26, 194)
            Me.LblDate.Name = "LblDate"
            Me.LblDate.Size = New System.Drawing.Size(51, 15)
            Me.LblDate.TabIndex = 6
            Me.LblDate.Text = "Tanggal"
            '
            'DtEvent
            '
            Me.DtEvent.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.DtEvent.Format = System.Windows.Forms.DateTimePickerFormat.Long
            Me.DtEvent.Location = New System.Drawing.Point(28, 214)
            Me.DtEvent.Name = "DtEvent"
            Me.DtEvent.Size = New System.Drawing.Size(460, 25)
            Me.DtEvent.TabIndex = 7
            '
            'LblPlace
            '
            Me.LblPlace.AutoSize = True
            Me.LblPlace.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.LblPlace.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81)
            Me.LblPlace.Location = New System.Drawing.Point(26, 250)
            Me.LblPlace.Name = "LblPlace"
            Me.LblPlace.Size = New System.Drawing.Size(135, 15)
            Me.LblPlace.TabIndex = 8
            Me.LblPlace.Text = "Tempat / Lokasi (Opsional)"
            '
            'TxtPlace
            '
            Me.TxtPlace.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.TxtPlace.Location = New System.Drawing.Point(28, 270)
            Me.TxtPlace.MaxLength = 100
            Me.TxtPlace.Name = "TxtPlace"
            Me.TxtPlace.PlaceholderText = "Contoh: Cafe Senja, Apartemen ABC, Bandung"
            Me.TxtPlace.Size = New System.Drawing.Size(460, 25)
            Me.TxtPlace.TabIndex = 9
            '
            'LblOwnerName
            '
            Me.LblOwnerName.AutoSize = True
            Me.LblOwnerName.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.LblOwnerName.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81)
            Me.LblOwnerName.Location = New System.Drawing.Point(26, 306)
            Me.LblOwnerName.Name = "LblOwnerName"
            Me.LblOwnerName.Size = New System.Drawing.Size(126, 15)
            Me.LblOwnerName.TabIndex = 10
            Me.LblOwnerName.Text = "Nama Anda di Grup *"
            '
            'TxtOwnerName
            '
            Me.TxtOwnerName.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.TxtOwnerName.Location = New System.Drawing.Point(28, 326)
            Me.TxtOwnerName.MaxLength = 50
            Me.TxtOwnerName.Name = "TxtOwnerName"
            Me.TxtOwnerName.PlaceholderText = "Nama Anda sebagai pemilik grup"
            Me.TxtOwnerName.Size = New System.Drawing.Size(460, 25)
            Me.TxtOwnerName.TabIndex = 11
            '
            'LblInitialMembers
            '
            Me.LblInitialMembers.AutoSize = True
            Me.LblInitialMembers.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.LblInitialMembers.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81)
            Me.LblInitialMembers.Location = New System.Drawing.Point(26, 362)
            Me.LblInitialMembers.Name = "LblInitialMembers"
            Me.LblInitialMembers.Size = New System.Drawing.Size(262, 15)
            Me.LblInitialMembers.TabIndex = 12
            Me.LblInitialMembers.Text = "Anggota Awal (Opsional, pisahkan tanda koma)"
            '
            'TxtInitialMembers
            '
            Me.TxtInitialMembers.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.TxtInitialMembers.Location = New System.Drawing.Point(28, 382)
            Me.TxtInitialMembers.MaxLength = 200
            Me.TxtInitialMembers.Name = "TxtInitialMembers"
            Me.TxtInitialMembers.PlaceholderText = "Contoh: Budi, Citra, Doni"
            Me.TxtInitialMembers.Size = New System.Drawing.Size(460, 25)
            Me.TxtInitialMembers.TabIndex = 13
            '
            'LblValidation
            '
            Me.LblValidation.AutoSize = True
            Me.LblValidation.Font = New System.Drawing.Font("Segoe UI", 8.5F)
            Me.LblValidation.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38)
            Me.LblValidation.Location = New System.Drawing.Point(26, 420)
            Me.LblValidation.Name = "LblValidation"
            Me.LblValidation.Size = New System.Drawing.Size(0, 15)
            Me.LblValidation.TabIndex = 14
            '
            'BtnCreate
            '
            Me.BtnCreate.BackColor = System.Drawing.Color.FromArgb(35, 122, 72)
            Me.BtnCreate.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnCreate.FlatAppearance.BorderSize = 0
            Me.BtnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnCreate.Font = New System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold)
            Me.BtnCreate.ForeColor = System.Drawing.Color.White
            Me.BtnCreate.Location = New System.Drawing.Point(338, 460)
            Me.BtnCreate.Name = "BtnCreate"
            Me.BtnCreate.Size = New System.Drawing.Size(150, 42)
            Me.BtnCreate.TabIndex = 15
            Me.BtnCreate.Text = "Buat Grup"
            Me.BtnCreate.UseVisualStyleBackColor = False
            '
            'BtnCancel
            '
            Me.BtnCancel.BackColor = System.Drawing.Color.White
            Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.BtnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 231, 235)
            Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnCancel.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.BtnCancel.ForeColor = System.Drawing.Color.FromArgb(75, 85, 99)
            Me.BtnCancel.Location = New System.Drawing.Point(228, 460)
            Me.BtnCancel.Name = "BtnCancel"
            Me.BtnCancel.Size = New System.Drawing.Size(100, 42)
            Me.BtnCancel.TabIndex = 16
            Me.BtnCancel.Text = "Batal"
            Me.BtnCancel.UseVisualStyleBackColor = False
            '
            'CreateGroupDialog
            '
            Me.AcceptButton = Me.BtnCreate
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.BtnCancel
            Me.ClientSize = New System.Drawing.Size(520, 530)
            Me.Controls.Add(Me.MainPanel)
            Me.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "CreateGroupDialog"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Buat Grup Baru"
            Me.MainPanel.ResumeLayout(False)
            Me.MainPanel.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents MainPanel As System.Windows.Forms.Panel
        Friend WithEvents LblHeader As System.Windows.Forms.Label
        Friend WithEvents LblSubheader As System.Windows.Forms.Label
        Friend WithEvents LblGroupName As System.Windows.Forms.Label
        Friend WithEvents TxtGroupName As System.Windows.Forms.TextBox
        Friend WithEvents LblType As System.Windows.Forms.Label
        Friend WithEvents CmbType As System.Windows.Forms.ComboBox
        Friend WithEvents LblDate As System.Windows.Forms.Label
        Friend WithEvents DtEvent As System.Windows.Forms.DateTimePicker
        Friend WithEvents LblPlace As System.Windows.Forms.Label
        Friend WithEvents TxtPlace As System.Windows.Forms.TextBox
        Friend WithEvents LblOwnerName As System.Windows.Forms.Label
        Friend WithEvents TxtOwnerName As System.Windows.Forms.TextBox
        Friend WithEvents LblInitialMembers As System.Windows.Forms.Label
        Friend WithEvents TxtInitialMembers As System.Windows.Forms.TextBox
        Friend WithEvents LblValidation As System.Windows.Forms.Label
        Friend WithEvents BtnCreate As System.Windows.Forms.Button
        Friend WithEvents BtnCancel As System.Windows.Forms.Button
    End Class
End Namespace

