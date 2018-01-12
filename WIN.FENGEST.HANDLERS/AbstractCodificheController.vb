Public MustInherit Class AbstractCodificheController
   Inherits AbstractController
   Implements APPLICATION.IControllerCodifiche

   Public Property Descrizione() As String Implements IControllerCodifiche.Descrizione
      Get
         Return m_current.Descrizione
      End Get
      Set(ByVal value As String)
         m_current.Descrizione = value
      End Set
   End Property
   Public ReadOnly Property Id() As Int32 Implements IControllerCodifiche.Id
      Get
         Return m_current.Id
      End Get
   End Property

   Public Overridable Sub LoadByDescrizione(ByVal Descrizione As String) Implements IControllerCodifiche.LoadByDescrizione

   End Sub

   Public Overrides Sub CreateNew() Implements IControllerCodifiche.CreateNew
      '
   End Sub
   Public Overridable Overloads Sub CreateNew(ByVal Descrizione As String) Implements IControllerCodifiche.CreateNew

   End Sub

   Public MustOverride Function GetListaCausali() As ArrayList Implements IControllerCodifiche.GetListaCausali


   Public Overrides Function GetCategoryObject() As String Implements IControllerCodifiche.GetCategoryObject
      Return ""
   End Function
   Friend MustOverride Function GetCausaleById(ByVal Id As String) As AbstractPersistenceObject Implements IControllerCodifiche.GetCausaleById


   Public Function GetIdByDescrizione(ByVal Descrizione As String) As String Implements IControllerCodifiche.GetIdByDescrizione
      Try
         LoadByDescrizione(Descrizione)
         Return m_current.Id
      Catch ex As Exception
         Throw New Exception(ex.Message)
      End Try
   End Function
   Public Overrides Sub Save() Implements IControllerCodifiche.Save
      MyBase.Save()
   End Sub
   Public Overrides Sub LoadById(ByVal Id As String) Implements IControllerCodifiche.LoadById
      MyBase.LoadById(Id)
   End Sub
End Class
