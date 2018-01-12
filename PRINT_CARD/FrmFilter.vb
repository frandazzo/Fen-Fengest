Public Class FrmFilter

    Public Sub New(ByVal nome As String, ByVal cognome As String, ByVal azienda As String, ByVal comune As String, ByVal addressOK As Boolean, ByVal AziendaNuulla As Boolean)

        ' Chiamata richiesta da Progettazione Windows Form.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        m_nome = nome
        m_azienda = azienda
        m_cognome = cognome
        m_comune = comune
        m_addressOk = addressOK
        m_aziendaNulla = AziendaNuulla
        'carico i vecchi filtri
        txtNome.Text = m_nome
        txtAzienda.Text = m_azienda
        txtCognome.Text = m_cognome
        txtComune.Text = m_comune
        chkAddressOK.Checked = m_addressOk
        chkAzNull.Checked = m_aziendaNulla
    End Sub



    Private m_nome As String = ""
    Private m_cognome As String = ""
    Private m_azienda As String = ""
    Private m_comune As String = ""
    Private m_addressOk As Boolean = False

    Private m_aziendaNulla As Boolean = False




    Public ReadOnly Property Cognome() As String
        Get
            Return m_cognome
        End Get
    End Property


    Public ReadOnly Property Azienda() As String
        Get
            Return m_azienda
        End Get
    End Property

    Public ReadOnly Property AziendaNulla() As Boolean
        Get
            Return m_aziendaNulla
        End Get
    End Property

    Public ReadOnly Property AddressOk() As Boolean
        Get
            Return m_addressOk
        End Get
    End Property

    Public ReadOnly Property Comune() As String
        Get
            Return m_comune
        End Get
    End Property

    Public ReadOnly Property Nome() As String
        Get
            Return m_nome
        End Get
    End Property

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        m_nome = txtNome.Text
        m_azienda = txtAzienda.Text
        m_cognome = txtCognome.Text
        m_comune = txtComune.Text
        m_addressOk = chkAddressOK.Checked
        m_aziendaNulla = chkAzNull.Checked

        initial_index = numDa.Value
        final_index = NumA.Value





        If initial_index <> 0 And final_index <> 0 Then
            If initial_index > final_index Then
                Dim t As Int32 = final_index
                final_index = initial_index
                initial_index = t
            End If
        End If

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub cmdAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnnulla.Click
        m_nome = txtNome.Text
        m_azienda = txtAzienda.Text
        m_cognome = txtCognome.Text
        m_comune = txtComune.Text
        m_addressOk = chkAddressOK.Checked
        m_aziendaNulla = chkAzNull.Checked

        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub chkAzNull_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAzNull.CheckedChanged
        If chkAzNull.Checked Then
            txtAzienda.Enabled = False
            txtAzienda.Text = ""
        Else
            txtAzienda.Enabled = True
        End If
    End Sub
End Class