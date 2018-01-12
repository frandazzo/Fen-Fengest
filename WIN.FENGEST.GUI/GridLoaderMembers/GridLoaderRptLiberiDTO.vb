
Imports System.Windows.Forms
Imports WIN.APPLICATION.FINANCIAL_ARTIFACTS
Public Class GridLoaderRptLiberiDTO
   Inherits AbstractGridLoader
   Public Sub New(ByVal Grid As DataGridView)
      MyBase.New(Grid)
   End Sub
   Protected Overrides Sub LoadCustomListProperties(ByVal list As System.Collections.IList)
      With m_Grid


            
            .Columns("Id_Utente").Visible = False
            .Columns("Id_Azienda_Impiego").Visible = False
            .Columns("Id_Ente").Visible = False


            .Columns("Nome_Utente").Visible = True
            .Columns("Nome_Utente").HeaderText = "Utente"
            .Columns("Nome_Utente").CellTemplate.Style.Font = New Font(.Columns("Nome_Utente").DataGridView.Font, FontStyle.Underline)
            .Columns("Nome_Utente").CellTemplate.Style.ForeColor = Color.Black
            .Columns("Nome_Utente").DisplayIndex = 0

            .Columns("Codice_Fiscale").Visible = True
            .Columns("Codice_Fiscale").HeaderText = "Codice Fiscale"
            .Columns("Codice_Fiscale").DisplayIndex = 1

            .Columns("Nome_Nazione").Visible = True
            .Columns("Nome_Nazione").HeaderText = "Nazionalità"
            .Columns("Nome_Nazione").DisplayIndex = 2

            .Columns("Nome_Provincia").Visible = True
            .Columns("Nome_Provincia").HeaderText = "Provincia di residenza"
            .Columns("Nome_Provincia").DisplayIndex = 3


            .Columns("Nome_Comune").Visible = True
            .Columns("Nome_Comune").HeaderText = "Comune di residenza"
            .Columns("Nome_Comune").DisplayIndex = 4

            .Columns("Nome_Ente").Visible = True
            .Columns("Nome_Ente").DisplayIndex = 5


            .Columns("Libero_Al").Visible = True
            .Columns("Libero_Al").DisplayIndex = 6


            .Columns("Nome_Azienda").Visible = True
            .Columns("Nome_Azienda").HeaderText = "Azienda d'impiego"
            .Columns("Nome_Azienda").CellTemplate.Style.Font = New Font(.Columns("Nome_Azienda").DataGridView.Font, FontStyle.Underline)
            .Columns("Nome_Azienda").CellTemplate.Style.ForeColor = Color.Black
            .Columns("Nome_Azienda").DisplayIndex = 7

            .Columns("Livello").Visible = True
            .Columns("Livello").DisplayIndex = 8


            .Columns("IscrittoA").Visible = True
            .Columns("IscrittoA").HeaderText = "Iscritto a"
            .Columns("IscrittoA").DisplayIndex = 9

            .Columns("Ha_Delega_Precedente").Visible = True
            .Columns("Ha_Delega_Precedente").DisplayIndex = 10











            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


      End With
   End Sub
End Class

