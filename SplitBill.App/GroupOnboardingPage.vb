Option Explicit On
Option Strict On
Option Infer On

Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Text.Json
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports SplitBill.Data

Namespace Global.SplitBill.App
    Public Enum GroupOnboardingMode
        Create
        Join
    End Enum

    Public NotInheritable Class GroupNavigationEventArgs
        Inherits EventArgs

        Public Sub New(groupId As Guid)
            Me.GroupId = groupId
        End Sub

        Public ReadOnly Property GroupId As Guid
    End Class

    Partial Class GroupOnboardingPage
        Private ReadOnly _repository As SplitBillRepository
        Private ReadOnly _session As SupabaseSession
        Private ReadOnly _mode As GroupOnboardingMode
        Private ReadOnly _initialType As String
        Private _invitePreview As InvitePreview

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub New(repository As SplitBillRepository, session As SupabaseSession, mode As GroupOnboardingMode, Optional initialType As String = Nothing)
            Me.New()
            _repository = repository
            _session = session
            _mode = mode
            _initialType = initialType

            TitleLabel.Text = If(mode = GroupOnboardingMode.Create, "Buat Grup / Kegiatan Baru", "Gabung Kegiatan dengan Kode")
            CreateCard.Visible = (mode = GroupOnboardingMode.Create)
            JoinCard.Visible = (mode = GroupOnboardingMode.Join)

            If mode = GroupOnboardingMode.Create Then
                TypeCombo.Items.Clear()
                TypeCombo.Items.AddRange(New Object() {
                    New ActivityTypeOption("Nongkrong atau makan bersama", "hangout"),
                    New ActivityTypeOption("Perjalanan bersama", "trip"),
                    New ActivityTypeOption("Pembelian atau penyewaan", "purchase_rental")
                })
                TypeCombo.SelectedIndex = 0
                If Not String.IsNullOrWhiteSpace(_initialType) Then
                    For i As Integer = 0 To TypeCombo.Items.Count - 1
                        Dim opt = TryCast(TypeCombo.Items(i), ActivityTypeOption)
                        If opt IsNot Nothing AndAlso String.Equals(opt.Value, _initialType, StringComparison.OrdinalIgnoreCase) Then
                            TypeCombo.SelectedIndex = i
                            Exit For
                        End If
                    Next
                End If

                PlaceCombo.DisplayMember = NameOf(PlaceRecord.Name)
                OwnerPersonCombo.DisplayMember = NameOf(PersonRecord.Name)
                MembersCheckList.DisplayMember = NameOf(PersonRecord.Name)

                AddHandler BtnCreateSubmit.Click, AddressOf CreateGroupAsync
                AddHandler BtnCreateBack.Click, Sub(s, e) RaiseEvent BackRequested(Me, EventArgs.Empty)
                AddHandler BtnAddPlace.Click, AddressOf AddPlaceAsync
                AddHandler BtnAddOwnerPerson.Click, AddressOf AddPersonAsync
                AddHandler BtnAddMemberPerson.Click, AddressOf AddPersonAsync
                AddHandler Load, AddressOf LoadLookupsAsync
            Else
                AvailableMembersCombo.DisplayMember = NameOf(InviteMemberOption.Name)
                AddHandler BtnPreviewCode.Click, AddressOf PreviewInviteAsync
                AddHandler ExistingMemberRadio.CheckedChanged, AddressOf UpdateJoinSelection
                AddHandler NewMemberRadio.CheckedChanged, AddressOf UpdateJoinSelection
                AddHandler BtnJoinSubmit.Click, AddressOf SubmitJoinRequestAsync
                AddHandler BtnJoinBack.Click, Sub(s, e) RaiseEvent BackRequested(Me, EventArgs.Empty)
            End If
        End Sub

        Public Event BackRequested As EventHandler
        Public Event GroupReady As EventHandler(Of GroupNavigationEventArgs)
        Public Event JoinRequestSubmitted As EventHandler

        Private Async Sub LoadLookupsAsync(sender As Object, e As EventArgs)
            If _mode <> GroupOnboardingMode.Create Then Return
            Try
                PlaceCombo.Items.Clear()
                PlaceCombo.Items.Add(New PlaceOption(Nothing, "Tanpa tempat"))
                For Each place In Await _repository.GetPlacesAsync(_session, CancellationToken.None)
                    PlaceCombo.Items.Add(New PlaceOption(place.Id, place.Name))
                Next
                PlaceCombo.SelectedIndex = 0
                Await ReloadPeopleAsync()
            Catch ex As Exception
                SetStatus(ex.Message, True)
            End Try
        End Sub

        Private Async Function ReloadPeopleAsync() As Task
            Dim selectedOwnerId = If(TryCast(OwnerPersonCombo.SelectedItem, PersonRecord)?.Id, Guid.Empty)
            Dim people = Await _repository.GetPeopleAsync(_session, CancellationToken.None)
            OwnerPersonCombo.Items.Clear()
            MembersCheckList.Items.Clear()
            For Each person In people
                OwnerPersonCombo.Items.Add(person)
                MembersCheckList.Items.Add(person, False)
            Next
            If selectedOwnerId <> Guid.Empty Then
                For index = 0 To OwnerPersonCombo.Items.Count - 1
                    If DirectCast(OwnerPersonCombo.Items(index), PersonRecord).Id = selectedOwnerId Then OwnerPersonCombo.SelectedIndex = index
                Next
            ElseIf OwnerPersonCombo.Items.Count > 0 Then
                OwnerPersonCombo.SelectedIndex = 0
            End If
        End Function

        Private Async Sub AddPersonAsync(sender As Object, e As EventArgs)
            Using dialog As New QuickEntryDialog("Tambah Teman Baru", New String() {"Nama Teman", "Catatan"})
                If dialog.ShowDialog(FindForm()) <> DialogResult.OK Then Return
                Try
                    Await _repository.CreatePersonAsync(_session, dialog.Values(0), dialog.Values(1), CancellationToken.None)
                    Await ReloadPeopleAsync()
                    SetStatus("Data teman tersimpan.", False)
                Catch ex As Exception
                    SetStatus(ex.Message, True)
                End Try
            End Using
        End Sub

        Private Async Sub AddPlaceAsync(sender As Object, e As EventArgs)
            Using dialog As New QuickEntryDialog("Tambah Tempat Baru", New String() {"Nama Tempat", "Kategori", "Alamat"})
                If dialog.ShowDialog(FindForm()) <> DialogResult.OK Then Return
                Try
                    Dim place = Await _repository.CreatePlaceAsync(_session, dialog.Values(0), dialog.Values(1), dialog.Values(2), CancellationToken.None)
                    PlaceCombo.Items.Add(New PlaceOption(place.Id, place.Name))
                    PlaceCombo.SelectedIndex = PlaceCombo.Items.Count - 1
                    SetStatus("Tempat tersimpan.", False)
                Catch ex As Exception
                    SetStatus(ex.Message, True)
                End Try
            End Using
        End Sub

        Private Async Sub CreateGroupAsync(sender As Object, e As EventArgs)
            If TypeCombo.SelectedItem Is Nothing OrElse String.IsNullOrWhiteSpace(NameText.Text) OrElse OwnerPersonCombo.SelectedItem Is Nothing Then
                SetStatus("Jenis kegiatan, nama grup, dan nama owner wajib diisi.", True)
                Return
            End If
            Try
                Dim selectedType = DirectCast(TypeCombo.SelectedItem, ActivityTypeOption)
                Dim selectedPlace = TryCast(PlaceCombo.SelectedItem, PlaceOption)
                Dim ownerPerson = DirectCast(OwnerPersonCombo.SelectedItem, PersonRecord)
                Dim memberIds As New List(Of Guid)
                For Each item In MembersCheckList.CheckedItems
                    Dim person = DirectCast(item, PersonRecord)
                    If person.Id <> ownerPerson.Id Then memberIds.Add(person.Id)
                Next
                Dim groupId = Await _repository.CreateGroupAsync(
                    _session,
                    selectedType.Value,
                    NameText.Text,
                    DateOnly.FromDateTime(EventDatePicker.Value.Date),
                    If(selectedPlace Is Nothing, Nothing, selectedPlace.Id),
                    ownerPerson.Id,
                    memberIds.ToArray(),
                    CancellationToken.None)
                RaiseEvent GroupReady(Me, New GroupNavigationEventArgs(groupId))
            Catch ex As Exception
                SetStatus(ex.Message, True)
            End Try
        End Sub

        Private Async Sub PreviewInviteAsync(sender As Object, e As EventArgs)
            If InviteCodeText.Text.Trim().Length <> 8 Then
                SetStatus("Kode undangan harus berisi 8 karakter.", True)
                Return
            End If
            BtnPreviewCode.Enabled = False
            Try
                _invitePreview = Await _repository.PreviewInviteAsync(_session, InviteCodeText.Text, CancellationToken.None)
                If Not _invitePreview.Valid Then
                    PreviewTextLabel.Text = _invitePreview.Message
                    SetStatus(_invitePreview.Message, True)
                    EnableJoinChoices(False)
                    Return
                End If

                PreviewTextLabel.Text = $"Grup: {_invitePreview.GroupName}{Environment.NewLine}Owner: {_invitePreview.OwnerName}"
                AvailableMembersCombo.Items.Clear()
                If _invitePreview.Members IsNot Nothing Then
                    For Each member In _invitePreview.Members
                        AvailableMembersCombo.Items.Add(member)
                    Next
                End If
                ExistingMemberRadio.Enabled = AvailableMembersCombo.Items.Count > 0
                NewMemberRadio.Enabled = True
                ExistingMemberRadio.Checked = AvailableMembersCombo.Items.Count > 0
                NewMemberRadio.Checked = AvailableMembersCombo.Items.Count = 0
                If AvailableMembersCombo.Items.Count > 0 Then AvailableMembersCombo.SelectedIndex = 0
                EnableJoinChoices(True)
                UpdateJoinSelection(Nothing, EventArgs.Empty)
                SetStatus(String.Empty, False)
            Catch ex As Exception
                SetStatus(ex.Message, True)
            Finally
                BtnPreviewCode.Enabled = True
            End Try
        End Sub

        Private Sub EnableJoinChoices(enabled As Boolean)
            AvailableMembersCombo.Enabled = enabled AndAlso ExistingMemberRadio.Enabled AndAlso ExistingMemberRadio.Checked
            ProposedNameText.Enabled = enabled AndAlso NewMemberRadio.Checked
            BtnJoinSubmit.Enabled = enabled
        End Sub

        Private Sub UpdateJoinSelection(sender As Object, e As EventArgs)
            If _invitePreview Is Nothing OrElse Not _invitePreview.Valid Then Return
            AvailableMembersCombo.Enabled = ExistingMemberRadio.Checked AndAlso ExistingMemberRadio.Enabled
            ProposedNameText.Enabled = NewMemberRadio.Checked
        End Sub

        Private Async Sub SubmitJoinRequestAsync(sender As Object, e As EventArgs)
            Dim claimedMemberId As Guid? = Nothing
            Dim proposedName As String = Nothing
            If ExistingMemberRadio.Checked Then
                Dim optionValue = TryCast(AvailableMembersCombo.SelectedItem, InviteMemberOption)
                If optionValue Is Nothing Then
                    SetStatus("Pilih nama anggota yang tersedia atau ajukan nama baru.", True)
                    Return
                End If
                claimedMemberId = optionValue.MemberId
            Else
                proposedName = ProposedNameText.Text.Trim()
                If String.IsNullOrWhiteSpace(proposedName) Then
                    SetStatus("Nama baru wajib diisi.", True)
                    Return
                End If
            End If

            BtnJoinSubmit.Enabled = False
            Try
                Dim result = Await _repository.RequestJoinAsync(_session, InviteCodeText.Text, claimedMemberId, proposedName, CancellationToken.None)
                Dim submitted As JsonElement
                Dim messageElement As JsonElement
                If result.TryGetProperty("submitted", submitted) AndAlso submitted.ValueKind = JsonValueKind.True Then
                    SetStatus("Permintaan bergabung dikirim dan menunggu persetujuan owner.", False)
                    RaiseEvent JoinRequestSubmitted(Me, EventArgs.Empty)
                ElseIf result.TryGetProperty("message", messageElement) Then
                    SetStatus(messageElement.GetString(), True)
                Else
                    SetStatus("Permintaan tidak dapat dikirim.", True)
                End If
            Catch ex As Exception
                SetStatus(ex.Message, True)
            Finally
                BtnJoinSubmit.Enabled = _invitePreview IsNot Nothing AndAlso _invitePreview.Valid
            End Try
        End Sub

        Private Sub SetStatus(message As String, isError As Boolean)
            Dim lbl = If(_mode = GroupOnboardingMode.Create, CreateStatusLabel, JoinStatusLabel)
            lbl.Text = message
            lbl.ForeColor = If(isError, UiTheme.ErrorColor, UiTheme.PrimaryDarkColor)
        End Sub

        Private NotInheritable Class ActivityTypeOption
            Public Sub New(displayName As String, value As String)
                Me.DisplayName = displayName
                Me.Value = value
            End Sub
            Public ReadOnly Property DisplayName As String
            Public ReadOnly Property Value As String
            Public Overrides Function ToString() As String
                Return DisplayName
            End Function
        End Class

        Private NotInheritable Class PlaceOption
            Public Sub New(id As Guid?, displayName As String)
                Me.Id = id
                Me.DisplayName = displayName
            End Sub
            Public ReadOnly Property Id As Guid?
            Public ReadOnly Property DisplayName As String
            Public Overrides Function ToString() As String
                Return DisplayName
            End Function
        End Class
    End Class
End Namespace
