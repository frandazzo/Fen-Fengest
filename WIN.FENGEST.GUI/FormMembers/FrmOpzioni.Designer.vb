<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOpzioni
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOpzioni))
        Me.cmdOk = New System.Windows.Forms.Button
        Me.cmdAnnulla = New System.Windows.Forms.Button
        Me.CmdApplica = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.chkDefaultPosIF = New System.Windows.Forms.CheckBox
        Me.chkPaybility = New System.Windows.Forms.CheckBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.chkVisualizzaFile = New System.Windows.Forms.CheckBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtRecordMax = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtNaz = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtPro = New System.Windows.Forms.TextBox
        Me.txtCom = New System.Windows.Forms.TextBox
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.TabControl2 = New System.Windows.Forms.TabControl
        Me.TabPage6 = New System.Windows.Forms.TabPage
        Me.GridUtentiTagger = New System.Windows.Forms.DataGridView
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GridSereteriaTagger = New System.Windows.Forms.DataGridView
        Me.TabPage7 = New System.Windows.Forms.TabPage
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.lstTagSpeciali = New System.Windows.Forms.ListBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Templates = New System.Windows.Forms.TabPage
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.cmdDeleghe = New System.Windows.Forms.Button
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.cmdIQA = New System.Windows.Forms.Button
        Me.TabPage8 = New System.Windows.Forms.TabPage
        Me.cmdPathModelli = New System.Windows.Forms.Button
        Me.txtPathModelli = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Button4 = New System.Windows.Forms.Button
        Me.txtPathDefaultCartelleAziende = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.txtPathDefaultCartelleUtenti = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        CType(Me.GridUtentiTagger, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.GridSereteriaTagger, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage7.SuspendLayout()
        Me.Templates.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdOk
        '
        Me.cmdOk.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.OK
        Me.cmdOk.Location = New System.Drawing.Point(280, 395)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(60, 27)
        Me.cmdOk.TabIndex = 0
        Me.cmdOk.Text = "Ok"
        Me.cmdOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'cmdAnnulla
        '
        Me.cmdAnnulla.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.GotoShortcutsHS
        Me.cmdAnnulla.Location = New System.Drawing.Point(346, 395)
        Me.cmdAnnulla.Name = "cmdAnnulla"
        Me.cmdAnnulla.Size = New System.Drawing.Size(70, 27)
        Me.cmdAnnulla.TabIndex = 1
        Me.cmdAnnulla.Text = "Annulla"
        Me.cmdAnnulla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAnnulla.UseVisualStyleBackColor = True
        '
        'CmdApplica
        '
        Me.CmdApplica.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.saveHS
        Me.CmdApplica.Location = New System.Drawing.Point(422, 395)
        Me.CmdApplica.Name = "CmdApplica"
        Me.CmdApplica.Size = New System.Drawing.Size(66, 27)
        Me.CmdApplica.TabIndex = 2
        Me.CmdApplica.Text = "Applica"
        Me.CmdApplica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.CmdApplica.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.Templates)
        Me.TabControl1.Controls.Add(Me.TabPage8)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(480, 377)
        Me.TabControl1.TabIndex = 3
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox6)
        Me.TabPage2.Controls.Add(Me.GroupBox5)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(472, 351)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Applicazione"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.chkDefaultPosIF)
        Me.GroupBox6.Controls.Add(Me.chkPaybility)
        Me.GroupBox6.Location = New System.Drawing.Point(21, 252)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(410, 73)
        Me.GroupBox6.TabIndex = 14
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Incassi quote"
        '
        'chkDefaultPosIF
        '
        Me.chkDefaultPosIF.AutoSize = True
        Me.chkDefaultPosIF.Location = New System.Drawing.Point(19, 47)
        Me.chkDefaultPosIF.Name = "chkDefaultPosIF"
        Me.chkDefaultPosIF.Size = New System.Drawing.Size(253, 17)
        Me.chkDefaultPosIF.TabIndex = 13
        Me.chkDefaultPosIF.Text = "Crea posizioni di default per aziende impianti fissi"
        Me.chkDefaultPosIF.UseVisualStyleBackColor = True
        '
        'chkPaybility
        '
        Me.chkPaybility.AutoSize = True
        Me.chkPaybility.Checked = True
        Me.chkPaybility.CheckState = System.Windows.Forms.CheckState.Checked
        Me.HelpProvider1.SetHelpString(Me.chkPaybility, resources.GetString("chkPaybility.HelpString"))
        Me.chkPaybility.Location = New System.Drawing.Point(19, 19)
        Me.chkPaybility.Name = "chkPaybility"
        Me.HelpProvider1.SetShowHelp(Me.chkPaybility, True)
        Me.chkPaybility.Size = New System.Drawing.Size(156, 17)
        Me.chkPaybility.TabIndex = 12
        Me.chkPaybility.Text = "Verifica pagabilità posizione"
        Me.chkPaybility.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.chkVisualizzaFile)
        Me.GroupBox5.Location = New System.Drawing.Point(21, 195)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(410, 48)
        Me.GroupBox5.TabIndex = 11
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Prestazioni"
        '
        'chkVisualizzaFile
        '
        Me.chkVisualizzaFile.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.chkVisualizzaFile, "Spuntare questa casella se si vuole visualizzare le prestazioni autocompilate al " & _
                "momento del loro salvataggio sul sistema.")
        Me.chkVisualizzaFile.Location = New System.Drawing.Point(16, 22)
        Me.chkVisualizzaFile.Name = "chkVisualizzaFile"
        Me.HelpProvider1.SetShowHelp(Me.chkVisualizzaFile, True)
        Me.chkVisualizzaFile.Size = New System.Drawing.Size(189, 17)
        Me.chkVisualizzaFile.TabIndex = 10
        Me.chkVisualizzaFile.Text = "Visualizza file output al salvataggio"
        Me.chkVisualizzaFile.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtRecordMax)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Location = New System.Drawing.Point(21, 138)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(410, 47)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Ricerche oggetti"
        '
        'txtRecordMax
        '
        Me.txtRecordMax.Location = New System.Drawing.Point(208, 16)
        Me.txtRecordMax.Name = "txtRecordMax"
        Me.txtRecordMax.Size = New System.Drawing.Size(56, 20)
        Me.txtRecordMax.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(185, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Massimo numero di oggetti per ricerca"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtNaz)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.txtPro)
        Me.GroupBox3.Controls.Add(Me.txtCom)
        Me.GroupBox3.Location = New System.Drawing.Point(21, 18)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(410, 115)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Valori geografici default"
        '
        'txtNaz
        '
        Me.HelpProvider1.SetHelpString(Me.txtNaz, "Nazione di default che verrà visualizzato al momento della creazione di una nuova" & _
                " anagrafica utente o azienda")
        Me.txtNaz.Location = New System.Drawing.Point(107, 81)
        Me.txtNaz.Name = "txtNaz"
        Me.HelpProvider1.SetShowHelp(Me.txtNaz, True)
        Me.txtNaz.Size = New System.Drawing.Size(211, 20)
        Me.txtNaz.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Comune di default"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Provincia di defalut"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nazione di default"
        '
        'txtPro
        '
        Me.HelpProvider1.SetHelpString(Me.txtPro, "Provincia di default che verrà visualizzato al momento della creazione di una nuo" & _
                "va anagrafica utente o azienda")
        Me.txtPro.Location = New System.Drawing.Point(107, 49)
        Me.txtPro.Name = "txtPro"
        Me.HelpProvider1.SetShowHelp(Me.txtPro, True)
        Me.txtPro.Size = New System.Drawing.Size(211, 20)
        Me.txtPro.TabIndex = 4
        '
        'txtCom
        '
        Me.HelpProvider1.SetHelpString(Me.txtCom, "Comune di default che verrà visualizzato al momento della creazione di una nuova " & _
                "anagrafica utente o azienda")
        Me.txtCom.Location = New System.Drawing.Point(107, 20)
        Me.txtCom.Name = "txtCom"
        Me.HelpProvider1.SetShowHelp(Me.txtCom, True)
        Me.txtCom.Size = New System.Drawing.Size(211, 20)
        Me.txtCom.TabIndex = 3
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.TabControl2)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(472, 351)
        Me.TabPage5.TabIndex = 5
        Me.TabPage5.Text = "Comunicazioni"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage6)
        Me.TabControl2.Controls.Add(Me.TabPage1)
        Me.TabControl2.Controls.Add(Me.TabPage7)
        Me.TabControl2.Location = New System.Drawing.Point(28, 20)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(397, 315)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.GridUtentiTagger)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage6.Size = New System.Drawing.Size(389, 289)
        Me.TabPage6.TabIndex = 0
        Me.TabPage6.Text = "Tag utenti"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'GridUtentiTagger
        '
        Me.GridUtentiTagger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridUtentiTagger.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridUtentiTagger.Location = New System.Drawing.Point(3, 3)
        Me.GridUtentiTagger.Name = "GridUtentiTagger"
        Me.GridUtentiTagger.ReadOnly = True
        Me.GridUtentiTagger.Size = New System.Drawing.Size(383, 283)
        Me.GridUtentiTagger.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GridSereteriaTagger)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(389, 289)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Tag segreteria"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GridSereteriaTagger
        '
        Me.GridSereteriaTagger.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridSereteriaTagger.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridSereteriaTagger.Location = New System.Drawing.Point(3, 3)
        Me.GridSereteriaTagger.Name = "GridSereteriaTagger"
        Me.GridSereteriaTagger.ReadOnly = True
        Me.GridSereteriaTagger.Size = New System.Drawing.Size(383, 283)
        Me.GridSereteriaTagger.TabIndex = 1
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.TextBox2)
        Me.TabPage7.Controls.Add(Me.Label6)
        Me.TabPage7.Controls.Add(Me.TextBox1)
        Me.TabPage7.Controls.Add(Me.Label5)
        Me.TabPage7.Controls.Add(Me.lstTagSpeciali)
        Me.TabPage7.Controls.Add(Me.Label14)
        Me.TabPage7.Location = New System.Drawing.Point(4, 22)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage7.Size = New System.Drawing.Size(389, 289)
        Me.TabPage7.TabIndex = 1
        Me.TabPage7.Text = "Tag speciali"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.HelpProvider1.SetHelpString(Me.TextBox2, "Il seguente tag imposta la data corrente ")
        Me.TextBox2.Location = New System.Drawing.Point(30, 206)
        Me.TextBox2.Name = "TextBox2"
        Me.HelpProvider1.SetShowHelp(Me.TextBox2, True)
        Me.TextBox2.Size = New System.Drawing.Size(157, 20)
        Me.TextBox2.TabIndex = 5
        Me.TextBox2.Text = "@DataCorrente@"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(29, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Tag data corrente"
        '
        'TextBox1
        '
        Me.HelpProvider1.SetHelpString(Me.TextBox1, "Il seguente tag imposta il nome e cognome dell'utente  corrente ")
        Me.TextBox1.Location = New System.Drawing.Point(28, 143)
        Me.TextBox1.Name = "TextBox1"
        Me.HelpProvider1.SetShowHelp(Me.TextBox1, True)
        Me.TextBox1.Size = New System.Drawing.Size(157, 20)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "@OperatoreCorrente@"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Tag operatore corrente"
        '
        'lstTagSpeciali
        '
        Me.lstTagSpeciali.FormattingEnabled = True
        Me.lstTagSpeciali.Items.AddRange(New Object() {"Valore tag speciale 1 = @Tag1@", "Valore tag speciale 2 = @Tag2@", "Valore tag speciale 3 = @Tag3@"})
        Me.lstTagSpeciali.Location = New System.Drawing.Point(21, 24)
        Me.lstTagSpeciali.Name = "lstTagSpeciali"
        Me.lstTagSpeciali.Size = New System.Drawing.Size(181, 56)
        Me.lstTagSpeciali.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(18, 7)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(113, 13)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Lista valori tag speciali"
        '
        'Templates
        '
        Me.Templates.Controls.Add(Me.GroupBox9)
        Me.Templates.Controls.Add(Me.GroupBox8)
        Me.Templates.Controls.Add(Me.GroupBox7)
        Me.Templates.Location = New System.Drawing.Point(4, 22)
        Me.Templates.Name = "Templates"
        Me.Templates.Padding = New System.Windows.Forms.Padding(3)
        Me.Templates.Size = New System.Drawing.Size(472, 351)
        Me.Templates.TabIndex = 3
        Me.Templates.Text = "Template import"
        Me.Templates.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Button2)
        Me.GroupBox9.Location = New System.Drawing.Point(18, 222)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(405, 51)
        Me.GroupBox9.TabIndex = 5
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Lavoratori liberi"
        '
        'Button2
        '
        Me.HelpProvider1.SetHelpString(Me.Button2, "Funzione che permette di importare la lista dei lavoratori liberi qualora questa " & _
                "sia fornita dagli enti bilaterali alla federazione.")
        Me.Button2.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.OpenSelectedItemHS
        Me.Button2.Location = New System.Drawing.Point(229, 11)
        Me.Button2.Name = "Button2"
        Me.HelpProvider1.SetShowHelp(Me.Button2, True)
        Me.Button2.Size = New System.Drawing.Size(146, 32)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Importazione liberi"
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.cmdDeleghe)
        Me.GroupBox8.Location = New System.Drawing.Point(18, 121)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(406, 48)
        Me.GroupBox8.TabIndex = 4
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Deleghe"
        '
        'cmdDeleghe
        '
        Me.cmdDeleghe.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.OpenSelectedItemHS
        Me.cmdDeleghe.Location = New System.Drawing.Point(229, 10)
        Me.cmdDeleghe.Name = "cmdDeleghe"
        Me.cmdDeleghe.Size = New System.Drawing.Size(146, 32)
        Me.cmdDeleghe.TabIndex = 1
        Me.cmdDeleghe.Text = "Importazione deleghe"
        Me.cmdDeleghe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdDeleghe.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.cmdIQA)
        Me.GroupBox7.Location = New System.Drawing.Point(18, 22)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(407, 50)
        Me.GroupBox7.TabIndex = 3
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Incassi quote associative e previsionali"
        '
        'cmdIQA
        '
        Me.HelpProvider1.SetHelpString(Me.cmdIQA, "Funzione che permette di importare le quote associative da incassare dai file ele" & _
                "ttronici che gli enti bilaterali o l'azienda forniscono periodicamente alla fede" & _
                "razione.")
        Me.cmdIQA.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.OpenSelectedItemHS
        Me.cmdIQA.Location = New System.Drawing.Point(229, 15)
        Me.cmdIQA.Name = "cmdIQA"
        Me.HelpProvider1.SetShowHelp(Me.cmdIQA, True)
        Me.cmdIQA.Size = New System.Drawing.Size(146, 29)
        Me.cmdIQA.TabIndex = 0
        Me.cmdIQA.Text = "Importazione IQA"
        Me.cmdIQA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdIQA.UseVisualStyleBackColor = True
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.cmdPathModelli)
        Me.TabPage8.Controls.Add(Me.txtPathModelli)
        Me.TabPage8.Controls.Add(Me.Label15)
        Me.TabPage8.Controls.Add(Me.Button4)
        Me.TabPage8.Controls.Add(Me.txtPathDefaultCartelleAziende)
        Me.TabPage8.Controls.Add(Me.Label18)
        Me.TabPage8.Controls.Add(Me.Button3)
        Me.TabPage8.Controls.Add(Me.txtPathDefaultCartelleUtenti)
        Me.TabPage8.Controls.Add(Me.Label17)
        Me.TabPage8.Location = New System.Drawing.Point(4, 22)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage8.Size = New System.Drawing.Size(472, 351)
        Me.TabPage8.TabIndex = 6
        Me.TabPage8.Text = "Percorsi di default"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'cmdPathModelli
        '
        Me.HelpProvider1.SetHelpString(Me.cmdPathModelli, "Funzione che permette di selezionare il percorso dei modelli in formato elettroni" & _
                "co utilizzati per l'autocompilazione di prestazioni,per la comunicazione massiva" & _
                "...")
        Me.cmdPathModelli.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.openHS
        Me.cmdPathModelli.Location = New System.Drawing.Point(337, 172)
        Me.cmdPathModelli.Name = "cmdPathModelli"
        Me.HelpProvider1.SetShowHelp(Me.cmdPathModelli, True)
        Me.cmdPathModelli.Size = New System.Drawing.Size(82, 41)
        Me.cmdPathModelli.TabIndex = 12
        Me.cmdPathModelli.Text = "Seleziona percorso"
        Me.cmdPathModelli.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdPathModelli.UseVisualStyleBackColor = True
        '
        'txtPathModelli
        '
        Me.txtPathModelli.Enabled = False
        Me.HelpProvider1.SetHelpString(Me.txtPathModelli, "selezionare il percorso dei modelli in formato elettronico utilizzati per l'autoc" & _
                "ompilazione di prestazioni,per la comunicazione massiva...")
        Me.txtPathModelli.Location = New System.Drawing.Point(18, 172)
        Me.txtPathModelli.Multiline = True
        Me.txtPathModelli.Name = "txtPathModelli"
        Me.HelpProvider1.SetShowHelp(Me.txtPathModelli, True)
        Me.txtPathModelli.Size = New System.Drawing.Size(313, 41)
        Me.txtPathModelli.TabIndex = 11
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(17, 156)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(84, 13)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "Percorso modelli"
        '
        'Button4
        '
        Me.HelpProvider1.SetHelpString(Me.Button4, "Funzione che permette di selezionare il percorso della cartella di default che il" & _
                " sistema suggerisce automaticamente al momento della creazione dell'archivio doc" & _
                "umentale dell'azienda")
        Me.Button4.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.openHS
        Me.Button4.Location = New System.Drawing.Point(335, 101)
        Me.Button4.Name = "Button4"
        Me.HelpProvider1.SetShowHelp(Me.Button4, True)
        Me.Button4.Size = New System.Drawing.Size(82, 41)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Seleziona percorso"
        Me.Button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txtPathDefaultCartelleAziende
        '
        Me.txtPathDefaultCartelleAziende.Enabled = False
        Me.HelpProvider1.SetHelpString(Me.txtPathDefaultCartelleAziende, "percorso della cartella di default che il sistema suggerisce automaticamente al m" & _
                "omento della creazione dell'archivio documentale dell'azienda")
        Me.txtPathDefaultCartelleAziende.Location = New System.Drawing.Point(16, 101)
        Me.txtPathDefaultCartelleAziende.Multiline = True
        Me.txtPathDefaultCartelleAziende.Name = "txtPathDefaultCartelleAziende"
        Me.HelpProvider1.SetShowHelp(Me.txtPathDefaultCartelleAziende, True)
        Me.txtPathDefaultCartelleAziende.Size = New System.Drawing.Size(313, 41)
        Me.txtPathDefaultCartelleAziende.TabIndex = 8
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(15, 85)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(151, 13)
        Me.Label18.TabIndex = 7
        Me.Label18.Text = "Suggerimento Cartelle Aziende"
        '
        'Button3
        '
        Me.HelpProvider1.SetHelpString(Me.Button3, "Funzione che permette di selezionare il percorso della cartella di default che il" & _
                " sistema suggerisce automaticamente al momento della creazione dell'archivio doc" & _
                "umentale dell'utente.")
        Me.Button3.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.openHS
        Me.Button3.Location = New System.Drawing.Point(335, 31)
        Me.Button3.Name = "Button3"
        Me.HelpProvider1.SetShowHelp(Me.Button3, True)
        Me.Button3.Size = New System.Drawing.Size(82, 41)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Seleziona percorso"
        Me.Button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtPathDefaultCartelleUtenti
        '
        Me.txtPathDefaultCartelleUtenti.Enabled = False
        Me.HelpProvider1.SetHelpString(Me.txtPathDefaultCartelleUtenti, "percorso della cartella di default che il sistema suggerisce automaticamente al m" & _
                "omento della creazione dell'archivio documentale dell'utente.")
        Me.txtPathDefaultCartelleUtenti.Location = New System.Drawing.Point(16, 31)
        Me.txtPathDefaultCartelleUtenti.Multiline = True
        Me.txtPathDefaultCartelleUtenti.Name = "txtPathDefaultCartelleUtenti"
        Me.HelpProvider1.SetShowHelp(Me.txtPathDefaultCartelleUtenti, True)
        Me.txtPathDefaultCartelleUtenti.Size = New System.Drawing.Size(313, 41)
        Me.txtPathDefaultCartelleUtenti.TabIndex = 5
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(15, 15)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(141, 13)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "Suggerimento Cartelle Utenti"
        '
        'FrmOpzioni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 432)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.CmdApplica)
        Me.Controls.Add(Me.cmdAnnulla)
        Me.Controls.Add(Me.cmdOk)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmOpzioni"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Opzioni"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.TabPage5.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage6.ResumeLayout(False)
        CType(Me.GridUtentiTagger, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.GridSereteriaTagger, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage7.ResumeLayout(False)
        Me.TabPage7.PerformLayout()
        Me.Templates.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.TabPage8.ResumeLayout(False)
        Me.TabPage8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
   Friend WithEvents cmdOk As System.Windows.Forms.Button
   Friend WithEvents cmdAnnulla As System.Windows.Forms.Button
   Friend WithEvents CmdApplica As System.Windows.Forms.Button
   Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
   Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents txtNaz As System.Windows.Forms.TextBox
   Friend WithEvents txtPro As System.Windows.Forms.TextBox
   Friend WithEvents txtCom As System.Windows.Forms.TextBox
   Friend WithEvents txtRecordMax As System.Windows.Forms.TextBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents Templates As System.Windows.Forms.TabPage
   Friend WithEvents cmdDeleghe As System.Windows.Forms.Button
   Friend WithEvents cmdIQA As System.Windows.Forms.Button
   Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
   Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
   Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
   Friend WithEvents GridUtentiTagger As System.Windows.Forms.DataGridView
   Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
   Friend WithEvents lstTagSpeciali As System.Windows.Forms.ListBox
   Friend WithEvents Label14 As System.Windows.Forms.Label
   Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
   Friend WithEvents Button2 As System.Windows.Forms.Button
   Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
   Friend WithEvents Button3 As System.Windows.Forms.Button
   Friend WithEvents txtPathDefaultCartelleUtenti As System.Windows.Forms.TextBox
   Friend WithEvents Label17 As System.Windows.Forms.Label
   Friend WithEvents Button4 As System.Windows.Forms.Button
   Friend WithEvents txtPathDefaultCartelleAziende As System.Windows.Forms.TextBox
   Friend WithEvents Label18 As System.Windows.Forms.Label
   Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
   Friend WithEvents chkDefaultPosIF As System.Windows.Forms.CheckBox
   Friend WithEvents chkPaybility As System.Windows.Forms.CheckBox
   Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
   Friend WithEvents chkVisualizzaFile As System.Windows.Forms.CheckBox
   Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
   Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
   Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
   Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
   Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
   Friend WithEvents cmdPathModelli As System.Windows.Forms.Button
   Friend WithEvents txtPathModelli As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
   Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
   Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
   Friend WithEvents GridSereteriaTagger As System.Windows.Forms.DataGridView
   Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
   Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
