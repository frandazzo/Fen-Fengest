Public Class DataRetireverInps
    Inherits DataInfoRetriever



    Friend Const CognomeNome As String = "Cognome/Nome"
    Friend Const Fiscale As String = "Codice Fiscale"
    Friend Const DataNascita As String = "Data di Nascita"
    Friend Const Importo As String = "Importo Pagamento"
    Friend Const DataValuta As String = "Data Valuta"
    Friend Const Domanda As String = "N. Domanda"
    Friend Const Comune As String = "Comune Res."
    Friend Const Patronato As String = "Patronato"
 


    Public Overrides Sub ParseImportFile()
        ' RaiseEvent BeginParse()

        '**********************
        'Campi Azienda
        If Not FindField(CognomeNome) Then Throw New Exception("Formato file non valido: " & CognomeNome)
        If Not FindField(Fiscale) Then Throw New Exception("Formato file non valido: " & Fiscale)
        If Not FindField(DataNascita) Then Throw New Exception("Formato file non valido: " & DataNascita)
        If Not FindField(Importo) Then Throw New Exception("Formato file non valido: " & Importo)
        If Not FindField(DataValuta) Then Throw New Exception("Formato file non valido: " & DataValuta)
        If Not FindField(Domanda) Then Throw New Exception("Formato file non valido: " & Domanda)
        If Not FindField(Comune) Then Throw New Exception("Formato file non valido: " & Comune)
        If Not FindField(Patronato) Then Throw New Exception("Formato file non valido: " & Patronato)
      
    End Sub

    Friend Sub New()

    End Sub


    Friend Overrides Function GetTemplateHashTable() As System.Collections.Hashtable
        Dim temp As New Hashtable

        temp.Add(CognomeNome, "")
        temp.Add(Fiscale, "")
        temp.Add(DataNascita, "")
        temp.Add(Importo, "")
        temp.Add(DataValuta, "")
        temp.Add(Domanda, "")
        temp.Add(Comune, "")
        temp.Add(Patronato, "")

        Return temp
    End Function




    Public Sub New(ByVal Filename As String, Optional StartRow As Int32 = 11, Optional StartColumn As Int32 = 2)
        m_Filename = Filename
        m_startColumn = StartColumn
        m_startRow = StartRow
    End Sub


End Class
