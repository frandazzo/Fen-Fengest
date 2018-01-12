Imports System.Windows.Forms
Imports WIN.GUI.UTILITY

Public Class FrmReportIQToListaLavoro

    Private Controller As WIN.APPLICATION.REPORTING.ReportIncassiQuote
    Private controllersettori As ControllerSettori
    Private controllerContratti As ControllerTipoContratto
    Private m_listaUtenti As ArrayList
    Private controllerEnti As AZIENDE.ControllerEntiBilaterali
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
        controllersettori = New ControllerSettori
        controllerContratti = New ControllerTipoContratto
        m_listaUtenti = New ArrayList
        controllerEnti = New AZIENDE.ControllerEntiBilaterali

        PrepareLoading()
    End Sub



    Public Sub SetSearchConditions()

        Controller.IsIQAIncluded(Me.chkIQA.Checked)
        Controller.IsIQIIncluded(Me.chkIQI.Checked)
        Controller.IsIQVIncluded(Me.chkIQV.Checked)
        Controller.IsIQPIncluded(Me.chkIQP.Checked)

        Dim parameterMap As New Hashtable
        parameterMap.Add("IntervalloRegistrazione", chkReg.Checked)
        parameterMap.Add("IntervalloDocumento", chkDoc.Checked)
        parameterMap.Add("ListaSoggetti", chkSogg.Checked)
        If Not Me.chkComp.Enabled Then
            parameterMap.Add("CompetenzaQuote", False)
        Else
            parameterMap.Add("CompetenzaQuote", chkComp.Checked)
        End If


        Me.ControlSelPeriodiMensili1.CalcolaDate()
        Controller.SetCompetenzaIncassiQuote(Me.ControlSelPeriodiMensili1.MinDate, Me.ControlSelPeriodiMensili1.MaxDate)
        Controller.SetDataDocumentoRange(dtpDocDa.Value.Date, dtpDocA.Value.Date)
        Controller.SetDataRegistrazioneRange(dtpRegDa.Value.Date, dtpRegA.Value.Date)
        Controller.SetListaUtenti(m_listaUtenti)
        Controller.SetSettore(cboSettori.Text)
        Controller.SetContratto(cboContratti.Text)
        Controller.SetAzienda(Me.IdAziendaTextBox1.TextValue)
        Controller.SetEnte(cboEnti.Text)
        Controller.SetReferenteId(Me.IdReferenteTextBox1.TextValue)
        If Me.optAll.Checked Then
            Controller.SetInclusioneItemRistornate(REPORTING.ReportIncassiQuote.TipoInclusioneItemRistornate.Tutto)
        ElseIf Me.optNo.Checked Then
            Controller.SetInclusioneItemRistornate(REPORTING.ReportIncassiQuote.TipoInclusioneItemRistornate.NonRistornate)
        Else
            Controller.SetInclusioneItemRistornate(REPORTING.ReportIncassiQuote.TipoInclusioneItemRistornate.Ristornate)
        End If


        Controller.SetAziendaImpiego(IdAziendaTextBox2.TextValue)


        Controller.SetNewSerchConditions(parameterMap)
    End Sub



    Public Sub PrepareLoading()
        Me.lblDescrizioneAzienda.Text = ""
        Me.lblDescrizioneReferente.Text = ""
        chkReg.Checked = True
        chkDoc.Checked = True
        chkComp.Checked = False
        chkSogg.Checked = False
        dtpRegDa.Enabled = True
        dtpRegDa.Value = dtpRegDa.Value.AddYears(-1)
        dtpRegA.Enabled = True
        dtpDocDa.Enabled = True
        dtpDocDa.Value = dtpDocDa.Value.AddYears(-1)
        dtpDocA.Enabled = True
        'dtpCompDa.Enabled = False
        'dtpCompA.Enabled = False
        Me.ControlSelPeriodiMensili1.Enabled = False
        Me.cmdUt.Enabled = False
        InterfaceMediator.LoadCombo(cboContratti, controllerContratti.GetListaContratti, True)
        InterfaceMediator.LoadCombo(cboSettori, controllersettori.GetListaSettori, True)
        InterfaceMediator.LoadCombo(cboEnti, controllerEnti.GetListaEnti, True)
    End Sub


    Private Sub chkReg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkReg.CheckedChanged
        If chkReg.Checked = True Then
            dtpRegDa.Enabled = True
            dtpRegA.Enabled = True
        Else
            dtpRegDa.Enabled = False
            dtpRegA.Enabled = False
        End If
    End Sub

    Private Sub chkDoc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDoc.CheckedChanged
        If chkDoc.Checked = True Then
            dtpDocDa.Enabled = True
            dtpDocA.Enabled = True
        Else
            dtpDocDa.Enabled = False
            dtpDocA.Enabled = False
        End If
    End Sub

    Private Sub chkComp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkComp.CheckedChanged
        If chkComp.Checked = True Then
            'dtpCompDa.Enabled = True
            'dtpCompA.Enabled = True
            Me.ControlSelPeriodiMensili1.Enabled = True
        Else
            'dtpCompDa.Enabled = False
            'dtpCompA.Enabled = False
            Me.ControlSelPeriodiMensili1.Enabled = False
        End If
    End Sub

    Private Sub chkSogg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSogg.CheckedChanged
        If chkSogg.Checked Then
            Me.cmdUt.Enabled = True
        Else
            Me.cmdUt.Enabled = False
        End If
    End Sub


    Private Sub cboSettori_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSettori.SelectedIndexChanged

        If cboSettori.Text = "" Then
            InterfaceMediator.LoadCombo(cboContratti, controllerContratti.GetListaContratti, True)
        Else
            InterfaceMediator.LoadCombo(cboContratti, controllerContratti.GetListaContrattiByIdSettore(controllersettori.GetIdSettoreByDescrizione(cboSettori.Text)), True)
        End If
        SetVisualizzazioneDelega()
    End Sub

    Private Sub IdAziendaTextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles IdAziendaTextBox1.Leave
        Dim cont As New AZIENDE.ControllerAziende
        InterfaceMediator.GetSimpleDescription(cont, "Descrizione", Me.lblDescrizioneAzienda, Me.IdAziendaTextBox1.TextValue)
    End Sub

    Private Sub IdReferenteTextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles IdReferenteTextBox1.Leave
        Dim cont As New FINANCIAL_ARTIFACTS.ControllerReferenti
        InterfaceMediator.GetSimpleDescription(cont, "CompleteName", Me.lblDescrizioneReferente, Me.IdReferenteTextBox1.TextValue)
    End Sub

    Private Sub chkIQA_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIQA.CheckedChanged
        If Me.chkIQA.Checked Or Me.chkIQP.Checked And chkIQI.Checked = False And chkIQV.Checked = False Then
            Me.chkComp.Enabled = True
            Me.cboContratti.Enabled = True
            Me.cboSettori.Enabled = True
            Me.IdAziendaTextBox1.Enabled = True
            Me.cboEnti.Enabled = True
        ElseIf Me.chkIQA.Checked Or Me.chkIQP.Checked And chkIQI.Checked = False And chkIQV.Checked Then
            Me.chkComp.Enabled = False
            Me.cboContratti.Enabled = False
            Me.cboSettori.Enabled = False
            Me.IdAziendaTextBox1.Enabled = False
            Me.cboEnti.Enabled = False

        ElseIf Me.chkIQA.Checked Or Me.chkIQP.Checked And chkIQI.Checked And chkIQV.Checked = False Then
            Me.chkComp.Enabled = True
            Me.cboContratti.Enabled = False
            Me.cboSettori.Enabled = False
            Me.IdAziendaTextBox1.Enabled = False
            Me.cboEnti.Enabled = False
        ElseIf Me.chkIQA.Checked Or Me.chkIQP.Checked And chkIQI.Checked And chkIQV.Checked Then
            Me.chkComp.Enabled = False
            Me.cboContratti.Enabled = False
            Me.cboSettori.Enabled = False
            Me.IdAziendaTextBox1.Enabled = False
            Me.cboEnti.Enabled = False
        ElseIf Me.chkIQA.Checked = False Or Me.chkIQP.Checked = False And chkIQI.Checked And chkIQV.Checked Then
            Me.chkComp.Enabled = False
            Me.cboContratti.Enabled = False
            Me.cboSettori.Enabled = False
            Me.IdAziendaTextBox1.Enabled = False
            Me.cboEnti.Enabled = False
        ElseIf Me.chkIQA.Checked = False Or Me.chkIQP.Checked = False And chkIQI.Checked And chkIQV.Checked = False Then
            Me.chkComp.Enabled = True
            Me.cboContratti.Enabled = False
            Me.cboSettori.Enabled = False
            Me.IdAziendaTextBox1.Enabled = False
            Me.cboEnti.Enabled = False
        Else
            Me.chkComp.Enabled = False
            Me.cboContratti.Enabled = False
            Me.cboSettori.Enabled = False
            Me.IdAziendaTextBox1.Enabled = False
            Me.cboEnti.Enabled = False
        End If
    End Sub

    Private Sub chkIQV_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIQV.CheckedChanged
        If Me.chkIQA.Checked And chkIQI.Checked = False And chkIQV.Checked = False Then
            Me.chkComp.Enabled = True
            Me.cboContratti.Enabled = True
            Me.cboSettori.Enabled = True
            Me.IdAziendaTextBox1.Enabled = True
            Me.cboEnti.Enabled = True
        ElseIf Me.chkIQA.Checked And chkIQI.Checked = False And chkIQV.Checked Then
            Me.chkComp.Enabled = False
            Me.cboContratti.Enabled = False
            Me.cboSettori.Enabled = False
            Me.IdAziendaTextBox1.Enabled = False
            Me.cboEnti.Enabled = False

        ElseIf Me.chkIQA.Checked And chkIQI.Checked And chkIQV.Checked = False Then
            Me.chkComp.Enabled = True
            Me.cboContratti.Enabled = False
            Me.cboSettori.Enabled = False
            Me.IdAziendaTextBox1.Enabled = False
            Me.cboEnti.Enabled = False
        ElseIf Me.chkIQA.Checked And chkIQI.Checked And chkIQV.Checked Then
            Me.chkComp.Enabled = False
            Me.cboContratti.Enabled = False
            Me.cboSettori.Enabled = False
            Me.IdAziendaTextBox1.Enabled = False
            Me.cboEnti.Enabled = False
        ElseIf Me.chkIQA.Checked = False And chkIQI.Checked And chkIQV.Checked Then
            Me.chkComp.Enabled = False
            Me.cboContratti.Enabled = False
            Me.cboSettori.Enabled = False
            Me.IdAziendaTextBox1.Enabled = False
            Me.cboEnti.Enabled = False
        ElseIf Me.chkIQA.Checked = False And chkIQI.Checked And chkIQV.Checked = False Then
            Me.chkComp.Enabled = True
            Me.cboContratti.Enabled = False
            Me.cboSettori.Enabled = False
            Me.IdAziendaTextBox1.Enabled = False
            Me.cboEnti.Enabled = False
        Else
            Me.chkComp.Enabled = False
            Me.cboContratti.Enabled = False
            Me.cboSettori.Enabled = False
            Me.IdAziendaTextBox1.Enabled = False
            Me.cboEnti.Enabled = False
        End If
    End Sub

    Private Sub chkIQI_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIQI.CheckedChanged
        If Me.chkIQA.Checked And chkIQI.Checked = False And chkIQV.Checked = False Then
            Me.chkComp.Enabled = True
            Me.cboContratti.Enabled = True
            Me.cboSettori.Enabled = True
            Me.IdAziendaTextBox1.Enabled = True
            Me.cboEnti.Enabled = True
        ElseIf Me.chkIQA.Checked And chkIQI.Checked = False And chkIQV.Checked Then
            Me.chkComp.Enabled = False
            Me.cboContratti.Enabled = False
            Me.cboSettori.Enabled = False
            Me.IdAziendaTextBox1.Enabled = False
            Me.cboEnti.Enabled = False

        ElseIf Me.chkIQA.Checked And chkIQI.Checked And chkIQV.Checked = False Then
            Me.chkComp.Enabled = True
            Me.cboContratti.Enabled = False
            Me.cboSettori.Enabled = False
            Me.IdAziendaTextBox1.Enabled = False
            Me.cboEnti.Enabled = False
        ElseIf Me.chkIQA.Checked And chkIQI.Checked And chkIQV.Checked Then
            Me.chkComp.Enabled = False
            Me.cboContratti.Enabled = False
            Me.cboSettori.Enabled = False
            Me.IdAziendaTextBox1.Enabled = False
            Me.cboEnti.Enabled = False
        ElseIf Me.chkIQA.Checked = False And chkIQI.Checked And chkIQV.Checked Then
            Me.chkComp.Enabled = False
            Me.cboContratti.Enabled = False
            Me.cboSettori.Enabled = False
            Me.IdAziendaTextBox1.Enabled = False
            Me.cboEnti.Enabled = False
        ElseIf Me.chkIQA.Checked = False And chkIQI.Checked And chkIQV.Checked = False Then
            Me.chkComp.Enabled = True
            Me.cboContratti.Enabled = False
            Me.cboSettori.Enabled = False
            Me.IdAziendaTextBox1.Enabled = False
            Me.cboEnti.Enabled = False
        Else
            Me.chkComp.Enabled = False
            Me.cboContratti.Enabled = False
            Me.cboSettori.Enabled = False
            Me.IdAziendaTextBox1.Enabled = False
            Me.cboEnti.Enabled = False
        End If
    End Sub


    Private Sub SetVisualizzazioneDelega()
        lblDescrizioneAzienda.Visible = False
        IdAziendaTextBox1.Visible = False
        cboEnti.Visible = False
        If cboSettori.Text = "" Then
            lblDescrizioneAzienda.Visible = True
            IdAziendaTextBox1.Visible = True
            Exit Sub
        End If
        If controllersettori.IsSettoreEdile(cboSettori.Text) Then
            cboEnti.Visible = True
        Else
            lblDescrizioneAzienda.Visible = True
            IdAziendaTextBox1.Visible = True
        End If
    End Sub



    Private Sub SearchAndShowResult()
        Try


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
    Private Sub FillSearchList()

        SearchList = Controller.Search
    End Sub




    Private Sub chkIQP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIQP.CheckedChanged
        If Me.chkIQA.Checked Or Me.chkIQP.Checked And chkIQI.Checked = False And chkIQV.Checked = False Then
            Me.chkComp.Enabled = True
            Me.cboContratti.Enabled = True
            Me.cboSettori.Enabled = True
            Me.IdAziendaTextBox1.Enabled = True
            Me.cboEnti.Enabled = True
        ElseIf Me.chkIQA.Checked Or Me.chkIQP.Checked And chkIQI.Checked = False And chkIQV.Checked Then
            Me.chkComp.Enabled = False
            Me.cboContratti.Enabled = False
            Me.cboSettori.Enabled = False
            Me.IdAziendaTextBox1.Enabled = False
            Me.cboEnti.Enabled = False

        ElseIf Me.chkIQA.Checked Or Me.chkIQP.Checked And chkIQI.Checked And chkIQV.Checked = False Then
            Me.chkComp.Enabled = True
            Me.cboContratti.Enabled = False
            Me.cboSettori.Enabled = False
            Me.IdAziendaTextBox1.Enabled = False
            Me.cboEnti.Enabled = False
        ElseIf Me.chkIQA.Checked Or Me.chkIQP.Checked And chkIQI.Checked And chkIQV.Checked Then
            Me.chkComp.Enabled = False
            Me.cboContratti.Enabled = False
            Me.cboSettori.Enabled = False
            Me.IdAziendaTextBox1.Enabled = False
            Me.cboEnti.Enabled = False
        ElseIf Me.chkIQA.Checked = False Or Me.chkIQP.Checked = False And chkIQI.Checked And chkIQV.Checked Then
            Me.chkComp.Enabled = False
            Me.cboContratti.Enabled = False
            Me.cboSettori.Enabled = False
            Me.IdAziendaTextBox1.Enabled = False
            Me.cboEnti.Enabled = False
        ElseIf Me.chkIQA.Checked = False Or Me.chkIQP.Checked = False And chkIQI.Checked And chkIQV.Checked = False Then
            Me.chkComp.Enabled = True
            Me.cboContratti.Enabled = False
            Me.cboSettori.Enabled = False
            Me.IdAziendaTextBox1.Enabled = False
            Me.cboEnti.Enabled = False
        Else
            Me.chkComp.Enabled = False
            Me.cboContratti.Enabled = False
            Me.cboSettori.Enabled = False
            Me.IdAziendaTextBox1.Enabled = False
            Me.cboEnti.Enabled = False
        End If
    End Sub










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
            Throw New Exception("Visualizzare il report prima di richiedere la creazione della lista di lavoro")
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