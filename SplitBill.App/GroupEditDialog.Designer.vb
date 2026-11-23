Namespace Global.SplitBill.App
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class GroupEditDialog
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
            Me.MainLayout = New System.Windows.Forms.TableLayoutPanel()
            Me.LblName = New System.Windows.Forms.Label()
            Me.TxtName = New System.Windows.Forms.TextBox()
            Me.LblDate = New System.Windows.Forms.Label()
            Me.DtDate = New System.Windows.Forms.DateTimePicker()
            Me.LblPlace = New System.Windows.Forms.Label()
            Me.CmbPlace = New System.Windows.Forms.ComboBox()
            Me.ActionPanel = New System.Windows.Forms.FlowLayoutPanel()
            Me.BtnSave = New System.Windows.Forms.Button()
            Me.BtnCancel = New System.Windows.Forms.Button()
            Me.MainLayout.SuspendLayout()
            Me.ActionPanel.SuspendLayout()
            Me.SuspendLayout()
            '
            'MainLayout
            '
            Me.MainLayout.ColumnCount = 2
            Me.MainLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0F))
            Me.MainLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.MainLayout.Controls.Add(Me.LblName, 0, 0)
            Me.MainLayout.Controls.Add(Me.TxtName, 1, 0)
            Me.MainLayout.Controls.Add(Me.LblDate, 0, 1)
            Me.MainLayout.Controls.Add(Me.DtDate, 1, 1)
            Me.MainLayout.Controls.Add(Me.LblPlace, 0, 2)
            Me.MainLayout.Controls.Add(Me.CmbPlace, 1, 2)
            Me.MainLayout.Controls.Add(Me.ActionPanel, 1, 3)
            Me.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MainLayout.Location = New System.Drawing.Point(0, 0)
            Me.MainLayout.Name = "MainLayout"
            Me.MainLayout.Padding = New System.Windows.Forms.Padding(20)
            Me.MainLayout.RowCount = 4
            Me.MainLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52.0F))
            Me.MainLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52.0F))
            Me.MainLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52.0F))
            Me.MainLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.MainLayout.Size = New System.Drawing.Size(560, 260)
            Me.MainLayout.TabIndex = 0
            '
            'LblName
            '
            Me.LblName.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LblName.Font = New System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold)
            Me.LblName.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39)
            Me.LblName.Location = New System.Drawing.Point(23, 20)
            Me.LblName.Name = "LblName"
            Me.LblName.Size = New System.Drawing.Size(114, 52)
            Me.LblName.TabIndex = 0
            Me.LblName.Text = "Nama"
            Me.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'TxtName
            '
            Me.TxtName.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TxtName.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.TxtName.Location = New System.Drawing.Point(143, 28)
            Me.TxtName.Margin = New System.Windows.Forms.Padding(3, 8, 3, 8)
            Me.TxtName.Name = "TxtName"
            Me.TxtName.Size = New System.Drawing.Size(394, 25)
            Me.TxtName.TabIndex = 1
            '
            'LblDate
            '
            Me.LblDate.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LblDate.Font = New System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold)
            Me.LblDate.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39)
            Me.LblDate.Location = New System.Drawing.Point(23, 72)
            Me.LblDate.Name = "LblDate"
            Me.LblDate.Size = New System.Drawing.Size(114, 52)
            Me.LblDate.TabIndex = 2
            Me.LblDate.Text = "Tanggal"
            Me.LblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'DtDate
            '
            Me.DtDate.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.DtDate.Format = System.Windows.Forms.DateTimePickerFormat.Long
            Me.DtDate.Location = New System.Drawing.Point(143, 80)
            Me.DtDate.Margin = New System.Windows.Forms.Padding(3, 8, 3, 8)
            Me.DtDate.Name = "DtDate"
            Me.DtDate.Size = New System.Drawing.Size(260, 25)
            Me.DtDate.TabIndex = 3
            '
            'LblPlace
            '
            Me.LblPlace.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LblPlace.Font = New System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold)
            Me.LblPlace.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39)
            Me.LblPlace.Location = New System.Drawing.Point(23, 124)
            Me.LblPlace.Name = "LblPlace"
            Me.LblPlace.Size = New System.Drawing.Size(114, 52)
            Me.LblPlace.TabIndex = 4
            Me.LblPlace.Text = "Tempat"
            Me.LblPlace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'CmbPlace
            '
            Me.CmbPlace.Dock = System.Windows.Forms.DockStyle.Fill
            Me.CmbPlace.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.CmbPlace.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.CmbPlace.FormattingEnabled = True
            Me.CmbPlace.Location = New System.Drawing.Point(143, 132)
            Me.CmbPlace.Margin = New System.Windows.Forms.Padding(3, 8, 3, 8)
            Me.CmbPlace.Name = "CmbPlace"
            Me.CmbPlace.Size = New System.Drawing.Size(394, 25)
            Me.CmbPlace.TabIndex = 5
            '
            'ActionPanel
            '
            Me.ActionPanel.Controls.Add(Me.BtnSave)
            Me.ActionPanel.Controls.Add(Me.BtnCancel)
            Me.ActionPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ActionPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
            Me.ActionPanel.Location = New System.Drawing.Point(143, 179)
            Me.ActionPanel.Name = "ActionPanel"
            Me.ActionPanel.Size = New System.Drawing.Size(394, 58)
            Me.ActionPanel.TabIndex = 6
            '
            'BtnSave
            '
            Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(22, 101, 52)
            Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnSave.FlatAppearance.BorderSize = 0
            Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnSave.Font = New System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold)
            Me.BtnSave.ForeColor = System.Drawing.Color.White
            Me.BtnSave.Location = New System.Drawing.Point(284, 10)
            Me.BtnSave.Margin = New System.Windows.Forms.Padding(10, 10, 0, 0)
            Me.BtnSave.Name = "BtnSave"
            Me.BtnSave.Size = New System.Drawing.Size(110, 38)
            Me.BtnSave.TabIndex = 0
            Me.BtnSave.Text = "Simpan"
            Me.BtnSave.UseVisualStyleBackColor = False
            '
            'BtnCancel
            '
            Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnCancel.Font = New System.Drawing.Font("Segoe UI", 9.5F)
            Me.BtnCancel.Location = New System.Drawing.Point(164, 10)
            Me.BtnCancel.Margin = New System.Windows.Forms.Padding(0, 10, 0, 0)
            Me.BtnCancel.Name = "BtnCancel"
            Me.BtnCancel.Size = New System.Drawing.Size(110, 38)
            Me.BtnCancel.TabIndex = 1
            Me.BtnCancel.Text = "Batal"
            Me.BtnCancel.UseVisualStyleBackColor = True
            '
            'GroupEditDialog
            '
            Me.AcceptButton = Me.BtnSave
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
            Me.BackColor = System.Drawing.Color.FromArgb(246, 248, 246)
            Me.CancelButton = Me.BtnCancel
            Me.ClientSize = New System.Drawing.Size(560, 260)
            Me.Controls.Add(Me.MainLayout)
            Me.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "GroupEditDialog"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Ubah Kegiatan"
            Me.MainLayout.ResumeLayout(False)
            Me.MainLayout.PerformLayout()
            Me.ActionPanel.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents MainLayout As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents LblName As System.Windows.Forms.Label
        Friend WithEvents TxtName As System.Windows.Forms.TextBox
        Friend WithEvents LblDate As System.Windows.Forms.Label
        Friend WithEvents DtDate As System.Windows.Forms.DateTimePicker
        Friend WithEvents LblPlace As System.Windows.Forms.Label
        Friend WithEvents CmbPlace As System.Windows.Forms.ComboBox
        Friend WithEvents ActionPanel As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents BtnSave As System.Windows.Forms.Button
        Friend WithEvents BtnCancel As System.Windows.Forms.Button
    End Class
End Namespace

