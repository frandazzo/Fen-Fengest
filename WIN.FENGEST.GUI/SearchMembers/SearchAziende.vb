
Imports System.Windows.Forms
Public Class SearchAziende
    Implements IFrmSearch
    Private SearchController As New AZIENDE.ControllerAziende
    Private m_SelectedId As Int32 = -1
    Private controllerSettori As New ControllerSettori
    Dim controllerContratti As New ControllerTipoContratto
    Dim controllerRicerche As New WIN.APPLICATION.AZIENDE.ControllerRicercheAziende
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
            controllerRicerche.SetRagioneSociale(Me.txtNome.Text)
            controllerRicerche.SetContratto(Me.cboContratti.Text)
            controllerRicerche.SetComune(Me.cboComune.Text)
            controllerRicerche.SetProvincia(Me.cboProvincia.Text)
            controllerRicerche.SetMaxNumberOfReturnedRecords(My.Settings.MaxReturnedRecordNumber)
            lista = controllerRicerche.Search
            If lista.Count = 0 Then
                MsgBox("Non è stato trovato alcun elemento che soddisfa i requisiti richiesti!", MsgBoxStyle.Information, "Nessun elemento trovato")
                'Exit Sub
            End If
            LoadGrid(lista)
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    Private Sub LoadGrid(ByVal Lista As ArrayList)

        'GridReferenti.DataSource = Lista
        With GridAziende

            .DataSource = Lista
            If Lista.Count > 0 Then
                .AutoGenerateColumns = False

                .Columns("Key").Visible = False
                .Columns("Versione").Visible = False
                .Columns("CreatoDa").Visible = False
                .Columns("ModificatoDa").Visible = False
                .Columns("DataCreazione").Visible = False
                .Columns("DataModifica").Visible = False
                .Columns("Conto").Visible = False
                .Columns("Scarto").Visible = False
                .Columns("CalcolatoreCongruita").Visible = False
                .Columns("CompetenzaUltimoPagamento").Visible = False
                .Columns("UnitaDiCompetenza").Visible = False
                .Columns("DirectoryPreferenziale").Visible = False
                .Columns("Comunicazione").Visible = False
                .Columns("Responsable").Visible = False
                .Columns("Id").Visible = False
                .Columns("TipologiaAzienda").Visible = False
                .Columns("IndirizzoSedeLegale").Visible = False
                .Columns("Segreteria").Visible = False
                .Columns("ArchivioDocumenti").Visible = False
                .Columns("Codifica").Visible = False
                .Columns("Note").Visible = False
                .Columns("NonCancellabile").Visible = False



                .Columns("IdAzienda").HeaderText = "Id"
                .Columns("IdAzienda").Visible = True
                .Columns("IdAzienda").ReadOnly = True
                .Columns("IdAzienda").DisplayIndex = 0


                .Columns("Descrizione").HeaderText = "Ragione sociale"
                .Columns("Descrizione").Visible = True
                .Columns("Descrizione").ReadOnly = True
                .Columns("Descrizione").DisplayIndex = 1




                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

            End If
        End With



    End Sub

    Private Sub GridAziende_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles GridAziende.CellFormatting
        If GridAziende.Columns(e.ColumnIndex).Name.Equals("ContrattoApplicato") Then
            If Not e.Value Is Nothing Then
                e.Value = e.Value.Descrizione
            End If
        End If
    End Sub

    Private Sub GridReferenti_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridAziende.MouseDoubleClick

        Seleziona()

    End Sub


    Private Sub Seleziona()
        If GridAziende.SelectedRows.Count = 1 Then
            m_SelectedId = DirectCast(GridAziende.SelectedRows.Item(0).Cells("IdAzienda").Value, Int32)
            m_SelectedDescription = DirectCast(GridAziende.SelectedRows.Item(0).DataBoundItem, Azienda).Descrizione
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            MsgBox("Selezionare un Azienda!")
        End If
    End Sub



    Private Sub SearchAziende_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        InterfaceMediator.LoadCombo(Me.cboComune, GeoLocationFacade.Instance.GetListaComuniPerProvincia(My.Settings.ComuneDefault), True)
        InterfaceMediator.LoadCombo(Me.cboProvincia, GeoLocationFacade.Instance.GetListaProvincie, True)
        Me.cboProvincia.Text = My.Settings.ProvinciaDefault
        Me.cboComune.Text = My.Settings.ComuneDefault
        InterfaceMediator.LoadCombo(Me.cboContratti, controllerContratti.GetListaContratti, True)
    End Sub


    Private Sub cboProvincia_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProvincia.SelectedIndexChanged
        InterfaceMediator.LoadCombo(Me.cboComune, GeoLocationFacade.Instance.GetListaComuniPerProvincia(Me.cboProvincia.Text), True)
        cboComune.SelectedIndex = 0
    End Sub


End Class