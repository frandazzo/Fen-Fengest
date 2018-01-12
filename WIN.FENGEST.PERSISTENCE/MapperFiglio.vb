Public Class MapperFiglio
   Inherits AbstractRDBMapper



#Region "Istruzioni Sql"

   Protected Overrides Function FindAllStatement() As String
      Return "Select * from DB_FIGLI"
   End Function

   Protected Function FindAllByUserStatement() As String
      Return "Select * from DB_FIGLI where Id_Utente = @IdUt"
   End Function


   Protected Overrides Function FindByKeyStatement() As String
      Return "Select * from DB_FIGLI where Id = @Id"
   End Function

   Protected Overrides Function InsertStatement() As String
      Return "Insert into DB_FIGLI (ID, ID_UTENTE, DATA_NASCITA, SCUOLA, ANNO_FREQUENZA, NOME_FIGLIO, COGNOME_FIGLIO , CF_FIGLIO) values (@Id, @IdUt, @Dat, @Sc, @An, @NomF, @CogF, @CfF)"
   End Function

   Protected Overrides Function UpdateStatement() As String
      Return "UPDATE DB_FIGLI SET ID_UTENTE = @IdUt,   DATA_NASCITA = @Dat, SCUOLA = @Sc, ANNO_FREQUENZA = @An, NOME_FIGLIO = @NomF, COGNOME_FIGLIO = @CogF, CF_FIGLIO = @CfF  WHERE (Id =@Id )"
   End Function

   Protected Overrides Function DeleteStatement() As String
      Return "Delete from DB_FIGLI where Id = @Id"
   End Function

   Protected Overrides Function FindNextKeyStatement() As String
      Return "Select Max(Id) from DB_FIGLI"
   End Function

#End Region


   Public Function FindFigliByUtente(ByVal Utente As Utente) As IList
      Dim rs As IDataReader = Nothing
      Dim Datalist As IList
      Dim Lista As IList
      Dim connectionExternallyOpened As Boolean = False
      Try

            If m_PersistentService.CurrentConnection.State = ConnectionState.Open Then
                connectionExternallyOpened = True
                'DBConnectionManager.Instance.GetCurrentConnection.Close()
            Else
                m_PersistentService.CurrentConnection.Open()
            End If



         Dim cmd As IDbCommand = GetCommand(FindAllByUserStatement)
         Dim param As IDataParameter = cmd.CreateParameter
         param.ParameterName = "@IdUt"
         param.Value = Utente.IdUtente
         cmd.Parameters.Add(param)
         rs = cmd.ExecuteReader
         Datalist = Me.LoadDataMatrix(rs)
         rs.Close()
         Lista = LoadAll(Datalist, Utente)

         If connectionExternallyOpened = False Then
                m_PersistentService.CurrentConnection.Close()
         End If

         'RipristinaRiferimentoCircolareCon(Utente, Lista)
         Return Lista
      Catch ex As Exception
         Throw
      Finally
         ReleaseDBDatareader(rs)
         Datalist = New ArrayList
         If connectionExternallyOpened = False Then
                If m_PersistentService.CurrentConnection.State = ConnectionState.Open Then m_PersistentService.CurrentConnection.Close()
         End If
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
      Dim figlio As New Figlio(Utente)






      Dim DATA As DateTime = IIf(rs("DATA_NASCITA") IsNot Nothing, rs("DATA_NASCITA"), DateTime.MinValue)
      Dim scuola As String = IIf(rs("SCUOLA") IsNot Nothing, rs("SCUOLA"), "")

      Dim anno As String = IIf(rs("ANNO_FREQUENZA") IsNot Nothing, rs("ANNO_FREQUENZA"), "")



      Dim nome As String = IIf(rs("NOME_FIGLIO") IsNot Nothing, rs("NOME_FIGLIO"), "")
      Dim cognome As String = IIf(rs("COGNOME_FIGLIO") IsNot Nothing, rs("COGNOME_FIGLIO"), "")
      Dim cf As String = IIf(rs("CF_FIGLIO") IsNot Nothing, rs("CF_FIGLIO"), "")



      figlio.Nome = nome
      figlio.Cognome = cognome
      figlio.CodiceFiscale = cf
      figlio.DataNascita = DATA
      figlio.AnnoFrequenza = anno
      figlio.Scuola = scuola
      figlio.Key = Key
      Return figlio
   End Function











#Region "Metodi per la ricerca dell'oggetto secondo l'id proposto"

   Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject

      Return DirectCast(MyBase.FindByKey(New Key(Id)), Figlio)

   End Function
   Protected Overloads Overrides Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable) As AbstractPersistenceObject
      Throw New NotImplementedException()
   End Function
    'Protected Overrides Function GetCommand(ByVal CommandText As String) As System.Data.IDbCommand

    '   ' Return New SqlClient1.SqlCommand(CommandText, DBConnectionManager.Instance.GetCurrentConnection)
    '   Return DBTypeUtils.GetCommand(Me.m_PersistentService.ServiceName, CommandText, DBConnectionManager.Instance.GetCurrentConnection)

    'End Function

#End Region










   Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      Dim Figlio As Figlio = DirectCast(Item, Figlio)

      Dim param As IDbDataParameter = Cmd.CreateParameter
      param.ParameterName = "@IdUt"
      param.Value = Figlio.Utente.IdUtente
      Cmd.Parameters.Add(param)




      param = Cmd.CreateParameter
      param.ParameterName = "@Dat"
      If Figlio.DataNascita = DateTime.MinValue Then
         param.Value = DBNull.Value
      Else
         param.Value = Figlio.DataNascita
      End If
      Cmd.Parameters.Add(param)


      param = Cmd.CreateParameter
      param.ParameterName = "@Sc"
      param.Value = Figlio.Scuola
      Cmd.Parameters.Add(param)


      param = Cmd.CreateParameter
      param.ParameterName = "@An"
      param.Value = Figlio.AnnoFrequenza
      Cmd.Parameters.Add(param)



      param = Cmd.CreateParameter
      param.ParameterName = "@NomF"
      param.Value = Figlio.Nome
      Cmd.Parameters.Add(param)



      param = Cmd.CreateParameter
      param.ParameterName = "@CogF"
      param.Value = Figlio.Cognome
      Cmd.Parameters.Add(param)



      param = Cmd.CreateParameter
      param.ParameterName = "@CfF"
      param.Value = Figlio.CodiceFiscale
      Cmd.Parameters.Add(param)


   End Sub

   Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)

      Dim Figlio As Figlio = DirectCast(Item, Figlio)

      Dim param As IDbDataParameter = Cmd.CreateParameter
      param.ParameterName = "@IdUt"
      param.Value = Figlio.Utente.IdUtente
      Cmd.Parameters.Add(param)




      param = Cmd.CreateParameter
      param.ParameterName = "@Dat"
      If Figlio.DataNascita = DateTime.MinValue Then
         param.Value = DBNull.Value
      Else
         param.Value = Figlio.DataNascita
      End If
      Cmd.Parameters.Add(param)


      param = Cmd.CreateParameter
      param.ParameterName = "@Sc"
      param.Value = Figlio.Scuola
      Cmd.Parameters.Add(param)


      param = Cmd.CreateParameter
      param.ParameterName = "@An"
      param.Value = Figlio.AnnoFrequenza
      Cmd.Parameters.Add(param)

      param = Cmd.CreateParameter
      param.ParameterName = "@NomF"
      param.Value = Figlio.Nome
      Cmd.Parameters.Add(param)



      param = Cmd.CreateParameter
      param.ParameterName = "@CogF"
      param.Value = Figlio.Cognome
      Cmd.Parameters.Add(param)



      param = Cmd.CreateParameter
      param.ParameterName = "@CfF"
      param.Value = Figlio.CodiceFiscale
      Cmd.Parameters.Add(param)


      param = Cmd.CreateParameter
      param.ParameterName = "@Id"
      param.Value = Figlio.Id
      Cmd.Parameters.Add(param)

   End Sub
End Class
