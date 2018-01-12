<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDatiFiscali
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
      Me.txtData = New System.Windows.Forms.TextBox
      Me.txtProvincia = New System.Windows.Forms.TextBox
      Me.Label2 = New System.Windows.Forms.Label
      Me.txtComune = New System.Windows.Forms.TextBox
      Me.Label3 = New System.Windows.Forms.Label
      Me.Label4 = New System.Windows.Forms.Label
      Me.txtSesso = New System.Windows.Forms.TextBox
      Me.txtNazione = New System.Windows.Forms.TextBox
      Me.Label5 = New System.Windows.Forms.Label
      Me.Label6 = New System.Windows.Forms.Label
      Me.cmdOK = New System.Windows.Forms.Button
      Me.cmdAnnulla = New System.Windows.Forms.Button
      Me.SuspendLayout()
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(12, 43)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(61, 13)
      Me.Label1.TabIndex = 2
      Me.Label1.Text = "Data Nasc."
      '
      'txtData
      '
      Me.txtData.Location = New System.Drawing.Point(86, 36)
      Me.txtData.Name = "txtData"
      Me.txtData.Size = New System.Drawing.Size(117, 20)
      Me.txtData.TabIndex = 3
      '
      'txtProvincia
      '
      Me.txtProvincia.Location = New System.Drawing.Point(86, 97)
      Me.txtProvincia.Name = "txtProvincia"
      Me.txtProvincia.Size = New System.Drawing.Size(212, 20)
      Me.txtProvincia.TabIndex = 7
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Location = New System.Drawing.Point(19, 104)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(51, 13)
      Me.Label2.TabIndex = 6
      Me.Label2.Text = "Provincia"
      '
      'txtComune
      '
      Me.txtComune.Location = New System.Drawing.Point(86, 124)
      Me.txtComune.Name = "txtComune"
      Me.txtComune.Size = New System.Drawing.Size(212, 20)
      Me.txtComune.TabIndex = 9
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Location = New System.Drawing.Point(24, 131)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(46, 13)
      Me.Label3.TabIndex = 8
      Me.Label3.Text = "Comune"
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.Location = New System.Drawing.Point(34, 17)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(36, 13)
      Me.Label4.TabIndex = 0
      Me.Label4.Text = "Sesso"
      '
      'txtSesso
      '
      Me.txtSesso.Location = New System.Drawing.Point(86, 10)
      Me.txtSesso.Name = "txtSesso"
      Me.txtSesso.Size = New System.Drawing.Size(117, 20)
      Me.txtSesso.TabIndex = 1
      '
      'txtNazione
      '
      Me.txtNazione.Location = New System.Drawing.Point(86, 67)
      Me.txtNazione.Name = "txtNazione"
      Me.txtNazione.Size = New System.Drawing.Size(212, 20)
      Me.txtNazione.TabIndex = 5
      '
      'Label5
      '
      Me.Label5.AutoSize = True
      Me.Label5.Location = New System.Drawing.Point(11, 74)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(59, 13)
      Me.Label5.TabIndex = 4
      Me.Label5.Text = "Nazionalità"
      '
      'Label6
      '
      Me.Label6.AutoSize = True
      Me.Label6.ForeColor = System.Drawing.Color.DarkGray
      Me.Label6.Location = New System.Drawing.Point(11, 158)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(295, 13)
      Me.Label6.TabIndex = 10
      Me.Label6.Text = "________________________________________________"
      '
      'cmdOK
      '
      Me.cmdOK.Location = New System.Drawing.Point(156, 180)
      Me.cmdOK.Name = "cmdOK"
      Me.cmdOK.Size = New System.Drawing.Size(72, 27)
      Me.cmdOK.TabIndex = 11
      Me.cmdOK.Text = "&OK"
      Me.cmdOK.UseVisualStyleBackColor = True
      '
      'cmdAnnulla
      '
      Me.cmdAnnulla.Location = New System.Drawing.Point(234, 180)
      Me.cmdAnnulla.Name = "cmdAnnulla"
      Me.cmdAnnulla.Size = New System.Drawing.Size(72, 27)
      Me.cmdAnnulla.TabIndex = 12
      Me.cmdAnnulla.Text = "&Annulla"
      Me.cmdAnnulla.UseVisualStyleBackColor = True
      '
      'FrmDatiFiscali
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(327, 217)
      Me.Controls.Add(Me.cmdAnnulla)
      Me.Controls.Add(Me.cmdOK)
      Me.Controls.Add(Me.Label6)
      Me.Controls.Add(Me.txtNazione)
      Me.Controls.Add(Me.Label5)
      Me.Controls.Add(Me.txtComune)
      Me.Controls.Add(Me.Label3)
      Me.Controls.Add(Me.txtProvincia)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.txtSesso)
      Me.Controls.Add(Me.Label4)
      Me.Controls.Add(Me.txtData)
      Me.Controls.Add(Me.Label1)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Name = "FrmDatiFiscali"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Dati fiscali "
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents txtData As System.Windows.Forms.TextBox
   Friend WithEvents txtProvincia As System.Windows.Forms.TextBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents txtComune As System.Windows.Forms.TextBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents txtSesso As System.Windows.Forms.TextBox
   Friend WithEvents txtNazione As System.Windows.Forms.TextBox
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents cmdOK As System.Windows.Forms.Button
   Friend WithEvents cmdAnnulla As System.Windows.Forms.Button
End Class
