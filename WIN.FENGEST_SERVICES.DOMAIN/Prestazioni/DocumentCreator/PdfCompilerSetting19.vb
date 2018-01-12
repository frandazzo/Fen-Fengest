Imports WIN.TECHNICAL.PDF_PRINTER
Imports System.Runtime.InteropServices
Imports System.IO

Public Class PdfCompilerSetting19
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

                '*******************************************
                pdf.SetCampo("78888", Prestazione.Utente.Cognome)
                pdf.SetCampo("66666666", Prestazione.Utente.Nome)
                pdf.SetCampo("SESS", RetrieveSesso(Prestazione))
                pdf.SetCampo("COMUNE", Prestazione.Utente.ComuneNascita.Descrizione)
                pdf.SetCampo("POIL", Prestazione.Utente.ProvinciaNascita.Sigla)
                pdf.SetCampo("693", Prestazione.Utente.Nazionalita.Descrizione)


                'pdf.SetCampo("codfisc", Prestazione.Utente.CodiceFiscale)
                'pdf.SetCampo("cognome coniuge", "")
                'pdf.SetCampo("datanascita", Prestazione.Utente.DataNascita)
                'pdf.SetCampo("domanda numero", "") 'Prestazione.Id.ToString())
                'pdf.SetCampo("nome_echo", Prestazione.Utente.Nome)
                'pdf.SetCampo("cognome_echo", Prestazione.Utente.Cognome)
                'pdf.SetCampo("codfisc_echo", Prestazione.Utente.CodiceFiscale)
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


                'pdf.SetCampo("INDI", "INDI")
                'pdf.SetCampo("33a", "33a")
                'pdf.SetCampo("BVVBVB", "BVVBVB")
                'pdf.SetCampo("dataM", "dataM")
                'pdf.SetCampo("2", "2")
                'pdf.SetCampo("78888", "78888")
                'pdf.SetCampo("87", "87")
                'pdf.SetCampo("ANNOCOMP", "ANNOCOMP")
                'pdf.SetCampo("MATR", "MATR")
                'pdf.SetCampo("HN", "HN")
                'pdf.SetCampo("77", "77")
                'pdf.SetCampo("89", "89")
                'pdf.SetCampo("HGG", "HGG")
                'pdf.SetCampo("FFFF8546", "FFFF8546")
                'pdf.SetCampo("411222", "411222")
                'pdf.SetCampo("22", "22")
                'pdf.SetCampo("SAADSA", "SAADSA")
                'pdf.SetCampo("DSDS", "DSDS")
                'pdf.SetCampo("33c", "33c")
                'pdf.SetCampo("protocollo", "protocollo")
                'pdf.SetCampo("AZSDF", "AZSDF")
                'pdf.SetCampo("74741", "74741")
                ''pdf.SetCampo("2", "2")
                'pdf.SetCampo("3", "3")
                'pdf.SetCampo("CODF", "CODF")
                'pdf.SetCampo("MJNB", "MJNB")
                'pdf.SetCampo("7", "7")
                'pdf.SetCampo("POIL", "POIL")
                'pdf.SetCampo("899", "899")
                'pdf.SetCampo("VBN", "VBN")
                'pdf.SetCampo("FFFFF", "FFFFF")
                'pdf.SetCampo("1421", "1421")
                'pdf.SetCampo("1414", "1414")
                'pdf.SetCampo("2999", "2999")
                'pdf.SetCampo("120", "120")
                'pdf.SetCampo("FFGH", "FFGH")
                'pdf.SetCampo("PIN", "PIN")
                'pdf.SetCampo("520", "520")
                'pdf.SetCampo("ZSHGHJK", "ZSHGHJK")
                'pdf.SetCampo("411", "411")
                'pdf.SetCampo("AQZSDCGK", "AQZSDCGK")
                'pdf.SetCampo("33b", "33b")
                'pdf.SetCampo("32158", "32158")
                'pdf.SetCampo("587", "587")
                'pdf.SetCampo("693", "693")
                'pdf.SetCampo("8521", "8521")
                'pdf.SetCampo("HH-à", "HH-à")
                'pdf.SetCampo("140681", "140681")
                'pdf.SetCampo("784", "784")
                'pdf.SetCampo("dataversione", "dataversione")
                'pdf.SetCampo("DSWDEW", "DSWDEW")
                'pdf.SetCampo("7999", "7999")
                'pdf.SetCampo("0", "0")
                'pdf.SetCampo("10", "10")
                'pdf.SetCampo("COMUNE", "COMUNE")
                'pdf.SetCampo("AZX", "AZX")
                'pdf.SetCampo("QAFGG", "QAFGG")
                'pdf.SetCampo(".0", ".0")
                'pdf.SetCampo("66666666", "66666666")
                'pdf.SetCampo("1115", "1115")
                'pdf.SetCampo("DENOM", "DENOM")
                'pdf.SetCampo("MK", "MK")
                'pdf.SetCampo("258411", "258411")
                'pdf.SetCampo("23", "23")
                'pdf.SetCampo("07L", "07L")
                'pdf.SetCampo("nomefile", "nomefile")
                'pdf.SetCampo("descrizione", "descrizione")
                'pdf.SetCampo("1", "1")
                'pdf.SetCampo("743", "743")
                'pdf.SetCampo("Y", "Y")
                'pdf.SetCampo("SESS", "SESS")
                'pdf.SetCampo("56", "56")
                'pdf.SetCampo("89623", "89623")
                'pdf.SetCampo("98", "98")
                'pdf.SetCampo("M", "M")
                'pdf.SetCampo("K", "K")
                'pdf.SetCampo("QREDFG", "QREDFG")
                'pdf.SetCampo("5243", "5243")
                'pdf.SetCampo("G", "G")
                'pdf.SetCampo("OPLK", "OPLK")
                'pdf.SetCampo("356", "356")
                'pdf.SetCampo("PLXS", "PLXS")

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