Public Class MapperKnowHow
   Inherits AbstractRDBMapper



#Region "Istruzioni Sql"

   Protected Overrides Function FindAllStatement() As String
      Return "Select * from DB_Attitudini"
   End Function

   Protected Function FindAllByUserStatement() As String
      Return "Select * from DB_Attitudini where Id_Utente = @IdUt"
   End Function


   Protected Overrides Function FindByKeyStatement() As String
      Return "Select * from DB_Attitudini where Id = @Id"
   End Function

   Protected Overrides Function InsertStatement() As String
      Return "Insert into DB_Attitudini (ID, ID_UTENTE, ID_LIVELLO_ABILITA, ID_ABILITA, NOTES) values (@Id, @IdUt, @IdLa, @IdAb, @Not)"
   End Function

   Protected Overrides Function UpdateStatement() As String
      Return "UPDATE DB_Attitudini SET ID_UTENTE = @IdUt, ID_LIVELLO_ABILITA = @IdLa, ID_ABILITA = @IdAb, NOTES = @Not WHERE (Id =@Id )"
   End Function

   Protected Overrides Function DeleteStatement() As String
      Return "Delete from DB_Attitudini where Id = @Id"
   End Function

   Protected Overrides Function FindNextKeyStatement() As String
      Return "Select Max(Id) from DB_Attitudini"
   End Function

#End Region


   Public Function FindAttitudiniByUtente(ByVal Utente As Utente) As IList
      Dim rs As IDataReader = Nothing
      Dim Datalist As IList
      Dim Lista As IList
      Try
            If m_PersistentService.CurrentConnection.State = ConnectionState.Open Then m_PersistentService.CurrentConnection.Close()
            m_PersistentService.CurrentConnection.Open()

         Dim cmd As IDbCommand = GetCommand(FindAllByUserStatement)
         Dim param As IDataParameter = cmd.CreateParameter
         param.ParameterName = "@IdUt"
         param.Value = Utente.IdUtente
         cmd.Parameters.Add(param)
         rs = cmd.ExecuteReader
         Datalist = Me.LoadDataMatrix(rs)
         rs.Close()
         Lista = LoadAll(Datalist, Utente)

            m_PersistentService.CurrentConnection.Close()
         'RipristinaRiferimentoCircolareCon(Utente, Lista)
         Return Lista
      Catch ex As Exception
         Throw
      Finally
         ReleaseDBDatareader(rs)
         Datalist = New ArrayList
            If m_PersistentService.CurrentConnection.State = ConnectionState.Open Then m_PersistentService.CurrentConnection.Close()
      End Try
   End Function


   Protected Overloads Function LoadAll(ByVal rs As IList, ByVal Utente As Utente) As IList
      Dim List As New ArrayList
      Try
         For Each elem As Hashtable In rs
            List.Add(Load(elem, Utente))
         Next
         Return List
      Catch ex As Exception
         Throw New Exception(ex.Message)
      End Try
   End Function

   Protected Overloads Function Load(ByVal rs As Hashtable, ByVal Utente As Utente, Optional ByVal FindAllForDeletion As Boolean = False) As AbstractPersistenceObject
      Dim key As Key = CreateKey(rs)
      If Cache.GetObjectFromCache(key.ToString) IsNot Nothing Then Return DirectCast(Cache.GetObjectFromCache(key.ToString), AbstractPersistenceObject)
      Dim obj As AbstractPersistenceObject = DoLoad(key, rs, Utente)
      Cache.AddToCache(obj)
      Return obj
   End Function




   Protected Overloads Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable, ByVal Utente As Utente) As AbstractPersistenceObject
      Dim attitudine As New KnowHow
      attitudine.Utente = Utente


      Dim Id_Livello As Int32 = IIf(rs("ID_LIVELLO_ABILITA") IsNot Nothing, rs("ID_LIVELLO_ABILITA"), -1)
      Dim Id_Abilita As Int32 = IIf(rs("ID_ABILITA") IsNot Nothing, rs("ID_ABILITA"), -1)
      Dim MapperAbilita As MapperAbilita = PersistenceMapperRegistry.Instance.GetMapperByName("MapperAbilita")
      Dim MapperLivelloAbilita As MapperLivelloAbilita = PersistenceMapperRegistry.Instance.GetMapperByName("MapperLivelloAbilita")
      Dim abilita As Abilita = MapperAbilita.FindObjectById(Id_Abilita)
      Dim livello As LivelloAbilita = MapperLivelloAbilita.FindObjectById(Id_Livello)

      Dim note As String = IIf(rs("NOTES") IsNot Nothing, rs("NOTES"), "")

      attitudine.Livello = livello
      attitudine.Abilita = abilita
      attitudine.Note = note
      attitudine.Key = Key
      Return attitudine
   End Function











#Region "Metodi per la ricerca dell'oggetto secondo l'id proposto"

   Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject

      Return DirectCast(MyBase.FindByKey(New Key(Id)), KnowHow)

   End Function
   Protected Overloads Overrides Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable) As AbstractPersistenceObject
      Throw New NotImplementedException()
   End Function
    'Protected Overrides Function GetCommand(ByVal CommandText As String) As System.Data.IDbCommand

    '   'Return New SqlClient1.SqlCommand(CommandText, DBConnectionManager.Instance.GetCurrentConnection)
    '   Return DBTypeUtils.GetCommand(Me.m_PersistentService.ServiceName, CommandText, DBConnectionManager.Instance.GetCurrentConnection)
    'End Function

#End Region










   Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Dim attitudine As KnowHow = DirectCast(Item, KnowHow)

      Dim param As IDbDataParameter = Cmd.CreateParameter
      param.ParameterName = "@IdUt"
      param.Value = attitudine.Utente.IdUtente
      Cmd.Parameters.Add(param)


      param = Cmd.CreateParameter
      param.ParameterName = "@IdLa"
      If attitudine.Livello Is Nothing Then
         param.Value = DBNull.Value
      Else
         param.Value = attitudine.Livello.Id
      End If
      Cmd.Parameters.Add(param)


      param = Cmd.CreateParameter
      param.ParameterName = "@IdAb"
      If attitudine.Abilita Is Nothing Then
         param.Value = DBNull.Value
      Else
         param.Value = attitudine.Abilita.Id
      End If
      Cmd.Parameters.Add(param)

      param = Cmd.CreateParameter
      param.ParameterName = "@Not"
      param.Value = attitudine.Note
      Cmd.Parameters.Add(param)


   End Sub

   Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)

      Dim attitudine As KnowHow = DirectCast(Item, KnowHow)

      Dim param As IDbDataParameter = Cmd.CreateParameter
      param.ParameterName = "@IdUt"
      param.Value = attitudine.Utente.IdUtente
      Cmd.Parameters.Add(param)


      param = Cmd.CreateParameter
      param.ParameterName = "@IdLa"
      If attitudine.Livello Is Nothing Then
         param.Value = DBNull.Value
      Else
         param.Value = attitudine.Livello.Id
      End If
      Cmd.Parameters.Add(param)


      param = Cmd.CreateParameter
      param.ParameterName = "@IdAb"
      If attitudine.Abilita Is Nothing Then
         param.Value = DBNull.Value
      Else
         param.Value = attitudine.Abilita.Id
      End If
      Cmd.Parameters.Add(param)

      param = Cmd.CreateParameter
      param.ParameterName = "@Not"
      param.Value = attitudine.Note
      Cmd.Parameters.Add(param)


      param = Cmd.CreateParameter
      param.ParameterName = "@Id"
      param.Value = attitudine.Id
      Cmd.Parameters.Add(param)

   End Sub

End Class
