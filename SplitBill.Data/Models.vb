Option Explicit On
Option Strict On
Option Infer On

Imports System
Imports System.Text.Json
Imports System.Text.Json.Serialization

Namespace Global.SplitBill.Data
    Public NotInheritable Class PersonRecord
        <JsonPropertyName("id")>
        Public Property Id As Guid

        <JsonPropertyName("owner_id")>
        Public Property OwnerId As Guid

        <JsonPropertyName("name")>
        Public Property Name As String

        <JsonPropertyName("note")>
        Public Property Note As String

        Public Overrides Function ToString() As String
            Return Name
        End Function
    End Class

    Public NotInheritable Class PlaceRecord
        <JsonPropertyName("id")>
        Public Property Id As Guid

        <JsonPropertyName("owner_id")>
        Public Property OwnerId As Guid

        <JsonPropertyName("name")>
        Public Property Name As String

        <JsonPropertyName("category")>
        Public Property Category As String

        <JsonPropertyName("address")>
        Public Property Address As String

        Public Overrides Function ToString() As String
            Return Name
        End Function
    End Class

    Public NotInheritable Class GroupRecord
        <JsonPropertyName("id")>
        Public Property Id As Guid

        <JsonPropertyName("owner_id")>
        Public Property OwnerId As Guid

        <JsonPropertyName("type")>
        Public Property Type As String

        <JsonPropertyName("name")>
        Public Property Name As String

        <JsonPropertyName("event_date")>
        Public Property EventDate As DateOnly

        <JsonPropertyName("place_id")>
        Public Property PlaceId As Guid?

        <JsonPropertyName("status")>
        Public Property Status As String

        <JsonPropertyName("invite_code")>
        Public Property InviteCode As String

        <JsonPropertyName("invite_enabled")>
        Public Property InviteEnabled As Boolean

        <JsonPropertyName("finalized_at")>
        Public Property FinalizedAt As DateTimeOffset?

        Public Overrides Function ToString() As String
            Return Name
        End Function
    End Class

    Public NotInheritable Class GroupMemberRecord
        <JsonPropertyName("id")>
        Public Property Id As Guid

        <JsonPropertyName("group_id")>
        Public Property GroupId As Guid

        <JsonPropertyName("person_id")>
        Public Property PersonId As Guid

        <JsonPropertyName("user_id")>
        Public Property UserId As Guid?

        <JsonPropertyName("role")>
        Public Property Role As String

        <JsonPropertyName("person")>
        Public Property Person As PersonNameRecord

        Public Overrides Function ToString() As String
            Return If(Person Is Nothing OrElse String.IsNullOrWhiteSpace(Person.Name), "Anggota", Person.Name)
        End Function
    End Class

    Public NotInheritable Class PersonNameRecord
        <JsonPropertyName("name")>
        Public Property Name As String
    End Class

    Public NotInheritable Class JoinRequestRecord
        <JsonPropertyName("requestId")>
        Public Property RequestId As Guid

        <JsonPropertyName("requesterUserId")>
        Public Property RequesterUserId As Guid

        <JsonPropertyName("requesterName")>
        Public Property RequesterName As String

        <JsonPropertyName("memberId")>
        Public Property MemberId As Guid?

        <JsonPropertyName("memberName")>
        Public Property MemberName As String

        <JsonPropertyName("status")>
        Public Property Status As String

        <JsonPropertyName("createdAt")>
        Public Property CreatedAt As DateTimeOffset

        Public Overrides Function ToString() As String
            Return $"{MemberName} — permintaan dari {RequesterName}"
        End Function
    End Class

    Public NotInheritable Class InviteMemberOption
        <JsonPropertyName("memberId")>
        Public Property MemberId As Guid

        <JsonPropertyName("name")>
        Public Property Name As String

        Public Overrides Function ToString() As String
            Return Name
        End Function
    End Class

    Public NotInheritable Class InvitePreview
        <JsonPropertyName("valid")>
        Public Property Valid As Boolean

        <JsonPropertyName("message")>
        Public Property Message As String

        <JsonPropertyName("groupId")>
        Public Property GroupId As Guid

        <JsonPropertyName("groupName")>
        Public Property GroupName As String

        <JsonPropertyName("ownerName")>
        Public Property OwnerName As String

        <JsonPropertyName("members")>
        Public Property Members As InviteMemberOption()

        Public Shared Function FromJson(value As JsonElement) As InvitePreview
            Dim options As New JsonSerializerOptions With {.PropertyNameCaseInsensitive = True}
            Return JsonSerializer.Deserialize(Of InvitePreview)(value.GetRawText(), options)
        End Function
    End Class

    Public NotInheritable Class ExpenseRecord
        <JsonPropertyName("id")>
        Public Property Id As Guid

        <JsonPropertyName("group_id")>
        Public Property GroupId As Guid

        <JsonPropertyName("name")>
        Public Property Name As String

        <JsonPropertyName("total_amount")>
        Public Property TotalAmount As Long

        <JsonPropertyName("adjustment_amount")>
        Public Property AdjustmentAmount As Long

        <JsonPropertyName("expense_date")>
        Public Property ExpenseDate As DateOnly

        <JsonPropertyName("split_method")>
        Public Property SplitMethod As String

        <JsonPropertyName("note")>
        Public Property Note As String

        <JsonPropertyName("created_by")>
        Public Property CreatedBy As Guid

        <JsonPropertyName("created_at")>
        Public Property CreatedAt As DateTimeOffset

        Public Overrides Function ToString() As String
            Return $"{Name} — Rp{TotalAmount:N0} ({SplitMethod})"
        End Function
    End Class

    Public NotInheritable Class ExpensePayerRecord
        <JsonPropertyName("id")>
        Public Property Id As Guid

        <JsonPropertyName("expense_id")>
        Public Property ExpenseId As Guid

        <JsonPropertyName("member_id")>
        Public Property MemberId As Guid

        <JsonPropertyName("amount")>
        Public Property Amount As Long
    End Class

    Public NotInheritable Class ExpenseShareRecord
        <JsonPropertyName("id")>
        Public Property Id As Guid

        <JsonPropertyName("expense_id")>
        Public Property ExpenseId As Guid

        <JsonPropertyName("member_id")>
        Public Property MemberId As Guid

        <JsonPropertyName("amount")>
        Public Property Amount As Long

        <JsonPropertyName("percent")>
        Public Property Percent As Decimal?
    End Class

    Public NotInheritable Class ExpenseItemRecord
        <JsonPropertyName("id")>
        Public Property Id As Guid

        <JsonPropertyName("expense_id")>
        Public Property ExpenseId As Guid

        <JsonPropertyName("member_id")>
        Public Property MemberId As Guid

        <JsonPropertyName("name")>
        Public Property Name As String

        <JsonPropertyName("unit_price")>
        Public Property UnitPrice As Long

        <JsonPropertyName("qty")>
        Public Property Qty As Integer
    End Class

    Public NotInheritable Class OrderSubmissionRecord
        <JsonPropertyName("id")>
        Public Property Id As Guid

        <JsonPropertyName("group_id")>
        Public Property GroupId As Guid

        <JsonPropertyName("member_id")>
        Public Property MemberId As Guid

        <JsonPropertyName("item_name")>
        Public Property ItemName As String

        <JsonPropertyName("unit_price")>
        Public Property UnitPrice As Long

        <JsonPropertyName("qty")>
        Public Property Qty As Integer

        <JsonPropertyName("note")>
        Public Property Note As String

        <JsonPropertyName("expense_id")>
        Public Property ExpenseId As Guid?

        <JsonPropertyName("status")>
        Public Property Status As String

        <JsonPropertyName("reviewed_by")>
        Public Property ReviewedBy As Guid?

        <JsonPropertyName("reviewed_at")>
        Public Property ReviewedAt As DateTimeOffset?

        <JsonPropertyName("created_at")>
        Public Property CreatedAt As DateTimeOffset

        Public Overrides Function ToString() As String
            Return $"{ItemName} x{Qty} @ Rp{UnitPrice:N0} — {Status}"
        End Function
    End Class

    Public NotInheritable Class GroupBalanceRecord
        <JsonPropertyName("id")>
        Public Property Id As Guid

        <JsonPropertyName("group_id")>
        Public Property GroupId As Guid

        <JsonPropertyName("member_id")>
        Public Property MemberId As Guid

        <JsonPropertyName("paid")>
        Public Property Paid As Long

        <JsonPropertyName("owed")>
        Public Property Owed As Long

        <JsonPropertyName("balance")>
        Public Property Balance As Long

        <JsonPropertyName("created_at")>
        Public Property CreatedAt As DateTimeOffset
    End Class

    Public NotInheritable Class SettlementRecord
        <JsonPropertyName("id")>
        Public Property Id As Guid

        <JsonPropertyName("group_id")>
        Public Property GroupId As Guid

        <JsonPropertyName("from_member_id")>
        Public Property FromMemberId As Guid

        <JsonPropertyName("to_member_id")>
        Public Property ToMemberId As Guid

        <JsonPropertyName("amount")>
        Public Property Amount As Long

        <JsonPropertyName("status")>
        Public Property Status As String

        <JsonPropertyName("marked_at")>
        Public Property MarkedAt As DateTimeOffset?

        <JsonPropertyName("confirmed_at")>
        Public Property ConfirmedAt As DateTimeOffset?

        <JsonPropertyName("confirmed_by")>
        Public Property ConfirmedBy As Guid?

        <JsonPropertyName("created_at")>
        Public Property CreatedAt As DateTimeOffset
    End Class
End Namespace
