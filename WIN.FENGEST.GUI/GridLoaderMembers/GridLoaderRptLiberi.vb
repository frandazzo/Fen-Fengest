
Imports System.Windows.Forms
Imports WIN.APPLICATION.FINANCIAL_ARTIFACTS
Public Class GridLoaderRptLiberi
   Inherits AbstractGridLoader
   Public Sub New(ByVal Grid As DataGridView)
      MyBase.New(Grid)
   End Sub
   Protected Overrides Sub LoadCustomListProperties(ByVal list As System.Collections.IList)
      With m_Grid
         ''.AutoGenerateColumns = False
         '.Columns("Key").Visible = False
         .RowTemplate = Nothing


         .Columns("CompleteName").Visible = False
         .Columns("IdUtente").Visible = False

         '.Columns("IdUtente").HeaderText = "Id utente"
         '.Columns("IdUtente").CellTemplate.Style.Font = New Font(.Columns("IdUtente").DataGridView.Font, FontStyle.Underline)
         '.Columns("IdUtente").CellTemplate.Style.ForeColor = SystemColors.ActiveCaption

         .Columns("Utente").Visible = True
         .Columns("Utente").HeaderText = "Utente"
         .Columns("Utente").CellTemplate.Style.Font = New Font(.Columns("Utente").DataGridView.Font, FontStyle.Underline)
            .Columns("Utente").CellTemplate.Style.ForeColor = Color.Black
         .Columns("Utente").DisplayIndex = 0


         .Columns("CodiceFiscale").Visible = True
         .Columns("CodiceFiscale").HeaderText = "CodiceFiscale"
         .Columns("CodiceFiscale").DisplayIndex = 1

       

         .Columns("NomeAzienda").Visible = False
         .Columns("Azienda").Visible = True
         .Columns("Azienda").HeaderText = "Azienda d'impiego"
         .Columns("Azienda").CellTemplate.Style.Font = New Font(.Columns("Azienda").DataGridView.Font, FontStyle.Underline)
            .Columns("Azienda").CellTemplate.Style.ForeColor = Color.Black

         '.Columns("CreatoDa").Visible = False
         '.Columns("ModificatoDa").Visible = False
         '.Columns("DataCreazione").Visible = False
         '.Columns("DataModifica").Visible = False
         '.Columns("Descrizione").Visible = False

         '.Columns("Nome").Visible = False
         '.Columns("Cognome").Visible = False
         '.Columns("Residenza").Visible = False
         '.Columns("Nazionalita").Visible = False
         '.Columns("ProvinciaNascita").Visible = False
         '.Columns("Conto").Visible = False
         '.Columns("QuotaMensile").Visible = False
         '.Columns("ComuneNascita").Visible = False
         '.Columns("Selected").Visible = False
         '.Columns("DirectoryPreferenziale").Visible = False
         '.Columns("Comunicazione").Visible = False
         '.Columns("Sesso").Visible = False
         '.Columns("IdUtente").Visible = False



         '.Columns("Id").Visible = True
         '.Columns("Id").DisplayIndex = 0

         '.Columns("CompleteName").Visible = True
         '.Columns("CompleteName").HeaderText = "Cognome e nome"
         '.Columns("CompleteName").DisplayIndex = 1

         '.Columns("DataNascita").Visible = True
         '.Columns("DataNascita").ReadOnly = True

         '.Columns("CodiceFiscale").Visible = True
         '.Columns("CodiceFiscale").ReadOnly = True



         .SelectionMode = DataGridViewSelectionMode.FullRowSelect
         .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing
         .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


      End With
   End Sub
End Class

