Public Class SedeOperativa
   Inherits AbstractPersistenceObject
   Implements ISedeOperativa
   Private m_indirizzo As New Indirizzo
   Private m_AziendaPadre As Azienda = New AziendaNonSpecificata
   Public Sub New()

   End Sub
   Public Sub New(ByVal Descrizione As String, ByVal Comune As Comune, ByVal Provincia As Provincia, ByVal Via As String)
      If Descrizione = "" Then Throw New ArgumentNullException("Descrizione sede operativa nulla")
      MyBase.Descrizione = Descrizione
      With m_indirizzo
         .Comune = Comune
         .Provincia = Provincia
         .Via = Via
      End With
   End Sub
   Public Overrides Function ToString() As String
      Return Me.Descrizione
   End Function
   Public Property Indirizzo() As Indirizzo Implements ISedeOperativa.Indirizzo
      Get
         Return m_indirizzo
      End Get
      Set(ByVal value As Indirizzo)
         m_indirizzo = value
      End Set
   End Property
   Public Overrides Property Descrizione() As String Implements ISedeOperativa.Descrizione
      Get
         Return MyBase.Descrizione
      End Get
      Set(ByVal value As String)
         If value = "" Then Throw New ArgumentNullException("Descrizione sede operativa nulla")
         MyBase.Descrizione = value
      End Set
   End Property
   ''' <summary>
   ''' NON UTILIZZARE. Metodo usato dal metodo AddSedeOperativa della classe azienda
   ''' per notificare al servizio di persistenza l'id dell'azienda necessario per la fase di inserimento. 
   ''' </summary>
   ''' <param name="Azienda"></param>
   ''' <remarks></remarks>
   Public Sub SetAziendaPadre(ByVal Azienda As Azienda)
      m_AziendaPadre = Azienda
   End Sub
   Public ReadOnly Property IdAziendaPadre() As Int32
      Get
         Return m_AziendaPadre.Id
      End Get
   End Property
End Class
