<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSpostaFile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSpostaFile))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtFile = New System.Windows.Forms.TextBox
        Me.cmdSel = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.txtNomeFileRin = New System.Windows.Forms.TextBox
        Me.chkRinomina = New System.Windows.Forms.CheckBox
        Me.cmdOk = New System.Windows.Forms.Button
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(290, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleziona file da spostare"
        '
        'txtFile
        '
        Me.txtFile.Enabled = False
        Me.txtFile.Location = New System.Drawing.Point(14, 39)
        Me.txtFile.Multiline = True
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(521, 99)
        Me.txtFile.TabIndex = 1
        '
        'cmdSel
        '
        Me.cmdSel.Location = New System.Drawing.Point(423, 10)
        Me.cmdSel.Name = "cmdSel"
        Me.cmdSel.Size = New System.Drawing.Size(112, 23)
        Me.cmdSel.TabIndex = 2
        Me.cmdSel.Text = "Seleziona"
        Me.cmdSel.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtNomeFileRin
        '
        Me.txtNomeFileRin.Location = New System.Drawing.Point(14, 142)
        Me.txtNomeFileRin.Name = "txtNomeFileRin"
        Me.txtNomeFileRin.Size = New System.Drawing.Size(239, 20)
        Me.txtNomeFileRin.TabIndex = 4
        '
        'chkRinomina
        '
        Me.chkRinomina.AutoSize = True
        Me.chkRinomina.Checked = True
        Me.chkRinomina.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkRinomina.Location = New System.Drawing.Point(258, 144)
        Me.chkRinomina.Name = "chkRinomina"
        Me.chkRinomina.Size = New System.Drawing.Size(277, 17)
        Me.chkRinomina.TabIndex = 5
        Me.chkRinomina.Text = "Rinomina file (Inserire il nome del file con l'estensione)"
        Me.chkRinomina.UseVisualStyleBackColor = True
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(423, 167)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(112, 27)
        Me.cmdOk.TabIndex = 45
        Me.cmdOk.Text = "Ok"
        Me.cmdOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'FrmSpostaFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(544, 202)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.chkRinomina)
        Me.Controls.Add(Me.txtNomeFileRin)
        Me.Controls.Add(Me.cmdSel)
        Me.Controls.Add(Me.txtFile)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSpostaFile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sposta file"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents txtFile As System.Windows.Forms.TextBox
   Friend WithEvents cmdSel As System.Windows.Forms.Button
   Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
   Friend WithEvents txtNomeFileRin As System.Windows.Forms.TextBox
   Friend WithEvents chkRinomina As System.Windows.Forms.CheckBox
   Friend WithEvents cmdOk As System.Windows.Forms.Button
   Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
End Class
