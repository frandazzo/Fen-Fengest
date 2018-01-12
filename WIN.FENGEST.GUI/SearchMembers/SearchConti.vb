Imports System.Windows.Forms
Public Class SearchConti
   Implements IFrmSearch
   Private SearchController As New CONTI.ControllerConti
   Private m_SelectedId As Int32 = -1
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
         lista = SearchController.GetAll
         LoadGrid(lista)
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub
   Private Sub LoadGrid(ByVal Lista As ArrayList)
      Try

         With GridConti

            .DataSource = Lista
            If Lista.Count > 0 Then
               .AutoGenerateColumns = False

               .Columns("Key").Visible = False
               .Columns("Versione").Visible = False
               .Columns("CreatoDa").Visible = False
               .Columns("ModificatoDa").Visible = False
               .Columns("DataCreazione").Visible = False
               .Columns("DataModifica").Visible = False

               .Columns("IdConto").HeaderText = "Id Conto"
               .Columns("IdConto").Visible = True
               .Columns("IdConto").ReadOnly = True
               .Columns("IdConto").DisplayIndex = 0

               .Columns("Descrizione").Visible = True
               .Columns("Descrizione").ReadOnly = True
               .Columns("Descrizione").DisplayIndex = 1

               .Columns("Valuta").Visible = True
               .Columns("Valuta").ReadOnly = True
               .Columns("Valuta").DisplayIndex = 2


               .SelectionMode = DataGridViewSelectionMode.FullRowSelect
               .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
               .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            End If

         End With


      Catch ex As Exception
         Throw New Exception(ex.Message)
      End Try
   End Sub

   Private Sub GridConti_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridConti.MouseDoubleClick
      Try
         Seleziona()
      Catch ex As Exception
         Throw New Exception(ex.Message)
      End Try
   End Sub


   Private Sub Seleziona()
      If GridConti.SelectedRows.Count = 1 Then
         m_SelectedId = DirectCast(GridConti.SelectedRows.Item(0).Cells("IdConto").Value, Int32)
         Me.DialogResult = Windows.Forms.DialogResult.OK
         Me.Close()
      Else
         MsgBox("Selezionare un conto!")
      End If
   End Sub

   Private Sub SearchConti_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
      'If e.CloseReason = CloseReason.Then Then
      '   Me.DialogResult = Windows.Forms.DialogResult.Cancel
      'End If
   End Sub
End Class