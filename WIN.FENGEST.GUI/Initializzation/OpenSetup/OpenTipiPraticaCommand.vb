Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY
<SecureContext()> _
Public Class OpenTipiPraticaCommand
    Inherits OpenCommand
    Private Id As Int32 = -1

    Protected Overrides Function DoCreateTargetControl() As PRESENTATION.BrowserControl
        Return New ControlTipiPratica(-1)
    End Function
    Protected Overrides Function DoCreateTargetControl(ByVal Id As Int32) As PRESENTATION.BrowserControl
        Return New ControlTipiPratica(Id)
    End Function

    Protected Overrides Function ObjectToOpenName() As String
        Return "Tipo pratica"
    End Function

    <Secure(Area:="TipiPratica", Alias:="Visualizzazione", Macroarea:="Setup")> _
    Protected Overrides Sub SetTargetControlReceviers(ByVal Control As PRESENTATION.BrowserControl)
        SecurityManager.Instance.Check()
        'Il controllo creato dal comando non è linkato a nessu altro controllo
        Control.AddLinkCommand("ViewTipoPratica", New OpenTipiPraticaCommand)
        Control.AddLinkCommand("CreateTipoPratica", New OpenNewTipoPraticaCommand)
    End Sub
End Class

