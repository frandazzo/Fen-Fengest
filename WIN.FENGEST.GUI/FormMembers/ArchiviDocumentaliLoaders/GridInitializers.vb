Imports System.Windows.Forms
Public Class GridInitializers

   Public Shared Sub InitializeGridArchivioDocumenti(ByVal grid As DataGridView)

      grid.Columns.Clear()
      grid.AutoGenerateColumns = False


      Dim col As New DataGridViewTextBoxColumn
      col.Name = "Data"
      col.HeaderText = "Data"
      col.ReadOnly = True
      col.DataPropertyName = "Data"
      grid.Columns.Add(col)


      Dim col1 As New DataGridViewTextBoxColumn
      col1.Name = "TipoDocumento"
      col1.HeaderText = "Tipo documento"
      col1.ReadOnly = True
      col1.DataPropertyName = "TipoDocumentazione"
      grid.Columns.Add(col1)

      Dim col2 As New DataGridViewTextBoxColumn
      col2.Name = "NomeFile"
      col2.HeaderText = "Nome file"
      col2.ReadOnly = True
      col2.DataPropertyName = "FileNameWithoutPath"
        grid.Columns.Add(col2)


        Dim col3 As New DataGridViewTextBoxColumn
        col3.Name = "Collaboratoe"
        col3.HeaderText = "Collaboratore"
        col3.ReadOnly = True
        col3.DataPropertyName = "Referente"
        grid.Columns.Add(col3)

      grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
      grid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing
      grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells


    


   End Sub

   Public Shared Sub InitializeGridAttivita(ByVal grid As DataGridView)

      grid.Columns.Clear()
      grid.AutoGenerateColumns = False

      Dim col0 As New DataGridViewTextBoxColumn
      col0.Name = "Id"
      col0.HeaderText = "ID Oggetto"
      col0.ReadOnly = True
      col0.DataPropertyName = "Id"
      grid.Columns.Add(col0)



      Dim col As New DataGridViewTextBoxColumn
      col.Name = "Data"
      col.HeaderText = "Data"
      col.ReadOnly = True
      col.DataPropertyName = "Data"
      grid.Columns.Add(col)


      Dim col1 As New DataGridViewTextBoxColumn
      col1.Name = "TipoDocumento"
      col1.HeaderText = "Tipo documento"
      col1.ReadOnly = True
      col1.DataPropertyName = "TipoDocumentazione"
      grid.Columns.Add(col1)

      Dim col2 As New DataGridViewTextBoxColumn
      col2.Name = "NomeFile"
      col2.HeaderText = "Nome file"
      col2.ReadOnly = True
      col2.DataPropertyName = "FileNameWithoutPath"
      grid.Columns.Add(col2)



      Dim col3 As New DataGridViewTextBoxColumn
      col3.Name = "Note"
      col3.HeaderText = "Note"
      col3.ReadOnly = True
      col3.DataPropertyName = "Notes"
      grid.Columns.Add(col3)

      grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect
      grid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing
      grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells



   End Sub
End Class
