Public MustInherit Class ServicesTimeSorter

   Protected m_Documenti As IList
   Protected comparer As IComparer


   Public Sub New(ByVal Lista As IList)
      m_Documenti = Lista
   End Sub


   Public Sub Sort()
      If m_Documenti Is Nothing Then
         Throw New ArgumentNullException("Lista")
      End If




      Dim a As New ArrayList(m_Documenti)

      a.Sort(comparer)

      m_Documenti = a

   End Sub

   Public ReadOnly Property OrderedList() As IList
      Get
         Sort()
         Return m_Documenti
      End Get
   End Property


   Public Function GetListaAnniRiferimentoServizi() As IList
      Sort()

      Dim lista As New ArrayList


      FillLista(lista)

      Return lista
   End Function

   Protected Sub FillLista(ByVal lista As IList)

      Dim hash As New Hashtable


      For Each elem As Object In m_Documenti
         Try
            Dim anno As Int32 = elem.DataDocumento.Year
            hash.Add(anno, "")
            lista.Add(anno)
         Catch ex As Exception

         End Try
      Next

   End Sub


   Public Function GetServiziPerAnnoDocumento(ByVal anno As Int32) As IList

      Dim lista As IList = New ArrayList

      For Each elem As Object In m_Documenti
         If elem.DataDocumento.Year = anno Then
            lista.Add(elem)
         End If
      Next

      Return lista
   End Function



End Class
