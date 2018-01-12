<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSelezionaModello
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
      Me.Label1 = New System.Windows.Forms.Label
      Me.cmdOk = New System.Windows.Forms.Button
      Me.cmdAnnulla = New System.Windows.Forms.Button
      Me.FileExplorerTreeView1 = New FileDirectoryProvider.Control.FileExplorerTreeView(Me.components)
      Me.SuspendLayout()
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.ForeColor = System.Drawing.Color.Gray
      Me.Label1.Location = New System.Drawing.Point(5, 401)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(391, 13)
      Me.Label1.TabIndex = 0
      Me.Label1.Text = "________________________________________________________________"
      '
      'cmdOk
      '
      Me.cmdOk.Location = New System.Drawing.Point(7, 421)
      Me.cmdOk.Name = "cmdOk"
      Me.cmdOk.Size = New System.Drawing.Size(77, 23)
      Me.cmdOk.TabIndex = 1
      Me.cmdOk.Text = "&Seleziona"
      Me.cmdOk.UseVisualStyleBackColor = True
      '
      'cmdAnnulla
      '
      Me.cmdAnnulla.Location = New System.Drawing.Point(314, 421)
      Me.cmdAnnulla.Name = "cmdAnnulla"
      Me.cmdAnnulla.Size = New System.Drawing.Size(77, 23)
      Me.cmdAnnulla.TabIndex = 2
      Me.cmdAnnulla.Text = "&Annulla"
      Me.cmdAnnulla.UseVisualStyleBackColor = True
      '
      'FileExplorerTreeView1
      '
      Me.FileExplorerTreeView1.BasePath = ""
      Me.FileExplorerTreeView1.Filter = ""
      Me.FileExplorerTreeView1.ImageIndex = 0
      Me.FileExplorerTreeView1.Location = New System.Drawing.Point(3, 2)
      Me.FileExplorerTreeView1.Name = "FileExplorerTreeView1"
      Me.FileExplorerTreeView1.SelectedImageIndex = 0
      Me.FileExplorerTreeView1.Size = New System.Drawing.Size(396, 396)
      Me.FileExplorerTreeView1.TabIndex = 3
      Me.FileExplorerTreeView1.ViewMode = FileDirectoryProvider.Control.FileExplorerTreeViewOption.FileAndDirectiory
      '
      'FrmSelezionaModello
      '
      Me.AcceptButton = Me.cmdOk
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(403, 452)
      Me.Controls.Add(Me.FileExplorerTreeView1)
      Me.Controls.Add(Me.cmdAnnulla)
      Me.Controls.Add(Me.cmdOk)
      Me.Controls.Add(Me.Label1)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Name = "FrmSelezionaModello"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Seleziona modello"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents cmdOk As System.Windows.Forms.Button
   Friend WithEvents cmdAnnulla As System.Windows.Forms.Button
   Friend WithEvents FileExplorerTreeView1 As FileDirectoryProvider.Control.FileExplorerTreeView
End Class
