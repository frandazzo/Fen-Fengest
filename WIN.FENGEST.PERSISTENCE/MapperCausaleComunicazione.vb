Public Class MapperCausaleComunicazione
   Inherits AbstractRDBMapper


#Region "Istruzioni Sql"

   Protected Overrides Function FindAllStatement() As String
      Return "Select * from DB_CAUSALE_COMUNICAZIONE"
   End Function

   Protected Overrides Function FindByKeyStatement() As String
      Return "Select * from DB_CAUSALE_COMUNICAZIONE where Id = @Id"
   End Function

   Protected Overrides Function InsertStatement() As String
      Return "Insert into DB_CAUSALE_COMUNICAZIONE (ID, DESCRIZIONE, CreatedBy, CreatedOn) values (@Id, @Desc, @CRby, @CRon)"
   End Function

   Protected Overrides Function UpdateStatement() As String
      Return "UPDATE DB_CAUSALE_COMUNICAZIONE SET Descrizione = @Desc, ModifiedBy = @MOby, ModifiedOn = @MOon  WHERE (Id =@Id )"
   End Function

   Protected Overrides Function DeleteStatement() As String
      Return "Delete from DB_CAUSALE_COMUNICAZIONE where Id = @Id"
   End Function

   Protected Overrides Function FindNextKeyStatement() As String
      Return "Select Max(Id) from DB_CAUSALE_COMUNICAZIONE"
   End Function

#End Region


#Region "Metodi per la ricerca dell'oggetto secondo l'id proposto"

   Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject

      Return DirectCast(MyBase.FindByKey(New Key(Id)), CausaleComunicazione)

   End Function
   Protected Overloads Overrides Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable) As AbstractPersistenceObject
      Dim CausaleComunicazione As New CausaleComunicazione
      CausaleComunicazione.Descrizione = rs.Item("DESCRIZIONE")
      CausaleComunicazione.Key = Key
      JournalingDataLoader.ReadJournalingParameters(CausaleComunicazione, rs)
      Return CausaleComunicazione
   End Function
    'Protected Overrides Function GetCommand(ByVal CommandText As String) As System.Data.IDbCommand

    '   'Return New SqlClient1.SqlCommand(CommandText, DBConnectionManager.Instance.GetCurrentConnection)
    '   Return DBTypeUtils.GetCommand(Me.m_PersistentService.ServiceName, CommandText, DBConnectionManager.Instance.GetCurrentConnection)

    'End Function

#End Region


    Public Overrides Function FindObjectByIdReloadingCache(ByVal Id As Integer) As AbstractPersistenceObject

        Return DirectCast(MyBase.FindByKeyReloadingCache(New Key(Id)), CausaleComunicazione)


    End Function

   Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Dim tipo As CausaleComunicazione = DirectCast(Item, CausaleComunicazione)

      Dim param As IDbDataParameter = Cmd.CreateParameter
      param.ParameterName = "@Desc"
      param.Value = tipo.Descrizione
      Cmd.Parameters.Add(param)
      JournalingDataLoader.LoadJournalingInsertCommandParameters(Item, Cmd)
   End Sub

   Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)

      Dim tipo As CausaleComunicazione = DirectCast(Item, CausaleComunicazione)

      Dim param As IDbDataParameter = Cmd.CreateParameter
      param.ParameterName = "@Desc"
      param.Value = tipo.Descrizione
      Cmd.Parameters.Add(param)
      JournalingDataLoader.LoadJournalingUpdateCommandParameters(Item, Cmd)

      param = Cmd.CreateParameter
      param.ParameterName = "@Id"
      param.Value = tipo.Id
      Cmd.Parameters.Add(param)

   End Sub

End Class
