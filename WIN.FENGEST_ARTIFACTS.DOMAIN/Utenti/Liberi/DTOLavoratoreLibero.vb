Public Class DTOLavoratoreLibero
   inherits  AbstractPersistenceObject
   Private m_utente As Utente
   Private m_azienda As Azienda
   Private m_liberoal As DateTime

   Public Sub New(ByVal Utente As Utente, ByVal LiberoAl As DateTime, ByVal Azienda As Azienda)
      m_utente = Utente
      m_liberoal = LiberoAl
      m_azienda = Azienda
   End Sub

   Public ReadOnly Property Utente() As Utente
      Get
         Return m_utente
      End Get
   End Property

   Public ReadOnly Property IdUtente() As String
      Get
         Return m_utente.Id
      End Get
   End Property

   Public ReadOnly Property Azienda() As Azienda
      Get
         Return m_azienda
      End Get
   End Property

   Public ReadOnly Property CodiceFiscale() As String
      Get
         Return m_utente.CodiceFiscale
      End Get
   End Property


   Public ReadOnly Property DataNascita() As DateTime
      Get
         Return m_utente.DataNascita
      End Get
   End Property


   Public ReadOnly Property CompleteName() As String
      Get
         Return m_utente.CompleteName
      End Get
   End Property


   Public ReadOnly Property NomeAzienda() As String
      Get
         Return m_azienda.Descrizione
      End Get
   End Property



   Public ReadOnly Property LiberoAl() As DateTime
      Get
         Return m_liberoal
      End Get
   End Property

End Class
