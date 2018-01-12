
Imports System.Windows.Forms
Imports WIN.APPLICATION.FINANCIAL_ARTIFACTS
Public Class GridLoaderRptDeleghe
   Inherits AbstractGridLoader
   Public Sub New(ByVal Grid As DataGridView)
      MyBase.New(Grid)
   End Sub
   Protected Overrides Sub LoadCustomListProperties(ByVal list As System.Collections.IList)
      With m_Grid

         .RowTemplate = Nothing
        

         .Columns("IdEnteInoltro").Visible = False
         .Columns("IdSettore").Visible = False
         .Columns("IdUtente").Visible = False
         .Columns("IdReferente").Visible = False
         .Columns("IdResponsabile").Visible = False
         .Columns("Note").Visible = False
         .Columns("IdContratto").Visible = False
         .Columns("Selected").Visible = False


         .Columns("Id").Visible = True
         .Columns("Id").HeaderText = "Id delega"
         .Columns("Id").CellTemplate.Style.Font = New Font(.Columns("Id").DataGridView.Font, FontStyle.Underline)
            .Columns("Id").CellTemplate.Style.ForeColor = Color.Black
         .Columns("Id").DisplayIndex = 0



         .Columns("DataDocumento").Visible = True
         .Columns("DataDocumento").HeaderText = "Data documento"
         .Columns("DataDocumento").DisplayIndex = 1

         .Columns("Utente").Visible = True
         .Columns("Utente").HeaderText = "Utente"
         .Columns("Utente").CellTemplate.Style.Font = New Font(.Columns("Utente").DataGridView.Font, FontStyle.Underline)
            .Columns("Utente").CellTemplate.Style.ForeColor = Color.Black

         .Columns("Utente").DisplayIndex = 2


         .Columns("Settore").Visible = True
         .Columns("Settore").HeaderText = "Settore"
         .Columns("Settore").DisplayIndex = 3

         .Columns("EnteInoltro").Visible = True
         .Columns("EnteInoltro").CellTemplate.Style.Font = New Font(.Columns("EnteInoltro").DataGridView.Font, FontStyle.Underline)
            .Columns("EnteInoltro").CellTemplate.Style.ForeColor = Color.Black
         .Columns("EnteInoltro").HeaderText = "Ente di inoltro"
         .Columns("EnteInoltro").DisplayIndex = 4


         .Columns("SedeOperativa").Visible = True
         .Columns("SedeOperativa").HeaderText = "Nome sede operativa"
         .Columns("SedeOperativa").DisplayIndex = 5

         .Columns("Reparto").Visible = True
         .Columns("Reparto").HeaderText = "Reparto"
         .Columns("Reparto").DisplayIndex = 6


         .Columns("StatoDelega").Visible = True
         .Columns("StatoDelega").HeaderText = "Stato delega"
         .Columns("StatoDelega").DisplayIndex = 7

         .Columns("Referente").Visible = True
         .Columns("Referente").HeaderText = "Collaboratore comunale"
         .Columns("Referente").CellTemplate.Style.Font = New Font(.Columns("Referente").DataGridView.Font, FontStyle.Underline)
            .Columns("Referente").CellTemplate.Style.ForeColor = Color.Black
         .Columns("Referente").DisplayIndex = 8

         .Columns("Responsabile").Visible = True
         .Columns("Responsabile").HeaderText = "Responsabile"
         .Columns("Responsabile").CellTemplate.Style.Font = New Font(.Columns("Responsabile").DataGridView.Font, FontStyle.Underline)
            .Columns("Responsabile").CellTemplate.Style.ForeColor = Color.Black
         .Columns("Responsabile").DisplayIndex = 9


         .Columns("CausaleSottoscrizione").Visible = True
         .Columns("CausaleSottoscrizione").HeaderText = "Causale sottoscrizione"
         .Columns("CausaleSottoscrizione").DisplayIndex = 10



         .Columns("DataRegistrazione").Visible = True
         .Columns("DataRegistrazione").HeaderText = "Data registrazione"
         .Columns("DataRegistrazione").DisplayIndex = 11

         .Columns("DataInoltro").Visible = True
         .Columns("DataInoltro").HeaderText = "Data inoltro"
         .Columns("DataInoltro").DisplayIndex = 12

         .Columns("DataAccettazioneDelega").Visible = True
         .Columns("DataAccettazioneDelega").HeaderText = "Data accettazione"
         .Columns("DataAccettazioneDelega").DisplayIndex = 13


         .Columns("DataDecorrenzaDelega").Visible = True
         .Columns("DataDecorrenzaDelega").HeaderText = "Data attivazione"
         .Columns("DataDecorrenzaDelega").DisplayIndex = 14


         .Columns("DataAnnullamentoDelega").Visible = True
         .Columns("DataAnnullamentoDelega").HeaderText = "Data annullamento"
         .Columns("DataAnnullamentoDelega").DisplayIndex = 15


         .Columns("DataRevocaDelega").Visible = True
         .Columns("DataRevocaDelega").HeaderText = "Data revoca"
         .Columns("DataRevocaDelega").DisplayIndex = 16


         .Columns("CausaleFineCiclo").Visible = True
         .Columns("CausaleFineCiclo").HeaderText = "Causale fine ciclo"
         .Columns("CausaleFineCiclo").DisplayIndex = 17


       


      End With
   End Sub
End Class
