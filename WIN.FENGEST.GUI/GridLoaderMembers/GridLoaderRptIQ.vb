Imports System.Windows.Forms
Imports WIN.APPLICATION.FINANCIAL_ARTIFACTS
Public Class GridLoaderRptIQ
    Inherits AbstractGridLoader
    Public Sub New(ByVal Grid As DataGridView)
        MyBase.New(Grid)
    End Sub
    Protected Overrides Sub LoadCustomListProperties(ByVal list As System.Collections.IList)
        With m_Grid
            .Columns.Add("KeyPos", "")
            .RowTemplate = Nothing

          


            .Columns("IdUtente").Visible = False
            .Columns("IdAziendaImpiego").Visible = False
            .Columns("IdSoggettoEsecutore").Visible = False
            .Columns("IdSettore").Visible = False
            .Columns("IdContrattoApplicato").Visible = False
            .Columns("Note").Visible = False
            .Columns("IdReferente").Visible = False


           

     




       



            .Columns("Utente").Visible = True
            .Columns("Utente").CellTemplate.Style.Font = New Font(.Columns("Utente").DataGridView.Font, FontStyle.Underline)
            .Columns("Utente").CellTemplate.Style.ForeColor = Color.Black
            .Columns("Utente").ReadOnly = True
            .Columns("Utente").DisplayIndex = 1


            .Columns("Settore").Visible = True
            .Columns("Settore").ReadOnly = True
            .Columns("Settore").DisplayIndex = 2

            .Columns("AziendaImpiego").Visible = True
            .Columns("AziendaImpiego").ReadOnly = True
            .Columns("AziendaImpiego").CellTemplate.Style.Font = New Font(.Columns("AziendaImpiego").DataGridView.Font, FontStyle.Underline)
            .Columns("AziendaImpiego").CellTemplate.Style.ForeColor = Color.Black
            .Columns("AziendaImpiego").DisplayIndex = 3

            .Columns("Competenza").Visible = True
            .Columns("Competenza").ReadOnly = True
            .Columns("Competenza").DisplayIndex = 4

            .Columns("Importo").Visible = True
            .Columns("Importo").HeaderText = "Importo posizione"
            .Columns("Importo").ReadOnly = True
            .Columns("Importo").DisplayIndex = 5

           

          

            '.Columns("PercentualeRistornoDeleghe").Visible = True
            '.Columns("PercentualeRistornoDeleghe").HeaderText = "Percentuale ristorno deleghe (%)"
            '.Columns("PercentualeRistornoDeleghe").ReadOnly = True
            '.Columns("PercentualeRistornoDeleghe").DisplayIndex = 8


          
            .Columns("SoggettoEsecutore").Visible = True
            .Columns("SoggettoEsecutore").HeaderText = "Soggetto esecutore"
            .Columns("SoggettoEsecutore").CellTemplate.Style.Font = New Font(.Columns("SoggettoEsecutore").DataGridView.Font, FontStyle.Underline)
            .Columns("SoggettoEsecutore").CellTemplate.Style.ForeColor = Color.Black
            .Columns("SoggettoEsecutore").ReadOnly = True
            .Columns("SoggettoEsecutore").DisplayIndex = 6



            If .Columns("DocumentoPadre") IsNot Nothing Then
                .Columns("DocumentoPadre").Visible = True
                .Columns("DocumentoPadre").HeaderText = "Id documento"
                .Columns("DocumentoPadre").CellTemplate.Style.Font = New Font(.Columns("DocumentoPadre").DataGridView.Font, FontStyle.Underline)
                .Columns("DocumentoPadre").CellTemplate.Style.ForeColor = Color.Black
                .Columns("DocumentoPadre").DisplayIndex = 7
            End If

            .Columns("TipoDocumento").Visible = True
            .Columns("TipoDocumento").HeaderText = "Tipo documento"
            .Columns("TipoDocumento").DisplayIndex = 8


            .Columns("DataDocumento").Visible = True
            .Columns("DataDocumento").HeaderText = "Data documento"
            .Columns("DataDocumento").DisplayIndex = 9



            .Columns("DataRegistrazione").Visible = True
            .Columns("DataRegistrazione").HeaderText = "Data registrazione"
            .Columns("DataRegistrazione").DisplayIndex = 10



            .Columns("Referente").Visible = True
            .Columns("Referente").ReadOnly = True
            .Columns("Referente").HeaderText = "Collaboratore comunale"
            .Columns("Referente").CellTemplate.Style.Font = New Font(.Columns("Referente").DataGridView.Font, FontStyle.Underline)
            .Columns("Referente").CellTemplate.Style.ForeColor = Color.Black
            .Columns("Referente").DisplayIndex = 11



            .Columns("SedeOperativa").Visible = True
            .Columns("SedeOperativa").ReadOnly = True
            .Columns("SedeOperativa").DisplayIndex = 12

            .Columns("ContrattoApplicato").Visible = True
            .Columns("ContrattoApplicato").ReadOnly = True
            .Columns("ContrattoApplicato").DisplayIndex = 13

            .Columns("LivelloInquadramento").Visible = True
            .Columns("LivelloInquadramento").ReadOnly = True
            .Columns("LivelloInquadramento").DisplayIndex = 14

            .Columns("OreLavorate").Visible = True
            .Columns("OreLavorate").ReadOnly = True
            .Columns("OreLavorate").DisplayIndex = 15


            .Columns("OreMalattia").Visible = True
            .Columns("OreMalattia").ReadOnly = True
            .Columns("OreMalattia").DisplayIndex = 16

            .Columns("Tredicesima").Visible = True
            .Columns("Tredicesima").ReadOnly = True
            .Columns("Tredicesima").DisplayIndex = 17

            .Columns("Quattordicesima").Visible = True
            .Columns("Quattordicesima").ReadOnly = True
            .Columns("Quattordicesima").DisplayIndex = 18


            .Columns("IdVertenza").Visible = True
            .Columns("IdVertenza").CellTemplate.Style.Font = New Font(.Columns("IdVertenza").DataGridView.Font, FontStyle.Underline)
            .Columns("IdVertenza").CellTemplate.Style.ForeColor = Color.Black
            .Columns("IdVertenza").DisplayIndex = 19

            .Columns("IdPrestazione").Visible = True
            .Columns("IdPrestazione").CellTemplate.Style.Font = New Font(.Columns("IdPrestazione").DataGridView.Font, FontStyle.Underline)
            .Columns("IdPrestazione").CellTemplate.Style.ForeColor = Color.Black
            .Columns("IdPrestazione").DisplayIndex = 20


            .Columns("TipoPrestazione").Visible = True
            .Columns("TipoPrestazione").ReadOnly = True
            .Columns("TipoPrestazione").DisplayIndex = 21

            .Columns("ImportoRistorno").Visible = True
            .Columns("ImportoRistorno").HeaderText = "Importo ristorno"
            .Columns("ImportoRistorno").ReadOnly = True
            .Columns("ImportoRistorno").DisplayIndex = 22


            .Columns("PagamentoReferente").Visible = True
            .Columns("PagamentoReferente").HeaderText = "Id pagamento coll. comunale"
            .Columns("PagamentoReferente").CellTemplate.Style.Font = New Font(.Columns("PagamentoReferente").DataGridView.Font, FontStyle.Underline)
            .Columns("PagamentoReferente").CellTemplate.Style.ForeColor = Color.Black
            .Columns("PagamentoReferente").DisplayIndex = 23



        End With
    End Sub
End Class
