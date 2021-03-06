
Imports System.Reflection
Imports System.Globalization
Public Class OffertaLavoroComparer
   Implements IComparer

   Private m_PropertyName As String = ""
   Private m_Descending As Boolean = False



   Public Sub New(ByVal PropertyName As String, Optional ByVal Descending As Boolean = False)
      m_PropertyName = PropertyName
      m_Descending = Descending
   End Sub
   Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements IComparer.Compare
      If x Is Nothing And y Is Nothing Then Return 0
      If x Is Nothing Then Return 1
      If y Is Nothing Then Return -1
      Dim t1 As OffertaLavoro = DirectCast(x, OffertaLavoro)
      Dim t2 As OffertaLavoro = DirectCast(y, OffertaLavoro)
      'Dim prop1 As Object = GetPropertyValueFor(t1)
      'Dim prop2 As Object = GetPropertyValueFor(t2)

      'If TypeOf (prop1) Is DateTime Then

      '   If m_Descending Then
      '      Return -1 * DirectCast(prop1, DateTime).CompareTo(DirectCast(prop2, DateTime))
      '   Else
      '      Return DirectCast(prop1, DateTime).CompareTo(DirectCast(prop2, DateTime))
      '   End If

      'ElseIf TypeOf (prop1) Is Int32 Then

      '   If m_Descending Then
      '      Return -1 * DirectCast(prop1, Int32).CompareTo(DirectCast(prop2, Int32))
      '   Else
      '      Return DirectCast(prop1, Int32).CompareTo(DirectCast(prop2, Int32))
      '   End If

      'Else

      '   If m_Descending Then
      '      Return -1 * StrComp(prop1, prop2, CompareMethod.Text)
      '   Else
      '      Return StrComp(prop1, prop2, CompareMethod.Text)
      '   End If

      'End If

      Try
         Dim prop1 As IComparable = GetPropertyValueFor(t1)
         Dim prop2 As IComparable = GetPropertyValueFor(t2)

         If m_Descending Then
            Return -1 * prop1.CompareTo(prop2)
         Else
            Return prop1.CompareTo(prop2)
         End If

      Catch ex As Exception
         Dim prop1 As Object = GetPropertyValueFor(t1)
         Dim prop2 As Object = GetPropertyValueFor(t2)

         If m_Descending Then
            Return -1 * StrComp(prop1, prop2, CompareMethod.Text)
         Else
            Return StrComp(prop1, prop2, CompareMethod.Text)
         End If

      End Try



   End Function
   Public Function GetPropertyValueFor(ByVal Item As OffertaLavoro) As Object
      'Dim myType As Type = GetType(ItemContabile)
      'Dim myInstance As IItemDescriptors = Item
      'Dim myProperty As PropertyInfo = myType.GetProperty(m_PropertyName)
      'Dim result As String = myProperty.GetValue(myInstance, Nothing).CompleteName
      'Return result
      Select Case m_PropertyName
         Case "Id"
            Return Item.Id
         Case "Data"
            Return Item.Data
         Case "AziendaRichiedente"
            Return Item.AziendaRichiedente.Descrizione
         Case "GetNumeroTotalePosti"
            Return Item.GetNumeroTotalePosti
         Case "Validita"
            Return Item.Validita
         
         Case Else
            Return "#"
      End Select

   End Function

End Class

