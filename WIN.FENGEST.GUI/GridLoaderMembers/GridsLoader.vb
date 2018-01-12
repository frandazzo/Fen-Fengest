
Imports System.Windows.Forms
Public Class GridsLoader

   Public Shared Sub LoadData(ByVal grid As DataGridView, ByVal lista As IList)

      If grid.DataSource Is Nothing Then
         grid.DataSource = lista
         Return
      End If

      grid.DataSource = Nothing
      grid.DataSource = lista

   End Sub

End Class
