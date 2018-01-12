Public Interface IValuableForCongruity
   Inherits IDocumento
   Enum Congruita
      Congrua
      NonCongrua
   End Enum

   Sub SetCongruitaPosizione(ByVal Congrua As IValuableForCongruity.Congruita)
   ReadOnly Property Importo() As Moneta
   ReadOnly Property Competenza() As AbstractPeriodo
   ReadOnly Property TredicesimaInclusa() As Boolean
   ReadOnly Property QuattordicesimaInclusa() As Boolean
   ReadOnly Property QuotaMensileUtente() As Moneta
   ReadOnly Property TipoConfrontoCompetenze() As IConfrontoPeriodi.UnitaDiCompetenza
   ReadOnly Property PercentualeScarto() As Double
   Property QuotaMedia() As Moneta
End Interface
