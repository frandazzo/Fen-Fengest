Public Class TernaTesserati


    Public Sub New()

    End Sub

    Public Sub New(t1 As Tesserato1, t2 As Tesserato1, t3 As Tesserato1)
        m_Azienda1 = t1.Azienda
        m_Azienda2 = t2.Azienda
        m_Azienda3 = t3.Azienda

        m_Nome1 = t1.Nome
        m_Nome2 = t2.Nome
        m_Nome3 = t3.Nome

        m_Cognome1 = t1.Cognome
        m_Cognome2 = t2.Cognome
        m_Cognome3 = t3.Cognome

    End Sub

    Public Property SettoreTessera() As String
        Get
            Return settore
        End Get
        Set(ByVal value As String)
            settore = value
        End Set
    End Property


    Public Property Nome1() As String
        Get
            Return m_Nome1
        End Get
        Set(ByVal value As String)
            m_Nome1 = value
        End Set
    End Property
    Public Property Cognome1() As String
        Get
            Return m_Cognome1
        End Get
        Set(ByVal value As String)
            m_Cognome1 = value
        End Set
    End Property
    Public Property Azienda1() As String
        Get
            If settore.StartsWith("EDIL") Then
                If federProv = "BOLZANO" Then
                    Return "CE/BK PROV. BZ"
                End If
            End If


            Return m_Azienda1
        End Get
        Set(ByVal value As String)
            m_Azienda1 = value
        End Set
    End Property



    Private m_Cognome1 As String = ""
    Private m_Nome1 As String = ""
    Private m_Azienda1 As String = ""
    Private m_Cognome2 As String = ""
    Private m_Nome2 As String = ""
    Private m_Azienda2 As String = ""
    Private m_Cognome3 As String = ""
    Private m_Nome3 As String = ""
    Private m_Azienda3 As String = ""




    Public Property Nome2() As String
        Get
            Return m_Nome2
        End Get
        Set(ByVal value As String)
            m_Nome2 = value
        End Set
    End Property
    Public Property Cognome2() As String
        Get
            Return m_Cognome2
        End Get
        Set(ByVal value As String)
            m_Cognome2 = value
        End Set
    End Property
    Public Property Azienda2() As String
        Get
            If settore.StartsWith("EDIL") Then
                If federProv = "BOLZANO" Then
                    Return "CE/BK PROV. BZ"
                End If
            End If


            Return m_Azienda2
        End Get
        Set(ByVal value As String)
            m_Azienda2 = value
        End Set
    End Property


    Public Property Nome3() As String
        Get
            Return m_Nome3
        End Get
        Set(ByVal value As String)
            m_Nome3 = value
        End Set
    End Property
    Public Property Cognome3() As String
        Get
            Return m_Cognome3
        End Get
        Set(ByVal value As String)
            m_Cognome3 = value
        End Set
    End Property
    Public Property Azienda3() As String
        Get
            If settore.StartsWith("EDIL") Then
                If federProv = "BOLZANO" Then
                    Return "CE/BK PROV. BZ"
                End If
            End If


            Return m_Azienda3
        End Get
        Set(ByVal value As String)
            m_Azienda3 = value
        End Set
    End Property

  
End Class
