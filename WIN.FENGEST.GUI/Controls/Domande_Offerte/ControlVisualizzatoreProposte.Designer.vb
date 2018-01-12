<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlVisualizzatoreProposte
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.lblDescrizioneUtente = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GridProposte = New System.Windows.Forms.DataGridView
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
        CType(Me.GridProposte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NiceGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DockPanel
        '
        Me.DockPanel.Controls.Add(Me.SpNew)
        Me.DockPanel.Controls.Add(Me.cmdPrint)
        Me.DockPanel.Controls.Add(Me.lblId)
        Me.DockPanel.Controls.Add(Me.IdUtenteTextBox1)
        '
        'lblDescrizioneUtente
        '
        Me.lblDescrizioneUtente.AutoSize = True
        Me.lblDescrizioneUtente.BackColor = System.Drawing.Color.Transparent
        Me.lblDescrizioneUtente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrizioneUtente.ForeColor = System.Drawing.Color.Black
        Me.HelpProvider1.SetHelpString(Me.lblDescrizioneUtente, "Cognome e nome dell'utente")
        Me.lblDescrizioneUtente.Location = New System.Drawing.Point(57, 30)
        Me.lblDescrizioneUtente.Name = "lblDescrizioneUtente"
        Me.HelpProvider1.SetShowHelp(Me.lblDescrizioneUtente, True)
        Me.lblDescrizioneUtente.Size = New System.Drawing.Size(12, 13)
        Me.lblDescrizioneUtente.TabIndex = 23
        Me.lblDescrizioneUtente.Text = "-"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.ItemSize = New System.Drawing.Size(71, 18)
        Me.TabControl1.Location = New System.Drawing.Point(16, 57)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(684, 236)
        Me.TabControl1.TabIndex = 22
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage1.Controls.Add(Me.GridProposte)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(676, 210)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Lista proposte"
        '
        'GridProposte
        '
        Me.GridProposte.AllowUserToAddRows = False
        Me.GridProposte.AllowUserToDeleteRows = False
        Me.GridProposte.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.NullValue = Nothing
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridProposte.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GridProposte.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.GridProposte.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GridProposte.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridProposte.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridProposte.DefaultCellStyle = DataGridViewCellStyle3
        Me.GridProposte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridProposte.GridColor = System.Drawing.Color.LightGray
        Me.GridProposte.Location = New System.Drawing.Point(3, 3)
        Me.GridProposte.Name = "GridProposte"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridProposte.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.GridProposte.RowHeadersWidth = 30
        Me.GridProposte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.GridProposte.Size = New System.Drawing.Size(670, 204)
        Me.GridProposte.TabIndex = 11
        '
        'IdUtenteTextBox1
        '
        Me.IdUtenteTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.IdUtenteTextBox1.DescriptionOfText = ""
        Me.IdUtenteTextBox1.DescriptionTextWidth = 150
        Me.IdUtenteTextBox1.DescriptionTextXValue = 92
        Me.IdUtenteTextBox1.EnableSerchTextBox = True
        Me.HelpProvider1.SetHelpString(Me.IdUtenteTextBox1, "Identificativo dell'utente")
        Me.IdUtenteTextBox1.IsDescriptionVisible = False
        Me.IdUtenteTextBox1.Location = New System.Drawing.Point(65, 12)
        Me.IdUtenteTextBox1.Mandatory = False
        Me.IdUtenteTextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.IdUtenteTextBox1.Name = "IdUtenteTextBox1"
        Me.HelpProvider1.SetShowHelp(Me.IdUtenteTextBox1, True)
        Me.IdUtenteTextBox1.Size = New System.Drawing.Size(106, 25)
        Me.IdUtenteTextBox1.TabIndex = 20
        Me.IdUtenteTextBox1.TextValue = ""
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.BackColor = System.Drawing.Color.Transparent
        Me.lblId.Location = New System.Drawing.Point(12, 17)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(52, 13)
        Me.lblId.TabIndex = 19
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
        Me.cmdPrint.Location = New System.Drawing.Point(263, 6)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Radius = 32.0!
        Me.cmdPrint.ShowTooltip = True
        Me.cmdPrint.Size = New System.Drawing.Size(32, 32)
        Me.cmdPrint.TabIndex = 116
        Me.cmdPrint.TextValue = ""
        Me.cmdPrint.TooltipText = "Stampa proposte"
        '
        'NiceGroupBox1
        '
        Me.NiceGroupBox1.Controls.Add(Me.Label1)
        Me.NiceGroupBox1.Controls.Add(Me.TabControl1)
        Me.NiceGroupBox1.Controls.Add(Me.lblDescrizioneUtente)
        Me.NiceGroupBox1.Location = New System.Drawing.Point(11, 86)
        Me.NiceGroupBox1.Name = "NiceGroupBox1"
        Me.NiceGroupBox1.Size = New System.Drawing.Size(719, 311)
        Me.NiceGroupBox1.TabIndex = 35
        Me.NiceGroupBox1.Title = "Lista proposte"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(13, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 24
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
        Me.HelpProvider1.SetHelpString(Me.SpNew, "Funzione che permette di creare una nuova proposta di lavoro per l'utente")
        Me.SpNew.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SpNew.Location = New System.Drawing.Point(310, 6)
        Me.SpNew.Name = "SpNew"
        Me.SpNew.Radius = 32.0!
        Me.HelpProvider1.SetShowHelp(Me.SpNew, True)
        Me.SpNew.ShowTooltip = True
        Me.SpNew.Size = New System.Drawing.Size(32, 32)
        Me.SpNew.TabIndex = 117
        Me.SpNew.TextValue = ""
        Me.SpNew.TooltipText = "Crea nuova proposta"
        '
        'ControlVisualizzatoreProposte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.NiceGroupBox1)
        Me.Name = "ControlVisualizzatoreProposte"
        Me.Size = New System.Drawing.Size(741, 416)
        Me.Controls.SetChildIndex(Me.DockPanel, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.NiceGroupBox1, 0)
        Me.DockPanel.ResumeLayout(False)
        Me.DockPanel.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.GridProposte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NiceGroupBox1.ResumeLayout(False)
        Me.NiceGroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
   Friend WithEvents lblDescrizioneUtente As System.Windows.Forms.Label
   Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
   Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
   Friend WithEvents GridProposte As System.Windows.Forms.DataGridView
    Friend WithEvents IdUtenteTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdUtenteTextBox
   Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents cmdPrint As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents NiceGroupBox1 As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SpNew As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider

End Class
