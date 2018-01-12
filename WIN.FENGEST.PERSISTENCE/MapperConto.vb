Public Class MapperConto
   Inherits AbstractRDBMapper



#Region "Istruzioni Sql"

   Protected Overrides Function FindAllStatement() As String
      Return "Select * from DB_CONTO"
   End Function

   Protected Overrides Function FindByKeyStatement() As String
      Return "Select * from DB_CONTO where Id = @Id"
   End Function

   Protected Overrides Function InsertStatement() As String
      Return "Insert into DB_CONTO (ID, DESCRIZIONE, VALUTA, TIPO_CONTO) values (@Id, @Desc, @Val, @Tip)"
   End Function

   Protected Overrides Function UpdateStatement() As String
      Return "UPDATE DB_CONTO SET Descrizione = @Desc, Valuta = @Val, TIPO_CONTO = @Tip WHERE (Id =@Id )"
   End Function

   Protected Overrides Function DeleteStatement() As String
      Return "Delete from DB_CONTO where Id = @Id"
   End Function

   Protected Overrides Function FindNextKeyStatement() As String
      Return "Select Max(Id) from DB_CONTO"
   End Function

#End Region


#Region "Metodi per la ricerca dell'oggetto secondo l'id proposto"

   Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject
      Try
         Return DirectCast(MyBase.FindByKey(New Key(Id)), Conto)
      Catch ex As Exception
         Throw New Exception(ex.Message)
      End Try

   End Function
   Protected Overloads Overrides Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable) As AbstractPersistenceObject
      Try
         Dim conto As New Conto(rs.Item("DESCRIZIONE"), rs.Item("VALUTA"), DirectCast(rs.Item("TIPO_CONTO"), Conto.TipoConto))
         conto.Key = Key
         Dim VirtualList As LazyLoadPosizioniConto = New LazyLoadPosizioniConto(conto)
         conto.SetItemList(VirtualList)
         Return conto
      Catch ex As Exception
         Throw New Exception("Impossibile caricare l'oggetto conto con Id = " & Key.LongValue & ". " & vbCrLf & ex.Message)
      End Try
   End Function
    'Protected Overrides Function GetCommand(ByVal CommandText As String) As System.Data.IDbCommand

    '   'Return New SqlClient1.SqlCommand(CommandText, DBConnectionManager.Instance.GetCurrentConnection)
    '   Return DBTypeUtils.GetCommand(Me.m_PersistentService.ServiceName, CommandText, DBConnectionManager.Instance.GetCurrentConnection)
    'End Function

#End Region




   Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Try
         Dim Conto As Conto = DirectCast(Item, Conto)

         Dim param As IDbDataParameter = Cmd.CreateParameter
         param.ParameterName = "@Desc"
         param.Value = Conto.Descrizione
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Val"
         param.Value = Conto.Valuta
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Tip"
         param.Value = Conto.TipologiaConto
         Cmd.Parameters.Add(param)


      Catch ex As Exception
         Throw New Exception("Impossibile caricare il comando di inserimento dell'oggetto conto." & vbCrLf & ex.Message)
      End Try
   End Sub

   Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Try
         Dim Conto As Conto = DirectCast(Item, Conto)

         Dim param As IDbDataParameter = Cmd.CreateParameter
         param.ParameterName = "@Desc"
         param.Value = Conto.Descrizione
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Val"
         param.Value = Conto.Valuta
         Cmd.Parameters.Add(param)


         param = Cmd.CreateParameter
         param.ParameterName = "@Tip"
         param.Value = Conto.TipologiaConto
         Cmd.Parameters.Add(param)

         param = Cmd.CreateParameter
         param.ParameterName = "@Id"
         param.Value = Conto.IdConto
         Cmd.Parameters.Add(param)

      Catch ex As Exception
         Throw New Exception("Impossibile caricare il comando di aggiornamento dell'oggetto conto." & vbCrLf & ex.Message)
      End Try
   End Sub




End Class
