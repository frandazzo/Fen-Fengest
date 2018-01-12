Public Class FrmCausaliRevoca
   Private controllerCausali As IControllerCodifiche
   Private op As OperazioneCausali = OperazioneCausali.Add
   Private m_DescrizioneCausale As String = ""
   Public Enum OperazioneCausali
      Add
      Update
   End Enum
   Public Sub New(ByVal Controller As IControllerCodifiche, ByVal Operation As FrmCausaliRevoca.OperazioneCausali)

      ' Chiamata richiesta da Progettazione Windows Form.
      InitializeComponent()
      controllerCausali = Controller
      Select Case Operation
         Case OperazioneCausali.Add
            op = OperazioneCausali.Add
            txtDescr.Text = ""
            Me.Text = "Nuovo"
         Case OperazioneCausali.Update
            op = OperazioneCausali.Update
            txtDescr.Text = Controller.Descrizione
            Me.Text = "Aggiorna"
            controllerCausali.LoadById(Controller.Id)
      End Select
      ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

   End Sub
  
    Private Sub SpecialButton2_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub SpecialButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpecialButton1.Click
        Try
            If op = OperazioneCausali.Add Then
                controllerCausali.CreateNew(txtDescr.Text)
            Else
                controllerCausali.Descrizione = txtDescr.Text
                controllerCausali.Save()
            End If
            Me.Close()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

   Private Sub SpecialButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpecialButton2.Click
      Me.Close()
   End Sub
End Class