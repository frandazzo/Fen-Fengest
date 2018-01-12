Public Class ControllerComunicazioni
   Inherits AbstractController


   Private controllerCausali As New ControllerCausaleComunicazione
   Private controllerTipo As New ControllerTipoComunicazione
   Private controllerUtente As New UTENTI.ControllerUtenti
   'Private controllerTaggers As New OptionController
   'Private segreteria As Segreteria

   '''' <summary>
   '''' Crea una hash table avente come chiave
   '''' tutti i tag definiti nelle opzioni e come valori le relative
   '''' proprietà dell'utente
   '''' </summary>
   '''' <param name="IdUtente"></param>
   '''' <param name="Tags"></param>
   '''' <returns></returns>
   '''' <remarks></remarks>
   'Public Function CreateTagValuesMap(ByVal IdUtente As String, ByVal Tags As Hashtable) As Hashtable
   '   LoadUtente(IdUtente)
   '   Dim result As Hashtable = CreateUserTagMap()
   '   CompileFederationTags(result)
   '   AddSpecialTag(result, Tags)
   '   Return result
   'End Function




   'Private Sub CompileFederationTags(ByVal result As Hashtable)
   '   LoadSegreteria()

   '   Dim taggers As IList = GetListaTaggersSegreteria()
   '   For Each tagger As WordTagger In taggers
   '      If Not result.Contains(tagger.ValoreTag) Then
   '         result.Add(tagger.ValoreTag, GetPropertyValue(segreteria, tagger.NomeProprieta))
   '      End If
   '   Next

   'End Sub

   'Private Function GetListaTaggersSegreteria() As IList
   '   Return controllerTaggers.SearchTaggerSegreteria
   'End Function

   'Private Sub LoadSegreteria()
   '   Dim utente As Utente = DirectCast(controllerUtente.GetCurrent(), Utente)
   '   If utente Is Nothing Then
   '      segreteria = New Segreteria
   '      Return
   '   End If

   '   segreteria = utente.Segreteria
   'End Sub







   'Public Sub AddSpecialTag(ByVal ToMap As Hashtable, ByVal SpecialTags As Hashtable)
   '   Dim enumerator As IDictionaryEnumerator = SpecialTags.GetEnumerator
   '   Do While enumerator.MoveNext
   '      If Not ToMap.Contains(enumerator.Key) Then
   '         ToMap.Add(enumerator.Key, enumerator.Value)
   '      End If
   '   Loop

   '   Dim l As IList = controllerTaggers.SearchTaggerData()
   '   If l.Count = 1 Then
   '      Dim data As WordTagger = l.Item(0)
   '      ToMap.Add(data.ValoreTag, Format(DateTime.Now, "dd/MM/yyyy"))
   '   End If

   '   Dim l1 As IList = controllerTaggers.SearchTaggerOperatoreCorrente
   '   If l1.Count = 1 Then
   '      Dim data As WordTagger = l1.Item(0)
   '      Dim nome As String = ""
   '      Try
   '         Dim us As WIN.BASEREUSE.User = DirectCast(SecurityManager.Instance.CurrentUser, WIN.BASEREUSE.User)
   '         nome = us.SurName & " " & us.Name
   '      Catch ex As Exception
   '         nome = ""
   '      End Try
   '      ToMap.Add(data.ValoreTag, nome)
   '   End If
   'End Sub

   'Private Function CreateUserTagMap() As Hashtable
   '   Dim taggers As IList = GetListaTaggersUtenti()
   '   Dim result As New Hashtable

   '   For Each tagger As WordTagger In taggers
   '      If Not result.Contains(tagger.ValoreTag) Then
   '         result.Add(tagger.ValoreTag, GetPropertyValue(controllerUtente, tagger.NomeProprieta))
   '      End If
   '   Next
   '   Return result
   'End Function

   'Public Function GetPropertyValue(ByVal Controller As Object, ByVal PropertyName As String) As String
   '   Try
   '      Dim myType As Type = Controller.GetType
   '      Dim myInstance As Object = Controller
   '      Dim myProperty As Reflection.PropertyInfo = myType.GetProperty(PropertyName)
   '      Return myProperty.GetValue(myInstance, Nothing)
   '   Catch ex As Exception
   '      Return ""
   '   End Try
   'End Function

   'Private Function GetListaTaggersUtenti() As IList
   '   Return controllerTaggers.SearchTaggerUtenti
   'End Function

   Private Sub LoadUtente(ByVal IdUtente As String)
      Try
         controllerUtente.LoadById(IdUtente)
      Catch ex As NullReferenceException
         Throw New Exception("Non esiste nessun utente con l'id selezionato")
      End Try
   End Sub







   Public Function Current() As Comunicazione
      Return DirectCast(m_current, Comunicazione)
   End Function

#Region "Proprietà oggetto"

   Public Property Note() As String
      Get
         Return Current.Note
      End Get
      Set(ByVal value As String)
         Current.Note = value
      End Set
   End Property


   Public Property Allegato() As String
      Get
         Return Current.Allegato
      End Get
      Set(ByVal value As String)
         If value = "" Then
            Current.Allegato = value
            Return
         End If
         If My.Computer.FileSystem.FileExists(value) Then
            Current.Allegato = value
         Else
            Throw New Exception("Allegato non trovato")
         End If
      End Set
   End Property


   Public Property Data() As DateTime
      Get
         Return Current.DataDocumento
      End Get
      Set(ByVal value As DateTime)
         Current.DataDocumento = value
      End Set
   End Property


   Public ReadOnly Property IdComunicazione() As String
      Get
         Return Current.Id
      End Get
   End Property



   Public ReadOnly Property DescrizioneCausale() As String
      Get
         Return Current.Causale.Descrizione
      End Get
   End Property
   Public Sub SetCausale(ByVal DescrizioneCausale As String)
      Current.Causale = controllerCausali.GetCausaleComunicazione(DescrizioneCausale)
   End Sub


   Public ReadOnly Property DescrizioneTipo() As String
      Get
         Return Current.Tipo.Descrizione
      End Get
   End Property
   Public Sub SetTipo(ByVal DescrizioneTipo As String)
      Current.Tipo = controllerTipo.GetCausaleComunicazione(DescrizioneTipo)
   End Sub





   Public ReadOnly Property IdUtente() As String
      Get
         Return Current.Utente.Id
      End Get
   End Property
   Public ReadOnly Property NomeUtente() As String
      Get
         Return Current.Utente.CompleteName
      End Get
   End Property
   Public Sub SetUtente(ByVal IdUtente As String)
      If Not IsNumeric(IdUtente) Then Throw New Exception("Id utente errato")
      Dim id As Int32 = CType(IdUtente, Int32)
      Current.Utente = controllerUtente.GetUtenteById(id)
   End Sub






#End Region





   Public Sub OpenFile(ByVal FileName As String)
      Try
         'If FileName = "" Then Throw New ArgumentException("Nome file vuoto")
         'If Not System.IO.File.Exists(FileName) Then Throw New ArgumentException("File inesistente")
         'Dim pInfo As New ProcessStartInfo()
         'pInfo.FileName = FileName
         'pInfo.UseShellExecute = True
         'Dim p As Process = Process.Start(pInfo)
         SimpleFileSystemManager.ViewFile(FileName)
      Catch ex As Exception
         Throw New ArgumentException("Impossibile aprire il file specificato" & vbCrLf & ex.Message, "Filename")
      End Try
   End Sub

   Public Sub RemoveReferenceToOutputFile()

      Current.Allegato = ""

   End Sub



    Public Function GenerateDocumentAndPrintOnBackground(ByVal modello As String, ByVal TagTable As Hashtable, ByVal save As Boolean) As String
        If m_current Is Nothing Then
            Throw New InvalidOperationException("Non è possibile generare un documento senza selezionare una comunicazione")
        End If
        'Dim documento As String = ""
        'Genero il documento
        Try
            'Dim wordHandler As New OfficeWordHandler
            'documento = GenerateAndSaveDocument(wordHandler, modello, TagTable)
            'wordHandler.Print()
            'wordHandler.DocumentClose(False)
            'wordHandler.QuitApplication()

            'Dim tagValues As Hashtable = c.CreateTagValuesMap(Current.Utente.Id, TagTable)

            Dim dest As String = Current.Utente.DirectoryPreferenziale

            Dim suggestedName As String = SimpleFileSystemManager.GetFileNameWithoutExtension(modello)


            Return OfficeWordDocumentGenerator.GenerateDocumentAndPrintOnBackGroundLowLevel(modello, TagTable, save, dest, suggestedName)


        Catch ex As Exception
            Throw New Exception("Impossibile generare il documento word", ex)
        End Try



        'Return documento
    End Function

   ' Private Function GenerateAndSaveDocument(ByVal modello As String, ByVal TagTable As Hashtable, ByVal destinazione As String, ByVal nomeFileSenzaEstensione As String) As String
   '   Dim documento As String = ""
   '   Dim wordHandler As New OfficeWordHandler


   '   wordHandler.OpenWordApplication(True)
   '   wordHandler.AddDocumentToWord(modello)

   '   'Dim tagValues As Hashtable = CreateTagValuesMap(Current.Utente.Id, TagTable)
   '   Dim enumerator As IDictionaryEnumerator = TagTable.GetEnumerator
   '   Do While enumerator.MoveNext
   '      wordHandler.FindReplace(enumerator.Key, enumerator.Value)
   '   Loop


   '   'lo salvo
   'Current.CostruisciNomeAllegato(modello)
   '   wordHandler.SaveAs(documento)

   '   wordHandler.DocumentClose(False)
   '   wordHandler.QuitApplication()

   '   Return documento
   ' End Function



   Public Function GenerateDocument(ByVal modello As String, ByVal TagTable As Hashtable) As String
      If m_current Is Nothing Then
         Throw New InvalidOperationException("Non è possibile generare un documento senza selezionare una comunicazione")
      End If
      If Current.Utente Is Nothing Then
         Throw New InvalidOperationException("Non è possibile generare un documento senza selezionare un utente.")
      End If


      Dim c As New ControllerCompilazioneModelli
     
      Dim dest As String = Current.Utente.DirectoryPreferenziale


      Dim suggestedName As String = SimpleFileSystemManager.GetFileNameWithoutExtension(modello)


      Return c.GenerateDocument(Current.Utente.Id, modello, TagTable, dest, suggestedName)




   End Function





   Public Overrides Function GetCategoryObject() As String
      Return "Comunicazione"
   End Function


   Friend Function GetComunicazioneById(ByVal Id As String) As Comunicazione
      If Id = -1 Then Return Nothing
      Me.LoadById(Id)
      Return Current()
   End Function


   Public Sub LoadAllByUtente(ByVal IdUtente As String)
      If Not IsNumeric(IdUtente) Then Throw New Exception("Id utente errato.")
      Dim query As Query = Ps.CreateNewQuery("MapperComunicazione")
      Dim mainCriteria As Criteria = Criteria.Equal("ID_UTENTE", IdUtente)
      query.AddWhereClause(mainCriteria)
      DomainObjectList = query.Execute(Ps)
   End Sub
   Public Function GetComunicazioniByUtente(ByVal IdUtente As String) As IList
      LoadAllByUtente(IdUtente)
      Return DomainObjectList
   End Function
   Public Overrides Sub CreateNew()
      m_current = New Comunicazione
   End Sub




End Class
