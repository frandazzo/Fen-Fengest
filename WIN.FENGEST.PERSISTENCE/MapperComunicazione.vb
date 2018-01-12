Public Class MapperComunicazione
   Inherits AbstractRDBMapper


#Region "Istruzioni Sql"

   Protected Overrides Function FindAllStatement() As String
      Return "Select * from DB_COMUNICAZIONI"
   End Function

   Protected Overrides Function FindByKeyStatement() As String
      Return "Select * from DB_COMUNICAZIONI where Id = @Id"
   End Function

   Protected Overrides Function InsertStatement() As String
      Return "Insert into DB_COMUNICAZIONI (ID, ID_UTENTE, ID_CAUSALE, DATA_COMUNICAZIONE, ALLEGATO, NOTE_DOC, ID_TIPO, CreatedBy, CreatedOn) values (@Id, @IdUt, @IdCau, @Dat, @All, @Not, @IdT, @CRby, @CRon)"
   End Function

   Protected Overrides Function UpdateStatement() As String
      Return "UPDATE DB_COMUNICAZIONI SET ID_UTENTE = @IdUt, ID_CAUSALE = @IdCau, DATA_COMUNICAZIONE = @Dat, ALLEGATO = @All, NOTE_DOC = @Not, ID_TIPO = @IdT, ModifiedBy = @MOby, ModifiedOn = @MOon WHERE (Id =@Id )"
   End Function

   Protected Overrides Function DeleteStatement() As String
      Return "Delete from DB_COMUNICAZIONI where Id = @Id"
   End Function

   Protected Overrides Function FindNextKeyStatement() As String
      Return "Select Max(Id) from DB_COMUNICAZIONI"
   End Function

#End Region


#Region "Metodi per la ricerca dell'oggetto secondo l'id proposto"

   Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject

      Return DirectCast(MyBase.FindByKey(New Key(Id)), Comunicazione)

   End Function
   Protected Overloads Overrides Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable) As AbstractPersistenceObject
      Dim com As New Comunicazione

      Dim Id_Utente As Int32 = IIf(rs("ID_UTENTE") IsNot Nothing, rs("ID_UTENTE"), -1)
      Dim MapperUtente As MapperUtente = PersistenceMapperRegistry.Instance.GetMapperByName("MapperUtente")
      Dim utente As Utente = MapperUtente.FindObjectById(Id_Utente)


      Dim Id_Causale As Int32 = IIf(rs("ID_CAUSALE") IsNot Nothing, rs("ID_CAUSALE"), -1)
      Dim MapperCausale As MapperCausaleComunicazione = PersistenceMapperRegistry.Instance.GetMapperByName("MapperCausaleComunicazione")
      Dim Causale As CausaleComunicazione = MapperCausale.FindObjectById(Id_Causale)


      Dim Id_Tipo As Int32 = IIf(rs("ID_TIPO") IsNot Nothing, rs("ID_TIPO"), -1)
      Dim MapperTipo As MapperTipoComunicazione = PersistenceMapperRegistry.Instance.GetMapperByName("MapperTipoComunicazione")
      Dim Tipo As TipoComunicazione = MapperTipo.FindObjectById(Id_Tipo)





      Dim Id_Offerta As Int32 = IIf(rs("ID_OFFERTA") IsNot Nothing, rs("ID_OFFERTA"), -1)
      Dim MapperOfferta As MapperOffertaLavoro = PersistenceMapperRegistry.Instance.GetMapperByName("MapperOffertaLavoro")
      Dim offerta As OffertaLavoro = MapperOfferta.FindObjectById(Id_Offerta)




      Dim DATA_REGISTRAZIONE As DateTime = IIf(rs("DATA_COMUNICAZIONE") IsNot Nothing, rs("DATA_COMUNICAZIONE"), DateTime.MinValue)
      Dim ALLEGATO As String = IIf(rs("ALLEGATO") IsNot Nothing, rs("ALLEGATO"), "")
      Dim NOTE As String = IIf(rs("NOTE_DOC") IsNot Nothing, rs("NOTE_DOC"), "")

      com.DataDocumento = DATA_REGISTRAZIONE
      com.Note = NOTE
      com.Causale = Causale
      com.Tipo = Tipo
      com.Utente = utente
      com.Allegato = ALLEGATO

      com.Key = Key

      JournalingDataLoader.ReadJournalingParameters(com, rs)
      Return com
   End Function
    'Protected Overrides Function GetCommand(ByVal CommandText As String) As System.Data.IDbCommand

    '   'Return New SqlClient1.SqlCommand(CommandText, DBConnectionManager.Instance.GetCurrentConnection)
    '   Return DBTypeUtils.GetCommand(Me.m_PersistentService.ServiceName, CommandText, DBConnectionManager.Instance.GetCurrentConnection)
    'End Function

#End Region




   Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Dim com As Comunicazione = DirectCast(Item, Comunicazione)

      Dim param As IDbDataParameter = Cmd.CreateParameter
      param.ParameterName = "@IdUt"
      If com.Utente Is Nothing Then
         param.Value = DBNull.Value
      Else
         param.Value = com.Utente.Id
      End If
      Cmd.Parameters.Add(param)


      param = Cmd.CreateParameter
      param.ParameterName = "@IdCau"
      If com.Causale Is Nothing Then
         param.Value = DBNull.Value
      Else
         param.Value = com.Causale.Id
      End If
      Cmd.Parameters.Add(param)



      param = Cmd.CreateParameter
      param.ParameterName = "@Dat"
      If com.DataDocumento = DateTime.MinValue Then
         param.Value = DBNull.Value
      Else
         param.Value = com.DataDocumento
      End If
      Cmd.Parameters.Add(param)



      param = Cmd.CreateParameter
      param.ParameterName = "@All"
      If com.Allegato = "" Then
         param.Value = DBNull.Value
      Else
         param.Value = com.Allegato
      End If
      Cmd.Parameters.Add(param)

      param = Cmd.CreateParameter
      param.ParameterName = "@Not"
      param.Value = com.Note
      Cmd.Parameters.Add(param)

      param = Cmd.CreateParameter
      param.ParameterName = "@IdT"
      param.Value = com.Tipo.Id
      Cmd.Parameters.Add(param)


      JournalingDataLoader.LoadJournalingInsertCommandParameters(Item, Cmd)

   End Sub

   Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)

      Dim com As Comunicazione = DirectCast(Item, Comunicazione)

      Dim param As IDbDataParameter = Cmd.CreateParameter
      param.ParameterName = "@IdUt"
      If com.Utente Is Nothing Then
         param.Value = DBNull.Value
      Else
         param.Value = com.Utente.Id
      End If
      Cmd.Parameters.Add(param)


      param = Cmd.CreateParameter
      param.ParameterName = "@IdCau"
      If com.Causale Is Nothing Then
         param.Value = DBNull.Value
      Else
         param.Value = com.Causale.Id
      End If
      Cmd.Parameters.Add(param)



      param = Cmd.CreateParameter
      param.ParameterName = "@Dat"
      If com.DataDocumento = DateTime.MinValue Then
         param.Value = DBNull.Value
      Else
         param.Value = com.DataDocumento
      End If
      Cmd.Parameters.Add(param)



      param = Cmd.CreateParameter
      param.ParameterName = "@All"
      If com.Allegato = "" Then
         param.Value = DBNull.Value
      Else
         param.Value = com.Allegato
      End If
      Cmd.Parameters.Add(param)

      param = Cmd.CreateParameter
      param.ParameterName = "@Not"
      param.Value = com.Note
      Cmd.Parameters.Add(param)

      param = Cmd.CreateParameter
      param.ParameterName = "@IdT"
      param.Value = com.Tipo.Id
      Cmd.Parameters.Add(param)
      JournalingDataLoader.LoadJournalingUpdateCommandParameters(Item, Cmd)



      param = Cmd.CreateParameter
      param.ParameterName = "@Id"
      param.Value = com.Id
      Cmd.Parameters.Add(param)

   End Sub
End Class
