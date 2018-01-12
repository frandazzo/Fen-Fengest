Imports WIN.TECHNICAL.PDF_PRINTER
Imports System.Runtime.InteropServices

Public Class PdfCompilerCONGEDO_PARENTALE
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



                '******************************************************
                pdf.SetCampo("sede inps", Prestazione.Utente.Segreteria.Comune)
                pdf.SetCampo("cognome", Prestazione.Utente.Cognome)
                pdf.SetCampo("nome", Prestazione.Utente.Nome)
                pdf.SetCampo("datanascita", Prestazione.Utente.DataNascita)
                pdf.SetCampo("M/F", RetrieveSesso(Prestazione))
                pdf.SetCampo("comune nascita", Prestazione.Utente.ComuneNascita.Descrizione)
                pdf.SetCampo("provnascita", Prestazione.Utente.ProvinciaNascita.Sigla)
                pdf.SetCampo("codfisc", Prestazione.Utente.CodiceFiscale)
                pdf.SetCampo("indirizzoresidenza", Prestazione.Utente.Residenza.Via)
                'pdf.SetCampo("num civico", "num civico")
                pdf.SetCampo("comuneresidenza", Prestazione.Utente.Residenza.Comune.Descrizione)
                pdf.SetCampo("provresidenza", Prestazione.Utente.Residenza.Provincia.Sigla)
                pdf.SetCampo("capresidenza", Prestazione.Utente.Residenza.Comune.CAP)
                pdf.SetCampo("telefono", Prestazione.Utente.Comunicazione.Cellulare1)
                pdf.SetCampo("nato/a", RetrieveSessoNatOA(Prestazione))

                ''Campi da controllare o inesistenti sul modulo
                'pdf.SetCampo("cognome coniuge", "")
                'pdf.SetCampo("domanda numero", "") 'Prestazione.Id.ToString())
                'pdf.SetCampo("nome_echo", Prestazione.Utente.Nome)
                'pdf.SetCampo("cognome_echo", Prestazione.Utente.Cognome)
                'pdf.SetCampo("codfisc_echo", Prestazione.Utente.CodiceFiscale)
                'pdf.SetCampo("cittadinanza", Prestazione.Utente.Nazionalita.Descrizione)
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



                'pdf.SetCampo("nato/a", "nato/a")
                'pdf.SetCampo("B_cognome", "B_cognome")
                'pdf.SetCampo("gg lav agr", "gg lav agr")
                'pdf.SetCampo("D_data al 4", "D_data al 4")
                'pdf.SetCampo("inf  3", "inf  3")
                'pdf.SetCampo("indirizzoazienda", "indirizzoazienda")
                'pdf.SetCampo("codfisc", "codfisc")
                'pdf.SetCampo("G_capresidenza", "G_capresidenza")
                'pdf.SetCampo("D_data dal 3", "D_data dal 3")
                'pdf.SetCampo("num civ azienda", "num civ azienda")
                'pdf.SetCampo("D_data al 3", "D_data al 3")
                'pdf.SetCampo("comune lav agr", "comune lav agr")
                'pdf.SetCampo("datanascita", "datanascita")
                'pdf.SetCampo("G_cognome", "G_cognome")
                'pdf.SetCampo("indirizzoazienda 4", "indirizzoazienda 4")
                'pdf.SetCampo("B_comune nascita", "B_comune nascita")
                'pdf.SetCampo("G_nato/a", "G_nato/a")
                'pdf.SetCampo("A_data al 2", "A_data al 2")
                'pdf.SetCampo("azienda 6", "azienda 6")
                'pdf.SetCampo("azienda 5", "azienda 5")
                'pdf.SetCampo("azienda 4", "azienda 4")
                'pdf.SetCampo("azienda 3", "azienda 3")
                'pdf.SetCampo("azienda 2", "azienda 2")
                'pdf.SetCampo("indirizzoresidenza", "indirizzoresidenza")
                'pdf.SetCampo("indirizzoazienda 3", "indirizzoazienda 3")
                'pdf.SetCampo("A_data dal 1", "A_data dal 1")
                'pdf.SetCampo("data adoz", "data adoz")
                'pdf.SetCampo("G_indirizzoresidenza", "G_indirizzoresidenza")
                'pdf.SetCampo("A_gg 4", "A_gg 4")
                'pdf.SetCampo("sede inps", "sede inps")
                'pdf.SetCampo("data affid", "data affid")
                'pdf.SetCampo("D_gg 1", "D_gg 1")
                'pdf.SetCampo("B_provnascita", "B_provnascita")
                'pdf.SetCampo("D_data dal 1", "D_data dal 1")
                'pdf.SetCampo("M/F", "M/F")
                'pdf.SetCampo("protocollo", "protocollo")
                'pdf.SetCampo("cognome", "cognome")
                'pdf.SetCampo("telefono", "telefono")
                'pdf.SetCampo("G_telefono", "G_telefono")
                'pdf.SetCampo("punto 3", "punto 3")
                'pdf.SetCampo("num civico", "num civico")
                'pdf.SetCampo("comune azienda 6", "comune azienda 6")
                'pdf.SetCampo("cognome_echo", "cognome_echo")
                'pdf.SetCampo("D_data dal 4", "D_data dal 4")
                'pdf.SetCampo("num civ azienda 4", "num civ azienda 4")
                'pdf.SetCampo("num civ azienda 5", "num civ azienda 5")
                'pdf.SetCampo("num civ azienda 6", "num civ azienda 6")
                'pdf.SetCampo("comune azienda 4", "comune azienda 4")
                'pdf.SetCampo("B_codfisc", "B_codfisc")
                'pdf.SetCampo("data az 2", "data az 2")
                'pdf.SetCampo("num civ azienda 2", "num civ azienda 2")
                'pdf.SetCampo("num civ azienda 3", "num civ azienda 3")
                'pdf.SetCampo("indirizzoazienda 2", "indirizzoazienda 2")
                'pdf.SetCampo("comune azienda 3", "comune azienda 3")
                'pdf.SetCampo("G_provnascita", "G_provnascita")
                'pdf.SetCampo("comuneresidenza", "comuneresidenza")
                'pdf.SetCampo("G_codfisc", "G_codfisc")
                'pdf.SetCampo("provresidenza", "provresidenza")
                'pdf.SetCampo("B_nome", "B_nome")
                'pdf.SetCampo("A_data dal 2", "A_data dal 2")
                'pdf.SetCampo("inf  2", "inf  2")
                'pdf.SetCampo("comune azienda", "comune azienda")
                'pdf.SetCampo("PIN", "PIN")
                'pdf.SetCampo("D_gg 2", "D_gg 2")
                'pdf.SetCampo("nomefile", "nomefile")
                'pdf.SetCampo("nome patr", "nome patr")
                'pdf.SetCampo("Z nascosto", "Z nascosto")
                'pdf.SetCampo("num prat", "num prat")
                'pdf.SetCampo("data dich", "data dich")
                'pdf.SetCampo("indirizzoazienda 6", "indirizzoazienda 6")
                'pdf.SetCampo("punto 4", "punto 4")
                'pdf.SetCampo("azienda", "azienda")
                'pdf.SetCampo("D_data al 2", "D_data al 2")
                'pdf.SetCampo("A_gg 1", "A_gg 1")
                'pdf.SetCampo("punto 1", "punto 1")
                'pdf.SetCampo("G_provresid", "G_provresid")
                'pdf.SetCampo("matr inps azienda 4", "matr inps azienda 4")
                'pdf.SetCampo("data az 4 al_2", "data az 4 al_2")
                'pdf.SetCampo("D_data al 1", "D_data al 1")
                'pdf.SetCampo("dataversione", "dataversione")
                'pdf.SetCampo("A_data al 4", "A_data al 4")
                'pdf.SetCampo("G_M/F", "G_M/F")
                'pdf.SetCampo("comune azienda 2", "comune azienda 2")
                'pdf.SetCampo("anno lav agr", "anno lav agr")
                'pdf.SetCampo("G_comuneresidenza", "G_comuneresidenza")
                'pdf.SetCampo("A_data al 3", "A_data al 3")
                'pdf.SetCampo("provnascita", "provnascita")
                'pdf.SetCampo("A_data al 1", "A_data al 1")
                'pdf.SetCampo("ric IL", "ric IL")
                'pdf.SetCampo("data az 4", "data az 4")
                'pdf.SetCampo("B_nato/a", "B_nato/a")
                'pdf.SetCampo("A_data dal 3", "A_data dal 3")
                'pdf.SetCampo("matr inps azienda 2", "matr inps azienda 2")
                'pdf.SetCampo("D_gg 3", "D_gg 3")
                'pdf.SetCampo("ric LA", "ric LA")
                'pdf.SetCampo("nome", "nome")
                'pdf.SetCampo("info 1", "info 1")
                'pdf.SetCampo("B_datanascita", "B_datanascita")
                'pdf.SetCampo("descrizione", "descrizione")
                'pdf.SetCampo("inf  1", "inf  1")
                'pdf.SetCampo("info 1a", "info 1a")
                'pdf.SetCampo("A_gg 2", "A_gg 2")
                'pdf.SetCampo("data az 4 dal_2", "data az 4 dal_2")
                'pdf.SetCampo("G_nome", "G_nome")
                'pdf.SetCampo("A_data dal 4", "A_data dal 4")
                'pdf.SetCampo("data az 4 al_1", "data az 4 al_1")
                'pdf.SetCampo("data az 3", "data az 3")
                'pdf.SetCampo("punto 2", "punto 2")
                'pdf.SetCampo("D_data dal 2", "D_data dal 2")
                'pdf.SetCampo("matr inps azienda 5", "matr inps azienda 5")
                'pdf.SetCampo("G_datanascita", "G_datanascita")
                'pdf.SetCampo("scad contr", "scad contr")
                'pdf.SetCampo("Z", "Z")
                'pdf.SetCampo("comune azienda 5", "comune azienda 5")
                'pdf.SetCampo("matr inps azienda 6", "matr inps azienda 6")
                'pdf.SetCampo("data patr", "data patr")
                'pdf.SetCampo("D_gg 4", "D_gg 4")
                'pdf.SetCampo("B_M/F", "B_M/F")
                'pdf.SetCampo("indirizzoazienda 5", "indirizzoazienda 5")
                'pdf.SetCampo("nome_echo", "nome_echo")
                'pdf.SetCampo("matr inps azienda 3", "matr inps azienda 3")
                'pdf.SetCampo("G_comune nascita", "G_comune nascita")
                'pdf.SetCampo("G_num civico", "G_num civico")
                'pdf.SetCampo("comune nascita", "comune nascita")
                'pdf.SetCampo("A", "A")
                'pdf.SetCampo("B", "B")
                'pdf.SetCampo("capresidenza", "capresidenza")
                'pdf.SetCampo("D", "D")
                'pdf.SetCampo("C", "C")
                'pdf.SetCampo("A_gg 3", "A_gg 3")
                'pdf.SetCampo("data az 4 dal_1", "data az 4 dal_1")
                'pdf.SetCampo("inf  4", "inf  4")


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

    Private Function RetrieveSessoNatOA(ByVal Prest As Prestazione) As String


        If Prest.Utente.Sesso = AbstractPersona.Sex.Maschio Then
            Return "o"
        End If

        Return "a"


        'If Prest.Utente.Sesso.ToString().Equals("Maschio") = True Then
        'End If
    End Function

End Class