
Imports System
Imports System.IO
Imports System.Windows.Forms
Public Class ControlComunicazioneMassiva
    Private controller As New WIN.APPLICATION.ControllerComunicazioni
    Private controllerUtenti As New WIN.APPLICATION.UTENTI.ControllerUtenti
    Dim controllerCausali As New ControllerCausaleComunicazione
    Dim controllerTipo As New ControllerTipoComunicazione
    Dim controllerlista As New ControllerListaUtenti
    Dim controllerComunicazione As New ControllerComunicazioni
    Dim wordHandler As OfficeWordHandler
    Dim controllerCompilazione As New ControllerCompilazioneModelli

    Private frm1 As FrmElaborazioneInCorso


    Dim tag1 As String = ""
    Dim tag2 As String = ""
    Dim tag3 As String = ""

    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "Comunicazione massiva"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Comunicazione massiva"
        Me.lblCurrentFunction.Text = UCase("Comunicazione   massiva")
        SelectToolStripImage()
    End Sub

    'Protected Overrides Sub PostChangeActions()
    '   Try
    '      Dim logo As String = "Comunicazione massiva"
    '      MasterControl.Instance.ParentForm.Text = "Comunicazione massiva"
    '      MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Comunicazione massiva"
    '      Me.lblCurrentFunction.Text = "Comunicazione massiva"
    '   Catch ex As Exception
    '      NotifyParent()
    '   End Try

    'End Sub


    Public Sub New()
        InitializeComponent()
        DoLoad()
        Nested_NotifyParent()
    End Sub


#Region "Metodi per Load iniziale"
    Protected Overrides Sub Nested_PrepareLoading()
        'Dim listaModelli As IList = GetListaModelli()
        InterfaceMediator.LoadCombo(cboCausale, controllerCausali.GetListaCausali, False)
        InterfaceMediator.LoadCombo(cboTipo, controllerTipo.GetListaCausali, False)
        'InterfaceMediator.LoadCombo(cboModello, listaModelli, True)
    End Sub

    'Public Function GetListaModelli() As IList
    '   Dim list As IList(Of String) = My.Computer.FileSystem.GetFiles(My.Settings.PathModelli)
    '   Dim list1 As New ArrayList
    '   For Each elem As String In list
    '      Dim info As System.IO.FileInfo = My.Computer.FileSystem.GetFileInfo(elem)
    '      If (info.Attributes And FileAttributes.Hidden) <> FileAttributes.Hidden Then
    '         If info.Extension = ".dot" Or info.Extension = ".dotx" Then
    '            list1.Add(info.Name)
    '         End If
    '      End If
    '   Next
    '   Return list1
    'End Function



#End Region



    Public Overrides Sub DoLoad()
        Try
            MyBase.m_IsLoading = True
            Nested_PrepareLoading()
            MyBase.m_IsLoading = False
        Catch ex As Exception
            MyBase.m_IsLoading = False
            Throw
        End Try
    End Sub



    Private Sub Avvia()
        Try
            cmdAvviaProc.Enabled = False
            'Prendo il file modello da stampare
            Dim filename As String = lblModello.Text ' My.Settings.PathModelli & "\" & cboModello.Text
            'Carico la lista utente
            controllerlista.LoadById(IdListaUtentiTextBox1.TextValue)

            'Verifico l'esistenza del modello
            If Not My.Computer.FileSystem.FileExists(filename) Then
                MsgBox("Selezionare un modello corretto", MsgBoxStyle.Exclamation, "Selezione modello")
                cmdAvviaProc.Enabled = True
                Return
            End If

            'Chiedo di selezionare una stampante 
            If Not IsPrinterSelected() Then
                MsgBox("Operazione annullata dall'utente", MsgBoxStyle.Information, "Messaggio")
                cmdAvviaProc.Enabled = True
                Return
            End If

            'Chiedo conferma per proseguire
            If Not IsProcessConfirmed() Then
                MsgBox("Operazione annullata dall'utente", MsgBoxStyle.Information, "Messaggio")
                cmdAvviaProc.Enabled = True
                Return
            End If

            'Avvio il processo
            ' Helper.ShowWaitBox("Processo di stampa massiva in corso...", My.Resources.Waiting3)
            StartProcess(filename)
            ' Helper.HideWaitBox()

            'Notifico la fine del processo
            MsgBox("Operazioni eseguite correttamente!", MsgBoxStyle.Information, "Messaggio")


            cmdAvviaProc.Enabled = True

        Catch ex As Exception
            cmdAvviaProc.Enabled = True
            ErrorHandler.ShowError(ex)
        Finally
            'Helper.HideWaitBox()
        End Try
    End Sub


    Private Sub CreaNuovaComunicazione(ByVal utente As Utente)
        controllerComunicazione.CreateNew()
        controllerComunicazione.Data = DateTime.Now
        controllerComunicazione.Note = "Comunicazione massiva in data " & DateTime.Now.ToLongDateString
        controllerComunicazione.SetUtente(utente.IdUtente)
        controllerComunicazione.SetCausale(cboCausale.Text)
        controllerComunicazione.SetTipo(cboTipo.Text)
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


        Dim i As Int32 = 1
        Dim perc As Int32 = 0



        For Each elem As Utente In controllerlista.GetListaUtenti



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
            perc = CInt((100 / controllerlista.GetListaUtenti.Count) * i)

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
            i = i + 1
        Next

        frm1.Dispose()

    End Sub


    Private Function IsProcessConfirmed() As Boolean
        If MsgBox("Sicuro di avviare il processo di stampa?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Domanda") = MsgBoxResult.Yes Then
            Return True
        Else
            Return False
        End If

    End Function


    Private Function IsPrinterSelected() As Boolean
        Dim frm As New FrmSelectPrinter
        If frm.ShowDialog() = DialogResult.OK Then
            frm.Dispose()
            Return True
        Else
            frm.Dispose()
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


    'Private Sub PrintFile()
    '    wordHandler.Print()
    'End Sub

    'Private Sub cmdProp_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs)
    '    Try

    '        controllerlista.LoadById(IdListaUtentiTextBox1.TextValue)

    '        For Each elem As Object In controllerlista.GetListaUtenti
    '            controllerComunicazione.CreateNew()
    '            controllerComunicazione.Data = DateTime.Now
    '            controllerComunicazione.Note = "Comunicazione massiva in data " & DateTime.Now.ToLongDateString
    '            controllerComunicazione.SetUtente(elem.IdUtente)
    '            controllerComunicazione.SetCausale(cboCausale.Text)
    '            controllerComunicazione.SetTipo(cboTipo.Text)
    '            controllerComunicazione.Allegato = ""
    '            controllerComunicazione.Save()
    '        Next


    '        MsgBox("Comunicazioni utente create con successo!", MsgBoxStyle.Information, "Comunicazioni utente")


    '    Catch ex As Exception
    '        ErrorHandler.ShowError(ex)
    '    End Try
    'End Sub

    Private Sub cmdTags_DoClik(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles cmdTags.DoClik
        Dim frmTags As New FrmTagSupplementari(tag1, tag2, tag3)
        frmTags.ShowDialog()

        tag1 = frmTags.Tag1
        tag2 = frmTags.Tag2
        tag3 = frmTags.Tag3

        frmTags.Dispose()
    End Sub

    Private Sub lblId_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblId.DoubleClick
        Try
            Dim hash As New Hashtable
            hash.Add("Id", Me.IdListaUtentiTextBox1.TextValue)
            Me.NavigateTo("ViewListaLavoro", hash)
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub IdListaUtentiTextBox1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IdListaUtentiTextBox1.Leave
        InterfaceMediator.GetSimpleDescription(New WIN.APPLICATION.ControllerListaUtenti, "Descrizione", Me.lblDescrizione, Me.IdListaUtentiTextBox1.TextValue)
    End Sub

    Private Sub ControlComunicazioneMassiva_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DockPanel.Visible = False
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

   

    Private Sub cmdAvviaProc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAvviaProc.Click
        Avvia()
    End Sub

    Private Sub chkSaveCom_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSaveCom.CheckedChanged
        If chkSaveCom.Checked Then
            chkSaveFile.Enabled = True
        Else
            chkSaveFile.Enabled = False
        End If
    End Sub
End Class


