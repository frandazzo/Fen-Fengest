Imports WIN.GUI.APPLICATION.PRESENTATION
Imports System.Windows.Forms

Public Class Form1

    Private Sub lnkTemplateIQA_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkTemplateIQA.LinkClicked
        Try
            Dim process As New Process
            Dim info As New ProcessStartInfo
            Dim temp As String = Me.GetType.Assembly.CodeBase.Replace("file:///", "")

            Dim s As String = "/WIN.FENGEST.IMPORT.GUI.EXE"

            temp = temp.ToLower.Replace(s.ToLower, "")
            info.FileName = temp & "/Templates/TemplateImportIQA.xlt"
            Diagnostics.Process.Start(info)
            process.Dispose()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub lnkTeplateLL_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkTeplateLL.LinkClicked
        Try
            Dim process As New Process
            Dim info As New ProcessStartInfo
            Dim temp As String = Me.GetType.Assembly.CodeBase.Replace("file:///", "")

            Dim s As String = "/WIN.FENGEST.IMPORT.GUI.EXE"

            temp = temp.ToLower.Replace(s.ToLower, "")
            info.FileName = temp & "/Templates/TemplateImportLiberi.xlt"
            Diagnostics.Process.Start(info)
            process.Dispose()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub lnkTemplateDeleghe_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkTemplateDeleghe.LinkClicked
        Try
            Dim process As New Process
            Dim info As New ProcessStartInfo
            Dim temp As String = Me.GetType.Assembly.CodeBase.Replace("file:///", "")

            Dim s As String = "/WIN.FENGEST.IMPORT.GUI.EXE"

            temp = temp.ToLower.Replace(s.ToLower, "")
            info.FileName = temp & "/Templates/TemplateImportDeleghe.xlt"
            Diagnostics.Process.Start(info)
            process.Dispose()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub lnkTemplateUtenti_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkTemplateUtenti.LinkClicked
        Try
            Dim process As New Process
            Dim info As New ProcessStartInfo
            Dim temp As String = Me.GetType.Assembly.CodeBase.Replace("file:///", "")

            Dim s As String = "/WIN.FENGEST.IMPORT.GUI.EXE"

            temp = temp.ToLower.Replace(s.ToLower, "")
            info.FileName = temp & "/Templates/TemplateImportUtenti.xlt"
            Diagnostics.Process.Start(info)
            process.Dispose()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub lnkTemplateAziende_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkTemplateAziende.LinkClicked
        Try
            Dim process As New Process
            Dim info As New ProcessStartInfo
            Dim temp As String = Me.GetType.Assembly.CodeBase.Replace("file:///", "")

            Dim s As String = "/WIN.FENGEST.IMPORT.GUI.EXE"

            temp = temp.ToLower.Replace(s.ToLower, "")
            info.FileName = temp & "/Templates/TemplateImportAziende.xlt"
            Diagnostics.Process.Start(info)
            process.Dispose()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub LinkLabel11_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel11.LinkClicked
        Try
            Dim process As New Process
            Dim info As New ProcessStartInfo
            Dim temp As String = Me.GetType.Assembly.CodeBase.Replace("file:///", "")

            Dim s As String = "/WIN.FENGEST.IMPORT.GUI.EXE"

            temp = temp.ToLower.Replace(s.ToLower, "")
            info.FileName = temp & "/Templates/Nazioni_Regioni_Provincie_Comuni.xlt"




            Diagnostics.Process.Start(info)
            process.Dispose()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub lnkImportIQA_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkImportIQA.LinkClicked
        Try

            Dim frm As New FrmImportIQA

            frm.ShowDialog()


            frm.Dispose()


        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub lnkLiberi_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkLiberi.LinkClicked
        Try

            Dim frm As New FrmImportLiberi

            frm.ShowDialog()


            frm.Dispose()


        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try

    End Sub

    Private Sub lnkDeleghe_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkDeleghe.LinkClicked
        Try

            Dim frm As New FrmImportDeleghe

            frm.ShowDialog()


            frm.Dispose()


        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub lnkUtenti_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkUtenti.LinkClicked
        Try

            Dim frm As New FrmImportUtenti

            frm.ShowDialog()


            frm.Dispose()


        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub lnkAziende_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkAziende.LinkClicked
        Try

            Dim frm As New FrmImportAziende

            frm.ShowDialog()


            frm.Dispose()


        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            Dim process As New Process
            Dim info As New ProcessStartInfo
            Dim temp As String = Me.GetType.Assembly.CodeBase.Replace("file:///", "")

            Dim s As String = "/WIN.FENGEST.IMPORT.GUI.EXE"

            temp = temp.ToLower.Replace(s.ToLower, "")
            info.FileName = temp & "/Templates/TemplateImportRevoche.xlt"
            Diagnostics.Process.Start(info)
            process.Dispose()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Try

            Dim frm As New FrmImportRevoche

            frm.ShowDialog()


            frm.Dispose()


        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        Dim frm As New FrmWizardInps

        frm.ShowDialog()

        frm.Dispose()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Try
            Dim process As New Process
            Dim info As New ProcessStartInfo
            Dim temp As String = Me.GetType.Assembly.CodeBase.Replace("file:///", "")

            Dim s As String = "/WIN.FENGEST.IMPORT.GUI.EXE"

            temp = temp.ToLower.Replace(s.ToLower, "")
            info.FileName = temp & "/Templates/TemplateImportIQI.xlt"
            Diagnostics.Process.Start(info)
            process.Dispose()
        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub LinkLabel4_Click(sender As System.Object, e As System.EventArgs) Handles LinkLabel4.Click

    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Try

            Dim frm As New FrmQuoteInps

            frm.ShowDialog()


            frm.Dispose()


        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub

    Private Sub LinkLabel6_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel6.LinkClicked
        Try

            Dim frm As New FrmQuoteInpsDaPath

            frm.ShowDialog()


            frm.Dispose()


        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
End Class