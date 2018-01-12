Imports System.Windows.Forms
Imports WIN.APPLICATION.FINANCIAL_ARTIFACTS
Public Class GridLoaderNewIQV
   Inherits AbstractGridLoader
   ' Protected m_controller As ControllerIncassiQuot
   Public Sub New(ByVal Grid As DataGridView)
      MyBase.New(Grid)
      ' m_controller = Controller
   End Sub
   Protected Overrides Sub LoadCustomListProperties(ByVal list As System.Collections.IList)
      With m_Grid


         Dim CercaReferenti As New DataGridViewButtonColumn
         'Dim CercaAziendaImpiego As New DataGridViewButtonColumn
         ' Dim SelCompetenza As New DataGridViewButtonColumn



         .Columns.Add("ImportoPosizione", "Importo posizione")
         .Columns.Add("IdUtente", "Id Utente")
         .Columns.Add("IdReferente", "Id Referente")
         .Columns.Add(CercaReferenti)



         CercaReferenti.Name = "CercaReferenti"
         CercaReferenti.HeaderText = ""
         CercaReferenti.Text = "..."
         CercaReferenti.Width = 20
         CercaReferenti.UseColumnTextForButtonValue = True

         .Columns("TipoPrestazione").Visible = False
         .Columns("PercentualeRistornoDeleghe").Visible = False
         .Columns("ImportoPosizione").Visible = False
         .Columns("DataRegistrazione").Visible = False
         .Columns("DataDocumento").Visible = False
         .Columns("GetQuotaMedia").Visible = False
         .Columns("TipoDocumento").Visible = False
         .Columns("DocumentoPadre").Visible = False
         .Columns("SoggettoEsecutore").Visible = False
         .Columns("Settore").Visible = False
         .Columns("ImportoRistorno").Visible = False
         .Columns("PagamentoReferente").Visible = False
         .Columns("Conto").Visible = False
         .Columns("GetCongruitaToString").Visible = False
         .Columns("PosizioneUtente").Visible = False
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
         .Columns("Prestazione").Visible = False
         .Columns("IdUtente").Visible = False
         .Columns("IdReferente").Visible = False
         .Columns("Competenza").Visible = False
         .Columns("SedeOperativaAzienda").Visible = False
         .Columns("Selezione").Visible = False
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


         .Columns("Vertenza").Visible = True
         .Columns("Vertenza").ReadOnly = True
         .Columns("Vertenza").HeaderText = "Id vertenza"




      End With
   End Sub
End Class
