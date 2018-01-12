Public Class Vertenza
   Inherits AbstractDocumento
   Implements IVertenza

   Private m_Utente As Utente = New UtenteNonSpecificato
   Private m_Azienda As Azienda = New AziendaNonSpecificata
   Private m_listaIstituti As New ArrayList
   Private m_Periodo As DataRange
   Private m_referente As Referente = New ReferenteNullo
   Private m_RUP As Referente = New ReferenteNullo
   Private m_Quota As Moneta = New Moneta(0, Moneta.Valuta.Euro)
   Private m_Eventi As IList = New VirtualLazyList



    Private m_VertenzaChiusa As Boolean = False

    Public Property VertenzaChiusa() As Boolean
        Get
            Return m_VertenzaChiusa
        End Get
        Set(ByVal value As Boolean)
            m_VertenzaChiusa = value
        End Set
    End Property

   Private m_Avvocato As Avvocato
   Public Property Avvocato() As Avvocato
      Get
         Return m_Avvocato
      End Get
      Set(ByVal value As Avvocato)
         m_Avvocato = value
      End Set
   End Property


   Public Overrides Function ToString() As String
      If Me.GetId = -1 Then
         Return ""
      End If
      Return Me.GetId
   End Function
#Region "Proprietà oggetto"
   Public Sub ClearListaIstituti()
      m_listaIstituti.Clear()
   End Sub
   Public Property Rup() As Referente
      Get
         Return m_RUP
      End Get
      Set(ByVal value As Referente)
         If value Is Nothing Then Throw New Exception("Impossibile impostare il RUP per la vertenza. RUP nullo.")
         m_RUP = value
      End Set
   End Property
   Public Property Referente() As Referente
      Get
         Return m_referente
      End Get
      Set(ByVal value As Referente)
         If value Is Nothing Then Throw New Exception("Impossibile impostare il referente per la vertenza. Referente nullo.")
         m_referente = value
      End Set
   End Property
   Public Property Utente() As Utente
      Get
         Return m_Utente
      End Get
      Set(ByVal value As Utente)
         If value Is Nothing OrElse value.Id = -1 Then Throw New Exception("Impossibile impostare l'utente per la vertenza. Utente o tipo utente nullo.")
         m_Utente = value
      End Set
   End Property
   Public Property Azienda() As Azienda
      Get
         Return m_Azienda
      End Get
      Set(ByVal value As Azienda)
         If value Is Nothing OrElse value.Id = -1 Then Throw New Exception("Impossibile impostare l'azienda controparte per la vertenza. Azienda o tipo azienda nulla.")
         m_Azienda = value
      End Set
   End Property
   Public ReadOnly Property ListaItituti() As ArrayList
      Get
         Return m_listaIstituti
      End Get
   End Property

   Public Property Quota() As Moneta
      Get
         Return m_Quota
      End Get
      Set(ByVal value As Moneta)
         If value.Importo < 0 Then Throw New Exception("Impossibile impostare un impotro quota < 0.")
         m_Quota = value
      End Set
   End Property
   Public Property PeriodoVertenza() As DataRange
      Get
         Return m_Periodo
      End Get
      Set(ByVal value As DataRange)
         If value.IsEmpty Then Throw New Exception("Impossibile impostare il periodo per la vertenza. Intervallo date negativo.")
         m_Periodo = value
      End Set
   End Property
   Public ReadOnly Property ListaEventi() As IList
      Get
         Return ArrayList.ReadOnly(m_Eventi)
      End Get
   End Property
   ''' <summary>
   ''' Questo metodo deve essere usato solamente dal mapper per le vertenze
   ''' </summary>
   ''' <param name="Lista"></param>
   ''' <remarks></remarks>
   Public Sub SetListaEventi(ByVal Lista As IList)
      If Lista Is Nothing Then Throw New Exception("Impossibile impostare la lista degli eventi. Lista nulla")
      m_Eventi = Lista
   End Sub
   ''' <summary>
   ''' Questo metodo deve essere usato solamente dal mapper per le vertenze
   ''' </summary>
   ''' <param name="Lista"></param>
   ''' <remarks></remarks>
   Public Sub SetListaIstituti(ByVal Lista As ArrayList)
      If Lista Is Nothing Then Throw New Exception("Impossibile impostare la lista degli istituti contrattuali. Lista nulla")
      Me.m_listaIstituti = Lista
   End Sub

#End Region

   Public Sub New(ByVal DataDocumento As DateTime, ByVal DataRegistrazione As DateTime, _
                       ByVal Note As String, ByVal Utente As Utente, ByVal Referente As Referente, _
                       ByVal RUP As Referente, ByVal Quota As Moneta, ByVal Azienda As Azienda, ByVal Periodo As DataRange)
      MyBase.New(DataDocumento, DataRegistrazione, Note)
      If Utente Is Nothing Then Throw New Exception("Impossibile impostare l'utente per la vertenza richiesta. Utente nullo")
      If Utente.Id = -1 Then Throw New Exception("Impossibile impostare l'utente per la vertenza richiesta. Tipo utente nullo")
      If Referente Is Nothing Then Throw New Exception("Impossibile impostare il referente per la vertenza richiesta. Referente nullo")
      If RUP Is Nothing Then Throw New Exception("Impossibile impostare il RUP per la vertenza richiesta. Rup nullo")
      If Quota.Importo < 0 Then Throw New Exception("Impossibile impostare un impotro quota < 0.")
      If Azienda Is Nothing OrElse Azienda.Id = -1 Then Throw New Exception("Impossibile impostare l'azienda controparte per la vertenza. Azienda o tipo azienda nulla.")
      If Periodo.IsEmpty Then Throw New Exception("Impossibile impostare il periodo per la vertenza. Intervallo date negativo.")
      m_Periodo = Periodo
      m_Azienda = Azienda
      m_Quota = Quota
      m_RUP = RUP
      m_referente = Referente
      m_Utente = Utente
      MyBase.m_TipoDocumento = "VER"
   End Sub
   Public Sub New()
      MyBase.m_TipoDocumento = "VER"
   End Sub

   Public Sub AddEvento(ByVal Evento As Evento)
      Try
         If Evento Is Nothing OrElse TypeOf (Evento) Is EventoNullo Then Throw New Exception("Evento o tipo evento nullo")
         If Evento.DataDocumento < Me.DataDocumento Then Throw New Exception("Data vertenza posteriore alla data dell'evento")
         For Each elem As Evento In m_Eventi
            If elem.DataRegistrazione = Evento.DataRegistrazione And elem.TipoEvento.Tipo = Evento.TipoEvento.Tipo Then Throw New Exception("Evento già esistente")
         Next
         Evento.DocumentoPadre = Me
         m_Eventi.Add(Evento)
      Catch ex As Exception
         Throw New Exception("Impossibile aggiungere un nuovo evento alla vertenza" & vbCrLf & ex.Message)
      End Try

   End Sub
   Public Sub RemoveEvento(ByVal Evento As Evento)
      m_Eventi.Remove(Evento)
   End Sub
   Public Sub AddIstitutoContrattuale(ByVal Istituto As IstitutoContrattuale)
      Try
         If Istituto Is Nothing OrElse TypeOf (Istituto) Is IstitutoNullo Then Throw New Exception("Istituto o tipo stituto nullo")
         For Each elem As IstitutoContrattuale In m_listaIstituti
            If elem.Id = Istituto.Id Then Throw New Exception("Istituto già presente")
         Next
         m_listaIstituti.Add(Istituto)
      Catch ex As Exception
         Throw New Exception("Impossibile aggiungere un nuovo istituto contrattuale." & vbCrLf & ex.Message)
      End Try
   End Sub
   Public Sub RemoveIstituto(ByVal Istituto As IstitutoContrattuale)

      'm_listaIstituti.Remove(Istituto)
      For Each elem As IstitutoContrattuale In m_listaIstituti
         If elem.Id = Istituto.Id Then
            m_listaIstituti.Remove(elem)
            Return
         End If

      Next
   End Sub

   Public Overloads Function GetEvento(ByVal Index As Int32) As Evento
      Try
         If Index < 0 OrElse Index >= m_Eventi.Count Then Throw New Exception("Indice non valido")
         Return m_Eventi.Item(Index)
      Catch ex As Exception
         Throw New Exception("Impossibile recuperare l'evento." & vbCrLf & ex.Message)
      End Try
   End Function
   Public Overloads Function GetEvento(ByVal Key As Key) As Evento
      Try
         For Each elem As Evento In m_Eventi
            If elem.Key.EqualsTo(Key) Then Return elem
         Next
         Return New EventoNullo
      Catch ex As Exception
         Throw New Exception("Impossibile recuperare l'evento." & vbCrLf & ex.Message)
      End Try
   End Function
   Public Overloads Function GetEvento(ByVal DataRegistrazione As DateTime, ByVal TipoEvento As TipoEvento.TipologiaEvento) As Evento
      Try
         For Each elem As Evento In m_Eventi
            If elem.DataRegistrazione = DataRegistrazione And elem.TipoEvento.Tipo = TipoEvento Then Return elem
         Next
         Return New EventoNullo
      Catch ex As Exception
         Throw New Exception("Impossibile recuperare l'evento." & vbCrLf & ex.Message)
      End Try
   End Function

   Public ReadOnly Property ReferenteI() As BASEREUSE.AbstractPersona Implements INTERFACES.IVertenza.Referente
      Get
         Return m_referente
      End Get

   End Property
   Protected Overrides Sub DoValidation()

      If Me.m_Azienda Is Nothing OrElse TypeOf (m_Azienda) Is AziendaNonSpecificata Then
         ValidationErrors.Add("Vertenza non valida. Azienda controparte non specificata o nulla.")
      End If

      If Me.m_Utente Is Nothing OrElse TypeOf (m_Utente) Is UtenteNonSpecificato Then
         ValidationErrors.Add("Vertenza non valida. Utente  non specificato o nullo.")
      End If

      If Me.m_Periodo Is Nothing OrElse Me.m_Periodo.IsEmpty Then
         ValidationErrors.Add("Vertenza non valida. Periodo vertenza  vuoto o nullo.")
      End If



   End Sub
End Class
