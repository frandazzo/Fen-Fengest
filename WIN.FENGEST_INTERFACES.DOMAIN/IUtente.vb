Public Interface IUtente
   Inherits IPersona
   
   Property Conto() As IConto
   Property QuotaMensile() As Moneta
   ReadOnly Property Deleghe() As VirtualLazyList
   ReadOnly Property IdUtente() As Int32
   Sub AddDelega(ByVal Delega As IDelega)
   Sub AnnullaDeleghePerSoggetto(ByVal Delega As IDelega)
   Sub RipristinaStatoPrecedenteAccettazione(ByVal Delega As IDelega)
   Sub SetDeleghe(ByVal List As VirtualLazyList)
   Function ActivateDelega(ByVal PerSoggetto As AbstractAzienda, ByVal ConDocumento As IDocumento) As Boolean
   Sub ChangeSedeOperativa(ByVal PerSoggetto As AbstractAzienda, ByVal AllaData As Date, ByVal Sede As ISedeOperativa)
   Function HaAttivatoDelega() As Boolean
   Function HaCambiatoSede() As Boolean
   Sub CheckPaybility(ByVal PosizioneDiPagamento As IPayble, ByVal SoggettoEsecutore As AbstractAzienda)
   Function CheckExistenceActiveDelegaFor(ByVal Ente As AbstractAzienda) As Boolean
   Function GetActiveDelegaFor(ByVal SoggettoEsecutore As AbstractAzienda) As IDelega
   Function GetActiveDelegaFor(ByVal SoggettoEsecutore As AbstractAzienda, ByVal AtDate As DateTime) As IDelega
   Function ToString() As String
   Function PossiedeTessera(ByVal anno As Int32)
   '   Property Nazionalita() As Nazione
   '   Property ProvinciaNascita() As Provincia
   '   Property ComuneNascita() As Comune
   '   Property DataNascita() As Date
   '   Property Sesso() As Sex
   '   Property CodiceFiscale() As String
   '   Property Residenza() As Indirizzo
   '   Property Comunicazione() As Comunicazione











 Function GetDelegaById(ByVal IdDelega As Int32) As IDelega


End Interface
