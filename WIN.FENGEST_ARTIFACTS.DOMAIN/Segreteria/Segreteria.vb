Public Class Segreteria
    Inherits AbstractAzienda

    Protected m_PartitaIva As String = ""
    Private m_DirectoryPreferenziale As String = ""
    Private m_DirectoryPreferenzialeUtenti As String = ""
    Private m_DirectoryPreferenzialeAziende As String = ""
    Private m_Intestazione As String = ""
    Private m_Sottotitolo1 As String = ""
    Private m_Sottotitolo2 As String = ""
    Private m_Sottotitolo3 As String = ""
    Private m_ArchivioDocumenti As New ArchivioDocumenti


    Private m_UtenteNazionale As String = ""
    Private m_PasswordNazionale As String = ""


    Private m_cartella_modelli As String = ""


    Private m_cartella_etichette As String = ""

    Public Property PasswordNazionale() As String
        Get
            Return m_PasswordNazionale
        End Get
        Set(ByVal value As String)
            m_PasswordNazionale = value
        End Set
    End Property

    Public Property UtenteNazionale() As String
        Get
            Return m_UtenteNazionale
        End Get
        Set(ByVal value As String)
            m_UtenteNazionale = value
        End Set
    End Property


    Public Property CartellaEtichette() As String
        Get
            Return m_cartella_etichette
        End Get
        Set(ByVal value As String)
            m_cartella_etichette = value
        End Set
    End Property




    Public Property CartellaModelli() As String
        Get
            Return m_cartella_modelli
        End Get
        Set(ByVal value As String)
            m_cartella_modelli = value
        End Set
    End Property





    Public Property ArchivioDocumenti() As ArchivioDocumenti
        Get
            If m_ArchivioDocumenti Is Nothing Then
                m_ArchivioDocumenti = New ArchivioDocumenti
            End If
            Return m_ArchivioDocumenti
        End Get
        Set(ByVal value As ArchivioDocumenti)
            m_ArchivioDocumenti = value
        End Set
    End Property
    Public Property Sottotitolo3() As String
        Get
            Return m_Sottotitolo3
        End Get
        Set(ByVal value As String)
            m_Sottotitolo3 = value
        End Set
    End Property



    Public Property Sottotitolo2() As String
        Get
            Return m_Sottotitolo2
        End Get
        Set(ByVal value As String)
            m_Sottotitolo2 = value
        End Set
    End Property



    Public Property Sottotitolo1() As String
        Get
            Return m_Sottotitolo1
        End Get
        Set(ByVal value As String)
            m_Sottotitolo1 = value
        End Set
    End Property

    Public ReadOnly Property Cell1() As String
        Get
            Return m_Comunicazione.Cellulare1
        End Get
    End Property
    Public ReadOnly Property Cell2() As String
        Get
            Return m_Comunicazione.Cellulare2
        End Get
    End Property

    Public ReadOnly Property TelUfficio() As String
        Get
            Return m_Comunicazione.TelefonoUfficio
        End Get
    End Property

    Public ReadOnly Property Mail() As String
        Get
            Return m_Comunicazione.Mail
        End Get
    End Property

    Public ReadOnly Property Fax() As String
        Get
            Return m_Comunicazione.Fax
        End Get
    End Property


    Public ReadOnly Property Via() As String
        Get
            Return m_IndirizzoSedeLegale.Via
        End Get
    End Property

    Public ReadOnly Property Comune() As String
        Get
            Try
                Return m_IndirizzoSedeLegale.Comune.Descrizione
            Catch ex As Exception
                Return ""
            End Try
        End Get
    End Property

    Public ReadOnly Property Provincia() As String
        Get
            Try
                Return m_IndirizzoSedeLegale.Provincia.Descrizione
            Catch ex As Exception
                Return ""
            End Try
        End Get
    End Property


    Public ReadOnly Property Cap() As String
        Get
            Try
                Return m_IndirizzoSedeLegale.Comune.CAP
            Catch ex As Exception
                Return ""
            End Try
        End Get
    End Property

    Public ReadOnly Property Web() As String
        Get
            Return m_IndirizzoSedeLegale.IndirizzoWeb
        End Get
    End Property

    Public Property Intestazione() As String
        Get
            Return m_Intestazione
        End Get
        Set(ByVal value As String)
            m_Intestazione = value
        End Set
    End Property


    Public Function GetDirectoryPreferenziale(ByVal Target As AbstractPersistenceObject) As String
        Select Case Target.GetType.Name
            Case "Utente"
                Return m_DirectoryPreferenzialeUtenti
            Case "Azienda"
                Return m_DirectoryPreferenzialeAziende
            Case "Segreteria"
                Return m_DirectoryPreferenziale
            Case Else
                Return m_DirectoryPreferenziale
        End Select
    End Function


    Public Property DirectoryPreferenzialeUtenti() As String
        Get
            Return m_DirectoryPreferenzialeUtenti
        End Get
        Set(ByVal value As String)
            m_DirectoryPreferenzialeUtenti = value
        End Set
    End Property

    Public Property DirectoryPreferenzialeAziende() As String
        Get
            Return m_DirectoryPreferenzialeAziende
        End Get
        Set(ByVal value As String)
            m_DirectoryPreferenzialeAziende = value
        End Set
    End Property



    Public Property DirectoryPreferenziale() As String
        Get
            Return m_DirectoryPreferenziale
        End Get
        Set(ByVal value As String)
            m_DirectoryPreferenziale = value
        End Set
    End Property
    Property Partita_IVA() As String
        Get
            Return m_PartitaIva
        End Get
        Set(ByVal value As String)
            m_PartitaIva = value
        End Set
    End Property


    Private m_Data_Installazione As DateTime
    Private m_Numero_Installazione As String

    Public Property Data_Installazione() As DateTime
        Get
            Return m_Data_Installazione
        End Get
        Set(ByVal value As DateTime)
            m_Data_Installazione = value
        End Set
    End Property

    Public Property Numero_Installazione() As String
        Get
            Return m_Numero_Installazione
        End Get
        Set(ByVal value As String)
            m_Numero_Installazione = value
        End Set
    End Property

    Protected Overrides Sub DoValidation()
        If String.IsNullOrEmpty(MyBase.Descrizione) Then
            ValidationErrors.Add("Ragione sociale nulla")
        End If
        If String.IsNullOrEmpty(m_DirectoryPreferenziale) Then
            ValidationErrors.Add("Cartella preferenziale nulla")
        End If

        If String.IsNullOrEmpty(m_DirectoryPreferenzialeAziende) Then
            ValidationErrors.Add("Cartella preferenziale aziende nulla")
        End If

        If String.IsNullOrEmpty(m_DirectoryPreferenzialeUtenti) Then
            ValidationErrors.Add("Cartella preferenziale utenti nulla")
        End If

        If Me.Key IsNot Nothing Then
            If m_IndirizzoSedeLegale.Comune.Id = -1 Then
                ValidationErrors.Add("Comune provincia non impostato")
            End If
        End If

        If String.IsNullOrEmpty(m_cartella_etichette) Then
            ValidationErrors.Add("Cartella modelli etichette non impostata")
        End If

        If String.IsNullOrEmpty(m_cartella_modelli) Then
            ValidationErrors.Add("Cartella modelli non impostata")
        End If
    End Sub

End Class
