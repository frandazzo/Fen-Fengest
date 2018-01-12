Imports WIN.APPLICATION.IMPORT_EXPORT_SERVICES

Public Class BackgroundLiberiImporter
    Private m_data As ArrayList
    Protected m_LogPath As String = ""


    Protected m_updateUt As Boolean = False
    Protected m_updateAz As Boolean = False
    Private m_overWriteLib As Boolean = False

    Dim m_RowReference As Int32






    Public Sub New(data As ArrayList, ByVal LogFilePath As String, ByVal updateUtenti As Boolean, ByVal updateAziende As Boolean, ByVal overWriteLib As Boolean)

        m_data = data
        m_LogPath = LogFilePath
        m_updateUt = updateUtenti
        m_updateAz = updateAziende
        m_overWriteLib = overWriteLib


    End Sub


    Public Sub Import()





        Try
            InsertData(m_data)
        Catch ex As Exception



            My.Computer.FileSystem.WriteAllText(m_LogPath, String.Format("Errore nel salvataggio dei lavoratori liberi.  {0}{1}", ex.Message, vbCrLf), True)
            My.Computer.FileSystem.WriteAllText(m_LogPath, "***********************ERROR***********************" + vbCrLf, True)

        End Try




    End Sub

    Private Sub InsertData(m_data As ArrayList)
        For Each elem As Hashtable In m_data
            m_RowReference = m_RowReference + 1
            WriteData(elem, m_RowReference)

        Next
    End Sub

    Private Sub WriteData(ByVal RecordData As Hashtable, ByVal num As Int32)

        Dim CheckContratto As New ExsistContractChecker
        Dim CheckAzienda As New ExsistAziendaChecker(True)
        Dim CheckUtente As New ExistUserChekcer


        Dim InsertContratto As New InsertContrattoCommand(RecordData)
        Dim InsertAzienda As New InsertAziendeCommand(RecordData, True)
        Dim InsertUtente As New InsertUtentiCommand(RecordData)
        Dim InsertInfo As New InsertInfoUtenteCommand(RecordData, m_overWriteLib)

        Try
            If Not CheckContratto.Exist(RecordData) Then
                InsertContratto.Execute()
            End If

            'inserimento aziende
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
                        My.Computer.FileSystem.WriteAllText(m_LogPath, "Errore di aggiornamento: " & ex1.Message & vbCrLf & vbCrLf, True)
                    End Try
                End If
            End If


            'inserimento utenti
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
                        My.Computer.FileSystem.WriteAllText(m_LogPath, "Errore di aggiornamento: " & ex2.Message & vbCrLf & vbCrLf, True)
                    End Try
                End If
            End If

            InsertInfo.Execute()

        Catch ex As Exception
            My.Computer.FileSystem.WriteAllText(m_LogPath, "Riga numero:" & num & "; " & ex.Message & vbCrLf & vbCrLf, True)

        End Try
    End Sub

End Class
