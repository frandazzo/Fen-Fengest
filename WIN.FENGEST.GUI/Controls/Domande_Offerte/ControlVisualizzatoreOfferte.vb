
Imports System.Windows.Forms
Imports System.Drawing.Drawing2D
Imports WIN.SECURITY.Exceptions

Public Class ControlVisualizzatoreOfferte
   Private controller As New WIN.APPLICATION.AZIENDE.ControllerAziende
   Private controllerOfferte As New ControllerOfferteLavoro
   Public Sub New()
      InitializeComponent()

      DoLoad()

   End Sub

   Public Sub New(ByVal IdUtente As Int32)
      InitializeComponent()
      Me.m_IdShowedObject = IdUtente
      DoLoad()
   End Sub
    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "" & MyBase.State.StateName & "  domande lavoro azienda"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "" & MyBase.State.StateName & "  domande lavoro azienda "
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & " domande lavoro azienda")
        SelectToolStripImage()
    End Sub
    Protected Overrides Sub Nested_PostLoadingActions()
        Dim logo As String = "" & MyBase.State.StateName & "  domande lavoro azienda"
        MasterControl.Instance.ParentForm.Text = logo & " " & UCase(controller.Descrizione)
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo & " " & UCase(controller.Descrizione)
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "   domande lavoro  -  " & UCase(controller.Descrizione))

    End Sub
    Protected Overrides Sub Nested_PostchangeActions()
        Try
            Dim logo As String = "" & MyBase.State.StateName & "   domande lavoro azienda"
            MasterControl.Instance.ParentForm.Text = logo & " " & UCase(controller.Descrizione)
            MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo & " " & UCase(controller.Descrizione)
            Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "   domande lavoro  -  " & UCase(controller.Descrizione))
        Catch ex As Exception
            Nested_NotifyParent()
        End Try

    End Sub

#Region "Metodi per la ricerca"
    Public Overrides Sub DoSearch()
        Me.NiceGroupBox1.Visible = False
        Me.TabControl1.Visible = False
        Me.IdAziendaTextBox1.TextValue = ""
        Me.IdAziendaTextBox1.Visible = True
        Me.IdAziendaTextBox1.Enabled = True
        Me.cmdPrint.Visible = False
        Me.lblId.Visible = True
        MasterControl.Instance.ParentForm.Text = "Ricerca domande lavoro azienda"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Ricerca domande lavoro azieneda"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.SearchPaint
        'Me.CmdVis.Visible = True
        Me.lblCurrentFunction.Text = UCase("Ricerca domande lavoro azienda ")
    End Sub
#End Region

#Region "Metodi per Load iniziale"
    Protected Overrides Sub Nested_PrepareLoading()
        Me.NiceGroupBox1.Visible = True
        Me.TabControl1.Visible = True
        Me.IdAziendaTextBox1.TextValue = ""
        Me.IdAziendaTextBox1.Enabled = False
        Me.IdAziendaTextBox1.Visible = True
        Me.cmdPrint.Visible = True
        Me.lblId.Visible = True
        Me.Nested_NotifyParent()
        ' Me.CmdVis.Visible = False
    End Sub
    Protected Overrides Sub Nested_ClearWindowEditors()

    End Sub
    Protected Overrides Sub Nested_LoadDataFromDataSource()
        'qui carico ordino il caricamento dei dati e carico le possibili scelte
        controller.LoadById(Me.m_IdShowedObject)
    End Sub
    Protected Overrides Sub Nested_LoadEditorsProperties()

        Me.IdAziendaTextBox1.TextValue = controller.IdAzienda
        lblDescrizioneUtente.Text = controller.Descrizione
        Dim listaOfferte As IList = controllerOfferte.GetOfferteByAzienda(Me.m_IdShowedObject)
        'If listaVertenze.Count > 0 Then
        LoadGrid(listaOfferte)
        'Else
        '   PerformDialog()
        'End If
    End Sub
    Private Sub PerformDialog()
        Select Case MsgBox("Non esistono domande di lavoro per l'azienda selezionata. Si desidera creare una nuova domanda? " & vbCrLf & _
                                   "Scegliere Sì per registrare una nuova domanda;" & vbCrLf & _
                                   "Scegliere No per visualizzare l'anagrafica dell'azienda selezionata;" & vbCrLf & _
                                   "Segliere Annulla per riprovare una nuova ricerca.", _
                                   MsgBoxStyle.YesNoCancel + MsgBoxStyle.Exclamation, _
                                   "Visualizzazione dmande di lavoro")
            Case MsgBoxResult.Cancel
                Me.NavigateWithoutHistoryTo("ViewOfferte", True)
            Case MsgBoxResult.Yes
                Me.NavigateWithoutHistoryTo("CreateOfferta", True)
            Case MsgBoxResult.No
                Me.Navigate(m_IdShowedObject, "ViewAzienda")
        End Select
    End Sub


    Private Sub GridOfferte_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles GridOfferte.CellFormatting

        If GridOfferte.Columns(e.ColumnIndex).Name.Equals("AziendaRichiedente") Then
            If Not e.Value Is Nothing Then
                'GridDeleghe.Rows(e.RowIndex).Cells("StatoDelega").Value = e.Value.
                e.Value = e.Value.Descrizione
            End If
        End If

        If GridOfferte.Columns(e.ColumnIndex).Name.Equals("Validita") Then
            If Not e.Value Is Nothing Then
                'GridDeleghe.Rows(e.RowIndex).Cells("StatoDelega").Value = e.Value.
                e.Value = e.Value.ToString
            End If
        End If

    End Sub
    Private Sub GridOfferte_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridOfferte.DoubleClick
        Try
            If GridOfferte.SelectedRows.Count = 1 Then
                Dim SelectedId As Int32 = DirectCast(GridOfferte.SelectedRows.Item(0).Cells("Id").Value, Int32)
                Me.Navigate(SelectedId, "ViewOfferta")
            End If
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try

    End Sub
    Private Sub LoadGrid(ByVal Lista As IList)
        Try
            'GridReferenti.DataSource = Lista
            With GridOfferte

                .DataSource = Lista
                If Lista.Count > 0 Then
                    .AutoGenerateColumns = False

                    .Columns("Key").Visible = False
                    .Columns("Versione").Visible = False
                    .Columns("CreatoDa").Visible = False
                    .Columns("ModificatoDa").Visible = False
                    .Columns("DataCreazione").Visible = False
                    .Columns("DataModifica").Visible = False
                    .Columns("Descrizione").Visible = False
                    .Columns("Selected").Visible = False

                    .Columns("Note").Visible = False

                    .Columns("Id").Visible = False
                    '.Columns("Id").ReadOnly = True
                    '.Columns("Id").DisplayIndex = 0

                    .Columns("Data").Visible = True
                    .Columns("Data").HeaderText = "Data"
                    .Columns("Data").ReadOnly = True
                    .Columns("Data").DisplayIndex = 1



                    .Columns("AziendaRichiedente").Visible = True
                    .Columns("AziendaRichiedente").HeaderText = "Azienda richiedente"
                    .Columns("AziendaRichiedente").ReadOnly = True
                    .Columns("AziendaRichiedente").DisplayIndex = 2


                    .Columns("Validita").Visible = True
                    .Columns("Validita").HeaderText = "Validità"
                    .Columns("Validita").ReadOnly = True
                    .Columns("Validita").DisplayIndex = 3

                    .Columns("GetNumeroTotalePosti").Visible = True
                    .Columns("GetNumeroTotalePosti").HeaderText = "Totale posti"
                    .Columns("GetNumeroTotalePosti").ReadOnly = True
                    .Columns("GetNumeroTotalePosti").DisplayIndex = 4



                    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing
                    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                End If
            End With


        Catch ex As Exception
            Throw New Exception("Impossibile caricare la griglia delle offerte di lavoro per l'azienda" & vbCrLf & ex.Message)
        End Try
    End Sub
#End Region






#Region "Metodi per il salvataggio"

   'Protected Overrides Sub Navigate()
   '   Try
   '      Dim ParameterList As Hashtable = New Hashtable
   '      ParameterList.Add("Id", m_IdShowedObject)
   '      Me.NavigateWithoutHistoryTo("ViewDeleghe")
   '   Catch ex As Exception
   '      Throw New Exception(ex.Message)
   '   End Try
   'End Sub
   Protected Overloads Sub Navigate(ByVal ToId As String)
      Try
         Dim ParameterList As Hashtable = New Hashtable
         ParameterList.Add("Id", ToId)
            Me.NavigateTo("ViewOfferte", ParameterList, True)
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

#End Region



    Private Sub View()
        Try
            Me.m_IdShowedObject = Me.IdAziendaTextBox1.TextValue
            Dim listaOfferte As IList = controllerOfferte.GetOfferteByAzienda(Me.m_IdShowedObject)
            If listaOfferte.Count > 0 Then
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


    Private Sub CmdVis_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs)
        View()
    End Sub


   Private Sub cmdPrint_DoClik(ByVal Sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.DoClik
      Try
         Dim print As PrintFacade = New PrintFacade
         print.PrintReportListaOfferteLavoro(controllerOfferte.GetOfferteByAzienda(Me.m_IdShowedObject))
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub


   Private Sub SpNew_DoClik(ByVal Sender As Object, ByVal e As System.EventArgs) Handles SpNew.DoClik
      Try
         Dim id As Int32
         Try
            id = CType(IdAziendaTextBox1.TextValue, Int32)
         Catch ex As InvalidCastException
            id = -1
         Catch ex As OverflowException
            id = -1
         End Try


         If id = -1 Then
                Me.NavigateWithoutHistoryTo("CreateOfferta", True)
         Else

            Dim hash As New Hashtable
            hash.Add("IdAzienda", IdAziendaTextBox1.TextValue)
                Me.NavigateWithoutHistoryTo("CreateOfferta", hash, True)
         End If
      Catch ex As AccessDeniedException
         MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")

      End Try
   End Sub


    Private Sub IdAziendaTextBox1_ReturnPressed() Handles IdAziendaTextBox1.ReturnPressed
        View()
    End Sub
End Class
