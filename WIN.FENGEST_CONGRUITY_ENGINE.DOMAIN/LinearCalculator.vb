Public Class LinearCalculator
   Inherits AbstractCalculator



   Protected Overrides Function Execute() As IValuableForCongruity.Congruita
      Try
         If MyBase.m_QuotaMensileUtente.Importo = 0.0 Then
            MyBase.m_QuotaCalcolata = New Moneta(0.0, MyBase.m_QuotaMensileUtente.GetValuta)
            Return IValuableForCongruity.Congruita.NonCongrua
         End If

         CalculateRangeOfCongruity()
         'finora ho disponibile il range entro cui eseguire il confronto per la congruità
         'devo adesso calcolare la quota che devo verificare se è inclusa nel range che ho trovato
         CalculateQuotaMedia()
         If MyBase.m_QuotaCalcolata.IsIncludedBetween(MyBase.m_QuotaMinima, MyBase.m_QuotaMax) Then
            Return IValuableForCongruity.Congruita.Congrua
         Else
            Return IValuableForCongruity.Congruita.NonCongrua
         End If

      Catch ex As Exception
         Throw New Exception(ex.Message)
      End Try



   End Function
   Private Sub CalculateQuotaMedia()
      Try
         Dim NumPeriodiCompetenza As Integer = MyBase.m_CompetenzaPosizione.GetNumberOfPeriods + GetNumberOfAddedPeriods()
         If NumPeriodiCompetenza = 0 Then Throw New Exception("Impossibile calcolare il valore della quota media per il calcolo della congruità della posizione poichè la competenza è suddivisa in 0 intervalli")
         Dim importoMedio As Double = MyBase.m_ImportoPosizione.Importo / NumPeriodiCompetenza * MyBase.m_numPeriodiMensili
         importoMedio = Math.Abs(CDbl(Format(importoMedio, "###0.00")))
         m_Posizione.QuotaMedia = New Moneta(importoMedio, MyBase.m_ImportoPosizione.GetValuta)
         MyBase.m_QuotaCalcolata = New Moneta(importoMedio, MyBase.m_ImportoPosizione.GetValuta)
      Catch ex As Exception
         Throw New Exception(ex.Message)
      End Try
   End Sub
   Private Sub CalculateRangeOfCongruity()
      Try
         Dim importoMensile As Double = m_QuotaMensileUtente.Importo
         importoMensile = Math.Abs(importoMensile)
         Dim scarto As Double = MyBase.GetValueOf(MyBase.m_PercentualeScarto, importoMensile)
         MyBase.m_QuotaMax = New Moneta(importoMensile + scarto, MyBase.m_QuotaMensileUtente.GetValuta)
         MyBase.m_QuotaMinima = New Moneta(importoMensile - scarto, MyBase.m_QuotaMensileUtente.GetValuta)
      Catch ex As Exception
         Throw New Exception(ex.Message)
      End Try
   End Sub

End Class
