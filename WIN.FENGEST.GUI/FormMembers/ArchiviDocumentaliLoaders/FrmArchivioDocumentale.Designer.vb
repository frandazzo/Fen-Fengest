<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmArchivioDocumentale
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
      Me.components = New System.ComponentModel.Container
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmArchivioDocumentale))
      Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ARCHIVIO DOCUMENTI")
      Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("COMUNICAZIONI", 4, 4)
      Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("PRESTAZIONI", 4, 4)
      Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("VERTENZE", 4, 4)
      Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("DOCUMENTI ATTIVITA'", 0, 0, New System.Windows.Forms.TreeNode() {TreeNode2, TreeNode3, TreeNode4})
      Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
      Me.Panel2 = New System.Windows.Forms.Panel
      Me.cmdSeleziona = New System.Windows.Forms.Button
      Me.txtCartella = New System.Windows.Forms.TextBox
      Me.Label5 = New System.Windows.Forms.Label
      Me.DockPanel2 = New System.Windows.Forms.Panel
      Me.cmdSetDefaultFolder = New System.Windows.Forms.Button
      Me.cmdViewPathDefault = New System.Windows.Forms.Button
      Me.cmdMoveFile = New System.Windows.Forms.Button
      Me.SplitContainer4 = New System.Windows.Forms.SplitContainer
      Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
      Me.TreeView1 = New System.Windows.Forms.TreeView
      Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
      Me.DockPanel = New System.Windows.Forms.Panel
      Me.cmdSearch = New System.Windows.Forms.Button
      Me.txtSearch = New System.Windows.Forms.TextBox
      Me.cmdDown = New System.Windows.Forms.Button
      Me.cmdUp = New System.Windows.Forms.Button
      Me.cmdInfoFile = New System.Windows.Forms.Button
      Me.cmdViewPath = New System.Windows.Forms.Button
      Me.cmdView = New System.Windows.Forms.Button
      Me.cmdRename = New System.Windows.Forms.Button
      Me.cmdRemoveFile = New System.Windows.Forms.Button
      Me.cmdAddFile = New System.Windows.Forms.Button
      Me.datagridview1 = New System.Windows.Forms.DataGridView
      Me.SplitContainer5 = New System.Windows.Forms.SplitContainer
      Me.SplitContainer3 = New System.Windows.Forms.SplitContainer
      Me.TreeView2 = New System.Windows.Forms.TreeView
      Me.datagridviewAttivita = New System.Windows.Forms.DataGridView
      Me.DocPanel1 = New System.Windows.Forms.Panel
      Me.cmdSearchAtt = New System.Windows.Forms.Button
      Me.txtSearchAtt = New System.Windows.Forms.TextBox
      Me.cmdDownAtt = New System.Windows.Forms.Button
      Me.cmdUpAtt = New System.Windows.Forms.Button
      Me.cmdBrowse = New System.Windows.Forms.Button
      Me.cmdInfoFileAttivita = New System.Windows.Forms.Button
      Me.cmdViewPathAttivita = New System.Windows.Forms.Button
      Me.cmdViiewFileAttività = New System.Windows.Forms.Button
      Me.cmdClose = New System.Windows.Forms.Button
      Me.lblNumDocs = New System.Windows.Forms.Label
      Me.cmdOk = New System.Windows.Forms.Button
      Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
      Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
      Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
      Me.SplitContainer1.Panel1.SuspendLayout()
      Me.SplitContainer1.Panel2.SuspendLayout()
      Me.SplitContainer1.SuspendLayout()
      Me.Panel2.SuspendLayout()
      Me.DockPanel2.SuspendLayout()
      Me.SplitContainer4.Panel1.SuspendLayout()
      Me.SplitContainer4.Panel2.SuspendLayout()
      Me.SplitContainer4.SuspendLayout()
      Me.SplitContainer2.Panel1.SuspendLayout()
      Me.SplitContainer2.Panel2.SuspendLayout()
      Me.SplitContainer2.SuspendLayout()
      Me.DockPanel.SuspendLayout()
      CType(Me.datagridview1, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SplitContainer5.Panel1.SuspendLayout()
      Me.SplitContainer5.Panel2.SuspendLayout()
      Me.SplitContainer5.SuspendLayout()
      Me.SplitContainer3.Panel1.SuspendLayout()
      Me.SplitContainer3.Panel2.SuspendLayout()
      Me.SplitContainer3.SuspendLayout()
      CType(Me.datagridviewAttivita, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.DocPanel1.SuspendLayout()
      Me.SuspendLayout()
      '
      'SplitContainer1
      '
      Me.SplitContainer1.BackColor = System.Drawing.Color.White
      Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
      Me.SplitContainer1.Name = "SplitContainer1"
      Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
      '
      'SplitContainer1.Panel1
      '
      Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.White
      Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
      Me.SplitContainer1.Panel1.Controls.Add(Me.DockPanel2)
      '
      'SplitContainer1.Panel2
      '
      Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer4)
      Me.SplitContainer1.Size = New System.Drawing.Size(752, 442)
      Me.SplitContainer1.SplitterDistance = 107
      Me.SplitContainer1.TabIndex = 0
      '
      'Panel2
      '
      Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.Panel2.Controls.Add(Me.cmdSeleziona)
      Me.Panel2.Controls.Add(Me.txtCartella)
      Me.Panel2.Controls.Add(Me.Label5)
      Me.Panel2.Location = New System.Drawing.Point(3, 39)
      Me.Panel2.Name = "Panel2"
      Me.Panel2.Size = New System.Drawing.Size(746, 65)
      Me.Panel2.TabIndex = 1
      '
      'cmdSeleziona
      '
      Me.cmdSeleziona.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.cmdSeleziona.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.HelpProvider1.SetHelpString(Me.cmdSeleziona, resources.GetString("cmdSeleziona.HelpString"))
      Me.cmdSeleziona.Location = New System.Drawing.Point(605, 29)
      Me.cmdSeleziona.Name = "cmdSeleziona"
      Me.HelpProvider1.SetShowHelp(Me.cmdSeleziona, True)
      Me.cmdSeleziona.Size = New System.Drawing.Size(125, 23)
      Me.cmdSeleziona.TabIndex = 1
      Me.cmdSeleziona.Text = "Seleziona percorso"
      Me.cmdSeleziona.UseVisualStyleBackColor = True
      '
      'txtCartella
      '
      Me.txtCartella.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.txtCartella.Enabled = False
      Me.txtCartella.Location = New System.Drawing.Point(13, 31)
      Me.txtCartella.Name = "txtCartella"
      Me.txtCartella.Size = New System.Drawing.Size(588, 20)
      Me.txtCartella.TabIndex = 0
      '
      'Label5
      '
      Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Label5.AutoSize = True
      Me.Label5.BackColor = System.Drawing.Color.Transparent
      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.Location = New System.Drawing.Point(10, 15)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(77, 13)
      Me.Label5.TabIndex = 16
      Me.Label5.Text = "Cartella default"
      '
      'DockPanel2
      '
      Me.DockPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.DockPanel2.BackColor = System.Drawing.Color.Transparent
      Me.DockPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.DockPanel2.Controls.Add(Me.cmdSetDefaultFolder)
      Me.DockPanel2.Controls.Add(Me.cmdViewPathDefault)
      Me.DockPanel2.Controls.Add(Me.cmdMoveFile)
      Me.DockPanel2.Location = New System.Drawing.Point(2, 2)
      Me.DockPanel2.Margin = New System.Windows.Forms.Padding(1, 0, 0, 0)
      Me.DockPanel2.Name = "DockPanel2"
      Me.DockPanel2.Size = New System.Drawing.Size(748, 35)
      Me.DockPanel2.TabIndex = 0
      '
      'cmdSetDefaultFolder
      '
      Me.cmdSetDefaultFolder.BackgroundImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.file_broken_32x32
      Me.HelpProvider1.SetHelpString(Me.cmdSetDefaultFolder, "Funzione che permette di impostare la cartella di default per l'utente.Questa fun" & _
              "zione non fa altro che preparare il sistema alla modifica.")
      Me.cmdSetDefaultFolder.Location = New System.Drawing.Point(38, 0)
      Me.cmdSetDefaultFolder.Name = "cmdSetDefaultFolder"
      Me.HelpProvider1.SetShowHelp(Me.cmdSetDefaultFolder, True)
      Me.cmdSetDefaultFolder.Size = New System.Drawing.Size(37, 33)
      Me.cmdSetDefaultFolder.TabIndex = 2
      Me.cmdSetDefaultFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
      Me.ToolTip1.SetToolTip(Me.cmdSetDefaultFolder, "Imposta cartella default")
      Me.cmdSetDefaultFolder.UseVisualStyleBackColor = True
      '
      'cmdViewPathDefault
      '
      Me.cmdViewPathDefault.BackgroundImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.folder_open_32x32
      Me.HelpProvider1.SetHelpString(Me.cmdViewPathDefault, "Funzione che permette di aprire la cartella di default dell'utente per visualizza" & _
              "rne il contenuto.")
      Me.cmdViewPathDefault.Location = New System.Drawing.Point(2, 0)
      Me.cmdViewPathDefault.Name = "cmdViewPathDefault"
      Me.HelpProvider1.SetShowHelp(Me.cmdViewPathDefault, True)
      Me.cmdViewPathDefault.Size = New System.Drawing.Size(37, 33)
      Me.cmdViewPathDefault.TabIndex = 1
      Me.cmdViewPathDefault.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
      Me.ToolTip1.SetToolTip(Me.cmdViewPathDefault, "Visualizza percorso")
      Me.cmdViewPathDefault.UseVisualStyleBackColor = True
      '
      'cmdMoveFile
      '
      Me.cmdMoveFile.BackgroundImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.k_multiple_32x32_1_2
      Me.HelpProvider1.SetHelpString(Me.cmdMoveFile, "Funzione che permette di importare un nuovo file nella cartella di default impost" & _
              "ata per l'utente.")
      Me.cmdMoveFile.Location = New System.Drawing.Point(74, 0)
      Me.cmdMoveFile.Name = "cmdMoveFile"
      Me.HelpProvider1.SetShowHelp(Me.cmdMoveFile, True)
      Me.cmdMoveFile.Size = New System.Drawing.Size(37, 33)
      Me.cmdMoveFile.TabIndex = 0
      Me.cmdMoveFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
      Me.ToolTip1.SetToolTip(Me.cmdMoveFile, "Importa file")
      Me.cmdMoveFile.UseVisualStyleBackColor = True
      Me.cmdMoveFile.Visible = False
      '
      'SplitContainer4
      '
      Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
      Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
      Me.SplitContainer4.Name = "SplitContainer4"
      Me.SplitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal
      '
      'SplitContainer4.Panel1
      '
      Me.SplitContainer4.Panel1.Controls.Add(Me.SplitContainer2)
      '
      'SplitContainer4.Panel2
      '
      Me.SplitContainer4.Panel2.Controls.Add(Me.SplitContainer5)
      Me.SplitContainer4.Size = New System.Drawing.Size(752, 331)
      Me.SplitContainer4.SplitterDistance = 134
      Me.SplitContainer4.TabIndex = 0
      '
      'SplitContainer2
      '
      Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
      Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
      Me.SplitContainer2.Name = "SplitContainer2"
      '
      'SplitContainer2.Panel1
      '
      Me.SplitContainer2.Panel1.Controls.Add(Me.TreeView1)
      '
      'SplitContainer2.Panel2
      '
      Me.SplitContainer2.Panel2.Controls.Add(Me.DockPanel)
      Me.SplitContainer2.Panel2.Controls.Add(Me.datagridview1)
      Me.SplitContainer2.Size = New System.Drawing.Size(752, 134)
      Me.SplitContainer2.SplitterDistance = 188
      Me.SplitContainer2.TabIndex = 0
      '
      'TreeView1
      '
      Me.TreeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.TreeView1.ImageIndex = 0
      Me.TreeView1.ImageList = Me.ImageList1
      Me.TreeView1.Location = New System.Drawing.Point(0, 0)
      Me.TreeView1.Name = "TreeView1"
      TreeNode1.Name = "Nodo0"
      TreeNode1.Text = "ARCHIVIO DOCUMENTI"
      Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1})
      Me.TreeView1.SelectedImageIndex = 0
      Me.TreeView1.Size = New System.Drawing.Size(188, 134)
      Me.TreeView1.TabIndex = 0
      '
      'ImageList1
      '
      Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
      Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
      Me.ImageList1.Images.SetKeyName(0, "openfolderHS.png")
      Me.ImageList1.Images.SetKeyName(1, "error-32x32-2.png")
      Me.ImageList1.Images.SetKeyName(2, "edu-languages-32x32-2.png")
      Me.ImageList1.Images.SetKeyName(3, "prestiti-48x48.png")
      Me.ImageList1.Images.SetKeyName(4, "outicon.exe (33).ico")
      '
      'DockPanel
      '
      Me.DockPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.DockPanel.BackColor = System.Drawing.Color.Transparent
      Me.DockPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.DockPanel.Controls.Add(Me.cmdSearch)
      Me.DockPanel.Controls.Add(Me.txtSearch)
      Me.DockPanel.Controls.Add(Me.cmdDown)
      Me.DockPanel.Controls.Add(Me.cmdUp)
      Me.DockPanel.Controls.Add(Me.cmdInfoFile)
      Me.DockPanel.Controls.Add(Me.cmdViewPath)
      Me.DockPanel.Controls.Add(Me.cmdView)
      Me.DockPanel.Controls.Add(Me.cmdRename)
      Me.DockPanel.Controls.Add(Me.cmdRemoveFile)
      Me.DockPanel.Controls.Add(Me.cmdAddFile)
      Me.DockPanel.Location = New System.Drawing.Point(3, 0)
      Me.DockPanel.Margin = New System.Windows.Forms.Padding(1, 0, 0, 0)
      Me.DockPanel.Name = "DockPanel"
      Me.DockPanel.Size = New System.Drawing.Size(554, 35)
      Me.DockPanel.TabIndex = 0
      '
      'cmdSearch
      '
      Me.cmdSearch.BackgroundImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.ActualSizeHS
      Me.cmdSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.HelpProvider1.SetHelpString(Me.cmdSearch, "Funzione che permette di visualizzare il file selezionato.")
      Me.cmdSearch.Location = New System.Drawing.Point(512, 0)
      Me.cmdSearch.Name = "cmdSearch"
      Me.HelpProvider1.SetShowHelp(Me.cmdSearch, True)
      Me.cmdSearch.Size = New System.Drawing.Size(37, 33)
      Me.cmdSearch.TabIndex = 9
      Me.cmdSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
      Me.ToolTip1.SetToolTip(Me.cmdSearch, "ricerca documenti")
      Me.cmdSearch.UseVisualStyleBackColor = True
      '
      'txtSearch
      '
      Me.HelpProvider1.SetHelpString(Me.txtSearch, resources.GetString("txtSearch.HelpString"))
      Me.txtSearch.Location = New System.Drawing.Point(353, 7)
      Me.txtSearch.Name = "txtSearch"
      Me.HelpProvider1.SetShowHelp(Me.txtSearch, True)
      Me.txtSearch.Size = New System.Drawing.Size(153, 20)
      Me.txtSearch.TabIndex = 8
      '
      'cmdDown
      '
      Me.cmdDown.BackgroundImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.package_edutainment_48x48_down
      Me.cmdDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
      Me.HelpProvider1.SetHelpString(Me.cmdDown, "Funzione che permette di ottenere informazioni sul file selezionato ( creato da, " & _
              "data creazione...)")
      Me.cmdDown.Location = New System.Drawing.Point(295, 1)
      Me.cmdDown.Name = "cmdDown"
      Me.HelpProvider1.SetShowHelp(Me.cmdDown, True)
      Me.cmdDown.Size = New System.Drawing.Size(37, 33)
      Me.cmdDown.TabIndex = 7
      Me.cmdDown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
      Me.ToolTip1.SetToolTip(Me.cmdDown, "Ordina dal basso")
      Me.cmdDown.UseVisualStyleBackColor = True
      '
      'cmdUp
      '
      Me.cmdUp.BackgroundImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.package_edutainment_48x48_up
      Me.cmdUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
      Me.HelpProvider1.SetHelpString(Me.cmdUp, "Funzione che permette di visualizzare il percorso del file selezionato.")
      Me.cmdUp.Location = New System.Drawing.Point(259, 1)
      Me.cmdUp.Name = "cmdUp"
      Me.HelpProvider1.SetShowHelp(Me.cmdUp, True)
      Me.cmdUp.Size = New System.Drawing.Size(37, 33)
      Me.cmdUp.TabIndex = 6
      Me.cmdUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
      Me.ToolTip1.SetToolTip(Me.cmdUp, "Ordina dall'alto")
      Me.cmdUp.UseVisualStyleBackColor = True
      '
      'cmdInfoFile
      '
      Me.cmdInfoFile.BackgroundImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.info_32x32_active
      Me.HelpProvider1.SetHelpString(Me.cmdInfoFile, "Funzione che permette di ottenere informazioni sul file selezionato ( creato da, " & _
              "data creazione...)")
      Me.cmdInfoFile.Location = New System.Drawing.Point(198, 0)
      Me.cmdInfoFile.Name = "cmdInfoFile"
      Me.HelpProvider1.SetShowHelp(Me.cmdInfoFile, True)
      Me.cmdInfoFile.Size = New System.Drawing.Size(37, 33)
      Me.cmdInfoFile.TabIndex = 5
      Me.cmdInfoFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
      Me.ToolTip1.SetToolTip(Me.cmdInfoFile, "Informazioni file")
      Me.cmdInfoFile.UseVisualStyleBackColor = True
      '
      'cmdViewPath
      '
      Me.cmdViewPath.BackgroundImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.folder_open_32x32
      Me.HelpProvider1.SetHelpString(Me.cmdViewPath, "Funzione che permette di visualizzare il percorso del file selezionato.")
      Me.cmdViewPath.Location = New System.Drawing.Point(162, 0)
      Me.cmdViewPath.Name = "cmdViewPath"
      Me.HelpProvider1.SetShowHelp(Me.cmdViewPath, True)
      Me.cmdViewPath.Size = New System.Drawing.Size(37, 33)
      Me.cmdViewPath.TabIndex = 4
      Me.cmdViewPath.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
      Me.ToolTip1.SetToolTip(Me.cmdViewPath, "Visualizza percorso")
      Me.cmdViewPath.UseVisualStyleBackColor = True
      '
      'cmdView
      '
      Me.cmdView.BackgroundImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.file_view_32x32
      Me.HelpProvider1.SetHelpString(Me.cmdView, "Funzione che permette di visualizzare il file selezionato.")
      Me.cmdView.Location = New System.Drawing.Point(126, 0)
      Me.cmdView.Name = "cmdView"
      Me.HelpProvider1.SetShowHelp(Me.cmdView, True)
      Me.cmdView.Size = New System.Drawing.Size(37, 33)
      Me.cmdView.TabIndex = 3
      Me.cmdView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
      Me.ToolTip1.SetToolTip(Me.cmdView, "Visualizza file")
      Me.cmdView.UseVisualStyleBackColor = True
      '
      'cmdRename
      '
      Me.cmdRename.BackgroundImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.desktop_32x32
      Me.HelpProvider1.SetHelpString(Me.cmdRename, "Funzione che permette di rinominare un file")
      Me.cmdRename.Location = New System.Drawing.Point(75, 0)
      Me.cmdRename.Name = "cmdRename"
      Me.HelpProvider1.SetShowHelp(Me.cmdRename, True)
      Me.cmdRename.Size = New System.Drawing.Size(37, 33)
      Me.cmdRename.TabIndex = 2
      Me.cmdRename.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
      Me.ToolTip1.SetToolTip(Me.cmdRename, "Rinomina file")
      Me.cmdRename.UseVisualStyleBackColor = True
      '
      'cmdRemoveFile
      '
      Me.cmdRemoveFile.BackgroundImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.file_remove_32x32
      Me.HelpProvider1.SetHelpString(Me.cmdRemoveFile, "Funzione che permettere di eliminare il file selezionato dalla cartella di archiv" & _
              "io documentale dell'utente.")
      Me.cmdRemoveFile.Location = New System.Drawing.Point(39, 0)
      Me.cmdRemoveFile.Name = "cmdRemoveFile"
      Me.HelpProvider1.SetShowHelp(Me.cmdRemoveFile, True)
      Me.cmdRemoveFile.Size = New System.Drawing.Size(37, 33)
      Me.cmdRemoveFile.TabIndex = 1
      Me.cmdRemoveFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
      Me.ToolTip1.SetToolTip(Me.cmdRemoveFile, "Rimuovi file")
      Me.cmdRemoveFile.UseVisualStyleBackColor = True
      '
      'cmdAddFile
      '
      Me.cmdAddFile.BackgroundImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.file_add_32x32
      Me.HelpProvider1.SetHelpString(Me.cmdAddFile, "Funzione che permettere di aggiungere un nuovo file nella cartella di archivio do" & _
              "cumentale dell'utente.")
      Me.cmdAddFile.Location = New System.Drawing.Point(3, 0)
      Me.cmdAddFile.Name = "cmdAddFile"
      Me.HelpProvider1.SetShowHelp(Me.cmdAddFile, True)
      Me.cmdAddFile.Size = New System.Drawing.Size(37, 33)
      Me.cmdAddFile.TabIndex = 0
      Me.cmdAddFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
      Me.ToolTip1.SetToolTip(Me.cmdAddFile, "Aggiungi nuovo file")
      Me.cmdAddFile.UseVisualStyleBackColor = True
      '
      'datagridview1
      '
      DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue
      DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
      DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange
      DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
      Me.datagridview1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
      Me.datagridview1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.datagridview1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
      Me.datagridview1.BackgroundColor = System.Drawing.Color.White
      DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
      DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
      DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
      DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
      DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
      Me.datagridview1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
      Me.datagridview1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
      DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
      DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
      DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
      DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
      Me.datagridview1.DefaultCellStyle = DataGridViewCellStyle3
      Me.HelpProvider1.SetHelpString(Me.datagridview1, "Fare doppio click su un documento elettronico per visualizzarne le proprietà")
      Me.datagridview1.Location = New System.Drawing.Point(3, 36)
      Me.datagridview1.Name = "datagridview1"
      DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
      DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
      DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
      DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
      DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
      Me.datagridview1.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
      Me.datagridview1.RowHeadersVisible = False
      DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
      DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Orange
      DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
      Me.datagridview1.RowsDefaultCellStyle = DataGridViewCellStyle5
      Me.datagridview1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
      Me.HelpProvider1.SetShowHelp(Me.datagridview1, True)
      Me.datagridview1.Size = New System.Drawing.Size(554, 98)
      Me.datagridview1.TabIndex = 1
      '
      'SplitContainer5
      '
      Me.SplitContainer5.Dock = System.Windows.Forms.DockStyle.Fill
      Me.SplitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel2
      Me.SplitContainer5.Location = New System.Drawing.Point(0, 0)
      Me.SplitContainer5.Name = "SplitContainer5"
      Me.SplitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal
      '
      'SplitContainer5.Panel1
      '
      Me.SplitContainer5.Panel1.Controls.Add(Me.SplitContainer3)
      '
      'SplitContainer5.Panel2
      '
      Me.SplitContainer5.Panel2.BackColor = System.Drawing.Color.White
      Me.SplitContainer5.Panel2.Controls.Add(Me.cmdClose)
      Me.SplitContainer5.Panel2.Controls.Add(Me.lblNumDocs)
      Me.SplitContainer5.Panel2.Controls.Add(Me.cmdOk)
      Me.SplitContainer5.Size = New System.Drawing.Size(752, 193)
      Me.SplitContainer5.SplitterDistance = 144
      Me.SplitContainer5.TabIndex = 0
      '
      'SplitContainer3
      '
      Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
      Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
      Me.SplitContainer3.Name = "SplitContainer3"
      '
      'SplitContainer3.Panel1
      '
      Me.SplitContainer3.Panel1.Controls.Add(Me.TreeView2)
      '
      'SplitContainer3.Panel2
      '
      Me.SplitContainer3.Panel2.Controls.Add(Me.datagridviewAttivita)
      Me.SplitContainer3.Panel2.Controls.Add(Me.DocPanel1)
      Me.SplitContainer3.Size = New System.Drawing.Size(752, 144)
      Me.SplitContainer3.SplitterDistance = 189
      Me.SplitContainer3.TabIndex = 0
      '
      'TreeView2
      '
      Me.TreeView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.TreeView2.Dock = System.Windows.Forms.DockStyle.Fill
      Me.TreeView2.ImageIndex = 0
      Me.TreeView2.ImageList = Me.ImageList1
      Me.TreeView2.Location = New System.Drawing.Point(0, 0)
      Me.TreeView2.Name = "TreeView2"
      TreeNode2.ImageIndex = 4
      TreeNode2.Name = "Comunicazioni"
      TreeNode2.SelectedImageIndex = 4
      TreeNode2.Text = "COMUNICAZIONI"
      TreeNode3.ImageIndex = 4
      TreeNode3.Name = "Prestazioni"
      TreeNode3.SelectedImageIndex = 4
      TreeNode3.Text = "PRESTAZIONI"
      TreeNode4.ImageIndex = 4
      TreeNode4.Name = "Vertenze"
      TreeNode4.SelectedImageIndex = 4
      TreeNode4.Text = "VERTENZE"
      TreeNode5.ImageIndex = 0
      TreeNode5.Name = "Nodo0"
      TreeNode5.SelectedImageIndex = 0
      TreeNode5.Text = "DOCUMENTI ATTIVITA'"
      Me.TreeView2.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode5})
      Me.TreeView2.SelectedImageIndex = 0
      Me.TreeView2.Size = New System.Drawing.Size(189, 144)
      Me.TreeView2.TabIndex = 0
      '
      'datagridviewAttivita
      '
      DataGridViewCellStyle6.BackColor = System.Drawing.Color.LightSteelBlue
      DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
      DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Orange
      DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
      Me.datagridviewAttivita.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
      Me.datagridviewAttivita.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.datagridviewAttivita.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
      Me.datagridviewAttivita.BackgroundColor = System.Drawing.Color.White
      DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
      DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
      DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
      DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
      DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
      Me.datagridviewAttivita.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
      Me.datagridviewAttivita.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
      DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
      DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
      DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
      DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
      Me.datagridviewAttivita.DefaultCellStyle = DataGridViewCellStyle8
      Me.HelpProvider1.SetHelpString(Me.datagridviewAttivita, "Fare doppio click su un documento elettronico per visualizzarne le proprietà")
      Me.datagridviewAttivita.Location = New System.Drawing.Point(2, 36)
      Me.datagridviewAttivita.Name = "datagridviewAttivita"
      DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
      DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
      DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
      DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
      DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
      Me.datagridviewAttivita.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
      Me.datagridviewAttivita.RowHeadersVisible = False
      DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
      DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Orange
      DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
      Me.datagridviewAttivita.RowsDefaultCellStyle = DataGridViewCellStyle10
      Me.datagridviewAttivita.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
      Me.HelpProvider1.SetShowHelp(Me.datagridviewAttivita, True)
      Me.datagridviewAttivita.Size = New System.Drawing.Size(554, 108)
      Me.datagridviewAttivita.TabIndex = 1
      '
      'DocPanel1
      '
      Me.DocPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.DocPanel1.BackColor = System.Drawing.Color.Transparent
      Me.DocPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.DocPanel1.Controls.Add(Me.cmdSearchAtt)
      Me.DocPanel1.Controls.Add(Me.txtSearchAtt)
      Me.DocPanel1.Controls.Add(Me.cmdDownAtt)
      Me.DocPanel1.Controls.Add(Me.cmdUpAtt)
      Me.DocPanel1.Controls.Add(Me.cmdBrowse)
      Me.DocPanel1.Controls.Add(Me.cmdInfoFileAttivita)
      Me.DocPanel1.Controls.Add(Me.cmdViewPathAttivita)
      Me.DocPanel1.Controls.Add(Me.cmdViiewFileAttività)
      Me.DocPanel1.Location = New System.Drawing.Point(3, 0)
      Me.DocPanel1.Margin = New System.Windows.Forms.Padding(1, 0, 0, 0)
      Me.DocPanel1.Name = "DocPanel1"
      Me.DocPanel1.Size = New System.Drawing.Size(553, 35)
      Me.DocPanel1.TabIndex = 0
      Me.ToolTip1.SetToolTip(Me.DocPanel1, "Naviga")
      '
      'cmdSearchAtt
      '
      Me.cmdSearchAtt.BackgroundImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.ActualSizeHS
      Me.cmdSearchAtt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.HelpProvider1.SetHelpString(Me.cmdSearchAtt, "Funzione che permette di visualizzare il file selezionato.")
      Me.cmdSearchAtt.Location = New System.Drawing.Point(440, 0)
      Me.cmdSearchAtt.Name = "cmdSearchAtt"
      Me.HelpProvider1.SetShowHelp(Me.cmdSearchAtt, True)
      Me.cmdSearchAtt.Size = New System.Drawing.Size(37, 33)
      Me.cmdSearchAtt.TabIndex = 13
      Me.cmdSearchAtt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
      Me.ToolTip1.SetToolTip(Me.cmdSearchAtt, "ricerca documenti")
      Me.cmdSearchAtt.UseVisualStyleBackColor = True
      '
      'txtSearchAtt
      '
      Me.HelpProvider1.SetHelpString(Me.txtSearchAtt, resources.GetString("txtSearchAtt.HelpString"))
      Me.txtSearchAtt.Location = New System.Drawing.Point(281, 6)
      Me.txtSearchAtt.Name = "txtSearchAtt"
      Me.HelpProvider1.SetShowHelp(Me.txtSearchAtt, True)
      Me.txtSearchAtt.Size = New System.Drawing.Size(153, 20)
      Me.txtSearchAtt.TabIndex = 12
      '
      'cmdDownAtt
      '
      Me.cmdDownAtt.BackgroundImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.package_edutainment_48x48_down
      Me.cmdDownAtt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
      Me.HelpProvider1.SetHelpString(Me.cmdDownAtt, "Funzione che permette di ottenere informazioni sul file selezionato ( creato da, " & _
              "data creazione...)")
      Me.cmdDownAtt.Location = New System.Drawing.Point(223, 0)
      Me.cmdDownAtt.Name = "cmdDownAtt"
      Me.HelpProvider1.SetShowHelp(Me.cmdDownAtt, True)
      Me.cmdDownAtt.Size = New System.Drawing.Size(37, 33)
      Me.cmdDownAtt.TabIndex = 11
      Me.cmdDownAtt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
      Me.ToolTip1.SetToolTip(Me.cmdDownAtt, "Ordina dal basso")
      Me.cmdDownAtt.UseVisualStyleBackColor = True
      '
      'cmdUpAtt
      '
      Me.cmdUpAtt.BackgroundImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.package_edutainment_48x48_up
      Me.cmdUpAtt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
      Me.HelpProvider1.SetHelpString(Me.cmdUpAtt, "Funzione che permette di visualizzare il percorso del file selezionato.")
      Me.cmdUpAtt.Location = New System.Drawing.Point(186, 0)
      Me.cmdUpAtt.Name = "cmdUpAtt"
      Me.HelpProvider1.SetShowHelp(Me.cmdUpAtt, True)
      Me.cmdUpAtt.Size = New System.Drawing.Size(37, 33)
      Me.cmdUpAtt.TabIndex = 10
      Me.cmdUpAtt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
      Me.ToolTip1.SetToolTip(Me.cmdUpAtt, "Ordina dall'alto")
      Me.cmdUpAtt.UseVisualStyleBackColor = True
      '
      'cmdBrowse
      '
      Me.cmdBrowse.BackgroundImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.k_get_list_48x48
      Me.cmdBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
      Me.HelpProvider1.SetHelpString(Me.cmdBrowse, "Funzione che permette di navigare verso l'oggetto cui il documento selezionato fa" & _
              " riferimento.")
      Me.cmdBrowse.Location = New System.Drawing.Point(131, 0)
      Me.cmdBrowse.Name = "cmdBrowse"
      Me.HelpProvider1.SetShowHelp(Me.cmdBrowse, True)
      Me.cmdBrowse.Size = New System.Drawing.Size(37, 33)
      Me.cmdBrowse.TabIndex = 3
      Me.cmdBrowse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
      Me.ToolTip1.SetToolTip(Me.cmdBrowse, "Naviga verso l'oggetto selezionato")
      Me.cmdBrowse.UseVisualStyleBackColor = True
      '
      'cmdInfoFileAttivita
      '
      Me.cmdInfoFileAttivita.BackgroundImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.info_32x32_active
      Me.HelpProvider1.SetHelpString(Me.cmdInfoFileAttivita, resources.GetString("cmdInfoFileAttivita.HelpString"))
      Me.cmdInfoFileAttivita.Location = New System.Drawing.Point(76, 0)
      Me.cmdInfoFileAttivita.Name = "cmdInfoFileAttivita"
      Me.HelpProvider1.SetShowHelp(Me.cmdInfoFileAttivita, True)
      Me.cmdInfoFileAttivita.Size = New System.Drawing.Size(37, 33)
      Me.cmdInfoFileAttivita.TabIndex = 2
      Me.cmdInfoFileAttivita.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
      Me.ToolTip1.SetToolTip(Me.cmdInfoFileAttivita, "Informazioni file")
      Me.cmdInfoFileAttivita.UseVisualStyleBackColor = True
      '
      'cmdViewPathAttivita
      '
      Me.cmdViewPathAttivita.BackgroundImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.folder_open_32x32
      Me.HelpProvider1.SetHelpString(Me.cmdViewPathAttivita, resources.GetString("cmdViewPathAttivita.HelpString"))
      Me.cmdViewPathAttivita.Location = New System.Drawing.Point(40, 0)
      Me.cmdViewPathAttivita.Name = "cmdViewPathAttivita"
      Me.HelpProvider1.SetShowHelp(Me.cmdViewPathAttivita, True)
      Me.cmdViewPathAttivita.Size = New System.Drawing.Size(37, 33)
      Me.cmdViewPathAttivita.TabIndex = 1
      Me.cmdViewPathAttivita.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
      Me.ToolTip1.SetToolTip(Me.cmdViewPathAttivita, "Visualizza percorso")
      Me.cmdViewPathAttivita.UseVisualStyleBackColor = True
      '
      'cmdViiewFileAttività
      '
      Me.cmdViiewFileAttività.BackgroundImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.file_view_32x32
      Me.HelpProvider1.SetHelpString(Me.cmdViiewFileAttività, resources.GetString("cmdViiewFileAttività.HelpString"))
      Me.cmdViiewFileAttività.Location = New System.Drawing.Point(4, 0)
      Me.cmdViiewFileAttività.Name = "cmdViiewFileAttività"
      Me.HelpProvider1.SetShowHelp(Me.cmdViiewFileAttività, True)
      Me.cmdViiewFileAttività.Size = New System.Drawing.Size(37, 33)
      Me.cmdViiewFileAttività.TabIndex = 0
      Me.cmdViiewFileAttività.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
      Me.ToolTip1.SetToolTip(Me.cmdViiewFileAttività, "Visualizza file")
      Me.cmdViiewFileAttività.UseVisualStyleBackColor = True
      '
      'cmdClose
      '
      Me.cmdClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.cmdClose.Location = New System.Drawing.Point(658, 9)
      Me.cmdClose.Name = "cmdClose"
      Me.cmdClose.Size = New System.Drawing.Size(82, 24)
      Me.cmdClose.TabIndex = 1
      Me.cmdClose.Text = "Chiudi"
      Me.cmdClose.UseVisualStyleBackColor = True
      '
      'lblNumDocs
      '
      Me.lblNumDocs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.lblNumDocs.AutoSize = True
      Me.lblNumDocs.Location = New System.Drawing.Point(16, 17)
      Me.lblNumDocs.Name = "lblNumDocs"
      Me.lblNumDocs.Size = New System.Drawing.Size(96, 13)
      Me.lblNumDocs.TabIndex = 2
      Me.lblNumDocs.Text = "Numero documenti"
      '
      'cmdOk
      '
      Me.cmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.cmdOk.BackgroundImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.saveHS
      Me.cmdOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
      Me.HelpProvider1.SetHelpString(Me.cmdOk, "Funzione che permette il salvataggio di tutte le modifiche apportate all'archivio" & _
              " documentale dell'utente.")
      Me.cmdOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.cmdOk.Location = New System.Drawing.Point(561, 9)
      Me.cmdOk.Name = "cmdOk"
      Me.HelpProvider1.SetShowHelp(Me.cmdOk, True)
      Me.cmdOk.Size = New System.Drawing.Size(82, 24)
      Me.cmdOk.TabIndex = 0
      Me.cmdOk.Text = "Salva"
      Me.cmdOk.UseVisualStyleBackColor = True
      '
      'FrmArchivioDocumentale
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(752, 442)
      Me.Controls.Add(Me.SplitContainer1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.MinimizeBox = False
      Me.Name = "FrmArchivioDocumentale"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Archivio documentale"
      Me.SplitContainer1.Panel1.ResumeLayout(False)
      Me.SplitContainer1.Panel2.ResumeLayout(False)
      Me.SplitContainer1.ResumeLayout(False)
      Me.Panel2.ResumeLayout(False)
      Me.Panel2.PerformLayout()
      Me.DockPanel2.ResumeLayout(False)
      Me.SplitContainer4.Panel1.ResumeLayout(False)
      Me.SplitContainer4.Panel2.ResumeLayout(False)
      Me.SplitContainer4.ResumeLayout(False)
      Me.SplitContainer2.Panel1.ResumeLayout(False)
      Me.SplitContainer2.Panel2.ResumeLayout(False)
      Me.SplitContainer2.ResumeLayout(False)
      Me.DockPanel.ResumeLayout(False)
      Me.DockPanel.PerformLayout()
      CType(Me.datagridview1, System.ComponentModel.ISupportInitialize).EndInit()
      Me.SplitContainer5.Panel1.ResumeLayout(False)
      Me.SplitContainer5.Panel2.ResumeLayout(False)
      Me.SplitContainer5.Panel2.PerformLayout()
      Me.SplitContainer5.ResumeLayout(False)
      Me.SplitContainer3.Panel1.ResumeLayout(False)
      Me.SplitContainer3.Panel2.ResumeLayout(False)
      Me.SplitContainer3.ResumeLayout(False)
      CType(Me.datagridviewAttivita, System.ComponentModel.ISupportInitialize).EndInit()
      Me.DocPanel1.ResumeLayout(False)
      Me.DocPanel1.PerformLayout()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
   Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
   Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
   Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
   Friend WithEvents TreeView2 As System.Windows.Forms.TreeView
   Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
   Friend WithEvents SplitContainer5 As System.Windows.Forms.SplitContainer
   Friend WithEvents cmdOk As System.Windows.Forms.Button
   Friend WithEvents lblNumDocs As System.Windows.Forms.Label
   Friend WithEvents txtCartella As System.Windows.Forms.TextBox
   Friend WithEvents cmdSeleziona As System.Windows.Forms.Button
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
   Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
   Friend WithEvents cmdClose As System.Windows.Forms.Button
   Friend WithEvents datagridview1 As System.Windows.Forms.DataGridView
   Protected WithEvents DockPanel As System.Windows.Forms.Panel
   Friend WithEvents cmdAddFile As System.Windows.Forms.Button
   Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
   Friend WithEvents cmdRename As System.Windows.Forms.Button
   Friend WithEvents cmdMoveFile As System.Windows.Forms.Button
   Friend WithEvents cmdRemoveFile As System.Windows.Forms.Button
   Friend WithEvents cmdInfoFile As System.Windows.Forms.Button
   Friend WithEvents cmdViewPath As System.Windows.Forms.Button
   Friend WithEvents cmdView As System.Windows.Forms.Button
   Protected WithEvents DocPanel1 As System.Windows.Forms.Panel
   Friend WithEvents cmdInfoFileAttivita As System.Windows.Forms.Button
   Friend WithEvents cmdViewPathAttivita As System.Windows.Forms.Button
   Friend WithEvents cmdViiewFileAttività As System.Windows.Forms.Button
   Protected WithEvents DockPanel2 As System.Windows.Forms.Panel
   Friend WithEvents cmdSetDefaultFolder As System.Windows.Forms.Button
   Friend WithEvents cmdViewPathDefault As System.Windows.Forms.Button
   Friend WithEvents Panel2 As System.Windows.Forms.Panel
   Friend WithEvents datagridviewAttivita As System.Windows.Forms.DataGridView
   Friend WithEvents cmdBrowse As System.Windows.Forms.Button
   Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
   Friend WithEvents cmdSearch As System.Windows.Forms.Button
   Friend WithEvents txtSearch As System.Windows.Forms.TextBox
   Friend WithEvents cmdDown As System.Windows.Forms.Button
   Friend WithEvents cmdUp As System.Windows.Forms.Button
   Friend WithEvents cmdSearchAtt As System.Windows.Forms.Button
   Friend WithEvents txtSearchAtt As System.Windows.Forms.TextBox
   Friend WithEvents cmdDownAtt As System.Windows.Forms.Button
   Friend WithEvents cmdUpAtt As System.Windows.Forms.Button
End Class
