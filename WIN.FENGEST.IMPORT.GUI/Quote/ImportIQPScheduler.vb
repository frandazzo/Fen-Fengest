Imports WIN.APPLICATION.IMPORT_EXPORT_SERVICES

Public Class ImportIQPScheduler
    Inherits ImportIQAScheduler

    Public Sub New(ByVal Filename As String, ByVal LogFilePath As String, ByVal updateUtenti As Boolean, ByVal updateAziende As Boolean, ByVal addDelega As Boolean)
        MyBase.New(Filename, LogFilePath, updateUtenti, updateAziende, addDelega)

        FileLogName = "ImportIQP"

    End Sub

    Protected Overrides Sub InsertElement(singleDocument_Data As ArrayList)
        InsertIQP = New InsertIQPCommand(Data, FileLogName, m_checkPaybility)
        InsertIQP.Execute()
    End Sub

End Class
