
Imports System.Reflection
Imports System.Globalization
Public Class NonIscrittoDTOComparer
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
      Dim t1 As NonIscrittoDTO = DirectCast(x, NonIscrittoDTO)
      Dim t2 As NonIscrittoDTO = DirectCast(y, NonIscrittoDTO)
      'If m_Descending Then
      '   Return -1 * StrComp(GetPropertyValueFor(t1), GetPropertyValueFor(t2), CompareMethod.Text)
      'Else
      '   Return StrComp(GetPropertyValueFor(t1), GetPropertyValueFor(t2), CompareMethod.Text)
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
   Public Function GetPropertyValueFor(ByVal Item As NonIscrittoDTO) As Object
      'Dim myType As Type = GetType(ItemContabile)
      'Dim myInstance As IItemDescriptors = Item
      'Dim myProperty As PropertyInfo = myType.GetProperty(m_PropertyName)
      'Dim result As String = myProperty.GetValue(myInstance, Nothing).CompleteName
      'Return result
      Select Case m_PropertyName
            Case "Id"
                Return Item.Id
            Case "Nome_Azienda"
                Return Item.Nome_Azienda
            Case "Id_Azienda_Impiego"
                Return Item.Id_Azienda_Impiego
            Case "Ha_Delega_Precedente"
                Return Item.Ha_Delega_Precedente
            Case "Libero_Al"
                Return Item.Libero_Al
            Case "Livello"
                Return Item.Livello
            Case "Nome_Ente"
                Return Item.Nome_Ente
            Case "Nome_Utente"
                Return Item.Nome_Utente
            Case "Nome_Nazione"
                Return Item.Nome_Nazione
            Case "Nome_Comune"
                Return Item.Nome_Comune
            Case "Nome_Provincia"
                Return Item.Nome_Provincia
            Case "Codice_Fiscale"
                Return Item.Codice_Fiscale
            Case "IscrittoA"
                Return Item.IscrittoA
            Case Else
                Return "#"
        End Select

   End Function

End Class
