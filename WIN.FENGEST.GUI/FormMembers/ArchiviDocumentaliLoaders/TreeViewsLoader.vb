Imports System.Windows.Forms
Imports WIN.DOMAIN.FEDERATIONARTIFACTS


Public Class TreeViewsLoader

   Public Shared Sub LoadTreeViewArchivio(ByVal controller As ControllerArchivioDocumentale, ByVal tree As TreeView)

        tree.SuspendLayout()

        Dim parentNode As TreeNode = tree.Nodes("Nodo0")
        parentNode.Nodes.Clear()
        ' Dim listaTipi As IList = controller.GetListaTipiDocumentazione
        Dim anni As IList = controller.GetListaDocumentYears
        For Each elem As Int32 In anni
            Dim node As TreeNode = New TreeNode(elem)
            node.Tag = elem
            parentNode.Nodes.Add(node)

            'allinterno del nodo relativo all'anno inserisco tutti tipi documentazione
            For Each doc As TipoDocumentazione In controller.GetListaTipiDocumentazionePerAnni(elem)
                If controller.NumberOfListaDoc(doc) > 0 Then
                    Dim node1 As TreeNode = New TreeNode(doc.Descrizione, 4, 4)
                    node1.Tag = doc
                    node.Nodes.Add(node1)
                End If
            Next
        Next




        
        tree.ExpandAll()

        tree.ResumeLayout()
   End Sub

   Public Shared Sub LoadTreeViewAttivita(ByVal controller As ControllerArchivioDocumentale, ByVal tree As TreeView)

      tree.SuspendLayout()

      Dim parentNode As TreeNode = tree.Nodes("Nodo0")
      parentNode.Nodes.Clear()
      Dim listaTipi As IList = New ArrayList
      listaTipi.Add(TipoDocumentazione.CreaTipoComunicazione)
      listaTipi.Add(TipoDocumentazione.CreaTipoPrestazione)



      For Each elem As TipoDocumentazione In listaTipi
         If controller.NumberOfListaDocAttivita(elem) > 0 Then
            Dim node As TreeNode = New TreeNode(elem.Descrizione, 4, 4)
            node.Tag = elem
            parentNode.Nodes.Add(node)
         End If
      Next


      AggiungiNodoVertenza(parentNode, controller)

      tree.ExpandAll()

      tree.ResumeLayout()
   End Sub

   Private Shared Sub AggiungiNodoVertenza(ByVal node As TreeNode, ByVal controller As ControllerArchivioDocumentale)
      Dim vertNode As TreeNode
      Dim listaEv As IList
      If controller.NumberOfListaDocAttivita(TipoDocumentazione.CreaTipoVertenza) > 0 Then
         listaEv = controller.GetListaDocumentiAttivita
         node.Nodes.Add(New TreeNode("VERTENZE", 4, 4))
         vertNode = node.Nodes(node.Nodes.Count - 1)
         vertNode.Tag = TipoDocumentazione.CreaTipoVertenza

         Dim hash As New Hashtable
         FillHashTable(hash, listaEv)


         For Each elem As Int32 In hash.Keys
            Dim n As New TreeNode(hash.Item(elem).Descrizione, 2, 2)
            n.Tag = hash.Item(elem).TipoDocumentazione
            n.Name = hash.Item(elem).Id
            vertNode.Nodes.Add(n)
         Next

      End If
   End Sub

   Private Shared Sub FillHashTable(ByVal hash As Hashtable, ByVal lista As IList)
      Try
         For Each elem As ElectronicDocument In lista
            hash.Add(elem.Id, elem)
         Next
      Catch ex As Exception

      End Try
   End Sub



End Class
