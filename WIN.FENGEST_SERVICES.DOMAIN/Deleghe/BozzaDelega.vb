Public Class BozzaDelega
      Inherits AbstractPersistenceObject

    Private m_Data As DateTime = DateTime.Now
    Private m_Ente As String = "CASSA EDILE"
    Private m_Utente As Utente = New UtenteNonSpecificato
    Private m_Referente As Referente = New ReferenteNullo


    Protected Overrides Sub DoValidation()

        If m_Utente Is Nothing Then
            Me.ValidationErrors.Add("Utente nullo")
        End If
        If Not m_Utente Is Nothing Then
            If m_Utente.Id = -1 Then
                Me.ValidationErrors.Add("Utente nullo")
            End If
        End If
        If m_Ente Is Nothing Then
            Me.ValidationErrors.Add("Ente nullo")
        Else
            If m_Ente <> "CASSA EDILE" And m_Ente <> "EDILCASSA" Then
                Me.ValidationErrors.Add("Ente non corretto")
            End If
        End If


    End Sub


    Public Property CodiceFiscale() As String
        Get
            If Not m_Utente Is Nothing Then
                Return m_Utente.CodiceFiscale
            End If
            Return ""
        End Get
        Set(ByVal value As String)

        End Set
    End Property

    Public Property NomeUtente() As String
        Get
            If Not m_Utente Is Nothing Then
                Return m_Utente.Cognome + " " + m_Utente.Nome
            End If
            Return ""
        End Get
        Set(ByVal value As String)

        End Set
    End Property



    Public Property Ente() As String
        Get
            Return m_Ente
        End Get
        Set(ByVal value As String)
            m_Ente = value
        End Set
    End Property

    Public Property Data() As DateTime
        Get
            Return m_Data
        End Get
        Set(value As DateTime)

            m_Data = value
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

    Public Property Referente() As Referente
        Get
            Return m_Referente
        End Get
        Set(ByVal value As Referente)
            m_Referente = value
        End Set
    End Property


End Class
