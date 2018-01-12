
Imports System.Windows.Forms
Public Class SearchUtenti
    Implements IFrmSearch
    Private SearchController As New UTENTI.ControllerUtenti
    Private m_SelectedId As Int32 = -1
    Dim controllerRicerche As New UTENTI.ControllerRicercheUtenti


    Private m_SelectedDescription As String = ""

    Public ReadOnly Property SelectedDescription() As String Implements IFrmSearch.SelectedDescription
        Get
            Return m_SelectedDescription
        End Get
    End Property
    Public ReadOnly Property SelectedId() As Int32 Implements IFrmSearch.SelectedId
        Get
            Return m_SelectedId
        End Get
    End Property
    Public Sub New()
        ' Chiamata richiesta da Progettazione Windows Form.
        InitializeComponent()
        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
    Private Sub cmdCerca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerca.Click
        Try
            Dim lista As New ArrayList
            'lista = SearchController.GetAll
            Dim map As New Hashtable
            map.Add("IntervalloDate", chkReg.Checked)
            controllerRicerche.SetNewSerchConditions(map)
            controllerRicerche.SetCodiceFiscale(Me.txtCF.Text)
            controllerRicerche.SetCognome(Me.txtCognome.Text)
            controllerRicerche.SetNome(Me.txtNome.Text)
            controllerRicerche.SetComune(Me.cboComune.Text)
            controllerRicerche.SetProvincia(Me.cboProvincia.Text)
            controllerRicerche.SetNazione(Me.cboNazione.Text)
            controllerRicerche.SetComuneNascita(Me.cboComNas.Text)
            controllerRicerche.SetProvinciaNascita(Me.cboProvNas.Text)
            controllerRicerche.SetCell1(txtCell1.Text)
            controllerRicerche.SetCell2(txtCell2.Text)
            controllerRicerche.SetDataNascitaRange(Me.dtpRegDa.Value.Date, Me.dtpRegA.Value.Date)
            controllerRicerche.SetMaxNumberOfReturnedRecords(My.Settings.MaxReturnedRecordNumber)
            controllerRicerche.SetOnlyFiscalCodeNull(chkNullFisc.Checked)
            controllerRicerche.Setm_AddressNull(chkAddressNotOk.Checked)

            Dim start As DateTime = Now
            System.Diagnostics.Debug.WriteLine("Inizio ricerca")
            lista = controllerRicerche.Search
            System.Diagnostics.Debug.WriteLine("Fine ricerca in millisecondi  " & Now.Subtract(start).TotalMilliseconds)
            If lista.Count = 0 Then
                MsgBox("Non è stato trovato alcun elemento che soddisfa i requisiti richiesti!", MsgBoxStyle.Information, "Nessun elemento trovato")
                'Exit Sub
            End If
            start = Now
            LoadGrid(lista)
            System.Diagnostics.Debug.WriteLine("Caricamento griglia in millisecondi  " & Now.Subtract(start).TotalMilliseconds)
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    Private Sub LoadGrid(ByVal Lista As ArrayList)

        'GridReferenti.DataSource = Lista
        With GridUtenti

            .DataSource = Lista
            If Lista.Count > 0 Then
                .AutoGenerateColumns = False

                .Columns("Key").Visible = False
                .Columns("Versione").Visible = False
                .Columns("CreatoDa").Visible = False
                .Columns("ModificatoDa").Visible = False
                .Columns("DataCreazione").Visible = False
                .Columns("DataModifica").Visible = False
                .Columns("Descrizione").Visible = False
                .Columns("CompleteName").Visible = False
                .Columns("Conto").Visible = False
                .Columns("QuotaMensile").Visible = False
                .Columns("Fondo").Visible = False
                .Columns("SituazioneFamiliare").Visible = False
                .Columns("Codifica").Visible = False
                .Columns("Note").Visible = False
                .Columns("Genere").Visible = False
                .Columns("NonCancellabile").Visible = False
                .Columns("TagUtente").Visible = False


                .Columns("DirectoryPreferenziale").Visible = False
                .Columns("Segreteria").Visible = False


                .Columns("Id").Visible = False
                .Columns("Comunicazione").Visible = False

                .Columns("Path_Foto").Visible = False

                .Columns("ProvinciaNascita").Visible = False
                .Columns("ComuneNascita").Visible = False
                .Columns("Sesso").Visible = False

                .Columns("Selected").Visible = False
                .Columns("ArchivioDocumenti").Visible = False



                '.Columns("Deleghe").Visible = False

                .Columns("IdUtente").HeaderText = "Id"
                .Columns("IdUtente").Visible = True
                .Columns("IdUtente").ReadOnly = True
                .Columns("IdUtente").DisplayIndex = 0


                .Columns("Cognome").Visible = True
                .Columns("Cognome").ReadOnly = True
                .Columns("Cognome").DisplayIndex = 1


                .Columns("Nome").Visible = True
                .Columns("Nome").ReadOnly = True
                .Columns("Nome").DisplayIndex = 2



                .Columns("DataNascita").Visible = True
                .Columns("DataNascita").Visible = True
                .Columns("DataNascita").ReadOnly = True
                .Columns("DataNascita").DisplayIndex = 3


                .Columns("Nazionalita").Visible = True
                .Columns("Nazionalita").Visible = True
                .Columns("Nazionalita").ReadOnly = True
                .Columns("Nazionalita").DisplayIndex = 4

                '.Columns("CodiceFiscale").Visible = True
                '.Columns("Cognome").ReadOnly = True
                '.Columns("Cognome").DisplayIndex = 3
                .Columns("Residenza").Visible = True
                .Columns("Residenza").HeaderText = "Comune di residenza"
                .Columns("Residenza").ReadOnly = True
                .Columns("Residenza").DisplayIndex = 5


                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            End If
        End With


    End Sub

    Private Sub GridUtenti_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles GridUtenti.CellFormatting
        If GridUtenti.Columns(e.ColumnIndex).Name.Equals("Residenza") Then
            If Not e.Value Is Nothing Then
                e.Value = e.Value.Comune.Descrizione
            Else
                e.Value = ""
            End If
        End If
    End Sub

    Private Sub GridReferenti_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridUtenti.MouseDoubleClick

        Seleziona()

    End Sub


    Private Sub Seleziona()
        If GridUtenti.SelectedRows.Count = 1 Then
            m_SelectedId = DirectCast(GridUtenti.SelectedRows.Item(0).DataBoundItem, Utente).Id
            m_SelectedDescription = DirectCast(GridUtenti.SelectedRows.Item(0).DataBoundItem, Utente).CompleteName
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            MsgBox("Selezionare un Utente!", MsgBoxStyle.Information, "Informazione")
        End If
    End Sub



    Private Sub SearchUtenti_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InterfaceMediator.LoadCombo(Me.cboComune, GeoLocationFacade.Instance.GetListaComuniPerProvincia(My.Settings.ComuneDefault), True)
        InterfaceMediator.LoadCombo(Me.cboNazione, GeoLocationFacade.Instance.GetListaNazioni, False)
        Me.cboNazione.Text = My.Settings.NazioneDefault

        ' InterfaceMediator.LoadComboDatasource(Me.cboComune, GeoLocationController.Instance.GetListaComuni, True)
        InterfaceMediator.LoadCombo(Me.cboProvincia, GeoLocationFacade.Instance.GetListaProvincie, True)
        Me.cboProvincia.Text = My.Settings.ProvinciaDefault
        Me.cboComune.Text = My.Settings.ComuneDefault
        InterfaceMediator.LoadCombo(Me.cboComNas, GeoLocationFacade.Instance.GetListaComuniPerProvincia(My.Settings.ComuneDefault), True)
        'InterfaceMediator.LoadComboDatasource(Me.cboComNas, GeoLocationController.Instance.GetListaComuni, True)
        InterfaceMediator.LoadCombo(Me.cboProvNas, GeoLocationFacade.Instance.GetListaProvincie, True)
        Me.cboProvNas.Text = My.Settings.ProvinciaDefault
        Me.cboComNas.Text = My.Settings.ComuneDefault
    End Sub

    Private Sub cboProvincia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProvincia.SelectedIndexChanged
        InterfaceMediator.LoadCombo(Me.cboComune, GeoLocationFacade.Instance.GetListaComuniPerProvincia(Me.cboProvincia.Text), True)
        cboComune.SelectedIndex = 0
    End Sub

    Private Sub cboProvNas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProvNas.SelectedIndexChanged
        InterfaceMediator.LoadCombo(Me.cboComNas, GeoLocationFacade.Instance.GetListaComuniPerProvincia(Me.cboProvNas.Text), True)
        cboComNas.SelectedIndex = 0
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

    Private Sub txtNome_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNome.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Try
            If GridUtenti.SelectedRows.Count = 1 Then
                Dim frm As New FrmVisualizzatoreDeleghe(DirectCast(GridUtenti.SelectedRows.Item(0).Cells("IdUtente").Value, Int32))
                frm.ShowDialog()
                frm.Dispose()
            End If
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try

    End Sub

    Private Sub GridUtenti_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridUtenti.KeyDown
        'If GridUtenti.SelectedRows.Count = 1 Then
        If e.KeyCode = Keys.Return Then
            Me.Seleziona()
        End If
        'End If
    End Sub

    Private Sub cmdAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnnulla.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        Me.Seleziona()
    End Sub

    Private Sub cboNazione_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboNazione.SelectedIndexChanged

        If Me.cboNazione.Text <> "ITALIA" Then
            Me.cboComNas.Enabled = False
            Me.cboProvNas.Enabled = False
        Else
            Me.cboComNas.Enabled = True
            Me.cboProvNas.Enabled = True
        End If
    End Sub

    Private Sub chkNullFisc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNullFisc.CheckedChanged
        If chkNullFisc.Checked Then
            txtCF.Enabled = False
            txtCF.Text = ""
        Else
            txtCF.Enabled = True
        End If
    End Sub

    Private Sub chkAddressNotOk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAddressNotOk.CheckedChanged
        If chkAddressNotOk.Checked Then
            cboProvincia.Enabled = False
            cboComune.Enabled = False
            cboComune.Text = ""
            cboProvincia.Text = ""
        Else
            cboProvincia.Enabled = True
            cboComune.Enabled = True
        End If
    End Sub
End Class