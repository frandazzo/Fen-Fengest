Imports System.Windows.Forms
Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY
Imports WIN.SECURITY.Exceptions

<SecureContext()> _
Public Class ControlPrestazioni
   Private controller As New WIN.APPLICATION.ADMINISTRATION.ControllerPrestazioni
   Private controllerTP As New WIN.APPLICATION.ADMINISTRATION.ControllerTipoPrestazione


   Private m_IdUtente As Int32 = -1
   Private m_automaticCreation As Boolean = False

   Private Sub CustomBar1_DoInformationClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoInformationClick
      MsgBox(controller.CurrentObjectJournalingData, MsgBoxStyle.Information, "Informazione")
   End Sub

#Region "Metodi di inizializzazione e  nptifica di stato"
   ''' <summary>
   ''' Costruttore utilizzato dal comando di creazione di un nuovo contratto
   ''' </summary>
   ''' <remarks></remarks>
   Public Sub New()
      InitializeComponent()

      DoLoad()

   End Sub



    Public Overrides Sub StartChangeOperation()
        Try
            MyBase.StartChangeOperation()
        Catch ex As AccessDeniedException
            MsgBox("Impossibile aggiornare l'oggetto. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    <Secure(Area:="Prestazioni", Alias:="Creazione", Macroarea:="Servizi")> _
    Protected Overrides Sub Nested_CheckSecurityForCreation()
        SecurityManager.Instance.Check()
    End Sub

    <Secure(Area:="Prestazioni", Alias:="Aggiornamento", Macroarea:="Servizi")> _
    Protected Overrides Sub Nested_CheckSecurityForChanging()
        SecurityManager.Instance.Check()
    End Sub

    <Secure(Area:="Prestazioni", Alias:="Cancellazione", Macroarea:="Servizi")> _
      Protected Overrides Sub Nested_CheckSecurityForDeletion()
        SecurityManager.Instance.Check()
    End Sub



    Public Sub New(ByVal IdPrestazione As Int32) ', ByVal IdUtente As Int32)
        InitializeComponent()

        Me.m_IdShowedObject = IdPrestazione

        DoLoad()
    End Sub


    Public Sub New(ByVal IdUtente As Int32, ByVal dummyField As Boolean)
        InitializeComponent()
        Me.m_IdUtente = IdUtente

        m_automaticCreation = True
        DoLoad()
    End Sub



    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "" & MyBase.State.StateName & " prestazione"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "" & MyBase.State.StateName & " prestazione "
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  prestazione")
        SelectToolStripImage()
    End Sub
    Protected Overrides Sub Nested_PostLoadingActions()
        Dim logo As String = "" & MyBase.State.StateName & "  prestazione"
        MasterControl.Instance.ParentForm.Text = logo & " " & UCase(controller.DescrizioneTipoPrestazione)
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo & " " & UCase(controller.DescrizioneTipoPrestazione)
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  -   prestazione  " & UCase(controller.DescrizioneTipoPrestazione)) & "  -  " & UCase(controller.DescrizioneUtente)

    End Sub
    Protected Overrides Sub Nested_PostchangeActions()
        Try
            Dim logo As String = "" & MyBase.State.StateName & "  prestazione"
            MasterControl.Instance.ParentForm.Text = logo & " " & UCase(controller.DescrizioneTipoPrestazione)
            MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo & " " & UCase(controller.DescrizioneTipoPrestazione)
            Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  -   prestazione   " & UCase(controller.DescrizioneTipoPrestazione))
        Catch ex As Exception
            Nested_NotifyParent()
        End Try

    End Sub
#End Region



#Region "Metodi per Load iniziale"

    Public Overrides Sub DoSearch()

        Me.SpAddFile.Visible = False
        Me.SpDel.Visible = False
        Me.SpDelRef.Visible = False
        Me.SpView.Visible = False

        MainGroup.Visible = False
        Me.lblIdPrest.Visible = False
        Me.txtIdPrest.Visible = False

        CustomBar1.Visible = False
        lblId.Visible = True
        Me.IdUtenteTextBox2.Visible = True
        CmdVis.Visible = True
        MasterControl.Instance.ParentForm.Text = "Ricerca prestazioni per utente"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Ricerca prestazioni per utente "
        Me.lblCurrentFunction.Text = UCase("Ricerca   prestazioni   per   utente")
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.SearchPaint
        refBox.Visible = False
        GroupBox1.Visible = False

    End Sub

    Public Overrides Sub DoLoad()
        Try
            If Me.m_IdShowedObject <> -1 Then
                MyBase.m_IsLoading = True
                Nested_PrepareLoading()
                Nested_ClearWindowEditors()
                Nested_LoadDataFromDataSource()
                Nested_LoadEditorsProperties()
                Nested_PostLoadingActions()
                MyBase.m_IsLoading = False
            End If
        Catch ex As Exception
            MyBase.m_IsLoading = False
            Throw
        End Try
    End Sub




    Protected Overrides Sub Nested_PrepareLoading()
        CustomBar1.Visible = True
        Me.CustomBar1.SetTargetControl(Me)
        InterfaceMediator.LoadCombo(Me.cboTipo, controllerTP.GetListaTipiPrestazioni, True)
        lblId.Visible = False
        Me.IdUtenteTextBox2.Visible = False
        Me.IdUtenteTextBox1.Enabled = False
        CmdVis.Visible = False

        Me.lblIdPrest.Visible = True
        Me.txtIdPrest.Visible = True
        CustomBar1.Visible = True
        MainGroup.Visible = True
        refBox.Visible = True
        GroupBox1.Visible = True
        Me.SpDel.Disabled = False
        Me.SpDelRef.Disabled = False
        Me.SpView.Disabled = False
        Me.SpAddFile.Disabled = False

        Me.SpAddFile.Visible = True
        Me.SpDel.Visible = True
        Me.SpDelRef.Visible = True
        Me.SpView.Visible = True
    End Sub
    Protected Overrides Sub Nested_ClearWindowEditors()
        'Qui pulisco tutti i campi della maschera
        Me.IdUtenteTextBox1.TextValue = ""
        Me.IdReferenteTextBox1.TextValue = ""
        dtpData.Value = Now
        dtpDoc.Value = Now
        Me.txtNote.Text = ""
        Me.cboTipo.Text = ""
        Me.txtIdPrest.Text = ""
        lblDocumento.Text = "Nessun documento"
        lblDocumento.ForeColor = Color.Black

    End Sub
    Protected Overrides Sub Nested_LoadEditorsProperties()
        Me.IdUtenteTextBox1.TextValue = controller.IdUtente
        Me.IdReferenteTextBox1.TextValue = controller.IdReferente
        InterfaceMediator.GetSimpleDescription(New WIN.APPLICATION.UTENTI.ControllerUtenti, "CompleteName", Me.lblDescrizioneUtente, Me.IdUtenteTextBox1.TextValue)
        InterfaceMediator.GetSimpleDescription(New WIN.APPLICATION.FINANCIAL_ARTIFACTS.ControllerReferenti, "CompleteName", Me.lblDescrizioneReferente, Me.IdReferenteTextBox1.TextValue)
        'Me.txtId.Text = controller.IdPrestazione
        dtpData.Value = controller.DataRegistrazione
        dtpDoc.Value = controller.DataDocumento

        If controller.NomeFileOutput = "" Then
            lblDocumento.Text = "Nessun documento"
            lblDocumento.ForeColor = Color.Black
        Else
            lblDocumento.Text = controller.NomeFileOutput
            lblDocumento.ForeColor = System.Drawing.SystemColors.ActiveCaption
        End If


        LoadFileStateImage()

        Me.txtNote.Text = controller.Note
        Me.cboTipo.Text = controller.DescrizioneTipoPrestazione
        txtIdPrest.Text = controller.IdPrestazione
    End Sub


    Protected Overrides Sub Nested_LoadDataFromDataSource()
        'qui carico ordino il caricamento dei dati e carico le possibili scelte

        controller.LoadById(Me.m_IdShowedObject)

    End Sub

    Protected Overrides Sub Nested_PrepareForCreation()
        Me.IdUtenteTextBox1.Enabled = True

        Me.SpAddFile.Visible = False
        Me.SpDel.Visible = False
        Me.SpDelRef.Visible = False
        Me.SpView.Visible = False
        Me.lblIdPrest.Visible = False
        Me.txtIdPrest.Visible = False
        MainGroup.Visible = True
        InterfaceMediator.LoadCombo(Me.cboTipo, controllerTP.GetListaTipiPrestazioni, True)
        CustomBar1.SetTargetControl(Me)
        CustomBar1.Visible = True

        lblId.Visible = False

        Me.IdUtenteTextBox2.Visible = False
        CmdVis.Visible = False
        lblDescrizioneReferente.Text = ""
        lblDescrizioneUtente.Text = ""
        If m_automaticCreation Then
            Me.m_automaticCreation = False
            Me.IdUtenteTextBox1.TextValue = m_IdUtente
            InterfaceMediator.GetSimpleDescription(New UTENTI.ControllerUtenti, "CompleteName", Me.lblDescrizioneUtente, m_IdUtente)
        End If

    End Sub
#End Region



    Protected Overrides Sub Nested_PostSaveActions()
        Me.SpAddFile.Visible = True
        Me.SpDel.Visible = True
        Me.SpDelRef.Visible = True
        Me.SpView.Visible = True
        Me.SpAddFile.Disabled = False
        Me.SpDel.Disabled = False
        Me.SpDelRef.Disabled = False
        Me.SpView.Disabled = False
    End Sub


#Region "Metodi per la custombar"

    Private Sub CustomBar1_DoStampaClick(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles CustomBar1.DoStampaClick

        DoPrint()

    End Sub

    Private Sub CustomBar1_DoAnnullaClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoAnnullaClick
        DoUndo()
    End Sub

    Public Overrides Sub DoUndo()
        Try
            If Me.State.StateName = "Creazione" Then
                MasterControl.Instance.GoPrevious()
            Else
                'inserisco il do load per recuperare gli eventi
                Me.StartUndoOperation()
                DoLoad()
            End If
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Protected Overrides Sub DoPrint()
        Try
            Dim print As PrintFacade = New PrintFacade
            print.PrintPrestazione(controller)
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub



    Private Sub CustomBar1_DoEliminaClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoEliminaClick
        Try
            Nested_CheckSecurityForDeletion()
            If MsgBox("La prestazione sarà eliminata solamente se nel sistema non ci sono altri riferimenti alla prestazione. Sicuro di voler cancellare la prestazione selezionata? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminazione utente") = MsgBoxResult.Yes Then
                controller.Delete()
                MasterControl.Instance.GoPrevious()
            End If
        Catch ex As AccessDeniedException
            MsgBox("Impossibile eliminare l'elemento. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    Private Sub CustomBar1_DoSaveClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoSaveClick
        Try
            StartSaveOperation()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub CustomBar1_DoNewClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoNewClick
        Try

            Me.StartCreateOperation()
        Catch ex As AccessDeniedException
            MsgBox("Impossibile inserire un nuovo elemento. Accesso negato", MsgBoxStyle.Information, "Accesso negato")

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

#End Region

#Region "Metodi per il salvataggio"
    Protected Overloads Sub GoPreviosCommand()


        MasterControl.Instance.GoPrevious()


    End Sub
    Private Overloads Sub AddCommandToHistory()
        Dim ParameterList As Hashtable = New Hashtable
        ParameterList.Add("Id", m_IdShowedObject)
        Me.AddCommandToHistory("ViewPrestazione", ParameterList)

    End Sub
    Protected Overrides Sub Nested_PostCreationActions()
        Me.AddCommandToHistory()
        Me.txtIdPrest.Enabled = False
        Me.txtIdPrest.Visible = True
        Me.lblIdPrest.Visible = True
        Me.SpAddFile.Visible = True
        Me.SpDel.Visible = True
        Me.SpDelRef.Visible = True
        Me.SpView.Visible = True
        Me.SpAddFile.Disabled = False
        Me.SpDel.Disabled = False
        Me.SpDelRef.Disabled = False
        Me.SpView.Disabled = False

    End Sub
    Protected Overrides Sub Navigate()
        Try
            Dim ParameterList As Hashtable = New Hashtable
            ParameterList.Add("Id", m_IdShowedObject)
            Me.NavigateWithoutHistoryTo("ViewPrestazione", ParameterList, True)
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")

        End Try
    End Sub
    Protected Overloads Sub NavigateToNew()
        Try
            Me.NavigateWithoutHistoryTo("CreatePrestazione")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")

        End Try
    End Sub
    Protected Overloads Sub Navigate(ByVal ToId As String, ByVal Link As String)
        Try
            Dim ParameterList As Hashtable = New Hashtable
            ParameterList.Add("Id", ToId)
            Me.NavigateTo(Link, ParameterList)
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")

        End Try
    End Sub

    Public Overrides Sub Nested_InsertData()

        controller.CreateNew(dtpDoc.Value, dtpData.Value, txtNote.Text, Me.IdUtenteTextBox1.TextValue, Me.IdReferenteTextBox1.TextValue, controllerTP.GetIdTipoPrestazioneByDescrizione(cboTipo.Text))
        controller.CreaFileOutput()
        If System.IO.File.Exists(controller.NomeFileOutput) Then
            lblDocumento.Text = controller.NomeFileOutput
        End If

        LoadFileStateImage()
        If System.IO.File.Exists(controller.NomeFileOutput) And My.Settings.VisualizzaFileOutput Then
            controller.OpenFile(controller.NomeFileOutput)
        End If
        MyBase.m_IdShowedObject = controller.IdPrestazione


    End Sub
#End Region








#Region "Metodi per l'aggiornamento"
    Public Overrides Sub Nested_UpdateData()
        controller.SetUtente(Me.IdUtenteTextBox1.TextValue)
        controller.SetReferente(Me.IdReferenteTextBox1.TextValue)
        controller.DataRegistrazione = dtpData.Value
        controller.DataDocumento = dtpDoc.Value
        If Me.lblDocumento.Text = "Nessun documento" Then
            controller.SetFileOutput("")
        Else
            controller.SetFileOutput(Me.lblDocumento.Text)
        End If

        controller.Note = Me.txtNote.Text
        controller.SetTipoPrestazione(controllerTP.GetIdTipoPrestazioneByDescrizione(Me.cboTipo.Text))
        controller.Save()
        LoadFileStateImage()

    End Sub
    Public Overrides Sub Nested_PrepareForUpdate()
        MyBase.Nested_PrepareForUpdate()
        Me.SpDel.Disabled = True
        Me.SpDelRef.Disabled = True
        Me.SpView.Disabled = True
    End Sub
    Private Sub txtNote_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNote.TextChanged
        Me.StartChangeOperation()
    End Sub
    Private Sub txtFile_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.StartChangeOperation()
    End Sub
    Private Sub dtpData_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpData.ValueChanged
        Me.StartChangeOperation()
    End Sub
    Private Sub dtpDoc_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDoc.ValueChanged
        Me.StartChangeOperation()
    End Sub
    Private Sub cboTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipo.SelectedIndexChanged
        Me.StartChangeOperation()
    End Sub


#End Region




#Region "Metodi di info sui singoli campi e sui link agli altri oggetti"


    Private Sub IdUtenteTextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles IdUtenteTextBox1.Leave
        InterfaceMediator.GetSimpleDescription(New WIN.APPLICATION.UTENTI.ControllerUtenti, "CompleteName", Me.lblDescrizioneUtente, Me.IdUtenteTextBox1.TextValue)
    End Sub
    Private Sub IdReferenteTextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles IdReferenteTextBox1.Leave
        InterfaceMediator.GetSimpleDescription(New WIN.APPLICATION.FINANCIAL_ARTIFACTS.ControllerReferenti, "CompleteName", Me.lblDescrizioneReferente, Me.IdReferenteTextBox1.TextValue)
    End Sub

    Private Sub lblTipo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label4.DoubleClick
        Try
            Navigate(controllerTP.GetIdTipoPrestazioneByDescrizione(Me.cboTipo.Text), "ViewTipoPrestazione")
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    Private Sub lblUtente_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblUtente.DoubleClick
        Try
            Navigate(Me.IdUtenteTextBox1.TextValue, "ViewUtente")
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    Private Sub lblReferente_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblReferente.DoubleClick
        Try
            Navigate(Me.IdReferenteTextBox1.TextValue, "ViewReferente")
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

#End Region

#Region "Metodi sul file di output"

    Private Sub SpView_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles SpView.DoClik
        Try
            controller.OpenFile(lblDocumento.Text)
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    Private Sub SpAddFile_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles SpAddFile.DoClik
        '' If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
        'OpenFileDialog1.ShowDialog()
        'lblDocumento.Text = OpenFileDialog1.FileName
        'lblDocumento.ForeColor = System.Drawing.SystemColors.ActiveCaption

        'Change()
        '' End If


        Try
            Dim frm As New FrmAllegaFile()
            frm.Destination = GetCartellaPreferenziale()
            Dim dialog As System.Windows.Forms.DialogResult = frm.ShowDialog

            If dialog = Windows.Forms.DialogResult.OK Then
                lblDocumento.Text = frm.FileName
                lblDocumento.ForeColor = System.Drawing.SystemColors.ActiveCaption
                LoadFileStateImage()

                Me.StartChangeOperation()
            End If
            frm.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Errore")
        End Try


    End Sub

    Private Sub LoadFileStateImage()
        If My.Computer.FileSystem.FileExists(lblDocumento.Text) Then
            PictureBox1.BackgroundImage = My.Resources.OK
        Else
            PictureBox1.BackgroundImage = My.Resources.WarningHS
        End If
    End Sub

    Private Function GetCartellaPreferenziale() As String

        Dim controllerUtenti As New UTENTI.ControllerUtenti


        controllerUtenti.LoadById(IdUtenteTextBox1.TextValue)



        Return controllerUtenti.CartellaPreferenziale

    End Function

    Private Sub SpDel_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles SpDel.DoClik
        Try
            If MsgBox("Sicuro di voler eliminare il file?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminazione file prestazione") = MsgBoxResult.Yes Then
                controller.RemoveOutputFile()
                StartSaveOperation()
                lblDocumento.Text = "Nessun documento"
                lblDocumento.ForeColor = Color.Black
            End If
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    Private Sub SpDelRef_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles SpDelRef.DoClik
        Try
            If MsgBox("Sicuro di voler eliminare il riferimento al file?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Eliminazione file prestazione") = MsgBoxResult.Yes Then
                controller.RemoveReferenceToOutputFile()
                StartSaveOperation()
                lblDocumento.Text = "Nessun documento"
                lblDocumento.ForeColor = Color.Black
            End If
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

#End Region




    Private Sub IdReferenteTextBox1_TextBoxChanged() Handles IdReferenteTextBox1.TextBoxChanged
        Me.StartChangeOperation()
    End Sub


    Private Sub IdUtenteTextBox1_TextBoxChanged() Handles IdUtenteTextBox1.TextBoxChanged
        Me.StartChangeOperation()
    End Sub

  
End Class

