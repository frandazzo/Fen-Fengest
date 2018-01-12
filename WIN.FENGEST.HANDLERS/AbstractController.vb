Public MustInherit Class AbstractController
   ''' <summary>
   ''' Proprietà che contiene la lista degli oggetti caricati
   ''' </summary>
   ''' <remarks></remarks>
   Protected DomainObjectList As New ArrayList
   ''' <summary>
   ''' Proprietà che contiene l'oggetto correntemente gestito
   ''' </summary>
   ''' <remarks></remarks>
   Protected m_current As AbstractPersistenceObject
   ''' <summary>
   ''' Proprietà che offre il servizio di persistenza già inizializzato
   ''' </summary>
   ''' <remarks></remarks>
   Protected Ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade


   Public ReadOnly Property LoadedObjects() As IList
      Get
         Return DomainObjectList
      End Get

   End Property


#Region "Metodi di inserimento e aggiornamento"
   Public MustOverride Sub CreateNew()
   ''' <summary>
   ''' Metodo sovrascrivibile che esegue il commit sull'oggetto controllato. Esso verifica se l'oggetto corrente è nullo.
   ''' Se lo è solleva un'eccezione altrimenti tenta di capire se si deve eseguire l'inserimento dell'oggetto
   ''' corrente oppure un aggiornamento tramite la verifica dell'esistenza di una chiave univoca.
   ''' A seconda del risultato della verifica richama il metodo hook per l'inserimento o per l'aggiornamento.
   ''' </summary>
   ''' <remarks></remarks>
   Public Overridable Sub Save()

      If m_current Is Nothing Then Throw New Exception("Impossibile salvare. Non è stato ancora creato alcun oggetto")
      If m_current.Key Is Nothing Then
         DoSave()
      Else
         DoUpdate()
      End If

   End Sub
   ''' <summary>
   ''' Metodo hook sovrascrivibile che esegue operazioni  per portare a termine l'inserimento di un oggetto.
   ''' Di default richiede l'inseriemnto dell'oggetto al servizio di persistenza.
   ''' </summary>
   ''' <remarks></remarks>
   Protected Overridable Sub DoSave()

      'RegistratoreElementi.Instance.Save(m_current, GetCategoryObject)
      Ps.InsertObject(Me.GetCategoryObject, m_current)

   End Sub
   ''' <summary>
   ''' Metodo hook che esegue operazioni custumizzate per portare a termine l'aggiornamento di un oggetto.
   ''' Di default richiede l'aggiornamento dell'oggetto al servizio di persistenza.
   ''' </summary>
   ''' <remarks></remarks>
   Protected Overridable Sub DoUpdate()

      'RegistratoreElementi.Instance.Save(m_current, GetCategoryObject)
      Ps.UpdateObject(Me.GetCategoryObject, m_current)

   End Sub
#End Region

   ''' <summary>
   ''' Metodo sovrascrivibile  che restituisce il tipo dell'oggetto che il controller controlla
   ''' </summary>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public Overridable Function GetCategoryObject() As String
      Return "AbstractController"
   End Function


   Public Sub ExecuteSqlCommand(ByVal Command As String)
      Ps.ExecuteNonQuery(Command)
   End Sub


   Public Function CurrentObjectJournalingData() As String
      If m_current IsNot Nothing Then
         Dim result As String = ""
         result += "Creato da - " & m_current.CreatoDa & Environment.NewLine
         result += "Creato in data - " & m_current.DataCreazione.ToString & Environment.NewLine
         result += "Modificato da - " & m_current.ModificatoDa & Environment.NewLine
         result += "Modificato in data - " & m_current.DataModifica.ToString & Environment.NewLine
         Return result
      End If
      Return ""
   End Function



#Region "Metodi per la ricerca dei degli oggetti"

   Friend Function GetCurrent() As AbstractPersistenceObject
      Return m_current
   End Function
   ''' <summary>
   ''' Metodosovrascrivibile che richiede al servizio di persistenza il caricamento di un oggetto dall'id specificato
   ''' </summary>
   ''' <param name="Id"></param>
   ''' <remarks></remarks>
   Public Overridable Sub LoadById(ByVal Id As String)
      If Not IsNumeric(Id) Then Throw New Exception("Impossibile caricare un oggetto. Il formato dell'id immesso non è corretto. Inserire l'Id corretto.")
      ' m_current = RegistratoreElementi.Instance.GetObjectById(Id, GetCategoryObject) '
      m_current = Ps.GetObject(GetCategoryObject, Id)
      If m_current Is Nothing Then Throw New Exception("L'oggetto con l'Id richiesto non esiste. Reinserire un Id corretto oppure effettuare una ricerca.")
   End Sub

   Public Overridable Sub LoadByIdReloadingCache(ByVal Id As String)
      If Not IsNumeric(Id) Then Throw New Exception("Impossibile caricare un oggetto. Il formato dell'id immesso non è corretto. Inserire l'Id corretto.")
      ' m_current = RegistratoreElementi.Instance.GetObjectById(Id, GetCategoryObject) '
      m_current = Ps.GetObjectReloadingCache(GetCategoryObject, Id)
      If m_current Is Nothing Then Throw New Exception("L'oggetto con l'Id richiesto non esiste. Reinserire un Id corretto oppure effettuare una ricerca.")
   End Sub

   ''' <summary>
   ''' Metodo sovrascrivibile  che richiama il caricamento di tutti gli elementi dal servizio di persistenza. 
   ''' </summary>
   ''' <remarks></remarks>
   Protected Overridable Sub LoadAll()

      'DomainObjectList = RegistratoreElementi.Instance.GetAll(GetCategoryObject)
      DomainObjectList = Ps.GetAllObjects(Me.GetCategoryObject)

   End Sub
   ''' <summary>
   ''' Metodo sovrascrivibile  che carica e restituisce tutti gli elementi di un dato tipo presenti
   ''' </summary>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public Overridable Function GetAll() As ArrayList

      LoadAll()
      Return Me.DomainObjectList

   End Function

   Public Overridable Sub Delete()
      Try
         Ps.DeleteObject(GetCategoryObject, m_current)
      Catch ex As Exception
         Throw New Exception("Impossibile eliminare l'oggetto." & vbCrLf & ex.Message)
      End Try
   End Sub


#End Region
End Class
