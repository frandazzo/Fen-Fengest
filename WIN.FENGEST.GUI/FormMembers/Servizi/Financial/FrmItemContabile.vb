Imports WIN.APPLICATION.FINANCIAL_ARTIFACTS
Public Class FrmItemContabile
   Public Event EventAdded()
   Public Event EventUpdated()
   Private m_operation As String = "View"
   Private m_TipoDoc As String = ""
   Private m_controller As AbstractDocumentController

   '''' <summary>
   '''' Costruttore del form
   '''' </summary>
   '''' <param name="Controller"></param>
   '''' <param name="IdDocumento"></param>
   '''' <param name="IdPosizione"></param>
   '''' <param name="TipoDocumento"></param>
   '''' <remarks></remarks>
   'Public Sub New(ByVal Controller As AbstractDocumentController, ByVal IdDocumento As String, ByVal IdPosizione As String, ByVal TipoDocumento As String)
   '   InitializeComponent()
   '   Me.ControlItemContabile1.SetController(Controller)
   '   m_controller = Controller
   '   'Me.ControlItemContabile1.SetDocumentData(IdDocumento, IdPosizione, TipoDocumento)
   '   m_TipoDoc = TipoDocumento
   'End Sub

   Public Sub New()

      ' Chiamata richiesta da Progettazione Windows Form.
      InitializeComponent()

      ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

   End Sub

   ''' <summary>
   ''' Costruttore del form
   ''' </summary>
   ''' <param name="Operation">I valori ammessi sono: "View", "Add"</param>
   ''' <param name="Controller"></param>
   ''' <param name="TipoDocumento"></param>
   ''' <remarks></remarks>
   Public Sub New(ByVal Operation As String, ByVal Controller As AbstractDocumentController, ByVal TipoDocumento As String)
      InitializeComponent()
      m_operation = Operation
      m_controller = Controller
      Me.ControlItemContabile1.SetController(Controller)
      m_TipoDoc = TipoDocumento
   End Sub
   Private Sub FrmItemContabile_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
      Select Case m_operation
         Case "View"
                Me.ControlItemContabile1.StartLoadOperation()
         Case "Add"
                Me.ControlItemContabile1.StartCreateOperation()
            Me.cmdOk.Enabled = False
            Me.cmdAdd.Enabled = True
      End Select

   End Sub

   Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
      Try
         If Me.ControlItemContabile1.State.StateName = "Aggiornamento" Then
            DocumentMediatorFactory.GetDocumentMediator(m_TipoDoc).SetItemProperties(Me, m_controller)
            RaiseEvent EventUpdated()
         End If
         Me.Close()
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub


   Private Sub cmdAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnnulla.Click
      Me.Close()
   End Sub



   Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
      Try
         DocumentMediatorFactory.GetDocumentMediator(m_TipoDoc).AddNewItem(Me, m_controller)
         RaiseEvent EventAdded()
         Me.Close()
      Catch ex As Exception
         'Me.m_IsEventoAdded = False
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

    Private Sub ControlItemContabile1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ControlItemContabile1.Load

    End Sub
End Class