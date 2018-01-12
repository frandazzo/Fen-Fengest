Public Class MapperTipoIncarico
    Inherits AbstractRDBMapper


#Region "Istruzioni Sql"

    Protected Overrides Function FindAllStatement() As String
        Return "Select * from DB_TIPO_INCARICO"
    End Function

    Protected Overrides Function FindByKeyStatement() As String
        Return "Select * from DB_TIPO_INCARICO where Id = @Id"
    End Function

    Protected Overrides Function InsertStatement() As String
        Return "Insert into DB_TIPO_INCARICO (ID, DESCRIZIONE) values (@Id, @Desc)"
    End Function

    Protected Overrides Function UpdateStatement() As String
        Return "UPDATE DB_TIPO_INCARICO SET Descrizione = @Desc  WHERE (Id =@Id )"
    End Function

    Protected Overrides Function DeleteStatement() As String
        Return "Delete from DB_TIPO_INCARICO where Id = @Id"
    End Function

    Protected Overrides Function FindNextKeyStatement() As String
        Return "Select Max(Id) from DB_TIPO_INCARICO"
    End Function

#End Region


#Region "Metodi per la ricerca dell'oggetto secondo l'id proposto"

    Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject

        Return DirectCast(MyBase.FindByKey(New Key(Id)), TipoIncarico)

    End Function
    Protected Overloads Overrides Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable) As AbstractPersistenceObject
        Dim tipo As New TipoIncarico
        tipo.Descrizione = rs.Item("DESCRIZIONE")
        tipo.Key = Key

        Return tipo
    End Function
    'Protected Overrides Function GetCommand(ByVal CommandText As String) As System.Data.IDbCommand

    '   ' Return New SqlClient1.SqlCommand(CommandText, DBConnectionManager.Instance.GetCurrentConnection)
    '   Return DBTypeUtils.GetCommand(Me.m_PersistentService.ServiceName, CommandText, DBConnectionManager.Instance.GetCurrentConnection)

    'End Function

#End Region




    Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
        Dim tipo As TipoIncarico = DirectCast(Item, TipoIncarico)

        Dim param As IDbDataParameter = Cmd.CreateParameter
        param.ParameterName = "@Desc"
        param.Value = tipo.Descrizione
        Cmd.Parameters.Add(param)


    End Sub

    Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)

        Dim tipo As TipoIncarico = DirectCast(Item, TipoIncarico)

        Dim param As IDbDataParameter = Cmd.CreateParameter
        param.ParameterName = "@Desc"
        param.Value = tipo.Descrizione
        Cmd.Parameters.Add(param)



        param = Cmd.CreateParameter
        param.ParameterName = "@Id"
        param.Value = tipo.Id
        Cmd.Parameters.Add(param)

    End Sub


End Class
