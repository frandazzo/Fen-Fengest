Public Class FrmRinominaFile

   Private m_NuovoNome As String
   Private m_NomeFile As String



   Public ReadOnly Property NuovoNome() As String
      Get
         Return m_NuovoNome
      End Get
   End Property

   Public Sub New(ByVal NomeFile As String)
      InitializeComponent()
      m_NomeFile = NomeFile
      Me.DialogResult = Windows.Forms.DialogResult.Cancel
      TextBox1.Text = m_NomeFile
   End Sub


   Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
      Me.DialogResult = Windows.Forms.DialogResult.OK
      If TextBox2.Text = "" Then
         Me.DialogResult = Windows.Forms.DialogResult.Cancel
         System.Windows.Forms.MessageBox.Show("Inserire un nuovo nome per il file!", "Messaggio", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Exclamation)
      End If
      m_NuovoNome = TextBox2.Text
      Me.Close()

   End Sub

   Private Sub cmdAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnnulla.Click
      Me.DialogResult = Windows.Forms.DialogResult.Cancel
      Me.Close()

   End Sub
End Class