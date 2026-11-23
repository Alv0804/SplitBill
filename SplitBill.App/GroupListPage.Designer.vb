Namespace Global.SplitBill.App
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class GroupListPage
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
            Me.TopActions = New System.Windows.Forms.FlowLayoutPanel()
            Me.BtnNewGroup = New System.Windows.Forms.Button()
            Me.BtnReload = New System.Windows.Forms.Button()
            Me.TabsControl = New System.Windows.Forms.TabControl()
            Me.ActiveTab = New System.Windows.Forms.TabPage()
            Me.ActiveGroupsList = New System.Windows.Forms.ListBox()
            Me.CompletedTab = New System.Windows.Forms.TabPage()
            Me.CompletedGroupsList = New System.Windows.Forms.ListBox()
            Me.AllTab = New System.Windows.Forms.TabPage()
            Me.AllGroupsList = New System.Windows.Forms.ListBox()
            Me.FooterLayout = New System.Windows.Forms.FlowLayoutPanel()
            Me.BtnOpenSelected = New System.Windows.Forms.Button()
            Me.BtnJoinWithCode = New System.Windows.Forms.Button()
            Me.StatusLabel = New System.Windows.Forms.Label()
            Me.RootLayout.SuspendLayout()
            Me.HeaderLayout.SuspendLayout()
            Me.TitleStack.SuspendLayout()
            Me.TopActions.SuspendLayout()
            Me.TabsControl.SuspendLayout()
            Me.ActiveTab.SuspendLayout()
            Me.CompletedTab.SuspendLayout()
            Me.AllTab.SuspendLayout()
            Me.FooterLayout.SuspendLayout()
            Me.SuspendLayout()
            '
            'RootLayout
            '
            Me.RootLayout.BackColor = System.Drawing.Color.FromArgb(246, 248, 246)
            Me.RootLayout.ColumnCount = 1
            Me.RootLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.RootLayout.Controls.Add(Me.HeaderLayout, 0, 0)
            Me.RootLayout.Controls.Add(Me.TabsControl, 0, 1)
            Me.RootLayout.Controls.Add(Me.FooterLayout, 0, 2)
            Me.RootLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.RootLayout.Location = New System.Drawing.Point(0, 0)
            Me.RootLayout.Name = "RootLayout"
            Me.RootLayout.Padding = New System.Windows.Forms.Padding(24, 20, 24, 20)
            Me.RootLayout.RowCount = 3
            Me.RootLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 68.0F))
            Me.RootLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.RootLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52.0F))
            Me.RootLayout.Size = New System.Drawing.Size(900, 600)
            Me.RootLayout.TabIndex = 0
            '
            'HeaderLayout
            '
            Me.HeaderLayout.ColumnCount = 2
            Me.HeaderLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.HeaderLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260.0F))
            Me.HeaderLayout.Controls.Add(Me.TitleStack, 0, 0)
            Me.HeaderLayout.Controls.Add(Me.TopActions, 1, 0)
            Me.HeaderLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.HeaderLayout.Location = New System.Drawing.Point(24, 20)
            Me.HeaderLayout.Margin = New System.Windows.Forms.Padding(0)
            Me.HeaderLayout.Name = "HeaderLayout"
            Me.HeaderLayout.RowCount = 1
            Me.HeaderLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.HeaderLayout.Size = New System.Drawing.Size(852, 68)
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
            Me.TitleStack.Size = New System.Drawing.Size(592, 68)
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
            Me.TitleLabel.Size = New System.Drawing.Size(250, 37)
            Me.TitleLabel.TabIndex = 0
            Me.TitleLabel.Text = "Kegiatan & Riwayat"
            '
            'SubtitleLabel
            '
            Me.SubtitleLabel.AutoSize = True
            Me.SubtitleLabel.Font = New System.Drawing.Font("Segoe UI", 9.5F)
            Me.SubtitleLabel.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128)
            Me.SubtitleLabel.Location = New System.Drawing.Point(0, 37)
            Me.SubtitleLabel.Margin = New System.Windows.Forms.Padding(0)
            Me.SubtitleLabel.Name = "SubtitleLabel"
            Me.SubtitleLabel.Size = New System.Drawing.Size(471, 17)
            Me.SubtitleLabel.TabIndex = 1
            Me.SubtitleLabel.Text = "Kelola daftar kegiatan aktif dan tinjau riwayat tagihan yang sudah difinalisasi."
            '
            'TopActions
            '
            Me.TopActions.Controls.Add(Me.BtnNewGroup)
            Me.TopActions.Controls.Add(Me.BtnReload)
            Me.TopActions.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TopActions.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft
            Me.TopActions.Location = New System.Drawing.Point(592, 0)
            Me.TopActions.Margin = New System.Windows.Forms.Padding(0)
            Me.TopActions.Name = "TopActions"
            Me.TopActions.Size = New System.Drawing.Size(260, 68)
            Me.TopActions.TabIndex = 1
            Me.TopActions.WrapContents = False
            '
            'BtnNewGroup
            '
            Me.BtnNewGroup.AutoSize = True
            Me.BtnNewGroup.BackColor = System.Drawing.Color.FromArgb(47, 107, 79)
            Me.BtnNewGroup.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnNewGroup.FlatAppearance.BorderSize = 0
            Me.BtnNewGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnNewGroup.Font = New System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold)
            Me.BtnNewGroup.ForeColor = System.Drawing.Color.White
            Me.BtnNewGroup.Location = New System.Drawing.Point(125, 0)
            Me.BtnNewGroup.Margin = New System.Windows.Forms.Padding(0)
            Me.BtnNewGroup.Name = "BtnNewGroup"
            Me.BtnNewGroup.Size = New System.Drawing.Size(135, 38)
            Me.BtnNewGroup.TabIndex = 0
            Me.BtnNewGroup.Text = "＋ Buat Kegiatan"
            Me.BtnNewGroup.UseVisualStyleBackColor = False
            '
            'BtnReload
            '
            Me.BtnReload.AutoSize = True
            Me.BtnReload.BackColor = System.Drawing.Color.White
            Me.BtnReload.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnReload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 231, 235)
            Me.BtnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnReload.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.BtnReload.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.BtnReload.Location = New System.Drawing.Point(34, 0)
            Me.BtnReload.Margin = New System.Windows.Forms.Padding(0, 0, 8, 0)
            Me.BtnReload.Name = "BtnReload"
            Me.BtnReload.Size = New System.Drawing.Size(83, 38)
            Me.BtnReload.TabIndex = 1
            Me.BtnReload.Text = "Muat Ulang"
            Me.BtnReload.UseVisualStyleBackColor = False
            '
            'TabsControl
            '
            Me.TabsControl.Controls.Add(Me.ActiveTab)
            Me.TabsControl.Controls.Add(Me.CompletedTab)
            Me.TabsControl.Controls.Add(Me.AllTab)
            Me.TabsControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TabsControl.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.TabsControl.Location = New System.Drawing.Point(24, 88)
            Me.TabsControl.Margin = New System.Windows.Forms.Padding(0)
            Me.TabsControl.Name = "TabsControl"
            Me.TabsControl.SelectedIndex = 0
            Me.TabsControl.Size = New System.Drawing.Size(852, 440)
            Me.TabsControl.TabIndex = 1
            '
            'ActiveTab
            '
            Me.ActiveTab.BackColor = System.Drawing.Color.FromArgb(246, 248, 246)
            Me.ActiveTab.Controls.Add(Me.ActiveGroupsList)
            Me.ActiveTab.Location = New System.Drawing.Point(4, 26)
            Me.ActiveTab.Name = "ActiveTab"
            Me.ActiveTab.Padding = New System.Windows.Forms.Padding(12)
            Me.ActiveTab.Size = New System.Drawing.Size(844, 410)
            Me.ActiveTab.TabIndex = 0
            Me.ActiveTab.Text = "Kegiatan Aktif"
            '
            'ActiveGroupsList
            '
            Me.ActiveGroupsList.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.ActiveGroupsList.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ActiveGroupsList.Font = New System.Drawing.Font("Segoe UI", 10.5F)
            Me.ActiveGroupsList.IntegralHeight = False
            Me.ActiveGroupsList.ItemHeight = 19
            Me.ActiveGroupsList.Location = New System.Drawing.Point(12, 12)
            Me.ActiveGroupsList.Name = "ActiveGroupsList"
            Me.ActiveGroupsList.Size = New System.Drawing.Size(820, 386)
            Me.ActiveGroupsList.TabIndex = 0
            '
            'CompletedTab
            '
            Me.CompletedTab.BackColor = System.Drawing.Color.FromArgb(246, 248, 246)
            Me.CompletedTab.Controls.Add(Me.CompletedGroupsList)
            Me.CompletedTab.Location = New System.Drawing.Point(4, 26)
            Me.CompletedTab.Name = "CompletedTab"
            Me.CompletedTab.Padding = New System.Windows.Forms.Padding(12)
            Me.CompletedTab.Size = New System.Drawing.Size(844, 410)
            Me.CompletedTab.TabIndex = 1
            Me.CompletedTab.Text = "Riwayat Selesai"
            '
            'CompletedGroupsList
            '
            Me.CompletedGroupsList.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.CompletedGroupsList.Dock = System.Windows.Forms.DockStyle.Fill
            Me.CompletedGroupsList.Font = New System.Drawing.Font("Segoe UI", 10.5F)
            Me.CompletedGroupsList.IntegralHeight = False
            Me.CompletedGroupsList.ItemHeight = 19
            Me.CompletedGroupsList.Location = New System.Drawing.Point(12, 12)
            Me.CompletedGroupsList.Name = "CompletedGroupsList"
            Me.CompletedGroupsList.Size = New System.Drawing.Size(820, 386)
            Me.CompletedGroupsList.TabIndex = 0
            '
            'AllTab
            '
            Me.AllTab.BackColor = System.Drawing.Color.FromArgb(246, 248, 246)
            Me.AllTab.Controls.Add(Me.AllGroupsList)
            Me.AllTab.Location = New System.Drawing.Point(4, 26)
            Me.AllTab.Name = "AllTab"
            Me.AllTab.Padding = New System.Windows.Forms.Padding(12)
            Me.AllTab.Size = New System.Drawing.Size(844, 410)
            Me.AllTab.TabIndex = 2
            Me.AllTab.Text = "Semua Kegiatan"
            '
            'AllGroupsList
            '
            Me.AllGroupsList.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.AllGroupsList.Dock = System.Windows.Forms.DockStyle.Fill
            Me.AllGroupsList.Font = New System.Drawing.Font("Segoe UI", 10.5F)
            Me.AllGroupsList.IntegralHeight = False
            Me.AllGroupsList.ItemHeight = 19
            Me.AllGroupsList.Location = New System.Drawing.Point(12, 12)
            Me.AllGroupsList.Name = "AllGroupsList"
            Me.AllGroupsList.Size = New System.Drawing.Size(820, 386)
            Me.AllGroupsList.TabIndex = 0
            '
            'FooterLayout
            '
            Me.FooterLayout.Controls.Add(Me.BtnOpenSelected)
            Me.FooterLayout.Controls.Add(Me.BtnJoinWithCode)
            Me.FooterLayout.Controls.Add(Me.StatusLabel)
            Me.FooterLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.FooterLayout.Location = New System.Drawing.Point(24, 528)
            Me.FooterLayout.Margin = New System.Windows.Forms.Padding(0)
            Me.FooterLayout.Name = "FooterLayout"
            Me.FooterLayout.Size = New System.Drawing.Size(852, 52)
            Me.FooterLayout.TabIndex = 2
            Me.FooterLayout.WrapContents = True
            '
            'BtnOpenSelected
            '
            Me.BtnOpenSelected.AutoSize = True
            Me.BtnOpenSelected.BackColor = System.Drawing.Color.FromArgb(47, 107, 79)
            Me.BtnOpenSelected.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnOpenSelected.FlatAppearance.BorderSize = 0
            Me.BtnOpenSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnOpenSelected.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.BtnOpenSelected.ForeColor = System.Drawing.Color.White
            Me.BtnOpenSelected.Location = New System.Drawing.Point(0, 0)
            Me.BtnOpenSelected.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
            Me.BtnOpenSelected.Name = "BtnOpenSelected"
            Me.BtnOpenSelected.Size = New System.Drawing.Size(155, 38)
            Me.BtnOpenSelected.TabIndex = 0
            Me.BtnOpenSelected.Text = "Buka Kegiatan Terpilih"
            Me.BtnOpenSelected.UseVisualStyleBackColor = False
            '
            'BtnJoinWithCode
            '
            Me.BtnJoinWithCode.AutoSize = True
            Me.BtnJoinWithCode.BackColor = System.Drawing.Color.White
            Me.BtnJoinWithCode.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnJoinWithCode.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(229, 231, 235)
            Me.BtnJoinWithCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BtnJoinWithCode.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.BtnJoinWithCode.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.BtnJoinWithCode.Location = New System.Drawing.Point(165, 0)
            Me.BtnJoinWithCode.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
            Me.BtnJoinWithCode.Name = "BtnJoinWithCode"
            Me.BtnJoinWithCode.Size = New System.Drawing.Size(195, 38)
            Me.BtnJoinWithCode.TabIndex = 1
            Me.BtnJoinWithCode.Text = "Gabung dengan Kode Undangan"
            Me.BtnJoinWithCode.UseVisualStyleBackColor = False
            '
            'StatusLabel
            '
            Me.StatusLabel.AutoSize = True
            Me.StatusLabel.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128)
            Me.StatusLabel.Location = New System.Drawing.Point(370, 11)
            Me.StatusLabel.Margin = New System.Windows.Forms.Padding(0, 11, 0, 0)
            Me.StatusLabel.MaximumSize = New System.Drawing.Size(450, 0)
            Me.StatusLabel.Name = "StatusLabel"
            Me.StatusLabel.Size = New System.Drawing.Size(0, 15)
            Me.StatusLabel.TabIndex = 2
            '
            'GroupListPage
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(246, 248, 246)
            Me.Controls.Add(Me.RootLayout)
            Me.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.Name = "GroupListPage"
            Me.Size = New System.Drawing.Size(900, 600)
            Me.RootLayout.ResumeLayout(False)
            Me.HeaderLayout.ResumeLayout(False)
            Me.TitleStack.ResumeLayout(False)
            Me.TitleStack.PerformLayout()
            Me.TopActions.ResumeLayout(False)
            Me.TopActions.PerformLayout()
            Me.TabsControl.ResumeLayout(False)
            Me.ActiveTab.ResumeLayout(False)
            Me.CompletedTab.ResumeLayout(False)
            Me.AllTab.ResumeLayout(False)
            Me.FooterLayout.ResumeLayout(False)
            Me.FooterLayout.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents RootLayout As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents HeaderLayout As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents TitleStack As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents TitleLabel As System.Windows.Forms.Label
        Friend WithEvents SubtitleLabel As System.Windows.Forms.Label
        Friend WithEvents TopActions As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents BtnNewGroup As System.Windows.Forms.Button
        Friend WithEvents BtnReload As System.Windows.Forms.Button
        Friend WithEvents TabsControl As System.Windows.Forms.TabControl
        Friend WithEvents ActiveTab As System.Windows.Forms.TabPage
        Friend WithEvents ActiveGroupsList As System.Windows.Forms.ListBox
        Friend WithEvents CompletedTab As System.Windows.Forms.TabPage
        Friend WithEvents CompletedGroupsList As System.Windows.Forms.ListBox
        Friend WithEvents AllTab As System.Windows.Forms.TabPage
        Friend WithEvents AllGroupsList As System.Windows.Forms.ListBox
        Friend WithEvents FooterLayout As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents BtnOpenSelected As System.Windows.Forms.Button
        Friend WithEvents BtnJoinWithCode As System.Windows.Forms.Button
        Friend WithEvents StatusLabel As System.Windows.Forms.Label
    End Class
End Namespace