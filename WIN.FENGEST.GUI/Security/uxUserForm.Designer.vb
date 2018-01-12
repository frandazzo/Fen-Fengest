<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uxUserForm
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
      Me.groupBox1 = New System.Windows.Forms.GroupBox
      Me.label1 = New System.Windows.Forms.Label
      Me.label2 = New System.Windows.Forms.Label
      Me.uxUsernameTextBox = New System.Windows.Forms.TextBox
      Me.uxInfoLabel = New System.Windows.Forms.Label
      Me.uxSurnameTextBox = New System.Windows.Forms.TextBox
      Me.uxPasswordTextBox = New System.Windows.Forms.TextBox
      Me.uxNameTextBox = New System.Windows.Forms.TextBox
      Me.label4 = New System.Windows.Forms.Label
      Me.label3 = New System.Windows.Forms.Label
      Me.uxOKButton = New System.Windows.Forms.Button
      Me.uxCancelButton = New System.Windows.Forms.Button
      Me.groupBox1.SuspendLayout()
      Me.SuspendLayout()
      '
      'groupBox1
      '
      Me.groupBox1.Controls.Add(Me.label1)
      Me.groupBox1.Controls.Add(Me.label2)
      Me.groupBox1.Controls.Add(Me.uxUsernameTextBox)
      Me.groupBox1.Controls.Add(Me.uxInfoLabel)
      Me.groupBox1.Controls.Add(Me.uxSurnameTextBox)
      Me.groupBox1.Controls.Add(Me.uxPasswordTextBox)
      Me.groupBox1.Controls.Add(Me.uxNameTextBox)
      Me.groupBox1.Controls.Add(Me.label4)
      Me.groupBox1.Controls.Add(Me.label3)
      Me.groupBox1.Location = New System.Drawing.Point(5, 8)
      Me.groupBox1.Name = "groupBox1"
      Me.groupBox1.Size = New System.Drawing.Size(248, 219)
      Me.groupBox1.TabIndex = 21
      Me.groupBox1.TabStop = False
      Me.groupBox1.Text = "Info utente"
      '
      'label1
      '
      Me.label1.AutoSize = True
      Me.label1.Location = New System.Drawing.Point(16, 16)
      Me.label1.Name = "label1"
      Me.label1.Size = New System.Drawing.Size(58, 13)
      Me.label1.TabIndex = 2
      Me.label1.Text = "Username:"
      '
      'label2
      '
      Me.label2.AutoSize = True
      Me.label2.Location = New System.Drawing.Point(16, 61)
      Me.label2.Name = "label2"
      Me.label2.Size = New System.Drawing.Size(56, 13)
      Me.label2.TabIndex = 3
      Me.label2.Text = "Password:"
      '
      'uxUsernameTextBox
      '
      Me.uxUsernameTextBox.Location = New System.Drawing.Point(19, 38)
      Me.uxUsernameTextBox.Name = "uxUsernameTextBox"
      Me.uxUsernameTextBox.Size = New System.Drawing.Size(223, 20)
      Me.uxUsernameTextBox.TabIndex = 0
      '
      'uxInfoLabel
      '
      Me.uxInfoLabel.AutoSize = True
      Me.uxInfoLabel.ForeColor = System.Drawing.Color.Blue
      Me.uxInfoLabel.Location = New System.Drawing.Point(7, 194)
      Me.uxInfoLabel.Name = "uxInfoLabel"
      Me.uxInfoLabel.Size = New System.Drawing.Size(152, 13)
      Me.uxInfoLabel.TabIndex = 15
      Me.uxInfoLabel.Text = "L'utente appartiene al ruolo {0}"
      '
      'uxSurnameTextBox
      '
      Me.uxSurnameTextBox.Location = New System.Drawing.Point(19, 162)
      Me.uxSurnameTextBox.Name = "uxSurnameTextBox"
      Me.uxSurnameTextBox.Size = New System.Drawing.Size(223, 20)
      Me.uxSurnameTextBox.TabIndex = 8
      '
      'uxPasswordTextBox
      '
      Me.uxPasswordTextBox.Location = New System.Drawing.Point(19, 81)
      Me.uxPasswordTextBox.Name = "uxPasswordTextBox"
      Me.uxPasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
      Me.uxPasswordTextBox.Size = New System.Drawing.Size(223, 20)
      Me.uxPasswordTextBox.TabIndex = 1
      '
      'uxNameTextBox
      '
      Me.uxNameTextBox.Location = New System.Drawing.Point(19, 120)
      Me.uxNameTextBox.Name = "uxNameTextBox"
      Me.uxNameTextBox.Size = New System.Drawing.Size(223, 20)
      Me.uxNameTextBox.TabIndex = 7
      '
      'label4
      '
      Me.label4.AutoSize = True
      Me.label4.Location = New System.Drawing.Point(16, 104)
      Me.label4.Name = "label4"
      Me.label4.Size = New System.Drawing.Size(38, 13)
      Me.label4.TabIndex = 9
      Me.label4.Text = "Nome:"
      '
      'label3
      '
      Me.label3.AutoSize = True
      Me.label3.Location = New System.Drawing.Point(16, 146)
      Me.label3.Name = "label3"
      Me.label3.Size = New System.Drawing.Size(55, 13)
      Me.label3.TabIndex = 10
      Me.label3.Text = "Cognome:"
      '
      'uxOKButton
      '
      Me.uxOKButton.Location = New System.Drawing.Point(30, 237)
      Me.uxOKButton.Name = "uxOKButton"
      Me.uxOKButton.Size = New System.Drawing.Size(85, 27)
      Me.uxOKButton.TabIndex = 19
      Me.uxOKButton.Text = "OK"
      Me.uxOKButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.uxOKButton.UseVisualStyleBackColor = True
      '
      'uxCancelButton
      '
      Me.uxCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.uxCancelButton.Location = New System.Drawing.Point(141, 237)
      Me.uxCancelButton.Name = "uxCancelButton"
      Me.uxCancelButton.Size = New System.Drawing.Size(85, 27)
      Me.uxCancelButton.TabIndex = 20
      Me.uxCancelButton.Text = "Annulla"
      Me.uxCancelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.uxCancelButton.UseVisualStyleBackColor = True
      '
      'uxUserForm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(265, 284)
      Me.Controls.Add(Me.groupBox1)
      Me.Controls.Add(Me.uxOKButton)
      Me.Controls.Add(Me.uxCancelButton)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Name = "uxUserForm"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "uxUserForm"
      Me.groupBox1.ResumeLayout(False)
      Me.groupBox1.PerformLayout()
      Me.ResumeLayout(False)

   End Sub
   Private WithEvents groupBox1 As System.Windows.Forms.GroupBox
   Private WithEvents label1 As System.Windows.Forms.Label
   Private WithEvents label2 As System.Windows.Forms.Label
   Private WithEvents uxUsernameTextBox As System.Windows.Forms.TextBox
   Private WithEvents uxInfoLabel As System.Windows.Forms.Label
   Private WithEvents uxSurnameTextBox As System.Windows.Forms.TextBox
   Private WithEvents uxPasswordTextBox As System.Windows.Forms.TextBox
   Private WithEvents uxNameTextBox As System.Windows.Forms.TextBox
   Private WithEvents label4 As System.Windows.Forms.Label
   Private WithEvents label3 As System.Windows.Forms.Label
   Private WithEvents uxOKButton As System.Windows.Forms.Button
   Private WithEvents uxCancelButton As System.Windows.Forms.Button
End Class
