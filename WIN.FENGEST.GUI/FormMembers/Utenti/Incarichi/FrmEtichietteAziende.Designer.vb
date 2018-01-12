<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEtichietteAziende
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkOnlyAddressOK = New System.Windows.Forms.CheckBox()
        Me.optLabelWord = New System.Windows.Forms.RadioButton()
        Me.Word = New System.Windows.Forms.PictureBox()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdAnnulla = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Word, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkOnlyAddressOK)
        Me.GroupBox2.Controls.Add(Me.optLabelWord)
        Me.GroupBox2.Controls.Add(Me.Word)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(270, 103)
        Me.GroupBox2.TabIndex = 68
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Esporta su..."
        '
        'chkOnlyAddressOK
        '
        Me.chkOnlyAddressOK.AutoSize = True
        Me.chkOnlyAddressOK.Location = New System.Drawing.Point(26, 72)
        Me.chkOnlyAddressOK.Name = "chkOnlyAddressOK"
        Me.chkOnlyAddressOK.Size = New System.Drawing.Size(198, 17)
        Me.chkOnlyAddressOK.TabIndex = 4
        Me.chkOnlyAddressOK.Text = "Esporta utenti con indirizzo completo"
        Me.chkOnlyAddressOK.UseVisualStyleBackColor = True
        '
        'optLabelWord
        '
        Me.optLabelWord.AutoSize = True
        Me.optLabelWord.Checked = True
        Me.optLabelWord.Location = New System.Drawing.Point(78, 32)
        Me.optLabelWord.Name = "optLabelWord"
        Me.optLabelWord.Size = New System.Drawing.Size(110, 17)
        Me.optLabelWord.TabIndex = 3
        Me.optLabelWord.TabStop = True
        Me.optLabelWord.Text = "Etichette su Word"
        Me.optLabelWord.UseVisualStyleBackColor = True
        '
        'Word
        '
        Me.Word.BackgroundImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.Microsoft_Word32x32
        Me.Word.Location = New System.Drawing.Point(26, 24)
        Me.Word.Name = "Word"
        Me.Word.Size = New System.Drawing.Size(32, 32)
        Me.Word.TabIndex = 1
        Me.Word.TabStop = False
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(126, 134)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(74, 27)
        Me.cmdOk.TabIndex = 70
        Me.cmdOk.Text = "&Esporta"
        Me.cmdOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'cmdAnnulla
        '
        Me.cmdAnnulla.Location = New System.Drawing.Point(206, 134)
        Me.cmdAnnulla.Name = "cmdAnnulla"
        Me.cmdAnnulla.Size = New System.Drawing.Size(74, 27)
        Me.cmdAnnulla.TabIndex = 69
        Me.cmdAnnulla.Text = "&Chiudi"
        Me.cmdAnnulla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAnnulla.UseVisualStyleBackColor = True
        '
        'FrmEtichietteAziende
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 173)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmdAnnulla)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmEtichietteAziende"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Esporta etichiette aziende"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Word, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkOnlyAddressOK As System.Windows.Forms.CheckBox
    Friend WithEvents optLabelWord As System.Windows.Forms.RadioButton
    Friend WithEvents Word As System.Windows.Forms.PictureBox
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdAnnulla As System.Windows.Forms.Button
End Class
