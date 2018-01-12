Imports WIN.TECHNICAL.PDF_PRINTER
Imports System.Runtime.InteropServices

Public Class PdfCompilerDISOCCUPAZIONE_REQUISITI_RIDOTTI
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



                '******************************************************+
                'pdf.SetCampo("domanda numero", "domanda numero") 'Prestazione.Id.ToString())
                pdf.SetCampo("sede inps", Prestazione.Utente.Segreteria.Comune)
                pdf.SetCampo("cognome", Prestazione.Utente.Cognome)
                pdf.SetCampo("nome", Prestazione.Utente.Nome)
                pdf.SetCampo("datanascita", Prestazione.Utente.DataNascita)
                pdf.SetCampo("cognome coniuge", "cognome coniuge")
                pdf.SetCampo("codfisc", Prestazione.Utente.CodiceFiscale)
                pdf.SetCampo("M/F", RetrieveSesso(Prestazione))
                pdf.SetCampo("comune nascita", Prestazione.Utente.ComuneNascita.Descrizione)
                pdf.SetCampo("provnascita", Prestazione.Utente.ProvinciaNascita.Sigla)
                pdf.SetCampo("cittadinanza", Prestazione.Utente.Nazionalita.Descrizione)
                pdf.SetCampo("comuneresidenza", Prestazione.Utente.Residenza.Comune.Descrizione)
                pdf.SetCampo("indirizzoresidenza", Prestazione.Utente.Residenza.Via)
                pdf.SetCampo("capresidenza", Prestazione.Utente.Residenza.Comune.CAP)
                pdf.SetCampo("provresidenza", Prestazione.Utente.Residenza.Provincia.Sigla)
                pdf.SetCampo("telefono", Prestazione.Utente.Comunicazione.TelefonoCasa)
                pdf.SetCampo("email", Prestazione.Utente.Comunicazione.Mail)
                pdf.SetCampo("M_sindacato", "FENEAL-UIL 03-03")

                'Reinsderisco i dati del richiedente
                pdf.SetCampo("N_progr 1", "x")
                pdf.SetCampo("N_cogn/nome 1", Prestazione.Utente.Cognome + " " + Prestazione.Utente.Nome)
                pdf.SetCampo("N_codfisc 1", Prestazione.Utente.CodiceFiscale)
                pdf.SetCampo("N_parent 1", "R")
                pdf.SetCampo("N_com/nasc 1", Prestazione.Utente.ComuneNascita.Descrizione)
                pdf.SetCampo("M_data/nasc 1", Prestazione.Utente.DataNascita)
                Try

                    'controllo che esista in coniuge
                    If Not String.IsNullOrEmpty(Prestazione.Utente.SituazioneFamiliare.Coniuge.Cognome) Then
                        'inserisco i dati del coniuge
                        pdf.SetCampo("N_progr 2", "x")
                        pdf.SetCampo("N_cogn/nome 2", Prestazione.Utente.SituazioneFamiliare.Coniuge.Cognome + " " + Prestazione.Utente.SituazioneFamiliare.Coniuge.Nome)
                        pdf.SetCampo("N_codfisc 2", Prestazione.Utente.SituazioneFamiliare.Coniuge.CodiceFiscale)
                        pdf.SetCampo("N_parent 2", "C")
                        Try

                            Dim dati As DatiFiscali = GeoLocationFacade.Instance.CalcolaDatiFiscali(Prestazione.Utente.SituazioneFamiliare.Coniuge.CodiceFiscale)
                            pdf.SetCampo("N_com/nasc 2", dati.Comune.Descrizione)
                            pdf.SetCampo("M_data/nasc 2", dati.DataNascita)
                        Catch ex As InvalidFiscalCodeException
                            'lasci i campi vuoti
                        Catch ex1 As Exception

                        End Try


                        'inserisco al max 5 figli
                        Dim count As Int32
                        Dim i As Int32 = 0
                        Dim n_progr As String
                        Dim cognome_nome As String
                        Dim cod_fisc As String
                        Dim n_parent As String
                        Dim luogo_nasc As String
                        Dim data_nasc As String
                        count = Prestazione.Utente.SituazioneFamiliare.Figli.Count()
                        If (count = 0) Then
                            count = -1
                        End If
                        While (i < count And i < 5)

                            n_progr = "N_progr " + (i + 3).ToString
                            cognome_nome = "N_cogn/nome " + (i + 3).ToString
                            cod_fisc = "N_codfisc " + (i + 3).ToString
                            data_nasc = "M_data/nasc " + (i + 3).ToString
                            luogo_nasc = "N_com/nasc " + (i + 3).ToString
                            n_parent = "N_parent " + (i + 3).ToString


                            Dim figlio As Figlio = DirectCast(Prestazione.Utente.SituazioneFamiliare.Figli.Item(i), Figlio)
                            pdf.SetCampo(n_progr, "x")
                            pdf.SetCampo(cognome_nome, figlio.Cognome + " " + figlio.Nome)
                            pdf.SetCampo(cod_fisc, figlio.CodiceFiscale)
                            pdf.SetCampo(n_parent, "FG")
                            Try

                                Dim dati As DatiFiscali = GeoLocationFacade.Instance.CalcolaDatiFiscali(figlio.CodiceFiscale)
                                pdf.SetCampo(data_nasc, dati.DataNascita)
                                pdf.SetCampo(luogo_nasc, dati.Comune.Descrizione)
                            Catch ex As InvalidFiscalCodeException
                                'lasci i campi vuoti
                            Catch ex1 As Exception

                            End Try

                            i = i + 1
                        End While
                    Else
                        'inserisco al max 6 figli
                        Dim count As Int32
                        Dim i As Int32 = 0
                        Dim n_progr As String
                        Dim cognome_nome As String
                        Dim cod_fisc As String
                        Dim n_parent As String
                        Dim luogo_nasc As String
                        Dim data_nasc As String
                        count = Prestazione.Utente.SituazioneFamiliare.Figli.Count()
                        If (count = 0) Then
                            count = -1
                        End If
                        While (i < count And i < 6)

                            n_progr = "N_progr " + (i + 2).ToString
                            cognome_nome = "N_cogn/nome " + (i + 2).ToString
                            cod_fisc = "N_codfisc " + (i + 2).ToString
                            data_nasc = "M_data/nasc " + (i + 2).ToString
                            luogo_nasc = "N_com/nasc " + (i + 2).ToString
                            n_parent = "N_parent " + (i + 2).ToString

                            Dim figlio As Figlio = DirectCast(Prestazione.Utente.SituazioneFamiliare.Figli.Item(i), Figlio)
                            pdf.SetCampo(n_progr, "x")
                            pdf.SetCampo(cognome_nome, figlio.Cognome + " " + figlio.Nome)
                            pdf.SetCampo(cod_fisc, figlio.CodiceFiscale)
                            pdf.SetCampo(n_parent, "FG")
                            Try

                                Dim dati As DatiFiscali = GeoLocationFacade.Instance.CalcolaDatiFiscali(figlio.CodiceFiscale)
                                pdf.SetCampo(data_nasc, dati.DataNascita)
                                pdf.SetCampo(luogo_nasc, dati.Comune.Descrizione)
                            Catch ex As InvalidFiscalCodeException
                                'lasci i campi vuoti
                            Catch ex1 As Exception

                            End Try
                            i = i + 1
                        End While
                    End If

                Catch ex As Exception

                End Try

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



                'pdf.SetCampo("D_al 8", "D_al 8")
                'pdf.SetCampo("N_progr 1", "N_progr 1")
                'pdf.SetCampo("N_progr 3", "N_progr 3")
                'pdf.SetCampo("N_progr 6", "N_progr 6")
                'pdf.SetCampo("N_progr 5", "N_progr 5")
                'pdf.SetCampo("N_progr 4", "N_progr 4")
                'pdf.SetCampo("N_progr 7", "N_progr 7")
                'pdf.SetCampo("D_1_6", "D_1_6")
                'pdf.SetCampo("D_1_7", "D_1_7")
                'pdf.SetCampo("D_1_4", "D_1_4")
                'pdf.SetCampo("D_1_5", "D_1_5")
                'pdf.SetCampo("D_dal 7", "D_dal 7")
                'pdf.SetCampo("D_1_3", "D_1_3")
                'pdf.SetCampo("D_1_1", "D_1_1")
                'pdf.SetCampo("provnascit", "provnascita")
                'pdf.SetCampo("L_1", "L_1")
                'pdf.SetCampo("M_1", "M_1")
                'pdf.SetCampo("Z5 nascosto", "Z5 nascosto")
                'pdf.SetCampo("E_data inizio 9", "E_data inizio 9")
                'pdf.SetCampo("D_1_8", "D_1_8")
                'pdf.SetCampo("D_1_9", "D_1_9")
                'pdf.SetCampo("cognome", "cognome")
                'pdf.SetCampo("A5", "A5")
                'pdf.SetCampo("D_3_12", "D_3_12")
                'pdf.SetCampo("C5", "C5")
                'pdf.SetCampo("domanda numero", "domanda numero")
                'pdf.SetCampo("D_3_3", "D_3_3")
                'pdf.SetCampo("Z3", "Z3")
                'pdf.SetCampo("Z", "Z")
                'pdf.SetCampo("D_al 3", "D_al 3")
                'pdf.SetCampo("N_com/nasc 1", "N_com/nasc 1")
                'pdf.SetCampo("D_1_15", "D_1_15")
                'pdf.SetCampo("D_al 11", "D_al 11")
                'pdf.SetCampo("N_cogn/nome 2", "N_cogn/nome 2")
                'pdf.SetCampo("N_cogn/nome 3", "N_cogn/nome 3")
                'pdf.SetCampo("D_3_10", "D_3_10")
                'pdf.SetCampo("N_cogn/nome 1", "N_cogn/nome 1")
                'pdf.SetCampo("N_cogn/nome 6", "N_cogn/nome 6")
                'pdf.SetCampo("A3", "A3")
                'pdf.SetCampo("B3", "B3")
                'pdf.SetCampo("C3", "C3")
                'pdf.SetCampo("E_data inizio 10", "E_data inizio 10")
                'pdf.SetCampo("N_parent 3", "N_parent 3")
                'pdf.SetCampo("A", "A")
                'pdf.SetCampo("E_data inizio 4", "E_data inizio 4")
                'pdf.SetCampo("C", "C")
                'pdf.SetCampo("D_1_10", "D_1_10")
                'pdf.SetCampo("Z nascosto", "Z nascosto")
                'pdf.SetCampo("comune nascita", "comune nascita")
                'pdf.SetCampo("D_2_13", "D_2_13")
                'pdf.SetCampo("N_codfisc 5", "N_codfisc 5")
                'pdf.SetCampo("L_patronato", "L_patronato")
                'pdf.SetCampo("D_dal 6", "D_dal 6")
                'pdf.SetCampo("E_data inizio 6", "E_data inizio 6")
                'pdf.SetCampo("cittadinanza", "cittadinanza")
                'pdf.SetCampo("E_data fine 8", "E_data fine 8")
                'pdf.SetCampo("N_com/nasc 5", "N_com/nasc 5")
                'pdf.SetCampo("Z7", "Z7")
                'pdf.SetCampo("D_2_4", "D_2_4")
                'pdf.SetCampo("D_2_5", "D_2_5")
                'pdf.SetCampo("D_2_2", "D_2_2")
                'pdf.SetCampo("D_al 10", "D_al 10")
                'pdf.SetCampo("N_codfisc 2", "N_codfisc 2")
                'pdf.SetCampo("D_3_11", "D_3_11")
                'pdf.SetCampo("D_dal 3", "D_dal 3")
                'pdf.SetCampo("A7 ", "A7")
                'pdf.SetCampo("B7 ", "B7")
                'pdf.SetCampo("C7 ", "C7")
                'pdf.SetCampo("L_5", "L_5")
                'pdf.SetCampo("descrizione", "descrizione")
                'pdf.SetCampo("Z2", "Z2")
                'pdf.SetCampo("E_data fine 10", "E_data fine 10")
                'pdf.SetCampo("D_dal 14", "D_dal 14")
                'pdf.SetCampo("D_3_13  ", "D_3_13")
                'pdf.SetCampo("D_al 2  ", "D_al 2")
                'pdf.SetCampo("D_al 13 ", "D_al 13")
                'pdf.SetCampo("M_data/nasc 1", "M_data/nasc 1")
                'pdf.SetCampo("M_data/nasc 2", "M_data/nasc 2")
                'pdf.SetCampo("M_data/nasc 3", "M_data/nasc 3")
                'pdf.SetCampo("M_data/nasc 4", "M_data/nasc 4")
                'pdf.SetCampo("M_data/nasc 5", "M_data/nasc 5")
                'pdf.SetCampo("M_data/nasc 6", "M_data/nasc 6")
                'pdf.SetCampo("M_data/nasc 7", "M_data/nasc 7")
                'pdf.SetCampo("D_3_6", "D_3_6")
                'pdf.SetCampo("N_codfisc 4", "N_codfisc 4")
                'pdf.SetCampo("B2", "B2")
                'pdf.SetCampo("C2", "C2")
                'pdf.SetCampo("D_3_2", "D_3_2")
                'pdf.SetCampo("Z2 nascosto", "Z2 nascosto")
                'pdf.SetCampo("D_3_1", "D_3_1")
                'pdf.SetCampo("N_com/nasc 7", "N_com/nasc 7")
                'pdf.SetCampo("D_3_8", "D_3_8")
                'pdf.SetCampo("D_3_9", "D_3_9")
                'pdf.SetCampo("D_al 7", "D_al 7")
                'pdf.SetCampo("N_parent 6", "N_parent 6")
                'pdf.SetCampo("D_3_7", "D_3_7")
                'pdf.SetCampo("D_3_4", "D_3_4")
                'pdf.SetCampo("sede inps", "sede inps")
                'pdf.SetCampo("comuneresidenza", "comuneresidenza")
                'pdf.SetCampo("Z1 nascosto", "Z1 nascosto")
                'pdf.SetCampo("D_2_12", "D_2_12")
                'pdf.SetCampo("N_codfisc 6", "N_codfisc 6")
                'pdf.SetCampo("D_3_15", "D_3_15")
                'pdf.SetCampo("G_ente erogatore", "G_ente erogatore")
                'pdf.SetCampo("cod_IBAN", "cod_IBAN")
                'pdf.SetCampo("D_dal 8", "D_dal 8")
                'pdf.SetCampo("Z6", "Z6")
                'pdf.SetCampo("N_cogn/nome 5", "N_cogn/nome 5")
                'pdf.SetCampo("E_data fine 1", "E_data fine 1")
                'pdf.SetCampo("D_al 6", "D_al 6")
                'pdf.SetCampo("E_data fine 4", "E_data fine 4")
                'pdf.SetCampo("E_data fine 5", "E_data fine 5")
                'pdf.SetCampo("E_data fine 7", "E_data fine 7")
                'pdf.SetCampo("nome", "nome")
                'pdf.SetCampo("D_1_2", "D_1_2")
                'pdf.SetCampo("N_com/nasc 6", "N_com/nasc 6")
                'pdf.SetCampo("A6", "A6")
                'pdf.SetCampo("B6", "B6")
                'pdf.SetCampo("C6", "C6")
                'pdf.SetCampo("Z7 nascosto", "Z7 nascosto")
                'pdf.SetCampo("Z1", "Z1")
                'pdf.SetCampo("M_sindacato", "M_sindacato")
                'pdf.SetCampo("Z3 nascosto", "Z3 nascosto")
                'pdf.SetCampo("D_al 1", "D_al 1")
                'pdf.SetCampo("D_al 14", "D_al 14")
                'pdf.SetCampo("E_data fine9", "E_data fine9")
                'pdf.SetCampo("D_1_13", "D_1_13")
                'pdf.SetCampo("D_dal 12", "D_dal 12")
                'pdf.SetCampo("E_data inizio 1", "E_data inizio 1")
                'pdf.SetCampo("A1", "A1")
                'pdf.SetCampo("B1", "B1")
                'pdf.SetCampo("C1", "C1")
                'pdf.SetCampo("F_data", "F_data")
                'pdf.SetCampo("N_parent 5", "N_parent 5")
                'pdf.SetCampo("telefono", "telefono")
                'pdf.SetCampo("N_anno 1", "N_anno 1")
                'pdf.SetCampo("D_dal 1", "D_dal 1")
                'pdf.SetCampo("D_1_12", "D_1_12")
                'pdf.SetCampo("dataversione", "dataversione")
                'pdf.SetCampo("N_codfisc 3", "N_codfisc 3")
                'pdf.SetCampo("D_2_11", "D_2_11")
                'pdf.SetCampo("E_data inizio 3", "E_data inizio 3")
                'pdf.SetCampo("D_dal 2", "D_dal 2")
                'pdf.SetCampo("N_anno 2", "N_anno 2")
                'pdf.SetCampo("M/F", "M/F")
                'pdf.SetCampo("H_data", "H_data")
                'pdf.SetCampo("L_4", "L_4")
                'pdf.SetCampo("protocollo", "protocollo")
                'pdf.SetCampo("D_3_14", "D_3_14")
                'pdf.SetCampo("D_1_14", "D_1_14")
                'pdf.SetCampo("cognome coniuge", "cognome coniuge")
                'pdf.SetCampo("N_parent 7", "N_parent 7")
                'pdf.SetCampo("codfisc", "codfisc")
                'pdf.SetCampo("Z5", "Z5")
                'pdf.SetCampo("M_data", "M_data")
                'pdf.SetCampo("D_dal 13", "D_dal 13")
                'pdf.SetCampo("G_data", "G_data")
                'pdf.SetCampo("N_progr 2", "N_progr 2")
                'pdf.SetCampo("D_al 5", "D_al 5")
                'pdf.SetCampo("D_2_6", "D_2_6")
                'pdf.SetCampo("D_2_7", "D_2_7")
                'pdf.SetCampo("E_data fine 2", "E_data fine 2")
                'pdf.SetCampo("E_data fine 3", "E_data fine 3")
                'pdf.SetCampo("D_dal 4", "D_dal 4")
                'pdf.SetCampo("D_2_3", "D_2_3")
                'pdf.SetCampo("E_data fine 6", "E_data fine 6")
                'pdf.SetCampo("D_2_1", "D_2_1")
                'pdf.SetCampo("nomefile", "nomefile")
                'pdf.SetCampo("L_2", "L_2")
                'pdf.SetCampo("M_2", "M_2")
                'pdf.SetCampo("D_2_8", "D_2_8")
                'pdf.SetCampo("D_2_9", "D_2_9")
                'pdf.SetCampo("B5", "B5")
                'pdf.SetCampo("D_3_5", "D_3_5")
                'pdf.SetCampo("B_data3", "B_data3")
                'pdf.SetCampo("D_dal 9", "D_dal 9")
                'pdf.SetCampo("PIN", "PIN")
                'pdf.SetCampo("L_data", "L_data")
                'pdf.SetCampo("N_com/nasc 4", "N_com/nasc 4")
                'pdf.SetCampo("datanascita", "datanascita")
                'pdf.SetCampo("N_codfisc 7", "N_codfisc 7")
                'pdf.SetCampo("E_data inizio 8", "E_data inizio 8")
                'pdf.SetCampo("F_ente erogatore", "F_ente erogatore")
                'pdf.SetCampo("B", "B")
                'pdf.SetCampo("N_cogn/nome 7", "N_cogn/nome 7")
                'pdf.SetCampo("N_cogn/nome 4", "N_cogn/nome 4")
                'pdf.SetCampo("D_dal 10", "D_dal 10")
                'pdf.SetCampo("E_data inizio 5", "E_data inizio 5")
                'pdf.SetCampo("D_dal 15", "D_dal 15")
                'pdf.SetCampo("D_2_10", "D_2_10")
                'pdf.SetCampo("D_al 9", "D_al 9")
                'pdf.SetCampo("N_parent 4", "N_parent 4")
                'pdf.SetCampo("E_altro", "E_altro")
                'pdf.SetCampo("N_com/nasc 3", "N_com/nasc 3")
                'pdf.SetCampo("provresidenza", "provresidenza")
                'pdf.SetCampo("D_al 15", "D_al 15")
                'pdf.SetCampo("indirizzoresidenza", "indirizzoresidenza")
                'pdf.SetCampo("E_data inizio 7", "E_data inizio 7")
                'pdf.SetCampo("Z4", "Z4")
                'pdf.SetCampo("D_dal 5", "D_dal 5")
                'pdf.SetCampo("A2", "A2")
                'pdf.SetCampo("Z6 nascosto", "Z6 nascosto")
                'pdf.SetCampo("D_al 4", "D_al 4")
                'pdf.SetCampo("capresidenza", "capresidenza")
                'pdf.SetCampo("Z4 nascosto", "Z4 nascosto")
                'pdf.SetCampo("A4", "A4")
                'pdf.SetCampo("B4", "B4")
                'pdf.SetCampo("C4", "C4")
                'pdf.SetCampo("D_dal 11", "D_dal 11")
                'pdf.SetCampo("N_parent 2", "N_parent 2")
                'pdf.SetCampo("N_codfisc 1", "N_codfisc 1")
                'pdf.SetCampo("N_parent 1", "N_parent 1")
                'pdf.SetCampo("email", "email")
                'pdf.SetCampo("D_al 12", "D_al 12")
                'pdf.SetCampo("D_1_11", "D_1_11")
                'pdf.SetCampo("E_data inizio 2", "E_data inizio 2")
                'pdf.SetCampo("L_3", "L_3")
                'pdf.SetCampo("M_3", "M_3")
                'pdf.SetCampo("C_data1", "C_data1")
                'pdf.SetCampo("N_com/nasc 2", "N_com/nasc 2")
                'pdf.SetCampo("D_2_14", "D_2_14")
                'pdf.SetCampo("D_2_15", "D_2_15")

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