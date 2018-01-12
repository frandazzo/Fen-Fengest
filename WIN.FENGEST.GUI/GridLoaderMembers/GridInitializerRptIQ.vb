Imports System.Windows.Forms

Public Class GridInitializerRptIQ

   Public Sub InitializeGrid(ByVal grid As DataGridView)

      With grid

         .Columns.Clear()

         .AutoGenerateColumns = False

       



         'Dim colAb As DataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
         'colAb.Name = "Selected"
         'colAb.ReadOnly = False
         'colAb.HeaderText = "Seleziona"
         'colAb.DataPropertyName = "Selected"
         'colAb.TrueValue = True
         'colAb.FalseValue = False
         '.Columns.Add(colAb)

         '.Columns("DocumentoPadre").Visible = True
         '.Columns("DocumentoPadre").HeaderText = "Id documento"
         '.Columns("DocumentoPadre").CellTemplate.Style.Font = New Font(.Columns("DocumentoPadre").DataGridView.Font, FontStyle.Underline)
         '.Columns("DocumentoPadre").CellTemplate.Style.ForeColor = SystemColors.ActiveCaption
         '.Columns("DocumentoPadre").DisplayIndex = 0

         Dim colDocumentoPadre As DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
         colDocumentoPadre.Name = "DocumentoPadre"
         colDocumentoPadre.ReadOnly = True
         colDocumentoPadre.HeaderText = "Id documento"
         colDocumentoPadre.DataPropertyName = "DocumentoPadre"
         colDocumentoPadre.CellTemplate.Style.Font = New Font(.Font, FontStyle.Underline)
            colDocumentoPadre.CellTemplate.Style.ForeColor = Color.Black
         .Columns.Add(colDocumentoPadre)

         '.Columns("TipoDocumento").Visible = True
         '.Columns("TipoDocumento").HeaderText = "Tipo documento"
         '.Columns("TipoDocumento").DisplayIndex = 1

         Dim colTipoDocumento As DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
         colTipoDocumento.Name = "TipoDocumento"
         colTipoDocumento.ReadOnly = True
         colTipoDocumento.HeaderText = "Tipo documento"
         colTipoDocumento.DataPropertyName = "TipoDocumento"
         .Columns.Add(colTipoDocumento)

         '.Columns("DataRegistrazione").Visible = True
         '.Columns("DataRegistrazione").HeaderText = "Data registrazione"
         '.Columns("DataRegistrazione").DisplayIndex = 2

         Dim colDataRegistrazione As DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
         colDataRegistrazione.Name = "DataRegistrazione"
         colDataRegistrazione.ReadOnly = True
         colDataRegistrazione.HeaderText = "Data registrazione"
         colDataRegistrazione.DataPropertyName = "DataRegistrazione"
         .Columns.Add(colDataRegistrazione)

         '.Columns("DataDocumento").Visible = True
         '.Columns("DataDocumento").HeaderText = "Data documento"
         '.Columns("DataDocumento").DisplayIndex = 3

         Dim colDataDocumento As DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
         colDataDocumento.Name = "DataDocumento"
         colDataDocumento.ReadOnly = True
         colDataDocumento.HeaderText = "Data documento"
         colDataDocumento.DataPropertyName = "DataDocumento"
         .Columns.Add(colDataDocumento)

         '.Columns("Utente").Visible = True
         '.Columns("Utente").CellTemplate.Style.Font = New Font(.Columns("Utente").DataGridView.Font, FontStyle.Underline)
         '.Columns("Utente").CellTemplate.Style.ForeColor = SystemColors.ActiveCaption
         '.Columns("Utente").ReadOnly = True
         '.Columns("Utente").DisplayIndex = 4


         Dim colUtente As DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
         colUtente.Name = "Utente"
         colUtente.ReadOnly = True
         colUtente.HeaderText = "Utente"
         colUtente.DataPropertyName = "Utente"
         colUtente.CellTemplate.Style.Font = New Font(.Font, FontStyle.Underline)
            colUtente.CellTemplate.Style.ForeColor = Color.Black
         .Columns.Add(colUtente)

         '.Columns("Importo").Visible = True
         '.Columns("Importo").HeaderText = "Importo posizione"
         '.Columns("Importo").ReadOnly = True
         '.Columns("Importo").DisplayIndex = 5

         Dim colImporto As DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
         colImporto.Name = "Importo"
         colImporto.ReadOnly = True
         colImporto.HeaderText = "Importo"
         colImporto.DataPropertyName = "Importo"
         .Columns.Add(colImporto)

         '.Columns("Competenza").Visible = True
         '.Columns("Competenza").ReadOnly = True
         '.Columns("Competenza").DisplayIndex = 6

         Dim colCompetenza As DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
         colCompetenza.Name = "Competenza"
         colCompetenza.ReadOnly = True
         colCompetenza.HeaderText = "Competenza"
         colCompetenza.DataPropertyName = "Competenza"
         .Columns.Add(colCompetenza)

         '.Columns("ImportoRistorno").Visible = True
         '.Columns("ImportoRistorno").HeaderText = "Importo ristorno"
         '.Columns("ImportoRistorno").ReadOnly = True
         '.Columns("ImportoRistorno").DisplayIndex = 7

         Dim colImportoRistorno As DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
         colImportoRistorno.Name = "ImportoRistorno"
         colImportoRistorno.ReadOnly = True
         colImportoRistorno.HeaderText = "Importo ristorno"
         colImportoRistorno.DataPropertyName = "ImportoRistorno"
         .Columns.Add(colImportoRistorno)

         '.Columns("PagamentoReferente").Visible = True
         '.Columns("PagamentoReferente").HeaderText = "Id pagamento coll. comunale"
         '.Columns("PagamentoReferente").CellTemplate.Style.Font = New Font(.Columns("PagamentoReferente").DataGridView.Font, FontStyle.Underline)
         '.Columns("PagamentoReferente").CellTemplate.Style.ForeColor = SystemColors.ActiveCaption
         '.Columns("PagamentoReferente").DisplayIndex = 9


         Dim colPagamentoReferente As DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
         colPagamentoReferente.Name = "PagamentoReferente"
         colPagamentoReferente.ReadOnly = True
         colPagamentoReferente.HeaderText = "Pagamento coll. comunale"
         colPagamentoReferente.DataPropertyName = "PagamentoReferente"
         colPagamentoReferente.CellTemplate.Style.Font = New Font(.Font, FontStyle.Underline)
            colPagamentoReferente.CellTemplate.Style.ForeColor = Color.Black
         .Columns.Add(colPagamentoReferente)

         '.Columns("SoggettoEsecutore").Visible = True
         '.Columns("SoggettoEsecutore").HeaderText = "Soggetto esecutore"
         '.Columns("SoggettoEsecutore").CellTemplate.Style.Font = New Font(.Columns("SoggettoEsecutore").DataGridView.Font, FontStyle.Underline)
         '.Columns("SoggettoEsecutore").CellTemplate.Style.ForeColor = SystemColors.ActiveCaption
         '.Columns("SoggettoEsecutore").ReadOnly = True
         '.Columns("SoggettoEsecutore").DisplayIndex = 10

         Dim colSoggettoEsecutore As DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
         colSoggettoEsecutore.Name = "SoggettoEsecutore"
         colSoggettoEsecutore.ReadOnly = True
         colSoggettoEsecutore.HeaderText = "Soggetto esecutore"
         colSoggettoEsecutore.DataPropertyName = "SoggettoEsecutore"
         colSoggettoEsecutore.CellTemplate.Style.Font = New Font(.Font, FontStyle.Underline)
            colSoggettoEsecutore.CellTemplate.Style.ForeColor = Color.Black
         .Columns.Add(colSoggettoEsecutore)


         '.Columns("Referente").Visible = True
         '.Columns("Referente").ReadOnly = True
         '.Columns("Referente").HeaderText = "Collaboratore comunale"
         '.Columns("Referente").CellTemplate.Style.Font = New Font(.Columns("Referente").DataGridView.Font, FontStyle.Underline)
         '.Columns("Referente").CellTemplate.Style.ForeColor = SystemColors.ActiveCaption
         '.Columns("Referente").DisplayIndex = 11

         Dim colReferente As DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
         colReferente.Name = "Referente"
         colReferente.ReadOnly = True
         colReferente.HeaderText = "Collaboratore comunale"
         colReferente.DataPropertyName = "Referente"
         colReferente.CellTemplate.Style.Font = New Font(.Font, FontStyle.Underline)
            colReferente.CellTemplate.Style.ForeColor = Color.Black
         .Columns.Add(colReferente)

         '.Columns("Settore").Visible = True
         '.Columns("Settore").ReadOnly = True
         '.Columns("Settore").DisplayIndex = 12

         Dim colSettore As DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
         colSettore.Name = "Settore"
         colSettore.ReadOnly = True
         colSettore.HeaderText = "Settore"
         colSettore.DataPropertyName = "Settore"
         .Columns.Add(colSettore)

         '.Columns("AziendaImpiego").Visible = True
         '.Columns("AziendaImpiego").ReadOnly = True
         '.Columns("AziendaImpiego").CellTemplate.Style.Font = New Font(.Columns("AziendaImpiego").DataGridView.Font, FontStyle.Underline)
         '.Columns("AziendaImpiego").CellTemplate.Style.ForeColor = SystemColors.ActiveCaption
         '.Columns("AziendaImpiego").DisplayIndex = 13

         Dim colAziendaImpiego As DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
         colAziendaImpiego.Name = "AziendaImpiego"
         colAziendaImpiego.ReadOnly = True
         colAziendaImpiego.HeaderText = "Azienda impiego"
         colAziendaImpiego.DataPropertyName = "AziendaImpiego"
         colAziendaImpiego.CellTemplate.Style.Font = New Font(.Font, FontStyle.Underline)
            colAziendaImpiego.CellTemplate.Style.ForeColor = Color.Black
         .Columns.Add(colAziendaImpiego)


         '.Columns("SedeOperativa").Visible = True
         '.Columns("SedeOperativa").ReadOnly = True
         '.Columns("SedeOperativa").DisplayIndex = 14

         Dim colSedeOperativae As DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
         colSedeOperativae.Name = "SedeOperativa"
         colSedeOperativae.ReadOnly = True
         colSedeOperativae.HeaderText = "Sede operativa"
         colSedeOperativae.DataPropertyName = "SedeOperativa"
         .Columns.Add(colSedeOperativae)


         '.Columns("ContrattoApplicato").Visible = True
         '.Columns("ContrattoApplicato").ReadOnly = True
         '.Columns("ContrattoApplicato").DisplayIndex = 15

         Dim colContrattoApplicato As DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
         colContrattoApplicato.Name = "ContrattoApplicato"
         colContrattoApplicato.ReadOnly = True
         colContrattoApplicato.HeaderText = "Contratto applicato"
         colContrattoApplicato.DataPropertyName = "ContrattoApplicato"
         .Columns.Add(colContrattoApplicato)


         '.Columns("LivelloInquadramento").Visible = True
         '.Columns("LivelloInquadramento").ReadOnly = True
         '.Columns("LivelloInquadramento").DisplayIndex = 16


         Dim colLivelloInquadramento As DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
         colLivelloInquadramento.Name = "LivelloInquadramento"
         colLivelloInquadramento.ReadOnly = True
         colLivelloInquadramento.HeaderText = "Livello inquadramento"
         colLivelloInquadramento.DataPropertyName = "LivelloInquadramento"
         .Columns.Add(colLivelloInquadramento)

         '.Columns("OreLavorate").Visible = True
         '.Columns("OreLavorate").ReadOnly = True
         '.Columns("OreLavorate").DisplayIndex = 17

         Dim colOreLavorate As DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
         colOreLavorate.Name = "OreLavorate"
         colOreLavorate.ReadOnly = True
         colOreLavorate.HeaderText = "Ore lavorate"
         colOreLavorate.DataPropertyName = "OreLavorate"
         .Columns.Add(colOreLavorate)



         '.Columns("OreMalattia").Visible = True
         '.Columns("OreMalattia").ReadOnly = True
         '.Columns("OreMalattia").DisplayIndex = 18

         Dim colOreMalattia As DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
         colOreMalattia.Name = "OreMalattia"
         colOreMalattia.ReadOnly = True
         colOreMalattia.HeaderText = "Ore malattia"
         colOreMalattia.DataPropertyName = "OreMalattia"
         .Columns.Add(colOreMalattia)




         '.Columns("Tredicesima").Visible = True
         '.Columns("Tredicesima").ReadOnly = True
         '.Columns("Tredicesima").DisplayIndex = 19

         '.Columns("Quattordicesima").Visible = True
         '.Columns("Quattordicesima").ReadOnly = True
         '.Columns("Quattordicesima").DisplayIndex = 20


         '.Columns("IdVertenza").Visible = True
         '.Columns("IdVertenza").CellTemplate.Style.Font = New Font(.Columns("IdVertenza").DataGridView.Font, FontStyle.Underline)
         '.Columns("IdVertenza").CellTemplate.Style.ForeColor = SystemColors.ActiveCaption
         '.Columns("IdVertenza").DisplayIndex = 21

         Dim colIdVertenza As DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
         colIdVertenza.Name = "IdVertenza"
         colIdVertenza.ReadOnly = True
         colIdVertenza.HeaderText = "Vertenza"
         colIdVertenza.DataPropertyName = "IdVertenza"
         colIdVertenza.CellTemplate.Style.Font = New Font(.Font, FontStyle.Underline)
            colIdVertenza.CellTemplate.Style.ForeColor = Color.Black
         .Columns.Add(colIdVertenza)

         '.Columns("IdPrestazione").Visible = True
         '.Columns("IdPrestazione").CellTemplate.Style.Font = New Font(.Columns("IdPrestazione").DataGridView.Font, FontStyle.Underline)
         '.Columns("IdPrestazione").CellTemplate.Style.ForeColor = SystemColors.ActiveCaption
         '.Columns("IdPrestazione").DisplayIndex = 22

         Dim colIdPrestazione As DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
         colIdPrestazione.Name = "IdPrestazione"
         colIdPrestazione.ReadOnly = True
         colIdPrestazione.HeaderText = "Prestazione"
         colIdPrestazione.DataPropertyName = "IdPrestazione"
         colIdPrestazione.CellTemplate.Style.Font = New Font(.Font, FontStyle.Underline)
            colIdPrestazione.CellTemplate.Style.ForeColor = Color.Black
         .Columns.Add(colIdPrestazione)




         '.Columns("TipoPrestazione").Visible = True
         '.Columns("TipoPrestazione").ReadOnly = True
         '.Columns("TipoPrestazione").DisplayIndex = 23

         Dim colTipoPrestazione As DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
         colTipoPrestazione.Name = "TipoPrestazione"
         colTipoPrestazione.ReadOnly = True
         colTipoPrestazione.HeaderText = "Tipo prestazione"
         colTipoPrestazione.DataPropertyName = "TipoPrestazione"
         .Columns.Add(colTipoPrestazione)







         .SelectionMode = DataGridViewSelectionMode.CellSelect
         .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing
         .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

      End With




    

   End Sub
End Class
