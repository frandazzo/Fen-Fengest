<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlPrepareRptIscritti
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlPrepareRptIscritti))
      Me.GroupBox3 = New WIN.GUI.UTILITY.NiceGroupBox
      Me.IdReferenteTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox
      Me.lblRef = New System.Windows.Forms.Label
      Me.Label4 = New System.Windows.Forms.Label
      Me.chkVer = New System.Windows.Forms.CheckBox
      Me.ControlSelPeriodiMensili1 = New WIN.GUI.APPLICATION.PRESENTATION.ControlSelPeriodiMensili
      Me.IdAziendaTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdAziendaTextBox
      Me.lblDescrizioneAzienda = New System.Windows.Forms.Label
      Me.Label5 = New System.Windows.Forms.Label
      Me.cboContratti = New System.Windows.Forms.ComboBox
      Me.cboSettori = New System.Windows.Forms.ComboBox
      Me.Label3 = New System.Windows.Forms.Label
      Me.lblSettore = New System.Windows.Forms.Label
      Me.lblSogg = New System.Windows.Forms.Label
      Me.CmdRpt = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.Label1 = New System.Windows.Forms.Label
      Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
      Me.DockPanel.SuspendLayout()
      Me.GroupBox3.SuspendLayout()
      Me.SuspendLayout()
      '
      'DockPanel
      '
      Me.DockPanel.Controls.Add(Me.Label1)
      Me.DockPanel.Controls.Add(Me.CmdRpt)
      '
      'GroupBox3
      '
      Me.GroupBox3.BackColor = System.Drawing.Color.Silver
      Me.GroupBox3.Controls.Add(Me.IdReferenteTextBox1)
      Me.GroupBox3.Controls.Add(Me.lblRef)
      Me.GroupBox3.Controls.Add(Me.Label4)
      Me.GroupBox3.Controls.Add(Me.chkVer)
      Me.GroupBox3.Controls.Add(Me.ControlSelPeriodiMensili1)
      Me.GroupBox3.Controls.Add(Me.IdAziendaTextBox1)
      Me.GroupBox3.Controls.Add(Me.lblDescrizioneAzienda)
      Me.GroupBox3.Controls.Add(Me.Label5)
      Me.GroupBox3.Controls.Add(Me.cboContratti)
      Me.GroupBox3.Controls.Add(Me.cboSettori)
      Me.GroupBox3.Controls.Add(Me.Label3)
      Me.GroupBox3.Controls.Add(Me.lblSettore)
      Me.GroupBox3.Controls.Add(Me.lblSogg)
      Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.GroupBox3.ForeColor = System.Drawing.Color.Black
      Me.GroupBox3.Location = New System.Drawing.Point(11, 91)
      Me.GroupBox3.Name = "GroupBox3"
      Me.GroupBox3.Size = New System.Drawing.Size(533, 240)
      Me.GroupBox3.TabIndex = 80
      Me.GroupBox3.Text = "Selezione criteri ricerca iscritti"
      Me.GroupBox3.Title = "Dati di selezione"
      '
      'IdReferenteTextBox1
      '
      Me.IdReferenteTextBox1.BackColor = System.Drawing.Color.Transparent
      Me.IdReferenteTextBox1.DescriptionOfText = ""
      Me.IdReferenteTextBox1.DescriptionTextWidth = 150
      Me.IdReferenteTextBox1.DescriptionTextXValue = 92
      Me.IdReferenteTextBox1.EnableSerchTextBox = True
      Me.HelpProvider1.SetHelpString(Me.IdReferenteTextBox1, "Identificativo del collaboratore comunale.Se selezionato, il report visualizzerà " & _
              "solo gli iscritti le cui deleghe sono state fatte sottoscrivere da quel collabor" & _
              "atore comunale")
      Me.IdReferenteTextBox1.IsDescriptionVisible = False
      Me.IdReferenteTextBox1.Location = New System.Drawing.Point(78, 188)
      Me.IdReferenteTextBox1.Mandatory = False
      Me.IdReferenteTextBox1.Margin = New System.Windows.Forms.Padding(0)
      Me.IdReferenteTextBox1.Name = "IdReferenteTextBox1"
      Me.HelpProvider1.SetShowHelp(Me.IdReferenteTextBox1, True)
      Me.IdReferenteTextBox1.Size = New System.Drawing.Size(97, 26)
      Me.IdReferenteTextBox1.TabIndex = 81
      Me.IdReferenteTextBox1.TextValue = ""
      '
      'lblRef
      '
      Me.lblRef.AutoSize = True
      Me.lblRef.BackColor = System.Drawing.Color.Transparent
      Me.lblRef.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblRef.Location = New System.Drawing.Point(226, 194)
      Me.lblRef.Name = "lblRef"
      Me.lblRef.Size = New System.Drawing.Size(0, 13)
      Me.lblRef.TabIndex = 92
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.Location = New System.Drawing.Point(10, 194)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(65, 13)
      Me.Label4.TabIndex = 91
      Me.Label4.Text = "Collab. com."
      '
      'chkVer
      '
      Me.chkVer.AutoSize = True
      Me.chkVer.BackColor = System.Drawing.Color.Transparent
      Me.chkVer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.HelpProvider1.SetHelpString(Me.chkVer, resources.GetString("chkVer.HelpString"))
      Me.chkVer.Location = New System.Drawing.Point(256, 79)
      Me.chkVer.Name = "chkVer"
      Me.HelpProvider1.SetShowHelp(Me.chkVer, True)
      Me.chkVer.Size = New System.Drawing.Size(172, 17)
      Me.chkVer.TabIndex = 90
      Me.chkVer.Text = "Verifica esistenza delega attiva"
      Me.chkVer.UseVisualStyleBackColor = False
      '
      'ControlSelPeriodiMensili1
      '
      Me.ControlSelPeriodiMensili1.BackColor = System.Drawing.Color.Transparent
      Me.ControlSelPeriodiMensili1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.HelpProvider1.SetHelpString(Me.ControlSelPeriodiMensili1, "Spuntare questa casella se si vuole selezionare quegli utenti per cui esiste un i" & _
              "ncasso di una quota associativa la cui competenza sia contenuta nel periodo sele" & _
              "zionato")
      Me.ControlSelPeriodiMensili1.Location = New System.Drawing.Point(40, 36)
      Me.ControlSelPeriodiMensili1.Name = "ControlSelPeriodiMensili1"
      Me.HelpProvider1.SetShowHelp(Me.ControlSelPeriodiMensili1, True)
      Me.ControlSelPeriodiMensili1.Size = New System.Drawing.Size(396, 32)
      Me.ControlSelPeriodiMensili1.TabIndex = 89
      '
      'IdAziendaTextBox1
      '
      Me.IdAziendaTextBox1.BackColor = System.Drawing.Color.Transparent
      Me.IdAziendaTextBox1.DescriptionOfText = ""
      Me.IdAziendaTextBox1.DescriptionTextWidth = 150
      Me.IdAziendaTextBox1.DescriptionTextXValue = 92
      Me.IdAziendaTextBox1.EnableSerchTextBox = True
      Me.IdAziendaTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.IdAziendaTextBox1.ForeColor = System.Drawing.Color.Black
      Me.HelpProvider1.SetHelpString(Me.IdAziendaTextBox1, resources.GetString("IdAziendaTextBox1.HelpString"))
      Me.IdAziendaTextBox1.IsDescriptionVisible = False
      Me.IdAziendaTextBox1.Location = New System.Drawing.Point(78, 146)
      Me.IdAziendaTextBox1.Mandatory = False
      Me.IdAziendaTextBox1.Margin = New System.Windows.Forms.Padding(0)
      Me.IdAziendaTextBox1.Name = "IdAziendaTextBox1"
      Me.HelpProvider1.SetShowHelp(Me.IdAziendaTextBox1, True)
      Me.IdAziendaTextBox1.Size = New System.Drawing.Size(97, 25)
      Me.IdAziendaTextBox1.TabIndex = 86
      Me.IdAziendaTextBox1.TextValue = ""
      '
      'lblDescrizioneAzienda
      '
      Me.lblDescrizioneAzienda.AutoSize = True
      Me.lblDescrizioneAzienda.BackColor = System.Drawing.Color.Transparent
      Me.lblDescrizioneAzienda.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblDescrizioneAzienda.Location = New System.Drawing.Point(219, 153)
      Me.lblDescrizioneAzienda.Name = "lblDescrizioneAzienda"
      Me.lblDescrizioneAzienda.Size = New System.Drawing.Size(14, 13)
      Me.lblDescrizioneAzienda.TabIndex = 83
      Me.lblDescrizioneAzienda.Text = "*"
      '
      'Label5
      '
      Me.Label5.AutoSize = True
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.Location = New System.Drawing.Point(15, 152)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(61, 13)
      Me.Label5.TabIndex = 81
      Me.Label5.Text = "Az. impiego"
      '
      'cboContratti
      '
      Me.cboContratti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cboContratti.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboContratti.FormattingEnabled = True
      Me.HelpProvider1.SetHelpString(Me.cboContratti, resources.GetString("cboContratti.HelpString"))
      Me.cboContratti.Location = New System.Drawing.Point(78, 108)
      Me.cboContratti.Name = "cboContratti"
      Me.HelpProvider1.SetShowHelp(Me.cboContratti, True)
      Me.cboContratti.Size = New System.Drawing.Size(162, 21)
      Me.cboContratti.TabIndex = 78
      '
      'cboSettori
      '
      Me.cboSettori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cboSettori.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboSettori.FormattingEnabled = True
      Me.HelpProvider1.SetHelpString(Me.cboSettori, "Settore di pertinenza delle deleghe.Essi possono essere EDILE e IMPIANTI FISSI. S" & _
              "e selezionato,il report conterrà soltanto le deleghe di pertinenza di quel setto" & _
              "re.")
      Me.cboSettori.Location = New System.Drawing.Point(78, 75)
      Me.cboSettori.Name = "cboSettori"
      Me.HelpProvider1.SetShowHelp(Me.cboSettori, True)
      Me.cboSettori.Size = New System.Drawing.Size(162, 21)
      Me.cboSettori.TabIndex = 79
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(16, 112)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(59, 13)
      Me.Label3.TabIndex = 77
      Me.Label3.Text = "Contr. app."
      '
      'lblSettore
      '
      Me.lblSettore.AutoSize = True
      Me.lblSettore.BackColor = System.Drawing.Color.Transparent
      Me.lblSettore.Cursor = System.Windows.Forms.Cursors.Hand
      Me.lblSettore.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblSettore.Location = New System.Drawing.Point(34, 79)
      Me.lblSettore.Name = "lblSettore"
      Me.lblSettore.Size = New System.Drawing.Size(41, 13)
      Me.lblSettore.TabIndex = 80
      Me.lblSettore.Text = "Settore"
      '
      'lblSogg
      '
      Me.lblSogg.AutoSize = True
      Me.lblSogg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblSogg.Location = New System.Drawing.Point(246, 108)
      Me.lblSogg.Name = "lblSogg"
      Me.lblSogg.Size = New System.Drawing.Size(0, 13)
      Me.lblSogg.TabIndex = 76
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
      Me.HelpProvider1.SetHelpString(Me.CmdRpt, "Funzione che permette di avviare la ricerca degli iscritti che rispondono ai crit" & _
              "eri di selezione impostati")
      Me.CmdRpt.ImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.CmdRpt.Location = New System.Drawing.Point(65, 5)
      Me.CmdRpt.Name = "CmdRpt"
      Me.CmdRpt.Radius = 32.0!
      Me.HelpProvider1.SetShowHelp(Me.CmdRpt, True)
      Me.CmdRpt.ShowTooltip = True
      Me.CmdRpt.Size = New System.Drawing.Size(32, 32)
      Me.CmdRpt.TabIndex = 81
      Me.CmdRpt.TextValue = ""
      Me.CmdRpt.TooltipText = "Elabora report"
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(11, 16)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(35, 13)
      Me.Label1.TabIndex = 82
      Me.Label1.Text = "Cerca"
      '
      'ControlPrepareRptIscritti
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.Controls.Add(Me.GroupBox3)
      Me.Name = "ControlPrepareRptIscritti"
      Me.Size = New System.Drawing.Size(741, 352)
      Me.Controls.SetChildIndex(Me.DockPanel, 0)
      Me.Controls.SetChildIndex(Me.Panel2, 0)
      Me.Controls.SetChildIndex(Me.GroupBox3, 0)
      Me.DockPanel.ResumeLayout(False)
      Me.DockPanel.PerformLayout()
      Me.GroupBox3.ResumeLayout(False)
      Me.GroupBox3.PerformLayout()
      Me.ResumeLayout(False)

   End Sub
    Friend WithEvents GroupBox3 As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents IdAziendaTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdAziendaTextBox
   Friend WithEvents lblDescrizioneAzienda As System.Windows.Forms.Label
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents cboContratti As System.Windows.Forms.ComboBox
   Friend WithEvents cboSettori As System.Windows.Forms.ComboBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents lblSettore As System.Windows.Forms.Label
   Friend WithEvents lblSogg As System.Windows.Forms.Label
   Friend WithEvents CmdRpt As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents ControlSelPeriodiMensili1 As WIN.GUI.APPLICATION.PRESENTATION.ControlSelPeriodiMensili
   Friend WithEvents chkVer As System.Windows.Forms.CheckBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents lblRef As System.Windows.Forms.Label
   Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents IdReferenteTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider

End Class
