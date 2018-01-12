Public Class ItemDtoCompetenzaComparer
   Implements IComparer
   Private m_PropertyName As String = ""
   Private m_descending As Boolean = False
   Public Shared Function GetItemComparer(ByVal PropertyName As String, Optional ByVal Descending As Boolean = False) As ItemDtoCompetenzaComparer
      Return New ItemDtoCompetenzaComparer(PropertyName, Descending)
   End Function

   Public Sub New(ByVal PropertyName As String, ByVal Descending As Boolean)
      m_PropertyName = PropertyName
      m_descending = Descending
   End Sub
   Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements IComparer.Compare
      If x Is Nothing And y Is Nothing Then Return 0
      If x Is Nothing Then Return 1
      If y Is Nothing Then Return -1
      Dim t1 As DTOItemContabile = DirectCast(x, DTOItemContabile)
      Dim t2 As DTOItemContabile = DirectCast(y, DTOItemContabile)
      If m_Descending Then
         Return -1 * GetPropertyValueFor(t1).GetDataRange.CompareTo((GetPropertyValueFor(t2).GetDataRange))
      Else
         Return GetPropertyValueFor(t1).GetDataRange.CompareTo((GetPropertyValueFor(t2).GetDataRange))
      End If
   End Function
   Public Function GetPropertyValueFor(ByVal Item As DTOItemContabile) As AbstractPeriodo
      'Dim myType As Type = GetType(ItemContabile)
      'Dim myInstance As IItemDescriptors = Item
      'Dim myProperty As PropertyInfo = myType.GetProperty(m_PropertyName)
      'Dim result As String = myProperty.GetValue(myInstance, Nothing).CompleteName
      'Return result
      Select Case m_PropertyName
         Case "Competenza"
            Return Item.Competenza
         Case Else
            Throw New InvalidOperationException
      End Select

   End Function
End Class
