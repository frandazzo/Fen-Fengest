Public Class Utente
    Inherits AbstractPersona
    Implements IUtente, IComparable

    Private m_QuotaMensile As Moneta = New Moneta(0.0, Moneta.Valuta.Euro)
    Private m_ListaDeleghe As New VirtualLazyList
    Private m_Conto As IConto = DomainFactory.GetContoNullo
    'Private m_competenzaUltimopagamento As AbstractPeriodo
    Private m_DelegaAttivata As Boolean
    Private m_SedeCambiata As Boolean
    Private m_Attitudini As IList = New ArrayList
    Private m_Preferenze As IList = New ArrayList

    Private m_Infos As IList = New ArrayList
    Private m_DirectoryPreferenziale As String
    Private m_Selected As Boolean = False
    Private m_SituazioneFamiliare As New SituazioneFamiliare
    Private m_Fondo As Fondo
    Private m_Foto As String = ""
    Private m_ArchivioDocumenti As New ArchivioDocumenti
    Private m_Segreteria As Segreteria
    Private m_Codifica As CodificaEnti

    Private m_Incarichi As IList = New ArrayList

    Public Property Incarichi() As IList
        Get
            Return m_Incarichi
        End Get
        Set(ByVal value As IList)
            m_Incarichi = value
        End Set
    End Property

    Public Sub RemoveIncarico(ByVal TipoIncarico As TipoIncarico)
        Dim info As Incarico = GetIncaricoo(TipoIncarico)

        If info IsNot Nothing Then
            Me.Incarichi.Remove(info)
        End If

    End Sub


    Public Function GetIncaricoo(ByVal TipoIncarico As TipoIncarico) As Incarico
        For Each elem As Incarico In Me.Incarichi
            If elem.TipoIncarico.Id = TipoIncarico.Id Then

                Return elem

            End If
        Next
        Return Nothing
    End Function


    Public Sub AddIncarico(ByVal Azienda As Azienda, ByVal TipoIncarico As TipoIncarico, ByVal Note As String)

        'If Azienda Is Nothing Then
        '    Throw New ArgumentException("l'azienda non può essere nulla")
        'End If

        'If TypeOf (Azienda) Is AziendaNonSpecificata Then
        '    Throw New ArgumentException("l'azienda non può essere nulla")
        'End If

        If GetIncaricoo(TipoIncarico) Is Nothing Then
            Dim info As New Incarico
            info.TipoIncarico = TipoIncarico
            info.Utente = Me
            info.Azienda = Azienda
            info.Notes = Note
            Me.Incarichi.Add(info)
            Return
        End If

        Throw New Exception("Non è possibile avere più incarichi con lo stesso tipo di incarico")
    End Sub

    Private m_tag As TagUtente = New TagUtente

    Public Property TagUtente() As TagUtente
        Get
            Return m_tag
        End Get
        Set(ByVal value As TagUtente)
            m_tag = value
        End Set
    End Property


    Public Function ToUtenteDTO() As UtenteDTO

        Dim u As New UtenteDTO
        If Me.Key IsNot Nothing Then
            u.Id = Me.Id
        End If

        u.Cap = Me.Residenza.Cap
        u.Cellulare1 = Me.Comunicazione.Cellulare1
        u.Cellulare2 = Me.Comunicazione.Cellulare2
        u.CodiceFiscale = Me.CodiceFiscale
        u.Cognome = Me.Cognome
        u.CompleteName = Me.CompleteName
        u.Comune = Me.Residenza.Comune.Descrizione
        u.ComuneNascita = Me.ComuneNascita.Descrizione
        u.DataNascita = Me.DataNascita.Date
        u.Fax = Me.Comunicazione.Fax
        u.IndirizzoWeb = Me.Residenza.IndirizzoWeb
        u.Mail = Me.Comunicazione.Mail
        u.Nazionalita = Me.Nazionalita.Descrizione
        u.Nome = Me.Nome
        u.Note = Me.Note
        u.Provincia = Me.Residenza.Provincia.Descrizione
        u.ProvinciaNascita = Me.ProvinciaNascita.Descrizione
        u.Sesso = IIf(Me.Sesso = Sex.Maschio, "Maschio", "Femmina")
        u.TelefonoCasa = Me.Comunicazione.TelefonoCasa
        u.TelefonoUfficio = Me.Comunicazione.TelefonoUfficio
        u.Via = Me.Residenza.Via

        Return u
    End Function


    Public Function HaStampatoTessera() As Boolean
        For Each elem As Tessera In m_tessere
            If elem.DataTesseramento.Year = Date.Now.Year Then
                Return True
            End If
        Next
        Return False
    End Function

    Public ReadOnly Property Indirizzo() As String
        Get
            If Me.Residenza IsNot Nothing Then
                Return Me.Residenza.Via & " " & Me.Residenza.Cap
            End If
            Return ""
        End Get
    End Property

    Public Property Codifica() As CodificaEnti
        Get
            If m_Codifica Is Nothing Then
                m_Codifica = New CodificaEnti
            End If
            Return m_Codifica
        End Get
        Set(ByVal value As CodificaEnti)
            m_Codifica = value
        End Set
    End Property


    Public Property Segreteria() As Segreteria
        Get
            Return m_Segreteria
        End Get
        Set(ByVal value As Segreteria)
            m_Segreteria = value
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


    Private m_tessere As IList = New ArrayList


    Public Property Path_Foto() As String
        Get
            Return m_Foto
        End Get
        Set(ByVal value As String)
            m_Foto = value
        End Set
    End Property






    Public Property Tessere() As IList
        Get
            Return m_tessere
        End Get
        Set(ByVal value As IList)
            m_tessere = value
        End Set
    End Property

    Public Function PossiedeTessera(ByVal anno As Int32) Implements IUtente.PossiedeTessera
        For Each elem As Tessera In m_tessere
            If elem.DataTesseramento <> DateTime.MinValue Then
                If elem.DataTesseramento.Year = anno Then
                    Return True
                End If
            End If
        Next
        Return False
    End Function


    Public Property Fondo() As Fondo
        Get
            Return m_Fondo
        End Get
        Set(ByVal value As Fondo)
            m_Fondo = value
        End Set
    End Property

    Public Property SituazioneFamiliare() As SituazioneFamiliare
        Get
            Return m_SituazioneFamiliare
        End Get
        Set(ByVal value As SituazioneFamiliare)
            m_SituazioneFamiliare = value
        End Set
    End Property

    Public Function CreaNomeCartella() As String
        Return m_Cognome & m_Nome & Format(m_DataNascita, "dd-MM-yy")
    End Function


    Public Function CreaDirectoryUtente(ByVal pathUtenti As String) As Boolean
        Dim result As String
        Dim nomeCartella As String

        If pathUtenti = "" Then
            Throw New ArgumentException("Non esiste un percorso di default per le cartelle Utenti")
        End If


        nomeCartella = CreaNomeCartella()

        result = pathUtenti & "\" & nomeCartella

        If Not My.Computer.FileSystem.DirectoryExists(result) Then
            My.Computer.FileSystem.CreateDirectory(result)
            Return True
        End If

        Return False
    End Function






    Public Property Selected() As Boolean
        Get
            Return m_Selected
        End Get
        Set(ByVal value As Boolean)
            m_Selected = value
        End Set
    End Property

    Protected Overrides Sub DoValidation()
        If Me.Nome = "" Then
            ValidationErrors.Add("Nome mancante")
        End If
        If Me.Cognome = "" Then
            ValidationErrors.Add("Cognome mancante")
        End If
        If Me.DirectoryPreferenziale = "" Then
            ValidationErrors.Add("Directory preferenziale mancante")
        End If
    End Sub

    Public Property Infos() As IList
        Get
            Return m_Infos
        End Get
        Set(ByVal value As IList)
            m_Infos = value
        End Set
    End Property



    Public Property Preferenze() As IList
        Get
            Return m_Preferenze
        End Get
        Set(ByVal value As IList)
            m_Preferenze = value
        End Set
    End Property


    Public Property Attitudini() As IList
        Get
            Return m_Attitudini
        End Get
        Set(ByVal value As IList)
            m_Attitudini = value
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


    Public Overloads Sub AddInfo(ByVal AziendaImpiego As Azienda, ByVal LiberoAl As DateTime, ByVal LivelloInquadramento As String, _
                        ByVal Ente As EnteBilaterale, ByVal DataImportazione As DateTime, ByVal IscrittoA As String)

        If GetInfo(AziendaImpiego, Ente, DataImportazione, LiberoAl) Is Nothing Then

            Dim s As String = ""
            If IscrittoA = "FILCA" Or IscrittoA = "FILLEA" Then
                s = IscrittoA
            End If


            Dim info As New Info
            info.IscrittoA = s
            info.Utente = Me
            info.LiberoAl = LiberoAl
            If Ente Is Nothing Then Throw New ArgumentNullException("Ente nullo")

            info.Ente = Ente
            If AziendaImpiego Is Nothing Then Throw New ArgumentNullException("Azinda impiego nulla")
            If TypeOf (AziendaImpiego) Is AziendaNonSpecificata Then Throw New ArgumentNullException("Azinda impiego nulla")
            info.AziendaImpiego = AziendaImpiego
            info.DataImportazione = DataImportazione
            info.LivelloInquadramento = LivelloInquadramento
            Me.Infos.Add(info)

        End If
    End Sub

    Public Overloads Sub AddInfo(ByVal AziendaImpiego As Azienda, ByVal LiberoAl As DateTime, ByVal LivelloInquadramento As String, _
                        ByVal Ente As EnteBilaterale, ByVal DataImportazione As DateTime, ByVal IscrittoA As String, ByVal Sovrascrivi As Boolean)



        Dim s As String = ""
        If IscrittoA = "FILCA" Or IscrittoA = "FILLEA" Then
            s = IscrittoA
        End If

        Dim i As Info = GetLastInfo(AziendaImpiego, Ente)

        If i Is Nothing Then
            Dim info As New Info
            info.IscrittoA = s
            info.Utente = Me
            info.LiberoAl = LiberoAl
            If Ente Is Nothing Then Throw New ArgumentNullException("Ente nullo")

            info.Ente = Ente
            If AziendaImpiego Is Nothing Then Throw New ArgumentNullException("Azinda impiego nulla")
            If TypeOf (AziendaImpiego) Is AziendaNonSpecificata Then Throw New ArgumentNullException("Azinda impiego nulla")
            info.AziendaImpiego = AziendaImpiego
            info.DataImportazione = DataImportazione
            info.LivelloInquadramento = LivelloInquadramento
            Me.Infos.Add(info)
        Else
            i.DataImportazione = DataImportazione
            i.LiberoAl = LiberoAl
            i.IscrittoA = IscrittoA
            i.LivelloInquadramento = LivelloInquadramento
        End If
    End Sub


    Public Function GetLastInfo(ByVal AziendaImpiego As Azienda, ByVal Ente As EnteBilaterale) As Info

        Dim temp As DateTime = New DateTime(1900, 1, 1)
        Dim tempInfo As Info = Nothing

        For Each elem As Info In Me.Infos
            If elem.AziendaImpiego.Id = AziendaImpiego.Id And elem.Ente.Id = Ente.Id Then
                If elem.LiberoAl > temp Then
                    temp = elem.LiberoAl
                    tempInfo = elem
                End If
            End If
        Next

        Return tempInfo
    End Function

    Public Function GetInfo(ByVal AziendaImpiego As Azienda, ByVal Ente As EnteBilaterale, ByVal DataImportazione As DateTime, ByVal LiberoAl As DateTime) As Info
        For Each elem As Info In Me.Infos
            If elem.AziendaImpiego.Id = AziendaImpiego.Id Then
                If elem.Ente.Id = Ente.Id Then
                    If elem.DataImportazione.Date = DataImportazione.Date Then
                        If elem.LiberoAl = LiberoAl Then
                            Return elem
                        End If
                    End If
                End If
            End If
        Next
        Return Nothing
    End Function

    Public Sub RemoveInfo(ByVal AziendaImpiego As Azienda, ByVal Ente As EnteBilaterale, ByVal DataImportazione As DateTime, ByVal LiberoAl As DateTime)
        Dim info As Info = GetInfo(AziendaImpiego, Ente, DataImportazione, LiberoAl)
        If info IsNot Nothing Then
            Me.Infos.Remove(info)
        End If

    End Sub




#Region "Metodi per la gestione delle preferenze"


    Public Sub AddPreferenza(ByVal Abilita As Abilita, ByVal Priorita As Preferenza.PrioritaPreferenza, ByVal Data As DateTime)
        If GetPreferenza(Abilita, Data) Is Nothing Then
            m_Preferenze.Add(New Preferenza(Me, Abilita, Priorita, Data))
            Return
        End If
        Throw New InvalidOperationException("Impossibile aggiungere una nuova preferenza. Skill già presente tra le preferenze dell'utente")
    End Sub

    Public Overloads Function GetPreferenza(ByVal Abilita As Abilita, ByVal Data As DateTime) As Preferenza
        For Each elem As Preferenza In m_Preferenze
            If elem.Abilita.Id = Abilita.Id Then
                If elem.Data = Data Then
                    Return elem
                End If
            End If
        Next
        Return Nothing
    End Function

    Public ReadOnly Property AbilitaPreferite() As IList
        Get
            Dim result As IList = New ArrayList
            For Each elem As Preferenza In m_Preferenze
                If Not result.Contains(elem.Abilita) Then
                    result.Add(elem.Abilita)
                End If
            Next
            Return result
        End Get

    End Property


    Public Overloads Function GetPreferenza(ByVal Id As Int32) As Preferenza
        For Each elem As Preferenza In m_Preferenze
            If elem.Id = Id Then
                Return elem
            End If
        Next
        Return Nothing
    End Function

    Public Sub RemovePreferenza(ByVal Abilita As Abilita, ByVal Data As DateTime)
        Dim temp As Preferenza = GetPreferenza(Abilita, Data)
        If temp IsNot Nothing Then
            m_Preferenze.Remove(temp)
        End If
    End Sub


    ''' <summary>
    ''' Restituisce l'ultima info per l'ente selezionato nell'intervallo di tempo specificato
    ''' </summary>
    ''' <param name="range"></param>
    ''' <param name="Ente"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function GetLastInfoInRange(ByVal range As DataRange, ByVal Ente As EnteBilaterale) As Info
        Dim result As Info = Nothing
        If range.IsEmpty Then Return Nothing
        Dim max_data As DateTime = range.Start.AddDays(-1)
        For Each elem As Info In m_Infos
            If range.Includes(elem.LiberoAl) And Ente.Id = elem.Ente.Id And elem.LiberoAl >= max_data Then
                result = elem
                max_data = elem.LiberoAl
            End If
        Next
        Return result
    End Function



    Public Function IsFree(ByVal LiberoAl As DateTime, ByVal Ente As EnteBilaterale) As Boolean
        'verifico il numero di deleghe per l'ente specificato
        'se è nullo allora il lavoratore è libero
        'altrimenti il lavoratore è libero solo se la delega 
        '(per l'ente specificato) precedente
        'la data libero al è nello stato "revocata" o "annullata"

        If m_ListaDeleghe.Count = 0 Then
            Return True
        End If

        Dim delega As IDelega = GetLastDelegaBefore(LiberoAl, Ente)

        If delega Is Nothing Then Return True

        If delega.NomeStato = "Annullata" Or delega.NomeStato = "Revocata" Then
            Return True
        End If

        Return False


    End Function
    Public Overloads Function HasPositiveDeleghe(ByVal atDate As DateTime, ByVal ente As Int32) As Boolean
        'verifico che l'utente abbia almeno una delega 
        'che non sia annullata, revocata, sottoscritta o 
        'inoltrata per cassa edile ed edilcassa fino alla data indicata

        'If range.IsEmpty Then Return False

        If SearchAmongEntiBilaterali(atDate, ente) Then
            'Verifico l'ultima delega nell'intervallo per la cassa edile
            Return True
        End If

        'If SearchAmongEntiBilaterali(atDate, 2) Then
        '   'Verifico l'ultima delega nell'intervallo per l' edilcassa
        '   Return True

        'End If



        Return False


    End Function

    Private Function SearchAmongEntiBilaterali(ByVal atDate As DateTime, ByVal int As Int32) As Boolean

        Dim delega As IDelega = GetLastDelegaBefore(atDate.Date, int)

        If delega Is Nothing Then Return False

        'If Not range.Includes(delega.DataDocumento) Then Return False

        If delega.NomeStato = "Accettata" Or delega.NomeStato = "Attivata" Then
            Return True
        End If
    End Function

    Private Overloads Function GetLastDelegaBefore(ByVal data As DateTime, ByVal Ente As EnteBilaterale) As IDelega
        Dim result As IDelega = Nothing

        Dim max_data As DateTime = DateTime.MinValue
        For Each elem As IDelega In m_ListaDeleghe
            If elem.IsForSettoreEdile Then
                If Ente.Id = elem.EnteInoltro.Id And elem.DataDocumento >= max_data Then
                    If elem.DataDocumento <= data Then
                        result = elem
                        max_data = elem.DataDocumento
                    End If
                End If
            End If
        Next
        Return result
    End Function

    Private Overloads Function GetLastDelegaBefore(ByVal data As DateTime, ByVal IdEnte As Int32) As IDelega
        Dim result As IDelega = Nothing

        Dim max_data As DateTime = DateTime.MinValue
        For Each elem As IDelega In m_ListaDeleghe
            If elem.IsForSettoreEdile Then
                If IdEnte = elem.EnteInoltro.Id And elem.DataDocumento >= max_data Then
                    If elem.DataDocumento <= data Then
                        result = elem
                        max_data = elem.DataDocumento
                    End If
                End If
            End If
        Next
        Return result
    End Function



#End Region








#Region "Metodi per la gestione delle attitudini"





    Public Sub AddAttitudine(ByVal Abilita As Abilita, ByVal Livello As LivelloAbilita)
        If GetAttitudine(Abilita) Is Nothing Then
            m_Attitudini.Add(New KnowHow(Me, Abilita, Livello))
            Return
        End If
        Throw New InvalidOperationException("Impossibile aggiungere un nuovo skill. Skill già presente nelle attitudini dell'utente")
    End Sub

    Public Function GetAttitudine(ByVal Abilita As Abilita) As KnowHow
        For Each elem As KnowHow In m_Attitudini
            If elem.Abilita.Id = Abilita.Id Then
                Return elem
            End If
        Next
        Return Nothing
    End Function

    Public Sub RemoveAttitudine(ByVal Abilita As Abilita)
        Dim temp As KnowHow = GetAttitudine(Abilita)
        If temp IsNot Nothing Then
            m_Attitudini.Remove(temp)
        End If
    End Sub


#End Region


#Region "Proprietà e costruttori"


    Public Sub New()

    End Sub
    Public Sub New(ByVal Nome As String, ByVal Cognome As String)
        MyBase.New(Nome, Cognome)
    End Sub
    Public Sub New(ByVal Nome As String, ByVal Cognome As String, ByVal QuotaMensile As Moneta, ByVal Conto As IConto)
        MyBase.New(Nome, Cognome)
        If Conto Is Nothing Then Throw New Exception("Non è possibile creare un oggetto persona con un conto nullo. Inserire un conto corretto.")
        If Conto.Descrizione = "" Then Throw New Exception("Non è possibile creare un oggetto persona con un conto di tipo nullo.")
        If QuotaMensile Is Nothing Then Throw New Exception("Non è possibile creare un oggetto persona con una quota mensile nulla.")
        m_QuotaMensile = QuotaMensile
        m_Conto = Conto
    End Sub
#End Region

#Region "Proprietà "
    Public Property Conto() As IConto Implements IUtente.Conto
        Get
            Return m_Conto
        End Get
        Set(ByVal value As IConto)
            If value Is Nothing Then Throw New Exception("Non è possibile creare un oggetto persona con un conto nullo. Inserire un conto corretto.")
            If value.Descrizione = "" Then Throw New Exception("Non è possibile creare un oggetto persona con un conto di tipo nullo.")
            m_Conto = value
        End Set
    End Property
    Public Property QuotaMensile() As Moneta Implements IUtente.QuotaMensile
        Get
            Return m_QuotaMensile
        End Get
        Set(ByVal value As Moneta)
            If value Is Nothing Then Throw New Exception("Non è possibile creare un oggetto persona con una quota mensile nulla.")
            m_QuotaMensile = value
        End Set
    End Property
    Public ReadOnly Property Deleghe() As VirtualLazyList Implements IUtente.Deleghe
        Get
            Return m_ListaDeleghe
        End Get
    End Property
    Public ReadOnly Property IdUtente() As Int32 Implements IUtente.IdUtente
        Get
            Return MyBase.Key.LongValue
        End Get
    End Property
#End Region

#Region "Gestione Deleghe"
    ''' <summary>
    ''' A causa del doppio riferimento tra deleghe ed utenti permetto alla delega di essere l'unica a poter inserisi
    ''' tra le deleghe di un utente. Questa funzione è richiamata solamente dall'oggetto delega
    ''' </summary>
    ''' <param name="Delega"></param>
    ''' <remarks></remarks>
    Public Sub AddDelega(ByVal Delega As IDelega) Implements IUtente.AddDelega
        m_ListaDeleghe.Add(Delega)
    End Sub


    Public Sub RemoveDelega(ByVal Delega As IDelega)
        For i As Int32 = 0 To m_ListaDeleghe.Count - 1
            Dim del As IDelega = m_ListaDeleghe.Item(i)
            If del.IdDelega = Delega.IdDelega Then
                m_ListaDeleghe.RemoveAt(i)
                Return
            End If
        Next
    End Sub

    'Public Function GetReferenteForActiveDelegaIn() As Referente
    '   For Each elem As IDelega In m_ListaDeleghe
    '      If elem.IsActive Then
    '         Return elem.Referente
    '      End If
    '   Next
    '   Return New ReferenteNullo
    'End Function
    Public Sub AnnullaDeleghePerSoggetto(ByVal Delega As IDelega) Implements IUtente.AnnullaDeleghePerSoggetto
        For Each elem As IDelega In m_ListaDeleghe
            If Not elem Is Delega Then
                'If Delega.IsForSettoreEdile Then
                '   If (elem.IsForSettoreEdile And elem.EnteInoltro.Id = Delega.EnteInoltro.Id) Or Not elem.IsForSettoreEdile Then
                '      elem.Annulla(elem, Delega.DataAccettazioneDelega, Delega)
                '   End If
                'Else
                '   elem.Annulla(elem, Delega.DataAccettazioneDelega, Delega)
                'End If
                If Delega.IsForSettoreEdile Then
                    If (elem.IsForSettoreEdile And elem.EnteInoltro.Id = Delega.EnteInoltro.Id) Then
                        elem.Annulla(elem, Delega.DataAccettazioneDelega, Delega)
                    End If
                Else
                    If (elem.IsForSettoreEdile = False And elem.EnteInoltro.Id = Delega.EnteInoltro.Id) Then
                        elem.Annulla(elem, Delega.DataAccettazioneDelega, Delega)
                    End If
                End If
            End If
        Next
    End Sub

    Public Sub RipristinaStatoPrecedenteAccettazione(ByVal Delega As IDelega) Implements IUtente.RipristinaStatoPrecedenteAccettazione
        For Each elem As IDelega In m_ListaDeleghe
            'If Not elem.IdDelega = Delega.IdDelega Then
            If elem.DelegaDiAnnullamento Is Delega Then
                elem.RipristinaStatoPrecedente()
            End If
        Next
    End Sub
    ''' <summary>
    ''' Metodo da usarsi solamente in fase di materializzazione dell'oggetto utente.
    ''' </summary>
    ''' <param name="List"></param>
    ''' <remarks></remarks>
    Public Sub SetDeleghe(ByVal List As VirtualLazyList) Implements IUtente.SetDeleghe
        'If Not List Is Nothing Then
        m_ListaDeleghe = List
        'End If
    End Sub
#Region "Attività di collaborazione con il pagamento per l'attivazione delle delaghe"
    Public Function ActivateDelega(ByVal PerSoggetto As AbstractAzienda, ByVal ConDocumento As IDocumento) As Boolean Implements IUtente.ActivateDelega
        'For Each elem As IDelega In m_ListaDeleghe
        '   'il tipo di ente se blaterale o azienda normale è importante poichè è adesso possibile avere più
        '   'delege attive  o accettate per settori diversi
        '   'If (elem.IsForSettoreEdile And TypeOf (PerSoggetto) Is EnteBilaterale) Or ((Not elem.IsForSettoreEdile) And (TypeOf (PerSoggetto) Is Azienda)) Then
        '   '   If elem.IsActive And elem.NomeStato = "Accettata" And elem.EnteInoltro.Id = PerSoggetto.Id Then
        '   '      elem.Attiva(elem, ConDocumento)
        '   '      m_DelegaAttivata = True
        '   '      System.Diagnostics.Debug.WriteLine("Accettazione delega per utente con nome = " & Me.CompleteName & " e azienda con nome " & PerSoggetto.Descrizione)
        '   '      Return True
        '   '   End If
        '   'End If
        'Next


        'Prendo la delega accettata
        Dim temp As IDelega = Me.GetAcceptedDelegaFor(PerSoggetto, ConDocumento.DataDocumento)
        If temp.IdDelega = -1 Then
            'se non la trovo verifico la delega attiva
            temp = Me.GetActiveDelegaFor(PerSoggetto, ConDocumento.DataDocumento)
        End If

        If temp.IdDelega > -1 Then
            temp.Attiva(temp, ConDocumento)
            m_DelegaAttivata = True
            Return True
        End If


        Return False
    End Function
    Public Sub ChangeSedeOperativa(ByVal PerSoggetto As AbstractAzienda, ByVal AllaData As Date, ByVal Sede As ISedeOperativa) Implements IUtente.ChangeSedeOperativa
        If Sede.Descrizione = "" Then Return
        Dim delega As IDelega = Me.GetActiveDelegaFor(PerSoggetto, AllaData)
        If delega.IdDelega = -1 Then Return
        If Sede.Descrizione <> delega.SedeOperativa.Descrizione Then
            delega.SedeOperativa = Sede
            m_SedeCambiata = True
        End If
    End Sub



    ''' <summary>
    ''' Metodo che restituisce una variabile che viene impostata in fase di attivazione di una delega
    ''' a causa della registrazione di un nuovo pagamento. Al di fuori di questo contesto non è significativa.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function HaAttivatoDelega() As Boolean Implements IUtente.HaAttivatoDelega
        Return m_DelegaAttivata
    End Function
    Public Function HaCambiatoSede() As Boolean Implements IUtente.HaCambiatoSede
        Return m_SedeCambiata
    End Function
#End Region
#End Region

#Region "Attività di collaborazione con la posizione di pagamento"

#Region "Attività di verifica di pagabiltà della posizione"
    ''' <summary>
    ''' Metodo che verifica  l'esistenza di una delega  che imposti la pagabilità della posizione.
    ''' Viene verificato che esista una delega attiva o accettata verificando chel'intervallo di validità della delega almeno 
    ''' intersechi il  periodo di competenza della posizione altrimenti
    ''' il sistema , nel caso non trovi una delega attiva o accettata con 
    ''' l’ente esecutore specificato o la il periodo di validità della delega attiva o accettata non soddisfi il requisito sopra
    '''  effettua una ricerca tra tutte le deleghe 
    ''' annullate o revocate per l’utente con quel soggetto esecutore il cui 
    ''' periodo di validità interseca la competenza della  
    ''' delega stessa
    ''' </summary>
    ''' <param name="PosizioneDiPagamento"></param>
    ''' <param name="SoggettoEsecutore"></param>
    ''' <remarks></remarks>
    Public Sub CheckPaybility(ByVal PosizioneDiPagamento As IPayble, ByVal SoggettoEsecutore As AbstractAzienda) Implements IUtente.CheckPaybility

        Dim delega As IDelega = GetActiveDelegaFor(SoggettoEsecutore)
        If delega.DataRegistrazione = DateTime.MinValue Then
            'se la delega à nulla verifico tra tutte le deleghe annullate o revocate se ve ne sia alcuna
            'con periodo di validità a cavallo della competenza della posizione
            If ExsistPaybleInactiveDelega(PosizioneDiPagamento, SoggettoEsecutore) Then
                PosizioneDiPagamento.SetPosizionePagabile(True, "")
            Else
                PosizioneDiPagamento.SetPosizionePagabile(False, "Non è possibile impostare la pagabilità della posizione poichè non esiste una delega per il soggetto esecutore  e per l'utente che imposti la pagabilità della posizione corrente")
            End If
        ElseIf Not PosizioneDiPagamento.Competenza.GetDataRange.Overlaps(delega.GetPeriodoValidita) Then
            'se la delega attiva non soddisfa il requisito verifico tra tutte le deleghe annullate o revocate se ve ne sia alcuna
            'con periodo di validità a cavallo della competenza della posizione
            If ExsistPaybleInactiveDelega(PosizioneDiPagamento, SoggettoEsecutore) Then
                PosizioneDiPagamento.SetPosizionePagabile(True, "")
            Else
                PosizioneDiPagamento.SetPosizionePagabile(False, "Non è possibile impostare la pagabilità della posizione poichè la competenza della posizione è disgiunta dal periodo di validità della delega.")
            End If
        Else
            PosizioneDiPagamento.SetPosizionePagabile(True, "")
        End If
    End Sub

    Public Function IsPayble(ByVal Competenza As DataRange, ByVal SoggettoEsecutore As AbstractAzienda) As Boolean

        Dim delega As IDelega = GetActiveDelegaFor(SoggettoEsecutore)
        If delega.DataRegistrazione = DateTime.MinValue Then
            'se la delega à nulla verifico tra tutte le deleghe annullate o revocate se ve ne sia alcuna
            'con periodo di validità a cavallo della competenza della posizione
            If ExsistPaybleInactiveDelega(Competenza, SoggettoEsecutore) Then
                Return True
            Else
                Return False
            End If
        ElseIf Not Competenza.Overlaps(delega.GetPeriodoValidita) Then
            'se la delega attiva non soddisfa il requisito verifico tra tutte le deleghe annullate o revocate se ve ne sia alcuna
            'con periodo di validità a cavallo della competenza della posizione
            If ExsistPaybleInactiveDelega(Competenza, SoggettoEsecutore) Then
                Return True
            Else
                Return False
            End If
        Else
            Return True
        End If
    End Function
    Private Overloads Function ExsistPaybleInactiveDelega(ByVal PosizioneDiPagamento As IPayble, ByVal SoggettoEsecutore As AbstractAzienda) As Boolean
        For Each elem As IDelega In m_ListaDeleghe
            If Me.VerifyInactiveDelegaFor(SoggettoEsecutore, elem) Then
                If PosizioneDiPagamento.Competenza.GetDataRange.Overlaps(elem.GetPeriodoValidita) Then Return True
            End If
        Next
        Return False
    End Function


    Private Overloads Function ExsistPaybleInactiveDelega(ByVal periodo As DataRange, ByVal SoggettoEsecutore As AbstractAzienda) As Boolean
        For Each elem As IDelega In m_ListaDeleghe
            If Me.VerifyInactiveDelegaFor(SoggettoEsecutore, elem) Then
                If periodo.Overlaps(elem.GetPeriodoValidita) Then Return True
            End If
        Next
        Return False
    End Function


    Public Function CheckExistenceActiveDelegaFor(ByVal Ente As AbstractAzienda) As Boolean Implements IUtente.CheckExistenceActiveDelegaFor
        For Each elem As IDelega In m_ListaDeleghe
            If elem.IsActive And VerifyActiveDelegaFor(Ente, elem) Then
                Return True
            End If
        Next
        Return False
    End Function
    Public Overloads Function GetActiveDelegaFor(ByVal SoggettoEsecutore As AbstractAzienda) As IDelega Implements IUtente.GetActiveDelegaFor
        For Each elem As IDelega In m_ListaDeleghe
            If Not elem.DataAccettazioneDelega = DateTime.MinValue Then
                If VerifyActiveDelegaFor(SoggettoEsecutore, elem) Then Return elem
            End If
        Next
        Return DomainFactory.GetDelegaNulla
    End Function
    ''' <summary>
    ''' Metodo che cerca una delega attiva o accettata alla data indicata per il soggetto esecutore indicato
    ''' </summary>
    ''' <param name="SoggettoEsecutore"></param>
    ''' <param name="AtDate"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overloads Function GetActiveDelegaFor(ByVal SoggettoEsecutore As AbstractAzienda, ByVal AtDate As DateTime) As IDelega Implements IUtente.GetActiveDelegaFor
        For Each elem As IDelega In m_ListaDeleghe
            'ricerco la delega attiva alla data indicata
            If VerifyActiveDelegaFor(SoggettoEsecutore, elem) Then
                Dim validita As DataRange = elem.GetPeriodoValidita
                If validita.Includes(AtDate) Then Return elem
            End If
        Next
        Return DomainFactory.GetDelegaNulla
    End Function

    Public Overloads Function GetAcceptedDelegaFor(ByVal SoggettoEsecutore As AbstractAzienda, ByVal AtDate As DateTime) As IDelega
        For Each elem As IDelega In m_ListaDeleghe
            'ricerco la delega attiva alla data indicata
            If VerifyAcceptedDelegaFor(SoggettoEsecutore, elem) Then
                Dim validita As DataRange = elem.GetPeriodoValidita
                If validita.Includes(AtDate) Then Return elem
            End If
        Next
        Return DomainFactory.GetDelegaNulla
    End Function


    Private Function VerifyDelegaIsFor(ByVal SoggettoEsecutore As AbstractAzienda, ByVal Elem As IDelega) As Boolean
        'verifico la che la delega sia per il soggetto indicato
        If VerifySettoreDelega(SoggettoEsecutore, Elem) Then
            If SoggettoEsecutore.Id = Elem.EnteInoltro.Id Then
                Return True
            End If
        End If
        Return False
    End Function

    'Private Function VerifyDelegaFor(ByVal SoggettoEsecutore As AbstractAzienda, ByVal Elem As IDelega) As Boolean
    '   'se la coerenza è stata verificata procedo alla verifica dell'identità del soggetto esecutore
    '   If VerifyDelegaIsFor(SoggettoEsecutore, Elem) Then
    '      Return True
    '   End If
    '   Return False
    'End Function

    Public Overrides Function ToString() As String Implements IUtente.ToString
        Return Me.CompleteName
    End Function






    Private Function VerifySettoreDelega(ByVal SoggettoEsecutore As AbstractAzienda, ByVal Elem As IDelega) As Boolean
        'verifico la coerenza con il settore di sottoscrizione della delega
        Dim SettoreVerificato As Boolean = False
        If DirectCast(SoggettoEsecutore, Azienda).TipologiaAzienda = Azienda.TipoAzienda.EnteBilateraleEdili And Elem.IsForSettoreEdile Then
            SettoreVerificato = True
        ElseIf DirectCast(SoggettoEsecutore, Azienda).TipologiaAzienda = Azienda.TipoAzienda.AziendaPrivata And Not Elem.IsForSettoreEdile Then
            SettoreVerificato = True
        Else
            SettoreVerificato = False
        End If
        Return SettoreVerificato
    End Function

    Private Function VerifyInactiveDelegaFor(ByVal SoggettoEsecutore As AbstractAzienda, ByVal Elem As IDelega) As Boolean
        'se la coerenza è stata verificata procedo alla verifica dell'identità del soggetto esecutore
        If Elem.IsRevocata Or Elem.IsAnnullata Then
            If VerifyDelegaIsFor(SoggettoEsecutore, Elem) Then
                Return True
            End If
        End If
        Return False
    End Function
    Private Function VerifyActiveDelegaFor(ByVal SoggettoEsecutore As AbstractAzienda, ByVal Elem As IDelega) As Boolean
        'se la coerenza è stata verificata procedo alla verifica dell'identità del soggetto esecutore
        If Elem.IsActive Then
            If VerifyDelegaIsFor(SoggettoEsecutore, Elem) Then
                Return True
            End If
        End If
        Return False
    End Function

    Private Function VerifyAcceptedDelegaFor(ByVal SoggettoEsecutore As AbstractAzienda, ByVal Elem As IDelega) As Boolean
        'se la coerenza è stata verificata procedo alla verifica dell'identità del soggetto esecutore
        If Elem.IsActive And Elem.NomeStato = "Accettata" Then
            If VerifyDelegaIsFor(SoggettoEsecutore, Elem) Then
                Return True
            End If
        End If
        Return False
    End Function

#End Region




    Public Function GetDelegaById(ByVal IdDelega As Int32) As IDelega Implements IUtente.GetDelegaById
        For Each elem As IDelega In Me.Deleghe
            If elem.IdDelega = IdDelega Then
                Return elem
            End If
        Next
        Return DomainFactory.GetDelegaNulla
    End Function

#End Region


    Public Function CompareTo(obj As Object) As Integer Implements System.IComparable.CompareTo
        Dim c As Utente

        Try
            c = DirectCast(obj, Utente)
        Catch ex As Exception
            c = Nothing
        End Try

        If (Not c Is Nothing) Then

            Return String.Compare(Me.CompleteName, c.CompleteName)
        Else
            Return String.Compare(Me.CompleteName, "")

        End If

    End Function
End Class
