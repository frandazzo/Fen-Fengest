<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExportLista
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmExportLista))
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdAnnulla = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optExportAsLabel = New System.Windows.Forms.RadioButton()
        Me.optExportAll = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkOnlyAddressOK = New System.Windows.Forms.CheckBox()
        Me.optLabelWord = New System.Windows.Forms.RadioButton()
        Me.optLabelExcel = New System.Windows.Forms.RadioButton()
        Me.Word = New System.Windows.Forms.PictureBox()
        Me.Excel = New System.Windows.Forms.PictureBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Word, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Excel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(126, 273)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(74, 27)
        Me.cmdOk.TabIndex = 65
        Me.cmdOk.Text = "&Esporta"
        Me.cmdOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'cmdAnnulla
        '
        Me.cmdAnnulla.Location = New System.Drawing.Point(206, 273)
        Me.cmdAnnulla.Name = "cmdAnnulla"
        Me.cmdAnnulla.Size = New System.Drawing.Size(74, 27)
        Me.cmdAnnulla.TabIndex = 64
        Me.cmdAnnulla.Text = "&Chiudi"
        Me.cmdAnnulla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAnnulla.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optExportAsLabel)
        Me.GroupBox1.Controls.Add(Me.optExportAll)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(268, 97)
        Me.GroupBox1.TabIndex = 66
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo esportazione"
        '
        'optExportAsLabel
        '
        Me.optExportAsLabel.AutoSize = True
        Me.optExportAsLabel.Location = New System.Drawing.Point(20, 66)
        Me.optExportAsLabel.Name = "optExportAsLabel"
        Me.optExportAsLabel.Size = New System.Drawing.Size(134, 17)
        Me.optExportAsLabel.TabIndex = 5
        Me.optExportAsLabel.Text = "Esporta come etichette"
        Me.optExportAsLabel.UseVisualStyleBackColor = True
        '
        'optExportAll
        '
        Me.optExportAll.AutoSize = True
        Me.optExportAll.Checked = True
        Me.optExportAll.Location = New System.Drawing.Point(20, 30)
        Me.optExportAll.Name = "optExportAll"
        Me.optExportAll.Size = New System.Drawing.Size(154, 17)
        Me.optExportAll.TabIndex = 4
        Me.optExportAll.TabStop = True
        Me.optExportAll.Text = "Esporta intera lista su Excel"
        Me.optExportAll.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkOnlyAddressOK)
        Me.GroupBox2.Controls.Add(Me.optLabelWord)
        Me.GroupBox2.Controls.Add(Me.optLabelExcel)
        Me.GroupBox2.Controls.Add(Me.Word)
        Me.GroupBox2.Controls.Add(Me.Excel)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Location = New System.Drawing.Point(10, 116)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(270, 151)
        Me.GroupBox2.TabIndex = 67
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Esporta su..."
        '
        'chkOnlyAddressOK
        '
        Me.chkOnlyAddressOK.AutoSize = True
        Me.chkOnlyAddressOK.Location = New System.Drawing.Point(22, 117)
        Me.chkOnlyAddressOK.Name = "chkOnlyAddressOK"
        Me.chkOnlyAddressOK.Size = New System.Drawing.Size(198, 17)
        Me.chkOnlyAddressOK.TabIndex = 4
        Me.chkOnlyAddressOK.Text = "Esporta utenti con indirizzo completo"
        Me.chkOnlyAddressOK.UseVisualStyleBackColor = True
        '
        'optLabelWord
        '
        Me.optLabelWord.AutoSize = True
        Me.optLabelWord.Location = New System.Drawing.Point(74, 77)
        Me.optLabelWord.Name = "optLabelWord"
        Me.optLabelWord.Size = New System.Drawing.Size(110, 17)
        Me.optLabelWord.TabIndex = 3
        Me.optLabelWord.Text = "Etichette su Word"
        Me.optLabelWord.UseVisualStyleBackColor = True
        '
        'optLabelExcel
        '
        Me.optLabelExcel.AutoSize = True
        Me.optLabelExcel.Checked = True
        Me.optLabelExcel.Location = New System.Drawing.Point(74, 34)
        Me.optLabelExcel.Name = "optLabelExcel"
        Me.optLabelExcel.Size = New System.Drawing.Size(110, 17)
        Me.optLabelExcel.TabIndex = 2
        Me.optLabelExcel.TabStop = True
        Me.optLabelExcel.Text = "Etichette su Excel"
        Me.optLabelExcel.UseVisualStyleBackColor = True
        '
        'Word
        '
        Me.Word.BackgroundImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.Microsoft_Word32x32
        Me.Word.Location = New System.Drawing.Point(22, 69)
        Me.Word.Name = "Word"
        Me.Word.Size = New System.Drawing.Size(32, 32)
        Me.Word.TabIndex = 1
        Me.Word.TabStop = False
        '
        'Excel
        '
        Me.Excel.BackgroundImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.Microsoft_Excel32x32
        Me.Excel.Location = New System.Drawing.Point(22, 24)
        Me.Excel.Name = "Excel"
        Me.Excel.Size = New System.Drawing.Size(32, 32)
        Me.Excel.TabIndex = 0
        Me.Excel.TabStop = False
        '
        'FrmExportLista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 312)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmdAnnulla)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmExportLista"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Esporta lista di lavoro"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Word, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Excel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdAnnulla As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Excel As System.Windows.Forms.PictureBox
    Friend WithEvents Word As System.Windows.Forms.PictureBox
    Friend WithEvents optExportAsLabel As System.Windows.Forms.RadioButton
    Friend WithEvents optExportAll As System.Windows.Forms.RadioButton
    Friend WithEvents optLabelWord As System.Windows.Forms.RadioButton
    Friend WithEvents optLabelExcel As System.Windows.Forms.RadioButton
    Friend WithEvents chkOnlyAddressOK As System.Windows.Forms.CheckBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
