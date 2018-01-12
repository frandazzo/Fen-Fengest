Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY
<SecureContext()> _
Public Class OpenAnagraficaAziendaCommand
   Inherits OpenCommand


   Protected Overrides Function DoCreateTargetControl() As PRESENTATION.BrowserControl
      Return New ControlAnagraficaAzienda
   End Function
   Protected Overrides Function DoCreateTargetControl(ByVal Id As Int32) As PRESENTATION.BrowserControl
      'Try
      Return New ControlAnagraficaAzienda(Id)
      'Catch ex As Exception
      '   Throw New Exception(ex.Message)
      'End Try

   End Function


   <Secure(Area:="Aziende", Alias:="Visualizzazione", Macroarea:="Anagrafiche")> _
   Protected Overrides Sub SetTargetControlReceviers(ByVal Control As PRESENTATION.BrowserControl)
      'Il controllo creato dal comando non è linkato a nessu altro controllo
      SecurityManager.Instance.Check()
      Control.AddLinkCommand("ViewAzienda", New OpenAnagraficaAziendaCommand)
      Control.AddLinkCommand("CreateAzienda", New OpenNewAnagraficaAziendaCommand)
      Control.AddLinkCommand("ViewConto", New OpenAnagraficaContoCommand)
      Control.AddLinkCommand("ViewOfferte", New OpenOfferteCommand)
      Control.AddLinkCommand("ViewUtente", New OpenAnagraficaUtenteCommand)
      Control.AddLinkCommand("ViewEnte", New OpenEnteCommand)
      Control.AddLinkCommand("ViewReferente", New OpenAnagraficaReferenteCommand)
      Control.AddLinkCommand("ViewDocumento", New OpenDocumentoCommand)
      'Control.AddLinkCommand("OpenPrestazioni", New OpenPrestazioniCommand)
      'Control.AddLinkCommand("OpenVertenze", New OpenVertenzeCommand)
      Control.AddLinkCommand("OpenPrestazione", New OpenPrestazioneCommand)
      Control.AddLinkCommand("OpenVertenza", New OpenVertenzaCommand)
      Control.AddLinkCommand("ViewCompilazioneModelli", New OpenCompilazioneModelliCommand)

   End Sub
   Protected Overrides Function ObjectToOpenName() As String
      Return "Azienda"
   End Function
   Public Overloads Overrides Sub Execute(ByVal WithParameter As System.Collections.Hashtable)
      'Se richiamo questo metodo di questo comando vuol dire che  ho un id
      'e che deve essere presentato l'offetto
      Dim id As Int32
      Dim clearCache As Boolean = False
      Try
         id = WithParameter.Item("Id")
         If WithParameter.ContainsKey("ClearCache") Then
            clearCache = WithParameter.Item("ClearCache")
         End If
      Catch ex As Exception
         Throw New Exception("Impossibile eseguire il comando di apertura " & ObjectToOpenName() & " poichè non esiste un identificativo.")
      End Try
      Open(id, clearCache)
   End Sub


   Protected Overloads Sub Open(ByVal Id As Int32, ByVal ClearCache As Boolean)
      Dim control As BrowserControl = CreateTargetControl(Id, ClearCache)
      Forward(control)
   End Sub


   Protected Overloads Function CreateTargetControl(ByVal Id As Int32, ByVal ClearCache As Boolean) As BrowserControl

      MyBase.m_IdObjectToOpen = Id
      Dim control As BrowserControl = DoCreateTargetControl(Id, ClearCache)
      SetTargetControlReceviers(control)
      Return control


   End Function

   Protected Overloads Function DoCreateTargetControl(ByVal Id As Int32, ByVal ClearCache As Boolean) As PRESENTATION.BrowserControl
      Return New ControlAnagraficaAzienda(Id, ClearCache)
   End Function


End Class
