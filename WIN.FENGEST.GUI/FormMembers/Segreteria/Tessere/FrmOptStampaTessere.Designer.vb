<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOptStampaTessere
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
        Me.cmdOk = New System.Windows.Forms.Button
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.optTutti = New System.Windows.Forms.RadioButton
        Me.optFilter = New System.Windows.Forms.RadioButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkAddressOK = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(157, 149)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(63, 25)
        Me.cmdOk.TabIndex = 0
        Me.cmdOk.Text = "Ok"
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Location = New System.Drawing.Point(226, 148)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(70, 26)
        Me.cmdCancel.TabIndex = 1
        Me.cmdCancel.Text = "Annulla"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'optTutti
        '
        Me.optTutti.AutoSize = True
        Me.optTutti.Checked = True
        Me.optTutti.Location = New System.Drawing.Point(23, 22)
        Me.optTutti.Name = "optTutti"
        Me.optTutti.Size = New System.Drawing.Size(94, 17)
        Me.optTutti.TabIndex = 2
        Me.optTutti.TabStop = True
        Me.optTutti.Text = "Seleziona tutti "
        Me.optTutti.UseVisualStyleBackColor = True
        '
        'optFilter
        '
        Me.optFilter.AutoSize = True
        Me.optFilter.Location = New System.Drawing.Point(23, 50)
        Me.optFilter.Name = "optFilter"
        Me.optFilter.Size = New System.Drawing.Size(255, 17)
        Me.optFilter.TabIndex = 3
        Me.optFilter.TabStop = True
        Me.optFilter.Text = "Seleziona utenti senza tessera nell'anno corrente"
        Me.optFilter.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.chkAddressOK)
        Me.GroupBox1.Controls.Add(Me.optFilter)
        Me.GroupBox1.Controls.Add(Me.optTutti)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(284, 130)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selezione utenti"
        '
        'chkAddressOK
        '
        Me.chkAddressOK.AutoSize = True
        Me.chkAddressOK.Location = New System.Drawing.Point(23, 95)
        Me.chkAddressOK.Name = "chkAddressOK"
        Me.chkAddressOK.Size = New System.Drawing.Size(15, 14)
        Me.chkAddressOK.TabIndex = 4
        Me.chkAddressOK.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 93)
        Me.Label1.MaximumSize = New System.Drawing.Size(200, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 26)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Solo utenti con indirizzo completo (comune,indirizzo e   cap non nulli)"
        '
        'FrmOptStampaTessere
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 183)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdOk)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmOptStampaTessere"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Opzione"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
   Friend WithEvents cmdOk As System.Windows.Forms.Button
   Friend WithEvents cmdCancel As System.Windows.Forms.Button
   Friend WithEvents optTutti As System.Windows.Forms.RadioButton
    Friend WithEvents optFilter As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkAddressOK As System.Windows.Forms.CheckBox
End Class
