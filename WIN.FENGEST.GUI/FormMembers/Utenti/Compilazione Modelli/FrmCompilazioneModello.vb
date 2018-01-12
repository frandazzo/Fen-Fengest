
Imports System
Imports System.IO
Imports System.Windows.Forms
Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY


<SecureContext()> _
Public Class FrmCompilazioneModello




    Private controllerUtente As New WIN.APPLICATION.UTENTI.ControllerUtenti
    Dim controllerAzienda As New AZIENDE.ControllerAziende
    Dim controllerSegreteria As New ControllerSegreteria

    Dim wordHandler As OfficeWordHandler
    Dim controllerCompilazione As New ControllerCompilazioneModelli
    Dim con As New ControllerSegreteria

    Private frm1 As FrmElaborazioneInCorso


    Dim tag1 As String = ""
    Dim tag2 As String = ""
    Dim tag3 As String = ""


    Public Sub New()

        ' Chiamata richiesta da Progettazione Windows Form.
        InitializeComponent()
        PrepareLoading()
        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().


    End Sub

    Public Sub New(ByVal idutente As String)

        ' Chiamata richiesta da Progettazione Windows Form.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        PrepareLoading()

        IdUtenteTextBox1.TextValue = idutente

    End Sub
    <Secure(Area:="Servizi", Alias:="Modelli", Macroarea:="Compilazione")> _
    Private Sub PrepareLoading()
        SecurityManager.Instance.Check()
        con.LoadById("1")
    End Sub

    Private Sub AddToArchive(ByVal document As String)

        Dim c As ControllerArchivioDocumentale = Nothing
        If optAzienda.Checked Then
            c = New ControllerArchivioDocumentale(controllerAzienda.Current)
        End If
        If optUtente.Checked Then
            c = New ControllerArchivioDocumentale(controllerUtente.Current)
        End If
        If optSegreteria.Checked Then
            c = New ControllerArchivioDocumentale(con.Current)
        End If

        Dim frm As New FrmDocumentoElettronico(document, c, FrmDocumentoElettronico.DocumentoAction.Insert)
        If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
            c.Save()

        Else
            If MsgBox("Operazione annullata dall'utente. Il file generato nella cartella preferenziale deve essere cancellato?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Domanda") = MsgBoxResult.Yes Then
                My.Computer.FileSystem.DeleteFile(document)
            End If
        End If


    End Sub


    Private Function GetCartellaDestinazione() As String

        Dim dest As String




        If optAzienda.Checked Then
            dest = controllerAzienda.DirectoryPreferenziale
            If Not My.Computer.FileSystem.DirectoryExists(dest) Then
                dest = con.DirectoryPreferenzialeAziende
            End If
            Return dest
        End If


        If optUtente.Checked Then
            dest = controllerUtente.CartellaPreferenziale
            If Not My.Computer.FileSystem.DirectoryExists(dest) Then
                dest = con.DirectoryPreferenzialeUtenti
            End If
            Return dest
        End If


        Return con.DirectoryPreferenziale
    End Function


    Private Function GenerateDocument() As String

        Dim dest As String = GetCartellaDestinazione()
        Dim suggestedName As String = GetNomeSuggeritoModello()
        Dim modello As String = lblModello.Text 'My.Settings.PathModelli & "\" & cboModello.Text


        Dim c As New ControllerCompilazioneModelli
        Return c.GenerateDocument(IdUtenteTextBox1.TextValue, modello, GetTagTable(), dest, suggestedName)




    End Function

    Private Function InitializeHashTable() As Hashtable
        Dim hash As New Hashtable
        hash.Add("@Tag1@", tag1)
        hash.Add("@Tag2@", tag2)
        hash.Add("@Tag3@", tag3)
        Return hash
    End Function


    Private Function GetTagTable() As Hashtable
        Dim hash As Hashtable = InitializeHashTable()
        Return hash
    End Function

    Private Function GetNomeSuggeritoModello() As String
        Dim n As String = lblModello.Text
        Dim i As New IO.FileInfo(n)
        n = i.Name

        If n.EndsWith(".dot") Then
            n = n.Replace(".dot", "")
            Return n
        End If

        If n.EndsWith(".dotx") Then
            n = n.Replace(".dotx", "")
            Return n
        End If

        Return "DocumentGenerico"
    End Function


    Private Sub ProcessPartial()
        Try
            GenearateAndActivateDocument()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub


    Private Sub GenearateAndActivateDocument()
        Dim c As New ControllerCompilazioneModelli
        c.GenerateAndActivateTempDocument(IdUtenteTextBox1.TextValue, lblModello.Text, GetTagTable())
    End Sub
    Private Sub ProcessComplete()

        Dim doc As String = GenerateDocument()
        AddToArchive(doc)

        If My.Computer.FileSystem.FileExists(doc) Then
            SimpleFileSystemManager.ViewFile(doc)
        End If

    End Sub


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

    Private Sub lblModello_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblModello.Click
        Try
            If My.Computer.FileSystem.FileExists(lblModello.Text) Then
                System.Diagnostics.Process.Start(lblModello.Text)
            End If
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try

    End Sub



    Private Sub Wizard1_CloseFromCancel(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Wizard1.CloseFromCancel
        If MessageBox.Show("Sicuro di voler uscire dalla procedura guidata?", "Domanda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
            e.Cancel = False
        End If
    End Sub





    Private Sub ListPage_CloseFromNext(ByVal sender As System.Object, ByVal e As Wizard.PageEventArgs) Handles ListPage.CloseFromNext
        Try

            'qui verifico che la lista sia esistente
            controllerUtente.LoadByIdReloadingCache(IdUtenteTextBox1.TextValue)

        Catch ex As Exception

            ErrorHandler.ShowError(ex.Message & Environment.NewLine & "Selezionare un utente")
            e.Page = ListPage
        End Try
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


        'Avvio il processo
        ' Helper.ShowWaitBox("Processo di stampa massiva in corso...", My.Resources.Waiting3)
        StartProcess()
        ' Helper.HideWaitBox()


        'Notifico la fine del processo
        MsgBox("Operazione eseguita correttamente!", MsgBoxStyle.Information, "Messaggio")




    End Sub


    Private Sub StartProcess()

        If chkNoArchive.Checked Then


            ProcessPartial()
        Else


            ProcessComplete()

        End If






    End Sub




    Private Sub chkNoArchive_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNoArchive.CheckedChanged
        If chkNoArchive.Checked Then
            optAzienda.Enabled = False
            optSegreteria.Enabled = False
            optUtente.Enabled = False
            optAzienda.Checked = False
            optSegreteria.Checked = False
            optUtente.Checked = False

            IdAziendaTextBox1.EnableSerchTextBox = False

        Else
            optAzienda.Enabled = True
            optSegreteria.Enabled = True
            optUtente.Enabled = True
            optAzienda.Checked = False
            optSegreteria.Checked = False
            optUtente.Checked = True

            IdAziendaTextBox1.EnableSerchTextBox = False


        End If
    End Sub

    Private Sub optAzienda_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAzienda.CheckedChanged
        If optAzienda.Checked Then
            IdAziendaTextBox1.Visible = True
            IdAziendaTextBox1.EnableSerchTextBox = True
            IdAziendaTextBox1.Enabled = True
        Else
            IdAziendaTextBox1.Visible = False
            IdAziendaTextBox1.Enabled = False
        End If
    End Sub

    Private Sub ComunicationPage_CloseFromNext(ByVal sender As Object, ByVal e As Wizard.PageEventArgs) Handles ComunicationPage.CloseFromNext
        Try
            If Not chkNoArchive.Checked Then
                If optAzienda.Checked Then
                    controllerAzienda.LoadById(IdAziendaTextBox1.TextValue)
                End If
            End If
        Catch ex As Exception
            ErrorHandler.ShowError(ex.Message & Environment.NewLine & "Selezionare un'azienda")
            e.Page = ComunicationPage
        End Try
    End Sub



End Class