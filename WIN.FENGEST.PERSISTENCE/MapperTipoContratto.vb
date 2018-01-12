Public Class MapperTipoContratto


   Inherits AbstractRDBMapper



#Region "Istruzioni Sql"

   Protected Overrides Function FindAllStatement() As String
      Return "Select * from DB_TIPO_CONTRATTO"
   End Function

   Protected Overrides Function FindByKeyStatement() As String
      Return "Select * from DB_TIPO_CONTRATTO where Id = @Id"
   End Function

   Protected Overrides Function InsertStatement() As String
      Return "Insert into DB_TIPO_CONTRATTO (ID, DESCRIZIONE, SETTORE_SPECIFICO, DI_VALIDITA_ECONOMICA, DF_VALIDITA_ECONOMICA, DI_VALIDITA_NORMATIVA, DF_VALIDITA_NORMATIVA, CreatedBy, CreatedOn) values (@Id, @Desc, @Tip, @dive, @dfve, @divn, @dfvn, @CRby, @CRon)"
   End Function

   Protected Overrides Function UpdateStatement() As String
      Return "UPDATE DB_TIPO_CONTRATTO SET Descrizione = @Desc, SETTORE_SPECIFICO = @Tip, DI_VALIDITA_ECONOMICA = @dive, DF_VALIDITA_ECONOMICA = @dfve, DI_VALIDITA_NORMATIVA = @divn, DF_VALIDITA_NORMATIVA = @dfvn, ModifiedBy = @MOby, ModifiedOn = @MOon    WHERE (Id =@Id )"
   End Function

   Protected Overrides Function DeleteStatement() As String
      Return "Delete from DB_TIPO_CONTRATTO where Id = @Id"
   End Function

   Protected Overrides Function FindNextKeyStatement() As String
      Return "Select Max(Id) from DB_TIPO_CONTRATTO"
   End Function

#End Region


#Region "Metodi per la ricerca dell'oggetto secondo l'id proposto"

   Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject

      Return DirectCast(MyBase.FindByKey(New Key(Id)), TipoContratto)


   End Function
   Protected Overloads Overrides Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable) As AbstractPersistenceObject
      Try
         Dim IdSettore As Int32 = IIf(rs.Item("SETTORE_SPECIFICO") IsNot Nothing, rs.Item("SETTORE_SPECIFICO"), -1)
         Dim mappersettori As MapperSettore = PersistenceMapperRegistry.Instance.GetMapperByName("MapperSettore")
         Dim settore As Settore = mappersettori.FindObjectById(IdSettore)
         Dim TipoCon As TipoContratto = New TipoContratto(rs.Item("DESCRIZIONE"), settore)

         Dim dive As DateTime = IIf(rs.Item("DI_VALIDITA_ECONOMICA") IsNot Nothing, rs.Item("DI_VALIDITA_ECONOMICA"), Today)
         Dim dfve As DateTime = IIf(rs.Item("DF_VALIDITA_ECONOMICA") IsNot Nothing, rs.Item("DF_VALIDITA_ECONOMICA"), Today)
         Dim divn As DateTime = IIf(rs.Item("DI_VALIDITA_NORMATIVA") IsNot Nothing, rs.Item("DI_VALIDITA_NORMATIVA"), Today)
         Dim dfvn As DateTime = IIf(rs.Item("DF_VALIDITA_NORMATIVA") IsNot Nothing, rs.Item("DF_VALIDITA_NORMATIVA"), Today)

         TipoCon.ValiditaEconomica = New DataRange(dive, dfve)
         TipoCon.ValiditaNormativa = New DataRange(divn, dfvn)



         TipoCon.Key = Key


         JournalingDataLoader.ReadJournalingParameters(TipoCon, rs)


         Return TipoCon
      Catch ex As Exception
         Throw New Exception("Impossibile caricare l'oggetto tipo contratto con Id = " & Key.LongValue & ". " & vbCrLf & ex.Message)
      End Try
   End Function
    'Protected Overrides Function GetCommand(ByVal CommandText As String) As System.Data.IDbCommand

    '   'Return New SqlClient1.SqlCommand(CommandText, DBConnectionManager.Instance.GetCurrentConnection)
    '   Return DBTypeUtils.GetCommand(Me.m_PersistentService.ServiceName, CommandText, DBConnectionManager.Instance.GetCurrentConnection)

    'End Function

#End Region




   Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Try
         Dim contratto As TipoContratto = DirectCast(Item, TipoContratto)

         Dim param As IDbDataParameter = Cmd.CreateParameter
         param.ParameterName = "@Desc"
         param.Value = contratto.Descrizione
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Tip"
         param.Value = contratto.SettoreSpecifico.Id
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@dive"
         param.Value = contratto.ValiditaEconomica.Start
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@dfve"
         param.Value = contratto.ValiditaEconomica.Finish
         Cmd.Parameters.Add(param)



         param = Cmd.CreateParameter
         param.ParameterName = "@divn"
         param.Value = contratto.ValiditaNormativa.Start
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@dfvn"
         param.Value = contratto.ValiditaNormativa.Finish
         Cmd.Parameters.Add(param)
         JournalingDataLoader.LoadJournalingInsertCommandParameters(Item, Cmd)
      Catch ex As Exception
         Throw New Exception("Impossibile caricare il comando di inserimento dell'oggetto contratto." & vbCrLf & ex.Message)
      End Try
   End Sub

   Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Try
         Dim contratto As TipoContratto = DirectCast(Item, TipoContratto)

         Dim param As IDbDataParameter = Cmd.CreateParameter
         param.ParameterName = "@Desc"
         param.Value = contratto.Descrizione
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Tip"
         param.Value = contratto.SettoreSpecifico.Id
         Cmd.Parameters.Add(param)



         param = Cmd.CreateParameter
         param.ParameterName = "@dive"
         param.Value = contratto.ValiditaEconomica.Start
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@dfve"
         param.Value = contratto.ValiditaEconomica.Finish
         Cmd.Parameters.Add(param)



         param = Cmd.CreateParameter
         param.ParameterName = "@divn"
         param.Value = contratto.ValiditaNormativa.Start
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@dfvn"
         param.Value = contratto.ValiditaNormativa.Finish
         Cmd.Parameters.Add(param)

         JournalingDataLoader.LoadJournalingUpdateCommandParameters(Item, Cmd)

         param = Cmd.CreateParameter
         param.ParameterName = "@Id"
         param.Value = contratto.Id
         Cmd.Parameters.Add(param)


      Catch ex As Exception
         Throw New Exception("Impossibile caricare il comando di aggiornamento dell'oggetto contratto." & vbCrLf & ex.Message)
      End Try
   End Sub



End Class
