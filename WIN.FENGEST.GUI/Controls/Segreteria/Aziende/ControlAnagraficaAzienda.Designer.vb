<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlAnagraficaAzienda
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUltimaCompetenza = New System.Windows.Forms.Label()
        Me.cboContratti = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSettore = New System.Windows.Forms.Label()
        Me.cboSettori = New System.Windows.Forms.ComboBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CustomBar1 = New WIN.GUI.APPLICATION.PRESENTATION.CustomBar()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GridSedi = New System.Windows.Forms.DataGridView()
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
        Me.IdAziendaTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdAziendaTextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.GrpSed = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.sedimenu = New System.Windows.Forms.Panel()
        Me.CmdSel = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.CmdAdd = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.CmdDel = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.grpRag = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdCAP = New System.Windows.Forms.Button()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.txtFax = New System.Windows.Forms.TextBox()
        Me.txtCell2 = New System.Windows.Forms.TextBox()
        Me.txtTelUf = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtCell1 = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtResp = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtNote = New WIN.GUI.UTILITY.UsabilityTextBox()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.txtEC = New WIN.GUI.UTILITY.UsabilityTextBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.txtCE = New WIN.GUI.UTILITY.UsabilityTextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.SpNew = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.NiceGroupBox1 = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.cmdCantieri = New System.Windows.Forms.Button()
        Me.spDoc1 = New System.Windows.Forms.Button()
        Me.spIscritti1 = New System.Windows.Forms.Button()
        Me.spArchivio1 = New System.Windows.Forms.Button()
        Me.cmdGoToOfferte1 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DockPanel.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.GridSedi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpSed.SuspendLayout()
        Me.sedimenu.SuspendLayout()
        Me.grpRag.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.NiceGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Size = New System.Drawing.Size(869, 26)
        '
        'DockPanel
        '
        Me.DockPanel.Controls.Add(Me.SpNew)
        Me.DockPanel.Controls.Add(Me.lblId)
        Me.DockPanel.Controls.Add(Me.IdAziendaTextBox1)
        Me.DockPanel.Controls.Add(Me.CustomBar1)
        Me.DockPanel.Location = New System.Drawing.Point(0, 26)
        Me.DockPanel.Size = New System.Drawing.Size(869, 44)
        Me.DockPanel.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 210)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "La competenza dell'ultimo pagamento è:"
        '
        'lblUltimaCompetenza
        '
        Me.lblUltimaCompetenza.AutoSize = True
        Me.lblUltimaCompetenza.Location = New System.Drawing.Point(213, 210)
        Me.lblUltimaCompetenza.Name = "lblUltimaCompetenza"
        Me.lblUltimaCompetenza.Size = New System.Drawing.Size(25, 13)
        Me.lblUltimaCompetenza.TabIndex = 19
        Me.lblUltimaCompetenza.Text = "***"
        '
        'cboContratti
        '
        Me.cboContratti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboContratti.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboContratti.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboContratti, "Contratto a cui l'azienda aderisce.I contratti sono visualizzati in base al setto" & _
        "re selezionato")
        Me.cboContratti.Location = New System.Drawing.Point(347, 165)
        Me.cboContratti.Name = "cboContratti"
        Me.HelpProvider1.SetShowHelp(Me.cboContratti, True)
        Me.cboContratti.Size = New System.Drawing.Size(210, 21)
        Me.cboContratti.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(277, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Contr. app."
        '
        'lblSettore
        '
        Me.lblSettore.AutoSize = True
        Me.lblSettore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSettore.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettore.Location = New System.Drawing.Point(35, 173)
        Me.lblSettore.Name = "lblSettore"
        Me.lblSettore.Size = New System.Drawing.Size(41, 13)
        Me.lblSettore.TabIndex = 14
        Me.lblSettore.Text = "Settore"
        '
        'cboSettori
        '
        Me.cboSettori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSettori.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSettori.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboSettori, "Settore di appartenenza dell'azienda. I settori possono essere EDILE e IMPIANTI F" & _
        "ISSI")
        Me.cboSettori.Location = New System.Drawing.Point(79, 165)
        Me.cboSettori.Name = "cboSettori"
        Me.HelpProvider1.SetShowHelp(Me.cboSettori, True)
        Me.cboSettori.Size = New System.Drawing.Size(161, 21)
        Me.cboSettori.TabIndex = 15
        '
        'txtNome
        '
        Me.txtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtNome, "Ragione sociale dell'azienda")
        Me.txtNome.Location = New System.Drawing.Point(80, 14)
        Me.txtNome.Name = "txtNome"
        Me.HelpProvider1.SetShowHelp(Me.txtNome, True)
        Me.txtNome.Size = New System.Drawing.Size(232, 20)
        Me.txtNome.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Rag. soc."
        '
        'CustomBar1
        '
        Me.CustomBar1.BackColor = System.Drawing.Color.Transparent
        Me.CustomBar1.Location = New System.Drawing.Point(163, 3)
        Me.CustomBar1.Name = "CustomBar1"
        Me.CustomBar1.Size = New System.Drawing.Size(297, 40)
        Me.CustomBar1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(10, 23)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(495, 191)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GridSedi)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(487, 165)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Sedi operative"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GridSedi
        '
        Me.GridSedi.AllowUserToAddRows = False
        Me.GridSedi.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.GridSedi.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GridSedi.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.GridSedi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridSedi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridSedi.Location = New System.Drawing.Point(3, 3)
        Me.GridSedi.Name = "GridSedi"
        Me.GridSedi.RowHeadersVisible = False
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.GridSedi.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.GridSedi.Size = New System.Drawing.Size(481, 159)
        Me.GridSedi.TabIndex = 0
        '
        'txtCap
        '
        Me.txtCap.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtCap, "CAP dell'indirizzo di residenza della sede legale dell'azienda")
        Me.txtCap.Location = New System.Drawing.Point(382, 106)
        Me.txtCap.Name = "txtCap"
        Me.HelpProvider1.SetShowHelp(Me.txtCap, True)
        Me.txtCap.Size = New System.Drawing.Size(127, 20)
        Me.txtCap.TabIndex = 11
        '
        'txtVia
        '
        Me.txtVia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtVia, "Indirizzo della sede legale dell'azienda")
        Me.txtVia.Location = New System.Drawing.Point(79, 107)
        Me.txtVia.Name = "txtVia"
        Me.HelpProvider1.SetShowHelp(Me.txtVia, True)
        Me.txtVia.Size = New System.Drawing.Size(233, 20)
        Me.txtVia.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(22, 46)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Provincia"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(348, 112)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "CAP"
        '
        'cboProvincia
        '
        Me.cboProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProvincia.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboProvincia, "Provincia di residenza della sede legale dell'azienda")
        Me.cboProvincia.Location = New System.Drawing.Point(80, 43)
        Me.cboProvincia.Name = "cboProvincia"
        Me.HelpProvider1.SetShowHelp(Me.cboProvincia, True)
        Me.cboProvincia.Size = New System.Drawing.Size(187, 21)
        Me.cboProvincia.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(28, 109)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Indirizzo"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(30, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Comune"
        '
        'cboComune
        '
        Me.cboComune.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboComune.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboComune, "Comune di residenza della sede legale dell'azienda")
        Me.cboComune.Location = New System.Drawing.Point(79, 73)
        Me.cboComune.Name = "cboComune"
        Me.HelpProvider1.SetShowHelp(Me.cboComune, True)
        Me.cboComune.Size = New System.Drawing.Size(187, 21)
        Me.cboComune.TabIndex = 7
        '
        'txtPIva
        '
        Me.txtPIva.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtPIva, "Partita Iva dell'azienda")
        Me.txtPIva.Location = New System.Drawing.Point(382, 14)
        Me.txtPIva.Name = "txtPIva"
        Me.HelpProvider1.SetShowHelp(Me.txtPIva, True)
        Me.txtPIva.Size = New System.Drawing.Size(127, 20)
        Me.txtPIva.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(341, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "P. Iva"
        '
        'IdAziendaTextBox1
        '
        Me.IdAziendaTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.IdAziendaTextBox1.DescriptionOfText = ""
        Me.IdAziendaTextBox1.DescriptionTextWidth = 150
        Me.IdAziendaTextBox1.DescriptionTextXValue = 92
        Me.IdAziendaTextBox1.EnableSerchTextBox = True
        Me.IdAziendaTextBox1.IsDescriptionVisible = False
        Me.IdAziendaTextBox1.Location = New System.Drawing.Point(34, 12)
        Me.IdAziendaTextBox1.Mandatory = False
        Me.IdAziendaTextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.IdAziendaTextBox1.Name = "IdAziendaTextBox1"
        Me.IdAziendaTextBox1.Size = New System.Drawing.Size(94, 23)
        Me.IdAziendaTextBox1.TabIndex = 1
        Me.IdAziendaTextBox1.TextValue = ""
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.BackColor = System.Drawing.Color.Transparent
        Me.lblId.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.ForeColor = System.Drawing.Color.Black
        Me.lblId.Location = New System.Drawing.Point(13, 15)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(17, 13)
        Me.lblId.TabIndex = 0
        Me.lblId.Text = "Id"
        '
        'GrpSed
        '
        Me.GrpSed.BackColor = System.Drawing.Color.Transparent
        Me.GrpSed.Controls.Add(Me.sedimenu)
        Me.GrpSed.Controls.Add(Me.TabControl1)
        Me.GrpSed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrpSed.Location = New System.Drawing.Point(3, 3)
        Me.GrpSed.Name = "GrpSed"
        Me.GrpSed.Size = New System.Drawing.Size(603, 229)
        Me.GrpSed.TabIndex = 0
        Me.GrpSed.Title = ""
        '
        'sedimenu
        '
        Me.sedimenu.BackgroundImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.internalmenubar
        Me.sedimenu.Controls.Add(Me.CmdSel)
        Me.sedimenu.Controls.Add(Me.CmdAdd)
        Me.sedimenu.Controls.Add(Me.CmdDel)
        Me.sedimenu.Location = New System.Drawing.Point(516, 35)
        Me.sedimenu.Name = "sedimenu"
        Me.sedimenu.Size = New System.Drawing.Size(78, 179)
        Me.sedimenu.TabIndex = 1
        '
        'CmdSel
        '
        Me.CmdSel.ApplyOutLookStile = True
        Me.CmdSel.BackColor = System.Drawing.Color.Transparent
        Me.CmdSel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CmdSel.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.showsede_48x48
        Me.CmdSel.Disabled = False
        Me.CmdSel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdSel.ForeColor = System.Drawing.Color.Transparent
        Me.CmdSel.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CmdSel.Location = New System.Drawing.Point(15, 13)
        Me.CmdSel.Name = "CmdSel"
        Me.CmdSel.Radius = 48.0!
        Me.CmdSel.ShowTooltip = True
        Me.CmdSel.Size = New System.Drawing.Size(48, 48)
        Me.CmdSel.TabIndex = 0
        Me.CmdSel.TextValue = ""
        Me.CmdSel.TooltipText = "Seleziona sede operativa"
        '
        'CmdAdd
        '
        Me.CmdAdd.ApplyOutLookStile = True
        Me.CmdAdd.BackColor = System.Drawing.Color.Transparent
        Me.CmdAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CmdAdd.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.addsede_48x48
        Me.CmdAdd.Disabled = False
        Me.CmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdAdd.ForeColor = System.Drawing.Color.Transparent
        Me.CmdAdd.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CmdAdd.Location = New System.Drawing.Point(15, 68)
        Me.CmdAdd.Name = "CmdAdd"
        Me.CmdAdd.Radius = 48.0!
        Me.CmdAdd.ShowTooltip = True
        Me.CmdAdd.Size = New System.Drawing.Size(48, 48)
        Me.CmdAdd.TabIndex = 1
        Me.CmdAdd.TextValue = ""
        Me.CmdAdd.TooltipText = "Aggiungi sede operativa"
        '
        'CmdDel
        '
        Me.CmdDel.ApplyOutLookStile = True
        Me.CmdDel.BackColor = System.Drawing.Color.Transparent
        Me.CmdDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CmdDel.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.removesede_48x48
        Me.CmdDel.Disabled = False
        Me.CmdDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdDel.ForeColor = System.Drawing.Color.Transparent
        Me.CmdDel.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CmdDel.Location = New System.Drawing.Point(15, 124)
        Me.CmdDel.Name = "CmdDel"
        Me.CmdDel.Radius = 48.0!
        Me.CmdDel.ShowTooltip = True
        Me.CmdDel.Size = New System.Drawing.Size(48, 48)
        Me.CmdDel.TabIndex = 2
        Me.CmdDel.TextValue = ""
        Me.CmdDel.TooltipText = "Elimina sede operativa"
        '
        'grpRag
        '
        Me.grpRag.BackColor = System.Drawing.Color.Transparent
        Me.grpRag.Controls.Add(Me.TabControl2)
        Me.grpRag.Location = New System.Drawing.Point(11, 77)
        Me.grpRag.Name = "grpRag"
        Me.grpRag.Size = New System.Drawing.Size(647, 317)
        Me.grpRag.TabIndex = 1
        Me.grpRag.Title = "Dati anagrafici"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Controls.Add(Me.TabPage1)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Location = New System.Drawing.Point(13, 24)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(617, 261)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label6)
        Me.TabPage3.Controls.Add(Me.cmdCAP)
        Me.TabPage3.Controls.Add(Me.cboContratti)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Controls.Add(Me.txtCap)
        Me.TabPage3.Controls.Add(Me.lblUltimaCompetenza)
        Me.TabPage3.Controls.Add(Me.cboSettori)
        Me.TabPage3.Controls.Add(Me.lblSettore)
        Me.TabPage3.Controls.Add(Me.txtPIva)
        Me.TabPage3.Controls.Add(Me.txtVia)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.txtNome)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.cboProvincia)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.cboComune)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(609, 235)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Ragione sociale"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.DarkGray
        Me.Label6.Location = New System.Drawing.Point(77, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(481, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "_______________________________________________________________________________"
        '
        'cmdCAP
        '
        Me.cmdCAP.Location = New System.Drawing.Point(520, 104)
        Me.cmdCAP.Name = "cmdCAP"
        Me.cmdCAP.Size = New System.Drawing.Size(72, 24)
        Me.cmdCAP.TabIndex = 12
        Me.cmdCAP.Text = "Calcola CAP"
        Me.cmdCAP.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Label7)
        Me.TabPage5.Controls.Add(Me.Label5)
        Me.TabPage5.Controls.Add(Me.txtMail)
        Me.TabPage5.Controls.Add(Me.txtFax)
        Me.TabPage5.Controls.Add(Me.txtCell2)
        Me.TabPage5.Controls.Add(Me.txtTelUf)
        Me.TabPage5.Controls.Add(Me.Label13)
        Me.TabPage5.Controls.Add(Me.Label19)
        Me.TabPage5.Controls.Add(Me.txtCell1)
        Me.TabPage5.Controls.Add(Me.Label16)
        Me.TabPage5.Controls.Add(Me.Label18)
        Me.TabPage5.Controls.Add(Me.Label14)
        Me.TabPage5.Controls.Add(Me.Label15)
        Me.TabPage5.Controls.Add(Me.txtResp)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(609, 235)
        Me.TabPage5.TabIndex = 2
        Me.TabPage5.Text = "Contatti"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(64, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "RIEPILOGO CONTATTI"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.DarkGray
        Me.Label5.Location = New System.Drawing.Point(64, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(481, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "_______________________________________________________________________________"
        '
        'txtMail
        '
        Me.txtMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtMail, "Indirizzo di posta elettronica del responsabile,indicato dall'azienda,con cui la " & _
        "federazione può interagire.")
        Me.txtMail.Location = New System.Drawing.Point(351, 56)
        Me.txtMail.Name = "txtMail"
        Me.HelpProvider1.SetShowHelp(Me.txtMail, True)
        Me.txtMail.Size = New System.Drawing.Size(196, 20)
        Me.txtMail.TabIndex = 9
        '
        'txtFax
        '
        Me.txtFax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtFax, "Numero di fax dell'azienda")
        Me.txtFax.Location = New System.Drawing.Point(67, 117)
        Me.txtFax.Name = "txtFax"
        Me.HelpProvider1.SetShowHelp(Me.txtFax, True)
        Me.txtFax.Size = New System.Drawing.Size(196, 20)
        Me.txtFax.TabIndex = 1
        '
        'txtCell2
        '
        Me.txtCell2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtCell2, "Numero di cellulare del responsabile indicato dall'azienda")
        Me.txtCell2.Location = New System.Drawing.Point(351, 117)
        Me.txtCell2.Name = "txtCell2"
        Me.HelpProvider1.SetShowHelp(Me.txtCell2, True)
        Me.txtCell2.Size = New System.Drawing.Size(196, 20)
        Me.txtCell2.TabIndex = 2
        '
        'txtTelUf
        '
        Me.txtTelUf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtTelUf, "Numero di telefono dell'azienda")
        Me.txtTelUf.Location = New System.Drawing.Point(67, 87)
        Me.txtTelUf.Name = "txtTelUf"
        Me.HelpProvider1.SetShowHelp(Me.txtTelUf, True)
        Me.txtTelUf.Size = New System.Drawing.Size(196, 20)
        Me.txtTelUf.TabIndex = 11
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(31, 94)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(25, 13)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "Tel."
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(32, 124)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(24, 13)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Fax"
        '
        'txtCell1
        '
        Me.txtCell1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtCell1, "Numero di cellulare del responsabile indicato dall'azienda.")
        Me.txtCell1.Location = New System.Drawing.Point(351, 87)
        Me.txtCell1.Name = "txtCell1"
        Me.HelpProvider1.SetShowHelp(Me.txtCell1, True)
        Me.txtCell1.Size = New System.Drawing.Size(196, 20)
        Me.txtCell1.TabIndex = 13
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(314, 61)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(26, 13)
        Me.Label16.TabIndex = 8
        Me.Label16.Text = "Mail"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(21, 61)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(35, 13)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "Resp."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(307, 91)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 13)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Cell.1"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(307, 122)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 13)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "Cell.2"
        '
        'txtResp
        '
        Me.txtResp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtResp, "Responsabile, indicato dall'azienda,con cui la federazione può interagire per qua" & _
        "nto riguarda le pratiche e le attività relative alla rappresentanza sindacale de" & _
        "i lavoratori.")
        Me.txtResp.Location = New System.Drawing.Point(67, 56)
        Me.txtResp.Name = "txtResp"
        Me.HelpProvider1.SetShowHelp(Me.txtResp, True)
        Me.txtResp.Size = New System.Drawing.Size(196, 20)
        Me.txtResp.TabIndex = 7
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtNote)
        Me.TabPage1.Controls.Add(Me.Label39)
        Me.TabPage1.Controls.Add(Me.txtEC)
        Me.TabPage1.Controls.Add(Me.Label36)
        Me.TabPage1.Controls.Add(Me.txtCE)
        Me.TabPage1.Controls.Add(Me.Label35)
        Me.TabPage1.Controls.Add(Me.Label24)
        Me.TabPage1.Controls.Add(Me.Label34)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(609, 235)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Text = "Varie"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtNote
        '
        Me.txtNote.BackColor = System.Drawing.Color.Transparent
        Me.txtNote.IsMultiline = True
        Me.txtNote.Location = New System.Drawing.Point(121, 90)
        Me.txtNote.Mandatory = False
        Me.txtNote.Name = "txtNote"
        Me.txtNote.OverridedEnable = True
        Me.txtNote.Required = False
        Me.txtNote.Size = New System.Drawing.Size(314, 127)
        Me.txtNote.TabIndex = 7
        Me.txtNote.TextHeight = 120
        Me.txtNote.TextValue = ""
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(33, 99)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(37, 13)
        Me.Label39.TabIndex = 6
        Me.Label39.Text = "NOTE"
        '
        'txtEC
        '
        Me.txtEC.BackColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.txtEC, "Codice edilcassa dell'utente")
        Me.txtEC.IsMultiline = False
        Me.txtEC.Location = New System.Drawing.Point(298, 24)
        Me.txtEC.Mandatory = False
        Me.txtEC.Name = "txtEC"
        Me.txtEC.OverridedEnable = True
        Me.txtEC.Required = False
        Me.HelpProvider1.SetShowHelp(Me.txtEC, True)
        Me.txtEC.Size = New System.Drawing.Size(119, 21)
        Me.txtEC.TabIndex = 4
        Me.txtEC.TextHeight = 20
        Me.txtEC.TextValue = ""
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(265, 32)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(28, 13)
        Me.Label36.TabIndex = 3
        Me.Label36.Text = "E.C."
        '
        'txtCE
        '
        Me.txtCE.BackColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.txtCE, "Codice cassa edile dell'utente")
        Me.txtCE.IsMultiline = False
        Me.txtCE.Location = New System.Drawing.Point(121, 24)
        Me.txtCE.Mandatory = False
        Me.txtCE.Name = "txtCE"
        Me.txtCE.OverridedEnable = True
        Me.txtCE.Required = False
        Me.HelpProvider1.SetShowHelp(Me.txtCE, True)
        Me.txtCE.Size = New System.Drawing.Size(99, 21)
        Me.txtCE.TabIndex = 2
        Me.txtCE.TextHeight = 20
        Me.txtCE.TextValue = ""
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(91, 32)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(28, 13)
        Me.Label35.TabIndex = 1
        Me.Label35.Text = "C.E."
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(6, 32)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(64, 13)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "CODIFICHE"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.BackColor = System.Drawing.Color.Transparent
        Me.Label34.ForeColor = System.Drawing.Color.DarkGray
        Me.Label34.Location = New System.Drawing.Point(120, 56)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(301, 13)
        Me.Label34.TabIndex = 5
        Me.Label34.Text = "_________________________________________________"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GrpSed)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(609, 235)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Sedi operative"
        Me.TabPage4.UseVisualStyleBackColor = True
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
        Me.SpNew.TabIndex = 2
        Me.SpNew.TextValue = ""
        Me.SpNew.TooltipText = "Crea nuova anagrafica"
        '
        'NiceGroupBox1
        '
        Me.NiceGroupBox1.Controls.Add(Me.Button1)
        Me.NiceGroupBox1.Controls.Add(Me.cmdCantieri)
        Me.NiceGroupBox1.Controls.Add(Me.spDoc1)
        Me.NiceGroupBox1.Controls.Add(Me.spIscritti1)
        Me.NiceGroupBox1.Controls.Add(Me.spArchivio1)
        Me.NiceGroupBox1.Controls.Add(Me.cmdGoToOfferte1)
        Me.NiceGroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NiceGroupBox1.Location = New System.Drawing.Point(664, 77)
        Me.NiceGroupBox1.Name = "NiceGroupBox1"
        Me.NiceGroupBox1.Size = New System.Drawing.Size(135, 317)
        Me.NiceGroupBox1.TabIndex = 35
        Me.NiceGroupBox1.Title = "Funzioni"
        '
        'cmdCantieri
        '
        Me.cmdCantieri.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.folder_grey_32x32
        Me.cmdCantieri.Location = New System.Drawing.Point(3, 197)
        Me.cmdCantieri.Name = "cmdCantieri"
        Me.cmdCantieri.Size = New System.Drawing.Size(123, 38)
        Me.cmdCantieri.TabIndex = 15
        Me.cmdCantieri.Text = "           Can&tieri"
        Me.cmdCantieri.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdCantieri.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdCantieri.UseVisualStyleBackColor = True
        '
        'spDoc1
        '
        Me.spDoc1.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.folder_grey_32x32
        Me.spDoc1.Location = New System.Drawing.Point(3, 153)
        Me.spDoc1.Name = "spDoc1"
        Me.spDoc1.Size = New System.Drawing.Size(123, 38)
        Me.spDoc1.TabIndex = 14
        Me.spDoc1.Text = "           Co&mpila documenti"
        Me.spDoc1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.spDoc1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.spDoc1.UseVisualStyleBackColor = True
        '
        'spIscritti1
        '
        Me.spIscritti1.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.folder_green_32x32
        Me.spIscritti1.Location = New System.Drawing.Point(3, 109)
        Me.spIscritti1.Name = "spIscritti1"
        Me.spIscritti1.Size = New System.Drawing.Size(123, 38)
        Me.spIscritti1.TabIndex = 12
        Me.spIscritti1.Text = "  &Iscr./Non Iscr."
        Me.spIscritti1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.spIscritti1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.spIscritti1.UseVisualStyleBackColor = True
        '
        'spArchivio1
        '
        Me.spArchivio1.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.folder_orange_32x32
        Me.spArchivio1.Location = New System.Drawing.Point(3, 65)
        Me.spArchivio1.Name = "spArchivio1"
        Me.spArchivio1.Size = New System.Drawing.Size(123, 38)
        Me.spArchivio1.TabIndex = 11
        Me.spArchivio1.Text = "   &Archivio  doc."
        Me.spArchivio1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.spArchivio1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.spArchivio1.UseVisualStyleBackColor = True
        '
        'cmdGoToOfferte1
        '
        Me.cmdGoToOfferte1.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.folder_blue_32x32
        Me.cmdGoToOfferte1.Location = New System.Drawing.Point(3, 21)
        Me.cmdGoToOfferte1.Name = "cmdGoToOfferte1"
        Me.cmdGoToOfferte1.Size = New System.Drawing.Size(123, 38)
        Me.cmdGoToOfferte1.TabIndex = 6
        Me.cmdGoToOfferte1.TabStop = False
        Me.cmdGoToOfferte1.Text = "    &Offerte  lav."
        Me.cmdGoToOfferte1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdGoToOfferte1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdGoToOfferte1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.folder_grey_32x32
        Me.Button1.Location = New System.Drawing.Point(3, 243)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 38)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Dati db Nazionale"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ControlAnagraficaAzienda
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.NiceGroupBox1)
        Me.Controls.Add(Me.grpRag)
        Me.Name = "ControlAnagraficaAzienda"
        Me.Size = New System.Drawing.Size(869, 460)
        Me.Controls.SetChildIndex(Me.DockPanel, 0)
        Me.Controls.SetChildIndex(Me.grpRag, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.NiceGroupBox1, 0)
        Me.DockPanel.ResumeLayout(False)
        Me.DockPanel.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.GridSedi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpSed.ResumeLayout(False)
        Me.sedimenu.ResumeLayout(False)
        Me.grpRag.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.NiceGroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblUltimaCompetenza As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboContratti As System.Windows.Forms.ComboBox
    Friend WithEvents lblSettore As System.Windows.Forms.Label
    Friend WithEvents cboSettori As System.Windows.Forms.ComboBox
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
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GridSedi As System.Windows.Forms.DataGridView
    Friend WithEvents CmdSel As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents CmdDel As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents CmdAdd As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents IdAziendaTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdAziendaTextBox
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents GrpSed As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents grpRag As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents sedimenu As System.Windows.Forms.Panel
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
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents SpNew As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtNote As WIN.GUI.UTILITY.UsabilityTextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents txtEC As WIN.GUI.UTILITY.UsabilityTextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtCE As WIN.GUI.UTILITY.UsabilityTextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents cmdCAP As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents NiceGroupBox1 As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents spDoc1 As System.Windows.Forms.Button
    Friend WithEvents spIscritti1 As System.Windows.Forms.Button
    Friend WithEvents spArchivio1 As System.Windows.Forms.Button
    Friend WithEvents cmdGoToOfferte1 As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmdCantieri As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
