Public Class VertenzaDTO
   Inherits AbstractPersistenceObject


   Private m_Utente As String = ""
   Private m_IdUtente As String = ""


   Private m_Referente As String = ""
   Private m_IdReferente As String = ""

   Private m_Responsabile As String = ""
   Private m_IdResponsabile As String = ""

   Private m_Azienda As String = ""
   Private m_IdAzienda As String = ""

   Private m_IdAvvocato As String = ""
   Private m_Avvocato As String = ""

   Private m_PeriodoVertenza As String = ""

   Private m_dataRegistrazione As DateTime
   Private m_dataDocumento As DateTime
    Private m_note As String = ""



    Private m_VertenzaChiusa As Boolean = False

    Public Property VertenzaChiusa() As Boolean
        Get
            Return m_VertenzaChiusa
        End Get
        Set(ByVal value As Boolean)
            m_VertenzaChiusa = value
        End Set
    End Property

   Public Property Avvocato() As String
      Get
         Return m_Avvocato
      End Get
      Set(ByVal value As String)
         m_Avvocato = value
      End Set
   End Property


   Public Property IdAvvocato() As String
      Get
         Return m_IdAvvocato
      End Get
      Set(ByVal value As String)
         m_IdAvvocato = value
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

   Public Property PeriodoVertenza() As String
      Get
         Return m_PeriodoVertenza
      End Get
      Set(ByVal value As String)
         m_PeriodoVertenza = value
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



   Public Property DataRegistrazione() As DateTime
      Get
         Return m_dataRegistrazione
      End Get
      Set(ByVal value As DateTime)
         m_dataRegistrazione = value
      End Set
   End Property

   Public Property IdAzienda() As String
      Get
         Return m_IdAzienda
      End Get
      Set(ByVal value As String)
         m_IdAzienda = value
      End Set
   End Property

   Public Property Azienda() As String
      Get
         Return m_Azienda
      End Get
      Set(ByVal value As String)
         m_Azienda = value
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


   Public Property Responsabile() As String
      Get
         Return m_Responsabile
      End Get
      Set(ByVal value As String)
         m_Responsabile = value
      End Set
   End Property

   Public Property IdResponsabile() As String
      Get
         Return m_IdResponsabile
      End Get
      Set(ByVal value As String)
         m_IdResponsabile = value
      End Set
   End Property

End Class
