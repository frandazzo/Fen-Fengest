Imports WIN.APPLICATION.REPORTING

Namespace ADMINISTRATION
    Public Class ControllerBozzaDelega
        Inherits AbstractController
        Private ControllerReferenti As New FINANCIAL_ARTIFACTS.ControllerReferenti
        Private ControllerUtenti As New UTENTI.ControllerUtenti


        Public Function Current() As BozzaDelega
            Return DirectCast(MyBase.m_current, BozzaDelega)
        End Function
#Region "Proprietà oggetto"

        Public Sub SetCurrent(bozza As BozzaDelega)
            MyBase.m_current = bozza
        End Sub

        Public ReadOnly Property IdUtente() As Int32
            Get
                Return Current.Utente.Key.LongValue
            End Get
        End Property
        Public ReadOnly Property IdReferente() As String
            Get
                If Current.Referente Is Nothing Then
                    Return ""
                End If
                If Current.Referente.Key.LongValue = -1 Then Return ""
                Return Current.Referente.Key.LongValue
            End Get
        End Property


        Public Property Ente() As String
            Get
                Return Current.Ente
            End Get
            Set(value As String)
                Current.Ente = value
            End Set
        End Property

        Public Sub SetReferente(ByVal IdReferente As String)

            If IdReferente = "" Then IdReferente = -1
            If Not IsNumeric(IdReferente) Then Throw New Exception("Il valore dell'id del collaboratore immesso non ha un formato corretto. Inserire un id valido")
            Current.Referente = ControllerReferenti.GetReferenteById(IdReferente)

        End Sub

        Public Property DataRegistrazione() As DateTime
            Get
                Return Current.Data
            End Get
            Set(ByVal value As DateTime)
                Current.Data = value
            End Set
        End Property

        Public Sub SetUtente(ByVal IdUtente As String)
            If Not IsNumeric(IdUtente) Then
                Return
            End If
            Current.Utente = ControllerUtenti.GetUtenteById(IdUtente)
        End Sub

        Public ReadOnly Property IdDelega() As Int32
            Get
                Return Current.Key.LongValue
            End Get
        End Property

        Public ReadOnly Property DescrizioneUtente() As String
            Get
                Return Current.Utente.CompleteName
            End Get
        End Property






        Public ReadOnly Property DescrizioneReferente() As String
            Get
                If Current.Referente Is Nothing Then
                    Return ""
                End If
                Return Current.Referente.CompleteName
            End Get
        End Property


#End Region



#Region "Metodi CRUD"
        Public Overrides Function GetCategoryObject() As String
            Return "BozzaDelega"
        End Function
        ''' <summary>
        ''' Metodo non implementato
        ''' </summary>
        ''' <remarks></remarks>
        Public Overrides Sub CreateNew()
            MyBase.m_current = New BozzaDelega

        End Sub




        Protected Overrides Sub DoUpdate()


            Ps.UpdateObject("BozzaDelega", m_current)

        End Sub




#End Region

        Public Sub GeneraDeleghe(ente As String, range As DataRange)

            'creo il nome del file per il log
            Dim FileLogName As String = "ImportBozzeDelega" & Now.ToString("ddMMyyyy")

            FileLogName = IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), FileLogName + ".txt")

            'per prima cosa recupero la lista delle bozze da filtrare
            Dim c As New ControllerRicercheBozzaDelega

            c.SetCompetenza(range.Start, range.Finish)
            c.SetEnte(ente)
            Dim result As IList = c.Search

            If result.Count = 0 Then
                Throw New Exception("Nessuna bozza delega trovata")
            End If

            'a questo punto posso filtrare la lista ottenuta prendendo una delega per ciascun utente

            Dim filtered As IList = FilterData(result)

            Dim counter As Int32 = 1
            'ho ottenuto la lista delle bozze da eliminare e da trasformare in deleghe
            For Each elem As BozzaDelega In filtered
                My.Computer.FileSystem.WriteAllText(FileLogName, "Inizio importazione deleghe : " & DateTime.Now.ToString & " deleghe!" & vbCrLf & vbCrLf, True)
                My.Computer.FileSystem.WriteAllText(FileLogName, "Saranno create : " & filtered.Count & " deleghe!" & vbCrLf & vbCrLf, True)

                Try
                     'qui devo creare una nuova delega, cancellare la bozza e scrivere sul file di log ciò che è stato fatto
                    CreateDelega(elem, FileLogName)
                    DeleteBozza(elem, FileLogName)
                    counter = counter + 1
                Catch ex As Exception
                    My.Computer.FileSystem.WriteAllText(FileLogName, "Si è verificato un errore : " & ex.Message & vbCrLf & vbCrLf, True)
                    My.Computer.FileSystem.WriteAllText(FileLogName, "Errore per l'operazione num. : " & counter.ToString & vbCrLf & vbCrLf, True)
                    My.Computer.FileSystem.WriteAllText(FileLogName, "L'importazione viene terminata e non sarà conclusa " & vbCrLf & vbCrLf, True)
                    Throw
                End Try

            Next
        End Sub

        Private Sub DeleteBozza(Bozza As BozzaDelega, log As String)
            Ps.DeleteObject("BozzaDelega", Bozza)
            My.Computer.FileSystem.WriteAllText(log, "Cancellazione della bozza delega di : " & Bozza.Utente.CompleteName & "; Data bozza: " & Bozza.Data.ToShortDateString & vbCrLf & vbCrLf, True)
        End Sub

        Private Sub CreateDelega(elem As BozzaDelega, log As String)

            Dim controller As New ControllerDeleghe
            controller.CreateNew(DateTime.Now, elem.Data, "", _
                                              elem.Utente.Id, GetIdReferente(elem), GetIdEnteForEdili(elem.Ente), GetIdSettore("EDILE"), _
                                              Nothing, "1", GetIdReferente(elem), "")
            controller.DataImportazione = DateTime.Now.Date
            controller.Save()
            'loggo il dato
            My.Computer.FileSystem.WriteAllText(log, "Creazione  delega per : " & elem.Utente.CompleteName & "; Data bozza: " & elem.Data.ToShortDateString & vbCrLf & vbCrLf, True)

        End Sub

        Private Function GetIdReferente(BozzaDelega As BozzaDelega) As String
            Dim idRef As String = ""
            If Not BozzaDelega.Referente Is Nothing Then
                idRef = BozzaDelega.Referente.Id
            End If
            Return idRef
        End Function


        Private Function GetIdSettore(nome As String) As Int32
            Dim c As New ControllerSettori
            Return c.GetIdSettoreByDescrizione(nome)
        End Function

        Private Function GetIdEnteForEdili(ByVal nome) As Int32
            Dim idEnte As Int32
            If nome = "CASSA EDILE" Then
                idEnte = 1
            ElseIf nome = "EDILCASSA" Then
                idEnte = 2
            Else
                Throw New Exception("Ente non definito: utilizzare le descrizioni --CASSA EDILE oppure EDILCASSA--)")
            End If

            Return idEnte
        End Function


        Private Function FilterData(list As IList) As IList

            Dim result As IList = New ArrayList
            Dim h As New Hashtable

            For Each elem As BozzaDelega In list
                'se contiene l'id dell'utente
                If Not h.ContainsKey(elem.Utente.Id) Then
                    result.Add(elem)
                    h.Add(elem.Utente.Id, elem)
                End If
            Next

            Return result

        End Function

       


    End Class
End Namespace