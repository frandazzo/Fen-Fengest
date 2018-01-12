Imports WIN.APPLICATION.IMPORT_EXPORT_SERVICES

Public Class ImportAziendeScheduler


    Public Event BeginParse()
    Public Event EndParse(ByVal NumberOfRecords As Int32)
    Public Event BeginRetrieving()
    Public Event RetrievingRecord(ByVal IdRecord As Int32)
    Public Event BeginWriting()
    Public Event WritingRecord(ByVal IdRecord As Int32)
    Public Event EndWriting(ByVal Errors As Int32, ByVal Inserted As Int32)
    Public Event EndRetrieving(ByVal NumberOfRecords As Int32)
    Private m_FileName As String = ""
    Private m_LogPath As String = ""
    Private FileLogName = "ImportAnagraficheAziende"
    Private WithEvents m_DataRetriver As DataRetrieverAnagraficheAziende
    Private ListOfCommands As New Hashtable
    Private Data As ArrayList
    Private Errors As Int32 = 0
    Private Inserted As Int32 = 0
    Private m_Update As Boolean = False

    Public Sub New(ByVal Filename As String, ByVal LogFilePath As String, ByVal update As Boolean)
        m_DataRetriver = New DataRetrieverAnagraficheAziende(Filename)
        m_LogPath = LogFilePath
        m_Update = update
    End Sub

    Public Sub StartImport()
        Try
            m_DataRetriver.OpenExcel()
            m_DataRetriver.ParseData()
            Data = m_DataRetriver.RetrieveData()
            m_DataRetriver.Dispose()
            FileLogName = FileLogName & Now.ToString("ddMMyyyy")
            FileLogName = m_LogPath & "/" & FileLogName & ".txt"
            'Adesso bisogna ciclare sui dati per inserrli attraverso i comandi
            Dim i As Int32 = 0
            RaiseEvent BeginWriting()
            For Each elem As Hashtable In Data
                i = i + 1
                WriteData(elem, i)
                RaiseEvent WritingRecord(i)
            Next
            RaiseEvent EndWriting(Errors, Inserted)
        Catch ex As Exception
            m_DataRetriver.Dispose()
            Throw
        End Try

    End Sub
    Private Sub WriteData(ByVal RecordData As Hashtable, ByVal num As Int32)

        Dim CheckContratto As New ExsistContractChecker
        Dim CheckAzienda As New ExsistAziendaChecker(True)



        Dim InsertContratto As New InsertContrattoCommand(RecordData)
        Dim InsertAzienda As New InsertAziendeCommand(RecordData, True)


        Try
            If Not CheckContratto.Exist(RecordData) Then
                InsertContratto.Execute()
            End If

            If Not CheckAzienda.Exist(RecordData) Then


                InsertAzienda.Execute()

            Else
                If m_Update Then
                    Dim updateCommand As New UpdateAziendaCommand(RecordData, CheckAzienda.GetId)
                    updateCommand.Execute()
                End If
            End If



            Inserted = Inserted + 1
        Catch ex As Exception
            My.Computer.FileSystem.WriteAllText(FileLogName, "Riga numero:" & num & "; " & ex.Message & vbCrLf & vbCrLf, True)
            Errors = Errors + 1
        End Try
    End Sub


    Private Sub m_DataRetriver_BeginParse() Handles m_DataRetriver.BeginParse
        RaiseEvent BeginParse()
    End Sub

    Private Sub m_DataRetriver_BeginRetrieving() Handles m_DataRetriver.BeginRetrieving
        RaiseEvent BeginRetrieving()
    End Sub

    Private Sub m_DataRetriver_EndParse(ByVal NumberOfRecords As Integer, ByVal NumberOfFields As Integer) Handles m_DataRetriver.EndParse
        RaiseEvent EndParse(NumberOfRecords)
    End Sub

    Private Sub m_DataRetriver_EndRetrieving(ByVal NumberOfRecords As Integer) Handles m_DataRetriver.EndRetrieving
        RaiseEvent EndRetrieving(NumberOfRecords)
    End Sub

    Private Sub m_DataRetriver_RetrievingRecord(ByVal IdRecord As Integer) Handles m_DataRetriver.RetrievingRecord
        RaiseEvent RetrievingRecord(IdRecord)
    End Sub
End Class
