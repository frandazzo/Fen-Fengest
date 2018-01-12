Imports System.ComponentModel
Imports System.IO
Imports BilancioFenealgest.ServiceLayer

Public Class ControllerRendiconto

    Private ps As IPersistenceFacade
    Private m_Provincia As String
    Private m_regione As String

    Public Sub New()
        ps = DataAccessServices.Instance.PersistenceFacade
    End Sub

    Private Function GetRendicontoExecutablePath(type As RendicontoType)




        Dim path As String = System.Reflection.Assembly.GetExecutingAssembly.CodeBase.Replace("file:///", "")

        Dim file1 As String = ""
        If type = RendicontoType.RLST Then
            file1 = "\RENDICONTO RLST\GestAmm.exe"
        Else
            file1 = "\RENDICONTO FENEAL\GestAmm.exe"
        End If



        Dim f As New FileInfo(path)

        ' path = f.DirectoryName + file

        path = f.Directory.FullName + file1

        If Not File.Exists(path) Then
            Throw New Exception("Funzionalità non installata: " + file1)
        End If



        'Dim args As New ProcessStartInfo


        ''passo il nome del programma da avviare
        'args.FileName = path

        ''avvio il programma
        'Process.Start(args)


        Return path



    End Function



    Private Function ConstuctArgumentsForOpenRendiconto(filename As String) As String
        Dim result As String = ""




        Dim usn As String = """cmd:1"""
        Dim usp As String = """fto:" + filename + """"




        result = usn + " " + usp


        Return result
    End Function



    Public Sub ViewRendiconto(Rendiconto As Rendiconto)


        Dim exePath As String = Me.GetRendicontoExecutablePath(Rendiconto.Tipo)
        Dim args1 As String = ConstuctArgumentsForOpenRendiconto(Rendiconto.FilePath)

        Dim args As New ProcessStartInfo


        'passo il nome del programma da avviare
        args.FileName = exePath
        args.Arguments = args1


        'prima di eseguire verifico che il file esista altrimenti attendo 5 secondi
        If File.Exists(Rendiconto.FilePath) Then
            'avvio il programma
            Process.Start(args)
            Return
        End If
        'aspetto 10 secondi
        Threading.Thread.Sleep(5000)
        If File.Exists(Rendiconto.FilePath) Then
            'avvio il programma
            Process.Start(args)
            Return
        End If

        'aspetto altri 10 secondi
        Threading.Thread.Sleep(10000)
        If File.Exists(Rendiconto.FilePath) Then
            'avvio il programma
            Process.Start(args)
            Return
        End If

        'aspetto altri 10 secondi
        Threading.Thread.Sleep(10000)
        If File.Exists(Rendiconto.FilePath) Then
            'avvio il programma
            Process.Start(args)
            Return
        End If

        'se a questo punto non esiste ancora lancio una eccezione
        Throw New Exception("Troppo tempo per la creazione del rendiconto. Riprovare o contattare l'amministratore")
    End Sub

    Public Sub DeleteRendiconto(Rendiconto As Rendiconto)
        ps.DeleteObject("Rendiconto", Rendiconto)
        File.Delete(Rendiconto.FilePath)
    End Sub

    Public Function CreateRendiconto(tipo As RendicontoType, descrizione As String, anno As Int32, rendicontoPrecedente As Rendiconto) As Rendiconto


        Dim newName As String = Rendiconto.NewRendicontoName
        Dim pathSegreteria As String = Me.GetPathSegreteria


        Dim rendiconto1 As New Rendiconto
        rendiconto1.Tipo = tipo
        rendiconto1.Descrizione = descrizione
        rendiconto1.Anno = anno
        rendiconto1.FilePath = pathSegreteria + "/" + newName

        'salvo l'oggetto creato
        SaveOrUpdateRendiconto(rendiconto1)

        'adesso devo creare il file del rendiconto vero  e prorpio
        'come prima cosa verifico se devo recuperare i saldi 
        'da in rendiconto precedente
        Dim saldi As String = ""
        If Not rendicontoPrecedente Is Nothing Then
            'recupero il rendiconto instanziandone il servizio e da li recupero il file
            Dim r As New RendicontoService
            r.LoadRendiconto(rendicontoPrecedente.FilePath)
            saldi = r.RetrievePatternSaldiFinaliStatoPatrimoniale()

        End If

        'una volta verificata la presenza dei saldi posso passare alla costruzione dei parametri per la creazione
        Dim params As String = ConstuctArgumentsForCreateRendiconto(pathSegreteria, newName, saldi, anno, tipo)

        Dim args As New ProcessStartInfo


        'passo il nome del programma da avviare
        args.FileName = GetRendicontoExecutablePath(tipo)
        args.Arguments = params

        'avvio il programma
        Process.Start(args)

        Return rendiconto1

    End Function



    Public Sub SaveOrUpdateRendiconto(Rendiconto As Rendiconto)
        If Rendiconto.Key Is Nothing Then
            ps.InsertObject("Rendiconto", Rendiconto)
        Else
            ps.UpdateObject("Rendiconto", Rendiconto)
        End If
    End Sub

    Public Function GetAllRendiconti(tipo As RendicontoType) As BindingList(Of Rendiconto)

        Dim list As IList = ps.GetAllObjects("Rendiconto")

        'creo una binding list
        Dim l As IBindingList = New BindingList(Of Rendiconto)
        For Each elem As Rendiconto In list
            If elem.Tipo.Equals(tipo) Then
                l.Add(elem)
            End If
        Next


        Return l

    End Function

    'Private Function ConstructRendicontoFilePath() As String
    '    Dim seg As New ControllerSegreteria

    '    seg.LoadById(1)

    '    Dim pathSegreteria As String = seg.DirectoryPreferenziale
    '    Dim rendicontoFilename As String = Rendiconto.NewRendicontoName

    '    Return pathSegreteria + "/" + rendicontoFilename

    'End Function

    Private Function GetPathSegreteria() As String
        Dim seg As New ControllerSegreteria

        seg.LoadById(1)

        m_Provincia = seg.ProvinciaLegale
        m_regione = seg.RegioneLegale


        If String.IsNullOrEmpty(m_Provincia) Then
            Throw New Exception("Provincia non impostata nella configuraizone Fenealgest")
        End If

        Return seg.DirectoryPreferenziale()


    End Function

    Private Function ConstuctArgumentsForCreateRendiconto(pathSegreteria As String, newName As String, saldi As String, anno As Integer, tipo As RendicontoType) As String
        Dim result As String = ""
        Dim t As String
        If tipo = RendicontoType.Provinciale Then
            t = "1"
        ElseIf tipo = RendicontoType.Regionale Then
            t = 2
        Else
            t = 3
        End If


        Dim cmd As String = """cmd:2""" ' comando
        Dim ret As String = """ret:" + t + """" ' tipo rendiconto
        Dim yea As String = """yea:" + anno.ToString + """" ' anno
        Dim fnt As String = """fnt:" + newName + """" 'nome file da creare
        Dim pro As String = """pro:" + m_Provincia + """"
        Dim reg As String = """reg:" + m_regione + """"
        Dim ftc As String = """ftc:" + pathSegreteria + """"
        Dim sal As String = """sal:" + saldi + """"





        result = cmd + " " + ret + " " + yea + " " + fnt + " " + pro + " " + reg + " " + ftc + " " + sal


        Return result
    End Function


End Class
