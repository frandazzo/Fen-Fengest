Public Class ExistUserChekcer
   Implements IDomainObjectExistenceChecker
   Private m_id As Int32 = -1

   ''' <summary>
   ''' I parametri ammesso sono: NOME_UTENTE, COGNOME_UTENTE, DATA_NASCITA_UTENTE
   ''' </summary>
   ''' <param name="Parameters"></param>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public Function Exist(ByVal Parameters As System.Collections.Hashtable) As Boolean Implements IDomainObjectExistenceChecker.Exist
      Dim controller As New WIN.APPLICATION.UTENTI.ControllerUtenti
      If Parameters.Item("DATA_NASCITA_UTENTE") Is Nothing Then Parameters.Item("DATA_NASCITA_UTENTE") = ""
      If Parameters.Item("NOME_UTENTE") Is Nothing Then Parameters.Item("NOME_UTENTE") = ""
        If Parameters.Item("COGNOME_UTENTE") Is Nothing Then Parameters.Item("COGNOME_UTENTE") = ""

        'tolgo eventuali orari in formato invariant culture derivanti da file excel o xml
        Parameters.Item("DATA_NASCITA_UTENTE") = Parameters.Item("DATA_NASCITA_UTENTE").ToString().Replace(" 0.00.00", "")


      If Parameters.Item("FISCALE") Is Nothing Then Parameters.Item("FISCALE") = ""

      Dim nome As String = Parameters.Item("NOME_UTENTE")
      Dim cognome As String = Parameters.Item("COGNOME_UTENTE")


      If Not IsDate(Parameters.Item("DATA_NASCITA_UTENTE")) Then
         Parameters.Item("DATA_NASCITA_UTENTE") = "01/01/1900"
      End If
 


      m_id = UtenteRetriever.GetIdUtente(Parameters.Item("FISCALE"), nome, cognome, Parameters.Item("DATA_NASCITA_UTENTE"))
      If m_id > -1 Then Return True

      Return False

   End Function

   Public ReadOnly Property GetId() As Integer Implements IDomainObjectExistenceChecker.GetId
      Get
         Return m_id
      End Get
   End Property
End Class
