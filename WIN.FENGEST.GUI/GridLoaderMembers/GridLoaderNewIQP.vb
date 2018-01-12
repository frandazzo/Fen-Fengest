
Imports System.Windows.Forms
Imports WIN.APPLICATION.FINANCIAL_ARTIFACTS
Public Class GridLoaderNewIQP
    Inherits AbstractGridLoader
    Protected m_controller As ControllerIncassiQuotePrevisionali
    Public Sub New(ByVal Grid As DataGridView, ByVal Controller As ControllerIncassiQuotePrevisionali)
        MyBase.New(Grid)
        m_controller = Controller
    End Sub
    Protected Overrides Sub LoadCustomListProperties(ByVal list As System.Collections.IList)
        With m_Grid


            Dim CercaReferenti As New DataGridViewButtonColumn
            Dim CercaAziendaImpiego As New DataGridViewButtonColumn
            Dim SelCompetenza As New DataGridViewButtonColumn
            Dim SelSede As New DataGridViewButtonColumn



            .Columns.Add("ImportoPosizione", "Importo posizione")
            .Columns.Add("IdUtente", "Id Utente")
            .Columns.Add("IdSettore", "Id Settore")
            .Columns.Add("IdTipoContratto", "Id TipoContratto")
            .Columns.Add("IdReferente", "Id Referente")
            .Columns.Add("IdAziendaImpiego", "Id Azienda Impiego")
            .Columns.Add("DICompetenza", "Data inizio competenza")
            .Columns.Add("DFCompetenza", "Data fine competenza")
            .Columns.Add(CercaReferenti)
            .Columns.Add(CercaAziendaImpiego)
            .Columns.Add(SelCompetenza)
            .Columns.Add(SelSede)


            CercaReferenti.Name = "CercaReferenti"
            CercaReferenti.HeaderText = ""
            CercaReferenti.Text = "..."
            CercaReferenti.Width = 20
            CercaReferenti.UseColumnTextForButtonValue = True

            CercaAziendaImpiego.Name = "CercaAziendaImpiego"
            CercaAziendaImpiego.HeaderText = ""
            CercaAziendaImpiego.Text = "..."
            CercaAziendaImpiego.Width = 20
            CercaAziendaImpiego.UseColumnTextForButtonValue = True

            SelCompetenza.Name = "SelCompetenza"
            SelCompetenza.HeaderText = ""
            SelCompetenza.Text = "..."
            SelCompetenza.Width = 20
            SelCompetenza.UseColumnTextForButtonValue = True

            SelSede.Name = "SelSede"
            SelSede.HeaderText = ""
            SelSede.Text = "..."
            SelSede.Width = 20
            SelSede.UseColumnTextForButtonValue = True
            .Columns("TipoPrestazione").Visible = False
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
            .Columns("Prestazione").Visible = False
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
            .Columns("IdAziendaImpiego").Visible = False
            .Columns("Settore").Visible = False
            .Columns("IdSettore").Visible = False
            .Columns("IdTipoContratto").Visible = False
            .Columns("Selezione").Visible = False
            '.Columns("Path_Documento").Visible = False



            .Columns("Utente").Visible = True
            .Columns("Utente").ReadOnly = True
            .Columns("Utente").DisplayIndex = 0

            .Columns("ImportoPosizione").Visible = True
            .Columns("ImportoPosizione").DisplayIndex = 1

            .Columns("Importo").Visible = True
            .Columns("Importo").HeaderText = "Valuta posizione"
            .Columns("Importo").ReadOnly = True
            .Columns("Importo").DisplayIndex = 2

            .Columns("Note").Visible = True
            .Columns("Note").DisplayIndex = 3

            .Columns("Referente").Visible = True
            .Columns("Referente").HeaderText = "Collaboratore comunale"
            .Columns("Referente").DisplayIndex = 5

            CercaReferenti.Visible = True
            CercaReferenti.DisplayIndex = 6

            .Columns("Tredicesima").Visible = True
            .Columns("Tredicesima").HeaderText = "Tredicesima"
            .Columns("Tredicesima").DisplayIndex = 7

            .Columns("Quattordicesima").Visible = True
            .Columns("Quattordicesima").HeaderText = "Quattordicesima"
            .Columns("Quattordicesima").DisplayIndex = 8

            .Columns("Competenza").Visible = True
            .Columns("Competenza").ReadOnly = True
            .Columns("Competenza").DisplayIndex = 9

            SelCompetenza.Visible = True
            SelCompetenza.DisplayIndex = 10


            .Columns("AziendaImpiego").Visible = True
            .Columns("AziendaImpiego").ReadOnly = True
            .Columns("AziendaImpiego").DisplayIndex = 11





            If m_controller.IsForSettoreEdile Then
                CercaAziendaImpiego.Visible = True
                CercaAziendaImpiego.DisplayIndex = 12
            Else
                CercaAziendaImpiego.Visible = False
            End If


            .Columns("SedeOperativaAzienda").Visible = True
            .Columns("SedeOperativaAzienda").HeaderText = "Sede operativa"
            .Columns("SedeOperativaAzienda").ReadOnly = True
            .Columns("SedeOperativaAzienda").DisplayIndex = 13

            SelSede.Visible = True
            SelSede.DisplayIndex = 14


        End With
    End Sub
End Class

