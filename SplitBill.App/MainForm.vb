Option Explicit On
Option Strict On
Option Infer On

Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Text.Json.Serialization
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports SplitBill.Data

Namespace Global.SplitBill.App
    Partial Class MainForm
        Inherits Form

        Private ReadOnly _tokenStore As New SecureRefreshTokenStore()
        Private ReadOnly _authenticationPage As AuthenticationPage
        Private ReadOnly _menuButtons As New Dictionary(Of String, Button)(StringComparer.OrdinalIgnoreCase)

        Private _supabase As SupabaseClient
        Private _repository As SplitBillRepository
        Private _session As SupabaseSession
        Private _displayName As String
        Private _currentActiveMenu As String = "Dashboard"

        Public Sub New()
            ' This call is required by the Windows Form Designer.
            InitializeComponent()

            ' Initialize Supabase backend client
            InitializeSupabaseClient()

            ' Wire up designer sidebar controls
            WireSidebarControls()

            ' Setup authentication page
            _authenticationPage = New AuthenticationPage()
            AddHandler _authenticationPage.AuthenticationRequested, AddressOf HandleAuthenticationAsync
            AddHandler Shown, AddressOf RestoreSessionAsync
            AddHandler FormClosed, AddressOf FormClosedHandler

            ShowAuthenticationPage()
        End Sub

        Private Function InitializeSupabaseClient() As Boolean
            Try
                If _supabase IsNot Nothing Then
                    _supabase.Dispose()
                    _supabase = Nothing
                End If
                _supabase = New SupabaseClient(SupabaseOptions.FromEnvironment())
                _repository = New SplitBillRepository(_supabase)
                Return True
            Catch
                Return False
            End Try
        End Function

        Private Sub WireSidebarControls()
            SidebarPanel.AutoScroll = False
            SidebarLayout.AutoScroll = False
            MenuContainer.AutoScroll = False

            _menuButtons("Dashboard") = BtnNavDashboard
            _menuButtons("Kegiatan") = BtnNavKegiatan
            _menuButtons("Teman") = BtnNavTeman
            _menuButtons("Tempat") = BtnNavTempat
            _menuButtons("Riwayat") = BtnNavRiwayat

            AddHandler BtnNavDashboard.Click, Sub(s, e) NavigateTo("Dashboard")
            AddHandler BtnNavKegiatan.Click, Sub(s, e) NavigateTo("Kegiatan")
            AddHandler BtnNavTeman.Click, Sub(s, e) NavigateTo("Teman")
            AddHandler BtnNavTempat.Click, Sub(s, e) NavigateTo("Tempat")
            AddHandler BtnNavRiwayat.Click, Sub(s, e) NavigateTo("Riwayat")

            SignOutButton.FlatAppearance.BorderSize = 1
            SignOutButton.FlatAppearance.BorderColor = Color.FromArgb(254, 202, 202)
            SignOutButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(239, 68, 68)
            AddHandler SignOutButton.MouseEnter, Sub(s, e) SignOutButton.ForeColor = Color.White
            AddHandler SignOutButton.MouseLeave, Sub(s, e) SignOutButton.ForeColor = UiTheme.ErrorColor
            AddHandler SignOutButton.Click, AddressOf SignOutAsync

            AddHandler SidebarPanel.Paint, Sub(s, e)
                                               Using pen As New Pen(UiTheme.BorderColor, 1.0F)
                                                   e.Graphics.DrawLine(pen, SidebarPanel.Width - 1, 0, SidebarPanel.Width - 1, SidebarPanel.Height)
                                               End Using
                                           End Sub
        End Sub

        Private Sub SetActiveMenuButton(key As String)
            _currentActiveMenu = key
            For Each pair In _menuButtons
                Dim btn = pair.Value
                If String.Equals(pair.Key, key, StringComparison.OrdinalIgnoreCase) Then
                    btn.BackColor = UiTheme.PrimaryLightColor
                    btn.ForeColor = UiTheme.PrimaryColor
                    btn.Font = New Font("Segoe UI", 9.5F, FontStyle.Bold)
                    btn.FlatAppearance.MouseOverBackColor = UiTheme.PrimaryLightColor
                Else
                    btn.BackColor = Color.White
                    btn.ForeColor = Color.FromArgb(75, 85, 99)
                    btn.Font = New Font("Segoe UI", 9.5F, FontStyle.Regular)
                    btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(243, 244, 246)
                End If
            Next
        End Sub

        Private Sub ShowAuthenticationPage(Optional statusMessage As String = Nothing)
            SidebarPanel.Visible = False
            RootLayout.ColumnStyles(0).Width = 0
            ContentHost.Padding = New Padding(0)
            ContentHost.Controls.Clear()
            _authenticationPage.ResetForm()
            If Not String.IsNullOrWhiteSpace(statusMessage) Then
                _authenticationPage.SetStatus(statusMessage, False)
            End If
            _authenticationPage.Dock = DockStyle.Fill
            ContentHost.Controls.Add(_authenticationPage)
        End Sub

        Private Sub ShowDashboard()
            SidebarPanel.Visible = True
            RootLayout.ColumnStyles(0).Width = 260.0F
            ContentHost.Padding = New Padding(0)

            Dim name = If(String.IsNullOrWhiteSpace(_displayName), "Pengguna", _displayName)
            If UserNameLabel IsNot Nothing Then UserNameLabel.Text = name
            If UserAvatarLabel IsNot Nothing Then
                Dim initial = If(name.Length > 0, name.Substring(0, 1).ToUpperInvariant(), "P")
                UserAvatarLabel.Text = initial
            End If

            NavigateTo("Dashboard")
        End Sub

        Public Sub NavigateTo(pageName As String)
            SetActiveMenuButton(pageName)
            ContentHost.Controls.Clear()

            Select Case pageName
                Case "Dashboard"
                    Dim page As New DashboardPage(_repository, _session, _displayName)
                    page.Dock = DockStyle.Fill
                    AddHandler page.CreateGroupRequested, Sub(sender, groupType) OpenCreateGroupDialog(groupType)
                    AddHandler page.JoinGroupRequested, Sub(sender, args) OpenJoinGroupDialog()
                    AddHandler page.GroupSelected, Sub(sender, groupId) ShowGroupDetails(groupId)
                    AddHandler page.NavigateRequested, Sub(sender, target) NavigateTo(target)
                    ContentHost.Controls.Add(page)
                    Dim ignoredTask = page.ReloadDashboardDataAsync()

                Case "Kegiatan"
                    If _repository Is Nothing OrElse _session Is Nothing Then
                        ShowEmptyState(pageName)
                        Return
                    End If
                    Dim groupsPage As New GroupListPage(_repository, _session)
                    groupsPage.Dock = DockStyle.Fill
                    AddHandler groupsPage.GroupSelected, Sub(sender, args) ShowGroupDetails(args.GroupId)
                    AddHandler groupsPage.CreateGroupRequested, Sub(sender, args) OpenCreateGroupDialog(Nothing)
                    AddHandler groupsPage.JoinGroupRequested, Sub(sender, args) OpenJoinGroupDialog()
                    ContentHost.Controls.Add(groupsPage)

                Case "Riwayat"
                    If _repository Is Nothing OrElse _session Is Nothing Then
                        ShowEmptyState(pageName)
                        Return
                    End If
                    Dim historyPage As New GroupListPage(_repository, _session, "Selesai")
                    historyPage.Dock = DockStyle.Fill
                    AddHandler historyPage.GroupSelected, Sub(sender, args) ShowGroupDetails(args.GroupId)
                    AddHandler historyPage.CreateGroupRequested, Sub(sender, args) OpenCreateGroupDialog(Nothing)
                    AddHandler historyPage.JoinGroupRequested, Sub(sender, args) OpenJoinGroupDialog()
                    ContentHost.Controls.Add(historyPage)

                Case "Teman", "Anggota", "Tempat"
                    If _repository Is Nothing OrElse _session Is Nothing Then
                        ShowEmptyState(pageName)
                        Return
                    End If
                    Dim ownerPage As New OwnerDataPage(_repository, _session, pageName)
                    ownerPage.Dock = DockStyle.Fill
                    ContentHost.Controls.Add(ownerPage)

                Case Else
                    ShowEmptyState(pageName)
            End Select
        End Sub

        Private Sub OpenCreateGroupDialog(initialType As String)
            If _repository Is Nothing OrElse _session Is Nothing Then
                ShowEmptyState("Buat Kegiatan")
                Return
            End If

            Using dialog As New CreateGroupDialog(_repository, _session, _displayName, initialType)
                If dialog.ShowDialog(Me) = DialogResult.OK AndAlso dialog.CreatedGroupId.HasValue Then
                    ShowGroupDetails(dialog.CreatedGroupId.Value)
                End If
            End Using
        End Sub

        Private Sub OpenJoinGroupDialog()
            If _repository Is Nothing OrElse _session Is Nothing Then
                ShowEmptyState("Gabung Kegiatan")
                Return
            End If

            Using dialog As New JoinGroupDialog(_repository, _session, _displayName)
                If dialog.ShowDialog(Me) = DialogResult.OK AndAlso dialog.JoinedGroupId.HasValue Then
                    MessageBox.Show($"Selamat! Anda berhasil bergabung ke grup '{dialog.JoinedGroupName}'.", "Berhasil Bergabung", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ShowGroupDetails(dialog.JoinedGroupId.Value)
                End If
            End Using
        End Sub

        Private Sub ShowGroupDetails(groupId As Guid)
            If _repository Is Nothing OrElse _session Is Nothing Then Return
            SetActiveMenuButton("Kegiatan")
            ContentHost.Controls.Clear()
            Dim detailPage As New GroupDetailPage(_repository, _session, groupId)
            detailPage.Dock = DockStyle.Fill
            ContentHost.Controls.Add(detailPage)
        End Sub

        Private Sub ShowEmptyState(pageName As String)
            Dim description = $"Belum ada data untuk {pageName.ToLowerInvariant()}. Buat atau gabung grup terlebih dahulu."
            Dim page As New EmptyStatePage(pageName, description)
            page.Dock = DockStyle.Fill
            AddHandler page.BackToDashboardRequested, Sub(sender, args) NavigateTo("Dashboard")
            ContentHost.Controls.Add(page)
        End Sub

        Private Async Sub HandleAuthenticationAsync(sender As Object, e As AuthenticationRequestEventArgs)
            _authenticationPage.SetBusy(True)
            Try
                Dim session As SupabaseSession
                If e.CreateAccount Then
                    session = Await _supabase.SignUpAsync(e.Email, e.Password, e.DisplayName, CancellationToken.None)
                    _displayName = e.DisplayName
                Else
                    session = Await _supabase.SignInWithPasswordAsync(e.Email, e.Password, CancellationToken.None)
                    _displayName = Await LoadDisplayNameAsync(session)
                End If
                Await _tokenStore.SaveAsync(session.RefreshToken, CancellationToken.None)
                _session = session
                ShowDashboard()
            Catch ex As Exception
                _authenticationPage.SetStatus(ex.Message, True)
            Finally
                _authenticationPage.SetBusy(False)
            End Try
        End Sub

        Private Async Sub RestoreSessionAsync(sender As Object, e As EventArgs)
            If _supabase Is Nothing Then
                ShowAuthenticationPage()
                Return
            End If

            Try
                Dim refreshToken = Await _tokenStore.LoadAsync(CancellationToken.None)
                If String.IsNullOrWhiteSpace(refreshToken) Then Return
                _authenticationPage.SetBusy(True)
                Dim session = Await _supabase.RefreshSessionAsync(refreshToken, CancellationToken.None)
                Await _tokenStore.SaveAsync(session.RefreshToken, CancellationToken.None)
                _session = session
                _displayName = Await LoadDisplayNameAsync(session)
                ShowDashboard()
            Catch ex As Exception
                _tokenStore.Delete()
                _authenticationPage.SetStatus("Sesi login berakhir. Silakan masuk kembali.", True)
            Finally
                _authenticationPage.SetBusy(False)
            End Try
        End Sub

        Private Async Function LoadDisplayNameAsync(session As SupabaseSession) As Task(Of String)
            Try
                Dim resource = "profiles?id=eq." & Uri.EscapeDataString(session.UserId.ToString("D")) & "&select=display_name"
                Dim profiles = Await _supabase.GetResourceAsync(Of List(Of ProfileRecord))(resource, session.AccessToken, CancellationToken.None)
                If profiles IsNot Nothing AndAlso profiles.Count > 0 AndAlso Not String.IsNullOrWhiteSpace(profiles(0).DisplayName) Then Return profiles(0).DisplayName
            Catch ex As Exception
            End Try
            Return If(String.IsNullOrWhiteSpace(session.Email), "Pengguna", session.Email.Split("@"c)(0))
        End Function

        Private Async Sub SignOutAsync(sender As Object, e As EventArgs)
            If _session IsNot Nothing AndAlso _supabase IsNot Nothing Then
                Try
                    Await _supabase.SignOutAsync(_session.AccessToken, CancellationToken.None)
                Catch ex As Exception
                End Try
            End If
            _tokenStore.Delete()
            _session = Nothing
            _displayName = Nothing
            ShowAuthenticationPage("Anda telah keluar. Silakan masuk kembali.")
        End Sub

        Private Sub FormClosedHandler(sender As Object, e As FormClosedEventArgs)
            If _supabase IsNot Nothing Then _supabase.Dispose()
        End Sub

        Private NotInheritable Class ProfileRecord
            <JsonPropertyName("display_name")>
            Public Property DisplayName As String
        End Class
    End Class
End Namespace
