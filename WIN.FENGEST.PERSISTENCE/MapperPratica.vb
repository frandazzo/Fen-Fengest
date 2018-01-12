Public Class MapperPratica
    Inherits AbstractRDBMapper


#Region "Istruzioni Sql"

    Protected Overrides Function FindAllStatement() As String
        Return "Select * from DB_PRATICHE"
    End Function

    Protected Overrides Function FindByKeyStatement() As String
        Return "Select * from DB_PRATICHE where Id = @Id"
    End Function

    Protected Overrides Function InsertStatement() As String
        Return "Insert into DB_PRATICHE (ID, PracticeDate, UserId, PracticeTypeId, PracticeState, PracticeNote, Owner, Code, City) values (@Id, @prd, @usi, @prt, @prs, @prn, @own, @cod, @cit)"
    End Function

    Protected Overrides Function UpdateStatement() As String
        Return "UPDATE DB_PRATICHE SET PracticeDate = @prd, UserId = @usi, PracticeTypeId = @prt, PracticeState = @prs, PracticeNote = @prn, Owner = @own, Code=@cod, City=@cit  WHERE (Id =@Id )"
    End Function

    Protected Overrides Function DeleteStatement() As String
        Return "Delete from DB_PRATICHE where Id = @Id"
    End Function

    Protected Overrides Function FindNextKeyStatement() As String
        Return "Select Max(Id) from DB_PRATICHE"
    End Function

#End Region


#Region "Metodi per la ricerca dell'oggetto secondo l'id proposto"

    Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject

        Return DirectCast(MyBase.FindByKey(New Key(Id)), Pratica)

    End Function
    Protected Overloads Overrides Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable) As AbstractPersistenceObject
        Dim tipo As New Pratica
        tipo.PraticaDate = rs.Item("PracticeDate")
        tipo.Notes = rs.Item("PracticeNote")


        tipo.Code = IIf(rs.Item("Code") IsNot Nothing, rs.Item("Code"), "")
        tipo.City = IIf(rs.Item("City") IsNot Nothing, rs.Item("City"), "")

        Dim state As Int32 = rs.Item("PracticeState")
        tipo.State = PracticeStateFactory.ConstructPracticeState(state)

        Dim MapperUser As MapperUser = PersistenceMapperRegistry.Instance.GetMapperByName("MapperUser")
        Dim MapperUtente As MapperUtente = PersistenceMapperRegistry.Instance.GetMapperByName("MapperUtente")
        Dim MapperTipoPratica As MapperTipoPratica = PersistenceMapperRegistry.Instance.GetMapperByName("MapperTipoPratica")


        Dim ID_Owner As Int32 = IIf(rs.Item("Owner") IsNot Nothing, rs.Item("Owner"), -1)
        If ID_Owner <> -1 Then
            tipo.Owner = MapperUser.FindObjectById(ID_Owner)
        End If

        Dim ID_User As Int32 = IIf(rs.Item("UserId") IsNot Nothing, rs.Item("UserId"), -1)
        If ID_User <> -1 Then
            tipo.Utente = MapperUtente.FindObjectById(ID_User)
        End If

        Dim ID_tipo As Int32 = IIf(rs.Item("PracticeTypeId") IsNot Nothing, rs.Item("PracticeTypeId"), -1)
        If ID_tipo <> -1 Then
            tipo.TipoPratica = MapperTipoPratica.FindObjectById(ID_tipo)
        End If

        Dim lazyList As New LazyLoadPraticaEvents(tipo, Me)
        tipo.Events = lazyList

        Dim lazyList1 As New LazyLoadPraticaDetails(tipo, Me)
        tipo.Details = lazyList1
        
        tipo.Key = Key

        Return tipo
    End Function


#End Region


    Public Overrides Sub PostInsertAction(ByVal item As AbstractPersistenceObject)
        InsertAssociatedEvents(item)
        InsertAssociatedDetails(item)
    End Sub

   

    Public Overrides Sub PostUpdateAction(ByVal item As AbstractPersistenceObject)
        RemoveAssociatedEvents(item)
        RemoveAssociatedDetails(item)
        InsertAssociatedEvents(item)
        InsertAssociatedDetails(item)
    End Sub


    Private Sub InsertAssociatedEvents(ByVal Item As AbstractPersistenceObject)
        For Each elem As PraticaEvent In DirectCast(Item, Pratica).Events
            InsertAssociatedEvent(Item, elem)
        Next
    End Sub


    Private Sub InsertAssociatedEvent(Item As AbstractPersistenceObject, elem As PraticaEvent)
        Dim connectionExternallyOpened As Boolean = False
        Try

            If m_PersistentService.CurrentConnection.State = ConnectionState.Open Then
                connectionExternallyOpened = True
            Else
                m_PersistentService.CurrentConnection.Open()
            End If


            Dim cmd As IDbCommand = GetCommand("Insert into DB_PRATICHE_EVENTS (PracticeId, PracticeState, PracticeNotes, PracticeDate, PracticeOperator) VALUES (@pri, @prs, @prn, @prd, @pro)")
            Dim param As IDataParameter = cmd.CreateParameter
            param.ParameterName = "@pri"
            param.Value = Item.Id
            cmd.Parameters.Add(param)

            param = cmd.CreateParameter
            param.ParameterName = "@prs"
            param.Value = elem.State.State
            cmd.Parameters.Add(param)

            param = cmd.CreateParameter
            param.ParameterName = "@prn"
            If (String.IsNullOrEmpty(elem.Notes)) Then
                param.Value = ""
            Else
                param.Value = elem.Notes
            End If
            cmd.Parameters.Add(param)

            param = cmd.CreateParameter
            param.ParameterName = "@prd"
            param.Value = elem.Data
            cmd.Parameters.Add(param)

            param = cmd.CreateParameter
            param.ParameterName = "@pro"
            param.Value = elem.Operatore.Id
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
        Dim tipo As Pratica = DirectCast(Item, Pratica)

        Dim param As IDbDataParameter = Cmd.CreateParameter
        param.ParameterName = "@prd"
        param.Value = tipo.PraticaDate
        Cmd.Parameters.Add(param)

        param = Cmd.CreateParameter
        param.ParameterName = "@usi"
        param.Value = tipo.Utente.Id
        Cmd.Parameters.Add(param)

        param = Cmd.CreateParameter
        param.ParameterName = "@prt"
        param.Value = tipo.TipoPratica.Id
        Cmd.Parameters.Add(param)

        param = Cmd.CreateParameter
        param.ParameterName = "@prs"
        param.Value = tipo.State.State
        Cmd.Parameters.Add(param)

        param = Cmd.CreateParameter
        param.ParameterName = "@prn"
        If tipo.Notes Is Nothing Then
            param.Value = ""
        Else
            param.Value = tipo.Notes
        End If
        Cmd.Parameters.Add(param)

        param = Cmd.CreateParameter
        param.ParameterName = "@own"
        param.Value = tipo.Owner.Id
        Cmd.Parameters.Add(param)


        param = Cmd.CreateParameter
        param.ParameterName = "@cod"
        If tipo.Code Is Nothing Then
            param.Value = ""
        Else
            param.Value = tipo.Code
        End If
        Cmd.Parameters.Add(param)

        param = Cmd.CreateParameter
        param.ParameterName = "@cit"
        If tipo.City Is Nothing Then
            param.Value = ""
        Else
            param.Value = tipo.City
        End If
        Cmd.Parameters.Add(param)
      

    End Sub

    Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)

         Dim tipo As Pratica = DirectCast(Item, Pratica)

        Dim param As IDbDataParameter = Cmd.CreateParameter
        param.ParameterName = "@prd"
        param.Value = tipo.PraticaDate
        Cmd.Parameters.Add(param)

        param = Cmd.CreateParameter
        param.ParameterName = "@usi"
        param.Value = tipo.Utente.Id
        Cmd.Parameters.Add(param)

        param = Cmd.CreateParameter
        param.ParameterName = "@prt"
        param.Value = tipo.TipoPratica.Id
        Cmd.Parameters.Add(param)

        param = Cmd.CreateParameter
        param.ParameterName = "@prs"
        param.Value = tipo.State.State
        Cmd.Parameters.Add(param)

        param = Cmd.CreateParameter
        param.ParameterName = "@prn"
        If tipo.Notes Is Nothing Then
            param.Value = ""
        Else
            param.Value = tipo.Notes
        End If
        Cmd.Parameters.Add(param)

        param = Cmd.CreateParameter
        param.ParameterName = "@own"
        param.Value = tipo.Owner.Id
        Cmd.Parameters.Add(param)

        param = Cmd.CreateParameter
        param.ParameterName = "@cod"
        If tipo.Code Is Nothing Then
            param.Value = ""
        Else
            param.Value = tipo.Code
        End If
        Cmd.Parameters.Add(param)

        param = Cmd.CreateParameter
        param.ParameterName = "@cit"
        If tipo.City Is Nothing Then
            param.Value = ""
        Else
            param.Value = tipo.City
        End If
        Cmd.Parameters.Add(param)


        param = Cmd.CreateParameter
        param.ParameterName = "@Id"
        param.Value = tipo.Id
        Cmd.Parameters.Add(param)

    End Sub


    Function FindListaEvents(pratica As Pratica) As ArrayList
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



            Dim cmd As IDbCommand = GetCommand("Select * from DB_PRATICHE_EVENTS where PracticeId = @Idl")
            Dim param As IDataParameter = cmd.CreateParameter
            param.ParameterName = "@Idl"
            param.Value = pratica.Id
            cmd.Parameters.Add(param)
            rs = cmd.ExecuteReader
            Datalist = Me.LoadDataMatrix(rs)
            rs.Close()
            Lista = LoadEvents(Datalist, pratica)

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

    Private Function LoadEvents(Datalist As IList, m_templ As Pratica) As IList
        Dim List As New ArrayList

        Dim registro As PersistenceMapperRegistry = PersistenceMapperRegistry.Instance
      


        For Each elem As Hashtable In Datalist
            'qui carico la lista delle questions
            Dim id As Int32 = elem.Item("ID")
            Dim q As PraticaEvent = LoadPratica(elem, New Key(id), registro)
            List.Add(q)
        Next


        Return List
    End Function



    Private Function LoadPratica(rs As Hashtable, key As Key, registro As PersistenceMapperRegistry) As PraticaEvent
        Dim ans As New PraticaEvent
        ans.Key = key

        ans.State = PracticeStateFactory.ConstructPracticeState(rs.Item("PracticeState"))
        ans.Notes = rs.Item("PracticeNotes")
        ans.Data = rs.Item("PracticeDate")

        Dim mapper As MapperUser = registro.GetMapperByName("MapperUser")
        ans.Operatore = mapper.FindObjectById(rs.Item("PracticeOperator"))

        Return ans
    End Function





    Function FindListaDetails(pratica As Pratica) As ArrayList
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



            Dim cmd As IDbCommand = GetCommand("Select * from DB_PRATICHE_DETAILS where PracticeId = @Idl")
            Dim param As IDataParameter = cmd.CreateParameter
            param.ParameterName = "@Idl"
            param.Value = pratica.Id
            cmd.Parameters.Add(param)
            rs = cmd.ExecuteReader
            Datalist = Me.LoadDataMatrix(rs)
            rs.Close()
            Lista = LoadDetails(Datalist, pratica)

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

    Private Function LoadDetails(Datalist As IList, m_templ As Pratica) As IList
        Dim List As New ArrayList

        Dim registro As PersistenceMapperRegistry = PersistenceMapperRegistry.Instance



        For Each elem As Hashtable In Datalist
            'qui carico la lista delle questions
            Dim id As Int32 = elem.Item("ID")
            Dim q As PraticaDetail = LoadDetail(elem, New Key(id), registro)
            List.Add(q)
        Next


        Return List
    End Function



    Private Function LoadDetail(rs As Hashtable, key As Key, registro As PersistenceMapperRegistry) As PraticaDetail
        Dim ans As New PraticaDetail
        ans.Key = key


        ans.Notes = rs.Item("Notes")
        ans.FilePath = rs.Item("FilePath")
        ans.Data = rs.Item("Data")


        Return ans
    End Function

    Private Sub RemoveAssociatedEvents(item As AbstractPersistenceObject)
        Dim connectionExternallyOpened As Boolean = False
        Try

            If m_PersistentService.CurrentConnection.State = ConnectionState.Open Then
                connectionExternallyOpened = True
            Else
                m_PersistentService.CurrentConnection.Open()
            End If


            Dim cmd As IDbCommand = GetCommand("Delete from DB_PRATICHE_EVENTS WHERE PracticeId = @Idl")
            Dim param As IDataParameter = cmd.CreateParameter
            param.ParameterName = "@Idl"
            param.Value = item.Id
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


    Private Sub RemoveAssociatedDetails(item As AbstractPersistenceObject)
        Dim connectionExternallyOpened As Boolean = False
        Try

            If m_PersistentService.CurrentConnection.State = ConnectionState.Open Then
                connectionExternallyOpened = True
            Else
                m_PersistentService.CurrentConnection.Open()
            End If


            Dim cmd As IDbCommand = GetCommand("Delete from DB_PRATICHE_DETAILS WHERE PracticeId = @Idl")
            Dim param As IDataParameter = cmd.CreateParameter
            param.ParameterName = "@Idl"
            param.Value = item.Id
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

    Private Sub InsertAssociatedDetails(item As AbstractPersistenceObject)
        For Each elem As PraticaDetail In DirectCast(item, Pratica).Details
            InsertAssociatedDetail(item, elem)
        Next
    End Sub

    Private Sub InsertAssociatedDetail(item As AbstractPersistenceObject, elem As PraticaDetail)
        Dim connectionExternallyOpened As Boolean = False
        Try

            If m_PersistentService.CurrentConnection.State = ConnectionState.Open Then
                connectionExternallyOpened = True
            Else
                m_PersistentService.CurrentConnection.Open()
            End If


            Dim cmd As IDbCommand = GetCommand("Insert into DB_PRATICHE_DETAILS (PracticeId, FilePath, Notes, Data) VALUES (@pri, @fip, @not, @dat)")
            Dim param As IDataParameter = cmd.CreateParameter
            param.ParameterName = "@pri"
            param.Value = item.Id
            cmd.Parameters.Add(param)

            param = cmd.CreateParameter
            param.ParameterName = "@fip"
            param.Value = elem.FilePath
            cmd.Parameters.Add(param)

            param = cmd.CreateParameter
            param.ParameterName = "@not"
            If (String.IsNullOrEmpty(elem.Notes)) Then
                param.Value = ""
            Else
                param.Value = elem.Notes
            End If
            cmd.Parameters.Add(param)

            param = cmd.CreateParameter
            param.ParameterName = "@dat"
            param.Value = elem.Data
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



End Class


