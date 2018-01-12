Public Class ImportException
   Inherits Exception
   Private m_message As String
   Public Sub New()

   End Sub
   Public Sub New(ByVal Message As String)
      m_message = Message
   End Sub
   Public Overrides ReadOnly Property Message() As String
      Get
         Return m_message
      End Get
   End Property
End Class
