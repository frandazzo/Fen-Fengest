<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportDelegheFializzate
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
        Me.spview = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.cmdPrint = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.cmdListaLavoro = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.GroupBox2 = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.lblEnte = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblCausaleSott = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblRev = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblAnn = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblAtt = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblAcc = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblInol = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblSott = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblRevRange = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblAnnRange = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblAttRange = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblAccRange = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblInRange = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblReferente = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblSettore = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lblRegRange = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GridDeleghe = New DevExpress.XtraGrid.GridControl()
        Me.GridDelegheView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colUtente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSettore = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStatoDelega = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataDocumento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMailAzienda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProvinciaAzienda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComuneAzienda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIndirizzoAzienda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCapAzienda = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.colContratto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdContratto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCellulare1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCellulare2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCausaleSottoscrizione = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReparto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCausaleFineCiclo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colEnteInoltro = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataRegistrazione = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdUtente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReferente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdReferente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataInoltro = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataAccettazioneDelega = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataDecorrenzaDelega = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataAnnullamentoDelega = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataRevocaDelega = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSedeOperativa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colResponsabile = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DelegadTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GridQuote = New DevExpress.XtraGrid.GridControl()
        Me.QuotaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridQuoteView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoDocumento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImporto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompetenza = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProvinciaNascita = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComuneNascita = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProvincia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComune = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodiceFiscale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoPrestazione = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSoggettoEsecutore = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDocumentoPadre = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImportoRistorno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPagamentoReferente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAziendaImpiego = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContrattoApplicato = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLivelloInquadramento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOreLavorate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colOreMalattia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTredicesima = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQuattordicesima = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCoperto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colScoperto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GridDelegheSenzaQuote = New DevExpress.XtraGrid.GridControl()
        Me.GridDelegheSenzaQuoteView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn81 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn82 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn83 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn84 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn85 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn86 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn87 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn88 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn89 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn90 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn91 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn92 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn93 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn94 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn95 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn96 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn97 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn98 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn99 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn100 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn101 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn102 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn103 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn104 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn105 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn106 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn107 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn108 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn109 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn110 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn111 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn112 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn113 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn114 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn115 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn116 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn117 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn118 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn119 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn120 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn121 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.GridQuoteConDelega = New DevExpress.XtraGrid.GridControl()
        Me.GridQuoteConDelegaView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn47 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn48 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn49 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn51 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn52 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn53 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn54 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn55 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn56 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn57 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn58 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn59 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn60 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn61 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn62 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn63 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn64 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn65 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn66 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn67 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn68 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn69 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn70 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn71 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn72 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn73 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn74 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn75 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn76 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn77 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn78 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn79 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn80 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.GridQuoteSenzaDelega = New DevExpress.XtraGrid.GridControl()
        Me.GridQuoteSenzaDelegaView = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn20 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn21 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn26 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn27 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn28 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn29 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn30 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn31 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn32 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn33 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn34 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn35 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn36 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn37 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn38 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn39 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn40 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn41 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn42 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn43 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn44 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn45 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn46 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DockPanel.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridDeleghe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridDelegheView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DelegadTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.GridQuote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuotaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridQuoteView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.GridDelegheSenzaQuote, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridDelegheSenzaQuoteView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.GridQuoteConDelega, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridQuoteConDelegaView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.GridQuoteSenzaDelega, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridQuoteSenzaDelegaView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Size = New System.Drawing.Size(756, 30)
        '
        'DockPanel
        '
        Me.DockPanel.Controls.Add(Me.spview)
        Me.DockPanel.Controls.Add(Me.cmdPrint)
        Me.DockPanel.Controls.Add(Me.cmdListaLavoro)
        Me.DockPanel.Size = New System.Drawing.Size(756, 44)
        '
        'spview
        '
        Me.spview.ApplyOutLookStile = True
        Me.spview.BackColor = System.Drawing.Color.Transparent
        Me.spview.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.file_view_32x32
        Me.spview.Disabled = False
        Me.spview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.spview.ForeColor = System.Drawing.Color.Transparent
        Me.spview.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.spview.Location = New System.Drawing.Point(109, 9)
        Me.spview.Name = "spview"
        Me.spview.Radius = 32.0!
        Me.spview.ShowTooltip = True
        Me.spview.Size = New System.Drawing.Size(32, 32)
        Me.spview.TabIndex = 124
        Me.spview.TextValue = ""
        Me.spview.TooltipText = "Cambia visualizzazione"
        '
        'cmdPrint
        '
        Me.cmdPrint.ApplyOutLookStile = True
        Me.cmdPrint.BackColor = System.Drawing.Color.Transparent
        Me.cmdPrint.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.print_32x32_active
        Me.cmdPrint.Disabled = False
        Me.cmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPrint.ForeColor = System.Drawing.Color.Transparent
        Me.cmdPrint.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdPrint.Location = New System.Drawing.Point(57, 9)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Radius = 32.0!
        Me.cmdPrint.ShowTooltip = True
        Me.cmdPrint.Size = New System.Drawing.Size(32, 32)
        Me.cmdPrint.TabIndex = 122
        Me.cmdPrint.TextValue = ""
        Me.cmdPrint.TooltipText = "Stampa report"
        '
        'cmdListaLavoro
        '
        Me.cmdListaLavoro.ApplyOutLookStile = True
        Me.cmdListaLavoro.BackColor = System.Drawing.Color.Transparent
        Me.cmdListaLavoro.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.k_address_book_32x32
        Me.cmdListaLavoro.Disabled = False
        Me.cmdListaLavoro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdListaLavoro.ForeColor = System.Drawing.Color.Transparent
        Me.cmdListaLavoro.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdListaLavoro.Location = New System.Drawing.Point(11, 9)
        Me.cmdListaLavoro.Name = "cmdListaLavoro"
        Me.cmdListaLavoro.Radius = 32.0!
        Me.cmdListaLavoro.ShowTooltip = True
        Me.cmdListaLavoro.Size = New System.Drawing.Size(32, 32)
        Me.cmdListaLavoro.TabIndex = 123
        Me.cmdListaLavoro.TextValue = ""
        Me.cmdListaLavoro.TooltipText = "Crea lista di lavoro"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.lblEnte)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.lblCausaleSott)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.lblNum)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.lblRev)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lblAnn)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.lblAtt)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.lblAcc)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.lblInol)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.lblSott)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.lblRevRange)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.lblAnnRange)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.lblAttRange)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.lblAccRange)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lblInRange)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.lblReferente)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.lblSettore)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.lblRegRange)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.lblData)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(5, 79)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(730, 247)
        Me.GroupBox2.TabIndex = 119
        Me.GroupBox2.Text = "Dati report"
        Me.GroupBox2.Title = "Dati report"
        '
        'lblEnte
        '
        Me.lblEnte.AutoSize = True
        Me.lblEnte.Location = New System.Drawing.Point(322, 65)
        Me.lblEnte.MaximumSize = New System.Drawing.Size(80, 0)
        Me.lblEnte.Name = "lblEnte"
        Me.lblEnte.Size = New System.Drawing.Size(33, 13)
        Me.lblEnte.TabIndex = 144
        Me.lblEnte.Text = "Ente"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(275, 65)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(32, 13)
        Me.Label20.TabIndex = 143
        Me.Label20.Text = "Ente:"
        '
        'lblCausaleSott
        '
        Me.lblCausaleSott.AutoSize = True
        Me.lblCausaleSott.Location = New System.Drawing.Point(532, 55)
        Me.lblCausaleSott.Name = "lblCausaleSott"
        Me.lblCausaleSott.Size = New System.Drawing.Size(52, 13)
        Me.lblCausaleSott.TabIndex = 140
        Me.lblCausaleSott.Text = "Causale"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(468, 55)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 13)
        Me.Label14.TabIndex = 139
        Me.Label14.Text = "Cau. sott.:"
        '
        'lblNum
        '
        Me.lblNum.AutoSize = True
        Me.lblNum.Location = New System.Drawing.Point(532, 102)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(28, 13)
        Me.lblNum.TabIndex = 136
        Me.lblNum.Text = "100"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(444, 102)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 135
        Me.Label7.Text = "Numero risultati:"
        '
        'lblRev
        '
        Me.lblRev.AutoSize = True
        Me.lblRev.Location = New System.Drawing.Point(322, 200)
        Me.lblRev.Name = "lblRev"
        Me.lblRev.Size = New System.Drawing.Size(40, 13)
        Me.lblRev.TabIndex = 134
        Me.lblRev.Text = "Si/No"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(250, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 133
        Me.Label5.Text = "Revocate:"
        '
        'lblAnn
        '
        Me.lblAnn.AutoSize = True
        Me.lblAnn.Location = New System.Drawing.Point(322, 177)
        Me.lblAnn.Name = "lblAnn"
        Me.lblAnn.Size = New System.Drawing.Size(40, 13)
        Me.lblAnn.TabIndex = 132
        Me.lblAnn.Text = "Si/No"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(253, 177)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 131
        Me.Label9.Text = "Annullate:"
        '
        'lblAtt
        '
        Me.lblAtt.AutoSize = True
        Me.lblAtt.Location = New System.Drawing.Point(322, 155)
        Me.lblAtt.Name = "lblAtt"
        Me.lblAtt.Size = New System.Drawing.Size(40, 13)
        Me.lblAtt.TabIndex = 130
        Me.lblAtt.Text = "Si/No"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(261, 155)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 13)
        Me.Label13.TabIndex = 129
        Me.Label13.Text = "Attivate:"
        '
        'lblAcc
        '
        Me.lblAcc.AutoSize = True
        Me.lblAcc.Location = New System.Drawing.Point(322, 133)
        Me.lblAcc.Name = "lblAcc"
        Me.lblAcc.Size = New System.Drawing.Size(40, 13)
        Me.lblAcc.TabIndex = 128
        Me.lblAcc.Text = "Si/No"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(251, 133)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 13)
        Me.Label15.TabIndex = 127
        Me.Label15.Text = "Accettate:"
        '
        'lblInol
        '
        Me.lblInol.AutoSize = True
        Me.lblInol.Location = New System.Drawing.Point(322, 111)
        Me.lblInol.Name = "lblInol"
        Me.lblInol.Size = New System.Drawing.Size(40, 13)
        Me.lblInol.TabIndex = 126
        Me.lblInol.Text = "Si/No"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(259, 111)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(48, 13)
        Me.Label18.TabIndex = 125
        Me.Label18.Text = "Inoltrate:"
        '
        'lblSott
        '
        Me.lblSott.AutoSize = True
        Me.lblSott.Location = New System.Drawing.Point(322, 91)
        Me.lblSott.Name = "lblSott"
        Me.lblSott.Size = New System.Drawing.Size(40, 13)
        Me.lblSott.TabIndex = 124
        Me.lblSott.Text = "Si/No"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(244, 91)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(63, 13)
        Me.Label21.TabIndex = 123
        Me.Label21.Text = "Sottoscritte:"
        '
        'lblRevRange
        '
        Me.lblRevRange.AutoSize = True
        Me.lblRevRange.Location = New System.Drawing.Point(89, 205)
        Me.lblRevRange.Name = "lblRevRange"
        Me.lblRevRange.Size = New System.Drawing.Size(44, 13)
        Me.lblRevRange.TabIndex = 122
        Me.lblRevRange.Text = "Range"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(17, 205)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 13)
        Me.Label12.TabIndex = 121
        Me.Label12.Text = "Data rev. in:"
        '
        'lblAnnRange
        '
        Me.lblAnnRange.AutoSize = True
        Me.lblAnnRange.Location = New System.Drawing.Point(89, 182)
        Me.lblAnnRange.Name = "lblAnnRange"
        Me.lblAnnRange.Size = New System.Drawing.Size(44, 13)
        Me.lblAnnRange.TabIndex = 120
        Me.lblAnnRange.Text = "Range"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 182)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 119
        Me.Label8.Text = "Data ann. in:"
        '
        'lblAttRange
        '
        Me.lblAttRange.AutoSize = True
        Me.lblAttRange.Location = New System.Drawing.Point(89, 158)
        Me.lblAttRange.Name = "lblAttRange"
        Me.lblAttRange.Size = New System.Drawing.Size(44, 13)
        Me.lblAttRange.TabIndex = 118
        Me.lblAttRange.Text = "Range"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(14, 158)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(70, 13)
        Me.Label10.TabIndex = 117
        Me.Label10.Text = "Data attiv. in:"
        '
        'lblAccRange
        '
        Me.lblAccRange.AutoSize = True
        Me.lblAccRange.Location = New System.Drawing.Point(89, 134)
        Me.lblAccRange.Name = "lblAccRange"
        Me.lblAccRange.Size = New System.Drawing.Size(44, 13)
        Me.lblAccRange.TabIndex = 116
        Me.lblAccRange.Text = "Range"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 115
        Me.Label6.Text = "Data acc. in:"
        '
        'lblInRange
        '
        Me.lblInRange.AutoSize = True
        Me.lblInRange.Location = New System.Drawing.Point(89, 111)
        Me.lblInRange.Name = "lblInRange"
        Me.lblInRange.Size = New System.Drawing.Size(44, 13)
        Me.lblInRange.TabIndex = 114
        Me.lblInRange.Text = "Range"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(19, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 113
        Me.Label4.Text = "Data inol. in:"
        '
        'lblReferente
        '
        Me.lblReferente.AutoSize = True
        Me.lblReferente.Location = New System.Drawing.Point(532, 79)
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
        Me.Label22.Location = New System.Drawing.Point(457, 79)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(68, 13)
        Me.Label22.TabIndex = 95
        Me.Label22.Text = "Collab. com.:"
        '
        'lblSettore
        '
        Me.lblSettore.AutoSize = True
        Me.lblSettore.Location = New System.Drawing.Point(322, 40)
        Me.lblSettore.MaximumSize = New System.Drawing.Size(80, 0)
        Me.lblSettore.Name = "lblSettore"
        Me.lblSettore.Size = New System.Drawing.Size(43, 13)
        Me.lblSettore.TabIndex = 88
        Me.lblSettore.Text = "EDILE"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(263, 40)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(44, 13)
        Me.Label25.TabIndex = 87
        Me.Label25.Text = "Settore:"
        '
        'lblRegRange
        '
        Me.lblRegRange.AutoSize = True
        Me.lblRegRange.Location = New System.Drawing.Point(91, 91)
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
        Me.Label17.Location = New System.Drawing.Point(19, 91)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 13)
        Me.Label17.TabIndex = 81
        Me.Label17.Text = "Data reg. in:"
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Location = New System.Drawing.Point(89, 28)
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
        Me.Label2.Location = New System.Drawing.Point(21, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "Data report:"
        '
        'GridDeleghe
        '
        Me.GridDeleghe.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridDeleghe.Location = New System.Drawing.Point(3, 3)
        Me.GridDeleghe.MainView = Me.GridDelegheView
        Me.GridDeleghe.Name = "GridDeleghe"
        Me.GridDeleghe.Size = New System.Drawing.Size(716, 265)
        Me.GridDeleghe.TabIndex = 123
        Me.GridDeleghe.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridDelegheView})
        '
        'GridDelegheView
        '
        Me.GridDelegheView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUtente, Me.colSettore, Me.colStatoDelega, Me.colDataDocumento, Me.colMailAzienda, Me.colProvinciaAzienda, Me.colComuneAzienda, Me.colIndirizzoAzienda, Me.colCapAzienda, Me.colNome_Provincia_Nascita, Me.colNome_Comune_Nascita, Me.colNome_Comune, Me.colIndirizzo, Me.colNome_Nazione, Me.colNome_Provincia, Me.colCap, Me.colCodice_Fiscale, Me.colDataNascita, Me.colCognome, Me.colNome, Me.colContratto, Me.colIdContratto, Me.colCellulare1, Me.colCellulare2, Me.colCausaleSottoscrizione, Me.colReparto, Me.colCausaleFineCiclo, Me.colEnteInoltro, Me.colNote, Me.colDataRegistrazione, Me.colIdUtente, Me.colReferente, Me.colIdReferente, Me.colDataInoltro, Me.colDataAccettazioneDelega, Me.colDataDecorrenzaDelega, Me.colDataAnnullamentoDelega, Me.colDataRevocaDelega, Me.colSedeOperativa, Me.colResponsabile, Me.colId})
        Me.GridDelegheView.GridControl = Me.GridDeleghe
        Me.GridDelegheView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "TipoDocumento", Nothing, "")})
        Me.GridDelegheView.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridDelegheView.Name = "GridDelegheView"
        Me.GridDelegheView.OptionsBehavior.Editable = False
        Me.GridDelegheView.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridDelegheView.OptionsMenu.ShowGroupSummaryEditorItem = True
        Me.GridDelegheView.OptionsSelection.MultiSelect = True
        Me.GridDelegheView.OptionsView.ShowDetailButtons = False
        Me.GridDelegheView.OptionsView.ShowFooter = True
        Me.GridDelegheView.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'colUtente
        '
        Me.colUtente.FieldName = "Utente"
        Me.colUtente.Name = "colUtente"
        Me.colUtente.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colUtente.Visible = True
        Me.colUtente.VisibleIndex = 0
        '
        'colSettore
        '
        Me.colSettore.FieldName = "Settore"
        Me.colSettore.Name = "colSettore"
        Me.colSettore.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colSettore.Visible = True
        Me.colSettore.VisibleIndex = 1
        '
        'colStatoDelega
        '
        Me.colStatoDelega.FieldName = "StatoDelega"
        Me.colStatoDelega.Name = "colStatoDelega"
        Me.colStatoDelega.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colStatoDelega.Visible = True
        Me.colStatoDelega.VisibleIndex = 2
        '
        'colDataDocumento
        '
        Me.colDataDocumento.FieldName = "DataDocumento"
        Me.colDataDocumento.Name = "colDataDocumento"
        Me.colDataDocumento.Visible = True
        Me.colDataDocumento.VisibleIndex = 3
        '
        'colMailAzienda
        '
        Me.colMailAzienda.FieldName = "MailAzienda"
        Me.colMailAzienda.Name = "colMailAzienda"
        '
        'colProvinciaAzienda
        '
        Me.colProvinciaAzienda.FieldName = "ProvinciaAzienda"
        Me.colProvinciaAzienda.Name = "colProvinciaAzienda"
        Me.colProvinciaAzienda.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colComuneAzienda
        '
        Me.colComuneAzienda.FieldName = "ComuneAzienda"
        Me.colComuneAzienda.Name = "colComuneAzienda"
        Me.colComuneAzienda.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colIndirizzoAzienda
        '
        Me.colIndirizzoAzienda.FieldName = "IndirizzoAzienda"
        Me.colIndirizzoAzienda.Name = "colIndirizzoAzienda"
        '
        'colCapAzienda
        '
        Me.colCapAzienda.FieldName = "CapAzienda"
        Me.colCapAzienda.Name = "colCapAzienda"
        '
        'colNome_Provincia_Nascita
        '
        Me.colNome_Provincia_Nascita.FieldName = "Nome_Provincia_Nascita"
        Me.colNome_Provincia_Nascita.Name = "colNome_Provincia_Nascita"
        Me.colNome_Provincia_Nascita.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colNome_Comune_Nascita
        '
        Me.colNome_Comune_Nascita.FieldName = "Nome_Comune_Nascita"
        Me.colNome_Comune_Nascita.Name = "colNome_Comune_Nascita"
        Me.colNome_Comune_Nascita.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colNome_Comune
        '
        Me.colNome_Comune.FieldName = "Nome_Comune"
        Me.colNome_Comune.Name = "colNome_Comune"
        Me.colNome_Comune.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
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
        Me.colNome_Nazione.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colNome_Provincia
        '
        Me.colNome_Provincia.FieldName = "Nome_Provincia"
        Me.colNome_Provincia.Name = "colNome_Provincia"
        Me.colNome_Provincia.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
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
        Me.colCodice_Fiscale.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
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
        'colContratto
        '
        Me.colContratto.FieldName = "Contratto"
        Me.colContratto.Name = "colContratto"
        Me.colContratto.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colIdContratto
        '
        Me.colIdContratto.FieldName = "IdContratto"
        Me.colIdContratto.Name = "colIdContratto"
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
        Me.colCausaleSottoscrizione.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
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
        Me.colCausaleFineCiclo.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colEnteInoltro
        '
        Me.colEnteInoltro.FieldName = "EnteInoltro"
        Me.colEnteInoltro.Name = "colEnteInoltro"
        Me.colEnteInoltro.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colNote
        '
        Me.colNote.FieldName = "Note"
        Me.colNote.Name = "colNote"
        '
        'colDataRegistrazione
        '
        Me.colDataRegistrazione.FieldName = "DataRegistrazione"
        Me.colDataRegistrazione.Name = "colDataRegistrazione"
        '
        'colIdUtente
        '
        Me.colIdUtente.FieldName = "IdUtente"
        Me.colIdUtente.Name = "colIdUtente"
        '
        'colReferente
        '
        Me.colReferente.FieldName = "Referente"
        Me.colReferente.Name = "colReferente"
        Me.colReferente.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colIdReferente
        '
        Me.colIdReferente.FieldName = "IdReferente"
        Me.colIdReferente.Name = "colIdReferente"
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
        'colId
        '
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        '
        'DelegadTOBindingSource
        '
        Me.DelegadTOBindingSource.DataSource = GetType(WIN.DOMAIN.FEDERATIONARTIFACTS.DelegadTO)
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(5, 345)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(730, 297)
        Me.TabControl1.TabIndex = 124
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GridDeleghe)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(722, 271)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Deleghe trovate"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GridQuote)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(722, 271)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Quote trovate"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GridQuote
        '
        Me.GridQuote.DataSource = Me.QuotaBindingSource
        Me.GridQuote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridQuote.Location = New System.Drawing.Point(3, 3)
        Me.GridQuote.MainView = Me.GridQuoteView
        Me.GridQuote.Name = "GridQuote"
        Me.GridQuote.Size = New System.Drawing.Size(716, 265)
        Me.GridQuote.TabIndex = 110
        Me.GridQuote.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridQuoteView})
        '
        'QuotaBindingSource
        '
        Me.QuotaBindingSource.DataSource = GetType(WIN.DOMAIN.FEDERATIONARTIFACTS.Quota)
        '
        'GridQuoteView
        '
        Me.GridQuoteView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.colTipoDocumento, Me.colImporto, Me.colCompetenza, Me.colProvinciaNascita, Me.colComuneNascita, Me.colProvincia, Me.colComune, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.colCodiceFiscale, Me.colTipoPrestazione, Me.colSoggettoEsecutore, Me.colDocumentoPadre, Me.GridColumn8, Me.colImportoRistorno, Me.colPagamentoReferente, Me.colAziendaImpiego, Me.colContrattoApplicato, Me.colLivelloInquadramento, Me.colOreLavorate, Me.colOreMalattia, Me.GridColumn9, Me.colTredicesima, Me.colQuattordicesima, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.colCoperto, Me.colScoperto})
        Me.GridQuoteView.GridControl = Me.GridQuote
        Me.GridQuoteView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "TipoDocumento", Nothing, "")})
        Me.GridQuoteView.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridQuoteView.Name = "GridQuoteView"
        Me.GridQuoteView.OptionsBehavior.Editable = False
        Me.GridQuoteView.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridQuoteView.OptionsMenu.ShowGroupSummaryEditorItem = True
        Me.GridQuoteView.OptionsSelection.MultiSelect = True
        Me.GridQuoteView.OptionsView.ShowDetailButtons = False
        Me.GridQuoteView.OptionsView.ShowFooter = True
        Me.GridQuoteView.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Utente"
        Me.GridColumn1.FieldName = "Utente"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        '
        'GridColumn2
        '
        Me.GridColumn2.FieldName = "DataDocumento"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
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
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Cap"
        Me.GridColumn3.FieldName = "Cap"
        Me.GridColumn3.Name = "GridColumn3"
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Indirizzo"
        Me.GridColumn4.FieldName = "Indirizzo"
        Me.GridColumn4.Name = "GridColumn4"
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Cognome"
        Me.GridColumn5.FieldName = "Cognome"
        Me.GridColumn5.Name = "GridColumn5"
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Nome"
        Me.GridColumn6.FieldName = "Nome"
        Me.GridColumn6.Name = "GridColumn6"
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Data nascita"
        Me.GridColumn7.FieldName = "DataNascita"
        Me.GridColumn7.Name = "GridColumn7"
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
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Settore"
        Me.GridColumn8.FieldName = "Settore"
        Me.GridColumn8.Name = "GridColumn8"
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
        'GridColumn9
        '
        Me.GridColumn9.FieldName = "Referente"
        Me.GridColumn9.Name = "GridColumn9"
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
        'GridColumn10
        '
        Me.GridColumn10.FieldName = "DataRegistrazione"
        Me.GridColumn10.Name = "GridColumn10"
        '
        'GridColumn11
        '
        Me.GridColumn11.FieldName = "Note"
        Me.GridColumn11.Name = "GridColumn11"
        '
        'GridColumn12
        '
        Me.GridColumn12.FieldName = "SedeOperativa"
        Me.GridColumn12.Name = "GridColumn12"
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
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GridDelegheSenzaQuote)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(722, 271)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Deleghe senza quota"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GridDelegheSenzaQuote
        '
        Me.GridDelegheSenzaQuote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridDelegheSenzaQuote.Location = New System.Drawing.Point(3, 3)
        Me.GridDelegheSenzaQuote.MainView = Me.GridDelegheSenzaQuoteView
        Me.GridDelegheSenzaQuote.Name = "GridDelegheSenzaQuote"
        Me.GridDelegheSenzaQuote.Size = New System.Drawing.Size(716, 265)
        Me.GridDelegheSenzaQuote.TabIndex = 124
        Me.GridDelegheSenzaQuote.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridDelegheSenzaQuoteView})
        '
        'GridDelegheSenzaQuoteView
        '
        Me.GridDelegheSenzaQuoteView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn81, Me.GridColumn82, Me.GridColumn83, Me.GridColumn84, Me.GridColumn85, Me.GridColumn86, Me.GridColumn87, Me.GridColumn88, Me.GridColumn89, Me.GridColumn90, Me.GridColumn91, Me.GridColumn92, Me.GridColumn93, Me.GridColumn94, Me.GridColumn95, Me.GridColumn96, Me.GridColumn97, Me.GridColumn98, Me.GridColumn99, Me.GridColumn100, Me.GridColumn101, Me.GridColumn102, Me.GridColumn103, Me.GridColumn104, Me.GridColumn105, Me.GridColumn106, Me.GridColumn107, Me.GridColumn108, Me.GridColumn109, Me.GridColumn110, Me.GridColumn111, Me.GridColumn112, Me.GridColumn113, Me.GridColumn114, Me.GridColumn115, Me.GridColumn116, Me.GridColumn117, Me.GridColumn118, Me.GridColumn119, Me.GridColumn120, Me.GridColumn121})
        Me.GridDelegheSenzaQuoteView.GridControl = Me.GridDelegheSenzaQuote
        Me.GridDelegheSenzaQuoteView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "TipoDocumento", Nothing, "")})
        Me.GridDelegheSenzaQuoteView.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridDelegheSenzaQuoteView.Name = "GridDelegheSenzaQuoteView"
        Me.GridDelegheSenzaQuoteView.OptionsBehavior.Editable = False
        Me.GridDelegheSenzaQuoteView.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridDelegheSenzaQuoteView.OptionsMenu.ShowGroupSummaryEditorItem = True
        Me.GridDelegheSenzaQuoteView.OptionsSelection.MultiSelect = True
        Me.GridDelegheSenzaQuoteView.OptionsView.ShowDetailButtons = False
        Me.GridDelegheSenzaQuoteView.OptionsView.ShowFooter = True
        Me.GridDelegheSenzaQuoteView.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'GridColumn81
        '
        Me.GridColumn81.FieldName = "Utente"
        Me.GridColumn81.Name = "GridColumn81"
        Me.GridColumn81.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GridColumn81.Visible = True
        Me.GridColumn81.VisibleIndex = 0
        '
        'GridColumn82
        '
        Me.GridColumn82.FieldName = "Settore"
        Me.GridColumn82.Name = "GridColumn82"
        Me.GridColumn82.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GridColumn82.Visible = True
        Me.GridColumn82.VisibleIndex = 1
        '
        'GridColumn83
        '
        Me.GridColumn83.FieldName = "StatoDelega"
        Me.GridColumn83.Name = "GridColumn83"
        Me.GridColumn83.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.GridColumn83.Visible = True
        Me.GridColumn83.VisibleIndex = 2
        '
        'GridColumn84
        '
        Me.GridColumn84.FieldName = "DataDocumento"
        Me.GridColumn84.Name = "GridColumn84"
        Me.GridColumn84.Visible = True
        Me.GridColumn84.VisibleIndex = 3
        '
        'GridColumn85
        '
        Me.GridColumn85.FieldName = "MailAzienda"
        Me.GridColumn85.Name = "GridColumn85"
        '
        'GridColumn86
        '
        Me.GridColumn86.FieldName = "ProvinciaAzienda"
        Me.GridColumn86.Name = "GridColumn86"
        Me.GridColumn86.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'GridColumn87
        '
        Me.GridColumn87.FieldName = "ComuneAzienda"
        Me.GridColumn87.Name = "GridColumn87"
        Me.GridColumn87.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'GridColumn88
        '
        Me.GridColumn88.FieldName = "IndirizzoAzienda"
        Me.GridColumn88.Name = "GridColumn88"
        '
        'GridColumn89
        '
        Me.GridColumn89.FieldName = "CapAzienda"
        Me.GridColumn89.Name = "GridColumn89"
        '
        'GridColumn90
        '
        Me.GridColumn90.FieldName = "Nome_Provincia_Nascita"
        Me.GridColumn90.Name = "GridColumn90"
        Me.GridColumn90.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'GridColumn91
        '
        Me.GridColumn91.FieldName = "Nome_Comune_Nascita"
        Me.GridColumn91.Name = "GridColumn91"
        Me.GridColumn91.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'GridColumn92
        '
        Me.GridColumn92.FieldName = "Nome_Comune"
        Me.GridColumn92.Name = "GridColumn92"
        Me.GridColumn92.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'GridColumn93
        '
        Me.GridColumn93.FieldName = "Indirizzo"
        Me.GridColumn93.Name = "GridColumn93"
        '
        'GridColumn94
        '
        Me.GridColumn94.FieldName = "Nome_Nazione"
        Me.GridColumn94.Name = "GridColumn94"
        Me.GridColumn94.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'GridColumn95
        '
        Me.GridColumn95.FieldName = "Nome_Provincia"
        Me.GridColumn95.Name = "GridColumn95"
        Me.GridColumn95.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'GridColumn96
        '
        Me.GridColumn96.FieldName = "Cap"
        Me.GridColumn96.Name = "GridColumn96"
        '
        'GridColumn97
        '
        Me.GridColumn97.FieldName = "Codice_Fiscale"
        Me.GridColumn97.Name = "GridColumn97"
        Me.GridColumn97.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'GridColumn98
        '
        Me.GridColumn98.FieldName = "DataNascita"
        Me.GridColumn98.Name = "GridColumn98"
        '
        'GridColumn99
        '
        Me.GridColumn99.FieldName = "Cognome"
        Me.GridColumn99.Name = "GridColumn99"
        '
        'GridColumn100
        '
        Me.GridColumn100.FieldName = "Nome"
        Me.GridColumn100.Name = "GridColumn100"
        '
        'GridColumn101
        '
        Me.GridColumn101.FieldName = "Contratto"
        Me.GridColumn101.Name = "GridColumn101"
        Me.GridColumn101.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'GridColumn102
        '
        Me.GridColumn102.FieldName = "IdContratto"
        Me.GridColumn102.Name = "GridColumn102"
        '
        'GridColumn103
        '
        Me.GridColumn103.FieldName = "Cellulare1"
        Me.GridColumn103.Name = "GridColumn103"
        '
        'GridColumn104
        '
        Me.GridColumn104.FieldName = "Cellulare2"
        Me.GridColumn104.Name = "GridColumn104"
        '
        'GridColumn105
        '
        Me.GridColumn105.FieldName = "CausaleSottoscrizione"
        Me.GridColumn105.Name = "GridColumn105"
        Me.GridColumn105.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'GridColumn106
        '
        Me.GridColumn106.FieldName = "Reparto"
        Me.GridColumn106.Name = "GridColumn106"
        '
        'GridColumn107
        '
        Me.GridColumn107.FieldName = "CausaleFineCiclo"
        Me.GridColumn107.Name = "GridColumn107"
        Me.GridColumn107.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'GridColumn108
        '
        Me.GridColumn108.FieldName = "EnteInoltro"
        Me.GridColumn108.Name = "GridColumn108"
        Me.GridColumn108.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'GridColumn109
        '
        Me.GridColumn109.FieldName = "Note"
        Me.GridColumn109.Name = "GridColumn109"
        '
        'GridColumn110
        '
        Me.GridColumn110.FieldName = "DataRegistrazione"
        Me.GridColumn110.Name = "GridColumn110"
        '
        'GridColumn111
        '
        Me.GridColumn111.FieldName = "IdUtente"
        Me.GridColumn111.Name = "GridColumn111"
        '
        'GridColumn112
        '
        Me.GridColumn112.FieldName = "Referente"
        Me.GridColumn112.Name = "GridColumn112"
        Me.GridColumn112.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'GridColumn113
        '
        Me.GridColumn113.FieldName = "IdReferente"
        Me.GridColumn113.Name = "GridColumn113"
        '
        'GridColumn114
        '
        Me.GridColumn114.FieldName = "DataInoltro"
        Me.GridColumn114.Name = "GridColumn114"
        '
        'GridColumn115
        '
        Me.GridColumn115.FieldName = "DataAccettazioneDelega"
        Me.GridColumn115.Name = "GridColumn115"
        '
        'GridColumn116
        '
        Me.GridColumn116.FieldName = "DataDecorrenzaDelega"
        Me.GridColumn116.Name = "GridColumn116"
        '
        'GridColumn117
        '
        Me.GridColumn117.FieldName = "DataAnnullamentoDelega"
        Me.GridColumn117.Name = "GridColumn117"
        '
        'GridColumn118
        '
        Me.GridColumn118.FieldName = "DataRevocaDelega"
        Me.GridColumn118.Name = "GridColumn118"
        '
        'GridColumn119
        '
        Me.GridColumn119.FieldName = "SedeOperativa"
        Me.GridColumn119.Name = "GridColumn119"
        '
        'GridColumn120
        '
        Me.GridColumn120.FieldName = "Responsabile"
        Me.GridColumn120.Name = "GridColumn120"
        '
        'GridColumn121
        '
        Me.GridColumn121.FieldName = "Id"
        Me.GridColumn121.Name = "GridColumn121"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GridQuoteConDelega)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(722, 271)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Quote con delega"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'GridQuoteConDelega
        '
        Me.GridQuoteConDelega.DataSource = Me.QuotaBindingSource
        Me.GridQuoteConDelega.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridQuoteConDelega.Location = New System.Drawing.Point(3, 3)
        Me.GridQuoteConDelega.MainView = Me.GridQuoteConDelegaView
        Me.GridQuoteConDelega.Name = "GridQuoteConDelega"
        Me.GridQuoteConDelega.Size = New System.Drawing.Size(716, 265)
        Me.GridQuoteConDelega.TabIndex = 111
        Me.GridQuoteConDelega.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridQuoteConDelegaView})
        '
        'GridQuoteConDelegaView
        '
        Me.GridQuoteConDelegaView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn47, Me.GridColumn48, Me.GridColumn49, Me.GridColumn50, Me.GridColumn51, Me.GridColumn52, Me.GridColumn53, Me.GridColumn54, Me.GridColumn55, Me.GridColumn56, Me.GridColumn57, Me.GridColumn58, Me.GridColumn59, Me.GridColumn60, Me.GridColumn61, Me.GridColumn62, Me.GridColumn63, Me.GridColumn64, Me.GridColumn65, Me.GridColumn66, Me.GridColumn67, Me.GridColumn68, Me.GridColumn69, Me.GridColumn70, Me.GridColumn71, Me.GridColumn72, Me.GridColumn73, Me.GridColumn74, Me.GridColumn75, Me.GridColumn76, Me.GridColumn77, Me.GridColumn78, Me.GridColumn79, Me.GridColumn80})
        Me.GridQuoteConDelegaView.GridControl = Me.GridQuoteConDelega
        Me.GridQuoteConDelegaView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "TipoDocumento", Nothing, "")})
        Me.GridQuoteConDelegaView.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridQuoteConDelegaView.Name = "GridQuoteConDelegaView"
        Me.GridQuoteConDelegaView.OptionsBehavior.Editable = False
        Me.GridQuoteConDelegaView.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridQuoteConDelegaView.OptionsMenu.ShowGroupSummaryEditorItem = True
        Me.GridQuoteConDelegaView.OptionsSelection.MultiSelect = True
        Me.GridQuoteConDelegaView.OptionsView.ShowDetailButtons = False
        Me.GridQuoteConDelegaView.OptionsView.ShowFooter = True
        Me.GridQuoteConDelegaView.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'GridColumn47
        '
        Me.GridColumn47.Caption = "Utente"
        Me.GridColumn47.FieldName = "Utente"
        Me.GridColumn47.Name = "GridColumn47"
        Me.GridColumn47.Visible = True
        Me.GridColumn47.VisibleIndex = 0
        '
        'GridColumn48
        '
        Me.GridColumn48.FieldName = "DataDocumento"
        Me.GridColumn48.Name = "GridColumn48"
        Me.GridColumn48.Visible = True
        Me.GridColumn48.VisibleIndex = 1
        '
        'GridColumn49
        '
        Me.GridColumn49.FieldName = "TipoDocumento"
        Me.GridColumn49.Name = "GridColumn49"
        Me.GridColumn49.Visible = True
        Me.GridColumn49.VisibleIndex = 2
        '
        'GridColumn50
        '
        Me.GridColumn50.FieldName = "Importo"
        Me.GridColumn50.Name = "GridColumn50"
        Me.GridColumn50.Visible = True
        Me.GridColumn50.VisibleIndex = 3
        '
        'GridColumn51
        '
        Me.GridColumn51.FieldName = "Competenza"
        Me.GridColumn51.Name = "GridColumn51"
        Me.GridColumn51.Visible = True
        Me.GridColumn51.VisibleIndex = 4
        '
        'GridColumn52
        '
        Me.GridColumn52.Caption = "Provincia di nascita"
        Me.GridColumn52.FieldName = "ProvinciaNascita"
        Me.GridColumn52.Name = "GridColumn52"
        '
        'GridColumn53
        '
        Me.GridColumn53.Caption = "Comune di nascita"
        Me.GridColumn53.FieldName = "ComuneNascita"
        Me.GridColumn53.Name = "GridColumn53"
        '
        'GridColumn54
        '
        Me.GridColumn54.Caption = "Provincia"
        Me.GridColumn54.FieldName = "Provincia"
        Me.GridColumn54.Name = "GridColumn54"
        '
        'GridColumn55
        '
        Me.GridColumn55.Caption = "Comune"
        Me.GridColumn55.FieldName = "Comune"
        Me.GridColumn55.Name = "GridColumn55"
        '
        'GridColumn56
        '
        Me.GridColumn56.Caption = "Cap"
        Me.GridColumn56.FieldName = "Cap"
        Me.GridColumn56.Name = "GridColumn56"
        '
        'GridColumn57
        '
        Me.GridColumn57.Caption = "Indirizzo"
        Me.GridColumn57.FieldName = "Indirizzo"
        Me.GridColumn57.Name = "GridColumn57"
        '
        'GridColumn58
        '
        Me.GridColumn58.Caption = "Cognome"
        Me.GridColumn58.FieldName = "Cognome"
        Me.GridColumn58.Name = "GridColumn58"
        '
        'GridColumn59
        '
        Me.GridColumn59.Caption = "Nome"
        Me.GridColumn59.FieldName = "Nome"
        Me.GridColumn59.Name = "GridColumn59"
        '
        'GridColumn60
        '
        Me.GridColumn60.Caption = "Data nascita"
        Me.GridColumn60.FieldName = "DataNascita"
        Me.GridColumn60.Name = "GridColumn60"
        '
        'GridColumn61
        '
        Me.GridColumn61.Caption = "Codice fiscale"
        Me.GridColumn61.FieldName = "CodiceFiscale"
        Me.GridColumn61.Name = "GridColumn61"
        '
        'GridColumn62
        '
        Me.GridColumn62.Caption = "Tipo prestazione"
        Me.GridColumn62.FieldName = "TipoPrestazione"
        Me.GridColumn62.Name = "GridColumn62"
        '
        'GridColumn63
        '
        Me.GridColumn63.Caption = "Azienda"
        Me.GridColumn63.FieldName = "SoggettoEsecutore"
        Me.GridColumn63.Name = "GridColumn63"
        '
        'GridColumn64
        '
        Me.GridColumn64.FieldName = "DocumentoPadre"
        Me.GridColumn64.Name = "GridColumn64"
        '
        'GridColumn65
        '
        Me.GridColumn65.Caption = "Settore"
        Me.GridColumn65.FieldName = "Settore"
        Me.GridColumn65.Name = "GridColumn65"
        '
        'GridColumn66
        '
        Me.GridColumn66.FieldName = "ImportoRistorno"
        Me.GridColumn66.Name = "GridColumn66"
        '
        'GridColumn67
        '
        Me.GridColumn67.FieldName = "PagamentoReferente"
        Me.GridColumn67.Name = "GridColumn67"
        '
        'GridColumn68
        '
        Me.GridColumn68.FieldName = "AziendaImpiego"
        Me.GridColumn68.Name = "GridColumn68"
        '
        'GridColumn69
        '
        Me.GridColumn69.FieldName = "ContrattoApplicato"
        Me.GridColumn69.Name = "GridColumn69"
        '
        'GridColumn70
        '
        Me.GridColumn70.FieldName = "LivelloInquadramento"
        Me.GridColumn70.Name = "GridColumn70"
        '
        'GridColumn71
        '
        Me.GridColumn71.FieldName = "OreLavorate"
        Me.GridColumn71.Name = "GridColumn71"
        '
        'GridColumn72
        '
        Me.GridColumn72.FieldName = "OreMalattia"
        Me.GridColumn72.Name = "GridColumn72"
        '
        'GridColumn73
        '
        Me.GridColumn73.FieldName = "Referente"
        Me.GridColumn73.Name = "GridColumn73"
        '
        'GridColumn74
        '
        Me.GridColumn74.FieldName = "Tredicesima"
        Me.GridColumn74.Name = "GridColumn74"
        '
        'GridColumn75
        '
        Me.GridColumn75.FieldName = "Quattordicesima"
        Me.GridColumn75.Name = "GridColumn75"
        '
        'GridColumn76
        '
        Me.GridColumn76.FieldName = "DataRegistrazione"
        Me.GridColumn76.Name = "GridColumn76"
        '
        'GridColumn77
        '
        Me.GridColumn77.FieldName = "Note"
        Me.GridColumn77.Name = "GridColumn77"
        '
        'GridColumn78
        '
        Me.GridColumn78.FieldName = "SedeOperativa"
        Me.GridColumn78.Name = "GridColumn78"
        '
        'GridColumn79
        '
        Me.GridColumn79.FieldName = "Coperto"
        Me.GridColumn79.Name = "GridColumn79"
        Me.GridColumn79.Visible = True
        Me.GridColumn79.VisibleIndex = 5
        '
        'GridColumn80
        '
        Me.GridColumn80.FieldName = "Scoperto"
        Me.GridColumn80.Name = "GridColumn80"
        Me.GridColumn80.Visible = True
        Me.GridColumn80.VisibleIndex = 6
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.GridQuoteSenzaDelega)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(722, 271)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Quote senza delega"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'GridQuoteSenzaDelega
        '
        Me.GridQuoteSenzaDelega.DataSource = Me.QuotaBindingSource
        Me.GridQuoteSenzaDelega.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridQuoteSenzaDelega.Location = New System.Drawing.Point(3, 3)
        Me.GridQuoteSenzaDelega.MainView = Me.GridQuoteSenzaDelegaView
        Me.GridQuoteSenzaDelega.Name = "GridQuoteSenzaDelega"
        Me.GridQuoteSenzaDelega.Size = New System.Drawing.Size(716, 265)
        Me.GridQuoteSenzaDelega.TabIndex = 111
        Me.GridQuoteSenzaDelega.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridQuoteSenzaDelegaView})
        '
        'GridQuoteSenzaDelegaView
        '
        Me.GridQuoteSenzaDelegaView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn13, Me.GridColumn14, Me.GridColumn15, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18, Me.GridColumn19, Me.GridColumn20, Me.GridColumn21, Me.GridColumn22, Me.GridColumn23, Me.GridColumn24, Me.GridColumn25, Me.GridColumn26, Me.GridColumn27, Me.GridColumn28, Me.GridColumn29, Me.GridColumn30, Me.GridColumn31, Me.GridColumn32, Me.GridColumn33, Me.GridColumn34, Me.GridColumn35, Me.GridColumn36, Me.GridColumn37, Me.GridColumn38, Me.GridColumn39, Me.GridColumn40, Me.GridColumn41, Me.GridColumn42, Me.GridColumn43, Me.GridColumn44, Me.GridColumn45, Me.GridColumn46})
        Me.GridQuoteSenzaDelegaView.GridControl = Me.GridQuoteSenzaDelega
        Me.GridQuoteSenzaDelegaView.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "TipoDocumento", Nothing, "")})
        Me.GridQuoteSenzaDelegaView.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridQuoteSenzaDelegaView.Name = "GridQuoteSenzaDelegaView"
        Me.GridQuoteSenzaDelegaView.OptionsBehavior.Editable = False
        Me.GridQuoteSenzaDelegaView.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridQuoteSenzaDelegaView.OptionsMenu.ShowGroupSummaryEditorItem = True
        Me.GridQuoteSenzaDelegaView.OptionsSelection.MultiSelect = True
        Me.GridQuoteSenzaDelegaView.OptionsView.ShowDetailButtons = False
        Me.GridQuoteSenzaDelegaView.OptionsView.ShowFooter = True
        Me.GridQuoteSenzaDelegaView.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Utente"
        Me.GridColumn13.FieldName = "Utente"
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 0
        '
        'GridColumn14
        '
        Me.GridColumn14.FieldName = "DataDocumento"
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 1
        '
        'GridColumn15
        '
        Me.GridColumn15.FieldName = "TipoDocumento"
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 2
        '
        'GridColumn16
        '
        Me.GridColumn16.FieldName = "Importo"
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 3
        '
        'GridColumn17
        '
        Me.GridColumn17.FieldName = "Competenza"
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 4
        '
        'GridColumn18
        '
        Me.GridColumn18.Caption = "Provincia di nascita"
        Me.GridColumn18.FieldName = "ProvinciaNascita"
        Me.GridColumn18.Name = "GridColumn18"
        '
        'GridColumn19
        '
        Me.GridColumn19.Caption = "Comune di nascita"
        Me.GridColumn19.FieldName = "ComuneNascita"
        Me.GridColumn19.Name = "GridColumn19"
        '
        'GridColumn20
        '
        Me.GridColumn20.Caption = "Provincia"
        Me.GridColumn20.FieldName = "Provincia"
        Me.GridColumn20.Name = "GridColumn20"
        '
        'GridColumn21
        '
        Me.GridColumn21.Caption = "Comune"
        Me.GridColumn21.FieldName = "Comune"
        Me.GridColumn21.Name = "GridColumn21"
        '
        'GridColumn22
        '
        Me.GridColumn22.Caption = "Cap"
        Me.GridColumn22.FieldName = "Cap"
        Me.GridColumn22.Name = "GridColumn22"
        '
        'GridColumn23
        '
        Me.GridColumn23.Caption = "Indirizzo"
        Me.GridColumn23.FieldName = "Indirizzo"
        Me.GridColumn23.Name = "GridColumn23"
        '
        'GridColumn24
        '
        Me.GridColumn24.Caption = "Cognome"
        Me.GridColumn24.FieldName = "Cognome"
        Me.GridColumn24.Name = "GridColumn24"
        '
        'GridColumn25
        '
        Me.GridColumn25.Caption = "Nome"
        Me.GridColumn25.FieldName = "Nome"
        Me.GridColumn25.Name = "GridColumn25"
        '
        'GridColumn26
        '
        Me.GridColumn26.Caption = "Data nascita"
        Me.GridColumn26.FieldName = "DataNascita"
        Me.GridColumn26.Name = "GridColumn26"
        '
        'GridColumn27
        '
        Me.GridColumn27.Caption = "Codice fiscale"
        Me.GridColumn27.FieldName = "CodiceFiscale"
        Me.GridColumn27.Name = "GridColumn27"
        '
        'GridColumn28
        '
        Me.GridColumn28.Caption = "Tipo prestazione"
        Me.GridColumn28.FieldName = "TipoPrestazione"
        Me.GridColumn28.Name = "GridColumn28"
        '
        'GridColumn29
        '
        Me.GridColumn29.Caption = "Azienda"
        Me.GridColumn29.FieldName = "SoggettoEsecutore"
        Me.GridColumn29.Name = "GridColumn29"
        '
        'GridColumn30
        '
        Me.GridColumn30.FieldName = "DocumentoPadre"
        Me.GridColumn30.Name = "GridColumn30"
        '
        'GridColumn31
        '
        Me.GridColumn31.Caption = "Settore"
        Me.GridColumn31.FieldName = "Settore"
        Me.GridColumn31.Name = "GridColumn31"
        '
        'GridColumn32
        '
        Me.GridColumn32.FieldName = "ImportoRistorno"
        Me.GridColumn32.Name = "GridColumn32"
        '
        'GridColumn33
        '
        Me.GridColumn33.FieldName = "PagamentoReferente"
        Me.GridColumn33.Name = "GridColumn33"
        '
        'GridColumn34
        '
        Me.GridColumn34.FieldName = "AziendaImpiego"
        Me.GridColumn34.Name = "GridColumn34"
        '
        'GridColumn35
        '
        Me.GridColumn35.FieldName = "ContrattoApplicato"
        Me.GridColumn35.Name = "GridColumn35"
        '
        'GridColumn36
        '
        Me.GridColumn36.FieldName = "LivelloInquadramento"
        Me.GridColumn36.Name = "GridColumn36"
        '
        'GridColumn37
        '
        Me.GridColumn37.FieldName = "OreLavorate"
        Me.GridColumn37.Name = "GridColumn37"
        '
        'GridColumn38
        '
        Me.GridColumn38.FieldName = "OreMalattia"
        Me.GridColumn38.Name = "GridColumn38"
        '
        'GridColumn39
        '
        Me.GridColumn39.FieldName = "Referente"
        Me.GridColumn39.Name = "GridColumn39"
        '
        'GridColumn40
        '
        Me.GridColumn40.FieldName = "Tredicesima"
        Me.GridColumn40.Name = "GridColumn40"
        '
        'GridColumn41
        '
        Me.GridColumn41.FieldName = "Quattordicesima"
        Me.GridColumn41.Name = "GridColumn41"
        '
        'GridColumn42
        '
        Me.GridColumn42.FieldName = "DataRegistrazione"
        Me.GridColumn42.Name = "GridColumn42"
        '
        'GridColumn43
        '
        Me.GridColumn43.FieldName = "Note"
        Me.GridColumn43.Name = "GridColumn43"
        '
        'GridColumn44
        '
        Me.GridColumn44.FieldName = "SedeOperativa"
        Me.GridColumn44.Name = "GridColumn44"
        '
        'GridColumn45
        '
        Me.GridColumn45.FieldName = "Coperto"
        Me.GridColumn45.Name = "GridColumn45"
        Me.GridColumn45.Visible = True
        Me.GridColumn45.VisibleIndex = 5
        '
        'GridColumn46
        '
        Me.GridColumn46.FieldName = "Scoperto"
        Me.GridColumn46.Name = "GridColumn46"
        Me.GridColumn46.Visible = True
        Me.GridColumn46.VisibleIndex = 6
        '
        'ReportDelegheFializzate
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "ReportDelegheFializzate"
        Me.Size = New System.Drawing.Size(756, 651)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.DockPanel, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        Me.DockPanel.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.GridDeleghe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridDelegheView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DelegadTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.GridQuote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuotaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridQuoteView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.GridDelegheSenzaQuote, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridDelegheSenzaQuoteView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.GridQuoteConDelega, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridQuoteConDelegaView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        CType(Me.GridQuoteSenzaDelega, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridQuoteSenzaDelegaView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents spview As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents cmdPrint As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents cmdListaLavoro As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents GroupBox2 As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents lblEnte As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lblCausaleSott As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblNum As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblRev As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblAnn As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblAtt As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblAcc As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblInol As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lblSott As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lblRevRange As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents lblAnnRange As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblAttRange As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lblAccRange As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblInRange As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblReferente As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents lblSettore As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents lblRegRange As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GridDeleghe As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridDelegheView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colUtente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSettore As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStatoDelega As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataDocumento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMailAzienda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProvinciaAzienda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComuneAzienda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIndirizzoAzienda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCapAzienda As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents colIdContratto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCellulare1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCellulare2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCausaleSottoscrizione As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReparto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCausaleFineCiclo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colEnteInoltro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataRegistrazione As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdUtente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReferente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdReferente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataInoltro As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataAccettazioneDelega As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataDecorrenzaDelega As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataAnnullamentoDelega As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataRevocaDelega As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSedeOperativa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colResponsabile As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents DelegadTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents QuotaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridQuote As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridQuoteView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoDocumento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImporto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompetenza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProvinciaNascita As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComuneNascita As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProvincia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComune As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodiceFiscale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoPrestazione As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSoggettoEsecutore As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDocumentoPadre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImportoRistorno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPagamentoReferente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAziendaImpiego As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContrattoApplicato As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLivelloInquadramento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOreLavorate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOreMalattia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTredicesima As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuattordicesima As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCoperto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colScoperto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridDelegheSenzaQuote As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridDelegheSenzaQuoteView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn81 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn82 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn83 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn84 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn85 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn86 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn87 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn88 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn89 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn90 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn91 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn92 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn93 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn94 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn95 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn96 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn97 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn98 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn99 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn100 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn101 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn102 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn103 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn104 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn105 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn106 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn107 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn108 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn109 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn110 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn111 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn112 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn113 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn114 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn115 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn116 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn117 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn118 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn119 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn120 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn121 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridQuoteConDelega As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridQuoteConDelegaView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn47 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn48 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn49 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn51 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn52 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn53 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn54 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn55 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn56 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn57 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn58 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn59 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn60 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn61 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn62 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn63 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn64 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn65 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn66 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn67 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn68 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn69 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn70 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn71 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn72 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn73 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn74 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn75 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn76 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn77 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn78 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn79 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn80 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridQuoteSenzaDelega As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridQuoteSenzaDelegaView As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn18 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn26 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn27 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn28 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn29 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn30 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn31 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn32 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn33 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn34 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn35 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn36 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn37 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn38 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn39 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn40 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn41 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn42 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn43 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn44 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn45 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn46 As DevExpress.XtraGrid.Columns.GridColumn

End Class
