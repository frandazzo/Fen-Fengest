Public Class HashTableFromInpsTemplateConverter

    Public Shared Function ConvertToIQITemplateHashList(listOfInpsHashes As IList) As IList

        'in questa funzione converto una lista di hashtables dove ogni hashtable è un record
        'proveninete da un file excel sul modello dell'inps
        'in una lista di hashtable sul temoplate iqi fenealgest


        Dim list As New ArrayList

        For Each elem As Hashtable In listOfInpsHashes

            list.Add(ConvertHashRecord(elem))
        Next

        Return list


    End Function


    Private Shared Function ConvertHashRecord(inpsTemplate As Hashtable) As Hashtable

        Dim a As New DataRetrieverIQI


        Dim result As Hashtable = a.GetTemplateHashTable



        'adesso valorizzo tutte le proprietà della hash table risultato con 
        'le proprietà della hashtable di input

        'recupero il nome e il cognome
        Dim nome As String() = inpsTemplate.Item(DataRetireverInps.CognomeNome).ToString.Split("/")
        result.Item(DataRetrieverIQI.COGNOME_UTENTE) = nome(0)
        result.Item(DataRetrieverIQI.NOME_UTENTE) = nome(1)
        result.Item(DataRetrieverIQI.DATA_NASCITA_UTENTE) = inpsTemplate.Item(DataRetireverInps.DataNascita)
        result.Item(DataRetrieverIQI.FISCALE) = inpsTemplate.Item(DataRetireverInps.Fiscale)
        result.Item(DataRetrieverIQI.COMUNE) = inpsTemplate.Item(DataRetireverInps.Comune)
        result.Item(DataRetrieverIQI.QUOTA) = inpsTemplate.Item(DataRetireverInps.Importo)
        result.Item(DataRetrieverIQI.DATA_INIZIO) = inpsTemplate.Item(DataRetireverInps.DataValuta)
        result.Item(DataRetrieverIQI.DOMANDA) = inpsTemplate.Item(DataRetireverInps.Domanda)
        result.Item(DataRetrieverIQI.TIPO_PRESTAZIONE) = inpsTemplate.Item("TIPO_PRESTAZIONE")
        result.Item("FILE_NAME") = inpsTemplate.Item("FILE_NAME")

        Return result

    End Function


End Class
