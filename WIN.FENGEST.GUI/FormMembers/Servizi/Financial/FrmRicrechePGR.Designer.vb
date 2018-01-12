<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRicrechePGR
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRicrechePGR))
      Me.GridPosizioni = New System.Windows.Forms.DataGridView
      Me.cmdAnnulla = New System.Windows.Forms.Button
      Me.cmdAdd = New System.Windows.Forms.Button
      Me.cmdDeselectAll = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.cmdSelectAll = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.CmdDown = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.cmdUp = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.CmdVis = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.ControlRicerchePGR1 = New WIN.GUI.APPLICATION.PRESENTATION.ControlRicerchePGR
      Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
      Me.lblStatus = New System.Windows.Forms.ToolStripStatusLabel
      Me.Panel1 = New System.Windows.Forms.Panel
      CType(Me.GridPosizioni, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.StatusStrip1.SuspendLayout()
      Me.Panel1.SuspendLayout()
      Me.SuspendLayout()
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
      Me.GridPosizioni.GridColor = System.Drawing.Color.WhiteSmoke
      Me.GridPosizioni.Location = New System.Drawing.Point(16, 294)
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
      Me.GridPosizioni.Size = New System.Drawing.Size(556, 197)
      Me.GridPosizioni.TabIndex = 15
      '
      'cmdAnnulla
      '
      Me.cmdAnnulla.Location = New System.Drawing.Point(487, 498)
      Me.cmdAnnulla.Name = "cmdAnnulla"
      Me.cmdAnnulla.Size = New System.Drawing.Size(85, 27)
      Me.cmdAnnulla.TabIndex = 72
      Me.cmdAnnulla.Text = "Annulla"
      Me.cmdAnnulla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.cmdAnnulla.UseVisualStyleBackColor = True
      '
      'cmdAdd
      '
      Me.cmdAdd.Location = New System.Drawing.Point(388, 497)
      Me.cmdAdd.Name = "cmdAdd"
      Me.cmdAdd.Size = New System.Drawing.Size(95, 28)
      Me.cmdAdd.TabIndex = 71
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
      Me.cmdDeselectAll.Location = New System.Drawing.Point(15, 128)
      Me.cmdDeselectAll.Name = "cmdDeselectAll"
      Me.cmdDeselectAll.Radius = 48.0!
      Me.cmdDeselectAll.ShowTooltip = True
      Me.cmdDeselectAll.Size = New System.Drawing.Size(48, 48)
      Me.cmdDeselectAll.TabIndex = 74
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
      Me.cmdSelectAll.Location = New System.Drawing.Point(14, 87)
      Me.cmdSelectAll.Name = "cmdSelectAll"
      Me.cmdSelectAll.Radius = 48.0!
      Me.cmdSelectAll.ShowTooltip = True
      Me.cmdSelectAll.Size = New System.Drawing.Size(48, 48)
      Me.cmdSelectAll.TabIndex = 73
      Me.cmdSelectAll.TextValue = ""
      Me.cmdSelectAll.TooltipText = "Seleziona tutto"
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
      Me.CmdDown.Location = New System.Drawing.Point(13, 3)
      Me.CmdDown.Name = "CmdDown"
      Me.CmdDown.Radius = 48.0!
      Me.CmdDown.ShowTooltip = True
      Me.CmdDown.Size = New System.Drawing.Size(48, 48)
      Me.CmdDown.TabIndex = 70
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
      Me.cmdUp.Location = New System.Drawing.Point(13, 45)
      Me.cmdUp.Name = "cmdUp"
      Me.cmdUp.Radius = 48.0!
      Me.cmdUp.ShowTooltip = True
      Me.cmdUp.Size = New System.Drawing.Size(48, 48)
      Me.cmdUp.TabIndex = 69
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
      Me.CmdVis.Location = New System.Drawing.Point(578, 28)
      Me.CmdVis.Name = "CmdVis"
      Me.CmdVis.Radius = 48.0!
      Me.CmdVis.ShowTooltip = True
      Me.CmdVis.Size = New System.Drawing.Size(48, 48)
      Me.CmdVis.TabIndex = 16
      Me.CmdVis.TextValue = ""
      Me.CmdVis.TooltipText = "Visualizza"
      '
      'ControlRicerchePGR1
      '
      Me.ControlRicerchePGR1.BackColor = System.Drawing.Color.Transparent
      Me.ControlRicerchePGR1.Location = New System.Drawing.Point(16, 5)
      Me.ControlRicerchePGR1.Name = "ControlRicerchePGR1"
      Me.ControlRicerchePGR1.Size = New System.Drawing.Size(570, 283)
      Me.ControlRicerchePGR1.TabIndex = 0
      '
      'StatusStrip1
      '
      Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblStatus})
      Me.StatusStrip1.Location = New System.Drawing.Point(0, 531)
      Me.StatusStrip1.Name = "StatusStrip1"
      Me.StatusStrip1.Size = New System.Drawing.Size(664, 22)
      Me.StatusStrip1.TabIndex = 75
      Me.StatusStrip1.Text = "StatusStrip1"
      '
      'lblStatus
      '
      Me.lblStatus.Name = "lblStatus"
      Me.lblStatus.Size = New System.Drawing.Size(39, 17)
      Me.lblStatus.Text = "Pronto"
      '
      'Panel1
      '
      Me.Panel1.BackColor = System.Drawing.Color.Transparent
      Me.Panel1.BackgroundImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.internalmenubar
      Me.Panel1.Controls.Add(Me.CmdDown)
      Me.Panel1.Controls.Add(Me.cmdUp)
      Me.Panel1.Controls.Add(Me.cmdDeselectAll)
      Me.Panel1.Controls.Add(Me.cmdSelectAll)
      Me.Panel1.Location = New System.Drawing.Point(578, 294)
      Me.Panel1.Name = "Panel1"
      Me.Panel1.Size = New System.Drawing.Size(79, 181)
      Me.Panel1.TabIndex = 76
      '
      'FrmRicrechePGR
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(664, 553)
      Me.Controls.Add(Me.Panel1)
      Me.Controls.Add(Me.StatusStrip1)
      Me.Controls.Add(Me.cmdAnnulla)
      Me.Controls.Add(Me.cmdAdd)
      Me.Controls.Add(Me.CmdVis)
      Me.Controls.Add(Me.GridPosizioni)
      Me.Controls.Add(Me.ControlRicerchePGR1)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "FrmRicrechePGR"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Ricerca posizioni pagamento referente"
      CType(Me.GridPosizioni, System.ComponentModel.ISupportInitialize).EndInit()
      Me.StatusStrip1.ResumeLayout(False)
      Me.StatusStrip1.PerformLayout()
      Me.Panel1.ResumeLayout(False)
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents ControlRicerchePGR1 As WIN.GUI.APPLICATION.PRESENTATION.ControlRicerchePGR
   Friend WithEvents GridPosizioni As System.Windows.Forms.DataGridView
   Friend WithEvents CmdVis As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents CmdDown As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents cmdUp As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents cmdAnnulla As System.Windows.Forms.Button
   Friend WithEvents cmdAdd As System.Windows.Forms.Button
   Friend WithEvents cmdDeselectAll As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents cmdSelectAll As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
