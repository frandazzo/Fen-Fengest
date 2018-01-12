Imports DevExpress.XtraPrinting

Public Class FrmReportZone

    Public Sub New(ListaLavoroUtenti As IList)
        InitializeComponent()

        GridControl1.DataSource = ListaLavoroUtenti
    End Sub


    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim link As PrintableComponentLink = New PrintableComponentLink(New PrintingSystem())
        link.Component = GridControl1
        link.PaperKind = System.Drawing.Printing.PaperKind.A4
        link.ShowPreview()
    End Sub
End Class