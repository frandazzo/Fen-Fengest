Public Class MapperWordTagger
   Inherits AbstractRDBMapper



#Region "Istruzioni Sql"

   Protected Overrides Function FindAllStatement() As String
      Return "Select * from DB_TAGS"
   End Function

   Protected Overrides Function FindByKeyStatement() As String
      Return "Select * from DB_TAGS where Id = @Id"
   End Function

   Protected Overrides Function InsertStatement() As String
      Return "Insert into DB_TAGS (ID, CAMPO, VALORE_TAG, NOME_PROPRIETA, TIPO) values (@Id, @Cam, @Val, @Nom, @Tip)"
   End Function

   Protected Overrides Function UpdateStatement() As String
      Return "UPDATE DB_TAGS SET CAMPO = @Cam, VALORE_TAG = @Val, NOME_PROPRIETA = @Nom, TIPO = @Tip WHERE (Id =@Id )"
   End Function

   Protected Overrides Function DeleteStatement() As String
      Return "Delete from DB_TAGS where Id = @Id"
   End Function

   Protected Overrides Function FindNextKeyStatement() As String
      Return "Select Max(Id) from DB_TAGS"
   End Function

#End Region


#Region "Metodi per la ricerca dell'oggetto secondo l'id proposto"

   Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject
      Return DirectCast(MyBase.FindByKey(New Key(Id)), WordTagger)
   End Function
   Protected Overloads Overrides Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable) As AbstractPersistenceObject
      Try
         Dim tagger As New WordTagger
         tagger.Key = Key

         Dim Campo As String = IIf(rs.Item("CAMPO") IsNot Nothing, rs.Item("CAMPO"), "")
         Dim Valore_Tag As String = IIf(rs.Item("VALORE_TAG") IsNot Nothing, rs.Item("VALORE_TAG"), "")
         Dim Nome_Proprieta As String = IIf(rs.Item("NOME_PROPRIETA") IsNot Nothing, rs.Item("NOME_PROPRIETA"), "")
         Dim TIPO As Int32 = IIf(rs.Item("TIPO") IsNot Nothing, rs.Item("TIPO"), 1)

         tagger.Campo = Campo
         tagger.ValoreTag = Valore_Tag
         tagger.NomeProprieta = Nome_Proprieta
         tagger.Tipo = TIPO

         Return tagger
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

      Dim Tagger As WordTagger = DirectCast(Item, WordTagger)

      Dim param As IDbDataParameter = Cmd.CreateParameter
      param.ParameterName = "@Cam"
      param.Value = Tagger.Campo
      Cmd.Parameters.Add(param)

      param = Cmd.CreateParameter
      param.ParameterName = "@Val"
      param.Value = Tagger.ValoreTag
      Cmd.Parameters.Add(param)


      param = Cmd.CreateParameter
      param.ParameterName = "@Nom"
      param.Value = Tagger.NomeProprieta
      Cmd.Parameters.Add(param)


      param = Cmd.CreateParameter
      param.ParameterName = "@Tip"
      param.Value = Tagger.Tipo
      Cmd.Parameters.Add(param)



   End Sub

   Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Dim Tagger As WordTagger = DirectCast(Item, WordTagger)

      Dim param As IDbDataParameter = Cmd.CreateParameter
      param.ParameterName = "@Cam"
      param.Value = Tagger.Campo
      Cmd.Parameters.Add(param)

      param = Cmd.CreateParameter
      param.ParameterName = "@Val"
      param.Value = Tagger.ValoreTag
      Cmd.Parameters.Add(param)


      param = Cmd.CreateParameter
      param.ParameterName = "@Nom"
      param.Value = Tagger.NomeProprieta
      Cmd.Parameters.Add(param)


      param = Cmd.CreateParameter
      param.ParameterName = "@Tip"
      param.Value = Tagger.Tipo
      Cmd.Parameters.Add(param)

      param = Cmd.CreateParameter
      param.ParameterName = "@Id"
      param.Value = Tagger.Id
      Cmd.Parameters.Add(param)


   End Sub

End Class
