Imports System.Reflection
Imports System.Globalization
Public Class ItemsComparer
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
      Dim t1 As ItemContabile = DirectCast(x, ItemContabile)
      Dim t2 As ItemContabile = DirectCast(y, ItemContabile)
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
   Public Function GetPropertyValueFor(ByVal Item As ItemContabile) As Object
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
         Case "Utente"
            Return Item.Utente.CompleteName
         Case "Conto"
            Return Item.Conto.Descrizione
         Case "DataRegistrazione"
            Return Item.DataRegistrazione
         Case "DataDocumento"
            Return Item.DataDocumento
         Case "DocumentoPadre"
            Return Item.DocumentoPadre.Id
         Case "SoggettoEsecutore"
            Return Item.SoggettoEsecutore.Descrizione
         Case "Congruita"
            Return Item.GetCongruitaToString
         Case "PagamentoReferente"
            Return Item.PagamentoReferente.Id
         Case "AziendaImpiego"
            Return Item.AziendaImpiego.Descrizione
         Case "ContrattoApplicato"
            Return Item.ContrattoApplicato.Descrizione
         Case "LivelloInquadramento"
            Return Item.LivelloInquadramento
         Case "OreLavorate"
            Return Item.OreLavorate
         Case "OreMalattia"
            Return Item.OreMalattia
         Case "TipoPrestazione"
            Return Item.Prestazione.TipoDocumento
         Case "TipoDocumento"
            Return Item.TipoDocumento
         Case "QuotaMedia"
            Return Item.GetQuotaMedia
         Case "ImportoRistorno"
            Return Item.ImportoRistorno
         Case "ImpRist"
            Return Item.ImportoRistorno
         Case "ImportoPosizione"
            Return Item.Importo
         Case "Importo"
            Return Item.Importo
         Case "Prestazione"
            Return Item.Prestazione.GetId
         Case "Competenza"
            Return Item.Competenza
         Case Else
            Return "#"
      End Select

   End Function

End Class
