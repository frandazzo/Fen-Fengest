Imports System.Globalization

Public Class InsertIQACommand
    Implements ICommand
    Public Event AddingRecord(ByVal num As Int32)
    Public Event AddingRecordError(ByVal num As Int32)

    Private m_ItemParameters As Hashtable
    Private m_Parameters As ArrayList
    Private Const CASSA_EDILE As Int32 = 1
    Private Const EDILCASSA As Int32 = 2
    Dim settore As Int32 = -1

    Private Const IMPIANTI_FISSI As Int32 = 1
    Private Const EDILE As Int32 = 2

    Private IsIF As Boolean = False
    Private IsCassaEdile As Boolean = False
    Private m_IdAzienda As Int32 = -1
    Private m_FileLogName As String = ""
    Private m_checkPaybility As Boolean = False


    Public SavedDocumentId As Int32


    ''' <summary>
    ''' Costruttore comando. Questo comando crea una quota associativa. 
    ''' </summary>
    ''' <param name="Parameters">Le chiavi ammesse sono: DATA_INIZIO, DATA_FINE, 
    ''' SETTORE:-- "IMPIANTI FISSI", "EDILE" --, ENTE, NOME_UTENTE, COGNOME_UTENTE, DATA_NASCITA_UTENTE,
    ''' NOTE, NOME_REFERENTE, COGNOME_REFERENTE, LIVELLO, AZIENDA_IMPIEGO, QUOTA,
    ''' ORE_LAVORATE, ORE_MALATTIA_INFOTUNIO</param>
    ''' <remarks></remarks>
    Public Sub New(ByVal Parameters As ArrayList, ByVal FileLogName As String, ByVal CheckPaybility As Boolean)
        m_FileLogName = FileLogName
        m_Parameters = Parameters
        m_checkPaybility = Not CheckPaybility
    End Sub
    Public Sub Execute() Implements ICommand.Execute
        Dim controller As New WIN.APPLICATION.FINANCIAL_ARTIFACTS.ControllerIncassiQuote
        Dim controllerSettore As New WIN.APPLICATION.ControllerSettori
        Dim ControllerUtente As New WIN.APPLICATION.UTENTI.ControllerUtenti
        Dim ControllerAzienda As New WIN.APPLICATION.AZIENDE.ControllerAziende



        Try
            CreateDocument(m_Parameters.Item(0), controller)
            Dim i As Int32 = 0
            For Each elem As Hashtable In m_Parameters
                m_ItemParameters = elem
                Try

                    m_ItemParameters.Item("DATA_INIZIO") = m_ItemParameters.Item("DATA_INIZIO").ToString().Replace(" 0.00.00", "")
                    m_ItemParameters.Item("DATA_FINE") = m_ItemParameters.Item("DATA_FINE").ToString().Replace(" 0.00.00", "")


                    If m_ItemParameters.Item("QUOTA") Is Nothing Then m_ItemParameters.Item("QUOTA") = ""
                    If m_ItemParameters.Item("NOTE") Is Nothing Then m_ItemParameters.Item("NOTE") = ""
                    If m_ItemParameters.Item("ORE_LAVORATE") Is Nothing Then m_ItemParameters.Item("ORE_LAVORATE") = ""
                    If m_ItemParameters.Item("ORE_MALATTIA_INFORTUNIO") Is Nothing Then m_ItemParameters.Item("ORE_MALATTIA_INFORTUNIO") = ""
                    If m_ItemParameters.Item("LIVELLO") Is Nothing Then m_ItemParameters.Item("LIVELLO") = ""
                    If m_ItemParameters.Item("PARTITA_IVA") Is Nothing Then m_ItemParameters.Item("PARTITA_IVA") = ""
                    If m_ItemParameters.Item("AZIENDA_IMPIEGO") Is Nothing Then m_ItemParameters.Item("AZIENDA_IMPIEGO") = ""

                    If m_ItemParameters.Item("FISCALE") Is Nothing Then m_ItemParameters.Item("FISCALE") = ""

                    If m_ItemParameters.Item("CONTRATTO") Is Nothing Then m_ItemParameters.Item("CONTRATTO") = ""


                    Dim nomeUt As String = m_ItemParameters.Item("NOME_UTENTE")
                    Dim CognomeUt As String = m_ItemParameters.Item("COGNOME_UTENTE")
                    Dim nomeAz As String = m_ItemParameters.Item("AZIENDA_IMPIEGO")
                    Dim part As String = m_ItemParameters.Item("PARTITA_IVA")
                    Dim contratto As String = m_ItemParameters.Item("CONTRATTO")


                    If CType(m_ItemParameters.Item("QUOTA"), Double) < 0 Then
                        m_ItemParameters.Item("QUOTA") = CType(m_ItemParameters.Item("QUOTA"), Double) * -1
                    End If


                    If Not IsNumeric(m_ItemParameters.Item("QUOTA")) Then
                        Throw New Exception("Il campo QUOTA non è un campo numerico")
                    End If



                    If Not IsDate(m_ItemParameters.Item("DATA_INIZIO")) Then
                        Throw New Exception("Il campo DATA_INIZIO non è un campo di tipo data ___" + m_ItemParameters.Item("DATA_INIZIO"))
                    End If


                    If Not IsDate(m_ItemParameters.Item("DATA_FINE")) Then
                        Throw New Exception("Il campo DATA_FINE non è un campo di tipo data")
                    End If


                    Dim idUtente As String = -1
                    idUtente = UtenteRetriever.GetIdUtente(m_ItemParameters.Item("FISCALE"), nomeUt, CognomeUt, m_ItemParameters.Item("DATA_NASCITA_UTENTE"))








                    controller.AddItem(idUtente, m_ItemParameters.Item("QUOTA"), "", m_ItemParameters.Item("NOTE"), False, False, _
                                                    DateTime.Parse(m_ItemParameters.Item("DATA_INIZIO")), DateTime.Parse(m_ItemParameters.Item("DATA_FINE")), m_checkPaybility)


                    controller.SelectItem(idUtente, DateTime.Parse(m_ItemParameters.Item("DATA_INIZIO")), DateTime.Parse(m_ItemParameters.Item("DATA_FINE")))
                    'adesso imposto tutte le proprietà

                    controller.OreLavorateItem = m_ItemParameters.Item("ORE_LAVORATE")
                    controller.OreMalattiaItem = m_ItemParameters.Item("ORE_MALATTIA_INFORTUNIO")
                    controller.LivelloInquadramentoItem = m_ItemParameters.Item("LIVELLO")

                    If Not IsIF Then
                        Dim idAz As Int32 = AziendaRetriever.GetIdAzienda(part, nomeAz)
                        controller.SetAziendaImpiegoItem(idAz)

                    End If
                    controller.SetContrattoApplicatoItem(contratto)
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
            controller.Save()


            SavedDocumentId = controller.IdDocumento

        Catch ex As Exception
            If Not m_ItemParameters Is Nothing Then
                Throw New ImportIQAException(ex.Message, m_ItemParameters.Item("NOME_UTENTE"), m_ItemParameters.Item("COGNOME_UTENTE"), m_ItemParameters.Item("ENTE"))
            Else
                Throw
            End If

        End Try
    End Sub

    Private Sub CreateDocument(ByVal DocProperties As Hashtable, ByVal Controller As WIN.APPLICATION.FINANCIAL_ARTIFACTS.ControllerIncassiQuote)

        DocProperties.Item("DATA_INIZIO") = DocProperties.Item("DATA_INIZIO").ToString().Replace(" 0.00.00", "")
        DocProperties.Item("DATA_FINE") = DocProperties.Item("DATA_FINE").ToString().Replace(" 0.00.00", "")


        ' Dim c As DateTime

        If Not IsNumeric(DocProperties.Item("QUOTA")) Then
            Throw New Exception("Il campo QUOTA non è un campo numerico")
        End If
       

        If Not IsDate(DocProperties.Item("DATA_INIZIO")) Then
            Throw New Exception("Il campo DATA_INIZIO non è un campo di tipo data")
        End If
        If Not IsDate(DocProperties.Item("DATA_FINE")) Then
            Throw New Exception("Il campo DATA_FINE non è un campo di tipo data")
        End If

        If DocProperties.Item("SETTORE") <> "EDILE" And DocProperties.Item("SETTORE") <> "IMPIANTI FISSI" Then
            Throw New Exception("Il campo Settore è sconosciuto: impostarlo a EDILE o IMPIANTI FISSI")
        End If





        settore = SettoreRetiever.GetIdSettore(DocProperties.Item("SETTORE"))
        IsIF = SettoreRetiever.IsImpiantiFissi(DocProperties.Item("SETTORE"))


        If IsIF Then
            m_IdAzienda = AziendaRetriever.GetIdAzienda(DocProperties.Item("PARTITA_IVA"), DocProperties.Item("ENTE"))
            If m_IdAzienda = -1 Then Throw New Exception("Azienda " & DocProperties.Item("ENTE").ToString & "non trovata")
        Else
            m_IdAzienda = EnteRetriever.GetIdEnteForEdili(DocProperties.Item("ENTE"))
            IsCassaEdile = EnteRetriever.IsCassaEdile(DocProperties.Item("ENTE"))
        End If
        Dim data As DateTime
        If IsDate(DocProperties.Item("DATA_FINE")) Then
            data = CDate(DocProperties.Item("DATA_FINE"))
            data = data.AddDays(1)
        Else
            Throw New Exception("Impossibile trovare una data di registrazione")
        End If

        Controller.CreateNew(DateTime.Now, data, m_IdAzienda, 0, "", settore, CDate(DocProperties.Item("DATA_INIZIO")), CDate(DocProperties.Item("DATA_FINE")), , , False)
    End Sub
End Class
