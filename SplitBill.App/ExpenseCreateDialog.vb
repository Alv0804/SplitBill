Option Explicit On
Option Strict On
Option Infer On

Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports SplitBill.Core
Imports SplitBill.Data

Namespace Global.SplitBill.App
    Partial Class ExpenseCreateDialog
        Private ReadOnly _members As IReadOnlyList(Of GroupMemberRecord)
        Private ReadOnly _approvedOrders As IReadOnlyList(Of OrderSubmissionRecord)

        Private _calculatedShares As New List(Of Object)()
        Private _calculatedPayers As New List(Of Object)()
        Private _calculatedItems As New List(Of Object)()
        Private _adjustmentAmount As Long = 0

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub New(members As IReadOnlyList(Of GroupMemberRecord), approvedOrders As IReadOnlyList(Of OrderSubmissionRecord))
            Me.New()
            If members Is Nothing OrElse members.Count = 0 Then Throw New ArgumentException("Daftar anggota tidak boleh kosong.", NameOf(members))
            _members = members
            _approvedOrders = If(approvedOrders, New List(Of OrderSubmissionRecord)())

            PayerComboBox.Items.Clear()
            For Each member In _members
                PayerComboBox.Items.Add(New MemberChoice(member.Id, If(member.Person IsNot Nothing, member.Person.Name, "Anggota")))
            Next
            If PayerComboBox.Items.Count > 0 Then PayerComboBox.SelectedIndex = 0

            MethodComboBox.Items.Clear()
            MethodComboBox.Items.Add(New MethodChoice("equal", "Sama Rata (Dibagi rata)"))
            If _approvedOrders.Count > 0 Then
                MethodComboBox.Items.Add(New MethodChoice("order", $"Berdasarkan Pesanan ({_approvedOrders.Count} pesanan disetujui)"))
            End If
            MethodComboBox.SelectedIndex = 0

            EqualCheckList.Items.Clear()
            For Each member In _members
                EqualCheckList.Items.Add(New MemberChoice(member.Id, If(member.Person IsNot Nothing, member.Person.Name, "Anggota")), True)
            Next

            AddHandler BtnSave.Click, AddressOf SaveClicked
        End Sub

        Public ReadOnly Property ExpenseName As String
            Get
                Return NameTextBox.Text.Trim()
            End Get
        End Property

        Public ReadOnly Property ExpenseDate As DateOnly
            Get
                Return DateOnly.FromDateTime(DatePicker.Value.Date)
            End Get
        End Property

        Public ReadOnly Property TotalAmount As Long
            Get
                Return CLng(TotalNumeric.Value)
            End Get
        End Property

        Public ReadOnly Property AdjustmentAmount As Long
            Get
                Return _adjustmentAmount
            End Get
        End Property

        Public ReadOnly Property SplitMethod As String
            Get
                Dim choice = TryCast(MethodComboBox.SelectedItem, MethodChoice)
                Return If(choice IsNot Nothing, choice.Code, "equal")
            End Get
        End Property

        Public ReadOnly Property Note As String
            Get
                Return NoteTextBox.Text.Trim()
            End Get
        End Property

        Public ReadOnly Property Payers As Object
            Get
                Return _calculatedPayers.ToArray()
            End Get
        End Property

        Public ReadOnly Property Shares As Object
            Get
                Return _calculatedShares.ToArray()
            End Get
        End Property

        Public ReadOnly Property Items As Object
            Get
                Return _calculatedItems.ToArray()
            End Get
        End Property

        Private Sub SaveClicked(sender As Object, e As EventArgs)
            If String.IsNullOrWhiteSpace(ExpenseName) Then
                MessageBox.Show("Nama pengeluaran wajib diisi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            If TotalAmount <= 0 Then
                MessageBox.Show("Total struk harus lebih dari Rp0.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim payerChoice = TryCast(PayerComboBox.SelectedItem, MemberChoice)
            If payerChoice Is Nothing Then
                MessageBox.Show("Pilih pembayar pengeluaran.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            _calculatedPayers.Clear()
            _calculatedShares.Clear()
            _calculatedItems.Clear()
            _adjustmentAmount = 0

            _calculatedPayers.Add(New With {.member_id = payerChoice.Id, .amount = TotalAmount})

            Try
                If SplitMethod = "order" AndAlso _approvedOrders.Count > 0 Then
                    Dim splitMembers As New List(Of SplitMember)()
                    Dim lineItems As New List(Of ExpenseLineItem)()
                    Dim joinIndex = 0L

                    For Each m In _members
                        splitMembers.Add(New SplitMember(m.Id, joinIndex))
                        joinIndex += 1L
                    Next

                    For Each ord In _approvedOrders
                        lineItems.Add(New ExpenseLineItem(ord.MemberId, ord.ItemName, ord.UnitPrice, ord.Qty))
                        _calculatedItems.Add(New With {.member_id = ord.MemberId, .name = ord.ItemName, .unit_price = ord.UnitPrice, .qty = ord.Qty})
                    Next

                    Dim splitRes = SplitCalculator.SplitByOrder(TotalAmount, splitMembers, lineItems)
                    _adjustmentAmount = splitRes.AdjustmentAmount
                    For Each kvp In splitRes.Amounts
                        _calculatedShares.Add(New With {.member_id = kvp.Key, .amount = kvp.Value, .percent = CType(Nothing, Decimal?)})
                    Next
                Else
                    Dim selectedMembers As New List(Of SplitMember)()
                    Dim joinIndex = 0L
                    For i = 0 To EqualCheckList.Items.Count - 1
                        If EqualCheckList.GetItemChecked(i) Then
                            Dim choice = DirectCast(EqualCheckList.Items(i), MemberChoice)
                            selectedMembers.Add(New SplitMember(choice.Id, joinIndex))
                        End If
                        joinIndex += 1L
                    Next

                    If selectedMembers.Count = 0 Then
                        MessageBox.Show("Pilih minimal satu anggota yang menanggung pengeluaran ini.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return
                    End If

                    Dim splitRes = SplitCalculator.SplitEqually(TotalAmount, selectedMembers)
                    For Each kvp In splitRes.Amounts
                        _calculatedShares.Add(New With {.member_id = kvp.Key, .amount = kvp.Value, .percent = CType(Nothing, Decimal?)})
                    Next
                End If

                DialogResult = DialogResult.OK
                Close()
            Catch ex As Exception
                MessageBox.Show($"Gagal menghitung pembagian: {ex.Message}", "Error Pembagian", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
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

        Private NotInheritable Class MethodChoice
            Public Sub New(code As String, label As String)
                Me.Code = code
                Me.Label = label
            End Sub
            Public ReadOnly Property Code As String
            Public ReadOnly Property Label As String
            Public Overrides Function ToString() As String
                Return Label
            End Function
        End Class
    End Class
End Namespace
