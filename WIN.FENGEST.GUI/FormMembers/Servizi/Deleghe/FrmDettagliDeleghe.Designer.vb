<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDettagliDeleghe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDettagliDeleghe))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSott = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtInoltro = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtDataAcc = New System.Windows.Forms.TextBox
        Me.txtDataAtt = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtInc = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtRep = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Caus. Sottoscrizione"
        '
        'txtSott
        '
        Me.txtSott.Location = New System.Drawing.Point(118, 14)
        Me.txtSott.Name = "txtSott"
        Me.txtSott.Size = New System.Drawing.Size(199, 20)
        Me.txtSott.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(54, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Data inoltro"
        '
        'txtInoltro
        '
        Me.txtInoltro.Location = New System.Drawing.Point(118, 66)
        Me.txtInoltro.Name = "txtInoltro"
        Me.txtInoltro.Size = New System.Drawing.Size(199, 20)
        Me.txtInoltro.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Data accettazione"
        '
        'txtDataAcc
        '
        Me.txtDataAcc.Location = New System.Drawing.Point(118, 92)
        Me.txtDataAcc.Name = "txtDataAcc"
        Me.txtDataAcc.Size = New System.Drawing.Size(199, 20)
        Me.txtDataAcc.TabIndex = 7
        '
        'txtDataAtt
        '
        Me.txtDataAtt.Location = New System.Drawing.Point(118, 121)
        Me.txtDataAtt.Name = "txtDataAtt"
        Me.txtDataAtt.Size = New System.Drawing.Size(199, 20)
        Me.txtDataAtt.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 124)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Data attivazione"
        '
        'txtInc
        '
        Me.txtInc.Location = New System.Drawing.Point(118, 148)
        Me.txtInc.Name = "txtInc"
        Me.txtInc.Size = New System.Drawing.Size(199, 20)
        Me.txtInc.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Incasso attivazione"
        '
        'txtRep
        '
        Me.txtRep.AcceptsTab = True
        Me.txtRep.Location = New System.Drawing.Point(118, 40)
        Me.txtRep.Name = "txtRep"
        Me.txtRep.Size = New System.Drawing.Size(199, 20)
        Me.txtRep.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(70, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Reparto"
        '
        'FrmDettagliDeleghe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(329, 182)
        Me.Controls.Add(Me.txtRep)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDataAtt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtInc)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDataAcc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtInoltro)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSott)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDettagliDeleghe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dettaglio delega"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents txtSott As System.Windows.Forms.TextBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents txtInoltro As System.Windows.Forms.TextBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents txtDataAcc As System.Windows.Forms.TextBox
   Friend WithEvents txtDataAtt As System.Windows.Forms.TextBox
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents txtInc As System.Windows.Forms.TextBox
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents txtRep As System.Windows.Forms.TextBox
   Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
