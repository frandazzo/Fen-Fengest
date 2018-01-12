Imports System.Windows.Forms
Imports WIN.SECURITY.Attributes
Imports WIN.SECURITY
Imports WIN.SECURITY.Exceptions

<SecureContext()> _
Public Class ControlTipoPrestazioni
   Private controller As New WIN.APPLICATION.ADMINISTRATION.ControllerTipoPrestazione
   'Private m_SetFirstAivaibleRecord As Boolean = False
   'Public ReadOnly Property SetFirstAivaibleRecord() As Boolean
   '   Get
   '      Return m_SetFirstAivaibleRecord
   '   End Get
   'End Property
   ''' <summary>
   ''' Costruttore utilizzato dal comando di creazione di un nuovo contratto
   ''' </summary>
   ''' <remarks></remarks>
   Public Sub New()
      InitializeComponent()

      CustomBar1.SetTargetControl(Me)
      Me.m_IdShowedObject = -1
      DoLoad()

   End Sub

   Private Sub CustomBar1_DoInformationClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoInformationClick
      MsgBox(controller.CurrentObjectJournalingData, MsgBoxStyle.Information, "Informazione")
   End Sub

    Public Overrides Sub StartChangeOperation()
        Try
            MyBase.StartChangeOperation()
        Catch ex As AccessDeniedException
            MsgBox("Impossibile aggiornare l'oggetto. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
        End Try
    End Sub

    <Secure(Area:="TipiPrestazioni", Alias:="Creazione", Macroarea:="Setup")> _
    Protected Overrides Sub Nested_CheckSecurityForCreation()
        SecurityManager.Instance.Check()
    End Sub

    <Secure(Area:="TipiPrestazioni", Alias:="Aggiornamento", Macroarea:="Setup")> _
    Protected Overrides Sub Nested_CheckSecurityForChanging()
        SecurityManager.Instance.Check()
    End Sub

    <Secure(Area:="TipiPrestazioni", Alias:="Cancellazione", Macroarea:="Setup")> _
      Protected Overrides Sub Nested_CheckSecurityForDeletion()
        SecurityManager.Instance.Check()
    End Sub


    Public Sub New(ByVal IdTipoPrestazione As Int32)
        InitializeComponent()
        Try
            CustomBar1.SetTargetControl(Me)
            SetViewModeForTipo(IdTipoPrestazione)
        Catch ex As Exception
            'ErrorHandler.ShowError(ex)
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Private Sub SetViewModeForTipo(ByVal IdTipo As Int32)
        Dim list As ArrayList = controller.GetListaTipiPrestazioni
        If IdTipo = -1 Then
            'vado in modalità nuovo tipo prestazione nel caso non 
            'posso posizionarmi sul primo record
            If list.Count = 0 Then
                Me.StartCreateOperation()
                LoadGrid(controller.GetAll)
            Else
                LoadAll(list)
            End If
        Else
            Me.m_IdShowedObject = IdTipo
            DoLoad()
        End If
    End Sub
    Public Sub LoadAll(ByVal List As ArrayList)
        If List.Count = 0 Then
            Me.StartCreateOperation()
            LoadGrid(controller.GetAll)
            Exit Sub
        End If
        Me.m_IdShowedObject = controller.GetIdTipoPrestazioneByDescrizione(List.Item(0))
        DoLoad()
    End Sub


    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "" & MyBase.State.StateName & " tipo prestazione"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "" & MyBase.State.StateName & " tipi prestazione "
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & " tipo prestazione")
        SelectToolStripImage()
    End Sub

    Protected Overrides Sub Nested_PostLoadingActions()
        Dim logo As String = "" & MyBase.State.StateName & "  tipo prestazione"
        MasterControl.Instance.ParentForm.Text = logo & " " & UCase(controller.DescrizioneTipoPrestazione)
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo & " " & UCase(controller.DescrizioneTipoPrestazione)
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  -   tipo prestazione   " & UCase(controller.DescrizioneTipoPrestazione))
    End Sub

    Protected Overrides Sub Nested_PostchangeActions()
        Try
            Dim logo As String = "" & MyBase.State.StateName & "  tipo prestazione"
            MasterControl.Instance.ParentForm.Text = logo & " " & UCase(controller.DescrizioneTipoPrestazione)
            MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo & " " & UCase(controller.DescrizioneTipoPrestazione)
            Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  -   tipo prestazione   " & UCase(controller.DescrizioneTipoPrestazione))
        Catch ex As Exception
            Nested_NotifyParent()
        End Try

    End Sub

#Region "Metodi per Load iniziale"
    Public Overrides Sub DoLoad()
        Try
            'If m_SetFirstAivaibleRecord Then
            '   Me.NavigateToNew()
            'Else
            If Me.m_IdShowedObject = -1 Then
                Me.Nested_PrepareForCreation()
            Else
                MyBase.m_IsLoading = True
                Nested_PrepareLoading()
                Nested_ClearWindowEditors()
                Nested_LoadDataFromDataSource()
                Nested_LoadEditorsProperties()
                Nested_PostLoadingActions()
                MyBase.m_IsLoading = False
            End If
            'End If

        Catch ex As Exception
            MyBase.m_IsLoading = False
            Throw
        End Try
    End Sub
    Protected Overrides Sub Nested_PrepareLoading()
        CustomBar1.Visible = True
        Me.CustomBar1.SetTargetControl(Me)

    End Sub
    Protected Overrides Sub Nested_ClearWindowEditors()
        'Qui pulisco tutti i campi della maschera
        Me.txtCod.Text = ""
        Me.txtId.Text = ""
        Me.txtDescr.Text = ""
        Me.txtDir.Text = ""
        lblDocumento.Text = "Nessun documento"
        lblDocumento.ForeColor = Color.Black
    End Sub
    Protected Overrides Sub Nested_LoadEditorsProperties()
        Me.txtCod.Text = controller.CodicePrestazione
        Me.txtId.Text = controller.IdTipoPrestazione
        Me.txtDescr.Text = controller.DescrizioneTipoPrestazione
        If controller.NomeFileModello = "" Then
            lblDocumento.Text = "Nessun documento"
            lblDocumento.ForeColor = Color.Black
        Else
            lblDocumento.Text = controller.NomeFileModello
            lblDocumento.ForeColor = System.Drawing.SystemColors.ActiveCaption
        End If



        Me.txtDir.Text = controller.OutputDir
        LoadGrid(controller.GetAll)
        GridRowSelection(Me.txtCod.Text)

        LoadFileStateImage()
    End Sub
    Private Sub GridRowSelection(ByVal Id As String)
        GridPosizioni.ClearSelection()
        GridPosizioni.Rows.Item(0).Selected = False
        For Each row As System.Windows.Forms.DataGridViewRow In GridPosizioni.Rows
            If row.Cells("CodicePrestazione").Value = Id Then row.Selected = True
        Next
    End Sub
    Private Sub LoadGrid(ByVal Lista As IList)
        Try
            'GridReferenti.DataSource = Lista
            With GridPosizioni

                .DataSource = Lista
                If Lista.Count > 0 Then
                    .AutoGenerateColumns = False

                    .Columns("Key").Visible = False
                    .Columns("Versione").Visible = False
                    .Columns("CreatoDa").Visible = False
                    .Columns("ModificatoDa").Visible = False
                    .Columns("DataCreazione").Visible = False
                    .Columns("DataModifica").Visible = False
                    .Columns("Id").Visible = False
                    .Columns("TipoDocumento").Visible = False

                    .Columns("Descrizione").Visible = True
                    .Columns("Descrizione").DisplayIndex = 1
                    .Columns("Descrizione").ReadOnly = True

                    .Columns("CodicePrestazione").Visible = True
                    .Columns("CodicePrestazione").HeaderText = "Codice prestazione"
                    .Columns("CodicePrestazione").DisplayIndex = 2
                    .Columns("CodicePrestazione").ReadOnly = True

                    .Columns("NomeFileModello").Visible = True
                    .Columns("NomeFileModello").DisplayIndex = 3
                    .Columns("NomeFileModello").ReadOnly = True

                    .Columns("PathOutPut").Visible = False
                    '.Columns("NomeFileModello").DisplayIndex = 4
                    '.Columns("NomeFileModello").ReadOnly = True

                    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
                    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                End If
            End With


        Catch ex As Exception
            Throw New Exception("Impossibile caricare la griglia dei tipi prestazione per l'utente" & vbCrLf & ex.Message)
        End Try
    End Sub


    Protected Overrides Sub Nested_LoadDataFromDataSource()
        'qui carico ordino il caricamento dei dati e carico le possibili scelte
        Try
            controller.LoadById(Me.m_IdShowedObject)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Protected Overrides Sub Nested_PrepareForCreation()

        Nested_ClearWindowEditors()
        LoadGrid(controller.GetAll)

    End Sub
#End Region




    Public Overrides Sub Nested_InsertData()

        Dim nomeModello As String
        If Me.lblDocumento.Text = "Nessun documento" Then
            nomeModello = ""
        Else
            nomeModello = Me.lblDocumento.Text
        End If

        controller.CreateNew(txtDescr.Text, txtCod.Text, nomeModello)
        MyBase.m_IdShowedObject = controller.IdTipoPrestazione
        GridPosizioni.Refresh()
        'LoadGrid(controller.GetAll)

    End Sub
    Public Overrides Sub Nested_UpdateData()
        If Me.lblDocumento.Text = "Nessun documento" Then
            controller.NomeFileModello = ""
        Else
            controller.NomeFileModello = Me.lblDocumento.Text
        End If
        controller.DescrizioneTipoPrestazione = txtDescr.Text
        controller.CodicePrestazione = txtCod.Text
        'controller.OutputDir = txtDir.Text
        controller.SetPathOutput()
        controller.Save()
        GridPosizioni.Refresh()
        'LoadGrid(controller.GetAll)
    End Sub



    Private Sub CustomBar1_DoEliminaClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoEliminaClick
        Try
            Nested_CheckSecurityForDeletion()
            If MsgBox("Il tipo prestazione sarà eliminato solamente se nel sistema non ci sono altri riferimenti al tipo prestazione. Sicuro di voler cancellare il tipo prestazione selezionato? ", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminazione utente") = MsgBoxResult.Yes Then
                controller.Delete()
                LoadAll(controller.GetListaTipiPrestazioni)
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





#Region "Metodi per il salvataggio"
    Private Overloads Sub AddCommandToHistory()
        Dim ParameterList As Hashtable = New Hashtable
        ParameterList.Add("Id", m_IdShowedObject)
        Me.AddCommandToHistory("ViewTipoPrestazione", ParameterList)
    End Sub
    Protected Overrides Sub Nested_PostCreationActions()
        Me.AddCommandToHistory()
        Me.txtId.Enabled = False
        Me.txtId.Visible = True
        Me.lblId.Visible = True
    End Sub
    Protected Overrides Sub Navigate()

        Dim ParameterList As Hashtable = New Hashtable
        ParameterList.Add("Id", m_IdShowedObject)
        Me.NavigateWithoutHistoryTo("ViewTipoPrestazione", ParameterList, True)

    End Sub
    Protected Overloads Sub NavigateToNew()

        Me.NavigateWithoutHistoryTo("CreateTipoPrestazione")

    End Sub

#End Region


    Private Sub CmdSel_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs)
        SelectTipo()
    End Sub

    Private Sub SelectTipo()
        Try
            If Me.State.StateName <> "Visualizzazione" Then Exit Sub
            If GridPosizioni.SelectedRows.Count = 1 Then
                Me.m_IdShowedObject = controller.GetIdTipoPrestazioneByDescrizione(GridPosizioni.SelectedRows(0).Cells("Descrizione").Value)
                'Navigate()
                DoLoad()
            Else
                MsgBox("Non è stato selezionato alcun tipo prestazione. Selezionare un tipo prestazione.", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub



    Private Sub CustomBar1_DoStampaClick(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles CustomBar1.DoStampaClick

        DoPrint()

    End Sub

    Private Sub CustomBar1_DoAnnullaClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoAnnullaClick
        DoUndo()
    End Sub

    Public Overrides Sub DoUndo()
        Try
            Navigate()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Protected Overrides Sub DoPrint()
        Try
            Dim print As PrintFacade = New PrintFacade
            print.PrintListaTipiPrestazioni(controller)
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub



    Private Sub CustomBar1_DoNewClick(ByVal Sender As Object, ByVal e As System.EventArgs) Handles CustomBar1.DoNewClick
        Try
            'NavigateToNew()
            Me.StartCreateOperation()
        Catch ex As AccessDeniedException
            MsgBox("Impossibile inserire un nuovo elemento. Accesso negato", MsgBoxStyle.Information, "Accesso negato")

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub


    Private Sub SpCartella_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles SpCartella.DoClik
        FolderBrowserDialog1.ShowNewFolderButton = True
        FolderBrowserDialog1.Description = "Selezionare la cartella di output:"
        FolderBrowserDialog1.ShowDialog()
        txtDir.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub SpAddFile_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles SpAddFile.DoClik
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            lblDocumento.Text = OpenFileDialog1.FileName
            lblDocumento.ForeColor = System.Drawing.SystemColors.ActiveCaption
            LoadFileStateImage()
            Me.StartChangeOperation()
        End If




    End Sub

    Private Sub SpView_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles SpView.DoClik
        Try
            controller.OpenFile(Me.lblDocumento.Text)
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub txtDescr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescr.TextChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub txtCod_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCod.TextChanged
        Me.StartChangeOperation()
    End Sub

    Private Sub txtFileModello_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.StartChangeOperation()
    End Sub

    Private Sub txtDir_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.StartChangeOperation()
    End Sub


   Private Sub LoadFileStateImage()
      If My.Computer.FileSystem.FileExists(lblDocumento.Text) Then
         PictureBox1.BackgroundImage = My.Resources.OK
      Else
         PictureBox1.BackgroundImage = My.Resources.WarningHS
      End If
   End Sub

   Private Sub GridPosizioni_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridPosizioni.MouseDoubleClick
      SelectTipo()
   End Sub
End Class
