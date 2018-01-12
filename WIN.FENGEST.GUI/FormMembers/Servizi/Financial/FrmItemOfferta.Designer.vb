<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmItemOfferta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmItemOfferta))
        Me.cboSkill = New System.Windows.Forms.ComboBox
        Me.cboLevel = New System.Windows.Forms.ComboBox
        Me.txtNum = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmdOk = New System.Windows.Forms.Button
        Me.cmdAnnulla = New System.Windows.Forms.Button
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
        Me.SuspendLayout()
        '
        'cboSkill
        '
        Me.cboSkill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSkill.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboSkill, "Competenza professionale richiesta. Le competenze professionali(skill) possono es" & _
                "sere impostate da Menu->Strumenti->Setup->Utenti->Skill")
        Me.cboSkill.Location = New System.Drawing.Point(82, 12)
        Me.cboSkill.Name = "cboSkill"
        Me.HelpProvider1.SetShowHelp(Me.cboSkill, True)
        Me.cboSkill.Size = New System.Drawing.Size(232, 21)
        Me.cboSkill.TabIndex = 0
        '
        'cboLevel
        '
        Me.cboLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLevel.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboLevel, "Livello di competenza professionale richiesta. I livelli di competenze profession" & _
                "ale (livello di skill) possono essere impostate da Menu->Strumenti->Setup->Utent" & _
                "i->Livello Skill")
        Me.cboLevel.Location = New System.Drawing.Point(82, 41)
        Me.cboLevel.Name = "cboLevel"
        Me.HelpProvider1.SetShowHelp(Me.cboLevel, True)
        Me.cboLevel.Size = New System.Drawing.Size(232, 21)
        Me.cboLevel.TabIndex = 1
        '
        'txtNum
        '
        Me.HelpProvider1.SetHelpString(Me.txtNum, "Numero di posti ricercati.")
        Me.txtNum.Location = New System.Drawing.Point(82, 72)
        Me.txtNum.Name = "txtNum"
        Me.HelpProvider1.SetShowHelp(Me.txtNum, True)
        Me.txtNum.Size = New System.Drawing.Size(232, 20)
        Me.txtNum.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(9, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Numero posti"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(42, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Livello"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(53, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Skill"
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(82, 98)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(70, 27)
        Me.cmdOk.TabIndex = 27
        Me.cmdOk.Text = "Ok"
        Me.cmdOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'cmdAnnulla
        '
        Me.cmdAnnulla.Location = New System.Drawing.Point(245, 99)
        Me.cmdAnnulla.Name = "cmdAnnulla"
        Me.cmdAnnulla.Size = New System.Drawing.Size(69, 27)
        Me.cmdAnnulla.TabIndex = 29
        Me.cmdAnnulla.Text = "Annulla"
        Me.cmdAnnulla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAnnulla.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.HelpProvider1.SetHelpString(Me.cmdAdd, "Funzione che permette di aggiungere la nuova skill ricercata dall'azienda")
        Me.cmdAdd.Location = New System.Drawing.Point(157, 98)
        Me.cmdAdd.Name = "cmdAdd"
        Me.HelpProvider1.SetShowHelp(Me.cmdAdd, True)
        Me.cmdAdd.Size = New System.Drawing.Size(83, 28)
        Me.cmdAdd.TabIndex = 28
        Me.cmdAdd.Text = "Aggiungi"
        Me.cmdAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'FrmItemOfferta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(321, 132)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmdAnnulla)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.cboLevel)
        Me.Controls.Add(Me.cboSkill)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmItemOfferta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Posizione domanda di lavoro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Friend WithEvents cboSkill As System.Windows.Forms.ComboBox
   Friend WithEvents cboLevel As System.Windows.Forms.ComboBox
   Friend WithEvents txtNum As System.Windows.Forms.TextBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents cmdOk As System.Windows.Forms.Button
   Friend WithEvents cmdAnnulla As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
