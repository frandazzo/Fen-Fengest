Imports WIN.SECURITY.Exceptions

Public Class ControlVisualizzaPratiche
    Private controller As New UTENTI.ControllerUtenti
    Private controllerpratiche As New ControllerPratiche
    Public Sub New()
        InitializeComponent()
        Try



            DoLoad()

        Catch ex As Exception
            'ErrorHandler.ShowError(ex)
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Public Sub New(ByVal IdUtente As Int32)
        InitializeComponent()
        Me.m_IdShowedObject = IdUtente

        DoLoad()

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)
        Dim hash As New Hashtable
        hash.Add("IdUtente", 1)
        Me.NavigateWithoutHistoryTo("CreatePratica", hash, True)
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs)
        Dim SelectedId As Int32 = 1
        Me.Navigate(SelectedId, "ViewPratica")
    End Sub

    'Protected Overloads Sub Navigate(ByVal ToId As String, ByVal Link As String)
    '    Try
    '        Dim ParameterList As Hashtable = New Hashtable
    '        ParameterList.Add("Id", ToId)
    '        Me.NavigateTo(Link, ParameterList, True)
    '    Catch ex As AccessDeniedException
    '        MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")
    '    End Try
    'End Sub


    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "" & MyBase.State.StateName & "  pratiche utente"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "" & MyBase.State.StateName & "  pratiche utente "
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & " pratiche utente")
        SelectToolStripImage()
    End Sub
    Protected Overrides Sub Nested_PostLoadingActions()
        Dim logo As String = "" & MyBase.State.StateName & "  pratiche utente"
        MasterControl.Instance.ParentForm.Text = logo & " " & UCase(controller.CompleteName)
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo & " " & UCase(controller.CompleteName)
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  pratiche  -  " & UCase(controller.CompleteName))

    End Sub
    Protected Overrides Sub Nested_PostchangeActions()
        Try
            Dim logo As String = "" & MyBase.State.StateName & "  pratiche utente"
            MasterControl.Instance.ParentForm.Text = logo & " " & UCase(controller.CompleteName)
            MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo & " " & UCase(controller.CompleteName)
            Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  pratiche  -  " & UCase(controller.CompleteName))
        Catch ex As Exception
            Nested_NotifyParent()
        End Try

    End Sub


    Public Overrides Sub DoSearch()
        Me.NiceGroupBox1.Visible = False
        Me.TabControl1.Visible = False
        Me.IdUtenteTextBox1.TextValue = ""
        Me.IdUtenteTextBox1.Visible = True
        Me.IdUtenteTextBox1.Enabled = True
        Me.lblId.Visible = True

        MasterControl.Instance.ParentForm.Text = "Ricerca pratiche utente"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Ricerca pratiche utente"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.SearchPaint
        '  Me.CmdVis.Visible = True
        Me.lblCurrentFunction.Text = UCase("Ricerca   pratiche   utente ")
    End Sub

    Protected Overrides Sub Nested_PrepareLoading()
        Me.TabControl1.Visible = True
        Me.IdUtenteTextBox1.TextValue = ""
        Me.IdUtenteTextBox1.Enabled = False
        Me.IdUtenteTextBox1.Visible = True
        Me.lblId.Visible = True
        Me.Nested_NotifyParent()

        ' Me.CmdVis.Visible = False

        Me.NiceGroupBox1.Visible = True
    End Sub

    Protected Overrides Sub Nested_LoadDataFromDataSource()
        'qui carico ordino il caricamento dei dati e carico le possibili scelte
        controller.LoadById(Me.m_IdShowedObject)
    End Sub
    Protected Overrides Sub Nested_LoadEditorsProperties()
        Try
            Me.IdUtenteTextBox1.TextValue = controller.IdUtente
        Catch ex As NullReferenceException
            Return
        End Try


        lblDescrizioneUtente.Text = controller.CompleteName
        Dim listaPratiche As IList = controllerpratiche.GetPraticheByUtente(Me.m_IdShowedObject)
        'If listaVertenze.Count > 0 Then
        LoadGrid(listaPratiche)
        'Else
        '   PerformDialog()
        'End If
    End Sub

    Private Sub PerformDialog()
        Select Case MsgBox("Non esistono pratiche per l'utente selezionato. Si desidera creare una nuova Pratica? " & vbCrLf & _
                                   "Scegliere Sì per registrare una nuova Pratica;" & vbCrLf & _
                                   "Scegliere No per visualizzare l'anagrafica dell'utente selezionato;" & vbCrLf & _
                                   "Segliere Annulla per riprovare una nuova ricerca.", _
                                   MsgBoxStyle.YesNoCancel + MsgBoxStyle.Exclamation, _
                                   "Visualizzazione pratiche")
            Case MsgBoxResult.Cancel
                Me.NavigateWithoutHistoryTo("Viewpratiche", True)
            Case MsgBoxResult.Yes
                Me.NavigateWithoutHistoryTo("CreatePratica", True)
            Case MsgBoxResult.No
                Me.Navigate(m_IdShowedObject, "ViewUtente")
        End Select
    End Sub

    Private Sub GridPrestazioni_DoubleClick(sender As Object, e As EventArgs) Handles GridPrestazioni.DoubleClick
        Try
            If GridPrestazioni.SelectedRows.Count = 1 Then
                Dim SelectedId As Int32 = DirectCast(GridPrestazioni.SelectedRows.Item(0).DataBoundItem, Pratica).Id
                Me.Navigate(SelectedId, "ViewPratica")
            End If
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub LoadGrid(ByVal Lista As IList)

        'GridReferenti.DataSource = Lista
        With GridPrestazioni

            .DataSource = Lista

            .SelectionMode = DataGridViewSelectionMode.FullRowSelect

            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill


        End With

    End Sub

    Protected Overloads Sub Navigate(ByVal ToId As String)
        Try
            Dim ParameterList As Hashtable = New Hashtable
            ParameterList.Add("Id", ToId)
            Me.NavigateTo("ViewPratiche", ParameterList, True)
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")

        End Try
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

    Private Sub View()
        Try
            Me.m_IdShowedObject = Me.IdUtenteTextBox1.TextValue
            Dim listaPrestazioni As IList = controllerpratiche.GetPraticheByUtente(Me.IdShowedObject)
            If listaPrestazioni.Count > 0 Then
                Navigate(Me.m_IdShowedObject)
            Else
                PerformDialog()
            End If
        Catch ex As Exception
            If TypeOf (ex) Is InvalidCastException Then
                ex = New Exception("L'id di ricerca non ha un formato valido oppure è nullo. Inserire un id corretto")
            End If
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub SpNew_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles SpNew.DoClik
        Try
            Dim id As Int32
            Try
                id = CType(IdUtenteTextBox1.TextValue, Int32)
            Catch ex As InvalidCastException
                id = -1
            Catch ex As OverflowException
                id = -1
            End Try


            If id = -1 Then
                Me.NavigateWithoutHistoryTo("CreatePratica", True)
            Else

                Dim hash As New Hashtable
                hash.Add("IdUtente", IdUtenteTextBox1.TextValue)
                Me.NavigateWithoutHistoryTo("CreatePratica", hash, True)
            End If
        Catch ex As AccessDeniedException
            MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")

        End Try
    End Sub
End Class
