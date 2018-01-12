Public Class TipoEvento
   Inherits AbstractPersistenceObject
   Protected m_Tipo As TipoEvento.TipologiaEvento
   Protected m_EnteInoltro As String = ""
   Protected m_Avvocato As String = ""
   Protected m_Intervento As String = ""
   Public Sub New()

   End Sub

   Public Property EnteInoltro() As String
      Get
         Return m_EnteInoltro
      End Get
      Set(ByVal value As String)
         m_EnteInoltro = value
      End Set
   End Property

   Public Property InterventoRichiesto() As String
      Get
         Return m_Intervento
      End Get
      Set(ByVal value As String)
         m_Intervento = value
      End Set
   End Property
   Public Property Avvocato() As String
      Get
         Return m_Avvocato
      End Get
      Set(ByVal value As String)
         m_Avvocato = value
      End Set
   End Property

   Public Enum TipologiaEvento
      TipoNullo
      ProcedimentoAmministrativo
      ProcedimentoLegale
      Conciliazione
      MancataConciliazione
   End Enum
   Public Shared Function GetListaTipi() As ArrayList
      Dim lista As New ArrayList
      lista.Add("Conciliazione")
      lista.Add("Mancata conciliazione")
      lista.Add("Procedimento amministrativo")
      lista.Add("Procedimento legale")
      Return lista
   End Function
   Public Shared Function GetTipoEventoToString(ByVal TipoEvento As TipoEvento.TipologiaEvento) As String
      Select Case TipoEvento
         Case TipologiaEvento.Conciliazione
            Return "Conciliazione"
         Case TipologiaEvento.MancataConciliazione
            Return "Mancata conciliazione"
         Case TipologiaEvento.ProcedimentoAmministrativo
            Return "Procedimento amministrativo"
         Case TipologiaEvento.ProcedimentoLegale
            Return "Procedimento legale"
         Case TipologiaEvento.TipoNullo
            Return "Tipo evento nullo"
         Case Else
            Throw New Exception("Impossibile ottenere la descrizione del tipo evento. Tipo evento sconosciuto")
      End Select
   End Function
   Public Shared Function GetTipoEventoByDescrizione(ByVal TipoEvento As String) As TipoEvento.TipologiaEvento
      Select Case TipoEvento
         Case "Conciliazione"
            Return TipologiaEvento.Conciliazione
         Case "Mancata conciliazione"
            Return TipologiaEvento.MancataConciliazione
         Case "Procedimento amministrativo"
            Return TipologiaEvento.ProcedimentoAmministrativo
         Case "Procedimento legale"
            Return TipologiaEvento.ProcedimentoLegale
         Case "Tipo evento nullo"
            Return TipologiaEvento.TipoNullo
         Case Else
            Throw New Exception("Impossibile ottenere il tipo evento. Descrizione non codificata")
      End Select
   End Function

   Public Property Tipo() As TipologiaEvento
      Get
         Return m_Tipo
      End Get
      Set(ByVal value As TipologiaEvento)
         m_Tipo = value
         MyBase.Descrizione = GetTipoEventoToString(m_Tipo)
      End Set
   End Property
End Class
