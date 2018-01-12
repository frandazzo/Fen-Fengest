Imports System.Windows.Forms

Public Class GridInitializerRptLiberi
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
         colUtente.CellTemplate.Style.ForeColor = SystemColors.ActiveCaption
         .Columns.Add(colUtente)

       

         Dim colCodiceFiscale As DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
         colCodiceFiscale.Name = "CodiceFiscale"
         colCodiceFiscale.ReadOnly = True
         colCodiceFiscale.HeaderText = "Codice fiscale"
         colCodiceFiscale.DataPropertyName = "CodiceFiscale"
         .Columns.Add(colCodiceFiscale)

         Dim colAziendaImpiego As DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
         colAziendaImpiego.Name = "Azienda"
         colAziendaImpiego.ReadOnly = True
         colAziendaImpiego.HeaderText = "Azienda impiego"
         colAziendaImpiego.DataPropertyName = "Azienda"
         colAziendaImpiego.CellTemplate.Style.Font = New Font(.Font, FontStyle.Underline)
         colAziendaImpiego.CellTemplate.Style.ForeColor = SystemColors.ActiveCaption
         .Columns.Add(colAziendaImpiego)

         Dim colDataNascita As DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
         colDataNascita.Name = "DataNascita"
         colDataNascita.ReadOnly = True
         colDataNascita.HeaderText = "Data nascita"
         colDataNascita.DataPropertyName = "DataNascita"
         .Columns.Add(colDataNascita)

         Dim colLiberoAl As DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
         colLiberoAl.Name = "LiberoAl"
         colLiberoAl.ReadOnly = True
         colLiberoAl.HeaderText = "Libero al"
         colLiberoAl.DataPropertyName = "LiberoAl"
         .Columns.Add(colLiberoAl)


         .SelectionMode = DataGridViewSelectionMode.CellSelect
         .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing
         .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

      End With






   End Sub
End Class
