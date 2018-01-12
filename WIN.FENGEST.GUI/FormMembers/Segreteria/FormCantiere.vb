Public Class FormCantiere
    Private m_idAz As Int32
    Private controller As New ControllerCantiere
    Private creation As Boolean = True
    Private m_cantiere As Cantiere
    Private m_NomeAzienda As String
    Public Sub New(cantiere As Cantiere)

        ' Chiamata richiesta dalla finestra di progettazione.
        InitializeComponent()

        LoadComboProvincia()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        m_cantiere = cantiere
        txtDescr.Text = m_cantiere.Descrizione
        txtnot.Text = m_cantiere.Notes
        dtpData.DateTime = m_cantiere.DataFine


        txtZona.Text = m_cantiere.Zona
        cboProv.Text = m_cantiere.Provincia
        cboCom.Text = m_cantiere.Comune
        txtImp.Value = m_cantiere.Importo

        creation = False
    End Sub

    Public Sub New(idAzienda As Int32, nomeAzienda As String)

        ' Chiamata richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        m_NomeAzienda = nomeAzienda
        m_idAz = idAzienda
        creation = True
        LoadComboProvincia()
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub cmdOk_Click(sender As Object, e As EventArgs) Handles cmdOk.Click

        If (String.IsNullOrEmpty(txtDescr.Text)) Then

            MessageBox.Show("Impostare una descrizione per il cantiere", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return

        End If

        If (dtpData.EditValue Is Nothing) Then
            MessageBox.Show("Impostare una data fine per il cantiere", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        'qui salvo
        If (creation = True) Then
            m_cantiere = New Cantiere
            m_cantiere.IdAzienda = m_idAz
            m_cantiere.Descrizione = txtDescr.Text
            m_cantiere.Notes = txtnot.Text
            m_cantiere.DataFine = dtpData.DateTime.Date
            m_cantiere.NomeAzienda = m_NomeAzienda
            m_cantiere.Zona = txtZona.Text
            m_cantiere.Provincia = cboProv.Text
            m_cantiere.Comune = cboCom.Text
            m_cantiere.Importo = txtImp.Value
        Else
            m_cantiere.Descrizione = txtDescr.Text
            m_cantiere.Notes = txtnot.Text
            m_cantiere.DataFine = dtpData.DateTime.Date
            m_cantiere.Zona = txtZona.Text
            m_cantiere.Provincia = cboProv.Text
            m_cantiere.Comune = cboCom.Text
            m_cantiere.Importo = txtImp.Value

        End If
        controller.SaveOrUpdateCantiere(m_cantiere)

        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub LoadComboProvincia()

        Dim provs As IList = GeoLocationFacade.Instance.GetListaProvincie

        cboProv.Properties.Items.Clear()
        For Each elem As String In provs
            cboProv.Properties.Items.Add(elem)
        Next

        cboProv.Properties.Items.Add("")
        cboProv.Properties.Sorted = True
        cboProv.SelectedIndex = 0

    End Sub

    Private Sub cboProv_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProv.SelectedIndexChanged
        Dim comuni As IList = GeoLocationFacade.Instance.GetListaComuniPerProvincia(cboProv.Text)


        cboCom.Properties.Items.Clear()
        For Each elem As String In comuni
            cboCom.Properties.Items.Add(elem)
        Next

        cboCom.Properties.Items.Add("")
        cboCom.Properties.Sorted = True
        cboCom.SelectedIndex = 0

    End Sub
End Class