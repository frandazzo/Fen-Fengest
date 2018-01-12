<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSituazioneFamiliare
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
      Me.chkACarico = New System.Windows.Forms.CheckBox
      Me.cboStatus = New System.Windows.Forms.ComboBox
      Me.Label21 = New System.Windows.Forms.Label
      Me.chkCasa = New System.Windows.Forms.CheckBox
      Me.dtpIntervista = New System.Windows.Forms.DateTimePicker
      Me.Label20 = New System.Windows.Forms.Label
      Me.NiceGroupBox1 = New WIN.GUI.UTILITY.NiceGroupBox
      Me.TextBox1 = New System.Windows.Forms.TextBox
      Me.Label14 = New System.Windows.Forms.Label
      Me.TextBox2 = New System.Windows.Forms.TextBox
      Me.Label15 = New System.Windows.Forms.Label
      Me.CheckBox1 = New System.Windows.Forms.CheckBox
      Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
      Me.Label16 = New System.Windows.Forms.Label
      Me.TextBox3 = New System.Windows.Forms.TextBox
      Me.Label17 = New System.Windows.Forms.Label
      Me.TextBox4 = New System.Windows.Forms.TextBox
      Me.Label18 = New System.Windows.Forms.Label
      Me.CheckBox2 = New System.Windows.Forms.CheckBox
      Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
      Me.Label19 = New System.Windows.Forms.Label
      Me.txtFreq4 = New System.Windows.Forms.TextBox
      Me.Label10 = New System.Windows.Forms.Label
      Me.txtScuola4 = New System.Windows.Forms.TextBox
      Me.Label11 = New System.Windows.Forms.Label
      Me.chjFiglio4 = New System.Windows.Forms.CheckBox
      Me.dtpFiglio4 = New System.Windows.Forms.DateTimePicker
      Me.Label12 = New System.Windows.Forms.Label
      Me.txtFreq3 = New System.Windows.Forms.TextBox
      Me.Label7 = New System.Windows.Forms.Label
      Me.txtScuola3 = New System.Windows.Forms.TextBox
      Me.Label8 = New System.Windows.Forms.Label
      Me.chjFiglio3 = New System.Windows.Forms.CheckBox
      Me.dtpFiglio3 = New System.Windows.Forms.DateTimePicker
      Me.Label9 = New System.Windows.Forms.Label
      Me.txtFreq2 = New System.Windows.Forms.TextBox
      Me.Label4 = New System.Windows.Forms.Label
      Me.txtScuola2 = New System.Windows.Forms.TextBox
      Me.Label5 = New System.Windows.Forms.Label
      Me.chjFiglio2 = New System.Windows.Forms.CheckBox
      Me.dtpFiglio2 = New System.Windows.Forms.DateTimePicker
      Me.Label6 = New System.Windows.Forms.Label
      Me.txtFreq1 = New System.Windows.Forms.TextBox
      Me.Label3 = New System.Windows.Forms.Label
      Me.txtScuola1 = New System.Windows.Forms.TextBox
      Me.Label1 = New System.Windows.Forms.Label
      Me.chjFiglio1 = New System.Windows.Forms.CheckBox
      Me.dtpFiglio1 = New System.Windows.Forms.DateTimePicker
      Me.Label2 = New System.Windows.Forms.Label
      Me.NiceGroupBox2 = New WIN.GUI.UTILITY.NiceGroupBox
      Me.cmdOk = New System.Windows.Forms.Button
      Me.cmdAnnulla = New System.Windows.Forms.Button
      Me.Label13 = New System.Windows.Forms.Label
      Me.IdReferenteTextBox1 = New WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox
      Me.NiceGroupBox1.SuspendLayout()
      Me.NiceGroupBox2.SuspendLayout()
      Me.SuspendLayout()
      '
      'chkACarico
      '
      Me.chkACarico.AutoSize = True
      Me.chkACarico.Location = New System.Drawing.Point(471, 40)
      Me.chkACarico.Name = "chkACarico"
      Me.chkACarico.Size = New System.Drawing.Size(106, 17)
      Me.chkACarico.TabIndex = 3
      Me.chkACarico.Text = "Coniuge a carico"
      Me.chkACarico.UseVisualStyleBackColor = True
      '
      'cboStatus
      '
      Me.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
      Me.cboStatus.FormattingEnabled = True
      Me.cboStatus.Items.AddRange(New Object() {"Celibe-Nubile", "Coniugato", "Separato"})
      Me.cboStatus.Location = New System.Drawing.Point(95, 34)
      Me.cboStatus.Name = "cboStatus"
      Me.cboStatus.Size = New System.Drawing.Size(159, 21)
      Me.cboStatus.TabIndex = 1
      '
      'Label21
      '
      Me.Label21.AutoSize = True
      Me.Label21.Location = New System.Drawing.Point(27, 41)
      Me.Label21.Name = "Label21"
      Me.Label21.Size = New System.Drawing.Size(62, 13)
      Me.Label21.TabIndex = 0
      Me.Label21.Text = "Stato civile:"
      '
      'chkCasa
      '
      Me.chkCasa.AutoSize = True
      Me.chkCasa.Location = New System.Drawing.Point(322, 40)
      Me.chkCasa.Name = "chkCasa"
      Me.chkCasa.Size = New System.Drawing.Size(105, 17)
      Me.chkCasa.TabIndex = 2
      Me.chkCasa.Text = "Casa di proprietà"
      Me.chkCasa.UseVisualStyleBackColor = True
      '
      'dtpIntervista
      '
      Me.dtpIntervista.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.dtpIntervista.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.dtpIntervista.Location = New System.Drawing.Point(85, 21)
      Me.dtpIntervista.Name = "dtpIntervista"
      Me.dtpIntervista.Size = New System.Drawing.Size(105, 20)
      Me.dtpIntervista.TabIndex = 0
      '
      'Label20
      '
      Me.Label20.AutoSize = True
      Me.Label20.Location = New System.Drawing.Point(1, 28)
      Me.Label20.Name = "Label20"
      Me.Label20.Size = New System.Drawing.Size(78, 13)
      Me.Label20.TabIndex = 10
      Me.Label20.Text = "Data intervista:"
      '
      'NiceGroupBox1
      '
      Me.NiceGroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.NiceGroupBox1.Controls.Add(Me.TextBox1)
      Me.NiceGroupBox1.Controls.Add(Me.Label14)
      Me.NiceGroupBox1.Controls.Add(Me.TextBox2)
      Me.NiceGroupBox1.Controls.Add(Me.Label15)
      Me.NiceGroupBox1.Controls.Add(Me.CheckBox1)
      Me.NiceGroupBox1.Controls.Add(Me.DateTimePicker1)
      Me.NiceGroupBox1.Controls.Add(Me.Label16)
      Me.NiceGroupBox1.Controls.Add(Me.TextBox3)
      Me.NiceGroupBox1.Controls.Add(Me.Label17)
      Me.NiceGroupBox1.Controls.Add(Me.TextBox4)
      Me.NiceGroupBox1.Controls.Add(Me.Label18)
      Me.NiceGroupBox1.Controls.Add(Me.CheckBox2)
      Me.NiceGroupBox1.Controls.Add(Me.DateTimePicker2)
      Me.NiceGroupBox1.Controls.Add(Me.Label19)
      Me.NiceGroupBox1.Controls.Add(Me.txtFreq4)
      Me.NiceGroupBox1.Controls.Add(Me.Label10)
      Me.NiceGroupBox1.Controls.Add(Me.txtScuola4)
      Me.NiceGroupBox1.Controls.Add(Me.Label11)
      Me.NiceGroupBox1.Controls.Add(Me.chjFiglio4)
      Me.NiceGroupBox1.Controls.Add(Me.dtpFiglio4)
      Me.NiceGroupBox1.Controls.Add(Me.Label12)
      Me.NiceGroupBox1.Controls.Add(Me.txtFreq3)
      Me.NiceGroupBox1.Controls.Add(Me.Label7)
      Me.NiceGroupBox1.Controls.Add(Me.txtScuola3)
      Me.NiceGroupBox1.Controls.Add(Me.Label8)
      Me.NiceGroupBox1.Controls.Add(Me.chjFiglio3)
      Me.NiceGroupBox1.Controls.Add(Me.dtpFiglio3)
      Me.NiceGroupBox1.Controls.Add(Me.Label9)
      Me.NiceGroupBox1.Controls.Add(Me.txtFreq2)
      Me.NiceGroupBox1.Controls.Add(Me.Label4)
      Me.NiceGroupBox1.Controls.Add(Me.txtScuola2)
      Me.NiceGroupBox1.Controls.Add(Me.Label5)
      Me.NiceGroupBox1.Controls.Add(Me.chjFiglio2)
      Me.NiceGroupBox1.Controls.Add(Me.dtpFiglio2)
      Me.NiceGroupBox1.Controls.Add(Me.Label6)
      Me.NiceGroupBox1.Controls.Add(Me.txtFreq1)
      Me.NiceGroupBox1.Controls.Add(Me.Label3)
      Me.NiceGroupBox1.Controls.Add(Me.txtScuola1)
      Me.NiceGroupBox1.Controls.Add(Me.Label1)
      Me.NiceGroupBox1.Controls.Add(Me.chjFiglio1)
      Me.NiceGroupBox1.Controls.Add(Me.dtpFiglio1)
      Me.NiceGroupBox1.Controls.Add(Me.Label2)
      Me.NiceGroupBox1.Location = New System.Drawing.Point(15, 152)
      Me.NiceGroupBox1.Name = "NiceGroupBox1"
      Me.NiceGroupBox1.Size = New System.Drawing.Size(720, 254)
      Me.NiceGroupBox1.TabIndex = 2
      Me.NiceGroupBox1.Title = "Situazione familiare"
      '
      'TextBox1
      '
      Me.TextBox1.Location = New System.Drawing.Point(626, 212)
      Me.TextBox1.Name = "TextBox1"
      Me.TextBox1.Size = New System.Drawing.Size(59, 20)
      Me.TextBox1.TabIndex = 45
      '
      'Label14
      '
      Me.Label14.AutoSize = True
      Me.Label14.Location = New System.Drawing.Point(561, 216)
      Me.Label14.Name = "Label14"
      Me.Label14.Size = New System.Drawing.Size(59, 13)
      Me.Label14.TabIndex = 51
      Me.Label14.Text = "Anno freq.:"
      '
      'TextBox2
      '
      Me.TextBox2.Location = New System.Drawing.Point(350, 214)
      Me.TextBox2.Name = "TextBox2"
      Me.TextBox2.Size = New System.Drawing.Size(205, 20)
      Me.TextBox2.TabIndex = 44
      '
      'Label15
      '
      Me.Label15.AutoSize = True
      Me.Label15.Location = New System.Drawing.Point(301, 218)
      Me.Label15.Name = "Label15"
      Me.Label15.Size = New System.Drawing.Size(43, 13)
      Me.Label15.TabIndex = 50
      Me.Label15.Text = "Scuola:"
      '
      'CheckBox1
      '
      Me.CheckBox1.AutoSize = True
      Me.CheckBox1.Location = New System.Drawing.Point(27, 217)
      Me.CheckBox1.Name = "CheckBox1"
      Me.CheckBox1.Size = New System.Drawing.Size(50, 17)
      Me.CheckBox1.TabIndex = 42
      Me.CheckBox1.Text = "Figlio"
      Me.CheckBox1.UseVisualStyleBackColor = True
      '
      'DateTimePicker1
      '
      Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.DateTimePicker1.Location = New System.Drawing.Point(155, 214)
      Me.DateTimePicker1.Name = "DateTimePicker1"
      Me.DateTimePicker1.Size = New System.Drawing.Size(105, 20)
      Me.DateTimePicker1.TabIndex = 43
      '
      'Label16
      '
      Me.Label16.AutoSize = True
      Me.Label16.Location = New System.Drawing.Point(92, 219)
      Me.Label16.Name = "Label16"
      Me.Label16.Size = New System.Drawing.Size(62, 13)
      Me.Label16.TabIndex = 49
      Me.Label16.Text = "Data nasc.:"
      '
      'TextBox3
      '
      Me.TextBox3.Location = New System.Drawing.Point(626, 177)
      Me.TextBox3.Name = "TextBox3"
      Me.TextBox3.Size = New System.Drawing.Size(59, 20)
      Me.TextBox3.TabIndex = 41
      '
      'Label17
      '
      Me.Label17.AutoSize = True
      Me.Label17.Location = New System.Drawing.Point(561, 181)
      Me.Label17.Name = "Label17"
      Me.Label17.Size = New System.Drawing.Size(59, 13)
      Me.Label17.TabIndex = 48
      Me.Label17.Text = "Anno freq.:"
      '
      'TextBox4
      '
      Me.TextBox4.Location = New System.Drawing.Point(350, 179)
      Me.TextBox4.Name = "TextBox4"
      Me.TextBox4.Size = New System.Drawing.Size(205, 20)
      Me.TextBox4.TabIndex = 40
      '
      'Label18
      '
      Me.Label18.AutoSize = True
      Me.Label18.Location = New System.Drawing.Point(301, 183)
      Me.Label18.Name = "Label18"
      Me.Label18.Size = New System.Drawing.Size(43, 13)
      Me.Label18.TabIndex = 47
      Me.Label18.Text = "Scuola:"
      '
      'CheckBox2
      '
      Me.CheckBox2.AutoSize = True
      Me.CheckBox2.Location = New System.Drawing.Point(27, 182)
      Me.CheckBox2.Name = "CheckBox2"
      Me.CheckBox2.Size = New System.Drawing.Size(50, 17)
      Me.CheckBox2.TabIndex = 38
      Me.CheckBox2.Text = "Figlio"
      Me.CheckBox2.UseVisualStyleBackColor = True
      '
      'DateTimePicker2
      '
      Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.DateTimePicker2.Location = New System.Drawing.Point(155, 179)
      Me.DateTimePicker2.Name = "DateTimePicker2"
      Me.DateTimePicker2.Size = New System.Drawing.Size(105, 20)
      Me.DateTimePicker2.TabIndex = 39
      '
      'Label19
      '
      Me.Label19.AutoSize = True
      Me.Label19.Location = New System.Drawing.Point(92, 184)
      Me.Label19.Name = "Label19"
      Me.Label19.Size = New System.Drawing.Size(62, 13)
      Me.Label19.TabIndex = 46
      Me.Label19.Text = "Data nasc.:"
      '
      'txtFreq4
      '
      Me.txtFreq4.Location = New System.Drawing.Point(626, 142)
      Me.txtFreq4.Name = "txtFreq4"
      Me.txtFreq4.Size = New System.Drawing.Size(59, 20)
      Me.txtFreq4.TabIndex = 15
      '
      'Label10
      '
      Me.Label10.AutoSize = True
      Me.Label10.Location = New System.Drawing.Point(561, 146)
      Me.Label10.Name = "Label10"
      Me.Label10.Size = New System.Drawing.Size(59, 13)
      Me.Label10.TabIndex = 37
      Me.Label10.Text = "Anno freq.:"
      '
      'txtScuola4
      '
      Me.txtScuola4.Location = New System.Drawing.Point(350, 144)
      Me.txtScuola4.Name = "txtScuola4"
      Me.txtScuola4.Size = New System.Drawing.Size(205, 20)
      Me.txtScuola4.TabIndex = 14
      '
      'Label11
      '
      Me.Label11.AutoSize = True
      Me.Label11.Location = New System.Drawing.Point(301, 148)
      Me.Label11.Name = "Label11"
      Me.Label11.Size = New System.Drawing.Size(43, 13)
      Me.Label11.TabIndex = 35
      Me.Label11.Text = "Scuola:"
      '
      'chjFiglio4
      '
      Me.chjFiglio4.AutoSize = True
      Me.chjFiglio4.Location = New System.Drawing.Point(27, 147)
      Me.chjFiglio4.Name = "chjFiglio4"
      Me.chjFiglio4.Size = New System.Drawing.Size(50, 17)
      Me.chjFiglio4.TabIndex = 12
      Me.chjFiglio4.Text = "Figlio"
      Me.chjFiglio4.UseVisualStyleBackColor = True
      '
      'dtpFiglio4
      '
      Me.dtpFiglio4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.dtpFiglio4.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.dtpFiglio4.Location = New System.Drawing.Point(155, 144)
      Me.dtpFiglio4.Name = "dtpFiglio4"
      Me.dtpFiglio4.Size = New System.Drawing.Size(105, 20)
      Me.dtpFiglio4.TabIndex = 13
      '
      'Label12
      '
      Me.Label12.AutoSize = True
      Me.Label12.Location = New System.Drawing.Point(92, 149)
      Me.Label12.Name = "Label12"
      Me.Label12.Size = New System.Drawing.Size(62, 13)
      Me.Label12.TabIndex = 32
      Me.Label12.Text = "Data nasc.:"
      '
      'txtFreq3
      '
      Me.txtFreq3.Location = New System.Drawing.Point(626, 107)
      Me.txtFreq3.Name = "txtFreq3"
      Me.txtFreq3.Size = New System.Drawing.Size(59, 20)
      Me.txtFreq3.TabIndex = 11
      '
      'Label7
      '
      Me.Label7.AutoSize = True
      Me.Label7.Location = New System.Drawing.Point(561, 111)
      Me.Label7.Name = "Label7"
      Me.Label7.Size = New System.Drawing.Size(59, 13)
      Me.Label7.TabIndex = 30
      Me.Label7.Text = "Anno freq.:"
      '
      'txtScuola3
      '
      Me.txtScuola3.Location = New System.Drawing.Point(350, 109)
      Me.txtScuola3.Name = "txtScuola3"
      Me.txtScuola3.Size = New System.Drawing.Size(205, 20)
      Me.txtScuola3.TabIndex = 10
      '
      'Label8
      '
      Me.Label8.AutoSize = True
      Me.Label8.Location = New System.Drawing.Point(301, 113)
      Me.Label8.Name = "Label8"
      Me.Label8.Size = New System.Drawing.Size(43, 13)
      Me.Label8.TabIndex = 28
      Me.Label8.Text = "Scuola:"
      '
      'chjFiglio3
      '
      Me.chjFiglio3.AutoSize = True
      Me.chjFiglio3.Location = New System.Drawing.Point(27, 112)
      Me.chjFiglio3.Name = "chjFiglio3"
      Me.chjFiglio3.Size = New System.Drawing.Size(50, 17)
      Me.chjFiglio3.TabIndex = 8
      Me.chjFiglio3.Text = "Figlio"
      Me.chjFiglio3.UseVisualStyleBackColor = True
      '
      'dtpFiglio3
      '
      Me.dtpFiglio3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.dtpFiglio3.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.dtpFiglio3.Location = New System.Drawing.Point(155, 109)
      Me.dtpFiglio3.Name = "dtpFiglio3"
      Me.dtpFiglio3.Size = New System.Drawing.Size(105, 20)
      Me.dtpFiglio3.TabIndex = 9
      '
      'Label9
      '
      Me.Label9.AutoSize = True
      Me.Label9.Location = New System.Drawing.Point(92, 114)
      Me.Label9.Name = "Label9"
      Me.Label9.Size = New System.Drawing.Size(62, 13)
      Me.Label9.TabIndex = 25
      Me.Label9.Text = "Data nasc.:"
      '
      'txtFreq2
      '
      Me.txtFreq2.Location = New System.Drawing.Point(626, 72)
      Me.txtFreq2.Name = "txtFreq2"
      Me.txtFreq2.Size = New System.Drawing.Size(59, 20)
      Me.txtFreq2.TabIndex = 7
      '
      'Label4
      '
      Me.Label4.AutoSize = True
      Me.Label4.Location = New System.Drawing.Point(561, 76)
      Me.Label4.Name = "Label4"
      Me.Label4.Size = New System.Drawing.Size(59, 13)
      Me.Label4.TabIndex = 23
      Me.Label4.Text = "Anno freq.:"
      '
      'txtScuola2
      '
      Me.txtScuola2.Location = New System.Drawing.Point(350, 74)
      Me.txtScuola2.Name = "txtScuola2"
      Me.txtScuola2.Size = New System.Drawing.Size(205, 20)
      Me.txtScuola2.TabIndex = 6
      '
      'Label5
      '
      Me.Label5.AutoSize = True
      Me.Label5.Location = New System.Drawing.Point(301, 78)
      Me.Label5.Name = "Label5"
      Me.Label5.Size = New System.Drawing.Size(43, 13)
      Me.Label5.TabIndex = 21
      Me.Label5.Text = "Scuola:"
      '
      'chjFiglio2
      '
      Me.chjFiglio2.AutoSize = True
      Me.chjFiglio2.Location = New System.Drawing.Point(27, 77)
      Me.chjFiglio2.Name = "chjFiglio2"
      Me.chjFiglio2.Size = New System.Drawing.Size(50, 17)
      Me.chjFiglio2.TabIndex = 4
      Me.chjFiglio2.Text = "Figlio"
      Me.chjFiglio2.UseVisualStyleBackColor = True
      '
      'dtpFiglio2
      '
      Me.dtpFiglio2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.dtpFiglio2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.dtpFiglio2.Location = New System.Drawing.Point(155, 74)
      Me.dtpFiglio2.Name = "dtpFiglio2"
      Me.dtpFiglio2.Size = New System.Drawing.Size(105, 20)
      Me.dtpFiglio2.TabIndex = 5
      '
      'Label6
      '
      Me.Label6.AutoSize = True
      Me.Label6.Location = New System.Drawing.Point(92, 79)
      Me.Label6.Name = "Label6"
      Me.Label6.Size = New System.Drawing.Size(62, 13)
      Me.Label6.TabIndex = 18
      Me.Label6.Text = "Data nasc.:"
      '
      'txtFreq1
      '
      Me.txtFreq1.Location = New System.Drawing.Point(626, 37)
      Me.txtFreq1.Name = "txtFreq1"
      Me.txtFreq1.Size = New System.Drawing.Size(59, 20)
      Me.txtFreq1.TabIndex = 3
      '
      'Label3
      '
      Me.Label3.AutoSize = True
      Me.Label3.Location = New System.Drawing.Point(561, 41)
      Me.Label3.Name = "Label3"
      Me.Label3.Size = New System.Drawing.Size(59, 13)
      Me.Label3.TabIndex = 16
      Me.Label3.Text = "Anno freq.:"
      '
      'txtScuola1
      '
      Me.txtScuola1.Location = New System.Drawing.Point(350, 39)
      Me.txtScuola1.Name = "txtScuola1"
      Me.txtScuola1.Size = New System.Drawing.Size(205, 20)
      Me.txtScuola1.TabIndex = 2
      '
      'Label1
      '
      Me.Label1.AutoSize = True
      Me.Label1.Location = New System.Drawing.Point(301, 43)
      Me.Label1.Name = "Label1"
      Me.Label1.Size = New System.Drawing.Size(43, 13)
      Me.Label1.TabIndex = 14
      Me.Label1.Text = "Scuola:"
      '
      'chjFiglio1
      '
      Me.chjFiglio1.AutoSize = True
      Me.chjFiglio1.Location = New System.Drawing.Point(27, 42)
      Me.chjFiglio1.Name = "chjFiglio1"
      Me.chjFiglio1.Size = New System.Drawing.Size(50, 17)
      Me.chjFiglio1.TabIndex = 0
      Me.chjFiglio1.Text = "Figlio"
      Me.chjFiglio1.UseVisualStyleBackColor = True
      '
      'dtpFiglio1
      '
      Me.dtpFiglio1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.dtpFiglio1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
      Me.dtpFiglio1.Location = New System.Drawing.Point(155, 39)
      Me.dtpFiglio1.Name = "dtpFiglio1"
      Me.dtpFiglio1.Size = New System.Drawing.Size(105, 20)
      Me.dtpFiglio1.TabIndex = 1
      '
      'Label2
      '
      Me.Label2.AutoSize = True
      Me.Label2.Location = New System.Drawing.Point(92, 44)
      Me.Label2.Name = "Label2"
      Me.Label2.Size = New System.Drawing.Size(62, 13)
      Me.Label2.TabIndex = 2
      Me.Label2.Text = "Data nasc.:"
      '
      'NiceGroupBox2
      '
      Me.NiceGroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                  Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
      Me.NiceGroupBox2.Controls.Add(Me.cboStatus)
      Me.NiceGroupBox2.Controls.Add(Me.Label21)
      Me.NiceGroupBox2.Controls.Add(Me.chkACarico)
      Me.NiceGroupBox2.Controls.Add(Me.chkCasa)
      Me.NiceGroupBox2.Location = New System.Drawing.Point(12, 56)
      Me.NiceGroupBox2.Name = "NiceGroupBox2"
      Me.NiceGroupBox2.Size = New System.Drawing.Size(720, 75)
      Me.NiceGroupBox2.TabIndex = 1
      Me.NiceGroupBox2.Title = "Dati fiscali"
      '
      'cmdOk
      '
      Me.cmdOk.Location = New System.Drawing.Point(565, 427)
      Me.cmdOk.Name = "cmdOk"
      Me.cmdOk.Size = New System.Drawing.Size(70, 27)
      Me.cmdOk.TabIndex = 3
      Me.cmdOk.Text = "Ok"
      Me.cmdOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.cmdOk.UseVisualStyleBackColor = True
      '
      'cmdAnnulla
      '
      Me.cmdAnnulla.Location = New System.Drawing.Point(641, 427)
      Me.cmdAnnulla.Name = "cmdAnnulla"
      Me.cmdAnnulla.Size = New System.Drawing.Size(69, 27)
      Me.cmdAnnulla.TabIndex = 4
      Me.cmdAnnulla.Text = "Annulla"
      Me.cmdAnnulla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
      Me.cmdAnnulla.UseVisualStyleBackColor = True
      '
      'Label13
      '
      Me.Label13.AutoSize = True
      Me.Label13.Location = New System.Drawing.Point(263, 27)
      Me.Label13.Name = "Label13"
      Me.Label13.Size = New System.Drawing.Size(71, 13)
      Me.Label13.TabIndex = 12
      Me.Label13.Text = "Compilato da:"
      '
      'IdReferenteTextBox1
      '
      Me.IdReferenteTextBox1.BackColor = System.Drawing.Color.Transparent
      Me.IdReferenteTextBox1.EnableSerchTextBox = True
      Me.IdReferenteTextBox1.Location = New System.Drawing.Point(337, 13)
      Me.IdReferenteTextBox1.Margin = New System.Windows.Forms.Padding(0)
      Me.IdReferenteTextBox1.Name = "IdReferenteTextBox1"
      Me.IdReferenteTextBox1.Size = New System.Drawing.Size(124, 40)
      Me.IdReferenteTextBox1.TabIndex = 11
      Me.IdReferenteTextBox1.TextValue = ""
      '
      'FrmSituazioneFamiliare
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.BackColor = System.Drawing.Color.WhiteSmoke
      Me.ClientSize = New System.Drawing.Size(747, 462)
      Me.Controls.Add(Me.Label13)
      Me.Controls.Add(Me.IdReferenteTextBox1)
      Me.Controls.Add(Me.cmdOk)
      Me.Controls.Add(Me.cmdAnnulla)
      Me.Controls.Add(Me.NiceGroupBox2)
      Me.Controls.Add(Me.NiceGroupBox1)
      Me.Controls.Add(Me.dtpIntervista)
      Me.Controls.Add(Me.Label20)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
      Me.Name = "FrmSituazioneFamiliare"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Situazione familiare"
      Me.NiceGroupBox1.ResumeLayout(False)
      Me.NiceGroupBox1.PerformLayout()
      Me.NiceGroupBox2.ResumeLayout(False)
      Me.NiceGroupBox2.PerformLayout()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents chkACarico As System.Windows.Forms.CheckBox
   Friend WithEvents cboStatus As System.Windows.Forms.ComboBox
   Friend WithEvents Label21 As System.Windows.Forms.Label
   Friend WithEvents chkCasa As System.Windows.Forms.CheckBox
   Friend WithEvents dtpIntervista As System.Windows.Forms.DateTimePicker
   Friend WithEvents Label20 As System.Windows.Forms.Label
   Friend WithEvents NiceGroupBox1 As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents NiceGroupBox2 As WIN.GUI.UTILITY.NiceGroupBox
   Friend WithEvents cmdOk As System.Windows.Forms.Button
   Friend WithEvents cmdAnnulla As System.Windows.Forms.Button
   Friend WithEvents txtFreq1 As System.Windows.Forms.TextBox
   Friend WithEvents Label3 As System.Windows.Forms.Label
   Friend WithEvents txtScuola1 As System.Windows.Forms.TextBox
   Friend WithEvents Label1 As System.Windows.Forms.Label
   Friend WithEvents chjFiglio1 As System.Windows.Forms.CheckBox
   Friend WithEvents dtpFiglio1 As System.Windows.Forms.DateTimePicker
   Friend WithEvents Label2 As System.Windows.Forms.Label
   Friend WithEvents txtFreq4 As System.Windows.Forms.TextBox
   Friend WithEvents Label10 As System.Windows.Forms.Label
   Friend WithEvents txtScuola4 As System.Windows.Forms.TextBox
   Friend WithEvents Label11 As System.Windows.Forms.Label
   Friend WithEvents chjFiglio4 As System.Windows.Forms.CheckBox
   Friend WithEvents dtpFiglio4 As System.Windows.Forms.DateTimePicker
   Friend WithEvents Label12 As System.Windows.Forms.Label
   Friend WithEvents txtFreq3 As System.Windows.Forms.TextBox
   Friend WithEvents Label7 As System.Windows.Forms.Label
   Friend WithEvents txtScuola3 As System.Windows.Forms.TextBox
   Friend WithEvents Label8 As System.Windows.Forms.Label
   Friend WithEvents chjFiglio3 As System.Windows.Forms.CheckBox
   Friend WithEvents dtpFiglio3 As System.Windows.Forms.DateTimePicker
   Friend WithEvents Label9 As System.Windows.Forms.Label
   Friend WithEvents txtFreq2 As System.Windows.Forms.TextBox
   Friend WithEvents Label4 As System.Windows.Forms.Label
   Friend WithEvents txtScuola2 As System.Windows.Forms.TextBox
   Friend WithEvents Label5 As System.Windows.Forms.Label
   Friend WithEvents chjFiglio2 As System.Windows.Forms.CheckBox
   Friend WithEvents dtpFiglio2 As System.Windows.Forms.DateTimePicker
   Friend WithEvents Label6 As System.Windows.Forms.Label
   Friend WithEvents IdReferenteTextBox1 As WIN.GUI.APPLICATION.PRESENTATION.IdReferenteTextBox
   Friend WithEvents Label13 As System.Windows.Forms.Label
   Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
   Friend WithEvents Label14 As System.Windows.Forms.Label
   Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
   Friend WithEvents Label15 As System.Windows.Forms.Label
   Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
   Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
   Friend WithEvents Label16 As System.Windows.Forms.Label
   Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
   Friend WithEvents Label17 As System.Windows.Forms.Label
   Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
   Friend WithEvents Label18 As System.Windows.Forms.Label
   Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
   Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
   Friend WithEvents Label19 As System.Windows.Forms.Label
End Class
