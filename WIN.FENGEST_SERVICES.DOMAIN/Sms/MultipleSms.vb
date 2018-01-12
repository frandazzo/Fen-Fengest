Public Class MultipleSms
    Public Sub New(listaLavoro As IList, text As String)
        'If String.IsNullOrEmpty(text) Then
        '    Throw New ArgumentException("Testo del messaggio nullo")
        'End If
        If listaLavoro Is Nothing Then
            Throw New ArgumentException("Lista nulla")
        End If

        If listaLavoro.Count = 0 Then
            Throw New ArgumentException("Lista vuota")
        End If

        m_ListaLavoroUtenti = listaLavoro
        m_text = text
    End Sub


    Private m_ListaLavoroUtenti As IList
    Private m_text As String
   

    Public ReadOnly Property SmsCompleteRecipients As IList(Of SmsRecipient)
        Get
            Dim l As New List(Of SmsRecipient)
            For Each elem As UtenteDTO In m_ListaLavoroUtenti
                l.Add(New SmsRecipient(elem))
            Next
            Return l
        End Get
    End Property

    Public ReadOnly Property SmsCorrectRecipients As IList(Of SmsRecipient)
        Get
            Dim l As New List(Of SmsRecipient)
            For Each elem As UtenteDTO In m_ListaLavoroUtenti
                Dim a As SmsRecipient = New SmsRecipient(elem)
                If a.IsValid Then
                    l.Add(a)
                End If
            Next
            Return l
        End Get
    End Property

    Public Function ToStringArray() As String()

        Dim res As New ArrayList
        For Each elem As SmsRecipient In SmsCorrectRecipients
            res.Add(elem.RecipientNumber)
        Next

        Return res.ToArray(GetType(String))

    End Function

    Private ReadOnly Property SmsText As String
        Get
            Return m_text
        End Get
    End Property


End Class
