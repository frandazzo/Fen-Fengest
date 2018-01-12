Imports System.Windows.Forms
Imports WIN.SECURITY.Exceptions
Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY
Imports WIN.GUI.UTILITY

<SecureContext()> _
Public Class ControlVertenza
    Private controller As New WIN.APPLICATION.ADMINISTRATION.ControllerVertenze
    Private controllerIstituti As New WIN.APPLICATION.ADMINISTRATION.ControllerIstituti
    Private WithEvents frm As FrmEventi
    Private m_IdUtente As Int32 = -1
    Private m_automaticCreation As Boolean = False
    Private m_CartellaUtente As String = ""

    Dim m_ClearCache As Boolean = False

    Public Sub New(ByVal IdVertenza As Int32, ByVal ClearCache As Boolean)
        InitializeComponent()
        Me.m_IdShowedObject = IdVertenza
        m_ClearCache = ClearCache

        DoLoad()

    End Sub


    Private Sub CustomBar1_DoInformationClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoInformationClick
        MsgBox(controller.CurrentObjectJournalingData, MsgBoxStyle.Information, "Informazione")
    End Sub
    Public Sub New(ByVal IdUtente As Int32, ByVal dummyField1 As Boolean, ByVal dummyField2 As Boolean)
        InitializeComponent()
        m_IdUtente = IdUtente

        m_automaticCreation = True
        DoLoad()

    End Sub


    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "" & MyBase.State.StateName & " vertenza"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "" & MyBase.State.StateName & " vertenza "
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  vertenza")
        SelectToolStripImage()
    End Sub
    Protected Overrides Sub Nested_PostLoadingActions()
        Dim logo As String = "" & MyBase.State.StateName & "  vertenza"
        MasterControl.Instance.ParentForm.Text = logo & " " & UCase(controller.DescrizioneUtente)
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo & " " & UCase(controller.DescrizioneUtente)
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  -   vertenza  " & UCase(controller.DescrizioneUtente))
        If TypeOf (Me.State) Is StView Then

        Else

        End If
    End Sub
    Protected Overrides Sub Nested_PostchangeActions()
        Try
            Dim logo As String = "" & MyBase.State.StateName & "  vertenza"
            MasterControl.Instance.ParentForm.Text = logo & " " & UCase(controller.DescrizioneUtente)
            MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo & " " & UCase(controller.DescrizioneUtente)
            Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  -   vertenza   " & UCase(controller.DescrizioneUtente))
        Catch ex As Exception
            Nested_NotifyParent()
        End Try

    End Sub

    Private Sub IdAziendaTextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles IdAziendaTextBox1.Leave
        InterfaceMediator.GetSimpleDescription(New WIN.APPLICATION.AZIENDE.ControllerAziende, "Descrizione", Me.lblAziendaDescrizione, Me.IdAziendaTextBox1.TextValue)
    End Sub
    Private Sub IdReferenteTextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles IdReferenteTextBox1.Leave
        InterfaceMediator.GetSimpleDescription(New WIN.APPLICATION.FINANCIAL_ARTIFACTS.ControllerReferenti, "CompleteName", Me.lblDescrizioneReferente, Me.IdReferenteTextBox1.TextValue)
    End Sub
    Private Sub IdReferenteTextBox2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles IdReferenteTextBox2.Leave
        InterfaceMediator.GetSimpleDescription(New WIN.APPLICATION.FINANCIAL_ARTIFACTS.ControllerReferenti, "CompleteName", Me.lblDescrizioneRUP, Me.IdReferenteTextBox2.TextValue)
    End Sub
    Private Sub IdUtenteTextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles IdUtenteTextBox1.Leave
        InterfaceMediator.GetSimpleDescription(New WIN.APPLICATION.UTENTI.ControllerUtenti, "CompleteName", Me.lblDescrizioneUtente, Me.IdUtenteTextBox1.TextValue)
    End Sub

    Protected Overloads Sub Navigate(ByVal ToId As String, ByVal Link As String)
        Try
            Dim ParameterList As Hashtable = New Hashtable
            ParameterList.Add("Id", ToId)
            Me.NavigateTo(Link, ParameterList, True)
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub



    Private Overloads Sub AddCommandToHistory()
        Dim ParameterList As Hashtable = New Hashtable
        ParameterList.Add("Id", m_IdShowedObject)
        Me.AddCommandToHistory("ViewVertenza", ParameterList)
    End Sub
    Protected Overrides Sub Nested_PostCreationActions()
        Me.AddCommandToHistory()
        Me.txtId.Enabled = False
        Me.txtId.Visible = True
        Me.lblId.Visible = True
    End Sub


    Protected Overloads Sub Navigate(ByVal ToId As String, Optional ByVal ClearCache As Boolean = False)
        Try
            Dim ParameterList As Hashtable = New Hashtable
            ParameterList.Add("Id", ToId)
            ParameterList.Add("ClearCache", ClearCache)
            Me.NavigateWithoutHistoryTo("ViewVertenza", ParameterList, True)
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub



    Private Sub lblAzienda_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblAzienda.Click
        Try
            Navigate(Me.IdAziendaTextBox1.TextValue, "ViewAzienda")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    Private Sub lblReferente_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblReferente.Click
        Try
            Navigate(Me.IdReferenteTextBox1.TextValue, "ViewReferente")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    Private Sub lblRup_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblRup.Click
        Try
            Navigate(Me.IdReferenteTextBox2.TextValue, "ViewReferente")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    Private Sub lblUtente_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lblUtente.Click
        Try
            Navigate(Me.IdUtenteTextBox1.TextValue, "ViewUtente")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub


    Public Overrides Sub StartChangeOperation()
        Try
            MyBase.StartChangeOperation()
        Catch ex As AccessDeniedException
            MsgBox("Impossibile aggiornare l'oggetto. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    <Secure(Area:="Vertenze", Alias:="Creazione", Macroarea:="Servizi")> _
    Protected Overrides Sub Nested_CheckSecurityForCreation()
        SecurityManager.Instance.Check()
    End Sub

    <Secure(Area:="Vertenze", Alias:="Aggiornamento", Macroarea:="Servizi")> _
    Protected Overrides Sub Nested_CheckSecurityForChanging()
        SecurityManager.Instance.Check()
    End Sub

    <Secure(Area:="Vertenze", Alias:="Cancellazione", Macroarea:="Servizi")> _
    Protected Overrides Sub Nested_CheckSecurityForDeletion()
        SecurityManager.Instance.Check()
    End Sub


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
                Me.Navigate(Me.txtId.Text, True)
            End If
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Protected Overrides Sub DoPrint()
        Try
            Dim print As PrintFacade = New PrintFacade
            print.PrintVertenze(controller)
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub




    Private Sub CustomBar1_DoEliminaClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoEliminaClick
        Try
            Nested_CheckSecurityForDeletion()
            If MsgBox("La vertenza sarà eliminata solamente se nel sistema non ci sono altri riferimenti alla vertenza. Sicuro di voler cancellare la vertenza selezionata? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminazione utente") = MsgBoxResult.Yes Then
                controller.Delete()
                MasterControl.Instance.GoPrevious()
            End If
        Catch ex As AccessDeniedException
            MsgBox("Impossibile eliminare l'elemento. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    Private Sub CustomBar1_DoNewClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoNewClick
        Try
            'NavigateWithoutHistoryTo("CreateVertenza")
            Me.StartCreateOperation()
        Catch ex As AccessDeniedException
            MsgBox("Impossibile inserire un nuovo elemento. Accesso negato", MsgBoxStyle.Information, "Accesso negato")

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





    Public Sub New()
        InitializeComponent()

        DoLoad()

    End Sub
    Public Sub New(ByVal IdVertenza As Int32)
        InitializeComponent()
        Me.m_IdShowedObject = IdVertenza

        DoLoad()

    End Sub



#Region "Metodi per Load iniziale"
    Protected Overrides Sub Nested_PrepareLoading()
        Me.MainGroup.Visible = True
        Me.txtId.Text = ""
        Me.txtId.Visible = True
        Me.lblId.Visible = True
        Me.IdUtenteTextBox1.Enabled = False
        'MasterControl.Instance.ParentForm.Text = "Visualizzazione vertenza"
        CustomBar1.SetTargetControl(Me)
        InterfaceMediator.LoadCheckedListBox(Me.lstIst, controllerIstituti.GetListaCausali)
    End Sub

    Protected Overrides Sub Nested_ClearWindowEditors()
        'Qui pulisco tutti i campi della maschera
        chkVertenzaChiusa.Checked = False
        dtpData.Value = Today
        dtpDoc.Value = Today
        txtNote.Text = ""
        dtpDI.Value = Today
        dtpDF.Value = Today
        Me.txtId.Text = ""
        Me.IdUtenteTextBox1.TextValue = ""
        Me.IdReferenteTextBox1.TextValue = ""
        Me.IdReferenteTextBox2.TextValue = ""
        Me.IdAziendaTextBox1.TextValue = ""
        Me.txtImp.Text = ""
        Me.lblAziendaDescrizione.Text = ""
        Me.lblDescrizioneRUP.Text = ""
        Me.lblDescrizioneReferente.Text = ""
        Me.lblDescrizioneUtente.Text = ""
        Me.lblDescrizioneAvvocato.Text = ""
        Me.IdAvvocatoTextbox1.TextValue = ""
    End Sub
    Protected Overrides Sub Nested_LoadDataFromDataSource()
        If m_ClearCache Then
            controller.LoadByIdReloadingCache(Me.m_IdShowedObject)
            m_ClearCache = False
        Else
            controller.LoadById(Me.m_IdShowedObject)
        End If
    End Sub
    Protected Overrides Sub Nested_LoadEditorsProperties()
        dtpData.Value = controller.DataRegistrazione
        dtpDoc.Value = controller.DataDocumento
        dtpDI.Value = controller.DataInizioPeriodo
        dtpDF.Value = controller.DataFinePeriodo
        txtNote.Text = controller.Note
        Me.txtId.Text = controller.IdVertenza
        Me.IdUtenteTextBox1.TextValue = controller.IdUtente
        Me.IdReferenteTextBox1.TextValue = controller.IdReferente
        Me.IdReferenteTextBox2.TextValue = controller.IdRup
        Me.IdAziendaTextBox1.TextValue = controller.IdAzienda
        Me.txtImp.Text = controller.Importo
        Me.lblAziendaDescrizione.Text = controller.DescrizioneAzienda
        Me.lblDescrizioneRUP.Text = controller.DescrizioneRup
        Me.lblDescrizioneReferente.Text = controller.DescrizioneReferente
        Me.lblDescrizioneUtente.Text = controller.DescrizioneUtente
        Me.lblDescrizioneAvvocato.Text = controller.DescrizioneAvvocato
        Me.IdAvvocatoTextbox1.TextValue = controller.IdAvvocato

        Dim listaIstituti As ArrayList = controller.GetListaIstituti
        'Me.lstIst.Items.Clear()
        'InterfaceMediator.LoadCheckedListBox(Me.lstIst, controllerIstituti.GetListaCausali)
        For Each elem As String In listaIstituti
            If Me.lstIst.Items.Contains(elem) Then
                Dim i As Int32 = Me.lstIst.Items.IndexOf(elem)
                lstIst.SetItemChecked(i, True)
            End If
        Next
        'adesso carico la lista degli eventi
        LoadGrid(controller.GetListaEventi)
        Me.GridEventi.Refresh()
        chkVertenzaChiusa.Checked = controller.VertenzaChiusa
        'CheckEnabledUI()
    End Sub
#End Region


#Region "Metodi per la creazione di un nuovo oggetto"
    Public Overrides Sub DoLoad()
        Try
            If Me.m_IdShowedObject = -1 Then
                'Me.PrepareForCreation()
            Else
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
    Protected Overrides Sub Nested_PrepareForCreation()
        CustomBar1.SetTargetControl(Me)
        lblId.Visible = False
        txtId.Visible = False
        InterfaceMediator.LoadCheckedListBox(Me.lstIst, controllerIstituti.GetListaCausali)
        controller.CreateNew()
        LoadGrid(controller.GetListaEventi)
        Me.IdUtenteTextBox1.Enabled = True
        If m_automaticCreation Then
            Me.m_automaticCreation = False
            Me.IdUtenteTextBox1.TextValue = m_IdUtente
            InterfaceMediator.GetSimpleDescription(New UTENTI.ControllerUtenti, "CompleteName", Me.lblDescrizioneUtente, m_IdUtente)
        End If
    End Sub

#End Region


#Region "Metodi per il salvataggio"
    Public Overrides Sub Nested_InsertData()


        controller.DataRegistrazione = dtpData.Value
        controller.DataDocumento = dtpDoc.Value
        controller.SetPeriodoVertenza(dtpDI.Value, dtpDF.Value)
        controller.Note = txtNote.Text
        controller.SetUtente(Me.IdUtenteTextBox1.TextValue)
        controller.SetReferente(Me.IdReferenteTextBox1.TextValue)
        controller.SetRup(Me.IdReferenteTextBox2.TextValue)
        controller.SetAzienda(Me.IdAziendaTextBox1.TextValue)
        controller.SetQuota(Me.txtImp.Text)
        controller.SetAvvocato(Me.IdAvvocatoTextbox1.TextValue)
        controller.VertenzaChiusa = chkVertenzaChiusa.Checked
        For Each elem As Int32 In Me.lstIst.CheckedIndices
            controller.AddIstituto(Me.lstIst.Items(elem))
        Next
        controller.Save()
        MyBase.m_IdShowedObject = controller.IdVertenza

    End Sub
#End Region



#Region "Metodi per l'aggiornamento"
    Public Overrides Sub Nested_UpdateData()
        controller.DataRegistrazione = dtpData.Value
        controller.DataDocumento = dtpDoc.Value
        controller.SetPeriodoVertenza(dtpDI.Value, dtpDF.Value)
        controller.Note = txtNote.Text
        controller.SetUtente(Me.IdUtenteTextBox1.TextValue)
        controller.SetReferente(Me.IdReferenteTextBox1.TextValue)
        controller.SetRup(Me.IdReferenteTextBox2.TextValue)
        controller.SetAzienda(Me.IdAziendaTextBox1.TextValue)
        controller.SetQuota(Me.txtImp.Text)
        controller.SetAvvocato(Me.IdAvvocatoTextbox1.TextValue)
        controller.VertenzaChiusa = chkVertenzaChiusa.Checked
        controller.ClearListaIstituti()
        For Each elem As Int32 In Me.lstIst.CheckedIndices
            controller.AddIstituto(Me.lstIst.Items(elem))
        Next
        controller.Save()
    End Sub
    Private Sub IdReferenteTextBox1_TextBoxChanged()
        Me.StartChangeOperation()
    End Sub
    Private Sub IdReferenteTextBox2_TextBoxChanged()
        Me.StartChangeOperation()
    End Sub
    Private Sub IdAziendaTextBox1_TextBoxChanged()
        Me.StartChangeOperation()
    End Sub
    Private Sub txtNote_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.StartChangeOperation()
    End Sub
    Private Sub dtpData_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.StartChangeOperation()
    End Sub
    Private Sub dtpDoc_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.StartChangeOperation()
    End Sub
    Private Sub dtpDI_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.StartChangeOperation()
    End Sub
    Private Sub dtpDF_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.StartChangeOperation()
    End Sub
    Private Sub txtFile_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.StartChangeOperation()
    End Sub

    Private Sub lstIst_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs)
        Me.StartChangeOperation()
    End Sub

    Private Sub frm_EventAdded() Handles frm.EventAdded
        Me.StartChangeOperation()
    End Sub

    Private Sub frm_EventUpdated() Handles frm.EventUpdated
        Me.StartChangeOperation()
    End Sub
#End Region

    Private Sub CmdSel_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CmdSel.DoClik
        Try
            If VerificaCompilazioneUtente() Then
                SetCartellaUtente()
                If Me.GridEventi.SelectedRows.Count = 0 Then Throw New Exception("Nessun evento è stato selezionato. Selezionare un evento.")
                controller.SelectEvento(GridEventi.SelectedRows(0).Cells("DataDocumento").Value, GridEventi.SelectedRows(0).Cells("TipoEvento").Value.Descrizione)
                frm = New FrmEventi("View", controller, m_CartellaUtente)
                frm.ShowDialog()
                frm.Dispose()
                'GridEventi.Refresh()
                LoadGrid(controller.GetListaEventi)
            Else
                MsgBox("Impostare un utente!", MsgBoxStyle.Exclamation + MsgBoxStyle.Information, "Informazione")
            End If
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
    Private Sub CmdAdd_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CmdAdd.DoClik
        Try

            If VerificaCompilazioneUtente() Then
                SetCartellaUtente()
                frm = New FrmEventi("Add", controller, m_CartellaUtente)
                frm.ShowDialog()
                frm.Dispose()
                'GridEventi.Refresh()
                LoadGrid(controller.GetListaEventi)
            Else
                MsgBox("Impostare un utente!", MsgBoxStyle.Exclamation + MsgBoxStyle.Information, "Informazione")
            End If




        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub SetCartellaUtente()
        Dim controllerUtente As New UTENTI.ControllerUtenti
        controllerUtente.LoadById(IdUtenteTextBox1.TextValue)
        m_CartellaUtente = controllerUtente.CartellaPreferenziale
    End Sub

    Private Function VerificaCompilazioneUtente() As Boolean
        If Me.IdUtenteTextBox1.TextValue = "" Then
            Return False
        End If
        Return True
    End Function




    Private Sub CmdDel_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CmdDel.DoClik
        Try
            If Me.GridEventi.SelectedRows.Count = 0 Then Throw New Exception("Nessun evento è stato selezionato. Selezionare un evento.")
            controller.RemoveEvento(DirectCast(GridEventi.SelectedRows(0).Cells("DataDocumento").Value, DateTime), GridEventi.SelectedRows(0).Cells("TipoEvento").Value.Descrizione)
            Me.StartChangeOperation()
            'GridEventi.Refresh()
            LoadGrid(controller.GetListaEventi)
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub LoadGrid(ByVal Lista As IList)
        Try
            'GridReferenti.DataSource = Lista
            With GridEventi

                .DataSource = Lista
                If Lista.Count > 0 Then
                    .AutoGenerateColumns = False
                    .Columns("Key").Visible = False
                    .Columns("Id").Visible = False
                    .Columns("Versione").Visible = False
                    .Columns("CreatoDa").Visible = False
                    .Columns("ModificatoDa").Visible = False
                    .Columns("DataCreazione").Visible = False
                    .Columns("DataModifica").Visible = False
                    .Columns("Descrizione").Visible = False
                    .Columns("DataRegistrazione").Visible = False
                    .Columns("TipoDocumento").Visible = False
                    .Columns("DocumentoPadre").Visible = False


                    .Columns("DataDocumento").Visible = True
                    .Columns("DataDocumento").HeaderText = "Data evento"
                    .Columns("DataDocumento").ReadOnly = True
                    .Columns("DataDocumento").DisplayIndex = 1

                    .Columns("TipoEvento").Visible = True
                    .Columns("TipoEvento").HeaderText = "Tipo evento"
                    .Columns("TipoEvento").ReadOnly = True
                    .Columns("TipoEvento").DisplayIndex = 2

                    .Columns("Path_Documento").Visible = True
                    .Columns("Path_Documento").HeaderText = "Documento"
                    .Columns("Path_Documento").ReadOnly = True
                    .Columns("Path_Documento").DisplayIndex = 3

                    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing
                    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                End If
            End With


        Catch ex As Exception
            Throw New Exception("Impossibile caricare la griglia delle deleghe per l'utente" & vbCrLf & ex.Message)
        End Try
    End Sub



    Private Sub GridEventi_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles GridEventi.CellFormatting
        If GridEventi.Columns(e.ColumnIndex).Name.Equals("TipoEvento") Then
            If Not e.Value Is Nothing Then
                'GridDeleghe.Rows(e.RowIndex).Cells("StatoDelega").Value = e.Value.
                e.Value = e.Value.Descrizione
            End If
        End If
    End Sub

    Private Sub GridEventi_CellMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles GridEventi.CellMouseDoubleClick
        Try
            If VerificaCompilazioneUtente() Then
                SetCartellaUtente()
                If e.RowIndex <> -1 And e.ColumnIndex <> -1 Then
                    If Me.GridEventi.SelectedRows.Count = 0 Then Throw New Exception("Nessun evento è stato selezionato. Selezionare un evento.")
                    controller.SelectEvento(GridEventi.SelectedRows(0).Cells("DataDocumento").Value, GridEventi.SelectedRows(0).Cells("TipoEvento").Value.Descrizione)
                    frm = New FrmEventi("View", controller, m_CartellaUtente)
                    frm.ShowDialog()
                    frm.Dispose()
                    LoadGrid(controller.GetListaEventi)
                End If
            Else
                MsgBox("Impostare un utente!", MsgBoxStyle.Exclamation + MsgBoxStyle.Information, "Informazione")
            End If
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub



    Private Sub GridEventi_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles GridEventi.DataError
        If TypeOf (e.Exception) Is IndexOutOfRangeException Then
            Return
        End If
    End Sub


    Private Sub IdUtenteTextBox1_TextBoxChanged()
        Me.StartChangeOperation()
    End Sub


    Private Sub dtpData_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpData.ValueChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub dtpDoc_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDoc.ValueChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub IdUtenteTextBox1_TextBoxChanged_1() Handles IdUtenteTextBox1.TextBoxChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub IdAziendaTextBox1_TextBoxChanged_1() Handles IdAziendaTextBox1.TextBoxChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub txtNote_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNote.TextChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub dtpDI_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDI.ValueChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub dtpDF_ValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDF.ValueChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub lstIst_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstIst.SelectedIndexChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub IdReferenteTextBox2_TextBoxChanged_1() Handles IdReferenteTextBox2.TextBoxChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub IdReferenteTextBox1_TextBoxChanged_1() Handles IdReferenteTextBox1.TextBoxChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub txtImp_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtImp.TextChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub IdAvvocatoTextbox1_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IdAvvocatoTextbox1.Leave
        InterfaceMediator.GetSimpleDescription(New ControllerAvvocati, "Descrizione", Me.lblDescrizioneAvvocato, Me.IdAvvocatoTextbox1.TextValue)
    End Sub

    Private Sub IdAvvocatoTextbox1_TextBoxChanged() Handles IdAvvocatoTextbox1.TextBoxChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub lblAvvocato_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAvvocato.DoubleClick
        Try
            Navigate(Me.IdAvvocatoTextbox1.TextValue, "ViewAvvocato")
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub chkVertenzaChiusa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVertenzaChiusa.CheckedChanged
        Me.StartChangeOperation()
        'CheckEnabledUI()
    End Sub
    'Private Sub CheckEnabledUI()
    '    If chkVertenzaChiusa.Checked Then
    '        TabControl1.Enabled = False
    '        TabControl2.Enabled = False
    '        Panel1.Enabled = False
    '    Else
    '        TabControl1.Enabled = True
    '        TabControl2.Enabled = True
    '        Panel1.Enabled = True
    '    End If
    'End Sub
End Class
