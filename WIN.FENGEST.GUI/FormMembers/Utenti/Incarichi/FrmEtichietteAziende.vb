Public Class FrmEtichietteAziende

    Private m_lista As IList(Of Hashtable)


    Private frm1 As FrmElaborazioneInCorso
    Private m_close As Boolean = False


    Public Sub New(ByVal Lista As IList(Of Hashtable), ByVal close As Boolean)

        InitializeComponent()


        If Lista Is Nothing Then
            Throw New Exception("Lista incarichi nulla!")
        End If

        m_close = close
        m_lista = Lista

    End Sub



    Public Sub New(ByVal Lista As IList(Of Hashtable))

        InitializeComponent()


        If Lista Is Nothing Then
            Throw New Exception("Lista incarichi nulla!")
        End If

        m_lista = Lista

    End Sub

    Private Sub cmdAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnnulla.Click
        Me.Close()
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        Try
            cmdOk.Enabled = False
            cmdAnnulla.Enabled = False

            ExportOnWord()

            If m_close Then
                Me.Close()
            End If

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        Finally
            cmdOk.Enabled = True
            cmdAnnulla.Enabled = True
        End Try
    End Sub



    

    Private Sub ExportOnWord()

        Try
            'chkOnlyAddressOK.Checked

            Dim list As IList(Of Hashtable) = New List(Of Hashtable)
            For Each elem As Hashtable In m_lista
                If Not chkOnlyAddressOK.Checked Then
                    If Not String.IsNullOrEmpty(elem("@Azienda@").ToString) Then ' per prevenire oggetti vuoti
                        list.Add(elem)
                    End If
                Else
                    If Not String.IsNullOrEmpty(elem("@AziendaProvincia@").ToString) Then
                        If Not String.IsNullOrEmpty(elem("@AziendaComune@").ToString) Then
                            If Not String.IsNullOrEmpty(elem("@AziendaVia@").ToString) Then
                                If Not String.IsNullOrEmpty(elem("@AziendaCap@").ToString) Then
                                    list.Add(elem)
                                End If
                            End If
                        End If
                    End If
                End If

            Next

            Dim frm As New FrmExportEtichette(list, "Aziende", "", "@Azienda@")


            frm.ShowDialog()

            frm.Dispose()


        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try

    End Sub






End Class