Public Class ControllerCausaliRevoca
   Inherits AbstractCodificheController

   Public Overrides Sub LoadByDescrizione(ByVal Descrizione As String)

      m_current = Nothing
      LoadAll()
      For Each elem As CausaleRevocaDelega In Me.DomainObjectList
         If elem.Descrizione = Descrizione Then m_current = elem
      Next
      If m_current Is Nothing Then m_current = New CausaleNulla

   End Sub
   Private Function Current() As CausaleRevocaDelega
      Return DirectCast(m_current, CausaleRevocaDelega)
   End Function
   Public Overrides Sub CreateNew()
      m_current = New CausaleRevocaDelega
   End Sub
   Public Overloads Overrides Sub CreateNew(ByVal Descrizione As String)

      m_current = New CausaleRevocaDelega
      Current.Descrizione = Descrizione
      Save()

   End Sub
   ''' <summary>
   ''' Metodo che restituisce la lista delle descrizioni delle causali
   ''' </summary>
   ''' <returns></returns>
   ''' <remarks></remarks>
  
   Public Overrides Function GetCategoryObject() As String
      Return "CausaleRevocaDelega"
   End Function
  
   'Public Function GetIdByDescrizione(ByVal Descrizione As String) As String
   '   Try
   '      LoadByDescrizione(Descrizione)
   '      Return Current.Id
   '   Catch ex As Exception
   '      Throw New Exception(ex.Message)
   '   End Try
   'End Function

   Friend Overrides Function GetCausaleById(ByVal Id As String) As AbstractPersistenceObject

      If Id = "" Then Id = -1
      If Id = -1 Then Return New CausaleNulla
      Me.LoadById(Id)
      Return Current()

   End Function

   Public Overrides Function GetListaCausali() As System.Collections.ArrayList

      Dim list As New ArrayList
      LoadAll()
      For Each elem As CausaleRevocaDelega In Me.DomainObjectList
         list.Add(elem.Descrizione)
      Next
      list.Sort()
      Return list

   End Function
End Class

