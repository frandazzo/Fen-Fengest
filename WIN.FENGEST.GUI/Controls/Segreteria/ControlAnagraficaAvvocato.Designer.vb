<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlAnagraficaAvvocato
   Inherits GUI.APPLICATION.PRESENTATION.BrowserControl

   'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
   <System.Diagnostics.DebuggerNonUserCode()> _
   Protected Overrides Sub Dispose(ByVal disposing As Boolean)
      If disposing AndAlso components IsNot Nothing Then
         components.Dispose()
      End If
      MyBase.Dispose(disposing)
   End Sub

   'Richiesto da Progettazione Windows Form
   Private components As System.ComponentModel.IContainer

   'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
   'Può essere modificata in Progettazione Windows Form.  
   'Non modificarla nell'editor del codice.
   <System.Diagnostics.DebuggerStepThrough()> _
   Private Sub InitializeComponent()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CustomBar1 = New WIN.GUI.APPLICATION.PRESENTATION.CustomBar()
        Me.txtCap = New System.Windows.Forms.TextBox()
        Me.txtVia = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboProvincia = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboComune = New System.Windows.Forms.ComboBox()
        Me.txtPIva = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblId = New System.Windows.Forms.Label()
        Me.grpRag = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFax = New System.Windows.Forms.TextBox()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtResp = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtCell1 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTelUf = New System.Windows.Forms.TextBox()
        Me.txtCell2 = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.SpNew = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.IdAvvocatoTextbox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdAvvocatoTextbox()
        Me.DockPanel.SuspendLayout()
        Me.grpRag.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Size = New System.Drawing.Size(696, 26)
        '
        'DockPanel
        '
        Me.DockPanel.Controls.Add(Me.IdAvvocatoTextbox1)
        Me.DockPanel.Controls.Add(Me.SpNew)
        Me.DockPanel.Controls.Add(Me.lblId)
        Me.DockPanel.Controls.Add(Me.CustomBar1)
        Me.DockPanel.Location = New System.Drawing.Point(0, 26)
        Me.DockPanel.Size = New System.Drawing.Size(696, 44)
        '
        'txtNome
        '
        Me.txtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtNome, "Ragione sociale dell'avvocato")
        Me.txtNome.Location = New System.Drawing.Point(79, 14)
        Me.txtNome.Name = "txtNome"
        Me.HelpProvider1.SetShowHelp(Me.txtNome, True)
        Me.txtNome.Size = New System.Drawing.Size(253, 20)
        Me.txtNome.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Rag. soc."
        '
        'CustomBar1
        '
        Me.CustomBar1.BackColor = System.Drawing.Color.Transparent
        Me.CustomBar1.Location = New System.Drawing.Point(163, 1)
        Me.CustomBar1.Name = "CustomBar1"
        Me.CustomBar1.Size = New System.Drawing.Size(297, 40)
        Me.CustomBar1.TabIndex = 7
        '
        'txtCap
        '
        Me.txtCap.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtCap, "CAP della sede legale")
        Me.txtCap.Location = New System.Drawing.Point(373, 104)
        Me.txtCap.Name = "txtCap"
        Me.HelpProvider1.SetShowHelp(Me.txtCap, True)
        Me.txtCap.Size = New System.Drawing.Size(135, 20)
        Me.txtCap.TabIndex = 5
        '
        'txtVia
        '
        Me.txtVia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtVia, "Indirizzo della sede legale dello studio")
        Me.txtVia.Location = New System.Drawing.Point(79, 44)
        Me.txtVia.Name = "txtVia"
        Me.HelpProvider1.SetShowHelp(Me.txtVia, True)
        Me.txtVia.Size = New System.Drawing.Size(471, 20)
        Me.txtVia.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(25, 76)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Provincia"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(342, 109)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "CAP"
        '
        'cboProvincia
        '
        Me.cboProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProvincia.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboProvincia, "Provincia della sede legale dello studio")
        Me.cboProvincia.Location = New System.Drawing.Point(79, 75)
        Me.cboProvincia.Name = "cboProvincia"
        Me.HelpProvider1.SetShowHelp(Me.cboProvincia, True)
        Me.cboProvincia.Size = New System.Drawing.Size(232, 21)
        Me.cboProvincia.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(28, 47)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Indirizzo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(30, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Comune"
        '
        'cboComune
        '
        Me.cboComune.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboComune.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboComune, "Comune della sede legale dello studio")
        Me.cboComune.Location = New System.Drawing.Point(79, 103)
        Me.cboComune.Name = "cboComune"
        Me.HelpProvider1.SetShowHelp(Me.cboComune, True)
        Me.cboComune.Size = New System.Drawing.Size(232, 21)
        Me.cboComune.TabIndex = 4
        '
        'txtPIva
        '
        Me.txtPIva.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtPIva, "Partita Iva dell'avvocato")
        Me.txtPIva.Location = New System.Drawing.Point(407, 14)
        Me.txtPIva.Name = "txtPIva"
        Me.HelpProvider1.SetShowHelp(Me.txtPIva, True)
        Me.txtPIva.Size = New System.Drawing.Size(143, 20)
        Me.txtPIva.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(367, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "P. Iva"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.BackColor = System.Drawing.Color.Transparent
        Me.lblId.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.ForeColor = System.Drawing.Color.Black
        Me.lblId.Location = New System.Drawing.Point(8, 15)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(17, 13)
        Me.lblId.TabIndex = 1
        Me.lblId.Text = "Id"
        '
        'grpRag
        '
        Me.grpRag.BackColor = System.Drawing.Color.Transparent
        Me.grpRag.Controls.Add(Me.TabControl2)
        Me.grpRag.Location = New System.Drawing.Point(11, 77)
        Me.grpRag.Name = "grpRag"
        Me.grpRag.Size = New System.Drawing.Size(647, 405)
        Me.grpRag.TabIndex = 0
        Me.grpRag.Title = "Dati anagrafici"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Location = New System.Drawing.Point(13, 24)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(617, 355)
        Me.TabControl2.TabIndex = 3
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Controls.Add(Me.txtCap)
        Me.TabPage3.Controls.Add(Me.txtFax)
        Me.TabPage3.Controls.Add(Me.txtPIva)
        Me.TabPage3.Controls.Add(Me.txtVia)
        Me.TabPage3.Controls.Add(Me.txtMail)
        Me.TabPage3.Controls.Add(Me.Label19)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.txtNome)
        Me.TabPage3.Controls.Add(Me.Label18)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.txtResp)
        Me.TabPage3.Controls.Add(Me.cboProvincia)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.Label16)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.txtCell1)
        Me.TabPage3.Controls.Add(Me.cboComune)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Controls.Add(Me.txtTelUf)
        Me.TabPage3.Controls.Add(Me.txtCell2)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(609, 329)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Anagrafica avvocato"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 165)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Contatti"
        '
        'txtFax
        '
        Me.txtFax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtFax, "Numero di fax dell'avvocato")
        Me.txtFax.Location = New System.Drawing.Point(79, 228)
        Me.txtFax.Name = "txtFax"
        Me.HelpProvider1.SetShowHelp(Me.txtFax, True)
        Me.txtFax.Size = New System.Drawing.Size(196, 20)
        Me.txtFax.TabIndex = 8
        '
        'txtMail
        '
        Me.txtMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtMail, "Indirizzo di posta elettronica dell'avvocato")
        Me.txtMail.Location = New System.Drawing.Point(373, 271)
        Me.txtMail.Name = "txtMail"
        Me.HelpProvider1.SetShowHelp(Me.txtMail, True)
        Me.txtMail.Size = New System.Drawing.Size(196, 20)
        Me.txtMail.TabIndex = 11
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(44, 235)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(24, 13)
        Me.Label19.TabIndex = 25
        Me.Label19.Text = "Fax"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(33, 276)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(35, 13)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "Resp."
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(319, 235)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 13)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "Cell.2"
        '
        'txtResp
        '
        Me.txtResp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtResp, "Responsabile  dell'ufficio legale")
        Me.txtResp.Location = New System.Drawing.Point(79, 271)
        Me.txtResp.Name = "txtResp"
        Me.HelpProvider1.SetShowHelp(Me.txtResp, True)
        Me.txtResp.Size = New System.Drawing.Size(196, 20)
        Me.txtResp.TabIndex = 10
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(319, 209)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 13)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Cell.1"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(326, 274)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(26, 13)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Mail"
        '
        'txtCell1
        '
        Me.txtCell1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtCell1, "Numero di cellulare dell'avvocato")
        Me.txtCell1.Location = New System.Drawing.Point(373, 206)
        Me.txtCell1.Name = "txtCell1"
        Me.HelpProvider1.SetShowHelp(Me.txtCell1, True)
        Me.txtCell1.Size = New System.Drawing.Size(196, 20)
        Me.txtCell1.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(43, 209)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(25, 13)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Tel."
        '
        'txtTelUf
        '
        Me.txtTelUf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtTelUf, "Numero di telefono dell'avvocato")
        Me.txtTelUf.Location = New System.Drawing.Point(79, 202)
        Me.txtTelUf.Name = "txtTelUf"
        Me.HelpProvider1.SetShowHelp(Me.txtTelUf, True)
        Me.txtTelUf.Size = New System.Drawing.Size(196, 20)
        Me.txtTelUf.TabIndex = 6
        '
        'txtCell2
        '
        Me.txtCell2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtCell2, "Secondo numero di cellulare dell'avvocato")
        Me.txtCell2.Location = New System.Drawing.Point(373, 232)
        Me.txtCell2.Name = "txtCell2"
        Me.HelpProvider1.SetShowHelp(Me.txtCell2, True)
        Me.txtCell2.Size = New System.Drawing.Size(196, 20)
        Me.txtCell2.TabIndex = 9
        '
        'SpNew
        '
        Me.SpNew.ApplyOutLookStile = True
        Me.SpNew.BackColor = System.Drawing.Color.Transparent
        Me.SpNew.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.file_new_32x32
        Me.SpNew.Disabled = False
        Me.SpNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SpNew.ForeColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.SpNew, "Funzione che permette di creare una nuova vertenza.")
        Me.SpNew.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SpNew.Location = New System.Drawing.Point(170, 6)
        Me.SpNew.Name = "SpNew"
        Me.SpNew.Radius = 32.0!
        Me.HelpProvider1.SetShowHelp(Me.SpNew, True)
        Me.SpNew.ShowTooltip = True
        Me.SpNew.Size = New System.Drawing.Size(32, 32)
        Me.SpNew.TabIndex = 119
        Me.SpNew.TextValue = ""
        Me.SpNew.TooltipText = "Crea nuova anagrafica"
        '
        'IdAvvocatoTextbox1
        '
        Me.IdAvvocatoTextbox1.BackColor = System.Drawing.Color.Transparent
        Me.IdAvvocatoTextbox1.DescriptionOfText = ""
        Me.IdAvvocatoTextbox1.DescriptionTextWidth = 150
        Me.IdAvvocatoTextbox1.DescriptionTextXValue = 92
        Me.IdAvvocatoTextbox1.EnableSerchTextBox = True
        Me.IdAvvocatoTextbox1.IsDescriptionVisible = False
        Me.IdAvvocatoTextbox1.Location = New System.Drawing.Point(26, 10)
        Me.IdAvvocatoTextbox1.Mandatory = False
        Me.IdAvvocatoTextbox1.Margin = New System.Windows.Forms.Padding(0)
        Me.IdAvvocatoTextbox1.Name = "IdAvvocatoTextbox1"
        Me.IdAvvocatoTextbox1.Size = New System.Drawing.Size(98, 27)
        Me.IdAvvocatoTextbox1.TabIndex = 120
        Me.IdAvvocatoTextbox1.TextValue = ""
        '
        'ControlAnagraficaAvvocato
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.grpRag)
        Me.Name = "ControlAnagraficaAvvocato"
        Me.Size = New System.Drawing.Size(696, 502)
        Me.Controls.SetChildIndex(Me.DockPanel, 0)
        Me.Controls.SetChildIndex(Me.grpRag, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.DockPanel.ResumeLayout(False)
        Me.DockPanel.PerformLayout()
        Me.grpRag.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
   Friend WithEvents txtNome As System.Windows.Forms.TextBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents CustomBar1 As WIN.GUI.APPLICATION.PRESENTATION.CustomBar
   Friend WithEvents txtCap As System.Windows.Forms.TextBox
   Friend WithEvents txtVia As System.Windows.Forms.TextBox
   Friend WithEvents Label10 As System.Windows.Forms.Label
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Friend WithEvents cboComune As System.Windows.Forms.ComboBox
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents cboProvincia As System.Windows.Forms.ComboBox
   Friend WithEvents Label12 As System.Windows.Forms.Label
   Friend WithEvents txtPIva As System.Windows.Forms.TextBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents grpRag As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
   Friend WithEvents txtFax As System.Windows.Forms.TextBox
   Friend WithEvents txtMail As System.Windows.Forms.TextBox
   Friend WithEvents Label19 As System.Windows.Forms.Label
   Friend WithEvents Label18 As System.Windows.Forms.Label
   Friend WithEvents txtResp As System.Windows.Forms.TextBox
   Friend WithEvents Label16 As System.Windows.Forms.Label
   Friend WithEvents Label13 As System.Windows.Forms.Label
   Friend WithEvents txtCell2 As System.Windows.Forms.TextBox
   Friend WithEvents txtTelUf As System.Windows.Forms.TextBox
   Friend WithEvents txtCell1 As System.Windows.Forms.TextBox
   Friend WithEvents Label14 As System.Windows.Forms.Label
   Friend WithEvents Label15 As System.Windows.Forms.Label
   Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
   Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
   Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
   Friend WithEvents SpNew As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents IdAvvocatoTextbox1 As WIN.GUI.APPLICATION.PRESENTATION.IdAvvocatoTextbox

End Class
