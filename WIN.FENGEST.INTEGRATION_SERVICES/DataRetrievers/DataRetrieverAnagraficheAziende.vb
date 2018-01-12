Public Class DataRetrieverAnagraficheAziende
    Inherits DataInfoRetriever



    Private Const CAP_AZIENDA As String = "CAP_AZIENDA"
    Private Const TELEFONO_AZIENDA As String = "TELEFONO_AZIENDA"
    Private Const PARTITA_IVA As String = "PARTITA_IVA"
    Private Const CONTRATTO As String = "CONTRATTO"
    Private Const AZIENDA_IMPIEGO As String = "AZIENDA_IMPIEGO"
    Private Const PROVINCIA_AZIENDA As String = "PROVINCIA_AZIENDA"
    Private Const COMUNE_AZIENDA As String = "COMUNE_AZIENDA"
    Private Const NOTE_AZIENDA As String = "NOTE_AZIENDA"
    Private Const CODICE_CE_AZIENDA As String = "CODICE_CE_AZIENDA"
    Private Const CODICE_EC_AZIENDA As String = "CODICE_EC_AZIENDA"
    Private Const INDIRIZZO_AZIENDA As String = "INDIRIZZO_AZIENDA"



    Public Overrides Sub ParseImportFile()
        ' RaiseEvent BeginParse()


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
