<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlInoltroDelega
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

    'NOTA: la procedura che segue � richiesta da Progettazione Windows Form
    'Pu� essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlInoltroDelega))
        Me.GroupBox3 = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboEnti = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblSogg = New System.Windows.Forms.Label()
        Me.chkReg = New System.Windows.Forms.CheckBox()
        Me.chkDoc = New System.Windows.Forms.CheckBox()
        Me.dtpRegDa = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpRegA = New System.Windows.Forms.DateTimePicker()
        Me.dtpDocA = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpDocDa = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cmdSelectAll = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.CmdDeselectAll = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.CmdInoltra = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.CmdRpt = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.cmdPrint = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.GridPosizioni = New DevExpress.XtraGrid.GridControl()
        Me.DelegadTOBindingSource = New System.Windows.Forms.BindingSource()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SpecialButton1 = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.colNome_Provincia_Nascita = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNome_Comune_Nascita = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNome_Comune = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIndirizzo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNome_Nazione = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNome_Provincia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCap = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodice_Fiscale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataNascita = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCognome = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNome = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSelected = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContratto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCellulare1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCellulare2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCausaleSottoscrizione = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReparto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCausaleFineCiclo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEnteInoltro = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSettore = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataDocumento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataRegistrazione = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colUtente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatoDelega = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReferente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataInoltro = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataAccettazioneDelega = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataDecorrenzaDelega = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataAnnullamentoDelega = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataRevocaDelega = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSedeOperativa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colResponsabile = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DockPanel.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.GridPosizioni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DelegadTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Size = New System.Drawing.Size(619, 30)
        '
        'DockPanel
        '
        Me.DockPanel.Controls.Add(Me.SpecialButton1)
        Me.DockPanel.Controls.Add(Me.CmdInoltra)
        Me.DockPanel.Controls.Add(Me.CmdDeselectAll)
        Me.DockPanel.Controls.Add(Me.cmdSelectAll)
        Me.DockPanel.Controls.Add(Me.cmdPrint)
        Me.DockPanel.Controls.Add(Me.Label20)
        Me.DockPanel.Controls.Add(Me.CmdRpt)
        Me.DockPanel.Size = New System.Drawing.Size(619, 44)
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Silver
        Me.GroupBox3.Controls.Add(Me.lblNum)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.cboEnti)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.lblSogg)
        Me.GroupBox3.Controls.Add(Me.chkReg)
        Me.GroupBox3.Controls.Add(Me.chkDoc)
        Me.GroupBox3.Controls.Add(Me.dtpRegDa)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.dtpRegA)
        Me.GroupBox3.Controls.Add(Me.dtpDocA)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.dtpDocDa)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Black
        Me.GroupBox3.Location = New System.Drawing.Point(18, 85)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(553, 154)
        Me.GroupBox3.TabIndex = 81
        Me.GroupBox3.Text = "Selezione criteri documenti"
        Me.GroupBox3.Title = "Dati di selezione"
        '
        'lblNum
        '
        Me.lblNum.AutoSize = True
        Me.lblNum.BackColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.lblNum, "Numero di deleghe che sono risulate dalla ricerca effettuata")
        Me.lblNum.Location = New System.Drawing.Point(411, 122)
        Me.lblNum.Name = "lblNum"
        Me.HelpProvider1.SetShowHelp(Me.lblNum, True)
        Me.lblNum.Size = New System.Drawing.Size(11, 13)
        Me.lblNum.TabIndex = 138
        Me.lblNum.Text = "-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(323, 122)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 137
        Me.Label7.Text = "Numero risultati:"
        '
        'cboEnti
        '
        Me.cboEnti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEnti.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEnti.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboEnti, "Ente bilaterale a cui viene inoltrata la delega. Se non viene selezionato alcun e" & _
        "nte, verranno selezionate sia le deleghe inoltrate all'EdilCassa sia le deleghe " & _
        "inoltrate alla CassaEdile")
        Me.cboEnti.Location = New System.Drawing.Point(45, 114)
        Me.cboEnti.Name = "cboEnti"
        Me.HelpProvider1.SetShowHelp(Me.cboEnti, True)
        Me.cboEnti.Size = New System.Drawing.Size(169, 21)
        Me.cboEnti.TabIndex = 88
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(10, 122)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(29, 13)
        Me.Label21.TabIndex = 89
        Me.Label21.Text = "Ente"
        '
        'lblSogg
        '
        Me.lblSogg.AutoSize = True
        Me.lblSogg.BackColor = System.Drawing.Color.Transparent
        Me.lblSogg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSogg.Location = New System.Drawing.Point(94, 224)
        Me.lblSogg.Name = "lblSogg"
        Me.lblSogg.Size = New System.Drawing.Size(0, 13)
        Me.lblSogg.TabIndex = 87
        '
        'chkReg
        '
        Me.chkReg.AutoSize = True
        Me.chkReg.BackColor = System.Drawing.Color.Transparent
        Me.chkReg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.chkReg, resources.GetString("chkReg.HelpString"))
        Me.chkReg.Location = New System.Drawing.Point(305, 49)
        Me.chkReg.Name = "chkReg"
        Me.HelpProvider1.SetShowHelp(Me.chkReg, True)
        Me.chkReg.Size = New System.Drawing.Size(117, 17)
        Me.chkReg.TabIndex = 59
        Me.chkReg.Text = "Selezione data reg."
        Me.chkReg.UseVisualStyleBackColor = False
        '
        'chkDoc
        '
        Me.chkDoc.AutoSize = True
        Me.chkDoc.BackColor = System.Drawing.Color.Transparent
        Me.chkDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.chkDoc, resources.GetString("chkDoc.HelpString"))
        Me.chkDoc.Location = New System.Drawing.Point(305, 79)
        Me.chkDoc.Name = "chkDoc"
        Me.HelpProvider1.SetShowHelp(Me.chkDoc, True)
        Me.chkDoc.Size = New System.Drawing.Size(120, 17)
        Me.chkDoc.TabIndex = 62
        Me.chkDoc.Text = "Selezione data doc."
        Me.chkDoc.UseVisualStyleBackColor = False
        '
        'dtpRegDa
        '
        Me.dtpRegDa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRegDa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRegDa.Location = New System.Drawing.Point(45, 47)
        Me.dtpRegDa.Name = "dtpRegDa"
        Me.dtpRegDa.Size = New System.Drawing.Size(99, 20)
        Me.dtpRegDa.TabIndex = 60
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(158, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 13)
        Me.Label10.TabIndex = 73
        Me.Label10.Text = "a"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(10, 83)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(21, 13)
        Me.Label11.TabIndex = 72
        Me.Label11.Text = "Da"
        '
        'dtpRegA
        '
        Me.dtpRegA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpRegA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRegA.Location = New System.Drawing.Point(189, 47)
        Me.dtpRegA.Name = "dtpRegA"
        Me.dtpRegA.Size = New System.Drawing.Size(98, 20)
        Me.dtpRegA.TabIndex = 61
        '
        'dtpDocA
        '
        Me.dtpDocA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDocA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDocA.Location = New System.Drawing.Point(189, 77)
        Me.dtpDocA.Name = "dtpDocA"
        Me.dtpDocA.Size = New System.Drawing.Size(98, 20)
        Me.dtpDocA.TabIndex = 64
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(21, 13)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Da"
        '
        'dtpDocDa
        '
        Me.dtpDocDa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDocDa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDocDa.Location = New System.Drawing.Point(45, 77)
        Me.dtpDocDa.Name = "dtpDocDa"
        Me.dtpDocDa.Size = New System.Drawing.Size(99, 20)
        Me.dtpDocDa.TabIndex = 63
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(158, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 13)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "a"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(13, 18)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(35, 13)
        Me.Label20.TabIndex = 85
        Me.Label20.Text = "Cerca"
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
        Me.cmdSelectAll.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdSelectAll.Location = New System.Drawing.Point(228, 3)
        Me.cmdSelectAll.Name = "cmdSelectAll"
        Me.cmdSelectAll.Radius = 36.0!
        Me.cmdSelectAll.ShowTooltip = True
        Me.cmdSelectAll.Size = New System.Drawing.Size(36, 36)
        Me.cmdSelectAll.TabIndex = 102
        Me.cmdSelectAll.TextValue = ""
        Me.cmdSelectAll.TooltipText = "Seleziona tutto"
        '
        'CmdDeselectAll
        '
        Me.CmdDeselectAll.ApplyOutLookStile = True
        Me.CmdDeselectAll.BackColor = System.Drawing.Color.Transparent
        Me.CmdDeselectAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CmdDeselectAll.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.kate_48x48_disabled
        Me.CmdDeselectAll.Disabled = False
        Me.CmdDeselectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdDeselectAll.ForeColor = System.Drawing.Color.Transparent
        Me.CmdDeselectAll.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CmdDeselectAll.Location = New System.Drawing.Point(285, 5)
        Me.CmdDeselectAll.Name = "CmdDeselectAll"
        Me.CmdDeselectAll.Radius = 36.0!
        Me.CmdDeselectAll.ShowTooltip = True
        Me.CmdDeselectAll.Size = New System.Drawing.Size(36, 36)
        Me.CmdDeselectAll.TabIndex = 103
        Me.CmdDeselectAll.TextValue = ""
        Me.CmdDeselectAll.TooltipText = "Deseleziona tutto"
        '
        'CmdInoltra
        '
        Me.CmdInoltra.ApplyOutLookStile = True
        Me.CmdInoltra.BackColor = System.Drawing.Color.Transparent
        Me.CmdInoltra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CmdInoltra.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.email_32x32
        Me.CmdInoltra.Disabled = False
        Me.CmdInoltra.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdInoltra.ForeColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.CmdInoltra, resources.GetString("CmdInoltra.HelpString"))
        Me.CmdInoltra.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CmdInoltra.Location = New System.Drawing.Point(164, 3)
        Me.CmdInoltra.Name = "CmdInoltra"
        Me.CmdInoltra.Radius = 36.0!
        Me.HelpProvider1.SetShowHelp(Me.CmdInoltra, True)
        Me.CmdInoltra.ShowTooltip = True
        Me.CmdInoltra.Size = New System.Drawing.Size(36, 36)
        Me.CmdInoltra.TabIndex = 104
        Me.CmdInoltra.TextValue = ""
        Me.CmdInoltra.TooltipText = "Inoltra tutte le deleghe"
        '
        'CmdRpt
        '
        Me.CmdRpt.ApplyOutLookStile = True
        Me.CmdRpt.BackColor = System.Drawing.Color.Transparent
        Me.CmdRpt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CmdRpt.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.k_ghost_view_32x32
        Me.CmdRpt.Disabled = False
        Me.CmdRpt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdRpt.ForeColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.CmdRpt, "Funzione che avvia la ricerca delle deleghe che soddisfano i criteri di selezione" & _
        " impostati.")
        Me.CmdRpt.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CmdRpt.Location = New System.Drawing.Point(54, 5)
        Me.CmdRpt.Name = "CmdRpt"
        Me.CmdRpt.Radius = 32.0!
        Me.HelpProvider1.SetShowHelp(Me.CmdRpt, True)
        Me.CmdRpt.ShowTooltip = True
        Me.CmdRpt.Size = New System.Drawing.Size(32, 32)
        Me.CmdRpt.TabIndex = 84
        Me.CmdRpt.TextValue = ""
        Me.CmdRpt.TooltipText = "Elabora report"
        '
        'cmdPrint
        '
        Me.cmdPrint.ApplyOutLookStile = True
        Me.cmdPrint.BackColor = System.Drawing.Color.Transparent
        Me.cmdPrint.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.print_32x32_active
        Me.cmdPrint.Disabled = False
        Me.cmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPrint.ForeColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.cmdPrint, "Funzione che permette di stampare il report.")
        Me.cmdPrint.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdPrint.Location = New System.Drawing.Point(115, 5)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Radius = 32.0!
        Me.HelpProvider1.SetShowHelp(Me.cmdPrint, True)
        Me.cmdPrint.ShowTooltip = True
        Me.cmdPrint.Size = New System.Drawing.Size(32, 32)
        Me.cmdPrint.TabIndex = 120
        Me.cmdPrint.TextValue = ""
        Me.cmdPrint.TooltipText = "Stampa report"
        '
        'GridPosizioni
        '
        Me.GridPosizioni.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridPosizioni.DataSource = Me.DelegadTOBindingSource
        Me.GridPosizioni.Location = New System.Drawing.Point(18, 245)
        Me.GridPosizioni.MainView = Me.GridView1
        Me.GridPosizioni.Name = "GridPosizioni"
        Me.GridPosizioni.Size = New System.Drawing.Size(553, 361)
        Me.GridPosizioni.TabIndex = 123
        Me.GridPosizioni.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'DelegadTOBindingSource
        '
        Me.DelegadTOBindingSource.DataSource = GetType(WIN.DOMAIN.FEDERATIONARTIFACTS.DelegadTO)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSelected, Me.colUtente, Me.colSettore, Me.colStatoDelega, Me.colDataDocumento, Me.colNome_Provincia_Nascita, Me.colNome_Comune_Nascita, Me.colNome_Comune, Me.colIndirizzo, Me.colNome_Nazione, Me.colNome_Provincia, Me.colCap, Me.colCodice_Fiscale, Me.colDataNascita, Me.colCognome, Me.colNome, Me.colContratto, Me.colCellulare1, Me.colCellulare2, Me.colCausaleSottoscrizione, Me.colReparto, Me.colCausaleFineCiclo, Me.colEnteInoltro, Me.colNote, Me.colDataRegistrazione, Me.colReferente, Me.colDataInoltro, Me.colDataAccettazioneDelega, Me.colDataDecorrenzaDelega, Me.colDataAnnullamentoDelega, Me.colDataRevocaDelega, Me.colSedeOperativa, Me.colResponsabile})
        Me.GridView1.GridControl = Me.GridPosizioni
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "TipoDocumento", Nothing, "")})
        Me.GridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridView1.OptionsMenu.ShowGroupSummaryEditorItem = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'SpecialButton1
        '
        Me.SpecialButton1.ApplyOutLookStile = True
        Me.SpecialButton1.BackColor = System.Drawing.Color.Transparent
        Me.SpecialButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SpecialButton1.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.txt_2_48x48
        Me.SpecialButton1.Disabled = False
        Me.SpecialButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SpecialButton1.ForeColor = System.Drawing.Color.Transparent
        Me.SpecialButton1.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SpecialButton1.Location = New System.Drawing.Point(329, 5)
        Me.SpecialButton1.Name = "SpecialButton1"
        Me.SpecialButton1.Radius = 36.0!
        Me.SpecialButton1.ShowTooltip = True
        Me.SpecialButton1.Size = New System.Drawing.Size(36, 36)
        Me.SpecialButton1.TabIndex = 121
        Me.SpecialButton1.TextValue = ""
        Me.SpecialButton1.TooltipText = "Seleziona una delega per utente"
        '
        'colNome_Provincia_Nascita
        '
        Me.colNome_Provincia_Nascita.FieldName = "Nome_Provincia_Nascita"
        Me.colNome_Provincia_Nascita.Name = "colNome_Provincia_Nascita"
        '
        'colNome_Comune_Nascita
        '
        Me.colNome_Comune_Nascita.FieldName = "Nome_Comune_Nascita"
        Me.colNome_Comune_Nascita.Name = "colNome_Comune_Nascita"
        '
        'colNome_Comune
        '
        Me.colNome_Comune.FieldName = "Nome_Comune"
        Me.colNome_Comune.Name = "colNome_Comune"
        '
        'colIndirizzo
        '
        Me.colIndirizzo.FieldName = "Indirizzo"
        Me.colIndirizzo.Name = "colIndirizzo"
        '
        'colNome_Nazione
        '
        Me.colNome_Nazione.FieldName = "Nome_Nazione"
        Me.colNome_Nazione.Name = "colNome_Nazione"
        '
        'colNome_Provincia
        '
        Me.colNome_Provincia.FieldName = "Nome_Provincia"
        Me.colNome_Provincia.Name = "colNome_Provincia"
        '
        'colCap
        '
        Me.colCap.FieldName = "Cap"
        Me.colCap.Name = "colCap"
        '
        'colCodice_Fiscale
        '
        Me.colCodice_Fiscale.FieldName = "Codice_Fiscale"
        Me.colCodice_Fiscale.Name = "colCodice_Fiscale"
        '
        'colDataNascita
        '
        Me.colDataNascita.FieldName = "DataNascita"
        Me.colDataNascita.Name = "colDataNascita"
        '
        'colCognome
        '
        Me.colCognome.FieldName = "Cognome"
        Me.colCognome.Name = "colCognome"
        '
        'colNome
        '
        Me.colNome.FieldName = "Nome"
        Me.colNome.Name = "colNome"
        '
        'colSelected
        '
        Me.colSelected.FieldName = "Selected"
        Me.colSelected.Name = "colSelected"
        Me.colSelected.Visible = True
        Me.colSelected.VisibleIndex = 0
        '
        'colContratto
        '
        Me.colContratto.FieldName = "Contratto"
        Me.colContratto.Name = "colContratto"
        '
        'colCellulare1
        '
        Me.colCellulare1.FieldName = "Cellulare1"
        Me.colCellulare1.Name = "colCellulare1"
        '
        'colCellulare2
        '
        Me.colCellulare2.FieldName = "Cellulare2"
        Me.colCellulare2.Name = "colCellulare2"
        '
        'colCausaleSottoscrizione
        '
        Me.colCausaleSottoscrizione.FieldName = "CausaleSottoscrizione"
        Me.colCausaleSottoscrizione.Name = "colCausaleSottoscrizione"
        '
        'colReparto
        '
        Me.colReparto.FieldName = "Reparto"
        Me.colReparto.Name = "colReparto"
        '
        'colCausaleFineCiclo
        '
        Me.colCausaleFineCiclo.FieldName = "CausaleFineCiclo"
        Me.colCausaleFineCiclo.Name = "colCausaleFineCiclo"
        '
        'colEnteInoltro
        '
        Me.colEnteInoltro.FieldName = "EnteInoltro"
        Me.colEnteInoltro.Name = "colEnteInoltro"
        '
        'colSettore
        '
        Me.colSettore.FieldName = "Settore"
        Me.colSettore.Name = "colSettore"
        Me.colSettore.Visible = True
        Me.colSettore.VisibleIndex = 2
        '
        'colNote
        '
        Me.colNote.FieldName = "Note"
        Me.colNote.Name = "colNote"
        '
        'colDataDocumento
        '
        Me.colDataDocumento.FieldName = "DataDocumento"
        Me.colDataDocumento.Name = "colDataDocumento"
        Me.colDataDocumento.Visible = True
        Me.colDataDocumento.VisibleIndex = 4
        '
        'colDataRegistrazione
        '
        Me.colDataRegistrazione.FieldName = "DataRegistrazione"
        Me.colDataRegistrazione.Name = "colDataRegistrazione"
        '
        'colUtente
        '
        Me.colUtente.FieldName = "Utente"
        Me.colUtente.Name = "colUtente"
        Me.colUtente.Visible = True
        Me.colUtente.VisibleIndex = 1
        '
        'colStatoDelega
        '
        Me.colStatoDelega.FieldName = "StatoDelega"
        Me.colStatoDelega.Name = "colStatoDelega"
        Me.colStatoDelega.Visible = True
        Me.colStatoDelega.VisibleIndex = 3
        '
        'colReferente
        '
        Me.colReferente.FieldName = "Referente"
        Me.colReferente.Name = "colReferente"
        '
        'colDataInoltro
        '
        Me.colDataInoltro.FieldName = "DataInoltro"
        Me.colDataInoltro.Name = "colDataInoltro"
        '
        'colDataAccettazioneDelega
        '
        Me.colDataAccettazioneDelega.FieldName = "DataAccettazioneDelega"
        Me.colDataAccettazioneDelega.Name = "colDataAccettazioneDelega"
        '
        'colDataDecorrenzaDelega
        '
        Me.colDataDecorrenzaDelega.FieldName = "DataDecorrenzaDelega"
        Me.colDataDecorrenzaDelega.Name = "colDataDecorrenzaDelega"
        '
        'colDataAnnullamentoDelega
        '
        Me.colDataAnnullamentoDelega.FieldName = "DataAnnullamentoDelega"
        Me.colDataAnnullamentoDelega.Name = "colDataAnnullamentoDelega"
        '
        'colDataRevocaDelega
        '
        Me.colDataRevocaDelega.FieldName = "DataRevocaDelega"
        Me.colDataRevocaDelega.Name = "colDataRevocaDelega"
        '
        'colSedeOperativa
        '
        Me.colSedeOperativa.FieldName = "SedeOperativa"
        Me.colSedeOperativa.Name = "colSedeOperativa"
        '
        'colResponsabile
        '
        Me.colResponsabile.FieldName = "Responsabile"
        Me.colResponsabile.Name = "colResponsabile"
        '
        'ControlInoltroDelega
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.GridPosizioni)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "ControlInoltroDelega"
        Me.Size = New System.Drawing.Size(619, 623)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.DockPanel, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.GridPosizioni, 0)
        Me.DockPanel.ResumeLayout(False)
        Me.DockPanel.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.GridPosizioni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DelegadTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
   Friend WithEvents GroupBox3 As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents cboEnti As System.Windows.Forms.ComboBox
   Friend WithEvents Label21 As System.Windows.Forms.Label
   Friend WithEvents lblSogg As System.Windows.Forms.Label
   Friend WithEvents chkReg As System.Windows.Forms.CheckBox
   Friend WithEvents chkDoc As System.Windows.Forms.CheckBox
   Friend WithEvents dtpRegDa As System.Windows.Forms.DateTimePicker
   Friend WithEvents Label10 As System.Windows.Forms.Label
   Friend WithEvents Label11 As System.Windows.Forms.Label
   Friend WithEvents dtpRegA As System.Windows.Forms.DateTimePicker
   Friend WithEvents dtpDocA As System.Windows.Forms.DateTimePicker
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents dtpDocDa As System.Windows.Forms.DateTimePicker
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Friend WithEvents Label20 As System.Windows.Forms.Label
   Friend WithEvents CmdRpt As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents CmdInoltra As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents cmdSelectAll As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents CmdDeselectAll As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents lblNum As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
   Friend WithEvents cmdPrint As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents GridPosizioni As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents DelegadTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SpecialButton1 As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents colSelected As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colUtente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSettore As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatoDelega As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataDocumento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome_Provincia_Nascita As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome_Comune_Nascita As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome_Comune As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIndirizzo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome_Nazione As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome_Provincia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCap As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodice_Fiscale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataNascita As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCognome As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContratto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCellulare1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCellulare2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCausaleSottoscrizione As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReparto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCausaleFineCiclo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEnteInoltro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataRegistrazione As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReferente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataInoltro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataAccettazioneDelega As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataDecorrenzaDelega As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataAnnullamentoDelega As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataRevocaDelega As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSedeOperativa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colResponsabile As DevExpress.XtraGrid.Columns.GridColumn

End Class
