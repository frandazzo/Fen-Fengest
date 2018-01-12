<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProfileListForm
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
      Me.ComboBox1 = New System.Windows.Forms.ComboBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.uxOKButton = New System.Windows.Forms.Button
      Me.uxCancelButton = New System.Windows.Forms.Button
      Me.SuspendLayout()
      '
      'ComboBox1
      '
      Me.ComboBox1.FormattingEnabled = True
      Me.ComboBox1.Location = New System.Drawing.Point(15, 29)
      Me.ComboBox1.Name = "ComboBox1"
      Me.ComboBox1.Size = New System.Drawing.Size(208, 21)
      Me.ComboBox1.TabIndex = 0
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(14, 11)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(84, 13)
      Me.Label1.TabIndex = 1
      Me.Label1.Text = "Seleziona profilo"
      '
      'uxOKButton
      '
      Me.uxOKButton.Location = New System.Drawing.Point(105, 56)
      Me.uxOKButton.Name = "uxOKButton"
      Me.uxOKButton.Size = New System.Drawing.Size(53, 27)
      Me.uxOKButton.TabIndex = 21
      Me.uxOKButton.Text = "OK"
      Me.uxOKButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.uxOKButton.UseVisualStyleBackColor = True
      '
      'uxCancelButton
      '
      Me.uxCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.uxCancelButton.Location = New System.Drawing.Point(164, 56)
      Me.uxCancelButton.Name = "uxCancelButton"
      Me.uxCancelButton.Size = New System.Drawing.Size(53, 27)
      Me.uxCancelButton.TabIndex = 22
      Me.uxCancelButton.Text = "Annulla"
      Me.uxCancelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.uxCancelButton.UseVisualStyleBackColor = True
      '
      'ProfileListForm
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(235, 94)
      Me.Controls.Add(Me.uxOKButton)
      Me.Controls.Add(Me.uxCancelButton)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.ComboBox1)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Name = "ProfileListForm"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Profili"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Private WithEvents uxOKButton As System.Windows.Forms.Button
   Private WithEvents uxCancelButton As System.Windows.Forms.Button
End Class
