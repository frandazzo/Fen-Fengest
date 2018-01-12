Public Class MapperNonIscrittoDTO
   Inherits AbstractRDBMapper

   Public Sub New()
      'MyBase.Cache = New PersistentObjectCache(True)
   End Sub

#Region "Istruzioni Sql"




   Protected Overrides Function FindAllStatement() As String
      Return " "
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

   Protected Overrides Function Load(ByVal rs As Hashtable) As AbstractPersistenceObject



      Dim obj As AbstractPersistenceObject = DoLoad(Nothing, rs)

      Return obj

   End Function



#Region "Metodi per il caricamento dell'oggetto"

   Protected Overloads Overrides Function DoLoad(ByVal Key As Key, ByVal rs As System.Collections.Hashtable) As AbstractPersistenceObject







      Dim NOME_AZIENDA As String = IIf(rs("NOME_AZIENDA") IsNot Nothing, rs("NOME_AZIENDA"), "")



        Dim Ha_Delega As String = IIf(rs("HA_DELEGA_PRECEDENTE") IsNot Nothing, rs("HA_DELEGA_PRECEDENTE"), "")
        Dim ENTE As String = IIf(rs("NOME_ENTE") IsNot Nothing, rs("NOME_ENTE"), "")
        Dim UTENTE As String = IIf(rs("NOME_UTENTE") IsNot Nothing, rs("NOME_UTENTE"), "")
        Dim ID_UTENTE As Int32 = IIf(rs("ID_UTENTE") IsNot Nothing, rs("ID_UTENTE"), -1)
        Dim LIVELLO_INQUADRAMENTO As String = IIf(rs("LIVELLO") IsNot Nothing, rs("LIVELLO"), "")
        Dim ID_AZIENDA_IMPIEGO As Int32 = IIf(rs("ID_AZIENDA_IMPIEGO") IsNot Nothing, rs("ID_AZIENDA_IMPIEGO"), -1)
        Dim ID_ENTE As Int32 = IIf(rs("ID_ENTE") IsNot Nothing, rs("ID_ENTE"), -1)
        Dim LIBERO_AL As DateTime = rs("LIBERO_AL")
        Dim comune As String = IIf(rs("NOME_COMUNE") IsNot Nothing, rs("NOME_COMUNE"), "")
        Dim provincia As String = IIf(rs("NOME_PROVINCIA") IsNot Nothing, rs("NOME_PROVINCIA"), "")
        Dim nazione As String = IIf(rs("NAZIONE") IsNot Nothing, rs("NAZIONE"), "")

        Dim codice As String = IIf(rs("CODICE_FISCALE") IsNot Nothing, rs("CODICE_FISCALE"), "")
        Dim iscritto As String = IIf(rs("ISCRITTO_A") IsNot Nothing, rs("ISCRITTO_A"), "")

        Dim c1 As String = IIf(rs("CELL1") IsNot Nothing, rs("CELL1"), "")
        Dim c2 As String = IIf(rs("CELL2") IsNot Nothing, rs("CELL2"), "")

        Dim q As New NonIscrittoDTO






        q.Codice_Fiscale = codice
        q.Cell1 = c1
        q.Cell2 = c2
        q.IscrittoA = iscritto
        q.Nome_Utente = UTENTE
        q.Id_Utente = ID_UTENTE
        q.Id_Ente = ID_ENTE
        q.Nome_Ente = ENTE
        q.Livello = LIVELLO_INQUADRAMENTO
        q.Nome_Azienda = NOME_AZIENDA
        q.Id_Azienda_Impiego = ID_AZIENDA_IMPIEGO
        q.Ha_Delega_Precedente = Ha_Delega
        q.Libero_Al = LIBERO_AL
        q.Nome_Comune = comune
        q.Nome_Nazione = nazione
        q.Nome_Provincia = provincia
        'q.Libero_Al = LIBERO_AL
        'q.Nome_Ente



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
      Return Nothing

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
