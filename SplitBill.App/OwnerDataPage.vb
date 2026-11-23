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
    Partial Class OwnerDataPage
        Private ReadOnly _repository As SplitBillRepository
        Private ReadOnly _session As SupabaseSession
        Private _people As List(Of PersonRecord) = New List(Of PersonRecord)
        Private _places As List(Of PlaceRecord) = New List(Of PlaceRecord)
        Private _selectedPerson As PersonRecord
        Private _selectedPlace As PlaceRecord
        Private _refreshing As Boolean

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub New(repository As SplitBillRepository, session As SupabaseSession, initialTab As String)
            Me.New()
            _repository = repository
            _session = session

            TabsControl.SelectedIndex = If(String.Equals(initialTab, "Tempat", StringComparison.OrdinalIgnoreCase), 1, 0)

            PeopleList.DisplayMember = NameOf(PersonRecord.Name)
            PlacesList.DisplayMember = NameOf(PlaceRecord.Name)

            AddHandler BtnReload.Click, Async Sub(s, e) Await ReloadAsync()

            AddHandler PeopleSearchText.TextChanged, Sub(sender, args) FilterPeople()
            AddHandler PeopleList.SelectedIndexChanged, AddressOf SelectPerson
            AddHandler BtnSavePerson.Click, AddressOf SavePersonAsync
            AddHandler BtnDeletePerson.Click, AddressOf DeletePersonAsync
            AddHandler BtnClearPerson.Click, AddressOf ClearPerson

            AddHandler PlacesSearchText.TextChanged, Sub(sender, args) FilterPlaces()
            AddHandler PlacesList.SelectedIndexChanged, AddressOf SelectPlace
            AddHandler BtnSavePlace.Click, AddressOf SavePlaceAsync
            AddHandler BtnDeletePlace.Click, AddressOf DeletePlaceAsync
            AddHandler BtnClearPlace.Click, AddressOf ClearPlace

            AddHandler Load, AddressOf LoadDataAsync
        End Sub

        Private Async Sub LoadDataAsync(sender As Object, e As EventArgs)
            Await ReloadAsync()
        End Sub

        Public Async Function ReloadAsync() As Task
            If _repository Is Nothing OrElse _session Is Nothing Then Return
            _refreshing = True
            Try
                _people = Await _repository.GetPeopleAsync(_session, CancellationToken.None)
                _places = Await _repository.GetPlacesAsync(_session, CancellationToken.None)
                FilterPeople()
                FilterPlaces()
            Catch ex As Exception
                PeopleStatusLabel.Text = ex.Message
                PeopleStatusLabel.ForeColor = UiTheme.ErrorColor
            Finally
                _refreshing = False
            End Try
        End Function

        Private Sub FilterPeople()
            Dim query = PeopleSearchText.Text.Trim()
            PeopleList.BeginUpdate()
            PeopleList.Items.Clear()
            For Each person In _people.Where(Function(item) item.Name.Contains(query, StringComparison.OrdinalIgnoreCase))
                PeopleList.Items.Add(person)
            Next
            PeopleList.EndUpdate()
        End Sub

        Private Sub FilterPlaces()
            Dim query = PlacesSearchText.Text.Trim()
            PlacesList.BeginUpdate()
            PlacesList.Items.Clear()
            For Each place In _places.Where(Function(item) item.Name.Contains(query, StringComparison.OrdinalIgnoreCase) OrElse If(item.Address, String.Empty).Contains(query, StringComparison.OrdinalIgnoreCase))
                PlacesList.Items.Add(place)
            Next
            PlacesList.EndUpdate()
        End Sub

        Private Sub SelectPerson(sender As Object, e As EventArgs)
            If _refreshing Then Return
            _selectedPerson = TryCast(PeopleList.SelectedItem, PersonRecord)
            PeopleNameText.Text = If(_selectedPerson?.Name, String.Empty)
            PeopleNoteText.Text = If(_selectedPerson?.Note, String.Empty)
        End Sub

        Private Sub SelectPlace(sender As Object, e As EventArgs)
            If _refreshing Then Return
            _selectedPlace = TryCast(PlacesList.SelectedItem, PlaceRecord)
            PlacesNameText.Text = If(_selectedPlace?.Name, String.Empty)
            PlacesCategoryText.Text = If(_selectedPlace?.Category, String.Empty)
            PlacesAddressText.Text = If(_selectedPlace?.Address, String.Empty)
        End Sub

        Private Async Sub SavePersonAsync(sender As Object, e As EventArgs)
            If String.IsNullOrWhiteSpace(PeopleNameText.Text) Then
                SetStatus(PeopleStatusLabel, "Nama teman wajib diisi.", True)
                Return
            End If
            Try
                If _selectedPerson Is Nothing Then
                    Await _repository.CreatePersonAsync(_session, PeopleNameText.Text, PeopleNoteText.Text, CancellationToken.None)
                Else
                    Await _repository.UpdatePersonAsync(_session, _selectedPerson.Id, PeopleNameText.Text, PeopleNoteText.Text, CancellationToken.None)
                End If
                ClearPerson(sender, e)
                Await ReloadAsync()
                SetStatus(PeopleStatusLabel, "Data teman tersimpan.", False)
            Catch ex As Exception
                SetStatus(PeopleStatusLabel, ex.Message, True)
            End Try
        End Sub

        Private Async Sub DeletePersonAsync(sender As Object, e As EventArgs)
            If _selectedPerson Is Nothing Then Return
            If MessageBox.Show($"Hapus {_selectedPerson.Name} dari database teman?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
            Try
                Await _repository.DeletePersonAsync(_session, _selectedPerson.Id, CancellationToken.None)
                ClearPerson(sender, e)
                Await ReloadAsync()
                SetStatus(PeopleStatusLabel, "Data teman dihapus.", False)
            Catch ex As Exception
                SetStatus(PeopleStatusLabel, ex.Message, True)
            End Try
        End Sub

        Private Sub ClearPerson(sender As Object, e As EventArgs)
            _selectedPerson = Nothing
            PeopleList.ClearSelected()
            PeopleNameText.Clear()
            PeopleNoteText.Clear()
        End Sub

        Private Async Sub SavePlaceAsync(sender As Object, e As EventArgs)
            If String.IsNullOrWhiteSpace(PlacesNameText.Text) Then
                SetStatus(PlacesStatusLabel, "Nama tempat wajib diisi.", True)
                Return
            End If
            Try
                If _selectedPlace Is Nothing Then
                    Await _repository.CreatePlaceAsync(_session, PlacesNameText.Text, PlacesCategoryText.Text, PlacesAddressText.Text, CancellationToken.None)
                Else
                    Await _repository.UpdatePlaceAsync(_session, _selectedPlace.Id, PlacesNameText.Text, PlacesCategoryText.Text, PlacesAddressText.Text, CancellationToken.None)
                End If
                ClearPlace(sender, e)
                Await ReloadAsync()
                SetStatus(PlacesStatusLabel, "Data tempat tersimpan.", False)
            Catch ex As Exception
                SetStatus(PlacesStatusLabel, ex.Message, True)
            End Try
        End Sub

        Private Async Sub DeletePlaceAsync(sender As Object, e As EventArgs)
            If _selectedPlace Is Nothing Then Return
            If MessageBox.Show($"Hapus {_selectedPlace.Name} dari database tempat?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then Return
            Try
                Await _repository.DeletePlaceAsync(_session, _selectedPlace.Id, CancellationToken.None)
                ClearPlace(sender, e)
                Await ReloadAsync()
                SetStatus(PlacesStatusLabel, "Data tempat dihapus.", False)
            Catch ex As Exception
                SetStatus(PlacesStatusLabel, ex.Message, True)
            End Try
        End Sub

        Private Sub ClearPlace(sender As Object, e As EventArgs)
            _selectedPlace = Nothing
            PlacesList.ClearSelected()
            PlacesNameText.Clear()
            PlacesCategoryText.Clear()
            PlacesAddressText.Clear()
        End Sub

        Private Shared Sub SetStatus(label As Label, message As String, isError As Boolean)
            label.Text = message
            label.ForeColor = If(isError, UiTheme.ErrorColor, UiTheme.PrimaryDarkColor)
        End Sub
    End Class
End Namespace
