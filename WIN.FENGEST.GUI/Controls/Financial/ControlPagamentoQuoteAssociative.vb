Imports System.Windows.Forms
Imports System
Imports Microsoft.VisualBasic.ApplicationServices

Public Class ControlPagamentoQuoteAssociative
   Private controllerSettori As New ControllerSettori
   Private controller As New FINANCIAL_ARTIFACTS.ControllerIncassiQuote
   Private m_SelectedColumnName As String = ""
   Dim controllerEnti As New AZIENDE.ControllerEntiBilaterali
   Dim WithEvents frm As FrmItemContabile
   Public Sub New()
      InitializeComponent()
      Try
         DoLoad()
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub


#Region "Metodo per visualizzare le combobox, le informazioni di stato  e i dati del soggetto pagante"
   Private Sub SetVisualizzazioneSoggetto()
      CboEnti.Visible = False
      IdAziendaTextBox1.Visible = False
      If controllerSettori.IsSettoreEdile(cboSettori.Text) Then
         CboEnti.Visible = True
         DisplayDataforSoggettoEdile()
      Else
         IdAziendaTextBox1.Visible = True
         DisplaydataForSoggettoIF()
      End If

   End Sub
   Private Sub cboSettori_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSettori.SelectedIndexChanged
      SetVisualizzazioneSoggetto()
   End Sub
   Private Sub IdAziendaTextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles IdAziendaTextBox1.Leave
      DisplaydataForSoggettoIF()
   End Sub
   Private Sub DisplaydataForSoggettoIF()
      Try
         Dim controllerAziende As New AZIENDE.ControllerAziende
         controllerAziende.LoadById(Me.IdAziendaTextBox1.TextValue)
         lblValuta.Text = controllerAziende.ValutaConto
         lblDescrizioneAzienda.Text = controllerAziende.Descrizione
         lblCompUltimo.Text = controllerAziende.CompetenzaUltimoPagamento
         GrpSogg.Visible = True
         controllerAziende = Nothing
      Catch ex As Exception
         lblValuta.Text = ""
         lblDescrizioneAzienda.Text = ""
         lblCompUltimo.Text = ""
         GrpSogg.Visible = False
      End Try
   End Sub
   Private Sub CboEnti_SelectedIndexchanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CboEnti.SelectedIndexChanged
      DisplayDataforSoggettoEdile()
   End Sub
   Private Sub DisplayDataforSoggettoEdile()
      Try
         Dim controllerEnti As New AZIENDE.ControllerEntiBilaterali
         controllerEnti.LoadById(controllerEnti.GetIdEnteByDescrizione(CboEnti.Text))
         lblValuta.Text = controllerEnti.ValutaConto
         lblDescrizioneAzienda.Text = controllerEnti.Descrizione
         lblCompUltimo.Text = controllerEnti.CompetenzaUltimoPagamento
         GrpSogg.Visible = True
         controllerEnti = Nothing
      Catch ex As Exception
         lblValuta.Text = ""
         lblDescrizioneAzienda.Text = ""
         lblCompUltimo.Text = ""
         GrpSogg.Visible = False
      End Try
   End Sub
    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "" & MyBase.State.StateName & " incasso quota associativa"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "" & MyBase.State.StateName & " incasso quota associativa "
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & " incasso  quota   associativa")
        SelectToolStripImage()
    End Sub
#End Region


#Region "Metodi per la creazione di un nuovo oggetto"
    Protected Overrides Sub Nested_PrepareForCreation()
        Me.TabControl1.Visible = True
        txtTotale.Enabled = False
        Me.GridPosizioni.Visible = False
        Me.CmdCrea.Visible = True

        GrpSogg.Visible = False
        InterfaceMediator.LoadCombo(Me.cboSettori, controllerSettori.GetListaSettori, False)
        Me.cboSettori.SelectedIndex = 1
        InterfaceMediator.LoadCombo(Me.CboEnti, controllerEnti.GetListaEnti, False)
        Dim MinDate As DateTime = New DateTime(Today.Year, Today.Month, 1)
        Dim MaxDate As DateTime = New DateTime(Today.Year, Today.Month, Date.DaysInMonth(Today.Year, Today.Month))
        lblComp.Text = "La competenza va dal " & Format(MinDate, "dd/MM/yyyy") & " al " & Format(MaxDate, "dd/MM/yyyy")
        GrpSogg.Visible = False
        cmdUp.Visible = False
        CmdDown.Visible = False
        Panel1.Visible = False
        cmdDel.Visible = False
        cmdAdd.Visible = False
        Me.txtImporto.Text = "0,00"
        Me.txtAttribuito.Text = "0,00"
        Me.txtTotale.Text = "0,00"
        CustomBar1.SetTargetControl(Me)
    End Sub
    Private Sub cmdCrea_DoClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCrea.DoClik
        WIN.GUI.UTILITY.Helper.ShowWaitBox("Attendere ricerca posizioni...", My.Resources.Waiting3)
        Try
            controllerSettori.LoadById(controllerSettori.GetIdSettoreByDescrizione(Me.cboSettori.Text))
            controllerEnti.LoadById(controllerEnti.GetIdEnteByDescrizione(Me.CboEnti.Text))
            If controllerSettori.IsSettoreEdile(Me.cboSettori.Text) Then
                controller.CreateNew(dtpRegistrazione.Value.Date, Me.dtpDoc.Value.Date, _
                                                controllerEnti.GetIdEnteByDescrizione(Me.CboEnti.Text), _
                                                Me.txtImporto.Text, Me.txtNote.Text, controllerSettori.GetIdSettoreByDescrizione(Me.cboSettori.Text), _
                                                Me.ControlloSelezioneCompetenza1.MinDate, _
                                                Me.ControlloSelezioneCompetenza1.MaxDate, , , False)
            Else

                controller.CreateNew(dtpRegistrazione.Value.Date, Me.dtpDoc.Value.Date, _
                                     Me.IdAziendaTextBox1.TextValue, _
                                     Me.txtImporto.Text, Me.txtNote.Text, controllerSettori.GetIdSettoreByDescrizione(Me.cboSettori.Text), _
                                     Me.ControlloSelezioneCompetenza1.MinDate, _
                                     Me.ControlloSelezioneCompetenza1.MaxDate, , , False)
                'Qui creo un thread a parte che carica le posizioni di default se richiesto
                If My.Settings.CreateDefaultPositionIF Then
                    Dim t As System.Threading.Thread = New System.Threading.Thread(AddressOf controller.CreateDefaultPosition)
                    t.Start()

                    NotifyDefaultPositionCreation()

                    Do While t.IsAlive
                        System.Windows.Forms.Application.DoEvents()
                    Loop

                    Nested_NotifyParent()

                End If

            End If



            'qiu faccio il controllo se esistono pagament sovrapposti
            Dim result As MsgBoxResult = MsgBoxResult.Ok
            If controller.EsistonoIncassiSovrapposti Then
                result = MsgBox("Esistono altri incassi dello stesso soggetto esecutore che si sovrappongono alla competenza indicata! Continuare?", MsgBoxStyle.YesNo + MsgBoxStyle.Information)
                If result = MsgBoxResult.Yes Then
                    PreparaCompilazione()
                Else
                    RitornaAlComandoPrecedente()
                End If
            Else
                PreparaCompilazione()
            End If
            WIN.GUI.UTILITY.Helper.HideWaitBox()

        Catch ex As Exception
            WIN.GUI.UTILITY.Helper.HideWaitBox()
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub NotifyDefaultPositionCreation()

        MasterControl.Instance.ParentForm.Text = "Attendere creazione posizioni di default..."
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Attendere creazione posizioni di default..."
        MasterControl.Instance.Current.SetLabelForCurrentFunction(UCase(" Attendere  creazione  posizioni  di  default..."))
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.status_anim


    End Sub
    Private Sub PreparaCompilazione()
        Try
            If PrepareGridLoading() Then
                txtTotale.Text = controller.Totale
                Me.IdAziendaTextBox1.Enabled = False
                Me.CmdCrea.Visible = False
                Me.CboEnti.Enabled = False
                Me.cboSettori.Enabled = False
                cmdUp.Visible = True
                CmdDown.Visible = True
                cmdDel.Visible = True

                cmdAdd.Visible = True
                Panel1.Visible = True
                Me.cmdBlu.BackgroundImage = My.Resources.Flag_grayHS
                Me.cmdRed.BackgroundImage = My.Resources.Flag_redHS
                Me.cmdGreen.BackgroundImage = My.Resources.Flag_grayHS
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
#End Region


#Region "metodi per la navigazione"
   Protected Overrides Sub Navigate()
      Try
         Dim ParameterList As Hashtable = New Hashtable
         ParameterList.Add("Id", m_IdShowedObject)
         ParameterList.Add("TipoDocumento", "IQA")
         Me.NavigateTo("ViewDocumento", ParameterList)
      Catch ex As Exception
         Throw New Exception(ex.Message)
      End Try
   End Sub
   Private Sub RitornaAlComandoPrecedente()
      Try
         MasterControl.Instance.GoPrevious()
      Catch ex As Exception
         Throw New Exception(ex.Message)
      End Try
   End Sub
#End Region


#Region "Metodi per il salvataggio"
    Public Overrides Sub Nested_InsertData()
        Try
            controller.Save()
            MyBase.m_IdShowedObject = controller.IdDocumento
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
#End Region


#Region "Metodi per l'usabilità  della griglia"
   Private Sub GridPosizioni_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridPosizioni.CellEnter
      Try
         If GridPosizioni.Columns(e.ColumnIndex).Name = "Note" Then
                GridPosizioni.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.SelectionBackColor = Drawing.Color.LightGray()
            GridPosizioni.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.BackColor = Drawing.Color.LightGreen
         End If
         If GridPosizioni.Columns(e.ColumnIndex).Name = "ImportoPosizione" Then
            GridPosizioni.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.SelectionBackColor = Drawing.Color.LightGray
            GridPosizioni.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.BackColor = Drawing.Color.LightGreen
         End If
         If GridPosizioni.Columns(e.ColumnIndex).Name = "Tredicesima" Then
            GridPosizioni.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.SelectionBackColor = Drawing.Color.LightGray
            GridPosizioni.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.BackColor = Drawing.Color.LightGreen
         End If
         If GridPosizioni.Columns(e.ColumnIndex).Name = "Quattordicesima" Then
            GridPosizioni.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.SelectionBackColor = Drawing.Color.LightGray
            GridPosizioni.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.BackColor = Drawing.Color.LightGreen
         End If
         If GridPosizioni.Columns(e.ColumnIndex).Name = "LivelloInquadramento" Then
            GridPosizioni.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.SelectionBackColor = Drawing.Color.LightGray
            GridPosizioni.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.BackColor = Drawing.Color.LightGreen
         End If
         If GridPosizioni.Columns(e.ColumnIndex).Name = "OreLavorate" Then
            GridPosizioni.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.SelectionBackColor = Drawing.Color.LightGray
            GridPosizioni.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.BackColor = Drawing.Color.LightGreen
         End If
         If GridPosizioni.Columns(e.ColumnIndex).Name = "OreMalattia" Then
            GridPosizioni.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.SelectionBackColor = Drawing.Color.LightGray
            GridPosizioni.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.BackColor = Drawing.Color.LightGreen
         End If
         If GridPosizioni.Columns(e.ColumnIndex).Name = "CercaContratti" Then
            GridPosizioni.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.SelectionBackColor = Drawing.Color.LightGray
         End If
         If GridPosizioni.Columns(e.ColumnIndex).Name = "CercaReferenti" Then
            GridPosizioni.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.SelectionBackColor = Drawing.Color.LightGray
         End If
         If GridPosizioni.Columns(e.ColumnIndex).Name = "SelCompetenza" Then
            GridPosizioni.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.SelectionBackColor = Drawing.Color.LightGray
         End If
         If GridPosizioni.Columns(e.ColumnIndex).Name = "CercaAziendaImpiego" Then
            GridPosizioni.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.SelectionBackColor = Drawing.Color.LightGray
         End If


      Catch ex As Exception

      End Try
   End Sub
   Private Sub GridPosizioni_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridPosizioni.CellLeave
      Try
         'If GridPosizioni.Columns(e.ColumnIndex).Name = "Note" Then
         GridPosizioni.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.BackColor = Drawing.Color.White
         'End If
      Catch ex As Exception

      End Try
   End Sub
#End Region


#Region "Metodi per la gestione  della griglia"
   Private Sub GridPosizioni_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GridPosizioni.ColumnHeaderMouseClick
      'qui seleziono tutta la colonna
      GridPosizioni.ClearSelection()
      For Each elem As DataGridViewColumn In GridPosizioni.Columns
         elem.HeaderCell.SortGlyphDirection = SortOrder.None
      Next
      GridPosizioni.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.Descending
      m_SelectedColumnName = GridPosizioni.Columns(e.ColumnIndex).Name
   End Sub
   Private Sub GridPosizioni_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles GridPosizioni.CellBeginEdit
      Try
         controller.SelectItem(GridPosizioni.Rows(e.RowIndex).Cells("IdUtente").Value, GridPosizioni.Rows(e.RowIndex).Cells("DICompetenza").Value, GridPosizioni.Rows(e.RowIndex).Cells("DFCompetenza").Value)
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub
   Private Sub GridPosizioni_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridPosizioni.CellContentClick
      Try
         If GridPosizioni.Columns(e.ColumnIndex).Name = "CercaReferenti" AndAlso Not e.RowIndex = -1 Then
            Dim frm As New SearchReferenti
            frm.ShowDialog()
            If frm.DialogResult = Windows.Forms.DialogResult.OK Then
               controller.SelectItem(GridPosizioni.Rows(e.RowIndex).Cells("IdUtente").Value, GridPosizioni.Rows(e.RowIndex).Cells("DICompetenza").Value, GridPosizioni.Rows(e.RowIndex).Cells("DFCompetenza").Value)
               controller.SetReferenteItem(frm.SelectedId)
               GridPosizioni.Refresh()
            End If
            frm.Dispose()
         End If

         If GridPosizioni.Columns(e.ColumnIndex).Name = "SelSede" AndAlso Not e.RowIndex = -1 Then
            controller.SelectItem(GridPosizioni.Rows(e.RowIndex).Cells("IdUtente").Value, GridPosizioni.Rows(e.RowIndex).Cells("DICompetenza").Value, GridPosizioni.Rows(e.RowIndex).Cells("DFCompetenza").Value)
            Dim frm As New FrmSelSedi(controller.DescrizioneSoggettoEsecutore, controller.ListaSediForSoggetto, GridPosizioni.Rows(e.RowIndex).Cells("SedeOperativaAzienda").Value.Descrizione)
            frm.ShowDialog()
            If frm.DialogResult = Windows.Forms.DialogResult.OK Then
               'controller.SelectItem(GridPosizioni.Rows(e.RowIndex).Cells("IdUtente").Value, GridPosizioni.Rows(e.RowIndex).Cells("DICompetenza").Value, GridPosizioni.Rows(e.RowIndex).Cells("DFCompetenza").Value)
               controller.SetSedeOperativaItem(frm.NomeSede)
               GridPosizioni.Refresh()
            End If
            frm.Dispose()
         End If

         If GridPosizioni.Columns(e.ColumnIndex).Name = "CercaAziendaImpiego" AndAlso Not e.RowIndex = -1 Then
            Dim frm As New SearchAziende
            frm.ShowDialog()
            If frm.DialogResult = Windows.Forms.DialogResult.OK Then
               controller.SelectItem(GridPosizioni.Rows(e.RowIndex).Cells("IdUtente").Value, GridPosizioni.Rows(e.RowIndex).Cells("DICompetenza").Value, GridPosizioni.Rows(e.RowIndex).Cells("DFCompetenza").Value)
               controller.SetAziendaImpiegoItem(frm.SelectedId)
               GridPosizioni.Refresh()
            End If
            frm.Dispose()
         End If
         If GridPosizioni.Columns(e.ColumnIndex).Name = "SelCompetenza" AndAlso Not e.RowIndex = -1 Then
            Dim frm As New frmCompetenza
            frm.ShowDialog()
            If frm.DialogResult = Windows.Forms.DialogResult.OK Then
               frm.ControlloSelezioneCompetenza1.CalcolaDate()
               controller.SelectItem(GridPosizioni.Rows(e.RowIndex).Cells("IdUtente").Value, GridPosizioni.Rows(e.RowIndex).Cells("DICompetenza").Value, GridPosizioni.Rows(e.RowIndex).Cells("DFCompetenza").Value)
               controller.SetCompetenzaItem(frm.ControlloSelezioneCompetenza1.MinDate, frm.ControlloSelezioneCompetenza1.MaxDate)
               GridPosizioni.Refresh()
            End If
            frm.Dispose()
         End If
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub
   Private Sub GridPosizioni_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridPosizioni.CellEndEdit
      'in questo punto eseguo le variazioni sul controller
      Try
         If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("ImportoPosizione") Then
            controller.SetImportoItem(GridPosizioni.Rows(e.RowIndex).Cells("ImportoPosizione").Value)
            txtTotale.Text = controller.Totale
            Me.txtAttribuito.Text = controller.TotaleAttribuito
            GridPosizioni.Refresh()
            SetBandierine()
         End If
         If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("Note") Then
            controller.NoteItem = GridPosizioni.Rows(e.RowIndex).Cells("Note").Value
            GridPosizioni.Refresh()
         End If
         If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("LivelloInquadramento") Then
            controller.LivelloInquadramentoItem = GridPosizioni.Rows(e.RowIndex).Cells("LivelloInquadramento").Value
            GridPosizioni.Refresh()
         End If
         If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("OreLavorate") Then
            controller.OreLavorateItem = GridPosizioni.Rows(e.RowIndex).Cells("OreLavorate").Value
            GridPosizioni.Refresh()
         End If
         If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("OreMalattia") Then
            controller.OreMalattiaItem = GridPosizioni.Rows(e.RowIndex).Cells("OreMalattia").Value
            GridPosizioni.Refresh()
         End If
         If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("Tredicesima") Then
            controller.TredicesimaItem = GridPosizioni.Rows(e.RowIndex).Cells("Tredicesima").Value
            GridPosizioni.Refresh()
         End If
         If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("Quattordicesima") Then
            controller.QuattordicesimaItem = GridPosizioni.Rows(e.RowIndex).Cells("Quattordicesima").Value
            GridPosizioni.Refresh()
         End If
         If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("IdReferente") Then
            controller.SetReferenteItem(GridPosizioni.Rows(e.RowIndex).Cells("IdReferente").Value)
            GridPosizioni.Refresh()
         End If

      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub
   Private Sub GridPosizioni_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles GridPosizioni.CellFormatting
      Try
         If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("Utente") Then
            If Not e.Value Is Nothing Then
               GridPosizioni.Rows(e.RowIndex).Cells("IdUtente").Value = e.Value.IdUtente
               e.Value = e.Value.CompleteName
            End If
         End If
         If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("Referente") Then
            If Not e.Value Is Nothing Then
               GridPosizioni.Rows(e.RowIndex).Cells("IdReferente").Value = e.Value.IdReferente
               e.Value = e.Value.CompleteName
            End If
         End If

         If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("AziendaImpiego") Then
            If Not e.Value Is Nothing Then
               GridPosizioni.Rows(e.RowIndex).Cells("IdAziendaImpiego").Value = e.Value.Id
               e.Value = e.Value.Descrizione
            End If
         End If
         If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("SedeOperativaAzienda") Then
            If Not e.Value Is Nothing Then
               e.Value = e.Value.Descrizione
            End If
         End If

         If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("Importo") Then
            If Not e.Value Is Nothing Then
               GridPosizioni.Rows(e.RowIndex).Cells("ImportoPosizione").Value = CDbl(e.Value.Importo) * -1
               e.Value = e.Value.GetTipoValutaToString(e.Value.GetValuta)
            End If
         End If

         If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("Conto") Then
            If Not e.Value Is Nothing Then
               e.Value = e.Value.Descrizione
            End If
         End If

         If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("ContrattoApplicato") Then
            If Not e.Value Is Nothing Then
               e.Value = e.Value.Descrizione
            End If
         End If

         If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("Competenza") Then
            If Not e.Value Is Nothing Then
               GridPosizioni.Rows(e.RowIndex).Cells("DICompetenza").Value = Format(e.Value.GetDataRange.Start, "dd/MM/yyyy")
               GridPosizioni.Rows(e.RowIndex).Cells("DFCompetenza").Value = Format(e.Value.GetDataRange.Finish, "dd/MM/yyyy")
               e.Value = e.Value.ToString
            End If
         End If

         If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("QuotaMensileUtente") Then
            If Not e.Value Is Nothing Then
               e.Value = e.Value.Importo
            End If
         End If

         If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("QuotaMedia") Then
            If Not e.Value Is Nothing Then
               e.Value = e.Value.Importo
            End If
         End If



      Catch ex As Exception
         Throw New Exception(ex.Message)
         'ErrorHandler.ShowError(ex)
      End Try
   End Sub
   Private Function PrepareGridLoading() As Boolean
      Try
         Dim listaPosizioni As IList = controller.ListaPosizioniUtenti
         If listaPosizioni.Count = 0 Then
            'If MsgBox("Non esistono utenti con una delega accettata o attiva. Il soggetto esecutore può eseguire solo pagamenti arretrati. Procedere comunque?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.No Then
            '   Me.RitornaAlComandoPrecedente()
            '   Return False
            'Else
            'non carico la lista la carico dopo se devo aggiungere le posizioni
            GridPosizioni.Visible = True
            Return True
            'End If
         End If
         GridPosizioni.DataSource = New ArrayList
         Dim gridLoader As New GridLoaderNewIQA(Me.GridPosizioni, controller)
         gridLoader.LoadGrid(listaPosizioni)
         'LoadGrid(listaPosizioni)
         Return True
      Catch ex As Exception
         Throw New Exception(ex.Message)
      End Try
   End Function
   
#End Region


#Region "Metodi per l'aggiornamento del pagamento"
   Private Sub txtNote_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
      Try
         If controller.IsCreated Then controller.Note = txtNote.Text
         System.Windows.Forms.Application.DoEvents()
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub
   Private Sub txtImporto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtImporto.Leave
      CorrectImporto()
   End Sub
   Private Sub CorrectImporto()
      Try
         If controller.IsCreated Then
            controller.SetImporto(txtImporto.Text)
            txtTotale.Text = controller.Totale
            Me.txtAttribuito.Text = controller.TotaleAttribuito
            System.Windows.Forms.Application.DoEvents()
            SetBandierine()
         End If
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
         If controller.IsCreated Then
            txtImporto.Text = controller.Importo
         End If
      End Try
   End Sub
   Private Sub SetBandierine()
      If controller.Importo > 0 And controller.Totale = 0 Then
         Me.cmdGreen.BackgroundImage = My.Resources.Flag_greenHS
         Me.cmdRed.BackgroundImage = My.Resources.Flag_grayHS
      Else
         Me.cmdGreen.BackgroundImage = My.Resources.Flag_grayHS
         Me.cmdRed.BackgroundImage = My.Resources.Flag_redHS
      End If
   End Sub
   Private Sub dtpRegistrazione_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpRegistrazione.Leave
      Try
         If controller.IsCreated Then controller.DataRegistrazione = dtpRegistrazione.Value
         System.Windows.Forms.Application.DoEvents()
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Private Sub dtpDoc_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpDoc.Leave
      Try
         If controller.IsCreated Then controller.DataDocumento = dtpDoc.Value
         System.Windows.Forms.Application.DoEvents()
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub
   Private Sub ControlloSelezioneCompetenza1_Leave(ByVal sender As Object, ByVal e As System.EventArgs)
      Try
         Me.ControlloSelezioneCompetenza1.CalcolaDate()
         If controller.IsCreated Then controller.SetCompetenza(ControlloSelezioneCompetenza1.MinDate, ControlloSelezioneCompetenza1.MaxDate)
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub
   Private Sub ControlloSelezioneCompetenza1_ChangeCompetenza(ByVal Competenza As String) Handles ControlloSelezioneCompetenza1.ChangeCompetenza
      lblComp.Text = Competenza
   End Sub
   Private Sub lblValuta_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblValuta.TextChanged
      lblTot.Text = lblValuta.Text
   End Sub
#End Region


#Region "Funzionalità sulle posizioni"
   Private Sub cmdUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUp.DoClik
      Try
         controller.SortItems(m_SelectedColumnName)
         GridPosizioni.DataSource = controller.ListaPosizioniUtenti
         GridPosizioni.Refresh()
         If m_SelectedColumnName = "" Then Exit Sub
         GridPosizioni.Columns(m_SelectedColumnName).HeaderCell.SortGlyphDirection = SortOrder.Descending
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub
   Private Sub cmdDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdDown.DoClik
      Try
         controller.SortItems(m_SelectedColumnName, True)
         GridPosizioni.DataSource = controller.ListaPosizioniUtenti
         GridPosizioni.Refresh()
         If m_SelectedColumnName = "" Then Exit Sub
         GridPosizioni.Columns(m_SelectedColumnName).HeaderCell.SortGlyphDirection = SortOrder.Descending
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub
   Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.DoClik
      Try
         If GridPosizioni.SelectedCells.Count = 0 Then Throw New Exception("Per eliminare una riga posizionarsi su una cella all'interno della riga da rimuovere")
         If GridPosizioni.SelectedCells.Count > 1 Then Throw New Exception("Per eliminare una riga selezionare una sola cella all'interno della riga da rimuovere")
         Dim cell As System.Windows.Forms.DataGridViewCell = GridPosizioni.SelectedCells(0)
         If Not cell.Displayed Then
            Throw New Exception("Per rimuovere una riga selezionare una cella")
         Else
            If MsgBox("Sicuro di voler eliminare la posizione?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Eliminazione posizione incasso") = MsgBoxResult.Yes Then
               controller.RemoveItem(GridPosizioni.Rows(cell.RowIndex).Cells("IdUtente").Value, GridPosizioni.Rows(cell.RowIndex).Cells("DICompetenza").Value, GridPosizioni.Rows(cell.RowIndex).Cells("DFCompetenza").Value)
               txtImporto.Text = controller.Importo
               CorrectImporto()
               GridPosizioni.DataSource = controller.ListaPosizioniUtenti
               GridPosizioni.Refresh()
            End If
         End If

      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub
   Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.DoClik
      Try
         frm = New FrmItemContabile("Add", controller, "IQA")
         frm.ShowDialog()
         frm.Dispose()
         Dim lista As IList = controller.ListaPosizioniUtenti
         If lista.Count = 1 Then
            Dim gridLoader As New GridLoaderNewIQA(Me.GridPosizioni, controller)
            gridLoader.LoadGrid(lista)
         Else
            DocumentMediatorFactory.GetDocumentMediator("IQA").RefeshItemsGrid(Me, controller)
         End If
         CorrectImporto()
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub
#End Region

   Private Sub CustomBar1_DoAnnullaClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoAnnullaClick
      Try
         MasterControl.Instance.GoPrevious()
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub
   Private Sub CustomBar1_DoSaveClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoSaveClick
      Try
            StartSaveOperation()
         Navigate()
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

End Class
