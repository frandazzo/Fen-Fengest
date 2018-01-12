
Imports System.Windows.Forms
Public Class SearchContratti
   Implements IFrmSearch
   Private SearchController As New ControllerSettori
   Private m_SelectedId As Int32 = -1
   Public SelectedSettore As Int32 = -1
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
         'lista = SearchController.GetListaContratti
         LoadGrid(lista)
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub
   Private Sub LoadGrid(ByVal Lista As ArrayList)
      Try
         'GridReferenti.DataSource = Lista
         Dim i As Int32 = 0
         If Lista.Count = 0 Then Exit Sub
         Me.GridContratti.Rows.Clear()
         For Each elem As String In Lista
            Me.GridContratti.Rows.Add("")
            Me.GridContratti.Rows(i).Cells(0).Value = elem
            i = i + 1
         Next
         'Me.GridAziende.Rows.RemoveAt(i)
         GridContratti.SelectionMode = DataGridViewSelectionMode.FullRowSelect


      Catch ex As Exception
         Throw New Exception(ex.Message)
      End Try
   End Sub



   Private Sub GridReferenti_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridContratti.MouseDoubleClick
      Try
         Seleziona()
      Catch ex As Exception
         Throw New Exception(ex.Message)
      End Try
   End Sub


   Private Sub Seleziona()
      If GridContratti.SelectedRows.Count = 1 Then
         Dim controller As New ControllerTipoContratto
         m_SelectedId = controller.GetIdTipoContrattoByDescrizione(DirectCast(GridContratti.SelectedRows.Item(0).Cells(0).Value, String))
         Me.DialogResult = Windows.Forms.DialogResult.OK
         Me.Close()
      Else
         MsgBox("Selezionare un contratto!")
      End If
   End Sub

   Private Sub SearchContratti_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      SetUpComboSettori()
   End Sub
   Private Sub SetUpComboSettori()
      Try
         cboSettori.Items.Clear()
         Dim list As Hashtable = SearchController.GetListaSettori
         Dim en As IDictionaryEnumerator = list.GetEnumerator
         Do While en.MoveNext
            Me.cboSettori.Items.Add(en.Value)
         Loop
         Me.cboSettori.SelectedIndex = 0
      Catch ex As Exception
         Throw New Exception("Impossibile impostare il combo dei settori." & vbCrLf & ex.Message)
      End Try
   End Sub

   Private Sub cboSettori_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboSettori.SelectedIndexChanged
      SearchController.LoadById(SearchController.GetIdSettoreByDescrizione(cboSettori.Text))
      Me.SelectedSettore = SearchController.Id
   End Sub
End Class