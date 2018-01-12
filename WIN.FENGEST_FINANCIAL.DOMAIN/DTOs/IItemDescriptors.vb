Imports WIN.DOMAIN.FED_SERVICES

Public Interface IItemDescriptors
    Inherits IDocumento
    ReadOnly Property SoggettoEsecutore() As Azienda
    ReadOnly Property SedeOperativaAzienda() As SedeOperativa
    ReadOnly Property Utente() As IUtente
    ReadOnly Property GetCongruitaToString() As String
    ReadOnly Property DocumentoPadre() As DocumentoContabile
    ReadOnly Property Conto() As Conto
    ReadOnly Property GetQuotaMedia() As Moneta
    ReadOnly Property Prestazione() As Prestazione
    ReadOnly Property Vertenza() As IDocumento
    Property Importo() As Moneta
    Property Referente() As Referente
    Property Competenza() As AbstractPeriodo
    Property Tredicesima() As Boolean
    Property Quattordicesima() As Boolean
    Property ImportoRistorno() As Moneta
    Property PagamentoReferente() As DocumentoContabile
    ReadOnly Property Settore() As Settore
    Property AziendaImpiego() As Azienda
    Property ContrattoApplicato() As TipoContratto
    Property LivelloInquadramento() As String
    Property OreLavorate() As Double
    Property OreMalattia() As Double
    Property Selezione() As Boolean
    ReadOnly Property TipoPrestazione() As ITipoPrestazione
End Interface
