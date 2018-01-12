<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCantiere
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
        Me.cmdClose = New DevExpress.XtraEditors.SimpleButton()
        Me.cmdOk = New DevExpress.XtraEditors.SimpleButton()
        Me.txtDescr = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.dtpData = New DevExpress.XtraEditors.DateEdit()
        Me.txtnot = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txtZona = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txtImp = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.cboProv = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.cboCom = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.txtDescr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpData.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpData.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtnot.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtZona.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtImp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboProv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboCom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(346, 365)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(75, 23)
        Me.cmdClose.TabIndex = 0
        Me.cmdClose.Text = "Chiudi"
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(265, 365)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(75, 23)
        Me.cmdOk.TabIndex = 1
        Me.cmdOk.Text = "Ok"
        '
        'txtDescr
        '
        Me.txtDescr.Location = New System.Drawing.Point(100, 27)
        Me.txtDescr.Name = "txtDescr"
        Me.txtDescr.Size = New System.Drawing.Size(255, 20)
        Me.txtDescr.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(29, 30)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(54, 13)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Descrizione"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(39, 69)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(44, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Data fine"
        '
        'dtpData
        '
        Me.dtpData.EditValue = Nothing
        Me.dtpData.Location = New System.Drawing.Point(100, 61)
        Me.dtpData.Name = "dtpData"
        Me.dtpData.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[False]
        Me.dtpData.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpData.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dtpData.Size = New System.Drawing.Size(150, 20)
        Me.dtpData.TabIndex = 5
        '
        'txtnot
        '
        Me.txtnot.Location = New System.Drawing.Point(100, 275)
        Me.txtnot.Name = "txtnot"
        Me.txtnot.Size = New System.Drawing.Size(297, 84)
        Me.txtnot.TabIndex = 6
        Me.txtnot.UseOptimizedRendering = True
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(60, 278)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl3.TabIndex = 7
        Me.LabelControl3.Text = "Note"
        '
        'txtZona
        '
        Me.txtZona.Location = New System.Drawing.Point(100, 106)
        Me.txtZona.Name = "txtZona"
        Me.txtZona.Size = New System.Drawing.Size(255, 20)
        Me.txtZona.TabIndex = 8
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(59, 113)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(24, 13)
        Me.LabelControl4.TabIndex = 9
        Me.LabelControl4.Text = "Zona"
        '
        'txtImp
        '
        Me.txtImp.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtImp.Location = New System.Drawing.Point(100, 231)
        Me.txtImp.Name = "txtImp"
        Me.txtImp.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtImp.Properties.DisplayFormat.FormatString = "C2"
        Me.txtImp.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.txtImp.Size = New System.Drawing.Size(150, 20)
        Me.txtImp.TabIndex = 10
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(45, 238)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl5.TabIndex = 11
        Me.LabelControl5.Text = "Importo"
        '
        'cboProv
        '
        Me.cboProv.Location = New System.Drawing.Point(100, 149)
        Me.cboProv.Name = "cboProv"
        Me.cboProv.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboProv.Size = New System.Drawing.Size(255, 20)
        Me.cboProv.TabIndex = 12
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(40, 152)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl6.TabIndex = 13
        Me.LabelControl6.Text = "Provincia"
        '
        'cboCom
        '
        Me.cboCom.Location = New System.Drawing.Point(100, 196)
        Me.cboCom.Name = "cboCom"
        Me.cboCom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboCom.Size = New System.Drawing.Size(255, 20)
        Me.cboCom.TabIndex = 14
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(40, 199)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(39, 13)
        Me.LabelControl7.TabIndex = 15
        Me.LabelControl7.Text = "Comune"
        '
        'FormCantiere
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(433, 397)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.cboCom)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.cboProv)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txtImp)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txtZona)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txtnot)
        Me.Controls.Add(Me.dtpData)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txtDescr)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmdClose)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormCantiere"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormCantiere"
        CType(Me.txtDescr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpData.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpData.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtnot.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtZona.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtImp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboProv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboCom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdClose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cmdOk As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtDescr As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dtpData As DevExpress.XtraEditors.DateEdit
    Friend WithEvents txtnot As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtZona As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txtImp As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboProv As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboCom As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
End Class
