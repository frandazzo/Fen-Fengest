
Imports System.Windows.Forms
Imports WIN.SECURITY.Exceptions

Public Class ControlAnalisiOffertaLavoro
   Dim controllerRicerche As New ControllerRicercheOfferte
   Dim controllerUtenti As New UTENTI.ControllerUtenti
   Dim controllerabilita As New ControllerAbilita
   Dim controllerProposte As New ControllerProposte()
   Dim ErrorString As String = ""
   'Private WithEvents Controller As New WIN.APPLICATION.REPORTING.ReportIscritti

   Private m_selectedColumnName As String = ""
   Dim frm As FrmElaborazioneInCorso
   Dim list As IList = New ArrayList

    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "Ricerca domande di lavoro"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Ricerca domande di lavoro  "
        Me.lblCurrentFunction.Text = UCase("Ricerca domande di lavoro ")
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.SearchPaint
    End Sub

    Protected Overrides Sub Nested_PostLoadingActions()
        Dim logo As String = "Ricerca domande di lavoro "
        MasterControl.Instance.ParentForm.Text = logo
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo
        Me.lblCurrentFunction.Text = UCase(logo)
    End Sub


   Private Sub FillSearchList()
      list = controllerRicerche.Search
   End Sub


   Private Sub SetGUIPreProcessReport()
      MasterControl.Instance.ParentForm.Text = "Attendere l'elaborazione...  "
      MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Attendere l'elaborazione... "
      Me.lblCurrentFunction.Text = UCase("Attendere   l'elaborazione  . . . ")
      MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.status_anim
      Me.Cursor = Windows.Forms.Cursors.WaitCursor
   End Sub

   Private Sub SetGUIPostProcessReport()
      Me.Cursor = Windows.Forms.Cursors.Default
      MasterControl.Instance.ParentForm.Text = "Ricerca domande di lavoro"
      MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Ricerca domande di lavoro  "
      Me.lblCurrentFunction.Text = UCase("Ricerca domande di lavoro ")
      MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.SearchPaint
   End Sub

    Protected Overrides Sub Nested_PrepareLoading()
        LoadComboWithPreferences(True)
    End Sub

   Public Sub New()
      ' Chiamata richiesta da Progettazione Windows Form.
      InitializeComponent()
      ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
      Me.m_IdShowedObject = 0
      DoLoad()
      InitializeGrid()
   End Sub
   Private Sub cmdCerca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdVis.DoClik

      Try
         If cboPref.Text = "" Then
            MsgBox("Selezionare una offerta di lavoro", MsgBoxStyle.Exclamation, "Selezione offerrte")
            Exit Sub
         End If
         'frm = New FrmElaborazioneInCorso
         'frm.Show()
         SetGUIPreProcessReport()
         System.Windows.Forms.Application.DoEvents()

         Me.SetSearchConditions()
         Dim thread As New System.Threading.Thread(AddressOf FillSearchList)
         thread.Start()

         Do While thread.IsAlive = True
            System.Windows.Forms.Application.DoEvents()
         Loop


         'frm.Dispose()
         SetGUIPostProcessReport()
         System.Windows.Forms.Application.DoEvents()

         If list.Count = 0 Then
            MsgBox("Non ci sono posizioni per i requisiti immessi!", MsgBoxStyle.Information, "Nessuna posizione trovata")
            txtResults.Text = 0
            If GridOfferte.DataSource IsNot Nothing Then
               GridOfferte.DataSource = New ArrayList
            End If
         Else
            LoadGrid(list)
            txtResults.Text = list.Count
         End If

      Catch ex As Exception
         SetGUIPostProcessReport()
         ErrorHandler.ShowError(ex)
         txtResults.Text = 0
      End Try

   End Sub


   Private Sub SetSearchConditions()
      Dim map As New Hashtable
      map.Add("IntervalloDate", chkReg.Checked)
      map.Add("Data", chkDoc.Checked)
      controllerRicerche.SetNewSerchConditions(map)
      controllerRicerche.SetData(dtpDocDa.Value)
      controllerRicerche.SetValidityRange(dtpRegDa.Value, dtpRegA.Value)
      controllerRicerche.SetIdAzienda(IdAziendaTextBox1.TextValue)
      controllerRicerche.SetSkill(cboPref.Text)
      'controllerRicerche.SetMaxNumberOfReturnedRecords(My.Settings.MaxReturnedRecordNumber)
      controllerRicerche.SetIdSkill(controllerabilita.GetIdByDescrizione(cboPref.Text))
   End Sub

   Private Sub InitializeGrid()
      With GridOfferte



         .Columns.Clear()

         .AutoGenerateColumns = False

         Dim colAb As DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
         colAb.Name = "Selected"
         colAb.ReadOnly = False
         colAb.HeaderText = "Seleziona"
         colAb.DataPropertyName = "Selected"
         colAb.TrueValue = True
         colAb.FalseValue = False
         .Columns.Add(colAb)


         Dim coldom As DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
         coldom.Name = "Id"
         coldom.ReadOnly = True
         coldom.HeaderText = "Domanda di lavoro"
         coldom.DataPropertyName = "Id"
         coldom.CellTemplate.Style.Font = New Font(.Font, FontStyle.Underline)
         coldom.CellTemplate.Style.ForeColor = SystemColors.ActiveCaption
         .Columns.Add(coldom)



         Dim colData As DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
         colData.Name = "Data"
         colData.ReadOnly = True
         colData.HeaderText = "Data domanda"
         colData.DataPropertyName = "Data"
         .Columns.Add(colData)


         Dim colaz As DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
         colaz.Name = "AziendaRichiedente"
         colaz.ReadOnly = True
         colaz.HeaderText = "Azienda richiedente"
         colaz.DataPropertyName = "AziendaRichiedente"
         colaz.CellTemplate.Style.Font = New Font(.Font, FontStyle.Underline)
         colaz.CellTemplate.Style.ForeColor = SystemColors.ActiveCaption
         .Columns.Add(colaz)


         Dim colval As DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
         colval.Name = "Validita"
         colval.ReadOnly = True
         colval.HeaderText = "Validità"
         colval.DataPropertyName = "Validita"
         .Columns.Add(colval)

         Dim colnum As DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
         colnum.Name = "GetNumeroTotalePosti"
         colnum.ReadOnly = True
         colnum.HeaderText = "Totale posti"
         colnum.DataPropertyName = "GetNumeroTotalePosti"
         .Columns.Add(colnum)

         .SelectionMode = DataGridViewSelectionMode.CellSelect
         .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing
         .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells


      End With

   End Sub

   Private Sub LoadGrid(ByVal Lista As ArrayList)

      If GridOfferte.DataSource Is Nothing Then
         GridOfferte.DataSource = Lista
         Return
      End If

      GridOfferte.DataSource = Nothing
      GridOfferte.DataSource = Lista

      ''GridReferenti.DataSource = Lista
      'With GridOfferte

      '   If Lista.Count > 0 Then

      '      .DataSource = Lista
      '      .AutoGenerateColumns = False

      '      .Columns("Key").Visible = False
      '      .Columns("Versione").Visible = False
      '      .Columns("CreatoDa").Visible = False
      '      .Columns("ModificatoDa").Visible = False
      '      .Columns("DataCreazione").Visible = False
      '      .Columns("DataModifica").Visible = False
      '      .Columns("Descrizione").Visible = False


      '      .Columns("Note").Visible = False



      '      .Columns("Selected").Visible = True
      '      .Columns("Selected").HeaderText = "Seleziona"
      '      .Columns("Selected").DisplayIndex = 0

      '      .Columns("Id").Visible = True
      '      .Columns("Id").ReadOnly = True
      '      .Columns("Id").CellTemplate.Style.Font = New Font(.Columns("Id").DataGridView.Font, FontStyle.Underline)
      '      .Columns("Id").CellTemplate.Style.ForeColor = SystemColors.ActiveCaption

      '      .Columns("Id").DisplayIndex = 1

      '      .Columns("Data").Visible = True
      '      .Columns("Data").HeaderText = "Data"
      '      .Columns("Data").ReadOnly = True
      '      .Columns("Data").DisplayIndex = 2



      '      .Columns("AziendaRichiedente").Visible = True
      '      .Columns("AziendaRichiedente").HeaderText = "Azienda richiedente"
      '      .Columns("AziendaRichiedente").CellTemplate.Style.Font = New Font(.Columns("AziendaRichiedente").DataGridView.Font, FontStyle.Underline)
      '      .Columns("AziendaRichiedente").CellTemplate.Style.ForeColor = SystemColors.ActiveCaption
      '      .Columns("AziendaRichiedente").ReadOnly = True
      '      .Columns("AziendaRichiedente").DisplayIndex = 3


      '      .Columns("Validita").Visible = True
      '      .Columns("Validita").HeaderText = "Validità"
      '      .Columns("Validita").ReadOnly = True
      '      .Columns("Validita").DisplayIndex = 4

      '      .Columns("GetNumeroTotalePosti").Visible = True
      '      .Columns("GetNumeroTotalePosti").HeaderText = "Totale posti"
      '      .Columns("GetNumeroTotalePosti").ReadOnly = True
      '      .Columns("GetNumeroTotalePosti").DisplayIndex = 5






      '      .SelectionMode = DataGridViewSelectionMode.CellSelect
      '      .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing
      '      .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

      '      .Refresh()
      '   End If
      'End With


   End Sub










   Private Sub chkReg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkReg.CheckedChanged
      If chkReg.Checked Then
         dtpRegDa.Enabled = True
         dtpRegA.Enabled = True
      Else
         dtpRegDa.Enabled = False
         dtpRegA.Enabled = False
      End If

   End Sub

   Private Sub chkDoc_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkDoc.CheckedChanged
      If chkDoc.Checked Then
         dtpDocDa.Enabled = True
      Else
         dtpDocDa.Enabled = False
      End If
   End Sub


   Private Sub cmdSelectAll_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles cmdSelectAll.DoClik
      For Each elem As System.Windows.Forms.DataGridViewRow In GridOfferte.Rows
         elem.Cells("Selected").Value = True
      Next
      Me.GridOfferte.Refresh()
   End Sub


   Private Sub cmdDeselectAll_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles cmdDeselectAll.DoClik
      For Each elem As System.Windows.Forms.DataGridViewRow In GridOfferte.Rows
         elem.Cells("Selected").Value = False
      Next
      Me.GridOfferte.Refresh()
   End Sub

   Private Sub IdUtenteTextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles IdUtenteTextBox1.Leave
      If Trim(IdUtenteTextBox1.TextValue) = "" Then
         LoadComboWithPreferences(True)
      Else
         LoadComboWithPreferences(False)
      End If
   End Sub
   Private Sub LoadComboWithPreferences(ByVal all As Boolean)
      Try
         If all Then
            Dim controllerSkill As New ControllerAbilita
            InterfaceMediator.LoadCombo(cboPref, controllerSkill.GetListaCausali, False)
         Else
            controllerUtenti.LoadById(IdUtenteTextBox1.TextValue)
            InterfaceMediator.LoadCombo(cboPref, controllerUtenti.GetListaSkillPreferiti, False)
         End If

      Catch ex As Exception
         ErrorHandler.ShowError(ex)
         cboPref.Items.Clear()
      End Try
   End Sub





   Private Sub cmdProp_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles cmdProp.DoClik
      Dim errNumber As Int32 = 0

      If Trim(IdUtenteTextBox1.TextValue) = "" Then
         MsgBox("Selezionare un'utente", MsgBoxStyle.Exclamation, "Selezione utente")
         Exit Sub
      End If


      If cboPref.Text = "" Then
         MsgBox("Selezionare un'offerta", MsgBoxStyle.Exclamation, "Selezione offerte")
         Exit Sub
      End If


      If controllerRicerche.Results.Count = 0 Then Return

      Dim trovato As Boolean = False
      For Each elem As Object In controllerRicerche.Results
         If elem.Selected = True Then
            trovato = True
            Exit For
         End If
      Next

      If trovato = False Then
         MsgBox("Selezionare almeno una domanda", MsgBoxStyle.Exclamation, "Selezione domande")
         Exit Sub
      End If


      For Each elem As Object In controllerRicerche.Results
         Try
            If elem.Selected = True Then
               InserisciProposta(elem)
            End If
         Catch ex As Exception
            errNumber = errNumber + 1
            AddToLog(elem, ex)
         End Try
      Next


      If errNumber = 0 Then
         MsgBox("Proposte generate con successo!", MsgBoxStyle.Information, "Generazione proposte")
      Else
         Dim errorform As New ErrorForm
         errorform.TextBox1.Text = "Numero di errori = " & errNumber
         errorform.TextBox1.Text = errorform.TextBox1.Text & ErrorString
         errorform.ShowDialog()
         ErrorString = ""
         errNumber = 0
      End If

   End Sub
   Private Sub AddToLog(ByVal Offerta As Object, ByVal err As Exception)
      ErrorString = ErrorString & vbCrLf & "--- Errore nell creazione della proposta per la domanda con id " & Offerta.Id & "; (" & err.Message & ")"
   End Sub

   Private Sub InserisciProposta(ByVal Offerta As Object)
      controllerProposte.CreateNew()
      controllerProposte.DataDocumento = DateTime.Now.Date
      controllerProposte.DataRegistrazione = DateTime.Now.Date
      controllerProposte.SetOfferta(Offerta.Id)
      controllerProposte.SetUtente(controllerUtenti.IdUtente)
      controllerProposte.SetAbilita(cboPref.Text)
      controllerProposte.Note = "Proposta automaticamente generata al giorno " & DateTime.Now
      controllerProposte.Save()
   End Sub

   Private Sub cmdPrint_DoClik(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.DoClik
      Try
         Dim print As PrintFacade = New PrintFacade
         print.PrintReportAnalisiOfferteLavoro(controllerRicerche, controllerUtenti)
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try

      'PrintReportOfferteLavoro()
   End Sub


   Private Sub IdAziendaTextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles IdAziendaTextBox1.Leave
      InterfaceMediator.GetSimpleDescription(New AZIENDE.ControllerAziende, "Descrizione", lblDescrizioneAzienda, IdAziendaTextBox1.TextValue)
   End Sub

   Private Sub GridOfferte_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridOfferte.CellContentClick
      If e.RowIndex = -1 Or e.ColumnIndex = -1 Then
         Return
      End If
      If GridOfferte.Columns(e.ColumnIndex).Name = "Selected" Then
         GridOfferte.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Not GridOfferte.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
      End If

   End Sub

   Private Sub GridOfferte_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridOfferte.CellDoubleClick

      If e.RowIndex = -1 Or e.ColumnIndex = -1 Then
         Return
      End If
      If GridOfferte.SelectedCells.Count = 0 Then Return
      If GridOfferte.SelectedCells.Count > 1 Then Return
      Try
         Select Case GridOfferte.Columns(e.ColumnIndex).Name

            Case "Id"
               Navigate(GridOfferte.Rows(e.RowIndex).DataBoundItem.Id, "ViewOfferta")



            Case "AziendaRichiedente"
               Navigate(GridOfferte.Rows(e.RowIndex).DataBoundItem.AziendaRichiedente.Id, "ViewAzienda")


         End Select



      Catch ex As AccessDeniedException
         MsgBox("Impossibile eliminare l'elemento. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Protected Overloads Sub Navigate(ByVal ToId As String, ByVal Link As String)

      Dim ParameterList As Hashtable = New Hashtable
      ParameterList.Add("Id", ToId)
      Me.NavigateTo(Link, ParameterList)

   End Sub



   Private Sub GridOfferte_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GridOfferte.ColumnHeaderMouseClick
      'qui seleziono tutta la colonna
      GridOfferte.ClearSelection()
      For Each elem As DataGridViewColumn In GridOfferte.Columns
         elem.HeaderCell.SortGlyphDirection = SortOrder.None
      Next
      Try
         GridOfferte.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.Descending
         m_selectedColumnName = GridOfferte.Columns(e.ColumnIndex).Name
      Catch ex As Exception
         m_selectedColumnName = ""
      End Try
   End Sub


   Private Sub cmdUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUp.DoClik
      Try
         controllerRicerche.SortItems(m_selectedColumnName)
         ' Me.GridPosizioni.DataSource = controller.SearchResult
         Me.GridOfferte.Refresh()
         GridOfferte.Columns(m_selectedColumnName).HeaderCell.SortGlyphDirection = SortOrder.Descending
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub
   Private Sub cmdDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdDown.DoClik
      Try
         controllerRicerche.SortItems(m_selectedColumnName, True)
         ' Me.GridPosizioni.DataSource = controller.SearchResult
         GridOfferte.Refresh()
         GridOfferte.Columns(m_selectedColumnName).HeaderCell.SortGlyphDirection = SortOrder.Descending
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub


End Class
