Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Windows.Forms

Public Class ControlStackView
    Public Event DoClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs)
    'Private stackStrip As New ToolStrip
    Public Sub New()
        Me.InitializeComponent()

        ' Assign icons to ToolStripButton controls.
        'Me.InitializeImages()

        ' Set up renderers.
        Me.ToolStrip1.Renderer = New StackRenderer()
        Me.Dock = DockStyle.Fill
        Me.AutoSize = True
    End Sub


    Friend Class StackRenderer
        Inherits ToolStripProfessionalRenderer
        Private Shared titlebarColor1 As Color = System.Drawing.SystemColors.Control
        Private Shared titlebarColor2 As Color = System.Drawing.SystemColors.Control
        Private Shared titlebarColor3 As Color = System.Drawing.SystemColors.Control
        Private Shared titlebarColor4 As Color = System.Drawing.SystemColors.Control
        Private Shared titlebarColor5 As Color = System.Drawing.SystemColors.Control
        Private Shared titlebarColor6 As Color = System.Drawing.SystemColors.Control
        Private Shared titlebarColor7 As Color = System.Drawing.SystemColors.Control

        Private Shared titleBarGripBmp As Bitmap
        Private Shared titleBarGripEnc As String = "Qk16AQAAAAAAADYAAAAoAAAAIwAAAAMAAAABABgAAAAAAAAAAADEDgAAxA4AAAAAAAAAAAAAuGMy+/n5+/n5uGMyuGMy+/n5+/n5uGMyuGMy+/n5+/n5uGMyuGMy+/n5+/n5uGMyuGMy+/n5+/n5uGMyuGMy+/n5+/n5uGMyuGMy+/n5+/n5uGMyuGMy+/n5+/n5uGMyuGMy+/n5+/n5ANj+RzIomHRh+/n5wm8/RzIomHRh+/n5wm8/RzIomHRh+/n5wm8/RzIomHRh+/n5wm8/RzIomHRh+/n5wm8/RzIomHRh+/n5wm8/RzIomHRh+/n5wm8/RzIomHRh+/n5wm8/RzIomHRh+/n5ANj+RzIoRzIozHtMzHtMRzIoRzIozHtMzHtMRzIoRzIozHtMzHtMRzIoRzIozHtMzHtMRzIoRzIozHtMzHtMRzIoRzIozHtMzHtMRzIoRzIozHtMzHtMRzIoRzIozHtMzHtMRzIoRzIozHtMANj+"

        ' Define titlebar colors.



        'Private Shared titlebarColor2 As Color = Color.FromArgb(76, 123, 204)
        'Private Shared titlebarColor3 As Color = Color.FromArgb(63, 111, 194)
        'Private Shared titlebarColor4 As Color = Color.FromArgb(50, 99, 184)
        'Private Shared titlebarColor5 As Color = Color.FromArgb(38, 88, 174)
        'Private Shared titlebarColor6 As Color = Color.FromArgb(25, 76, 164)
        'Private Shared titlebarColor7 As Color = Color.FromArgb(12, 64, 154)

        Private Shared borderColor As Color = Color.FromArgb(0, 0, 128)

        Shared Sub New()
            titleBarGripBmp = StackView.DeserializeFromBase64(titleBarGripEnc)

            Try
                titlebarColor1 = Color.FromArgb(System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor.MenuHighlight).R, Color.FromKnownColor(KnownColor.MenuHighlight).G, Color.FromKnownColor(KnownColor.MenuHighlight).B)
                titlebarColor2 = Color.FromArgb(Color.FromKnownColor(KnownColor.MenuHighlight).R - 7, Color.FromKnownColor(KnownColor.MenuHighlight).G - 6, Color.FromKnownColor(KnownColor.MenuHighlight).B - 6)
                titlebarColor3 = Color.FromArgb(Color.FromKnownColor(KnownColor.MenuHighlight).R - 14, Color.FromKnownColor(KnownColor.MenuHighlight).G - 12, Color.FromKnownColor(KnownColor.MenuHighlight).B - 12)
                titlebarColor4 = Color.FromArgb(Color.FromKnownColor(KnownColor.MenuHighlight).R - 21, Color.FromKnownColor(KnownColor.MenuHighlight).G - 18, Color.FromKnownColor(KnownColor.MenuHighlight).B - 18)
                titlebarColor5 = Color.FromArgb(Color.FromKnownColor(KnownColor.MenuHighlight).R - 28, Color.FromKnownColor(KnownColor.MenuHighlight).G - 24, Color.FromKnownColor(KnownColor.MenuHighlight).B - 24)
                titlebarColor6 = Color.FromArgb(Color.FromKnownColor(KnownColor.MenuHighlight).R - 35, Color.FromKnownColor(KnownColor.MenuHighlight).G - 30, Color.FromKnownColor(KnownColor.MenuHighlight).B - 30)
                titlebarColor7 = Color.FromArgb(Color.FromKnownColor(KnownColor.MenuHighlight).R - 42, Color.FromKnownColor(KnownColor.MenuHighlight).G - 36, Color.FromKnownColor(KnownColor.MenuHighlight).B - 36)

            Catch ex As Exception
                titlebarColor1 = System.Drawing.SystemColors.Control
                titlebarColor2 = System.Drawing.SystemColors.Control
                titlebarColor3 = System.Drawing.SystemColors.Control
                titlebarColor4 = System.Drawing.SystemColors.Control
                titlebarColor5 = System.Drawing.SystemColors.Control
                titlebarColor6 = System.Drawing.SystemColors.Control
                titlebarColor7 = System.Drawing.SystemColors.Control
            End Try


        End Sub

        Public Sub New()
        End Sub

        Private Sub DrawTitleBar(ByVal g As Graphics, ByVal rect As Rectangle)

            ' Assign the image for the grip.
            'Dim titlebarGrip As Image = titleBarGripBmp

            ' Fill the titlebar. 
            ' This produces the gradient and the rounded-corner effect.
            'g.DrawLine(New Pen(titlebarColor1), rect.X, rect.Y, rect.X + rect.Width, rect.Y)
            'g.DrawLine(New Pen(titlebarColor2), rect.X, rect.Y + 1, rect.X + rect.Width, rect.Y + 1)
            'g.DrawLine(New Pen(titlebarColor3), rect.X, rect.Y + 2, rect.X + rect.Width, rect.Y + 2)
            'g.DrawLine(New Pen(titlebarColor4), rect.X, rect.Y + 3, rect.X + rect.Width, rect.Y + 3)
            'g.DrawLine(New Pen(titlebarColor5), rect.X, rect.Y + 4, rect.X + rect.Width, rect.Y + 4)
            'g.DrawLine(New Pen(titlebarColor6), rect.X, rect.Y + 5, rect.X + rect.Width, rect.Y + 5)
            'g.DrawLine(New Pen(titlebarColor7), rect.X, rect.Y + 6, rect.X + rect.Width, rect.Y + 6)

            ' Center the titlebar grip.
            'g.DrawImage(titlebarGrip, New Point(rect.X + (rect.Width / 2 - titlebarGrip.Width / 2), rect.Y + 1))
        End Sub


        ' This method handles the RenderGrip event.
        Protected Overrides Sub OnRenderGrip(ByVal e As ToolStripGripRenderEventArgs)
            DrawTitleBar(e.Graphics, New Rectangle(0, 0, e.ToolStrip.Width, 7))
        End Sub


        ' This method handles the RenderToolStripBorder event.
        Protected Overrides Sub OnRenderToolStripBorder(ByVal e As ToolStripRenderEventArgs)
            DrawTitleBar(e.Graphics, New Rectangle(0, 0, e.ToolStrip.Width, 7))
        End Sub


        ' This method handles the RenderButtonBackground event.
        Protected Overrides Sub OnRenderButtonBackground(ByVal e As ToolStripItemRenderEventArgs)
            Dim g As Graphics = e.Graphics
            Dim bounds As New Rectangle(Point.Empty, e.Item.Size)

            'Dim gradientBegin As System.Drawing.Color = System.Drawing.SystemColors.ControlLight
            'Dim gradientEnd As System.Drawing.Color = System.Drawing.SystemColors.MenuHighlight
            Dim gradientBegin As Color = Color.FromArgb(224, 224, 223)
            Dim gradientEnd As Color = Color.FromArgb(245, 245, 245)


            Dim button As ToolStripButton = CType(e.Item, ToolStripButton)
            Dim entrato As Boolean = False

            If button.Pressed OrElse button.Checked Then
                entrato = True
                gradientBegin = Color.FromArgb(229, 160, 37)
                gradientEnd = Color.FromArgb(250, 193, 74)
            ElseIf button.Selected Then
                gradientBegin = Color.LightGray
                gradientEnd = Color.LightGray
            End If

            Dim b = New LinearGradientBrush(bounds, gradientBegin, gradientEnd, LinearGradientMode.Vertical)
            Try
                g.FillRectangle(b, bounds)
            Finally
                b.Dispose()
            End Try

            'e.Graphics.DrawRectangle(SystemPens.ControlDarkDark, bounds)

            If (entrato) Then
                g.DrawLine(New Pen(Color.FromArgb(132, 23, 23)), bounds.X, bounds.Y, bounds.Width - 1, bounds.Y)
            Else
                g.DrawLine(SystemPens.ControlDarkDark, bounds.X, bounds.Y, bounds.Width - 1, bounds.Y)
            End If


            g.DrawLine(SystemPens.ControlDarkDark, bounds.X, bounds.Y, bounds.X, bounds.Height - 1)

            Dim toolStrip As ToolStrip = button.Owner
            Dim nextItem As ToolStripButton = CType(button.Owner.GetItemAt(button.Bounds.X, button.Bounds.Bottom + 1), ToolStripButton)

            'If nextItem Is Nothing Then
            '    g.DrawLine(SystemPens.ControlDarkDark, bounds.X, bounds.Height - 1, bounds.X + bounds.Width - 1, bounds.Height - 1)
            'End If


        End Sub
    End Class

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim item As ToolStripItem
        For Each item In Me.ToolStrip1.Items
            If item IsNot sender AndAlso TypeOf item Is ToolStripButton Then
                CType(item, ToolStripButton).Checked = False
            End If
        Next item
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripAmministrazione.Click
        Dim item As ToolStripItem
        For Each item In Me.ToolStrip1.Items
            If item IsNot sender AndAlso TypeOf item Is ToolStripButton Then
                CType(item, ToolStripButton).Checked = False
            End If
        Next item
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim item As ToolStripItem
        For Each item In Me.ToolStrip1.Items
            If item IsNot sender AndAlso TypeOf item Is ToolStripButton Then
                CType(item, ToolStripButton).Checked = False
            End If
        Next item
    End Sub


    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked
        RaiseEvent DoClick(sender, e)
    End Sub

   Private Sub ToolStripAppuntamenti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Dim item As ToolStripItem
      For Each item In Me.ToolStrip1.Items
         If item IsNot sender AndAlso TypeOf item Is ToolStripButton Then
            CType(item, ToolStripButton).Checked = False
         End If
      Next item
   End Sub

    Private Sub ToolStripComunicazioni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripComunicazioni.Click
        Dim item As ToolStripItem
        For Each item In Me.ToolStrip1.Items
            If item IsNot sender AndAlso TypeOf item Is ToolStripButton Then
                CType(item, ToolStripButton).Checked = False
            End If
        Next item
    End Sub

    Private Sub ToolStripDeleghe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripDeleghe.Click
        Dim item As ToolStripItem
        For Each item In Me.ToolStrip1.Items
            If item IsNot sender AndAlso TypeOf item Is ToolStripButton Then
                CType(item, ToolStripButton).Checked = False
            End If
        Next item
    End Sub

    Private Sub ToolStripDomandeOfferte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripDomandeOfferte.Click
        Dim item As ToolStripItem
        For Each item In Me.ToolStrip1.Items
            If item IsNot sender AndAlso TypeOf item Is ToolStripButton Then
                CType(item, ToolStripButton).Checked = False
            End If
        Next item
    End Sub

    Private Sub ToolStripPrestazioni_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripPrestazioni.Click
        Dim item As ToolStripItem
        For Each item In Me.ToolStrip1.Items
            If item IsNot sender AndAlso TypeOf item Is ToolStripButton Then
                CType(item, ToolStripButton).Checked = False
            End If
        Next item
    End Sub

    Private Sub ToolStripVertenze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripVertenze.Click
        Dim item As ToolStripItem
        For Each item In Me.ToolStrip1.Items
            If item IsNot sender AndAlso TypeOf item Is ToolStripButton Then
                CType(item, ToolStripButton).Checked = False
            End If
        Next item
    End Sub

    Private Sub ToolStripButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim item As ToolStripItem
        For Each item In Me.ToolStrip1.Items
            If item IsNot sender AndAlso TypeOf item Is ToolStripButton Then
                CType(item, ToolStripButton).Checked = False
            End If
        Next item
    End Sub
End Class
