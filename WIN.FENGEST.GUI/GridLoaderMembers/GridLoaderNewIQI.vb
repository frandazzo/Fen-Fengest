Imports System.Windows.Forms
Imports WIN.APPLICATION.FINANCIAL_ARTIFACTS
Public Class GridLoaderNewIQI
   Inherits AbstractGridLoader
   Protected m_controller As ControllerIncassiQuote
   Public Sub New(ByVal Grid As DataGridView, ByVal Controller As ControllerIncassiQuote)
      MyBase.New(Grid)
      m_controller = Controller
   End Sub
   Protected Overrides Sub LoadCustomListProperties(ByVal list As System.Collections.IList)
      With m_Grid


         Dim CercaReferenti As New DataGridViewButtonColumn
         'Dim CercaAziendaImpiego As New DataGridViewButtonColumn
         Dim SelCompetenza As New DataGridViewButtonColumn


         .Columns("Selezione").Visible = False
         .Columns.Add("ImportoPosizione", "Importo posizione")
         .Columns.Add("IdUtente", "Id Utente")
         .Columns.Add("IdReferente", "Id Referente")
         .Columns.Add("DICompetenza", "Data inizio competenza")
         .Columns.Add("DFCompetenza", "Data fine competenza")

         .Columns.Add(CercaReferenti)
         .Columns.Add(SelCompetenza)


         CercaReferenti.Name = "CercaReferenti"
         CercaReferenti.HeaderText = ""
         CercaReferenti.Text = "..."
         CercaReferenti.Width = 20
         CercaReferenti.UseColumnTextForButtonValue = True


         SelCompetenza.Name = "SelCompetenza"
         SelCompetenza.HeaderText = ""
         SelCompetenza.Text = "..."
         SelCompetenza.Width = 20
         SelCompetenza.UseColumnTextForButtonValue = True



         .Columns("PercentualeRistornoDeleghe").Visible = False
         .Columns("GetCongruita").Visible = False
         .Columns("DataRegistrazione").Visible = False
         .Columns("DataDocumento").Visible = False
         .Columns("GetImporto").Visible = False
         .Columns("GetQuotaMedia").Visible = False
         .Columns("TipoDocumento").Visible = False
         .Columns("GetCompetenza").Visible = False
         .Columns("QuattordicesimaInclusa").Visible = False
         .Columns("TredicesimaInclusa").Visible = False
         .Columns("DocumentoPadre").Visible = False
         .Columns("TipoConfrontoCompetenze").Visible = False
         .Columns("SoggettoEsecutore").Visible = False
         .Columns("Settore").Visible = False
         .Columns("Vertenza").Visible = False
         .Columns("IsRistornata").Visible = False
         .Columns("ImportoRistorno").Visible = False
         .Columns("PagamentoReferente").Visible = False
         .Columns("Conto").Visible = False
         .Columns("QuotaMensileUtente").Visible = False
         .Columns("GetCongruitaToString").Visible = False
         .Columns("QuotaMedia").Visible = False
         .Columns("DICompetenza").Visible = False
         .Columns("DFCompetenza").Visible = False
         .Columns("PercentualeScarto").Visible = False
         .Columns("IdUtente").Visible = False
         .Columns("IdReferente").Visible = False
         .Columns("Settore").Visible = False
         .Columns("Tredicesima").Visible = False
         .Columns("Quattordicesima").Visible = False
         .Columns("ContrattoApplicato").Visible = False
         .Columns("LivelloInquadramento").Visible = False
         .Columns("OreLavorate").Visible = False
         .Columns("OreMalattia").Visible = False
         .Columns("AziendaImpiego").Visible = False

         .Columns("SedeOperativaAzienda").Visible = False

         .Columns("Prestazione").Visible = True
         .Columns("Prestazione").HeaderText = "Id prestazione"
         .Columns("Prestazione").ReadOnly = True
         .Columns("Prestazione").DisplayIndex = 0


         .Columns("TipoPrestazione").Visible = True
         .Columns("TipoPrestazione").ReadOnly = True
         .Columns("TipoPrestazione").DisplayIndex = 1

         .Columns("Utente").Visible = True
         .Columns("Utente").ReadOnly = True
         .Columns("Utente").DisplayIndex = 2

         .Columns("ImportoPosizione").Visible = True
         .Columns("ImportoPosizione").DisplayIndex = 3

         .Columns("Importo").Visible = True
         .Columns("Importo").HeaderText = "Valuta posizione"
         .Columns("Importo").ReadOnly = True
         .Columns("Importo").DisplayIndex = 4

         .Columns("Note").Visible = True
         .Columns("Note").DisplayIndex = 5

         .Columns("Referente").Visible = True
         .Columns("Referente").HeaderText = "Collaboratore comunale"
         .Columns("Referente").DisplayIndex = 6

         CercaReferenti.Visible = True
         CercaReferenti.DisplayIndex = 7


         .Columns("Competenza").Visible = True
         .Columns("Competenza").ReadOnly = True
         .Columns("Competenza").DisplayIndex = 10

         SelCompetenza.Visible = True
         SelCompetenza.DisplayIndex = 11


      End With
   End Sub
End Class
