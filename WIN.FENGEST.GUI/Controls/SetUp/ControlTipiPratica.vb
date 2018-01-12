Imports WIN.SECURITY.Exceptions
Imports WIN.SECURITY.Core

<SecureContext()> _
Public Class ControlTipiPratica
    Private controller As New ControllerTipoPratica
    Private m_current As TipoPratica

    Public Sub New(Id As Object)

        ' Chiamata richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        CustomBar1.SetTargetControl(Me)
        SetViewModeForTipo(Id)
    End Sub

    Public Sub New()

        ' Chiamata richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        CustomBar1.SetTargetControl(Me)
        Me.m_IdShowedObject = -1
        DoLoad()
    End Sub

    Public Overrides Sub StartChangeOperation()
        Try
            MyBase.StartChangeOperation()
        Catch ex As AccessDeniedException
            MsgBox("Impossibile aggiornare l'oggetto. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    <Secure(Area:="TipiPratica", Alias:="Creazione", Macroarea:="Setup")> _
    Protected Overrides Sub Nested_CheckSecurityForCreation()
        SecurityManager.Instance.Check()
    End Sub

    <Secure(Area:="TipiPratica", Alias:="Aggiornamento", Macroarea:="Setup")> _
    Protected Overrides Sub Nested_CheckSecurityForChanging()
        SecurityManager.Instance.Check()
    End Sub

    <Secure(Area:="TipiPratica", Alias:="Cancellazione", Macroarea:="Setup")> _
    Protected Overrides Sub Nested_CheckSecurityForDeletion()
        SecurityManager.Instance.Check()
    End Sub

    Private Sub SetViewModeForTipo(ByVal IdTipo As Int32)
        Dim list As ArrayList = controller.GetAll
        If IdTipo = -1 Then
            'vado in modalità nuovo tipo pratica nel caso non 
            'posso posizionarmi sul primo record
            If list.Count = 0 Then
                Me.StartCreateOperation()
                LoadGrid(New ArrayList)
            Else
                LoadAll(list)
            End If
        Else
            Me.m_IdShowedObject = IdTipo
            'm_current = controller.GetTipoPraticaById(IdTipo)
            DoLoad()
        End If
    End Sub
    Public Sub LoadAll(ByVal List As ArrayList)
        If List.Count = 0 Then
            Me.StartCreateOperation()
            LoadGrid(controller.GetAll)
            Exit Sub
        End If
        Me.m_IdShowedObject = List.Item(0).Id
        m_current = List.Item(0)
        DoLoad()
    End Sub

    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "" & MyBase.State.StateName & " tipo pratica"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "" & MyBase.State.StateName & " tipi pratica "
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & " tipo pratica")
        SelectToolStripImage()
    End Sub

    Protected Overrides Sub Nested_PostLoadingActions()
        Dim logo As String = "" & MyBase.State.StateName & "  tipo pratica"
        MasterControl.Instance.ParentForm.Text = logo & " " & UCase(m_current.Descrizione)
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo & " " & UCase(m_current.Descrizione)
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  -   tipo pratica   " & UCase(m_current.Descrizione))
    End Sub

    Protected Overrides Sub Nested_PostchangeActions()
        Try
            Dim logo As String = "" & MyBase.State.StateName & "  tipo pratica"
            MasterControl.Instance.ParentForm.Text = logo & " " & UCase(m_current.Descrizione)
            MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo & " " & UCase(m_current.Descrizione)
            Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  -   tipo pratica   " & UCase(m_current.Descrizione))
        Catch ex As Exception
            Nested_NotifyParent()
        End Try

    End Sub

    Public Overrides Sub DoLoad()
        Try
            'If m_SetFirstAivaibleRecord Then
            '   Me.NavigateToNew()
            'Else
            If Me.m_IdShowedObject = -1 Then
                Me.Nested_PrepareForCreation()
            Else
                MyBase.m_IsLoading = True
                Nested_PrepareLoading()
                Nested_ClearWindowEditors()
                Nested_LoadDataFromDataSource()
                Nested_LoadEditorsProperties()
                Nested_PostLoadingActions()
                MyBase.m_IsLoading = False
            End If
            'End If

        Catch ex As Exception
            MyBase.m_IsLoading = False
            Throw
        End Try
    End Sub
    Protected Overrides Sub Nested_PrepareLoading()
        CustomBar1.Visible = True
        Me.CustomBar1.SetTargetControl(Me)

    End Sub


    Protected Overrides Sub Nested_ClearWindowEditors()
        'Qui pulisco tutti i campi della maschera
        Dim controllerUtente As New SecureDataManager
        Dim users As IList(Of IdDescriptionClass) = controllerUtente.GetUsersList()

        users.Insert(0, New IdDescriptionClass)


        LoadComboUser(cbojolly, users)
        LoadComboUser(cbocontrol, users)
        LoadComboUser(cboconfirm, users)
        LoadComboUser(cbointegr, users)
        LoadComboUser(cborig, users)
        LoadComboUser(cbochiusa, users)

       
        chkrestr.Checked = False
        Me.txtId.Text = ""
        Me.txtDescr.Text = ""

    End Sub


    Private Sub LoadComboUser(comboBox As ComboBox, template As IList(Of IdDescriptionClass))
        comboBox.Items.Clear()

        For Each elem As IdDescriptionClass In template
            comboBox.Items.Add(elem)
        Next
        comboBox.SelectedIndex = 0
    End Sub


    Protected Overrides Sub Nested_LoadEditorsProperties()
        Dim controllerUtente As New SecureDataManager
        Dim users As IList(Of IdDescriptionClass) = controllerUtente.GetUsersList()
        Dim nullValue As IdDescriptionClass = New IdDescriptionClass
        users.Insert(0, nullValue)

        LoadComboUser(cbojolly, users)
        LoadComboUser(cbocontrol, users)
        LoadComboUser(cboconfirm, users)

        LoadComboUser(cbointegr, users)
        LoadComboUser(cborig, users)
        LoadComboUser(cbochiusa, users)


       
        chkrestr.Checked = m_current.RestrictedPermissions

        If Not m_current.JollyUser Is Nothing Then
            For Each elem As IdDescriptionClass In users
                If elem.Id = m_current.JollyUser.Id Then
                    cbojolly.SelectedItem = elem
                End If
            Next
        Else
            cbojolly.SelectedItem = nullValue
        End If
        If Not m_current.ControlUser Is Nothing Then
            For Each elem As IdDescriptionClass In users
                If elem.Id = m_current.ControlUser.Id Then
                    cbocontrol.SelectedItem = elem
                End If
            Next
        Else
            cbocontrol.SelectedItem = nullValue
        End If
        If Not m_current.DocumentationVerifiedUser Is Nothing Then
            For Each elem As IdDescriptionClass In users
                If elem.Id = m_current.DocumentationVerifiedUser.Id Then
                    cboconfirm.SelectedItem = elem
                End If
            Next
        Else
            cboconfirm.SelectedItem = nullValue
        End If
        If Not m_current.IntegrationUser Is Nothing Then
            For Each elem As IdDescriptionClass In users
                If elem.Id = m_current.IntegrationUser.Id Then
                    cbointegr.SelectedItem = elem
                End If
            Next
        Else
            cbointegr.SelectedItem = nullValue
        End If
        If Not m_current.RejectedPractice Is Nothing Then
            For Each elem As IdDescriptionClass In users
                If elem.Id = m_current.RejectedPractice.Id Then
                    cborig.SelectedItem = elem
                End If
            Next
        Else
            cborig.SelectedItem = nullValue
        End If
        If Not m_current.ClosedPracticeuser Is Nothing Then
            For Each elem As IdDescriptionClass In users
                If elem.Id = m_current.ClosedPracticeuser.Id Then
                    cbochiusa.SelectedItem = elem
                End If
            Next
        Else
            cbochiusa.SelectedItem = nullValue
        End If


        Me.txtId.Text = m_current.Id
        Me.txtDescr.Text = m_current.Descrizione





        LoadGrid(controller.GetAll)

    End Sub

    Private Sub LoadGrid(ByVal Lista As IList)
        ListBox1.Items.Clear()


        For Each elem As TipoPratica In Lista
            ListBox1.Items.Add(elem)
        Next

    End Sub
  

    Protected Overrides Sub Nested_LoadDataFromDataSource()
        'qui carico ordino il caricamento dei dati e carico le possibili scelte

        m_current = controller.GetTipoPraticaById(Me.m_IdShowedObject)

    End Sub
    Protected Overrides Sub Nested_PrepareForCreation()

        Nested_ClearWindowEditors()
        LoadGrid(controller.GetAll)

    End Sub

    Public Overrides Sub Nested_InsertData()

       


        m_current = New TipoPratica
        m_current.Descrizione = txtDescr.Text
        m_current.RestrictedPermissions = chkrestr.Checked
        If Not String.IsNullOrEmpty(DirectCast(cbojolly.SelectedItem, IdDescriptionClass).Description) Then
            m_current.JollyUser = New SecureDataManager().GetUserById(DirectCast(cbojolly.SelectedItem, IdDescriptionClass).Id)
        End If

        If Not String.IsNullOrEmpty(DirectCast(cbocontrol.SelectedItem, IdDescriptionClass).Description) Then
            m_current.ControlUser = New SecureDataManager().GetUserById(DirectCast(cbocontrol.SelectedItem, IdDescriptionClass).Id)
        End If
        If Not String.IsNullOrEmpty(DirectCast(cboconfirm.SelectedItem, IdDescriptionClass).Description) Then
            m_current.DocumentationVerifiedUser = New SecureDataManager().GetUserById(DirectCast(cboconfirm.SelectedItem, IdDescriptionClass).Id)
        End If
        If Not String.IsNullOrEmpty(DirectCast(cbointegr.SelectedItem, IdDescriptionClass).Description) Then
            m_current.IntegrationUser = New SecureDataManager().GetUserById(DirectCast(cbointegr.SelectedItem, IdDescriptionClass).Id)
        End If
        If Not String.IsNullOrEmpty(DirectCast(cborig.SelectedItem, IdDescriptionClass).Description) Then
            m_current.RejectedPractice = New SecureDataManager().GetUserById(DirectCast(cborig.SelectedItem, IdDescriptionClass).Id)
        End If
        If Not String.IsNullOrEmpty(DirectCast(cbochiusa.SelectedItem, IdDescriptionClass).Description) Then
            m_current.ClosedPracticeuser = New SecureDataManager().GetUserById(DirectCast(cbochiusa.SelectedItem, IdDescriptionClass).Id)
        End If

        controller.SaveOrUpdateTipoPratica(m_current)
        LoadGrid(controller.GetAll)
    End Sub
    Public Overrides Sub Nested_UpdateData()

        m_current.Descrizione = txtDescr.Text
        m_current.RestrictedPermissions = chkrestr.Checked
        If Not String.IsNullOrEmpty(DirectCast(cbojolly.SelectedItem, IdDescriptionClass).Description) Then
            m_current.JollyUser = New SecureDataManager().GetUserById(DirectCast(cbojolly.SelectedItem, IdDescriptionClass).Id)
        Else
            m_current.JollyUser = Nothing
        End If

        If Not String.IsNullOrEmpty(DirectCast(cbocontrol.SelectedItem, IdDescriptionClass).Description) Then
            m_current.ControlUser = New SecureDataManager().GetUserById(DirectCast(cbocontrol.SelectedItem, IdDescriptionClass).Id)
        Else
            m_current.ControlUser = Nothing
        End If
        If Not String.IsNullOrEmpty(DirectCast(cboconfirm.SelectedItem, IdDescriptionClass).Description) Then
            m_current.DocumentationVerifiedUser = New SecureDataManager().GetUserById(DirectCast(cboconfirm.SelectedItem, IdDescriptionClass).Id)
        Else
            m_current.DocumentationVerifiedUser = Nothing
        End If
        If Not String.IsNullOrEmpty(DirectCast(cbointegr.SelectedItem, IdDescriptionClass).Description) Then
            m_current.IntegrationUser = New SecureDataManager().GetUserById(DirectCast(cbointegr.SelectedItem, IdDescriptionClass).Id)
        Else
            m_current.IntegrationUser = Nothing
        End If
        If Not String.IsNullOrEmpty(DirectCast(cborig.SelectedItem, IdDescriptionClass).Description) Then
            m_current.RejectedPractice = New SecureDataManager().GetUserById(DirectCast(cborig.SelectedItem, IdDescriptionClass).Id)
        Else
            m_current.RejectedPractice = Nothing
        End If
        If Not String.IsNullOrEmpty(DirectCast(cbochiusa.SelectedItem, IdDescriptionClass).Description) Then
            m_current.ClosedPracticeuser = New SecureDataManager().GetUserById(DirectCast(cbochiusa.SelectedItem, IdDescriptionClass).Id)
        Else
            m_current.ClosedPracticeuser = Nothing
        End If


        controller.SaveOrUpdateTipoPratica(m_current)
        LoadGrid(controller.GetAll)
    End Sub


    Private Sub CustomBar1_DoEliminaClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoEliminaClick
        Try
            Nested_CheckSecurityForDeletion()
            If MsgBox("Il tipo pratica sarà eliminato solamente se nel sistema non ci sono altri riferimenti al tipo prestazione. Sicuro di voler cancellare il tipo prestazione selezionato? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminazione utente") = MsgBoxResult.Yes Then
                controller.DeletePratica(m_current)
                LoadAll(controller.GetAll)
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


    Private Overloads Sub AddCommandToHistory()
        Dim ParameterList As Hashtable = New Hashtable
        ParameterList.Add("Id", m_IdShowedObject)
        Me.AddCommandToHistory("ViewTipoPratica", ParameterList)
    End Sub
    Protected Overrides Sub Nested_PostCreationActions()
        Me.AddCommandToHistory()
        Me.txtId.Enabled = False
        Me.txtId.Visible = True
        Me.lblId.Visible = True
    End Sub
    Protected Overrides Sub Navigate()

        Dim ParameterList As Hashtable = New Hashtable
        ParameterList.Add("Id", m_IdShowedObject)
        Me.NavigateWithoutHistoryTo("ViewTipoPratica", ParameterList, True)

    End Sub
    Protected Overloads Sub NavigateToNew()

        Me.NavigateWithoutHistoryTo("CreateTipoPratica")

    End Sub



    'Private Sub ListBoxControl1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ListBoxControl1.SelectedValueChanged
    '    SelectTipo()
    'End Sub

    Private Sub SelectTipo()
        Try
            If Me.State.StateName <> "Visualizzazione" Then Exit Sub

            Me.m_IdShowedObject = DirectCast(ListBox1.SelectedItem, TipoPratica).Id
            'Navigate()
            DoLoad()
          
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub CustomBar1_DoAnnullaClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoAnnullaClick
        DoUndo()
    End Sub

    Public Overrides Sub DoUndo()
        Try
            Navigate()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub


    Private Sub CustomBar1_DoNewClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoNewClick
        Try
            'NavigateToNew()
            Me.StartCreateOperation()
        Catch ex As AccessDeniedException
            MsgBox("Impossibile inserire un nuovo elemento. Accesso negato", MsgBoxStyle.Information, "Accesso negato")

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub txtDescr_TextChanged(sender As Object, e As EventArgs) Handles txtDescr.TextChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub chkrestr_CheckedChanged(sender As Object, e As EventArgs) Handles chkrestr.CheckedChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub chkrestr_TextChanged(sender As Object, e As EventArgs) Handles chkrestr.TextChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub cbojolly_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbojolly.SelectedIndexChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub cbocontrol_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbocontrol.SelectedIndexChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub cbointegr_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbointegr.SelectedIndexChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub cboconfirm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboconfirm.SelectedIndexChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub cborig_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cborig.SelectedIndexChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub cbochiusa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbochiusa.SelectedIndexChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        SelectTipo()
    End Sub
End Class
