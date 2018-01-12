Imports WIN.TECHNICAL.PDF_PRINTER
Imports System.Runtime.InteropServices
Imports System.IO

Public Class PdfCompilerSetting3
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
                If (Environment.Version.Major >= 4) Then
                    Dim folder As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "..\Microsoft.NET\Framework\v2.0.50727")

                    folder = Path.GetFullPath(folder)

                    LoadLibrary(Path.Combine(folder, "vjsnativ.dll"))
                End If
                pdf = New PdfCompiler(fileInput, fileOutput)
                pdf.Setup()
                'pdf.SetCampo("nome", Prestazione.Utente.Nome)
                'pdf.SetCampo("cognome", Prestazione.Utente.Cognome)
                'pdf.SetCampo("codfisc", Prestazione.Utente.CodiceFiscale)
                'pdf.SetCampo("cognome coniuge", "")
                'pdf.SetCampo("datanascita", Prestazione.Utente.DataNascita)
                'pdf.SetCampo("M/F", RetrieveSesso(Prestazione))
                'pdf.SetCampo("domanda numero", "") 'Prestazione.Id.ToString())
                'pdf.SetCampo("nome_echo", Prestazione.Utente.Nome)
                'pdf.SetCampo("cognome_echo", Prestazione.Utente.Cognome)
                'pdf.SetCampo("codfisc_echo", Prestazione.Utente.CodiceFiscale)

                'pdf.SetCampo("comune nascita", Prestazione.Utente.ComuneNascita.Descrizione)

                'pdf.SetCampo("provnascita", Prestazione.Utente.ProvinciaNascita.Sigla)
                'pdf.SetCampo("cittadinanza", Prestazione.Utente.Nazionalita.Descrizione)
                'pdf.SetCampo("comuneresidenza", Prestazione.Utente.Residenza.Comune.Descrizione)
                'pdf.SetCampo("indirizzoresidenza", Prestazione.Utente.Residenza.Via)
                'pdf.SetCampo("provresidenza", Prestazione.Utente.Residenza.Provincia.Sigla)
                'pdf.SetCampo("capresidenza", Prestazione.Utente.Residenza.Comune.CAP)
                'pdf.SetCampo("telefono", Prestazione.Utente.Comunicazione.Cellulare1)
                'pdf.SetCampo("email", Prestazione.Utente.Comunicazione.Mail)
                'pdf.SetCampo("sede inps", "")
                'pdf.SetCampo("B_centro x l'imp_comune", "")
                'pdf.SetCampo("B_data1", "") 'Prestazione.DataRegistrazione)
                'pdf.SetCampo("B_data2", Prestazione.DataDocumento)
                'pdf.SetCampo("B_data3", Prestazione.DataDocumento)
                'pdf.SetCampo("M_sindacato", "FENEAL-UIL 03-03")
                'pdf.SetCampo("M_data", Prestazione.DataDocumento)
                'pdf.SetCampo("L_data", Prestazione.DataDocumento)
                'pdf.SetCampo("com_res", Prestazione.Utente.Residenza.Comune.Descrizione)
                'pdf.SetCampo("prov_nasc", Prestazione.Utente.ProvinciaNascita.Sigla)
                'pdf.SetCampo("comune_nasc", Prestazione.Utente.ComuneNascita.Descrizione)
                'pdf.SetCampo("stato_nasc", Prestazione.Utente.Nazionalita.Descrizione)
                'pdf.SetCampo("data_5", Prestazione.DataDocumento)
                'pdf.SetCampo("data_3", Prestazione.DataDocumento)
                'pdf.SetCampo("data_4", Prestazione.DataDocumento)
                'pdf.SetCampo("cap_res", Prestazione.Utente.Residenza.Comune.CAP)
                'pdf.SetCampo("prov_res", Prestazione.Utente.Residenza.Provincia.Sigla)
                ''pdf.SetCampo("stato_res", Prestazione.Utente.Residenza.Nazione.Descrizione)
                'pdf.SetCampo("ind_res", Prestazione.Utente.Residenza.Via)
                'pdf.SetCampo("data_2", Prestazione.DataDocumento)
                'pdf.SetCampo("num_tel", Prestazione.Utente.Comunicazione.TelefonoCasa)
                'pdf.SetCampo("num_cell", Prestazione.Utente.Comunicazione.Cellulare1)
                'pdf.SetCampo("sindacato", "FENEAL-UIL 03-03")
                'pdf.SetCampo("e-mail", Prestazione.Utente.Comunicazione.Mail)


                '***************************************************************
                pdf.SetCampo("nome", Prestazione.Utente.Nome)
                pdf.SetCampo("cognome", Prestazione.Utente.Cognome)
                pdf.SetCampo("codfisc", Prestazione.Utente.CodiceFiscale)
                pdf.SetCampo("cognome coniuge", "")
                pdf.SetCampo("datanascita", Prestazione.Utente.DataNascita)
                pdf.SetCampo("M/F", RetrieveSesso(Prestazione))
                pdf.SetCampo("domanda numero", "") 'Prestazione.Id.ToString())
                pdf.SetCampo("nome_echo", Prestazione.Utente.Nome)
                pdf.SetCampo("cognome_echo", Prestazione.Utente.Cognome)
                pdf.SetCampo("codfisc_echo", Prestazione.Utente.CodiceFiscale)
                pdf.SetCampo("comune nascita", Prestazione.Utente.ComuneNascita.Descrizione)
                pdf.SetCampo("provnascita", Prestazione.Utente.ProvinciaNascita.Sigla)
                pdf.SetCampo("cittadinanza", Prestazione.Utente.Nazionalita.Descrizione)
                pdf.SetCampo("comuneresidenza", Prestazione.Utente.Residenza.Comune.Descrizione)
                pdf.SetCampo("indirizzoresidenza", Prestazione.Utente.Residenza.Via)
                pdf.SetCampo("provresidenza", Prestazione.Utente.Residenza.Provincia.Sigla)
                pdf.SetCampo("capresidenza", Prestazione.Utente.Residenza.Comune.CAP)
                pdf.SetCampo("telefono", Prestazione.Utente.Comunicazione.Cellulare1)
                pdf.SetCampo("email", Prestazione.Utente.Comunicazione.Mail)
                pdf.SetCampo("sede inps", "")
                pdf.SetCampo("B_centro x l'imp_comune", "")
                pdf.SetCampo("B_data1", "") 'Prestazione.DataRegistrazione)
                pdf.SetCampo("B_data2", Prestazione.DataDocumento)
                pdf.SetCampo("B_data3", Prestazione.DataDocumento)
                pdf.SetCampo("M_sindacato", "FENEAL-UIL 03-03")
                pdf.SetCampo("M_data", Prestazione.DataDocumento)
                pdf.SetCampo("L_data", Prestazione.DataDocumento)
                pdf.SetCampo("com_res", Prestazione.Utente.Residenza.Comune.Descrizione)
                pdf.SetCampo("prov_nasc", Prestazione.Utente.ProvinciaNascita.Sigla)
                pdf.SetCampo("comune_nasc", Prestazione.Utente.ComuneNascita.Descrizione)
                pdf.SetCampo("stato_nasc", Prestazione.Utente.Nazionalita.Descrizione)
                pdf.SetCampo("data_5", Prestazione.DataDocumento)
                pdf.SetCampo("data_3", Prestazione.DataDocumento)
                pdf.SetCampo("data_4", Prestazione.DataDocumento)
                pdf.SetCampo("cap_res", Prestazione.Utente.Residenza.Comune.CAP)
                pdf.SetCampo("prov_res", Prestazione.Utente.Residenza.Provincia.Sigla)
                'pdf.SetCampo("stato_res", Prestazione.Utente.Residenza.Nazione.Descrizione)
                pdf.SetCampo("ind_res", Prestazione.Utente.Residenza.Via)
                pdf.SetCampo("data_2", Prestazione.DataDocumento)
                pdf.SetCampo("num_tel", Prestazione.Utente.Comunicazione.TelefonoCasa)
                pdf.SetCampo("num_cell", Prestazione.Utente.Comunicazione.Cellulare1)
                pdf.SetCampo("sindacato", "FENEAL-UIL 03-03")
                pdf.SetCampo("e-mail", Prestazione.Utente.Comunicazione.Mail)


                pdf.Compile()

                pdf.Dispose()



                'My.Computer.FileSystem.CopyFile(.NomeFileModello, Prestazione.FileOutPut)
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