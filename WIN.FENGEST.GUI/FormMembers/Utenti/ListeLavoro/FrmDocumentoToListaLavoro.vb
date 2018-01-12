Imports System.Windows.Forms
Imports WIN.GUI.UTILITY

Public Class FrmDocumentoToListaLavoro
    Private Controller As WIN.APPLICATION.REPORTING.ReportIncassiQuote


    Public SearchList As IList


    Private m_listaLavoro As ListaLavoroUtenti



    Public ReadOnly Property ListaLavoro() As ListaLavoroUtenti
        Get
            Return m_listaLavoro
        End Get

    End Property




    Public Sub New()

        ' Chiamata richiesta da Progettazione Windows Form.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        Controller = New WIN.APPLICATION.REPORTING.ReportIncassiQuote



    End Sub



    Public Sub SetSearchConditions()
        Dim tipo As String = IdDocumentoTextBox1.TipoDoc

        If String.IsNullOrEmpty(tipo) Then
            tipo = "IQA"
        End If


        If tipo = "IQA" Then
            Controller.IsIQAIncluded(True)
        End If

        If tipo = "IQI" Then
            Controller.IsIQIIncluded(True)
        End If

        If tipo = "IQV" Then
            Controller.IsIQVIncluded(True)
        End If

        If tipo = "IQP" Then
            Controller.IsIQPIncluded(True)
        End If


        If tipo = "PGR" Then
            IdDocumentoTextBox1.TextValue = ""
            Throw New InvalidOperationException("Selezionare un documento di tipo incasso")

        End If

        Controller.SetDocumento(IdDocumentoTextBox1.TextValue)





    End Sub






    Private Sub SearchAndShowResult()
        Try

            If IdDocumentoTextBox1.TextValue = "" Then
                MsgBox("Selezionare un documento", MsgBoxStyle.Information, "Messaggio")
                Return
            End If


            Helper.ShowWaitBox("Attendere elaborazione report...", My.Resources.Waiting3)


            Me.SetSearchConditions()
            Dim thread As New System.Threading.Thread(AddressOf FillSearchList)
            thread.Start()

            Do While thread.IsAlive = True
                System.Windows.Forms.Application.DoEvents()
            Loop

            System.Windows.Forms.Application.DoEvents()

            If SearchList.Count = 0 Then
                MsgBox("Non ci sono posizioni per i requisiti immessi!", MsgBoxStyle.Information, "Nessuna posizione trovata")
            Else


                'Dim gridLoader As New GridLoaderRptIQ(Me.GridPosizioni)
                'gridLoader.LoadGrid(SearchList)
                GridPosizioni.DataSource = SearchList

            End If




        Catch ex As Exception

            ErrorHandler.ShowError(ex)
        Finally
            Helper.HideWaitBox()
        End Try
    End Sub


    Private Sub FillSearchList()

        SearchList = Controller.Search
    End Sub




    Private Function GetVisuibleRecords() As IList
        Dim l As New ArrayList()
        If GridView1.RowCount > 0 Then
            GridView1.ExpandAllGroups()
        End If
        For i As Integer = 0 To GridView1.RowCount
            Dim handle As Int32 = GridView1.GetVisibleRowHandle(i)
            If (Not GridView1.IsGroupRow(handle)) Then
                Dim a As Quota = DirectCast(GridView1.GetRow(handle), Quota)
                If (a IsNot Nothing) Then
                    l.Add(a)
                End If
            End If
        Next
        Return l
    End Function






    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click



        SearchAndShowResult()
    End Sub

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        Try
            Helper.ShowWaitBox("Creazione lista di lavoro in corso...", My.Resources.Waiting3)
            CalcolaLista()
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        Finally
            Helper.HideWaitBox()
        End Try
    End Sub

    Private Sub CalcolaLista()

        If SearchList Is Nothing Then
            Throw New Exception("Visualizzare il documento prima di richiedere la creazione della lista di lavoro")

        End If

        Dim c As New ReportToListaLavoroConverter

        m_listaLavoro = c.CreaListaDaReportIQ(GetVisuibleRecords)


    End Sub

    Private Sub cmdAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnnulla.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
    'Private Sub GridPosizioni_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs)

    '    Try


    '        'tolgo il glifo da tutte le colonne non selezionate
    '        For Each elem As DataGridViewColumn In GridPosizioni.Columns
    '            If e.ColumnIndex <> elem.Index Then
    '                elem.HeaderCell.SortGlyphDirection = SortOrder.None
    '            End If
    '        Next

    '        'SelectToolStripImage nella colonna non c'è glifo
    '        If GridPosizioni.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.None Then
    '            'm_selectedColumnName = GridPosizioni.Columns(e.ColumnIndex).Name
    '            OrderUp(GridPosizioni.Columns(e.ColumnIndex).Name)
    '            Return
    '        End If


    '        'SelectToolStripImage nella colonna c'è glifo ascending
    '        If GridPosizioni.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.Ascending Then
    '            'm_selectedColumnName = GridPosizioni.Columns(e.ColumnIndex).Name
    '            OrderUp(GridPosizioni.Columns(e.ColumnIndex).Name)
    '            Return
    '        End If


    '        'SelectToolStripImage nella colonna c'è glifo descending
    '        If GridPosizioni.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.Descending Then
    '            ' m_selectedColumnName = 
    '            OrderDown(GridPosizioni.Columns(e.ColumnIndex).Name)
    '            Return
    '        End If

    '    Catch ex As Exception
    '        ErrorHandler.ShowError(ex)
    '    End Try

    'End Sub


    'Private Sub OrderUp(ByVal colonna As String)
    '    Try
    '        Controller.SortItems(colonna)
    '        Me.GridPosizioni.DataSource = Controller.SearchResult
    '        Me.GridPosizioni.Refresh()
    '        GridPosizioni.Columns(colonna).HeaderCell.SortGlyphDirection = SortOrder.Descending
    '    Catch ex As Exception
    '        ErrorHandler.ShowError(ex)
    '    End Try
    'End Sub


    'Private Sub OrderDown(ByVal colonna As String)
    '    Try
    '        Controller.SortItems(colonna, True)
    '        Me.GridPosizioni.DataSource = Controller.SearchResult
    '        Me.GridPosizioni.Refresh()
    '        GridPosizioni.Columns(colonna).HeaderCell.SortGlyphDirection = SortOrder.Ascending
    '    Catch ex As Exception
    '        ErrorHandler.ShowError(ex)
    '    End Try
    'End Sub

End Class