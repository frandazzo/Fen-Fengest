Public Class MapperLivelloAbilita
   Inherits AbstractRDBMapper



#Region "Istruzioni Sql"

   Protected Overrides Function FindAllStatement() As String
      Return "Select * from DB_Livello_Abilita"
   End Function

   Protected Overrides Function FindByKeyStatement() As String
      Return "Select * from DB_Livello_Abilita where Id = @Id"
   End Function

   Protected Overrides Function InsertStatement() As String
      Return "Insert into DB_Livello_Abilita (ID, DESCRIZIONE, CreatedBy, CreatedOn) values (@Id, @Desc, @CRby, @CRon)"
   End Function

   Protected Overrides Function UpdateStatement() As String
      Return "UPDATE DB_Livello_Abilita SET Descrizione = @Desc, ModifiedBy = @MOby, ModifiedOn = @MOon  WHERE (Id =@Id )"
   End Function

   Protected Overrides Function DeleteStatement() As String
      Return "Delete from DB_Livello_Abilita where Id = @Id"
   End Function

   Protected Overrides Function FindNextKeyStatement() As String
      Return "Select Max(Id) from DB_Livello_Abilita"
   End Function

#End Region


#Region "Metodi per la ricerca dell'oggetto secondo l'id proposto"

   Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject

      Return DirectCast(MyBase.FindByKey(New Key(Id)), LivelloAbilita)

   End Function
   Protected Overloads Overrides Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable) As AbstractPersistenceObject
      Dim Livello As New LivelloAbilita()
      Livello.Descrizione = rs.Item("DESCRIZIONE")
      Livello.Key = Key
      JournalingDataLoader.ReadJournalingParameters(Livello, rs)
      Return Livello
   End Function
    'Protected Overrides Function GetCommand(ByVal CommandText As String) As System.Data.IDbCommand

    '   'Return New SqlClient1.SqlCommand(CommandText, DBConnectionManager.Instance.GetCurrentConnection)
    '   Return DBTypeUtils.GetCommand(Me.m_PersistentService.ServiceName, CommandText, DBConnectionManager.Instance.GetCurrentConnection)
    'End Function

#End Region




   Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Dim Livello As LivelloAbilita = DirectCast(Item, LivelloAbilita)

      Dim param As IDbDataParameter = Cmd.CreateParameter
      param.ParameterName = "@Desc"
      param.Value = Livello.Descrizione
      Cmd.Parameters.Add(param)

      JournalingDataLoader.LoadJournalingInsertCommandParameters(Item, Cmd)
   End Sub

   Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)

      Dim livello As LivelloAbilita = DirectCast(Item, LivelloAbilita)

      Dim param As IDbDataParameter = Cmd.CreateParameter
      param.ParameterName = "@Desc"
      param.Value = livello.Descrizione
      Cmd.Parameters.Add(param)

      JournalingDataLoader.LoadJournalingUpdateCommandParameters(Item, Cmd)

      param = Cmd.CreateParameter
      param.ParameterName = "@Id"
      param.Value = livello.Id
      Cmd.Parameters.Add(param)

   End Sub


End Class
