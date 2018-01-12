Public Class Preferenza
   Inherits AbstractPersistenceObject
   Private m_Priorita As PrioritaPreferenza = PrioritaPreferenza.Media
   Private m_Data As DateTime
   Private m_Utente As Utente = New UtenteNonSpecificato
   Private m_abilita As Abilita

   Private m_Note As String = ""
   Public Property Note() As String
      Get
         Return m_Note
      End Get
      Set(ByVal value As String)
         m_Note = value
      End Set
   End Property

   Public Sub New(ByVal Utente As Utente, ByVal Abilita As Abilita, ByVal Priorita As PrioritaPreferenza, ByVal Data As DateTime)
      Me.Utente = Utente
      Me.Abilita = Abilita
      m_Priorita = Priorita
      m_Data = Data
   End Sub
   Public Sub New()

   End Sub

   Public Property Abilita() As Abilita
      Get
         Return m_abilita
      End Get
      Set(ByVal value As Abilita)
         If value Is Nothing Then Throw New ArgumentNullException("Abilità")
         m_abilita = value
      End Set
   End Property

   Public Property Utente() As Utente
      Get
         Return m_Utente
      End Get
      Set(ByVal value As Utente)
         If value Is Nothing Then Throw New ArgumentNullException("Utente")
         m_Utente = value
      End Set
   End Property

   Public Property Data() As DateTime
      Get
         Return m_Data
      End Get
      Set(ByVal value As DateTime)
         m_Data = value
      End Set
   End Property


   Public Property Priorita() As PrioritaPreferenza
      Get
         Return m_Priorita
      End Get
      Set(ByVal value As PrioritaPreferenza)
         m_Priorita = value
      End Set
   End Property


   Public Enum PrioritaPreferenza
      Alta = 1
      Media = 2
      Bassa = 3
   End Enum

   Public Overrides Function Equals(ByVal obj As Object) As Boolean
      Dim temp As Preferenza
      Try
         temp = DirectCast(obj, Preferenza)
      Catch ex As Exception
         Return False
      End Try

      If temp.Key Is Nothing Or Me.Key Is Nothing Then
         If temp.GetHashCode = Me.GetHashCode Then
            Return True
         End If
         Return False
      Else
         If temp.Key.LongValue = Me.Key.LongValue Then
            Return True
         End If
         Return False
      End If

   End Function

End Class
