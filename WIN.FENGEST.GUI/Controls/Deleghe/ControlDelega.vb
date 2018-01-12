Imports WIN.SECURITY.Exceptions
Imports WIN.GUI.UTILITY

Public Class ControlDelega
    Private controller As New ADMINISTRATION.ControllerDeleghe
    Dim controllerEnti As New AZIENDE.ControllerEntiBilaterali
    Dim controllerSettori As New ControllerSettori
    Dim controllerReparti As New WIN.APPLICATION.ControllerReparti
    Dim controllerCausaliSott As New WIN.APPLICATION.ControllerCausaliSottoscrizione
    Private m_IdUtente As Int32 = -1
    Private m_automaticCreation As Boolean = False
    Public Sub New(ByVal IdUtente As Int32)
        InitializeComponent()



        m_IdUtente = IdUtente
        m_automaticCreation = True
        DoLoad()
    End Sub
    Private Sub CustomBar1_DoInformationClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoInformationClick
        MsgBox(controller.CurrentObjectJournalingData, MsgBoxStyle.Information, "Informazione")
    End Sub

    Public Overrides Sub StartChangeOperation()
        Try
            If m_IsLoading Then Return
            If TypeOf (State) Is StView Then
                DelegheMediator.CheckDelegaEditable()
                MyBase.StartChangeOperation()
            End If
        Catch ex As AccessDeniedException
            MsgBox("Impossibile aggiornare l'oggetto. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub
    Public Sub New()
        InitializeComponent()


        DoLoad()

    End Sub
    Public Sub New(ByVal IdDelega As Int32, ByVal IdUtente As Int32)
        InitializeComponent()
        Me.m_IdShowedObject = IdDelega
        m_IdUtente = IdUtente
        If m_IdUtente = -1 Then Throw New Exception("Impossibile creare un controllo delega senza un id utente valido.")

        DoLoad()

    End Sub

#Region "Operazioni di avvio transizioni deleghe"
    Private Sub SpCmdInoltra_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles SpCmdInoltra.DoClik
        Try
            DelegheMediator.CheckDelegaForInoltro()
            Dim frm As New DelegheActions
            If controller.IsSettoreEdile Then
                frm.OpenForInoltro()
            Else
                frm.OpenForAccettazione(controller.IsSettoreEdile)
            End If
            PerformDialog(frm)
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    Private Sub PerformDialog(ByVal frm As DelegheActions)
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then

            If controller.IsSettoreEdile Then
                controller.InoltraDelega(frm.DataInoltro.Date)
                controller.Save()
            Else
                controller.InoltraDelega(frm.DataAccettazione.Date)
                controller.AccettaDelega(frm.DataAccettazione.Date)
                controller.UpdateAllDeleghe()
            End If

            Dim list As New Hashtable
            list.Add("Id", Me.m_IdShowedObject)
            list.Add("IdUtente", m_IdUtente)
            Me.NavigateTo("ViewDelega", list)
            frm.Dispose()
        Else
            frm.Dispose()
        End If
    End Sub
#End Region

#Region "Metodi per Load iniziale"
    Protected Overrides Sub Nested_PrepareLoading()
        Me.MainGroup.Visible = True
        Me.txtIdDelega.Text = ""
        Me.txtIdDelega.Enabled = False
        Me.txtIdDelega.Visible = True
        Me.lblId.Visible = True
        MasterControl.Instance.ParentForm.Text = "Visualizzazione delega"
        Me.IdUtenteTextBox1.Enabled = False
        Me.IdUtenteTextBox1.EnableSerchTextBox = False
        Me.cboSettori.Enabled = False
        CustomBar1.SetTargetControl(Me)
        InterfaceMediator.LoadCombo(Me.cboSettori, controllerSettori.GetListaSettori, False)
        InterfaceMediator.LoadCombo(Me.cboCausaliSott, controllerCausaliSott.GetListaCausali, False)
        InterfaceMediator.LoadCombo(Me.cboReparto, controllerReparti.GetListaCausali, True)
        SetUpCombo(Me.cboEnti, controllerEnti.GetListaEnti)
        Me.SpCmdRevoca.Disabled = False
        Me.SpCmdInoltra.Disabled = False
        SpAnnulla.Visible = True
        SpAnnulla.Disabled = False
        chkDuplica.Visible = False
    End Sub
    Private Sub cboSettori_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSettori.SelectedIndexChanged
        SetVisualizzazioneDelega()
    End Sub
    Protected Overrides Sub Nested_ClearWindowEditors()
        'Qui pulisco tutti i campi della maschera
        dtpData.Value = Today
        dtpDoc.Value = Today
        txtNote.Text = ""
        Me.txtIdDelega.Text = ""
        Me.IdUtenteTextBox1.TextValue = ""
        Me.IdReferenteTextBox1.TextValue = ""
        Me.IdAziendaTextBox1.TextValue = ""
        Me.lblDescrizioneAzienda.Text = ""
        Me.lblDescrizioneReferente.Text = ""
        Me.lblDescrizioneUtente.Text = ""
        Me.cboSettori.Text = "IMPIANTI FISSI"
        Me.cboReparto.Text = ""
        lblEnte.Visible = False
        cboEnti.Visible = False
    End Sub
    Protected Overrides Sub Nested_LoadDataFromDataSource()
        'qui carico ordino il caricamento dei dati e carico le possibili scelte
        controller.LoadById(m_IdUtente, Me.m_IdShowedObject)
    End Sub
    Protected Overrides Sub Nested_LoadEditorsProperties()
        Dim Canceled As Boolean = False
        If Me.IsLoading = False Then
            Canceled = True
            MyBase.m_IsLoading = True
        End If

        dtpData.Value = controller.DataRegistrazione
        dtpDoc.Value = controller.DataDocumento
        txtNote.Text = controller.Note
        Me.txtIdDelega.Text = controller.IdDelega
        Me.cboCausaliSott.Text = controller.CausaleSottoscrizione
        Me.cboReparto.Text = controller.Reparto
        Me.IdUtenteTextBox1.TextValue = controller.IdUtente
        Me.IdReferenteTextBox1.TextValue = controller.IdReferente
        Me.IdAziendaTextBox1.TextValue = controller.IdEnteInoltro
        Me.lblDescrizioneAzienda.Text = controller.DescrizioneEnteInoltro
        Me.lblDescrizioneReferente.Text = controller.DescrizioneReferente
        Me.lblDescrizioneUtente.Text = controller.DescrizioneUtente
        Me.cboSettori.Text = controllerSettori.GetDescrizioneSettoreById(controller.IdSettore)
        If controller.IsSettoreEdile Then
            lblEnte.Visible = True
            cboEnti.Text = controller.DescrizioneEnteInoltro
            'If controller.InoltrataEntrambiEntiBilaterali Then
            '   cboEnti.Text = "ENTRAMBI"
            'Else
            '   cboEnti.Text = controller.DescrizioneEnteInoltro1
            'End If
        Else

            IdAziendaTextBox1.TextValue = controller.IdEnteInoltro
            lblDescrizioneAzienda.Text = controller.DescrizioneEnteInoltro
            If lblDescrizioneAzienda.Text <> "" Then
                InterfaceMediator.LoadCombo(cboSede, controller.ListaSediOperative(Me.IdAziendaTextBox1.TextValue), True)
            End If
            cboSede.Text = controller.DescrizioneSedeOprativa

        End If
        Me.IdReferenteTextBox2.TextValue = controller.IdResponsabile
        lblDescrizioneResponsabile.Text = controller.DescrizioneResponsabile
        SetVisualizzazioneDelega()
        If Canceled = True Then
            MyBase.m_IsLoading = False
        End If
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
        'Label2.Visible = False
        Me.txtIdDelega.Enabled = False
        Me.txtIdDelega.Visible = False
        Me.lblId.Visible = False
        SpCmdInoltra.Visible = False
        SpCmdRevoca.Visible = False
        SpAnnulla.Visible = False
        'lblInoltra.Visible = False
        'lblRevoca.Visible = False
        CustomBar1.SetTargetControl(Me)
        InterfaceMediator.LoadCombo(Me.cboSettori, controllerSettori.GetListaSettori, False)
        InterfaceMediator.LoadCombo(Me.cboCausaliSott, controllerCausaliSott.GetListaCausali, False)
        InterfaceMediator.LoadCombo(Me.cboReparto, controllerReparti.GetListaCausali, True)
        SetUpCombo(Me.cboEnti, controllerEnti.GetListaEnti)
        Me.cboCausaliSott.Text = "NUOVA ISCRIZIONE"
        If m_automaticCreation Then
            Me.m_automaticCreation = False
            Me.IdUtenteTextBox1.TextValue = m_IdUtente
            InterfaceMediator.GetSimpleDescription(New UTENTI.ControllerUtenti, "CompleteName", Me.lblDescrizioneUtente, m_IdUtente)
        End If
        chkDuplica.Visible = True
    End Sub
    Private Sub SetVisualizzazioneDelega()
        lblAzienda.Visible = False
        lblDescrizioneAzienda.Visible = False
        IdAziendaTextBox1.Visible = False
        lblEnte.Visible = False
        cboEnti.Visible = False

        If controllerSettori.IsSettoreEdile(cboSettori.Text) Then
            lblEnte.Visible = True
            cboEnti.Visible = True
            lblReparto.Visible = False
            cboReparto.Visible = False
            cboSede.Visible = False
            lblSedeOperativa.Visible = False

            If Me.State.StateName = "Creazione" Then
                chkDuplica.Visible = True
            Else
                chkDuplica.Visible = False
            End If


        Else
            lblAzienda.Visible = True
            lblDescrizioneAzienda.Visible = True
            IdAziendaTextBox1.Visible = True
            lblReparto.Visible = True
            cboReparto.Visible = True
            cboSede.Visible = True
            lblSedeOperativa.Visible = True
            chkDuplica.Visible = False
        End If
    End Sub
#End Region


#Region "Metodi per il salvataggio"
    Public Overrides Sub Nested_InsertData()

        Dim idEn As String = "-1"
        Dim idSett As String = controllerSettori.GetIdSettoreByDescrizione(Me.cboSettori.Text)
        controllerSettori.LoadById(idSett)
        idEn = controllerEnti.GetIdEnteByDescrizione(Me.cboEnti.Text)
        controllerEnti.LoadById(idEn)


        If controllerSettori.IsSettoreEdile(Me.cboSettori.Text) Then

            If chkDuplica.Checked Then
                controller.CreateNew(dtpData.Value, dtpData.Value, txtNote.Text, _
                                              Me.IdUtenteTextBox1.TextValue, _
                                              Me.IdReferenteTextBox1.TextValue, _
                                              GetOtherIdEnte(idEn), _
                                              controllerSettori.GetIdSettoreByDescrizione(Me.cboSettori.Text), -1, controllerCausaliSott.GetIdByDescrizione(Me.cboCausaliSott.Text), Me.IdReferenteTextBox2.TextValue, "")

            End If
            controller.CreateNew(dtpData.Value, dtpData.Value, txtNote.Text, _
                                Me.IdUtenteTextBox1.TextValue, _
                                Me.IdReferenteTextBox1.TextValue, _
                               idEn, _
                                controllerSettori.GetIdSettoreByDescrizione(Me.cboSettori.Text), -1, controllerCausaliSott.GetIdByDescrizione(Me.cboCausaliSott.Text), Me.IdReferenteTextBox2.TextValue, "")


        Else
            controller.CreateNew(dtpData.Value, dtpData.Value, txtNote.Text, _
                                 Me.IdUtenteTextBox1.TextValue, _
                                 Me.IdReferenteTextBox1.TextValue, _
                                 Me.IdAziendaTextBox1.TextValue, _
                                 controllerSettori.GetIdSettoreByDescrizione(Me.cboSettori.Text), controllerReparti.GetIdByDescrizione(Me.cboReparto.Text), controllerCausaliSott.GetIdByDescrizione(Me.cboCausaliSott.Text), Me.IdReferenteTextBox2.TextValue, cboSede.Text)
        End If
        MyBase.m_IdShowedObject = controller.IdDelega
        m_IdUtente = Me.IdUtenteTextBox1.TextValue

    End Sub
#End Region


    Private Function GetOtherIdEnte(ByVal idEnte As Int32) As Int32
        If idEnte = 1 Then Return 2
        If idEnte = 2 Then Return 1
        Throw (New InvalidProgramException("Identificativo ente sconosciuto"))
    End Function


#Region "Metodi per l'aggiornamento"
    Private Sub IdReferenteTextBox1_TextBoxChanged() Handles IdReferenteTextBox1.TextBoxChanged
        Me.StartChangeOperation()
    End Sub
    Private Sub IdAziendaTextBox1_TextBoxChanged() Handles IdAziendaTextBox1.TextBoxChanged
        Me.StartChangeOperation()
    End Sub
    Public Overrides Sub Nested_UpdateData()

        controller.DataRegistrazione = dtpData.Value.Date
        controller.DataDocumento = dtpDoc.Value.Date
        controller.Note = txtNote.Text
        If controller.IsSettoreEdile Then
            controller.SetEnteBiletraleInoltro(controllerEnti.GetIdEnteByDescrizione(cboEnti.Text))
            'If cboEnti.Text = "ENTRAMBI" Then
            '   controller.SetEnteBiletraleInoltro(-1, True)
            'Else
            '   controller.SetEnteBiletraleInoltro(controllerEnti.GetIdEnteByDescrizione(cboEnti.Text))
            'End If
        Else
            controller.SetAziendaInoltro(Me.IdAziendaTextBox1.TextValue)
            controller.SetSedeOperativa(cboSede.Text)
        End If

        controller.SetCausaleSottoscrizione(controllerCausaliSott.GetIdByDescrizione(Me.cboCausaliSott.Text))
        controller.SetReparto(controllerReparti.GetIdByDescrizione(Me.cboReparto.Text))
        controller.SetReferente(Me.IdReferenteTextBox1.TextValue)
        controller.SetResponsabile(Me.IdReferenteTextBox2.TextValue)
        controller.Save()
    End Sub
    'Public Overrides Sub ReLoadProperties()
    '   '
    'End Sub
    Private Sub dtpData_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpData.ValueChanged
        Me.StartChangeOperation()
    End Sub
    Private Sub dtpDoc_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpDoc.ValueChanged
        Me.StartChangeOperation()
    End Sub
    Private Sub cboEnti_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboEnti.SelectedIndexChanged
        If m_IsLoading Then Return
        Me.StartChangeOperation()

        If Me.State.StateName = "Creazione" Then
            chkDuplica.Visible = True
            If cboEnti.Text = "CASSA EDILE" Then
                chkDuplica.Text = "Duplica delega per Edilcassa"
            Else
                chkDuplica.Text = "Duplica delega per Cassa Edile"
            End If
        End If


    End Sub
    Private Sub txtNote_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNote.TextChanged
        Me.StartChangeOperation()
    End Sub
    Public Overrides Sub Nested_PrepareForUpdate()
        MyBase.Nested_PrepareForUpdate()
        Me.SpCmdRevoca.Disabled = True
        Me.SpCmdInoltra.Disabled = True
        Me.SpAnnulla.Disabled = True
    End Sub
#End Region


#Region "Metodi rifattorizzati"

#Region "Metodi CRUD custom bar"

    Private Sub CustomBar1_DoSaveClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoSaveClick
        Try
            If TypeOf (Me.State) Is StCreation Then
                DelegheMediator.Save(Me)
                Navigate()
            Else
                DelegheMediator.Save(Me)
                'Me.ReLoadProperties()
                SpCmdInoltra.Disabled = False
                SpAnnulla.Disabled = False
                SpCmdRevoca.Disabled = False
            End If
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try

    End Sub
    Private Sub CustomBar1_DoEliminaClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoEliminaClick
        DelegheMediator.Delete(Me, controller, "La delega sarà eliminata solamente se nel sistema non ci sono altri riferimenti alla delega. Sicuro di voler cancellare la delega corrente? ")
    End Sub
    Private Sub CustomBar1_DoNewClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoNewClick
        Try
            DelegheMediator.NewDelega(Me)
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try

    End Sub


    Private Sub CustomBar1_DoStampaClick(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles CustomBar1.DoStampaClick

        DoPrint()

    End Sub

    Private Sub CustomBar1_DoAnnullaClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoAnnullaClick
        DoUndo()
    End Sub



    Protected Overrides Sub DoPrint()
        Try
            Dim print As PrintFacade = New PrintFacade
            print.PrintDelega(controller)
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub


    Public Overrides Sub DoUndo()
        DelegheMediator.Annulla(Me, m_IdUtente, m_IdShowedObject, "Sottoscritta")
    End Sub




    Protected Overrides Sub Navigate()
        Try
            DelegheMediator.Navigate(Me, m_IdUtente, m_IdShowedObject, "Sottoscritta")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub
    Protected Overloads Sub Navigate(ByVal ToId As String, ByVal Link As String)
        Try
            DelegheMediator.Navigate(Me, ToId, Link)
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub
#End Region



#Region "Metodo per riempire e gestire le combobox"
    Private Sub SetUpCombo(ByVal Combo As System.Windows.Forms.ComboBox, ByVal Lista As Hashtable)
        DelegheMediator.SetUpCombo(Combo, Lista)
    End Sub
#End Region


#Region "Metodi di notifica"
    Public Overrides Sub Nested_NotifyParent()
        DelegheMediator.NotifyParent(Me)
    End Sub
    Protected Overrides Sub Nested_PostLoadingActions()
        DelegheMediator.PostLoadingActions(Me, controller)
        If controller.IsSettoreEdile Then
            'Me.lblInoltra.Text = "Inoltra delega"
            Me.SpCmdInoltra.TooltipText = "Inoltra delega"
        Else
            'Me.lblInoltra.Text = "Accetta delega"
            Me.SpCmdInoltra.TooltipText = "Accetta delega"
        End If



    End Sub
    Protected Overrides Sub Nested_PostchangeActions()
        DelegheMediator.PostchangeActions(Me, controller)
    End Sub
#End Region

#Region "Metodi per la revoca della delega"
    Private Sub SpCmdRevoca_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles SpCmdRevoca.DoClik
        DelegheMediator.RevocaDelega(Me, controller, Me.m_IdShowedObject, m_IdUtente)
    End Sub
    Private Sub SpAnnulla_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles SpAnnulla.DoClik
        DelegheMediator.AnnullaDelega(Me, controller, Me.m_IdShowedObject, m_IdUtente)
    End Sub

#End Region


#Region "Metodi per la ricerca delle  descrizioni"
    Private Sub IdAziendaTextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles IdAziendaTextBox1.Leave
        DelegheMediator.GetSimpleDescription(New WIN.APPLICATION.AZIENDE.ControllerAziende, "Descrizione", lblDescrizioneAzienda, Me.IdAziendaTextBox1.TextValue)
        If lblDescrizioneAzienda.Text <> "" Then
            InterfaceMediator.LoadCombo(cboSede, controller.ListaSediOperative(Me.IdAziendaTextBox1.TextValue), True)
        Else
            cboSede.Items.Clear()
        End If
    End Sub

    Private Sub IdReferenteTextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles IdReferenteTextBox1.Leave
        DelegheMediator.GetSimpleDescription(New WIN.APPLICATION.FINANCIAL_ARTIFACTS.ControllerReferenti, "CompleteName", lblDescrizioneReferente, Me.IdReferenteTextBox1.TextValue)
    End Sub

    Private Sub IdUtenteTextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles IdUtenteTextBox1.Leave
        DelegheMediator.GetSimpleDescription(New WIN.APPLICATION.UTENTI.ControllerUtenti, "CompleteName", lblDescrizioneUtente, Me.IdUtenteTextBox1.TextValue)
    End Sub
#End Region

#Region "Metodi per la navigazione "
    Private Sub lblUtente_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblUtente.Click
        Try
            Navigate(Me.IdUtenteTextBox1.TextValue, "ViewUtente")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    Private Sub lblReferente_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblReferente.DoubleClick
        Try
            Navigate(Me.IdReferenteTextBox1.TextValue, "ViewReferente")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    Private Sub lblAzienda_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblAzienda.DoubleClick
        Try
            Navigate(Me.IdAziendaTextBox1.TextValue, "ViewAzienda")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    Private Sub lblEnte_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblEnte.DoubleClick
        Try
            DelegheMediator.NavigateToEnte(Me, cboEnti.Text)
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub
#End Region

#End Region





    Private Sub cboReparto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboReparto.SelectedIndexChanged

        Me.StartChangeOperation()
    End Sub

    Private Sub cboCausaliSott_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCausaliSott.SelectedIndexChanged

        Me.StartChangeOperation()
    End Sub

    Private Sub lblResponsabile_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblResponsabile.DoubleClick

        Try
            Navigate(Me.IdReferenteTextBox2.TextValue, "ViewReferente")
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try

    End Sub


    Private Sub lblResponsabile_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblResponsabile.Leave
        DelegheMediator.GetSimpleDescription(New WIN.APPLICATION.FINANCIAL_ARTIFACTS.ControllerReferenti, "CompleteName", lblDescrizioneResponsabile, Me.IdReferenteTextBox2.TextValue)
    End Sub


    Private Sub IdReferenteTextBox2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles IdReferenteTextBox2.Leave
        DelegheMediator.GetSimpleDescription(New WIN.APPLICATION.FINANCIAL_ARTIFACTS.ControllerReferenti, "CompleteName", lblDescrizioneResponsabile, Me.IdReferenteTextBox2.TextValue)
    End Sub

    Private Sub IdReferenteTextBox2_TextBoxChanged() Handles IdReferenteTextBox2.TextBoxChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub cboSede_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSede.SelectedIndexChanged
        Me.StartChangeOperation()
    End Sub


    Private Sub NiceGroupBox1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles NiceGroupBox1.Paint

    End Sub
End Class
