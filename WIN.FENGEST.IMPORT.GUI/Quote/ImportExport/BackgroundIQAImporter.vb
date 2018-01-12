Imports WIN.APPLICATION.IMPORT_EXPORT_SERVICES

Public Class BackgroundIQAImporter

    Private m_data As ArrayList
    Protected m_LogPath As String = ""
  



    Protected InsertIQA As InsertIQACommand

    Protected m_checkPaybility As Boolean = True
    Protected m_updateUt As Boolean = False
    Protected m_updateAz As Boolean = False
    Protected m_addDelega As Boolean = False
    Dim m_RowReference As Int32



    Public ReturnedDocumentId As Int32



    Public Sub New(data As ArrayList, ByVal LogFilePath As String, ByVal updateUtenti As Boolean, ByVal updateAziende As Boolean, ByVal addDelega As Boolean)

        m_data = data
        m_LogPath = LogFilePath
        m_updateUt = updateUtenti
        m_updateAz = updateAziende
        m_addDelega = addDelega


    End Sub


    Public Sub Import()

        ReturnedDocumentId = 0



        Try  
            ReturnedDocumentId = InsertDocumentData(m_data)
        Catch ex As Exception

            ReturnedDocumentId = 0

            My.Computer.FileSystem.WriteAllText(m_LogPath, String.Format("Errore nel salvataggio del documento IQA.  {0}{1}", ex.Message, vbCrLf), True)
            My.Computer.FileSystem.WriteAllText(m_LogPath, "***********************ERROR***********************" + vbCrLf, True)

        End Try




    End Sub



    Private Function InsertDocumentData(singleDocument_Data As ArrayList) As Int32
        'Adesso bisogna ciclare sui dati per inserrli attraverso i comandi
        Dim i As Int32 = 0

        For Each elem As Hashtable In singleDocument_Data
            i = i + 1
            Try
                WriteRequiredData(elem)
            Catch ex As Exception

            End Try

        Next

        'inserisco il documento
        InsertIQA = New InsertIQACommand(singleDocument_Data, m_LogPath, m_checkPaybility)
        InsertIQA.Execute()


        Return InsertIQA.SavedDocumentId




    End Function

    Protected Sub WriteRequiredData(ByVal RecordData As Hashtable)
        Dim CheckContratto As New ExsistContractChecker
        Dim CheckReferente As New ExsistReferenteChecKer
        Dim CheckAzienda As New ExsistAziendaChecker
        Dim CheckAziendaImpiego As New ExistAzindaImpiegoChecker
        Dim CheckUtente As New ExistUserForIQAChecker


        Dim InsertContratto As New InsertContrattoCommand(RecordData)
        Dim InsertReferente As New InsertReferenteCommand(RecordData)
        Dim InsertAzienda As New InsertAziendeCommand(RecordData)
        Dim InsertAziendaImpiego As New InsertAziendeCommand(RecordData, True)
        Dim InsertUtente As New InsertUtentiCommand(RecordData)
        'Dim InsertIQA As New InsertIQACommand(Data)

        Try

            m_RowReference = m_RowReference + 1

            If Not CheckContratto.Exist(RecordData) Then
                InsertContratto.Execute()
            End If
            If Not CheckReferente.Exist(RecordData) Then
                InsertReferente.Execute()
            End If

            'Inserimento aziende settore edile
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
                            My.Computer.FileSystem.WriteAllText(m_LogPath, "Errore di aggiornamento: " & ex1.Message & vbCrLf & vbCrLf, True)
                        End Try
                    End If
                End If
            End If
            'inserimento aziende settore impianti fissi
            If RecordData.Item("SETTORE") = "EDILE" Then
                If Not CheckAziendaImpiego.Exist(RecordData) Then
                    InsertAziendaImpiego.Execute()
                Else
                    If m_updateAz Then
                        'solo in caso di aggiornamento notfico un eventuale errore ma non 
                        'esco dal ciclo perchè l'oggetto risulta cmq esistente
                        Try
                            Dim chkAz As New UpdateAziendaCommand(RecordData, CheckAziendaImpiego.GetId)
                            chkAz.Execute()
                        Catch ex1 As ImportAziendaException
                            My.Computer.FileSystem.WriteAllText(m_LogPath, "Errore di aggiornamento: " & ex1.Message & vbCrLf & vbCrLf, True)
                        End Try
                    End If
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



            'inserisco la delega per l'utente nel caso la quota non è pagabile
            If m_addDelega Then

                Try





                    Dim insertDelega As New InsertDelegaCommand(CreaHash(RecordData), True, New DataRange(RecordData.Item("DATA_INIZIO"), RecordData.Item("DATA_FINE")))
                    insertDelega.Execute()

                    If insertDelega.Inserted Then
                        Dim nomeUtente As String = RecordData.Item("COGNOME_UTENTE") + " " + RecordData.Item("NOME_UTENTE")
                        My.Computer.FileSystem.WriteAllText(m_LogPath, "Delega automaticamente inserita per l'utente " + nomeUtente + Environment.NewLine, True)
                    End If




                Catch ex As ImportDelegaException
                    My.Computer.FileSystem.WriteAllText(m_LogPath, "Errore nella creazione della delega: " & ex.Message & vbCrLf & vbCrLf, True)
                End Try






            End If




            'Inserted = Inserted + 1
        Catch ex As Exception
            My.Computer.FileSystem.WriteAllText(m_LogPath, "Riga numero:" & m_RowReference & "; " & ex.Message & vbCrLf & vbCrLf, True)
            'Errors = Errors + 1
            'Throw
        End Try
    End Sub


    Private Function CreaHash(ByVal Hashtable As Hashtable) As Hashtable
        'in questa funzione devo ricreare una hash table come quando importo le deleghe
        Dim result As New Hashtable

        Dim accettazione As DateTime

        Try
            accettazione = Convert.ToDateTime(Hashtable.Item("DATA_INIZIO")).AddDays(-1)
        Catch ex As Exception
            accettazione = DateTime.Now.Date
        End Try


        result.Add("NOTE", "Delega automaticamente generata attraverso la registrazione dell'incasso quota associativa del " + DateTime.Now.ToString)
        result.Add("DATA_NASCITA_UTENTE", Hashtable.Item("DATA_NASCITA_UTENTE"))
        result.Add("NOME_UTENTE", Hashtable.Item("NOME_UTENTE"))
        result.Add("COGNOME_UTENTE", Hashtable.Item("COGNOME_UTENTE"))
        result.Add("FISCALE", Hashtable.Item("FISCALE"))
        result.Add("PARTITA_IVA", Hashtable.Item("PARTITA_IVA"))
        result.Add("NOME_REFERENTE", Hashtable.Item("NOME_REFERENTE"))
        result.Add("COGNOME_REFERENTE", Hashtable.Item("COGNOME_REFERENTE"))
        result.Add("SETTORE", Hashtable.Item("SETTORE"))
        result.Add("ENTE", Hashtable.Item("ENTE"))
        result.Add("REVOCATA_A", "")
        result.Add("SEDE_OPERATIVA", "")
        result.Add("DATA", accettazione)
        result.Add("REPARTO", "")
        result.Add("DATA_ACCETTAZIONE", accettazione)

        result.Add("DATA_ANNULLAMENTO", "")
        result.Add("DATA_REVOCA", "")





        Return result
    End Function

End Class
