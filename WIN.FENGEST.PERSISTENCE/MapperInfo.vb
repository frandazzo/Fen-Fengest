Public Class MapperInfo
   Inherits AbstractRDBMapper



#Region "Istruzioni Sql"

   Protected Overrides Function FindAllStatement() As String
      Return "Select * from DB_Infos"
   End Function

   Protected Function FindAllByUserStatement() As String
      Return "Select * from DB_Infos where Id_Utente = @IdUt"
   End Function


   Protected Overrides Function FindByKeyStatement() As String
      Return "Select * from DB_Infos where Id = @Id"
   End Function

   Protected Overrides Function InsertStatement() As String
      Return "Insert into DB_Infos (ID, ID_UTENTE, ID_AZIENDA, DATA_IMPORTAZIONE, LIBERO_AL, LIVELLO, ID_ENTE, ISCRITTO_A) values (@Id, @IdUt, @IdAz, @Dat, @Lal,  @Liv, @IdE, @IsA)"
   End Function

   Protected Overrides Function UpdateStatement() As String
      Return "UPDATE DB_Infos SET ID_UTENTE = @IdUt,  ID_AZIENDA = @IdAz, DATA_IMPORTAZIONE = @Dat, LIBERO_AL = @Lal, LIVELLO = @Liv, ID_ENTE = @IdE, ISCRITTO_A = @IsA WHERE (Id =@Id )"
   End Function

   Protected Overrides Function DeleteStatement() As String
      Return "Delete from DB_Infos where Id = @Id"
   End Function

   Protected Overrides Function FindNextKeyStatement() As String
      Return "Select Max(Id) from DB_Infos"
   End Function

#End Region


   Public Function FindInfoByUtente(ByVal Utente As Utente) As IList
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
      For Each elem As Hashtable In rs
         List.Add(Load(elem, Utente))
      Next
      Return List
   End Function

   Protected Overloads Function Load(ByVal rs As Hashtable, ByVal Utente As Utente, Optional ByVal FindAllForDeletion As Boolean = False) As AbstractPersistenceObject
      Dim key As Key = CreateKey(rs)
      If Cache.GetObjectFromCache(key.ToString) IsNot Nothing Then Return DirectCast(Cache.GetObjectFromCache(key.ToString), AbstractPersistenceObject)
      Dim obj As AbstractPersistenceObject = DoLoad(key, rs, Utente)
      Cache.AddToCache(obj)
      Return obj
   End Function




   Protected Overloads Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable, ByVal Utente As Utente) As AbstractPersistenceObject
      Dim info As New Info
      info.Utente = Utente



      Dim Id_Azienda As Int32 = IIf(rs("ID_AZIENDA") IsNot Nothing, rs("ID_AZIENDA"), -1)
      Dim MapperAzienda As MapperAzienda = PersistenceMapperRegistry.Instance.GetMapperByName("MapperAzienda")
      Dim azienda As Azienda = MapperAzienda.FindObjectById(Id_Azienda)


      Dim Id_ENTE As Int32 = IIf(rs("ID_ENTE") IsNot Nothing, rs("ID_ENTE"), -1)
      Dim MapperEnte As MapperEnteBilaterale = PersistenceMapperRegistry.Instance.GetMapperByName("MapperEnteBilaterale")

      Dim ente As EnteBilaterale = MapperEnte.FindObjectById(Id_ENTE)
      Dim livello As String = IIf(rs("LIVELLO") IsNot Nothing, rs("LIVELLO"), "")

      Dim DATA As DateTime = IIf(rs("DATA_IMPORTAZIONE") IsNot Nothing, rs("DATA_IMPORTAZIONE"), DateTime.MinValue)
      Dim LIBERO As DateTime = IIf(rs("LIBERO_AL") IsNot Nothing, rs("LIBERO_AL"), DateTime.MinValue)
      Dim Priorita As Int32 = IIf(rs("Priorita") IsNot Nothing, rs("Priorita"), 1)

      Dim ISCRITTO_A As String = IIf(rs("ISCRITTO_A") IsNot Nothing, rs("ISCRITTO_A"), "")

      info.IscrittoA = ISCRITTO_A
      info.AziendaImpiego = azienda
      info.DataImportazione = DATA
      info.LiberoAl = LIBERO
      info.Ente = ente
      info.LivelloInquadramento = livello


      info.Key = Key
      Return info
   End Function











#Region "Metodi per la ricerca dell'oggetto secondo l'id proposto"

   Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject

      Return DirectCast(MyBase.FindByKey(New Key(Id)), Info)

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
      Dim info As Info = DirectCast(Item, Info)

      Dim param As IDbDataParameter = Cmd.CreateParameter
      param.ParameterName = "@IdUt"
      param.Value = info.Utente.IdUtente
      Cmd.Parameters.Add(param)


      param = Cmd.CreateParameter
      param.ParameterName = "@IdAz"
      If info.AziendaImpiego Is Nothing Then
         param.Value = DBNull.Value
      Else
         param.Value = info.AziendaImpiego.Id
      End If
      Cmd.Parameters.Add(param)


      param = Cmd.CreateParameter
      param.ParameterName = "@Dat"
      If info.DataImportazione = DateTime.MinValue Then
         param.Value = DBNull.Value
      Else
         param.Value = info.DataImportazione
      End If
      Cmd.Parameters.Add(param)



      param = Cmd.CreateParameter
      param.ParameterName = "@Lal"
      If info.LiberoAl = DateTime.MinValue Then
         param.Value = DBNull.Value
      Else
         param.Value = info.LiberoAl
      End If
      Cmd.Parameters.Add(param)



      param = Cmd.CreateParameter
      param.ParameterName = "@Liv"
      If info.LivelloInquadramento Is Nothing Then
         param.Value = DBNull.Value
      Else
         param.Value = info.LivelloInquadramento
      End If
      Cmd.Parameters.Add(param)

      param = Cmd.CreateParameter
      param.ParameterName = "@IdE"
      If info.Ente Is Nothing Then
         param.Value = DBNull.Value
      Else
         param.Value = info.Ente.Id
      End If
      Cmd.Parameters.Add(param)



      param = Cmd.CreateParameter
      param.ParameterName = "@IsA"
      param.Value = info.IscrittoA
      Cmd.Parameters.Add(param)


   End Sub

   Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)

      Dim info As Info = DirectCast(Item, Info)

      Dim param As IDbDataParameter = Cmd.CreateParameter
      param.ParameterName = "@IdUt"
      param.Value = info.Utente.IdUtente
      Cmd.Parameters.Add(param)


      param = Cmd.CreateParameter
      param.ParameterName = "@IdAz"
      If info.AziendaImpiego Is Nothing Then
         param.Value = DBNull.Value
      Else
         param.Value = info.AziendaImpiego.Id
      End If
      Cmd.Parameters.Add(param)


      param = Cmd.CreateParameter
      param.ParameterName = "@Dat"
      If info.DataImportazione = DateTime.MinValue Then
         param.Value = DBNull.Value
      Else
         param.Value = info.DataImportazione
      End If
      Cmd.Parameters.Add(param)



      param = Cmd.CreateParameter
      param.ParameterName = "@Lal"
      If info.LiberoAl = DateTime.MinValue Then
         param.Value = DBNull.Value
      Else
         param.Value = info.LiberoAl
      End If
      Cmd.Parameters.Add(param)



      param = Cmd.CreateParameter
      param.ParameterName = "@Liv"
      If info.LivelloInquadramento Is Nothing Then
         param.Value = DBNull.Value
      Else
         param.Value = info.LivelloInquadramento
      End If
      Cmd.Parameters.Add(param)

      param = Cmd.CreateParameter
      param.ParameterName = "@IdE"
      If info.Ente Is Nothing Then
         param.Value = DBNull.Value
      Else
         param.Value = info.Ente.Id
      End If
      Cmd.Parameters.Add(param)


      param = Cmd.CreateParameter
      param.ParameterName = "@IsA"
      param.Value = info.IscrittoA
      Cmd.Parameters.Add(param)

      param = Cmd.CreateParameter
      param.ParameterName = "@Id"
      param.Value = info.Id
      Cmd.Parameters.Add(param)

   End Sub
End Class
