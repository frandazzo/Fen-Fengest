Public Class ExsistReferenteChecKer
   Implements IDomainObjectExistenceChecker
   Private m_id As Int32 = -1

   ''' <summary>
   ''' I parametri ammesso sono: NOME_REFERENTE, COGNOME_REFERENTE
   ''' </summary>
   ''' <param name="Parameters"></param>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public Function Exist(ByVal Parameters As System.Collections.Hashtable) As Boolean Implements IDomainObjectExistenceChecker.Exist
      Dim controller As New WIN.APPLICATION.FINANCIAL_ARTIFACTS.ControllerReferenti
      Dim null As Boolean = False
      If String.IsNullOrEmpty(Parameters.Item("NOME_REFERENTE")) Then
         Parameters.Item("NOME_REFERENTE") = ""
         null = True
      End If
      If String.IsNullOrEmpty(Parameters.Item("COGNOME_REFERENTE")) Then
         Parameters.Item("COGNOME_REFERENTE") = ""
         null = True
      End If



      If null = True Then Return True


      m_id = controller.GetIdReferente(Parameters.Item("NOME_REFERENTE"), Parameters.Item("COGNOME_REFERENTE"))
      If m_id = -1 Then Return False
      Return True
   End Function

   Public ReadOnly Property GetId() As Integer Implements IDomainObjectExistenceChecker.GetId
      Get
         Return m_id
      End Get
   End Property
End Class
