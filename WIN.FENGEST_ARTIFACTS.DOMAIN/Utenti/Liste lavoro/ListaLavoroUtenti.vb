Public Class ListaLavoroUtenti
    Inherits AbstractPersistenceObject
    Private m_ListaUtenti As IList = New ArrayList

    Private m_HasAdded As Boolean



    Public ReadOnly Property HasAdded() As Boolean
        Get
            Return m_HasAdded
        End Get
    End Property
    Protected Overrides Sub DoValidation()
        If Me.Descrizione = "" Then
            ValidationErrors.Add("Descrizione mancante")
        End If

        If Me.ListaUtenti.Count = 0 Then
            ValidationErrors.Add("Inserire almeno un utente")
        End If
    End Sub

    Public Function GetExcelExporter(ByVal onlyAddressOk As Boolean, ByVal asLabel As Boolean) As ExcelExporterListaLavoro

        Dim e As New ExcelExporterListaLavoro(Me, onlyAddressOk, asLabel)

        Return e


    End Function


    Public Function GetListaDtosUtenti() As IList

        Dim l As New ArrayList

        For Each u As Utente In m_ListaUtenti
            l.Add(u.ToUtenteDTO)
        Next

        Return l

    End Function



    Public Function ToMetadataForEtichette() As IList(Of Hashtable)

        Dim h As New List(Of Hashtable)

        For Each elem As Utente In m_ListaUtenti
            Dim tagTable As New Hashtable
            tagTable = New Hashtable
            tagTable.Add("@Nome_Completo@", elem.Cognome + " " + elem.Nome)

            tagTable.Add("@ViaResidenza@", elem.Residenza.Via)
            tagTable.Add("@ComuneResidenza@", elem.Residenza.Comune.Descrizione)
            tagTable.Add("@ProvinciaResidenza@", elem.Residenza.Provincia.Sigla)
            tagTable.Add("@CapRes@", elem.Residenza.Cap)
            h.Add(tagTable)
        Next


        Return h

    End Function


    Public Function ListaUtentiOrdinataPerCognome() As ArrayList

        Dim lst As New ArrayList


        lst.AddRange(m_ListaUtenti)


        lst.Sort(New UtenteComparer("Cognome"))


        Return lst
    End Function


    ''' <summary>
    ''' Non utilizzare la proporietà set. 
    ''' Per aggiungere o rimuovere elementi utilizzare i metodi appropriati
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property ListaUtenti() As IList
        Get
            Return m_ListaUtenti
        End Get
        Set(ByVal value As IList)
            m_ListaUtenti = value
        End Set
    End Property

    Public Sub AddUtente(ByVal Utente As Utente)
        m_HasAdded = False
        If GetUtente(Utente) Is Nothing Then
            m_ListaUtenti.Add(Utente)
            m_HasAdded = True
        Else
            m_HasAdded = False

        End If
    End Sub

    Private Function GetUtente(ByVal Utente As Utente) As Utente
        For Each elem As Utente In m_ListaUtenti
            If elem.Id = Utente.Id Then
                Return elem
            End If
        Next
        Return Nothing
    End Function
    Public Sub RemoveUtente(ByVal Utente As Utente)
        Dim temp As Utente = GetUtente(Utente)
        If temp IsNot Nothing Then
            m_ListaUtenti.Remove(temp)
        End If

    End Sub



    Public Function Clone() As ListaLavoroUtenti

        Dim cloneList As New ArrayList
        'If TypeOf (m_ListaUtenti) Is VirtualLazyList Then
        '    cloneList = DirectCast(m_ListaUtenti, VirtualLazyList).Clone
        'Else
        '    cloneList = DirectCast(m_ListaUtenti, ArrayList).Clone
        'End If
        For Each elem As Utente In m_ListaUtenti
            cloneList.Add(elem)
        Next
        Dim result As New ListaLavoroUtenti()
        result.Descrizione = "Clone_" & Format(DateTime.Now, "dd-MM-yyyy hh-mm-ss")
        result.ListaUtenti = cloneList

        Return result
    End Function



    Public Sub Merge(ByVal lista As ListaLavoroUtenti)
        If lista Is Nothing Then Return
        For Each elem As Utente In lista.ListaUtenti
            Me.AddUtente(elem)
        Next
    End Sub

    Public Sub SubtractCommons(ByVal lista As ListaLavoroUtenti)
        If lista Is Nothing Then Return
        For Each elem As Utente In lista.ListaUtenti
            Me.RemoveUtente(elem)
        Next
    End Sub
    Public Sub RemoveIfAddressIsNotValid()

        Dim l As New ArrayList

        l.AddRange(m_ListaUtenti)




        For Each elem As Utente In l
            If Not elem.Residenza.IsIndirizzoValido Then
                Me.RemoveUtente(elem)
            End If
        Next
    End Sub


    Public Function CreaListaSpecificita(ByVal lista As ListaLavoroUtenti) As ListaLavoroUtenti
        Dim lista1 As ListaLavoroUtenti

        lista1 = Clone()
        lista1.SubtractCommons(lista)

        Return lista1

    End Function

    Public Function CreaListaComunanze(ByVal lista As ListaLavoroUtenti) As ListaLavoroUtenti
        Dim lista1 As New ListaLavoroUtenti
        lista1.Descrizione = Me.Descrizione



        'ottimizzo l'algoritmo scegliendo la lista con un numero minore di eleemtni


     

        If Me.ListaUtenti.Count >= lista.ListaUtenti.Count Then
            For Each elem As Utente In lista.ListaUtenti
                If Me.GetUtente(elem) IsNot Nothing Then
                    lista1.AddUtente(elem)
                End If
            Next
        Else
            For Each elem As Utente In Me.ListaUtenti
                If lista.GetUtente(elem) IsNot Nothing Then
                    lista1.AddUtente(elem)
                End If
            Next
        End If




        Return lista1

    End Function



End Class
