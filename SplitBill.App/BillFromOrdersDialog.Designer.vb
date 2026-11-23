Namespace Global.SplitBill.App
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class BillFromOrdersDialog
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
            Me.DialogLayout = New System.Windows.Forms.TableLayoutPanel()
            Me.LblHeader = New System.Windows.Forms.Label()
            Me.LblSubheader = New System.Windows.Forms.Label()
            Me.LblExpenseName = New System.Windows.Forms.Label()
            Me.TxtExpenseName = New System.Windows.Forms.TextBox()
            Me.LblPayer = New System.Windows.Forms.Label()
            Me.CmbPayer = New System.Windows.Forms.ComboBox()
            Me.LblMethod = New System.Windows.Forms.Label()
            Me.CmbMethod = New System.Windows.Forms.ComboBox()
            Me.LblOrders = New System.Windows.Forms.Label()
            Me.LstOrders = New System.Windows.Forms.ListBox()
            Me.LblAdjustment = New System.Windows.Forms.Label()
            Me.NumAdjustment = New System.Windows.Forms.NumericUpDown()
            Me.LblTotal = New System.Windows.Forms.Label()
            Me.LblValidation = New System.Windows.Forms.Label()
            Me.ActionsFlow = New System.Windows.Forms.FlowLayoutPanel()
            Me.BtnSave = New System.Windows.Forms.Button()
            Me.BtnCancel = New System.Windows.Forms.Button()
            Me.DialogLayout.SuspendLayout()
            CType(Me.NumAdjustment, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.ActionsFlow.SuspendLayout()
            Me.SuspendLayout()
            '
            'DialogLayout
            '
            Me.DialogLayout.BackColor = System.Drawing.Color.White
            Me.DialogLayout.ColumnCount = 1
            Me.DialogLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.DialogLayout.Controls.Add(Me.LblHeader, 0, 0)
            Me.DialogLayout.Controls.Add(Me.LblSubheader, 0, 1)
            Me.DialogLayout.Controls.Add(Me.LblExpenseName, 0, 2)
            Me.DialogLayout.Controls.Add(Me.TxtExpenseName, 0, 3)
            Me.DialogLayout.Controls.Add(Me.LblPayer, 0, 4)
            Me.DialogLayout.Controls.Add(Me.CmbPayer, 0, 5)
            Me.DialogLayout.Controls.Add(Me.LblMethod, 0, 6)
            Me.DialogLayout.Controls.Add(Me.CmbMethod, 0, 7)
            Me.DialogLayout.Controls.Add(Me.LblOrders, 0, 8)
            Me.DialogLayout.Controls.Add(Me.LstOrders, 0, 9)
            Me.DialogLayout.Controls.Add(Me.LblAdjustment, 0, 10)
            Me.DialogLayout.Controls.Add(Me.NumAdjustment, 0, 11)
            Me.DialogLayout.Controls.Add(Me.LblTotal, 0, 12)
            Me.DialogLayout.Controls.Add(Me.LblValidation, 0, 13)
            Me.DialogLayout.Controls.Add(Me.ActionsFlow, 0, 14)
            Me.DialogLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.DialogLayout.Location = New System.Drawing.Point(0, 0)
            Me.DialogLayout.Name = "DialogLayout"
            Me.DialogLayout.Padding = New System.Windows.Forms.Padding(20, 16, 20, 14)
            Me.DialogLayout.RowCount = 15
            Me.DialogLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0F))
            Me.DialogLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0F))
            Me.DialogLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0F))
            Me.DialogLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0F))
            Me.DialogLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0F))
            Me.DialogLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0F))
            Me.DialogLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0F))
            Me.DialogLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0F))
            Me.DialogLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0F))
            Me.DialogLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.DialogLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0F))
            Me.DialogLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0F))
            Me.DialogLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0F))
            Me.DialogLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0F))
            Me.DialogLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46.0F))
            Me.DialogLayout.Size = New System.Drawing.Size(560, 660)
            Me.DialogLayout.TabIndex = 0
            '
            'LblHeader
            '
            Me.LblHeader.AutoSize = True
            Me.LblHeader.Font = New System.Drawing.Font("Segoe UI", 14.5F, System.Drawing.FontStyle.Bold)
            Me.LblHeader.ForeColor = System.Drawing.Color.FromArgb(17, 24, 39)
            Me.LblHeader.Location = New System.Drawing.Point(20, 16)
            Me.LblHeader.Margin = New System.Windows.Forms.Padding(0)
            Me.LblHeader.Name = "LblHeader"
            Me.LblHeader.Size = New System.Drawing.Size(286, 28)
            Me.LblHeader.TabIndex = 0
            Me.LblHeader.Text = "Tagih Otomatis dari Pesanan"
            '
            'LblSubheader
            '
            Me.LblSubheader.AutoSize = True
            Me.LblSubheader.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.LblSubheader.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128)
            Me.LblSubheader.Location = New System.Drawing.Point(20, 46)
            Me.LblSubheader.Margin = New System.Windows.Forms.Padding(0)
            Me.LblSubheader.Name = "LblSubheader"
            Me.LblSubheader.Size = New System.Drawing.Size(462, 15)
            Me.LblSubheader.TabIndex = 1
            Me.LblSubheader.Text = "Pesanan menu yang disetujui otomatis dihitung tanpa perlu membuat struk manual."
            '
            'LblExpenseName
            '
            Me.LblExpenseName.AutoSize = True
            Me.LblExpenseName.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.LblExpenseName.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81)
            Me.LblExpenseName.Location = New System.Drawing.Point(20, 72)
            Me.LblExpenseName.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
            Me.LblExpenseName.Name = "LblExpenseName"
            Me.LblExpenseName.Size = New System.Drawing.Size(124, 15)
            Me.LblExpenseName.TabIndex = 2
            Me.LblExpenseName.Text = "Nama Pengeluaran *"
            '
            'TxtExpenseName
            '
            Me.TxtExpenseName.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TxtExpenseName.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.TxtExpenseName.Location = New System.Drawing.Point(20, 92)
            Me.TxtExpenseName.Margin = New System.Windows.Forms.Padding(0, 2, 0, 4)
            Me.TxtExpenseName.Name = "TxtExpenseName"
            Me.TxtExpenseName.Size = New System.Drawing.Size(520, 25)
            Me.TxtExpenseName.TabIndex = 3
            '
            'LblPayer
            '
            Me.LblPayer.AutoSize = True
            Me.LblPayer.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.LblPayer.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81)
            Me.LblPayer.Location = New System.Drawing.Point(20, 124)
            Me.LblPayer.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
            Me.LblPayer.Name = "LblPayer"
            Me.LblPayer.Size = New System.Drawing.Size(166, 15)
            Me.LblPayer.TabIndex = 4
            Me.LblPayer.Text = "Ditalangi / Dibayar Oleh: *"
            '
            'CmbPayer
            '
            Me.CmbPayer.Dock = System.Windows.Forms.DockStyle.Fill
            Me.CmbPayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.CmbPayer.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.CmbPayer.FormattingEnabled = True
            Me.CmbPayer.Location = New System.Drawing.Point(20, 144)
            Me.CmbPayer.Margin = New System.Windows.Forms.Padding(0, 2, 0, 4)
            Me.CmbPayer.Name = "CmbPayer"
            Me.CmbPayer.Size = New System.Drawing.Size(520, 25)
            Me.CmbPayer.TabIndex = 5
            '
            'LblMethod
            '
            Me.LblMethod.AutoSize = True
            Me.LblMethod.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.LblMethod.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81)
            Me.LblMethod.Location = New System.Drawing.Point(20, 176)
            Me.LblMethod.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
            Me.LblMethod.Name = "LblMethod"
            Me.LblMethod.Size = New System.Drawing.Size(130, 15)
            Me.LblMethod.TabIndex = 6
            Me.LblMethod.Text = "Metode Pembagian: *"
            '
            'CmbMethod
            '
            Me.CmbMethod.Dock = System.Windows.Forms.DockStyle.Fill
            Me.CmbMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.CmbMethod.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.CmbMethod.FormattingEnabled = True
            Me.CmbMethod.Location = New System.Drawing.Point(20, 196)
            Me.CmbMethod.Margin = New System.Windows.Forms.Padding(0, 2, 0, 4)
            Me.CmbMethod.Name = "CmbMethod"
            Me.CmbMethod.Size = New System.Drawing.Size(520, 25)
            Me.CmbMethod.TabIndex = 7
            '
            'LblOrders
            '
            Me.LblOrders.AutoSize = True
            Me.LblOrders.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.LblOrders.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81)
            Me.LblOrders.Location = New System.Drawing.Point(20, 228)
            Me.LblOrders.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
            Me.LblOrders.Name = "LblOrders"
            Me.LblOrders.Size = New System.Drawing.Size(225, 15)
            Me.LblOrders.TabIndex = 8
            Me.LblOrders.Text = "Rincian Pesanan Menu yang Ditagihkan:"
            '
            'LstOrders
            '
            Me.LstOrders.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LstOrders.Font = New System.Drawing.Font("Segoe UI", 9.5F)
            Me.LstOrders.FormattingEnabled = True
            Me.LstOrders.IntegralHeight = False
            Me.LstOrders.ItemHeight = 17
            Me.LstOrders.Location = New System.Drawing.Point(20, 248)
            Me.LstOrders.Margin = New System.Windows.Forms.Padding(0, 2, 0, 4)
            Me.LstOrders.Name = "LstOrders"
            Me.LstOrders.Size = New System.Drawing.Size(520, 114)
            Me.LstOrders.TabIndex = 9
            '
            'LblAdjustment
            '
            Me.LblAdjustment.AutoSize = True
            Me.LblAdjustment.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.LblAdjustment.ForeColor = System.Drawing.Color.FromArgb(55, 65, 81)
            Me.LblAdjustment.Location = New System.Drawing.Point(20, 368)
            Me.LblAdjustment.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
            Me.LblAdjustment.Name = "LblAdjustment"
            Me.LblAdjustment.Size = New System.Drawing.Size(325, 15)
            Me.LblAdjustment.TabIndex = 10
            Me.LblAdjustment.Text = "Penyesuaian Tambahan (Pajak / Parkir / Diskon / Biaya Lain):"
            '
            'NumAdjustment
            '
            Me.NumAdjustment.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.NumAdjustment.Location = New System.Drawing.Point(20, 388)
            Me.NumAdjustment.Margin = New System.Windows.Forms.Padding(0, 2, 0, 4)
            Me.NumAdjustment.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
            Me.NumAdjustment.Minimum = New Decimal(New Integer() {1000000000, 0, 0, -2147483648})
            Me.NumAdjustment.Name = "NumAdjustment"
            Me.NumAdjustment.Size = New System.Drawing.Size(240, 25)
            Me.NumAdjustment.TabIndex = 11
            Me.NumAdjustment.ThousandsSeparator = True
            '
            'LblTotal
            '
            Me.LblTotal.AutoSize = True
            Me.LblTotal.Font = New System.Drawing.Font("Segoe UI", 12.0F, System.Drawing.FontStyle.Bold)
            Me.LblTotal.ForeColor = System.Drawing.Color.FromArgb(22, 101, 52)
            Me.LblTotal.Location = New System.Drawing.Point(20, 418)
            Me.LblTotal.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
            Me.LblTotal.Name = "LblTotal"
            Me.LblTotal.Size = New System.Drawing.Size(155, 21)
            Me.LblTotal.TabIndex = 12
            Me.LblTotal.Text = "Total Tagihan: Rp0"
            '
            'LblValidation
            '
            Me.LblValidation.AutoSize = True
            Me.LblValidation.Font = New System.Drawing.Font("Segoe UI", 8.5F)
            Me.LblValidation.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38)
            Me.LblValidation.Location = New System.Drawing.Point(20, 448)
            Me.LblValidation.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
            Me.LblValidation.Name = "LblValidation"
            Me.LblValidation.Size = New System.Drawing.Size(0, 15)
            Me.LblValidation.TabIndex = 13
            '
            'ActionsFlow
            '
            Me.ActionsFlow.Controls.Add(Me.BtnSave)
            Me.ActionsFlow.Controls.Add(Me.BtnCancel)
            Me.ActionsFlow.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ActionsFlow.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
            Me.ActionsFlow.Location = New System.Drawing.Point(20, 470)
            Me.ActionsFlow.Margin = New System.Windows.Forms.Padding(0)
            Me.ActionsFlow.Name = "ActionsFlow"
            Me.ActionsFlow.Size = New System.Drawing.Size(520, 46)
            Me.ActionsFlow.TabIndex = 14
            Me.ActionsFlow.WrapContents = False
            '
            'BtnSave
            '
            Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(35, 122, 72)
            Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnSave.FlatAppearance.BorderSize = 0
            Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnSave.Font = New System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold)
            Me.BtnSave.ForeColor = System.Drawing.Color.White
            Me.BtnSave.Location = New System.Drawing.Point(354, 2)
            Me.BtnSave.Margin = New System.Windows.Forms.Padding(6, 2, 0, 2)
            Me.BtnSave.Name = "BtnSave"
            Me.BtnSave.Size = New System.Drawing.Size(160, 38)
            Me.BtnSave.TabIndex = 0
            Me.BtnSave.Text = "✓ Simpan Tagihan"
            Me.BtnSave.UseVisualStyleBackColor = False
            '
            'BtnCancel
            '
            Me.BtnCancel.BackColor = System.Drawing.Color.White
            Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.BtnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 231, 235)
            Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnCancel.Font = New System.Drawing.Font("Segoe UI", 9.5F)
            Me.BtnCancel.ForeColor = System.Drawing.Color.FromArgb(75, 85, 99)
            Me.BtnCancel.Location = New System.Drawing.Point(252, 2)
            Me.BtnCancel.Margin = New System.Windows.Forms.Padding(6, 2, 0, 2)
            Me.BtnCancel.Name = "BtnCancel"
            Me.BtnCancel.Size = New System.Drawing.Size(96, 38)
            Me.BtnCancel.TabIndex = 1
            Me.BtnCancel.Text = "Batal"
            Me.BtnCancel.UseVisualStyleBackColor = False
            '
            'BillFromOrdersDialog
            '
            Me.AcceptButton = Me.BtnSave
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.CancelButton = Me.BtnCancel
            Me.ClientSize = New System.Drawing.Size(560, 660)
            Me.Controls.Add(Me.DialogLayout)
            Me.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.MinimumSize = New System.Drawing.Size(500, 600)
            Me.Name = "BillFromOrdersDialog"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Buat Tagihan dari Pesanan Menu"
            Me.DialogLayout.ResumeLayout(False)
            Me.DialogLayout.PerformLayout()
            CType(Me.NumAdjustment, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ActionsFlow.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents DialogLayout As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents LblHeader As System.Windows.Forms.Label
        Friend WithEvents LblSubheader As System.Windows.Forms.Label
        Friend WithEvents LblExpenseName As System.Windows.Forms.Label
        Friend WithEvents TxtExpenseName As System.Windows.Forms.TextBox
        Friend WithEvents LblPayer As System.Windows.Forms.Label
        Friend WithEvents CmbPayer As System.Windows.Forms.ComboBox
        Friend WithEvents LblMethod As System.Windows.Forms.Label
        Friend WithEvents CmbMethod As System.Windows.Forms.ComboBox
        Friend WithEvents LblOrders As System.Windows.Forms.Label
        Friend WithEvents LstOrders As System.Windows.Forms.ListBox
        Friend WithEvents LblAdjustment As System.Windows.Forms.Label
        Friend WithEvents NumAdjustment As System.Windows.Forms.NumericUpDown
        Friend WithEvents LblTotal As System.Windows.Forms.Label
        Friend WithEvents LblValidation As System.Windows.Forms.Label
        Friend WithEvents ActionsFlow As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents BtnSave As System.Windows.Forms.Button
        Friend WithEvents BtnCancel As System.Windows.Forms.Button
    End Class
End Namespace
