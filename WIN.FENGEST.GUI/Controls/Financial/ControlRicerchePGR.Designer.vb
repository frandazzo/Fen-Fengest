<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ControlRicerchePGR
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ControlRicerchePGR))
        Me.SearcTab = New System.Windows.Forms.TabControl
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.lblSogg = New System.Windows.Forms.Label
        Me.cboTipo = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.chkReg = New System.Windows.Forms.CheckBox
        Me.dtpDocA = New System.Windows.Forms.DateTimePicker
        Me.chkDoc = New System.Windows.Forms.CheckBox
        Me.dtpDocDa = New System.Windows.Forms.DateTimePicker
        Me.chkComp = New System.Windows.Forms.CheckBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.chkSogg = New System.Windows.Forms.CheckBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.dtpRegDa = New System.Windows.Forms.DateTimePicker
        Me.dtpCompA = New System.Windows.Forms.DateTimePicker
        Me.cmdSogg = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtpRegA = New System.Windows.Forms.DateTimePicker
        Me.dtpCompDa = New System.Windows.Forms.DateTimePicker
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
        Me.SearcTab.Size = New System.Drawing.Size(559, 274)
        Me.SearcTab.TabIndex = 14
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.lblSogg)
        Me.TabPage2.Controls.Add(Me.cboTipo)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.chkReg)
        Me.TabPage2.Controls.Add(Me.dtpDocA)
        Me.TabPage2.Controls.Add(Me.chkDoc)
        Me.TabPage2.Controls.Add(Me.dtpDocDa)
        Me.TabPage2.Controls.Add(Me.chkComp)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.chkSogg)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.dtpRegDa)
        Me.TabPage2.Controls.Add(Me.dtpCompA)
        Me.TabPage2.Controls.Add(Me.cmdSogg)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.dtpRegA)
        Me.TabPage2.Controls.Add(Me.dtpCompDa)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(551, 248)
        Me.TabPage2.TabIndex = 0
        Me.TabPage2.Text = "Ricerca posizioni da ristornare"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'lblSogg
        '
        Me.lblSogg.AutoSize = True
        Me.lblSogg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSogg.Location = New System.Drawing.Point(274, 61)
        Me.lblSogg.Name = "lblSogg"
        Me.lblSogg.Size = New System.Drawing.Size(11, 13)
        Me.lblSogg.TabIndex = 58
        Me.lblSogg.Text = "-"
        '
        'cboTipo
        '
        Me.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipo.FormattingEnabled = True
        Me.HelpProvider1.SetHelpString(Me.cboTipo, "Tipi di posizioni che si vogliono ristornare per il collaboratore comunale. Esse " & _
                "possono essere incassi quote associative,quote Inps e quote vertenza.")
        Me.cboTipo.Items.AddRange(New Object() {"IQA - Incasso quota associativa", "IQI - Incasso quota Inps", "IQV - Incasso quota vertenza"})
        Me.cboTipo.Location = New System.Drawing.Point(121, 13)
        Me.cboTipo.Name = "cboTipo"
        Me.HelpProvider1.SetShowHelp(Me.cboTipo, True)
        Me.cboTipo.Size = New System.Drawing.Size(204, 21)
        Me.cboTipo.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(322, 126)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 13)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "a"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Tipo documento"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(190, 126)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(19, 13)
        Me.Label11.TabIndex = 52
        Me.Label11.Text = "da"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(322, 159)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(13, 13)
        Me.Label12.TabIndex = 57
        Me.Label12.Text = "a"
        '
        'chkReg
        '
        Me.chkReg.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.chkReg, resources.GetString("chkReg.HelpString"))
        Me.chkReg.Location = New System.Drawing.Point(23, 92)
        Me.chkReg.Name = "chkReg"
        Me.HelpProvider1.SetShowHelp(Me.chkReg, True)
        Me.chkReg.Size = New System.Drawing.Size(117, 17)
        Me.chkReg.TabIndex = 2
        Me.chkReg.Text = "Selezione data reg."
        Me.chkReg.UseVisualStyleBackColor = True
        '
        'dtpDocA
        '
        Me.dtpDocA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDocA.Location = New System.Drawing.Point(338, 122)
        Me.dtpDocA.Name = "dtpDocA"
        Me.dtpDocA.Size = New System.Drawing.Size(99, 20)
        Me.dtpDocA.TabIndex = 7
        '
        'chkDoc
        '
        Me.chkDoc.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.chkDoc, resources.GetString("chkDoc.HelpString"))
        Me.chkDoc.Location = New System.Drawing.Point(23, 125)
        Me.chkDoc.Name = "chkDoc"
        Me.HelpProvider1.SetShowHelp(Me.chkDoc, True)
        Me.chkDoc.Size = New System.Drawing.Size(120, 17)
        Me.chkDoc.TabIndex = 5
        Me.chkDoc.Text = "Selezione data doc."
        Me.chkDoc.UseVisualStyleBackColor = True
        '
        'dtpDocDa
        '
        Me.dtpDocDa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDocDa.Location = New System.Drawing.Point(212, 122)
        Me.dtpDocDa.Name = "dtpDocDa"
        Me.dtpDocDa.Size = New System.Drawing.Size(99, 20)
        Me.dtpDocDa.TabIndex = 6
        '
        'chkComp
        '
        Me.chkComp.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.chkComp, "Spuntare questa casella se si vuole realizzare il report delle posizioni ristorna" & _
                "bili, per il collaboratore comunale, i cui periodi di competenza intersechino l'" & _
                "intervallo temporale ""da-a""")
        Me.chkComp.Location = New System.Drawing.Point(23, 158)
        Me.chkComp.Name = "chkComp"
        Me.HelpProvider1.SetShowHelp(Me.chkComp, True)
        Me.chkComp.Size = New System.Drawing.Size(136, 17)
        Me.chkComp.TabIndex = 8
        Me.chkComp.Text = "Selezione  competenza"
        Me.chkComp.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(190, 158)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(19, 13)
        Me.Label14.TabIndex = 56
        Me.Label14.Text = "da"
        '
        'chkSogg
        '
        Me.chkSogg.AutoSize = True
        Me.HelpProvider1.SetHelpString(Me.chkSogg, resources.GetString("chkSogg.HelpString"))
        Me.chkSogg.Location = New System.Drawing.Point(23, 60)
        Me.chkSogg.Name = "chkSogg"
        Me.HelpProvider1.SetShowHelp(Me.chkSogg, True)
        Me.chkSogg.Size = New System.Drawing.Size(151, 17)
        Me.chkSogg.TabIndex = 11
        Me.chkSogg.Text = "Selezione sogg. esecutore"
        Me.chkSogg.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(322, 94)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 13)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "a"
        '
        'dtpRegDa
        '
        Me.dtpRegDa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRegDa.Location = New System.Drawing.Point(212, 90)
        Me.dtpRegDa.Name = "dtpRegDa"
        Me.dtpRegDa.Size = New System.Drawing.Size(99, 20)
        Me.dtpRegDa.TabIndex = 3
        '
        'dtpCompA
        '
        Me.dtpCompA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCompA.Location = New System.Drawing.Point(338, 155)
        Me.dtpCompA.Name = "dtpCompA"
        Me.dtpCompA.Size = New System.Drawing.Size(99, 20)
        Me.dtpCompA.TabIndex = 10
        '
        'cmdSogg
        '
        Me.cmdSogg.Image = Global.WIN.GUI.APPLICATION.PRESENTATION.My.Resources.Resources.k_edit_16x16
        Me.cmdSogg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSogg.Location = New System.Drawing.Point(193, 55)
        Me.cmdSogg.Name = "cmdSogg"
        Me.cmdSogg.Size = New System.Drawing.Size(74, 24)
        Me.cmdSogg.TabIndex = 12
        Me.cmdSogg.Text = "Seleziona"
        Me.cmdSogg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdSogg.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(190, 94)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 13)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "da"
        '
        'dtpRegA
        '
        Me.dtpRegA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpRegA.Location = New System.Drawing.Point(338, 90)
        Me.dtpRegA.Name = "dtpRegA"
        Me.dtpRegA.Size = New System.Drawing.Size(99, 20)
        Me.dtpRegA.TabIndex = 4
        '
        'dtpCompDa
        '
        Me.dtpCompDa.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCompDa.Location = New System.Drawing.Point(212, 155)
        Me.dtpCompDa.Name = "dtpCompDa"
        Me.dtpCompDa.Size = New System.Drawing.Size(99, 20)
        Me.dtpCompDa.TabIndex = 9
        '
        'ControlRicerchePGR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.SearcTab)
        Me.Name = "ControlRicerchePGR"
        Me.Size = New System.Drawing.Size(574, 287)
        Me.SearcTab.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SearcTab As System.Windows.Forms.TabControl
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dtpDocA As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDocDa As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpRegA As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpRegDa As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
   Friend WithEvents Label14 As System.Windows.Forms.Label
   Friend WithEvents dtpCompA As System.Windows.Forms.DateTimePicker
   Friend WithEvents dtpCompDa As System.Windows.Forms.DateTimePicker
   Friend WithEvents cmdSogg As System.Windows.Forms.Button
   Friend WithEvents chkSogg As System.Windows.Forms.CheckBox
   Friend WithEvents chkComp As System.Windows.Forms.CheckBox
   Friend WithEvents chkDoc As System.Windows.Forms.CheckBox
   Friend WithEvents chkReg As System.Windows.Forms.CheckBox
   Friend WithEvents cboTipo As System.Windows.Forms.ComboBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblSogg As System.Windows.Forms.Label
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider

End Class
