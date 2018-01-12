<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSelezionaId
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSelezionaId))
      Me.cmdOk = New System.Windows.Forms.Button
      Me.cmdAnnulla = New System.Windows.Forms.Button
      Me.cmdDel = New System.Windows.Forms.Button
      Me.cmdLista = New System.Windows.Forms.Button
      Me.ControlloListeIDs1 = New WIN.GUI.APPLICATION.PRESENTATION.ControlloListeIDs
      Me.SuspendLayout()
      '
      'cmdOk
      '
      Me.cmdOk.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.OK
      Me.cmdOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.cmdOk.Location = New System.Drawing.Point(238, 41)
      Me.cmdOk.Name = "cmdOk"
      Me.cmdOk.Size = New System.Drawing.Size(89, 24)
      Me.cmdOk.TabIndex = 1
      Me.cmdOk.Text = "Ok"
      Me.cmdOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.cmdOk.UseVisualStyleBackColor = True
      '
      'cmdAnnulla
      '
      Me.cmdAnnulla.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.GotoShortcutsHS
      Me.cmdAnnulla.ImageAlign = System.Drawing.ContentAlignment.TopLeft
      Me.cmdAnnulla.Location = New System.Drawing.Point(238, 71)
      Me.cmdAnnulla.Name = "cmdAnnulla"
      Me.cmdAnnulla.Size = New System.Drawing.Size(89, 24)
      Me.cmdAnnulla.TabIndex = 2
      Me.cmdAnnulla.Text = "Annulla"
      Me.cmdAnnulla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.cmdAnnulla.UseVisualStyleBackColor = True
      '
      'cmdDel
      '
      Me.cmdDel.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.DeleteHS
      Me.cmdDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.cmdDel.Location = New System.Drawing.Point(238, 101)
      Me.cmdDel.Name = "cmdDel"
      Me.cmdDel.Size = New System.Drawing.Size(89, 27)
      Me.cmdDel.TabIndex = 3
      Me.cmdDel.Text = "Elimina riga"
      Me.cmdDel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.cmdDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.cmdDel.UseVisualStyleBackColor = True
      '
      'cmdLista
      '
      Me.cmdLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
      Me.cmdLista.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.OrganizerHS
      Me.cmdLista.ImageAlign = System.Drawing.ContentAlignment.TopLeft
      Me.cmdLista.Location = New System.Drawing.Point(239, 203)
      Me.cmdLista.Name = "cmdLista"
      Me.cmdLista.Size = New System.Drawing.Size(89, 30)
      Me.cmdLista.TabIndex = 4
      Me.cmdLista.Text = "Importa lista"
      Me.cmdLista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.cmdLista.UseVisualStyleBackColor = True
      '
      'ControlloListeIDs1
      '
      Me.ControlloListeIDs1.Location = New System.Drawing.Point(12, 2)
      Me.ControlloListeIDs1.Name = "ControlloListeIDs1"
      Me.ControlloListeIDs1.Size = New System.Drawing.Size(220, 248)
      Me.ControlloListeIDs1.TabIndex = 0
      Me.ControlloListeIDs1.TipoRicerca = WIN.GUI.APPLICATION.PRESENTATION.ControlloListeIDs.SearchType.Conti
      '
      'FrmSelezionaId
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(340, 260)
      Me.Controls.Add(Me.cmdLista)
      Me.Controls.Add(Me.cmdDel)
      Me.Controls.Add(Me.cmdAnnulla)
      Me.Controls.Add(Me.cmdOk)
      Me.Controls.Add(Me.ControlloListeIDs1)
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "FrmSelezionaId"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Selezione lista identificativi"
      Me.ResumeLayout(False)

   End Sub
   Friend WithEvents ControlloListeIDs1 As WIN.GUI.APPLICATION.PRESENTATION.ControlloListeIDs
   Friend WithEvents cmdOk As System.Windows.Forms.Button
   Friend WithEvents cmdAnnulla As System.Windows.Forms.Button
   Friend WithEvents cmdDel As System.Windows.Forms.Button
   Friend WithEvents cmdLista As System.Windows.Forms.Button
End Class
