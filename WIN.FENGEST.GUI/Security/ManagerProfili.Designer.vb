<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagerProfili
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
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.uxProfilesListBox = New System.Windows.Forms.ListBox
        Me.ProfileMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.uxAddMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.uxDeleteMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.txtCambiaDescrizione = New System.Windows.Forms.Button
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer
        Me.uxTreeView = New System.Windows.Forms.TreeView
        Me.uxPermissionsListBox = New System.Windows.Forms.CheckedListBox
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.txtDescrizione = New System.Windows.Forms.TextBox
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.cmdSave = New System.Windows.Forms.ToolStripButton
        Me.cmdCancel = New System.Windows.Forms.ToolStripButton
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ProfileMenu.SuspendLayout()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.SplitContainer1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(638, 334)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(638, 359)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip1)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtCambiaDescrizione)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Splitter1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtDescrizione)
        Me.SplitContainer1.Size = New System.Drawing.Size(638, 334)
        Me.SplitContainer1.SplitterDistance = 212
        Me.SplitContainer1.TabIndex = 7
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.DarkGray
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(3, 3)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(206, 21)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "Profili"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.uxProfilesListBox)
        Me.Panel1.Location = New System.Drawing.Point(3, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(206, 304)
        Me.Panel1.TabIndex = 2
        '
        'uxProfilesListBox
        '
        Me.uxProfilesListBox.ContextMenuStrip = Me.ProfileMenu
        Me.uxProfilesListBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.uxProfilesListBox.FormattingEnabled = True
        Me.uxProfilesListBox.Location = New System.Drawing.Point(0, 0)
        Me.uxProfilesListBox.Name = "uxProfilesListBox"
        Me.uxProfilesListBox.Size = New System.Drawing.Size(206, 303)
        Me.uxProfilesListBox.TabIndex = 0
        '
        'ProfileMenu
        '
        Me.ProfileMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.uxAddMenuItem, Me.uxDeleteMenuItem})
        Me.ProfileMenu.Name = "ProfileMenu"
        Me.ProfileMenu.Size = New System.Drawing.Size(160, 48)
        '
        'uxAddMenuItem
        '
        Me.uxAddMenuItem.Name = "uxAddMenuItem"
        Me.uxAddMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.uxAddMenuItem.Text = "Aggiungi profilo"
        '
        'uxDeleteMenuItem
        '
        Me.uxDeleteMenuItem.Name = "uxDeleteMenuItem"
        Me.uxDeleteMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.uxDeleteMenuItem.Text = "Elimina profilo"
        '
        'txtCambiaDescrizione
        '
        Me.txtCambiaDescrizione.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCambiaDescrizione.Location = New System.Drawing.Point(263, 3)
        Me.txtCambiaDescrizione.Name = "txtCambiaDescrizione"
        Me.txtCambiaDescrizione.Size = New System.Drawing.Size(155, 20)
        Me.txtCambiaDescrizione.TabIndex = 9
        Me.txtCambiaDescrizione.Text = "Cambia descrizione profilo"
        Me.txtCambiaDescrizione.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 26)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.uxTreeView)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.uxPermissionsListBox)
        Me.SplitContainer2.Size = New System.Drawing.Size(416, 308)
        Me.SplitContainer2.SplitterDistance = 138
        Me.SplitContainer2.TabIndex = 8
        '
        'uxTreeView
        '
        Me.uxTreeView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.uxTreeView.Location = New System.Drawing.Point(0, 0)
        Me.uxTreeView.Name = "uxTreeView"
        Me.uxTreeView.Size = New System.Drawing.Size(138, 308)
        Me.uxTreeView.TabIndex = 5
        '
        'uxPermissionsListBox
        '
        Me.uxPermissionsListBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.uxPermissionsListBox.FormattingEnabled = True
        Me.uxPermissionsListBox.Location = New System.Drawing.Point(0, 0)
        Me.uxPermissionsListBox.Name = "uxPermissionsListBox"
        Me.uxPermissionsListBox.Size = New System.Drawing.Size(274, 304)
        Me.uxPermissionsListBox.TabIndex = 6
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 334)
        Me.Splitter1.TabIndex = 7
        Me.Splitter1.TabStop = False
        '
        'txtDescrizione
        '
        Me.txtDescrizione.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescrizione.BackColor = System.Drawing.Color.DarkGray
        Me.txtDescrizione.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescrizione.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescrizione.ForeColor = System.Drawing.Color.White
        Me.txtDescrizione.Location = New System.Drawing.Point(3, 3)
        Me.txtDescrizione.Multiline = True
        Me.txtDescrizione.Name = "txtDescrizione"
        Me.txtDescrizione.Size = New System.Drawing.Size(416, 21)
        Me.txtDescrizione.TabIndex = 4
        Me.txtDescrizione.Text = "Profilo selezionato"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdSave, Me.cmdCancel})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(58, 25)
        Me.ToolStrip1.TabIndex = 1
        '
        'cmdSave
        '
        Me.cmdSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdSave.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.saveHS
        Me.cmdSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(23, 22)
        Me.cmdSave.Text = "ToolStripButton1"
        Me.cmdSave.ToolTipText = "Salva"
        '
        'cmdCancel
        '
        Me.cmdCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdCancel.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.DeleteHS
        Me.cmdCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(23, 22)
        Me.cmdCancel.Text = "ToolStripButton2"
        Me.cmdCancel.ToolTipText = "Elimina"
        '
        'ManagerProfili
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(638, 359)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "ManagerProfili"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestione profili"
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ProfileMenu.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
   Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
   Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
   Friend WithEvents cmdSave As System.Windows.Forms.ToolStripButton
   Friend WithEvents cmdCancel As System.Windows.Forms.ToolStripButton
   Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
   Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
   Friend WithEvents Panel1 As System.Windows.Forms.Panel
   Friend WithEvents uxProfilesListBox As System.Windows.Forms.ListBox
   Friend WithEvents txtDescrizione As System.Windows.Forms.TextBox
   Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
   Friend WithEvents uxTreeView As System.Windows.Forms.TreeView
   Friend WithEvents uxPermissionsListBox As System.Windows.Forms.CheckedListBox
   Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
   Private WithEvents ProfileMenu As System.Windows.Forms.ContextMenuStrip
   Private WithEvents uxAddMenuItem As System.Windows.Forms.ToolStripMenuItem
   Private WithEvents uxDeleteMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents txtCambiaDescrizione As System.Windows.Forms.Button
End Class
