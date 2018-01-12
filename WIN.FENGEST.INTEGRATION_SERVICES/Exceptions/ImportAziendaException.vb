Public Class ImportAziendaException
   Inherits Exception
   Private m_message As String = ""
   Private m_Descrizione As String = ""
   Private m_PIva As String = ""



   Public Sub New()

   End Sub
   Public Sub New(ByVal Message As String, Optional ByVal Descrizione As String = "", Optional ByVal PIva As String = "")
      m_message = Message
      m_Descrizione = Descrizione
      m_PIva = PIva
   End Sub
   Public Overrides ReadOnly Property Message() As String
        Get

            Dim t As String = "Errore importazione azienda"
            If m_Descrizione <> "" Then
                Return t & ": " & m_Descrizione & Environment.NewLine & "       " & m_message & Environment.NewLine
            Else
                Return t & Environment.NewLine & "       " & m_message & Environment.NewLine
            End If

            'Return m_message
        End Get
   End Property
   Public ReadOnly Property Descrizione() As String
      Get
         Return m_Descrizione
      End Get
   End Property
   Public ReadOnly Property PIva() As String
      Get
         Return m_PIva
      End Get
   End Property
End Class
