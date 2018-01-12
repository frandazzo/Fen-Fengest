<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSediOperative
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSediOperative))
        Me.cmdOk = New System.Windows.Forms.Button
        Me.txtDescrizione = New System.Windows.Forms.TextBox
        Me.lblAvvocato = New System.Windows.Forms.Label
        Me.cmdAnnulla = New System.Windows.Forms.Button
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.txtCap = New System.Windows.Forms.TextBox
        Me.lblCap = New System.Windows.Forms.Label
        Me.cboComune = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboProvincia = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtVia = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
        Me.SuspendLayout()
        '
        'cmdOk
        '
        Me.cmdOk.Location = New System.Drawing.Point(58, 115)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(123, 27)
        Me.cmdOk.TabIndex = 24
        Me.cmdOk.Text = "Ok"
        Me.cmdOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'txtDescrizione
        '
        Me.HelpProvider1.SetHelpString(Me.txtDescrizione, "Descrizione della sede operativa dell'azienda")
        Me.txtDescrizione.Location = New System.Drawing.Point(80, 20)
        Me.txtDescrizione.Name = "txtDescrizione"
        Me.HelpProvider1.SetShowHelp(Me.txtDescrizione, True)
        Me.txtDescrizione.Size = New System.Drawing.Size(343, 20)
        Me.txtDescrizione.TabIndex = 1
        '
        'lblAvvocato
        '
        Me.lblAvvocato.AutoSize = True
        Me.lblAvvocato.BackColor = System.Drawing.Color.Transparent
        Me.lblAvvocato.Location = New System.Drawing.Point(15, 23)
        Me.lblAvvocato.Name = "lblAvvocato"
        Me.lblAvvocato.Size = New System.Drawing.Size(62, 13)
        Me.lblAvvocato.TabIndex = 22
        Me.lblAvvocato.Text = "Descrizione"
        '
        'cmdAnnulla
        '
        Me.cmdAnnulla.Location = New System.Drawing.Point(307, 115)
        Me.cmdAnnulla.Name = "cmdAnnulla"
        Me.cmdAnnulla.Size = New System.Drawing.Size(116, 27)
        Me.cmdAnnulla.TabIndex = 26
        Me.cmdAnnulla.Text = "Annulla"
        Me.cmdAnnulla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAnnulla.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.Location = New System.Drawing.Point(187, 115)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(114, 28)
        Me.cmdAdd.TabIndex = 25
        Me.cmdAdd.Text = "Aggiungi"
        Me.cmdAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'txtCap
        '
        Me.HelpProvider1.SetHelpString(Me.txtCap, "C.A.P. associato all'indirizzo di residenza della sede operativa")
        Me.txtCap.Location = New System.Drawing.Point(319, 87)
        Me.txtCap.Name = "txtCap"
        Me.HelpProvider1.SetShowHelp(Me.txtCap, True)
        Me.txtCap.Size = New System.Drawing.Size(104, 20)
        Me.txtCap.TabIndex = 5
        '
        'lblCap
        '
        Me.lblCap.AutoSize = True
        Me.lblCap.BackColor = System.Drawing.Color.Transparent
        Me.lblCap.Location = New System.Drawing.Point(288, 90)
        Me.lblCap.Name = "lblCap"
        Me.lblCap.Size = New System.Drawing.Size(28, 13)
        Me.lblCap.TabIndex = 18
        Me.lblCap.Text = "CAP"
        '
        'cboComune
        '
        Me.cboComune.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboComune, "Comune di residenza della sede operativa dell'azienda")
        Me.cboComune.Location = New System.Drawing.Point(288, 52)
        Me.cboComune.Name = "cboComune"
        Me.HelpProvider1.SetShowHelp(Me.cboComune, True)
        Me.cboComune.Size = New System.Drawing.Size(135, 21)
        Me.cboComune.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(239, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Comune"
        '
        'cboProvincia
        '
        Me.cboProvincia.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboProvincia, "Provincia di residenza della sede operativa")
        Me.cboProvincia.Location = New System.Drawing.Point(80, 52)
        Me.cboProvincia.Name = "cboProvincia"
        Me.HelpProvider1.SetShowHelp(Me.cboProvincia, True)
        Me.cboProvincia.Size = New System.Drawing.Size(153, 21)
        Me.cboProvincia.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(26, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Provincia"
        '
        'txtVia
        '
        Me.HelpProvider1.SetHelpString(Me.txtVia, "Indirizzo della sede operativa dell'azienda")
        Me.txtVia.Location = New System.Drawing.Point(80, 87)
        Me.txtVia.Name = "txtVia"
        Me.HelpProvider1.SetShowHelp(Me.txtVia, True)
        Me.txtVia.Size = New System.Drawing.Size(202, 20)
        Me.txtVia.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(55, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(22, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Via"
        '
        'FrmSediOperative
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(450, 156)
        Me.Controls.Add(Me.txtVia)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboProvincia)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.txtDescrizione)
        Me.Controls.Add(Me.lblAvvocato)
        Me.Controls.Add(Me.cmdAnnulla)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.txtCap)
        Me.Controls.Add(Me.lblCap)
        Me.Controls.Add(Me.cboComune)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSediOperative"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sedi operative"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Friend WithEvents cmdOk As System.Windows.Forms.Button
   Friend WithEvents txtDescrizione As System.Windows.Forms.TextBox
   Friend WithEvents lblAvvocato As System.Windows.Forms.Label
   Friend WithEvents cmdAnnulla As System.Windows.Forms.Button
   Friend WithEvents cmdAdd As System.Windows.Forms.Button
   Friend WithEvents txtCap As System.Windows.Forms.TextBox
   Friend WithEvents lblCap As System.Windows.Forms.Label
   Friend WithEvents cboComune As System.Windows.Forms.ComboBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents cboProvincia As System.Windows.Forms.ComboBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents txtVia As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
