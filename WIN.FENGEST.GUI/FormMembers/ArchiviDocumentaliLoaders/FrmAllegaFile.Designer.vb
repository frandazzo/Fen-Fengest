<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAllegaFile
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
        Me.cmdSel = New System.Windows.Forms.Button()
        Me.txtFile = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.optMove = New System.Windows.Forms.RadioButton()
        Me.optCopy = New System.Windows.Forms.RadioButton()
        Me.optNoAction = New System.Windows.Forms.RadioButton()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdAnnulla = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.SuspendLayout()
        '
        'cmdSel
        '
        Me.HelpProvider1.SetHelpString(Me.cmdSel, "Funzione che permette di allegare un nuovo file.")
        Me.cmdSel.Location = New System.Drawing.Point(302, 21)
        Me.cmdSel.Name = "cmdSel"
        Me.HelpProvider1.SetShowHelp(Me.cmdSel, True)
        Me.cmdSel.Size = New System.Drawing.Size(62, 23)
        Me.cmdSel.TabIndex = 5
        Me.cmdSel.Text = "Seleziona"
        Me.cmdSel.UseVisualStyleBackColor = True
        '
        'txtFile
        '
        Me.txtFile.Enabled = False
        Me.txtFile.Location = New System.Drawing.Point(38, 23)
        Me.txtFile.Multiline = True
        Me.txtFile.Name = "txtFile"
        Me.txtFile.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtFile.Size = New System.Drawing.Size(258, 45)
        Me.txtFile.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "File"
        '
        'optMove
        '
        Me.optMove.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.optMove, "Spuntare questa casella se si vuole spostare il file da allegare nella cartella d" & _
        "i default dell'utente")
        Me.optMove.Location = New System.Drawing.Point(12, 171)
        Me.optMove.Name = "optMove"
        Me.HelpProvider1.SetShowHelp(Me.optMove, True)
        Me.optMove.Size = New System.Drawing.Size(155, 17)
        Me.optMove.TabIndex = 6
        Me.optMove.Text = "Sposta nella cartella default"
        Me.optMove.UseVisualStyleBackColor = True
        '
        'optCopy
        '
        Me.optCopy.AutoSize = True
        Me.optCopy.Checked = True
        Me.HelpProvider1.SetHelpString(Me.optCopy, "puntare questa casella se si vuole copiare il file da allegare nella cartella di " & _
        "default dell'utente")
        Me.optCopy.Location = New System.Drawing.Point(12, 194)
        Me.optCopy.Name = "optCopy"
        Me.HelpProvider1.SetShowHelp(Me.optCopy, True)
        Me.optCopy.Size = New System.Drawing.Size(149, 17)
        Me.optCopy.TabIndex = 7
        Me.optCopy.TabStop = True
        Me.optCopy.Text = "Copia nella cartella default"
        Me.optCopy.UseVisualStyleBackColor = True
        '
        'optNoAction
        '
        Me.optNoAction.AutoSize = True
        Me.optNoAction.Location = New System.Drawing.Point(12, 148)
        Me.optNoAction.Name = "optNoAction"
        Me.optNoAction.Size = New System.Drawing.Size(258, 17)
        Me.optNoAction.TabIndex = 8
        Me.optNoAction.Text = "Allega senza eseguire nessuna operazione sul file"
        Me.optNoAction.UseVisualStyleBackColor = True
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(234, 239)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(62, 22)
        Me.cmdOk.TabIndex = 46
        Me.cmdOk.Text = "Ok"
        Me.cmdOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.LinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LinkLabel1.Location = New System.Drawing.Point(37, 95)
        Me.LinkLabel1.MaximumSize = New System.Drawing.Size(258, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(10, 13)
        Me.LinkLabel1.TabIndex = 47
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Cartella default"
        '
        'cmdAnnulla
        '
        Me.cmdAnnulla.Location = New System.Drawing.Point(310, 239)
        Me.cmdAnnulla.Name = "cmdAnnulla"
        Me.cmdAnnulla.Size = New System.Drawing.Size(62, 22)
        Me.cmdAnnulla.TabIndex = 49
        Me.cmdAnnulla.Text = "Annulla"
        Me.cmdAnnulla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAnnulla.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.CheckBox1, "Spuntare questa casella se si vuole,nel caso esista già un file con lo stesso nom" & _
        "e, sovrascrivere quello già esistente con quello che si va ad allegare")
        Me.CheckBox1.Location = New System.Drawing.Point(188, 172)
        Me.CheckBox1.Name = "CheckBox1"
        Me.HelpProvider1.SetShowHelp(Me.CheckBox1, True)
        Me.CheckBox1.Size = New System.Drawing.Size(135, 17)
        Me.CheckBox1.TabIndex = 50
        Me.CheckBox1.Text = "Sovrascrivi file esistenti"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'FrmAllegaFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 271)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.cmdAnnulla)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.optNoAction)
        Me.Controls.Add(Me.optCopy)
        Me.Controls.Add(Me.optMove)
        Me.Controls.Add(Me.cmdSel)
        Me.Controls.Add(Me.txtFile)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmAllegaFile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Allega file"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Friend WithEvents cmdSel As System.Windows.Forms.Button
   Friend WithEvents txtFile As System.Windows.Forms.TextBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents optMove As System.Windows.Forms.RadioButton
   Friend WithEvents optCopy As System.Windows.Forms.RadioButton
   Friend WithEvents optNoAction As System.Windows.Forms.RadioButton
   Friend WithEvents cmdOk As System.Windows.Forms.Button
   Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
   Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
   Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents cmdAnnulla As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
