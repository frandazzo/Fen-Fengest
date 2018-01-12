<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlDocumentView
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlDocumentView))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblId = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.txtVert = New System.Windows.Forms.TextBox()
        Me.lblVert = New System.Windows.Forms.Label()
        Me.txtReferente = New System.Windows.Forms.TextBox()
        Me.lblRef = New System.Windows.Forms.Label()
        Me.lblSettore = New System.Windows.Forms.Label()
        Me.txtSettore = New System.Windows.Forms.TextBox()
        Me.cmdCompetenza = New System.Windows.Forms.Button()
        Me.txtCompetenza = New System.Windows.Forms.TextBox()
        Me.lblCompetenza = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtImporto = New System.Windows.Forms.TextBox()
        Me.lblValuta = New System.Windows.Forms.Label()
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpDoc = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpRegistrazione = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GridPosizioni = New System.Windows.Forms.DataGridView()
        Me.CustomBar1 = New WIN.GUI.APPLICATION.PRESENTATION.CustomBar()
        Me.GrpSogg = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.lblContratto = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblDescrizioneAzienda = New System.Windows.Forms.Label()
        Me.lblCompUltimo = New System.Windows.Forms.Label()
        Me.grpUt = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblDescrUt = New System.Windows.Forms.Label()
        Me.GrpRef = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblReferente = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmdAdd = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.cmdDel = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.CmdDown = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.cmdUp = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.cmdCerca = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.SpecialButton1 = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.DockPanel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.GridPosizioni, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpSogg.SuspendLayout()
        Me.grpUt.SuspendLayout()
        Me.GrpRef.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Size = New System.Drawing.Size(700, 26)
        '
        'DockPanel
        '
        Me.DockPanel.Controls.Add(Me.SpecialButton1)
        Me.DockPanel.Controls.Add(Me.CustomBar1)
        Me.DockPanel.Controls.Add(Me.cmdCerca)
        Me.DockPanel.Controls.Add(Me.lblId)
        Me.DockPanel.Controls.Add(Me.txtId)
        Me.DockPanel.Location = New System.Drawing.Point(0, 26)
        Me.DockPanel.Size = New System.Drawing.Size(700, 44)
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.BackColor = System.Drawing.Color.Transparent
        Me.lblId.ForeColor = System.Drawing.Color.Black
        Me.lblId.Location = New System.Drawing.Point(7, 18)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(17, 13)
        Me.lblId.TabIndex = 30
        Me.lblId.Text = "Id"
        '
        'txtId
        '
        Me.HelpProvider1.SetHelpString(Me.txtId, "Identificativo del documento di incasso quota")
        Me.txtId.Location = New System.Drawing.Point(36, 14)
        Me.txtId.Name = "txtId"
        Me.HelpProvider1.SetShowHelp(Me.txtId, True)
        Me.txtId.Size = New System.Drawing.Size(57, 21)
        Me.txtId.TabIndex = 36
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TabPage1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 78)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.SelectedIndex = 0
        Me.GroupBox1.Size = New System.Drawing.Size(409, 222)
        Me.GroupBox1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.txtVert)
        Me.TabPage1.Controls.Add(Me.lblVert)
        Me.TabPage1.Controls.Add(Me.txtReferente)
        Me.TabPage1.Controls.Add(Me.lblRef)
        Me.TabPage1.Controls.Add(Me.lblSettore)
        Me.TabPage1.Controls.Add(Me.txtSettore)
        Me.TabPage1.Controls.Add(Me.cmdCompetenza)
        Me.TabPage1.Controls.Add(Me.txtCompetenza)
        Me.TabPage1.Controls.Add(Me.lblCompetenza)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.txtImporto)
        Me.TabPage1.Controls.Add(Me.lblValuta)
        Me.TabPage1.Controls.Add(Me.txtNote)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txtTipo)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.dtpDoc)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.dtpRegistrazione)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(401, 196)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Dati testata documento"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'txtVert
        '
        Me.txtVert.Location = New System.Drawing.Point(65, 136)
        Me.txtVert.Name = "txtVert"
        Me.txtVert.Size = New System.Drawing.Size(138, 21)
        Me.txtVert.TabIndex = 66
        Me.txtVert.Visible = False
        '
        'lblVert
        '
        Me.lblVert.AutoSize = True
        Me.lblVert.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVert.Location = New System.Drawing.Point(13, 142)
        Me.lblVert.Name = "lblVert"
        Me.lblVert.Size = New System.Drawing.Size(29, 13)
        Me.lblVert.TabIndex = 65
        Me.lblVert.Text = "Vert."
        Me.lblVert.Visible = False
        '
        'txtReferente
        '
        Me.txtReferente.Enabled = False
        Me.txtReferente.Location = New System.Drawing.Point(65, 136)
        Me.txtReferente.Name = "txtReferente"
        Me.txtReferente.Size = New System.Drawing.Size(136, 21)
        Me.txtReferente.TabIndex = 5
        '
        'lblRef
        '
        Me.lblRef.AutoSize = True
        Me.lblRef.Location = New System.Drawing.Point(10, 142)
        Me.lblRef.Name = "lblRef"
        Me.lblRef.Size = New System.Drawing.Size(40, 13)
        Me.lblRef.TabIndex = 64
        Me.lblRef.Text = "Collab."
        '
        'lblSettore
        '
        Me.lblSettore.AutoSize = True
        Me.lblSettore.Location = New System.Drawing.Point(10, 171)
        Me.lblSettore.Name = "lblSettore"
        Me.lblSettore.Size = New System.Drawing.Size(43, 13)
        Me.lblSettore.TabIndex = 62
        Me.lblSettore.Text = "Settore"
        '
        'txtSettore
        '
        Me.txtSettore.Enabled = False
        Me.HelpProvider1.SetHelpString(Me.txtSettore, "Settore di competenza per le quote incassate")
        Me.txtSettore.Location = New System.Drawing.Point(65, 165)
        Me.txtSettore.Name = "txtSettore"
        Me.HelpProvider1.SetShowHelp(Me.txtSettore, True)
        Me.txtSettore.Size = New System.Drawing.Size(151, 21)
        Me.txtSettore.TabIndex = 8
        '
        'cmdCompetenza
        '
        Me.HelpProvider1.SetHelpString(Me.cmdCompetenza, "Funzione che permette di modificare il periodo di competenza dell'incasso")
        Me.cmdCompetenza.Image = CType(resources.GetObject("cmdCompetenza.Image"), System.Drawing.Image)
        Me.cmdCompetenza.Location = New System.Drawing.Point(204, 134)
        Me.cmdCompetenza.Name = "cmdCompetenza"
        Me.HelpProvider1.SetShowHelp(Me.cmdCompetenza, True)
        Me.cmdCompetenza.Size = New System.Drawing.Size(32, 23)
        Me.cmdCompetenza.TabIndex = 7
        Me.cmdCompetenza.UseVisualStyleBackColor = True
        '
        'txtCompetenza
        '
        Me.txtCompetenza.Enabled = False
        Me.txtCompetenza.Location = New System.Drawing.Point(65, 136)
        Me.txtCompetenza.Name = "txtCompetenza"
        Me.txtCompetenza.Size = New System.Drawing.Size(137, 21)
        Me.txtCompetenza.TabIndex = 6
        '
        'lblCompetenza
        '
        Me.lblCompetenza.AutoSize = True
        Me.lblCompetenza.Location = New System.Drawing.Point(6, 141)
        Me.lblCompetenza.Name = "lblCompetenza"
        Me.lblCompetenza.Size = New System.Drawing.Size(38, 13)
        Me.lblCompetenza.TabIndex = 59
        Me.lblCompetenza.Text = "Comp."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Importo"
        '
        'txtImporto
        '
        Me.txtImporto.Enabled = False
        Me.HelpProvider1.SetHelpString(Me.txtImporto, "Importo incassato")
        Me.txtImporto.Location = New System.Drawing.Point(65, 106)
        Me.txtImporto.Name = "txtImporto"
        Me.HelpProvider1.SetShowHelp(Me.txtImporto, True)
        Me.txtImporto.Size = New System.Drawing.Size(116, 21)
        Me.txtImporto.TabIndex = 4
        '
        'lblValuta
        '
        Me.lblValuta.AutoSize = True
        Me.lblValuta.Location = New System.Drawing.Point(187, 109)
        Me.lblValuta.Name = "lblValuta"
        Me.lblValuta.Size = New System.Drawing.Size(29, 13)
        Me.lblValuta.TabIndex = 58
        Me.lblValuta.Text = "Euro"
        '
        'txtNote
        '
        Me.HelpProvider1.SetHelpString(Me.txtNote, "Eventuali note")
        Me.txtNote.Location = New System.Drawing.Point(238, 32)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.HelpProvider1.SetShowHelp(Me.txtNote, True)
        Me.txtNote.Size = New System.Drawing.Size(151, 154)
        Me.txtNote.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(235, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Note"
        '
        'txtTipo
        '
        Me.txtTipo.Enabled = False
        Me.HelpProvider1.SetHelpString(Me.txtTipo, "Tipo di incasso quota")
        Me.txtTipo.Location = New System.Drawing.Point(65, 74)
        Me.txtTipo.Name = "txtTipo"
        Me.HelpProvider1.SetShowHelp(Me.txtTipo, True)
        Me.txtTipo.Size = New System.Drawing.Size(151, 21)
        Me.txtTipo.TabIndex = 3
        Me.txtTipo.Text = "Incasso Quota Associativa"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Tipo doc."
        '
        'dtpDoc
        '
        Me.dtpDoc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.HelpProvider1.SetHelpString(Me.dtpDoc, "Data del documento di pagamento quote che fa riferimento alle quote incassate.")
        Me.dtpDoc.Location = New System.Drawing.Point(65, 43)
        Me.dtpDoc.Name = "dtpDoc"
        Me.HelpProvider1.SetShowHelp(Me.dtpDoc, True)
        Me.dtpDoc.Size = New System.Drawing.Size(96, 21)
        Me.dtpDoc.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(7, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Data doc."
        '
        'dtpRegistrazione
        '
        Me.dtpRegistrazione.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.HelpProvider1.SetHelpString(Me.dtpRegistrazione, "Data di registrazione dell'incasso quote")
        Me.dtpRegistrazione.Location = New System.Drawing.Point(65, 14)
        Me.dtpRegistrazione.Name = "dtpRegistrazione"
        Me.HelpProvider1.SetShowHelp(Me.dtpRegistrazione, True)
        Me.dtpRegistrazione.Size = New System.Drawing.Size(96, 21)
        Me.dtpRegistrazione.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(5, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Data reg."
        '
        'GridPosizioni
        '
        Me.GridPosizioni.AllowUserToAddRows = False
        Me.GridPosizioni.AllowUserToDeleteRows = False
        Me.GridPosizioni.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.NullValue = Nothing
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridPosizioni.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GridPosizioni.BackgroundColor = System.Drawing.Color.White
        Me.GridPosizioni.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GridPosizioni.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridPosizioni.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridPosizioni.DefaultCellStyle = DataGridViewCellStyle3
        Me.GridPosizioni.GridColor = System.Drawing.Color.LightGray
        Me.GridPosizioni.Location = New System.Drawing.Point(16, 310)
        Me.GridPosizioni.Name = "GridPosizioni"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridPosizioni.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.GridPosizioni.RowHeadersWidth = 30
        Me.GridPosizioni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.GridPosizioni.Size = New System.Drawing.Size(555, 308)
        Me.GridPosizioni.TabIndex = 8
        '
        'CustomBar1
        '
        Me.CustomBar1.BackColor = System.Drawing.Color.Transparent
        Me.CustomBar1.Location = New System.Drawing.Point(129, 1)
        Me.CustomBar1.Name = "CustomBar1"
        Me.CustomBar1.Size = New System.Drawing.Size(295, 40)
        Me.CustomBar1.TabIndex = 9
        '
        'GrpSogg
        '
        Me.GrpSogg.BackColor = System.Drawing.Color.Silver
        Me.GrpSogg.Controls.Add(Me.lblContratto)
        Me.GrpSogg.Controls.Add(Me.Label7)
        Me.GrpSogg.Controls.Add(Me.Label13)
        Me.GrpSogg.Controls.Add(Me.Label5)
        Me.GrpSogg.Controls.Add(Me.lblDescrizioneAzienda)
        Me.GrpSogg.Controls.Add(Me.lblCompUltimo)
        Me.GrpSogg.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GrpSogg.Location = New System.Drawing.Point(432, 100)
        Me.GrpSogg.Name = "GrpSogg"
        Me.GrpSogg.Size = New System.Drawing.Size(228, 200)
        Me.GrpSogg.TabIndex = 2
        Me.GrpSogg.Text = "Dati anagrafici del pagante"
        Me.GrpSogg.Title = "Dati Generici"
        '
        'lblContratto
        '
        Me.lblContratto.AutoSize = True
        Me.lblContratto.BackColor = System.Drawing.Color.Transparent
        Me.lblContratto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.lblContratto, "Contratto applicato")
        Me.lblContratto.Location = New System.Drawing.Point(12, 168)
        Me.lblContratto.MaximumSize = New System.Drawing.Size(160, 0)
        Me.lblContratto.Name = "lblContratto"
        Me.HelpProvider1.SetShowHelp(Me.lblContratto, True)
        Me.lblContratto.Size = New System.Drawing.Size(59, 13)
        Me.lblContratto.TabIndex = 5
        Me.lblContratto.Text = "Contratto"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(12, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Contratto applicato"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(13, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Ragione sociale:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(13, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(198, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "La competenza dell'ultimo pagamento è:"
        '
        'lblDescrizioneAzienda
        '
        Me.lblDescrizioneAzienda.AutoSize = True
        Me.lblDescrizioneAzienda.BackColor = System.Drawing.Color.Transparent
        Me.lblDescrizioneAzienda.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblDescrizioneAzienda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.lblDescrizioneAzienda, "Descrizione dell'azienda che ha pagato le quote ")
        Me.lblDescrizioneAzienda.Location = New System.Drawing.Point(18, 43)
        Me.lblDescrizioneAzienda.MaximumSize = New System.Drawing.Size(180, 0)
        Me.lblDescrizioneAzienda.Name = "lblDescrizioneAzienda"
        Me.HelpProvider1.SetShowHelp(Me.lblDescrizioneAzienda, True)
        Me.lblDescrizioneAzienda.Size = New System.Drawing.Size(121, 13)
        Me.lblDescrizioneAzienda.TabIndex = 0
        Me.lblDescrizioneAzienda.Text = "Descrizione azienda"
        '
        'lblCompUltimo
        '
        Me.lblCompUltimo.AutoSize = True
        Me.lblCompUltimo.BackColor = System.Drawing.Color.Transparent
        Me.lblCompUltimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.lblCompUltimo, "Competenza dell'ultimo pagamento effettuato dall'azienda")
        Me.lblCompUltimo.Location = New System.Drawing.Point(18, 100)
        Me.lblCompUltimo.Name = "lblCompUltimo"
        Me.HelpProvider1.SetShowHelp(Me.lblCompUltimo, True)
        Me.lblCompUltimo.Size = New System.Drawing.Size(81, 13)
        Me.lblCompUltimo.TabIndex = 1
        Me.lblCompUltimo.Text = "Comp. Ultimo"
        '
        'grpUt
        '
        Me.grpUt.BackColor = System.Drawing.Color.Silver
        Me.grpUt.Controls.Add(Me.Label8)
        Me.grpUt.Controls.Add(Me.lblDescrUt)
        Me.grpUt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grpUt.Location = New System.Drawing.Point(431, 173)
        Me.grpUt.Name = "grpUt"
        Me.grpUt.Size = New System.Drawing.Size(201, 70)
        Me.grpUt.TabIndex = 42
        Me.grpUt.Text = "Dati utente"
        Me.grpUt.Title = "Utente"
        Me.grpUt.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(13, 21)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Nome e cognome:"
        '
        'lblDescrUt
        '
        Me.lblDescrUt.AutoSize = True
        Me.lblDescrUt.BackColor = System.Drawing.Color.Transparent
        Me.lblDescrUt.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblDescrUt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.lblDescrUt, "Nome e cognome dell'utente per cui è stata pagata la quota")
        Me.lblDescrUt.Location = New System.Drawing.Point(13, 41)
        Me.lblDescrUt.MaximumSize = New System.Drawing.Size(160, 0)
        Me.lblDescrUt.Name = "lblDescrUt"
        Me.HelpProvider1.SetShowHelp(Me.lblDescrUt, True)
        Me.lblDescrUt.Size = New System.Drawing.Size(43, 13)
        Me.lblDescrUt.TabIndex = 0
        Me.lblDescrUt.Text = "utente"
        '
        'GrpRef
        '
        Me.GrpRef.BackColor = System.Drawing.Color.Silver
        Me.GrpRef.Controls.Add(Me.Label10)
        Me.GrpRef.Controls.Add(Me.lblReferente)
        Me.GrpRef.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GrpRef.Location = New System.Drawing.Point(441, 173)
        Me.GrpRef.Name = "GrpRef"
        Me.GrpRef.Size = New System.Drawing.Size(201, 107)
        Me.GrpRef.TabIndex = 3
        Me.GrpRef.Text = "Dati referente"
        Me.GrpRef.Title = "Collaboratore comunale"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(13, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Nome e cognome:"
        '
        'lblReferente
        '
        Me.lblReferente.AutoSize = True
        Me.lblReferente.BackColor = System.Drawing.Color.Transparent
        Me.lblReferente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblReferente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReferente.Location = New System.Drawing.Point(18, 43)
        Me.lblReferente.Name = "lblReferente"
        Me.lblReferente.Size = New System.Drawing.Size(58, 13)
        Me.lblReferente.TabIndex = 0
        Me.lblReferente.Text = "referente"
        '
        'Timer1
        '
        '
        'cmdAdd
        '
        Me.cmdAdd.ApplyOutLookStile = True
        Me.cmdAdd.BackColor = System.Drawing.Color.Transparent
        Me.cmdAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdAdd.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.addsede_48x48
        Me.cmdAdd.Disabled = False
        Me.cmdAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdAdd.ForeColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.cmdAdd, "Funzione che permette di aggiungere una posizione di incasso quota al documento")
        Me.cmdAdd.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdAdd.Location = New System.Drawing.Point(17, 84)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Radius = 48.0!
        Me.HelpProvider1.SetShowHelp(Me.cmdAdd, True)
        Me.cmdAdd.ShowTooltip = True
        Me.cmdAdd.Size = New System.Drawing.Size(48, 48)
        Me.cmdAdd.TabIndex = 6
        Me.cmdAdd.TextValue = ""
        Me.cmdAdd.TooltipText = "Aggiungi posizione"
        '
        'cmdDel
        '
        Me.cmdDel.ApplyOutLookStile = True
        Me.cmdDel.BackColor = System.Drawing.Color.Transparent
        Me.cmdDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdDel.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.removesede_48x48
        Me.cmdDel.Disabled = False
        Me.cmdDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDel.ForeColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.cmdDel, "funzione che permette di eliminare una posizione di incasso quota al documento")
        Me.cmdDel.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdDel.Location = New System.Drawing.Point(17, 129)
        Me.cmdDel.Name = "cmdDel"
        Me.cmdDel.Radius = 48.0!
        Me.HelpProvider1.SetShowHelp(Me.cmdDel, True)
        Me.cmdDel.ShowTooltip = True
        Me.cmdDel.Size = New System.Drawing.Size(48, 48)
        Me.cmdDel.TabIndex = 7
        Me.cmdDel.TextValue = ""
        Me.cmdDel.TooltipText = "Rimuovi posizione"
        '
        'CmdDown
        '
        Me.CmdDown.ApplyOutLookStile = True
        Me.CmdDown.BackColor = System.Drawing.Color.Transparent
        Me.CmdDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CmdDown.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.package_edutainment_48x48_down
        Me.CmdDown.Disabled = False
        Me.CmdDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdDown.ForeColor = System.Drawing.Color.Transparent
        Me.CmdDown.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CmdDown.Location = New System.Drawing.Point(15, 38)
        Me.CmdDown.Name = "CmdDown"
        Me.CmdDown.Radius = 48.0!
        Me.CmdDown.ShowTooltip = True
        Me.CmdDown.Size = New System.Drawing.Size(48, 48)
        Me.CmdDown.TabIndex = 5
        Me.CmdDown.TextValue = ""
        Me.CmdDown.TooltipText = "Ordina dal basso"
        '
        'cmdUp
        '
        Me.cmdUp.ApplyOutLookStile = True
        Me.cmdUp.BackColor = System.Drawing.Color.Transparent
        Me.cmdUp.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.package_edutainment_48x48_up
        Me.cmdUp.Disabled = False
        Me.cmdUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdUp.ForeColor = System.Drawing.Color.Transparent
        Me.cmdUp.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdUp.Location = New System.Drawing.Point(15, -1)
        Me.cmdUp.Name = "cmdUp"
        Me.cmdUp.Radius = 48.0!
        Me.cmdUp.ShowTooltip = True
        Me.cmdUp.Size = New System.Drawing.Size(48, 48)
        Me.cmdUp.TabIndex = 4
        Me.cmdUp.TextValue = ""
        Me.cmdUp.TooltipText = "Ordina dall'alto"
        '
        'cmdCerca
        '
        Me.cmdCerca.ApplyOutLookStile = True
        Me.cmdCerca.BackColor = System.Drawing.Color.Transparent
        Me.cmdCerca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdCerca.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.k_ghost_view_32x322
        Me.cmdCerca.Disabled = False
        Me.cmdCerca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdCerca.ForeColor = System.Drawing.Color.Transparent
        Me.cmdCerca.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdCerca.Location = New System.Drawing.Point(23, 7)
        Me.cmdCerca.Name = "cmdCerca"
        Me.cmdCerca.Radius = 32.0!
        Me.cmdCerca.ShowTooltip = True
        Me.cmdCerca.Size = New System.Drawing.Size(32, 32)
        Me.cmdCerca.TabIndex = 41
        Me.cmdCerca.TextValue = ""
        Me.cmdCerca.TooltipText = "Cerca documenti"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.internalmenubar
        Me.Panel1.Controls.Add(Me.cmdUp)
        Me.Panel1.Controls.Add(Me.cmdDel)
        Me.Panel1.Controls.Add(Me.cmdAdd)
        Me.Panel1.Controls.Add(Me.CmdDown)
        Me.Panel1.Location = New System.Drawing.Point(582, 307)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(78, 180)
        Me.Panel1.TabIndex = 35
        '
        'SpecialButton1
        '
        Me.SpecialButton1.ApplyOutLookStile = True
        Me.SpecialButton1.BackColor = System.Drawing.Color.Transparent
        Me.SpecialButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SpecialButton1.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.print_address_48x48
        Me.SpecialButton1.Disabled = False
        Me.SpecialButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SpecialButton1.ForeColor = System.Drawing.Color.Transparent
        Me.SpecialButton1.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SpecialButton1.Location = New System.Drawing.Point(425, 9)
        Me.SpecialButton1.Name = "SpecialButton1"
        Me.SpecialButton1.Radius = 32.0!
        Me.SpecialButton1.ShowTooltip = True
        Me.SpecialButton1.Size = New System.Drawing.Size(32, 32)
        Me.SpecialButton1.TabIndex = 42
        Me.SpecialButton1.TextValue = ""
        Me.SpecialButton1.TooltipText = "Visualizza report"
        Me.SpecialButton1.Visible = False
        '
        'ControlDocumentView
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.GridPosizioni)
        Me.Controls.Add(Me.grpUt)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GrpSogg)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GrpRef)
        Me.Name = "ControlDocumentView"
        Me.Size = New System.Drawing.Size(700, 637)
        Me.Controls.SetChildIndex(Me.GrpRef, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.GrpSogg, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.grpUt, 0)
        Me.Controls.SetChildIndex(Me.GridPosizioni, 0)
        Me.Controls.SetChildIndex(Me.DockPanel, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.DockPanel.ResumeLayout(False)
        Me.DockPanel.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.GridPosizioni, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpSogg.ResumeLayout(False)
        Me.GrpSogg.PerformLayout()
        Me.grpUt.ResumeLayout(False)
        Me.grpUt.PerformLayout()
        Me.GrpRef.ResumeLayout(False)
        Me.GrpRef.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTipo As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtpDoc As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpRegistrazione As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdCerca As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents CmdDown As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents cmdUp As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents CustomBar1 As WIN.GUI.APPLICATION.PRESENTATION.CustomBar
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblValuta As System.Windows.Forms.Label
    Friend WithEvents GrpSogg As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents Label13 As System.Windows.Forms.Label
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents lblDescrizioneAzienda As System.Windows.Forms.Label
   Friend WithEvents lblCompUltimo As System.Windows.Forms.Label
   Friend WithEvents cmdAdd As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents cmdDel As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents cmdCompetenza As System.Windows.Forms.Button
   Friend WithEvents txtCompetenza As System.Windows.Forms.TextBox
   Friend WithEvents lblCompetenza As System.Windows.Forms.Label
   Friend WithEvents lblSettore As System.Windows.Forms.Label
   Friend WithEvents txtSettore As System.Windows.Forms.TextBox
   Friend WithEvents lblContratto As System.Windows.Forms.Label
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Public WithEvents GridPosizioni As System.Windows.Forms.DataGridView
   Public WithEvents txtImporto As System.Windows.Forms.TextBox
    Friend WithEvents GrpRef As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblReferente As System.Windows.Forms.Label
    Friend WithEvents txtReferente As System.Windows.Forms.TextBox
    Friend WithEvents lblRef As System.Windows.Forms.Label
    Friend WithEvents txtVert As System.Windows.Forms.TextBox
    Friend WithEvents lblVert As System.Windows.Forms.Label
    Friend WithEvents grpUt As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents lblDescrUt As System.Windows.Forms.Label
   Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents SpecialButton1 As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton

End Class
