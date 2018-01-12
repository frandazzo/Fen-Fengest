Imports System.Windows.Forms
Imports WIN.APPLICATION.FINANCIAL_ARTIFACTS
Public Class GridLoaderViewIQI
   Inherits AbstractGridLoader
   Public Sub New(ByVal Grid As DataGridView)
      MyBase.New(Grid)
   End Sub
   Protected Overrides Sub LoadCustomListProperties(ByVal list As System.Collections.IList)
      With m_Grid
         Dim CongruityColumn As New DataGridViewImageColumn
         If .Columns("KeyPos") Is Nothing Then
            .Columns.Add("KeyPos", "")
         End If
         'If .Columns("DICompetenza") Is Nothing Then
         '   .Columns.Add("DICompetenza", "Data inizio competenza")
         'End If
         'If .Columns("DFCompetenza") Is Nothing Then
         '   .Columns.Add("DFCompetenza", "Data fine competenza")
         'End If
         If .Columns("TipoPrestazione") Is Nothing Then
            .Columns.Add("TipoPrestazione", "Tipo prestazione")
         End If

    
         .Columns("Selezione").Visible = False
         .Columns("DataRegistrazione").Visible = False
         .Columns("DataDocumento").Visible = False
         .Columns("GetQuotaMedia").Visible = False
         .Columns("Tredicesima").Visible = False
         .Columns("Quattordicesima").Visible = False
         .Columns("DocumentoPadre").Visible = False
         .Columns("GetCongruitaToString").Visible = False
         .Columns("Conto").Visible = False
         .Columns("GetCongruita").Visible = False
         .Columns("GetCompetenza").Visible = False
         .Columns("GetImporto").Visible = False
         .Columns("PercentualeScarto").Visible = False
         .Columns("TipoConfrontoCompetenze").Visible = False
         .Columns("PercentualeRistornoDeleghe").Visible = False
         .Columns("TipoDocumento").Visible = False
         .Columns("Vertenza").Visible = False
         .Columns("TredicesimaInclusa").Visible = False
         .Columns("QuattordicesimaInclusa").Visible = False
         .Columns("Settore").Visible = False
         .Columns("AziendaImpiego").Visible = False
         .Columns("QuotaMensileUtente").Visible = False
         .Columns("LivelloInquadramento").Visible = False
         .Columns("OreLavorate").Visible = False
         .Columns("OreMalattia").Visible = False
         .Columns("ContrattoApplicato").Visible = False
         .Columns("GetCongruita").Visible = False
         .Columns("IsRistornata").Visible = False
         .Columns("QuotaMedia").Visible = False
         .Columns("SoggettoEsecutore").Visible = False
         .Columns("SedeOperativaAzienda").Visible = False



         .Columns("Utente").Visible = True
         .Columns("Utente").DisplayIndex = 0

         .Columns("TipoPrestazione").Visible = True
         .Columns("TipoPrestazione").ReadOnly = True
         .Columns("TipoPrestazione").DisplayIndex = 1





         .Columns("Importo").Visible = True
         .Columns("Importo").HeaderText = "Importo posizione"
         .Columns("Importo").ReadOnly = True
         .Columns("Importo").DisplayIndex = 2

         .Columns("Note").Visible = True
         .Columns("Note").ReadOnly = True
         .Columns("Note").DisplayIndex = 3




         .Columns("Referente").Visible = True
         .Columns("Referente").HeaderText = "Collaboratore comunale"
         .Columns("Referente").ReadOnly = True
         .Columns("Referente").DisplayIndex = 4



         .Columns("Prestazione").Visible = True
         '.Columns("Prestazione").HeaderText = "Id prestazione"
         .Columns("Prestazione").ReadOnly = True
         .Columns("Prestazione").DisplayIndex = 6

         .Columns("ImportoRistorno").Visible = True
         .Columns("ImportoRistorno").HeaderText = "Importo ristorno"
         .Columns("ImportoRistorno").ReadOnly = True
         .Columns("ImportoRistorno").DisplayIndex = 7


         .Columns("PagamentoReferente").Visible = True
         .Columns("PagamentoReferente").HeaderText = "Pag. collaboratore comunale"
         .Columns("PagamentoReferente").ReadOnly = True
         .Columns("PagamentoReferente").DisplayIndex = 8



         .Columns("Competenza").Visible = True
         .Columns("Competenza").HeaderText = "Competenza"
         .Columns("Competenza").ReadOnly = True
         .Columns("Competenza").DisplayIndex = 5

         '.Columns("DICompetenza").Visible = False
         '.Columns("DICompetenza").HeaderText = "Data inizio competenza"
         '.Columns("DICompetenza").ReadOnly = True
         '.Columns("DICompetenza").DisplayIndex = 11

         '.Columns("DFCompetenza").Visible = False
         '.Columns("DFCompetenza").HeaderText = "Data fine competenza"
         '.Columns("DFCompetenza").ReadOnly = True
         '.Columns("DFCompetenza").DisplayIndex = 12



         .Columns("Key").Visible = True
         .Columns("Key").HeaderText = ""
         .Columns("Key").Width = 1
         .Columns("Key").DisplayIndex = 15

         .Columns("KeyPos").Visible = True
         .Columns("KeyPos").HeaderText = ""
         .Columns("KeyPos").Width = 1
         .Columns("KeyPos").DisplayIndex = 16




      End With
   End Sub
   Protected Overrides Sub SetMainSettings()
      For Each elem As DataGridViewColumn In m_Grid.Columns
         elem.SortMode = DataGridViewColumnSortMode.Automatic
      Next
      MyBase.SetMainSettings()
   End Sub
End Class

