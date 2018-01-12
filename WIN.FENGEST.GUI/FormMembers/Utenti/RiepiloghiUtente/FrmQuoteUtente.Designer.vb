<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQuoteUtente
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.NiceGroupBox3 = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.GridIQI = New System.Windows.Forms.DataGridView()
        Me.NiceGroupBox4 = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.GridIQV = New System.Windows.Forms.DataGridView()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.NiceGroupBox2 = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.GridIQA = New System.Windows.Forms.DataGridView()
        Me.lblSettore = New System.Windows.Forms.Label()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.NiceGroupBox1 = New WIN.GUI.UTILITY.NiceGroupBox()
        Me.ControlSelPeriodiMensili1 = New WIN.GUI.APPLICATION.PRESENTATION.ControlSelPeriodiMensili()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.NiceGroupBox3.SuspendLayout()
        CType(Me.GridIQI, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NiceGroupBox4.SuspendLayout()
        CType(Me.GridIQV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.NiceGroupBox2.SuspendLayout()
        CType(Me.GridIQA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NiceGroupBox1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.SplitContainer2.Size = New System.Drawing.Size(780, 321)
        Me.SplitContainer2.SplitterDistance = 183
        Me.SplitContainer2.TabIndex = 1
        '
        'NiceGroupBox3
        '
        Me.NiceGroupBox3.Controls.Add(Me.GridIQI)
        Me.NiceGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NiceGroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.NiceGroupBox3.Name = "NiceGroupBox3"
        Me.NiceGroupBox3.Size = New System.Drawing.Size(780, 183)
        Me.NiceGroupBox3.TabIndex = 0
        Me.NiceGroupBox3.Title = "Incassi quote Inps"
        '
        'GridIQI
        '
        Me.GridIQI.AllowUserToAddRows = False
        Me.GridIQI.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.GridIQI.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.GridIQI.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridIQI.BackgroundColor = System.Drawing.Color.White
        Me.GridIQI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridIQI.Location = New System.Drawing.Point(15, 26)
        Me.GridIQI.MultiSelect = False
        Me.GridIQI.Name = "GridIQI"
        Me.GridIQI.ReadOnly = True
        Me.GridIQI.RowHeadersVisible = False
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.GridIQI.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.GridIQI.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.GridIQI.Size = New System.Drawing.Size(752, 149)
        Me.GridIQI.TabIndex = 1
        '
        'NiceGroupBox4
        '
        Me.NiceGroupBox4.Controls.Add(Me.GridIQV)
        Me.NiceGroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NiceGroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.NiceGroupBox4.Name = "NiceGroupBox4"
        Me.NiceGroupBox4.Size = New System.Drawing.Size(780, 134)
        Me.NiceGroupBox4.TabIndex = 1
        Me.NiceGroupBox4.Title = "Incass quote vertenza"
        '
        'GridIQV
        '
        Me.GridIQV.AllowUserToAddRows = False
        Me.GridIQV.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.GridIQV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.GridIQV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridIQV.BackgroundColor = System.Drawing.Color.White
        Me.GridIQV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridIQV.Location = New System.Drawing.Point(15, 26)
        Me.GridIQV.MultiSelect = False
        Me.GridIQV.Name = "GridIQV"
        Me.GridIQV.ReadOnly = True
        Me.GridIQV.RowHeadersVisible = False
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.GridIQV.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.GridIQV.Size = New System.Drawing.Size(752, 91)
        Me.GridIQV.TabIndex = 1
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
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
        Me.SplitContainer1.Size = New System.Drawing.Size(780, 513)
        Me.SplitContainer1.SplitterDistance = 188
        Me.SplitContainer1.TabIndex = 4
        '
        'NiceGroupBox2
        '
        Me.NiceGroupBox2.Controls.Add(Me.GridIQA)
        Me.NiceGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NiceGroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.NiceGroupBox2.Name = "NiceGroupBox2"
        Me.NiceGroupBox2.Size = New System.Drawing.Size(780, 188)
        Me.NiceGroupBox2.TabIndex = 0
        Me.NiceGroupBox2.Title = "Incassi quote associative"
        '
        'GridIQA
        '
        Me.GridIQA.AllowUserToAddRows = False
        Me.GridIQA.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        Me.GridIQA.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.GridIQA.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridIQA.BackgroundColor = System.Drawing.Color.White
        Me.GridIQA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridIQA.Location = New System.Drawing.Point(15, 26)
        Me.GridIQA.MultiSelect = False
        Me.GridIQA.Name = "GridIQA"
        Me.GridIQA.ReadOnly = True
        Me.GridIQA.RowHeadersVisible = False
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Orange
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.GridIQA.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.GridIQA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.GridIQA.Size = New System.Drawing.Size(752, 149)
        Me.GridIQA.TabIndex = 2
        '
        'lblSettore
        '
        Me.lblSettore.AutoSize = True
        Me.lblSettore.BackColor = System.Drawing.Color.Transparent
        Me.lblSettore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lblSettore.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettore.Location = New System.Drawing.Point(9, 35)
        Me.lblSettore.Name = "lblSettore"
        Me.lblSettore.Size = New System.Drawing.Size(66, 13)
        Me.lblSettore.TabIndex = 94
        Me.lblSettore.Text = "Competenza"
        '
        'cmdSearch
        '
        Me.cmdSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HelpProvider1.SetHelpString(Me.cmdSearch, "Funzione che permette di avviare la ricerca delle quote incassate per l'utente e " & _
        "i cui periodi di competenza intersecano l'intervallo temporale ""da-a""")
        Me.cmdSearch.Location = New System.Drawing.Point(697, 29)
        Me.cmdSearch.Name = "cmdSearch"
        Me.HelpProvider1.SetShowHelp(Me.cmdSearch, True)
        Me.cmdSearch.Size = New System.Drawing.Size(71, 24)
        Me.cmdSearch.TabIndex = 92
        Me.cmdSearch.Text = "Cerca"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'NiceGroupBox1
        '
        Me.NiceGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NiceGroupBox1.BackColor = System.Drawing.Color.White
        Me.NiceGroupBox1.Controls.Add(Me.lblSettore)
        Me.NiceGroupBox1.Controls.Add(Me.cmdSearch)
        Me.NiceGroupBox1.Controls.Add(Me.ControlSelPeriodiMensili1)
        Me.NiceGroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.NiceGroupBox1.Name = "NiceGroupBox1"
        Me.NiceGroupBox1.Size = New System.Drawing.Size(781, 100)
        Me.NiceGroupBox1.TabIndex = 3
        Me.NiceGroupBox1.Title = "Dati selezione"
        '
        'ControlSelPeriodiMensili1
        '
        Me.ControlSelPeriodiMensili1.BackColor = System.Drawing.Color.Transparent
        Me.HelpProvider1.SetHelpString(Me.ControlSelPeriodiMensili1, "Finestra temporale in cui si vogliono cercare incassi di quote per l'utente.Il si" & _
        "stema mostrerà soltanto quelle quote incassate i cui periodi di competenza inter" & _
        "sechino questo intervallo temporale.")
        Me.ControlSelPeriodiMensili1.Location = New System.Drawing.Point(107, 26)
        Me.ControlSelPeriodiMensili1.Name = "ControlSelPeriodiMensili1"
        Me.HelpProvider1.SetShowHelp(Me.ControlSelPeriodiMensili1, True)
        Me.ControlSelPeriodiMensili1.Size = New System.Drawing.Size(394, 31)
        Me.ControlSelPeriodiMensili1.TabIndex = 0
        '
        'FrmQuoteUtente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(805, 643)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.NiceGroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "FrmQuoteUtente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Riepilogo quote utente"
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.NiceGroupBox3.ResumeLayout(False)
        CType(Me.GridIQI, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NiceGroupBox4.ResumeLayout(False)
        CType(Me.GridIQV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.NiceGroupBox2.ResumeLayout(False)
        CType(Me.GridIQA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NiceGroupBox1.ResumeLayout(False)
        Me.NiceGroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
   Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
   Friend WithEvents NiceGroupBox3 As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents GridIQI As System.Windows.Forms.DataGridView
   Friend WithEvents NiceGroupBox4 As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents GridIQV As System.Windows.Forms.DataGridView
   Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
   Friend WithEvents NiceGroupBox2 As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents lblSettore As System.Windows.Forms.Label
   Friend WithEvents cmdSearch As System.Windows.Forms.Button
   Friend WithEvents NiceGroupBox1 As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents ControlSelPeriodiMensili1 As WIN.GUI.APPLICATION.PRESENTATION.ControlSelPeriodiMensili
    Friend WithEvents GridIQA As System.Windows.Forms.DataGridView
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
