Public Class Evento
   Inherits AbstractDocumento
   Protected m_TipoEvento As TipoEvento = New TipoEventoNullo
   Protected m_DocumentoPadre As IDocumento = New VertenzaNulla
   Public Sub New()

   End Sub


   Public Property Path_Documento() As String
      Get
         Return m_Path_Documento
      End Get
      Set(ByVal value As String)
         m_Path_Documento = value
      End Set
   End Property


   Public Sub New(ByVal DataEvento As DateTime, ByVal Note As String, ByVal TipoEvento As TipoEvento)
      MyBase.New(DataEvento, DataEvento, Note)
      If TipoEvento Is Nothing OrElse TipoEvento.Tipo = FED_SERVICES.TipoEvento.TipologiaEvento.TipoNullo Then Throw New Exception("Impossibile impostare un evento vertenza. Tipo evento nullo.")
      m_TipoEvento = TipoEvento
   End Sub
   Public Property TipoEvento() As TipoEvento
      Get
         Return m_TipoEvento
      End Get
      Set(ByVal value As TipoEvento)
         If value Is Nothing Then Throw New Exception("Impossibile impostare un evento vertenza. Tipo evento nullo.")
         m_TipoEvento = value
      End Set
   End Property
   ''' <summary>
   ''' Questa proprietà è stata inserita solamente per permettere il recupero dell'id della vertenza per 
   ''' l'inserimento di un nuovo evento. Il riferimento circolare non è necessario nel ciclo di vita dell'evento
   ''' e pertanto verra creato solo quando un nuo evento viena aggiunto alla vertenza tramite il metodo AddEvento.
   ''' Non valorizzare e non leggere questa proprietà.
   ''' </summary>
   ''' <value></value>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public Property DocumentoPadre() As IDocumento
      Get
         Return m_DocumentoPadre
      End Get
      Set(ByVal value As IDocumento)
         m_DocumentoPadre = value
      End Set
   End Property
   Protected Overrides Sub DoValidation()

   End Sub
End Class
