Public Class ControllerArchivioDocumentale
   ' Inherits AbstractController

   Private ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade

   Private m_CurrentElectronicDocument As ElectronicDocument

   Private m_CurrentElectronicDocumentAttitvita As ElectronicDocument
   Private m_Target As Object
   Private m_Archivio As ArchivioDocumenti
   Private m_ArchivioAttivita As ArchivioDocumenti = New ArchivioDocumenti
   Private m_currentListaDocs As ArrayList = New ArrayList
   Private m_currentListaDocsAtt As ArrayList = New ArrayList
    Private m_controllerReferetni As New WIN.APPLICATION.FINANCIAL_ARTIFACTS.ControllerReferenti


   'Private m_mapperUtente As IMapper
   Public ReadOnly Property Target() As Object
      Get
         Return m_Target
      End Get
   End Property

   Public Overridable Sub SortItems(ByVal PropertyName As String, Optional ByVal Descending As Boolean = False)

      If PropertyName = "" Then Throw New Exception("Selezionare una proprietà.")

      m_currentListaDocs.Sort(SortFactory.GetItemComparer(PropertyName, Descending, "ElectronicDocument"))
   End Sub
   Public Overridable Sub SortItemsAtt(ByVal PropertyName As String, Optional ByVal Descending As Boolean = False)

      If PropertyName = "" Then Throw New Exception("Selezionare una proprietà.")

      m_currentListaDocsAtt.Sort(SortFactory.GetItemComparer(PropertyName, Descending, "ElectronicDocument"))
   End Sub


   Public Function Current() As ElectronicDocument
      Return m_CurrentElectronicDocument
   End Function
   Public Function CurrentDocumentoAttivita() As ElectronicDocument
      Return m_CurrentElectronicDocumentAttitvita
   End Function

   Public Sub New(ByVal Target As Object)
      m_Target = Target
      m_Archivio = m_Target.ArchivioDocumenti
      ps.BeginTransaction()
   End Sub

   'Public ReadOnly Property PersistenceService() As IPersistenceFacade
   '   Get
   '      Return ps
   '   End Get

   'End Property

   Public Sub Save()
      ps.CommitTransaction()
      ps.BeginTransaction()
   End Sub

   Public Function CreateDirectoryPreferenziale() As String
      Dim c As New ControllerSegreteria
      c.LoadById(1)
      Return c.GetDirectoryPreferenziale(m_Target)
   End Function

   Public Sub LoadListaDocumenti()
      m_currentListaDocs = New ArrayList(m_Archivio.Documenti)
   End Sub

   Public Sub LoadListaDocumentiByPattern(ByVal pattern As String)
      m_currentListaDocs = New ArrayList
      Dim pattern1 As String = pattern.ToLower
      For Each elem As ElectronicDocument In m_Archivio.Documenti
         Dim pat As String = elem.FileNameWithoutPath.ToLower
         If pat.Contains(pattern1) Then
            m_currentListaDocs.Add(elem)
         End If
      Next
   End Sub

   Public Sub LoadListaDocumentiAttivitaByPattern(ByVal pattern As String)
      Dim pattern1 As String = pattern.ToLower
      m_currentListaDocsAtt = New ArrayList
      For Each elem As ElectronicDocument In m_ArchivioAttivita.Documenti
         Dim pat As String = elem.FileNameWithoutPath.ToLower
         If pat.Contains(pattern1) Then
            m_currentListaDocsAtt.Add(elem)
         End If
      Next
   End Sub



   Public Function GetListaDocumenti() As IList
      Return m_currentListaDocs
   End Function

   'Public Function GetListaDocumentiOrdinati() As IList
   '   Return m_Archivio.DocumentiOrdinati
   'End Function

   Public Function NumberOfListaDoc(ByVal Tipo As TipoDocumentazione) As Int32
      Return m_Archivio.DocumentiPerTipo(Tipo).Count
   End Function

   Public Function NumberOfListaDocAttivita(ByVal Tipo As TipoDocumentazione) As Int32
      Return m_ArchivioAttivita.DocumentiPerTipo(Tipo).Count
   End Function

   Public Sub LoadListaDocumentiPerTipo(ByVal Tipo As TipoDocumentazione)
      m_currentListaDocs = New ArrayList(m_Archivio.DocumentiPerTipo(Tipo))
   End Sub

   'Public Function GetListaDocumentiPerTipo(ByVal Tipo As TipoDocumentazione) As IList
   '   Return m_Archivio.DocumentiPerTipo(Tipo)
   'End Function

   'Public Function GetListaDocumentiAttivitaPerTipo(ByVal Tipo As TipoDocumentazione, Optional ByVal IdVertenza As String = "") As IList
   '   If Not IsNumeric(IdVertenza) Then
   '      Return m_ArchivioAttivita.DocumentiPerTipo(Tipo)
   '   End If
   '   Dim lista As IList = New ArrayList


   '   For Each elem As ElectronicDocument In m_ArchivioAttivita.DocumentiPerTipo(Tipo)
   '      If elem.Id = IdVertenza Then
   '         lista.Add(elem)
   '      End If
   '   Next

   '   Return lista
   'End Function

   Public Sub LoadListaDocumentiAttivitaPerTipo(ByVal Tipo As TipoDocumentazione, Optional ByVal IdVertenza As String = "")
      If Not IsNumeric(IdVertenza) Then
         m_currentListaDocsAtt = m_ArchivioAttivita.DocumentiPerTipo(Tipo)
         Return
      End If
      m_currentListaDocsAtt = New ArrayList


      For Each elem As ElectronicDocument In m_ArchivioAttivita.DocumentiPerTipo(Tipo)
         If elem.Id = IdVertenza Then
            m_currentListaDocsAtt.Add(elem)
         End If
      Next
   End Sub

    Public Function GetListaDocumentYears() As IList

        LoadListaDocumenti()

        'dalla lista dei documenti recupero tutti gli anni
        Dim h As New Hashtable
        For Each elem As ElectronicDocument In m_currentListaDocs
            If Not h.ContainsKey(elem.Data.Year) Then

                h.Add(elem.Data.Year, "")

            End If
        Next

        Dim result As New ArrayList()
        Dim e As IEnumerator = h.GetEnumerator()
        While e.MoveNext

            Dim year = Convert.ToInt32(e.Current.Key)
            result.Add(year)

        End While

        result.Sort()
        Return result

    End Function

   Public Function GetListaTipiDocumentazione() As IList
      Dim list As IList = ps.GetAllObjects("TipoDocumentazione")

      Dim sortList As New ArrayList(list)
      sortList.Sort()
      Return sortList
    End Function
 

   Public Sub AddElectronicDocument(ByVal Documento As ElectronicDocument)

      m_Archivio.AddDocumento(Documento, True)

      m_CurrentElectronicDocument = Documento

      ps.MarkNew(m_CurrentElectronicDocument)

   End Sub



   Public Sub RemoveDocumento(ByVal Documento As ElectronicDocument, ByVal RemoveFile As Boolean)
      m_Archivio.RemoveDocumento(Documento, RemoveFile)

      ps.MarkRemoved(Documento)

   End Sub
   Public Sub SelectDocumento(ByVal documento As ElectronicDocument)
      m_CurrentElectronicDocument = documento
   End Sub

   Public Sub SelectDocumentoAttivita(ByVal documento As ElectronicDocument)
      m_CurrentElectronicDocumentAttitvita = documento
   End Sub

   Public Property Data() As DateTime
      Get
         Return m_CurrentElectronicDocument.Data
      End Get
      Set(ByVal value As DateTime)
         m_CurrentElectronicDocument.Data = value
         ps.MarkDirty(m_CurrentElectronicDocument)
      End Set
    End Property

    Public Sub SetReferente(idReferente As String)

        If idReferente = "" Then
            m_CurrentElectronicDocument.Referente = Nothing
            Return
        End If


        Dim referente As Referente = m_controllerReferetni.GetReferenteById(idReferente)
        If referente.Id = -1 Then
            m_CurrentElectronicDocument.Referente = Nothing
            Return
        End If

        m_CurrentElectronicDocument.Referente = referente

      
    End Sub



    Public ReadOnly Property Referente() As Referente
        Get
            Return m_CurrentElectronicDocument.Referente
        End Get

    End Property

   Public Property TipoDocumentazione() As TipoDocumentazione
      Get
         Return m_CurrentElectronicDocument.TipoDocumentazione
      End Get
      Set(ByVal value As TipoDocumentazione)
         m_CurrentElectronicDocument.TipoDocumentazione = value
         ps.MarkDirty(m_CurrentElectronicDocument)
      End Set
   End Property


   Public Property FileName() As String
      Get
         Return m_CurrentElectronicDocument.FullFileName
      End Get
      Set(ByVal value As String)
         m_CurrentElectronicDocument.FullFileName = value
         ps.MarkDirty(m_CurrentElectronicDocument)
      End Set
   End Property

   Public Property Note() As String
      Get
         Return m_CurrentElectronicDocument.Notes
      End Get
      Set(ByVal value As String)
         m_CurrentElectronicDocument.Notes = value
         ps.MarkDirty(m_CurrentElectronicDocument)
      End Set
   End Property



   Public Function ExistFile()
      Return m_CurrentElectronicDocument.ExistFile
   End Function



   Public Sub MoveFile(ByVal Destination As String, ByVal Sovrascrivi As Boolean)
      m_CurrentElectronicDocument.MoveFile(Destination, Sovrascrivi)
      ps.MarkDirty(m_CurrentElectronicDocument)
   End Sub

   Public Sub CopyFile(ByVal Destination As String, ByVal Sovrascrivi As Boolean, ByVal ChangeReference As Boolean)
      m_CurrentElectronicDocument.CopyFile(Destination, Sovrascrivi, ChangeReference)
      If ChangeReference Then
         ps.MarkDirty(m_CurrentElectronicDocument)
      End If
   End Sub


   Public Sub RenameFile(ByVal NewName As String)
      m_CurrentElectronicDocument.RenameFile(NewName)
      ps.MarkDirty(m_CurrentElectronicDocument)
   End Sub

   Public Property DirectoryPreferenziale() As String
      Get
         Return m_Target.DirectoryPreferenziale
      End Get
      Set(ByVal value As String)
         m_Target.DirectoryPreferenziale = value
         ps.MarkDirty(m_Target)
      End Set
   End Property

   'Public ReadOnly Property DefaultPath() As String
   '   Get
   '      Return m_CurrentElectronicDocument.DefaultPath
   '   End Get

   'End Property

   Public Sub LoadListaDocumentiAttivitaFromDB()
      Dim c As New ControllerComunicazioni
      Dim p As New ADMINISTRATION.ControllerPrestazioni
      Dim v As New ADMINISTRATION.ControllerVertenze(False)

      c.LoadAllByUtente(m_Target.Id)
      p.LoadAllByUtente(m_Target.Id)
      v.LoadAllByUtente(m_Target.Id)

      Dim comunicazioni As IList = c.LoadedObjects
      Dim prestazioni As IList = p.LoadedObjects
      Dim vertenze As IList = v.LoadedObjects

      m_ArchivioAttivita.Documenti.Clear()
      'Dim documenti As IList = m_Archivio.Documenti
      AddListaDocumentiComunicazioni(comunicazioni)
      AddListaDocumentiPrestazioni(prestazioni)
      AddListaDocumentiVertenze(vertenze)
   End Sub


   Public Sub LoadListaDocumentiAttivita()
      m_currentListaDocsAtt = m_ArchivioAttivita.Documenti
   End Sub



   Public Function GetListaDocumentiAttivita() As IList
      Return m_currentListaDocsAtt
   End Function

    Private Sub AddListaDocumentiComunicazioni(ByVal target As IList)
        For Each elem As Comunicazione In target
            If elem.Allegato <> "" Then
                Dim doc As New ElectronicDocument
                doc.Key = New Key(elem.Id)
                doc.TipoDocumentazione = TipoDocumentazione.CreaTipoComunicazione
                doc.Data = elem.DataDocumento
                doc.FullFileName = elem.Allegato
                doc.Notes = "Causale comunicazione: " & elem.Causale.Descrizione.ToUpper

                m_ArchivioAttivita.AddDocumento(doc)
            End If
        Next
    End Sub

    Private Sub AddListaDocumentiPrestazioni(ByVal target As IList)
        For Each elem As Prestazione In target
            If elem.FileOutPut <> "" Then
                Dim doc As New ElectronicDocument
                doc.Key = New Key(elem.Id)
                doc.TipoDocumentazione = TipoDocumentazione.CreaTipoPrestazione
                doc.Data = elem.DataDocumento
                doc.FullFileName = elem.FileOutPut
                doc.Notes = "Tipo prestazione: " & elem.TipoPrestazione.Descrizione.ToUpper
                If elem.Referente IsNot Nothing And elem.Referente.Id > -1 Then
                    doc.Referente = elem.Referente
                End If

                m_ArchivioAttivita.AddDocumento(doc)
            End If
        Next
    End Sub

    Private Sub AddListaDocumentiVertenze(ByVal target As IList)
        For Each vert As Vertenza In target
            For Each elem As Evento In vert.ListaEventi
                If elem.Path_Documento <> "" Then
                    Dim doc As New ElectronicDocument
                    doc.Key = New Key(vert.Id)
                    doc.TipoDocumentazione = TipoDocumentazione.CreaTipoVertenza
                    doc.Data = elem.DataDocumento
                    doc.FullFileName = elem.Path_Documento
                    doc.Notes = "Tipo evento: " & elem.TipoEvento.Tipo.ToString.ToUpper
                    doc.Descrizione = "Vertenza " & vert.Azienda.Descrizione
                    m_ArchivioAttivita.AddDocumento(doc)
                End If
            Next

        Next
    End Sub

   Public Function GetNumeroDocumenti() As Int32
      Return m_Archivio.Documenti.Count + m_ArchivioAttivita.Documenti.Count
   End Function

    Sub LoadListaDocumentiPerAnno(m_annoSelezionato As Integer)
        m_currentListaDocs = New ArrayList(m_Archivio.DocumentiPerAnno(m_annoSelezionato))
    End Sub
    Sub LoadListaDocumentiPerAnnoETipo(m_annoSelezionato As Integer, ByVal Tipo As TipoDocumentazione)
        m_currentListaDocs = New ArrayList(m_Archivio.DocumentiPerAnnoETipo(m_annoSelezionato, Tipo))
    End Sub

    Function GetListaTipiDocumentazionePerAnni(anno As Integer) As IList
        LoadListaDocumenti()

        Dim h As New Hashtable

        For Each elem As ElectronicDocument In m_currentListaDocs
            If Not h.ContainsKey(elem.TipoDocumentazione.Id) Then
                If elem.Data.Year = anno Then
                    h.Add(elem.TipoDocumentazione.Id, elem.TipoDocumentazione)
                End If
            End If
        Next

        Dim result As New ArrayList

        Dim en As IEnumerator = h.GetEnumerator
        While en.MoveNext

            result.Add(en.Current.Value)

        End While

        Return result

    End Function

End Class
