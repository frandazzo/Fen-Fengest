Public Class OpenReportSaldiContoCommand
   Inherits OpenCommand

   Protected Overrides Function DoCreateTargetControl() As PRESENTATION.BrowserControl
      Return New ControlSaldoConto
   End Function
   Protected Overrides Function DoCreateTargetControl(ByVal Id As Int32) As PRESENTATION.BrowserControl
      Return New ControlSaldoConto
   End Function

   Protected Overrides Function ObjectToOpenName() As String
      Return "Report saldi conto"
   End Function



End Class
