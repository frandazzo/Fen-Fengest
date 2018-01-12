<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlVisualizzaPratiche
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblId = New System.Windows.Forms.Label()
        Me.IdUtenteTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdUtenteTextBox()
        Me.SpNew = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton()
        Me.NiceGroupBox1 = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GridPrestazioni = New System.Windows.Forms.DataGridView()
        Me.PraticaDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeTipoPraticaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StateNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GetOwnerOperatorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GetStateOperatorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PraticaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblDescrizioneUtente = New System.Windows.Forms.Label()
        Me.DockPanel.SuspendLayout()
        Me.NiceGroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.GridPrestazioni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PraticaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Size = New System.Drawing.Size(729, 30)
        '
        'DockPanel
        '
        Me.DockPanel.Controls.Add(Me.SpNew)
        Me.DockPanel.Controls.Add(Me.lblId)
        Me.DockPanel.Controls.Add(Me.IdUtenteTextBox1)
        Me.DockPanel.Size = New System.Drawing.Size(729, 44)
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.BackColor = System.Drawing.Color.Transparent
        Me.lblId.Location = New System.Drawing.Point(20, 14)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(52, 13)
        Me.lblId.TabIndex = 2
        Me.lblId.Text = "Id utente"
        '
        'IdUtenteTextBox1
        '
        Me.IdUtenteTextBox1.BackColor = System.Drawing.Color.Transparent
        Me.IdUtenteTextBox1.DescriptionOfText = ""
        Me.IdUtenteTextBox1.DescriptionTextWidth = 150
        Me.IdUtenteTextBox1.DescriptionTextXValue = 92
        Me.IdUtenteTextBox1.EnableSerchTextBox = True
        Me.IdUtenteTextBox1.IsDescriptionVisible = False
        Me.IdUtenteTextBox1.Location = New System.Drawing.Point(78, 10)
        Me.IdUtenteTextBox1.Mandatory = False
        Me.IdUtenteTextBox1.Margin = New System.Windows.Forms.Padding(0)
        Me.IdUtenteTextBox1.Name = "IdUtenteTextBox1"
        Me.IdUtenteTextBox1.Size = New System.Drawing.Size(97, 25)
        Me.IdUtenteTextBox1.TabIndex = 3
        Me.IdUtenteTextBox1.TextValue = ""
        '
        'SpNew
        '
        Me.SpNew.ApplyOutLookStile = True
        Me.SpNew.BackColor = System.Drawing.Color.Transparent
        Me.SpNew.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.file_new_32x32
        Me.SpNew.Disabled = False
        Me.SpNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SpNew.ForeColor = System.Drawing.Color.Transparent
        Me.SpNew.ImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SpNew.Location = New System.Drawing.Point(225, 3)
        Me.SpNew.Name = "SpNew"
        Me.SpNew.Radius = 32.0!
        Me.SpNew.ShowTooltip = True
        Me.SpNew.Size = New System.Drawing.Size(32, 32)
        Me.SpNew.TabIndex = 4
        Me.SpNew.TextValue = ""
        Me.SpNew.TooltipText = "Crea nuova pratica"
        '
        'NiceGroupBox1
        '
        Me.NiceGroupBox1.Controls.Add(Me.Label1)
        Me.NiceGroupBox1.Controls.Add(Me.TabControl1)
        Me.NiceGroupBox1.Controls.Add(Me.lblDescrizioneUtente)
        Me.NiceGroupBox1.Location = New System.Drawing.Point(3, 87)
        Me.NiceGroupBox1.Name = "NiceGroupBox1"
        Me.NiceGroupBox1.Size = New System.Drawing.Size(709, 337)
        Me.NiceGroupBox1.TabIndex = 37
        Me.NiceGroupBox1.Title = "Lista pratiche utente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(7, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Utente:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.ItemSize = New System.Drawing.Size(71, 18)
        Me.TabControl1.Location = New System.Drawing.Point(10, 49)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(683, 263)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage1.Controls.Add(Me.GridPrestazioni)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(675, 237)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Lista pratiche"
        '
        'GridPrestazioni
        '
        Me.GridPrestazioni.AllowUserToAddRows = False
        Me.GridPrestazioni.AllowUserToDeleteRows = False
        Me.GridPrestazioni.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.NullValue = Nothing
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridPrestazioni.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GridPrestazioni.AutoGenerateColumns = False
        Me.GridPrestazioni.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.GridPrestazioni.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.GridPrestazioni.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridPrestazioni.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.GridPrestazioni.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PraticaDateDataGridViewTextBoxColumn, Me.NomeTipoPraticaDataGridViewTextBoxColumn, Me.StateNameDataGridViewTextBoxColumn, Me.GetOwnerOperatorDataGridViewTextBoxColumn, Me.GetStateOperatorDataGridViewTextBoxColumn})
        Me.GridPrestazioni.DataSource = Me.PraticaBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(53, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridPrestazioni.DefaultCellStyle = DataGridViewCellStyle3
        Me.GridPrestazioni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridPrestazioni.GridColor = System.Drawing.Color.LightGray
        Me.GridPrestazioni.Location = New System.Drawing.Point(3, 3)
        Me.GridPrestazioni.Name = "GridPrestazioni"
        Me.GridPrestazioni.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GridPrestazioni.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.GridPrestazioni.RowHeadersWidth = 30
        Me.GridPrestazioni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.GridPrestazioni.Size = New System.Drawing.Size(669, 231)
        Me.GridPrestazioni.TabIndex = 0
        '
        'PraticaDateDataGridViewTextBoxColumn
        '
        Me.PraticaDateDataGridViewTextBoxColumn.DataPropertyName = "PraticaDate"
        Me.PraticaDateDataGridViewTextBoxColumn.HeaderText = "Data"
        Me.PraticaDateDataGridViewTextBoxColumn.Name = "PraticaDateDataGridViewTextBoxColumn"
        Me.PraticaDateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NomeTipoPraticaDataGridViewTextBoxColumn
        '
        Me.NomeTipoPraticaDataGridViewTextBoxColumn.DataPropertyName = "NomeTipoPratica"
        Me.NomeTipoPraticaDataGridViewTextBoxColumn.HeaderText = "Tipo pratica"
        Me.NomeTipoPraticaDataGridViewTextBoxColumn.Name = "NomeTipoPraticaDataGridViewTextBoxColumn"
        Me.NomeTipoPraticaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StateNameDataGridViewTextBoxColumn
        '
        Me.StateNameDataGridViewTextBoxColumn.DataPropertyName = "StateName"
        Me.StateNameDataGridViewTextBoxColumn.HeaderText = "Stato"
        Me.StateNameDataGridViewTextBoxColumn.Name = "StateNameDataGridViewTextBoxColumn"
        Me.StateNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GetOwnerOperatorDataGridViewTextBoxColumn
        '
        Me.GetOwnerOperatorDataGridViewTextBoxColumn.DataPropertyName = "GetOwnerOperator"
        Me.GetOwnerOperatorDataGridViewTextBoxColumn.HeaderText = "Proprietario"
        Me.GetOwnerOperatorDataGridViewTextBoxColumn.Name = "GetOwnerOperatorDataGridViewTextBoxColumn"
        Me.GetOwnerOperatorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GetStateOperatorDataGridViewTextBoxColumn
        '
        Me.GetStateOperatorDataGridViewTextBoxColumn.DataPropertyName = "GetStateOperator"
        Me.GetStateOperatorDataGridViewTextBoxColumn.HeaderText = "In carico a "
        Me.GetStateOperatorDataGridViewTextBoxColumn.Name = "GetStateOperatorDataGridViewTextBoxColumn"
        Me.GetStateOperatorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PraticaBindingSource
        '
        Me.PraticaBindingSource.DataSource = GetType(WIN.DOMAIN.FED_SERVICES.Pratica)
        '
        'lblDescrizioneUtente
        '
        Me.lblDescrizioneUtente.AutoSize = True
        Me.lblDescrizioneUtente.BackColor = System.Drawing.Color.Transparent
        Me.lblDescrizioneUtente.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescrizioneUtente.Location = New System.Drawing.Point(50, 26)
        Me.lblDescrizioneUtente.Name = "lblDescrizioneUtente"
        Me.lblDescrizioneUtente.Size = New System.Drawing.Size(0, 13)
        Me.lblDescrizioneUtente.TabIndex = 18
        '
        'ControlVisualizzaPratiche
        '
        Me.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.Controls.Add(Me.NiceGroupBox1)
        Me.Name = "ControlVisualizzaPratiche"
        Me.Size = New System.Drawing.Size(729, 437)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.DockPanel, 0)
        Me.Controls.SetChildIndex(Me.NiceGroupBox1, 0)
        Me.DockPanel.ResumeLayout(False)
        Me.DockPanel.PerformLayout()
        Me.NiceGroupBox1.ResumeLayout(False)
        Me.NiceGroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.GridPrestazioni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PraticaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblId As System.Windows.Forms.Label
    Friend WithEvents IdUtenteTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdUtenteTextBox
    Friend WithEvents SpNew As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents NiceGroupBox1 As WIN.GUI.UTILITY.NiceGroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GridPrestazioni As System.Windows.Forms.DataGridView
    Friend WithEvents lblDescrizioneUtente As System.Windows.Forms.Label
    Friend WithEvents PraticaDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomeTipoPraticaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StateNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GetOwnerOperatorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GetStateOperatorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PraticaBindingSource As System.Windows.Forms.BindingSource

End Class
