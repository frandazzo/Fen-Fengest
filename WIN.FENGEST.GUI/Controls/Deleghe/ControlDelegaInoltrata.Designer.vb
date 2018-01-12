<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlDelegaInoltrata
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlDelegaInoltrata))
        Me.txtIdDelega = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblEnte = New System.Windows.Forms.Label()
        Me.cboEnti = New System.Windows.Forms.ComboBox()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.lblSettore = New System.Windows.Forms.Label()
        Me.cboSettori = New System.Windows.Forms.ComboBox()
        Me.dtpDoc = New System.Windows.Forms.DateTimePicker()
        Me.dtpData = New System.Windows.Forms.DateTimePicker()
        Me.lblDescrizioneUtente = New System.Windows.Forms.Label()
        Me.lblDescrizioneReferente = New System.Windows.Forms.Label()
        Me.lblDescrizioneAzienda = New System.Windows.Forms.Label()
        Me.IdAziendaTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdAziendaTextBox()
        Me.lblAzienda = New System.Windows.Forms.Label()
        Me.dtpInoltro = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.IdReferenteTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox()
        Me.IdUtenteTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdUtenteTextBox()
        Me.lblReferente = New System.Windows.Forms.Label()
        Me.lblUtente = New System.Windows.Forms.Label()
        Me.CustomBar1 = New WIN.GUI.APPLICATION.PRESENTATION.CustomBar()
        Me.GroupBox1 = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.cboSede = New System.Windows.Forms.ComboBox()
        Me.lblSedeOperativa = New System.Windows.Forms.Label()
        Me.cboCausaliSott = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboReparto = New System.Windows.Forms.ComboBox()
        Me.lblReparto = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.MainGroup = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.IdReferenteTextBox2 = New WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox()
        Me.lblDescrizioneResponsabile = New System.Windows.Forms.Label()
        Me.lblResponsabile = New System.Windows.Forms.Label()
        Me.SpCmdAccetta = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.SpAnnulla = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.SpCmdRevoca = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.SpRipristina = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.DockPanel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MainGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Size = New System.Drawing.Size(614, 22)
        '
        'DockPanel
        '
        Me.DockPanel.Controls.Add(Me.lblId)
        Me.DockPanel.Controls.Add(Me.txtIdDelega)
        Me.DockPanel.Controls.Add(Me.CustomBar1)
        Me.DockPanel.Controls.Add(Me.SpCmdAccetta)
        Me.DockPanel.Controls.Add(Me.SpAnnulla)
        Me.DockPanel.Controls.Add(Me.SpCmdRevoca)
        Me.DockPanel.Controls.Add(Me.SpRipristina)
        Me.DockPanel.Location = New System.Drawing.Point(0, 22)
        Me.DockPanel.Size = New System.Drawing.Size(614, 44)
        '
        'txtIdDelega
        '
        Me.HelpProvider1.SetHelpString(Me.txtIdDelega, "Identificativo della delega")
        Me.txtIdDelega.Location = New System.Drawing.Point(64, 12)
        Me.txtIdDelega.Name = "txtIdDelega"
        Me.HelpProvider1.SetShowHelp(Me.txtIdDelega, True)
        Me.txtIdDelega.Size = New System.Drawing.Size(52, 21)
        Me.txtIdDelega.TabIndex = 28
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.BackColor = System.Drawing.Color.Transparent
        Me.lblId.Location = New System.Drawing.Point(6, 17)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(56, 13)
        Me.lblId.TabIndex = 27
        Me.lblId.Text = "Id. delega"
        '
        'lblEnte
        '
        Me.lblEnte.AutoSize = True
        Me.lblEnte.BackColor = System.Drawing.Color.Transparent
        Me.lblEnte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblEnte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnte.Location = New System.Drawing.Point(29, 164)
        Me.lblEnte.Name = "lblEnte"
        Me.lblEnte.Size = New System.Drawing.Size(29, 13)
        Me.lblEnte.TabIndex = 45
        Me.lblEnte.Text = "Ente"
        '
        'cboEnti
        '
        Me.cboEnti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEnti.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEnti.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboEnti, "Ente bilaterale verso cui è stata inoltrata la delega sottoscritta dall'utente. G" & _
        "li enti bilaterali sono EdilCassa e CassaEdile")
        Me.cboEnti.Location = New System.Drawing.Point(69, 160)
        Me.cboEnti.Name = "cboEnti"
        Me.HelpProvider1.SetShowHelp(Me.cboEnti, True)
        Me.cboEnti.Size = New System.Drawing.Size(149, 21)
        Me.cboEnti.TabIndex = 7
        '
        'txtNote
        '
        Me.txtNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtNote, "Eventuali note legate alla sottoscrizione della delega.")
        Me.txtNote.Location = New System.Drawing.Point(69, 252)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.HelpProvider1.SetShowHelp(Me.txtNote, True)
        Me.txtNote.Size = New System.Drawing.Size(315, 83)
        Me.txtNote.TabIndex = 5
        '
        'lblSettore
        '
        Me.lblSettore.AutoSize = True
        Me.lblSettore.BackColor = System.Drawing.Color.Transparent
        Me.lblSettore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSettore.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettore.Location = New System.Drawing.Point(18, 95)
        Me.lblSettore.Name = "lblSettore"
        Me.lblSettore.Size = New System.Drawing.Size(41, 13)
        Me.lblSettore.TabIndex = 41
        Me.lblSettore.Text = "Settore"
        '
        'cboSettori
        '
        Me.cboSettori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSettori.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSettori.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboSettori, "Settore di pertinenza della delega.I settori sono EDILE e IMPIANTI FISSI")
        Me.cboSettori.Location = New System.Drawing.Point(69, 88)
        Me.cboSettori.Name = "cboSettori"
        Me.HelpProvider1.SetShowHelp(Me.cboSettori, True)
        Me.cboSettori.Size = New System.Drawing.Size(209, 21)
        Me.cboSettori.TabIndex = 6
        '
        'dtpDoc
        '
        Me.dtpDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDoc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.HelpProvider1.SetHelpString(Me.dtpDoc, "Data documento della delega.Si ricordi che la data documento è la data in cui il " & _
        "funzionario ha fatto sottoscrivere la delega.")
        Me.dtpDoc.Location = New System.Drawing.Point(282, 30)
        Me.dtpDoc.Name = "dtpDoc"
        Me.HelpProvider1.SetShowHelp(Me.dtpDoc, True)
        Me.dtpDoc.Size = New System.Drawing.Size(99, 20)
        Me.dtpDoc.TabIndex = 2
        '
        'dtpData
        '
        Me.dtpData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.HelpProvider1.SetHelpString(Me.dtpData, "Data di registrazione della delega. Si ricordi che la data di registrazione è la " & _
        "data in cui il funzionario registra la sottoscrizione della delega.")
        Me.dtpData.Location = New System.Drawing.Point(69, 30)
        Me.dtpData.Name = "dtpData"
        Me.HelpProvider1.SetShowHelp(Me.dtpData, True)
        Me.dtpData.Size = New System.Drawing.Size(99, 20)
        Me.dtpData.TabIndex = 1
        '
        'lblDescrizioneUtente
        '
        Me.lblDescrizioneUtente.AutoSize = True
        Me.lblDescrizioneUtente.BackColor = System.Drawing.Color.Transparent
        Me.lblDescrizioneUtente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrizioneUtente.ForeColor = System.Drawing.Color.Black
        Me.lblDescrizioneUtente.Location = New System.Drawing.Point(165, 126)
        Me.lblDescrizioneUtente.Name = "lblDescrizioneUtente"
        Me.lblDescrizioneUtente.Size = New System.Drawing.Size(0, 13)
        Me.lblDescrizioneUtente.TabIndex = 0
        '
        'lblDescrizioneReferente
        '
        Me.lblDescrizioneReferente.AutoSize = True
        Me.lblDescrizioneReferente.BackColor = System.Drawing.Color.Transparent
        Me.lblDescrizioneReferente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrizioneReferente.ForeColor = System.Drawing.Color.Black
        Me.lblDescrizioneReferente.Location = New System.Drawing.Point(177, 40)
        Me.lblDescrizioneReferente.Name = "lblDescrizioneReferente"
        Me.lblDescrizioneReferente.Size = New System.Drawing.Size(0, 13)
        Me.lblDescrizioneReferente.TabIndex = 0
        '
        'lblDescrizioneAzienda
        '
        Me.lblDescrizioneAzienda.AutoSize = True
        Me.lblDescrizioneAzienda.BackColor = System.Drawing.Color.Transparent
        Me.lblDescrizioneAzienda.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrizioneAzienda.ForeColor = System.Drawing.Color.Black
        Me.lblDescrizioneAzienda.Location = New System.Drawing.Point(159, 165)
        Me.lblDescrizioneAzienda.Name = "lblDescrizioneAzienda"
        Me.lblDescrizioneAzienda.Size = New System.Drawing.Size(0, 13)
        Me.lblDescrizioneAzienda.TabIndex = 0
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
        Me.IdAziendaTextBox1.Location = New System.Drawing.Point(67, 159)
        Me.IdAziendaTextBox1.Mandatory = False
        Me.IdAziendaTextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.IdAziendaTextBox1.Name = "IdAziendaTextBox1"
        Me.HelpProvider1.SetShowHelp(Me.IdAziendaTextBox1, True)
        Me.IdAziendaTextBox1.Size = New System.Drawing.Size(93, 26)
        Me.IdAziendaTextBox1.TabIndex = 8
        Me.IdAziendaTextBox1.TextValue = ""
        '
        'lblAzienda
        '
        Me.lblAzienda.AutoSize = True
        Me.lblAzienda.BackColor = System.Drawing.Color.Transparent
        Me.lblAzienda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAzienda.ForeColor = System.Drawing.Color.Black
        Me.lblAzienda.Location = New System.Drawing.Point(15, 164)
        Me.lblAzienda.Name = "lblAzienda"
        Me.lblAzienda.Size = New System.Drawing.Size(45, 13)
        Me.lblAzienda.TabIndex = 27
        Me.lblAzienda.Text = "Azienda"
        '
        'dtpInoltro
        '
        Me.dtpInoltro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.HelpProvider1.SetHelpString(Me.dtpInoltro, resources.GetString("dtpInoltro.HelpString"))
        Me.dtpInoltro.Location = New System.Drawing.Point(69, 25)
        Me.dtpInoltro.Name = "dtpInoltro"
        Me.HelpProvider1.SetShowHelp(Me.dtpInoltro, True)
        Me.dtpInoltro.Size = New System.Drawing.Size(106, 21)
        Me.dtpInoltro.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(8, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Inoltro"
        '
        'IdReferenteTextBox1
        '
        Me.IdReferenteTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.IdReferenteTextBox1.DescriptionOfText = ""
        Me.IdReferenteTextBox1.DescriptionTextWidth = 150
        Me.IdReferenteTextBox1.DescriptionTextXValue = 92
        Me.IdReferenteTextBox1.EnableSerchTextBox = True
        Me.HelpProvider1.SetHelpNavigator(Me.IdReferenteTextBox1, System.Windows.Forms.HelpNavigator.KeywordIndex)
        Me.HelpProvider1.SetHelpString(Me.IdReferenteTextBox1, resources.GetString("IdReferenteTextBox1.HelpString"))
        Me.IdReferenteTextBox1.IsDescriptionVisible = False
        Me.IdReferenteTextBox1.Location = New System.Drawing.Point(76, 29)
        Me.IdReferenteTextBox1.Mandatory = False
        Me.IdReferenteTextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.IdReferenteTextBox1.Name = "IdReferenteTextBox1"
        Me.HelpProvider1.SetShowHelp(Me.IdReferenteTextBox1, True)
        Me.IdReferenteTextBox1.Size = New System.Drawing.Size(93, 29)
        Me.IdReferenteTextBox1.TabIndex = 11
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
        Me.IdUtenteTextBox1.Location = New System.Drawing.Point(67, 120)
        Me.IdUtenteTextBox1.Mandatory = False
        Me.IdUtenteTextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.IdUtenteTextBox1.Name = "IdUtenteTextBox1"
        Me.HelpProvider1.SetShowHelp(Me.IdUtenteTextBox1, True)
        Me.IdUtenteTextBox1.Size = New System.Drawing.Size(92, 23)
        Me.IdUtenteTextBox1.TabIndex = 3
        Me.IdUtenteTextBox1.TextValue = ""
        '
        'lblReferente
        '
        Me.lblReferente.AutoSize = True
        Me.lblReferente.BackColor = System.Drawing.Color.Transparent
        Me.lblReferente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReferente.ForeColor = System.Drawing.Color.Black
        Me.lblReferente.Location = New System.Drawing.Point(30, 40)
        Me.lblReferente.Name = "lblReferente"
        Me.lblReferente.Size = New System.Drawing.Size(27, 13)
        Me.lblReferente.TabIndex = 15
        Me.lblReferente.Text = "Coll."
        '
        'lblUtente
        '
        Me.lblUtente.AutoSize = True
        Me.lblUtente.BackColor = System.Drawing.Color.Transparent
        Me.lblUtente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUtente.ForeColor = System.Drawing.Color.Black
        Me.lblUtente.Location = New System.Drawing.Point(11, 125)
        Me.lblUtente.Name = "lblUtente"
        Me.lblUtente.Size = New System.Drawing.Size(49, 13)
        Me.lblUtente.TabIndex = 13
        Me.lblUtente.Text = "Id utente"
        '
        'CustomBar1
        '
        Me.CustomBar1.BackColor = System.Drawing.Color.Transparent
        Me.CustomBar1.Location = New System.Drawing.Point(121, 2)
        Me.CustomBar1.Name = "CustomBar1"
        Me.CustomBar1.Size = New System.Drawing.Size(295, 40)
        Me.CustomBar1.TabIndex = 45
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.Controls.Add(Me.cboSede)
        Me.GroupBox1.Controls.Add(Me.lblSedeOperativa)
        Me.GroupBox1.Controls.Add(Me.cboCausaliSott)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboReparto)
        Me.GroupBox1.Controls.Add(Me.lblReparto)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lblEnte)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cboEnti)
        Me.GroupBox1.Controls.Add(Me.lblSettore)
        Me.GroupBox1.Controls.Add(Me.txtNote)
        Me.GroupBox1.Controls.Add(Me.lblAzienda)
        Me.GroupBox1.Controls.Add(Me.dtpDoc)
        Me.GroupBox1.Controls.Add(Me.IdAziendaTextBox1)
        Me.GroupBox1.Controls.Add(Me.cboSettori)
        Me.GroupBox1.Controls.Add(Me.lblDescrizioneAzienda)
        Me.GroupBox1.Controls.Add(Me.dtpData)
        Me.GroupBox1.Controls.Add(Me.IdUtenteTextBox1)
        Me.GroupBox1.Controls.Add(Me.lblDescrizioneUtente)
        Me.GroupBox1.Controls.Add(Me.lblUtente)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(11, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(438, 349)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.Text = "Dati principali"
        Me.GroupBox1.Title = "Dati Generali"
        '
        'cboSede
        '
        Me.cboSede.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSede.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboSede, "Sede operativa dell'azienda presso cui il lavoratore è impiegato.Essa è indicata " & _
        "solo nel caso di delega del settore IMPIANTI FISSI")
        Me.cboSede.Location = New System.Drawing.Point(69, 223)
        Me.cboSede.Name = "cboSede"
        Me.HelpProvider1.SetShowHelp(Me.cboSede, True)
        Me.cboSede.Size = New System.Drawing.Size(149, 21)
        Me.cboSede.TabIndex = 64
        '
        'lblSedeOperativa
        '
        Me.lblSedeOperativa.AutoSize = True
        Me.lblSedeOperativa.BackColor = System.Drawing.Color.Transparent
        Me.lblSedeOperativa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSedeOperativa.Location = New System.Drawing.Point(9, 228)
        Me.lblSedeOperativa.Name = "lblSedeOperativa"
        Me.lblSedeOperativa.Size = New System.Drawing.Size(50, 13)
        Me.lblSedeOperativa.TabIndex = 63
        Me.lblSedeOperativa.Text = "Sede op."
        '
        'cboCausaliSott
        '
        Me.cboCausaliSott.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCausaliSott.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCausaliSott.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboCausaliSott, "Causale di sottoscrizione della delega. Le causali possono essere impostate dal M" & _
        "enu Strumenti->Setup->Segreteria->Causali deleghe.")
        Me.cboCausaliSott.Location = New System.Drawing.Point(69, 60)
        Me.cboCausaliSott.Name = "cboCausaliSott"
        Me.HelpProvider1.SetShowHelp(Me.cboCausaliSott, True)
        Me.cboCausaliSott.Size = New System.Drawing.Size(209, 21)
        Me.cboCausaliSott.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Caus. sott."
        '
        'cboReparto
        '
        Me.cboReparto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboReparto.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboReparto, "Reparto dell'azienda in cui lavora l'utente. Esso è indicato soltanto nel caso di" & _
        " delega del settore IMPIANTI FISSI")
        Me.cboReparto.Location = New System.Drawing.Point(70, 191)
        Me.cboReparto.Name = "cboReparto"
        Me.HelpProvider1.SetShowHelp(Me.cboReparto, True)
        Me.cboReparto.Size = New System.Drawing.Size(149, 21)
        Me.cboReparto.TabIndex = 9
        '
        'lblReparto
        '
        Me.lblReparto.AutoSize = True
        Me.lblReparto.BackColor = System.Drawing.Color.Transparent
        Me.lblReparto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReparto.Location = New System.Drawing.Point(14, 199)
        Me.lblReparto.Name = "lblReparto"
        Me.lblReparto.Size = New System.Drawing.Size(45, 13)
        Me.lblReparto.TabIndex = 62
        Me.lblReparto.Text = "Reparto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 41
        Me.Label5.Text = "Note"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(11, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Data reg."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(225, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "Data doc."
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Silver
        Me.GroupBox2.Controls.Add(Me.dtpInoltro)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(11, 428)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(438, 58)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.Title = "Inoltro"
        '
        'MainGroup
        '
        Me.MainGroup.BackColor = System.Drawing.Color.Silver
        Me.MainGroup.Controls.Add(Me.IdReferenteTextBox2)
        Me.MainGroup.Controls.Add(Me.lblDescrizioneResponsabile)
        Me.MainGroup.Controls.Add(Me.lblResponsabile)
        Me.MainGroup.Controls.Add(Me.lblReferente)
        Me.MainGroup.Controls.Add(Me.IdReferenteTextBox1)
        Me.MainGroup.Controls.Add(Me.lblDescrizioneReferente)
        Me.MainGroup.ForeColor = System.Drawing.Color.Black
        Me.MainGroup.Location = New System.Drawing.Point(11, 491)
        Me.MainGroup.Name = "MainGroup"
        Me.MainGroup.Size = New System.Drawing.Size(438, 104)
        Me.MainGroup.TabIndex = 3
        Me.MainGroup.Title = "Dati collaboratore comunale"
        '
        'IdReferenteTextBox2
        '
        Me.IdReferenteTextBox2.BackColor = System.Drawing.Color.Transparent
        Me.IdReferenteTextBox2.DescriptionOfText = ""
        Me.IdReferenteTextBox2.DescriptionTextWidth = 150
        Me.IdReferenteTextBox2.DescriptionTextXValue = 92
        Me.IdReferenteTextBox2.EnableSerchTextBox = True
        Me.HelpProvider1.SetHelpString(Me.IdReferenteTextBox2, "Identificativo del funzionario della segreteria provinciale  che è responsabile d" & _
        "ella delega")
        Me.IdReferenteTextBox2.IsDescriptionVisible = False
        Me.IdReferenteTextBox2.Location = New System.Drawing.Point(76, 68)
        Me.IdReferenteTextBox2.Mandatory = False
        Me.IdReferenteTextBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.IdReferenteTextBox2.Name = "IdReferenteTextBox2"
        Me.HelpProvider1.SetShowHelp(Me.IdReferenteTextBox2, True)
        Me.IdReferenteTextBox2.Size = New System.Drawing.Size(93, 25)
        Me.IdReferenteTextBox2.TabIndex = 18
        Me.IdReferenteTextBox2.TextValue = ""
        '
        'lblDescrizioneResponsabile
        '
        Me.lblDescrizioneResponsabile.AutoSize = True
        Me.lblDescrizioneResponsabile.BackColor = System.Drawing.Color.Transparent
        Me.lblDescrizioneResponsabile.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrizioneResponsabile.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDescrizioneResponsabile.Location = New System.Drawing.Point(177, 72)
        Me.lblDescrizioneResponsabile.Name = "lblDescrizioneResponsabile"
        Me.lblDescrizioneResponsabile.Size = New System.Drawing.Size(0, 13)
        Me.lblDescrizioneResponsabile.TabIndex = 17
        '
        'lblResponsabile
        '
        Me.lblResponsabile.AutoSize = True
        Me.lblResponsabile.BackColor = System.Drawing.Color.Transparent
        Me.lblResponsabile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblResponsabile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResponsabile.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblResponsabile.Location = New System.Drawing.Point(3, 72)
        Me.lblResponsabile.Name = "lblResponsabile"
        Me.lblResponsabile.Size = New System.Drawing.Size(71, 13)
        Me.lblResponsabile.TabIndex = 16
        Me.lblResponsabile.Text = "Responsabile"
        '
        'SpCmdAccetta
        '
        Me.SpCmdAccetta.ApplyOutLookStile = True
        Me.SpCmdAccetta.BackColor = System.Drawing.Color.Transparent
        Me.SpCmdAccetta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SpCmdAccetta.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.desktop_32x32
        Me.SpCmdAccetta.Disabled = False
        Me.SpCmdAccetta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SpCmdAccetta.ForeColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.SpCmdAccetta, resources.GetString("SpCmdAccetta.HelpString"))
        Me.SpCmdAccetta.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SpCmdAccetta.Location = New System.Drawing.Point(422, 7)
        Me.SpCmdAccetta.Name = "SpCmdAccetta"
        Me.SpCmdAccetta.Radius = 32.0!
        Me.HelpProvider1.SetShowHelp(Me.SpCmdAccetta, True)
        Me.SpCmdAccetta.ShowTooltip = True
        Me.SpCmdAccetta.Size = New System.Drawing.Size(32, 32)
        Me.SpCmdAccetta.TabIndex = 5
        Me.SpCmdAccetta.TextValue = ""
        Me.SpCmdAccetta.TooltipText = "Accetta delega"
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
        Me.SpAnnulla.Location = New System.Drawing.Point(466, 7)
        Me.SpAnnulla.Name = "SpAnnulla"
        Me.SpAnnulla.Radius = 32.0!
        Me.HelpProvider1.SetShowHelp(Me.SpAnnulla, True)
        Me.SpAnnulla.ShowTooltip = True
        Me.SpAnnulla.Size = New System.Drawing.Size(32, 32)
        Me.SpAnnulla.TabIndex = 6
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
        Me.SpCmdRevoca.Location = New System.Drawing.Point(511, 7)
        Me.SpCmdRevoca.Name = "SpCmdRevoca"
        Me.SpCmdRevoca.Radius = 32.0!
        Me.HelpProvider1.SetShowHelp(Me.SpCmdRevoca, True)
        Me.SpCmdRevoca.ShowTooltip = True
        Me.SpCmdRevoca.Size = New System.Drawing.Size(32, 32)
        Me.SpCmdRevoca.TabIndex = 7
        Me.SpCmdRevoca.TextValue = ""
        Me.SpCmdRevoca.TooltipText = "Revoca delega"
        '
        'SpRipristina
        '
        Me.SpRipristina.ApplyOutLookStile = True
        Me.SpRipristina.BackColor = System.Drawing.Color.Transparent
        Me.SpRipristina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SpRipristina.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.package_development_32x32
        Me.SpRipristina.Disabled = False
        Me.SpRipristina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SpRipristina.ForeColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.SpRipristina, "Funzione che permette di ripristinare lo stato precedente della delega. Questa fu" & _
        "nzione serve per proteggere il sistema da eventuali errori di immissione da part" & _
        "e del funzionario della federazione.")
        Me.SpRipristina.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SpRipristina.Location = New System.Drawing.Point(554, 7)
        Me.SpRipristina.Name = "SpRipristina"
        Me.SpRipristina.Radius = 32.0!
        Me.HelpProvider1.SetShowHelp(Me.SpRipristina, True)
        Me.SpRipristina.ShowTooltip = True
        Me.SpRipristina.Size = New System.Drawing.Size(32, 32)
        Me.SpRipristina.TabIndex = 8
        Me.SpRipristina.TextValue = ""
        Me.SpRipristina.TooltipText = "Ripristina stato precedente"
        '
        'ControlDelegaInoltrata
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.MainGroup)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ControlDelegaInoltrata"
        Me.Size = New System.Drawing.Size(614, 607)
        Me.Controls.SetChildIndex(Me.DockPanel, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.MainGroup, 0)
        Me.DockPanel.ResumeLayout(False)
        Me.DockPanel.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MainGroup.ResumeLayout(False)
        Me.MainGroup.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtIdDelega As System.Windows.Forms.TextBox
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents dtpInoltro As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents IdReferenteTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox
    Friend WithEvents IdUtenteTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdUtenteTextBox
    Friend WithEvents lblReferente As System.Windows.Forms.Label
    Friend WithEvents lblUtente As System.Windows.Forms.Label
    Friend WithEvents IdAziendaTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdAziendaTextBox
    Friend WithEvents lblAzienda As System.Windows.Forms.Label
    Friend WithEvents lblDescrizioneAzienda As System.Windows.Forms.Label
    Friend WithEvents lblDescrizioneReferente As System.Windows.Forms.Label
    Friend WithEvents lblDescrizioneUtente As System.Windows.Forms.Label
    Friend WithEvents dtpDoc As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpData As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblSettore As System.Windows.Forms.Label
    Friend WithEvents cboSettori As System.Windows.Forms.ComboBox
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents lblEnte As System.Windows.Forms.Label
    Friend WithEvents cboEnti As System.Windows.Forms.ComboBox
    Friend WithEvents CustomBar1 As WIN.GUI.APPLICATION.PRESENTATION.CustomBar
   Friend WithEvents SpCmdRevoca As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents SpCmdAccetta As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents SpRipristina As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents SpAnnulla As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents GroupBox1 As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents MainGroup As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents cboReparto As System.Windows.Forms.ComboBox
   Friend WithEvents lblReparto As System.Windows.Forms.Label
   Friend WithEvents cboCausaliSott As System.Windows.Forms.ComboBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents IdReferenteTextBox2 As WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox
   Friend WithEvents lblDescrizioneResponsabile As System.Windows.Forms.Label
   Friend WithEvents lblResponsabile As System.Windows.Forms.Label
   Friend WithEvents cboSede As System.Windows.Forms.ComboBox
    Friend WithEvents lblSedeOperativa As System.Windows.Forms.Label
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider

End Class
