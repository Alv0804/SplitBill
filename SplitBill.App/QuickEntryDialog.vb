Option Explicit On
Option Strict On
Option Infer On

Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Windows.Forms

Namespace Global.SplitBill.App
    Partial Class QuickEntryDialog
        Private ReadOnly _inputs As New List(Of TextBox)

        Public Sub New()
            InitializeComponent()
        End Sub

        Public Sub New(title As String, fieldNames As IReadOnlyList(Of String))
            Me.New()
            If fieldNames Is Nothing OrElse fieldNames.Count = 0 Then Throw New ArgumentException("Minimal satu kolom wajib disediakan.", NameOf(fieldNames))
            Text = title
            MinimumSize = New Size(480, 240)
            ClientSize = New Size(520, Math.Max(240, fieldNames.Count * 82 + 90))

            FieldsPanel.Controls.Clear()
            FieldsPanel.RowCount = fieldNames.Count
            FieldsPanel.RowStyles.Clear()

            For index = 0 To fieldNames.Count - 1
                FieldsPanel.RowStyles.Add(New RowStyle(SizeType.Percent, 100.0F / fieldNames.Count))
                Dim fieldLayout As New TableLayoutPanel With {.Dock = DockStyle.Fill, .ColumnCount = 2, .RowCount = 1}
                fieldLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Absolute, 110.0F))
                fieldLayout.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 100.0F))
                Dim label As New Label With {.Text = fieldNames(index), .Dock = DockStyle.Fill, .TextAlign = ContentAlignment.MiddleLeft, .ForeColor = UiTheme.TextColor}
                Dim input As New TextBox With {.Dock = DockStyle.Fill, .Font = New Font("Segoe UI", 10.0F)}
                If fieldNames(index).Contains("Catatan", StringComparison.OrdinalIgnoreCase) OrElse fieldNames(index).Contains("Alamat", StringComparison.OrdinalIgnoreCase) Then
                    input.Multiline = True
                    input.Height = 54
                End If
                _inputs.Add(input)
                fieldLayout.Controls.Add(label, 0, 0)
                fieldLayout.Controls.Add(input, 1, 0)
                FieldsPanel.Controls.Add(fieldLayout, 0, index)
            Next

            AddHandler BtnSave.Click, AddressOf SaveClicked
        End Sub

        Public ReadOnly Property Values As String()
            Get
                Return _inputs.ConvertAll(Function(input) input.Text.Trim()).ToArray()
            End Get
        End Property

        Private Sub SaveClicked(sender As Object, e As EventArgs)
            If _inputs.Count > 0 AndAlso String.IsNullOrWhiteSpace(_inputs(0).Text) Then
                Dim fieldName = If(_inputs(0).Parent IsNot Nothing AndAlso _inputs(0).Parent.Controls.Count > 0, _inputs(0).Parent.Controls(0).Text, "Data")
                MessageBox.Show($"{fieldName} wajib diisi.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            DialogResult = DialogResult.OK
            Close()
        End Sub
    End Class
End Namespace
