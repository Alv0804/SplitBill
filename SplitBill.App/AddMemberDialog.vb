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
    Partial Class AddMemberDialog
        Private ReadOnly _repository As SplitBillRepository
        Private ReadOnly _session As SupabaseSession
        Private ReadOnly _groupId As Guid
        Private ReadOnly _existingPeople As List(Of PersonRecord)
        Private ReadOnly _currentMembers As List(Of GroupMemberRecord)

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub New(repository As SplitBillRepository, session As SupabaseSession, groupId As Guid, existingPeople As IEnumerable(Of PersonRecord), Optional currentMembers As IEnumerable(Of GroupMemberRecord) = Nothing)
            Me.New()
            _repository = repository
            _session = session
            _groupId = groupId
            _currentMembers = If(currentMembers, Enumerable.Empty(Of GroupMemberRecord)()).ToList()

            ' Filter out existing people who are already members of this group (by name or ID)
            Dim existingMemberNames As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase)
            Dim existingPersonIds As New HashSet(Of Guid)()
            For Each m In _currentMembers
                existingPersonIds.Add(m.PersonId)
                If m.Person IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(m.Person.Name) Then
                    existingMemberNames.Add(m.Person.Name.Trim())
                End If
            Next

            _existingPeople = If(existingPeople, Enumerable.Empty(Of PersonRecord)()) _
                .Where(Function(p) Not existingPersonIds.Contains(p.Id) AndAlso Not existingMemberNames.Contains(p.Name.Trim())) _
                .ToList()

            CmbExistingPeople.Items.Add("-- Pilih dari Daftar Teman --")
            For Each p In _existingPeople
                CmbExistingPeople.Items.Add(New PersonChoice(p))
            Next
            CmbExistingPeople.SelectedIndex = 0
        End Sub

        Private Sub CmbExistingPeople_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbExistingPeople.SelectedIndexChanged
            If CmbExistingPeople.SelectedIndex > 0 Then
                Dim choice = TryCast(CmbExistingPeople.SelectedItem, PersonChoice)
                If choice IsNot Nothing Then
                    TxtName.Text = choice.Person.Name
                End If
            End If
        End Sub

        Private Async Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
            Dim name = TxtName.Text.Trim()

            If String.IsNullOrWhiteSpace(name) Then
                LblValidation.Text = "Nama teman tidak boleh kosong."
                TxtName.Focus()
                Return
            End If

            If name.Length < 2 Then
                LblValidation.Text = "Nama teman minimal 2 karakter."
                TxtName.Focus()
                Return
            End If

            ' Strict duplicate member name validation
            If _currentMembers.Any(Function(m) m.Person IsNot Nothing AndAlso String.Equals(m.Person.Name.Trim(), name, StringComparison.OrdinalIgnoreCase)) Then
                LblValidation.Text = $"Nama '{name}' sudah terdaftar dalam kegiatan ini. Nama teman tidak boleh sama."
                TxtName.Focus()
                Return
            End If

            LblValidation.Text = String.Empty
            BtnAdd.Enabled = False
            BtnAdd.Text = "Menambahkan..."

            Try
                ' 1. Find or create the Person record
                Dim person = _existingPeople.FirstOrDefault(Function(p) String.Equals(p.Name, name, StringComparison.OrdinalIgnoreCase))
                If person Is Nothing Then
                    person = Await _repository.CreatePersonAsync(_session, name, "Ditambahkan langsung dari grup", CancellationToken.None)
                End If

                ' 2. Add to group
                Await _repository.AddGroupMemberAsync(_session, _groupId, person.Id, CancellationToken.None)
                DialogResult = DialogResult.OK
                Close()
            Catch ex As Exception
                LblValidation.Text = ex.Message
                BtnAdd.Enabled = True
                BtnAdd.Text = "＋ Tambah Teman"
            End Try
        End Sub

        Private NotInheritable Class PersonChoice
            Public ReadOnly Property Person As PersonRecord

            Public Sub New(person As PersonRecord)
                Me.Person = person
            End Sub

            Public Overrides Function ToString() As String
                Return Person.Name
            End Function
        End Class
    End Class
End Namespace

