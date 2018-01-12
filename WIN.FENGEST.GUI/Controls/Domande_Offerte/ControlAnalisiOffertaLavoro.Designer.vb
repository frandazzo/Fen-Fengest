<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlAnalisiOffertaLavoro
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlAnalisiOffertaLavoro))
      Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Me.IdAziendaTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdAziendaTextBox
      Me.Label2 = New System.Windows.Forms.Label
      Me.chkDoc = New System.Windows.Forms.CheckBox
      Me.chkReg = New System.Windows.Forms.CheckBox
      Me.dtpDocDa = New System.Windows.Forms.DateTimePicker
      Me.Label9 = New System.Windows.Forms.Label
      Me.Label4 = New System.Windows.Forms.Label
      Me.dtpRegA = New System.Windows.Forms.DateTimePicker
      Me.dtpRegDa = New System.Windows.Forms.DateTimePicker
      Me.cboPref = New System.Windows.Forms.ComboBox
      Me.IdUtenteTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdUtenteTextBox
      Me.lblId = New System.Windows.Forms.Label
      Me.Label1 = New System.Windows.Forms.Label
      Me.TabControl1 = New System.Windows.Forms.TabControl
      Me.TabPage1 = New System.Windows.Forms.TabPage
      Me.GridOfferte = New System.Windows.Forms.DataGridView
      Me.GroupBox3 = New WIN.GUI.UTILITY.NiceGroupBox
      Me.NiceGroupBox1 = New WIN.GUI.UTILITY.NiceGroupBox
      Me.Panel1 = New System.Windows.Forms.Panel
      Me.cmdUp = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.CmdDown = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.cmdSelectAll = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.cmdDeselectAll = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.txtResults = New System.Windows.Forms.TextBox
      Me.Label3 = New System.Windows.Forms.Label
      Me.NiceGroupBox2 = New WIN.GUI.UTILITY.NiceGroupBox
      Me.lblDescrizioneAzienda = New System.Windows.Forms.Label
      Me.cmdProp = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.cmdPrint = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.CmdVis = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
      Me.DockPanel.SuspendLayout()
      Me.TabControl1.SuspendLayout()
      Me.TabPage1.SuspendLayout()
      CType(Me.GridOfferte, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.GroupBox3.SuspendLayout()
      Me.NiceGroupBox1.SuspendLayout()
      Me.Panel1.SuspendLayout()
      Me.NiceGroupBox2.SuspendLayout()
      Me.SuspendLayout()
      '
      'Panel2
      '
      Me.Panel2.Size = New System.Drawing.Size(597, 26)
      '
      'DockPanel
      '
      Me.DockPanel.Controls.Add(Me.cmdProp)
      Me.DockPanel.Controls.Add(Me.cmdPrint)
      Me.DockPanel.Controls.Add(Me.CmdVis)
      Me.DockPanel.Location = New System.Drawing.Point(0, 26)
      Me.DockPanel.Size = New System.Drawing.Size(597, 44)
      '
      'IdAziendaTextBox1
      '
      Me.IdAziendaTextBox1.BackColor = System.Drawing.Color.Transparent
      Me.IdAziendaTextBox1.DescriptionOfText = ""
      Me.IdAziendaTextBox1.DescriptionTextWidth = 150
      Me.IdAziendaTextBox1.DescriptionTextXValue = 92
      Me.IdAziendaTextBox1.EnableSerchTextBox = True
      Me.HelpProvider1.SetHelpString(Me.IdAziendaTextBox1, resources.GetString("IdAziendaTextBox1.HelpString"))
      Me.IdAziendaTextBox1.IsDescriptionVisible = False
      Me.IdAziendaTextBox1.Location = New System.Drawing.Point(79, 95)
      Me.IdAziendaTextBox1.Mandatory = False
      Me.IdAziendaTextBox1.Margin = New System.Windows.Forms.Padding(0)
      Me.IdAziendaTextBox1.Name = "IdAziendaTextBox1"
      Me.HelpProvider1.SetShowHelp(Me.IdAziendaTextBox1, True)
      Me.IdAziendaTextBox1.Size = New System.Drawing.Size(92, 24)
      Me.IdAziendaTextBox1.TabIndex = 74
      Me.IdAziendaTextBox1.TextValue = ""
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Location = New System.Drawing.Point(19, 103)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(57, 13)
      Me.Label2.TabIndex = 73
      Me.Label2.Text = "Id azienda"
      '
      'chkDoc
      '
      Me.chkDoc.AutoSize = True
      Me.chkDoc.BackColor = System.Drawing.Color.Transparent
      Me.HelpProvider1.SetHelpString(Me.chkDoc, "Spuntare questa casella nel caso in cui si vogliono selezionare le domande di lav" & _
              "oro che rispondono all'offerta selezionata in base alla data di registrazione de" & _
              "lla domanda di lavoro.")
      Me.chkDoc.Location = New System.Drawing.Point(22, 30)
      Me.chkDoc.Name = "chkDoc"
      Me.HelpProvider1.SetShowHelp(Me.chkDoc, True)
      Me.chkDoc.Size = New System.Drawing.Size(116, 17)
      Me.chkDoc.TabIndex = 72
      Me.chkDoc.Text = "Sel. data domanda"
      Me.chkDoc.UseVisualStyleBackColor = False
      '
      'chkReg
      '
      Me.chkReg.AutoSize = True
      Me.chkReg.BackColor = System.Drawing.Color.Transparent
      Me.HelpProvider1.SetHelpString(Me.chkReg, "Spuntare questa casella nel caso in cui si vogliono selezionare le domande di lav" & _
              "oro, che rispondono all'offerta selezionata, in base al periodo di validità dell" & _
              "a domanda.")
      Me.chkReg.Location = New System.Drawing.Point(22, 60)
      Me.chkReg.Name = "chkReg"
      Me.HelpProvider1.SetShowHelp(Me.chkReg, True)
      Me.chkReg.Size = New System.Drawing.Size(128, 17)
      Me.chkReg.TabIndex = 71
      Me.chkReg.Text = "Sel. validità domanda"
      Me.chkReg.UseVisualStyleBackColor = False
      '
      'dtpDocDa
      '
      Me.dtpDocDa.Enabled = False
      Me.dtpDocDa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.HelpProvider1.SetHelpString(Me.dtpDocDa, "Data di registrazione della domanda di lavoro")
      Me.dtpDocDa.Location = New System.Drawing.Point(196, 26)
      Me.dtpDocDa.Name = "dtpDocDa"
      Me.HelpProvider1.SetShowHelp(Me.dtpDocDa, True)
      Me.dtpDocDa.Size = New System.Drawing.Size(99, 21)
      Me.dtpDocDa.TabIndex = 70
      '
      'Label9
      '
      Me.Label9.AutoSize = True
      Me.Label9.BackColor = System.Drawing.Color.Transparent
      Me.Label9.Location = New System.Drawing.Point(306, 61)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(13, 13)
      Me.Label9.TabIndex = 69
      Me.Label9.Text = "a"
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Location = New System.Drawing.Point(171, 62)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(19, 13)
      Me.Label4.TabIndex = 68
      Me.Label4.Text = "da"
      '
      'dtpRegA
      '
      Me.dtpRegA.Enabled = False
      Me.dtpRegA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.HelpProvider1.SetHelpString(Me.dtpRegA, "Data fine validità domanda di lavoro")
      Me.dtpRegA.Location = New System.Drawing.Point(325, 57)
      Me.dtpRegA.Name = "dtpRegA"
      Me.HelpProvider1.SetShowHelp(Me.dtpRegA, True)
      Me.dtpRegA.Size = New System.Drawing.Size(99, 21)
      Me.dtpRegA.TabIndex = 67
      '
      'dtpRegDa
      '
      Me.dtpRegDa.Enabled = False
      Me.dtpRegDa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.HelpProvider1.SetHelpString(Me.dtpRegDa, "Data inizio validità domanda di lavoro")
      Me.dtpRegDa.Location = New System.Drawing.Point(196, 58)
      Me.dtpRegDa.Name = "dtpRegDa"
      Me.HelpProvider1.SetShowHelp(Me.dtpRegDa, True)
      Me.dtpRegDa.Size = New System.Drawing.Size(99, 21)
      Me.dtpRegDa.TabIndex = 66
      '
      'cboPref
      '
      Me.cboPref.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cboPref.FormattingEnabled = True
      Me.HelpProvider1.SetHelpString(Me.cboPref, resources.GetString("cboPref.HelpString"))
      Me.cboPref.Location = New System.Drawing.Point(73, 67)
      Me.cboPref.Name = "cboPref"
      Me.HelpProvider1.SetShowHelp(Me.cboPref, True)
      Me.cboPref.Size = New System.Drawing.Size(200, 21)
      Me.cboPref.TabIndex = 8
      '
      'IdUtenteTextBox1
      '
      Me.IdUtenteTextBox1.BackColor = System.Drawing.Color.Transparent
      Me.IdUtenteTextBox1.DescriptionOfText = ""
      Me.IdUtenteTextBox1.DescriptionTextWidth = 150
      Me.IdUtenteTextBox1.DescriptionTextXValue = 92
      Me.IdUtenteTextBox1.EnableSerchTextBox = True
      Me.HelpProvider1.SetHelpString(Me.IdUtenteTextBox1, "Identificativo dell'utente per cui si vuole cercare una possibile proposta di lav" & _
              "oro")
      Me.IdUtenteTextBox1.IsDescriptionVisible = False
      Me.IdUtenteTextBox1.Location = New System.Drawing.Point(73, 31)
      Me.IdUtenteTextBox1.Mandatory = False
      Me.IdUtenteTextBox1.Margin = New System.Windows.Forms.Padding(0)
      Me.IdUtenteTextBox1.Name = "IdUtenteTextBox1"
      Me.HelpProvider1.SetShowHelp(Me.IdUtenteTextBox1, True)
      Me.IdUtenteTextBox1.Size = New System.Drawing.Size(99, 24)
      Me.IdUtenteTextBox1.TabIndex = 7
      Me.IdUtenteTextBox1.TextValue = ""
      '
      'lblId
      '
      Me.lblId.AutoSize = True
      Me.lblId.Location = New System.Drawing.Point(18, 38)
      Me.lblId.Name = "lblId"
      Me.lblId.Size = New System.Drawing.Size(52, 13)
      Me.lblId.TabIndex = 4
      Me.lblId.Text = "Id utente"
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Location = New System.Drawing.Point(22, 70)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(43, 13)
      Me.Label1.TabIndex = 5
      Me.Label1.Text = "Offerta"
      '
      'TabControl1
      '
      Me.TabControl1.Controls.Add(Me.TabPage1)
      Me.TabControl1.Location = New System.Drawing.Point(15, 59)
      Me.TabControl1.Name = "TabControl1"
      Me.TabControl1.SelectedIndex = 0
      Me.TabControl1.Size = New System.Drawing.Size(426, 210)
      Me.TabControl1.TabIndex = 124
      '
      'TabPage1
      '
      Me.TabPage1.Controls.Add(Me.GridOfferte)
      Me.TabPage1.Location = New System.Drawing.Point(4, 22)
      Me.TabPage1.Name = "TabPage1"
      Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
      Me.TabPage1.Size = New System.Drawing.Size(418, 184)
      Me.TabPage1.TabIndex = 0
      Me.TabPage1.Text = "Lista domande"
      Me.TabPage1.UseVisualStyleBackColor = True
      '
      'GridOfferte
      '
      Me.GridOfferte.AllowUserToAddRows = False
      Me.GridOfferte.AllowUserToDeleteRows = False
      DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue
      DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
      DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange
      DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
      Me.GridOfferte.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
      Me.GridOfferte.BackgroundColor = System.Drawing.Color.White
      Me.GridOfferte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.GridOfferte.Dock = System.Windows.Forms.DockStyle.Fill
      Me.GridOfferte.Location = New System.Drawing.Point(3, 3)
      Me.GridOfferte.Name = "GridOfferte"
      Me.GridOfferte.ReadOnly = True
      Me.GridOfferte.RowHeadersVisible = False
      DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
      DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Orange
      DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
      Me.GridOfferte.RowsDefaultCellStyle = DataGridViewCellStyle2
      Me.GridOfferte.Size = New System.Drawing.Size(412, 178)
      Me.GridOfferte.TabIndex = 0
      '
      'GroupBox3
      '
      Me.GroupBox3.Controls.Add(Me.cboPref)
      Me.GroupBox3.Controls.Add(Me.Label1)
      Me.GroupBox3.Controls.Add(Me.IdUtenteTextBox1)
      Me.GroupBox3.Controls.Add(Me.lblId)
      Me.GroupBox3.Location = New System.Drawing.Point(11, 76)
      Me.GroupBox3.Name = "GroupBox3"
      Me.GroupBox3.Size = New System.Drawing.Size(464, 106)
      Me.GroupBox3.TabIndex = 133
      Me.GroupBox3.Title = "Dati selezione offerta"
      '
      'NiceGroupBox1
      '
      Me.NiceGroupBox1.Controls.Add(Me.Panel1)
      Me.NiceGroupBox1.Controls.Add(Me.txtResults)
      Me.NiceGroupBox1.Controls.Add(Me.Label3)
      Me.NiceGroupBox1.Controls.Add(Me.TabControl1)
      Me.NiceGroupBox1.Location = New System.Drawing.Point(11, 329)
      Me.NiceGroupBox1.Name = "NiceGroupBox1"
      Me.NiceGroupBox1.Size = New System.Drawing.Size(555, 288)
      Me.NiceGroupBox1.TabIndex = 0
      Me.NiceGroupBox1.Title = "Lista Domande"
      '
      'Panel1
      '
      Me.Panel1.BackColor = System.Drawing.Color.Transparent
      Me.Panel1.BackgroundImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.internalmenubar
      Me.Panel1.Controls.Add(Me.cmdUp)
      Me.Panel1.Controls.Add(Me.CmdDown)
      Me.Panel1.Controls.Add(Me.cmdSelectAll)
      Me.Panel1.Controls.Add(Me.cmdDeselectAll)
      Me.Panel1.Location = New System.Drawing.Point(451, 84)
      Me.Panel1.Name = "Panel1"
      Me.Panel1.Size = New System.Drawing.Size(79, 180)
      Me.Panel1.TabIndex = 133
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
      Me.HelpProvider1.SetHelpString(Me.cmdUp, "Funzione che permette di visualizzare la lista delle domande disposte in ordine a" & _
              "lfabetico")
      Me.cmdUp.ImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.cmdUp.Location = New System.Drawing.Point(14, 5)
      Me.cmdUp.Name = "cmdUp"
      Me.cmdUp.Radius = 48.0!
      Me.HelpProvider1.SetShowHelp(Me.cmdUp, True)
      Me.cmdUp.ShowTooltip = True
      Me.cmdUp.Size = New System.Drawing.Size(48, 48)
      Me.cmdUp.TabIndex = 129
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
      Me.HelpProvider1.SetHelpString(Me.CmdDown, "Funzione che permette di visualizzare la lista delle domande disposte in ordine a" & _
              "lfabetico inverso")
      Me.CmdDown.ImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.CmdDown.Location = New System.Drawing.Point(14, 46)
      Me.CmdDown.Name = "CmdDown"
      Me.CmdDown.Radius = 48.0!
      Me.HelpProvider1.SetShowHelp(Me.CmdDown, True)
      Me.CmdDown.ShowTooltip = True
      Me.CmdDown.Size = New System.Drawing.Size(48, 48)
      Me.CmdDown.TabIndex = 130
      Me.CmdDown.TextValue = ""
      Me.CmdDown.TooltipText = "Ordina dal basso"
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
      Me.HelpProvider1.SetHelpString(Me.cmdSelectAll, "Funzione che permette di selezionare tutte le domande dalla lista")
      Me.cmdSelectAll.ImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.cmdSelectAll.Location = New System.Drawing.Point(15, 88)
      Me.cmdSelectAll.Name = "cmdSelectAll"
      Me.cmdSelectAll.Radius = 48.0!
      Me.HelpProvider1.SetShowHelp(Me.cmdSelectAll, True)
      Me.cmdSelectAll.ShowTooltip = True
      Me.cmdSelectAll.Size = New System.Drawing.Size(48, 48)
      Me.cmdSelectAll.TabIndex = 131
      Me.cmdSelectAll.TextValue = ""
      Me.cmdSelectAll.TooltipText = "Seleziona tutto"
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
      Me.HelpProvider1.SetHelpString(Me.cmdDeselectAll, "Funzione che permette di deselezionare tutte le domande dalla lista")
      Me.cmdDeselectAll.ImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.cmdDeselectAll.Location = New System.Drawing.Point(17, 129)
      Me.cmdDeselectAll.Name = "cmdDeselectAll"
      Me.cmdDeselectAll.Radius = 48.0!
      Me.HelpProvider1.SetShowHelp(Me.cmdDeselectAll, True)
      Me.cmdDeselectAll.ShowTooltip = True
      Me.cmdDeselectAll.Size = New System.Drawing.Size(48, 48)
      Me.cmdDeselectAll.TabIndex = 132
      Me.cmdDeselectAll.TextValue = ""
      Me.cmdDeselectAll.TooltipText = "Deseleziona tutto"
      '
      'txtResults
      '
      Me.txtResults.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.HelpProvider1.SetHelpString(Me.txtResults, "Numero di risultati ottenuti dall'analisi, ovvero il numero di domande di lavoro " & _
              "che rispondono all'offerta di lavoro,in base ai criteri di selezione impostati.")
      Me.txtResults.Location = New System.Drawing.Point(375, 30)
      Me.txtResults.Name = "txtResults"
      Me.HelpProvider1.SetShowHelp(Me.txtResults, True)
      Me.txtResults.Size = New System.Drawing.Size(50, 21)
      Me.txtResults.TabIndex = 76
      Me.txtResults.Text = "0"
      '
      'Label3
      '
      Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label3.AutoSize = True
      Me.Label3.Location = New System.Drawing.Point(243, 35)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(127, 13)
      Me.Label3.TabIndex = 75
      Me.Label3.Text = "Numero risultati ottenuti:"
      '
      'NiceGroupBox2
      '
      Me.NiceGroupBox2.Controls.Add(Me.lblDescrizioneAzienda)
      Me.NiceGroupBox2.Controls.Add(Me.IdAziendaTextBox1)
      Me.NiceGroupBox2.Controls.Add(Me.Label9)
      Me.NiceGroupBox2.Controls.Add(Me.Label4)
      Me.NiceGroupBox2.Controls.Add(Me.dtpDocDa)
      Me.NiceGroupBox2.Controls.Add(Me.Label2)
      Me.NiceGroupBox2.Controls.Add(Me.dtpRegA)
      Me.NiceGroupBox2.Controls.Add(Me.chkDoc)
      Me.NiceGroupBox2.Controls.Add(Me.chkReg)
      Me.NiceGroupBox2.Controls.Add(Me.dtpRegDa)
      Me.NiceGroupBox2.Location = New System.Drawing.Point(12, 187)
      Me.NiceGroupBox2.Name = "NiceGroupBox2"
      Me.NiceGroupBox2.Size = New System.Drawing.Size(463, 134)
      Me.NiceGroupBox2.TabIndex = 135
      Me.NiceGroupBox2.Title = "Dati selezione domande"
      '
      'lblDescrizioneAzienda
      '
      Me.lblDescrizioneAzienda.AutoSize = True
      Me.lblDescrizioneAzienda.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblDescrizioneAzienda.Location = New System.Drawing.Point(183, 102)
      Me.lblDescrizioneAzienda.Name = "lblDescrizioneAzienda"
      Me.lblDescrizioneAzienda.Size = New System.Drawing.Size(0, 13)
      Me.lblDescrizioneAzienda.TabIndex = 77
      '
      'cmdProp
      '
      Me.cmdProp.ApplyOutLookStile = True
      Me.cmdProp.BackColor = System.Drawing.Color.Transparent
      Me.cmdProp.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.desktop_32x32
      Me.cmdProp.Disabled = False
      Me.cmdProp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.cmdProp.ForeColor = System.Drawing.Color.Transparent
      Me.HelpProvider1.SetHelpString(Me.cmdProp, "Funzione che permette di creare una o più proposte di lavoro all'utente inserito." & _
              " Il sistema crea una proposta di lavoro per ognuna delle domande selezionate dal" & _
              "la lista")
      Me.cmdProp.ImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.cmdProp.Location = New System.Drawing.Point(105, 6)
      Me.cmdProp.Name = "cmdProp"
      Me.cmdProp.Radius = 32.0!
      Me.HelpProvider1.SetShowHelp(Me.cmdProp, True)
      Me.cmdProp.ShowTooltip = True
      Me.cmdProp.Size = New System.Drawing.Size(32, 32)
      Me.cmdProp.TabIndex = 127
      Me.cmdProp.TextValue = ""
      Me.cmdProp.TooltipText = "Crea proposte di lavoro"
      '
      'cmdPrint
      '
      Me.cmdPrint.ApplyOutLookStile = True
      Me.cmdPrint.BackColor = System.Drawing.Color.Transparent
      Me.cmdPrint.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.print_32x32_active
      Me.cmdPrint.Disabled = False
      Me.cmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.cmdPrint.ForeColor = System.Drawing.Color.Transparent
      Me.cmdPrint.ImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.cmdPrint.Location = New System.Drawing.Point(64, 6)
      Me.cmdPrint.Name = "cmdPrint"
      Me.cmdPrint.Radius = 32.0!
      Me.cmdPrint.ShowTooltip = True
      Me.cmdPrint.Size = New System.Drawing.Size(32, 32)
      Me.cmdPrint.TabIndex = 126
      Me.cmdPrint.TextValue = ""
      Me.cmdPrint.TooltipText = "Stampa report"
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
      Me.HelpProvider1.SetHelpString(Me.CmdVis, "Funzione che avvia la ricerca di domande di lavoro che rispondono ai criteri di s" & _
              "elezione impostati.")
      Me.CmdVis.ImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.CmdVis.Location = New System.Drawing.Point(12, 6)
      Me.CmdVis.Name = "CmdVis"
      Me.CmdVis.Radius = 32.0!
      Me.HelpProvider1.SetShowHelp(Me.CmdVis, True)
      Me.CmdVis.ShowTooltip = True
      Me.CmdVis.Size = New System.Drawing.Size(32, 32)
      Me.CmdVis.TabIndex = 125
      Me.CmdVis.TextValue = ""
      Me.CmdVis.TooltipText = "Esegui analisi"
      '
      'ControlAnalisiOffertaLavoro
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.Controls.Add(Me.NiceGroupBox2)
      Me.Controls.Add(Me.NiceGroupBox1)
      Me.Controls.Add(Me.GroupBox3)
      Me.Name = "ControlAnalisiOffertaLavoro"
      Me.Size = New System.Drawing.Size(597, 620)
      Me.Controls.SetChildIndex(Me.DockPanel, 0)
      Me.Controls.SetChildIndex(Me.Panel2, 0)
      Me.Controls.SetChildIndex(Me.GroupBox3, 0)
      Me.Controls.SetChildIndex(Me.NiceGroupBox1, 0)
      Me.Controls.SetChildIndex(Me.NiceGroupBox2, 0)
      Me.DockPanel.ResumeLayout(False)
      Me.TabControl1.ResumeLayout(False)
      Me.TabPage1.ResumeLayout(False)
      CType(Me.GridOfferte, System.ComponentModel.ISupportInitialize).EndInit()
      Me.GroupBox3.ResumeLayout(False)
      Me.GroupBox3.PerformLayout()
      Me.NiceGroupBox1.ResumeLayout(False)
      Me.NiceGroupBox1.PerformLayout()
      Me.Panel1.ResumeLayout(False)
      Me.NiceGroupBox2.ResumeLayout(False)
      Me.NiceGroupBox2.PerformLayout()
      Me.ResumeLayout(False)

   End Sub
    Friend WithEvents cmdDeselectAll As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents cmdSelectAll As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents CmdDown As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents cmdUp As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents cmdProp As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents cmdPrint As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents CmdVis As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GridOfferte As System.Windows.Forms.DataGridView
    Friend WithEvents IdUtenteTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdUtenteTextBox
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents IdAziendaTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdAziendaTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkDoc As System.Windows.Forms.CheckBox
    Friend WithEvents chkReg As System.Windows.Forms.CheckBox
    Friend WithEvents dtpDocDa As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpRegA As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpRegDa As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboPref As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox3 As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents NiceGroupBox1 As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents Panel1 As System.Windows.Forms.Panel
   Friend WithEvents txtResults As System.Windows.Forms.TextBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents NiceGroupBox2 As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents lblDescrizioneAzienda As System.Windows.Forms.Label
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider

End Class
