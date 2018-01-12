Public Class MapperPrestazioneDTO
   Inherits AbstractRDBMapper

   Public Sub New()
      'MyBase.Cache = New PersistentObjectCache(True)
   End Sub

#Region "Istruzioni Sql"




   Protected Overrides Function FindAllStatement() As String
      Return "Select * from DB_PRESTAZIONI_UTENTE "
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

      Dim NOTE As String = IIf(rs("NOTE_DOC") IsNot Nothing, rs("NOTE_DOC"), "")

      Dim ID_UTENTE As Int32 = IIf(rs("ID_UTENTE") IsNot Nothing, rs("ID_UTENTE"), -1)
      Dim UTENTE As String = IIf(rs("NOME_UTENTE") IsNot Nothing, rs("NOME_UTENTE"), "")

      Dim ID_REFERENTE As String = IIf(rs("ID_REFERENTE") IsNot Nothing, rs("ID_REFERENTE"), "")
      Dim REFERENTE As String = IIf(rs("NOME_COLLABORATORE") IsNot Nothing, rs("NOME_COLLABORATORE"), "")

      Dim NOME_TIPO_PRESTAZIONE As String = IIf(rs("NOME_TIPO_PRESTAZIONE") IsNot Nothing, rs("NOME_TIPO_PRESTAZIONE"), "")


      Dim q As New PrestazioneDTO
      q.Key = Key

      q.DataDocumento = DATA_DOCUMENTO
      q.DataRegistrazione = DATA_REGISTRAZIONE
      q.IdReferente = ID_REFERENTE
      q.Referente = REFERENTE
      q.Utente = UTENTE
      q.IdUtente = ID_UTENTE
      q.Note = NOTE
      q.TipoPrestazione = NOME_TIPO_PRESTAZIONE



      Return q



   End Function

#End Region


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
