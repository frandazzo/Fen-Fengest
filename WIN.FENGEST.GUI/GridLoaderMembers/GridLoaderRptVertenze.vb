
Imports System.Windows.Forms
Imports WIN.APPLICATION.FINANCIAL_ARTIFACTS
Public Class GridLoaderRptVertenze
   Inherits AbstractGridLoader


   Public Sub New(ByVal Grid As DataGridView)
      MyBase.New(Grid)
   End Sub
   Protected Overrides Sub LoadCustomListProperties(ByVal list As System.Collections.IList)
      With m_Grid
         '.Columns.Add("IdUtente", "Id Utente")

         .Columns("IdUtente").Visible = False
         .Columns("Note").Visible = False
         .Columns("IdReferente").Visible = False
         .Columns("IdResponsabile").Visible = False
         .Columns("IdAzienda").Visible = False
        

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


         .Columns("Azienda").Visible = True
         .Columns("Azienda").HeaderText = "Azienda controparte"
         .Columns("Azienda").CellTemplate.Style.Font = New Font(.Columns("Azienda").DataGridView.Font, FontStyle.Underline)
            .Columns("Azienda").CellTemplate.Style.ForeColor = Color.Black
         .Columns("Azienda").ReadOnly = True
         .Columns("Azienda").DisplayIndex = 5

         .Columns("PeriodoVertenza").Visible = True
         .Columns("PeriodoVertenza").HeaderText = "Periodo vertenza"
         .Columns("PeriodoVertenza").ReadOnly = True
         .Columns("PeriodoVertenza").DisplayIndex = 6

         .Columns("Avvocato").Visible = True
         .Columns("Avvocato").HeaderText = "Avvocato"
         .Columns("Avvocato").CellTemplate.Style.Font = New Font(.Columns("Avvocato").DataGridView.Font, FontStyle.Underline)
            .Columns("Avvocato").CellTemplate.Style.ForeColor = Color.Black
         .Columns("Avvocato").ReadOnly = True
         .Columns("Avvocato").DisplayIndex = 7


         .Columns("Referente").Visible = True
         .Columns("Referente").HeaderText = "Collaboratore comunale"
         .Columns("Referente").CellTemplate.Style.Font = New Font(.Columns("Referente").DataGridView.Font, FontStyle.Underline)
            .Columns("Referente").CellTemplate.Style.ForeColor = Color.Black
         .Columns("Referente").ReadOnly = True
         .Columns("Referente").DisplayIndex = 8
       
         .Columns("Responsabile").Visible = True
         .Columns("Responsabile").CellTemplate.Style.Font = New Font(.Columns("Responsabile").DataGridView.Font, FontStyle.Underline)
            .Columns("Responsabile").CellTemplate.Style.ForeColor = Color.Black
         .Columns("Responsabile").ReadOnly = True
         .Columns("Responsabile").DisplayIndex = 9

      End With
   End Sub


End Class
