Imports System.Windows.Forms
Imports WIN.APPLICATION.FINANCIAL_ARTIFACTS
Public Class GridLoaderRptIscritti
   Inherits AbstractGridLoader
   Public Sub New(ByVal Grid As DataGridView)
      MyBase.New(Grid)
   End Sub
   Protected Overrides Sub LoadCustomListProperties(ByVal list As System.Collections.IList)
      With m_Grid
         '.Columns.Add("KeyPos", "")
         .RowTemplate = Nothing
         '.Columns.Add("DICompetenza", "Data inizio competenza")
         '.Columns.Add("DFCompetenza", "Data fine competenza")
         If .Columns("KeyPos") Is Nothing Then
            .Columns.Add("KeyPos", "")
            .Columns("KeyPos").Visible = False
         End If
         If .Columns("DICompetenza") Is Nothing Then
            .Columns.Add("DICompetenza", "Data inizio competenza")
         End If
         If .Columns("DFCompetenza") Is Nothing Then
            .Columns.Add("DFCompetenza", "Data fine competenza")
         End If
         If .Columns("IdUtente") Is Nothing Then
            .Columns.Add("IdUtente", "Id Utente")
         End If


         .Columns("IdUtente").Visible = False
         .Columns("DICompetenza").Visible = False
         .Columns("DFCompetenza").Visible = False
         .Columns("GetQuotaMedia").Visible = False
         .Columns("GetCongruitaToString").Visible = False
         .Columns("Conto").Visible = False
         .Columns("Note").Visible = False
         .Columns("Vertenza").Visible = False
         .Columns("Prestazione").Visible = False
         .Columns("SedeOperativa").Visible = False
         .Columns("TipoPrestazione").Visible = False

         .Columns("DocumentoPadre").Visible = False
         '.Columns("DocumentoPadre").HeaderText = "Id documento"
         '.Columns("DocumentoPadre").DisplayIndex = 0

         .Columns("TipoDocumento").Visible = False
         '.Columns("TipoDocumento").HeaderText = "Tipo documento"
         '.Columns("TipoDocumento").DisplayIndex = 1


         .Columns("DataRegistrazione").Visible = False
         '.Columns("DataRegistrazione").HeaderText = "Data registrazione"
         '.Columns("DataRegistrazione").DisplayIndex = 2


         .Columns("DataDocumento").Visible = False
         '.Columns("DataDocumento").HeaderText = "Data documento"
         '.Columns("DataDocumento").DisplayIndex = 3

         .Columns("Importo").Visible = False
         '.Columns("Importo").HeaderText = "Importo posizione"
         '.Columns("Importo").ReadOnly = True
         '.Columns("Importo").DisplayIndex = 5

         .Columns("Utente").Visible = True
         .Columns("Utente").CellTemplate.Style.Font = New Font(.Columns("Utente").DataGridView.Font, FontStyle.Underline)
            .Columns("Utente").CellTemplate.Style.ForeColor = Color.Black
         .Columns("Utente").ReadOnly = True
         .Columns("Utente").DisplayIndex = 4

         .Columns("Competenza").Visible = True
         .Columns("Competenza").ReadOnly = True
         .Columns("Competenza").DisplayIndex = 6

         .Columns("PercentualeRistornoDeleghe").Visible = False
         '.Columns("PercentualeRistornoDeleghe").HeaderText = "Percentuale ristorno deleghe (%)"
         '.Columns("PercentualeRistornoDeleghe").ReadOnly = True
         '.Columns("PercentualeRistornoDeleghe").DisplayIndex = 8


         .Columns("ImportoRistorno").Visible = False
         '.Columns("ImportoRistorno").HeaderText = "Importo ristorno"
         '.Columns("ImportoRistorno").ReadOnly = True
         '.Columns("ImportoRistorno").DisplayIndex = 7


         .Columns("PagamentoReferente").Visible = False
         '.Columns("PagamentoReferente").HeaderText = "Id pagamento referente"
         '.Columns("PagamentoReferente").DisplayIndex = 9

         .Columns("SoggettoEsecutore").Visible = False
         '.Columns("SoggettoEsecutore").HeaderText = "Soggetto esecutore"
         '.Columns("SoggettoEsecutore").ReadOnly = True
         '.Columns("SoggettoEsecutore").DisplayIndex = 10

         .Columns("Referente").Visible = False
         '.Columns("Referente").ReadOnly = True
         '.Columns("Referente").DisplayIndex = 11


         .Columns("Settore").Visible = True
         .Columns("Settore").ReadOnly = True
         .Columns("Settore").DisplayIndex = 12

         .Columns("AziendaImpiego").Visible = True
         .Columns("AziendaImpiego").CellTemplate.Style.Font = New Font(.Columns("AziendaImpiego").DataGridView.Font, FontStyle.Underline)
            .Columns("AziendaImpiego").CellTemplate.Style.ForeColor = Color.Black
         .Columns("AziendaImpiego").ReadOnly = True
         .Columns("AziendaImpiego").DisplayIndex = 13

         .Columns("ContrattoApplicato").Visible = True
         .Columns("ContrattoApplicato").ReadOnly = True
         .Columns("ContrattoApplicato").DisplayIndex = 14

         .Columns("LivelloInquadramento").Visible = True
         .Columns("LivelloInquadramento").ReadOnly = True
         .Columns("LivelloInquadramento").DisplayIndex = 15

         .Columns("OreLavorate").Visible = False
         '.Columns("OreLavorate").ReadOnly = True
         '.Columns("OreLavorate").DisplayIndex = 16


         .Columns("OreMalattia").Visible = False
         '.Columns("OreMalattia").ReadOnly = True
         '.Columns("OreMalattia").DisplayIndex = 17

         .Columns("Tredicesima").Visible = False
         '.Columns("Tredicesima").ReadOnly = True
         '.Columns("Tredicesima").DisplayIndex = 18

         .Columns("Quattordicesima").Visible = False
         '.Columns("Quattordicesima").ReadOnly = True
         '.Columns("Quattordicesima").DisplayIndex = 19


         .Columns("Vertenza").Visible = False
         '.Columns("Vertenza").DisplayIndex = 20

         .Columns("Prestazione").Visible = False
         '.Columns("Prestazione").DisplayIndex = 21


      End With
   End Sub
End Class
