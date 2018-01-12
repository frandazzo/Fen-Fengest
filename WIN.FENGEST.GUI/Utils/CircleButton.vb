Imports System.Drawing
Public Class CircleButton
   Private MouseOn As Boolean = False
   Private m_radius As Single
   Public Sub New()

      ' Chiamata richiesta da Progettazione Windows Form.
      InitializeComponent()

      ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
      'Me.Button1.FlatStyle = Windows.Forms.FlatStyle.Flat
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


      Dim shape As New System.Drawing.Drawing2D.GraphicsPath
      shape.AddEllipse(0, 0, Me.Radius - 2, Me.Radius - 2)
      Me.Region = New System.Drawing.Region(shape)
      



   End Sub
   Protected Overrides Sub OnPaintBackground(ByVal e As System.Windows.Forms.PaintEventArgs)
      MyBase.OnPaintBackground(e)

      Dim g As Graphics = e.Graphics
      Dim bounds As Rectangle = Me.ClientRectangle

      Dim gradientBegin As Color = Color.FromArgb(203, 225, 252)
      Dim gradientEnd As Color = Color.FromArgb(125, 165, 224)



      If Me.MouseOn Then
         gradientBegin = Color.FromArgb(254, 128, 62)
         gradientEnd = Color.FromArgb(255, 223, 154)
      Else
         gradientBegin = Color.FromArgb(255, 255, 222)
         gradientEnd = Color.FromArgb(255, 203, 136)
      End If

      Dim b = New Drawing2D.LinearGradientBrush(bounds, gradientBegin, gradientEnd, Drawing2D.LinearGradientMode.Vertical)
      'Dim b As Drawing.Brush = New Drawing.SolidBrush(gradientBegin)
      Try
         g.FillRectangle(b, bounds)
         g.DrawImage(My.Resources.HomeHS, New System.Drawing.Point(0, 0))
      Finally
         b.Dispose()
      End Try
   End Sub
   Private Sub CircleButton_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
      Radius = Math.Max(Me.Width, Me.Height)
   End Sub

   Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

   End Sub

   Private Sub Button1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.DoubleClick

   End Sub

   Private Sub Button1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter
      MouseOn = True
      Me.Invalidate()
   End Sub

   Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
      MouseOn = False
      Me.Invalidate()
   End Sub
End Class
