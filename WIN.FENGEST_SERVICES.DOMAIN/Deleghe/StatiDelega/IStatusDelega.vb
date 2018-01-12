Public Interface IStatusDelega
   Sub Inoltra(ByVal DataInoltro As DateTime, ByVal Delega As Delega)
   Sub Accetta(ByVal DataAccettazione As DateTime, ByVal Delega As Delega)
   Sub Rifiuta(ByVal Delega As Delega)
   Sub Revoca(ByVal Delega As Delega, ByVal Causale As CausaleRevocaDelega, ByVal DataRevoca As DateTime, ByVal Note As String)
   Sub Attiva(ByVal Pagamento As IDocumento, ByVal Delega As Delega)
   Sub Annulla(ByVal Delega As Delega, ByVal DataAnnullamento As DateTime, ByVal DelegaAccettata As Delega)
   Sub Annulla(ByVal Delega As Delega, ByVal DataAnnullamento As DateTime, ByVal Causale As AbstractPersistenceObject)
   ReadOnly Property ReadyForPayment() As Boolean
   ReadOnly Property IsAccepted() As Boolean
   ReadOnly Property StatusName() As String
   Sub RipristinaStatoPrecedente(ByVal Delega As Delega)
End Interface
