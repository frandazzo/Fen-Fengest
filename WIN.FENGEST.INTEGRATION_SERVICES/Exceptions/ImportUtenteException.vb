Public Class ImportUtenteException
   Inherits Exception
   Private m_message As String = ""
   Private m_Nome As String = ""
   Private m_Cognome As String = ""
   Private m_DataNascita As String = ""


   Public Sub New()

   End Sub
   Public Sub New(ByVal Message As String, Optional ByVal Nome As String = "", Optional ByVal Cognome As String = "", Optional ByVal DataNascita As String = "")
      m_message = Message
      m_Nome = Nome
      m_Cognome = Cognome
      m_DataNascita = DataNascita
   End Sub
   Public ReadOnly Property Nome() As String
      Get
         Return m_Nome
      End Get
   End Property
   Public ReadOnly Property Cognome() As String
      Get
         Return m_Cognome
      End Get
   End Property
   Public ReadOnly Property DataNascita() As String
      Get
         Return m_DataNascita
      End Get
   End Property
   Public Overrides ReadOnly Property Message() As String
        Get
            Dim t As String = "Errore importazione utente"
            If m_Cognome <> "" Then
                Return t & ": " & m_Cognome & " " & m_Nome & "(" & m_DataNascita & ")" & Environment.NewLine & "       " & m_message & Environment.NewLine
            Else
                Return t & Environment.NewLine & "       " & m_message & Environment.NewLine
            End If
            Return m_message
        End Get
   End Property
End Class
