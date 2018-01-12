Public Class RegistratoreElementi
   Private Shared m_Instance As RegistratoreElementi
   Private lista As New Hashtable
   Public Shared Function Instance() As RegistratoreElementi
      If m_Instance Is Nothing Then
         m_Instance = New RegistratoreElementi
         m_Instance.Add("Conto", New ArrayList)
         m_Instance.Add("Utente", New ArrayList)
         m_Instance.Add("Azienda", New ArrayList)
         m_Instance.Add("Referente", New ArrayList)
         m_Instance.Add("Delega", New ArrayList)
         m_Instance.Add("Pagamento", New ArrayList)
      End If
      Return m_Instance
   End Function
   Private Function NextIdGenerator(ByVal Category As String) As Int32
      Dim arr As ArrayList = GetCategory(Category)
      Dim max As Int32 = 0
      For Each elem As AbstractPersistenceObject In arr
         If elem.Key.LongValue > max Then max = elem.Key.LongValue
      Next
      Return max + 1
   End Function

   Private Function GetCategory(ByVal Category As String) As ArrayList
      Dim arr As ArrayList
      Try
         arr = m_Instance.Item(Category)
         Return arr
      Catch ex As Exception
         Throw New Exception("Categoria oggetti persistenti sconosciuta. Impossibile recuperare la categoria scelta")
      End Try
   End Function

   Public Sub Save(ByVal Obj As AbstractPersistenceObject, ByVal Category As String)
      Dim NewId As Int32 = NextIdGenerator(Category)
      Dim arr As ArrayList = GetCategory(Category)
      Obj.Key = New Key(NewId)
      If Not arr.Contains(Obj) Then
         arr.Add(Obj)
      End If
   End Sub

   Public Function GetObjectById(ByVal Id As Int32, ByVal Category As String) As AbstractPersistenceObject
      Try
         Dim arr As ArrayList = GetCategory(Category)
         For Each elem As AbstractPersistenceObject In arr
            If elem.Key.LongValue = Id Then
               Return elem
            End If
         Next
         Throw New Exception("Non è stato trovato nessun oggetto con l'id specificato")
      Catch ex As Exception
         Throw New Exception(ex.Message)
      End Try
   End Function
   Public Function GetAll(ByVal Category As String) As ArrayList
      Try
         Return Me.GetCategory(Category)
      Catch ex As Exception
         Throw New Exception(ex.Message)
      End Try
   End Function


   Public Sub Add(ByVal Nome As String, ByVal Oggetto As Object)
      lista.Add(Nome, Oggetto)
   End Sub
   Public Function Item(ByVal Nome As String) As Object
      Try
         Return lista.Item(Nome)
      Catch ex As Exception
         Throw New Exception(ex.Message)
      End Try
   End Function
End Class
