Namespace Global.SplitBill.App
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class ExpenseCreateDialog
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
            Me.DialogLayout = New System.Windows.Forms.TableLayoutPanel()
            Me.NameLabel = New System.Windows.Forms.Label()
            Me.NameTextBox = New System.Windows.Forms.TextBox()
            Me.DateLabel = New System.Windows.Forms.Label()
            Me.DatePicker = New System.Windows.Forms.DateTimePicker()
            Me.TotalLabel = New System.Windows.Forms.Label()
            Me.TotalNumeric = New System.Windows.Forms.NumericUpDown()
            Me.PayerLabel = New System.Windows.Forms.Label()
            Me.PayerComboBox = New System.Windows.Forms.ComboBox()
            Me.MethodLabel = New System.Windows.Forms.Label()
            Me.MethodComboBox = New System.Windows.Forms.ComboBox()
            Me.NoteLabel = New System.Windows.Forms.Label()
            Me.NoteTextBox = New System.Windows.Forms.TextBox()
            Me.MembersLabel = New System.Windows.Forms.Label()
            Me.MembersPanel = New System.Windows.Forms.Panel()
            Me.EqualCheckList = New System.Windows.Forms.CheckedListBox()
            Me.ActionsPanel = New System.Windows.Forms.FlowLayoutPanel()
            Me.BtnSave = New System.Windows.Forms.Button()
            Me.BtnCancel = New System.Windows.Forms.Button()
            Me.DialogLayout.SuspendLayout()
            CType(Me.TotalNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.MembersPanel.SuspendLayout()
            Me.ActionsPanel.SuspendLayout()
            Me.SuspendLayout()
            '
            'DialogLayout
            '
            Me.DialogLayout.ColumnCount = 2
            Me.DialogLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0F))
            Me.DialogLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.DialogLayout.Controls.Add(Me.NameLabel, 0, 0)
            Me.DialogLayout.Controls.Add(Me.NameTextBox, 1, 0)
            Me.DialogLayout.Controls.Add(Me.DateLabel, 0, 1)
            Me.DialogLayout.Controls.Add(Me.DatePicker, 1, 1)
            Me.DialogLayout.Controls.Add(Me.TotalLabel, 0, 2)
            Me.DialogLayout.Controls.Add(Me.TotalNumeric, 1, 2)
            Me.DialogLayout.Controls.Add(Me.PayerLabel, 0, 3)
            Me.DialogLayout.Controls.Add(Me.PayerComboBox, 1, 3)
            Me.DialogLayout.Controls.Add(Me.MethodLabel, 0, 4)
            Me.DialogLayout.Controls.Add(Me.MethodComboBox, 1, 4)
            Me.DialogLayout.Controls.Add(Me.NoteLabel, 0, 5)
            Me.DialogLayout.Controls.Add(Me.NoteTextBox, 1, 5)
            Me.DialogLayout.Controls.Add(Me.MembersLabel, 0, 6)
            Me.DialogLayout.Controls.Add(Me.MembersPanel, 1, 6)
            Me.DialogLayout.Controls.Add(Me.ActionsPanel, 1, 7)
            Me.DialogLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.DialogLayout.Location = New System.Drawing.Point(0, 0)
            Me.DialogLayout.Name = "DialogLayout"
            Me.DialogLayout.Padding = New System.Windows.Forms.Padding(20)
            Me.DialogLayout.RowCount = 8
            Me.DialogLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0F))
            Me.DialogLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0F))
            Me.DialogLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0F))
            Me.DialogLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0F))
            Me.DialogLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0F))
            Me.DialogLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0F))
            Me.DialogLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.DialogLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0F))
            Me.DialogLayout.Size = New System.Drawing.Size(620, 560)
            Me.DialogLayout.TabIndex = 0
            '
            'NameLabel
            '
            Me.NameLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.NameLabel.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.NameLabel.Location = New System.Drawing.Point(20, 20)
            Me.NameLabel.Name = "NameLabel"
            Me.NameLabel.Size = New System.Drawing.Size(144, 44)
            Me.NameLabel.TabIndex = 0
            Me.NameLabel.Text = "Nama Pengeluaran"
            Me.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'NameTextBox
            '
            Me.NameTextBox.Dock = System.Windows.Forms.DockStyle.Fill
            Me.NameTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.NameTextBox.Location = New System.Drawing.Point(167, 24)
            Me.NameTextBox.Margin = New System.Windows.Forms.Padding(0, 4, 0, 4)
            Me.NameTextBox.Name = "NameTextBox"
            Me.NameTextBox.PlaceholderText = "Contoh: Makan Malam, Tiket Masuk, Bensin"
            Me.NameTextBox.Size = New System.Drawing.Size(433, 25)
            Me.NameTextBox.TabIndex = 1
            '
            'DateLabel
            '
            Me.DateLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.DateLabel.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.DateLabel.Location = New System.Drawing.Point(20, 64)
            Me.DateLabel.Name = "DateLabel"
            Me.DateLabel.Size = New System.Drawing.Size(144, 44)
            Me.DateLabel.TabIndex = 2
            Me.DateLabel.Text = "Tanggal"
            Me.DateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'DatePicker
            '
            Me.DatePicker.Dock = System.Windows.Forms.DockStyle.Left
            Me.DatePicker.Font = New System.Drawing.Font("Segoe UI", 9.5F)
            Me.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.DatePicker.Location = New System.Drawing.Point(167, 68)
            Me.DatePicker.Margin = New System.Windows.Forms.Padding(0, 4, 0, 4)
            Me.DatePicker.Name = "DatePicker"
            Me.DatePicker.Size = New System.Drawing.Size(150, 24)
            Me.DatePicker.TabIndex = 3
            '
            'TotalLabel
            '
            Me.TotalLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TotalLabel.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.TotalLabel.Location = New System.Drawing.Point(20, 108)
            Me.TotalLabel.Name = "TotalLabel"
            Me.TotalLabel.Size = New System.Drawing.Size(144, 44)
            Me.TotalLabel.TabIndex = 4
            Me.TotalLabel.Text = "Total Struk (Rp)"
            Me.TotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'TotalNumeric
            '
            Me.TotalNumeric.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TotalNumeric.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.TotalNumeric.Location = New System.Drawing.Point(167, 112)
            Me.TotalNumeric.Margin = New System.Windows.Forms.Padding(0, 4, 0, 4)
            Me.TotalNumeric.Maximum = New Decimal(New Integer() {1410065408, 2, 0, 0})
            Me.TotalNumeric.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.TotalNumeric.Name = "TotalNumeric"
            Me.TotalNumeric.Size = New System.Drawing.Size(433, 25)
            Me.TotalNumeric.TabIndex = 5
            Me.TotalNumeric.ThousandsSeparator = True
            Me.TotalNumeric.Value = New Decimal(New Integer() {100000, 0, 0, 0})
            '
            'PayerLabel
            '
            Me.PayerLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PayerLabel.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.PayerLabel.Location = New System.Drawing.Point(20, 152)
            Me.PayerLabel.Name = "PayerLabel"
            Me.PayerLabel.Size = New System.Drawing.Size(144, 44)
            Me.PayerLabel.TabIndex = 6
            Me.PayerLabel.Text = "Dibayar Oleh"
            Me.PayerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'PayerComboBox
            '
            Me.PayerComboBox.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PayerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.PayerComboBox.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.PayerComboBox.Location = New System.Drawing.Point(167, 156)
            Me.PayerComboBox.Margin = New System.Windows.Forms.Padding(0, 4, 0, 4)
            Me.PayerComboBox.Name = "PayerComboBox"
            Me.PayerComboBox.Size = New System.Drawing.Size(433, 25)
            Me.PayerComboBox.TabIndex = 7
            '
            'MethodLabel
            '
            Me.MethodLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MethodLabel.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.MethodLabel.Location = New System.Drawing.Point(20, 196)
            Me.MethodLabel.Name = "MethodLabel"
            Me.MethodLabel.Size = New System.Drawing.Size(144, 44)
            Me.MethodLabel.TabIndex = 8
            Me.MethodLabel.Text = "Metode Pembagian"
            Me.MethodLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'MethodComboBox
            '
            Me.MethodComboBox.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.MethodComboBox.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.MethodComboBox.Location = New System.Drawing.Point(167, 200)
            Me.MethodComboBox.Margin = New System.Windows.Forms.Padding(0, 4, 0, 4)
            Me.MethodComboBox.Name = "MethodComboBox"
            Me.MethodComboBox.Size = New System.Drawing.Size(433, 25)
            Me.MethodComboBox.TabIndex = 9
            '
            'NoteLabel
            '
            Me.NoteLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.NoteLabel.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.NoteLabel.Location = New System.Drawing.Point(20, 240)
            Me.NoteLabel.Name = "NoteLabel"
            Me.NoteLabel.Size = New System.Drawing.Size(144, 44)
            Me.NoteLabel.TabIndex = 10
            Me.NoteLabel.Text = "Catatan"
            Me.NoteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'NoteTextBox
            '
            Me.NoteTextBox.Dock = System.Windows.Forms.DockStyle.Fill
            Me.NoteTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.NoteTextBox.Location = New System.Drawing.Point(167, 244)
            Me.NoteTextBox.Margin = New System.Windows.Forms.Padding(0, 4, 0, 4)
            Me.NoteTextBox.Name = "NoteTextBox"
            Me.NoteTextBox.PlaceholderText = "Opsional: Catatan nota / struk"
            Me.NoteTextBox.Size = New System.Drawing.Size(433, 25)
            Me.NoteTextBox.TabIndex = 11
            '
            'MembersLabel
            '
            Me.MembersLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MembersLabel.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.MembersLabel.Location = New System.Drawing.Point(20, 284)
            Me.MembersLabel.Name = "MembersLabel"
            Me.MembersLabel.Size = New System.Drawing.Size(144, 208)
            Me.MembersLabel.TabIndex = 12
            Me.MembersLabel.Text = "Anggota Terkait"
            Me.MembersLabel.TextAlign = System.Drawing.ContentAlignment.TopLeft
            '
            'MembersPanel
            '
            Me.MembersPanel.BackColor = System.Drawing.Color.White
            Me.MembersPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.MembersPanel.Controls.Add(Me.EqualCheckList)
            Me.MembersPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MembersPanel.Location = New System.Drawing.Point(167, 288)
            Me.MembersPanel.Margin = New System.Windows.Forms.Padding(0, 4, 0, 4)
            Me.MembersPanel.Name = "MembersPanel"
            Me.MembersPanel.Size = New System.Drawing.Size(433, 200)
            Me.MembersPanel.TabIndex = 13
            '
            'EqualCheckList
            '
            Me.EqualCheckList.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.EqualCheckList.CheckOnClick = True
            Me.EqualCheckList.Dock = System.Windows.Forms.DockStyle.Fill
            Me.EqualCheckList.Font = New System.Drawing.Font("Segoe UI", 9.5F)
            Me.EqualCheckList.Location = New System.Drawing.Point(0, 0)
            Me.EqualCheckList.Name = "EqualCheckList"
            Me.EqualCheckList.Size = New System.Drawing.Size(431, 198)
            Me.EqualCheckList.TabIndex = 0
            '
            'ActionsPanel
            '
            Me.ActionsPanel.Controls.Add(Me.BtnSave)
            Me.ActionsPanel.Controls.Add(Me.BtnCancel)
            Me.ActionsPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ActionsPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
            Me.ActionsPanel.Location = New System.Drawing.Point(167, 492)
            Me.ActionsPanel.Margin = New System.Windows.Forms.Padding(0)
            Me.ActionsPanel.Name = "ActionsPanel"
            Me.ActionsPanel.Size = New System.Drawing.Size(433, 48)
            Me.ActionsPanel.TabIndex = 14
            '
            'BtnSave
            '
            Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(47, 107, 79)
            Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnSave.FlatAppearance.BorderSize = 0
            Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnSave.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.BtnSave.ForeColor = System.Drawing.Color.White
            Me.BtnSave.Location = New System.Drawing.Point(273, 3)
            Me.BtnSave.Name = "BtnSave"
            Me.BtnSave.Size = New System.Drawing.Size(157, 38)
            Me.BtnSave.TabIndex = 0
            Me.BtnSave.Text = "Simpan Pengeluaran"
            Me.BtnSave.UseVisualStyleBackColor = False
            '
            'BtnCancel
            '
            Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnCancel.Location = New System.Drawing.Point(167, 3)
            Me.BtnCancel.Name = "BtnCancel"
            Me.BtnCancel.Size = New System.Drawing.Size(100, 38)
            Me.BtnCancel.TabIndex = 1
            Me.BtnCancel.Text = "Batal"
            Me.BtnCancel.UseVisualStyleBackColor = True
            '
            'ExpenseCreateDialog
            '
            Me.AcceptButton = Me.BtnSave
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(246, 248, 246)
            Me.CancelButton = Me.BtnCancel
            Me.ClientSize = New System.Drawing.Size(620, 560)
            Me.Controls.Add(Me.DialogLayout)
            Me.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "ExpenseCreateDialog"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Tambah Pengeluaran Tagihan"
            Me.DialogLayout.ResumeLayout(False)
            Me.DialogLayout.PerformLayout()
            CType(Me.TotalNumeric, System.ComponentModel.ISupportInitialize).EndInit()
            Me.MembersPanel.ResumeLayout(False)
            Me.ActionsPanel.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents DialogLayout As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents NameLabel As System.Windows.Forms.Label
        Friend WithEvents NameTextBox As System.Windows.Forms.TextBox
        Friend WithEvents DateLabel As System.Windows.Forms.Label
        Friend WithEvents DatePicker As System.Windows.Forms.DateTimePicker
        Friend WithEvents TotalLabel As System.Windows.Forms.Label
        Friend WithEvents TotalNumeric As System.Windows.Forms.NumericUpDown
        Friend WithEvents PayerLabel As System.Windows.Forms.Label
        Friend WithEvents PayerComboBox As System.Windows.Forms.ComboBox
        Friend WithEvents MethodLabel As System.Windows.Forms.Label
        Friend WithEvents MethodComboBox As System.Windows.Forms.ComboBox
        Friend WithEvents NoteLabel As System.Windows.Forms.Label
        Friend WithEvents NoteTextBox As System.Windows.Forms.TextBox
        Friend WithEvents MembersLabel As System.Windows.Forms.Label
        Friend WithEvents MembersPanel As System.Windows.Forms.Panel
        Friend WithEvents EqualCheckList As System.Windows.Forms.CheckedListBox
        Friend WithEvents ActionsPanel As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents BtnSave As System.Windows.Forms.Button
        Friend WithEvents BtnCancel As System.Windows.Forms.Button
    End Class
End Namespace
