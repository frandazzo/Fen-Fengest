Public Class ControllerAbilita
   Inherits AbstractCodificheController

   Public Overrides Sub LoadByDescrizione(ByVal Descrizione As String)

      m_current = Nothing
      LoadAll()
      For Each elem As Abilita In Me.DomainObjectList
         If elem.Descrizione = Descrizione Then m_current = elem
      Next
      If m_current Is Nothing Then m_current = New Abilita

   End Sub

   Friend Function GetAbilita(ByVal DescrizioneAbilita As String) As Abilita
      Me.LoadByDescrizione(DescrizioneAbilita)
      Return Current()
   End Function


   Private Function Current() As Abilita
      Return DirectCast(m_current, Abilita)
   End Function
   Public Overrides Sub CreateNew()
      m_current = New Abilita
   End Sub
   Public Overloads Overrides Sub CreateNew(ByVal Descrizione As String)

      m_current = New Abilita
      Current.Descrizione = Descrizione
      Save()

   End Sub
   ''' <summary>
   ''' Metodo che restituisce la lista delle descrizioni delle causali
   ''' </summary>
   ''' <returns></returns>
   ''' <remarks></remarks>

   Public Overrides Function GetCategoryObject() As String
      Return "Abilita"
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
      If Id = -1 Then Return New Abilita
      Me.LoadById(Id)
      Return Current()

   End Function

   Public Overrides Function GetListaCausali() As System.Collections.ArrayList

      Dim list As New ArrayList
      LoadAll()
      For Each elem As Abilita In Me.DomainObjectList
         list.Add(elem.Descrizione)
      Next
      list.Sort()
      Return list

   End Function
End Class
