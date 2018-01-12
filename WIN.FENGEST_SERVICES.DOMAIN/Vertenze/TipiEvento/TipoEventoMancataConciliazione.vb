Public Class TipoEventoMancataConciliazione
   Inherits TipoEvento
   Public Sub New()
      MyBase.Descrizione = "Mancata conciliazione"
      MyBase.m_Tipo = TipologiaEvento.MancataConciliazione
   End Sub
End Class
