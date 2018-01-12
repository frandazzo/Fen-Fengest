Public Class ItemPagamentoReferenti
   Inherits ItemContabile

   Public Sub New(ByVal PagamentoReferenti As DocumentoContabile, ByVal Importo As Moneta, _
                  ByVal Conto As Conto, ByVal Note As String, ByVal Referente As Referente)
      MyBase.New(PagamentoReferenti, Note, Importo, Conto)
      MyBase.m_TipoDocumento = "PGR"
      MyBase.m_Referente = Referente
   End Sub
   Protected Overrides Sub DoPost()
      Me.PagamentoReferente = Me.DocumentoPadre
      If Not TypeOf (Referente) Is ReferenteNullo Then
         Referente.UltimoRistorno = Me.DocumentoPadre
      End If
   End Sub
End Class
