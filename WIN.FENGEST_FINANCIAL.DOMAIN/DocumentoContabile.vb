Public Class DocumentoContabile
   Inherits AbstractDocumento
   Protected m_IsPosted As Boolean
   Protected m_Items As New VirtualLazyList
   Protected m_Valuta As Moneta.Valuta

#Region "Costruttori"
   Public Sub New()

   End Sub
   Public Sub New(ByVal DataRegistrazione As DateTime, ByVal DataDocumento As DateTime, ByVal Note As String)
      MyBase.New(DataDocumento, DataRegistrazione, Note)
   End Sub
#End Region



#Region "Metodi usabili solo dai mapper"
   ''' <summary>
   ''' NON USARE QUESTO METODO PER LA REGISTRAZIONE DEL DOCUMENTO.
   ''' Esso è un metodo ausiliario per costruire l'oggetto a partire da un record nella base dati.
   ''' </summary>
   ''' <remarks></remarks>
   Public Sub SetPosted()
      m_IsPosted = True
   End Sub
   ''' <summary>
   ''' NON USARE QUESTO METODO PER LA REGISTRAZIONE DEL DOCUMENTO. Metodo per impostare la lista delle posizioni del documento usato dai mapper per la ricostruzione dell'oggetto dalla base dati
   ''' </summary>
   ''' <param name="ItemList"></param>
   ''' <remarks></remarks>
   Public Sub SetItems(ByVal ItemList As IList)
      m_Items = ItemList
   End Sub
#End Region


#Region "Metodi concreti ed astratti per la gestione del documento contabile"

   ''' <summary>
   ''' Metodo che registra il documento eseguendo la validazione del documento tramite il metodo IsValid, 
   ''' ne verifica il totale e se esso è 0 richiama il metodo post su tutte le posizioni del documento.
   ''' Se tutto va a buon fine imposta la variabile IsPosted a True.
   ''' </summary>
   ''' <remarks></remarks>
   Public Overrides Sub Post()
      PrePostActions()
      If CanPost() Then

         If Me.IsValid Then
            For Each elem As ItemContabile In m_Items
               elem.Post()
            Next
            PostPostActions()
            m_IsPosted = True
         Else
            Dim errors As String = ""
            For Each elem As String In Me.ValidationErrors
               errors = errors & elem & vbCrLf
            Next
            Throw New Exception("L'oggetto non è valido. Controllare il valore dei valori immessi" & vbCrLf & errors)
         End If
      Else
         Throw New Exception("Impossibile registrare il documento. Totale documento diverso da 0.")
      End If
   End Sub
   ''' <summary>
   ''' Metodo hook per inserire azioni preliminari la registrazione del documento
   ''' </summary>
   ''' <remarks></remarks>
   Protected Overridable Sub PrePostActions()
      '
   End Sub
   ''' <summary>
   ''' Metodo hook per inserire azioni successive la registrazione del documento
   ''' </summary>
   ''' <remarks></remarks>
   Protected Overridable Sub PostPostActions()
      '

   End Sub
   ''' <summary>
   ''' Metodo che esegue il calcolo dell'importo totale delle posizioni
   ''' </summary>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public Function GetTotal() As Moneta
      Dim Total As Moneta = New Moneta(0.0, m_Valuta)
      For Each elem As ItemContabile In m_Items
         Total = Total.Add(elem.Importo)
      Next
      Return Total
   End Function
   ''' <summary>
   ''' Metodo che verifica se il totale delle posizioni è 0.
   ''' </summary>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Protected Overridable Function CanPost() As Boolean
      Return Me.GetTotal.Importo = 0.0
   End Function
   ''' <summary>
   ''' Proprietà che indica se il documento è stato registrato
   ''' </summary>
   ''' <value></value>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public ReadOnly Property IsPosted() As Boolean
      Get
         Return m_IsPosted
      End Get
   End Property
   ''' <summary>
   ''' Metodo che restituisce la lista delle posizioni del documento per mezzo dell'interfaccia IList
   ''' </summary>
   ''' <value></value>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public ReadOnly Property ItemList() As VirtualLazyList
      Get
         Return m_Items
      End Get
   End Property
   Public Overrides Function ToString() As String
      If Me.GetId = -1 Then
         Return ""
      End If
      Return Me.GetId
   End Function

#End Region







#Region "Proprietà sovrascritte"
   ''' <summary>
   ''' Proprietà che ottiene o imposta  la data di registrazione 
   ''' del documento. Nel caso il documento possegga degli item Nel caso il documento possegga degli item essi vengono aggiornati
   ''' </summary>
   ''' <value></value>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public Overrides Property DataRegistrazione() As DateTime
      Get
         Return m_dataRegistrazione
      End Get
      Set(ByVal value As DateTime)
         m_dataRegistrazione = value
         For Each item As ItemContabile In m_Items
            item.DataRegistrazione = value
         Next
      End Set
   End Property
   ''' <summary>
   ''' Proprietà che ottiene o imposta  la data di documento 
   ''' del documento. Nel caso il documento possegga degli item essi vengono aggiornati
   ''' </summary>
   ''' <value></value>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public Overrides Property DataDocumento() As DateTime
      Get
         Return m_dataDocumento
      End Get
      Set(ByVal value As DateTime)
         m_dataDocumento = value
         For Each item As ItemContabile In m_Items
            item.DataDocumento = value
         Next
      End Set
   End Property
#End Region
End Class
