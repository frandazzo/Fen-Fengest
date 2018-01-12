Public Class IncaricoDTO
    Inherits AbstractPersistenceObject


    Private m_IdUtente As Int32

    Private m_IdAzienda As Int32

    Private m_Notes As String

    Private m_Nome As String

    Private m_Cognome As String

    Private m_Mail As String

    Private m_Cell1 As String

    Private m_Cell2 As String

    Private m_CodiceFiscale As String

    Private m_Indirizzo As String

    Private m_Tel As String

    Private m_Cap As String

    Private m_ComuneResidenza As String

    Private m_ProvinciaResidenza As String

    Private m_Azienda As String

    Private m_IndirizzoAzienda As String

    Private m_CapAzienda As String

    Public Property CapAzienda() As String
        Get
            Return m_CapAzienda
        End Get
        Set(ByVal value As String)
            m_CapAzienda = value
        End Set
    End Property


    Public Property IndirizzoAzienda() As String
        Get
            Return m_IndirizzoAzienda
        End Get
        Set(ByVal value As String)
            m_IndirizzoAzienda = value
        End Set
    End Property


    Public Property Azienda() As String
        Get
            Return m_Azienda
        End Get
        Set(ByVal value As String)
            m_Azienda = value
        End Set
    End Property


    Public Property ProvinciaResidenza() As String
        Get
            Return m_ProvinciaResidenza
        End Get
        Set(ByVal value As String)
            m_ProvinciaResidenza = value
        End Set
    End Property


    Public Property ComuneResidenza() As String
        Get
            Return m_ComuneResidenza
        End Get
        Set(ByVal value As String)
            m_ComuneResidenza = value
        End Set
    End Property




    Private m_ComuneAzienda As String

    Private m_ProvinciaAzienda As String



    Public Property ProvinciaAzienda() As String
        Get
            Return m_ProvinciaAzienda
        End Get
        Set(ByVal value As String)
            m_ProvinciaAzienda = value
        End Set
    End Property


    Public Property ComuneAzienda() As String
        Get
            Return m_ComuneAzienda
        End Get
        Set(ByVal value As String)
            m_ComuneAzienda = value
        End Set
    End Property


    Public Property Cap() As String
        Get
            Return m_Cap
        End Get
        Set(ByVal value As String)
            m_Cap = value
        End Set
    End Property


    Public Property Tel() As String
        Get
            Return m_Tel
        End Get
        Set(ByVal value As String)
            m_Tel = value
        End Set
    End Property


    Public Property Indirizzo() As String
        Get
            Return m_Indirizzo
        End Get
        Set(ByVal value As String)
            m_Indirizzo = value
        End Set
    End Property


    Public Property CodiceFiscale() As String
        Get
            Return m_CodiceFiscale
        End Get
        Set(ByVal value As String)
            m_CodiceFiscale = value
        End Set
    End Property


    Public Property Cell2() As String
        Get
            Return m_Cell2
        End Get
        Set(ByVal value As String)
            m_Cell2 = value
        End Set
    End Property


    Public Property Cell1() As String
        Get
            Return m_Cell1
        End Get
        Set(ByVal value As String)
            m_Cell1 = value
        End Set
    End Property


    Public Property Mail() As String
        Get
            Return m_Mail
        End Get
        Set(ByVal value As String)
            m_Mail = value
        End Set
    End Property



    Public Property Cognome() As String
        Get
            Return m_Cognome
        End Get
        Set(ByVal value As String)
            m_Cognome = value
        End Set
    End Property


    Public Property Nome() As String
        Get
            Return m_Nome
        End Get
        Set(ByVal value As String)
            m_Nome = value
        End Set
    End Property



    Public Property Notes() As String
        Get
            Return m_Notes
        End Get
        Set(ByVal value As String)
            m_Notes = value
        End Set
    End Property


    Public Property IdAzienda() As Int32
        Get
            Return m_IdAzienda
        End Get
        Set(ByVal value As Int32)
            m_IdAzienda = value
        End Set
    End Property



    Public Property IdUtente() As Int32
        Get
            Return m_IdUtente
        End Get
        Set(ByVal value As Int32)
            m_IdUtente = value
        End Set
    End Property

    Private m_TipoIncarico As String

    Public Property TipoIncarico() As String
        Get
            Return m_TipoIncarico
        End Get
        Set(ByVal value As String)
            m_TipoIncarico = value
        End Set
    End Property



End Class
