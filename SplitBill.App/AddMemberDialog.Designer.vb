Namespace Global.SplitBill.App
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class AddMemberDialog
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
            Me.LblName = New System.Windows.Forms.Label()
            Me.TxtName = New System.Windows.Forms.TextBox()
            Me.LblOrSelect = New System.Windows.Forms.Label()
            Me.CmbExistingPeople = New System.Windows.Forms.ComboBox()
            Me.LblValidation = New System.Windows.Forms.Label()
            Me.BtnAdd = New System.Windows.Forms.Button()
            Me.BtnCancel = New System.Windows.Forms.Button()
            Me.MainPanel.SuspendLayout()
            Me.SuspendLayout()
            '
            'MainPanel
            '
            Me.MainPanel.BackColor = System.Drawing.Color.White
            Me.MainPanel.Controls.Add(Me.LblHeader)
            Me.MainPanel.Controls.Add(Me.LblSubheader)
            Me.MainPanel.Controls.Add(Me.LblName)
            Me.MainPanel.Controls.Add(Me.TxtName)
            Me.MainPanel.Controls.Add(Me.LblOrSelect)
            Me.MainPanel.Controls.Add(Me.CmbExistingPeople)
            Me.MainPanel.Controls.Add(Me.LblValidation)
            Me.MainPanel.Controls.Add(Me.BtnAdd)
            Me.MainPanel.Controls.Add(Me.BtnCancel)
            Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MainPanel.Location = New System.Drawing.Point(0, 0)
            Me.MainPanel.Name = "MainPanel"
            Me.MainPanel.Padding = New System.Windows.Forms.Padding(26)
            Me.MainPanel.Size = New System.Drawing.Size(460, 360)
            Me.MainPanel.TabIndex = 0
            '
            'LblHeader
            '
            Me.LblHeader.AutoSize = True
            Me.LblHeader.Font = New System.Drawing.Font("Segoe UI", 16.0F, System.Drawing.FontStyle.Bold)
            Me.LblHeader.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39)
            Me.LblHeader.Location = New System.Drawing.Point(24, 22)
            Me.LblHeader.Name = "LblHeader"
            Me.LblHeader.Size = New System.Drawing.Size(290, 30)
            Me.LblHeader.TabIndex = 0
            Me.LblHeader.Text = "Tambah Teman ke Kegiatan"
            '
            'LblSubheader
            '
            Me.LblSubheader.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.LblSubheader.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128)
            Me.LblSubheader.Location = New System.Drawing.Point(26, 56)
            Me.LblSubheader.Name = "LblSubheader"
            Me.LblSubheader.Size = New System.Drawing.Size(400, 36)
            Me.LblSubheader.TabIndex = 1
            Me.LblSubheader.Text = "Pilih teman dari daftar Anda atau ketik nama teman baru untuk langsung ditambahkan."
            '
            'LblName
            '
            Me.LblName.AutoSize = True
            Me.LblName.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.LblName.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81)
            Me.LblName.Location = New System.Drawing.Point(26, 102)
            Me.LblName.Name = "LblName"
            Me.LblName.Size = New System.Drawing.Size(126, 15)
            Me.LblName.TabIndex = 2
            Me.LblName.Text = "Nama Teman Baru *"
            '
            'TxtName
            '
            Me.TxtName.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.TxtName.Location = New System.Drawing.Point(28, 124)
            Me.TxtName.MaxLength = 50
            Me.TxtName.Name = "TxtName"
            Me.TxtName.PlaceholderText = "Contoh: Budi, Citra, Doni"
            Me.TxtName.Size = New System.Drawing.Size(400, 25)
            Me.TxtName.TabIndex = 3
            '
            'LblOrSelect
            '
            Me.LblOrSelect.AutoSize = True
            Me.LblOrSelect.Font = New System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic)
            Me.LblOrSelect.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128)
            Me.LblOrSelect.Location = New System.Drawing.Point(26, 166)
            Me.LblOrSelect.Name = "LblOrSelect"
            Me.LblOrSelect.Size = New System.Drawing.Size(200, 15)
            Me.LblOrSelect.TabIndex = 4
            Me.LblOrSelect.Text = "Atau pilih langsung dari Daftar Teman:"
            '
            'CmbExistingPeople
            '
            Me.CmbExistingPeople.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.CmbExistingPeople.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.CmbExistingPeople.FormattingEnabled = True
            Me.CmbExistingPeople.Location = New System.Drawing.Point(28, 186)
            Me.CmbExistingPeople.Name = "CmbExistingPeople"
            Me.CmbExistingPeople.Size = New System.Drawing.Size(400, 25)
            Me.CmbExistingPeople.TabIndex = 5
            '
            'LblValidation
            '
            Me.LblValidation.AutoSize = True
            Me.LblValidation.Font = New System.Drawing.Font("Segoe UI", 8.5F)
            Me.LblValidation.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38)
            Me.LblValidation.Location = New System.Drawing.Point(26, 226)
            Me.LblValidation.Name = "LblValidation"
            Me.LblValidation.Size = New System.Drawing.Size(0, 15)
            Me.LblValidation.TabIndex = 6
            '
            'BtnAdd
            '
            Me.BtnAdd.BackColor = System.Drawing.Color.FromArgb(35, 122, 72)
            Me.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnAdd.FlatAppearance.BorderSize = 0
            Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnAdd.Font = New System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold)
            Me.BtnAdd.ForeColor = System.Drawing.Color.White
            Me.BtnAdd.Location = New System.Drawing.Point(278, 276)
            Me.BtnAdd.Name = "BtnAdd"
            Me.BtnAdd.Size = New System.Drawing.Size(150, 40)
            Me.BtnAdd.TabIndex = 7
            Me.BtnAdd.Text = "＋ Tambah Teman"
            Me.BtnAdd.UseVisualStyleBackColor = False
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
            Me.BtnCancel.Location = New System.Drawing.Point(168, 276)
            Me.BtnCancel.Name = "BtnCancel"
            Me.BtnCancel.Size = New System.Drawing.Size(100, 40)
            Me.BtnCancel.TabIndex = 8
            Me.BtnCancel.Text = "Batal"
            Me.BtnCancel.UseVisualStyleBackColor = False
            '
            'AddMemberDialog
            '
            Me.AcceptButton = Me.BtnAdd
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.BtnCancel
            Me.ClientSize = New System.Drawing.Size(460, 360)
            Me.Controls.Add(Me.MainPanel)
            Me.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "AddMemberDialog"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Tambah Anggota"
            Me.MainPanel.ResumeLayout(False)
            Me.MainPanel.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents MainPanel As System.Windows.Forms.Panel
        Friend WithEvents LblHeader As System.Windows.Forms.Label
        Friend WithEvents LblSubheader As System.Windows.Forms.Label
        Friend WithEvents LblName As System.Windows.Forms.Label
        Friend WithEvents TxtName As System.Windows.Forms.TextBox
        Friend WithEvents LblOrSelect As System.Windows.Forms.Label
        Friend WithEvents CmbExistingPeople As System.Windows.Forms.ComboBox
        Friend WithEvents LblValidation As System.Windows.Forms.Label
        Friend WithEvents BtnAdd As System.Windows.Forms.Button
        Friend WithEvents BtnCancel As System.Windows.Forms.Button
    End Class
End Namespace

