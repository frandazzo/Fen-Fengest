Imports System.Windows.Forms
Public Class ControlPagamentoReferenti
    Private WithEvents controller As New FINANCIAL_ARTIFACTS.ControllerPagamentoReferenti
    Private ControlRic As New FINANCIAL_ARTIFACTS.ControllerRicercheItems
    Private m_SelectedColumnName As String = ""
    Private frm As FrmRicrechePGR
    Dim lista As IList = New ArrayList
    Delegate Sub GuiRefresher()
    Dim deleg As GuiRefresher
    Dim numberOfElement As Int32


    Public Sub New()
        InitializeComponent()
        Try
            DoLoad()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

#Region "Metodi per la notifica delle barre di stato e per il recupero delle descrizioni"
    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "" & MyBase.State.StateName & " pagamento collaboratori comunali"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "" & MyBase.State.StateName & " pagamento collaboratori comunali "
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "   pagamento   collaboratori comunali")
        SelectToolStripImage()
    End Sub
    Private Sub IdReferenteTextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles IdReferenteTextBox1.Leave
        Try
            Dim cont As New WIN.APPLICATION.FINANCIAL_ARTIFACTS.ControllerReferenti
            cont.LoadById(Me.IdReferenteTextBox1.TextValue)
            lblReferente.Text = cont.CompleteName
            Me.GrpSogg.Visible = True
            cont = Nothing
        Catch ex As Exception
            Me.lblReferente.Text = ""
            Me.GrpSogg.Visible = False
        End Try
    End Sub

#End Region



#Region "Metodi per la preparazione e definizione dei layout "
    Protected Overrides Sub Nested_PrepareForCreation()
        Me.TabControl1.Visible = True
        'Me.SearcTab.Visible = True
        Me.GridPosizioni.Visible = False
        txtImporto.Enabled = False
        Me.CustomBar1.SetTargetControl(Me)
        cmdUp.Visible = False
        CmdDown.Visible = False
        cmdAdd.Visible = False
        cmdDel.Visible = False
        GrpSogg.Visible = False
        Panel1.Visible = False
        'cmdRed.Visible = False
        'cmdGreen.Visible = False
        'cmdBlu.Visible = False
        txtTotale.Text = "0,00"
        txtAttribuito.Text = "0,00"
        'lblTotale.Visible = False
        'lblAttribuito.Visible = False
        'lblTot.Visible = False
        'lblAtt.Visible = False
    End Sub
    Private Sub SetCreationLayout()
        'Me.ControlRicerchePGR1.Visible = False
        Me.IdReferenteTextBox1.Enabled = False
        cmdUp.Visible = True
        CmdDown.Visible = True
        cmdAdd.Visible = True
        cmdDel.Visible = True
        GrpSogg.Visible = True
        CmdCrea.Visible = False
        Panel1.Visible = True
        'lblCrea.Visible = False
        'cmdRed.Visible = True
        'cmdGreen.Visible = True
        'cmdBlu.Visible = True
        'txtTotale.Visible = True
        'txtAttribuito.Visible = True
        'lblTotale.Visible = True
        'lblAttribuito.Visible = True
        'lblTot.Visible = True
        'lblAtt.Visible = True
    End Sub
#End Region


#Region "Metodi per la navigazione"
    Private Sub RitornaAlComandoPrecedente()
        Try
            MasterControl.Instance.GoPrevious()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Protected Overrides Sub Navigate()
        Try
            Dim ParameterList As Hashtable = New Hashtable
            ParameterList.Add("Id", m_IdShowedObject)
            ParameterList.Add("TipoDocumento", "PGR")
            Me.NavigateTo("ViewDocumento", ParameterList)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
#End Region

    '#Region "Metodi per la selezione dei criteri di ricerca"
    '   Private Function GetListByCriteria() As IList
    '      Me.ControlRicerchePGR1.SetInitialSearchConditions(Me.IdReferenteTextBox1.TextValue)
    '      Me.ControlRicerchePGR1.SetSearchConditions()
    '      Return Me.ControlRicerchePGR1.GetControllerRicerche.Search
    '   End Function
    '#End Region


#Region "Metodi per creare l'oggetto e gestirlo e inserirlo"
    Private Sub CmdCrea_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CmdCrea.DoClik
        Try
            controller.CreateNew(Me.dtpRegistrazione.Value, Me.dtpDoc.Value, Me.txtNote.Text, Me.IdReferenteTextBox1.TextValue)
            'Dim List As IList = GetListByCriteria()
            'controller.SetListaPosizioniDaRistornare(List)
            'LoadGrid(List)
            'CorrectImporto()
            ProcessNewItems()
            SetCreationLayout()
        Catch ex As Exception
            If ex.Message = "Non ci sono posizioni da pagare." Then
                If MsgBox(ex.Message & vbCrLf & "Si desidera proseguire con un'altra ricerca o abbandonare la transazione?", MsgBoxStyle.YesNo + MsgBoxStyle.Information) = MsgBoxResult.Yes Then
                    'preparo un nuovo pagamento
                    Me.NavigateWithoutHistoryTo("CreateRistorno")
                Else
                    RitornaAlComandoPrecedente()
                End If
                Exit Sub
            End If
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    Public Overrides Sub Nested_InsertData()
        Try
            controller.Save()
            MyBase.m_IdShowedObject = controller.IdDocumento
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
#End Region




#Region "metodi per la gestione della griglia"
    Private Sub LoadGrid(ByVal Lista As IList)
        Dim gridLoader As New GridLoaderNewPGR(Me.GridPosizioni)
        gridLoader.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        gridLoader.LoadGrid(Lista)
    End Sub

    Private Sub GridPosizioni_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridPosizioni.CellEndEdit
        Try
            If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("ImpRist") Then
                controller.SetImportoItem(GridPosizioni.Rows(e.RowIndex).Cells("ImpRist").Value)
                Me.txtImporto.Text = controller.Importo
                'GridPosizioni.DataSource = New ArrayList
                'GridPosizioni.DataSource = controller.ListaDTOPosizioni
                GridPosizioni.Refresh()
                CorrectImporto()
            End If
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    Private Sub GridPosizioni_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles GridPosizioni.CellBeginEdit
        Try
            controller.SelectItem(GridPosizioni.Rows(e.RowIndex).Cells("Utente").Value.IdUtente, GridPosizioni.Rows(e.RowIndex).Cells("Competenza").Value.GetDataRange.Start, GridPosizioni.Rows(e.RowIndex).Cells("Competenza").Value.GetDataRange.Finish, GridPosizioni.Rows(e.RowIndex).Cells("DocumentoPadre").Value.Id, GridPosizioni.Rows(e.RowIndex).Cells("TipoDocumento").Value, GridPosizioni.Rows(e.RowIndex).Cells("Prestazione").Value.Id.ToString)
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    Private Sub GridPosizioni_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles GridPosizioni.CellFormatting
        Try
            If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("Utente") Then
                If Not e.Value Is Nothing Then
                    'GridPosizioni.Rows(e.RowIndex).Cells("IdUtente").Value = e.Value.IdUtente
                    e.Value = e.Value.ToString
                End If
            End If
            If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("TipoPrestazione") Then
                If Not e.Value Is Nothing Then
                    'GridPosizioni.Rows(e.RowIndex).Cells("IdUtente").Value = e.Value.IdUtente
                    e.Value = e.Value.ToString
                End If
            End If
            If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("Prestazione") Then
                If Not e.Value Is Nothing Then
                    'GridPosizioni.Rows(e.RowIndex).Cells("IdUtente").Value = e.Value.IdUtente
                    e.Value = e.Value.ToString
                End If
            End If
            If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("Vertenza") Then
                If Not e.Value Is Nothing Then
                    'GridPosizioni.Rows(e.RowIndex).Cells("IdUtente").Value = e.Value.IdUtente
                    e.Value = e.Value.ToString
                End If
            End If
            'If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("SoggettoEsecutore") Then
            '   If Not e.Value Is Nothing Then
            '      e.Value = e.Value.Descrizione
            '   End If
            'End If
            'If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("PagamentoReferente") Then
            '   If Not e.Value Is Nothing Then
            '      If e.Value.Id = -1 Then 'documento nullo 
            '         e.Value = ""
            '      Else
            '         e.Value = e.Value.Id
            '      End If
            '   End If
            'End If
            'If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("DocumentoPadre") Then
            '   If Not e.Value Is Nothing Then
            '      If e.Value.Id = -1 Then 'documento nullo 
            '         e.Value = ""
            '      Else
            '         e.Value = e.Value.Id
            '      End If
            '   End If
            'End If
            'If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("Referente") Then
            '   If Not e.Value Is Nothing Then
            '      If e.Value.Cognome = "" Then 'referente nullo 
            '         e.Value = ""
            '      Else
            '         e.Value = e.Value.CompleteName
            '      End If
            '   End If
            'End If

            'If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("Competenza") Then
            '   If Not e.Value Is Nothing Then
            '      'GridPosizioni.Rows(e.RowIndex).Cells("DICompetenza").Value = Format(e.Value.GetDataRange.Start, "dd/MM/yyyy")
            '      'GridPosizioni.Rows(e.RowIndex).Cells("DFCompetenza").Value = Format(e.Value.GetDataRange.Finish, "dd/MM/yyyy")
            '      e.Value = e.Value.ToString
            '   End If
            'End If


            'If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("Importo") Then
            '   If Not e.Value Is Nothing Then
            '      e.Value = CStr(CDbl(e.Value.importo) * -1) & " " & e.Value.GetTipoValutaToString(e.Value.GetValuta)
            '   End If
            'End If

            'If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("ImportoRistorno") Then
            '   If Not e.Value Is Nothing Then
            '      'GridPosizioni.Rows(e.RowIndex).Cells("ImpRist").Value = e.Value.Importo
            '      e.Value = "Euro"
            '   End If
            'End If
            'Try
            '   If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("Prestazione") Then
            '      If Not e.Value Is Nothing Then
            '         If Not GridPosizioni.Columns("TipoPrestazione") Is Nothing Then
            '            GridPosizioni.Rows(e.RowIndex).Cells("TipoPrestazione").Value = e.Value.TipoPrestazione.Descrizione
            '         End If
            '         If e.Value.Id.ToString = -1 Then
            '            e.Value = ""
            '         Else
            '            e.Value = e.Value.Id.ToString
            '         End If

            '      End If
            '   End If
            'Catch ex As Exception

            'End Try
            'If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("Vertenza") Then
            '   If Not e.Value Is Nothing Then
            '      If e.Value.Id.ToString = -1 Then
            '         e.Value = ""
            '      Else
            '         e.Value = e.Value.Id.ToString
            '      End If
            '   End If
            'End If

            'If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("GetCompetenza") Then
            '   If Not e.Value Is Nothing Then
            '      e.Value = e.Value.ToString
            '   End If
            'End If




        Catch ex As Exception
            Throw New Exception("Errore nella formattazione delle celle della griglia." & vbCrLf & ex.Message)
        End Try
    End Sub
    Private Sub GridPosizioni_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GridPosizioni.ColumnHeaderMouseClick
        'qui seleziono tutta la colonna
        GridPosizioni.ClearSelection()
        For Each elem As DataGridViewColumn In GridPosizioni.Columns
            elem.HeaderCell.SortGlyphDirection = SortOrder.None
        Next
        GridPosizioni.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.Descending
        m_SelectedColumnName = GridPosizioni.Columns(e.ColumnIndex).Name
    End Sub
#End Region





#Region "Funzionalità sulle posizioni"
    Private Sub cmdUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUp.DoClik
        Try
            controller.SortItems(m_SelectedColumnName)
            controller.CreateListaDto()
            GridPosizioni.DataSource = controller.ListaDTOPosizioni
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
            controller.CreateListaDto()
            GridPosizioni.DataSource = controller.ListaDTOPosizioni
            GridPosizioni.Refresh()
            If m_SelectedColumnName = "" Then Exit Sub
            GridPosizioni.Columns(m_SelectedColumnName).HeaderCell.SortGlyphDirection = SortOrder.Descending
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.DoClik
        Try
            If GridPosizioni.SelectedRows.Count = 0 Then Throw New Exception("Per eliminare una posizione selezionare una posizione")
            If GridPosizioni.SelectedRows.Count > 1 Then Throw New Exception("Per eliminare una posizione selezionare una posizione")
            Dim cell As System.Windows.Forms.DataGridViewCell = GridPosizioni.SelectedCells(0)
            If MsgBox("Sicuro di voler eliminare la posizione?", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Eliminazione posizione incasso") = MsgBoxResult.Yes Then
                controller.RemoveItem(GridPosizioni.SelectedRows(0).Cells("Utente").Value.IdUtente, GridPosizioni.SelectedRows(0).Cells("Competenza").Value.GetDataRange.Start, GridPosizioni.SelectedRows(0).Cells("Competenza").Value.GetDataRange.Finish, GridPosizioni.SelectedRows(0).Cells("DocumentoPadre").Value.Id, GridPosizioni.SelectedRows(0).Cells("TipoDocumento").Value, GridPosizioni.SelectedRows(0).Cells("Prestazione").Value.Id.ToString)
                CorrectImporto()
                GridPosizioni.DataSource = New ArrayList
                GridPosizioni.DataSource = controller.ListaDTOPosizioni
                GridPosizioni.Refresh()
            End If
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.DoClik
        Try

            ProcessNewItems()

        Catch ex As Exception

            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    Private Sub ProcessNewItems()

        frm = New FrmRicrechePGR(Me.IdReferenteTextBox1.TextValue)

        frm.ShowDialog()
        If frm.DialogResult = DialogResult.OK Then


            Dim t As System.Threading.Thread = New Threading.Thread(AddressOf SetDocumentData)
            t.Start()


            MasterControl.Instance.ParentForm.Text = "Attendere recupero informazioni ..."
            MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Attendere recupero informazioni ..."
            MasterControl.Instance.Current.SetLabelForCurrentFunction(UCase(" Attendere  recupero  informazioni ..."))
            MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.status_anim


            Do While t.IsAlive
                'Threading.Thread.Sleep(100)
                System.Windows.Forms.Application.DoEvents()
            Loop


            Nested_NotifyParent()

        End If
        frm.Dispose()
    End Sub
    Private Sub SetDocumentData()
        Dim start As Int32 = Environment.TickCount

        lista = frm.GetItemList
        System.Diagnostics.Debug.WriteLine("Get list from form: ms " & Environment.TickCount - start)

        If lista.Count = 0 Then
            MsgBox("Nessun elemento selezionato!", MsgBoxStyle.Information, "FenealGest")
            frm.Dispose()
            Return
        End If

        start = Environment.TickCount
        'Li aggiungo al documento
        controller.AddItem(lista)
        System.Diagnostics.Debug.WriteLine("Add items to document: ms " & Environment.TickCount - start)


        start = Environment.TickCount
        'Visualizzo la lista
        deleg = New GuiRefresher(AddressOf ReloadGrid)
        Me.GridPosizioni.Invoke(deleg)
        System.Diagnostics.Debug.WriteLine("Load grid: ms " & Environment.TickCount - start)

        'Correggo la visualizzazione degli importi
        deleg = New GuiRefresher(AddressOf CorrectImporto)
        Me.Invoke(deleg)

    End Sub

    Private Sub controller_ItemAddedd(ByVal number As Integer) Handles controller.ItemAddedd
        numberOfElement = number
        deleg = New GuiRefresher(AddressOf UpdateToolStripLabel)
        MasterControl.Instance.GetMdi.ToolStrip.Invoke(deleg)
    End Sub

    Private Sub UpdateToolStripLabel()
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Attendere recupero informazioni per il record " & numberOfElement & " di " & lista.Count
        System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub ReloadGrid()

        Me.GridPosizioni.Visible = True
        If Me.GridPosizioni.DataSource Is Nothing Then
            LoadGrid(controller.ListaDTOPosizioni)
        Else
            Me.GridPosizioni.DataSource = New ArrayList
            Me.GridPosizioni.DataSource = controller.ListaDTOPosizioni
            Me.GridPosizioni.Refresh()
        End If
    End Sub

#End Region


#Region "Metodi per la custombar"
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
#End Region




#Region "Metodi per la corretta visualizzazione dell'importo"
    Private Sub CorrectImporto()
        Try
            txtTotale.Text = controller.Importo
            Me.txtAttribuito.Text = controller.Importo
            txtImporto.Text = controller.Importo
            SetBandierine()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    Private Sub SetBandierine()
        If controller.Importo > 0 Then
            Me.cmdGreen.BackgroundImage = My.Resources.Flag_greenHS
            Me.cmdRed.BackgroundImage = My.Resources.Flag_grayHS
            Me.cmdBlu.BackgroundImage = My.Resources.Flag_grayHS
        Else
            Me.cmdGreen.BackgroundImage = My.Resources.Flag_grayHS
            Me.cmdRed.BackgroundImage = My.Resources.Flag_redHS
            Me.cmdBlu.BackgroundImage = My.Resources.Flag_grayHS
        End If
    End Sub
#End Region



    Private Sub GridPosizioni_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridPosizioni.CellLeave

    End Sub

    Private Sub GridPosizioni_CellValuePushed(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellValueEventArgs) Handles GridPosizioni.CellValuePushed
        GridPosizioni.DataSource = New ArrayList
        GridPosizioni.DataSource = controller.ListaDTOPosizioni
        GridPosizioni.Refresh()
    End Sub

    Private Sub txtNote_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNote.TextChanged

    End Sub



End Class
