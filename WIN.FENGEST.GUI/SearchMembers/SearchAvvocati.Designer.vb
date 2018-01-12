<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchAvvocati
   Inherits System.Windows.Forms.Form

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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchAvvocati))
      Me.cmdCerca = New System.Windows.Forms.Button
      Me.GridAziende = New System.Windows.Forms.DataGridView
      Me.TabControl1 = New System.Windows.Forms.TabControl
      Me.TabPage1 = New System.Windows.Forms.TabPage
      Me.txtNome = New System.Windows.Forms.TextBox
      Me.Label2 = New System.Windows.Forms.Label
      CType(Me.GridAziende, System.ComponentModel.ISupportInitialize).BeginInit()
      Me.TabControl1.SuspendLayout()
      Me.TabPage1.SuspendLayout()
      Me.SuspendLayout()
      '
      'cmdCerca
      '
      Me.cmdCerca.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.show_16x16
      Me.cmdCerca.Location = New System.Drawing.Point(369, 36)
      Me.cmdCerca.Name = "cmdCerca"
      Me.cmdCerca.Size = New System.Drawing.Size(64, 26)
      Me.cmdCerca.TabIndex = 2
      Me.cmdCerca.Text = "Cerca"
      Me.cmdCerca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.cmdCerca.UseVisualStyleBackColor = True
      '
      'GridAziende
      '
      Me.GridAziende.AllowUserToAddRows = False
      Me.GridAziende.AllowUserToDeleteRows = False
      Me.GridAziende.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
      Me.GridAziende.Location = New System.Drawing.Point(12, 112)
      Me.GridAziende.Name = "GridAziende"
      Me.GridAziende.ReadOnly = True
      Me.GridAziende.Size = New System.Drawing.Size(429, 196)
      Me.GridAziende.TabIndex = 3
      '
      'TabControl1
      '
      Me.TabControl1.Controls.Add(Me.TabPage1)
      Me.TabControl1.Location = New System.Drawing.Point(12, 14)
      Me.TabControl1.Name = "TabControl1"
      Me.TabControl1.SelectedIndex = 0
      Me.TabControl1.Size = New System.Drawing.Size(335, 92)
      Me.TabControl1.TabIndex = 1
      '
      'TabPage1
      '
      Me.TabPage1.Controls.Add(Me.txtNome)
      Me.TabPage1.Controls.Add(Me.Label2)
      Me.TabPage1.Location = New System.Drawing.Point(4, 22)
      Me.TabPage1.Name = "TabPage1"
      Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
      Me.TabPage1.Size = New System.Drawing.Size(327, 66)
      Me.TabPage1.TabIndex = 0
      Me.TabPage1.Text = "Ricerca avvocato"
      Me.TabPage1.UseVisualStyleBackColor = True
      '
      'txtNome
      '
      Me.txtNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.txtNome.Location = New System.Drawing.Point(73, 16)
      Me.txtNome.Name = "txtNome"
      Me.txtNome.Size = New System.Drawing.Size(198, 20)
      Me.txtNome.TabIndex = 1
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.Label2.Location = New System.Drawing.Point(12, 23)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(53, 13)
      Me.Label2.TabIndex = 2
      Me.Label2.Text = "Rag. soc."
      '
      'SearchAvvocati
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(453, 314)
      Me.Controls.Add(Me.cmdCerca)
      Me.Controls.Add(Me.GridAziende)
      Me.Controls.Add(Me.TabControl1)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.Name = "SearchAvvocati"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Ricerca avvocati"
      CType(Me.GridAziende, System.ComponentModel.ISupportInitialize).EndInit()
      Me.TabControl1.ResumeLayout(False)
      Me.TabPage1.ResumeLayout(False)
      Me.TabPage1.PerformLayout()
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents cmdCerca As System.Windows.Forms.Button
   Friend WithEvents GridAziende As System.Windows.Forms.DataGridView
   Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
   Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
   Friend WithEvents txtNome As System.Windows.Forms.TextBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
