Option Explicit On
Option Strict On
Option Infer On

Imports System
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks

Namespace Global.SplitBill.App
    Public NotInheritable Class SecureRefreshTokenStore
        Private ReadOnly _filePath As String

        Public Sub New(Optional filePath As String = Nothing)
            _filePath = If(filePath, Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "SplitBill", "refresh-token.bin"))
        End Sub

        Public Async Function SaveAsync(refreshToken As String, cancellationToken As CancellationToken) As Task
            If String.IsNullOrWhiteSpace(refreshToken) Then Throw New ArgumentException("Refresh token tidak valid.", NameOf(refreshToken))
            Dim encrypted = ProtectedData.Protect(Encoding.UTF8.GetBytes(refreshToken), Nothing, DataProtectionScope.CurrentUser)
            Dim directoryPath = Path.GetDirectoryName(_filePath)
            If String.IsNullOrWhiteSpace(directoryPath) Then Throw New InvalidOperationException("Lokasi penyimpanan token tidak valid.")
            Directory.CreateDirectory(directoryPath)

            Dim temporaryPath = _filePath & "." & Guid.NewGuid().ToString("N") & ".tmp"
            Try
                Await File.WriteAllBytesAsync(temporaryPath, encrypted, cancellationToken).ConfigureAwait(False)
                File.Move(temporaryPath, _filePath, True)
            Finally
                If File.Exists(temporaryPath) Then File.Delete(temporaryPath)
            End Try
        End Function

        Public Async Function LoadAsync(cancellationToken As CancellationToken) As Task(Of String)
            If Not File.Exists(_filePath) Then Return Nothing
            Dim encrypted = Await File.ReadAllBytesAsync(_filePath, cancellationToken).ConfigureAwait(False)
            Dim clearBytes = ProtectedData.Unprotect(encrypted, Nothing, DataProtectionScope.CurrentUser)
            Return Encoding.UTF8.GetString(clearBytes)
        End Function

        Public Sub Delete()
            If File.Exists(_filePath) Then File.Delete(_filePath)
        End Sub
    End Class
End Namespace
