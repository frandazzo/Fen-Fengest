Imports System.Windows.Forms
Imports WIN.APPLICATION.FINANCIAL_ARTIFACTS
Public Class GridLoaderViewIQV
   Inherits AbstractGridLoader
   Public Sub New(ByVal Grid As DataGridView)
      MyBase.New(Grid)
   End Sub
   Protected Overrides Sub LoadCustomListProperties(ByVal list As System.Collections.IList)
      With m_Grid
         If Not .Columns.Contains("IdUtente") Then
            .Columns.Add("IdUtente", "Id Utente")
         End If
         If Not .Columns.Contains("IdReferente") Then
            .Columns.Add("IdReferente", "Id Referente")
         End If



         .Columns("Selezione").Visible = False
         .Columns("Prestazione").Visible = False
         .Columns("PosizioneUtente").Visible = False
         .Columns("PercentualeRistornoDeleghe").Visible = False
         .Columns("GetQuotaMedia").Visible = False
         .Columns("GetCongruitaToString").Visible = False
         .Columns("DataRegistrazione").Visible = False
         .Columns("DataDocumento").Visible = False
         .Columns("TipoDocumento").Visible = False
         .Columns("DocumentoPadre").Visible = False
         .Columns("SoggettoEsecutore").Visible = False
         .Columns("Settore").Visible = False
        
         .Columns("Conto").Visible = False
         .Columns("IdUtente").Visible = False
         .Columns("IdReferente").Visible = False
         .Columns("Tredicesima").Visible = False
         .Columns("Quattordicesima").Visible = False
         .Columns("ContrattoApplicato").Visible = False
         .Columns("LivelloInquadramento").Visible = False
         .Columns("OreLavorate").Visible = False
         .Columns("OreMalattia").Visible = False
         .Columns("AziendaImpiego").Visible = False
         .Columns("Competenza").Visible = False
         .Columns("SedeOperativaAzienda").Visible = False
         .Columns("TipoPrestazione").Visible = False

         .Columns("Utente").Visible = True
         .Columns("Utente").ReadOnly = True
         .Columns("Utente").DisplayIndex = 2


         .Columns("Importo").Visible = True
         .Columns("Importo").HeaderText = "Importo posizione"
         .Columns("Importo").ReadOnly = True
         .Columns("Importo").DisplayIndex = 3

         .Columns("Note").Visible = True
         .Columns("Note").ReadOnly = True
         .Columns("Note").DisplayIndex = 5

         .Columns("Referente").Visible = True
         .Columns("Referente").HeaderText = "Collaboratore comunale"
         .Columns("Referente").DisplayIndex = 6



         .Columns("Vertenza").Visible = False


         .Columns("ImportoRistorno").Visible = True
         .Columns("ImportoRistorno").HeaderText = "Importo ristorno"
         .Columns("ImportoRistorno").ReadOnly = True
         .Columns("ImportoRistorno").DisplayIndex = 8

         .Columns("PagamentoReferente").Visible = True
         .Columns("PagamentoReferente").HeaderText = "Pag. collaboratore comunale"
         .Columns("PagamentoReferente").ReadOnly = True
         .Columns("PagamentoReferente").DisplayIndex = 9



      End With
   End Sub
   Protected Overrides Sub SetMainSettings()
      For Each elem As DataGridViewColumn In m_Grid.Columns
         elem.SortMode = DataGridViewColumnSortMode.Automatic
      Next
      MyBase.SetMainSettings()
   End Sub
End Class

