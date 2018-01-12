Imports System.Windows.Forms

Public Class GridInitializerRptLiberiDTO
   Public Sub InitializeGrid(ByVal grid As DataGridView)





      With grid

            .Columns.Clear()

            .AutoGenerateColumns = False


            Dim colUtente As DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            colUtente.Name = "Utente"
            colUtente.ReadOnly = True
            colUtente.HeaderText = "Utente"
            colUtente.DataPropertyName = "Nome_Utente"
            colUtente.CellTemplate.Style.Font = New Font(.Font, FontStyle.Underline)
            colUtente.CellTemplate.Style.ForeColor = Color.Black
            .Columns.Add(colUtente)



            Dim colCodiceFiscale As DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            colCodiceFiscale.Name = "CodiceFiscale"
            colCodiceFiscale.ReadOnly = True
            colCodiceFiscale.HeaderText = "Codice fiscale"
            colCodiceFiscale.DataPropertyName = "Codice_Fiscale"
            .Columns.Add(colCodiceFiscale)

            Dim colNazione As DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            colNazione.Name = "Nazione"
            colNazione.ReadOnly = True
            colNazione.HeaderText = "Nazionalità"
            colNazione.DataPropertyName = "Nome_Nazione"
            .Columns.Add(colNazione)


            Dim colProvincia As DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            colProvincia.Name = "Provincia"
            colProvincia.ReadOnly = True
            colProvincia.HeaderText = "Provincia residenza"
            colProvincia.DataPropertyName = "Nome_Provincia"
            .Columns.Add(colProvincia)


            Dim colComune As DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            colComune.Name = "Comune"
            colComune.ReadOnly = True
            colComune.HeaderText = "Comune residenza"
            colComune.DataPropertyName = "Nome_Comune"
            .Columns.Add(colComune)

            Dim colIscrittoA As DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            colIscrittoA.Name = "IscrittoA"
            colIscrittoA.ReadOnly = True
            colIscrittoA.HeaderText = "Iscritto"
            colIscrittoA.DataPropertyName = "IscrittoA"
            .Columns.Add(colIscrittoA)

            'Dim colAziendaImpiego As DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            'colAziendaImpiego.Name = "Azienda"
            'colAziendaImpiego.ReadOnly = True
            'colAziendaImpiego.HeaderText = "Azienda impiego"
            'colAziendaImpiego.DataPropertyName = "Nome_Azienda"
            'colAziendaImpiego.CellTemplate.Style.Font = New Font(.Font, FontStyle.Underline)
            'colAziendaImpiego.CellTemplate.Style.ForeColor = Color.Black
            '.Columns.Add(colAziendaImpiego)

            Dim colDataliv As DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            colDataliv.Name = "Livello"
            colDataliv.ReadOnly = True
            colDataliv.HeaderText = "Livello"
            colDataliv.DataPropertyName = "Livello"
            .Columns.Add(colDataliv)

            Dim colLiberoAl As DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            colLiberoAl.Name = "LiberoAl"
            colLiberoAl.ReadOnly = True
            colLiberoAl.HeaderText = "Libero al"
            colLiberoAl.DataPropertyName = "Libero_Al"
            .Columns.Add(colLiberoAl)

            Dim colcell1 As DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            colcell1.Name = "Cell1"
            colcell1.ReadOnly = True
            colcell1.HeaderText = "Cell1"
            colcell1.DataPropertyName = "Cell1"
            .Columns.Add(colcell1)

            Dim colcell2 As DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            colcell2.Name = "Cell2"
            colcell2.ReadOnly = True
            colcell2.HeaderText = "Cell2"
            colcell2.DataPropertyName = "Cell2"
            .Columns.Add(colcell2)


            .SelectionMode = DataGridViewSelectionMode.CellSelect
            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

      End With


   End Sub

End Class
