Imports win.DOMAIN.FEDERATIONARTIFACTS
Public Class FrmSelezionaListaLavoro

   Private m_ListaLavoro As ListaLavoroUtenti
   Private controller As New ControllerListaUtenti


   Public ReadOnly Property ListaLavoro() As ListaLavoroUtenti
      Get
         Return m_ListaLavoro
      End Get
   End Property


   Private Sub cmdAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnnulla.Click
      Me.DialogResult = Windows.Forms.DialogResult.Cancel
      Me.Close()
   End Sub

   Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
      If IdListaUtentiTextBox1.TextValue = "" Then
         Me.DialogResult = Windows.Forms.DialogResult.Cancel
         Me.Close()
         Return
      End If

      controller.LoadById(IdListaUtentiTextBox1.TextValue)
      m_ListaLavoro = controller.Current
      Me.DialogResult = Windows.Forms.DialogResult.OK
      Me.Close()
      Try

      Catch ex As Exception
         Me.DialogResult = Windows.Forms.DialogResult.Cancel
         Me.Close()


      End Try

   End Sub
End Class