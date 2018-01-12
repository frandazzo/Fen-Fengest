<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlSegreteria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlSegreteria))
        Me.grpRag = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txtCap = New System.Windows.Forms.TextBox()
        Me.txtPIva = New System.Windows.Forms.TextBox()
        Me.txtVia = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboProvincia = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboComune = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.txtWeb = New System.Windows.Forms.TextBox()
        Me.txtTelUf = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCell2 = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtFax = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtCell1 = New System.Windows.Forms.TextBox()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.txtResp = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTitoloPagina = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtSottotitolo2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSottotitolo3 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSottotitolo1 = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtModelli = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtEtichette = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtCartellaAziende = New System.Windows.Forms.TextBox()
        Me.cmdSelezionaCartellaAziende = New System.Windows.Forms.Button()
        Me.txtCartella = New System.Windows.Forms.TextBox()
        Me.cmdSeleziona = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCartellaUtenti = New System.Windows.Forms.TextBox()
        Me.cmdSelezionaCartellaUtenti = New System.Windows.Forms.Button()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.CustomBar1 = New WIN.GUI.APPLICATION.PRESENTATION.CustomBar()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.NiceGroupBox1 = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.spDoc1 = New System.Windows.Forms.Button()
        Me.spIscritti1 = New System.Windows.Forms.Button()
        Me.spArchivio1 = New System.Windows.Forms.Button()
        Me.DockPanel.SuspendLayout()
        Me.grpRag.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.NiceGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Size = New System.Drawing.Size(800, 30)
        '
        'DockPanel
        '
        Me.DockPanel.Controls.Add(Me.CustomBar1)
        Me.DockPanel.Size = New System.Drawing.Size(800, 44)
        '
        'grpRag
        '
        Me.grpRag.BackColor = System.Drawing.Color.Transparent
        Me.grpRag.Controls.Add(Me.TabControl2)
        Me.grpRag.Location = New System.Drawing.Point(11, 100)
        Me.grpRag.Name = "grpRag"
        Me.grpRag.Size = New System.Drawing.Size(588, 255)
        Me.grpRag.TabIndex = 35
        Me.grpRag.Title = "Segreteria"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage5)
        Me.TabControl2.Controls.Add(Me.TabPage1)
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Location = New System.Drawing.Point(16, 27)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(550, 215)
        Me.TabControl2.TabIndex = 3
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txtCap)
        Me.TabPage3.Controls.Add(Me.txtPIva)
        Me.TabPage3.Controls.Add(Me.txtVia)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.txtNome)
        Me.TabPage3.Controls.Add(Me.Label10)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.cboProvincia)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.Label9)
        Me.TabPage3.Controls.Add(Me.cboComune)
        Me.TabPage3.Controls.Add(Me.Label8)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(542, 189)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Ragione sociale"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'txtCap
        '
        Me.txtCap.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtCap, "CAP dell'indirizzo della sede della segreteria della federazione")
        Me.txtCap.Location = New System.Drawing.Point(79, 142)
        Me.txtCap.Name = "txtCap"
        Me.HelpProvider1.SetShowHelp(Me.txtCap, True)
        Me.txtCap.Size = New System.Drawing.Size(144, 20)
        Me.txtCap.TabIndex = 1
        '
        'txtPIva
        '
        Me.txtPIva.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPIva.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtPIva, "Partita Iva della segreteria della federazione provinciale")
        Me.txtPIva.Location = New System.Drawing.Point(385, 24)
        Me.txtPIva.Name = "txtPIva"
        Me.HelpProvider1.SetShowHelp(Me.txtPIva, True)
        Me.txtPIva.Size = New System.Drawing.Size(90, 20)
        Me.txtPIva.TabIndex = 1
        '
        'txtVia
        '
        Me.txtVia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtVia, "Indirizzo della segreteria della federazione provinciale")
        Me.txtVia.Location = New System.Drawing.Point(79, 54)
        Me.txtVia.Name = "txtVia"
        Me.HelpProvider1.SetShowHelp(Me.txtVia, True)
        Me.txtVia.Size = New System.Drawing.Size(421, 20)
        Me.txtVia.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(25, 84)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Provincia"
        '
        'txtNome
        '
        Me.txtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtNome, "Ragione sociale della segreteria della  federazione provinciale")
        Me.txtNome.Location = New System.Drawing.Point(79, 24)
        Me.txtNome.Name = "txtNome"
        Me.HelpProvider1.SetShowHelp(Me.txtNome, True)
        Me.txtNome.Size = New System.Drawing.Size(253, 20)
        Me.txtNome.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(48, 147)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "CAP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Rag. soc."
        '
        'cboProvincia
        '
        Me.cboProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProvincia.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboProvincia, "Provincia di residenza della segreteria della federazione ")
        Me.cboProvincia.Location = New System.Drawing.Point(79, 83)
        Me.cboProvincia.Name = "cboProvincia"
        Me.HelpProvider1.SetShowHelp(Me.cboProvincia, True)
        Me.cboProvincia.Size = New System.Drawing.Size(232, 21)
        Me.cboProvincia.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(345, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "P. Iva"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(29, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Indirizzo"
        '
        'cboComune
        '
        Me.cboComune.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboComune.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboComune, "Comune di residenza della segreteria della federazione")
        Me.cboComune.Location = New System.Drawing.Point(79, 113)
        Me.cboComune.Name = "cboComune"
        Me.HelpProvider1.SetShowHelp(Me.cboComune, True)
        Me.cboComune.Size = New System.Drawing.Size(232, 21)
        Me.cboComune.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(30, 117)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Comune"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.txtWeb)
        Me.TabPage5.Controls.Add(Me.txtTelUf)
        Me.TabPage5.Controls.Add(Me.Label1)
        Me.TabPage5.Controls.Add(Me.txtCell2)
        Me.TabPage5.Controls.Add(Me.Label13)
        Me.TabPage5.Controls.Add(Me.txtFax)
        Me.TabPage5.Controls.Add(Me.Label16)
        Me.TabPage5.Controls.Add(Me.txtCell1)
        Me.TabPage5.Controls.Add(Me.txtMail)
        Me.TabPage5.Controls.Add(Me.txtResp)
        Me.TabPage5.Controls.Add(Me.Label14)
        Me.TabPage5.Controls.Add(Me.Label19)
        Me.TabPage5.Controls.Add(Me.Label18)
        Me.TabPage5.Controls.Add(Me.Label15)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(542, 189)
        Me.TabPage5.TabIndex = 2
        Me.TabPage5.Text = "Contatti"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'txtWeb
        '
        Me.txtWeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtWeb, "Indizzo del sito web della segreteria della federazione o della federazione nazio" & _
        "nale")
        Me.txtWeb.Location = New System.Drawing.Point(55, 121)
        Me.txtWeb.Name = "txtWeb"
        Me.HelpProvider1.SetShowHelp(Me.txtWeb, True)
        Me.txtWeb.Size = New System.Drawing.Size(449, 20)
        Me.txtWeb.TabIndex = 27
        '
        'txtTelUf
        '
        Me.txtTelUf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtTelUf, "Numero di telefono della segreteria della federazione")
        Me.txtTelUf.Location = New System.Drawing.Point(55, 28)
        Me.txtTelUf.Name = "txtTelUf"
        Me.HelpProvider1.SetShowHelp(Me.txtTelUf, True)
        Me.txtTelUf.Size = New System.Drawing.Size(196, 20)
        Me.txtTelUf.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Web"
        '
        'txtCell2
        '
        Me.txtCell2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtCell2, "Numero di cellulare a cui l'utenza può chiamare per interagire con la segreteria " & _
        "della federazione")
        Me.txtCell2.Location = New System.Drawing.Point(308, 56)
        Me.txtCell2.Name = "txtCell2"
        Me.HelpProvider1.SetShowHelp(Me.txtCell2, True)
        Me.txtCell2.Size = New System.Drawing.Size(196, 20)
        Me.txtCell2.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(19, 31)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(25, 13)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Tel."
        '
        'txtFax
        '
        Me.txtFax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtFax, "Numero di fax della segreteria della federazione")
        Me.txtFax.Location = New System.Drawing.Point(55, 56)
        Me.txtFax.Name = "txtFax"
        Me.HelpProvider1.SetShowHelp(Me.txtFax, True)
        Me.txtFax.Size = New System.Drawing.Size(196, 20)
        Me.txtFax.TabIndex = 3
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(271, 89)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(26, 13)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Mail"
        '
        'txtCell1
        '
        Me.txtCell1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtCell1, "Numero di cellulare a cui l'utenza può chiamare per interagire con la segreteria " & _
        "della federazione")
        Me.txtCell1.Location = New System.Drawing.Point(308, 28)
        Me.txtCell1.Name = "txtCell1"
        Me.HelpProvider1.SetShowHelp(Me.txtCell1, True)
        Me.txtCell1.Size = New System.Drawing.Size(196, 20)
        Me.txtCell1.TabIndex = 2
        '
        'txtMail
        '
        Me.txtMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtMail, "Indirizzo di posta elettronica della segreteria della federazione")
        Me.txtMail.Location = New System.Drawing.Point(308, 86)
        Me.txtMail.Name = "txtMail"
        Me.HelpProvider1.SetShowHelp(Me.txtMail, True)
        Me.txtMail.Size = New System.Drawing.Size(196, 20)
        Me.txtMail.TabIndex = 4
        '
        'txtResp
        '
        Me.txtResp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtResp, "Responsabile della segreteria della federazione")
        Me.txtResp.Location = New System.Drawing.Point(55, 87)
        Me.txtResp.Name = "txtResp"
        Me.HelpProvider1.SetShowHelp(Me.txtResp, True)
        Me.txtResp.Size = New System.Drawing.Size(196, 20)
        Me.txtResp.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(264, 31)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 13)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Cell.1"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(20, 59)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(24, 13)
        Me.Label19.TabIndex = 25
        Me.Label19.Text = "Fax"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(13, 92)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(35, 13)
        Me.Label18.TabIndex = 24
        Me.Label18.Text = "Resp."
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(264, 59)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 13)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "Cell.2"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txtTitoloPagina)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.txtSottotitolo2)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.txtSottotitolo3)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.txtSottotitolo1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(542, 189)
        Me.TabPage1.TabIndex = 3
        Me.TabPage1.Text = "Intestazione stampe"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Titolo Pagina"
        '
        'txtTitoloPagina
        '
        Me.HelpProvider1.SetHelpString(Me.txtTitoloPagina, "Titolo della pagina pre-intestata per le stampe su carta intestata")
        Me.txtTitoloPagina.Location = New System.Drawing.Point(100, 22)
        Me.txtTitoloPagina.Multiline = True
        Me.txtTitoloPagina.Name = "txtTitoloPagina"
        Me.HelpProvider1.SetShowHelp(Me.txtTitoloPagina, True)
        Me.txtTitoloPagina.Size = New System.Drawing.Size(317, 29)
        Me.txtTitoloPagina.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(23, 63)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "Sottotitolo 1"
        '
        'txtSottotitolo2
        '
        Me.HelpProvider1.SetHelpString(Me.txtSottotitolo2, "Secondo sottotitolo della pagina pre-intestata per le stampe su carta intestata")
        Me.txtSottotitolo2.Location = New System.Drawing.Point(100, 95)
        Me.txtSottotitolo2.Multiline = True
        Me.txtSottotitolo2.Name = "txtSottotitolo2"
        Me.HelpProvider1.SetShowHelp(Me.txtSottotitolo2, True)
        Me.txtSottotitolo2.Size = New System.Drawing.Size(317, 28)
        Me.txtSottotitolo2.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Sottotitolo 3"
        '
        'txtSottotitolo3
        '
        Me.HelpProvider1.SetHelpString(Me.txtSottotitolo3, "Terzo sottotitolo della pagina pre-intestata per le stampe su carta intestata")
        Me.txtSottotitolo3.Location = New System.Drawing.Point(100, 131)
        Me.txtSottotitolo3.Multiline = True
        Me.txtSottotitolo3.Name = "txtSottotitolo3"
        Me.HelpProvider1.SetShowHelp(Me.txtSottotitolo3, True)
        Me.txtSottotitolo3.Size = New System.Drawing.Size(317, 31)
        Me.txtSottotitolo3.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Sottotitolo 2"
        '
        'txtSottotitolo1
        '
        Me.HelpProvider1.SetHelpString(Me.txtSottotitolo1, "Sottotitolo della pagina pre-intestata per le stampe su carta intestata")
        Me.txtSottotitolo1.Location = New System.Drawing.Point(100, 60)
        Me.txtSottotitolo1.Multiline = True
        Me.txtSottotitolo1.Name = "txtSottotitolo1"
        Me.HelpProvider1.SetShowHelp(Me.txtSottotitolo1, True)
        Me.txtSottotitolo1.Size = New System.Drawing.Size(317, 26)
        Me.txtSottotitolo1.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtModelli)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.Label21)
        Me.TabPage2.Controls.Add(Me.Label22)
        Me.TabPage2.Controls.Add(Me.txtEtichette)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.txtCartellaAziende)
        Me.TabPage2.Controls.Add(Me.cmdSelezionaCartellaAziende)
        Me.TabPage2.Controls.Add(Me.txtCartella)
        Me.TabPage2.Controls.Add(Me.cmdSeleziona)
        Me.TabPage2.Controls.Add(Me.Label20)
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.txtCartellaUtenti)
        Me.TabPage2.Controls.Add(Me.cmdSelezionaCartellaUtenti)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(542, 189)
        Me.TabPage2.TabIndex = 4
        Me.TabPage2.Text = "Archivi documentazione"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtModelli
        '
        Me.txtModelli.Enabled = False
        Me.HelpProvider1.SetHelpString(Me.txtModelli, resources.GetString("txtModelli.HelpString"))
        Me.txtModelli.Location = New System.Drawing.Point(108, 120)
        Me.txtModelli.Name = "txtModelli"
        Me.HelpProvider1.SetShowHelp(Me.txtModelli, True)
        Me.txtModelli.Size = New System.Drawing.Size(280, 21)
        Me.txtModelli.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.Button1, "Funzione che permette di selezionare il percorso della cartella segreteria.")
        Me.Button1.Location = New System.Drawing.Point(401, 120)
        Me.Button1.Name = "Button1"
        Me.HelpProvider1.SetShowHelp(Me.Button1, True)
        Me.Button1.Size = New System.Drawing.Size(125, 22)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Seleziona percorso"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(13, 163)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(86, 13)
        Me.Label21.TabIndex = 11
        Me.Label21.Text = "Cartella etichette"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(11, 127)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(77, 13)
        Me.Label22.TabIndex = 8
        Me.Label22.Text = "Cartella modelli"
        '
        'txtEtichette
        '
        Me.txtEtichette.Enabled = False
        Me.HelpProvider1.SetHelpString(Me.txtEtichette, resources.GetString("txtEtichette.HelpString"))
        Me.txtEtichette.Location = New System.Drawing.Point(108, 156)
        Me.txtEtichette.Name = "txtEtichette"
        Me.HelpProvider1.SetShowHelp(Me.txtEtichette, True)
        Me.txtEtichette.Size = New System.Drawing.Size(280, 21)
        Me.txtEtichette.TabIndex = 12
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.Button2, "Funzione che permette di selezionare il percorso della cartella utenti.")
        Me.Button2.Location = New System.Drawing.Point(401, 156)
        Me.Button2.Name = "Button2"
        Me.HelpProvider1.SetShowHelp(Me.Button2, True)
        Me.Button2.Size = New System.Drawing.Size(125, 22)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Seleziona percorso"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtCartellaAziende
        '
        Me.txtCartellaAziende.AcceptsTab = True
        Me.txtCartellaAziende.Enabled = False
        Me.HelpProvider1.SetHelpString(Me.txtCartellaAziende, resources.GetString("txtCartellaAziende.HelpString"))
        Me.txtCartellaAziende.Location = New System.Drawing.Point(108, 83)
        Me.txtCartellaAziende.Name = "txtCartellaAziende"
        Me.HelpProvider1.SetShowHelp(Me.txtCartellaAziende, True)
        Me.txtCartellaAziende.Size = New System.Drawing.Size(280, 21)
        Me.txtCartellaAziende.TabIndex = 6
        '
        'cmdSelezionaCartellaAziende
        '
        Me.cmdSelezionaCartellaAziende.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.cmdSelezionaCartellaAziende, "Funzione che permette di selezionare il percorso della cartella aziende.")
        Me.cmdSelezionaCartellaAziende.Location = New System.Drawing.Point(401, 83)
        Me.cmdSelezionaCartellaAziende.Name = "cmdSelezionaCartellaAziende"
        Me.HelpProvider1.SetShowHelp(Me.cmdSelezionaCartellaAziende, True)
        Me.cmdSelezionaCartellaAziende.Size = New System.Drawing.Size(125, 22)
        Me.cmdSelezionaCartellaAziende.TabIndex = 7
        Me.cmdSelezionaCartellaAziende.Text = "Seleziona percorso"
        Me.cmdSelezionaCartellaAziende.UseVisualStyleBackColor = True
        '
        'txtCartella
        '
        Me.txtCartella.Enabled = False
        Me.HelpProvider1.SetHelpString(Me.txtCartella, resources.GetString("txtCartella.HelpString"))
        Me.txtCartella.Location = New System.Drawing.Point(108, 11)
        Me.txtCartella.Name = "txtCartella"
        Me.HelpProvider1.SetShowHelp(Me.txtCartella, True)
        Me.txtCartella.Size = New System.Drawing.Size(280, 21)
        Me.txtCartella.TabIndex = 0
        '
        'cmdSeleziona
        '
        Me.cmdSeleziona.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.cmdSeleziona, "Funzione che permette di selezionare il percorso della cartella segreteria.")
        Me.cmdSeleziona.Location = New System.Drawing.Point(401, 11)
        Me.cmdSeleziona.Name = "cmdSeleziona"
        Me.HelpProvider1.SetShowHelp(Me.cmdSeleziona, True)
        Me.cmdSeleziona.Size = New System.Drawing.Size(125, 22)
        Me.cmdSeleziona.TabIndex = 1
        Me.cmdSeleziona.Text = "Seleziona percorso"
        Me.cmdSeleziona.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(13, 90)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(82, 13)
        Me.Label20.TabIndex = 5
        Me.Label20.Text = "Cartella aziende"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(13, 54)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(71, 13)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Cartella utenti"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(11, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Cartella segreteria"
        '
        'txtCartellaUtenti
        '
        Me.txtCartellaUtenti.Enabled = False
        Me.HelpProvider1.SetHelpString(Me.txtCartellaUtenti, resources.GetString("txtCartellaUtenti.HelpString"))
        Me.txtCartellaUtenti.Location = New System.Drawing.Point(108, 47)
        Me.txtCartellaUtenti.Name = "txtCartellaUtenti"
        Me.HelpProvider1.SetShowHelp(Me.txtCartellaUtenti, True)
        Me.txtCartellaUtenti.Size = New System.Drawing.Size(280, 21)
        Me.txtCartellaUtenti.TabIndex = 3
        '
        'cmdSelezionaCartellaUtenti
        '
        Me.cmdSelezionaCartellaUtenti.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.cmdSelezionaCartellaUtenti, "Funzione che permette di selezionare il percorso della cartella utenti.")
        Me.cmdSelezionaCartellaUtenti.Location = New System.Drawing.Point(401, 47)
        Me.cmdSelezionaCartellaUtenti.Name = "cmdSelezionaCartellaUtenti"
        Me.HelpProvider1.SetShowHelp(Me.cmdSelezionaCartellaUtenti, True)
        Me.cmdSelezionaCartellaUtenti.Size = New System.Drawing.Size(125, 22)
        Me.cmdSelezionaCartellaUtenti.TabIndex = 4
        Me.cmdSelezionaCartellaUtenti.Text = "Seleziona percorso"
        Me.cmdSelezionaCartellaUtenti.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Label25)
        Me.TabPage4.Controls.Add(Me.txtPassword)
        Me.TabPage4.Controls.Add(Me.Label24)
        Me.TabPage4.Controls.Add(Me.txtUser)
        Me.TabPage4.Controls.Add(Me.Label23)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(542, 189)
        Me.TabPage4.TabIndex = 5
        Me.TabPage4.Text = "Credenziali DB nazionale"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(24, 31)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(233, 13)
        Me.Label25.TabIndex = 4
        Me.Label25.Text = "Inserire le credenziali  per il database nazionale"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(101, 93)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(251, 21)
        Me.txtPassword.TabIndex = 3
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(33, 101)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(53, 13)
        Me.Label24.TabIndex = 2
        Me.Label24.Text = "Password"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(101, 62)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(251, 21)
        Me.txtUser.TabIndex = 1
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(28, 70)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(58, 13)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "User name"
        '
        'CustomBar1
        '
        Me.CustomBar1.BackColor = System.Drawing.Color.Transparent
        Me.CustomBar1.Location = New System.Drawing.Point(16, 1)
        Me.CustomBar1.Name = "CustomBar1"
        Me.CustomBar1.Size = New System.Drawing.Size(296, 40)
        Me.CustomBar1.TabIndex = 8
        '
        'NiceGroupBox1
        '
        Me.NiceGroupBox1.Controls.Add(Me.spDoc1)
        Me.NiceGroupBox1.Controls.Add(Me.spIscritti1)
        Me.NiceGroupBox1.Controls.Add(Me.spArchivio1)
        Me.NiceGroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NiceGroupBox1.Location = New System.Drawing.Point(614, 100)
        Me.NiceGroupBox1.Name = "NiceGroupBox1"
        Me.NiceGroupBox1.Size = New System.Drawing.Size(135, 255)
        Me.NiceGroupBox1.TabIndex = 36
        Me.NiceGroupBox1.Title = "Funzioni"
        '
        'spDoc1
        '
        Me.spDoc1.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.folder_grey_32x32
        Me.spDoc1.Location = New System.Drawing.Point(6, 111)
        Me.spDoc1.Name = "spDoc1"
        Me.spDoc1.Size = New System.Drawing.Size(123, 38)
        Me.spDoc1.TabIndex = 14
        Me.spDoc1.Text = "           Co&mpila documenti"
        Me.spDoc1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.spDoc1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.spDoc1.UseVisualStyleBackColor = True
        '
        'spIscritti1
        '
        Me.spIscritti1.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.folder_green_32x32
        Me.spIscritti1.Location = New System.Drawing.Point(6, 67)
        Me.spIscritti1.Name = "spIscritti1"
        Me.spIscritti1.Size = New System.Drawing.Size(123, 38)
        Me.spIscritti1.TabIndex = 12
        Me.spIscritti1.Text = "&Documenti contabili"
        Me.spIscritti1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.spIscritti1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.spIscritti1.UseVisualStyleBackColor = True
        '
        'spArchivio1
        '
        Me.spArchivio1.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.folder_orange_32x32
        Me.spArchivio1.Location = New System.Drawing.Point(6, 23)
        Me.spArchivio1.Name = "spArchivio1"
        Me.spArchivio1.Size = New System.Drawing.Size(123, 38)
        Me.spArchivio1.TabIndex = 11
        Me.spArchivio1.Text = "   &Archivio  doc."
        Me.spArchivio1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.spArchivio1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.spArchivio1.UseVisualStyleBackColor = True
        '
        'ControlSegreteria
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.NiceGroupBox1)
        Me.Controls.Add(Me.grpRag)
        Me.Name = "ControlSegreteria"
        Me.Size = New System.Drawing.Size(800, 491)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.DockPanel, 0)
        Me.Controls.SetChildIndex(Me.grpRag, 0)
        Me.Controls.SetChildIndex(Me.NiceGroupBox1, 0)
        Me.DockPanel.ResumeLayout(False)
        Me.grpRag.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.NiceGroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
   Friend WithEvents grpRag As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
   Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
   Friend WithEvents txtCap As System.Windows.Forms.TextBox
   Friend WithEvents txtPIva As System.Windows.Forms.TextBox
   Friend WithEvents txtVia As System.Windows.Forms.TextBox
   Friend WithEvents Label12 As System.Windows.Forms.Label
   Friend WithEvents txtNome As System.Windows.Forms.TextBox
   Friend WithEvents Label10 As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents cboProvincia As System.Windows.Forms.ComboBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Friend WithEvents cboComune As System.Windows.Forms.ComboBox
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
   Friend WithEvents txtFax As System.Windows.Forms.TextBox
   Friend WithEvents txtMail As System.Windows.Forms.TextBox
   Friend WithEvents Label19 As System.Windows.Forms.Label
   Friend WithEvents Label18 As System.Windows.Forms.Label
   Friend WithEvents txtResp As System.Windows.Forms.TextBox
   Friend WithEvents Label16 As System.Windows.Forms.Label
   Friend WithEvents Label13 As System.Windows.Forms.Label
   Friend WithEvents txtCell2 As System.Windows.Forms.TextBox
   Friend WithEvents txtTelUf As System.Windows.Forms.TextBox
   Friend WithEvents txtCell1 As System.Windows.Forms.TextBox
   Friend WithEvents Label14 As System.Windows.Forms.Label
   Friend WithEvents Label15 As System.Windows.Forms.Label
   Friend WithEvents txtWeb As System.Windows.Forms.TextBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents CustomBar1 As WIN.GUI.APPLICATION.PRESENTATION.CustomBar
   Friend WithEvents txtCartella As System.Windows.Forms.TextBox
   Friend WithEvents cmdSeleziona As System.Windows.Forms.Button
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
   Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents txtTitoloPagina As System.Windows.Forms.TextBox
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents txtSottotitolo1 As System.Windows.Forms.TextBox
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents txtSottotitolo2 As System.Windows.Forms.TextBox
   Friend WithEvents Label11 As System.Windows.Forms.Label
   Friend WithEvents txtSottotitolo3 As System.Windows.Forms.TextBox
   Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
   Friend WithEvents txtCartellaAziende As System.Windows.Forms.TextBox
   Friend WithEvents cmdSelezionaCartellaAziende As System.Windows.Forms.Button
   Friend WithEvents Label20 As System.Windows.Forms.Label
   Friend WithEvents txtCartellaUtenti As System.Windows.Forms.TextBox
   Friend WithEvents cmdSelezionaCartellaUtenti As System.Windows.Forms.Button
   Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents NiceGroupBox1 As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents spDoc1 As System.Windows.Forms.Button
    Friend WithEvents spIscritti1 As System.Windows.Forms.Button
    Friend WithEvents spArchivio1 As System.Windows.Forms.Button
    Friend WithEvents txtModelli As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtEtichette As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label

End Class
