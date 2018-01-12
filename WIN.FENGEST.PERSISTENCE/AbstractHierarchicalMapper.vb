Public Class AbstractHierarchicalMapper
   Inherits AbstractRDBMapper



#Region "Metodi non implementati"
   Protected Overrides Function FindAllStatement() As String
      Throw New Exception("Not implemented method")
   End Function
   Protected Overrides Function FindByKeyStatement() As String
      Throw New Exception("Not implemented method")
   End Function
   Protected Overrides Function FindNextKeyStatement() As String
      Throw New Exception("Not implemented method")
   End Function
   Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject
      Throw New Exception("Not implemented method")
   End Function
   Protected Overrides Function InsertStatement() As String
      Throw New Exception("Not implemented method")
   End Function
   Protected Overrides Function UpdateStatement() As String
      Throw New Exception("Not implemented method")
   End Function
   Protected Overrides Function DeleteStatement() As String
      Throw New Exception("Not implemented method")
   End Function
   Protected Overloads Overrides Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable) As AbstractPersistenceObject
      Throw New Exception("Not implemented method")
   End Function
   Protected Overridable Function CreateNewObject() As AbstractPersistenceObject
      Throw New Exception("not implemented method")
   End Function
#End Region



   Protected Overrides Function GetObjectFromStorage(ByVal Key As Key) As AbstractPersistenceObject
      Dim rs As IDataReader = Nothing
      Dim dataHash As Hashtable
      Try
         'qui devo leggere l'oggetto in un datareader e caricarlo
            If m_PersistentService.CurrentConnection.State = ConnectionState.Closed Then m_PersistentService.CurrentConnection.Open()
         rs = GetDBRecordData(Key)
         If rs.Read Then
            dataHash = LoadHashTableDataFromDatareader(rs)
            rs.Close()
            Dim obj As AbstractPersistenceObject = Me.CreateNewObject
            LoadObject(obj, dataHash)
            'Dim obj As AbstractPersistenceObject = Load(dataHash)
            Return obj
         End If
         Return Nothing
      Catch ex As Exception
         Throw New Exception(ex.Message)
      Finally
         ReleaseDBDatareader(rs)
         dataHash = New Hashtable
      End Try
   End Function
   Protected Overrides Function LoadAll(ByVal rs As ArrayList) As ArrayList
      Dim List As New ArrayList
      Try
         For Each elem As Hashtable In rs
            Dim item As AbstractPersistenceObject = Me.CreateNewObject
            LoadObject(item, elem)
            List.Add(item)
         Next
         Return List
      Catch ex As Exception
         Throw New Exception(ex.Message)
      End Try
   End Function
   Protected Sub LoadObject(ByRef Item As AbstractPersistenceObject, ByVal rs As Hashtable)

      Dim key As Key = CreateKey(rs)
      If Cache.GetObjectFromCache(key.ToString) IsNot Nothing Then
         Item = Cache.GetObjectFromCache(key.ToString)
      Else
         BuildObject(Item, key, rs)
         Cache.AddToCache(Item)
      End If


   End Sub
    'Protected Overrides Function GetCommand(ByVal CommandText As String) As System.Data.IDbCommand
    '   'Return New SqlClient1.SqlCommand(CommandText, DBConnectionManager.Instance.GetCurrentConnection)
    '   Return DBTypeUtils.GetCommand(Me.m_PersistentService.ServiceName, CommandText, DBConnectionManager.Instance.GetCurrentConnection)
    'End Function

   Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      '
   End Sub
   Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      '
   End Sub

   Protected Overridable Sub BuildObject(ByVal Item As AbstractPersistenceObject, ByVal Key As Key, ByVal rs As Hashtable)
      '
   End Sub



   Public Overrides Sub Update(ByVal item As AbstractPersistenceObject)
      Dim cmd As IDbCommand

      If item.IsValid Then
         cmd = GetCommand(UpdateStatement)
         LoadUpdateCommandParameters(item, cmd)
         LoadUpdateCommandKeysParameters(item, cmd)
         cmd.ExecuteNonQuery()
         'anche se già presente nella cache ne rinnovo il riferimento nel caso il riferimento
         'presente nella cache punti ad un'altra area di memoria
         Cache.AddToCache(item)
      Else
         Dim errors As String = ""
         For Each elem As String In item.ValidationErrors
            errors = errors & elem & vbCrLf
         Next
         Throw New Exception("L'oggetto inserito non è valido. Controllare il valore dei valori immessi" & vbCrLf & errors)
      End If

   End Sub
   Protected Sub LoadUpdateCommandKeysParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Dim param As IDbDataParameter = Cmd.CreateParameter
      param.ParameterName = "@Id"
      param.Value = Item.Id
      Cmd.Parameters.Add(param)
   End Sub
End Class
