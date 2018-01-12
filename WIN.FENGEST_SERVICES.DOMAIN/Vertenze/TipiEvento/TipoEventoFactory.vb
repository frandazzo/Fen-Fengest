Public Class TipoEventoFactory
   Private Shared m_instance As TipoEventoFactory
   Private m_Avvocato As String = ""
   Private m_Intervento As String = ""
   Private m_EnteInoltro As String = ""
   Public Shared Function Instance() As TipoEventoFactory
      If m_instance Is Nothing Then
         m_instance = New TipoEventoFactory
      End If
      Return m_instance
   End Function
   Public WriteOnly Property Avvocato() As String
      Set(ByVal value As String)
         m_Avvocato = value
      End Set
   End Property
   Public WriteOnly Property Intervento() As String
      Set(ByVal value As String)
         m_Intervento = value
      End Set
   End Property
   Public WriteOnly Property EnteInoltro() As String
      Set(ByVal value As String)
         m_EnteInoltro = value
      End Set
   End Property

   Public Function GetTipoEvento(ByVal Tipo As TipoEvento.TipologiaEvento) As TipoEvento
      Dim tipoEv As TipoEvento
      Select Case Tipo
         Case TipoEvento.TipologiaEvento.Conciliazione
            tipoEv = New TipoEventoConciliazione
         Case TipoEvento.TipologiaEvento.MancataConciliazione
            tipoEv = New TipoEventoMancataConciliazione
         Case TipoEvento.TipologiaEvento.ProcedimentoAmministrativo
            tipoEv = New TipoEventoProcedimentoAmministrativo()
         Case TipoEvento.TipologiaEvento.ProcedimentoLegale
            tipoEv = New TipoEventoProcedimentoLegale()
         Case TipoEvento.TipologiaEvento.TipoNullo
            tipoEv = New TipoEventoNullo
         Case Else
            Throw New Exception("Impossibile ottenere il tipo evento. Tipo evento sconosciuto.")
      End Select
      tipoEv.InterventoRichiesto = m_Intervento
      tipoEv.EnteInoltro = m_EnteInoltro
      tipoEv.Avvocato = m_Avvocato
      Return tipoEv
   End Function
End Class
