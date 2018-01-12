
Imports WIN.GUI.PRINT
Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY
Imports WIN.SECURITY.Exceptions

<SecureContext()> _
Public Class ControlAnagraficaReferente
   Private controller As New FINANCIAL_ARTIFACTS.ControllerReferenti

   Private Sub CustomBar1_DoInformationClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoInformationClick
      MsgBox(controller.CurrentObjectJournalingData, MsgBoxStyle.Information, "Informazione")
   End Sub

    <Secure(Area:="Referenti", Alias:="Creazione", Macroarea:="Anagrafiche")> _
  Protected Overrides Sub Nested_CheckSecurityForCreation()
        SecurityManager.Instance.Check()
    End Sub

    <Secure(Area:="Referenti", Alias:="Aggiornamento", Macroarea:="Anagrafiche")> _
    Protected Overrides Sub Nested_CheckSecurityForChanging()
        SecurityManager.Instance.Check()
    End Sub

    <Secure(Area:="Referenti", Alias:="Cancellazione", Macroarea:="Anagrafiche")> _
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


    Public Sub New()
        InitializeComponent()
        Try
            DoLoad()
        Catch ex As Exception
            'ErrorHandler.ShowError(ex)
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Public Sub New(ByVal IdReferente As Int32)
        InitializeComponent()
        Me.m_IdShowedObject = IdReferente
        Try
            DoLoad()
        Catch ex As Exception
            'ErrorHandler.ShowError(ex)
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "" & MyBase.State.StateName & "  collaboratore comunale"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "" & MyBase.State.StateName & "  utente "
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & " collaboratore comunale")
        SelectToolStripImage()
    End Sub
    Protected Overrides Sub Nested_PostLoadingActions()
        Dim logo As String = "" & MyBase.State.StateName & "  collaboratore comunale"
        MasterControl.Instance.ParentForm.Text = logo & " " & UCase(controller.CompleteName)
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo & " " & UCase(controller.CompleteName)
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  -  " & UCase(controller.CompleteName))

    End Sub
    Protected Overrides Sub Nested_PostchangeActions()
        Try
            Dim logo As String = "" & MyBase.State.StateName & "  collaboratore comunale"
            MasterControl.Instance.ParentForm.Text = logo & " " & UCase(controller.CompleteName)
            MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo & " " & UCase(controller.CompleteName)
            Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  -  " & UCase(controller.CompleteName))
        Catch ex As Exception
            Nested_NotifyParent()
        End Try

    End Sub



#Region "Metodi per la ricerca"
    Public Overrides Sub DoSearch()

        Me.grpAnag.Visible = False
        ' Me.GrpRist.Visible = False
        Me.IdReferenteTextBox1.TextValue = ""
        Me.IdReferenteTextBox1.Visible = True
        Me.IdReferenteTextBox1.Enabled = True
        Me.lblId.Visible = True
        MasterControl.Instance.ParentForm.Text = "Ricerca collaboratore comunale"
        Me.lblCurrentFunction.Text = UCase("Ricerca collaboratore comunale")
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Ricerca collaboratore comunale"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.SearchPaint
        ' Me.CmdVis.Visible = True
        CustomBar1.Visible = False
        SpNew.Visible = True
    End Sub
#End Region

#Region "Metodi per Load iniziale"
    Protected Overrides Sub Nested_PrepareLoading()
        Me.grpAnag.Visible = True
        'Me.GrpRist.Visible = True
        Me.IdReferenteTextBox1.TextValue = ""
        Me.IdReferenteTextBox1.Enabled = False
        Me.IdReferenteTextBox1.Visible = True
        Me.lblId.Visible = True
        MasterControl.Instance.ParentForm.Text = "Visualizzazione collaboratore comunale"
        '   Me.CmdVis.Visible = False
        CustomBar1.SetTargetControl(Me)
        CustomBar1.Visible = True
        SpNew.Visible = False
        LoadDefaultData()
    End Sub
    Protected Overrides Sub Nested_ClearWindowEditors()
        'Qui pulisco tutti i campi della maschera
        txtNome.Text = ""
        txtCognome.Text = ""
        Me.IdReferenteTextBox1.TextValue = ""
        Me.chkCom.Checked = False
        Me.txtPrd.Text = "0,0"
        Me.txtPrdIf.Text = "0,0"
        Me.txtPrdIn.Text = "0,0"
        Me.txtPrdVe.Text = "0,0"
        Me.txtUltimoRistorno.Text = ""
        txtResp.Text = ""
        txtMail.Text = ""
        txtCell1.Text = ""
        txtCell2.Text = ""
        txtFax.Text = ""
        txtTelUf.Text = ""
        CheckBox1.Checked = False
        txtVia.Text = ""
        cboProvincia.Text = ""
        cboComune.Text = ""
        txtCap.Text = ""
    End Sub

    Private Sub LoadDefaultData()
        InterfaceMediator.LoadCombo(Me.cboProvincia, GeoLocationFacade.Instance.GetListaProvincie, True)
        Me.cboProvincia.Text = My.Settings.ProvinciaDefault
        InterfaceMediator.LoadCombo(Me.cboComune, GeoLocationFacade.Instance.GetListaComuniPerProvincia("MATERA"), True)
        Me.cboComune.Text = My.Settings.ComuneDefault
    End Sub
    Protected Overrides Sub Nested_LoadDataFromDataSource()
        'qui carico ordino il caricamento dei dati e carico le possibili scelte
        controller.LoadById(Me.m_IdShowedObject)
    End Sub
    Protected Overrides Sub Nested_LoadEditorsProperties()
        txtNome.Text = controller.Nome
        txtCognome.Text = controller.Cognome
        Me.IdReferenteTextBox1.TextValue = controller.IdReferente
        Me.txtPrd.Text = controller.PercRistornoDeleghe
        Me.chkCom.Checked = controller.ComponenteStruttura
        Me.txtUltimoRistorno.Text = controller.IdUltimoRistorno
        Me.txtPrdIf.Text = controller.PercRistornoDelegheImpFissi
        Me.txtPrdIn.Text = controller.PercRistornoDelegheInps
        Me.txtPrdVe.Text = controller.PercRistornoDelegheVertenza
        txtVia.Text = controller.ViaLegale
        cboProvincia.Text = controller.ProvinciaLegale
        cboComune.Text = controller.ComuneLegale
        'txtCartella.Text = controller.DirectoryPreferenziale
        CheckBox1.Checked = controller.IsCameraComunale
        Me.txtFax.Text = controller.Fax
        Me.txtCell1.Text = controller.Cellulare1
        Me.txtCell2.Text = controller.Cellulare2
        Me.txtTelUf.Text = controller.TelefonoUfficio
        Me.txtMail.Text = controller.Mail
        Me.txtResp.Text = controller.Responsabile
    End Sub
#End Region


#Region "Metodi per la creazione di un nuovo oggetto"
    Protected Overrides Sub Nested_PrepareForCreation()
        Me.IdReferenteTextBox1.Enabled = False
        Me.IdReferenteTextBox1.Visible = False
        Me.lblId.Visible = False
        Me.grpAnag.Visible = True
        ' Me.GrpRist.Visible = True
        ' Me.CmdVis.Visible = False
        Me.chkCom.Checked = False
        Me.txtPrd.Text = "0,0"
        Me.txtPrdIf.Text = "0,0"
        Me.txtPrdIn.Text = "0,0"
        Me.txtPrdVe.Text = "0,0"
        CustomBar1.Visible = True
        CustomBar1.SetTargetControl(Me)
        SpNew.Visible = False
        LoadDefaultData()
    End Sub

#Region "Metodi per il salvataggio"
    Private Overloads Sub AddCommandToHistory()
        Dim ParameterList As Hashtable = New Hashtable
        ParameterList.Add("Id", m_IdShowedObject)
        Me.AddCommandToHistory("ViewReferente", ParameterList)
    End Sub
    Protected Overrides Sub Nested_PostCreationActions()
        Me.AddCommandToHistory()
        Me.IdReferenteTextBox1.Enabled = False
        Me.IdReferenteTextBox1.Visible = True
        Me.lblId.Visible = True
        SpNew.Visible = False
    End Sub
    Protected Overrides Sub Navigate()
        Try
            Dim ParameterList As Hashtable = New Hashtable
            ParameterList.Add("Id", m_IdShowedObject)
            Me.NavigateWithoutHistoryTo("ViewReferente", ParameterList, True)
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub
    Protected Overloads Sub Navigate(ByVal ToId As Int32)
        Try
            Dim ParameterList As Hashtable = New Hashtable
            ParameterList.Add("Id", ToId)
            Me.NavigateTo("ViewReferente", ParameterList, True)
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub
    Public Overrides Sub Nested_InsertData()

        controller.CreateNew(txtNome.Text, txtCognome.Text)
        controller.ComponenteStruttura = Me.chkCom.Checked
        controller.PercRistornoDeleghe = Me.txtPrd.Text
        controller.PercRistornoDelegheImpFissi = Me.txtPrdIf.Text
        controller.PercRistornoDelegheInps = Me.txtPrdIn.Text
        controller.PercRistornoDelegheVertenza = Me.txtPrdVe.Text
        controller.SetIndirizzoSedeLegale(txtVia.Text, cboProvincia.Text, cboComune.Text)
        controller.SetComunicazione(Me.txtTelUf.Text, Me.txtFax.Text, Me.txtMail.Text, Me.txtCell1.Text, Me.txtCell2.Text)
        controller.Responsabile = txtResp.Text
        controller.IsCameraComunale = CheckBox1.Checked
        controller.Save()
        MyBase.m_IdShowedObject = controller.IdReferente

    End Sub

#End Region
#End Region

    Private Sub View()
        Try
            Navigate(Me.IdReferenteTextBox1.TextValue)
        Catch ex As Exception
            If TypeOf (ex) Is InvalidCastException Then
                ex = New Exception("L'id di ricerca non ha un formato valido oppure è nullo. Inserire un id corretto")
            End If
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub cmdVis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        View()
    End Sub


#Region "Metodi per l'aggiornamento dell'oggetto"

    Private Sub txtNome_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNome.TextChanged
        Me.StartChangeOperation()
    End Sub
    Private Sub txtCognome_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCognome.TextChanged
        Me.StartChangeOperation()
    End Sub
    Public Overrides Sub Nested_UpdateData()

        controller.Nome = txtNome.Text
        controller.Cognome = txtCognome.Text
        controller.ComponenteStruttura = Me.chkCom.Checked
        controller.PercRistornoDeleghe = Me.txtPrd.Text
        controller.PercRistornoDelegheImpFissi = Me.txtPrdIf.Text
        controller.PercRistornoDelegheInps = Me.txtPrdIn.Text
        controller.PercRistornoDelegheVertenza = Me.txtPrdVe.Text
        controller.SetIndirizzoSedeLegale(txtVia.Text, cboProvincia.Text, cboComune.Text)
        controller.SetComunicazione(Me.txtTelUf.Text, Me.txtFax.Text, Me.txtMail.Text, Me.txtCell1.Text, Me.txtCell2.Text)
        controller.Responsabile = txtResp.Text
        controller.IsCameraComunale = CheckBox1.Checked
        controller.Save()

    End Sub
    Private Sub chkCom_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCom.CheckedChanged
        Me.StartChangeOperation()
    End Sub


    Private Sub IdContoTextBox1_TextBoxChanged()
        Me.StartChangeOperation()
    End Sub

    Private Sub txtPrd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrd.TextChanged
        Me.StartChangeOperation()
    End Sub
#End Region




    Protected Overloads Sub Navigate(ByVal ToId As String, ByVal Link As String)
        Try
            Dim ParameterList As Hashtable = New Hashtable
            ParameterList.Add("Id", ToId)
            ParameterList.Add("TipoDocumento", "PGR")
            Me.NavigateTo(Link, ParameterList)
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    Private Sub lblUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblUltimo.Click
        Try
            Navigate(Me.txtUltimoRistorno.Text, "ViewDocumento")
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub txtPrdIf_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrdIf.TextChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub txtPrdIn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrdIn.TextChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub txtPrdVe_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPrdVe.TextChanged
        Me.StartChangeOperation()
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
                Me.StartUndoOperation()
            End If
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Protected Overrides Sub DoPrint()
        Try

            Dim print As PrintFacade = New PrintFacade
            print.PrintReferente(controller)

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub




    Private Sub CustomBar1_DoEliminaClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoEliminaClick
        Try
            Nested_CheckSecurityForDeletion()
            If MsgBox("Il collaboratore comunale sarà eliminato solamente se nel sistema non ci sono altri riferimenti al collaboratore comunale. Sicuro di voler cancellare il collaboratore comunale selezionato? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminazione utente") = MsgBoxResult.Yes Then
                controller.Delete()
                Navigate(-1)
            End If
        Catch ex As AccessDeniedException
            MsgBox("Impossibile eliminare l'elemento. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub CustomBar1_DoNewClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoNewClick
        Createnew()

    End Sub

    Private Sub Createnew()
        Try
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

    Private Sub SpNew_DoClik(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles SpNew.DoClik
        Createnew()

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub txtVia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVia.TextChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub cboProvincia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProvincia.SelectedIndexChanged
        Me.StartChangeOperation()
        InterfaceMediator.LoadCombo(Me.cboComune, GeoLocationFacade.Instance.GetListaComuniPerProvincia(Me.cboProvincia.Text), True)
        cboComune.SelectedIndex = 0
    End Sub

    Private Sub cboComune_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboComune.SelectedIndexChanged
        Me.StartChangeOperation()
        Me.txtCap.Text = GeoLocationFacade.Instance.GetCapForComune(Me.cboComune.Text)
    End Sub

    Private Sub txtCap_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCap.TextChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub txtResp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtResp.TextChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub txtTelUf_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTelUf.TextChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub txtFax_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFax.TextChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub txtMail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMail.TextChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub txtCell1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCell1.TextChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub txtCell2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCell2.TextChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub IdReferenteTextBox1_ReturnPressed() Handles IdReferenteTextBox1.ReturnPressed
        View()
    End Sub
End Class


