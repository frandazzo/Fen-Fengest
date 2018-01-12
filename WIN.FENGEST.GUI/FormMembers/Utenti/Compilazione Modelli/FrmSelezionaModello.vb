Public Class FrmSelezionaModello
   Public FileSelezionato As String = ""


   Private Sub cmdAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnnulla.Click
      Me.DialogResult = Windows.Forms.DialogResult.Cancel
      Me.Close()
   End Sub

   Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
      If Not IO.File.Exists(FileSelezionato) Then
         FileSelezionato = ""
      End If
      Me.DialogResult = Windows.Forms.DialogResult.OK
      Me.Close()
   End Sub

    Private Sub FrmSelezionaModello_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim con As New ControllerSegreteria
        con.LoadById("1")

        FileExplorerTreeView1.BasePath = con.CartellaModelli
        FileExplorerTreeView1.Filter = ".Dot|.Dotx"
        FileExplorerTreeView1.ViewMode = FileDirectoryProvider.Control.FileExplorerTreeViewOption.FileAndDirectiory
        FileExplorerTreeView1.Create()
    End Sub

   Private Sub FileExplorerTreeView1_NodeMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles FileExplorerTreeView1.NodeMouseClick
      FileSelezionato = e.Node.FullPath

   End Sub
End Class