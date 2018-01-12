Imports WIN.TECHNICAL.PDF_PRINTER
Imports System.Runtime.InteropServices

Public Class PdfCompilerMODELLO_DETRAZIONI
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


                '********************************************++
                pdf.SetCampo("sede/inps", Prestazione.Utente.Segreteria.Comune)
                pdf.SetCampo("cognome", Prestazione.Utente.Cognome)
                pdf.SetCampo("nome", Prestazione.Utente.Nome)
                pdf.SetCampo("cod_fisc", Prestazione.Utente.CodiceFiscale)
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
                pdf.SetCampo("dom_fisc", "Come residenza")
                pdf.SetCampo("tel", Prestazione.Utente.Comunicazione.TelefonoCasa)
                pdf.SetCampo("tel_cell", Prestazione.Utente.Comunicazione.Cellulare1)
                pdf.SetCampo("e-mail", "                               " + Prestazione.Utente.Comunicazione.Mail)
                'il campo e-mail si sovrappone alla laber e perciò sono inseriti degli spazi bianchi iniziali
                'pdf.SetCampo("cognome2", "cognome2")
                Try


                    'controllo che esista in coniuge
                    If Not String.IsNullOrEmpty(Prestazione.Utente.SituazioneFamiliare.Coniuge.Cognome) Then
                        'inserisco i dati del coniuge
                        pdf.SetCampo("nome_2", Prestazione.Utente.SituazioneFamiliare.Coniuge.Nome)
                        pdf.SetCampo("cognome_2", Prestazione.Utente.SituazioneFamiliare.Coniuge.Cognome)
                        pdf.SetCampo("cod_fisc_2", Prestazione.Utente.SituazioneFamiliare.Coniuge.CodiceFiscale)
                        pdf.SetCampo("indirizzo_2", Prestazione.Utente.Residenza.Via)
                        pdf.SetCampo("prov_res_2", Prestazione.Utente.Residenza.Provincia.Sigla)
                        pdf.SetCampo("stato_res_2", Prestazione.Utente.Nazionalita.Descrizione)
                        pdf.SetCampo("cap_2", Prestazione.Utente.Residenza.Comune.CAP)
                        pdf.SetCampo("dom_fisc_2", "Come residenza")
                        Try

                            Dim dati As DatiFiscali = GeoLocationFacade.Instance.CalcolaDatiFiscali(Prestazione.Utente.SituazioneFamiliare.Coniuge.CodiceFiscale)
                            pdf.SetCampo("data_nasc_2", dati.DataNascita)
                            pdf.SetCampo("luogo_nasc_2", dati.Comune.Descrizione)
                            pdf.SetCampo("prov_nasc_2", dati.Provincia.Descrizione)
                            pdf.SetCampo("stato_nasc_2", dati.Nazione.Descrizione)
                            pdf.SetCampo("cittadinanza_2", dati.Nazione.Descrizione)
                        Catch ex As InvalidFiscalCodeException
                            'lasci i campi vuoti
                        Catch ex1 As Exception

                        End Try
                    End If
                Catch ex As Exception

                End Try
                'pdf.SetCampo("M/F", RetrieveSesso(Prestazione))
                'pdf.SetCampo("domanda numero", "") 'Prestazione.Id.ToString())
                'pdf.SetCampo("nome_echo", Prestazione.Utente.Nome)
                'pdf.SetCampo("cognome_echo", Prestazione.Utente.Cognome)
                'pdf.SetCampo("codfisc_echo", Prestazione.Utente.CodiceFiscale)
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



                'pdf.SetCampo("info 1b", "info 1b")
                'pdf.SetCampo("stato_nasc", "stato_nasc")
                'pdf.SetCampo("prov_res_2", "prov_res_2")
                'pdf.SetCampo("stato_nasc_2", "stato_nasc_2")
                'pdf.SetCampo("inf1a", "inf1a")
                'pdf.SetCampo("fam/data_nasc_5", "fam/data_nasc_5")
                'pdf.SetCampo("fam/nome_8", "fam/nome_8")
                'pdf.SetCampo("fam/prov_nasc_7", "fam/prov_nasc_7")
                'pdf.SetCampo("fam/data_nasc_6", "fam/data_nasc_6")
                'pdf.SetCampo("prov_nasc", "prov_nasc")
                'pdf.SetCampo("fam/nome_3", "fam/nome_3")
                'pdf.SetCampo("luogo_nasc", "luogo_nasc")
                'pdf.SetCampo("tel_cell", "tel_cell")
                'pdf.SetCampo("luogo_res_2", "luogo_res_2")
                'pdf.SetCampo("fam/nome_5", "fam/nome_5")
                'pdf.SetCampo("cap", "cap")
                'pdf.SetCampo("fam/cod_fisc_1", "fam/cod_fisc_1")
                'pdf.SetCampo("fam/stato_nasc_8", "fam/stato_nasc_8")
                'pdf.SetCampo("fam/data_4", "fam/data_4")
                'pdf.SetCampo("info 8", "info 8")
                'pdf.SetCampo("fam/stato_nasc_4", "fam/stato_nasc_4")
                'pdf.SetCampo("fam/luogo_nasc_5", "fam/luogo_nasc_5")
                'pdf.SetCampo("fam/luogo_nasc_1", "fam/luogo_nasc_1")
                'pdf.SetCampo("PIN", "PIN")
                'pdf.SetCampo("fam/stato_nasc_1", "fam/stato_nasc_1")
                'pdf.SetCampo("fam/data_3", "fam/data_3")
                'pdf.SetCampo("protocollo", "protocollo")
                'pdf.SetCampo("cognome", "cognome")
                'pdf.SetCampo("cognome_2", "cognome_2")
                'pdf.SetCampo("data_nasc_2", "data_nasc_2")
                'pdf.SetCampo("fam/data_nasc_1", "fam/data_nasc_1")
                'pdf.SetCampo("e-mail", "e-mail")
                'pdf.SetCampo("luogo_res", "luogo_res")
                'pdf.SetCampo("fam/nome_7", "fam/nome_7")
                'pdf.SetCampo("inf2a", "inf2a")
                'pdf.SetCampo("fam/prov_nasc_3", "fam/prov_nasc_3")
                'pdf.SetCampo("fam/data_nasc_2", "fam/data_nasc_2")
                'pdf.SetCampo("indirizzo_2", "indirizzo_2")
                'pdf.SetCampo("fam/nome_2", "fam/nome_2")
                'pdf.SetCampo("nomefile", "nomefile")
                'pdf.SetCampo("fam/prov_nasc_6", "fam/prov_nasc_6")
                'pdf.SetCampo("fam/data_nasc_7", "fam/data_nasc_7")
                'pdf.SetCampo("fam/cognome_8", "fam/cognome_8")
                'pdf.SetCampo("fam/cognome_9", "fam/cognome_9")
                'pdf.SetCampo("dom_fisc", "dom_fisc")
                'pdf.SetCampo("cod_fisc_2", "cod_fisc_2")
                'pdf.SetCampo("info 9", "info 9")
                'pdf.SetCampo("fam/data_7", "fam/data_7")
                'pdf.SetCampo("data_modello", "data_modello")
                'pdf.SetCampo("cod_fisc", "cod_fisc")
                'pdf.SetCampo("fam/cognome_1", "fam/cognome_1")
                'pdf.SetCampo("fam/cognome_2", "fam/cognome_2")
                'pdf.SetCampo("fam/cognome_3", "fam/cognome_3")
                'pdf.SetCampo("fam/cognome_4", "fam/cognome_4")
                'pdf.SetCampo("fam/cognome_5", "fam/cognome_5")
                'pdf.SetCampo("fam/cognome_6", "fam/cognome_6")
                'pdf.SetCampo("fam/cognome_7", "fam/cognome_7")
                'pdf.SetCampo("fam/data_2", "fam/data_2")
                'pdf.SetCampo("fam/stato_nasc_9", "fam/stato_nasc_9")
                'pdf.SetCampo("fam/stato_nasc_5", "fam/stato_nasc_5")
                'pdf.SetCampo("fam/prov_nasc_9", "fam/prov_nasc_9")
                'pdf.SetCampo("fam/luogo_nasc_2", "fam/luogo_nasc_2")
                'pdf.SetCampo("stato_res_2", "stato_res_2")
                'pdf.SetCampo("fam/stato_nasc_2", "fam/stato_nasc_2")
                'pdf.SetCampo("fam/luogo_nasc_3", "fam/luogo_nasc_3")
                'pdf.SetCampo("fam/data_9", "fam/data_9")
                'pdf.SetCampo("fam/cod_fisc_6", "fam/cod_fisc_6")
                'pdf.SetCampo("fam/nome_6", "fam/nome_6")
                'pdf.SetCampo("cap_2", "cap_2")
                'pdf.SetCampo("fam/prov_nasc_8", "fam/prov_nasc_8")
                'pdf.SetCampo("cittadinanza", "cittadinanza")
                'pdf.SetCampo("fam/luogo_nasc_4", "fam/luogo_nasc_4")
                'pdf.SetCampo("tel_cell_2", "tel_cell_2")
                'pdf.SetCampo("inf3a", "inf3a")
                'pdf.SetCampo("info 2a", "info 2a")
                'pdf.SetCampo("fam/cod_fisc_2", "fam/cod_fisc_2")
                'pdf.SetCampo("fam/nome_1", "fam/nome_1")
                'pdf.SetCampo("fam/prov_nasc_2", "fam/prov_nasc_2")
                'pdf.SetCampo("fam/data_nasc_3", "fam/data_nasc_3")
                'pdf.SetCampo("fam/luogo_nasc_6", "fam/luogo_nasc_6")
                'pdf.SetCampo("info 3b", "info 3b")
                'pdf.SetCampo("dataversione", "dataversione")
                'pdf.SetCampo("fam/cod_fisc_7", "fam/cod_fisc_7")
                'pdf.SetCampo("fam/prov_nasc_1", "fam/prov_nasc_1")
                'pdf.SetCampo("data_decorr", "data_decorr")
                'pdf.SetCampo("fam/data_6", "fam/data_6")
                'pdf.SetCampo("indirizzo", "indirizzo")
                'pdf.SetCampo("fam/cod_fisc_8", "fam/cod_fisc_8")
                'pdf.SetCampo("data_nasc", "data_nasc")
                'pdf.SetCampo("cittadinanza_2", "cittadinanza_2")
                'pdf.SetCampo("descrizione", "descrizione")
                'pdf.SetCampo("fam/data_nasc_9", "fam/data_nasc_9")
                'pdf.SetCampo("luogo_nasc_2", "luogo_nasc_2")
                'pdf.SetCampo("fam/prov_nasc_4", "fam/prov_nasc_4")
                'pdf.SetCampo("fam/prov_nasc_5", "fam/prov_nasc_5")
                'pdf.SetCampo("fam/data_8", "fam/data_8")
                'pdf.SetCampo("prov_res", "prov_res")
                'pdf.SetCampo("fam/stato_nasc_6", "fam/stato_nasc_6")
                'pdf.SetCampo("fam/luogo_nasc_7", "fam/luogo_nasc_7")
                'pdf.SetCampo("tel_2", "tel_2")
                'pdf.SetCampo("fam/stato_nasc_3", "fam/stato_nasc_3")
                'pdf.SetCampo("nome_2", "nome_2")
                'pdf.SetCampo("fam/cod_fisc_3", "fam/cod_fisc_3")
                'pdf.SetCampo("fam/luogo_nasc_9", "fam/luogo_nasc_9")
                'pdf.SetCampo("info 2b", "info 2b")
                'pdf.SetCampo("fam/cod_fisc_4", "fam/cod_fisc_4")
                'pdf.SetCampo("inf4a", "inf4a")
                'pdf.SetCampo("sede/inps", "sede/inps")
                'pdf.SetCampo("fam/data_1", "fam/data_1")
                'pdf.SetCampo("fam/data_nasc_4", "fam/data_nasc_4")
                'pdf.SetCampo("info 1a", "info 1a")
                'pdf.SetCampo("fam/cod_fisc_9", "fam/cod_fisc_9")
                'pdf.SetCampo("nome", "nome")
                'pdf.SetCampo("fam/data_nasc_8", "fam/data_nasc_8")
                'pdf.SetCampo("stato_res", "stato_res")
                'pdf.SetCampo("fam/nome_9", "fam/nome_9")
                'pdf.SetCampo("fam/cod_fisc_5", "fam/cod_fisc_5")
                'pdf.SetCampo("prov_nasc_2", "prov_nasc_2")
                'pdf.SetCampo("tel", "tel")
                'pdf.SetCampo("fam/nome_4", "fam/nome_4")
                'pdf.SetCampo("dom_fisc_2", "dom_fisc_2")
                'pdf.SetCampo("fam/luogo_nasc_8", "fam/luogo_nasc_8")
                'pdf.SetCampo("fam/stato_nasc_7", "fam/stato_nasc_7")
                'pdf.SetCampo("fam/data_5", "fam/data_5")

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