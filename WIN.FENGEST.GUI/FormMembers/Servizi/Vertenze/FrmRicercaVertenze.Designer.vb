<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRicercaVertenze
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
      Me.GridPosizioni = New System.Windows.Forms.DataGridView
      Me.ControlRicrcheIQV1 = New WIN.GUI.APPLICATION.PRESENTATION.ControlRicrcheIQV
      Me.cmdCerca = New System.Windows.Forms.Button
      CType(Me.GridPosizioni, System.ComponentModel.ISupportInitialize).BeginInit()
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
      DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkOrange
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
      Me.GridPosizioni.Location = New System.Drawing.Point(12, 184)
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
      Me.GridPosizioni.Size = New System.Drawing.Size(604, 183)
      Me.GridPosizioni.TabIndex = 73
      '
      'ControlRicrcheIQV1
      '
      Me.ControlRicrcheIQV1.BackColor = System.Drawing.Color.Transparent
      Me.ControlRicrcheIQV1.Location = New System.Drawing.Point(12, 16)
      Me.ControlRicrcheIQV1.Name = "ControlRicrcheIQV1"
      Me.ControlRicrcheIQV1.Size = New System.Drawing.Size(525, 162)
      Me.ControlRicrcheIQV1.TabIndex = 75
      '
      'cmdCerca
      '
      Me.cmdCerca.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.show_16x16
      Me.cmdCerca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.cmdCerca.Location = New System.Drawing.Point(543, 147)
      Me.cmdCerca.Name = "cmdCerca"
      Me.cmdCerca.Size = New System.Drawing.Size(73, 24)
      Me.cmdCerca.TabIndex = 76
      Me.cmdCerca.Text = "Cerca"
      Me.cmdCerca.TextAlign = System.Drawing.ContentAlignment.MiddleRight
      Me.cmdCerca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.cmdCerca.UseVisualStyleBackColor = True
      '
      'FrmRicercaVertenze
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(632, 380)
      Me.Controls.Add(Me.cmdCerca)
      Me.Controls.Add(Me.ControlRicrcheIQV1)
      Me.Controls.Add(Me.GridPosizioni)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "FrmRicercaVertenze"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Ricerca vertenze"
      CType(Me.GridPosizioni, System.ComponentModel.ISupportInitialize).EndInit()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents GridPosizioni As System.Windows.Forms.DataGridView
   Friend WithEvents ControlRicrcheIQV1 As WIN.GUI.APPLICATION.PRESENTATION.ControlRicrcheIQV
   Friend WithEvents cmdCerca As System.Windows.Forms.Button
End Class
