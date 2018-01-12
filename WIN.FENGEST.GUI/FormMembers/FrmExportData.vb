Imports WIN.FENGEST_NAZIONALE.INTEGRATION_ENTITIES
Imports WIN.SECURITY.Core
Imports WIN.SECURITY
Imports System.Windows.Forms

Public Class FrmExportData


    Private m_Iscritti As IList = New ArrayList
    Public IscrittidaEsportare As ExportTrace

    Private WithEvents exporter As IscrittiExporter

    Private frmElab As New FrmElaborazioneInCorso

    Public Sub New(ByVal settore As String, ByVal ente As String, ByVal iscritti As IList)

        ' Chiamata richiesta da Progettazione Windows Form.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        m_Iscritti = iscritti
        cboSettore.Text = settore
        If ente <> "" Then
            cboEnte.Text = ente
        End If
        numAnno.Value = DateTime.Now.Year

        cboPeriodo.SelectedIndex = 0

        LoadProvince()

        LoadResponsabile()

        LoadCredential()
    End Sub
    Private Sub LoadCredential()
        'recupero le credenziali
        Dim c As Credenziali = DatabaseNazionaleCredentialHandler.RetrieveCredential()


        txtUser.Text = c.UserName
        txtPassword.Text = c.Password

        cboProvincia.Text = c.Provincia

    End Sub

    Private Sub LoadResponsabile()

        Dim nome As String = ""
        Dim cognome As String = ""
        Dim resp As String = cognome + " " + nome

        Dim utente As WIN.BASEREUSE.User = DirectCast(SecurityManager.Instance.CurrentUser, WIN.BASEREUSE.User)
        If Not String.IsNullOrEmpty(utente.Mail) Then
            txtMail.Text = utente.Mail
        End If
        If Not String.IsNullOrEmpty(utente.Name) Then
            nome = utente.Name
        End If
        If Not String.IsNullOrEmpty(utente.SurName) Then
            cognome = utente.SurName
        End If

        If resp.Trim = "" Then
            txtResp.Text = utente.Username
        Else
            txtResp.Text = resp
        End If




    End Sub

    Private Sub LoadProvince()

        Dim prov As IList = GeoLocationFacade.Instance.GetListaProvincie

        cboProvincia.Items.Clear()
        For Each elem As String In prov
            cboProvincia.Items.Add(elem)
        Next
        cboProvincia.Sorted = True

    End Sub

    Private Sub cboSettore_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSettore.SelectedIndexChanged
        If cboSettore.Text = "EDILE" Then
            cboEnte.Enabled = True
            cboPeriodo.Enabled = True
        Else
            cboEnte.Enabled = False
            cboPeriodo.Enabled = False
        End If
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub cmdExp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExp.Click
        Try
            If txtResp.Text.Trim = "Admin" Then
                If System.Windows.Forms.MessageBox.Show("Il responsabile specificato è poco indicativo. Procedere comunque?", "Domanda", Windows.Forms.MessageBoxButtons.YesNo, Windows.Forms.MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    Return
                End If
            End If


            'mi assicuro di valorizzare correttamente ll'ente per i settori non edili
            Dim ente As String
            If cboSettore.Text <> "EDILE" Then
                ente = ""
            Else
                ente = cboEnte.Text
            End If

            'recupero le credenziali
            Dim c As Credenziali = DatabaseNazionaleCredentialHandler.RetrieveCredential()



            'valido gli input
            Dim h As New ExportHeader(txtResp.Text, cboSettore.Text, ente, txtMail.Text, Convert.ToInt32(numAnno.Value), Convert.ToInt32(cboPeriodo.Text), txtUser.Text, txtPassword.Text, cboProvincia.Text)

            'eseguo la vreifica
            h.CheckValidity()


            exporter = New IscrittiExporter(m_Iscritti, h)



            frmElab = New FrmElaborazioneInCorso
            frmElab.EnableCancel(True)
            frmElab.TopLevel = True

            frmElab.Show()

            IscrittidaEsportare = exporter.CreateTrace(chkDel.Checked, CheckBox1.Checked, chkRic.Checked, chkVert.Checked, chkPrest.Checked)

            frmElab.Dispose()


            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub exporter_BeginExport() Handles exporter.BeginExport
        frmElab.SetPercentageValue(0)
        frmElab.SetActivity("Inizio creazione esportazione!")
        System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub exporter_EndExport() Handles exporter.EndExport
        frmElab.SetPercentageValue(100)
        frmElab.SetActivity("Termine creazione esportazione!")
        System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub exporter_Exporting(ByVal percentage As Integer, ByVal cancel As Boolean) Handles exporter.Exporting
        If (frmElab.Annulla) Then

            If (MessageBox.Show("Sicuro di voler la creazione dell'esportazione dei dati?", "Messaggio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                MessageBox.Show("Operazione annullata dall'utente", "Messaggio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cancel = True
            Else
                frmElab.Annulla = False
            End If

        End If





        frmElab.SetPercentageValue(percentage)
        frmElab.SetActivity("Percentuale di creazione esportazione: " + percentage.ToString)
        System.Windows.Forms.Application.DoEvents()
    End Sub
End Class