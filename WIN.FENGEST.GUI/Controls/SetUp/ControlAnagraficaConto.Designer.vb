<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlAnagraficaConto
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
      Me.lblId = New System.Windows.Forms.Label
      Me.TabPage1 = New System.Windows.Forms.TabPage
      Me.Label3 = New System.Windows.Forms.Label
      Me.cboValuta = New System.Windows.Forms.ComboBox
      Me.txtDescrizione = New System.Windows.Forms.TextBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.TabControl1 = New System.Windows.Forms.TabControl
      Me.IdContoTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdContoTextBox
      Me.cmdVisualizza = New System.Windows.Forms.Button
      Me.NiceGroupBox1 = New WIN.GUI.UTILITY.NiceGroupBox
      Me.DockPanel.SuspendLayout()
      Me.TabPage1.SuspendLayout()
      Me.TabControl1.SuspendLayout()
      Me.NiceGroupBox1.SuspendLayout()
      Me.SuspendLayout()
      '
      'Panel2
      '
      Me.Panel2.Size = New System.Drawing.Size(747, 30)
      '
      'DockPanel
      '
      Me.DockPanel.Controls.Add(Me.lblId)
      Me.DockPanel.Controls.Add(Me.IdContoTextBox1)
      Me.DockPanel.Controls.Add(Me.cmdVisualizza)
      Me.DockPanel.Location = New System.Drawing.Point(1, 30)
      Me.DockPanel.Size = New System.Drawing.Size(746, 44)
      '
      'lblId
      '
      Me.lblId.AutoSize = True
      Me.lblId.BackColor = System.Drawing.Color.Transparent
      Me.lblId.Location = New System.Drawing.Point(11, 17)
      Me.lblId.Name = "lblId"
      Me.lblId.Size = New System.Drawing.Size(47, 13)
      Me.lblId.TabIndex = 2
      Me.lblId.Text = "Id conto"
      '
      'TabPage1
      '
      Me.TabPage1.Controls.Add(Me.Label3)
      Me.TabPage1.Controls.Add(Me.cboValuta)
      Me.TabPage1.Controls.Add(Me.txtDescrizione)
      Me.TabPage1.Controls.Add(Me.Label1)
      Me.TabPage1.Location = New System.Drawing.Point(4, 22)
      Me.TabPage1.Name = "TabPage1"
      Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
      Me.TabPage1.Size = New System.Drawing.Size(275, 114)
      Me.TabPage1.TabIndex = 0
      Me.TabPage1.Text = "Dati generali"
      Me.TabPage1.UseVisualStyleBackColor = True
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Location = New System.Drawing.Point(39, 69)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(37, 13)
      Me.Label3.TabIndex = 5
      Me.Label3.Text = "Valuta"
      '
      'cboValuta
      '
      Me.cboValuta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cboValuta.Enabled = False
      Me.cboValuta.FormattingEnabled = True
      Me.cboValuta.Items.AddRange(New Object() {"Euro", "Dollaro"})
      Me.cboValuta.Location = New System.Drawing.Point(82, 61)
      Me.cboValuta.Name = "cboValuta"
      Me.cboValuta.Size = New System.Drawing.Size(82, 21)
      Me.cboValuta.TabIndex = 4
      '
      'txtDescrizione
      '
      Me.txtDescrizione.Location = New System.Drawing.Point(82, 17)
      Me.txtDescrizione.Name = "txtDescrizione"
      Me.txtDescrizione.Size = New System.Drawing.Size(132, 21)
      Me.txtDescrizione.TabIndex = 3
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(8, 24)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(68, 13)
      Me.Label1.TabIndex = 2
      Me.Label1.Text = "Descr. conto"
      '
      'TabControl1
      '
      Me.TabControl1.Controls.Add(Me.TabPage1)
      Me.TabControl1.Location = New System.Drawing.Point(15, 34)
      Me.TabControl1.Name = "TabControl1"
      Me.TabControl1.SelectedIndex = 0
      Me.TabControl1.Size = New System.Drawing.Size(283, 140)
      Me.TabControl1.TabIndex = 4
      '
      'IdContoTextBox1
      '
      Me.IdContoTextBox1.BackColor = System.Drawing.Color.Transparent
      Me.IdContoTextBox1.EnableSerchTextBox = True
      Me.IdContoTextBox1.Location = New System.Drawing.Point(61, 11)
      Me.IdContoTextBox1.Margin = New System.Windows.Forms.Padding(0)
      Me.IdContoTextBox1.Name = "IdContoTextBox1"
      Me.IdContoTextBox1.Size = New System.Drawing.Size(169, 23)
      Me.IdContoTextBox1.TabIndex = 5
      Me.IdContoTextBox1.TextValue = ""
      '
      'cmdVisualizza
      '
      Me.cmdVisualizza.BackColor = System.Drawing.SystemColors.Control
      Me.cmdVisualizza.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
      Me.cmdVisualizza.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
      Me.cmdVisualizza.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
      Me.cmdVisualizza.FlatStyle = System.Windows.Forms.FlatStyle.System
      Me.cmdVisualizza.Location = New System.Drawing.Point(233, 11)
      Me.cmdVisualizza.Name = "cmdVisualizza"
      Me.cmdVisualizza.Size = New System.Drawing.Size(64, 25)
      Me.cmdVisualizza.TabIndex = 6
      Me.cmdVisualizza.Text = "Visualizza"
      Me.cmdVisualizza.UseVisualStyleBackColor = False
      '
      'NiceGroupBox1
      '
      Me.NiceGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.NiceGroupBox1.Controls.Add(Me.TabControl1)
      Me.NiceGroupBox1.Location = New System.Drawing.Point(15, 92)
      Me.NiceGroupBox1.Name = "NiceGroupBox1"
      Me.NiceGroupBox1.Size = New System.Drawing.Size(721, 189)
      Me.NiceGroupBox1.TabIndex = 35
      Me.NiceGroupBox1.Title = "Dati Generali"
      '
      'ControlAnagraficaConto
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.Controls.Add(Me.NiceGroupBox1)
      Me.Name = "ControlAnagraficaConto"
      Me.Size = New System.Drawing.Size(747, 298)
      Me.Controls.SetChildIndex(Me.NiceGroupBox1, 0)
      Me.Controls.SetChildIndex(Me.DockPanel, 0)
      Me.Controls.SetChildIndex(Me.Panel2, 0)
      Me.DockPanel.ResumeLayout(False)
      Me.DockPanel.PerformLayout()
      Me.TabPage1.ResumeLayout(False)
      Me.TabPage1.PerformLayout()
      Me.TabControl1.ResumeLayout(False)
      Me.NiceGroupBox1.ResumeLayout(False)
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents lblId As System.Windows.Forms.Label
   Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
   Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
   Friend WithEvents txtDescrizione As System.Windows.Forms.TextBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents IdContoTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdContoTextBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents cboValuta As System.Windows.Forms.ComboBox
    Friend WithEvents cmdVisualizza As System.Windows.Forms.Button
    Friend WithEvents NiceGroupBox1 As WIN.GUI.UTILITY.NiceGroupBox

End Class
