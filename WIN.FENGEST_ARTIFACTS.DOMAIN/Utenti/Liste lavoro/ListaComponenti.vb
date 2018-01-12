Imports System.Text

Friend Class ListaComponenti


    Private m_lista As ArrayList = New ArrayList



    Private m_Descrizione As String = ""

    Friend Sub New(ByVal DescrizioneLista As String)
        m_Descrizione = DescrizioneLista
    End Sub

    Friend Sub New()

    End Sub

    Public Property Descrizione() As String
        Get
            Return m_Descrizione
        End Get
        Set(ByVal value As String)
            m_Descrizione = value
        End Set
    End Property


    Public Overloads Sub AddComponente(ByVal Tipo As ComponenteLista.ComponentType, ByVal DescrizioneTipo As String, ByVal Lista As ListaLavoroUtenti)
        If Lista Is Nothing Then Throw New InvalidOperationException("Il componente di lista di lavoro deve avere un riferimento non nullo ad una lista")

        For Each elem As ComponenteLista In m_lista
            If elem.Descrizione = DescrizioneTipo Then
                Throw New InvalidOperationException("Descrizione esistente!")
            End If
        Next
        m_lista.Add(New ComponenteLista(DescrizioneTipo, Tipo, Lista))
    End Sub



    Public Overloads Sub AddComponente(ByVal Tipo As ComponenteLista.ComponentType, ByVal Lista As ListaLavoroUtenti)
        If Lista Is Nothing Then Throw New InvalidOperationException("Il componente di lista di lavoro deve avere un riferimento non nullo ad una lista")

        For Each elem As ComponenteLista In m_lista
            If elem.Descrizione = Lista.Descrizione Then
                Throw New InvalidOperationException("Descrizione esistente!")
            End If
        Next
        m_lista.Add(New ComponenteLista(Lista.Descrizione, Tipo, Lista))
    End Sub

    Public Sub RemoveComponente(ByVal DescrizioneTipo As String)
        For Each elem As ComponenteLista In m_lista
            If elem.Descrizione = DescrizioneTipo Then
                m_lista.Remove(elem)
                Return
            End If
        Next

    End Sub



    Public Function CreaDescrizioneCompleta() As String
        Dim sb As New StringBuilder

        sb.AppendLine("Lista: " & m_Descrizione.ToUpper)
        If m_lista.Count = 0 Then
            sb.AppendLine("Nessun elemento aggiunto!")
            Return sb.ToString
        End If
        For Each elem As ComponenteLista In m_lista
            sb.AppendLine(elem.ToString)
        Next

        Return sb.ToString
    End Function



    Public Property ListaComponenti() As ArrayList
        Get
            Return m_lista
        End Get
        Set(ByVal value As ArrayList)
            m_lista = value
        End Set
    End Property


    Public Function CreaMergeFinale() As ListaLavoroUtenti

        Dim lista As New ListaLavoroUtenti

        lista.Descrizione = m_Descrizione


        If m_lista.Count = 0 Then
            Return lista
        End If


        For Each elem As ComponenteLista In m_lista
            lista.Merge(elem.ListaLavoro)
        Next

        Return lista

    End Function






End Class
