Public Class FrmUserMessages
    Public Sub New(lista As IList)

        ' Chiamata richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        GridPosizioni.DataSource = lista
    End Sub
End Class