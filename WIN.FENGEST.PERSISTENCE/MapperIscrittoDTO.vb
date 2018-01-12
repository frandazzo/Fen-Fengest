Public Class MapperIscrittoDTO
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






        Dim DI As DateTime = IIf(rs("DataIn") IsNot Nothing, rs("DataIn"), DateTime.MinValue)
        Dim DF As DateTime = IIf(rs("DataFin") IsNot Nothing, rs("DataFin"), DateTime.MinValue)
        Dim DN As DateTime = IIf(rs("DATA_NASCITA") IsNot Nothing, rs("DATA_NASCITA"), DateTime.Now)
        Dim Nome As String = IIf(rs("NOME") IsNot Nothing, rs("NOME"), "")
        Dim Cognome As String = IIf(rs("COGNOME") IsNot Nothing, rs("COGNOME"), "")


        Dim AZIENDA_IMPIEGO As String = IIf(rs("AziendaImpiego") IsNot Nothing, rs("AziendaImpiego"), "")
        Dim CAUSALE As String = IIf(rs("Causale") IsNot Nothing, rs("Causale"), "")
        Dim CONTRATTO As String = IIf(rs("Contratto") IsNot Nothing, rs("Contratto"), "")
        Dim ID_AZIENDA_IMPIEGO As Int32 = IIf(rs("Id_Azienda_Impiego") IsNot Nothing, rs("Id_Azienda_Impiego"), -1)
        Dim ID_UTENTE As Int32 = IIf(rs("Id_Utente") IsNot Nothing, rs("Id_Utente"), -1)
        Dim LIVELLO_INQUADRAMENTO As String = IIf(rs("Livello") IsNot Nothing, rs("Livello"), "")
        Dim SETTORE As String = IIf(rs("Settore") IsNot Nothing, rs("Settore"), "")
        Dim TIPO_DOCUMENTO As String = IIf(rs("TipoDoc") IsNot Nothing, rs("TipoDoc"), "")
        Dim UTENTE As String = IIf(rs("Utente") IsNot Nothing, rs("Utente"), "")
        Dim TIPO_PRESTAZIONE As String = IIf(rs("TipoPrestazione") IsNot Nothing, rs("TipoPrestazione"), "")
        Dim ID_REFERENTE As Int32 = IIf(rs("Id_Referente") IsNot Nothing, rs("Id_Referente"), -1)
        Dim comune As String = IIf(rs("NOME_COMUNE") IsNot Nothing, rs("NOME_COMUNE"), "")
        Dim provincia As String = IIf(rs("NOME_PROVINCIA") IsNot Nothing, rs("NOME_PROVINCIA"), "")
        Dim nazione As String = IIf(rs("NAZIONE") IsNot Nothing, rs("NAZIONE"), "")

        Dim INDIRIZZO As String = IIf(rs("INDIRIZZO") IsNot Nothing, rs("INDIRIZZO"), "")
        Dim CELL1 As String = IIf(rs("CELL1") IsNot Nothing, rs("CELL1"), "")
        Dim CELL2 As String = IIf(rs("CELL2") IsNot Nothing, rs("CELL2"), "")
        Dim Codice As String = IIf(rs("CODICE_FISCALE") IsNot Nothing, rs("CODICE_FISCALE"), "")
        Dim CAP As String = IIf(rs("CAP") IsNot Nothing, rs("CAP"), "")
        Dim comune_NASCITA As String = IIf(rs("NOME_COMUNE_NASCITA") IsNot Nothing, rs("NOME_COMUNE_NASCITA"), "")
        Dim provincia_NASCITA As String = IIf(rs("NOME_PROVINCIA_NASCITA") IsNot Nothing, rs("NOME_PROVINCIA_NASCITA"), "")
        Dim nome_ente As String = IIf(rs("ENTE") IsNot Nothing, rs("ENTE"), "")
        Dim importo As Double = IIf(rs("IMPORTO") IsNot Nothing, rs("IMPORTO"), 0)
        Dim ID_ENTE As Int32 = IIf(rs("ID_ENTE") IsNot Nothing, rs("ID_ENTE"), -1)



        Dim q As New IscrittoDTO
        q.Nome = Nome
        q.Cognome = Cognome
        q.DataNascita = DN
        q.Codice_Fiscale = Codice
        q.Competenza = CalculateCompetenza(DI, DF).ToString
        q.AziendaImpiego = AZIENDA_IMPIEGO
        q.Causale = CAUSALE
        q.Contratto = CONTRATTO
        q.Id_Azienda_Impiego = ID_AZIENDA_IMPIEGO
        q.Id_Utente = ID_UTENTE
        q.Livello = LIVELLO_INQUADRAMENTO
        q.Settore = SETTORE
        q.TipoDoc = TIPO_DOCUMENTO
        q.TipoPrestazione = TIPO_PRESTAZIONE
        q.Utente = UTENTE
        q.Id_Referente = ID_REFERENTE
        q.Nome_Comune = comune
        q.Nome_Nazione = nazione
        q.Nome_Provincia = provincia

        If SETTORE = "EDILE" Then
            If ID_ENTE = 1 Then
                q.NomeEnte = "CASSA EDILE"
            Else
                q.NomeEnte = "EDILCASSA"
            End If
        ElseIf SETTORE = "" Then
            q.NomeEnte = ""
        Else
            q.NomeEnte = nome_ente
        End If



        q.Indirizzo = INDIRIZZO
        q.Cell1 = CELL1
        q.Cell2 = CELL2
        q.Cap = CAP
        q.Importo = importo * -1
        q.Nome_Comune_Nascita = comune_NASCITA
        q.Nome_Provincia_Nascita = provincia_NASCITA
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
