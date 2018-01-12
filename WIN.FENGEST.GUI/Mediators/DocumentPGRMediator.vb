Imports WIN.APPLICATION.FINANCIAL_ARTIFACTS
Imports WIN.APPLICATION.AZIENDE
Imports WIN.APPLICATION
Imports System.Windows.Forms
Public Class DocumentPGRMediator
   Implements IDocumentViewMediator

   Public Event DocChanged()

   Public Sub AddNewItem(ByVal FrmItem As System.Windows.Forms.Form, ByVal controller As AbstractController) Implements IDocumentViewMediator.AddNewItem
      '
   End Sub
   Public Sub DefineLayout(ByVal Control As BrowserControl, ByVal DocumentType As String) Implements IDocumentViewMediator.DefineDocumentViewLayout
      Dim controlDoc As ControlDocumentView = DirectCast(Control, ControlDocumentView)
      With controlDoc
         Dim i As Integer = 20
         .GrpSogg.Visible = False
         .GrpRef.Visible = True
         .cmdCompetenza.Visible = False
         .txtCompetenza.Visible = False
         .lblCompetenza.Visible = False
         .txtSettore.Visible = False
         .lblSettore.Visible = False
         .lblRef.Visible = True
         .txtReferente.Visible = True
         .txtNote.Height = .txtNote.Height - 20
         .GroupBox1.Size = New System.Drawing.Size(.GroupBox1.Size.Width, .GroupBox1.Size.Height - i)
         .SetNomeTipoDocumento("Pagamento referenti")
         .Panel1.Location = New System.Drawing.Point(.Panel1.Location.X, .Panel1.Location.Y - i)
         '.cmdUp.Location = New System.Drawing.Point(.cmdUp.Location.X, .cmdUp.Location.Y + 5)
         '.CmdDown.Location = New System.Drawing.Point(.cmdUp.Location.X, .CmdDown.Location.Y + 5)
         '.cmdAdd.Location = New System.Drawing.Point(.cmdUp.Location.X, .cmdAdd.Location.Y + 5)
         '.cmdDel.Location = New System.Drawing.Point(.cmdUp.Location.X, .cmdDel.Location.Y + 5)
         .GridPosizioni.Location = New System.Drawing.Point(.GridPosizioni.Location.X, .GridPosizioni.Location.Y - i)
         .GridPosizioni.Size = New System.Drawing.Size(.GridPosizioni.Size.Width, .GridPosizioni.Size.Height + i)
      End With

   End Sub
   Public Sub GetSpecificDocumentProperties(ByVal Control As BrowserControl, ByVal Controller As AbstractController) Implements IDocumentViewMediator.GetSpecificDocumentProperties
      Dim controllerDoc As ControllerPagamentoReferenti = DirectCast(Controller, ControllerPagamentoReferenti)
      Dim controlDoc As ControlDocumentView = DirectCast(Control, ControlDocumentView)
      Dim gridloader As AbstractGridLoader = GridLoaderDocumentFactory.GetGridDocumentLoader("PGR", controlDoc.GridPosizioni)
      gridloader.SelectionMode = DataGridViewSelectionMode.FullRowSelect
      controllerDoc.CreateListaDto()
      gridloader.LoadGrid(controllerDoc.ListaDTOPosizioni)
      controlDoc.txtImporto.Text = controllerDoc.Importo
      controlDoc.txtReferente.Text = controllerDoc.IdReferente
      controlDoc.lblReferente.Text = controllerDoc.NameReferente
   End Sub
   Public Sub RefeshItemsGrid(ByVal Control As BrowserControl, ByVal controller As AbstractController) Implements IDocumentViewMediator.RefeshItemsGrid
      Dim controllerDoc As ControllerPagamentoReferenti = DirectCast(controller, ControllerPagamentoReferenti)
      Dim controlDoc As Object
      If TypeOf (Control) Is ControlDocumentView Then
         controlDoc = DirectCast(Control, ControlDocumentView)
      Else
         controlDoc = DirectCast(Control, ControlPagamentoQuoteAssociative)
      End If
      controlDoc.GridPosizioni.DataSource = New ArrayList
      controlDoc.GridPosizioni.DataSource = controllerDoc.ListaDTOPosizioni
      controlDoc.GridPosizioni.Refresh()
      'la inserisco qui poichè una variazione dell'importo di una posizione rivisualizza l'importo totale
      controlDoc.txtImporto.Text = controllerDoc.Importo
   End Sub
   Public Sub GetSpecificItemProperties(ByVal Control As BrowserControl, ByVal controller As AbstractController) Implements IDocumentViewMediator.GetSpecificItemProperties
      Dim frm As ControlItemContabile = DirectCast(Control, ControlItemContabile)
      frm.chk13.Enabled = False
      frm.chk14.Enabled = False
   End Sub
   Public Sub SetItemProperties(ByVal FrmItem As System.Windows.Forms.Form, ByVal controller As AbstractController) Implements IDocumentViewMediator.SetItemProperties
      Dim frm As FrmItemContabile = DirectCast(FrmItem, FrmItemContabile)
      Dim controllerDoc As ControllerPagamentoReferenti = DirectCast(controller, ControllerPagamentoReferenti)
      With controllerDoc
         .SetImportoItem(frm.ControlItemContabile1.txtImportoRist.Text)
      End With
   End Sub
   Public Sub DefineNewItemViewLayout(ByVal Control As BrowserControl, ByVal controller As AbstractController) Implements IDocumentViewMediator.DefineNewItemViewLayout

   End Sub







   ''' <summary>
   ''' Obsoleta
   ''' </summary>
   ''' <param name="Controller"></param>
   ''' <remarks></remarks>
   Public Sub ViewItemDetail(ByVal Controller As AbstractController) Implements IDocumentViewMediator.ViewItemDetail

   End Sub
   Public Sub DefineItemViewLayout(ByVal Control As BrowserControl, ByVal controller As AbstractController) Implements IDocumentViewMediator.DefineItemViewLayout
      Dim frm As ControlItemContabile = DirectCast(Control, ControlItemContabile)
      'Dim controllerDoc As ControllerIncassiQuote = DirectCast(controller, ControllerIncassiQuote)
      With frm
         .IdAziendaTextBox1.Enabled = False
         .IdUtenteTextBox1.Enabled = False
         .IdReferenteTextBox1.Enabled = False
         .txtImporto.Enabled = False
         .txtImportoRist.Enabled = True
         .cmdCompetenza.Enabled = False
         .txtNote.Enabled = False
         .txtLav.Enabled = False
         .txtLiv.Enabled = False
         .txtMal.Enabled = False
      End With
   End Sub
End Class
