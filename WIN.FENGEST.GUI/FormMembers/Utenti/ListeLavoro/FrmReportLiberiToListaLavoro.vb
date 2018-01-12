Imports System.Windows.Forms
Imports WIN.GUI.UTILITY

Public Class FrmReportLiberiToListaLavoro


    Private WithEvents Controller As New WIN.APPLICATION.REPORTING.ReportLiberi
    Dim controllersettori As New ControllerSettori
    Dim controllerContratti As New ControllerTipoContratto
    'Dim controllerReparti As New ControllerReparti
    Dim frm As FrmElaborazioneInCorso
    Dim list As IList = New ArrayList

    Private Const NoSelection As String = "Nessuna selezione"
    Private Const ZeroCodes As String = "Codici 0"

    Public Sub New()

        ' Chiamata richiesta da Progettazione Windows Form.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        PrepareLoading()

    End Sub



    Private m_listaLavoro As ListaLavoroUtenti
    Public ReadOnly Property ListaLavoro() As ListaLavoroUtenti
        Get
            Return m_listaLavoro
        End Get
    End Property
    Protected Sub PrepareLoading()
        Me.lblDescrizioneAzienda.Text = ""
        Dim controllerEnti As New AZIENDE.ControllerEntiBilaterali
        InterfaceMediator.LoadCombo(cboEnti, controllerEnti.GetListaEnti, False)
        ' InterfaceMediator.LoadCombo(cboReparto, controllerReparti.GetListaCausali, True)



        InterfaceMediator.LoadCombo(Me.cboNazione, GeoLocationFacade.Instance.GetListaNazioni, True)
        Me.cboNazione.Text = My.Settings.NazioneDefault



        LoadComboComuni(GeoLocationFacade.Instance.GetListaComuniPerProvincia(My.Settings.ComuneDefault))
        LoadComboProvincie(GeoLocationFacade.Instance.GetListaProvincie)
        Me.cboProvincia.Text = My.Settings.ProvinciaDefault
        Me.cboComune.Text = My.Settings.ComuneDefault


        LoadComboIscritti()

    End Sub

    Private Sub LoadComboIscritti()
        cboIscrittoA.Items.Add(NoSelection)
        cboIscrittoA.Items.Add(ZeroCodes)
        cboIscrittoA.Items.Add("FILCA")
        cboIscrittoA.Items.Add("FILLEA")
        cboIscrittoA.SelectedIndex = 0
    End Sub


    Private Sub LoadComboProvincie(ByVal Lista As ArrayList)

        cboProvincia.Items.Clear()
        For Each elem As String In Lista
            cboProvincia.Items.Add(elem)
        Next
        cboProvincia.Sorted = True
        cboProvincia.Items.Add("")
    End Sub

    Private Sub LoadComboComuni(ByVal Lista As ArrayList)

        cboComune.Items.Clear()
        For Each elem As String In Lista
            cboComune.Items.Add(elem)
        Next
        cboComune.Sorted = True
        cboComune.Items.Add("")

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
        If list Is Nothing Then
            Throw New Exception("Visualizzare il report prima di richiedere la creazione della lista di lavoro")
        End If
        Dim c As New ReportToListaLavoroConverter

        m_listaLavoro = c.CreaListaDaReportNonIscritti(GetVisuibleRecords)


    End Sub



    Private Sub IdAziendaTextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles IdAziendaTextBox1.Leave
        Dim cont As New AZIENDE.ControllerAziende
        InterfaceMediator.GetSimpleDescription(cont, "Descrizione", Me.lblDescrizioneAzienda, Me.IdAziendaTextBox1.TextValue)
    End Sub

    Public Sub SetSearchConditions()

        Me.ControlSelPeriodiMensili1.CalcolaDate()
        Controller.SetEnte(cboEnti.Text)
        Controller.SetCompetenza(Me.ControlSelPeriodiMensili1.MinDate, Me.ControlSelPeriodiMensili1.MaxDate)
        Controller.SetAzienda(Me.IdAziendaTextBox1.TextValue)
        Controller.SetRicercaErrori(chkErr.Checked)
        Controller.SetComune(cboComune.Text)
        Controller.SetProvincia(cboProvincia.Text)
        Controller.SetNazione(cboNazione.Text)

        If cboIscrittoA.Text = ZeroCodes Then
            Controller.SetIscrittoA("")
        ElseIf cboIscrittoA.Text = NoSelection Then
            Controller.SetIscrittoA("-")
        Else
            Controller.SetIscrittoA(cboIscrittoA.Text)
        End If


    End Sub


    Private Sub FillSearchList()
        Try
            Helper.ShowWaitBox("Attendere elaborazione report...", My.Resources.Waiting3)
            list = Controller.SearchDTOs
            Helper.HideWaitBox()
        Catch ex As Exception
            Helper.HideWaitBox()
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    Private Sub SearchData()

        Try



            System.Windows.Forms.Application.DoEvents()

            Me.SetSearchConditions()
            Dim thread As New System.Threading.Thread(AddressOf FillSearchList)
            thread.Start()

            Do While thread.IsAlive = True
                System.Windows.Forms.Application.DoEvents()
            Loop





            System.Windows.Forms.Application.DoEvents()

            If list.Count > 0 Then
                'Dim gridLoader As New GridLoaderRptLiberiDTO(Me.GridPosizioni)
                '' gridLoader.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                'gridLoader.LoadGrid(list)
                GridPosizioni.DataSource = list
            Else
                MsgBox("Non ci sono posizioni per i requisiti immessi!", MsgBoxStyle.Information, "Nessuna posizione trovata")
            End If

        Catch ex As Exception


            ErrorHandler.ShowError(ex)
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
                Dim a As NonIscrittoDTO = DirectCast(GridView1.GetRow(handle), NonIscrittoDTO)
                If (a IsNot Nothing) Then
                    l.Add(a)
                End If
            End If
        Next
        Return l
    End Function

    Private Sub chkErr_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkErr.CheckedChanged
        If chkErr.Checked Then
            cboEnti.Enabled = False
        Else
            cboEnti.Enabled = True
        End If
    End Sub

    Private Sub cboNazione_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboNazione.SelectedIndexChanged
        'If Me.cboNazione.Text <> "ITALIA" Then
        '    Me.cboComune.Enabled = False
        '    Me.cboProvincia.Enabled = False
        'Else
        '    Me.cboComune.Enabled = True
        '    Me.cboProvincia.Enabled = True
        'End If
    End Sub

    Private Sub cboProvincia_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboProvincia.SelectedIndexChanged
        InterfaceMediator.LoadCombo(Me.cboComune, GeoLocationFacade.Instance.GetListaComuniPerProvincia(Me.cboProvincia.Text), True)
        cboComune.SelectedIndex = 0
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
    '        Controller.SortDTOItems(colonna)
    '        Me.GridPosizioni.DataSource = Controller.SearchResult
    '        Me.GridPosizioni.Refresh()
    '        GridPosizioni.Columns(colonna).HeaderCell.SortGlyphDirection = SortOrder.Descending
    '    Catch ex As Exception
    '        ErrorHandler.ShowError(ex)
    '    End Try
    'End Sub


    'Private Sub OrderDown(ByVal colonna As String)
    '    Try
    '        Controller.SortDTOItems(colonna, True)
    '        Me.GridPosizioni.DataSource = Controller.SearchResult
    '        Me.GridPosizioni.Refresh()
    '        GridPosizioni.Columns(colonna).HeaderCell.SortGlyphDirection = SortOrder.Ascending
    '    Catch ex As Exception
    '        ErrorHandler.ShowError(ex)
    '    End Try
    'End Sub

End Class