Option Explicit On
Option Strict On
Option Infer On

Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading
Imports System.Windows.Forms
Imports SplitBill.Data

Namespace Global.SplitBill.App
    Partial Class CreateGroupDialog
        Private ReadOnly _repository As SplitBillRepository
        Private ReadOnly _session As SupabaseSession
        Private _createdGroupId As Guid?

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub New(repository As SplitBillRepository, session As SupabaseSession, defaultOwnerName As String, Optional initialType As String = Nothing)
            Me.New()
            _repository = repository
            _session = session

            CmbType.Items.Add(New ActivityTypeChoice("Nongkrong atau Makan Bersama", "hangout"))
            CmbType.Items.Add(New ActivityTypeChoice("Perjalanan Bersama (Trip)", "trip"))
            CmbType.Items.Add(New ActivityTypeChoice("Pembelian atau Sewa Bersama", "purchase_rental"))
            CmbType.SelectedIndex = 0

            If Not String.IsNullOrWhiteSpace(initialType) Then
                For i As Integer = 0 To CmbType.Items.Count - 1
                    Dim choice = DirectCast(CmbType.Items(i), ActivityTypeChoice)
                    If String.Equals(choice.Value, initialType, StringComparison.OrdinalIgnoreCase) Then
                        CmbType.SelectedIndex = i
                        Exit For
                    End If
                Next
            End If

            If Not String.IsNullOrWhiteSpace(defaultOwnerName) Then
                TxtOwnerName.Text = defaultOwnerName.Trim()
            End If

            DtEvent.Value = DateTime.Today
        End Sub

        Public ReadOnly Property CreatedGroupId As Guid?
            Get
                Return _createdGroupId
            End Get
        End Property

        Private Async Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
            Dim groupName = TxtGroupName.Text.Trim()
            Dim ownerName = TxtOwnerName.Text.Trim()
            Dim placeName = TxtPlace.Text.Trim()
            Dim initialMembersRaw = TxtInitialMembers.Text.Trim()

            ' 1. Input Validation
            If String.IsNullOrWhiteSpace(groupName) Then
                LblValidation.Text = "Nama grup / kegiatan tidak boleh kosong."
                TxtGroupName.Focus()
                Return
            End If

            If groupName.Length < 2 Then
                LblValidation.Text = "Nama grup minimal 2 karakter."
                TxtGroupName.Focus()
                Return
            End If

            If String.IsNullOrWhiteSpace(ownerName) Then
                LblValidation.Text = "Nama Anda sebagai pemilik tidak boleh kosong."
                TxtOwnerName.Focus()
                Return
            End If

            If ownerName.Length < 2 Then
                LblValidation.Text = "Nama pemilik minimal 2 karakter."
                TxtOwnerName.Focus()
                Return
            End If

            ' 2. Validate Initial Member Names (Duplicate & Collision Check)
            Dim cleanMemberNames As New List(Of String)()
            If Not String.IsNullOrWhiteSpace(initialMembersRaw) Then
                Dim rawTokens = initialMembersRaw.Split(New Char() {","c, ";"c, ControlChars.Lf, ControlChars.Cr}, StringSplitOptions.RemoveEmptyEntries)
                Dim seenMemberNames As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase)

                For Each rawToken In rawTokens
                    Dim trimmedName = rawToken.Trim()
                    If Not String.IsNullOrWhiteSpace(trimmedName) Then
                        If trimmedName.Length < 2 Then
                            LblValidation.Text = $"Nama anggota '{trimmedName}' terlalu pendek (minimal 2 karakter)."
                            TxtInitialMembers.Focus()
                            Return
                        End If

                        If String.Equals(trimmedName, ownerName, StringComparison.OrdinalIgnoreCase) Then
                            LblValidation.Text = $"Nama '{trimmedName}' sama dengan nama pemilik. Anda otomatis menjadi anggota, jadi tidak perlu ditulis lagi."
                            TxtInitialMembers.Focus()
                            Return
                        End If

                        If seenMemberNames.Contains(trimmedName) Then
                            LblValidation.Text = $"Nama anggota '{trimmedName}' ditulis lebih dari sekali. Nama anggota dalam satu kegiatan tidak boleh sama."
                            TxtInitialMembers.Focus()
                            Return
                        End If

                        seenMemberNames.Add(trimmedName)
                        cleanMemberNames.Add(trimmedName)
                    End If
                Next
            End If

            LblValidation.Text = String.Empty
            BtnCreate.Enabled = False
            BtnCreate.Text = "Membuat..."

            Try
                ' 3. Ensure Owner Person Record exists
                Dim existingPeople = Await _repository.GetPeopleAsync(_session, CancellationToken.None)
                Dim ownerPerson = existingPeople.FirstOrDefault(Function(p) String.Equals(p.Name, ownerName, StringComparison.OrdinalIgnoreCase))
                If ownerPerson Is Nothing Then
                    ownerPerson = Await _repository.CreatePersonAsync(_session, ownerName, "Pemilik grup", CancellationToken.None)
                End If

                ' 4. Ensure Place Record exists if provided
                Dim placeId As Guid? = Nothing
                If Not String.IsNullOrWhiteSpace(placeName) Then
                    Dim existingPlaces = Await _repository.GetPlacesAsync(_session, CancellationToken.None)
                    Dim place = existingPlaces.FirstOrDefault(Function(p) String.Equals(p.Name, placeName, StringComparison.OrdinalIgnoreCase))
                    If place Is Nothing Then
                        place = Await _repository.CreatePlaceAsync(_session, placeName, "Tempat", placeName, CancellationToken.None)
                    End If
                    placeId = place.Id
                End If

                ' 5. Ensure Initial Member Persons exist if provided
                Dim initialMemberIds As New List(Of Guid)()
                For Each memberName In cleanMemberNames
                    Dim memberPerson = existingPeople.FirstOrDefault(Function(p) String.Equals(p.Name, memberName, StringComparison.OrdinalIgnoreCase))
                    If memberPerson Is Nothing Then
                        memberPerson = Await _repository.CreatePersonAsync(_session, memberName, "Anggota kegiatan", CancellationToken.None)
                    End If
                    If Not initialMemberIds.Contains(memberPerson.Id) Then
                        initialMemberIds.Add(memberPerson.Id)
                    End If
                Next

                ' 6. Call CreateGroup RPC
                Dim selectedChoice = DirectCast(CmbType.SelectedItem, ActivityTypeChoice)
                Dim eventDateOnly = DateOnly.FromDateTime(DtEvent.Value)

                Dim groupId = Await _repository.CreateGroupAsync(
                    _session,
                    selectedChoice.Value,
                    groupName,
                    eventDateOnly,
                    placeId,
                    ownerPerson.Id,
                    initialMemberIds.ToArray(),
                    CancellationToken.None
                )

                _createdGroupId = groupId
                DialogResult = DialogResult.OK
                Close()
            Catch ex As Exception
                LblValidation.Text = ex.Message
                BtnCreate.Enabled = True
                BtnCreate.Text = "Buat Grup"
            End Try
        End Sub

        Private NotInheritable Class ActivityTypeChoice
            Public ReadOnly Property DisplayName As String
            Public ReadOnly Property Value As String

            Public Sub New(displayName As String, value As String)
                Me.DisplayName = displayName
                Me.Value = value
            End Sub

            Public Overrides Function ToString() As String
                Return DisplayName
            End Function
        End Class
    End Class
End Namespace
