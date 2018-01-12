Imports WIN.DOMAIN.FED_SERVICES
Imports System.Windows.Forms
Public Class TreeViewAttivitaLoaders
   Public Shared Sub LoadTreeView(ByVal handler As ServicesTimeSorter, ByVal Tree As TreeView)
      Dim parent As TreeNode = Tree.Nodes(0)
      parent.Tag = 0
      Dim lista As IList = handler.GetListaAnniRiferimentoServizi

      Tree.SuspendLayout()


      For Each elem As Int32 In lista
         Dim node As New TreeNode("Anno - " & elem.ToString, 4, 4)
         node.Tag = elem
         parent.Nodes.Add(node)
      Next

      Tree.ExpandAll()

      Tree.ResumeLayout()

   End Sub

End Class
