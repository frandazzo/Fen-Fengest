Imports System.Windows.Forms
Public Class FrmOpzioni
   Dim controllerOpzioni As New OptionController


   Private Sub CmdApplica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdApplica.Click
      My.Settings.VisualizzaFileOutput = Me.chkVisualizzaFile.Checked
      My.Settings.CheckPaybility = Me.chkPaybility.Checked
      My.Settings.ComuneDefault = Me.txtCom.Text
      My.Settings.ProvinciaDefault = Me.txtPro.Text
      My.Settings.NazioneDefault = Me.txtNaz.Text
      My.Settings.CreateDefaultPositionIF = Me.chkDefaultPosIF.Checked
      My.Settings.MaxReturnedRecordNumber = Me.txtRecordMax.Text
        '  My.Settings.PathModelli = Me.txtPathModelli.Text
      'My.Settings.PathComunicazioniDefault = Me.txtPathComunicazioni.Text
      My.Settings.PathDefaultCartelleUtenti = Me.txtPathDefaultCartelleUtenti.Text
      My.Settings.PathDefaultCartelleAziende = Me.txtPathDefaultCartelleAziende.Text
      'My.Settings.FederationSite = Me.txtSite.Text

      ''print settings
      'WIN.GUI.PRINT.SettingsManager.SetReportFooterTextCitta(Me.txtCitta.Text)
      'WIN.GUI.PRINT.SettingsManager.SetReportFooterTextMail(Me.txtMail.Text)
      'WIN.GUI.PRINT.SettingsManager.SetReportFooterTextSitoWeb(Me.txtWebSite.Text)
      'WIN.GUI.PRINT.SettingsManager.SetReportFooterTextTelFax(Me.txtTelFax.Text)
      'WIN.GUI.PRINT.SettingsManager.SetReportFooterTextVia(Me.txtVia.Text)
      'WIN.GUI.PRINT.SettingsManager.SetReportTitlePersonalizzato(Me.txtSottotitolo3.Text)
      'WIN.GUI.PRINT.SettingsManager.SetReportTitle(Me.txtTitoloPagina.Text)
      'WIN.GUI.PRINT.SettingsManager.SetReportSubTitle(Me.txtSottotitolo1.Text)
      'WIN.GUI.PRINT.SettingsManager.SetReportSubTittle2(Me.txtSottotitolo2.Text)

      My.Settings.Save()

   End Sub

   Private Sub cmdAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnnulla.Click
      Me.Close()
   End Sub

   Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
      Me.Close()
   End Sub

   Private Sub FrmOpzioni_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      Me.chkVisualizzaFile.Checked = My.Settings.VisualizzaFileOutput
      Me.txtCom.Text = My.Settings.ComuneDefault
      Me.txtPro.Text = My.Settings.ProvinciaDefault
      Me.txtNaz.Text = My.Settings.NazioneDefault
      Me.chkPaybility.Checked = My.Settings.CheckPaybility
      Me.chkDefaultPosIF.Checked = My.Settings.CreateDefaultPositionIF
      Me.txtRecordMax.Text = My.Settings.MaxReturnedRecordNumber
      'print settings

      'Me.txtTitoloPagina.Text = WIN.GUI.PRINT.SettingsManager.GetReportTitle
      'Me.txtSottotitolo1.Text = WIN.GUI.PRINT.SettingsManager.GetReportSubTitle
      'Me.txtSottotitolo2.Text = WIN.GUI.PRINT.SettingsManager.GetReportSubTittle2
      'Me.txtSottotitolo3.Text = WIN.GUI.PRINT.SettingsManager.GetReportTitlePersonalizzato
      'Me.txtCitta.Text = WIN.GUI.PRINT.SettingsManager.GetReportFooterTextCitta()
      'Me.txtMail.Text = WIN.GUI.PRINT.SettingsManager.GetReportFooterTextMail
      'Me.txtWebSite.Text = WIN.GUI.PRINT.SettingsManager.GetReportFooterTextSitoWeb
      'Me.txtTelFax.Text = WIN.GUI.PRINT.SettingsManager.GetReportFooterTextTelFax
      'Me.txtVia.Text = WIN.GUI.PRINT.SettingsManager.GetReportFooterTextVia
        'Me.txtPathModelli.Text = My.Settings.PathModelli
      'Me.txtPathComunicazioni.Text = My.Settings.PathComunicazioniDefault
      Me.txtPathDefaultCartelleUtenti.Text = My.Settings.PathDefaultCartelleUtenti
      Me.txtPathDefaultCartelleAziende.Text = My.Settings.PathDefaultCartelleAziende
      'Me.txtSite.Text = My.Settings.FederationSite

      LoadGridTagger(GridUtentiTagger, controllerOpzioni.SearchTaggerUtenti)
      LoadGridTagger(GridSereteriaTagger, controllerOpzioni.SearchTaggerSegreteria)

   End Sub

   Public Sub LoadGridTagger(ByVal grid As DataGridView, ByVal Lista As IList)
      With grid
         If Lista.Count > 0 Then
            .DataSource = Lista


            .AutoGenerateColumns = False
            .Columns("Key").Visible = False
            .Columns("Id").Visible = False
            .Columns("Versione").Visible = False
            .Columns("CreatoDa").Visible = False
            .Columns("ModificatoDa").Visible = False
            .Columns("DataCreazione").Visible = False
            .Columns("DataModifica").Visible = False
            .Columns("Descrizione").Visible = False
            .Columns("Tipo").Visible = False
            .Columns("NomeProprieta").Visible = False


            .Columns("Campo").DisplayIndex = 0
            .Columns("Campo").ReadOnly = True

            .Columns("ValoreTag").DisplayIndex = 1
            .Columns("ValoreTag").HeaderText = "Valore tag"
            .Columns("ValoreTag").ReadOnly = True






            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

         End If
      End With

   End Sub








   Private Sub cmdIQA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIQA.Click
      Try
         Dim process As New Process
         Dim info As New ProcessStartInfo
         Dim temp As String = Me.GetType.Assembly.CodeBase.Replace("file:///", "")
         temp = temp.Replace("/WIN.FENGEST.GUI.DLL", "")
         info.FileName = temp & "/Templates/TemplateImportIQA.xlt"
         Diagnostics.Process.Start(info)
         process.Dispose()
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try

   End Sub

   Private Sub cmdDeleghe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDeleghe.Click
      Try
         Dim process As New Process
         Dim info As New ProcessStartInfo
         Dim temp As String = Me.GetType.Assembly.CodeBase.Replace("file:///", "")
         temp = temp.Replace("/WIN.FENGEST.GUI.DLL", "")
         info.FileName = temp & "/Templates/TemplateImportDeleghe.xlt"
         Diagnostics.Process.Start(info)
         Process.Dispose()
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try


   End Sub

   Private Sub cmdPathModelli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPathModelli.Click
      FolderBrowserDialog1.ShowNewFolderButton = True
      FolderBrowserDialog1.ShowDialog()
      If FolderBrowserDialog1.SelectedPath <> "" Then
         Me.txtPathModelli.Text = FolderBrowserDialog1.SelectedPath
      End If

   End Sub

   'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
   '   FolderBrowserDialog1.ShowNewFolderButton = True
   '   FolderBrowserDialog1.ShowDialog()
   '   If FolderBrowserDialog1.SelectedPath <> "" Then
   '      Me.txtPathComunicazioni.Text = FolderBrowserDialog1.SelectedPath
   '   End If
   'End Sub

   Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
      Try
         Dim process As New Process
         Dim info As New ProcessStartInfo
         Dim temp As String = Me.GetType.Assembly.CodeBase.Replace("file:///", "")
         temp = temp.Replace("/WIN.FENGEST.GUI.DLL", "")
         info.FileName = temp & "/Templates/TemplateImportLiberi.xlt"
         Diagnostics.Process.Start(info)
         process.Dispose()
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try

   End Sub

   Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
      FolderBrowserDialog1.ShowNewFolderButton = True
      FolderBrowserDialog1.ShowDialog()
      If FolderBrowserDialog1.SelectedPath <> "" Then
         Me.txtPathDefaultCartelleUtenti.Text = FolderBrowserDialog1.SelectedPath
      End If
   End Sub

   Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
      FolderBrowserDialog1.ShowNewFolderButton = True
      FolderBrowserDialog1.ShowDialog()
      If FolderBrowserDialog1.SelectedPath <> "" Then
         Me.txtPathDefaultCartelleAziende.Text = FolderBrowserDialog1.SelectedPath
      End If
   End Sub
End Class