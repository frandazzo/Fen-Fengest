<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlTipoPrestazioni
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlTipoPrestazioni))
      Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Me.MainGroup = New WIN.GUI.UTILITY.NiceGroupBox
      Me.PictureBox1 = New System.Windows.Forms.PictureBox
      Me.txtDir = New System.Windows.Forms.Label
      Me.SpAddFile = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.Label2 = New System.Windows.Forms.Label
      Me.SpCartella = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.lblDocumento = New System.Windows.Forms.Label
      Me.SpView = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.Label4 = New System.Windows.Forms.Label
      Me.Label1 = New System.Windows.Forms.Label
      Me.txtCod = New System.Windows.Forms.TextBox
      Me.Label3 = New System.Windows.Forms.Label
      Me.txtDescr = New System.Windows.Forms.TextBox
      Me.txtId = New System.Windows.Forms.TextBox
      Me.lblId = New System.Windows.Forms.Label
      Me.Panel1 = New System.Windows.Forms.Panel
      Me.GridPosizioni = New System.Windows.Forms.DataGridView
      Me.CustomBar1 = New WIN.GUI.APPLICATION.PRESENTATION.CustomBar
      Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
      Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
      Me.NiceGroupBox1 = New WIN.GUI.UTILITY.NiceGroupBox
      Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
      Me.DockPanel.SuspendLayout()
      Me.MainGroup.SuspendLayout()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.Panel1.SuspendLayout()
      CType(Me.GridPosizioni, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.NiceGroupBox1.SuspendLayout()
      Me.SuspendLayout()
      '
      'Panel2
      '
      Me.Panel2.Size = New System.Drawing.Size(674, 22)
      '
      'DockPanel
      '
      Me.DockPanel.Controls.Add(Me.txtId)
      Me.DockPanel.Controls.Add(Me.lblId)
      Me.DockPanel.Controls.Add(Me.CustomBar1)
      Me.DockPanel.Location = New System.Drawing.Point(0, 22)
      Me.DockPanel.Size = New System.Drawing.Size(674, 44)
      '
      'MainGroup
      '
      Me.MainGroup.BackColor = System.Drawing.Color.LightGray
      Me.MainGroup.Controls.Add(Me.PictureBox1)
      Me.MainGroup.Controls.Add(Me.txtDir)
      Me.MainGroup.Controls.Add(Me.SpAddFile)
      Me.MainGroup.Controls.Add(Me.Label2)
      Me.MainGroup.Controls.Add(Me.SpCartella)
      Me.MainGroup.Controls.Add(Me.lblDocumento)
      Me.MainGroup.Controls.Add(Me.SpView)
      Me.MainGroup.Controls.Add(Me.Label4)
      Me.MainGroup.Controls.Add(Me.Label1)
      Me.MainGroup.Controls.Add(Me.txtCod)
      Me.MainGroup.Controls.Add(Me.Label3)
      Me.MainGroup.Controls.Add(Me.txtDescr)
      Me.MainGroup.ForeColor = System.Drawing.SystemColors.ControlText
      Me.MainGroup.Location = New System.Drawing.Point(11, 83)
      Me.MainGroup.Name = "MainGroup"
      Me.MainGroup.Size = New System.Drawing.Size(402, 233)
      Me.MainGroup.TabIndex = 27
      Me.MainGroup.Title = "Tipo prestazione selezionato"
      '
      'PictureBox1
      '
      Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
      Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.PictureBox1.Location = New System.Drawing.Point(357, 144)
      Me.PictureBox1.Name = "PictureBox1"
      Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
      Me.PictureBox1.TabIndex = 78
      Me.PictureBox1.TabStop = False
      '
      'txtDir
      '
      Me.txtDir.AutoEllipsis = True
      Me.txtDir.AutoSize = True
      Me.txtDir.BackColor = System.Drawing.Color.Transparent
      Me.txtDir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.HelpProvider1.SetHelpString(Me.txtDir, resources.GetString("txtDir.HelpString"))
      Me.txtDir.Location = New System.Drawing.Point(90, 98)
      Me.txtDir.MaximumSize = New System.Drawing.Size(293, 0)
      Me.txtDir.Name = "txtDir"
      Me.HelpProvider1.SetShowHelp(Me.txtDir, True)
      Me.txtDir.Size = New System.Drawing.Size(100, 13)
      Me.txtDir.TabIndex = 77
      Me.txtDir.Text = "Nessun percorso"
      '
      'SpAddFile
      '
      Me.SpAddFile.ApplyOutLookStile = True
      Me.SpAddFile.BackColor = System.Drawing.Color.Transparent
      Me.SpAddFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.SpAddFile.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.file_add_32x32
      Me.SpAddFile.Disabled = False
      Me.SpAddFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.SpAddFile.ForeColor = System.Drawing.Color.Transparent
      Me.HelpProvider1.SetHelpString(Me.SpAddFile, "Funzione che permette di aggiungere un file da autocompilare per il tipo di prest" & _
              "azione correntemente selezionato.")
      Me.SpAddFile.Location = New System.Drawing.Point(12, 144)
      Me.SpAddFile.Name = "SpAddFile"
      Me.SpAddFile.Radius = 32.0!
      Me.HelpProvider1.SetShowHelp(Me.SpAddFile, True)
      Me.SpAddFile.ShowTooltip = True
      Me.SpAddFile.Size = New System.Drawing.Size(32, 32)
      Me.SpAddFile.TabIndex = 55
      Me.SpAddFile.TextValue = ""
      Me.SpAddFile.TooltipText = "Allega file modello"
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(9, 190)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(65, 13)
      Me.Label2.TabIndex = 76
      Me.Label2.Text = "Documento:"
      '
      'SpCartella
      '
      Me.SpCartella.ApplyOutLookStile = True
      Me.SpCartella.BackColor = System.Drawing.Color.Transparent
      Me.SpCartella.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.SpCartella.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.folder_open_32x32
      Me.SpCartella.Disabled = False
      Me.SpCartella.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.SpCartella.ForeColor = System.Drawing.Color.Transparent
      Me.HelpProvider1.SetHelpString(Me.SpCartella, resources.GetString("SpCartella.HelpString"))
      Me.SpCartella.Location = New System.Drawing.Point(89, 144)
      Me.SpCartella.Name = "SpCartella"
      Me.SpCartella.Radius = 32.0!
      Me.HelpProvider1.SetShowHelp(Me.SpCartella, True)
      Me.SpCartella.ShowTooltip = True
      Me.SpCartella.Size = New System.Drawing.Size(32, 32)
      Me.SpCartella.TabIndex = 54
      Me.SpCartella.TextValue = ""
      Me.SpCartella.TooltipText = "Seleziona cartella di output"
      '
      'lblDocumento
      '
      Me.lblDocumento.AutoEllipsis = True
      Me.lblDocumento.AutoSize = True
      Me.lblDocumento.BackColor = System.Drawing.Color.Transparent
      Me.lblDocumento.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblDocumento.Location = New System.Drawing.Point(89, 190)
      Me.lblDocumento.MaximumSize = New System.Drawing.Size(293, 0)
      Me.lblDocumento.Name = "lblDocumento"
      Me.lblDocumento.Size = New System.Drawing.Size(114, 13)
      Me.lblDocumento.TabIndex = 75
      Me.lblDocumento.Text = "Nessun documento"
      '
      'SpView
      '
      Me.SpView.ApplyOutLookStile = True
      Me.SpView.BackColor = System.Drawing.Color.Transparent
      Me.SpView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.SpView.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.file_view_32x32
      Me.SpView.Disabled = False
      Me.SpView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.SpView.ForeColor = System.Drawing.Color.Transparent
      Me.HelpProvider1.SetHelpString(Me.SpView, "Funzione che permette di visualizzare il file del modello allegato al tipo di pre" & _
              "stazione correntemente selezionato.")
      Me.SpView.Location = New System.Drawing.Point(50, 144)
      Me.SpView.Name = "SpView"
      Me.SpView.Radius = 32.0!
      Me.HelpProvider1.SetShowHelp(Me.SpView, True)
      Me.SpView.ShowTooltip = True
      Me.SpView.Size = New System.Drawing.Size(32, 32)
      Me.SpView.TabIndex = 39
      Me.SpView.TextValue = ""
      Me.SpView.TooltipText = "Apri file modello"
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.BackColor = System.Drawing.Color.Transparent
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.Location = New System.Drawing.Point(7, 98)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(67, 13)
      Me.Label4.TabIndex = 46
      Me.Label4.Text = "Dir. di output"
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Location = New System.Drawing.Point(35, 67)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(39, 13)
      Me.Label1.TabIndex = 43
      Me.Label1.Text = "Codice"
      '
      'txtCod
      '
      Me.HelpProvider1.SetHelpString(Me.txtCod, "Codice associato al tipo di prestazione correntemente selezionato.")
      Me.txtCod.Location = New System.Drawing.Point(92, 61)
      Me.txtCod.Multiline = True
      Me.txtCod.Name = "txtCod"
      Me.HelpProvider1.SetShowHelp(Me.txtCod, True)
      Me.txtCod.Size = New System.Drawing.Size(72, 21)
      Me.txtCod.TabIndex = 44
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Location = New System.Drawing.Point(13, 38)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(61, 13)
      Me.Label3.TabIndex = 28
      Me.Label3.Text = "Descrizione"
      '
      'txtDescr
      '
      Me.HelpProvider1.SetHelpString(Me.txtDescr, "Descrizione del tipo di prestazione correntemente selezionato.Essa può essere mod" & _
              "ificata e salvata.")
      Me.txtDescr.Location = New System.Drawing.Point(92, 32)
      Me.txtDescr.Multiline = True
      Me.txtDescr.Name = "txtDescr"
      Me.HelpProvider1.SetShowHelp(Me.txtDescr, True)
      Me.txtDescr.Size = New System.Drawing.Size(150, 21)
      Me.txtDescr.TabIndex = 29
      '
      'txtId
      '
      Me.txtId.Enabled = False
      Me.txtId.Location = New System.Drawing.Point(43, 13)
      Me.txtId.Name = "txtId"
      Me.txtId.Size = New System.Drawing.Size(53, 21)
      Me.txtId.TabIndex = 50
      '
      'lblId
      '
      Me.lblId.AutoSize = True
      Me.lblId.BackColor = System.Drawing.Color.Transparent
      Me.lblId.Location = New System.Drawing.Point(21, 16)
      Me.lblId.Name = "lblId"
      Me.lblId.Size = New System.Drawing.Size(17, 13)
      Me.lblId.TabIndex = 49
      Me.lblId.Text = "Id"
      '
      'Panel1
      '
      Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Panel1.Controls.Add(Me.GridPosizioni)
      Me.Panel1.Location = New System.Drawing.Point(5, 22)
      Me.Panel1.Name = "Panel1"
      Me.Panel1.Size = New System.Drawing.Size(600, 175)
      Me.Panel1.TabIndex = 36
      '
      'GridPosizioni
      '
      DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue
      DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
      DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange
      DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
      Me.GridPosizioni.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
      Me.GridPosizioni.BackgroundColor = System.Drawing.Color.WhiteSmoke
      Me.GridPosizioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
      DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
      DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
      DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
      DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
      Me.GridPosizioni.DefaultCellStyle = DataGridViewCellStyle2
      Me.GridPosizioni.Dock = System.Windows.Forms.DockStyle.Fill
      Me.GridPosizioni.Location = New System.Drawing.Point(0, 0)
      Me.GridPosizioni.Name = "GridPosizioni"
      Me.GridPosizioni.RowHeadersVisible = False
      DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
      DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Orange
      DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
      Me.GridPosizioni.RowsDefaultCellStyle = DataGridViewCellStyle3
      Me.GridPosizioni.Size = New System.Drawing.Size(600, 175)
      Me.GridPosizioni.TabIndex = 1
      '
      'CustomBar1
      '
      Me.CustomBar1.BackColor = System.Drawing.Color.Transparent
      Me.CustomBar1.Location = New System.Drawing.Point(107, 2)
      Me.CustomBar1.Name = "CustomBar1"
      Me.CustomBar1.Size = New System.Drawing.Size(293, 40)
      Me.CustomBar1.TabIndex = 38
      '
      'OpenFileDialog1
      '
      Me.OpenFileDialog1.FileName = "OpenFileDialog1"
      '
      'NiceGroupBox1
      '
      Me.NiceGroupBox1.Controls.Add(Me.Panel1)
      Me.HelpProvider1.SetHelpString(Me.NiceGroupBox1, resources.GetString("NiceGroupBox1.HelpString"))
      Me.NiceGroupBox1.Location = New System.Drawing.Point(11, 322)
      Me.NiceGroupBox1.Name = "NiceGroupBox1"
      Me.HelpProvider1.SetShowHelp(Me.NiceGroupBox1, True)
      Me.NiceGroupBox1.Size = New System.Drawing.Size(610, 200)
      Me.NiceGroupBox1.TabIndex = 38
      Me.NiceGroupBox1.Title = "Riepilogo tipi prestazioni"
      '
      'ControlTipoPrestazioni
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.Controls.Add(Me.MainGroup)
      Me.Controls.Add(Me.NiceGroupBox1)
      Me.Name = "ControlTipoPrestazioni"
      Me.Size = New System.Drawing.Size(674, 525)
      Me.Controls.SetChildIndex(Me.NiceGroupBox1, 0)
      Me.Controls.SetChildIndex(Me.MainGroup, 0)
      Me.Controls.SetChildIndex(Me.DockPanel, 0)
      Me.Controls.SetChildIndex(Me.Panel2, 0)
      Me.DockPanel.ResumeLayout(False)
      Me.DockPanel.PerformLayout()
      Me.MainGroup.ResumeLayout(False)
      Me.MainGroup.PerformLayout()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.Panel1.ResumeLayout(False)
      CType(Me.GridPosizioni, System.ComponentModel.ISupportInitialize).EndInit()
      Me.NiceGroupBox1.ResumeLayout(False)
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents MainGroup As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents txtDescr As System.Windows.Forms.TextBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents txtCod As System.Windows.Forms.TextBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents txtId As System.Windows.Forms.TextBox
   Friend WithEvents lblId As System.Windows.Forms.Label
   Friend WithEvents Panel1 As System.Windows.Forms.Panel
   Friend WithEvents CustomBar1 As WIN.GUI.APPLICATION.PRESENTATION.CustomBar
   Friend WithEvents SpAddFile As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents SpCartella As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents SpView As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
   Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents lblDocumento As System.Windows.Forms.Label
   Friend WithEvents NiceGroupBox1 As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents GridPosizioni As System.Windows.Forms.DataGridView
   Friend WithEvents txtDir As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider

End Class
