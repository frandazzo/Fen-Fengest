Public Class ExsistAziendaChecker
   Implements IDomainObjectExistenceChecker
   Private m_id As Int32 = -1
   Private m_VerificaAziendaImpiego As Boolean

   Public Sub New()

   End Sub
   Public Sub New(ByVal VerificaImpiego As Boolean)
      m_VerificaAziendaImpiego = VerificaImpiego
   End Sub


   ''' <summary>
   ''' I parametri ammesso sono: ENTE, PATITA_IVA
   ''' </summary>
   ''' <param name="Parameters"></param>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public Function Exist(ByVal Parameters As System.Collections.Hashtable) As Boolean Implements IDomainObjectExistenceChecker.Exist
      Dim controller As New WIN.APPLICATION.AZIENDE.ControllerAziende

      Dim descr As String

      If m_VerificaAziendaImpiego Then
         If String.IsNullOrEmpty(Parameters.Item("AZIENDA_IMPIEGO")) Then
            Parameters.Item("AZIENDA_IMPIEGO") = ""
            Return True
         Else
            descr = Parameters.Item("AZIENDA_IMPIEGO")
         End If
      Else
         If String.IsNullOrEmpty(Parameters.Item("ENTE")) Then
            Parameters.Item("ENTE") = ""
            Return True
         Else
            descr = Parameters.Item("ENTE")
         End If
      End If



      Dim nomeEnte As String

      nomeEnte = descr

      If Parameters.Item("PARTITA_IVA") Is Nothing Then Parameters.Item("PARTITA_IVA") = ""

      'm_id = controller.GetIdAzienda(nomeEnte, Parameters.Item("PARTITA_IVA").ToString)
      'If m_id = -1 Then
      '   m_id = controller.GetIdAzienda(nomeEnte)
      '   If m_id = -1 Then Return False
      'End If
      'Return True


      m_id = AziendaRetriever.GetIdAzienda(Parameters.Item("PARTITA_IVA"), nomeEnte)

      If m_id = -1 Then Return False
      Return True
   End Function

   Public ReadOnly Property GetId() As Integer Implements IDomainObjectExistenceChecker.GetId
      Get
         Return m_id
      End Get
   End Property
End Class
