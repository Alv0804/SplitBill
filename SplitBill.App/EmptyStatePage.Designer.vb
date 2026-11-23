Namespace Global.SplitBill.App
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class EmptyStatePage
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
            Me.ContentLayout = New System.Windows.Forms.FlowLayoutPanel()
            Me.TitleLabel = New System.Windows.Forms.Label()
            Me.DescriptionLabel = New System.Windows.Forms.Label()
            Me.BackButton = New System.Windows.Forms.Button()
            Me.CenterLayout.SuspendLayout()
            Me.CardPanel.SuspendLayout()
            Me.ContentLayout.SuspendLayout()
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
            Me.CenterLayout.Size = New System.Drawing.Size(800, 600)
            Me.CenterLayout.TabIndex = 0
            '
            'CardPanel
            '
            Me.CardPanel.Anchor = System.Windows.Forms.AnchorStyles.None
            Me.CardPanel.AutoSize = True
            Me.CardPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.CardPanel.BackColor = System.Drawing.Color.White
            Me.CardPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.CardPanel.Controls.Add(Me.ContentLayout)
            Me.CardPanel.Location = New System.Drawing.Point(60, 120)
            Me.CardPanel.MaximumSize = New System.Drawing.Size(680, 360)
            Me.CardPanel.Name = "CardPanel"
            Me.CardPanel.Padding = New System.Windows.Forms.Padding(32)
            Me.CardPanel.Size = New System.Drawing.Size(586, 178)
            Me.CardPanel.TabIndex = 0
            '
            'ContentLayout
            '
            Me.ContentLayout.AutoSize = True
            Me.ContentLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.ContentLayout.BackColor = System.Drawing.Color.White
            Me.ContentLayout.Controls.Add(Me.TitleLabel)
            Me.ContentLayout.Controls.Add(Me.DescriptionLabel)
            Me.ContentLayout.Controls.Add(Me.BackButton)
            Me.ContentLayout.Dock = System.Windows.Forms.DockStyle.Fill
            Me.ContentLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
            Me.ContentLayout.Location = New System.Drawing.Point(32, 32)
            Me.ContentLayout.Name = "ContentLayout"
            Me.ContentLayout.Size = New System.Drawing.Size(520, 112)
            Me.ContentLayout.TabIndex = 0
            Me.ContentLayout.WrapContents = False
            '
            'TitleLabel
            '
            Me.TitleLabel.AutoSize = True
            Me.TitleLabel.Font = New System.Drawing.Font("Segoe UI", 20.0F, System.Drawing.FontStyle.Bold)
            Me.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(29, 36, 32)
            Me.TitleLabel.Location = New System.Drawing.Point(0, 0)
            Me.TitleLabel.Margin = New System.Windows.Forms.Padding(0, 0, 0, 12)
            Me.TitleLabel.Name = "TitleLabel"
            Me.TitleLabel.Size = New System.Drawing.Size(184, 37)
            Me.TitleLabel.TabIndex = 0
            Me.TitleLabel.Text = "Halaman Kosong"
            '
            'DescriptionLabel
            '
            Me.DescriptionLabel.AutoSize = True
            Me.DescriptionLabel.Font = New System.Drawing.Font("Segoe UI", 10.0F)
            Me.DescriptionLabel.ForeColor = System.Drawing.Color.FromArgb(107, 114, 128)
            Me.DescriptionLabel.Location = New System.Drawing.Point(0, 49)
            Me.DescriptionLabel.Margin = New System.Windows.Forms.Padding(0, 0, 0, 20)
            Me.DescriptionLabel.MaximumSize = New System.Drawing.Size(520, 0)
            Me.DescriptionLabel.Name = "DescriptionLabel"
            Me.DescriptionLabel.Size = New System.Drawing.Size(264, 19)
            Me.DescriptionLabel.TabIndex = 1
            Me.DescriptionLabel.Text = "Tidak ada informasi yang dapat ditampilkan."
            '
            'BackButton
            '
            Me.BackButton.BackColor = System.Drawing.Color.FromArgb(47, 107, 79)
            Me.BackButton.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BackButton.FlatAppearance.BorderSize = 0
            Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.BackButton.Font = New System.Drawing.Font("Segoe UI", 9.0F, System.Drawing.FontStyle.Bold)
            Me.BackButton.ForeColor = System.Drawing.Color.White
            Me.BackButton.Location = New System.Drawing.Point(0, 92)
            Me.BackButton.Margin = New System.Windows.Forms.Padding(0, 4, 0, 0)
            Me.BackButton.Name = "BackButton"
            Me.BackButton.Size = New System.Drawing.Size(180, 42)
            Me.BackButton.TabIndex = 2
            Me.BackButton.Text = "Kembali ke Dashboard"
            Me.BackButton.UseVisualStyleBackColor = False
            '
            'EmptyStatePage
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0F, 15.0F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.FromArgb(246, 248, 246)
            Me.Controls.Add(Me.CenterLayout)
            Me.Font = New System.Drawing.Font("Segoe UI", 9.0F)
            Me.Name = "EmptyStatePage"
            Me.Size = New System.Drawing.Size(800, 600)
            Me.CenterLayout.ResumeLayout(False)
            Me.CenterLayout.PerformLayout()
            Me.CardPanel.ResumeLayout(False)
            Me.CardPanel.PerformLayout()
            Me.ContentLayout.ResumeLayout(False)
            Me.ContentLayout.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

        Friend WithEvents CenterLayout As System.Windows.Forms.TableLayoutPanel
        Friend WithEvents CardPanel As System.Windows.Forms.Panel
        Friend WithEvents ContentLayout As System.Windows.Forms.FlowLayoutPanel
        Friend WithEvents TitleLabel As System.Windows.Forms.Label
        Friend WithEvents DescriptionLabel As System.Windows.Forms.Label
        Friend WithEvents BackButton As System.Windows.Forms.Button
    End Class
End Namespace
