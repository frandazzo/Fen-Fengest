
Imports System.Windows.Forms
Public Class SearchOfferte
   Implements IFrmSearch
   'Private SearchController As New UTENTI.ControllerOfferte
   Private m_SelectedId As Int32 = -1
   Dim controllerRicerche As New ControllerRicercheOfferte

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
         map.Add("Data", chkDoc.Checked)
         controllerRicerche.SetNewSerchConditions(map)
         controllerRicerche.SetData(dtpDocDa.Value)
         controllerRicerche.SetValidityRange(dtpRegDa.Value, dtpRegA.Value)
         controllerRicerche.SetIdAzienda(IdAziendaTextBox1.TextValue)
         controllerRicerche.SetMaxNumberOfReturnedRecords(My.Settings.MaxReturnedRecordNumber)

         If chkDomanda.Text <> "" Then
            Dim controllerSkill As New ControllerAbilita
            controllerRicerche.SetIdSkill(controllerSkill.GetIdByDescrizione(chkDomanda.Text))
         End If


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
      With GridOfferte

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

            .Columns("Selected").Visible = False
            .Columns("Note").Visible = False

            .Columns("Id").Visible = True
            .Columns("Id").ReadOnly = True
            .Columns("Id").DisplayIndex = 0

            .Columns("Data").Visible = True
            .Columns("Data").HeaderText = "Data"
            .Columns("Data").ReadOnly = True
            .Columns("Data").DisplayIndex = 1



            .Columns("AziendaRichiedente").Visible = True
            .Columns("AziendaRichiedente").HeaderText = "Azienda richiedente"
            .Columns("AziendaRichiedente").ReadOnly = True
            .Columns("AziendaRichiedente").DisplayIndex = 2


            .Columns("Validita").Visible = True
            .Columns("Validita").HeaderText = "Validità"
            .Columns("Validita").ReadOnly = True
            .Columns("Validita").DisplayIndex = 3

            .Columns("GetNumeroTotalePosti").Visible = True
            .Columns("GetNumeroTotalePosti").HeaderText = "Totale posti"
            .Columns("GetNumeroTotalePosti").ReadOnly = True
            .Columns("GetNumeroTotalePosti").DisplayIndex = 4






            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

         End If
      End With


   End Sub



   Private Sub GridReferenti_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridOfferte.MouseDoubleClick

      Seleziona()

   End Sub


   Private Sub Seleziona()
      If GridOfferte.SelectedRows.Count = 1 Then
         m_SelectedId = DirectCast(GridOfferte.SelectedRows.Item(0).Cells("Id").Value, Int32)
         m_SelectedDescription = DirectCast(GridOfferte.SelectedRows.Item(0).DataBoundItem, OffertaLavoro).AziendaRichiedente.Descrizione
         Me.DialogResult = Windows.Forms.DialogResult.OK
         Me.Close()
      Else
         MsgBox("Selezionare un Utente!")
      End If
   End Sub



   Private Sub SearchOfferte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

      Dim controllerSkill As New ControllerAbilita
      InterfaceMediator.LoadCombo(chkDomanda, controllerSkill.GetListaCausali, True)
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

   Private Sub chkDoc_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkDoc.CheckedChanged
      If chkDoc.Checked Then
         dtpDocDa.Enabled = True
      Else
         dtpDocDa.Enabled = False
      End If
   End Sub
End Class