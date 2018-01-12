Namespace AZIENDE
   Public Class ControllerEntiBilaterali
      Inherits AbstractController
      Private m_ControllerConti As New CONTI.ControllerConti

      Private Function Current() As Azienda
         Return DirectCast(MyBase.m_current, EnteBilaterale)
      End Function

#Region "Proprietà oggetto"
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
      Public Sub SetIndirizzoSedeLegale(ByVal Via As String, ByVal NomeProvincia As String, ByVal NomeComune As String)
            Dim geo As GeoLocationHandler = GeoLocationFacade.Instance.GetGeoHandler
         Dim indirizzo As New Indirizzo
         indirizzo.Via = Via
         indirizzo.Provincia = geo.GetProvinciaByName(NomeProvincia)
         indirizzo.Comune = geo.GetComuneByName(NomeComune)
         Current.IndirizzoSedeLegale = indirizzo
      End Sub
      Public Function GetIdEnteByDescrizione(ByVal Descrizione As String) As Int32
         Try
            Me.LoadAll()
            For Each elem As EnteBilaterale In Me.DomainObjectList
               If elem.Descrizione = Descrizione Then Return elem.Id
            Next
            Throw New Exception("Ente con descrizione " & Descrizione & " non trovato")
         Catch ex As Exception
            Throw New Exception("Impossibile ottenere l'Id dell'ente ." & vbCrLf & ex.Message)
         End Try
      End Function

      Friend Function GetEnteByDescrizione(ByVal Descrizione As String) As EnteBilaterale
         Try
            Me.LoadAll()
            For Each elem As EnteBilaterale In Me.DomainObjectList
               If elem.Descrizione = Descrizione Then Return elem
            Next
            Return Nothing
         Catch ex As Exception
            Throw New Exception("Impossibile ottenere l'ente ." & vbCrLf & ex.Message)
         End Try
      End Function

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

      Public Function GetDescrizioneEnteById(ByVal Id As String) As String
         Try
            Me.LoadAll()
            For Each elem As EnteBilaterale In Me.DomainObjectList
               If elem.Id = Id Then Return elem.Descrizione
            Next
            Throw New Exception("Ente con id " & Id & " non trovato")
         Catch ex As Exception
            Throw New Exception("Impossibile ottenere la descrizione dell'ente." & vbCrLf & ex.Message)
         End Try
      End Function
      Public Function IsCassaEdile(ByVal Descrizione As String) As Boolean

         Me.LoadAll()
         For Each elem As EnteBilaterale In Me.DomainObjectList
            If elem.Descrizione = Descrizione Then
               If elem.TipoEnte = EnteBilaterale.TipoEnteBilaterale.CassaEdile Then Return True
            End If
         Next
         Return False


      End Function
      Public Function GetListaEnti() As Hashtable
         Try
            Me.LoadAll()
            Dim map As New Hashtable
            For Each elem As EnteBilaterale In Me.DomainObjectList
               map.Add(elem.Id, elem.Descrizione)
            Next
            Return map
         Catch ex As Exception
            Throw New Exception("Impossibile ottenere la hash map degli enti bilaterali. " & vbCrLf & ex.Message)
         End Try
      End Function




      Public ReadOnly Property ValutaConto() As String
         Get
            Return Moneta.GetTipoValutaToString(Current.Conto.Valuta)
         End Get
      End Property
      Public ReadOnly Property IdEnte() As Int32
         Get
            Return Current.Key.LongValue
         End Get
      End Property
      Public Property Descrizione() As String
         Get
            Return Current.Descrizione
         End Get
         Set(ByVal value As String)
            Current.Descrizione = value
         End Set
      End Property


      Public ReadOnly Property CompetenzaUltimoPagamento() As String
         Get
            If TypeOf Current.CompetenzaUltimoPagamento Is PeriodoNullo Then
               Return "Non è stato effettuato alcun pagamento"
            Else
               Return Current.CompetenzaUltimoPagamento.ToString
            End If
         End Get
      End Property


      Public ReadOnly Property IdConto() As String
         Get
            If Current.Conto.IdConto = -1 Then Return ""
            Return Current.Conto.IdConto
         End Get

      End Property
      Public Sub SetConto(ByVal IdConto As String)

         If Not IsNumeric(IdConto) Then Throw New Exception("L'id del conto inserito non ha una formato corretto. Correggere l'id del conto.")
         Current.Conto = m_ControllerConti.GetContoById(IdConto)

      End Sub
      Public ReadOnly Property DescrizioneConto() As String
         Get
            Return Current.Conto.Descrizione
         End Get
      End Property
#End Region



#Region "Metodi CRUD"
      Public Overrides Function GetCategoryObject() As String
         Return "EnteBilaterale"
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
         MyBase.m_current = New EnteBilaterale
         'Current.CompetenzaUltimoPagamento = New PeriodoNullo
      End Sub

      ''' <summary>
      ''' Crea e salva un oggetto Ente bilaterale di un dato tipo previa verifica dell'esistenza di un ente dello stesso tipo
      ''' </summary>
      ''' <param name="Descrizione"></param>
      ''' <param name="TipoEnte">I valori ammessi sono: "CassaEdile", "EdilCassa"</param>
      ''' <remarks></remarks>
      Public Overloads Sub CreateNew(ByVal Descrizione As String, _
                                     ByVal TipoEnte As String)


         If ControllerEntiBilaterali.GetEnteByTipo(TipoEnte).Id = -1 Then
            MyBase.m_current = New EnteBilaterale(Descrizione, New PeriodoNullo, CONTI.ControllerConti.GetContoByType("Feneal"), IConfrontoPeriodi.UnitaDiCompetenza.Mensile, EnteBilaterale.GetTipoEnte(TipoEnte))
            Save()
         Else
            Throw New Exception("Impossibile aggiungere l'ente bilaterale. Tipo ente esistente")
         End If

      End Sub
      Friend Function GetEnteById(ByVal IdEnte As String) As EnteBilaterale

         LoadById(IdEnte)
         Return Current()

      End Function
      ''' <summary>
      ''' 
      ''' </summary>
      ''' <param name="Tipo">I valori ammessi sono: "CassaEdile", "EdilCassa"</param>
      ''' <returns></returns>
      ''' <remarks></remarks>
      Public Shared Function GetEnteByTipo(ByVal Tipo As String) As Azienda
         Try
            Dim tipoEnte As EnteBilaterale.TipoEnteBilaterale = EnteBilaterale.GetTipoEnte(Tipo)
            Dim query As Query = DataAccessServices.Instance.PersistenceFacade.CreateNewQuery("MapperEnteBilaterale")
                Dim criteria As Criteria = TECHNICAL.PERSISTENCE.Criteria.Equal("TIPO_ENTE", tipoEnte)
            query.AddWhereClause(criteria)
            Dim list As ArrayList = query.Execute(DataAccessServices.Instance.PersistenceFacade)
            If list.Count > 0 Then
               Return list.Item(0)
            End If
            Return New AziendaNonSpecificata
         Catch ex As Exception
            Throw New Exception("Impossibile ottenere l'ente bilaterale secondo il tipo " & Tipo & vbCrLf & ex.Message)
         End Try
      End Function
      Friend Function GetEdilCassa() As EnteBilaterale
         Try
            Dim list As ArrayList
            Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
            Dim query As Query = ps.CreateNewQuery("MapperEnteBilaterale")
            Dim mainCriteria As Criteria = Criteria.Equal("TIPO_ENTE", EnteBilaterale.TipoEnteBilaterale.EdilCassa)
            query.AddWhereClause(mainCriteria)
            list = query.Execute(ps)
            If list.Count = 0 Then Throw New Exception("Impossibile ottenere l'oggetto EdilCassa. La query non ha prodotto risultati.")
            Return list.Item(0)
         Catch ex As Exception
            Throw New Exception(ex.Message)
         End Try
      End Function
      Friend Function GetCassaEdile() As EnteBilaterale
         Try
            Dim list As ArrayList
            Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
            Dim query As Query = ps.CreateNewQuery("MapperEnteBilaterale")
            Dim mainCriteria As Criteria = Criteria.Equal("TIPO_ENTE", EnteBilaterale.TipoEnteBilaterale.CassaEdile)
            query.AddWhereClause(mainCriteria)
            list = query.Execute(ps)
            If list.Count = 0 Then Throw New Exception("Impossibile ottenere l'oggetto Cassa Edile. La query non ha prodotto risultati.")
            Return list.Item(0)
         Catch ex As Exception
            Throw New Exception(ex.Message)
         End Try
      End Function
#End Region


   End Class
End Namespace