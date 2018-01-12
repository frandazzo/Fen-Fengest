Public Class FrmLista

   Public Sub New(ByVal Lista As ArrayList, ByVal Caption As String)
      InitializeComponent()
      Me.Text = Caption
      If Lista.Count = 0 Then
         Me.lstElem.Items.Add("Nessun elemento specificato")
         Exit Sub
      End If
      For Each elem As String In Lista
         Me.lstElem.Items.Add(elem)
      Next
   End Sub
End Class