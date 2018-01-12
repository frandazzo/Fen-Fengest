<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPreferenza
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPreferenza))
      Me.cmdOk = New System.Windows.Forms.Button
      Me.cmdAnnulla = New System.Windows.Forms.Button
      Me.cmdAdd = New System.Windows.Forms.Button
      Me.Label2 = New System.Windows.Forms.Label
      Me.Label3 = New System.Windows.Forms.Label
      Me.Label1 = New System.Windows.Forms.Label
      Me.Label4 = New System.Windows.Forms.Label
      Me.dtpData = New WIN.GUI.UTILITY.UsabilityDtPicker
      Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
      Me.cboSkill = New WIN.GUI.UTILITY.UsabilityCombo
      Me.cboPriorita = New WIN.GUI.UTILITY.UsabilityCombo
      Me.TextBox1 = New WIN.GUI.UTILITY.UsabilityTextBox
      Me.SuspendLayout()
      '
      'cmdOk
      '
      Me.cmdOk.Location = New System.Drawing.Point(56, 291)
      Me.cmdOk.Name = "cmdOk"
      Me.cmdOk.Size = New System.Drawing.Size(101, 27)
      Me.cmdOk.TabIndex = 8
      Me.cmdOk.Text = "&Ok"
      Me.cmdOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.cmdOk.UseVisualStyleBackColor = True
      '
      'cmdAnnulla
      '
      Me.cmdAnnulla.Location = New System.Drawing.Point(265, 290)
      Me.cmdAnnulla.Name = "cmdAnnulla"
      Me.cmdAnnulla.Size = New System.Drawing.Size(85, 27)
      Me.cmdAnnulla.TabIndex = 10
      Me.cmdAnnulla.Text = "&Annulla"
      Me.cmdAnnulla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.cmdAnnulla.UseVisualStyleBackColor = True
      '
      'cmdAdd
      '
      Me.cmdAdd.Location = New System.Drawing.Point(164, 290)
      Me.cmdAdd.Name = "cmdAdd"
      Me.cmdAdd.Size = New System.Drawing.Size(95, 28)
      Me.cmdAdd.TabIndex = 9
      Me.cmdAdd.Text = "A&ggiungi"
      Me.cmdAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.cmdAdd.UseVisualStyleBackColor = True
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Location = New System.Drawing.Point(19, 15)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(30, 13)
      Me.Label2.TabIndex = 0
      Me.Label2.Text = "Data"
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Location = New System.Drawing.Point(23, 48)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(26, 13)
      Me.Label3.TabIndex = 2
      Me.Label3.Text = "Skill"
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Location = New System.Drawing.Point(10, 83)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(39, 13)
      Me.Label1.TabIndex = 4
      Me.Label1.Text = "Priorità"
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.Location = New System.Drawing.Point(16, 113)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(30, 13)
      Me.Label4.TabIndex = 6
      Me.Label4.Text = "Note"
      '
      'dtpData
      '
      Me.dtpData.BackColor = System.Drawing.Color.Transparent
      Me.dtpData.DataValue = New DateTime(2009, 1, 1)
      Me.HelpProvider1.SetHelpString(Me.dtpData, "Data in cui è stata specificata la preferenza da parte dell'utente")
      Me.dtpData.Location = New System.Drawing.Point(52, 7)
      Me.dtpData.Mandatory = True
      Me.dtpData.Name = "dtpData"
      Me.dtpData.OverridedEnable = True
      Me.dtpData.Required = True
      Me.HelpProvider1.SetShowHelp(Me.dtpData, True)
      Me.dtpData.Size = New System.Drawing.Size(116, 25)
      Me.dtpData.TabIndex = 1
      '
      'cboSkill
      '
      Me.cboSkill.BackColor = System.Drawing.Color.Transparent
      Me.cboSkill.ComboBoxStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.HelpProvider1.SetHelpString(Me.cboSkill, "Preferenza del lavoratore o skill offerto")
      Me.cboSkill.Location = New System.Drawing.Point(52, 38)
      Me.cboSkill.Mandatory = True
      Me.cboSkill.Name = "cboSkill"
      Me.cboSkill.OverridedEnable = True
      Me.cboSkill.Required = False
      Me.HelpProvider1.SetShowHelp(Me.cboSkill, True)
      Me.cboSkill.Size = New System.Drawing.Size(275, 29)
      Me.cboSkill.TabIndex = 3
      Me.cboSkill.TextValue = ""
      '
      'cboPriorita
      '
      Me.cboPriorita.BackColor = System.Drawing.Color.Transparent
      Me.cboPriorita.ComboBoxStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.HelpProvider1.SetHelpString(Me.cboPriorita, "Priorità con cui l'utente richiede di lavorare con questo skill")
      Me.cboPriorita.Location = New System.Drawing.Point(52, 73)
      Me.cboPriorita.Mandatory = False
      Me.cboPriorita.Name = "cboPriorita"
      Me.cboPriorita.OverridedEnable = True
      Me.cboPriorita.Required = True
      Me.HelpProvider1.SetShowHelp(Me.cboPriorita, True)
      Me.cboPriorita.Size = New System.Drawing.Size(275, 24)
      Me.cboPriorita.TabIndex = 5
      Me.cboPriorita.TextValue = ""
      '
      'TextBox1
      '
      Me.TextBox1.BackColor = System.Drawing.Color.Transparent
      Me.HelpProvider1.SetHelpString(Me.TextBox1, "Note da apporre allegate all'offerta dell'utente")
      Me.TextBox1.IsMultiline = True
      Me.TextBox1.Location = New System.Drawing.Point(52, 113)
      Me.TextBox1.Mandatory = False
      Me.TextBox1.Name = "TextBox1"
      Me.TextBox1.OverridedEnable = True
      Me.TextBox1.Required = False
      Me.HelpProvider1.SetShowHelp(Me.TextBox1, True)
      Me.TextBox1.Size = New System.Drawing.Size(275, 161)
      Me.TextBox1.TabIndex = 7
      Me.TextBox1.TextHeight = 160
      Me.TextBox1.TextValue = ""
      '
      'FrmPreferenza
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(362, 329)
      Me.Controls.Add(Me.TextBox1)
      Me.Controls.Add(Me.cboPriorita)
      Me.Controls.Add(Me.cboSkill)
      Me.Controls.Add(Me.dtpData)
      Me.Controls.Add(Me.Label4)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.Label3)
      Me.Controls.Add(Me.cmdOk)
      Me.Controls.Add(Me.cmdAnnulla)
      Me.Controls.Add(Me.cmdAdd)
      Me.Controls.Add(Me.Label2)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "FrmPreferenza"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Preferenza"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents cmdOk As System.Windows.Forms.Button
   Friend WithEvents cmdAnnulla As System.Windows.Forms.Button
   Friend WithEvents cmdAdd As System.Windows.Forms.Button
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents dtpData As WIN.GUI.UTILITY.UsabilityDtPicker
   Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
   Friend WithEvents cboSkill As WIN.GUI.UTILITY.UsabilityCombo
   Friend WithEvents cboPriorita As WIN.GUI.UTILITY.UsabilityCombo
   Friend WithEvents TextBox1 As WIN.GUI.UTILITY.UsabilityTextBox
End Class
