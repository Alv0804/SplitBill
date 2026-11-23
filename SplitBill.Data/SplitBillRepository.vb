Option Explicit On
Option Strict On
Option Infer On

Imports System
Imports System.Collections.Generic
Imports System.Text.Json
Imports System.Threading
Imports System.Threading.Tasks

Namespace Global.SplitBill.Data
    Public NotInheritable Class SplitBillRepository
        Private Shared ReadOnly DeserializerOptions As New JsonSerializerOptions With {.PropertyNameCaseInsensitive = True}
        Private ReadOnly _client As SupabaseClient

        Public Sub New(client As SupabaseClient)
            If client Is Nothing Then Throw New ArgumentNullException(NameOf(client))
            _client = client
        End Sub

        Public Function GetPeopleAsync(session As SupabaseSession, cancellationToken As CancellationToken) As Task(Of List(Of PersonRecord))
            Return _client.GetResourceAsync(Of List(Of PersonRecord))("people?select=id,owner_id,name,note&order=name.asc", session.AccessToken, cancellationToken)
        End Function

        Public Async Function CreatePersonAsync(session As SupabaseSession, name As String, note As String, cancellationToken As CancellationToken) As Task(Of PersonRecord)
            Dim rows = Await _client.InsertResourceAsync(Of List(Of PersonRecord))(
                "people",
                New With {.owner_id = session.UserId, .name = name.Trim(), .note = If(String.IsNullOrWhiteSpace(note), Nothing, note.Trim())},
                session.AccessToken,
                cancellationToken).ConfigureAwait(False)
            Return FirstOrDefault(rows)
        End Function

        Public Async Function UpdatePersonAsync(session As SupabaseSession, personId As Guid, name As String, note As String, cancellationToken As CancellationToken) As Task(Of PersonRecord)
            Dim resource = $"people?id=eq.{personId:D}&owner_id=eq.{session.UserId:D}"
            Dim rows = Await _client.UpdateResourceAsync(Of List(Of PersonRecord))(
                resource,
                New With {.name = name.Trim(), .note = If(String.IsNullOrWhiteSpace(note), Nothing, note.Trim())},
                session.AccessToken,
                cancellationToken).ConfigureAwait(False)
            Return FirstOrDefault(rows)
        End Function

        Public Function DeletePersonAsync(session As SupabaseSession, personId As Guid, cancellationToken As CancellationToken) As Task
            Return _client.DeleteResourceAsync($"people?id=eq.{personId:D}&owner_id=eq.{session.UserId:D}", session.AccessToken, cancellationToken)
        End Function

        Public Function GetPlacesAsync(session As SupabaseSession, cancellationToken As CancellationToken) As Task(Of List(Of PlaceRecord))
            Return _client.GetResourceAsync(Of List(Of PlaceRecord))("places?select=id,owner_id,name,category,address&order=name.asc", session.AccessToken, cancellationToken)
        End Function

        Public Async Function CreatePlaceAsync(session As SupabaseSession, name As String, category As String, address As String, cancellationToken As CancellationToken) As Task(Of PlaceRecord)
            Dim rows = Await _client.InsertResourceAsync(Of List(Of PlaceRecord))(
                "places",
                New With {
                    .owner_id = session.UserId,
                    .name = name.Trim(),
                    .category = If(String.IsNullOrWhiteSpace(category), Nothing, category.Trim()),
                    .address = If(String.IsNullOrWhiteSpace(address), Nothing, address.Trim())
                },
                session.AccessToken,
                cancellationToken).ConfigureAwait(False)
            Return FirstOrDefault(rows)
        End Function

        Public Async Function UpdatePlaceAsync(session As SupabaseSession, placeId As Guid, name As String, category As String, address As String, cancellationToken As CancellationToken) As Task(Of PlaceRecord)
            Dim resource = $"places?id=eq.{placeId:D}&owner_id=eq.{session.UserId:D}"
            Dim rows = Await _client.UpdateResourceAsync(Of List(Of PlaceRecord))(
                resource,
                New With {
                    .name = name.Trim(),
                    .category = If(String.IsNullOrWhiteSpace(category), Nothing, category.Trim()),
                    .address = If(String.IsNullOrWhiteSpace(address), Nothing, address.Trim())
                },
                session.AccessToken,
                cancellationToken).ConfigureAwait(False)
            Return FirstOrDefault(rows)
        End Function

        Public Function DeletePlaceAsync(session As SupabaseSession, placeId As Guid, cancellationToken As CancellationToken) As Task
            Return _client.DeleteResourceAsync($"places?id=eq.{placeId:D}&owner_id=eq.{session.UserId:D}", session.AccessToken, cancellationToken)
        End Function

        Public Function CreateGroupAsync(session As SupabaseSession, groupType As String, name As String, eventDate As DateOnly, placeId As Guid?, ownerPersonId As Guid, personIds As Guid(), cancellationToken As CancellationToken) As Task(Of Guid)
            Dim parameters = New With {
                .p_type = groupType,
                .p_name = name.Trim(),
                .p_event_date = eventDate.ToString("yyyy-MM-dd", Globalization.CultureInfo.InvariantCulture),
                .p_place_id = placeId,
                .p_owner_person_id = ownerPersonId,
                .p_person_ids = If(personIds, Array.Empty(Of Guid)())
            }
            Return _client.RpcAsync(Of Guid)("create_group", parameters, session.AccessToken, cancellationToken)
        End Function

        Public Async Function GetVisibleGroupsAsync(session As SupabaseSession, cancellationToken As CancellationToken) As Task(Of List(Of GroupRecord))
            Try
                Await _client.RpcAsync(Of JsonElement)("claim_my_memberships", New Dictionary(Of String, Object)(), session.AccessToken, cancellationToken).ConfigureAwait(False)
            Catch
            End Try
            Return Await _client.GetResourceAsync(Of List(Of GroupRecord))("groups?select=*&order=event_date.desc,created_at.desc", session.AccessToken, cancellationToken).ConfigureAwait(False)
        End Function

        Public Async Function GetGroupAsync(session As SupabaseSession, groupId As Guid, cancellationToken As CancellationToken) As Task(Of GroupRecord)
            Dim groups = Await _client.GetResourceAsync(Of List(Of GroupRecord))($"groups?id=eq.{groupId:D}&select=*&limit=1", session.AccessToken, cancellationToken).ConfigureAwait(False)
            Return FirstOrDefault(groups)
        End Function

        Public Function GetMyMembershipsAsync(session As SupabaseSession, cancellationToken As CancellationToken) As Task(Of List(Of GroupMemberRecord))
            Return _client.GetResourceAsync(Of List(Of GroupMemberRecord))($"group_members?select=id,group_id,person_id,user_id,role&user_id=eq.{session.UserId:D}&order=created_at.asc", session.AccessToken, cancellationToken)
        End Function

        Public Function GetGroupMembersAsync(session As SupabaseSession, groupId As Guid, cancellationToken As CancellationToken) As Task(Of List(Of GroupMemberRecord))
            Return _client.GetResourceAsync(Of List(Of GroupMemberRecord))($"group_members?select=id,group_id,person_id,user_id,role,person:people(name)&group_id=eq.{groupId:D}&order=created_at.asc", session.AccessToken, cancellationToken)
        End Function

        Public Async Function PreviewInviteAsync(session As SupabaseSession, inviteCode As String, cancellationToken As CancellationToken) As Task(Of InvitePreview)
            Dim result = Await _client.RpcAsync(Of JsonElement)("preview_invite", New With {.p_invite_code = inviteCode.Trim()}, session.AccessToken, cancellationToken).ConfigureAwait(False)
            Return JsonSerializer.Deserialize(Of InvitePreview)(result.GetRawText(), DeserializerOptions)
        End Function

        Public Async Function RequestJoinAsync(session As SupabaseSession, inviteCode As String, claimedMemberId As Guid?, proposedName As String, cancellationToken As CancellationToken) As Task(Of JsonElement)
            Dim parameters As New Dictionary(Of String, Object) From {
                {"p_invite_code", inviteCode.Trim()},
                {"p_claimed_member_id", If(claimedMemberId.HasValue, CType(claimedMemberId.Value, Object), Nothing)},
                {"p_proposed_name", If(String.IsNullOrWhiteSpace(proposedName), Nothing, proposedName.Trim())}
            }
            Return Await _client.RpcAsync(Of JsonElement)("request_to_join", parameters, session.AccessToken, cancellationToken).ConfigureAwait(False)
        End Function

        Public Async Function JoinGroupWithCodeAsync(session As SupabaseSession, inviteCode As String, memberName As String, cancellationToken As CancellationToken) As Task(Of JsonElement)
            Dim parameters As New Dictionary(Of String, Object) From {
                {"p_invite_code", inviteCode.Trim()},
                {"p_member_name", memberName.Trim()}
            }
            Return Await _client.RpcAsync(Of JsonElement)("join_group_with_code", parameters, session.AccessToken, cancellationToken).ConfigureAwait(False)
        End Function

        Public Async Function GetPendingJoinRequestsAsync(session As SupabaseSession, groupId As Guid, cancellationToken As CancellationToken) As Task(Of List(Of JoinRequestRecord))
            Dim result = Await _client.RpcAsync(Of JsonElement)("get_group_join_requests", New With {.p_group_id = groupId}, session.AccessToken, cancellationToken).ConfigureAwait(False)
            Return JsonSerializer.Deserialize(Of List(Of JoinRequestRecord))(result.GetRawText(), DeserializerOptions)
        End Function

        Public Function ReviewJoinRequestAsync(session As SupabaseSession, requestId As Guid, approve As Boolean, cancellationToken As CancellationToken) As Task(Of Guid)
            Return _client.RpcAsync(Of Guid)("review_join_request", New With {.p_request_id = requestId, .p_approve = approve}, session.AccessToken, cancellationToken)
        End Function

        Public Function UpdateGroupAsync(session As SupabaseSession, groupId As Guid, name As String, eventDate As DateOnly, placeId As Guid?, cancellationToken As CancellationToken) As Task(Of JsonElement)
            Return _client.RpcAsync(Of JsonElement)(
                "update_group_details",
                New With {.p_group_id = groupId, .p_name = name.Trim(), .p_event_date = eventDate.ToString("yyyy-MM-dd", Globalization.CultureInfo.InvariantCulture), .p_place_id = placeId},
                session.AccessToken,
                cancellationToken)
        End Function

        Public Function AddGroupMemberAsync(session As SupabaseSession, groupId As Guid, personId As Guid, cancellationToken As CancellationToken) As Task(Of Guid)
            Return _client.RpcAsync(Of Guid)("add_group_member", New With {.p_group_id = groupId, .p_person_id = personId}, session.AccessToken, cancellationToken)
        End Function

        Public Function RemoveGroupMemberAsync(session As SupabaseSession, groupId As Guid, memberId As Guid, cancellationToken As CancellationToken) As Task(Of JsonElement)
            Return _client.RpcAsync(Of JsonElement)("remove_group_member", New With {.p_group_id = groupId, .p_member_id = memberId}, session.AccessToken, cancellationToken)
        End Function

        Public Function SetInviteEnabledAsync(session As SupabaseSession, groupId As Guid, enabled As Boolean, cancellationToken As CancellationToken) As Task(Of JsonElement)
            Return _client.RpcAsync(Of JsonElement)("set_invite_enabled", New With {.p_group_id = groupId, .p_enabled = enabled}, session.AccessToken, cancellationToken)
        End Function

        Public Function RegenerateInviteCodeAsync(session As SupabaseSession, groupId As Guid, cancellationToken As CancellationToken) As Task(Of String)
            Return _client.RpcAsync(Of String)("regenerate_invite_code", New With {.p_group_id = groupId}, session.AccessToken, cancellationToken)
        End Function

        Public Function GetExpensesAsync(session As SupabaseSession, groupId As Guid, cancellationToken As CancellationToken) As Task(Of List(Of ExpenseRecord))
            Return _client.GetResourceAsync(Of List(Of ExpenseRecord))($"expenses?group_id=eq.{groupId:D}&select=*&order=expense_date.desc,created_at.desc", session.AccessToken, cancellationToken)
        End Function

        Public Function GetExpensePayersAsync(session As SupabaseSession, expenseId As Guid, cancellationToken As CancellationToken) As Task(Of List(Of ExpensePayerRecord))
            Return _client.GetResourceAsync(Of List(Of ExpensePayerRecord))($"expense_payers?expense_id=eq.{expenseId:D}&select=*&order=created_at.asc", session.AccessToken, cancellationToken)
        End Function

        Public Function GetExpenseSharesAsync(session As SupabaseSession, expenseId As Guid, cancellationToken As CancellationToken) As Task(Of List(Of ExpenseShareRecord))
            Return _client.GetResourceAsync(Of List(Of ExpenseShareRecord))($"expense_shares?expense_id=eq.{expenseId:D}&select=*&order=created_at.asc", session.AccessToken, cancellationToken)
        End Function

        Public Function GetExpenseItemsAsync(session As SupabaseSession, expenseId As Guid, cancellationToken As CancellationToken) As Task(Of List(Of ExpenseItemRecord))
            Return _client.GetResourceAsync(Of List(Of ExpenseItemRecord))($"expense_items?expense_id=eq.{expenseId:D}&select=*&order=created_at.asc", session.AccessToken, cancellationToken)
        End Function

        Public Function CreateExpenseAsync(session As SupabaseSession, groupId As Guid, name As String, totalAmount As Long, adjustmentAmount As Long, expenseDate As DateOnly, splitMethod As String, note As String, payers As Object, shares As Object, items As Object, cancellationToken As CancellationToken, Optional orderIds As Guid() = Nothing) As Task(Of Guid)
            Dim parameters = New With {
                .p_group_id = groupId,
                .p_name = name.Trim(),
                .p_total_amount = totalAmount,
                .p_adjustment_amount = adjustmentAmount,
                .p_expense_date = expenseDate.ToString("yyyy-MM-dd", Globalization.CultureInfo.InvariantCulture),
                .p_split_method = splitMethod,
                .p_note = note,
                .p_payers = payers,
                .p_shares = shares,
                .p_items = If(items, New Object() {}),
                .p_order_ids = If(orderIds IsNot Nothing AndAlso orderIds.Length > 0, orderIds, CType(Nothing, Guid()))
            }
            Return _client.RpcAsync(Of Guid)("create_expense", parameters, session.AccessToken, cancellationToken)
        End Function

        Public Function LinkOrdersToExpenseAsync(session As SupabaseSession, expenseId As Guid, orderIds As Guid(), cancellationToken As CancellationToken) As Task
            Return _client.RpcAsync(Of JsonElement)("link_orders_to_expense", New With {.p_expense_id = expenseId, .p_order_ids = orderIds}, session.AccessToken, cancellationToken)
        End Function

        Public Function DeleteExpenseAsync(session As SupabaseSession, expenseId As Guid, cancellationToken As CancellationToken) As Task
            Return _client.RpcAsync(Of JsonElement)("delete_expense", New With {.p_expense_id = expenseId}, session.AccessToken, cancellationToken)
        End Function

        Public Function GetOrderSubmissionsAsync(session As SupabaseSession, groupId As Guid, cancellationToken As CancellationToken) As Task(Of List(Of OrderSubmissionRecord))
            Return _client.GetResourceAsync(Of List(Of OrderSubmissionRecord))($"order_submissions?group_id=eq.{groupId:D}&select=*&order=created_at.asc", session.AccessToken, cancellationToken)
        End Function

        Public Function SubmitOrderAsync(session As SupabaseSession, groupId As Guid, memberId As Guid, itemName As String, unitPrice As Long, qty As Integer, note As String, cancellationToken As CancellationToken) As Task(Of Guid)
            Dim parameters = New With {
                .p_group_id = groupId,
                .p_member_id = memberId,
                .p_item_name = itemName.Trim(),
                .p_unit_price = unitPrice,
                .p_qty = qty,
                .p_note = If(String.IsNullOrWhiteSpace(note), Nothing, note.Trim())
            }
            Return _client.RpcAsync(Of Guid)("submit_order", parameters, session.AccessToken, cancellationToken)
        End Function

        Public Function ReviewOrderSubmissionAsync(session As SupabaseSession, submissionId As Guid, approve As Boolean, cancellationToken As CancellationToken) As Task
            Return _client.RpcAsync(Of JsonElement)("review_order_submission", New With {.p_submission_id = submissionId, .p_approve = approve}, session.AccessToken, cancellationToken)
        End Function

        Public Function GetGroupBalancesAsync(session As SupabaseSession, groupId As Guid, cancellationToken As CancellationToken) As Task(Of List(Of GroupBalanceRecord))
            Return _client.GetResourceAsync(Of List(Of GroupBalanceRecord))($"group_balances?group_id=eq.{groupId:D}&select=*&order=created_at.asc", session.AccessToken, cancellationToken)
        End Function

        Public Function GetSettlementsAsync(session As SupabaseSession, groupId As Guid, cancellationToken As CancellationToken) As Task(Of List(Of SettlementRecord))
            Return _client.GetResourceAsync(Of List(Of SettlementRecord))($"settlements?group_id=eq.{groupId:D}&select=*&order=created_at.asc", session.AccessToken, cancellationToken)
        End Function

        Public Function FinalizeGroupSettlementAsync(session As SupabaseSession, groupId As Guid, cancellationToken As CancellationToken) As Task(Of JsonElement)
            Return _client.RpcAsync(Of JsonElement)("finalize_group_settlement", New With {.p_group_id = groupId}, session.AccessToken, cancellationToken)
        End Function

        Public Function MarkSettlementPaidAsync(session As SupabaseSession, settlementId As Guid, cancellationToken As CancellationToken) As Task
            Return _client.RpcAsync(Of JsonElement)("mark_settlement_paid", New With {.p_settlement_id = settlementId}, session.AccessToken, cancellationToken)
        End Function

        Public Function ConfirmSettlementPaymentAsync(session As SupabaseSession, settlementId As Guid, cancellationToken As CancellationToken) As Task
            Return _client.RpcAsync(Of JsonElement)("confirm_settlement_payment", New With {.p_settlement_id = settlementId}, session.AccessToken, cancellationToken)
        End Function

        Private Shared Function FirstOrDefault(Of T As Class)(items As List(Of T)) As T
            If items Is Nothing OrElse items.Count = 0 Then Return Nothing
            Return items(0)
        End Function
    End Class
End Namespace
