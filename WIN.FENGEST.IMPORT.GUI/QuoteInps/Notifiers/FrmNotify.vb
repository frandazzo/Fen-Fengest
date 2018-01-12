Imports WIN.APPLICATION.IMPORT_EXPORT_SERVICES
Imports System.IO

Public Class FrmNotify
    Private WithEvents m_dataRetriver As DataInfoRetriever
    Private WithEvents m_multipledataRetriver As MultipleFileDataRetriever
    Private m_fromIQITemplate As Boolean
    Private WithEvents actionScheduler As ActionScheduler
    Public Data As IList
    Private WithEvents m_iqiScheduler As ImportIQIScheduler


    Private numberoOfFilesFound As Int32

    Public Sub New(dataRetriver As DataInfoRetriever)

        ' Chiamata richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        m_dataRetriver = dataRetriver
    End Sub





    Private Sub scheduler_BeginWriting() Handles m_iqiScheduler.BeginWriting
        Me.lstActivity.Items.Add("Scrittura iniziata")
        System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub scheduler_BeginWritingIQA() Handles m_iqiScheduler.BeginWritingIQA
        Me.lstActivity.Items.Add("Salvataggio documento in corso...")
        System.Windows.Forms.Application.DoEvents()
    End Sub
    Private Sub scheduler_AddingRecord(ByVal IdRecord As Integer) Handles m_iqiScheduler.AddingRecord
        Me.txtTask.Text = "Inserimento dell'item " & IdRecord.ToString
        System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub scheduler_BeginDocumentWriting() Handles m_iqiScheduler.BeginDocumentWriting
        Me.txtTask.Text = "Preparazione scrittura documento"
        System.Windows.Forms.Application.DoEvents()
    End Sub



    Private Sub scheduler_EndImport(Errors As Integer, Inserted As Integer) Handles m_iqiScheduler.EndImport
        Me.lstActivity.Items.Add("Importazione elaborata con " & Errors & " errori totali e " & Inserted & " posizioni totali correttamente inserite")
        System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub scheduler_EndWriting(ByVal Errors As Integer, ByVal Inserted As Integer) Handles m_iqiScheduler.EndWriting
        'Me.lstActivity.Items.Add("Terminata attività di scrittura dei prerequisiti")
        Me.lstActivity.Items.Add("Documento elaborato con " & Errors & " errori e " & Inserted & " posizioni correttamente inserite")
        System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub scheduler_EndWritingIQA() Handles m_iqiScheduler.EndWritingIQA
        Me.lstActivity.Items.Add("Salvataggio effettuato!")
        System.Windows.Forms.Application.DoEvents()
    End Sub








    Public Sub New(dataRetriver As MultipleFileDataRetriever, fromIQITemplate As Boolean)

        ' Chiamata richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        m_multipledataRetriver = dataRetriver
        m_fromIQITemplate = fromIQITemplate
    End Sub


    Public Sub New(iqiScheduler As ImportIQIScheduler, retrievedData As IList)

        ' Chiamata richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        m_iqiScheduler = iqiScheduler
        Data = retrievedData
    End Sub


    Private Sub ShowImportState()

        If Not m_iqiScheduler Is Nothing Then
            m_iqiScheduler.BackGroundStartImport(Data)
            m_iqiScheduler.OpenLogFile()
            Me.Close()
            Return
        End If



        If m_multipledataRetriver Is Nothing Then

            actionScheduler = New ActionScheduler(m_dataRetriver)

        Else
            actionScheduler = New ActionScheduler(m_multipledataRetriver, m_fromIQITemplate)

        End If

        actionScheduler.StartImport()
        data = actionScheduler.ExtractedData
        Me.Close()
    End Sub


    Private Sub FrmNotify_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FrmNotify_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        System.Windows.Forms.Application.DoEvents()
        ShowImportState()
    End Sub


    Private Sub scheduler_BeginParse() Handles m_multipledataRetriver.BeginParse
        Me.lstActivity.Items.Add("Iniziata analisi percorso")
        System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub scheduler_BeginParseFile(filename As String, number As Integer) Handles m_multipledataRetriver.BeginParseFile

        Dim filei As New FileInfo(filename)


        Me.lstActivity.Items.Add("Importazione file " + number.ToString + " di " + numberoOfFilesFound.ToString + "; file: " + filei.Name)
        System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub scheduler_BeginParsePath() Handles m_multipledataRetriver.BeginParsePath
        Me.lstActivity.Items.Add("Iniziata analisi del percorso indicato")
        System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub scheduler_BeginRetrieving() Handles m_multipledataRetriver.BeginRetrieving
        Me.lstActivity.Items.Add("Iniziato recupero dati dal file")
        System.Windows.Forms.Application.DoEvents()
    End Sub





    Private Sub m_multipledataRetriver_EndParse(NumberOfRecords As Integer, NumberOfFields As Integer) Handles m_multipledataRetriver.EndParse
        Me.lstActivity.Items.Add("Termine analisi formato file. Trovati " & NumberOfRecords & " records")
        System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub scheduler_EndParseFile(filename As String, exception As System.Exception) Handles m_multipledataRetriver.EndParseFile
        Dim filei As New FileInfo(filename)

        If (exception Is Nothing) Then
            Me.lstActivity.Items.Add("Importazione terminata con successo del file " + filei.Name)

        Else
            Me.lstActivity.Items.Add("Errore nell'importazione del file " + filei.Name)
            Me.lstActivity.Items.Add("Errore: " + exception.Message)
        End If
        System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub scheduler_EndParsePath(NumberOfFilesFound As Integer) Handles m_multipledataRetriver.EndParsePath
        numberoOfFilesFound = NumberOfFilesFound
        Me.lstActivity.Items.Add("Sono stati trovati " & NumberOfFilesFound & " file da importare")
        System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub scheduler_EndRetrieving(ByVal NumberOfRecords As Integer) Handles m_multipledataRetriver.EndRetrieving
        Me.lstActivity.Items.Add("Termine recupero dati file.")
        System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub m_multipledataRetriver_RetrievingRecord(IdRecord As Integer) Handles m_multipledataRetriver.RetrievingRecord
        Me.txtTask.Text = "Recupero del record " & IdRecord.ToString
        System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub m_dataRetriver_BeginParse() Handles m_dataRetriver.BeginParse
        Me.lstActivity.Items.Add("Iniziata analisi formato file")
        System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub m_dataRetriver_BeginRetrieving() Handles m_dataRetriver.BeginRetrieving
        Me.lstActivity.Items.Add("Iniziato recupero dati dal file")
        System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub m_dataRetriver_EndParse(NumberOfRecords As Integer, NumberOfFields As Integer) Handles m_dataRetriver.EndParse
        Me.lstActivity.Items.Add("Termine analisi formato file. Trovati " & NumberOfRecords & " records")
        System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub m_dataRetriver_EndRetrieving(NumberOfRecords As Integer) Handles m_dataRetriver.EndRetrieving
        Me.lstActivity.Items.Add("Termine recupero dati file.")
        System.Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub m_dataRetriver_RetrievingRecord(IdRecord As Integer) Handles m_dataRetriver.RetrievingRecord
        Me.txtTask.Text = "Recupero del record " & IdRecord.ToString
        System.Windows.Forms.Application.DoEvents()
    End Sub
End Class