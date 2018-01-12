Public Class DocumentoNullo
   Inherits DocumentoContabile
   Public Sub New()
      MyBase.New(DateTime.MinValue, DateTime.MinValue, "DocumentoNullo")
      MyBase.m_TipoDocumento = "Nullo"
      MyBase.Key = New Key(-1)
   End Sub
End Class
