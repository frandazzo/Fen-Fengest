Public Class DataRetrieverIQA
    Inherits DataInfoRetriever
    'Implements IDisposable
    'Public Event BeginParse()
    'Public Event EndParse(ByVal NumberOfRecords As Int32, ByVal NumberOfFields As Int32)
    'Public Event BeginRetrieving()
    'Public Event RetrievingRecord(ByVal IdRecord As Int32)
    'Public Event EndRetrieving(ByVal NumberOfRecords As Int32)
    'Private m_numberOfRecords As Int32
    'Private m_numberOfFields As Int32

    'Private m_Filename As String = ""
    'Private m_Excel As Object 'Microsoft.Office.Interop.Excel.Application
    'Private m_workSheet As Object 'Microsoft.Office.Interop.Excel.Worksheet
    'Private m_workBook As Object 'Microsoft.Office.Interop.Excel.Workbook
    ''Private WithEvents m_DataParser As DataParser
    'Private m_SheetStructure As New Hashtable
    ''Private m_RetrivedData As ArrayList = New ArrayList


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
    Private Const SETTORE As String = "SETTORE"
    Private Const NOTE As String = "NOTE"
    Private Const CAP As String = "CAP"
    Private Const CAP_AZIENDA As String = "CAP_AZIENDA"
    Private Const TELEFONO_AZIENDA As String = "TELEFONO_AZIENDA"

    'Private Const REPARTO As String = "REPARTO"
    'Private Const SEDE_OPERATIVA As String = "SEDE_OPERATIVA"
    Private Const DATA As String = "DATA"
    Private Const NOME_REFERENTE As String = "NOME_REFERENTE"
    Private Const COGNOME_REFERENTE As String = "COGNOME_REFERENTE"
    'Private Const NOME_RESPONSABILE As String = "NOME_RESPONSABILE"
    'Private Const COGNOME_RESPONSABILE As String = "COGNOME_RESPONSABILE"
    Private Const PARTITA_IVA As String = "PARTITA_IVA"
    Private Const CONTRATTO As String = "CONTRATTO"
    'Private Const REVOCATA_A As String = "REVOCATA_A"
    'Private Const DATA_ACCETTAZIONE As String = "DATA_ACCETTAZIONE"
    'Private Const DATA_REVOCA As String = "DATA_REVOCA"
    'Private Const DATA_ANNULLAMENTO As String = "DATA_ANNULLAMENTO"
    Private Const TELEFONO1 As String = "TELEFONO1"
    Private Const TELEFONO2 As String = "TELEFONO2"


    Private Const ORE_AVORATE As String = "ORE_LAVORATE"
    Private Const ORE_MALATTIA_INFORTUNIO As String = "ORE_MALATTIA_INFORTUNIO"
    Private Const DATA_INIZIO As String = "DATA_INIZIO"
    Private Const DATA_FINE As String = "DATA_FINE"
    Private Const LIVELLO As String = "LIVELLO"
    Private Const AZIENDA_IMPIEGO As String = "AZIENDA_IMPIEGO"
    Private Const QUOTA As String = "QUOTA"


    Private Const CODICE_CE_UTENTE As String = "CODICE_CE_UTENTE"
    Private Const CODICE_EC_UTENTE As String = "CODICE_EC_UTENTE"
    Private Const NOTE_UTENTE As String = "NOTE_UTENTE"



    Private Const PROVINCIA_AZIENDA As String = "PROVINCIA_AZIENDA"
    Private Const COMUNE_AZIENDA As String = "COMUNE_AZIENDA"
    Private Const NOTE_AZIENDA As String = "NOTE_AZIENDA"
    Private Const CODICE_CE_AZIENDA As String = "CODICE_CE_AZIENDA"
    Private Const CODICE_EC_AZIENDA As String = "CODICE_EC_AZIENDA"

    Private Const INDIRIZZO_AZIENDA As String = "INDIRIZZO_AZIENDA"



    Public Overrides Sub ParseImportFile()
        ' RaiseEvent BeginParse()


        '*********************+
        'Campi Utente
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


        '*************************+
        'Campi Ente Settore
        If Not FindField(ENTE) Then Throw New Exception("Formato file non valido: " & ENTE)
        If Not FindField(SETTORE) Then Throw New Exception("Formato file non valido: " & SETTORE)




        '*********************************
        'Campi Quota
        If Not FindField(NOTE) Then Throw New Exception("Formato file non valido: " & NOTE)
        If Not FindField(ORE_AVORATE) Then Throw New Exception("Formato file non valido: " & ORE_AVORATE)
        If Not FindField(ORE_MALATTIA_INFORTUNIO) Then Throw New Exception("Formato file non valido: " & ORE_MALATTIA_INFORTUNIO)
        If Not FindField(DATA_INIZIO) Then Throw New Exception("Formato file non valido: " & DATA_INIZIO)
        If Not FindField(DATA_FINE) Then Throw New Exception("Formato file non valido: " & DATA_FINE)
        If Not FindField(LIVELLO) Then Throw New Exception("Formato file non valido: " & LIVELLO)
        If Not FindField(QUOTA) Then Throw New Exception("Formato file non valido: " & QUOTA)
        'If Not FindField(DATA_ANNULLAMENTO) Then Throw New Exception("Formato file non valido")
        'If Not FindField(DATA) Then Throw New Exception("Formato file non valido")

        '****************************
        'Referenti
        If Not FindField(NOME_REFERENTE) Then Throw New Exception("Formato file non valido: " & NOME_REFERENTE)
        If Not FindField(COGNOME_REFERENTE) Then Throw New Exception("Formato file non valido: " & COGNOME_REFERENTE)


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

        'RaiseEvent EndParse(FindNumberOfRecords, FindNumberOfFields)
    End Sub



    Public Sub New(ByVal Filename As String)
        m_Filename = Filename
    End Sub
 

End Class
