Imports System.Windows.Forms

Public Class FrmQuoteUtente
   Private m_IdUtente As Int32


   Private WithEvents ControllerIQA As New WIN.APPLICATION.REPORTING.ReportIncassiQuote
   Private WithEvents ControllerIQI As New WIN.APPLICATION.REPORTING.ReportIncassiQuote
   Private WithEvents ControllerIQV As New WIN.APPLICATION.REPORTING.ReportIncassiQuote

   Private m_Link As String = ""
   Private m_Id As String = ""
   Private m_TipoDoc As String = ""


   Public ReadOnly Property Id() As String
      Get
         Return m_Id
      End Get
   End Property


   Public ReadOnly Property Link() As String
      Get
         Return m_Link
      End Get

   End Property

   Public ReadOnly Property TipoDoc() As String
      Get
         Return m_TipoDoc
      End Get
   End Property


   Public Sub New(ByVal IdUtente As Int32)
      InitializeComponent()
      m_IdUtente = IdUtente

      Dim iniGrid As New GridInitializerRptIQ
      iniGrid.InitializeGrid(Me.GridIQA)
      iniGrid.InitializeGrid(Me.GridIQI)
      iniGrid.InitializeGrid(Me.GridIQV)

   End Sub


   Private Sub SetSearchConditionsIQA()


        ControllerIQA.IsIQAIncluded(True)
        ControllerIQA.IsIQIIncluded(False)
        ControllerIQA.IsIQVIncluded(False)
        Me.ControlSelPeriodiMensili1.CalcolaDate()

        Dim parameterMap As New Hashtable
        parameterMap.Add("IntervalloRegistrazione", False)
        parameterMap.Add("IntervalloDocumento", False)
        parameterMap.Add("ListaSoggetti", True)
        parameterMap.Add("CompetenzaQuote", True)



        Me.ControlSelPeriodiMensili1.CalcolaDate()

        ControllerIQA.SetCompetenzaIncassiQuote(Me.ControlSelPeriodiMensili1.MinDate, Me.ControlSelPeriodiMensili1.MaxDate)
        Dim listaUtenti As New ArrayList
        listaUtenti.Add(m_IdUtente)
        ControllerIQA.SetListaUtenti(listaUtenti)
        ControllerIQA.SetSettore("")
        ControllerIQA.SetContratto("")
        ControllerIQA.SetAzienda("")
        ControllerIQA.SetEnte("")
        ControllerIQA.SetReferenteId("")
        ControllerIQA.SetInclusioneItemRistornate(REPORTING.ReportIncassiQuote.TipoInclusioneItemRistornate.Tutto)

        ControllerIQA.SetNewSerchConditions(parameterMap)



   End Sub


   Private Sub SetSearchConditionsIQI()

      ControllerIQI.IsIQAIncluded(False)
      ControllerIQI.IsIQIIncluded(True)
      ControllerIQI.IsIQVIncluded(False)
      Me.ControlSelPeriodiMensili1.CalcolaDate()

      Dim parameterMap As New Hashtable
      parameterMap.Add("IntervalloRegistrazione", False)
        parameterMap.Add("IntervalloDocumento", False)
      parameterMap.Add("ListaSoggetti", True)
        parameterMap.Add("CompetenzaQuote", True)



      Me.ControlSelPeriodiMensili1.CalcolaDate()

        ControllerIQI.SetCompetenzaIncassiQuote(Me.ControlSelPeriodiMensili1.MinDate, Me.ControlSelPeriodiMensili1.MaxDate)
      Dim listaUtenti As New ArrayList
      listaUtenti.Add(m_IdUtente)
      ControllerIQI.SetListaUtenti(listaUtenti)
      ControllerIQI.SetSettore("")
      ControllerIQI.SetContratto("")
      ControllerIQI.SetAzienda("")
      ControllerIQI.SetEnte("")
      ControllerIQI.SetReferenteId("")
      ControllerIQI.SetInclusioneItemRistornate(REPORTING.ReportIncassiQuote.TipoInclusioneItemRistornate.Tutto)

      ControllerIQI.SetNewSerchConditions(parameterMap)





   End Sub

   Private Sub SetSearchConditionsIQV()

      ControllerIQV.IsIQAIncluded(False)
      ControllerIQV.IsIQIIncluded(False)
      ControllerIQV.IsIQVIncluded(True)
      Me.ControlSelPeriodiMensili1.CalcolaDate()

      Dim parameterMap As New Hashtable
      parameterMap.Add("IntervalloRegistrazione", False)
      parameterMap.Add("IntervalloDocumento", True)
      parameterMap.Add("ListaSoggetti", True)
      parameterMap.Add("CompetenzaQuote", False)



      Me.ControlSelPeriodiMensili1.CalcolaDate()

      ControllerIQV.SetDataDocumentoRange(Me.ControlSelPeriodiMensili1.MinDate, Me.ControlSelPeriodiMensili1.MaxDate)
      Dim listaUtenti As New ArrayList
      listaUtenti.Add(m_IdUtente)
      ControllerIQV.SetListaUtenti(listaUtenti)
      ControllerIQV.SetSettore("")
      ControllerIQV.SetContratto("")
      ControllerIQV.SetAzienda("")
      ControllerIQV.SetEnte("")
      ControllerIQV.SetReferenteId("")
      ControllerIQV.SetInclusioneItemRistornate(REPORTING.ReportIncassiQuote.TipoInclusioneItemRistornate.Tutto)

      ControllerIQV.SetNewSerchConditions(parameterMap)



   End Sub


   Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
      Try
         'per prima cosa cerco la lista degli iscritti
         SetSearchConditionsIQA()
         ControllerIQA.Search()
         ControllerIQA.SortItems("DataDocumento", True)



         SetSearchConditionsIQI()
         ControllerIQI.Search()
         ControllerIQI.SortItems("DataDocumento", True)


         SetSearchConditionsIQV()
         ControllerIQV.Search()
         ControllerIQV.SortItems("DataDocumento", True)


         LoadGrids()

         Me.Invalidate()

      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub


   Private Sub LoadGrids()
      'Dim gridLoaderIQA As New GridLoaderRptIQ(Me.GridIQA)
      'gridLoaderIQA.LoadGrid(ControllerIQA.SearchResult)

      LoadGrid(Me.GridIQA, ControllerIQA.SearchResult)
      LoadGrid(Me.GridIQI, ControllerIQI.SearchResult)
      LoadGrid(Me.GridIQV, ControllerIQV.SearchResult)

      'Dim gridLoaderIQI As New GridLoaderRptIQ(Me.GridIQI)
      'gridLoaderIQI.LoadGrid(ControllerIQI.SearchResult)

      'Dim gridLoaderIQV As New GridLoaderRptIQ(Me.GridIQV)
      'gridLoaderIQV.LoadGrid(ControllerIQV.SearchResult)

   End Sub


   Private Sub LoadGrid(ByVal Grid As DataGridView, ByVal dataSource As IList)
      If Grid.DataSource Is Nothing Then
         Grid.DataSource = dataSource
         Return
      End If

      Grid.DataSource = Nothing
      Grid.DataSource = dataSource
   End Sub


   Private Sub GridIQA_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridIQA.CellDoubleClick
      If e.RowIndex = -1 Or e.ColumnIndex = -1 Then
         Return
      End If
      If GridIQA.SelectedCells.Count = 0 Then Return
      If GridIQA.SelectedCells.Count > 1 Then Return
      Try
         Select Case GridIQA.Columns(e.ColumnIndex).Name

            Case "Utente"
               Navigate(GridIQA.Rows(e.RowIndex).DataBoundItem.IdUtente, "ViewUtente")
            Case "Prestazione"
               Navigate(GridIQA.SelectedCells(0).Value, "ViewPrestazione")
            Case "Vertenza"
               Navigate(GridIQA.SelectedCells(0).Value, "ViewVertenza")
            Case "SoggettoEsecutore"
               If GridIQA.Rows(e.RowIndex).Cells("Settore").Value = "EDILE" Then
                  Navigate(GridIQA.Rows(e.RowIndex).DataBoundItem.IdSoggettoEsecutore, "ViewEnte")
               Else
                  Navigate(GridIQA.Rows(e.RowIndex).DataBoundItem.IdSoggettoEsecutore, "ViewAzienda")
               End If
            Case "AziendaImpiego"
               Navigate(GridIQA.Rows(e.RowIndex).DataBoundItem.IdAziendaImpiego, "ViewAzienda")
            Case "Referente"
               Navigate(GridIQA.Rows(e.RowIndex).DataBoundItem.IdReferente, "ViewReferente")
            Case "DocumentoPadre"
               Dim TipoDoc As String = GridIQA.Rows(e.RowIndex).Cells("TipoDocumento").Value
               Navigate(GridIQA.SelectedCells(0).Value, TipoDoc, "ViewDocumento")
            Case "PagamentoReferente"
               Dim TipoDoc As String = "PGR"
               Navigate(GridIQA.SelectedCells(0).Value, TipoDoc, "ViewDocumento")
         End Select


      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Private Sub GridIQV_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridIQV.CellDoubleClick
      If e.RowIndex = -1 Or e.ColumnIndex = -1 Then
         Return
      End If
      If GridIQV.SelectedCells.Count = 0 Then Return
      If GridIQV.SelectedCells.Count > 1 Then Return
      Try
         Select Case GridIQV.Columns(e.ColumnIndex).Name

            Case "Utente"
               Navigate(GridIQV.Rows(e.RowIndex).DataBoundItem.IdUtente, "ViewUtente")
            Case "Vertenza"
               Navigate(GridIQI.Rows(e.RowIndex).DataBoundItem.IdVertenza, "ViewVertenza")
              
           
            Case "Referente"
               Navigate(GridIQV.Rows(e.RowIndex).DataBoundItem.IdReferente, "ViewReferente")
            Case "DocumentoPadre"
               Dim TipoDoc As String = GridIQV.Rows(e.RowIndex).Cells("TipoDocumento").Value
               Navigate(GridIQV.SelectedCells(0).Value, TipoDoc, "ViewDocumento")
            Case "PagamentoReferente"
               Dim TipoDoc As String = "PGR"
               Navigate(GridIQV.SelectedCells(0).Value, TipoDoc, "ViewDocumento")
         End Select

      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub




   Private Sub GridIQI_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridIQI.CellDoubleClick
      If e.RowIndex = -1 Or e.ColumnIndex = -1 Then
         Return
      End If
      If GridIQI.SelectedCells.Count = 0 Then Return
      If GridIQI.SelectedCells.Count > 1 Then Return
      Try
         Select Case GridIQI.Columns(e.ColumnIndex).Name

            Case "Utente"
               Navigate(GridIQI.Rows(e.RowIndex).DataBoundItem.IdUtente, "ViewUtente")
            Case "IdPrestazione"
               Navigate(GridIQI.Rows(e.RowIndex).DataBoundItem.IdPrestazione, "ViewPrestazione")
        
          
            Case "SoggettoEsecutore"
               Navigate(GridIQI.Rows(e.RowIndex).DataBoundItem.IdSoggettoEsecutore, "ViewAzienda")
            Case "Referente"
               Navigate(GridIQI.Rows(e.RowIndex).DataBoundItem.IdReferente, "ViewReferente")
            Case "DocumentoPadre"
               Dim TipoDoc As String = GridIQI.Rows(e.RowIndex).Cells("TipoDocumento").Value
               Navigate(GridIQI.SelectedCells(0).Value, TipoDoc, "ViewDocumento")
            Case "PagamentoReferente"
               Dim TipoDoc As String = "PGR"
               Navigate(GridIQI.SelectedCells(0).Value, TipoDoc, "ViewDocumento")
         End Select


      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub


   Private Overloads Sub Navigate(ByVal id As String, ByVal link As String)
      m_Id = id
      m_Link = link
      Me.DialogResult = Windows.Forms.DialogResult.OK
      Me.Close()

   End Sub

   Private Overloads Sub Navigate(ByVal id As String, ByVal Tipodoc As String, ByVal link As String)
      m_TipoDoc = Tipodoc
      m_Id = id
      m_Link = link
      Me.DialogResult = Windows.Forms.DialogResult.OK
      Me.Close()
   End Sub

   'Private Sub GridIQA_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles GridIQA.CellFormatting
   '   If GridIQA.Columns(e.ColumnIndex).Name.Equals("Utente") Then
   '      If Not e.Value Is Nothing Then
   '         e.Value = e.Value.ToString
   '      End If
   '   End If


   '   If GridIQA.Columns(e.ColumnIndex).Name.Equals("TipoPrestazione") Then
   '      If Not e.Value Is Nothing Then
   '         e.Value = e.Value.ToString
   '      End If
   '   End If

   'End Sub

   'Private Sub GridIQI_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles GridIQI.CellFormatting
   '   If GridIQI.Columns(e.ColumnIndex).Name.Equals("Utente") Then
   '      If Not e.Value Is Nothing Then
   '         e.Value = e.Value.ToString
   '      End If
   '   End If
   '   If GridIQI.Columns(e.ColumnIndex).Name.Equals("TipoPrestazione") Then
   '      If Not e.Value Is Nothing Then
   '         e.Value = e.Value.ToString
   '      End If
   '   End If
   '   If GridIQI.Columns(e.ColumnIndex).Name.Equals("Prestazione") Then
   '      If Not e.Value Is Nothing Then
   '         e.Value = e.Value.ToString
   '         'End If
   '      End If
   '   End If

   'End Sub

   'Private Sub GridIQV_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles GridIQV.CellFormatting
   '   If GridIQV.Columns(e.ColumnIndex).Name.Equals("Utente") Then
   '      If Not e.Value Is Nothing Then
   '         e.Value = e.Value.ToString
   '      End If
   '   End If
   '   If GridIQV.Columns(e.ColumnIndex).Name.Equals("TipoPrestazione") Then
   '      If Not e.Value Is Nothing Then
   '         e.Value = e.Value.ToString
   '      End If
   '   End If

   '   If GridIQV.Columns(e.ColumnIndex).Name.Equals("Vertenza") Then
   '      If Not e.Value Is Nothing Then
   '         e.Value = e.Value.ToString
   '      End If

   '   End If
   'End Sub

   
End Class