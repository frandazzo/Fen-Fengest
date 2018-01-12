Public Class Settore
   Inherits AbstractPersistenceObject
   Protected m_Tipo As TipoSettore = TipoSettore.SettoreNullo
   'Protected m_ContrattiApplicati As New ArrayList
   'Public Sub SetListaContrattiApplicati(ByVal Lista As ArrayList)
   '   If Not Lista Is Nothing Then
   '      m_ContrattiApplicati = Lista
   '   End If
   'End Sub

   'Public Function GetListaContratti() As ArrayList
   '   Return m_ContrattiApplicati
   'End Function
   'Public Sub AddContratto(ByVal Contratto As Contratto)
   '   If Contratto Is Nothing Then Throw New Exception("Impossibile aggiungere un nuovo contratto per il settore. Contratto nullo")
   '   If Contratto.Descrizione = "" Then Throw New Exception("Impossibile aggiungere un nuovo contratto per il settore. Tipo contratto nullo")
   '   If Contratto.Settore IsNot Me Then Throw New Exception("Impossibile aggiungere un nuovo contratto al settore. Il contratto è riferito ad un settore diverso.")
   '   m_ContrattiApplicati.Add(Contratto)
   'End Sub
   'Public Sub RemoveContratto(ByVal Contratto As Contratto)
   '   If m_ContrattiApplicati.Contains(Contratto) Then
   '      m_ContrattiApplicati.Remove(Contratto)
   '   End If
   'End Sub
   'Public Function NumeroContrattiGestiti() As Int32
   '   Return m_ContrattiApplicati.Count
   'End Function
   'Public Function GetContrattoByDescrizione(ByVal Descrizione As String) As Contratto
   '   For Each elem As Contratto In m_ContrattiApplicati
   '      If elem.Descrizione = Descrizione Then Return elem
   '   Next
   '   Return New ContrattoNullo
   'End Function
   'Public Function GetContrattoById(ByVal Id As Int32) As Contratto
   '   For Each elem As Contratto In m_ContrattiApplicati
   '      If elem.TipoContratto.Id = Id Then Return elem
   '   Next
   '   Return New ContrattoNullo
   'End Function
   Public Sub New()
   End Sub
   Public Enum TipoSettore
      SettoreNullo = 0
      ImpiantiFissi = 1
      Edili = 2
   End Enum
   Public Sub New(ByVal Descrizione As String, ByVal TipologiaSettore As TipoSettore)
      MyBase.Descrizione = Descrizione
      If TipologiaSettore = TipoSettore.SettoreNullo Then Throw New Exception("Impossibile creare un settore di tipologia settore nulla.")
      m_Tipo = TipologiaSettore
   End Sub
   Public Overrides Function ToString() As String
      Return Me.Descrizione
   End Function
   ''' <summary>
   ''' 
   ''' </summary>
   ''' <param name="TipoSettore">I valori ammessi sono: "ImpiantiFissi" e "Edile"</param>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public Shared Function GetTipoSettoreByDescrizione(ByVal TipoSettore As String) As Settore.TipoSettore
      Select Case TipoSettore
         Case "ImpiantiFissi"
            Return Settore.TipoSettore.ImpiantiFissi
         Case "Edile"
            Return Settore.TipoSettore.Edili
         Case Else
            Throw New Exception("Impossibile ottenere il tipo settore richiesto. Tipo settore sconosciuto.")
      End Select
   End Function
   Public Property TipologiaSettore() As TipoSettore
      Get
         Return m_Tipo
      End Get
      Set(ByVal value As TipoSettore)
         If value = TipoSettore.SettoreNullo Then Throw New Exception("Impossibile impostare un settore di tipologia settore nulla.")
         m_Tipo = value
      End Set
   End Property
   Public Function EnteCoerenteConSettore(ByVal Ente As Azienda) As Boolean
      Select Case Me.TipologiaSettore
         Case FEDERATIONARTIFACTS.Settore.TipoSettore.Edili
            Return IIf(Ente.TipologiaAzienda = Azienda.TipoAzienda.EnteBilateraleEdili, True, False)
         Case FEDERATIONARTIFACTS.Settore.TipoSettore.ImpiantiFissi
            Return IIf(Ente.TipologiaAzienda = Azienda.TipoAzienda.AziendaPrivata, True, False)
         Case FEDERATIONARTIFACTS.Settore.TipoSettore.SettoreNullo
            Throw New Exception("Impossibile verificare la coerenza tra settore ed ente poichè non è stato impostato nessun settore per la delega corrente.")
         Case Else
            Throw New Exception("Impossibile verificare la coerenza tra settore ed ente. Tipo settore sconosciuto")
      End Select
   End Function

End Class
