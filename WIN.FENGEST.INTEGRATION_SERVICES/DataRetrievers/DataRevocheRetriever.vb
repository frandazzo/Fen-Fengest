Public Class DataRevocheRetriever
    Inherits DataInfoRetriever



    Private Const COGNOME_UTENTE As String = "COGNOME_UTENTE"
    Private Const NOME_UTENTE As String = "NOME_UTENTE"
    Private Const DATA_NASCITA_UTENTE As String = "DATA_NASCITA_UTENTE"
    Private Const FISCALE As String = "FISCALE"
    Private Const PROVINCIA_NASCITA As String = "PROVINCIA_NASCITA"
    Private Const COMUNE_NASCITA As String = "COMUNE_NASCITA"
    Private Const PROVINCIA As String = "PROVINCIA"

    Private Const COMUNE As String = "COMUNE"
    Private Const INDIRIZZO As String = "INDIRIZZO"
    Private Const CAP As String = "CAP"
    Private Const TELEFONO1 As String = "TELEFONO1"
    Private Const TELEFONO2 As String = "TELEFONO2"
    Private Const CODICE_CE_UTENTE As String = "CODICE_CE_UTENTE"
    Private Const CODICE_EC_UTENTE As String = "CODICE_EC_UTENTE"
    Private Const NOTE_UTENTE As String = "NOTE_UTENTE"

    Private Const ENTE As String = "ENTE"
    Private Const DATA_REVOCA As String = "DATA_REVOCA"
    Private Const REVOCATA_DA As String = "REVOCATA_DA"




 


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

       
        '*************************+
        'Campi Ente Settore
        If Not FindField(ENTE) Then Throw New Exception("Formato file non valido: " & ENTE)
        If Not FindField(DATA_REVOCA) Then Throw New Exception("Formato file non valido: " & DATA_REVOCA)
        If Not FindField(REVOCATA_DA) Then Throw New Exception("Formato file non valido: " & REVOCATA_DA)




       

      
    End Sub




    Public Sub New(ByVal Filename As String)
        m_Filename = Filename
    End Sub

End Class
