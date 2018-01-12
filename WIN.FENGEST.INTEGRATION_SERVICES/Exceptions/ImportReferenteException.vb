Public Class ImportReferenteException
   Inherits Exception
   Private m_message As String = ""
   Private m_Cognome As String = ""




   Public Sub New()

   End Sub
   Public Sub New(ByVal Message As String, Optional ByVal Cognome As String = "")
      m_message = Message
      m_Cognome = Cognome
   End Sub
   Public Overrides ReadOnly Property Message() As String
      Get
         Return m_message
      End Get
   End Property
   Public ReadOnly Property Cognome() As String
      Get
         Return m_Cognome
      End Get
   End Property

End Class
