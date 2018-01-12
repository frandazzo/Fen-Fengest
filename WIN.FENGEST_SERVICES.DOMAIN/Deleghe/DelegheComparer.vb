
Imports System.Reflection
Imports System.Globalization
Public Class DelegheComparer
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
      Dim t1 As Delega = DirectCast(x, Delega)
      Dim t2 As Delega = DirectCast(y, Delega)
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
   Public Function GetPropertyValueFor(ByVal Item As Delega) As Object
      'Dim myType As Type = GetType(ItemContabile)
      'Dim myInstance As IItemDescriptors = Item
      'Dim myProperty As PropertyInfo = myType.GetProperty(m_PropertyName)
      'Dim result As String = myProperty.GetValue(myInstance, Nothing).CompleteName
      'Return result
      Select Case m_PropertyName
         Case "Note"
            Return Item.Note
         Case "Referente"
            Return Item.Referente.CompleteName
         Case "Responsabile"
            Return Item.Responsabile.CompleteName
         Case "Utente"
            Return Item.Utente.CompleteName
         Case "DataRegistrazione"
            Return Item.DataRegistrazione
         Case "DataDocumento"
            Return Item.DataDocumento
         Case "DataInoltro"
            Return Item.DataInoltro
         Case "DataAccettazioneDelega"
            Return Item.DataAccettazioneDelega
         Case "DataDecorrenzaDelega"
            Return Item.DataDecorrenzaDelega
         Case "DataAnnullamentoDelega"
            Return Item.DataAnnullamentoDelega
         Case "CaualeSottoscrizione"
            Return Item.CausaleSottoscrizione.Descrizione
         Case "CaualeFineCiclo"
            Return Item.CausaleFineCiclo.Descrizione
         Case "Reparto"
            Return Item.Reparto.Descrizione
         Case "EnteInoltro"
            Return Item.EnteInoltro.Descrizione
         Case "SedeOperativa"
            Return Item.Reparto
         Case "NomeStato"
            Return Item.NomeStato
         Case Else
            Return "#"
      End Select

   End Function

End Class
