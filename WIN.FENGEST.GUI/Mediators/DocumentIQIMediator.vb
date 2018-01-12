Imports WIN.APPLICATION.FINANCIAL_ARTIFACTS
Imports WIN.APPLICATION.AZIENDE
Imports System.Windows.Forms
Public Class DocumentIQIMediator
   Implements IDocumentViewMediator

   Dim WithEvents frm As FrmItemContabile

   Public Sub DefineLayout(ByVal Control As BrowserControl, ByVal DocumentType As String) Implements IDocumentViewMediator.DefineDocumentViewLayout
      Dim controlDoc As ControlDocumentView = DirectCast(Control, ControlDocumentView)
      With controlDoc
         Dim i As Integer = 20
         .GrpSogg.Visible = True
         .cmdAdd.Visible = True
         .cmdDel.Visible = True
         .cmdUp.Visible = True
         .CmdDown.Visible = True
         .GrpRef.Visible = False
         .lblRef.Visible = False
         .txtReferente.Visible = False
         .lblSettore.Visible = False
         .txtSettore.Visible = False
         .SetNomeTipoDocumento("Incasso quote Inps")
         .GrpSogg.Size = New System.Drawing.Size(.GrpSogg.Size.Width, 126)
         .GrpSogg.Location = New System.Drawing.Point(.GrpSogg.Location.X, .GrpSogg.Location.Y + 43)
         .GroupBox1.Size = New System.Drawing.Size(.GroupBox1.Size.Width, 191)
         .Panel1.Location = New System.Drawing.Point(.Panel1.Location.X, .Panel1.Location.Y - i)
         .cmdUp.Location = New System.Drawing.Point(.cmdUp.Location.X, .cmdUp.Location.Y + i)
         .CmdDown.Location = New System.Drawing.Point(.cmdUp.Location.X, .CmdDown.Location.Y + i)
         .cmdAdd.Location = New System.Drawing.Point(.cmdUp.Location.X, .cmdAdd.Location.Y + i)
         .cmdDel.Location = New System.Drawing.Point(.cmdUp.Location.X, .cmdDel.Location.Y + i)
         .txtNote.Height = .txtNote.Height - 30
         .cmdDel.Location = New System.Drawing.Point(.cmdDel.Location.X, .cmdDel.Location.Y - i)
         .cmdAdd.Location = New System.Drawing.Point(.cmdAdd.Location.X, .cmdAdd.Location.Y - i)
         .CmdDown.Location = New System.Drawing.Point(.CmdDown.Location.X, .CmdDown.Location.Y - i)
         .cmdUp.Location = New System.Drawing.Point(.cmdUp.Location.X, .cmdUp.Location.Y - i)
         .GridPosizioni.Location = New System.Drawing.Point(.GridPosizioni.Location.X, .GridPosizioni.Location.Y - i)
         .GridPosizioni.Size = New System.Drawing.Size(.GridPosizioni.Size.Width, .GridPosizioni.Size.Height + i)

      End With

   End Sub
   Public Sub GetSpecificDocumentProperties(ByVal Control As BrowserControl, ByVal Controller As AbstractController) Implements IDocumentViewMediator.GetSpecificDocumentProperties
      Dim controllerDoc As ControllerIncassiQuoteInps = DirectCast(Controller, ControllerIncassiQuoteInps)
      Dim controlDoc As ControlDocumentView = DirectCast(Control, ControlDocumentView)
      controlDoc.txtCompetenza.Text = controllerDoc.Competenza

      controlDoc.txtImporto.Text = controllerDoc.Importo
      DisplaydataForSoggettoInps(controlDoc)

      Dim gridloader As AbstractGridLoader = GridLoaderDocumentFactory.GetGridDocumentLoader("IQI", controlDoc.GridPosizioni)
      gridloader.SelectionMode = DataGridViewSelectionMode.FullRowSelect
      gridloader.LoadGrid(controllerDoc.ListaPosizioniUtenti)
   End Sub
   Private Sub DisplaydataForSoggettoInps(ByVal control As ControlDocumentView)
      With control
         Try
            Dim controllerAziende As New AZIENDE.ControllerInps
            controllerAziende.LoadById(1)
            .lblDescrizioneAzienda.Text = controllerAziende.Descrizione
            .lblCompUltimo.Text = controllerAziende.CompetenzaUltimoPagamento
            controllerAziende = Nothing
         Catch ex As Exception
            .lblDescrizioneAzienda.Text = ""
            .lblCompUltimo.Text = ""
         End Try
      End With
   End Sub

   Public Sub RefeshItemsGrid(ByVal Control As BrowserControl, ByVal controller As AbstractController) Implements IDocumentViewMediator.RefeshItemsGrid
      Dim controllerDoc As ControllerIncassiQuoteInps = DirectCast(controller, ControllerIncassiQuoteInps)
      Dim controlDoc As Object
      If TypeOf (Control) Is ControlDocumentView Then
         controlDoc = DirectCast(Control, ControlDocumentView)
      Else
         controlDoc = DirectCast(Control, ControlPagamentoQuoteInps)
      End If
      controlDoc.GridPosizioni.DataSource = controllerDoc.ListaPosizioniUtenti
      controlDoc.GridPosizioni.Refresh()
      'la inserisco qui poichè una variazione dell'importo di una posizione rivisualizza l'importo totale
      controlDoc.txtImporto.Text = controllerDoc.Importo

   End Sub
   Public Sub GetSpecificItemProperties(ByVal Control As BrowserControl, ByVal controller As AbstractController) Implements IDocumentViewMediator.GetSpecificItemProperties
      Dim frm As ControlItemContabile = DirectCast(Control, ControlItemContabile)
      Dim controllerDoc As ControllerIncassiQuoteInps = DirectCast(controller, ControllerIncassiQuoteInps)
      With frm
         .lblDescrizioneSogg.Text = controllerDoc.DescrizioneSoggettoEsecutore
         .lblDescrizioneUtente.Text = controllerDoc.NameUtenteItem
         .lblDescrizioneReferente.Text = controllerDoc.NameReferenteItem
         .lblDescrAzImpiego.Text = ""
         .IdAziendaTextBox1.Enabled = False
         .IdUtenteTextBox1.Enabled = False
         .txtLav.Enabled = False
         .txtMal.Enabled = False
         .txtSettore.Text = ""
         .txtLiv.Enabled = False
         .txtTipoPrest.Text = controllerDoc.DescrizioneTipoPrestazione
         .txtIdPrest.Text = controllerDoc.IdPrestazioneItem
         If controllerDoc.CongruitaItemToString = "Quota congrua" Then
            .cmdCongrua.Image = My.Resources.OK
         Else
            .cmdCongrua.Image = My.Resources.WarningHS
         End If
         .chk13.Enabled = False
         .chk14.Enabled = False
      End With
   End Sub
   Public Sub SetItemProperties(ByVal FrmItem As System.Windows.Forms.Form, ByVal controller As AbstractController) Implements IDocumentViewMediator.SetItemProperties
      Dim frm As FrmItemContabile = DirectCast(FrmItem, FrmItemContabile)
      Dim controllerDoc As ControllerIncassiQuoteInps = DirectCast(controller, ControllerIncassiQuoteInps)
      With controllerDoc
         .SetImportoItem(frm.ControlItemContabile1.txtImporto.Text)
         .NoteItem = frm.ControlItemContabile1.txtNote.Text
         .SetCompetenzaItem(frm.ControlItemContabile1.DataInizioCompetenza, frm.ControlItemContabile1.DataFineCompetenza)
         .SetReferenteItem(frm.ControlItemContabile1.IdReferenteTextBox1.TextValue)
      End With
   End Sub
   Public Sub DefineNewItemViewLayout(ByVal Control As BrowserControl, ByVal controller As AbstractController) Implements IDocumentViewMediator.DefineNewItemViewLayout
      Dim frm As ControlItemContabile = DirectCast(Control, ControlItemContabile)
      Dim controllerDoc As ControllerIncassiQuoteInps = DirectCast(controller, ControllerIncassiQuoteInps)
      With frm
         .lblDescrizioneSogg.Text = controllerDoc.DescrizioneSoggettoEsecutore
         .lblDescrizioneUtente.Text = ""
         .lblDescrizioneReferente.Text = ""
         .lblDescrAzImpiego.Text = ""
         .txtSettore.Text = ""
         .DataInizioCompetenza = controllerDoc.DataInizioCompetenza
         .DataFineCompetenza = controllerDoc.DataFineCompetenza
         .txtCompetenza.Text = controllerDoc.Competenza
         .IdAziendaTextBox1.Enabled = False
         .IdAziendaTextBox1.TextValue = ""
         .DescribeAzienda()
         .cmdCongrua.Image = My.Resources.WarningHS
      End With
   End Sub
   Public Sub AddNewItem(ByVal FrmItem As System.Windows.Forms.Form, ByVal controller As AbstractController) Implements IDocumentViewMediator.AddNewItem
      Dim frm As FrmItemContabile = DirectCast(FrmItem, FrmItemContabile)
      Dim controllerDoc As ControllerIncassiQuoteInps = DirectCast(controller, ControllerIncassiQuoteInps)
      'DirectCast(controller, ControllerIncassiQuote).AddItem(frm.IdUtente, frm.Importo, "-1", "", False, False, frm.DataInizio, frm.DataFine)
      'With frm.ControlItemContabile1
      '   controllerDoc.AddItem(.IdUtenteTextBox1.TextValue, .txtImporto.Text, .IdReferenteTextBox1.TextValue, .txtNote.Text, .chk13.Checked, .chk14.Checked, .DataInizioCompetenza, .DataFineCompetenza, Not My.Settings.CheckPaybility)
      '   controllerDoc.SelectItem(.IdUtenteTextBox1.TextValue, .DataInizioCompetenza, .DataFineCompetenza)
      '   Try
      '      If controllerDoc.IsForSettoreEdile Then
      '         controllerDoc.SetAziendaImpiegoItem(.IdAziendaTextBox1.TextValue)
      '      End If
      '      controllerDoc.OreLavorateItem = .txtLav.Text
      '      controllerDoc.OreMalattiaItem = .txtMal.Text
      '      controllerDoc.LivelloInquadramentoItem = .txtLiv.Text
      '   Catch ex As Exception
      '      ErrorHandler.ShowError(ex)
      '      frm.Close()
      '   End Try
      'End With

   End Sub

   Public Sub ViewItemDetail(ByVal Controller As AbstractController) Implements IDocumentViewMediator.ViewItemDetail
      frm = New FrmItemContabile("View", Controller, "IQI")
      frm.ShowDialog()
      frm.Dispose()
   End Sub


   Public Sub DefineItemViewLayout(ByVal Control As BrowserControl, ByVal controller As AbstractController) Implements IDocumentViewMediator.DefineItemViewLayout
      '
   End Sub
End Class

