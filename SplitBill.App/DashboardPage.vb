Option Explicit On
Option Strict On
Option Infer On

Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Globalization
Imports System.Linq
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports SplitBill.Data

Namespace Global.SplitBill.App
    Partial Class DashboardPage
        Private ReadOnly _repository As SplitBillRepository
        Private ReadOnly _session As SupabaseSession
        Private ReadOnly _displayName As String
        Private ReadOnly _culture As New CultureInfo("id-ID")

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub New(repository As SplitBillRepository, session As SupabaseSession, displayName As String)
            Me.New()
            _repository = repository
            _session = session
            _displayName = If(String.IsNullOrWhiteSpace(displayName), "Pengguna", displayName)

            Dim dateText = DateTime.Now.ToString("dddd, dd MMMM yyyy", _culture).ToUpper()
            BannerDateLabel.Text = dateText
            BannerWelcomeLabel.Text = $"Selamat datang kembali, {_displayName}!"

            AddHandler BtnTopCreate.Click, Sub(s, e) RaiseEvent CreateGroupRequested(Me, Nothing)
            AddHandler BtnTopJoin.Click, Sub(s, e) RaiseEvent JoinGroupRequested(Me, EventArgs.Empty)
            AddHandler SearchTextBox.KeyDown, Sub(s, e)
                                                  If e.KeyCode = Keys.Enter Then
                                                      RaiseEvent NavigateRequested(Me, "Kegiatan")
                                                  End If
                                              End Sub

            AddHandler BtnBannerCreate.Click, Sub(s, e) RaiseEvent CreateGroupRequested(Me, "hangout")
            AddHandler BtnViewAllActive.Click, Sub(s, e) RaiseEvent NavigateRequested(Me, "Kegiatan")

            AddHandler BtnOptionHangout.Click, Sub(s, e) RaiseEvent CreateGroupRequested(Me, "hangout")
            AddHandler BtnOptionTrip.Click, Sub(s, e) RaiseEvent CreateGroupRequested(Me, "trip")
            AddHandler BtnOptionRental.Click, Sub(s, e) RaiseEvent CreateGroupRequested(Me, "purchase_rental")

            AddHandler BtnBottomHistory.Click, Sub(s, e) RaiseEvent NavigateRequested(Me, "Riwayat")
            AddHandler BtnBottomFriends.Click, Sub(s, e) RaiseEvent NavigateRequested(Me, "Teman")
            AddHandler BtnBottomPlaces.Click, Sub(s, e) RaiseEvent NavigateRequested(Me, "Tempat")
            AddHandler BtnBottomJoin.Click, Sub(s, e) RaiseEvent JoinGroupRequested(Me, EventArgs.Empty)

            AddHandler ActiveGroupsContainer.Resize, AddressOf OnActiveGroupsContainerResize
            AddHandler Load, AddressOf PageLoadAsync
        End Sub

        Protected Overrides Async Sub OnHandleCreated(e As EventArgs)
            MyBase.OnHandleCreated(e)
            Await ReloadDashboardDataAsync()
        End Sub

        Private Sub OnActiveGroupsContainerResize(sender As Object, e As EventArgs)
            Dim containerWidth = Math.Max(280, ActiveGroupsContainer.ClientSize.Width - 6)
            For Each c As Control In ActiveGroupsContainer.Controls
                c.Width = containerWidth
            Next
        End Sub

        Public Event CreateGroupRequested As EventHandler(Of String)
        Public Event JoinGroupRequested As EventHandler
        Public Event GroupSelected As EventHandler(Of Guid)
        Public Event NavigateRequested As EventHandler(Of String)

        Private Async Sub PageLoadAsync(sender As Object, e As EventArgs)
            Await ReloadDashboardDataAsync()
        End Sub

        Public Async Function ReloadDashboardDataAsync() As Task
            If _repository Is Nothing OrElse _session Is Nothing Then Return
            Try
                Dim groupsTask = _repository.GetVisibleGroupsAsync(_session, CancellationToken.None)
                Dim peopleTask = _repository.GetPeopleAsync(_session, CancellationToken.None)
                Dim placesTask = _repository.GetPlacesAsync(_session, CancellationToken.None)

                Await Task.WhenAll(groupsTask, peopleTask, placesTask)

                Dim allGroups = groupsTask.Result
                Dim allPeople = peopleTask.Result
                Dim allPlaces = placesTask.Result

                Dim activeGroups = allGroups.Where(Function(g) g.Status = "active").ToList()
                Dim completedGroups = allGroups.Where(Function(g) g.Status <> "active").ToList()

                ActiveGroupsCountLabel.Text = activeGroups.Count.ToString()
                CompletedGroupsCountLabel.Text = completedGroups.Count.ToString()
                PeopleCountLabel.Text = allPeople.Count.ToString()
                PlacesCountLabel.Text = allPlaces.Count.ToString()
                RunningBadgeLabel.Text = $"• {activeGroups.Count} kegiatan sedang berjalan"

                ' Render Active Groups
                ActiveGroupsContainer.Controls.Clear()
                Dim targetCardWidth = Math.Max(280, ActiveGroupsContainer.ClientSize.Width - 6)

                If activeGroups.Count = 0 Then
                    Dim emptyCard As New Panel With {
                        .Width = targetCardWidth,
                        .AutoSize = True,
                        .BackColor = Color.FromArgb(248, 250, 248),
                        .BorderStyle = BorderStyle.FixedSingle,
                        .Padding = New Padding(20),
                        .Margin = New Padding(0, 6, 0, 6)
                    }
                    Dim emptyFlow As New FlowLayoutPanel With {
                        .Dock = DockStyle.Fill,
                        .FlowDirection = FlowDirection.TopDown,
                        .WrapContents = False,
                        .AutoSize = True,
                        .BackColor = Color.FromArgb(248, 250, 248)
                    }
                    Dim emptyIcon As New Label With {.Text = "🎒", .Font = New Font("Segoe UI", 24.0F), .AutoSize = True, .Margin = New Padding(0, 0, 0, 6)}
                    Dim emptyTitle As New Label With {.Text = "Belum Ada Grup / Kegiatan", .Font = New Font("Segoe UI", 12.0F, FontStyle.Bold), .ForeColor = UiTheme.TextColor, .AutoSize = True}
                    Dim emptyDesc As New Label With {
                        .Text = "Anda belum memiliki grup aktif. Buat grup baru untuk mulai membagi pengeluaran bersama teman, atau gunakan kode undangan dari pemilik grup untuk bergabung.",
                        .Font = New Font("Segoe UI", 9.0F),
                        .ForeColor = UiTheme.MutedTextColor,
                        .AutoSize = True,
                        .MaximumSize = New Size(500, 0),
                        .Margin = New Padding(0, 4, 0, 14)
                    }
                    Dim btnStack As New FlowLayoutPanel With {.AutoSize = True, .FlowDirection = FlowDirection.LeftToRight}
                    Dim createBtn As New Button With {
                        .Text = "＋ Buat Grup Baru",
                        .Height = 36,
                        .AutoSize = True,
                        .BackColor = UiTheme.PrimaryColor,
                        .ForeColor = Color.White,
                        .FlatStyle = FlatStyle.Flat,
                        .Font = New Font("Segoe UI", 9.0F, FontStyle.Bold),
                        .Cursor = Cursors.Hand,
                        .Margin = New Padding(0, 0, 10, 0)
                    }
                    createBtn.FlatAppearance.BorderSize = 0
                    AddHandler createBtn.Click, Sub(s, e) RaiseEvent CreateGroupRequested(Me, Nothing)

                    Dim joinBtn As New Button With {
                        .Text = "↗ Gabung dengan Kode",
                        .Height = 36,
                        .AutoSize = True,
                        .BackColor = Color.White,
                        .ForeColor = UiTheme.TextColor,
                        .FlatStyle = FlatStyle.Flat,
                        .Font = New Font("Segoe UI", 9.0F, FontStyle.Bold),
                        .Cursor = Cursors.Hand
                    }
                    joinBtn.FlatAppearance.BorderColor = UiTheme.BorderColor
                    AddHandler joinBtn.Click, Sub(s, e) RaiseEvent JoinGroupRequested(Me, EventArgs.Empty)

                    btnStack.Controls.Add(createBtn)
                    btnStack.Controls.Add(joinBtn)

                    emptyFlow.Controls.Add(emptyIcon)
                    emptyFlow.Controls.Add(emptyTitle)
                    emptyFlow.Controls.Add(emptyDesc)
                    emptyFlow.Controls.Add(btnStack)
                    emptyCard.Controls.Add(emptyFlow)
                    ActiveGroupsContainer.Controls.Add(emptyCard)
                Else
                    For Each grp In activeGroups.Take(5)
                        Dim placeName = "Tanpa lokasi"
                        If grp.PlaceId.HasValue Then
                            Dim p = allPlaces.FirstOrDefault(Function(item) item.Id = grp.PlaceId.Value)
                            If p IsNot Nothing Then placeName = p.Name
                        End If
                        ActiveGroupsContainer.Controls.Add(CreateActiveGroupCard(grp, placeName))
                    Next
                End If

                ' Render Completed Groups Preview
                CompletedGroupsContainer.Controls.Clear()
                If completedGroups.Count = 0 Then
                    Dim emptyHistory As New Label With {.Text = "Belum ada riwayat selesai.", .ForeColor = UiTheme.MutedTextColor, .AutoSize = True, .Padding = New Padding(4, 12, 4, 12)}
                    CompletedGroupsContainer.Controls.Add(emptyHistory)
                Else
                    For Each grp In completedGroups.Take(3)
                        CompletedGroupsContainer.Controls.Add(CreateCompletedGroupItem(grp))
                    Next
                End If

                ' Render People Preview
                PeoplePreviewContainer.Controls.Clear()
                If allPeople.Count = 0 Then
                    Dim emptyPeople As New Label With {.Text = "Belum ada kontak teman tersimpan.", .ForeColor = UiTheme.MutedTextColor, .AutoSize = True, .Padding = New Padding(4, 12, 4, 12)}
                    PeoplePreviewContainer.Controls.Add(emptyPeople)
                Else
                    Dim avatarsFlow As New FlowLayoutPanel With {.AutoSize = True, .FlowDirection = FlowDirection.LeftToRight, .Margin = New Padding(0, 4, 0, 8)}
                    For Each person In allPeople.Take(6)
                        avatarsFlow.Controls.Add(CreateAvatarCircle(person.Name))
                    Next
                    PeoplePreviewContainer.Controls.Add(avatarsFlow)
                    Dim countLabel As New Label With {.Text = $"{allPeople.Count} teman tersimpan di kontak Anda", .ForeColor = UiTheme.MutedTextColor, .AutoSize = True, .Font = New Font("Segoe UI", 8.5F)}
                    PeoplePreviewContainer.Controls.Add(countLabel)
                End If

                ' Render Places Preview
                PlacesPreviewContainer.Controls.Clear()
                If allPlaces.Count = 0 Then
                    Dim emptyPlaces As New Label With {.Text = "Belum ada tempat tersimpan.", .ForeColor = UiTheme.MutedTextColor, .AutoSize = True, .Padding = New Padding(4, 12, 4, 12)}
                    PlacesPreviewContainer.Controls.Add(emptyPlaces)
                Else
                    For Each place In allPlaces.Take(3)
                        Dim itemLabel As New Label With {
                            .Text = $"📍 {place.Name} ({If(place.Category, "Tempat")})",
                            .AutoSize = True,
                            .Font = New Font("Segoe UI", 9.0F),
                            .ForeColor = UiTheme.TextColor,
                            .Margin = New Padding(0, 2, 0, 2)
                        }
                        PlacesPreviewContainer.Controls.Add(itemLabel)
                    Next
                End If
            Catch ex As Exception
                ActiveGroupsContainer.Controls.Clear()
                Dim errLbl As New Label With {
                    .Text = $"Gagal memuat kegiatan: {ex.Message}",
                    .ForeColor = UiTheme.ErrorColor,
                    .AutoSize = True,
                    .Padding = New Padding(12)
                }
                ActiveGroupsContainer.Controls.Add(errLbl)
            End Try
        End Function

        Private Function CreateActiveGroupCard(grp As GroupRecord, placeName As String) As Control
            Dim targetCardWidth = Math.Max(280, ActiveGroupsContainer.ClientSize.Width - 6)
            Dim card As New Panel With {
                .Width = targetCardWidth,
                .Height = 84,
                .BackColor = Color.FromArgb(252, 253, 252),
                .BorderStyle = BorderStyle.FixedSingle,
                .Padding = New Padding(12),
                .Margin = New Padding(0, 0, 0, 8),
                .Cursor = Cursors.Hand
            }
            Dim layout As New TableLayoutPanel With {.Dock = DockStyle.Fill, .ColumnCount = 4, .RowCount = 1, .Cursor = Cursors.Hand}
            layout.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 44.0F))
            layout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 45.0F))
            layout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 55.0F))
            layout.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 125.0F))

            Dim icon = If(grp.Type = "trip", "🚗", If(grp.Type = "hangout", "☕", "🛍️"))
            Dim badge As New Label With {.Text = icon, .Font = New Font("Segoe UI", 13.0F), .ForeColor = UiTheme.BadgeGreenFg, .BackColor = UiTheme.BadgeGreenBg, .Size = New Size(36, 36), .TextAlign = ContentAlignment.MiddleCenter}

            Dim leftStack As New FlowLayoutPanel With {.Dock = DockStyle.Fill, .FlowDirection = FlowDirection.TopDown, .WrapContents = False}
            Dim nameLabel As New Label With {.Text = grp.Name, .Font = New Font("Segoe UI", 10.0F, FontStyle.Bold), .ForeColor = UiTheme.TextColor, .AutoSize = True}
            Dim typeLabel As New Label With {.Text = FormatGroupType(grp.Type), .Font = New Font("Segoe UI", 8.0F), .ForeColor = UiTheme.MutedTextColor, .AutoSize = True}
            leftStack.Controls.Add(nameLabel)
            leftStack.Controls.Add(typeLabel)

            Dim metaStack As New FlowLayoutPanel With {.Dock = DockStyle.Fill, .FlowDirection = FlowDirection.TopDown, .WrapContents = False}
            Dim pillsRow As New FlowLayoutPanel With {.AutoSize = True, .FlowDirection = FlowDirection.LeftToRight, .Margin = New Padding(0)}
            Dim statusPill As New Label With {.Text = "• Aktif", .Font = New Font("Segoe UI", 8.0F, FontStyle.Bold), .ForeColor = UiTheme.BadgeGreenFg, .AutoSize = True, .Margin = New Padding(0, 0, 6, 0)}
            Dim codePill As New Label With {
                .Text = $"Kode: {grp.InviteCode}",
                .Font = New Font("Segoe UI", 7.5F, FontStyle.Bold),
                .ForeColor = UiTheme.PrimaryColor,
                .BackColor = UiTheme.PrimaryLightColor,
                .Padding = New Padding(4, 1, 4, 1),
                .AutoSize = True,
                .Cursor = Cursors.Hand
            }
            AddHandler codePill.Click, Sub(s, e)
                                           If Not String.IsNullOrWhiteSpace(grp.InviteCode) Then
                                               Clipboard.SetText(grp.InviteCode)
                                               MessageBox.Show($"Kode undangan '{grp.InviteCode}' berhasil disalin ke clipboard!", "Kode Disalin", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                           End If
                                       End Sub
            pillsRow.Controls.Add(statusPill)
            pillsRow.Controls.Add(codePill)

            Dim metaLabel As New Label With {.Text = $"📍 {placeName}  ·  📅 {grp.EventDate:dd MMM yyyy}", .Font = New Font("Segoe UI", 8.0F), .ForeColor = UiTheme.MutedTextColor, .AutoSize = True, .Margin = New Padding(0, 2, 0, 0)}
            metaStack.Controls.Add(pillsRow)
            metaStack.Controls.Add(metaLabel)

            Dim openBtn As New Button With {
                .Text = "Buka Kegiatan ›",
                .Dock = DockStyle.Fill,
                .FlatStyle = FlatStyle.Flat,
                .Font = New Font("Segoe UI", 9.0F, FontStyle.Bold),
                .ForeColor = UiTheme.PrimaryColor,
                .Cursor = Cursors.Hand
            }
            openBtn.FlatAppearance.BorderSize = 0
            AddHandler openBtn.Click, Sub(s, e) RaiseEvent GroupSelected(Me, grp.Id)

            layout.Controls.Add(badge, 0, 0)
            layout.Controls.Add(leftStack, 1, 0)
            layout.Controls.Add(metaStack, 2, 0)
            layout.Controls.Add(openBtn, 3, 0)
            card.Controls.Add(layout)

            AddHandler card.Click, Sub(s, e) RaiseEvent GroupSelected(Me, grp.Id)
            AddHandler leftStack.Click, Sub(s, e) RaiseEvent GroupSelected(Me, grp.Id)
            AddHandler metaStack.Click, Sub(s, e) RaiseEvent GroupSelected(Me, grp.Id)
            Return card
        End Function

        Private Shared Function CreateCompletedGroupItem(grp As GroupRecord) As Control
            Dim item As New FlowLayoutPanel With {.AutoSize = True, .FlowDirection = FlowDirection.LeftToRight, .WrapContents = False, .Margin = New Padding(0, 2, 0, 2)}
            Dim dateBadge As New Label With {
                .Text = grp.EventDate.ToString("dd MMM", CultureInfo.InvariantCulture),
                .Font = New Font("Segoe UI", 7.5F, FontStyle.Bold),
                .ForeColor = UiTheme.MutedTextColor,
                .BackColor = Color.FromArgb(240, 242, 240),
                .Padding = New Padding(4, 2, 4, 2),
                .AutoSize = True
            }
            Dim titleLbl As New Label With {.Text = grp.Name, .Font = New Font("Segoe UI", 8.5F, FontStyle.Bold), .ForeColor = UiTheme.TextColor, .AutoSize = True, .Margin = New Padding(6, 0, 0, 0)}
            item.Controls.Add(dateBadge)
            item.Controls.Add(titleLbl)
            Return item
        End Function

        Private Shared Function CreateAvatarCircle(name As String) As Control
            Dim initial = If(String.IsNullOrWhiteSpace(name), "?", name.Trim()(0).ToString().ToUpper())
            Return New Label With {
                .Text = initial,
                .Font = New Font("Segoe UI", 9.0F, FontStyle.Bold),
                .ForeColor = UiTheme.PrimaryDarkColor,
                .BackColor = UiTheme.PrimaryLightColor,
                .Size = New Size(28, 28),
                .TextAlign = ContentAlignment.MiddleCenter,
                .Margin = New Padding(2, 0, 2, 0)
            }
        End Function

        Private Shared Function FormatGroupType(t As String) As String
            Select Case t
                Case "hangout" : Return "Nongkrong / Makan Bersama"
                Case "trip" : Return "Perjalanan Bersama"
                Case "purchase_rental" : Return "Pembelian / Penyewaan"
                Case Else : Return t
            End Select
        End Function
    End Class
End Namespace
