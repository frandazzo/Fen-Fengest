Public Class MapperTipoPrestazione
   Inherits AbstractRDBMapper



#Region "Istruzioni Sql"

   Protected Overrides Function FindAllStatement() As String
      Return "Select * from DB_TIPO_PRESTAZIONE"
   End Function

   Protected Overrides Function FindByKeyStatement() As String
      Return "Select * from DB_TIPO_PRESTAZIONE where Id = @Id"
   End Function

   Protected Overrides Function InsertStatement() As String
      Return "Insert into DB_TIPO_PRESTAZIONE (ID, DESCRIZIONE, CODICE, FILE_MODELLO, DIR_OUTPUT, CreatedBy, CreatedOn) values (@Id, @Desc, @Cod, @Fim, @Dir, @CRby, @CRon)"
   End Function

   Protected Overrides Function UpdateStatement() As String
      Return "UPDATE DB_TIPO_PRESTAZIONE SET DESCRIZIONE = @Desc, CODICE = @Cod, FILE_MODELLO = @Fim, DIR_OUTPUT = @Dir, ModifiedBy = @MOby, ModifiedOn = @MOon   WHERE (Id = @Id )"
   End Function

   Protected Overrides Function DeleteStatement() As String
      Return "Delete from DB_TIPO_PRESTAZIONE where Id = @Id"
   End Function

   Protected Overrides Function FindNextKeyStatement() As String
      Return "Select Max(Id) from DB_TIPO_PRESTAZIONE"
   End Function

#End Region


#Region "Metodi per la ricerca dell'oggetto secondo l'id proposto"

   Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject

      Return DirectCast(MyBase.FindByKey(New Key(Id)), TipoPrestazione)


   End Function
   Protected Overloads Overrides Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable) As AbstractPersistenceObject
      Try
         Dim tipo As New TipoPrestazione(rs.Item("DESCRIZIONE"), rs.Item("CODICE"), rs.Item("FILE_MODELLO"), rs.Item("DIR_OUTPUT"))
         tipo.Key = Key
         JournalingDataLoader.ReadJournalingParameters(tipo, rs)
         Return tipo
      Catch ex As Exception
         Throw New Exception("Impossibile caricare l'oggetto tipo prestazione con Id = " & Key.LongValue & ". " & vbCrLf & ex.Message)
      End Try
   End Function
    'Protected Overrides Function GetCommand(ByVal CommandText As String) As System.Data.IDbCommand

    '   'Return New SqlClient1.SqlCommand(CommandText, DBConnectionManager.Instance.GetCurrentConnection)
    '   Return DBTypeUtils.GetCommand(Me.m_PersistentService.ServiceName, CommandText, DBConnectionManager.Instance.GetCurrentConnection)

    'End Function

#End Region




   Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Try
         Dim Tipo As TipoPrestazione = DirectCast(Item, TipoPrestazione)

         Dim param As IDbDataParameter = Cmd.CreateParameter
         param.ParameterName = "@Desc"
         param.Value = Tipo.Descrizione
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Cod"
         param.Value = Tipo.CodicePrestazione
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Fim"
         param.Value = Tipo.NomeFileModello
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Dir"
         param.Value = Tipo.PathOutPut

         JournalingDataLoader.LoadJournalingInsertCommandParameters(Item, Cmd)

         Cmd.Parameters.Add(param)
      Catch ex As Exception
         Throw New Exception("Impossibile caricare il comando di inserimento dell'oggetto tipo prestazione." & vbCrLf & ex.Message)
      End Try
   End Sub

   Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Try
         Dim Tipo As TipoPrestazione = DirectCast(Item, TipoPrestazione)

         Dim param As IDbDataParameter = Cmd.CreateParameter
         param.ParameterName = "@Desc"
         param.Value = Tipo.Descrizione
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Cod"
         param.Value = Tipo.CodicePrestazione
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Fim"
         param.Value = Tipo.NomeFileModello
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Dir"
         param.Value = Tipo.PathOutPut
         Cmd.Parameters.Add(param)

         JournalingDataLoader.LoadJournalingUpdateCommandParameters(Item, Cmd)

         param = Cmd.CreateParameter
         param.ParameterName = "@Id"
         param.Value = Tipo.Id
         Cmd.Parameters.Add(param)

      Catch ex As Exception
         Throw New Exception("Impossibile caricare il comando di aggiornamento dell'oggetto tipo prestazione." & vbCrLf & ex.Message)
      End Try
   End Sub


End Class
