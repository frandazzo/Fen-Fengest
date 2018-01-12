Imports System
Imports System.IO
Imports System.Windows.Forms
Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY
Imports WIN.SECURITY.Exceptions
Imports WIN.GUI.UTILITY

<SecureContext()> _
Public Class ControlComunicazione
    Private controller As New WIN.APPLICATION.ControllerComunicazioni
    Private controllerUtenti As New WIN.APPLICATION.UTENTI.ControllerUtenti
    Dim controllerCausali As New ControllerCausaleComunicazione
    Dim controllerTipo As New ControllerTipoComunicazione
    Dim conSeg As New ControllerSegreteria

    Dim tag1 As String = ""
    Dim tag2 As String = ""
    Dim tag3 As String = ""

    Private m_IdUtente As Int32 = -1
    Private m_automaticCreation As Boolean = False


    Private Sub CustomBar1_DoInformationClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoInformationClick
        MsgBox(controller.CurrentObjectJournalingData, MsgBoxStyle.Information, "Informazione")
    End Sub

    <Secure(Area:="Comunicazioni", Alias:="Creazione", Macroarea:="Comunicazioni")> _
    Protected Overrides Sub Nested_CheckSecurityForCreation()
        SecurityManager.Instance.Check()
    End Sub

    <Secure(Area:="Comunicazioni", Alias:="Aggiornamento", Macroarea:="Comunicazioni")> _
    Protected Overrides Sub Nested_CheckSecurityForChanging()
        SecurityManager.Instance.Check()
    End Sub

    <Secure(Area:="Comunicazioni", Alias:="Cancellazione", Macroarea:="Comunicazioni")> _
    Protected Overrides Sub Nested_CheckSecurityForDeletion()
        SecurityManager.Instance.Check()
    End Sub
    Public Overrides Sub StartChangeOperation()
        Try
            MyBase.StartChangeOperation()
        Catch ex As AccessDeniedException
            MsgBox("Impossibile aggiornare l'oggetto. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "" & MyBase.State.StateName & " comunicazione utente"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "" & MyBase.State.StateName & " comunicazione utente "
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  comunicazione   utente")
        SelectToolStripImage()
    End Sub
    Protected Overrides Sub Nested_PostLoadingActions()
        Dim logo As String = "" & MyBase.State.StateName & "  comunicazione utente"
        MasterControl.Instance.ParentForm.Text = logo & " " & UCase(controller.NomeUtente)
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo & " " & UCase(controller.NomeUtente)
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  -   comunicazione    utente  " & UCase(controller.NomeUtente))
        If TypeOf (Me.State) Is StView Then

        Else

        End If
    End Sub
    Protected Overrides Sub Nested_PostchangeActions()
        Try
            Dim logo As String = "" & MyBase.State.StateName & "  comunicazione utente"
            MasterControl.Instance.ParentForm.Text = logo & " " & UCase(controller.NomeUtente)
            MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo & " " & UCase(controller.NomeUtente)
            Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  -   comunicazione   utente   " & UCase(controller.NomeUtente))
            SpDel.Disabled = False
            SpDelRef.Disabled = False
            SpView.Disabled = True

        Catch ex As Exception
            Nested_NotifyParent()
        End Try

    End Sub

    Protected Overrides Sub Nested_PostSaveActions()
        SpDel.Disabled = False
        SpDelRef.Disabled = False
        SpView.Disabled = False
    End Sub

    Private Sub IdUtenteTextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles IdUtenteTextBox1.Leave
        InterfaceMediator.GetSimpleDescription(controllerUtenti, "CompleteName", Me.lblDescrizioneUtente, Me.IdUtenteTextBox1.TextValue)

    End Sub





    Protected Overloads Sub Navigate(ByVal ToId As String, ByVal Link As String)
        Try
            Dim ParameterList As Hashtable = New Hashtable
            ParameterList.Add("Id", ToId)
            Me.NavigateTo(Link, ParameterList)
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub



    Private Overloads Sub AddCommandToHistory()
        Dim ParameterList As Hashtable = New Hashtable
        ParameterList.Add("Id", m_IdShowedObject)
        Me.AddCommandToHistory("ViewComunicazione", ParameterList)
    End Sub
    Protected Overrides Sub Nested_PostCreationActions()
        Me.AddCommandToHistory()
        Me.txtId.Enabled = False
        Me.txtId.Visible = True
        Me.lblId.Visible = True
        Me.IdUtenteTextBox1.Enabled = False
        SpDel.Disabled = False
        SpDelRef.Disabled = False
        SpView.Disabled = False
    End Sub
    Protected Overrides Sub Navigate()
        Try
            Dim ParameterList As Hashtable = New Hashtable
            ParameterList.Add("Id", m_IdShowedObject)
            Me.NavigateWithoutHistoryTo("ViewComunicazione", ParameterList, True)
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub
    Private Sub lblDescrizioneUtente_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblDescrizioneUtente.DoubleClick
        Try
            Navigate(Me.IdUtenteTextBox1.TextValue, "ViewUtente")
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub




    Private Sub CustomBar1_DoAnnullaClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoAnnullaClick
        DoUndo()
    End Sub

    Public Overrides Sub DoUndo()
        Try
            If Me.State.StateName = "Creazione" Then
                MasterControl.Instance.GoPrevious()
            Else
                'inserisco il do load per recuperare gli eventi
                Me.StartUndoOperation()
                DoLoad()
            End If
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub




    Private Sub CustomBar1_DoEliminaClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoEliminaClick
        Try
            Nested_CheckSecurityForDeletion()
            If MsgBox("La comunicazione utente  sarà eliminata solamente se nel sistema non ci sono altri riferimenti. Sicuro di voler cancellare la comunicazione utente? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminazione comunicazione utente") = MsgBoxResult.Yes Then
                controller.Delete()
                MasterControl.Instance.GoPrevious()
            End If
        Catch ex As AccessDeniedException
            MsgBox("Impossibile eliminare l'elemento. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    Private Sub CustomBar1_DoNewClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoNewClick
        Try
            'NavigateWithoutHistoryTo("CreateVertenza")
            Me.StartCreateOperation()
        Catch ex As AccessDeniedException
            MsgBox("Impossibile inserire un nuovo elemento. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    Private Sub CustomBar1_DoSaveClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoSaveClick
        Try
            StartSaveOperation()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub





    Public Sub New()
        InitializeComponent()

        DoLoad()

        conSeg.LoadById("1")
    End Sub
    Public Sub New(ByVal IdComunicazione As Int32)
        InitializeComponent()
        Me.m_IdShowedObject = IdComunicazione

        DoLoad()
        conSeg.LoadById("1")
    End Sub
    Public Sub New(ByVal IdUtente As Int32, ByVal dummyField As Boolean)
        InitializeComponent()
        Me.m_IdUtente = IdUtente
        m_automaticCreation = True
        DoLoad()
        conSeg.LoadById("1")
    End Sub

    Private Sub LoadFileStateImage()
        If My.Computer.FileSystem.FileExists(lblDocumento.Text) Then
            PictureBox1.BackgroundImage = My.Resources.OK
        Else
            PictureBox1.BackgroundImage = My.Resources.WarningHS
        End If
    End Sub

#Region "Metodi per Load iniziale"
    Protected Overrides Sub Nested_PrepareLoading()
        ' Dim listaModelli As IList = GetListaModelli()
        Me.MainGroup.Visible = True
        GroupBox1.Visible = True
        Me.txtId.Text = ""
        Me.txtId.Visible = True
        Me.lblId.Visible = True
        Me.IdUtenteTextBox1.Enabled = False
        'chkModello.Checked = False
        'ChangeCheState()
        SpDel.Disabled = False
        SpDelRef.Disabled = False
        SpView.Disabled = False
        'MasterControl.Instance.ParentForm.Text = "Visualizzazione vertenza"
        CustomBar1.SetTargetControl(Me)
        InterfaceMediator.LoadCombo(cboCausale, controllerCausali.GetListaCausali, False)
        InterfaceMediator.LoadCombo(cboTipo, controllerTipo.GetListaCausali, False)
        'InterfaceMediator.LoadCombo(cboModello, listaModelli, True)

    End Sub

    Public Function GetListaModelli() As IList
        Dim list As IList(Of String)
        Try
            list = My.Computer.FileSystem.GetFiles(conSeg.CartellaModelli)
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
            list = New List(Of String)
        End Try

        Dim list1 As New ArrayList
        For Each elem As String In list
            Dim info As System.IO.FileInfo = My.Computer.FileSystem.GetFileInfo(elem)
            If (info.Attributes And FileAttributes.Hidden) <> FileAttributes.Hidden Then
                If info.Extension = ".dot" Or info.Extension = ".dotx" Then
                    list1.Add(info.Name)
                End If
            End If
        Next
        Return list1
    End Function

    Protected Overrides Sub Nested_ClearWindowEditors()
        'Qui pulisco tutti i campi della maschera
        dtpData.Value = Today
        txtNote.Text = ""
        cboCausale.Text = ""
        cboTipo.Text = ""
        lblModello.Text = ""
        lblDocumento.Text = "Nessun documento"
        lblDocumento.ForeColor = Color.Black

        Me.txtId.Text = ""
        Me.IdUtenteTextBox1.TextValue = ""
        Me.lblDescrizioneUtente.Text = ""

    End Sub
    Protected Overrides Sub Nested_LoadDataFromDataSource()
        'qui carico ordino il caricamento dei dati e carico le possibili scelte
        controller.LoadById(Me.m_IdShowedObject)
    End Sub
    Protected Overrides Sub Nested_LoadEditorsProperties()
        dtpData.Value = controller.Data
        txtNote.Text = controller.Note
        Me.txtId.Text = controller.IdComunicazione
        Me.IdUtenteTextBox1.TextValue = controller.IdUtente
        Me.lblDescrizioneUtente.Text = controller.NomeUtente

        cboCausale.Text = controller.DescrizioneCausale
        cboTipo.Text = controller.DescrizioneTipo
        If controller.Allegato = "" Then
            lblDocumento.Text = "Nessun documento"
            lblDocumento.ForeColor = Color.Black
        Else
            lblDocumento.Text = controller.Allegato
            lblDocumento.ForeColor = System.Drawing.SystemColors.ActiveCaption
        End If

        LoadFileStateImage()


    End Sub
#End Region


#Region "Metodi per la creazione di un nuovo oggetto"
    Public Overrides Sub DoLoad()
        Try
            If Me.m_IdShowedObject = -1 Then
                'Me.PrepareForCreation()
            Else
                MyBase.m_IsLoading = True
                Nested_PrepareLoading()
                Nested_ClearWindowEditors()
                Nested_LoadDataFromDataSource()
                Nested_LoadEditorsProperties()
                Nested_PostLoadingActions()
                MyBase.m_IsLoading = False
            End If
        Catch ex As Exception
            MyBase.m_IsLoading = False
            Throw
        End Try
    End Sub
    Protected Overrides Sub Nested_PrepareForCreation()
        Dim listaModelli As IList = GetListaModelli()
        CustomBar1.SetTargetControl(Me)
        lblId.Visible = False
        txtId.Visible = False
        'chkModello.Checked = False
        'cboModello.Enabled = False
        SpDel.Disabled = True
        SpDelRef.Disabled = True
        SpView.Disabled = True


        InterfaceMediator.LoadCombo(cboCausale, controllerCausali.GetListaCausali, False)
        InterfaceMediator.LoadCombo(cboTipo, controllerTipo.GetListaCausali, False)

        'InterfaceMediator.LoadCombo(cboModello, listaModelli, True)
        controller.CreateNew()

        Me.IdUtenteTextBox1.Enabled = True
        If m_automaticCreation Then
            Me.m_automaticCreation = False
            Me.IdUtenteTextBox1.TextValue = m_IdUtente
            InterfaceMediator.GetSimpleDescription(New UTENTI.ControllerUtenti, "CompleteName", Me.lblDescrizioneUtente, m_IdUtente)
        End If
    End Sub

#End Region


#Region "Metodi per il salvataggio"
    Public Overrides Sub Nested_InsertData()


        controller.Data = dtpData.Value
        controller.Note = txtNote.Text
        controller.SetUtente(Me.IdUtenteTextBox1.TextValue)
        controller.SetCausale(cboCausale.Text)
        controller.SetTipo(cboTipo.Text)
        If lblDocumento.Text = "Nessun documento" Then
            controller.Allegato = ""
        Else
            controller.Allegato = lblDocumento.Text
        End If

        controller.Save()

        GenerateAndSaveDocument()


        MyBase.m_IdShowedObject = controller.IdComunicazione
        lblModello.Text = ""
    End Sub

    Private Sub GenerateAndSaveDocument()
        VerifyInput()


        Dim modello As String = lblModello.Text
        If modello <> "" Then
            Dim documento As String = controller.GenerateDocument(modello, GetTagTable())
            controller.Allegato = documento
            controller.Save()
            lblDocumento.Text = controller.Allegato
            SimpleFileSystemManager.ViewFile(controller.Allegato)
        End If
    End Sub

    Private Sub VerifyInput()
        If controller.Current Is Nothing Then
            Throw New InvalidOperationException("Comunicazione non creata. Creare prima una comunicazione!")
        End If
        If controller.Current.Utente Is Nothing Then
            Throw New InvalidOperationException("Utente non selezionato. Salvare prima la comunicazione!")
        End If
    End Sub


    Private Function GetTagTable() As Hashtable
        Dim hash As Hashtable = InitializeHashTable()
        Return hash
    End Function

    'Private Function GetModello() As String
    '   Dim modello As String = My.Settings.PathModelli & "\" & cboModello.Text
    '   If Not My.Computer.FileSystem.FileExists(modello) Then
    '      modello = ""
    '   End If
    '   If chkModello.Checked Then
    '      Return modello
    '   Else
    '      Return ""
    '   End If
    'End Function
#End Region



#Region "Metodi per l'aggiornamento"
    Public Overrides Sub Nested_UpdateData()

        controller.Data = dtpData.Value
        controller.Note = txtNote.Text
        controller.SetUtente(Me.IdUtenteTextBox1.TextValue)
        controller.SetCausale(cboCausale.Text)
        controller.SetTipo(cboTipo.Text)
        If lblDocumento.Text = "Nessun documento" Then
            controller.Allegato = ""
        Else
            controller.Allegato = lblDocumento.Text
        End If
        controller.Save()
        lblModello.Text = ""
    End Sub

    Private Sub IdUtenteTextBox1_TextBoxChanged() Handles IdUtenteTextBox1.TextBoxChanged
        Me.StartChangeOperation()
    End Sub




    Private Sub txtNote_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNote.TextChanged
        Me.StartChangeOperation()
    End Sub
    Private Sub dtpData_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpData.ValueChanged
        Me.StartChangeOperation()
    End Sub





#End Region

    Private Sub cboTipo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.StartChangeOperation()
    End Sub

    Private Sub cboCausale_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.StartChangeOperation()
    End Sub


    Private Sub lblUtente_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblUtente.DoubleClick
        Try
            Navigate(Me.IdUtenteTextBox1.TextValue, "ViewUtente")
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub




#Region "Metodi sul file di output"

    Private Sub SpView_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles SpView.DoClik
        Try
            controller.OpenFile(Me.lblDocumento.Text)
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    Private Sub SpAddFile_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles SpAddFile.DoClik
        'OpenFileDialog1.ShowDialog()
        'lblDocumento.Text = OpenFileDialog1.FileName
        'lblDocumento.ForeColor = System.Drawing.SystemColors.ActiveCaption

        'Change()


        Try
            Dim frm As New FrmAllegaFile()
            frm.Destination = GetCartellaPreferenziale()
            Dim dialog As System.Windows.Forms.DialogResult = frm.ShowDialog

            If dialog = Windows.Forms.DialogResult.OK Then
                lblDocumento.Text = frm.FileName
                lblDocumento.ForeColor = System.Drawing.SystemColors.ActiveCaption
                LoadFileStateImage()
                Me.StartChangeOperation()
            End If
            frm.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Errore")
        End Try


    End Sub


    Private Function GetCartellaPreferenziale() As String
        If controllerUtenti Is Nothing Then
            controllerUtenti = New UTENTI.ControllerUtenti
        End If

        controllerUtenti.LoadById(IdUtenteTextBox1.TextValue)



        Return controllerUtenti.CartellaPreferenziale

    End Function

    Private Sub SpDel_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles SpDel.DoClik

        Try
            If My.Computer.FileSystem.FileExists(lblDocumento.Text) Then
                If MsgBox("Il file sarà irrevocabilmente rimosso. Sicuro di voler eliminare il file?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminazione file prestazione") = MsgBoxResult.Yes Then
                    controller.RemoveReferenceToOutputFile()
                    My.Computer.FileSystem.DeleteFile(lblDocumento.Text)
                    lblDocumento.Text = "Nessun documento"
                    lblDocumento.ForeColor = Color.Black
                    StartSaveOperation()
                End If
            End If
        Catch ex As Exception
            'ErrorHandler.ShowError(ex)
        End Try
    End Sub
    Private Sub SpDelRef_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles SpDelRef.DoClik

        'If MsgBox("Sicuro di voler eliminare il riferimento al file?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminazione file prestazione") = MsgBoxResult.Yes Then
        controller.RemoveReferenceToOutputFile()
        lblDocumento.Text = "Nessun documento"
        lblDocumento.ForeColor = Color.Black

        StartChangeOperation()
        'End If

    End Sub

#End Region



    Private Sub cmdTags_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles cmdTags.DoClik
        Dim frmTags As New FrmTagSupplementari(tag1, tag2, tag3)
        frmTags.ShowDialog()

        tag1 = frmTags.Tag1
        tag2 = frmTags.Tag2
        tag3 = frmTags.Tag3

        frmTags.Dispose()
    End Sub





    Private Sub cmdCreateDocument_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles cmdCreateDocument.DoClik
        '  MsgBox("ciao")

        Try
            'Dim filename As String = My.Settings.PathModelli & "\" & cboModello.Text
            'If My.Computer.FileSystem.FileExists(filename) Then
            '   Dim wordHandler As New OfficeWordHandler
            '   wordHandler.OpenWordApplication(True)
            '   wordHandler.AddDocumentToWord(filename)

            '   Dim hash As Hashtable = InitializeHashTable()


            '   Dim tagValues As Hashtable = controller.CreateTagValuesMap(Me.IdUtenteTextBox1.TextValue, hash)
            '   Dim enumerator As IDictionaryEnumerator = tagValues.GetEnumerator
            '   Do While enumerator.MoveNext
            '      wordHandler.FindReplace(enumerator.Key, enumerator.Value)
            '   Loop

            '   wordHandler.ActivateDocument()

            'Else
            '   MsgBox("Selezionare un modello corretto", MsgBoxStyle.Exclamation, "Selezione modello")
            'End If

            If IO.File.Exists(lblModello.Text) Then
                If MsgBox("Si sta per creare un documento che verrà assegnato alla comunicazione corrente. Proseguire?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Messaggio") = MsgBoxResult.Yes Then
                    GenerateAndSaveDocument()
                    LoadFileStateImage()
                End If
            End If
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    Private Function InitializeHashTable() As Hashtable
        Dim hash As New Hashtable
        hash.Add("@Tag1@", tag1)
        hash.Add("@Tag2@", tag2)
        hash.Add("@Tag3@", tag3)
        Return hash
    End Function


    Private Sub CustomBar1_DoStampaClick(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles CustomBar1.DoStampaClick

        DoPrint()

    End Sub


    Protected Overrides Sub DoPrint()
        Try
            Dim print As PrintFacade = New PrintFacade
            print.PrintReportComunicazioni(controller)
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub





    Private Sub cboTipo_SelectedIndexChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTipo.SelectedIndexChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub cboCausale_SelectedIndexChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCausale.SelectedIndexChanged
        Me.StartChangeOperation()
    End Sub

    'Private Sub chkModello_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '   ChangeCheState()
    'End Sub

    'Private Sub ChangeCheState()
    '   If chkModello.Checked Then
    '      'cboModello.Enabled = True
    '      cmdTags.Disabled = False
    '      cmdCreateDocument.Disabled = False


    '   Else
    '      'cboModello.Enabled = False
    '      cmdTags.Disabled = True
    '      cmdCreateDocument.Disabled = True
    '   End If
    'End Sub

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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        lblModello.Text = ""
    End Sub

    Private Sub ControlComunicazione_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


    End Sub
End Class
