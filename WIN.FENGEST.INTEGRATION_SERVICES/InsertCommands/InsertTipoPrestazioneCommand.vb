Imports WIN.APPLICATION.ADMINISTRATION

Public Class InsertTipoPrestazioneCommand
    Implements ICommand
    Private m_parameters As Hashtable
    Dim controller As New ControllerTipoPrestazione
    ''' <summary>
    ''' Costruttore comando
    ''' </summary>
    ''' <param name="Parameters">Le chiavi ammesse sono: PARTITA_IVA, CONTRATTO, SETTORE: IMPIANTI FISSI, EDILE</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Parameters As Hashtable)
        m_parameters = Parameters
    End Sub
    Public Sub Execute() Implements ICommand.Execute



        If m_parameters.Item("TIPO_PRESTAZIONE") Is Nothing Then
            InsertTipoPrestazione("NON SPECIFICATA")
        Else
            If String.IsNullOrEmpty(m_parameters("TIPO_PRESTAZIONE")) Then
                InsertTipoPrestazione("NON SPECIFICATA")
            Else
                InsertTipoPrestazione(m_parameters("TIPO_PRESTAZIONE"))
            End If
        End If
    End Sub

    Private Sub InsertTipoPrestazione(descrizione As String)

        'verifico se esiste la prestazione
        If controller.ExistTipoPrestazione(descrizione) Then
            Return
        End If

        Try
            controller.CreateNew(descrizione, "AAA", "")
        Catch ex As Exception
            Throw New ImportContrattiException(ex.Message, descrizione)
        End Try
    End Sub

End Class
