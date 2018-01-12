Public Class MapperDelegaDTO
    Inherits AbstractRDBMapper

    Public Sub New()
        'MyBase.Cache = New PersistentObjectCache(True)
    End Sub

#Region "Istruzioni Sql"




    Protected Overrides Function FindAllStatement() As String
        Return "Select * from DB_DELEGHE_UTENTE "
    End Function
    Protected Overrides Function FindByKeyStatement() As String
        Return ""
    End Function
    Protected Overrides Function InsertStatement() As String
        Return ""
    End Function
    Protected Overrides Function UpdateStatement() As String
        Return ""
    End Function
    'la cancellazione di un insieme di posizioni legate ad un PagamentoItem avverrà tramite cancellazione a cascata
    'del PagamentoItem. Verrà impostata una relazione su DB con queste opzioni
    Protected Overrides Function DeleteStatement() As String
        Return ""
    End Function
    Protected Overrides Function FindNextKeyStatement() As String
        Return ""
    End Function
#End Region





#Region "Metodi per il caricamento dell'oggetto"

    Protected Overloads Overrides Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable) As AbstractPersistenceObject


      


        Dim DATA_REGISTRAZIONE As DateTime = rs("DATA_SOTTOSCRIZIONE")
        Dim DATA_DOCUMENTO As DateTime = rs("DATA_DOCUMENTO")
        Dim DATA_INOLTRO As DateTime = rs("DATA_INOLTRO")
        Dim DATA_ACCETTAZIONE As DateTime = rs("DATA_ACCETTAZIONE")
        Dim DATA_ATTIVAZIONE As DateTime = rs("DATA_ATTIVAZIONE")
        Dim DATA_ANNULLAMENTO As DateTime = rs("DATA_ANNULLAMENTO")
        Dim DATA_REVOCA As DateTime = rs("DATA_REVOCA")

        Dim NOTE As String = IIf(rs("NOTE_DEL") IsNot Nothing, rs("NOTE_DEL"), "")


        Dim ID_AZIENDA As Int32 = IIf(rs("ID_AZIENDA") IsNot Nothing, rs("ID_AZIENDA"), -1)
        Dim AZIENDA As String = IIf(rs("NOME_AZIENDA") IsNot Nothing, rs("NOME_AZIENDA"), "")


        Dim ID_UTENTE As Int32 = IIf(rs("ID_UTENTE") IsNot Nothing, rs("ID_UTENTE"), -1)
        Dim UTENTE As String = IIf(rs("NOME_UTENTE") IsNot Nothing, rs("NOME_UTENTE"), "")

        Dim Indirizzo As String = IIf(rs("INDIRIZZO") IsNot Nothing, rs("INDIRIZZO"), "")
        Dim Cap As String = IIf(rs("CAP") IsNot Nothing, rs("CAP"), "")
        Dim Nome As String = IIf(rs("NOME") IsNot Nothing, rs("NOME"), "")
        Dim Cognome As String = IIf(rs("COGNOME") IsNot Nothing, rs("COGNOME"), "")

        Dim DataNascita As DateTime = IIf(rs("DATA_NASCITA") IsNot Nothing, rs("DATA_NASCITA"), DateTime.Now)
        Dim CodiceFiscale As String = IIf(rs("CODICE_FISCALE") IsNot Nothing, rs("CODICE_FISCALE"), "")
        Dim Comune As String = IIf(rs("NOME_COMUNE") IsNot Nothing, rs("NOME_COMUNE"), "")
        Dim Provincia As String = IIf(rs("NOME_PROVINCIA") IsNot Nothing, rs("NOME_PROVINCIA"), "")

        Dim ComuneNascita As String = IIf(rs("NOME_COMUNE_NASCITA") IsNot Nothing, rs("NOME_COMUNE_NASCITA"), "")
        Dim ProvinciaNascita As String = IIf(rs("NOME_PROVINCIA_NASCITA") IsNot Nothing, rs("NOME_PROVINCIA_NASCITA"), "")

        Dim Nazione As String = IIf(rs("NAZIONE") IsNot Nothing, rs("NAZIONE"), "")

        Dim CELL1 As String = IIf(rs("CELL1") IsNot Nothing, rs("CELL1"), "")
        Dim CELL2 As String = IIf(rs("CELL2") IsNot Nothing, rs("CELL2"), "")

        Dim ID_REFERENTE As String = IIf(rs("ID_REFERENTE") IsNot Nothing, rs("ID_REFERENTE"), "")
        Dim REFERENTE As String = IIf(rs("NOME_COLLABORATORE") IsNot Nothing, rs("NOME_COLLABORATORE"), "")

        Dim ID_RESPONSABILE As String = IIf(rs("ID_RESPONSABILE") IsNot Nothing, rs("ID_RESPONSABILE"), "")
        Dim RESPONSABILE As String = IIf(rs("NOME_RESPONSABILE") IsNot Nothing, rs("NOME_RESPONSABILE"), "")



        Dim ID_SETTORE As Int32 = IIf(rs("ID_SETTORE") IsNot Nothing, rs("ID_SETTORE"), -1)
        Dim SETTORE As String = IIf(rs("NOME_SETTORE") IsNot Nothing, rs("NOME_SETTORE"), "")



        Dim ID_CAUSALE As Int32 = IIf(rs("ID_CAUSALE") IsNot Nothing, rs("ID_CAUSALE"), -1)
        Dim NOME_CAUSALE As String = IIf(rs("NOME_CAUSALE") IsNot Nothing, rs("NOME_CAUSALE"), "")

        Dim ID_CAUSALE_SOTTOSCRIZIONE As Int32 = IIf(rs("ID_CAUSALE_SOTT") IsNot Nothing, rs("ID_CAUSALE_SOTT"), -1)
        Dim NOME_CAUSALE_SOTTOSCRIZIONE As String = IIf(rs("NOME_CAUSALE_SOTTOSCRIZIONE") IsNot Nothing, rs("NOME_CAUSALE_SOTTOSCRIZIONE"), "")


        Dim ID_REPARTO As Int32 = IIf(rs("ID_REPARTO") IsNot Nothing, rs("ID_REPARTO"), -1)
        Dim NOME_REPARTO As String = IIf(rs("NOME_REPARTO") IsNot Nothing, rs("NOME_REPARTO"), "")



        Dim NOME_SEDE_OPERATIVA As String = IIf(rs("NOME_SEDE_OPERATIVA") IsNot Nothing, rs("NOME_SEDE_OPERATIVA"), "")
        Dim STATO_DELEGA As String = IIf(rs("STATO_DELEGA") IsNot Nothing, rs("STATO_DELEGA"), "")

        Dim IdContratto As String = IIf(rs("ID_TIPO_CONTRATTO") IsNot Nothing, rs("ID_TIPO_CONTRATTO"), "")
        Dim Contratto As String = IIf(rs("NOME_CONTRATTO") IsNot Nothing, rs("NOME_CONTRATTO"), "")

        Dim comAz As String = IIf(rs("COMUNE_AZIENDA") IsNot Nothing, rs("COMUNE_AZIENDA"), "")
        Dim proAz As String = IIf(rs("PROVINCIA_AZIENDA") IsNot Nothing, rs("PROVINCIA_AZIENDA"), "")
        Dim indAz As String = IIf(rs("INDIRIZZO_AZIENDA") IsNot Nothing, rs("INDIRIZZO_AZIENDA"), "")
        Dim capAz As String = IIf(rs("CAP_AZIENDA") IsNot Nothing, rs("CAP_AZIENDA"), "")
        Dim maiAz As String = IIf(rs("MAIL_AZIENDA") IsNot Nothing, rs("MAIL_AZIENDA"), "")
        



        Dim q As New DelegadTO
        q.Key = Key

        If Not SETTORE.Equals("EDILE") Then
            q.ComuneAzienda = comAz
            q.ProvinciaAzienda = proAz
            q.IndirizzoAzienda = indAz
            q.CapAzienda = capAz
            q.MailAzienda = maiAz
        End If

        

        q.IdSettore = ID_SETTORE
        q.Settore = SETTORE
        q.IdEnteInoltro = ID_AZIENDA
        q.Nome_Comune_Nascita = ComuneNascita
        q.Nome_Provincia_Nascita = ProvinciaNascita

        Select Case ID_SETTORE
            Case 1 'settore IF

                q.EnteInoltro = AZIENDA
                q.IdContratto = IdContratto
                q.Contratto = Contratto
            Case 2 'Settore E
                If ID_AZIENDA = 1 Then
                    q.EnteInoltro = "CASSA EDILE"
                Else
                    q.EnteInoltro = "EDILCASSA"
                End If
            Case -1 'Settore nullo
                q.EnteInoltro = AZIENDA
        End Select




        q.DataDocumento = DATA_DOCUMENTO
        q.DataRegistrazione = DATA_REGISTRAZIONE
        q.DataInoltro = DATA_INOLTRO
        q.DataAccettazioneDelega = DATA_ACCETTAZIONE
        q.DataDecorrenzaDelega = DATA_ATTIVAZIONE
        q.DataAnnullamentoDelega = DATA_ANNULLAMENTO
        q.DataRevocaDelega = DATA_REVOCA


        q.IdReferente = ID_REFERENTE
        q.Referente = REFERENTE

        q.IdResponsabile = ID_RESPONSABILE
        q.Responsabile = RESPONSABILE


        q.Utente = UTENTE
        q.IdUtente = ID_UTENTE
        q.Cellulare1 = CELL1
        q.Cellulare2 = CELL2



        q.StatoDelega = STATO_DELEGA
        q.Note = NOTE
        q.SedeOperativa = NOME_SEDE_OPERATIVA

        q.Reparto = NOME_REPARTO
        q.CausaleFineCiclo = NOME_CAUSALE
        q.CausaleSottoscrizione = NOME_CAUSALE_SOTTOSCRIZIONE

        q.Cap = Cap
        q.Nome = Nome
        q.Indirizzo = Indirizzo
        q.Cognome = Cognome
        q.DataNascita = DataNascita

        q.Codice_Fiscale = CodiceFiscale
        q.Nome_Comune = Comune
        q.Nome_Provincia = Provincia
        q.Nome_Nazione = Nazione

        Return q


    End Function

#End Region


#Region "Metodi per la preparazione dei comandi"




    'Protected Overrides Function GetCommand(ByVal CommandText As String) As System.Data.IDbCommand

    '    'Return New SqlClient1.SqlCommand(CommandText, DBConnectionManager.Instance.GetCurrentConnection)
    '    Return DBTypeUtils.GetCommand(Me.m_PersistentService.ServiceName, CommandText, DBConnectionManager.Instance.GetCurrentConnection)
    'End Function
#End Region



#Region "Metodi per la ricerca"
    Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject
        Throw New Exception("Impossibile utilizzare il metodo di ricerca secondo l'identificati specificato per una posizione di pagamento. Metodo non implementato.")
    End Function
    Protected Overrides Function CreateKey(ByVal rs As System.Collections.Hashtable) As Key
        Return New Key(CInt(rs("ID")))

    End Function
#End Region






#Region "Metodi per il caricamento dei parametri per i comandi"


    Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)

    End Sub
    Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)

    End Sub

#End Region

#Region "Metodi per l'inserimento"
    Public Overrides Function Insert(ByVal item As AbstractPersistenceObject) As Key

        Return Nothing

    End Function

    Protected Overloads Function FindNextKey(ByVal IdDocumento As Int32) As Key
        Return Nothing
    End Function



#End Region


End Class
