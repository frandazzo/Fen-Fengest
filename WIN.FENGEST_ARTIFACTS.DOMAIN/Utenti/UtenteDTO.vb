Imports System.Text.RegularExpressions

Public Class UtenteDTO


    Private m_Id As Int32
    Protected m_Nome As String = ""
    Protected m_Cognome As String = ""
    Protected m_Sesso As String = "Maschio"
    Protected m_DataNascita As Date = New DateTime(1900, 1, 1)
    Protected m_Nazionalita As String = ""
    Protected m_ComuneNascita As String = ""
    Protected m_ProvinciaNascita As String = ""
    Protected m_CodiceFiscale As String = ""


    Protected m_Note As String = ""
    Protected m_Via As String = ""
    Protected m_Cap As String = ""
    Protected m_Comune As String = ""
    Protected m_Provincia As String = ""
    Protected m_IndirizzoWeb As String = ""

    Protected m_TelCasa As String = ""
    Protected m_TelUff As String = ""
    Protected m_Fax As String = ""
    Protected m_Cell1 As String = ""
    Protected m_Cell2 As String = ""
    Protected m_Mail As String = ""

    Protected m_CompleteName As String = ""


    Public Sub New()

    End Sub

    Public Property CompleteName() As String
        Get
            Return m_CompleteName
        End Get
        Set(ByVal value As String)
            m_CompleteName = UCase(value)
        End Set
    End Property



    Public Property Id() As Int32
        Get
            Return m_Id
        End Get
        Set(ByVal value As Int32)
            m_Id = value
        End Set
    End Property


    Public Property Nome() As String
        Get
            Return m_Nome
        End Get
        Set(ByVal value As String)
            '  If value = "" Then Throw New Exception("Non è possibile creare un oggetto persona con un nome nullo. Inserire un nome corretto.")
            m_Nome = UCase(value)
        End Set
    End Property

    Public Property Cognome() As String
        Get
            Return m_Cognome
        End Get
        Set(ByVal value As String)
            ' If value = "" Then Throw New Exception("Non è possibile creare un oggetto persona con un cognome nullo. Inserire un cognome corretto.")
            m_Cognome = UCase(value)
        End Set
    End Property

    Public Property Nazionalita() As String
        Get
            Return m_Nazionalita
        End Get
        Set(ByVal value As String)
            ' If value Is Nothing Then Throw New Exception("Impossibile impostare la nazionalità. Valore nullo")
            m_Nazionalita = value
        End Set
    End Property

    Public Property ProvinciaNascita() As String
        Get
            Return m_ProvinciaNascita
        End Get
        Set(ByVal value As String)
            ' If value Is Nothing Then Throw New Exception("Impossibile impostare la provincia di nascita. Valore nullo")
            m_ProvinciaNascita = value
        End Set
    End Property

    Public Property ComuneNascita() As String
        Get
            Return m_ComuneNascita
        End Get
        Set(ByVal value As String)
            ' If value Is Nothing Then Throw New Exception("Impossibile impostare il comune di nascita. Valore nullo")
            m_ComuneNascita = value
        End Set
    End Property

    Property DataNascita() As DateTime
        Get
            Return m_DataNascita
        End Get
        Set(ByVal value As DateTime)
            m_DataNascita = value
        End Set
    End Property

    Property Sesso() As String
        Get
            Return m_Sesso
        End Get
        Set(ByVal value As String)
            m_Sesso = value
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

    Public Property Note() As String
        Get
            Return m_Note
        End Get
        Set(ByVal value As String)
            m_Note = value
        End Set
    End Property







    Property IndirizzoWeb() As String
        Get
            Return m_IndirizzoWeb
        End Get
        Set(ByVal value As String)
            m_IndirizzoWeb = value
        End Set
    End Property

    Property Cap() As String
        Get
            Return m_Cap
        End Get
        Set(ByVal value As String)
            m_Cap = value
        End Set
    End Property
    Property Via() As String
        Get
            Return m_Via
        End Get
        Set(ByVal value As String)
            m_Via = value
        End Set
    End Property

    Public Property Provincia() As String
        Get
            Return m_Provincia
        End Get
        Set(ByVal value As String)
            m_Provincia = value
        End Set
    End Property
    Public Property Comune() As String
        Get
            Return m_Comune
        End Get
        Set(ByVal value As String)
            m_Comune = value
        End Set
    End Property

    Public ReadOnly Property Cellulare1Numerico() As String
        Get
            Try
                Return Regex.Replace(m_Cell1, "[^.0-9]", "")
            Catch ex As Exception
                Return ""
            End Try

        End Get

    End Property

    Public ReadOnly Property Cellulare2Numerico() As String
        Get
            Try
                Return Regex.Replace(m_Cell2, "[^.0-9]", "")
            Catch ex As Exception
                Return ""
            End Try

        End Get

    End Property

    Public Property Cellulare1() As String
        Get
            Return m_Cell1
        End Get
        Set(ByVal value As String)
            m_Cell1 = value
        End Set
    End Property
    Public Property Cellulare2() As String
        Get
            Return m_Cell2
        End Get
        Set(ByVal value As String)
            m_Cell2 = value
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
    Public Property TelefonoCasa() As String
        Get
            Return m_TelCasa
        End Get
        Set(ByVal value As String)
            m_TelCasa = value
        End Set
    End Property
    Public Property TelefonoUfficio() As String
        Get
            Return m_TelUff
        End Get
        Set(ByVal value As String)
            m_TelUff = value
        End Set
    End Property
    Public Property Fax() As String
        Get
            Return m_Fax
        End Get
        Set(ByVal value As String)
            m_Fax = value
        End Set
    End Property






End Class
