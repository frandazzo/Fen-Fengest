Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY
Imports WIN.SECURITY.Exceptions

<SecureContext()> _
Public Class ControlInps
   Private controller As New AZIENDE.ControllerInps
   Public Sub New()
      InitializeComponent()
      Me.m_IdShowedObject = 1
      Try
         DoLoad()
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Private Sub CustomBar1_DoInformationClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoInformationClick
      MsgBox(controller.CurrentObjectJournalingData, MsgBoxStyle.Information, "Informazione")
   End Sub
    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "" & MyBase.State.StateName & " Inps"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "" & MyBase.State.StateName & " Inps "
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  -  " & UCase(controller.Descrizione))
        SelectToolStripImage()
    End Sub

    Protected Overrides Sub Nested_PostLoadingActions()
        Dim logo As String = "" & MyBase.State.StateName
        MasterControl.Instance.ParentForm.Text = logo & " " & UCase(controller.Descrizione)
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo & " " & UCase(controller.Descrizione)
        Me.lblCurrentFunction.Text = UCase(logo & "  -  Inps")

    End Sub

    Protected Overrides Sub Nested_PostchangeActions()
        Dim logo As String = "" & MyBase.State.StateName & " "
        MasterControl.Instance.ParentForm.Text = logo & " " & UCase(controller.Descrizione)
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo & " " & UCase(controller.Descrizione)
        Me.lblCurrentFunction.Text = UCase(logo & " - Inps")
    End Sub




#Region "Metodi per Load iniziale"
    Protected Overrides Sub Nested_PrepareLoading()
        'Me.TabControl1.Visible = True
        MasterControl.Instance.ParentForm.Text = "Visualizzazione anagrafica "
        CustomBar1.Visible = True
        CustomBar1.SetTargetControl(Me)
        CustomBar1.SetStatus(True, CustomBar.ActionType.Nuovo)
        CustomBar1.SetStatus(True, CustomBar.ActionType.Elimina)
    End Sub
    Protected Overrides Sub Nested_ClearWindowEditors()
        'Qui pulisco tutti i campi della maschera
        txtNome.Text = ""
        Me.lblUltimaCompetenza.Text = "Non è stato effettuato alcun pagamento!"
        txtResp.Text = ""
        txtMail.Text = ""
        txtCell1.Text = ""
        txtCell2.Text = ""
        txtFax.Text = ""
        txtTelUf.Text = ""
    End Sub
    Protected Overrides Sub Nested_LoadDataFromDataSource()
        'qui carico ordino il caricamento dei dati e carico le possibili scelte
        controller.LoadById(Me.m_IdShowedObject)
    End Sub
    Protected Overrides Sub Nested_LoadEditorsProperties()
        txtNome.Text = controller.Descrizione
        Me.lblUltimaCompetenza.Text = controller.CompetenzaUltimoPagamento
        Me.txtFax.Text = controller.Fax
        Me.txtCell1.Text = controller.Cellulare1
        Me.txtCell2.Text = controller.Cellulare2
        Me.txtTelUf.Text = controller.TelefonoUfficio
        Me.txtMail.Text = controller.Mail
        Me.txtResp.Text = controller.Responsabile
    End Sub
#End Region



#Region "Metodi per il salvataggio"

   Protected Overrides Sub Navigate()
      Try
         Me.NavigateTo("ViewInps", True)
      Catch ex As Exception
         Throw New Exception(ex.Message)
      End Try
   End Sub

   Protected Overloads Sub Navigate(ByVal ToId As String, ByVal Link As String)
      Try
         Dim ParameterList As Hashtable = New Hashtable
         ParameterList.Add("Id", ToId)
         Me.NavigateTo(Link, ParameterList)
      Catch ex As Exception
         Throw New Exception(ex.Message)
      End Try
   End Sub

#End Region


#Region "Metodi per l'aggiornamneto"
   Private Sub txtNome_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNome.TextChanged
      '
   End Sub
   Private Sub IdContoTextBox1_TextBoxChanged()
        Me.StartChangeOperation()
    End Sub

    Public Overrides Sub Nested_UpdateData()
        'controller.Descrizione = txtNome.Text
        controller.SetComunicazione(Me.txtTelUf.Text, Me.txtFax.Text, Me.txtMail.Text, Me.txtCell1.Text, Me.txtCell2.Text)
        controller.Responsabile = txtResp.Text
        controller.Save()
    End Sub




#End Region

    <Secure(Area:="Inps", Alias:="Aggiornamento", Macroarea:="Anagrafiche")> _
       Protected Overrides Sub Nested_CheckSecurityForChanging()
        SecurityManager.Instance.Check()
    End Sub


    Public Overrides Sub StartChangeOperation()
        Try
            MyBase.StartChangeOperation()
            CustomBar1.SetStatus(True, CustomBar.ActionType.Nuovo)
            CustomBar1.SetStatus(True, CustomBar.ActionType.Elimina)
        Catch ex As AccessDeniedException
            MsgBox("Impossibile aggiornare l'oggetto. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try

    End Sub
    Private Sub CustomBar1_DoAnnullaClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoAnnullaClick
        Try
            Navigate()
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

    Private Sub CustomBar1_DoStampaClick(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles CustomBar1.DoStampaClick
        Try
            Dim print As PrintFacade = New PrintFacade
            print.PrintReportEnti(controller)
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub txtVia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.StartChangeOperation()
    End Sub

    Private Sub txtCap_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.StartChangeOperation()
    End Sub

    Private Sub cboProvincia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.StartChangeOperation()
    End Sub

    Private Sub cboComune_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.StartChangeOperation()
    End Sub

    Private Sub txtResp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtResp.TextChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub txtTelUf_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTelUf.TextChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub txtCell1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCell1.TextChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub txtCell2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCell2.TextChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub txtFax_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFax.TextChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub txtMail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMail.TextChanged
        Me.StartChangeOperation()
    End Sub
End Class
