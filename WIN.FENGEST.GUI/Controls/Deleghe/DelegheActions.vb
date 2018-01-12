Imports System.Windows.Forms

Public Class DelegheActions
   Private Azione As Action
   Public DataInoltro As DateTime
   Public DataFineCiclo As DateTime
   Public DataAccettazione As DateTime
   'Public IdEnteAccettante As String
   Public Causale As String
   'Public AccettataDaEntrambi As Boolean = False
   Private isForEdilizia As Boolean
   'Dim controllerenti As New AZIENDE.ControllerEntiBilaterali
   Private Sub SetUpComboCausali()
      Try
         Dim controller As New ControllerCausaliRevoca
         cboCausali.Items.Clear()
         Dim list As ArrayList = controller.GetListaCausali
         For Each elem As String In list
            Me.cboCausali.Items.Add(elem)
         Next
         Me.cboCausali.Items.Add("")
         Me.cboCausali.Sorted = True
         Me.cboCausali.SelectedIndex = 0
      Catch ex As Exception
         Throw New Exception("Impossibile impostare il combo delle causali." & vbCrLf & ex.Message)
      End Try
   End Sub
   'Private Sub SetUpComboEnti()
   '   Try

   '      CboEnti.Items.Clear()
   '      Dim list As Hashtable = controllerEnti.GetListaEnti
   '      Dim en As IDictionaryEnumerator = list.GetEnumerator
   '      Do While en.MoveNext
   '         Me.CboEnti.Items.Add(en.Value)
   '      Loop
   '      CboEnti.Items.Add("ENTRAMBI")
   '      Me.CboEnti.SelectedIndex = 0
   '   Catch ex As Exception
   '      Throw New Exception("Impossibile impostare il combo degli enti ." & vbCrLf & ex.Message)
   '   End Try
   'End Sub
   Public Enum Action
      Inoltra
      Accetta
      Annulla
      Revoca
   End Enum
   Public Sub OpenForInoltro()
      Azione = Action.Inoltra
      Inoltro.Visible = True
      Accettazione.Visible = False
      Revoca.Visible = False
      Me.Text = "Inoltro delega"
   End Sub
   Public Sub OpenForCancel()
      Azione = Action.Annulla
      Inoltro.Visible = False
      Accettazione.Visible = False
      Revoca.Visible = True
      Revoca.Text = "Annullamento delega"
      lblRevoca.Text = "Data annullamento"
      Me.Text = "Annullamento delega"
      SetUpComboCausali()
   End Sub
   Public Sub OpenForRevoca()
      Azione = Action.Revoca
      Inoltro.Visible = False
      Accettazione.Visible = False
      Revoca.Visible = True
      SetUpComboCausali()
      Me.Text = "Revoca delega"
   End Sub
   Public Sub OpenForAccettazione(ByVal ForSettoreEdile As Boolean)
      isForEdilizia = ForSettoreEdile
      'lblEnte.Visible = False
      'CboEnti.Visible = False
      Azione = Action.Accetta
      Inoltro.Visible = False
      Accettazione.Visible = True
      'If ForSettoreEdile Then
      '   SetUpComboEnti()
      '   lblEnte.Visible = True
      '   CboEnti.Visible = True
      'End If
      Revoca.Visible = False
      Me.Text = "Accettazione delega"
   End Sub

   Private Sub Commit()
      Select Case Azione
         Case Action.Inoltra
            DataInoltro = dtpInoltro.Value
         Case Action.Accetta
            DataAccettazione = dtpAccettazione.Value
            'If isForEdilizia Then
            '   Select Case CboEnti.Text

            '      Case "ENTRAMBI"
            '         IdEnteAccettante = -1
            '         AccettataDaEntrambi = True
            '      Case Else
            '         IdEnteAccettante = controllerenti.GetIdEnteByDescrizione(CboEnti.Text)
            '   End Select
            'End If
         Case Action.Revoca
            DataFineCiclo = Me.dtpDatarevoca.Value
            Causale = cboCausali.Text
         Case Action.Annulla
            DataFineCiclo = Me.dtpDatarevoca.Value
            Causale = cboCausali.Text
      End Select

   End Sub

   Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
      Try
         Commit()
         Me.DialogResult = System.Windows.Forms.DialogResult.OK
         Me.Close()
      Catch ex As Exception
         Throw New Exception(ex.Message)
      End Try
   End Sub


   Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
      Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
      Me.Close()
   End Sub


 
End Class
