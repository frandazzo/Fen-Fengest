Imports System.Drawing
Imports System.Windows.Forms

Public Class SpecialButton
   Private MouseOn As Boolean = False
   Private m_radius As Single
   Private m_Disabled As Boolean = False
   Private m_BackImage As Image = My.Resources.HomeHS
   Public Event DoClik(ByVal Sender As Object, ByVal e As System.EventArgs)
   Public Event DoShowToolTip(ByVal Show As Boolean, ByVal Text As Boolean)
   Private m_DrawAsCircle As Boolean = False
   Private m_ApplyOutlookStile As Boolean = False
   Private m_NoActionImage As Image = My.Resources.Interdit
   Private m_ShowToolTip As Boolean = False
   Private m_ToolTipText As String = ""
   Private m_ImageLayout As ImageLayout = ImageLayout.Center



   Property ImageLayout() As ImageLayout
      Get
         Return m_ImageLayout
      End Get
      Set(ByVal value As ImageLayout)
         m_ImageLayout = value
      End Set
   End Property

   Public Sub New()

      ' Chiamata richiesta da Progettazione Windows Form.
      InitializeComponent()

      ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
      'Me.Button1.FlatStyle = Windows.Forms.FlatStyle.Flat
      Me.Button1.BackgroundImage = Nothing
      Me.Button1.BackgroundImageLayout = m_ImageLayout
      Radius = 200
   End Sub
   Public Property Radius() As Single
      Get
         Return m_radius
      End Get
      Set(ByVal value As Single)
         m_radius = value
         Me.Button1.Height = m_radius
         Me.Button1.Width = m_radius
         Me.Width = m_radius
         Me.Height = m_radius
      End Set
   End Property

   Public Property TextValue() As String
      Get
         Return Me.Button1.Text
      End Get
      Set(ByVal value As String)
         Me.Button1.Text = value
      End Set
   End Property
   Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
      MyBase.OnPaint(e)

      If Me.m_DrawAsCircle Then
         Dim shape As New System.Drawing.Drawing2D.GraphicsPath
         shape.AddEllipse(0, 0, Me.Radius - 2, Me.Radius - 2)
         Me.Region = New System.Drawing.Region(shape)
      End If



   End Sub
   Protected Overrides Sub OnPaintBackground(ByVal e As System.Windows.Forms.PaintEventArgs)
      MyBase.OnPaintBackground(e)
      If Me.m_ApplyOutlookStile Then
         Dim g As Graphics = e.Graphics
         Me.Button1.BackgroundImage = Nothing

         Dim bounds As Rectangle = Me.ClientRectangle
         Dim gradientBegin As Color = Color.FromArgb(0, 203, 225, 252)
         Dim gradientEnd As Color = Color.FromArgb(0, 125, 165, 224)

         If Not m_Disabled Then
            If Me.MouseOn And Me.Button1.ContainsFocus Then
               Me.BorderStyle = Windows.Forms.BorderStyle.None
               'gradientBegin = Color.FromArgb(150, 254, 128, 62)
               'gradientEnd = Color.FromArgb(150, 255, 223, 154)
            ElseIf Me.MouseOn Then
               Me.BorderStyle = Windows.Forms.BorderStyle.None
               'gradientBegin = Color.FromArgb(255, 255, 222)
               'gradientEnd = Color.FromArgb(255, 203, 136)
               ''ElseIf Me.Button1.ContainsFocus Then
               ''   gradientBegin = Color.FromArgb(255, 255, 222)
               ''   gradientEnd = Color.FromArgb(255, 203, 136)
            Else
               Me.BorderStyle = Windows.Forms.BorderStyle.None
               gradientBegin = Color.FromArgb(0, 203, 225, 252)
               gradientEnd = Color.FromArgb(0, 125, 165, 224)
            End If
         End If

         Dim b As New Drawing2D.LinearGradientBrush(bounds, gradientBegin, gradientEnd, Drawing2D.LinearGradientMode.Vertical)
         Try
            g.FillRectangle(b, bounds)
            If Not Me.m_BackImage Is Nothing Then
               'g.DrawImage(Me.m_BackImage, New System.Drawing.Rectangle(Me.Width / 2 - 12, Me.Height / 2 - 10, Me.Width / 2 + 2, Me.Height / 2 + 2))
               g.DrawImage(Me.m_BackImage, New System.Drawing.Rectangle(New Point(0, 0), New Size(New Point(Me.Width, Me.Height))))
               If Me.m_Disabled Then
                  'g.DrawImage(Me.m_NoActionImage, New System.Drawing.Rectangle(Me.Width / 2 + 2, Me.Height / 2 + 1, Me.Width / 2 - 9, Me.Height / 2 - 9))
                  g.DrawImage(Me.m_NoActionImage, New System.Drawing.Rectangle(Me.Width - Me.m_NoActionImage.Width, Me.Height - Me.m_NoActionImage.Height, Me.m_NoActionImage.Width, Me.m_NoActionImage.Height))
                  'Me.Enabled = False
               End If
            End If
         Finally
            b.Dispose()
         End Try
      Else
         'Me.Button1.BackgroundImage = Me.m_BackImage
         Me.Button1.BackgroundImageLayout = m_ImageLayout
      End If
   End Sub
   Private Sub CircleButton_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
      If Me.m_DrawAsCircle Then
         Radius = Math.Max(Me.Width, Me.Height)
      Else
         Button1.Size = Me.Size
      End If
      ''
   End Sub

   Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
      If Not m_Disabled Then
         RaiseEvent DoClik(sender, e)
      End If
   End Sub

   Private Sub Button1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.DoubleClick

   End Sub

   Private Sub Button1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter
      MouseOn = True
      Me.Invalidate()
      DrawToolTip(m_ShowToolTip, m_ToolTipText)
      'Debug.WriteLine("Mouse_Enter")
   End Sub

   'Private Sub Button1_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseHover
   '   DrawToolTip(m_ShowToolTip, m_ToolTipText)

   'End Sub
   Private Sub DrawToolTip(ByVal Show As Boolean, ByVal Text As String)
      If Show Then
         ToolTip1.AutomaticDelay = 200
         ToolTip1.Show(Text, ToolTipLabel)
         'toolTipLabel.Visible = True
      End If
   End Sub

   Public Property TooltipText() As String
      Get
         Return m_ToolTipText
      End Get
      Set(ByVal value As String)
         m_ToolTipText = value
      End Set
   End Property
   Public Property ShowTooltip() As Boolean
      Get
         Return m_ShowToolTip
      End Get
      Set(ByVal value As Boolean)
         m_ShowToolTip = value
      End Set
   End Property
   Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
      MouseOn = False
      Me.Invalidate()
      ToolTip1.RemoveAll()
      'Debug.WriteLine("Mouse_Leave")
      'ToolTipLabel.Visible = False
   End Sub
   Public Property Disabled() As Boolean
      Get
         Return m_Disabled
      End Get
      Set(ByVal value As Boolean)
         m_Disabled = value
         Me.Invalidate()
      End Set
   End Property
   Public Overrides Property BackgroundImage() As System.Drawing.Image
      Get
         Return Nothing
      End Get
      Set(ByVal value As System.Drawing.Image)
         'Me.m_BackImage = value
         'Me.Invalidate()
         'Me.Button1.BackgroundImage = value
      End Set
   End Property

   Public Property BackImage() As System.Drawing.Image
      Get
         Return Me.m_BackImage
      End Get
      Set(ByVal value As System.Drawing.Image)
         Me.m_BackImage = value
         Me.Invalidate()
      End Set
   End Property

   Public ReadOnly Property BackImageSize() As System.Drawing.Size
      Get
         Return m_BackImage.Size
      End Get
   End Property




   Public Property FlatStyle() As System.Windows.Forms.FlatStyle
      Get
         Return Me.Button1.FlatStyle
      End Get
      Set(ByVal value As System.Windows.Forms.FlatStyle)
         Me.Button1.FlatStyle = value
         Me.Invalidate()
      End Set
   End Property
   Public ReadOnly Property FlatAppearence() As System.Windows.Forms.FlatButtonAppearance
      Get
         Return Me.Button1.FlatAppearance
      End Get
   End Property
   Public Property ApplyOutLookStile() As Boolean
      Get
         Return Me.m_ApplyOutlookStile
      End Get
      Set(ByVal value As Boolean)
         m_ApplyOutlookStile = value
         Me.Invalidate()
      End Set
   End Property



   Private Sub ToolTip1_Draw(ByVal sender As Object, ByVal e As System.Windows.Forms.DrawToolTipEventArgs) Handles ToolTip1.Draw
      e.DrawBackground()

      '' Draw the custom border to appear 3-dimensional.
      'e.Graphics.DrawLines( _
      '    SystemPens.ControlLightLight, New Point() { _
      '    New Point(10, e.Bounds.Height + 9), _
      '    New Point(100, 100), _
      '    New Point(e.Bounds.Width - 1, 0)})
      'e.Graphics.DrawLines( _
      '    SystemPens.ControlDarkDark, New Point() { _
      '    New Point(10, e.Bounds.Height + 9), _
      '    New Point(e.Bounds.Width + 100, e.Bounds.Height + 100), _
      '    New Point(e.Bounds.Width - 1, 0)})

   End Sub


End Class
