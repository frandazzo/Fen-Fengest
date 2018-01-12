Imports System.Windows.Forms
Imports WIN.APPLICATION.FINANCIAL_ARTIFACTS
Public Class GridLoaderViewIQA
   Inherits AbstractGridLoader
   Public Sub New(ByVal Grid As DataGridView)
      MyBase.New(Grid)
   End Sub
   Protected Overrides Sub LoadCustomListProperties(ByVal list As System.Collections.IList)
      With m_Grid
         Dim CongruityColumn As New DataGridViewImageColumn
         'If .Columns("KeyPos") Is Nothing Then
         '   .Columns.Add("KeyPos", "")
         'End If
         'If .Columns("DICompetenza") Is Nothing Then
         '   .Columns.Add("DICompetenza", "Data inizio competenza")
         'End If
         'If .Columns("DFCompetenza") Is Nothing Then
         '   .Columns.Add("DFCompetenza", "Data fine competenza")
         'End If
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
         .Columns("Competenza").Visible = False
         .Columns("GetImporto").Visible = False
         .Columns("PercentualeScarto").Visible = False
         .Columns("TipoConfrontoCompetenze").Visible = False
         .Columns("PercentualeRistornoDeleghe").Visible = False
         .Columns("TipoDocumento").Visible = False
         .Columns("Vertenza").Visible = False
         .Columns("Prestazione").Visible = False
         .Columns("IsRistornata").Visible = False
         .Columns("TipoPrestazione").Visible = False
         '.Columns("Path_Documento").Visible = False

         .Columns("Utente").Visible = True
         .Columns("Utente").DisplayIndex = 0

         .Columns("Importo").Visible = True
         .Columns("Importo").HeaderText = "Importo posizione"
         .Columns("Importo").ReadOnly = True
         .Columns("Importo").DisplayIndex = 1

         .Columns("Note").Visible = True
         .Columns("Note").ReadOnly = True
         .Columns("Note").DisplayIndex = 2

         .Columns("SoggettoEsecutore").Visible = True
         .Columns("SoggettoEsecutore").HeaderText = "Soggetto esecutore"
         .Columns("SoggettoEsecutore").DisplayIndex = 3

         .Columns("Referente").Visible = True
         .Columns("Referente").HeaderText = "Collaboratore comunale"
         .Columns("Referente").ReadOnly = True
         .Columns("Referente").DisplayIndex = 4


         .Columns("GetCompetenza").Visible = True
         .Columns("GetCompetenza").HeaderText = "Competenza"
         .Columns("GetCompetenza").ReadOnly = True
         .Columns("GetCompetenza").DisplayIndex = 5

         .Columns("TredicesimaInclusa").Visible = True
         .Columns("TredicesimaInclusa").HeaderText = "Incasso tredicesima"
         .Columns("TredicesimaInclusa").ReadOnly = True
         .Columns("TredicesimaInclusa").DisplayIndex = 6

         .Columns("QuattordicesimaInclusa").Visible = True
         .Columns("QuattordicesimaInclusa").HeaderText = "Incasso quattordicesima"
         .Columns("QuattordicesimaInclusa").ReadOnly = True
         .Columns("QuattordicesimaInclusa").DisplayIndex = 7


         .Columns("Settore").Visible = True
         .Columns("Settore").ReadOnly = True
         .Columns("Settore").DisplayIndex = 8


         .Columns("AziendaImpiego").Visible = True
         .Columns("AziendaImpiego").ReadOnly = True
         .Columns("AziendaImpiego").HeaderText = "Azienda di impiego"
         .Columns("AziendaImpiego").DisplayIndex = 9

         .Columns("SedeOperativaAzienda").Visible = True
         .Columns("SedeOperativaAzienda").HeaderText = "Sede operativa"
         .Columns("SedeOperativaAzienda").ReadOnly = True
         .Columns("SedeOperativaAzienda").DisplayIndex = 10

         .Columns("ContrattoApplicato").Visible = True
         .Columns("ContrattoApplicato").HeaderText = "Contratto applicato"
         .Columns("ContrattoApplicato").ReadOnly = True
         .Columns("ContrattoApplicato").DisplayIndex = 11


         .Columns("ImportoRistorno").Visible = True
         .Columns("ImportoRistorno").HeaderText = "Importo ristorno"
         .Columns("ImportoRistorno").ReadOnly = True
         .Columns("ImportoRistorno").DisplayIndex = 12


         .Columns("PagamentoReferente").Visible = True
         .Columns("PagamentoReferente").HeaderText = "Pag. collaboratore comunale"
         .Columns("PagamentoReferente").ReadOnly = True
         .Columns("PagamentoReferente").DisplayIndex = 13






         .Columns("QuotaMedia").Visible = True
         .Columns("QuotaMedia").HeaderText = "Quota media mensile"
         .Columns("QuotaMedia").ReadOnly = True
         .Columns("QuotaMedia").DisplayIndex = 14


         .Columns("QuotaMensileUtente").Visible = True
         .Columns("QuotaMensileUtente").HeaderText = "Quota mensile attesa"
         .Columns("QuotaMensileUtente").ReadOnly = True
         .Columns("QuotaMensileUtente").DisplayIndex = 15


       

         '.Columns("DICompetenza").Visible = True
         '.Columns("DICompetenza").HeaderText = "Data inizio competenza"
         '.Columns("DICompetenza").ReadOnly = True
         '.Columns("DICompetenza").DisplayIndex = 15

         '.Columns("DFCompetenza").Visible = True
         '.Columns("DFCompetenza").HeaderText = "Data fine competenza"
         '.Columns("DFCompetenza").ReadOnly = True
         '.Columns("DFCompetenza").DisplayIndex = 16


         'If .Columns("ColumnCongruita") Is Nothing Then
         '   .Columns.Add(CongruityColumn)
         'End If
         'CongruityColumn.Name = "ColumnCongruita"
         'CongruityColumn.HeaderText = ""
         'CongruityColumn.Visible = True
         'CongruityColumn.DisplayIndex = 17
         .Columns("GetCongruita").Visible = True
         .Columns("GetCongruita").DisplayIndex = 18
         .Columns("GetCongruita").HeaderText = "Valore congruità"


         .Columns("LivelloInquadramento").Visible = True
         .Columns("LivelloInquadramento").HeaderText = "Livello di inquadramento"
         .Columns("LivelloInquadramento").ReadOnly = True
         .Columns("LivelloInquadramento").DisplayIndex = 19

         .Columns("OreLavorate").Visible = True
         .Columns("OreLavorate").HeaderText = "Ore lavorate"
         .Columns("OreLavorate").ReadOnly = True
         .Columns("OreLavorate").DisplayIndex = 20

         .Columns("OreMalattia").Visible = True
         .Columns("OreMalattia").HeaderText = "Ore malattia"
         .Columns("OreMalattia").ReadOnly = True
         .Columns("OreMalattia").DisplayIndex = 21



         .Columns("Key").Visible = True
         .Columns("Key").HeaderText = ""
         .Columns("Key").Width = 1
         .Columns("Key").DisplayIndex = 22

         '.Columns("KeyPos").Visible = True
         '.Columns("KeyPos").HeaderText = ""
         '.Columns("KeyPos").Width = 1
         '.Columns("KeyPos").DisplayIndex = 23




      End With
   End Sub
   Protected Overrides Sub SetMainSettings()
        For Each elem As DataGridViewColumn In m_Grid.Columns
            elem.SortMode = DataGridViewColumnSortMode.Automatic
        Next


        m_Grid.SelectionMode = m_SelectionMode
        'm_Grid.RowHeadersWidthSizeMode = m_RowHeadersWidthSizeMode
        'm_Grid.AutoSizeColumnsMode = m_AutoSizeColumnsMode
        m_Grid.Visible = True

   End Sub
End Class
