<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlAnalisiDomandaLavoro
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
      Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlAnalisiDomandaLavoro))
      Me.Label1 = New System.Windows.Forms.Label
      Me.TabControl1 = New System.Windows.Forms.TabControl
      Me.TabPage1 = New System.Windows.Forms.TabPage
      Me.GridUtenti = New System.Windows.Forms.DataGridView
      Me.cboSkill = New System.Windows.Forms.ComboBox
      Me.IdOffertaTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdOffertaTextBox
      Me.lblId = New System.Windows.Forms.Label
      Me.NiceGroupBox1 = New WIN.GUI.UTILITY.NiceGroupBox
      Me.txtResults = New System.Windows.Forms.TextBox
      Me.Label2 = New System.Windows.Forms.Label
      Me.Panel1 = New System.Windows.Forms.Panel
      Me.cmdUp = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.CmdDown = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.cmdDeselectAll = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.cmdSelectAll = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.NiceGroupBox2 = New WIN.GUI.UTILITY.NiceGroupBox
      Me.cmdListaLavoro = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.cmdProp = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.CmdVis = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
      Me.DockPanel.SuspendLayout()
      Me.TabControl1.SuspendLayout()
      Me.TabPage1.SuspendLayout()
      CType(Me.GridUtenti, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.NiceGroupBox1.SuspendLayout()
      Me.Panel1.SuspendLayout()
      Me.NiceGroupBox2.SuspendLayout()
      Me.SuspendLayout()
      '
      'Panel2
      '
      Me.Panel2.Size = New System.Drawing.Size(547, 26)
      '
      'DockPanel
      '
      Me.DockPanel.Controls.Add(Me.cmdListaLavoro)
      Me.DockPanel.Controls.Add(Me.cmdProp)
      Me.DockPanel.Controls.Add(Me.CmdVis)
      Me.DockPanel.Location = New System.Drawing.Point(0, 26)
      Me.DockPanel.Size = New System.Drawing.Size(547, 44)
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.Location = New System.Drawing.Point(22, 40)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(68, 13)
      Me.Label1.TabIndex = 0
      Me.Label1.Text = "Skill richiesto"
      '
      'TabControl1
      '
      Me.TabControl1.Controls.Add(Me.TabPage1)
      Me.TabControl1.Location = New System.Drawing.Point(13, 57)
      Me.TabControl1.Name = "TabControl1"
      Me.TabControl1.SelectedIndex = 0
      Me.TabControl1.Size = New System.Drawing.Size(410, 402)
      Me.TabControl1.TabIndex = 10
      '
      'TabPage1
      '
      Me.TabPage1.Controls.Add(Me.GridUtenti)
      Me.TabPage1.Location = New System.Drawing.Point(4, 22)
      Me.TabPage1.Name = "TabPage1"
      Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
      Me.TabPage1.Size = New System.Drawing.Size(402, 376)
      Me.TabPage1.TabIndex = 0
      Me.TabPage1.Text = "Lista utenti compatibili"
      Me.TabPage1.UseVisualStyleBackColor = True
      '
      'GridUtenti
      '
      Me.GridUtenti.AllowUserToAddRows = False
      Me.GridUtenti.AllowUserToDeleteRows = False
      DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue
      DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
      DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange
      DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
      Me.GridUtenti.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
      Me.GridUtenti.BackgroundColor = System.Drawing.Color.White
      Me.GridUtenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.GridUtenti.Dock = System.Windows.Forms.DockStyle.Fill
      Me.GridUtenti.Location = New System.Drawing.Point(3, 3)
      Me.GridUtenti.Name = "GridUtenti"
      Me.GridUtenti.ReadOnly = True
      Me.GridUtenti.RowHeadersVisible = False
      DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
      DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Orange
      DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
      Me.GridUtenti.RowsDefaultCellStyle = DataGridViewCellStyle2
      Me.GridUtenti.Size = New System.Drawing.Size(396, 370)
      Me.GridUtenti.TabIndex = 0
      '
      'cboSkill
      '
      Me.cboSkill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cboSkill.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.cboSkill.FormattingEnabled = True
      Me.HelpProvider1.SetHelpString(Me.cboSkill, resources.GetString("cboSkill.HelpString"))
      Me.cboSkill.Location = New System.Drawing.Point(96, 35)
      Me.cboSkill.Name = "cboSkill"
      Me.HelpProvider1.SetShowHelp(Me.cboSkill, True)
      Me.cboSkill.Size = New System.Drawing.Size(130, 21)
      Me.cboSkill.TabIndex = 1
      '
      'IdOffertaTextBox1
      '
      Me.IdOffertaTextBox1.BackColor = System.Drawing.Color.Transparent
      Me.IdOffertaTextBox1.DescriptionOfText = ""
      Me.IdOffertaTextBox1.DescriptionTextWidth = 150
      Me.IdOffertaTextBox1.DescriptionTextXValue = 92
      Me.IdOffertaTextBox1.EnableSerchTextBox = True
      Me.IdOffertaTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.HelpProvider1.SetHelpString(Me.IdOffertaTextBox1, "Identificativo della domanda di lavoro per cui si vogliono cercare offerte di lav" & _
              "oro da parte degli iscritti alla federazione.")
      Me.IdOffertaTextBox1.IsDescriptionVisible = False
      Me.IdOffertaTextBox1.Location = New System.Drawing.Point(375, 34)
      Me.IdOffertaTextBox1.Mandatory = False
      Me.IdOffertaTextBox1.Margin = New System.Windows.Forms.Padding(0)
      Me.IdOffertaTextBox1.Name = "IdOffertaTextBox1"
      Me.HelpProvider1.SetShowHelp(Me.IdOffertaTextBox1, True)
      Me.IdOffertaTextBox1.Size = New System.Drawing.Size(99, 24)
      Me.IdOffertaTextBox1.TabIndex = 0
      Me.IdOffertaTextBox1.TextValue = ""
      '
      'lblId
      '
      Me.lblId.AutoSize = True
      Me.lblId.BackColor = System.Drawing.Color.Transparent
      Me.lblId.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblId.Location = New System.Drawing.Point(305, 41)
      Me.lblId.Name = "lblId"
      Me.lblId.Size = New System.Drawing.Size(63, 13)
      Me.lblId.TabIndex = 0
      Me.lblId.Text = "Id domanda"
      '
      'NiceGroupBox1
      '
      Me.NiceGroupBox1.Controls.Add(Me.txtResults)
      Me.NiceGroupBox1.Controls.Add(Me.Label2)
      Me.NiceGroupBox1.Controls.Add(Me.Panel1)
      Me.NiceGroupBox1.Controls.Add(Me.TabControl1)
      Me.NiceGroupBox1.Location = New System.Drawing.Point(10, 155)
      Me.NiceGroupBox1.Name = "NiceGroupBox1"
      Me.NiceGroupBox1.Size = New System.Drawing.Size(528, 462)
      Me.NiceGroupBox1.TabIndex = 126
      Me.NiceGroupBox1.Title = "Risultati"
      '
      'txtResults
      '
      Me.HelpProvider1.SetHelpString(Me.txtResults, "Numero di risultati ottenuti dal report, ovvero numero di iscritti che offrono la" & _
              "voro che soddisferebbe potenzialmente la domanda di lavoro selezionata")
      Me.txtResults.Location = New System.Drawing.Point(356, 27)
      Me.txtResults.Name = "txtResults"
      Me.HelpProvider1.SetShowHelp(Me.txtResults, True)
      Me.txtResults.Size = New System.Drawing.Size(67, 21)
      Me.txtResults.TabIndex = 4
      Me.txtResults.Text = "0"
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Location = New System.Drawing.Point(224, 32)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(127, 13)
      Me.Label2.TabIndex = 3
      Me.Label2.Text = "Numero risultati ottenuti:"
      '
      'Panel1
      '
      Me.Panel1.BackColor = System.Drawing.Color.Transparent
      Me.Panel1.BackgroundImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.internalmenubar
      Me.Panel1.Controls.Add(Me.cmdUp)
      Me.Panel1.Controls.Add(Me.CmdDown)
      Me.Panel1.Controls.Add(Me.cmdDeselectAll)
      Me.Panel1.Controls.Add(Me.cmdSelectAll)
      Me.Panel1.Location = New System.Drawing.Point(429, 79)
      Me.Panel1.Name = "Panel1"
      Me.Panel1.Size = New System.Drawing.Size(79, 180)
      Me.Panel1.TabIndex = 11
      '
      'cmdUp
      '
      Me.cmdUp.ApplyOutLookStile = True
      Me.cmdUp.BackColor = System.Drawing.Color.Transparent
      Me.cmdUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.cmdUp.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.package_edutainment_48x48_down
      Me.cmdUp.Disabled = False
      Me.cmdUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.cmdUp.ForeColor = System.Drawing.Color.Transparent
      Me.cmdUp.ImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.cmdUp.Location = New System.Drawing.Point(14, 3)
      Me.cmdUp.Name = "cmdUp"
      Me.cmdUp.Radius = 48.0!
      Me.cmdUp.ShowTooltip = True
      Me.cmdUp.Size = New System.Drawing.Size(48, 48)
      Me.cmdUp.TabIndex = 0
      Me.cmdUp.TextValue = ""
      Me.cmdUp.TooltipText = "Ordina dall'alto"
      '
      'CmdDown
      '
      Me.CmdDown.ApplyOutLookStile = True
      Me.CmdDown.BackColor = System.Drawing.Color.Transparent
      Me.CmdDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.CmdDown.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.package_edutainment_48x48_up
      Me.CmdDown.Disabled = False
      Me.CmdDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.CmdDown.ForeColor = System.Drawing.Color.Transparent
      Me.CmdDown.ImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.CmdDown.Location = New System.Drawing.Point(14, 44)
      Me.CmdDown.Name = "CmdDown"
      Me.CmdDown.Radius = 48.0!
      Me.CmdDown.ShowTooltip = True
      Me.CmdDown.Size = New System.Drawing.Size(48, 48)
      Me.CmdDown.TabIndex = 1
      Me.CmdDown.TextValue = ""
      Me.CmdDown.TooltipText = "Ordina dal basso"
      '
      'cmdDeselectAll
      '
      Me.cmdDeselectAll.ApplyOutLookStile = True
      Me.cmdDeselectAll.BackColor = System.Drawing.Color.Transparent
      Me.cmdDeselectAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.cmdDeselectAll.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.kate_48x48_disabled
      Me.cmdDeselectAll.Disabled = False
      Me.cmdDeselectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.cmdDeselectAll.ForeColor = System.Drawing.Color.Transparent
      Me.HelpProvider1.SetHelpString(Me.cmdDeselectAll, "Funzione che permette di deselezionare tutti gli utenti della lista.")
      Me.cmdDeselectAll.ImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.cmdDeselectAll.Location = New System.Drawing.Point(16, 129)
      Me.cmdDeselectAll.Name = "cmdDeselectAll"
      Me.cmdDeselectAll.Radius = 48.0!
      Me.HelpProvider1.SetShowHelp(Me.cmdDeselectAll, True)
      Me.cmdDeselectAll.ShowTooltip = True
      Me.cmdDeselectAll.Size = New System.Drawing.Size(48, 48)
      Me.cmdDeselectAll.TabIndex = 3
      Me.cmdDeselectAll.TextValue = ""
      Me.cmdDeselectAll.TooltipText = "Deseleziona tutto"
      '
      'cmdSelectAll
      '
      Me.cmdSelectAll.ApplyOutLookStile = True
      Me.cmdSelectAll.BackColor = System.Drawing.Color.Transparent
      Me.cmdSelectAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.cmdSelectAll.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.kate_48x48
      Me.cmdSelectAll.Disabled = False
      Me.cmdSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.cmdSelectAll.ForeColor = System.Drawing.Color.Transparent
      Me.HelpProvider1.SetHelpString(Me.cmdSelectAll, "Funzione che permette di selezionare tutti gli utenti dalla lista.")
      Me.cmdSelectAll.ImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.cmdSelectAll.Location = New System.Drawing.Point(16, 86)
      Me.cmdSelectAll.Name = "cmdSelectAll"
      Me.cmdSelectAll.Radius = 48.0!
      Me.HelpProvider1.SetShowHelp(Me.cmdSelectAll, True)
      Me.cmdSelectAll.ShowTooltip = True
      Me.cmdSelectAll.Size = New System.Drawing.Size(48, 48)
      Me.cmdSelectAll.TabIndex = 2
      Me.cmdSelectAll.TextValue = ""
      Me.cmdSelectAll.TooltipText = "Seleziona tutto"
      '
      'NiceGroupBox2
      '
      Me.NiceGroupBox2.Controls.Add(Me.IdOffertaTextBox1)
      Me.NiceGroupBox2.Controls.Add(Me.cboSkill)
      Me.NiceGroupBox2.Controls.Add(Me.lblId)
      Me.NiceGroupBox2.Controls.Add(Me.Label1)
      Me.NiceGroupBox2.Location = New System.Drawing.Point(10, 80)
      Me.NiceGroupBox2.Name = "NiceGroupBox2"
      Me.NiceGroupBox2.Size = New System.Drawing.Size(528, 69)
      Me.NiceGroupBox2.TabIndex = 127
      Me.NiceGroupBox2.Title = "Dati selezione"
      '
      'cmdListaLavoro
      '
      Me.cmdListaLavoro.ApplyOutLookStile = True
      Me.cmdListaLavoro.BackColor = System.Drawing.Color.Transparent
      Me.cmdListaLavoro.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.k_jots_32x32
      Me.cmdListaLavoro.Disabled = False
      Me.cmdListaLavoro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.cmdListaLavoro.ForeColor = System.Drawing.Color.Transparent
      Me.HelpProvider1.SetHelpString(Me.cmdListaLavoro, "Funzione che permette di inserire gli utenti selezionati dalla lista degli utenti" & _
              ", in una lista di lavoro ")
      Me.cmdListaLavoro.ImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.cmdListaLavoro.Location = New System.Drawing.Point(130, 5)
      Me.cmdListaLavoro.Name = "cmdListaLavoro"
      Me.cmdListaLavoro.Radius = 32.0!
      Me.HelpProvider1.SetShowHelp(Me.cmdListaLavoro, True)
      Me.cmdListaLavoro.ShowTooltip = True
      Me.cmdListaLavoro.Size = New System.Drawing.Size(32, 32)
      Me.cmdListaLavoro.TabIndex = 3
      Me.cmdListaLavoro.TextValue = ""
      Me.cmdListaLavoro.TooltipText = "Crea lista di lavoro"
      '
      'cmdProp
      '
      Me.cmdProp.ApplyOutLookStile = True
      Me.cmdProp.BackColor = System.Drawing.Color.Transparent
      Me.cmdProp.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.desktop_32x32
      Me.cmdProp.Disabled = False
      Me.cmdProp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.cmdProp.ForeColor = System.Drawing.Color.Transparent
      Me.HelpProvider1.SetHelpString(Me.cmdProp, "Funzione che permette di creare proposte di lavoro agli iscritti selezionati dall" & _
              "a lista degli utenti le cui offerte di lavoro incontrano la domanda di lavoro.")
      Me.cmdProp.ImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.cmdProp.Location = New System.Drawing.Point(86, 7)
      Me.cmdProp.Name = "cmdProp"
      Me.cmdProp.Radius = 32.0!
      Me.HelpProvider1.SetShowHelp(Me.cmdProp, True)
      Me.cmdProp.ShowTooltip = True
      Me.cmdProp.Size = New System.Drawing.Size(32, 32)
      Me.cmdProp.TabIndex = 2
      Me.cmdProp.TextValue = ""
      Me.cmdProp.TooltipText = "Crea proposte di lavoro"
      '
      'CmdVis
      '
      Me.CmdVis.ApplyOutLookStile = True
      Me.CmdVis.BackColor = System.Drawing.Color.Transparent
      Me.CmdVis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.CmdVis.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.k_ghost_view_32x32
      Me.CmdVis.Disabled = False
      Me.CmdVis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.CmdVis.ForeColor = System.Drawing.Color.Transparent
      Me.HelpProvider1.SetHelpString(Me.CmdVis, "Funzione che avvia la ricerca di offerte di lavoro che soddisfano la domanda di l" & _
              "avoro.")
      Me.CmdVis.ImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.CmdVis.Location = New System.Drawing.Point(14, 6)
      Me.CmdVis.Name = "CmdVis"
      Me.CmdVis.Radius = 32.0!
      Me.CmdVis.RightToLeft = System.Windows.Forms.RightToLeft.Yes
      Me.HelpProvider1.SetShowHelp(Me.CmdVis, True)
      Me.CmdVis.ShowTooltip = True
      Me.CmdVis.Size = New System.Drawing.Size(32, 32)
      Me.CmdVis.TabIndex = 0
      Me.CmdVis.TextValue = ""
      Me.CmdVis.TooltipText = "Esegui analisi"
      '
      'ControlAnalisiDomandaLavoro
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.Controls.Add(Me.NiceGroupBox2)
      Me.Controls.Add(Me.NiceGroupBox1)
      Me.Name = "ControlAnalisiDomandaLavoro"
      Me.Size = New System.Drawing.Size(512, 554)
      Me.Controls.SetChildIndex(Me.DockPanel, 0)
      Me.Controls.SetChildIndex(Me.Panel2, 0)
      Me.Controls.SetChildIndex(Me.NiceGroupBox1, 0)
      Me.Controls.SetChildIndex(Me.NiceGroupBox2, 0)
      Me.DockPanel.ResumeLayout(False)
      Me.TabControl1.ResumeLayout(False)
      Me.TabPage1.ResumeLayout(False)
      CType(Me.GridUtenti, System.ComponentModel.ISupportInitialize).EndInit()
      Me.NiceGroupBox1.ResumeLayout(False)
      Me.NiceGroupBox1.PerformLayout()
      Me.Panel1.ResumeLayout(False)
      Me.NiceGroupBox2.ResumeLayout(False)
      Me.NiceGroupBox2.PerformLayout()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
   Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
   Friend WithEvents GridUtenti As System.Windows.Forms.DataGridView
   Friend WithEvents CmdVis As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents cmdProp As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents IdOffertaTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdOffertaTextBox
   Friend WithEvents lblId As System.Windows.Forms.Label
   Friend WithEvents cmdDeselectAll As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents cmdSelectAll As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents CmdDown As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents cmdUp As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents cboSkill As System.Windows.Forms.ComboBox
    Friend WithEvents cmdListaLavoro As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents NiceGroupBox1 As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents Panel1 As System.Windows.Forms.Panel
   Friend WithEvents NiceGroupBox2 As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents txtResults As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider

End Class
