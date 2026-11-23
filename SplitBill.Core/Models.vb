Option Explicit On
Option Strict On
Option Infer On

Imports System
Imports System.Collections.Generic

Namespace Global.SplitBill.Core
    Public Enum ExpenseSplitMethod
        Equal
        ByOrder
        Percentage
        FixedAmount
    End Enum

    Public Class SplitMember
        Public Sub New(memberId As Guid, joinOrder As Long)
            If memberId = Guid.Empty Then Throw New ArgumentException("ID anggota tidak valid.", NameOf(memberId))
            Me.MemberId = memberId
            Me.JoinOrder = joinOrder
        End Sub

        Public ReadOnly Property MemberId As Guid
        Public ReadOnly Property JoinOrder As Long
    End Class

    Public NotInheritable Class PercentageShare
        Inherits SplitMember

        Public Sub New(memberId As Guid, joinOrder As Long, percent As Decimal)
            MyBase.New(memberId, joinOrder)
            Me.Percent = percent
        End Sub

        Public ReadOnly Property Percent As Decimal
    End Class

    Public NotInheritable Class FixedShare
        Inherits SplitMember

        Public Sub New(memberId As Guid, joinOrder As Long, amount As Long)
            MyBase.New(memberId, joinOrder)
            Me.Amount = amount
        End Sub

        Public ReadOnly Property Amount As Long
    End Class

    Public NotInheritable Class ExpenseLineItem
        Public Sub New(memberId As Guid, name As String, unitPrice As Long, quantity As Integer)
            If memberId = Guid.Empty Then Throw New ArgumentException("ID anggota tidak valid.", NameOf(memberId))
            If String.IsNullOrWhiteSpace(name) Then Throw New ArgumentException("Nama item wajib diisi.", NameOf(name))
            If unitPrice <= 0 Then Throw New ArgumentOutOfRangeException(NameOf(unitPrice), "Harga item harus lebih dari Rp0.")
            If quantity <= 0 Then Throw New ArgumentOutOfRangeException(NameOf(quantity), "Jumlah item harus lebih dari 0.")
            If unitPrice > Long.MaxValue \ CLng(quantity) Then Throw New OverflowException("Nilai item melebihi batas rupiah.")

            Me.MemberId = memberId
            Me.Name = name.Trim()
            Me.UnitPrice = unitPrice
            Me.Quantity = quantity
        End Sub

        Public ReadOnly Property MemberId As Guid
        Public ReadOnly Property Name As String
        Public ReadOnly Property UnitPrice As Long
        Public ReadOnly Property Quantity As Integer
        Public ReadOnly Property LineTotal As Long
            Get
                Return UnitPrice * CLng(Quantity)
            End Get
        End Property
    End Class

    Public NotInheritable Class MoneySplitResult
        Public Sub New(amounts As IReadOnlyDictionary(Of Guid, Long), adjustmentAmount As Long)
            Me.Amounts = amounts
            Me.AdjustmentAmount = adjustmentAmount
        End Sub

        Public ReadOnly Property Amounts As IReadOnlyDictionary(Of Guid, Long)
        Public ReadOnly Property AdjustmentAmount As Long
    End Class

    Public NotInheritable Class MemberBalance
        Inherits SplitMember

        Public Sub New(memberId As Guid, joinOrder As Long, paid As Long, owed As Long)
            MyBase.New(memberId, joinOrder)
            If paid < 0 Then Throw New ArgumentOutOfRangeException(NameOf(paid), "Total pembayaran tidak boleh negatif.")
            If owed < 0 Then Throw New ArgumentOutOfRangeException(NameOf(owed), "Total tanggungan tidak boleh negatif.")
            Me.Paid = paid
            Me.Owed = owed
            Me.Balance = paid - owed
        End Sub

        Public ReadOnly Property Paid As Long
        Public ReadOnly Property Owed As Long
        Public ReadOnly Property Balance As Long
    End Class

    Public NotInheritable Class SettlementTransfer
        Public Sub New(fromMemberId As Guid, toMemberId As Guid, amount As Long)
            If fromMemberId = Guid.Empty OrElse toMemberId = Guid.Empty Then Throw New ArgumentException("ID anggota tidak valid.")
            If fromMemberId = toMemberId Then Throw New ArgumentException("Pembayar dan penerima harus berbeda.")
            If amount <= 0 Then Throw New ArgumentOutOfRangeException(NameOf(amount), "Nominal transfer harus lebih dari Rp0.")
            Me.FromMemberId = fromMemberId
            Me.ToMemberId = toMemberId
            Me.Amount = amount
        End Sub

        Public ReadOnly Property FromMemberId As Guid
        Public ReadOnly Property ToMemberId As Guid
        Public ReadOnly Property Amount As Long
    End Class
End Namespace
