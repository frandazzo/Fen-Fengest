Public Class LazyLoadReferente
   Implements IReferente

   Private Source As IReferente = New ReferenteNullo
   Private m_Id As Int32 = -1
   Private Loader As MapperReferente = PersistenceMapperRegistry.Instance.GetMapperByName("MapperReferente")

   Public Sub New(ByVal IdReferente As Int32)
      m_Id = IdReferente
   End Sub
   Private Function GetReferente() As IReferente
      If TypeOf (Source) Is ReferenteNullo Then
         Source = Loader.FindObjectById(m_Id)
         If Source Is Nothing Then Throw New Exception("Impossibile ottenere attraverso la materializzazione pigra il referente con Id =" & m_Id & ". Riferimento nullo.")
      End If
      Return Source
   End Function
   Public ReadOnly Property IdReferente() As Integer Implements DOMAIN.INTERFACES.IReferente.IdReferente
      Get
         Return GetReferente.IdReferente
      End Get
   End Property
   Public Property Conto() As IConto Implements IReferente.Conto
      Get
         Return GetReferente.Conto
      End Get
      Set(ByVal value As IConto)
         GetReferente.Conto = value
      End Set
   End Property

   Public Property Cognome() As String Implements BASEREUSE.IPersona.Cognome
      Get
         Return GetReferente.Cognome
      End Get
      Set(ByVal value As String)
         GetReferente.Cognome = value
      End Set
   End Property

   Public ReadOnly Property CompleteName() As String Implements BASEREUSE.IPersona.CompleteName
      Get
         Return GetReferente.CompleteName
      End Get
   End Property

   Public Property Nome() As String Implements BASEREUSE.IPersona.Nome
      Get
         Return GetReferente.Nome
      End Get
      Set(ByVal value As String)
         GetReferente.Nome = value
      End Set
   End Property

   Public Property UltimoRistorno() As BASEREUSE.IDocumento Implements DOMAIN.INTERFACES.IReferente.UltimoRistorno
      Get
         Return GetReferente.UltimoRistorno
      End Get
      Set(ByVal value As BASEREUSE.IDocumento)
         GetReferente.UltimoRistorno = value
      End Set
   End Property
End Class
