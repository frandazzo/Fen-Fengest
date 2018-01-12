Public Class MapperItemDocumentoContabile
    Inherits AbstractRDBMapper
    Private CassaEdile As EnteBilaterale = Nothing
    Private EdilCassa As EnteBilaterale = Nothing
    Private IDCassaEdile As Int32 = 1
    Private IDEdilCassa As Int32 = 2
    Private SettoreEdile As Settore = Nothing
    Private IDSettoreEdile As Int32 = 2
    Private SettoreIF As Settore = Nothing
    Private IDSettoreIF As Int32 = 1
    Public Sub New()
        'MyBase.Cache = New PersistentObjectCache(True)
    End Sub

#Region "Istruzioni Sql"
    Protected Function FindItemsByIncassoStatement() As String
        Return "Select * from DB_ITEM_DOCUMENTO_CONTABILE where Id_Documento_Contabile = @IdP"
    End Function
    Protected Function FindItemsByPagamentoReferentiStatement() As String
        Return "Select * from DB_ITEM_DOCUMENTO_CONTABILE where Id_Documento_Contabile = @IdP"
    End Function
    Protected Function FindItemsRistornateByPagamentoReferentiStatement() As String
        Return "Select * from DB_ITEM_DOCUMENTO_CONTABILE where Id_Pagamento_Referente = @IdP and (Tipo_Documento_Contabile = 'IQA' or Tipo_Documento_Contabile = 'IQI' or Tipo_Documento_Contabile = 'IQV')"
    End Function

    'Protected Function FindItemsIQANotPaidToReferentiStatement() As String
    '   Return "Select * from DB_ITEM_DOCUMENTO_CONTABILE where Tipo_Documento_Contabile = 'IQA' and Id_Referente = @IdP and Id_Pagamento_Referente is NULL"
    'End Function
    Protected Function FindItemsByContoStatement() As String
        Return "SELECT Top 10 * FROM DB_ITEM_DOCUMENTO_CONTABILE WHERE ID_CONTO = @IdP"
    End Function
    Protected Overrides Function FindAllStatement() As String
        Return "Select * from DB_ITEM_DOCUMENTO_CONTABILE"
    End Function
    Protected Overrides Function FindByKeyStatement() As String
        Return "Select * from DB_ITEM_DOCUMENTO_CONTABILE where Id = @Id and Id_Documento_Contabile = @IdP"
    End Function
    Protected Overrides Function InsertStatement() As String
        Return "Insert into DB_ITEM_DOCUMENTO_CONTABILE (ID,Id_Documento_Contabile, " _
             & "DATA_REGISTRAZIONE, DATA_DOCUMENTO, NOTE_ITEM, TIPO_DOCUMENTO_CONTABILE, " _
             & "DATA_INIZIO_COMP, DATA_FINE_COMP, IMPORTO, VALUTA, ID_AZIENDA, TREDICESIMA, QUATTORDICESIMA, " _
             & "ID_REFERENTE, ID_UTENTE, ID_CONTO, ID_PAGAMENTO_REFERENTE, IMPORTO_RISTORNATO, " _
             & "ID_AZIENDA_IMPIEGO, ID_SETTORE, ID_TIPO_CONTRATTO, LIVELLO_INQUADRAMENTO, ORE_LAVORATE, ORE_MALATTIA, ID_PRESTAZIONE, ID_VERTENZA, NOME_SEDE_OPERATIVA) values " _
             & "(@Id, @IdP, @Drg, @Ddc, @Not, @Tdc, @Di, @Df, @Imp, " _
             & "@Val, @Az, @Tr, @Qu, @Ref, @Ut, @Con, @Idpr, @Iri, @IdAi, @IdS, @IdT, @Liv, @Ol, @Om, @Pre, @Idve, @Sed)"
    End Function
    Protected Overrides Function UpdateStatement() As String
        Return "UPDATE DB_ITEM_DOCUMENTO_CONTABILE SET DATA_REGISTRAZIONE = @Drg, DATA_DOCUMENTO = @Ddc, NOTE_ITEM = @Not, " _
              & "TIPO_DOCUMENTO_CONTABILE = @Tdc, DATA_INIZIO_COMP = @Di, DATA_FINE_COMP = @Df, IMPORTO = @Imp, " _
              & "VALUTA = @Val, ID_AZIENDA = @Az, " _
              & "TREDICESIMA = @Tr, QUATTORDICESIMA = @Qu, ID_REFERENTE = @Ref, ID_UTENTE = @Ut, " _
              & "ID_CONTO = @Con, ID_PAGAMENTO_REFERENTE = @Idpr, IMPORTO_RISTORNATO = @Iri, " _
              & "ID_AZIENDA_IMPIEGO = @IdAi, ID_SETTORE = @IdS, ID_TIPO_CONTRATTO = @IdT, " _
              & "LIVELLO_INQUADRAMENTO = @Liv, ORE_LAVORATE = @Ol, ORE_MALATTIA = @Om, ID_PRESTAZIONE = @Pre, ID_VERTENZA = @Idve, NOME_SEDE_OPERATIVA = @Sed WHERE (Id = @Id and Id_Documento_Contabile = @IdP )"
    End Function
    'la cancellazione di un insieme di posizioni legate ad un PagamentoItem avverrà tramite cancellazione a cascata
    'del PagamentoItem. Verrà impostata una relazione su DB con queste opzioni
    Protected Overrides Function DeleteStatement() As String
        Return "Delete from DB_ITEM_DOCUMENTO_CONTABILE where Id = @Id and Id_Documento_Contabile = @IdP"
    End Function
    Protected Overrides Function FindNextKeyStatement() As String
        Return "Select Max(Id) from DB_ITEM_DOCUMENTO_CONTABILE where Id_Documento_Contabile = @IdP"
    End Function
#End Region





#Region "Metodi per il caricamento dell'oggetto"
    Protected Overloads Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable, ByVal Documento As DocumentoContabile) As AbstractPersistenceObject
        Try
            Dim DATA_REGISTRAZIONE As DateTime = IIf(rs("DATA_REGISTRAZIONE") IsNot Nothing, rs("DATA_REGISTRAZIONE"), DateTime.MinValue)
            Dim DATA_DOCUMENTO As DateTime = IIf(rs("DATA_DOCUMENTO") IsNot Nothing, rs("DATA_DOCUMENTO"), DateTime.MinValue)
            Dim NOTE As String = IIf(rs("NOTE_ITEM") IsNot Nothing, rs("NOTE_ITEM"), "")
            Dim DI As DateTime = IIf(rs("DATA_INIZIO_COMP") IsNot Nothing, rs("DATA_INIZIO_COMP"), DateTime.MinValue)
            Dim DF As DateTime = IIf(rs("DATA_FINE_COMP") IsNot Nothing, rs("DATA_FINE_COMP"), DateTime.MinValue)
            Dim IMP As Double = IIf(rs("IMPORTO") IsNot Nothing, rs("IMPORTO"), 0)
            Dim IMP_RIST As Double = IIf(rs("IMPORTO_RISTORNATO") IsNot Nothing, rs("IMPORTO_RISTORNATO"), 0)
            Dim VALUTA As Moneta.Valuta = IIf(rs("VALUTA") IsNot Nothing, rs("VALUTA"), Moneta.Valuta.Euro)
            Dim ID_AZIENDA As Int32 = IIf(rs("ID_AZIENDA") IsNot Nothing, rs("ID_AZIENDA"), -1)
            Dim ID_UTENTE As Int32 = IIf(rs("ID_UTENTE") IsNot Nothing, rs("ID_UTENTE"), -1)
            Dim ID_REFERENTE As Int32 = IIf(rs("ID_REFERENTE") IsNot Nothing, rs("ID_REFERENTE"), -1)
            Dim ID_CONTO As Int32 = IIf(rs("ID_CONTO") IsNot Nothing, rs("ID_CONTO"), -1)
            Dim TR As Boolean = IIf(rs("TREDICESIMA") IsNot Nothing, rs("TREDICESIMA"), False)
            Dim QU As Boolean = IIf(rs("QUATTORDICESIMA") IsNot Nothing, rs("QUATTORDICESIMA"), False)
            Dim TIPO_DOCUMENTO As String = IIf(rs("TIPO_DOCUMENTO_CONTABILE") IsNot Nothing, rs("TIPO_DOCUMENTO_CONTABILE"), "")
            Dim ID_PGR As Int32 = IIf(rs("ID_PAGAMENTO_REFERENTE") IsNot Nothing, rs("ID_PAGAMENTO_REFERENTE"), -1)
            Dim ID_SETTORE As Int32 = IIf(rs("ID_SETTORE") IsNot Nothing, rs("ID_SETTORE"), -1)
            Dim ID_AZIENDA_IMPIEGO As Int32 = IIf(rs("ID_AZIENDA_IMPIEGO") IsNot Nothing, rs("ID_AZIENDA_IMPIEGO"), -1)
            Dim ID_TIPO_CONTRATTO As Int32 = IIf(rs("ID_TIPO_CONTRATTO") IsNot Nothing, rs("ID_TIPO_CONTRATTO"), -1)
            Dim ORE_LAVORATE As Double = IIf(rs("ORE_LAVORATE") IsNot Nothing, rs("ORE_LAVORATE"), 0)
            Dim ORE_MALATTIA As Double = IIf(rs("ORE_MALATTIA") IsNot Nothing, rs("ORE_MALATTIA"), 0)
            Dim LIVELLO_INQUADRAMENTO As String = IIf(rs("LIVELLO_INQUADRAMENTO") IsNot Nothing, rs("LIVELLO_INQUADRAMENTO"), "")
            Dim NOME_SEDE_OPERATIVA As String = IIf(rs("NOME_SEDE_OPERATIVA") IsNot Nothing, rs("NOME_SEDE_OPERATIVA"), "")
            Dim ID_PRESTAZIONE As Int32 = IIf(rs("ID_PRESTAZIONE") IsNot Nothing, rs("ID_PRESTAZIONE"), -1)
            Dim ID_VERTENZA As Int32 = IIf(rs("ID_VERTENZA") IsNot Nothing, rs("ID_VERTENZA"), -1)


            Dim PagamentoReferenti As DocumentoContabile = New DocumentoNullo
            Dim importoRistorno As Moneta = New Moneta(0, VALUTA)
            If ID_PGR > -1 Then
                Dim MapperPagamentoReferenti As MapperPagamentoReferenti = PersistenceMapperRegistry.Instance.GetMapperByName("MapperPagamentoReferenti")
                PagamentoReferenti = MapperPagamentoReferenti.FindObjectById(ID_PGR)
                importoRistorno = New Moneta(IMP_RIST, VALUTA)
                If PagamentoReferenti Is Nothing Then
                    PagamentoReferenti = New DocumentoNullo
                    importoRistorno = New Moneta(0, VALUTA)
                End If
            End If







            Dim MapperTipoContratto As MapperTipoContratto = PersistenceMapperRegistry.Instance.GetMapperByName("MapperTipoContratto")
            Dim MapperAziende As MapperAzienda = PersistenceMapperRegistry.Instance.GetMapperByName("MapperAzienda")

            'Dim MapperUtenti As MapperUtente = PersistenceMapperRegistry.Instance.GetMapperByName("MapperUtente")
            Dim MapperReferenti As MapperReferente = PersistenceMapperRegistry.Instance.GetMapperByName("MapperReferente")
            Dim MapperConti As MapperConto = PersistenceMapperRegistry.Instance.GetMapperByName("MapperConto")


            'Dim Utente As Utente = IIf(ID_UTENTE > -1, MapperUtenti.FindObjectById(ID_UTENTE), New UtenteNonSpecificato)
            Dim Utente As IUtente = New LazyLoadUtente(ID_UTENTE)
            Dim Referente As Referente = IIf(ID_REFERENTE > -1, MapperReferenti.FindObjectById(ID_REFERENTE), New ReferenteNullo)
            Dim Conto As Conto = IIf(ID_CONTO > -1, MapperConti.FindObjectById(ID_CONTO), New ContoNullo)
            Dim TipoContratto As TipoContratto = IIf(ID_TIPO_CONTRATTO > -1, MapperTipoContratto.FindObjectById(ID_TIPO_CONTRATTO), new TipoContrattoNullo)

            Dim Settore As Settore
            Select Case ID_SETTORE
                Case IDSettoreEdile
                    If SettoreEdile Is Nothing Then
                        Dim MapperSettori As MapperSettore = PersistenceMapperRegistry.Instance.GetMapperByName("MapperSettore")
                        Settore = MapperSettori.FindObjectById(ID_SETTORE)
                        SettoreEdile = Settore
                    End If
                    Settore = SettoreEdile
                Case IDSettoreIF
                    If SettoreIF Is Nothing Then
                        Dim MapperSettori As MapperSettore = PersistenceMapperRegistry.Instance.GetMapperByName("MapperSettore")
                        Settore = MapperSettori.FindObjectById(ID_SETTORE)
                        SettoreIF = Settore
                    End If
                    Settore = SettoreIF
            End Select

            'A questo punto della routine devo decidere che tipo di posizione creare
            'in base al tipo documento

            Dim AZIENDA As Azienda

            Select Case TIPO_DOCUMENTO
                Case "IQA"
                    AZIENDA = GetSoggettoEsecutore(DirectCast(Documento, IncassoQuotaAssociativa).Settore, ID_AZIENDA)
                    Dim posUtente As Boolean = IIf(ID_UTENTE > -1, True, False)
                    Dim IncassoItem As ItemIncassoQuotaAssociativa
                    Dim competenza As AbstractPeriodo = CalculateCompetenza(DI, DF, AZIENDA)
                    If posUtente Then
                        If DirectCast(Documento, IncassoQuotaAssociativa).Settore.TipologiaSettore = DOMAIN.FEDERATIONARTIFACTS.Settore.TipoSettore.ImpiantiFissi Then
                            Dim sede As SedeOperativa = AZIENDA.GetSedeOperativaByDescrizione(NOME_SEDE_OPERATIVA)
                            If sede Is Nothing Then sede = New SedeOperativaNulla
                            IncassoItem = New ItemIncassoQuotaAssociativa(Utente, Documento, New Moneta(IMP, VALUTA), Referente, AZIENDA, NOTE, competenza, TR, QU, True, sede)
                        Else
                            IncassoItem = New ItemIncassoQuotaAssociativa(Utente, Documento, New Moneta(IMP, VALUTA), Referente, AZIENDA, NOTE, competenza, TR, QU, True)
                            IncassoItem.AziendaImpiego = IIf(ID_AZIENDA_IMPIEGO > -1, MapperAziende.FindObjectById(ID_AZIENDA_IMPIEGO), New AziendaNonSpecificata)
                        End If
                    Else
                        IncassoItem = New ItemIncassoQuotaAssociativa(Documento, New Moneta(IMP, VALUTA), competenza, AZIENDA, TR, QU, NOTE)
                    End If
                    IncassoItem.PagamentoReferente = PagamentoReferenti
                    IncassoItem.ImportoRistorno = importoRistorno
                    IncassoItem.OreLavorate = ORE_LAVORATE
                    IncassoItem.OreMalattia = ORE_MALATTIA
                    IncassoItem.LivelloInquadramento = LIVELLO_INQUADRAMENTO
                    If TipoContratto.Descrizione <> "" Then
                        IncassoItem.ContrattoApplicato = TipoContratto
                    End If

                    IncassoItem.Key = Key
                    Return IncassoItem

                Case "IQP"
                    AZIENDA = GetSoggettoEsecutore(DirectCast(Documento, IncassoQuotaPrevisionale).Settore, ID_AZIENDA)
                    Dim posUtente As Boolean = IIf(ID_UTENTE > -1, True, False)
                    Dim IncassoItem As ItemIncassoQuotaPrevisionale
                    Dim competenza As AbstractPeriodo = CalculateCompetenza(DI, DF, AZIENDA)
                    If posUtente Then
                        If DirectCast(Documento, IncassoQuotaPrevisionale).Settore.TipologiaSettore = DOMAIN.FEDERATIONARTIFACTS.Settore.TipoSettore.ImpiantiFissi Then
                            Dim sede As SedeOperativa = AZIENDA.GetSedeOperativaByDescrizione(NOME_SEDE_OPERATIVA)
                            If sede Is Nothing Then sede = New SedeOperativaNulla
                            IncassoItem = New ItemIncassoQuotaPrevisionale(Utente, Documento, New Moneta(IMP, VALUTA), Referente, AZIENDA, NOTE, competenza, TR, QU, True, sede)
                        Else
                            IncassoItem = New ItemIncassoQuotaPrevisionale(Utente, Documento, New Moneta(IMP, VALUTA), Referente, AZIENDA, NOTE, competenza, TR, QU, True)
                            IncassoItem.AziendaImpiego = IIf(ID_AZIENDA_IMPIEGO > -1, MapperAziende.FindObjectById(ID_AZIENDA_IMPIEGO), New AziendaNonSpecificata)
                        End If
                    Else
                        IncassoItem = New ItemIncassoQuotaPrevisionale(Documento, New Moneta(IMP, VALUTA), competenza, AZIENDA, TR, QU, NOTE)
                    End If
                    IncassoItem.PagamentoReferente = New DocumentoNullo
                    IncassoItem.ImportoRistorno = importoRistorno
                    IncassoItem.OreLavorate = ORE_LAVORATE
                    IncassoItem.OreMalattia = ORE_MALATTIA
                    IncassoItem.LivelloInquadramento = LIVELLO_INQUADRAMENTO
                    IncassoItem.Key = Key
                    Return IncassoItem

                Case "PGR"
                    Dim PagRefItem As ItemPagamentoReferenti = New ItemPagamentoReferenti(Documento, New Moneta(IMP, VALUTA), Conto, NOTE, Referente)
                    PagRefItem.Key = Key
                    PagRefItem.PagamentoReferente = Documento
                    Return PagRefItem

                Case "IQI"

                    Dim MapperPrestazione As MapperPrestazione = PersistenceMapperRegistry.Instance.GetMapperByName("MapperPrestazione")
                    Dim prestazione As Prestazione = MapperPrestazione.FindObjectById(ID_PRESTAZIONE)
                    If prestazione Is Nothing Then prestazione = New PrestazioneNulla
                    Dim MapperInps As MapperInps = PersistenceMapperRegistry.Instance.GetMapperByName("MapperInps")


                    Dim posUtente As Boolean = IIf(ID_UTENTE > -1, True, False)
                    Dim IncassoItem As ItemIncassoQuoteInps
                    AZIENDA = MapperInps.FindObjectById(1)
                    Dim competenza As AbstractPeriodo = CalculateCompetenza(DI, DF, AZIENDA)
                    If posUtente Then
                        IncassoItem = New ItemIncassoQuoteInps(Utente, Documento, New Moneta(IMP, VALUTA), Referente, AZIENDA, NOTE, competenza, TR, QU, prestazione)
                    Else
                        IncassoItem = New ItemIncassoQuoteInps(Documento, New Moneta(IMP, VALUTA), competenza, AZIENDA, TR, QU, NOTE)
                    End If
                    'IncassoItem.SetConto(Conto)
                    IncassoItem.PagamentoReferente = PagamentoReferenti
                    IncassoItem.ImportoRistorno = New Moneta(IMP_RIST, VALUTA)
                    IncassoItem.Key = Key
                    Return IncassoItem

                Case "IQV"
                    Dim MapperVertenza As MapperVertenza = PersistenceMapperRegistry.Instance.GetMapperByName("MapperVertenza")
                    Dim Vertenza As Vertenza = MapperVertenza.FindObjectById(ID_VERTENZA)
                    If Vertenza Is Nothing Then Vertenza = New VertenzaNulla
                    Dim posUtente As Boolean = IIf(ID_UTENTE > -1, True, False)
                    Dim IncassoItem As ItemIncassoQuoteVertenza
                    If posUtente Then
                        IncassoItem = New ItemIncassoQuoteVertenza(Utente, Documento, New Moneta(IMP, VALUTA), Referente, NOTE, Vertenza)
                    Else
                        IncassoItem = New ItemIncassoQuoteVertenza(Documento, New Moneta(IMP, VALUTA), Conto, NOTE)
                    End If
                    IncassoItem.PagamentoReferente = PagamentoReferenti
                    IncassoItem.ImportoRistorno = New Moneta(IMP_RIST, VALUTA)
                    IncassoItem.Key = Key
                    Return IncassoItem

                Case Else
                    Throw New Exception("Tipo documento sconosciuto.")
            End Select

        Catch ex As Exception
            Throw New Exception("Impossibile caricare l'oggetto Posizione di pagamento." & vbCrLf & ex.Message)
        End Try
    End Function
    Private Function GetSoggettoEsecutore(ByVal Settore As Settore, ByVal IdSoggetto As Int32) As Azienda
        Dim azienda As Azienda = New AziendaNonSpecificata
        Dim MapperAziende As MapperAzienda = PersistenceMapperRegistry.Instance.GetMapperByName("MapperAzienda")

        Select Case Settore.TipologiaSettore
            Case DOMAIN.FEDERATIONARTIFACTS.Settore.TipoSettore.Edili
                Select Case IdSoggetto
                    Case IDCassaEdile
                        If CassaEdile Is Nothing Then
                            Dim MapperEnte As MapperEnteBilaterale = PersistenceMapperRegistry.Instance.GetMapperByName("MapperEnteBilaterale")
                            azienda = MapperEnte.FindObjectById(IdSoggetto)
                            CassaEdile = azienda
                        End If
                        azienda = CassaEdile
                    Case IDEdilCassa
                        If EdilCassa Is Nothing Then
                            Dim MapperEnte As MapperEnteBilaterale = PersistenceMapperRegistry.Instance.GetMapperByName("MapperEnteBilaterale")
                            azienda = MapperEnte.FindObjectById(IdSoggetto)
                            EdilCassa = azienda
                        End If
                        azienda = EdilCassa
                End Select
            Case DOMAIN.FEDERATIONARTIFACTS.Settore.TipoSettore.ImpiantiFissi
                azienda = MapperAziende.FindObjectById(IdSoggetto)
                If azienda Is Nothing Then azienda = New AziendaNonSpecificata
        End Select
        Return azienda
    End Function
    Private Function CalculateCompetenza(ByVal Di As DateTime, ByVal Df As DateTime, ByVal Azienda As Azienda) As AbstractPeriodo
        Dim competenza As AbstractPeriodo
        If Di = DateTime.MinValue Or Df = DateTime.MinValue Then
            competenza = New PeriodoNullo
        Else
            competenza = New CompositePeriodo(New DataRange(Di, Df), Azienda.UnitaDiCompetenza)
        End If
        Return competenza
    End Function
    Protected Overloads Overrides Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable) As AbstractPersistenceObject
        Throw New Exception("Metodo DoLoad mapper posizione documento non implementato")
    End Function
    Protected Overloads Function Load(ByVal rs As Hashtable, ByVal Documento As DocumentoContabile) As AbstractPersistenceObject
        Try
            Dim key As Key = CreateKey(rs)
            If Cache.GetObjectFromCache(key.ToString) IsNot Nothing Then Return DirectCast(Cache.GetObjectFromCache(key.ToString), AbstractPersistenceObject)
            Dim obj As AbstractPersistenceObject = DoLoad(key, rs, Documento)
            Cache.AddToCache(obj)
            Return obj
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
#End Region


#Region "Metodi per la preparazione dei comandi"

    Private Function PrepareCommandForPagamentoReferente(ByVal Pagamento As PagamentoReferenti) As IDbCommand

        'Dim cmd As SqlClient1.SqlCommand = GetCommand(FindItemsByPagamentoReferentiStatement)
        Dim cmd As IDbCommand = DBTypeUtils.GetCommand(Me.m_PersistentService.ServiceName, FindItemsByPagamentoReferentiStatement, m_PersistentService.CurrentConnection)
        LoadSimpleFindParameter(cmd, Pagamento)
        Return cmd

    End Function
    Private Function PrepareCommandForItemsWithPagamentoReferente(ByVal Pagamento As PagamentoReferenti) As IDbCommand

        'Dim cmd As IDbCommand = GetCommand(FindItemsRistornateByPagamentoReferentiStatement)
        Dim cmd As IDbCommand = DBTypeUtils.GetCommand(Me.m_PersistentService.ServiceName, FindItemsRistornateByPagamentoReferentiStatement, m_PersistentService.CurrentConnection)
        LoadSimpleFindParameter(cmd, Pagamento)
        Return cmd

    End Function
    'Private Function PrepareCommandForItemsNotPaidToReferente(ByVal Referente As Referente) As IDbCommand
    '   Try
    '      Dim cmd As SqlClient1.SqlCommand = GetCommand(FindItemsIQANotPaidToReferentiStatement)
    '      LoadFindParameter(cmd, Referente)
    '      Return cmd
    '   Catch ex As Exception
    '      Throw New Exception(ex.Message)
    '   End Try
    'End Function
    Private Function PrepareCommandForIncasso(ByVal Incasso As IncassoQuotaAssociativa) As IDbCommand
        Try
            'Dim cmd As SqlClient1.SqlCommand = GetCommand(FindItemsByIncassoStatement)
            Dim cmd As IDbCommand = DBTypeUtils.GetCommand(Me.m_PersistentService.ServiceName, FindItemsByIncassoStatement, m_PersistentService.CurrentConnection)
            LoadSimpleFindParameter(cmd, Incasso)
            Return cmd
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Private Function PrepareCommandForConto(ByVal Conto As Conto) As IDbCommand

        'Dim cmd As SqlClient1.SqlCommand = GetCommand(FindItemsByContoStatement)
        Dim cmd As IDbCommand = DBTypeUtils.GetCommand(Me.m_PersistentService.ServiceName, FindItemsByContoStatement, m_PersistentService.CurrentConnection)
        LoadSimpleFindParameter(cmd, Conto)
        Return cmd

    End Function
    'Protected Overrides Function GetCommand(ByVal CommandText As String) As System.Data.IDbCommand

    '    'Return New SqlClient1.SqlCommand(CommandText, DBConnectionManager.Instance.GetCurrentConnection)
    '    Return DBTypeUtils.GetCommand(Me.m_PersistentService.ServiceName, CommandText, DBConnectionManager.Instance.GetCurrentConnection)
    'End Function
#End Region

    Protected Overloads Function LoadAll(ByVal rs As ArrayList, ByVal Documento As DocumentoContabile) As ArrayList
        Dim List As New ArrayList
        Try
            For Each elem As Hashtable In rs
                List.Add(Load(elem, Documento))
            Next
            Return List
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
    Protected Overloads Overrides Function LoadAll(ByVal rs As ArrayList) As ArrayList
        Dim List As New ArrayList
        Dim TipoDoc As String = ""
        Dim mapper As Object
        Try
            'qui devo per prima cosa capire che tipo di documento sto creando
            'recuperare il documento e quindi caricare le posizioni

            For Each elem As Hashtable In rs
                TipoDoc = IIf(elem.Item("TIPO_DOCUMENTO_CONTABILE") Is Nothing, "", elem.Item("TIPO_DOCUMENTO_CONTABILE"))
                Select Case TipoDoc
                    Case "IQA"
                        mapper = PersistenceMapperRegistry.Instance.GetMapperByName("MapperIncassoQuotaAssociativa")
                    Case "IQP"
                        mapper = PersistenceMapperRegistry.Instance.GetMapperByName("MapperIncassoQuotaPrevisionale")
                    Case "PGR"
                        mapper = PersistenceMapperRegistry.Instance.GetMapperByName("MapperPagamentoReferenti")
                    Case "IQI"
                        mapper = PersistenceMapperRegistry.Instance.GetMapperByName("MapperIncassoQuotaInps")
                    Case "IQV"
                        mapper = PersistenceMapperRegistry.Instance.GetMapperByName("MapperIncassoQuotaVertenza")
                    Case Else
                        Throw New Exception("Tipo documento sconosciuto.")
                End Select
                Dim documento As DocumentoContabile = mapper.FindObjectById(elem.Item("ID_DOCUMENTO_CONTABILE"))
                List.Add(Load(elem, documento))
            Next
            Return List
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function







#Region "Metodi per la ricerca"
    Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject
        Throw New Exception("Impossibile utilizzare il metodo di ricerca secondo l'identificati specificato per una posizione di pagamento. Metodo non implementato.")
    End Function
    Protected Overrides Function CreateKey(ByVal rs As System.Collections.Hashtable) As Key
        Try
            Return New Key(rs("ID"), rs("ID_DOCUMENTO_CONTABILE"))
        Catch ex As Exception
            Throw New Exception("Impossibile creare una chiave per l'oggetto posizione pagamento. " & vbCrLf & ex.Message)
        End Try
    End Function
#End Region



#Region "Metodi pubblici di ricerche di vario tipo"

    Public Function FindItemsByIncasso(ByVal Incasso As IncassoQuotaAssociativa) As IList
        Dim rs As IDataReader = Nothing
        Dim Datalist As IList
        Dim lista As IList
        Try
            If m_PersistentService.CurrentConnection.State = ConnectionState.Open Then m_PersistentService.CurrentConnection.Close()
            m_PersistentService.CurrentConnection.Open()
            Dim cmd As IDbCommand = PrepareCommandForIncasso(Incasso)
            Dim ticks As Int32 = Environment.TickCount
            rs = cmd.ExecuteReader
            System.Diagnostics.Debug.WriteLine("Numero millisecondi esecuzione query " & (Environment.TickCount - ticks).ToString)

            ticks = Environment.TickCount
            Datalist = Me.LoadDataMatrix(rs)
            System.Diagnostics.Debug.WriteLine("Numero millisecondi caricamento datamatrix " & (Environment.TickCount - ticks).ToString)

            rs.Close()

            ticks = Environment.TickCount
            lista = LoadAll(Datalist, Incasso)
            System.Diagnostics.Debug.WriteLine("Numero millisecondi caricamento lista " & (Environment.TickCount - ticks).ToString)


            m_PersistentService.CurrentConnection.Close()
            Return lista
            'rs = cmd.ExecuteReader
            'Datalist = Me.LoadDataMatrix(rs)
            'rs.Close()
            'lista = LoadAll(Datalist, Incasso)
            'DBConnectionManager.Instance.GetCurrentConnection.Close()
            'Return lista
        Catch ex As Exception
            Throw New ApplicationException("Impossibile caricare la lista di tutti gli oggetti posizione per il documento specificato. " & vbCrLf & ex.Message)
        Finally
            ReleaseDBDatareader(rs)
            Datalist = New ArrayList
            If m_PersistentService.CurrentConnection.State = ConnectionState.Open Then m_PersistentService.CurrentConnection.Close()
        End Try
    End Function
    Public Function FindItemsByConto(ByVal Conto As Conto) As IList
        Dim rs As IDataReader = Nothing
        Dim Datalist As IList
        Dim lista As IList
        Try
            If m_PersistentService.CurrentConnection.State = ConnectionState.Open Then m_PersistentService.CurrentConnection.Close()
            m_PersistentService.CurrentConnection.Open()
            Dim cmd As IDbCommand = PrepareCommandForConto(Conto)
            rs = cmd.ExecuteReader
            Datalist = Me.LoadDataMatrix(rs)
            rs.Close()
            lista = LoadAll(Datalist)
            m_PersistentService.CurrentConnection.Close()
            Return lista
        Catch ex As Exception
            Throw New ApplicationException("Impossibile caricare la lista di tutti gli oggetti posizione per il conto specificato. " & vbCrLf & ex.Message)
        Finally
            ReleaseDBDatareader(rs)
            Datalist = New ArrayList
            If m_PersistentService.CurrentConnection.State = ConnectionState.Open Then m_PersistentService.CurrentConnection.Close()
        End Try
    End Function
    Public Function FindItemsByPagamentoReferente(ByVal Pagamento As PagamentoReferenti) As IList
        Dim rs As IDataReader = Nothing
        Dim Datalist As IList
        Dim lista As IList
        Try
            If m_PersistentService.CurrentConnection.State = ConnectionState.Open Then m_PersistentService.CurrentConnection.Close()
            m_PersistentService.CurrentConnection.Open()
            Dim cmd As IDbCommand = Me.PrepareCommandForPagamentoReferente(Pagamento)
            rs = cmd.ExecuteReader
            Datalist = Me.LoadDataMatrix(rs)
            rs.Close()
            lista = LoadAll(Datalist, Pagamento)
            m_PersistentService.CurrentConnection.Close()
            Return lista
        Catch ex As Exception
            Throw New ApplicationException("Impossibile caricare la lista di tutti gli oggetti posizione per il documento specificato. " & vbCrLf & ex.Message)
        Finally
            ReleaseDBDatareader(rs)
            Datalist = New ArrayList
            If m_PersistentService.CurrentConnection.State = ConnectionState.Open Then m_PersistentService.CurrentConnection.Close()
        End Try
    End Function



    Public Function FindItemsRistornateByPagamentoReferente(ByVal Pagamento As PagamentoReferenti) As IList
        Dim rs As IDataReader = Nothing
        Dim Datalist As IList
        Dim lista As IList = New ArrayList
        Dim ConnOpened As Boolean = False
        Try
            If m_PersistentService.CurrentConnection.State = ConnectionState.Closed Then
                m_PersistentService.CurrentConnection.Open()
                ConnOpened = True
            End If
            Dim cmd As IDbCommand = Me.PrepareCommandForItemsWithPagamentoReferente(Pagamento)
            rs = cmd.ExecuteReader
            Datalist = Me.LoadDataMatrix(rs)
            rs.Close()
            lista = LoadAll(Datalist)
            If ConnOpened = True Then
                m_PersistentService.CurrentConnection.Close()
            End If
            Return lista
        Catch ex As Exception
            Throw New ApplicationException("Impossibile caricare la lista di tutti gli oggetti posizione per il documento specificato. " & vbCrLf & ex.Message)
        Finally
            ReleaseDBDatareader(rs)
            Datalist = New ArrayList
            'If DBConnectionManager.Instance.GetCurrentConnection.State = ConnectionState.Open Then DBConnectionManager.Instance.GetCurrentConnection.Close()
        End Try
    End Function
    'Public Function FindItemsIQANotPaidToReferente(ByVal Referente As Referente) As IList
    '   Dim rs As IDataReader = Nothing
    '   Dim Datalist As IList
    '   Dim lista As IList = New ArrayList
    '   Try
    '      If DBConnectionManager.Instance.GetCurrentConnection.State = ConnectionState.Open Then DBConnectionManager.Instance.GetCurrentConnection.Close()
    '      DBConnectionManager.Instance.GetCurrentConnection.Open()
    'Dim cmd As SqlClient1.SqlCommand = Me.PrepareCommandForItemsNotPaidToReferente(Referente)
    '      rs = cmd.ExecuteReader
    '      Datalist = Me.LoadDataMatrix(rs)
    '      rs.Close()
    '      'For Each elem As Hashtable In Datalist
    '      '   Dim Mapper As MapperIncassoQuotaAssociativa = PersistenceMapperRegistry.Instance.GetMapperByName("MapperIncassoQuotaAssociativa")
    '      '   Dim Incasso As IncassoQuotaAssociativa = IIf(elem.Item("ID_DOCUMENTO_CONTABILE") > -1, Mapper.FindObjectById(elem.Item("ID_DOCUMENTO_CONTABILE")), New DocumentoNullo)
    '      '   lista.Add(Load(elem, Incasso))
    '      'Next
    '      lista = LoadAll(Datalist)
    '      DBConnectionManager.Instance.GetCurrentConnection.Close()
    '      Return lista
    '   Catch ex As Exception
    '      Throw New ApplicationException("Impossibile caricare la lista di tutti gli oggetti posizione per il documento specificato. " & vbCrLf & ex.Message)
    '   Finally
    '      ReleaseDBDatareader(rs)
    '      Datalist = New ArrayList
    '      If DBConnectionManager.Instance.GetCurrentConnection.State = ConnectionState.Open Then DBConnectionManager.Instance.GetCurrentConnection.Close()
    '   End Try
    'End Function
#End Region


#Region "Metodi per il caricamento dei parametri per i comandi"


    Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
        Try
            Dim DocumentoItem As ItemContabile = DirectCast(Item, ItemContabile)

            Dim param As IDbDataParameter = Cmd.CreateParameter
            param.ParameterName = "@Drg"
            param.Value = DocumentoItem.DataRegistrazione.Date
            Cmd.Parameters.Add(param)


            param = Cmd.CreateParameter
            param.ParameterName = "@Ddc"
            param.Value = DocumentoItem.DataDocumento.Date
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@Not"
            If DocumentoItem.Note Is Nothing Then
                param.Value = ""
            Else
                param.Value = DocumentoItem.Note
            End If
            Cmd.Parameters.Add(param)


            param = Cmd.CreateParameter
            param.ParameterName = "@Tdc"
            param.Value = DocumentoItem.TipoDocumento
            Cmd.Parameters.Add(param)



            param = Cmd.CreateParameter
            param.ParameterName = "@Di"
            If Not TypeOf (DocumentoItem.Competenza) Is PeriodoNullo Then
                param.Value = DocumentoItem.Competenza.GetDataRange.Start
            Else
                param.Value = DBNull.Value
            End If
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@Df"
            If Not TypeOf (DocumentoItem.Competenza) Is PeriodoNullo Then
                param.Value = DocumentoItem.Competenza.GetDataRange.Finish
            Else
                param.Value = DBNull.Value
            End If
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@Imp"
            param.Value = DocumentoItem.Importo.Importo
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@Val"
            param.Value = DocumentoItem.Importo.GetValuta
            Cmd.Parameters.Add(param)


            param = Cmd.CreateParameter
            param.ParameterName = "@Az"
            If DocumentoItem.SoggettoEsecutore Is Nothing Then
                param.Value = DBNull.Value
            Else
                If Not TypeOf (DocumentoItem.SoggettoEsecutore) Is AziendaNonSpecificata Then
                    param.Value = DocumentoItem.SoggettoEsecutore.Key.LongValue
                Else
                    param.Value = DBNull.Value
                End If
            End If
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@Tr"
            param.Value = DocumentoItem.Tredicesima
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@Qu"
            param.Value = DocumentoItem.Quattordicesima
            Cmd.Parameters.Add(param)


            param = Cmd.CreateParameter
            param.ParameterName = "@Ref"
            If DocumentoItem.Referente Is Nothing Then
                param.Value = DBNull.Value
            Else
                If TypeOf (DocumentoItem.Referente) Is ReferenteNullo Then
                    param.Value = DBNull.Value
                Else
                    param.Value = DocumentoItem.Referente.IdReferente
                End If

            End If
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@Ut"
            If DocumentoItem.Utente Is Nothing Then
                param.Value = DBNull.Value
            Else
                If Not TypeOf (DocumentoItem.Utente) Is UtenteNonSpecificato Then
                    param.Value = DocumentoItem.Utente.IdUtente
                Else
                    param.Value = DBNull.Value
                End If
            End If
            Cmd.Parameters.Add(param)


            param = Cmd.CreateParameter
            param.ParameterName = "@Con"
            param.Value = DocumentoItem.Conto.IdConto
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@Idpr"
            If TypeOf (DocumentoItem.PagamentoReferente) Is DocumentoNullo Then
                param.Value = DBNull.Value
            Else
                param.Value = DocumentoItem.PagamentoReferente.Id
            End If
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@Iri"
            param.Value = DocumentoItem.ImportoRistorno.Importo
            Cmd.Parameters.Add(param)


            param = Cmd.CreateParameter
            param.ParameterName = "@IdAi"
            If DocumentoItem.AziendaImpiego.Id = -1 Then
                param.Value = DBNull.Value
            Else
                param.Value = DocumentoItem.AziendaImpiego.Id
            End If
            Cmd.Parameters.Add(param)


            param = Cmd.CreateParameter
            param.ParameterName = "@IdS"
            'If DocumentoItem.ContrattoApplicato.Descrizione = "" Then
            '   param.Value = DBNull.Value
            'Else
            '   param.Value = DocumentoItem.ContrattoApplicato.SettoreSpecifico.Id
            'End If
            If DocumentoItem.Settore.Id = -1 Then
                param.Value = DBNull.Value
            Else
                param.Value = DocumentoItem.Settore.Id
            End If
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@IdT"
            If DocumentoItem.ContrattoApplicato.Descrizione = "" Then
                param.Value = DBNull.Value
            Else
                param.Value = DocumentoItem.ContrattoApplicato.Id
            End If
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@Liv"
            If DocumentoItem.LivelloInquadramento Is Nothing Then
                param.Value = ""
            Else
                param.Value = DocumentoItem.LivelloInquadramento
            End If
            Cmd.Parameters.Add(param)


            param = Cmd.CreateParameter
            param.ParameterName = "@Ol"
            param.Value = DocumentoItem.OreLavorate
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@Om"
            param.Value = DocumentoItem.OreMalattia
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@Pre"
            If DocumentoItem.Prestazione.GetId = -1 Then
                param.Value = DBNull.Value
            Else
                param.Value = DocumentoItem.Prestazione.GetId
            End If
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@Idve"
            If DocumentoItem.Vertenza.GetId = -1 Then
                param.Value = DBNull.Value
            Else
                param.Value = DocumentoItem.Vertenza.GetId
            End If
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@Sed"
            If DocumentoItem.SedeOperativaAzienda.Descrizione = "" Then
                param.Value = DBNull.Value
            Else
                param.Value = DocumentoItem.SedeOperativaAzienda.Descrizione
            End If
            Cmd.Parameters.Add(param)

        Catch ex As Exception
            Throw New Exception("Impossibile caricare il comando di inserimento dell'oggetto item documento." & vbCrLf & ex.Message)
        End Try
    End Sub
    Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
        Try
            Dim DocumentoItem As ItemContabile = DirectCast(Item, ItemContabile)

            Dim param As IDbDataParameter = Cmd.CreateParameter
            param.ParameterName = "@Drg"
            param.Value = DocumentoItem.DataRegistrazione.Date
            Cmd.Parameters.Add(param)


            param = Cmd.CreateParameter
            param.ParameterName = "@Ddc"
            param.Value = DocumentoItem.DataDocumento.Date
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@Not"
            If DocumentoItem.Note Is Nothing Then
                param.Value = ""
            Else
                param.Value = DocumentoItem.Note
            End If
            Cmd.Parameters.Add(param)


            param = Cmd.CreateParameter
            param.ParameterName = "@Tdc"
            param.Value = DocumentoItem.TipoDocumento
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@Di"
            If Not TypeOf (DocumentoItem.Competenza) Is PeriodoNullo Then
                param.Value = DocumentoItem.Competenza.GetDataRange.Start
            Else
                param.Value = DBNull.Value
            End If
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@Df"
            If Not TypeOf (DocumentoItem.Competenza) Is PeriodoNullo Then
                param.Value = DocumentoItem.Competenza.GetDataRange.Finish
            Else
                param.Value = DBNull.Value
            End If
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@Imp"
            param.Value = DocumentoItem.Importo.Importo
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@Val"
            param.Value = DocumentoItem.Importo.GetValuta
            Cmd.Parameters.Add(param)


            param = Cmd.CreateParameter
            param.ParameterName = "@Az"
            If DocumentoItem.SoggettoEsecutore Is Nothing Then
                param.Value = DBNull.Value
            Else
                If Not TypeOf (DocumentoItem.SoggettoEsecutore) Is AziendaNonSpecificata Then
                    param.Value = DocumentoItem.SoggettoEsecutore.Key.LongValue
                Else
                    param.Value = DBNull.Value
                End If
            End If
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@Tr"
            param.Value = DocumentoItem.Tredicesima
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@Qu"
            param.Value = DocumentoItem.Quattordicesima
            Cmd.Parameters.Add(param)


            param = Cmd.CreateParameter
            param.ParameterName = "@Ref"
            If DocumentoItem.Referente Is Nothing Then
                param.Value = DBNull.Value
            Else
                If TypeOf (DocumentoItem.Referente) Is ReferenteNullo Then
                    param.Value = DBNull.Value
                Else
                    param.Value = DocumentoItem.Referente.IdReferente
                End If

            End If
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@Ut"
            If DocumentoItem.Utente Is Nothing Then
                param.Value = DBNull.Value
            Else
                If Not TypeOf (DocumentoItem.Utente) Is UtenteNonSpecificato Then
                    param.Value = DocumentoItem.Utente.IdUtente
                Else
                    param.Value = DBNull.Value
                End If
            End If
            Cmd.Parameters.Add(param)


            param = Cmd.CreateParameter
            param.ParameterName = "@Con"
            param.Value = DocumentoItem.Conto.IdConto
            Cmd.Parameters.Add(param)




            param = Cmd.CreateParameter
            param.ParameterName = "@Idpr"
            If TypeOf (DocumentoItem.PagamentoReferente) Is DocumentoNullo Then
                param.Value = DBNull.Value
            Else
                param.Value = DocumentoItem.PagamentoReferente.Id
            End If
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@Iri"
            param.Value = DocumentoItem.ImportoRistorno.Importo
            Cmd.Parameters.Add(param)







            param = Cmd.CreateParameter
            param.ParameterName = "@IdAi"
            If DocumentoItem.AziendaImpiego.Id = -1 Then
                param.Value = DBNull.Value
            Else
                param.Value = DocumentoItem.AziendaImpiego.Id
            End If
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@IdS"
            'If DocumentoItem.ContrattoApplicato.Descrizione = "" Then
            '   param.Value = DBNull.Value
            'Else
            '   param.Value = DocumentoItem.ContrattoApplicato.SettoreSpecifico.Id
            'End If
            If DocumentoItem.Settore.Id = -1 Then
                param.Value = DBNull.Value
            Else
                param.Value = DocumentoItem.Settore.Id
            End If
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@IdT"
            If DocumentoItem.ContrattoApplicato.Descrizione = "" Then
                param.Value = DBNull.Value
            Else
                param.Value = DocumentoItem.ContrattoApplicato.Id
            End If
            Cmd.Parameters.Add(param)


            param = Cmd.CreateParameter
            param.ParameterName = "@Liv"
            If DocumentoItem.LivelloInquadramento Is Nothing Then
                param.Value = ""
            Else
                param.Value = DocumentoItem.LivelloInquadramento
            End If
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@Ol"
            param.Value = DocumentoItem.OreLavorate
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@Om"
            param.Value = DocumentoItem.OreMalattia
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@Pre"
            If DocumentoItem.Prestazione.GetId = -1 Then
                param.Value = DBNull.Value
            Else
                param.Value = DocumentoItem.Prestazione.GetId
            End If
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@Idve"
            If DocumentoItem.Vertenza.GetId = -1 Then
                param.Value = DBNull.Value
            Else
                param.Value = DocumentoItem.Vertenza.GetId
            End If
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@Sed"
            If DocumentoItem.SedeOperativaAzienda.Descrizione = "" Then
                param.Value = DBNull.Value
            Else
                param.Value = DocumentoItem.SedeOperativaAzienda.Descrizione
            End If
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@Id"
            param.Value = DocumentoItem.Key.Value(0)
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@IdP"
            param.Value = DocumentoItem.Key.Value(1)
            Cmd.Parameters.Add(param)

        Catch ex As Exception
            Throw New Exception("Impossibile caricare il comando di aggiornamento dell'oggetto item documento." & vbCrLf & ex.Message)
        End Try
    End Sub

#End Region

#Region "Metodi per l'inserimento"
    Public Overrides Function Insert(ByVal item As AbstractPersistenceObject) As Key

        If item.IsValid Then
            Dim IdDocumento As Int32
            'Assumo che l'id del pagamento sara il 
            'secondo valore nella lista delle chiavi identificative
            'e l'id della posizione sarà il primo
            Try
                IdDocumento = DirectCast(item, ItemContabile).DocumentoPadre.Id
            Catch ex As Exception
                Throw New Exception("Non è stata trovata una chiave per l'incasso di appartenenza.")
            End Try
            Return PerformInsert(item, FindNextKey(IdDocumento))
        Else
            Dim errors As String = ""
            For Each elem As String In item.ValidationErrors
                errors = errors & elem & vbCrLf
            Next
            Throw New Exception("L'oggetto inserito non è valido. Controllare il valore dei valori immessi" & vbCrLf & errors)
        End If

    End Function

    Protected Overloads Function FindNextKey(ByVal IdDocumento As Int32) As Key
        Dim rs As IDataReader = Nothing
        Dim cmd As IDbCommand
        Try
            'qui devo leggere l'oggetto in un datareader e caricarlo
            cmd = Me.GetCommand(Me.FindNextKeyStatement)

            Dim Param As IDataParameter = cmd.CreateParameter
            Param.ParameterName = "@IdP"
            Param.Value = IdDocumento
            cmd.Parameters.Add(Param)

            rs = cmd.ExecuteReader
            rs.Read()
            'Assumo che l'id del pagamento sara il 
            'secondo valore nella lista delle chiavi identificative
            'e l'id della posizione sarà il primo
            If IsDBNull(rs(0)) Then
                rs.Close()
                Dim Newkey As Key = New Key(1, IdDocumento)
                Return Newkey
            Else
                Dim Id As Int32 = rs(0) + 1
                rs.Close()
                Dim Updatedkey As Key = New Key(Id, IdDocumento)
                Return Updatedkey
            End If
        Catch ex As Exception
            Throw New Exception("Impossibile trovare una nuova chiave identificativa per l'oggetto. " & vbCrLf & ex.Message)
        Finally
            ReleaseDBDatareader(rs)
        End Try
    End Function
    Private Sub LoadSimpleFindParameter(ByVal cmd As IDbCommand, ByVal Obj As AbstractPersistenceObject)
        Try
            Dim param As IDataParameter = cmd.CreateParameter
            param.ParameterName = "@IdP"
            param.Value = Obj.Key.LongValue
            cmd.Parameters.Add(param)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Private Sub LoadFindParameter(ByVal cmd As IDbCommand, ByVal Obj As AbstractPersistenceObject)
        Try
            Dim param As IDataParameter = cmd.CreateParameter
            param.ParameterName = "@IdP"
            param.Value = Obj.Key.LongValue
            cmd.Parameters.Add(param)
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
    Protected Overrides Sub LoadInsertCommandKeyParameter(ByVal Item As AbstractPersistenceObject, ByVal Cmd As IDbCommand)
        Try
            Dim param As IDbDataParameter = Cmd.CreateParameter
            param.ParameterName = "@Id"
            param.Value = Item.Key.Value(0)
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@IdP"
            param.Value = Item.Key.Value(1)
            Cmd.Parameters.Add(param)
        Catch ex As Exception
            Throw New Exception("Impossibile creare un parametro per la chiave identificativa nel comando per l'inserimento di un oggetto" & vbCrLf & ex.Message)
        End Try
    End Sub
    Protected Overrides Sub LoadDeleteCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As IDbCommand)
        Try
            Dim param As IDbDataParameter = Cmd.CreateParameter
            param.ParameterName = "@Id"
            param.Value = Item.Key.Value(0)
            Cmd.Parameters.Add(param)

            param = Cmd.CreateParameter
            param.ParameterName = "@IdP"
            param.Value = Item.Key.Value(1)
            Cmd.Parameters.Add(param)
        Catch ex As Exception
            Throw New Exception("Impossibile creare un parametro per la chiave identificativa nel comando per l'eliminazione di un oggetto" & vbCrLf & ex.Message)
        End Try
    End Sub
#End Region



End Class
