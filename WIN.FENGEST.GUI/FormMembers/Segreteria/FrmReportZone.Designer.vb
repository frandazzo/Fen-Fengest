<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReportZone
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
        Me.ReportZonaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colZona = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProvincia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCitta = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNomeAzienda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumIscritti = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNumLiberi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdAzienda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportZonaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataSource = Me.ReportZonaBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(673, 297)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ReportZonaBindingSource
        '
        Me.ReportZonaBindingSource.DataSource = GetType(WIN.DOMAIN.FEDERATIONARTIFACTS.ReportZona)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colZona, Me.colProvincia, Me.colCitta, Me.colNomeAzienda, Me.colNumIscritti, Me.colNumLiberi, Me.colIdAzienda})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        '
        'colZona
        '
        Me.colZona.FieldName = "Zona"
        Me.colZona.Name = "colZona"
        Me.colZona.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colZona.Visible = True
        Me.colZona.VisibleIndex = 0
        '
        'colProvincia
        '
        Me.colProvincia.FieldName = "Provincia"
        Me.colProvincia.Name = "colProvincia"
        Me.colProvincia.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colProvincia.Visible = True
        Me.colProvincia.VisibleIndex = 1
        '
        'colCitta
        '
        Me.colCitta.FieldName = "Citta"
        Me.colCitta.Name = "colCitta"
        Me.colCitta.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colCitta.Visible = True
        Me.colCitta.VisibleIndex = 2
        '
        'colNomeAzienda
        '
        Me.colNomeAzienda.FieldName = "NomeAzienda"
        Me.colNomeAzienda.Name = "colNomeAzienda"
        Me.colNomeAzienda.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colNomeAzienda.Visible = True
        Me.colNomeAzienda.VisibleIndex = 3
        '
        'colNumIscritti
        '
        Me.colNumIscritti.FieldName = "NumIscritti"
        Me.colNumIscritti.Name = "colNumIscritti"
        Me.colNumIscritti.Visible = True
        Me.colNumIscritti.VisibleIndex = 4
        '
        'colNumLiberi
        '
        Me.colNumLiberi.FieldName = "NumLiberi"
        Me.colNumLiberi.Name = "colNumLiberi"
        Me.colNumLiberi.Visible = True
        Me.colNumLiberi.VisibleIndex = 5
        '
        'colIdAzienda
        '
        Me.colIdAzienda.FieldName = "IdAzienda"
        Me.colIdAzienda.Name = "colIdAzienda"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(560, 303)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(94, 23)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "Esporta"
        '
        'FrmReportZone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 335)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GridControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmReportZone"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Zone"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportZonaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ReportZonaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colZona As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProvincia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCitta As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNomeAzienda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumIscritti As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNumLiberi As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdAzienda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
