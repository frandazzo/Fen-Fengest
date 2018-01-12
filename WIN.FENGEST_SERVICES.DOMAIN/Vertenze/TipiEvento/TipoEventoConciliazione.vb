Public Class TipoEventoConciliazione
   Inherits TipoEvento
   Public Sub New()
      MyBase.Descrizione = "Conciliazione"
      MyBase.m_Tipo = TipologiaEvento.Conciliazione
   End Sub
End Class
