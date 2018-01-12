Imports WIN.DOMAIN.FEDERATIONARTIFACTS.ImportExport

Public Class MapperImportExport
    Inherits AbstractRDBMapper

#Region "Istruzioni Sql"
    Protected Overrides Function FindAllStatement() As String
        Return "Select * from DB_IMPORT_EXPORT"
    End Function
    Protected Overrides Function FindByKeyStatement() As String
        Return "Select * from DB_IMPORT_EXPORT where Id = @Id"
    End Function
    Protected Overrides Function InsertStatement() As String
        Return "Insert into DB_IMPORT_EXPORT (ID, ElaborationData, Type, " _
             & "CreatedDocumentId, LogFilePath, ImportedFile, Result, Subject, LiberiImportedData) values (@Id, @ela, @typ, @cre, @log, @imp, @res, @sub, @lib)"
    End Function
    Protected Overrides Function UpdateStatement() As String
        Return "UPDATE DB_IMPORT_EXPORT SET ElaborationData = @ela, " _
              & "Type = @typ, CreatedDocumentId = @cre, " _
              & "LogFilePath = @log, ImportedFile = @imp, Result = @res, Subject = @sub, LiberiImportedData = @lib  WHERE (Id =@Id) "
    End Function
    Protected Overrides Function DeleteStatement() As String
        Return "Delete from DB_IMPORT_EXPORT where Id = @Id"
    End Function
    Protected Overrides Function FindNextKeyStatement() As String
        Return "Select Max(Id) from DB_IMPORT_EXPORT"
    End Function
#End Region




    Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject

        Return DirectCast(MyBase.FindByKey(New Key(Id)), ImportExport)

    End Function

    Protected Overloads Overrides Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable) As AbstractPersistenceObject

        Dim DataRegistrazione As DateTime = IIf(rs.Item("ElaborationData") IsNot Nothing, rs.Item("ElaborationData"), DateTime.Now)

        Dim type As String = IIf(rs.Item("Type") IsNot Nothing, rs.Item("Type"), "")
        Dim docid As Int32 = IIf(rs.Item("CreatedDocumentId") IsNot Nothing, rs.Item("CreatedDocumentId"), 0)
        Dim FILE_Log As String = IIf(rs("LogFilePath") IsNot Nothing, rs("LogFilePath"), "")
        Dim FILE_Imported As String = IIf(rs("ImportedFile") IsNot Nothing, rs("ImportedFile"), "")


        Dim result As ResultType = IIf(rs("Result") IsNot Nothing, rs("Result"), ResultType.FileRenamedWithoutHasBeenProcessed)
        Dim liberiimporteddata As String = IIf(rs("LiberiImportedData") IsNot Nothing, rs("LiberiImportedData"), "")
        Dim subject As String = IIf(rs("Subject") IsNot Nothing, rs("Subject"), "")

        Dim i As New ImportExport

        i.Key = Key
        i.ImportedFile = FILE_Imported
        i.LogFilePath = FILE_Log
        i.ElaborationData = DataRegistrazione
        i.Type = DirectCast([Enum].Parse(GetType(ElaborationType), type), ElaborationType)
        i.Result = result
        i.Subject = subject
        i.LiberiImportedData = liberiimporteddata

        i.CreatedDocumentId = docid

        Return i
    End Function


    Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
        Try

            Dim ImportExport As ImportExport = DirectCast(Item, ImportExport)

            Dim param As IDbDataParameter = Cmd.CreateParameter
            param.ParameterName = "@ela"
            param.Value = ImportExport.ElaborationData
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@typ"
            param.Value = ImportExport.Type.ToString
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@cre"
            param.Value = ImportExport.CreatedDocumentId
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@log"
            param.Value = ImportExport.LogFilePath
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@imp"
            param.Value = ImportExport.ImportedFile
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@res"
            param.Value = ImportExport.Result
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@sub"
            param.Value = ImportExport.Subject
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@lib"
            param.Value = ImportExport.LiberiImportedData
            Cmd.Parameters.Add(param)

         


        Catch ex As Exception
            Throw New Exception("Impossibile creare un parametro per la chiave identificativa nel comando per l'inserimento di un oggetto" & vbCrLf & ex.Message)
        End Try

    End Sub

    Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
        Try

            Dim ImportExport As ImportExport = DirectCast(Item, ImportExport)

            Dim param As IDbDataParameter = Cmd.CreateParameter
            param.ParameterName = "@ela"
            param.Value = ImportExport.ElaborationData
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@typ"
            param.Value = ImportExport.Type.ToString
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@cre"
            param.Value = ImportExport.CreatedDocumentId
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@log"
            param.Value = ImportExport.LogFilePath
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@imp"
            param.Value = ImportExport.ImportedFile
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@res"
            param.Value = ImportExport.Result
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@sub"
            param.Value = ImportExport.Subject
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@lib"
            param.Value = ImportExport.LiberiImportedData
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@Id"
            param.Value = ImportExport.Id
            Cmd.Parameters.Add(param)


        Catch ex As Exception
            Throw New Exception("Impossibile creare un parametro per la chiave identificativa nel comando per l'inserimento di un oggetto" & vbCrLf & ex.Message)
        End Try

    End Sub
End Class
