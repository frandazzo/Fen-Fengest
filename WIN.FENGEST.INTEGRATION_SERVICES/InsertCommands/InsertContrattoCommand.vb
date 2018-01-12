Imports WIN.BASEREUSE

Public Class InsertContrattoCommand
   Implements ICommand
   Private m_parameters As Hashtable
   ''' <summary>
   ''' Costruttore comando
   ''' </summary>
   ''' <param name="Parameters">Le chiavi ammesse sono: PARTITA_IVA, CONTRATTO, SETTORE: IMPIANTI FISSI, EDILE</param>
   ''' <remarks></remarks>
   Public Sub New(ByVal Parameters As Hashtable)
      m_parameters = Parameters
   End Sub
   Public Sub Execute() Implements ICommand.Execute

      If Not m_parameters.Contains("SETTORE") Then
         InsertContract(m_parameters, "EDILE")
         Return
      End If

      If m_parameters.Item("SETTORE") = "IMPIANTI FISSI" Or m_parameters.Item("SETTORE") = "EDILE" Then
         InsertContract(m_parameters, m_parameters.Item("SETTORE"))
      Else
         Throw New IMPORT_EXPORT_SERVICES.ImportContrattiException("Settore non corrispondente", m_parameters.Item("CONTRATTO"), m_parameters.Item("SETTORE"))
      End If
   End Sub

   Private Sub InsertContract(ByVal param As Hashtable, ByVal Settore As String)
      Dim controller As New WIN.APPLICATION.ControllerTipoContratto
      Try
         controller.CreateNew(param.Item("CONTRATTO"), Settore)
      Catch ex As Exception
         Throw New ImportContrattiException(ex.Message, param.Item("CONTRATTO"), "")
      End Try
   End Sub


End Class
