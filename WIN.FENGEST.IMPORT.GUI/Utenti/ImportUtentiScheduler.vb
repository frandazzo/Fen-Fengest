Imports WIN.APPLICATION.IMPORT_EXPORT_SERVICES
Imports WIN.APPLICATION

Public Class ImportUtentiScheduler


    Public Event BeginParse()
    Public Event EndParse(ByVal NumberOfRecords As Int32)
    Public Event BeginRetrieving()
    Public Event RetrievingRecord(ByVal IdRecord As Int32)
    Public Event BeginWriting()
    Public Event WritingRecord(ByVal IdRecord As Int32)
    Public Event EndWriting(ByVal Errors As Int32, ByVal Inserted As Int32)
    Public Event EndRetrieving(ByVal NumberOfRecords As Int32)

    Public Event ListCreated(ByVal ListName As String)
    Private m_FileName As String = ""
    Private m_LogPath As String = ""
    Private FileLogName = "ImportAnagraficheUtente"
    Private WithEvents m_DataRetriver As DataRetrieverAnagraficheUtente
    Private ListOfCommands As New Hashtable
    Private Data As ArrayList
    Private Errors As Int32 = 0
    Private Inserted As Int32 = 0

    Private m_update As Boolean = False
    Private m_createlist As Boolean = False
    Private m_updateComunications As Boolean = False
    Private m_CalcolaCodiceFiscaleFittizio = False
    Dim ControllerLista As ControllerListaUtenti

    Public Sub New(ByVal Filename As String, ByVal LogFilePath As String, ByVal UpdateExisting As Boolean, ByVal CreateList As Boolean, updateComunicationsData As Boolean)
        m_DataRetriver = New DataRetrieverAnagraficheUtente(Filename)
        m_LogPath = LogFilePath
        m_update = UpdateExisting
        m_createlist = CreateList
        m_updateComunications = updateComunicationsData
    End Sub
    Public Sub New(ByVal Filename As String, ByVal LogFilePath As String, ByVal UpdateExisting As Boolean, ByVal CreateList As Boolean, updateComunicationsData As Boolean, CalcolaCodiceFiscaleFittizio As Boolean)
        m_DataRetriver = New DataRetrieverAnagraficheUtente(Filename)
        m_LogPath = LogFilePath
        m_update = UpdateExisting
        m_createlist = CreateList
        m_updateComunications = updateComunicationsData
        m_CalcolaCodiceFiscaleFittizio = CalcolaCodiceFiscaleFittizio
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
                If (m_CalcolaCodiceFiscaleFittizio) Then
                    elem.Add("CALCOLACFFITTIZIO", "")
                End If
                WriteData(elem, i)
                RaiseEvent WritingRecord(i)
            Next

            If m_createlist Then
                Me.SaveLista()
            End If
            RaiseEvent EndWriting(Errors, Inserted)

            If m_createlist Then
                'Me.SaveLista()
                RaiseEvent ListCreated(ControllerLista.Descrizione)
            End If
        Catch ex As Exception
            m_DataRetriver.Dispose()
            Throw
        End Try

    End Sub

    Private Sub AddElementToList(ByVal id As String)
        If ControllerLista Is Nothing Then
            ControllerLista = New ControllerListaUtenti
            ControllerLista.CreateNew()
            ControllerLista.Descrizione = "ListaImportazione_" & Format(DateTime.Now, "dd-MM-yyyy hh-mm-ss")
        End If

        Try
            ControllerLista.AddUtente(id)
        Catch ex As Exception
            'Nonn fa nulla
        End Try


    End Sub


    Private Sub SaveLista()
        If ControllerLista Is Nothing Then
            Return
        End If


        Try
            ControllerLista.Save()
        Catch ex As Exception
            My.Computer.FileSystem.WriteAllText(FileLogName, "Errore nel salvaggio della lista di lavoro" & Environment.NewLine & ex.Message, True)
        End Try

    End Sub

    Private Sub WriteData(ByVal RecordData As Hashtable, ByVal num As Int32)


        Dim CheckUtente As New ExistUserChekcer


        Dim InsertUtente As New InsertUtentiCommand(RecordData)


        Try


            If Not CheckUtente.Exist(RecordData) Then
                InsertUtente.Execute()
            Else
                'If m_update Then
                Dim updateCommand As New PartialUpdateUtenteCommand(RecordData, CheckUtente.GetId, m_updateComunications, m_update)
                updateCommand.Execute()
                'End If
            End If

            CheckUtente.Exist(RecordData)

            If m_createlist Then
                Me.AddElementToList(CheckUtente.GetId)
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


