Namespace Global.SplitBill.App
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class PersonPickerDialog
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
            MainLayout = New TableLayoutPanel()
            TxtSearch = New TextBox()
            LstPeople = New ListBox()
            ActionPanel = New FlowLayoutPanel()
            BtnSelect = New Button()
            BtnCancel = New Button()
            MainLayout.SuspendLayout()
            ActionPanel.SuspendLayout()
            SuspendLayout()
            ' 
            ' MainLayout
            ' 
            MainLayout.ColumnCount = 1
            MainLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
            MainLayout.Controls.Add(TxtSearch, 0, 0)
            MainLayout.Controls.Add(LstPeople, 0, 1)
            MainLayout.Controls.Add(ActionPanel, 0, 2)
            MainLayout.Dock = DockStyle.Fill
            MainLayout.Location = New Point(0, 0)
            MainLayout.Margin = New Padding(62, 29, 62, 29)
            MainLayout.Name = "MainLayout"
            MainLayout.Padding = New Padding(329, 154, 329, 154)
            MainLayout.RowCount = 3
            MainLayout.RowStyles.Add(New RowStyle(SizeType.Absolute, 384.0F))
            MainLayout.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F))
            MainLayout.RowStyles.Add(New RowStyle(SizeType.Absolute, 461.0F))
            MainLayout.Size = New Size(1924, 1170)
            MainLayout.TabIndex = 0
            ' 
            ' TxtSearch
            ' 
            TxtSearch.Dock = DockStyle.Fill
            TxtSearch.Font = New Font("Segoe UI", 10.0F)
            TxtSearch.Location = New Point(391, 183)
            TxtSearch.Margin = New Padding(62, 29, 62, 29)
            TxtSearch.Name = "TxtSearch"
            TxtSearch.PlaceholderText = "Cari nama..."
            TxtSearch.Size = New Size(1142, 34)
            TxtSearch.TabIndex = 0
            ' 
            ' LstPeople
            ' 
            LstPeople.Dock = DockStyle.Fill
            LstPeople.Font = New Font("Segoe UI", 10.0F)
            LstPeople.FormattingEnabled = True
            LstPeople.IntegralHeight = False
            LstPeople.Location = New Point(391, 567)
            LstPeople.Margin = New Padding(62, 29, 62, 29)
            LstPeople.Name = "LstPeople"
            LstPeople.Size = New Size(1142, 1)
            LstPeople.TabIndex = 1
            ' 
            ' ActionPanel
            ' 
            ActionPanel.Controls.Add(BtnSelect)
            ActionPanel.Controls.Add(BtnCancel)
            ActionPanel.Dock = DockStyle.Fill
            ActionPanel.FlowDirection = FlowDirection.RightToLeft
            ActionPanel.Location = New Point(391, 584)
            ActionPanel.Margin = New Padding(62, 29, 62, 29)
            ActionPanel.Name = "ActionPanel"
            ActionPanel.Size = New Size(1142, 403)
            ActionPanel.TabIndex = 2
            ' 
            ' BtnSelect
            ' 
            BtnSelect.BackColor = Color.FromArgb(CByte(22), CByte(101), CByte(52))
            BtnSelect.Cursor = Cursors.Hand
            BtnSelect.DialogResult = DialogResult.OK
            BtnSelect.FlatAppearance.BorderSize = 0
            BtnSelect.FlatStyle = FlatStyle.Flat
            BtnSelect.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
            BtnSelect.ForeColor = Color.White
            BtnSelect.Location = New Point(-915, 29)
            BtnSelect.Margin = New Padding(62, 29, 62, 29)
            BtnSelect.Name = "BtnSelect"
            BtnSelect.Size = New Size(1995, 346)
            BtnSelect.TabIndex = 0
            BtnSelect.Text = "Pilih"
            BtnSelect.UseVisualStyleBackColor = False
            ' 
            ' BtnCancel
            ' 
            BtnCancel.Cursor = Cursors.Hand
            BtnCancel.DialogResult = DialogResult.Cancel
            BtnCancel.FlatStyle = FlatStyle.Flat
            BtnCancel.Font = New Font("Segoe UI", 9.5F)
            BtnCancel.Location = New Point(-915, 433)
            BtnCancel.Margin = New Padding(62, 29, 62, 29)
            BtnCancel.Name = "BtnCancel"
            BtnCancel.Size = New Size(1995, 346)
            BtnCancel.TabIndex = 1
            BtnCancel.Text = "Batal"
            BtnCancel.UseVisualStyleBackColor = True
            ' 
            ' PersonPickerDialog
            ' 
            AcceptButton = BtnSelect
            AutoScaleDimensions = New SizeF(144.0F, 144.0F)
            AutoScaleMode = AutoScaleMode.Dpi
            BackColor = Color.FromArgb(CByte(246), CByte(248), CByte(246))
            CancelButton = BtnCancel
            ClientSize = New Size(1924, 1170)
            Controls.Add(MainLayout)
            Font = New Font("Segoe UI", 9.0F)
            FormBorderStyle = FormBorderStyle.FixedDialog
            Margin = New Padding(62, 29, 62, 29)
            MaximizeBox = False
            MinimizeBox = False
            Name = "PersonPickerDialog"
            StartPosition = FormStartPosition.CenterParent
            Text = "Pilih Anggota"
            MainLayout.ResumeLayout(False)
            MainLayout.PerformLayout()
            ActionPanel.ResumeLayout(False)
            ResumeLayout(False)

        End Sub

        Friend WithEvents MainLayout As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
        Friend WithEvents LstPeople As System.Windows.Forms.ListBox
        Friend WithEvents ActionPanel As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents BtnSelect As System.Windows.Forms.Button
        Friend WithEvents BtnCancel As System.Windows.Forms.Button
    End Class
End Namespace

