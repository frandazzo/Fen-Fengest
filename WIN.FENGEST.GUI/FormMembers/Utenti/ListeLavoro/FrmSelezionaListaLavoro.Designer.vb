<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSelezionaListaLavoro
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
      Me.IdListaUtentiTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdListaUtentiTextBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.SuspendLayout()
      '
      'cmdAnnulla
      '
      Me.cmdAnnulla.Location = New System.Drawing.Point(120, 78)
      Me.cmdAnnulla.Name = "cmdAnnulla"
      Me.cmdAnnulla.Size = New System.Drawing.Size(62, 22)
      Me.cmdAnnulla.TabIndex = 53
      Me.cmdAnnulla.Text = "Annulla"
      Me.cmdAnnulla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.cmdAnnulla.UseVisualStyleBackColor = True
      '
      'cmdOk
      '
      Me.cmdOk.Location = New System.Drawing.Point(44, 78)
      Me.cmdOk.Name = "cmdOk"
      Me.cmdOk.Size = New System.Drawing.Size(62, 22)
      Me.cmdOk.TabIndex = 52
      Me.cmdOk.Text = "Ok"
      Me.cmdOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.cmdOk.UseVisualStyleBackColor = True
      '
      'IdListaUtentiTextBox1
      '
      Me.IdListaUtentiTextBox1.BackColor = System.Drawing.Color.Transparent
      Me.IdListaUtentiTextBox1.EnableSerchTextBox = True
      Me.IdListaUtentiTextBox1.Location = New System.Drawing.Point(86, 24)
      Me.IdListaUtentiTextBox1.Margin = New System.Windows.Forms.Padding(0)
      Me.IdListaUtentiTextBox1.Name = "IdListaUtentiTextBox1"
      Me.IdListaUtentiTextBox1.Size = New System.Drawing.Size(109, 39)
      Me.IdListaUtentiTextBox1.TabIndex = 54
      Me.IdListaUtentiTextBox1.TextValue = ""
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(12, 40)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(61, 13)
      Me.Label1.TabIndex = 55
      Me.Label1.Text = "Lista lavoro"
      '
      'FrmSelezionaListaLavoro
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(228, 114)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.IdListaUtentiTextBox1)
      Me.Controls.Add(Me.cmdAnnulla)
      Me.Controls.Add(Me.cmdOk)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Name = "FrmSelezionaListaLavoro"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Seleziona una lista di lavoro"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents cmdAnnulla As System.Windows.Forms.Button
   Friend WithEvents cmdOk As System.Windows.Forms.Button
   Friend WithEvents IdListaUtentiTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdListaUtentiTextBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
