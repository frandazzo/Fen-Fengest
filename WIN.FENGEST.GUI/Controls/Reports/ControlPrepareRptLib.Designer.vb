<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlPrepareRptLib
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlPrepareRptLib))
      Me.GroupBox3 = New WIN.GUI.UTILITY.NiceGroupBox
      Me.chkErr = New System.Windows.Forms.CheckBox
      Me.Label2 = New System.Windows.Forms.Label
      Me.cboEnti = New System.Windows.Forms.ComboBox
      Me.ControlSelPeriodiMensili1 = New WIN.GUI.APPLICATION.PRESENTATION.ControlSelPeriodiMensili
      Me.IdAziendaTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdAziendaTextBox
      Me.lblDescrizioneAzienda = New System.Windows.Forms.Label
      Me.Label5 = New System.Windows.Forms.Label
      Me.Label1 = New System.Windows.Forms.Label
      Me.CmdRpt = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
      Me.DockPanel.SuspendLayout()
      Me.GroupBox3.SuspendLayout()
      Me.SuspendLayout()
      '
      'DockPanel
      '
      Me.DockPanel.Controls.Add(Me.CmdRpt)
      Me.DockPanel.Controls.Add(Me.Label1)
      '
      'GroupBox3
      '
      Me.GroupBox3.BackColor = System.Drawing.Color.Silver
      Me.GroupBox3.Controls.Add(Me.chkErr)
      Me.GroupBox3.Controls.Add(Me.Label2)
      Me.GroupBox3.Controls.Add(Me.cboEnti)
      Me.GroupBox3.Controls.Add(Me.ControlSelPeriodiMensili1)
      Me.GroupBox3.Controls.Add(Me.IdAziendaTextBox1)
      Me.GroupBox3.Controls.Add(Me.lblDescrizioneAzienda)
      Me.GroupBox3.Controls.Add(Me.Label5)
      Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.GroupBox3.ForeColor = System.Drawing.Color.Black
      Me.GroupBox3.Location = New System.Drawing.Point(11, 87)
      Me.GroupBox3.Name = "GroupBox3"
      Me.GroupBox3.Size = New System.Drawing.Size(569, 159)
      Me.GroupBox3.TabIndex = 83
      Me.GroupBox3.Text = "Selezione criteri ricerca iscritti"
      Me.GroupBox3.Title = "Dati impiego"
      '
      'chkErr
      '
      Me.chkErr.AutoSize = True
      Me.chkErr.BackColor = System.Drawing.Color.Transparent
      Me.chkErr.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.HelpProvider1.SetHelpString(Me.chkErr, resources.GetString("chkErr.HelpString"))
      Me.chkErr.Location = New System.Drawing.Point(335, 75)
      Me.chkErr.Name = "chkErr"
      Me.HelpProvider1.SetShowHelp(Me.chkErr, True)
      Me.chkErr.Size = New System.Drawing.Size(130, 17)
      Me.chkErr.TabIndex = 92
      Me.chkErr.Text = "Ricerca incongruenze"
      Me.chkErr.UseVisualStyleBackColor = False
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(42, 82)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(29, 13)
      Me.Label2.TabIndex = 91
      Me.Label2.Text = "Ente"
      '
      'cboEnti
      '
      Me.cboEnti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cboEnti.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboEnti.FormattingEnabled = True
      Me.HelpProvider1.SetHelpString(Me.cboEnti, "Ente bilaterale. Se selezionato,si visualizzeranno soltanto i lavoratori liberi c" & _
              "he risultano dai dati consegnati alla federazione da quell'ente bilaterale")
      Me.cboEnti.Location = New System.Drawing.Point(77, 74)
      Me.cboEnti.Name = "cboEnti"
      Me.HelpProvider1.SetShowHelp(Me.cboEnti, True)
      Me.cboEnti.Size = New System.Drawing.Size(162, 21)
      Me.cboEnti.TabIndex = 90
      '
      'ControlSelPeriodiMensili1
      '
      Me.ControlSelPeriodiMensili1.BackColor = System.Drawing.Color.Transparent
      Me.ControlSelPeriodiMensili1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.ControlSelPeriodiMensili1.Location = New System.Drawing.Point(40, 36)
      Me.ControlSelPeriodiMensili1.Name = "ControlSelPeriodiMensili1"
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
      Me.HelpProvider1.SetHelpString(Me.IdAziendaTextBox1, "Identificativo dell'azienda di impiego dei lavoratori.Se selezionato,il report vi" & _
              "sualizzerà soltanto i lavoratori liberi che sono impiegati presso l'azienda sele" & _
              "zionata.")
      Me.IdAziendaTextBox1.IsDescriptionVisible = False
      Me.IdAziendaTextBox1.Location = New System.Drawing.Point(77, 112)
      Me.IdAziendaTextBox1.Mandatory = False
      Me.IdAziendaTextBox1.Margin = New System.Windows.Forms.Padding(0)
      Me.IdAziendaTextBox1.Name = "IdAziendaTextBox1"
      Me.HelpProvider1.SetShowHelp(Me.IdAziendaTextBox1, True)
      Me.IdAziendaTextBox1.Size = New System.Drawing.Size(95, 23)
      Me.IdAziendaTextBox1.TabIndex = 86
      Me.IdAziendaTextBox1.TextValue = ""
      '
      'lblDescrizioneAzienda
      '
      Me.lblDescrizioneAzienda.AutoSize = True
      Me.lblDescrizioneAzienda.BackColor = System.Drawing.Color.Transparent
      Me.lblDescrizioneAzienda.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblDescrizioneAzienda.Location = New System.Drawing.Point(260, 119)
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
      Me.Label5.Location = New System.Drawing.Point(11, 118)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(61, 13)
      Me.Label5.TabIndex = 81
      Me.Label5.Text = "Az. impiego"
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(8, 18)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(35, 13)
      Me.Label1.TabIndex = 85
      Me.Label1.Text = "Cerca"
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
      Me.HelpProvider1.SetHelpString(Me.CmdRpt, "Funzione che permette di avviare la ricerca dei lavoratori liberi che rispondono " & _
              "ai criteri di selezione impostati")
      Me.CmdRpt.ImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.CmdRpt.Location = New System.Drawing.Point(57, 7)
      Me.CmdRpt.Name = "CmdRpt"
      Me.CmdRpt.Radius = 32.0!
      Me.HelpProvider1.SetShowHelp(Me.CmdRpt, True)
      Me.CmdRpt.ShowTooltip = True
      Me.CmdRpt.Size = New System.Drawing.Size(32, 32)
      Me.CmdRpt.TabIndex = 84
      Me.CmdRpt.TextValue = ""
      Me.CmdRpt.TooltipText = "Elabora report"
      '
      'ControlPrepareRptLib
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.Controls.Add(Me.GroupBox3)
      Me.Name = "ControlPrepareRptLib"
      Me.Controls.SetChildIndex(Me.GroupBox3, 0)
      Me.Controls.SetChildIndex(Me.Panel2, 0)
      Me.Controls.SetChildIndex(Me.DockPanel, 0)
      Me.DockPanel.ResumeLayout(False)
      Me.DockPanel.PerformLayout()
      Me.GroupBox3.ResumeLayout(False)
      Me.GroupBox3.PerformLayout()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents GroupBox3 As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents ControlSelPeriodiMensili1 As WIN.GUI.APPLICATION.PRESENTATION.ControlSelPeriodiMensili
   Friend WithEvents IdAziendaTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdAziendaTextBox
   Friend WithEvents lblDescrizioneAzienda As System.Windows.Forms.Label
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents CmdRpt As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents cboEnti As System.Windows.Forms.ComboBox
    Friend WithEvents chkErr As System.Windows.Forms.CheckBox
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider

End Class
