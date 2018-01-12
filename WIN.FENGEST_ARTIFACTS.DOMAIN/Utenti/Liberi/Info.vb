Public Class Info
   Inherits AbstractPersistenceObject
   Private m_ente As EnteBilaterale
   Private m_DataImportazione As DateTime
   Private m_LiberoAl As DateTime
   Private m_AziendaImpiego As Azienda = New AziendaNonSpecificata
   Private m_LivelloInquadramento As String
   Private m_Utente As Utente

   Private m_IscrittoA As String = ""
   Public Property IscrittoA() As String
      Get
         Return m_IscrittoA
      End Get
      Set(ByVal value As String)
         m_IscrittoA = value
      End Set
   End Property



   Public Property Utente() As Utente
      Get
         Return m_Utente
      End Get
      Set(ByVal value As Utente)
         m_Utente = value
      End Set
   End Property

   Public Property LivelloInquadramento() As String
      Get
         Return m_LivelloInquadramento
      End Get
      Set(ByVal value As String)
         m_LivelloInquadramento = value
      End Set
   End Property

   Public Property AziendaImpiego() As Azienda
      Get
         Return m_AziendaImpiego
      End Get
      Set(ByVal value As Azienda)
         m_AziendaImpiego = value
      End Set
   End Property

   Public Property Ente() As EnteBilaterale
      Get
         Return m_ente
      End Get
      Set(ByVal value As EnteBilaterale)
         m_ente = value
      End Set
   End Property

   Public Property DataImportazione() As DateTime
      Get
         Return m_DataImportazione
      End Get
      Set(ByVal value As DateTime)
         m_DataImportazione = value
      End Set
   End Property

   Public Property LiberoAl() As DateTime
      Get
         Return m_LiberoAl
      End Get
      Set(ByVal value As DateTime)
         m_LiberoAl = value
      End Set
   End Property


End Class
