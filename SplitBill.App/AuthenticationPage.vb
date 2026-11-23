Option Explicit On
Option Strict On
Option Infer On

Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace Global.SplitBill.App
    Public NotInheritable Class AuthenticationRequestEventArgs
        Inherits EventArgs

        Public Sub New(createAccount As Boolean, displayName As String, email As String, password As String)
            Me.CreateAccount = createAccount
            Me.DisplayName = displayName
            Me.Email = email
            Me.Password = password
        End Sub

        Public ReadOnly Property CreateAccount As Boolean
        Public ReadOnly Property DisplayName As String
        Public ReadOnly Property Email As String
        Public ReadOnly Property Password As String
    End Class

    Partial Class AuthenticationPage
        Private _createAccount As Boolean

        Public Sub New()
            InitializeComponent()
            AddHandler SubmitButton.Click, AddressOf Submit
            AddHandler ToggleButton.Click, AddressOf ToggleMode
            SetCreateAccountMode(False)
        End Sub

        Public Event AuthenticationRequested As EventHandler(Of AuthenticationRequestEventArgs)

        Public Sub SetBusy(isBusy As Boolean)
            DisplayNameTextBox.Enabled = Not isBusy
            EmailTextBox.Enabled = Not isBusy
            PasswordTextBox.Enabled = Not isBusy
            SubmitButton.Enabled = Not isBusy
            ToggleButton.Enabled = Not isBusy
            If isBusy Then
                SetStatus("Memproses...", False)
            End If
        End Sub

        Public Sub ResetForm()
            SetBusy(False)
            PasswordTextBox.Clear()
            SetStatus(String.Empty, False)
        End Sub

        Public Sub SetStatus(message As String, isError As Boolean)
            StatusLabel.Text = If(message, String.Empty)
            StatusLabel.ForeColor = If(isError, UiTheme.ErrorColor, UiTheme.PrimaryDarkColor)
        End Sub

        Private Sub ToggleMode(sender As Object, e As EventArgs)
            SetCreateAccountMode(Not _createAccount)
            SetStatus(String.Empty, False)
        End Sub

        Private Sub SetCreateAccountMode(createAccount As Boolean)
            _createAccount = createAccount
            DisplayNameLabel.Visible = createAccount
            DisplayNameTextBox.Visible = createAccount
            SubmitButton.Text = If(createAccount, "Buat akun", "Masuk")
            ToggleButton.Text = If(createAccount, "Sudah punya akun? Masuk", "Belum punya akun? Daftar")
        End Sub

        Private Sub Submit(sender As Object, e As EventArgs)
            Dim email = EmailTextBox.Text.Trim()
            Dim password = PasswordTextBox.Text
            Dim name = DisplayNameTextBox.Text.Trim()

            If _createAccount Then
                If String.IsNullOrWhiteSpace(name) Then
                    SetStatus("Nama lengkap wajib diisi.", True)
                    DisplayNameTextBox.Focus()
                    Return
                End If
                If name.Length < 2 Then
                    SetStatus("Nama minimal 2 karakter.", True)
                    DisplayNameTextBox.Focus()
                    Return
                End If
            End If

            If String.IsNullOrWhiteSpace(email) Then
                SetStatus("Alamat email tidak boleh kosong.", True)
                EmailTextBox.Focus()
                Return
            End If

            If Not email.Contains("@", StringComparison.Ordinal) OrElse Not email.Contains(".", StringComparison.Ordinal) Then
                SetStatus("Format alamat email tidak valid (contoh: user@gmail.com).", True)
                EmailTextBox.Focus()
                Return
            End If

            If String.IsNullOrWhiteSpace(password) Then
                SetStatus("Kata sandi tidak boleh kosong.", True)
                PasswordTextBox.Focus()
                Return
            End If

            If password.Length < 6 Then
                SetStatus("Kata sandi minimal 6 karakter.", True)
                PasswordTextBox.Focus()
                Return
            End If

            SetStatus(String.Empty, False)
            RaiseEvent AuthenticationRequested(Me, New AuthenticationRequestEventArgs(_createAccount, name, email, password))
        End Sub
    End Class
End Namespace
