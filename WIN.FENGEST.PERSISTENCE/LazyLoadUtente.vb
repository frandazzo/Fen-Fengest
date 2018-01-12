Public Class LazyLoadUtente
   Implements IUtente


   Private Source As IUtente = New UtenteNonSpecificato
   Private m_Id As Int32 = -1
   Private Loader As MapperUtente = PersistenceMapperRegistry.Instance.GetMapperByName("MapperUtente")
   Private m_conto As IConto

   Public Sub New(ByVal IdUtente As Int32)
      m_Id = IdUtente
   End Sub
   Private Function GetUtente() As IUtente
      If TypeOf (Source) Is UtenteNonSpecificato Then
         Source = Loader.FindObjectById(m_Id)
         If Source Is Nothing Then Throw New Exception("Impossibile ottenere attraverso la materializzazione pigra l'utente con Id =" & m_Id & ". Riferimento nullo.")
      End If
      Return Source
   End Function

   Public Property Cognome() As String Implements BASEREUSE.IPersona.Cognome
      Get
         Return GetUtente.Cognome
      End Get
      Set(ByVal value As String)
         GetUtente.Cognome = value
      End Set
   End Property

   Public ReadOnly Property CompleteName() As String Implements BASEREUSE.IPersona.CompleteName
      Get
         Return GetUtente.CompleteName
      End Get
   End Property


   Public Function PossiedeTessera(ByVal anno As Int32) Implements IUtente.PossiedeTessera

      Return GetUtente.PossiedeTessera(anno)

   End Function

   Public Property Nome() As String Implements BASEREUSE.IPersona.Nome
      Get
         Return GetUtente.Nome
      End Get
      Set(ByVal value As String)
         GetUtente.Nome = value
      End Set
   End Property

   Public Function ActivateDelega(ByVal PerSoggetto As BASEREUSE.AbstractAzienda, ByVal ConDocumento As BASEREUSE.IDocumento) As Boolean Implements DOMAIN.INTERFACES.IUtente.ActivateDelega
      Return GetUtente.ActivateDelega(PerSoggetto, ConDocumento)
   End Function

   Public Sub AddDelega(ByVal Delega As DOMAIN.INTERFACES.IDelega) Implements DOMAIN.INTERFACES.IUtente.AddDelega
      GetUtente.AddDelega(Delega)
   End Sub

   Public Sub AnnullaDelegheEccetto(ByVal Delega As DOMAIN.INTERFACES.IDelega) Implements DOMAIN.INTERFACES.IUtente.AnnullaDeleghePerSoggetto
      GetUtente.AnnullaDeleghePerSoggetto(Delega)
   End Sub

   Public Sub ChangeSedeOperativa(ByVal PerSoggetto As BASEREUSE.AbstractAzienda, ByVal AllaData As Date, ByVal Sede As DOMAIN.INTERFACES.ISedeOperativa) Implements DOMAIN.INTERFACES.IUtente.ChangeSedeOperativa
      GetUtente.ChangeSedeOperativa(PerSoggetto, AllaData, Sede)
   End Sub

   Public Function CheckExistenceActiveDelegaFor(ByVal Ente As BASEREUSE.AbstractAzienda) As Boolean Implements DOMAIN.INTERFACES.IUtente.CheckExistenceActiveDelegaFor
      Return GetUtente.CheckExistenceActiveDelegaFor(Ente)
   End Function

   Public Sub CheckPaybility(ByVal PosizioneDiPagamento As DOMAIN.INTERFACES.IPayble, ByVal SoggettoEsecutore As BASEREUSE.AbstractAzienda) Implements DOMAIN.INTERFACES.IUtente.CheckPaybility
      GetUtente.CheckPaybility(PosizioneDiPagamento, SoggettoEsecutore)
   End Sub

   Public Property Conto() As DOMAIN.INTERFACES.IConto Implements DOMAIN.INTERFACES.IUtente.Conto
      Get
         If m_conto Is Nothing Then
            Dim map As MapperConto = PersistenceMapperRegistry.Instance.GetMapperByName("MapperConto")
            'Creo il conto per gli utenti senza effettivamente caricare l'utente reale
            m_conto = map.FindObjectById(2)
         End If
         Return m_conto
      End Get
      Set(ByVal value As DOMAIN.INTERFACES.IConto)
         GetUtente.Conto = value
      End Set
   End Property

   Public ReadOnly Property Deleghe() As TECHNICAL.PERSISTENCE.VirtualLazyList Implements DOMAIN.INTERFACES.IUtente.Deleghe
      Get
         Return GetUtente.Deleghe
      End Get
   End Property

   Public Function GetActiveDelegaFor(ByVal SoggettoEsecutore As BASEREUSE.AbstractAzienda) As DOMAIN.INTERFACES.IDelega Implements DOMAIN.INTERFACES.IUtente.GetActiveDelegaFor
      Return GetUtente.GetActiveDelegaFor(SoggettoEsecutore)
   End Function

   Public Function GetActiveDelegaFor(ByVal SoggettoEsecutore As BASEREUSE.AbstractAzienda, ByVal AtDate As Date) As DOMAIN.INTERFACES.IDelega Implements DOMAIN.INTERFACES.IUtente.GetActiveDelegaFor
      Return GetUtente.GetActiveDelegaFor(SoggettoEsecutore, AtDate)
   End Function

   Public Function GetDelegaById(ByVal IdDelega As Integer) As DOMAIN.INTERFACES.IDelega Implements DOMAIN.INTERFACES.IUtente.GetDelegaById
      Return GetUtente.GetDelegaById(IdDelega)
   End Function

   Public Function HaAttivatoDelega() As Boolean Implements DOMAIN.INTERFACES.IUtente.HaAttivatoDelega
      Return GetUtente.HaAttivatoDelega
   End Function

   Public Function HaCambiatoSede() As Boolean Implements DOMAIN.INTERFACES.IUtente.HaCambiatoSede
      Return GetUtente.HaCambiatoSede
   End Function

   Public ReadOnly Property IdUtente() As Integer Implements DOMAIN.INTERFACES.IUtente.IdUtente
      Get
         Return GetUtente.IdUtente
      End Get
   End Property

   Public Property QuotaMensile() As BASEREUSE.Moneta Implements DOMAIN.INTERFACES.IUtente.QuotaMensile
      Get
         'Return GetUtente.QuotaMensile
         Return New Moneta(0, Moneta.Valuta.Euro)
      End Get
      Set(ByVal value As BASEREUSE.Moneta)
         GetUtente.QuotaMensile = value
      End Set
   End Property

   Public Sub RipristinaStatoPrecedenteAccettazione(ByVal Delega As DOMAIN.INTERFACES.IDelega) Implements DOMAIN.INTERFACES.IUtente.RipristinaStatoPrecedenteAccettazione
      GetUtente.RipristinaStatoPrecedenteAccettazione(Delega)
   End Sub

   Public Sub SetDeleghe(ByVal List As TECHNICAL.PERSISTENCE.VirtualLazyList) Implements DOMAIN.INTERFACES.IUtente.SetDeleghe
      GetUtente.SetDeleghe(List)
   End Sub

   Public Overrides Function ToString() As String Implements DOMAIN.INTERFACES.IUtente.ToString
      Return GetUtente.CompleteName
   End Function
End Class
