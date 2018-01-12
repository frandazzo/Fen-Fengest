Imports System.Drawing.Drawing2D
Imports System
Imports WIN.GUI.UTILITY

Public Class BrowserControl


    'Protected m_startColorVis As System.Drawing.Color = Drawing.Color.Lavender
    'Protected m_EndColorVis As System.Drawing.Color = Drawing.Color.CornflowerBlue
    Protected m_startColorVis As System.Drawing.Color = System.Drawing.Color.White
    Protected m_EndColorVis As System.Drawing.Color = System.Drawing.SystemColors.MenuHighlight


    Protected m_startColorUp As System.Drawing.Color = System.Drawing.SystemColors.MenuHighlight
    Protected m_EndColorUp As System.Drawing.Color = System.Drawing.Color.White
    Protected m_startColorCreat As System.Drawing.Color = Drawing.SystemColors.GradientInactiveCaption
    Protected m_EndColorCreat As System.Drawing.Color = Drawing.SystemColors.GradientInactiveCaption
    Protected m_GradientMode As LinearGradientMode = Drawing.Drawing2D.LinearGradientMode.Vertical
    Private CmdExitPenColor As Pen = New Pen(Color.DarkGray, 2)
    Dim titleBarFrom As System.Drawing.Color
    Dim titleBarTo As System.Drawing.Color
    Dim titleBarColor As System.Drawing.Drawing2D.LinearGradientBrush
    Dim br As SolidBrush


    Public Overrides Sub Nested_PrepareForUpdate()
        Me.Invalidate()
    End Sub

    Public Overridable Sub PrintControl()
        DoPrint()
    End Sub

    Protected Overridable Sub DoPrint()

    End Sub

    Public Overridable Sub UndoControl()
        DoUndo()
    End Sub

    'Protected Overrides Sub DoUndo()

    'End Sub


    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        titleBarFrom = System.Drawing.Color.White
        titleBarTo = System.Drawing.Color.FromArgb(237, 237, 237)
        titleBarColor = New System.Drawing.Drawing2D.LinearGradientBrush(New Rectangle(Me.Location.X, Me.Location.Y, Me.Panel2.Width, Me.Panel2.Height), titleBarFrom, titleBarTo, Drawing.Drawing2D.LinearGradientMode.Vertical)
        Me.BackColor = System.Drawing.Color.FromArgb(245, 245, 245)

        ' Add any initialization after the InitializeComponent() call.

        'SetStyle(Windows.Forms.ControlStyles.ResizeRedraw, True)

    End Sub

    Public Sub SetLabelForCurrentFunction(ByVal value As String)
        Me.lblCurrentFunction.Text = value
    End Sub

    'Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
    '   'MyBase.OnPaint(e)
    '   'SetWindowStyle(e.Graphics, Me.State)
    'End Sub
    Public Overridable Sub SetWindowStyle(ByVal Graphics As System.Drawing.Graphics, ByVal State As AbstractControlState)
        Select Case State.StateName
            Case "Visualizzazione"
                DrawBackground(Graphics, m_startColorVis, m_EndColorVis)
            Case "Creazione"
                DrawBackground(Graphics, m_startColorCreat, m_EndColorCreat)
            Case "Aggiornamento"
                DrawBackground(Graphics, m_startColorUp, m_EndColorUp)
        End Select
    End Sub

    Protected Sub DrawBackground(ByVal Graphics As System.Drawing.Graphics, ByVal StartColor As System.Drawing.Color, ByVal EndColor As System.Drawing.Color)
        Try
            '' paint the background.
            'Graphics.FillRectangle(br, Me.ClientRectangle)
            '' orderly destroy the brush.
            'br.Dispose()
        Catch ex As Exception

        End Try
        ' start/end color and gradient mode

    End Sub

    'Private Sub cmdPreviousCommand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPreviousCommand.Click
    '   MasterControl.Instance.GoPrevious()
    'End Sub

    'Private Sub BrowserControl_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '   Me.cmdPreviousComm.Location = New Drawing.Point(Me.Location.X + Me.Width - Me.cmdPreviousCommand.Width - 9, Me.Location.Y)
    'End Sub

    'Private Sub BrowserControl_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
    '   Me.cmdPreviousCommand.Location = New Drawing.Point(Me.Location.X + Me.Width - Me.cmdPreviousCommand.Width - 9, Me.Location.Y)
    'End Sub

    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        MasterControl.Instance.GoPrevious()
    End Sub


    Private Sub Panel2_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint
        'Dim g As System.Drawing.Graphics = e.Graphics

        'Panel2.Height = 26
        'Dim TitleBarPath As System.Drawing.Drawing2D.GraphicsPath = New System.Drawing.Drawing2D.GraphicsPath

        'Dim TopLeftStart As Point = New Point(Me.Panel2.Location.X, Me.Panel2.Location.Y)
        'Dim TopLeftEnd As Point = New Point(Me.Panel2.Location.X, Me.Panel2.Location.Y + Me.Panel2.Height / 2)
        'Dim ArcRectangle As RectangleF = New RectangleF(Me.Panel2.Location.X, Me.Panel2.Location.Y, Me.Panel2.Height, Me.Panel2.Height - 1)
        'Dim BottomLineStart As Point = New Point(Me.Panel2.Location.X + Me.Panel2.Height, Me.Panel2.Location.Y + Me.Panel2.Height - 1)
        'Dim BottomLineEnd As Point = New Point(Me.Panel2.Location.X + Me.Panel2.Width, Me.Panel2.Location.Y + Me.Panel2.Height - 1)
        'Dim TopRightStart As Point = New Point(Me.Panel2.Location.X + Me.Panel2.Width, Me.Panel2.Location.Y + Me.Panel2.Height)
        'Dim TopRightEnd As Point = New Point(Me.Panel2.Location.X + Me.Panel2.Width, Me.Panel2.Location.Y)

        'TitleBarPath.AddLine(TopLeftStart, TopLeftEnd)
        'TitleBarPath.AddArc(ArcRectangle, 180.0F, -90.0F)
        'TitleBarPath.AddLine(BottomLineStart, BottomLineEnd)
        'TitleBarPath.AddLine(TopRightStart, TopRightEnd)
        'TitleBarPath.CloseFigure()

        'g.SmoothingMode = SmoothingMode.HighQuality

        Dim titleBarFrom As System.Drawing.Color = System.Drawing.Color.White
        Dim titleBarTo As System.Drawing.Color = System.Drawing.Color.FromArgb(237, 237, 237)
        Dim titleBarColor As New System.Drawing.Drawing2D.LinearGradientBrush(New Rectangle(Me.Location.X, Me.Location.Y, Me.Panel2.Width, Me.Panel2.Height), titleBarFrom, titleBarTo, Drawing.Drawing2D.LinearGradientMode.Vertical)

        'g.FillPath(titleBarColor, TitleBarPath)

        'TitleBarPath.Dispose()
        'g.Dispose()

        Dim g As System.Drawing.Graphics = e.Graphics
        g.FillRectangle(titleBarColor, Panel2.ClientRectangle)
        g.DrawLine(Pens.DarkGray, 0, 0, 1, Me.Height)
    End Sub
    Public Sub SelectToolStripImage()
        Select Case MyBase.State.StateName
            Case "Creazione"
                MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.AlertPaint
            Case "Aggiornamento"
                MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.InformationPaint
            Case "Visualizzazione"
                MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.ZoomHS
        End Select
    End Sub



    Public Overrides Sub StartSaveOperation()

        MyBase.StartSaveOperation()
        Me.Invalidate()


    End Sub

    Public Overrides Sub StartCreateOperation()

        MyBase.StartCreateOperation()
        Me.Invalidate()


    End Sub
    Public Overrides Sub StartUndoOperation()

        MyBase.StartUndoOperation()
        Me.Invalidate()


    End Sub



    Private Sub BrowserControl_Scroll(ByVal sender As Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles Me.Scroll
        Me.Invalidate()
    End Sub

    Private Sub lblCurrentFunction_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles lblCurrentFunction.Paint
        lblCurrentFunction.ForeColor = System.Drawing.Color.FromArgb(51, 51, 51)
        lblCurrentFunction.Font = New Font("Tahoma", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CType(0, Byte))
        Dim testo As String = lblCurrentFunction.Text
        'testo = StrConv(testo,VbStrConv.None )
        lblCurrentFunction.Text = testo
    End Sub

    Private Sub CmdExit_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles CmdExit.Paint
        Dim g As System.Drawing.Graphics = e.Graphics
        g.SmoothingMode = SmoothingMode.HighQuality
        g.DrawLine(CmdExitPenColor, 0, 0, CmdExit.Width - 1, CmdExit.Height - 1)
        g.DrawLine(CmdExitPenColor, 0, CmdExit.Height - 1, CmdExit.Width - 1, 0)
    End Sub

    Private Sub CmdExit_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.MouseHover
        CmdExitPenColor = New Pen(System.Drawing.Color.FromArgb(228, 146, 17), 2)
        CmdExit.Invalidate()
    End Sub

    Private Sub CmdExit_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.MouseLeave
        CmdExitPenColor = New Pen(Color.DarkGray, 2)
        CmdExit.Invalidate()
    End Sub

    Private Sub CmdExit_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.MouseEnter
        CmdExitPenColor = New Pen(System.Drawing.Color.FromArgb(228, 146, 17), 2)
        CmdExit.Invalidate()
    End Sub

    Private Sub CmdExit_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CmdExit.MouseDown
        CmdExitPenColor = New Pen(Color.Black, 2)
        CmdExit.Invalidate()

    End Sub

    Private Sub CmdExit_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles CmdExit.MouseMove
        'If CmdExit.ClientRectangle.Contains(e.X, e.Y) Then
        '    CmdExitPenColor = New Pen(System.Drawing.Color.FromArgb(228, 146, 17), 2)
        'Else
        '    CmdExitPenColor = New Pen(Color.DarkGray, 2)
        'End If

        'CmdExit.Invalidate()
    End Sub

    Private Sub DockPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles DockPanel.Paint
        ChangeDockPanelColor(e.Graphics)
        e.Graphics.DrawLine(Pens.DarkGray, 0, 0, 0, Me.Height)
    End Sub

    Private Sub SetDockPanelColor(ByVal Graphics As System.Drawing.Graphics, ByVal titleBarTo As System.Drawing.Color)
        Dim g As System.Drawing.Graphics = Graphics
        Dim DockPanel As Rectangle = New Rectangle(0, 0, Me.DockPanel.Width, Me.DockPanel.Height)

        Dim titleBarFrom As System.Drawing.Color = System.Drawing.Color.White
        Dim titleBarColor As New System.Drawing.Drawing2D.LinearGradientBrush(DockPanel, titleBarFrom, titleBarTo, Drawing.Drawing2D.LinearGradientMode.Vertical)

        g.FillRectangle(titleBarColor, DockPanel)
        'g.DrawLine(New Pen(System.Drawing.Color.FromArgb(133, 135, 140)), 0, Me.Height - 1, Me.Width, Me.Height - 1)
    End Sub

    Private Sub ChangeDockPanelColor(ByVal Graphics As System.Drawing.Graphics)
        Select Case State.StateName
            Case "Visualizzazione"
                SetDockPanelColor(Graphics, System.Drawing.Color.FromArgb(237, 237, 237))
            Case "Creazione"
                SetDockPanelColor(Graphics, System.Drawing.Color.FromArgb(209, 47, 47))
            Case "Aggiornamento"
                SetDockPanelColor(Graphics, System.Drawing.Color.FromArgb(209, 47, 47))
        End Select
    End Sub


    Private Sub BrowserControl_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        e.Graphics.DrawLine(Pens.DarkGray, 0, 0, 0, Me.Height)
    End Sub
End Class
