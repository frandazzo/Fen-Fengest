<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmItemContabile
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
        Dim StView1 As WIN.GUI.UTILITY.StView = New WIN.GUI.UTILITY.StView
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmItemContabile))
        Me.ControlItemContabile1 = New WIN.GUI.APPLICATION.PRESENTATION.ControlItemContabile
        Me.cmdOk = New System.Windows.Forms.Button
        Me.cmdAnnulla = New System.Windows.Forms.Button
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'ControlItemContabile1
        '
        Me.ControlItemContabile1.AutoScroll = True
        Me.ControlItemContabile1.BackColor = System.Drawing.Color.Gainsboro
        Me.ControlItemContabile1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ControlItemContabile1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ControlItemContabile1.IdShowedObject = "-1"
        Me.ControlItemContabile1.Location = New System.Drawing.Point(0, 0)
        Me.ControlItemContabile1.Margin = New System.Windows.Forms.Padding(0)
        Me.ControlItemContabile1.Name = "ControlItemContabile1"
        Me.ControlItemContabile1.Size = New System.Drawing.Size(579, 319)
        Me.ControlItemContabile1.State = StView1
        Me.ControlItemContabile1.TabIndex = 0
        '
        'cmdOk
        '
        Me.cmdOk.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.OK
        Me.cmdOk.Location = New System.Drawing.Point(259, 327)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(101, 27)
        Me.cmdOk.TabIndex = 17
        Me.cmdOk.Text = "Ok"
        Me.cmdOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'cmdAnnulla
        '
        Me.cmdAnnulla.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.GotoShortcutsHS
        Me.cmdAnnulla.Location = New System.Drawing.Point(467, 326)
        Me.cmdAnnulla.Name = "cmdAnnulla"
        Me.cmdAnnulla.Size = New System.Drawing.Size(85, 27)
        Me.cmdAnnulla.TabIndex = 16
        Me.cmdAnnulla.Text = "Annulla"
        Me.cmdAnnulla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAnnulla.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Enabled = False
        Me.cmdAdd.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.saveHS
        Me.cmdAdd.Location = New System.Drawing.Point(366, 326)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(95, 28)
        Me.cmdAdd.TabIndex = 18
        Me.cmdAdd.Text = "Aggiungi"
        Me.cmdAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'FrmItemContabile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(581, 362)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmdAnnulla)
        Me.Controls.Add(Me.ControlItemContabile1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmItemContabile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Posizione documento"
        Me.ResumeLayout(False)

    End Sub
   Friend WithEvents ControlItemContabile1 As WIN.GUI.APPLICATION.PRESENTATION.ControlItemContabile
   Friend WithEvents cmdOk As System.Windows.Forms.Button
   Friend WithEvents cmdAnnulla As System.Windows.Forms.Button
   Friend WithEvents cmdAdd As System.Windows.Forms.Button
End Class
