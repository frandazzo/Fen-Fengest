Public Class Inps
   Inherits Azienda

   Public Sub New()
      MyBase.m_TipoAzienda = TipoAzienda.Inps
      MyBase.UnitaDiCompetenza = IConfrontoPeriodi.UnitaDiCompetenza.Giornaliera
   End Sub
   Public Sub New(ByVal Descrizione As String, _
                  ByVal CompetenzaUltimoPagamento As AbstractPeriodo, _
                  ByVal Conto As IConto)
      If Conto Is Nothing Then Throw New Exception("Non è possibile creare un oggetto Inps senza un oggetto conto valido. Oggetto nullo.")
      If Conto.IdConto = -1 Then Throw New Exception("Non è possibile creare un oggetto Inps senza un oggetto conto valido. Tipo conto nullo.")
      If Descrizione = "" Then Throw New Exception("Non è possibile creare un oggetto Inps con una descrizione vuota. Inserire una descrizione corretta.")
      If CompetenzaUltimoPagamento Is Nothing Then Throw New Exception("Non è possibile creare un oggetto Inps con un oggetto Competenza Ultimo Pagamento nullo.")
      MyBase.m_TipoAzienda = TipoAzienda.Inps
      m_Conto = Conto
      MyBase.Descrizione = Descrizione
      m_CompetenzaUltimoPagamento = CompetenzaUltimoPagamento
      m_UnitaCompetenza = IConfrontoPeriodi.UnitaDiCompetenza.Giornaliera
   End Sub

   Protected Overrides Sub DoValidation()
      If MyBase.Descrizione = "" Then
         ValidationErrors.Add("Impossibile registrare i dati della segreteria con una ragione sociale nulla")
      End If
      If m_Conto Is Nothing Then
         ValidationErrors.Add("Conto nullo")
      End If


   End Sub

End Class
