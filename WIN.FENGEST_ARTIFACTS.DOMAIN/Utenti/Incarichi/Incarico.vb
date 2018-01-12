Public Class Incarico
    Inherits AbstractPersistenceObject

    Private m_Azienda As Azienda

    Private m_Utente As Utente

    Private n_Notes As String

    Private M_TipoIncarico As TipoIncarico

    Public Property TipoIncarico() As TipoIncarico
        Get
            Return M_TipoIncarico
        End Get
        Set(ByVal value As TipoIncarico)
            M_TipoIncarico = value
        End Set
    End Property



    Public Property Notes() As String
        Get
            Return n_Notes
        End Get
        Set(ByVal value As String)
            n_Notes = value
        End Set
    End Property


    Public Property Utente() As Utente
        Get
            Return m_Utente
        End Get
        Set(ByVal value As Utente)
            m_Utente = value
        End Set
    End Property



    Public Property Azienda() As Azienda
        Get
            Return m_Azienda
        End Get
        Set(ByVal value As Azienda)
            m_Azienda = value
        End Set
    End Property


    Protected Overrides Sub DoValidation()

        If m_Utente Is Nothing Then
            ValidationErrors.Add("Utente non specificato")
        End If

        If M_TipoIncarico Is Nothing Then
            ValidationErrors.Add("Tipo di incoarico non specificato")
        End If

    End Sub



End Class
