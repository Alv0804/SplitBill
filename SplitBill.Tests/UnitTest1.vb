Imports System
Imports System.Linq
Imports SplitBill.Core
Imports Xunit

Namespace SplitBill.Tests
    Public Class MoneyCalculationTests
        <Fact>
        Public Sub PercentageSplitMatchesRentalFixture()
            Dim memberA = Guid.Parse("00000000-0000-4000-8000-000000000001")
            Dim memberB = Guid.Parse("00000000-0000-4000-8000-000000000002")
            Dim memberC = Guid.Parse("00000000-0000-4000-8000-000000000003")
            Dim memberD = Guid.Parse("00000000-0000-4000-8000-000000000004")
            Dim shares As PercentageShare() = {
                New PercentageShare(memberA, 0, 40D),
                New PercentageShare(memberB, 1, 30D),
                New PercentageShare(memberC, 2, 20D),
                New PercentageShare(memberD, 3, 10D)
            }

            Dim result = SplitCalculator.SplitByPercentage(500000L, shares)

            Assert.Equal(200000L, result.Amounts(memberA))
            Assert.Equal(150000L, result.Amounts(memberB))
            Assert.Equal(100000L, result.Amounts(memberC))
            Assert.Equal(50000L, result.Amounts(memberD))
            Assert.Equal(500000L, result.Amounts.Values.Sum())
        End Sub

        <Fact>
        Public Sub EqualSplitUsesLargestRemainderInJoinOrder()
            Dim members As SplitMember() = {
                New SplitMember(Guid.Parse("00000000-0000-4000-8000-000000000001"), 0),
                New SplitMember(Guid.Parse("00000000-0000-4000-8000-000000000002"), 1),
                New SplitMember(Guid.Parse("00000000-0000-4000-8000-000000000003"), 2)
            }

            Dim result = SplitCalculator.SplitEqually(100000L, members)

            Assert.Equal(New Long() {33334L, 33333L, 33333L}, members.Select(Function(member) result.Amounts(member.MemberId)))
            Assert.Equal(100000L, result.Amounts.Values.Sum())
        End Sub

        <Fact>
        Public Sub PercentageTotalMustEqualOneHundred()
            Dim shares As PercentageShare() = {
                New PercentageShare(Guid.Parse("00000000-0000-4000-8000-000000000001"), 0, 33.33D),
                New PercentageShare(Guid.Parse("00000000-0000-4000-8000-000000000002"), 1, 33.33D),
                New PercentageShare(Guid.Parse("00000000-0000-4000-8000-000000000003"), 2, 33.33D)
            }

            Dim validationError = Assert.Throws(Of ArgumentException)(Function() SplitCalculator.SplitByPercentage(100000L, shares))

            Assert.Contains("kurang 0.01%", validationError.Message)
        End Sub

        <Fact>
        Public Sub OrderSplitDistributesTaxProportionally()
            Dim memberA = Guid.Parse("00000000-0000-4000-8000-000000000001")
            Dim memberB = Guid.Parse("00000000-0000-4000-8000-000000000002")
            Dim members As SplitMember() = {New SplitMember(memberA, 0), New SplitMember(memberB, 1)}
            Dim items As ExpenseLineItem() = {
                New ExpenseLineItem(memberA, "Nasi", 10000L, 1),
                New ExpenseLineItem(memberB, "Sewa", 20000L, 1)
            }

            Dim result = SplitCalculator.SplitByOrder(36000L, members, items)

            Assert.Equal(6000L, result.AdjustmentAmount)
            Assert.Equal(12000L, result.Amounts(memberA))
            Assert.Equal(24000L, result.Amounts(memberB))
        End Sub

        <Fact>
        Public Sub GreedyTransfersAreDeterministicAndIgnoreZeroBalance()
            Dim memberA = Guid.Parse("00000000-0000-4000-8000-000000000001")
            Dim memberB = Guid.Parse("00000000-0000-4000-8000-000000000002")
            Dim memberC = Guid.Parse("00000000-0000-4000-8000-000000000003")
            Dim memberD = Guid.Parse("00000000-0000-4000-8000-000000000004")
            Dim memberE = Guid.Parse("00000000-0000-4000-8000-000000000005")
            Dim balances As MemberBalance() = {
                New MemberBalance(memberA, 0, 0L, 100000L),
                New MemberBalance(memberB, 1, 0L, 100000L),
                New MemberBalance(memberC, 2, 100000L, 0L),
                New MemberBalance(memberD, 3, 100000L, 0L),
                New MemberBalance(memberE, 4, 0L, 0L)
            }

            Dim transfers = TransferCalculator.Recommend(balances)

            Assert.Equal(2, transfers.Count)
            Assert.Equal((memberA, memberC, 100000L), (transfers(0).FromMemberId, transfers(0).ToMemberId, transfers(0).Amount))
            Assert.Equal((memberB, memberD, 100000L), (transfers(1).FromMemberId, transfers(1).ToMemberId, transfers(1).Amount))
        End Sub

        <Fact>
        Public Sub FixedSharesMustSumToReceiptTotal()
            Dim shares As FixedShare() = {
                New FixedShare(Guid.Parse("00000000-0000-4000-8000-000000000001"), 0, 40000L),
                New FixedShare(Guid.Parse("00000000-0000-4000-8000-000000000002"), 1, 50000L)
            }

            Dim validationError = Assert.Throws(Of ArgumentException)(Function() SplitCalculator.SplitByFixedAmounts(100000L, shares))

            Assert.Contains("kurang Rp10.000", validationError.Message)
        End Sub

        <Fact>
        Public Sub BalanceCalculatorCalculatesCorrectNetBalances()
            Dim memberA = Guid.Parse("00000000-0000-4000-8000-000000000001")
            Dim memberB = Guid.Parse("00000000-0000-4000-8000-000000000002")
            Dim members As SplitMember() = {New SplitMember(memberA, 0), New SplitMember(memberB, 1)}

            Dim paid As New Dictionary(Of Guid, Long) From {{memberA, 100000L}, {memberB, 0L}}
            Dim owed As New Dictionary(Of Guid, Long) From {{memberA, 50000L}, {memberB, 50000L}}

            Dim balances = BalanceCalculator.Calculate(members, paid, owed)

            Assert.Equal(2, balances.Count)
            Assert.Equal(50000L, balances.First(Function(b) b.MemberId = memberA).Balance)
            Assert.Equal(-50000L, balances.First(Function(b) b.MemberId = memberB).Balance)
        End Sub

        <Fact>
        Public Sub BalanceCalculatorThrowsWhenUnbalanced()
            Dim memberA = Guid.Parse("00000000-0000-4000-8000-000000000001")
            Dim memberB = Guid.Parse("00000000-0000-4000-8000-000000000002")
            Dim members As SplitMember() = {New SplitMember(memberA, 0), New SplitMember(memberB, 1)}

            Dim paid As New Dictionary(Of Guid, Long) From {{memberA, 100000L}, {memberB, 0L}}
            Dim owed As New Dictionary(Of Guid, Long) From {{memberA, 40000L}, {memberB, 50000L}}

            Dim ex = Assert.Throws(Of ArgumentException)(Function() BalanceCalculator.Calculate(members, paid, owed))
            Assert.Contains("Total saldo tidak seimbang", ex.Message)
        End Sub

        <Fact>
        Public Sub BillFromOrdersEquallyAndByOrderProduceValidTotals()
            Dim memberA = Guid.Parse("00000000-0000-4000-8000-000000000001")
            Dim memberB = Guid.Parse("00000000-0000-4000-8000-000000000002")
            Dim members As SplitMember() = {New SplitMember(memberA, 0), New SplitMember(memberB, 1)}
            Dim items As ExpenseLineItem() = {
                New ExpenseLineItem(memberA, "Burger", 35000L, 1),
                New ExpenseLineItem(memberB, "Steak", 65000L, 1)
            }

            ' Total 100.000 + 10.000 tax = 110.000
            Dim totalWithTax = 110000L

            ' 1. By Order (Sendiri-sendiri + pajak proporsional)
            Dim orderResult = SplitCalculator.SplitByOrder(totalWithTax, members, items)
            Assert.Equal(38500L, orderResult.Amounts(memberA))
            Assert.Equal(71500L, orderResult.Amounts(memberB))
            Assert.Equal(totalWithTax, orderResult.Amounts.Values.Sum())

            ' 2. Equal (Bagi rata)
            Dim equalResult = SplitCalculator.SplitEqually(totalWithTax, members)
            Assert.Equal(55000L, equalResult.Amounts(memberA))
            Assert.Equal(55000L, equalResult.Amounts(memberB))
            Assert.Equal(totalWithTax, equalResult.Amounts.Values.Sum())
        End Sub
    End Class
End Namespace

