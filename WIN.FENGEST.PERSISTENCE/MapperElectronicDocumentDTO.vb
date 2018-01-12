Public Class MapperElectronicDocumentDTO
    Inherits AbstractRDBMapper


    Public Sub New()
        Me.UseDefaultCacheMechanism = False
        Me.Cache = New PersistentObjectCache(0)
    End Sub
#Region "Istruzioni Sql"

    Protected Overrides Function FindAllStatement() As String
        Throw New Exception("Not implemented method")
    End Function

    Protected Overrides Function FindByKeyStatement() As String
        Throw New Exception("Not implemented method")
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
        Throw New Exception("Not implemented method")

    End Function
    Protected Overloads Overrides Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable) As AbstractPersistenceObject
        Try
            Dim OwnerId As Int32
            Dim DocumentTypeId As Int32
            Dim ExecutorId As Int32

            Dim Descrizione As String = "" 'dato obbligatorio per utenti e aziende (nome e cognome o ragione sociale)
            Dim Fiscal As String = ""
            Dim DocumentType As String = ""
            Dim ExecutedBy As String = ""
            Dim FileName As String = ""
            Dim Notes As String = ""

            Dim Data As DateTime

            Descrizione = rs("Description")
            OwnerId = rs("OwnerId")
            DocumentType = rs("DocumentType")
            DocumentTypeId = rs("DocumentTypeId")
            FileName = rs("FILE_NAME")

            Data = rs("DATA")

            If Not IsDBNull(rs("Fiscal")) Then
                Fiscal = rs("Fiscal")
            End If
            If Not IsDBNull(rs("NOTES")) Then
                Notes = rs("NOTES")
            End If

            If Not IsDBNull(rs("ExecutedBy")) Then
                ExecutedBy = rs("ExecutedBy")
            End If
            If Not IsDBNull(rs("ExecutorId")) Then
                ExecutorId = rs("ExecutorId")
            End If




          
            Dim com As ElectronicDocumentDTO = New ElectronicDocumentDTO

            com.Key = Key
            com.Descrizione = Descrizione
            com.OwnerId = OwnerId

            com.Fiscal = Fiscal
            com.DocumentType = DocumentType
            com.Data = Data
            com.ExecutedBy = ExecutedBy
            com.FileName = FileName
            com.Notes = Notes
            com.DocumentId = DocumentTypeId
            com.ExecutorId = ExecutorId



            Return com
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

