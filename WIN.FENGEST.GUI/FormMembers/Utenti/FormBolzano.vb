Public Class FormBolzano

    Public Sub New(list As IList)
        InitializeComponent()
        GridControl1.DataSource = list
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If FolderBrowserDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim savePath As String = FolderBrowserDialog1.SelectedPath + "\exportUIL.xlsx"
            GridControl1.ExportToXlsx(savePath)

            Process.Start(savePath)
        End If
               
    End Sub
End Class