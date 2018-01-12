Imports System.Windows.Forms
Imports WIN.APPLICATION.FINANCIAL_ARTIFACTS
Public Class GridLoaderRicercheIQV
   Inherits AbstractGridLoader


   Public Sub New(ByVal Grid As DataGridView)
      MyBase.New(Grid)
   End Sub
   Protected Overrides Sub LoadCustomListProperties(ByVal list As System.Collections.IList)
      With m_Grid
         .Columns.Add("IdUtente", "Id Utente")

         .Columns("IdUtente").Visible = False
         .Columns("Note").Visible = False
         .Columns("TipoDocumento").Visible = False
         .Columns("Referente").Visible = False
         .Columns("ReferenteI").Visible = False
         .Columns("RUP").Visible = False
         .Columns("Quota").Visible = False

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


         .Columns("Azienda").Visible = True
         .Columns("Azienda").HeaderText = "Azienda controparte"
         .Columns("Azienda").ReadOnly = True
         .Columns("Azienda").DisplayIndex = 5

         .Columns("PeriodoVertenza").Visible = True
         .Columns("PeriodoVertenza").HeaderText = "Periodo vertenza"
         .Columns("PeriodoVertenza").ReadOnly = True
         .Columns("PeriodoVertenza").DisplayIndex = 6



         .Columns("Id").Visible = True
         .Columns("Id").DisplayIndex = 7



      End With
   End Sub


End Class
