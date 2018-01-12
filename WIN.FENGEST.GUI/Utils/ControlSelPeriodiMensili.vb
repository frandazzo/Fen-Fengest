Public Class ControlSelPeriodiMensili
   Private m_MinDate As DateTime = Date.MinValue
   Private m_MaxDate As DateTime = Date.MaxValue

    Private m_mothPeriod As Boolean


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

        'SetDefaultPeriodiMensili()
        'CalcolaDate()
   End Sub

   Private Sub ControlloSelezioneCompetenza_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If m_mothPeriod Then
            SetDefaultToLastMonth()
            CalcolaDate()
        Else

            SetDefaultPeriodiMensili()
            CalcolaDate()
        End If
    

   End Sub

    Public Sub SetDefaultPeriodiMensili()
        cboMI.Text = GetMeseByNumero(Today.Month)
        txtAi.Text = (Today.Year - 1).ToString

        cboMF.Text = GetMeseByNumero(Today.Month)
        txtAf.Text = Today.Year.ToString

        m_MinDate = New DateTime(Today.Year - 1, Today.Month, 1)
        m_MaxDate = New DateTime(Today.Year, Today.Month, Date.DaysInMonth(Today.Year, Today.Month))

    End Sub

  
    Public Sub SetDefaultToLastMonth()
        cboMI.Text = GetMeseByNumero(Today.Month)
        txtAi.Text = (Today.Year).ToString

        cboMF.Text = GetMeseByNumero(Today.Month)
        txtAf.Text = Today.Year.ToString

        m_MinDate = New DateTime(Today.Year, Today.Month, 1)
        m_MaxDate = New DateTime(Today.Year, Today.Month, Date.DaysInMonth(Today.Year, Today.Month))


        m_mothPeriod = True
    End Sub



   Public Sub CalcolaDate()
      Try

         m_MinDate = New DateTime(ValidateYear(Me.txtAi.Text), ValidateMese(GetNumeroMeseByName(Me.cboMI.Text)), 1)
         Dim dayAfter As DateTime = New DateTime(ValidateYear(Me.txtAf.Text), ValidateMese(GetNumeroMeseByName(Me.cboMF.Text)), 1)
         dayAfter = dayAfter.AddMonths(1)
         m_MaxDate = dayAfter.AddDays(-1)
         'ValidateDate()
      Catch ex As Exception
         'ErrorHandler.ShowError(ex)
         SetDefaultValues()
      End Try
   End Sub
   Private Sub SetDefaultValues()
      Me.SetDefaultPeriodiMensili()
   End Sub
   Private Sub ValidateDate()
      If m_MaxDate < m_MinDate Then
         Throw New Exception("L'intervallo di tempo selezionato è negativo. Ripetere la selezione")
      End If
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
      'CalcolaDate()
   End Sub

   Private Sub txtAf_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAf.TextChanged
      'CalcolaDate()
   End Sub

   Private Sub cboMI_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMI.SelectedIndexChanged
      'CalcolaDate()
   End Sub

   Private Sub cboMF_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMF.SelectedIndexChanged
      'CalcolaDate()
   End Sub

 
End Class
