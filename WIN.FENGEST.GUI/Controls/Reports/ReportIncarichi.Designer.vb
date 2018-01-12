<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportIncarichi
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
        Me.GridPosizioni = New DevExpress.XtraGrid.GridControl()
        Me.IncaricoDTOBindingSource = New System.Windows.Forms.BindingSource()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCognome = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNome = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoIncarico = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAzienda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCapAzienda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIndirizzoAzienda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProvinciaResidenza = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComuneResidenza = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProvinciaAzienda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComuneAzienda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCap = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIndirizzo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodiceFiscale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCell2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCell1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdAzienda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdUtente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GroupBox2 = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.lblAzienda = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmdListaLavoro = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.cmdPrint = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.SpecialButton1 = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.DockPanel.SuspendLayout()
        CType(Me.GridPosizioni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IncaricoDTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DockPanel
        '
        Me.DockPanel.Controls.Add(Me.SpecialButton1)
        Me.DockPanel.Controls.Add(Me.cmdListaLavoro)
        Me.DockPanel.Controls.Add(Me.cmdPrint)
        '
        'GridPosizioni
        '
        Me.GridPosizioni.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridPosizioni.DataSource = Me.IncaricoDTOBindingSource
        Me.GridPosizioni.Location = New System.Drawing.Point(16, 177)
        Me.GridPosizioni.MainView = Me.GridView1
        Me.GridPosizioni.Name = "GridPosizioni"
        Me.GridPosizioni.Size = New System.Drawing.Size(714, 214)
        Me.GridPosizioni.TabIndex = 112
        Me.GridPosizioni.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'IncaricoDTOBindingSource
        '
        Me.IncaricoDTOBindingSource.DataSource = GetType(WIN.DOMAIN.FEDERATIONARTIFACTS.IncaricoDTO)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCognome, Me.colNome, Me.colTipoIncarico, Me.colAzienda, Me.colCapAzienda, Me.colIndirizzoAzienda, Me.colProvinciaResidenza, Me.colComuneResidenza, Me.colProvinciaAzienda, Me.colComuneAzienda, Me.colCap, Me.colTel, Me.colIndirizzo, Me.colCodiceFiscale, Me.colCell2, Me.colCell1, Me.colMail, Me.colNotes, Me.colIdAzienda, Me.colIdUtente})
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
        'colCognome
        '
        Me.colCognome.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline)
        Me.colCognome.AppearanceCell.Options.UseFont = True
        Me.colCognome.FieldName = "Cognome"
        Me.colCognome.Name = "colCognome"
        Me.colCognome.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colCognome.Visible = True
        Me.colCognome.VisibleIndex = 0
        '
        'colNome
        '
        Me.colNome.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline)
        Me.colNome.AppearanceCell.Options.UseFont = True
        Me.colNome.FieldName = "Nome"
        Me.colNome.Name = "colNome"
        Me.colNome.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colNome.Visible = True
        Me.colNome.VisibleIndex = 1
        '
        'colTipoIncarico
        '
        Me.colTipoIncarico.FieldName = "TipoIncarico"
        Me.colTipoIncarico.Name = "colTipoIncarico"
        Me.colTipoIncarico.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colTipoIncarico.Visible = True
        Me.colTipoIncarico.VisibleIndex = 2
        '
        'colAzienda
        '
        Me.colAzienda.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline)
        Me.colAzienda.AppearanceCell.Options.UseFont = True
        Me.colAzienda.FieldName = "Azienda"
        Me.colAzienda.Name = "colAzienda"
        Me.colAzienda.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colAzienda.Visible = True
        Me.colAzienda.VisibleIndex = 3
        '
        'colCapAzienda
        '
        Me.colCapAzienda.FieldName = "CapAzienda"
        Me.colCapAzienda.Name = "colCapAzienda"
        Me.colCapAzienda.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colIndirizzoAzienda
        '
        Me.colIndirizzoAzienda.FieldName = "IndirizzoAzienda"
        Me.colIndirizzoAzienda.Name = "colIndirizzoAzienda"
        Me.colIndirizzoAzienda.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colProvinciaResidenza
        '
        Me.colProvinciaResidenza.FieldName = "ProvinciaResidenza"
        Me.colProvinciaResidenza.Name = "colProvinciaResidenza"
        Me.colProvinciaResidenza.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colComuneResidenza
        '
        Me.colComuneResidenza.FieldName = "ComuneResidenza"
        Me.colComuneResidenza.Name = "colComuneResidenza"
        Me.colComuneResidenza.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
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
        'colCap
        '
        Me.colCap.FieldName = "Cap"
        Me.colCap.Name = "colCap"
        Me.colCap.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colTel
        '
        Me.colTel.FieldName = "Tel"
        Me.colTel.Name = "colTel"
        Me.colTel.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colIndirizzo
        '
        Me.colIndirizzo.FieldName = "Indirizzo"
        Me.colIndirizzo.Name = "colIndirizzo"
        Me.colIndirizzo.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colCodiceFiscale
        '
        Me.colCodiceFiscale.FieldName = "CodiceFiscale"
        Me.colCodiceFiscale.Name = "colCodiceFiscale"
        Me.colCodiceFiscale.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colCell2
        '
        Me.colCell2.FieldName = "Cell2"
        Me.colCell2.Name = "colCell2"
        Me.colCell2.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colCell1
        '
        Me.colCell1.FieldName = "Cell1"
        Me.colCell1.Name = "colCell1"
        Me.colCell1.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colMail
        '
        Me.colMail.FieldName = "Mail"
        Me.colMail.Name = "colMail"
        Me.colMail.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colNotes
        '
        Me.colNotes.FieldName = "Notes"
        Me.colNotes.Name = "colNotes"
        Me.colNotes.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colIdAzienda
        '
        Me.colIdAzienda.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline)
        Me.colIdAzienda.AppearanceCell.Options.UseFont = True
        Me.colIdAzienda.FieldName = "IdAzienda"
        Me.colIdAzienda.Name = "colIdAzienda"
        Me.colIdAzienda.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colIdUtente
        '
        Me.colIdUtente.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline)
        Me.colIdUtente.AppearanceCell.Options.UseFont = True
        Me.colIdUtente.FieldName = "IdUtente"
        Me.colIdUtente.Name = "colIdUtente"
        Me.colIdUtente.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.lblAzienda)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.lblTipo)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.lblData)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(16, 94)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(714, 77)
        Me.GroupBox2.TabIndex = 111
        Me.GroupBox2.Text = "Dati report"
        Me.GroupBox2.Title = "Dati report"
        '
        'lblAzienda
        '
        Me.lblAzienda.AutoSize = True
        Me.lblAzienda.Location = New System.Drawing.Point(262, 47)
        Me.lblAzienda.MaximumSize = New System.Drawing.Size(80, 0)
        Me.lblAzienda.Name = "lblAzienda"
        Me.lblAzienda.Size = New System.Drawing.Size(52, 13)
        Me.lblAzienda.TabIndex = 96
        Me.lblAzienda.Text = "Azienda"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(179, 47)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(48, 13)
        Me.Label22.TabIndex = 95
        Me.Label22.Text = "Azienda:"
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(63, 47)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(32, 13)
        Me.lblTipo.TabIndex = 80
        Me.lblTipo.Text = "Tipo"
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
        'cmdListaLavoro
        '
        Me.cmdListaLavoro.ApplyOutLookStile = True
        Me.cmdListaLavoro.BackColor = System.Drawing.Color.Transparent
        Me.cmdListaLavoro.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.k_address_book_32x32
        Me.cmdListaLavoro.Disabled = False
        Me.cmdListaLavoro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdListaLavoro.ForeColor = System.Drawing.Color.Transparent
        Me.cmdListaLavoro.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdListaLavoro.Location = New System.Drawing.Point(17, 6)
        Me.cmdListaLavoro.Name = "cmdListaLavoro"
        Me.cmdListaLavoro.Radius = 32.0!
        Me.cmdListaLavoro.ShowTooltip = True
        Me.cmdListaLavoro.Size = New System.Drawing.Size(32, 32)
        Me.cmdListaLavoro.TabIndex = 121
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
        Me.cmdPrint.Location = New System.Drawing.Point(63, 6)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Radius = 32.0!
        Me.cmdPrint.ShowTooltip = True
        Me.cmdPrint.Size = New System.Drawing.Size(32, 32)
        Me.cmdPrint.TabIndex = 120
        Me.cmdPrint.TextValue = ""
        Me.cmdPrint.TooltipText = "Stampa report"
        '
        'SpecialButton1
        '
        Me.SpecialButton1.ApplyOutLookStile = True
        Me.SpecialButton1.BackColor = System.Drawing.Color.Transparent
        Me.SpecialButton1.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.print_address_48x48
        Me.SpecialButton1.Disabled = False
        Me.SpecialButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SpecialButton1.ForeColor = System.Drawing.Color.Transparent
        Me.SpecialButton1.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SpecialButton1.Location = New System.Drawing.Point(112, 6)
        Me.SpecialButton1.Name = "SpecialButton1"
        Me.SpecialButton1.Radius = 32.0!
        Me.SpecialButton1.ShowTooltip = True
        Me.SpecialButton1.Size = New System.Drawing.Size(32, 32)
        Me.SpecialButton1.TabIndex = 122
        Me.SpecialButton1.TextValue = ""
        Me.SpecialButton1.TooltipText = "Compila documenti"
        '
        'ReportIncarichi
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.GridPosizioni)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "ReportIncarichi"
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.DockPanel, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.GridPosizioni, 0)
        Me.DockPanel.ResumeLayout(False)
        CType(Me.GridPosizioni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IncaricoDTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridPosizioni As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GroupBox2 As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents lblAzienda As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblData As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmdListaLavoro As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents cmdPrint As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents IncaricoDTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colCognome As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoIncarico As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAzienda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCapAzienda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIndirizzoAzienda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProvinciaResidenza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComuneResidenza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProvinciaAzienda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComuneAzienda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCap As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIndirizzo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodiceFiscale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCell2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCell1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNotes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdAzienda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdUtente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SpecialButton1 As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton

End Class
