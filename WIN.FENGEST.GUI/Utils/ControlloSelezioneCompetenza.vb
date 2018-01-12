Public Class ControlloSelezioneCompetenza
   Private m_MinDate As DateTime = Date.MinValue
   Private m_MaxDate As DateTime = Date.MaxValue
   Public Event ChangeCompetenza(ByVal Competenza As String)
   Private m_error As String = ""



   Public ReadOnly Property MinDate() As DateTime
      Get
         Return m_MinDate
      End Get
   End Property
   Public ReadOnly Property MaxDate() As DateTime
      Get
         Return m_MaxDate
      End Get
   End Property
   Public Sub New()

      ' Chiamata richiesta da Progettazione Windows Form.
      InitializeComponent()

      ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
      optPM.Checked = True
      SetDefaultPeriodiMensili()
      FrmPM.Visible = True
      FrmPS.Visible = False
      FrmID.Visible = False
      FrmDS.Visible = False


      CalcolaDate()
      RaiseEvent ChangeCompetenza(Label9.Text)
   End Sub

   Private Sub ControlloSelezioneCompetenza_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      optPM.Checked = True
      SetDefaultPeriodiMensili()
      FrmPM.Visible = True
      FrmPS.Visible = False
      FrmID.Visible = False
      FrmDS.Visible = False


      CalcolaDate()
      RaiseEvent ChangeCompetenza(Label9.Text)
   End Sub

   Private Sub SetDefaultPeriodiMensili()
      cboMI.Text = GetMeseByNumero(Today.Month)
      txtAi.Text = Today.Year

      cboMF.Text = GetMeseByNumero(Today.Month)
      txtAf.Text = Today.Year

      m_MinDate = New DateTime(Today.Year, Today.Month, 1)
      m_MaxDate = New DateTime(Today.Year, Today.Month, Date.DaysInMonth(Today.Year, Today.Month))

   End Sub

   Private Sub SetDefaultPeriodoSingolo()
      cboM.Text = GetMeseByNumero(Today.Month)
      txtA.Text = Today.Year
      m_MinDate = New DateTime(Today.Year, Today.Month, 1)
      m_MaxDate = New DateTime(Today.Year, Today.Month, Date.DaysInMonth(Today.Year, Today.Month))

   End Sub

   Private Sub SetDefaultIntervalloDate()
      dtpDI.Value = Today
      dtpDF.Value = Today
      m_MinDate = Today
      m_MaxDate = Today
   End Sub

   Private Sub SetDefaultDataSingola()
      dtpData.Value = Today
      m_MinDate = Today
      m_MaxDate = Today
   End Sub
   Private Sub optPM_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optPM.CheckedChanged
      If optPM.Checked = True Then
         SetDefaultPeriodiMensili()
         FrmPM.Visible = True
         FrmPS.Visible = False
         FrmID.Visible = False
         FrmDS.Visible = False
      End If

      CalcolaDate()
      RaiseEvent ChangeCompetenza(Label9.Text)
   End Sub

   Private Sub optPS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optPS.CheckedChanged
      If optPS.Checked = True Then
         SetDefaultPeriodoSingolo()
         FrmPM.Visible = False
         FrmPS.Visible = True
         FrmID.Visible = False
         FrmDS.Visible = False
      End If

      CalcolaDate()
      RaiseEvent ChangeCompetenza(Label9.Text)
   End Sub

   Private Sub optID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optID.CheckedChanged
      If optID.Checked = True Then
         SetDefaultIntervalloDate()
         FrmPM.Visible = False
         FrmPS.Visible = False
         FrmID.Visible = True
         FrmDS.Visible = False
      End If

      CalcolaDate()
      RaiseEvent ChangeCompetenza(Label9.Text)
   End Sub

   Private Sub optDS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optDS.CheckedChanged
      If optDS.Checked = True Then
         SetDefaultDataSingola()
         FrmPM.Visible = False
         FrmPS.Visible = False
         FrmID.Visible = False
         FrmDS.Visible = True
      End If

      CalcolaDate()
      RaiseEvent ChangeCompetenza(Label9.Text)
   End Sub

   Public ReadOnly Property ErrorText() As String
      Get
         Return m_error
      End Get
   End Property

   Public Sub CalcolaDate()
      Try
         m_error = ""
         If optPM.Checked Then
            m_MinDate = New DateTime(ValidateYear(Me.txtAi.Text), ValidateMese(GetNumeroMeseByName(Me.cboMI.Text)), 1)
            Dim dayAfter As DateTime = New DateTime(ValidateYear(Me.txtAf.Text), ValidateMese(GetNumeroMeseByName(Me.cboMF.Text)), 1)
            dayAfter = dayAfter.AddMonths(1)
            m_MaxDate = dayAfter.AddDays(-1)
         ElseIf optPS.Checked Then
            m_MinDate = New DateTime(ValidateYear(Me.txtA.Text), ValidateMese(GetNumeroMeseByName(Me.cboM.Text)), 1)
            Dim dayAfter As DateTime = New DateTime(ValidateYear(Me.txtA.Text), ValidateMese(GetNumeroMeseByName(Me.cboM.Text)) + 1, 1)
            m_MaxDate = dayAfter.AddDays(-1)
         ElseIf optID.Checked Then
            m_MinDate = CDate(Format(dtpDI.Value, "dd/MM/yyyy"))
            m_MaxDate = CDate(Format(dtpDF.Value, "dd/MM/yyyy"))
         ElseIf optDS.Checked Then
            m_MinDate = CDate(Format(dtpData.Value, "dd/MM/yyyy"))
            m_MaxDate = CDate(Format(dtpData.Value, "dd/MM/yyyy"))
         End If
         ValidateDate()
         RaiseEvent ChangeCompetenza(Label9.Text)
      Catch ex As Exception
         m_error = ex.Message
         'ErrorHandler.ShowError(ex)
         'SetDefaultValues()
         RaiseEvent ChangeCompetenza(Label9.Text)
      End Try
   End Sub
   Private Sub SetDefaultValues()
      If optPM.Checked Then
         Me.SetDefaultPeriodiMensili()
      ElseIf optPS.Checked Then
         Me.SetDefaultPeriodoSingolo()
      ElseIf optID.Checked Then
         Me.SetDefaultIntervalloDate()
      ElseIf optDS.Checked Then
         Me.SetDefaultDataSingola()
      End If
   End Sub
   Private Sub ValidateDate()
      If m_MaxDate < m_MinDate Then
         Label9.Text = "Intervallo nullo"
         Throw New Exception("L'intervallo di tempo selezionato è negativo. Ripetere la selezione")
      End If
      Label9.Text = "Dal " & Format(m_MinDate, "dd/MM/yyyy") & " al " & Format(m_MaxDate, "dd/MM/yyyy")
   End Sub

   Private Function ValidateMese(ByVal Numero As Integer) As Integer
      Try
         If Not IsNumeric(Numero) Then Throw New Exception("Il mese inserito non è corretto. Correggerlo.")
         If Numero = -1 Then
            Throw New Exception("Il mese inserito non è corretto! ")
         End If
         Return Numero
      Catch ex As Exception
         Throw New Exception(ex.Message & vbCrLf & "Inserirne uno corretto.")
      End Try
   End Function
   Private Function ValidateYear(ByVal Year As String) As Integer
      Try
         If Not IsNumeric(Year) Then Throw New Exception("L'anno inserito non è corretto. Correggerlo.")
         Dim y As Integer = CInt(Year)
         If y > 2050 And y < 1980 Then
            Throw New Exception("L'anno inserito non è compreso in un intervallo possibile! ")
         End If
         Return y
      Catch ex As Exception
         Throw New Exception(ex.Message & vbCrLf & " Inserirne uno corretto")
      End Try
   End Function
   Private Function GetNumeroMeseByName(ByVal Name As String) As Integer
      Select Case Name
         Case "Gennaio" : Return 1
         Case "Febbraio" : Return 2
         Case "Marzo" : Return 3
         Case "Aprile" : Return 4
         Case "Maggio" : Return 5
         Case "Giugno" : Return 6
         Case "Luglio" : Return 7
         Case "Agosto" : Return 8
         Case "Settembre" : Return 9
         Case "Ottobre" : Return 10
         Case "Novembre" : Return 11
         Case "Dicembre" : Return 12
         Case Else : Return -1
      End Select
   End Function
   Private Function GetMeseByNumero(ByVal num As Integer) As String
      Select Case num
         Case 1 : Return "Gennaio"
         Case 2 : Return "Febbraio"
         Case 3 : Return "Marzo"
         Case 4 : Return "Aprile"
         Case 5 : Return "Maggio"
         Case 6 : Return "Giugno"
         Case 7 : Return "Luglio"
         Case 8 : Return "Agosto"
         Case 9 : Return "Settembre"
         Case 10 : Return "Ottobre"
         Case 11 : Return "Novembre"
         Case 12 : Return "Dicembre"
         Case Else : Return ""
      End Select
   End Function

   Private Sub txtAi_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAi.TextChanged
      CalcolaDate()
   End Sub

   Private Sub txtAf_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAf.TextChanged
      CalcolaDate()
   End Sub

   Private Sub cboMI_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMI.SelectedIndexChanged
      CalcolaDate()
   End Sub

   Private Sub cboMF_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMF.SelectedIndexChanged
      CalcolaDate()
   End Sub

   Private Sub dtpDI_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDI.ValueChanged
      CalcolaDate()
   End Sub

   Private Sub dtpDF_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDF.ValueChanged
      CalcolaDate()
   End Sub

   Private Sub dtpData_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpData.ValueChanged
      CalcolaDate()
   End Sub

   Private Sub cboM_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboM.SelectedIndexChanged
      CalcolaDate()
   End Sub

   Private Sub txtA_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtA.TextChanged
      CalcolaDate()
   End Sub
End Class
