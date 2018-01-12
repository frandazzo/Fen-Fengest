Imports System.Windows.Forms
Imports System.Drawing.Drawing2D
Imports WIN.SECURITY.Exceptions

Public Class ControlVisualizzaVertenze
   Private controller As New UTENTI.ControllerUtenti
   Private controllerVertenze As New ADMINISTRATION.ControllerVertenze
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
      Try
         DoLoad()
      Catch ex As Exception
         'ErrorHandler.ShowError(ex)
         Throw New Exception(ex.Message)
      End Try
   End Sub
    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "" & MyBase.State.StateName & "  vertenze utente"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "" & MyBase.State.StateName & "  vertenze utente "
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & " vertenze utente")
        SelectToolStripImage()
    End Sub
    Protected Overrides Sub Nested_PostLoadingActions()
        Dim logo As String = "" & MyBase.State.StateName & "  vertenze utente"
        MasterControl.Instance.ParentForm.Text = logo & " " & UCase(controller.CompleteName)
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo & " " & UCase(controller.CompleteName)
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  vertenze  -  " & UCase(controller.CompleteName))

    End Sub
    Protected Overrides Sub Nested_PostchangeActions()
        Try
            Dim logo As String = "" & MyBase.State.StateName & "  vertenze utente"
            MasterControl.Instance.ParentForm.Text = logo & " " & UCase(controller.CompleteName)
            MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo & " " & UCase(controller.CompleteName)
            Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "  vertenze  -  " & UCase(controller.CompleteName))
        Catch ex As Exception
            Nested_NotifyParent()
        End Try

    End Sub

#Region "Metodi per la ricerca"
    Public Overrides Sub DoSearch()
        Me.NiceGroupBox1.Visible = False
        Me.TabControl1.Visible = False
        Me.IdUtenteTextBox1.TextValue = ""
        Me.IdUtenteTextBox1.Visible = True
        Me.IdUtenteTextBox1.Enabled = True
        Me.lblId.Visible = True
        Me.cmdPrint.Visible = False
        MasterControl.Instance.ParentForm.Text = "Ricerca vertenze utente"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Ricerca vertenze utente"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.SearchPaint
        ' Me.CmdVis.Visible = True
        Me.lblCurrentFunction.Text = UCase("Ricerca   vertenze   utente ")
    End Sub
#End Region

#Region "Metodi per Load iniziale"
    Protected Overrides Sub Nested_PrepareLoading()
        Me.TabControl1.Visible = True
        Me.IdUtenteTextBox1.TextValue = ""
        Me.IdUtenteTextBox1.Enabled = False
        Me.IdUtenteTextBox1.Visible = True
        Me.lblId.Visible = True
        Me.Nested_NotifyParent()
        Me.cmdPrint.Visible = True
        'Me.CmdVis.Visible = False

        Me.NiceGroupBox1.Visible = True
    End Sub
    Protected Overrides Sub Nested_ClearWindowEditors()

    End Sub
    Protected Overrides Sub Nested_LoadDataFromDataSource()
        'qui carico ordino il caricamento dei dati e carico le possibili scelte
        controller.LoadById(Me.m_IdShowedObject)
    End Sub
    Protected Overrides Sub Nested_LoadEditorsProperties()

        Me.IdUtenteTextBox1.TextValue = controller.IdUtente
        lblDescrizioneUtente.Text = controller.CompleteName
        Dim listaVertenze As IList = controllerVertenze.GetVertenzeByUtente(Me.m_IdShowedObject)
        'If listaVertenze.Count > 0 Then
        LoadGrid(listaVertenze)
        'Else
        '   PerformDialog()
        'End If
    End Sub
    Private Sub PerformDialog()
        Select Case MsgBox("Non esistono vertenze per l'utente selezionato. Si desidera creare una nuova vertenza? " & vbCrLf & _
                                   "Scegliere Sì per registrare una nuova vertenza;" & vbCrLf & _
                                   "Scegliere No per visualizzare l'anagrafica dell'utente selezionato;" & vbCrLf & _
                                   "Segliere Annulla per riprovare una nuova ricerca.", _
                                   MsgBoxStyle.YesNoCancel + MsgBoxStyle.Exclamation, _
                                   "Visualizzazione vertenze")
            Case MsgBoxResult.Cancel
                Me.NavigateWithoutHistoryTo("ViewVertenze", True)
            Case MsgBoxResult.Yes
                Me.NavigateWithoutHistoryTo("CreateVertenza", True)
            Case MsgBoxResult.No
                Me.Navigate(m_IdShowedObject, "ViewUtente")
        End Select
    End Sub


    Private Sub GridDeleghe_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles GridVertenze.CellFormatting
        Try
            If GridVertenze.Columns(e.ColumnIndex).Name.Equals("Utente") Then
                If Not e.Value Is Nothing Then
                    'GridDeleghe.Rows(e.RowIndex).Cells("StatoDelega").Value = e.Value.
                    e.Value = e.Value.CompleteName
                End If
            End If
            If GridVertenze.Columns(e.ColumnIndex).Name.Equals("Azienda") Then
                If Not e.Value Is Nothing Then
                    'GridDeleghe.Rows(e.RowIndex).Cells("StatoDelega").Value = e.Value.
                    e.Value = e.Value.Descrizione
                End If
            End If
            If GridVertenze.Columns(e.ColumnIndex).Name.Equals("PeriodoVertenza") Then
                If Not e.Value Is Nothing Then
                    'GridDeleghe.Rows(e.RowIndex).Cells("StatoDelega").Value = e.Value.
                    e.Value = e.Value.ToString
                End If
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Private Sub GridDeleghe_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridVertenze.DoubleClick
        Try
            If GridVertenze.SelectedRows.Count = 1 Then
                Dim SelectedId As Int32 = DirectCast(GridVertenze.SelectedRows.Item(0).Cells("Id").Value, Int32)
                Me.Navigate(SelectedId, "ViewVertenza")
            End If
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try

    End Sub
    Private Sub LoadGrid(ByVal Lista As IList)
        Try
            'GridReferenti.DataSource = Lista
            With GridVertenze

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
                    .Columns("DataRegistrazione").Visible = False
                    .Columns("TipoDocumento").Visible = False
                    .Columns("Quota").Visible = False
                    .Columns("Referente").Visible = False
                    .Columns("ReferenteI").Visible = False
                    .Columns("RUP").Visible = False
                    .Columns("Note").Visible = False

                    .Columns("Id").Visible = True
                    .Columns("Id").ReadOnly = True
                    .Columns("Id").DisplayIndex = 0

                    .Columns("DataDocumento").Visible = True
                    .Columns("DataDocumento").HeaderText = "Data vertenza"
                    .Columns("DataDocumento").ReadOnly = True
                    .Columns("DataDocumento").DisplayIndex = 1

                    .Columns("Utente").Visible = True
                    .Columns("Utente").ReadOnly = True
                    .Columns("Utente").DisplayIndex = 2

                    .Columns("Azienda").Visible = True
                    .Columns("Azienda").HeaderText = "Azienda controparte"
                    .Columns("Azienda").ReadOnly = True
                    .Columns("Azienda").DisplayIndex = 3


                    .Columns("PeriodoVertenza").Visible = True
                    .Columns("PeriodoVertenza").HeaderText = "Periodo  vertenza"
                    .Columns("PeriodoVertenza").ReadOnly = True
                    .Columns("PeriodoVertenza").DisplayIndex = 4




                    .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                    .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing
                    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

                End If
            End With


        Catch ex As Exception
            Throw New Exception("Impossibile caricare la griglia delle vertenze per l'utente" & vbCrLf & ex.Message)
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
            Me.NavigateTo("ViewVertenze", ParameterList, True)
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
   'Protected Overloads Sub Navigate(ByVal ToId As String, ByVal Status As String, ByVal Link As String)
   '   Try
   '      Dim ParameterList As Hashtable = New Hashtable
   '      ParameterList.Add("Id", ToId)
   '      ParameterList.Add("Status", Status)
   '      ParameterList.Add("IdUtente", Me.m_IdShowedObject)
   '      Me.NavigateTo(Link, ParameterList)
   '   Catch ex As Exception
   '      Throw New Exception(ex.Message)
   '   End Try
   'End Sub

#End Region




    Private Sub View()
        Try
            Me.m_IdShowedObject = Me.IdUtenteTextBox1.TextValue
            Dim listaVertenze As IList = controllerVertenze.GetVertenzeByUtente(Me.m_IdShowedObject)
            If listaVertenze.Count > 0 Then
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
         print.PrintListaVertenze(controllerVertenze)
      Catch ex As Exception
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
                Me.NavigateTo("CreateVertenza", True)
         Else

            Dim hash As New Hashtable
            hash.Add("IdUtente", IdUtenteTextBox1.TextValue)
                Me.NavigateWithoutHistoryTo("CreateVertenza", hash, True)
         End If
      Catch ex As AccessDeniedException
         MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")

      End Try
   End Sub

    Private Sub IdUtenteTextBox1_ReturnPressed() Handles IdUtenteTextBox1.ReturnPressed
        View()
    End Sub

    Private Sub ControlVisualizzaVertenze_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IdUtenteTextBox1.SetFocus()
    End Sub
End Class