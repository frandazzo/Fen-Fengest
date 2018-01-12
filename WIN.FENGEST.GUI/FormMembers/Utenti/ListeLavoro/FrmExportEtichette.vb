Imports System.Windows.Forms

Public Class FrmExportEtichette

    Private m_lista As IList(Of Hashtable)
    Private controllerSeg As ControllerSegreteria
    Private MyImage As Bitmap
    Private m_selectedFile As String = ""
    Dim WithEvents esporter As EtichetteExporter
    Dim frm As FrmElaborazioneInCorso



    Dim m_AbsolutethToLabelTemplate As String = ""
    Dim m_textToReplaceFromImageName As String = ""
    Dim m_CounterTag As String = "@Nome_Completo@"

    Private m_savedFile As String = ""


    

    Public ReadOnly Property SavedFile() As String
        Get
            Return m_savedFile
        End Get
    End Property

    Public Sub New(ByVal lista As IList(Of Hashtable))

        InitializeComponent()


        controllerSeg = New ControllerSegreteria
        controllerSeg.LoadById("1")

        If lista Is Nothing Then
            Throw New ArgumentNullException("Lista lavoro")
        End If

        m_lista = lista


        Me.DialogResult = Windows.Forms.DialogResult.Cancel


        m_AbsolutethToLabelTemplate = controllerSeg.CartellaEtichette + "\dot"

    End Sub


    Public Sub New(ByVal lista As IList(Of Hashtable), ByVal relativePath As String, ByVal textToReplaceFromImageName As String, ByVal counterTag As String)

        InitializeComponent()

        controllerSeg = New ControllerSegreteria
        controllerSeg.LoadById("1")

        If lista Is Nothing Then
            Throw New ArgumentNullException("Lista lavoro")
        End If

        m_lista = lista


        Me.DialogResult = Windows.Forms.DialogResult.Cancel

        m_textToReplaceFromImageName = textToReplaceFromImageName

        If Not String.IsNullOrEmpty(counterTag) Then
            m_CounterTag = counterTag
        End If


        m_AbsolutethToLabelTemplate = controllerSeg.CartellaEtichette + "\dot\" + relativePath

    End Sub






    Private Sub PopolaCombo()
        Dim path As String = ""
        Dim filePaths As System.Collections.ObjectModel.ReadOnlyCollection(Of String)
        Dim name As String


        path = m_AbsolutethToLabelTemplate
        filePaths = My.Computer.FileSystem.GetFiles(path)
        ComboBoxModello.Items.Add("")
        For Each file As String In filePaths
            name = file.ToString.Replace(path + "\", "")
            name = name.Replace(".dot", "")
            ComboBoxModello.Items.Add(name)
            'ComboBoxModello.Text = name
        Next
        ComboBoxModello.Items.Add("<Sfoglia>")
    End Sub



    Private Sub FrmExportEtichette_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        PopolaCombo()
        cboProduttore.SelectedIndex = 0
    End Sub

    Private Sub ComboBoxModello_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBoxModello.SelectedIndexChanged
        Try
            'se non seleziono nulla
            If ComboBoxModello.Text = "" Then
                MessageBox.Show("Selezionare un modello", "Messaggio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                m_selectedFile = ""
                MyImage = New Bitmap(My.Resources.non_disponibile)
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                Return
            End If

            'se richiedo la ricerca di un modello
            If ComboBoxModello.Text = "<Sfoglia>" Then
                'imposto l'anteprima non disponibile
                MyImage = New Bitmap(My.Resources.non_disponibile)
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
                OpenFileDialog1.Filter = "Modelli word 2003 (*.dot)|*.dot"
                If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
                    If My.Computer.FileSystem.FileExists(OpenFileDialog1.FileName) Then
                        m_selectedFile = OpenFileDialog1.FileName
                        Return
                    End If
                End If
                MessageBox.Show("Selezionare un modello", "Messaggio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                m_selectedFile = ""
                ComboBoxModello.Text = ""
                Return
            End If



            'Se ho selezionato un modello esistente
            'seleziono l'immagine

            Dim path As String

            If (MyImage IsNot Nothing) Then
                MyImage.Dispose()
            End If


            path = controllerSeg.CartellaEtichette + "\image\" + Replace(ComboBoxModello.Text, m_textToReplaceFromImageName, "") + ".png"
            Try
                MyImage = New Bitmap(path)
                'PictureBox1.ClientSize = New Size(xSize, ySize)
            Catch ex As Exception
                MyImage = New Bitmap(My.Resources.non_disponibile)
            End Try



            PictureBox1.Image = CType(MyImage, Image)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            'imposto il file da esportare
            m_selectedFile = m_AbsolutethToLabelTemplate + "\" + ComboBoxModello.Text + ".dot"



        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        Try
            Dim savapath As String = ""

            'richiedo dove salvare
            If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

                savapath = FolderBrowserDialog1.SelectedPath

            End If


            If savapath = "" Then
                MessageBox.Show("Inserire un percorso di detinazione del file delle etichette!", "Messaggio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If


            'predispongo alla creazione del file
            esporter = New EtichetteExporter
            Dim o As ExportOption
            o = New ExportOption(m_selectedFile, savapath)



            o.OffsetPartenza = NumericUpDownEtPartenza.Value
            o.TagRicercaOccorrenze = m_CounterTag
            o.Ripetizioni = NumericUpDownRipetizioni.Value
            o.Metadata = m_lista

            'creo il file
            Dim fileSaved As String = ""

            'avvio il processo monitorandolo

            Try

                frm = New FrmElaborazioneInCorso()
                frm.EnableCancel(True)
                frm.SetActivity("Inizio attività in corso...")

                frm.TopLevel = True


                frm.Show()
                System.Windows.Forms.Application.DoEvents()



                fileSaved = esporter.creaEtichette(o)


                frm.Dispose()

                If esporter.ErrorTest <> "" Then
                    Dim fileerr As String = savapath + "\" + esporter.FileErrorName
                    My.Computer.FileSystem.WriteAllText(fileerr, esporter.ErrorTest, True)
                    MessageBox.Show("Attenzione si sono verificati degli errori. Visualizzare il file '" + fileerr + "' per consultarli", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If




            Catch ex As Exception
                ErrorHandler.ShowError(ex)
            End Try


            'visualizzo il file
            Process.Start(fileSaved)




            Me.DialogResult = Windows.Forms.DialogResult.OK
            'Me.Close()
        Catch ex1 As Exception
            ErrorHandler.ShowError(ex1)
        End Try
    End Sub

    Private Sub cmdAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnnulla.Click

        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub




    Private Sub esporter_DocumentClosing() Handles esporter.DocumentClosing
        frm.SetPercentageValue(100)
        frm.SetActivity("Chiusura documento in corso...")
        Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub esporter_DocumentOpening() Handles esporter.DocumentOpening
        frm.SetPercentageValue(0)
        frm.SetActivity("Apertura documento in corso...")
        Windows.Forms.Application.DoEvents()
    End Sub

    Private Sub esporter_LabelPrinted(ByVal printed As Integer, ByVal totalToPrint As Integer, ByRef cancel As Boolean) Handles esporter.LabelPrinted
        If frm.Annulla Then
            If MessageBox.Show("Sicuro di voler annullare l'esportazione dei dati?", "Messaggio", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                MessageBox.Show("Operazione annullata dall'utente", "Messaggio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cancel = True
            Else
                frm.Annulla = False
            End If
        End If
        Dim perc As Int32 = CInt((printed / totalToPrint) * 100)
        frm.SetPercentageValue(perc)
        frm.SetActivity("Percentuale di esportazione: " & perc.ToString)
        Windows.Forms.Application.DoEvents()
    End Sub
End Class