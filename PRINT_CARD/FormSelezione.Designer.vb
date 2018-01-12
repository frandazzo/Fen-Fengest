<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSelezione
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSelezione))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lnkStampa = New System.Windows.Forms.LinkLabel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lnkRipristina = New System.Windows.Forms.LinkLabel()
        Me.lnkCreateList = New System.Windows.Forms.LinkLabel()
        Me.lnkExport = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.lnkImport = New System.Windows.Forms.LinkLabel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GridPosizioni = New DevExpress.XtraGrid.GridControl()
        Me.TesseratoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCognome = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNome = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAzienda = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProvincia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComune = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCap = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIdUtente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.cboSettore = New DevExpress.XtraEditors.ComboBoxEdit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridPosizioni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TesseratoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboSettore.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(55, 146)
        Me.Label4.MaximumSize = New System.Drawing.Size(500, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(357, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Questa funzionalita avvia la procedura di stampa delle tessere selezionate."
        '
        'lnkStampa
        '
        Me.lnkStampa.AutoSize = True
        Me.lnkStampa.BackColor = System.Drawing.Color.Transparent
        Me.lnkStampa.ForeColor = System.Drawing.Color.White
        Me.lnkStampa.LinkColor = System.Drawing.Color.DodgerBlue
        Me.lnkStampa.Location = New System.Drawing.Point(55, 108)
        Me.lnkStampa.Name = "lnkStampa"
        Me.lnkStampa.Size = New System.Drawing.Size(80, 13)
        Me.lnkStampa.TabIndex = 22
        Me.lnkStampa.TabStop = True
        Me.lnkStampa.Text = "Stampa tessere"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(55, 63)
        Me.Label7.MaximumSize = New System.Drawing.Size(500, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(475, 26)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Questa funzionalita consente di modificare il valore del campo azienda per tutti " & _
    "i lavoratori. In alcuni contesti si preferisce sotituire il nome dell'azienda co" & _
    "n il nome della provincia."
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.ForeColor = System.Drawing.Color.White
        Me.LinkLabel1.LinkColor = System.Drawing.Color.DodgerBlue
        Me.LinkLabel1.Location = New System.Drawing.Point(55, 44)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(110, 13)
        Me.LinkLabel1.TabIndex = 31
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Imposta testo azienda"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(55, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(365, 16)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Benvenuto nella procedura di stampa delle tessere."
        '
        'lnkRipristina
        '
        Me.lnkRipristina.AutoSize = True
        Me.lnkRipristina.BackColor = System.Drawing.Color.Transparent
        Me.lnkRipristina.ForeColor = System.Drawing.Color.White
        Me.lnkRipristina.LinkColor = System.Drawing.Color.DodgerBlue
        Me.lnkRipristina.Location = New System.Drawing.Point(179, 44)
        Me.lnkRipristina.Name = "lnkRipristina"
        Me.lnkRipristina.Size = New System.Drawing.Size(116, 13)
        Me.lnkRipristina.TabIndex = 43
        Me.lnkRipristina.TabStop = True
        Me.lnkRipristina.Text = "Ripristina testo azienda"
        '
        'lnkCreateList
        '
        Me.lnkCreateList.AutoSize = True
        Me.lnkCreateList.BackColor = System.Drawing.Color.Transparent
        Me.lnkCreateList.ForeColor = System.Drawing.Color.White
        Me.lnkCreateList.LinkColor = System.Drawing.Color.DodgerBlue
        Me.lnkCreateList.Location = New System.Drawing.Point(376, 108)
        Me.lnkCreateList.Name = "lnkCreateList"
        Me.lnkCreateList.Size = New System.Drawing.Size(93, 13)
        Me.lnkCreateList.TabIndex = 44
        Me.lnkCreateList.TabStop = True
        Me.lnkCreateList.Text = "Crea lista di lavoro"
        '
        'lnkExport
        '
        Me.lnkExport.AutoSize = True
        Me.lnkExport.BackColor = System.Drawing.Color.Transparent
        Me.lnkExport.ForeColor = System.Drawing.Color.White
        Me.lnkExport.LinkColor = System.Drawing.Color.DodgerBlue
        Me.lnkExport.Location = New System.Drawing.Point(303, 108)
        Me.lnkExport.Name = "lnkExport"
        Me.lnkExport.Size = New System.Drawing.Size(63, 13)
        Me.lnkExport.TabIndex = 45
        Me.lnkExport.TabStop = True
        Me.lnkExport.Text = "Esporta dati"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel2.ForeColor = System.Drawing.Color.White
        Me.LinkLabel2.LinkColor = System.Drawing.Color.DodgerBlue
        Me.LinkLabel2.Location = New System.Drawing.Point(142, 108)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(153, 13)
        Me.LinkLabel2.TabIndex = 46
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Stampa tessere come etichette"
        '
        'lnkImport
        '
        Me.lnkImport.AutoSize = True
        Me.lnkImport.BackColor = System.Drawing.Color.Transparent
        Me.lnkImport.ForeColor = System.Drawing.Color.White
        Me.lnkImport.LinkColor = System.Drawing.Color.DodgerBlue
        Me.lnkImport.Location = New System.Drawing.Point(55, 127)
        Me.lnkImport.Name = "lnkImport"
        Me.lnkImport.Size = New System.Drawing.Size(106, 13)
        Me.lnkImport.TabIndex = 47
        Me.lnkImport.TabStop = True
        Me.lnkImport.Text = "Importa lista di lavoro"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Location = New System.Drawing.Point(17, 50)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox4.TabIndex = 30
        Me.PictureBox4.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(17, 108)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'GridPosizioni
        '
        Me.GridPosizioni.DataSource = Me.TesseratoBindingSource
        Me.GridPosizioni.Location = New System.Drawing.Point(17, 188)
        Me.GridPosizioni.MainView = Me.GridView1
        Me.GridPosizioni.Name = "GridPosizioni"
        Me.GridPosizioni.Size = New System.Drawing.Size(579, 431)
        Me.GridPosizioni.TabIndex = 115
        Me.GridPosizioni.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'TesseratoBindingSource
        '
        Me.TesseratoBindingSource.DataSource = GetType(StampaTessereSindacati.Tesserato1)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCognome, Me.colNome, Me.colAzienda, Me.colProvincia, Me.colComune, Me.colVia, Me.colCap, Me.colIdUtente})
        Me.GridView1.GridControl = Me.GridPosizioni
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "TipoDocumento", Nothing, "")})
        Me.GridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsFilter.ShowAllTableValuesInFilterPopup = True
        Me.GridView1.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridView1.OptionsMenu.ShowGroupSummaryEditorItem = True
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'colCognome
        '
        Me.colCognome.FieldName = "Cognome"
        Me.colCognome.Name = "colCognome"
        Me.colCognome.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colCognome.Visible = True
        Me.colCognome.VisibleIndex = 0
        '
        'colNome
        '
        Me.colNome.FieldName = "Nome"
        Me.colNome.Name = "colNome"
        Me.colNome.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colNome.Visible = True
        Me.colNome.VisibleIndex = 1
        '
        'colAzienda
        '
        Me.colAzienda.FieldName = "Azienda"
        Me.colAzienda.Name = "colAzienda"
        Me.colAzienda.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colAzienda.Visible = True
        Me.colAzienda.VisibleIndex = 2
        '
        'colProvincia
        '
        Me.colProvincia.FieldName = "Provincia"
        Me.colProvincia.Name = "colProvincia"
        Me.colProvincia.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colProvincia.Visible = True
        Me.colProvincia.VisibleIndex = 3
        '
        'colComune
        '
        Me.colComune.FieldName = "Comune"
        Me.colComune.Name = "colComune"
        Me.colComune.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colComune.Visible = True
        Me.colComune.VisibleIndex = 4
        '
        'colVia
        '
        Me.colVia.FieldName = "Via"
        Me.colVia.Name = "colVia"
        Me.colVia.Visible = True
        Me.colVia.VisibleIndex = 5
        '
        'colCap
        '
        Me.colCap.FieldName = "Cap"
        Me.colCap.Name = "colCap"
        Me.colCap.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colCap.Visible = True
        Me.colCap.VisibleIndex = 6
        '
        'colIdUtente
        '
        Me.colIdUtente.FieldName = "IdUtente"
        Me.colIdUtente.Name = "colIdUtente"
        Me.colIdUtente.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colIdUtente.Visible = True
        Me.colIdUtente.VisibleIndex = 7
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel3.ForeColor = System.Drawing.Color.White
        Me.LinkLabel3.LinkColor = System.Drawing.Color.DodgerBlue
        Me.LinkLabel3.Location = New System.Drawing.Point(171, 127)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(64, 13)
        Me.LinkLabel3.TabIndex = 116
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Stampa lista"
        '
        'cboSettore
        '
        Me.cboSettore.Location = New System.Drawing.Point(459, 12)
        Me.cboSettore.Name = "cboSettore"
        Me.cboSettore.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboSettore.Properties.Items.AddRange(New Object() {"", "EDILIZIA - BAUSEKTOR", "IMPIANTI FISSI - ANDERE SEKTOREN"})
        Me.cboSettore.Size = New System.Drawing.Size(135, 20)
        Me.cboSettore.TabIndex = 117
        '
        'FormSelezione
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(606, 634)
        Me.Controls.Add(Me.cboSettore)
        Me.Controls.Add(Me.LinkLabel3)
        Me.Controls.Add(Me.GridPosizioni)
        Me.Controls.Add(Me.lnkImport)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.lnkExport)
        Me.Controls.Add(Me.lnkCreateList)
        Me.Controls.Add(Me.lnkRipristina)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lnkStampa)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormSelezione"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stampa tessere iscritti"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridPosizioni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TesseratoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboSettore.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lnkStampa As System.Windows.Forms.LinkLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lnkRipristina As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkCreateList As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkExport As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkImport As System.Windows.Forms.LinkLabel
    Friend WithEvents GridPosizioni As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TesseratoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colCognome As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAzienda As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProvincia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComune As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCap As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIdUtente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LinkLabel3 As System.Windows.Forms.LinkLabel
    Friend WithEvents cboSettore As DevExpress.XtraEditors.ComboBoxEdit

End Class
