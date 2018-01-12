Imports System.Windows.Forms

Public Class GridLoaderListaLavoro
    Inherits AbstractGridLoader

    Private m_EnableLink As Boolean = True



    Public Sub New(ByVal Grid As DataGridView)
        MyBase.New(Grid)
    End Sub


    Public Sub New(ByVal Grid As DataGridView, ByVal EnableLink As Boolean)
        MyBase.New(Grid)
        m_EnableLink = EnableLink
    End Sub
    Protected Overrides Sub LoadCustomListProperties(ByVal list As System.Collections.IList)
        With m_Grid
            'If list.Count > 0 Then
            '    .DataSource = list




            If Not .Columns.Contains("Indirizzo") Then
                Dim a As New DataGridViewTextBoxColumn
                a.Name = "Indirizzo"
                a.Visible = True
                a.ReadOnly = True
                a.HeaderText = "Indirizzo"
                .Columns.Add(a)
            End If


            .AutoGenerateColumns = False
            .Columns("Key").Visible = False

            .Columns("Versione").Visible = False
            .Columns("CreatoDa").Visible = False
            .Columns("ModificatoDa").Visible = False
            .Columns("DataCreazione").Visible = False
            .Columns("DataModifica").Visible = False
            .Columns("Descrizione").Visible = False
            .Columns("Codifica").Visible = False

            .Columns("Genere").Visible = False
            .Columns("Residenza").Visible = False
            .Columns("Nome").Visible = False
            .Columns("Cognome").Visible = False
            .Columns("TagUtente").Visible = False

            .Columns("Nazionalita").Visible = False
            .Columns("ProvinciaNascita").Visible = False
            .Columns("Conto").Visible = False
            .Columns("QuotaMensile").Visible = False
            .Columns("ComuneNascita").Visible = False
            .Columns("Selected").Visible = False
            .Columns("DirectoryPreferenziale").Visible = False
            '.Columns("Comunicazione").Visible = False
            .Columns("Sesso").Visible = False
            .Columns("IdUtente").Visible = False
            .Columns("Fondo").Visible = False
            .Columns("SituazioneFamiliare").Visible = False
            .Columns("Path_Foto").Visible = False
            .Columns("ArchivioDocumenti").Visible = False
            .Columns("Segreteria").Visible = False

            .Columns("Id").Visible = False
            ' .Columns("Id").DisplayIndex = 0


            .Columns("CompleteName").Visible = True
            .Columns("CompleteName").HeaderText = "Utente"
            If m_EnableLink Then
                .Columns("CompleteName").CellTemplate.Style.Font = New Font(.Columns("CompleteName").DataGridView.Font, FontStyle.Underline)
                .Columns("CompleteName").CellTemplate.Style.ForeColor = Color.Black
            End If

            .Columns("CompleteName").DisplayIndex = 1

            .Columns("DataNascita").Visible = True
            .Columns("DataNascita").ReadOnly = True
            .Columns("DataNascita").DisplayIndex = 2


            .Columns("CodiceFiscale").Visible = True
            .Columns("CodiceFiscale").ReadOnly = True
            .Columns("CodiceFiscale").DisplayIndex = 3


            .Columns("Nazionalita").Visible = True
            .Columns("Nazionalita").ReadOnly = True
            .Columns("Nazionalita").DisplayIndex = 4




            .Columns("Residenza").Visible = True
            .Columns("Residenza").HeaderText = "Comune residenza"
            .Columns("Residenza").ReadOnly = True
            .Columns("Residenza").DisplayIndex = 5

            .Columns("Indirizzo").DisplayIndex = 6



            .Columns("Comunicazione").Visible = True
            .Columns("Comunicazione").HeaderText = "Cellulari"
            .Columns("Comunicazione").ReadOnly = True
            .Columns("Comunicazione").DisplayIndex = 7


            .Columns("Note").Visible = True
            .Columns("Note").ReadOnly = True
            .Columns("Note").DisplayIndex = 8


            m_SelectionMode = DataGridViewSelectionMode.FullRowSelect
            m_RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
            m_AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells

            'End If
        End With
    End Sub
End Class
