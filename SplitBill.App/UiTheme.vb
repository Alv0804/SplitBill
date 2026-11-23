Option Explicit On
Option Strict On
Option Infer On

Imports System.Drawing

Namespace Global.SplitBill.App
    Friend Module UiTheme
        Public ReadOnly BackgroundColor As Color = Color.FromArgb(246, 248, 246)
        Public ReadOnly CardColor As Color = Color.White
        Public ReadOnly SidebarColor As Color = Color.White
        Public ReadOnly PrimaryColor As Color = Color.FromArgb(35, 122, 72)
        Public ReadOnly PrimaryHoverColor As Color = Color.FromArgb(27, 98, 58)
        Public ReadOnly PrimaryLightColor As Color = Color.FromArgb(235, 245, 237)
        Public ReadOnly PrimaryDarkColor As Color = Color.FromArgb(24, 75, 45)
        Public ReadOnly TextColor As Color = Color.FromArgb(17, 24, 39)
        Public ReadOnly MutedTextColor As Color = Color.FromArgb(107, 114, 128)
        Public ReadOnly BorderColor As Color = Color.FromArgb(229, 231, 235)
        Public ReadOnly ErrorColor As Color = Color.FromArgb(220, 38, 38)
        Public ReadOnly SuccessColor As Color = Color.FromArgb(22, 163, 74)
        Public ReadOnly WarningColor As Color = Color.FromArgb(217, 119, 6)
        Public ReadOnly InfoColor As Color = Color.FromArgb(37, 99, 235)

        ' Pill & Badge colors from the design reference
        Public ReadOnly BadgeGreenBg As Color = Color.FromArgb(232, 245, 233)
        Public ReadOnly BadgeGreenFg As Color = Color.FromArgb(46, 125, 50)
        Public ReadOnly BadgeBlueBg As Color = Color.FromArgb(227, 242, 253)
        Public ReadOnly BadgeBlueFg As Color = Color.FromArgb(25, 118, 210)
        Public ReadOnly BadgePurpleBg As Color = Color.FromArgb(237, 231, 246)
        Public ReadOnly BadgePurpleFg As Color = Color.FromArgb(103, 58, 183)
        Public ReadOnly BadgeAmberBg As Color = Color.FromArgb(255, 243, 224)
        Public ReadOnly BadgeAmberFg As Color = Color.FromArgb(245, 124, 0)
    End Module
End Namespace
