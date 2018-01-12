
Imports System.Windows.Forms
Imports System.Drawing.Drawing2D
Public Class FrmVisualizzatoreDeleghe
   Private controller As New UTENTI.ControllerUtenti


   Public Sub New(ByVal IdUtente As Int32)
      InitializeComponent()


      LoadData(IdUtente)
      GetProperties()
   End Sub




   Private Sub LoadData(ByVal IdUtente As Int32)
      'qui carico ordino il caricamento dei dati e carico le possibili scelte
      controller.LoadById(IdUtente)
   End Sub
   Protected Sub GetProperties()


      lblDescrizioneUtente.Text = controller.CompleteName
      Dim listaDeleghe As IList = controller.ElencoDeleghe
      'If listaDeleghe.Count > 0 Then
      LoadGrid(listaDeleghe)
      'Else
      '   PerformDialog()
      'End If
   End Sub
   


   Private Sub GridDeleghe_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles GridDeleghe.CellFormatting
      Try
         If GridDeleghe.Columns(e.ColumnIndex).Name.Equals("StatoDelega") Then
            If Not e.Value Is Nothing Then
               'GridDeleghe.Rows(e.RowIndex).Cells("StatoDelega").Value = e.Value.
               e.Value = e.Value.StatusName
            End If
         End If
         If GridDeleghe.Columns(e.ColumnIndex).Name.Equals("Settore") Then
            If Not e.Value Is Nothing Then
               'GridDeleghe.Rows(e.RowIndex).Cells("StatoDelega").Value = e.Value.
               e.Value = e.Value.Descrizione
            End If
         End If
      Catch ex As Exception
         Throw New Exception(ex.Message)
      End Try
   End Sub
   
   Private Sub LoadGrid(ByVal Lista As IList)
      Try
         'GridReferenti.DataSource = Lista
         With GridDeleghe

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

               .Columns("DataImportazione").Visible = False
               .Columns("Selected").Visible = False
               '.Columns("Path_Foto").Visible = False
               .Columns("Cellulare1Utente").Visible = False
               .Columns("Cellulare2Utente").Visible = False

               .Columns("Utente").Visible = False
               '.Columns("ListaEntiInoltro").Visible = False
               .Columns("IdDelega").Visible = False

               .Columns("Referente").Visible = False
               .Columns("DataInoltro").Visible = False
               .Columns("DataAccettazioneDelega").Visible = False
               .Columns("DataDecorrenzaDelega").Visible = False
               .Columns("DataAnnullamentoDelega").Visible = False
               .Columns("DataRevocaDelega").Visible = False
               .Columns("PagamentoAttivazione").Visible = False

               '.Columns("EnteAccettante1").Visible = False
               '.Columns("EnteAccettante2").Visible = False
               .Columns("EnteInoltro").Visible = True
               '.Columns("EnteInoltro2").Visible = False
               .Columns("DelegaDiAnnullamento").Visible = False
               .Columns("DataRegistrazione").Visible = False
               .Columns("GetDataRegistrazione").Visible = False
               .Columns("Note").Visible = False
               '.Columns("AccettataDaEntrambiEntiBilaterali").Visible = False
               '.Columns("InoltrataEntrambiEntiBilaterali").Visible = False
               .Columns("TipoDocumento").Visible = False
               .Columns("CausaleFineCiclo").Visible = False
               .Columns("StatoPrecedente").Visible = False
               .Columns("Id").Visible = False
               .Columns("IsForSettoreEdile").Visible = False
               .Columns("SedeOperativa").Visible = False
               .Columns("Reparto").Visible = False
               .Columns("Responsabile").Visible = False

               .Columns("DataDocumento").Visible = True
               .Columns("DataDocumento").HeaderText = "Data documento"
               .Columns("DataDocumento").ReadOnly = True
               .Columns("DataDocumento").DisplayIndex = 0

               .Columns("StatoDelega").Visible = True
               .Columns("StatoDelega").HeaderText = "Stato delega"
               .Columns("StatoDelega").ReadOnly = True
               .Columns("StatoDelega").DisplayIndex = 1
               .Columns("NomeStato").Visible = False

               .Columns("Settore").Visible = False
               '.Columns("Settore").HeaderText = "Settore"
               '.Columns("Settore").ReadOnly = True
               '.Columns("Settore").DisplayIndex = 2


               .SelectionMode = DataGridViewSelectionMode.FullRowSelect
               .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing
               .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            End If
         End With


      Catch ex As Exception
         Throw New Exception("Impossibile caricare la griglia delle deleghe per l'utente" & vbCrLf & ex.Message)
      End Try
   End Sub

















   





End Class


