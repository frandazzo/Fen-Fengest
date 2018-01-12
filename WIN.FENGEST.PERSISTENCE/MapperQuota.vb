Public Class MapperQuota
   Inherits AbstractRDBMapper
 
   Public Sub New()
      'MyBase.Cache = New PersistentObjectCache(True)
   End Sub

#Region "Istruzioni Sql"
  



   Protected Overrides Function FindAllStatement() As String
      Return "Select * from DB_QUOTE_UTENTE "
   End Function
   Protected Overrides Function FindByKeyStatement() As String
      Return ""
   End Function
   Protected Overrides Function InsertStatement() As String
      Return ""
   End Function
   Protected Overrides Function UpdateStatement() As String
      Return ""
   End Function
   'la cancellazione di un insieme di posizioni legate ad un PagamentoItem avverrà tramite cancellazione a cascata
   'del PagamentoItem. Verrà impostata una relazione su DB con queste opzioni
   Protected Overrides Function DeleteStatement() As String
      Return ""
   End Function
   Protected Overrides Function FindNextKeyStatement() As String
      Return ""
   End Function
#End Region





#Region "Metodi per il caricamento dell'oggetto"

   
   Private Function CalculateCompetenza(ByVal Di As DateTime, ByVal Df As DateTime) As AbstractPeriodo
      Dim competenza As AbstractPeriodo
      If Di = DateTime.MinValue Or Df = DateTime.MinValue Then
         competenza = New PeriodoNullo
      Else
         competenza = New CompositePeriodo(New DataRange(Di, Df), 0)
      End If
      Return competenza
   End Function
   Protected Overloads Overrides Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable) As AbstractPersistenceObject




      Dim DATA_REGISTRAZIONE As DateTime = IIf(rs("DATA_REGISTRAZIONE") IsNot Nothing, rs("DATA_REGISTRAZIONE"), DateTime.MinValue)
      Dim DATA_DOCUMENTO As DateTime = IIf(rs("DATA_DOCUMENTO") IsNot Nothing, rs("DATA_DOCUMENTO"), DateTime.MinValue)
      Dim NOTE As String = IIf(rs("NOTE_ITEM") IsNot Nothing, rs("NOTE_ITEM"), "")
      Dim DI As DateTime = IIf(rs("DATA_INIZIO_COMP") IsNot Nothing, rs("DATA_INIZIO_COMP"), DateTime.MinValue)
      Dim DF As DateTime = IIf(rs("DATA_FINE_COMP") IsNot Nothing, rs("DATA_FINE_COMP"), DateTime.MinValue)
      Dim IMP As Double = IIf(rs("IMPORTO") IsNot Nothing, rs("IMPORTO"), 0)
      Dim IMP_RIST As Double = IIf(rs("IMPORTO_RISTORNATO") IsNot Nothing, rs("IMPORTO_RISTORNATO"), 0)
      'Dim VALUTA As Moneta.Valuta = IIf(rs("VALUTA") IsNot Nothing, rs("VALUTA"), Moneta.Valuta.Euro)
      Dim ID_AZIENDA As Int32 = IIf(rs("ID_AZIENDA") IsNot Nothing, rs("ID_AZIENDA"), -1)
      Dim AZIENDA As String = IIf(rs("NOME_AZIENDA") IsNot Nothing, rs("NOME_AZIENDA"), "")
      Dim ID_UTENTE As Int32 = IIf(rs("ID_UTENTE") IsNot Nothing, rs("ID_UTENTE"), -1)
      Dim UTENTE As String = IIf(rs("NOME_UTENTE") IsNot Nothing, rs("NOME_UTENTE"), "")
      Dim ID_REFERENTE As String = IIf(rs("ID_REFERENTE") IsNot Nothing, rs("ID_REFERENTE"), "")
      Dim REFERENTE As String = IIf(rs("NOME_REFERENTE") IsNot Nothing, rs("NOME_REFERENTE"), "")
      Dim TR As Boolean = IIf(rs("TREDICESIMA") IsNot Nothing, rs("TREDICESIMA"), False)
      Dim QU As Boolean = IIf(rs("QUATTORDICESIMA") IsNot Nothing, rs("QUATTORDICESIMA"), False)
      Dim TIPO_DOCUMENTO As String = IIf(rs("TIPO_DOCUMENTO_CONTABILE") IsNot Nothing, rs("TIPO_DOCUMENTO_CONTABILE"), "")
      Dim ID_PGR As String = IIf(rs("ID_PAGAMENTO_REFERENTE") IsNot Nothing, rs("ID_PAGAMENTO_REFERENTE"), "")
      Dim ID_SETTORE As Int32 = IIf(rs("ID_SETTORE") IsNot Nothing, rs("ID_SETTORE"), -1)
      Dim SETTORE As String = IIf(rs("DESCRIZIONE_SETTORE") IsNot Nothing, rs("DESCRIZIONE_SETTORE"), "")
      Dim ID_AZIENDA_IMPIEGO As Int32 = IIf(rs("ID_AZIENDA_IMPIEGO") IsNot Nothing, rs("ID_AZIENDA_IMPIEGO"), -1)
      Dim AZIENDA_IMPIEGO As String = IIf(rs("NOME_AZIENDA_IMPIEGO") IsNot Nothing, rs("NOME_AZIENDA_IMPIEGO"), "")
      Dim ID_TIPO_CONTRATTO As Int32 = IIf(rs("ID_TIPO_CONTRATTO") IsNot Nothing, rs("ID_TIPO_CONTRATTO"), -1)
      Dim CONTRATTO As String = IIf(rs("NOME_CONTRATTO") IsNot Nothing, rs("NOME_CONTRATTO"), "")
      Dim ORE_LAVORATE As Double = IIf(rs("ORE_LAVORATE") IsNot Nothing, rs("ORE_LAVORATE"), 0)
      Dim ORE_MALATTIA As Double = IIf(rs("ORE_MALATTIA") IsNot Nothing, rs("ORE_MALATTIA"), 0)
      Dim LIVELLO_INQUADRAMENTO As String = IIf(rs("LIVELLO_INQUADRAMENTO") IsNot Nothing, rs("LIVELLO_INQUADRAMENTO"), "")
      Dim NOME_SEDE_OPERATIVA As String = IIf(rs("NOME_SEDE_OPERATIVA") IsNot Nothing, rs("NOME_SEDE_OPERATIVA"), "")
      Dim ID_PRESTAZIONE As String = IIf(rs("ID_PRESTAZIONE") IsNot Nothing, rs("ID_PRESTAZIONE"), "")
      Dim TIPO_PRESTAZIONE As String = IIf(rs("NOME_TIPO_PRESTAZIONE") IsNot Nothing, rs("NOME_TIPO_PRESTAZIONE"), "")
      Dim ID_VERTENZA As String = IIf(rs("ID_VERTENZA") IsNot Nothing, rs("ID_VERTENZA"), "")
      Dim ID_DOCUMENTO_CONTABILE As Int32 = IIf(rs("ID_DOCUMENTO_CONTABILE") IsNot Nothing, rs("ID_DOCUMENTO_CONTABILE"), -1)
        Dim cf As String = IIf(rs("CODICE_FISCALE") IsNot Nothing, rs("CODICE_FISCALE"), "")

        Dim DATA_NASCITA As DateTime = IIf(rs("DATA_NASCITA") IsNot Nothing, rs("DATA_NASCITA"), DateTime.MinValue)
        Dim NOME As String = IIf(rs("NOME") IsNot Nothing, rs("NOME"), "")
        Dim COGNOME As String = IIf(rs("COGNOME") IsNot Nothing, rs("COGNOME"), "")
        Dim INDIRIZZO As String = IIf(rs("INDIRIZZO") IsNot Nothing, rs("INDIRIZZO"), "")
        Dim CAP As String = IIf(rs("CAP") IsNot Nothing, rs("CAP"), "")
        Dim NOME_PROVINCIA As String = IIf(rs("NOME_PROVINCIA") IsNot Nothing, rs("NOME_PROVINCIA"), "")
        Dim NOME_COMUNE As String = IIf(rs("NOME_COMUNE") IsNot Nothing, rs("NOME_COMUNE"), "")
        Dim NOME_PROVINCIA_NASCITA As String = IIf(rs("NOME_PROVINCIA_NASCITA") IsNot Nothing, rs("NOME_PROVINCIA_NASCITA"), "")
        Dim NOME_COMUNE_NASCITA As String = IIf(rs("NOME_COMUNE_NASCITA") IsNot Nothing, rs("NOME_COMUNE_NASCITA"), "")

        Dim q As New Quota


        q.DataNascita = DATA_NASCITA
        q.Nome = NOME
        q.Cognome = COGNOME
        q.Indirizzo = INDIRIZZO
        q.Cap = CAP
        q.Comune = NOME_COMUNE
        q.Provincia = NOME_PROVINCIA
        q.ProvinciaNascita = NOME_PROVINCIA_NASCITA
        q.ComuneNascita = NOME_COMUNE_NASCITA



      q.Key = Key
      q.AziendaImpiego = AZIENDA_IMPIEGO
      q.Competenza = CalculateCompetenza(DI, DF)
      q.ContrattoApplicato = CONTRATTO
      q.DocumentoPadre = ID_DOCUMENTO_CONTABILE
      'q.GetQuotaMedia 
      q.IdAziendaImpiego = ID_AZIENDA_IMPIEGO
      q.IdContrattoApplicato = ID_TIPO_CONTRATTO
      q.IdPrestazione = ID_PRESTAZIONE
      q.IdReferente = ID_REFERENTE
        q.IdSettore = ID_SETTORE
        q.CodiceFiscale = cf
      Select Case ID_SETTORE
         Case 1 'settore IF

            q.SoggettoEsecutore = AZIENDA
         Case 2 'Settore E
            If ID_AZIENDA = 1 Then
               q.SoggettoEsecutore = "CASSA EDILE"
            Else
               q.SoggettoEsecutore = "EDILCASSA"
            End If
         Case -1 'Settore nullo
            q.SoggettoEsecutore = AZIENDA
      End Select

      If TIPO_DOCUMENTO = "IQI" Then
         q.SoggettoEsecutore = "INPS"
      End If

      q.DataDocumento = DATA_DOCUMENTO
      q.DataRegistrazione = DATA_REGISTRAZIONE
      q.Settore = SETTORE
      q.IdSoggettoEsecutore = ID_AZIENDA
      q.IdUtente = ID_UTENTE
      q.IdVertenza = ID_VERTENZA
      q.Importo = IMP
      q.ImportoRistorno = IMP_RIST
      q.LivelloInquadramento = LIVELLO_INQUADRAMENTO
      q.Note = NOTE
      q.OreLavorate = ORE_LAVORATE
      q.OreMalattia = ORE_MALATTIA
      q.PagamentoReferente = ID_PGR

      q.Quattordicesima = QU
      q.Referente = REFERENTE
      q.SedeOperativa = NOME_SEDE_OPERATIVA
      q.TipoDocumento = TIPO_DOCUMENTO

      q.TipoPrestazione = TIPO_PRESTAZIONE
      q.Tredicesima = TR
      q.Utente = UTENTE
      q.IdVertenza = ID_VERTENZA


      Return q



   End Function
   Protected Overrides Function Load(ByVal rs As Hashtable) As AbstractPersistenceObject

      Dim key As Key = CreateKey(rs)
      ' If Cache.GetObjectFromCache(key.ToString) IsNot Nothing Then Return DirectCast(Cache.GetObjectFromCache(key.ToString), AbstractPersistenceObject)
      Dim obj As AbstractPersistenceObject = DoLoad(key, rs)
      ' Cache.AddToCache(obj)
      Return obj

   End Function
   'Protected Overloads Function Load(ByVal rs As Hashtable, ByVal Documento As DocumentoContabile) As AbstractPersistenceObject

   '   Dim key As Key = CreateKey(rs)
   '   If Cache.GetObjectFromCache(key.ToString) IsNot Nothing Then Return DirectCast(Cache.GetObjectFromCache(key.ToString), AbstractPersistenceObject)
   '   Dim obj As AbstractPersistenceObject = DoLoad(key, rs, Documento)
   '   Cache.AddToCache(obj)
   '   Return obj

   'End Function
#End Region


#Region "Metodi per la preparazione dei comandi"



   'Private Function PrepareCommandForItemsNotPaidToReferente(ByVal Referente As Referente) As IDbCommand
   '   Try
   '      Dim cmd As SqlClient1.SqlCommand = GetCommand(FindItemsIQANotPaidToReferentiStatement)
   '      LoadFindParameter(cmd, Referente)
   '      Return cmd
   '   Catch ex As Exception
   '      Throw New Exception(ex.Message)
   '   End Try
   'End Function
   

    'Protected Overrides Function GetCommand(ByVal CommandText As String) As System.Data.IDbCommand

    '   'Return New SqlClient1.SqlCommand(CommandText, DBConnectionManager.Instance.GetCurrentConnection)
    '   Return DBTypeUtils.GetCommand(Me.m_PersistentService.ServiceName, CommandText, DBConnectionManager.Instance.GetCurrentConnection)
    'End Function
#End Region

   'Protected Overloads Function LoadAll(ByVal rs As ArrayList, ByVal Documento As DocumentoContabile) As ArrayList
   '   Dim List As New ArrayList

   '   For Each elem As Hashtable In rs
   '      List.Add(Load(elem, Documento))
   '   Next
   '   Return List

   'End Function
   





#Region "Metodi per la ricerca"
   Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject
      Throw New Exception("Impossibile utilizzare il metodo di ricerca secondo l'identificati specificato per una posizione di pagamento. Metodo non implementato.")
   End Function
   Protected Overrides Function CreateKey(ByVal rs As System.Collections.Hashtable) As Key
      Return New Key(CInt(rs("ID")), CInt(rs("ID_DOCUMENTO_CONTABILE")))

   End Function
#End Region






#Region "Metodi per il caricamento dei parametri per i comandi"


   Protected Overrides Sub LoadInsertCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
     
   End Sub
   Protected Overrides Sub LoadUpdateCommandParameters(ByVal Item As AbstractPersistenceObject, ByVal Cmd As System.Data.IDbCommand)
      
   End Sub

#End Region

#Region "Metodi per l'inserimento"
   Public Overrides Function Insert(ByVal item As AbstractPersistenceObject) As Key

      Return Nothing

   End Function

   Protected Overloads Function FindNextKey(ByVal IdDocumento As Int32) As Key
      Return Nothing
   End Function



#End Region



End Class
