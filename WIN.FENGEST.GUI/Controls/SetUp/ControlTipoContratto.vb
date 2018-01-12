Imports WIN.SECURITY.Exceptions
Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY
<SecureContext()> _
Public Class ControlTipoContratto
   Private controller As New ControllerTipoContratto
   Private ControllerSettori As New ControllerSettori
   Private m_SetFirstAivaibleRecord As Boolean = False
   'Public ReadOnly Property SetFirstAivaibleRecord() As Boolean
   '   Get
   '      Return m_SetFirstAivaibleRecord
   '   End Get
   'End Property
   ''' <summary>
   ''' Costruttore utilizzato dal comando di creazione di un nuovo contratto
   ''' </summary>
   ''' <remarks></remarks>
   Public Sub New()
      InitializeComponent()

      CustomBar1.SetTargetControl(Me)
      Me.m_IdShowedObject = -1
      DoLoad()

   End Sub
   Private Sub lstCausali_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstContratti.Click
      If lstContratti.SelectedIndex = -1 Then
         Exit Sub
      End If
      Me.m_IdShowedObject = controller.GetIdTipoContrattoByDescrizione(lstContratti.SelectedItem)
   End Sub

   Private Sub CustomBar1_DoInformationClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoInformationClick
      MsgBox(controller.CurrentObjectJournalingData, MsgBoxStyle.Information, "Informazione")
   End Sub

   ''' <summary>
   ''' Costruttore utilizzato dal comado di apertura di un contratto esistente
   ''' </summary>
   ''' <param name="IdTipoContratto"></param>
   ''' <remarks></remarks>
   Public Sub New(ByVal IdTipoContratto As Int32)
      InitializeComponent()
      Try
         CustomBar1.SetTargetControl(Me)
         SetViewModeForContratto(IdTipoContratto)
      Catch ex As Exception
         'ErrorHandler.ShowError(ex)
         Throw New Exception(ex.Message)
      End Try
   End Sub
   Private Sub SetViewModeForContratto(ByVal IdContratto As Int32)
      Dim list As ArrayList = controller.GetListaContratti
      If IdContratto = -1 Then
         'vado in modalità nuovo contratto nel caso non 
         'posso posizionarmi sul primo record
         If list.Count = 0 Then
                Me.StartCreateOperation()
            Else
                LoadAll(list)
            End If
        Else
            Me.m_IdShowedObject = IdContratto
            DoLoad()
        End If
    End Sub
    Public Sub LoadAll(ByVal List As ArrayList)
        If List.Count = 0 Then
            Me.StartCreateOperation()
            Exit Sub
        End If
        Me.m_IdShowedObject = controller.GetIdTipoContrattoByDescrizione(List.Item(0))
        DoLoad()
    End Sub


    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "" & MyBase.State.StateName & " contratto"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "" & MyBase.State.StateName & " tipi contratto "
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & " contratto")
        SelectToolStripImage()
    End Sub

    Protected Overrides Sub Nested_PostLoadingActions()
        Dim logo As String = "" & MyBase.State.StateName & "  contratto"
        MasterControl.Instance.ParentForm.Text = logo & " " & UCase(controller.Descrizione)
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo & " " & UCase(controller.Descrizione)
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  -   contratto   " & UCase(controller.Descrizione))
    End Sub

    Protected Overrides Sub Nested_PostchangeActions()
        Try
            Dim logo As String = "" & MyBase.State.StateName & "  contratto"
            MasterControl.Instance.ParentForm.Text = logo & " " & UCase(controller.Descrizione)
            MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo & " " & UCase(controller.Descrizione)
            Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  -   contratto   " & UCase(controller.Descrizione))
        Catch ex As Exception
            Nested_NotifyParent()
        End Try

    End Sub

#Region "Metodi per Load iniziale"
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
         Throw New Exception(ex.Message)
      End Try
   End Sub
    Protected Overrides Sub Nested_PrepareLoading()
        CustomBar1.Visible = True
        Me.CustomBar1.SetTargetControl(Me)
        InterfaceMediator.LoadListBox(Me.lstContratti, controller.GetListaContratti)
        InterfaceMediator.LoadCombo(cboSettori, ControllerSettori.GetListaSettori, False)
    End Sub
    Protected Overrides Sub Nested_ClearWindowEditors()
        'Qui pulisco tutti i campi della maschera
        txtNome.Text = ""
        cboSettori.SelectedIndex = -1
        dtpNormDa.Value = Today
        dtpNormA.Value = Today
        dtpEcoDa.Value = Today
        dtpEcoA.Value = Today

    End Sub
    Protected Overrides Sub Nested_LoadEditorsProperties()
        txtNome.Text = controller.Descrizione
        cboSettori.Text = controller.DescrizioneSettore
        InterfaceMediator.LoadListBox(Me.lstContratti, controller.GetListaContratti)
        txtId.Text = controller.IdTipoContratto
        dtpNormDa.Value = controller.DataInizioValiditaNormativa
        dtpNormA.Value = controller.DataFineValiditaNormativa

        dtpEcoDa.Value = controller.DataInizioValiditaEconomica
        dtpEcoA.Value = controller.DataFineValiditaEconomica

    End Sub
    Protected Overrides Sub Nested_LoadDataFromDataSource()
        'qui carico ordino il caricamento dei dati e carico le possibili scelte
        Try
            controller.LoadById(Me.m_IdShowedObject)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Protected Overrides Sub Nested_PrepareForCreation()
        Try
            InterfaceMediator.LoadListBox(Me.lstContratti, controller.GetListaContratti)
            InterfaceMediator.LoadCombo(Me.cboSettori, ControllerSettori.GetListaSettori, False)
            Nested_ClearWindowEditors()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
#End Region




    Public Overrides Sub Nested_InsertData()
        Try
            controller.CreateNew()
            controller.Descrizione = txtNome.Text
            controller.SetSettore(ControllerSettori.GetIdSettoreByDescrizione(cboSettori.Text))
            controller.SetValiditaEconomica(dtpEcoDa.Value, dtpEcoA.Value)
            controller.SetValiditaNormativa(dtpNormDa.Value, dtpNormA.Value)
            controller.Save()
            MyBase.m_IdShowedObject = controller.IdTipoContratto
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Public Overrides Sub Nested_UpdateData()
        controller.Descrizione = txtNome.Text
        controller.SetSettore(ControllerSettori.GetIdSettoreByDescrizione(cboSettori.Text))
        controller.SetValiditaEconomica(dtpEcoDa.Value, dtpEcoA.Value)
        controller.SetValiditaNormativa(dtpNormDa.Value, dtpNormA.Value)
        controller.Save()
    End Sub

    Public Overrides Sub StartChangeOperation()
        Try
            MyBase.StartChangeOperation()
        Catch ex As AccessDeniedException
            MsgBox("Impossibile aggiornare l'oggetto. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    <Secure(Area:="Contratti", Alias:="Creazione", Macroarea:="Setup")> _
    Protected Overrides Sub Nested_CheckSecurityForCreation()
        SecurityManager.Instance.Check()
    End Sub

    <Secure(Area:="Contratti", Alias:="Aggiornamento", Macroarea:="Setup")> _
    Protected Overrides Sub Nested_CheckSecurityForChanging()
        SecurityManager.Instance.Check()
    End Sub

    <Secure(Area:="Contratti", Alias:="Cancellazione", Macroarea:="Setup")> _
      Protected Overrides Sub Nested_CheckSecurityForDeletion()
        SecurityManager.Instance.Check()
    End Sub

    Private Sub CustomBar1_DoEliminaClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoEliminaClick
        Try
            Nested_CheckSecurityForDeletion()
            If MsgBox("Il tipo contratto sarà eliminato solamente se nel sistema non ci sono altri riferimenti al al tipo contratto. Sicuro di voler cancellare il tipo contratto selezionato? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminazione utente") = MsgBoxResult.Yes Then
                controller.Delete()
                LoadAll(controller.GetListaContratti)
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





#Region "Metodi per il salvataggio"
    'Private Overloads Sub AddCommandToHistory()
    '   Dim ParameterList As Hashtable = New Hashtable
    '   ParameterList.Add("Id", m_IdShowedObject)
    '   Me.AddCommandToHistory("ViewTipoContratto", ParameterList)
    'End Sub
    'Protected Overrides Sub PostCreationActions()
    '   Me.AddCommandToHistory()
    'End Sub
    Protected Overrides Sub Navigate()
        Try
            Dim ParameterList As Hashtable = New Hashtable
            ParameterList.Add("Id", m_IdShowedObject)
            Me.NavigateWithoutHistoryTo("ViewTipoContratto", ParameterList, True)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Protected Overloads Sub NavigateToNew()

        Me.NavigateWithoutHistoryTo("CreateTipoContratto")

    End Sub

#End Region


    'Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '   Try
    '      NavigateToNew()
    '   Catch ex As Exception
    '      ErrorHandler.ShowError(ex)
    '   End Try
    'End Sub
    Private Sub txtNome_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNome.TextChanged
        Me.StartChangeOperation()
    End Sub
    Private Sub lstContratti_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            If lstContratti.SelectedIndex > -1 Then
                Me.m_IdShowedObject = controller.GetIdTipoContrattoByDescrizione(lstContratti.SelectedItem)
                Navigate()
            Else
                MsgBox("Non è stato selezionato alcun contratto. Selezionare un contratto.", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub CustomBar1_DoAnnullaClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoAnnullaClick
        Try
            Navigate()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    Private Sub CustomBar1_DoNewClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoNewClick
        Try
            NavigateToNew()
        Catch ex As AccessDeniedException
            MsgBox("Impossibile inserire un nuovo elemento. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    Private Sub cboSettori_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSettori.SelectedIndexChanged
        Me.StartChangeOperation()
    End Sub



    Private Sub txtId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtId.TextChanged

    End Sub

    Private Sub dtpEcoA_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpEcoA.ValueChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub dtpEcoDa_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpEcoDa.ValueChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub dtpNormA_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpNormA.ValueChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub dtpNormDa_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpNormDa.ValueChanged
        Me.StartChangeOperation()
    End Sub

   Private Sub CmdSel_DoClik1(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CmdSel.DoClik
      Try
         If lstContratti.SelectedIndex > -1 Then
            Me.m_IdShowedObject = controller.GetIdTipoContrattoByDescrizione(lstContratti.SelectedItem)
            Navigate()
         Else
            MsgBox("Non è stato selezionato alcun contratto. Selezionare un contratto.", MsgBoxStyle.Information)
         End If
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Private Sub CustomBar1_DoStampaClick(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles CustomBar1.DoStampaClick
      Try
         Dim print As PrintFacade = New PrintFacade
         print.PrintListaTipiContratti(controller)
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

   End Sub

   Private Sub GroupBox2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles GroupBox2.Paint

   End Sub
End Class
