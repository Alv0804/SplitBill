Option Explicit On
Option Strict On
Option Infer On

Imports System
Imports System.Linq
Imports System.Net
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Text
Imports System.Text.Json
Imports System.Threading
Imports System.Threading.Tasks

Namespace Global.SplitBill.Data
    Public NotInheritable Class SupabaseClient
        Implements IDisposable

        Private Shared ReadOnly SerializerOptions As New JsonSerializerOptions With {
            .PropertyNameCaseInsensitive = True,
            .PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        }

        Private ReadOnly _options As SupabaseOptions
        Private ReadOnly _httpClient As HttpClient
        Private ReadOnly _ownsHttpClient As Boolean

        Public Sub New(options As SupabaseOptions, Optional httpClient As HttpClient = Nothing)
            If options Is Nothing Then Throw New ArgumentNullException(NameOf(options))
            _options = options
            _ownsHttpClient = (httpClient Is Nothing)
            _httpClient = If(httpClient, New HttpClient())
        End Sub

        Public Async Function SignInWithPasswordAsync(email As String, password As String, cancellationToken As CancellationToken) As Task(Of SupabaseSession)
            If String.IsNullOrWhiteSpace(email) Then Throw New ArgumentException("Email wajib diisi.", NameOf(email))
            If String.IsNullOrEmpty(password) Then Throw New ArgumentException("Kata sandi wajib diisi.", NameOf(password))
            Dim body = New With {.email = email.Trim(), .password = password}
            Dim response = Await SendJsonAsync(Of SupabaseAuthResponse)(HttpMethod.Post, "auth/v1/token?grant_type=password", Nothing, body, cancellationToken).ConfigureAwait(False)
            Return CreateSession(response, "Email atau kata sandi tidak valid.")
        End Function

        Public Async Function SignUpAsync(email As String, password As String, displayName As String, cancellationToken As CancellationToken) As Task(Of SupabaseSession)
            If String.IsNullOrWhiteSpace(email) Then Throw New ArgumentException("Email wajib diisi.", NameOf(email))
            If String.IsNullOrEmpty(password) Then Throw New ArgumentException("Kata sandi wajib diisi.", NameOf(password))
            If String.IsNullOrWhiteSpace(displayName) Then Throw New ArgumentException("Nama pengguna wajib diisi.", NameOf(displayName))
            Dim body = New With {
                .email = email.Trim(),
                .password = password,
                .data = New With {.display_name = displayName.Trim()}
            }
            Dim response = Await SendJsonAsync(Of SupabaseAuthResponse)(HttpMethod.Post, "auth/v1/signup", Nothing, body, cancellationToken).ConfigureAwait(False)
            Return CreateSession(response, "Pendaftaran berhasil. Periksa email untuk menyelesaikan verifikasi.")
        End Function

        Public Async Function RefreshSessionAsync(refreshToken As String, cancellationToken As CancellationToken) As Task(Of SupabaseSession)
            If String.IsNullOrWhiteSpace(refreshToken) Then Throw New ArgumentException("Refresh token tidak tersedia.", NameOf(refreshToken))
            Dim body = New With {.refresh_token = refreshToken}
            Dim response = Await SendJsonAsync(Of SupabaseAuthResponse)(HttpMethod.Post, "auth/v1/token?grant_type=refresh_token", Nothing, body, cancellationToken).ConfigureAwait(False)
            Return CreateSession(response, "Sesi login telah berakhir. Silakan login kembali.")
        End Function

        Public Async Function SignOutAsync(accessToken As String, cancellationToken As CancellationToken) As Task
            Await SendJsonAsync(Of JsonElement)(HttpMethod.Post, "auth/v1/logout?scope=local", accessToken, Nothing, cancellationToken).ConfigureAwait(False)
        End Function

        Public Async Function RpcAsync(Of TResponse)(functionName As String, parameters As Object, accessToken As String, cancellationToken As CancellationToken) As Task(Of TResponse)
            If String.IsNullOrWhiteSpace(functionName) OrElse Not functionName.All(Function(character) Char.IsLetterOrDigit(character) OrElse character = "_"c) Then
                Throw New ArgumentException("Nama fungsi RPC tidak valid.", NameOf(functionName))
            End If
            Return Await SendJsonAsync(Of TResponse)(HttpMethod.Post, "rest/v1/rpc/" & Uri.EscapeDataString(functionName), accessToken, parameters, cancellationToken).ConfigureAwait(False)
        End Function

        Public Async Function GetResourceAsync(Of TResponse)(resourceAndQuery As String, accessToken As String, cancellationToken As CancellationToken) As Task(Of TResponse)
            ValidateResourcePath(resourceAndQuery)
            Return Await SendJsonAsync(Of TResponse)(HttpMethod.Get, "rest/v1/" & resourceAndQuery, accessToken, Nothing, cancellationToken).ConfigureAwait(False)
        End Function

        Public Async Function InsertResourceAsync(Of TResponse)(resource As String, payload As Object, accessToken As String, cancellationToken As CancellationToken) As Task(Of TResponse)
            ValidateResourcePath(resource)
            Return Await SendJsonAsync(Of TResponse)(HttpMethod.Post, "rest/v1/" & resource, accessToken, payload, cancellationToken, "return=representation").ConfigureAwait(False)
        End Function

        Public Async Function UpdateResourceAsync(Of TResponse)(resourceAndQuery As String, payload As Object, accessToken As String, cancellationToken As CancellationToken) As Task(Of TResponse)
            ValidateResourcePath(resourceAndQuery)
            Return Await SendJsonAsync(Of TResponse)(HttpMethod.Patch, "rest/v1/" & resourceAndQuery, accessToken, payload, cancellationToken, "return=representation").ConfigureAwait(False)
        End Function

        Public Async Function DeleteResourceAsync(resourceAndQuery As String, accessToken As String, cancellationToken As CancellationToken) As Task
            ValidateResourcePath(resourceAndQuery)
            Await SendJsonAsync(Of JsonElement)(HttpMethod.Delete, "rest/v1/" & resourceAndQuery, accessToken, Nothing, cancellationToken).ConfigureAwait(False)
        End Function

        Private Async Function SendJsonAsync(Of TResponse)(method As HttpMethod, relativePath As String, accessToken As String, payload As Object, cancellationToken As CancellationToken, Optional prefer As String = Nothing) As Task(Of TResponse)
            Using request As New HttpRequestMessage(method, New Uri(_options.BaseUri, relativePath))
                request.Headers.TryAddWithoutValidation("apikey", _options.AnonKey)
                If Not String.IsNullOrWhiteSpace(accessToken) Then request.Headers.Authorization = New AuthenticationHeaderValue("Bearer", accessToken)
                If Not String.IsNullOrWhiteSpace(prefer) Then request.Headers.TryAddWithoutValidation("Prefer", prefer)
                If payload IsNot Nothing Then
                    Dim json = JsonSerializer.Serialize(payload, payload.GetType(), SerializerOptions)
                    request.Content = New StringContent(json, Encoding.UTF8, "application/json")
                End If

                Using response = Await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(False)
                    Dim responseBody = If(response.Content Is Nothing, String.Empty, Await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(False))
                    If Not response.IsSuccessStatusCode Then
                        Throw New SupabaseRequestException(response.StatusCode, ExtractErrorMessage(responseBody, response.StatusCode))
                    End If
                    If String.IsNullOrWhiteSpace(responseBody) Then Return Nothing
                    Return JsonSerializer.Deserialize(Of TResponse)(responseBody, SerializerOptions)
                End Using
            End Using
        End Function

        Private Shared Function CreateSession(response As SupabaseAuthResponse, noSessionMessage As String) As SupabaseSession
            If response Is Nothing OrElse String.IsNullOrWhiteSpace(response.AccessToken) OrElse String.IsNullOrWhiteSpace(response.RefreshToken) OrElse response.User Is Nothing OrElse response.User.Id = Guid.Empty Then
                Throw New SupabaseRequestException(HttpStatusCode.Accepted, noSessionMessage)
            End If
            Return New SupabaseSession(response.AccessToken, response.RefreshToken, response.ExpiresIn, response.User.Id, If(response.User.Email, String.Empty))
        End Function

        Private Shared Sub ValidateResourcePath(resourceAndQuery As String)
            If String.IsNullOrWhiteSpace(resourceAndQuery) OrElse resourceAndQuery.StartsWith("/", StringComparison.Ordinal) OrElse resourceAndQuery.Contains("..", StringComparison.Ordinal) Then
                Throw New ArgumentException("Jalur PostgREST tidak valid.", NameOf(resourceAndQuery))
            End If
        End Sub

        Private Shared Function ExtractErrorMessage(responseBody As String, statusCode As HttpStatusCode) As String
            If Not String.IsNullOrWhiteSpace(responseBody) Then
                Try
                    Using document = JsonDocument.Parse(responseBody)
                        For Each propertyName In {"message", "msg", "error_description", "error"}
                            Dim value As JsonElement
                            If document.RootElement.ValueKind = JsonValueKind.Object AndAlso document.RootElement.TryGetProperty(propertyName, value) AndAlso value.ValueKind = JsonValueKind.String Then
                                Return value.GetString()
                            End If
                        Next
                    End Using
                Catch ex As JsonException
                End Try
            End If
            Return $"Permintaan Supabase gagal ({CInt(statusCode)})."
        End Function

        Public Sub Dispose() Implements IDisposable.Dispose
            If _ownsHttpClient Then _httpClient.Dispose()
        End Sub
    End Class

    Public NotInheritable Class SupabaseRequestException
        Inherits Exception

        Public Sub New(statusCode As HttpStatusCode, message As String)
            MyBase.New(message)
            Me.StatusCode = statusCode
        End Sub

        Public ReadOnly Property StatusCode As HttpStatusCode
    End Class
End Namespace
