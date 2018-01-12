Public Class Quota
   Inherits AbstractPersistenceObject
#Region "Variabili protette Descrittori"


   'Variabili presenti nell'interfaccia descrittore
   '***************************************************
   '***************************************************
   Protected m_SoggettoEsecutore As String = ""
   Protected m_IdSoggettoEsecutore As String = ""

   Protected m_Utente As String = ""
   Protected m_IdUtente As String = ""

   Protected m_QuotaMedia As String = ""

   Protected m_Importo As Double = 0
   Protected m_ImportoRistorno As Double = 0
   Protected m_DocumentoPadre As String = ""

   Protected m_Referente As String = ""
   Protected m_IdReferente As String = ""

   Protected m_Competenza As AbstractPeriodo = New PeriodoNullo
   Protected m_TredicesimaInclusa As Boolean = False
   Protected m_QuattordicesimaInclusa As Boolean = False

   Protected m_DocumentoRistorno As String = ""

   Protected m_settore As String = ""
   Protected m_Idsettore As String = ""

   Protected m_AziendaImpiego As String = ""
   Protected m_IdAziendaImpiego As String = ""

   Protected m_ContrattoApplicato As String = ""
   Protected m_IdContrattoApplicato As String = ""

   Protected m_LivelloInquadramento As String = ""
   Protected m_OreLavorate As Double = 0
   Protected m_OreMalattia As Double = 0

   Protected m_TipoPrestazione As String = ""
   Protected m_prestazione As String = ""
   Protected m_Idprestazione As String = ""


   Protected m_IdVertenza As String = ""

   Protected m_dataRegistrazione As DateTime = Date.MinValue
   Protected m_dataDocumento As DateTime = Date.MinValue
   Protected m_note As String = ""
   Protected m_TipoDocumento As String = ""
   ' Protected m_PercentualeRistornoDeleghe As Double = 0
   Protected m_sedeoperativa As String = ""
    Protected m_CodiceFiscale As String = ""



    Private m_ProvinciaNascita As String
    Public Property ProvinciaNascita() As String
        Get
            Return m_ProvinciaNascita
        End Get
        Set(ByVal value As String)
            m_ProvinciaNascita = value
        End Set
    End Property

    Private m_ComuneNascita As String
    Public Property ComuneNascita() As String
        Get
            Return m_ComuneNascita
        End Get
        Set(ByVal value As String)
            m_ComuneNascita = value
        End Set
    End Property

    Private m_Provincia As String
    Public Property Provincia() As String
        Get
            Return m_Provincia
        End Get
        Set(ByVal value As String)
            m_Provincia = value
        End Set
    End Property


    Private m_comune As String
    Public Property Comune() As String
        Get
            Return m_comune
        End Get
        Set(ByVal value As String)
            m_comune = value
        End Set
    End Property


    Private m_cap As String
    Public Property Cap() As String
        Get
            Return m_cap
        End Get
        Set(ByVal value As String)
            m_cap = value
        End Set
    End Property


    Private m_indirizzo As String
    Public Property Indirizzo() As String
        Get
            Return m_indirizzo
        End Get
        Set(ByVal value As String)
            m_indirizzo = value
        End Set
    End Property

    Private m_cognome As String
    Public Property Cognome() As String
        Get
            Return m_cognome
        End Get
        Set(ByVal value As String)
            m_cognome = value
        End Set
    End Property

    Private m_nome As String
    Public Property Nome() As String
        Get
            Return m_nome
        End Get
        Set(ByVal value As String)
            m_nome = value
        End Set
    End Property


    Private m_DataNascita As DateTime
    Public Property DataNascita() As DateTime
        Get
            Return m_DataNascita
        End Get
        Set(ByVal value As DateTime)
            m_DataNascita = value
        End Set
    End Property



   '***************************************************
   '***************************************************
#End Region

    Public Property CodiceFiscale() As String
        Get
            Return m_CodiceFiscale
        End Get
        Set(ByVal value As String)
            m_CodiceFiscale = value
        End Set
    End Property


   Public Property TipoPrestazione() As String
      Get
         Return m_TipoPrestazione
      End Get
      Set(ByVal value As String)
         m_TipoPrestazione = value
      End Set
   End Property

   Public Property IdSoggettoEsecutore() As String
      Get
         Return m_IdSoggettoEsecutore
      End Get
      Set(ByVal value As String)
         m_IdSoggettoEsecutore = value
      End Set
   End Property

   Public Property SoggettoEsecutore() As String
      Get
         Return m_SoggettoEsecutore
      End Get
      Set(ByVal value As String)
         m_SoggettoEsecutore = value
      End Set
   End Property
   Public Property Utente() As String
      Get
         Return m_Utente
      End Get
      Set(ByVal value As String)
         m_Utente = value
      End Set
   End Property


   Public Property IdUtente() As String
      Get
         Return m_IdUtente
      End Get
      Set(ByVal value As String)
         m_IdUtente = value
      End Set
   End Property


   Public Property DocumentoPadre() As String
      Get
         Return m_DocumentoPadre
      End Get
      Set(ByVal value As String)
         m_DocumentoPadre = value
      End Set
   End Property

 
   Public Property Settore() As String
      Get
         Return m_settore
      End Get
      Set(ByVal value As String)
         m_settore = value
      End Set
   End Property

   Public Property IdSettore() As String
      Get
         Return m_Idsettore
      End Get
      Set(ByVal value As String)
         m_Idsettore = value
      End Set
   End Property
   Public Property IdPrestazione() As String
      Get
         Return m_Idprestazione
      End Get
      Set(ByVal value As String)
         m_Idprestazione = value
      End Set
   End Property




   Public Property IdVertenza() As String
      Get
         Return m_IdVertenza
      End Get
      Set(ByVal value As String)
         m_IdVertenza = value
      End Set
   End Property


   Public Property ImportoRistorno() As Double
      Get
         Return m_ImportoRistorno
      End Get
      Set(ByVal value As Double)
         m_ImportoRistorno = value
      End Set
   End Property
   Public Property PagamentoReferente() As String
      Get
         Return m_DocumentoRistorno
      End Get
      Set(ByVal value As String)
         m_DocumentoRistorno = value
      End Set
   End Property
   Public Property AziendaImpiego() As String
      Get
         Return m_AziendaImpiego
      End Get
      Set(ByVal value As String)
         m_AziendaImpiego = value
      End Set
   End Property

   Public Property IdAziendaImpiego() As String
      Get
         Return m_IdAziendaImpiego
      End Get
      Set(ByVal value As String)
         m_IdAziendaImpiego = value
      End Set
   End Property
   Public Property ContrattoApplicato() As String
      Get
         Return m_ContrattoApplicato
      End Get
      Set(ByVal value As String)
         m_ContrattoApplicato = value
      End Set
   End Property

   Public Property IdContrattoApplicato() As String
      Get
         Return m_IdContrattoApplicato
      End Get
      Set(ByVal value As String)
         m_IdContrattoApplicato = value
      End Set
   End Property


   Public Property LivelloInquadramento() As String
      Get
         Return m_LivelloInquadramento
      End Get
      Set(ByVal value As String)
         m_LivelloInquadramento = value
      End Set
   End Property
   Public Property OreLavorate() As Double
      Get
         Return m_OreLavorate
      End Get
      Set(ByVal value As Double)
         m_OreLavorate = value
      End Set
   End Property
   Public Property OreMalattia() As Double
      Get
         Return m_OreMalattia
      End Get
      Set(ByVal value As Double)
         m_OreMalattia = value
      End Set
   End Property
   Public Property Referente() As String
      Get
         Return m_Referente
      End Get
      Set(ByVal value As String)
         m_Referente = value
      End Set
   End Property

   Public Property IdReferente() As String
      Get
         Return m_IdReferente
      End Get
      Set(ByVal value As String)
         m_IdReferente = value
      End Set
   End Property
   Public Property Competenza() As AbstractPeriodo
      Get
         Return m_Competenza
      End Get
      Set(ByVal value As AbstractPeriodo)
         m_Competenza = value
      End Set
   End Property
   Public Property Tredicesima() As Boolean
      Get
         Return m_TredicesimaInclusa
      End Get
      Set(ByVal value As Boolean)
         m_TredicesimaInclusa = value
      End Set
   End Property
   Public Property Quattordicesima() As Boolean
      Get
         Return m_QuattordicesimaInclusa
      End Get
      Set(ByVal value As Boolean)
         m_QuattordicesimaInclusa = value
      End Set
   End Property
   Public Property Importo() As Double
      Get
         Return m_Importo
      End Get
      Set(ByVal value As Double)
         m_Importo = value
      End Set
   End Property
   Public Property DataRegistrazione() As DateTime
      Get
         Return m_dataRegistrazione
      End Get
      Set(ByVal value As DateTime)
         m_dataRegistrazione = value
      End Set
   End Property
   Public Property DataDocumento() As DateTime
      Get
         Return m_dataDocumento
      End Get
      Set(ByVal value As DateTime)
         m_dataDocumento = value
      End Set
   End Property
   Public Property Note() As String
      Get
         Return m_note
      End Get
      Set(ByVal value As String)
         m_note = value
      End Set
    End Property


    Private Function CalculateCoperto() As Double
        'se le note son vuote non trovo nulla da deserializzare
        'nelle note ci sarà per la sola provincia di salerno
        'una stringa riportatante cosperto e scoperto
        'string.Format("GNF_COPERTO: {0} #_# GNF_SCOPERTO: {1}", coperto, scoperto);
        If (String.IsNullOrEmpty(m_note)) Then
            Return 0
        End If
        'se non trovo i cancelletti allora ritorno 0
        If (m_note.IndexOf("#_#", 0) < 0) Then
            Return 0
        End If
        'se ci sono allora è una stringa contenete i dati di copertura e scopertura....
        Dim stringSeparators() As String = {"#_#"}
        Dim a As String() = m_note.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries)

        'se nn ci sono due elementi allora si tratta di qualcosaltro
        If (a.Length <> 2) Then
            Return 0
        End If

        'per calcolare il coperto devo verificare che la string alla posizione
        '0 deve incominciasre con "GNF_COPERTO: "
        'se inizia con tale valore allora posso convertire in un double
        If (Not a(0).StartsWith("GNF_COPERTO: ")) Then
            Return 0
        End If

        Dim c As String = a(0).Replace("GNF_COPERTO: ", "").Trim()

        Return TryConvertToDouble(c)

    End Function
    Private Function CalculateScoperto() As Double
        'se le note son vuote non trovo nulla da deserializzare
        'nelle note ci sarà per la sola provincia di salerno
        'una stringa riportatante cosperto e scoperto
        'string.Format("GNF_COPERTO: {0} #_# GNF_SCOPERTO: {1}", coperto, scoperto);
        If (String.IsNullOrEmpty(m_note)) Then
            Return 0
        End If
        'se non trovo i cancelletti allora ritorno 0
        If (m_note.IndexOf("#_#", 0) < 0) Then
            Return 0
        End If
        'se ci sono allora è una stringa contenete i dati di copertura e scopertura....
        Dim stringSeparators() As String = {"#_#"}
        Dim a As String() = m_note.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries)

        'se nn ci sono due elementi allora si tratta di qualcosaltro
        If (a.Length <> 2) Then
            Return 0
        End If

        'per calcolare il coperto devo verificare che la string alla posizione
        '0 deve incominciasre con "GNF_COPERTO: "
        'se inizia con tale valore allora posso convertire in un double
        If (Not a(1).StartsWith(" GNF_SCOPERTO: ")) Then
            Return 0
        End If

        Dim c As String = a(1).Replace(" GNF_SCOPERTO: ", "").Trim()

        Return TryConvertToDouble(c)

    End Function
    Private Function TryConvertToDouble(c As String) As Double
        Try
            Return Convert.ToDouble(c)
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public ReadOnly Property Coperto() As Double
        Get
            Return CalculateCoperto()
        End Get
    End Property
    Public ReadOnly Property Scoperto() As Double
        Get
            Return CalculateScoperto()
        End Get
    End Property



   Public Property TipoDocumento() As String
      Get
         Return m_TipoDocumento
      End Get
      Set(ByVal value As String)
         m_TipoDocumento = value
      End Set
   End Property
   'Public Property PercentualeRistornoDeleghe() As Double
   '   Get
   '      Return m_PercentualeRistornoDeleghe
   '   End Get
   '   Set(ByVal value As Double)
   '      m_PercentualeRistornoDeleghe = value
   '   End Set
   'End Property
   Public Property SedeOperativa() As String
      Get
         Return m_sedeoperativa
      End Get
      Set(ByVal value As String)
         m_sedeoperativa = value
      End Set
   End Property



End Class
