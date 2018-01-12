Imports System.Windows.Forms
Public Class SearchReferenti
   Implements IFrmSearch
   Private SearchController As New FINANCIAL_ARTIFACTS.ControllerReferenti
   Private m_SelectedId As Int32 = -1
   Dim controllerRicerche As New WIN.APPLICATION.FINANCIAL_ARTIFACTS.ControllerRicercheReferenti
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

         controllerRicerche.SetCognome(Me.txtCognome.Text)
         controllerRicerche.SetNome(Me.txtNome.Text)
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
      With GridReferenti

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

                .Columns("NonCancellabile").Visible = False
                .Columns("Note").Visible = False
                .Columns("Genere").Visible = False
                .Columns("LuogoNascita").Visible = False

            .Columns("ComunicazioneSedeLegale").Visible = False
            .Columns("IndirizzoSedeLegale").Visible = False
            .Columns("IsCameraComunale").Visible = False
            .Columns("Responsable").Visible = False

            .Columns("PercRistornoDeleghe").Visible = False
            .Columns("PercRistornoDelegheImpFissi").Visible = False
            .Columns("PercRistornoVertenze").Visible = False
            .Columns("PercRistornoInps").Visible = False
            .Columns("Id").Visible = False
            .Columns("ComponenteStruttura").Visible = False
            .Columns("UltimoRistorno").Visible = False
            .Columns("Conto").Visible = False
            .Columns("CodiceFiscale").Visible = False


            .Columns("Comunicazione").Visible = False
            .Columns("DataNascita").Visible = False
            .Columns("Nazionalita").Visible = False
            .Columns("ProvinciaNascita").Visible = False
            .Columns("ComuneNascita").Visible = False
            .Columns("Sesso").Visible = False
            .Columns("Residenza").Visible = False


            .Columns("IdReferente").HeaderText = "Id"
            .Columns("IdReferente").Visible = True
            .Columns("IdReferente").ReadOnly = True
            .Columns("IdReferente").DisplayIndex = 0

            .Columns("Nome").Visible = True
            .Columns("Nome").ReadOnly = True
            .Columns("Nome").DisplayIndex = 1

            .Columns("Cognome").Visible = True
            .Columns("Cognome").ReadOnly = True
            .Columns("Cognome").DisplayIndex = 2



         End If
         .SelectionMode = DataGridViewSelectionMode.FullRowSelect
         .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
         .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells


      End With


   End Sub

   Private Sub GridReferenti_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridReferenti.MouseDoubleClick

      Seleziona()

   End Sub


   Private Sub Seleziona()
      If GridReferenti.SelectedRows.Count = 1 Then
         m_SelectedId = DirectCast(GridReferenti.SelectedRows.Item(0).Cells("IdReferente").Value, Int32)
         m_SelectedDescription = DirectCast(GridReferenti.SelectedRows.Item(0).DataBoundItem, Referente).CompleteName
         Me.DialogResult = Windows.Forms.DialogResult.OK
         Me.Close()
      Else
         MsgBox("Selezionare un collaboratore!")
      End If
   End Sub

   Private Sub SearchConti_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
      'If e.CloseReason = CloseReason.UserClosing Then
      '   Me.DialogResult = Windows.Forms.DialogResult.Cancel
      'End If
   End Sub


End Class
