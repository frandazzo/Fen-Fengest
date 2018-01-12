<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDocumentoToListaLavoro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDocumentoToListaLavoro))
        Me.cmdAnnulla = New System.Windows.Forms.Button
        Me.cmdOK = New System.Windows.Forms.Button
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New WIN.GUI.UTILITY.NiceGroupBox
        Me.IdDocumentoTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdDocumentoTextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.NiceGroupBox1 = New WIN.GUI.UTILITY.NiceGroupBox
        Me.GridPosizioni = New DevExpress.XtraGrid.GridControl
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView
        Me.colUtente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTipoDocumento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSoggettoEsecutore = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colAziendaImpiego = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colImporto = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSettore = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCompetenza = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colCodiceFiscale = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colContrattoApplicato = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDataRegistrazione = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colDocumentoPadre = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colImportoRistorno = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colLivelloInquadramento = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colNote = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOreLavorate = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colOreMalattia = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colPagamentoReferente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colQuattordicesima = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colReferente = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colSedeOperativa = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTipoPrestazione = New DevExpress.XtraGrid.Columns.GridColumn
        Me.colTredicesima = New DevExpress.XtraGrid.Columns.GridColumn
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.NiceGroupBox1.SuspendLayout()
        CType(Me.GridPosizioni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdAnnulla
        '
        Me.cmdAnnulla.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdAnnulla.Location = New System.Drawing.Point(605, 619)
        Me.cmdAnnulla.Name = "cmdAnnulla"
        Me.cmdAnnulla.Size = New System.Drawing.Size(84, 25)
        Me.cmdAnnulla.TabIndex = 5
        Me.cmdAnnulla.Text = "&Annulla"
        Me.cmdAnnulla.UseVisualStyleBackColor = True
        '
        'cmdOK
        '
        Me.cmdOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdOK.Location = New System.Drawing.Point(514, 619)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.Size = New System.Drawing.Size(85, 25)
        Me.cmdOK.TabIndex = 4
        Me.cmdOK.Text = "&Ok"
        Me.cmdOK.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(5, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.NiceGroupBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(709, 610)
        Me.SplitContainer1.SplitterDistance = 87
        Me.SplitContainer1.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(709, 87)
        Me.Panel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoScroll = True
        Me.GroupBox1.BackColor = System.Drawing.Color.Silver
        Me.GroupBox1.Controls.Add(Me.IdDocumentoTextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(709, 87)
        Me.GroupBox1.TabIndex = 78
        Me.GroupBox1.Text = "Selezione tipo quote"
        Me.GroupBox1.Title = "Selezione"
        '
        'IdDocumentoTextBox1
        '
        Me.IdDocumentoTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.IdDocumentoTextBox1.DescriptionOfText = ""
        Me.IdDocumentoTextBox1.DescriptionTextWidth = 150
        Me.IdDocumentoTextBox1.DescriptionTextXValue = 92
        Me.IdDocumentoTextBox1.EnableSerchTextBox = True
        Me.IdDocumentoTextBox1.IsDescriptionVisible = False
        Me.IdDocumentoTextBox1.Location = New System.Drawing.Point(199, 33)
        Me.IdDocumentoTextBox1.Mandatory = False
        Me.IdDocumentoTextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.IdDocumentoTextBox1.Name = "IdDocumentoTextBox1"
        Me.IdDocumentoTextBox1.Size = New System.Drawing.Size(133, 25)
        Me.IdDocumentoTextBox1.TabIndex = 103
        Me.IdDocumentoTextBox1.TextValue = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 13)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Seleziona documento contabile"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.Anag
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(528, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 42)
        Me.Button1.TabIndex = 101
        Me.Button1.Text = "Visualizza"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'NiceGroupBox1
        '
        Me.NiceGroupBox1.Controls.Add(Me.GridPosizioni)
        Me.NiceGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NiceGroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.NiceGroupBox1.Name = "NiceGroupBox1"
        Me.NiceGroupBox1.Size = New System.Drawing.Size(709, 519)
        Me.NiceGroupBox1.TabIndex = 110
        Me.NiceGroupBox1.Title = "Lista lavoro risultante"
        '
        'GridPosizioni
        '
        Me.GridPosizioni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPosizioni.Location = New System.Drawing.Point(0, 0)
        Me.GridPosizioni.MainView = Me.GridView1
        Me.GridPosizioni.Name = "GridPosizioni"
        Me.GridPosizioni.Size = New System.Drawing.Size(709, 519)
        Me.GridPosizioni.TabIndex = 110
        Me.GridPosizioni.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colUtente, Me.colTipoDocumento, Me.colSoggettoEsecutore, Me.colAziendaImpiego, Me.colImporto, Me.colSettore, Me.colCompetenza, Me.colCodiceFiscale, Me.colContrattoApplicato, Me.colDataRegistrazione, Me.colDocumentoPadre, Me.colImportoRistorno, Me.colLivelloInquadramento, Me.colNote, Me.colOreLavorate, Me.colOreMalattia, Me.colPagamentoReferente, Me.colQuattordicesima, Me.colReferente, Me.colSedeOperativa, Me.colTipoPrestazione, Me.colTredicesima})
        Me.GridView1.GridControl = Me.GridPosizioni
        Me.GridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "TipoDocumento", Nothing, "")})
        Me.GridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsFilter.UseNewCustomFilterDialog = True
        Me.GridView1.OptionsMenu.ShowGroupSummaryEditorItem = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowDetailButtons = False
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'colUtente
        '
        Me.colUtente.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colUtente.AppearanceCell.Options.UseFont = True
        Me.colUtente.Caption = "Utente"
        Me.colUtente.FieldName = "Utente"
        Me.colUtente.Name = "colUtente"
        Me.colUtente.Visible = True
        Me.colUtente.VisibleIndex = 0
        '
        'colTipoDocumento
        '
        Me.colTipoDocumento.Caption = "Tipo documento"
        Me.colTipoDocumento.FieldName = "TipoDocumento"
        Me.colTipoDocumento.Name = "colTipoDocumento"
        Me.colTipoDocumento.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colTipoDocumento.Visible = True
        Me.colTipoDocumento.VisibleIndex = 1
        '
        'colSoggettoEsecutore
        '
        Me.colSoggettoEsecutore.Caption = "Soggetto  Esecutore"
        Me.colSoggettoEsecutore.FieldName = "SoggettoEsecutore"
        Me.colSoggettoEsecutore.Name = "colSoggettoEsecutore"
        Me.colSoggettoEsecutore.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colSoggettoEsecutore.Visible = True
        Me.colSoggettoEsecutore.VisibleIndex = 2
        '
        'colAziendaImpiego
        '
        Me.colAziendaImpiego.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colAziendaImpiego.AppearanceCell.Options.UseFont = True
        Me.colAziendaImpiego.Caption = "Azienda di impiego"
        Me.colAziendaImpiego.FieldName = "AziendaImpiego"
        Me.colAziendaImpiego.Name = "colAziendaImpiego"
        Me.colAziendaImpiego.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colAziendaImpiego.Visible = True
        Me.colAziendaImpiego.VisibleIndex = 3
        '
        'colImporto
        '
        Me.colImporto.DisplayFormat.FormatString = "c"
        Me.colImporto.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colImporto.FieldName = "Importo"
        Me.colImporto.Name = "colImporto"
        Me.colImporto.Visible = True
        Me.colImporto.VisibleIndex = 4
        '
        'colSettore
        '
        Me.colSettore.FieldName = "Settore"
        Me.colSettore.Name = "colSettore"
        Me.colSettore.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colCompetenza
        '
        Me.colCompetenza.FieldName = "Competenza"
        Me.colCompetenza.Name = "colCompetenza"
        '
        'colCodiceFiscale
        '
        Me.colCodiceFiscale.FieldName = "CodiceFiscale"
        Me.colCodiceFiscale.Name = "colCodiceFiscale"
        '
        'colContrattoApplicato
        '
        Me.colContrattoApplicato.FieldName = "ContrattoApplicato"
        Me.colContrattoApplicato.Name = "colContrattoApplicato"
        '
        'colDataRegistrazione
        '
        Me.colDataRegistrazione.FieldName = "DataRegistrazione"
        Me.colDataRegistrazione.Name = "colDataRegistrazione"
        Me.colDataRegistrazione.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.DateSmart
        '
        'colDocumentoPadre
        '
        Me.colDocumentoPadre.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colDocumentoPadre.AppearanceCell.Options.UseFont = True
        Me.colDocumentoPadre.FieldName = "DocumentoPadre"
        Me.colDocumentoPadre.Name = "colDocumentoPadre"
        Me.colDocumentoPadre.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colImportoRistorno
        '
        Me.colImportoRistorno.DisplayFormat.FormatString = "c"
        Me.colImportoRistorno.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.colImportoRistorno.FieldName = "ImportoRistorno"
        Me.colImportoRistorno.Name = "colImportoRistorno"
        '
        'colLivelloInquadramento
        '
        Me.colLivelloInquadramento.FieldName = "LivelloInquadramento"
        Me.colLivelloInquadramento.Name = "colLivelloInquadramento"
        '
        'colNote
        '
        Me.colNote.FieldName = "Note"
        Me.colNote.Name = "colNote"
        '
        'colOreLavorate
        '
        Me.colOreLavorate.FieldName = "OreLavorate"
        Me.colOreLavorate.Name = "colOreLavorate"
        '
        'colOreMalattia
        '
        Me.colOreMalattia.FieldName = "OreMalattia"
        Me.colOreMalattia.Name = "colOreMalattia"
        '
        'colPagamentoReferente
        '
        Me.colPagamentoReferente.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colPagamentoReferente.AppearanceCell.Options.UseFont = True
        Me.colPagamentoReferente.FieldName = "PagamentoReferente"
        Me.colPagamentoReferente.Name = "colPagamentoReferente"
        Me.colPagamentoReferente.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colQuattordicesima
        '
        Me.colQuattordicesima.FieldName = "Quattordicesima"
        Me.colQuattordicesima.Name = "colQuattordicesima"
        '
        'colReferente
        '
        Me.colReferente.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colReferente.AppearanceCell.Options.UseFont = True
        Me.colReferente.Caption = "Collaboratore"
        Me.colReferente.FieldName = "Referente"
        Me.colReferente.Name = "colReferente"
        '
        'colSedeOperativa
        '
        Me.colSedeOperativa.FieldName = "SedeOperativa"
        Me.colSedeOperativa.Name = "colSedeOperativa"
        '
        'colTipoPrestazione
        '
        Me.colTipoPrestazione.FieldName = "TipoPrestazione"
        Me.colTipoPrestazione.Name = "colTipoPrestazione"
        '
        'colTredicesima
        '
        Me.colTredicesima.FieldName = "Tredicesima"
        Me.colTredicesima.Name = "colTredicesima"
        '
        'FrmDocumentoToListaLavoro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(719, 653)
        Me.Controls.Add(Me.cmdAnnulla)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmDocumentoToListaLavoro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleziona documento contabile"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.NiceGroupBox1.ResumeLayout(False)
        CType(Me.GridPosizioni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdAnnulla As System.Windows.Forms.Button
    Friend WithEvents cmdOK As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents NiceGroupBox1 As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents IdDocumentoTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdDocumentoTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GridPosizioni As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colUtente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoDocumento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSoggettoEsecutore As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAziendaImpiego As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImporto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSettore As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompetenza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodiceFiscale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContrattoApplicato As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataRegistrazione As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDocumentoPadre As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colImportoRistorno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLivelloInquadramento As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOreLavorate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colOreMalattia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colPagamentoReferente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colQuattordicesima As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReferente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSedeOperativa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoPrestazione As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTredicesima As DevExpress.XtraGrid.Columns.GridColumn
End Class
