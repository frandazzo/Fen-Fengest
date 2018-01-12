Public Class Coniuge
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

End Class
