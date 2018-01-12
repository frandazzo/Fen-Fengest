Imports System.Windows.Forms
Public Class GridAttivitaInitializers

   Public Shared Sub InitializeGridDeleghe(ByVal Grid As DataGridView)
      Grid.Columns.Clear()
      Grid.AutoGenerateColumns = False


      Dim col0 As New DataGridViewTextBoxColumn
      col0.Name = "Id"
      col0.HeaderText = "Id"
      col0.ReadOnly = True
      col0.DataPropertyName = "Id"
      Grid.Columns.Add(col0)



      Dim col As New DataGridViewTextBoxColumn
      col.Name = "DataDocumento"
      col.HeaderText = "Data documento"
      col.ReadOnly = True
      col.DataPropertyName = "DataDocumento"
      Grid.Columns.Add(col)


      Dim col1 As New DataGridViewTextBoxColumn
      col1.Name = "EnteInoltro"
      col1.HeaderText = "Ente inoltro"
      col1.ReadOnly = True
      col1.DataPropertyName = "EnteInoltro"
      Grid.Columns.Add(col1)

      Dim col2 As New DataGridViewTextBoxColumn
      col2.Name = "StatoDelega"
      col2.HeaderText = "Stato delega"
      col2.ReadOnly = True
      col2.DataPropertyName = "StatoDelega"
      Grid.Columns.Add(col2)



   End Sub


   Public Shared Sub InitializeGridPrestazioni(ByVal Grid As DataGridView)
      Grid.Columns.Clear()
      Grid.AutoGenerateColumns = False


      Dim col0 As New DataGridViewTextBoxColumn
      col0.Name = "Id"
      col0.HeaderText = "Id"
      col0.ReadOnly = True
      col0.DataPropertyName = "Id"
      Grid.Columns.Add(col0)



      Dim col As New DataGridViewTextBoxColumn
      col.Name = "DataDocumento"
      col.HeaderText = "Data documento"
      col.ReadOnly = True
      col.DataPropertyName = "DataDocumento"
      Grid.Columns.Add(col)


      Dim col1 As New DataGridViewTextBoxColumn
      col1.Name = "TipoPrestazione"
      col1.HeaderText = "Tipo prestazione"
      col1.ReadOnly = True
      col1.DataPropertyName = "TipoPrestazione"
      Grid.Columns.Add(col1)

  


   End Sub

   Public Shared Sub InitializeGridVertenze(ByVal Grid As DataGridView)
      Grid.Columns.Clear()
      Grid.AutoGenerateColumns = False


      Dim col0 As New DataGridViewTextBoxColumn
      col0.Name = "Id"
      col0.HeaderText = "Id"
      col0.ReadOnly = True
      col0.DataPropertyName = "Id"
      Grid.Columns.Add(col0)



      Dim col As New DataGridViewTextBoxColumn
      col.Name = "DataDocumento"
      col.HeaderText = "Data documento"
      col.ReadOnly = True
      col.DataPropertyName = "DataDocumento"
      Grid.Columns.Add(col)


      Dim col1 As New DataGridViewTextBoxColumn
      col1.Name = "Controparte"
      col1.HeaderText = "Controparte"
      col1.ReadOnly = True
      col1.DataPropertyName = "Azienda"
      Grid.Columns.Add(col1)

      Dim col2 As New DataGridViewTextBoxColumn
      col2.Name = "Periodo"
      col2.HeaderText = "Periodo contenzioso"
      col2.ReadOnly = True
      col2.DataPropertyName = "PeriodoVertenza"
      Grid.Columns.Add(col2)



   End Sub

   Public Shared Sub InitializeGridComunicazioni(ByVal Grid As DataGridView)
      Grid.Columns.Clear()
      Grid.AutoGenerateColumns = False


      Dim col0 As New DataGridViewTextBoxColumn
      col0.Name = "Id"
      col0.HeaderText = "Id"
      col0.ReadOnly = True
      col0.DataPropertyName = "Id"
      Grid.Columns.Add(col0)



      Dim col As New DataGridViewTextBoxColumn
      col.Name = "DataDocumento"
      col.HeaderText = "Data documento"
      col.ReadOnly = True
      col.DataPropertyName = "DataDocumento"
      Grid.Columns.Add(col)


      Dim col1 As New DataGridViewTextBoxColumn
      col1.Name = "CausaleComunicazione"
      col1.HeaderText = "Causale comunicazione"
      col1.ReadOnly = True
      col1.DataPropertyName = "Causale"
      Grid.Columns.Add(col1)

      Dim col2 As New DataGridViewTextBoxColumn
      col2.Name = "TipoComunicazione"
      col2.HeaderText = "Tipo comunicazione"
      col2.ReadOnly = True
      col2.DataPropertyName = "Tipo"
      Grid.Columns.Add(col2)



   End Sub
   Public Shared Sub InitializeGridProposte(ByVal Grid As DataGridView)
      Grid.Columns.Clear()
      Grid.AutoGenerateColumns = False


      Dim col0 As New DataGridViewTextBoxColumn
      col0.Name = "Id"
      col0.HeaderText = "Id"
      col0.ReadOnly = True
      col0.DataPropertyName = "Id"
      Grid.Columns.Add(col0)



      Dim col As New DataGridViewTextBoxColumn
      col.Name = "DataDocumento"
      col.HeaderText = "Data documento"
      col.ReadOnly = True
      col.DataPropertyName = "DataDocumento"
      Grid.Columns.Add(col)


      Dim col1 As New DataGridViewTextBoxColumn
      col1.Name = "Offerta"
      col1.HeaderText = "Azienda richiedente"
      col1.ReadOnly = True
      col1.DataPropertyName = "Offerta"
      Grid.Columns.Add(col1)

      Dim col2 As New DataGridViewTextBoxColumn
      col2.Name = "Skill"
      col2.HeaderText = "Skill offerto"
      col2.ReadOnly = True
      col2.DataPropertyName = "Abilita"
      Grid.Columns.Add(col2)



   End Sub

End Class
