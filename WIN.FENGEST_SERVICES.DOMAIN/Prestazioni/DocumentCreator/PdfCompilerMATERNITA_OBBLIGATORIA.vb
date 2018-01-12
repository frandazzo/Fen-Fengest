Imports WIN.TECHNICAL.PDF_PRINTER
Imports System.Runtime.InteropServices

Public Class PdfCompilerMATERNITA_OBBLIGATORIA
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
                'pdf.SetCampo("NOME", Prestazione.Utente.Nome)
                'pdf.SetCampo("COGNOME", Prestazione.Utente.Cognome)
                'pdf.SetCampo("COD.FISC", Prestazione.Utente.CodiceFiscale)
                'pdf.SetCampo("cognome coniuge", "")
                'pdf.SetCampo("DATA", Prestazione.Utente.DataNascita)
                'pdf.SetCampo("SESSO", RetrieveSesso(Prestazione))
                'pdf.SetCampo("DOMANDA NUMERO", "") 'Prestazione.Id.ToString())
                'pdf.SetCampo("nome_echo", Prestazione.Utente.Nome)
                'pdf.SetCampo("cognome_echo", Prestazione.Utente.Cognome)
                'pdf.SetCampo("codfisc_echo", Prestazione.Utente.CodiceFiscale)

                'pdf.SetCampo("COMUNE NASCITA", Prestazione.Utente.ComuneNascita.Descrizione)

                'pdf.SetCampo("PROV2", Prestazione.Utente.ProvinciaNascita.Sigla)
                'pdf.SetCampo("CITTADIN", Prestazione.Utente.Nazionalita.Descrizione)
                'pdf.SetCampo("RESIDENZA", Prestazione.Utente.Residenza.Comune.Descrizione)
                'pdf.SetCampo("INDIRIZZO", Prestazione.Utente.Residenza.Via)
                'pdf.SetCampo("PROV1", Prestazione.Utente.Residenza.Provincia.Sigla)
                'pdf.SetCampo("CAPRESIDENZA", Prestazione.Utente.Residenza.Comune.CAP)
                'pdf.SetCampo("TELEFONO", Prestazione.Utente.Comunicazione.Cellulare1)
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

                '************************************************+
                pdf.SetCampo("SEDE", "SEDE")
                pdf.SetCampo("COGNOME", Prestazione.Utente.Cognome)
                pdf.SetCampo("NOME", Prestazione.Utente.Nome)
                pdf.SetCampo("DATA", Prestazione.Utente.DataNascita)
                pdf.SetCampo("SESSO", RetrieveSesso(Prestazione))
                pdf.SetCampo("COMUNE", Prestazione.Utente.ComuneNascita.Descrizione)
                pdf.SetCampo("PROV", Prestazione.Utente.ProvinciaNascita.Descrizione)
                pdf.SetCampo("COD.FISC", Prestazione.Utente.CodiceFiscale)
                pdf.SetCampo("CITTADIN", Prestazione.Utente.Nazionalita.Descrizione)
                pdf.SetCampo("RESIDENZA", Prestazione.Utente.Residenza.Comune.Descrizione)
                pdf.SetCampo("PROV1", Prestazione.Utente.Residenza.Provincia.Sigla)
                pdf.SetCampo("INDIRIZZO", Prestazione.Utente.Residenza.Via)
                pdf.SetCampo("TELEFONO", Prestazione.Utente.Comunicazione.Cellulare1)



                'pdf.SetCampo("cognome coniuge", "")
                'pdf.SetCampo("DOMANDA NUMERO", "") 'Prestazione.Id.ToString())
                'pdf.SetCampo("nome_echo", Prestazione.Utente.Nome)
                'pdf.SetCampo("cognome_echo", Prestazione.Utente.Cognome)
                'pdf.SetCampo("codfisc_echo", Prestazione.Utente.CodiceFiscale)
                'pdf.SetCampo("PROV2", Prestazione.Utente.ProvinciaNascita.Sigla)
                'pdf.SetCampo("CAPRESIDENZA", Prestazione.Utente.Residenza.Comune.CAP)
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



                'pdf.SetCampo("PIN", "PIN")
                'pdf.SetCampo("CDF-4", "CDF-4")
                'pdf.SetCampo("SETTORE4", "SETTORE4")
                'pdf.SetCampo("SESSO1", "SESSO1")
                'pdf.SetCampo("CDF-3", "CDF-3")
                'pdf.SetCampo("benef al", "benef al")
                'pdf.SetCampo("PROV2", "PROV2")
                'pdf.SetCampo("CITTADIN", "CITTADIN")
                'pdf.SetCampo("cog-coni", "cog-coni")
                'pdf.SetCampo("PROV1", "PROV1")
                'pdf.SetCampo("NOME-MADRE", "NOME-MADRE")
                'pdf.SetCampo("INDIRIZZO", "INDIRIZZO")
                'pdf.SetCampo("al7", "al7")
                'pdf.SetCampo("benef dal", "benef dal")
                'pdf.SetCampo("COMUNE-DI", "COMUNE-DI")
                'pdf.SetCampo("qualifica7", "qualifica7")
                'pdf.SetCampo("lato", "lato")
                'pdf.SetCampo("COMUNE-3", "COMUNE-3")
                'pdf.SetCampo("LUOGO-DECESSO", "LUOGO-DECESSO")
                'pdf.SetCampo("SESSO-RAPP", "SESSO-RAPP")
                'pdf.SetCampo("SETTORE7", "SETTORE7")
                'pdf.SetCampo("NOME-BAMBI", "NOME-BAMBI")
                'pdf.SetCampo("protocollo", "protocollo")
                'pdf.SetCampo("comune-legge", "comune-legge")
                'pdf.SetCampo("DATA-34", "DATA-34")
                'pdf.SetCampo("INDIR.BAMB", "INDIR.BAMB")
                'pdf.SetCampo("DATA-CONIU", "DATA-CONIU")
                'pdf.SetCampo("CDF-DI", "CDF-DI")
                'pdf.SetCampo("dal6", "dal6")
                'pdf.SetCampo("PROV-RAPP", "PROV-RAPP")
                'pdf.SetCampo("SEDE", "SEDE")
                'pdf.SetCampo("dal2", "dal2             	")
                'pdf.SetCampo("COGNOME-5", "COGNOME-5")
                'pdf.SetCampo("altro", "altro")
                'pdf.SetCampo("DATA-NASC-4", "DATA-NASC-4")
                'pdf.SetCampo("PROV", "PROV")
                'pdf.SetCampo("qualifica2", "qualifica2")
                'pdf.SetCampo("DATA-MADRE", "DATA-MADRE")
                'pdf.SetCampo("qualifica3", "qualifica3")
                'pdf.SetCampo("DATORE5", "DATORE5")
                'pdf.SetCampo("SETTORE3", "SETTORE3")
                'pdf.SetCampo("4", "4")
                'pdf.SetCampo("1", "1")
                'pdf.SetCampo("2", "2")
                'pdf.SetCampo("3", "3")
                'pdf.SetCampo("DATA-DI", "DATA-DI")
                'pdf.SetCampo("CD.F.BAM", "CD.F.BAM")
                'pdf.SetCampo("DATORE6", "DATORE6")
                'pdf.SetCampo("DEL", "DEL")
                'pdf.SetCampo("al4", "al4")
                'pdf.SetCampo("CDF-RAPP", "CDF-RAPP")
                'pdf.SetCampo("al5", "al5")
                'pdf.SetCampo("cognome-madre", "cognome-madre")
                'pdf.SetCampo("CAB", "CAB")
                'pdf.SetCampo("DATA-RAPP", "DATA-RAPP")
                'pdf.SetCampo("al2", "al2")
                'pdf.SetCampo("dal5", "dal5")
                'pdf.SetCampo("RES.BAMB", "RES.BAMB")
                'pdf.SetCampo("dal3", "dal3")
                'pdf.SetCampo("dal7", "dal7")
                'pdf.SetCampo("DATORE1", "DATORE1")
                'pdf.SetCampo("SETTORE1", "SETTORE1")
                'pdf.SetCampo("PATRONATO", "PATRONATO")
                'pdf.SetCampo("qualifica4", "qualifica4")
                'pdf.SetCampo("DATORE2", "DATORE2")
                'pdf.SetCampo("CIN", "CIN")
                'pdf.SetCampo("SETTORE6", "SETTORE6")
                'pdf.SetCampo("SETTORE2", "SETTORE2")
                'pdf.SetCampo("DATA-43", "DATA-43")
                'pdf.SetCampo("cognome-3", "cognome-3")
                'pdf.SetCampo("DATORE7", "DATORE7")
                'pdf.SetCampo("LUOGO-CONIU", "LUOGO-CONIU")
                'pdf.SetCampo("COGNOME-BAMBI", "COGNOME-BAMBI")
                'pdf.SetCampo("CD-BANCA", "CD-BANCA")
                'pdf.SetCampo("dataversione", "dataversione")
                'pdf.SetCampo("NOME-5", "NOME-5")
                'pdf.SetCampo("qualifica1", "qualifica1")
                'pdf.SetCampo("DATA-NAS-3", "DATA-NAS-3")
                'pdf.SetCampo("DATA-DECESSO", "DATA-DECESSO")
                'pdf.SetCampo("COMUNE", "COMUNE")
                'pdf.SetCampo("DATA", "DATA")
                'pdf.SetCampo("TELEFONO", "TELEFONO")
                'pdf.SetCampo("COMUNE-4", "COMUNE-4")
                'pdf.SetCampo("NOME-RAPPO", "NOME-RAPPO")
                'pdf.SetCampo("DATA1", "DATA1")
                'pdf.SetCampo("NOME-3", "NOME-3")
                'pdf.SetCampo("CITTA-BAMB", "CITTA-BAMB")
                'pdf.SetCampo("dal4", "dal4")
                'pdf.SetCampo("COGNOME", "COGNOME")
                'pdf.SetCampo("COD.FISC-MADRE", "COD.FISC-MADRE")
                'pdf.SetCampo("DATORE3", "DATORE3")
                'pdf.SetCampo("DA", "DA")
                'pdf.SetCampo("SETTORE5", "SETTORE5")
                'pdf.SetCampo("RESIDENZA", "RESIDENZA")
                'pdf.SetCampo("SESSO", "SESSO")
                'pdf.SetCampo("nome-coniu", "nome-coniu")
                'pdf.SetCampo("SENTENZA", "SENTENZA")
                'pdf.SetCampo("DATORE4", "DATORE4")
                'pdf.SetCampo("nomefile", "nomefile")
                'pdf.SetCampo("descrizione", "descrizione")
                'pdf.SetCampo("CDF-CONIU", "CDF-CONIU")
                'pdf.SetCampo("COMUNE-MADRE", "COMUNE-MADRE")
                'pdf.SetCampo("NOME-4", "NOME-4")
                'pdf.SetCampo("al6", "al6")
                'pdf.SetCampo("NOME", "NOME")
                'pdf.SetCampo("cognome-4", "cognome-4")
                'pdf.SetCampo("qualifica5", "qualifica5")
                'pdf.SetCampo("COMUNE-BAM", "COMUNE-BAM")
                'pdf.SetCampo("al3", "al3")
                'pdf.SetCampo("qualifica6", "qualifica6")
                'pdf.SetCampo("COD-CLIE", "COD-CLIE")
                'pdf.SetCampo("COD.FISC", "COD.FISC")
                'pdf.SetCampo("DATA2", "DATA2")
                'pdf.SetCampo("dal1", "dal1")
                'pdf.SetCampo("COGNOME-RAPPO", "COGNOME-RAPPO")
                'pdf.SetCampo("D", "D")
                'pdf.SetCampo("STATO", "STATO")
                'pdf.SetCampo("al1", "al1")

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