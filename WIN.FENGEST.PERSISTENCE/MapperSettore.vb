Public Class MapperSettore
   Inherits AbstractRDBMapper



#Region "Istruzioni Sql"

   Protected Overrides Function FindAllStatement() As String
      Return "Select * from DB_SETTORE"
   End Function

   Protected Overrides Function FindByKeyStatement() As String
      Return "Select * from DB_SETTORE where Id = @Id"
   End Function

   Protected Overrides Function InsertStatement() As String
      Return "Insert into DB_SETTORE (ID, DESCRIZIONE, TIPO_SETTORE) values (@Id, @Desc, @Tip)"
   End Function

   Protected Overrides Function UpdateStatement() As String
      Return "UPDATE DB_SETTORE SET Descrizione = @Desc, TIPO_SETTORE = @Tip WHERE (Id =@Id )"
   End Function

   Protected Overrides Function DeleteStatement() As String
      Return "Delete from DB_SETTORE where Id = @Id"
   End Function

   Protected Overrides Function FindNextKeyStatement() As String
      Return "Select Max(Id) from DB_SETTORE"
   End Function


   Protected Function FindContrattiForSettoreStatement() As String
      Return "SELECT DB_TIPO_CONTRATTO.*, DB_CONTRATTI_SETTORE.* " _
            & "FROM DB_CONTRATTI_SETTORE " _
            & "INNER JOIN DB_TIPO_CONTRATTO ON DB_CONTRATTI_SETTORE.ID_TIPO_CONTRATTO = DB_TIPO_CONTRATTO.ID " _
            & " WHERE DB_CONTRATTI_SETTORE.ID_SETTORE = @Id"
   End Function
#End Region


#Region "Metodi per la ricerca dell'oggetto secondo l'id proposto"

   Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject
      Try
         Return DirectCast(MyBase.FindByKey(New Key(Id)), Settore)
      Catch ex As Exception
         Throw New Exception(ex.Message)
      End Try

   End Function
   Protected Overloads Overrides Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable) As AbstractPersistenceObject
      Try
         Dim Settore As New Settore(rs.Item("DESCRIZIONE"), rs.Item("TIPO_SETTORE"))
         Settore.Key = Key
         'Settore.SetListaContrattiApplicati(LoadContratti(Settore))
         Return Settore
      Catch ex As Exception
         Throw New Exception("Impossibile caricare l'oggetto settore con Id = " & Key.LongValue & ". " & vbCrLf & ex.Message)
      End Try
   End Function


#Region "Metodi per la ricerca dell'associazione tra contratti e settore"
   Private Function LoadContratti(ByVal Settore As Settore) As ArrayList
      Dim rs As IDataReader = Nothing
      Dim Datalist As IList
      Dim lista As IList = New ArrayList
      Try
         Dim cmd As OleDb.OleDbCommand = PrepareCommandForContratti(Settore.Id)
         rs = cmd.ExecuteReader
         Datalist = Me.LoadDataMatrix(rs)
         rs.Close()
         For Each elem As Hashtable In Datalist
            lista.Add(DirectCast(PersistenceMapperRegistry.Instance.GetMapperByName("MapperContratto"), MapperContratto).LoadContratto(Settore, elem))
         Next
         Return lista
      Catch ex As Exception
         Throw New ApplicationException("Impossibile caricare la lista di tutti gli oggetti contratto. " & vbCrLf & ex.Message)
      Finally
         ReleaseDBDatareader(rs)
         Datalist = New ArrayList
      End Try
   End Function
   Private Function PrepareCommandForContratti(ByVal Id As Int32) As IDbCommand
      Try
         Dim cmd As OleDb.OleDbCommand = GetCommand(FindContrattiForSettoreStatement)
         LoadSimpleFindParameter(cmd, Id)
         Return cmd
      Catch ex As Exception
         Throw New Exception(ex.Message)
      End Try
   End Function
   Private Sub LoadSimpleFindParameter(ByVal cmd As IDbCommand, ByVal Id As Int32)
      Try
         Dim param As IDataParameter = cmd.CreateParameter
         param.ParameterName = "@Id"
         param.Value = Id
         cmd.Parameters.Add(param)
      Catch ex As Exception
         Throw New Exception(ex.Message)
      End Try
   End Sub

#End Region


    'Protected Overrides Function GetCommand(ByVal CommandText As String) As System.Data.IDbCommand

    '   'Return New SqlClient1.SqlCommand(CommandText, DBConnectionManager.Instance.GetCurrentConnection)
    '   Return DBTypeUtils.GetCommand(Me.m_PersistentService.ServiceName, CommandText, DBConnectionManager.Instance.GetCurrentConnection)

    'End Function

#End Region




   Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Try
         Dim settore As Settore = DirectCast(Item, Settore)

         Dim param As IDbDataParameter = Cmd.CreateParameter
         param.ParameterName = "@Desc"
         param.Value = settore.Descrizione
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Tip"
         param.Value = settore.TipologiaSettore
         Cmd.Parameters.Add(param)

      Catch ex As Exception
         Throw New Exception("Impossibile caricare il comando di inserimento dell'oggetto settore." & vbCrLf & ex.Message)
      End Try
   End Sub

   Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Try
         Dim settore As Settore = DirectCast(Item, Settore)

         Dim param As IDbDataParameter = Cmd.CreateParameter
         param.ParameterName = "@Desc"
         param.Value = settore.Descrizione
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Tip"
         param.Value = settore.TipologiaSettore
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Id"
         param.Value = settore.Id
         Cmd.Parameters.Add(param)

      Catch ex As Exception
         Throw New Exception("Impossibile caricare il comando di aggiornamento dell'oggetto settore." & vbCrLf & ex.Message)
      End Try
   End Sub





End Class
