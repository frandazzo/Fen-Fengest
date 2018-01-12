﻿Imports WIN.TECHNICAL.PDF_PRINTER
Imports System.Runtime.InteropServices
Imports System.IO

Public Class PdfCompilerSetting18
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


                '*********************************************
                pdf.SetCampo("A_cognome", Prestazione.Utente.Cognome)
                pdf.SetCampo("A_nome", Prestazione.Utente.Nome)
                pdf.SetCampo("A_datanascita", Prestazione.Utente.DataNascita)
                pdf.SetCampo("A_comune nascita", Prestazione.Utente.ComuneNascita.Descrizione)
                pdf.SetCampo("A_provnascita", Prestazione.Utente.ProvinciaNascita.Sigla)
                pdf.SetCampo("A_codfisc", Prestazione.Utente.CodiceFiscale)
                pdf.SetCampo("A_indirizzoresidenza", Prestazione.Utente.Residenza.Via)
                pdf.SetCampo("A_capresidenza", Prestazione.Utente.Residenza.Comune.CAP)
                pdf.SetCampo("A_comuneresidenza", Prestazione.Utente.Residenza.Comune.Descrizione)
                pdf.SetCampo("A_provresidenza", Prestazione.Utente.Residenza.Provincia.Sigla)

                'pdf.SetCampo("cognome coniuge", "")
                'pdf.SetCampo("M/F", RetrieveSesso(Prestazione))
                'pdf.SetCampo("domanda numero", "") 'Prestazione.Id.ToString())
                'pdf.SetCampo("nome_echo", Prestazione.Utente.Nome)
                'pdf.SetCampo("cognome_echo", Prestazione.Utente.Cognome)
                'pdf.SetCampo("codfisc_echo", Prestazione.Utente.CodiceFiscale)
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

                'pdf.SetCampo("B_adottato/a", "B_adottato/a")
                'pdf.SetCampo("B_cognome", "B_cognome")
                'pdf.SetCampo("num civico", "num civico")
                'pdf.SetCampo("C7_professione", "C7_professione")
                'pdf.SetCampo("indirizzoazienda", "indirizzoazienda")
                'pdf.SetCampo("doc/allegati_altro 1", "doc/allegati_altro 1")
                'pdf.SetCampo("C2_datanascita", "C2_datanascita")
                'pdf.SetCampo("D_anno_8", "D_anno_8")
                'pdf.SetCampo("Dichiara_settore appart", "Dichiara_settore appart")
                'pdf.SetCampo("D_anno_3", "D_anno_3")
                'pdf.SetCampo("C5_cognome/nome", "C5_cognome/nome")
                'pdf.SetCampo("C3_datanascita", "C3_datanascita")
                'pdf.SetCampo("B_data 2", "B_data 2")
                'pdf.SetCampo("B_provresidenza", "B_provresidenza")
                'pdf.SetCampo("domanda al", "domanda al")
                'pdf.SetCampo("C2_professione", "C2_professione")
                'pdf.SetCampo("ricevuta_nome", "ricevuta_nome")
                'pdf.SetCampo("dichiara n° giorni", "dichiara n° giorni")
                'pdf.SetCampo("A_indirizzoresidenza", "A_indirizzoresidenza")
                'pdf.SetCampo("C6_datanascita", "C6_datanascita")
                'pdf.SetCampo("A_provnascita", "A_provnascita")
                'pdf.SetCampo("protocollo", "protocollo")
                'pdf.SetCampo("codice patronato", "codice patronato")
                'pdf.SetCampo("C6_rapp/parent", "C6_rapp/parent")
                'pdf.SetCampo("ricevuta_cognome", "ricevuta_cognome")
                'pdf.SetCampo("C1_rapp/parent", "C1_rapp/parent")
                'pdf.SetCampo("D_anno_7", "D_anno_7")
                'pdf.SetCampo("B_codfisc", "B_codfisc")
                'pdf.SetCampo("D_anno_5", "D_anno_5")
                'pdf.SetCampo("D_anno_6", "D_anno_6")
                'pdf.SetCampo("D_anno_2", "D_anno_2")
                'pdf.SetCampo("B_provnascita", "B_provnascita")
                'pdf.SetCampo("nomefile", "nomefile")
                'pdf.SetCampo("Dich/resp_data2", "Dich/resp_data2")
                'pdf.SetCampo("A_codfisc", "A_codfisc")
                'pdf.SetCampo("C6_professione", "C6_professione")
                'pdf.SetCampo("C5_datanascita", "C5_datanascita")
                'pdf.SetCampo("azienda", "azienda")
                'pdf.SetCampo("B_nome", "B_nome")
                'pdf.SetCampo("sede inps", "	ede inps")
                'pdf.SetCampo("comune azienda", "comune azienda")
                'pdf.SetCampo("C2_cognome/nome", "C2_cognome/nome")
                'pdf.SetCampo("C3_rapp/parent", "C3_rapp/parent")
                'pdf.SetCampo("C8_datanascita", "C8_datanascita")
                'pdf.SetCampo("PIN", "PIN")
                'pdf.SetCampo("Dichiara_matr inps", "Dichiara_matr inps")
                'pdf.SetCampo("A_nome", "A_nome")
                'pdf.SetCampo("C1_professione", "C1_professione")
                'pdf.SetCampo("C7_rapp/parent", "C7_rapp/parent")
                'pdf.SetCampo("C1_datanascita", "C1_datanascita")
                'pdf.SetCampo("B_comune nascita", "B_comune nascita")
                'pdf.SetCampo("A_provresidenza", "A_provresidenza")
                'pdf.SetCampo("C6_cognome/nome", "C6_cognome/nome")
                'pdf.SetCampo("C8_rapp/parent", "C8_rapp/parent")
                'pdf.SetCampo("B_affidato/a", "B_affidato/a")
                'pdf.SetCampo("C2_rapp/parent", "C2_rapp/parent")
                'pdf.SetCampo("firma patronato", "firma patronato")
                'pdf.SetCampo("C5_professione", "C5_professione")
                'pdf.SetCampo("C7_cognome/nome", "C7_cognome/nome")
                'pdf.SetCampo("C5_rapp/parent", "C5_rapp/parent")
                'pdf.SetCampo("D_anno_1", "D_anno_1")
                'pdf.SetCampo("C8_professione", "C8_professione")
                'pdf.SetCampo("Dich/resp_data1", "Dich/resp_data1")
                'pdf.SetCampo("comune lavoro", "comune lavoro")
                'pdf.SetCampo("A_comune nascita", "A_comune nascita")
                'pdf.SetCampo("C7_datanascita", "C7_datanascita")
                'pdf.SetCampo("domanda dal", "domanda dal")
                'pdf.SetCampo("patronato", "patronato")
                'pdf.SetCampo("C1_cognome/nome", "C1_cognome/nome")
                'pdf.SetCampo("B_datanascita", "B_datanascita")
                'pdf.SetCampo("A_capresidenza", "A_capresidenza")
                'pdf.SetCampo("dataversione", "dataversione")
                'pdf.SetCampo("D_anno_12", "D_anno_12")
                'pdf.SetCampo("C4_rapp/parent", "C4_rapp/parent")
                'pdf.SetCampo("D_anno_10", "D_anno_10")
                'pdf.SetCampo("D_anno_11", "D_anno_11")
                'pdf.SetCampo("A_comuneresidenza", "A_comuneresidenza")
                'pdf.SetCampo("num pratica patronato", "num pratica patronato")
                'pdf.SetCampo("comune abitazione", "comune abitazione")
                'pdf.SetCampo("Dichiara_data 1", "Dichiara_data 1")
                'pdf.SetCampo("A_cognome", "A_cognome")
                'pdf.SetCampo("B_gradoparent", "B_gradoparent")
                'pdf.SetCampo("Dich/resp_data3", "Dich/resp_data3")
                'pdf.SetCampo("C8_cognome/nome", "C8_cognome/nome")
                'pdf.SetCampo("C4_professione", "C4_professione")
                'pdf.SetCampo("descrizione", "descrizione")
                'pdf.SetCampo("D_anno_9", "D_anno_9")
                'pdf.SetCampo("A_telefono", "A_telefono")
                'pdf.SetCampo("Dichiara_qualifica", "Dichiara_qualifica")
                'pdf.SetCampo("B_ASL di", "B_ASL di")
                'pdf.SetCampo("D_anno_4", "D_anno_4")
                'pdf.SetCampo("B_data 1", "B_data 1")
                'pdf.SetCampo("B_indirizzoresidenza", "B_indirizzoresidenza")
                'pdf.SetCampo("C4_datanascita", "C4_datanascita")
                'pdf.SetCampo("C4_cognome/nome", "C4_cognome/nome")
                'pdf.SetCampo("B_capresidenza", "B_capresidenza")
                'pdf.SetCampo("B_comuneresidenza", "B_comuneresidenza")
                'pdf.SetCampo("A_datanascita", "A_datanascita")
                'pdf.SetCampo("C3_professione", "C3_professione")
                'pdf.SetCampo("C3_cognome/nome", "C3_cognome/nome")

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