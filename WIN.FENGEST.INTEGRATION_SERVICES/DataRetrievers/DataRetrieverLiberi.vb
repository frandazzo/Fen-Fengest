Public Class DataRetrieverLiberi
    Inherits DataInfoRetriever



    Private Const COGNOME_UTENTE As String = "COGNOME_UTENTE"
    Private Const NOME_UTENTE As String = "NOME_UTENTE"
    Private Const FISCALE As String = "FISCALE"
    Private Const COMUNE_NASCITA As String = "COMUNE_NASCITA"
    Private Const PROVINCIA_NASCITA As String = "PROVINCIA_NASCITA"
    Private Const DATA_NASCITA_UTENTE As String = "DATA_NASCITA_UTENTE"
    Private Const COMUNE As String = "COMUNE"
    Private Const PROVINCIA As String = "PROVINCIA"
    Private Const INDIRIZZO As String = "INDIRIZZO"
    Private Const ENTE As String = "ENTE"
    Private Const AZIENDA_IMPIEGO As String = "AZIENDA_IMPIEGO"
    Private Const DATA As String = "DATA"
    Private Const PARTITA_IVA As String = "PARTITA_IVA"
    Private Const CONTRATTO As String = "CONTRATTO"
    Private Const TELEFONO1 As String = "TELEFONO1"
    Private Const TELEFONO2 As String = "TELEFONO2"
    Private Const LIVELLO As String = "LIVELLO"
    Private Const CAP As String = "CAP"
    Private Const CAP_AZIENDA As String = "CAP_AZIENDA"
    Private Const TELEFONO_AZIENDA As String = "TELEFONO_AZIENDA"

    Private Const CODICE_CE_UTENTE As String = "CODICE_CE_UTENTE"
    Private Const CODICE_EC_UTENTE As String = "CODICE_EC_UTENTE"
    Private Const NOTE_UTENTE As String = "NOTE_UTENTE"



    Private Const PROVINCIA_AZIENDA As String = "PROVINCIA_AZIENDA"
    Private Const COMUNE_AZIENDA As String = "COMUNE_AZIENDA"
    Private Const NOTE_AZIENDA As String = "NOTE_AZIENDA"
    Private Const CODICE_CE_AZIENDA As String = "CODICE_CE_AZIENDA"
    Private Const CODICE_EC_AZIENDA As String = "CODICE_EC_AZIENDA"
    Private Const ISCRITTO_A As String = "ISCRITTO_A"
    Private Const INDIRIZZO_AZIENDA As String = "INDIRIZZO_AZIENDA"


    Public Overrides Sub ParseImportFile()
        If Not FindField(COGNOME_UTENTE) Then Throw New Exception("Formato file non valido: " & COGNOME_UTENTE)
        If Not FindField(NOME_UTENTE) Then Throw New Exception("Formato file non valido: " & NOME_UTENTE)
        If Not FindField(FISCALE) Then Throw New Exception("Formato file non valido: " & FISCALE)
        If Not FindField(DATA_NASCITA_UTENTE) Then Throw New Exception("Formato file non valido: " & DATA_NASCITA_UTENTE)
        If Not FindField(PROVINCIA_NASCITA) Then Throw New Exception("Formato file non valido: " & PROVINCIA_NASCITA)
        If Not FindField(COMUNE_NASCITA) Then Throw New Exception("Formato file non valido: " & COMUNE_NASCITA)
        If Not FindField(PROVINCIA) Then Throw New Exception("Formato file non valido: " & PROVINCIA)
        If Not FindField(COMUNE) Then Throw New Exception("Formato file non valido: " & COMUNE)
        If Not FindField(INDIRIZZO) Then Throw New Exception("Formato file non valido: " & INDIRIZZO)
        If Not FindField(CAP) Then Throw New Exception("Formato file non valido: " & CAP)
        If Not FindField(TELEFONO1) Then Throw New Exception("Formato file non valido: " & TELEFONO1)
        If Not FindField(TELEFONO2) Then Throw New Exception("Formato file non valido: " & TELEFONO2)
        If Not FindField(CODICE_CE_UTENTE) Then Throw New Exception("Formato file non valido: " & CODICE_CE_UTENTE)
        If Not FindField(CODICE_EC_UTENTE) Then Throw New Exception("Formato file non valido: " & CODICE_EC_UTENTE)
        If Not FindField(NOTE_UTENTE) Then Throw New Exception("Formato file non valido: " & NOTE_UTENTE)


        If Not FindField(ENTE) Then Throw New Exception("Formato file non valido: " & ENTE)
        If Not FindField(ISCRITTO_A) Then Throw New Exception("Formato file non valido: " & ISCRITTO_A)
        If Not FindField(LIVELLO) Then Throw New Exception("Formato file non valido: " & LIVELLO)
        If Not FindField(DATA) Then Throw New Exception("Formato file non valido: " & DATA)




        '**********************
        'Campi Azienda
        If Not FindField(AZIENDA_IMPIEGO) Then Throw New Exception("Formato file non valido: " & AZIENDA_IMPIEGO)
        If Not FindField(PARTITA_IVA) Then Throw New Exception("Formato file non valido: " & PARTITA_IVA)
        If Not FindField(PROVINCIA_AZIENDA) Then Throw New Exception("Formato file non valido: " & PROVINCIA_AZIENDA)
        If Not FindField(INDIRIZZO_AZIENDA) Then Throw New Exception("Formato file non valido: " & INDIRIZZO_AZIENDA)
        If Not FindField(COMUNE_AZIENDA) Then Throw New Exception("Formato file non valido: " & COMUNE_AZIENDA)
        If Not FindField(CAP_AZIENDA) Then Throw New Exception("Formato file non valido: " & CAP_AZIENDA)
        If Not FindField(TELEFONO_AZIENDA) Then Throw New Exception("Formato file non valido: " & TELEFONO_AZIENDA)
        If Not FindField(NOTE_AZIENDA) Then Throw New Exception("Formato file non valido: " & NOTE_AZIENDA)
        If Not FindField(CODICE_CE_AZIENDA) Then Throw New Exception("Formato file non valido: " & CODICE_CE_AZIENDA)
        If Not FindField(CODICE_EC_AZIENDA) Then Throw New Exception("Formato file non valido: " & CODICE_EC_AZIENDA)
        If Not FindField(CONTRATTO) Then Throw New Exception("Formato file non valido: " & CONTRATTO)


    End Sub




    Public Sub New(ByVal Filename As String)
        m_Filename = Filename
    End Sub


End Class
