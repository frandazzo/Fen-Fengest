
Imports System.Windows.Forms
Imports WIN.APPLICATION.FINANCIAL_ARTIFACTS
Public Class GridLoaderElaborazioniMassiveDeleghe
    Inherits AbstractGridLoader
    Public Sub New(ByVal Grid As DataGridView)
        MyBase.New(Grid)
    End Sub
    Protected Overrides Sub LoadCustomListProperties(ByVal list As System.Collections.IList)
        With m_Grid

            .RowTemplate = Nothing

            '.Columns("Selected").Visible = True
            '.Columns("Selected").DisplayIndex = 0
            '.Columns("Selected").HeaderText = "..."


            .Columns("IdEnteInoltro").Visible = False
            .Columns("IdSettore").Visible = False
            .Columns("IdUtente").Visible = False
            .Columns("IdReferente").Visible = False
            .Columns("IdResponsabile").Visible = False
            .Columns("Note").Visible = False
            .Columns("IdContratto").Visible = False
            .Columns("DataAccettazioneDelega").Visible = False
            .Columns("DataDecorrenzaDelega").Visible = False
            .Columns("DataAnnullamentoDelega").Visible = False
            .Columns("DataRevocaDelega").Visible = False
            .Columns("CausaleFineCiclo").Visible = False
            .Columns("SedeOperativa").Visible = False
            .Columns("Reparto").Visible = False
            .Columns("Referente").Visible = False
            .Columns("Responsabile").Visible = False

            .Columns("Indirizzo").Visible = False
            .Columns("Nome").Visible = False
            .Columns("Cognome").Visible = False
            .Columns("DataNascita").Visible = False
            .Columns("Codice_Fiscale").Visible = False
            .Columns("Nome_Nazione").Visible = False
            .Columns("Nome_Comune").Visible = False
            .Columns("Nome_Provincia").Visible = False
            .Columns("Cap").Visible = False



            .Columns("Selected").Visible = True
            .Columns("Selected").DisplayIndex = 0

            .Columns("Id").Visible = True
            .Columns("Id").HeaderText = "Id delega"
            .Columns("Id").CellTemplate.Style.Font = New Font(.Columns("Id").DataGridView.Font, FontStyle.Underline)
            .Columns("Id").CellTemplate.Style.ForeColor = Color.Black
            .Columns("Id").DisplayIndex = 1



            .Columns("DataDocumento").Visible = True
            .Columns("DataDocumento").HeaderText = "Data documento"
            .Columns("DataDocumento").DisplayIndex = 2

            .Columns("Utente").Visible = True
            .Columns("Utente").HeaderText = "Utente"
            .Columns("Utente").CellTemplate.Style.Font = New Font(.Columns("Utente").DataGridView.Font, FontStyle.Underline)
            .Columns("Utente").CellTemplate.Style.ForeColor = Color.Black

            .Columns("Utente").DisplayIndex = 3


            .Columns("Settore").Visible = True
            .Columns("Settore").HeaderText = "Settore"
            .Columns("Settore").DisplayIndex = 4

            .Columns("EnteInoltro").Visible = True
            .Columns("EnteInoltro").CellTemplate.Style.Font = New Font(.Columns("EnteInoltro").DataGridView.Font, FontStyle.Underline)
            .Columns("EnteInoltro").CellTemplate.Style.ForeColor = Color.Black
            .Columns("EnteInoltro").HeaderText = "Ente di inoltro"
            .Columns("EnteInoltro").DisplayIndex = 5



            .Columns("StatoDelega").Visible = True
            .Columns("StatoDelega").HeaderText = "Stato delega"
            .Columns("StatoDelega").DisplayIndex = 6




            .Columns("CausaleSottoscrizione").Visible = True
            .Columns("CausaleSottoscrizione").HeaderText = "Causale sottoscrizione"
            .Columns("CausaleSottoscrizione").DisplayIndex = 7



            .Columns("DataRegistrazione").Visible = True
            .Columns("DataRegistrazione").HeaderText = "Data registrazione"
            .Columns("DataRegistrazione").DisplayIndex = 8

            .Columns("DataInoltro").Visible = True
            .Columns("DataInoltro").HeaderText = "Data inoltro"
            .Columns("DataInoltro").DisplayIndex = 9




        End With
    End Sub
End Class

