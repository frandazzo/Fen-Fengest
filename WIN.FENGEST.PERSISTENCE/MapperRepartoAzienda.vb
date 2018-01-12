Public Class MapperRepartoAzienda
   Inherits AbstractRDBMapper



#Region "Istruzioni Sql"

   Protected Overrides Function FindAllStatement() As String
      Return "Select * from COD_CAUSALI_REPARTI"
   End Function

   Protected Overrides Function FindByKeyStatement() As String
      Return "Select * from COD_CAUSALI_REPARTI where Id = @Id"
   End Function

   Protected Overrides Function InsertStatement() As String
      Return "Insert into COD_CAUSALI_REPARTI (ID, DESCRIZIONE, CreatedBy, CreatedOn) values (@Id, @Desc, @CRby, @CRon)"
   End Function

   Protected Overrides Function UpdateStatement() As String
      Return "UPDATE COD_CAUSALI_REPARTI SET Descrizione = @Desc, ModifiedBy = @MOby, ModifiedOn = @MOon    WHERE (Id =@Id )"
   End Function

   Protected Overrides Function DeleteStatement() As String
      Return "Delete from COD_CAUSALI_REPARTI where Id = @Id"
   End Function

   Protected Overrides Function FindNextKeyStatement() As String
      Return "Select Max(Id) from COD_CAUSALI_REPARTI"
   End Function

#End Region


#Region "Metodi per la ricerca dell'oggetto secondo l'id proposto"

   Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject

      Return DirectCast(MyBase.FindByKey(New Key(Id)), RepartoAzienda)


   End Function
   Protected Overloads Overrides Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable) As AbstractPersistenceObject
      Try
         Dim causale As RepartoAzienda = New RepartoAzienda
         causale.Descrizione = rs.Item("DESCRIZIONE")
         causale.Key = Key
         JournalingDataLoader.ReadJournalingParameters(causale, rs)
         Return causale
      Catch ex As Exception
         Throw New Exception("Impossibile caricare l'oggetto Reparto azienda con Id = " & Key.LongValue & ". " & vbCrLf & ex.Message)
      End Try
   End Function
    'Protected Overrides Function GetCommand(ByVal CommandText As String) As System.Data.IDbCommand

    '   'Return New SqlClient1.SqlCommand(CommandText, DBConnectionManager.Instance.GetCurrentConnection)
    '   Return DBTypeUtils.GetCommand(Me.m_PersistentService.ServiceName, CommandText, DBConnectionManager.Instance.GetCurrentConnection)

    'End Function

#End Region




   Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Try
         Dim causale As RepartoAzienda = DirectCast(Item, RepartoAzienda)

         Dim param As IDbDataParameter = Cmd.CreateParameter
         param.ParameterName = "@Desc"
         param.Value = causale.Descrizione
         Cmd.Parameters.Add(param)

         JournalingDataLoader.LoadJournalingInsertCommandParameters(Item, Cmd)

      Catch ex As Exception
         Throw New Exception("Impossibile caricare il comando di inserimento dell'oggetto  Reparto azienda." & vbCrLf & ex.Message)
      End Try
   End Sub

   Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Try
         Dim causale As RepartoAzienda = DirectCast(Item, RepartoAzienda)

         Dim param As IDbDataParameter = Cmd.CreateParameter
         param.ParameterName = "@Desc"
         param.Value = causale.Descrizione
         Cmd.Parameters.Add(param)
         JournalingDataLoader.LoadJournalingUpdateCommandParameters(Item, Cmd)


         param = Cmd.CreateParameter
         param.ParameterName = "@Id"
         param.Value = causale.Id
         Cmd.Parameters.Add(param)

      Catch ex As Exception
         Throw New Exception("Impossibile caricare il comando di aggiornamento dell'oggetto Reparto azienda." & vbCrLf & ex.Message)
      End Try
   End Sub

End Class
