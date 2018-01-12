Public Class ControlSaldoConto
   Private controllerConti As New CONTI.ControllerConti
   Public Sub New()
      InitializeComponent()
      Try
         DoLoad()
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub
  
    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "" & MyBase.State.StateName & " saldo conto"
    End Sub
   Public Overrides Sub DoLoad()
        Nested_PrepareLoading()
        Nested_ClearWindowEditors()
   End Sub


#Region "Metodi per Load iniziale"
    Protected Overrides Sub Nested_PrepareLoading()

        MasterControl.Instance.ParentForm.Text = "Visualizzazione saldo conto"
        Me.optI.Checked = True
        Singolo.Visible = False
        Intervallo.Visible = True
    End Sub
    Protected Overrides Sub Nested_ClearWindowEditors()
        'Qui pulisco tutti i campi della maschera
        Me.txtSaldo.Text = ""
        Me.IdContoTextBox1.TextValue = ""

    End Sub

#End Region



   Private Sub optI_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optI.Click
      If optI.Checked = True Then
         Singolo.Visible = False
         Intervallo.Visible = True
      Else
         Singolo.Visible = True
         Intervallo.Visible = False
      End If
   End Sub

   Private Sub optS_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optS.Click
      If optS.Checked = True Then
         Singolo.Visible = True
         Intervallo.Visible = False
      Else
         Singolo.Visible = False
         Intervallo.Visible = True
      End If
   End Sub

   Private Sub cmdSaldo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSaldo.Click
      Try
         Dim importo As String = ""
         Dim valuta As String
         controllerConti.LoadById(Me.IdContoTextBox1.TextValue)
         valuta = controllerConti.Valuta
         Select Case optI.Checked
            Case True
               importo = controllerConti.BalanceAmount(dtpDa.Value, DtpA.Value)
            Case False
               importo = controllerConti.BalanceAmount(dtpFino.Value)
         End Select
         txtSaldo.Text = importo & " " & valuta
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Private Sub IdContoTextBox1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles IdContoTextBox1.Leave
      Try
         controllerConti.LoadById(Me.IdContoTextBox1.TextValue)
         lblNomeConto.Text = controllerConti.Descrizione
      Catch ex As Exception
         lblNomeConto.Text = ""
      End Try
   End Sub
End Class
