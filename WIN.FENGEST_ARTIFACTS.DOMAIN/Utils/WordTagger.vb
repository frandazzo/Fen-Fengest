Public Class WordTagger
   Inherits AbstractPersistenceObject
   Private m_Campo As String
   Private m_ValoreTag As String
   Private m_NomeProprieta As String
    Private m_Tipo As TipoTag = TipoTag.Utente


   Public Property Tipo() As TipoTag
      Get
         Return m_Tipo
      End Get
      Set(ByVal value As TipoTag)
         m_Tipo = value
      End Set
   End Property

   Public Property NomeProprieta() As String
      Get
         Return m_NomeProprieta
      End Get
      Set(ByVal value As String)
         m_NomeProprieta = value
      End Set
   End Property


   Public Property Campo() As String
      Get
         Return m_Campo
      End Get
      Set(ByVal value As String)
         m_Campo = value
      End Set
   End Property

   Public Enum TipoTag
      Utente = 1
   End Enum



   Public Property ValoreTag() As String
      Get
         Return m_ValoreTag
      End Get
      Set(ByVal value As String)
         m_ValoreTag = value
      End Set
   End Property



End Class
