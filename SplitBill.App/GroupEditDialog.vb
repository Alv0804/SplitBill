Option Explicit On
Option Strict On
Option Infer On

Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports SplitBill.Data

Namespace Global.SplitBill.App
    Partial Class GroupEditDialog
        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub New(group As GroupRecord, places As IReadOnlyList(Of PlaceRecord))
            Me.New()
            If group Is Nothing Then Throw New ArgumentNullException(NameOf(group))

            TxtName.Text = group.Name
            DtDate.Value = group.EventDate.ToDateTime(TimeOnly.MinValue)

            CmbPlace.Items.Add(New PlaceChoice(Nothing, "Tanpa tempat"))
            If places IsNot Nothing Then
                For Each place In places
                    CmbPlace.Items.Add(New PlaceChoice(place.Id, place.Name))
                Next
            End If

            For index = 0 To CmbPlace.Items.Count - 1
                Dim choice = DirectCast(CmbPlace.Items(index), PlaceChoice)
                If choice.Id = group.PlaceId Then
                    CmbPlace.SelectedIndex = index
                    Exit For
                End If
            Next
            If CmbPlace.SelectedIndex < 0 AndAlso CmbPlace.Items.Count > 0 Then
                CmbPlace.SelectedIndex = 0
            End If
        End Sub

        Public ReadOnly Property GroupName As String
            Get
                Return TxtName.Text.Trim()
            End Get
        End Property

        Public ReadOnly Property EventDate As DateOnly
            Get
                Return DateOnly.FromDateTime(DtDate.Value.Date)
            End Get
        End Property

        Public ReadOnly Property PlaceId As Guid?
            Get
                Dim choice = TryCast(CmbPlace.SelectedItem, PlaceChoice)
                Return If(choice Is Nothing, Nothing, choice.Id)
            End Get
        End Property

        Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
            Dim name = TxtName.Text.Trim()
            If String.IsNullOrWhiteSpace(name) Then
                MessageBox.Show("Nama kegiatan wajib diisi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TxtName.Focus()
                Return
            End If
            If name.Length < 2 Then
                MessageBox.Show("Nama kegiatan minimal 2 karakter.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                TxtName.Focus()
                Return
            End If
            DialogResult = DialogResult.OK
            Close()
        End Sub

        Private NotInheritable Class PlaceChoice
            Public Sub New(id As Guid?, name As String)
                Me.Id = id
                Me.Name = name
            End Sub
            Public ReadOnly Property Id As Guid?
            Public ReadOnly Property Name As String
            Public Overrides Function ToString() As String
                Return Name
            End Function
        End Class
    End Class
End Namespace
