Namespace ADMINISTRATION
   Public Class ControllerDeleghe
      Inherits AbstractController
      Private ControllerReferenti As New FINANCIAL_ARTIFACTS.ControllerReferenti
      Private ControllerUtenti As New UTENTI.ControllerUtenti
      Private ControllerAziende As New AZIENDE.ControllerAziende
      Private ControllerSettori As New ControllerSettori
      Private controllerEnteBil As New AZIENDE.ControllerEntiBilaterali
      Private controllerCausali As New ControllerCausaliRevoca
      Private controllerCausaliSott As New ControllerCausaliSottoscrizione
      Private controllerReparti As New ControllerReparti


      Private Function Current() As Delega
         Return DirectCast(MyBase.m_current, Delega)
      End Function
#Region "Proprietà oggetto"
      ''' <summary>
      ''' Proprietà valida solo per le aziende. Non per gli enti bilaterali
      ''' </summary>
      ''' <param name="ForAziendaWithId"></param>
      ''' <value></value>
      ''' <returns></returns>
      ''' <remarks></remarks>
      Public ReadOnly Property ListaSediOperative(ByVal ForAziendaWithId As String) As IList
         Get
            ControllerAziende.LoadById(ForAziendaWithId)
            Return ControllerAziende.GetListaNomiSediOperative
         End Get
      End Property


      Public Property DataImportazione() As DateTime
         Get
            Return Current.DataImportazione
         End Get
         Set(ByVal value As DateTime)
            Current.DataImportazione = value
         End Set
      End Property

      Public ReadOnly Property IdUtente() As Int32
         Get
            Return Current.Utente.Key.LongValue
         End Get
      End Property
      Public ReadOnly Property IdReferente() As String
         Get
            If Current.Referente.Key.LongValue = -1 Then Return ""
            Return Current.Referente.Key.LongValue
         End Get
      End Property
      Public ReadOnly Property IdResponsabile() As String
         Get
            If Current.Responsabile.Key.LongValue = -1 Then Return ""
            Return Current.Responsabile.Key.LongValue
         End Get
      End Property
      Public ReadOnly Property IdPagamento() As String
         Get
            If Current.PagamentoAttivazione.GetId = -1 Then Return ""
            Return Current.PagamentoAttivazione.GetId
         End Get
      End Property
      Public ReadOnly Property IdSettore() As Int32
         Get
            Return Current.Settore.Id
         End Get
      End Property
      Public ReadOnly Property DescrizioneSettore() As String
         Get
            Return Current.Settore.Descrizione
         End Get
      End Property
      Public ReadOnly Property IsSettoreEdile() As Boolean
         Get
            If Current.Settore.TipologiaSettore = Settore.TipoSettore.Edili Then Return True
            Return False
         End Get
      End Property
      Public Sub SetSettore(ByVal IdSettore As String)
         Try
            If Not IsNumeric(IdSettore) Then Throw New Exception("Il valore dell'id del settore immesso non ha un formato corretto. Inserire un id valido")
            Current.Settore = ControllerSettori.GetSettoreById(IdSettore)
         Catch ex As Exception
            Throw New Exception(ex.Message)
         End Try
      End Sub
      Public ReadOnly Property IsPeriodoValiditaEmpty() As Boolean
         Get
            Return Current.GetPeriodoValidita.IsEmpty
         End Get
      End Property
      Public ReadOnly Property PeriodoValidita() As String
         Get
            Return Current.GetPeriodoValidita.ToString
         End Get
      End Property
      Public Sub SetReferente(ByVal IdReferente As String)
         Try
            If IdReferente = "" Then IdReferente = -1
            If Not IsNumeric(IdReferente) Then Throw New Exception("Il valore dell'id del referente immesso non ha un formato corretto. Inserire un id valido")
            Current.Referente = ControllerReferenti.GetReferenteById(IdReferente)
         Catch ex As Exception
            Throw New Exception(ex.Message)
         End Try
      End Sub
      Public Sub SetResponsabile(ByVal IdResponsabile As String)
         Try
            If IdResponsabile = "" Then IdResponsabile = -1
            If Not IsNumeric(IdResponsabile) Then Throw New Exception("Il valore dell'id del responsabile delega immesso non ha un formato corretto. Inserire un id valido")
            Current.Responsabile = ControllerReferenti.GetReferenteById(IdResponsabile)
         Catch ex As Exception
            Throw New Exception(ex.Message)
         End Try
      End Sub
      Public ReadOnly Property IdEnteInoltro() As Int32
         Get
            Return Current.EnteInoltro.Key.LongValue
         End Get
      End Property
      Public ReadOnly Property DescrizioneSedeOprativa() As String
         Get
            Return Current.SedeOperativa.Descrizione
         End Get
      End Property
      Public ReadOnly Property DelegaAnnullamentoIsNull() As Boolean
         Get
            If TypeOf (Current.DelegaDiAnnullamento) Is DelegaNulla Then Return True
            Return False
         End Get
      End Property
      ''' <summary>
      ''' Metodo che imposta l'ente di inoltro per la delega. 
      ''' </summary>
      ''' <param name="Value"></param>
      ''' <remarks></remarks>
      Public Sub SetAziendaInoltro(ByVal Value As Int32)
         Try
            If Not IsNumeric(Value) Then Throw New Exception("Il valore dell'id dell'azienda d'inoltro immesso non ha un formato corretto. Inserire un id valido")
            'Current.EnteInoltro2 = New AziendaNonSpecificata
            Current.EnteInoltro = ControllerAziende.GetAziendaById(Value)
         Catch ex As Exception
            Throw New Exception(ex.Message)
         End Try
      End Sub
      ''' <summary>
      ''' Metodo che imposta la sede operativa per la delega. E' necessario 
      ''' aver inserito prima l'ente di inoltro 
      ''' poichè le sedi operative vengono verificate traquelle
      ''' apparteneti all'ente di inoltro. Il metodo vale solo se 
      ''' la delega appartiene al settore degli impianti fissi.
      ''' </summary>
      ''' <param name="Descrizione"></param>
      ''' <remarks></remarks>
      Public Sub SetSedeOperativa(ByVal Descrizione As String)
         If Current.Settore.TipologiaSettore <> Settore.TipoSettore.ImpiantiFissi Then
            Throw New InvalidOperationException("Impossibile impostare una sede operativa. Settore non corrispondente")
         End If
         Dim sede As SedeOperativa = DirectCast(Current.EnteInoltro, Azienda).GetSedeOperativaByDescrizione(Descrizione)
         If sede IsNot Nothing Then
            Current.SedeOperativa = sede
         Else
            Current.SedeOperativa = New SedeOperativaNulla
         End If
      End Sub
      'Public Sub SetAziendaAccettante(ByVal Value As Int32, Optional ByVal AccettataDaEntrabiEntiBilaterali As Boolean = False)
      '   Try
      '      If Not IsNumeric(Value) Then Throw New Exception("Il valore dell'id dell'azienda d'inoltro immesso non ha un formato corretto. Inserire un id valido")
      '      Current.EnteAccettante2 = New AziendaNonSpecificata
      '      Current.EnteAccettante1 = ControllerAziende.GetAziendaById(Value)
      '   Catch ex As Exception
      '      Throw New Exception(ex.Message)
      '   End Try
      'End Sub
      Public ReadOnly Property DescrizioneCausaleFineCiclo() As String
         Get
            Return Current.CausaleFineCiclo.Descrizione
         End Get
      End Property
      Public Sub SetCausaleFineCiclo(ByVal IdCausale As String)
         Try
            If Not IsNumeric(IdCausale) Then Throw New Exception("Il valore dell'id della causakle revoca immesso non ha un formato corretto. Inserire un id valido")
            Dim causale As CausaleRevocaDelega = controllerCausali.GetCausaleById(IdCausale)
            If causale Is Nothing Then causale = New CausaleNulla
            Current.CausaleFineCiclo = causale
         Catch ex As Exception
            Throw New Exception(ex.Message)
         End Try
      End Sub
      'Public Sub SetEnteBilateraleAccettante(ByVal Value As Int32, Optional ByVal AccettataDaEntrabiEntiBilaterali As Boolean = False)
      '   Try
      '      If AccettataDaEntrabiEntiBilaterali Then
      '         Current.EnteAccettante1 = controllerEnteBil.GetEdilCassa
      '         Current.EnteAccettante2 = controllerEnteBil.GetCassaEdile
      '         If Current.EnteAccettante2 Is Nothing Then Throw New Exception("Impossibile impostare l'azienda di inoltro. Impossibile trovare la definizione di Cassa Edile")
      '         If Current.EnteAccettante1 Is Nothing Then Throw New Exception("Impossibile impostare l'azienda di inoltro. Impossibile trovare la definizione di EdilCassa ")
      '         If Current.EnteAccettante2.Id = -1 Then Throw New Exception("Impossibile impostare l'azienda di inoltro. Impossibile trovare la definizione di Cassa Edile. Tipo oggetto non specificato.")
      '         If Current.EnteAccettante1.Id = -1 Then Throw New Exception("Impossibile impostare l'azienda di inoltro. Impossibile trovare la definizione di EdilCassa. Tipo oggetto non specificato.")
      '      Else
      '         If Not IsNumeric(Value) Then Throw New Exception("Il valore dell'id dell'ente d'inoltro immesso non ha un formato corretto. Inserire un id valido")
      '         Current.EnteAccettante2 = New AziendaNonSpecificata
      '         Current.EnteAccettante1 = controllerEnteBil.GetEnteById(Value)
      '      End If

      '   Catch ex As Exception
      '      Throw New Exception(ex.Message)
      '   End Try
      'End Sub
      Public Sub SetEnteBiletraleInoltro(ByVal Value As Int32)
         'If InoltrataAdEntrabiEntiBilaterali Then
         '   Current.EnteInoltro = controllerEnteBil.GetEdilCassa
         '   Current.EnteInoltro2 = controllerEnteBil.GetCassaEdile
         '   If Current.EnteInoltro2 Is Nothing Then Throw New Exception("Impossibile impostare l'azienda di inoltro. Impossibile trovare la definizione di Cassa Edile")
         '   If Current.EnteInoltro Is Nothing Then Throw New Exception("Impossibile impostare l'azienda di inoltro. Impossibile trovare la definizione di EdilCassa ")
         '   If Current.EnteInoltro2.Id = -1 Then Throw New Exception("Impossibile impostare l'azienda di inoltro. Impossibile trovare la definizione di Cassa Edile. Tipo oggetto non specificato.")
         '   If Current.EnteInoltro.Id = -1 Then Throw New Exception("Impossibile impostare l'azienda di inoltro. Impossibile trovare la definizione di EdilCassa. Tipo oggetto non specificato.")
         'Else
         '   If Not IsNumeric(Value) Then Throw New Exception("Il valore dell'id dell'azienda d'inoltro immesso non ha un formato corretto. Inserire un id valido")
         '   Current.EnteInoltro2 = New AziendaNonSpecificata
         '   Current.EnteInoltro = controllerEnteBil.GetEnteById(Value)
         'End If
         If Not IsNumeric(Value) Then Throw New Exception("Il valore dell'id dell'azienda d'inoltro immesso non ha un formato corretto. Inserire un id valido")
         Current.EnteInoltro = controllerEnteBil.GetEnteById(Value)
      End Sub


      Public Property DataRegistrazione() As DateTime
         Get
            Return Current.DataRegistrazione
         End Get
         Set(ByVal value As DateTime)
            Current.DataRegistrazione = value
         End Set
      End Property
      Public Property DataRevoca() As DateTime
         Get
            Return Current.DataRevocaDelega
         End Get
         Set(ByVal value As DateTime)
            Current.DataRevocaDelega = value
         End Set
      End Property
      Public Property DataAnnullamento() As DateTime
         Get
            Return Current.DataAnnullamentoDelega
         End Get
         Set(ByVal value As DateTime)
            Current.DataAnnullamentoDelega = value
         End Set
      End Property
      Public ReadOnly Property StatoPrecedente() As String
         Get
            Return Current.StatoPrecedente.StatusName
         End Get
      End Property
      Public Property DataDocumento() As DateTime
         Get
            Return Current.DataDocumento
         End Get
         Set(ByVal value As DateTime)
            Current.DataDocumento = value
         End Set
      End Property
      Public Property Note() As String
         Get
            Return Current.Note
         End Get
         Set(ByVal value As String)
            Current.Note = value
         End Set
      End Property
      Public ReadOnly Property CausaleSottoscrizione() As String
         Get
            Return Current.CausaleSottoscrizione.Descrizione
         End Get
      End Property

      Public Sub SetCausaleSottoscrizione(ByVal Idcausale As String)
         Current.CausaleSottoscrizione = controllerCausaliSott.GetCausaleById(Idcausale)
      End Sub
      Public ReadOnly Property Reparto() As String
         Get
            Return Current.Reparto.Descrizione
         End Get
      End Property
      Public Sub SetReparto(ByVal Idreparto As String)
         Current.Reparto = controllerReparti.GetCausaleById(Idreparto)
      End Sub

      Public Sub SetUtente(ByVal IdUtente As Int32)
         Current.Utente = ControllerUtenti.GetUtenteById(IdUtente)
      End Sub

      Public ReadOnly Property IdDelega() As Int32
         Get
            Return Current.Key.LongValue
         End Get
      End Property
      Public Property DataInoltro() As DateTime
         Get
            Return Current.DataInoltro
         End Get
         Set(ByVal value As DateTime)
            Current.DataInoltro = value
         End Set
      End Property
      Public Property DataAccettazione() As DateTime
         Get
            Return Current.DataAccettazioneDelega
         End Get
         Set(ByVal value As DateTime)
            Current.DataAccettazioneDelega = value
         End Set
      End Property
      Public ReadOnly Property DataAttivazione() As DateTime
            Get
                Return Current.DataDecorrenzaDelega
                'If Current.PagamentoAttivazione.GetId = -1 Then Return CDate("01/01/1900")
                'Return Current.PagamentoAttivazione.DataRegistrazione
            End Get
      End Property
      'Public ReadOnly Property IdEnteAccettante() As Int32
      '   Get
      '      Return Current.EnteAccettante1.Key.LongValue
      '   End Get
      'End Property
      Public ReadOnly Property DescrizioneUtente() As String
         Get
            Return Current.Utente.CompleteName
         End Get
      End Property


      Public ReadOnly Property Cellulare1Utente() As String
         Get
            Return Current.Utente.Comunicazione.Cellulare1
         End Get
      End Property

      Public ReadOnly Property Cellulare2Utente() As String
         Get
            Return Current.Utente.Comunicazione.Cellulare2
         End Get
      End Property




      Public ReadOnly Property DescrizioneReferente() As String
         Get
            Return Current.Referente.CompleteName
         End Get
      End Property
      Public ReadOnly Property DescrizioneResponsabile() As String
         Get
            Return Current.Responsabile.CompleteName
         End Get
      End Property
      Public ReadOnly Property DescrizioneEnteInoltro() As String
         Get
            Return Current.EnteInoltro.Descrizione
         End Get
      End Property
      'Public ReadOnly Property DescrizioneEnteInoltro2() As String
      '   Get
      '      Return Current.EnteInoltro2.Descrizione
      '   End Get
      'End Property
      'Public ReadOnly Property DescrizioneEnteAccettante1() As String
      '   Get
      '      Return Current.EnteAccettante1.Descrizione
      '   End Get
      'End Property
      'Public ReadOnly Property DescrizioneEnteAccettante2() As String
      '   Get
      '      Return Current.EnteAccettante2.Descrizione
      '   End Get
      'End Property
      Public ReadOnly Property StatusDelega() As String
         Get
            Return Current.StatoDelega.StatusName
         End Get
      End Property
      'Public ReadOnly Property InoltrataEntrambiEntiBilaterali() As Boolean
      '   Get
      '      Return Current.InoltrataEntrambiEntiBilaterali
      '   End Get
      'End Property
      'Public ReadOnly Property AccettataEntrambiEntiBilaterali() As Boolean
      '   Get
      '      Return Current.AccettataDaEntrambiEntiBilaterali
      '   End Get
      'End Property

#End Region

      Private m_errorMessage As New Text.StringBuilder
      Public ReadOnly Property ErrorMessage() As String
         Get
            Return m_errorMessage.ToString
         End Get
      End Property

      Public Sub InoltraDeleghe(ByVal Data As DateTime, ByVal list As ArrayList)
         m_errorMessage = New Text.StringBuilder()
         For Each elem As DelegadTO In list
            If elem.Selected Then
               EseguiInoltro(Data, Me.GetDelegaById(elem.Id, elem.IdUtente))
            End If
         Next
      End Sub

      Public Sub AccettaDeleghe(ByVal Data As DateTime, ByVal list As ArrayList)
         m_errorMessage = New Text.StringBuilder()
         For Each elem As DelegadTO In list
            If elem.Selected Then
               EseguiAccettazione(Data, Me.GetDelegaById(elem.Id, elem.IdUtente))
            End If
         Next
      End Sub

      Private Sub EseguiAccettazione(ByVal Data As DateTime, ByVal Delega As Delega)
         Try
            m_current = Delega
            InoltraDelega(Data)
            AccettaDelega(Data)
            UpdateAllDeleghe()
         Catch ex As Exception
            m_errorMessage.Append("Errore nell'inoltro della delega " & Delega.IdDelega & " dell utente " & Delega.Utente.ToString & vbCr & ex.Message & vbCrLf)
         End Try
      End Sub


      Private Sub EseguiInoltro(ByVal Data As DateTime, ByVal Delega As Delega)
         Try
            m_current = Delega
            InoltraDelega(Data)
            Save()
         Catch ex As Exception
            m_errorMessage.Append("Errore nell'inoltro della delega " & Delega.IdDelega & " dell utente " & Delega.Utente.ToString & vbCr & ex.Message & vbCrLf)
         End Try
      End Sub



#Region "Metodi di gestione dello stato delle deleghe"
      Public Sub InoltraDelega(ByVal DataInoltro As DateTime)

         Current.Inoltra(Current, DataInoltro)

      End Sub
      Public Sub AccettaDelega(ByVal DataAccettazione As DateTime)

         'If AccettataDaEntrambiEntiBilaterali Then
         '   Dim EdilCassa As Azienda = controllerEnteBil.GetEdilCassa
         '   Dim CassaEdile As Azienda = controllerEnteBil.GetCassaEdile
         '   If EdilCassa Is Nothing Then Throw New Exception("Impossibile impostare l'ente di inoltro. Impossibile trovare la definizione di Cassa Edile")
         '   If CassaEdile Is Nothing Then Throw New Exception("Impossibile impostare l'ente di inoltro. Impossibile trovare la definizione di EdilCassa ")
         '   If EdilCassa.Id = -1 Then Throw New Exception("Impossibile impostare l'ente di inoltro. Impossibile trovare la definizione di Cassa Edile. Tipo oggetto non specificato.")
         '   If CassaEdile.Id = -1 Then Throw New Exception("Impossibile impostare l'ente di inoltro. Impossibile trovare la definizione di EdilCassa. Tipo oggetto non specificato.")
         '   Current.Accetta(Current, DataAccettazione, EdilCassa, CassaEdile)
         'Else
         '   Dim ente As Azienda = New AziendaNonSpecificata
         '   If Current.Settore.TipologiaSettore = Settore.TipoSettore.Edili Then
         '      ente = controllerEnteBil.GetEnteById(EnteAccettante)
         '   ElseIf Current.Settore.TipologiaSettore = Settore.TipoSettore.ImpiantiFissi Then
         '      ente = ControllerAziende.GetAziendaById(EnteAccettante)
         '   Else
         '      Throw New Exception("Impossibile accettare la delega. Tipo settore sconiosciuto")
         '   End If
         '   If Not IsNumeric(EnteAccettante) Then Throw New Exception("Non è possibile accettare la delega. L'id dell'ente accettante non ha un formato corretto. Inserire un id corretto.")
         '   Current.Accetta(Current, DataAccettazione, ente, New AziendaNonSpecificata)
         'End If
         Current.Accetta(Current, DataAccettazione)

      End Sub
      Public Sub RevocaDelega(ByVal DataRevoca As DateTime, ByVal IdCausale As String, ByVal Note As String)

         Dim controlCausali As New ControllerCausaliRevoca
         Dim causale As CausaleRevocaDelega = controlCausali.GetCausaleById(IdCausale)
         Current.Revoca(Current, DataRevoca, causale, Note)

      End Sub
      Public Sub AnnullaDelega(ByVal DataAnnullamento As DateTime, ByVal IdCausale As String)

         Dim controlCausali As New ControllerCausaliRevoca
         Dim causale As CausaleRevocaDelega = controlCausali.GetCausaleById(IdCausale)
         Current.Annulla(Current, DataAnnullamento, causale)

      End Sub
      Public Function IsActive() As Boolean
         Return Current.IsActive
      End Function
      Public Function IsAccepted() As Boolean
         Return Current.IsAccepted
      End Function
      Public Sub RipristinaStatoPrecedente()

         Current.RipristinaStatoPrecedente()

      End Sub
#End Region



      Public Sub RemoveCurrentDelegaFouUtente()
         Current.Utente.RemoveDelega(Current)
      End Sub


#Region "Metodi CRUD"
      Public Overrides Function GetCategoryObject() As String
         Return "Delega"
      End Function
      ''' <summary>
      ''' Metodo non implementato
      ''' </summary>
      ''' <remarks></remarks>
      Public Overrides Sub CreateNew()
         MyBase.m_current = New Delega
         Current.StatoDelega = StSottoscritta.Instance
        End Sub


        Public Function VerificaDelegaPagabile(ByVal idUtente As String, ByVal idSettore As String, ByVal idEnte As String, ByVal datainizio As DateTime, ByVal dataFine As DateTime) As Boolean

            Try

                If Not IsNumeric(idUtente) Then Throw New Exception("Il valore dell'id dell'utente immesso non ha un formato corretto. Inserire un id valido")
                If Not IsNumeric(idEnte) Then Throw New Exception("Il valore dell'id dell'azienda d'inoltro immesso non ha un formato corretto. Inserire un id valido")
                If Not IsNumeric(idSettore) Then Throw New Exception("Il valore dell'id del settore immesso non ha un formato corretto. Inserire un id valido")
                Dim utente As Utente = ControllerUtenti.GetUtenteById(idUtente)
                Dim Ente As Azienda = New AziendaNonSpecificata
                Dim settore As Settore = ControllerSettori.GetSettoreById(idSettore)
                Dim range As New DataRange(datainizio, dataFine)


                If settore.TipologiaSettore = DOMAIN.FEDERATIONARTIFACTS.Settore.TipoSettore.Edili Then
                    Ente = controllerEnteBil.GetEnteById(idEnte)
                   

                ElseIf settore.TipologiaSettore = DOMAIN.FEDERATIONARTIFACTS.Settore.TipoSettore.ImpiantiFissi Then


                    Ente = ControllerAziende.GetAziendaById(idEnte)

              
                End If


                Return utente.IsPayble(range, Ente)


            Catch ex As Exception
                Return False
            End Try



        End Function


      ''' <summary>
      ''' Crea un'istanza completa dell'oggetto e la rende immediatamente persistente
      ''' </summary>
      ''' <param name="DataRegistrazione"></param>
      ''' <param name="DataDocumento"></param>
      ''' <param name="Note"></param>
      ''' <param name="IdUtente"></param>
      ''' <param name="IdReferente"></param>
      ''' <param name="IdEnte"></param>
      ''' <remarks></remarks>
        Public Overloads Sub CreateNew(ByVal DataRegistrazione As DateTime, ByVal DataDocumento As DateTime, _
                                       ByVal Note As String, ByVal IdUtente As String, _
                                       ByVal IdReferente As String, ByVal IdEnte As String, _
                                       ByVal IdSettore As String, ByVal IdReparto As String, _
                                       ByVal IdCausaleSott As String, _
                                       ByVal IdResponsabile As String, _
                                       ByVal NomeSedeOperativa As String)
            Try
                'questo metodo andrà modificato per gestire l'inoltro ad entrambi gli enti bilaterali
                If IdReferente = "" Then IdReferente = -1
                If IdResponsabile = "" Then IdResponsabile = -1
                If IdReparto = "" Then IdReparto = -1
                If Not IsNumeric(IdReparto) Then Throw New Exception("Il valore dell'id del reparto immesso non ha un formato corretto. Inserire un id valido")
                If Not IsNumeric(IdCausaleSott) Then Throw New Exception("Il valore dell'id della causale di sottoscrizione immesso non ha un formato corretto. Inserire un id valido")
                If Not IsNumeric(IdUtente) Then Throw New Exception("Il valore dell'id dell'utente immesso non ha un formato corretto. Inserire un id valido")
                If Not IsNumeric(IdReferente) Then Throw New Exception("Il valore dell'id del referente immesso non ha un formato corretto. Inserire un id valido")
                If Not IsNumeric(IdResponsabile) Then Throw New Exception("Il valore dell'id del responsabile immesso non ha un formato corretto. Inserire un id valido")
                If Not IsNumeric(IdEnte) Then Throw New Exception("Il valore dell'id dell'azienda d'inoltro immesso non ha un formato corretto. Inserire un id valido")
                If Not IsNumeric(IdSettore) Then Throw New Exception("Il valore dell'id del settore immesso non ha un formato corretto. Inserire un id valido")
                Dim utente As Utente = ControllerUtenti.GetUtenteById(IdUtente)
               

                Dim referente As Referente = ControllerReferenti.GetReferenteById(IdReferente)
                Dim responsabile As Referente = ControllerReferenti.GetReferenteById(IdResponsabile)
                Dim Ente As Azienda = New AziendaNonSpecificata
                Dim settore As Settore = ControllerSettori.GetSettoreById(IdSettore)
                Dim controllerCausaliSott As New ControllerCausaliSottoscrizione
                Dim causale As CausaleSottoscrizioneDelega = controllerCausaliSott.GetCausaleById(IdCausaleSott)
                If settore.TipologiaSettore = DOMAIN.FEDERATIONARTIFACTS.Settore.TipoSettore.Edili Then
                    Ente = controllerEnteBil.GetEnteById(IdEnte)
                    'If EntrambiEntiBilaterali Then
                    '   Ente1 = controllerEnteBil.GetEdilCassa
                    '   Ente2 = controllerEnteBil.GetCassaEdile
                    'Else
                    '   Ente1 = controllerEnteBil.GetEnteById(IdEnte)
                    'End If
                    MyBase.m_current = New Delega(DataRegistrazione, DataDocumento, Note, utente, referente, Ente, New StSottoscritta, settore, causale, New RepartoNullo, , responsabile)
                ElseIf settore.TipologiaSettore = DOMAIN.FEDERATIONARTIFACTS.Settore.TipoSettore.ImpiantiFissi Then
                    Dim controllerrep As New ControllerReparti
                    Dim reparto As RepartoAzienda = controllerrep.GetCausaleById(IdReparto)
                    Dim azienda As Azienda = ControllerAziende.GetAziendaById(IdEnte)
                    MyBase.m_current = New Delega(DataRegistrazione, DataDocumento, Note, utente, referente, azienda, New StSottoscritta, settore, causale, reparto, , responsabile, NomeSedeOperativa)
                Else
                    Throw New Exception("Tipologia settore sconosciuta. ")
                End If
                Save()
            Catch ex As Exception
                Throw New Exception("Impossibile creare la delega." & vbCrLf & ex.Message)
            End Try
        End Sub
      Friend Function GetDelegaById(ByVal IdDelega As Int32) As Delega

         LoadById(IdDelega)
         Return Current()

      End Function


      Friend Function GetDelegaById(ByVal IdDelega As Int32, ByVal IdUtente As Int32) As Delega

         LoadById(IdUtente, IdDelega)
         Return Current()

      End Function


      Protected Overrides Sub DoUpdate()


         Ps.UpdateObject("Delega", m_current)

      End Sub
      Public Sub UpdateAllDeleghe()

         Ps.BeginTransaction()
         For Each elem As IDelega In Current.Utente.Deleghe
            Ps.MarkDirty(elem)
         Next
         Ps.CommitTransaction()

      End Sub
      Public Overloads Sub LoadById(ByVal IdUtente As String, ByVal IdDelega As String)

         If Not IsNumeric(IdUtente) Then Throw New Exception("Impossibile caricare un oggetto delega. Il formato dell'id utente immesso non è corretto. Inserire l'Id corretto.")
         If Not IsNumeric(IdDelega) Then Throw New Exception("Impossibile caricare un oggetto delega. Il formato dell'id dlelega immesso non è corretto. Inserire l'Id corretto.")

         ' m_current = RegistratoreElementi.Instance.GetObjectById(Id, GetCategoryObject) '
         Dim utente As Utente = Ps.GetObject("Utente", IdUtente)
         m_current = utente.GetDelegaById(IdDelega)
            If m_current Is Nothing Then Throw New Exception("L'oggetto con l'Id richiesto non esiste. Reinserire un Id corretto oppure effettuare una ricerca.")

      End Sub
#End Region

        Public Shared Function RevocaDelegaEdileUtente(idUtente As String, idente As String, idCausaleRevoca As String, datarevoca As DateTime, m_AddDelegaifNotExist As Boolean, m_revokeAll As Boolean) As Boolean
            Dim executed As Boolean = False

            'verifico il'identificativo dell'utente
            If idente = -1 Then
                Throw New Exception("Id utente inesistente")
            End If
            If String.IsNullOrEmpty(idUtente) Then
                Throw New Exception("Id utente inesistente")
            End If

            'ottengo l'ente
            Dim controllerEnti As New AZIENDE.ControllerEntiBilaterali
            Dim Ente As Azienda = controllerEnti.GetEnteById(idente)


            'ottengo l'oggetto utente
            Dim ControllerUtenti As New WIN.APPLICATION.UTENTI.ControllerUtenti()
            Dim utente As Utente = ControllerUtenti.GetUtenteById(idUtente)

            If utente Is Nothing Then
                Throw New Exception("Id utente inesistente")
            End If



            'verifico il numero di deleghe nel settore edile dell'utente
            Dim deled As Int32 = GetDelegheEdili(utente, Ente)

            'una volta ottenuto l'utente verifico il numero delle deleghe
            'se non ci sono deleghe e addDelegaIfNotExist è falso
            'ritorno che nulla è avvenuto
            If deled = 0 Then
                If Not m_AddDelegaifNotExist Then
                    Return False
                Else ' altrimenti inserisco una delega e la revoco contemporaneamente
                    Dim note As String = String.Format("Delega automaticamente generata e revocata in data: {0}", DateTime.Now)
                    Dim cc As New ControllerDeleghe
                    cc.CreateNew(datarevoca, datarevoca, note, utente.Id, "-1", idente, "2", "-1", "1", "-1", "")
                    cc.RevocaDelega(datarevoca, idCausaleRevoca, "")
                    cc.Save()
                    Return True
                End If
            End If




            'adesso devo verificare la presenza di una delega attiva o accettata
            Dim delega As Delega = utente.GetActiveDelegaFor(Ente)
            If delega.Id <> -1 Then
                'se la trovo la revoco
                Dim cc As New ControllerDeleghe
                cc.LoadById(delega.Id)
                cc.RevocaDelega(datarevoca, idCausaleRevoca, "")
                cc.Save()
                executed = True
            End If

            'adesso verifico se revocare tutte le altre deleghe sottoscritte e inoltrate
            If m_revokeAll Then
                'ciclo su tutte le deleghe dell'utente e ne cerco le deleghe sottoscritte o inoltrate per quellente
                For Each d As Delega In utente.Deleghe
                    If d.StatoDelega.StatusName = "Sottoscritta" Or d.StatoDelega.StatusName = "Inoltrata" Then
                        If d.IsForSettoreEdile And d.EnteInoltro.Id = Ente.Id Then
                            Dim cc As New ControllerDeleghe
                            cc.LoadById(d.Id)
                            cc.RevocaDelega(datarevoca, idCausaleRevoca, "")
                            cc.Save()
                            executed = True
                        End If
                    End If
                Next
            End If

           



            Return executed


            ''ottengo l'oggetto causali revoca
            'Dim controllercausali As New ControllerCausaliRevoca()
            'Dim causale As CausaleRevocaDelega
            'If idCausaleRevoca > -1 Then
            '    causale = controllercausali.GetCausaleById(idCausaleRevoca)
            'End If




        End Function

        Private Shared Function GetDelegheEdili(utente As Utente, ente As Azienda) As Int32
            Dim res As Int32
            For Each delega As Delega In utente.Deleghe
                If delega.IsForSettoreEdile And delega.EnteInoltro.Id = ente.Id Then
                    res = res + 1
                End If
            Next
            Return res
        End Function


   End Class
End Namespace