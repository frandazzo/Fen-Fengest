<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInfos
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInfos))
      Me.Label1 = New System.Windows.Forms.Label
      Me.Label3 = New System.Windows.Forms.Label
      Me.cmdOk = New System.Windows.Forms.Button
      Me.cmdAnnulla = New System.Windows.Forms.Button
      Me.cmdAdd = New System.Windows.Forms.Button
      Me.Label2 = New System.Windows.Forms.Label
      Me.IdAziendaTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdAziendaTextBox
      Me.Label4 = New System.Windows.Forms.Label
      Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
      Me.dtpData = New WIN.GUI.UTILITY.UsabilityDtPicker
      Me.cboEnti = New WIN.GUI.UTILITY.UsabilityCombo
      Me.cboIscritto = New WIN.GUI.UTILITY.UsabilityCombo
      Me.txtLivello = New WIN.GUI.UTILITY.UsabilityTextBox
      Me.Label5 = New System.Windows.Forms.Label
      Me.SuspendLayout()
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Location = New System.Drawing.Point(41, 47)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(29, 13)
      Me.Label1.TabIndex = 2
      Me.Label1.Text = "Ente"
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Location = New System.Drawing.Point(27, 79)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(45, 13)
      Me.Label3.TabIndex = 4
      Me.Label3.Text = "Azienda"
      '
      'cmdOk
      '
      Me.cmdOk.Location = New System.Drawing.Point(156, 189)
      Me.cmdOk.Name = "cmdOk"
      Me.cmdOk.Size = New System.Drawing.Size(68, 25)
      Me.cmdOk.TabIndex = 10
      Me.cmdOk.Text = "&Ok"
      Me.cmdOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.cmdOk.UseVisualStyleBackColor = True
      '
      'cmdAnnulla
      '
      Me.cmdAnnulla.Location = New System.Drawing.Point(307, 189)
      Me.cmdAnnulla.Name = "cmdAnnulla"
      Me.cmdAnnulla.Size = New System.Drawing.Size(66, 25)
      Me.cmdAnnulla.TabIndex = 12
      Me.cmdAnnulla.Text = "&Annulla"
      Me.cmdAnnulla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.cmdAnnulla.UseVisualStyleBackColor = True
      '
      'cmdAdd
      '
      Me.cmdAdd.Location = New System.Drawing.Point(230, 188)
      Me.cmdAdd.Name = "cmdAdd"
      Me.cmdAdd.Size = New System.Drawing.Size(71, 26)
      Me.cmdAdd.TabIndex = 11
      Me.cmdAdd.Text = "A&ggiungi"
      Me.cmdAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.cmdAdd.UseVisualStyleBackColor = True
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Location = New System.Drawing.Point(3, 19)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(74, 13)
      Me.Label2.TabIndex = 0
      Me.Label2.Text = "Non iscritto al "
      '
      'IdAziendaTextBox1
      '
      Me.IdAziendaTextBox1.BackColor = System.Drawing.Color.Transparent
      Me.IdAziendaTextBox1.DescriptionOfText = ""
      Me.IdAziendaTextBox1.DescriptionTextWidth = 190
      Me.IdAziendaTextBox1.DescriptionTextXValue = 92
      Me.IdAziendaTextBox1.EnableSerchTextBox = True
      Me.HelpProvider1.SetHelpString(Me.IdAziendaTextBox1, "Identificativo dell'azienda d'impiego del lavoratore libero")
      Me.IdAziendaTextBox1.IsDescriptionVisible = True
      Me.IdAziendaTextBox1.Location = New System.Drawing.Point(83, 73)
      Me.IdAziendaTextBox1.Mandatory = True
      Me.IdAziendaTextBox1.Margin = New System.Windows.Forms.Padding(0)
      Me.IdAziendaTextBox1.Name = "IdAziendaTextBox1"
      Me.HelpProvider1.SetShowHelp(Me.IdAziendaTextBox1, True)
      Me.IdAziendaTextBox1.Size = New System.Drawing.Size(290, 23)
      Me.IdAziendaTextBox1.TabIndex = 5
      Me.IdAziendaTextBox1.TextValue = ""
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Location = New System.Drawing.Point(34, 109)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(37, 13)
      Me.Label4.TabIndex = 6
      Me.Label4.Text = "Livello"
      '
      'dtpData
      '
      Me.dtpData.BackColor = System.Drawing.Color.Transparent
      Me.dtpData.DataValue = New DateTime(2009, 1, 1)
      Me.HelpProvider1.SetHelpString(Me.dtpData, "Data alla quale il lavoratore risulta non iscritto")
      Me.dtpData.Location = New System.Drawing.Point(83, 12)
      Me.dtpData.Mandatory = True
      Me.dtpData.Name = "dtpData"
      Me.dtpData.OverridedEnable = True
      Me.dtpData.Required = False
      Me.HelpProvider1.SetShowHelp(Me.dtpData, True)
      Me.dtpData.Size = New System.Drawing.Size(111, 24)
      Me.dtpData.TabIndex = 1
      '
      'cboEnti
      '
      Me.cboEnti.BackColor = System.Drawing.Color.Transparent
      Me.cboEnti.ComboBoxStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.HelpProvider1.SetHelpString(Me.cboEnti, "Ente bilaterale che notifica la non iscrizione del lavoratore alla federazione")
      Me.cboEnti.Location = New System.Drawing.Point(83, 42)
      Me.cboEnti.Mandatory = True
      Me.cboEnti.Name = "cboEnti"
      Me.cboEnti.OverridedEnable = True
      Me.cboEnti.Required = False
      Me.HelpProvider1.SetShowHelp(Me.cboEnti, True)
      Me.cboEnti.Size = New System.Drawing.Size(151, 24)
      Me.cboEnti.TabIndex = 3
      Me.cboEnti.TextValue = ""
      '
      'cboIscritto
      '
      Me.cboIscritto.BackColor = System.Drawing.Color.Transparent
      Me.cboIscritto.ComboBoxStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.HelpProvider1.SetHelpString(Me.cboIscritto, "Sindacato cui il lavoratore è eventualmente iscritto (Diverso dalla Feneal)")
      Me.cboIscritto.Location = New System.Drawing.Point(83, 146)
      Me.cboIscritto.Mandatory = False
      Me.cboIscritto.Name = "cboIscritto"
      Me.cboIscritto.OverridedEnable = True
      Me.cboIscritto.Required = False
      Me.HelpProvider1.SetShowHelp(Me.cboIscritto, True)
      Me.cboIscritto.Size = New System.Drawing.Size(157, 29)
      Me.cboIscritto.TabIndex = 9
      Me.cboIscritto.TextValue = ""
      '
      'txtLivello
      '
      Me.txtLivello.BackColor = System.Drawing.Color.Transparent
      Me.HelpProvider1.SetHelpString(Me.txtLivello, "Livello di qualifica del lavoratore")
      Me.txtLivello.IsMultiline = False
      Me.txtLivello.Location = New System.Drawing.Point(83, 103)
      Me.txtLivello.Mandatory = False
      Me.txtLivello.Name = "txtLivello"
      Me.txtLivello.OverridedEnable = True
      Me.txtLivello.Required = False
      Me.HelpProvider1.SetShowHelp(Me.txtLivello, True)
      Me.txtLivello.Size = New System.Drawing.Size(103, 28)
      Me.txtLivello.TabIndex = 7
      Me.txtLivello.TextHeight = 20
      Me.txtLivello.TextValue = ""
      '
      'Label5
      '
      Me.Label5.AutoSize = True
      Me.Label5.Location = New System.Drawing.Point(23, 154)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(47, 13)
      Me.Label5.TabIndex = 8
      Me.Label5.Text = "Iscritto a"
      '
      'FrmInfos
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(382, 226)
      Me.Controls.Add(Me.txtLivello)
      Me.Controls.Add(Me.cboIscritto)
      Me.Controls.Add(Me.Label5)
      Me.Controls.Add(Me.cboEnti)
      Me.Controls.Add(Me.dtpData)
      Me.Controls.Add(Me.Label4)
      Me.Controls.Add(Me.IdAziendaTextBox1)
      Me.Controls.Add(Me.Label1)
      Me.Controls.Add(Me.Label3)
      Me.Controls.Add(Me.cmdOk)
      Me.Controls.Add(Me.cmdAnnulla)
      Me.Controls.Add(Me.cmdAdd)
      Me.Controls.Add(Me.Label2)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.Name = "FrmInfos"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Info utente"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents cmdOk As System.Windows.Forms.Button
   Friend WithEvents cmdAnnulla As System.Windows.Forms.Button
   Friend WithEvents cmdAdd As System.Windows.Forms.Button
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents IdAziendaTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdAziendaTextBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
   Friend WithEvents dtpData As WIN.GUI.UTILITY.UsabilityDtPicker
   Friend WithEvents cboEnti As WIN.GUI.UTILITY.UsabilityCombo
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents cboIscritto As WIN.GUI.UTILITY.UsabilityCombo
   Friend WithEvents txtLivello As WIN.GUI.UTILITY.UsabilityTextBox
End Class
