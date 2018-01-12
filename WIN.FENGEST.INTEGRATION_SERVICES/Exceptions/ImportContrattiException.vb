Public Class ImportContrattiException
   Inherits Exception
   Private m_message As String = ""
   Private m_Descrizione As String = ""
   Private m_Settore As String = ""

   Public Sub New()

   End Sub
   Public Sub New(ByVal Message As String, Optional ByVal Descrizione As String = "", Optional ByVal Settore As String = "")
      m_message = Message
      m_Descrizione = Descrizione
      m_Settore = Settore
   End Sub
   Public Overrides ReadOnly Property Message() As String
      Get
         Return m_message
      End Get
   End Property
   Public ReadOnly Property Descrizione() As String
      Get
         Return m_Descrizione
      End Get
   End Property
   Public ReadOnly Property Settore() As String
      Get
         Return m_Settore
      End Get
   End Property
End Class
