Imports System.Windows.Forms

Public Class FrmConfrontoListeWizard

    Private WithEvents m_gestore As GestoreConfrontoListe
    Private m_confronto As ConfrontoListeUtenti


    Public Sub New()

        ' Chiamata richiesta da Progettazione Windows Form.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

        m_gestore = New GestoreConfrontoListe
    End Sub





    Private Sub Wizard1_CloseFromCancel(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Wizard1.CloseFromCancel
        If MessageBox.Show(Me, "Sicuro di voler annullare la procedura guidata?", "Procedura annullata", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If

    End Sub

    Private Sub DescriptionPage_CloseFromNext(ByVal sender As System.Object, ByVal e As Wizard.PageEventArgs) Handles DescriptionPage.CloseFromNext
        If txtDescr1.Text.Length = 0 Then
            MessageBox.Show("Inserire un valore corretto per la descrizione della lista iniziale", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)

            e.Page = DescriptionPage
            Return
        End If


        If txtDescr2.Text.Length = 0 Then
            MessageBox.Show("Inserire un valore corretto per la descrizione della lista di confronto", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)

            e.Page = DescriptionPage

            Return
        End If


        m_gestore.SetDescrizioneLista1(txtDescr1.Text)
        m_gestore.SetDescrizioneLista2(txtDescr2.Text)

    End Sub

    Private Sub Definition1Page_ShowFromNext(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Definition1Page.ShowFromNext

        InitializeLista1()

    End Sub

    Private Sub InitializeLista1()

        ControlSelezioneComponentiLista1.SetGestore(m_gestore)

        ControlSelezioneComponentiLista1.SetIsLista1(True)

        ControlSelezioneComponentiLista1.LoadData()

    End Sub


    Private Sub InitializeLista2()

        ControlSelezioneComponentiLista2.SetGestore(m_gestore)

        ControlSelezioneComponentiLista2.SetIsLista1(False)

        ControlSelezioneComponentiLista2.LoadData()

    End Sub


    Private Sub Definition1Page_ShowFromBack(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Definition1Page.ShowFromBack
        InitializeLista1()
    End Sub

    Private Sub Definition2Page_ShowFromNext(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Definition2Page.ShowFromNext
        InitializeLista2()
    End Sub

    Private Sub Definition2Page_ShowFromBack(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Definition2Page.ShowFromBack
        InitializeLista2()
    End Sub

    Private Sub Definition1Page_CloseFromNext(ByVal sender As System.Object, ByVal e As Wizard.PageEventArgs) Handles Definition1Page.CloseFromNext
        'Valido l'inserimento di almeno un compoente


        If ControlSelezioneComponentiLista1.lstComponenti.Items.Count = 0 Then

            MessageBox.Show("Inserire almeno un componente!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)

            e.Page = Definition1Page
        End If
    End Sub

    Private Sub Definition2Page_CloseFromNext(ByVal sender As System.Object, ByVal e As Wizard.PageEventArgs) Handles Definition2Page.CloseFromNext
        'Valido l'inserimento di almeno un compoente


        If ControlSelezioneComponentiLista2.lstComponenti.Items.Count = 0 Then

            MessageBox.Show("Inserire almeno un componente!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)

            e.Page = Definition2Page
        End If
    End Sub

    Private Sub SummarizePage_ShowFromNext(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SummarizePage.ShowFromNext
        Dim s As String = "Riepilogo elementi:" & Environment.NewLine
        s += m_gestore.DescrizioneCompletaLista1

        s += Environment.NewLine

        s += m_gestore.DescrizioneCompletaLista2

        txtSummarize.Text = s

    End Sub

    Private Sub ProgressPage_ShowFromNext(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressPage.ShowFromNext
        Try
            m_confronto = m_gestore.CreaConfronto()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub





    Private Sub m_gestore_BeginExecuteCompare() Handles m_gestore.BeginExecuteCompare
        'Evento iniziale
        lblActivity.Text = "Iniziata attività di confronto"
        ProgressBar1.Value = 5
        System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub m_gestore_CreateCommons() Handles m_gestore.CreateCommons
        lblActivity.Text = "Elaborazione elementi elementi comuni"
        ProgressBar1.Value = 95
        System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub m_gestore_CreateDiffLista1() Handles m_gestore.CreateDiffLista1
        lblActivity.Text = "Elaborazione elementi specifici lista iniziale"
        ProgressBar1.Value = 55
        System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub m_gestore_CreateDiffLista2() Handles m_gestore.CreateDiffLista2
        lblActivity.Text = "Elaborazione elementi specifici lista di confronto"
        ProgressBar1.Value = 75
        System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub m_gestore_EndExecuteCompare() Handles m_gestore.EndExecuteCompare
        lblActivity.Text = "ConfrontoGiornaliero eseguito"
        ProgressBar1.Value = 100
        Wizard1.Next()

    End Sub

    Private Sub m_gestore_MergeLista1() Handles m_gestore.MergeLista1

        lblActivity.Text = "Creazione lista iniziale"
        ProgressBar1.Value = 20
        System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub m_gestore_MergeLista2() Handles m_gestore.MergeLista2
        lblActivity.Text = "Creazione lista di confronto"
        ProgressBar1.Value = 35
        System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub EndPage_CloseFromNext(ByVal sender As System.Object, ByVal e As Wizard.PageEventArgs) Handles EndPage.CloseFromNext
        Try
            Dim frm As New FrmConfrontoListeLavoro(m_confronto)
            frm.TopLevel = True
            frm.Show()

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
End Class