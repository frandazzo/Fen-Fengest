Imports System.Windows.Forms
Imports WIN.GUI.UTILITY

Public Class FrmReportDelegheToListaLavoro
    Private Controller As New WIN.APPLICATION.REPORTING.ReportDeleghe
    Dim controllersettori As New ControllerSettori
    Dim controllerReparti As New ControllerReparti
    Dim controllerContratti As New ControllerTipoContratto
    Dim controllerCausali As New ControllerCausaliSottoscrizione
    Private m_listaAziende As New ArrayList
    Dim controllerEnti As New AZIENDE.ControllerEntiBilaterali
    Dim SearchList As IList


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
        PrepareLoading()
    End Sub
    Protected Sub PrepareLoading()
        Me.lblCons.Text = ""
        Me.lblDescrizioneReferente.Text = ""
        'chkReg.Checked = False
        'chkDoc.Checked = False
        chkSogg.Checked = False
        'dtpRegDa.Enabled = False
        'dtpRegA.Enabled = False
        'dtpDocDa.Enabled = False
        'dtpDocA.Enabled = False
        chkReg.Checked = True
        chkDoc.Checked = True
        dtpRegDa.Enabled = True
        dtpRegDa.Value = dtpRegDa.Value.AddYears(-1)
        dtpRegA.Enabled = True
        dtpDocDa.Enabled = True
        dtpDocDa.Value = dtpDocDa.Value.AddYears(-1)
        dtpDocA.Enabled = True


        'chkSelDataInoltro.Enabled = False
        'chkSelDataAcc.Enabled = False
        'chkSelDataAnn.Enabled = False
        'chkSelDataAtt.Enabled = False
        'chkSelDataRev.Enabled = False

        dtpInDa.Enabled = False
        dtpInA.Enabled = False
        dtpAccDa.Enabled = False
        dtpAccA.Enabled = False
        dtpAttDa.Enabled = False
        dtpAttA.Enabled = False
        dtpAnnDa.Enabled = False
        dtpAnnA.Enabled = False
        dtpRevDa.Enabled = False
        dtpRevA.Enabled = False



        'dtpCompDa.Enabled = False
        'dtpCompA.Enabled = False

        Me.cmdUt.Enabled = False
        'InterfaceMediator.LoadCombo(cboContratti, controllerContratti.GetListaContratti, True)
        InterfaceMediator.LoadCombo(cboContratti, controllerContratti.GetListaContrattiByIdSettore(1), True)
        InterfaceMediator.LoadCombo(cboSettori, controllersettori.GetListaSettori, False)
        InterfaceMediator.LoadCombo(cboEnti, controllerEnti.GetListaEnti, False)
        InterfaceMediator.LoadCombo(cboReparto, controllerReparti.GetListaCausali, True)
        InterfaceMediator.LoadCombo(cboCaus, controllerCausali.GetListaCausali, True)
    End Sub
    Public Sub SetSearchConditions()



        Dim parameterMap As New Hashtable
        parameterMap.Add("IntervalloRegistrazione", chkReg.Checked)
        parameterMap.Add("IntervalloDocumento", chkDoc.Checked)

        parameterMap.Add("IntervalloInoltro", chkSelDataInoltro.Checked)
        parameterMap.Add("IntervalloAccettazione", chkSelDataAcc.Checked)
        parameterMap.Add("IntervalloAttivazione", chkSelDataAtt.Checked)
        parameterMap.Add("IntervalloAnnullamento", chkSelDataAnn.Checked)
        parameterMap.Add("IntervalloRevoca", chkSelDataRev.Checked)
        parameterMap.Add("ListaAziende", chkSogg.Checked)







        Controller.SetDataDocumentoRange(dtpDocDa.Value.Date, dtpDocA.Value.Date)
        Controller.SetDataRegistrazioneRange(dtpRegDa.Value.Date, dtpRegA.Value.Date)

        Controller.SetDataInoltroRange(dtpInDa.Value.Date, dtpInA.Value.Date)
        Controller.SetDataAccettazioneRange(dtpAccDa.Value.Date, dtpAccA.Value.Date)
        Controller.SetDataAttivazioneRange(dtpAttDa.Value.Date, dtpAttA.Value.Date)
        Controller.SetDataAnnullamentoRange(dtpAnnDa.Value.Date, dtpAnnA.Value.Date)
        Controller.SetDataRevocaRange(dtpRevDa.Value.Date, dtpRevA.Value.Date)


        Controller.SetDelegheSottoscritte(chkSottoscritta.Checked)
        Controller.SetDelegheInoltrate(chkInoltrata.Checked)
        Controller.SetDelegheAccettate(chkAccettata.Checked)
        Controller.SetDelegheAttivate(chkAttivata.Checked)
        Controller.SetDelegheAnnullate(chkAnnullata.Checked)
        Controller.SetDelegheRevocate(chkRevocata.Checked)

        Controller.SetSettore(cboSettori.Text)
        Controller.SetListaAziende(m_listaAziende)

        Controller.SetContratto(cboContratti.Text)
        Controller.SetCausaleSottoscrizione(cboCaus.Text)
        Controller.SetReparto(cboReparto.Text)
        Controller.SetEnte(cboEnti.Text)

        Controller.SetReferenteId(Me.IdReferenteTextBox1.TextValue)
        Controller.SetResponsabileId(Me.IdReferenteTextBox2.TextValue)


        Controller.SetNewSerchConditions(parameterMap)
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

    Private Sub chkSelDataInoltro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSelDataInoltro.CheckedChanged
        If chkSelDataInoltro.Checked = True Then
            dtpInA.Enabled = True
            dtpInDa.Enabled = True
        Else
            dtpInA.Enabled = False
            dtpInDa.Enabled = False
        End If
    End Sub



    Private Sub chkSogg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSogg.CheckedChanged
        If chkSogg.Checked Then
            Me.cmdUt.Enabled = True
        Else
            Me.cmdUt.Enabled = False
        End If
    End Sub

    Private Sub cmdSogg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUt.Click
        Dim frm As New FrmSelezionaId
        frm.SetTipoRicerca(ControlloListeIDs.SearchType.Aziende, m_listaAziende)
        frm.ShowDialog()
        If frm.DialogResult = Windows.Forms.DialogResult.OK Then
            m_listaAziende = frm.ControlloListeIDs1.GetListId
            If m_listaAziende.Count = 0 Then
                lblSogg.Text = ""
            Else
                lblSogg.Text = "Lista aziende impostata"
            End If
        End If
        frm.Dispose()
    End Sub



    Private Sub cboSettori_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSettori.SelectedIndexChanged
        If cboSettori.Text <> "EDILE" Then
            cboReparto.Enabled = True
            cboContratti.Enabled = True
            chkSogg.Enabled = True
            If chkSogg.Checked Then
                cmdUt.Enabled = True
            Else
                cmdUt.Enabled = False
            End If
            cboEnti.Text = ""
            cboEnti.Enabled = False
        Else
            cboContratti.Text = ""
            cboReparto.Text = ""
            cboReparto.Enabled = False
            cboContratti.Enabled = False
            chkSogg.Enabled = False
            cmdUt.Enabled = False
            cboEnti.Text = ""
            cboEnti.Enabled = True
        End If




    End Sub

    Private Sub IdReferenteTextBox2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles IdReferenteTextBox2.Leave
        Dim cont As New FINANCIAL_ARTIFACTS.ControllerReferenti
        InterfaceMediator.GetSimpleDescription(cont, "CompleteName", Me.lblCons, Me.IdReferenteTextBox2.TextValue)
    End Sub

    Private Sub IdReferenteTextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles IdReferenteTextBox1.Leave
        Dim cont As New FINANCIAL_ARTIFACTS.ControllerReferenti
        InterfaceMediator.GetSimpleDescription(cont, "CompleteName", Me.lblDescrizioneReferente, Me.IdReferenteTextBox1.TextValue)
    End Sub


    Private Sub SearchData()
        Try

            Helper.ShowWaitBox("Attendere elaborazione report...", My.Resources.Waiting3)

            Me.SetSearchConditions()
            Dim thread As New System.Threading.Thread(AddressOf FillSearchList)
            thread.Start()

            Do While thread.IsAlive = True
                System.Windows.Forms.Application.DoEvents()
            Loop

            System.Windows.Forms.Application.DoEvents()
            If SearchList.Count > 0 Then
                'Dim gridLoader As New GridLoaderRptDeleghe(Me.GridPosizioni)
                'gridLoader.LoadGrid(SearchList)
                GridPosizioni.DataSource = SearchList
            Else
                MsgBox("Non ci sono posizioni per i requisiti immessi!", MsgBoxStyle.Information, "Nessuna posizione trovata")
            End If

            Helper.HideWaitBox()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        Finally
            Helper.HideWaitBox()
        End Try
    End Sub
    Private Sub FillSearchList()

        SearchList = Controller.Search
    End Sub


    Private Sub chkSelDataAcc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSelDataAcc.CheckedChanged
        If chkSelDataAcc.Checked = True Then
            dtpAccA.Enabled = True
            dtpAccDa.Enabled = True
        Else
            dtpAccA.Enabled = False
            dtpAccDa.Enabled = False
        End If
    End Sub

    Private Sub chkSelDataAtt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSelDataAtt.CheckedChanged
        If chkSelDataAtt.Checked = True Then
            dtpAttA.Enabled = True
            dtpAttDa.Enabled = True
        Else
            dtpAttA.Enabled = False
            dtpAttDa.Enabled = False
        End If
    End Sub

    Private Sub chkSelDataAnn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSelDataAnn.CheckedChanged
        If chkSelDataAnn.Checked = True Then
            dtpAnnA.Enabled = True
            dtpAnnDa.Enabled = True
        Else
            dtpAnnA.Enabled = False
            dtpAnnDa.Enabled = False
        End If
    End Sub

    Private Sub chkSelDataRev_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSelDataRev.CheckedChanged
        If chkSelDataRev.Checked = True Then
            dtpRevA.Enabled = True
            dtpRevDa.Enabled = True
        Else
            dtpRevA.Enabled = False
            dtpRevDa.Enabled = False
        End If
    End Sub

    Private Sub chkInoltrata_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkInoltrata.CheckedChanged
        'If chkInoltrata.Checked = True Then
        '    chkSelDataInoltro.Enabled = True
        'Else
        '    chkSelDataInoltro.Enabled = False
        'End If
    End Sub

    Private Sub chkAccettata_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAccettata.CheckedChanged
        'If chkAccettata.Checked = True Then
        '    chkSelDataAcc.Enabled = True
        'Else
        '    chkSelDataAcc.Enabled = False
        'End If
    End Sub

    Private Sub chkAttivata_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAttivata.CheckedChanged
        'If chkAttivata.Checked = True Then
        '    chkSelDataAtt.Enabled = True
        'Else
        '    chkSelDataAtt.Enabled = False
        'End If
    End Sub

    Private Sub chkAnnullata_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAnnullata.CheckedChanged
        'If chkAnnullata.Checked = True Then
        '    chkSelDataAnn.Enabled = True
        'Else
        '    chkSelDataAnn.Enabled = False
        'End If
    End Sub

    Private Sub chkRevocata_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRevocata.CheckedChanged
        'If chkRevocata.Checked = True Then
        '    chkSelDataRev.Enabled = True
        'Else
        '    chkSelDataRev.Enabled = False
        'End If
    End Sub







    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        SearchData()
    End Sub

    Private Sub cmdAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnnulla.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
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

        m_listaLavoro = c.CreaListaDaReportDeleghe(GetVisuibleRecords)


    End Sub
    Private Function GetVisuibleRecords() As IList
        Dim l As New ArrayList()
        If GridView1.RowCount > 0 Then
            GridView1.ExpandAllGroups()
        End If
        For i As Integer = 0 To GridView1.RowCount
            Dim handle As Int32 = GridView1.GetVisibleRowHandle(i)
            If (Not GridView1.IsGroupRow(handle)) Then
                Dim a As DelegadTO = DirectCast(GridView1.GetRow(handle), DelegadTO)
                If (a IsNot Nothing) Then
                    l.Add(a)
                End If
            End If
        Next
        Return l
    End Function
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
    '        'Me.GridPosizioni.DataSource = controller.SearchResult
    '        Me.GridPosizioni.Refresh()
    '        GridPosizioni.Columns(colonna).HeaderCell.SortGlyphDirection = SortOrder.Descending
    '    Catch ex As Exception
    '        ErrorHandler.ShowError(ex)
    '    End Try
    'End Sub


    'Private Sub OrderDown(ByVal colonna As String)
    '    Try
    '        Controller.SortItems(colonna, True)
    '        'Me.GridPosizioni.DataSource = controller.SearchResult
    '        Me.GridPosizioni.Refresh()
    '        GridPosizioni.Columns(colonna).HeaderCell.SortGlyphDirection = SortOrder.Ascending
    '    Catch ex As Exception
    '        ErrorHandler.ShowError(ex)
    '    End Try
    'End Sub

End Class