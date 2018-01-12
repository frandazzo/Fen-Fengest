Public Class FrmSelezionaId

   Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
      Me.DialogResult = Windows.Forms.DialogResult.OK
      Me.Close()
   End Sub

   Public Sub SetTipoRicerca(ByVal Tipo As ControlloListeIDs.SearchType, ByVal ListaId As ArrayList)

      Me.ControlloListeIDs1.TipoRicerca = Tipo
      Me.ControlloListeIDs1.SetListId(ListaId)

      Select Case Tipo
         Case ControlloListeIDs.SearchType.Utenti
            cmdLista.Visible = True
         Case Else
            cmdLista.Visible = False
      End Select
   End Sub
   Private Sub cmdAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnnulla.Click
      Me.DialogResult = Windows.Forms.DialogResult.Cancel
      Me.Close()
   End Sub


   Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click
      If Me.ControlloListeIDs1.GridIds.SelectedRows.Count > 0 Then
         Dim list As IList = Me.ControlloListeIDs1.GridIds.SelectedRows
         For Each elem As System.Windows.Forms.DataGridViewRow In list
            If Not elem.IsNewRow Then
               Me.ControlloListeIDs1.GridIds.Rows.RemoveAt(elem.Index)
            End If
         Next
      ElseIf Me.ControlloListeIDs1.GridIds.SelectedCells.Count > 0 Then
         For Each elem As System.Windows.Forms.DataGridViewCell In Me.ControlloListeIDs1.GridIds.SelectedCells
            Dim rowindex As Int32 = Me.ControlloListeIDs1.GridIds.SelectedCells(0).RowIndex
            If Not Me.ControlloListeIDs1.GridIds.Rows(rowindex) Is Nothing Then
               If Not Me.ControlloListeIDs1.GridIds.Rows(rowindex).IsNewRow Then
                  Me.ControlloListeIDs1.GridIds.Rows.RemoveAt(rowindex)
               Else
                  Me.ControlloListeIDs1.GridIds.SelectedCells(rowindex).Selected = False
               End If
            End If
         Next
      End If
   End Sub

   Private Sub cmdLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLista.Click
      Try
         Dim frm As New FrmSelezionaListaLavoro
         If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
            If frm.ListaLavoro IsNot Nothing Then
               Me.ControlloListeIDs1.SetListaIdUtenti(frm.ListaLavoro.ListaUtenti)
            End If
         End If
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub
End Class