Public Class GestoreConfrontoListe

    Public Event MergeLista1()
    Public Event MergeLista2()
    Public Event CreateDiffLista1()
    Public Event CreateDiffLista2()
    Public Event CreateCommons()
    Public Event BeginExecuteCompare()
    Public Event EndExecuteCompare()

    Private m_listaComponenti1 As New ListaComponenti
    Private m_listaComponenti2 As New ListaComponenti


    Public Sub SetDescrizioneLista1(ByVal descrizione As String)
        m_listaComponenti1.Descrizione = descrizione
    End Sub

    Public Sub SetDescrizioneLista2(ByVal descrizione As String)
        m_listaComponenti2.Descrizione = descrizione
    End Sub


    Public Sub AddComponenteLista1(ByVal Descrizione As String, ByVal Tipo As ComponenteLista.ComponentType, ByVal Lista As ListaLavoroUtenti)

        m_listaComponenti1.AddComponente(Tipo, Descrizione, Lista)


    End Sub


    Public Sub RemoveComponenteLista1(ByVal Descrizione As String)
        m_listaComponenti1.RemoveComponente(Descrizione)
    End Sub


    Public Sub RemoveComponenteLista2(ByVal Descrizione As String)
        m_listaComponenti2.RemoveComponente(Descrizione)
    End Sub


    Public ReadOnly Property ComponentiLista1() As ArrayList
        Get
            Return m_listaComponenti1.ListaComponenti
        End Get
    End Property


    Public ReadOnly Property ComponentiLista2() As ArrayList
        Get
            Return m_listaComponenti2.ListaComponenti
        End Get
    End Property


    Public Sub AddComponenteLista2(ByVal Descrizione As String, ByVal Tipo As ComponenteLista.ComponentType, ByVal Lista As ListaLavoroUtenti)

        m_listaComponenti2.AddComponente(Tipo, Descrizione, Lista)


    End Sub

    Public ReadOnly Property DescrizioneCompletaLista1()
        Get
            Return m_listaComponenti1.CreaDescrizioneCompleta
        End Get
    End Property


    Public ReadOnly Property DescrizioneCompletaLista2()
        Get
            Return m_listaComponenti2.CreaDescrizioneCompleta
        End Get
    End Property


    Public Function CreaConfronto() As ConfrontoListeUtenti

        RaiseEvent BeginExecuteCompare()

        Dim confronto As New ConfrontoListeUtenti
        If String.IsNullOrEmpty(m_listaComponenti1.Descrizione) Then
            confronto.DescrizioneLista1 = "Speficità lista iniziale"
        Else
            confronto.DescrizioneLista1 = "Speficità lista: " & m_listaComponenti1.Descrizione
        End If

        If String.IsNullOrEmpty(m_listaComponenti2.Descrizione) Then
            confronto.DescrizioneLista2 = "Speficità lista di confronto"
        Else
            confronto.DescrizioneLista2 = "Speficità lista: " & m_listaComponenti2.Descrizione
        End If




        RaiseEvent MergeLista1()

        Dim lista1 As ListaLavoroUtenti = m_listaComponenti1.CreaMergeFinale


        RaiseEvent MergeLista2()

        Dim lista2 As ListaLavoroUtenti = m_listaComponenti2.CreaMergeFinale


        RaiseEvent CreateDiffLista1()

        confronto.ListaLavoro1 = lista1.CreaListaSpecificita(lista2)


        RaiseEvent CreateDiffLista2()

        confronto.ListaLavoro2 = lista2.CreaListaSpecificita(lista1)

        RaiseEvent CreateCommons()

        confronto.ListaConfronto = lista1.CreaListaComunanze(lista2)

        RaiseEvent EndExecuteCompare()

        Return confronto


    End Function



End Class
