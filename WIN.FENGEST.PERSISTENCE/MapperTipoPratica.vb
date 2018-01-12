Public Class MapperTipoPratica
    Inherits AbstractRDBMapper


#Region "Istruzioni Sql"

    Protected Overrides Function FindAllStatement() As String
        Return "Select * from DB_PRACTICE_TYPE"
    End Function

    Protected Overrides Function FindByKeyStatement() As String
        Return "Select * from DB_PRACTICE_TYPE where Id = @Id"
    End Function

    Protected Overrides Function InsertStatement() As String
        Return "Insert into DB_PRACTICE_TYPE (ID, Description, JollyUser, RestrictedPermissions, ControlUser, IntegrationUser, DocumentationVerifiedUser, CloseUser, RejectedUser) values (@Id, @Desc, @Jol, @Res, @Con, @Int, @Doc, @Clo, @Rej)"
    End Function

    Protected Overrides Function UpdateStatement() As String
        Return "UPDATE DB_PRACTICE_TYPE SET Description = @Desc, JollyUser = @Jol, RestrictedPermissions = @Res, ControlUser = @Con, IntegrationUser = @Int, DocumentationVerifiedUser = @Doc, CloseUser = @Clo, RejectedUser = @Rej  WHERE (Id =@Id )"
    End Function

    Protected Overrides Function DeleteStatement() As String
        Return "Delete from DB_PRACTICE_TYPE where Id = @Id"
    End Function

    Protected Overrides Function FindNextKeyStatement() As String
        Return "Select Max(Id) from DB_PRACTICE_TYPE"
    End Function

#End Region


#Region "Metodi per la ricerca dell'oggetto secondo l'id proposto"

    Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject

        Return DirectCast(MyBase.FindByKey(New Key(Id)), TipoPratica)

    End Function
    Protected Overloads Overrides Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable) As AbstractPersistenceObject
        Dim tipo As New TipoPratica
        tipo.Descrizione = rs.Item("Description")

        Dim MapperUser As MapperUser = PersistenceMapperRegistry.Instance.GetMapperByName("MapperUser")


        Dim ID_Jolly As Int32 = IIf(rs.Item("JollyUser") IsNot Nothing, rs.Item("JollyUser"), -1)
        If ID_Jolly <> -1 Then
            tipo.JollyUser = MapperUser.FindObjectById(ID_Jolly)
        End If

        Dim ID_ControlUser As Int32 = IIf(rs.Item("ControlUser") IsNot Nothing, rs.Item("ControlUser"), -1)
        If ID_ControlUser <> -1 Then
            tipo.ControlUser = MapperUser.FindObjectById(ID_ControlUser)
        End If

        Dim ID_Integrationuser As Int32 = IIf(rs.Item("IntegrationUser") IsNot Nothing, rs.Item("IntegrationUser"), -1)
        If ID_Integrationuser <> -1 Then
            tipo.IntegrationUser = MapperUser.FindObjectById(ID_Integrationuser)
        End If


        Dim ID_DocumentationVerifiedUser As Int32 = IIf(rs.Item("DocumentationVerifiedUser") IsNot Nothing, rs.Item("DocumentationVerifiedUser"), -1)
        If ID_DocumentationVerifiedUser <> -1 Then
            tipo.DocumentationVerifiedUser = MapperUser.FindObjectById(ID_DocumentationVerifiedUser)
        End If


        Dim ID_CloseUser As Int32 = IIf(rs.Item("CloseUser") IsNot Nothing, rs.Item("CloseUser"), -1)
        If ID_CloseUser <> -1 Then
            tipo.ClosedPracticeuser = MapperUser.FindObjectById(ID_CloseUser)
        End If


        Dim ID_RejectedUser As Int32 = IIf(rs.Item("RejectedUser") IsNot Nothing, rs.Item("RejectedUser"), -1)
        If ID_RejectedUser <> -1 Then
            tipo.RejectedPractice = MapperUser.FindObjectById(ID_RejectedUser)
        End If


        tipo.RestrictedPermissions = rs.Item("RestrictedPermissions")
        tipo.Key = Key

        Return tipo
    End Function


#End Region




    Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
        Dim tipo As TipoPratica = DirectCast(Item, TipoPratica)

        Dim param As IDbDataParameter = Cmd.CreateParameter
        param.ParameterName = "@Desc"
        param.Value = tipo.Descrizione
        Cmd.Parameters.Add(param)

        param = Cmd.CreateParameter
        param.ParameterName = "@Jol"
        If tipo.JollyUser Is Nothing Then
            param.Value = DBNull.Value
        Else
            param.Value = tipo.JollyUser.Id
        End If
        Cmd.Parameters.Add(param)

        param = Cmd.CreateParameter
        param.ParameterName = "@res"
        param.Value = tipo.RestrictedPermissions
        Cmd.Parameters.Add(param)


        param = Cmd.CreateParameter
        param.ParameterName = "@Con"
        If tipo.ControlUser Is Nothing Then
            param.Value = DBNull.Value
        Else
            param.Value = tipo.ControlUser.Id
        End If
        Cmd.Parameters.Add(param)

        param = Cmd.CreateParameter
        param.ParameterName = "@Int"
        If tipo.IntegrationUser Is Nothing Then
            param.Value = DBNull.Value
        Else
            param.Value = tipo.IntegrationUser.Id
        End If
        Cmd.Parameters.Add(param)


        param = Cmd.CreateParameter
        param.ParameterName = "@Doc"
        If tipo.DocumentationVerifiedUser Is Nothing Then
            param.Value = DBNull.Value
        Else
            param.Value = tipo.DocumentationVerifiedUser.Id
        End If
        Cmd.Parameters.Add(param)

        param = Cmd.CreateParameter
        param.ParameterName = "@Clo"
        If tipo.ClosedPracticeuser Is Nothing Then
            param.Value = DBNull.Value
        Else
            param.Value = tipo.ClosedPracticeuser.Id
        End If
        Cmd.Parameters.Add(param)

        param = Cmd.CreateParameter
        param.ParameterName = "@Rej"
        If tipo.RejectedPractice Is Nothing Then
            param.Value = DBNull.Value
        Else
            param.Value = tipo.RejectedPractice.Id
        End If
        Cmd.Parameters.Add(param)


    End Sub

    Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)

        Dim tipo As TipoPratica = DirectCast(Item, TipoPratica)

        Dim param As IDbDataParameter = Cmd.CreateParameter
        param.ParameterName = "@Desc"
        param.Value = tipo.Descrizione
        Cmd.Parameters.Add(param)

        param = Cmd.CreateParameter
        param.ParameterName = "@Jol"
        If tipo.JollyUser Is Nothing Then
            param.Value = DBNull.Value
        Else
            param.Value = tipo.JollyUser.Id
        End If
        Cmd.Parameters.Add(param)

        param = Cmd.CreateParameter
        param.ParameterName = "@res"
        param.Value = tipo.RestrictedPermissions
        Cmd.Parameters.Add(param)


        param = Cmd.CreateParameter
        param.ParameterName = "@Con"
        If tipo.ControlUser Is Nothing Then
            param.Value = DBNull.Value
        Else
            param.Value = tipo.ControlUser.Id
        End If
        Cmd.Parameters.Add(param)

        param = Cmd.CreateParameter
        param.ParameterName = "@Int"
        If tipo.IntegrationUser Is Nothing Then
            param.Value = DBNull.Value
        Else
            param.Value = tipo.IntegrationUser.Id
        End If
        Cmd.Parameters.Add(param)


        param = Cmd.CreateParameter
        param.ParameterName = "@Doc"
        If tipo.DocumentationVerifiedUser Is Nothing Then
            param.Value = DBNull.Value
        Else
            param.Value = tipo.DocumentationVerifiedUser.Id
        End If
        Cmd.Parameters.Add(param)

        param = Cmd.CreateParameter
        param.ParameterName = "@Clo"
        If tipo.ClosedPracticeuser Is Nothing Then
            param.Value = DBNull.Value
        Else
            param.Value = tipo.ClosedPracticeuser.Id
        End If
        Cmd.Parameters.Add(param)

        param = Cmd.CreateParameter
        param.ParameterName = "@Rej"
        If tipo.RejectedPractice Is Nothing Then
            param.Value = DBNull.Value
        Else
            param.Value = tipo.RejectedPractice.Id
        End If
        Cmd.Parameters.Add(param)



        param = Cmd.CreateParameter
        param.ParameterName = "@Id"
        param.Value = tipo.Id
        Cmd.Parameters.Add(param)

    End Sub

End Class
