<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIscritti
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIscritti))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.NiceGroupBox1 = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.rptIQP = New System.Windows.Forms.RadioButton()
        Me.rptIQA = New System.Windows.Forms.RadioButton()
        Me.cboSettori = New System.Windows.Forms.ComboBox()
        Me.lblSettore = New System.Windows.Forms.Label()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.ControlSelPeriodiMensili1 = New WIN.GUI.APPLICATION.PRESENTATION.ControlSelPeriodiMensili()
        Me.chkVer = New System.Windows.Forms.CheckBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.NiceGroupBox2 = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.GridIscritti = New System.Windows.Forms.DataGridView()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.NiceGroupBox3 = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.GridNonIscrittiCassaEdile = New System.Windows.Forms.DataGridView()
        Me.NiceGroupBox4 = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.GridNonIscrittiEdilcassa = New System.Windows.Forms.DataGridView()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.NiceGroupBox1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.NiceGroupBox2.SuspendLayout()
        CType(Me.GridIscritti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.NiceGroupBox3.SuspendLayout()
        CType(Me.GridNonIscrittiCassaEdile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NiceGroupBox4.SuspendLayout()
        CType(Me.GridNonIscrittiEdilcassa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NiceGroupBox1
        '
        Me.NiceGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NiceGroupBox1.Controls.Add(Me.rptIQP)
        Me.NiceGroupBox1.Controls.Add(Me.rptIQA)
        Me.NiceGroupBox1.Controls.Add(Me.cboSettori)
        Me.NiceGroupBox1.Controls.Add(Me.lblSettore)
        Me.NiceGroupBox1.Controls.Add(Me.cmdSearch)
        Me.NiceGroupBox1.Controls.Add(Me.ControlSelPeriodiMensili1)
        Me.NiceGroupBox1.Controls.Add(Me.chkVer)
        Me.NiceGroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.NiceGroupBox1.Name = "NiceGroupBox1"
        Me.NiceGroupBox1.Size = New System.Drawing.Size(691, 100)
        Me.NiceGroupBox1.TabIndex = 0
        Me.NiceGroupBox1.Title = "Dati selezione"
        '
        'rptIQP
        '
        Me.rptIQP.AutoSize = True
        Me.rptIQP.Location = New System.Drawing.Point(547, 28)
        Me.rptIQP.Name = "rptIQP"
        Me.rptIQP.Size = New System.Drawing.Size(107, 17)
        Me.rptIQP.TabIndex = 3
        Me.rptIQP.Text = "QuotePrevisionali"
        Me.rptIQP.UseVisualStyleBackColor = True
        '
        'rptIQA
        '
        Me.rptIQA.AutoSize = True
        Me.rptIQA.Checked = True
        Me.rptIQA.Location = New System.Drawing.Point(431, 28)
        Me.rptIQA.Name = "rptIQA"
        Me.rptIQA.Size = New System.Drawing.Size(110, 17)
        Me.rptIQA.TabIndex = 2
        Me.rptIQA.TabStop = True
        Me.rptIQA.Text = "Quote associative"
        Me.rptIQA.UseVisualStyleBackColor = True
        '
        'cboSettori
        '
        Me.cboSettori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSettori.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSettori.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboSettori, "Settore di pertinenza delle deleghe.Essi possono essere EDILE e IMPIANTI FISSI. S" & _
        "e selezionato,il report conterrà soltanto le deleghe di pertinenza di quel setto" & _
        "re.")
        Me.cboSettori.Location = New System.Drawing.Point(56, 63)
        Me.cboSettori.Name = "cboSettori"
        Me.HelpProvider1.SetShowHelp(Me.cboSettori, True)
        Me.cboSettori.Size = New System.Drawing.Size(162, 21)
        Me.cboSettori.TabIndex = 5
        '
        'lblSettore
        '
        Me.lblSettore.AutoSize = True
        Me.lblSettore.BackColor = System.Drawing.Color.Transparent
        Me.lblSettore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSettore.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettore.Location = New System.Drawing.Point(12, 67)
        Me.lblSettore.Name = "lblSettore"
        Me.lblSettore.Size = New System.Drawing.Size(41, 13)
        Me.lblSettore.TabIndex = 4
        Me.lblSettore.Text = "Settore"
        '
        'cmdSearch
        '
        Me.cmdSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HelpProvider1.SetHelpString(Me.cmdSearch, resources.GetString("cmdSearch.HelpString"))
        Me.cmdSearch.Location = New System.Drawing.Point(606, 67)
        Me.cmdSearch.Name = "cmdSearch"
        Me.HelpProvider1.SetShowHelp(Me.cmdSearch, True)
        Me.cmdSearch.Size = New System.Drawing.Size(71, 24)
        Me.cmdSearch.TabIndex = 0
        Me.cmdSearch.Text = "Cerca"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'ControlSelPeriodiMensili1
        '
        Me.ControlSelPeriodiMensili1.BackColor = System.Drawing.Color.Transparent
        Me.ControlSelPeriodiMensili1.Location = New System.Drawing.Point(18, 26)
        Me.ControlSelPeriodiMensili1.Name = "ControlSelPeriodiMensili1"
        Me.ControlSelPeriodiMensili1.Size = New System.Drawing.Size(394, 31)
        Me.ControlSelPeriodiMensili1.TabIndex = 1
        '
        'chkVer
        '
        Me.chkVer.AutoSize = True
        Me.chkVer.BackColor = System.Drawing.Color.Transparent
        Me.chkVer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpProvider1.SetHelpString(Me.chkVer, resources.GetString("chkVer.HelpString"))
        Me.chkVer.Location = New System.Drawing.Point(240, 65)
        Me.chkVer.Name = "chkVer"
        Me.HelpProvider1.SetShowHelp(Me.chkVer, True)
        Me.chkVer.Size = New System.Drawing.Size(172, 17)
        Me.chkVer.TabIndex = 6
        Me.chkVer.Text = "Verifica esistenza delega attiva"
        Me.chkVer.UseVisualStyleBackColor = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(13, 118)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.NiceGroupBox2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(690, 487)
        Me.SplitContainer1.SplitterDistance = 150
        Me.SplitContainer1.TabIndex = 2
        '
        'NiceGroupBox2
        '
        Me.NiceGroupBox2.Controls.Add(Me.GridIscritti)
        Me.NiceGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NiceGroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.NiceGroupBox2.Name = "NiceGroupBox2"
        Me.NiceGroupBox2.Size = New System.Drawing.Size(690, 150)
        Me.NiceGroupBox2.TabIndex = 0
        Me.NiceGroupBox2.Title = "Lavoratori iscritti"
        '
        'GridIscritti
        '
        Me.GridIscritti.AllowUserToAddRows = False
        Me.GridIscritti.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.GridIscritti.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GridIscritti.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridIscritti.BackgroundColor = System.Drawing.Color.White
        Me.GridIscritti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridIscritti.Location = New System.Drawing.Point(16, 25)
        Me.GridIscritti.MultiSelect = False
        Me.GridIscritti.Name = "GridIscritti"
        Me.GridIscritti.ReadOnly = True
        Me.GridIscritti.RowHeadersVisible = False
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.GridIscritti.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.GridIscritti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.GridIscritti.Size = New System.Drawing.Size(663, 122)
        Me.GridIscritti.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.NiceGroupBox3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.NiceGroupBox4)
        Me.SplitContainer2.Size = New System.Drawing.Size(690, 333)
        Me.SplitContainer2.SplitterDistance = 167
        Me.SplitContainer2.TabIndex = 1
        '
        'NiceGroupBox3
        '
        Me.NiceGroupBox3.Controls.Add(Me.GridNonIscrittiCassaEdile)
        Me.NiceGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NiceGroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.NiceGroupBox3.Name = "NiceGroupBox3"
        Me.NiceGroupBox3.Size = New System.Drawing.Size(690, 167)
        Me.NiceGroupBox3.TabIndex = 0
        Me.NiceGroupBox3.Title = "Lavoratori non iscritti Cassa edile"
        '
        'GridNonIscrittiCassaEdile
        '
        Me.GridNonIscrittiCassaEdile.AllowUserToAddRows = False
        Me.GridNonIscrittiCassaEdile.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.GridNonIscrittiCassaEdile.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.GridNonIscrittiCassaEdile.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridNonIscrittiCassaEdile.BackgroundColor = System.Drawing.Color.White
        Me.GridNonIscrittiCassaEdile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridNonIscrittiCassaEdile.Location = New System.Drawing.Point(15, 26)
        Me.GridNonIscrittiCassaEdile.MultiSelect = False
        Me.GridNonIscrittiCassaEdile.Name = "GridNonIscrittiCassaEdile"
        Me.GridNonIscrittiCassaEdile.ReadOnly = True
        Me.GridNonIscrittiCassaEdile.RowHeadersVisible = False
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.GridNonIscrittiCassaEdile.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.GridNonIscrittiCassaEdile.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.GridNonIscrittiCassaEdile.Size = New System.Drawing.Size(662, 133)
        Me.GridNonIscrittiCassaEdile.TabIndex = 0
        '
        'NiceGroupBox4
        '
        Me.NiceGroupBox4.Controls.Add(Me.GridNonIscrittiEdilcassa)
        Me.NiceGroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NiceGroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.NiceGroupBox4.Name = "NiceGroupBox4"
        Me.NiceGroupBox4.Size = New System.Drawing.Size(690, 162)
        Me.NiceGroupBox4.TabIndex = 0
        Me.NiceGroupBox4.Title = "Lavoratori non iscritti Edilcassa"
        '
        'GridNonIscrittiEdilcassa
        '
        Me.GridNonIscrittiEdilcassa.AllowUserToAddRows = False
        Me.GridNonIscrittiEdilcassa.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.GridNonIscrittiEdilcassa.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.GridNonIscrittiEdilcassa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridNonIscrittiEdilcassa.BackgroundColor = System.Drawing.Color.White
        Me.GridNonIscrittiEdilcassa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridNonIscrittiEdilcassa.Location = New System.Drawing.Point(15, 26)
        Me.GridNonIscrittiEdilcassa.MultiSelect = False
        Me.GridNonIscrittiEdilcassa.Name = "GridNonIscrittiEdilcassa"
        Me.GridNonIscrittiEdilcassa.ReadOnly = True
        Me.GridNonIscrittiEdilcassa.RowHeadersVisible = False
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.GridNonIscrittiEdilcassa.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.GridNonIscrittiEdilcassa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.GridNonIscrittiEdilcassa.Size = New System.Drawing.Size(662, 128)
        Me.GridNonIscrittiEdilcassa.TabIndex = 0
        '
        'cmdClose
        '
        Me.cmdClose.Location = New System.Drawing.Point(600, 614)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(92, 30)
        Me.cmdClose.TabIndex = 1
        Me.cmdClose.Text = "&Chiudi"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(483, 614)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(111, 30)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "&Esporta su Excel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmIscritti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(715, 653)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdClose)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.NiceGroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "FrmIscritti"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lavoratori azienda"
        Me.NiceGroupBox1.ResumeLayout(False)
        Me.NiceGroupBox1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.NiceGroupBox2.ResumeLayout(False)
        CType(Me.GridIscritti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.NiceGroupBox3.ResumeLayout(False)
        CType(Me.GridNonIscrittiCassaEdile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NiceGroupBox4.ResumeLayout(False)
        CType(Me.GridNonIscrittiEdilcassa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
   Friend WithEvents ControlSelPeriodiMensili1 As WIN.GUI.APPLICATION.PRESENTATION.ControlSelPeriodiMensili
   Friend WithEvents NiceGroupBox1 As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents chkVer As System.Windows.Forms.CheckBox
   Friend WithEvents cmdSearch As System.Windows.Forms.Button
   Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
   Friend WithEvents NiceGroupBox2 As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents GridIscritti As System.Windows.Forms.DataGridView
   Friend WithEvents NiceGroupBox3 As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents GridNonIscrittiCassaEdile As System.Windows.Forms.DataGridView
   Friend WithEvents cboSettori As System.Windows.Forms.ComboBox
   Friend WithEvents lblSettore As System.Windows.Forms.Label
   Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
   Friend WithEvents NiceGroupBox4 As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents GridNonIscrittiEdilcassa As System.Windows.Forms.DataGridView
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents rptIQP As System.Windows.Forms.RadioButton
    Friend WithEvents rptIQA As System.Windows.Forms.RadioButton
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
