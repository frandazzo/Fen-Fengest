Public Class FrmViewRendiconto 

    Private m_rendiconto As Rendiconto

    Public Sub New(rendiconto As Rendiconto)

        ' Chiamata richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        m_rendiconto = rendiconto

        SpinEdit1.Value = rendiconto.Anno
        DateEdit1.DateTime = rendiconto.DataCreazione
        TextEdit1.Text = rendiconto.Tipo.ToString
        MemoEdit1.Text = rendiconto.Descrizione
    End Sub


    Private Sub cmdOk_Click(sender As System.Object, e As System.EventArgs) Handles cmdOk.Click
        Try

            m_rendiconto.Anno = SpinEdit1.Value
            m_rendiconto.DataCreazione = DateEdit1.DateTime
            m_rendiconto.Descrizione = MemoEdit1.Text


            Dim controller As New ControllerRendiconto



            controller.SaveOrUpdateRendiconto(m_rendiconto)

            Me.Close()

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As System.Object, e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
End Class