Public Class TipoEventoProcedimentoLegale
   Inherits TipoEvento


   Public Sub New()
      MyBase.Descrizione = "Procedimento legale"
      MyBase.m_Tipo = TipologiaEvento.ProcedimentoLegale
   End Sub
   Public Sub New(ByVal Avvocato As String, ByVal InterventoRichiesto As String)
      m_Avvocato = Avvocato
      m_Intervento = InterventoRichiesto
      MyBase.Descrizione = "Procedimento legale"
      MyBase.m_Tipo = TipologiaEvento.ProcedimentoLegale
   End Sub
   
End Class
