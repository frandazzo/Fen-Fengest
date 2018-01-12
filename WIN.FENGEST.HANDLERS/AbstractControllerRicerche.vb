Public MustInherit Class AbstractControllerRicerche
   Public MustOverride Function Search() As IList
   Protected m_Top As Int32 = -1
   Public Sub SetMaxNumberOfReturnedRecords(ByVal number As String)
      If number = "" Then
         number = 100
         Return
      End If
      If Not IsNumeric(number) Then
         Throw New ArgumentException("Numero massimo di record non corretto")
      End If
      m_Top = CType(number, Int32)
   End Sub

   Protected m_Results As IList = New ArrayList
   Public ReadOnly Property Results() As IList
      Get
         Return m_Results
      End Get
   End Property

End Class
