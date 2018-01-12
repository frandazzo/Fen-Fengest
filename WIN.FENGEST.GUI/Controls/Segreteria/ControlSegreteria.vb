Imports System.Windows.Forms
Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY
Imports WIN.SECURITY.Exceptions

<SecureContext()> _
Public Class ControlSegreteria
    Private controller As New ControllerSegreteria


    Public Sub New()
        InitializeComponent()
        Me.m_IdShowedObject = 1


        DoLoad()

    End Sub


    Public Overrides Sub StartChangeOperation()
        Try
            MyBase.StartChangeOperation()
        Catch ex As AccessDeniedException
            MsgBox("Impossibile aggiornare l'oggetto. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub





    <Secure(Area:="Segreteria", Alias:="Aggiornamento", Macroarea:="Anagrafiche")> _
    Protected Overrides Sub Nested_CheckSecurityForChanging()
        SecurityManager.Instance.Check()
    End Sub







    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "" & MyBase.State.StateName & " segreteria"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "" & MyBase.State.StateName & " segreteria "
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & " segreteria")
        SelectToolStripImage()
    End Sub

    Protected Overrides Sub Nested_PostLoadingActions()
        Dim logo As String = "" & MyBase.State.StateName & "  segreteria"
        MasterControl.Instance.ParentForm.Text = logo & " " & UCase(controller.Descrizione)
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo & " " & UCase(controller.Descrizione)
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  -  " & UCase(controller.Descrizione))
    End Sub

    Protected Overrides Sub Nested_PostchangeActions()
        Try
            Dim logo As String = "" & MyBase.State.StateName & "  segreteria"
            MasterControl.Instance.ParentForm.Text = logo & " " & UCase(controller.Descrizione)
            MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo & " " & UCase(controller.Descrizione)
            Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  -  " & UCase(controller.Descrizione))

        Catch ex As Exception
            Nested_NotifyParent()
        End Try
    End Sub



#Region "Metodi per Load iniziale"
    Protected Overrides Sub Nested_PrepareLoading()
        grpRag.Visible = True
        'grpContatti.Visible = True

        MasterControl.Instance.ParentForm.Text = "Visualizzazione segreteria"

        CustomBar1.Visible = True
        Me.CustomBar1.SetTargetControl(Me)
        CustomBar1.SetStatus(True, CustomBar.ActionType.Nuovo)
        CustomBar1.SetStatus(True, CustomBar.ActionType.Elimina)
        LoadDefaultData()
    End Sub


    Protected Overrides Sub Nested_PostUpdateActions()
        CustomBar1.SetStatus(True, CustomBar.ActionType.Nuovo)
        CustomBar1.SetStatus(True, CustomBar.ActionType.Elimina)
        CustomBar1.SetStatus(True, CustomBar.ActionType.Stampa)

    End Sub

    Protected Overrides Sub Nested_ClearWindowEditors()
        'Qui pulisco tutti i campi della maschera
        txtVia.Text = ""
        cboProvincia.Text = ""
        cboComune.Text = ""
        txtNome.Text = ""

        txtPIva.Text = ""

        txtResp.Text = ""
        txtMail.Text = ""
        txtCell1.Text = ""
        txtCell2.Text = ""
        txtFax.Text = ""
        txtTelUf.Text = ""
        txtWeb.Text = ""


    End Sub
    Protected Overrides Sub Nested_LoadDataFromDataSource()
        'qui carico ordino il caricamento dei dati e carico le possibili scelte
        controller.LoadById(Me.m_IdShowedObject)
    End Sub
    Protected Overrides Sub Nested_LoadEditorsProperties()
        txtNome.Text = controller.Descrizione
        txtPIva.Text = controller.PartitaIva
        txtVia.Text = controller.ViaLegale
        cboProvincia.Text = controller.ProvinciaLegale
        cboComune.Text = controller.ComuneLegale
        txtCartella.Text = controller.DirectoryPreferenziale
        txtWeb.Text = controller.IndirizzoWEB
        txtUser.Text = controller.Current.UtenteNazionale
        txtPassword.Text = controller.Current.PasswordNazionale

        Me.txtFax.Text = controller.Fax
        Me.txtCell1.Text = controller.Cellulare1
        Me.txtCell2.Text = controller.Cellulare2
        Me.txtTelUf.Text = controller.TelefonoUfficio
        Me.txtMail.Text = controller.Mail
        Me.txtResp.Text = controller.Responsabile

        txtTitoloPagina.Text = controller.Intestazione
        txtSottotitolo1.Text = controller.Sottotitolo1
        txtSottotitolo2.Text = controller.Sottotitolo2
        txtSottotitolo3.Text = controller.Sottotitolo3

        txtCartellaUtenti.Text = controller.DirectoryPreferenzialeUtenti
        txtCartellaAziende.Text = controller.DirectoryPreferenzialeAziende
        txtModelli.Text = controller.CartellaModelli
        txtEtichette.Text = controller.CartellaEtichette


    End Sub





#End Region


#Region "Metodi per la creazione di un nuovo oggetto"
    Protected Overrides Sub Nested_PrepareForCreation()

    End Sub
#End Region




#Region "Metodi per il salvataggio"
    Private Overloads Sub AddCommandToHistory()
        Dim ParameterList As Hashtable = New Hashtable
        ParameterList.Add("Id", m_IdShowedObject)
        Me.AddCommandToHistory("ViewSegreteria", ParameterList)
    End Sub

    Protected Overrides Sub Navigate()
        Try
            Dim ParameterList As Hashtable = New Hashtable
            ParameterList.Add("Id", m_IdShowedObject)
            Me.NavigateWithoutHistoryTo("ViewSegreteria", ParameterList, True)
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



    End Sub
#End Region

#Region "Metodi per l'aggiornamneto"

    Public Overrides Sub Nested_UpdateData()
        controller.Descrizione = txtNome.Text

        controller.PartitaIva = Me.txtPIva.Text
        controller.DirectoryPreferenziale = txtCartella.Text
        controller.DirectoryPreferenzialeUtenti = txtCartellaUtenti.Text
        controller.DirectoryPreferenzialeAziende = txtCartellaAziende.Text
        controller.SetIndirizzoSedeLegale(txtVia.Text, cboProvincia.Text, cboComune.Text, txtWeb.Text)
        controller.SetComunicazione(Me.txtTelUf.Text, Me.txtFax.Text, Me.txtMail.Text, Me.txtCell1.Text, Me.txtCell2.Text)
        controller.Sottotitolo1 = txtSottotitolo1.Text
        controller.Sottotitolo2 = txtSottotitolo2.Text
        controller.Sottotitolo3 = txtSottotitolo3.Text
        controller.Intestazione = txtTitoloPagina.Text
        controller.CartellaModelli = txtModelli.Text
        controller.CartellaEtichette = txtEtichette.Text
        controller.Current.PasswordNazionale = txtPassword.Text
        controller.Current.UtenteNazionale = txtUser.Text

        controller.Responsabile = txtResp.Text


        controller.Save()
    End Sub

#End Region















    Private Sub CustomBar1_DoAnnullaClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoAnnullaClick
        DoUndo()
    End Sub

    Public Overrides Sub DoUndo()
        Try

            'Me.Cancel()
            Navigate()


        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub






    Private Sub CustomBar1_DoEliminaClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoEliminaClick

    End Sub

    Private Sub CustomBar1_DoInformationClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoInformationClick
        MsgBox(controller.CurrentObjectJournalingData, MsgBoxStyle.Information, "Informazione")
    End Sub
    Private Sub CustomBar1_DoNewClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoNewClick

    End Sub
    Private Sub CustomBar1_DoSaveClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoSaveClick
        Try
            StartSaveOperation()
            Nested_PostUpdateActions()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
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
























    Private Sub SpView_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs)
        Try
            If txtCartella.Text <> "" Then
                Dim process As New Process
                Dim info As New ProcessStartInfo
                info.FileName = txtCartella.Text
                Diagnostics.Process.Start(info)
                process.Dispose()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SpAddFile_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs)
        If Me.txtCartella.Text <> "" Then
            Dim frm As New FrmSpostaFile
            frm.Destination = txtCartella.Text
            frm.ShowDialog()
            frm.Dispose()
        Else
            MsgBox("Non è stata impostata alcuna cartella", MsgBoxStyle.Information, "Informazione")
        End If
    End Sub



    Private Sub spDelPath_DoClik(ByVal Sender As System.Object, ByVal e As System.EventArgs)
        txtCartella.Text = ""

    End Sub


    Private Sub txtCap_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCap.TextChanged
        StartChangeOperation()
    End Sub

    Private Sub txtVia_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtVia.TextChanged
        StartChangeOperation()
    End Sub

    Private Sub txtNome_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNome.TextChanged
        StartChangeOperation()
    End Sub

    Private Sub txtPIva_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPIva.TextChanged
        StartChangeOperation()
    End Sub

    Private Sub txtCartella_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCartella.TextChanged
        StartChangeOperation()
    End Sub

    Private Sub txtTelUf_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTelUf.TextChanged
        StartChangeOperation()
    End Sub

    Private Sub txtCell1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCell1.TextChanged
        StartChangeOperation()
    End Sub

    Private Sub txtFax_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFax.TextChanged
        StartChangeOperation()
    End Sub

    Private Sub txtCell2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCell2.TextChanged
        StartChangeOperation()
    End Sub

    Private Sub txtResp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtResp.TextChanged
        StartChangeOperation()
    End Sub

    Private Sub txtMail_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMail.TextChanged
        StartChangeOperation()
    End Sub

    Private Sub txtWeb_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtWeb.TextChanged
        StartChangeOperation()
    End Sub

    Private Sub cmdSeleziona_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSeleziona.Click
        If My.Settings.PathDefaultCartelleAziende <> "" Then
            FolderBrowserDialog1.SelectedPath = My.Settings.PathDefaultCartelleAziende
        End If
        If FolderBrowserDialog1.ShowDialog() = DialogResult.Cancel Then
            Return
        End If

        txtCartella.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub txtTitoloPagina_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTitoloPagina.TextChanged
        StartChangeOperation()

    End Sub

    Private Sub txtSottotitolo1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSottotitolo1.TextChanged
        StartChangeOperation()
    End Sub

    Private Sub txtSottotitolo2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSottotitolo2.TextChanged
        StartChangeOperation()
    End Sub

    Private Sub txtSottotitolo3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSottotitolo3.TextChanged
        StartChangeOperation()
    End Sub

    Private Sub txtCartellaUtenti_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCartellaUtenti.TextChanged
        StartChangeOperation()
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCartellaAziende.TextChanged
        StartChangeOperation()
    End Sub

    Private Sub cmdSelezionaCartellaUtenti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSelezionaCartellaUtenti.Click
        If My.Settings.PathDefaultCartelleUtenti <> "" Then
            FolderBrowserDialog1.SelectedPath = My.Settings.PathDefaultCartelleUtenti
        End If
        If FolderBrowserDialog1.ShowDialog() = DialogResult.Cancel Then
            Return
        End If

        txtCartellaUtenti.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub cmdSelezionaCartellaAziende_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSelezionaCartellaAziende.Click
        If My.Settings.PathDefaultCartelleAziende <> "" Then
            FolderBrowserDialog1.SelectedPath = My.Settings.PathDefaultCartelleAziende
        End If
        If FolderBrowserDialog1.ShowDialog() = DialogResult.Cancel Then
            Return
        End If

        txtCartellaAziende.Text = FolderBrowserDialog1.SelectedPath
    End Sub


    Public Sub OpenArchivio()
        Try
            controller.LoadByIdReloadingCache(Me.m_IdShowedObject)
            Dim frm As New FrmArchivioDocumentale(New ControllerArchivioDocumentale(controller.Current), FrmArchivioDocumentale.TypeOfTargetArchivio.Segreteria)

            frm.ShowDialog()

            frm.Dispose()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub



    Private Sub spArchivio1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles spArchivio1.Click
        OpenArchivio()
    End Sub

    Private Sub spDoc1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles spDoc1.Click
        Try
            ' NavigateTo("ViewCompilazioneModelli")
            Dim frm As New FrmCompilazioneModello()
            frm.Show()
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        Catch ex1 As Exception
            ErrorHandler.ShowError(ex1)
        End Try
    End Sub

    Private Sub spIscritti1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles spIscritti1.Click
        If Me.State.StateName = "Aggiornamento" Then
            Return
        End If
        Try
            Me.NavigateTo("ViewDocumento")
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If FolderBrowserDialog1.ShowDialog() = DialogResult.Cancel Then
            Return
        End If

        txtModelli.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If FolderBrowserDialog1.ShowDialog() = DialogResult.Cancel Then
            Return
        End If

        txtEtichette.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub txtModelli_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtModelli.TextChanged
        StartChangeOperation()
    End Sub

    Private Sub txtEtichette_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEtichette.TextChanged
        StartChangeOperation()
    End Sub

    Private Sub txtUser_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUser.TextChanged
        StartChangeOperation()
    End Sub

    Private Sub txtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPassword.TextChanged
        StartChangeOperation()
    End Sub
End Class
