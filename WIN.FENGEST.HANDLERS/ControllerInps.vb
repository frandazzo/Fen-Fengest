Namespace AZIENDE
   Public Class ControllerInps
      Inherits AbstractController
      Private m_ControllerConti As New CONTI.ControllerConti

      Private Function Current() As Azienda
         Return DirectCast(MyBase.m_current, Inps)
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
      Public Function GetDescrizioneInps() As String
         Try
            Me.LoadById(1)
            Return Current.Descrizione
            Throw New Exception("Il record  non è stato trovato")
         Catch ex As Exception
            Throw New Exception("Impossibile ottenere la descrizione dell'Inps." & vbCrLf & ex.Message)
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


      Public ReadOnly Property ValutaConto() As String
         Get
            Return Moneta.GetTipoValutaToString(Current.Conto.Valuta)
         End Get
      End Property
      Public ReadOnly Property Id() As Int32
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
      ''' <summary>
      ''' 
      ''' </summary>
      ''' <value>I valori ammessi sono: "Periodi generici","Periodi mensili"</value>
      ''' <returns></returns>
      ''' <remarks></remarks>
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

      Public ReadOnly Property IdConto() As String
         Get
            If Current.Conto.IdConto = -1 Then Return ""
            Return Current.Conto.IdConto
         End Get

      End Property
      Public Sub SetConto(ByVal IdConto As String)
         Try
            If Not IsNumeric(IdConto) Then Throw New Exception("L'id del conto inserito non ha una formato corretto. Correggere l'id del conto.")
            Current.Conto = m_ControllerConti.GetContoById(IdConto)
         Catch ex As Exception
            Throw New Exception(ex.Message)
         End Try
      End Sub
      Public ReadOnly Property DescrizioneConto() As String
         Get
            Return Current.Conto.Descrizione
         End Get
      End Property
#End Region



#Region "Metodi CRUD"
      Public Overrides Function GetCategoryObject() As String
         Return "Inps"
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
         MyBase.m_current = New Inps
         'Current.CompetenzaUltimoPagamento = New PeriodoNullo
      End Sub

      ''' <summary>
      ''' Crea e salval'oggetto Inps solo se già non ne esiste uno
      ''' </summary>
      ''' <param name="Descrizione"></param>
      ''' <remarks></remarks>
      Public Overloads Sub CreateNew(ByVal Descrizione As String)
         'questo costruttore è utile se voglio che il client crei e salvi
         'l'oggetto in un unico passaggio.
         'Client.CreateNew(Parameters)

         'esegue l'operaione solo se non esiste un altro elemento
         If GetInps() Is Nothing Then
            MyBase.m_current = New Inps(Descrizione, New PeriodoNullo, CONTI.ControllerConti.GetContoByType("Feneal"))
            Save()
         End If

      End Sub
      ''' <summary>
      ''' Metodo che restituisce nothing se non viene trovato l'oggetto corrispondente
      ''' </summary>
      ''' <returns></returns>
      ''' <remarks></remarks>
      Public Function GetInps() As Inps
         Try
            LoadById(1)
            Return Current()
         Catch ex As Exception
            Return Nothing
         End Try
      End Function
#End Region


   End Class
End Namespace
