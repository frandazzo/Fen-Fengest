Imports WIN.FENGEST_NAZIONALE.INTEGRATION_ENTITIES.FenealgestImportExport

Public Class FrmViewTemplate

    Public Sub New(details As InpsTraceDetails())

        ' Chiamata richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

        GridControl1.DataSource = details


    End Sub

    Private Sub GridControl1_Click(sender As System.Object, e As System.EventArgs) Handles GridControl1.Click

    End Sub

    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click
        GridControl1.ShowPrintPreview()
    End Sub
End Class