Public Class LazyLoadIncarichi
    Inherits VirtualLazyList

    Private ListLoader As MapperIncarico = PersistenceMapperRegistry.Instance.GetMapperByName("MapperIncarico")
    Private m_Utente As Utente

    Public Sub New(ByVal Utente As Utente)
        m_Utente = Utente
    End Sub



    Protected Overrides Function GetList() As System.Collections.ArrayList
        If Source Is Nothing Then
            Source = ListLoader.FindIncaricoByUtente(m_Utente)
        End If
        Return Source
    End Function
End Class
