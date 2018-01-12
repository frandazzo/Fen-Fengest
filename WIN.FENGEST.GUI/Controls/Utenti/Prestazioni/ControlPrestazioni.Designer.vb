<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlPrestazioni
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
        Me.lblId = New System.Windows.Forms.Label()
        Me.MainGroup = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpDoc = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpData = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.lblDescrizioneUtente = New System.Windows.Forms.Label()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        Me.IdUtenteTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdUtenteTextBox()
        Me.lblUtente = New System.Windows.Forms.Label()
        Me.lblDescrizioneReferente = New System.Windows.Forms.Label()
        Me.IdReferenteTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox()
        Me.lblReferente = New System.Windows.Forms.Label()
        Me.IdUtenteTextBox2 = New WIN.GUI.APPLICATION.PRESENTATION.IdUtenteTextBox()
        Me.CustomBar1 = New WIN.GUI.APPLICATION.PRESENTATION.CustomBar()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.refBox = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.lblIdPrest = New System.Windows.Forms.Label()
        Me.txtIdPrest = New System.Windows.Forms.TextBox()
        Me.CmdVis = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.GroupBox1 = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SpAddFile = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SpView = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.lblDocumento = New System.Windows.Forms.Label()
        Me.SpDel = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.SpDelRef = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.DockPanel.SuspendLayout()
        Me.MainGroup.SuspendLayout()
        Me.refBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Size = New System.Drawing.Size(843, 22)
        '
        'DockPanel
        '
        Me.DockPanel.Controls.Add(Me.txtIdPrest)
        Me.DockPanel.Controls.Add(Me.CustomBar1)
        Me.DockPanel.Controls.Add(Me.lblId)
        Me.DockPanel.Controls.Add(Me.IdUtenteTextBox2)
        Me.DockPanel.Controls.Add(Me.lblIdPrest)
        Me.DockPanel.Controls.Add(Me.CmdVis)
        Me.DockPanel.Location = New System.Drawing.Point(0, 22)
        Me.DockPanel.Size = New System.Drawing.Size(843, 44)
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.BackColor = System.Drawing.Color.Transparent
        Me.lblId.ForeColor = System.Drawing.Color.Black
        Me.lblId.Location = New System.Drawing.Point(15, 18)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(52, 13)
        Me.lblId.TabIndex = 27
        Me.lblId.Text = "Id utente"
        '
        'MainGroup
        '
        Me.MainGroup.BackColor = System.Drawing.Color.Silver
        Me.MainGroup.Controls.Add(Me.Label1)
        Me.MainGroup.Controls.Add(Me.dtpDoc)
        Me.MainGroup.Controls.Add(Me.Label6)
        Me.MainGroup.Controls.Add(Me.dtpData)
        Me.MainGroup.Controls.Add(Me.Label3)
        Me.MainGroup.Controls.Add(Me.Label4)
        Me.MainGroup.Controls.Add(Me.txtNote)
        Me.MainGroup.Controls.Add(Me.lblDescrizioneUtente)
        Me.MainGroup.Controls.Add(Me.cboTipo)
        Me.MainGroup.Controls.Add(Me.IdUtenteTextBox1)
        Me.MainGroup.Controls.Add(Me.lblUtente)
        Me.MainGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainGroup.ForeColor = System.Drawing.Color.Black
        Me.MainGroup.Location = New System.Drawing.Point(11, 82)
        Me.MainGroup.Name = "MainGroup"
        Me.MainGroup.Size = New System.Drawing.Size(429, 238)
        Me.MainGroup.TabIndex = 1
        Me.MainGroup.Text = "Dati principali"
        Me.MainGroup.Title = "Dati Generali"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 212)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Data fine prest."
        '
        'dtpDoc
        '
        Me.dtpDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDoc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.HelpProvider1.SetHelpString(Me.dtpDoc, "Data in cui è stata compilata la prestazione")
        Me.dtpDoc.Location = New System.Drawing.Point(96, 208)
        Me.dtpDoc.Name = "dtpDoc"
        Me.HelpProvider1.SetShowHelp(Me.dtpDoc, True)
        Me.dtpDoc.Size = New System.Drawing.Size(103, 20)
        Me.dtpDoc.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(28, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Data prest."
        '
        'dtpData
        '
        Me.dtpData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.HelpProvider1.SetHelpString(Me.dtpData, "Data in cui la prestazione Inps è stata registrata nel sistema")
        Me.dtpData.Location = New System.Drawing.Point(98, 31)
        Me.dtpData.Name = "dtpData"
        Me.HelpProvider1.SetShowHelp(Me.dtpData, True)
        Me.dtpData.Size = New System.Drawing.Size(103, 20)
        Me.dtpData.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(55, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Note"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Tipo prest."
        '
        'txtNote
        '
        Me.txtNote.AcceptsReturn = True
        Me.txtNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtNote, "Eventuali note.")
        Me.txtNote.Location = New System.Drawing.Point(97, 132)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.HelpProvider1.SetShowHelp(Me.txtNote, True)
        Me.txtNote.Size = New System.Drawing.Size(305, 62)
        Me.txtNote.TabIndex = 4
        '
        'lblDescrizioneUtente
        '
        Me.lblDescrizioneUtente.AutoSize = True
        Me.lblDescrizioneUtente.BackColor = System.Drawing.Color.Transparent
        Me.lblDescrizioneUtente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrizioneUtente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDescrizioneUtente.Location = New System.Drawing.Point(199, 66)
        Me.lblDescrizioneUtente.Name = "lblDescrizioneUtente"
        Me.lblDescrizioneUtente.Size = New System.Drawing.Size(0, 13)
        Me.lblDescrizioneUtente.TabIndex = 0
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipo.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboTipo, "Tipo di prestazione. I tipi di prestazione possono essere impostati dal menu Stru" & _
        "menti->Setup-> Segreteria->Tipi prestazione.")
        Me.cboTipo.Location = New System.Drawing.Point(97, 101)
        Me.cboTipo.Name = "cboTipo"
        Me.HelpProvider1.SetShowHelp(Me.cboTipo, True)
        Me.cboTipo.Size = New System.Drawing.Size(305, 21)
        Me.cboTipo.TabIndex = 5
        '
        'IdUtenteTextBox1
        '
        Me.IdUtenteTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.IdUtenteTextBox1.DescriptionOfText = ""
        Me.IdUtenteTextBox1.DescriptionTextWidth = 150
        Me.IdUtenteTextBox1.DescriptionTextXValue = 92
        Me.IdUtenteTextBox1.EnableSerchTextBox = True
        Me.IdUtenteTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.IdUtenteTextBox1, "Identificativo dell'utente per cui è compilata la prestazione")
        Me.IdUtenteTextBox1.IsDescriptionVisible = False
        Me.IdUtenteTextBox1.Location = New System.Drawing.Point(97, 63)
        Me.IdUtenteTextBox1.Mandatory = False
        Me.IdUtenteTextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.IdUtenteTextBox1.Name = "IdUtenteTextBox1"
        Me.HelpProvider1.SetShowHelp(Me.IdUtenteTextBox1, True)
        Me.IdUtenteTextBox1.Size = New System.Drawing.Size(90, 25)
        Me.IdUtenteTextBox1.TabIndex = 3
        Me.IdUtenteTextBox1.TextValue = ""
        '
        'lblUtente
        '
        Me.lblUtente.AutoSize = True
        Me.lblUtente.BackColor = System.Drawing.Color.Transparent
        Me.lblUtente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblUtente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUtente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblUtente.Location = New System.Drawing.Point(36, 66)
        Me.lblUtente.Name = "lblUtente"
        Me.lblUtente.Size = New System.Drawing.Size(49, 13)
        Me.lblUtente.TabIndex = 13
        Me.lblUtente.Text = "Id utente"
        '
        'lblDescrizioneReferente
        '
        Me.lblDescrizioneReferente.AutoSize = True
        Me.lblDescrizioneReferente.BackColor = System.Drawing.Color.Transparent
        Me.lblDescrizioneReferente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrizioneReferente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDescrizioneReferente.Location = New System.Drawing.Point(179, 37)
        Me.lblDescrizioneReferente.Name = "lblDescrizioneReferente"
        Me.lblDescrizioneReferente.Size = New System.Drawing.Size(0, 13)
        Me.lblDescrizioneReferente.TabIndex = 0
        '
        'IdReferenteTextBox1
        '
        Me.IdReferenteTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.IdReferenteTextBox1.DescriptionOfText = ""
        Me.IdReferenteTextBox1.DescriptionTextWidth = 150
        Me.IdReferenteTextBox1.DescriptionTextXValue = 92
        Me.IdReferenteTextBox1.EnableSerchTextBox = True
        Me.HelpProvider1.SetHelpString(Me.IdReferenteTextBox1, "Identificativo del collaboratore comunale che ha compilato la prestazione.")
        Me.IdReferenteTextBox1.IsDescriptionVisible = False
        Me.IdReferenteTextBox1.Location = New System.Drawing.Point(76, 32)
        Me.IdReferenteTextBox1.Mandatory = False
        Me.IdReferenteTextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.IdReferenteTextBox1.Name = "IdReferenteTextBox1"
        Me.HelpProvider1.SetShowHelp(Me.IdReferenteTextBox1, True)
        Me.IdReferenteTextBox1.Size = New System.Drawing.Size(92, 27)
        Me.IdReferenteTextBox1.TabIndex = 19
        Me.IdReferenteTextBox1.TextValue = ""
        '
        'lblReferente
        '
        Me.lblReferente.AutoSize = True
        Me.lblReferente.BackColor = System.Drawing.Color.Transparent
        Me.lblReferente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblReferente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReferente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblReferente.Location = New System.Drawing.Point(28, 37)
        Me.lblReferente.Name = "lblReferente"
        Me.lblReferente.Size = New System.Drawing.Size(38, 13)
        Me.lblReferente.TabIndex = 15
        Me.lblReferente.Text = "Id coll."
        '
        'IdUtenteTextBox2
        '
        Me.IdUtenteTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.IdUtenteTextBox2.DescriptionOfText = ""
        Me.IdUtenteTextBox2.DescriptionTextWidth = 150
        Me.IdUtenteTextBox2.DescriptionTextXValue = 92
        Me.IdUtenteTextBox2.EnableSerchTextBox = True
        Me.IdUtenteTextBox2.IsDescriptionVisible = False
        Me.IdUtenteTextBox2.Location = New System.Drawing.Point(69, 14)
        Me.IdUtenteTextBox2.Mandatory = False
        Me.IdUtenteTextBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.IdUtenteTextBox2.Name = "IdUtenteTextBox2"
        Me.IdUtenteTextBox2.Size = New System.Drawing.Size(92, 24)
        Me.IdUtenteTextBox2.TabIndex = 31
        Me.IdUtenteTextBox2.TextValue = ""
        '
        'CustomBar1
        '
        Me.CustomBar1.BackColor = System.Drawing.Color.Transparent
        Me.CustomBar1.Location = New System.Drawing.Point(164, 2)
        Me.CustomBar1.Name = "CustomBar1"
        Me.CustomBar1.Size = New System.Drawing.Size(294, 40)
        Me.CustomBar1.TabIndex = 6
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'refBox
        '
        Me.refBox.BackColor = System.Drawing.Color.Silver
        Me.refBox.Controls.Add(Me.IdReferenteTextBox1)
        Me.refBox.Controls.Add(Me.lblReferente)
        Me.refBox.Controls.Add(Me.lblDescrizioneReferente)
        Me.refBox.ForeColor = System.Drawing.Color.Black
        Me.refBox.Location = New System.Drawing.Point(11, 466)
        Me.refBox.Name = "refBox"
        Me.refBox.Size = New System.Drawing.Size(429, 76)
        Me.refBox.TabIndex = 3
        Me.refBox.Title = "Dati collaboratore comunale"
        '
        'lblIdPrest
        '
        Me.lblIdPrest.AutoSize = True
        Me.lblIdPrest.BackColor = System.Drawing.Color.Transparent
        Me.lblIdPrest.Location = New System.Drawing.Point(39, 18)
        Me.lblIdPrest.Name = "lblIdPrest"
        Me.lblIdPrest.Size = New System.Drawing.Size(17, 13)
        Me.lblIdPrest.TabIndex = 61
        Me.lblIdPrest.Text = "Id"
        '
        'txtIdPrest
        '
        Me.txtIdPrest.Enabled = False
        Me.HelpProvider1.SetHelpString(Me.txtIdPrest, "Identificativo dell'utente.")
        Me.txtIdPrest.Location = New System.Drawing.Point(70, 14)
        Me.txtIdPrest.Name = "txtIdPrest"
        Me.HelpProvider1.SetShowHelp(Me.txtIdPrest, True)
        Me.txtIdPrest.Size = New System.Drawing.Size(50, 21)
        Me.txtIdPrest.TabIndex = 62
        '
        'CmdVis
        '
        Me.CmdVis.ApplyOutLookStile = True
        Me.CmdVis.BackColor = System.Drawing.Color.Transparent
        Me.CmdVis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CmdVis.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.folder_download_32x32
        Me.CmdVis.Disabled = False
        Me.CmdVis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdVis.ForeColor = System.Drawing.Color.Transparent
        Me.CmdVis.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CmdVis.Location = New System.Drawing.Point(161, 7)
        Me.CmdVis.Name = "CmdVis"
        Me.CmdVis.Radius = 32.0!
        Me.CmdVis.ShowTooltip = True
        Me.CmdVis.Size = New System.Drawing.Size(32, 32)
        Me.CmdVis.TabIndex = 44
        Me.CmdVis.TextValue = ""
        Me.CmdVis.TooltipText = "Visualizza"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.SpAddFile)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.SpView)
        Me.GroupBox1.Controls.Add(Me.lblDocumento)
        Me.GroupBox1.Controls.Add(Me.SpDel)
        Me.GroupBox1.Controls.Add(Me.SpDelRef)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(11, 326)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(429, 134)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.Title = "Allegato"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(385, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.TabIndex = 75
        Me.PictureBox1.TabStop = False
        '
        'SpAddFile
        '
        Me.SpAddFile.ApplyOutLookStile = True
        Me.SpAddFile.BackColor = System.Drawing.Color.Transparent
        Me.SpAddFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SpAddFile.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.file_add_32x32
        Me.SpAddFile.Disabled = False
        Me.SpAddFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SpAddFile.ForeColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.SpAddFile, "Funzione che permette di allegare un file alla prestazione.")
        Me.SpAddFile.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SpAddFile.Location = New System.Drawing.Point(22, 25)
        Me.SpAddFile.Name = "SpAddFile"
        Me.SpAddFile.Radius = 32.0!
        Me.HelpProvider1.SetShowHelp(Me.SpAddFile, True)
        Me.SpAddFile.ShowTooltip = True
        Me.SpAddFile.Size = New System.Drawing.Size(32, 32)
        Me.SpAddFile.TabIndex = 7
        Me.SpAddFile.TextValue = ""
        Me.SpAddFile.TooltipText = "Allega file"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Documento:"
        '
        'SpView
        '
        Me.SpView.ApplyOutLookStile = True
        Me.SpView.BackColor = System.Drawing.Color.Transparent
        Me.SpView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SpView.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.file_view_32x32
        Me.SpView.Disabled = False
        Me.SpView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SpView.ForeColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.SpView, "Funzione che permette di aprire il file allegato alla prestazione.")
        Me.SpView.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SpView.Location = New System.Drawing.Point(60, 25)
        Me.SpView.Name = "SpView"
        Me.SpView.Radius = 32.0!
        Me.HelpProvider1.SetShowHelp(Me.SpView, True)
        Me.SpView.ShowTooltip = True
        Me.SpView.Size = New System.Drawing.Size(32, 32)
        Me.SpView.TabIndex = 8
        Me.SpView.TextValue = ""
        Me.SpView.TooltipText = "Apri file"
        '
        'lblDocumento
        '
        Me.lblDocumento.AutoEllipsis = True
        Me.lblDocumento.AutoSize = True
        Me.lblDocumento.BackColor = System.Drawing.Color.Transparent
        Me.lblDocumento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDocumento.Location = New System.Drawing.Point(77, 69)
        Me.lblDocumento.MaximumSize = New System.Drawing.Size(300, 0)
        Me.lblDocumento.Name = "lblDocumento"
        Me.lblDocumento.Size = New System.Drawing.Size(114, 13)
        Me.lblDocumento.TabIndex = 73
        Me.lblDocumento.Text = "Nessun documento"
        '
        'SpDel
        '
        Me.SpDel.ApplyOutLookStile = True
        Me.SpDel.BackColor = System.Drawing.Color.Transparent
        Me.SpDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SpDel.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.file_broken_32x32
        Me.SpDel.Disabled = False
        Me.SpDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SpDel.ForeColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.SpDel, "Funzione che permette di eliminare il file allegato alla prestazione dalla memori" & _
        "a del sistema.")
        Me.SpDel.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SpDel.Location = New System.Drawing.Point(136, 25)
        Me.SpDel.Name = "SpDel"
        Me.SpDel.Radius = 32.0!
        Me.HelpProvider1.SetShowHelp(Me.SpDel, True)
        Me.SpDel.ShowTooltip = True
        Me.SpDel.Size = New System.Drawing.Size(32, 32)
        Me.SpDel.TabIndex = 56
        Me.SpDel.TextValue = ""
        Me.SpDel.TooltipText = "Elimina file"
        '
        'SpDelRef
        '
        Me.SpDelRef.ApplyOutLookStile = True
        Me.SpDelRef.BackColor = System.Drawing.Color.Transparent
        Me.SpDelRef.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SpDelRef.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.file_broken_feneal_32x32
        Me.SpDelRef.Disabled = False
        Me.SpDelRef.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SpDelRef.ForeColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.SpDelRef, "Funzione che permette di eliminare il file allegato alla prestazione.Eliminare il" & _
        " riferimento al file non comporta l'eliminazione del file stesso dalla memoria d" & _
        "el sistema.")
        Me.SpDelRef.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SpDelRef.Location = New System.Drawing.Point(98, 25)
        Me.SpDelRef.Name = "SpDelRef"
        Me.SpDelRef.Radius = 32.0!
        Me.HelpProvider1.SetShowHelp(Me.SpDelRef, True)
        Me.SpDelRef.ShowTooltip = True
        Me.SpDelRef.Size = New System.Drawing.Size(32, 32)
        Me.SpDelRef.TabIndex = 9
        Me.SpDelRef.TextValue = ""
        Me.SpDelRef.TooltipText = "Elimina riferimento"
        '
        'ControlPrestazioni
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.refBox)
        Me.Controls.Add(Me.MainGroup)
        Me.Name = "ControlPrestazioni"
        Me.Size = New System.Drawing.Size(843, 562)
        Me.Controls.SetChildIndex(Me.DockPanel, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.MainGroup, 0)
        Me.Controls.SetChildIndex(Me.refBox, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.DockPanel.ResumeLayout(False)
        Me.DockPanel.PerformLayout()
        Me.MainGroup.ResumeLayout(False)
        Me.MainGroup.PerformLayout()
        Me.refBox.ResumeLayout(False)
        Me.refBox.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents MainGroup As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents IdUtenteTextBox2 As WIN.GUI.APPLICATION.PRESENTATION.IdUtenteTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpDoc As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpData As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents lblDescrizioneReferente As System.Windows.Forms.Label
    Friend WithEvents lblDescrizioneUtente As System.Windows.Forms.Label
    Friend WithEvents IdReferenteTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox
    Friend WithEvents IdUtenteTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdUtenteTextBox
    Friend WithEvents lblReferente As System.Windows.Forms.Label
    Friend WithEvents lblUtente As System.Windows.Forms.Label
   Friend WithEvents CustomBar1 As WIN.GUI.APPLICATION.PRESENTATION.CustomBar
   Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents CmdVis As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents refBox As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents lblIdPrest As System.Windows.Forms.Label
    Friend WithEvents txtIdPrest As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents SpAddFile As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents SpView As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SpDel As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents SpDelRef As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents lblDocumento As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider

End Class
