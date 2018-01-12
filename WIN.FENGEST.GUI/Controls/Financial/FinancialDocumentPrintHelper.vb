Public Class FinancialDocumentPrintHelper

   Public Sub PrintDocument(ByVal IdDocumento As String, ByVal TipoDocumento As String)
      Dim c As WIN.APPLICATION.REPORTING.ReportIncassiQuote = SearchDocumento(IdDocumento, TipoDocumento)



      Dim print As PrintFacade = New PrintFacade
      print.PrintReportIncassiQuote(c)

   End Sub



   Private Function SearchDocumento(ByVal IdDocumento As String, ByVal TipoDocumento As String) As WIN.APPLICATION.REPORTING.ReportIncassiQuote

      Dim Controller As New WIN.APPLICATION.REPORTING.ReportIncassiQuote

        Select Case TipoDocumento
            Case "IQA"
                Controller.IsIQAIncluded(True)
                Controller.SetDocumento(IdDocumento)
            Case "IQP"
                Controller.IsIQPIncluded(True)
                Controller.SetDocumento(IdDocumento)
            Case "IQI"
                Controller.IsIQIIncluded(True)
                Controller.SetDocumento(IdDocumento)
            Case "IQV"
                Controller.IsIQVIncluded(True)
                Controller.SetDocumento(IdDocumento)
            Case "PGR"
                Controller.IsIQAIncluded(True)
                Controller.IsIQIIncluded(True)
                Controller.IsIQVIncluded(True)
                Controller.SetDocumentoRistorno(IdDocumento)
        End Select
        Controller.Search()
        Return Controller

    End Function


End Class
