Imports WIN.TECHNICAL.PDF_PRINTER
Imports System.Runtime.InteropServices

Public Class PdfCompilerASSEGNI_FAMIGLIA_NUMEROSA
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

                '***********************************************+++
                'pdf.SetCampo("periodo_1", "periodo_1")
                'pdf.SetCampo("periodo_2", "periodo_2")
                pdf.SetCampo("sede/inps", Prestazione.Utente.Segreteria.Comune)
                pdf.SetCampo("nome", Prestazione.Utente.Nome)
                pdf.SetCampo("cognome", Prestazione.Utente.Cognome)
                pdf.SetCampo("cod_fisc", Prestazione.Utente.CodiceFiscale)
                'pdf.SetCampo("cognome coniuge", "")
                pdf.SetCampo("data_nasc", Prestazione.Utente.DataNascita)
                pdf.SetCampo("luogo_nasc", Prestazione.Utente.ComuneNascita.Descrizione)
                pdf.SetCampo("prov_nasc", Prestazione.Utente.ProvinciaNascita.Sigla)
                pdf.SetCampo("stato_nasc", Prestazione.Utente.Nazionalita.Descrizione)
                pdf.SetCampo("cittadinanza", Prestazione.Utente.Nazionalita.Descrizione)
                pdf.SetCampo("luogo_res", Prestazione.Utente.Residenza.Comune.Descrizione)
                pdf.SetCampo("prov_res", Prestazione.Utente.Residenza.Provincia.Sigla)
                pdf.SetCampo("stato_res", Prestazione.Utente.Nazionalita.Descrizione)
                pdf.SetCampo("indirizzo", Prestazione.Utente.Residenza.Via)
                pdf.SetCampo("cap", Prestazione.Utente.Residenza.Comune.CAP)
                pdf.SetCampo("tel", Prestazione.Utente.Comunicazione.TelefonoCasa)
                pdf.SetCampo("cell", Prestazione.Utente.Comunicazione.Cellulare1)
                pdf.SetCampo("e_mail", Prestazione.Utente.Comunicazione.Mail)


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



                'pdf.SetCampo("stato_nasc_1", "stato_nasc_1")
                'pdf.SetCampo("cell", "cell")
                'pdf.SetCampo("prov_nasc_4", "prov_nasc_4")
                'pdf.SetCampo("indirizzo", "indirizzo")
                'pdf.SetCampo("luogo_nasc_2", "luogo_nasc_2")
                'pdf.SetCampo("cod_fisc_1", "cod_fisc_1")
                'pdf.SetCampo("PIN", "PIN")
                'pdf.SetCampo("cod_fisc_3", "cod_fisc_3")
                'pdf.SetCampo("prov_nasc_2", "prov_nasc_2")
                'pdf.SetCampo("prov_res", "prov_res")
                'pdf.SetCampo("prov_nasc_7", "prov_nasc_7")
                'pdf.SetCampo("luogo_nasc", "luogo_nasc")
                'pdf.SetCampo("data_nasc_1", "data_nasc_1")
                'pdf.SetCampo("stato_nasc_2", "stato_nasc_2")
                'pdf.SetCampo("cognome_5", "cognome_5")
                'pdf.SetCampo("cognome_4", "cognome_4")
                'pdf.SetCampo("cognome_7", "cognome_7")
                'pdf.SetCampo("cognome_6", "cognome_6")
                'pdf.SetCampo("cognome_1", "cognome_1")
                'pdf.SetCampo("luogo_nasc_4", "luogo_nasc_4")
                'pdf.SetCampo("cognome_3", "cognome_3")
                'pdf.SetCampo("cognome_2", "cognome_2")
                'pdf.SetCampo("prov_nasc_6", "prov_nasc_6")
                'pdf.SetCampo("cognome", "cognome")
                'pdf.SetCampo("dataversione", "dataversione")
                'pdf.SetCampo("nome_7", "nome_7")
                'pdf.SetCampo("stato_nasc_7", "stato_nasc_7")
                'pdf.SetCampo("nome_5", "nome_5")
                'pdf.SetCampo("cod_fisc", "cod_fisc")
                'pdf.SetCampo("prov_nasc_1", "prov_nasc_1")
                'pdf.SetCampo("nome_3", "nome_3")
                'pdf.SetCampo("data_nasc_3", "data_nasc_3")
                'pdf.SetCampo("nome_1", "nome_1")
                'pdf.SetCampo("data_nasc_4", "data_nasc_4")
                'pdf.SetCampo("tel", "tel")
                'pdf.SetCampo("prov_nasc_3", "prov_nasc_3")
                'pdf.SetCampo("cod_fisc_4", "cod_fisc_4")
                'pdf.SetCampo("prov_nasc", "prov_nasc")
                'pdf.SetCampo("cod_fisc_5", "cod_fisc_5")
                'pdf.SetCampo("cod_fisc_6", "cod_fisc_6")
                'pdf.SetCampo("data_nasc_2", "data_nasc_2")
                'pdf.SetCampo("prov_nasc_5", "prov_nasc_5")
                'pdf.SetCampo("data_nasc_7", "data_nasc_7")
                'pdf.SetCampo("stato_nasc_5", "stato_nasc_5")
                'pdf.SetCampo("descrizione", "descrizione")
                'pdf.SetCampo("luogo_nasc_7", "luogo_nasc_7")
                'pdf.SetCampo("luogo_nasc_6", "luogo_nasc_6")
                'pdf.SetCampo("cod_fisc_7", "cod_fisc_7")
                'pdf.SetCampo("stato_nasc", "stato_nasc")
                'pdf.SetCampo("data_nasc_6", "data_nasc_6")
                'pdf.SetCampo("data_nasc", "data_nasc")
                'pdf.SetCampo("luogo_res", "luogo_res")
                'pdf.SetCampo("cittadinanza", "cittadinanza")
                'pdf.SetCampo("stato_nasc_6", "stato_nasc_6")
                'pdf.SetCampo("nome", "nome")
                'pdf.SetCampo("stato_res", "stato_res")
                'pdf.SetCampo("stato_nasc_3", "stato_nasc_3")
                'pdf.SetCampo("cod_fisc_2", "cod_fisc_2")
                'pdf.SetCampo("protocollo", "protocollo")
                'pdf.SetCampo("luogo_nasc_5", "luogo_nasc_5")
                'pdf.SetCampo("nomefile", "nomefile")
                'pdf.SetCampo("nome_6", "nome_6")
                'pdf.SetCampo("sede/inps", "sede/inps")
                'pdf.SetCampo("luogo_nasc_1", "luogo_nasc_1")
                'pdf.SetCampo("nome_4", "nome_4")
                'pdf.SetCampo("e_mail", "e_mail")
                'pdf.SetCampo("nome_2", "nome_2")
                'pdf.SetCampo("data/mod", "data/mod")
                'pdf.SetCampo("luogo_nasc_3", "luogo_nasc_3")
                'pdf.SetCampo("data_nasc_5", "data_nasc_5")
                'pdf.SetCampo("stato_nasc_4", "stato_nasc_4")
                'pdf.SetCampo("cap", "cap")

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