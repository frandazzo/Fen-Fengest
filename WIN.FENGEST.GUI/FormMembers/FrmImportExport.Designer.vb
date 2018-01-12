<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmImportExport
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.ImportExportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colSelected = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colResult = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSubject = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLiberiImportedData = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLogFilePath = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colImportedFile = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colElaborationData = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCreatedDocumentId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ResultTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportExportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ResultTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.DataSource = Me.ImportExportBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(0, 29)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(721, 313)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'ImportExportBindingSource
        '
        Me.ImportExportBindingSource.DataSource = GetType(WIN.DOMAIN.FEDERATIONARTIFACTS.ImportExport)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colSelected, Me.colResult, Me.colSubject, Me.colLiberiImportedData, Me.colLogFilePath, Me.colImportedFile, Me.colType, Me.colElaborationData, Me.colCreatedDocumentId})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsDetail.EnableMasterViewMode = False
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        '
        'colSelected
        '
        Me.colSelected.FieldName = "Selected"
        Me.colSelected.Name = "colSelected"
        Me.colSelected.Visible = True
        Me.colSelected.VisibleIndex = 0
        '
        'colResult
        '
        Me.colResult.FieldName = "Result"
        Me.colResult.Name = "colResult"
        Me.colResult.OptionsColumn.AllowEdit = False
        Me.colResult.Visible = True
        Me.colResult.VisibleIndex = 4
        '
        'colSubject
        '
        Me.colSubject.FieldName = "Subject"
        Me.colSubject.Name = "colSubject"
        Me.colSubject.OptionsColumn.AllowEdit = False
        Me.colSubject.Visible = True
        Me.colSubject.VisibleIndex = 2
        '
        'colLiberiImportedData
        '
        Me.colLiberiImportedData.FieldName = "LiberiImportedData"
        Me.colLiberiImportedData.Name = "colLiberiImportedData"
        Me.colLiberiImportedData.OptionsColumn.AllowEdit = False
        Me.colLiberiImportedData.Visible = True
        Me.colLiberiImportedData.VisibleIndex = 8
        '
        'colLogFilePath
        '
        Me.colLogFilePath.FieldName = "LogFilePath"
        Me.colLogFilePath.Name = "colLogFilePath"
        Me.colLogFilePath.OptionsColumn.AllowEdit = False
        Me.colLogFilePath.Visible = True
        Me.colLogFilePath.VisibleIndex = 5
        '
        'colImportedFile
        '
        Me.colImportedFile.FieldName = "ImportedFile"
        Me.colImportedFile.Name = "colImportedFile"
        Me.colImportedFile.OptionsColumn.AllowEdit = False
        Me.colImportedFile.Visible = True
        Me.colImportedFile.VisibleIndex = 6
        '
        'colType
        '
        Me.colType.FieldName = "Type"
        Me.colType.Name = "colType"
        Me.colType.OptionsColumn.AllowEdit = False
        Me.colType.Visible = True
        Me.colType.VisibleIndex = 3
        '
        'colElaborationData
        '
        Me.colElaborationData.FieldName = "ElaborationData"
        Me.colElaborationData.Name = "colElaborationData"
        Me.colElaborationData.OptionsColumn.AllowEdit = False
        Me.colElaborationData.Visible = True
        Me.colElaborationData.VisibleIndex = 1
        '
        'colCreatedDocumentId
        '
        Me.colCreatedDocumentId.FieldName = "CreatedDocumentId"
        Me.colCreatedDocumentId.Name = "colCreatedDocumentId"
        Me.colCreatedDocumentId.OptionsColumn.AllowEdit = False
        Me.colCreatedDocumentId.Visible = True
        Me.colCreatedDocumentId.VisibleIndex = 7
        '
        'ResultTypeBindingSource
        '
        Me.ResultTypeBindingSource.DataSource = GetType(WIN.DOMAIN.FEDERATIONARTIFACTS.ImportExport.ResultType)
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(425, 0)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(296, 23)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "Calcola iscritti alle varie organizzazioni"
        '
        'FrmImportExport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 342)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GridControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmImportExport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Elaborazioni automatiche dalle casse edili"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportExportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ResultTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ImportExportBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ResultTypeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colSelected As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colResult As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSubject As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLiberiImportedData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLogFilePath As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImportedFile As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colType As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colElaborationData As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCreatedDocumentId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
End Class
