Public Class ControlloselezioneDataRange

   Private m_Din As DateTime = Today.Date
   Private m_Df As DateTime = Today.Date

   Public ReadOnly Property Start() As DateTime
      Get
         Return m_Din
      End Get
   End Property
   Public ReadOnly Property Finish() As DateTime
      Get
         Return m_Df
      End Get
   End Property
   Public ReadOnly Property GetIntervalloTostring() As String
      Get
         Return "Dal " & m_Din.Date & " al " & m_Df.Date
      End Get
   End Property





   Private Sub CmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdOk.Click
      m_Din = dtpI.Value
      m_Df = dtpF.Value
      If m_Df < m_Din Then
         MsgBox("Inserire un intervallo corretto. La data fine non può essere inferiore alla data di inizio.", MsgBoxStyle.Information, "Selezione intervallo date")
      Else
         Me.ParentForm.DialogResult = Windows.Forms.DialogResult.OK
         Me.ParentForm.Close()
      End If
   End Sub


   Private Sub cmdAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnnulla.Click
      Me.ParentForm.DialogResult = Windows.Forms.DialogResult.Cancel
      Me.ParentForm.Close()
   End Sub
End Class
