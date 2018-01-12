Public MustInherit Class AbstractCalculator
   Public Enum TipoCalcolatore
      Lineare
   End Enum
   Protected m_ImportoPosizione As Moneta
   Protected m_CompetenzaPosizione As AbstractPeriodo
   Protected m_QuotaMensileUtente As Moneta
   Protected m_QuotaCalcolata As Moneta
   Protected m_TredicesimaInclusa As Boolean
   Protected m_QuattordicesimaInclusa As Boolean
   Protected m_TipoConfronto As IConfrontoPeriodi.UnitaDiCompetenza
   Protected m_Posizione As IValuableForCongruity
   Protected m_PercentualeScarto As Double
   Protected m_QuotaMinima As Moneta
   Protected m_QuotaMax As Moneta
   Protected m_numPeriodiMensili As Integer
   Public Overridable Function CalaculateCongruity(ByVal PosizionePagamento As IValuableForCongruity) As IValuableForCongruity.Congruita
      'Uso il pattern Template Method
      'setto tutte le proprietà che mi servono
      m_ImportoPosizione = PosizionePagamento.Importo
      m_QuotaMensileUtente = PosizionePagamento.QuotaMensileUtente
      m_CompetenzaPosizione = PosizionePagamento.Competenza
      m_TredicesimaInclusa = PosizionePagamento.TredicesimaInclusa
      m_QuattordicesimaInclusa = PosizionePagamento.QuattordicesimaInclusa
      m_TipoConfronto = PosizionePagamento.TipoConfrontoCompetenze
      m_Posizione = PosizionePagamento
      m_PercentualeScarto = PosizionePagamento.PercentualeScarto
      'infine ritorno il valore calcolato
      Try
         Return Execute()
      Catch ex As Exception
         Throw New Exception("Errore nel calcolo della congruità per la posizione corrente" & vbCrLf & ex.Message)
      End Try

   End Function
   Protected Overridable Function Execute() As IValuableForCongruity.Congruita
      Return IValuableForCongruity.Congruita.Congrua
   End Function
   Protected Function GetValueOf(ByVal PerCent As Double, ByVal forValue As Double) As Double
      If PerCent = 0.0 Then Return 0.0
      Dim risultato As Double = (forValue / 100) * PerCent
      risultato = CDbl(Format(risultato, "###0.00"))
      Return risultato
   End Function
   Protected Function GetNumberOfAddedPeriods() As Integer
      Dim numPeriodi As Integer
      Select Case Me.m_TipoConfronto
         Case IConfrontoPeriodi.UnitaDiCompetenza.Giornaliera
            numPeriodi = 30
         Case IConfrontoPeriodi.UnitaDiCompetenza.Mensile
            numPeriodi = 1
      End Select
      Me.m_numPeriodiMensili = numPeriodi
      If Me.m_TredicesimaInclusa And Me.m_QuattordicesimaInclusa Then
         Return (numPeriodi * 2)
      ElseIf Me.m_TredicesimaInclusa Or Me.m_QuattordicesimaInclusa Then
         Return numPeriodi
      Else
         Return 0
      End If
   End Function
End Class
