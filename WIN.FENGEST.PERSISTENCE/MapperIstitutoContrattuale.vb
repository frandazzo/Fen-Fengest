Public Class MapperIstitutoContrattuale
   Inherits AbstractRDBMapper



#Region "Istruzioni Sql"

   Protected Overrides Function FindAllStatement() As String
      Return "Select * from COD_ISTITUTI"
   End Function

   Protected Overrides Function FindByKeyStatement() As String
      Return "Select * from COD_ISTITUTI where Id = @Id"
   End Function

   Protected Overrides Function InsertStatement() As String
      Return "Insert into COD_ISTITUTI (ID, DESCRIZIONE, CreatedBy, CreatedOn) values (@Id, @Desc, @CRby, @CRon)"
   End Function

   Protected Overrides Function UpdateStatement() As String
      Return "UPDATE COD_ISTITUTI SET Descrizione = @Desc, ModifiedBy = @MOby, ModifiedOn = @MOon   WHERE (Id =@Id )"
   End Function

   Protected Overrides Function DeleteStatement() As String
      Return "Delete from COD_ISTITUTI where Id = @Id"
   End Function

   Protected Overrides Function FindNextKeyStatement() As String
      Return "Select Max(Id) from COD_ISTITUTI"
   End Function

#End Region


#Region "Metodi per la ricerca dell'oggetto secondo l'id proposto"

   Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject

      Return DirectCast(MyBase.FindByKey(New Key(Id)), IstitutoContrattuale)


   End Function
   Protected Overloads Overrides Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable) As AbstractPersistenceObject
      Try
         Dim Istituto As IstitutoContrattuale = New IstitutoContrattuale(rs.Item("DESCRIZIONE"))
         Istituto.Key = Key
         JournalingDataLoader.ReadJournalingParameters(Istituto, rs)
         Return Istituto
      Catch ex As Exception
         Throw New Exception("Impossibile caricare l'oggetto istituto contrattuale con Id = " & Key.LongValue & ". " & vbCrLf & ex.Message)
      End Try
   End Function
    'Protected Overrides Function GetCommand(ByVal CommandText As String) As System.Data.IDbCommand

    '   'Return New SqlClient1.SqlCommand(CommandText, DBConnectionManager.Instance.GetCurrentConnection)
    '   Return DBTypeUtils.GetCommand(Me.m_PersistentService.ServiceName, CommandText, DBConnectionManager.Instance.GetCurrentConnection)
    'End Function

#End Region




   Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Try
         Dim ist As IstitutoContrattuale = DirectCast(Item, IstitutoContrattuale)

         Dim param As IDbDataParameter = Cmd.CreateParameter
         param.ParameterName = "@Desc"
         param.Value = ist.Descrizione
         Cmd.Parameters.Add(param)

         JournalingDataLoader.LoadJournalingInsertCommandParameters(Item, Cmd)

      Catch ex As Exception
         Throw New Exception("Impossibile caricare il comando di inserimento dell'oggetto  istituto contrattuale." & vbCrLf & ex.Message)
      End Try
   End Sub

   Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Try
         Dim ist As IstitutoContrattuale = DirectCast(Item, IstitutoContrattuale)

         Dim param As IDbDataParameter = Cmd.CreateParameter
         param.ParameterName = "@Desc"
         param.Value = ist.Descrizione
         Cmd.Parameters.Add(param)

         JournalingDataLoader.LoadJournalingUpdateCommandParameters(Item, Cmd)

         param = Cmd.CreateParameter
         param.ParameterName = "@Id"
         param.Value = ist.Id
         Cmd.Parameters.Add(param)

      Catch ex As Exception
         Throw New Exception("Impossibile caricare il comando di aggiornamento dell'oggetto istituto contrattuale." & vbCrLf & ex.Message)
      End Try
   End Sub

End Class
