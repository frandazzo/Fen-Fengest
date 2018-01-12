Imports WIN.SECURITY.Exceptions

Public Class ControlDelegaRevocata
   Private controller As New ADMINISTRATION.ControllerDeleghe
   Dim controllerEnti As New AZIENDE.ControllerEntiBilaterali
   Dim controllerSettori As New ControllerSettori
   Dim controllerCausali As New ControllerCausaliRevoca
   Private m_IdUtente As Int32 = -1

   Public Sub New(ByVal IdDelega As Int32, ByVal IdUtente As Int32)
      InitializeComponent()
      Me.m_IdShowedObject = IdDelega
      m_IdUtente = IdUtente
      If m_IdUtente = -1 Then Throw New Exception("Impossibile creare un controllo delega senza un id utente valido.")

      DoLoad()

   End Sub
   Private Sub CustomBar1_DoInformationClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoInformationClick
      MsgBox(controller.CurrentObjectJournalingData, MsgBoxStyle.Information, "Informazione")
   End Sub

    Public Overrides Sub StartChangeOperation()
        Try
            If m_IsLoading Then Return
            DelegheMediator.CheckDelegaEditable()
            MyBase.StartChangeOperation()
        Catch ex As AccessDeniedException
            MsgBox("Impossibile aggiornare l'oggetto. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

#Region "Metodi per Load iniziale"
    Protected Overrides Sub Nested_PrepareLoading()
        Me.MainGroup.Visible = True
        Me.txtIdDelega.Text = ""
        Me.txtIdDelega.Enabled = False
        Me.txtIdDelega.Visible = True
        Me.lblId.Visible = True
        MasterControl.Instance.ParentForm.Text = "Visualizzazione delega revocata"
        Me.IdUtenteTextBox1.Enabled = False
        Me.IdAziendaTextBox1.Enabled = False
        Me.IdAziendaTextBox1.EnableSerchTextBox = False
        Me.IdUtenteTextBox1.EnableSerchTextBox = False
        Me.IdReferenteTextBox1.Enabled = False
        Me.IdReferenteTextBox1.EnableSerchTextBox = False
        Me.cboSettori.Enabled = False
        Me.cboEnti.Enabled = False
        Me.dtpDoc.Enabled = False
        Me.dtpData.Enabled = True
        Me.txtStato.Enabled = False
        InterfaceMediator.LoadCombo(Me.cboSettori, controllerSettori.GetListaSettori, False)
        SetUpCombo(Me.cboEnti, controllerEnti.GetListaEnti)
        InterfaceMediator.LoadCombo(Me.cboCausali, controllerCausali.GetListaCausali, True)
        CustomBar1.SetTargetControl(Me)
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
        Me.cboSettori.Text = ""
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
        dtpData.Value = controller.DataRevoca
        dtpDoc.Value = controller.DataDocumento
        dtpReg.Value = controller.DataRegistrazione
        txtNote.Text = controller.Note
        Me.txtIdDelega.Text = controller.IdDelega
        Me.IdUtenteTextBox1.TextValue = controller.IdUtente
        Me.IdReferenteTextBox1.TextValue = controller.IdReferente
        Me.IdAziendaTextBox1.TextValue = controller.IdEnteInoltro
        Me.lblDescrizioneAzienda.Text = controller.DescrizioneEnteInoltro
        Me.lblDescrizioneReferente.Text = controller.DescrizioneReferente
        Me.lblDescrizioneUtente.Text = controller.DescrizioneUtente
        Me.cboSettori.Text = controllerSettori.GetDescrizioneSettoreById(controller.IdSettore)
        If controller.IsSettoreEdile Then
            lblEnte.Visible = True
            'If controller.InoltrataEntrambiEntiBilaterali Then
            '   cboEnti.Text = "ENTRAMBI"
            'Else
            cboEnti.Text = controller.DescrizioneEnteInoltro
            'End If
        Else
            IdAziendaTextBox1.TextValue = controller.IdEnteInoltro
            lblDescrizioneAzienda.Text = controller.DescrizioneEnteInoltro
            If lblDescrizioneAzienda.Text <> "" Then
                InterfaceMediator.LoadCombo(cboSede, controller.ListaSediOperative(Me.IdAziendaTextBox1.TextValue), True)
            End If
            cboSede.Text = controller.DescrizioneSedeOprativa
            'Me.lblDescrizioneAziendaAcc.Text = controller.DescrizioneEnteAccettante1
            'Me.IdAziendaTextBox2.TextValue = controller.IdEnteAccettante
        End If
        Me.IdReferenteTextBox2.TextValue = controller.IdResponsabile
        lblDescrizioneResponsabile.Text = controller.DescrizioneResponsabile
        Me.txtStato.Text = controller.StatoPrecedente
        cboCausali.Text = controller.DescrizioneCausaleFineCiclo
        If controller.IsPeriodoValiditaEmpty Then
            txtValidita.Text = "-"
        Else
            txtValidita.Text = controller.PeriodoValidita
        End If
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
                Me.Nested_PrepareForCreation()
            Else
                MyBase.m_IsLoading = True
                Nested_PrepareLoading()
                Nested_ClearWindowEditors()
                Nested_LoadDataFromDataSource()
                Nested_LoadEditorsProperties()
                Me.Nested_PostLoadingActions()
                MyBase.m_IsLoading = False
            End If
        Catch ex As Exception
            MyBase.m_IsLoading = False
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Private Sub SetVisualizzazioneDelega()
        Dim con As New ControllerSettori
        lblAzienda.Visible = False
        lblDescrizioneAzienda.Visible = False
        IdAziendaTextBox1.Visible = False
        lblEnte.Visible = False
        cboEnti.Visible = False

        If con.IsSettoreEdile(cboSettori.Text) Then
            lblEnte.Visible = True
            cboEnti.Visible = True
            cboSede.Visible = False
            lblSedeOperativa.Visible = False
        Else
            lblAzienda.Visible = True
            lblDescrizioneAzienda.Visible = True
            IdAziendaTextBox1.Visible = True
            cboSede.Visible = True
            lblSedeOperativa.Visible = True
        End If
    End Sub
#End Region


#Region "Metodi per l'aggiornamento"

    Private Sub txtNote_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNote.TextChanged
        Me.StartChangeOperation()
    End Sub
    Public Overrides Sub Nested_UpdateData()
        controller.Note = txtNote.Text
        controller.SetCausaleFineCiclo(controllerCausali.GetIdByDescrizione(cboCausali.Text))
        controller.DataRevoca = Me.dtpData.Value
        controller.Save()
    End Sub
    Public Overrides Sub Nested_PrepareForUpdate()
        MyBase.Nested_PrepareForUpdate()
        Me.SpRipristina.Disabled = True
        Me.SpVisDett.Disabled = True
    End Sub
    Private Sub cboCausali_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboCausali.SelectedIndexChanged
        Me.StartChangeOperation()
    End Sub
    Private Sub dtpData_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpData.ValueChanged
        Me.StartChangeOperation()
    End Sub

#End Region



#Region "Metodi rifattorizzati"

#Region "Metodi CRUD custom bar"

   Private Sub CustomBar1_DoSaveClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoSaveClick
      DelegheMediator.Save(Me)
        Me.Nested_ReLoadProperties()
      SpRipristina.Disabled = False
      SpVisDett.Disabled = False
   End Sub
   Private Sub CustomBar1_DoEliminaClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoEliminaClick
      DelegheMediator.Delete(Me, controller, "La delega sarà eliminata solamente se nel sistema non ci sono altri riferimenti alla delega. Sicuro di voler cancellare la delega corrente? ")
   End Sub
   Private Sub CustomBar1_DoNewClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoNewClick
      DelegheMediator.NewDelega(Me)
   End Sub

   Protected Overrides Sub Navigate()
      Try
         DelegheMediator.Navigate(Me, m_IdUtente, m_IdShowedObject, controller.StatusDelega)
      Catch ex As AccessDeniedException
         MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")

      End Try
   End Sub
   Protected Overloads Sub Navigate(ByVal ToId As String, ByVal Link As String)
      DelegheMediator.Navigate(Me, ToId, Link)
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
    End Sub
    Protected Overrides Sub Nested_PostchangeActions()
        DelegheMediator.PostchangeActions(Me, controller)
    End Sub
#End Region

#Region "Metodi per la revoca della delega"
   'Private Sub SpCmdRevoca_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles SpCmdRevoca.DoClik
   '   DelegheMediator.RevocaDelega(Me, controller, Me.m_IdShowedObject, m_IdUtente)
   'End Sub
   Private Sub SpRipristina_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles SpRipristina.DoClik
      DelegheMediator.Ripristina(Me, controller, Me.m_IdShowedObject, Me.m_IdUtente)
   End Sub
   Private Sub SpVisDett_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles SpVisDett.DoClik
      DelegheMediator.OpenDetail(controller)
   End Sub
#End Region

#Region "Metodi per la ricerca delle  descrizioni"
   Private Sub IdAziendaTextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles IdAziendaTextBox1.Leave
      DelegheMediator.GetSimpleDescription(New WIN.APPLICATION.AZIENDE.ControllerAziende, "Descrizione", lblDescrizioneAzienda, Me.IdAziendaTextBox1.TextValue)
   End Sub
   Private Sub IdReferenteTextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles IdReferenteTextBox1.Leave
      DelegheMediator.GetSimpleDescription(New WIN.APPLICATION.FINANCIAL_ARTIFACTS.ControllerReferenti, "CompleteName", lblDescrizioneReferente, Me.IdReferenteTextBox1.TextValue)
   End Sub
   Private Sub IdUtenteTextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles IdUtenteTextBox1.Leave
      DelegheMediator.GetSimpleDescription(New WIN.APPLICATION.UTENTI.ControllerUtenti, "CompleteName", lblDescrizioneUtente, Me.IdUtenteTextBox1.TextValue)
   End Sub
#End Region

#Region "Metodi per la navigazione "

   'Private Sub lblAziendaAccettante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAziendaAccettante.Click
   '   Try
   '      Navigate(Me.IdAziendaTextBox2.TextValue, "ViewAzienda")
   '   Catch ex As Exception
   '      ErrorHandler.ShowError(ex)
   '   End Try
   'End Sub
   Private Sub lblUtente_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblUtente.DoubleClick
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
   'Private Sub lblEnteAccettante_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblEnteAccettante.DoubleClick
   '   DelegheMediator.NavigateToEnte(Me, Me.cboEntiAccettanti.Text)
   'End Sub
#End Region

#End Region









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
        DelegheMediator.Annulla(Me, m_IdUtente, m_IdShowedObject, controller.StatusDelega)
    End Sub

   Private Sub lblDescrizioneAzienda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDescrizioneAzienda.Click

   End Sub

   Private Sub lblResponsabile_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblResponsabile.DoubleClick
      Try
         Navigate(Me.IdReferenteTextBox2.TextValue, "ViewReferente")
      Catch ex As AccessDeniedException
         MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")

      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Private Sub DockPanel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles DockPanel.Paint

   End Sub
End Class
