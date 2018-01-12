<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportDocumenti
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
        Me.cmdListaLavoro = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.cmdPrint = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.GroupBox2 = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.lblTipoDocumento = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblReferente = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblCompetenza = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GridPosizioni = New DevExpress.XtraGrid.GridControl()
        Me.ElectronicDocumentDTOBindingSource = New System.Windows.Forms.BindingSource()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colOwnerId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDescrizione = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFiscal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDocumentId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDocumentType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colData = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExecutorId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colExecutedBy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFileName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DockPanel.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridPosizioni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElectronicDocumentDTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Size = New System.Drawing.Size(833, 30)
        '
        'DockPanel
        '
        Me.DockPanel.Controls.Add(Me.cmdListaLavoro)
        Me.DockPanel.Controls.Add(Me.cmdPrint)
        Me.DockPanel.Size = New System.Drawing.Size(833, 44)
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
        Me.cmdListaLavoro.Location = New System.Drawing.Point(18, 6)
        Me.cmdListaLavoro.Name = "cmdListaLavoro"
        Me.cmdListaLavoro.Radius = 32.0!
        Me.cmdListaLavoro.ShowTooltip = True
        Me.cmdListaLavoro.Size = New System.Drawing.Size(32, 32)
        Me.cmdListaLavoro.TabIndex = 119
        Me.cmdListaLavoro.TextValue = ""
        Me.cmdListaLavoro.TooltipText = "Crea lista di lavoro utenti"
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
        Me.cmdPrint.Location = New System.Drawing.Point(64, 6)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Radius = 32.0!
        Me.cmdPrint.ShowTooltip = True
        Me.cmdPrint.Size = New System.Drawing.Size(32, 32)
        Me.cmdPrint.TabIndex = 118
        Me.cmdPrint.TextValue = ""
        Me.cmdPrint.TooltipText = "Stampa report"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.lblTipoDocumento)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.lblReferente)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.lblCompetenza)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.lblTipo)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.lblData)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(18, 89)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(804, 77)
        Me.GroupBox2.TabIndex = 108
        Me.GroupBox2.Text = "Dati report"
        Me.GroupBox2.Title = "Dati report"
        '
        'lblTipoDocumento
        '
        Me.lblTipoDocumento.AutoSize = True
        Me.lblTipoDocumento.Location = New System.Drawing.Point(421, 21)
        Me.lblTipoDocumento.Name = "lblTipoDocumento"
        Me.lblTipoDocumento.Size = New System.Drawing.Size(11, 13)
        Me.lblTipoDocumento.TabIndex = 98
        Me.lblTipoDocumento.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(367, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 97
        Me.Label3.Text = "Tipi doc:"
        '
        'lblReferente
        '
        Me.lblReferente.AutoSize = True
        Me.lblReferente.Location = New System.Drawing.Point(262, 47)
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
        Me.Label22.Location = New System.Drawing.Point(179, 47)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(78, 13)
        Me.Label22.TabIndex = 95
        Me.Label22.Text = "Coollaboratore:"
        '
        'lblCompetenza
        '
        Me.lblCompetenza.AutoSize = True
        Me.lblCompetenza.Location = New System.Drawing.Point(231, 21)
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
        Me.Label21.Location = New System.Drawing.Point(179, 21)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(46, 13)
        Me.Label21.TabIndex = 85
        Me.Label21.Text = "Periodo:"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(63, 47)
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
        Me.Label16.Location = New System.Drawing.Point(6, 47)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(61, 13)
        Me.Label16.TabIndex = 79
        Me.Label16.Text = "Tipo report:"
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
        'GridPosizioni
        '
        Me.GridPosizioni.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridPosizioni.DataSource = Me.ElectronicDocumentDTOBindingSource
        Me.GridPosizioni.Location = New System.Drawing.Point(18, 177)
        Me.GridPosizioni.MainView = Me.GridView1
        Me.GridPosizioni.Name = "GridPosizioni"
        Me.GridPosizioni.Size = New System.Drawing.Size(804, 331)
        Me.GridPosizioni.TabIndex = 110
        Me.GridPosizioni.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ElectronicDocumentDTOBindingSource
        '
        Me.ElectronicDocumentDTOBindingSource.DataSource = GetType(WIN.DOMAIN.FEDERATIONARTIFACTS.ElectronicDocumentDTO)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOwnerId, Me.colDescrizione, Me.colFiscal, Me.colDocumentId, Me.colDocumentType, Me.colData, Me.colExecutorId, Me.colExecutedBy, Me.colFileName, Me.colNotes})
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
        'colOwnerId
        '
        Me.colOwnerId.Caption = "Id proprietario"
        Me.colOwnerId.FieldName = "OwnerId"
        Me.colOwnerId.Name = "colOwnerId"
        '
        'colDescrizione
        '
        Me.colDescrizione.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline)
        Me.colDescrizione.AppearanceCell.Options.UseFont = True
        Me.colDescrizione.Caption = "Proprietario"
        Me.colDescrizione.FieldName = "Descrizione"
        Me.colDescrizione.Name = "colDescrizione"
        Me.colDescrizione.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colDescrizione.Visible = True
        Me.colDescrizione.VisibleIndex = 0
        '
        'colFiscal
        '
        Me.colFiscal.Caption = "Codice fiscale o partita iva"
        Me.colFiscal.FieldName = "Fiscal"
        Me.colFiscal.Name = "colFiscal"
        '
        'colDocumentId
        '
        Me.colDocumentId.Caption = "Id tipo documento"
        Me.colDocumentId.FieldName = "DocumentId"
        Me.colDocumentId.Name = "colDocumentId"
        '
        'colDocumentType
        '
        Me.colDocumentType.Caption = "Tipo documento"
        Me.colDocumentType.FieldName = "DocumentType"
        Me.colDocumentType.Name = "colDocumentType"
        Me.colDocumentType.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colDocumentType.Visible = True
        Me.colDocumentType.VisibleIndex = 1
        '
        'colData
        '
        Me.colData.Caption = "Data"
        Me.colData.FieldName = "Data"
        Me.colData.Name = "colData"
        Me.colData.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.DateSmart
        Me.colData.Visible = True
        Me.colData.VisibleIndex = 2
        '
        'colExecutorId
        '
        Me.colExecutorId.Caption = "Id collaboratore"
        Me.colExecutorId.FieldName = "ExecutorId"
        Me.colExecutorId.Name = "colExecutorId"
        '
        'colExecutedBy
        '
        Me.colExecutedBy.Caption = "Collaboratore"
        Me.colExecutedBy.FieldName = "ExecutedBy"
        Me.colExecutedBy.Name = "colExecutedBy"
        Me.colExecutedBy.Visible = True
        Me.colExecutedBy.VisibleIndex = 3
        '
        'colFileName
        '
        Me.colFileName.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline)
        Me.colFileName.AppearanceCell.Options.UseFont = True
        Me.colFileName.Caption = "File"
        Me.colFileName.FieldName = "FileName"
        Me.colFileName.Name = "colFileName"
        Me.colFileName.Visible = True
        Me.colFileName.VisibleIndex = 4
        '
        'colNotes
        '
        Me.colNotes.Caption = "Note"
        Me.colNotes.FieldName = "Notes"
        Me.colNotes.Name = "colNotes"
        '
        'ReportDocumenti
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.GridPosizioni)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "ReportDocumenti"
        Me.Size = New System.Drawing.Size(833, 525)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.DockPanel, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.GridPosizioni, 0)
        Me.DockPanel.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.GridPosizioni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElectronicDocumentDTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdListaLavoro As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents cmdPrint As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents GroupBox2 As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents lblReferente As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents lblCompetenza As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GridPosizioni As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ElectronicDocumentDTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colOwnerId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescrizione As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFiscal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDocumentId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDocumentType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExecutorId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colExecutedBy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFileName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNotes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lblTipoDocumento As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
