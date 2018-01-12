<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIscrittoNonIscitto
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
        Me.IscrittoNonIscrittoDTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCognome = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNome = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataNascita = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCodice_Fiscale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNome_Nazione = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNome_Provincia_Nascita = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNome_Comune_Nascita = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNome_Provincia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNome_Comune = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIndirizzo = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCap = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCell1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCell2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSettore = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNomeEnte = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colAziendaImpiego = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colReferente = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTipoDoc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colLivello = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colContratto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompetenza = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIscittoA = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataNonIscritto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IscrittoNonIscrittoDTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.DataSource = Me.IscrittoNonIscrittoDTOBindingSource
        Me.GridControl1.Location = New System.Drawing.Point(3, 30)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(859, 392)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'IscrittoNonIscrittoDTOBindingSource
        '
        Me.IscrittoNonIscrittoDTOBindingSource.DataSource = GetType(WIN.DOMAIN.FEDERATIONARTIFACTS.IscrittoNonIscrittoDTO)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCognome, Me.colNome, Me.colDataNascita, Me.colCodice_Fiscale, Me.colNome_Nazione, Me.colNome_Provincia_Nascita, Me.colNome_Comune_Nascita, Me.colNome_Provincia, Me.colNome_Comune, Me.colIndirizzo, Me.colCap, Me.colCell1, Me.colCell2, Me.colSettore, Me.colNomeEnte, Me.colAziendaImpiego, Me.colReferente, Me.colTipoDoc, Me.colLivello, Me.colContratto, Me.colCompetenza, Me.colIscittoA, Me.colDataNonIscritto})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'colCognome
        '
        Me.colCognome.FieldName = "Cognome"
        Me.colCognome.Name = "colCognome"
        Me.colCognome.Visible = True
        Me.colCognome.VisibleIndex = 0
        '
        'colNome
        '
        Me.colNome.FieldName = "Nome"
        Me.colNome.Name = "colNome"
        Me.colNome.Visible = True
        Me.colNome.VisibleIndex = 1
        '
        'colDataNascita
        '
        Me.colDataNascita.FieldName = "DataNascita"
        Me.colDataNascita.Name = "colDataNascita"
        '
        'colCodice_Fiscale
        '
        Me.colCodice_Fiscale.FieldName = "Codice_Fiscale"
        Me.colCodice_Fiscale.Name = "colCodice_Fiscale"
        '
        'colNome_Nazione
        '
        Me.colNome_Nazione.FieldName = "Nome_Nazione"
        Me.colNome_Nazione.Name = "colNome_Nazione"
        Me.colNome_Nazione.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colNome_Provincia_Nascita
        '
        Me.colNome_Provincia_Nascita.FieldName = "Nome_Provincia_Nascita"
        Me.colNome_Provincia_Nascita.Name = "colNome_Provincia_Nascita"
        Me.colNome_Provincia_Nascita.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colNome_Comune_Nascita
        '
        Me.colNome_Comune_Nascita.FieldName = "Nome_Comune_Nascita"
        Me.colNome_Comune_Nascita.Name = "colNome_Comune_Nascita"
        Me.colNome_Comune_Nascita.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colNome_Provincia
        '
        Me.colNome_Provincia.FieldName = "Nome_Provincia"
        Me.colNome_Provincia.Name = "colNome_Provincia"
        Me.colNome_Provincia.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colNome_Provincia.Visible = True
        Me.colNome_Provincia.VisibleIndex = 2
        '
        'colNome_Comune
        '
        Me.colNome_Comune.FieldName = "Nome_Comune"
        Me.colNome_Comune.Name = "colNome_Comune"
        Me.colNome_Comune.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colNome_Comune.Visible = True
        Me.colNome_Comune.VisibleIndex = 3
        '
        'colIndirizzo
        '
        Me.colIndirizzo.FieldName = "Indirizzo"
        Me.colIndirizzo.Name = "colIndirizzo"
        Me.colIndirizzo.Visible = True
        Me.colIndirizzo.VisibleIndex = 4
        '
        'colCap
        '
        Me.colCap.FieldName = "Cap"
        Me.colCap.Name = "colCap"
        Me.colCap.Visible = True
        Me.colCap.VisibleIndex = 5
        '
        'colCell1
        '
        Me.colCell1.FieldName = "Cell1"
        Me.colCell1.Name = "colCell1"
        Me.colCell1.Visible = True
        Me.colCell1.VisibleIndex = 6
        '
        'colCell2
        '
        Me.colCell2.FieldName = "Cell2"
        Me.colCell2.Name = "colCell2"
        Me.colCell2.Visible = True
        Me.colCell2.VisibleIndex = 7
        '
        'colSettore
        '
        Me.colSettore.FieldName = "Settore"
        Me.colSettore.Name = "colSettore"
        Me.colSettore.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colNomeEnte
        '
        Me.colNomeEnte.FieldName = "NomeEnte"
        Me.colNomeEnte.Name = "colNomeEnte"
        Me.colNomeEnte.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colAziendaImpiego
        '
        Me.colAziendaImpiego.FieldName = "AziendaImpiego"
        Me.colAziendaImpiego.Name = "colAziendaImpiego"
        Me.colAziendaImpiego.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colAziendaImpiego.Visible = True
        Me.colAziendaImpiego.VisibleIndex = 8
        '
        'colReferente
        '
        Me.colReferente.FieldName = "Referente"
        Me.colReferente.Name = "colReferente"
        Me.colReferente.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colReferente.Visible = True
        Me.colReferente.VisibleIndex = 9
        '
        'colTipoDoc
        '
        Me.colTipoDoc.FieldName = "TipoDoc"
        Me.colTipoDoc.Name = "colTipoDoc"
        '
        'colLivello
        '
        Me.colLivello.FieldName = "Livello"
        Me.colLivello.Name = "colLivello"
        '
        'colContratto
        '
        Me.colContratto.FieldName = "Contratto"
        Me.colContratto.Name = "colContratto"
        '
        'colCompetenza
        '
        Me.colCompetenza.FieldName = "Competenza"
        Me.colCompetenza.Name = "colCompetenza"
        '
        'colIscittoA
        '
        Me.colIscittoA.FieldName = "IscittoA"
        Me.colIscittoA.Name = "colIscittoA"
        Me.colIscittoA.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colIscittoA.Visible = True
        Me.colIscittoA.VisibleIndex = 10
        '
        'colDataNonIscritto
        '
        Me.colDataNonIscritto.FieldName = "DataNonIscritto"
        Me.colDataNonIscritto.Name = "colDataNonIscritto"
        Me.colDataNonIscritto.Visible = True
        Me.colDataNonIscritto.VisibleIndex = 11
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SimpleButton1.Location = New System.Drawing.Point(697, 3)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(165, 23)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "Stampa"
        '
        'FrmIscrittoNonIscitto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 434)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "FrmIscrittoNonIscitto"
        Me.Text = "FrmIscrittoNonIscitto"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IscrittoNonIscrittoDTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents IscrittoNonIscrittoDTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colCognome As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataNascita As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCodice_Fiscale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome_Nazione As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome_Provincia_Nascita As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome_Comune_Nascita As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome_Provincia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome_Comune As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIndirizzo As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCap As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCell1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCell2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSettore As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNomeEnte As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colAziendaImpiego As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colReferente As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTipoDoc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colLivello As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colContratto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompetenza As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIscittoA As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataNonIscritto As DevExpress.XtraGrid.Columns.GridColumn
End Class
