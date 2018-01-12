Public Class StAccettata
   Implements IStatusDelega


   Public ReadOnly Property StatusName() As String Implements IStatusDelega.StatusName
      Get
         Return "Accettata"
      End Get
   End Property

   Public Shared Function Instance() As StAccettata
      Return New StAccettata
   End Function
   Public Sub Accetta(ByVal DataAccettazione As DateTime, ByVal Delega As Delega) Implements IStatusDelega.Accetta

   End Sub
   Public Sub Attiva(ByVal Pagamento As IDocumento, ByVal Delega As Delega) Implements IStatusDelega.Attiva
      Delega.PagamentoAttivazione = Pagamento
      Delega.DataDecorrenzaDelega = Pagamento.DataRegistrazione
      Delega.StatoDelega = StAttiva.Instance
      'qui devo usare uno strategy per il calcolo della decorrenza della delega
      Delega.StatoPrecedente = Me
   End Sub
   Public Sub Inoltra(ByVal DataInoltro As DateTime, ByVal Delega As Delega) Implements IStatusDelega.Inoltra


   End Sub
   Public Sub Rifiuta(ByVal Delega As Delega) Implements IStatusDelega.Rifiuta


   End Sub
   Public Sub Revoca(ByVal Delega As Delega, ByVal Causale As CausaleRevocaDelega, ByVal DataRevoca As DateTime, ByVal Note As String) Implements IStatusDelega.Revoca
      Delega.CausaleFineCiclo = Causale
      Delega.DataRevocaDelega = DataRevoca
      Delega.Note = Note
      Delega.StatoPrecedente = Me
      Delega.StatoDelega = StRevocata.Instance
   End Sub
   Public Sub Annulla(ByVal Delega As Delega, ByVal DataAnnullamento As DateTime, ByVal DelegaAccettata As Delega) Implements IStatusDelega.Annulla
      Delega.DataAnnullamentoDelega = DataAnnullamento
      Delega.StatoDelega = StAnnullata.Instance
      Delega.DelegaDiAnnullamento = DelegaAccettata
      Dim msg As String = "Delega annullata a causa dell' accettazione della delega di id " & DelegaAccettata.Id & " in data " & DelegaAccettata.DataAccettazioneDelega
      Delega.Note = IIf(Delega.Note = "", msg, Delega.Note & vbCrLf & msg)
      Delega.StatoPrecedente = Me
   End Sub

   Public ReadOnly Property ReadyForPayment() As Boolean Implements IStatusDelega.ReadyForPayment
      Get
         Return True
      End Get
   End Property
   Public ReadOnly Property IsAccepted() As Boolean Implements IStatusDelega.IsAccepted
      Get
         Return True
      End Get
   End Property

   Public Sub RipristinaStatoPrecedente(ByVal Delega As Delega) Implements IStatusDelega.RipristinaStatoPrecedente
      Try

         Delega.DataAccettazioneDelega = DateTime.MinValue
         'Delega.EnteAccettante1 = New AziendaNonSpecificata
         'Delega.EnteAccettante2 = New AziendaNonSpecificata
         Delega.StatoDelega = New StInoltrata
         Delega.StatoPrecedente = New StSottoscritta
         Delega.Utente.RipristinaStatoPrecedenteAccettazione(Delega)
      Catch ex As Exception
         Throw New Exception("Impossibile ripristinare lo stato precedente la delega di id " & Delega.Id & vbCrLf & ex.Message)
      End Try

   End Sub

   Public Sub Annulla1(ByVal Delega As Delega, ByVal DataAnnullamento As Date, ByVal Causale As AbstractPersistenceObject) Implements IStatusDelega.Annulla
      Delega.CausaleFineCiclo = Causale
      Delega.DataAnnullamentoDelega = DataAnnullamento
      Delega.StatoDelega = StAnnullata.Instance
      Delega.DelegaDiAnnullamento = New DelegaNulla
      Delega.StatoPrecedente = Me
   End Sub
End Class
