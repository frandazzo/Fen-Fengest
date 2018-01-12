Public Class ControlloListeIDs
   Protected m_IdList As New ArrayList
   Private m_Tipo As ControlloListeIDs.SearchType
   Private frmSearch As System.Windows.Forms.Form
   Private IdList As New ArrayList

   Public Sub New()

      ' Chiamata richiesta da Progettazione Windows Form.
      InitializeComponent()

      ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

   End Sub

   Public Sub SetListaIdUtenti(ByVal listaUtenti As IList)
      For Each elem As AbstractPersistenceObject In listaUtenti
         Dim int As Int32 = Me.GridIds.NewRowIndex
         Me.GridIds.Rows.Insert(int)
         Me.GridIds.Rows(int).Cells(0).Value = elem.Id
      Next
   End Sub


   Public Sub SetListId(ByVal List As ArrayList)
      If List.Count <= 0 Then
         'For i As Int32 = 1 To 5
         '   Me.GridIds.Rows.Add("")
         'Next
         Exit Sub
      End If
      Me.GridIds.Rows.Clear()
      For Each elem As String In List
         Me.GridIds.Rows.Add(elem)
      Next
      'For i As Int32 = 1 To 5
      '   Me.GridIds.Rows.Add("")
      'Next
   End Sub

   Public ReadOnly Property GetListId() As ArrayList
      Get
         SetIdList()
         Return IdList
      End Get
   End Property
   Public Property TipoRicerca() As ControlloListeIDs.SearchType
      Get
         Return m_Tipo
      End Get
      Set(ByVal value As ControlloListeIDs.SearchType)
         m_Tipo = value
      End Set
   End Property
   Public Enum SearchType
      Conti
      Aziende
      Referenti
      Utenti
      Documenti
   End Enum



   Private Sub GridIds_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridIds.CellContentClick
      Try
         frmSearch = SearcFormFactory.GetSearchForm(m_Tipo)
         Dim ISearch As IFrmSearch = DirectCast(frmSearch, IFrmSearch)
         frmSearch.ShowDialog()
         If frmSearch.DialogResult = Windows.Forms.DialogResult.OK And Trim(ISearch.SelectedId) <> "" Then
            If CStr(Me.GridIds.Rows(e.RowIndex).Cells(0).Value) = "" Then
               Me.GridIds.Rows.Insert(Me.GridIds.NewRowIndex, "")
            End If
            Me.GridIds.Rows(e.RowIndex).Cells(0).Value = ISearch.SelectedId
         End If

         frmSearch.Dispose()
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Private Sub SetIdList()
      IdList = New ArrayList
      Try
         For Each elem As System.Windows.Forms.DataGridViewRow In GridIds.Rows
            If Not elem.Cells("Id").Value Is Nothing Then
               If IsNumeric(elem.Cells("Id").Value.ToString) Then
                  If Not IdList.Contains(elem.Cells("Id").Value) Then
                     IdList.Add(elem.Cells("Id").Value)
                  End If
               End If
            End If
         Next
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub
   Public Class SearcFormFactory
      Public Shared Function GetSearchForm(ByVal Type As ControlloListeIDs.SearchType)
         Select Case Type
            Case SearchType.Aziende
               Return New SearchAziende
            Case SearchType.Conti
               Return New SearchConti
            Case SearchType.Documenti
               Return New SearchDocumenti
            Case SearchType.Referenti
               Return New SearchReferenti
            Case SearchType.Utenti
               Return New SearchUtenti
            Case Else
               Throw New Exception("Imopossibile creare un form di ricerca. Tipo ricerca sconosciuto")
         End Select

      End Function
   End Class


   Private Sub GridIds_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridIds.KeyDown
      If e.KeyData = Windows.Forms.Keys.Delete Then
         If Me.GridIds.SelectedRows.Count > 0 Then
            Dim list As IList = Me.GridIds.SelectedRows
            For Each elem As System.Windows.Forms.DataGridViewRow In list
               If Not elem.IsNewRow Then
                  Me.GridIds.Rows.RemoveAt(elem.Index)
               End If
            Next
         End If
      End If
   End Sub
End Class
