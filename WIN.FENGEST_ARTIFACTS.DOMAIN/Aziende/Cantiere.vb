Public Class Cantiere
    Inherits AbstractPersistenceObject

    Private m_botes As String
    Private m_dataFine As DateTime
    Private m_idazienda As Int32
    Private m_nomeAzienda As String

    Private m_zona As String
    Private m_Provincia As String
    Private m_comune As String
    Private m_importo As Double

    Public Property Importo() As Double
        Get
            Return m_importo
        End Get
        Set(ByVal value As Double)
            m_importo = value
        End Set
    End Property

    Public Property Comune() As String
        Get
            Return m_comune
        End Get
        Set(ByVal value As String)
            m_comune = value
        End Set
    End Property

    Public Property Provincia() As String
        Get
            Return m_Provincia
        End Get
        Set(ByVal value As String)
            m_Provincia = value
        End Set
    End Property

    Public Property Zona() As String
        Get
            Return m_zona
        End Get
        Set(ByVal value As String)
            m_zona = value
        End Set
    End Property



    Public Property NomeAzienda() As String
        Get
            Return m_nomeAzienda
        End Get
        Set(ByVal value As String)
            m_nomeAzienda = value
        End Set
    End Property


    Public Property IdAzienda() As Int32
        Get
            Return m_idazienda
        End Get
        Set(ByVal value As Int32)
            m_idazienda = value
        End Set
    End Property


    Public Property DataFine() As DateTime
        Get
            Return m_dataFine
        End Get
        Set(ByVal value As DateTime)
            m_dataFine = value
        End Set
    End Property

    Public Property Notes() As String
        Get
            Return m_botes
        End Get
        Set(ByVal value As String)
            m_botes = value
        End Set
    End Property



    Public Overrides Function ToString() As String
        Return Me.Descrizione
    End Function

End Class
