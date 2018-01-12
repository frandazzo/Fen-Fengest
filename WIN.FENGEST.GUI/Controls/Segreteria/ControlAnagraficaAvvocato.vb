Imports System.Windows.Forms
Imports WIN.GUI.PRINT
Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY
Imports WIN.SECURITY.Exceptions

<SecureContext()> _
Public Class ControlAnagraficaAvvocato
   Private controller As New ControllerAvvocati
   

  
   Private Sub CustomBar1_DoInformationClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoInformationClick
      MsgBox(controller.CurrentObjectJournalingData, MsgBoxStyle.Information, "Informazione")
   End Sub

    Public Overrides Sub StartChangeOperation()
        Try
            MyBase.StartChangeOperation()
        Catch ex As AccessDeniedException
            MsgBox("Impossibile aggiornare l'oggetto. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    <Secure(Area:="Collaboratori", Alias:="Creazione", Macroarea:="Avvocati")> _
    Protected Overrides Sub Nested_CheckSecurityForCreation()
        SecurityManager.Instance.Check()
    End Sub

    <Secure(Area:="Collaboratori", Alias:="Aggiornamento", Macroarea:="Avvocati")> _
    Protected Overrides Sub Nested_CheckSecurityForChanging()
        SecurityManager.Instance.Check()
    End Sub



    <Secure(Area:="Collaboratori", Alias:="Cancellazione", Macroarea:="Avvocati")> _
      Protected Overrides Sub Nested_CheckSecurityForDeletion()
        SecurityManager.Instance.Check()
    End Sub



    Public Sub New()
        InitializeComponent()
        Try
            DoLoad()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    Public Sub New(ByVal IdAz As Int32)
        InitializeComponent()
        Me.m_IdShowedObject = IdAz

        DoLoad()

    End Sub
    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "" & MyBase.State.StateName & " avvocato"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "" & MyBase.State.StateName & " avvocato "
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & " avvocato")
        SelectToolStripImage()
    End Sub

    Protected Overrides Sub Nested_PostLoadingActions()
        Dim logo As String = "" & MyBase.State.StateName & "  avvocato"
        MasterControl.Instance.ParentForm.Text = logo & " " & UCase(controller.Descrizione)
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo & " " & UCase(controller.Descrizione)
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  -  " & UCase(controller.Descrizione))
    End Sub

    Protected Overrides Sub Nested_PostchangeActions()
        Try
            Dim logo As String = "" & MyBase.State.StateName & "  avvocato"
            MasterControl.Instance.ParentForm.Text = logo & " " & UCase(controller.Descrizione)
            MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo & " " & UCase(controller.Descrizione)
            Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  -  " & UCase(controller.Descrizione))

            SpNew.Visible = False

        Catch ex As Exception
            Nested_NotifyParent()
        End Try
    End Sub

#Region "Metodi per la ricerca"
    Public Overrides Sub DoSearch()

        grpRag.Visible = False


        Me.IdAvvocatoTextbox1.TextValue = ""
        Me.IdAvvocatoTextbox1.Visible = True
        Me.IdAvvocatoTextbox1.Enabled = True
        Me.lblId.Visible = True
        CustomBar1.Visible = False
        MasterControl.Instance.ParentForm.Text = "Ricerca avvocato"
        Me.lblCurrentFunction.Text = UCase("Ricerca avvocato ")
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Ricerca avvocato"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.SearchPaint
        ' Me.PictureBox1.Visible = True


        Me.BackColor = Color.Transparent
        SpNew.Visible = True

    End Sub
#End Region

#Region "Metodi per Load iniziale"
    Protected Overrides Sub Nested_PrepareLoading()
        grpRag.Visible = True

        Me.IdAvvocatoTextbox1.TextValue = ""
        Me.IdAvvocatoTextbox1.Enabled = False

        Me.IdAvvocatoTextbox1.Visible = True
        Me.lblId.Visible = True
        MasterControl.Instance.ParentForm.Text = "Visualizzazione Avvocato"
        '  Me.PictureBox1.Visible = False
        CustomBar1.Visible = True
        Me.CustomBar1.SetTargetControl(Me)


        LoadDefaultData()
        SpNew.Visible = False
    End Sub

    Protected Overrides Sub Nested_ClearWindowEditors()
        'Qui pulisco tutti i campi della maschera
        txtVia.Text = ""
        cboProvincia.Text = ""
        cboComune.Text = ""
        txtNome.Text = ""
        'txtCartella.Text = ""
        txtPIva.Text = ""

        txtResp.Text = ""
        txtMail.Text = ""
        txtCell1.Text = ""
        txtCell2.Text = ""
        txtFax.Text = ""
        txtTelUf.Text = ""



        Me.IdAvvocatoTextbox1.TextValue = ""

    End Sub
    Protected Overrides Sub Nested_LoadDataFromDataSource()
        'qui carico ordino il caricamento dei dati e carico le possibili scelte

        controller.LoadById(Me.m_IdShowedObject)

    End Sub
    Protected Overrides Sub Nested_LoadEditorsProperties()
        txtNome.Text = controller.Descrizione
        Me.IdAvvocatoTextbox1.TextValue = controller.Id

        txtPIva.Text = controller.PartitaIva



        txtVia.Text = controller.ViaLegale
        cboProvincia.Text = controller.ProvinciaLegale
        cboComune.Text = controller.ComuneLegale
        'txtCartella.Text = controller.DirectoryPreferenziale


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
        Me.IdAvvocatoTextbox1.Enabled = False
        Me.IdAvvocatoTextbox1.Visible = False
        SpNew.Visible = False
        Me.lblId.Visible = False
        grpRag.Visible = True
        ' Me.PictureBox1.Visible = False
        Me.CustomBar1.SetTargetControl(Me)
        CustomBar1.Visible = True
        LoadDefaultData()
        controller.CreateNew()
        'SpAddFile.Disabled = True
        'SpCreateDir.Disabled = True
    End Sub
#End Region




#Region "Metodi per il salvataggio"
    Private Overloads Sub AddCommandToHistory()
        Dim ParameterList As Hashtable = New Hashtable
        ParameterList.Add("Id", m_IdShowedObject)
        Me.AddCommandToHistory("ViewAvvocato", ParameterList)
    End Sub
    Protected Overrides Sub Nested_PostCreationActions()
        Me.AddCommandToHistory()
        Me.IdAvvocatoTextbox1.Enabled = False
        Me.IdAvvocatoTextbox1.Visible = True
        Me.lblId.Visible = True

        SpNew.Visible = False

    End Sub


    Protected Overrides Sub Navigate()
        Try
            Dim ParameterList As Hashtable = New Hashtable
            ParameterList.Add("Id", m_IdShowedObject)
            Me.NavigateWithoutHistoryTo("ViewAvvocato", ParameterList, True)
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub



    Protected Overloads Sub Navigate(ByVal ToId As String, Optional ByVal ClearCache As Boolean = False)
        Try
            Dim ParameterList As Hashtable = New Hashtable
            ParameterList.Add("Id", ToId)
            Me.NavigateTo("ViewAvvocato", ParameterList, True)
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

        controller.Descrizione = txtNome.Text
        controller.PartitaIva = Me.txtPIva.Text


        controller.SetIndirizzoSedeLegale(txtVia.Text, cboProvincia.Text, cboComune.Text)
        controller.SetComunicazione(Me.txtTelUf.Text, Me.txtFax.Text, Me.txtMail.Text, Me.txtCell1.Text, Me.txtCell2.Text)
        controller.Responsabile = txtResp.Text
        controller.Save()
        MyBase.m_IdShowedObject = controller.Id

    End Sub
#End Region

#Region "Metodi per l'aggiornamneto"
    Private Sub txtNome_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNome.TextChanged
        Me.StartChangeOperation()
    End Sub
    Private Sub IdContoTextBox1_TextBoxChanged()
        Me.StartChangeOperation()
    End Sub

    Private Sub txtScarto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.StartChangeOperation()
    End Sub
    Private Sub txtScarto_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.StartChangeOperation()
    End Sub
    Public Overrides Sub Nested_UpdateData()
        controller.Descrizione = txtNome.Text

        controller.PartitaIva = Me.txtPIva.Text


        controller.SetIndirizzoSedeLegale(txtVia.Text, cboProvincia.Text, cboComune.Text)
        controller.SetComunicazione(Me.txtTelUf.Text, Me.txtFax.Text, Me.txtMail.Text, Me.txtCell1.Text, Me.txtCell2.Text)
        controller.Responsabile = txtResp.Text





        controller.Save()
    End Sub

#End Region











    Private Sub CmdVis_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs)
        Try
            Navigate(Me.IdAvvocatoTextbox1.TextValue)
        Catch ex As Exception
            If TypeOf (ex) Is InvalidCastException Then
                ex = New Exception("L'id di ricerca non ha un formato valido oppure è nullo. Inserire un id corretto")
            End If
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
                'Me.Cancel()
                Navigate(Me.IdAvvocatoTextbox1.TextValue, True)
            End If
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Protected Overrides Sub DoPrint()
        Try
            MsgBox("Stampa non disponibile", MsgBoxStyle.Information, "Messaggio")
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub




    Private Sub CustomBar1_DoEliminaClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoEliminaClick
        Try
            Nested_CheckSecurityForDeletion()
            If MsgBox("L'azienda sarà eliminata solamente se nel sistema non ci sono altri riferimenti all'azienda. Sicuro di voler cancellare l'azienda selezionata? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminazione utente") = MsgBoxResult.Yes Then
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







    Private Sub txtVia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVia.TextChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub txtCap_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCap.TextChanged
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
    Private Sub LoadDefaultData()
        InterfaceMediator.LoadCombo(Me.cboProvincia, GeoLocationFacade.Instance.GetListaProvincie, True)
        Me.cboProvincia.Text = My.Settings.ProvinciaDefault
        InterfaceMediator.LoadCombo(Me.cboComune, GeoLocationFacade.Instance.GetListaComuniPerProvincia("MATERA"), True)
        Me.cboComune.Text = My.Settings.ComuneDefault
    End Sub

    Private Sub txtPIva_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPIva.TextChanged
        Me.StartChangeOperation()
    End Sub
    Private Sub view()
        Try
            Navigate(Me.IdAvvocatoTextbox1.TextValue)
        Catch ex As Exception
            If TypeOf (ex) Is InvalidCastException Then
                ex = New Exception("L'id di ricerca non ha un formato valido oppure è nullo. Inserire un id corretto")
            End If
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub PictureBox1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        view()

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

    Private Sub txtFax_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFax.TextChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub txtMail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMail.TextChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub txtCell2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCell2.TextChanged
        Me.StartChangeOperation()
    End Sub

   Private Sub spArchivio_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs)
      Try
         controller.LoadByIdReloadingCache(Me.m_IdShowedObject)
         Dim frm As New FrmArchivioDocumentale(New ControllerArchivioDocumentale(controller.Current), FrmArchivioDocumentale.TypeOfTargetArchivio.Aziende)

         frm.ShowDialog()

         frm.Dispose()
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Private Sub SpNew_DoClik(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles SpNew.DoClik
      Createnew()
   End Sub

   Private Sub spDoc_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs)
      Try
         NavigateTo("ViewCompilazioneModelli")
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

    Private Sub IdAvvocatoTextbox1_ReturnPressed() Handles IdAvvocatoTextbox1.ReturnPressed
        view()
    End Sub
End Class

