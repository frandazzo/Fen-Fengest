Public Class MapperTessera
   Inherits AbstractRDBMapper



#Region "Istruzioni Sql"

   Protected Overrides Function FindAllStatement() As String
      Return "Select * from DB_STAMPA_TESSERE"
   End Function

   Protected Function FindAllByUserStatement() As String
      Return "Select * from DB_STAMPA_TESSERE where Id_Utente = @IdUt"
   End Function


   Protected Overrides Function FindByKeyStatement() As String
      Return "Select * from DB_STAMPA_TESSERE where Id = @Id"
   End Function

   Protected Overrides Function InsertStatement() As String
      Return "Insert into DB_STAMPA_TESSERE (ID, ID_UTENTE,  DATA_STAMPA, STAMPATA_DA) values (@Id, @IdUt, @Dat, @StDa)"
   End Function

   Protected Overrides Function UpdateStatement() As String
      Return "UPDATE DB_STAMPA_TESSERE SET ID_UTENTE = @IdUt, DATA_STAMPA = @Dat, STAMPATA_DA = @StDa WHERE (Id =@Id )"
   End Function

   Protected Overrides Function DeleteStatement() As String
      Return "Delete from DB_STAMPA_TESSERE where Id = @Id"
   End Function

   Protected Overrides Function FindNextKeyStatement() As String
      Return "Select Max(Id) from DB_STAMPA_TESSERE"
   End Function

#End Region


   Public Function FindTessereByUtente(ByVal Utente As Utente) As IList
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
      Dim tessera As New Tessera(Utente)






      Dim DATA As DateTime = IIf(rs("DATA_STAMPA") IsNot Nothing, rs("DATA_STAMPA"), DateTime.MinValue)


      Dim STAMPATA_DA As String = IIf(rs("STAMPATA_DA") IsNot Nothing, rs("STAMPATA_DA"), "")



      tessera.DataTesseramento = DATA
      tessera.StampataDa = STAMPATA_DA
      tessera.Key = Key
      Return tessera
   End Function











#Region "Metodi per la ricerca dell'oggetto secondo l'id proposto"

   Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject

      Return DirectCast(MyBase.FindByKey(New Key(Id)), Tessera)

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
      Dim tessera As Tessera = DirectCast(Item, Tessera)

      Dim param As IDbDataParameter = Cmd.CreateParameter
      param.ParameterName = "@IdUt"
      param.Value = tessera.Utente.IdUtente
      Cmd.Parameters.Add(param)





      param = Cmd.CreateParameter
      param.ParameterName = "@Dat"
      If tessera.DataTesseramento = DateTime.MinValue Then
         param.Value = DBNull.Value
      Else
         param.Value = tessera.DataTesseramento
      End If
      Cmd.Parameters.Add(param)



      param = Cmd.CreateParameter
      param.ParameterName = "@StDa"
      param.Value = tessera.StampataDa
      Cmd.Parameters.Add(param)

   End Sub

   Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)

      Dim tessera As Tessera = DirectCast(Item, Tessera)

      Dim param As IDbDataParameter = Cmd.CreateParameter
      param.ParameterName = "@IdUt"
      param.Value = tessera.Utente.IdUtente
      Cmd.Parameters.Add(param)





      param = Cmd.CreateParameter
      param.ParameterName = "@Dat"
      If tessera.DataTesseramento = DateTime.MinValue Then
         param.Value = DBNull.Value
      Else
         param.Value = tessera.DataTesseramento
      End If
      Cmd.Parameters.Add(param)



      param = Cmd.CreateParameter
      param.ParameterName = "@StDa"
      param.Value = tessera.StampataDa
      Cmd.Parameters.Add(param)


      param = Cmd.CreateParameter
      param.ParameterName = "@Id"
      param.Value = tessera.Id
      Cmd.Parameters.Add(param)

   End Sub
End Class
