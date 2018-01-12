Public Class Figlio
   Inherits AbstractPersistenceObject
   Private m_DataNascita As DateTime
   Private m_Scuola As String
   Private m_AnnoFrequenza As String
   Private m_utente As Utente



   Private m_Nome As String = ""
   Private m_Cognome As String = ""


   Private m_CodiceFiscale As String = ""
   Public Property CodiceFiscale() As String
      Get
         Return m_CodiceFiscale
      End Get
      Set(ByVal value As String)
         m_CodiceFiscale = value
      End Set
   End Property



   Public Property Cognome() As String
      Get
         Return m_Cognome
      End Get
      Set(ByVal value As String)
         m_Cognome = value
      End Set
   End Property





   Public Property Nome() As String
      Get
         Return m_Nome
      End Get
      Set(ByVal value As String)
         m_Nome = value
      End Set
   End Property


   Public ReadOnly Property Utente() As Utente
      Get
         Return m_utente
      End Get
   End Property

   Public Sub New(ByVal Utente As Utente)
      m_utente = Utente
   End Sub

   Public Property DataNascita() As DateTime
      Get
         If m_DataNascita = DateTime.MinValue Then Return DateTime.Now
         Return m_DataNascita
      End Get
      Set(ByVal value As DateTime)
         m_DataNascita = value
      End Set
   End Property

   Public Property Scuola() As String
      Get
         Return m_Scuola
      End Get
      Set(ByVal value As String)
         m_Scuola = value
      End Set
   End Property

   Public Property AnnoFrequenza() As String
      Get
         Return m_AnnoFrequenza
      End Get
      Set(ByVal value As String)
         m_AnnoFrequenza = value
      End Set
   End Property


End Class
