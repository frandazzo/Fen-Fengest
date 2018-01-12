Imports System.Windows.Forms
Imports System
Imports Microsoft.VisualBasic.ApplicationServices
Imports WIN.SECURITY

Public Class ControlPagamentoQuoteInps
    Private controller As New FINANCIAL_ARTIFACTS.ControllerIncassiQuoteInps
    Private m_SelectedColumnName As String = ""
    Private m_MaxDate As Date = Date.MaxValue
    Private m_MinDate As Date = Date.MinValue



    Private Sub cmdCompetenza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCompetenza.Click
        Dim frm As New frmCompetenza
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            frm.ControlloSelezioneCompetenza1.CalcolaDate()
            Me.txtCompetenza.Text = Format(frm.ControlloSelezioneCompetenza1.MinDate, "dd/MM/yyyy") & " - " & Format(frm.ControlloSelezioneCompetenza1.MaxDate, "dd/MM/yyyy")
            If controller.IsCreated Then controller.SetCompetenza(frm.ControlloSelezioneCompetenza1.MinDate, frm.ControlloSelezioneCompetenza1.MaxDate)
            m_MinDate = frm.ControlloSelezioneCompetenza1.MinDate
            m_MaxDate = frm.ControlloSelezioneCompetenza1.MaxDate
        End If
        frm.Dispose()
    End Sub

    Private Sub cmdAdd_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles cmdAdd.DoClik
        Try
            DisplayPrestazioniFinder()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    Private Sub DisplayPrestazioniFinder()
        Dim frm As New FrmRicercheIQI()
        frm.ShowDialog()
        If frm.DialogResult = DialogResult.OK Then
            If frm.ListaStutturePrestazioni.Count > 0 Then
                AddItemFromListaPrestazioni(frm.ListaStutturePrestazioni)
                LoadGrid()
            End If
        End If
        frm.Dispose()
    End Sub

    Private Sub AddItemFromListaPrestazioni(ByVal Lista As ArrayList)
        For Each elem As FrmRicercheIQI.Prest In Lista
            controller.AddItem(elem.IdUtente, "0", elem.IdReferente, "", m_MinDate, m_MaxDate, elem.IdPrestazione)
        Next
    End Sub
    Private Sub LoadGrid()
        Dim listaPosizioni As IList = controller.ListaPosizioniUtenti
        If GridPosizioni.DataSource Is Nothing Then
            'GridPosizioni.DataSource = New ArrayList
            Dim gridLoader As New GridLoaderNewIQI(Me.GridPosizioni, controller)
            gridLoader.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            gridLoader.LoadGrid(listaPosizioni)
        Else
            Me.GridPosizioni.DataSource = Nothing
            Me.GridPosizioni.DataSource = controller.ListaPosizioniUtenti
            'Me.GridPosizioni.Refresh()
        End If

    End Sub

    Public Sub New()
        InitializeComponent()
        Try
            DoLoad()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub


#Region "Metodo per visualizzare le informazioni di stato  "

    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "" & MyBase.State.StateName & " incasso quota Inps"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "" & MyBase.State.StateName & " incasso quota Inps "
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & " incasso  quota   Inps")
        SelectToolStripImage()
    End Sub
#End Region


#Region "Metodi per la creazione di un nuovo oggetto"
    Protected Overrides Sub Nested_PrepareForCreation()
        Panel1.Visible = False
        Me.TabControl1.Visible = True
        txtTotale.Enabled = False
        Me.GridPosizioni.Visible = False
        Me.CmdCrea.Visible = True
        Me.cmdPrest.Visible = False
        m_MinDate = New DateTime(Today.Year, Today.Month, 1)
        m_MaxDate = New DateTime(Today.Year, Today.Month, Date.DaysInMonth(Today.Year, Today.Month))
        txtCompetenza.Text = Format(m_MinDate, "dd/MM/yyyy") & " - " & Format(m_MaxDate, "dd/MM/yyyy")
        DisplaydataForInps()
        cmdUp.Visible = False
        CmdDown.Visible = False
        cmdDel.Visible = False
        cmdAdd.Visible = False
        Me.txtImporto.Text = "0,00"
        Me.txtAttribuito.Text = "0,00"
        Me.txtTotale.Text = "0,00"
        CustomBar1.SetTargetControl(Me)
    End Sub

    Private Sub DisplaydataForInps()
        Try
            Dim controllerInps As New AZIENDE.ControllerInps
            controllerInps.LoadById(1)
            lblCompUltimo.Text = controllerInps.CompetenzaUltimoPagamento
            controllerInps = Nothing
        Catch ex As Exception
            lblCompUltimo.Text = ""
        End Try
    End Sub
    Private Sub cmdCrea_DoClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCrea.DoClik
        Try
            controller.CreateNew(dtpRegistrazione.Value.Date, Me.dtpDoc.Value.Date, _
                                             Me.txtImporto.Text, Me.txtNote.Text, m_MinDate, _
                                               m_MaxDate)

            'qiu faccio il controllo se esistono pagament sovrapposti
            Dim result As MsgBoxResult = MsgBoxResult.Ok
            If controller.EsistonoIncassiSovrapposti Then
                result = MsgBox("Esistono altri incassi  che si sovrappongono alla competenza indicata! Continuare?", MsgBoxStyle.YesNo + MsgBoxStyle.Information)
                If result = MsgBoxResult.Yes Then
                    PreparaCompilazione()
                Else
                    RitornaAlComandoPrecedente()
                End If
            Else
                PreparaCompilazione()
            End If
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    Private Sub PreparaCompilazione()
        Try
            Panel1.Visible = True
            'If PrepareGridLoading() Then
            txtTotale.Text = controller.Totale
            Me.CmdCrea.Visible = False
            cmdUp.Visible = True
            CmdDown.Visible = True
            cmdDel.Visible = True
            cmdAdd.Visible = True
            Me.cmdPrest.Visible = True
            Me.cmdBlu.BackgroundImage = My.Resources.Flag_grayHS
            Me.cmdRed.BackgroundImage = My.Resources.Flag_redHS
            Me.cmdGreen.BackgroundImage = My.Resources.Flag_grayHS
            Me.GridPosizioni.Visible = True
            DisplayPrestazioniFinder()
            'End If
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
            ParameterList.Add("TipoDocumento", "IQI")
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

        controller.Save()
        MyBase.m_IdShowedObject = controller.IdDocumento

    End Sub
#End Region


#Region "Metodi per l'usabilità  della griglia"
    Private Sub GridPosizioni_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridPosizioni.CellEnter
        Try
            If GridPosizioni.Columns(e.ColumnIndex).Name = "Note" Then
                GridPosizioni.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.SelectionBackColor = Drawing.Color.LightGray
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
        Try
            GridPosizioni.ClearSelection()
            For Each elem As DataGridViewColumn In GridPosizioni.Columns
                elem.HeaderCell.SortGlyphDirection = SortOrder.None
            Next
            GridPosizioni.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.Descending
            m_SelectedColumnName = GridPosizioni.Columns(e.ColumnIndex).Name
        Catch ex As Exception

        End Try

    End Sub
    Private Sub GridPosizioni_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles GridPosizioni.CellBeginEdit
        Try
            controller.SelectItem(GridPosizioni.Rows(e.RowIndex).Cells("Utente").Value.IdUtente, GridPosizioni.Rows(e.RowIndex).Cells("Competenza").Value.GetDataRange.Start, GridPosizioni.Rows(e.RowIndex).Cells("Competenza").Value.GetDataRange.Finish, GridPosizioni.Rows(e.RowIndex).Cells("Prestazione").Value.TipoPrestazione.Id.ToString)
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
                    controller.SelectItem(GridPosizioni.Rows(e.RowIndex).Cells("Utente").Value.IdUtente, GridPosizioni.Rows(e.RowIndex).Cells("Competenza").Value.GetDataRange.Start, GridPosizioni.Rows(e.RowIndex).Cells("Competenza").Value.GetDataRange.Finish, GridPosizioni.Rows(e.RowIndex).Cells("Prestazione").Value.TipoPrestazione.Id.ToString)
                    controller.SetReferenteItem(frm.SelectedId)
                    GridPosizioni.Refresh()
                End If
                frm.Dispose()
            End If

            If GridPosizioni.Columns(e.ColumnIndex).Name = "SelCompetenza" AndAlso Not e.RowIndex = -1 Then
                Dim frm As New frmCompetenza
                frm.ShowDialog()
                If frm.DialogResult = Windows.Forms.DialogResult.OK Then
                    frm.ControlloSelezioneCompetenza1.CalcolaDate()
                    controller.SelectItem(GridPosizioni.Rows(e.RowIndex).Cells("Utente").Value.IdUtente, GridPosizioni.Rows(e.RowIndex).Cells("Competenza").Value.GetDataRange.Start, GridPosizioni.Rows(e.RowIndex).Cells("Competenza").Value.GetDataRange.Finish, GridPosizioni.Rows(e.RowIndex).Cells("Prestazione").Value.TipoPrestazione.Id.ToString)
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
                    e.Value = e.Value.ToString
                End If
            End If


            If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("Prestazione") Then
                If Not e.Value Is Nothing Then
                    'GridPosizioni.Rows(e.RowIndex).Cells("TipoPrestazione").Value = e.Value.TipoPrestazione.Descrizione
                    e.Value = e.Value.Id.ToString
                End If
            End If
            If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("TipoPrestazione") Then
                If Not e.Value Is Nothing Then
                    e.Value = e.Value.ToString
                End If
            End If

            If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("Importo") Then
                If Not e.Value Is Nothing Then
                    GridPosizioni.Rows(e.RowIndex).Cells("ImportoPosizione").Value = CDbl(e.Value.Importo) * -1
                    e.Value = e.Value.GetTipoValutaToString(e.Value.GetValuta)
                End If
            End If



            If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("Competenza") Then
                If Not e.Value Is Nothing Then
                    'GridPosizioni.Rows(e.RowIndex).Cells("DICompetenza").Value = Format(e.Value.GetDataRange.Start, "dd/MM/yyyy")
                    'GridPosizioni.Rows(e.RowIndex).Cells("DFCompetenza").Value = Format(e.Value.GetDataRange.Finish, "dd/MM/yyyy")
                    e.Value = e.Value.ToString
                End If
            End If





        Catch ex As Exception

        End Try
    End Sub


#End Region


#Region "Metodi per l'aggiornamento del pagamento"
    Private Sub txtNote_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNote.TextChanged
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
                    controller.RemoveItem(GridPosizioni.Rows(cell.RowIndex).Cells("Utente").Value.Id, GridPosizioni.Rows(cell.RowIndex).Cells("Competenza").Value.GetDataRange.Start, GridPosizioni.Rows(cell.RowIndex).Cells("Competenza").Value.GetDataRange.Finish, GridPosizioni.Rows(cell.RowIndex).Cells("Prestazione").Value.Id.ToString)
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

    Private Sub cmdPrest_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles cmdPrest.DoClik
        Shell(MasterControl.Instance.GetAppPathWithParameter(New String() {SecurityManager.Instance.CurrentUser.Username, SecurityManager.Instance.CurrentUser.Password}), AppWinStyle.NormalFocus)
    End Sub
End Class
