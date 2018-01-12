<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRicercheIQI
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
      Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRicercheIQI))
      Me.CmdDown = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.cmdUp = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.CmdVis = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.GridPosizioni = New System.Windows.Forms.DataGridView
      Me.ControlRicercheIQI1 = New WIN.GUI.APPLICATION.PRESENTATION.ControlRicercheIQI
      Me.cmdAnnulla = New System.Windows.Forms.Button
      Me.cmdAdd = New System.Windows.Forms.Button
      Me.cmdDeselectAll = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.cmdSelectAll = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.Panel1 = New System.Windows.Forms.Panel
      CType(Me.GridPosizioni, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.Panel1.SuspendLayout()
      Me.SuspendLayout()
      '
      'CmdDown
      '
      Me.CmdDown.ApplyOutLookStile = True
      Me.CmdDown.BackColor = System.Drawing.Color.Transparent
      Me.CmdDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.CmdDown.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.package_edutainment_48x48_up
      Me.CmdDown.Disabled = False
      Me.CmdDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.CmdDown.ForeColor = System.Drawing.Color.Transparent
      Me.CmdDown.Location = New System.Drawing.Point(13, 43)
      Me.CmdDown.Name = "CmdDown"
      Me.CmdDown.Radius = 48.0!
      Me.CmdDown.ShowTooltip = True
      Me.CmdDown.Size = New System.Drawing.Size(48, 48)
      Me.CmdDown.TabIndex = 74
      Me.CmdDown.TextValue = ""
      Me.CmdDown.TooltipText = "Ordina dal basso"
      '
      'cmdUp
      '
      Me.cmdUp.ApplyOutLookStile = True
      Me.cmdUp.BackColor = System.Drawing.Color.Transparent
      Me.cmdUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.cmdUp.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.package_edutainment_48x48_down
      Me.cmdUp.Disabled = False
      Me.cmdUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.cmdUp.ForeColor = System.Drawing.Color.Transparent
      Me.cmdUp.Location = New System.Drawing.Point(13, 2)
      Me.cmdUp.Name = "cmdUp"
      Me.cmdUp.Radius = 48.0!
      Me.cmdUp.ShowTooltip = True
      Me.cmdUp.Size = New System.Drawing.Size(48, 48)
      Me.cmdUp.TabIndex = 73
      Me.cmdUp.TextValue = ""
      Me.cmdUp.TooltipText = "Ordina dall'alto"
      '
      'CmdVis
      '
      Me.CmdVis.ApplyOutLookStile = True
      Me.CmdVis.BackColor = System.Drawing.Color.Transparent
      Me.CmdVis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.CmdVis.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.k_ghost_view_48x48
      Me.CmdVis.Disabled = False
      Me.CmdVis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.CmdVis.ForeColor = System.Drawing.Color.Transparent
      Me.CmdVis.Location = New System.Drawing.Point(537, 37)
      Me.CmdVis.Name = "CmdVis"
      Me.CmdVis.Radius = 48.0!
      Me.CmdVis.ShowTooltip = True
      Me.CmdVis.Size = New System.Drawing.Size(48, 48)
      Me.CmdVis.TabIndex = 72
      Me.CmdVis.TextValue = ""
      Me.CmdVis.TooltipText = "Visualizza"
      '
      'GridPosizioni
      '
      Me.GridPosizioni.AllowUserToAddRows = False
      Me.GridPosizioni.AllowUserToDeleteRows = False
      Me.GridPosizioni.AllowUserToOrderColumns = True
      DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue
      DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
      DataGridViewCellStyle1.NullValue = Nothing
      DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Orange
      DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
      DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
      Me.GridPosizioni.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
      Me.GridPosizioni.BackgroundColor = System.Drawing.Color.WhiteSmoke
      Me.GridPosizioni.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
      Me.GridPosizioni.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
      DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray
      DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
      DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray
      DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
      DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
      Me.GridPosizioni.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
      DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
      DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
      DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray
      DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
      DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
      Me.GridPosizioni.DefaultCellStyle = DataGridViewCellStyle3
      Me.GridPosizioni.GridColor = System.Drawing.Color.LightGray
      Me.GridPosizioni.Location = New System.Drawing.Point(12, 281)
      Me.GridPosizioni.Name = "GridPosizioni"
      DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
      DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
      DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
      DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Gray
      DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
      DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
      Me.GridPosizioni.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
      Me.GridPosizioni.RowHeadersVisible = False
      Me.GridPosizioni.RowHeadersWidth = 30
      DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
      DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Orange
      DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
      Me.GridPosizioni.RowsDefaultCellStyle = DataGridViewCellStyle5
      Me.GridPosizioni.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
      Me.GridPosizioni.Size = New System.Drawing.Size(576, 183)
      Me.GridPosizioni.TabIndex = 71
      '
      'ControlRicercheIQI1
      '
      Me.ControlRicercheIQI1.BackColor = System.Drawing.Color.Transparent
      Me.ControlRicercheIQI1.Location = New System.Drawing.Point(9, 15)
      Me.ControlRicercheIQI1.Name = "ControlRicercheIQI1"
      Me.ControlRicercheIQI1.Size = New System.Drawing.Size(531, 251)
      Me.ControlRicercheIQI1.TabIndex = 75
      '
      'cmdAnnulla
      '
      Me.cmdAnnulla.Location = New System.Drawing.Point(503, 472)
      Me.cmdAnnulla.Name = "cmdAnnulla"
      Me.cmdAnnulla.Size = New System.Drawing.Size(85, 27)
      Me.cmdAnnulla.TabIndex = 77
      Me.cmdAnnulla.Text = "Annulla"
      Me.cmdAnnulla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.cmdAnnulla.UseVisualStyleBackColor = True
      '
      'cmdAdd
      '
      Me.cmdAdd.Location = New System.Drawing.Point(402, 471)
      Me.cmdAdd.Name = "cmdAdd"
      Me.cmdAdd.Size = New System.Drawing.Size(95, 28)
      Me.cmdAdd.TabIndex = 76
      Me.cmdAdd.Text = "Aggiungi"
      Me.cmdAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.cmdAdd.UseVisualStyleBackColor = True
      '
      'cmdDeselectAll
      '
      Me.cmdDeselectAll.ApplyOutLookStile = True
      Me.cmdDeselectAll.BackColor = System.Drawing.Color.Transparent
      Me.cmdDeselectAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.cmdDeselectAll.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.kate_48x48_disabled
      Me.cmdDeselectAll.Disabled = False
      Me.cmdDeselectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.cmdDeselectAll.ForeColor = System.Drawing.Color.Transparent
      Me.cmdDeselectAll.Location = New System.Drawing.Point(17, 128)
      Me.cmdDeselectAll.Name = "cmdDeselectAll"
      Me.cmdDeselectAll.Radius = 48.0!
      Me.cmdDeselectAll.ShowTooltip = True
      Me.cmdDeselectAll.Size = New System.Drawing.Size(48, 48)
      Me.cmdDeselectAll.TabIndex = 79
      Me.cmdDeselectAll.TextValue = ""
      Me.cmdDeselectAll.TooltipText = "Deseleziona tutto"
      '
      'cmdSelectAll
      '
      Me.cmdSelectAll.ApplyOutLookStile = True
      Me.cmdSelectAll.BackColor = System.Drawing.Color.Transparent
      Me.cmdSelectAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.cmdSelectAll.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.kate_48x48
      Me.cmdSelectAll.Disabled = False
      Me.cmdSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.cmdSelectAll.ForeColor = System.Drawing.Color.Transparent
      Me.cmdSelectAll.Location = New System.Drawing.Point(17, 86)
      Me.cmdSelectAll.Name = "cmdSelectAll"
      Me.cmdSelectAll.Radius = 48.0!
      Me.cmdSelectAll.ShowTooltip = True
      Me.cmdSelectAll.Size = New System.Drawing.Size(48, 48)
      Me.cmdSelectAll.TabIndex = 78
      Me.cmdSelectAll.TextValue = ""
      Me.cmdSelectAll.TooltipText = "Seleziona tutto"
      '
      'Panel1
      '
      Me.Panel1.BackgroundImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.internalmenubar
      Me.Panel1.Controls.Add(Me.cmdUp)
      Me.Panel1.Controls.Add(Me.cmdDeselectAll)
      Me.Panel1.Controls.Add(Me.CmdDown)
      Me.Panel1.Controls.Add(Me.cmdSelectAll)
      Me.Panel1.Location = New System.Drawing.Point(591, 281)
      Me.Panel1.Name = "Panel1"
      Me.Panel1.Size = New System.Drawing.Size(80, 180)
      Me.Panel1.TabIndex = 80
      '
      'FrmRicercheIQI
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(681, 509)
      Me.Controls.Add(Me.Panel1)
      Me.Controls.Add(Me.cmdAnnulla)
      Me.Controls.Add(Me.cmdAdd)
      Me.Controls.Add(Me.ControlRicercheIQI1)
      Me.Controls.Add(Me.CmdVis)
      Me.Controls.Add(Me.GridPosizioni)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "FrmRicercheIQI"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Ricerca prestazioni"
      CType(Me.GridPosizioni, System.ComponentModel.ISupportInitialize).EndInit()
      Me.Panel1.ResumeLayout(False)
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents CmdDown As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents cmdUp As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents CmdVis As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents GridPosizioni As System.Windows.Forms.DataGridView
   Friend WithEvents ControlRicercheIQI1 As WIN.GUI.APPLICATION.PRESENTATION.ControlRicercheIQI
   Friend WithEvents cmdAnnulla As System.Windows.Forms.Button
   Friend WithEvents cmdAdd As System.Windows.Forms.Button
   Friend WithEvents cmdDeselectAll As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents cmdSelectAll As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
