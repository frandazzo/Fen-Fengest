
Imports System
Imports System.IO
Imports System.Windows.Forms



Public Class FrmComunicazioniMassiveWizard


    Private m_start As Int32 = -1
    Private m_finish As Int32 = -1
    Dim m_printer As String = ""


    Private controller As New WIN.APPLICATION.ControllerComunicazioni
    Private controllerUtenti As New WIN.APPLICATION.UTENTI.ControllerUtenti
    Dim controllerCausali As New ControllerCausaleComunicazione
    Dim controllerTipo As New ControllerTipoComunicazione
    Dim controllerlista As New ControllerListaUtenti
    Dim controllerComunicazione As New ControllerComunicazioni
    Dim wordHandler As OfficeWordHandler
    Dim controllerCompilazione As New ControllerCompilazioneModelli

    Dim cl As New ControllerListaUtenti
    Private frm1 As FrmElaborazioneInCorso


    Dim tag1 As String = ""
    Dim tag2 As String = ""
    Dim tag3 As String = ""


    Public Sub New()

        ' Chiamata richiesta da Progettazione Windows Form.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        PrepareLoading()
    End Sub


    Private Sub PrepareLoading()
        'Dim listaModelli As IList = GetListaModelli()
        InterfaceMediator.LoadCombo(cboCausale, controllerCausali.GetListaCausali, False)
        InterfaceMediator.LoadCombo(cboTipo, controllerTipo.GetListaCausali, False)
        'InterfaceMediator.LoadCombo(cboModello, listaModelli, True)
    End Sub



    Private Sub CreaNuovaComunicazione(ByVal utente As Utente)
        controllerComunicazione.CreateNew()
        controllerComunicazione.Data = DateTime.Now
        controllerComunicazione.Note = "Comunicazione massiva in data " & DateTime.Now.ToLongDateString
        controllerComunicazione.SetUtente(utente.IdUtente)
        controllerComunicazione.SetCausale(cboCausale.Text)
        controllerComunicazione.SetTipo(cboTipo.Text)
    End Sub



    Private Function IsProcessConfirmed() As Boolean
        If MsgBox("Sicuro di avviare il processo di stampa?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Domanda") = MsgBoxResult.Yes Then
            Return True
        Else
            Return False
        End If

    End Function


    Private Function InitializeHashTable(ByVal utente As Utente) As Hashtable
        Dim hash As New Hashtable
        hash.Add("@Tag1@", tag1)
        hash.Add("@Tag2@", tag2)
        hash.Add("@Tag3@", tag3)

        Return controllerCompilazione.CreateTagValuesMap(utente.Id, hash)


    End Function

    Private Sub cmdTag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTag.Click
        If My.Computer.FileSystem.FileExists(lblModello.Text) Then
            Dim frmTags As New FrmTagSupplementari(tag1, tag2, tag3)
            frmTags.ShowDialog()

            tag1 = frmTags.Tag1
            tag2 = frmTags.Tag2
            tag3 = frmTags.Tag3

            frmTags.Dispose()


        Else
            MessageBox.Show("Selezionare un modello corretto!", "Messaggio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub IdListaUtentiTextBox1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IdListaUtentiTextBox1.Leave
        InterfaceMediator.GetSimpleDescription(New WIN.APPLICATION.ControllerListaUtenti, "Descrizione", Me.lblDescrizione, Me.IdListaUtentiTextBox1.TextValue)
    End Sub

    Private Sub cmdModello_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModello.Click
        Try
            Dim frm As New FrmSelezionaModello
            If frm.ShowDialog = DialogResult.OK Then
                lblModello.Text = frm.FileSelezionato
            End If
            frm.Dispose()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub lblModello_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblModello.DoubleClick
        Try
            If My.Computer.FileSystem.FileExists(lblModello.Text) Then
                Process.Start(lblModello.Text)
            End If
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try

    End Sub

    Private Sub chkSaveCom_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSaveCom.CheckedChanged
        If chkSaveCom.Checked Then
            chkSaveFile.Enabled = True
            cboCausale.Enabled = True
            cboTipo.Enabled = True
        Else
            chkSaveFile.Enabled = False
            cboCausale.Enabled = False
            cboTipo.Enabled = False
        End If
    End Sub

    Private Sub Wizard1_CloseFromCancel(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Wizard1.CloseFromCancel
        If MessageBox.Show("Sicuro di voler uscire dalla procedura guidata?", "Domanda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            e.Cancel = False
        End If
    End Sub

    Private Sub chkStart_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkStart.CheckedChanged
        If chkStart.Checked Then
            Dim frm As FrmSelezioneIndiceLista = New FrmSelezioneIndiceLista(controllerlista.Current.ListaUtenti, "Utente")

            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                m_start = frm.SelectedIndex
            End If

            frm.Dispose()
        Else
            m_start = -1
        End If

        SetIndexDescriptors()
    End Sub

    Private Sub chkFinish_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFinish.CheckedChanged
        If chkFinish.Checked Then
            Dim frm As FrmSelezioneIndiceLista = New FrmSelezioneIndiceLista(controllerlista.Current.ListaUtenti, "Utente")

            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                m_finish = frm.SelectedIndex
            End If

            frm.Dispose()
        Else

            m_finish = -1
        End If

        SetIndexDescriptors()
    End Sub

    Private Sub ListPage_CloseFromNext(ByVal sender As System.Object, ByVal e As Wizard.PageEventArgs) Handles ListPage.CloseFromNext
        Try

            'qui verifico che la lista sia esistente
            controllerlista.LoadByIdReloadingCache(IdListaUtentiTextBox1.TextValue)

        Catch ex As Exception

            ErrorHandler.ShowError(ex.Message & Environment.NewLine & "Selezionare una lista")
            e.Page = ListPage
        End Try
    End Sub

    Private Sub SetIndexDescriptors()
        If m_finish <> -1 Then
            lblFinish.Text = "Indice selezionato: " & m_finish.ToString
        Else
            lblFinish.Text = "Nessun indice selezionato"
        End If


        If m_start <> -1 Then
            lblStart.Text = "Indice selezionato: " & m_start.ToString
        Else
            lblStart.Text = "Nessun indice selezionato"
        End If
    End Sub


    Private Sub IndexPage_ShowFromNext(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IndexPage.ShowFromNext
        SetIndexDescriptors()
    End Sub

    Private Sub IndexPage_ShowFromBack(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IndexPage.ShowFromBack
        SetIndexDescriptors()
    End Sub


    Private Sub CorrectIndex()
        If m_start <= 0 Or m_finish <= 0 Then
            Return
        End If


        Dim temp As Int32

        If m_start > m_finish Then
            temp = m_start
            m_start = m_finish
            m_finish = temp
        End If


    End Sub


    Private Sub IndexPage_CloseFromNext(ByVal sender As System.Object, ByVal e As Wizard.PageEventArgs) Handles IndexPage.CloseFromNext
        CorrectIndex()
    End Sub

    Private Sub ModelPage_CloseFromNext(ByVal sender As System.Object, ByVal e As Wizard.PageEventArgs) Handles ModelPage.CloseFromNext
        If Not My.Computer.FileSystem.FileExists(lblModello.Text) Then
            MessageBox.Show("Selezionare un modello", "Messaggio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Page = ModelPage
        End If
    End Sub

    Private Sub EndPage_CloseFromNext(ByVal sender As System.Object, ByVal e As Wizard.PageEventArgs) Handles EndPage.CloseFromNext
        Try
            Wizard1.CancelEnabled = False
            Wizard1.NextEnabled = False
            Wizard1.BackEnabled = False
            Avvia()
            Wizard1.CancelEnabled = True
            Wizard1.NextEnabled = True
            Wizard1.BackEnabled = True



        Catch ex As Exception
            Wizard1.CancelEnabled = True
            Wizard1.NextEnabled = True
            Wizard1.BackEnabled = True


            ErrorHandler.ShowError(ex)

            e.Page = EndPage
        End Try
    End Sub



    Private Sub Avvia()



        'Chiedo conferma per proseguire
        If Not IsProcessConfirmed() Then
            MsgBox("Operazione annullata dall'utente", MsgBoxStyle.Information, "Messaggio")

            Return
        End If



        'preparo l'eventuale lista di lavoro per l'export dei dati
        If chkLabels.Checked Then
            cl.CreateNew()
        End If

        'Avvio il processo
        ' Helper.ShowWaitBox("Processo di stampa massiva in corso...", My.Resources.Waiting3)
        StartProcess(lblModello.Text)
        ' Helper.HideWaitBox()

        If chkLabels.Checked Then
            Dim frm As New FrmExportLista(cl.Current)
            frm.ShowDialog()
        End If


        'Notifico la fine del processo
        MsgBox("Operazioni eseguite correttamente!", MsgBoxStyle.Information, "Messaggio")




    End Sub


    Private Sub StartProcess(ByVal filename As String)

        If controllerlista.GetListaUtenti.Count = 0 Then
            MessageBox.Show("Lista vuota", "Messaggio", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        frm1 = New FrmElaborazioneInCorso

        frm1.EnableCancel(True)

        frm1.TopLevel = True


        frm1.Show()

        System.Windows.Forms.Application.DoEvents()


        Dim i As Int32 = 1
        Dim perc As Int32 = 0
        Dim temp As Int32
        Dim total As Int32 = CalculateTotalElementToPrint()

        'imposto il valore max per la variabile 
        'temp che mi serve a non sporcare m_finish
        If m_finish <= 0 Then
            temp = 9999999
        Else
            temp = m_finish
        End If

        For Each elem As Utente In controllerlista.GetListaUtenti
            'prendo i valori nel range
            If i >= m_start And i <= temp Then
                If chkLabels.Checked Then
                    cl.Current.AddUtente(elem)
                End If

                'Creo una comunicazione
                CreaNuovaComunicazione(elem)
                'Genero il documento e lo stampo

                Dim allegato As String

                If chkSaveFile.Checked And chkSaveFile.Enabled Then
                    allegato = controllerComunicazione.GenerateDocumentAndPrintOnBackground(filename, InitializeHashTable(elem), True)
                Else
                    allegato = controllerComunicazione.GenerateDocumentAndPrintOnBackground(filename, InitializeHashTable(elem), False)
                End If

                controllerComunicazione.Allegato = allegato

                If chkSaveCom.Checked Then
                    'Salvo la comunicazione
                    controllerComunicazione.Save()
                End If


                'verifico la percentuale di svolgimento
                perc = CInt((100 / total) * i)

                'la notifico al form
                frm1.SetPercentageValue(perc)
                frm1.SetActivity(i.ToString & " elementi stampati di " & controllerlista.GetListaUtenti.Count & "! (" & perc.ToString & "% completato" & ")")
                System.Windows.Forms.Application.DoEvents()


                If frm1.Annulla Then
                    If MessageBox.Show("Sicuro di annullare il processo di stampa?", "Domanda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                        MessageBox.Show("Operazione annullata dall'utente", "Messaggio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        frm1.Dispose()
                        Return
                    Else
                        frm1.Annulla = False
                    End If


                End If

                'incremento il contatore

            End If
            i = i + 1

        Next

        frm1.Dispose()

    End Sub

    Private Function CalculateTotalElementToPrint() As Int32
        Dim total As Int32

        If m_start <= 0 And m_finish <= 0 Then
            total = controllerlista.GetListaUtenti.Count
        ElseIf m_start <= 0 Then
            total = m_finish
        ElseIf m_finish <= 0 Then
            total = controllerlista.GetListaUtenti.Count - m_start
        Else
            total = m_finish - m_start
        End If

        If total = 0 Then
            total = 1
        End If

        Return total
    End Function

    Private Sub cmdPrinter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrinter.Click
        Try
            Dim frm As New FrmSelectPrinter
            If frm.ShowDialog() = DialogResult.OK Then
                m_printer = frm.PrinterName
                lblPrint.Text = m_printer
            End If
            frm.Dispose()

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
 

    End Sub

    Private Sub PrinterPage_CloseFromNext(ByVal sender As System.Object, ByVal e As Wizard.PageEventArgs) Handles PrinterPage.CloseFromNext
        If m_printer = "" Then
            MessageBox.Show("Selezionare una stampante!", "Messaggio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Page = PrinterPage
        End If
    End Sub

End Class