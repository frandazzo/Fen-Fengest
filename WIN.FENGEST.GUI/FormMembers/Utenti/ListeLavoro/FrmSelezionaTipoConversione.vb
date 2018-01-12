Public Class FrmSelezionaTipoConversione

    Private m_gestore As GestoreConfrontoListe


    Private m_ListaLavoro As ListaLavoroUtenti


    Private m_componente As ComponenteLista.ComponentType = ComponenteLista.ComponentType.ListaLavoro

    Private m_IsLista1 As Boolean

    Public ReadOnly Property GestoreConfronto() As GestoreConfrontoListe
        Get
            Return m_gestore
        End Get
    End Property


    Public Sub New(ByVal gestore As GestoreConfrontoListe, ByVal IsLista1 As Boolean)

        ' Chiamata richiesta da Progettazione Windows Form.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        If gestore Is Nothing Then
            Throw New InvalidOperationException("Gestore Nullo!")
        End If

        m_gestore = gestore
        m_IsLista1 = IsLista1

    End Sub


    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        Try
            AggiungiComponente()

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try

    End Sub

    Private Sub cmdAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnnulla.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub



    Private Sub AggiungiComponente()
        If m_IsLista1 Then
            m_gestore.AddComponenteLista1(txtDescrizione.Text, m_componente, m_ListaLavoro)
        Else
            m_gestore.AddComponenteLista2(txtDescrizione.Text, m_componente, m_ListaLavoro)
        End If
    End Sub



    Private Function IsNameValid() As Boolean
        ' Determine whether the text box contains a zero-length string.
        Return txtDescrizione.Text.Length > 0
    End Function


    Private Sub txtDescrizione_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescrizione.Validated
        If IsNameValid() Then
            ' Clear the error, if any, in the error provider.
            ErrorProvider1.SetError(Me.txtDescrizione, "")
        Else
            ' Set the error if the name is not valid.
            ErrorProvider1.SetError(Me.txtDescrizione, "Inserire una descrizione.")
        End If

    End Sub



    Private Sub SelectData()
        Try
            'qui seleziono il form da visualizzare in base al tipo selezionato

            Select Case cboTipo.Text
                Case "Report incassi quote"
                    m_componente = ComponenteLista.ComponentType.Report
                    Dim frm As New FrmReportIQToListaLavoro()
                    If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                        m_ListaLavoro = frm.ListaLavoro
                    End If
                    frm.Dispose()
                Case "Report iscritti"
                    m_componente = ComponenteLista.ComponentType.Report
                    Dim frm As New FrmReportIscrittiToListaLavoro
                    If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                        m_ListaLavoro = frm.ListaLavoro
                    End If
                    frm.Dispose()
                Case "Report non iscritti"
                    m_componente = ComponenteLista.ComponentType.Report
                    Dim frm As New FrmReportLiberiToListaLavoro
                    If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                        m_ListaLavoro = frm.ListaLavoro
                    End If
                    frm.Dispose()

                Case "Report deleghe"
                    m_componente = ComponenteLista.ComponentType.Report
                    Dim frm As New FrmReportDelegheToListaLavoro
                    If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                        m_ListaLavoro = frm.ListaLavoro
                    End If
                    frm.Dispose()
                Case "Documento contabile"
                    m_componente = ComponenteLista.ComponentType.DocumentoContabile
                    Dim frm As New FrmDocumentoToListaLavoro()
                    If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                        m_ListaLavoro = frm.ListaLavoro
                    End If
                    frm.Dispose()
                Case "Lista lavoro"
                    m_componente = ComponenteLista.ComponentType.ListaLavoro
                    Dim frm As New SearchListaUtenti
                    If frm.ShowDialog() = Windows.Forms.DialogResult.OK Then
                        m_ListaLavoro = frm.ListaLavoroSelezionata
                    End If
                    frm.Dispose()
                Case Else
                    Exit Sub
            End Select







        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub




    Private Sub cboTipo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboTipo.SelectedIndexChanged

        SelectData()



    End Sub
End Class