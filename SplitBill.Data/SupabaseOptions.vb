Option Explicit On
Option Strict On
Option Infer On

Imports System
Imports System.IO
Imports System.Text
Imports System.Text.Json

Namespace Global.SplitBill.Data
    Public NotInheritable Class SupabaseOptions
        Public Sub New(baseUrl As String, anonKey As String)
            Dim parsedUri As Uri = Nothing
            If Not Uri.TryCreate(baseUrl, UriKind.Absolute, parsedUri) OrElse (parsedUri.Scheme <> Uri.UriSchemeHttps AndAlso parsedUri.Scheme <> Uri.UriSchemeHttp) Then
                Throw New ArgumentException("URL Supabase harus berupa alamat HTTP atau HTTPS.", NameOf(baseUrl))
            End If
            If parsedUri.Scheme = Uri.UriSchemeHttp AndAlso Not (parsedUri.IsLoopback OrElse parsedUri.Host.Equals("localhost", StringComparison.OrdinalIgnoreCase)) Then
                Throw New ArgumentException("HTTP hanya diizinkan untuk Supabase lokal.", NameOf(baseUrl))
            End If
            If String.IsNullOrWhiteSpace(anonKey) Then Throw New ArgumentException("Supabase anon/publishable key wajib diisi.", NameOf(anonKey))
            If IsServiceRoleKey(anonKey) Then
                Throw New ArgumentException("Service role key tidak boleh digunakan oleh aplikasi desktop.", NameOf(anonKey))
            End If

            Me.BaseUri = New Uri(If(baseUrl.EndsWith("/", StringComparison.Ordinal), baseUrl, baseUrl & "/"), UriKind.Absolute)
            Me.AnonKey = anonKey.Trim()
        End Sub

        Public ReadOnly Property BaseUri As Uri
        Public ReadOnly Property AnonKey As String

        Public Shared Function GetConfigFilePath() As String
            Dim localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
            Return Path.Combine(localAppData, "SplitBill", "supabase.config.json")
        End Function

        Public Shared Function GetSavedUrl() As String
            Dim url = Environment.GetEnvironmentVariable("SPLITBILL_SUPABASE_URL", EnvironmentVariableTarget.Process)
            If Not String.IsNullOrWhiteSpace(url) Then Return url
            url = Environment.GetEnvironmentVariable("SPLITBILL_SUPABASE_URL", EnvironmentVariableTarget.User)
            If Not String.IsNullOrWhiteSpace(url) Then Return url
            Dim configPath = GetConfigFilePath()
            If File.Exists(configPath) Then
                Try
                    Dim json = File.ReadAllText(configPath, Encoding.UTF8)
                    Using doc = JsonDocument.Parse(json)
                        Dim prop As JsonElement
                        If doc.RootElement.TryGetProperty("url", prop) AndAlso prop.ValueKind = JsonValueKind.String Then
                            Return prop.GetString()
                        End If
                    End Using
                Catch
                End Try
            End If
            Return "https://pjaddroobmvovqmmdyip.supabase.co"
        End Function

        Public Shared Function FromEnvironment() As SupabaseOptions
            ' 1. Check Process environment
            Dim baseUrl = Environment.GetEnvironmentVariable("SPLITBILL_SUPABASE_URL", EnvironmentVariableTarget.Process)
            Dim anonKey = Environment.GetEnvironmentVariable("SPLITBILL_SUPABASE_ANON_KEY", EnvironmentVariableTarget.Process)

            ' 2. Check User environment
            If String.IsNullOrWhiteSpace(baseUrl) Then
                baseUrl = Environment.GetEnvironmentVariable("SPLITBILL_SUPABASE_URL", EnvironmentVariableTarget.User)
            End If
            If String.IsNullOrWhiteSpace(anonKey) Then
                anonKey = Environment.GetEnvironmentVariable("SPLITBILL_SUPABASE_ANON_KEY", EnvironmentVariableTarget.User)
            End If

            ' 3. Check Machine environment
            If String.IsNullOrWhiteSpace(baseUrl) Then
                baseUrl = Environment.GetEnvironmentVariable("SPLITBILL_SUPABASE_URL", EnvironmentVariableTarget.Machine)
            End If
            If String.IsNullOrWhiteSpace(anonKey) Then
                anonKey = Environment.GetEnvironmentVariable("SPLITBILL_SUPABASE_ANON_KEY", EnvironmentVariableTarget.Machine)
            End If

            ' 4. Check local config file in LocalApplicationData
            If String.IsNullOrWhiteSpace(baseUrl) OrElse String.IsNullOrWhiteSpace(anonKey) Then
                Dim configPath = GetConfigFilePath()
                If File.Exists(configPath) Then
                    Try
                        Dim json = File.ReadAllText(configPath, Encoding.UTF8)
                        Using doc = JsonDocument.Parse(json)
                            Dim root = doc.RootElement
                            Dim prop As JsonElement
                            If String.IsNullOrWhiteSpace(baseUrl) AndAlso root.TryGetProperty("url", prop) AndAlso prop.ValueKind = JsonValueKind.String Then
                                baseUrl = prop.GetString()
                            End If
                            If String.IsNullOrWhiteSpace(anonKey) AndAlso root.TryGetProperty("anonKey", prop) AndAlso prop.ValueKind = JsonValueKind.String Then
                                anonKey = prop.GetString()
                            End If
                        End Using
                    Catch
                    End Try
                End If
            End If

            ' 5. Check local .env file in base directory or repo
            If String.IsNullOrWhiteSpace(baseUrl) OrElse String.IsNullOrWhiteSpace(anonKey) Then
                Try
                    Dim envPaths = {
                        Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ".env"),
                        Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", ".env"),
                        Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..", "..", "..", "..", ".env")
                    }
                    For Each ep In envPaths
                        If File.Exists(ep) Then
                            For Each line In File.ReadAllLines(ep)
                                Dim trimmed = line.Trim()
                                If trimmed.StartsWith("SPLITBILL_SUPABASE_URL=", StringComparison.OrdinalIgnoreCase) Then
                                    If String.IsNullOrWhiteSpace(baseUrl) Then baseUrl = trimmed.Substring("SPLITBILL_SUPABASE_URL=".Length).Trim(""""c, "'"c)
                                ElseIf trimmed.StartsWith("SPLITBILL_SUPABASE_ANON_KEY=", StringComparison.OrdinalIgnoreCase) Then
                                    If String.IsNullOrWhiteSpace(anonKey) Then anonKey = trimmed.Substring("SPLITBILL_SUPABASE_ANON_KEY=".Length).Trim(""""c, "'"c)
                                End If
                            Next
                            If Not String.IsNullOrWhiteSpace(baseUrl) AndAlso Not String.IsNullOrWhiteSpace(anonKey) Then Exit For
                        End If
                    Next
                Catch
                End Try
            End If

            ' Default project URL and publishable key fallback if not set
            If String.IsNullOrWhiteSpace(baseUrl) Then
                baseUrl = "https://pjaddroobmvovqmmdyip.supabase.co"
            End If

            If String.IsNullOrWhiteSpace(anonKey) Then
                anonKey = "sb_publishable_S652thPhJjl4WLFfv8rE_Q_NqG12yXu"
            End If
            Return New SupabaseOptions(baseUrl, anonKey)
        End Function

        Public Shared Sub SaveConfig(baseUrl As String, anonKey As String)
            If String.IsNullOrWhiteSpace(baseUrl) Then Throw New ArgumentException("URL Supabase wajib diisi.", NameOf(baseUrl))
            If String.IsNullOrWhiteSpace(anonKey) Then Throw New ArgumentException("Anon Key wajib diisi.", NameOf(anonKey))

            ' Set process environment variables immediately
            Environment.SetEnvironmentVariable("SPLITBILL_SUPABASE_URL", baseUrl.Trim(), EnvironmentVariableTarget.Process)
            Environment.SetEnvironmentVariable("SPLITBILL_SUPABASE_ANON_KEY", anonKey.Trim(), EnvironmentVariableTarget.Process)

            ' Try setting user environment variables
            Try
                Environment.SetEnvironmentVariable("SPLITBILL_SUPABASE_URL", baseUrl.Trim(), EnvironmentVariableTarget.User)
                Environment.SetEnvironmentVariable("SPLITBILL_SUPABASE_ANON_KEY", anonKey.Trim(), EnvironmentVariableTarget.User)
            Catch
            End Try

            ' Save to LocalAppData
            Try
                Dim configPath = GetConfigFilePath()
                Dim dir = Path.GetDirectoryName(configPath)
                If Not Directory.Exists(dir) Then Directory.CreateDirectory(dir)
                Dim payload = JsonSerializer.Serialize(New With {.url = baseUrl.Trim(), .anonKey = anonKey.Trim()})
                File.WriteAllText(configPath, payload, Encoding.UTF8)
            Catch
            End Try
        End Sub

        Private Shared Function IsServiceRoleKey(key As String) As Boolean
            If key.StartsWith("sb_secret_", StringComparison.OrdinalIgnoreCase) OrElse key.Contains("service_role", StringComparison.OrdinalIgnoreCase) Then Return True
            Dim segments = key.Split("."c)
            If segments.Length <> 3 Then Return False
            Try
                Dim payload = segments(1).Replace("-", "+").Replace("_", "/")
                payload &= New String("="c, (4 - payload.Length Mod 4) Mod 4)
                Using document = JsonDocument.Parse(Encoding.UTF8.GetString(Convert.FromBase64String(payload)))
                    Dim role As JsonElement
                    Return document.RootElement.TryGetProperty("role", role) AndAlso role.ValueKind = JsonValueKind.String AndAlso String.Equals(role.GetString(), "service_role", StringComparison.OrdinalIgnoreCase)
                End Using
            Catch ex As FormatException
                Return False
            Catch ex As JsonException
                Return False
            End Try
        End Function
    End Class
End Namespace
