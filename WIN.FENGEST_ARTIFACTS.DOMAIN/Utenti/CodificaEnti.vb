Public Class CodificaEnti

   Private m_CodificaCE As String = ""
   Private m_CodificaEC As String = ""

   Public Property CodificaEC() As String
      Get
         Return m_CodificaEC
      End Get
      Set(ByVal value As String)
         m_CodificaEC = value
      End Set
   End Property



   Public Property CodificaCE() As String
      Get
         Return m_CodificaCE
      End Get
      Set(ByVal value As String)
         m_CodificaCE = value
      End Set
   End Property


End Class
