Public Class OpenHomePageCommand
   Inherits OpenCommand

  
   Protected Overrides Function DoCreateTargetControl() As PRESENTATION.BrowserControl
      Return New ControlHomePage
   End Function
   Protected Overrides Function DoCreateTargetControl(ByVal Id As Int32) As PRESENTATION.BrowserControl
      Return New ControlHomePage
   End Function

   Protected Overrides Function ObjectToOpenName() As String
      Return "Home page"
   End Function



End Class
