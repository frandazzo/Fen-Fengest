Public Class MapperOffertaLavoro
   Inherits AbstractRDBMapper


#Region "Istruzioni Sql"

   Protected Overrides Function FindAllStatement() As String
      Return "Select * from DB_Offerta_Lavoro"
   End Function

   Protected Overrides Function FindByKeyStatement() As String
      Return "Select * from DB_Offerta_Lavoro where Id = @Id"
   End Function

   Protected Overrides Function InsertStatement() As String
      Return "Insert into DB_Offerta_Lavoro (ID, ID_AZIENDA, DATA_INIZIO, DATA_FINE, DATA_OFFERTA, NOTE_DOC, CreatedBy, CreatedOn) values (@Id, @IdAz, @Di, @Df, @Dat, @Not, @CRby, @CRon)"
   End Function

   Protected Overrides Function UpdateStatement() As String
      Return "UPDATE DB_Offerta_Lavoro SET Id_Azienda = @IdAz, DATA_INIZIO = @Di, DATA_FINE = @Df, DATA_OFFERTA = @Dat, NOTE_DOC = @Not, ModifiedBy = @MOby, ModifiedOn = @MOon  WHERE (Id =@Id )"
   End Function

   Protected Overrides Function DeleteStatement() As String
      Return "Delete from DB_Offerta_Lavoro where Id = @Id"
   End Function

   Protected Overrides Function FindNextKeyStatement() As String
      Return "Select Max(Id) from DB_Offerta_Lavoro"
   End Function

#End Region


#Region "Metodi per la ricerca dell'oggetto secondo l'id proposto"
   Public Overrides Function FindObjectByIdReloadingCache(ByVal Id As Integer) As AbstractPersistenceObject

      Return DirectCast(MyBase.FindByKeyReloadingCache(New Key(Id)), OffertaLavoro)

   End Function


   Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject

      Return DirectCast(MyBase.FindByKey(New Key(Id)), OffertaLavoro)

   End Function
   Protected Overloads Overrides Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable) As AbstractPersistenceObject
      Dim offerta As New OffertaLavoro

      Dim Id_Azienda As Int32 = IIf(rs("ID_AZIENDA") IsNot Nothing, rs("ID_AZIENDA"), -1)
      Dim MapperAzienda As MapperAzienda = PersistenceMapperRegistry.Instance.GetMapperByName("MapperAzienda")
      Dim azienda As Azienda = MapperAzienda.FindObjectById(Id_Azienda)


      Dim Data As DateTime = IIf(rs.Item("DATA_OFFERTA") IsNot Nothing, rs.Item("DATA_OFFERTA"), DateTime.MinValue)
      Dim Note As String = IIf(rs.Item("NOTE_DOC") IsNot Nothing, rs.Item("NOTE_DOC"), "")

      Dim DI As DateTime = IIf(rs("DATA_INIZIO") IsNot Nothing, rs("DATA_INIZIO"), DateTime.MinValue)
      Dim DF As DateTime = IIf(rs("DATA_FINE") IsNot Nothing, rs("DATA_FINE"), DateTime.MinValue)

      Dim range As New DataRange(DI, DF)

      offerta.Data = Data
      offerta.Note = Note
      offerta.Validita = range
      offerta.AziendaRichiedente = azienda

      Dim virtualList As VirtualLazyList = New LazyLoadOfferteLavoroItem(offerta)
      offerta.Items = virtualList


      offerta.Key = Key

      JournalingDataLoader.ReadJournalingParameters(offerta, rs)
      Return offerta
   End Function
    'Protected Overrides Function GetCommand(ByVal CommandText As String) As System.Data.IDbCommand

    '   'Return New SqlClient1.SqlCommand(CommandText, DBConnectionManager.Instance.GetCurrentConnection)
    '   Return DBTypeUtils.GetCommand(Me.m_PersistentService.ServiceName, CommandText, DBConnectionManager.Instance.GetCurrentConnection)
    'End Function

#End Region




   Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Dim offerta As OffertaLavoro = DirectCast(Item, OffertaLavoro)

      Dim param As IDbDataParameter = Cmd.CreateParameter
      param.ParameterName = "@IdAz"
      If offerta.AziendaRichiedente Is Nothing Then
         param.Value = DBNull.Value
      Else
         param.Value = offerta.AziendaRichiedente.Id
      End If
      Cmd.Parameters.Add(param)

      param = Cmd.CreateParameter
      param.ParameterName = "@Di"
      If offerta.Validita.Start = DateTime.MinValue Then
         param.Value = DBNull.Value
      Else
         param.Value = offerta.Validita.Start
      End If
      Cmd.Parameters.Add(param)


      param = Cmd.CreateParameter
      param.ParameterName = "@Df"
      If offerta.Validita.Finish = DateTime.MinValue Then
         param.Value = DBNull.Value
      Else
         param.Value = offerta.Validita.Finish
      End If
      Cmd.Parameters.Add(param)

      param = Cmd.CreateParameter
      param.ParameterName = "@Dat"
      If offerta.Data = DateTime.MinValue Then
         param.Value = DBNull.Value
      Else
         param.Value = offerta.Data
      End If
      Cmd.Parameters.Add(param)

      param = Cmd.CreateParameter
      param.ParameterName = "@Not"
      param.Value = offerta.Note
      Cmd.Parameters.Add(param)

      JournalingDataLoader.LoadJournalingInsertCommandParameters(Item, Cmd)

   End Sub

   Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)

      Dim offerta As OffertaLavoro = DirectCast(Item, OffertaLavoro)

      Dim param As IDbDataParameter = Cmd.CreateParameter
      param.ParameterName = "@IdAz"
      If offerta.AziendaRichiedente Is Nothing Then
         param.Value = DBNull.Value
      Else
         param.Value = offerta.AziendaRichiedente.Id
      End If
      Cmd.Parameters.Add(param)

      param = Cmd.CreateParameter
      param.ParameterName = "@Di"
      If offerta.Validita.Start = DateTime.MinValue Then
         param.Value = DBNull.Value
      Else
         param.Value = offerta.Validita.Start
      End If
      Cmd.Parameters.Add(param)


      param = Cmd.CreateParameter
      param.ParameterName = "@Df"
      If offerta.Validita.Finish = DateTime.MinValue Then
         param.Value = DBNull.Value
      Else
         param.Value = offerta.Validita.Finish
      End If
      Cmd.Parameters.Add(param)

      param = Cmd.CreateParameter
      param.ParameterName = "@Dat"
      If offerta.Data = DateTime.MinValue Then
         param.Value = DBNull.Value
      Else
         param.Value = offerta.Data
      End If
      Cmd.Parameters.Add(param)

      param = Cmd.CreateParameter
      param.ParameterName = "@Not"
      param.Value = offerta.Note
      Cmd.Parameters.Add(param)

      JournalingDataLoader.LoadJournalingUpdateCommandParameters(Item, Cmd)


      param = Cmd.CreateParameter
      param.ParameterName = "@Id"
      param.Value = offerta.Id
      Cmd.Parameters.Add(param)

   End Sub
End Class
