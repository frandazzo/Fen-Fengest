Public Class MapperRendiconto
    Inherits AbstractRDBMapper


#Region "Istruzioni Sql"

    Protected Overrides Function FindAllStatement() As String
        Return "Select * from DB_RENDICONTO"
    End Function

    Protected Overrides Function FindByKeyStatement() As String
        Return "Select * from DB_RENDICONTO where Id = @Id"
    End Function

    Protected Overrides Function InsertStatement() As String
        Return "Insert into DB_RENDICONTO (ID, DataCreazione, Tipo, Note, FilePath, Anno) values (@Id, @dc, @ti, @no, @fp, @an)"
    End Function

    Protected Overrides Function UpdateStatement() As String
        Return "UPDATE DB_RENDICONTO SET DataCreazione = @dc, Tipo = @ti, Note = @no, FilePath = @fp, Anno = @an  WHERE (Id =@Id)"
    End Function

    Protected Overrides Function DeleteStatement() As String
        Return "Delete from DB_RENDICONTO where Id = @Id"
    End Function

    Protected Overrides Function FindNextKeyStatement() As String
        Return "Select Max(Id) from DB_RENDICONTO"
    End Function

#End Region


#Region "Metodi per la ricerca dell'oggetto secondo l'id proposto"

    Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject

        Return DirectCast(MyBase.FindByKey(New Key(Id)), Rendiconto)

    End Function
    Protected Overloads Overrides Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable) As AbstractPersistenceObject
        Dim Fondo As New Rendiconto
        Fondo.Tipo = rs.Item("Tipo")
        Fondo.Descrizione = rs.Item("Note")
        Fondo.FilePath = rs.Item("FilePath")
        Fondo.DataCreazione = rs.Item("DataCreazione")
        Fondo.Anno = rs.Item("Anno")
        Fondo.Key = Key

        Return Fondo
    End Function
    'Protected Overrides Function GetCommand(ByVal CommandText As String) As System.Data.IDbCommand

    '   'Return New SqlClient1.SqlCommand(CommandText, DBConnectionManager.Instance.GetCurrentConnection)
    '   Return DBTypeUtils.GetCommand(Me.m_PersistentService.ServiceName, CommandText, DBConnectionManager.Instance.GetCurrentConnection)

    'End Function

#End Region




    Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
        Dim tipo As Rendiconto = DirectCast(Item, Rendiconto)

        Dim param As IDbDataParameter = Cmd.CreateParameter
        param.ParameterName = "@dc"
        param.Value = tipo.DataCreazione
        Cmd.Parameters.Add(param)

        param = Cmd.CreateParameter
        param.ParameterName = "@ti"
        param.Value = tipo.Tipo
        Cmd.Parameters.Add(param)

        param = Cmd.CreateParameter
        param.ParameterName = "@no"
        param.Value = tipo.Descrizione
        Cmd.Parameters.Add(param)

        param = Cmd.CreateParameter
        param.ParameterName = "@fp"
        param.Value = tipo.FilePath
        Cmd.Parameters.Add(param)


        param = Cmd.CreateParameter
        param.ParameterName = "@an"
        param.Value = tipo.Anno
        Cmd.Parameters.Add(param)
    End Sub

    Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)

        Dim tipo As Rendiconto = DirectCast(Item, Rendiconto)

        Dim param As IDbDataParameter = Cmd.CreateParameter
        param.ParameterName = "@dc"
        param.Value = tipo.DataCreazione
        Cmd.Parameters.Add(param)

        param = Cmd.CreateParameter
        param.ParameterName = "@ti"
        param.Value = tipo.Tipo
        Cmd.Parameters.Add(param)

        param = Cmd.CreateParameter
        param.ParameterName = "@no"
        param.Value = tipo.Descrizione
        Cmd.Parameters.Add(param)

        param = Cmd.CreateParameter
        param.ParameterName = "@fp"
        param.Value = tipo.FilePath
        Cmd.Parameters.Add(param)

        param = Cmd.CreateParameter
        param.ParameterName = "@an"
        param.Value = tipo.Anno
        Cmd.Parameters.Add(param)

        param = Cmd.CreateParameter
        param.ParameterName = "@Id"
        param.Value = tipo.Id
        Cmd.Parameters.Add(param)

    End Sub

End Class


