Public Class ExistAzindaImpiegoChecker
   Implements IDomainObjectExistenceChecker
   Private m_id As Int32 = -1

   ''' <summary>
   ''' I parametri ammesso sono: ENTE, PATITA_IVA
   ''' </summary>
   ''' <param name="Parameters"></param>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public Function Exist(ByVal Parameters As System.Collections.Hashtable) As Boolean Implements IDomainObjectExistenceChecker.Exist
      Dim controller As New WIN.APPLICATION.AZIENDE.ControllerAziende

      If String.IsNullOrEmpty(Parameters.Item("AZIENDA_IMPIEGO")) Then
         Parameters.Item("AZIENDA_IMPIEGO") = ""
         Return True
      End If


      Dim nomeAz As String
      nomeAz = Parameters.Item("AZIENDA_IMPIEGO")
      If Parameters.Item("PARTITA_IVA") Is Nothing Then Parameters.Item("PARTITA_IVA") = ""

      'If Parameters.Item("PARTITA_IVA").ToString <> "" Then
      '   m_id = controller.GetIdAziendaByPIVA(Parameters.Item("PARTITA_IVA").ToString)
      '   If m_id <> -1 Then Return True
      'End If


      'm_id = controller.GetIdAzienda(nomeAz, Parameters.Item("PARTITA_IVA"))
      'If m_id = -1 Then
      '   m_id = controller.GetIdAzienda(nomeAz)
      '   If m_id = -1 Then Return False
      'End If
      'Return True
      m_id = AziendaRetriever.GetIdAzienda(Parameters.Item("PARTITA_IVA"), nomeAz)
      If m_id = -1 Then Return False
      Return True
   End Function

   Public ReadOnly Property GetId() As Integer Implements IDomainObjectExistenceChecker.GetId
      Get
         Return m_id
      End Get
   End Property
End Class
