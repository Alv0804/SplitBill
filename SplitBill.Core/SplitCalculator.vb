Option Explicit On
Option Strict On
Option Infer On

Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.Globalization

Namespace Global.SplitBill.Core
    Public NotInheritable Class SplitCalculator
        Private Sub New()
        End Sub

        Public Shared Function SplitEqually(totalAmount As Long, members As IReadOnlyList(Of SplitMember)) As MoneySplitResult
            ValidateTotal(totalAmount)
            Dim orderedMembers = ValidateMembers(members)
            Dim weights As New Dictionary(Of Guid, Decimal)
            For Each member In orderedMembers
                weights.Add(member.MemberId, 1D)
            Next
            Return New MoneySplitResult(AllocateLargestRemainder(totalAmount, orderedMembers, weights), 0)
        End Function

        Public Shared Function SplitByPercentage(totalAmount As Long, shares As IReadOnlyList(Of PercentageShare)) As MoneySplitResult
            ValidateTotal(totalAmount)
            If shares Is Nothing OrElse shares.Count = 0 Then Throw New ArgumentException("Pilih minimal satu anggota.", NameOf(shares))

            Dim members As New List(Of SplitMember)
            Dim weights As New Dictionary(Of Guid, Decimal)
            Dim percentageTotal As Decimal = 0D
            For Each share In shares
                If share Is Nothing Then Throw New ArgumentException("Persentase anggota tidak valid.", NameOf(shares))
                If share.Percent < 0D OrElse share.Percent > 100D Then Throw New ArgumentOutOfRangeException(NameOf(shares), "Persentase tiap anggota harus antara 0% dan 100%.")
                If Decimal.Round(share.Percent, 2, MidpointRounding.ToZero) <> share.Percent Then Throw New ArgumentException("Persentase maksimal dua angka di belakang koma.", NameOf(shares))
                members.Add(share)
                weights.Add(share.MemberId, share.Percent)
                percentageTotal += share.Percent
            Next

            Dim orderedMembers = ValidateMembers(members)
            If percentageTotal <> 100D Then
                Dim difference = Math.Abs(100D - percentageTotal).ToString("0.##", CultureInfo.InvariantCulture)
                Dim direction = If(percentageTotal < 100D, "kurang", "lebih")
                Throw New ArgumentException($"Total persentase harus tepat 100%; saat ini {direction} {difference}%.", NameOf(shares))
            End If

            Return New MoneySplitResult(AllocateLargestRemainder(totalAmount, orderedMembers, weights), 0)
        End Function

        Public Shared Function SplitByFixedAmounts(totalAmount As Long, shares As IReadOnlyList(Of FixedShare)) As MoneySplitResult
            ValidateTotal(totalAmount)
            If shares Is Nothing OrElse shares.Count = 0 Then Throw New ArgumentException("Pilih minimal satu anggota.", NameOf(shares))

            Dim members As New List(Of SplitMember)
            Dim amounts As New Dictionary(Of Guid, Long)
            Dim sum As Decimal = 0D
            For Each share In shares
                If share Is Nothing Then Throw New ArgumentException("Nominal tanggungan anggota tidak valid.", NameOf(shares))
                If share.Amount < 0 Then Throw New ArgumentOutOfRangeException(NameOf(shares), "Tanggungan tidak boleh negatif.")
                members.Add(share)
                amounts.Add(share.MemberId, share.Amount)
                sum += CDec(share.Amount)
            Next

            Dim orderedMembers = ValidateMembers(members)
            If sum <> CDec(totalAmount) Then
                Dim difference = Math.Abs(CDec(totalAmount) - sum)
                Dim direction = If(sum < CDec(totalAmount), "kurang", "lebih")
                Throw New ArgumentException($"Total tanggungan {direction} {FormatRupiah(difference)}.", NameOf(shares))
            End If

            Return New MoneySplitResult(New ReadOnlyDictionary(Of Guid, Long)(amounts), 0)
        End Function

        Public Shared Function SplitByOrder(totalAmount As Long, members As IReadOnlyList(Of SplitMember), items As IReadOnlyList(Of ExpenseLineItem)) As MoneySplitResult
            ValidateTotal(totalAmount)
            Dim orderedMembers = ValidateMembers(members)
            If items Is Nothing OrElse items.Count = 0 Then Throw New ArgumentException("Masukkan minimal satu item pesanan.", NameOf(items))

            Dim selected As New HashSet(Of Guid)
            Dim itemTotals As New Dictionary(Of Guid, Decimal)
            For Each member In orderedMembers
                selected.Add(member.MemberId)
                itemTotals.Add(member.MemberId, 0D)
            Next

            Dim itemSum As Decimal = 0D
            For Each item In items
                If item Is Nothing Then Throw New ArgumentException("Rincian item tidak valid.", NameOf(items))
                If Not selected.Contains(item.MemberId) Then Throw New ArgumentException("Item hanya boleh ditanggung anggota yang dipilih.", NameOf(items))
                itemTotals(item.MemberId) += CDec(item.LineTotal)
                itemSum += CDec(item.LineTotal)
            Next

            If itemSum <= 0D OrElse itemSum > CDec(Long.MaxValue) Then Throw New ArgumentException("Total item harus lebih dari Rp0 dan tidak melebihi batas rupiah.", NameOf(items))

            Dim adjustmentDecimal = CDec(totalAmount) - itemSum
            If adjustmentDecimal < CDec(Long.MinValue) OrElse adjustmentDecimal > CDec(Long.MaxValue) Then Throw New OverflowException("Selisih struk melebihi batas rupiah.")
            Dim adjustmentAmount = Decimal.ToInt64(adjustmentDecimal)
            Dim weights As New Dictionary(Of Guid, Decimal)
            For Each member In orderedMembers
                weights.Add(member.MemberId, itemTotals(member.MemberId))
            Next

            Dim adjustmentShares = AllocateLargestRemainder(adjustmentAmount, orderedMembers, weights)
            Dim finalAmounts As New Dictionary(Of Guid, Long)
            Dim finalTotal As Decimal = 0D
            For Each member In orderedMembers
                Dim amount = itemTotals(member.MemberId) + CDec(adjustmentShares(member.MemberId))
                If amount < 0D OrElse amount > CDec(Long.MaxValue) Then Throw New ArgumentException("Pembagian menghasilkan tanggungan yang tidak valid.", NameOf(items))
                finalAmounts.Add(member.MemberId, Decimal.ToInt64(amount))
                finalTotal += amount
            Next

            If finalTotal <> CDec(totalAmount) Then Throw New InvalidOperationException("Jumlah pembagian pesanan tidak sama dengan total struk.")
            Return New MoneySplitResult(New ReadOnlyDictionary(Of Guid, Long)(finalAmounts), adjustmentAmount)
        End Function

        Private Shared Function AllocateLargestRemainder(totalAmount As Long, members As IReadOnlyList(Of SplitMember), weights As IReadOnlyDictionary(Of Guid, Decimal)) As IReadOnlyDictionary(Of Guid, Long)
            If weights Is Nothing Then Throw New ArgumentNullException(NameOf(weights))
            Dim orderedMembers = ValidateMembers(members)
            Dim weightTotal As Decimal = 0D
            For Each member In orderedMembers
                If Not weights.ContainsKey(member.MemberId) Then Throw New ArgumentException("Bobot pembagian anggota tidak tersedia.", NameOf(weights))
                If weights(member.MemberId) < 0D Then Throw New ArgumentOutOfRangeException(NameOf(weights), "Bobot pembagian tidak boleh negatif.")
                weightTotal += weights(member.MemberId)
            Next
            If weightTotal <= 0D Then Throw New ArgumentException("Tidak ada anggota dengan porsi pembagian lebih dari nol.", NameOf(weights))

            Dim magnitude = Math.Abs(CDec(totalAmount))
            Dim sign = If(totalAmount < 0, -1L, 1L)
            Dim amounts As New Dictionary(Of Guid, Long)
            Dim remainders As New List(Of AllocationRemainder)
            Dim floorTotal As Decimal = 0D

            For Each member In orderedMembers
                Dim rawShare = magnitude * weights(member.MemberId) / weightTotal
                Dim wholeUnits = Decimal.Floor(rawShare)
                Dim signedUnits = If(sign < 0, -wholeUnits, wholeUnits)
                amounts.Add(member.MemberId, Decimal.ToInt64(signedUnits))
                floorTotal += wholeUnits
                remainders.Add(New AllocationRemainder(member, rawShare - wholeUnits))
            Next

            Dim unitsRemaining = Decimal.ToInt64(magnitude - floorTotal)
            remainders.Sort(Function(left, right)
                                Dim byFraction = right.Fraction.CompareTo(left.Fraction)
                                If byFraction <> 0 Then Return byFraction
                                Dim byJoinOrder = left.Member.JoinOrder.CompareTo(right.Member.JoinOrder)
                                If byJoinOrder <> 0 Then Return byJoinOrder
                                Return left.Member.MemberId.CompareTo(right.Member.MemberId)
                            End Function)

            For index = 0 To CInt(unitsRemaining) - 1
                Dim memberId = remainders(index).Member.MemberId
                amounts(memberId) += sign
            Next

            Dim resultingTotal As Decimal = 0D
            For Each amount In amounts.Values
                resultingTotal += CDec(amount)
            Next
            If resultingTotal <> CDec(totalAmount) Then Throw New InvalidOperationException("Jumlah alokasi tidak sama dengan total.")
            Return New ReadOnlyDictionary(Of Guid, Long)(amounts)
        End Function

        Private Shared Function ValidateMembers(members As IReadOnlyList(Of SplitMember)) As List(Of SplitMember)
            If members Is Nothing OrElse members.Count = 0 Then Throw New ArgumentException("Pilih minimal satu anggota.", NameOf(members))
            Dim seen As New HashSet(Of Guid)
            Dim ordered As New List(Of SplitMember)
            For Each member In members
                If member Is Nothing Then Throw New ArgumentException("Anggota pembagian tidak valid.", NameOf(members))
                If Not seen.Add(member.MemberId) Then Throw New ArgumentException("Anggota pembagian tidak boleh duplikat.", NameOf(members))
                ordered.Add(member)
            Next
            ordered.Sort(Function(left, right)
                             Dim byJoinOrder = left.JoinOrder.CompareTo(right.JoinOrder)
                             If byJoinOrder <> 0 Then Return byJoinOrder
                             Return left.MemberId.CompareTo(right.MemberId)
                         End Function)
            Return ordered
        End Function

        Private Shared Sub ValidateTotal(totalAmount As Long)
            If totalAmount <= 0 Then Throw New ArgumentOutOfRangeException(NameOf(totalAmount), "Total pengeluaran harus lebih dari Rp0.")
        End Sub

        Private Shared Function FormatRupiah(amount As Decimal) As String
            Return "Rp" & amount.ToString("N0", CultureInfo.GetCultureInfo("id-ID"))
        End Function

        Private NotInheritable Class AllocationRemainder
            Public Sub New(member As SplitMember, fraction As Decimal)
                Me.Member = member
                Me.Fraction = fraction
            End Sub

            Public ReadOnly Property Member As SplitMember
            Public ReadOnly Property Fraction As Decimal
        End Class
    End Class
End Namespace
