Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY
'<SecureContext()> _
Public Class OpenComunicazioneMassivaCommand
    Inherits OpenCommand

    '  <Secure(Area:="Comunicazioni", Alias:="Comunicazioni massive", Macroarea:="Comunicazioni")> _
    Protected Overrides Function DoCreateTargetControl() As PRESENTATION.BrowserControl
        SecurityManager.Instance.Check()
        Return New ControlComunicazioneMassiva
    End Function
    Protected Overrides Function DoCreateTargetControl(ByVal Id As Int32) As PRESENTATION.BrowserControl
        Return New ControlComunicazioneMassiva
    End Function

    Protected Overrides Function ObjectToOpenName() As String
        Return "Comunicazione massiva"
    End Function

    Protected Overrides Sub SetTargetControlReceviers(ByVal Control As PRESENTATION.BrowserControl)
        'Il controllo creato dal comando non è linkato a nessu altro controllo

        Control.AddLinkCommand("ViewListaLavoro", New OpenListaLivoroCommand)



    End Sub


End Class
