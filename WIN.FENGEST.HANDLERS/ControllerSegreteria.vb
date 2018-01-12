Public Class ControllerSegreteria
    Inherits AbstractController


    Public Function Current() As Segreteria
        Return DirectCast(MyBase.m_current, Segreteria)
    End Function
    Public Sub New()
        'Ps.BeginTransaction()
    End Sub

    Public Property PartitaIva() As String
        Get
            Return Current.Partita_IVA
        End Get
        Set(ByVal value As String)
            Current.Partita_IVA = value
        End Set
    End Property

    Public ReadOnly Property Id() As Int32
        Get
            Return Current.Key.LongValue
        End Get
    End Property


    Public Property Intestazione() As String
        Get
            Return Current.Intestazione
        End Get
        Set(ByVal value As String)
            Current.Intestazione = value
        End Set
    End Property

    Public Property Sottotitolo1() As String
        Get
            Return Current.Sottotitolo1
        End Get
        Set(ByVal value As String)
            Current.Sottotitolo1 = value
        End Set
    End Property

    Public Function GetDirectoryPreferenziale(ByVal Target As AbstractPersistenceObject) As String
        Return Current.GetDirectoryPreferenziale(Target)
    End Function

    Public Property Sottotitolo3() As String
        Get
            Return Current.Sottotitolo3
        End Get
        Set(ByVal value As String)
            Current.Sottotitolo3 = value
        End Set
    End Property

    Public Property Sottotitolo2() As String
        Get
            Return Current.Sottotitolo2
        End Get
        Set(ByVal value As String)
            Current.Sottotitolo2 = value
        End Set
    End Property


    Public Property CartellaEtichette() As String
        Get
            Return Current.CartellaEtichette
        End Get
        Set(ByVal value As String)
            Current.CartellaEtichette = value
        End Set
    End Property


    Public Property CartellaModelli() As String
        Get
            Return Current.CartellaModelli
        End Get
        Set(ByVal value As String)
            Current.CartellaModelli = value
        End Set
    End Property


    Public Property DirectoryPreferenziale() As String
        Get
            Return Current.DirectoryPreferenziale
        End Get
        Set(ByVal value As String)
            Current.DirectoryPreferenziale = value
        End Set
    End Property

    Public Property DirectoryPreferenzialeUtenti() As String
        Get
            Return Current.DirectoryPreferenzialeUtenti
        End Get
        Set(ByVal value As String)
            Current.DirectoryPreferenzialeUtenti = value
        End Set
    End Property


    Public Property DirectoryPreferenzialeAziende() As String
        Get
            Return Current.DirectoryPreferenzialeAziende
        End Get
        Set(ByVal value As String)
            Current.DirectoryPreferenzialeAziende = value
        End Set
    End Property


    Public Property Descrizione() As String
        Get
            Return Current.Descrizione
        End Get
        Set(ByVal value As String)
            Current.Descrizione = value
        End Set
    End Property


    Public ReadOnly Property ComuneLegale() As String
        Get
            Return UCase(Current.IndirizzoSedeLegale.Comune.Descrizione)
        End Get
    End Property
    Public ReadOnly Property ProvinciaLegale() As String
        Get
            Return UCase(Current.IndirizzoSedeLegale.Provincia.Descrizione)
        End Get
    End Property
    Public ReadOnly Property RegioneLegale() As String
        Get
            Return GeoLocationFacade.Instance.GetGeoHandler.GetRegioneById(Current.IndirizzoSedeLegale.Provincia.IdRegione).Descrizione
        End Get
    End Property

    Public ReadOnly Property IndirizzoWEB() As String
        Get
            Return UCase(Current.IndirizzoSedeLegale.IndirizzoWeb)
        End Get
    End Property
    Public ReadOnly Property ViaLegale() As String
        Get
            Return UCase(Current.IndirizzoSedeLegale.Via)
        End Get
    End Property
    Public ReadOnly Property CapLegale() As String
        Get
            Return Current.IndirizzoSedeLegale.Comune.CAP
        End Get
    End Property
    Public Sub SetIndirizzoSedeLegale(ByVal Via As String, ByVal NomeProvincia As String, ByVal NomeComune As String, ByVal IndirizzoWeb As String)
        Dim geo As GeoLocationHandler = GeoLocationFacade.Instance.GetGeoHandler
        Dim indirizzo As New Indirizzo
        indirizzo.Via = Via
        indirizzo.Provincia = geo.GetProvinciaByName(NomeProvincia)
        indirizzo.Comune = geo.GetComuneByName(NomeComune)
        indirizzo.IndirizzoWeb = IndirizzoWeb
        Current.IndirizzoSedeLegale = indirizzo
    End Sub


    Public ReadOnly Property TelefonoUfficio() As String
        Get
            Return Current.Comunicazione.TelefonoUfficio
        End Get
    End Property
    Public ReadOnly Property Fax() As String
        Get
            Return Current.Comunicazione.Fax
        End Get
    End Property
    Public ReadOnly Property Cellulare1() As String
        Get
            Return Current.Comunicazione.Cellulare1
        End Get
    End Property
    Public ReadOnly Property Cellulare2() As String
        Get
            Return Current.Comunicazione.Cellulare2
        End Get
    End Property
    Public ReadOnly Property Mail() As String
        Get
            Return Current.Comunicazione.Mail
        End Get
    End Property
    Public Sub SetComunicazione(ByVal TelefonoUfficio As String, ByVal Fax As String, ByVal Mail As String, ByVal Cellulare1 As String, ByVal Cellulare2 As String)
        Current.Comunicazione.Mail = Mail
        Current.Comunicazione.Cellulare2 = Cellulare2
        Current.Comunicazione.Cellulare1 = Cellulare1
        Current.Comunicazione.TelefonoUfficio = TelefonoUfficio
        Current.Comunicazione.Fax = Fax
        Current.Comunicazione.TelefonoCasa = ""

    End Sub


    Public Property Responsabile() As String
        Get
            Return Current.Responsable
        End Get
        Set(ByVal value As String)
            Current.Responsable = value

        End Set
    End Property




    Public Overrides Function GetCategoryObject() As String
        Return "Segreteria"
    End Function
    ''' <summary>
    ''' Crea un'istanza vuota dell'oggetto
    ''' </summary>
    ''' <remarks></remarks>
    Public Overrides Sub CreateNew()
        'questo costruttore è utile se voglio che il client crei e salvi
        'l'oggetto in 3 passaggi distinti.
        'Client.CreateNew
        'Client.SetProperties
        'Client.Save
        If GetSegreteria() Is Nothing Then
            MyBase.m_current = New Segreteria
            Current.Descrizione = "Segreteria provinciale"
            Current.DirectoryPreferenziale = "C:/"
            Current.DirectoryPreferenzialeAziende = "C:/"
            Current.DirectoryPreferenzialeUtenti = "C:/"
            Current.CartellaModelli = "C:/"
            Current.CartellaEtichette = "C:/"

            Current.Intestazione = "Federazione Nazionale Lavoratori Edili Affini e del Legno"
            Current.Sottotitolo1 = "Sindacato Provinciale"
            Current.Sottotitolo2 = "Edili - Cementieri  - Manufatti Cemento  - Calce e Gesso  - Laterizi  - Legno – Boschivi"
            Current.Sottotitolo3 = "Feneal - uil "
            Current.IndirizzoSedeLegale.IndirizzoWeb = "http://www.feneal-uil.it/"

            Save()
        End If

    End Sub






    Public Function GetSegreteria() As Segreteria

        Try
            LoadById(1)
        Catch ex As Exception
            Return Nothing
        End Try
        Return Current()

    End Function





End Class
