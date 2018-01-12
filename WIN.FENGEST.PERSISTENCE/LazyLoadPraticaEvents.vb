Public Class LazyLoadPraticaEvents
    Inherits VirtualLazyList

    Private m_ListLoader As MapperPratica
    Private m_templ As Pratica
    Private query As Query

    Public Sub New(ByVal group As Pratica, listLoader As MapperPratica)
        m_templ = group
        m_ListLoader = listLoader

    End Sub



    Protected Overrides Function GetList() As System.Collections.ArrayList
        If Source Is Nothing Then
            Source = m_ListLoader.FindListaEvents(m_templ)
        End If
        Return Source
    End Function
End Class
