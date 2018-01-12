Public Class TipoEventoProcedimentoAmministrativo
   Inherits TipoEvento


   Public Sub New()
      MyBase.Descrizione = "Procedimento amministrativo"
      MyBase.m_Tipo = TipologiaEvento.ProcedimentoAmministrativo
   End Sub
   Public Sub New(ByVal EnteInoltro As String)
      m_EnteInoltro = EnteInoltro
      MyBase.Descrizione = "Procedimento amministrativo"
      MyBase.m_Tipo = TipologiaEvento.ProcedimentoAmministrativo
   End Sub
   

End Class
