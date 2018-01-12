Imports WIN.TECHNICAL.PDF_PRINTER
Imports System.Runtime.InteropServices

Public Class PdfCompilerCURE_TERMALI
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


                '*********************************************
                pdf.SetCampo("sede inps", Prestazione.Utente.Segreteria.Comune)
                pdf.SetCampo("cognome", Prestazione.Utente.Cognome)
                pdf.SetCampo("nome", Prestazione.Utente.Nome)
                'pdf.SetCampo("M/F", RetrieveSesso(Prestazione))
                pdf.SetCampo("sesso M", RetrieveSessoM(Prestazione))
                pdf.SetCampo("sesso F", RetrieveSessoF(Prestazione))
                pdf.SetCampo("data nascita", Prestazione.Utente.DataNascita)
                'pdf.SetCampo("cogn coniuge", "cogn coniuge")
                pdf.SetCampo("comune nasc", Prestazione.Utente.ComuneNascita.Descrizione)
                pdf.SetCampo("prov", Prestazione.Utente.ProvinciaNascita.Sigla)
                pdf.SetCampo("codfisc", Prestazione.Utente.CodiceFiscale)
                pdf.SetCampo("telefono", Prestazione.Utente.Comunicazione.TelefonoCasa)
                pdf.SetCampo("comune resid", Prestazione.Utente.Residenza.Comune.Descrizione)
                pdf.SetCampo("prov resid", Prestazione.Utente.Residenza.Provincia.Sigla)
                pdf.SetCampo("capresidenza", Prestazione.Utente.Residenza.Comune.CAP)
                pdf.SetCampo("indirizzo", Prestazione.Utente.Residenza.Via)

                'Campi inesistenti o non presenti sul modulo
                'pdf.SetCampo("M/F", RetrieveSesso(Prestazione))
                'pdf.SetCampo("domanda numero", "") 'Prestazione.Id.ToString())
                'pdf.SetCampo("nome_echo", Prestazione.Utente.Nome)
                'pdf.SetCampo("cognome_echo", Prestazione.Utente.Cognome)
                'pdf.SetCampo("codfisc_echo", Prestazione.Utente.CodiceFiscale)
                'pdf.SetCampo("cittadinanza", Prestazione.Utente.Nazionalita.Descrizione)
                'pdf.SetCampo("provresidenza", Prestazione.Utente.Residenza.Provincia.Sigla)
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


                'pdf.SetCampo("data nascita", "data nascita")
                'pdf.SetCampo("prov_echo", "prov_echo")
                'pdf.SetCampo("cognome_echo", "cognome_echo")
                'pdf.SetCampo("indirizzo", "indirizzo")
                'pdf.SetCampo("PIN", "PIN")
                'pdf.SetCampo("sede inps", "sede inps")
                'pdf.SetCampo("comune nasc_echo", "comune nasc_echo")
                'pdf.SetCampo("qualifica", "qualifica")
                'pdf.SetCampo("prov", "prov")
                'pdf.SetCampo("diagnosi_.0", "diagnosi_.0")
                'pdf.SetCampo("apparato interessato.0", "apparato interessato.0")
                'pdf.SetCampo("terapia_.0", "terapia_.0")
                'pdf.SetCampo("apparato interessato.2", "apparato interessato.2")
                'pdf.SetCampo("data nascita_echo", "data nascita_echo")
                'pdf.SetCampo("apparato interessato.4", "apparato interessato.4")
                'pdf.SetCampo("peso", "peso")
                'pdf.SetCampo("apparato interessato.6", "apparato interessato.6")
                'pdf.SetCampo("data 1", "data 1")
                'pdf.SetCampo("cod patron", "cod patron")
                'pdf.SetCampo("diagnosi_.1", "diagnosi_.1")
                'pdf.SetCampo("dataversione", "dataversione")
                'pdf.SetCampo("altri org_.2", "altri org_.2")
                'pdf.SetCampo("altezza", "altezza")
                'pdf.SetCampo("cognome", "cognome")
                'pdf.SetCampo("diagnosi_.2", "diagnosi_.2")
                'pdf.SetCampo("patologia", "patologia")
                'pdf.SetCampo("cogn coniuge", "cogn coniuge")
                'pdf.SetCampo("anno dom", "anno dom")
                'pdf.SetCampo("patologia_.1", "patologia_.1")
                'pdf.SetCampo("nome patronato", "nome patronato")
                'pdf.SetCampo("descr altro", "descr altro")
                'pdf.SetCampo("patologia_.2", "patologia_.2")
                'pdf.SetCampo("patologia_.4", "patologia_.4")
                'pdf.SetCampo("nome_echo", "nome_echo")
                'pdf.SetCampo("altri org_.1", "	altri org_.1")
                'pdf.SetCampo("ricev anno dom", "ricev anno dom")
                'pdf.SetCampo("altri org_.0", "altri org_.0")
                'pdf.SetCampo("num pratica", "num pratica")
                'pdf.SetCampo("codfisc", "codfisc")
                'pdf.SetCampo("descrizione", "descrizione")
                'pdf.SetCampo("app cardio_.2", "app cardio_.2")
                'pdf.SetCampo("stato generale", "stato generale")
                'pdf.SetCampo("app cardio_.0", "app cardio_.0")
                'pdf.SetCampo("apparato interessato.1", "apparato interessato.1")
                'pdf.SetCampo("comune resid", "comune resid")
                'pdf.SetCampo("apparato interessato.3", "apparato interessato.3")
                'pdf.SetCampo("terapia_.1", "terapia_.1")
                'pdf.SetCampo("app cardio_.1", "app cardio_.1")
                'pdf.SetCampo("apparato interessato.5", "apparato interessato.5")
                'pdf.SetCampo("data 2", "data 2")
                'pdf.SetCampo("telefono", "telefono")
                'pdf.SetCampo("patologia_.0", "patologia_.0")
                'pdf.SetCampo("comune nasc", "comune nasc")
                'pdf.SetCampo("prov resid", "prov resid")
                'pdf.SetCampo("nome", "nome")
                'pdf.SetCampo("giorni assenza", "giorni assenza")
                'pdf.SetCampo("protocollo", "protocollo")
                'pdf.SetCampo("nomefile", "nomefile")
                'pdf.SetCampo("capresidenza", "capresidenza")
                'pdf.SetCampo("sigla ASL", "sigla ASL")
                'pdf.SetCampo("patologia_.3", "patologia_.3")
                'pdf.SetCampo("accert_.0", "accert_.0")
                'pdf.SetCampo("accert_.1", "accert_.1")
                'pdf.SetCampo("accert_.2", "accert_.2")

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

    Private Function RetrieveSessoM(ByVal Prest As Prestazione) As String


        If Prest.Utente.Sesso = AbstractPersona.Sex.Maschio Then
            Return "Sì"
        End If

        Return ""


        'If Prest.Utente.Sesso.ToString().Equals("Maschio") = True Then
        'End If
    End Function

    Private Function RetrieveSessoF(ByVal Prest As Prestazione) As String


        If Prest.Utente.Sesso = AbstractPersona.Sex.Maschio Then
            Return ""
        End If

        Return "Sì"


        'If Prest.Utente.Sesso.ToString().Equals("Maschio") = True Then
        'End If
    End Function


End Class