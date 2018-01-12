
Imports System.Windows.Forms
Public Class SearchAvvocati
   Implements IFrmSearch

   Private SearchController As New AZIENDE.ControllerAziende

   Private m_SelectedId As Int32 = -1
   Dim controllerAvvocati As New ControllerAvvocati
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
      InitializeGrid(Me.GridAziende)

   End Sub

   Private Sub InitializeGrid(ByVal grid As DataGridView)
      With grid

         .Columns.Clear()

         .AutoGenerateColumns = False



         Dim colId As DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
         colId.Name = "Id"
         colId.ReadOnly = True
         colId.HeaderText = "Id avvocato"
         colId.DataPropertyName = "Id"
         .Columns.Add(colId)



         Dim colDesc As DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
         colDesc.Name = "Ragione"
         colDesc.ReadOnly = True
         colDesc.HeaderText = "Ragione sociale"
         colDesc.DataPropertyName = "Descrizione"
         .Columns.Add(colDesc)


         .SelectionMode = DataGridViewSelectionMode.FullRowSelect
         .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
         .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells


      End With



   End Sub
   Private Sub cmdCerca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerca.Click
      Try
         Dim lista As New ArrayList
         'lista = SearchController.GetAll
         controllerAvvocati.SetRagioneSociale(Me.txtNome.Text)



         lista = controllerAvvocati.Search
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
      If GridAziende.DataSource Is Nothing Then
         GridAziende.DataSource = Lista
         Return
      End If

      GridAziende.DataSource = Nothing
      GridAziende.DataSource = Lista
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
         m_SelectedId = DirectCast(GridAziende.SelectedRows.Item(0).Cells("Id").Value, Int32)
         Me.DialogResult = Windows.Forms.DialogResult.OK
         Me.Close()
      Else
         MsgBox("Selezionare un Azienda!")
      End If
   End Sub





 
End Class