Imports System.Windows.Forms
Imports WIN.APPLICATION.FINANCIAL_ARTIFACTS
Imports System
Public Class GridLoaderNewPGR
   Inherits AbstractGridLoader

   Public Sub New(ByVal Grid As DataGridView)
      MyBase.New(Grid)
   End Sub
   Protected Overrides Sub LoadCustomListProperties(ByVal list As System.Collections.IList)
      With m_Grid


         '.Columns.Add("IdUtente", "Id Utente")
         '.Columns.Add("DICompetenza", "Data inizio competenza")
         '.Columns.Add("DFCompetenza", "Data fine competenza")
         .Columns.Add("ImpRist", "Modifica importo")
         If .Columns.Contains("SedeOperativaAzienda") Then
            .Columns("SedeOperativaAzienda").Visible = False
         End If

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

         If .Columns.Contains("SedeOperativa") Then
            .Columns("SedeOperativa").Visible = False
         End If


         If .Columns.Contains("TredicesimaInclusa") Then
            .Columns("TredicesimaInclusa").Visible = False
         End If
         If .Columns.Contains("QuattordicesimaInclusa") Then
            .Columns("QuattordicesimaInclusa").Visible = False
         End If
         If .Columns.Contains("QuotaMedia") Then
            .Columns("QuotaMedia").Visible = False
         End If
         If .Columns.Contains("QuotaMensileUtente") Then
            .Columns("QuotaMensileUtente").Visible = False
         End If


         If .Columns.Contains("IsRistornata") Then
            .Columns("IsRistornata").Visible = False
         End If
         If .Columns.Contains("GetCongruita") Then
            .Columns("GetCongruita").Visible = False
         End If

         If .Columns.Contains("GetImporto") Then
            .Columns("GetImporto").Visible = False
         End If
         If .Columns.Contains("PercentualeScarto") Then
            .Columns("PercentualeScarto").Visible = False
         End If
         If .Columns.Contains("TipoConfrontoCompetenze") Then
            .Columns("TipoConfrontoCompetenze").Visible = False
         End If
         If .Columns.Contains("GetCongruita") Then
            .Columns("GetCongruita").Visible = False
         End If
         If .Columns.Contains("GetCompetenza") Then
            .Columns("GetCompetenza").Visible = False
         End If

         If .Columns.Contains("PosizioneUtente") Then
            .Columns("PosizioneUtente").Visible = False
         End If



         .Columns("TipoDocumento").Visible = True
         .Columns("TipoDocumento").HeaderText = "Tipo documento"
         .Columns("TipoDocumento").DisplayIndex = 1

         .Columns("Importo").Visible = True
         .Columns("Importo").HeaderText = "Importo posizione"
         .Columns("Importo").ReadOnly = True
         .Columns("Importo").DisplayIndex = 2

         .Columns("ImpRist").Visible = True
         .Columns("ImpRist").HeaderText = "Modifica importo"
         .Columns("ImpRist").DisplayIndex = 3
         .Columns("ImpRist").DefaultCellStyle.BackColor = Drawing.Color.Gray


         .Columns("ImportoRistorno").Visible = True
         .Columns("ImportoRistorno").HeaderText = "Importo ristorno"
         .Columns("ImportoRistorno").ReadOnly = True
         .Columns("ImportoRistorno").DisplayIndex = 4


         .Columns("PercentualeRistornoDeleghe").Visible = True
         .Columns("PercentualeRistornoDeleghe").HeaderText = "Perc. calc. ristorno"
         .Columns("PercentualeRistornoDeleghe").ReadOnly = True
         .Columns("PercentualeRistornoDeleghe").DisplayIndex = 5

         .Columns("Utente").Visible = True
         .Columns("Utente").ReadOnly = True
         .Columns("Utente").DisplayIndex = 6


         .Columns("DataDocumento").Visible = True
         .Columns("DataDocumento").HeaderText = "Data documento"
         .Columns("DataDocumento").DisplayIndex = 7

         .Columns("Competenza").Visible = True
         .Columns("Competenza").ReadOnly = True
         .Columns("Competenza").DisplayIndex = 8

         .Columns("DocumentoPadre").Visible = True
         .Columns("DocumentoPadre").HeaderText = "Id documento"
         .Columns("DocumentoPadre").DisplayIndex = 9



         .Columns("SoggettoEsecutore").Visible = True
         .Columns("SoggettoEsecutore").HeaderText = "Soggetto esecutore"
         .Columns("SoggettoEsecutore").ReadOnly = True
         .Columns("SoggettoEsecutore").DisplayIndex = 10



         .Columns("Vertenza").Visible = True
         .Columns("Vertenza").HeaderText = "Id vertenza"
         .Columns("Vertenza").ReadOnly = True
         .Columns("Vertenza").DisplayIndex = 11


         .Columns("Prestazione").Visible = True
         .Columns("Prestazione").HeaderText = "Id prestazione"
         .Columns("Prestazione").ReadOnly = True
         .Columns("Prestazione").DisplayIndex = 12




         .Columns("TipoPrestazione").Visible = True
         .Columns("TipoPrestazione").HeaderText = "Tipo prestazione"
         .Columns("TipoPrestazione").ReadOnly = True
         .Columns("TipoPrestazione").DisplayIndex = 12
      End With
   End Sub
End Class

