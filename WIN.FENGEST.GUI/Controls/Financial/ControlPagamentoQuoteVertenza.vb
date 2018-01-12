Imports System.Windows.Forms
Imports System
Imports Microsoft.VisualBasic.ApplicationServices
Imports WIN.SECURITY

Public Class ControlPagamentoQuoteVertenza
   Private controller As New FINANCIAL_ARTIFACTS.ControllerIncassiQuoteVertenza
   Private m_IdUtente As String = ""
   Private m_IdReferente As String = ""

   Private Sub LoadGrid()
      Dim listaPosizioni As IList = controller.ListaPosizioniUtenti
      If GridPosizioni.DataSource Is Nothing Then
         Dim gridLoader As New GridLoaderNewIQV(Me.GridPosizioni)
         gridLoader.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
         gridLoader.LoadGrid(listaPosizioni)
      Else
         Me.GridPosizioni.DataSource = New ArrayList
         Me.GridPosizioni.DataSource = controller.ListaPosizioniUtenti
         Me.GridPosizioni.Refresh()
      End If

   End Sub

   Public Sub New()
      InitializeComponent()
      Try
         DoLoad()
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub


#Region "Metodo per visualizzare le informazioni di stato  "

    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "" & MyBase.State.StateName & " incasso quota vertenza"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "" & MyBase.State.StateName & " incasso quota vertenza "
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & " incasso  quota   vertenza")
        SelectToolStripImage()
    End Sub
#End Region


#Region "Metodi per la creazione di un nuovo oggetto"
    Protected Overrides Sub Nested_PrepareForCreation()
        Me.TabControl1.Visible = True
        txtTotale.Enabled = False
        Me.GridPosizioni.Visible = False
        Me.CmdCrea.Visible = True
        Me.cmdPrest.Visible = False
        'DisplaydataForUtente()
        Me.txtImporto.Text = "0,00"
        Me.txtAttribuito.Text = "0,00"
        Me.txtTotale.Text = "0,00"
        CustomBar1.SetTargetControl(Me)
        Me.GrpSogg.Visible = False
    End Sub

   Private Sub DisplaydataForUtente()
      Try
         Dim controllerVert As New ADMINISTRATION.ControllerVertenze
         controllerVert.LoadById(Me.txtVertenza.Text)
         lblDescrizioneUtente.Text = controllerVert.DescrizioneUtente
         Me.m_IdUtente = controllerVert.IdUtente
         Me.m_IdReferente = controllerVert.IdReferente
         controllerVert = Nothing
         Me.GrpSogg.Visible = True
      Catch ex As Exception
         lblDescrizioneUtente.Text = ""
         Me.GrpSogg.Visible = False
      End Try
   End Sub
   Private Sub cmdCrea_DoClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCrea.DoClik
      Try
         DisplaydataForUtente()
         controller.CreateNew(dtpRegistrazione.Value.Date, Me.dtpDoc.Value.Date, _
                                           Me.txtNote.Text, Me.txtImporto.Text, m_IdUtente)

         controller.AddItem("", Me.txtVertenza.Text, Me.m_IdReferente)
         txtImporto.Text = controller.Importo
         CorrectImporto()
         PreparaCompilazione()
         LoadGrid()
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub
   Private Sub PreparaCompilazione()
      Try
         txtTotale.Text = controller.Totale
         Me.txtVertenza.Enabled = False
         Me.cmdSearch.Enabled = False
         Me.CmdCrea.Visible = False
         Me.cmdPrest.Visible = True
         Me.cmdBlu.BackgroundImage = My.Resources.Flag_grayHS
         Me.cmdRed.BackgroundImage = My.Resources.Flag_grayHS
         Me.cmdGreen.BackgroundImage = My.Resources.Flag_greenHS
         Me.GridPosizioni.Visible = True
      Catch ex As Exception
         Throw New Exception(ex.Message)
      End Try
   End Sub
#End Region


#Region "metodi per la navigazione"
   Protected Overrides Sub Navigate()
      Try
         Dim ParameterList As Hashtable = New Hashtable
         ParameterList.Add("Id", m_IdShowedObject)
         ParameterList.Add("TipoDocumento", "IQV")
         Me.NavigateTo("ViewDocumento", ParameterList)
      Catch ex As Exception
         Throw New Exception(ex.Message)
      End Try
   End Sub
   Private Sub RitornaAlComandoPrecedente()
      Try
         MasterControl.Instance.GoPrevious()
      Catch ex As Exception
         Throw New Exception(ex.Message)
      End Try
   End Sub
#End Region


#Region "Metodi per il salvataggio"
    Public Overrides Sub Nested_InsertData()
        Try
            controller.Save()
            MyBase.m_IdShowedObject = controller.IdDocumento
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
#End Region


#Region "Metodi per l'usabilità  della griglia"
   Private Sub GridPosizioni_CellEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridPosizioni.CellEnter
      Try
         If GridPosizioni.Columns(e.ColumnIndex).Name = "Note" Then
            GridPosizioni.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.SelectionBackColor = Drawing.Color.LightGray
            GridPosizioni.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.BackColor = Drawing.Color.LightGreen
         End If
         If GridPosizioni.Columns(e.ColumnIndex).Name = "ImportoPosizione" Then
            GridPosizioni.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.SelectionBackColor = Drawing.Color.LightGray
            GridPosizioni.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.BackColor = Drawing.Color.LightGreen
         End If
         If GridPosizioni.Columns(e.ColumnIndex).Name = "CercaReferenti" Then
            GridPosizioni.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.SelectionBackColor = Drawing.Color.LightGray
         End If
      Catch ex As Exception

      End Try
   End Sub
   Private Sub GridPosizioni_CellLeave(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridPosizioni.CellLeave
      Try
         GridPosizioni.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.BackColor = Drawing.Color.White
      Catch ex As Exception

      End Try
   End Sub
#End Region


#Region "Metodi per la gestione  della griglia"

   Private Sub GridPosizioni_CellBeginEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles GridPosizioni.CellBeginEdit
      Try
         controller.SelectItem(GridPosizioni.Rows(e.RowIndex).Cells("Vertenza").Value.Id.ToString)
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub
   Private Sub GridPosizioni_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridPosizioni.CellContentClick
      Try
         If GridPosizioni.Columns(e.ColumnIndex).Name = "CercaReferenti" AndAlso Not e.RowIndex = -1 Then
            Dim frm As New SearchReferenti
            frm.ShowDialog()
            If frm.DialogResult = Windows.Forms.DialogResult.OK Then
               controller.SelectItem(GridPosizioni.Rows(e.RowIndex).Cells("Vertenza").Value.Id.ToString)
               controller.SetReferenteItem(frm.SelectedId)
               GridPosizioni.Refresh()
            End If
            frm.Dispose()
         End If
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub
   Private Sub GridPosizioni_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridPosizioni.CellEndEdit
      'in questo punto eseguo le variazioni sul controller
      Try
         If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("ImportoPosizione") Then
            controller.SetImportoItem(GridPosizioni.Rows(e.RowIndex).Cells("ImportoPosizione").Value)
            controller.SetImporto(GridPosizioni.Rows(e.RowIndex).Cells("ImportoPosizione").Value)
            Me.txtImporto.Text = controller.Importo
            txtTotale.Text = controller.Totale
            Me.txtAttribuito.Text = controller.TotaleAttribuito
            GridPosizioni.Refresh()
            SetBandierine()
         End If
         If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("Note") Then
            controller.NoteItem = GridPosizioni.Rows(e.RowIndex).Cells("Note").Value
            GridPosizioni.Refresh()
         End If
         If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("IdReferente") Then
            controller.SetReferenteItem(GridPosizioni.Rows(e.RowIndex).Cells("IdReferente").Value)
            GridPosizioni.Refresh()
         End If
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub
   Private Sub GridPosizioni_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles GridPosizioni.CellFormatting
      Try
         If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("Utente") Then
            If Not e.Value Is Nothing Then
               GridPosizioni.Rows(e.RowIndex).Cells("IdUtente").Value = e.Value.IdUtente
               e.Value = e.Value.CompleteName
            End If
         End If
         If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("Referente") Then
            If Not e.Value Is Nothing Then
               GridPosizioni.Rows(e.RowIndex).Cells("IdReferente").Value = e.Value.IdReferente
               e.Value = e.Value.CompleteName
            End If
         End If

         'If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("Prestazione") Then
         '   If Not e.Value Is Nothing Then
         '      GridPosizioni.Rows(e.RowIndex).Cells("TipoPrestazione").Value = e.Value.TipoPrestazione.Descrizione
         '      e.Value = e.Value.Id.ToString
         '   End If
         'End If
         'If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("Vertenza") Then
         '   If Not e.Value Is Nothing Then
         '      e.Value = e.Value.Id.ToString
         '   End If
         'End If

         If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("Importo") Then
            If Not e.Value Is Nothing Then
               GridPosizioni.Rows(e.RowIndex).Cells("ImportoPosizione").Value = CDbl(e.Value.Importo) * -1
               e.Value = e.Value.GetTipoValutaToString(e.Value.GetValuta)
            End If
         End If

         'If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("Competenza") Then
         '   If Not e.Value Is Nothing Then
         '      GridPosizioni.Rows(e.RowIndex).Cells("DICompetenza").Value = Format(e.Value.GetDataRange.Start, "dd/MM/yyyy")
         '      GridPosizioni.Rows(e.RowIndex).Cells("DFCompetenza").Value = Format(e.Value.GetDataRange.Finish, "dd/MM/yyyy")
         '      e.Value = e.Value.ToString
         '   End If
         'End If
      Catch ex As Exception
         'Throw New Exception(ex.Message)
         'ErrorHandler.ShowError(ex)
      End Try
   End Sub


#End Region


#Region "Metodi per l'aggiornamento del pagamento"
   Private Sub txtNote_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNote.TextChanged
      Try
         If controller.IsCreated Then controller.Note = txtNote.Text
         System.Windows.Forms.Application.DoEvents()
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub
   Private Sub txtImporto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtImporto.Leave
      CorrectImporto()
   End Sub
   Private Sub CorrectImporto()
      Try
         If controller.IsCreated Then
            controller.SetImporto(txtImporto.Text)
            controller.SelectItem(Me.txtVertenza.Text)
            controller.SetImportoItem(txtImporto.Text)
            txtTotale.Text = controller.Totale
            Me.txtAttribuito.Text = controller.TotaleAttribuito
            System.Windows.Forms.Application.DoEvents()
            SetBandierine()
         End If
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
         If controller.IsCreated Then
            txtImporto.Text = controller.Importo
         End If
      End Try
   End Sub
   Private Sub SetBandierine()
      If controller.Importo > 0 And controller.Totale = 0 Then
         Me.cmdGreen.BackgroundImage = My.Resources.Flag_greenHS
         Me.cmdRed.BackgroundImage = My.Resources.Flag_grayHS
      Else
         Me.cmdGreen.BackgroundImage = My.Resources.Flag_grayHS
         Me.cmdRed.BackgroundImage = My.Resources.Flag_redHS
      End If
   End Sub
   Private Sub dtpRegistrazione_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpRegistrazione.Leave
      Try
         If controller.IsCreated Then controller.DataRegistrazione = dtpRegistrazione.Value
         System.Windows.Forms.Application.DoEvents()
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Private Sub dtpDoc_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpDoc.Leave
      Try
         If controller.IsCreated Then controller.DataDocumento = dtpDoc.Value
         System.Windows.Forms.Application.DoEvents()
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub
   Private Sub lblValuta_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblValuta.TextChanged
      lblTot.Text = lblValuta.Text
   End Sub
#End Region



   Private Sub CustomBar1_DoAnnullaClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoAnnullaClick
      Try
         MasterControl.Instance.GoPrevious()
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub
   Private Sub CustomBar1_DoSaveClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoSaveClick
      Try
            StartSaveOperation()
         Navigate()
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Private Sub cmdPrest_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles cmdPrest.DoClik
      Shell(MasterControl.Instance.GetAppPathWithParameter(New String() {SecurityManager.Instance.CurrentUser.Username, SecurityManager.Instance.CurrentUser.Password}), AppWinStyle.NormalFocus)
   End Sub


   Private Sub cmdCompetenza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
      Dim frm As New FrmRicercaVertenze()
      frm.ShowDialog()
      If frm.DialogResult = DialogResult.OK Then
         Me.txtVertenza.Text = frm.SelectedId
         'Me.lblDescrizioneUtente.Text = frm.NomeUtente
         'If Me.lblDescrizioneUtente.Text <> "" Then
         '   GrpSogg.Visible = True
         'End If
         ''LoadGrid()
      End If
      frm.Dispose()
   End Sub

   Private Sub txtVertenza_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtVertenza.Leave
      Me.DisplaydataForUtente()
   End Sub



End Class
