<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlItemContabile
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
      Me.lblimo = New System.Windows.Forms.Label
      Me.txtTipo = New System.Windows.Forms.TextBox
      Me.Label3 = New System.Windows.Forms.Label
      Me.lblDocPadre = New System.Windows.Forms.Label
      Me.txtDoc = New System.Windows.Forms.TextBox
      Me.Label5 = New System.Windows.Forms.Label
      Me.txtQuota = New System.Windows.Forms.TextBox
      Me.Label6 = New System.Windows.Forms.Label
      Me.Label7 = New System.Windows.Forms.Label
      Me.txtSettore = New System.Windows.Forms.TextBox
      Me.txtQuotaCongrua = New System.Windows.Forms.TextBox
      Me.Label8 = New System.Windows.Forms.Label
      Me.lblUtente = New System.Windows.Forms.Label
      Me.lblDescrizioneUtente = New System.Windows.Forms.Label
      Me.lblReferente = New System.Windows.Forms.Label
      Me.txtSogg = New System.Windows.Forms.TextBox
      Me.lblDescrizioneSogg = New System.Windows.Forms.Label
      Me.lblSoggEsec = New System.Windows.Forms.Label
      Me.chk14 = New System.Windows.Forms.CheckBox
      Me.chk13 = New System.Windows.Forms.CheckBox
      Me.txtContratto = New System.Windows.Forms.TextBox
      Me.lblContratto = New System.Windows.Forms.Label
      Me.lblDescrAzImpiego = New System.Windows.Forms.Label
      Me.lblAzImpiego = New System.Windows.Forms.Label
      Me.txtLav = New System.Windows.Forms.TextBox
      Me.Label10 = New System.Windows.Forms.Label
      Me.txtLiv = New System.Windows.Forms.TextBox
      Me.Label11 = New System.Windows.Forms.Label
      Me.txtMal = New System.Windows.Forms.TextBox
      Me.Label12 = New System.Windows.Forms.Label
      Me.Label13 = New System.Windows.Forms.Label
      Me.txtDataDoc = New System.Windows.Forms.TextBox
      Me.Label14 = New System.Windows.Forms.Label
      Me.txtdataReg = New System.Windows.Forms.TextBox
      Me.GrpDoc = New WIN.GUI.UTILITY.NiceGroupBox
      Me.txtNote = New System.Windows.Forms.TextBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.cmdCompetenza = New System.Windows.Forms.Button
      Me.txtImporto = New System.Windows.Forms.TextBox
      Me.Label2 = New System.Windows.Forms.Label
      Me.txtCompetenza = New System.Windows.Forms.TextBox
      Me.Label4 = New System.Windows.Forms.Label
      Me.GrpPosizione = New WIN.GUI.UTILITY.NiceGroupBox
      Me.IdAziendaTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdAziendaTextBox
      Me.cmdCongrua = New System.Windows.Forms.Button
      Me.IdUtenteTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdUtenteTextBox
      Me.GroupBox4 = New WIN.GUI.UTILITY.NiceGroupBox
      Me.IdReferenteTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox
      Me.lblDescrizioneReferente = New System.Windows.Forms.Label
      Me.txtPagRef = New System.Windows.Forms.TextBox
      Me.lblPagRef = New System.Windows.Forms.Label
      Me.txtImportoRist = New System.Windows.Forms.TextBox
      Me.lblImpRist = New System.Windows.Forms.Label
      Me.Label9 = New System.Windows.Forms.Label
      Me.GroupBox1 = New WIN.GUI.UTILITY.NiceGroupBox
      Me.txtIdPrest = New System.Windows.Forms.TextBox
      Me.Label15 = New System.Windows.Forms.Label
      Me.txtTipoPrest = New System.Windows.Forms.TextBox
      Me.Label17 = New System.Windows.Forms.Label
      Me.TabControl1 = New System.Windows.Forms.TabControl
      Me.TabPage1 = New System.Windows.Forms.TabPage
      Me.TabPage2 = New System.Windows.Forms.TabPage
      Me.TabPage3 = New System.Windows.Forms.TabPage
      Me.TabPage4 = New System.Windows.Forms.TabPage
      Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
      Me.GrpDoc.SuspendLayout()
      Me.GrpPosizione.SuspendLayout()
      Me.GroupBox4.SuspendLayout()
      Me.GroupBox1.SuspendLayout()
      Me.TabControl1.SuspendLayout()
      Me.TabPage1.SuspendLayout()
      Me.TabPage2.SuspendLayout()
      Me.TabPage3.SuspendLayout()
      Me.TabPage4.SuspendLayout()
      Me.SuspendLayout()
      '
      'Panel2
      '
      Me.Panel2.Size = New System.Drawing.Size(574, 22)
      '
      'DockPanel
      '
      Me.DockPanel.Location = New System.Drawing.Point(0, 23)
      Me.DockPanel.Size = New System.Drawing.Size(574, 44)
      Me.DockPanel.Visible = False
      '
      'lblimo
      '
      Me.lblimo.AutoSize = True
      Me.lblimo.BackColor = System.Drawing.Color.Transparent
      Me.lblimo.Location = New System.Drawing.Point(15, 173)
      Me.lblimo.Name = "lblimo"
      Me.lblimo.Size = New System.Drawing.Size(45, 13)
      Me.lblimo.TabIndex = 2
      Me.lblimo.Text = "Importo"
      '
      'txtTipo
      '
      Me.txtTipo.Enabled = False
      Me.txtTipo.Location = New System.Drawing.Point(250, 25)
      Me.txtTipo.Name = "txtTipo"
      Me.txtTipo.Size = New System.Drawing.Size(105, 21)
      Me.txtTipo.TabIndex = 3
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Location = New System.Drawing.Point(190, 26)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(51, 13)
      Me.Label3.TabIndex = 5
      Me.Label3.Text = "Tipo doc."
      '
      'lblDocPadre
      '
      Me.lblDocPadre.AutoSize = True
      Me.lblDocPadre.BackColor = System.Drawing.Color.Transparent
      Me.lblDocPadre.Location = New System.Drawing.Point(18, 30)
      Me.lblDocPadre.Name = "lblDocPadre"
      Me.lblDocPadre.Size = New System.Drawing.Size(41, 13)
      Me.lblDocPadre.TabIndex = 7
      Me.lblDocPadre.Text = "Id doc."
      '
      'txtDoc
      '
      Me.txtDoc.Enabled = False
      Me.txtDoc.Location = New System.Drawing.Point(62, 25)
      Me.txtDoc.Name = "txtDoc"
      Me.txtDoc.Size = New System.Drawing.Size(103, 21)
      Me.txtDoc.TabIndex = 0
      '
      'Label5
      '
      Me.Label5.AutoSize = True
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Location = New System.Drawing.Point(19, 180)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(50, 13)
      Me.Label5.TabIndex = 13
      Me.Label5.Text = "Q. media"
      '
      'txtQuota
      '
      Me.txtQuota.Enabled = False
      Me.txtQuota.Location = New System.Drawing.Point(81, 176)
      Me.txtQuota.Name = "txtQuota"
      Me.txtQuota.Size = New System.Drawing.Size(65, 21)
      Me.txtQuota.TabIndex = 6
      '
      'Label6
      '
      Me.Label6.AutoSize = True
      Me.Label6.BackColor = System.Drawing.Color.Transparent
      Me.Label6.Location = New System.Drawing.Point(149, 180)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(29, 13)
      Me.Label6.TabIndex = 15
      Me.Label6.Text = "Euro"
      '
      'Label7
      '
      Me.Label7.AutoSize = True
      Me.Label7.BackColor = System.Drawing.Color.Transparent
      Me.Label7.Location = New System.Drawing.Point(10, 112)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(43, 13)
      Me.Label7.TabIndex = 17
      Me.Label7.Text = "Settore"
      '
      'txtSettore
      '
      Me.txtSettore.Enabled = False
      Me.txtSettore.Location = New System.Drawing.Point(62, 109)
      Me.txtSettore.Name = "txtSettore"
      Me.txtSettore.Size = New System.Drawing.Size(207, 21)
      Me.txtSettore.TabIndex = 5
      '
      'txtQuotaCongrua
      '
      Me.txtQuotaCongrua.Enabled = False
      Me.txtQuotaCongrua.Location = New System.Drawing.Point(80, 203)
      Me.txtQuotaCongrua.Name = "txtQuotaCongrua"
      Me.txtQuotaCongrua.Size = New System.Drawing.Size(108, 21)
      Me.txtQuotaCongrua.TabIndex = 7
      '
      'Label8
      '
      Me.Label8.AutoSize = True
      Me.Label8.BackColor = System.Drawing.Color.Transparent
      Me.Label8.Location = New System.Drawing.Point(14, 207)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(61, 13)
      Me.Label8.TabIndex = 19
      Me.Label8.Text = "Q. congrua"
      '
      'lblUtente
      '
      Me.lblUtente.AutoSize = True
      Me.lblUtente.BackColor = System.Drawing.Color.Transparent
      Me.lblUtente.Location = New System.Drawing.Point(7, 37)
      Me.lblUtente.Name = "lblUtente"
      Me.lblUtente.Size = New System.Drawing.Size(52, 13)
      Me.lblUtente.TabIndex = 21
      Me.lblUtente.Text = "Id utente"
      '
      'lblDescrizioneUtente
      '
      Me.lblDescrizioneUtente.AutoSize = True
      Me.lblDescrizioneUtente.BackColor = System.Drawing.Color.Transparent
      Me.lblDescrizioneUtente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblDescrizioneUtente.Location = New System.Drawing.Point(190, 35)
      Me.lblDescrizioneUtente.Name = "lblDescrizioneUtente"
      Me.lblDescrizioneUtente.Size = New System.Drawing.Size(0, 13)
      Me.lblDescrizioneUtente.TabIndex = 22
      '
      'lblReferente
      '
      Me.lblReferente.AutoSize = True
      Me.lblReferente.BackColor = System.Drawing.Color.Transparent
      Me.lblReferente.Location = New System.Drawing.Point(29, 45)
      Me.lblReferente.Name = "lblReferente"
      Me.lblReferente.Size = New System.Drawing.Size(39, 13)
      Me.lblReferente.TabIndex = 24
      Me.lblReferente.Text = "Id coll."
      '
      'txtSogg
      '
      Me.txtSogg.AcceptsTab = True
      Me.txtSogg.Enabled = False
      Me.txtSogg.Location = New System.Drawing.Point(62, 82)
      Me.txtSogg.Name = "txtSogg"
      Me.txtSogg.Size = New System.Drawing.Size(103, 21)
      Me.txtSogg.TabIndex = 2
      '
      'lblDescrizioneSogg
      '
      Me.lblDescrizioneSogg.AutoSize = True
      Me.lblDescrizioneSogg.BackColor = System.Drawing.Color.Transparent
      Me.lblDescrizioneSogg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblDescrizioneSogg.Location = New System.Drawing.Point(194, 86)
      Me.lblDescrizioneSogg.Name = "lblDescrizioneSogg"
      Me.lblDescrizioneSogg.Size = New System.Drawing.Size(0, 13)
      Me.lblDescrizioneSogg.TabIndex = 28
      '
      'lblSoggEsec
      '
      Me.lblSoggEsec.AutoSize = True
      Me.lblSoggEsec.BackColor = System.Drawing.Color.Transparent
      Me.lblSoggEsec.Location = New System.Drawing.Point(17, 87)
      Me.lblSoggEsec.Name = "lblSoggEsec"
      Me.lblSoggEsec.Size = New System.Drawing.Size(42, 13)
      Me.lblSoggEsec.TabIndex = 27
      Me.lblSoggEsec.Text = "Id Ente"
      '
      'chk14
      '
      Me.chk14.AutoSize = True
      Me.chk14.BackColor = System.Drawing.Color.Transparent
      Me.HelpProvider1.SetHelpString(Me.chk14, "Spuntare questa casella se nella quota da incassare è inclusa la tredicesima")
      Me.chk14.Location = New System.Drawing.Point(308, 169)
      Me.chk14.Name = "chk14"
      Me.HelpProvider1.SetShowHelp(Me.chk14, True)
      Me.chk14.Size = New System.Drawing.Size(139, 17)
      Me.chk14.TabIndex = 8
      Me.chk14.Text = "Quattordicesima inclusa"
      Me.chk14.UseVisualStyleBackColor = False
      '
      'chk13
      '
      Me.chk13.AutoSize = True
      Me.chk13.BackColor = System.Drawing.Color.Transparent
      Me.HelpProvider1.SetHelpString(Me.chk13, "Spuntare questa casella se nella quota da incassare è inclusa la tredicesima")
      Me.chk13.Location = New System.Drawing.Point(308, 146)
      Me.chk13.Name = "chk13"
      Me.HelpProvider1.SetShowHelp(Me.chk13, True)
      Me.chk13.Size = New System.Drawing.Size(117, 17)
      Me.chk13.TabIndex = 7
      Me.chk13.Text = "Tredicesima inclusa"
      Me.chk13.UseVisualStyleBackColor = False
      '
      'txtContratto
      '
      Me.txtContratto.AcceptsTab = True
      Me.txtContratto.AccessibleDescription = ""
      Me.txtContratto.Enabled = False
      Me.txtContratto.Location = New System.Drawing.Point(81, 121)
      Me.txtContratto.Name = "txtContratto"
      Me.txtContratto.Size = New System.Drawing.Size(133, 21)
      Me.txtContratto.TabIndex = 2
      '
      'lblContratto
      '
      Me.lblContratto.AutoSize = True
      Me.lblContratto.BackColor = System.Drawing.Color.Transparent
      Me.lblContratto.Location = New System.Drawing.Point(10, 129)
      Me.lblContratto.Name = "lblContratto"
      Me.lblContratto.Size = New System.Drawing.Size(63, 13)
      Me.lblContratto.TabIndex = 40
      Me.lblContratto.Text = "Contr. app."
      '
      'lblDescrAzImpiego
      '
      Me.lblDescrAzImpiego.AutoSize = True
      Me.lblDescrAzImpiego.BackColor = System.Drawing.Color.Transparent
      Me.lblDescrAzImpiego.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblDescrAzImpiego.Location = New System.Drawing.Point(191, 74)
      Me.lblDescrAzImpiego.Name = "lblDescrAzImpiego"
      Me.lblDescrAzImpiego.Size = New System.Drawing.Size(0, 13)
      Me.lblDescrAzImpiego.TabIndex = 39
      '
      'lblAzImpiego
      '
      Me.lblAzImpiego.AutoSize = True
      Me.lblAzImpiego.BackColor = System.Drawing.Color.Transparent
      Me.lblAzImpiego.Location = New System.Drawing.Point(13, 75)
      Me.lblAzImpiego.Name = "lblAzImpiego"
      Me.lblAzImpiego.Size = New System.Drawing.Size(48, 13)
      Me.lblAzImpiego.TabIndex = 37
      Me.lblAzImpiego.Text = "Az. Imp."
      '
      'txtLav
      '
      Me.HelpProvider1.SetHelpString(Me.txtLav, "Ore lavorate dall'utente")
      Me.txtLav.Location = New System.Drawing.Point(80, 149)
      Me.txtLav.Name = "txtLav"
      Me.HelpProvider1.SetShowHelp(Me.txtLav, True)
      Me.txtLav.Size = New System.Drawing.Size(67, 21)
      Me.txtLav.TabIndex = 4
      '
      'Label10
      '
      Me.Label10.AutoSize = True
      Me.Label10.BackColor = System.Drawing.Color.Transparent
      Me.Label10.Location = New System.Drawing.Point(4, 152)
      Me.Label10.Name = "Label10"
      Me.Label10.Size = New System.Drawing.Size(68, 13)
      Me.Label10.TabIndex = 46
      Me.Label10.Text = "Ore lavorate"
      '
      'txtLiv
      '
      Me.HelpProvider1.SetHelpString(Me.txtLiv, "Livello di inquadramento dell'utente")
      Me.txtLiv.Location = New System.Drawing.Point(320, 121)
      Me.txtLiv.Name = "txtLiv"
      Me.HelpProvider1.SetShowHelp(Me.txtLiv, True)
      Me.txtLiv.Size = New System.Drawing.Size(133, 21)
      Me.txtLiv.TabIndex = 3
      '
      'Label11
      '
      Me.Label11.AutoSize = True
      Me.Label11.BackColor = System.Drawing.Color.Transparent
      Me.Label11.Location = New System.Drawing.Point(272, 124)
      Me.Label11.Name = "Label11"
      Me.Label11.Size = New System.Drawing.Size(45, 13)
      Me.Label11.TabIndex = 44
      Me.Label11.Text = "Liv. inq."
      '
      'txtMal
      '
      Me.HelpProvider1.SetHelpString(Me.txtMal, "Ore di malattie o infortuni dell'utente")
      Me.txtMal.Location = New System.Drawing.Point(321, 149)
      Me.txtMal.Name = "txtMal"
      Me.HelpProvider1.SetShowHelp(Me.txtMal, True)
      Me.txtMal.Size = New System.Drawing.Size(67, 21)
      Me.txtMal.TabIndex = 5
      '
      'Label12
      '
      Me.Label12.AutoSize = True
      Me.Label12.BackColor = System.Drawing.Color.Transparent
      Me.Label12.Location = New System.Drawing.Point(249, 154)
      Me.Label12.Name = "Label12"
      Me.Label12.Size = New System.Drawing.Size(68, 13)
      Me.Label12.TabIndex = 42
      Me.Label12.Text = "Ore mal./inf."
      '
      'Label13
      '
      Me.Label13.AutoSize = True
      Me.Label13.BackColor = System.Drawing.Color.Transparent
      Me.Label13.Location = New System.Drawing.Point(6, 59)
      Me.Label13.Name = "Label13"
      Me.Label13.Size = New System.Drawing.Size(53, 13)
      Me.Label13.TabIndex = 50
      Me.Label13.Text = "Data reg."
      '
      'txtDataDoc
      '
      Me.txtDataDoc.Enabled = False
      Me.txtDataDoc.Location = New System.Drawing.Point(250, 52)
      Me.txtDataDoc.Name = "txtDataDoc"
      Me.txtDataDoc.Size = New System.Drawing.Size(105, 21)
      Me.txtDataDoc.TabIndex = 4
      '
      'Label14
      '
      Me.Label14.AutoSize = True
      Me.Label14.BackColor = System.Drawing.Color.Transparent
      Me.Label14.Location = New System.Drawing.Point(190, 56)
      Me.Label14.Name = "Label14"
      Me.Label14.Size = New System.Drawing.Size(54, 13)
      Me.Label14.TabIndex = 48
      Me.Label14.Text = "Data doc."
      '
      'txtdataReg
      '
      Me.txtdataReg.Enabled = False
      Me.txtdataReg.Location = New System.Drawing.Point(62, 52)
      Me.txtdataReg.Name = "txtdataReg"
      Me.txtdataReg.Size = New System.Drawing.Size(103, 21)
      Me.txtdataReg.TabIndex = 1
      '
      'GrpDoc
      '
      Me.GrpDoc.BackColor = System.Drawing.Color.Transparent
      Me.GrpDoc.Controls.Add(Me.txtDoc)
      Me.GrpDoc.Controls.Add(Me.txtNote)
      Me.GrpDoc.Controls.Add(Me.Label1)
      Me.GrpDoc.Controls.Add(Me.cmdCompetenza)
      Me.GrpDoc.Controls.Add(Me.lblDocPadre)
      Me.GrpDoc.Controls.Add(Me.txtImporto)
      Me.GrpDoc.Controls.Add(Me.chk14)
      Me.GrpDoc.Controls.Add(Me.Label2)
      Me.GrpDoc.Controls.Add(Me.chk13)
      Me.GrpDoc.Controls.Add(Me.txtdataReg)
      Me.GrpDoc.Controls.Add(Me.lblimo)
      Me.GrpDoc.Controls.Add(Me.Label13)
      Me.GrpDoc.Controls.Add(Me.txtDataDoc)
      Me.GrpDoc.Controls.Add(Me.Label14)
      Me.GrpDoc.Controls.Add(Me.txtTipo)
      Me.GrpDoc.Controls.Add(Me.Label3)
      Me.GrpDoc.Controls.Add(Me.txtSettore)
      Me.GrpDoc.Controls.Add(Me.Label7)
      Me.GrpDoc.Controls.Add(Me.txtSogg)
      Me.GrpDoc.Controls.Add(Me.txtCompetenza)
      Me.GrpDoc.Controls.Add(Me.Label4)
      Me.GrpDoc.Controls.Add(Me.lblSoggEsec)
      Me.GrpDoc.Controls.Add(Me.lblDescrizioneSogg)
      Me.GrpDoc.Dock = System.Windows.Forms.DockStyle.Fill
      Me.GrpDoc.ForeColor = System.Drawing.Color.Black
      Me.GrpDoc.Location = New System.Drawing.Point(3, 3)
      Me.GrpDoc.Name = "GrpDoc"
      Me.GrpDoc.Size = New System.Drawing.Size(529, 248)
      Me.GrpDoc.TabIndex = 0
      Me.GrpDoc.Text = "Documento"
      Me.GrpDoc.Title = "Dati documento"
      '
      'txtNote
      '
      Me.txtNote.Location = New System.Drawing.Point(62, 200)
      Me.txtNote.Multiline = True
      Me.txtNote.Name = "txtNote"
      Me.txtNote.Size = New System.Drawing.Size(449, 40)
      Me.txtNote.TabIndex = 9
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Location = New System.Drawing.Point(9, 200)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(54, 13)
      Me.Label1.TabIndex = 32
      Me.Label1.Text = "Note pos."
      '
      'cmdCompetenza
      '
      Me.HelpProvider1.SetHelpString(Me.cmdCompetenza, "Funzione che permette di selezionare il periodo di competenza della quota da inca" & _
              "ssare")
      Me.cmdCompetenza.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.Aggiorna
      Me.cmdCompetenza.Location = New System.Drawing.Point(198, 137)
      Me.cmdCompetenza.Name = "cmdCompetenza"
      Me.HelpProvider1.SetShowHelp(Me.cmdCompetenza, True)
      Me.cmdCompetenza.Size = New System.Drawing.Size(32, 23)
      Me.cmdCompetenza.TabIndex = 62
      Me.cmdCompetenza.UseVisualStyleBackColor = True
      '
      'txtImporto
      '
      Me.HelpProvider1.SetHelpString(Me.txtImporto, "Importo della quota da incassare")
      Me.txtImporto.Location = New System.Drawing.Point(62, 169)
      Me.txtImporto.Name = "txtImporto"
      Me.HelpProvider1.SetShowHelp(Me.txtImporto, True)
      Me.txtImporto.Size = New System.Drawing.Size(133, 21)
      Me.txtImporto.TabIndex = 6
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Location = New System.Drawing.Point(201, 173)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(29, 13)
      Me.Label2.TabIndex = 4
      Me.Label2.Text = "Euro"
      '
      'txtCompetenza
      '
      Me.txtCompetenza.Enabled = False
      Me.txtCompetenza.Location = New System.Drawing.Point(62, 139)
      Me.txtCompetenza.Name = "txtCompetenza"
      Me.txtCompetenza.Size = New System.Drawing.Size(133, 21)
      Me.txtCompetenza.TabIndex = 5
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Location = New System.Drawing.Point(18, 146)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(38, 13)
      Me.Label4.TabIndex = 11
      Me.Label4.Text = "Comp."
      '
      'GrpPosizione
      '
      Me.GrpPosizione.BackColor = System.Drawing.Color.Transparent
      Me.GrpPosizione.Controls.Add(Me.IdAziendaTextBox1)
      Me.GrpPosizione.Controls.Add(Me.lblAzImpiego)
      Me.GrpPosizione.Controls.Add(Me.cmdCongrua)
      Me.GrpPosizione.Controls.Add(Me.lblDescrAzImpiego)
      Me.GrpPosizione.Controls.Add(Me.IdUtenteTextBox1)
      Me.GrpPosizione.Controls.Add(Me.txtQuota)
      Me.GrpPosizione.Controls.Add(Me.txtLav)
      Me.GrpPosizione.Controls.Add(Me.lblUtente)
      Me.GrpPosizione.Controls.Add(Me.Label10)
      Me.GrpPosizione.Controls.Add(Me.Label5)
      Me.GrpPosizione.Controls.Add(Me.txtMal)
      Me.GrpPosizione.Controls.Add(Me.Label12)
      Me.GrpPosizione.Controls.Add(Me.lblDescrizioneUtente)
      Me.GrpPosizione.Controls.Add(Me.txtLiv)
      Me.GrpPosizione.Controls.Add(Me.Label6)
      Me.GrpPosizione.Controls.Add(Me.Label11)
      Me.GrpPosizione.Controls.Add(Me.txtQuotaCongrua)
      Me.GrpPosizione.Controls.Add(Me.txtContratto)
      Me.GrpPosizione.Controls.Add(Me.Label8)
      Me.GrpPosizione.Controls.Add(Me.lblContratto)
      Me.GrpPosizione.Dock = System.Windows.Forms.DockStyle.Fill
      Me.GrpPosizione.ForeColor = System.Drawing.Color.Black
      Me.GrpPosizione.Location = New System.Drawing.Point(3, 3)
      Me.GrpPosizione.Name = "GrpPosizione"
      Me.GrpPosizione.Size = New System.Drawing.Size(529, 248)
      Me.GrpPosizione.TabIndex = 1
      Me.GrpPosizione.Text = "Posizione documento"
      Me.GrpPosizione.Title = "Utente"
      '
      'IdAziendaTextBox1
      '
      Me.IdAziendaTextBox1.BackColor = System.Drawing.Color.Transparent
      Me.IdAziendaTextBox1.DescriptionOfText = ""
      Me.IdAziendaTextBox1.DescriptionTextWidth = 150
      Me.IdAziendaTextBox1.DescriptionTextXValue = 92
      Me.IdAziendaTextBox1.EnableSerchTextBox = True
      Me.IdAziendaTextBox1.IsDescriptionVisible = False
      Me.IdAziendaTextBox1.Location = New System.Drawing.Point(79, 66)
      Me.IdAziendaTextBox1.Mandatory = False
      Me.IdAziendaTextBox1.Margin = New System.Windows.Forms.Padding(0)
      Me.IdAziendaTextBox1.Name = "IdAziendaTextBox1"
      Me.IdAziendaTextBox1.Size = New System.Drawing.Size(99, 24)
      Me.IdAziendaTextBox1.TabIndex = 1
      Me.IdAziendaTextBox1.TextValue = ""
      '
      'cmdCongrua
      '
      Me.cmdCongrua.FlatAppearance.BorderSize = 0
      Me.cmdCongrua.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.cmdCongrua.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.OK
      Me.cmdCongrua.Location = New System.Drawing.Point(195, 202)
      Me.cmdCongrua.Name = "cmdCongrua"
      Me.cmdCongrua.Size = New System.Drawing.Size(24, 20)
      Me.cmdCongrua.TabIndex = 21
      Me.cmdCongrua.UseVisualStyleBackColor = True
      '
      'IdUtenteTextBox1
      '
      Me.IdUtenteTextBox1.BackColor = System.Drawing.Color.Transparent
      Me.IdUtenteTextBox1.DescriptionOfText = ""
      Me.IdUtenteTextBox1.DescriptionTextWidth = 150
      Me.IdUtenteTextBox1.DescriptionTextXValue = 92
      Me.IdUtenteTextBox1.EnableSerchTextBox = True
      Me.HelpProvider1.SetHelpString(Me.IdUtenteTextBox1, "Identificativo dell'utente")
      Me.IdUtenteTextBox1.IsDescriptionVisible = False
      Me.IdUtenteTextBox1.Location = New System.Drawing.Point(80, 29)
      Me.IdUtenteTextBox1.Mandatory = False
      Me.IdUtenteTextBox1.Margin = New System.Windows.Forms.Padding(0)
      Me.IdUtenteTextBox1.Name = "IdUtenteTextBox1"
      Me.HelpProvider1.SetShowHelp(Me.IdUtenteTextBox1, True)
      Me.IdUtenteTextBox1.Size = New System.Drawing.Size(104, 26)
      Me.IdUtenteTextBox1.TabIndex = 0
      Me.IdUtenteTextBox1.TextValue = ""
      '
      'GroupBox4
      '
      Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
      Me.GroupBox4.Controls.Add(Me.IdReferenteTextBox1)
      Me.GroupBox4.Controls.Add(Me.lblDescrizioneReferente)
      Me.GroupBox4.Controls.Add(Me.lblReferente)
      Me.GroupBox4.Controls.Add(Me.txtPagRef)
      Me.GroupBox4.Controls.Add(Me.lblPagRef)
      Me.GroupBox4.Controls.Add(Me.txtImportoRist)
      Me.GroupBox4.Controls.Add(Me.lblImpRist)
      Me.GroupBox4.Controls.Add(Me.Label9)
      Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
      Me.GroupBox4.ForeColor = System.Drawing.Color.Black
      Me.GroupBox4.Location = New System.Drawing.Point(3, 3)
      Me.GroupBox4.Name = "GroupBox4"
      Me.GroupBox4.Size = New System.Drawing.Size(529, 248)
      Me.GroupBox4.TabIndex = 2
      Me.GroupBox4.Text = "Pagamento referente"
      Me.GroupBox4.Title = "Collaboratore comunale"
      '
      'IdReferenteTextBox1
      '
      Me.IdReferenteTextBox1.BackColor = System.Drawing.Color.Transparent
      Me.IdReferenteTextBox1.DescriptionOfText = ""
      Me.IdReferenteTextBox1.DescriptionTextWidth = 150
      Me.IdReferenteTextBox1.DescriptionTextXValue = 92
      Me.IdReferenteTextBox1.EnableSerchTextBox = True
      Me.HelpProvider1.SetHelpString(Me.IdReferenteTextBox1, "Identificativo del collaboratore comunale che ha fatto sottoscrivere la delega a " & _
              "cui la quota incassata fa riferimento")
      Me.IdReferenteTextBox1.IsDescriptionVisible = False
      Me.IdReferenteTextBox1.Location = New System.Drawing.Point(86, 38)
      Me.IdReferenteTextBox1.Mandatory = False
      Me.IdReferenteTextBox1.Margin = New System.Windows.Forms.Padding(0)
      Me.IdReferenteTextBox1.Name = "IdReferenteTextBox1"
      Me.HelpProvider1.SetShowHelp(Me.IdReferenteTextBox1, True)
      Me.IdReferenteTextBox1.Size = New System.Drawing.Size(102, 26)
      Me.IdReferenteTextBox1.TabIndex = 0
      Me.IdReferenteTextBox1.TextValue = ""
      '
      'lblDescrizioneReferente
      '
      Me.lblDescrizioneReferente.AutoSize = True
      Me.lblDescrizioneReferente.BackColor = System.Drawing.Color.Transparent
      Me.lblDescrizioneReferente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblDescrizioneReferente.Location = New System.Drawing.Point(216, 48)
      Me.lblDescrizioneReferente.Name = "lblDescrizioneReferente"
      Me.lblDescrizioneReferente.Size = New System.Drawing.Size(0, 13)
      Me.lblDescrizioneReferente.TabIndex = 25
      '
      'txtPagRef
      '
      Me.txtPagRef.Enabled = False
      Me.txtPagRef.Location = New System.Drawing.Point(88, 72)
      Me.txtPagRef.Name = "txtPagRef"
      Me.txtPagRef.Size = New System.Drawing.Size(71, 21)
      Me.txtPagRef.TabIndex = 1
      '
      'lblPagRef
      '
      Me.lblPagRef.AutoSize = True
      Me.lblPagRef.BackColor = System.Drawing.Color.Transparent
      Me.lblPagRef.Location = New System.Drawing.Point(24, 76)
      Me.lblPagRef.Name = "lblPagRef"
      Me.lblPagRef.Size = New System.Drawing.Size(51, 13)
      Me.lblPagRef.TabIndex = 32
      Me.lblPagRef.Text = "Pag. coll."
      '
      'txtImportoRist
      '
      Me.txtImportoRist.Enabled = False
      Me.txtImportoRist.Location = New System.Drawing.Point(88, 99)
      Me.txtImportoRist.Name = "txtImportoRist"
      Me.txtImportoRist.Size = New System.Drawing.Size(128, 21)
      Me.txtImportoRist.TabIndex = 2
      '
      'lblImpRist
      '
      Me.lblImpRist.AutoSize = True
      Me.lblImpRist.BackColor = System.Drawing.Color.Transparent
      Me.lblImpRist.Location = New System.Drawing.Point(6, 104)
      Me.lblImpRist.Name = "lblImpRist"
      Me.lblImpRist.Size = New System.Drawing.Size(69, 13)
      Me.lblImpRist.TabIndex = 34
      Me.lblImpRist.Text = "Imp. ristorno"
      '
      'Label9
      '
      Me.Label9.AutoSize = True
      Me.Label9.BackColor = System.Drawing.Color.Transparent
      Me.Label9.Location = New System.Drawing.Point(227, 107)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(29, 13)
      Me.Label9.TabIndex = 36
      Me.Label9.Text = "Euro"
      '
      'GroupBox1
      '
      Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
      Me.GroupBox1.Controls.Add(Me.txtIdPrest)
      Me.GroupBox1.Controls.Add(Me.Label15)
      Me.GroupBox1.Controls.Add(Me.txtTipoPrest)
      Me.GroupBox1.Controls.Add(Me.Label17)
      Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.GroupBox1.ForeColor = System.Drawing.Color.Black
      Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
      Me.GroupBox1.Name = "GroupBox1"
      Me.GroupBox1.Size = New System.Drawing.Size(529, 248)
      Me.GroupBox1.TabIndex = 3
      Me.GroupBox1.Text = "Prestazioni"
      Me.GroupBox1.Title = "Prestazioni"
      '
      'txtIdPrest
      '
      Me.txtIdPrest.Enabled = False
      Me.HelpProvider1.SetHelpString(Me.txtIdPrest, "Identificativo della prestazione per cui si sta incassando quella quota")
      Me.txtIdPrest.Location = New System.Drawing.Point(77, 32)
      Me.txtIdPrest.Name = "txtIdPrest"
      Me.HelpProvider1.SetShowHelp(Me.txtIdPrest, True)
      Me.txtIdPrest.Size = New System.Drawing.Size(90, 21)
      Me.txtIdPrest.TabIndex = 0
      '
      'Label15
      '
      Me.Label15.AutoSize = True
      Me.Label15.BackColor = System.Drawing.Color.Transparent
      Me.Label15.Location = New System.Drawing.Point(16, 35)
      Me.Label15.Name = "Label15"
      Me.Label15.Size = New System.Drawing.Size(52, 13)
      Me.Label15.TabIndex = 13
      Me.Label15.Text = "Id  prest."
      '
      'txtTipoPrest
      '
      Me.txtTipoPrest.Enabled = False
      Me.HelpProvider1.SetHelpString(Me.txtTipoPrest, "Tipo di prestazione ")
      Me.txtTipoPrest.Location = New System.Drawing.Point(77, 59)
      Me.txtTipoPrest.Name = "txtTipoPrest"
      Me.HelpProvider1.SetShowHelp(Me.txtTipoPrest, True)
      Me.txtTipoPrest.Size = New System.Drawing.Size(204, 21)
      Me.txtTipoPrest.TabIndex = 1
      '
      'Label17
      '
      Me.Label17.AutoSize = True
      Me.Label17.BackColor = System.Drawing.Color.Transparent
      Me.Label17.Location = New System.Drawing.Point(9, 63)
      Me.Label17.Name = "Label17"
      Me.Label17.Size = New System.Drawing.Size(59, 13)
      Me.Label17.TabIndex = 19
      Me.Label17.Text = "Tipo prest."
      '
      'TabControl1
      '
      Me.TabControl1.Controls.Add(Me.TabPage1)
      Me.TabControl1.Controls.Add(Me.TabPage2)
      Me.TabControl1.Controls.Add(Me.TabPage3)
      Me.TabControl1.Controls.Add(Me.TabPage4)
      Me.TabControl1.Location = New System.Drawing.Point(11, 33)
      Me.TabControl1.Name = "TabControl1"
      Me.TabControl1.SelectedIndex = 0
      Me.TabControl1.Size = New System.Drawing.Size(543, 280)
      Me.TabControl1.TabIndex = 35
      '
      'TabPage1
      '
      Me.TabPage1.Controls.Add(Me.GrpDoc)
      Me.TabPage1.Location = New System.Drawing.Point(4, 22)
      Me.TabPage1.Name = "TabPage1"
      Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
      Me.TabPage1.Size = New System.Drawing.Size(535, 254)
      Me.TabPage1.TabIndex = 0
      Me.TabPage1.Text = "Dati documento"
      Me.TabPage1.UseVisualStyleBackColor = True
      '
      'TabPage2
      '
      Me.TabPage2.Controls.Add(Me.GrpPosizione)
      Me.TabPage2.Location = New System.Drawing.Point(4, 22)
      Me.TabPage2.Name = "TabPage2"
      Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
      Me.TabPage2.Size = New System.Drawing.Size(535, 254)
      Me.TabPage2.TabIndex = 1
      Me.TabPage2.Text = "Dati utente"
      Me.TabPage2.UseVisualStyleBackColor = True
      '
      'TabPage3
      '
      Me.TabPage3.Controls.Add(Me.GroupBox4)
      Me.TabPage3.Location = New System.Drawing.Point(4, 22)
      Me.TabPage3.Name = "TabPage3"
      Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
      Me.TabPage3.Size = New System.Drawing.Size(535, 254)
      Me.TabPage3.TabIndex = 2
      Me.TabPage3.Text = "Dati collaboratore comunale"
      Me.TabPage3.UseVisualStyleBackColor = True
      '
      'TabPage4
      '
      Me.TabPage4.Controls.Add(Me.GroupBox1)
      Me.TabPage4.Location = New System.Drawing.Point(4, 22)
      Me.TabPage4.Name = "TabPage4"
      Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
      Me.TabPage4.Size = New System.Drawing.Size(535, 254)
      Me.TabPage4.TabIndex = 3
      Me.TabPage4.Text = "Prestazioni"
      Me.TabPage4.UseVisualStyleBackColor = True
      '
      'ControlItemContabile
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.Controls.Add(Me.TabControl1)
      Me.Name = "ControlItemContabile"
      Me.Size = New System.Drawing.Size(574, 330)
      Me.Controls.SetChildIndex(Me.DockPanel, 0)
      Me.Controls.SetChildIndex(Me.Panel2, 0)
      Me.Controls.SetChildIndex(Me.TabControl1, 0)
      Me.GrpDoc.ResumeLayout(False)
      Me.GrpDoc.PerformLayout()
      Me.GrpPosizione.ResumeLayout(False)
      Me.GrpPosizione.PerformLayout()
      Me.GroupBox4.ResumeLayout(False)
      Me.GroupBox4.PerformLayout()
      Me.GroupBox1.ResumeLayout(False)
      Me.GroupBox1.PerformLayout()
      Me.TabControl1.ResumeLayout(False)
      Me.TabPage1.ResumeLayout(False)
      Me.TabPage2.ResumeLayout(False)
      Me.TabPage3.ResumeLayout(False)
      Me.TabPage4.ResumeLayout(False)
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents lblimo As System.Windows.Forms.Label
   Friend WithEvents txtTipo As System.Windows.Forms.TextBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents lblDocPadre As System.Windows.Forms.Label
   Friend WithEvents txtDoc As System.Windows.Forms.TextBox
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents txtQuota As System.Windows.Forms.TextBox
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents txtQuotaCongrua As System.Windows.Forms.TextBox
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents lblUtente As System.Windows.Forms.Label
   Friend WithEvents lblDescrizioneUtente As System.Windows.Forms.Label
   Friend WithEvents lblReferente As System.Windows.Forms.Label
   Friend WithEvents txtSogg As System.Windows.Forms.TextBox
   Friend WithEvents lblDescrizioneSogg As System.Windows.Forms.Label
   Friend WithEvents lblSoggEsec As System.Windows.Forms.Label
   Friend WithEvents chk14 As System.Windows.Forms.CheckBox
   Friend WithEvents chk13 As System.Windows.Forms.CheckBox
   Friend WithEvents txtContratto As System.Windows.Forms.TextBox
   Friend WithEvents lblContratto As System.Windows.Forms.Label
   Friend WithEvents lblDescrAzImpiego As System.Windows.Forms.Label
   Friend WithEvents lblAzImpiego As System.Windows.Forms.Label
   Friend WithEvents Label10 As System.Windows.Forms.Label
   Friend WithEvents txtLiv As System.Windows.Forms.TextBox
   Friend WithEvents Label11 As System.Windows.Forms.Label
   Friend WithEvents Label12 As System.Windows.Forms.Label
   Friend WithEvents Label13 As System.Windows.Forms.Label
   Friend WithEvents txtDataDoc As System.Windows.Forms.TextBox
   Friend WithEvents Label14 As System.Windows.Forms.Label
   Friend WithEvents txtdataReg As System.Windows.Forms.TextBox
    Friend WithEvents GrpDoc As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents GrpPosizione As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents IdAziendaTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdAziendaTextBox
    Friend WithEvents GroupBox4 As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents IdReferenteTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox
    Friend WithEvents lblDescrizioneReferente As System.Windows.Forms.Label
    Friend WithEvents txtPagRef As System.Windows.Forms.TextBox
    Friend WithEvents lblPagRef As System.Windows.Forms.Label
    Friend WithEvents txtImportoRist As System.Windows.Forms.TextBox
    Friend WithEvents lblImpRist As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtImporto As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCompetenza As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdCompetenza As System.Windows.Forms.Button
    Friend WithEvents cmdCongrua As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents Label15 As System.Windows.Forms.Label
   Friend WithEvents Label17 As System.Windows.Forms.Label
   Public WithEvents txtSettore As System.Windows.Forms.TextBox
   Public WithEvents txtLav As System.Windows.Forms.TextBox
   Public WithEvents txtMal As System.Windows.Forms.TextBox
   Public WithEvents IdUtenteTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdUtenteTextBox
   Public WithEvents txtIdPrest As System.Windows.Forms.TextBox
   Public WithEvents txtTipoPrest As System.Windows.Forms.TextBox
   Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
   Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
   Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
   Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider

End Class
