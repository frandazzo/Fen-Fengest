Public Class FrmGeneraDeleghe


    Public Ente As String
    Public Period As DataRange

    Public Sub New()

        ' Chiamata richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        cboTipo.SelectedIndex = 0
    End Sub





    Private Sub cmdAnnulla_Click(sender As System.Object, e As System.EventArgs) Handles cmdAnnulla.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub cmdOk_Click(sender As System.Object, e As System.EventArgs) Handles cmdOk.Click
        ControlSelPeriodiMensili1.CalcolaDate()

        Ente = cboTipo.Text
        Period = New DataRange(ControlSelPeriodiMensili1.MinDate, ControlSelPeriodiMensili1.MaxDate)

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class