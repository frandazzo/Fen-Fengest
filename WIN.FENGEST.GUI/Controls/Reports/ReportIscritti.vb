Imports System.Windows.Forms
Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY
Imports WIN.SECURITY.Exceptions

<SecureContext()> _
Public Class ReportIscritti
   Private controller As REPORTING.ReportIscritti
   Private m_selectedColumnName As String = ""
    Private fullview As Boolean = True
    Private WithEvents m_excelExporter As ExcelExporterListaAziende

    Private frm1 As FrmElaborazioneInCorso

   Public Sub New()

      ' Chiamata richiesta da Progettazione Windows Form.
      InitializeComponent()

      ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

   End Sub
   Public Sub New(ByVal ReportingService As Object)

      InitializeComponent()
      controller = DirectCast(ReportingService, REPORTING.ReportIscritti)
      Me.IdShowedObject = 0
      DoLoad()

   End Sub




    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "Report iscritti"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Report iscritti"
        Me.lblCurrentFunction.Text = UCase("Report  iscritti")
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.ActualSizeHS
    End Sub

    Protected Overrides Sub Nested_PostLoadingActions()
        Dim logo As String = "Report iscritti"
        MasterControl.Instance.ParentForm.Text = logo
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo
        Me.lblCurrentFunction.Text = UCase(logo)
    End Sub





   Protected Overloads Sub Navigate(ByVal ToId As String, ByVal Link As String)

      Dim ParameterList As Hashtable = New Hashtable
      ParameterList.Add("Id", ToId)
      Me.NavigateTo(Link, ParameterList)

   End Sub

   Private Sub GridPosizioni_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridPosizioni.CellDoubleClick
      If e.RowIndex = -1 Or e.ColumnIndex = -1 Then
         Return
      End If
      If GridPosizioni.SelectedCells.Count = 0 Then Return
      If GridPosizioni.SelectedCells.Count > 1 Then Return
      Try
         Select Case GridPosizioni.Columns(e.ColumnIndex).Name

            Case "Utente"
               Navigate(GridPosizioni.SelectedCells(0).Value.IdUtente, "ViewUtente")


            Case "AziendaImpiego"
               Navigate(GridPosizioni.SelectedCells(0).Value.Id, "ViewAzienda")


         End Select

      Catch ex As AccessDeniedException
         MsgBox("Impossibile eliminare l'elemento. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub









    Protected Overrides Sub Nested_PrepareLoading()
        Dim gridLoader As New GridLoaderRptIscritti(Me.GridPosizioni)
        gridLoader.LoadGrid(controller.SearchResult)
        'numIsc.Text = controller.NumeroPosizioniIQA
        'numRev.Text = controller.NumeroPosizioniIQI
        'numNew.Text = controller.NumeroPosizioniIQV





        lblData.Text = Format(Now, "dd/MM/yyyy hh:mm")
        lblCompetenza.Text = controller.CompetenzaRange
        lblSettore.Text = controller.NomeSettore
        lblContratto.Text = controller.NomeContratto
        lblSogg.Text = controller.NomeAzienda
        lblVerifica.Text = controller.VerificaDelega
        lblReferente.Text = controller.NomeReferente
        Me.numIsc.Text = controller.NumeroIscritti
        Me.numNew.Text = controller.NumeroIscrittiNuovi
        Me.numRevCGL.Text = controller.NumeroIscrittiConRevocaCGL
        Me.NumRevCisl.Text = controller.NumeroIscrittiConRevocaCISL

        ''lblReferente.Text = controller.NomeReferente

    End Sub

   Private Sub GridPosizioni_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles GridPosizioni.CellFormatting
      'Try
      If GridPosizioni.Columns(e.ColumnIndex).Name.Equals("Utente") Then
         If Not e.Value Is Nothing Then
            e.Value = e.Value.ToString
         End If
      End If

   End Sub
   Private Function GetImage(ByVal ImageType As String) As System.Drawing.Image
      If ImageType = "0" Then
         Return My.Resources.OK
      Else
         Return My.Resources.WarningHS
      End If
   End Function






   Private Sub GridPosizioni_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GridPosizioni.ColumnHeaderMouseClick
      'qui seleziono tutta la colonna
      GridPosizioni.ClearSelection()
      For Each elem As DataGridViewColumn In GridPosizioni.Columns
         elem.HeaderCell.SortGlyphDirection = SortOrder.None
      Next
      Try
         GridPosizioni.Columns(e.ColumnIndex).HeaderCell.SortGlyphDirection = SortOrder.Descending
         m_selectedColumnName = GridPosizioni.Columns(e.ColumnIndex).Name
      Catch ex As Exception
         m_selectedColumnName = ""
      End Try

   End Sub




   Private Sub cmdUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUp.DoClik
      Try
         controller.SortItems(m_selectedColumnName)
         ' Me.GridPosizioni.DataSource = controller.SearchResult
         Me.GridPosizioni.Refresh()
         GridPosizioni.Columns(m_selectedColumnName).HeaderCell.SortGlyphDirection = SortOrder.Descending
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub
   Private Sub cmdDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdDown.DoClik
      Try
         controller.SortItems(m_selectedColumnName, True)
         ' Me.GridPosizioni.DataSource = controller.SearchResult
         Me.GridPosizioni.Refresh()
         GridPosizioni.Columns(m_selectedColumnName).HeaderCell.SortGlyphDirection = SortOrder.Descending
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub



   Private Sub SpecialButton1_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles cmdPrint.DoClik
      Try
         Dim print As PrintFacade = New PrintFacade
         print.PrintReportIscritti(controller)
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Private Sub cmdListaLavoro_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles cmdListaLavoro.DoClik
      Try


         Dim frm As New FrmDescrListaLavoro
         frm.ShowDialog()
         Dim descr As String = frm.Descrizione

         If frm.DialogResult = DialogResult.OK Then
            Dim controllerListe As New ControllerListaUtenti
            controllerListe.CreateNew()
            controllerListe.Descrizione = descr

            For Each elem As Object In controller.Results
               controllerListe.AddUtente(elem.Utente.IdUtente)
            Next
            controllerListe.Save()
            MsgBox("Lista creata con successo!", MsgBoxStyle.Information, "Creazione lista lavoro utenti")
         End If

      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Private Sub cmdPrintCard_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles cmdPrintCard.DoClik
      Try
         If controller.SearchResult.Count = 0 Then
            Return
         End If
         Dim frm As New FrmOptStampaTessere
         If frm.ShowDialog = DialogResult.OK Then
                'controller.SetPrintCardsTable(frm.WithoutTesseraAnnuale)
            PrintCards()
         End If


      Catch ex As AccessDeniedException
         MsgBox("Impossibile accedere alla funzionalitą richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   <Secure(Area:="Stampe", Alias:="Stampa tessere", Macroarea:="Reportistica")> _
   Private Sub PrintCards()
      SecurityManager.Instance.Check()
      GoToPrintCards()
   End Sub

   Public Sub GoToPrintCards()

      Dim provinceName As String = GetProvince()



      Dim path As String = GetAppPrintCardPathWithParameter(New String() {"""" & PersistenceInfo.ConnectionString & """", PersistenceInfo.ServiceName, provinceName})
      Shell(path, AppWinStyle.NormalFocus)
   End Sub

   Private Function GetProvince() As String
      Dim c As New ControllerSegreteria
      c.LoadById("1")

      If c.ProvinciaLegale = "" Then
         Return "(Vuoto)"
      End If
      Return c.ProvinciaLegale


   End Function

   Public Overloads Function GetAppPrintCardPathWithParameter(ByVal Parameter() As String) As String
      Dim path As String = My.Application.Info.DirectoryPath & "\WIN.FENGEST_PRINT_CARDS.GUI.exe" '& FileShortName
      If Parameter.Length > 0 Then
         For argNum As Integer = 0 To UBound(Parameter, 1)
            path = path & " " & Parameter(argNum)
         Next argNum
      End If
      Return path
   End Function


   Private Sub spview_DoClik(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles spview.DoClik
      Try
         SetupView()
      Catch ex As Exception
         WIN.GUI.APPLICATION.PRESENTATION.ErrorHandler.ShowError(ex)
      End Try

   End Sub


   Private Sub SetupView()
      If fullview Then
         ViewFullGrid()

      Else
         ViewAllData()
      End If
   End Sub

   Private Sub ViewFullGrid()
      GroupBox1.Visible = False
      GroupBox2.Visible = False
      GridPosizioni.Location = New System.Drawing.Point(GridPosizioni.Location.X, 78)
      GridPosizioni.Size = New Size(New Point(GridPosizioni.Size.Width, 554))
      Panel1.Location = New Point(Panel1.Location.X, 78)
      fullview = False
   End Sub

   Private Sub ViewAllData()
      GroupBox1.Visible = True
      GroupBox2.Visible = True
      GridPosizioni.Location = New System.Drawing.Point(15, 286)
      GridPosizioni.Size = New Size(New Point(GridPosizioni.Size.Width, 350))
      Panel1.Location = New Point(592, 286)
      fullview = True
    End Sub

    

    
End Class
