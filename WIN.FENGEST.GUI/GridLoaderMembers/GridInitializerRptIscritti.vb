Imports System.Windows.Forms

Public Class GridInitializerRptIscritti
   Public Sub InitializeGrid(ByVal grid As DataGridView)


      With grid
            .Columns.Clear()

            .AutoGenerateColumns = False

            Dim colUtente As DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            colUtente.Name = "Utente"
            colUtente.ReadOnly = True
            colUtente.HeaderText = "Utente"
            colUtente.DataPropertyName = "Utente"
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

            Dim colCompetenza As DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            colCompetenza.Name = "Competenza"
            colCompetenza.ReadOnly = True
            colCompetenza.HeaderText = "Competenza"
            colCompetenza.DataPropertyName = "Competenza"
            .Columns.Add(colCompetenza)


            Dim colSettore As DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            colSettore.Name = "Settore"
            colSettore.ReadOnly = True
            colSettore.HeaderText = "Settore"
            colSettore.DataPropertyName = "Settore"
            .Columns.Add(colSettore)



            Dim colAziendaImpiego As DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            colAziendaImpiego.Name = "AziendaImpiego"
            colAziendaImpiego.ReadOnly = True
            colAziendaImpiego.HeaderText = "Azienda impiego"
            colAziendaImpiego.DataPropertyName = "AziendaImpiego"
            colAziendaImpiego.CellTemplate.Style.Font = New Font(.Font, FontStyle.Underline)
            colAziendaImpiego.CellTemplate.Style.ForeColor = Color.Black
            .Columns.Add(colAziendaImpiego)




            Dim colContrattoApplicato As DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            colContrattoApplicato.Name = "ContrattoApplicato"
            colContrattoApplicato.ReadOnly = True
            colContrattoApplicato.HeaderText = "Contratto applicato"
            colContrattoApplicato.DataPropertyName = "ContrattoApplicato"
            .Columns.Add(colContrattoApplicato)




            Dim colLivelloInquadramento As DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
            colLivelloInquadramento.Name = "LivelloInquadramento"
            colLivelloInquadramento.ReadOnly = True
            colLivelloInquadramento.HeaderText = "Livello inquadramento"
            colLivelloInquadramento.DataPropertyName = "LivelloInquadramento"
            .Columns.Add(colLivelloInquadramento)

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
