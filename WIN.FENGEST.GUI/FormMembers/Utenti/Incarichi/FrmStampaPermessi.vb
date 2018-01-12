Public Class FrmStampaPermessi


    Private m_start As Int32 = -1
    Private m_finish As Int32 = -1
    Dim m_printer As String = ""
    Private m_Incarichi As IList

    '   Private controller As New WIN.APPLICATION.ControllerComunicazioni
    '  Private controllerUtenti As New WIN.APPLICATION.UTENTI.ControllerUtenti
    ' Dim controllerCausali As New ControllerCausaleComunicazione
    Dim controllerTipo As New ControllerTipoDocumentazione
    'Dim controllerlista As New ControllerListaUtenti
    Dim controllerArchivio As ControllerArchivioDocumentale
    Dim wordHandler As OfficeWordHandler
    Dim controllerCompilazione As New ControllerCompilazioneModelli

    Dim cl As New ControllerListaUtenti
    Private frm1 As FrmElaborazioneInCorso


    Dim tag1 As String = ""
    Dim tag2 As String = ""
    Dim tag3 As String = ""


    Private Function InitializeHashTable(ByVal utenteId As Int32, aziendaId As Int32) As Hashtable

        Dim hash As New Hashtable
        hash.Add("@Tag1@", tag1)
        hash.Add("@Tag2@", tag2)
        hash.Add("@Tag3@", tag3)

        Return controllerCompilazione.CreateTagValuesMap(utenteId, aziendaId, hash)


    End Function

    Private Function IsProcessConfirmed() As Boolean
        If MsgBox("Sicuro di avviare il processo di stampa?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Domanda") = MsgBoxResult.Yes Then
            Return True
        Else
            Return False
        End If

    End Function

    Public Sub New(listaIncarichi As IList)
        If listaIncarichi Is Nothing Then
            Throw New ArgumentException("Lista incarichi non impostata")
        End If

        If listaIncarichi.Count = 0 Then
            Throw New ArgumentException("Lista incarichi vuota")
        End If

        InitializeComponent()
        m_Incarichi = listaIncarichi
        PrepareLoading()
    End Sub

    Private Sub PrepareLoading()
        
        InterfaceMediator.LoadCombo(cboTipo, controllerTipo.GetListaCausali, False)

    End Sub




    Private Sub rdbAz_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles rdbAz.CheckedChanged
        If rdbAz.Checked Then
            chkSaveCom.Text = "Salva come documento nell'archivio documentale dell'azienda"
            chkLabels.Text = "Crea etichette per l'azienda al termine dell'elaborazione"
        Else
            chkSaveCom.Text = "Salva come documento nell'archivio documentale dell'utente"
            chkLabels.Text = "Crea etichette per l'utente al termine dell'elaborazione"
        End If
    End Sub

    Private Sub cmdPrinter_Click(sender As System.Object, e As System.EventArgs) Handles cmdPrinter.Click
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

    Private Sub cmdModello_Click(sender As System.Object, e As System.EventArgs) Handles cmdModello.Click
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

    Private Sub cmdTag_Click(sender As System.Object, e As System.EventArgs) Handles cmdTag.Click
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

    Private Sub lblModello_DoubleClick(sender As System.Object, e As System.EventArgs) Handles lblModello.DoubleClick
        Try
            If My.Computer.FileSystem.FileExists(lblModello.Text) Then
                Process.Start(lblModello.Text)
            End If
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

   
    Private Sub ModelPage_CloseFromNext(sender As Object, e As Wizard.PageEventArgs) Handles ModelPage.CloseFromNext
        If Not My.Computer.FileSystem.FileExists(lblModello.Text) Then
            MessageBox.Show("Selezionare un modello", "Messaggio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Page = ModelPage
        End If
    End Sub

    Private Sub PrinterPage_CloseFromNext(sender As System.Object, e As Wizard.PageEventArgs) Handles PrinterPage.CloseFromNext
        If m_printer = "" Then
            MessageBox.Show("Selezionare una stampante!", "Messaggio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            e.Page = PrinterPage
        End If
    End Sub

    Private Sub Wizard1_CloseFromCancel(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles Wizard1.CloseFromCancel
        If MessageBox.Show("Sicuro di voler uscire dalla procedura guidata?", "Domanda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            e.Cancel = False
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

            e.Page = EndPage
            ErrorHandler.ShowError(ex)


        End Try
    End Sub


    Private Sub Avvia()

        'Chiedo conferma per proseguire
        If Not IsProcessConfirmed() Then
            MsgBox("Operazione annullata", MsgBoxStyle.Information, "Messaggio")

            Return
        End If
        ''preparo l'eventuale lista di lavoro per l'export dei dati
        If chkLabels.Checked Then
            If Not rdbAz.Checked Then
                cl.CreateNew()
            End If
        End If

        'Avvio il processo
        StartProcess(lblModello.Text)

        'esporto le etichette
        If chkLabels.Checked Then
            If rdbAz.Checked Then
                Dim ll As New List(Of Hashtable)

                For Each elem As IncaricoDTO In m_Incarichi
                    ll.Add(InitializeHashTable(elem.IdUtente, elem.IdAzienda))
                Next

                Dim frm As New FrmEtichietteAziende(ll)
                frm.ShowDialog()
                frm.Dispose()
            Else
                Dim frm As New FrmExportLista(cl.Current)
                frm.ShowDialog()
                frm.Dispose()
            End If

        End If

        'Notifico la fine del processo
        MsgBox("Operazioni eseguite correttamente!", MsgBoxStyle.Information, "Messaggio")
    End Sub


    Private Sub StartProcess(ByVal filename As String)

        frm1 = New FrmElaborazioneInCorso

        frm1.EnableCancel(True)

        frm1.TopLevel = True


        frm1.Show()

        System.Windows.Forms.Application.DoEvents()


        Dim i As Int32 = 1
        Dim perc As Int32 = 0
        Dim total As Int32 = m_Incarichi.Count


        For Each elem As IncaricoDTO In m_Incarichi
          
            Dim target As AbstractPersistenceObject = GetTargetObject(elem)


            'se è un utente ed è ceccato la stampa delle etichette la aggiungo alla lista di lavoro
            If chkLabels.Checked Then
                If Not rdbAz.Checked Then
                    cl.AddUtente(elem.IdUtente)
                End If
            End If




            'genero il documento dopo avere verificasto dove riporre l'eventuale file da
            'allegare all'archivio documentale
            Dim destination As String = GetDestinationSavedFilePath(target)


            Dim createdFile As String = ""


            Try

                If CheckBox1.Checked Then
                    If String.IsNullOrEmpty(destination) Then
                        createdFile = GenerateWordDocAndPrintOnBackground(destination, filename, InitializeHashTable(elem.IdUtente, elem.IdAzienda), False)
                    Else
                        createdFile = GenerateWordDocAndPrintOnBackground(destination, filename, InitializeHashTable(elem.IdUtente, elem.IdAzienda), chkSaveCom.Checked)
                    End If
                Else
                    If Not String.IsNullOrEmpty(destination) Then
                        createdFile = GenerateWordDoc(destination, filename, InitializeHashTable(elem.IdUtente, elem.IdAzienda))
                    End If
                End If





                If chkSaveCom.Checked Then
                    If Not target Is Nothing Then
                        controllerArchivio = New ControllerArchivioDocumentale(target)

                        Dim documento As ElectronicDocument = ElectronicDocumentFactory.CreateElectronicDocument(target)
                        controllerArchivio.AddElectronicDocument(documento)

                        controllerArchivio.Data = DateTime.Now
                        controllerArchivio.FileName = createdFile
                        controllerArchivio.TipoDocumentazione = controllerTipo.GetCausaleDocumentazione(cboTipo.Text)
                        controllerArchivio.SetReferente(IdReferenteTextBox1.TextValue)
                        controllerArchivio.Note = ""
                        controllerArchivio.Save()
                    End If
                End If
            Catch ex As Exception
                ErrorHandler.ShowError(ex)
            End Try

           

            'verifico la percentuale di svolgimento
            perc = CInt((100 / total) * i)

            'la notifico al form
            frm1.SetPercentageValue(perc)
            frm1.SetActivity(i.ToString & " elementi stampati di " & m_Incarichi.Count & "! (" & perc.ToString & "% completato" & ")")
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


            i = i + 1

        Next
        frm1.Dispose()
    End Sub


    Private Function GetTargetObject(elem As IncaricoDTO) As AbstractPersistenceObject
        Dim id As Int32

        If rdbAz.Checked Then
            id = elem.IdAzienda
        Else
            id = elem.IdUtente
        End If


        If id = -1 Then
            Return Nothing
        End If


        If rdbUt.Checked Then ' si tratta di un utente
            Dim ccUt As New UTENTI.ControllerUtenti
            ccUt.LoadById(id.ToString)
            Return ccUt.Current
        End If

        Dim ccAz As New AZIENDE.ControllerAziende()
        ccAz.LoadById(id.ToString)
        Return ccAz.Current
    End Function


    Private Function GetDestinationSavedFilePath(target As AbstractPersistenceObject) As String

        If target Is Nothing Then
            Return ""
        End If

        If TypeOf (target) Is Utente Then
            Return DirectCast(target, Utente).DirectoryPreferenziale
        Else
            Return DirectCast(target, Azienda).DirectoryPreferenziale
        End If



    End Function

    Private Function GenerateWordDoc(destination As String, ByVal modello As String, ByVal TagTable As Hashtable) As String
        Try

            Dim dest As String = destination 'Current.Utente.DirectoryPreferenziale

            Dim suggestedName As String = SimpleFileSystemManager.GetFileNameWithoutExtension(modello)

            Return OfficeWordDocumentGenerator.GenerateAndSaveDocumentLowLevel(modello, TagTable, dest, suggestedName)

        Catch ex As Exception
            Throw New Exception("Impossibile generare il documento word", ex)
        End Try
    End Function

    Private Function GenerateWordDocAndPrintOnBackground(destination As String, ByVal modello As String, ByVal TagTable As Hashtable, ByVal save As Boolean) As String
        Try

            Dim dest As String = destination 'Current.Utente.DirectoryPreferenziale

            Dim suggestedName As String = SimpleFileSystemManager.GetFileNameWithoutExtension(modello)

            Return OfficeWordDocumentGenerator.GenerateDocumentAndPrintOnBackGroundLowLevel(modello, TagTable, save, dest, suggestedName)

        Catch ex As Exception
            Throw New Exception("Impossibile generare il documento word", ex)
        End Try
    End Function

End Class