Imports WIN.APPLICATION.FINANCIAL_ARTIFACTS
Public Class ControlItemContabile
   Private controller As FINANCIAL_ARTIFACTS.AbstractDocumentController
   Public DataInizioCompetenza As Date = DateTime.MinValue
   Public DataFineCompetenza As Date = DateTime.MinValue
   Private m_IdPosizione As Int32 = -1
   Public Sub SetController(ByVal ExtController As Object)

        controller = DirectCast(ExtController, FINANCIAL_ARTIFACTS.AbstractDocumentController)
        Me.m_IdShowedObject = 0

    End Sub
   Public Sub New()

      ' Chiamata richiesta da Progettazione Windows Form.
      InitializeComponent()

      ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

   End Sub
   Public Sub SetDocumentData(ByVal IdDocumento As String, ByVal IdPosizione As String, ByVal TipoDocumento As String)
      Me.m_IdShowedObject = 0
      controller = ApplicationController.GetDocumentController(TipoDocumento)
      controller.LoadById(IdDocumento)
      controller.SelectItemByIds(IdDocumento, IdPosizione)
   End Sub
   Public Sub New(ByVal ExtController As Object)
      InitializeComponent()
      controller = DirectCast(ExtController, FINANCIAL_ARTIFACTS.AbstractDocumentController)
      Me.m_IdShowedObject = 0

        DoLoad()

    End Sub
   Public Sub New(ByVal IdDocumento As String, ByVal IdPosizione As String, ByVal TipoDocumento As String)
      InitializeComponent()
      Me.m_IdShowedObject = 0
      controller = ApplicationController.GetDocumentController(TipoDocumento)
      controller.LoadById(IdDocumento)
      controller.SelectItemByIds(IdDocumento, IdPosizione)

        DoLoad()

    End Sub

    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "" & MyBase.State.StateName & " posizione documento"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "" & MyBase.State.StateName & " posizione documento "
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  posizione  documento")
        SelectToolStripImage()
    End Sub

    Protected Overrides Sub Nested_PostLoadingActions()
        Dim logo As String = "" & MyBase.State.StateName & "  posizione  documento"
        MasterControl.Instance.ParentForm.Text = logo
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo
        Me.lblCurrentFunction.Text = UCase(logo)
    End Sub

    Protected Overrides Sub Nested_PostchangeActions()
        Dim logo As String = "" & MyBase.State.StateName & "  posizione  documento"
        MasterControl.Instance.ParentForm.Text = logo
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo
        Me.lblCurrentFunction.Text = UCase(logo)
    End Sub


#Region "Metodi per Load iniziale"
    Protected Overrides Sub Nested_PrepareLoading()
        DocumentMediatorFactory.GetDocumentMediator(controller.TipoDocumento).DefineItemViewLayout(Me, controller)
    End Sub
    Protected Overrides Sub Nested_ClearWindowEditors()
        txtdataReg.Text = controller.DataRegistrazione
        txtDataDoc.Text = controller.DataDocumento
        txtTipo.Text = controller.TipoDocumento
        txtDoc.Text = ""
        txtSettore.Text = ""
        txtImporto.Text = 0
        txtCompetenza.Text = ""
        DataInizioCompetenza = DateTime.MinValue
        DataFineCompetenza = DateTime.MinValue
        txtNote.Text = ""
        chk13.Checked = False
        chk14.Checked = False
        IdUtenteTextBox1.TextValue = ""
        IdReferenteTextBox1.TextValue = ""
        txtSogg.Text = ""
        txtQuota.Text = ""
        txtQuotaCongrua.Text = ""
        IdAziendaTextBox1.TextValue = ""
        txtContratto.Text = ""
        txtLav.Text = ""
        txtMal.Text = ""
        txtLiv.Text = ""
        txtPagRef.Text = ""
        txtImportoRist.Text = ""
        DocumentMediatorFactory.GetDocumentMediator(controller.TipoDocumento).DefineNewItemViewLayout(Me, controller)
    End Sub
   'Protected Overrides Sub LoadData()
   '   'qui carico ordino il caricamento dei dati e carico le possibili scelte
   '   'controller.LoadById(m_IdUtente, Me.m_IdShowedObject)
   'End Sub
    Protected Overrides Sub Nested_LoadEditorsProperties()
        txtdataReg.Text = controller.DataRegistrazioneItem
        txtDataDoc.Text = controller.DataDocumentoItem
        txtTipo.Text = controller.TipoDocumento
        txtDoc.Text = controller.IdDocumento
        txtSettore.Text = controller.DescrizioneSettoreItem
        txtImporto.Text = controller.ImportoItem * -1
        txtCompetenza.Text = controller.CompetenzaItem
        DataInizioCompetenza = controller.DataInizioCompetenzaItem
        DataFineCompetenza = controller.DataFineCompetenzaItem
        txtNote.Text = controller.NoteItem
        chk13.Checked = controller.TredicesimaItem
        chk14.Checked = controller.QuattordicesimaItem
        IdUtenteTextBox1.TextValue = controller.IdUtenteItem
        IdReferenteTextBox1.TextValue = controller.IdReferenteItem
        txtSogg.Text = controller.IdSoggettoEsecutore
        txtQuota.Text = controller.QuotaMediaItem
        txtQuotaCongrua.Text = controller.CongruitaItemToString
        IdAziendaTextBox1.TextValue = controller.IdAziendaImpiegoItem
        txtContratto.Text = controller.DescrizioneContrattoItem
        txtLav.Text = controller.OreLavorateItem
        txtMal.Text = controller.OreMalattiaItem
        txtLiv.Text = controller.LivelloInquadramentoItem
        txtPagRef.Text = controller.IdPagamentoReferenti
        txtImportoRist.Text = controller.ImportoRistornoItem
        txtIdPrest.Text = controller.IdPrestazioneItem
        txtTipoPrest.Text = controller.DescrizioneTipoPrestazione
        DocumentMediatorFactory.GetDocumentMediator(controller.TipoDocumento).GetSpecificItemProperties(Me, controller)
    End Sub
#End Region



#Region "Metodi per la navigazione e il recupero d'informazioni sugli id impostati"
   'Private Sub lblUtente_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblUtente.DoubleClick
   '   Try
   '      Navigate(Me.IdUtenteTextBox1.TextValue, "ViewUtente")
   '   Catch ex As Exception
   '      ErrorHandler.ShowError(ex)
   '   End Try
   'End Sub

   'Private Sub lblReferente_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblReferente.DoubleClick
   '   Try
   '      Navigate(Me.IdReferenteTextBox1.TextValue, "ViewReferente")
   '   Catch ex As Exception
   '      ErrorHandler.ShowError(ex)
   '   End Try
   'End Sub
   'Private Sub lblSettore_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblSettore.DoubleClick
   '   Try
   '      If cboSettori.Text = "EDILE" Then
   '         Navigate(1, "ViewSettore")
   '      Else
   '         Navigate(2, "ViewSettore")
   '      End If
   '   Catch ex As Exception
   '      ErrorHandler.ShowError(ex)
   '   End Try
   'End Sub
   'Private Sub lblEnte_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblEnte.DoubleClick
   '   Try
   '      If cboEnti.Text = "CASSA EDILE" Then
   '         Navigate(1, "ViewEnte")
   '      ElseIf cboEnti.Text = "EDIL CASSA" Then
   '         Navigate(2, "ViewEnte")
   '      End If
   '   Catch ex As Exception
   '      ErrorHandler.ShowError(ex)
   '   End Try
   'End Sub
#End Region


#Region "Metodi per l'aggiornamento"
    Public Overrides Sub Nested_UpdateData()
        controller.Save()
    End Sub
#End Region


   Protected Overrides Sub Navigate()

        'Dim ParameterList As Hashtable = New Hashtable

    End Sub






   Private Sub cmdCompetenza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCompetenza.Click
      Dim frm As New frmCompetenza
      frm.ShowDialog()
      If frm.DialogResult = Windows.Forms.DialogResult.OK Then
         frm.ControlloSelezioneCompetenza1.CalcolaDate()
         Select Case Me.txtTipo.Text
                Case "IQA", "IQI", "IQP"
                    'DirectCast(controller, ControllerIncassiQuote).SetCompetenzaItem(frm.ControlloSelezioneCompetenza1.MinDate, frm.ControlloSelezioneCompetenza1.MaxDate)
                    'Me.txtCompetenza.Text = DirectCast(controller, ControllerIncassiQuote).CompetenzaItem
                    DataInizioCompetenza = frm.ControlloSelezioneCompetenza1.MinDate
                    DataFineCompetenza = frm.ControlloSelezioneCompetenza1.MaxDate
                    Me.txtCompetenza.Text = Format(frm.ControlloSelezioneCompetenza1.MinDate, "dd/MM/yyyy") & " - " & Format(frm.ControlloSelezioneCompetenza1.MaxDate, "dd/MM/yyyy")
                    'Case "IQI"

            End Select
      End If
      frm.Dispose()
   End Sub


   Private Sub txtCompetenza_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCompetenza.TextChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub txtImporto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImporto.TextChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub txtNote_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNote.TextChanged
        Me.StartChangeOperation()
    End Sub


    Private Sub IdAziendaTextBox1_TextBoxChanged() Handles IdAziendaTextBox1.TextBoxChanged
        Me.StartChangeOperation()
    End Sub



    Private Sub IdReferenteTextBox1_TextBoxChanged() Handles IdReferenteTextBox1.TextBoxChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub txtContratto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtContratto.TextChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub txtLiv_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLiv.TextChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub txtLav_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLav.TextChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub txtMal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMal.TextChanged
        Me.StartChangeOperation()
    End Sub
    Private Sub chk13_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk13.CheckedChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub chk14_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk14.CheckedChanged
        Me.StartChangeOperation()
    End Sub
    Private Sub ControlItemContabile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CmdExit.Visible = False
    End Sub
    Private Sub IdReferenteTextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles IdReferenteTextBox1.Leave
        InterfaceMediator.GetSimpleDescription(New ControllerReferenti, "CompleteName", Me.lblDescrizioneReferente, Me.IdReferenteTextBox1.TextValue)
    End Sub

    Private Sub IdAziendaTextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles IdAziendaTextBox1.Leave
        'InterfaceMediator.GetSimpleDescription(New WIN.APPLICATION.AZIENDE.ControllerAziende, "Descrizione", Me.lblAzImpiego, Me.IdAziendaTextBox1.TextValue)
        DescribeAzienda()

    End Sub
    Public Sub DescribeAzienda()
        Try
            Dim controllerAz As New WIN.APPLICATION.AZIENDE.ControllerAziende
            controllerAz.LoadById(Me.IdAziendaTextBox1.TextValue)
            Me.lblDescrAzImpiego.Text = controllerAz.Descrizione
            Me.txtContratto.Text = controllerAz.DescrizioneContratto
            controllerAz = Nothing
        Catch ex As Exception
            Me.lblDescrAzImpiego.Text = ""
            Me.txtContratto.Text = ""
        End Try
    End Sub

    Private Sub IdUtenteTextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles IdUtenteTextBox1.Leave
        InterfaceMediator.GetSimpleDescription(New WIN.APPLICATION.UTENTI.ControllerUtenti, "CompleteName", Me.lblDescrizioneUtente, Me.IdUtenteTextBox1.TextValue)
    End Sub


    Private Sub txtImportoRist_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImportoRist.TextChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.StartChangeOperation()
    End Sub

    Private Sub lblDescrizioneUtente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblDescrizioneUtente.Click

    End Sub

   Private Sub GrpPosizione_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles GrpPosizione.Paint

   End Sub
End Class
