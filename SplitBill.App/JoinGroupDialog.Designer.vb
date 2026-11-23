Namespace Global.SplitBill.App
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class JoinGroupDialog
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
            Me.LblHeader = New System.Windows.Forms.Label()
            Me.LblSubheader = New System.Windows.Forms.Label()
            Me.LblCode = New System.Windows.Forms.Label()
            Me.TxtCode = New System.Windows.Forms.TextBox()
            Me.LblName = New System.Windows.Forms.Label()
            Me.TxtName = New System.Windows.Forms.TextBox()
            Me.LblValidation = New System.Windows.Forms.Label()
            Me.BtnJoin = New System.Windows.Forms.Button()
            Me.BtnCancel = New System.Windows.Forms.Button()
            Me.MainPanel = New System.Windows.Forms.Panel()
            Me.MainPanel.SuspendLayout()
            Me.SuspendLayout()
            '
            'MainPanel
            '
            Me.MainPanel.BackColor = System.Drawing.Color.White
            Me.MainPanel.Controls.Add(Me.LblHeader)
            Me.MainPanel.Controls.Add(Me.LblSubheader)
            Me.MainPanel.Controls.Add(Me.LblCode)
            Me.MainPanel.Controls.Add(Me.TxtCode)
            Me.MainPanel.Controls.Add(Me.LblName)
            Me.MainPanel.Controls.Add(Me.TxtName)
            Me.MainPanel.Controls.Add(Me.LblValidation)
            Me.MainPanel.Controls.Add(Me.BtnJoin)
            Me.MainPanel.Controls.Add(Me.BtnCancel)
            Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MainPanel.Location = New System.Drawing.Point(0, 0)
            Me.MainPanel.Name = "MainPanel"
            Me.MainPanel.Padding = New System.Windows.Forms.Padding(28)
            Me.MainPanel.Size = New System.Drawing.Size(460, 360)
            Me.MainPanel.TabIndex = 0
            '
            'LblHeader
            '
            Me.LblHeader.AutoSize = True
            Me.LblHeader.Font = New System.Drawing.Font("Segoe UI", 16.0F, System.Drawing.FontStyle.Bold)
            Me.LblHeader.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39)
            Me.LblHeader.Location = New System.Drawing.Point(26, 24)
            Me.LblHeader.Name = "LblHeader"
            Me.LblHeader.Size = New System.Drawing.Size(262, 30)
            Me.LblHeader.TabIndex = 0
            Me.LblHeader.Text = "Gabung ke Kegiatan / Grup"
            '
            'LblSubheader
            '
            Me.LblSubheader.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.LblSubheader.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128)
            Me.LblSubheader.Location = New System.Drawing.Point(28, 58)
            Me.LblSubheader.Name = "LblSubheader"
            Me.LblSubheader.Size = New System.Drawing.Size(400, 34)
            Me.LblSubheader.TabIndex = 1
            Me.LblSubheader.Text = "Mintalah kode undangan 8 digit kepada pemilik grup, lalu masukkan di bawah ini (s" &
    "eperti Google Classroom)."
            '
            'LblCode
            '
            Me.LblCode.AutoSize = True
            Me.LblCode.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.LblCode.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81)
            Me.LblCode.Location = New System.Drawing.Point(28, 102)
            Me.LblCode.Name = "LblCode"
            Me.LblCode.Size = New System.Drawing.Size(89, 15)
            Me.LblCode.TabIndex = 2
            Me.LblCode.Text = "Kode Undangan"
            '
            'TxtCode
            '
            Me.TxtCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
            Me.TxtCode.Font = New System.Drawing.Font("Segoe UI", 12.0F, System.Drawing.FontStyle.Bold)
            Me.TxtCode.Location = New System.Drawing.Point(30, 122)
            Me.TxtCode.MaxLength = 10
            Me.TxtCode.Name = "TxtCode"
            Me.TxtCode.PlaceholderText = "Contoh: ABC12345"
            Me.TxtCode.Size = New System.Drawing.Size(400, 29)
            Me.TxtCode.TabIndex = 3
            '
            'LblName
            '
            Me.LblName.AutoSize = True
            Me.LblName.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.LblName.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81)
            Me.LblName.Location = New System.Drawing.Point(28, 164)
            Me.LblName.Name = "LblName"
            Me.LblName.Size = New System.Drawing.Size(126, 15)
            Me.LblName.TabIndex = 4
            Me.LblName.Text = "Nama Anda di Grup Ini"
            '
            'TxtName
            '
            Me.TxtName.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.TxtName.Location = New System.Drawing.Point(30, 184)
            Me.TxtName.MaxLength = 50
            Me.TxtName.Name = "TxtName"
            Me.TxtName.PlaceholderText = "Contoh: Alv"
            Me.TxtName.Size = New System.Drawing.Size(400, 25)
            Me.TxtName.TabIndex = 5
            '
            'LblValidation
            '
            Me.LblValidation.AutoSize = True
            Me.LblValidation.Font = New System.Drawing.Font("Segoe UI", 8.5F)
            Me.LblValidation.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38)
            Me.LblValidation.Location = New System.Drawing.Point(28, 222)
            Me.LblValidation.Name = "LblValidation"
            Me.LblValidation.Size = New System.Drawing.Size(0, 15)
            Me.LblValidation.TabIndex = 6
            '
            'BtnJoin
            '
            Me.BtnJoin.BackColor = System.Drawing.Color.FromArgb(35, 122, 72)
            Me.BtnJoin.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnJoin.FlatAppearance.BorderSize = 0
            Me.BtnJoin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnJoin.Font = New System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold)
            Me.BtnJoin.ForeColor = System.Drawing.Color.White
            Me.BtnJoin.Location = New System.Drawing.Point(280, 270)
            Me.BtnJoin.Name = "BtnJoin"
            Me.BtnJoin.Size = New System.Drawing.Size(150, 40)
            Me.BtnJoin.TabIndex = 7
            Me.BtnJoin.Text = "Gabung Sekarang"
            Me.BtnJoin.UseVisualStyleBackColor = False
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
            Me.BtnCancel.Location = New System.Drawing.Point(170, 270)
            Me.BtnCancel.Name = "BtnCancel"
            Me.BtnCancel.Size = New System.Drawing.Size(100, 40)
            Me.BtnCancel.TabIndex = 8
            Me.BtnCancel.Text = "Batal"
            Me.BtnCancel.UseVisualStyleBackColor = False
            '
            'JoinGroupDialog
            '
            Me.AcceptButton = Me.BtnJoin
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.CancelButton = Me.BtnCancel
            Me.ClientSize = New System.Drawing.Size(460, 360)
            Me.Controls.Add(Me.MainPanel)
            Me.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "JoinGroupDialog"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Gabung ke Grup"
            Me.MainPanel.ResumeLayout(False)
            Me.MainPanel.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents MainPanel As System.Windows.Forms.Panel
        Friend WithEvents LblHeader As System.Windows.Forms.Label
        Friend WithEvents LblSubheader As System.Windows.Forms.Label
        Friend WithEvents LblCode As System.Windows.Forms.Label
        Friend WithEvents TxtCode As System.Windows.Forms.TextBox
        Friend WithEvents LblName As System.Windows.Forms.Label
        Friend WithEvents TxtName As System.Windows.Forms.TextBox
        Friend WithEvents LblValidation As System.Windows.Forms.Label
        Friend WithEvents BtnJoin As System.Windows.Forms.Button
        Friend WithEvents BtnCancel As System.Windows.Forms.Button
    End Class
End Namespace

