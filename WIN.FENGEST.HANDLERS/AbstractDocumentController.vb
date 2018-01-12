Namespace FINANCIAL_ARTIFACTS
    Public Class AbstractDocumentController
        Inherits AbstractController

        Protected m_currentItem As ItemContabile
        Private Function Current() As DocumentoContabile
            Return DirectCast(MyBase.m_current, DocumentoContabile)
        End Function
        Public Shared Function GetDocumentController(ByVal Tipodocumento As String) As AbstractDocumentController

            Select Case Tipodocumento
                Case "IQA"
                    Return New FINANCIAL_ARTIFACTS.ControllerIncassiQuote
                Case "IQP"
                    Return New FINANCIAL_ARTIFACTS.ControllerIncassiQuotePrevisionali
                Case "PGR"
                    Return New FINANCIAL_ARTIFACTS.ControllerPagamentoReferenti
                Case "IQI"
                    Return New FINANCIAL_ARTIFACTS.ControllerIncassiQuoteInps
                Case "IQV"
                    Return New FINANCIAL_ARTIFACTS.ControllerIncassiQuoteVertenza
                Case Else
                    Throw New Exception("Impossibile creare un controllore documento. Tipo documento sconosciuto.")
            End Select

        End Function

#Region "Proprietà Documento Testata"
        Public ReadOnly Property IdDocumento() As Int32
            Get
                Return Current.Key.LongValue
            End Get
        End Property
        Public Property DataRegistrazione() As DateTime
            Get
                Return Current.DataRegistrazione
            End Get
            Set(ByVal value As DateTime)
                Current.DataRegistrazione = value
            End Set
        End Property
        Public ReadOnly Property TipoDocumento() As String
            Get
                Return Current.TipoDocumento
            End Get
        End Property
        Public ReadOnly Property DescrizioneTipoPrestazione() As String
            Get
                Dim Prest As Prestazione = DirectCast(m_currentItem.Prestazione, Prestazione)
                Return Prest.TipoPrestazione.Descrizione
            End Get
        End Property
        Public Property DataDocumento() As DateTime
            Get
                Return Current.DataDocumento
            End Get
            Set(ByVal value As DateTime)
                Current.DataDocumento = value
            End Set
        End Property
        Public Property Note() As String
            Get
                Return Current.Note
            End Get
            Set(ByVal value As String)
                Current.Note = value
            End Set
        End Property
        Public ReadOnly Property Totale() As Double
            Get
                Return Current.GetTotal.Importo
            End Get
        End Property

        Public Overridable ReadOnly Property ListaPosizioni() As IList
            Get
                Return Current.ItemList
            End Get
        End Property

#End Region

#Region "Proprietà Item di IIDescriptors"
        Public ReadOnly Property IdReferenteItem() As String
            Get
                If m_currentItem.Referente.Key.Value(0) = -1 Then Return ""
                Return m_currentItem.Referente.Key.Value(0)
            End Get
        End Property
        Public Overridable ReadOnly Property IdSoggettoEsecutore() As String
            Get
                Return m_currentItem.SoggettoEsecutore.Key.LongValue
            End Get
        End Property
        Public ReadOnly Property IdUtenteItem() As Int32
            Get
                Return m_currentItem.Utente.IdUtente
            End Get
        End Property
        Public ReadOnly Property NameUtenteItem() As String
            Get
                Return m_currentItem.Utente.CompleteName
            End Get
        End Property
        Public ReadOnly Property NameReferenteItem() As String
            Get
                Return m_currentItem.Referente.CompleteName
            End Get
        End Property
        Public ReadOnly Property QuotaMensileItem() As Double
            Get
                Return DirectCast(m_currentItem, ItemIncassoQuotaAssociativa).QuotaMensileUtente.Importo
            End Get
        End Property
        Public ReadOnly Property CongruitaItemToString() As String
            Get
                Return DirectCast(m_currentItem, IItemDescriptors).GetCongruitaToString
            End Get
        End Property
        Public ReadOnly Property CongruitaItem() As IValuableForCongruity.Congruita
            Get
                Return DirectCast(m_currentItem, ItemIncassoQuotaAssociativa).GetCongruita
            End Get
        End Property
        Public ReadOnly Property IdPagamentoReferenti() As String
            Get
                If m_currentItem.PagamentoReferente.Id = -1 Then Return ""
                Return m_currentItem.PagamentoReferente.Id
            End Get
        End Property
        Public ReadOnly Property ImportoRistornoItem() As Double
            Get
                Return m_currentItem.ImportoRistorno.Importo
            End Get
        End Property
        Public ReadOnly Property QuotaMediaItem() As Double
            Get
                Return m_currentItem.GetQuotaMedia.Importo
            End Get
        End Property
        Public Property QuattordicesimaItem() As Boolean
            Get
                Return m_currentItem.Quattordicesima
            End Get
            Set(ByVal value As Boolean)
                m_currentItem.Quattordicesima = value
            End Set
        End Property
        Public Property TredicesimaItem() As Boolean
            Get
                Return m_currentItem.Tredicesima
            End Get
            Set(ByVal value As Boolean)
                m_currentItem.Tredicesima = value
            End Set
        End Property
        Public Overridable ReadOnly Property CompetenzaItem() As String
            Get
                Return m_currentItem.Competenza.ToString
            End Get
        End Property
        Public ReadOnly Property DataInizioCompetenzaItem() As DateTime
            Get
                Return m_currentItem.Competenza.GetDataRange.Start
            End Get
        End Property
        Public ReadOnly Property DataFineCompetenzaItem() As DateTime
            Get
                Return m_currentItem.Competenza.GetDataRange.Finish
            End Get
        End Property
        Public Overridable ReadOnly Property DescrizioneSettoreItem() As String
            Get
                Return m_currentItem.Settore.Descrizione
            End Get
        End Property
        Public Property NoteItem() As String
            Get
                Return m_currentItem.Note
            End Get
            Set(ByVal value As String)
                m_currentItem.Note = value
            End Set
        End Property
        Public ReadOnly Property DataRegistrazioneItem()
            Get
                Return m_currentItem.DataRegistrazione
            End Get
        End Property
        Public ReadOnly Property DataDocumentoItem()
            Get
                Return m_currentItem.DataDocumento
            End Get
        End Property
        Public ReadOnly Property ImportoItem() As Double
            Get
                Return m_currentItem.Importo.Importo
            End Get
        End Property
        Public ReadOnly Property IdContoItem() As Int32
            Get
                Return m_currentItem.Conto.Id
            End Get
        End Property
        Public ReadOnly Property IdAziendaImpiegoItem() As String
            Get
                If m_currentItem.AziendaImpiego.Id = -1 Then Return ""
                Return m_currentItem.AziendaImpiego.Id
            End Get
        End Property
        Public ReadOnly Property IdPrestazioneItem() As String
            Get
                If m_currentItem.Prestazione.GetId = -1 Then Return ""
                Return m_currentItem.Prestazione.GetId
            End Get
        End Property
        Public ReadOnly Property IdVertenzaItem() As Int32
            Get
                Return m_currentItem.Vertenza.GetId
            End Get
        End Property
        Public ReadOnly Property DescrizioneAziendaImpiegoItem() As String
            Get
                Return m_currentItem.AziendaImpiego.Descrizione
            End Get
        End Property

        ''' <summary>
        ''' Metodo che imposta l'azienda di impiego nelle posizioni incasso quota associativa se il settore dell'incasso
        ''' non è il settore Impianti fissi
        ''' </summary>
        ''' <param name="IdAzienda"></param>
        ''' <remarks></remarks>
        Public Sub SetAziendaImpiegoItem(ByVal IdAzienda As String)
            Try
                If IdAzienda = "" Then IdAzienda = -1
                If m_currentItem.AziendaImpiego.Id = IdAzienda Then Exit Sub
                If DirectCast(Current(), IncassoQuotaAssociativa).Settore.TipologiaSettore = Settore.TipoSettore.Edili Then
                    Dim controllerAziende As New AZIENDE.ControllerAziende
                    If Not IsNumeric(IdAzienda) Then Throw New Exception("L'id azienda non è corretto.")
                    m_currentItem.AziendaImpiego = controllerAziende.GetAziendaById(IdAzienda)
                Else
                    Throw New Exception("Impossibile impostare l'azienda di impiego per il lavoratore nel settore impianti fissi")
                End If
            Catch ex As Exception
                Throw New Exception("Impossibile impostare l'azienda di impiego." & vbCrLf & ex.Message)
            End Try
        End Sub
        Public ReadOnly Property DescrizioneContrattoItem() As String
            Get
                Return m_currentItem.ContrattoApplicato.Descrizione
            End Get
        End Property

        Public Property LivelloInquadramentoItem() As String
            Get
                Return m_currentItem.LivelloInquadramento
            End Get
            Set(ByVal value As String)
                m_currentItem.LivelloInquadramento = value
            End Set
        End Property
        Public Property OreLavorateItem() As String
            Get
                Return m_currentItem.OreLavorate
            End Get
            Set(ByVal value As String)
                If value = "" Then value = 0
                If Not IsNumeric(value) Then Throw New Exception("Le ore lavorate devono essere espresse come numero")
                m_currentItem.OreLavorate = value
            End Set
        End Property
        Public Property OreMalattiaItem() As String
            Get
                Return m_currentItem.OreMalattia
            End Get
            Set(ByVal value As String)
                If value = "" Then value = 0
                If Not IsNumeric(value) Then Throw New Exception("Le ore malattia devono essere espresse come numero")
                m_currentItem.OreMalattia = value
            End Set
        End Property
#End Region
        Public Overridable Sub SortItems(ByVal PropertyName As String, Optional ByVal Descending As Boolean = False)

            If PropertyName = "" Then Throw New Exception("Selezionare una proprietà.")
            Current.ItemList.Sort(SortFactory.GetItemComparer(PropertyName, Descending))

        End Sub
        Public Overridable Sub SelectItemByIds(ByVal IdDocumento As String, ByVal IdItem As String)
            If Not IsNumeric(IdDocumento) Then Throw New Exception("Impossibile selezionare la posizione del documento. Il formato dell'id documento non è corretto.")
            If Not IsNumeric(IdItem) Then Throw New Exception("Impossibile selezionare la posizione del documento. Il formato dell'id dell'item non è corretto.")

            For Each elem As ItemContabile In Current.ItemList
                If elem.Key.Value(1) = IdDocumento And elem.Key.Value(0) = IdItem Then
                    m_currentItem = elem
                    Exit Sub
                End If
            Next
            Throw New Exception("Impossibile selezionare la posizione del documento. Gli id immessi non si riferiscono a nessuna posizione.")

        End Sub
        Protected Overridable Sub CommitTransaction()
            '
        End Sub
        Protected Overrides Sub DoSave()

            Current.Post()
            CommitTransaction()

        End Sub
        Friend Function GetDocumentoById(ByVal IdDocumento As Int32) As DocumentoContabile

            LoadById(IdDocumento)
            Return Current()

        End Function
        Public Sub UpdateCurrentItem()
            Try
                Ps.BeginTransaction()
                Ps.MarkDirty(m_currentItem)
                Ps.CommitTransaction()
            Catch ex As Exception
                Ps.RollBackTRansaction()
                Throw
            End Try
        End Sub
        Public Overrides Sub CreateNew()
            '
        End Sub
    End Class
End Namespace