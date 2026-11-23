Option Explicit On
Option Strict On
Option Infer On

Imports System
Imports System.Text.Json
Imports System.Threading
Imports System.Windows.Forms
Imports SplitBill.Data

Namespace Global.SplitBill.App
    Partial Class JoinGroupDialog
        Private ReadOnly _repository As SplitBillRepository
        Private ReadOnly _session As SupabaseSession
        Private _joinedGroupId As Guid?
        Private _joinedGroupName As String

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub New(repository As SplitBillRepository, session As SupabaseSession, defaultDisplayName As String)
            Me.New()
            _repository = repository
            _session = session

            If Not String.IsNullOrWhiteSpace(defaultDisplayName) Then
                TxtName.Text = defaultDisplayName.Trim()
            End If
        End Sub

        Public ReadOnly Property JoinedGroupId As Guid?
            Get
                Return _joinedGroupId
            End Get
        End Property

        Public ReadOnly Property JoinedGroupName As String
            Get
                Return _joinedGroupName
            End Get
        End Property

        Private Async Sub BtnJoin_Click(sender As Object, e As EventArgs) Handles BtnJoin.Click
            Dim code = TxtCode.Text.Trim().ToUpperInvariant()
            Dim name = TxtName.Text.Trim()

            ' Validation
            If String.IsNullOrWhiteSpace(code) Then
                LblValidation.Text = "Kode undangan tidak boleh kosong."
                TxtCode.Focus()
                Return
            End If

            If code.Length < 4 Then
                LblValidation.Text = "Format kode undangan tidak valid."
                TxtCode.Focus()
                Return
            End If

            If String.IsNullOrWhiteSpace(name) Then
                LblValidation.Text = "Nama Anda tidak boleh kosong."
                TxtName.Focus()
                Return
            End If

            If name.Length < 2 Then
                LblValidation.Text = "Nama Anda minimal 2 karakter."
                TxtName.Focus()
                Return
            End If

            LblValidation.Text = String.Empty
            BtnJoin.Enabled = False
            BtnJoin.Text = "Memproses..."

            Try
                Dim result = Await _repository.JoinGroupWithCodeAsync(_session, code, name, CancellationToken.None)
                Dim success = False
                Dim message = "Gagal bergabung."

                If result.TryGetProperty("success", Nothing) Then
                    success = result.GetProperty("success").GetBoolean()
                End If

                If result.TryGetProperty("message", Nothing) Then
                    message = result.GetProperty("message").GetString()
                End If

                If success Then
                    If result.TryGetProperty("groupId", Nothing) Then
                        _joinedGroupId = Guid.Parse(result.GetProperty("groupId").GetString())
                    End If
                    If result.TryGetProperty("groupName", Nothing) Then
                        _joinedGroupName = result.GetProperty("groupName").GetString()
                    End If
                    DialogResult = DialogResult.OK
                    Close()
                Else
                    LblValidation.Text = message
                    BtnJoin.Enabled = True
                    BtnJoin.Text = "Gabung Sekarang"
                End If
            Catch ex As Exception
                LblValidation.Text = ex.Message
                BtnJoin.Enabled = True
                BtnJoin.Text = "Gabung Sekarang"
            End Try
        End Sub
    End Class
End Namespace

