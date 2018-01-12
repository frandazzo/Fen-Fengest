Public Class EnteBilaterale
   Inherits Azienda
   Private m_TipoEnte As TipoEnteBilaterale = TipoEnteBilaterale.CassaEdile
   Public Enum TipoEnteBilaterale
      CassaEdile
      EdilCassa
   End Enum
   Public Sub New()
      MyBase.m_TipoAzienda = TipoAzienda.EnteBilateraleEdili
   End Sub
   Public Sub New(ByVal Descrizione As String, _
                  ByVal CompetenzaUltimoPagamento As AbstractPeriodo, _
                  ByVal Conto As IConto, _
                  ByVal UnitaComptenzaPagamenti As IConfrontoPeriodi.UnitaDiCompetenza, _
                  ByVal TipoEnte As EnteBilaterale.TipoEnteBilaterale)
      If Conto Is Nothing Then Throw New Exception("Non è possibile creare un oggetto Ente bilaterale senza un oggetto conto valido. Oggetto nullo.")
      If Conto.IdConto = -1 Then Throw New Exception("Non è possibile creare un oggetto Ente bilaterale senza un oggetto conto valido. Tipo conto nullo.")
      If Descrizione = "" Then Throw New Exception("Non è possibile creare un oggetto Ente bilaterale con una descrizione vuota. Inserire una descrizione corretta.")
      If CompetenzaUltimoPagamento Is Nothing Then Throw New Exception("Non è possibile creare un oggetto Ente bilaterale con un oggetto Competenza Ultimo Pagamento nullo.")
      MyBase.m_TipoAzienda = TipoAzienda.EnteBilateraleEdili
      m_Conto = Conto
      MyBase.Descrizione = Descrizione
      m_CompetenzaUltimoPagamento = CompetenzaUltimoPagamento
      m_UnitaCompetenza = UnitaComptenzaPagamenti
      m_TipoEnte = TipoEnte
   End Sub

   Public Property TipoEnte() As EnteBilaterale.TipoEnteBilaterale
      Get
         Return m_TipoEnte
      End Get
      Set(ByVal value As EnteBilaterale.TipoEnteBilaterale)
         m_TipoEnte = value
      End Set
   End Property
   ''' <summary>
   ''' 
   ''' </summary>
   ''' <param name="Tipo">I valori ammessi sono: "CassaEdile", "EdilCassa"</param>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public Shared Function GetTipoEnte(ByVal Tipo As String) As TipoEnteBilaterale
      Select Case Tipo
         Case "CassaEdile"
            Return TipoEnteBilaterale.CassaEdile
         Case "EdilCassa"
            Return TipoEnteBilaterale.EdilCassa
      End Select
   End Function
   Public Overrides Function ToString() As String
      Return Me.Descrizione
   End Function

   Protected Overrides Sub DoValidation()
      If MyBase.Descrizione = "" Then
         ValidationErrors.Add("Impossibile registrare i dati della segreteria con una ragione sociale nulla")
      End If
      If m_Conto Is Nothing Then
         ValidationErrors.Add("Conto nullo")
      End If
    

   End Sub


End Class
