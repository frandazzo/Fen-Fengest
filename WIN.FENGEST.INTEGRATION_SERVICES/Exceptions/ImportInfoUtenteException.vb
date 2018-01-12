Public Class ImportInfoUtenteException
   Inherits ImportDelegaException

   Public Sub New(ByVal Message As String, Optional ByVal Nome As String = "", Optional ByVal Cognome As String = "", Optional ByVal NomeAzienda As String = "")
      MyBase.New(Message, Nome, Cognome, NomeAzienda)
   End Sub
End Class
