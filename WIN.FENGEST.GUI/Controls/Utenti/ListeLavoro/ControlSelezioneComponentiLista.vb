Imports System.Windows.Forms

Public Class ControlSelezioneComponentiLista

    Private m_gestore As GestoreConfrontoListe

    Private m_isLista1 As Boolean

    Public Sub SetIsLista1(ByVal isLista1 As Boolean)
        m_isLista1 = isLista1
    End Sub




    Public Sub SetGestore(ByVal gestore As GestoreConfrontoListe)
        m_gestore = gestore
    End Sub

    Public Sub New()

        ' Chiamata richiesta da Progettazione Windows Form.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub


    Public Sub LoadData()

        If m_gestore IsNot Nothing Then

            If m_isLista1 Then

                Label1.Text = "Selezione componenti lista iniziale"
                Me.lstComponenti.Items.Clear()
                For Each elem As ComponenteLista In m_gestore.ComponentiLista1
                    lstComponenti.Items.Add(elem)
                Next

            Else
                Label1.Text = "Selezione componenti lista di confronto"
                Me.lstComponenti.Items.Clear()
                For Each elem As ComponenteLista In m_gestore.ComponentiLista2
                    lstComponenti.Items.Add(elem)
                Next

            End If

        End If


    End Sub


    Private Sub CmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAdd.Click
        Try
            Dim frm As New FrmSelezionaTipoConversione(m_gestore, m_isLista1)

            If frm.ShowDialog() = DialogResult.OK Then
                LoadData()
            End If


            frm.Dispose()




        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub cmdRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemove.Click
        Try

            If lstComponenti.SelectedItems.Count <> 1 Then
                MessageBox.Show("Selezionare almeno un componente", "Messaggio", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return

            End If

            If m_isLista1 Then
                m_gestore.RemoveComponenteLista1(lstComponenti.SelectedItem.Descrizione)
            Else
                m_gestore.RemoveComponenteLista2(lstComponenti.SelectedItem.Descrizione)
            End If

            LoadData()

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
End Class
