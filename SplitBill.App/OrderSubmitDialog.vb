Option Explicit On
Option Strict On
Option Infer On

Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms
Imports SplitBill.Data

Namespace Global.SplitBill.App
    Partial Class OrderSubmitDialog
        Private ReadOnly _members As IReadOnlyList(Of GroupMemberRecord)

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub New(members As IReadOnlyList(Of GroupMemberRecord), defaultMemberId As Guid?)
            Me.New()
            If members Is Nothing OrElse members.Count = 0 Then Throw New ArgumentException("Daftar anggota tidak boleh kosong.", NameOf(members))
            _members = members

            MemberComboBox.Items.Clear()
            For Each member In _members
                MemberComboBox.Items.Add(New MemberChoice(member.Id, If(member.Person IsNot Nothing, member.Person.Name, "Anggota")))
            Next

            If MemberComboBox.Items.Count > 0 Then
                MemberComboBox.SelectedIndex = 0
                If defaultMemberId.HasValue Then
                    For i = 0 To MemberComboBox.Items.Count - 1
                        Dim choice = DirectCast(MemberComboBox.Items(i), MemberChoice)
                        If choice.Id = defaultMemberId.Value Then
                            MemberComboBox.SelectedIndex = i
                            Exit For
                        End If
                    Next
                End If
            End If

            AddHandler BtnSave.Click, AddressOf SaveClicked
        End Sub

        Public ReadOnly Property SelectedMemberId As Guid
            Get
                Dim choice = TryCast(MemberComboBox.SelectedItem, MemberChoice)
                Return If(choice IsNot Nothing, choice.Id, Guid.Empty)
            End Get
        End Property

        Public ReadOnly Property ItemName As String
            Get
                Return ItemNameTextBox.Text.Trim()
            End Get
        End Property

        Public ReadOnly Property UnitPrice As Long
            Get
                Return CLng(UnitPriceNumeric.Value)
            End Get
        End Property

        Public ReadOnly Property Qty As Integer
            Get
                Return CInt(QtyNumeric.Value)
            End Get
        End Property

        Public ReadOnly Property Note As String
            Get
                Return NoteTextBox.Text.Trim()
            End Get
        End Property

        Private Sub SaveClicked(sender As Object, e As EventArgs)
            If SelectedMemberId = Guid.Empty Then
                MessageBox.Show("Pilih anggota yang memesan.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            If String.IsNullOrWhiteSpace(ItemName) Then
                MessageBox.Show("Nama menu atau porsi wajib diisi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            If UnitPrice <= 0 Then
                MessageBox.Show("Harga satuan harus lebih dari Rp0.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            If Qty <= 0 Then
                MessageBox.Show("Jumlah porsi harus minimal 1.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            DialogResult = DialogResult.OK
            Close()
        End Sub

        Private NotInheritable Class MemberChoice
            Public Sub New(id As Guid, name As String)
                Me.Id = id
                Me.Name = name
            End Sub
            Public ReadOnly Property Id As Guid
            Public ReadOnly Property Name As String
            Public Overrides Function ToString() As String
                Return Name
            End Function
        End Class
    End Class
End Namespace
