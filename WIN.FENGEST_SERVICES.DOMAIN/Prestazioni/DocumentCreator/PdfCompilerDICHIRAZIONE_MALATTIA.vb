﻿Imports WIN.TECHNICAL.PDF_PRINTER
Imports System.Runtime.InteropServices

Public Class PdfCompilerDICHIRAZIONE_MALATTIA
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


                pdf.SetCampo("cognome", Prestazione.Utente.Cognome)
                pdf.SetCampo("nome", Prestazione.Utente.Nome)
                pdf.SetCampo("datanascita", Prestazione.Utente.DataNascita)
                pdf.SetCampo("comune nascita", Prestazione.Utente.ComuneNascita.Descrizione)
                pdf.SetCampo("comuneresidenza", Prestazione.Utente.Residenza.Comune.Descrizione)
                pdf.SetCampo("provresidenza", Prestazione.Utente.Residenza.Provincia.Sigla)
                pdf.SetCampo("indirizzoresidenza", Prestazione.Utente.Residenza.Via)
                'pdf.SetCampo("num civico", "num civico")
                pdf.SetCampo("telefono", Prestazione.Utente.Comunicazione.TelefonoCasa)
                pdf.SetCampo("email", Prestazione.Utente.Comunicazione.Mail)
                pdf.SetCampo("codfisc", Prestazione.Utente.CodiceFiscale)



                'pdf.SetCampo("cognome coniuge", "")
                'pdf.SetCampo("M/F", RetrieveSesso(Prestazione))
                'pdf.SetCampo("domanda numero", "") 'Prestazione.Id.ToString())
                'pdf.SetCampo("nome_echo", Prestazione.Utente.Nome)
                'pdf.SetCampo("cognome_echo", Prestazione.Utente.Cognome)
                'pdf.SetCampo("codfisc_echo", Prestazione.Utente.CodiceFiscale)
                'pdf.SetCampo("provnascita", Prestazione.Utente.ProvinciaNascita.Sigla)
                'pdf.SetCampo("cittadinanza", Prestazione.Utente.Nazionalita.Descrizione)
                'pdf.SetCampo("capresidenza", Prestazione.Utente.Residenza.Comune.CAP)
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

                'pdf.SetCampo("SUB1_cognome teste", "SUB1_cognome teste")
                'pdf.SetCampo("SUB1_data3", "SUB1_data3")
                'pdf.SetCampo("inf  2", "inf  2")
                'pdf.SetCampo("descrizione_1", "descrizione_1")
                'pdf.SetCampo("SUB1_data", "SUB1_data")
                'pdf.SetCampo("descrizione_3", "descrizione_3")
                'pdf.SetCampo("A_data", "A_data")
                'pdf.SetCampo("1_datanascita cond2", "1_datanascita cond2")
                'pdf.SetCampo("orario di lavoro", "orario di lavoro")
                'pdf.SetCampo("SUB1_luogo infort", "SUB1_luogo infort")
                'pdf.SetCampo("2_sede autorità", "2_sede autorità")
                'pdf.SetCampo("SUB1_descr1", "SUB1_descr1")
                'pdf.SetCampo("SUB2_quanto tempo", "SUB2_quanto tempo")
                'pdf.SetCampo("A_num civico teste 3", "A_num civico teste 3")
                'pdf.SetCampo("SUB2_sede inail", "SUB2_sede inail")
                'pdf.SetCampo("1_num civico propr2", "1_num civico propr2")
                'pdf.SetCampo("SUB1_data2", "SUB1_data2")
                'pdf.SetCampo("A_num civico teste 2", "A_num civico teste 2")
                'pdf.SetCampo("1_comuneresidenza cond2", "1_comuneresidenza cond2")
                'pdf.SetCampo("2_cognome", "2_cognome")
                'pdf.SetCampo("data assunzione", "data assunzione")
                'pdf.SetCampo("A_cognome teste 2", "A_cognome teste 2")
                'pdf.SetCampo("A_cognome teste 3", "A_cognome teste 3")
                'pdf.SetCampo("A_cognome teste 1", "A_cognome teste 1")
                'pdf.SetCampo("1_provresidenza cond2", "1_provresidenza cond2")
                'pdf.SetCampo("num civico", "num civico")
                'pdf.SetCampo("data modello", "data modello")
                'pdf.SetCampo("1_comune nascita propr2", "1_comune nascita propr2")
                'pdf.SetCampo("1_comune nascita cond2", "1_comune nascita cond2")
                'pdf.SetCampo("1_nome cond2", "1_nome cond2")
                'pdf.SetCampo("SUB1_diagnosi", "SUB1_diagnosi")
                'pdf.SetCampo("indirizzoresidenza", "indirizzoresidenza")
                'pdf.SetCampo("2_provresidenza", "2_provresidenza")
                'pdf.SetCampo("protocollo", "protocollo")
                'pdf.SetCampo("cognome", "cognome")
                'pdf.SetCampo("telefono", "telefono")
                'pdf.SetCampo("1_num polizza2", "1_num polizza2")
                'pdf.SetCampo("1_comune nascita cond", "1_comune nascita cond")
                'pdf.SetCampo("email", "email")
                'pdf.SetCampo("1_num civico cond", "1_num civico cond")
                'pdf.SetCampo("A_provresidenza teste 1", "A_provresidenza teste 1")
                'pdf.SetCampo("1_indirizzoresidenza cond2", "1_indirizzoresidenza cond2")
                'pdf.SetCampo("SUB1_orario2", "SUB1_orario2")
                'pdf.SetCampo("A_indirizzoresidenza teste 1", "A_indirizzoresidenza teste 1")
                'pdf.SetCampo("SUB1_cognome", "SUB1_cognome")
                'pdf.SetCampo("inf  16", "inf  16")
                'pdf.SetCampo("1_cognome propr2", "1_cognome propr2")
                'pdf.SetCampo("1_num polizza", "1_num polizza")
                'pdf.SetCampo("nomefile", "nomefile")
                'pdf.SetCampo("1_cognome cond2", "1_cognome cond2")
                'pdf.SetCampo("SUB1_idomicilio", "SUB1_idomicilio")
                'pdf.SetCampo("comuneresidenza", "comuneresidenza")
                'pdf.SetCampo("inf  13", "inf  13")
                'pdf.SetCampo("A_datanascita teste 1", "A_datanascita teste 1")
                'pdf.SetCampo("1_agenzia2", "1_agenzia2")
                'pdf.SetCampo("2_datanascita", "2_datanascita")
                'pdf.SetCampo("1_agenzia", "1_agenzia")
                'pdf.SetCampo("1_cognome cond", "1_cognome cond")
                'pdf.SetCampo("tipo contratto", "tipo contratto")
                'pdf.SetCampo("1_comune nascita propr", "1_comune nascita propr")
                'pdf.SetCampo("1_provresidenza propr2", "1_provresidenza propr2")
                'pdf.SetCampo("qualifica", "qualifica")
                'pdf.SetCampo("PIN", "PIN")
                'pdf.SetCampo("A_comune nascita teste 3", "A_comune nascita teste 3")
                'pdf.SetCampo("2_comuneresidenza", "2_comuneresidenza")
                'pdf.SetCampo("SUB1_descr2", "SUB1_descr2")
                'pdf.SetCampo("A_nome teste 1", "A_nome teste 1")
                'pdf.SetCampo("SUB1_nome", "SUB1_nome")
                'pdf.SetCampo("1_compagnia", "1_compagnia")
                'pdf.SetCampo("C_osserv 1", "C_osserv 1")
                'pdf.SetCampo("1_datanascita propr", "1_datanascita propr")
                'pdf.SetCampo("A_descr fatto", "A_descr fatto")
                'pdf.SetCampo("azienda", "azienda")
                'pdf.SetCampo("1_veic tipo e targa", "1_veic tipo e targa")
                'pdf.SetCampo("A_comuneresidenza teste 2", "A_comuneresidenza teste 2")
                'pdf.SetCampo("A_comuneresidenza teste 3", "A_comuneresidenza teste 3")
                'pdf.SetCampo("A_indirizzoresidenza teste 2", "A_indirizzoresidenza teste 2")
                'pdf.SetCampo("1_indirizzoresidenza propr2", "1_indirizzoresidenza propr2")
                'pdf.SetCampo("A_nome teste 3", "A_nome teste 3")
                'pdf.SetCampo("A_comune incidente", "A_comune incidente")
                'pdf.SetCampo("A_num civico teste 1", "A_num civico teste 1")
                'pdf.SetCampo("dataversione", "dataversione")
                'pdf.SetCampo("SUB1_orario", "SUB1_orario")
                'pdf.SetCampo("2_indirizzoresidenza", "2_indirizzoresidenza")
                'pdf.SetCampo("SUB1_autorità", "SUB1_autorità")
                'pdf.SetCampo("A_data ripr att lav", "A_data ripr att lav")
                'pdf.SetCampo("inf  14", "inf  14")
                'pdf.SetCampo("codfisc", "codfisc")
                'pdf.SetCampo("1_veic tipo", "1_veic tipo")
                'pdf.SetCampo("datanascita", "datanascita")
                'pdf.SetCampo("1_indirizzoresidenza cond", "1_indirizzoresidenza cond")
                'pdf.SetCampo("2_autorità", "2_autorità")
                'pdf.SetCampo("SUB1_strutt san", "SUB1_strutt san")
                'pdf.SetCampo("1_comuneresidenza propr", "1_comuneresidenza propr")
                'pdf.SetCampo("1_comuneresidenza cond", "1_comuneresidenza cond")
                'pdf.SetCampo("1_datanascita cond", "1_datanascita cond")
                'pdf.SetCampo("1_nome propr", "1_nome propr")
                'pdf.SetCampo("1_scad polizza polizza2", "1_scad polizza polizza2")
                'pdf.SetCampo("SUB1_sede inail", "SUB1_sede inail")
                'pdf.SetCampo("A_comune nascita teste 2", "A_comune nascita teste 2")
                'pdf.SetCampo("SUB2_data", "SUB2_data")
                'pdf.SetCampo("1_cognome propr", "1_cognome propr")
                'pdf.SetCampo("SUB2_cure", "SUB2_cure")
                'pdf.SetCampo("1_indirizzoresidenza propr", "1_indirizzoresidenza propr")
                'pdf.SetCampo("descrizione", "descrizione")
                'pdf.SetCampo("inf  1", "inf  1")
                'pdf.SetCampo("A_datanascita teste 2", "A_datanascita teste 2")
                'pdf.SetCampo("A_datanascita teste 3", "A_datanascita teste 3")
                'pdf.SetCampo("SUB2_sintomi2", "SUB2_sintomi2")
                'pdf.SetCampo("1_scad polizza polizza", "1_scad polizza polizza")
                'pdf.SetCampo("A_nome teste 2", "A_nome teste 2")
                'pdf.SetCampo("SUB1_descr3", "SUB1_descr3")
                'pdf.SetCampo("1_nome propr2", "1_nome propr2")
                'pdf.SetCampo("A_comuneresidenza teste 1", "A_comuneresidenza teste 1")
                'pdf.SetCampo("A_provresidenza teste 2", "A_provresidenza teste 2")
                'pdf.SetCampo("A_indirizzoresidenza teste 3", "A_indirizzoresidenza teste 3")
                'pdf.SetCampo("A_provresidenza teste 3", "A_provresidenza teste 3")
                'pdf.SetCampo("1_provresidenza cond", "1_provresidenza cond")
                'pdf.SetCampo("1_num civico cond2", "1_num civico cond2")
                'pdf.SetCampo("SUB1_idomicilio teste", "SUB1_idomicilio teste")
                'pdf.SetCampo("SUB1_nome teste", "SUB1_nome teste")
                'pdf.SetCampo("inf  15", "inf  15")
                'pdf.SetCampo("nome", "nome")
                'pdf.SetCampo("1_veic targa", "1_veic targa")
                'pdf.SetCampo("SUB1_descr5", "SUB1_descr5")
                'pdf.SetCampo("SUB2_sintomi", "SUB2_sintomi")
                'pdf.SetCampo("1_compagnia2", "1_compagnia2")
                'pdf.SetCampo("descrizione_2", "descrizione_2")
                'pdf.SetCampo("SUB1_descr4", "SUB1_descr4")
                'pdf.SetCampo("A_orario", "A_orario")
                'pdf.SetCampo("1_num civico propr", "1_num civico propr")
                'pdf.SetCampo("2_nome", "2_nome")
                'pdf.SetCampo("comune nascita", "comune nascita")
                'pdf.SetCampo("inf  12", "inf  12")
                'pdf.SetCampo("1_provresidenza propr", "1_provresidenza propr")
                'pdf.SetCampo("provresidenza", "provresidenza")
                'pdf.SetCampo("1_nome cond", "1_nome cond")
                'pdf.SetCampo("C_osserv 2", "C_osserv 2")
                'pdf.SetCampo("2_num civico", "2_num civico")
                'pdf.SetCampo("A_comune nascita teste 1", "A_comune nascita teste 1")
                'pdf.SetCampo("2_comune nascita", "2_comune nascita")
                'pdf.SetCampo("1_comuneresidenza propr2", "1_comuneresidenza propr2")
                'pdf.SetCampo("SUB2_lavorazione", "SUB2_lavorazione")
                'pdf.SetCampo("1_datanascita propr2", "1_datanascita propr2")


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