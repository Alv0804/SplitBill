Namespace Global.SplitBill.App
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class AuthenticationPage
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
            Me.CenterLayout = New System.Windows.Forms.TableLayoutPanel()
            Me.CardPanel = New System.Windows.Forms.Panel()
            Me.FieldsLayout = New System.Windows.Forms.FlowLayoutPanel()
            Me.LogoBadge = New System.Windows.Forms.Label()
            Me.TitleLabel = New System.Windows.Forms.Label()
            Me.SubtitleLabel = New System.Windows.Forms.Label()
            Me.DisplayNameLabel = New System.Windows.Forms.Label()
            Me.DisplayNameTextBox = New System.Windows.Forms.TextBox()
            Me.EmailLabel = New System.Windows.Forms.Label()
            Me.EmailTextBox = New System.Windows.Forms.TextBox()
            Me.PasswordLabel = New System.Windows.Forms.Label()
            Me.PasswordTextBox = New System.Windows.Forms.TextBox()
            Me.SubmitButton = New System.Windows.Forms.Button()
            Me.StatusLabel = New System.Windows.Forms.Label()
            Me.ToggleButton = New System.Windows.Forms.Button()
            Me.CenterLayout.SuspendLayout()
            Me.CardPanel.SuspendLayout()
            Me.FieldsLayout.SuspendLayout()
            Me.SuspendLayout()
            '
            'CenterLayout
            '
            Me.CenterLayout.BackColor = System.Drawing.Color.FromArgb(246, 248, 246)
            Me.CenterLayout.ColumnCount = 1
            Me.CenterLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.CenterLayout.Controls.Add(Me.CardPanel, 0, 0)
            Me.CenterLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.CenterLayout.Location = New System.Drawing.Point(0, 0)
            Me.CenterLayout.Name = "CenterLayout"
            Me.CenterLayout.RowCount = 1
            Me.CenterLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0F))
            Me.CenterLayout.Size = New System.Drawing.Size(700, 700)
            Me.CenterLayout.TabIndex = 0
            '
            'CardPanel
            '
            Me.CardPanel.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.CardPanel.AutoSize = True
            Me.CardPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.CardPanel.BackColor = System.Drawing.Color.White
            Me.CardPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.CardPanel.Controls.Add(Me.FieldsLayout)
            Me.CardPanel.Location = New System.Drawing.Point(100, 60)
            Me.CardPanel.MaximumSize = New System.Drawing.Size(560, 720)
            Me.CardPanel.MinimumSize = New System.Drawing.Size(480, 0)
            Me.CardPanel.Name = "CardPanel"
            Me.CardPanel.Padding = New System.Windows.Forms.Padding(28)
            Me.CardPanel.Size = New System.Drawing.Size(498, 540)
            Me.CardPanel.TabIndex = 0
            '
            'FieldsLayout
            '
            Me.FieldsLayout.AutoSize = True
            Me.FieldsLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.FieldsLayout.BackColor = System.Drawing.Color.White
            Me.FieldsLayout.Controls.Add(Me.LogoBadge)
            Me.FieldsLayout.Controls.Add(Me.TitleLabel)
            Me.FieldsLayout.Controls.Add(Me.SubtitleLabel)
            Me.FieldsLayout.Controls.Add(Me.DisplayNameLabel)
            Me.FieldsLayout.Controls.Add(Me.DisplayNameTextBox)
            Me.FieldsLayout.Controls.Add(Me.EmailLabel)
            Me.FieldsLayout.Controls.Add(Me.EmailTextBox)
            Me.FieldsLayout.Controls.Add(Me.PasswordLabel)
            Me.FieldsLayout.Controls.Add(Me.PasswordTextBox)
            Me.FieldsLayout.Controls.Add(Me.SubmitButton)
            Me.FieldsLayout.Controls.Add(Me.StatusLabel)
            Me.FieldsLayout.Controls.Add(Me.ToggleButton)
            Me.FieldsLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.FieldsLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
            Me.FieldsLayout.Location = New System.Drawing.Point(28, 28)
            Me.FieldsLayout.Margin = New System.Windows.Forms.Padding(0)
            Me.FieldsLayout.Name = "FieldsLayout"
            Me.FieldsLayout.Size = New System.Drawing.Size(440, 482)
            Me.FieldsLayout.TabIndex = 0
            Me.FieldsLayout.WrapContents = False
            '
            'LogoBadge
            '
            Me.LogoBadge.BackColor = System.Drawing.Color.FromArgb(47, 107, 79)
            Me.LogoBadge.Font = New System.Drawing.Font("Segoe UI", 16.0F)
            Me.LogoBadge.ForeColor = System.Drawing.Color.White
            Me.LogoBadge.Location = New System.Drawing.Point(0, 0)
            Me.LogoBadge.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
            Me.LogoBadge.Name = "LogoBadge"
            Me.LogoBadge.Size = New System.Drawing.Size(44, 44)
            Me.LogoBadge.TabIndex = 0
            Me.LogoBadge.Text = "👛"
            Me.LogoBadge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'TitleLabel
            '
            Me.TitleLabel.AutoSize = True
            Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI", 24.0F, System.Drawing.FontStyle.Bold)
            Me.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(32, 73, 54)
            Me.TitleLabel.Location = New System.Drawing.Point(0, 54)
            Me.TitleLabel.Margin = New System.Windows.Forms.Padding(0)
            Me.TitleLabel.Name = "TitleLabel"
            Me.TitleLabel.Size = New System.Drawing.Size(147, 45)
            Me.TitleLabel.TabIndex = 1
            Me.TitleLabel.Text = "SplitBill"
            '
            'SubtitleLabel
            '
            Me.SubtitleLabel.AutoSize = True
            Me.SubtitleLabel.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.SubtitleLabel.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128)
            Me.SubtitleLabel.Location = New System.Drawing.Point(0, 99)
            Me.SubtitleLabel.Margin = New System.Windows.Forms.Padding(0, 0, 0, 14)
            Me.SubtitleLabel.MaximumSize = New System.Drawing.Size(440, 0)
            Me.SubtitleLabel.Name = "SubtitleLabel"
            Me.SubtitleLabel.Size = New System.Drawing.Size(268, 19)
            Me.SubtitleLabel.TabIndex = 2
            Me.SubtitleLabel.Text = "Catat pengeluaran bersama dengan mudah."
            '
            'DisplayNameLabel
            '
            Me.DisplayNameLabel.AutoSize = True
            Me.DisplayNameLabel.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.DisplayNameLabel.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.DisplayNameLabel.Location = New System.Drawing.Point(0, 132)
            Me.DisplayNameLabel.Margin = New System.Windows.Forms.Padding(0, 0, 0, 4)
            Me.DisplayNameLabel.Name = "DisplayNameLabel"
            Me.DisplayNameLabel.Size = New System.Drawing.Size(40, 15)
            Me.DisplayNameLabel.TabIndex = 3
            Me.DisplayNameLabel.Text = "Nama"
            Me.DisplayNameLabel.Visible = False
            '
            'DisplayNameTextBox
            '
            Me.DisplayNameTextBox.Font = New System.Drawing.Font("Segoe UI", 10.5F)
            Me.DisplayNameTextBox.Location = New System.Drawing.Point(0, 151)
            Me.DisplayNameTextBox.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
            Me.DisplayNameTextBox.Name = "DisplayNameTextBox"
            Me.DisplayNameTextBox.PlaceholderText = "Nama yang ditampilkan"
            Me.DisplayNameTextBox.Size = New System.Drawing.Size(440, 26)
            Me.DisplayNameTextBox.TabIndex = 4
            Me.DisplayNameTextBox.Visible = False
            '
            'EmailLabel
            '
            Me.EmailLabel.AutoSize = True
            Me.EmailLabel.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.EmailLabel.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.EmailLabel.Location = New System.Drawing.Point(0, 187)
            Me.EmailLabel.Margin = New System.Windows.Forms.Padding(0, 0, 0, 4)
            Me.EmailLabel.Name = "EmailLabel"
            Me.EmailLabel.Size = New System.Drawing.Size(36, 15)
            Me.EmailLabel.TabIndex = 5
            Me.EmailLabel.Text = "Email"
            '
            'EmailTextBox
            '
            Me.EmailTextBox.Font = New System.Drawing.Font("Segoe UI", 10.5F)
            Me.EmailTextBox.Location = New System.Drawing.Point(0, 206)
            Me.EmailTextBox.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
            Me.EmailTextBox.Name = "EmailTextBox"
            Me.EmailTextBox.PlaceholderText = "nama@email.com"
            Me.EmailTextBox.Size = New System.Drawing.Size(440, 26)
            Me.EmailTextBox.TabIndex = 6
            '
            'PasswordLabel
            '
            Me.PasswordLabel.AutoSize = True
            Me.PasswordLabel.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.PasswordLabel.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.PasswordLabel.Location = New System.Drawing.Point(0, 242)
            Me.PasswordLabel.Margin = New System.Windows.Forms.Padding(0, 0, 0, 4)
            Me.PasswordLabel.Name = "PasswordLabel"
            Me.PasswordLabel.Size = New System.Drawing.Size(65, 15)
            Me.PasswordLabel.TabIndex = 7
            Me.PasswordLabel.Text = "Kata sandi"
            '
            'PasswordTextBox
            '
            Me.PasswordTextBox.Font = New System.Drawing.Font("Segoe UI", 10.5F)
            Me.PasswordTextBox.Location = New System.Drawing.Point(0, 261)
            Me.PasswordTextBox.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
            Me.PasswordTextBox.Name = "PasswordTextBox"
            Me.PasswordTextBox.PlaceholderText = "Minimal 6 karakter"
            Me.PasswordTextBox.Size = New System.Drawing.Size(440, 26)
            Me.PasswordTextBox.TabIndex = 8
            Me.PasswordTextBox.UseSystemPasswordChar = True
            '
            'SubmitButton
            '
            Me.SubmitButton.BackColor = System.Drawing.Color.FromArgb(47, 107, 79)
            Me.SubmitButton.Cursor = System.Windows.Forms.Cursors.Hand
            Me.SubmitButton.FlatAppearance.BorderSize = 0
            Me.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.SubmitButton.Font = New System.Drawing.Font("Segoe UI", 10.0F, System.Drawing.FontStyle.Bold)
            Me.SubmitButton.ForeColor = System.Drawing.Color.White
            Me.SubmitButton.Location = New System.Drawing.Point(0, 309)
            Me.SubmitButton.Margin = New System.Windows.Forms.Padding(0, 12, 0, 6)
            Me.SubmitButton.Name = "SubmitButton"
            Me.SubmitButton.Size = New System.Drawing.Size(440, 46)
            Me.SubmitButton.TabIndex = 9
            Me.SubmitButton.Text = "Masuk"
            Me.SubmitButton.UseVisualStyleBackColor = False
            '
            'StatusLabel
            '
            Me.StatusLabel.AutoSize = True
            Me.StatusLabel.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.StatusLabel.ForeColor = System.Drawing.Color.FromArgb(220, 38, 38)
            Me.StatusLabel.Location = New System.Drawing.Point(0, 361)
            Me.StatusLabel.Margin = New System.Windows.Forms.Padding(0, 0, 0, 8)
            Me.StatusLabel.MaximumSize = New System.Drawing.Size(440, 0)
            Me.StatusLabel.Name = "StatusLabel"
            Me.StatusLabel.Size = New System.Drawing.Size(0, 15)
            Me.StatusLabel.TabIndex = 10
            '
            'ToggleButton
            '
            Me.ToggleButton.Cursor = System.Windows.Forms.Cursors.Hand
            Me.ToggleButton.FlatAppearance.BorderSize = 0
            Me.ToggleButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
            Me.ToggleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
            Me.ToggleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.ToggleButton.Font = New System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold)
            Me.ToggleButton.ForeColor = System.Drawing.Color.FromArgb(47, 107, 79)
            Me.ToggleButton.Location = New System.Drawing.Point(0, 384)
            Me.ToggleButton.Margin = New System.Windows.Forms.Padding(0)
            Me.ToggleButton.Name = "ToggleButton"
            Me.ToggleButton.Padding = New System.Windows.Forms.Padding(0)
            Me.ToggleButton.Size = New System.Drawing.Size(440, 32)
            Me.ToggleButton.TabIndex = 11
            Me.ToggleButton.Text = "Belum punya akun? Daftar"
            Me.ToggleButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.ToggleButton.UseVisualStyleBackColor = True
            '
            'AuthenticationPage
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(246, 248, 246)
            Me.Controls.Add(Me.CenterLayout)
            Me.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.Name = "AuthenticationPage"
            Me.Size = New System.Drawing.Size(700, 700)
            Me.CenterLayout.ResumeLayout(False)
            Me.CenterLayout.PerformLayout()
            Me.CardPanel.ResumeLayout(False)
            Me.CardPanel.PerformLayout()
            Me.FieldsLayout.ResumeLayout(False)
            Me.FieldsLayout.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents CenterLayout As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents CardPanel As System.Windows.Forms.Panel
        Friend WithEvents FieldsLayout As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents LogoBadge As System.Windows.Forms.Label
        Friend WithEvents TitleLabel As System.Windows.Forms.Label
        Friend WithEvents SubtitleLabel As System.Windows.Forms.Label
        Friend WithEvents DisplayNameLabel As System.Windows.Forms.Label
        Friend WithEvents DisplayNameTextBox As System.Windows.Forms.TextBox
        Friend WithEvents EmailLabel As System.Windows.Forms.Label
        Friend WithEvents EmailTextBox As System.Windows.Forms.TextBox
        Friend WithEvents PasswordLabel As System.Windows.Forms.Label
        Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
        Friend WithEvents SubmitButton As System.Windows.Forms.Button
        Friend WithEvents StatusLabel As System.Windows.Forms.Label
        Friend WithEvents ToggleButton As System.Windows.Forms.Button
    End Class
End Namespace
