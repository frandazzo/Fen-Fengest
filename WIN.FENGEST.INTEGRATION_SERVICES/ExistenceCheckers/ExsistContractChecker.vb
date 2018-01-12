Public Class ExsistContractChecker
   Implements IDomainObjectExistenceChecker
   Private m_id As Int32 = -1

   ''' <summary>
   ''' I parametri ammesso sono: CONTRATTO
   ''' </summary>
   ''' <param name="Parameters"></param>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public Function Exist(ByVal Parameters As System.Collections.Hashtable) As Boolean Implements IDomainObjectExistenceChecker.Exist
      Dim controller As New WIN.APPLICATION.ControllerTipoContratto
      If String.IsNullOrEmpty(Parameters.Item("CONTRATTO")) Then
         Parameters.Item("CONTRATTO") = ""
         Return True
      End If

 


      m_id = controller.GetIdTipoContrattoByDescrizione(UCase(Parameters.Item("CONTRATTO")))
      If m_id = -1 Then Return False
      Return True
   End Function

   Public ReadOnly Property GetId() As Integer Implements IDomainObjectExistenceChecker.GetId
      Get
         Return m_id
      End Get
   End Property
End Class
