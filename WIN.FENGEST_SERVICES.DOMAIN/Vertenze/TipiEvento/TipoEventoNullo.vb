Public Class TipoEventoNullo
   Inherits TipoEvento
   Public Sub New()
      MyBase.Key = New Key(-1)
      MyBase.m_Tipo = TipologiaEvento.TipoNullo
   End Sub
End Class
