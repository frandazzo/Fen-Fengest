
Public Class ControllerAvvocati
   Inherits AbstractController

   Private m_ragioneSociale As String = ""

   Public Function Current() As Avvocato
      Return DirectCast(MyBase.m_current, Avvocato)
   End Function
   Public Sub New()

   End Sub

   Public Sub SetRagioneSociale(ByVal ragioneSociale As String)
      m_ragioneSociale = ragioneSociale
   End Sub


   Public Function Search() As IList
      'qui creo ed eseguo la query
      Dim ps As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
      Dim query As Query = ps.CreateNewQuery("MapperAvvocato")
      Dim mainCriteria As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.AndOp)
     






     


    
      If m_ragioneSociale <> "" Then
         mainCriteria.AddCriteria(Criteria.Matches("DESCRIZIONE", UCase(m_ragioneSociale), ps.DBType))
      End If




      Dim orderCriteria As AbstractBoolCriteria = New OrderByCriteria
      orderCriteria.AddCriteria(Criteria.SortCriteria("DESCRIZIONE", True))



      query.AddWhereClause(mainCriteria)

      query.AddOrderByClause(orderCriteria)



      'Dim start As DateTime = Now
      'System.Diagnostics.Debug.WriteLine("Inizio query a " & start.ToString)
      Dim list As IList = query.Execute(ps)

     
      Return list
   End Function
 
#Region "Proprietà oggetto"
   Public Property PartitaIva() As String
      Get
         Return Current.PartitaIva
      End Get
      Set(ByVal value As String)
         Current.PartitaIva = value
      End Set
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


#End Region

 

#Region "Metodi CRUD"
   Public Overrides Function GetCategoryObject() As String
      Return "Avvocato"
   End Function
   ''' <summary>
   ''' Crea un'istanza vuota dell'oggetto
   ''' </summary>
   ''' <remarks></remarks>
   Public Overrides Sub CreateNew()

      MyBase.m_current = New Avvocato
     
   End Sub





   Friend Function GetAvvcatoById(ByVal Id As String) As Avvocato

      Try
         LoadById(Id)
      Catch ex As Exception
         Return Nothing
      End Try
      Return Current()

   End Function


  
   
#End Region


End Class
