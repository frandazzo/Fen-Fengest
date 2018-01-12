Imports System.Windows.Forms
Imports WIN.APPLICATION.FINANCIAL_ARTIFACTS
Public Class GridLoaderRptIscrittiDTO
   Inherits AbstractGridLoader
   Public Sub New(ByVal Grid As DataGridView)
      MyBase.New(Grid)
   End Sub
    Protected Overrides Sub LoadCustomListProperties(ByVal list As System.Collections.IList)
        With m_Grid

            .RowTemplate = Nothing

            .Columns("Id_Utente").Visible = False
            .Columns("Id_Azienda_Impiego").Visible = False
            .Columns("Id_Referente").Visible = False

            .Columns("Nome").Visible = False
            .Columns("Cognome").Visible = False
            .Columns("DataNascita").Visible = False
            .Columns("Codice_Fiscale").Visible = False
            .Columns("Indirizzo").Visible = False
            .Columns("Nome_Provincia_Nascita").Visible = False
            .Columns("Nome_Comune_Nascita").Visible = False

            .Columns("TipoDoc").Visible = False






            '.Columns("TipoDocumento").HeaderText = "Tipo documento"
            '.Columns("TipoDocumento").DisplayIndex = 1



            .Columns("Utente").Visible = True
            .Columns("Utente").CellTemplate.Style.Font = New Font(.Columns("Utente").DataGridView.Font, FontStyle.Underline)
            .Columns("Utente").CellTemplate.Style.ForeColor = Color.Black
            .Columns("Utente").ReadOnly = True
            .Columns("Utente").DisplayIndex = 1

            .Columns("Nome_Nazione").Visible = True
            .Columns("Nome_Nazione").HeaderText = "Nazionalità"
            .Columns("Nome_Nazione").DisplayIndex = 2

            .Columns("Nome_Provincia").Visible = True
            .Columns("Nome_Provincia").HeaderText = "Provincia di residenza"
            .Columns("Nome_Provincia").DisplayIndex = 3


            .Columns("Nome_Comune").Visible = True
            .Columns("Nome_Comune").HeaderText = "Comune di residenza"
            .Columns("Nome_Comune").DisplayIndex = 4

            .Columns("Indirizzo").Visible = True
            .Columns("Indirizzo").DisplayIndex = 5

            .Columns("Cap").Visible = True
            .Columns("Cap").DisplayIndex = 6

            .Columns("Competenza").Visible = True
            .Columns("Competenza").ReadOnly = True
            .Columns("Competenza").DisplayIndex = 7

            .Columns("Settore").Visible = True
            .Columns("Settore").ReadOnly = True
            .Columns("Settore").DisplayIndex = 8

            .Columns("AziendaImpiego").Visible = True
            .Columns("AziendaImpiego").CellTemplate.Style.Font = New Font(.Columns("AziendaImpiego").DataGridView.Font, FontStyle.Underline)
            .Columns("AziendaImpiego").CellTemplate.Style.ForeColor = Color.Black
            .Columns("AziendaImpiego").ReadOnly = True
            .Columns("AziendaImpiego").DisplayIndex = 9

            .Columns("Contratto").Visible = True
            .Columns("Contratto").ReadOnly = True
            .Columns("Contratto").DisplayIndex = 10

            .Columns("Livello").Visible = True
            .Columns("Livello").ReadOnly = True
            .Columns("Livello").DisplayIndex = 11

            .Columns("Causale").Visible = True
            .Columns("Causale").ReadOnly = True
            .Columns("Causale").DisplayIndex = 12

            .Columns("TipoPrestazione").Visible = True
            .Columns("TipoPrestazione").ReadOnly = True
            .Columns("TipoPrestazione").DisplayIndex = 13


        End With
    End Sub
End Class
