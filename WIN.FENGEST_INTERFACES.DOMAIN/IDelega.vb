Public Interface IDelega
   Inherits IDocumento
   Function IsActive() As Boolean
   Sub Attiva(ByVal Delega As IDelega, ByVal ConPagamento As IDocumento)
   Sub Inoltra(ByVal Delega As IDelega, ByVal DataInoltro As DateTime)
   Sub Accetta(ByVal Delega As IDelega, ByVal DataAccettazione As DateTime)
   Sub Rifiuta(ByVal Delega As IDelega)
   Sub Revoca(ByVal Delega As IDelega, ByVal DataRevoca As DateTime, ByVal Causale As AbstractPersistenceObject, ByVal Note As String)
   Sub Annulla(ByVal Delega As IDelega, ByVal DataAnnullamento As DateTime, ByVal Causale As AbstractPersistenceObject)
   Sub Annulla(ByVal Delega As IDelega, ByVal DataAnnullamento As DateTime, ByVal DelegaAccettata As IDelega)

   Function IsAccepted() As Boolean
   Function IsRevocata() As Boolean
   Function IsAnnullata() As Boolean
   Sub RipristinaStatoPrecedente()
   Property DelegaDiAnnullamento() As IDelega
   'ReadOnly Property DataRegistrazione() As DateTime

   Function GetPeriodoValidita() As DataRange

   Property DataInoltro() As DateTime
   Property DataDecorrenzaDelega() As DateTime
   Property DataAccettazioneDelega() As DateTime
   Property DataAnnullamentoDelega() As DateTime
   Property PagamentoAttivazione() As IDocumento
   Property EnteInoltro() As AbstractAzienda
   Property SedeOperativa() As ISedeOperativa
   'Property EnteAccettante1() As AbstractAzienda
   'Property EnteAccettante2() As AbstractAzienda
   Property Referente() As AbstractPersona
   Property Responsabile() As AbstractPersona
   ReadOnly Property IdDelega() As Int32
   ReadOnly Property NomeStato() As String
   ReadOnly Property IsForSettoreEdile() As Boolean
End Interface
