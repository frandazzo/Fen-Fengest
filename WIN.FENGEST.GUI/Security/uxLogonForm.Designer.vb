<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uxLogonForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uxLogonForm))
        Me.uxPassTextBox = New System.Windows.Forms.TextBox
        Me.uxErrorLabel = New System.Windows.Forms.Label
        Me.uxLogonButton = New System.Windows.Forms.Button
        Me.uxCancelButton = New System.Windows.Forms.Button
        Me.uxUserTextBox = New System.Windows.Forms.TextBox
        Me.lblVers = New System.Windows.Forms.Label
        Me.lblDB = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'uxPassTextBox
        '
        Me.uxPassTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.uxPassTextBox.Location = New System.Drawing.Point(246, 170)
        Me.uxPassTextBox.Name = "uxPassTextBox"
        Me.uxPassTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.uxPassTextBox.Size = New System.Drawing.Size(110, 20)
        Me.uxPassTextBox.TabIndex = 26
        '
        'uxErrorLabel
        '
        Me.uxErrorLabel.AutoSize = True
        Me.uxErrorLabel.BackColor = System.Drawing.Color.Transparent
        Me.uxErrorLabel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uxErrorLabel.ForeColor = System.Drawing.Color.Red
        Me.uxErrorLabel.Location = New System.Drawing.Point(143, 245)
        Me.uxErrorLabel.Name = "uxErrorLabel"
        Me.uxErrorLabel.Size = New System.Drawing.Size(182, 13)
        Me.uxErrorLabel.TabIndex = 30
        Me.uxErrorLabel.Text = "Nome utente o password errati"
        Me.uxErrorLabel.Visible = False
        '
        'uxLogonButton
        '
        Me.uxLogonButton.Location = New System.Drawing.Point(144, 217)
        Me.uxLogonButton.Name = "uxLogonButton"
        Me.uxLogonButton.Size = New System.Drawing.Size(62, 25)
        Me.uxLogonButton.TabIndex = 28
        Me.uxLogonButton.Text = "Login"
        Me.uxLogonButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.uxLogonButton.UseVisualStyleBackColor = True
        '
        'uxCancelButton
        '
        Me.uxCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.uxCancelButton.Location = New System.Drawing.Point(247, 218)
        Me.uxCancelButton.Name = "uxCancelButton"
        Me.uxCancelButton.Size = New System.Drawing.Size(58, 24)
        Me.uxCancelButton.TabIndex = 29
        Me.uxCancelButton.Text = "Esci"
        Me.uxCancelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.uxCancelButton.UseVisualStyleBackColor = True
        '
        'uxUserTextBox
        '
        Me.uxUserTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.uxUserTextBox.Location = New System.Drawing.Point(96, 170)
        Me.uxUserTextBox.Name = "uxUserTextBox"
        Me.uxUserTextBox.Size = New System.Drawing.Size(110, 20)
        Me.uxUserTextBox.TabIndex = 25
        '
        'lblVers
        '
        Me.lblVers.AutoSize = True
        Me.lblVers.BackColor = System.Drawing.Color.Transparent
        Me.lblVers.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVers.ForeColor = System.Drawing.Color.White
        Me.lblVers.Location = New System.Drawing.Point(311, 28)
        Me.lblVers.Name = "lblVers"
        Me.lblVers.Size = New System.Drawing.Size(83, 12)
        Me.lblVers.TabIndex = 32
        Me.lblVers.Text = "Versione software "
        '
        'lblDB
        '
        Me.lblDB.AutoSize = True
        Me.lblDB.BackColor = System.Drawing.Color.Transparent
        Me.lblDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDB.ForeColor = System.Drawing.Color.White
        Me.lblDB.Location = New System.Drawing.Point(311, 12)
        Me.lblDB.Name = "lblDB"
        Me.lblDB.Size = New System.Drawing.Size(115, 12)
        Me.lblDB.TabIndex = 33
        Me.lblDB.Text = "Versione database 1.0.0.0 "
        '
        'uxLogonForm
        '
        Me.AcceptButton = Me.uxLogonButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.logim
        Me.CancelButton = Me.uxCancelButton
        Me.ClientSize = New System.Drawing.Size(452, 279)
        Me.Controls.Add(Me.lblDB)
        Me.Controls.Add(Me.lblVers)
        Me.Controls.Add(Me.uxPassTextBox)
        Me.Controls.Add(Me.uxErrorLabel)
        Me.Controls.Add(Me.uxLogonButton)
        Me.Controls.Add(Me.uxCancelButton)
        Me.Controls.Add(Me.uxUserTextBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "uxLogonForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Private WithEvents uxPassTextBox As System.Windows.Forms.TextBox
   Private WithEvents uxErrorLabel As System.Windows.Forms.Label
   Private WithEvents uxLogonButton As System.Windows.Forms.Button
   Private WithEvents uxCancelButton As System.Windows.Forms.Button
    Private WithEvents uxUserTextBox As System.Windows.Forms.TextBox
    Friend WithEvents lblVers As System.Windows.Forms.Label
   Friend WithEvents lblDB As System.Windows.Forms.Label
End Class
