Public Class ControllerReparti
   Inherits AbstractCodificheController

   Public Overrides Sub LoadByDescrizione(ByVal Descrizione As String)
      Try
         m_current = Nothing
         LoadAll()
         For Each elem As RepartoAzienda In Me.DomainObjectList
            If elem.Descrizione = Descrizione Then m_current = elem
         Next
         If m_current Is Nothing Then m_current = New RepartoNullo
      Catch ex As Exception
         Throw (New Exception(ex.Message))
      End Try
   End Sub
   Private Function Current() As RepartoAzienda
      Return DirectCast(m_current, RepartoAzienda)
   End Function
   Public Overrides Sub CreateNew()
      m_current = New RepartoAzienda
   End Sub
   Public Overloads Overrides Sub CreateNew(ByVal Descrizione As String)
      Try
         m_current = New RepartoAzienda
         Current.Descrizione = Descrizione
         Save()
      Catch ex As Exception
         Throw New Exception(ex.Message)
      End Try
   End Sub
   ''' <summary>
   ''' Metodo che restituisce la lista delle descrizioni delle causali
   ''' </summary>
   ''' <returns></returns>
   ''' <remarks></remarks>

   Public Overrides Function GetCategoryObject() As String
      Return "RepartoAzienda"
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
      Try
         If Id = -1 Then Return New RepartoNullo
         Try
            Me.LoadById(Id)
            Return Current()
         Catch ex As Exception
            Return New RepartoNullo
         End Try
      Catch ex As Exception
         Throw New Exception("Impossibile ottenere il reparto." & vbCrLf & ex.Message)
      End Try
   End Function

   Public Overrides Function GetListaCausali() As System.Collections.ArrayList
      Try
         Dim list As New ArrayList
         LoadAll()
         For Each elem As RepartoAzienda In Me.DomainObjectList
            list.Add(elem.Descrizione)
         Next
         list.Sort()
         Return list
      Catch ex As Exception
         Throw New Exception(ex.Message)
      End Try
   End Function
End Class
