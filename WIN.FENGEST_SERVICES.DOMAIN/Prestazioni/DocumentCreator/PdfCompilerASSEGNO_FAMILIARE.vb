Imports WIN.TECHNICAL.PDF_PRINTER
Imports System.Runtime.InteropServices

Public Class PdfCompilerASSEGNO_FAMILIARE
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
                'pdf.SetCampo("periodo_1", "periodo_1")
                'pdf.SetCampo("periodo_2", "periodo_2")
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

                'inserisco i dati ripetuti per il richiedente
                pdf.SetCampo("nome_15", Prestazione.Utente.Nome)
                pdf.SetCampo("cognome_15", Prestazione.Utente.Cognome)
                pdf.SetCampo("cod_fisc_15", Prestazione.Utente.CodiceFiscale)
                pdf.SetCampo("data_nasc_15", Prestazione.Utente.DataNascita)
                pdf.SetCampo("luogo_nasc_15", Prestazione.Utente.ComuneNascita.Descrizione)
                pdf.SetCampo("prov_nasc_15", Prestazione.Utente.ProvinciaNascita.Sigla)
                pdf.SetCampo("stato_nasc_15", Prestazione.Utente.Nazionalita.Descrizione)
                Try
                    'controllo che esista in coniuge
                    If Not String.IsNullOrEmpty(Prestazione.Utente.SituazioneFamiliare.Coniuge.Cognome) Then
                        'inserisco i dati del coniuge
                        pdf.SetCampo("nome_16", Prestazione.Utente.SituazioneFamiliare.Coniuge.Nome)
                        pdf.SetCampo("cognome_16", Prestazione.Utente.SituazioneFamiliare.Coniuge.Cognome)
                        pdf.SetCampo("cod_fisc_16", Prestazione.Utente.SituazioneFamiliare.Coniuge.CodiceFiscale)
                        pdf.SetCampo("parent_16", "Coniuge")
                        Try

                            Dim dati As DatiFiscali = GeoLocationFacade.Instance.CalcolaDatiFiscali(Prestazione.Utente.SituazioneFamiliare.Coniuge.CodiceFiscale)
                            pdf.SetCampo("data_nasc_16", dati.DataNascita)
                            pdf.SetCampo("luogo_nasc_16", dati.Comune.Descrizione)
                            pdf.SetCampo("prov_nasc_16", dati.Provincia.Descrizione)
                            pdf.SetCampo("stato_nasc_16", dati.Nazione.Descrizione)
                        Catch ex As InvalidFiscalCodeException
                            'lasci i campi vuoti
                        Catch ex1 As Exception

                        End Try

                        'inserisco al max 4 figli
                        Dim count As Int32
                        Dim i As Int32 = 0
                        Dim nome As String
                        Dim cognome As String
                        Dim cod_fisc As String
                        Dim data_nasc As String
                        Dim luogo_nasc As String
                        Dim prov_nasc As String
                        Dim stato_nasc As String
                        Dim parent As String
                        count = Prestazione.Utente.SituazioneFamiliare.Figli.Count()
                        If (count = 0) Then
                            count = -1
                        End If
                        While (i < count And i < 4)
                            If (i < 2) Then
                                nome = "nome_" + (i + 17).ToString
                                cognome = "cognome_" + (i + 17).ToString
                                cod_fisc = "cod_fisc_" + (i + 17).ToString
                                data_nasc = "data_nasc_" + (i + 17).ToString
                                luogo_nasc = "luogo_nasc_" + (i + 17).ToString
                                prov_nasc = "prov_nasc_" + (i + 17).ToString
                                stato_nasc = "stato_nasc_" + (i + 17).ToString
                                parent = "parent_" + (i + 17).ToString
                            Else
                                nome = "nome_" + (i + 11).ToString
                                cognome = "cognome_" + (i + 11).ToString
                                cod_fisc = "cod_fisc_" + (i + 11).ToString
                                data_nasc = "data_nasc_" + (i + 11).ToString
                                luogo_nasc = "luogo_nasc_" + (i + 11).ToString
                                prov_nasc = "prov_nasc_" + (i + 11).ToString
                                stato_nasc = "stato_nasc_" + (i + 11).ToString
                                parent = "parent_" + (i + 11).ToString
                            End If

                            Dim figlio As Figlio = DirectCast(Prestazione.Utente.SituazioneFamiliare.Figli.Item(i), Figlio)
                            pdf.SetCampo(nome, figlio.Nome)
                            pdf.SetCampo(cognome, figlio.Cognome)
                            pdf.SetCampo(cod_fisc, figlio.CodiceFiscale)
                            pdf.SetCampo(parent, "Figlio")
                            Try

                                Dim dati As DatiFiscali = GeoLocationFacade.Instance.CalcolaDatiFiscali(figlio.CodiceFiscale)
                                pdf.SetCampo(data_nasc, dati.DataNascita)
                                pdf.SetCampo(luogo_nasc, dati.Comune.Descrizione)
                                pdf.SetCampo(prov_nasc, dati.Provincia.Descrizione)
                                pdf.SetCampo(stato_nasc, dati.Nazione.Descrizione)
                            Catch ex As InvalidFiscalCodeException
                                'lasci i campi vuoti
                            Catch ex1 As Exception

                            End Try

                            i = i + 1
                        End While
                    Else
                        'inserisco al max 5 figli
                        Dim count As Int32
                        Dim i As Int32 = 0
                        Dim nome As String
                        Dim cognome As String
                        Dim cod_fisc As String
                        Dim data_nasc As String
                        Dim luogo_nasc As String
                        Dim prov_nasc As String
                        Dim stato_nasc As String
                        Dim parent As String
                        count = Prestazione.Utente.SituazioneFamiliare.Figli.Count()
                        If (count = 0) Then
                            count = -1
                        End If
                        While (i < count And i < 5)
                            If (i < 3) Then
                                nome = "nome_" + (i + 16).ToString
                                cognome = "cognome_" + (i + 16).ToString
                                cod_fisc = "cod_fisc_" + (i + 16).ToString
                                data_nasc = "data_nasc_" + (i + 16).ToString
                                luogo_nasc = "luogo_nasc_" + (i + 16).ToString
                                prov_nasc = "prov_nasc_" + (i + 16).ToString
                                stato_nasc = "stato_nasc_" + (i + 16).ToString
                                parent = "parent_" + (i + 16).ToString
                            Else
                                nome = "nome_" + (i + 10).ToString
                                cognome = "cognome_" + (i + 10).ToString
                                cod_fisc = "cod_fisc_" + (i + 10).ToString
                                data_nasc = "data_nasc_" + (i + 10).ToString
                                luogo_nasc = "luogo_nasc_" + (i + 10).ToString
                                prov_nasc = "prov_nasc_" + (i + 10).ToString
                                stato_nasc = "stato_nasc_" + (i + 10).ToString
                                parent = "parent_" + (i + 10).ToString
                            End If

                            Dim figlio As Figlio = DirectCast(Prestazione.Utente.SituazioneFamiliare.Figli.Item(i), Figlio)
                            pdf.SetCampo(nome, figlio.Nome)
                            pdf.SetCampo(cognome, figlio.Cognome)
                            pdf.SetCampo(cod_fisc, figlio.CodiceFiscale)
                            pdf.SetCampo(parent, "Figlio")
                            Try

                                Dim dati As DatiFiscali = GeoLocationFacade.Instance.CalcolaDatiFiscali(figlio.CodiceFiscale)
                                pdf.SetCampo(data_nasc, dati.DataNascita)
                                pdf.SetCampo(luogo_nasc, dati.Comune.Descrizione)
                                pdf.SetCampo(prov_nasc, dati.Provincia.Descrizione)
                                pdf.SetCampo(stato_nasc, dati.Nazione.Descrizione)
                            Catch ex As InvalidFiscalCodeException
                                'lasci i campi vuoti
                            Catch ex1 As Exception

                            End Try

                            i = i + 1
                        End While

                    End If
                Catch ex As Exception

                End Try

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