<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTransioniDeleghe
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
      Me.Label1 = New System.Windows.Forms.Label
      Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
      Me.lblPath = New System.Windows.Forms.Label
      Me.Button1 = New System.Windows.Forms.Button
      Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
      Me.cmdOk = New System.Windows.Forms.Button
      Me.cmdAnnulla = New System.Windows.Forms.Button
      Me.SuspendLayout()
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(27, 19)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(83, 13)
      Me.Label1.TabIndex = 0
      Me.Label1.Text = "Data transizione"
      '
      'DateTimePicker1
      '
      Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.DateTimePicker1.Location = New System.Drawing.Point(128, 12)
      Me.DateTimePicker1.Name = "DateTimePicker1"
      Me.DateTimePicker1.Size = New System.Drawing.Size(114, 20)
      Me.DateTimePicker1.TabIndex = 1
      '
      'lblPath
      '
      Me.lblPath.AutoSize = True
      Me.lblPath.ForeColor = System.Drawing.SystemColors.ActiveCaption
      Me.lblPath.Location = New System.Drawing.Point(27, 48)
      Me.lblPath.MaximumSize = New System.Drawing.Size(280, 0)
      Me.lblPath.Name = "lblPath"
      Me.lblPath.Size = New System.Drawing.Size(143, 13)
      Me.lblPath.TabIndex = 2
      Me.lblPath.Text = "Nessun percorso selezionato"
      '
      'Button1
      '
      Me.Button1.Location = New System.Drawing.Point(30, 102)
      Me.Button1.Name = "Button1"
      Me.Button1.Size = New System.Drawing.Size(189, 28)
      Me.Button1.TabIndex = 3
      Me.Button1.Text = "Seleziona percorso file di output"
      Me.Button1.UseVisualStyleBackColor = True
      '
      'cmdOk
      '
      Me.cmdOk.Location = New System.Drawing.Point(169, 151)
      Me.cmdOk.Name = "cmdOk"
      Me.cmdOk.Size = New System.Drawing.Size(88, 27)
      Me.cmdOk.TabIndex = 31
      Me.cmdOk.Text = "Ok"
      Me.cmdOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.cmdOk.UseVisualStyleBackColor = True
      '
      'cmdAnnulla
      '
      Me.cmdAnnulla.Location = New System.Drawing.Point(263, 151)
      Me.cmdAnnulla.Name = "cmdAnnulla"
      Me.cmdAnnulla.Size = New System.Drawing.Size(85, 27)
      Me.cmdAnnulla.TabIndex = 30
      Me.cmdAnnulla.Text = "Annulla"
      Me.cmdAnnulla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.cmdAnnulla.UseVisualStyleBackColor = True
      '
      'FrmTransioniDeleghe
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(360, 190)
      Me.Controls.Add(Me.cmdOk)
      Me.Controls.Add(Me.cmdAnnulla)
      Me.Controls.Add(Me.Button1)
      Me.Controls.Add(Me.lblPath)
      Me.Controls.Add(Me.DateTimePicker1)
      Me.Controls.Add(Me.Label1)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Name = "FrmTransioniDeleghe"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Elaborazioni massive deleghe"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
   Friend WithEvents lblPath As System.Windows.Forms.Label
   Friend WithEvents Button1 As System.Windows.Forms.Button
   Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
   Friend WithEvents cmdOk As System.Windows.Forms.Button
   Friend WithEvents cmdAnnulla As System.Windows.Forms.Button
End Class
