<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlVisualizzaVertenze
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

    'NOTA: la procedura che segue � richiesta da Progettazione Windows Form
    'Pu� essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblDescrizioneUtente = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GridVertenze = New System.Windows.Forms.DataGridView
        Me.IdUtenteTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdUtenteTextBox
        Me.lblId = New System.Windows.Forms.Label
        Me.cmdPrint = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
        Me.NiceGroupBox1 = New WIN.GUI.UTILITY.NiceGroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SpNew = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
        Me.DockPanel.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.GridVertenze, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NiceGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Size = New System.Drawing.Size(731, 22)
        '
        'DockPanel
        '
        Me.DockPanel.Controls.Add(Me.SpNew)
        Me.DockPanel.Controls.Add(Me.cmdPrint)
        Me.DockPanel.Controls.Add(Me.IdUtenteTextBox1)
        Me.DockPanel.Location = New System.Drawing.Point(0, 22)
        Me.DockPanel.Size = New System.Drawing.Size(731, 44)
        Me.DockPanel.TabIndex = 0
        '
        'lblDescrizioneUtente
        '
        Me.lblDescrizioneUtente.AutoSize = True
        Me.lblDescrizioneUtente.BackColor = System.Drawing.Color.Transparent
        Me.lblDescrizioneUtente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrizioneUtente.Location = New System.Drawing.Point(50, 32)
        Me.lblDescrizioneUtente.Name = "lblDescrizioneUtente"
        Me.lblDescrizioneUtente.Size = New System.Drawing.Size(0, 13)
        Me.lblDescrizioneUtente.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.ItemSize = New System.Drawing.Size(71, 18)
        Me.TabControl1.Location = New System.Drawing.Point(10, 61)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(683, 236)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage1.Controls.Add(Me.GridVertenze)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(675, 210)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Lista vertenze"
        '
        'GridVertenze
        '
        Me.GridVertenze.AllowUserToAddRows = False
        Me.GridVertenze.AllowUserToDeleteRows = False
        Me.GridVertenze.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.NullValue = Nothing
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridVertenze.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GridVertenze.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.GridVertenze.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GridVertenze.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridVertenze.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridVertenze.DefaultCellStyle = DataGridViewCellStyle3
        Me.GridVertenze.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridVertenze.GridColor = System.Drawing.Color.LightGray
        Me.GridVertenze.Location = New System.Drawing.Point(3, 3)
        Me.GridVertenze.Name = "GridVertenze"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridVertenze.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.GridVertenze.RowHeadersWidth = 30
        Me.GridVertenze.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.GridVertenze.Size = New System.Drawing.Size(669, 204)
        Me.GridVertenze.TabIndex = 0
        '
        'IdUtenteTextBox1
        '
        Me.IdUtenteTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.IdUtenteTextBox1.DescriptionOfText = ""
        Me.IdUtenteTextBox1.DescriptionTextWidth = 150
        Me.IdUtenteTextBox1.DescriptionTextXValue = 92
        Me.IdUtenteTextBox1.EnableSerchTextBox = True
        Me.HelpProvider1.SetHelpString(Me.IdUtenteTextBox1, "Identificativo dell'utente parte in causa della vertenza.")
        Me.IdUtenteTextBox1.IsDescriptionVisible = False
        Me.IdUtenteTextBox1.Location = New System.Drawing.Point(64, 11)
        Me.IdUtenteTextBox1.Mandatory = False
        Me.IdUtenteTextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.IdUtenteTextBox1.Name = "IdUtenteTextBox1"
        Me.HelpProvider1.SetShowHelp(Me.IdUtenteTextBox1, True)
        Me.IdUtenteTextBox1.Size = New System.Drawing.Size(106, 23)
        Me.IdUtenteTextBox1.TabIndex = 0
        Me.IdUtenteTextBox1.TextValue = ""
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.BackColor = System.Drawing.Color.Transparent
        Me.lblId.Location = New System.Drawing.Point(10, 39)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(52, 13)
        Me.lblId.TabIndex = 1
        Me.lblId.Text = "Id utente"
        '
        'cmdPrint
        '
        Me.cmdPrint.ApplyOutLookStile = True
        Me.cmdPrint.BackColor = System.Drawing.Color.Transparent
        Me.cmdPrint.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.print_32x32_active
        Me.cmdPrint.Disabled = False
        Me.cmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdPrint.ForeColor = System.Drawing.Color.Transparent
        Me.cmdPrint.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.cmdPrint.Location = New System.Drawing.Point(258, 7)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Radius = 32.0!
        Me.cmdPrint.ShowTooltip = True
        Me.cmdPrint.Size = New System.Drawing.Size(32, 32)
        Me.cmdPrint.TabIndex = 1
        Me.cmdPrint.TextValue = ""
        Me.cmdPrint.TooltipText = "Stampa vertenze"
        '
        'NiceGroupBox1
        '
        Me.NiceGroupBox1.Controls.Add(Me.Label1)
        Me.NiceGroupBox1.Controls.Add(Me.TabControl1)
        Me.NiceGroupBox1.Controls.Add(Me.lblDescrizioneUtente)
        Me.NiceGroupBox1.Location = New System.Drawing.Point(11, 80)
        Me.NiceGroupBox1.Name = "NiceGroupBox1"
        Me.NiceGroupBox1.Size = New System.Drawing.Size(709, 315)
        Me.NiceGroupBox1.TabIndex = 2
        Me.NiceGroupBox1.Title = "Lista vertenze"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(7, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Utente:"
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
        Me.SpNew.Location = New System.Drawing.Point(296, 7)
        Me.SpNew.Name = "SpNew"
        Me.SpNew.Radius = 32.0!
        Me.HelpProvider1.SetShowHelp(Me.SpNew, True)
        Me.SpNew.ShowTooltip = True
        Me.SpNew.Size = New System.Drawing.Size(32, 32)
        Me.SpNew.TabIndex = 2
        Me.SpNew.TextValue = ""
        Me.SpNew.TooltipText = "Crea nuova vertenza"
        '
        'ControlVisualizzaVertenze
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.NiceGroupBox1)
        Me.Controls.Add(Me.lblId)
        Me.Name = "ControlVisualizzaVertenze"
        Me.Size = New System.Drawing.Size(731, 437)
        Me.Controls.SetChildIndex(Me.DockPanel, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.lblId, 0)
        Me.Controls.SetChildIndex(Me.NiceGroupBox1, 0)
        Me.DockPanel.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.GridVertenze, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NiceGroupBox1.ResumeLayout(False)
        Me.NiceGroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
   Friend WithEvents lblDescrizioneUtente As System.Windows.Forms.Label
   Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
   Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
   Friend WithEvents GridVertenze As System.Windows.Forms.DataGridView
    Friend WithEvents IdUtenteTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdUtenteTextBox
   Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents cmdPrint As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents NiceGroupBox1 As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SpNew As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider

End Class