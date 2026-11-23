Option Explicit On
Option Strict On
Option Infer On

Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace Global.SplitBill.App
    Partial Class EmptyStatePage
        Public Sub New()
            InitializeComponent()
            AddHandler BackButton.Click, Sub(sender, args) RaiseEvent BackToDashboardRequested(Me, EventArgs.Empty)
        End Sub

        Public Sub New(title As String, description As String)
            Me.New()
            TitleLabel.Text = title
            DescriptionLabel.Text = description
        End Sub

        Public Event BackToDashboardRequested As EventHandler
    End Class
End Namespace
