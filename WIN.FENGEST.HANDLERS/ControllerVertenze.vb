Namespace ADMINISTRATION
   Public Class ControllerVertenze
      Inherits AbstractController
      Private ControllerUtenti As New UTENTI.ControllerUtenti
      Private controllerReferenti As New FINANCIAL_ARTIFACTS.ControllerReferenti
      Private ControllerAvvocati As New ControllerAvvocati
      Private ControllerAziende As New AZIENDE.ControllerAziende
      Private controllerIstituti As New ADMINISTRATION.ControllerIstituti
      Private m_CurrentEvento As Evento = New EventoNullo
      Public Sub New()
         Ps.BeginTransaction()
      End Sub
      Public Sub New(ByVal BeginTransaction As Boolean)
         If BeginTransaction Then
            Ps.BeginTransaction()
         End If
      End Sub
      Private Function Current() As Vertenza
         Return DirectCast(m_current, Vertenza)
      End Function

#Region "Proprietà oggetto"
      Public Property DataRegistrazione() As DateTime
         Get
            Return Current.DataRegistrazione
         End Get
         Set(ByVal value As DateTime)
            Current.DataRegistrazione = value
            Ps.MarkDirty(m_current)
         End Set
        End Property
        Public Property VertenzaChiusa() As Boolean
            Get
                Return Current.VertenzaChiusa
            End Get
            Set(ByVal value As Boolean)
                Current.VertenzaChiusa = value
                Ps.MarkDirty(m_current)
            End Set
        End Property
      Public Property DataDocumento() As DateTime
         Get
            Return Current.DataDocumento
         End Get
         Set(ByVal value As DateTime)
            Current.DataDocumento = value
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
      Public ReadOnly Property IdUtente() As Int32
         Get
            Return Current.Utente.Id
         End Get
      End Property




      Public Sub SetUtente(ByVal IdUtente As String)
         Try
            If Not IsNumeric(IdUtente) Then Throw New Exception("Id utente errato.")
            Current.Utente = ControllerUtenti.GetUtenteById(IdUtente)
            Ps.MarkDirty(m_current)
         Catch ex As Exception
            Throw New Exception("Impossibile impostare l'utente per la vertenza" & vbCrLf & ex.Message)
         End Try
      End Sub
      Public ReadOnly Property IdReferente() As String
         Get
            If Current.Referente.Id = -1 Then Return ""
            Return Current.Referente.Id
         End Get
      End Property
      Public Sub SetReferente(ByVal IdReferente As String)
         Try
            If IdReferente = "" Then IdReferente = -1
            If Not IsNumeric(IdReferente) Then Throw New Exception("Id referente errato.")
            Current.Referente = controllerReferenti.GetReferenteById(IdReferente)
            Ps.MarkDirty(m_current)
         Catch ex As Exception
            Throw New Exception("Impossibile impostare il referente per la vertenza" & vbCrLf & ex.Message)
         End Try
      End Sub


      Public ReadOnly Property IdAvvocato() As String
         Get
            If Current.Avvocato Is Nothing Then
               Return ""
            End If
            Return Current.Avvocato.Id
         End Get
      End Property
      Public Sub SetAvvocato(ByVal IdAvvocato As String)
         Try
            If IdAvvocato Is Nothing Then IdAvvocato = -1
            If IdAvvocato = "" Then IdAvvocato = -1
            If Not IsNumeric(IdAvvocato) Then Throw New Exception("Id avvocato errato.")
            Current.Avvocato = ControllerAvvocati.GetAvvcatoById(IdAvvocato)
            Ps.MarkDirty(m_current)
         Catch ex As Exception
            Throw New Exception("Impossibile impostare l'avvocato per la vertenza" & vbCrLf & ex.Message)
         End Try
      End Sub

      Public ReadOnly Property DescrizioneAvvocato() As String
         Get
            If Current.Avvocato IsNot Nothing Then
               Return Current.Avvocato.Descrizione
            End If
            Return ""
         End Get

      End Property






      Public ReadOnly Property IdRup() As String
         Get
            If Current.Rup.Id = -1 Then Return ""
            Return Current.Rup.Id
         End Get
      End Property
      Public Sub SetRup(ByVal IdRup As String)
         Try
            If IdRup = "" Then IdRup = -1
            If Not IsNumeric(IdRup) Then Throw New Exception("Id rup errato.")
            Current.Rup = controllerReferenti.GetReferenteById(IdRup)
            Ps.MarkDirty(m_current)
         Catch ex As Exception
            Throw New Exception("Impossibile impostare il rup per la vertenza" & vbCrLf & ex.Message)
         End Try
      End Sub
      Public ReadOnly Property IdVertenza() As String
         Get
            Return Current.Id
         End Get
      End Property
      Public ReadOnly Property CodiceVertenza() As String
         Get
            Return Current.TipoDocumento
         End Get
      End Property
      Public ReadOnly Property DescrizioneUtente() As String
         Get
            Return Current.Utente.CompleteName
         End Get
      End Property
      Public ReadOnly Property DescrizioneReferente() As String
         Get
            Return Current.Referente.CompleteName
         End Get
      End Property
      Public ReadOnly Property DescrizioneRup() As String
         Get
            Return Current.Rup.CompleteName
         End Get
      End Property
      Public ReadOnly Property DescrizioneAzienda() As String
         Get
            Return Current.Azienda.Descrizione
         End Get
      End Property
      Public ReadOnly Property IdAzienda() As Int32
         Get
            Return Current.Azienda.Id
         End Get
      End Property
      Public Sub SetAzienda(ByVal IdAzienda As String)
         Try
            If Not IsNumeric(IdAzienda) Then Throw New Exception("Id azienda errato.")
            Current.Azienda = ControllerAziende.GetAziendaById(IdAzienda)
            Ps.MarkDirty(m_current)
         Catch ex As Exception
            Throw New Exception("Impossibile impostare l'azienda controparte per la vertenza" & vbCrLf & ex.Message)
         End Try
      End Sub
      Public ReadOnly Property Importo() As Double
         Get
            Return Current.Quota.Importo
         End Get
      End Property
      Public ReadOnly Property Valuta() As String
         Get
            Return Moneta.GetTipoValutaToString(Current.Quota.GetValuta)
         End Get
      End Property
      Public Sub SetQuota(ByVal Importo As String)
         Try
            If Importo = "" Then Importo = 0
            If Not IsNumeric(Importo) Then Throw New Exception("Importo non corretto")
            Current.Quota = New Moneta(Importo, Moneta.Valuta.Euro)
            Ps.MarkDirty(m_current)
         Catch ex As Exception
            Throw New Exception("Impossibile impostare l'importo della vertenza" & vbCrLf & ex.Message)
         End Try
      End Sub
      Public ReadOnly Property DataInizioPeriodo() As DateTime
         Get
            Return Current.PeriodoVertenza.Start
         End Get
      End Property
      Public ReadOnly Property DataFinePeriodo() As DateTime
         Get
            Return Current.PeriodoVertenza.Finish
         End Get
      End Property
      Public Sub SetPeriodoVertenza(ByVal DataInizio As DateTime, ByVal DataFine As DateTime)
         Dim datar As New DataRange(DataInizio, DataFine)
         Current.PeriodoVertenza = datar
         Ps.MarkDirty(m_current)
      End Sub

#End Region

#Region "Metodi per l'aggiunta e la rimozione degli istituti"
      Public Sub AddIstituto(ByVal DescrizioneIstituto As String)
         Try
            Dim ist As IstitutoContrattuale = controllerIstituti.GetCausaleById(controllerIstituti.GetIdByDescrizione(DescrizioneIstituto))
            Current.AddIstitutoContrattuale(ist)
            Ps.MarkDirty(m_current)
         Catch ex As Exception
            Throw New Exception(ex.Message)
         End Try
      End Sub
      Public Sub RemoveIstituto(ByVal Istituto As String)
         Try
            Dim ist As IstitutoContrattuale = controllerIstituti.GetCausaleById(controllerIstituti.GetIdByDescrizione(Istituto))
            Current.RemoveIstituto(ist)
            Ps.MarkDirty(m_current)
         Catch ex As Exception
            Throw New Exception("Impossibile rimuovere un nuovo istituto contrattuale" & vbCrLf & ex.Message)
         End Try
      End Sub
      Public Function GetListaIstituti() As ArrayList
         Dim li As New ArrayList
         For Each elem As IstitutoContrattuale In Current.ListaItituti
            li.Add(elem.Descrizione)
         Next
         Return li
      End Function
      Public Sub ClearListaIstituti()
         Current.ClearListaIstituti()
      End Sub
#End Region

#Region "Metodi per la gestione degli eventi"
      Public Sub SelectEvento(ByVal DataEvento As DateTime, ByVal TipologiaEvento As String)
         For Each elem As Evento In Current.ListaEventi
            If elem.DataRegistrazione = DataEvento And UCase(TipoEvento.GetTipoEventoToString(elem.TipoEvento.Tipo)) = TipologiaEvento Then
               m_CurrentEvento = elem
               Return
            End If
         Next
         Throw New Exception("Non è stato selezionato nessun evento")
      End Sub
      ''' <summary>
      ''' Metodo che consente di aggiungere un evento alla vertenza corrente
      ''' </summary>
      ''' <param name="TipologiaEvento">I parametri possibili sono all'interno della lista di stringhe  presenti nella
      ''' lista restituita dal metodo GetListaProcedimenti della classe TipoEvento</param>
      ''' <param name="Intervento"></param>
      ''' <param name="Avvocato"></param>
      ''' <param name="Ente_Inoltro"></param>
      ''' <param name="DataEvento"></param>
      ''' <param name="Note"></param>
      ''' <remarks></remarks>
      Public Sub AddEvento(ByVal TipologiaEvento As String, ByVal Intervento As String, ByVal Avvocato As String, ByVal Ente_Inoltro As String, _
                           ByVal DataEvento As DateTime, ByVal Note As String, ByVal PathDocumento As String)
         'TipoEventoFactory.Instance.EnteInoltro = Ente_Inoltro
         'TipoEventoFactory.Instance.Avvocato = Avvocato
         'TipoEventoFactory.Instance.Intervento = Intervento
         'Dim tipo As TipoEvento = TipoEventoFactory.Instance.GetTipoEvento(TipoEvento.GetTipoEventoByDescrizione(TipologiaEvento))
         Dim tipo As TipoEvento = New TipoEvento()
         tipo.Tipo = TipoEvento.GetTipoEventoByDescrizione(TipologiaEvento)
         tipo.InterventoRichiesto = Intervento
         tipo.Avvocato = Avvocato
         tipo.EnteInoltro = Ente_Inoltro

         Dim evento As New Evento(DataEvento, Note, tipo)
         If My.Computer.FileSystem.FileExists(PathDocumento) Then
            evento.Path_Documento = PathDocumento
         Else
            evento.Path_Documento = ""
         End If
         Current.AddEvento(evento)
         Ps.MarkNew(evento)
      End Sub
      Public Sub RemoveEvento(ByVal DataEvento As DateTime, ByVal TipologiaEvento As String)
         For Each elem As Evento In Current.ListaEventi
            If elem.DataRegistrazione = DataEvento And UCase(TipoEvento.GetTipoEventoToString(elem.TipoEvento.Tipo)) = TipologiaEvento Then
               Current.RemoveEvento(elem)
               Ps.MarkRemoved(elem)
               Return
            End If
         Next
      End Sub
      Public Function GetListaEventi() As IList
         Return Current.ListaEventi
      End Function
#End Region

#Region "Proprietà evento corrente"
      Public Property DataEvento() As DateTime
         Get
            Return m_CurrentEvento.DataRegistrazione
         End Get
         Set(ByVal value As DateTime)
            m_CurrentEvento.DataRegistrazione = value
            Ps.MarkDirty(m_CurrentEvento)
         End Set
      End Property
      Public Property NoteEvento() As String
         Get
            Return m_CurrentEvento.Note
         End Get
         Set(ByVal value As String)
            m_CurrentEvento.Note = value
            Ps.MarkDirty(m_CurrentEvento)
         End Set
      End Property
      Public ReadOnly Property DescrizioneTipoEvento() As String
         Get
            Return TipoEvento.GetTipoEventoToString(m_CurrentEvento.TipoEvento.Tipo)
         End Get
      End Property
      Public Sub SetTipoEvento(ByVal TipologiaEvento As String)
         m_CurrentEvento.TipoEvento = New TipoEvento
         m_CurrentEvento.TipoEvento.Tipo = TipoEvento.GetTipoEventoByDescrizione(TipologiaEvento)
         Ps.MarkDirty(m_CurrentEvento)
      End Sub
      'Public Property Avvocato() As String
      '   Get
      '      Return m_CurrentEvento.TipoEvento.Avvocato
      '   End Get
      '   Set(ByVal value As String)
      '      m_CurrentEvento.TipoEvento.Avvocato = value
      '   End Set
      'End Property


      Public Property PathDocumento() As String
         Get
            Return m_CurrentEvento.Path_Documento
         End Get
         Set(ByVal value As String)
            If My.Computer.FileSystem.FileExists(value) Then
               m_CurrentEvento.Path_Documento = value
            Else
               m_CurrentEvento.Path_Documento = ""
            End If
         End Set
      End Property


      Public Property Intervento() As String
         Get
            Return m_CurrentEvento.TipoEvento.InterventoRichiesto
         End Get
         Set(ByVal value As String)
            m_CurrentEvento.TipoEvento.InterventoRichiesto = value
         End Set
      End Property
      Public Property EnteInoltro() As String
         Get
            Return m_CurrentEvento.TipoEvento.EnteInoltro
         End Get
         Set(ByVal value As String)
            m_CurrentEvento.TipoEvento.EnteInoltro = value
         End Set
      End Property
      Public Function GetListaTipiEvento() As ArrayList
         Return TipoEvento.GetListaTipi
      End Function
#End Region


      Public Overrides Function GetCategoryObject() As String
         Return "Vertenza"
      End Function
      Friend Function GetVertenzaById(ByVal Id As String) As Vertenza
         If Id = -1 Then Return New VertenzaNulla
         Me.LoadById(Id)
         Return Current()
      End Function
      Public Sub LoadAllByUtente(ByVal IdUtente As String)
         If Not IsNumeric(IdUtente) Then Throw New Exception("Id Utente errato.")
         Dim query As Query = Ps.CreateNewQuery("MapperVertenza")
         Dim mainCriteria As Criteria = Criteria.Equal("ID_UTENTE", IdUtente)
         query.AddWhereClause(mainCriteria)
         DomainObjectList = query.Execute(Ps)
      End Sub
      Public Function GetVertenzeByUtente(ByVal IdUtente As String) As IList
         LoadAllByUtente(IdUtente)
         Return DomainObjectList
      End Function
      Public Overrides Sub CreateNew()
         m_current = New Vertenza
         Ps.MarkNew(m_current)
      End Sub
      ''' <summary>
      ''' Metodo che crea un oggetto vertenza e lo inserisce nella base dati
      ''' </summary>
      ''' <param name="DataDocumento"></param>
      ''' <param name="DataRegistrazione"></param>
      ''' <param name="Note"></param>
      ''' <param name="IdUtente"></param>
      ''' <param name="IdReferente"></param>
      ''' <param name="IdRup"></param>
      ''' <param name="Quota"></param>
      ''' <param name="IdAzienda"></param>
      ''' <param name="Data_Inizio"></param>
      ''' <param name="Data_Fine"></param>
      ''' <remarks></remarks>
      Public Overloads Sub CreateNew(ByVal DataDocumento As DateTime, ByVal DataRegistrazione As DateTime, ByVal Note As String, ByVal IdUtente As String, ByVal IdReferente As String, ByVal IdRup As String, ByVal Quota As String, ByVal IdAzienda As String, ByVal Data_Inizio As DateTime, ByVal Data_Fine As DateTime)
         Try
            If IdReferente = "" Then IdReferente = -1
            If IdRup = "" Then IdRup = -1
            If Quota = "" Then Quota = 0
            If Not IsNumeric(IdUtente) Then Throw New Exception("L'id utente  non ha un formato corretto!")
            If Not IsNumeric(IdReferente) Then Throw New Exception("L'id referente non ha un formato corretto!")
            If Not IsNumeric(IdRup) Then Throw New Exception("L'id del Rup non ha un formato corretto!")
            If Not IsNumeric(Quota) Then Throw New Exception("L'importo della vertenza non ha un formato corretto!")
            If Not IsNumeric(IdAzienda) Then Throw New Exception("L'id dell'azienda controparte non ha un formato corretto!")


            Dim periodo As DataRange = New DataRange(Data_Inizio, Data_Fine)
            Dim utente As Utente = ControllerUtenti.GetUtenteById(IdUtente)
            Dim referente As Referente = controllerReferenti.GetReferenteById(IdReferente)
            Dim rup As Referente = controllerReferenti.GetReferenteById(IdRup)
            Dim azienda As Azienda = ControllerAziende.GetAziendaById(IdAzienda)




            Dim Vertenza As Vertenza = New Vertenza(DataDocumento, DataRegistrazione, Note, utente, referente, rup, New Moneta(Quota, Moneta.Valuta.Euro), azienda, periodo)
            m_current = Vertenza
            Ps.InsertObject("Vertenza", m_current)
         Catch ex As Exception
            Throw New Exception("Impossibile creare una nuova vertenza." & vbCrLf & ex.Message)
         End Try
      End Sub
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

   End Class
End Namespace