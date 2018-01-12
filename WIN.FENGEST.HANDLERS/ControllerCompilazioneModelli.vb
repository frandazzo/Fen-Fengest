Public Class ControllerCompilazioneModelli
    Dim controller As New ControllerComunicazioni
    Private controllerTaggers As New OptionController
    Private controllerUtente As New UTENTI.ControllerUtenti
    Private controllerAzienda As New AZIENDE.ControllerAziende
    Dim segreteria As Segreteria

    Public Sub GenerateAndActivateTempDocument(ByVal IdUtente As String, ByVal modello As String, ByVal TagTable As Hashtable)
        'Genero il documento
        Try
            Dim tagValues As Hashtable = CreateTagValuesMap(IdUtente, TagTable)

            OfficeWordDocumentGenerator.GenerateAndActivateTempDocumentLowLevel(modello, tagValues)

        Catch ex As Exception
            Throw New Exception("Impossibile generare il documento word", ex)
        End Try

    End Sub

    Public Function GenerateDocument(ByVal IdUtente As String, ByVal modello As String, ByVal TagTable As Hashtable, ByVal Destinazione As String, ByVal nomeFileSenzaEstensione As String) As String

        Dim documento As String = ""
        'Genero il documento
        Try
            Dim tagValues As Hashtable = CreateTagValuesMap(IdUtente, TagTable) '(Current.Utente.Id, TagTable)
            'Dim wordHandler As New OfficeWordHandler
            documento = OfficeWordDocumentGenerator.GenerateAndSaveDocumentLowLevel(modello, tagValues, Destinazione, nomeFileSenzaEstensione)

        Catch ex As Exception
            Throw New Exception("Impossibile generare il documento word", ex)
        End Try

        Return documento
    End Function

    Public Overloads Function CreateTagValuesMap(ByVal IdUtente As String, ByVal Tags As Hashtable) As Hashtable
        LoadUtente(IdUtente)
        Dim result As Hashtable = CreateUserTagMap()
        CompileFederationTags(result)
        AddSpecialTag(result, Tags)
        Return result
    End Function

    Public Overloads Function CreateTagValuesMap(ByVal IdUtente As String, IdAzienda As String, ByVal Tags As Hashtable) As Hashtable
        LoadUtente(IdUtente)
        Try
            LoadAzienda(IdAzienda)
        Catch ex As Exception
            Debug.WriteLine(ex.Message)
        End Try

        Dim result As Hashtable = CreateUserTagMap()
        CreateAziendaTagMap(result)
        CompileFederationTags(result)
        AddSpecialTag(result, Tags)
        Return result
    End Function


    Private Sub CompileFederationTags(ByVal result As Hashtable)
        LoadSegreteria()

        Dim taggers As IList = GetListaTaggersSegreteria()
        For Each tagger As WordTagger In taggers
            If Not result.Contains(tagger.ValoreTag) Then
                result.Add(tagger.ValoreTag, GetPropertyValue(segreteria, tagger.NomeProprieta))
            End If
        Next

    End Sub

    Private Function GetListaTaggersSegreteria() As IList
        Return controllerTaggers.SearchTaggerSegreteria
    End Function

    Private Sub LoadSegreteria()
        Dim utente As Utente = DirectCast(controllerUtente.GetCurrent(), Utente)
        If utente Is Nothing Then
            segreteria = New Segreteria
            Return
        End If

        segreteria = utente.Segreteria
    End Sub

    Private Sub LoadAzienda(ByVal IdAzienda As String)

        controllerAzienda.LoadById(IdAzienda)
      
    End Sub
    Private Sub LoadUtente(ByVal IdUtente As String)
        Try
            controllerUtente.LoadById(IdUtente)
        Catch ex As NullReferenceException
            Throw New Exception("Non esiste nessun utente con l'id selezionato")
        End Try
    End Sub

    Private Sub AddSpecialTag(ByVal ToMap As Hashtable, ByVal SpecialTags As Hashtable)
        Dim enumerator As IDictionaryEnumerator = SpecialTags.GetEnumerator
        Do While enumerator.MoveNext
            If Not ToMap.Contains(enumerator.Key) Then
                ToMap.Add(enumerator.Key, enumerator.Value)
            End If
        Loop

        Dim l As IList = controllerTaggers.SearchTaggerData()
        If l.Count = 1 Then
            Dim data As WordTagger = l.Item(0)
            ToMap.Add(data.ValoreTag, Format(DateTime.Now, "dd/MM/yyyy"))
        End If

        Dim l1 As IList = controllerTaggers.SearchTaggerOperatoreCorrente
        If l1.Count = 1 Then
            Dim data As WordTagger = l1.Item(0)
            Dim nome As String = ""
            Try
                Dim us As WIN.BASEREUSE.User = DirectCast(SecurityManager.Instance.CurrentUser, WIN.BASEREUSE.User)
                nome = us.SurName & " " & us.Name
            Catch ex As Exception
                nome = ""
            End Try
            ToMap.Add(data.ValoreTag, nome)
        End If


    End Sub

    Private Function CreateUserTagMap() As Hashtable
        Dim taggers As IList = GetListaTaggersUtenti()
        Dim result As New Hashtable

        For Each tagger As WordTagger In taggers
            If Not result.Contains(tagger.ValoreTag) Then
                result.Add(tagger.ValoreTag, GetPropertyValue(controllerUtente, tagger.NomeProprieta))
            End If
        Next
        Return result
    End Function


    Private Function CreateAziendaTagMap(result As Hashtable) As Hashtable
        Dim taggers As IList = GetListaTaggersAziende()


        For Each tagger As WordTagger In taggers
            If Not result.Contains(tagger.ValoreTag) Then
                result.Add(tagger.ValoreTag, GetPropertyValue(controllerAzienda, tagger.NomeProprieta))
            End If
        Next
        Return result
    End Function


    Private Function GetListaTaggersUtenti() As IList
        Return controllerTaggers.SearchTaggerUtenti
    End Function
    Private Function GetListaTaggersAziende() As IList
        Return controllerTaggers.SearchTaggerAziende
    End Function

    Private Function GetPropertyValue(ByVal Controller As Object, ByVal PropertyName As String) As String
        Try
            Dim myType As Type = Controller.GetType
            Dim myInstance As Object = Controller
            Dim myProperty As Reflection.PropertyInfo = myType.GetProperty(PropertyName)
            Return myProperty.GetValue(myInstance, Nothing)
        Catch ex As Exception
            Return ""
        End Try
    End Function

End Class
