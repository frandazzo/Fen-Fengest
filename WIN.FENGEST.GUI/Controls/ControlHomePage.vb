Public Class ControlHomePage
   Private m_Sito As String = ""
   'Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
   '   MyBase.OnPaint(e)

   'End Sub
   'Public Overrides Sub SetWindowStyle(ByVal Graphics As System.Drawing.Graphics, ByVal State As UTILITY.AbstractControlState)
   '   Dim graphPath As New System.Drawing.Drawing2D.GraphicsPath
   '   'Dim col As System.Drawing.Color
   '   Dim b As New System.Drawing.Bitmap(My.Resources.home)

   '   Dim rect As New Rectangle
   '   Dim logo = My.Resources.home
   '   rect = New Rectangle(0, 0, logo.Width, logo.Height)

   '   Graphics.Clear(Color.White)
   '   Graphics.DrawImage(b, rect)

   'End Sub



   Private Sub ControlHomePage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

      Me.Panel2.Visible = False
      Me.DockPanel.Visible = False
      ' Me.Timer1.Enabled = True

      MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "FenealGest home page"
      MasterControl.Instance.GetMdi.Text = "FenealGest home page"
      MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.HomeHS

      WebBrowser1.Url = New Uri(GetHomePagePath)

      'WebBrowser1.Size = Me.Size
   End Sub
   Private Function GetHomePagePath() As String
      Dim path As String
        Dim asm As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()
        Dim resolutionWidth As Integer = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width
        path = asm.CodeBase()
        path = path.Replace("file:///", "")
        Dim j As System.IO.FileInfo = New System.IO.FileInfo(path)
        path = j.DirectoryName()
        path = path + "\Fenealgest\default.htm"
        Return path
    End Function



 

  

 



 








 
End Class
