Public Class InsertReferenteCommand
   Implements ICommand
   Private m_parameters As Hashtable
   ''' <summary>
   ''' Costruttore comando
   ''' </summary>
   ''' <param name="Parameters">Le chiavi ammesse sono: NOME_REFERENTE, COGNOME_REFERENTE</param>
   ''' <remarks></remarks>
   Public Sub New(ByVal Parameters As Hashtable)
      m_parameters = Parameters
   End Sub
   Public Sub Execute() Implements ICommand.Execute
      Dim controller As New WIN.APPLICATION.FINANCIAL_ARTIFACTS.ControllerReferenti
      Try
         controller.CreateNew()
         controller.Nome = m_parameters.Item("NOME_REFERENTE")
         controller.Cognome = m_parameters.Item("COGNOME_REFERENTE")
         controller.Save()
      Catch ex As Exception
         Throw New ImportReferenteException(ex.Message, m_parameters.Item("COGNOME_REFERENTE"))
      End Try
   End Sub
End Class
