Public Interface IControllerCodifiche
   Property Descrizione() As String
   ReadOnly Property Id() As Int32
   Sub LoadByDescrizione(ByVal Descrizione As String)
   Sub CreateNew()
   Sub CreateNew(ByVal Descrizione As String)
   Function GetListaCausali() As ArrayList
   Function GetCategoryObject() As String
   Function GetCausaleById(ByVal Id As String) As AbstractPersistenceObject
   Function GetIdByDescrizione(ByVal Descrizione As String) As String
   Sub Save()
   Sub LoadById(ByVal Id As String)
End Interface
