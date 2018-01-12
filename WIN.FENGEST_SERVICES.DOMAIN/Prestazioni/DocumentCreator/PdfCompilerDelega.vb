Imports WIN.TECHNICAL.PDF_PRINTER
Imports System.Runtime.InteropServices
Public Class PdfCompilerDelega

    Implements IDocumentCreatorAdapter

    Private pdf As PdfCompiler
    Private tp As TipoPrestazione
    Private fileInput As String
    Private fileOutput As String
    <DllImport("kernel32.dll", SetLastError:=True)> _
    Public Shared Function LoadLibrary(ByVal lpFileName As String) As IntPtr
    End Function

    Public Sub CreateDocument(ByVal Prestazione As Prestazione) Implements IDocumentCreatorAdapter.CreateDocument
        Dim m_TipoPrestazione As TipoPrestazione = CType(Prestazione.TipoPrestazione, TipoPrestazione)

        With m_TipoPrestazione
            If .FileModelloExist Then

                Prestazione.SetFileOutput(.GetFileOutputName(Prestazione.Utente))

                tp = Prestazione.TipoPrestazione()
                fileInput = tp.NomeFileModello
                fileOutput = Prestazione.FileOutPut
                pdf = New PdfCompiler(fileInput, fileOutput)
                pdf.Setup()

                   pdf.SetCampo("Data", DateTime.Now.ToShortDateString)
                pdf.SetCampo("il", Prestazione.Utente.DataNascita)
                pdf.SetCampo("impresa", Prestazione.Note)
                pdf.SetCampo("residente", String.Format("{0} ({1})", Prestazione.Utente.Residenza.Comune.Descrizione, Prestazione.Utente.ProvinciaNascita.Sigla))

                pdf.SetCampo("tel", Prestazione.Utente.Comunicazione.Cellulare1)
                pdf.SetCampo("nato a", Prestazione.Utente.ComuneNascita.Descrizione)
                pdf.SetCampo("via", Prestazione.Utente.Residenza.Via)
                pdf.SetCampo("Il sottoscritto", Prestazione.Utente.Cognome + " " + Prestazione.Utente.Nome)

                pdf.Compile
                pdf.Dispose()
            End If
        End With



    End Sub

    Private Function RetrieveSesso(ByVal Prest As Prestazione) As String


        If Prest.Utente.Sesso = AbstractPersona.Sex.Maschio Then
            Return "M"
        End If

        Return "F"


        'If Prest.Utente.Sesso.ToString().Equals("Maschio") = True Then
        'End If
    End Function

End Class
