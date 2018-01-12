
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Public Class FrmRicercaVertenze
   Implements IFrmSearch

   Private m_selectedId As String = ""
   Private m_NomeUtente As String = ""
      Private m_SelectedColumnName As String = ""
   Private m_listaPosizioni As IList = New ArrayList
   Private m_SelectedDescription As String = ""

   Public ReadOnly Property SelectedDescription() As String Implements IFrmSearch.SelectedDescription
      Get
         Return m_SelectedDescription
      End Get
   End Property

   Private Sub GridPosizioni_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GridPosizioni.CellMouseDoubleClick
      If GridPosizioni.SelectedRows.Count = 1 Then
         m_selectedId = DirectCast(GridPosizioni.SelectedRows.Item(0).Cells("Id").Value, Int32)
         m_NomeUtente = GridPosizioni.SelectedRows.Item(0).Cells("Utente").Value.CompleteName
         Me.DialogResult = Windows.Forms.DialogResult.OK
         Me.Close()
      Else
         MsgBox("Selezionare un Azienda!")
      End If
   End Sub
   'Private controller As New WIN.APPLICATION.FINANCIAL_ARTIFACTS.ControllerPagamentoReferenti


   Private Sub GridPosizioni_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GridPosizioni.ColumnHeaderMouseClick
      'qui seleziono tutta la colonna
      If GridPosizioni.Columns(e.ColumnIndex).Name = "Selezione" Then Exit Sub
      GridPosizioni.ClearSelection()
      For Each elem As DataGridViewColumn In GridPosizioni.Columns
         elem.HeaderCell.SortGlyphDirection = SortOrder.None
      Next
      GridPosizioni.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.Descending
      m_SelectedColumnName = GridPosizioni.Columns(e.ColumnIndex).Name
   End Sub

   




   Public Sub New()
      InitializeComponent()
   End Sub






   Private Sub loadItems()
      If Me.GridPosizioni.DataSource Is Nothing Then
         LoadGrid(m_listaPosizioni)
      Else
         Me.GridPosizioni.DataSource = m_listaPosizioni
         GridPosizioni.Refresh()
      End If
   End Sub
   Private Sub LoadGrid(ByVal Lista As IList)
      Dim gridloader As New GridLoaderRicercheIQV(GridPosizioni)
      gridloader.SelectionMode = Windows.Forms.DataGridViewSelectionMode.FullRowSelect
      gridloader.LoadGrid(Lista)
   End Sub

   Private Sub GridPosizioni_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles GridPosizioni.CellFormatting
      Try
         If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("Utente") Then
            If Not e.Value Is Nothing Then
               GridPosizioni.Rows(e.RowIndex).Cells("IdUtente").Value = e.Value.IdUtente
               e.Value = e.Value.CompleteName
            End If
         End If
         If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("Azienda") Then
            If Not e.Value Is Nothing Then
               e.Value = e.Value.Descrizione
            End If
         End If

         If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("Referente") Then
            If Not e.Value Is Nothing Then
               e.Value = e.Value.CompleteName
            End If
         End If
      Catch ex As Exception
         Throw New Exception("Errore nella formattazione delle celle della griglia." & vbCrLf & ex.Message)
      End Try
   End Sub





   Public ReadOnly Property IdVertenza() As String
      Get
         Return m_selectedId
      End Get
   End Property
   Public ReadOnly Property NomeUtente() As String
      Get
         Return m_NomeUtente
      End Get
   End Property




   Public ReadOnly Property SelectedId() As Integer Implements IFrmSearch.SelectedId
      Get
         Return m_selectedId
      End Get
   End Property


   Private Sub cmdCerca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerca.Click
      Try
         Me.ControlRicrcheIQV1.SetSearchConditions()
         m_listaPosizioni = Me.ControlRicrcheIQV1.GetControllerRicerche.Search
         If m_listaPosizioni.Count = 0 Then MsgBox("Non è stata trovata alcuna vertenza che soddisfa i requisiti immessi!", MsgBoxStyle.Information, "Nessuna prestazione trovata")
         loadItems()
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub


End Class
