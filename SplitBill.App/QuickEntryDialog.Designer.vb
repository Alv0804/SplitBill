Namespace Global.SplitBill.App
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class QuickEntryDialog
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
            Me.FieldsPanel = New System.Windows.Forms.TableLayoutPanel()
            Me.ActionsPanel = New System.Windows.Forms.FlowLayoutPanel()
            Me.BtnSave = New System.Windows.Forms.Button()
            Me.BtnCancel = New System.Windows.Forms.Button()
            Me.DialogLayout.SuspendLayout()
            Me.ActionsPanel.SuspendLayout()
            Me.SuspendLayout()
            '
            'DialogLayout
            '
            Me.DialogLayout.ColumnCount = 1
            Me.DialogLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.DialogLayout.Controls.Add(Me.FieldsPanel, 0, 0)
            Me.DialogLayout.Controls.Add(Me.ActionsPanel, 0, 1)
            Me.DialogLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.DialogLayout.Location = New System.Drawing.Point(0, 0)
            Me.DialogLayout.Name = "DialogLayout"
            Me.DialogLayout.Padding = New System.Windows.Forms.Padding(20)
            Me.DialogLayout.RowCount = 2
            Me.DialogLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.DialogLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0F))
            Me.DialogLayout.Size = New System.Drawing.Size(520, 260)
            Me.DialogLayout.TabIndex = 0
            '
            'FieldsPanel
            '
            Me.FieldsPanel.ColumnCount = 1
            Me.FieldsPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.FieldsPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.FieldsPanel.Location = New System.Drawing.Point(20, 20)
            Me.FieldsPanel.Margin = New System.Windows.Forms.Padding(0)
            Me.FieldsPanel.Name = "FieldsPanel"
            Me.FieldsPanel.RowCount = 1
            Me.FieldsPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.FieldsPanel.Size = New System.Drawing.Size(480, 172)
            Me.FieldsPanel.TabIndex = 0
            '
            'ActionsPanel
            '
            Me.ActionsPanel.Controls.Add(Me.BtnSave)
            Me.ActionsPanel.Controls.Add(Me.BtnCancel)
            Me.ActionsPanel.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ActionsPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
            Me.ActionsPanel.Location = New System.Drawing.Point(20, 192)
            Me.ActionsPanel.Margin = New System.Windows.Forms.Padding(0)
            Me.ActionsPanel.Name = "ActionsPanel"
            Me.ActionsPanel.Size = New System.Drawing.Size(480, 48)
            Me.ActionsPanel.TabIndex = 1
            Me.ActionsPanel.WrapContents = False
            '
            'BtnSave
            '
            Me.BtnSave.BackColor = System.Drawing.Color.FromArgb(47, 107, 79)
            Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnSave.FlatAppearance.BorderSize = 0
            Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnSave.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.BtnSave.ForeColor = System.Drawing.Color.White
            Me.BtnSave.Location = New System.Drawing.Point(380, 3)
            Me.BtnSave.Name = "BtnSave"
            Me.BtnSave.Size = New System.Drawing.Size(97, 38)
            Me.BtnSave.TabIndex = 0
            Me.BtnSave.Text = "Simpan"
            Me.BtnSave.UseVisualStyleBackColor = False
            '
            'BtnCancel
            '
            Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnCancel.Location = New System.Drawing.Point(277, 3)
            Me.BtnCancel.Name = "BtnCancel"
            Me.BtnCancel.Size = New System.Drawing.Size(97, 38)
            Me.BtnCancel.TabIndex = 1
            Me.BtnCancel.Text = "Batal"
            Me.BtnCancel.UseVisualStyleBackColor = True
            '
            'QuickEntryDialog
            '
            Me.AcceptButton = Me.BtnSave
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(246, 248, 246)
            Me.CancelButton = Me.BtnCancel
            Me.ClientSize = New System.Drawing.Size(520, 260)
            Me.Controls.Add(Me.DialogLayout)
            Me.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "QuickEntryDialog"
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Input Data"
            Me.DialogLayout.ResumeLayout(False)
            Me.ActionsPanel.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents DialogLayout As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents FieldsPanel As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents ActionsPanel As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents BtnSave As System.Windows.Forms.Button
        Friend WithEvents BtnCancel As System.Windows.Forms.Button
    End Class
End Namespace
