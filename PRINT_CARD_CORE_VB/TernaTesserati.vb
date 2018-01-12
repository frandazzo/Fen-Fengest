Public Class TernaTesserati
    Private m_Cognome1 As String = ""
    Private m_Nome1 As String = ""
    Private m_Azienda1 As String = ""
    Private m_Categoria1 As String = ""
    Private m_Cognome2 As String = ""
    Private m_Nome2 As String = ""
    Private m_Azienda2 As String = ""
    Private m_Categoria2 As String = ""
    Private m_Cognome3 As String = ""
    Private m_Nome3 As String = ""
    Private m_Azienda3 As String = ""
    Private m_Categoria3 As String = ""


    Private m_settoreTessera1 As String = ""
    Private m_settoreTessera2 As String = ""
    Private m_settoreTessera3 As String = ""
    Public Property SettoreTessera1() As String
        Get
            Return m_settoreTessera1
        End Get
        Set(ByVal value As String)
            m_settoreTessera1 = value
        End Set
    End Property
    Public Property SettoreTessera2() As String
        Get
            Return m_settoreTessera2
        End Get
        Set(ByVal value As String)
            m_settoreTessera2 = value
        End Set
    End Property
    Public Property SettoreTessera3() As String
        Get
            Return m_settoreTessera3
        End Get
        Set(ByVal value As String)
            m_settoreTessera3 = value
        End Set
    End Property


    Public Sub New()

    End Sub

    Public Sub New(t1 As Tesserato, t2 As Tesserato, t3 As Tesserato)
        m_Azienda1 = t1.Azienda
        m_Azienda2 = t2.Azienda
        m_Azienda3 = t3.Azienda

        m_Nome1 = t1.Nome
        m_Nome2 = t2.Nome
        m_Nome3 = t3.Nome

        m_Cognome1 = t1.Cognome
        m_Cognome2 = t2.Cognome
        m_Cognome3 = t3.Cognome


        m_Categoria1 = t1.ProvinciaSindacale
        m_Categoria2 = t2.ProvinciaSindacale
        m_Categoria3 = t3.ProvinciaSindacale


        m_settoreTessera1 = t1.SettoreTessera
        m_settoreTessera2 = t2.SettoreTessera
        m_settoreTessera3 = t3.SettoreTessera

    End Sub

    Public Property SettoreTessera() As String
        Get
            Return sector
        End Get
        Set(ByVal value As String)
            sector = value
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
            If sector.StartsWith("EDIL") Then
                If provincia = "BOLZANO" Then
                    Return "CE/BK PROV. BZ"
                End If
            End If


            Return m_Azienda1
        End Get
        Set(ByVal value As String)
            m_Azienda1 = value
        End Set
    End Property



 

    Public Property Categoria1 As String
        Get
            If (uil = True) Then
                Return m_Categoria1
            End If


            If m_Categoria1 = "" Then
                Return "FENEAL UIL SGK BAU"
            End If
            Return m_Categoria1
        End Get
        Set(value As String)
            m_Categoria1 = value
        End Set
    End Property


    Public Property Categoria2 As String
        Get
            If (uil = True) Then
                Return m_Categoria2
            End If

            If m_Categoria2 = "" Then
                Return "FENEAL UIL SGK BAU"
            End If
            Return m_Categoria2
        End Get
        Set(value As String)
            m_Categoria2 = value
        End Set
    End Property


    Public Property Categoria3 As String
        Get
            If (uil = True) Then
                Return m_Categoria3
            End If

            If m_Categoria3 = "" Then
                Return "FENEAL UIL SGK BAU"
            End If
            Return m_Categoria3
        End Get
        Set(value As String)
            m_Categoria3 = value
        End Set
    End Property


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
            If sector.StartsWith("EDIL") Then
                If provincia = "BOLZANO" Then
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
            If sector.StartsWith("EDIL") Then
                If provincia = "BOLZANO" Then
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
