<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlAnagraficaReferente
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
        Me.lblId = New System.Windows.Forms.Label()
        Me.chkCom = New System.Windows.Forms.CheckBox()
        Me.txtCognome = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPrdVe = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPrdIn = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPrdIf = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtUltimoRistorno = New System.Windows.Forms.TextBox()
        Me.lblUltimo = New System.Windows.Forms.Label()
        Me.txtPrd = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CustomBar1 = New WIN.GUI.APPLICATION.PRESENTATION.CustomBar()
        Me.grpAnag = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtCap = New System.Windows.Forms.TextBox()
        Me.txtVia = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cboProvincia = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cboComune = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtFax = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtCell2 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtCell1 = New System.Windows.Forms.TextBox()
        Me.txtResp = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtTelUf = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.IdReferenteTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.SpNew = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.DockPanel.SuspendLayout()
        Me.grpAnag.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Size = New System.Drawing.Size(814, 22)
        '
        'DockPanel
        '
        Me.DockPanel.Controls.Add(Me.SpNew)
        Me.DockPanel.Controls.Add(Me.IdReferenteTextBox1)
        Me.DockPanel.Controls.Add(Me.CustomBar1)
        Me.DockPanel.Controls.Add(Me.lblId)
        Me.DockPanel.Location = New System.Drawing.Point(0, 22)
        Me.DockPanel.Size = New System.Drawing.Size(814, 44)
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.BackColor = System.Drawing.Color.Transparent
        Me.lblId.Location = New System.Drawing.Point(14, 16)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(17, 13)
        Me.lblId.TabIndex = 0
        Me.lblId.Text = "Id"
        '
        'chkCom
        '
        Me.chkCom.AutoSize = True
        Me.chkCom.BackColor = System.Drawing.Color.Transparent
        Me.chkCom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.chkCom, "Spuntare questa casella se il collaboratore fa parte dell'organico della federazi" & _
        "one")
        Me.chkCom.Location = New System.Drawing.Point(66, 61)
        Me.chkCom.Name = "chkCom"
        Me.HelpProvider1.SetShowHelp(Me.chkCom, True)
        Me.chkCom.Size = New System.Drawing.Size(127, 17)
        Me.chkCom.TabIndex = 2
        Me.chkCom.Text = "Componente struttura"
        Me.chkCom.UseVisualStyleBackColor = False
        '
        'txtCognome
        '
        Me.txtCognome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtCognome, "Cognome del collaboratore comunale")
        Me.txtCognome.Location = New System.Drawing.Point(66, 22)
        Me.txtCognome.Name = "txtCognome"
        Me.HelpProvider1.SetShowHelp(Me.txtCognome, True)
        Me.txtCognome.Size = New System.Drawing.Size(171, 20)
        Me.txtCognome.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Cognome"
        '
        'txtNome
        '
        Me.txtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtNome, "Nome del collaboratore comunale")
        Me.txtNome.Location = New System.Drawing.Point(290, 22)
        Me.txtNome.Name = "txtNome"
        Me.HelpProvider1.SetShowHelp(Me.txtNome, True)
        Me.txtNome.Size = New System.Drawing.Size(171, 20)
        Me.txtNome.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(249, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nome"
        '
        'txtPrdVe
        '
        Me.txtPrdVe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtPrdVe, "Percentuale di un incasso di una quota relativa ad una vertenza, seguita dal coll" & _
        "aboratore comunale, che viene ristornata al collaboratore in forma di provvigion" & _
        "e")
        Me.txtPrdVe.Location = New System.Drawing.Point(310, 111)
        Me.txtPrdVe.Name = "txtPrdVe"
        Me.HelpProvider1.SetShowHelp(Me.txtPrdVe, True)
        Me.txtPrdVe.Size = New System.Drawing.Size(53, 20)
        Me.txtPrdVe.TabIndex = 3
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(190, 113)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Perc. rist. Vertenze"
        '
        'txtPrdIn
        '
        Me.txtPrdIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtPrdIn, "Percentuale di un incasso di una quota relativa ad una prestazione Inps, compilat" & _
        "a dal collaboratore comunale, che viene ristornata al collaboratore in forma di " & _
        "provvigione")
        Me.txtPrdIn.Location = New System.Drawing.Point(111, 111)
        Me.txtPrdIn.Name = "txtPrdIn"
        Me.HelpProvider1.SetShowHelp(Me.txtPrdIn, True)
        Me.txtPrdIn.Size = New System.Drawing.Size(53, 20)
        Me.txtPrdIn.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Perc. rist. Inps"
        '
        'txtPrdIf
        '
        Me.txtPrdIf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtPrdIf, "Percentuale di un incasso di una quota relativa ad una delega del settore IMPIANT" & _
        "I FISSI, fatta sottoscrivere dal collaboratore comunale, che viene ristornata al" & _
        " collaboratore in forma di provvigione")
        Me.txtPrdIf.Location = New System.Drawing.Point(310, 75)
        Me.txtPrdIf.Name = "txtPrdIf"
        Me.HelpProvider1.SetShowHelp(Me.txtPrdIf, True)
        Me.txtPrdIf.Size = New System.Drawing.Size(53, 20)
        Me.txtPrdIf.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(189, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Perc. rist. Imp. Fissi"
        '
        'txtUltimoRistorno
        '
        Me.txtUltimoRistorno.Enabled = False
        Me.txtUltimoRistorno.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtUltimoRistorno, "Identificativo dell'ultimo ristorno effettuato al collaboratore comunale.")
        Me.txtUltimoRistorno.Location = New System.Drawing.Point(112, 152)
        Me.txtUltimoRistorno.Name = "txtUltimoRistorno"
        Me.HelpProvider1.SetShowHelp(Me.txtUltimoRistorno, True)
        Me.txtUltimoRistorno.Size = New System.Drawing.Size(91, 20)
        Me.txtUltimoRistorno.TabIndex = 4
        '
        'lblUltimo
        '
        Me.lblUltimo.AutoSize = True
        Me.lblUltimo.BackColor = System.Drawing.Color.Transparent
        Me.lblUltimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUltimo.Location = New System.Drawing.Point(16, 159)
        Me.lblUltimo.Name = "lblUltimo"
        Me.lblUltimo.Size = New System.Drawing.Size(73, 13)
        Me.lblUltimo.TabIndex = 17
        Me.lblUltimo.Text = "Ultimo ristorno"
        '
        'txtPrd
        '
        Me.txtPrd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtPrd, "Percentuale di un incasso di una quota relativa ad una delega del settore EDILE, " & _
        "fatta sottoscrivere dal collaboratore comunale, che viene ristornata al collabor" & _
        "atore in forma di provvigione")
        Me.txtPrd.Location = New System.Drawing.Point(111, 75)
        Me.txtPrd.Name = "txtPrd"
        Me.HelpProvider1.SetShowHelp(Me.txtPrd, True)
        Me.txtPrd.Size = New System.Drawing.Size(53, 20)
        Me.txtPrd.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Perc. rist. Edili"
        '
        'CustomBar1
        '
        Me.CustomBar1.BackColor = System.Drawing.Color.Transparent
        Me.CustomBar1.Location = New System.Drawing.Point(244, 1)
        Me.CustomBar1.Name = "CustomBar1"
        Me.CustomBar1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CustomBar1.Size = New System.Drawing.Size(294, 40)
        Me.CustomBar1.TabIndex = 10
        '
        'grpAnag
        '
        Me.grpAnag.Controls.Add(Me.TabControl1)
        Me.grpAnag.Location = New System.Drawing.Point(17, 73)
        Me.grpAnag.Name = "grpAnag"
        Me.grpAnag.Size = New System.Drawing.Size(595, 469)
        Me.grpAnag.TabIndex = 35
        Me.grpAnag.Title = "Dati collaboratore"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(14, 24)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(562, 430)
        Me.TabControl1.TabIndex = 7
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.CheckBox1)
        Me.TabPage1.Controls.Add(Me.Label23)
        Me.TabPage1.Controls.Add(Me.txtCap)
        Me.TabPage1.Controls.Add(Me.txtVia)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.Label17)
        Me.TabPage1.Controls.Add(Me.cboProvincia)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.cboComune)
        Me.TabPage1.Controls.Add(Me.Label21)
        Me.TabPage1.Controls.Add(Me.txtFax)
        Me.TabPage1.Controls.Add(Me.Label11)
        Me.TabPage1.Controls.Add(Me.txtMail)
        Me.TabPage1.Controls.Add(Me.Label19)
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.txtCell2)
        Me.TabPage1.Controls.Add(Me.Label18)
        Me.TabPage1.Controls.Add(Me.Label15)
        Me.TabPage1.Controls.Add(Me.txtCell1)
        Me.TabPage1.Controls.Add(Me.txtResp)
        Me.TabPage1.Controls.Add(Me.Label14)
        Me.TabPage1.Controls.Add(Me.txtTelUf)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.txtCognome)
        Me.TabPage1.Controls.Add(Me.chkCom)
        Me.TabPage1.Controls.Add(Me.txtNome)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(554, 404)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Collaboratore"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.CheckBox1, "Spuntare questa casella se il collaboratore fa parte di una camera comunle e non " & _
        "di una segreteria provinciale")
        Me.CheckBox1.Location = New System.Drawing.Point(370, 116)
        Me.CheckBox1.Name = "CheckBox1"
        Me.HelpProvider1.SetShowHelp(Me.CheckBox1, True)
        Me.CheckBox1.Size = New System.Drawing.Size(111, 17)
        Me.CheckBox1.TabIndex = 49
        Me.CheckBox1.Text = "Camera comunale"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(26, 120)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(250, 13)
        Me.Label23.TabIndex = 48
        Me.Label23.Text = "Indirizzo sede provinciale o comunale di riferimento"
        '
        'txtCap
        '
        Me.txtCap.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtCap, "CAP della sede provinciale o comunale")
        Me.txtCap.Location = New System.Drawing.Point(354, 213)
        Me.txtCap.Name = "txtCap"
        Me.HelpProvider1.SetShowHelp(Me.txtCap, True)
        Me.txtCap.Size = New System.Drawing.Size(135, 20)
        Me.txtCap.TabIndex = 6
        '
        'txtVia
        '
        Me.txtVia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtVia, "Indirizzo della sede legale della sede provinciale o comunale")
        Me.txtVia.Location = New System.Drawing.Point(60, 149)
        Me.txtVia.Name = "txtVia"
        Me.HelpProvider1.SetShowHelp(Me.txtVia, True)
        Me.txtVia.Size = New System.Drawing.Size(421, 20)
        Me.txtVia.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(17, 183)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 13)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "Prov."
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(323, 218)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(28, 13)
        Me.Label17.TabIndex = 43
        Me.Label17.Text = "CAP"
        '
        'cboProvincia
        '
        Me.cboProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProvincia.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboProvincia, "Provincia della sede provinciale o comunale")
        Me.cboProvincia.Location = New System.Drawing.Point(60, 180)
        Me.cboProvincia.Name = "cboProvincia"
        Me.HelpProvider1.SetShowHelp(Me.cboProvincia, True)
        Me.cboProvincia.Size = New System.Drawing.Size(232, 21)
        Me.cboProvincia.TabIndex = 4
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(6, 152)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(45, 13)
        Me.Label20.TabIndex = 41
        Me.Label20.Text = "Indirizzo"
        '
        'cboComune
        '
        Me.cboComune.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboComune.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboComune, "Comune della sede provinciale o comunale")
        Me.cboComune.Location = New System.Drawing.Point(60, 212)
        Me.cboComune.Name = "cboComune"
        Me.HelpProvider1.SetShowHelp(Me.cboComune, True)
        Me.cboComune.Size = New System.Drawing.Size(232, 21)
        Me.cboComune.TabIndex = 5
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(19, 216)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(31, 13)
        Me.Label21.TabIndex = 40
        Me.Label21.Text = "Com."
        '
        'txtFax
        '
        Me.txtFax.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtFax, "Numero di fax della sede provinciale o comunale")
        Me.txtFax.Location = New System.Drawing.Point(61, 345)
        Me.txtFax.Name = "txtFax"
        Me.HelpProvider1.SetShowHelp(Me.txtFax, True)
        Me.txtFax.Size = New System.Drawing.Size(196, 20)
        Me.txtFax.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(26, 258)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(249, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Contatti sede provinciale o comunale di riferimento"
        '
        'txtMail
        '
        Me.txtMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtMail, "Indirizzo di posta elettronica del responsabile della sede provinciale o comunale" & _
        "")
        Me.txtMail.Location = New System.Drawing.Point(307, 285)
        Me.txtMail.Name = "txtMail"
        Me.HelpProvider1.SetShowHelp(Me.txtMail, True)
        Me.txtMail.Size = New System.Drawing.Size(196, 20)
        Me.txtMail.TabIndex = 8
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(26, 348)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(24, 13)
        Me.Label19.TabIndex = 38
        Me.Label19.Text = "Fax"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(270, 288)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(26, 13)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "Mail"
        '
        'txtCell2
        '
        Me.txtCell2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtCell2, "Secondo numero di cellulare del responsabile della sede provinciale o comunale")
        Me.txtCell2.Location = New System.Drawing.Point(307, 345)
        Me.txtCell2.Name = "txtCell2"
        Me.HelpProvider1.SetShowHelp(Me.txtCell2, True)
        Me.txtCell2.Size = New System.Drawing.Size(196, 20)
        Me.txtCell2.TabIndex = 12
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(14, 290)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(35, 13)
        Me.Label18.TabIndex = 37
        Me.Label18.Text = "Resp."
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(263, 348)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 13)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "Cell.2"
        '
        'txtCell1
        '
        Me.txtCell1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtCell1, "Numero di cellulare del responsabile della sede provinciale o comunale")
        Me.txtCell1.Location = New System.Drawing.Point(307, 316)
        Me.txtCell1.Name = "txtCell1"
        Me.HelpProvider1.SetShowHelp(Me.txtCell1, True)
        Me.txtCell1.Size = New System.Drawing.Size(196, 20)
        Me.txtCell1.TabIndex = 10
        '
        'txtResp
        '
        Me.txtResp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtResp, "Responsabile della sede provinciale o comunale")
        Me.txtResp.Location = New System.Drawing.Point(60, 285)
        Me.txtResp.Name = "txtResp"
        Me.HelpProvider1.SetShowHelp(Me.txtResp, True)
        Me.txtResp.Size = New System.Drawing.Size(196, 20)
        Me.txtResp.TabIndex = 7
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(263, 319)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(33, 13)
        Me.Label14.TabIndex = 39
        Me.Label14.Text = "Cell.1"
        '
        'txtTelUf
        '
        Me.txtTelUf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.txtTelUf, "Numero di telefono della sede provinciale o comunale")
        Me.txtTelUf.Location = New System.Drawing.Point(61, 316)
        Me.txtTelUf.Name = "txtTelUf"
        Me.HelpProvider1.SetShowHelp(Me.txtTelUf, True)
        Me.txtTelUf.Size = New System.Drawing.Size(196, 20)
        Me.txtTelUf.TabIndex = 9
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(25, 319)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(25, 13)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "Tel."
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label22)
        Me.TabPage2.Controls.Add(Me.lblUltimo)
        Me.TabPage2.Controls.Add(Me.txtUltimoRistorno)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.txtPrdIf)
        Me.TabPage2.Controls.Add(Me.txtPrd)
        Me.TabPage2.Controls.Add(Me.txtPrdIn)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.txtPrdVe)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(554, 404)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Ristorni"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(16, 36)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(458, 13)
        Me.Label22.TabIndex = 26
        Me.Label22.Text = "Inserire le percentuali di ristorno al collaboratore comunale in base al tipo di " & _
    "quota corrisposta."
        '
        'IdReferenteTextBox1
        '
        Me.IdReferenteTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.IdReferenteTextBox1.DescriptionOfText = ""
        Me.IdReferenteTextBox1.DescriptionTextWidth = 150
        Me.IdReferenteTextBox1.DescriptionTextXValue = 92
        Me.IdReferenteTextBox1.EnableSerchTextBox = True
        Me.HelpProvider1.SetHelpString(Me.IdReferenteTextBox1, "Identificativo del collaboratore comunale")
        Me.IdReferenteTextBox1.IsDescriptionVisible = False
        Me.IdReferenteTextBox1.Location = New System.Drawing.Point(43, 11)
        Me.IdReferenteTextBox1.Mandatory = False
        Me.IdReferenteTextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.IdReferenteTextBox1.Name = "IdReferenteTextBox1"
        Me.HelpProvider1.SetShowHelp(Me.IdReferenteTextBox1, True)
        Me.IdReferenteTextBox1.Size = New System.Drawing.Size(104, 31)
        Me.IdReferenteTextBox1.TabIndex = 11
        Me.IdReferenteTextBox1.TextValue = ""
        '
        'SpNew
        '
        Me.SpNew.ApplyOutLookStile = True
        Me.SpNew.BackColor = System.Drawing.Color.Transparent
        Me.SpNew.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.file_new_32x32
        Me.SpNew.Disabled = False
        Me.SpNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SpNew.ForeColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.SpNew, "Funzione che permette di creare una nuova vertenza.")
        Me.SpNew.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SpNew.Location = New System.Drawing.Point(193, 6)
        Me.SpNew.Name = "SpNew"
        Me.SpNew.Radius = 32.0!
        Me.HelpProvider1.SetShowHelp(Me.SpNew, True)
        Me.SpNew.ShowTooltip = True
        Me.SpNew.Size = New System.Drawing.Size(32, 32)
        Me.SpNew.TabIndex = 118
        Me.SpNew.TextValue = ""
        Me.SpNew.TooltipText = "Crea nuova anagrafica"
        '
        'ControlAnagraficaReferente
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.grpAnag)
        Me.Name = "ControlAnagraficaReferente"
        Me.Size = New System.Drawing.Size(814, 566)
        Me.Controls.SetChildIndex(Me.DockPanel, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.grpAnag, 0)
        Me.DockPanel.ResumeLayout(False)
        Me.DockPanel.PerformLayout()
        Me.grpAnag.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
   Friend WithEvents lblId As System.Windows.Forms.Label
   Friend WithEvents txtCognome As System.Windows.Forms.TextBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents txtNome As System.Windows.Forms.TextBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents chkCom As System.Windows.Forms.CheckBox
   Friend WithEvents txtPrd As System.Windows.Forms.TextBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents txtUltimoRistorno As System.Windows.Forms.TextBox
   Friend WithEvents lblUltimo As System.Windows.Forms.Label
   Friend WithEvents txtPrdIn As System.Windows.Forms.TextBox
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents txtPrdIf As System.Windows.Forms.TextBox
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents CustomBar1 As WIN.GUI.APPLICATION.PRESENTATION.CustomBar
    Friend WithEvents txtPrdVe As System.Windows.Forms.TextBox
   Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents grpAnag As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents IdReferenteTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox
   Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
   Friend WithEvents SpNew As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
   Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
   Friend WithEvents txtFax As System.Windows.Forms.TextBox
   Friend WithEvents Label11 As System.Windows.Forms.Label
   Friend WithEvents txtMail As System.Windows.Forms.TextBox
   Friend WithEvents Label19 As System.Windows.Forms.Label
   Friend WithEvents Label16 As System.Windows.Forms.Label
   Friend WithEvents txtCell2 As System.Windows.Forms.TextBox
   Friend WithEvents Label18 As System.Windows.Forms.Label
   Friend WithEvents Label15 As System.Windows.Forms.Label
   Friend WithEvents txtCell1 As System.Windows.Forms.TextBox
   Friend WithEvents txtResp As System.Windows.Forms.TextBox
   Friend WithEvents Label14 As System.Windows.Forms.Label
   Friend WithEvents txtTelUf As System.Windows.Forms.TextBox
   Friend WithEvents Label13 As System.Windows.Forms.Label
   Friend WithEvents txtCap As System.Windows.Forms.TextBox
   Friend WithEvents txtVia As System.Windows.Forms.TextBox
   Friend WithEvents Label12 As System.Windows.Forms.Label
   Friend WithEvents Label17 As System.Windows.Forms.Label
   Friend WithEvents cboProvincia As System.Windows.Forms.ComboBox
   Friend WithEvents Label20 As System.Windows.Forms.Label
   Friend WithEvents cboComune As System.Windows.Forms.ComboBox
   Friend WithEvents Label21 As System.Windows.Forms.Label
   Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
   Friend WithEvents Label22 As System.Windows.Forms.Label
   Friend WithEvents Label23 As System.Windows.Forms.Label
   Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox

End Class
