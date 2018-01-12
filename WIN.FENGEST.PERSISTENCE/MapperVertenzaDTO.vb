Public Class MapperVertenzaDTO
   Inherits AbstractRDBMapper

   Public Sub New()
      'MyBase.Cache = New PersistentObjectCache(True)
   End Sub

#Region "Istruzioni Sql"




   Protected Overrides Function FindAllStatement() As String
      Return "Select * from DB_VERTENZE_UTENTE "
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

   Protected Overloads Overrides Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable) As AbstractPersistenceObject




      Dim DATA_REGISTRAZIONE As DateTime = rs("DATA_REGISTRAZIONE")
      Dim DATA_DOCUMENTO As DateTime = rs("DATA_DOCUMENTO")
      

      Dim NOTE As String = IIf(rs("NOTE_DEL") IsNot Nothing, rs("NOTE_DEL"), "")


      Dim ID_AZIENDA As Int32 = IIf(rs("ID_AZIENDA") IsNot Nothing, rs("ID_AZIENDA"), -1)
      Dim AZIENDA As String = IIf(rs("NOME_AZIENDA") IsNot Nothing, rs("NOME_AZIENDA"), "")


      Dim ID_UTENTE As Int32 = IIf(rs("ID_UTENTE") IsNot Nothing, rs("ID_UTENTE"), -1)
      Dim UTENTE As String = IIf(rs("NOME_UTENTE") IsNot Nothing, rs("NOME_UTENTE"), "")

     
      Dim ID_REFERENTE As String = IIf(rs("ID_REFERENTE") IsNot Nothing, rs("ID_REFERENTE"), "")
      Dim REFERENTE As String = IIf(rs("NOME_COLLABORATORE") IsNot Nothing, rs("NOME_COLLABORATORE"), "")

      Dim ID_RESPONSABILE As String = IIf(rs("ID_RUP") IsNot Nothing, rs("ID_RUP"), "")
      Dim RESPONSABILE As String = IIf(rs("NOME_RESPONSABILE") IsNot Nothing, rs("NOME_RESPONSABILE"), "")

      Dim DI As DateTime = IIf(rs("DATA_INIZIO") IsNot Nothing, rs("DATA_INIZIO"), DateTime.MinValue)
      Dim DF As DateTime = IIf(rs("DATA_FINE") IsNot Nothing, rs("DATA_FINE"), DateTime.MinValue)


      Dim ID_AVVOCATO As Int32 = IIf(rs("ID_AVVOCATO") IsNot Nothing, rs("ID_AVVOCATO"), -1)
      Dim AVVOCATO As String = IIf(rs("NOME_AVVOCATO") IsNot Nothing, rs("NOME_AVVOCATO"), "")

        Dim VertenzaChiusa As Boolean = IIf(rs("VertenzaChiusa") IsNot Nothing, rs("VertenzaChiusa"), False)


   

        Dim q As New VertenzaDTO
        q.Key = Key
        q.PeriodoVertenza = CalculateCompetenza(DI, DF).ToString

        q.DataDocumento = DATA_DOCUMENTO
        q.DataRegistrazione = DATA_REGISTRAZIONE
        q.IdReferente = ID_REFERENTE
        q.Referente = REFERENTE
        q.IdResponsabile = ID_RESPONSABILE
        q.Responsabile = RESPONSABILE
        q.Utente = UTENTE
        q.IdUtente = ID_UTENTE
        q.Azienda = AZIENDA
        q.IdAzienda = ID_AZIENDA
        q.IdAvvocato = ID_AVVOCATO
        q.Avvocato = AVVOCATO
        q.VertenzaChiusa = VertenzaChiusa
        q.Note = NOTE


      Return q



   End Function

#End Region
   Private Function CalculateCompetenza(ByVal Di As DateTime, ByVal Df As DateTime) As AbstractPeriodo
      Dim competenza As AbstractPeriodo
      If Di = DateTime.MinValue Or Df = DateTime.MinValue Then
         competenza = New PeriodoNullo
      Else
         competenza = New CompositePeriodo(New DataRange(Di, Df), 0)
      End If
      Return competenza
   End Function

#Region "Metodi per la preparazione dei comandi"




    'Protected Overrides Function GetCommand(ByVal CommandText As String) As System.Data.IDbCommand

    '   'Return New SqlClient1.SqlCommand(CommandText, DBConnectionManager.Instance.GetCurrentConnection)
    '   Return DBTypeUtils.GetCommand(Me.m_PersistentService.ServiceName, CommandText, DBConnectionManager.Instance.GetCurrentConnection)
    'End Function
#End Region



#Region "Metodi per la ricerca"
   Public Overrides Function FindObjectById(ByVal Id As Integer) As AbstractPersistenceObject
      Throw New Exception("Impossibile utilizzare il metodo di ricerca secondo l'identificati specificato per una posizione di pagamento. Metodo non implementato.")
   End Function
   Protected Overrides Function CreateKey(ByVal rs As System.Collections.Hashtable) As Key
      Return New Key(CInt(rs("ID")))

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
