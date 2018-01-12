Imports WIN.GUI.UTILITY

Public Class CustomBar
    Public Event DoAnnullaClick(ByVal Sender As Object, ByVal e As EventArgs)
    Public Event DoSaveClick(ByVal Sender As Object, ByVal e As EventArgs)
    Public Event DoNewClick(ByVal Sender As Object, ByVal e As EventArgs)
    Public Event DoInformationClick(ByVal Sender As Object, ByVal e As EventArgs)
    Public Event DoEliminaClick(ByVal Sender As Object, ByVal e As EventArgs)
    Public Event DoStampaClick(ByVal Sender As Object, ByVal e As EventArgs)
    Private WithEvents m_TargetControl As AbstractBrowserControl = Nothing
    Protected DefaultState As AbstractControlState = StView.Instance
    Public Sub New()

        ' Chiamata richiesta da Progettazione Windows Form.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        Me.SetInterfaceMode(DefaultState)
    End Sub
    Public Sub SetTargetControl(ByVal TargetControl As AbstractBrowserControl)
        If TargetControl Is Nothing Then Throw New Exception("Target control nullo per la barra dei comandi")
        m_TargetControl = TargetControl
    End Sub

    Public Enum ActionType
        Nuovo
        Annulla
        Salva
        Elimina
        Stampa
        Informazioni
    End Enum

    Private Sub CmdAnnulla_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CmdAnnulla.DoClik
        RaiseEvent DoAnnullaClick(Sender, e)
    End Sub

    Private Sub CmdDelete_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CmdDelete.DoClik
        RaiseEvent DoEliminaClick(Sender, e)
    End Sub

    Private Sub CmdInformation_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CmdInformation.DoClik
        RaiseEvent DoInformationClick(Sender, e)
    End Sub


    Private Sub CmdNew_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CmdNew.DoClik
        RaiseEvent DoNewClick(Sender, e)
    End Sub


    Private Sub CmdSave_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CmdSave.DoClik
        RaiseEvent DoSaveClick(Sender, e)
    End Sub


    Private Sub CmdStampa_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CmdStampa.DoClik
        RaiseEvent DoStampaClick(Sender, e)
    End Sub

    Public Sub SetStatus(ByVal Disabled As Boolean, ByVal Action As ActionType)
        Select Case Action
            Case ActionType.Annulla
                Me.CmdAnnulla.Disabled = Disabled
            Case ActionType.Elimina
                Me.CmdDelete.Disabled = Disabled
            Case ActionType.Informazioni
                Me.CmdInformation.Disabled = Disabled
            Case ActionType.Nuovo
                Me.CmdNew.Disabled = Disabled
            Case ActionType.Salva
                Me.CmdSave.Disabled = Disabled
            Case ActionType.Stampa
                Me.CmdStampa.Disabled = Disabled
        End Select
    End Sub
    Public Sub SetInterfaceMode(ByVal Mode As AbstractControlState)
        Select Case Mode.StateName
            Case "Visualizzazione"
                SetStatus(False, ActionType.Nuovo)
                SetStatus(False, ActionType.Informazioni)
                SetStatus(False, ActionType.Stampa)
                SetStatus(False, ActionType.Elimina)
                SetStatus(True, ActionType.Salva)
                SetStatus(True, ActionType.Annulla)
            Case "Aggiornamento"
                SetStatus(True, ActionType.Nuovo)
                SetStatus(True, ActionType.Informazioni)
                SetStatus(True, ActionType.Stampa)
                SetStatus(True, ActionType.Elimina)
                SetStatus(False, ActionType.Salva)
                SetStatus(False, ActionType.Annulla)
            Case "Creazione"
                SetStatus(True, ActionType.Nuovo)
                SetStatus(True, ActionType.Informazioni)
                SetStatus(True, ActionType.Stampa)
                SetStatus(True, ActionType.Elimina)
                SetStatus(False, ActionType.Salva)
                SetStatus(False, ActionType.Annulla)
            Case Else
                Throw New Exception("Impossibile impostare la modalità per la barra dei comandi. Tipo stato sconosciuto")
        End Select

    End Sub
    Private Sub TargetControl_StateChanged(ByVal State As UTILITY.AbstractControlState) Handles m_TargetControl.StateChanged
        SetInterfaceMode(State)
    End Sub

    Private Sub FlowLayoutPanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles FlowLayoutPanel1.Paint
        e.Graphics.DrawLine(Pens.LightGray, 1, 10, 1, 30)
        e.Graphics.DrawLine(Pens.White, 2, 10, 2, 30)
        e.Graphics.DrawLine(Pens.LightGray, Me.FlowLayoutPanel1.Width - 2, 10, Me.FlowLayoutPanel1.Width - 2, 30)
        e.Graphics.DrawLine(Pens.White, Me.FlowLayoutPanel1.Width - 1, 10, Me.FlowLayoutPanel1.Width - 1, 30)
    End Sub
End Class
