Option Explicit On
Option Strict On
Option Infer On

Imports System
Imports System.Text.Json.Serialization

Namespace Global.SplitBill.Data
    Public NotInheritable Class SupabaseSession
        Friend Sub New(accessToken As String, refreshToken As String, expiresIn As Integer, userId As Guid, email As String)
            Me.AccessToken = accessToken
            Me.RefreshToken = refreshToken
            Me.ExpiresIn = expiresIn
            Me.UserId = userId
            Me.Email = email
            Me.ExpiresAtUtc = DateTimeOffset.UtcNow.AddSeconds(expiresIn)
        End Sub

        Public ReadOnly Property AccessToken As String
        Public ReadOnly Property RefreshToken As String
        Public ReadOnly Property ExpiresIn As Integer
        Public ReadOnly Property UserId As Guid
        Public ReadOnly Property Email As String
        Public ReadOnly Property ExpiresAtUtc As DateTimeOffset
    End Class

    Friend NotInheritable Class SupabaseAuthResponse
        <JsonPropertyName("access_token")>
        Public Property AccessToken As String

        <JsonPropertyName("refresh_token")>
        Public Property RefreshToken As String

        <JsonPropertyName("expires_in")>
        Public Property ExpiresIn As Integer

        <JsonPropertyName("user")>
        Public Property User As SupabaseAuthUser
    End Class

    Friend NotInheritable Class SupabaseAuthUser
        <JsonPropertyName("id")>
        Public Property Id As Guid

        <JsonPropertyName("email")>
        Public Property Email As String
    End Class
End Namespace
