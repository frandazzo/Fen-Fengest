Public Class MapperSmsProviderData
    Inherits AbstractRDBMapper



#Region "Istruzioni Sql"

    Protected Overrides Function FindAllStatement() As String
        Return "Select * from DB_SMSPROVIDERDATA"
    End Function

    Protected Overrides Function FindByKeyStatement() As String
        Return "Select * from DB_SMSPROVIDERDATA where Id = @Id "
    End Function

    Protected Overrides Function InsertStatement() As String
        Throw New Exception("Not implemented method")
    End Function

    Protected Overrides Function UpdateStatement() As String
        Throw New Exception("Not implemented method")
    End Function

    Protected Overrides Function DeleteStatement() As String
        Throw New Exception("Not implemented method")
    End Function

    Protected Overrides Function FindNextKeyStatement() As String
        Throw New Exception("Not implemented method")
    End Function

#End Region


#Region "Metodi per la ricerca dell'oggetto secondo l'id proposto"

    Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject
        Try
            Return DirectCast(MyBase.FindByKey(New Key(Id)), SmsProviderData)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function
    Protected Overloads Overrides Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable) As AbstractPersistenceObject
        Try

         

            Dim s As New SmsProviderData
            s.Key = Key
            s.Provicer = rs("ProviderName")
            s.Username = rs("Username")
            s.Password = rs("Password")
            s.SmsOption1 = rs("SmsOption1")
            s.SenderAlias = rs("SenderAlias")
            s.SenderNumber = rs("SenderNumber")





            Return s
        Catch ex As Exception
            Throw New Exception("Impossibile caricare l'oggetto comune con Id = " & Key.LongValue & ". " & vbCrLf & ex.Message)
        End Try
    End Function
    'Protected Overrides Function GetCommand(ByVal CommandText As String) As System.Data.IDbCommand

    '   'Return New SqlClient1.SqlCommand(CommandText, DBConnectionManager.Instance.GetCurrentConnection)
    '   Return DBTypeUtils.GetCommand(Me.m_PersistentService.ServiceName, CommandText, DBConnectionManager.Instance.GetCurrentConnection)
    'End Function

#End Region




    Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
        Throw New Exception("Not implemented method")
    End Sub

    Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
        Throw New Exception("Not implemented method")
    End Sub


End Class
