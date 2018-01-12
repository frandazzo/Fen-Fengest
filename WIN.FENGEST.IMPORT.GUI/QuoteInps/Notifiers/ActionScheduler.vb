Imports WIN.APPLICATION.IMPORT_EXPORT_SERVICES

Public Class ActionScheduler

    Public Event DocumentsFound(ByVal NumberOfDocuments As Int32)
    Public Event BeginDocumentWriting()
    Public Event WritingDocument(idDocument As Int32)
    Public Event EndImport(ByVal Errors As Int32, ByVal Inserted As Int32)
    Public Event NotifyDocumentError(errorData As String)

    Public Event BeginParsePath()
    Public Event EndParsePath(NumberOfFilesFound As Integer)
    Public Event BeginParseFile(filename As String, number As Integer)
    Public Event EndParseFile(filename As String, exception As Exception)




    Public Event BeginParse()
    Public Event EndParse(ByVal NumberOfRecords As Int32)
    Public Event BeginRetrieving()
    Public Event RetrievingRecord(ByVal IdRecord As Int32)
    Public Event EndRetrieving(ByVal NumberOfRecords As Int32)



    Private WithEvents m_DataRetriver As DataInfoRetriever
    Private WithEvents m_MultipleDataRetriver As MultipleFileDataRetriever
    Protected Data As ArrayList


    Public ReadOnly Property ExtractedData As IList
        Get
            Return Data
        End Get
    End Property


    Private type As Int32


    Public Sub New(dataRetriver As DataInfoRetriever)
        type = 1
        m_DataRetriver = dataRetriver
    End Sub
    Public Sub New(dataRetriver As MultipleFileDataRetriever, fromIQITemplate As Boolean)
        'indico se verifichero la lettura di un file excel per un insieme di file
        'inps o un insieme di file iqi
        If fromIQITemplate Then
            type = 2
        Else
            type = 3
        End If

        m_MultipleDataRetriver = dataRetriver
    End Sub


    Public Sub StartImport()

        If type = 1 Then
            m_DataRetriver.OpenExcel()
            m_DataRetriver.ParseData()
            Data = m_DataRetriver.RetrieveData()
            m_DataRetriver.Dispose()
        ElseIf type = 2 Then
            m_MultipleDataRetriver.ValidateAndParsePath()
            m_MultipleDataRetriver.StartImport()
            Data = m_MultipleDataRetriver.Importresult
        Else
            m_MultipleDataRetriver.ValidateAndParsePath()
            m_MultipleDataRetriver.StartImport()
            Data = HashTableFromInpsTemplateConverter.ConvertToIQITemplateHashList(m_MultipleDataRetriver.Importresult)
        End If




    End Sub


    Protected Sub m_DataRetriver_BeginParse() Handles m_DataRetriver.BeginParse
        RaiseEvent BeginParse()
    End Sub

    Protected Sub m_DataRetriver_BeginRetrieving() Handles m_DataRetriver.BeginRetrieving
        RaiseEvent BeginRetrieving()
    End Sub

    Protected Sub m_DataRetriver_EndParse(ByVal NumberOfRecords As Integer, ByVal NumberOfFields As Integer) Handles m_DataRetriver.EndParse
        RaiseEvent EndParse(NumberOfRecords)
    End Sub

    Protected Sub m_DataRetriver_EndRetrieving(ByVal NumberOfRecords As Integer) Handles m_DataRetriver.EndRetrieving
        RaiseEvent EndRetrieving(NumberOfRecords)
    End Sub

    Protected Sub m_DataRetriver_RetrievingRecord(ByVal IdRecord As Integer) Handles m_DataRetriver.RetrievingRecord
        RaiseEvent RetrievingRecord(IdRecord)
    End Sub




    Protected Sub m_MultipleDataRetriver_BeginParse() Handles m_MultipleDataRetriver.BeginParse
        RaiseEvent BeginParse()
    End Sub

    Protected Sub m_MultipleDataRetriver_BeginRetrieving() Handles m_MultipleDataRetriver.BeginRetrieving
        RaiseEvent BeginRetrieving()
    End Sub

    Protected Sub m_MultipleDataRetriver_EndParse(ByVal NumberOfRecords As Integer, ByVal NumberOfFields As Integer) Handles m_MultipleDataRetriver.EndParse
        RaiseEvent EndParse(NumberOfRecords)
    End Sub

    Protected Sub m_MultipleDataRetriver_EndRetrieving(ByVal NumberOfRecords As Integer) Handles m_MultipleDataRetriver.EndRetrieving
        RaiseEvent EndRetrieving(NumberOfRecords)
    End Sub

    Protected Sub m_MultipleDataRetriver_RetrievingRecord(ByVal IdRecord As Integer) Handles m_MultipleDataRetriver.RetrievingRecord
        RaiseEvent RetrievingRecord(IdRecord)
    End Sub



    Private Sub m_MultipleDataRetriver_EndParseFile(filename As String, exception As System.Exception) Handles m_MultipleDataRetriver.EndParseFile
        RaiseEvent EndParseFile(filename, exception)
    End Sub

    Private Sub m_MultipleDataRetriver_EndParsePath(NumberOfFilesFound As Integer) Handles m_MultipleDataRetriver.EndParsePath
        RaiseEvent EndParsePath(NumberOfFilesFound)
    End Sub

    Private Sub m_MultipleDataRetriver_BeginParseFile(filename As String, number As Integer) Handles m_MultipleDataRetriver.BeginParseFile
        RaiseEvent BeginParseFile(filename, number)
    End Sub

    Private Sub m_MultipleDataRetriver_BeginParsePath() Handles m_MultipleDataRetriver.BeginParsePath
        RaiseEvent BeginParsePath()
    End Sub

    Private Sub m_MultipleDataRetriver_EndCreatingRecord(sheet As Object, hash As System.Collections.Hashtable) Handles m_MultipleDataRetriver.EndCreatingRecord
        If type = 3 Then 'se sto importando da file inps imposto il tipo di prestazione
            hash.Add("TIPO_PRESTAZIONE", sheet.Cells(6, 7).Value)
        End If
    End Sub
End Class
