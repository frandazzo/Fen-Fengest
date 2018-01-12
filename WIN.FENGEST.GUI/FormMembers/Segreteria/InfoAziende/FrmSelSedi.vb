Public Class FrmSelSedi
   Public NomeSede As String = ""
   Public Sub New(ByVal NomeAzienda As String, ByVal ListaSedi As ArrayList, ByVal ValoreDefault As String)


      InitializeComponent()
      If NomeAzienda = "" Then Throw New ArgumentException("Sede operativa nulla")
      If ListaSedi.Count = 0 Then Throw New InvalidOperationException("Nessuna sede operativa presente")
      Me.lblAzienda.Text = NomeAzienda
      For Each elem As String In ListaSedi
         cboSede.Items.Add(elem)
      Next
      cboSede.Items.Add("")
      cboSede.Sorted = True
      cboSede.Text = ValoreDefault
      Me.DialogResult = Windows.Forms.DialogResult.Cancel
   End Sub

   Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
      Me.DialogResult = Windows.Forms.DialogResult.OK
      Me.NomeSede = cboSede.Text
      Me.Close()
   End Sub


   Private Sub cmdAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnnulla.Click
      Me.DialogResult = Windows.Forms.DialogResult.Cancel
      Me.Close()
   End Sub
End Class