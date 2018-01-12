Public Class MapperContratto
   Inherits AbstractRDBMapper




#Region "Metodi non implementati"
   Protected Overrides Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable) As AbstractPersistenceObject
      Throw New Exception("Not implemented method")
   End Function
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
    'Protected Overrides Function GetCommand(ByVal CommandText As String) As System.Data.IDbCommand

    '   'Return New SqlClient1.SqlCommand(CommandText, DBConnectionManager.Instance.GetCurrentConnection)
    '   Return DBTypeUtils.GetCommand(Me.m_PersistentService.ServiceName, CommandText, DBConnectionManager.Instance.GetCurrentConnection)
    'End Function
   Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Throw New Exception("Not implemented method")
   End Sub
   Protected Overrides Function UpdateStatement() As String
      Throw New Exception("Not implemented method")
   End Function
#End Region

   Public Function LoadContratto(ByVal Settore As Settore, ByVal rs As Hashtable)
      Dim ID_TIPO_CONTRATTO As Int32 = IIf(rs.Item("ID_TIPO_CONTRATTO") Is Nothing, -1, rs.Item("ID_TIPO_CONTRATTO"))
      Dim mapper As MapperTipoContratto = PersistenceMapperRegistry.Instance.GetMapperByName("MapperTipoContratto")
      Dim CONTRATTO As TipoContratto = mapper.FindObjectById(ID_TIPO_CONTRATTO)
      Return New Contratto(Settore, CONTRATTO)
   End Function

   Protected Overrides Function DeleteStatement() As String
      Return "Delete from DB_CONTRATTI_SETTORE WHERE ID_TIPO_CONTRATTO = @IdT AND ID_SETTORE = @IdS"
   End Function

   Protected Overrides Function InsertStatement() As String
      Return "INSERT INTO DB_CONTRATTI_SETTORE (ID_TIPO_CONTRATTO, ID_SETTORE) VALUES (@IdT, @IdS)"
   End Function

   Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      '
   End Sub

   Protected Overrides Sub LoadDeleteCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As IDbCommand)
      Try
         Dim contratto As Contratto = DirectCast(Item, Contratto)

         Dim param As IDbDataParameter = Cmd.CreateParameter
         param.ParameterName = "@IdT"
         param.Value = contratto.TipoContratto.Id
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@IdS"
         param.Value = contratto.Settore.Id
         Cmd.Parameters.Add(param)
      Catch ex As Exception
         Throw New Exception("Impossibile creare un parametro per la chiave identificativa nel comando per l'eliminazione di un oggetto" & vbCrLf & ex.Message)
      End Try
   End Sub

   Protected Overrides Sub LoadInsertCommandKeyParameter(ByVal Item As AbstractPersistenceObject, ByVal Cmd As IDbCommand)
      Try

         Dim contratto As Contratto = DirectCast(Item, Contratto)

         Dim param As IDbDataParameter = Cmd.CreateParameter
         param.ParameterName = "@IdT"
         param.Value = Contratto.TipoContratto.Id
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@IdS"
         param.Value = Contratto.Settore.Id
         Cmd.Parameters.Add(param)

      Catch ex As Exception
         Throw New Exception("Impossibile creare un parametro per la chiave identificativa nel comando per l'inserimento di un oggetto" & vbCrLf & ex.Message)
      End Try
   End Sub

   Public Overrides Function Insert(ByVal item As AbstractPersistenceObject) As Key

      If item.IsValid Then
         Return PerformInsert(item, New Key(-1, -1))
      Else
         Dim errors As String = ""
         For Each elem As String In item.ValidationErrors
            errors = errors & elem & vbCrLf
         Next
         Throw New Exception("L'oggetto inserito non è valido. Controllare il valore dei valori immessi" & vbCrLf & errors)
      End If

   End Function

End Class
