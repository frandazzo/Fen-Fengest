Public Class FactoryCongruityCalc
   Shared Function GetCongruityCalculator(ByVal CalculatorType As AbstractCalculator.TipoCalcolatore) As AbstractCalculator
      Select Case CalculatorType
         Case AbstractCalculator.TipoCalcolatore.Lineare
            Return New LinearCalculator
         Case Else
            Throw New Exception("Non � possibile creare un calcolatore di congruit� da un tipo calcolatore sconosciuto")
      End Select
   End Function

End Class
