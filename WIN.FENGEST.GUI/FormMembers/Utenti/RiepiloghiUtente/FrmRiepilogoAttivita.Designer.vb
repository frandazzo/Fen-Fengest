<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRiepilogoAttivita
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
      Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Deleghe")
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRiepilogoAttivita))
      Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Prestazioni")
      Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Comunicazioni")
      Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Vertenze")
      Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Proposte lavoro")
      Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
      Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
      Me.SplitContainerDeleghe = New System.Windows.Forms.SplitContainer
      Me.TreeViewDeleghe = New System.Windows.Forms.TreeView
      Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
      Me.DockPanel = New System.Windows.Forms.Panel
      Me.PictureBox1 = New System.Windows.Forms.PictureBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.datagridviewDeleghe = New System.Windows.Forms.DataGridView
      Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn
      Me.StatoDelega = New System.Windows.Forms.DataGridViewTextBoxColumn
      Me.DataDocumento = New System.Windows.Forms.DataGridViewTextBoxColumn
      Me.EnteInoltro = New System.Windows.Forms.DataGridViewTextBoxColumn
      Me.SplitContainerPrestazioni = New System.Windows.Forms.SplitContainer
      Me.TreeViewPrestazioni = New System.Windows.Forms.TreeView
      Me.Panel1 = New System.Windows.Forms.Panel
      Me.PictureBox2 = New System.Windows.Forms.PictureBox
      Me.Label2 = New System.Windows.Forms.Label
      Me.DataGridViewPrestazioni = New System.Windows.Forms.DataGridView
      Me.SplitContainer3 = New System.Windows.Forms.SplitContainer
      Me.SplitContainerComunicazioni = New System.Windows.Forms.SplitContainer
      Me.TreeViewComunicazioni = New System.Windows.Forms.TreeView
      Me.Panel2 = New System.Windows.Forms.Panel
      Me.PictureBox3 = New System.Windows.Forms.PictureBox
      Me.Label3 = New System.Windows.Forms.Label
      Me.DataGridViewComunicazioni = New System.Windows.Forms.DataGridView
      Me.SplitContainer4 = New System.Windows.Forms.SplitContainer
      Me.SplitContainerVertenze = New System.Windows.Forms.SplitContainer
      Me.TreeViewVertenze = New System.Windows.Forms.TreeView
      Me.Panel3 = New System.Windows.Forms.Panel
      Me.PictureBox4 = New System.Windows.Forms.PictureBox
      Me.Label4 = New System.Windows.Forms.Label
      Me.DataGridViewVertenze = New System.Windows.Forms.DataGridView
      Me.SplitContainerProposte = New System.Windows.Forms.SplitContainer
      Me.TreeViewProposte = New System.Windows.Forms.TreeView
      Me.Panel4 = New System.Windows.Forms.Panel
      Me.PictureBox5 = New System.Windows.Forms.PictureBox
      Me.Label5 = New System.Windows.Forms.Label
      Me.DataGridViewProposte = New System.Windows.Forms.DataGridView
      Me.SplitContainer1.Panel1.SuspendLayout()
      Me.SplitContainer1.Panel2.SuspendLayout()
      Me.SplitContainer1.SuspendLayout()
      Me.SplitContainer2.Panel1.SuspendLayout()
      Me.SplitContainer2.Panel2.SuspendLayout()
      Me.SplitContainer2.SuspendLayout()
      Me.SplitContainerDeleghe.Panel1.SuspendLayout()
      Me.SplitContainerDeleghe.Panel2.SuspendLayout()
      Me.SplitContainerDeleghe.SuspendLayout()
      Me.DockPanel.SuspendLayout()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.datagridviewDeleghe, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SplitContainerPrestazioni.Panel1.SuspendLayout()
      Me.SplitContainerPrestazioni.Panel2.SuspendLayout()
      Me.SplitContainerPrestazioni.SuspendLayout()
      Me.Panel1.SuspendLayout()
      CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.DataGridViewPrestazioni, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SplitContainer3.Panel1.SuspendLayout()
      Me.SplitContainer3.Panel2.SuspendLayout()
      Me.SplitContainer3.SuspendLayout()
      Me.SplitContainerComunicazioni.Panel1.SuspendLayout()
      Me.SplitContainerComunicazioni.Panel2.SuspendLayout()
      Me.SplitContainerComunicazioni.SuspendLayout()
      Me.Panel2.SuspendLayout()
      CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.DataGridViewComunicazioni, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SplitContainer4.Panel1.SuspendLayout()
      Me.SplitContainer4.Panel2.SuspendLayout()
      Me.SplitContainer4.SuspendLayout()
      Me.SplitContainerVertenze.Panel1.SuspendLayout()
      Me.SplitContainerVertenze.Panel2.SuspendLayout()
      Me.SplitContainerVertenze.SuspendLayout()
      Me.Panel3.SuspendLayout()
      CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.DataGridViewVertenze, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SplitContainerProposte.Panel1.SuspendLayout()
      Me.SplitContainerProposte.Panel2.SuspendLayout()
      Me.SplitContainerProposte.SuspendLayout()
      Me.Panel4.SuspendLayout()
      CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
      CType(Me.DataGridViewProposte, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.SuspendLayout()
      '
      'SplitContainer1
      '
      Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
      Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
      Me.SplitContainer1.Name = "SplitContainer1"
      Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
      '
      'SplitContainer1.Panel1
      '
      Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
      '
      'SplitContainer1.Panel2
      '
      Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer3)
      Me.SplitContainer1.Size = New System.Drawing.Size(693, 527)
      Me.SplitContainer1.SplitterDistance = 220
      Me.SplitContainer1.TabIndex = 0
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
      Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainerDeleghe)
      '
      'SplitContainer2.Panel2
      '
      Me.SplitContainer2.Panel2.Controls.Add(Me.SplitContainerPrestazioni)
      Me.SplitContainer2.Size = New System.Drawing.Size(693, 220)
      Me.SplitContainer2.SplitterDistance = 104
      Me.SplitContainer2.TabIndex = 0
      '
      'SplitContainerDeleghe
      '
      Me.SplitContainerDeleghe.Dock = System.Windows.Forms.DockStyle.Fill
      Me.SplitContainerDeleghe.Location = New System.Drawing.Point(0, 0)
      Me.SplitContainerDeleghe.Name = "SplitContainerDeleghe"
      '
      'SplitContainerDeleghe.Panel1
      '
      Me.SplitContainerDeleghe.Panel1.BackColor = System.Drawing.Color.White
      Me.SplitContainerDeleghe.Panel1.Controls.Add(Me.TreeViewDeleghe)
      Me.SplitContainerDeleghe.Panel1.Controls.Add(Me.DockPanel)
      '
      'SplitContainerDeleghe.Panel2
      '
      Me.SplitContainerDeleghe.Panel2.BackColor = System.Drawing.Color.White
      Me.SplitContainerDeleghe.Panel2.Controls.Add(Me.datagridviewDeleghe)
      Me.SplitContainerDeleghe.Size = New System.Drawing.Size(693, 104)
      Me.SplitContainerDeleghe.SplitterDistance = 183
      Me.SplitContainerDeleghe.TabIndex = 0
      '
      'TreeViewDeleghe
      '
      Me.TreeViewDeleghe.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.TreeViewDeleghe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.TreeViewDeleghe.ImageIndex = 0
      Me.TreeViewDeleghe.ImageList = Me.ImageList1
      Me.TreeViewDeleghe.Location = New System.Drawing.Point(0, 35)
      Me.TreeViewDeleghe.Name = "TreeViewDeleghe"
      TreeNode1.Name = "Nodo0"
      TreeNode1.Text = "Deleghe"
      Me.TreeViewDeleghe.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1})
      Me.TreeViewDeleghe.SelectedImageIndex = 0
      Me.TreeViewDeleghe.Size = New System.Drawing.Size(183, 64)
      Me.TreeViewDeleghe.TabIndex = 4
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
      Me.ImageList1.Images.SetKeyName(5, "korn-32x32.png")
      Me.ImageList1.Images.SetKeyName(6, "money3.png")
      '
      'DockPanel
      '
      Me.DockPanel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.DockPanel.BackColor = System.Drawing.Color.Transparent
      Me.DockPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.DockPanel.Controls.Add(Me.PictureBox1)
      Me.DockPanel.Controls.Add(Me.Label1)
      Me.DockPanel.Location = New System.Drawing.Point(1, 1)
      Me.DockPanel.Margin = New System.Windows.Forms.Padding(1, 0, 0, 0)
      Me.DockPanel.Name = "DockPanel"
      Me.DockPanel.Size = New System.Drawing.Size(182, 32)
      Me.DockPanel.TabIndex = 1
      '
      'PictureBox1
      '
      Me.PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
      Me.PictureBox1.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.korn_32x32_2
      Me.PictureBox1.Location = New System.Drawing.Point(14, -1)
      Me.PictureBox1.Name = "PictureBox1"
      Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
      Me.PictureBox1.TabIndex = 1
      Me.PictureBox1.TabStop = False
      '
      'Label1
      '
      Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
      Me.Label1.AutoEllipsis = True
      Me.Label1.AutoSize = True
      Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label1.ImageKey = "korn-32x32.png"
      Me.Label1.Location = New System.Drawing.Point(69, 9)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(54, 13)
      Me.Label1.TabIndex = 0
      Me.Label1.Text = "Deleghe"
      '
      'datagridviewDeleghe
      '
      Me.datagridviewDeleghe.AllowUserToAddRows = False
      Me.datagridviewDeleghe.AllowUserToDeleteRows = False
      DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue
      DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
      DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange
      DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
      Me.datagridviewDeleghe.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
      Me.datagridviewDeleghe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
      Me.datagridviewDeleghe.BackgroundColor = System.Drawing.Color.White
      DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
      DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
      DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
      DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
      DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
      Me.datagridviewDeleghe.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
      Me.datagridviewDeleghe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.datagridviewDeleghe.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.StatoDelega, Me.DataDocumento, Me.EnteInoltro})
      DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
      DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
      DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
      DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
      DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
      Me.datagridviewDeleghe.DefaultCellStyle = DataGridViewCellStyle3
      Me.datagridviewDeleghe.Dock = System.Windows.Forms.DockStyle.Fill
      Me.datagridviewDeleghe.Location = New System.Drawing.Point(0, 0)
      Me.datagridviewDeleghe.Name = "datagridviewDeleghe"
      Me.datagridviewDeleghe.ReadOnly = True
      DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
      DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
      DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
      DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
      DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
      Me.datagridviewDeleghe.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
      Me.datagridviewDeleghe.RowHeadersVisible = False
      DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
      DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Orange
      DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
      Me.datagridviewDeleghe.RowsDefaultCellStyle = DataGridViewCellStyle5
      Me.datagridviewDeleghe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
      Me.datagridviewDeleghe.Size = New System.Drawing.Size(506, 104)
      Me.datagridviewDeleghe.TabIndex = 2
      '
      'Id
      '
      Me.Id.DataPropertyName = "Id"
      Me.Id.HeaderText = "Id"
      Me.Id.Name = "Id"
      Me.Id.ReadOnly = True
      '
      'StatoDelega
      '
      Me.StatoDelega.DataPropertyName = "Stato"
      Me.StatoDelega.HeaderText = "Stato delega"
      Me.StatoDelega.Name = "StatoDelega"
      Me.StatoDelega.ReadOnly = True
      '
      'DataDocumento
      '
      Me.DataDocumento.DataPropertyName = "DataDocumento"
      Me.DataDocumento.HeaderText = "Data documento"
      Me.DataDocumento.Name = "DataDocumento"
      Me.DataDocumento.ReadOnly = True
      '
      'EnteInoltro
      '
      Me.EnteInoltro.DataPropertyName = "EnteInoltro"
      Me.EnteInoltro.HeaderText = "Ente inoltro"
      Me.EnteInoltro.Name = "EnteInoltro"
      Me.EnteInoltro.ReadOnly = True
      '
      'SplitContainerPrestazioni
      '
      Me.SplitContainerPrestazioni.Dock = System.Windows.Forms.DockStyle.Fill
      Me.SplitContainerPrestazioni.Location = New System.Drawing.Point(0, 0)
      Me.SplitContainerPrestazioni.Name = "SplitContainerPrestazioni"
      '
      'SplitContainerPrestazioni.Panel1
      '
      Me.SplitContainerPrestazioni.Panel1.BackColor = System.Drawing.Color.White
      Me.SplitContainerPrestazioni.Panel1.Controls.Add(Me.TreeViewPrestazioni)
      Me.SplitContainerPrestazioni.Panel1.Controls.Add(Me.Panel1)
      '
      'SplitContainerPrestazioni.Panel2
      '
      Me.SplitContainerPrestazioni.Panel2.BackColor = System.Drawing.Color.White
      Me.SplitContainerPrestazioni.Panel2.Controls.Add(Me.DataGridViewPrestazioni)
      Me.SplitContainerPrestazioni.Size = New System.Drawing.Size(693, 112)
      Me.SplitContainerPrestazioni.SplitterDistance = 184
      Me.SplitContainerPrestazioni.TabIndex = 0
      '
      'TreeViewPrestazioni
      '
      Me.TreeViewPrestazioni.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.TreeViewPrestazioni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.TreeViewPrestazioni.ImageIndex = 0
      Me.TreeViewPrestazioni.ImageList = Me.ImageList1
      Me.TreeViewPrestazioni.Location = New System.Drawing.Point(1, 35)
      Me.TreeViewPrestazioni.Name = "TreeViewPrestazioni"
      TreeNode2.Name = "Nodo0"
      TreeNode2.Text = "Prestazioni"
      Me.TreeViewPrestazioni.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode2})
      Me.TreeViewPrestazioni.SelectedImageIndex = 0
      Me.TreeViewPrestazioni.Size = New System.Drawing.Size(182, 75)
      Me.TreeViewPrestazioni.TabIndex = 3
      '
      'Panel1
      '
      Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Panel1.BackColor = System.Drawing.Color.Transparent
      Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.Panel1.Controls.Add(Me.PictureBox2)
      Me.Panel1.Controls.Add(Me.Label2)
      Me.Panel1.Location = New System.Drawing.Point(1, 1)
      Me.Panel1.Margin = New System.Windows.Forms.Padding(1, 0, 0, 0)
      Me.Panel1.Name = "Panel1"
      Me.Panel1.Size = New System.Drawing.Size(183, 32)
      Me.Panel1.TabIndex = 2
      '
      'PictureBox2
      '
      Me.PictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
      Me.PictureBox2.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.money3
      Me.PictureBox2.Location = New System.Drawing.Point(12, 0)
      Me.PictureBox2.Name = "PictureBox2"
      Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
      Me.PictureBox2.TabIndex = 2
      Me.PictureBox2.TabStop = False
      '
      'Label2
      '
      Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
      Me.Label2.AutoEllipsis = True
      Me.Label2.AutoSize = True
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(63, 9)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(69, 13)
      Me.Label2.TabIndex = 0
      Me.Label2.Text = "Prestazioni"
      '
      'DataGridViewPrestazioni
      '
      DataGridViewCellStyle6.BackColor = System.Drawing.Color.LightSteelBlue
      DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
      DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Orange
      DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
      Me.DataGridViewPrestazioni.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
      Me.DataGridViewPrestazioni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
      Me.DataGridViewPrestazioni.BackgroundColor = System.Drawing.Color.White
      DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
      DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
      DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
      DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
      DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
      Me.DataGridViewPrestazioni.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
      Me.DataGridViewPrestazioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
      DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black
      DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
      DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
      DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
      Me.DataGridViewPrestazioni.DefaultCellStyle = DataGridViewCellStyle8
      Me.DataGridViewPrestazioni.Dock = System.Windows.Forms.DockStyle.Fill
      Me.DataGridViewPrestazioni.Location = New System.Drawing.Point(0, 0)
      Me.DataGridViewPrestazioni.Name = "DataGridViewPrestazioni"
      DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
      DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
      DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
      DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
      DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
      Me.DataGridViewPrestazioni.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
      Me.DataGridViewPrestazioni.RowHeadersVisible = False
      DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black
      DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.Orange
      DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
      Me.DataGridViewPrestazioni.RowsDefaultCellStyle = DataGridViewCellStyle10
      Me.DataGridViewPrestazioni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
      Me.DataGridViewPrestazioni.Size = New System.Drawing.Size(505, 112)
      Me.DataGridViewPrestazioni.TabIndex = 3
      '
      'SplitContainer3
      '
      Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Fill
      Me.SplitContainer3.Location = New System.Drawing.Point(0, 0)
      Me.SplitContainer3.Name = "SplitContainer3"
      Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
      '
      'SplitContainer3.Panel1
      '
      Me.SplitContainer3.Panel1.Controls.Add(Me.SplitContainerComunicazioni)
      '
      'SplitContainer3.Panel2
      '
      Me.SplitContainer3.Panel2.Controls.Add(Me.SplitContainer4)
      Me.SplitContainer3.Size = New System.Drawing.Size(693, 303)
      Me.SplitContainer3.SplitterDistance = 100
      Me.SplitContainer3.TabIndex = 0
      '
      'SplitContainerComunicazioni
      '
      Me.SplitContainerComunicazioni.Dock = System.Windows.Forms.DockStyle.Fill
      Me.SplitContainerComunicazioni.Location = New System.Drawing.Point(0, 0)
      Me.SplitContainerComunicazioni.Name = "SplitContainerComunicazioni"
      '
      'SplitContainerComunicazioni.Panel1
      '
      Me.SplitContainerComunicazioni.Panel1.BackColor = System.Drawing.Color.White
      Me.SplitContainerComunicazioni.Panel1.Controls.Add(Me.TreeViewComunicazioni)
      Me.SplitContainerComunicazioni.Panel1.Controls.Add(Me.Panel2)
      '
      'SplitContainerComunicazioni.Panel2
      '
      Me.SplitContainerComunicazioni.Panel2.BackColor = System.Drawing.Color.White
      Me.SplitContainerComunicazioni.Panel2.Controls.Add(Me.DataGridViewComunicazioni)
      Me.SplitContainerComunicazioni.Size = New System.Drawing.Size(693, 100)
      Me.SplitContainerComunicazioni.SplitterDistance = 184
      Me.SplitContainerComunicazioni.TabIndex = 0
      '
      'TreeViewComunicazioni
      '
      Me.TreeViewComunicazioni.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.TreeViewComunicazioni.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.TreeViewComunicazioni.ImageIndex = 0
      Me.TreeViewComunicazioni.ImageList = Me.ImageList1
      Me.TreeViewComunicazioni.Location = New System.Drawing.Point(1, 35)
      Me.TreeViewComunicazioni.Name = "TreeViewComunicazioni"
      TreeNode3.Name = "Nodo0"
      TreeNode3.Text = "Comunicazioni"
      Me.TreeViewComunicazioni.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode3})
      Me.TreeViewComunicazioni.SelectedImageIndex = 0
      Me.TreeViewComunicazioni.Size = New System.Drawing.Size(182, 63)
      Me.TreeViewComunicazioni.TabIndex = 4
      '
      'Panel2
      '
      Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Panel2.BackColor = System.Drawing.Color.Transparent
      Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.Panel2.Controls.Add(Me.PictureBox3)
      Me.Panel2.Controls.Add(Me.Label3)
      Me.Panel2.Location = New System.Drawing.Point(0, 1)
      Me.Panel2.Margin = New System.Windows.Forms.Padding(1, 0, 0, 0)
      Me.Panel2.Name = "Panel2"
      Me.Panel2.Size = New System.Drawing.Size(183, 32)
      Me.Panel2.TabIndex = 3
      '
      'PictureBox3
      '
      Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None
      Me.PictureBox3.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.edu_languages_32x32_2
      Me.PictureBox3.Location = New System.Drawing.Point(11, -1)
      Me.PictureBox3.Name = "PictureBox3"
      Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
      Me.PictureBox3.TabIndex = 2
      Me.PictureBox3.TabStop = False
      '
      'Label3
      '
      Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
      Me.Label3.AutoEllipsis = True
      Me.Label3.AutoSize = True
      Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label3.Location = New System.Drawing.Point(51, 9)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(88, 13)
      Me.Label3.TabIndex = 0
      Me.Label3.Text = "Comunicazioni"
      '
      'DataGridViewComunicazioni
      '
      DataGridViewCellStyle11.BackColor = System.Drawing.Color.LightSteelBlue
      DataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black
      DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Orange
      DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black
      Me.DataGridViewComunicazioni.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
      Me.DataGridViewComunicazioni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
      Me.DataGridViewComunicazioni.BackgroundColor = System.Drawing.Color.White
      DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
      DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
      DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
      DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
      DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
      Me.DataGridViewComunicazioni.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
      Me.DataGridViewComunicazioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
      DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black
      DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
      DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
      DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
      Me.DataGridViewComunicazioni.DefaultCellStyle = DataGridViewCellStyle13
      Me.DataGridViewComunicazioni.Dock = System.Windows.Forms.DockStyle.Fill
      Me.DataGridViewComunicazioni.Location = New System.Drawing.Point(0, 0)
      Me.DataGridViewComunicazioni.Name = "DataGridViewComunicazioni"
      DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
      DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
      DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
      DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
      DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
      Me.DataGridViewComunicazioni.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
      Me.DataGridViewComunicazioni.RowHeadersVisible = False
      DataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black
      DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Orange
      DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black
      Me.DataGridViewComunicazioni.RowsDefaultCellStyle = DataGridViewCellStyle15
      Me.DataGridViewComunicazioni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
      Me.DataGridViewComunicazioni.Size = New System.Drawing.Size(505, 100)
      Me.DataGridViewComunicazioni.TabIndex = 3
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
      Me.SplitContainer4.Panel1.Controls.Add(Me.SplitContainerVertenze)
      '
      'SplitContainer4.Panel2
      '
      Me.SplitContainer4.Panel2.Controls.Add(Me.SplitContainerProposte)
      Me.SplitContainer4.Size = New System.Drawing.Size(693, 199)
      Me.SplitContainer4.SplitterDistance = 99
      Me.SplitContainer4.TabIndex = 0
      '
      'SplitContainerVertenze
      '
      Me.SplitContainerVertenze.Dock = System.Windows.Forms.DockStyle.Fill
      Me.SplitContainerVertenze.Location = New System.Drawing.Point(0, 0)
      Me.SplitContainerVertenze.Name = "SplitContainerVertenze"
      '
      'SplitContainerVertenze.Panel1
      '
      Me.SplitContainerVertenze.Panel1.BackColor = System.Drawing.Color.White
      Me.SplitContainerVertenze.Panel1.Controls.Add(Me.TreeViewVertenze)
      Me.SplitContainerVertenze.Panel1.Controls.Add(Me.Panel3)
      '
      'SplitContainerVertenze.Panel2
      '
      Me.SplitContainerVertenze.Panel2.BackColor = System.Drawing.Color.White
      Me.SplitContainerVertenze.Panel2.Controls.Add(Me.DataGridViewVertenze)
      Me.SplitContainerVertenze.Size = New System.Drawing.Size(693, 99)
      Me.SplitContainerVertenze.SplitterDistance = 184
      Me.SplitContainerVertenze.TabIndex = 0
      '
      'TreeViewVertenze
      '
      Me.TreeViewVertenze.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.TreeViewVertenze.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.TreeViewVertenze.ImageIndex = 0
      Me.TreeViewVertenze.ImageList = Me.ImageList1
      Me.TreeViewVertenze.Location = New System.Drawing.Point(1, 35)
      Me.TreeViewVertenze.Name = "TreeViewVertenze"
      TreeNode4.Name = "Nodo0"
      TreeNode4.Text = "Vertenze"
      Me.TreeViewVertenze.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode4})
      Me.TreeViewVertenze.SelectedImageIndex = 0
      Me.TreeViewVertenze.Size = New System.Drawing.Size(182, 62)
      Me.TreeViewVertenze.TabIndex = 5
      '
      'Panel3
      '
      Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Panel3.BackColor = System.Drawing.Color.Transparent
      Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.Panel3.Controls.Add(Me.PictureBox4)
      Me.Panel3.Controls.Add(Me.Label4)
      Me.Panel3.Location = New System.Drawing.Point(0, 1)
      Me.Panel3.Margin = New System.Windows.Forms.Padding(1, 0, 0, 0)
      Me.Panel3.Name = "Panel3"
      Me.Panel3.Size = New System.Drawing.Size(183, 32)
      Me.Panel3.TabIndex = 4
      '
      'PictureBox4
      '
      Me.PictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None
      Me.PictureBox4.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.error_32x32_2
      Me.PictureBox4.Location = New System.Drawing.Point(9, -1)
      Me.PictureBox4.Name = "PictureBox4"
      Me.PictureBox4.Size = New System.Drawing.Size(32, 32)
      Me.PictureBox4.TabIndex = 2
      Me.PictureBox4.TabStop = False
      '
      'Label4
      '
      Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
      Me.Label4.AutoEllipsis = True
      Me.Label4.AutoSize = True
      Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label4.Location = New System.Drawing.Point(65, 9)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(57, 13)
      Me.Label4.TabIndex = 0
      Me.Label4.Text = "Vertenze"
      '
      'DataGridViewVertenze
      '
      DataGridViewCellStyle16.BackColor = System.Drawing.Color.LightSteelBlue
      DataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black
      DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.Orange
      DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black
      Me.DataGridViewVertenze.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
      Me.DataGridViewVertenze.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
      Me.DataGridViewVertenze.BackgroundColor = System.Drawing.Color.White
      DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control
      DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
      DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
      DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
      DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
      Me.DataGridViewVertenze.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
      Me.DataGridViewVertenze.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window
      DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black
      DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
      DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
      DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
      Me.DataGridViewVertenze.DefaultCellStyle = DataGridViewCellStyle18
      Me.DataGridViewVertenze.Dock = System.Windows.Forms.DockStyle.Fill
      Me.DataGridViewVertenze.Location = New System.Drawing.Point(0, 0)
      Me.DataGridViewVertenze.Name = "DataGridViewVertenze"
      DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control
      DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText
      DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight
      DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
      DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
      Me.DataGridViewVertenze.RowHeadersDefaultCellStyle = DataGridViewCellStyle19
      Me.DataGridViewVertenze.RowHeadersVisible = False
      DataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black
      DataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.Orange
      DataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black
      Me.DataGridViewVertenze.RowsDefaultCellStyle = DataGridViewCellStyle20
      Me.DataGridViewVertenze.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
      Me.DataGridViewVertenze.Size = New System.Drawing.Size(505, 99)
      Me.DataGridViewVertenze.TabIndex = 3
      '
      'SplitContainerProposte
      '
      Me.SplitContainerProposte.Dock = System.Windows.Forms.DockStyle.Fill
      Me.SplitContainerProposte.Location = New System.Drawing.Point(0, 0)
      Me.SplitContainerProposte.Name = "SplitContainerProposte"
      '
      'SplitContainerProposte.Panel1
      '
      Me.SplitContainerProposte.Panel1.BackColor = System.Drawing.Color.White
      Me.SplitContainerProposte.Panel1.Controls.Add(Me.TreeViewProposte)
      Me.SplitContainerProposte.Panel1.Controls.Add(Me.Panel4)
      '
      'SplitContainerProposte.Panel2
      '
      Me.SplitContainerProposte.Panel2.BackColor = System.Drawing.Color.White
      Me.SplitContainerProposte.Panel2.Controls.Add(Me.DataGridViewProposte)
      Me.SplitContainerProposte.Size = New System.Drawing.Size(693, 96)
      Me.SplitContainerProposte.SplitterDistance = 184
      Me.SplitContainerProposte.TabIndex = 0
      '
      'TreeViewProposte
      '
      Me.TreeViewProposte.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                  Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.TreeViewProposte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.TreeViewProposte.ImageIndex = 0
      Me.TreeViewProposte.ImageList = Me.ImageList1
      Me.TreeViewProposte.Location = New System.Drawing.Point(1, 34)
      Me.TreeViewProposte.Name = "TreeViewProposte"
      TreeNode5.Name = "Nodo0"
      TreeNode5.Text = "Proposte lavoro"
      Me.TreeViewProposte.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode5})
      Me.TreeViewProposte.SelectedImageIndex = 0
      Me.TreeViewProposte.Size = New System.Drawing.Size(182, 61)
      Me.TreeViewProposte.TabIndex = 6
      '
      'Panel4
      '
      Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.Panel4.BackColor = System.Drawing.Color.Transparent
      Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
      Me.Panel4.Controls.Add(Me.PictureBox5)
      Me.Panel4.Controls.Add(Me.Label5)
      Me.Panel4.Location = New System.Drawing.Point(1, 0)
      Me.Panel4.Margin = New System.Windows.Forms.Padding(1, 0, 0, 0)
      Me.Panel4.Name = "Panel4"
      Me.Panel4.Size = New System.Drawing.Size(182, 32)
      Me.Panel4.TabIndex = 5
      '
      'PictureBox5
      '
      Me.PictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None
      Me.PictureBox5.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.chat_32x32_2
      Me.PictureBox5.Location = New System.Drawing.Point(7, -1)
      Me.PictureBox5.Name = "PictureBox5"
      Me.PictureBox5.Size = New System.Drawing.Size(32, 32)
      Me.PictureBox5.TabIndex = 2
      Me.PictureBox5.TabStop = False
      '
      'Label5
      '
      Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
      Me.Label5.AutoEllipsis = True
      Me.Label5.AutoSize = True
      Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label5.Location = New System.Drawing.Point(51, 9)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(96, 13)
      Me.Label5.TabIndex = 0
      Me.Label5.Text = "Proposte lavoro"
      '
      'DataGridViewProposte
      '
      DataGridViewCellStyle21.BackColor = System.Drawing.Color.LightSteelBlue
      DataGridViewCellStyle21.ForeColor = System.Drawing.Color.Black
      DataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.Orange
      DataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.Black
      Me.DataGridViewProposte.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle21
      Me.DataGridViewProposte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
      Me.DataGridViewProposte.BackgroundColor = System.Drawing.Color.White
      DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control
      DataGridViewCellStyle22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText
      DataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight
      DataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText
      DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
      Me.DataGridViewProposte.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle22
      Me.DataGridViewProposte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window
      DataGridViewCellStyle23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle23.ForeColor = System.Drawing.Color.Black
      DataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight
      DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText
      DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
      Me.DataGridViewProposte.DefaultCellStyle = DataGridViewCellStyle23
      Me.DataGridViewProposte.Dock = System.Windows.Forms.DockStyle.Fill
      Me.DataGridViewProposte.Location = New System.Drawing.Point(0, 0)
      Me.DataGridViewProposte.Name = "DataGridViewProposte"
      DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control
      DataGridViewCellStyle24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText
      DataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight
      DataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText
      DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
      Me.DataGridViewProposte.RowHeadersDefaultCellStyle = DataGridViewCellStyle24
      Me.DataGridViewProposte.RowHeadersVisible = False
      DataGridViewCellStyle25.ForeColor = System.Drawing.Color.Black
      DataGridViewCellStyle25.SelectionBackColor = System.Drawing.Color.Orange
      DataGridViewCellStyle25.SelectionForeColor = System.Drawing.Color.Black
      Me.DataGridViewProposte.RowsDefaultCellStyle = DataGridViewCellStyle25
      Me.DataGridViewProposte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
      Me.DataGridViewProposte.Size = New System.Drawing.Size(505, 96)
      Me.DataGridViewProposte.TabIndex = 3
      '
      'FrmRiepilogoAttivita
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(693, 527)
      Me.Controls.Add(Me.SplitContainer1)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
      Me.Name = "FrmRiepilogoAttivita"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Riepilogo attività "
      Me.SplitContainer1.Panel1.ResumeLayout(False)
      Me.SplitContainer1.Panel2.ResumeLayout(False)
      Me.SplitContainer1.ResumeLayout(False)
      Me.SplitContainer2.Panel1.ResumeLayout(False)
      Me.SplitContainer2.Panel2.ResumeLayout(False)
      Me.SplitContainer2.ResumeLayout(False)
      Me.SplitContainerDeleghe.Panel1.ResumeLayout(False)
      Me.SplitContainerDeleghe.Panel2.ResumeLayout(False)
      Me.SplitContainerDeleghe.ResumeLayout(False)
      Me.DockPanel.ResumeLayout(False)
      Me.DockPanel.PerformLayout()
      CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.datagridviewDeleghe, System.ComponentModel.ISupportInitialize).EndInit()
      Me.SplitContainerPrestazioni.Panel1.ResumeLayout(False)
      Me.SplitContainerPrestazioni.Panel2.ResumeLayout(False)
      Me.SplitContainerPrestazioni.ResumeLayout(False)
      Me.Panel1.ResumeLayout(False)
      Me.Panel1.PerformLayout()
      CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.DataGridViewPrestazioni, System.ComponentModel.ISupportInitialize).EndInit()
      Me.SplitContainer3.Panel1.ResumeLayout(False)
      Me.SplitContainer3.Panel2.ResumeLayout(False)
      Me.SplitContainer3.ResumeLayout(False)
      Me.SplitContainerComunicazioni.Panel1.ResumeLayout(False)
      Me.SplitContainerComunicazioni.Panel2.ResumeLayout(False)
      Me.SplitContainerComunicazioni.ResumeLayout(False)
      Me.Panel2.ResumeLayout(False)
      Me.Panel2.PerformLayout()
      CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.DataGridViewComunicazioni, System.ComponentModel.ISupportInitialize).EndInit()
      Me.SplitContainer4.Panel1.ResumeLayout(False)
      Me.SplitContainer4.Panel2.ResumeLayout(False)
      Me.SplitContainer4.ResumeLayout(False)
      Me.SplitContainerVertenze.Panel1.ResumeLayout(False)
      Me.SplitContainerVertenze.Panel2.ResumeLayout(False)
      Me.SplitContainerVertenze.ResumeLayout(False)
      Me.Panel3.ResumeLayout(False)
      Me.Panel3.PerformLayout()
      CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.DataGridViewVertenze, System.ComponentModel.ISupportInitialize).EndInit()
      Me.SplitContainerProposte.Panel1.ResumeLayout(False)
      Me.SplitContainerProposte.Panel2.ResumeLayout(False)
      Me.SplitContainerProposte.ResumeLayout(False)
      Me.Panel4.ResumeLayout(False)
      Me.Panel4.PerformLayout()
      CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
      CType(Me.DataGridViewProposte, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
   Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
   Friend WithEvents SplitContainer3 As System.Windows.Forms.SplitContainer
   Friend WithEvents SplitContainer4 As System.Windows.Forms.SplitContainer
   Friend WithEvents SplitContainerDeleghe As System.Windows.Forms.SplitContainer
   Friend WithEvents SplitContainerPrestazioni As System.Windows.Forms.SplitContainer
   Friend WithEvents SplitContainerComunicazioni As System.Windows.Forms.SplitContainer
   Friend WithEvents SplitContainerVertenze As System.Windows.Forms.SplitContainer
   Friend WithEvents SplitContainerProposte As System.Windows.Forms.SplitContainer
   Protected WithEvents DockPanel As System.Windows.Forms.Panel
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Protected WithEvents Panel1 As System.Windows.Forms.Panel
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Protected WithEvents Panel2 As System.Windows.Forms.Panel
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Protected WithEvents Panel3 As System.Windows.Forms.Panel
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Protected WithEvents Panel4 As System.Windows.Forms.Panel
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents TreeViewDeleghe As System.Windows.Forms.TreeView
   Friend WithEvents TreeViewPrestazioni As System.Windows.Forms.TreeView
   Friend WithEvents TreeViewComunicazioni As System.Windows.Forms.TreeView
   Friend WithEvents TreeViewVertenze As System.Windows.Forms.TreeView
   Friend WithEvents TreeViewProposte As System.Windows.Forms.TreeView
   Friend WithEvents datagridviewDeleghe As System.Windows.Forms.DataGridView
   Friend WithEvents DataGridViewPrestazioni As System.Windows.Forms.DataGridView
   Friend WithEvents DataGridViewComunicazioni As System.Windows.Forms.DataGridView
   Friend WithEvents DataGridViewVertenze As System.Windows.Forms.DataGridView
   Friend WithEvents DataGridViewProposte As System.Windows.Forms.DataGridView
   Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
   Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
   Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
   Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
   Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
   Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
   Friend WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents StatoDelega As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents DataDocumento As System.Windows.Forms.DataGridViewTextBoxColumn
   Friend WithEvents EnteInoltro As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
