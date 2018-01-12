Public Class ImportRevocaDelegaException
    Inherits Exception
    Private m_message As String = ""
    Private m_Nome As String = ""
    Private m_Cognome As String = ""
    Private m_NomeAzienda As String = ""


    Public Sub New()

    End Sub
    Public Sub New(ByVal Message As String, Optional ByVal Nome As String = "", Optional ByVal Cognome As String = "", Optional ByVal NomeAzienda As String = "")
        m_message = Message
        m_Nome = Nome
        m_NomeAzienda = NomeAzienda
        m_Cognome = Cognome
    End Sub
    Public Overrides ReadOnly Property Message() As String
        Get
            Return m_message
        End Get
    End Property
    Public ReadOnly Property Nome() As String
        Get
            Return m_Nome
        End Get
    End Property
    Public ReadOnly Property Cognome() As String
        Get
            Return m_Cognome
        End Get
    End Property
    Public ReadOnly Property NomeAzienda() As String
        Get
            Return m_NomeAzienda
        End Get
    End Property
End Class
