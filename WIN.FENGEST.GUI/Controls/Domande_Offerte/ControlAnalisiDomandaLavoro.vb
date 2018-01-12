Imports System.Windows.Forms
Imports WIN.SECURITY.Exceptions

Public Class ControlAnalisiDomandaLavoro

   Dim controller As New UTENTI.ControllerRicercheUtenti
   Dim controllerOfferte As New ControllerOfferteLavoro
   Dim controllerabilita As New ControllerAbilita
   Dim controllerProposte As New ControllerProposte()
   Dim ErrorString As String = ""
   'Private WithEvents Controller As New WIN.APPLICATION.REPORTING.ReportIscritti

   Private m_selectedColumnName As String = ""
   Dim frm As FrmElaborazioneInCorso
   Dim list As IList = New ArrayList

    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "Ricerca offerte di lavoro"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Ricerca offerte di lavoro  "
        Me.lblCurrentFunction.Text = UCase("Ricerca offerte di lavoro ")
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.SearchPaint
    End Sub

    Protected Overrides Sub Nested_PostLoadingActions()
        Dim logo As String = "Ricerca offerte di lavoro "
        MasterControl.Instance.ParentForm.Text = logo
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo
        Me.lblCurrentFunction.Text = UCase(logo)
    End Sub


   Private Sub FillSearchList()
      list = controller.Search
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
      MasterControl.Instance.ParentForm.Text = "Ricerca offerte di lavoro"
      MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Ricerca offerte di lavoro  "
      Me.lblCurrentFunction.Text = UCase("Ricerca offerte di lavoro ")
      MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.SearchPaint
   End Sub



   Public Sub New()
      ' Chiamata richiesta da Progettazione Windows Form.
      InitializeComponent()
      ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
      Me.m_IdShowedObject = 0
      DoLoad()
      InitializeGrid()
   End Sub

   Private Sub cmdUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUp.DoClik
      Try
         controller.SortItems(m_selectedColumnName)
         ' Me.GridPosizioni.DataSource = controller.SearchResult
         Me.GridUtenti.Refresh()
         GridUtenti.Columns(m_selectedColumnName).HeaderCell.SortGlyphDirection = SortOrder.Descending
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub
   Private Sub cmdDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdDown.DoClik
      Try
         controller.SortItems(m_selectedColumnName, True)
         ' Me.GridPosizioni.DataSource = controller.SearchResult
         GridUtenti.Refresh()
         GridUtenti.Columns(m_selectedColumnName).HeaderCell.SortGlyphDirection = SortOrder.Descending
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub


   Private Sub cmdCerca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdVis.DoClik

      Try
         If cboSkill.Text = "" Then
            MsgBox("Selezionare una offerta di lavoro", MsgBoxStyle.Exclamation, "Selezione offerte di lavoro")
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
            If GridUtenti.DataSource IsNot Nothing Then
               GridUtenti.DataSource = New ArrayList
            End If
         Else
            LoadGrid(list)
            txtResults.Text = list.Count
         End If

      Catch ex As Exception
         SetGUIPostProcessReport()
         ErrorHandler.ShowError(ex)
      End Try

   End Sub


   Private Sub SetSearchConditions()
      Dim map As New Hashtable
      map.Add("IntervalloDate", False)
      controller.SetIdSkillPreferenza(controllerabilita.GetIdByDescrizione(cboSkill.Text))
      controller.SetSkillPreferenza(cboSkill.Text)
   End Sub

   Private Sub LoadGrid(ByVal Lista As ArrayList)
      If GridUtenti.DataSource Is Nothing Then
         GridUtenti.DataSource = Lista

      Else
         GridUtenti.DataSource = Nothing
         GridUtenti.DataSource = Lista

      End If

      'With GridUtenti


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
      '      '.Columns("CompleteName").Visible = False
      '      .Columns("Conto").Visible = False
      '      .Columns("QuotaMensile").Visible = False
      '      .Columns("Fondo").Visible = False
      '      .Columns("SituazioneFamiliare").Visible = False
      '      .Columns("Path_Foto").Visible = False
      '      .Columns("Segreteria").Visible = False
      '      .Columns("Residenza").Visible = False

      '      .Columns("DirectoryPreferenziale").Visible = False
      '      .Columns("CodiceFiscale").Visible = False

      '      .Columns("Id").Visible = False
      '      .Columns("Comunicazione").Visible = False
      '      .Columns("DataNascita").Visible = False
      '      .Columns("Nazionalita").Visible = False
      '      .Columns("ProvinciaNascita").Visible = False
      '      .Columns("ComuneNascita").Visible = False
      '      .Columns("Sesso").Visible = False
      '      .Columns("ArchivioDocumenti").Visible = False





      '      '.Columns("Deleghe").Visible = False

      '      .Columns("Selected").Visible = True
      '      .Columns("Selected").HeaderText = "Seleziona"
      '      .Columns("Selected").DisplayIndex = 0

      '      '.Columns("IdUtente").HeaderText = "Id"
      '      .Columns("IdUtente").Visible = False
      '      '.Columns("IdUtente").ReadOnly = True
      '      '.Columns("IdUtente").DisplayIndex = 1

      '      .Columns("Cognome").Visible = False
      '      .Columns("Nome").Visible = False

      '      .Columns("CompleteName").Visible = True
      '      .Columns("CompleteName").HeaderText = "Utente"
      '      .Columns("CompleteName").CellTemplate.Style.Font = New Font(.Columns("CompleteName").DataGridView.Font, FontStyle.Underline)
      '      .Columns("CompleteName").CellTemplate.Style.ForeColor = SystemColors.ActiveCaption
      '      .Columns("CompleteName").ReadOnly = True
      '      .Columns("CompleteName").DisplayIndex = 2

      '      .Columns("DataNascita").Visible = True
      '      .Columns("DataNascita").ReadOnly = True
      '      .Columns("DataNascita").DisplayIndex = 3

      '      .Columns("ComuneNascita").Visible = False

      '      '.Columns("ComuneNascita").HeaderText = "Comune di nascita"
      '      '.Columns("ComuneNascita").ReadOnly = True
      '      '.Columns("ComuneNascita").DisplayIndex = 4


      '.SelectionMode = DataGridViewSelectionMode.CellSelect
      '.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing
      '.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells


      '   End If
      'End With


   End Sub


   Private Sub InitializeGrid()
      GridUtenti.Columns.Clear()

      GridUtenti.AutoGenerateColumns = False

      Dim colAb As DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
      colAb.Name = "Selected"
      colAb.ReadOnly = False
      colAb.HeaderText = "Seleziona"
      colAb.DataPropertyName = "Selected"
      colAb.TrueValue = True
      colAb.FalseValue = False
      GridUtenti.Columns.Add(colAb)

      Dim colAg As DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
      colAg.Name = "CompleteName"
      colAg.ReadOnly = True
      colAg.HeaderText = "Utente"
      colAg.DataPropertyName = "CompleteName"
      colAg.CellTemplate.Style.Font = New Font(GridUtenti.Font, FontStyle.Underline)
      colAg.CellTemplate.Style.ForeColor = SystemColors.ActiveCaption

      GridUtenti.Columns.Add(colAg)


     
      GridUtenti.SelectionMode = DataGridViewSelectionMode.CellSelect
      GridUtenti.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing
      GridUtenti.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

   End Sub

   Private Sub cmdSelectAll_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles cmdSelectAll.DoClik
      For Each elem As System.Windows.Forms.DataGridViewRow In GridUtenti.Rows
         elem.Cells("Selected").Value = True
      Next
      Me.GridUtenti.Refresh()
   End Sub


   Private Sub cmdDeselectAll_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles cmdDeselectAll.DoClik
      For Each elem As System.Windows.Forms.DataGridViewRow In GridUtenti.Rows
         elem.Cells("Selected").Value = False
      Next
      Me.GridUtenti.Refresh()
   End Sub

   Private Sub IdOffertaTextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles IdOffertaTextBox1.Leave
      If Trim(IdOffertaTextBox1.TextValue) = "" Then
         LoadComboWithSkills(True)
      Else
         LoadComboWithSkills(False)
      End If

   End Sub
   Private Sub LoadComboWithSkills(ByVal all As Boolean)
      Try
         If all Then
            Dim controllerSkill As New ControllerAbilita
            InterfaceMediator.LoadCombo(cboSkill, controllerSkill.GetListaCausali, False)
         Else
            controllerOfferte.LoadById(IdOffertaTextBox1.TextValue)
            InterfaceMediator.LoadCombo(cboSkill, controllerOfferte.GetListaSkill, False)
         End If

      Catch ex As Exception
         ErrorHandler.ShowError(ex)
         cboSkill.Items.Clear()
      End Try
   End Sub

   Private Sub cmdProp_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles cmdProp.DoClik
      Dim errNumber As Int32 = 0

      If Trim(IdOffertaTextBox1.TextValue) = "" Then
         MsgBox("Selezionare una domanda di lavoro", MsgBoxStyle.Exclamation, "Selezione domanda di lavoro")
         Exit Sub
      End If


      If cboSkill.Text = "" Then
         MsgBox("Selezionare una offerta di lavoro", MsgBoxStyle.Exclamation, "Selezione offerte di lavoro")
         Exit Sub
      End If


      Dim trovato As Boolean = False
      For Each elem As Object In controller.Results
         If elem.Selected = True Then
            trovato = True
            Exit For
         End If
      Next

      If trovato = False Then
         MsgBox("Selezionare almeno un utente", MsgBoxStyle.Exclamation, "Selezione utenti")
         Exit Sub
      End If

      If controller.Results.Count = 0 Then Return

      For Each elem As Object In controller.Results
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
   Private Sub AddToLog(ByVal Utente As Object, ByVal err As Exception)
      ErrorString = ErrorString & vbCrLf & "--- Errore nell creazione della proposta per l'utente " & Utente.CompleteName & "; (" & err.Message & ")"
   End Sub

   Private Sub InserisciProposta(ByVal Utente As Object)

      controllerOfferte.LoadById(IdOffertaTextBox1.TextValue)


      controllerProposte.CreateNew()
      controllerProposte.DataDocumento = DateTime.Now.Date
      controllerProposte.DataRegistrazione = DateTime.Now.Date

      controllerProposte.SetOfferta(controllerOfferte.IdOfferta)
      controllerProposte.SetUtente(Utente.Id)
      controllerProposte.SetAbilita(cboSkill.Text)
      controllerProposte.Note = "Proposta automaticamente generata al giorno " & DateTime.Now
      controllerProposte.Save()
   End Sub



   Private Sub cmdListaLavoro_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles cmdListaLavoro.DoClik
      Try


         Dim frm As New FrmDescrListaLavoro
         frm.ShowDialog()
         Dim descr As String = frm.Descrizione

         If frm.DialogResult = DialogResult.OK Then
            Dim controllerListe As New ControllerListaUtenti
            controllerListe.CreateNew()
            controllerListe.Descrizione = descr

            For Each elem As Object In controller.Results
               If elem.Selected Then
                  controllerListe.AddUtente(elem.IdUtente)
               End If
            Next
            controllerListe.Save()
            MsgBox("Lista creata con successo!", MsgBoxStyle.Information, "Creazione lista lavoro utenti")
         End If

      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Private Sub cmdPrint_DoClik(ByVal Sender As System.Object, ByVal e As System.EventArgs)
      Try
         Dim print As PrintFacade = New PrintFacade
         print.PrintReportAnalisiDomandeLavoro(controller, controllerOfferte.IdOfferta)
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

    Protected Overrides Sub Nested_PrepareLoading()
        LoadComboWithSkills(True)
    End Sub

   Private Sub GridUtenti_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridUtenti.CellContentClick
      If e.RowIndex = -1 Or e.ColumnIndex = -1 Then
         Return
      End If
      If GridUtenti.Columns(e.ColumnIndex).Name = "Selected" Then
         GridUtenti.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = Not GridUtenti.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
      End If
      ' elem.Cells("Selected").Value = True
   End Sub

   Private Sub GridUtenti_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GridUtenti.CellMouseDoubleClick
      If e.RowIndex = -1 Or e.ColumnIndex = -1 Then
         Return
      End If
      If GridUtenti.SelectedCells.Count = 0 Then Return
      If GridUtenti.SelectedCells.Count > 1 Then Return
      Try
         Select Case GridUtenti.Columns(e.ColumnIndex).Name

            Case "CompleteName"
               Navigate(GridUtenti.Rows(e.RowIndex).DataBoundItem.Id, "ViewUtente")

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

   Private Sub GridUtenti_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GridUtenti.ColumnHeaderMouseClick
      'qui seleziono tutta la colonna
      GridUtenti.ClearSelection()
      For Each elem As DataGridViewColumn In GridUtenti.Columns
         elem.HeaderCell.SortGlyphDirection = SortOrder.None
      Next
      Try
         GridUtenti.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.Descending
         m_selectedColumnName = GridUtenti.Columns(e.ColumnIndex).Name
      Catch ex As Exception
         m_selectedColumnName = ""
      End Try
   End Sub
End Class
