<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEventi
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
      Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEventi))
      Me.Label1 = New System.Windows.Forms.Label
      Me.cboTipo = New System.Windows.Forms.ComboBox
      Me.Label2 = New System.Windows.Forms.Label
      Me.dtpData = New System.Windows.Forms.DateTimePicker
      Me.Label3 = New System.Windows.Forms.Label
      Me.txtNote = New System.Windows.Forms.TextBox
      Me.lblIntervento = New System.Windows.Forms.Label
      Me.txtIntervento = New System.Windows.Forms.TextBox
      Me.cmdAdd = New System.Windows.Forms.Button
      Me.cmdAnnulla = New System.Windows.Forms.Button
      Me.lblInoltro = New System.Windows.Forms.Label
      Me.txtEnte = New System.Windows.Forms.TextBox
      Me.cmdOk = New System.Windows.Forms.Button
      Me.Label4 = New System.Windows.Forms.Label
      Me.lblDocumento = New System.Windows.Forms.Label
      Me.SpAddFile = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.SpView = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.SpDel = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.SpDelRef = New WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
      Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
      Me.SuspendLayout()
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.BackColor = System.Drawing.Color.Transparent
      Me.Label1.Location = New System.Drawing.Point(12, 48)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(62, 13)
      Me.Label1.TabIndex = 0
      Me.Label1.Text = "TipoEvento"
      '
      'cboTipo
      '
      Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cboTipo.FormattingEnabled = True
      Me.HelpProvider1.SetHelpString(Me.cboTipo, "Tipo di evento che si verifica.")
      Me.cboTipo.Location = New System.Drawing.Point(77, 45)
      Me.cboTipo.Name = "cboTipo"
      Me.HelpProvider1.SetShowHelp(Me.cboTipo, True)
      Me.cboTipo.Size = New System.Drawing.Size(387, 21)
      Me.cboTipo.TabIndex = 1
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.BackColor = System.Drawing.Color.Transparent
      Me.Label2.Location = New System.Drawing.Point(8, 16)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(66, 13)
      Me.Label2.TabIndex = 2
      Me.Label2.Text = "Data evento"
      '
      'dtpData
      '
      Me.dtpData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.HelpProvider1.SetHelpString(Me.dtpData, "Data in cui si verifica l'evento relativo alla vertenza")
      Me.dtpData.Location = New System.Drawing.Point(77, 12)
      Me.dtpData.Name = "dtpData"
      Me.HelpProvider1.SetShowHelp(Me.dtpData, True)
      Me.dtpData.Size = New System.Drawing.Size(91, 20)
      Me.dtpData.TabIndex = 3
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.BackColor = System.Drawing.Color.Transparent
      Me.Label3.Location = New System.Drawing.Point(44, 271)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(30, 13)
      Me.Label3.TabIndex = 4
      Me.Label3.Text = "Note"
      '
      'txtNote
      '
      Me.txtNote.Location = New System.Drawing.Point(77, 271)
      Me.txtNote.Multiline = True
      Me.txtNote.Name = "txtNote"
      Me.txtNote.Size = New System.Drawing.Size(387, 163)
      Me.txtNote.TabIndex = 5
      '
      'lblIntervento
      '
      Me.lblIntervento.AutoSize = True
      Me.lblIntervento.BackColor = System.Drawing.Color.Transparent
      Me.lblIntervento.Location = New System.Drawing.Point(19, 121)
      Me.lblIntervento.Name = "lblIntervento"
      Me.lblIntervento.Size = New System.Drawing.Size(55, 13)
      Me.lblIntervento.TabIndex = 6
      Me.lblIntervento.Text = "Intervento"
      '
      'txtIntervento
      '
      Me.HelpProvider1.SetHelpString(Me.txtIntervento, "Tipo di intervento intrapreso associato all'evento verificato")
      Me.txtIntervento.Location = New System.Drawing.Point(77, 117)
      Me.txtIntervento.Name = "txtIntervento"
      Me.HelpProvider1.SetShowHelp(Me.txtIntervento, True)
      Me.txtIntervento.Size = New System.Drawing.Size(387, 20)
      Me.txtIntervento.TabIndex = 7
      '
      'cmdAdd
      '
      Me.cmdAdd.Location = New System.Drawing.Point(209, 444)
      Me.cmdAdd.Name = "cmdAdd"
      Me.cmdAdd.Size = New System.Drawing.Size(120, 28)
      Me.cmdAdd.TabIndex = 8
      Me.cmdAdd.Text = "Aggiungi"
      Me.cmdAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.cmdAdd.UseVisualStyleBackColor = True
      '
      'cmdAnnulla
      '
      Me.cmdAnnulla.Location = New System.Drawing.Point(335, 444)
      Me.cmdAnnulla.Name = "cmdAnnulla"
      Me.cmdAnnulla.Size = New System.Drawing.Size(129, 27)
      Me.cmdAnnulla.TabIndex = 9
      Me.cmdAnnulla.Text = "Annulla"
      Me.cmdAnnulla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.cmdAnnulla.UseVisualStyleBackColor = True
      '
      'lblInoltro
      '
      Me.lblInoltro.AutoSize = True
      Me.lblInoltro.BackColor = System.Drawing.Color.Transparent
      Me.lblInoltro.Location = New System.Drawing.Point(14, 85)
      Me.lblInoltro.Name = "lblInoltro"
      Me.lblInoltro.Size = New System.Drawing.Size(60, 13)
      Me.lblInoltro.TabIndex = 12
      Me.lblInoltro.Text = "Ente inoltro"
      '
      'txtEnte
      '
      Me.HelpProvider1.SetHelpString(Me.txtEnte, "")
      Me.txtEnte.Location = New System.Drawing.Point(77, 82)
      Me.txtEnte.Name = "txtEnte"
      Me.HelpProvider1.SetShowHelp(Me.txtEnte, True)
      Me.txtEnte.Size = New System.Drawing.Size(387, 20)
      Me.txtEnte.TabIndex = 13
      '
      'cmdOk
      '
      Me.cmdOk.Location = New System.Drawing.Point(77, 444)
      Me.cmdOk.Name = "cmdOk"
      Me.cmdOk.Size = New System.Drawing.Size(126, 27)
      Me.cmdOk.TabIndex = 14
      Me.cmdOk.Text = "Ok"
      Me.cmdOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.cmdOk.UseVisualStyleBackColor = True
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.Location = New System.Drawing.Point(12, 193)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(62, 13)
      Me.Label4.TabIndex = 15
      Me.Label4.Text = "Documento"
      '
      'lblDocumento
      '
      Me.lblDocumento.AutoSize = True
      Me.lblDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblDocumento.Location = New System.Drawing.Point(80, 193)
      Me.lblDocumento.MaximumSize = New System.Drawing.Size(230, 0)
      Me.lblDocumento.Name = "lblDocumento"
      Me.lblDocumento.Size = New System.Drawing.Size(115, 13)
      Me.lblDocumento.TabIndex = 16
      Me.lblDocumento.Text = "Nessun documento"
      '
      'SpAddFile
      '
      Me.SpAddFile.ApplyOutLookStile = True
      Me.SpAddFile.BackColor = System.Drawing.Color.Transparent
      Me.SpAddFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.SpAddFile.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.file_add_32x32
      Me.SpAddFile.Disabled = False
      Me.SpAddFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.SpAddFile.ForeColor = System.Drawing.Color.Transparent
      Me.HelpProvider1.SetHelpString(Me.SpAddFile, "Funzione che permette di allegare un file relativo all'evento della vertenza(es. " & _
              "raccomandate inviate...)")
      Me.SpAddFile.Location = New System.Drawing.Point(318, 193)
      Me.SpAddFile.Name = "SpAddFile"
      Me.SpAddFile.Radius = 32.0!
      Me.HelpProvider1.SetShowHelp(Me.SpAddFile, True)
      Me.SpAddFile.ShowTooltip = True
      Me.SpAddFile.Size = New System.Drawing.Size(32, 32)
      Me.SpAddFile.TabIndex = 57
      Me.SpAddFile.TextValue = ""
      Me.SpAddFile.TooltipText = "Allega file"
      '
      'SpView
      '
      Me.SpView.ApplyOutLookStile = True
      Me.SpView.BackColor = System.Drawing.Color.Transparent
      Me.SpView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.SpView.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.file_view_32x32
      Me.SpView.Disabled = False
      Me.SpView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.SpView.ForeColor = System.Drawing.Color.Transparent
      Me.HelpProvider1.SetHelpString(Me.SpView, "Funzione che permette di visualizzare un file relativo all'evento della vertenza(" & _
              "es. raccomandate inviate...)")
      Me.SpView.Location = New System.Drawing.Point(356, 193)
      Me.SpView.Name = "SpView"
      Me.SpView.Radius = 32.0!
      Me.HelpProvider1.SetShowHelp(Me.SpView, True)
      Me.SpView.ShowTooltip = True
      Me.SpView.Size = New System.Drawing.Size(32, 32)
      Me.SpView.TabIndex = 58
      Me.SpView.TextValue = ""
      Me.SpView.TooltipText = "Apri file"
      '
      'SpDel
      '
      Me.SpDel.ApplyOutLookStile = True
      Me.SpDel.BackColor = System.Drawing.Color.Transparent
      Me.SpDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.SpDel.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.file_broken_32x32
      Me.SpDel.Disabled = False
      Me.SpDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.SpDel.ForeColor = System.Drawing.Color.Transparent
      Me.HelpProvider1.SetHelpString(Me.SpDel, resources.GetString("SpDel.HelpString"))
      Me.SpDel.Location = New System.Drawing.Point(432, 193)
      Me.SpDel.Name = "SpDel"
      Me.SpDel.Radius = 32.0!
      Me.HelpProvider1.SetShowHelp(Me.SpDel, True)
      Me.SpDel.ShowTooltip = True
      Me.SpDel.Size = New System.Drawing.Size(32, 32)
      Me.SpDel.TabIndex = 60
      Me.SpDel.TextValue = ""
      Me.SpDel.TooltipText = "Elimina file"
      '
      'SpDelRef
      '
      Me.SpDelRef.ApplyOutLookStile = True
      Me.SpDelRef.BackColor = System.Drawing.Color.Transparent
      Me.SpDelRef.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
      Me.SpDelRef.BackImage = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.file_broken_feneal_32x32
      Me.SpDelRef.Disabled = False
      Me.SpDelRef.FlatStyle = System.Windows.Forms.FlatStyle.Flat
      Me.SpDelRef.ForeColor = System.Drawing.Color.Transparent
      Me.HelpProvider1.SetHelpString(Me.SpDelRef, resources.GetString("SpDelRef.HelpString"))
      Me.SpDelRef.Location = New System.Drawing.Point(394, 193)
      Me.SpDelRef.Name = "SpDelRef"
      Me.SpDelRef.Radius = 32.0!
      Me.HelpProvider1.SetShowHelp(Me.SpDelRef, True)
      Me.SpDelRef.ShowTooltip = True
      Me.SpDelRef.Size = New System.Drawing.Size(32, 32)
      Me.SpDelRef.TabIndex = 59
      Me.SpDelRef.TextValue = ""
      Me.SpDelRef.TooltipText = "Elimina riferimento"
      '
      'FrmEventi
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(480, 488)
      Me.Controls.Add(Me.SpAddFile)
      Me.Controls.Add(Me.SpView)
      Me.Controls.Add(Me.SpDel)
      Me.Controls.Add(Me.SpDelRef)
      Me.Controls.Add(Me.lblDocumento)
      Me.Controls.Add(Me.Label4)
      Me.Controls.Add(Me.cmdOk)
      Me.Controls.Add(Me.txtEnte)
      Me.Controls.Add(Me.lblInoltro)
      Me.Controls.Add(Me.cmdAnnulla)
      Me.Controls.Add(Me.cmdAdd)
      Me.Controls.Add(Me.txtIntervento)
      Me.Controls.Add(Me.lblIntervento)
      Me.Controls.Add(Me.txtNote)
      Me.Controls.Add(Me.Label3)
      Me.Controls.Add(Me.dtpData)
      Me.Controls.Add(Me.Label2)
      Me.Controls.Add(Me.cboTipo)
      Me.Controls.Add(Me.Label1)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
      Me.MaximizeBox = False
      Me.MinimizeBox = False
      Me.Name = "FrmEventi"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Evento vertenza"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents dtpData As System.Windows.Forms.DateTimePicker
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents txtNote As System.Windows.Forms.TextBox
   Friend WithEvents lblIntervento As System.Windows.Forms.Label
   Friend WithEvents txtIntervento As System.Windows.Forms.TextBox
   Friend WithEvents cmdAdd As System.Windows.Forms.Button
   Friend WithEvents cmdAnnulla As System.Windows.Forms.Button
   Friend WithEvents lblInoltro As System.Windows.Forms.Label
   Friend WithEvents txtEnte As System.Windows.Forms.TextBox
   Friend WithEvents cmdOk As System.Windows.Forms.Button
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents lblDocumento As System.Windows.Forms.Label
   Friend WithEvents SpAddFile As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents SpView As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
   Friend WithEvents SpDel As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents SpDelRef As WIN.GUI.APPLICATION.PRESENTATION.SpecialButton
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
End Class
