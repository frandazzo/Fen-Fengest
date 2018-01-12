Imports System.Text.RegularExpressions

Public Class SmsRecipient

    Public Sub New(utente As UtenteDTO)
        m_utente = utente
        CalculateNumber()
    End Sub

    Public Sub New(utente As Utente)


        Dim u As New UtenteDTO
        u.Id = utente.Id
        u.CompleteName = utente.CompleteName
        u.Cellulare1 = utente.Comunicazione.Cellulare1
        u.Cellulare2 = utente.Comunicazione.Cellulare2
        m_utente = u
        CalculateNumber()
    End Sub

    Private m_isValid As Boolean

    Public Property IsValid() As Boolean
        Get
            Return m_isValid
        End Get
        Set(ByVal value As Boolean)
            m_isValid = value
        End Set
    End Property


    Private m_utente As UtenteDTO
    Private m_recipient As String

    Public ReadOnly Property Utente() As UtenteDTO
        Get
            Return m_utente
        End Get

    End Property

    Public ReadOnly Property NomeUtente() As String
        Get
            Return m_utente.CompleteName
        End Get

    End Property

    Public ReadOnly Property Cell1() As String
        Get
            Return m_utente.Cellulare1
        End Get

    End Property

    Public ReadOnly Property Cell2() As String
        Get
            Return m_utente.Cellulare2
        End Get

    End Property


    Public ReadOnly Property RecipientNumber() As String
        Get
            Return m_recipient
        End Get

    End Property

    Private Sub CalculateNumber()
        If String.IsNullOrEmpty(m_utente.Cellulare1) And String.IsNullOrEmpty(m_utente.Cellulare2) Then
            m_recipient = m_recipient
            Return
        End If
        If String.IsNullOrEmpty(m_utente.Cellulare1) Then
            m_recipient = NormalizeNumber(m_utente.Cellulare2)
            Return

        End If
        If String.IsNullOrEmpty(m_utente.Cellulare2) Then
            m_recipient = NormalizeNumber(m_utente.Cellulare1)
            Return
        End If
        'se sono entrambi valorizzati provo la normallazione del cell 1 
        Dim number As String = NormalizeNumber(m_utente.Cellulare1)
        If Not String.IsNullOrEmpty(number) Then
            m_recipient = number
            Return
        End If
        'altrimenti passo alla 2
        m_recipient = NormalizeNumber(m_utente.Cellulare2)
    End Sub

    Private Function NormalizeNumber(number As String) As String
        'elimino tutti caratteri non numerici dal cellulare
        Dim digitsOnly As Regex = New Regex("[^\d]")
        Dim result As String = digitsOnly.Replace(number, "")

        'verifico se la stringa contiene almeno 9 caratteri (3 di prefisso e 6 di numeri)
        'e non piu di 10 caratteri  (3 di prefisso e 7 di numeri)
        Dim lenght As Int32 = result.Length
        If lenght < 9 Then
            Return ""
        End If
        If lenght > 10 Then
            Return ""
        End If

        'restituisco il numero di telefono con il 39 davanti
        'indico che il risultato è cotrretto
        m_isValid = True
        Return "39" + result

    End Function



End Class
