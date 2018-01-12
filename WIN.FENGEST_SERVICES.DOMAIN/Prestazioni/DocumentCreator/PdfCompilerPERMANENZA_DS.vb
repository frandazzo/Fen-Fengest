Imports WIN.TECHNICAL.PDF_PRINTER
Imports System.Runtime.InteropServices
Imports System.IO

Public Class PdfCompilerPERMANENZA_DS
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
                'pdf.SetCampo("NOME", Prestazione.Utente.Nome)
                'pdf.SetCampo("COGNOME", Prestazione.Utente.Cognome)
                'pdf.SetCampo("codfisc", Prestazione.Utente.CodiceFiscale)
                'pdf.SetCampo("cognome coniuge", "")
                'pdf.SetCampo("datan", Prestazione.Utente.DataNascita)
                'pdf.SetCampo("sess", RetrieveSesso(Prestazione))
                'pdf.SetCampo("domanda numero", "") 'Prestazione.Id.ToString())
                'pdf.SetCampo("nome_echo", Prestazione.Utente.Nome)
                'pdf.SetCampo("cognome_echo", Prestazione.Utente.Cognome)
                'pdf.SetCampo("codfisc_echo", Prestazione.Utente.CodiceFiscale)

                'pdf.SetCampo("luogon", Prestazione.Utente.ComuneNascita.Descrizione)

                'pdf.SetCampo("provnascita", Prestazione.Utente.ProvinciaNascita.Sigla)
                'pdf.SetCampo("cittadinanza", Prestazione.Utente.Nazionalita.Descrizione)
                'pdf.SetCampo("residen", Prestazione.Utente.Residenza.Comune.Descrizione)
                'pdf.SetCampo("vivo", Prestazione.Utente.Residenza.Via)
                'pdf.SetCampo("provres", Prestazione.Utente.Residenza.Provincia.Sigla)
                'pdf.SetCampo("cap", Prestazione.Utente.Residenza.Comune.CAP)
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

                ''pdf.SetCampo("militadata", "militadata")
                ''pdf.SetCampo("data62", "data62")
                ''pdf.SetCampo("data72", "data72")
                ''pdf.SetCampo("data1", "data1")
                ''pdf.SetCampo("data52", "data52")
                ''pdf.SetCampo("provres", "provres")
                ''pdf.SetCampo("data12", "data12")

                ''pdf.SetCampo("data71", "data71")
                ''pdf.SetCampo("NOME", "NOME")
                ''pdf.SetCampo("data51", "data51")
                ''pdf.SetCampo("data41", "data41")
                ''pdf.SetCampo("data31", "data31")
                ''pdf.SetCampo("data42", "data42")
                ''pdf.SetCampo("datan", "datan")
                ''pdf.SetCampo("protocollo", "protocollo")
                ''pdf.SetCampo("COGNOME", "COGNOME")
                ''pdf.SetCampo("SEDE Inps", "SEDE Inps")
                ''pdf.SetCampo("residen", "residen")
                ''pdf.SetCampo("luogon", "luogon")
                ''pdf.SetCampo("PIN", "PIN")
                ''pdf.SetCampo("codfisc", "codfisc")
                ''pdf.SetCampo("cap", "cap")
                ''pdf.SetCampo("vivo", "vivo")
                ''pdf.SetCampo("datafinale", "datafinale")
                ''pdf.SetCampo("civile", "civile")
                ''pdf.SetCampo("descrizione", "descrizione")
                ''pdf.SetCampo("pensio", "pensio")
                ''pdf.SetCampo("sess", "sess")
                ''pdf.SetCampo("data61", "data61")

                '*****************************************************
                'pdf.SetCampo("sede inps", "sede inps")
                pdf.SetCampo("SEDE INPS", Prestazione.Utente.Segreteria.Comune) 'nessuno dei due è visualizzato
                pdf.SetCampo("COGNOME", Prestazione.Utente.Cognome)
                pdf.SetCampo("NOME", Prestazione.Utente.Nome)
                pdf.SetCampo("luogon", Prestazione.Utente.ComuneNascita.Descrizione)
                pdf.SetCampo("datan", Prestazione.Utente.DataNascita)
                pdf.SetCampo("codfisc", Prestazione.Utente.CodiceFiscale)
                pdf.SetCampo("sess", RetrieveSesso(Prestazione))
                pdf.SetCampo("civile", Prestazione.Utente.SituazioneFamiliare.StatoCivile)
                pdf.SetCampo("residen", Prestazione.Utente.Residenza.Comune.Descrizione)
                pdf.SetCampo("provres", Prestazione.Utente.Residenza.Provincia.Sigla)
                pdf.SetCampo("cap", Prestazione.Utente.Residenza.Comune.CAP)
                pdf.SetCampo("vivo", Prestazione.Utente.Residenza.Via)





                'pdf.SetCampo("cognome coniuge", "")
                'pdf.SetCampo("domanda numero", "") 'Prestazione.Id.ToString())
                'pdf.SetCampo("nome_echo", Prestazione.Utente.Nome)
                'pdf.SetCampo("cognome_echo", Prestazione.Utente.Cognome)
                'pdf.SetCampo("codfisc_echo", Prestazione.Utente.CodiceFiscale)
                'pdf.SetCampo("provnascita", Prestazione.Utente.ProvinciaNascita.Sigla)
                'pdf.SetCampo("cittadinanza", Prestazione.Utente.Nazionalita.Descrizione)
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



                'pdf.SetCampo("militadata", "militadata")
                'pdf.SetCampo("data62", "data62")
                'pdf.SetCampo("data72", "data72")
                'pdf.SetCampo("data1", "data1")
                'pdf.SetCampo("data52", "data52")
                'pdf.SetCampo("provres", "provres")
                'pdf.SetCampo("data12", "data12")
                'pdf.SetCampo("data71", "data71")
                'pdf.SetCampo("NOME", "NOME")
                'pdf.SetCampo("data51", "data51")
                'pdf.SetCampo("data41", "data41")
                'pdf.SetCampo("data31", "data31")
                'pdf.SetCampo("data42", "data42")
                'pdf.SetCampo("datan", "datan")
                'pdf.SetCampo("protocollo", "protocollo")
                'pdf.SetCampo("COGNOME", "COGNOME")
                'pdf.SetCampo("SEDE Inps", "SEDE Inps")
                'pdf.SetCampo("residen", "residen")
                'pdf.SetCampo("luogon", "luogon")
                'pdf.SetCampo("PIN", "PIN")
                'pdf.SetCampo("codfisc", "codfisc")
                'pdf.SetCampo("cap", "cap")
                'pdf.SetCampo("vivo", "vivo")
                'pdf.SetCampo("datafinale", "datafinale")
                'pdf.SetCampo("civile", "civile")
                'pdf.SetCampo("descrizione", "descrizione")
                'pdf.SetCampo("pensio", "pensio")
                'pdf.SetCampo("sess", "sess")
                'pdf.SetCampo("data61", "data61")

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