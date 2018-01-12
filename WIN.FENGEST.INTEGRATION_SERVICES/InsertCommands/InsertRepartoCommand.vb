Public Class InsertRepartoCommand
   Implements ICommand
   Private m_parameters As Hashtable
   ''' <summary>
   ''' Costruttore comando
   ''' </summary>
   ''' <param name="Parameters">Le chiavi ammesse sono: REPARTO</param>
   ''' <remarks></remarks>
   Public Sub New(ByVal Parameters As Hashtable)
      m_parameters = Parameters
   End Sub
   Public Sub Execute() Implements ICommand.Execute
      Dim controller As New WIN.APPLICATION.ControllerReparti
      Try
         controller.CreateNew()
         controller.Descrizione = m_parameters.Item("REPARTO")
         controller.Save()
      Catch ex As Exception
         Throw New ImportRepartiException(ex.Message, m_parameters.Item("REPARTO"))
      End Try
   End Sub
End Class
