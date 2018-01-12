
Imports System.Windows.Forms

Public Class GridLoaderRptPrestazioni
   Inherits AbstractGridLoader


   Public Sub New(ByVal Grid As DataGridView)
      MyBase.New(Grid)
   End Sub
   Protected Overrides Sub LoadCustomListProperties(ByVal list As System.Collections.IList)
      With m_Grid
         .RowTemplate = Nothing
   

         .Columns("Note").Visible = False
         .Columns("IdUtente").Visible = False
         .Columns("IdReferente").Visible = False


         '.Columns("Selezione").Visible = True
         .Columns("Id").Visible = True
         .Columns("Id").CellTemplate.Style.Font = New Font(.Columns("Id").DataGridView.Font, FontStyle.Underline)
            .Columns("Id").CellTemplate.Style.ForeColor = Color.Black
         .Columns("Id").DisplayIndex = 0



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
         .Columns("Utente").CellTemplate.Style.Font = New Font(.Columns("Utente").DataGridView.Font, FontStyle.Underline)
            .Columns("Utente").CellTemplate.Style.ForeColor = Color.Black
         .Columns("Utente").DisplayIndex = 3

         .Columns("TipoPrestazione").Visible = True
         .Columns("TipoPrestazione").HeaderText = "Tipo prestazione"
         .Columns("TipoPrestazione").ReadOnly = True
         .Columns("TipoPrestazione").DisplayIndex = 4


         .Columns("Referente").Visible = True
         .Columns("Referente").HeaderText = "Collaboratore comunale"
         .Columns("Referente").CellTemplate.Style.Font = New Font(.Columns("Referente").DataGridView.Font, FontStyle.Underline)
            .Columns("Referente").CellTemplate.Style.ForeColor = Color.Black
         .Columns("Referente").ReadOnly = True
         .Columns("Referente").DisplayIndex = 5

       

     


      End With
   End Sub


End Class

