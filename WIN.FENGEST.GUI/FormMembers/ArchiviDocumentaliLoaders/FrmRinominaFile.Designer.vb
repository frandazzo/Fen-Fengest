<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRinominaFile
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
      Me.cmdAnnulla = New System.Windows.Forms.Button
      Me.cmdOk = New System.Windows.Forms.Button
      Me.Label1 = New System.Windows.Forms.Label
      Me.TextBox1 = New System.Windows.Forms.TextBox
      Me.TextBox2 = New System.Windows.Forms.TextBox
      Me.Label2 = New System.Windows.Forms.Label
      Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
      Me.Label3 = New System.Windows.Forms.Label
      Me.SuspendLayout()
      '
      'cmdAnnulla
      '
      Me.cmdAnnulla.Location = New System.Drawing.Point(302, 115)
      Me.cmdAnnulla.Name = "cmdAnnulla"
      Me.cmdAnnulla.Size = New System.Drawing.Size(62, 22)
      Me.cmdAnnulla.TabIndex = 51
      Me.cmdAnnulla.Text = "Annulla"
      Me.cmdAnnulla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.cmdAnnulla.UseVisualStyleBackColor = True
      '
      'cmdOk
      '
      Me.cmdOk.Location = New System.Drawing.Point(226, 115)
      Me.cmdOk.Name = "cmdOk"
      Me.cmdOk.Size = New System.Drawing.Size(62, 22)
      Me.cmdOk.TabIndex = 50
      Me.cmdOk.Text = "Ok"
      Me.cmdOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.cmdOk.UseVisualStyleBackColor = True
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(9, 15)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(51, 13)
      Me.Label1.TabIndex = 52
      Me.Label1.Text = "Nome file"
      '
      'TextBox1
      '
      Me.TextBox1.Enabled = False
      Me.HelpProvider1.SetHelpString(Me.TextBox1, "Nome del file che si vuole rinominare.")
      Me.TextBox1.Location = New System.Drawing.Point(80, 8)
      Me.TextBox1.Name = "TextBox1"
      Me.HelpProvider1.SetShowHelp(Me.TextBox1, True)
      Me.TextBox1.Size = New System.Drawing.Size(285, 20)
      Me.TextBox1.TabIndex = 53
      '
      'TextBox2
      '
      Me.HelpProvider1.SetHelpString(Me.TextBox2, "Nuovo nome da assegnare al file che si vuole rinominare. Il nome deve essere spec" & _
              "ificato senza estensione.")
      Me.TextBox2.Location = New System.Drawing.Point(79, 72)
      Me.TextBox2.Name = "TextBox2"
      Me.HelpProvider1.SetShowHelp(Me.TextBox2, True)
      Me.TextBox2.Size = New System.Drawing.Size(285, 20)
      Me.TextBox2.TabIndex = 55
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Location = New System.Drawing.Point(8, 79)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(68, 13)
      Me.Label2.TabIndex = 54
      Me.Label2.Text = "Nuovo nome"
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Location = New System.Drawing.Point(77, 46)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(214, 13)
      Me.Label3.TabIndex = 56
      Me.Label3.Text = "Specificare il nuovo nome senza estensione"
      '
      'FrmRinominaFile
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(376, 149)
      Me.Controls.Add(Me.Label3)
      Me.Controls.Add(Me.TextBox2)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.TextBox1)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.cmdAnnulla)
      Me.Controls.Add(Me.cmdOk)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Name = "FrmRinominaFile"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Rinomina file"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents cmdAnnulla As System.Windows.Forms.Button
   Friend WithEvents cmdOk As System.Windows.Forms.Button
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
   Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
   Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
