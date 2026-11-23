Namespace Global.SplitBill.App
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class OrderSubmitDialog
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
            Me.MemberLabel = New System.Windows.Forms.Label()
            Me.MemberComboBox = New System.Windows.Forms.ComboBox()
            Me.ItemNameLabel = New System.Windows.Forms.Label()
            Me.ItemNameTextBox = New System.Windows.Forms.TextBox()
            Me.UnitPriceLabel = New System.Windows.Forms.Label()
            Me.UnitPriceNumeric = New System.Windows.Forms.NumericUpDown()
            Me.QtyLabel = New System.Windows.Forms.Label()
            Me.QtyNumeric = New System.Windows.Forms.NumericUpDown()
            Me.NoteLabel = New System.Windows.Forms.Label()
            Me.NoteTextBox = New System.Windows.Forms.TextBox()
            Me.ActionsPanel = New System.Windows.Forms.FlowLayoutPanel()
            Me.BtnSave = New System.Windows.Forms.Button()
            Me.BtnCancel = New System.Windows.Forms.Button()
            Me.DialogLayout.SuspendLayout()
            CType(Me.UnitPriceNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.QtyNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.ActionsPanel.SuspendLayout()
            Me.SuspendLayout()
            '
            'DialogLayout
            '
            Me.DialogLayout.ColumnCount = 2
            Me.DialogLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0F))
            Me.DialogLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.DialogLayout.Controls.Add(Me.MemberLabel, 0, 0)
            Me.DialogLayout.Controls.Add(Me.MemberComboBox, 1, 0)
            Me.DialogLayout.Controls.Add(Me.ItemNameLabel, 0, 1)
            Me.DialogLayout.Controls.Add(Me.ItemNameTextBox, 1, 1)
            Me.DialogLayout.Controls.Add(Me.UnitPriceLabel, 0, 2)
            Me.DialogLayout.Controls.Add(Me.UnitPriceNumeric, 1, 2)
            Me.DialogLayout.Controls.Add(Me.QtyLabel, 0, 3)
            Me.DialogLayout.Controls.Add(Me.QtyNumeric, 1, 3)
            Me.DialogLayout.Controls.Add(Me.NoteLabel, 0, 4)
            Me.DialogLayout.Controls.Add(Me.NoteTextBox, 1, 4)
            Me.DialogLayout.Controls.Add(Me.ActionsPanel, 1, 5)
            Me.DialogLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.DialogLayout.Location = New System.Drawing.Point(0, 0)
            Me.DialogLayout.Name = "DialogLayout"
            Me.DialogLayout.Padding = New System.Windows.Forms.Padding(20)
            Me.DialogLayout.RowCount = 6
            Me.DialogLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0F))
            Me.DialogLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0F))
            Me.DialogLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0F))
            Me.DialogLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0F))
            Me.DialogLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0F))
            Me.DialogLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0F))
            Me.DialogLayout.Size = New System.Drawing.Size(500, 320)
            Me.DialogLayout.TabIndex = 0
            '
            'MemberLabel
            '
            Me.MemberLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MemberLabel.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.MemberLabel.Location = New System.Drawing.Point(20, 20)
            Me.MemberLabel.Name = "MemberLabel"
            Me.MemberLabel.Size = New System.Drawing.Size(114, 46)
            Me.MemberLabel.TabIndex = 0
            Me.MemberLabel.Text = "Anggota"
            Me.MemberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'MemberComboBox
            '
            Me.MemberComboBox.Dock = System.Windows.Forms.DockStyle.Fill
            Me.MemberComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.MemberComboBox.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.MemberComboBox.Location = New System.Drawing.Point(137, 24)
            Me.MemberComboBox.Margin = New System.Windows.Forms.Padding(0, 4, 0, 4)
            Me.MemberComboBox.Name = "MemberComboBox"
            Me.MemberComboBox.Size = New System.Drawing.Size(343, 25)
            Me.MemberComboBox.TabIndex = 1
            '
            'ItemNameLabel
            '
            Me.ItemNameLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ItemNameLabel.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.ItemNameLabel.Location = New System.Drawing.Point(20, 66)
            Me.ItemNameLabel.Name = "ItemNameLabel"
            Me.ItemNameLabel.Size = New System.Drawing.Size(114, 46)
            Me.ItemNameLabel.TabIndex = 2
            Me.ItemNameLabel.Text = "Nama Menu"
            Me.ItemNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'ItemNameTextBox
            '
            Me.ItemNameTextBox.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ItemNameTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.ItemNameTextBox.Location = New System.Drawing.Point(137, 70)
            Me.ItemNameTextBox.Margin = New System.Windows.Forms.Padding(0, 4, 0, 4)
            Me.ItemNameTextBox.Name = "ItemNameTextBox"
            Me.ItemNameTextBox.PlaceholderText = "Contoh: Nasi Goreng Spesial"
            Me.ItemNameTextBox.Size = New System.Drawing.Size(343, 25)
            Me.ItemNameTextBox.TabIndex = 3
            '
            'UnitPriceLabel
            '
            Me.UnitPriceLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UnitPriceLabel.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.UnitPriceLabel.Location = New System.Drawing.Point(20, 112)
            Me.UnitPriceLabel.Name = "UnitPriceLabel"
            Me.UnitPriceLabel.Size = New System.Drawing.Size(114, 46)
            Me.UnitPriceLabel.TabIndex = 4
            Me.UnitPriceLabel.Text = "Harga Satuan (Rp)"
            Me.UnitPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'UnitPriceNumeric
            '
            Me.UnitPriceNumeric.Dock = System.Windows.Forms.DockStyle.Fill
            Me.UnitPriceNumeric.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.UnitPriceNumeric.Location = New System.Drawing.Point(137, 116)
            Me.UnitPriceNumeric.Margin = New System.Windows.Forms.Padding(0, 4, 0, 4)
            Me.UnitPriceNumeric.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
            Me.UnitPriceNumeric.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.UnitPriceNumeric.Name = "UnitPriceNumeric"
            Me.UnitPriceNumeric.Size = New System.Drawing.Size(343, 25)
            Me.UnitPriceNumeric.TabIndex = 5
            Me.UnitPriceNumeric.ThousandsSeparator = True
            Me.UnitPriceNumeric.Value = New Decimal(New Integer() {25000, 0, 0, 0})
            '
            'QtyLabel
            '
            Me.QtyLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.QtyLabel.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.QtyLabel.Location = New System.Drawing.Point(20, 158)
            Me.QtyLabel.Name = "QtyLabel"
            Me.QtyLabel.Size = New System.Drawing.Size(114, 46)
            Me.QtyLabel.TabIndex = 6
            Me.QtyLabel.Text = "Jumlah Porsi"
            Me.QtyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'QtyNumeric
            '
            Me.QtyNumeric.Dock = System.Windows.Forms.DockStyle.Fill
            Me.QtyNumeric.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.QtyNumeric.Location = New System.Drawing.Point(137, 162)
            Me.QtyNumeric.Margin = New System.Windows.Forms.Padding(0, 4, 0, 4)
            Me.QtyNumeric.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
            Me.QtyNumeric.Name = "QtyNumeric"
            Me.QtyNumeric.Size = New System.Drawing.Size(343, 25)
            Me.QtyNumeric.TabIndex = 7
            Me.QtyNumeric.Value = New Decimal(New Integer() {1, 0, 0, 0})
            '
            'NoteLabel
            '
            Me.NoteLabel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.NoteLabel.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.NoteLabel.Location = New System.Drawing.Point(20, 204)
            Me.NoteLabel.Name = "NoteLabel"
            Me.NoteLabel.Size = New System.Drawing.Size(114, 46)
            Me.NoteLabel.TabIndex = 8
            Me.NoteLabel.Text = "Catatan"
            Me.NoteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'NoteTextBox
            '
            Me.NoteTextBox.Dock = System.Windows.Forms.DockStyle.Fill
            Me.NoteTextBox.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.NoteTextBox.Location = New System.Drawing.Point(137, 208)
            Me.NoteTextBox.Margin = New System.Windows.Forms.Padding(0, 4, 0, 4)
            Me.NoteTextBox.Name = "NoteTextBox"
            Me.NoteTextBox.PlaceholderText = "Opsional: Tanpa cabai, kuah dipisah"
            Me.NoteTextBox.Size = New System.Drawing.Size(343, 25)
            Me.NoteTextBox.TabIndex = 9
            '
            'ActionsPanel
            '
            Me.ActionsPanel.Controls.Add(Me.BtnSave)
            Me.ActionsPanel.Controls.Add(Me.BtnCancel)
            Me.ActionsPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ActionsPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
            Me.ActionsPanel.Location = New System.Drawing.Point(137, 250)
            Me.ActionsPanel.Margin = New System.Windows.Forms.Padding(0)
            Me.ActionsPanel.Name = "ActionsPanel"
            Me.ActionsPanel.Size = New System.Drawing.Size(343, 50)
            Me.ActionsPanel.TabIndex = 10
            '
            'BtnSave
            '
            Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(47, 107, 79)
            Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnSave.FlatAppearance.BorderSize = 0
            Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnSave.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.BtnSave.ForeColor = System.Drawing.Color.White
            Me.BtnSave.Location = New System.Drawing.Point(223, 3)
            Me.BtnSave.Name = "BtnSave"
            Me.BtnSave.Size = New System.Drawing.Size(117, 38)
            Me.BtnSave.TabIndex = 0
            Me.BtnSave.Text = "Kirim Pesanan"
            Me.BtnSave.UseVisualStyleBackColor = False
            '
            'BtnCancel
            '
            Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnCancel.Location = New System.Drawing.Point(117, 3)
            Me.BtnCancel.Name = "BtnCancel"
            Me.BtnCancel.Size = New System.Drawing.Size(100, 38)
            Me.BtnCancel.TabIndex = 1
            Me.BtnCancel.Text = "Batal"
            Me.BtnCancel.UseVisualStyleBackColor = True
            '
            'OrderSubmitDialog
            '
            Me.AcceptButton = Me.BtnSave
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(246, 248, 246)
            Me.CancelButton = Me.BtnCancel
            Me.ClientSize = New System.Drawing.Size(500, 320)
            Me.Controls.Add(Me.DialogLayout)
            Me.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "OrderSubmitDialog"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Pesan Menu / Porsi"
            Me.DialogLayout.ResumeLayout(False)
            Me.DialogLayout.PerformLayout()
            CType(Me.UnitPriceNumeric, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.QtyNumeric, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ActionsPanel.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents DialogLayout As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents MemberLabel As System.Windows.Forms.Label
        Friend WithEvents MemberComboBox As System.Windows.Forms.ComboBox
        Friend WithEvents ItemNameLabel As System.Windows.Forms.Label
        Friend WithEvents ItemNameTextBox As System.Windows.Forms.TextBox
        Friend WithEvents UnitPriceLabel As System.Windows.Forms.Label
        Friend WithEvents UnitPriceNumeric As System.Windows.Forms.NumericUpDown
        Friend WithEvents QtyLabel As System.Windows.Forms.Label
        Friend WithEvents QtyNumeric As System.Windows.Forms.NumericUpDown
        Friend WithEvents NoteLabel As System.Windows.Forms.Label
        Friend WithEvents NoteTextBox As System.Windows.Forms.TextBox
        Friend WithEvents ActionsPanel As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents BtnSave As System.Windows.Forms.Button
        Friend WithEvents BtnCancel As System.Windows.Forms.Button
    End Class
End Namespace
