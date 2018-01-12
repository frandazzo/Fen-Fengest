Public Class ExsistRepartoChecker
   Implements IDomainObjectExistenceChecker
   Private m_id As Int32 = -1

   ''' <summary>
   ''' I parametri ammesso sono: REPARTO
   ''' </summary>
   ''' <param name="Parameters"></param>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public Function Exist(ByVal Parameters As System.Collections.Hashtable) As Boolean Implements IDomainObjectExistenceChecker.Exist
      Dim controller As New WIN.APPLICATION.ControllerReparti
      If String.IsNullOrEmpty(Parameters.Item("REPARTO")) Then
         Parameters.Item("REPARTO") = ""
         Return True
      End If

      m_id = controller.GetIdByDescrizione(Parameters.Item("REPARTO"))
      If m_id = -1 Then Return False
      Return True
   End Function

   Public ReadOnly Property GetId() As Integer Implements IDomainObjectExistenceChecker.GetId
      Get
         Return m_id
      End Get
   End Property
End Class
