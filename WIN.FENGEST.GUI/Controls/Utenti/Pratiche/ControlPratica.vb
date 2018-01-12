Imports System.Windows.Forms
Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY
Imports WIN.SECURITY.Exceptions

<SecureContext()> _
Public Class ControlPratica
    Private controller As New ControllerPratiche
    Private controllerTP As New ControllerTipoPratica
    Private m_listaTipiPratica As IList
    Private m_current As Pratica

    Dim m_ClearCache As Boolean = False
    Private m_IdUtente As Int32 = -1
    Private m_automaticCreation As Boolean = False

    Public Sub New(ByVal IdPratica As Int32, ByVal ClearCache As Boolean)
        InitializeComponent()
        Me.m_IdShowedObject = IdPratica
        m_ClearCache = ClearCache

        DoLoad()

    End Sub
    Private Sub LoadComboProvincie(ByVal Lista As ArrayList)

        cboProvincia1.Items.Clear()
        For Each elem As String In Lista

            cboProvincia1.Items.Add(elem)
        Next

        cboProvincia1.Sorted = True

        cboProvincia1.Items.Add("")
    End Sub
    Public Sub New(ByVal IdUtente As Int32, ByVal dummyField1 As Boolean, ByVal dummyField2 As Boolean)
        InitializeComponent()
        m_IdUtente = IdUtente

        m_automaticCreation = True
        DoLoad()

    End Sub
    Public Sub New(ByVal IdPratica As Int32)
        InitializeComponent()
        Me.m_IdShowedObject = IdPratica

        DoLoad()

    End Sub

    Public Sub New()
        InitializeComponent()

        DoLoad()

    End Sub

    Public Overrides Sub StartChangeOperation()
        Try
            MyBase.StartChangeOperation()
        Catch ex As AccessDeniedException
            MsgBox("Impossibile aggiornare l'oggetto. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    <Secure(Area:="Pratiche", Alias:="Creazione", Macroarea:="Servizi")> _
    Protected Overrides Sub Nested_CheckSecurityForCreation()
        SecurityManager.Instance.Check()
    End Sub

    <Secure(Area:="Pratiche", Alias:="Aggiornamento", Macroarea:="Servizi")> _
    Protected Overrides Sub Nested_CheckSecurityForChanging()
        SecurityManager.Instance.Check()
    End Sub

    <Secure(Area:="Pratiche", Alias:="Cancellazione", Macroarea:="Servizi")> _
    Protected Overrides Sub Nested_CheckSecurityForDeletion()
        SecurityManager.Instance.Check()
    End Sub



    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "" & MyBase.State.StateName & " prestazione"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "" & MyBase.State.StateName & " prestazione "
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  prestazione")
        SelectToolStripImage()
    End Sub
    Protected Overrides Sub Nested_PostLoadingActions()
        Dim logo As String = "" & MyBase.State.StateName & "  prestazione"
        MasterControl.Instance.ParentForm.Text = logo & " " & UCase(m_current.NomeTipoPratica)
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo & " " & UCase(m_current.NomeTipoPratica)
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  -   prestazione  " & UCase(m_current.NomeTipoPratica)) & "  -  " & UCase(m_current.NomeUtente)

    End Sub
    Protected Overrides Sub Nested_PostchangeActions()
        Try
            Dim logo As String = "" & MyBase.State.StateName & "  prestazione"
            MasterControl.Instance.ParentForm.Text = logo & " " & UCase(m_current.NomeTipoPratica)
            MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo & " " & UCase(m_current.NomeTipoPratica)
            Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  -   prestazione   " & UCase(m_current.NomeTipoPratica))
        Catch ex As Exception
            Nested_NotifyParent()
        End Try
    End Sub


    Public Overrides Sub DoSearch()

        'Me.SpAddFile.Visible = False
        'Me.SpDel.Visible = False
        'Me.SpDelRef.Visible = False
        'Me.SpView.Visible = False
        NiceGroupBox1.Visible = False
        NiceGroupBox2.Visible = False

        MainGroup.Visible = False
        Me.lblIdPrest.Visible = False
        Me.txtIdPrest.Visible = False

        CustomBar1.Visible = False
        lblId.Visible = True
        Me.IdUtenteTextBox2.Visible = True
        CmdVis.Visible = True
        MasterControl.Instance.ParentForm.Text = "Ricerca Pratiche per utente"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Ricerca Pratiche per utente "
        Me.lblCurrentFunction.Text = UCase("Ricerca   Pratiche   per   utente")
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.SearchPaint
      

    End Sub


    Public Overrides Sub DoLoad()
        Try
            If Me.m_IdShowedObject <> -1 Then
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



    Protected Overrides Sub Nested_PrepareLoading()
        CustomBar1.Visible = True
        Me.CustomBar1.SetTargetControl(Me)
        'If m_listaTipiPratica Is Nothing Then
        '    m_listaTipiPratica = controllerTP.GetAll
        'End If




        'InterfaceMediator.LoadCombo(Me.cboTipo, m_listaTipiPratica, False)
        lblId.Visible = False
        Me.IdUtenteTextBox2.Visible = False
        Me.IdUtenteTextBox1.Enabled = False
        cboTipo.Enabled = False
        CmdVis.Visible = False

        Me.lblIdPrest.Visible = True
        Me.txtIdPrest.Visible = True
        CustomBar1.Visible = True
        MainGroup.Visible = True

        NiceGroupBox1.Visible = True
        NiceGroupBox2.Visible = True
        LoadComboProvincie(GeoLocationFacade.Instance.GetListaProvincie)
        txtCode.Text = ""
        lblDurata.Text = ""
        lblDataFine.Text = ""
       
    End Sub

    Protected Overrides Sub Nested_ClearWindowEditors()
        'Qui pulisco tutti i campi della maschera
        Me.IdUtenteTextBox1.TextValue = ""

        dtpData.Value = Now

        Me.txtNote.Text = ""
        'Me.cboTipo.Text = ""
        Me.txtIdPrest.Text = ""
        
        LoadComboProvincie(GeoLocationFacade.Instance.GetListaProvincie)
        txtCode.Text = ""
        lblDurata.Text = ""
        lblDataFine.Text = ""
    End Sub

    Protected Overrides Sub Nested_LoadEditorsProperties()
        Me.IdUtenteTextBox1.TextValue = m_current.Utente.Id
        InterfaceMediator.GetSimpleDescription(New WIN.APPLICATION.UTENTI.ControllerUtenti, "CompleteName", Me.lblDescrizioneUtente, Me.IdUtenteTextBox1.TextValue)

        'Me.txtId.Text = controller.IdPrestazione
        dtpData.Value = m_current.PraticaDate


        Me.txtNote.Text = m_current.Notes
        Me.cboTipo.Items.Add(m_current.TipoPratica)
        Me.cboTipo.SelectedIndex = 0
        txtIdPrest.Text = m_current.Id

        lblState.Text = m_current.StateName
        Label9.Text = m_current.GetStateOperator
        Label8.Text = m_current.GetOwnerOperator
        TextBox1.Text = m_current.GetStateNote

        cboProvincia1.Text = m_current.City
        txtCode.Text = m_current.Code
        lblDurata.Text = "Durata prest.: " + m_current.DurataPratica.ToString
        lblDataFine.Text = IIf(m_current.DataFine = DateTime.MinValue, "Data fine prest.: -", "Data fine prest.: " + m_current.DataFine.ToShortDateString)

        ''carico la lista dei dettagli 
        DataGridView1.DataSource = m_current.Details


        SetChangeStateButtons()


    End Sub

    Private Sub SetChangeStateButtons()
        Select Case m_current.State.State

            Case PracticeEnum.Aperta
                cmdControllo.Enabled = True
                cmdConfermata.Enabled = False
                cmdIntegrazione.Enabled = False
                cmdRigettata.Enabled = False
                cmdChiusa.Enabled = False
                SimpleButton3.Enabled = False
            Case PracticeEnum.Chiusa
                cmdControllo.Enabled = False
                cmdConfermata.Enabled = False
                cmdIntegrazione.Enabled = False
                cmdRigettata.Enabled = False
                cmdChiusa.Enabled = False
            Case PracticeEnum.Controllo
                cmdControllo.Enabled = False
                cmdConfermata.Enabled = True
                cmdIntegrazione.Enabled = True
                cmdRigettata.Enabled = True
                cmdChiusa.Enabled = False               
            Case PracticeEnum.Confermata
                cmdControllo.Enabled = False
                cmdConfermata.Enabled = False
                cmdIntegrazione.Enabled = False
                cmdRigettata.Enabled = False
                cmdChiusa.Enabled = True
            Case PracticeEnum.Integrazione
                cmdControllo.Enabled = True
                cmdConfermata.Enabled = False
                cmdIntegrazione.Enabled = False
                cmdRigettata.Enabled = False
                cmdChiusa.Enabled = False
            Case PracticeEnum.Rigettata
                cmdControllo.Enabled = False
                cmdConfermata.Enabled = False
                cmdIntegrazione.Enabled = False
                cmdRigettata.Enabled = False
                cmdChiusa.Enabled = False

        End Select
    End Sub


    Protected Overrides Sub Nested_LoadDataFromDataSource()
        'qui carico ordino il caricamento dei dati e carico le possibili scelte

        m_current = controller.GetPraticaById(Me.m_IdShowedObject)

    End Sub

    Protected Overrides Sub Nested_PrepareForCreation()
        Me.IdUtenteTextBox1.Enabled = True
        cboTipo.Enabled = True
        NiceGroupBox1.Visible = False
        NiceGroupBox2.Visible = False
        cmdPercorso.Visible = False


        Me.lblIdPrest.Visible = False
        Me.txtIdPrest.Visible = False
        MainGroup.Visible = True
        InterfaceMediator.LoadCombo(Me.cboTipo, controllerTP.GetAll, True)
        CustomBar1.SetTargetControl(Me)
        CustomBar1.Visible = True

        lblId.Visible = False

        Me.IdUtenteTextBox2.Visible = False
        CmdVis.Visible = False

        lblDescrizioneUtente.Text = ""
        If m_automaticCreation Then
            Me.m_automaticCreation = False
            Me.IdUtenteTextBox1.TextValue = m_IdUtente
            InterfaceMediator.GetSimpleDescription(New UTENTI.ControllerUtenti, "CompleteName", Me.lblDescrizioneUtente, m_IdUtente)
        End If

        LoadComboProvincie(GeoLocationFacade.Instance.GetListaProvincie)
        txtCode.Text = ""
        lblDurata.Text = ""
        lblDataFine.Text = ""

    End Sub




    Protected Overrides Sub Nested_PostSaveActions()
        'Me.SpAddFile.Visible = True
        'Me.SpDel.Visible = True
        'Me.SpDelRef.Visible = True
        'Me.SpView.Visible = True
        'Me.SpAddFile.Disabled = False
        'Me.SpDel.Disabled = False
        'Me.SpDelRef.Disabled = False
        'Me.SpView.Disabled = False
        Dim h As New Hashtable
        h.Add("Id", m_current.Id)
        NavigateTo("ViewPratica", h, True)

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
                Dim h As New Hashtable
                h.Add("Id", m_current.Id)
                NavigateTo("ViewPratica", h, True)
            End If
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub CustomBar1_DoEliminaClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoEliminaClick
        If Not m_current.State.IsChangeAuthorized(m_current) Then

            MessageBox.Show("L'utente non puo' eliminare la pratica poichè in carico ad un altro utente!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Try
            Nested_CheckSecurityForDeletion()
            If MsgBox("La pratica sarà eliminata solamente se nel sistema non ci sono altri riferimenti alla prestazione. Sicuro di voler cancellare la prestazione selezionata? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminazione utente") = MsgBoxResult.Yes Then
                controller.DeletePratica(m_current)
                MasterControl.Instance.GoPrevious()
            End If
        Catch ex As AccessDeniedException
            MsgBox("Impossibile eliminare l'elemento. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
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

    Private Sub CustomBar1_DoNewClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoNewClick
        Try

            Me.StartCreateOperation()
        Catch ex As AccessDeniedException
            MsgBox("Impossibile inserire un nuovo elemento. Accesso negato", MsgBoxStyle.Information, "Accesso negato")

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub





    Protected Overloads Sub GoPreviosCommand()


        MasterControl.Instance.GoPrevious()


    End Sub
    Private Overloads Sub AddCommandToHistory()
        Dim ParameterList As Hashtable = New Hashtable
        ParameterList.Add("Id", m_IdShowedObject)
        Me.AddCommandToHistory("ViewPratica", ParameterList)

    End Sub
    Protected Overrides Sub Nested_PostCreationActions()
        Me.AddCommandToHistory()
        Me.txtIdPrest.Enabled = False
        Me.txtIdPrest.Visible = True
        Me.lblIdPrest.Visible = True
        'Me.SpAddFile.Visible = True
        'Me.SpDel.Visible = True
        'Me.SpDelRef.Visible = True
        'Me.SpView.Visible = True
        'Me.SpAddFile.Disabled = False
        'Me.SpDel.Disabled = False
        'Me.SpDelRef.Disabled = False
        'Me.SpView.Disabled = False

    End Sub
    Protected Overrides Sub Navigate()
        Try
            Dim ParameterList As Hashtable = New Hashtable
            ParameterList.Add("Id", m_IdShowedObject)
            Me.NavigateWithoutHistoryTo("ViewPratica", ParameterList, True)
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")

        End Try
    End Sub
    Protected Overloads Sub NavigateToNew()
        Try
            Me.NavigateWithoutHistoryTo("CreatePratica")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")

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

    Public Overrides Sub Nested_InsertData()
        Dim c As New UTENTI.ControllerUtenti()
        c.LoadById(Me.IdUtenteTextBox1.TextValue)

        m_current = New Pratica
        m_current.PraticaDate = dtpData.Value
        m_current.Utente = c.Current
        If Not String.IsNullOrEmpty(cboTipo.SelectedItem.ToString) Then
            m_current.TipoPratica = cboTipo.SelectedItem
        End If

        m_current.Notes = txtNote.Text

        m_current.Owner = SecurityManager.Instance.CurrentUser


        m_current.Code = txtCode.Text
        m_current.City = cboProvincia1.Text



        controller.SaveOrUpdatePratica(m_current)

        MyBase.m_IdShowedObject = m_current.Id


    End Sub

    Public Overrides Sub Nested_UpdateData()


        m_current.PraticaDate = dtpData.Value
        m_current.Notes = txtNote.Text

        m_current.Code = txtCode.Text
        m_current.City = cboProvincia1.Text

        controller.SaveOrUpdatePratica(m_current)

    End Sub
    Public Overrides Sub Nested_PrepareForUpdate()
        MyBase.Nested_PrepareForUpdate()

        NiceGroupBox1.Visible = False
        NiceGroupBox2.Visible = False
        cmdPercorso.Visible = False

        'Me.SpDel.Disabled = True
        'Me.SpDelRef.Disabled = True
        'Me.SpView.Disabled = True
    End Sub

    Private Sub txtNote_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNote.TextChanged
        Me.StartChangeOperation()
    End Sub
    Private Sub dtpData_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpData.ValueChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub lblUtente_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblUtente.DoubleClick
        Try
            Navigate(Me.IdUtenteTextBox1.TextValue, "ViewUtente")
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles cmdPercorso.Click
        Try
            Dim frm As New FrmEventiPratica(m_current.Events)
            frm.ShowDialog()
            frm.Dispose()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            If Not m_current.State.IsChangeAuthorized(m_current) Then

                MessageBox.Show("L'utente non puo' modificare la pratica poichè in carico ad un altro utente!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If


            Dim frm As New FrmAggiungiAllegatoPratica(m_current, Nothing)
            If frm.ShowDialog() = DialogResult.OK Then

                'DataGridView1.DataSource = Nothing
                'DataGridView1.DataSource = m_current.Details
                ' DataGridView1.Rows(0).Selected = True
                Dim h As New Hashtable
                h.Add("Id", m_current.Id)
                NavigateTo("ViewPratica", h, True)
            End If
            frm.Dispose()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Errore")
        End Try
    End Sub

    Private Sub SimpleButton8_Click(sender As Object, e As EventArgs) Handles SimpleButton8.Click

        If Not m_current.State.IsChangeAuthorized(m_current) Then

            MessageBox.Show("L'utente non puo' modificare la pratica poichè in carico ad un altro utente!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Dim frm As New FrmPraticaWizard(m_current)
            If frm.ShowDialog() = DialogResult.OK Then
                'DataGridView1.DataSource = Nothing
                'DataGridView1.DataSource = m_current.Details
                Dim h As New Hashtable
                h.Add("Id", m_current.Id)
                NavigateTo("ViewPratica", h, True)
            End If
            frm.Dispose()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click

        If DataGridView1.SelectedRows.Count = 0 Then

            MessageBox.Show("Nessuna riga è stata selezionata. Selezionare una riga.", "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return

        End If

        If DataGridView1.SelectedRows.Count > 1 Then

            MessageBox.Show(" Selezionare una riga.", "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return

        End If

        If Not m_current.State.IsChangeAuthorized(m_current) Then

            MessageBox.Show("L'utente non puo' modificare la pratica poichè in carico ad un altro utente!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If MessageBox.Show("Sicuro di voler eliminare l'elemento selezioanto?", "Domanda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            m_current.RemoveDetail(DirectCast(DataGridView1.SelectedRows(0).DataBoundItem, PraticaDetail))
            'salvo
            controller.SaveOrUpdatePratica(m_current)
            'rinfesco la lista
            DataGridView1.DataSource = Nothing
            DataGridView1.DataSource = m_current.Details
        End If
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles cmdControllo.Click
        'controllo
        If Not m_current.State.IsChangeAuthorized(m_current) Then

            MessageBox.Show("L'utente non puo' modificare la pratica poichè in carico ad un altro utente!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Try
            Dim frm As New FrmCambioStatoratica("Controllo", m_current, PracticeEnum.Controllo)
            If frm.ShowDialog() = DialogResult.OK Then
                Dim h As New Hashtable
                h.Add("Id", m_current.Id)
                NavigateTo("ViewPratica", h, True)
            End If
            frm.Dispose()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles cmdConfermata.Click
        'conferma
        If Not m_current.State.IsChangeAuthorized(m_current) Then

            MessageBox.Show("L'utente non puo' modificare la pratica poichè in carico ad un altro utente!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Try
            Dim frm As New FrmCambioStatoratica("Conferma doc.", m_current, PracticeEnum.Confermata)
            If frm.ShowDialog() = DialogResult.OK Then
                Dim h As New Hashtable
                h.Add("Id", m_current.Id)
                NavigateTo("ViewPratica", h, True)
            End If
            frm.Dispose()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles cmdIntegrazione.Click
        'Integra
        If Not m_current.State.IsChangeAuthorized(m_current) Then

            MessageBox.Show("L'utente non puo' modificare la pratica poichè in carico ad un altro utente!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Try
            Dim frm As New FrmCambioStatoratica("Integra doc.", m_current, PracticeEnum.Integrazione)
            If frm.ShowDialog() = DialogResult.OK Then
                Dim h As New Hashtable
                h.Add("Id", m_current.Id)
                NavigateTo("ViewPratica", h, True)
            End If
            frm.Dispose()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles cmdRigettata.Click
        'rigetta
        If Not m_current.State.IsChangeAuthorized(m_current) Then

            MessageBox.Show("L'utente non puo' modificare la pratica poichè in carico ad un altro utente!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Try
            Dim frm As New FrmCambioStatoratica("Rigetta prat.", m_current, PracticeEnum.Rigettata)
            If frm.ShowDialog() = DialogResult.OK Then
                Dim h As New Hashtable
                h.Add("Id", m_current.Id)
                NavigateTo("ViewPratica", h, True)
            End If
            frm.Dispose()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles cmdChiusa.Click
        'chiudi
        If Not m_current.State.IsChangeAuthorized(m_current) Then

            MessageBox.Show("L'utente non puo' modificare la pratica poichè in carico ad un altro utente!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Try
            Dim frm As New FrmCambioStatoratica("Chiudi prat.", m_current, PracticeEnum.Chiusa)
            If frm.ShowDialog() = DialogResult.OK Then
                Dim h As New Hashtable
                h.Add("Id", m_current.Id)
                NavigateTo("ViewPratica", h, True)
            End If
            frm.Dispose()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub



    Private Sub DataGridView1_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseDoubleClick
        Try
            If e.RowIndex = -1 Or e.ColumnIndex = -1 Then
                Return
            End If

            Dim detail As PraticaDetail = DirectCast(DataGridView1.Rows(e.RowIndex).DataBoundItem, PraticaDetail)

            If e.ColumnIndex = 0 Then
                'sto cliccando sulla data
                'apro il dettaglio

                Dim frm As New FrmAggiungiAllegatoPratica(m_current, detail)
                frm.ShowDialog()
                frm.Dispose()


            Else
                'visualizzo il file
                Process.Start(detail.FilePath)
            End If

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub SimpleButton3_Click_1(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        If Not m_current.State.IsChangeAuthorized(m_current) Then

            MessageBox.Show("L'utente non puo' modificare la pratica poichè in carico ad un altro utente!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If MessageBox.Show("Vuoi tornare allo stato precedente?", "Domanda", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                m_current.State.RecoveryPrecedingState(m_current)
                controller.SaveOrUpdatePratica(m_current)
                Dim h As New Hashtable
                h.Add("Id", m_current.Id)
                NavigateTo("ViewPratica", h, True)
            Catch ex As Exception
                ErrorHandler.ShowError(ex)
            End Try
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Try
            If cboTipo.SelectedItem.Id > 0 Then
                Navigate(cboTipo.SelectedItem.Id, "ViewTipoPratica")
            End If

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub cboProvincia1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProvincia1.SelectedIndexChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub txtCode_TextChanged(sender As Object, e As EventArgs) Handles txtCode.TextChanged
        Me.StartChangeOperation()
    End Sub
End Class
