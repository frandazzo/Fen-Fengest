Public Class StSottoscritta
   Implements IStatusDelega



   Public Shared Function Instance() As StSottoscritta
      Return New StSottoscritta
   End Function
   Public Sub Accetta(ByVal DataAccettazione As DateTime, ByVal Delega As Delega) Implements IStatusDelega.Accetta
      'Delega.StatoDelega = StAccettata.Instance
      ''qui annullo tutte le possibili deleghe attive
   End Sub
   Public Sub Attiva(ByVal Pagamento As IDocumento, ByVal Delega As Delega) Implements IStatusDelega.Attiva


   End Sub
   Public Sub Inoltra(ByVal DataInoltro As DateTime, ByVal Delega As Delega) Implements IStatusDelega.Inoltra
      If DataInoltro < Delega.DataDocumento Then Throw New Exception("Impossibile inoltrare la delega. La data di inoltro è precedente la data documento.")
      Delega.DataInoltro = DataInoltro
      Delega.StatoDelega = StInoltrata.Instance
      Delega.StatoPrecedente = Me
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
      Dim msg As String = ""
      Delega.DataAnnullamentoDelega = DataAnnullamento
      Delega.StatoDelega = StAnnullata.Instance
      Delega.DelegaDiAnnullamento = DelegaAccettata
      msg = "Delega annullata a causa dell' accettazione della delega di id " & DelegaAccettata.Id & " in data " & DelegaAccettata.DataAccettazioneDelega
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

   Public ReadOnly Property StatusName() As String Implements IStatusDelega.StatusName
      Get
         Return "Sottoscritta"
      End Get
   End Property

   Public Sub RipristinaStatoPrecedente(ByVal Delega As Delega) Implements IStatusDelega.RipristinaStatoPrecedente

   End Sub

   Public Sub Annulla1(ByVal Delega As Delega, ByVal DataAnnullamento As Date, ByVal Causale As AbstractPersistenceObject) Implements IStatusDelega.Annulla
      Delega.CausaleFineCiclo = Causale
      Delega.DataAnnullamentoDelega = DataAnnullamento
      Delega.StatoDelega = StAnnullata.Instance
      Delega.DelegaDiAnnullamento = New DelegaNulla
      Delega.StatoPrecedente = Me
   End Sub
End Class
