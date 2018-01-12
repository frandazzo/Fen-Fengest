Imports DevExpress.XtraPrinting

Public Class FrmIscrittoNonIscitto


    Public Sub New(lista As IList)
        InitializeComponent()

        GridControl1.DataSource = lista
    End Sub




    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            Dim link As PrintableComponentLink = New PrintableComponentLink(New PrintingSystem())
            link.Component = GridControl1
            link.PaperKind = System.Drawing.Printing.PaperKind.A4
            link.ShowPreview()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
End Class