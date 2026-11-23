Option Explicit On
Option Strict On
Option Infer On

Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports SplitBill.Data

Namespace Global.SplitBill.App
    Partial Class PersonPickerDialog
        Private ReadOnly _people As IReadOnlyList(Of PersonRecord)

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub New(people As IReadOnlyList(Of PersonRecord))
            Me.New()
            If people Is Nothing OrElse people.Count = 0 Then Throw New ArgumentException("Belum ada nama anggota yang bisa dipilih.", NameOf(people))
            _people = people

            LstPeople.DisplayMember = NameOf(PersonRecord.Name)
            AddHandler TxtSearch.TextChanged, AddressOf FilterPeople
            AddHandler LstPeople.DoubleClick, AddressOf AcceptSelection
            PopulateList()
        End Sub

        Public ReadOnly Property SelectedPerson As PersonRecord
            Get
                Return TryCast(LstPeople.SelectedItem, PersonRecord)
            End Get
        End Property

        Private Sub FilterPeople(sender As Object, e As EventArgs)
            PopulateList()
        End Sub

        Private Sub PopulateList()
            Dim query = TxtSearch.Text.Trim()
            Dim filtered = If(String.IsNullOrWhiteSpace(query),
                _people,
                _people.Where(Function(p) p.Name.Contains(query, StringComparison.OrdinalIgnoreCase)).ToList())

            LstPeople.Items.Clear()
            For Each p In filtered
                LstPeople.Items.Add(p)
            Next
            If LstPeople.Items.Count > 0 Then LstPeople.SelectedIndex = 0
        End Sub

        Private Sub AcceptSelection(sender As Object, e As EventArgs)
            If SelectedPerson IsNot Nothing Then
                DialogResult = DialogResult.OK
                Close()
            End If
        End Sub
    End Class
End Namespace
