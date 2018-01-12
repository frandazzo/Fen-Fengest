Public Class FrmCacolatoreCF


    Private m_CodiceFiscale As String = ""


    Public ReadOnly Property CodiceFiscale() As String
        Get
            Return m_CodiceFiscale
        End Get
    End Property

    Private m_Data As String = ""


    Public ReadOnly Property Data() As DateTime
        Get
            Return m_Data
        End Get
    End Property

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        m_CodiceFiscale = txtCF1.TextValue
        m_Data = dtpData1.DateTimePicker1.Value
        Me.Close()
    End Sub


    Public Sub New()

        ' Chiamata richiesta da Progettazione Windows Form.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub

    Public Sub New(ByVal Cognome As String, ByVal Nome As String, ByVal Data As DateTime)

        ' Chiamata richiesta da Progettazione Windows Form.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

        txtCognome1.TextValue = Cognome
        txtNome1.TextValue = Nome
        dtpData1.DataValue = Data.Date


    End Sub



   Private Sub LoadDefaultData()
        InterfaceMediator.LoadUsabilityCombo(Me.cboNazionalita1, GeoLocationFacade.Instance.GetListaNazioni, False)
        Me.cboNazionalita1.TextValue = My.Settings.NazioneDefault



        LoadComboComuni(GeoLocationFacade.Instance.GetListaComuniPerProvincia(My.Settings.ComuneDefault))
        LoadComboProvincie(GeoLocationFacade.Instance.GetListaProvincie)
        Me.cboProvincia1.TextValue = My.Settings.ProvinciaDefault
        Me.cboComune1.TextValue = My.Settings.ComuneDefault

        cboSesso1.ComboBox1.Items.Add("MASCHIO")
        cboSesso1.ComboBox1.Items.Add("FEMMINA")
        Me.cboSesso1.ComboBox1.SelectedIndex = 0

        Me.dtpData1.DateTimePicker1.Value = New DateTime(1900, 1, 1)

    End Sub


    Private Sub LoadComboComuni(ByVal Lista As ArrayList)

        cboComune1.ComboBox1.Items.Clear()
        For Each elem As String In Lista
            cboComune1.ComboBox1.Items.Add(elem)
        Next
        cboComune1.ComboBox1.Sorted = True
        cboComune1.ComboBox1.Items.Add("")

    End Sub
    Private Sub LoadComboProvincie(ByVal Lista As ArrayList)

        cboProvincia1.ComboBox1.Items.Clear()
        For Each elem As String In Lista
            cboProvincia1.ComboBox1.Items.Add(elem)
        Next
        cboProvincia1.ComboBox1.Sorted = True
        cboProvincia1.ComboBox1.Items.Add("")
    End Sub

    Private Sub cboNazionalita1_SelectedIndexChange(ByVal e As System.EventArgs) Handles cboNazionalita1.SelectedIndexChange
        If Me.cboNazionalita1.ComboBox1.Text <> "ITALIA" Then
            Me.cboComune1.OverridedEnable = False
            Me.cboProvincia1.OverridedEnable = False
        Else
            Me.cboComune1.OverridedEnable = True
            Me.cboProvincia1.OverridedEnable = True
        End If
    End Sub



    Private Sub cboProvincia1_SelectedIndexChange(ByVal e As System.EventArgs) Handles cboProvincia1.SelectedIndexChange
        InterfaceMediator.LoadUsabilityCombo(Me.cboComune1, GeoLocationFacade.Instance.GetListaComuniPerProvincia(Me.cboProvincia1.ComboBox1.Text), True)
        cboComune1.ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub SpCf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpCf.Click
        Try
            Me.txtCF1.TextValue = GeoLocationFacade.Instance.CalcolaCodiceFiscale(txtNome1.TextValue, txtCognome1.TextValue, cboSesso1.ComboBox1.Text, Me.dtpData1.DateTimePicker1.Value, cboComune1.ComboBox1.Text, Me.cboNazionalita1.ComboBox1.Text)
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim datoFiscale As DatiFiscali = GeoLocationFacade.Instance.CalcolaDatiFiscali(txtCF1.TextValue)
            Dim frm As New FrmDatiFiscali(datoFiscale)
            If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                cboNazionalita1.TextValue = frm.DatiFiscali.Nazione.Descrizione
                cboProvincia1.TextValue = frm.DatiFiscali.Provincia.Descrizione
                cboComune1.TextValue = frm.DatiFiscali.Comune.Descrizione
                cboSesso1.TextValue = frm.txtSesso.Text
                If frm.DatiFiscali.DataNascita <> DateTime.MinValue Then
                    dtpData1.DataValue = frm.DatiFiscali.DataNascita
                End If
            End If

            frm.Dispose()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

   Private Sub FrmCacolatoreCF_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
      LoadDefaultData()
   End Sub
End Class