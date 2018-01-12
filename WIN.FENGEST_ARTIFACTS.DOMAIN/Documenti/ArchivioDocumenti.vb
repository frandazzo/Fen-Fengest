Public Class ArchivioDocumenti

   Private m_Documents As IList = New ArrayList

#Region "Metodi per la gestione dei documenti elettronici"

   Public Sub AddDocumento(ByVal documento As ElectronicDocument)
      m_Documents.Add(documento)
   End Sub

   Public Sub AddDocumento(ByVal documento As ElectronicDocument, ByVal CheckIfAlreadyExist As Boolean)
      If CheckIfAlreadyExist Then
         If Not ExistDocumentWithFile(documento.FullFileName) Then
            AddDocumento(documento)
            Return
         End If
         Throw New InvalidOperationException("Documento esistente")
      End If
      AddDocumento(documento)
   End Sub

   Public Function ExistDocumentWithFile(ByVal FileName As String) As Boolean
      For Each elem As ElectronicDocument In m_Documents
         If elem.FullFileName.Equals(FileName) Then
            Return True
         End If
      Next

      Return False
   End Function


   Public Sub RemoveDocumento(ByVal documento As ElectronicDocument, ByVal RemoveFile As Boolean)
      m_Documents.Remove(documento)
      If RemoveFile Then
         If documento.ExistFile() Then
            documento.RemoveFile()
         End If
      End If
   End Sub

#End Region

   Public ReadOnly Property DocumentiOrdinati() As IList
      Get
         Dim list As New ArrayList(m_Documents)
         list.Sort()
         'm_Documents = list
         Return list
      End Get
   End Property

   Public Property Documenti() As IList
      Get
         Return m_Documents
      End Get
      Set(ByVal value As IList)
         m_Documents = value
      End Set
   End Property

   Public ReadOnly Property DocumentiPerTipo(ByVal Tipo As TipoDocumentazione) As IList
      Get
         'Creo la lista
         Dim list As IList = New ArrayList
         For Each elem As ElectronicDocument In m_Documents
            If elem.TipoDocumentazione.Id.Equals(Tipo.Id) Then
               list.Add(elem)
            End If
         Next

         'la ordino
         Dim orderedList As New ArrayList(list)
         orderedList.Sort(New ComparerByFileName)
         Return orderedList


      End Get
   End Property

    Public ReadOnly Property DocumentiPerAnnoETipo(ByVal anno As Int32, ByVal Tipo As TipoDocumentazione) As IList
        Get
            'Creo la lista
            Dim list As IList = New ArrayList
            For Each elem As ElectronicDocument In m_Documents
                If elem.Data.Year.Equals(anno) Then
                    If elem.TipoDocumentazione.Id.Equals(Tipo.Id) Then
                        list.Add(elem)
                    End If
                End If
            Next

            'la ordino
            Dim orderedList As New ArrayList(list)
            orderedList.Sort(New ComparerByFileName)
            Return orderedList


        End Get
    End Property

    Public ReadOnly Property DocumentiPerAnno(ByVal anno As Int32) As IList
        Get
            'Creo la lista
            Dim list As IList = New ArrayList
            For Each elem As ElectronicDocument In m_Documents
                If elem.Data.Year.Equals(anno) Then
                    list.Add(elem)
                End If
            Next

            'la ordino
            Dim orderedList As New ArrayList(list)
            orderedList.Sort(New ComparerByFileName)
            Return orderedList


        End Get
    End Property


   Public Class ComparerByFileName
      Implements IComparer

      Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare
         If x Is Nothing And y Is Nothing Then
            Return 0
         End If

         If x Is Nothing Then
            Return 1
         End If
         If y Is Nothing Then
            Return -1
         End If

         Dim doc1 As ElectronicDocument = CType(x, ElectronicDocument)
         Dim doc2 As ElectronicDocument = CType(y, ElectronicDocument)

         Return StrComp(doc1.FileNameWithoutPath, doc2.FileNameWithoutPath)

      End Function
   End Class


End Class
