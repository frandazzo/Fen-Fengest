<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportIncassiQuote
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportIncassiQuote))
        Me.GroupBox2 = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.lblReferente = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cmdDett = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.lblTipoRistorno = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.lblSogg = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblContratto = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.lblSettore = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lblCompetenza = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblDocRange = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblRegRange = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdListaLavoro = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.cmdPrint = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.GridPosizioni = New DevExpress.XtraGrid.GridControl()
        Me.QuotaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUtente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataDocumento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoDocumento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImporto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompetenza = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProvinciaNascita = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComuneNascita = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProvincia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComune = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCap = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIndirizzo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCognome = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNome = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataNascita = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodiceFiscale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoPrestazione = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSoggettoEsecutore = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDocumentoPadre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSettore = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImportoRistorno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPagamentoReferente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAziendaImpiego = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContrattoApplicato = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLivelloInquadramento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOreLavorate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOreMalattia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReferente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTredicesima = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuattordicesima = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataRegistrazione = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSedeOperativa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCoperto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colScoperto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DockPanel.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridPosizioni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuotaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Size = New System.Drawing.Size(702, 26)
        '
        'DockPanel
        '
        Me.DockPanel.Controls.Add(Me.cmdListaLavoro)
        Me.DockPanel.Controls.Add(Me.cmdPrint)
        Me.DockPanel.Location = New System.Drawing.Point(0, 26)
        Me.DockPanel.Size = New System.Drawing.Size(702, 44)
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.lblReferente)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.cmdDett)
        Me.GroupBox2.Controls.Add(Me.lblTipoRistorno)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.lblSogg)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.lblContratto)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.lblSettore)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.lblCompetenza)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.lblDocRange)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.lblRegRange)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.lblTipo)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.lblData)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(15, 78)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(659, 110)
        Me.GroupBox2.TabIndex = 107
        Me.GroupBox2.Text = "Dati report"
        Me.GroupBox2.Title = "Dati report"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(537, 81)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(109, 13)
        Me.Label30.TabIndex = 110
        Me.Label30.Text = "Visualizza Lista Utenti"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(439, 80)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(73, 13)
        Me.Label29.TabIndex = 105
        Me.Label29.Text = "Utenti  inclusi:"
        '
        'lblReferente
        '
        Me.lblReferente.AutoSize = True
        Me.lblReferente.Location = New System.Drawing.Point(283, 82)
        Me.lblReferente.MaximumSize = New System.Drawing.Size(80, 0)
        Me.lblReferente.Name = "lblReferente"
        Me.lblReferente.Size = New System.Drawing.Size(63, 13)
        Me.lblReferente.TabIndex = 96
        Me.lblReferente.Text = "Referente"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(200, 82)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(77, 13)
        Me.Label22.TabIndex = 95
        Me.Label22.Text = "Coollab.  com.:"
        '
        'cmdDett
        '
        Me.cmdDett.ApplyOutLookStile = True
        Me.cmdDett.BackColor = System.Drawing.Color.Transparent
        Me.cmdDett.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdDett.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.k_edit_16x16
        Me.cmdDett.Disabled = False
        Me.cmdDett.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDett.ForeColor = System.Drawing.Color.Transparent
        Me.cmdDett.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdDett.Location = New System.Drawing.Point(521, 80)
        Me.cmdDett.Name = "cmdDett"
        Me.cmdDett.Radius = 16.0!
        Me.cmdDett.ShowTooltip = True
        Me.cmdDett.Size = New System.Drawing.Size(16, 16)
        Me.cmdDett.TabIndex = 104
        Me.cmdDett.TextValue = ""
        Me.cmdDett.TooltipText = "Visualizza lista utenti"
        '
        'lblTipoRistorno
        '
        Me.lblTipoRistorno.AutoSize = True
        Me.lblTipoRistorno.Location = New System.Drawing.Point(74, 81)
        Me.lblTipoRistorno.Name = "lblTipoRistorno"
        Me.lblTipoRistorno.Size = New System.Drawing.Size(32, 13)
        Me.lblTipoRistorno.TabIndex = 94
        Me.lblTipoRistorno.Text = "Tipo"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(4, 82)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(68, 13)
        Me.Label26.TabIndex = 93
        Me.Label26.Text = "Tipo ristorno:"
        '
        'lblSogg
        '
        Me.lblSogg.AutoSize = True
        Me.lblSogg.Location = New System.Drawing.Point(515, 53)
        Me.lblSogg.MaximumSize = New System.Drawing.Size(80, 0)
        Me.lblSogg.Name = "lblSogg"
        Me.lblSogg.Size = New System.Drawing.Size(58, 13)
        Me.lblSogg.TabIndex = 92
        Me.lblSogg.Text = "Soggetto"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(449, 53)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(62, 13)
        Me.Label20.TabIndex = 91
        Me.Label20.Text = "Sogg. pag.:"
        '
        'lblContratto
        '
        Me.lblContratto.AutoSize = True
        Me.lblContratto.Location = New System.Drawing.Point(283, 61)
        Me.lblContratto.Name = "lblContratto"
        Me.lblContratto.Size = New System.Drawing.Size(59, 13)
        Me.lblContratto.TabIndex = 90
        Me.lblContratto.Text = "Contratto"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(200, 61)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(77, 13)
        Me.Label23.TabIndex = 89
        Me.Label23.Text = "Contratto app.:"
        '
        'lblSettore
        '
        Me.lblSettore.AutoSize = True
        Me.lblSettore.Location = New System.Drawing.Point(74, 61)
        Me.lblSettore.Name = "lblSettore"
        Me.lblSettore.Size = New System.Drawing.Size(48, 13)
        Me.lblSettore.TabIndex = 88
        Me.lblSettore.Text = "Settore"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(26, 61)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(44, 13)
        Me.Label25.TabIndex = 87
        Me.Label25.Text = "Settore:"
        '
        'lblCompetenza
        '
        Me.lblCompetenza.AutoSize = True
        Me.lblCompetenza.Location = New System.Drawing.Point(519, 21)
        Me.lblCompetenza.Name = "lblCompetenza"
        Me.lblCompetenza.Size = New System.Drawing.Size(76, 13)
        Me.lblCompetenza.TabIndex = 86
        Me.lblCompetenza.Text = "Competenza"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(452, 21)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(69, 13)
        Me.Label21.TabIndex = 85
        Me.Label21.Text = "Competenza:"
        '
        'lblDocRange
        '
        Me.lblDocRange.AutoSize = True
        Me.lblDocRange.Location = New System.Drawing.Point(283, 41)
        Me.lblDocRange.Name = "lblDocRange"
        Me.lblDocRange.Size = New System.Drawing.Size(44, 13)
        Me.lblDocRange.TabIndex = 84
        Me.lblDocRange.Text = "Range"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(216, 41)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(57, 13)
        Me.Label19.TabIndex = 83
        Me.Label19.Text = "Data doc.:"
        '
        'lblRegRange
        '
        Me.lblRegRange.AutoSize = True
        Me.lblRegRange.Location = New System.Drawing.Point(74, 41)
        Me.lblRegRange.Name = "lblRegRange"
        Me.lblRegRange.Size = New System.Drawing.Size(44, 13)
        Me.lblRegRange.TabIndex = 82
        Me.lblRegRange.Text = "Range"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(13, 41)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(54, 13)
        Me.Label17.TabIndex = 81
        Me.Label17.Text = "Data reg.:"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(283, 21)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(55, 13)
        Me.lblTipo.TabIndex = 80
        Me.lblTipo.Text = "TipoDoc"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(229, 21)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(48, 13)
        Me.Label16.TabIndex = 79
        Me.Label16.Text = "Tipi doc:"
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(74, 21)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(34, 13)
        Me.lblData.TabIndex = 78
        Me.lblData.Text = "Data"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Data report:"
        '
        'cmdListaLavoro
        '
        Me.cmdListaLavoro.ApplyOutLookStile = True
        Me.cmdListaLavoro.BackColor = System.Drawing.Color.Transparent
        Me.cmdListaLavoro.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.k_address_book_32x32
        Me.cmdListaLavoro.Disabled = False
        Me.cmdListaLavoro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdListaLavoro.ForeColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.cmdListaLavoro, resources.GetString("cmdListaLavoro.HelpString"))
        Me.cmdListaLavoro.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdListaLavoro.Location = New System.Drawing.Point(9, 6)
        Me.cmdListaLavoro.Name = "cmdListaLavoro"
        Me.cmdListaLavoro.Radius = 32.0!
        Me.HelpProvider1.SetShowHelp(Me.cmdListaLavoro, True)
        Me.cmdListaLavoro.ShowTooltip = True
        Me.cmdListaLavoro.Size = New System.Drawing.Size(32, 32)
        Me.cmdListaLavoro.TabIndex = 117
        Me.cmdListaLavoro.TextValue = ""
        Me.cmdListaLavoro.TooltipText = "Crea lista di lavoro"
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
        Me.cmdPrint.Location = New System.Drawing.Point(55, 6)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Radius = 32.0!
        Me.HelpProvider1.SetShowHelp(Me.cmdPrint, True)
        Me.cmdPrint.ShowTooltip = True
        Me.cmdPrint.Size = New System.Drawing.Size(32, 32)
        Me.cmdPrint.TabIndex = 115
        Me.cmdPrint.TextValue = ""
        Me.cmdPrint.TooltipText = "Stampa report"
        '
        'GridPosizioni
        '
        Me.GridPosizioni.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridPosizioni.DataSource = Me.QuotaBindingSource
        Me.GridPosizioni.Location = New System.Drawing.Point(15, 194)
        Me.GridPosizioni.MainView = Me.GridView1
        Me.GridPosizioni.Name = "GridPosizioni"
        Me.GridPosizioni.Size = New System.Drawing.Size(659, 457)
        Me.GridPosizioni.TabIndex = 109
        Me.GridPosizioni.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'QuotaBindingSource
        '
        Me.QuotaBindingSource.DataSource = GetType(WIN.DOMAIN.FEDERATIONARTIFACTS.Quota)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUtente, Me.colDataDocumento, Me.colTipoDocumento, Me.colImporto, Me.colCompetenza, Me.colProvinciaNascita, Me.colComuneNascita, Me.colProvincia, Me.colComune, Me.colCap, Me.colIndirizzo, Me.colCognome, Me.colNome, Me.colDataNascita, Me.colCodiceFiscale, Me.colTipoPrestazione, Me.colSoggettoEsecutore, Me.colDocumentoPadre, Me.colSettore, Me.colImportoRistorno, Me.colPagamentoReferente, Me.colAziendaImpiego, Me.colContrattoApplicato, Me.colLivelloInquadramento, Me.colOreLavorate, Me.colOreMalattia, Me.colReferente, Me.colTredicesima, Me.colQuattordicesima, Me.colDataRegistrazione, Me.colNote, Me.colSedeOperativa, Me.colCoperto, Me.colScoperto})
        Me.GridView1.GridControl = Me.GridPosizioni
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "TipoDocumento", Nothing, "")})
        Me.GridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridView1.OptionsMenu.ShowGroupSummaryEditorItem = True
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'colUtente
        '
        Me.colUtente.Caption = "Utente"
        Me.colUtente.FieldName = "Utente"
        Me.colUtente.Name = "colUtente"
        Me.colUtente.Visible = True
        Me.colUtente.VisibleIndex = 0
        '
        'colDataDocumento
        '
        Me.colDataDocumento.FieldName = "DataDocumento"
        Me.colDataDocumento.Name = "colDataDocumento"
        Me.colDataDocumento.Visible = True
        Me.colDataDocumento.VisibleIndex = 1
        '
        'colTipoDocumento
        '
        Me.colTipoDocumento.FieldName = "TipoDocumento"
        Me.colTipoDocumento.Name = "colTipoDocumento"
        Me.colTipoDocumento.Visible = True
        Me.colTipoDocumento.VisibleIndex = 2
        '
        'colImporto
        '
        Me.colImporto.FieldName = "Importo"
        Me.colImporto.Name = "colImporto"
        Me.colImporto.Visible = True
        Me.colImporto.VisibleIndex = 3
        '
        'colCompetenza
        '
        Me.colCompetenza.FieldName = "Competenza"
        Me.colCompetenza.Name = "colCompetenza"
        Me.colCompetenza.Visible = True
        Me.colCompetenza.VisibleIndex = 4
        '
        'colProvinciaNascita
        '
        Me.colProvinciaNascita.Caption = "Provincia di nascita"
        Me.colProvinciaNascita.FieldName = "ProvinciaNascita"
        Me.colProvinciaNascita.Name = "colProvinciaNascita"
        '
        'colComuneNascita
        '
        Me.colComuneNascita.Caption = "Comune di nascita"
        Me.colComuneNascita.FieldName = "ComuneNascita"
        Me.colComuneNascita.Name = "colComuneNascita"
        '
        'colProvincia
        '
        Me.colProvincia.Caption = "Provincia"
        Me.colProvincia.FieldName = "Provincia"
        Me.colProvincia.Name = "colProvincia"
        '
        'colComune
        '
        Me.colComune.Caption = "Comune"
        Me.colComune.FieldName = "Comune"
        Me.colComune.Name = "colComune"
        '
        'colCap
        '
        Me.colCap.Caption = "Cap"
        Me.colCap.FieldName = "Cap"
        Me.colCap.Name = "colCap"
        '
        'colIndirizzo
        '
        Me.colIndirizzo.Caption = "Indirizzo"
        Me.colIndirizzo.FieldName = "Indirizzo"
        Me.colIndirizzo.Name = "colIndirizzo"
        '
        'colCognome
        '
        Me.colCognome.Caption = "Cognome"
        Me.colCognome.FieldName = "Cognome"
        Me.colCognome.Name = "colCognome"
        '
        'colNome
        '
        Me.colNome.Caption = "Nome"
        Me.colNome.FieldName = "Nome"
        Me.colNome.Name = "colNome"
        '
        'colDataNascita
        '
        Me.colDataNascita.Caption = "Data nascita"
        Me.colDataNascita.FieldName = "DataNascita"
        Me.colDataNascita.Name = "colDataNascita"
        '
        'colCodiceFiscale
        '
        Me.colCodiceFiscale.Caption = "Codice fiscale"
        Me.colCodiceFiscale.FieldName = "CodiceFiscale"
        Me.colCodiceFiscale.Name = "colCodiceFiscale"
        '
        'colTipoPrestazione
        '
        Me.colTipoPrestazione.Caption = "Tipo prestazione"
        Me.colTipoPrestazione.FieldName = "TipoPrestazione"
        Me.colTipoPrestazione.Name = "colTipoPrestazione"
        '
        'colSoggettoEsecutore
        '
        Me.colSoggettoEsecutore.Caption = "Azienda"
        Me.colSoggettoEsecutore.FieldName = "SoggettoEsecutore"
        Me.colSoggettoEsecutore.Name = "colSoggettoEsecutore"
        '
        'colDocumentoPadre
        '
        Me.colDocumentoPadre.FieldName = "DocumentoPadre"
        Me.colDocumentoPadre.Name = "colDocumentoPadre"
        '
        'colSettore
        '
        Me.colSettore.Caption = "Settore"
        Me.colSettore.FieldName = "Settore"
        Me.colSettore.Name = "colSettore"
        '
        'colImportoRistorno
        '
        Me.colImportoRistorno.FieldName = "ImportoRistorno"
        Me.colImportoRistorno.Name = "colImportoRistorno"
        '
        'colPagamentoReferente
        '
        Me.colPagamentoReferente.FieldName = "PagamentoReferente"
        Me.colPagamentoReferente.Name = "colPagamentoReferente"
        '
        'colAziendaImpiego
        '
        Me.colAziendaImpiego.FieldName = "AziendaImpiego"
        Me.colAziendaImpiego.Name = "colAziendaImpiego"
        '
        'colContrattoApplicato
        '
        Me.colContrattoApplicato.FieldName = "ContrattoApplicato"
        Me.colContrattoApplicato.Name = "colContrattoApplicato"
        '
        'colLivelloInquadramento
        '
        Me.colLivelloInquadramento.FieldName = "LivelloInquadramento"
        Me.colLivelloInquadramento.Name = "colLivelloInquadramento"
        '
        'colOreLavorate
        '
        Me.colOreLavorate.FieldName = "OreLavorate"
        Me.colOreLavorate.Name = "colOreLavorate"
        '
        'colOreMalattia
        '
        Me.colOreMalattia.FieldName = "OreMalattia"
        Me.colOreMalattia.Name = "colOreMalattia"
        '
        'colReferente
        '
        Me.colReferente.FieldName = "Referente"
        Me.colReferente.Name = "colReferente"
        '
        'colTredicesima
        '
        Me.colTredicesima.FieldName = "Tredicesima"
        Me.colTredicesima.Name = "colTredicesima"
        '
        'colQuattordicesima
        '
        Me.colQuattordicesima.FieldName = "Quattordicesima"
        Me.colQuattordicesima.Name = "colQuattordicesima"
        '
        'colDataRegistrazione
        '
        Me.colDataRegistrazione.FieldName = "DataRegistrazione"
        Me.colDataRegistrazione.Name = "colDataRegistrazione"
        '
        'colNote
        '
        Me.colNote.FieldName = "Note"
        Me.colNote.Name = "colNote"
        '
        'colSedeOperativa
        '
        Me.colSedeOperativa.FieldName = "SedeOperativa"
        Me.colSedeOperativa.Name = "colSedeOperativa"
        '
        'colCoperto
        '
        Me.colCoperto.FieldName = "Coperto"
        Me.colCoperto.Name = "colCoperto"
        Me.colCoperto.Visible = True
        Me.colCoperto.VisibleIndex = 5
        '
        'colScoperto
        '
        Me.colScoperto.FieldName = "Scoperto"
        Me.colScoperto.Name = "colScoperto"
        Me.colScoperto.Visible = True
        Me.colScoperto.VisibleIndex = 6
        '
        'ReportIncassiQuote
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GridPosizioni)
        Me.Name = "ReportIncassiQuote"
        Me.Size = New System.Drawing.Size(702, 675)
        Me.Controls.SetChildIndex(Me.DockPanel, 0)
        Me.Controls.SetChildIndex(Me.GridPosizioni, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.DockPanel.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.GridPosizioni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuotaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdDett As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents GroupBox2 As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblSogg As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lblContratto As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents lblSettore As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents lblCompetenza As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lblDocRange As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lblRegRange As System.Windows.Forms.Label
    Friend WithEvents lblReferente As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents lblTipoRistorno As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents cmdPrint As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents cmdListaLavoro As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents GridPosizioni As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents QuotaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colUtente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataDocumento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoDocumento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImporto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompetenza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProvinciaNascita As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComuneNascita As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProvincia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComune As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCap As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIndirizzo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCognome As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataNascita As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodiceFiscale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoPrestazione As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSoggettoEsecutore As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDocumentoPadre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSettore As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImportoRistorno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPagamentoReferente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAziendaImpiego As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContrattoApplicato As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLivelloInquadramento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOreLavorate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOreMalattia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReferente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTredicesima As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuattordicesima As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataRegistrazione As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSedeOperativa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCoperto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colScoperto As DevExpress.XtraGrid.Columns.GridColumn

End Class
