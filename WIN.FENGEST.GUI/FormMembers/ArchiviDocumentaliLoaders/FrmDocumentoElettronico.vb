Imports WIN.DOMAIN.FEDERATIONARTIFACTS

Public Class FrmDocumentoElettronico
    Public Enum DocumentoAction
        Insert
        Update
        ViewAttivita
    End Enum

    Private m_notFireEvent As Boolean
    Private m_controller As ControllerArchivioDocumentale

    Private m_Action As DocumentoAction

    Public Sub New(ByVal allegato As String, ByVal controller As ControllerArchivioDocumentale, ByVal action As DocumentoAction)
        InitializeComponent()
        Initialize(controller, action)
        lblAllegato.Text = allegato
        m_notFireEvent = True
    End Sub

    Public Sub New(ByVal controller As ControllerArchivioDocumentale, ByVal action As DocumentoAction)
        InitializeComponent()
        Initialize(controller, action)
    End Sub

    Private Sub Initialize(ByVal controller As ControllerArchivioDocumentale, ByVal action As DocumentoAction)


        m_controller = controller
        m_Action = action


        LoadPrerequisites()

        LoadDocumento()
    End Sub

    Private Sub LoadPrerequisites()
        Dim lista As IList = m_controller.GetListaTipiDocumentazione
        cboTipo.DataSource = lista
        If lista.Count > 0 Then
            cboTipo.SelectedIndex = 0
        End If

    End Sub

    Private Sub LoadDocumento()
        If m_Action = DocumentoAction.ViewAttivita Then
            InitializeReadOnlyForm()
            LoadActivityDocumentProperties()
            Return
        End If


        If m_Action = DocumentoAction.Insert Then
            CreateDocument()
            InitializeForm()

            Return
        End If

        LoadDocumentProperties()


    End Sub


    Private Sub InitializeReadOnlyForm()
        dtpData.Enabled = False
        lblAllegato.Enabled = False
        txtNote.Enabled = False
        cboTipo.Enabled = False
        cmdOk.Enabled = False
        IdReferenteTextBox1.Enabled = False
        cmdAnnulla.Text = "Chiudi"
    End Sub

    Private Sub CreateDocument()
        Dim m_Documento As ElectronicDocument = ElectronicDocumentFactory.CreateElectronicDocument(m_controller.Target)
        m_controller.AddElectronicDocument(m_Documento)
    End Sub
    Private Sub InitializeForm()
        dtpData.Value = DateTime.Now
        lblAllegato.Text = "Nessun allegato"
    End Sub

    Private Sub LoadActivityDocumentProperties()
        dtpData.Value = m_controller.CurrentDocumentoAttivita.Data
        lblAllegato.Text = m_controller.CurrentDocumentoAttivita.FullFileName
        cboTipo.SelectedItem = m_controller.CurrentDocumentoAttivita.TipoDocumentazione
        txtNote.Text = m_controller.CurrentDocumentoAttivita.Notes
    End Sub

    Private Sub LoadDocumentProperties()
        dtpData.Value = m_controller.Data
        lblAllegato.Text = m_controller.FileName
        cboTipo.SelectedItem = m_controller.TipoDocumentazione
        txtNote.Text = m_controller.Note
        If m_controller.Referente IsNot Nothing Then
            IdReferenteTextBox1.TextValue = m_controller.Referente.Id
            lblDescrizioneReferente.Text = m_controller.Referente.CompleteName
        End If
    End Sub


    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        Try
            SetProperties()
            ValidateDocument()

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try

    End Sub

    Private Sub SetProperties()
        m_controller.Data = dtpData.Value
        m_controller.FileName = lblAllegato.Text
        m_controller.TipoDocumentazione = cboTipo.SelectedItem
        m_controller.SetReferente(IdReferenteTextBox1.TextValue)
        m_controller.Note = txtNote.Text
    End Sub

    Private Sub ValidateDocument()
        If Not m_controller.Current.IsValid Then
            Dim sb As New System.Text.StringBuilder
            For Each elem As String In m_controller.Current.ValidationErrors
                sb.Append(elem)
            Next
            Throw New Exception(sb.ToString)
        End If
    End Sub

    Private Sub cmdAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnnulla.Click


        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub lblAllegato_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lblAllegato.LinkClicked
        If m_notFireEvent Then
            Return
        End If
        Try
            Dim frm As New FrmAllegaFile()
            frm.Destination = m_controller.DirectoryPreferenziale
            Dim dialog As System.Windows.Forms.DialogResult = frm.ShowDialog

            If dialog = Windows.Forms.DialogResult.OK Then
                lblAllegato.Text = frm.FileName
            End If
            frm.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Errore")
        End Try
    End Sub

    Private Sub FrmDocumentoElettronico_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Me.DialogResult <> Windows.Forms.DialogResult.OK Then
            If m_Action = DocumentoAction.Insert Then
                m_controller.RemoveDocumento(m_controller.Current, False)
            End If
        End If

    End Sub

    Private Sub IdReferenteTextBox1_Leave(sender As System.Object, e As System.EventArgs) Handles IdReferenteTextBox1.Leave
        DelegheMediator.GetSimpleDescription(New WIN.APPLICATION.FINANCIAL_ARTIFACTS.ControllerReferenti, "CompleteName", lblDescrizioneReferente, Me.IdReferenteTextBox1.TextValue)
    End Sub
End Class