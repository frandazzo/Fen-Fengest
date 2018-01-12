Public Class ConfrontoListeUtenti



    Private m_DescrizioneLista1 As String = ""
    Private m_DescrizioneLista2 As String = ""
    Private m_DescrizioneElementiComuni As String = "Elementi comuni"



    Private m_ListaLavoro1 As ListaLavoroUtenti
    Private m_ListaLavoro2 As ListaLavoroUtenti
    Private m_ListaConfronto As ListaLavoroUtenti

    Friend Function GetListaLavoroByIndex(ByVal index As Int32) As ListaLavoroUtenti
        If index = 1 Then
            Return m_ListaLavoro1
        End If

        If index = 2 Then
            Return m_ListaLavoro2
        End If


        If index = 3 Then
            Return m_ListaConfronto
        End If

        Throw New InvalidOperationException("Indice lista lavoro inesistente")

    End Function


    Public Function GetExporter() As ExcelExporterConfronto

        Dim e As New ExcelExporterConfronto(Me)

        Return e


    End Function



    Public Property ListaConfronto() As ListaLavoroUtenti
        Get
            Return m_ListaConfronto
        End Get
        Set(ByVal value As ListaLavoroUtenti)
            m_ListaConfronto = value
        End Set
    End Property

    Public Property ListaLavoro2() As ListaLavoroUtenti
        Get
            Return m_ListaLavoro2
        End Get
        Set(ByVal value As ListaLavoroUtenti)
            m_ListaLavoro2 = value
        End Set
    End Property

    Public Property ListaLavoro1() As ListaLavoroUtenti
        Get
            Return m_ListaLavoro1
        End Get
        Set(ByVal value As ListaLavoroUtenti)
            m_ListaLavoro1 = value
        End Set
    End Property




    Public Property DescrizioneElementiComuni() As String
        Get
            Return m_DescrizioneElementiComuni
        End Get
        Set(ByVal value As String)
            m_DescrizioneElementiComuni = value
        End Set
    End Property



    Public Property DescrizioneLista2() As String
        Get
            Return m_DescrizioneLista2
        End Get
        Set(ByVal value As String)
            m_DescrizioneLista2 = value
        End Set
    End Property


    Public Property DescrizioneLista1() As String
        Get
            Return m_DescrizioneLista1
        End Get
        Set(ByVal value As String)
            m_DescrizioneLista1 = value
        End Set
    End Property


    Public ReadOnly Property ElementiTotali() As Int32
        Get
            Return m_ListaLavoro1.ListaUtenti.Count + m_ListaLavoro2.ListaUtenti.Count + m_ListaConfronto.ListaUtenti.Count
        End Get
    End Property


End Class
