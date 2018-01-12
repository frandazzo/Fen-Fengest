Imports WIN.APPLICATION.REPORTING

Namespace UTENTI

    Public Class ControllerUtenti
        Inherits AbstractController
        Private m_ControllerConti As New CONTI.ControllerConti
        Private m_currentattitudine As KnowHow
        Private m_currentPreferenza As Preferenza
        Private m_currentFiglio As Figlio
        Private m_currentInfo As Info
        Private m_currentIncarico As Incarico
        Private controllerAbilita As New ControllerAbilita
        Private controllerLivello As New ControllerLivelloAbilita

#Region "Gestione attitudini"
        Public Function GetListaAttitudini() As IList
            Return Current.Attitudini
        End Function
        Public Function GetListaInfo() As IList
            Return Current.Infos
        End Function
        Public Function GetListaIcarichi() As IList
            Return Current.Incarichi
        End Function

        Private Function GetAbilita(ByVal DescrizioneAbilita As String)
            controllerAbilita.LoadByDescrizione(DescrizioneAbilita)
            Return controllerAbilita.GetCurrent
        End Function

        Public Function HaStampatoTessera() As Boolean
            Return Current.HaStampatoTessera
        End Function

        Public Property NoteAttitudine() As String
            Get
                If m_currentattitudine IsNot Nothing Then
                    Return m_currentattitudine.Note
                End If
                Return ""
            End Get
            Set(ByVal value As String)
                If m_currentattitudine IsNot Nothing Then
                    m_currentattitudine.Note = value
                End If
            End Set
        End Property

        Public Property NoteIncarico() As String
            Get
                Return m_currentIncarico.Notes         
            End Get
            Set(ByVal value As String)
                m_currentIncarico.Notes = value
                Ps.MarkDirty(m_currentIncarico)
            End Set
        End Property


        Public Property NotePreferenza() As String
            Get
                If m_currentPreferenza IsNot Nothing Then
                    Return m_currentPreferenza.Note
                End If
                Return ""
            End Get
            Set(ByVal value As String)
                If m_currentPreferenza IsNot Nothing Then
                    m_currentPreferenza.Note = value
                End If
            End Set
        End Property




        Public Sub AddAttitudine(ByVal DescrizioneAbilita As String, ByVal DescrizioneLivello As String, ByVal Note As String)

            Dim abilita As Abilita = GetAbilita(DescrizioneAbilita)

            controllerLivello.LoadByDescrizione(DescrizioneLivello)
            Dim livello As LivelloAbilita = controllerLivello.GetCurrent



            Current.AddAttitudine(abilita, livello)
            m_currentattitudine = Current.GetAttitudine(abilita)
            m_currentattitudine.Note = Note
            Ps.MarkNew(Current.GetAttitudine(abilita))
        End Sub

        Public Overloads Sub AddInfo(ByVal idAzienda As String, ByVal IdEnte As String, ByVal LiberoAl As DateTime, ByVal Livello As String, ByVal DataImportazione As DateTime, ByVal IscrittoA As String, Optional ByVal sovrascrivi As Boolean = False)
            Dim controllerAziende As New AZIENDE.ControllerAziende
            Dim controllerEnti As New AZIENDE.ControllerEntiBilaterali
            Dim azienda As Azienda = controllerAziende.GetAziendaById(idAzienda)
            Dim ente As EnteBilaterale = controllerEnti.GetEnteById(IdEnte)

            Dim info As Info = Current.GetInfo(azienda, ente, DataImportazione, LiberoAl)
            If info Is Nothing Then
                Current.AddInfo(azienda, LiberoAl, Livello, ente, DataImportazione, IscrittoA, sovrascrivi)
                info = Current.GetInfo(azienda, ente, DataImportazione, LiberoAl)
                If info.Key Is Nothing Then
                    Ps.MarkNew(info)
                Else
                    Ps.MarkDirty(info)
                End If

            End If
        End Sub

        Public Sub AddIncarico(ByVal idAzienda As String, ByVal TipoIncarico As String, ByVal note As String)
            Dim controllerAziende As New AZIENDE.ControllerAziende
            Dim controllerTipoIncarico As New ControllerTipoIncarico
            Dim azienda As Azienda = controllerAziende.GetAziendaById(idAzienda)
            If azienda.Id = -1 Then
                azienda = Nothing
            End If
            Dim tipo As TipoIncarico = controllerTipoIncarico.GetCausaleIncarico(TipoIncarico)


            Current.AddIncarico(azienda, tipo, note)
            m_currentIncarico = Current.GetIncaricoo(tipo)

            Ps.MarkNew(m_currentIncarico)
        End Sub





        Public Property IscrittoAInfo() As String
            Get
                Return m_currentInfo.IscrittoA
            End Get
            Set(ByVal value As String)
                m_currentInfo.IscrittoA = value
                Ps.MarkDirty(m_currentInfo)
            End Set
        End Property


        Public Property LiberoAlInfo() As DateTime
            Get
                Return m_currentInfo.LiberoAl
            End Get
            Set(ByVal value As DateTime)
                m_currentInfo.LiberoAl = value
                Ps.MarkDirty(m_currentInfo)
            End Set
        End Property

        Public Property LivelloInfo() As String
            Get
                Return m_currentInfo.LivelloInquadramento
            End Get
            Set(ByVal value As String)
                m_currentInfo.LivelloInquadramento = value
                Ps.MarkDirty(m_currentInfo)
            End Set
        End Property

        Public Sub SetInfoEnte(ByVal DescrizioneEnte As String)
            Dim controllerEnti As New AZIENDE.ControllerEntiBilaterali
            Dim ente As EnteBilaterale = controllerEnti.GetEnteByDescrizione(DescrizioneEnte)
            If ente Is Nothing Then Throw New Exception("Ente non trovato")
            m_currentInfo.Ente = ente
        End Sub

        Public Sub SetInfoAzienda(ByVal IdAzienda As String)
            Dim controllerAz As New AZIENDE.ControllerAziende
            Dim ente As Azienda = controllerAz.GetAziendaById(IdAzienda)
            If ente Is Nothing Then Throw New Exception("Azienda non trovata")
            m_currentInfo.AziendaImpiego = ente
        End Sub

        Public Sub SetIncaricoAzienda(ByVal IdAzienda As String)
            Dim controllerAz As New AZIENDE.ControllerAziende
            Dim ente As Azienda = controllerAz.GetAziendaById(IdAzienda)
            If ente.Id = -1 Then
                m_currentIncarico.Azienda = Nothing
            Else
                m_currentIncarico.Azienda = ente
            End If

            Ps.MarkDirty(m_currentIncarico)
        End Sub

        Public Sub SetIncaricoTipoIncarico(ByVal TipoIncarico As String)
            Dim controllerTipo As New ControllerTipoIncarico
            Dim tipo As TipoIncarico = controllerTipo.GetCausaleIncarico(TipoIncarico)
            If tipo Is Nothing Then Throw New Exception("Tipo incarico non trovato")
            m_currentIncarico.TipoIncarico = tipo
            Ps.MarkDirty(m_currentIncarico)
        End Sub


        Public ReadOnly Property IdInfoAzienda() As String
            Get
                Return m_currentInfo.AziendaImpiego.Id
            End Get
        End Property

        Public ReadOnly Property IdIncaricoAzienda() As String
            Get
                If Not m_currentIncarico.Azienda Is Nothing Then
                    Return m_currentIncarico.Azienda.Id
                End If
                Return ""
            End Get
        End Property
        Public ReadOnly Property DescrizioneIncaricoAzienda() As String
            Get
                If Not m_currentIncarico.Azienda Is Nothing Then
                    Return m_currentIncarico.Azienda.Descrizione
                End If
                Return ""
            End Get
        End Property

        Public ReadOnly Property DescrizioneInfoAzienda() As String
            Get
                Return m_currentInfo.AziendaImpiego.Descrizione
            End Get
        End Property

        Public ReadOnly Property DescrizioneIncaricoTipoIncarico() As String
            Get
                Return m_currentIncarico.TipoIncarico.Descrizione
            End Get
        End Property

        Public ReadOnly Property DescrizioneInfoEnte() As String
            Get
                Return m_currentInfo.Ente.Descrizione
            End Get
        End Property


        Public Sub SelectIncaricoo(ByVal TipoIncarico As String)
            Dim controllerTipo As New ControllerTipoIncarico

            Dim tipo As TipoIncarico = controllerTipo.GetCausaleIncarico(TipoIncarico)

            m_currentIncarico = Current.GetIncaricoo(tipo)

           
        End Sub

        Public Sub SelectInfo(ByVal idAzienda As String, ByVal IdEnte As String, ByVal DataImportazione As DateTime, ByVal LiberoAl As DateTime)
            Dim controllerAziende As New AZIENDE.ControllerAziende
            Dim controllerEnti As New AZIENDE.ControllerEntiBilaterali
            Dim azienda As Azienda = controllerAziende.GetAziendaById(idAzienda)
            Dim ente As EnteBilaterale = controllerEnti.GetEnteById(IdEnte)
            m_currentInfo = Current.GetInfo(azienda, ente, DataImportazione, LiberoAl)
        End Sub

        Public Sub RemoveIncarico(ByVal tipoIncarico As String)
            Dim controllerTipo As New ControllerTipoIncarico
            Dim tipo As TipoIncarico = controllerTipo.GetCausaleIncarico(tipoIncarico)
            Dim incaricoo As Incarico = Current.GetIncaricoo(tipo)

            If Not incaricoo Is Nothing Then
                Current.RemoveIncarico(tipo)
                Ps.MarkRemoved(incaricoo)
            End If

        End Sub

        Public Sub RemoveInfo(ByVal idAzienda As String, ByVal IdEnte As String, ByVal DataImportazione As DateTime, ByVal LiberoAl As DateTime)
            Dim controllerAziende As New AZIENDE.ControllerAziende
            Dim controllerEnti As New AZIENDE.ControllerEntiBilaterali
            Dim azienda As Azienda = controllerAziende.GetAziendaById(idAzienda)
            Dim ente As EnteBilaterale = controllerEnti.GetEnteById(IdEnte)
            Dim info As Info = Current.GetInfo(azienda, ente, DataImportazione, LiberoAl)

            If Not info Is Nothing Then
                Current.RemoveInfo(azienda, ente, DataImportazione, LiberoAl)
                Ps.MarkRemoved(info)
            End If

        End Sub


        Public Sub RemoveAttitudine(ByVal DescrizioneAbilita As String)
            Dim abilita As Abilita = GetAbilita(DescrizioneAbilita)

            Dim attitudine As KnowHow = Current.GetAttitudine(abilita)
            If Not attitudine Is Nothing Then
                Current.RemoveAttitudine(abilita)
                Ps.MarkRemoved(attitudine)
            End If
        End Sub
        Public Sub SelectAttitudine(ByVal DescrizioneAbilita As String)
            Dim abilita As Abilita = GetAbilita(DescrizioneAbilita)

            m_currentattitudine = Current.GetAttitudine(abilita)
        End Sub
        Public ReadOnly Property DescrizioneAbilitaAttitudine() As String
            Get
                Return m_currentattitudine.Abilita.Descrizione
            End Get
        End Property





        Public ReadOnly Property LivelloAbilitaAttitudine() As String
            Get
                Return m_currentattitudine.Livello.Descrizione
            End Get

        End Property

        Public Sub SetAbilitaAttitudine(ByVal DescrizioneAbilita As String)
            Dim abilita As Abilita = GetAbilita(DescrizioneAbilita)
            m_currentattitudine.Abilita = abilita
            Ps.MarkDirty(m_currentattitudine)
        End Sub
        Public Sub SetLivelloAbilitaAttitudine(ByVal DescrizioneLivelloAbilita As String)
            controllerLivello.LoadByDescrizione(DescrizioneLivelloAbilita)
            Dim livello As LivelloAbilita = controllerLivello.GetCurrent

            m_currentattitudine.Livello = livello
            Ps.MarkDirty(m_currentattitudine)
        End Sub

#End Region


        Public Function GetListaTessere() As IList
            Return Current.Tessere
        End Function



#Region "Gestione preferenze"
        Public Function GetListaPreferenze() As IList
            Return Current.Preferenze
        End Function
        Public Function GetListaPriorita() As IList
            Return [Enum].GetNames(GetType(Preferenza.PrioritaPreferenza))
        End Function

        Public Function GetListaSkillPreferiti() As IList
            Return Current.AbilitaPreferite
        End Function

        Public Sub AddPreferenza(ByVal DescrizioneAbilita As String, ByVal Priorita As String, ByVal Data As DateTime, ByVal Note As String)
            Dim abilita As Abilita = GetAbilita(DescrizioneAbilita)
            Dim p As Preferenza.PrioritaPreferenza = GetEnumeratoPriorita(Priorita)

            Current.AddPreferenza(abilita, p, Data)
            m_currentPreferenza = Current.GetPreferenza(abilita, Data)
            m_currentPreferenza.Note = Note
            Ps.MarkNew(m_currentPreferenza)
        End Sub


        Private Function GetEnumeratoPriorita(ByVal Priorita As String) As Preferenza.PrioritaPreferenza
            For Each elem As Object In [Enum].GetValues(GetType(Preferenza.PrioritaPreferenza))
                If Priorita = [Enum].GetName(GetType(Preferenza.PrioritaPreferenza), elem) Then
                    Return elem
                End If
            Next
            Return Preferenza.PrioritaPreferenza.Media
        End Function

        Public Sub RemovePreferenza(ByVal DescrizioneAbilita As String, ByVal Data As DateTime)
            Dim abilita As Abilita = GetAbilita(DescrizioneAbilita)
            Dim preferenza As Preferenza = Current.GetPreferenza(abilita, Data)
            If Not preferenza Is Nothing Then
                Current.RemovePreferenza(abilita, Data)
                Ps.MarkRemoved(preferenza)
            End If
        End Sub
        Public Sub SelectPreferenza(ByVal DescrizioneAbilita As String, ByVal Data As DateTime)
            Dim abilita As Abilita = GetAbilita(DescrizioneAbilita)
            m_currentPreferenza = Current.GetPreferenza(abilita, Data)
        End Sub
        Public ReadOnly Property DescrizioneAbilitaPreferenza() As String
            Get
                Return m_currentPreferenza.Abilita.Descrizione
            End Get
        End Property
        Public ReadOnly Property PrioritaPreferenza() As String
            Get
                Return m_currentPreferenza.Priorita.ToString
            End Get
        End Property
        Public Property DataPreferenza()
            Get
                Return m_currentPreferenza.Data
            End Get
            Set(ByVal value)
                m_currentPreferenza.Data = value
                Ps.MarkDirty(m_currentPreferenza)
            End Set
        End Property



        Public Sub SetAbilitaPreferenza(ByVal DescrizioneAbilita As String)
            Dim abilita As Abilita = GetAbilita(DescrizioneAbilita)
            m_currentPreferenza.Abilita = abilita
            Ps.MarkDirty(m_currentPreferenza)
        End Sub
        Public Sub SetPrioritaPreferenza(ByVal Priorita As String)
            m_currentPreferenza.Priorita = GetEnumeratoPriorita(Priorita)
            Ps.MarkDirty(m_currentPreferenza)
        End Sub

#End Region






        Public Sub StampaTesseraUtente(ByVal azienda As String)
            Dim ps1 As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
            'ps.ExecuteNonQuery("Begin transaction PrintCards")

            Ps.ExecuteNonQuery("Delete from db_tesseramento")

            ps1.ExecuteNonQuery(String.Format("Insert into db_tesseramento (Cognome, Nome, " & _
                                                "Impresa, STAMPATA_DA, IdUtente, " & _
                                                "PROVINCIA, COMUNE, VIA, CAP,AZIENDA_OLD) " & _
                                                "values ('{0}', '{1}', '{2}', '{3}', {4}, '{5}' , '{6}', '{7}', '{8}', '{9}')", Replace(Current.Cognome, "'", "''"), Replace(Current.Nome, "'", "''"), Replace(azienda, "'", "''"), Replace(SecurityManager.Instance.CurrentUser.Username, "'", "''"), Current.IdUtente, Replace(Current.Residenza.Provincia.Sigla, "'", "''"), Replace(Current.Residenza.Comune.Descrizione, "'", "''"), Replace(Current.Residenza.Via, "'", "''"), Replace(Current.Residenza.Cap, "'", "''"), Replace(azienda, "'", "''")))

        End Sub




        Public Function Current() As Utente
            Return DirectCast(MyBase.m_current, Utente)
        End Function
        Public Sub New()

        End Sub
        Public Sub New(ByVal OpenTransaction As Boolean)
            If OpenTransaction Then
                Ps.BeginTransaction()
            End If
        End Sub


        Public Function CreaNomeCartellaUtente() As String

            Return Current.CreaNomeCartella

        End Function

        Public Function CreaDirectoryUtente(ByVal pathUtenti As String) As Boolean
            Return Current.CreaDirectoryUtente(pathUtenti)
        End Function


        Public ReadOnly Property IdReferente() As String
            Get
                If Current.SituazioneFamiliare.Referente Is Nothing Then Return ""
                If Current.SituazioneFamiliare.Referente.Key Is Nothing Then Return ""
                If Current.SituazioneFamiliare.Referente.Key.LongValue = -1 Then Return ""
                Return Current.SituazioneFamiliare.Referente.Key.LongValue
            End Get
        End Property


        Public Sub SetReferente(ByVal IdReferente As String)

            If IdReferente = "" Then IdReferente = -1
            If Not IsNumeric(IdReferente) Then Throw New Exception("Id referente errato.")
            Dim controllerReferenti As New WIN.APPLICATION.FINANCIAL_ARTIFACTS.ControllerReferenti
            Dim ref As Referente = controllerReferenti.GetReferenteById(IdReferente)
            Current.SituazioneFamiliare.Referente = ref
            Ps.MarkDirty(m_current)
        End Sub


#Region "Proprietà oggetto"

        Public ReadOnly Property Genere() As String
            Get
                Return Current.Genere
            End Get
        End Property

        ''' <summary>
        ''' Propritetà che restituisce o imposta il sesso dell'utente  
        ''' </summary>
        ''' <value>Valori ammessi nei formati "MASCHIO" e "FEMMINA" </value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Sesso() As String
            Get
                Select Case Current.Sesso
                    Case AbstractPersona.Sex.Maschio
                        Return "MASCHIO"
                    Case AbstractPersona.Sex.Femmina
                        Return "FEMMINA"
                    Case Else
                        Throw New Exception("Tipo sesso sconosciuto")
                End Select
            End Get
            Set(ByVal value As String)
                Select Case value
                    Case "MASCHIO"
                        Current.Sesso = AbstractPersona.Sex.Maschio
                    Case "FEMMINA"
                        Current.Sesso = AbstractPersona.Sex.Femmina
                End Select
                Ps.MarkDirty(m_current)
            End Set
        End Property
        ''' <summary>
        ''' Proprietà che restituisce o imposta la data di nascita per l'utente.
        ''' Se la data impostata è la data odierna essa viene trascurata.
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property DataNascita() As Date
            Get
                Return Current.DataNascita
            End Get
            Set(ByVal value As Date)
                Current.DataNascita = value
                Ps.MarkDirty(m_current)
            End Set
        End Property


        Public Property PathFoto() As String
            Get
                Return Current.Path_Foto
            End Get
            Set(ByVal value As String)
                Current.Path_Foto = value
                Ps.MarkDirty(m_current)
            End Set
        End Property


        Public ReadOnly Property Nazionalita() As String
            Get
                Return UCase(Current.Nazionalita.Descrizione)
            End Get
        End Property
        Public Sub SetNazionalita(ByVal NomeNazionalita As String)
            Dim geo As GeoLocationHandler = GeoLocationFacade.Instance.GetGeoHandler
            Current.Nazionalita = geo.GetNazioneByName(NomeNazionalita)
            Ps.MarkDirty(m_current)
        End Sub



        Public ReadOnly Property Fondo() As String
            Get
                If Current.Fondo IsNot Nothing Then
                    Return UCase(Current.Fondo.Descrizione)
                End If
                Return ""
            End Get
        End Property
        Public Sub SetFondo(ByVal NomeFondo As String)
            Dim controllerFondi As New ControllerFondi
            controllerFondi.LoadByDescrizione(NomeFondo)
            Dim fondo As Fondo = controllerFondi.GetCurrent
            Current.Fondo = fondo
            Ps.MarkDirty(m_current)
        End Sub


        Public Property CasaProprieta() As Boolean
            Get
                Return Current.SituazioneFamiliare.CasaProprieta
            End Get
            Set(ByVal value As Boolean)
                Current.SituazioneFamiliare.CasaProprieta = value
                Ps.MarkDirty(m_current)
            End Set
        End Property
        Public Property StatoCivile() As String
            Get
                Return Current.SituazioneFamiliare.StatoCivile
            End Get
            Set(ByVal value As String)
                Current.SituazioneFamiliare.StatoCivile = value
                Ps.MarkDirty(m_current)
            End Set
        End Property

        Public Property NomeConiuge() As String
            Get
                Return Current.SituazioneFamiliare.Coniuge.Nome
            End Get
            Set(ByVal value As String)
                Current.SituazioneFamiliare.Coniuge.Nome = value
                Ps.MarkDirty(m_current)
            End Set
        End Property

        Public Property CodificaCE() As String
            Get
                Return Current.Codifica.CodificaCE
            End Get
            Set(ByVal value As String)
                Current.Codifica.CodificaCE = value
                Ps.MarkDirty(m_current)
            End Set
        End Property

        Public Property CodificaEC() As String
            Get
                Return Current.Codifica.CodificaEC
            End Get
            Set(ByVal value As String)
                Current.Codifica.CodificaEC = value
                Ps.MarkDirty(m_current)
            End Set
        End Property




        Public Property CognomeConiuge() As String
            Get
                Return Current.SituazioneFamiliare.Coniuge.Cognome
            End Get
            Set(ByVal value As String)
                Current.SituazioneFamiliare.Coniuge.Cognome = value
                Ps.MarkDirty(m_current)
            End Set
        End Property

        Public Property CoodiceFiscaleConiuge() As String
            Get
                Return Current.SituazioneFamiliare.Coniuge.CodiceFiscale
            End Get
            Set(ByVal value As String)
                Current.SituazioneFamiliare.Coniuge.CodiceFiscale = value
                Ps.MarkDirty(m_current)
            End Set
        End Property






        Public Property ConiugeACarico() As Boolean
            Get
                Return Current.SituazioneFamiliare.ConiugeACarico
            End Get
            Set(ByVal value As Boolean)
                Current.SituazioneFamiliare.ConiugeACarico = value
                Ps.MarkDirty(m_current)
            End Set
        End Property


        Public Property DataIntervista() As DateTime
            Get
                Return Current.SituazioneFamiliare.DataIntervista
            End Get
            Set(ByVal value As DateTime)
                Current.SituazioneFamiliare.DataIntervista = value
                Ps.MarkDirty(m_current)
            End Set
        End Property


        Public ReadOnly Property ProvinciaNascitaSigla() As String
            Get
                Return UCase(Current.ProvinciaNascita.Sigla)
            End Get
        End Property

        Public ReadOnly Property ProvinciaNascita() As String
            Get
                Return UCase(Current.ProvinciaNascita.Descrizione)
            End Get
        End Property
        Public Sub SetProvinciaNascita(ByVal NomeProvincia As String)
            Dim geo As GeoLocationHandler = GeoLocationFacade.Instance.GetGeoHandler
            Current.ProvinciaNascita = geo.GetProvinciaByName(NomeProvincia)
            Ps.MarkDirty(m_current)
        End Sub
        Public ReadOnly Property ComuneNascita() As String
            Get
                Return UCase(Current.ComuneNascita.Descrizione)
            End Get
        End Property
        Public Sub SetComuneNascita(ByVal NomeComune As String)
            Dim geo As GeoLocationHandler = GeoLocationFacade.Instance.GetGeoHandler
            Current.ComuneNascita = geo.GetComuneByName(NomeComune)
            Ps.MarkDirty(m_current)
        End Sub
        Public ReadOnly Property ComuneResidenza() As String
            Get
                Return UCase(Current.Residenza.Comune.Descrizione)
            End Get
        End Property
        Public ReadOnly Property ProvinciaResidenza() As String
            Get
                Return UCase(Current.Residenza.Provincia.Descrizione)
            End Get
        End Property
        Public ReadOnly Property ProvinciaResidenzaSigla() As String
            Get
                Return UCase(Current.Residenza.Provincia.Sigla)
            End Get
        End Property
        Public ReadOnly Property ViaResidenza() As String
            Get
                Return UCase(Current.Residenza.Via)
            End Get
        End Property
        Public ReadOnly Property CapResidenza() As String
            Get
                Return Current.Residenza.Cap
            End Get
        End Property
        'Public Overloads Sub SetResidenza(ByVal Via As String, ByVal NomeProvincia As String, ByVal NomeComune As String)
        '    Dim geo As GeoLocationHandler = WIN.APPLICATION.GeoLocationController.Instance.GetGeoHandler
        '    Dim indirizzo As New Indirizzo
        '    indirizzo.Via = Via
        '    indirizzo.Provincia = geo.GetProvinciaByName(NomeProvincia)
        '    indirizzo.Comune = geo.GetComuneByName(NomeComune)
        '    Current.Residenza = indirizzo
        '    Ps.MarkDirty(m_current)
        'End Sub


        Public Sub ChangeResidenzaIfNew(ByVal Via As String, ByVal NomeProvincia As String, ByVal NomeComune As String, ByVal CAP As String)
            Dim geo As GeoLocationHandler = GeoLocationFacade.Instance.GetGeoHandler
            Dim indirizzo As New Indirizzo

            If Via <> "" Then
                indirizzo.Via = Via
            End If
            If geo.GetProvinciaByName(NomeProvincia).Id <> -1 Then
                indirizzo.Provincia = geo.GetProvinciaByName(NomeProvincia)
            End If
            If geo.GetComuneByName(NomeComune).Id <> -1 Then
                indirizzo.Comune = geo.GetComuneByName(NomeComune)
            End If
            If CAP <> "" Then
                indirizzo.Cap = CAP
            End If

            Current.Residenza = indirizzo
            Ps.MarkDirty(m_current)
        End Sub


        Public Overloads Sub SetResidenza(ByVal Via As String, ByVal NomeProvincia As String, ByVal NomeComune As String, ByVal CAP As String)
            Dim geo As GeoLocationHandler = GeoLocationFacade.Instance.GetGeoHandler
            Dim indirizzo As New Indirizzo
            indirizzo.Via = Via
            indirizzo.Provincia = geo.GetProvinciaByName(NomeProvincia)
            indirizzo.Comune = geo.GetComuneByName(NomeComune)
            indirizzo.Cap = CAP
            Current.Residenza = indirizzo
            Ps.MarkDirty(m_current)
        End Sub
        Public ReadOnly Property TelefonoCasa() As String
            Get
                Return Current.Comunicazione.TelefonoCasa
            End Get
        End Property





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
        Public Sub SetComunicazione(ByVal TelefonoCasa As String, ByVal TelefonoUfficio As String, ByVal Fax As String, ByVal Mail As String, ByVal Cellulare1 As String, ByVal Cellulare2 As String)
            Current.Comunicazione.Mail = Mail
            Current.Comunicazione.Cellulare2 = Cellulare2
            Current.Comunicazione.Cellulare1 = Cellulare1
            Current.Comunicazione.TelefonoUfficio = TelefonoUfficio
            Current.Comunicazione.Fax = Fax
            Current.Comunicazione.TelefonoCasa = TelefonoCasa
            Ps.MarkDirty(m_current)
        End Sub
        Public Sub ChangeComunicazioneIfNew(ByVal TelefonoCasa As String, ByVal TelefonoUfficio As String, ByVal Fax As String, ByVal Mail As String, ByVal Cellulare1 As String, ByVal Cellulare2 As String)

            If Mail <> "" Then
                Current.Comunicazione.Mail = Mail
            End If
            If Cellulare2 <> "" Then
                Current.Comunicazione.Cellulare2 = Cellulare2
            End If

            If Cellulare1 <> "" Then
                Current.Comunicazione.Cellulare1 = Cellulare1
            End If

            If TelefonoUfficio <> "" Then
                Current.Comunicazione.TelefonoUfficio = TelefonoUfficio
            End If

            If Fax <> "" Then
                Current.Comunicazione.Fax = Fax
            End If

            If TelefonoCasa <> "" Then
                Current.Comunicazione.TelefonoCasa = TelefonoCasa
            End If

            Ps.MarkDirty(m_current)
        End Sub
        Public Property CartellaPreferenziale() As String
            Get
                Return Current.DirectoryPreferenziale
            End Get
            Set(ByVal value As String)
                Current.DirectoryPreferenziale = value
                Ps.MarkDirty(m_current)
            End Set
        End Property

        Public Property Note() As String
            Get
                Return Current.Note
            End Get
            Set(ByVal value As String)
                Current.Note = value
                Ps.MarkDirty(m_current)
            End Set
        End Property



        Public Property CodiceFiscale() As String
            Get
                Return Current.CodiceFiscale
            End Get
            Set(ByVal value As String)
                Current.CodiceFiscale = value
                Ps.MarkDirty(m_current)
            End Set
        End Property
        Public ReadOnly Property IdUtente() As Int32
            Get

                Return Current.Key.LongValue()

            End Get
        End Property
        Public Property Nome() As String
            Get
                Return Current.Nome
            End Get
            Set(ByVal value As String)
                Current.Nome = value
                Ps.MarkDirty(m_current)
            End Set
        End Property
        Public Property Cognome() As String
            Get
                Return Current.Cognome
            End Get
            Set(ByVal value As String)
                Current.Cognome = value
                Ps.MarkDirty(m_current)
            End Set
        End Property
        Public ReadOnly Property CompleteName()
            Get
                Return Current.CompleteName
            End Get
        End Property
        Public ReadOnly Property IdConto() As Int32
            Get
                Return Current.Conto.IdConto
            End Get
        End Property
        Public ReadOnly Property DescrizioneContoUtente() As String
            Get
                Return Current.Conto.Descrizione
            End Get
        End Property
        Public Sub SetConto(ByVal IdConto As String)

            If IsNumeric(IdConto) Then
                Dim conto As Conto = GetContoById(IdConto)
                If conto.TipologiaConto = DOMAIN.FINANCIAL.Conto.TipoConto.Utenti Then
                    Current.Conto = conto
                Else
                    Throw New Exception("Impossibile impostare un conto utente con un tipo conto diverso")
                End If
            Else
                Throw New Exception("L'Id del conto specificato non è di tipo numerico. Inserire un id nel formato corretto.")
            End If

        End Sub
        Private Function GetContoById(ByVal IdConto As Int32) As Conto
            Try
                Return m_ControllerConti.GetContoById(IdConto)
            Catch ex As Exception
                Throw New Exception("Impossibile recuperare il conto con l'id selezionato")
            End Try
        End Function
        Public ReadOnly Property ImportoQuota() As Double
            Get
                Return Current.QuotaMensile.Importo
            End Get
        End Property
        Public ReadOnly Property Valuta() As String
            Get
                Return Moneta.GetTipoValutaToString(Current.QuotaMensile.GetValuta)
            End Get
        End Property
        Public Sub SetQuotaMensile(ByVal Importo As String, ByVal Valuta As String)
            Dim m_Importo As Double
            Dim m_valuta As Moneta.Valuta = Moneta.GetTipoValuta(Valuta)
            If Importo = "" Then Importo = 0
            If IsNumeric(Importo) Then
                m_Importo = CDbl(Importo)
            Else
                Throw New Exception("Impossibile impostare la quota mensile. Inserire una quota mensile corretta.")
            End If
            Current.QuotaMensile = New Moneta(m_Importo, m_valuta)
            Ps.MarkDirty(m_current)
        End Sub
        Public ReadOnly Property ElencoDeleghe() As IList
            Get
                Return ArrayList.ReadOnly(Current.Deleghe)
            End Get
        End Property
#End Region








#Region "Gestione Figli"
        Public Function GetListaFigli() As IList
            Return Current.SituazioneFamiliare.Figli
        End Function




        Public Sub AddFiglio(ByVal Nome As String, ByVal cognome As String, ByVal codiceFiscale As String, ByVal Scuola As String, ByVal AnnoFrequentazione As String, ByVal DataNascita As DateTime)
            Dim figlio As Figlio = New Figlio(Current)

            figlio.Nome = Nome
            figlio.Cognome = cognome
            figlio.CodiceFiscale = codiceFiscale
            figlio.AnnoFrequenza = AnnoFrequentazione
            figlio.Scuola = Scuola
            figlio.DataNascita = DataNascita

            Current.SituazioneFamiliare.Figli.Add(figlio)
            m_currentFiglio = figlio
            Ps.MarkNew(m_currentFiglio)
        End Sub




        Public Sub RemoveFiglio(ByVal code As String)
            Dim Figlio As Figlio = GetFiglio(code)

            If Not Figlio Is Nothing Then
                Current.SituazioneFamiliare.Figli.Remove(Figlio)
                Ps.MarkRemoved(Figlio)
            End If
        End Sub
        Private Function GetFiglio(ByVal code As String) As Figlio
            For Each elem As Figlio In Current.SituazioneFamiliare.Figli
                If elem.GetHashCode.ToString.Equals(code) Then
                    Return elem
                End If
            Next
            Return Nothing
        End Function


        Public Sub SelectFiglio(ByVal Code As String)
            Dim Figlio As Figlio = GetFiglio(Code)
            m_currentFiglio = Figlio
        End Sub




        Public Property DataNascitaFiglio() As DateTime
            Get
                Return m_currentFiglio.DataNascita
            End Get
            Set(ByVal value As DateTime)
                m_currentFiglio.DataNascita = value
                Ps.MarkDirty(m_currentFiglio)
            End Set
        End Property

        Public Property CognomeFiglio() As String
            Get
                Return m_currentFiglio.Cognome
            End Get
            Set(ByVal value As String)
                m_currentFiglio.Cognome = value
                Ps.MarkDirty(m_currentFiglio)
            End Set
        End Property



        Public Property FiscaleFiglio() As String
            Get
                Return m_currentFiglio.CodiceFiscale
            End Get
            Set(ByVal value As String)
                m_currentFiglio.CodiceFiscale = value
                Ps.MarkDirty(m_currentFiglio)
            End Set
        End Property



        Public Property NomeFiglio() As String
            Get
                Return m_currentFiglio.Nome
            End Get
            Set(ByVal value As String)
                m_currentFiglio.Nome = value
                Ps.MarkDirty(m_currentFiglio)
            End Set
        End Property


        Public Property Scuola() As String
            Get
                Return m_currentFiglio.Scuola
            End Get
            Set(ByVal value As String)
                m_currentFiglio.Scuola = value
                Ps.MarkDirty(m_currentFiglio)
            End Set
        End Property

        Public Property AnnoFrequentazione() As String
            Get
                Return m_currentFiglio.AnnoFrequenza
            End Get
            Set(ByVal value As String)
                m_currentFiglio.AnnoFrequenza = value
                Ps.MarkDirty(m_currentFiglio)
            End Set
        End Property


#End Region













#Region "Metodi CRUD"
        Public Overrides Function GetCategoryObject() As String
            Return "Utente"
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
            MyBase.m_current = New Utente
            Dim conto As Conto = CONTI.ControllerConti.GetContoByType("Utenti")
            Current.Conto = conto

            Dim c As New ControllerSegreteria
            c.LoadById(1)
            Current.DirectoryPreferenziale = c.DirectoryPreferenzialeUtenti
            Current.Segreteria = c.GetCurrent()


            Ps.MarkNew(m_current)
        End Sub
        ''' <summary>
        ''' Crea e salva l'istanza dell'oggetto complato con i parametri necessari
        ''' </summary>
        ''' <param name="Nome"></param>
        ''' <param name="Cognome"></param>
        ''' <param name="Importo"></param>
        ''' <remarks></remarks>
        Public Overloads Sub CreateNew(ByVal Nome As String, ByVal Cognome As String, _
                          ByVal Importo As String)
            'questo costruttore è utile se voglio che il client crei e salvi
            'l'oggetto in un unico passaggio.
            'Client.CreateNew(Parameters)

            InputValidation(Importo)
            Dim m_Importo As Double = CDbl(Importo)
            Dim conto As Conto = CONTI.ControllerConti.GetContoByType("Utenti")
            MyBase.m_current = New Utente(Nome, Cognome, New Moneta(m_Importo, conto.Valuta), conto)

            Dim c As New ControllerSegreteria
            c.LoadById(1)
            Current.DirectoryPreferenziale = c.DirectoryPreferenzialeUtenti
            Current.Segreteria = c.GetCurrent()

            Save()

        End Sub
        Private Sub InputValidation(ByRef Quota As String)
            If Quota = "" Then Quota = 0.0
            If Not IsNumeric(Quota) Then
                Throw New Exception("Inserire un un quota mensile in formato numerico corretto")
            End If
        End Sub
        Friend Function GetUtenteById(ByVal IdUtente As Int32) As Utente
            Try

                LoadById(IdUtente)
                Return Current()
            Catch ex As Exception
                Return New UtenteNonSpecificato
            End Try
        End Function
        Public Overloads Function GetIdUtente(ByVal Nome As String, ByVal Cognome As String, ByVal DataNascita As DateTime) As Int32
            Return SearchUtente(Nome, Cognome, DataNascita).Id
        End Function
        Private Overloads Function SearchUtente(ByVal Nome As String, ByVal Cognome As String, ByVal DataNascita As DateTime) As Utente
            Dim nomeUt As String = Replace(Nome, "'", "''")
            Dim CognomeUt As String = Replace(Cognome, "'", "''")

            Dim qry As Query = Ps.CreateNewQuery("MapperUtente")
            Dim main As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.AndOp)
            main.AddCriteria(Criteria.Equal("NOME", "'" & UCase(nomeUt) & "'"))
            main.AddCriteria(Criteria.Equal("COGNOME", "'" & UCase(CognomeUt) & "'"))
            main.AddCriteria(New DateContainedCriteria("DATA_NASCITA", DataNascita, DataNascita, Ps.DBType))
            qry.AddWhereClause(main)
            Dim list As IList = qry.Execute(Ps)
            If list.Count > 0 Then Return list.Item(0)
            Return New UtenteNonSpecificato
        End Function

        Public Overloads Function GetIdUtente(ByVal CodiceFiscale As String) As Int32
            Return SearchUtente(CodiceFiscale).Id
        End Function
        Private Overloads Function SearchUtente(ByVal CodiceFiscale As String) As Utente
            If CodiceFiscale = "" Then
                Return New UtenteNonSpecificato
            End If

            Dim qry As Query = Ps.CreateNewQuery("MapperUtente")
            Dim main As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.AndOp)
            main.AddCriteria(Criteria.Equal("CODICE_FISCALE", "'" & UCase(CodiceFiscale) & "'"))
            qry.AddWhereClause(main)
            Dim list As IList = qry.Execute(Ps)
            If list.Count > 0 Then Return list.Item(0)
            Return New UtenteNonSpecificato
        End Function


        Public Overloads Function GetIdUtente(ByVal Nome As String, ByVal Cognome As String) As Int32
            Return SearchUtente(Nome, Cognome).Id
        End Function
        Private Overloads Function SearchUtente(ByVal Nome As String, ByVal Cognome As String) As Utente
            Dim nomeUt As String = Replace(Nome, "'", "''")
            Dim CognomeUt As String = Replace(Cognome, "'", "''")

            Dim qry As Query = Ps.CreateNewQuery("MapperUtente")
            Dim main As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.AndOp)
            main.AddCriteria(Criteria.Equal("NOME", "'" & UCase(nomeUt) & "'"))
            main.AddCriteria(Criteria.Equal("COGNOME", "'" & UCase(CognomeUt) & "'"))
            qry.AddWhereClause(main)
            Dim list As IList = qry.Execute(Ps)
            If list.Count > 0 Then Return list.Item(0)
            Return New UtenteNonSpecificato
        End Function


        Protected Overrides Sub DoSave()
            Ps.CommitTransaction()
            Ps.BeginTransaction()
        End Sub

        Protected Overrides Sub DoUpdate()
            Ps.CommitTransaction()
            Ps.BeginTransaction()
        End Sub


#End Region



    End Class
End Namespace