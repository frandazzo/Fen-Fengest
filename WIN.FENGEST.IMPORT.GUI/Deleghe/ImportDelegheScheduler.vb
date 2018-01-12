Imports WIN.APPLICATION.IMPORT_EXPORT_SERVICES
Imports System.Windows.Forms

Public Class ImportDelegheScheduler
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
    Private FileLogName = "ImportDeleghe"
    Private WithEvents m_DataRetriver As DataRetriever
    Private ListOfCommands As New Hashtable
    Private Data As ArrayList
    Private Errors As Int32 = 0
    Private Inserted As Int32 = 0


    Private m_updateUt As Boolean = False
    Private m_updateAz As Boolean = False



    Public Sub New(ByVal Filename As String, ByVal LogFilePath As String, ByVal updateUtenti As Boolean, ByVal updateAziende As Boolean)
        m_DataRetriver = New DataRetriever(Filename)
        m_LogPath = LogFilePath
        m_updateUt = updateUtenti
        m_updateAz = updateAziende
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
            MessageBox.Show(ex.Message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
            m_DataRetriver.Dispose()
        End Try

    End Sub
    Private Sub WriteData(ByVal RecordData As Hashtable, ByVal num As Int32)
        Dim CheckReparto As New ExsistRepartoChecker
        Dim CheckContratto As New ExsistContractChecker
        Dim CheckReferente As New ExsistReferenteChecKer
        Dim CheckAzienda As New ExsistAziendaChecker
        Dim CheckUtente As New ExistUserChekcer

        Dim InsertReparto As New InsertRepartoCommand(RecordData)
        Dim InsertContratto As New InsertContrattoCommand(RecordData)
        Dim InsertReferente As New InsertReferenteCommand(RecordData)
        Dim InsertAzienda As New InsertAziendeCommand(RecordData)
        Dim InsertUtente As New InsertUtentiCommand(RecordData)
        Dim InsertDelega As New InsertDelegaCommand(RecordData)

        Try
            If Not CheckReparto.Exist(RecordData) Then
                InsertReparto.Execute()
            End If
            If Not CheckContratto.Exist(RecordData) Then
                InsertContratto.Execute()
            End If
            If Not CheckReferente.Exist(RecordData) Then
                InsertReferente.Execute()
            End If

            'Inserimento o aggiornamento aziende x impianti fissi
            If Not RecordData.Item("SETTORE") = "EDILE" Then
                If Not CheckAzienda.Exist(RecordData) Then
                    InsertAzienda.Execute()
                Else
                    If m_updateAz Then
                        'solo in caso di aggiornamento notfico un eventuale errore ma non 
                        'esco dal ciclo perchè l'oggetto risulta cmq esistente
                        Try
                            Dim chkAz As New UpdateAziendaCommand(RecordData, CheckAzienda.GetId)
                            chkAz.Execute()
                        Catch ex1 As ImportAziendaException
                            My.Computer.FileSystem.WriteAllText(FileLogName, "Errore di aggiornamento: " & ex1.Message & vbCrLf & vbCrLf, True)
                        End Try
                    End If
                End If
            End If


            'Inserimento o aggiornamento utenti
            If Not CheckUtente.Exist(RecordData) Then
                InsertUtente.Execute()
            Else
                'solo in caso di aggiornamento notfico un eventuale errore ma non 
                'esco dal ciclo perchè l'oggetto risulta cmq esistente
                If m_updateUt Then
                    Try
                        Dim chkUt As New UpdateUtenteCommand(RecordData, CheckUtente.GetId)
                        chkUt.Execute()
                    Catch ex2 As ImportUtenteException
                        My.Computer.FileSystem.WriteAllText(FileLogName, "Errore di aggiornamento: " & ex2.Message & vbCrLf & vbCrLf, True)
                    End Try
                End If
            End If

            'inserimento delega
            InsertDelega.Execute()


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
