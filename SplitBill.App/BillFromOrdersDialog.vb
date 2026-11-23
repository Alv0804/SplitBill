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
    Partial Class BillFromOrdersDialog
        Private ReadOnly _members As IReadOnlyList(Of GroupMemberRecord)
        Private ReadOnly _approvedOrders As IReadOnlyList(Of OrderSubmissionRecord)
        Private ReadOnly _baseOrderTotal As Long

        Private _calculatedShares As New List(Of Object)()
        Private _calculatedPayers As New List(Of Object)()
        Private _calculatedItems As New List(Of Object)()
        Private _totalFinal As Long
        Private _adjFinal As Long

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub New(members As IReadOnlyList(Of GroupMemberRecord), approvedOrders As IReadOnlyList(Of OrderSubmissionRecord), Optional defaultExpenseName As String = "Tagihan Pesanan Menu")
            Me.New()
            If members Is Nothing OrElse members.Count = 0 Then Throw New ArgumentException("Daftar anggota tidak boleh kosong.", NameOf(members))
            If approvedOrders Is Nothing OrElse approvedOrders.Count = 0 Then Throw New ArgumentException("Daftar pesanan yang disetujui tidak boleh kosong.", NameOf(approvedOrders))
            _members = members
            _approvedOrders = approvedOrders

            TxtExpenseName.Text = If(String.IsNullOrWhiteSpace(defaultExpenseName), "Tagihan Pesanan Menu", defaultExpenseName.Trim())

            For Each m In _members
                Dim memberName = If(m.Person IsNot Nothing, m.Person.Name, "Anggota")
                CmbPayer.Items.Add(New MemberChoice(m.Id, memberName))
            Next
            If CmbPayer.Items.Count > 0 Then CmbPayer.SelectedIndex = 0

            CmbMethod.Items.Add("Bayar Sendiri-Sendiri (Sesuai Pesanan Masing-Masing)")
            CmbMethod.Items.Add("Bayar Bareng Semua (Bagi Rata)")
            CmbMethod.SelectedIndex = 0

            Dim sumTotal As Long = 0
            For Each ord In _approvedOrders
                Dim subtotal = ord.UnitPrice * CLng(ord.Qty)
                sumTotal += subtotal
                Dim memberName = GetMemberName(ord.MemberId)
                LstOrders.Items.Add($"{ord.ItemName} x{ord.Qty} (@ Rp{ord.UnitPrice:N0}) = Rp{subtotal:N0} — {memberName}")
            Next
            _baseOrderTotal = sumTotal

            UpdateTotalDisplay()
            AddHandler NumAdjustment.ValueChanged, Sub(s, e) UpdateTotalDisplay()
        End Sub

        Private Function GetMemberName(memberId As Guid) As String
            Dim m = _members.FirstOrDefault(Function(x) x.Id = memberId)
            If m IsNot Nothing AndAlso m.Person IsNot Nothing Then Return m.Person.Name
            Return "Anggota"
        End Function

        Private Sub UpdateTotalDisplay()
            Dim adj = CLng(NumAdjustment.Value)
            Dim total = _baseOrderTotal + adj
            If total < 1 Then total = 1
            LblTotal.Text = $"Total Tagihan: Rp{total:N0}" & If(adj <> 0, $" (Pesanan: Rp{_baseOrderTotal:N0} + Penyesuaian: Rp{adj:N0})", "")
        End Sub

        Public ReadOnly Property ExpenseName As String
            Get
                Return TxtExpenseName.Text.Trim()
            End Get
        End Property

        Public ReadOnly Property ExpenseDate As DateOnly
            Get
                Return DateOnly.FromDateTime(DateTime.Today)
            End Get
        End Property

        Public ReadOnly Property TotalAmount As Long
            Get
                Return _totalFinal
            End Get
        End Property

        Public ReadOnly Property AdjustmentAmount As Long
            Get
                Return _adjFinal
            End Get
        End Property

        Public ReadOnly Property SplitMethod As String
            Get
                If CmbMethod IsNot Nothing AndAlso CmbMethod.SelectedIndex = 1 Then
                    Return "equal"
                End If
                Return "order"
            End Get
        End Property

        Public ReadOnly Property Note As String
            Get
                Dim methodText = If(CmbMethod IsNot Nothing AndAlso CmbMethod.SelectedIndex = 1, "Bagi Rata", "Sesuai Pesanan Masing-Masing")
                Return $"Dibuat otomatis dari {_approvedOrders.Count} pesanan menu disetujui ({methodText})."
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

        Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
            Dim expName = TxtExpenseName.Text.Trim()
            If String.IsNullOrWhiteSpace(expName) Then
                LblValidation.Text = "Nama pengeluaran tidak boleh kosong."
                TxtExpenseName.Focus()
                Return
            End If

            Dim payerChoice = TryCast(CmbPayer.SelectedItem, MemberChoice)
            If payerChoice Is Nothing Then
                LblValidation.Text = "Pilih anggota yang membayar / menalangi tagihan ini."
                CmbPayer.Focus()
                Return
            End If

            Dim adj = CLng(NumAdjustment.Value)
            Dim total = _baseOrderTotal + adj
            If total <= 0 Then
                LblValidation.Text = "Total tagihan harus lebih dari Rp0."
                Return
            End If

            _calculatedPayers.Clear()
            _calculatedShares.Clear()
            _calculatedItems.Clear()

            _totalFinal = total
            _adjFinal = adj
            _calculatedPayers.Add(New With {.member_id = payerChoice.Id, .amount = _totalFinal})

            Try
                Dim splitMembers As New List(Of SplitMember)()
                Dim lineItems As New List(Of ExpenseLineItem)()
                Dim joinIndex = 0L

                For Each m In _members
                    splitMembers.Add(New SplitMember(m.Id, joinIndex))
                    joinIndex += 1L
                Next

                For Each ord In _approvedOrders
                    lineItems.Add(New ExpenseLineItem(ord.MemberId, ord.ItemName, ord.UnitPrice, ord.Qty))
                    _calculatedItems.Add(New With {
                        .member_id = ord.MemberId,
                        .name = ord.ItemName,
                        .unit_price = ord.UnitPrice,
                        .qty = ord.Qty
                    })
                Next

                Dim isEqual = (CmbMethod.SelectedIndex = 1)
                Dim splitRes = If(isEqual, SplitCalculator.SplitEqually(_totalFinal, splitMembers), SplitCalculator.SplitByOrder(_totalFinal, splitMembers, lineItems))
                For Each kvp In splitRes.Amounts
                    _calculatedShares.Add(New With {
                        .member_id = kvp.Key,
                        .amount = kvp.Value,
                        .percent = CType(Nothing, Decimal?)
                    })
                Next

                DialogResult = DialogResult.OK
                Close()
            Catch ex As Exception
                LblValidation.Text = $"Gagal membagi tagihan pesanan: {ex.Message}"
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
    End Class
End Namespace

