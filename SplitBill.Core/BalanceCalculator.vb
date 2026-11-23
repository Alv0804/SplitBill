Option Explicit On
Option Strict On
Option Infer On

Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Globalization

Namespace Global.SplitBill.Core
    Public NotInheritable Class BalanceCalculator
        Private Sub New()
        End Sub

        Public Shared Function Calculate(members As IReadOnlyList(Of SplitMember), paidAmounts As IReadOnlyDictionary(Of Guid, Long), owedAmounts As IReadOnlyDictionary(Of Guid, Long)) As IReadOnlyList(Of MemberBalance)
            If members Is Nothing OrElse members.Count = 0 Then Throw New ArgumentException("Pilih minimal satu anggota.", NameOf(members))
            If paidAmounts Is Nothing Then Throw New ArgumentNullException(NameOf(paidAmounts))
            If owedAmounts Is Nothing Then Throw New ArgumentNullException(NameOf(owedAmounts))

            Dim memberIds As New HashSet(Of Guid)
            Dim balances As New List(Of MemberBalance)
            Dim netTotal As Decimal = 0D
            For Each member In members
                If member Is Nothing Then Throw New ArgumentException("Anggota tidak valid.", NameOf(members))
                If Not memberIds.Add(member.MemberId) Then Throw New ArgumentException("Anggota tidak boleh duplikat.", NameOf(members))
                Dim paid = GetAmount(paidAmounts, member.MemberId, NameOf(paidAmounts))
                Dim owed = GetAmount(owedAmounts, member.MemberId, NameOf(owedAmounts))
                Dim balance = New MemberBalance(member.MemberId, member.JoinOrder, paid, owed)
                balances.Add(balance)
                netTotal += CDec(balance.Balance)
            Next

            ValidateKeys(paidAmounts, memberIds, NameOf(paidAmounts))
            ValidateKeys(owedAmounts, memberIds, NameOf(owedAmounts))
            If netTotal <> 0D Then
                Dim difference = Math.Abs(netTotal).ToString("N0", CultureInfo.GetCultureInfo("id-ID"))
                Throw New ArgumentException($"Total saldo tidak seimbang sebesar Rp{difference}.")
            End If

            balances.Sort(Function(left, right)
                              Dim byJoinOrder = left.JoinOrder.CompareTo(right.JoinOrder)
                              If byJoinOrder <> 0 Then Return byJoinOrder
                              Return left.MemberId.CompareTo(right.MemberId)
                          End Function)
            Return New ReadOnlyCollection(Of MemberBalance)(balances)
        End Function

        Private Shared Function GetAmount(amounts As IReadOnlyDictionary(Of Guid, Long), memberId As Guid, parameterName As String) As Long
            If Not amounts.ContainsKey(memberId) Then Return 0
            Dim amount = amounts(memberId)
            If amount < 0 Then Throw New ArgumentOutOfRangeException(parameterName, "Total pembayaran dan tanggungan tidak boleh negatif.")
            Return amount
        End Function

        Private Shared Sub ValidateKeys(amounts As IReadOnlyDictionary(Of Guid, Long), memberIds As HashSet(Of Guid), parameterName As String)
            For Each memberId In amounts.Keys
                If Not memberIds.Contains(memberId) Then Throw New ArgumentException("Data pembayaran atau tanggungan memuat anggota di luar grup.", parameterName)
            Next
        End Sub
    End Class

    Public NotInheritable Class TransferCalculator
        Private Sub New()
        End Sub

        Public Shared Function Recommend(balances As IReadOnlyList(Of MemberBalance)) As IReadOnlyList(Of SettlementTransfer)
            If balances Is Nothing Then Throw New ArgumentNullException(NameOf(balances))
            Dim seen As New HashSet(Of Guid)
            Dim debtors As New List(Of RemainingMember)
            Dim creditors As New List(Of RemainingMember)
            Dim netTotal As Decimal = 0D

            For Each balance In balances
                If balance Is Nothing Then Throw New ArgumentException("Saldo anggota tidak valid.", NameOf(balances))
                If Not seen.Add(balance.MemberId) Then Throw New ArgumentException("Saldo anggota tidak boleh duplikat.", NameOf(balances))
                netTotal += CDec(balance.Balance)
                If balance.Balance < 0 Then
                    debtors.Add(New RemainingMember(balance.MemberId, balance.JoinOrder, -balance.Balance))
                ElseIf balance.Balance > 0 Then
                    creditors.Add(New RemainingMember(balance.MemberId, balance.JoinOrder, balance.Balance))
                End If
            Next

            If netTotal <> 0D Then Throw New ArgumentException("Jumlah seluruh saldo harus tepat Rp0.", NameOf(balances))
            debtors.Sort(AddressOf CompareLargestFirst)
            creditors.Sort(AddressOf CompareLargestFirst)

            Dim transfers As New List(Of SettlementTransfer)
            Dim debtorIndex = 0
            Dim creditorIndex = 0
            While debtorIndex < debtors.Count AndAlso creditorIndex < creditors.Count
                Dim debtor = debtors(debtorIndex)
                Dim creditor = creditors(creditorIndex)
                Dim amount = Math.Min(debtor.Remaining, creditor.Remaining)
                transfers.Add(New SettlementTransfer(debtor.MemberId, creditor.MemberId, amount))
                debtor.Remaining -= amount
                creditor.Remaining -= amount
                If debtor.Remaining = 0 Then debtorIndex += 1
                If creditor.Remaining = 0 Then creditorIndex += 1
            End While

            If debtorIndex <> debtors.Count OrElse creditorIndex <> creditors.Count Then Throw New InvalidOperationException("Rekomendasi transfer tidak menutup seluruh saldo.")
            Return New ReadOnlyCollection(Of SettlementTransfer)(transfers)
        End Function

        Private Shared Function CompareLargestFirst(left As RemainingMember, right As RemainingMember) As Integer
            Dim byAmount = right.Remaining.CompareTo(left.Remaining)
            If byAmount <> 0 Then Return byAmount
            Dim byJoinOrder = left.JoinOrder.CompareTo(right.JoinOrder)
            If byJoinOrder <> 0 Then Return byJoinOrder
            Return left.MemberId.CompareTo(right.MemberId)
        End Function

        Private NotInheritable Class RemainingMember
            Public Sub New(memberId As Guid, joinOrder As Long, remaining As Long)
                Me.MemberId = memberId
                Me.JoinOrder = joinOrder
                Me.Remaining = remaining
            End Sub

            Public ReadOnly Property MemberId As Guid
            Public ReadOnly Property JoinOrder As Long
            Public Property Remaining As Long
        End Class
    End Class
End Namespace
