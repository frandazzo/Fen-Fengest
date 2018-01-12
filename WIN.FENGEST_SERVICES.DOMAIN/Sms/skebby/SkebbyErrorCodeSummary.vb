Public Class SkebbyErrorCodeSummary

    Private m_errorHashTable As Hashtable = New Hashtable

    Public Sub New()
        m_errorHashTable.Add(10, "Errore generico")
        m_errorHashTable.Add(11, "Charset non valido")
        m_errorHashTable.Add(12, "Qualche parametro obbligatorio non è stato specificato")
        m_errorHashTable.Add(20, "Parametri non validi")
        m_errorHashTable.Add(21, "Username o password non validi")
        m_errorHashTable.Add(22, "Mittente non valido")
        m_errorHashTable.Add(23, "Mittente troppo lungo (oltre gli 11 caratteri)")
        m_errorHashTable.Add(24, "Testo troppo lungo")
        m_errorHashTable.Add(25, "Destinatario non valido")
        m_errorHashTable.Add(26, "Mittente non impostato")
        m_errorHashTable.Add(27, "Troppi destinatari")
        m_errorHashTable.Add(29, "Il tuo account non è configurato per usare il gateway SMS")

        m_errorHashTable.Add(30, "Credito insufficiente per inviare il messaggio")
        m_errorHashTable.Add(31, "Sono accettate solo richieste HTTP con metodo POST")
        m_errorHashTable.Add(32, "Il formato del delivery_start non è valido, usa il formato RFC 2822 es: Mon, 15 Aug 2005 15:52:01 +0000")
        m_errorHashTable.Add(33, "L' encoding_scheme non è valido, valori accettati: normal, ucs2 visita http://en.wikipedia.org/wiki/GSM_03.38 per maggiori informazioni")
        m_errorHashTable.Add(34, "Il validity_period non è valido, deve essere un valore intero (espresso in minuti) più grande di 0 e minore di 2880 (2 giorni)")
        m_errorHashTable.Add(35, "L' user_reference non è valido, deve avere una lunghezza massima di 20 caratteri [a-zA-Z0-9-_+:;]")
        m_errorHashTable.Add(36, "Se hai impostato il delivery_start e vuoi il rapporto di consegna devi specificare obbligatoriamente anche il campo user_reference")
        m_errorHashTable.Add(37, "Stai inviando al gateway dei caratteri nel charset sbagliato, controlla il parametro charset")
        m_errorHashTable.Add(38, "Sono presenti troppi alias con partita iva uguale")
        m_errorHashTable.Add(39, "Il parametro partita iva ricevuto non è corretto")


        m_errorHashTable.Add(40, "E' necessario avere un profilo business per utilizzare i mittenti alfanumerici")
        m_errorHashTable.Add(41, "Mittente alfanumerico già presente ed approvato")


    End Sub


    Public Function GetError(errorCode As Int32) As String

        Dim s As IDictionaryEnumerator = m_errorHashTable.GetEnumerator
        While s.MoveNext

            If s.Key = errorCode Then
                Return s.Value.ToString
            End If


        End While

        Return "Errore non definito"

    End Function


End Class
