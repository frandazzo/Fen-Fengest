Public Class InizializzazioneGeoHandler
    Public Sub Inizializza()
        GeoLocationFacade.InitializeInstance(New GeoPersistenceService())
    End Sub
End Class
