<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlListaLavoro
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
        Me.grpRag = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.cmdSms = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdRemIncorrect = New System.Windows.Forms.Button()
        Me.cmdExport = New System.Windows.Forms.Button()
        Me.cmdCompare = New System.Windows.Forms.Button()
        Me.cmdImport = New System.Windows.Forms.Button()
        Me.cmdClone = New System.Windows.Forms.Button()
        Me.cmdDelLista = New System.Windows.Forms.Button()
        Me.cmdAddLista = New System.Windows.Forms.Button()
        Me.cmdRemoveElem = New System.Windows.Forms.Button()
        Me.cmdAddElement = New System.Windows.Forms.Button()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDescrizione = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GrpSed = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GridUtenti = New DevExpress.XtraGrid.GridControl()
        Me.UtenteDTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colCodiceFiscale = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colId = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCognome = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNome = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colDataNascita = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colSesso = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNazionalita = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProvinciaNascita = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComuneNascita = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colProvincia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colComune = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colVia = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCap = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCellulare1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCellulare2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTelefonoCasa = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colTelefonoUfficio = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colFax = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colMail = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colIndirizzoWeb = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colNote = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCompleteName = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCellulare1Numerico = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colCellulare2Numerico = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CustomBar1 = New WIN.GUI.APPLICATION.PRESENTATION.CustomBar()
        Me.lblId = New System.Windows.Forms.Label()
        Me.IdListaUtentiTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdListaUtentiTextBox()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.SpNew = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.DockPanel.SuspendLayout()
        Me.grpRag.SuspendLayout()
        Me.GrpSed.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.GridUtenti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UtenteDTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Size = New System.Drawing.Size(813, 26)
        '
        'DockPanel
        '
        Me.DockPanel.Controls.Add(Me.SpNew)
        Me.DockPanel.Controls.Add(Me.IdListaUtentiTextBox1)
        Me.DockPanel.Controls.Add(Me.lblId)
        Me.DockPanel.Controls.Add(Me.CustomBar1)
        Me.DockPanel.Location = New System.Drawing.Point(0, 26)
        Me.DockPanel.Size = New System.Drawing.Size(813, 44)
        Me.DockPanel.TabIndex = 0
        '
        'grpRag
        '
        Me.grpRag.AllowDrop = True
        Me.grpRag.BackColor = System.Drawing.Color.Transparent
        Me.grpRag.Controls.Add(Me.cmdSms)
        Me.grpRag.Controls.Add(Me.Button2)
        Me.grpRag.Controls.Add(Me.Button1)
        Me.grpRag.Controls.Add(Me.cmdRemIncorrect)
        Me.grpRag.Controls.Add(Me.cmdExport)
        Me.grpRag.Controls.Add(Me.cmdCompare)
        Me.grpRag.Controls.Add(Me.cmdImport)
        Me.grpRag.Controls.Add(Me.cmdClone)
        Me.grpRag.Controls.Add(Me.cmdDelLista)
        Me.grpRag.Controls.Add(Me.cmdAddLista)
        Me.grpRag.Controls.Add(Me.cmdRemoveElem)
        Me.grpRag.Controls.Add(Me.cmdAddElement)
        Me.grpRag.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpRag.ForeColor = System.Drawing.Color.Black
        Me.grpRag.Location = New System.Drawing.Point(661, 82)
        Me.grpRag.Name = "grpRag"
        Me.grpRag.Size = New System.Drawing.Size(131, 558)
        Me.grpRag.TabIndex = 1
        Me.grpRag.Text = "Dati generali"
        Me.grpRag.Title = "Funzioni"
        '
        'cmdSms
        '
        Me.cmdSms.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSms.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.email_32x32
        Me.cmdSms.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSms.Location = New System.Drawing.Point(5, 515)
        Me.cmdSms.Name = "cmdSms"
        Me.cmdSms.Size = New System.Drawing.Size(123, 38)
        Me.cmdSms.TabIndex = 11
        Me.cmdSms.Text = "Invia sms"
        Me.cmdSms.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSms.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdSms.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.print_32x32_active
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(5, 471)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(123, 38)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Stampa"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.synchronize_icon_28_28
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(8, 427)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 38)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "&Richiedi info dal web"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmdRemIncorrect
        '
        Me.cmdRemIncorrect.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRemIncorrect.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.vertenza_32x32
        Me.cmdRemIncorrect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdRemIncorrect.Location = New System.Drawing.Point(5, 378)
        Me.cmdRemIncorrect.Name = "cmdRemIncorrect"
        Me.cmdRemIncorrect.Size = New System.Drawing.Size(123, 43)
        Me.cmdRemIncorrect.TabIndex = 8
        Me.cmdRemIncorrect.Text = "Rimuovi in&dirizzi incompleti"
        Me.cmdRemIncorrect.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdRemIncorrect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdRemIncorrect.UseVisualStyleBackColor = True
        '
        'cmdExport
        '
        Me.cmdExport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdExport.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.synchronize_icon_28_28
        Me.cmdExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdExport.Location = New System.Drawing.Point(5, 290)
        Me.cmdExport.Name = "cmdExport"
        Me.cmdExport.Size = New System.Drawing.Size(123, 38)
        Me.cmdExport.TabIndex = 6
        Me.cmdExport.Text = "&Esporta lista (etichette)"
        Me.cmdExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdExport.UseVisualStyleBackColor = True
        '
        'cmdCompare
        '
        Me.cmdCompare.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCompare.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.Document_Chart_icon
        Me.cmdCompare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCompare.Location = New System.Drawing.Point(5, 246)
        Me.cmdCompare.Name = "cmdCompare"
        Me.cmdCompare.Size = New System.Drawing.Size(123, 38)
        Me.cmdCompare.TabIndex = 5
        Me.cmdCompare.Text = "Con&fronta"
        Me.cmdCompare.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdCompare.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdCompare.UseVisualStyleBackColor = True
        '
        'cmdImport
        '
        Me.cmdImport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdImport.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.synchronize_icon_28_28
        Me.cmdImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdImport.Location = New System.Drawing.Point(5, 334)
        Me.cmdImport.Name = "cmdImport"
        Me.cmdImport.Size = New System.Drawing.Size(123, 38)
        Me.cmdImport.TabIndex = 7
        Me.cmdImport.Text = "I&mporta lista"
        Me.cmdImport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdImport.UseVisualStyleBackColor = True
        '
        'cmdClone
        '
        Me.cmdClone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClone.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.k_multiple_32x32_1_2
        Me.cmdClone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdClone.Location = New System.Drawing.Point(3, 202)
        Me.cmdClone.Name = "cmdClone"
        Me.cmdClone.Size = New System.Drawing.Size(123, 38)
        Me.cmdClone.TabIndex = 4
        Me.cmdClone.Text = "&Clona lista"
        Me.cmdClone.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdClone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdClone.UseVisualStyleBackColor = True
        '
        'cmdDelLista
        '
        Me.cmdDelLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDelLista.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.Document_Difficon28_28
        Me.cmdDelLista.Location = New System.Drawing.Point(3, 159)
        Me.cmdDelLista.Name = "cmdDelLista"
        Me.cmdDelLista.Size = New System.Drawing.Size(123, 38)
        Me.cmdDelLista.TabIndex = 3
        Me.cmdDelLista.Text = "R&imuovi elementi comuni"
        Me.cmdDelLista.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdDelLista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdDelLista.UseVisualStyleBackColor = True
        '
        'cmdAddLista
        '
        Me.cmdAddLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddLista.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.Document_Copy_icon28_28
        Me.cmdAddLista.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAddLista.Location = New System.Drawing.Point(3, 115)
        Me.cmdAddLista.Name = "cmdAddLista"
        Me.cmdAddLista.Size = New System.Drawing.Size(123, 38)
        Me.cmdAddLista.TabIndex = 2
        Me.cmdAddLista.Text = "&Unisci"
        Me.cmdAddLista.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdAddLista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAddLista.UseVisualStyleBackColor = True
        '
        'cmdRemoveElem
        '
        Me.cmdRemoveElem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRemoveElem.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.file_remove_32x32
        Me.cmdRemoveElem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdRemoveElem.Location = New System.Drawing.Point(3, 71)
        Me.cmdRemoveElem.Name = "cmdRemoveElem"
        Me.cmdRemoveElem.Size = New System.Drawing.Size(123, 38)
        Me.cmdRemoveElem.TabIndex = 1
        Me.cmdRemoveElem.Text = "&Rimuovi elem."
        Me.cmdRemoveElem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdRemoveElem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdRemoveElem.UseVisualStyleBackColor = True
        '
        'cmdAddElement
        '
        Me.cmdAddElement.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAddElement.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.file_add_32x32
        Me.cmdAddElement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdAddElement.Location = New System.Drawing.Point(3, 27)
        Me.cmdAddElement.Name = "cmdAddElement"
        Me.cmdAddElement.Size = New System.Drawing.Size(123, 38)
        Me.cmdAddElement.TabIndex = 0
        Me.cmdAddElement.Text = "&Aggiungi elem."
        Me.cmdAddElement.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdAddElement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAddElement.UseVisualStyleBackColor = True
        '
        'txtNumero
        '
        Me.txtNumero.AcceptsTab = True
        Me.txtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtNumero, "Numero degli utenti che compongono la lista di lavoro")
        Me.txtNumero.Location = New System.Drawing.Point(508, 29)
        Me.txtNumero.Name = "txtNumero"
        Me.HelpProvider1.SetShowHelp(Me.txtNumero, True)
        Me.txtNumero.Size = New System.Drawing.Size(56, 20)
        Me.txtNumero.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(426, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Numero utenti:"
        '
        'txtDescrizione
        '
        Me.txtDescrizione.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtDescrizione, "Descrizione della lista di lavoro")
        Me.txtDescrizione.Location = New System.Drawing.Point(79, 29)
        Me.txtDescrizione.Name = "txtDescrizione"
        Me.HelpProvider1.SetShowHelp(Me.txtDescrizione, True)
        Me.txtDescrizione.Size = New System.Drawing.Size(288, 20)
        Me.txtDescrizione.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Descrizione"
        '
        'GrpSed
        '
        Me.GrpSed.AllowDrop = True
        Me.GrpSed.BackColor = System.Drawing.Color.Silver
        Me.GrpSed.Controls.Add(Me.Label3)
        Me.GrpSed.Controls.Add(Me.txtNumero)
        Me.GrpSed.Controls.Add(Me.Label1)
        Me.GrpSed.Controls.Add(Me.txtDescrizione)
        Me.GrpSed.Controls.Add(Me.Label2)
        Me.GrpSed.Controls.Add(Me.TabControl1)
        Me.GrpSed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpSed.ForeColor = System.Drawing.Color.Black
        Me.GrpSed.Location = New System.Drawing.Point(13, 82)
        Me.GrpSed.Name = "GrpSed"
        Me.GrpSed.Size = New System.Drawing.Size(642, 558)
        Me.GrpSed.TabIndex = 0
        Me.GrpSed.Text = "Lista utenti"
        Me.GrpSed.Title = "Lista Utenti"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(16, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(553, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "______________________________________________________________________________"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(15, 78)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(609, 466)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GridUtenti)
        Me.TabPage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(601, 440)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Lista utenti"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GridUtenti
        '
        Me.GridUtenti.DataSource = Me.UtenteDTOBindingSource
        Me.GridUtenti.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridUtenti.Location = New System.Drawing.Point(3, 3)
        Me.GridUtenti.MainView = Me.GridView1
        Me.GridUtenti.Name = "GridUtenti"
        Me.GridUtenti.Size = New System.Drawing.Size(595, 434)
        Me.GridUtenti.TabIndex = 123
        Me.GridUtenti.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'UtenteDTOBindingSource
        '
        Me.UtenteDTOBindingSource.DataSource = GetType(WIN.DOMAIN.FEDERATIONARTIFACTS.UtenteDTO)
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colCodiceFiscale, Me.colId, Me.colCognome, Me.colNome, Me.colDataNascita, Me.colSesso, Me.colNazionalita, Me.colProvinciaNascita, Me.colComuneNascita, Me.colProvincia, Me.colComune, Me.colVia, Me.colCap, Me.colCellulare1, Me.colCellulare2, Me.colTelefonoCasa, Me.colTelefonoUfficio, Me.colFax, Me.colMail, Me.colIndirizzoWeb, Me.colNote, Me.colCompleteName, Me.colCellulare1Numerico, Me.colCellulare2Numerico})
        Me.GridView1.GridControl = Me.GridUtenti
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
        'colCodiceFiscale
        '
        Me.colCodiceFiscale.FieldName = "CodiceFiscale"
        Me.colCodiceFiscale.Name = "colCodiceFiscale"
        '
        'colId
        '
        Me.colId.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colId.AppearanceCell.Options.UseFont = True
        Me.colId.Caption = "Id Utente"
        Me.colId.FieldName = "Id"
        Me.colId.Name = "colId"
        Me.colId.Visible = True
        Me.colId.VisibleIndex = 0
        '
        'colCognome
        '
        Me.colCognome.FieldName = "Cognome"
        Me.colCognome.Name = "colCognome"
        Me.colCognome.Visible = True
        Me.colCognome.VisibleIndex = 1
        '
        'colNome
        '
        Me.colNome.FieldName = "Nome"
        Me.colNome.Name = "colNome"
        Me.colNome.Visible = True
        Me.colNome.VisibleIndex = 2
        '
        'colDataNascita
        '
        Me.colDataNascita.FieldName = "DataNascita"
        Me.colDataNascita.Name = "colDataNascita"
        Me.colDataNascita.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.DateSmart
        '
        'colSesso
        '
        Me.colSesso.FieldName = "Sesso"
        Me.colSesso.Name = "colSesso"
        '
        'colNazionalita
        '
        Me.colNazionalita.FieldName = "Nazionalita"
        Me.colNazionalita.Name = "colNazionalita"
        Me.colNazionalita.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        Me.colNazionalita.Visible = True
        Me.colNazionalita.VisibleIndex = 3
        '
        'colProvinciaNascita
        '
        Me.colProvinciaNascita.FieldName = "ProvinciaNascita"
        Me.colProvinciaNascita.Name = "colProvinciaNascita"
        Me.colProvinciaNascita.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colComuneNascita
        '
        Me.colComuneNascita.FieldName = "ComuneNascita"
        Me.colComuneNascita.Name = "colComuneNascita"
        Me.colComuneNascita.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
        '
        'colProvincia
        '
        Me.colProvincia.FieldName = "Provincia"
        Me.colProvincia.Name = "colProvincia"
        Me.colProvincia.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList
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
        'colCellulare1
        '
        Me.colCellulare1.FieldName = "Cellulare1"
        Me.colCellulare1.Name = "colCellulare1"
        '
        'colCellulare2
        '
        Me.colCellulare2.FieldName = "Cellulare2"
        Me.colCellulare2.Name = "colCellulare2"
        '
        'colTelefonoCasa
        '
        Me.colTelefonoCasa.FieldName = "TelefonoCasa"
        Me.colTelefonoCasa.Name = "colTelefonoCasa"
        '
        'colTelefonoUfficio
        '
        Me.colTelefonoUfficio.FieldName = "TelefonoUfficio"
        Me.colTelefonoUfficio.Name = "colTelefonoUfficio"
        '
        'colFax
        '
        Me.colFax.FieldName = "Fax"
        Me.colFax.Name = "colFax"
        '
        'colMail
        '
        Me.colMail.FieldName = "Mail"
        Me.colMail.Name = "colMail"
        '
        'colIndirizzoWeb
        '
        Me.colIndirizzoWeb.FieldName = "IndirizzoWeb"
        Me.colIndirizzoWeb.Name = "colIndirizzoWeb"
        '
        'colNote
        '
        Me.colNote.FieldName = "Note"
        Me.colNote.Name = "colNote"
        '
        'colCompleteName
        '
        Me.colCompleteName.FieldName = "CompleteName"
        Me.colCompleteName.Name = "colCompleteName"
        '
        'colCellulare1Numerico
        '
        Me.colCellulare1Numerico.FieldName = "Cellulare1Numerico"
        Me.colCellulare1Numerico.Name = "colCellulare1Numerico"
        '
        'colCellulare2Numerico
        '
        Me.colCellulare2Numerico.FieldName = "Cellulare2Numerico"
        Me.colCellulare2Numerico.Name = "colCellulare2Numerico"
        '
        'CustomBar1
        '
        Me.CustomBar1.BackColor = System.Drawing.Color.Transparent
        Me.CustomBar1.Location = New System.Drawing.Point(172, 1)
        Me.CustomBar1.Name = "CustomBar1"
        Me.CustomBar1.Size = New System.Drawing.Size(294, 40)
        Me.CustomBar1.TabIndex = 4
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.BackColor = System.Drawing.Color.Transparent
        Me.lblId.Location = New System.Drawing.Point(19, 17)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(17, 13)
        Me.lblId.TabIndex = 0
        Me.lblId.Text = "Id"
        '
        'IdListaUtentiTextBox1
        '
        Me.IdListaUtentiTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.IdListaUtentiTextBox1.DescriptionOfText = ""
        Me.IdListaUtentiTextBox1.DescriptionTextWidth = 150
        Me.IdListaUtentiTextBox1.DescriptionTextXValue = 92
        Me.IdListaUtentiTextBox1.EnableSerchTextBox = True
        Me.HelpProvider1.SetHelpString(Me.IdListaUtentiTextBox1, "Identificativo della lista di lavoro")
        Me.IdListaUtentiTextBox1.IsDescriptionVisible = False
        Me.IdListaUtentiTextBox1.Location = New System.Drawing.Point(40, 12)
        Me.IdListaUtentiTextBox1.Mandatory = False
        Me.IdListaUtentiTextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.IdListaUtentiTextBox1.Name = "IdListaUtentiTextBox1"
        Me.HelpProvider1.SetShowHelp(Me.IdListaUtentiTextBox1, True)
        Me.IdListaUtentiTextBox1.Size = New System.Drawing.Size(97, 25)
        Me.IdListaUtentiTextBox1.TabIndex = 1
        Me.IdListaUtentiTextBox1.TextValue = ""
        '
        'SpNew
        '
        Me.SpNew.ApplyOutLookStile = True
        Me.SpNew.BackColor = System.Drawing.Color.Transparent
        Me.SpNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SpNew.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.file_new_32x32
        Me.SpNew.Disabled = False
        Me.SpNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SpNew.ForeColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.SpNew, "Funzione che permette di creare una nuova comunicazione per l'utente.")
        Me.SpNew.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SpNew.Location = New System.Drawing.Point(178, 6)
        Me.SpNew.Name = "SpNew"
        Me.SpNew.Radius = 32.0!
        Me.HelpProvider1.SetShowHelp(Me.SpNew, True)
        Me.SpNew.ShowTooltip = True
        Me.SpNew.Size = New System.Drawing.Size(32, 32)
        Me.SpNew.TabIndex = 2
        Me.SpNew.TextValue = ""
        Me.SpNew.TooltipText = "Crea nuova comunicazione"
        '
        'ControlListaLavoro
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.grpRag)
        Me.Controls.Add(Me.GrpSed)
        Me.Name = "ControlListaLavoro"
        Me.Size = New System.Drawing.Size(813, 666)
        Me.Controls.SetChildIndex(Me.DockPanel, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.GrpSed, 0)
        Me.Controls.SetChildIndex(Me.grpRag, 0)
        Me.DockPanel.ResumeLayout(False)
        Me.DockPanel.PerformLayout()
        Me.grpRag.ResumeLayout(False)
        Me.GrpSed.ResumeLayout(False)
        Me.GrpSed.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.GridUtenti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UtenteDTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpRag As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents txtDescrizione As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GrpSed As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents CustomBar1 As WIN.GUI.APPLICATION.PRESENTATION.CustomBar
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents IdListaUtentiTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdListaUtentiTextBox
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents SpNew As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdDelLista As System.Windows.Forms.Button
    Friend WithEvents cmdAddLista As System.Windows.Forms.Button
    Friend WithEvents cmdRemoveElem As System.Windows.Forms.Button
    Friend WithEvents cmdAddElement As System.Windows.Forms.Button
    Friend WithEvents cmdImport As System.Windows.Forms.Button
    Friend WithEvents cmdClone As System.Windows.Forms.Button
    Friend WithEvents cmdCompare As System.Windows.Forms.Button
    Friend WithEvents cmdExport As System.Windows.Forms.Button
    Friend WithEvents cmdRemIncorrect As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GridUtenti As DevExpress.XtraGrid.GridControl
    Friend WithEvents UtenteDTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents colCodiceFiscale As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCognome As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNome As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colDataNascita As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colSesso As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNazionalita As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProvinciaNascita As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComuneNascita As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colProvincia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colComune As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colVia As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCap As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCellulare1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCellulare2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTelefonoCasa As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colTelefonoUfficio As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colFax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colMail As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colIndirizzoWeb As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colNote As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colId As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCompleteName As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents colCellulare1Numerico As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colCellulare2Numerico As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cmdSms As System.Windows.Forms.Button

End Class
