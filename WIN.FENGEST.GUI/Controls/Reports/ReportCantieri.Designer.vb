<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportCantieri
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
        Me.cmdPrint = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.CantiereBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colNomeAzienda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemHyperLinkEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.colDescrizione = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataFine = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colZona = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProvincia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComune = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImporto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdAzienda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemHyperLinkEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.cmdReportZona = New DevExpress.XtraEditors.SimpleButton()
        Me.DockPanel.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CantiereBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Size = New System.Drawing.Size(668, 30)
        '
        'DockPanel
        '
        Me.DockPanel.Controls.Add(Me.cmdReportZona)
        Me.DockPanel.Controls.Add(Me.cmdPrint)
        Me.DockPanel.Size = New System.Drawing.Size(668, 44)
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
        Me.cmdPrint.Location = New System.Drawing.Point(23, 6)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Radius = 32.0!
        Me.cmdPrint.ShowTooltip = True
        Me.cmdPrint.Size = New System.Drawing.Size(32, 32)
        Me.cmdPrint.TabIndex = 121
        Me.cmdPrint.TextValue = ""
        Me.cmdPrint.TooltipText = "Stampa report"
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataSource = Me.CantiereBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(11, 77)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemHyperLinkEdit1, Me.RepositoryItemHyperLinkEdit2})
        Me.GridControl1.Size = New System.Drawing.Size(646, 233)
        Me.GridControl1.TabIndex = 35
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'CantiereBindingSource
        '
        Me.CantiereBindingSource.DataSource = GetType(WIN.DOMAIN.FEDERATIONARTIFACTS.Cantiere)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colNomeAzienda, Me.colDescrizione, Me.colDataFine, Me.colZona, Me.colProvincia, Me.colComune, Me.colImporto, Me.colIdAzienda})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsDetail.EnableMasterViewMode = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowPreview = True
        Me.GridView1.PreviewFieldName = "Notes"
        Me.GridView1.PreviewIndent = 3
        '
        'colNomeAzienda
        '
        Me.colNomeAzienda.ColumnEdit = Me.RepositoryItemHyperLinkEdit1
        Me.colNomeAzienda.FieldName = "NomeAzienda"
        Me.colNomeAzienda.Name = "colNomeAzienda"
        Me.colNomeAzienda.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colNomeAzienda.Visible = True
        Me.colNomeAzienda.VisibleIndex = 0
        '
        'RepositoryItemHyperLinkEdit1
        '
        Me.RepositoryItemHyperLinkEdit1.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit1.Name = "RepositoryItemHyperLinkEdit1"
        '
        'colDescrizione
        '
        Me.colDescrizione.FieldName = "Descrizione"
        Me.colDescrizione.Name = "colDescrizione"
        Me.colDescrizione.Visible = True
        Me.colDescrizione.VisibleIndex = 1
        '
        'colDataFine
        '
        Me.colDataFine.FieldName = "DataFine"
        Me.colDataFine.Name = "colDataFine"
        Me.colDataFine.Visible = True
        Me.colDataFine.VisibleIndex = 2
        '
        'colZona
        '
        Me.colZona.FieldName = "Zona"
        Me.colZona.Name = "colZona"
        Me.colZona.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colZona.Visible = True
        Me.colZona.VisibleIndex = 3
        '
        'colProvincia
        '
        Me.colProvincia.FieldName = "Provincia"
        Me.colProvincia.Name = "colProvincia"
        Me.colProvincia.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colProvincia.Visible = True
        Me.colProvincia.VisibleIndex = 4
        '
        'colComune
        '
        Me.colComune.FieldName = "Comune"
        Me.colComune.Name = "colComune"
        Me.colComune.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colComune.Visible = True
        Me.colComune.VisibleIndex = 5
        '
        'colImporto
        '
        Me.colImporto.FieldName = "Importo"
        Me.colImporto.Name = "colImporto"
        Me.colImporto.Visible = True
        Me.colImporto.VisibleIndex = 6
        '
        'colIdAzienda
        '
        Me.colIdAzienda.ColumnEdit = Me.RepositoryItemHyperLinkEdit2
        Me.colIdAzienda.FieldName = "IdAzienda"
        Me.colIdAzienda.Name = "colIdAzienda"
        Me.colIdAzienda.Visible = True
        Me.colIdAzienda.VisibleIndex = 7
        '
        'RepositoryItemHyperLinkEdit2
        '
        Me.RepositoryItemHyperLinkEdit2.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit2.Name = "RepositoryItemHyperLinkEdit2"
        '
        'cmdReportZona
        '
        Me.cmdReportZona.Location = New System.Drawing.Point(84, 12)
        Me.cmdReportZona.Name = "cmdReportZona"
        Me.cmdReportZona.Size = New System.Drawing.Size(194, 23)
        Me.cmdReportZona.TabIndex = 122
        Me.cmdReportZona.Text = "Report sulle zone dei cantieri"
        '
        'ReportCantieri
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "ReportCantieri"
        Me.Size = New System.Drawing.Size(668, 313)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.DockPanel, 0)
        Me.Controls.SetChildIndex(Me.GridControl1, 0)
        Me.DockPanel.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CantiereBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdPrint As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CantiereBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RepositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents RepositoryItemHyperLinkEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents colNomeAzienda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDescrizione As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataFine As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colZona As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProvincia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComune As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImporto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdAzienda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdReportZona As DevExpress.XtraEditors.SimpleButton

End Class
