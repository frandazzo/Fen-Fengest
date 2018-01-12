<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlPrepareRptPrestazioni
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlPrepareRptPrestazioni))
        Me.chkRes = New System.Windows.Forms.CheckBox()
        Me.cboComune = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboProvincia = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblSogg = New System.Windows.Forms.Label()
        Me.chkUt = New System.Windows.Forms.CheckBox()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDocDa = New System.Windows.Forms.DateTimePicker()
        Me.chkReg = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkDoc = New System.Windows.Forms.CheckBox()
        Me.dtpRegA = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox3 = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblDescrizioneReferente = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.IdReferenteTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox()
        Me.cmdUt = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmdRpt = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.DockPanel.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Size = New System.Drawing.Size(576, 30)
        '
        'DockPanel
        '
        Me.DockPanel.Controls.Add(Me.Label2)
        Me.DockPanel.Controls.Add(Me.CmdRpt)
        Me.DockPanel.Size = New System.Drawing.Size(576, 44)
        '
        'chkRes
        '
        Me.chkRes.AutoSize = True
        Me.chkRes.BackColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.chkRes, "Spuntare questa casella se si vuole il report delle prestazioni Inps degli utenti" & _
        " che abbiano una residenza specificata in termini di provincia e/o comune di res" & _
        "idenza.")
        Me.chkRes.Location = New System.Drawing.Point(19, 112)
        Me.chkRes.Name = "chkRes"
        Me.HelpProvider1.SetShowHelp(Me.chkRes, True)
        Me.chkRes.Size = New System.Drawing.Size(121, 17)
        Me.chkRes.TabIndex = 86
        Me.chkRes.Text = "Selezione res. utenti"
        Me.chkRes.UseVisualStyleBackColor = False
        '
        'cboComune
        '
        Me.cboComune.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboComune.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboComune, "Comune di residenza")
        Me.cboComune.Location = New System.Drawing.Point(222, 139)
        Me.cboComune.Name = "cboComune"
        Me.HelpProvider1.SetShowHelp(Me.cboComune, True)
        Me.cboComune.Size = New System.Drawing.Size(224, 21)
        Me.cboComune.TabIndex = 77
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(168, 143)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 85
        Me.Label8.Text = "Com. res."
        '
        'cboProvincia
        '
        Me.cboProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProvincia.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboProvincia, "Provincia di residenza.")
        Me.cboProvincia.Location = New System.Drawing.Point(222, 109)
        Me.cboProvincia.Name = "cboProvincia"
        Me.HelpProvider1.SetShowHelp(Me.cboProvincia, True)
        Me.cboProvincia.Size = New System.Drawing.Size(224, 21)
        Me.cboProvincia.TabIndex = 76
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(167, 113)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 13)
        Me.Label12.TabIndex = 84
        Me.Label12.Text = "Prov. res."
        '
        'lblSogg
        '
        Me.lblSogg.AutoSize = True
        Me.lblSogg.BackColor = System.Drawing.Color.Transparent
        Me.lblSogg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSogg.Location = New System.Drawing.Point(284, 77)
        Me.lblSogg.Name = "lblSogg"
        Me.lblSogg.Size = New System.Drawing.Size(0, 13)
        Me.lblSogg.TabIndex = 83
        Me.lblSogg.UseMnemonic = False
        '
        'chkUt
        '
        Me.chkUt.AutoSize = True
        Me.chkUt.BackColor = System.Drawing.Color.Transparent
        Me.chkUt.Location = New System.Drawing.Point(18, 76)
        Me.chkUt.Name = "chkUt"
        Me.chkUt.Size = New System.Drawing.Size(122, 17)
        Me.chkUt.TabIndex = 74
        Me.chkUt.Text = "Selezione lista utenti"
        Me.chkUt.UseVisualStyleBackColor = False
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboTipo, resources.GetString("cboTipo.HelpString"))
        Me.cboTipo.Location = New System.Drawing.Point(75, 31)
        Me.cboTipo.Name = "cboTipo"
        Me.HelpProvider1.SetShowHelp(Me.cboTipo, True)
        Me.cboTipo.Size = New System.Drawing.Size(204, 21)
        Me.cboTipo.TabIndex = 67
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(305, 65)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 13)
        Me.Label11.TabIndex = 81
        Me.Label11.Text = "fino al"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(15, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Tipo prest."
        '
        'dtpDocDa
        '
        Me.dtpDocDa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDocDa.Location = New System.Drawing.Point(358, 59)
        Me.dtpDocDa.Name = "dtpDocDa"
        Me.dtpDocDa.Size = New System.Drawing.Size(99, 20)
        Me.dtpDocDa.TabIndex = 72
        '
        'chkReg
        '
        Me.chkReg.AutoSize = True
        Me.chkReg.BackColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.chkReg, resources.GetString("chkReg.HelpString"))
        Me.chkReg.Location = New System.Drawing.Point(30, 33)
        Me.chkReg.Name = "chkReg"
        Me.HelpProvider1.SetShowHelp(Me.chkReg, True)
        Me.chkReg.Size = New System.Drawing.Size(154, 17)
        Me.chkReg.TabIndex = 68
        Me.chkReg.Text = "Selezione data inizio prest.:"
        Me.chkReg.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(320, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "dal"
        '
        'chkDoc
        '
        Me.chkDoc.AutoSize = True
        Me.chkDoc.BackColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.chkDoc, "Spuntare questa casella se si vuole il report delle prestazioni Inps la cui data " & _
        "documento(data in cui è stata compilata la prestazione) sia compresa nell'interv" & _
        "allo temporale delle date ""da-a""")
        Me.chkDoc.Location = New System.Drawing.Point(30, 65)
        Me.chkDoc.Name = "chkDoc"
        Me.HelpProvider1.SetShowHelp(Me.chkDoc, True)
        Me.chkDoc.Size = New System.Drawing.Size(145, 17)
        Me.chkDoc.TabIndex = 71
        Me.chkDoc.TabStop = False
        Me.chkDoc.Text = "Selezione data fine prest."
        Me.chkDoc.UseVisualStyleBackColor = False
        '
        'dtpRegA
        '
        Me.dtpRegA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRegA.Location = New System.Drawing.Point(358, 30)
        Me.dtpRegA.Name = "dtpRegA"
        Me.dtpRegA.Size = New System.Drawing.Size(99, 20)
        Me.dtpRegA.TabIndex = 70
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Silver
        Me.GroupBox3.Controls.Add(Me.Panel3)
        Me.GroupBox3.Controls.Add(Me.dtpRegA)
        Me.GroupBox3.Controls.Add(Me.chkDoc)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.chkReg)
        Me.GroupBox3.Controls.Add(Me.dtpDocDa)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(17, 91)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(533, 359)
        Me.GroupBox3.TabIndex = 87
        Me.GroupBox3.Text = "Selezione criteri ricerca iscritti"
        Me.GroupBox3.Title = "Dati di selezione"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lblDescrizioneReferente)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.cboTipo)
        Me.Panel3.Controls.Add(Me.IdReferenteTextBox1)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.chkUt)
        Me.Panel3.Controls.Add(Me.chkRes)
        Me.Panel3.Controls.Add(Me.cmdUt)
        Me.Panel3.Controls.Add(Me.lblSogg)
        Me.Panel3.Controls.Add(Me.cboComune)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.cboProvincia)
        Me.Panel3.Location = New System.Drawing.Point(20, 98)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(485, 231)
        Me.Panel3.TabIndex = 95
        '
        'lblDescrizioneReferente
        '
        Me.lblDescrizioneReferente.AutoSize = True
        Me.lblDescrizioneReferente.BackColor = System.Drawing.Color.Transparent
        Me.lblDescrizioneReferente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrizioneReferente.Location = New System.Drawing.Point(193, 196)
        Me.lblDescrizioneReferente.Name = "lblDescrizioneReferente"
        Me.lblDescrizioneReferente.Size = New System.Drawing.Size(0, 13)
        Me.lblDescrizioneReferente.TabIndex = 89
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 13)
        Me.Label6.TabIndex = 94
        Me.Label6.Text = "Selezione avanzata"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(8, 196)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 88
        Me.Label3.Text = "Collab. com."
        '
        'IdReferenteTextBox1
        '
        Me.IdReferenteTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.IdReferenteTextBox1.DescriptionOfText = ""
        Me.IdReferenteTextBox1.DescriptionTextWidth = 150
        Me.IdReferenteTextBox1.DescriptionTextXValue = 92
        Me.IdReferenteTextBox1.EnableSerchTextBox = True
        Me.HelpProvider1.SetHelpString(Me.IdReferenteTextBox1, "Identificativo del collaboratore comunale.Se inserito,il report visualizzerà solt" & _
        "anto le prestazioni Inps che sono state compilate dal collaboratore comunale.")
        Me.IdReferenteTextBox1.IsDescriptionVisible = False
        Me.IdReferenteTextBox1.Location = New System.Drawing.Point(80, 190)
        Me.IdReferenteTextBox1.Mandatory = False
        Me.IdReferenteTextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.IdReferenteTextBox1.Name = "IdReferenteTextBox1"
        Me.HelpProvider1.SetShowHelp(Me.IdReferenteTextBox1, True)
        Me.IdReferenteTextBox1.Size = New System.Drawing.Size(99, 27)
        Me.IdReferenteTextBox1.TabIndex = 87
        Me.IdReferenteTextBox1.TextValue = ""
        '
        'cmdUt
        '
        Me.cmdUt.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.k_edit_16x16
        Me.cmdUt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdUt.Location = New System.Drawing.Point(201, 70)
        Me.cmdUt.Name = "cmdUt"
        Me.cmdUt.Size = New System.Drawing.Size(77, 26)
        Me.cmdUt.TabIndex = 75
        Me.cmdUt.Text = "Seleziona"
        Me.cmdUt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdUt.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 84
        Me.Label2.Text = "Cerca"
        '
        'CmdRpt
        '
        Me.CmdRpt.ApplyOutLookStile = True
        Me.CmdRpt.BackColor = System.Drawing.Color.Transparent
        Me.CmdRpt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CmdRpt.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.k_ghost_view_32x32
        Me.CmdRpt.Disabled = False
        Me.CmdRpt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdRpt.ForeColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.CmdRpt, "Funzione che permette di avviare la ricerca delle prestazioni Inps che rispondono" & _
        " ai criteri di selezione impostati")
        Me.CmdRpt.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CmdRpt.Location = New System.Drawing.Point(70, 6)
        Me.CmdRpt.Name = "CmdRpt"
        Me.CmdRpt.Radius = 32.0!
        Me.HelpProvider1.SetShowHelp(Me.CmdRpt, True)
        Me.CmdRpt.ShowTooltip = True
        Me.CmdRpt.Size = New System.Drawing.Size(32, 32)
        Me.CmdRpt.TabIndex = 83
        Me.CmdRpt.TextValue = ""
        Me.CmdRpt.TooltipText = "Elabora report"
        '
        'ControlPrepareRptPrestazioni
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "ControlPrepareRptPrestazioni"
        Me.Size = New System.Drawing.Size(576, 473)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.DockPanel, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.DockPanel.ResumeLayout(False)
        Me.DockPanel.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
   Friend WithEvents chkRes As System.Windows.Forms.CheckBox
   Friend WithEvents cboComune As System.Windows.Forms.ComboBox
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents cboProvincia As System.Windows.Forms.ComboBox
   Friend WithEvents Label12 As System.Windows.Forms.Label
   Friend WithEvents lblSogg As System.Windows.Forms.Label
   Friend WithEvents cmdUt As System.Windows.Forms.Button
   Friend WithEvents chkUt As System.Windows.Forms.CheckBox
    Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
   Friend WithEvents Label11 As System.Windows.Forms.Label
   Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpDocDa As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkReg As System.Windows.Forms.CheckBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents chkDoc As System.Windows.Forms.CheckBox
   Friend WithEvents dtpRegA As System.Windows.Forms.DateTimePicker
   Friend WithEvents GroupBox3 As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents CmdRpt As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents IdReferenteTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox
    Friend WithEvents lblDescrizioneReferente As System.Windows.Forms.Label
   Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
   Friend WithEvents Panel3 As System.Windows.Forms.Panel
   Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
