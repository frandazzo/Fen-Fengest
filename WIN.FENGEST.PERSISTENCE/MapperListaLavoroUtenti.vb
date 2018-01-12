Public Class MapperListaLavoroUtenti
    Inherits AbstractRDBMapper



#Region "Istruzioni Sql"

    Protected Overrides Function FindAllStatement() As String
        Return "Select * from DB_LISTA_UTENTI"
    End Function

    Protected Overrides Function FindByKeyStatement() As String
        Return "Select * from DB_LISTA_UTENTI where Id = @Id"
    End Function

    Protected Overrides Function InsertStatement() As String
        Return "Insert into DB_LISTA_UTENTI (ID, DESCRIZIONE, CreatedBy, CreatedOn) values (@Id, @Desc, @CRby, @CRon)"
    End Function

    Protected Overrides Function UpdateStatement() As String
        Return "UPDATE DB_LISTA_UTENTI SET Descrizione = @Desc, ModifiedBy = @MOby, ModifiedOn = @MOon  WHERE (Id = @Id )"
    End Function

    Protected Overrides Function DeleteStatement() As String
        Return "Delete from DB_LISTA_UTENTI where Id = @Id"
    End Function

    Protected Overrides Function FindNextKeyStatement() As String
        Return "Select Max(Id) from DB_LISTA_UTENTI"
    End Function

    Private Function FindUserByListId() As String
        Return "Select * from DB_LISTALAVORO_UTENTI WHERE ID_LISTALAVORO_UTENTI = @Idl"
    End Function

#End Region


#Region "Metodi per la ricerca dell'oggetto secondo l'id proposto"
    Public Overrides Function FindObjectByIdReloadingCache(ByVal Id As Integer) As AbstractPersistenceObject

        Return DirectCast(MyBase.FindByKeyReloadingCache(New Key(Id)), ListaLavoroUtenti)


    End Function


    Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject

        Return DirectCast(MyBase.FindByKey(New Key(Id)), ListaLavoroUtenti)


    End Function
    Protected Overloads Overrides Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable) As AbstractPersistenceObject
        Try
            Dim lista As New ListaLavoroUtenti
            lista.Descrizione = rs.Item("DESCRIZIONE")
            lista.Key = Key
            Dim VirtualList As LazyLoadListaLavoroItems = New LazyLoadListaLavoroItems(lista)
            lista.ListaUtenti = VirtualList
            JournalingDataLoader.ReadJournalingParameters(lista, rs)
            Return lista
        Catch ex As Exception
            Throw New Exception("Impossibile caricare l'oggetto conto con Id = " & Key.LongValue & ". " & vbCrLf & ex.Message)
        End Try
    End Function
    'Protected Overrides Function GetCommand(ByVal CommandText As String) As System.Data.IDbCommand

    '    'Return New SqlClient1.SqlCommand(CommandText, DBConnectionManager.Instance.GetCurrentConnection)
    '    Return DBTypeUtils.GetCommand(Me.m_PersistentService.ServiceName, CommandText, DBConnectionManager.Instance.GetCurrentConnection)
    'End Function

#End Region

    Public Function FindListaUtenti(ByVal ListaLavoro As ListaLavoroUtenti) As IList
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



            Dim cmd As IDbCommand = GetCommand(FindUserByListId)
            Dim param As IDataParameter = cmd.CreateParameter
            param.ParameterName = "@Idl"
            param.Value = ListaLavoro.Id
            cmd.Parameters.Add(param)
            rs = cmd.ExecuteReader
            Datalist = Me.LoadDataMatrix(rs)
            rs.Close()
            Lista = LoadUsers(Datalist, ListaLavoro)

            If connectionExternallyOpened = False Then
                m_PersistentService.CurrentConnection.Close()
            End If


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


    Protected Function LoadUsers(ByVal rs As IList, ByVal Lista As ListaLavoroUtenti) As IList
        Dim List As New ArrayList
        Dim mapperUtenti As MapperUtente = PersistenceMapperRegistry.Instance.GetMapperByName("MapperUtente")

        



        For Each elem As Hashtable In rs

            Dim TAG1 As String = IIf(elem.Item("TAG1") IsNot Nothing, elem.Item("TAG1"), "")
            Dim TAG2 As String = IIf(elem.Item("TAG2") IsNot Nothing, elem.Item("TAG2"), "")
            Dim TAG3 As String = IIf(elem.Item("TAG3") IsNot Nothing, elem.Item("TAG3"), "")

            Dim u As Utente = mapperUtenti.FindObjectById(elem.Item("ID_UTENTE"))
            Dim Tag As New TagUtente
            Tag.Tag1 = TAG1
            Tag.Tag2 = TAG2
            Tag.Tag3 = TAG3
            u.TagUtente = Tag
            List.Add(u)

        Next
        Return List
    End Function





    Public Overrides Sub PostInsertAction(ByVal item As AbstractPersistenceObject)
        InsertAssociatedUsers(item)
    End Sub



    Public Overrides Sub PostUpdateAction(ByVal item As AbstractPersistenceObject)
        RemoveAssociatedUsers(item)
        InsertAssociatedUsers(item)
    End Sub

    Private Sub InsertAssociatedUsers(ByVal Item As AbstractPersistenceObject)
        For Each elem As Utente In DirectCast(Item, ListaLavoroUtenti).ListaUtenti
            InsertssociatedUser(Item, elem)
        Next
    End Sub


    Private Sub InsertssociatedUser(ByVal item As AbstractPersistenceObject, ByVal Utente As Utente)
        Dim connectionExternallyOpened As Boolean = False
        Try

            If m_PersistentService.CurrentConnection.State = ConnectionState.Open Then
                connectionExternallyOpened = True
            Else
                m_PersistentService.CurrentConnection.Open()
            End If


            Dim cmd As IDbCommand = GetCommand("Insert into DB_LISTALAVORO_UTENTI (ID_LISTALAVORO_UTENTI, ID_UTENTE, TAG1, TAG2, TAG3) VALUES (@Idl, @IdU, @Tag1, @Tag2, @Tag3)")
            Dim param As IDataParameter = cmd.CreateParameter
            param.ParameterName = "@Idl"
            param.Value = item.Id
            cmd.Parameters.Add(param)

            param = cmd.CreateParameter
            param.ParameterName = "@IdU"
            param.Value = Utente.Id
            cmd.Parameters.Add(param)

            param = cmd.CreateParameter
            param.ParameterName = "@Tag1"
            param.Value = Utente.TagUtente.Tag1
            cmd.Parameters.Add(param)

            param = cmd.CreateParameter
            param.ParameterName = "@Tag2"
            param.Value = Utente.TagUtente.Tag2
            cmd.Parameters.Add(param)

            param = cmd.CreateParameter
            param.ParameterName = "@Tag3"
            param.Value = Utente.TagUtente.Tag3
            cmd.Parameters.Add(param)


            cmd.ExecuteNonQuery()


            If connectionExternallyOpened = False Then
                m_PersistentService.CurrentConnection.Close()
            End If

        Catch ex As Exception
            Throw
        Finally
            If connectionExternallyOpened = False Then
                If m_PersistentService.CurrentConnection.State = ConnectionState.Open Then m_PersistentService.CurrentConnection.Close()
            End If
        End Try
    End Sub


    Private Sub RemoveAssociatedUsers(ByVal Item As AbstractPersistenceObject)

        Dim connectionExternallyOpened As Boolean = False
        Try

            If m_PersistentService.CurrentConnection.State = ConnectionState.Open Then
                connectionExternallyOpened = True
            Else
                m_PersistentService.CurrentConnection.Open()
            End If


            Dim cmd As IDbCommand = GetCommand("Delete from DB_LISTALAVORO_UTENTI WHERE ID_LISTALAVORO_UTENTI = @Idl")
            Dim param As IDataParameter = cmd.CreateParameter
            param.ParameterName = "@Idl"
            param.Value = Item.Id
            cmd.Parameters.Add(param)
            cmd.ExecuteNonQuery()


            If connectionExternallyOpened = False Then
                m_PersistentService.CurrentConnection.Close()
            End If

        Catch ex As Exception
            Throw
        Finally
            If connectionExternallyOpened = False Then
                If m_PersistentService.CurrentConnection.State = ConnectionState.Open Then m_PersistentService.CurrentConnection.Close()
            End If
        End Try
    End Sub





    Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)

        Dim lista As ListaLavoroUtenti = DirectCast(Item, ListaLavoroUtenti)

        Dim param As IDbDataParameter = Cmd.CreateParameter
        param.ParameterName = "@Desc"
        param.Value = lista.Descrizione
        Cmd.Parameters.Add(param)

        JournalingDataLoader.LoadJournalingInsertCommandParameters(Item, Cmd)



    End Sub

    Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
        Try
            Dim lista As ListaLavoroUtenti = DirectCast(Item, ListaLavoroUtenti)

            Dim param As IDbDataParameter = Cmd.CreateParameter
            param.ParameterName = "@Desc"
            param.Value = lista.Descrizione
            Cmd.Parameters.Add(param)

            JournalingDataLoader.LoadJournalingUpdateCommandParameters(Item, Cmd)

            param = Cmd.CreateParameter
            param.ParameterName = "@Id"
            param.Value = lista.Id
            Cmd.Parameters.Add(param)

        Catch ex As Exception
            Throw New Exception("Impossibile caricare il comando di aggiornamento dell'oggetto conto." & vbCrLf & ex.Message)
        End Try
    End Sub




End Class

