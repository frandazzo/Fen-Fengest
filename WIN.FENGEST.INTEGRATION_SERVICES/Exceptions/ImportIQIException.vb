﻿Public Class ImportIQIException
    Inherits Exception
    Private m_message As String = ""
    Private m_Nome As String = ""
    Private m_Cognome As String = ""



    Public Sub New()

    End Sub
    Public Sub New(ByVal Message As String, Optional ByVal Nome As String = "", Optional ByVal Cognome As String = "")
        m_message = Message
        m_Nome = Nome

        m_Cognome = Cognome
    End Sub
    Public Overrides ReadOnly Property Message() As String
        Get
            Return m_message & vbCrLf & m_Nome & " " & m_Cognome
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

End Class
