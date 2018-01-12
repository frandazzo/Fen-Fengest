Public Class FormConfigurazione



    ' Private Sub FormConfigurazione_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '   'TODO: questa riga di codice carica i dati nella tabella 'TesseramentoDataSet.Configurazione'. È possibile spostarla o rimuoverla se necessario.
    '   If connectionString <> "" Then
    '      Me.ConfigurazioneTableAdapter.Connection.ConnectionString = connectionString
    '   End If
    '   Me.ConfigurazioneTableAdapter.Fill(Me.TesseramentoDataSet.CONFIGURAZIONE)

    'End Sub


    ' Private Sub cmdSalva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSalva.Click
    '     Try
    '         'ConfigurazioneTableAdapter = ConfigurazioneTableAdapter
    '         'ConfigurazioneDataSet.AcceptChanges()
    '         Me.ConfigurazioneBindingSource.EndEdit()
    '         ConfigurazioneTableAdapter.Update(TesseramentoDataSet.Configurazione)
    '         'ConfigurazioneDataSet.Configurazione.AcceptChanges()
    '     Catch ex As Exception
    '         MsgBox(ex.Message)
    '     End Try
    ' End Sub

    'Public Sub PopolaDataset()
    '   Me.ConfigurazioneTableAdapter.Connection.ConnectionString = connectionString
    '   Me.ConfigurazioneTableAdapter.Fill(Me.TesseramentoDataSet.CONFIGURAZIONE)
    'End Sub
    ' Public Function GetReportSettings() As ReportSettings
    '     Try
    '         Dim RepSettings As New ReportSettings
    '         With RepSettings
    '             .Add("Matera1x", TesseramentoDataSet.Configurazione(0).Matera1x)
    '             .Add("Matera1y", TesseramentoDataSet.Configurazione(0).Matera1y)

    '             .Add("Matera2x", TesseramentoDataSet.Configurazione(0).Matera2x)
    '             .Add("Matera2y", TesseramentoDataSet.Configurazione(0).Matera2y)

    '             .Add("Matera3x", TesseramentoDataSet.Configurazione(0).Matera3x)
    '             .Add("Matera3y", TesseramentoDataSet.Configurazione(0).Matera3y)

    '             .Add("Matera4x", TesseramentoDataSet.Configurazione(0).Matera4x)
    '             .Add("Matera4y", TesseramentoDataSet.Configurazione(0).Matera4y)

    '             .Add("Matera5x", TesseramentoDataSet.Configurazione(0).Matera5x)
    '             .Add("Matera5y", TesseramentoDataSet.Configurazione(0).Matera5y)

    '             .Add("Matera6x", TesseramentoDataSet.Configurazione(0).Matera6x)
    '             .Add("Matera6y", TesseramentoDataSet.Configurazione(0).Matera6y)

    '             .Add("Matera7x", TesseramentoDataSet.Configurazione(0).Matera7x)
    '             .Add("Matera7y", TesseramentoDataSet.Configurazione(0).Matera7y)

    '             .Add("Matera8x", TesseramentoDataSet.Configurazione(0).Matera8x)
    '             .Add("Matera8y", TesseramentoDataSet.Configurazione(0).Matera8y)



    '             .Add("xn1", TesseramentoDataSet.Configurazione(0).xn1)
    '             .Add("xn2", TesseramentoDataSet.Configurazione(0).xn2)
    '             .Add("xn3", TesseramentoDataSet.Configurazione(0).xn3)
    '             .Add("xn4", TesseramentoDataSet.Configurazione(0).xn4)
    '             .Add("xc1", TesseramentoDataSet.Configurazione(0).xc1)
    '             .Add("xc2", TesseramentoDataSet.Configurazione(0).xc2)
    '             .Add("xc3", TesseramentoDataSet.Configurazione(0).xc3)
    '             .Add("xc4", TesseramentoDataSet.Configurazione(0).xc4)
    '             .Add("xa1", TesseramentoDataSet.Configurazione(0).xa1)
    '             .Add("xa2", TesseramentoDataSet.Configurazione(0).xa2)
    '             .Add("xa3", TesseramentoDataSet.Configurazione(0).xa3)
    '             .Add("xa4", TesseramentoDataSet.Configurazione(0).xa4)


    '             .Add("yn1", TesseramentoDataSet.Configurazione(0).yn1)
    '             .Add("yn2", TesseramentoDataSet.Configurazione(0).yn2)
    '             .Add("yn3", TesseramentoDataSet.Configurazione(0).yn3)
    '             .Add("yn4", TesseramentoDataSet.Configurazione(0).yn4)
    '             .Add("yc1", TesseramentoDataSet.Configurazione(0).yc1)
    '             .Add("yc2", TesseramentoDataSet.Configurazione(0).yc2)
    '             .Add("yc3", TesseramentoDataSet.Configurazione(0).yc3)
    '             .Add("yc4", TesseramentoDataSet.Configurazione(0).yc4)
    '             .Add("ya1", TesseramentoDataSet.Configurazione(0).ya1)
    '             .Add("ya2", TesseramentoDataSet.Configurazione(0).ya2)
    '             .Add("ya3", TesseramentoDataSet.Configurazione(0).ya3)
    '             .Add("ya4", TesseramentoDataSet.Configurazione(0).ya4)



    '             .Add("xn11", TesseramentoDataSet.Configurazione(0).xn11)
    '             .Add("xn22", TesseramentoDataSet.Configurazione(0).xn22)
    '             .Add("xn33", TesseramentoDataSet.Configurazione(0).xn33)
    '             .Add("xn44", TesseramentoDataSet.Configurazione(0).xn44)
    '             .Add("xc11", TesseramentoDataSet.Configurazione(0).xc11)
    '             .Add("xc22", TesseramentoDataSet.Configurazione(0).xc22)
    '             .Add("xc33", TesseramentoDataSet.Configurazione(0).xc33)
    '             .Add("xc44", TesseramentoDataSet.Configurazione(0).xc44)
    '             .Add("xa11", TesseramentoDataSet.Configurazione(0).xa11)
    '             .Add("xa22", TesseramentoDataSet.Configurazione(0).xa22)
    '             .Add("xa33", TesseramentoDataSet.Configurazione(0).xa33)
    '             .Add("xa44", TesseramentoDataSet.Configurazione(0).xa44)


    '             .Add("yn11", TesseramentoDataSet.Configurazione(0).yn11)
    '             .Add("yn22", TesseramentoDataSet.Configurazione(0).yn22)
    '             .Add("yn33", TesseramentoDataSet.Configurazione(0).yn33)
    '             .Add("yn44", TesseramentoDataSet.Configurazione(0).yn44)
    '             .Add("yc11", TesseramentoDataSet.Configurazione(0).yc11)
    '             .Add("yc22", TesseramentoDataSet.Configurazione(0).yc22)
    '             .Add("yc33", TesseramentoDataSet.Configurazione(0).yc33)
    '             .Add("yc44", TesseramentoDataSet.Configurazione(0).yc44)
    '             .Add("ya11", TesseramentoDataSet.Configurazione(0).ya11)
    '             .Add("ya22", TesseramentoDataSet.Configurazione(0).ya22)
    '             .Add("ya33", TesseramentoDataSet.Configurazione(0).ya33)
    '             .Add("ya44", TesseramentoDataSet.Configurazione(0).ya44)

    '             .Add("Top1", TesseramentoDataSet.Configurazione(0).Top1)
    '             .Add("Bottom1", TesseramentoDataSet.Configurazione(0).Bottom1)
    '             .Add("Left1", TesseramentoDataSet.Configurazione(0).Left1)
    '             .Add("Right1", TesseramentoDataSet.Configurazione(0).Right1)

    '         End With
    '         Return RepSettings
    '     Catch ex As Exception
    '      Throw
    '     End Try
    ' End Function

    ' Private Sub cmdVerificaAnteprima_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVerificaAnteprima.Click
    '     Try
    '         'Dim frm As New FormConfigurazione
    '         'frm.PopolaDataset()
    '         Dim repSettings As ReportSettings = GetReportSettings()
    '         Dim frmAnte As New FormAnteprima
    '         frmAnte.ReportSettings = repSettings
    '         frmAnte.Show()

    '     Catch ex As Exception
    '         MsgBox(ex.Message)
    '     End Try
    ' End Sub




End Class