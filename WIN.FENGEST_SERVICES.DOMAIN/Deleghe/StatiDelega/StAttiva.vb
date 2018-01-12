Public Class StAttiva
   Implements IStatusDelega


   Public ReadOnly Property StatusName() As String Implements IStatusDelega.StatusName
      Get
         Return "Attivata"
      End Get
   End Property
   Public Shared Function Instance() As StAttiva
      Return New StAttiva
   End Function
   Public Sub Accetta(ByVal DataAccettazione As DateTime, ByVal Delega As Delega) Implements IStatusDelega.Accetta


   End Sub
   Public Sub Attiva(ByVal Pagamento As IDocumento, ByVal Delega As Delega) Implements IStatusDelega.Attiva
      Dim nullo As Boolean = False

      If Delega.PagamentoAttivazione IsNot Nothing Then

        If Delega.PagamentoAttivazione Is Pagamento Then
          Return
        End If

      End If


      Delega.StatoPrecedente = Me

      If Delega.PagamentoAttivazione Is Nothing Then

         nullo = True

      End If

'questa riga di codice mi serve per gestire i 
'riferimenti agli incassi che sono stati cancellati
     Try
          If Delega.PagamentoAttivazione.GetId = -1 Then
            nullo = True
          End If
     Catch NullReferenceException As Exception

     'IL caso di un pagamento non nullo con id nullo non dovrebbe mai verificarsi
     'perchè la sola situazione in cui avviene e il caso in cui in un pagamento ci sono due posizioni
     'della stessa persona con competenze diverse e delega da attivare è già gestito sopra
     'quando verifico se il Pagamento di attivazione è uguale all'argomento di questa funzione
          nullo = True
     End Try




      If nullo Then
          Delega.PagamentoAttivazione = Pagamento
          Delega.DataDecorrenzaDelega = Pagamento.DataRegistrazione
      End If



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
      Dim msg As String = "Delega annullata  dalla delega di id " & DelegaAccettata.Id & " in data " & DelegaAccettata.DataAccettazioneDelega
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
         Return False
      End Get
   End Property

   Public Sub RipristinaStatoPrecedente(ByVal Delega As Delega) Implements IStatusDelega.RipristinaStatoPrecedente
      Throw New Exception("Impossibile effettuare il ripristino dello stato precedente nel caso di una delega attivata poiché almeno una quota associativa è già stata incassata.")
   End Sub

   Public Sub Annulla1(ByVal Delega As Delega, ByVal DataAnnullamento As Date, ByVal Causale As AbstractPersistenceObject) Implements IStatusDelega.Annulla
      Delega.CausaleFineCiclo = Causale
      Delega.DataAnnullamentoDelega = DataAnnullamento
      Delega.StatoDelega = StAnnullata.Instance
      Delega.DelegaDiAnnullamento = New DelegaNulla
      Delega.StatoPrecedente = Me
   End Sub
End Class
