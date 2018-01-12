<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagerRuoli
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
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Associazione utenti per ruolo", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Associazione profili per ruolo", System.Windows.Forms.HorizontalAlignment.Left)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManagerRuoli))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.uxRolesListBox = New System.Windows.Forms.ListBox
        Me.RolesMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.addNewRoleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.removeroleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.txtCambiaDescrizione = New System.Windows.Forms.Button
        Me.uxAssociationsListView = New System.Windows.Forms.ListView
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.txtDescrizioneRole = New System.Windows.Forms.TextBox
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.cmdSave = New System.Windows.Forms.ToolStripButton
        Me.cmdCancel = New System.Windows.Forms.ToolStripButton
        Me.RoleMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.addNewUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.uxAddProfileMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ProfileMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.uxDeleteProfileMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.uxProfilePropertiesMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UserMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.deleteuserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.edituserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.RolesMenu.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.RoleMenu.SuspendLayout()
        Me.ProfileMenu.SuspendLayout()
        Me.UserMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.SplitContainer1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(641, 506)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(641, 531)
        Me.ToolStripContainer1.TabIndex = 6
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.uxAssociationsListView)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txtDescrizioneRole)
        Me.SplitContainer1.Size = New System.Drawing.Size(641, 506)
        Me.SplitContainer1.SplitterDistance = 213
        Me.SplitContainer1.TabIndex = 6
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
        Me.TextBox1.Size = New System.Drawing.Size(207, 21)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.Text = "Ruoli"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.uxRolesListBox)
        Me.Panel1.Location = New System.Drawing.Point(3, 26)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(207, 476)
        Me.Panel1.TabIndex = 2
        '
        'uxRolesListBox
        '
        Me.uxRolesListBox.ContextMenuStrip = Me.RolesMenu
        Me.uxRolesListBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.uxRolesListBox.FormattingEnabled = True
        Me.uxRolesListBox.Location = New System.Drawing.Point(0, 0)
        Me.uxRolesListBox.Name = "uxRolesListBox"
        Me.uxRolesListBox.Size = New System.Drawing.Size(207, 472)
        Me.uxRolesListBox.TabIndex = 0
        '
        'RolesMenu
        '
        Me.RolesMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.addNewRoleToolStripMenuItem, Me.removeroleToolStripMenuItem})
        Me.RolesMenu.Name = "RolesMenu"
        Me.RolesMenu.Size = New System.Drawing.Size(187, 48)
        '
        'addNewRoleToolStripMenuItem
        '
        Me.addNewRoleToolStripMenuItem.Name = "addNewRoleToolStripMenuItem"
        Me.addNewRoleToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.addNewRoleToolStripMenuItem.Text = "Aggiungi nuovo ruolo"
        '
        'removeroleToolStripMenuItem
        '
        Me.removeroleToolStripMenuItem.Name = "removeroleToolStripMenuItem"
        Me.removeroleToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.removeroleToolStripMenuItem.Text = "Elimina"
        '
        'txtCambiaDescrizione
        '
        Me.txtCambiaDescrizione.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCambiaDescrizione.Location = New System.Drawing.Point(265, 3)
        Me.txtCambiaDescrizione.Name = "txtCambiaDescrizione"
        Me.txtCambiaDescrizione.Size = New System.Drawing.Size(155, 20)
        Me.txtCambiaDescrizione.TabIndex = 10
        Me.txtCambiaDescrizione.Text = "Cambia descrizione ruolo"
        Me.txtCambiaDescrizione.UseVisualStyleBackColor = True
        '
        'uxAssociationsListView
        '
        Me.uxAssociationsListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ListViewGroup1.Header = "Associazione utenti per ruolo"
        ListViewGroup1.Name = "ListViewGroup1"
        ListViewGroup2.Header = "Associazione profili per ruolo"
        ListViewGroup2.Name = "ListViewGroup2"
        Me.uxAssociationsListView.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2})
        Me.uxAssociationsListView.LargeImageList = Me.ImageList1
        Me.uxAssociationsListView.Location = New System.Drawing.Point(3, 27)
        Me.uxAssociationsListView.Name = "uxAssociationsListView"
        Me.uxAssociationsListView.Size = New System.Drawing.Size(417, 475)
        Me.uxAssociationsListView.TabIndex = 7
        Me.uxAssociationsListView.UseCompatibleStateImageBehavior = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "CreatePeople1.ico")
        Me.ImageList1.Images.SetKeyName(1, "hxds.dll (6).ico")
        '
        'txtDescrizioneRole
        '
        Me.txtDescrizioneRole.AcceptsReturn = True
        Me.txtDescrizioneRole.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDescrizioneRole.BackColor = System.Drawing.Color.DarkGray
        Me.txtDescrizioneRole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescrizioneRole.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescrizioneRole.ForeColor = System.Drawing.Color.White
        Me.txtDescrizioneRole.Location = New System.Drawing.Point(3, 3)
        Me.txtDescrizioneRole.Multiline = True
        Me.txtDescrizioneRole.Name = "txtDescrizioneRole"
        Me.txtDescrizioneRole.Size = New System.Drawing.Size(418, 21)
        Me.txtDescrizioneRole.TabIndex = 4
        Me.txtDescrizioneRole.Text = "Associazioni"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdSave, Me.cmdCancel})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(58, 25)
        Me.ToolStrip1.TabIndex = 0
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
        'RoleMenu
        '
        Me.RoleMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.addNewUserToolStripMenuItem, Me.uxAddProfileMenuItem, Me.ToolStripSeparator2})
        Me.RoleMenu.Name = "RoleMenu"
        Me.RoleMenu.Size = New System.Drawing.Size(162, 54)
        '
        'addNewUserToolStripMenuItem
        '
        Me.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem"
        Me.addNewUserToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.addNewUserToolStripMenuItem.Text = "Aggiungi utente"
        '
        'uxAddProfileMenuItem
        '
        Me.uxAddProfileMenuItem.Name = "uxAddProfileMenuItem"
        Me.uxAddProfileMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.uxAddProfileMenuItem.Text = "Aggiungi profilo"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(158, 6)
        '
        'ProfileMenu
        '
        Me.ProfileMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.uxDeleteProfileMenuItem, Me.uxProfilePropertiesMenuItem})
        Me.ProfileMenu.Name = "ProfileMenu"
        Me.ProfileMenu.Size = New System.Drawing.Size(151, 48)
        '
        'uxDeleteProfileMenuItem
        '
        Me.uxDeleteProfileMenuItem.Name = "uxDeleteProfileMenuItem"
        Me.uxDeleteProfileMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.uxDeleteProfileMenuItem.Text = "Elimina profilo"
        '
        'uxProfilePropertiesMenuItem
        '
        Me.uxProfilePropertiesMenuItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uxProfilePropertiesMenuItem.Name = "uxProfilePropertiesMenuItem"
        Me.uxProfilePropertiesMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.uxProfilePropertiesMenuItem.Text = "Proprietà"
        '
        'UserMenu
        '
        Me.UserMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.deleteuserToolStripMenuItem, Me.edituserToolStripMenuItem})
        Me.UserMenu.Name = "UserMenu"
        Me.UserMenu.Size = New System.Drawing.Size(153, 48)
        '
        'deleteuserToolStripMenuItem
        '
        Me.deleteuserToolStripMenuItem.Name = "deleteuserToolStripMenuItem"
        Me.deleteuserToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.deleteuserToolStripMenuItem.Text = "Elimina utente"
        '
        'edituserToolStripMenuItem
        '
        Me.edituserToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.edituserToolStripMenuItem.Name = "edituserToolStripMenuItem"
        Me.edituserToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.edituserToolStripMenuItem.Text = "Proprietà"
        '
        'ManagerRuoli
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 531)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "ManagerRuoli"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestione ruoli"
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
        Me.RolesMenu.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.RoleMenu.ResumeLayout(False)
        Me.ProfileMenu.ResumeLayout(False)
        Me.UserMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
   Friend WithEvents ToolStripContainer1 As System.Windows.Forms.ToolStripContainer
   Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
   Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
   Friend WithEvents Panel1 As System.Windows.Forms.Panel
   Friend WithEvents uxRolesListBox As System.Windows.Forms.ListBox
   Friend WithEvents txtDescrizioneRole As System.Windows.Forms.TextBox
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents cmdSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents uxAssociationsListView As System.Windows.Forms.ListView
    Friend WithEvents RoleMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents addNewUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents uxAddProfileMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProfileMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents uxDeleteProfileMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents uxProfilePropertiesMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents deleteuserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents edituserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RolesMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents removeroleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents addNewRoleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
   Friend WithEvents txtCambiaDescrizione As System.Windows.Forms.Button
End Class
