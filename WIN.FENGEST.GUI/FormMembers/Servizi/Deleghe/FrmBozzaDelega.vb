Imports WIN.APPLICATION.UTENTI
Imports WIN.DOMAIN.FED_SERVICES

Public Class FrmBozzaDelega
    Public Enum BozzaDelegaAction
        Insert
        Update
    End Enum

    Public currentBozzaDelega As BozzaDelega

    Private Sub cmdAnnulla_Click(sender As System.Object, e As System.EventArgs) Handles cmdAnnulla.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub





    Friend m_controller As ControllerBozzaDelega

    Private m_Action As BozzaDelegaAction
    Private m_Bozza As BozzaDelega


    Public Sub New(ByVal action As BozzaDelegaAction, Bozza As BozzaDelega)
        InitializeComponent()
        cboTipo.SelectedIndex = 0
        Initialize(action, Bozza)

        If action = BozzaDelegaAction.Update Then
            chkDuplica.Visible = False
        End If
    End Sub

    Private Sub Initialize(ByVal action As BozzaDelegaAction, Bozza As BozzaDelega)


        m_Bozza = Bozza
        m_Action = action

        m_controller = New ControllerBozzaDelega
        If m_Action = BozzaDelegaAction.Update Then
            m_controller.SetCurrent(Bozza)
        End If



        LoadDocumento()
    End Sub



    Private Sub LoadDocumento()



        If m_Action = BozzaDelegaAction.Insert Then
            CreateDocument()
            InitializeForm()

            Return
        End If

        LoadDocumentProperties()


    End Sub




    Private Sub CreateDocument()

        m_controller.CreateNew()
    End Sub
    Private Sub InitializeForm()
        dtpData.Value = DateTime.Now

    End Sub


    Private Sub LoadDocumentProperties()
        dtpData.Value = m_controller.DataRegistrazione

        cboTipo.Text = m_controller.Ente

        If m_controller.IdReferente <> "-1" Then
            IdReferenteTextBox1.TextValue = m_controller.IdReferente
            lblDescrizioneReferente.Text = m_controller.DescrizioneReferente
        Else
            IdReferenteTextBox1.TextValue = ""
            lblDescrizioneReferente.Text = ""
        End If

        If m_controller.IdUtente <> -1 Then
            IdUtenteTextBox1.TextValue = m_controller.IdUtente
            lblUtente.Text = m_controller.DescrizioneUtente
        Else
            IdUtenteTextBox1.TextValue = ""
            lblUtente.Text = ""
        End If

    End Sub


    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        Try
            SetProperties()
            m_controller.Save()


            If m_Action = BozzaDelegaAction.Insert Then
                If chkDuplica.Checked Then
                    m_controller.CreateNew()
                    m_controller.DataRegistrazione = dtpData.Value

                    m_controller.SetUtente(IdUtenteTextBox1.TextValue)
                    m_controller.SetReferente(IdReferenteTextBox1.TextValue)

                    Dim ente As String
                    If cboTipo.Text = "CASSA EDILE" Then
                        ente = "EDILCASSA"
                    Else
                        ente = "CASSA EDILE"
                    End If

                    m_controller.Ente = ente
                    m_controller.Save()
                End If
            End If

            currentBozzaDelega = m_controller.Current
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try

    End Sub

    Private Sub SetProperties()
        m_controller.DataRegistrazione = dtpData.Value

        m_controller.SetUtente(IdUtenteTextBox1.TextValue)
        m_controller.SetReferente(IdReferenteTextBox1.TextValue)
        m_controller.Ente = cboTipo.Text
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





    Private Sub IdReferenteTextBox1_Leave(sender As System.Object, e As System.EventArgs) Handles IdReferenteTextBox1.Leave
        DelegheMediator.GetSimpleDescription(New WIN.APPLICATION.FINANCIAL_ARTIFACTS.ControllerReferenti, "CompleteName", lblDescrizioneReferente, Me.IdReferenteTextBox1.TextValue)
    End Sub

    Private Sub IdUtenteTextBox1_Leave(sender As System.Object, e As System.EventArgs) Handles IdUtenteTextBox1.Leave
        InterfaceMediator.GetSimpleDescription(New ControllerUtenti, "CompleteName", lblUtente, Me.IdUtenteTextBox1.TextValue)
    End Sub
End Class