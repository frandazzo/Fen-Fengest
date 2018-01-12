<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlDelegaAccettata
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlDelegaAccettata))
        Me.txtIdDelega = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblEnte = New System.Windows.Forms.Label()
        Me.cboEnti = New System.Windows.Forms.ComboBox()
        Me.cboSettori = New System.Windows.Forms.ComboBox()
        Me.dtpDoc = New System.Windows.Forms.DateTimePicker()
        Me.dtpData = New System.Windows.Forms.DateTimePicker()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.lblDescrizioneAzienda = New System.Windows.Forms.Label()
        Me.lblDescrizioneReferente = New System.Windows.Forms.Label()
        Me.lblDescrizioneUtente = New System.Windows.Forms.Label()
        Me.IdAziendaTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdAziendaTextBox()
        Me.lblAzienda = New System.Windows.Forms.Label()
        Me.dtpInoltro = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.IdReferenteTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox()
        Me.IdUtenteTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdUtenteTextBox()
        Me.lblReferente = New System.Windows.Forms.Label()
        Me.lblUtente = New System.Windows.Forms.Label()
        Me.dtpAccettazione = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CustomBar1 = New WIN.GUI.APPLICATION.PRESENTATION.CustomBar()
        Me.MainGroup = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.cboReparto = New System.Windows.Forms.ComboBox()
        Me.lblReparto = New System.Windows.Forms.Label()
        Me.cboSede = New System.Windows.Forms.ComboBox()
        Me.lblSedeOperativa = New System.Windows.Forms.Label()
        Me.cboCausaliSott = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.IdReferenteTextBox2 = New WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox()
        Me.lblDescrizioneResponsabile = New System.Windows.Forms.Label()
        Me.lblResponsabile = New System.Windows.Forms.Label()
        Me.GroupBox3 = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.SpRipristina = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.SpAnnulla = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.SpCmdRevoca = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.DockPanel.SuspendLayout()
        Me.MainGroup.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Size = New System.Drawing.Size(561, 22)
        '
        'DockPanel
        '
        Me.DockPanel.Controls.Add(Me.lblId)
        Me.DockPanel.Controls.Add(Me.txtIdDelega)
        Me.DockPanel.Controls.Add(Me.CustomBar1)
        Me.DockPanel.Controls.Add(Me.SpRipristina)
        Me.DockPanel.Controls.Add(Me.SpAnnulla)
        Me.DockPanel.Controls.Add(Me.SpCmdRevoca)
        Me.DockPanel.Location = New System.Drawing.Point(0, 22)
        Me.DockPanel.Size = New System.Drawing.Size(561, 44)
        '
        'txtIdDelega
        '
        Me.HelpProvider1.SetHelpString(Me.txtIdDelega, "Identificativo della delega")
        Me.txtIdDelega.Location = New System.Drawing.Point(65, 12)
        Me.txtIdDelega.Name = "txtIdDelega"
        Me.HelpProvider1.SetShowHelp(Me.txtIdDelega, True)
        Me.txtIdDelega.Size = New System.Drawing.Size(58, 21)
        Me.txtIdDelega.TabIndex = 35
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.BackColor = System.Drawing.Color.Transparent
        Me.lblId.Location = New System.Drawing.Point(6, 18)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(56, 13)
        Me.lblId.TabIndex = 34
        Me.lblId.Text = "Id. delega"
        '
        'lblEnte
        '
        Me.lblEnte.AutoSize = True
        Me.lblEnte.BackColor = System.Drawing.Color.Transparent
        Me.lblEnte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblEnte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnte.Location = New System.Drawing.Point(12, 159)
        Me.lblEnte.Name = "lblEnte"
        Me.lblEnte.Size = New System.Drawing.Size(43, 13)
        Me.lblEnte.TabIndex = 57
        Me.lblEnte.Text = "Ente in."
        '
        'cboEnti
        '
        Me.cboEnti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEnti.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEnti.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboEnti, "Ente bilaterale verso cui è stata inoltrata la delega sottoscritta dall'utente. G" & _
        "li enti bilaterali sono EdilCassa e CassaEdile")
        Me.cboEnti.Location = New System.Drawing.Point(65, 151)
        Me.cboEnti.Name = "cboEnti"
        Me.HelpProvider1.SetShowHelp(Me.cboEnti, True)
        Me.cboEnti.Size = New System.Drawing.Size(139, 21)
        Me.cboEnti.TabIndex = 7
        '
        'cboSettori
        '
        Me.cboSettori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSettori.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSettori.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboSettori, "Settore di pertinenza della delega.I settori sono EDILE e IMPIANTI FISSI")
        Me.cboSettori.Location = New System.Drawing.Point(65, 81)
        Me.cboSettori.Name = "cboSettori"
        Me.HelpProvider1.SetShowHelp(Me.cboSettori, True)
        Me.cboSettori.Size = New System.Drawing.Size(197, 21)
        Me.cboSettori.TabIndex = 6
        '
        'dtpDoc
        '
        Me.dtpDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDoc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.HelpProvider1.SetHelpString(Me.dtpDoc, "Data documento della delega.Si ricordi che la data documento è la data in cui il " & _
        "funzionario ha fatto sottoscrivere la delega.")
        Me.dtpDoc.Location = New System.Drawing.Point(267, 25)
        Me.dtpDoc.Name = "dtpDoc"
        Me.HelpProvider1.SetShowHelp(Me.dtpDoc, True)
        Me.dtpDoc.Size = New System.Drawing.Size(103, 20)
        Me.dtpDoc.TabIndex = 2
        '
        'dtpData
        '
        Me.dtpData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.HelpProvider1.SetHelpString(Me.dtpData, "Data di registrazione della delega. Si ricordi che la data di registrazione è la " & _
        "data in cui il funzionario registra la sottoscrizione della delega.")
        Me.dtpData.Location = New System.Drawing.Point(65, 23)
        Me.dtpData.Name = "dtpData"
        Me.HelpProvider1.SetShowHelp(Me.dtpData, True)
        Me.dtpData.Size = New System.Drawing.Size(103, 20)
        Me.dtpData.TabIndex = 1
        '
        'txtNote
        '
        Me.txtNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtNote, "Eventuali note legate alla sottoscrizione della delega.")
        Me.txtNote.Location = New System.Drawing.Point(65, 248)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.HelpProvider1.SetShowHelp(Me.txtNote, True)
        Me.txtNote.Size = New System.Drawing.Size(282, 68)
        Me.txtNote.TabIndex = 5
        '
        'lblDescrizioneAzienda
        '
        Me.lblDescrizioneAzienda.AutoSize = True
        Me.lblDescrizioneAzienda.BackColor = System.Drawing.Color.Transparent
        Me.lblDescrizioneAzienda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrizioneAzienda.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDescrizioneAzienda.Location = New System.Drawing.Point(172, 159)
        Me.lblDescrizioneAzienda.Name = "lblDescrizioneAzienda"
        Me.lblDescrizioneAzienda.Size = New System.Drawing.Size(0, 13)
        Me.lblDescrizioneAzienda.TabIndex = 0
        '
        'lblDescrizioneReferente
        '
        Me.lblDescrizioneReferente.AutoSize = True
        Me.lblDescrizioneReferente.BackColor = System.Drawing.Color.Transparent
        Me.lblDescrizioneReferente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrizioneReferente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDescrizioneReferente.Location = New System.Drawing.Point(190, 35)
        Me.lblDescrizioneReferente.Name = "lblDescrizioneReferente"
        Me.lblDescrizioneReferente.Size = New System.Drawing.Size(0, 13)
        Me.lblDescrizioneReferente.TabIndex = 0
        '
        'lblDescrizioneUtente
        '
        Me.lblDescrizioneUtente.AutoSize = True
        Me.lblDescrizioneUtente.BackColor = System.Drawing.Color.Transparent
        Me.lblDescrizioneUtente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrizioneUtente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDescrizioneUtente.Location = New System.Drawing.Point(178, 121)
        Me.lblDescrizioneUtente.Name = "lblDescrizioneUtente"
        Me.lblDescrizioneUtente.Size = New System.Drawing.Size(0, 13)
        Me.lblDescrizioneUtente.TabIndex = 0
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
        Me.HelpProvider1.SetHelpString(Me.IdAziendaTextBox1, "Identificativo dell'azienda di impiego del lavoratore. Essa viene inserita nel ca" & _
        "so di delega del settore IMPIANTI FISSI")
        Me.IdAziendaTextBox1.IsDescriptionVisible = False
        Me.IdAziendaTextBox1.Location = New System.Drawing.Point(64, 150)
        Me.IdAziendaTextBox1.Mandatory = False
        Me.IdAziendaTextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.IdAziendaTextBox1.Name = "IdAziendaTextBox1"
        Me.HelpProvider1.SetShowHelp(Me.IdAziendaTextBox1, True)
        Me.IdAziendaTextBox1.Size = New System.Drawing.Size(99, 25)
        Me.IdAziendaTextBox1.TabIndex = 8
        Me.IdAziendaTextBox1.TextValue = ""
        '
        'lblAzienda
        '
        Me.lblAzienda.AutoSize = True
        Me.lblAzienda.BackColor = System.Drawing.Color.Transparent
        Me.lblAzienda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAzienda.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAzienda.Location = New System.Drawing.Point(24, 158)
        Me.lblAzienda.Name = "lblAzienda"
        Me.lblAzienda.Size = New System.Drawing.Size(36, 13)
        Me.lblAzienda.TabIndex = 41
        Me.lblAzienda.Text = "Az. in."
        '
        'dtpInoltro
        '
        Me.dtpInoltro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.HelpProvider1.SetHelpString(Me.dtpInoltro, resources.GetString("dtpInoltro.HelpString"))
        Me.dtpInoltro.Location = New System.Drawing.Point(65, 25)
        Me.dtpInoltro.Name = "dtpInoltro"
        Me.HelpProvider1.SetShowHelp(Me.dtpInoltro, True)
        Me.dtpInoltro.Size = New System.Drawing.Size(103, 21)
        Me.dtpInoltro.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(16, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Inoltro"
        '
        'IdReferenteTextBox1
        '
        Me.IdReferenteTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.IdReferenteTextBox1.DescriptionOfText = ""
        Me.IdReferenteTextBox1.DescriptionTextWidth = 150
        Me.IdReferenteTextBox1.DescriptionTextXValue = 92
        Me.IdReferenteTextBox1.EnableSerchTextBox = True
        Me.HelpProvider1.SetHelpString(Me.IdReferenteTextBox1, resources.GetString("IdReferenteTextBox1.HelpString"))
        Me.IdReferenteTextBox1.IsDescriptionVisible = False
        Me.IdReferenteTextBox1.Location = New System.Drawing.Point(87, 30)
        Me.IdReferenteTextBox1.Mandatory = False
        Me.IdReferenteTextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.IdReferenteTextBox1.Name = "IdReferenteTextBox1"
        Me.HelpProvider1.SetShowHelp(Me.IdReferenteTextBox1, True)
        Me.IdReferenteTextBox1.Size = New System.Drawing.Size(93, 26)
        Me.IdReferenteTextBox1.TabIndex = 14
        Me.IdReferenteTextBox1.TextValue = ""
        '
        'IdUtenteTextBox1
        '
        Me.IdUtenteTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.IdUtenteTextBox1.DescriptionOfText = ""
        Me.IdUtenteTextBox1.DescriptionTextWidth = 150
        Me.IdUtenteTextBox1.DescriptionTextXValue = 92
        Me.IdUtenteTextBox1.EnableSerchTextBox = True
        Me.IdUtenteTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.IdUtenteTextBox1, "Identificativo dell'utente")
        Me.IdUtenteTextBox1.IsDescriptionVisible = False
        Me.IdUtenteTextBox1.Location = New System.Drawing.Point(64, 115)
        Me.IdUtenteTextBox1.Mandatory = False
        Me.IdUtenteTextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.IdUtenteTextBox1.Name = "IdUtenteTextBox1"
        Me.HelpProvider1.SetShowHelp(Me.IdUtenteTextBox1, True)
        Me.IdUtenteTextBox1.Size = New System.Drawing.Size(95, 26)
        Me.IdUtenteTextBox1.TabIndex = 3
        Me.IdUtenteTextBox1.TextValue = ""
        '
        'lblReferente
        '
        Me.lblReferente.AutoSize = True
        Me.lblReferente.BackColor = System.Drawing.Color.Transparent
        Me.lblReferente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReferente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblReferente.Location = New System.Drawing.Point(24, 36)
        Me.lblReferente.Name = "lblReferente"
        Me.lblReferente.Size = New System.Drawing.Size(27, 13)
        Me.lblReferente.TabIndex = 34
        Me.lblReferente.Text = "Coll."
        '
        'lblUtente
        '
        Me.lblUtente.AutoSize = True
        Me.lblUtente.BackColor = System.Drawing.Color.Transparent
        Me.lblUtente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUtente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblUtente.Location = New System.Drawing.Point(7, 120)
        Me.lblUtente.Name = "lblUtente"
        Me.lblUtente.Size = New System.Drawing.Size(49, 13)
        Me.lblUtente.TabIndex = 33
        Me.lblUtente.Text = "Id utente"
        '
        'dtpAccettazione
        '
        Me.dtpAccettazione.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.HelpProvider1.SetHelpString(Me.dtpAccettazione, resources.GetString("dtpAccettazione.HelpString"))
        Me.dtpAccettazione.Location = New System.Drawing.Point(65, 55)
        Me.dtpAccettazione.Name = "dtpAccettazione"
        Me.HelpProvider1.SetShowHelp(Me.dtpAccettazione, True)
        Me.dtpAccettazione.Size = New System.Drawing.Size(103, 21)
        Me.dtpAccettazione.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(18, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Accett."
        '
        'CustomBar1
        '
        Me.CustomBar1.BackColor = System.Drawing.Color.Transparent
        Me.CustomBar1.Location = New System.Drawing.Point(128, 2)
        Me.CustomBar1.Name = "CustomBar1"
        Me.CustomBar1.Size = New System.Drawing.Size(293, 40)
        Me.CustomBar1.TabIndex = 7
        '
        'MainGroup
        '
        Me.MainGroup.BackColor = System.Drawing.Color.Silver
        Me.MainGroup.Controls.Add(Me.cboReparto)
        Me.MainGroup.Controls.Add(Me.lblReparto)
        Me.MainGroup.Controls.Add(Me.cboSede)
        Me.MainGroup.Controls.Add(Me.lblSedeOperativa)
        Me.MainGroup.Controls.Add(Me.cboCausaliSott)
        Me.MainGroup.Controls.Add(Me.Label1)
        Me.MainGroup.Controls.Add(Me.Label5)
        Me.MainGroup.Controls.Add(Me.Label9)
        Me.MainGroup.Controls.Add(Me.Label10)
        Me.MainGroup.Controls.Add(Me.lblEnte)
        Me.MainGroup.Controls.Add(Me.dtpDoc)
        Me.MainGroup.Controls.Add(Me.cboEnti)
        Me.MainGroup.Controls.Add(Me.Label11)
        Me.MainGroup.Controls.Add(Me.dtpData)
        Me.MainGroup.Controls.Add(Me.lblDescrizioneAzienda)
        Me.MainGroup.Controls.Add(Me.IdUtenteTextBox1)
        Me.MainGroup.Controls.Add(Me.lblUtente)
        Me.MainGroup.Controls.Add(Me.lblAzienda)
        Me.MainGroup.Controls.Add(Me.cboSettori)
        Me.MainGroup.Controls.Add(Me.IdAziendaTextBox1)
        Me.MainGroup.Controls.Add(Me.lblDescrizioneUtente)
        Me.MainGroup.Controls.Add(Me.txtNote)
        Me.MainGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainGroup.ForeColor = System.Drawing.Color.Black
        Me.MainGroup.Location = New System.Drawing.Point(11, 88)
        Me.MainGroup.Name = "MainGroup"
        Me.MainGroup.Size = New System.Drawing.Size(489, 326)
        Me.MainGroup.TabIndex = 1
        Me.MainGroup.Text = "Dati principali"
        Me.MainGroup.Title = "Dati Generali"
        '
        'cboReparto
        '
        Me.cboReparto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboReparto.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboReparto, "Reparto dell'azienda in cui lavora l'utente. Esso è indicato soltanto nel caso di" & _
        " delega del settore IMPIANTI FISSI")
        Me.cboReparto.Location = New System.Drawing.Point(65, 188)
        Me.cboReparto.Name = "cboReparto"
        Me.HelpProvider1.SetShowHelp(Me.cboReparto, True)
        Me.cboReparto.Size = New System.Drawing.Size(149, 21)
        Me.cboReparto.TabIndex = 11
        '
        'lblReparto
        '
        Me.lblReparto.AutoSize = True
        Me.lblReparto.BackColor = System.Drawing.Color.Transparent
        Me.lblReparto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReparto.Location = New System.Drawing.Point(13, 191)
        Me.lblReparto.Name = "lblReparto"
        Me.lblReparto.Size = New System.Drawing.Size(45, 13)
        Me.lblReparto.TabIndex = 60
        Me.lblReparto.Text = "Reparto"
        '
        'cboSede
        '
        Me.cboSede.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSede.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboSede, "Sede operativa dell'azienda presso cui il lavoratore è impiegato.Essa è indicata " & _
        "solo nel caso di delega del settore IMPIANTI FISSI")
        Me.cboSede.Location = New System.Drawing.Point(64, 217)
        Me.cboSede.Name = "cboSede"
        Me.HelpProvider1.SetShowHelp(Me.cboSede, True)
        Me.cboSede.Size = New System.Drawing.Size(150, 21)
        Me.cboSede.TabIndex = 66
        '
        'lblSedeOperativa
        '
        Me.lblSedeOperativa.AutoSize = True
        Me.lblSedeOperativa.BackColor = System.Drawing.Color.Transparent
        Me.lblSedeOperativa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSedeOperativa.Location = New System.Drawing.Point(10, 222)
        Me.lblSedeOperativa.Name = "lblSedeOperativa"
        Me.lblSedeOperativa.Size = New System.Drawing.Size(50, 13)
        Me.lblSedeOperativa.TabIndex = 65
        Me.lblSedeOperativa.Text = "Sede op."
        '
        'cboCausaliSott
        '
        Me.cboCausaliSott.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCausaliSott.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCausaliSott.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboCausaliSott, "Causale di sottoscrizione della delega. Le causali possono essere impostate dal M" & _
        "enu Strumenti->Setup->Segreteria->Causali deleghe.")
        Me.cboCausaliSott.Location = New System.Drawing.Point(65, 53)
        Me.cboCausaliSott.Name = "cboCausaliSott"
        Me.HelpProvider1.SetShowHelp(Me.cboCausaliSott, True)
        Me.cboCausaliSott.Size = New System.Drawing.Size(196, 21)
        Me.cboCausaliSott.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Caus. sott."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 251)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Note"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(8, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Data reg."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(210, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 13)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Data doc."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(13, 87)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 13)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Settore"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Silver
        Me.GroupBox2.Controls.Add(Me.IdReferenteTextBox2)
        Me.GroupBox2.Controls.Add(Me.lblDescrizioneResponsabile)
        Me.GroupBox2.Controls.Add(Me.lblResponsabile)
        Me.GroupBox2.Controls.Add(Me.lblReferente)
        Me.GroupBox2.Controls.Add(Me.lblDescrizioneReferente)
        Me.GroupBox2.Controls.Add(Me.IdReferenteTextBox1)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(9, 516)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(491, 103)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.Title = "Dati collaboratore comunale"
        '
        'IdReferenteTextBox2
        '
        Me.IdReferenteTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.IdReferenteTextBox2.DescriptionOfText = ""
        Me.IdReferenteTextBox2.DescriptionTextWidth = 150
        Me.IdReferenteTextBox2.DescriptionTextXValue = 92
        Me.IdReferenteTextBox2.EnableSerchTextBox = True
        Me.HelpProvider1.SetHelpNavigator(Me.IdReferenteTextBox2, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me.IdReferenteTextBox2, "Identificativo del funzionario della segreteria provinciale  che è responsabile d" & _
        "ella delega")
        Me.IdReferenteTextBox2.IsDescriptionVisible = False
        Me.IdReferenteTextBox2.Location = New System.Drawing.Point(87, 65)
        Me.IdReferenteTextBox2.Mandatory = False
        Me.IdReferenteTextBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.IdReferenteTextBox2.Name = "IdReferenteTextBox2"
        Me.HelpProvider1.SetShowHelp(Me.IdReferenteTextBox2, True)
        Me.IdReferenteTextBox2.Size = New System.Drawing.Size(95, 25)
        Me.IdReferenteTextBox2.TabIndex = 37
        Me.IdReferenteTextBox2.TextValue = ""
        '
        'lblDescrizioneResponsabile
        '
        Me.lblDescrizioneResponsabile.AutoSize = True
        Me.lblDescrizioneResponsabile.BackColor = System.Drawing.Color.Transparent
        Me.lblDescrizioneResponsabile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrizioneResponsabile.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDescrizioneResponsabile.Location = New System.Drawing.Point(191, 70)
        Me.lblDescrizioneResponsabile.Name = "lblDescrizioneResponsabile"
        Me.lblDescrizioneResponsabile.Size = New System.Drawing.Size(0, 13)
        Me.lblDescrizioneResponsabile.TabIndex = 36
        '
        'lblResponsabile
        '
        Me.lblResponsabile.AutoSize = True
        Me.lblResponsabile.BackColor = System.Drawing.Color.Transparent
        Me.lblResponsabile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblResponsabile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResponsabile.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblResponsabile.Location = New System.Drawing.Point(3, 70)
        Me.lblResponsabile.Name = "lblResponsabile"
        Me.lblResponsabile.Size = New System.Drawing.Size(71, 13)
        Me.lblResponsabile.TabIndex = 35
        Me.lblResponsabile.Text = "Responsabile"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Silver
        Me.GroupBox3.Controls.Add(Me.dtpAccettazione)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.dtpInoltro)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(9, 420)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(489, 90)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.Title = "Inoltro e Accettazione"
        '
        'SpRipristina
        '
        Me.SpRipristina.ApplyOutLookStile = True
        Me.SpRipristina.BackColor = System.Drawing.Color.Transparent
        Me.SpRipristina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SpRipristina.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.email_32x32
        Me.SpRipristina.Disabled = False
        Me.SpRipristina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SpRipristina.ForeColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.SpRipristina, "Funzione che permette di ripristinare lo stato precedente della delega. Questa fu" & _
        "nzione serve per proteggere il sistema da eventuali errori di immissione da part" & _
        "e del funzionario della federazione.")
        Me.SpRipristina.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SpRipristina.Location = New System.Drawing.Point(510, 9)
        Me.SpRipristina.Name = "SpRipristina"
        Me.SpRipristina.Radius = 32.0!
        Me.HelpProvider1.SetShowHelp(Me.SpRipristina, True)
        Me.SpRipristina.ShowTooltip = True
        Me.SpRipristina.Size = New System.Drawing.Size(32, 32)
        Me.SpRipristina.TabIndex = 6
        Me.SpRipristina.TextValue = ""
        Me.SpRipristina.TooltipText = "Ripristina stato precedente"
        '
        'SpAnnulla
        '
        Me.SpAnnulla.ApplyOutLookStile = True
        Me.SpAnnulla.BackColor = System.Drawing.Color.Transparent
        Me.SpAnnulla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SpAnnulla.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.trashcan_empty_32x32
        Me.SpAnnulla.Disabled = False
        Me.SpAnnulla.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SpAnnulla.ForeColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.SpAnnulla, resources.GetString("SpAnnulla.HelpString"))
        Me.SpAnnulla.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SpAnnulla.Location = New System.Drawing.Point(425, 8)
        Me.SpAnnulla.Name = "SpAnnulla"
        Me.SpAnnulla.Radius = 32.0!
        Me.HelpProvider1.SetShowHelp(Me.SpAnnulla, True)
        Me.SpAnnulla.ShowTooltip = True
        Me.SpAnnulla.Size = New System.Drawing.Size(32, 32)
        Me.SpAnnulla.TabIndex = 4
        Me.SpAnnulla.TextValue = ""
        Me.SpAnnulla.TooltipText = "Annulla  delega"
        '
        'SpCmdRevoca
        '
        Me.SpCmdRevoca.ApplyOutLookStile = True
        Me.SpCmdRevoca.BackColor = System.Drawing.Color.Transparent
        Me.SpCmdRevoca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SpCmdRevoca.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.trashcan_full_32x32
        Me.SpCmdRevoca.Disabled = False
        Me.SpCmdRevoca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SpCmdRevoca.ForeColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.SpCmdRevoca, resources.GetString("SpCmdRevoca.HelpString"))
        Me.SpCmdRevoca.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SpCmdRevoca.Location = New System.Drawing.Point(468, 8)
        Me.SpCmdRevoca.Name = "SpCmdRevoca"
        Me.SpCmdRevoca.Radius = 32.0!
        Me.HelpProvider1.SetShowHelp(Me.SpCmdRevoca, True)
        Me.SpCmdRevoca.ShowTooltip = True
        Me.SpCmdRevoca.Size = New System.Drawing.Size(32, 32)
        Me.SpCmdRevoca.TabIndex = 5
        Me.SpCmdRevoca.TextValue = ""
        Me.SpCmdRevoca.TooltipText = "Revoca delega"
        '
        'ControlDelegaAccettata
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.MainGroup)
        Me.Name = "ControlDelegaAccettata"
        Me.Size = New System.Drawing.Size(561, 645)
        Me.Controls.SetChildIndex(Me.DockPanel, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.MainGroup, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.DockPanel.ResumeLayout(False)
        Me.DockPanel.PerformLayout()
        Me.MainGroup.ResumeLayout(False)
        Me.MainGroup.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtIdDelega As System.Windows.Forms.TextBox
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents dtpAccettazione As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblDescrizioneAzienda As System.Windows.Forms.Label
    Friend WithEvents lblDescrizioneReferente As System.Windows.Forms.Label
    Friend WithEvents lblDescrizioneUtente As System.Windows.Forms.Label
    Friend WithEvents IdAziendaTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdAziendaTextBox
    Friend WithEvents lblAzienda As System.Windows.Forms.Label
    Friend WithEvents dtpInoltro As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents IdReferenteTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox
    Friend WithEvents IdUtenteTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdUtenteTextBox
    Friend WithEvents lblReferente As System.Windows.Forms.Label
    Friend WithEvents lblUtente As System.Windows.Forms.Label
    Friend WithEvents dtpDoc As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpData As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents cboSettori As System.Windows.Forms.ComboBox
    Friend WithEvents lblEnte As System.Windows.Forms.Label
    Friend WithEvents cboEnti As System.Windows.Forms.ComboBox
    Friend WithEvents CustomBar1 As WIN.GUI.APPLICATION.PRESENTATION.CustomBar
   Friend WithEvents SpRipristina As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents SpCmdRevoca As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents SpAnnulla As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents MainGroup As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents GroupBox3 As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents Label11 As System.Windows.Forms.Label
   Friend WithEvents cboCausaliSott As System.Windows.Forms.ComboBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents cboReparto As System.Windows.Forms.ComboBox
   Friend WithEvents lblReparto As System.Windows.Forms.Label
   Friend WithEvents cboSede As System.Windows.Forms.ComboBox
   Friend WithEvents lblSedeOperativa As System.Windows.Forms.Label
   Friend WithEvents IdReferenteTextBox2 As WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox
   Friend WithEvents lblDescrizioneResponsabile As System.Windows.Forms.Label
    Friend WithEvents lblResponsabile As System.Windows.Forms.Label
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider

End Class
