Public Class FrmTagSupplementari
   Public Tag1 As String
   Public Tag2 As String
   Public Tag3 As String
   Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
      Tag1 = Me.txtTag1.Text
      Tag2 = Me.txtTag2.Text
      Tag3 = Me.txtTag3.Text
      Me.Close()
   End Sub


   Public Sub New(ByVal tagValue1 As String, ByVal tagValue2 As String, ByVal tagValue3 As String)
      InitializeComponent()
      Tag1 = tagValue1
      Tag2 = tagValue2
      Tag3 = tagValue3
   End Sub
   Private Sub cmdAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnnulla.Click
      Me.Close()
   End Sub

   Private Sub FrmTagSupplementari_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
      Me.txtTag1.Text = Tag1
      Me.txtTag2.Text = Tag2
      Me.txtTag3.Text = Tag3
   End Sub
End Class