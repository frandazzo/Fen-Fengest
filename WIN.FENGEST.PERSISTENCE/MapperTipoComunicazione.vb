Public Class MapperTipoComunicazione
   Inherits AbstractRDBMapper


#Region "Istruzioni Sql"

   Protected Overrides Function FindAllStatement() As String
      Return "Select * from DB_TIPO_COMUNICAZIONE"
   End Function

   Protected Overrides Function FindByKeyStatement() As String
      Return "Select * from DB_TIPO_COMUNICAZIONE where Id = @Id"
   End Function

   Protected Overrides Function InsertStatement() As String
      Return "Insert into DB_TIPO_COMUNICAZIONE (ID, DESCRIZIONE, CreatedBy, CreatedOn) values (@Id, @Desc, @CRby, @CRon)"
   End Function

   Protected Overrides Function UpdateStatement() As String
      Return "UPDATE DB_TIPO_COMUNICAZIONE SET Descrizione = @Desc, ModifiedBy = @MOby, ModifiedOn = @MOon   WHERE (Id =@Id )"
   End Function

   Protected Overrides Function DeleteStatement() As String
      Return "Delete from DB_TIPO_COMUNICAZIONE where Id = @Id"
   End Function

   Protected Overrides Function FindNextKeyStatement() As String
      Return "Select Max(Id) from DB_TIPO_COMUNICAZIONE"
   End Function

#End Region


#Region "Metodi per la ricerca dell'oggetto secondo l'id proposto"

   Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject

      Return DirectCast(MyBase.FindByKey(New Key(Id)), TipoComunicazione)

   End Function
   Protected Overloads Overrides Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable) As AbstractPersistenceObject
      Dim tipo As New TipoComunicazione
      tipo.Descrizione = rs.Item("DESCRIZIONE")
      tipo.Key = Key
      JournalingDataLoader.ReadJournalingParameters(tipo, rs)
      Return tipo
   End Function
    'Protected Overrides Function GetCommand(ByVal CommandText As String) As System.Data.IDbCommand

    '   ' Return New SqlClient1.SqlCommand(CommandText, DBConnectionManager.Instance.GetCurrentConnection)
    '   Return DBTypeUtils.GetCommand(Me.m_PersistentService.ServiceName, CommandText, DBConnectionManager.Instance.GetCurrentConnection)

    'End Function

#End Region

    Public Overrides Function FindObjectByIdReloadingCache(ByVal Id As Integer) As AbstractPersistenceObject

        Return DirectCast(MyBase.FindByKeyReloadingCache(New Key(Id)), TipoComunicazione)


    End Function


   Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Dim tipo As TipoComunicazione = DirectCast(Item, TipoComunicazione)

      Dim param As IDbDataParameter = Cmd.CreateParameter
      param.ParameterName = "@Desc"
      param.Value = tipo.Descrizione
      Cmd.Parameters.Add(param)

      JournalingDataLoader.LoadJournalingInsertCommandParameters(Item, Cmd)
   End Sub

   Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)

      Dim tipo As TipoComunicazione = DirectCast(Item, TipoComunicazione)

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
