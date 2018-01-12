Public Class MapperAbilita
   Inherits AbstractRDBMapper



#Region "Istruzioni Sql"

   Protected Overrides Function FindAllStatement() As String
      Return "Select * from DB_Abilita"
   End Function

   Protected Overrides Function FindByKeyStatement() As String
      Return "Select * from DB_Abilita where Id = @Id"
   End Function

   Protected Overrides Function InsertStatement() As String
      Return "Insert into DB_Abilita (ID, DESCRIZIONE, CreatedBy, CreatedOn) values (@Id, @Desc, @CRby, @CRon)"
   End Function

   Protected Overrides Function UpdateStatement() As String
      Return "UPDATE DB_Abilita SET Descrizione = @Desc, ModifiedBy = @MOby, ModifiedOn = @MOon  WHERE (Id =@Id )"
   End Function

   Protected Overrides Function DeleteStatement() As String
      Return "Delete from DB_Abilita where Id = @Id"
   End Function

   Protected Overrides Function FindNextKeyStatement() As String
      Return "Select Max(Id) from DB_Abilita"
   End Function

#End Region


#Region "Metodi per la ricerca dell'oggetto secondo l'id proposto"

   Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject

      Return DirectCast(MyBase.FindByKey(New Key(Id)), Abilita)

   End Function
   Protected Overloads Overrides Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable) As AbstractPersistenceObject
      Dim abilita As New Abilita()
      abilita.Descrizione = rs.Item("DESCRIZIONE")
      abilita.Key = Key
      JournalingDataLoader.ReadJournalingParameters(abilita, rs)
      Return abilita
   End Function
    'Protected Overrides Function GetCommand(ByVal CommandText As String) As System.Data.IDbCommand

    '   'Return New SqlClient1.SqlCommand(CommandText, DBConnectionManager.Instance.GetCurrentConnection)
    '   Return DBTypeUtils.GetCommand(Me.m_PersistentService.ServiceName, CommandText, DBConnectionManager.Instance.GetCurrentConnection)

    'End Function

#End Region




   Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Dim abilita As Abilita = DirectCast(Item, Abilita)

      Dim param As IDbDataParameter = Cmd.CreateParameter
      param.ParameterName = "@Desc"
      param.Value = abilita.Descrizione
      Cmd.Parameters.Add(param)

      JournalingDataLoader.LoadJournalingInsertCommandParameters(Item, Cmd)
   End Sub

   Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)

      Dim abilita As Abilita = DirectCast(Item, Abilita)

      Dim param As IDbDataParameter = Cmd.CreateParameter
      param.ParameterName = "@Desc"
      param.Value = abilita.Descrizione
      Cmd.Parameters.Add(param)

      JournalingDataLoader.LoadJournalingUpdateCommandParameters(Item, Cmd)

      param = Cmd.CreateParameter
      param.ParameterName = "@Id"
      param.Value = abilita.Id
      Cmd.Parameters.Add(param)

   End Sub



End Class
