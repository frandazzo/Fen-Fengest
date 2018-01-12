Namespace AZIENDE
    Public Class ControllerAziende
        Inherits AbstractController
        Private m_ControllerConti As New CONTI.ControllerConti
        Private controllerSettori As New ControllerSettori
        Private controllerContratti As New ControllerTipoContratto
        Private m_CurrenSedeOperativa As SedeOperativa

        Public Function Current() As Azienda
            Return DirectCast(MyBase.m_current, Azienda)
        End Function
        Public Sub New()
            'Ps.BeginTransaction()
        End Sub
        Public Sub New(ByVal OpenTransaction As Boolean)
            If OpenTransaction Then
                Ps.BeginTransaction()
            End If
        End Sub
#Region "Proprietà oggetto"
        Public Property PartitaIva() As String
            Get
                Return Current.PartitaIva
            End Get
            Set(ByVal value As String)
                Current.PartitaIva = value
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
        Public Property CodiceEC() As String
            Get
                Return Current.Codifica.CodificaEC
            End Get
            Set(ByVal value As String)
                Current.Codifica.CodificaEC = value
                Ps.MarkDirty(m_current)
            End Set
        End Property

        Public Property CodiceCE() As String
            Get
                Return Current.Codifica.CodificaCE
            End Get
            Set(ByVal value As String)
                Current.Codifica.CodificaCE = value
                Ps.MarkDirty(m_current)
            End Set
        End Property


        Public ReadOnly Property ValutaConto() As String
            Get
                Return Moneta.GetTipoValutaToString(Current.Conto.Valuta)
            End Get
        End Property
        Public ReadOnly Property IdAzienda() As Int32
            Get
                Return Current.Key.LongValue
            End Get
        End Property


        Public Property DirectoryPreferenziale() As String
            Get
                Return Current.DirectoryPreferenziale
            End Get
            Set(ByVal value As String)
                Current.DirectoryPreferenziale = value
            End Set
        End Property


        Public Property Descrizione() As String
            Get
                Return Current.Descrizione
            End Get
            Set(ByVal value As String)
                Current.Descrizione = value
                Ps.MarkDirty(m_current)
            End Set
        End Property
        Public Function GetListaContrattiForSettore(ByVal IdSettore As Int32) As ArrayList
            If IdSettore = -1 Then Return New ArrayList
            Return controllerContratti.GetListaContrattiByIdSettore(IdSettore)
        End Function

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
        Public ReadOnly Property ProvinciaSigla() As String
            Get
                Return UCase(Current.IndirizzoSedeLegale.Provincia.Sigla)
            End Get
        End Property
        Public ReadOnly Property ViaLegale() As String
            Get
                Return UCase(Current.IndirizzoSedeLegale.Via)
            End Get
        End Property
        Public ReadOnly Property CapLegale() As String
            Get
                Return Current.IndirizzoSedeLegale.Cap
            End Get
        End Property
        'Public Overloads Sub SetIndirizzoSedeLegale(ByVal Via As String, ByVal NomeProvincia As String, ByVal NomeComune As String)
        '    Dim geo As GeoLocationHandler = WIN.APPLICATION.GeoLocationController.Instance.GetGeoHandler
        '    Dim indirizzo As New Indirizzo
        '    indirizzo.Via = Via
        '    indirizzo.Provincia = geo.GetProvinciaByName(NomeProvincia)
        '    indirizzo.Comune = geo.GetComuneByName(NomeComune)
        '    Current.IndirizzoSedeLegale = indirizzo
        '    Ps.MarkDirty(m_current)
        'End Sub
        Public Overloads Sub SetIndirizzoSedeLegale(ByVal Via As String, ByVal NomeProvincia As String, ByVal NomeComune As String, ByVal Cap As String)
            Dim geo As GeoLocationHandler = GeoLocationFacade.Instance.GetGeoHandler
            Dim indirizzo As New Indirizzo
            indirizzo.Via = Via
            indirizzo.Provincia = geo.GetProvinciaByName(NomeProvincia)
            indirizzo.Comune = geo.GetComuneByName(NomeComune)
            indirizzo.Cap = Cap
            Current.IndirizzoSedeLegale = indirizzo
            Ps.MarkDirty(m_current)
        End Sub
        Public Sub ChangeIndirizzoSedeLegaleIfNew(ByVal Via As String, ByVal NomeProvincia As String, ByVal NomeComune As String, ByVal Cap As String)
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
            If Cap <> "" Then
                indirizzo.Cap = Cap
            End If

            Current.IndirizzoSedeLegale = indirizzo
            Ps.MarkDirty(m_current)
        End Sub
#Region "Gestione sedi operative"
        Public Function GetListaSediOperative() As IList
            Return Current.SediOperative
        End Function

        Public Function GetListaNomiSediOperative() As IList
            Dim list As ArrayList = New ArrayList
            For Each elem As SedeOperativa In Current.SediOperative
                list.Add(elem.Descrizione)
            Next
            Return list
        End Function
        Public Sub AddSedeOperativa(ByVal Descrizione As String, ByVal NomeProvincia As String, ByVal NomeComune As String, ByVal Via As String)
            Dim com As Comune = GeoLocationFacade.Instance.GetGeoHandler.GetComuneByName(NomeComune)
            Dim prov As Provincia = GeoLocationFacade.Instance.GetGeoHandler.GetProvinciaByName(NomeProvincia)
            Dim sede As SedeOperativa = New SedeOperativa(Descrizione, com, prov, Via)
            Current.AddSedeOperativa(sede)
            Ps.MarkNew(sede)
        End Sub
        Public Sub RemoveSedeOperativa(ByVal Descrizione As String)
            Dim sede As SedeOperativa = Current.GetSedeOperativaByDescrizione(Descrizione)
            If Not sede Is Nothing Then
                Current.RemoveSedeOperativa(Descrizione)
                Ps.MarkRemoved(sede)
            End If
        End Sub
        Public Sub SelectSedeOperativa(ByVal Descrizione)
            m_CurrenSedeOperativa = Current.GetSedeOperativaByDescrizione(Descrizione)
        End Sub
        Public Property DescrizioneSedeOperativa() As String
            Get
                Return m_CurrenSedeOperativa.Descrizione
            End Get
            Set(ByVal value As String)
                m_CurrenSedeOperativa.Descrizione = value
                Ps.MarkDirty(m_CurrenSedeOperativa)
            End Set
        End Property
        Public Property ViaSedeOperativa() As String
            Get
                Return m_CurrenSedeOperativa.Indirizzo.Via
            End Get
            Set(ByVal value As String)
                m_CurrenSedeOperativa.Indirizzo.Via = value
                Ps.MarkDirty(m_CurrenSedeOperativa)
            End Set
        End Property
        Public ReadOnly Property DescrizioneComuneSedeOperativa() As String
            Get
                Return m_CurrenSedeOperativa.Indirizzo.Comune.Descrizione
            End Get
        End Property
        Public Sub SetComuneSedeOperativa(ByVal NomeComune As String)
            m_CurrenSedeOperativa.Indirizzo.Comune = GeoLocationFacade.Instance.GetGeoHandler.GetComuneByName(NomeComune)
            Ps.MarkDirty(m_CurrenSedeOperativa)
        End Sub
        Public Sub SetProvinciaSedeOperativa(ByVal NomeProvincia As String)
            m_CurrenSedeOperativa.Indirizzo.Provincia = GeoLocationFacade.Instance.GetGeoHandler.GetProvinciaByName(NomeProvincia)
            Ps.MarkDirty(m_CurrenSedeOperativa)
        End Sub
        Public ReadOnly Property DescrizioneProvinciaSedeOperativa() As String
            Get
                Return m_CurrenSedeOperativa.Indirizzo.Provincia.Descrizione
            End Get
        End Property
        Public ReadOnly Property CAPSedeOperativa() As String
            Get
                Return m_CurrenSedeOperativa.Indirizzo.Comune.CAP
            End Get
        End Property
#End Region




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
            Ps.MarkDirty(m_current)
        End Sub

        Public Sub ChangeComunicazioneIfNew(ByVal TelefonoUfficio As String, ByVal Fax As String, ByVal Mail As String, ByVal Cellulare1 As String, ByVal Cellulare2 As String)


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


            Current.Comunicazione.TelefonoCasa = ""
            Ps.MarkDirty(m_current)
        End Sub


        Public Property Responsabile() As String
            Get
                Return Current.Responsable
            End Get
            Set(ByVal value As String)
                Current.Responsable = value
                Ps.MarkDirty(m_current)
            End Set
        End Property


        Public Property UnitaDiCompetenza() As String
            Get
                Select Case Current.UnitaDiCompetenza
                    Case IConfrontoPeriodi.UnitaDiCompetenza.Giornaliera
                        Return "Periodi generici"
                    Case IConfrontoPeriodi.UnitaDiCompetenza.Mensile
                        Return "Periodi mensili"
                    Case Else
                        Throw New Exception("Impossibile ottenere il valore dell'unità di competenza. Tipo sconosciuto")
                End Select
            End Get
            Set(ByVal value As String)
                Current.UnitaDiCompetenza = Me.GetTipoConfronto(value)
                Ps.MarkDirty(m_current)
            End Set
        End Property
        Public Property Scarto() As String
            Get
                Return Current.Scarto
            End Get
            Set(ByVal value As String)
                If value = "" Then value = 0
                If Not IsNumeric(value) Then Throw New Exception("Il valore dello scarto non ha un formato corretto. Correggere la percentuale di scarto immessa.")
                Current.Scarto = value
                Ps.MarkDirty(m_current)
            End Set
        End Property
        Public ReadOnly Property CompetenzaUltimoPagamento() As String
            Get
                If TypeOf Current.CompetenzaUltimoPagamento Is PeriodoNullo Then
                    Return "Nessun pagamento"
                Else
                    Return Current.CompetenzaUltimoPagamento.ToString
                End If
            End Get
        End Property
        Public Property CalcolatoreCongruita() As String
            Get
                Select Case Current.CalcolatoreCongruita
                    Case AbstractCalculator.TipoCalcolatore.Lineare
                        Return "Calcolatore lineare"
                    Case Else
                        Throw New Exception("Impossibile ottenere il calcolatore di congruità. Tipo sconosciuto")
                End Select
            End Get
            Set(ByVal value As String)
                Current.CalcolatoreCongruita = Me.GetTipoCalcolatoreCongruita(value)
                Ps.MarkDirty(m_current)
            End Set
        End Property
        Private Function GetTipoConfronto(ByVal TipoConfronto As String) As IConfrontoPeriodi.UnitaDiCompetenza
            Select Case TipoConfronto
                Case "Periodi generici"
                    Return IConfrontoPeriodi.UnitaDiCompetenza.Giornaliera
                Case "Periodi mensili"
                    Return IConfrontoPeriodi.UnitaDiCompetenza.Mensile
                Case Else
                    Throw New Exception("Impossibile trovare il valore dell'unità di competenza impostato. Tipo sconosciuto")
            End Select
        End Function
        Private Function GetTipoCalcolatoreCongruita(ByVal TipoCalcolatore As String) As AbstractCalculator.TipoCalcolatore
            Select Case TipoCalcolatore
                Case "Calcolatore lineare"
                    Return AbstractCalculator.TipoCalcolatore.Lineare
            End Select
            Throw New Exception("Impossibile trovare il calcolatore congruità richiesto. Tipo sconosciuto")
        End Function
        Public ReadOnly Property IdConto() As Int32
            Get
                Return Current.Conto.IdConto
            End Get

        End Property
        Public Sub SetConto(ByVal IdConto As String)

            If Not IsNumeric(IdConto) Then Throw New Exception("L'id del conto inserito non ha una formato corretto. Correggere l'id del conto.")
            Dim conto As Conto = m_ControllerConti.GetContoById(IdConto)
            If conto.TipologiaConto = DOMAIN.FINANCIAL.Conto.TipoConto.Feneal Then
                Current.Conto = conto
                Ps.MarkDirty(m_current)
            Else
                Throw New Exception("Impossibile impostare un conto azienda con un conto di diverso tipo")
            End If

        End Sub
        Public ReadOnly Property DescrizioneConto() As String
            Get
                Return Current.Conto.Descrizione
            End Get
        End Property
        Public ReadOnly Property DescrizioneContratto() As String
            Get
                Return Current.ContrattoApplicato.Descrizione
            End Get
        End Property
        Public ReadOnly Property IdSettoreContratto() As Int32
            Get
                Return Current.ContrattoApplicato.SettoreSpecifico.Id
            End Get
        End Property
        Public Sub SetContrattoApplicato(ByVal IdTipoContratto As String)

            If IdTipoContratto = "-1" Or IdTipoContratto = "" Then
                Current.ContrattoApplicato = New TipoContrattoNullo
                Exit Sub
            End If
            Dim controllerContratti As New ControllerTipoContratto
            Current.ContrattoApplicato = controllerContratti.GetTipoContrattoById(IdTipoContratto)
            Ps.MarkDirty(m_current)
        End Sub
#End Region

        Public Function GetIdContrattoByDescrizione(ByVal Descrizione As String) As String
            Dim id As Int32 = controllerContratti.GetIdTipoContrattoByDescrizione(Descrizione)
            If id = -1 Then
                Return ""
            End If
            Return id
        End Function

#Region "Metodi CRUD"
        Public Overrides Function GetCategoryObject() As String
            Return "Azienda"
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
            MyBase.m_current = New Azienda
            Current.Conto = CONTI.ControllerConti.GetContoByType("Feneal")
            Dim c As New ControllerSegreteria
            c.LoadById(1)
            Current.DirectoryPreferenziale = c.DirectoryPreferenzialeAziende
            Ps.MarkNew(m_current)
        End Sub
        ''' <summary>
        ''' Crea e salva l'istanza dell'oggetto compilato con i parametri necessari
        ''' </summary>
        ''' <param name="Descrizione"></param>
        ''' <param name="DataInizioUltimaCompetenza"></param>
        ''' <param name="DataFineUltimaCompetenza"></param>
        ''' <param name="PercentualeScarto"></param>
        ''' <remarks></remarks>
        Public Overloads Sub CreateNew(ByVal Descrizione As String, ByVal DataInizioUltimaCompetenza As DateTime, _
                                             ByVal DataFineUltimaCompetenza As DateTime, _
                                             ByVal PercentualeScarto As String, ByVal IdTipoContratto As String)

            'questo costruttore è utile se voglio che il client crei e salvi
            'l'oggetto in un unico passaggio.
            'Client.CreateNew(Parameters)

            If Not IsNumeric(PercentualeScarto) Then Throw New Exception("Il valore dello scarto non ha un formato corretto. Correggere la percentuale di scarto immessa.")
            Dim Competenza As AbstractPeriodo
            Dim datarange As DataRange = New DataRange(DataInizioUltimaCompetenza, DataFineUltimaCompetenza)
            If datarange.IsEmpty Then
                Competenza = New PeriodoNullo
            Else
                Competenza = New CompositePeriodo(datarange, IConfrontoPeriodi.UnitaDiCompetenza.Mensile)
            End If
            MyBase.m_current = New Azienda(Descrizione, Competenza, CONTI.ControllerConti.GetContoByType("Feneal"), IConfrontoPeriodi.UnitaDiCompetenza.Mensile, AbstractCalculator.TipoCalcolatore.Lineare, PercentualeScarto, GetContratto(IdTipoContratto))
            Dim c As New ControllerSegreteria
            c.LoadById(1)
            Current.DirectoryPreferenziale = c.DirectoryPreferenzialeAziende
            Ps.MarkNew(m_current)
            'Ps.InsertObject(Current.GetType.Name, m_current)

        End Sub
        Private Function GetContratto(ByVal IdTipoContratto As String) As TipoContratto
            If IdTipoContratto = CStr(-1) Or IdTipoContratto = "" Then Return New TipoContrattoNullo
            Return controllerContratti.GetTipoContrattoById(IdTipoContratto)
        End Function


        '' < name="UnitaCompetenzaPagamenti">I valori possibili sono: "Periodi generici", "Periodi mensili"</param>
        '' <name="RegolaCalcoloCongruita">i valori ammessi sono: "Calcolatore lineare"</param>

        ''' <summary>
        ''' Crea una nuova istanza dell'oggetto salvandola nella base dati
        ''' </summary>
        ''' <param name="Descrizione"></param>
        ''' <param name="PercentualeScarto"></param>
        ''' <param name="IdTipoContratto"></param>
        ''' <remarks></remarks>
        Public Overloads Sub CreateNew(ByVal Descrizione As String, _
                                       ByVal PercentualeScarto As String, ByVal IdTipoContratto As String)

            'questo costruttore è utile se voglio che il client crei e salvi
            'l'oggetto in un unico passaggio.
            'Client.CreateNew(Parameters)


            If PercentualeScarto = "" Then PercentualeScarto = "0"
            If Not IsNumeric(PercentualeScarto) Then Throw New Exception("Il valore dello scarto non ha un formato corretto. Correggere la percentuale di scarto immessa.")
            MyBase.m_current = New Azienda(Descrizione, New PeriodoNullo, CONTI.ControllerConti.GetContoByType("Feneal"), IConfrontoPeriodi.UnitaDiCompetenza.Mensile, AbstractCalculator.TipoCalcolatore.Lineare, PercentualeScarto, GetContratto(IdTipoContratto))
            Dim c As New ControllerSegreteria
            c.LoadById(1)
            Current.DirectoryPreferenziale = c.DirectoryPreferenzialeAziende
            Save()

        End Sub
        Friend Function GetAziendaById(ByVal IdAzienda As String) As Azienda

            Try
                LoadById(IdAzienda)
            Catch ex As Exception
                Return New AziendaNonSpecificata
            End Try
            Return Current()

        End Function


        Protected Overrides Sub DoSave()

            'la transazione è stata aperta alla creazione del controller

            Ps.CommitTransaction()
            Ps.BeginTransaction()

            'Ps.InsertObject(Me.GetCategoryObject, m_current)

        End Sub
        Protected Overrides Sub DoUpdate()

            'la transazione è stata aperta alla creazione del controller

            Ps.CommitTransaction()
            Ps.BeginTransaction()

            'Ps.InsertObject(Me.GetCategoryObject, m_current)

        End Sub
        Public Overloads Function GetIdAzienda(ByVal Descrizione As String, ByVal PartitaIva As String)
            Return SearchAzienda(Descrizione, PartitaIva).Id
        End Function

        Public Overloads Function GetIdAzienda(ByVal Descrizione As String)
            Return SearchAzienda(Descrizione).Id
        End Function

        Public Overloads Function GetIdAziendaByPIVA(ByVal Piva As String)
            Return SearchAziendaByPIVA(Piva).Id
        End Function
        Private Overloads Function SearchAzienda(ByVal Descrizione As String, ByVal PartitaIva As String) As Azienda

            If PartitaIva = "" Then
                Return SearchAzienda(Descrizione)
            End If
            Dim DescrAz As String = Replace(Descrizione, "'", "''")
            Dim PartIva As String = Replace(PartitaIva, "'", "''")


            Dim qry As Query = Ps.CreateNewQuery("MapperAzienda")
            Dim main As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.AndOp)
            main.AddCriteria(Criteria.Equal("DESCRIZIONE", "'" & UCase(DescrAz) & "'"))
            main.AddCriteria(Criteria.Equal("P_IVA", "'" & PartIva & "'"))
            qry.AddWhereClause(main)
            Dim list As IList = qry.Execute(Ps)
            If list.Count > 0 Then Return list.Item(0)
            Return New AziendaNonSpecificata
        End Function
        Private Overloads Function SearchAzienda(ByVal Descrizione As String) As Azienda
            Dim DescrAz As String = Replace(Descrizione, "'", "''")
            Dim qry As Query = Ps.CreateNewQuery("MapperAzienda")
            Dim main As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.AndOp)
            main.AddCriteria(Criteria.Equal("DESCRIZIONE", "'" & UCase(DescrAz) & "'"))
            qry.AddWhereClause(main)
            Dim list As IList = qry.Execute(Ps)
            If list.Count > 0 Then Return list.Item(0)
            Return New AziendaNonSpecificata
        End Function
        Private Overloads Function SearchAziendaByPIVA(ByVal PartitaIva As String) As Azienda

            Dim PartIva As String = Replace(PartitaIva, "'", "''")
            Dim qry As Query = Ps.CreateNewQuery("MapperAzienda")
            Dim main As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.AndOp)
            main.AddCriteria(Criteria.Equal("P_IVA", "'" & PartIva & "'"))
            qry.AddWhereClause(main)
            Dim list As IList = qry.Execute(Ps)
            If list.Count > 0 Then Return list.Item(0)
            Return New AziendaNonSpecificata
        End Function
#End Region


    End Class
End Namespace