
Imports System.Windows.Forms
Imports System.Drawing.Drawing2D
Imports WIN.SECURITY.Exceptions

Public Class ControlVisualizzatoreComunicazioni
   Private controller As New WIN.APPLICATION.UTENTI.ControllerUtenti
   Private controllerComunicazioni As New ControllerComunicazioni
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
        MasterControl.Instance.ParentForm.Text = "" & MyBase.State.StateName & "  comunicazioni utente"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "" & MyBase.State.StateName & "  comunicazioni utente "
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & " comunicazioni utente")
        SelectToolStripImage()
    End Sub
    Protected Overrides Sub Nested_PostLoadingActions()
        Dim logo As String = "" & MyBase.State.StateName & "  comunicazioni utente"
        MasterControl.Instance.ParentForm.Text = logo & " " & UCase(controller.CompleteName)
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo & " " & UCase(controller.CompleteName)
        Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "   comunicazioni  -  " & UCase(controller.CompleteName))

    End Sub
    Protected Overrides Sub Nested_PostchangeActions()
        Try
            Dim logo As String = "" & MyBase.State.StateName & "   comunicazioni utente"
            MasterControl.Instance.ParentForm.Text = logo & " " & UCase(controller.CompleteName)
            MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = logo & " " & UCase(controller.CompleteName)
            Me.lblCurrentFunction.Text = UCase("" & MyBase.State.StateName & "   comunicazioni  -  " & UCase(controller.CompleteName))
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
        MasterControl.Instance.ParentForm.Text = "Ricerca comunicazioni utente"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Text = "Ricerca comunicazioni utente"
        MasterControl.Instance.GetMdi.ToolStripStatusLabel1.Image = My.Resources.SearchPaint
        'Me.CmdVis.Visible = True
        Me.cmdPrint.Visible = False
        Me.lblCurrentFunction.Text = UCase("Ricerca comunicazioni utente ")
    End Sub
#End Region

#Region "Metodi per Load iniziale"
    Protected Overrides Sub Nested_PrepareLoading()
        Me.NiceGroupBox1.Visible = True
        Me.TabControl1.Visible = True
        Me.IdUtenteTextBox1.TextValue = ""
        Me.IdUtenteTextBox1.Enabled = False
        Me.IdUtenteTextBox1.Visible = True
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

        Me.IdUtenteTextBox1.TextValue = controller.IdUtente
        lblDescrizioneUtente.Text = controller.CompleteName
        Dim listaComunicazioni As IList = controllerComunicazioni.GetComunicazioniByUtente(Me.m_IdShowedObject)

        'If listaVertenze.Count > 0 Then
        LoadGrid(listaComunicazioni)
        'Else
        '   PerformDialog()
        'End If
    End Sub
    Private Sub PerformDialog()
        Select Case MsgBox("Non esistono comunicazioni per l'utente selezionato. Si desidera creare una nuova comunicazione? " & vbCrLf & _
                                   "Scegliere Sì per registrare una nuova  comunicazione;" & vbCrLf & _
                                   "Scegliere No per visualizzare l'anagrafica dell'utente selezionato;" & vbCrLf & _
                                   "Segliere Annulla per riprovare una nuova ricerca.", _
                                   MsgBoxStyle.YesNoCancel + MsgBoxStyle.Exclamation, _
                                   "Visualizzazione comunicazione")
            Case MsgBoxResult.Cancel
                Me.NavigateWithoutHistoryTo("ViewComunicazioni", True)
            Case MsgBoxResult.Yes
                Me.NavigateWithoutHistoryTo("CreateComunicazione", True)
            Case MsgBoxResult.No
                Me.Navigate(m_IdShowedObject, "ViewUtente")
        End Select
    End Sub


    Private Sub GridProposte_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles GridProposte.CellFormatting



        'If GridProposte.Columns(e.ColumnIndex).Name.Equals("Utente") Then
        '   If Not e.Value Is Nothing Then
        '      'GridDeleghe.Rows(e.RowIndex).Cells("StatoDelega").Value = e.Value.
        '      e.Value = e.Value.CompleteName
        '   End If
        'End If



    End Sub
    Private Sub GridProposte_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridProposte.DoubleClick
        Try
            If GridProposte.SelectedRows.Count = 1 Then
                Dim SelectedId As Int32 = DirectCast(GridProposte.SelectedRows.Item(0).Cells("Id").Value, Int32)
                Me.Navigate(SelectedId, "ViewComunicazione")
            End If
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try

    End Sub
    Private Sub LoadGrid(ByVal Lista As IList)

        'GridReferenti.DataSource = Lista
        With GridProposte

            .DataSource = Lista
            If Lista.Count > 0 Then
                .AutoGenerateColumns = False

                .Columns("Key").Visible = False

                .Columns("NomeUtente").Visible = False
                .Columns("NomeTipoComunicazione").Visible = False
                .Columns("NomeCausale").Visible = False

                .Columns("Versione").Visible = False
                .Columns("CreatoDa").Visible = False
                .Columns("ModificatoDa").Visible = False
                .Columns("DataCreazione").Visible = False
                .Columns("DataModifica").Visible = False
                .Columns("Descrizione").Visible = False
                .Columns("Allegato").Visible = False
                .Columns("Note").Visible = False
                .Columns("Utente").Visible = False


                .Columns("Id").Visible = True
                .Columns("Id").DisplayIndex = 0


                '.Columns("Utente").HeaderText = "Utente"
                '.Columns("Utente").ReadOnly = True
                '.Columns("Utente").DisplayIndex = 0

                .Columns("DataDocumento").Visible = True
                .Columns("DataDocumento").HeaderText = "Data"
                .Columns("DataDocumento").ReadOnly = True
                .Columns("DataDocumento").DisplayIndex = 1



                .Columns("Causale").Visible = True
                .Columns("Causale").HeaderText = "Causale comunicazione"
                .Columns("Causale").ReadOnly = True
                .Columns("Causale").DisplayIndex = 2


                .Columns("Tipo").Visible = True
                .Columns("Tipo").HeaderText = "Tipo comunicazione"
                .Columns("Tipo").ReadOnly = True
                .Columns("Tipo").DisplayIndex = 3




                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing
                .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

            End If
        End With



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
            Me.NavigateTo("ViewComunicazioni", ParameterList, True)
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
            Me.m_IdShowedObject = Me.IdUtenteTextBox1.TextValue
            Dim listaProposte As IList = controllerComunicazioni.GetComunicazioniByUtente(Me.m_IdShowedObject)
            If listaProposte.Count > 0 Then
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
         print.PrintReportListaComunicazioni(controllerComunicazioni.GetComunicazioniByUtente(Me.m_IdShowedObject))
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
                Me.NavigateWithoutHistoryTo("CreateComunicazione", True)
         Else

            Dim hash As New Hashtable
            hash.Add("IdUtente", IdUtenteTextBox1.TextValue)
                Me.NavigateWithoutHistoryTo("CreateComunicazione", hash, True)
         End If
      Catch ex As AccessDeniedException
         MsgBox("Impossibile accedere alla funzionalità richiesta. Accesso negato", MsgBoxStyle.Information, "Accesso negato")

      End Try
   End Sub

    Private Sub IdUtenteTextBox1_ReturnPressed() Handles IdUtenteTextBox1.ReturnPressed
        View()
    End Sub

    Private Sub ControlVisualizzatoreComunicazioni_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        IdUtenteTextBox1.SetFocus()
    End Sub
End Class


