
Imports System.Windows.Forms
Public Class SearchListaUtenti
   Implements IFrmSearch
   Private SearchController As New ControllerListaUtenti
   Private m_SelectedId As Int32 = -1
   Dim controllerRicerche As New WIN.APPLICATION.FINANCIAL_ARTIFACTS.ControllerRicercheReferenti
    Private m_SelectedDescription As String = ""


    Private m_lista As ListaLavoroUtenti


   Public ReadOnly Property SelectedDescription() As String Implements IFrmSearch.SelectedDescription
      Get
         Return m_SelectedDescription
      End Get
   End Property
   Public ReadOnly Property SelectedId() As Int32 Implements IFrmSearch.SelectedId
      Get
         Return m_SelectedId
      End Get
   End Property
   Public Sub New()
      ' Chiamata richiesta da Progettazione Windows Form.
      InitializeComponent()
      ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
      Me.DialogResult = Windows.Forms.DialogResult.Cancel
   End Sub
   Private Sub cmdCerca_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCerca.Click
      Try
         Dim lista As New ArrayList
         'lista = SearchController.GetAll

         
         lista = SearchController.GetListeByDescrizione(Me.txtDescrizione.Text)
         If lista.Count = 0 Then
            MsgBox("Non è stato trovato alcun elemento che soddisfa i requisiti richiesti!", MsgBoxStyle.Information, "Nessun elemento trovato")
            'Exit Sub
         End If
         LoadGrid(lista)
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub
   Private Sub LoadGrid(ByVal Lista As ArrayList)

      'GridReferenti.DataSource = Lista
      With GridReferenti

         .DataSource = Lista
         If Lista.Count > 0 Then
            .AutoGenerateColumns = False

            .Columns("Key").Visible = False
            .Columns("Versione").Visible = False
            .Columns("CreatoDa").Visible = False
            .Columns("ModificatoDa").Visible = False
            .Columns("DataCreazione").Visible = False
            .Columns("DataModifica").Visible = False
                .Columns("NonCancellabile").Visible = False
            .Columns("HasAdded").Visible = False

            .Columns("Id").Visible = True
            .Columns("Id").ReadOnly = True
            .Columns("Id").DisplayIndex = 0


            .Columns("Descrizione").Visible = True
            .Columns("Descrizione").ReadOnly = True
            .Columns("Descrizione").DisplayIndex = 1

         End If
         .SelectionMode = DataGridViewSelectionMode.FullRowSelect
         .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
         .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells


      End With



   End Sub

   Private Sub GridReferenti_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GridReferenti.MouseDoubleClick
      Try
         Seleziona()
      Catch ex As Exception
         Throw New Exception(ex.Message)
      End Try
   End Sub


   Private Sub Seleziona()
      If GridReferenti.SelectedRows.Count = 1 Then
            m_SelectedId = DirectCast(GridReferenti.SelectedRows.Item(0).Cells("Id").Value, Int32)
            m_lista = DirectCast(GridReferenti.SelectedRows(0).DataBoundItem, ListaLavoroUtenti)
         m_SelectedDescription = DirectCast(GridReferenti.SelectedRows(0).DataBoundItem, ListaLavoroUtenti).Descrizione
         Me.DialogResult = Windows.Forms.DialogResult.OK
         Me.Close()
      Else
         MsgBox("Selezionare una lista!")
      End If
   End Sub



    Public ReadOnly Property ListaLavoroSelezionata()
        Get
            Return m_lista
        End Get
    End Property


End Class
