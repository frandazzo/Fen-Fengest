Imports System.Windows.Forms
Imports WIN.APPLICATION.FINANCIAL_ARTIFACTS
Public Class GridLoaderViewPGR
   Inherits AbstractGridLoader
   Public Sub New(ByVal Grid As DataGridView)
      MyBase.New(Grid)
   End Sub
   Protected Overrides Sub LoadCustomListProperties(ByVal list As System.Collections.IList)
      With m_Grid
         '.Columns.Add("KeyPos", "")

         '.Columns.Add("DICompetenza", "Data inizio competenza")
         '.Columns.Add("DFCompetenza", "Data fine competenza")
         If .Columns("KeyPos") Is Nothing Then
            .Columns.Add("KeyPos", "")
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
         .Columns("DataRegistrazione").Visible = False
         .Columns("DataDocumento").Visible = False
         .Columns("GetQuotaMedia").Visible = False
         .Columns("Tredicesima").Visible = False
         .Columns("Quattordicesima").Visible = False
         .Columns("DocumentoPadre").Visible = False
         .Columns("GetCongruitaToString").Visible = False
         .Columns("Conto").Visible = False
         .Columns("AziendaImpiego").Visible = False
         .Columns("ContrattoApplicato").Visible = False
         .Columns("OreLavorate").Visible = False
         .Columns("OreMalattia").Visible = False
         .Columns("LivelloInquadramento").Visible = False
         .Columns("Settore").Visible = False
         .Columns("Note").Visible = False
         .Columns("Referente").Visible = False
         .Columns("PagamentoReferente").Visible = False
         .Columns("Tredicesima").Visible = False
         .Columns("Quattordicesima").Visible = False


         
         '.Columns("GetCongruita").Visible = False
         '.Columns("GetImporto").Visible = False
         '.Columns("PercentualeScarto").Visible = False
         '.Columns("TipoConfrontoCompetenze").Visible = False
         '.Columns("GetCompetenza").Visible = False
         '.Columns("GetCongruita").Visible = False

         .Columns("DocumentoPadre").Visible = True
         .Columns("DocumentoPadre").HeaderText = "Id documento"
         .Columns("DocumentoPadre").DisplayIndex = 0

         .Columns("TipoDocumento").Visible = True
         .Columns("TipoDocumento").HeaderText = "Tipo documento"
         .Columns("TipoDocumento").DisplayIndex = 1

         .Columns("DataDocumento").Visible = True
         .Columns("DataDocumento").HeaderText = "Data documento"
         .Columns("DataDocumento").DisplayIndex = 7

         .Columns("Importo").Visible = True
         .Columns("Importo").HeaderText = "Importo posizione"
         .Columns("Importo").ReadOnly = True
         .Columns("Importo").DisplayIndex = 2

         .Columns("Utente").Visible = True
         .Columns("Utente").ReadOnly = True
         .Columns("Utente").DisplayIndex = 6

         .Columns("Competenza").Visible = True
         .Columns("Competenza").ReadOnly = True
         .Columns("Competenza").DisplayIndex = 8

         .Columns("PercentualeRistornoDeleghe").Visible = True
         .Columns("PercentualeRistornoDeleghe").HeaderText = "Perc. calc. ristorno"
         .Columns("PercentualeRistornoDeleghe").ReadOnly = True
         .Columns("PercentualeRistornoDeleghe").DisplayIndex = 5


         .Columns("ImportoRistorno").Visible = True
         .Columns("ImportoRistorno").HeaderText = "Importo ristorno"
         .Columns("ImportoRistorno").ReadOnly = True
         .Columns("ImportoRistorno").DisplayIndex = 4

         .Columns("SoggettoEsecutore").Visible = True
         .Columns("SoggettoEsecutore").HeaderText = "Soggetto esecutore"
         .Columns("SoggettoEsecutore").ReadOnly = True
         .Columns("SoggettoEsecutore").DisplayIndex = 10

         .Columns("Vertenza").Visible = True
         .Columns("Vertenza").ReadOnly = True
         .Columns("Vertenza").DisplayIndex = 11

         .Columns("Prestazione").Visible = True
         .Columns("Prestazione").ReadOnly = True
         .Columns("Prestazione").DisplayIndex = 12


         .Columns("Key").Visible = True
         .Columns("Key").HeaderText = ""
         .Columns("Key").Width = 1
         .Columns("Key").DisplayIndex = 16

         .Columns("KeyPos").Visible = True
         .Columns("KeyPos").HeaderText = ""
         .Columns("KeyPos").Width = 1
         .Columns("KeyPos").DisplayIndex = 17

      End With
   End Sub
End Class
