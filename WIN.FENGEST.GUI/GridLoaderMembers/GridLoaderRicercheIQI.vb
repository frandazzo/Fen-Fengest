Imports System.Windows.Forms
Imports WIN.APPLICATION.FINANCIAL_ARTIFACTS
Public Class GridLoaderRicercheIQI
   Inherits AbstractGridLoader


   Public Sub New(ByVal Grid As DataGridView)
      MyBase.New(Grid)
   End Sub
   Protected Overrides Sub LoadCustomListProperties(ByVal list As System.Collections.IList)
      With m_Grid

         Dim selCol As New DataGridViewCheckBoxColumn()
         MyBase.m_Grid.Columns.Add(selCol)
         selCol.Name = "Selezione"
         selCol.HeaderText = "Seleziona"
         selCol.DisplayIndex = 0
         selCol.FalseValue = False
         selCol.TrueValue = True

         .Columns.Add("IdUtente", "Id Utente")
         .Columns.Add("IdTipoPrestazione", "IdTipo")

         .Columns("IdTipoPrestazione").Visible = False
         .Columns("IdUtente").Visible = False
         .Columns("Note").Visible = False
         .Columns("FileOutPut").Visible = False
         .Columns("TipoDocumento").Visible = False

         '.Columns("Selezione").Visible = True

         .Columns("DataRegistrazione").Visible = True
         .Columns("DataRegistrazione").HeaderText = "Data registrazione"
         .Columns("DataRegistrazione").ReadOnly = True
         .Columns("DataRegistrazione").DisplayIndex = 1

         .Columns("DataDocumento").Visible = True
         .Columns("DataDocumento").HeaderText = "Data documento"
         .Columns("DataDocumento").ReadOnly = True
         .Columns("DataDocumento").DisplayIndex = 2

         .Columns("Utente").Visible = True
         .Columns("Utente").ReadOnly = True
         .Columns("Utente").DisplayIndex = 3

         .Columns("TipoPrestazione").Visible = True
         .Columns("TipoPrestazione").HeaderText = "Tipo prestazione"
         .Columns("TipoPrestazione").ReadOnly = True
         .Columns("TipoPrestazione").DisplayIndex = 4


         .Columns("Referente").Visible = True
         .Columns("Referente").ReadOnly = True
         .Columns("Referente").DisplayIndex = 5

         .Columns("Id").Visible = True
         .Columns("Id").DisplayIndex = 6


        

      End With
   End Sub


End Class
