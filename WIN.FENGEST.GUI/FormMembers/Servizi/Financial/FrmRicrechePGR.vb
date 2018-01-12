Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports WIN.GUI.UTILITY
Imports System
Public Class FrmRicrechePGR
    Protected m_startColorVis As System.Drawing.Color = System.Drawing.Color.White
    Protected m_EndColorVis As System.Drawing.Color = System.Drawing.SystemColors.MenuHighlight
    Protected m_startColorUp As System.Drawing.Color = System.Drawing.SystemColors.MenuHighlight
    Protected m_EndColorUp As System.Drawing.Color = System.Drawing.Color.White
    Protected m_startColorCreat As System.Drawing.Color = Drawing.SystemColors.GradientInactiveCaption
    Protected m_EndColorCreat As System.Drawing.Color = Drawing.SystemColors.GradientInactiveCaption

    Protected m_GradientMode As LinearGradientMode = Drawing.Drawing2D.LinearGradientMode.Vertical
    Private m_SelectedColumnName As String = ""
    Private m_IdReferente As String = "-1"
    'Private m_listaPosizioni As IList = New ArrayList
    Private controller As New WIN.APPLICATION.FINANCIAL_ARTIFACTS.ControllerPagamentoReferenti








#Region "Metodi per la gestione del thread di caricamento secondario"
    Dim gridloader As AbstractGridLoader
    Private m_ListaParziale As IList = New ArrayList
    Private m_ListaPosizioni As IList = New ArrayList
    Private contatore As Int32 = 0
    Delegate Sub GuiRefresh()
    Dim deleg As GuiRefresh

    Private Sub GridPosizioni_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles GridPosizioni.DataError
        '
    End Sub

    Private Sub GridPosizioni_Scroll(ByVal sender As Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles GridPosizioni.Scroll

        LazyLoadItems()

    End Sub

    Private Sub LazyLoadItems()
        If m_ListaPosizioni.Count <> m_ListaParziale.Count Then
            Me.lblStatus.Text = "Attendere caricamento delle restanti posizioni..."
            System.Windows.Forms.Application.DoEvents()
            Dim t As New System.Threading.Thread(AddressOf AddItemsToPartialList)
            t.Start()

            Do While t.IsAlive
                System.Threading.Thread.Sleep(100)
                System.Windows.Forms.Application.DoEvents()
            Loop
            Me.lblStatus.Text = "Pronto"
        Else
            Return
        End If
    End Sub
    Private Sub AddFirstItemsToPartialList()
        deleg = New GuiRefresh(AddressOf LoadItems)
        For i As Int32 = contatore To contatore + 60
            If contatore > m_ListaPosizioni.Count - 1 Then
                contatore = 0
                Me.GridPosizioni.Invoke(deleg)
                Exit Sub
            End If
            m_ListaParziale.Add(m_ListaPosizioni.Item(i))
            contatore = contatore + 1
        Next
        Me.GridPosizioni.Invoke(deleg)
        System.Windows.Forms.Application.DoEvents()
    End Sub




    'Qui scrivo l'algoritmo per caricare la lista con 40 elementi la volta
    Private Sub AddItemsToPartialList()

        If contatore = 0 Then Exit Sub
        For i As Int32 = contatore To m_ListaPosizioni.Count - 1
            m_ListaParziale.Add(m_ListaPosizioni.Item(i))
            contatore = contatore + 1
        Next
        deleg = New GuiRefresh(AddressOf LoadItems)
        Me.GridPosizioni.Invoke(deleg)
        contatore = 0
    End Sub


    'Private Sub GridRefresher()
    '   Me.GridPosizioni.DataSource = New ArrayList
    '   Me.GridPosizioni.DataSource = m_ListaParziale
    '   Me.GridPosizioni.Refresh()
    'End Sub




#End Region






















    Private Sub GridPosizioni_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GridPosizioni.ColumnHeaderMouseClick
        'qui seleziono tutta la colonna
        If GridPosizioni.Columns(e.ColumnIndex).Name = "Selezione" Then Exit Sub
        GridPosizioni.ClearSelection()
        For Each elem As DataGridViewColumn In GridPosizioni.Columns
            elem.HeaderCell.SortGlyphDirection = SortOrder.None
        Next
        GridPosizioni.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.Descending
        m_SelectedColumnName = GridPosizioni.Columns(e.ColumnIndex).Name
    End Sub
    Private Sub cmdUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUp.DoClik
        Try
            LazyLoadItems()
            controller.SortItems(m_SelectedColumnName, m_ListaPosizioni)
            GridPosizioni.DataSource = m_ListaPosizioni
            GridPosizioni.Refresh()
            If m_SelectedColumnName = "" Then Exit Sub
            GridPosizioni.Columns(m_SelectedColumnName).HeaderCell.SortGlyphDirection = SortOrder.Descending
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    Private Sub cmdDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdDown.DoClik
        Try
            LazyLoadItems()
            controller.SortItems(m_SelectedColumnName, m_ListaPosizioni, True)
            GridPosizioni.DataSource = m_ListaPosizioni
            GridPosizioni.Refresh()
            If m_SelectedColumnName = "" Then Exit Sub
            GridPosizioni.Columns(m_SelectedColumnName).HeaderCell.SortGlyphDirection = SortOrder.Descending
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    'Protected Overrides Sub OnPaintBackground(ByVal e As System.Windows.Forms.PaintEventArgs)
    '   MyBase.OnPaintBackground(e)
    '   'DrawBackground(e.Graphics, m_startColorVis, m_EndColorVis)
    'End Sub
    'Protected Sub DrawBackground(ByVal Graphics As System.Drawing.Graphics, ByVal StartColor As System.Drawing.Color, ByVal EndColor As System.Drawing.Color)
    '   Try
    '      Dim br As New LinearGradientBrush(Me.ClientRectangle, StartColor, EndColor, m_GradientMode)
    '      ' paint the background.
    '      Graphics.FillRectangle(br, Me.ClientRectangle)
    '      ' orderly destroy the brush.
    '      br.Dispose()
    '   Catch ex As Exception

    '   End Try
    '   ' start/end color and gradient mode

    'End Sub



    Public Sub New(ByVal IdReferente As String)
        InitializeComponent()
        m_IdReferente = IdReferente
        Dim cont As New WIN.APPLICATION.FINANCIAL_ARTIFACTS.ControllerReferenti
        cont.LoadById(m_IdReferente)
        Me.Text = "Selezione posizioni di pagamento per il referente - " & cont.CompleteName
        cont = Nothing
    End Sub
    Public Function GetItemList() As IList
        Dim lista As IList = New ArrayList
        For Each elem As DataGridViewRow In GridPosizioni.Rows
            If elem.Cells("Selezione").Value = True Then
                Dim obj As Object = controller.GetItem(CreateParameterList(elem), m_ListaPosizioni)
                If obj IsNot Nothing Then lista.Add(obj)
            End If
        Next
        Return lista
    End Function
    Private Function CreateParameterList(ByVal Row As DataGridViewRow) As Hashtable
        Dim hash As New Hashtable
        hash.Add("TipoDocumento", Row.Cells("TipoDocumento").Value)
        hash.Add("IdDocPadre", Row.Cells("DocumentoPadre").Value.Id)
        hash.Add("IdUtente", Row.Cells("Utente").Value.IdUtente)
        hash.Add("DataInizio", Row.Cells("Competenza").Value.GetDataRange.Start)
        hash.Add("DataFine", Row.Cells("Competenza").Value.GetDataRange.Finish)
        hash.Add("IdPrestazione", Row.Cells("Prestazione").Value.TipoPrestazione.Id.ToString)
        hash.Add("IdVertenza", Row.Cells("Vertenza").Value.Id.ToString)
        Return hash
    End Function

    Private Sub cmdAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnnulla.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub



    Private Sub CmdVis_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CmdVis.DoClik

        Try
            Helper.ShowWaitBox("Ricerca posizioni in corso...", My.Resources.Waiting3)
            m_ListaParziale = New ArrayList
            m_ListaPosizioni = New ArrayList
            Me.ControlRicerchePGR1.SetInitialSearchConditions(m_IdReferente)
            Me.ControlRicerchePGR1.SetSearchConditions()
            'Eseguo la ricerca su un thread differente
            Dim t As New System.Threading.Thread(AddressOf GetResult)
            t.Start()
            Me.lblStatus.Image = My.Resources.status_anim
            Me.lblStatus.Text = "Atterndere ricerca e ricostruzione posizioni..."
            Do While t.IsAlive
                System.Threading.Thread.Sleep(100)
                System.Windows.Forms.Application.DoEvents()
            Loop
            Me.lblStatus.Image = Nothing
            Me.lblStatus.Text = "Pronto"

            If m_ListaPosizioni.Count = 0 Then
                MsgBox("Non è stata trovata alcuna posizione che soddisfa i requisiti immessi!", MsgBoxStyle.Information, "Nessuna posizione trovata")
                Return
            End If

            'loadItems()
            AddFirstItemsToPartialList()
            Helper.HideWaitBox()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        Finally
            Helper.HideWaitBox()
        End Try


    End Sub

    Private Sub GetResult()
        m_ListaPosizioni = Me.ControlRicerchePGR1.GetControllerRicerche.Search
    End Sub



    Private Sub LoadItems()
        If Me.GridPosizioni.DataSource Is Nothing Then
            LoadGrid(m_ListaParziale)
        Else
            GridPosizioni.DataSource = New ArrayList
            GridPosizioni.DataSource = m_ListaParziale
            GridPosizioni.Refresh()
        End If
    End Sub
    Private Sub LoadGrid(ByVal Lista As IList)
        Dim gridloader As New GridLoaderRicerchePGR(GridPosizioni)
        gridloader.SelectionMode = Windows.Forms.DataGridViewSelectionMode.CellSelect
        gridloader.LoadGrid(Lista)
    End Sub

    Private Sub GridPosizioni_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles GridPosizioni.CellFormatting
        If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("Utente") Then
            If Not e.Value Is Nothing Then
                e.Value = e.Value.ToString
            End If
        End If
        If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("Prestazione") Then
            If Not e.Value Is Nothing Then
                e.Value = e.Value.ToString
            End If
        End If
        If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("TipoPrestazione") Then
            If Not e.Value Is Nothing Then
                e.Value = e.Value.ToString
            End If
        End If
        If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("Vertenza") Then
            If Not e.Value Is Nothing Then
                e.Value = e.Value.ToString
            End If
        End If
    End Sub




    Private Sub cmdDeselectAll_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles cmdDeselectAll.DoClik
        LazyLoadItems()
        For Each elem As System.Windows.Forms.DataGridViewRow In GridPosizioni.Rows
            elem.DataBoundItem.Selezione = False
        Next
        Me.GridPosizioni.Refresh()
    End Sub

    Private Sub cmdSelectAll_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles cmdSelectAll.DoClik
        LazyLoadItems()
        For Each elem As System.Windows.Forms.DataGridViewRow In GridPosizioni.Rows
            elem.DataBoundItem.Selezione = True
        Next
        Me.GridPosizioni.Refresh()
    End Sub
End Class