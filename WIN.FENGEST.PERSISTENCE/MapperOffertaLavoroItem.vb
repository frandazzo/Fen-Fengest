Public Class MapperOffertaLavoroItem
   Inherits AbstractRDBMapper



#Region "Istruzioni Sql"

   Protected Overrides Function FindAllStatement() As String
      Return "Select * from DB_Offerta_Lavoro_Item"
   End Function

   Protected Function FindAllByOfferStatement() As String
      Return "Select * from DB_Offerta_Lavoro_Item where Id_Offerta_lavoro = @IdOf"
   End Function


   Protected Overrides Function FindByKeyStatement() As String
      Return "Select * from DB_Offerta_Lavoro_Item where Id = @Id"
   End Function

   Protected Overrides Function InsertStatement() As String
      Return "Insert into DB_Offerta_Lavoro_Item (ID, ID_OFFERTA_LAVORO, ID_LIVELLO_ABILITA, ID_ABILITA, NUMERO_POSTI) values (@Id, @IdOf, @IdLa, @IdAb, @Num)"
   End Function

   Protected Overrides Function UpdateStatement() As String
      Return "UPDATE DB_Offerta_Lavoro_Item SET ID_OFFERTA_LAVORO = @IdOf, ID_LIVELLO_ABILITA = @IdLa, ID_ABILITA = @IdAb, NUMERO_POSTI = @Num WHERE (Id =@Id )"
   End Function

   Protected Overrides Function DeleteStatement() As String
      Return "Delete from DB_Offerta_Lavoro_Item where Id = @Id"
   End Function

   Protected Overrides Function FindNextKeyStatement() As String
      Return "Select Max(Id) from DB_Offerta_Lavoro_Item"
   End Function

#End Region


   Public Function FindItemsByOfferta(ByVal Offerta As OffertaLavoro) As IList
      Dim rs As IDataReader = Nothing
      Dim Datalist As IList
      Dim Lista As IList
      Dim connectionExternallyOpened As Boolean = False
      Try
    
            If m_PersistentService.CurrentConnection.State = ConnectionState.Open Then
                connectionExternallyOpened = True
            Else
                m_PersistentService.CurrentConnection.Open()
            End If


         Dim cmd As IDbCommand = GetCommand(FindAllByOfferStatement)
         Dim param As IDataParameter = cmd.CreateParameter
         param.ParameterName = "@IdOf"
         param.Value = Offerta.Id
         cmd.Parameters.Add(param)
         rs = cmd.ExecuteReader
         Datalist = Me.LoadDataMatrix(rs)
         rs.Close()
         Lista = LoadAll(Datalist, Offerta)

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


   Protected Overloads Function LoadAll(ByVal rs As IList, ByVal Offerta As OffertaLavoro) As IList
      Dim List As New ArrayList
      For Each elem As Hashtable In rs
         List.Add(Load(elem, offerta))
      Next
      Return List

   End Function

   Protected Overloads Function Load(ByVal rs As Hashtable, ByVal offerta As OffertaLavoro) As AbstractPersistenceObject
      Dim key As Key = CreateKey(rs)
      If Cache.GetObjectFromCache(key.ToString) IsNot Nothing Then Return DirectCast(Cache.GetObjectFromCache(key.ToString), AbstractPersistenceObject)
      Dim obj As AbstractPersistenceObject = DoLoad(key, rs, offerta)
      Cache.AddToCache(obj)
      Return obj
   End Function




   Protected Overloads Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable, ByVal offerta As OffertaLavoro) As AbstractPersistenceObject
      Dim item As New OffertaLavoroItem
      item.Offerta = offerta

      Dim numero As Int32 = IIf(rs("NUMERO_POSTI") IsNot Nothing, rs("NUMERO_POSTI"), -1)
      Dim Id_Livello As Int32 = IIf(rs("ID_LIVELLO_ABILITA") IsNot Nothing, rs("ID_LIVELLO_ABILITA"), -1)
      Dim Id_Abilita As Int32 = IIf(rs("ID_ABILITA") IsNot Nothing, rs("ID_ABILITA"), -1)
      Dim MapperAbilita As MapperAbilita = PersistenceMapperRegistry.Instance.GetMapperByName("MapperAbilita")
      Dim MapperLivelloAbilita As MapperLivelloAbilita = PersistenceMapperRegistry.Instance.GetMapperByName("MapperLivelloAbilita")
      Dim abilita As Abilita = MapperAbilita.FindObjectById(Id_Abilita)
      Dim livello As LivelloAbilita = MapperLivelloAbilita.FindObjectById(Id_Livello)


      item.Livello = livello
      item.Abilita = abilita
      item.NumeroPosti = numero

      item.Key = Key
      Return item
   End Function











#Region "Metodi per la ricerca dell'oggetto secondo l'id proposto"

   Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject

      Return DirectCast(MyBase.FindByKey(New Key(Id)), KnowHow)

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
      Dim item1 As OffertaLavoroItem = DirectCast(Item, OffertaLavoroItem)

      Dim param As IDbDataParameter = Cmd.CreateParameter
      param.ParameterName = "@IdOf"
      param.Value = item1.Offerta.Id
      Cmd.Parameters.Add(param)


      param = Cmd.CreateParameter
      param.ParameterName = "@IdLa"
      If item1.Livello Is Nothing Then
         param.Value = DBNull.Value
      Else
         param.Value = item1.Livello.Id
      End If
      Cmd.Parameters.Add(param)


      param = Cmd.CreateParameter
      param.ParameterName = "@IdAb"
      If item1.Abilita Is Nothing Then
         param.Value = DBNull.Value
      Else
         param.Value = item1.Abilita.Id
      End If
      Cmd.Parameters.Add(param)

      param = Cmd.CreateParameter
      param.ParameterName = "@Num"
      param.Value = item1.NumeroPosti
      Cmd.Parameters.Add(param)



   End Sub

   Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)

      Dim item1 As OffertaLavoroItem = DirectCast(Item, OffertaLavoroItem)

      Dim param As IDbDataParameter = Cmd.CreateParameter
      param.ParameterName = "@IdOf"
      param.Value = item1.Offerta.Id
      Cmd.Parameters.Add(param)


      param = Cmd.CreateParameter
      param.ParameterName = "@IdLa"
      If item1.Livello Is Nothing Then
         param.Value = DBNull.Value
      Else
         param.Value = item1.Livello.Id
      End If
      Cmd.Parameters.Add(param)


      param = Cmd.CreateParameter
      param.ParameterName = "@IdAb"
      If item1.Abilita Is Nothing Then
         param.Value = DBNull.Value
      Else
         param.Value = item1.Abilita.Id
      End If
      Cmd.Parameters.Add(param)

      param = Cmd.CreateParameter
      param.ParameterName = "@Num"
      param.Value = item1.NumeroPosti
      Cmd.Parameters.Add(param)


      param = Cmd.CreateParameter
      param.ParameterName = "@Id"
      param.Value = item1.Id
      Cmd.Parameters.Add(param)

   End Sub
End Class
