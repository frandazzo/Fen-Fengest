'Imports CrystalDecisions.CrystalReports
'Public Class FormAnteprima
'    Public ReportSettings As ReportSettings
'    Private Report As CrystalDecisions.CrystalReports.Engine.ReportDocument
'    Private TextOb As Engine.TextObject

'    Public Sub Stampa(ByVal Tesserato1 As Tesserato, ByVal Tesserato2 As Tesserato, ByVal RptSet As ReportSettings)
'        Try
'            OpenReport()
'            SetReportProperties(Tesserato1, Tesserato2, RptSet)
'            Report.PrintToPrinter(1, False, 1, 1)
'         System.Windows.Forms.Application.DoEvents()
'        Catch ex As Exception
'            Throw New Exception(ex.Message)
'        End Try
'    End Sub
'    Private Sub OpenReport()
'        Try
'            Report = New CrystalDecisions.CrystalReports.Engine.ReportDocument
'            Report.Load("CrystalReport1.rpt")
'        Catch ex As Exception
'            Throw New Exception(ex.Message)
'        End Try
'    End Sub
'    Public Sub AnteprimaStampa()
'        Try

'            SetReportPropertiesAnteprima()
'        Catch ex As Exception
'            Throw New Exception(ex.Message)
'        End Try
'    End Sub
'    Private Sub SetReportPropertiesAnteprima()
'        Try
'            With ReportSettings


'                TextOb = SearchTextObj("Matera1")
'                SetTextObjProperties(TextOb, "Matera", .Item("Matera1x"), .Item("Matera1y"))
'                TextOb = SearchTextObj("Matera2")
'                SetTextObjProperties(TextOb, "Matera", .Item("Matera2x"), .Item("Matera2y"))
'                TextOb = SearchTextObj("Matera3")
'                SetTextObjProperties(TextOb, "Matera", .Item("Matera3x"), .Item("Matera3y"))
'                TextOb = SearchTextObj("Matera4")
'                SetTextObjProperties(TextOb, "Matera", .Item("Matera4x"), .Item("Matera4y"))
'                TextOb = SearchTextObj("Matera5")
'                SetTextObjProperties(TextOb, "Matera", .Item("Matera5x"), .Item("Matera5y"))
'                TextOb = SearchTextObj("Matera6")
'                SetTextObjProperties(TextOb, "Matera", .Item("Matera6x"), .Item("Matera6y"))
'                TextOb = SearchTextObj("Matera7")
'                SetTextObjProperties(TextOb, "Matera", .Item("Matera7x"), .Item("Matera7y"))
'                TextOb = SearchTextObj("Matera8")
'                SetTextObjProperties(TextOb, "Matera", .Item("Matera8x"), .Item("Matera8y"))




'                TextOb = SearchTextObj("txtNome1")
'                SetTextObjProperties(TextOb, "Testo di prova1", .Item("xn1"), .Item("yn1"))
'                TextOb = SearchTextObj("txtNome2")
'                SetTextObjProperties(TextOb, "Testo di prova2", .Item("xn2"), .Item("yn2"))
'                TextOb = SearchTextObj("txtNome3")
'                SetTextObjProperties(TextOb, "Testo di prova3", .Item("xn3"), .Item("yn3"))
'                TextOb = SearchTextObj("txtNome4")
'                SetTextObjProperties(TextOb, "Testo di prova4", .Item("xn4"), .Item("yn4"))
'                TextOb = SearchTextObj("txtNome11")
'                SetTextObjProperties(TextOb, "Testo di prova11", .Item("xn11"), .Item("yn11"))
'                TextOb = SearchTextObj("txtNome22")
'                SetTextObjProperties(TextOb, "Testo di prova22", .Item("xn22"), .Item("yn22"))
'                TextOb = SearchTextObj("txtNome33")
'                SetTextObjProperties(TextOb, "Testo di prova33", .Item("xn33"), .Item("yn33"))
'                TextOb = SearchTextObj("txtNome44")
'                SetTextObjProperties(TextOb, "Testo di prova44", .Item("xn44"), .Item("yn44"))



'                TextOb = SearchTextObj("txtCognome1")
'                SetTextObjProperties(TextOb, "Testo di provaC1", .Item("xc1"), .Item("yc1"))
'                TextOb = SearchTextObj("txtCognome2")
'                SetTextObjProperties(TextOb, "Testo di provaC2", .Item("xc2"), .Item("yc2"))
'                TextOb = SearchTextObj("txtCognome3")
'                SetTextObjProperties(TextOb, "Testo di provaC3", .Item("xc3"), .Item("yc3"))
'                TextOb = SearchTextObj("txtCognome4")
'                SetTextObjProperties(TextOb, "Testo di provaC4", .Item("xc4"), .Item("yc4"))
'                TextOb = SearchTextObj("txtCognome11")
'                SetTextObjProperties(TextOb, "Testo di provaC11", .Item("xc11"), .Item("yc11"))
'                TextOb = SearchTextObj("txtCognome22")
'                SetTextObjProperties(TextOb, "Testo di provaC22", .Item("xc22"), .Item("yc22"))
'                TextOb = SearchTextObj("txtCognome33")
'                SetTextObjProperties(TextOb, "Testo di provaC33", .Item("xc33"), .Item("yc33"))
'                TextOb = SearchTextObj("txtCognome44")
'                SetTextObjProperties(TextOb, "Testo di provaC44", .Item("xc44"), .Item("yc44"))


'                TextOb = SearchTextObj("txtAzienda1")
'                SetTextObjProperties(TextOb, "Testo di provaA1", .Item("xa1"), .Item("ya1"))
'                TextOb = SearchTextObj("txtAzienda2")
'                SetTextObjProperties(TextOb, "Testo di provaA2", .Item("xa2"), .Item("ya2"))
'                TextOb = SearchTextObj("txtAzienda3")
'                SetTextObjProperties(TextOb, "Testo di provaA3", .Item("xa3"), .Item("ya3"))
'                TextOb = SearchTextObj("txtAzienda4")
'                SetTextObjProperties(TextOb, "Testo di provaA4", .Item("xa4"), .Item("ya4"))
'                TextOb = SearchTextObj("txtAzienda11")
'                SetTextObjProperties(TextOb, "Testo di provaA11", .Item("xa11"), .Item("ya11"))
'                TextOb = SearchTextObj("txtAzienda22")
'                SetTextObjProperties(TextOb, "Testo di provaA22", .Item("xa22"), .Item("ya22"))
'                TextOb = SearchTextObj("txtAzienda33")
'                SetTextObjProperties(TextOb, "Testo di provaA33", .Item("xa33"), .Item("ya33"))
'                TextOb = SearchTextObj("txtAzienda44")
'                SetTextObjProperties(TextOb, "Testo di provaA44", .Item("xa44"), .Item("ya44"))

'            End With

'            '......
'            '......
'            SetReportMargins()

'        Catch ex As Exception
'            Throw New Exception(ex.Message)
'        End Try
'    End Sub
'    Private Sub SetReportProperties(ByVal Tesserato1 As Tesserato, ByVal Tesserato2 As Tesserato, ByVal RptSet As ReportSettings)
'        Try
'            With RptSet

'                TextOb = SearchTextObj("Matera1")
'                SetTextObjProperties(TextOb, "Matera", .Item("Matera1x"), .Item("Matera1y"))
'                TextOb = SearchTextObj("Matera2")
'                SetTextObjProperties(TextOb, "Matera", .Item("Matera2x"), .Item("Matera2y"))
'                TextOb = SearchTextObj("Matera3")
'                SetTextObjProperties(TextOb, "Matera", .Item("Matera3x"), .Item("Matera3y"))
'                TextOb = SearchTextObj("Matera4")
'                SetTextObjProperties(TextOb, "Matera", .Item("Matera4x"), .Item("Matera4y"))
'                TextOb = SearchTextObj("Matera5")
'                SetTextObjProperties(TextOb, "Matera", .Item("Matera5x"), .Item("Matera5y"))
'                TextOb = SearchTextObj("Matera6")
'                SetTextObjProperties(TextOb, "Matera", .Item("Matera6x"), .Item("Matera6y"))
'                TextOb = SearchTextObj("Matera7")
'                SetTextObjProperties(TextOb, "Matera", .Item("Matera7x"), .Item("Matera7y"))
'                TextOb = SearchTextObj("Matera8")
'                SetTextObjProperties(TextOb, "Matera", .Item("Matera8x"), .Item("Matera8y"))


'                TextOb = SearchTextObj("txtNome1")
'                SetTextObjProperties(TextOb, Tesserato1.Nome, .Item("xn1"), .Item("yn1"))
'                TextOb = SearchTextObj("txtNome2")
'                SetTextObjProperties(TextOb, Tesserato1.Nome, .Item("xn2"), .Item("yn2"))
'                TextOb = SearchTextObj("txtNome3")
'                SetTextObjProperties(TextOb, Tesserato1.Nome, .Item("xn3"), .Item("yn3"))
'                TextOb = SearchTextObj("txtNome4")
'                SetTextObjProperties(TextOb, Tesserato1.Nome, .Item("xn4"), .Item("yn4"))
'                TextOb = SearchTextObj("txtNome11")
'                SetTextObjProperties(TextOb, Tesserato2.Nome, .Item("xn11"), .Item("yn11"))
'                TextOb = SearchTextObj("txtNome22")
'                SetTextObjProperties(TextOb, Tesserato2.Nome, .Item("xn22"), .Item("yn22"))
'                TextOb = SearchTextObj("txtNome33")
'                SetTextObjProperties(TextOb, Tesserato2.Nome, .Item("xn33"), .Item("yn33"))
'                TextOb = SearchTextObj("txtNome44")
'                SetTextObjProperties(TextOb, Tesserato2.Nome, .Item("xn44"), .Item("yn44"))



'                TextOb = SearchTextObj("txtCognome1")
'                SetTextObjProperties(TextOb, Tesserato1.Cognome, .Item("xc1"), .Item("yc1"))
'                TextOb = SearchTextObj("txtCognome2")
'                SetTextObjProperties(TextOb, Tesserato1.Cognome, .Item("xc2"), .Item("yc2"))
'                TextOb = SearchTextObj("txtCognome3")
'                SetTextObjProperties(TextOb, Tesserato1.Cognome, .Item("xc3"), .Item("yc3"))
'                TextOb = SearchTextObj("txtCognome4")
'                SetTextObjProperties(TextOb, Tesserato1.Cognome, .Item("xc4"), .Item("yc4"))
'                TextOb = SearchTextObj("txtCognome11")
'                SetTextObjProperties(TextOb, Tesserato2.Cognome, .Item("xc11"), .Item("yc11"))
'                TextOb = SearchTextObj("txtCognome22")
'                SetTextObjProperties(TextOb, Tesserato2.Cognome, .Item("xc22"), .Item("yc22"))
'                TextOb = SearchTextObj("txtCognome33")
'                SetTextObjProperties(TextOb, Tesserato2.Cognome, .Item("xc33"), .Item("yc33"))
'                TextOb = SearchTextObj("txtCognome44")
'                SetTextObjProperties(TextOb, Tesserato2.Cognome, .Item("xc44"), .Item("yc44"))


'                TextOb = SearchTextObj("txtAzienda1")
'                SetTextObjProperties(TextOb, Tesserato1.Azienda, .Item("xa1"), .Item("ya1"))
'                TextOb = SearchTextObj("txtAzienda2")
'                SetTextObjProperties(TextOb, Tesserato1.Azienda, .Item("xa2"), .Item("ya2"))
'                TextOb = SearchTextObj("txtAzienda3")
'                SetTextObjProperties(TextOb, Tesserato1.Azienda, .Item("xa3"), .Item("ya3"))
'                TextOb = SearchTextObj("txtAzienda4")
'                SetTextObjProperties(TextOb, Tesserato1.Azienda, .Item("xa4"), .Item("ya4"))
'                TextOb = SearchTextObj("txtAzienda11")
'                SetTextObjProperties(TextOb, Tesserato2.Azienda, .Item("xa11"), .Item("ya11"))
'                TextOb = SearchTextObj("txtAzienda22")
'                SetTextObjProperties(TextOb, Tesserato2.Azienda, .Item("xa22"), .Item("ya22"))
'                TextOb = SearchTextObj("txtAzienda33")
'                SetTextObjProperties(TextOb, Tesserato2.Azienda, .Item("xa33"), .Item("ya33"))
'                TextOb = SearchTextObj("txtAzienda44")
'                SetTextObjProperties(TextOb, Tesserato2.Azienda, .Item("xa44"), .Item("ya44"))

'            End With


'            SetReportMargins(RptSet)

'        Catch ex As Exception
'            Throw New Exception(ex.Message)
'        End Try
'    End Sub
'    Private Overloads Sub SetReportMargins(ByVal RptSet As ReportSettings)
'        Dim m As New CrystalDecisions.Shared.PageMargins
'        m.leftMargin = RptSet.Item("Left1")
'        m.rightMargin = RptSet.Item("Right1")
'        m.bottomMargin = RptSet.Item("Bottom1")
'        m.topMargin = RptSet.Item("Top1")
'        Report.PrintOptions.ApplyPageMargins(m)
'    End Sub
'    Private Overloads Sub SetReportMargins()
'        Dim m As New CrystalDecisions.Shared.PageMargins
'        m.leftMargin = ReportSettings.Item("Left1")
'        m.rightMargin = ReportSettings.Item("Right1")
'        m.bottomMargin = ReportSettings.Item("Bottom1")
'        m.topMargin = ReportSettings.Item("Top1")
'        Report.PrintOptions.ApplyPageMargins(m)
'    End Sub
'    Private Overloads Sub SetTextObjProperties(ByVal TextObj As Engine.TextObject, Optional ByVal Value As String = "Prova")
'        Try
'            TextObj.Text = Value
'        Catch ex As Exception
'            Throw (New Exception(ex.Message))
'        End Try
'    End Sub
'    Private Overloads Sub SetTextObjProperties(ByVal TextObj As Engine.TextObject, ByVal Value As String, ByVal x As Int64, ByVal y As Int64)
'        Try
'            TextObj.Text = Value
'            TextObj.Top = y
'            TextObj.Left = x
'        Catch ex As Exception
'            Throw (New Exception(ex.Message))
'        End Try
'    End Sub
'    Private Function SearchTextObj(ByVal Name As String) As Engine.TextObject
'        Try
'            Dim repObj As Engine.ReportObject
'            For Each repObj In Report.ReportDefinition.ReportObjects
'                If repObj.Name = Name Then
'                    Dim txt As Engine.TextObject = DirectCast(repObj, Engine.TextObject)
'                    Return txt
'                End If
'            Next
'            Throw New Exception("Campo del report non trovato!")
'        Catch ex As Exception
'            Throw New Exception(ex.Message)
'        End Try
'    End Function

'    Private Sub FormAnteprima_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
'        Try
'            'Report = CrystalReportViewer1.ReportSource
'            OpenReport()
'            AnteprimaStampa()
'            CrystalReportViewer1.ReportSource = Report
'        Catch ex As Exception
'            MsgBox(ex.Message)
'        End Try
'    End Sub
'End Class
'Imports CrystalDecisions.CrystalReports
Public Class FormAnteprima
    Public ReportSettings As ReportSettings
    ''Private Report As CrystalDecisions.CrystalReports.Engine.ReportDocument
    ''Private TextOb As Engine.TextObject

    'Public Sub Stampa(ByVal Tesserato1 As Tesserato, ByVal Tesserato2 As Tesserato, ByVal RptSet As ReportSettings)

    '    OpenReport()
    '    SetReportProperties(Tesserato1, Tesserato2, RptSet)

    '    Report.PrintToPrinter(1, False, 1, 1)
    '    System.Windows.Forms.Application.DoEvents()

    'End Sub
    'Private Sub OpenReport()

    '    Report = New CrystalDecisions.CrystalReports.Engine.ReportDocument
    '    Report.Load("CrystalReport1.rpt")

    'End Sub
    'Public Sub AnteprimaStampa()


    '    SetReportPropertiesAnteprima()

    'End Sub
    'Private Sub SetReportPropertiesAnteprima()
    '    Report.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperFanfoldStdGerman
    '    With ReportSettings


    '        TextOb = SearchTextObj("Matera1")
    '        SetTextObjProperties(TextOb, federProv, .Item("Matera1x"), .Item("Matera1y"))
    '        TextOb = SearchTextObj("Matera2")
    '        SetTextObjProperties(TextOb, federProv, .Item("Matera2x"), .Item("Matera2y"))
    '        TextOb = SearchTextObj("Matera3")
    '        SetTextObjProperties(TextOb, federProv, .Item("Matera3x"), .Item("Matera3y"))
    '        TextOb = SearchTextObj("Matera4")
    '        SetTextObjProperties(TextOb, federProv, .Item("Matera4x"), .Item("Matera4y"))
    '        TextOb = SearchTextObj("Matera5")
    '        SetTextObjProperties(TextOb, federProv, .Item("Matera5x"), .Item("Matera5y"))
    '        TextOb = SearchTextObj("Matera6")
    '        SetTextObjProperties(TextOb, federProv, .Item("Matera6x"), .Item("Matera6y"))
    '        TextOb = SearchTextObj("Matera7")
    '        SetTextObjProperties(TextOb, federProv, .Item("Matera7x"), .Item("Matera7y"))
    '        TextOb = SearchTextObj("Matera8")
    '        SetTextObjProperties(TextOb, federProv, .Item("Matera8x"), .Item("Matera8y"))




    '        TextOb = SearchTextObj("txtNome1")
    '        SetTextObjProperties(TextOb, "Testo di prova1", .Item("xn1"), .Item("yn1"))
    '        TextOb = SearchTextObj("txtNome2")
    '        SetTextObjProperties(TextOb, "Testo di prova2", .Item("xn2"), .Item("yn2"))
    '        TextOb = SearchTextObj("txtNome3")
    '        SetTextObjProperties(TextOb, "Testo di prova3", .Item("xn3"), .Item("yn3"))
    '        TextOb = SearchTextObj("txtNome4")
    '        SetTextObjProperties(TextOb, "Testo di prova4", .Item("xn4"), .Item("yn4"))
    '        TextOb = SearchTextObj("txtNome11")
    '        SetTextObjProperties(TextOb, "Testo di prova11", .Item("xn11"), .Item("yn11"))
    '        TextOb = SearchTextObj("txtNome22")
    '        SetTextObjProperties(TextOb, "Testo di prova22", .Item("xn22"), .Item("yn22"))
    '        TextOb = SearchTextObj("txtNome33")
    '        SetTextObjProperties(TextOb, "Testo di prova33", .Item("xn33"), .Item("yn33"))
    '        TextOb = SearchTextObj("txtNome44")
    '        SetTextObjProperties(TextOb, "Testo di prova44", .Item("xn44"), .Item("yn44"))



    '        TextOb = SearchTextObj("txtCognome1")
    '        SetTextObjProperties(TextOb, "Testo di provaC1", .Item("xc1"), .Item("yc1"))
    '        TextOb = SearchTextObj("txtCognome2")
    '        SetTextObjProperties(TextOb, "Testo di provaC2", .Item("xc2"), .Item("yc2"))
    '        TextOb = SearchTextObj("txtCognome3")
    '        SetTextObjProperties(TextOb, "Testo di provaC3", .Item("xc3"), .Item("yc3"))
    '        TextOb = SearchTextObj("txtCognome4")
    '        SetTextObjProperties(TextOb, "Testo di provaC4", .Item("xc4"), .Item("yc4"))
    '        TextOb = SearchTextObj("txtCognome11")
    '        SetTextObjProperties(TextOb, "Testo di provaC11", .Item("xc11"), .Item("yc11"))
    '        TextOb = SearchTextObj("txtCognome22")
    '        SetTextObjProperties(TextOb, "Testo di provaC22", .Item("xc22"), .Item("yc22"))
    '        TextOb = SearchTextObj("txtCognome33")
    '        SetTextObjProperties(TextOb, "Testo di provaC33", .Item("xc33"), .Item("yc33"))
    '        TextOb = SearchTextObj("txtCognome44")
    '        SetTextObjProperties(TextOb, "Testo di provaC44", .Item("xc44"), .Item("yc44"))


    '        TextOb = SearchTextObj("txtAzienda1")
    '        SetTextObjProperties(TextOb, "Testo di provaA1", .Item("xa1"), .Item("ya1"))
    '        TextOb = SearchTextObj("txtAzienda2")
    '        SetTextObjProperties(TextOb, "Testo di provaA2", .Item("xa2"), .Item("ya2"))
    '        TextOb = SearchTextObj("txtAzienda3")
    '        SetTextObjProperties(TextOb, "Testo di provaA3", .Item("xa3"), .Item("ya3"))
    '        TextOb = SearchTextObj("txtAzienda4")
    '        SetTextObjProperties(TextOb, "Testo di provaA4", .Item("xa4"), .Item("ya4"))
    '        TextOb = SearchTextObj("txtAzienda11")
    '        SetTextObjProperties(TextOb, "Testo di provaA11", .Item("xa11"), .Item("ya11"))
    '        TextOb = SearchTextObj("txtAzienda22")
    '        SetTextObjProperties(TextOb, "Testo di provaA22", .Item("xa22"), .Item("ya22"))
    '        TextOb = SearchTextObj("txtAzienda33")
    '        SetTextObjProperties(TextOb, "Testo di provaA33", .Item("xa33"), .Item("ya33"))
    '        TextOb = SearchTextObj("txtAzienda44")
    '        SetTextObjProperties(TextOb, "Testo di provaA44", .Item("xa44"), .Item("ya44"))

    '    End With

    '    '......
    '    '......
    '    SetReportMargins()


    'End Sub
    'Private Sub SetReportProperties(ByVal Tesserato1 As Tesserato, ByVal Tesserato2 As Tesserato, ByVal RptSet As ReportSettings)
    '    Report.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperFanfoldStdGerman
    '    With RptSet

    '        TextOb = SearchTextObj("Matera1")
    '        SetTextObjProperties(TextOb, federProv, .Item("Matera1x"), .Item("Matera1y"))
    '        TextOb = SearchTextObj("Matera2")
    '        SetTextObjProperties(TextOb, federProv, .Item("Matera2x"), .Item("Matera2y"))
    '        TextOb = SearchTextObj("Matera3")
    '        SetTextObjProperties(TextOb, federProv, .Item("Matera3x"), .Item("Matera3y"))
    '        TextOb = SearchTextObj("Matera4")
    '        SetTextObjProperties(TextOb, federProv, .Item("Matera4x"), .Item("Matera4y"))
    '        TextOb = SearchTextObj("Matera5")
    '        SetTextObjProperties(TextOb, federProv, .Item("Matera5x"), .Item("Matera5y"))
    '        TextOb = SearchTextObj("Matera6")
    '        SetTextObjProperties(TextOb, federProv, .Item("Matera6x"), .Item("Matera6y"))
    '        TextOb = SearchTextObj("Matera7")
    '        SetTextObjProperties(TextOb, federProv, .Item("Matera7x"), .Item("Matera7y"))
    '        TextOb = SearchTextObj("Matera8")
    '        SetTextObjProperties(TextOb, federProv, .Item("Matera8x"), .Item("Matera8y"))


    '        TextOb = SearchTextObj("txtNome1")
    '        SetTextObjProperties(TextOb, Tesserato1.Nome, .Item("xn1"), .Item("yn1"))
    '        TextOb = SearchTextObj("txtNome2")
    '        SetTextObjProperties(TextOb, Tesserato1.Nome, .Item("xn2"), .Item("yn2"))
    '        TextOb = SearchTextObj("txtNome3")
    '        SetTextObjProperties(TextOb, Tesserato1.Nome, .Item("xn3"), .Item("yn3"))
    '        TextOb = SearchTextObj("txtNome4")
    '        SetTextObjProperties(TextOb, Tesserato1.Nome, .Item("xn4"), .Item("yn4"))
    '        TextOb = SearchTextObj("txtNome11")
    '        SetTextObjProperties(TextOb, Tesserato2.Nome, .Item("xn11"), .Item("yn11"))
    '        TextOb = SearchTextObj("txtNome22")
    '        SetTextObjProperties(TextOb, Tesserato2.Nome, .Item("xn22"), .Item("yn22"))
    '        TextOb = SearchTextObj("txtNome33")
    '        SetTextObjProperties(TextOb, Tesserato2.Nome, .Item("xn33"), .Item("yn33"))
    '        TextOb = SearchTextObj("txtNome44")
    '        SetTextObjProperties(TextOb, Tesserato2.Nome, .Item("xn44"), .Item("yn44"))



    '        TextOb = SearchTextObj("txtCognome1")
    '        SetTextObjProperties(TextOb, Tesserato1.Cognome, .Item("xc1"), .Item("yc1"))
    '        TextOb = SearchTextObj("txtCognome2")
    '        SetTextObjProperties(TextOb, Tesserato1.Cognome, .Item("xc2"), .Item("yc2"))
    '        TextOb = SearchTextObj("txtCognome3")
    '        SetTextObjProperties(TextOb, Tesserato1.Cognome, .Item("xc3"), .Item("yc3"))
    '        TextOb = SearchTextObj("txtCognome4")
    '        SetTextObjProperties(TextOb, Tesserato1.Cognome, .Item("xc4"), .Item("yc4"))
    '        TextOb = SearchTextObj("txtCognome11")
    '        SetTextObjProperties(TextOb, Tesserato2.Cognome, .Item("xc11"), .Item("yc11"))
    '        TextOb = SearchTextObj("txtCognome22")
    '        SetTextObjProperties(TextOb, Tesserato2.Cognome, .Item("xc22"), .Item("yc22"))
    '        TextOb = SearchTextObj("txtCognome33")
    '        SetTextObjProperties(TextOb, Tesserato2.Cognome, .Item("xc33"), .Item("yc33"))
    '        TextOb = SearchTextObj("txtCognome44")
    '        SetTextObjProperties(TextOb, Tesserato2.Cognome, .Item("xc44"), .Item("yc44"))


    '        TextOb = SearchTextObj("txtAzienda1")
    '        SetTextObjProperties(TextOb, Tesserato1.Azienda, .Item("xa1"), .Item("ya1"))
    '        TextOb = SearchTextObj("txtAzienda2")
    '        SetTextObjProperties(TextOb, Tesserato1.Azienda, .Item("xa2"), .Item("ya2"))
    '        TextOb = SearchTextObj("txtAzienda3")
    '        SetTextObjProperties(TextOb, Tesserato1.Azienda, .Item("xa3"), .Item("ya3"))
    '        TextOb = SearchTextObj("txtAzienda4")
    '        SetTextObjProperties(TextOb, Tesserato1.Azienda, .Item("xa4"), .Item("ya4"))
    '        TextOb = SearchTextObj("txtAzienda11")
    '        SetTextObjProperties(TextOb, Tesserato2.Azienda, .Item("xa11"), .Item("ya11"))
    '        TextOb = SearchTextObj("txtAzienda22")
    '        SetTextObjProperties(TextOb, Tesserato2.Azienda, .Item("xa22"), .Item("ya22"))
    '        TextOb = SearchTextObj("txtAzienda33")
    '        SetTextObjProperties(TextOb, Tesserato2.Azienda, .Item("xa33"), .Item("ya33"))
    '        TextOb = SearchTextObj("txtAzienda44")
    '        SetTextObjProperties(TextOb, Tesserato2.Azienda, .Item("xa44"), .Item("ya44"))

    '    End With


    '    SetReportMargins(RptSet)

    'End Sub
    'Private Overloads Sub SetReportMargins(ByVal RptSet As ReportSettings)
    '    Dim m As New CrystalDecisions.Shared.PageMargins
    '    m.leftMargin = RptSet.Item("Left1")
    '    m.rightMargin = RptSet.Item("Right1")
    '    m.bottomMargin = RptSet.Item("Bottom1")
    '    m.topMargin = RptSet.Item("Top1")
    '    Report.PrintOptions.ApplyPageMargins(m)
    'End Sub
    'Private Overloads Sub SetReportMargins()
    '    Dim m As New CrystalDecisions.Shared.PageMargins
    '    m.leftMargin = ReportSettings.Item("Left1")
    '    m.rightMargin = ReportSettings.Item("Right1")
    '    m.bottomMargin = ReportSettings.Item("Bottom1")
    '    m.topMargin = ReportSettings.Item("Top1")
    '    Report.PrintOptions.ApplyPageMargins(m)
    'End Sub
    'Private Overloads Sub SetTextObjProperties(ByVal TextObj As Engine.TextObject, Optional ByVal Value As String = "Prova")

    '    TextObj.Text = Value

    'End Sub
    'Private Overloads Sub SetTextObjProperties(ByVal TextObj As Engine.TextObject, ByVal Value As String, ByVal x As Int64, ByVal y As Int64)

    '    TextObj.Text = Value
    '    TextObj.Top = y
    '    TextObj.Left = x

    'End Sub
    'Private Function SearchTextObj(ByVal Name As String) As Engine.TextObject

    '    Dim repObj As Engine.ReportObject
    '    For Each repObj In Report.ReportDefinition.ReportObjects
    '        If repObj.Name = Name Then
    '            Dim txt As Engine.TextObject = DirectCast(repObj, Engine.TextObject)
    '            Return txt
    '        End If
    '    Next
    '    Throw New Exception("Campo del report non trovato!")

    'End Function

    'Private Sub FormAnteprima_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    Try
    '        'Report = CrystalReportViewer1.ReportSource
    '        OpenReport()
    '        AnteprimaStampa()
    '        CrystalReportViewer1.ReportSource = Report
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Exclamation)
    '    End Try
    'End Sub
End Class

