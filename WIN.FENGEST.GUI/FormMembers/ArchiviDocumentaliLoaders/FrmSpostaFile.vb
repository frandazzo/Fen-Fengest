Public Class FrmSpostaFile

   Private m_Destination As String = ""
   Public WriteOnly Property Destination() As String
      Set(ByVal value As String)
         m_Destination = value
      End Set
   End Property



   Private Sub chkRinomina_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkRinomina.CheckedChanged
      If chkRinomina.Checked Then
         txtNomeFileRin.Enabled = True
      Else
         txtNomeFileRin.Enabled = False
      End If
   End Sub

   Private Sub cmdSel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSel.Click
      OpenFileDialog1.CheckFileExists = True
      OpenFileDialog1.ShowDialog()
      txtFile.Text = OpenFileDialog1.FileName
   End Sub

   Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click

      If txtFile.Text = "" Then
         MsgBox("Inserire un nome file corretto", MsgBoxStyle.Information, "FenealGest")
         Return
      End If
      Dim path As String = My.Computer.FileSystem.GetFileInfo(txtFile.Text).DirectoryName
      Dim filename As String = My.Computer.FileSystem.GetFileInfo(txtFile.Text).Name

      If chkRinomina.Checked Then
         If txtNomeFileRin.Text = "" Then
            MsgBox("Rinominare correttamente il file", MsgBoxStyle.Information, "FenealGest")
            Return
         End If
         filename = txtNomeFileRin.Text
      End If

      If m_Destination = "" Then
         MsgBox("Impostare un percorso di destinazione", MsgBoxStyle.Information, "FenealGest")
         Return
      End If

      If m_Destination.EndsWith("\") Then
         filename = m_Destination & filename
      Else
         filename = m_Destination & "\" & filename
      End If


      Try
         My.Computer.FileSystem.MoveFile(txtFile.Text, filename)
         Me.Close()
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try


   End Sub

 
End Class