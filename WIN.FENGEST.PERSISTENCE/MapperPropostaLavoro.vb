Public Class MapperPropostaLavoro
   Inherits AbstractRDBMapper


#Region "Istruzioni Sql"

   Protected Overrides Function FindAllStatement() As String
      Return "Select * from DB_Proposte"
   End Function

   Protected Overrides Function FindByKeyStatement() As String
      Return "Select * from DB_Proposte where Id = @Id"
   End Function

   Protected Overrides Function InsertStatement() As String
      Return "Insert into DB_Proposte (ID, ID_ABILITA, ID_OFFERTA, DATA_REGISTRAZIONE, DATA_DOCUMENTO, NOTE_DOC, ID_UTENTE, CreatedBy, CreatedOn) values (@Id, @IdP, @IdOf, @Dr, @Dd, @Not, @IdUt, @CRby, @CRon)"
   End Function

   Protected Overrides Function UpdateStatement() As String
      Return "UPDATE DB_Proposte SET ID_ABILITA = @IdP, ID_OFFERTA = @IdOf, DATA_REGISTRAZIONE = @Dr, DATA_DOCUMENTO = @Dd, NOTE_DOC = @Not, ID_UTENTE = @IdUt, ModifiedBy = @MOby, ModifiedOn = @MOon  WHERE (Id =@Id )"
   End Function

   Protected Overrides Function DeleteStatement() As String
      Return "Delete from DB_Proposte where Id = @Id"
   End Function

   Protected Overrides Function FindNextKeyStatement() As String
      Return "Select Max(Id) from DB_Proposte"
   End Function

#End Region


#Region "Metodi per la ricerca dell'oggetto secondo l'id proposto"

   Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject

      Return DirectCast(MyBase.FindByKey(New Key(Id)), PropostaLavoro)

   End Function
   Protected Overloads Overrides Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable) As AbstractPersistenceObject
      Dim proposta As New PropostaLavoro

      Dim Id_Utente As Int32 = IIf(rs("ID_UTENTE") IsNot Nothing, rs("ID_UTENTE"), -1)
      Dim MapperUtente As MapperUtente = PersistenceMapperRegistry.Instance.GetMapperByName("MapperUtente")
      Dim utente As Utente = MapperUtente.FindObjectById(Id_Utente)
      Dim Id_ABILITA As Int32 = IIf(rs("ID_ABILITA") IsNot Nothing, rs("ID_ABILITA"), -1)


      Dim MapperAbilita As MapperAbilita = PersistenceMapperRegistry.Instance.GetMapperByName("MapperAbilita")
      Dim Abilita As Abilita = MapperAbilita.FindObjectById(Id_ABILITA)


      Dim Id_Offerta As Int32 = IIf(rs("ID_OFFERTA") IsNot Nothing, rs("ID_OFFERTA"), -1)
      Dim MapperOfferta As MapperOffertaLavoro = PersistenceMapperRegistry.Instance.GetMapperByName("MapperOffertaLavoro")
      Dim offerta As OffertaLavoro = MapperOfferta.FindObjectById(Id_Offerta)




      Dim DATA_REGISTRAZIONE As DateTime = IIf(rs("DATA_REGISTRAZIONE") IsNot Nothing, rs("DATA_REGISTRAZIONE"), DateTime.MinValue)
      Dim DATA_DOCUMENTO As DateTime = IIf(rs("DATA_DOCUMENTO") IsNot Nothing, rs("DATA_DOCUMENTO"), DateTime.MinValue)
      Dim NOTE As String = IIf(rs("NOTE_DOC") IsNot Nothing, rs("NOTE_DOC"), "")

      proposta.DataRegistrazione = DATA_REGISTRAZIONE
      proposta.DataDocumento = DATA_DOCUMENTO
      proposta.Note = NOTE
      proposta.Abilita = Abilita
      proposta.Utente = utente
      proposta.Offerta = offerta

      proposta.Key = Key

      JournalingDataLoader.ReadJournalingParameters(proposta, rs)
      Return proposta
   End Function
    'Protected Overrides Function GetCommand(ByVal CommandText As String) As System.Data.IDbCommand

    '   'Return New SqlClient1.SqlCommand(CommandText, DBConnectionManager.Instance.GetCurrentConnection)
    '   Return DBTypeUtils.GetCommand(Me.m_PersistentService.ServiceName, CommandText, DBConnectionManager.Instance.GetCurrentConnection)

    'End Function

#End Region




   Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Dim proposta As PropostaLavoro = DirectCast(Item, PropostaLavoro)

      Dim param As IDbDataParameter = Cmd.CreateParameter
      param.ParameterName = "@IdP"
      If proposta.Abilita Is Nothing Then
         param.Value = DBNull.Value
      Else
         param.Value = proposta.Abilita.Id
      End If
      Cmd.Parameters.Add(param)


      param = Cmd.CreateParameter
      param.ParameterName = "@IdOf"
      If proposta.Offerta Is Nothing Then
         param.Value = DBNull.Value
      Else
         param.Value = proposta.Offerta.Id
      End If
      Cmd.Parameters.Add(param)



      param = Cmd.CreateParameter
      param.ParameterName = "@Dr"
      If proposta.DataRegistrazione = DateTime.MinValue Then
         param.Value = DBNull.Value
      Else
         param.Value = proposta.DataRegistrazione
      End If
      Cmd.Parameters.Add(param)



      param = Cmd.CreateParameter
      param.ParameterName = "@Dd"
      If proposta.DataDocumento = DateTime.MinValue Then
         param.Value = DBNull.Value
      Else
         param.Value = proposta.DataDocumento
      End If
      Cmd.Parameters.Add(param)

      param = Cmd.CreateParameter
      param.ParameterName = "@Not"
      param.Value = proposta.Note
      Cmd.Parameters.Add(param)

      param = Cmd.CreateParameter
      param.ParameterName = "@IdUt"
      param.Value = proposta.Utente.Id
      Cmd.Parameters.Add(param)


      JournalingDataLoader.LoadJournalingInsertCommandParameters(Item, Cmd)
   End Sub

   Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)

      Dim proposta As PropostaLavoro = DirectCast(Item, PropostaLavoro)

      Dim param As IDbDataParameter = Cmd.CreateParameter
      param.ParameterName = "@IdP"
      If proposta.Abilita Is Nothing Then
         param.Value = DBNull.Value
      Else
         param.Value = proposta.Abilita.Id
      End If
      Cmd.Parameters.Add(param)


      param = Cmd.CreateParameter
      param.ParameterName = "@IdOf"
      If proposta.Offerta Is Nothing Then
         param.Value = DBNull.Value
      Else
         param.Value = proposta.Offerta.Id
      End If
      Cmd.Parameters.Add(param)



      param = Cmd.CreateParameter
      param.ParameterName = "@Dr"
      If proposta.DataRegistrazione = DateTime.MinValue Then
         param.Value = DBNull.Value
      Else
         param.Value = proposta.DataRegistrazione
      End If
      Cmd.Parameters.Add(param)



      param = Cmd.CreateParameter
      param.ParameterName = "@Dd"
      If proposta.DataDocumento = DateTime.MinValue Then
         param.Value = DBNull.Value
      Else
         param.Value = proposta.DataDocumento
      End If
      Cmd.Parameters.Add(param)

      param = Cmd.CreateParameter
      param.ParameterName = "@Not"
      param.Value = proposta.Note
      Cmd.Parameters.Add(param)

      param = Cmd.CreateParameter
      param.ParameterName = "@IdUt"
      param.Value = proposta.Utente.Id
      Cmd.Parameters.Add(param)

      JournalingDataLoader.LoadJournalingUpdateCommandParameters(Item, Cmd)

      param = Cmd.CreateParameter
      param.ParameterName = "@Id"
      param.Value = proposta.Id
      Cmd.Parameters.Add(param)

   End Sub
End Class
