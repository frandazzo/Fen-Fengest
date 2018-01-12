Imports WIN.APPLICATION.ADMINISTRATION

Public Class InsertPrestazioneCommand
    Implements ICommand
    Private ReadOnly _idUtente As String
    Private ReadOnly _idReferente As String
    Private ReadOnly _idTipoPrestazione As String
    Private ReadOnly _data As DateTime
    Private m_parameters As Hashtable

    Public IdPrestazioneCreata As String



    Dim controllerP As New ControllerPrestazioni
    ''' <summary>
    ''' Costruttore comando
    ''' </summary>
    ''' <param name="Parameters">Le chiavi ammesse sono: PARTITA_IVA, CONTRATTO, SETTORE: IMPIANTI FISSI, EDILE</param>
    ''' <remarks></remarks>
    Public Sub New(IdUtente As String, IdReferente As String, IdTipoPrestazione As String, Data As DateTime)
        _idUtente = IdUtente
        _idReferente = IdReferente
        _idTipoPrestazione = IdTipoPrestazione
        _data = Data

    End Sub
    Public Sub Execute() Implements ICommand.Execute

        controllerP.CreateNew(_data, _data, "", _idUtente, _idReferente, _idTipoPrestazione)
        IdPrestazioneCreata = controllerP.IdPrestazione
    End Sub

    
End Class
