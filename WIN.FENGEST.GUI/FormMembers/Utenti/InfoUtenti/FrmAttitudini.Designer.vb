<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAttitudine
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAttitudine))
      Me.cmdOk = New System.Windows.Forms.Button
      Me.cmdAnnulla = New System.Windows.Forms.Button
      Me.cmdAdd = New System.Windows.Forms.Button
      Me.Label1 = New System.Windows.Forms.Label
      Me.Label3 = New System.Windows.Forms.Label
      Me.Label2 = New System.Windows.Forms.Label
      Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
      Me.cboSkill = New WIN.GUI.UTILITY.UsabilityCombo
      Me.cboLivello = New WIN.GUI.UTILITY.UsabilityCombo
      Me.TextBox1 = New WIN.GUI.UTILITY.UsabilityTextBox
      Me.SuspendLayout()
      '
      'cmdOk
      '
      Me.cmdOk.Location = New System.Drawing.Point(101, 251)
      Me.cmdOk.Name = "cmdOk"
      Me.cmdOk.Size = New System.Drawing.Size(101, 27)
      Me.cmdOk.TabIndex = 6
      Me.cmdOk.Text = "&Ok"
      Me.cmdOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.cmdOk.UseVisualStyleBackColor = True
      '
      'cmdAnnulla
      '
      Me.cmdAnnulla.Location = New System.Drawing.Point(309, 251)
      Me.cmdAnnulla.Name = "cmdAnnulla"
      Me.cmdAnnulla.Size = New System.Drawing.Size(85, 27)
      Me.cmdAnnulla.TabIndex = 8
      Me.cmdAnnulla.Text = "&Annulla"
      Me.cmdAnnulla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.cmdAnnulla.UseVisualStyleBackColor = True
      '
      'cmdAdd
      '
      Me.HelpProvider1.SetHelpString(Me.cmdAdd, "Funzione che permette di aggiungere la nuova skill per l'utente")
      Me.cmdAdd.Location = New System.Drawing.Point(208, 250)
      Me.cmdAdd.Name = "cmdAdd"
      Me.HelpProvider1.SetShowHelp(Me.cmdAdd, True)
      Me.cmdAdd.Size = New System.Drawing.Size(95, 28)
      Me.cmdAdd.TabIndex = 7
      Me.cmdAdd.Text = "A&ggiungi"
      Me.cmdAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.cmdAdd.UseVisualStyleBackColor = True
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Location = New System.Drawing.Point(25, 45)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(37, 13)
      Me.Label1.TabIndex = 2
      Me.Label1.Text = "Livello"
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Location = New System.Drawing.Point(36, 16)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(26, 13)
      Me.Label3.TabIndex = 0
      Me.Label3.Text = "Skill"
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Location = New System.Drawing.Point(28, 73)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(30, 13)
      Me.Label2.TabIndex = 4
      Me.Label2.Text = "Note"
      '
      'cboSkill
      '
      Me.cboSkill.BackColor = System.Drawing.Color.Transparent
      Me.cboSkill.ComboBoxStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.HelpProvider1.SetHelpString(Me.cboSkill, "Lavoro effettuato in precedenza dal lavoratore")
      Me.cboSkill.Location = New System.Drawing.Point(67, 7)
      Me.cboSkill.Mandatory = True
      Me.cboSkill.Name = "cboSkill"
      Me.cboSkill.OverridedEnable = True
      Me.cboSkill.Required = False
      Me.HelpProvider1.SetShowHelp(Me.cboSkill, True)
      Me.cboSkill.Size = New System.Drawing.Size(298, 28)
      Me.cboSkill.TabIndex = 1
      Me.cboSkill.TextValue = ""
      '
      'cboLivello
      '
      Me.cboLivello.BackColor = System.Drawing.Color.Transparent
      Me.cboLivello.ComboBoxStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.HelpProvider1.SetHelpString(Me.cboLivello, "Livello di competenza professionale offerto dal lavoratore. I livelli di competen" & _
              "ze professionale (livello di skill) possono essere impostate da Menu->Strumenti-" & _
              ">Setup->Utenti->Livello Skill")
      Me.cboLivello.Location = New System.Drawing.Point(66, 41)
      Me.cboLivello.Mandatory = False
      Me.cboLivello.Name = "cboLivello"
      Me.cboLivello.OverridedEnable = True
      Me.cboLivello.Required = True
      Me.HelpProvider1.SetShowHelp(Me.cboLivello, True)
      Me.cboLivello.Size = New System.Drawing.Size(298, 26)
      Me.cboLivello.TabIndex = 3
      Me.cboLivello.TextValue = ""
      '
      'TextBox1
      '
      Me.TextBox1.BackColor = System.Drawing.Color.Transparent
      Me.HelpProvider1.SetHelpString(Me.TextBox1, "Eventuali note sul know how o sulle predisposizioni o attitudini particolari del " & _
              "lavoratore.")
      Me.TextBox1.IsMultiline = True
      Me.TextBox1.Location = New System.Drawing.Point(66, 75)
      Me.TextBox1.Mandatory = False
      Me.TextBox1.Name = "TextBox1"
      Me.TextBox1.OverridedEnable = True
      Me.TextBox1.Required = False
      Me.HelpProvider1.SetShowHelp(Me.TextBox1, True)
      Me.TextBox1.Size = New System.Drawing.Size(298, 169)
      Me.TextBox1.TabIndex = 5
      Me.TextBox1.TextHeight = 160
      Me.TextBox1.TextValue = ""
      '
      'FrmAttitudine
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(406, 288)
      Me.Controls.Add(Me.TextBox1)
      Me.Controls.Add(Me.cboLivello)
      Me.Controls.Add(Me.cboSkill)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.Label3)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.cmdOk)
      Me.Controls.Add(Me.cmdAnnulla)
      Me.Controls.Add(Me.cmdAdd)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "FrmAttitudine"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Know how"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents cmdOk As System.Windows.Forms.Button
   Friend WithEvents cmdAnnulla As System.Windows.Forms.Button
   Friend WithEvents cmdAdd As System.Windows.Forms.Button
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
   Friend WithEvents cboSkill As WIN.GUI.UTILITY.UsabilityCombo
   Friend WithEvents cboLivello As WIN.GUI.UTILITY.UsabilityCombo
   Friend WithEvents TextBox1 As WIN.GUI.UTILITY.UsabilityTextBox
End Class
