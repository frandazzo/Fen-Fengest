Imports System.Windows.Forms

Public Class FrmItemRistornate
   Private m_Lista As IList

   Public Sub SetListaPOsizioni(ByVal Lista As IList)
      m_Lista = Lista
   End Sub


   Private Sub LoadGrid(ByVal Lista As IList)
      Try
         'GridReferenti.DataSource = Lista
         Dim CongruityColumn As New DataGridViewImageColumn

         With GridPosizioni

            .DataSource = Lista

            If Lista.Count > 0 Then
               .AutoGenerateColumns = False


               .Columns("Key").Visible = False
               .Columns("Versione").Visible = False
               .Columns("CreatoDa").Visible = False
               .Columns("ModificatoDa").Visible = False
               .Columns("DataCreazione").Visible = False
               .Columns("DataModifica").Visible = False
               .Columns("Descrizione").Visible = False
               .Columns("Id").Visible = False

               .Columns("DataRegistrazione").Visible = False
               .Columns("DataDocumento").Visible = False
               .Columns("GetQuotaMedia").Visible = False
               .Columns("TipoDocumento").Visible = False
               .Columns("Tredicesima").Visible = False
               .Columns("Quattordicesima").Visible = False
               .Columns("DocumentoPadre").Visible = False
               .Columns("GetCongruitaToString").Visible = False
               .Columns("Settore").Visible = False

               .Columns("Conto").Visible = True
               .Columns("Conto").DisplayIndex = 0
               .Columns("Conto").Visible = True

               .Columns("Importo").Visible = True
               .Columns("Importo").HeaderText = "Importo posizione"
               .Columns("Importo").ReadOnly = True
               .Columns("Importo").DisplayIndex = 1

               .Columns("Note").Visible = True
               .Columns("Note").ReadOnly = True
               .Columns("Note").DisplayIndex = 2



               .Columns("Referente").Visible = True
               .Columns("Referente").ReadOnly = True
               .Columns("Referente").DisplayIndex = 3



               If .Columns.Contains("PercentualeRistornoDeleghe") Then
                  .Columns("PercentualeRistornoDeleghe").Visible = True
                  .Columns("PercentualeRistornoDeleghe").HeaderText = "Percentuale ristorno deleghe"
                  .Columns("PercentualeRistornoDeleghe").ReadOnly = True
                  .Columns("PercentualeRistornoDeleghe").DisplayIndex = 4
               End If

               .Columns("ImportoRistorno").Visible = True
               .Columns("ImportoRistorno").HeaderText = "Importo ristorno"
               .Columns("ImportoRistorno").ReadOnly = True
               .Columns("ImportoRistorno").DisplayIndex = 5


               .Columns("PagamentoReferente").Visible = True
               .Columns("PagamentoReferente").HeaderText = "Pagamento referente"
               .Columns("PagamentoReferente").ReadOnly = True
               .Columns("PagamentoReferente").DisplayIndex = 6

               .Columns("Utente").Visible = True
               .Columns("Utente").DisplayIndex = 7

               .Columns("SoggettoEsecutore").Visible = True
               .Columns("SoggettoEsecutore").HeaderText = "Soggetto esecutore"
               .Columns("SoggettoEsecutore").DisplayIndex = 8


               If .Columns.Contains("TredicesimaInclusa") Then
                  .Columns("TredicesimaInclusa").Visible = True
                  .Columns("TredicesimaInclusa").HeaderText = "Incasso tredicesima"
                  .Columns("TredicesimaInclusa").ReadOnly = True
                  .Columns("TredicesimaInclusa").DisplayIndex = 10
               End If


               If .Columns.Contains("QuattordicesimaInclusa") Then
                  .Columns("QuattordicesimaInclusa").Visible = True
                  .Columns("QuattordicesimaInclusa").HeaderText = "Incasso quattordicesima"
                  .Columns("QuattordicesimaInclusa").ReadOnly = True
                  .Columns("QuattordicesimaInclusa").DisplayIndex = 11
               End If

               If .Columns.Contains("QuotaMedia") Then
                  .Columns("QuotaMedia").Visible = True
                  .Columns("QuotaMedia").HeaderText = "Quota media mensile"
                  .Columns("QuotaMedia").ReadOnly = True
                  .Columns("QuotaMedia").DisplayIndex = 12
               End If

               If .Columns.Contains("QuotaMensileUtente") Then
                  .Columns("QuotaMensileUtente").Visible = True
                  .Columns("QuotaMensileUtente").HeaderText = "Quota mensile attesa"
                  .Columns("QuotaMensileUtente").ReadOnly = True
                  .Columns("QuotaMensileUtente").DisplayIndex = 13
               End If

               If .Columns.Contains("GetCongruita") Then
                  .Columns("GetCongruita").Visible = False
               End If
               If .Columns.Contains("Competenza") Then
                  .Columns("Competenza").Visible = False
               End If
               If .Columns.Contains("GetImporto") Then
                  .Columns("GetImporto").Visible = False
               End If
               If .Columns.Contains("PercentualeScarto") Then
                  .Columns("PercentualeScarto").Visible = False
               End If
               If .Columns.Contains("TipoConfrontoCompetenze") Then
                  .Columns("TipoConfrontoCompetenze").Visible = False
               End If

               If .Columns.Contains("GetCompetenza") Then
                  .Columns("GetCompetenza").Visible = True
                  .Columns("GetCompetenza").HeaderText = "Competenza"
                  .Columns("GetCompetenza").ReadOnly = True
                  .Columns("GetCompetenza").DisplayIndex = 17
               End If



               If .Columns.Contains("GetCongruita") Then
                  .Columns.Add(CongruityColumn)
                  CongruityColumn.Name = "ColumnCongruita"
                  CongruityColumn.HeaderText = ""
                  CongruityColumn.Visible = True
                  CongruityColumn.DisplayIndex = 14
                  .Columns("GetCongruita").Visible = True
                  .Columns("GetCongruita").DisplayIndex = 15
                  .Columns("GetCongruita").HeaderText = "Valore congruità"
               End If
            End If

            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
            .Visible = True
         End With
      Catch ex As Exception
         Throw New Exception("Impossibile caricare la griglia delle posizioni" & vbCrLf & ex.Message)
      End Try
   End Sub

   Private Sub GridPosizioni_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles GridPosizioni.CellFormatting
      Try
         If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("Utente") Then
            If Not e.Value Is Nothing Then
               e.Value = e.Value.CompleteName
            End If
         End If
         If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("SoggettoEsecutore") Then
            If Not e.Value Is Nothing Then
               e.Value = e.Value.Descrizione
            End If
         End If
         If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("ContrattoApplicato") Then
            If Not e.Value Is Nothing Then
               e.Value = e.Value.Descrizione
            End If
         End If

         If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("AziendaImpiego") Then
            If Not e.Value Is Nothing Then
               e.Value = e.Value.Descrizione
            End If
         End If
         If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("PagamentoReferente") Then
            If Not e.Value Is Nothing Then
               If e.Value.Id = -1 Then 'documento nullo 
                  e.Value = ""
               Else
                  e.Value = e.Value.Id
               End If
            End If
         End If

         If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("Referente") Then
            If Not e.Value Is Nothing Then
               If e.Value.Cognome = "" Then 'referente nullo 
                  e.Value = ""
               Else
                  e.Value = e.Value.CompleteName
               End If
            End If
         End If

         If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("Conto") Then
            If Not e.Value Is Nothing Then
               e.Value = e.Value.Descrizione
            End If
         End If



         If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("Importo") Then
            If Not e.Value Is Nothing Then
               e.Value = e.Value.importo & " " & e.Value.GetTipoValutaToString(e.Value.GetValuta)
            End If
         End If

         If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("ImportoRistorno") Then
            If Not e.Value Is Nothing Then
               e.Value = e.Value.importo & " " & e.Value.GetTipoValutaToString(e.Value.GetValuta)
            End If
         End If


         If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("GetCompetenza") Then
            If Not e.Value Is Nothing Then
               e.Value = e.Value.ToString
            End If
         End If

         If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("QuotaMensileUtente") Then
            If Not e.Value Is Nothing Then
               e.Value = e.Value.importo & " " & e.Value.GetTipoValutaToString(e.Value.GetValuta)
            End If
         End If

         If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("QuotaMedia") Then
            If Not e.Value Is Nothing Then
               e.Value = e.Value.importo & " " & e.Value.GetTipoValutaToString(e.Value.GetValuta)
            End If
         End If
         If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("GetCongruita") Then
            If Not e.Value Is Nothing Then
               GridPosizioni.Rows(e.RowIndex).Cells("ColumnCongruita").Value = GetImage(e.Value)
            End If
         End If
      Catch ex As Exception
         Throw New Exception("Errore nella formattazione delle celle della griglia." & vbCrLf & ex.Message)
      End Try
   End Sub

   Private Function GetImage(ByVal ImageType As String) As System.Drawing.Image
      If ImageType = "0" Then
         Return My.Resources.OK
      Else
         Return My.Resources.WarningHS
      End If
   End Function

   Private Sub FrmItemRistornate_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
      Try
         LoadGrid(m_Lista)
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub
End Class