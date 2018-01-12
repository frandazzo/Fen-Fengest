Public Class ImportTipoPrestazioneException
    Inherits Exception
    Private m_message As String = ""
    Private m_Descrizione As String = ""


    Public Sub New()

    End Sub
    Public Sub New(ByVal Message As String, Optional ByVal Descrizione As String = "")
        m_message = Message
        m_Descrizione = Descrizione

    End Sub
    Public Overrides ReadOnly Property Message() As String
        Get
            Return m_message
        End Get
    End Property
    Public ReadOnly Property Descrizione() As String
        Get
            Return m_Descrizione
        End Get
    End Property

End Class
