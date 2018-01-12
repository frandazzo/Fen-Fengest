Imports System.Windows.Forms

Public Class ProfileDescriptorForm


   Private m_Descrizione As String


   Public Sub New(ByVal descrizione As String, ByVal caption As String)
      InitializeComponent()
      Me.Text = caption
      Me.TextBox1.Text = descrizione
   End Sub

   Public ReadOnly Property Descrizione() As String
      Get
         Return m_Descrizione
      End Get
   End Property

   Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
      m_Descrizione = TextBox1.Text
      Me.DialogResult = System.Windows.Forms.DialogResult.OK
      Me.Close()
   End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
