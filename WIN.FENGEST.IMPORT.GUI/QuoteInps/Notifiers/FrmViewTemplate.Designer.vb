<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmViewTemplate
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
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.InpsTraceDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.colCOGNOME_UTENTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOME_UTENTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDATA_NASCITA_UTENTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFISCALE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colPROVINCIA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCOMUNE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colINDIRIZZO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCAP = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSETTORE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFILE_NAME = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDATA_INIZIO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colQUOTA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTIPO_PRESTAZIONE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNOME_REFERENTE = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCOGNOME_REFERENTE = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InpsTraceDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataSource = Me.InpsTraceDetailsBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(2, 1)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(835, 435)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'InpsTraceDetailsBindingSource
        '
        Me.InpsTraceDetailsBindingSource.DataSource = GetType(WIN.FENGEST_NAZIONALE.INTEGRATION_ENTITIES.FenealgestImportExport.InpsTraceDetails)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCOGNOME_UTENTE, Me.colNOME_UTENTE, Me.colDATA_NASCITA_UTENTE, Me.colFISCALE, Me.colPROVINCIA, Me.colCOMUNE, Me.colINDIRIZZO, Me.colCAP, Me.colSETTORE, Me.colDATA_INIZIO, Me.colQUOTA, Me.colTIPO_PRESTAZIONE, Me.colNOME_REFERENTE, Me.colCOGNOME_REFERENTE, Me.colFILE_NAME})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Location = New System.Drawing.Point(678, 472)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(127, 23)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "Esporta"
        '
        'colCOGNOME_UTENTE
        '
        Me.colCOGNOME_UTENTE.FieldName = "COGNOME_UTENTE"
        Me.colCOGNOME_UTENTE.Name = "colCOGNOME_UTENTE"
        Me.colCOGNOME_UTENTE.Visible = True
        Me.colCOGNOME_UTENTE.VisibleIndex = 0
        '
        'colNOME_UTENTE
        '
        Me.colNOME_UTENTE.FieldName = "NOME_UTENTE"
        Me.colNOME_UTENTE.Name = "colNOME_UTENTE"
        Me.colNOME_UTENTE.Visible = True
        Me.colNOME_UTENTE.VisibleIndex = 1
        '
        'colDATA_NASCITA_UTENTE
        '
        Me.colDATA_NASCITA_UTENTE.FieldName = "DATA_NASCITA_UTENTE"
        Me.colDATA_NASCITA_UTENTE.Name = "colDATA_NASCITA_UTENTE"
        Me.colDATA_NASCITA_UTENTE.Visible = True
        Me.colDATA_NASCITA_UTENTE.VisibleIndex = 2
        '
        'colFISCALE
        '
        Me.colFISCALE.FieldName = "FISCALE"
        Me.colFISCALE.Name = "colFISCALE"
        Me.colFISCALE.Visible = True
        Me.colFISCALE.VisibleIndex = 3
        '
        'colPROVINCIA
        '
        Me.colPROVINCIA.FieldName = "PROVINCIA"
        Me.colPROVINCIA.Name = "colPROVINCIA"
        Me.colPROVINCIA.Visible = True
        Me.colPROVINCIA.VisibleIndex = 4
        '
        'colCOMUNE
        '
        Me.colCOMUNE.FieldName = "COMUNE"
        Me.colCOMUNE.Name = "colCOMUNE"
        Me.colCOMUNE.Visible = True
        Me.colCOMUNE.VisibleIndex = 5
        '
        'colINDIRIZZO
        '
        Me.colINDIRIZZO.FieldName = "INDIRIZZO"
        Me.colINDIRIZZO.Name = "colINDIRIZZO"
        Me.colINDIRIZZO.Visible = True
        Me.colINDIRIZZO.VisibleIndex = 6
        '
        'colCAP
        '
        Me.colCAP.FieldName = "CAP"
        Me.colCAP.Name = "colCAP"
        Me.colCAP.Visible = True
        Me.colCAP.VisibleIndex = 7
        '
        'colSETTORE
        '
        Me.colSETTORE.FieldName = "SETTORE"
        Me.colSETTORE.Name = "colSETTORE"
        Me.colSETTORE.Visible = True
        Me.colSETTORE.VisibleIndex = 8
        '
        'colFILE_NAME
        '
        Me.colFILE_NAME.FieldName = "FILE_NAME"
        Me.colFILE_NAME.Name = "colFILE_NAME"
        Me.colFILE_NAME.Visible = True
        Me.colFILE_NAME.VisibleIndex = 9
        '
        'colDATA_INIZIO
        '
        Me.colDATA_INIZIO.FieldName = "DATA_INIZIO"
        Me.colDATA_INIZIO.Name = "colDATA_INIZIO"
        Me.colDATA_INIZIO.Visible = True
        Me.colDATA_INIZIO.VisibleIndex = 10
        '
        'colQUOTA
        '
        Me.colQUOTA.FieldName = "QUOTA"
        Me.colQUOTA.Name = "colQUOTA"
        Me.colQUOTA.Visible = True
        Me.colQUOTA.VisibleIndex = 11
        '
        'colTIPO_PRESTAZIONE
        '
        Me.colTIPO_PRESTAZIONE.FieldName = "TIPO_PRESTAZIONE"
        Me.colTIPO_PRESTAZIONE.Name = "colTIPO_PRESTAZIONE"
        Me.colTIPO_PRESTAZIONE.Visible = True
        Me.colTIPO_PRESTAZIONE.VisibleIndex = 12
        '
        'colNOME_REFERENTE
        '
        Me.colNOME_REFERENTE.FieldName = "NOME_REFERENTE"
        Me.colNOME_REFERENTE.Name = "colNOME_REFERENTE"
        Me.colNOME_REFERENTE.Visible = True
        Me.colNOME_REFERENTE.VisibleIndex = 13
        '
        'colCOGNOME_REFERENTE
        '
        Me.colCOGNOME_REFERENTE.FieldName = "COGNOME_REFERENTE"
        Me.colCOGNOME_REFERENTE.Name = "colCOGNOME_REFERENTE"
        Me.colCOGNOME_REFERENTE.Visible = True
        Me.colCOGNOME_REFERENTE.VisibleIndex = 14
        '
        'FrmViewTemplate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 497)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GridControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "FrmViewTemplate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visualizza dati"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InpsTraceDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents InpsTraceDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents colCOGNOME_UTENTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOME_UTENTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDATA_NASCITA_UTENTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFISCALE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPROVINCIA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOMUNE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colINDIRIZZO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCAP As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSETTORE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDATA_INIZIO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQUOTA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTIPO_PRESTAZIONE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNOME_REFERENTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCOGNOME_REFERENTE As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFILE_NAME As DevExpress.XtraGrid.Columns.GridColumn
End Class
