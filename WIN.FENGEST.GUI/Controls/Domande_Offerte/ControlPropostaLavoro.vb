Imports System.Windows.Forms
Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY
Imports WIN.SECURITY.Exceptions
Imports WIN.GUI.UTILITY

<SecureContext()> _
Public Class ControlPropostaLavoro
    Private controller As New WIN.APPLICATION.ControllerProposte
    Private controllerUtenti As New WIN.APPLICATION.UTENTI.ControllerUtenti
    Private controllerOfferte As New WIN.APPLICATION.ControllerOfferteLavoro

    Private m_IdUtente As Int32 = -1
    Private m_automaticCreation As Boolean = False



    Private Sub CustomBar1_DoInformationClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoInformationClick
        MsgBox(controller.CurrentObjectJournalingData, MsgBoxStyle.Information, "Informazione")
    End Sub

    <Secure(Area:="Proposte lavoro", Alias:="Creazione", Macroarea:="Comunicazioni")> _
    Protected Overrides Sub Nested_CheckSecurityForCreation()
        SecurityManager.Instance.Check()
    End Sub

    <Secure(Area:="Proposte lavoro", Alias:="Aggiornamento", Macroarea:="Comunicazioni")> _
    Protected Overrides Sub Nested_CheckSecurityForChanging()
        SecurityManager.Instance.Check()
    End Sub

    <Secure(Area:="Proposte lavoro", Alias:="Cancellazione", Macroarea:="Comunicazioni")> _
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
        MasterControl.Instance.ParentForm.Text = "" & MyBase.State.StateName & " proposta lavoro"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "" & MyBase.State.StateName & " proposta lavoro "
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  proposta   lavoro")
        SelectToolStripImage()
    End Sub
    Protected Overrides Sub Nested_PostLoadingActions()
        Dim logo As String = "" & MyBase.State.StateName & "  proposta lavoro"
        MasterControl.Instance.ParentForm.Text = logo & " " & UCase(controller.NomeUtente)
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo & " " & UCase(controller.NomeUtente)
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  -   proposta   lavoro  " & UCase(controller.NomeUtente))
        If TypeOf (Me.State) Is StView Then

        Else

        End If
    End Sub
    Protected Overrides Sub Nested_PostchangeActions()
        Try
            Dim logo As String = "" & MyBase.State.StateName & "  proposta lavoro"
            MasterControl.Instance.ParentForm.Text = logo & " " & UCase(controller.NomeUtente)
            MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo & " " & UCase(controller.NomeUtente)
            Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  -   proposta   lavoro   " & UCase(controller.NomeUtente))
        Catch ex As Exception
            Nested_NotifyParent()
        End Try

    End Sub

    Private Sub IdUtenteTextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles IdUtenteTextBox1.Leave
        LoadPreferenze()
    End Sub


    Private Sub LoadPreferenze()
        InterfaceMediator.GetSimpleDescription(controllerUtenti, "CompleteName", Me.lblDescrizioneUtente, Me.IdUtenteTextBox1.TextValue)

        LoadComboPreferenze()
    End Sub


    Private Sub LoadComboPreferenze()
        controllerUtenti.LoadById(IdUtenteTextBox1.TextValue)
        Try
            cboSkill.DataSource = controllerUtenti.GetListaSkillPreferiti
        Catch ex As NullReferenceException
            cboSkill.DataSource = New ArrayList
        End Try

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
        Me.AddCommandToHistory("ViewProposta", ParameterList)
    End Sub
    Protected Overrides Sub Nested_PostCreationActions()
        Me.AddCommandToHistory()
        Me.txtId.Enabled = False
        Me.txtId.Visible = True
        Me.lblId.Visible = True
    End Sub
    Protected Overrides Sub Navigate()
        Try
            Dim ParameterList As Hashtable = New Hashtable
            ParameterList.Add("Id", m_IdShowedObject)
            Me.NavigateWithoutHistoryTo("ViewProposta", ParameterList, True)
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



    Private Sub CustomBar1_DoStampaClick(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles CustomBar1.DoStampaClick

        DoPrint()

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

    Protected Overrides Sub DoPrint()
        Try
            Dim print As PrintFacade = New PrintFacade
            'print.PrintReportPropostaLavoro(controller)
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub





    Private Sub CustomBar1_DoEliminaClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoEliminaClick
        Try
            Nested_CheckSecurityForDeletion()
            If MsgBox("La proposta di lavoro sarà eliminata solamente se nel sistema non ci sono altri riferimenti. Sicuro di voler cancellare la proposta di lavoro? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminazione utente") = MsgBoxResult.Yes Then
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

    End Sub
    Public Sub New(ByVal IdProposta As Int32)
        InitializeComponent()
        Me.m_IdShowedObject = IdProposta

        DoLoad()

    End Sub

    Public Sub New(ByVal IdUtente As Int32, ByVal dummyField As Boolean)
        InitializeComponent()
        Me.m_IdUtente = IdUtente
        m_automaticCreation = True
        DoLoad()

    End Sub


#Region "Metodi per Load iniziale"
    Protected Overrides Sub Nested_PrepareLoading()
        Me.MainGroup.Visible = True
        Me.txtId.Text = ""
        Me.txtId.Visible = True
        Me.lblId.Visible = True
        Me.IdUtenteTextBox1.Enabled = False
        'MasterControl.Instance.ParentForm.Text = "Visualizzazione vertenza"
        CustomBar1.SetTargetControl(Me)

    End Sub

    Protected Overrides Sub Nested_ClearWindowEditors()
        'Qui pulisco tutti i campi della maschera
        dtpData.Value = Today
        txtNote.Text = ""
        dtpDoc.Value = Today

        Me.txtId.Text = ""
        Me.IdUtenteTextBox1.TextValue = ""
        Me.lblDescrizioneUtente.Text = ""

    End Sub
    Protected Overrides Sub Nested_LoadDataFromDataSource()
        'qui carico ordino il caricamento dei dati e carico le possibili scelte
        controller.LoadById(Me.m_IdShowedObject)
    End Sub
    Protected Overrides Sub Nested_LoadEditorsProperties()
        dtpData.Value = controller.DataRegistrazione

        dtpDoc.Value = controller.DataDocumento

        txtNote.Text = controller.Note
        Me.txtId.Text = controller.IdProposta
        Me.IdUtenteTextBox1.TextValue = controller.IdUtente
        Me.lblDescrizioneUtente.Text = controller.NomeUtente
        Me.lblAziendaDescrizione.Text = controller.DescrizioneAziendaRichiedente
        Me.IdOffertaTextBox1.TextValue = controller.IdOfferta
        LoadListaDettagliOfferta()
        LoadComboPreferenze()
        cboSkill.Text = controller.DescrizioneAbilita

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
        CustomBar1.SetTargetControl(Me)
        lblId.Visible = False
        txtId.Visible = False
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
        'If cboSkill.Text = "" Then
        '   LoadPreferenze()
        '   Throw New Exception("Offerta mancante")
        'End If

        controller.DataRegistrazione = dtpData.Value
        controller.DataDocumento = dtpDoc.Value
        controller.Note = txtNote.Text
        controller.SetUtente(Me.IdUtenteTextBox1.TextValue)
        controller.SetAbilita(cboSkill.Text)
        controller.SetOfferta(IdOffertaTextBox1.TextValue)
        controller.Save()
        MyBase.m_IdShowedObject = controller.IdProposta

    End Sub
#End Region



#Region "Metodi per l'aggiornamento"
    Public Overrides Sub Nested_UpdateData()

        controller.DataRegistrazione = dtpData.Value
        controller.DataDocumento = dtpDoc.Value
        controller.Note = txtNote.Text
        controller.SetUtente(Me.IdUtenteTextBox1.TextValue)
        controller.SetAbilita(cboSkill.Text)
        controller.SetOfferta(IdOffertaTextBox1.TextValue)
        controller.Save()
    End Sub

    Private Sub IdUtenteTextBox1_TextBoxChanged() Handles IdUtenteTextBox1.TextBoxChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub IdOffertaTextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles IdOffertaTextBox1.Leave
        InterfaceMediator.GetSimpleDescription(controllerOfferte, "DescrizioneAzienda", Me.lblAziendaDescrizione, Me.IdOffertaTextBox1.TextValue)
        LoadListaDettagliOfferta()

    End Sub
    Private Sub LoadListaDettagliOfferta()
        Try
            controllerOfferte.LoadById(IdOffertaTextBox1.TextValue)
            ListBox1.DataSource = controllerOfferte.GetListaDettagliOfferta
        Catch ex As NullReferenceException
            ListBox1.DataSource = New ArrayList
        Catch ex As Exception
            'ErrorHandler.ShowError(ex)
        End Try
    End Sub
    Private Sub IdOffertaTextBox1_TextBoxChanged() Handles IdOffertaTextBox1.TextBoxChanged
        Me.StartChangeOperation()
    End Sub
    Private Sub txtNote_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNote.TextChanged
        Me.StartChangeOperation()
    End Sub
    Private Sub dtpData_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpData.ValueChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub dtpDI_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDoc.ValueChanged
        Me.StartChangeOperation()
    End Sub



#End Region

















    Private Sub cboSkill_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSkill.SelectedIndexChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub lblOfferta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblOfferta.Click

    End Sub

    Private Sub lblOfferta_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblOfferta.DoubleClick
        Try
            Navigate(Me.IdOffertaTextBox1.TextValue, "ViewOfferta")
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub lblUtente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblUtente.Click

    End Sub

    Private Sub lblUtente_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblUtente.DoubleClick
        Try
            Navigate(Me.IdUtenteTextBox1.TextValue, "ViewUtente")
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub


End Class


