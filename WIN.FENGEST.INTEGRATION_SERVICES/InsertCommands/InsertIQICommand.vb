Public Class InsertIQICommand
    Implements ICommand
    Public Event AddingRecord(ByVal num As Int32)
    Public Event AddingRecordError(ByVal num As Int32)

    Private m_ItemParameters As Hashtable
    Private m_Parameters As ArrayList

    Private m_FileLogName As String = ""



    Public SavedDocumentId As Int32


    ''' <summary>
    ''' Costruttore comando. Questo comando crea una quota inps. 
    ''' </summary>
   
    Public Sub New(ByVal Parameters As ArrayList, ByVal FileLogName As String)
        m_FileLogName = FileLogName
        m_Parameters = Parameters

    End Sub
    Public Sub Execute() Implements ICommand.Execute
        Dim controller As New WIN.APPLICATION.FINANCIAL_ARTIFACTS.ControllerIncassiQuoteInps

        '  Dim ControllerUtente As New WIN.APPLICATION.UTENTI.ControllerUtenti

        Dim filename As String = DirectCast(m_Parameters(0), Hashtable).Item("FILE_NAME")
        Dim tipoPrest As String = DirectCast(m_Parameters(0), Hashtable).Item("TIPO_PRESTAZIONE")


        Try
            CreateDocument(filename + " - - " + tipoPrest, controller)
            Dim i As Int32 = 0
            For Each elem As Hashtable In m_Parameters
                m_ItemParameters = elem
                Try

                    If Not m_ItemParameters.Item("DATA_INIZIO") Is Nothing Then
                        m_ItemParameters.Item("DATA_INIZIO") = m_ItemParameters.Item("DATA_INIZIO").ToString().Replace(" 0.00.00", "")
                    Else
                        m_ItemParameters.Item("DATA_INIZIO") = DateTime.Now.ToShortDateString
                    End If


                    'm_ItemParameters.Item("DATA_INIZIO") = m_ItemParameters.Item("DATA_INIZIO").ToString().Replace(" 0.00.00", "")

                    If m_ItemParameters.Item("QUOTA") Is Nothing Then m_ItemParameters.Item("QUOTA") = "0,01"

                    If m_ItemParameters.Item("FISCALE") Is Nothing Then m_ItemParameters.Item("FISCALE") = ""


                    Dim nomeUt As String = m_ItemParameters.Item("NOME_UTENTE")
                    Dim CognomeUt As String = m_ItemParameters.Item("COGNOME_UTENTE")

                    Dim nomeRef As String = m_ItemParameters.Item("NOME_REFERENTE")
                    Dim CognomeRef As String = m_ItemParameters.Item("COGNOME_REFERENTE")


                    If CType(m_ItemParameters.Item("QUOTA"), Double) < 0 Then
                        m_ItemParameters.Item("QUOTA") = CType(m_ItemParameters.Item("QUOTA"), Double) * -1
                    End If


                    If Not IsNumeric(m_ItemParameters.Item("QUOTA")) Then
                        m_ItemParameters.Item("QUOTA") = "0,01"
                    End If



                    If Not IsDate(m_ItemParameters.Item("DATA_INIZIO")) Then
                        Throw New Exception("Il campo DATA_INIZIO non è un campo di tipo data ___" + m_ItemParameters.Item("DATA_INIZIO"))
                    End If





                    Dim idUtente As String = -1
                    idUtente = UtenteRetriever.GetIdUtente(m_ItemParameters.Item("FISCALE"), nomeUt, CognomeUt, m_ItemParameters.Item("DATA_NASCITA_UTENTE"))

                    Dim idReferente As String = -1
                    idReferente = ReferenteRetriever.GetIdReferente(nomeRef, CognomeRef)


                    Dim idPrestazione As String = m_ItemParameters.Item("ID_PRESTAZIONE")

                    controller.AddItem(idUtente, m_ItemParameters.Item("QUOTA"), idReferente, m_ItemParameters.Item("SETTORE"), DateTime.Parse(m_ItemParameters.Item("DATA_INIZIO")),
                                        DateTime.Parse(m_ItemParameters.Item("DATA_INIZIO")).AddDays(1), idPrestazione)

                   


                Catch ex As Exception
                    Try
                        My.Computer.FileSystem.WriteAllText(m_FileLogName, "Riga del documento" & (i + 1).ToString & " " & ex.Message & vbCrLf, True)
                    Catch ex1 As Exception
                    End Try
                    RaiseEvent AddingRecordError(i)
                End Try
                i = i + 1
                RaiseEvent AddingRecord(i)
            Next

            controller.SetImporto(controller.Totale)

            controller.Save()


            SavedDocumentId = controller.IdDocumento

        Catch ex As Exception
            If Not m_ItemParameters Is Nothing Then
                Throw New ImportIQIException(ex.Message + ": Errore nel salvataggio", m_ItemParameters.Item("NOME_UTENTE"), m_ItemParameters.Item("COGNOME_UTENTE"))
            Else
                Throw
            End If

        End Try
    End Sub

    Private Sub CreateDocument(comune As String, ByVal Controller As WIN.APPLICATION.FINANCIAL_ARTIFACTS.ControllerIncassiQuoteInps)

        If comune Is Nothing Then
            comune = "Comune non specificato"
        End If
      
        Controller.CreateNew(DateTime.Now.Date, DateTime.Now.Date, _
                                             "0", comune, New DateTime(DateTime.Now.Year, 1, 1).Date, _
                                               New DateTime(DateTime.Now.Year, 12, 31).Date)

    End Sub
End Class
