<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlPagamentoQuoteVertenza
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
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.CustomBar1 = New WIN.GUI.APPLICATION.PRESENTATION.CustomBar
        Me.lblAtt = New System.Windows.Forms.Label
        Me.txtAttribuito = New System.Windows.Forms.TextBox
        Me.lblAttribuito = New System.Windows.Forms.Label
        Me.lblTot = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.cmdSearch = New System.Windows.Forms.Button
        Me.txtVertenza = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.dtpDoc = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtImporto = New System.Windows.Forms.TextBox
        Me.lblValuta = New System.Windows.Forms.Label
        Me.txtNote = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.dtpRegistrazione = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtTotale = New System.Windows.Forms.TextBox
        Me.lblTotale = New System.Windows.Forms.Label
        Me.GridPosizioni = New System.Windows.Forms.DataGridView
        Me.lblDescrizioneUtente = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.GrpSogg = New WIN.GUI.UTILITY.NiceGroupBox
        Me.cmdPrest = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
        Me.CmdCrea = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
        Me.cmdRed = New System.Windows.Forms.Button
        Me.cmdBlu = New System.Windows.Forms.Button
        Me.cmdGreen = New System.Windows.Forms.Button
        Me.NiceGroupBox1 = New WIN.GUI.UTILITY.NiceGroupBox
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
        Me.DockPanel.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.GridPosizioni, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpSogg.SuspendLayout()
        Me.NiceGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Size = New System.Drawing.Size(871, 22)
        '
        'DockPanel
        '
        Me.DockPanel.Controls.Add(Me.CmdCrea)
        Me.DockPanel.Controls.Add(Me.CustomBar1)
        Me.DockPanel.Controls.Add(Me.cmdPrest)
        Me.DockPanel.Location = New System.Drawing.Point(0, 22)
        Me.DockPanel.Size = New System.Drawing.Size(871, 44)
        '
        'CustomBar1
        '
        Me.CustomBar1.BackColor = System.Drawing.Color.Transparent
        Me.CustomBar1.Location = New System.Drawing.Point(3, 2)
        Me.CustomBar1.Name = "CustomBar1"
        Me.CustomBar1.Size = New System.Drawing.Size(308, 40)
        Me.CustomBar1.TabIndex = 79
        '
        'lblAtt
        '
        Me.lblAtt.AutoSize = True
        Me.lblAtt.BackColor = System.Drawing.Color.Transparent
        Me.lblAtt.Location = New System.Drawing.Point(194, 67)
        Me.lblAtt.Name = "lblAtt"
        Me.lblAtt.Size = New System.Drawing.Size(29, 13)
        Me.lblAtt.TabIndex = 85
        Me.lblAtt.Text = "Euro"
        '
        'txtAttribuito
        '
        Me.txtAttribuito.AcceptsTab = True
        Me.txtAttribuito.Enabled = False
        Me.txtAttribuito.Location = New System.Drawing.Point(97, 63)
        Me.txtAttribuito.Name = "txtAttribuito"
        Me.txtAttribuito.Size = New System.Drawing.Size(92, 21)
        Me.txtAttribuito.TabIndex = 84
        '
        'lblAttribuito
        '
        Me.lblAttribuito.AutoSize = True
        Me.lblAttribuito.BackColor = System.Drawing.Color.Transparent
        Me.lblAttribuito.Location = New System.Drawing.Point(42, 66)
        Me.lblAttribuito.Name = "lblAttribuito"
        Me.lblAttribuito.Size = New System.Drawing.Size(52, 13)
        Me.lblAttribuito.TabIndex = 83
        Me.lblAttribuito.Text = "Attribuito"
        '
        'lblTot
        '
        Me.lblTot.AutoSize = True
        Me.lblTot.BackColor = System.Drawing.Color.Transparent
        Me.lblTot.Location = New System.Drawing.Point(194, 38)
        Me.lblTot.Name = "lblTot"
        Me.lblTot.Size = New System.Drawing.Size(29, 13)
        Me.lblTot.TabIndex = 82
        Me.lblTot.Text = "Euro"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(18, 78)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(548, 199)
        Me.TabControl1.TabIndex = 73
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cmdSearch)
        Me.TabPage1.Controls.Add(Me.txtVertenza)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.dtpDoc)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txtImporto)
        Me.TabPage1.Controls.Add(Me.lblValuta)
        Me.TabPage1.Controls.Add(Me.txtNote)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.dtpRegistrazione)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(540, 173)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Dati generali"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'cmdSearch
        '
        Me.HelpProvider1.SetHelpString(Me.cmdSearch, "Funzione che permette di cercare la vertenza da incassare.")
        Me.cmdSearch.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.SearchPaint
        Me.cmdSearch.Location = New System.Drawing.Point(229, 109)
        Me.cmdSearch.Name = "cmdSearch"
        Me.HelpProvider1.SetShowHelp(Me.cmdSearch, True)
        Me.cmdSearch.Size = New System.Drawing.Size(32, 23)
        Me.cmdSearch.TabIndex = 65
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'txtVertenza
        '
        Me.HelpProvider1.SetHelpString(Me.txtVertenza, "Identificativo della vertenza cui l'incasso fa riferimento")
        Me.txtVertenza.Location = New System.Drawing.Point(83, 110)
        Me.txtVertenza.Name = "txtVertenza"
        Me.HelpProvider1.SetShowHelp(Me.txtVertenza, True)
        Me.txtVertenza.Size = New System.Drawing.Size(144, 21)
        Me.txtVertenza.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(11, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Id vertenza"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.HelpProvider1.SetHelpString(Me.TextBox1, "Tipo di quote incassate")
        Me.TextBox1.Location = New System.Drawing.Point(83, 78)
        Me.TextBox1.Name = "TextBox1"
        Me.HelpProvider1.SetShowHelp(Me.TextBox1, True)
        Me.TextBox1.Size = New System.Drawing.Size(144, 21)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "Incasso Quota Vertenza"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 85)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Tipo doc."
        '
        'dtpDoc
        '
        Me.dtpDoc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.HelpProvider1.SetHelpString(Me.dtpDoc, "Data del documento cui l'incasso quote fa riferimento. ")
        Me.dtpDoc.Location = New System.Drawing.Point(83, 46)
        Me.dtpDoc.Name = "dtpDoc"
        Me.HelpProvider1.SetShowHelp(Me.dtpDoc, True)
        Me.dtpDoc.Size = New System.Drawing.Size(144, 21)
        Me.dtpDoc.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Data doc."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Importo"
        '
        'txtImporto
        '
        Me.HelpProvider1.SetHelpString(Me.txtImporto, "Importo, concordato con l'utente,incassato per la vertenza")
        Me.txtImporto.Location = New System.Drawing.Point(84, 140)
        Me.txtImporto.Name = "txtImporto"
        Me.HelpProvider1.SetShowHelp(Me.txtImporto, True)
        Me.txtImporto.Size = New System.Drawing.Size(143, 21)
        Me.txtImporto.TabIndex = 4
        '
        'lblValuta
        '
        Me.lblValuta.AutoSize = True
        Me.lblValuta.Location = New System.Drawing.Point(230, 144)
        Me.lblValuta.Name = "lblValuta"
        Me.lblValuta.Size = New System.Drawing.Size(29, 13)
        Me.lblValuta.TabIndex = 16
        Me.lblValuta.Text = "Euro"
        '
        'txtNote
        '
        Me.HelpProvider1.SetHelpString(Me.txtNote, "Eventuali note sull'incasso della quota vertenza.")
        Me.txtNote.Location = New System.Drawing.Point(325, 16)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.HelpProvider1.SetShowHelp(Me.txtNote, True)
        Me.txtNote.Size = New System.Drawing.Size(195, 140)
        Me.txtNote.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(289, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Note"
        '
        'dtpRegistrazione
        '
        Me.dtpRegistrazione.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.HelpProvider1.SetHelpString(Me.dtpRegistrazione, "Data di registrazione dell'incasso quote nel sistema")
        Me.dtpRegistrazione.Location = New System.Drawing.Point(83, 16)
        Me.dtpRegistrazione.Name = "dtpRegistrazione"
        Me.HelpProvider1.SetShowHelp(Me.dtpRegistrazione, True)
        Me.dtpRegistrazione.Size = New System.Drawing.Size(144, 21)
        Me.dtpRegistrazione.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Data reg."
        '
        'txtTotale
        '
        Me.txtTotale.Enabled = False
        Me.txtTotale.Location = New System.Drawing.Point(97, 33)
        Me.txtTotale.Name = "txtTotale"
        Me.txtTotale.Size = New System.Drawing.Size(92, 21)
        Me.txtTotale.TabIndex = 81
        '
        'lblTotale
        '
        Me.lblTotale.AutoSize = True
        Me.lblTotale.BackColor = System.Drawing.Color.Transparent
        Me.lblTotale.Location = New System.Drawing.Point(27, 37)
        Me.lblTotale.Name = "lblTotale"
        Me.lblTotale.Size = New System.Drawing.Size(67, 13)
        Me.lblTotale.TabIndex = 80
        Me.lblTotale.Text = "Da attribuire"
        '
        'GridPosizioni
        '
        Me.GridPosizioni.AllowUserToAddRows = False
        Me.GridPosizioni.AllowUserToDeleteRows = False
        Me.GridPosizioni.AllowUserToOrderColumns = True
        DataGridViewCellStyle25.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle25.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle25.NullValue = Nothing
        DataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridPosizioni.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle25
        Me.GridPosizioni.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridPosizioni.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.GridPosizioni.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GridPosizioni.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle26.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle26.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridPosizioni.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle26
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle27.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle27.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle27.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridPosizioni.DefaultCellStyle = DataGridViewCellStyle27
        Me.GridPosizioni.GridColor = System.Drawing.Color.LightGray
        Me.GridPosizioni.Location = New System.Drawing.Point(18, 295)
        Me.GridPosizioni.Name = "GridPosizioni"
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle28.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle28.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle28.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle28.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle28.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridPosizioni.RowHeadersDefaultCellStyle = DataGridViewCellStyle28
        Me.GridPosizioni.RowHeadersWidth = 30
        Me.GridPosizioni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.GridPosizioni.Size = New System.Drawing.Size(832, 273)
        Me.GridPosizioni.TabIndex = 90
        '
        'lblDescrizioneUtente
        '
        Me.lblDescrizioneUtente.AutoSize = True
        Me.lblDescrizioneUtente.BackColor = System.Drawing.Color.Transparent
        Me.lblDescrizioneUtente.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.lblDescrizioneUtente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.lblDescrizioneUtente, "Nome e cognome dell'utente cui la vertenza incassata fa riferimento")
        Me.lblDescrizioneUtente.Location = New System.Drawing.Point(30, 46)
        Me.lblDescrizioneUtente.Name = "lblDescrizioneUtente"
        Me.HelpProvider1.SetShowHelp(Me.lblDescrizioneUtente, True)
        Me.lblDescrizioneUtente.Size = New System.Drawing.Size(46, 13)
        Me.lblDescrizioneUtente.TabIndex = 0
        Me.lblDescrizioneUtente.Text = "Utente"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(20, 27)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Nome e cognome:"
        '
        'GrpSogg
        '
        Me.GrpSogg.BackColor = System.Drawing.Color.Silver
        Me.GrpSogg.Controls.Add(Me.Label13)
        Me.GrpSogg.Controls.Add(Me.lblDescrizioneUtente)
        Me.GrpSogg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GrpSogg.Location = New System.Drawing.Point(572, 203)
        Me.GrpSogg.Name = "GrpSogg"
        Me.GrpSogg.Size = New System.Drawing.Size(282, 74)
        Me.GrpSogg.TabIndex = 72
        Me.GrpSogg.Text = "Dati anagrafici dell'utente"
        Me.GrpSogg.Title = "Dati Utente"
        '
        'cmdPrest
        '
        Me.cmdPrest.ApplyOutLookStile = True
        Me.cmdPrest.BackColor = System.Drawing.Color.Transparent
        Me.cmdPrest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdPrest.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.error_32x32_2
        Me.cmdPrest.Disabled = False
        Me.cmdPrest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPrest.ForeColor = System.Drawing.Color.Transparent
      Me.HelpProvider1.SetHelpString(Me.cmdPrest, "Funzione che permette di aprire una nuova istanza di FenealGest in cui parallelame" & _
                "nte è possibile visualizzare le vertenze di un utente.")
        Me.cmdPrest.Location = New System.Drawing.Point(341, 8)
        Me.cmdPrest.Margin = New System.Windows.Forms.Padding(0)
        Me.cmdPrest.Name = "cmdPrest"
        Me.cmdPrest.Radius = 32.0!
        Me.HelpProvider1.SetShowHelp(Me.cmdPrest, True)
        Me.cmdPrest.ShowTooltip = True
        Me.cmdPrest.Size = New System.Drawing.Size(32, 32)
        Me.cmdPrest.TabIndex = 91
        Me.cmdPrest.TextValue = ""
        Me.cmdPrest.TooltipText = "Esplora vertenze utente"
        '
        'CmdCrea
        '
        Me.CmdCrea.ApplyOutLookStile = True
        Me.CmdCrea.BackColor = System.Drawing.Color.Transparent
        Me.CmdCrea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CmdCrea.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.k_calc_32x32
        Me.CmdCrea.Disabled = False
        Me.CmdCrea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdCrea.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdCrea.ForeColor = System.Drawing.Color.Transparent
        Me.CmdCrea.Location = New System.Drawing.Point(304, 8)
        Me.CmdCrea.Margin = New System.Windows.Forms.Padding(0)
        Me.CmdCrea.Name = "CmdCrea"
        Me.CmdCrea.Radius = 32.0!
        Me.CmdCrea.ShowTooltip = True
        Me.CmdCrea.Size = New System.Drawing.Size(32, 32)
        Me.CmdCrea.TabIndex = 78
        Me.CmdCrea.TextValue = ""
        Me.CmdCrea.TooltipText = "Crea incasso"
        '
        'cmdRed
        '
        Me.cmdRed.BackColor = System.Drawing.Color.Transparent
        Me.cmdRed.BackgroundImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.Flag_grayHS1
        Me.cmdRed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdRed.FlatAppearance.BorderSize = 0
        Me.cmdRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdRed.Location = New System.Drawing.Point(229, 30)
        Me.cmdRed.Name = "cmdRed"
        Me.cmdRed.Size = New System.Drawing.Size(16, 16)
        Me.cmdRed.TabIndex = 88
        Me.cmdRed.UseVisualStyleBackColor = False
        '
        'cmdBlu
        '
        Me.cmdBlu.BackColor = System.Drawing.Color.Transparent
        Me.cmdBlu.BackgroundImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.Flag_blueHS
        Me.cmdBlu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdBlu.FlatAppearance.BorderSize = 0
        Me.cmdBlu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdBlu.Location = New System.Drawing.Point(229, 50)
        Me.cmdBlu.Name = "cmdBlu"
        Me.cmdBlu.Size = New System.Drawing.Size(16, 16)
        Me.cmdBlu.TabIndex = 87
        Me.cmdBlu.UseVisualStyleBackColor = False
        '
        'cmdGreen
        '
        Me.cmdGreen.BackColor = System.Drawing.Color.Transparent
        Me.cmdGreen.BackgroundImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.Flag_grayHS
        Me.cmdGreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cmdGreen.FlatAppearance.BorderSize = 0
        Me.cmdGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdGreen.Location = New System.Drawing.Point(229, 72)
        Me.cmdGreen.Name = "cmdGreen"
        Me.cmdGreen.Size = New System.Drawing.Size(16, 16)
        Me.cmdGreen.TabIndex = 86
        Me.cmdGreen.UseVisualStyleBackColor = False
        '
        'NiceGroupBox1
        '
        Me.NiceGroupBox1.Controls.Add(Me.txtTotale)
        Me.NiceGroupBox1.Controls.Add(Me.lblTotale)
        Me.NiceGroupBox1.Controls.Add(Me.lblTot)
        Me.NiceGroupBox1.Controls.Add(Me.lblAttribuito)
        Me.NiceGroupBox1.Controls.Add(Me.txtAttribuito)
        Me.NiceGroupBox1.Controls.Add(Me.cmdGreen)
        Me.NiceGroupBox1.Controls.Add(Me.cmdRed)
        Me.NiceGroupBox1.Controls.Add(Me.cmdBlu)
        Me.NiceGroupBox1.Controls.Add(Me.lblAtt)
        Me.NiceGroupBox1.Location = New System.Drawing.Point(573, 100)
        Me.NiceGroupBox1.Name = "NiceGroupBox1"
        Me.NiceGroupBox1.Size = New System.Drawing.Size(281, 100)
        Me.NiceGroupBox1.TabIndex = 93
        Me.NiceGroupBox1.Title = "Totalizzazioni"
        '
        'ControlPagamentoQuoteVertenza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.NiceGroupBox1)
        Me.Controls.Add(Me.GrpSogg)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GridPosizioni)
        Me.Name = "ControlPagamentoQuoteVertenza"
        Me.Size = New System.Drawing.Size(871, 584)
        Me.Controls.SetChildIndex(Me.GridPosizioni, 0)
        Me.Controls.SetChildIndex(Me.DockPanel, 0)
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        Me.Controls.SetChildIndex(Me.GrpSogg, 0)
        Me.Controls.SetChildIndex(Me.NiceGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.DockPanel.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.GridPosizioni, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpSogg.ResumeLayout(False)
        Me.GrpSogg.PerformLayout()
        Me.NiceGroupBox1.ResumeLayout(False)
        Me.NiceGroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdPrest As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents CustomBar1 As WIN.GUI.APPLICATION.PRESENTATION.CustomBar
    Friend WithEvents cmdRed As System.Windows.Forms.Button
   Friend WithEvents CmdCrea As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents cmdBlu As System.Windows.Forms.Button
    Friend WithEvents cmdGreen As System.Windows.Forms.Button
    Friend WithEvents lblAtt As System.Windows.Forms.Label
    Friend WithEvents txtAttribuito As System.Windows.Forms.TextBox
    Friend WithEvents lblAttribuito As System.Windows.Forms.Label
    Friend WithEvents lblTot As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents txtVertenza As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpDoc As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents txtImporto As System.Windows.Forms.TextBox
    Friend WithEvents lblValuta As System.Windows.Forms.Label
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpRegistrazione As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTotale As System.Windows.Forms.TextBox
    Friend WithEvents lblTotale As System.Windows.Forms.Label
    Friend WithEvents GridPosizioni As System.Windows.Forms.DataGridView
    Friend WithEvents lblDescrizioneUtente As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
   Friend WithEvents GrpSogg As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents NiceGroupBox1 As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider

End Class
