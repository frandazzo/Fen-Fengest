Public Interface IPayble
   Inherits IDocumento
   Sub SetPosizionePagabile(ByVal PuoAccettarePagamento As Boolean, ByVal Errore As String)
   'Property SoggettoEsecutore() As AbstractAzienda
   ReadOnly Property Competenza() As AbstractPeriodo
End Interface
