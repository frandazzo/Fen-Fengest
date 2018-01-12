Namespace ADMINISTRATION
   Public Class ControllerIstituti
      Inherits AbstractCodificheController


      'Public Property Descrizione() As String
      '   Get
      '      Return Current.Descrizione
      '   End Get
      '   Set(ByVal value As String)
      '      Current.Descrizione = value
      '   End Set
      'End Property
      'Public ReadOnly Property Id() As Int32
      '   Get
      '      Return (Current.Id)
      '   End Get
      'End Property
      Public Overrides Sub LoadByDescrizione(ByVal Descrizione As String)
         Try
            LoadAll()
            For Each elem As IstitutoContrattuale In Me.DomainObjectList
               If elem.Descrizione = Descrizione Then m_current = elem
            Next
            If m_current Is Nothing Then m_current = New IstitutoNullo
         Catch ex As Exception
            Throw (New Exception(ex.Message))
         End Try
      End Sub
      Private Function Current() As IstitutoContrattuale
         Return DirectCast(m_current, IstitutoContrattuale)
      End Function
      Public Overrides Sub CreateNew()
         m_current = New IstitutoContrattuale
      End Sub
      Public Overloads Overrides Sub CreateNew(ByVal Descrizione As String)
         Try
            m_current = New IstitutoContrattuale
            Current.Descrizione = Descrizione
            Save()
         Catch ex As Exception
            Throw New Exception(ex.Message)
         End Try
      End Sub
      ''' <summary>
      ''' Metodo che restituisce la lista delle descrizioni degli istituti
      ''' </summary>
      ''' <returns></returns>
      ''' <remarks></remarks>

      Public Overrides Function GetCategoryObject() As String
         Return "IstitutoContrattuale"
      End Function
      'Friend Function GetIstitutoById(ByVal Id As String) As IstitutoContrattuale
      '   Try
      '      If Id = -1 Then Return New IstitutoNullo
      '      Me.LoadById(Id)
      '      Return Current()
      '   Catch ex As Exception
      '      Throw New Exception("Impossibile ottenere l' Istituto contrattuale." & vbCrLf & ex.Message)
      '   End Try
      'End Function
      'Public overridesFunction GetIdByDescrizione(ByVal Descrizione As String) As String
      '   Try
      '      LoadByDescrizione(Descrizione)
      '      Return Current.Id
      '   Catch ex As Exception
      '      Throw New Exception(ex.Message)
      '   End Try
      'End Function

      Friend Overrides Function GetCausaleById(ByVal Id As String) As AbstractPersistenceObject
         Try
            If Id = -1 Then Return New IstitutoNullo
            Me.LoadById(Id)
            Return Current()
         Catch ex As Exception
            Throw New Exception("Impossibile ottenere l' Istituto contrattuale." & vbCrLf & ex.Message)
         End Try
      End Function

      Public Overrides Function GetListaCausali() As System.Collections.ArrayList
         Try
            Dim list As New ArrayList
            LoadAll()
            For Each elem As IstitutoContrattuale In Me.DomainObjectList
               list.Add(elem.Descrizione)
            Next
            list.Sort()
            Return list
         Catch ex As Exception
            Throw New Exception(ex.Message)
         End Try
      End Function
   End Class
End Namespace