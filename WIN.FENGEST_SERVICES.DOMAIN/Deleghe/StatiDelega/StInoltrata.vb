Public Class StInoltrata
   Implements IStatusDelega


   Public ReadOnly Property StatusName() As String Implements IStatusDelega.StatusName
      Get
         Return "Inoltrata"
      End Get
   End Property
   Public Shared Function Instance() As StInoltrata
      Return New StInoltrata
   End Function
   Public Sub Accetta(ByVal DataAccettazione As DateTime, ByVal Delega As Delega) Implements IStatusDelega.Accetta
      'If EnteAccettante1 Is Nothing Then Throw New Exception("Impossibile accettare la delega. L'ente accettante è nullo.")
      'If EnteAccettante2 Is Nothing Then Throw New Exception("Impossibile accettare la delega. L'ente accettante 2 è nullo.")
      If DataAccettazione < Delega.DataDocumento Then Throw New Exception("Non è possibile eseguire l'accettazione della delega se la data di accettazione è inferiore alla data di sottoscrizione")
      If DataAccettazione < Delega.DataInoltro Then Throw New Exception("Non è possibile eseguire l'accettazione della delega se la data di accettazione è inferiore alla data di inoltro")
      'If EnteAccettante1.Id = EnteAccettante2.Id Then Throw New Exception("Impossibile accettare la delega poichè entrambi gli enti bilaterali sono uguali")
      Delega.DataAccettazioneDelega = DataAccettazione
      'If Delega.VerificaEnteAccettazione(EnteAccettante1, Delega) Then
      '   Delega.EnteAccettante1 = EnteAccettante1
      '   If Not EnteAccettante2.Id = -1 Then
      '      Delega.EnteAccettante2 = EnteAccettante2
      '   End If
      Delega.Utente.AnnullaDeleghePerSoggetto(Delega)
      Delega.StatoDelega = StAccettata.Instance
      'Delega.DataAccettazioneDelega = DataAccettazione
      'Else
      'Throw New Exception("Non è possibile eseguire l'accettazione della delega poichè l'ente o gli enti di accettazione non corrispondono all'ente o agli enti di inoltro")
      'End If
      Delega.StatoPrecedente = Me
   End Sub


   Public Sub Attiva(ByVal Pagamento As IDocumento, ByVal Delega As Delega) Implements IStatusDelega.Attiva


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
         Return False
      End Get
   End Property
   Public ReadOnly Property IsAccepted() As Boolean Implements IStatusDelega.IsAccepted
      Get
         Return False
      End Get
   End Property


   Public Sub RipristinaStatoPrecedente(ByVal Delega As Delega) Implements IStatusDelega.RipristinaStatoPrecedente
      Delega.DataInoltro = DateTime.MinValue
      Delega.StatoDelega = New StSottoscritta
      Delega.StatoPrecedente = New StNull
   End Sub

   Public Sub Annulla1(ByVal Delega As Delega, ByVal DataAnnullamento As Date, ByVal Causale As AbstractPersistenceObject) Implements IStatusDelega.Annulla
      Delega.CausaleFineCiclo = Causale
      Delega.DataAnnullamentoDelega = DataAnnullamento
      Delega.StatoDelega = StAnnullata.Instance
      Delega.DelegaDiAnnullamento = New DelegaNulla
      Delega.StatoPrecedente = Me
   End Sub
End Class
