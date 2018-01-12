Public Class PrestazioneDTO
   Inherits AbstractPersistenceObject


   Private m_Utente As String = ""
   Private m_IdUtente As String = ""


   Private m_Referente As String = ""
   Private m_IdReferente As String = ""

   Private m_TipoPrestazione As String = ""

   Private m_dataRegistrazione As DateTime
   Private m_dataDocumento As DateTime
   Private m_note As String = ""

   Public Property Note() As String
      Get
         Return m_note
      End Get
      Set(ByVal value As String)
         m_note = value
      End Set
   End Property

   Public Property DataDocumento() As DateTime
      Get
         Return m_dataDocumento
      End Get
      Set(ByVal value As DateTime)
         m_dataDocumento = value
      End Set
   End Property



   Public Property DataRegistrazione() As DateTime
      Get
         Return m_dataRegistrazione
      End Get
      Set(ByVal value As DateTime)
         m_dataRegistrazione = value
      End Set
   End Property
  

   Public Property TipoPrestazione() As String
      Get
         Return m_TipoPrestazione
      End Get
      Set(ByVal value As String)
         m_TipoPrestazione = value
      End Set
   End Property
   Public Property Utente() As String
      Get
         Return m_Utente
      End Get
      Set(ByVal value As String)
         m_Utente = value
      End Set
   End Property

   Public Property IdUtente() As String
      Get
         Return m_IdUtente
      End Get
      Set(ByVal value As String)
         m_IdUtente = value
      End Set
   End Property

   Public Property Referente() As String
      Get
         Return m_Referente
      End Get
      Set(ByVal value As String)
         m_Referente = value
      End Set
   End Property

   Public Property IdReferente() As String
      Get
         Return m_IdReferente
      End Get
      Set(ByVal value As String)
         m_IdReferente = value
      End Set
   End Property


End Class
