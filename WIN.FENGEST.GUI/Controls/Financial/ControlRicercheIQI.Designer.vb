<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlRicercheIQI
    Inherits System.Windows.Forms.UserControl

    'UserControl esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlRicercheIQI))
        Me.SearcTab = New System.Windows.Forms.TabControl
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.chkRes = New System.Windows.Forms.CheckBox
        Me.cboComune = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cboProvincia = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.lblSogg = New System.Windows.Forms.Label
        Me.cmdUt = New System.Windows.Forms.Button
        Me.chkUt = New System.Windows.Forms.CheckBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cboTipo = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpDocA = New System.Windows.Forms.DateTimePicker
        Me.dtpDocDa = New System.Windows.Forms.DateTimePicker
        Me.dtpRegDa = New System.Windows.Forms.DateTimePicker
        Me.Label9 = New System.Windows.Forms.Label
        Me.chkReg = New System.Windows.Forms.CheckBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.chkDoc = New System.Windows.Forms.CheckBox
        Me.dtpRegA = New System.Windows.Forms.DateTimePicker
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider
        Me.SearcTab.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'SearcTab
        '
        Me.SearcTab.Controls.Add(Me.TabPage2)
        Me.SearcTab.Location = New System.Drawing.Point(3, 3)
        Me.SearcTab.Name = "SearcTab"
        Me.SearcTab.SelectedIndex = 0
        Me.SearcTab.Size = New System.Drawing.Size(521, 246)
        Me.SearcTab.TabIndex = 15
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.chkRes)
        Me.TabPage2.Controls.Add(Me.cboComune)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.cboProvincia)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.lblSogg)
        Me.TabPage2.Controls.Add(Me.cmdUt)
        Me.TabPage2.Controls.Add(Me.chkUt)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.cboTipo)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.dtpDocA)
        Me.TabPage2.Controls.Add(Me.dtpDocDa)
        Me.TabPage2.Controls.Add(Me.dtpRegDa)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.chkReg)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.chkDoc)
        Me.TabPage2.Controls.Add(Me.dtpRegA)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(513, 220)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Ricerca prestazioni"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'chkRes
        '
        Me.chkRes.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.chkRes, "Spuntare questa casella se si vuole realizzare il report delle prestazioni degli " & _
                "utenti la cui residenza sia specificata in termini di provincia e comune di resi" & _
                "denza")
        Me.chkRes.Location = New System.Drawing.Point(20, 160)
        Me.chkRes.Name = "chkRes"
        Me.HelpProvider1.SetShowHelp(Me.chkRes, True)
        Me.chkRes.Size = New System.Drawing.Size(121, 17)
        Me.chkRes.TabIndex = 66
        Me.chkRes.Text = "Selezione res. utenti"
        Me.chkRes.UseVisualStyleBackColor = True
        '
        'cboComune
        '
        Me.cboComune.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboComune.FormattingEnabled = True
        Me.cboComune.Location = New System.Drawing.Point(223, 187)
        Me.cboComune.Name = "cboComune"
        Me.cboComune.Size = New System.Drawing.Size(224, 21)
        Me.cboComune.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(169, 191)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 13)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Com. res."
        '
        'cboProvincia
        '
        Me.cboProvincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProvincia.FormattingEnabled = True
        Me.cboProvincia.Location = New System.Drawing.Point(223, 157)
        Me.cboProvincia.Name = "cboProvincia"
        Me.cboProvincia.Size = New System.Drawing.Size(224, 21)
        Me.cboProvincia.TabIndex = 10
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(168, 161)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 13)
        Me.Label12.TabIndex = 64
        Me.Label12.Text = "Prov. res."
        '
        'lblSogg
        '
        Me.lblSogg.AutoSize = True
        Me.lblSogg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSogg.Location = New System.Drawing.Point(286, 63)
        Me.lblSogg.Name = "lblSogg"
        Me.lblSogg.Size = New System.Drawing.Size(0, 13)
        Me.lblSogg.TabIndex = 61
        Me.lblSogg.UseMnemonic = False
        '
        'cmdUt
        '
        Me.HelpProvider1.SetHelpString(Me.cmdUt, resources.GetString("cmdUt.HelpString"))
        Me.cmdUt.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.k_edit_16x16
        Me.cmdUt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdUt.Location = New System.Drawing.Point(203, 56)
        Me.cmdUt.Name = "cmdUt"
        Me.HelpProvider1.SetShowHelp(Me.cmdUt, True)
        Me.cmdUt.Size = New System.Drawing.Size(77, 26)
        Me.cmdUt.TabIndex = 9
        Me.cmdUt.Text = "Seleziona"
        Me.cmdUt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdUt.UseVisualStyleBackColor = True
        '
        'chkUt
        '
        Me.chkUt.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.chkUt, "Spuntare questa casella se si vuole realizzare un report delle prestazioni di una" & _
                " certa lista di utenti.")
        Me.chkUt.Location = New System.Drawing.Point(20, 62)
        Me.chkUt.Name = "chkUt"
        Me.HelpProvider1.SetShowHelp(Me.chkUt, True)
        Me.chkUt.Size = New System.Drawing.Size(122, 17)
        Me.chkUt.TabIndex = 8
        Me.chkUt.Text = "Selezione lista utenti"
        Me.chkUt.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(332, 128)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 13)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "a"
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboTipo, "Tipi di prestazione per cui si vuole realizzare un report. Se non viene seleziona" & _
                "to alcun tipo di prestazione,il report conterrà tutte le prestazioni di ogni tip" & _
                "o.")
        Me.cboTipo.Location = New System.Drawing.Point(77, 17)
        Me.cboTipo.Name = "cboTipo"
        Me.HelpProvider1.SetShowHelp(Me.cboTipo, True)
        Me.cboTipo.Size = New System.Drawing.Size(204, 21)
        Me.cboTipo.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(200, 128)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(19, 13)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "da"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Tipo prest."
        '
        'dtpDocA
        '
        Me.dtpDocA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDocA.Location = New System.Drawing.Point(348, 124)
        Me.dtpDocA.Name = "dtpDocA"
        Me.dtpDocA.Size = New System.Drawing.Size(99, 20)
        Me.dtpDocA.TabIndex = 7
        '
        'dtpDocDa
        '
        Me.dtpDocDa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDocDa.Location = New System.Drawing.Point(222, 124)
        Me.dtpDocDa.Name = "dtpDocDa"
        Me.dtpDocDa.Size = New System.Drawing.Size(99, 20)
        Me.dtpDocDa.TabIndex = 6
        '
        'dtpRegDa
        '
        Me.dtpRegDa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRegDa.Location = New System.Drawing.Point(222, 92)
        Me.dtpRegDa.Name = "dtpRegDa"
        Me.dtpRegDa.Size = New System.Drawing.Size(99, 20)
        Me.dtpRegDa.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(332, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 13)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "a"
        '
        'chkReg
        '
        Me.chkReg.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.chkReg, resources.GetString("chkReg.HelpString"))
        Me.chkReg.Location = New System.Drawing.Point(20, 95)
        Me.chkReg.Name = "chkReg"
        Me.HelpProvider1.SetShowHelp(Me.chkReg, True)
        Me.chkReg.Size = New System.Drawing.Size(146, 17)
        Me.chkReg.TabIndex = 2
        Me.chkReg.Text = "Selezione data reg. prest."
        Me.chkReg.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(200, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 13)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "da"
        '
        'chkDoc
        '
        Me.chkDoc.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.chkDoc, resources.GetString("chkDoc.HelpString"))
        Me.chkDoc.Location = New System.Drawing.Point(20, 127)
        Me.chkDoc.Name = "chkDoc"
        Me.HelpProvider1.SetShowHelp(Me.chkDoc, True)
        Me.chkDoc.Size = New System.Drawing.Size(149, 17)
        Me.chkDoc.TabIndex = 5
        Me.chkDoc.Text = "Selezione data doc. prest."
        Me.chkDoc.UseVisualStyleBackColor = True
        '
        'dtpRegA
        '
        Me.dtpRegA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRegA.Location = New System.Drawing.Point(348, 92)
        Me.dtpRegA.Name = "dtpRegA"
        Me.dtpRegA.Size = New System.Drawing.Size(99, 20)
        Me.dtpRegA.TabIndex = 4
        '
        'ControlRicercheIQI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.SearcTab)
        Me.Name = "ControlRicercheIQI"
        Me.Size = New System.Drawing.Size(525, 252)
        Me.SearcTab.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
   Friend WithEvents SearcTab As System.Windows.Forms.TabControl
   Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
   Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents Label10 As System.Windows.Forms.Label
   Friend WithEvents Label11 As System.Windows.Forms.Label
   Friend WithEvents dtpDocA As System.Windows.Forms.DateTimePicker
   Friend WithEvents dtpDocDa As System.Windows.Forms.DateTimePicker
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents dtpRegA As System.Windows.Forms.DateTimePicker
   Friend WithEvents dtpRegDa As System.Windows.Forms.DateTimePicker
   Friend WithEvents chkDoc As System.Windows.Forms.CheckBox
   Friend WithEvents chkReg As System.Windows.Forms.CheckBox
   Friend WithEvents lblSogg As System.Windows.Forms.Label
   Friend WithEvents cmdUt As System.Windows.Forms.Button
   Friend WithEvents chkUt As System.Windows.Forms.CheckBox
   Friend WithEvents cboComune As System.Windows.Forms.ComboBox
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents cboProvincia As System.Windows.Forms.ComboBox
   Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents chkRes As System.Windows.Forms.CheckBox
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider

End Class
