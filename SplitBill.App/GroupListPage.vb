Option Explicit On
Option Strict On
Option Infer On

Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports SplitBill.Data

Namespace Global.SplitBill.App
    Partial Class GroupListPage
        Private ReadOnly _repository As SplitBillRepository
        Private ReadOnly _session As SupabaseSession

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub New(repository As SplitBillRepository, session As SupabaseSession, Optional initialTab As String = Nothing)
            Me.New()
            _repository = repository
            _session = session

            If Not String.IsNullOrWhiteSpace(initialTab) AndAlso (initialTab.IndexOf("Selesai", StringComparison.OrdinalIgnoreCase) >= 0 OrElse initialTab.IndexOf("Riwayat", StringComparison.OrdinalIgnoreCase) >= 0) Then
                TabsControl.SelectedIndex = 1
            End If

            AddHandler BtnNewGroup.Click, Sub(s, e) RaiseEvent CreateGroupRequested(Me, EventArgs.Empty)
            AddHandler BtnReload.Click, AddressOf ReloadButtonClicked
            AddHandler BtnOpenSelected.Click, AddressOf OpenCurrentSelectedGroup
            AddHandler BtnJoinWithCode.Click, Sub(s, e) RaiseEvent JoinGroupRequested(Me, EventArgs.Empty)

            AddHandler ActiveGroupsList.DoubleClick, AddressOf OpenSelectedGroup
            AddHandler CompletedGroupsList.DoubleClick, AddressOf OpenSelectedGroup
            AddHandler AllGroupsList.DoubleClick, AddressOf OpenSelectedGroup
            AddHandler Load, AddressOf LoadAsync
        End Sub

        Public Event GroupSelected As EventHandler(Of GroupNavigationEventArgs)
        Public Event CreateGroupRequested As EventHandler
        Public Event JoinGroupRequested As EventHandler

        Private Async Sub LoadAsync(sender As Object, e As EventArgs)
            Await ReloadAsync()
        End Sub

        Private Async Sub ReloadButtonClicked(sender As Object, e As EventArgs)
            Await ReloadAsync()
        End Sub

        Public Async Function ReloadAsync() As Task
            If _repository Is Nothing OrElse _session Is Nothing Then Return
            Try
                StatusLabel.Text = "Memuat data kegiatan..."
                StatusLabel.ForeColor = UiTheme.MutedTextColor

                Dim groups = Await _repository.GetVisibleGroupsAsync(_session, CancellationToken.None)
                Dim activeGroups = groups.Where(Function(g) g.Status = "active").OrderByDescending(Function(g) g.EventDate).ToList()
                Dim completedGroups = groups.Where(Function(g) g.Status <> "active").OrderByDescending(Function(g) g.EventDate).ToList()

                FillGroups(ActiveGroupsList, activeGroups)
                FillGroups(CompletedGroupsList, completedGroups)
                FillGroups(AllGroupsList, groups.OrderByDescending(Function(g) g.EventDate).ToList())

                If groups.Count = 0 Then
                    StatusLabel.Text = "Belum ada kegiatan. Buat kegiatan baru atau gabung menggunakan kode undangan."
                Else
                    StatusLabel.Text = $"Total {groups.Count} kegiatan ditemukan ({activeGroups.Count} aktif, {completedGroups.Count} selesai)."
                End If
            Catch ex As Exception
                StatusLabel.Text = ex.Message
                StatusLabel.ForeColor = UiTheme.ErrorColor
            End Try
        End Function

        Private Sub OpenCurrentSelectedGroup(sender As Object, e As EventArgs)
            Dim currentList = GetCurrentListBox()
            Dim item = TryCast(currentList.SelectedItem, GroupListItem)
            If item IsNot Nothing Then
                RaiseEvent GroupSelected(Me, New GroupNavigationEventArgs(item.Group.Id))
            Else
                MessageBox.Show("Pilih salah satu kegiatan dalam daftar terlebih dahulu.", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Sub

        Private Sub OpenSelectedGroup(sender As Object, e As EventArgs)
            Dim list = TryCast(sender, ListBox)
            Dim item = If(list Is Nothing, Nothing, TryCast(list.SelectedItem, GroupListItem))
            If item IsNot Nothing Then
                RaiseEvent GroupSelected(Me, New GroupNavigationEventArgs(item.Group.Id))
            End If
        End Sub

        Private Function GetCurrentListBox() As ListBox
            Select Case TabsControl.SelectedIndex
                Case 0 : Return ActiveGroupsList
                Case 1 : Return CompletedGroupsList
                Case Else : Return AllGroupsList
            End Select
        End Function

        Private Shared Sub FillGroups(list As ListBox, groups As IEnumerable(Of GroupRecord))
            list.BeginUpdate()
            list.Items.Clear()
            For Each group In groups
                list.Items.Add(New GroupListItem(group))
            Next
            list.EndUpdate()
        End Sub

        Public NotInheritable Class GroupListItem
            Public ReadOnly Property Group As GroupRecord
            Private ReadOnly _text As String

            Public Sub New(group As GroupRecord)
                Me.Group = group
                Dim icon = If(group.Type = "trip", "🚗", If(group.Type = "hangout", "☕", "🛍️"))
                Dim status = If(group.Status = "active", "• Aktif", "✓ Selesai")
                Dim typeStr = If(group.Type = "hangout", "Nongkrong / Makan Bersama", If(group.Type = "trip", "Perjalanan Bersama", "Pembelian / Sewa"))
                _text = $"{icon}  {group.Name}   [{status}]   ·   {typeStr}   ·   📅 {group.EventDate:dd MMM yyyy}"
            End Sub

            Public Overrides Function ToString() As String
                Return _text
            End Function
        End Class
    End Class
End Namespace