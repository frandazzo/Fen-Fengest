<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportPratiche
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
        Me.cmdListaLavoro = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.cmdPrint = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.GridPosizioni = New DevExpress.XtraGrid.GridControl()
        Me.PraticaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colPraticaDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNomeTipoPratica = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNomeUtente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colStateName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGetStateOperator = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGetOwnerOperator = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colGetStateNote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNotes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDurataPratica = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataFine = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.DockPanel.SuspendLayout()
        CType(Me.GridPosizioni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PraticaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DockPanel
        '
        Me.DockPanel.Controls.Add(Me.cmdListaLavoro)
        Me.DockPanel.Controls.Add(Me.cmdPrint)
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
        Me.cmdListaLavoro.Location = New System.Drawing.Point(26, 6)
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
        Me.cmdPrint.Location = New System.Drawing.Point(72, 6)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Radius = 32.0!
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
        Me.GridPosizioni.DataSource = Me.PraticaBindingSource
        Me.GridPosizioni.Location = New System.Drawing.Point(11, 77)
        Me.GridPosizioni.MainView = Me.GridView1
        Me.GridPosizioni.Name = "GridPosizioni"
        Me.GridPosizioni.Size = New System.Drawing.Size(727, 331)
        Me.GridPosizioni.TabIndex = 111
        Me.GridPosizioni.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'PraticaBindingSource
        '
        Me.PraticaBindingSource.DataSource = GetType(WIN.DOMAIN.FED_SERVICES.Pratica)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colPraticaDate, Me.colNomeTipoPratica, Me.colNomeUtente, Me.colStateName, Me.colGetStateOperator, Me.colGetOwnerOperator, Me.colGetStateNote, Me.colNotes, Me.colId, Me.colDurataPratica, Me.colDataFine, Me.colCode, Me.colCity})
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
        'colPraticaDate
        '
        Me.colPraticaDate.Caption = "Data"
        Me.colPraticaDate.FieldName = "PraticaDate"
        Me.colPraticaDate.Name = "colPraticaDate"
        Me.colPraticaDate.Visible = True
        Me.colPraticaDate.VisibleIndex = 0
        '
        'colNomeTipoPratica
        '
        Me.colNomeTipoPratica.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colNomeTipoPratica.AppearanceCell.Options.UseFont = True
        Me.colNomeTipoPratica.Caption = "Tipo pratica"
        Me.colNomeTipoPratica.FieldName = "NomeTipoPratica"
        Me.colNomeTipoPratica.Name = "colNomeTipoPratica"
        Me.colNomeTipoPratica.OptionsColumn.ReadOnly = True
        Me.colNomeTipoPratica.Visible = True
        Me.colNomeTipoPratica.VisibleIndex = 1
        '
        'colNomeUtente
        '
        Me.colNomeUtente.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colNomeUtente.AppearanceCell.Options.UseFont = True
        Me.colNomeUtente.Caption = "Lavoratore"
        Me.colNomeUtente.FieldName = "NomeUtente"
        Me.colNomeUtente.Name = "colNomeUtente"
        Me.colNomeUtente.OptionsColumn.ReadOnly = True
        Me.colNomeUtente.Visible = True
        Me.colNomeUtente.VisibleIndex = 2
        '
        'colStateName
        '
        Me.colStateName.Caption = "Stato"
        Me.colStateName.FieldName = "StateName"
        Me.colStateName.Name = "colStateName"
        Me.colStateName.OptionsColumn.ReadOnly = True
        Me.colStateName.Visible = True
        Me.colStateName.VisibleIndex = 3
        '
        'colGetStateOperator
        '
        Me.colGetStateOperator.Caption = "In carico a"
        Me.colGetStateOperator.FieldName = "GetStateOperator"
        Me.colGetStateOperator.Name = "colGetStateOperator"
        Me.colGetStateOperator.OptionsColumn.ReadOnly = True
        Me.colGetStateOperator.Visible = True
        Me.colGetStateOperator.VisibleIndex = 4
        '
        'colGetOwnerOperator
        '
        Me.colGetOwnerOperator.Caption = "Proprietario"
        Me.colGetOwnerOperator.FieldName = "GetOwnerOperator"
        Me.colGetOwnerOperator.Name = "colGetOwnerOperator"
        Me.colGetOwnerOperator.OptionsColumn.ReadOnly = True
        Me.colGetOwnerOperator.Visible = True
        Me.colGetOwnerOperator.VisibleIndex = 5
        '
        'colGetStateNote
        '
        Me.colGetStateNote.Caption = "Note aggiuntive"
        Me.colGetStateNote.FieldName = "GetStateNote"
        Me.colGetStateNote.Name = "colGetStateNote"
        Me.colGetStateNote.OptionsColumn.ReadOnly = True
        '
        'colNotes
        '
        Me.colNotes.Caption = "Note"
        Me.colNotes.FieldName = "Notes"
        Me.colNotes.Name = "colNotes"
        '
        'colId
        '
        Me.colId.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colId.AppearanceCell.Options.UseFont = True
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        Me.colId.Visible = True
        Me.colId.VisibleIndex = 6
        '
        'colDurataPratica
        '
        Me.colDurataPratica.FieldName = "DurataPratica"
        Me.colDurataPratica.Name = "colDurataPratica"
        Me.colDurataPratica.Visible = True
        Me.colDurataPratica.VisibleIndex = 7
        '
        'colDataFine
        '
        Me.colDataFine.FieldName = "DataFine"
        Me.colDataFine.Name = "colDataFine"
        Me.colDataFine.Visible = True
        Me.colDataFine.VisibleIndex = 8
        '
        'colCode
        '
        Me.colCode.Caption = "Codice ITAL"
        Me.colCode.FieldName = "Code"
        Me.colCode.Name = "colCode"
        Me.colCode.Visible = True
        Me.colCode.VisibleIndex = 9
        '
        'colCity
        '
        Me.colCity.Caption = "Città APE"
        Me.colCity.FieldName = "City"
        Me.colCity.Name = "colCity"
        Me.colCity.Visible = True
        Me.colCity.VisibleIndex = 10
        '
        'ReportPratiche
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.GridPosizioni)
        Me.Name = "ReportPratiche"
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.DockPanel, 0)
        Me.Controls.SetChildIndex(Me.GridPosizioni, 0)
        Me.DockPanel.ResumeLayout(False)
        CType(Me.GridPosizioni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PraticaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdListaLavoro As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents cmdPrint As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents GridPosizioni As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PraticaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colPraticaDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNomeTipoPratica As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNomeUtente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colStateName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGetStateOperator As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGetOwnerOperator As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colGetStateNote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNotes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDurataPratica As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataFine As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCity As DevExpress.XtraGrid.Columns.GridColumn

End Class
