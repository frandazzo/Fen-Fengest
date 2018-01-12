Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Imports WIN.GUI.UTILITY
Imports System

Public Class FrmRicercheIQI
    Private m_ListaStruct As New ArrayList
    Protected m_startColorVis As System.Drawing.Color = System.Drawing.Color.White
    Protected m_EndColorVis As System.Drawing.Color = System.Drawing.SystemColors.MenuHighlight
    Protected m_startColorUp As System.Drawing.Color = System.Drawing.SystemColors.MenuHighlight
    Protected m_EndColorUp As System.Drawing.Color = System.Drawing.Color.White
    Protected m_startColorCreat As System.Drawing.Color = Drawing.SystemColors.GradientInactiveCaption
    Protected m_EndColorCreat As System.Drawing.Color = Drawing.SystemColors.GradientInactiveCaption

    Protected m_GradientMode As LinearGradientMode = Drawing.Drawing2D.LinearGradientMode.Vertical
    Private m_SelectedColumnName As String = ""
    Private m_listaPosizioni As IList = New ArrayList
    'Private controller As New WIN.APPLICATION.FINANCIAL_ARTIFACTS.ControllerPagamentoReferenti
    Private Sub FrmRicercheIQI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ControlRicercheIQI1.LoadChoises()
    End Sub

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
    'Private Sub cmdUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUp.DoClik
    '   Try
    '      controller.SortItems(m_SelectedColumnName, m_listaPosizioni)
    '      GridPosizioni.DataSource = m_listaPosizioni
    '      GridPosizioni.Refresh()
    '      If m_SelectedColumnName = "" Then Exit Sub
    '      GridPosizioni.Columns(m_SelectedColumnName).HeaderCell.SortGlyphDirection = SortOrder.Descending
    '   Catch ex As Exception
    '      ErrorHandler.ShowError(ex)
    '   End Try
    'End Sub
    'Private Sub cmdDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdDown.DoClik
    '   Try
    '      controller.SortItems(m_SelectedColumnName, m_listaPosizioni, True)
    '      GridPosizioni.DataSource = m_listaPosizioni
    '      GridPosizioni.Refresh()
    '      If m_SelectedColumnName = "" Then Exit Sub
    '      GridPosizioni.Columns(m_SelectedColumnName).HeaderCell.SortGlyphDirection = SortOrder.Descending
    '   Catch ex As Exception
    '      ErrorHandler.ShowError(ex)
    '   End Try
    'End Sub
    Protected Overrides Sub OnPaintBackground(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaintBackground(e)
        'DrawBackground(e.Graphics, m_startColorVis, m_EndColorVis)
    End Sub
    Protected Sub DrawBackground(ByVal Graphics As System.Drawing.Graphics, ByVal StartColor As System.Drawing.Color, ByVal EndColor As System.Drawing.Color)
        Try
            Dim br As New LinearGradientBrush(Me.ClientRectangle, StartColor, EndColor, m_GradientMode)
            ' paint the background.
            Graphics.FillRectangle(br, Me.ClientRectangle)
            ' orderly destroy the brush.
            br.Dispose()
        Catch ex As Exception

        End Try
        ' start/end color and gradient mode
    End Sub




    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub cmdAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnnulla.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click

        FillStructList()
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
    Private Sub FillStructList()
        Try
            Helper.ShowWaitBox("Aggiunta posizioni in corso...", My.Resources.Waiting3)
            m_ListaStruct = New ArrayList
            For Each elem As DataGridViewRow In GridPosizioni.Rows
                If elem.Cells("Selezione").Value = True Then
                    Dim struct As Prest = Nothing
                    struct.IdPrestazione = elem.Cells("Id").Value
                    struct.IdUtente = elem.Cells("Utente").Value.Id.ToString
                    struct.IdReferente = elem.Cells("Referente").Value.Id.ToString
                    m_ListaStruct.Add(struct)
                End If
            Next
            Helper.HideWaitBox()
        Catch ex As Exception
            Helper.HideWaitBox()
            Throw

        End Try

        'Return lista
    End Sub


    Private Sub CmdVis_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CmdVis.DoClik
        Try
            Helper.ShowWaitBox("Ricerca posizioni in corso...", My.Resources.Waiting3)
            Me.ControlRicercheIQI1.SetSearchConditions()
            m_listaPosizioni = Me.ControlRicercheIQI1.GetControllerRicerche.Search
            If m_listaPosizioni.Count = 0 Then MsgBox("Non è stata trovata alcuna prestazione che soddisfa i requisiti immessi!", MsgBoxStyle.Information, "Nessuna prestazione trovata")
            loadItems()
            Helper.HideWaitBox()
        Catch ex As Exception
            Helper.HideWaitBox()
            ErrorHandler.ShowError(ex)
        End Try

    End Sub


    Private Sub loadItems()
        If Me.GridPosizioni.DataSource Is Nothing Then
            LoadGrid(m_listaPosizioni)
        Else
            Me.GridPosizioni.DataSource = m_listaPosizioni
            GridPosizioni.Refresh()
        End If
    End Sub
    Private Sub LoadGrid(ByVal Lista As IList)
        Dim gridloader As New GridLoaderRicercheIQI(GridPosizioni)
        gridloader.SelectionMode = Windows.Forms.DataGridViewSelectionMode.CellSelect
        gridloader.LoadGrid(Lista)
    End Sub

    Private Sub GridPosizioni_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles GridPosizioni.CellFormatting
        Try
            If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("Utente") Then
                If Not e.Value Is Nothing Then
                    e.Value = e.Value.ToString
                End If
            End If
            'Try
            If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("Selezione") Then
                If e.Value Is Nothing Then
                    e.Value = False
                End If
            End If
            'If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("TipoPrestazione") Then
            '   If Not e.Value Is Nothing Then
            '      e.Value = e.Value.ToString
            '   End If
            'End If
            'Catch ex As Exception

            'End Try

            If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("TipoPrestazione") Then
                If Not e.Value Is Nothing Then

                    'GridPosizioni.Rows(e.RowIndex).Cells("IdTipoPrestazione").Value = e.Value.Id
                    e.Value = e.Value.Descrizione
                End If
            End If


            'If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("Referente") Then
            '   If Not e.Value Is Nothing Then
            '      If e.Value.Cognome = "" Then 'referente nullo 
            '         e.Value = ""
            '      Else
            '         e.Value = e.Value.CompleteName
            '      End If
            '   End If
            'End If
        Catch ex As Exception
            Throw New Exception("Errore nella formattazione delle celle della griglia." & vbCrLf & ex.Message)
        End Try
    End Sub
    Public Structure Prest
        Public IdUtente As String
        Public IdPrestazione As String
        Public IdReferente As String
    End Structure




    Public ReadOnly Property ListaStutturePrestazioni() As ArrayList
        Get
            Return m_ListaStruct
        End Get
    End Property

    Private Sub cmdDeselectAll_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles cmdDeselectAll.DoClik
        For Each elem As System.Windows.Forms.DataGridViewRow In GridPosizioni.Rows
            elem.Cells("Selezione").Value = False
        Next
        Me.GridPosizioni.Refresh()
    End Sub

    Private Sub cmdSelectAll_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles cmdSelectAll.DoClik
        For Each elem As System.Windows.Forms.DataGridViewRow In GridPosizioni.Rows
            elem.Cells("Selezione").Value = True
        Next
        Me.GridPosizioni.Refresh()
    End Sub


End Class
