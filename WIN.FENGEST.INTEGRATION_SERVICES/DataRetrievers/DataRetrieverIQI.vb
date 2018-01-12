Public Class DataRetrieverIQI
    Inherits DataInfoRetriever



    Friend Const COGNOME_UTENTE As String = "COGNOME_UTENTE"
    Friend Const NOME_UTENTE As String = "NOME_UTENTE"
    Friend Const FISCALE As String = "FISCALE"
    Friend Const DATA_NASCITA_UTENTE As String = "DATA_NASCITA_UTENTE"
    Friend Const COMUNE As String = "COMUNE"
    Friend Const PROVINCIA As String = "PROVINCIA"
    Friend Const INDIRIZZO As String = "INDIRIZZO"
    Friend Const CAP As String = "CAP"

    Friend Const SETTORE As String = "SETTORE"

    Friend Const DATA_INIZIO As String = "DATA_INIZIO"
    Friend Const QUOTA As String = "QUOTA"
    Friend Const TIPO_PRESTAZIONE As String = "TIPO_PRESTAZIONE"
    Friend Const NOME_REFERENTE As String = "NOME_REFERENTE"
    Friend Const COGNOME_REFERENTE As String = "COGNOME_REFERENTE"

    Friend Const DOMANDA As String = "DOMANDA"

    Friend Sub New()

    End Sub

    Friend Overrides Function GetTemplateHashTable() As System.Collections.Hashtable
        Dim temp As New Hashtable

        temp.Add(COGNOME_UTENTE, "")
        temp.Add(NOME_UTENTE, "")
        temp.Add(FISCALE, "")
        temp.Add(DATA_NASCITA_UTENTE, "")
        temp.Add(COMUNE, "")
        temp.Add(PROVINCIA, "")
        temp.Add(INDIRIZZO, "")
        temp.Add(CAP, "")


        temp.Add(SETTORE, "")
        temp.Add(DATA_INIZIO, "")
        temp.Add(QUOTA, "")
        temp.Add(TIPO_PRESTAZIONE, "")
        temp.Add(NOME_REFERENTE, "")
        temp.Add(COGNOME_REFERENTE, "")

        temp.Add(DOMANDA, "")

        Return temp
    End Function


    Public Overrides Sub ParseImportFile()
        ' RaiseEvent BeginParse()


        '*********************+
        'Campi Utente
        If Not FindField(COGNOME_UTENTE) Then Throw New Exception("Formato file non valido: " & COGNOME_UTENTE)
        If Not FindField(NOME_UTENTE) Then Throw New Exception("Formato file non valido: " & NOME_UTENTE)
        If Not FindField(FISCALE) Then Throw New Exception("Formato file non valido: " & FISCALE)
        If Not FindField(DATA_NASCITA_UTENTE) Then Throw New Exception("Formato file non valido: " & DATA_NASCITA_UTENTE)
        
        If Not FindField(PROVINCIA) Then Throw New Exception("Formato file non valido: " & PROVINCIA)
        If Not FindField(COMUNE) Then Throw New Exception("Formato file non valido: " & COMUNE)
        If Not FindField(INDIRIZZO) Then Throw New Exception("Formato file non valido: " & INDIRIZZO)
        If Not FindField(CAP) Then Throw New Exception("Formato file non valido: " & CAP)
        
        '*************************+
        'Campi Ente Settore

        If Not FindField(SETTORE) Then Throw New Exception("Formato file non valido: " & SETTORE)




        '*********************************
        'Campi Quota
        If Not FindField(DATA_INIZIO) Then Throw New Exception("Formato file non valido: " & DATA_INIZIO)
        If Not FindField(TIPO_PRESTAZIONE) Then Throw New Exception("Formato file non valido: " & TIPO_PRESTAZIONE)
        If Not FindField(QUOTA) Then Throw New Exception("Formato file non valido: " & QUOTA)
        '****************************
        'Referenti
        If Not FindField(NOME_REFERENTE) Then Throw New Exception("Formato file non valido: " & NOME_REFERENTE)
        If Not FindField(COGNOME_REFERENTE) Then Throw New Exception("Formato file non valido: " & COGNOME_REFERENTE)


       
    End Sub



    Public Sub New(ByVal Filename As String)
        m_Filename = Filename
    End Sub


End Class
