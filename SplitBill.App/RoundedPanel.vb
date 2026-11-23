Option Explicit On
Option Strict On
Option Infer On

Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Namespace Global.SplitBill.App
    Public Class RoundedPanel
        Inherits Panel

        Private _cornerRadius As Integer = 14
        Private _borderColor As Color = UiTheme.BorderColor
        Private _showBorder As Boolean = True

        Public Sub New()
            DoubleBuffered = True
            SetStyle(ControlStyles.AllPaintingInWmPaint Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.ResizeRedraw Or ControlStyles.UserPaint, True)
            BackColor = UiTheme.CardColor
        End Sub

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property CornerRadius As Integer
            Get
                Return _cornerRadius
            End Get
            Set(value As Integer)
                _cornerRadius = Math.Max(2, value)
                Invalidate()
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property BorderColor As Color
            Get
                Return _borderColor
            End Get
            Set(value As Color)
                _borderColor = value
                Invalidate()
            End Set
        End Property

        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property ShowBorder As Boolean
            Get
                Return _showBorder
            End Get
            Set(value As Boolean)
                _showBorder = value
                Invalidate()
            End Set
        End Property

        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias
            Dim bounds = New Rectangle(0, 0, Width - 1, Height - 1)
            If bounds.Width <= 0 OrElse bounds.Height <= 0 Then Return

            Using path = CreateRoundedPath(bounds, _cornerRadius)
                Using background As New SolidBrush(BackColor)
                    e.Graphics.FillPath(background, path)
                End Using
                If _showBorder Then
                    Using border As New Pen(_borderColor, 1.0F)
                        e.Graphics.DrawPath(border, path)
                    End Using
                End If
            End Using
            MyBase.OnPaint(e)
        End Sub

        Private Shared Function CreateRoundedPath(bounds As Rectangle, radius As Integer) As GraphicsPath
            Dim path As New GraphicsPath()
            Dim diameter = Math.Min(radius * 2, Math.Min(bounds.Width, bounds.Height))
            If diameter <= 0 Then
                path.AddRectangle(bounds)
                Return path
            End If
            Dim arc As New Rectangle(bounds.X, bounds.Y, diameter, diameter)
            path.AddArc(arc, 180, 90)
            arc.X = bounds.Right - diameter
            path.AddArc(arc, 270, 90)
            arc.Y = bounds.Bottom - diameter
            path.AddArc(arc, 0, 90)
            arc.X = bounds.X
            path.AddArc(arc, 90, 90)
            path.CloseFigure()
            Return path
        End Function
    End Class
End Namespace
