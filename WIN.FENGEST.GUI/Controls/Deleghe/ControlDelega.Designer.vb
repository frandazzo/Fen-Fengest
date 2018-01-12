<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlDelega
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlDelega))
        Me.lblEnte = New System.Windows.Forms.Label()
        Me.cboEnti = New System.Windows.Forms.ComboBox()
        Me.lblSettore = New System.Windows.Forms.Label()
        Me.cboSettori = New System.Windows.Forms.ComboBox()
        Me.lblDescrizioneAzienda = New System.Windows.Forms.Label()
        Me.lblDescrizioneReferente = New System.Windows.Forms.Label()
        Me.IdAziendaTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdAziendaTextBox()
        Me.lblAzienda = New System.Windows.Forms.Label()
        Me.IdReferenteTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.txtIdDelega = New System.Windows.Forms.TextBox()
        Me.CustomBar1 = New WIN.GUI.APPLICATION.PRESENTATION.CustomBar()
        Me.cboSede = New System.Windows.Forms.ComboBox()
        Me.lblSedeOperativa = New System.Windows.Forms.Label()
        Me.cboReparto = New System.Windows.Forms.ComboBox()
        Me.lblReparto = New System.Windows.Forms.Label()
        Me.IdReferenteTextBox2 = New WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox()
        Me.lblDescrizioneResponsabile = New System.Windows.Forms.Label()
        Me.lblResponsabile = New System.Windows.Forms.Label()
        Me.lblReferente = New System.Windows.Forms.Label()
        Me.cboCausaliSott = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpData = New System.Windows.Forms.DateTimePicker()
        Me.IdUtenteTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdUtenteTextBox()
        Me.dtpDoc = New System.Windows.Forms.DateTimePicker()
        Me.lblUtente = New System.Windows.Forms.Label()
        Me.lblDescrizioneUtente = New System.Windows.Forms.Label()
        Me.MainGroup = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.SpCmdInoltra = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.SpAnnulla = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.SpCmdRevoca = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.chkDuplica = New System.Windows.Forms.CheckBox()
        Me.NiceGroupBox1 = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.DockPanel.SuspendLayout()
        Me.MainGroup.SuspendLayout()
        Me.NiceGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Size = New System.Drawing.Size(590, 22)
        '
        'DockPanel
        '
        Me.DockPanel.Controls.Add(Me.chkDuplica)
        Me.DockPanel.Controls.Add(Me.SpCmdRevoca)
        Me.DockPanel.Controls.Add(Me.CustomBar1)
        Me.DockPanel.Controls.Add(Me.SpAnnulla)
        Me.DockPanel.Controls.Add(Me.lblId)
        Me.DockPanel.Controls.Add(Me.SpCmdInoltra)
        Me.DockPanel.Controls.Add(Me.txtIdDelega)
        Me.DockPanel.Location = New System.Drawing.Point(0, 22)
        Me.DockPanel.Size = New System.Drawing.Size(590, 44)
        '
        'lblEnte
        '
        Me.lblEnte.AutoSize = True
        Me.lblEnte.BackColor = System.Drawing.Color.Transparent
        Me.lblEnte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblEnte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.lblEnte, "Ente bilaterale a cui la delega verrà inoltrata.")
        Me.lblEnte.Location = New System.Drawing.Point(38, 172)
        Me.lblEnte.Name = "lblEnte"
        Me.HelpProvider1.SetShowHelp(Me.lblEnte, True)
        Me.lblEnte.Size = New System.Drawing.Size(29, 13)
        Me.lblEnte.TabIndex = 0
        Me.lblEnte.Text = "Ente"
        '
        'cboEnti
        '
        Me.cboEnti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEnti.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEnti.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboEnti, "Ente bilaterale verso cui verrà inoltrata la delega sottoscritta dall'utente. Gli" & _
        " enti bilaterali sono EdilCassa e CassaEdile")
        Me.cboEnti.Location = New System.Drawing.Point(71, 170)
        Me.cboEnti.Name = "cboEnti"
        Me.HelpProvider1.SetShowHelp(Me.cboEnti, True)
        Me.cboEnti.Size = New System.Drawing.Size(132, 21)
        Me.cboEnti.TabIndex = 7
        '
        'lblSettore
        '
        Me.lblSettore.AutoSize = True
        Me.lblSettore.BackColor = System.Drawing.Color.Transparent
        Me.lblSettore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSettore.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettore.Location = New System.Drawing.Point(27, 99)
        Me.lblSettore.Name = "lblSettore"
        Me.lblSettore.Size = New System.Drawing.Size(41, 13)
        Me.lblSettore.TabIndex = 0
        Me.lblSettore.Text = "Settore"
        '
        'cboSettori
        '
        Me.cboSettori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSettori.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSettori.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboSettori, "Settore di pertinenza della delega.I settori sono EDILE e IMPIANTI FISSI")
        Me.cboSettori.ItemHeight = 13
        Me.cboSettori.Location = New System.Drawing.Point(71, 95)
        Me.cboSettori.Name = "cboSettori"
        Me.HelpProvider1.SetShowHelp(Me.cboSettori, True)
        Me.cboSettori.Size = New System.Drawing.Size(189, 21)
        Me.cboSettori.TabIndex = 6
        '
        'lblDescrizioneAzienda
        '
        Me.lblDescrizioneAzienda.AutoSize = True
        Me.lblDescrizioneAzienda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrizioneAzienda.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDescrizioneAzienda.Location = New System.Drawing.Point(167, 176)
        Me.lblDescrizioneAzienda.Name = "lblDescrizioneAzienda"
        Me.lblDescrizioneAzienda.Size = New System.Drawing.Size(0, 13)
        Me.lblDescrizioneAzienda.TabIndex = 0
        '
        'lblDescrizioneReferente
        '
        Me.lblDescrizioneReferente.AutoSize = True
        Me.lblDescrizioneReferente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrizioneReferente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDescrizioneReferente.Location = New System.Drawing.Point(179, 37)
        Me.lblDescrizioneReferente.Name = "lblDescrizioneReferente"
        Me.lblDescrizioneReferente.Size = New System.Drawing.Size(0, 13)
        Me.lblDescrizioneReferente.TabIndex = 0
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
        Me.IdAziendaTextBox1.Location = New System.Drawing.Point(70, 169)
        Me.IdAziendaTextBox1.Mandatory = False
        Me.IdAziendaTextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.IdAziendaTextBox1.Name = "IdAziendaTextBox1"
        Me.HelpProvider1.SetShowHelp(Me.IdAziendaTextBox1, True)
        Me.IdAziendaTextBox1.Size = New System.Drawing.Size(91, 24)
        Me.IdAziendaTextBox1.TabIndex = 8
        Me.IdAziendaTextBox1.TextValue = ""
        '
        'lblAzienda
        '
        Me.lblAzienda.AutoSize = True
        Me.lblAzienda.BackColor = System.Drawing.Color.Transparent
        Me.lblAzienda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblAzienda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAzienda.ForeColor = System.Drawing.SystemColors.ControlText
        Me.HelpProvider1.SetHelpString(Me.lblAzienda, "")
        Me.lblAzienda.Location = New System.Drawing.Point(22, 172)
        Me.lblAzienda.Name = "lblAzienda"
        Me.HelpProvider1.SetShowHelp(Me.lblAzienda, True)
        Me.lblAzienda.Size = New System.Drawing.Size(45, 13)
        Me.lblAzienda.TabIndex = 22
        Me.lblAzienda.Text = "Azienda"
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
        Me.IdReferenteTextBox1.Location = New System.Drawing.Point(75, 29)
        Me.IdReferenteTextBox1.Mandatory = False
        Me.IdReferenteTextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.IdReferenteTextBox1.Name = "IdReferenteTextBox1"
        Me.HelpProvider1.SetShowHelp(Me.IdReferenteTextBox1, True)
        Me.IdReferenteTextBox1.Size = New System.Drawing.Size(92, 27)
        Me.IdReferenteTextBox1.TabIndex = 10
        Me.IdReferenteTextBox1.TextValue = ""
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.BackColor = System.Drawing.Color.Transparent
        Me.lblId.ForeColor = System.Drawing.Color.Black
        Me.lblId.Location = New System.Drawing.Point(8, 16)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(52, 13)
        Me.lblId.TabIndex = 0
        Me.lblId.Text = "Id delega"
        '
        'txtIdDelega
        '
        Me.txtIdDelega.ForeColor = System.Drawing.Color.Black
        Me.txtIdDelega.Location = New System.Drawing.Point(61, 13)
        Me.txtIdDelega.Name = "txtIdDelega"
        Me.txtIdDelega.Size = New System.Drawing.Size(55, 21)
        Me.txtIdDelega.TabIndex = 0
        '
        'CustomBar1
        '
        Me.CustomBar1.BackColor = System.Drawing.Color.Transparent
        Me.CustomBar1.Location = New System.Drawing.Point(158, 1)
        Me.CustomBar1.Name = "CustomBar1"
        Me.CustomBar1.Size = New System.Drawing.Size(295, 40)
        Me.CustomBar1.TabIndex = 26
        '
        'cboSede
        '
        Me.cboSede.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSede.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboSede, "Sede operativa dell'azienda presso cui il lavoratore è impiegato.Essa è indicata " & _
        "solo nel caso di delega del settore IMPIANTI FISSI")
        Me.cboSede.Location = New System.Drawing.Point(71, 236)
        Me.cboSede.Name = "cboSede"
        Me.HelpProvider1.SetShowHelp(Me.cboSede, True)
        Me.cboSede.Size = New System.Drawing.Size(132, 21)
        Me.cboSede.TabIndex = 24
        '
        'lblSedeOperativa
        '
        Me.lblSedeOperativa.AutoSize = True
        Me.lblSedeOperativa.BackColor = System.Drawing.Color.Transparent
        Me.lblSedeOperativa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSedeOperativa.Location = New System.Drawing.Point(15, 239)
        Me.lblSedeOperativa.Name = "lblSedeOperativa"
        Me.lblSedeOperativa.Size = New System.Drawing.Size(50, 13)
        Me.lblSedeOperativa.TabIndex = 23
        Me.lblSedeOperativa.Text = "Sede op."
        '
        'cboReparto
        '
        Me.cboReparto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboReparto.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboReparto, "Reparto dell'azienda in cui lavora l'utente. Esso è indicato soltanto nel caso di" & _
        " delega del settore IMPIANTI FISSI")
        Me.cboReparto.Location = New System.Drawing.Point(71, 204)
        Me.cboReparto.Name = "cboReparto"
        Me.HelpProvider1.SetShowHelp(Me.cboReparto, True)
        Me.cboReparto.Size = New System.Drawing.Size(133, 21)
        Me.cboReparto.TabIndex = 9
        '
        'lblReparto
        '
        Me.lblReparto.AutoSize = True
        Me.lblReparto.BackColor = System.Drawing.Color.Transparent
        Me.lblReparto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReparto.Location = New System.Drawing.Point(22, 208)
        Me.lblReparto.Name = "lblReparto"
        Me.lblReparto.Size = New System.Drawing.Size(45, 13)
        Me.lblReparto.TabIndex = 0
        Me.lblReparto.Text = "Reparto"
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
        Me.IdReferenteTextBox2.Location = New System.Drawing.Point(75, 67)
        Me.IdReferenteTextBox2.Mandatory = False
        Me.IdReferenteTextBox2.Margin = New System.Windows.Forms.Padding(0)
        Me.IdReferenteTextBox2.Name = "IdReferenteTextBox2"
        Me.HelpProvider1.SetShowHelp(Me.IdReferenteTextBox2, True)
        Me.IdReferenteTextBox2.Size = New System.Drawing.Size(89, 25)
        Me.IdReferenteTextBox2.TabIndex = 13
        Me.IdReferenteTextBox2.TextValue = ""
        '
        'lblDescrizioneResponsabile
        '
        Me.lblDescrizioneResponsabile.AutoSize = True
        Me.lblDescrizioneResponsabile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrizioneResponsabile.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDescrizioneResponsabile.Location = New System.Drawing.Point(179, 73)
        Me.lblDescrizioneResponsabile.Name = "lblDescrizioneResponsabile"
        Me.lblDescrizioneResponsabile.Size = New System.Drawing.Size(0, 13)
        Me.lblDescrizioneResponsabile.TabIndex = 12
        '
        'lblResponsabile
        '
        Me.lblResponsabile.AutoSize = True
        Me.lblResponsabile.BackColor = System.Drawing.Color.Transparent
        Me.lblResponsabile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblResponsabile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResponsabile.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblResponsabile.Location = New System.Drawing.Point(3, 73)
        Me.lblResponsabile.Name = "lblResponsabile"
        Me.lblResponsabile.Size = New System.Drawing.Size(71, 13)
        Me.lblResponsabile.TabIndex = 11
        Me.lblResponsabile.Text = "Responsabile"
        '
        'lblReferente
        '
        Me.lblReferente.AutoSize = True
        Me.lblReferente.BackColor = System.Drawing.Color.Transparent
        Me.lblReferente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblReferente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReferente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblReferente.Location = New System.Drawing.Point(35, 37)
        Me.lblReferente.Name = "lblReferente"
        Me.lblReferente.Size = New System.Drawing.Size(27, 13)
        Me.lblReferente.TabIndex = 0
        Me.lblReferente.Text = "Coll."
        '
        'cboCausaliSott
        '
        Me.cboCausaliSott.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCausaliSott.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCausaliSott.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboCausaliSott, "Causale di sottoscrizione della delega. Le causali possono essere impostate dal M" & _
        "enu Strumenti->Setup->Segreteria->Causali deleghe.")
        Me.cboCausaliSott.ItemHeight = 13
        Me.cboCausaliSott.Location = New System.Drawing.Point(71, 63)
        Me.cboCausaliSott.Name = "cboCausaliSott"
        Me.HelpProvider1.SetShowHelp(Me.cboCausaliSott, True)
        Me.cboCausaliSott.Size = New System.Drawing.Size(189, 21)
        Me.cboCausaliSott.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Caus. sott."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 271)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Note"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(17, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Data reg."
        '
        'txtNote
        '
        Me.txtNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtNote, "Eventuali note legate alla sottoscrizione della delega.")
        Me.txtNote.Location = New System.Drawing.Point(70, 271)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.HelpProvider1.SetShowHelp(Me.txtNote, True)
        Me.txtNote.Size = New System.Drawing.Size(348, 89)
        Me.txtNote.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(260, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Data doc."
        '
        'dtpData
        '
        Me.dtpData.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.HelpProvider1.SetHelpString(Me.dtpData, "Data di registrazione della delega. Si ricordi che la data di registrazione è la " & _
        "data in cui il funzionario registra la sottoscrizione della delega.")
        Me.dtpData.Location = New System.Drawing.Point(71, 32)
        Me.dtpData.Name = "dtpData"
        Me.HelpProvider1.SetShowHelp(Me.dtpData, True)
        Me.dtpData.Size = New System.Drawing.Size(101, 20)
        Me.dtpData.TabIndex = 1
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
        Me.IdUtenteTextBox1.Location = New System.Drawing.Point(70, 129)
        Me.IdUtenteTextBox1.Mandatory = False
        Me.IdUtenteTextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.IdUtenteTextBox1.Name = "IdUtenteTextBox1"
        Me.HelpProvider1.SetShowHelp(Me.IdUtenteTextBox1, True)
        Me.IdUtenteTextBox1.Size = New System.Drawing.Size(91, 25)
        Me.IdUtenteTextBox1.TabIndex = 3
        Me.IdUtenteTextBox1.TextValue = ""
        '
        'dtpDoc
        '
        Me.dtpDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDoc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.HelpProvider1.SetHelpString(Me.dtpDoc, "Data documento della delega.Si ricordi che la data documento è la data in cui il " & _
        "funzionario ha fatto sottoscrivere la delega.")
        Me.dtpDoc.Location = New System.Drawing.Point(317, 32)
        Me.dtpDoc.Name = "dtpDoc"
        Me.HelpProvider1.SetShowHelp(Me.dtpDoc, True)
        Me.dtpDoc.Size = New System.Drawing.Size(101, 20)
        Me.dtpDoc.TabIndex = 2
        '
        'lblUtente
        '
        Me.lblUtente.AutoSize = True
        Me.lblUtente.BackColor = System.Drawing.Color.Transparent
        Me.lblUtente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblUtente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUtente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblUtente.Location = New System.Drawing.Point(19, 134)
        Me.lblUtente.Name = "lblUtente"
        Me.lblUtente.Size = New System.Drawing.Size(49, 13)
        Me.lblUtente.TabIndex = 0
        Me.lblUtente.Text = "Id utente"
        '
        'lblDescrizioneUtente
        '
        Me.lblDescrizioneUtente.AutoSize = True
        Me.lblDescrizioneUtente.BackColor = System.Drawing.Color.Transparent
        Me.lblDescrizioneUtente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrizioneUtente.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDescrizioneUtente.Location = New System.Drawing.Point(171, 136)
        Me.lblDescrizioneUtente.Name = "lblDescrizioneUtente"
        Me.lblDescrizioneUtente.Size = New System.Drawing.Size(0, 13)
        Me.lblDescrizioneUtente.TabIndex = 0
        '
        'MainGroup
        '
        Me.MainGroup.Controls.Add(Me.cboSede)
        Me.MainGroup.Controls.Add(Me.Label6)
        Me.MainGroup.Controls.Add(Me.lblSedeOperativa)
        Me.MainGroup.Controls.Add(Me.cboCausaliSott)
        Me.MainGroup.Controls.Add(Me.cboReparto)
        Me.MainGroup.Controls.Add(Me.lblDescrizioneUtente)
        Me.MainGroup.Controls.Add(Me.lblReparto)
        Me.MainGroup.Controls.Add(Me.lblUtente)
        Me.MainGroup.Controls.Add(Me.lblSettore)
        Me.MainGroup.Controls.Add(Me.lblEnte)
        Me.MainGroup.Controls.Add(Me.Label4)
        Me.MainGroup.Controls.Add(Me.cboSettori)
        Me.MainGroup.Controls.Add(Me.dtpDoc)
        Me.MainGroup.Controls.Add(Me.cboEnti)
        Me.MainGroup.Controls.Add(Me.IdUtenteTextBox1)
        Me.MainGroup.Controls.Add(Me.lblAzienda)
        Me.MainGroup.Controls.Add(Me.Label3)
        Me.MainGroup.Controls.Add(Me.IdAziendaTextBox1)
        Me.MainGroup.Controls.Add(Me.dtpData)
        Me.MainGroup.Controls.Add(Me.lblDescrizioneAzienda)
        Me.MainGroup.Controls.Add(Me.Label1)
        Me.MainGroup.Controls.Add(Me.txtNote)
        Me.MainGroup.Location = New System.Drawing.Point(11, 81)
        Me.MainGroup.Name = "MainGroup"
        Me.MainGroup.Size = New System.Drawing.Size(451, 373)
        Me.MainGroup.TabIndex = 35
        Me.MainGroup.Title = "Dati delega"
        '
        'SpCmdInoltra
        '
        Me.SpCmdInoltra.ApplyOutLookStile = True
        Me.SpCmdInoltra.BackColor = System.Drawing.Color.Transparent
        Me.SpCmdInoltra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SpCmdInoltra.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.email_32x32
        Me.SpCmdInoltra.Disabled = False
        Me.SpCmdInoltra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SpCmdInoltra.ForeColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.SpCmdInoltra, resources.GetString("SpCmdInoltra.HelpString"))
        Me.SpCmdInoltra.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SpCmdInoltra.Location = New System.Drawing.Point(536, 8)
        Me.SpCmdInoltra.Name = "SpCmdInoltra"
        Me.SpCmdInoltra.Radius = 32.0!
        Me.HelpProvider1.SetShowHelp(Me.SpCmdInoltra, True)
        Me.SpCmdInoltra.ShowTooltip = True
        Me.SpCmdInoltra.Size = New System.Drawing.Size(32, 32)
        Me.SpCmdInoltra.TabIndex = 1
        Me.SpCmdInoltra.TextValue = ""
        Me.SpCmdInoltra.TooltipText = "Inoltra delega"
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
        Me.SpAnnulla.Location = New System.Drawing.Point(454, 8)
        Me.SpAnnulla.Name = "SpAnnulla"
        Me.SpAnnulla.Radius = 32.0!
        Me.HelpProvider1.SetShowHelp(Me.SpAnnulla, True)
        Me.SpAnnulla.ShowTooltip = True
        Me.SpAnnulla.Size = New System.Drawing.Size(32, 32)
        Me.SpAnnulla.TabIndex = 2
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
        Me.SpCmdRevoca.Location = New System.Drawing.Point(495, 9)
        Me.SpCmdRevoca.Name = "SpCmdRevoca"
        Me.SpCmdRevoca.Radius = 32.0!
        Me.HelpProvider1.SetShowHelp(Me.SpCmdRevoca, True)
        Me.SpCmdRevoca.ShowTooltip = True
        Me.SpCmdRevoca.Size = New System.Drawing.Size(32, 32)
        Me.SpCmdRevoca.TabIndex = 3
        Me.SpCmdRevoca.TextValue = ""
        Me.SpCmdRevoca.TooltipText = "Revoca delega"
        '
        'chkDuplica
        '
        Me.chkDuplica.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.chkDuplica, "Spuntare questa casella se si desidera duplicare una delega da inoltrare verso la" & _
        " Cassa Edile")
        Me.chkDuplica.Location = New System.Drawing.Point(11, 15)
        Me.chkDuplica.Name = "chkDuplica"
        Me.HelpProvider1.SetShowHelp(Me.chkDuplica, True)
        Me.chkDuplica.Size = New System.Drawing.Size(141, 17)
        Me.chkDuplica.TabIndex = 27
        Me.chkDuplica.Text = "Duplica delega Edilcassa"
        Me.chkDuplica.UseVisualStyleBackColor = True
        '
        'NiceGroupBox1
        '
        Me.NiceGroupBox1.Controls.Add(Me.IdReferenteTextBox2)
        Me.NiceGroupBox1.Controls.Add(Me.lblReferente)
        Me.NiceGroupBox1.Controls.Add(Me.lblDescrizioneResponsabile)
        Me.NiceGroupBox1.Controls.Add(Me.lblDescrizioneReferente)
        Me.NiceGroupBox1.Controls.Add(Me.IdReferenteTextBox1)
        Me.NiceGroupBox1.Controls.Add(Me.lblResponsabile)
        Me.NiceGroupBox1.Location = New System.Drawing.Point(11, 460)
        Me.NiceGroupBox1.Name = "NiceGroupBox1"
        Me.NiceGroupBox1.Size = New System.Drawing.Size(451, 110)
        Me.NiceGroupBox1.TabIndex = 36
        Me.NiceGroupBox1.Title = "Dati collaboratore comunale"
        '
        'ControlDelega
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.MainGroup)
        Me.Controls.Add(Me.NiceGroupBox1)
        Me.Name = "ControlDelega"
        Me.Size = New System.Drawing.Size(590, 588)
        Me.Controls.SetChildIndex(Me.NiceGroupBox1, 0)
        Me.Controls.SetChildIndex(Me.DockPanel, 0)
        Me.Controls.SetChildIndex(Me.MainGroup, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.DockPanel.ResumeLayout(False)
        Me.DockPanel.PerformLayout()
        Me.MainGroup.ResumeLayout(False)
        Me.MainGroup.PerformLayout()
        Me.NiceGroupBox1.ResumeLayout(False)
        Me.NiceGroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
   Friend WithEvents IdReferenteTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox
   Friend WithEvents lblId As System.Windows.Forms.Label
   Friend WithEvents txtIdDelega As System.Windows.Forms.TextBox
   Friend WithEvents IdAziendaTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdAziendaTextBox
   Friend WithEvents lblAzienda As System.Windows.Forms.Label
   Friend WithEvents lblDescrizioneAzienda As System.Windows.Forms.Label
   Friend WithEvents lblDescrizioneReferente As System.Windows.Forms.Label
   Friend WithEvents lblSettore As System.Windows.Forms.Label
   Friend WithEvents cboSettori As System.Windows.Forms.ComboBox
   Friend WithEvents lblEnte As System.Windows.Forms.Label
   Friend WithEvents cboEnti As System.Windows.Forms.ComboBox
   Friend WithEvents CustomBar1 As WIN.GUI.APPLICATION.PRESENTATION.CustomBar
   Friend WithEvents SpCmdInoltra As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents SpCmdRevoca As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents SpAnnulla As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents lblReferente As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents txtNote As System.Windows.Forms.TextBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents dtpData As System.Windows.Forms.DateTimePicker
   Friend WithEvents IdUtenteTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdUtenteTextBox
   Friend WithEvents dtpDoc As System.Windows.Forms.DateTimePicker
   Friend WithEvents lblUtente As System.Windows.Forms.Label
   Friend WithEvents lblDescrizioneUtente As System.Windows.Forms.Label
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents cboReparto As System.Windows.Forms.ComboBox
   Friend WithEvents lblReparto As System.Windows.Forms.Label
   Friend WithEvents cboCausaliSott As System.Windows.Forms.ComboBox
   Friend WithEvents IdReferenteTextBox2 As WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox
   Friend WithEvents lblDescrizioneResponsabile As System.Windows.Forms.Label
   Friend WithEvents lblResponsabile As System.Windows.Forms.Label
   Friend WithEvents cboSede As System.Windows.Forms.ComboBox
    Friend WithEvents lblSedeOperativa As System.Windows.Forms.Label
   Friend WithEvents MainGroup As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents chkDuplica As System.Windows.Forms.CheckBox
    Friend WithEvents NiceGroupBox1 As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider

End Class
