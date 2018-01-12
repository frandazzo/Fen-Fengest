Imports WIN.APPLICATION.FINANCIAL_ARTIFACTS
Imports WIN.APPLICATION.AZIENDE
Imports System.Windows.Forms
Public Class DocumentIQAMediator
   Implements IDocumentViewMediator
   Dim gridloader As AbstractGridLoader
   Dim itemList As IList
   Delegate Sub GridLoadMaker()
   Dim Grid As System.Windows.Forms.DataGridView
   Dim WithEvents frm As FrmItemContabile
   Dim ControllerForSepThread As AbstractDocumentController
   Dim deleg As GridLoadMaker

   Public Sub DefineLayout(ByVal Control As BrowserControl, ByVal DocumentType As String) Implements IDocumentViewMediator.DefineDocumentViewLayout
      Dim controlDoc As ControlDocumentView = DirectCast(Control, ControlDocumentView)
      With controlDoc
         .GrpSogg.Visible = True
         .cmdAdd.Visible = True
         .cmdDel.Visible = True
         .cmdUp.Visible = True
         .CmdDown.Visible = True
         .GrpRef.Visible = False
         .lblRef.Visible = False
         .txtReferente.Visible = False
         .SetNomeTipoDocumento("Incasso quote associative")
      End With

   End Sub
   Public Sub GetSpecificDocumentProperties(ByVal Control As BrowserControl, ByVal Controller As AbstractController) Implements IDocumentViewMediator.GetSpecificDocumentProperties
      Dim controllerDoc As ControllerIncassiQuote = DirectCast(Controller, ControllerIncassiQuote)
      ControllerForSepThread = controllerDoc
      Dim controlDoc As ControlDocumentView = DirectCast(Control, ControlDocumentView)
      controlDoc.txtCompetenza.Text = controllerDoc.Competenza
      controlDoc.txtSettore.Text = controllerDoc.DescrizioneSettore
      controlDoc.txtImporto.Text = controllerDoc.Importo
      Dim controllerset As New ControllerSettori
      controllerset.LoadById(controllerDoc.IdSettore)
      If controllerset.IsSettoreEdile Then
         DisplayDataforSoggettoEdile(controlDoc, controllerDoc.DescrizioneSoggettoEsecutore)
      Else
         DisplaydataForSoggettoIF(controlDoc, controllerDoc.IdSoggettoEsecutore)
      End If
      gridloader = GridLoaderDocumentFactory.GetGridDocumentLoader("IQA", controlDoc.GridPosizioni)
      Grid = controlDoc.GridPosizioni
      gridloader.SelectionMode = DataGridViewSelectionMode.FullRowSelect



      MasterControl.Instance.ParentForm.Text = "Attendere ricerca e ricostruzione documento"
      MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Attendere ricerca e ricostruzione documento"
      MasterControl.Instance.Current.SetLabelForCurrentFunction(UCase(" Attendere  ricerca  e  ricostruzione  documento "))
      MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.status_anim



      'Poiche questa operazione richiede parecchio tempo la eseguo su un thread a parte
      deleg = New GridLoadMaker(AddressOf LoadGrid)
      Dim t As System.Threading.Thread = New System.Threading.Thread(AddressOf LoadView)
      t.Start()

      Do While t.IsAlive
         System.Windows.Forms.Application.DoEvents()
      Loop

      t.Join()


   End Sub

   Private Sub LoadGrid()
      gridloader.LoadGrid(itemList)
   End Sub

   Private Sub LoadView()
      itemList = DirectCast(ControllerForSepThread, ControllerIncassiQuote).ListaPosizioniUtenti
      Grid.Invoke(deleg)
   End Sub


   Private Sub DisplaydataForSoggettoIF(ByVal control As ControlDocumentView, ByVal IdSoggetto As String)
      With control
         Try
            Dim controllerAziende As New AZIENDE.ControllerAziende
            controllerAziende.LoadById(IdSoggetto)
            .lblDescrizioneAzienda.Text = controllerAziende.Descrizione
            .lblCompUltimo.Text = controllerAziende.CompetenzaUltimoPagamento
            .lblContratto.Text = controllerAziende.DescrizioneContratto
            controllerAziende = Nothing
         Catch ex As Exception
            .lblDescrizioneAzienda.Text = ""
            .lblCompUltimo.Text = ""
            .lblContratto.Text = ""
         End Try
      End With
   End Sub
   Private Sub DisplayDataforSoggettoEdile(ByVal control As ControlDocumentView, ByVal DescrizioneSoggetto As String)
      With control

         Try
            Dim controllerEnti As New AZIENDE.ControllerEntiBilaterali
            controllerEnti.LoadById(controllerEnti.GetIdEnteByDescrizione(DescrizioneSoggetto))
            .lblDescrizioneAzienda.Text = controllerEnti.Descrizione
            .lblCompUltimo.Text = controllerEnti.CompetenzaUltimoPagamento
            .lblContratto.Text = ""
         Catch ex As Exception
            .lblDescrizioneAzienda.Text = ""
            .lblCompUltimo.Text = ""
            .lblContratto.Text = ""
         End Try

      End With
   End Sub
   Public Sub RefeshItemsGrid(ByVal Control As BrowserControl, ByVal controller As AbstractController) Implements IDocumentViewMediator.RefeshItemsGrid
      Dim controllerDoc As ControllerIncassiQuote = DirectCast(controller, ControllerIncassiQuote)
      Dim controlDoc As Object
      If TypeOf (Control) Is ControlDocumentView Then
         controlDoc = DirectCast(Control, ControlDocumentView)
      Else
         controlDoc = DirectCast(Control, ControlPagamentoQuoteAssociative)
      End If
      controlDoc.GridPosizioni.DataSource = controllerDoc.ListaPosizioniUtenti
      controlDoc.GridPosizioni.Refresh()
      'la inserisco qui poichè una variazione dell'importo di una posizione rivisualizza l'importo totale
      controlDoc.txtImporto.Text = controllerDoc.Importo
   End Sub
   Public Sub GetSpecificItemProperties(ByVal Control As BrowserControl, ByVal controller As AbstractController) Implements IDocumentViewMediator.GetSpecificItemProperties
      Dim frm As ControlItemContabile = DirectCast(Control, ControlItemContabile)
      Dim controllerDoc As ControllerIncassiQuote = DirectCast(controller, ControllerIncassiQuote)
      With frm
         .lblDescrizioneSogg.Text = controllerDoc.DescrizioneSoggettoEsecutore
         .lblDescrizioneUtente.Text = controllerDoc.NameUtenteItem
         .lblDescrizioneReferente.Text = controllerDoc.NameReferenteItem
         .lblDescrAzImpiego.Text = controllerDoc.DescrizioneAziendaImpiegoItem
         If controllerDoc.IsForSettoreEdile Then
            .IdAziendaTextBox1.Enabled = True
         Else
            .IdAziendaTextBox1.Enabled = False
         End If
         If controllerDoc.CongruitaItemToString = "Quota congrua" Then
            .cmdCongrua.Image = My.Resources.OK
         Else
            .cmdCongrua.Image = My.Resources.WarningHS
         End If
      End With
   End Sub
   Public Sub SetItemProperties(ByVal FrmItem As System.Windows.Forms.Form, ByVal controller As AbstractController) Implements IDocumentViewMediator.SetItemProperties
      Dim frm As FrmItemContabile = DirectCast(FrmItem, FrmItemContabile)
      Dim controllerDoc As ControllerIncassiQuote = DirectCast(controller, ControllerIncassiQuote)
      With controllerDoc
         .TredicesimaItem = frm.ControlItemContabile1.chk13.Checked
         .QuattordicesimaItem = frm.ControlItemContabile1.chk14.Checked
         .SetImportoItem(frm.ControlItemContabile1.txtImporto.Text)
         .NoteItem = frm.ControlItemContabile1.txtNote.Text
         .SetCompetenzaItem(frm.ControlItemContabile1.DataInizioCompetenza, frm.ControlItemContabile1.DataFineCompetenza)
         .SetAziendaImpiegoItem(frm.ControlItemContabile1.IdAziendaTextBox1.TextValue)
         .OreLavorateItem = frm.ControlItemContabile1.txtLav.Text
         .OreMalattiaItem = frm.ControlItemContabile1.txtMal.Text
         .LivelloInquadramentoItem = frm.ControlItemContabile1.txtLiv.Text
         .SetReferenteItem(frm.ControlItemContabile1.IdReferenteTextBox1.TextValue)
         .MarkDirtyCurrentPosition()
      End With
   End Sub
   Public Sub DefineNewItemViewLayout(ByVal Control As BrowserControl, ByVal controller As AbstractController) Implements IDocumentViewMediator.DefineNewItemViewLayout
      Dim frm As ControlItemContabile = DirectCast(Control, ControlItemContabile)
      Dim controllerDoc As ControllerIncassiQuote = DirectCast(controller, ControllerIncassiQuote)
      With frm
         .lblDescrizioneSogg.Text = controllerDoc.DescrizioneSoggettoEsecutore
         .lblDescrizioneUtente.Text = ""
         .lblDescrizioneReferente.Text = ""
         .lblDescrAzImpiego.Text = ""
         .txtSettore.Text = controllerDoc.DescrizioneSettore
         .DataInizioCompetenza = controllerDoc.DataInizioCompetenza
         .DataFineCompetenza = controllerDoc.DataFineCompetenza
         .txtCompetenza.Text = controllerDoc.Competenza
         If controllerDoc.IsForSettoreEdile Then
            .IdAziendaTextBox1.Enabled = True
            .IdAziendaTextBox1.TextValue = ""
         Else
            .IdAziendaTextBox1.Enabled = False
            .IdAziendaTextBox1.TextValue = controllerDoc.IdSoggettoEsecutore
         End If
         .DescribeAzienda()
         .cmdCongrua.Image = My.Resources.WarningHS
      End With
   End Sub
   Public Sub AddNewItem(ByVal FrmItem As System.Windows.Forms.Form, ByVal controller As AbstractController) Implements IDocumentViewMediator.AddNewItem
      Dim frm As FrmItemContabile = DirectCast(FrmItem, FrmItemContabile)
      Dim controllerDoc As ControllerIncassiQuote = DirectCast(controller, ControllerIncassiQuote)
      'DirectCast(controller, ControllerIncassiQuote).AddItem(frm.IdUtente, frm.Importo, "-1", "", False, False, frm.DataInizio, frm.DataFine)
      With frm.ControlItemContabile1
         controllerDoc.AddItem(.IdUtenteTextBox1.TextValue, .txtImporto.Text, .IdReferenteTextBox1.TextValue, .txtNote.Text, .chk13.Checked, .chk14.Checked, .DataInizioCompetenza, .DataFineCompetenza, Not My.Settings.CheckPaybility)
         controllerDoc.SelectItem(.IdUtenteTextBox1.TextValue, .DataInizioCompetenza, .DataFineCompetenza)
         Try
            If controllerDoc.IsForSettoreEdile Then
               controllerDoc.SetAziendaImpiegoItem(.IdAziendaTextBox1.TextValue)
            End If
            controllerDoc.OreLavorateItem = .txtLav.Text
            controllerDoc.OreMalattiaItem = .txtMal.Text
            controllerDoc.LivelloInquadramentoItem = .txtLiv.Text
         Catch ex As Exception
            ErrorHandler.ShowError(ex)
            frm.Close()
         End Try
      End With

   End Sub

   Public Sub ViewItemDetail(ByVal Controller As AbstractController) Implements IDocumentViewMediator.ViewItemDetail
      frm = New FrmItemContabile("View", Controller, "IQA")
      frm.ShowDialog()
      frm.Dispose()
   End Sub


   Public Sub DefineItemViewLayout(ByVal Control As BrowserControl, ByVal controller As AbstractController) Implements IDocumentViewMediator.DefineItemViewLayout
      '
   End Sub
End Class
