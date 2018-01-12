<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUserMessages
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GridPosizioni = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataDocumento = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNomeUtente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNomeTipoComunicazione = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNomeCausale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.ComunicazioneBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.GridPosizioni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComunicazioneBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridPosizioni
        '
        Me.GridPosizioni.DataSource = Me.ComunicazioneBindingSource
        Me.GridPosizioni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPosizioni.Location = New System.Drawing.Point(0, 0)
        Me.GridPosizioni.MainView = Me.GridView1
        Me.GridPosizioni.Name = "GridPosizioni"
        Me.GridPosizioni.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1})
        Me.GridPosizioni.Size = New System.Drawing.Size(745, 351)
        Me.GridPosizioni.TabIndex = 113
        Me.GridPosizioni.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.Preview.Options.UseTextOptions = True
        Me.GridView1.Appearance.Preview.TextOptions.Trimming = DevExpress.Utils.Trimming.None
        Me.GridView1.Appearance.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colId, Me.colDataDocumento, Me.colNomeUtente, Me.colNomeTipoComunicazione, Me.colNomeCausale, Me.colNote})
        Me.GridView1.GridControl = Me.GridPosizioni
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "TipoDocumento", Nothing, "")})
        Me.GridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridView1.OptionsMenu.ShowGroupSummaryEditorItem = True
        Me.GridView1.OptionsView.AutoCalcPreviewLineCount = True
        Me.GridView1.OptionsView.RowAutoHeight = True
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.PreviewFieldName = "Note"
        Me.GridView1.PreviewIndent = 4
        Me.GridView1.PreviewLineCount = 2
        Me.GridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'colId
        '
        Me.colId.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colId.AppearanceCell.Options.UseFont = True
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        Me.colId.Width = 25
        '
        'colDataDocumento
        '
        Me.colDataDocumento.Caption = "Data"
        Me.colDataDocumento.FieldName = "DataDocumento"
        Me.colDataDocumento.Name = "colDataDocumento"
        Me.colDataDocumento.Visible = True
        Me.colDataDocumento.VisibleIndex = 0
        Me.colDataDocumento.Width = 114
        '
        'colNomeUtente
        '
        Me.colNomeUtente.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colNomeUtente.AppearanceCell.Options.UseFont = True
        Me.colNomeUtente.FieldName = "NomeUtente"
        Me.colNomeUtente.Name = "colNomeUtente"
        Me.colNomeUtente.OptionsColumn.ReadOnly = True
        Me.colNomeUtente.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colNomeUtente.Width = 114
        '
        'colNomeTipoComunicazione
        '
        Me.colNomeTipoComunicazione.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colNomeTipoComunicazione.AppearanceCell.Options.UseFont = True
        Me.colNomeTipoComunicazione.FieldName = "NomeTipoComunicazione"
        Me.colNomeTipoComunicazione.Name = "colNomeTipoComunicazione"
        Me.colNomeTipoComunicazione.OptionsColumn.ReadOnly = True
        Me.colNomeTipoComunicazione.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colNomeTipoComunicazione.Width = 114
        '
        'colNomeCausale
        '
        Me.colNomeCausale.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colNomeCausale.AppearanceCell.Options.UseFont = True
        Me.colNomeCausale.Caption = "Causale"
        Me.colNomeCausale.FieldName = "NomeCausale"
        Me.colNomeCausale.Name = "colNomeCausale"
        Me.colNomeCausale.OptionsColumn.ReadOnly = True
        Me.colNomeCausale.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colNomeCausale.Visible = True
        Me.colNomeCausale.VisibleIndex = 1
        Me.colNomeCausale.Width = 125
        '
        'colNote
        '
        Me.colNote.Caption = "Testo SMS"
        Me.colNote.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.colNote.FieldName = "Note"
        Me.colNote.Name = "colNote"
        Me.colNote.OptionsColumn.AllowFocus = False
        Me.colNote.Visible = True
        Me.colNote.VisibleIndex = 2
        Me.colNote.Width = 200
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'ComunicazioneBindingSource
        '
        Me.ComunicazioneBindingSource.DataSource = GetType(WIN.DOMAIN.FED_SERVICES.Comunicazione)
        '
        'FrmUserMessages
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 351)
        Me.Controls.Add(Me.GridPosizioni)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmUserMessages"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Messaggi precedenti"
        CType(Me.GridPosizioni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComunicazioneBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridPosizioni As DevExpress.XtraGrid.GridControl
    Friend WithEvents ComunicazioneBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataDocumento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNomeUtente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNomeTipoComunicazione As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNomeCausale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
End Class
