Public Class Tessera
   Inherits AbstractPersistenceObject

   Private m_DataTesseramento As DateTime
   Private m_StampataDa As String

   Private m_Utente As Utente


   Public Sub New(ByVal Utente As Utente)
      m_Utente = Utente
   End Sub

   Public ReadOnly Property Utente() As Utente
      Get
         Return m_Utente
      End Get
   End Property


   Public Property StampataDa() As String
      Get
         Return m_StampataDa
      End Get
      Set(ByVal value As String)
         m_StampataDa = value
      End Set
   End Property



   Public Property DataTesseramento() As DateTime
      Get
         Return m_DataTesseramento
      End Get
      Set(ByVal value As DateTime)
         m_DataTesseramento = value
      End Set
   End Property

End Class
