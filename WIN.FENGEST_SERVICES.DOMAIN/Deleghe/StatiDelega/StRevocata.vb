Public Class StRevocata
   Implements IStatusDelega



   Public Shared Function Instance() As StRevocata
      Return New StRevocata
   End Function
   Public Sub Accetta(ByVal DataAccettazione As DateTime, ByVal Delega As Delega) Implements IStatusDelega.Accetta


   End Sub
   Public Sub Attiva(ByVal Pagamento As IDocumento, ByVal Delega As Delega) Implements IStatusDelega.Attiva


   End Sub
   Public Sub Inoltra(ByVal DataInoltro As DateTime, ByVal Delega As Delega) Implements IStatusDelega.Inoltra


   End Sub
   Public Sub Rifiuta(ByVal Delega As Delega) Implements IStatusDelega.Rifiuta


   End Sub
   Public Sub Revoca(ByVal Delega As Delega, ByVal Causale As CausaleRevocaDelega, ByVal DataRevoca As DateTime, ByVal Note As String) Implements IStatusDelega.Revoca


   End Sub
   Public Sub Annulla(ByVal Delega As Delega, ByVal DataAnnullamento As DateTime, ByVal DelegaAccettata As Delega) Implements IStatusDelega.Annulla

      '
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
         Return "Revocata"
      End Get
   End Property

   Public Sub RipristinaStatoPrecedente(ByVal Delega As Delega) Implements IStatusDelega.RipristinaStatoPrecedente
      If Delega.Utente.CheckExistenceActiveDelegaFor(Delega.EnteInoltro) And (Delega.StatoPrecedente.StatusName = "Accettata" Or Delega.StatoPrecedente.StatusName = "Attivata") Then
         Throw New Exception("Impossibile ripristinare lo stato precedente nel caso di una delega revocata. Esistono altre deleghe attivate o accettate.")
      Else
         Delega.DataRevocaDelega = DateTime.MinValue
         Delega.CausaleFineCiclo = New CausaleNulla
         Select Case Delega.StatoPrecedente.StatusName
            Case "Sottoscritta"
               Delega.StatoDelega = StSottoscritta.Instance
               Delega.StatoPrecedente = New StNull
            Case "Inoltrata"
               Delega.StatoDelega = StInoltrata.Instance
               Delega.StatoPrecedente = New StSottoscritta
            Case "Accettata"
               Delega.StatoDelega = StAccettata.Instance
               Delega.StatoPrecedente = New StInoltrata
            Case "Attivata"
               Delega.StatoDelega = StAttiva.Instance
               If Delega.PagamentoAttivazione.GetId = -1 Then
                  Delega.StatoPrecedente = New StAccettata
               Else
                  Delega.StatoPrecedente = New StAttiva
               End If
            Case "Annullata"
               Throw New Exception("Impossibile ripristinare lo stato precedente una delega revocata  con stato precedente annullato. ")
            Case "Revocata"
               Throw New Exception("Impossibile ripristinare lo stato precedente una delega revocata  con stato precedente revocato. ")
            Case Else
               Throw New Exception("Impossibile ripristinare lo stato precedente per la delega. Nome stato precedente sconosciuto")
         End Select
      End If
   End Sub

   Public Sub Annulla1(ByVal Delega As Delega, ByVal DataAnnullamento As Date, ByVal Causale As AbstractPersistenceObject) Implements IStatusDelega.Annulla

   End Sub
End Class
