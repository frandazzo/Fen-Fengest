Public Class ComponenteLista
    Public Enum ComponentType
        ListaLavoro
        DocumentoContabile
        Report
    End Enum



    Private m_Descrizione As String = ""
    Private m_Tipo As ComponentType = ComponentType.ListaLavoro
    Private m_ListaLavoro As ListaLavoroUtenti



    Public Sub New(ByVal DescrizioneComponente As String, ByVal TipoComponente As ComponentType, ByVal Lista As ListaLavoroUtenti)
        If Lista Is Nothing Then Throw New NullReferenceException("Selezionare una lista di lavoro")

        m_Descrizione = DescrizioneComponente
        m_Tipo = TipoComponente
        m_ListaLavoro = Lista

    End Sub

    Public Property ListaLavoro() As ListaLavoroUtenti
        Get
            Return m_ListaLavoro
        End Get
        Set(ByVal value As ListaLavoroUtenti)
            m_ListaLavoro = value
        End Set
    End Property

    Public ReadOnly Property Tipo() As ComponentType
        Get
            Return m_Tipo
        End Get

    End Property

    Public Overrides Function ToString() As String
        If m_Tipo = ComponentType.DocumentoContabile Then
            Return m_Descrizione & " - (Documento contabile)"
        End If
        If m_Tipo = ComponentType.Report Then
            Return m_Descrizione & " - (Report)"
        End If

        If m_Tipo = ComponentType.ListaLavoro Then
            Return m_Descrizione & " - (Lista lavoro)"
        End If

        Return ""
    End Function



    Public ReadOnly Property Descrizione() As String
        Get
            Return m_Descrizione
        End Get

    End Property

End Class
