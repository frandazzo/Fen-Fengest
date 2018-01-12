Public Class MapperIncarico
    Inherits AbstractRDBMapper


#Region "Istruzioni Sql"

    Private Function FindAllByUserStatement() As String
        Return "Select * from DB_INCARICO where ID_Utente = @IdUt"
    End Function


    Protected Overrides Function FindAllStatement() As String
        Return "Select * from DB_INCARICO"
    End Function

    Protected Overrides Function FindByKeyStatement() As String
        Return "Select * from DB_INCARICO where Id = @Id"
    End Function

    Protected Overrides Function InsertStatement() As String
        Return "Insert into DB_INCARICO (ID, ID_UTENTE, ID_AZIENDA, NOTES, ID_TIPO ) values (@Id, @Idu, @Ida, @Not, @Idt)"
    End Function

    Protected Overrides Function UpdateStatement() As String
        Return "UPDATE DB_INCARICO SET ID_UTENTE = @Idu, ID_AZIENDA = @Ida, NOTES = @Not, ID_TIPO = @Idt  WHERE (Id =@Id )"
    End Function

    Protected Overrides Function DeleteStatement() As String
        Return "Delete from DB_INCARICO where Id = @Id"
    End Function

    Protected Overrides Function FindNextKeyStatement() As String
        Return "Select Max(Id) from DB_INCARICO"
    End Function

#End Region

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



    Public Function FindIncaricoByUtente(ByVal Utente As Utente) As IList
        Dim rs As IDataReader = Nothing
        Dim Datalist As IList
        Dim Lista As IList
        Try
            If m_PersistentService.CurrentConnection.State = ConnectionState.Open Then m_PersistentService.CurrentConnection.Close()
            m_PersistentService.CurrentConnection.Open()

            Dim cmd As IDbCommand = GetCommand(FindAllByUserStatement)
            Dim param As IDataParameter = cmd.CreateParameter
            param.ParameterName = "@IdUt"
            param.Value = Utente.IdUtente
            cmd.Parameters.Add(param)
            rs = cmd.ExecuteReader
            Datalist = Me.LoadDataMatrix(rs)
            rs.Close()
            Lista = LoadAll(Datalist, Utente)

            m_PersistentService.CurrentConnection.Close()
            'RipristinaRiferimentoCircolareCon(Utente, Lista)
            Return Lista
        Catch ex As Exception
            Throw
        Finally
            ReleaseDBDatareader(rs)
            Datalist = New ArrayList
            If m_PersistentService.CurrentConnection.State = ConnectionState.Open Then m_PersistentService.CurrentConnection.Close()
        End Try
    End Function



    Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject

        Return DirectCast(MyBase.FindByKey(New Key(Id)), Incarico)

    End Function


    Protected Overloads Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable, ByVal Utente As Utente) As AbstractPersistenceObject
        Dim incarico As New Incarico

        Dim note As String = IIf(rs("NOTES") IsNot Nothing, rs("NOTES"), "")


        Dim Id_TipoDocumentazione As Int32 = IIf(rs("ID_TIPO") IsNot Nothing, rs("ID_TIPO"), -1)
        Dim MapperTipoDocumentazione As MapperTipoIncarico = PersistenceMapperRegistry.Instance.GetMapperByName("MapperTipoIncarico")
        Dim tipoIncarico As TipoIncarico = MapperTipoDocumentazione.FindObjectById(Id_TipoDocumentazione)


        'Dim ID_UTENTE As Int32 = IIf(rs("ID_UTENTE") IsNot Nothing, rs("ID_UTENTE"), -1)
        'Dim utente As Utente = Nothing
        'If ID_UTENTE <> -1 Then
        '    Dim MapperUtente As MapperUtente = PersistenceMapperRegistry.Instance.GetMapperByName("MapperUtente")
        '    utente = MapperUtente.FindObjectById(ID_UTENTE)
        'End If



        Dim ID_AZIENDA As Int32 = IIf(rs("ID_AZIENDA") IsNot Nothing, rs("ID_AZIENDA"), -1)
        Dim azienda As Azienda = Nothing
        If ID_AZIENDA <> -1 Then
            Dim MapperAzienda As MapperAzienda = PersistenceMapperRegistry.Instance.GetMapperByName("MapperAzienda")
            azienda = MapperAzienda.FindObjectById(ID_AZIENDA)
        End If





        incarico.Azienda = azienda
        incarico.Utente = Utente
        incarico.Notes = note
        incarico.TipoIncarico = tipoIncarico

        incarico.Key = Key

        Return incarico
    End Function

    Protected Overloads Overrides Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable) As AbstractPersistenceObject
        Throw New NotImplementedException
    End Function


    Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
        Dim tipo As Incarico = DirectCast(Item, Incarico)

        Dim param As IDbDataParameter = Cmd.CreateParameter
        param.ParameterName = "@Idu"
        param.Value = tipo.Utente.Id
        Cmd.Parameters.Add(param)



        param = Cmd.CreateParameter
        param.ParameterName = "@Ida"
        If tipo.Azienda Is Nothing Then
            param.Value = DBNull.Value
        Else
            param.Value = tipo.Azienda.Id
        End If
        Cmd.Parameters.Add(param)


        param = Cmd.CreateParameter
        param.ParameterName = "@Not"
        param.Value = tipo.Notes
        Cmd.Parameters.Add(param)

        param = Cmd.CreateParameter
        param.ParameterName = "@Idt"
        param.Value = tipo.TipoIncarico.Id
        Cmd.Parameters.Add(param)

    End Sub

    Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)

        Dim tipo As Incarico = DirectCast(Item, Incarico)

        Dim param As IDbDataParameter = Cmd.CreateParameter
        param.ParameterName = "@Idu"
        param.Value = tipo.Utente.Id
        Cmd.Parameters.Add(param)



        param = Cmd.CreateParameter
        param.ParameterName = "@Ida"
        If tipo.Azienda Is Nothing Then
            param.Value = DBNull.Value
        Else
            param.Value = tipo.Azienda.Id
        End If
        Cmd.Parameters.Add(param)


        param = Cmd.CreateParameter
        param.ParameterName = "@Not"
        param.Value = tipo.Notes
        Cmd.Parameters.Add(param)

        param = Cmd.CreateParameter
        param.ParameterName = "@Idt"
        param.Value = tipo.TipoIncarico.Id
        Cmd.Parameters.Add(param)


        param = Cmd.CreateParameter
        param.ParameterName = "@Id"
        param.Value = tipo.Id
        Cmd.Parameters.Add(param)

    End Sub


End Class
