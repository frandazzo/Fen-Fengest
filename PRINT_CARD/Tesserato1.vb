Public Class Tesserato1
    Inherits PRINT_CARD_CORE_VB.Tesserato


    'Private m_Cognome As String
    'Private m_Nome As String
    'Private m_Azienda As String
    'Private m_StampataDa As String


    'Private m_IdUtente As Int32


    'Public Sub New()
    '    m_ProvinciaSindacale = Module1.federProv
    'End Sub

    'Public Property IdUtente() As Int32
    '    Get
    '        Return m_IdUtente
    '    End Get
    '    Set(ByVal value As Int32)
    '        m_IdUtente = value
    '    End Set
    'End Property

    'Public Property StampataDa() As String
    '    Get
    '        Return m_StampataDa
    '    End Get
    '    Set(ByVal value As String)
    '        m_StampataDa = value
    '    End Set
    'End Property






    'Private m_indice As Int32
    'Public Property Indice() As Int32
    '    Get
    '        Return m_indice
    '    End Get
    '    Set(ByVal value As Int32)
    '        m_indice = value
    '    End Set
    'End Property

    'Public Property SettoreTessera() As String
    '    Get
    '        Return settore
    '    End Get
    '    Set(ByVal value As String)
    '        settore = value
    '    End Set
    'End Property


    'Public Property Nome() As String
    '    Get
    '        Return m_Nome
    '    End Get
    '    Set(ByVal value As String)
    '        m_Nome = value
    '    End Set
    'End Property
    'Public Property Cognome() As String
    '    Get
    '        Return m_Cognome
    '    End Get
    '    Set(ByVal value As String)
    '        m_Cognome = value
    '    End Set
    'End Property
    'Public Property Azienda() As String
    '    Get
    '        If settore.StartsWith("EDIL") Then
    '            If federProv = "BOLZANO" Then
    '                Return "CE/BK PROV. BZ"
    '            End If
    '        End If


    '        Return m_Azienda
    '    End Get
    '    Set(ByVal value As String)
    '        m_Azienda = value
    '    End Set
    'End Property




    'Private m_ProvinciaSindacale As String
    'Public Property ProvinciaSindacale() As String
    '    Get
    '        Return m_ProvinciaSindacale
    '    End Get
    '    Set(ByVal value As String)
    '        m_ProvinciaSindacale = value
    '    End Set
    'End Property



    'Private m_Provincia As String = ""
    'Private m_comune As String = ""
    'Private m_via As String = ""
    'Private m_cap As String = ""

    'Private m_AziendaOld As String = ""

    'Public Property AziendaOld() As String
    '    Get
    '        Return m_AziendaOld
    '    End Get
    '    Set(ByVal value As String)
    '        m_AziendaOld = value
    '    End Set
    'End Property



    'Public Property Cap() As String
    '    Get
    '        Return m_cap
    '    End Get
    '    Set(ByVal value As String)
    '        m_cap = value
    '    End Set
    'End Property


    'Public Property Via() As String
    '    Get
    '        If m_via IsNot Nothing Then
    '            Return m_via
    '        End If
    '        Return ""
    '    End Get
    '    Set(ByVal value As String)
    '        m_via = value
    '    End Set
    'End Property


    'Public Property Comune() As String
    '    Get
    '        If m_comune IsNot Nothing Then
    '            Return m_comune.ToUpper
    '        End If
    '        Return ""
    '    End Get
    '    Set(ByVal value As String)
    '        m_comune = value
    '    End Set
    'End Property





    'Public Property Provincia() As String
    '    Get
    '        Return m_Provincia
    '    End Get
    '    Set(ByVal value As String)
    '        m_Provincia = value
    '    End Set
    'End Property



    'Shared Function GetComparerByFirma() As IComparer
    '    Return New ComparerByFirma
    'End Function
    'Shared Function GetComparerByName() As IComparer
    '    Return New ComparerByName
    'End Function
    'Shared Function GetComparerBySurame() As IComparer
    '    Return New ComparerBySurname
    'End Function

    'Shared Function GetComparerByComune() As IComparer
    '    Return New ComparerByComune
    'End Function

    'Class ComparerByName
    '    Implements IComparer
    '    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare
    '        If x Is Nothing And y Is Nothing Then Return 0
    '        If x Is Nothing Then Return 1
    '        If y Is Nothing Then Return -1
    '        Dim t1 As Tesserato = DirectCast(x, Tesserato)
    '        Dim t2 As Tesserato = DirectCast(y, Tesserato)
    '        Return StrComp(t1.Nome, t2.Nome, CompareMethod.Text)
    '    End Function
    'End Class
    'Class ComparerByComune
    '    Implements IComparer
    '    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare
    '        If x Is Nothing And y Is Nothing Then Return 0
    '        If x Is Nothing Then Return 1
    '        If y Is Nothing Then Return -1
    '        Dim t1 As Tesserato = DirectCast(x, Tesserato)
    '        Dim t2 As Tesserato = DirectCast(y, Tesserato)
    '        Return StrComp(t1.Comune, t2.Comune, CompareMethod.Text)
    '    End Function
    'End Class
    'Class ComparerBySurname
    '    Implements IComparer

    '    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare
    '        If x Is Nothing And y Is Nothing Then Return 0
    '        If x Is Nothing Then Return 1
    '        If y Is Nothing Then Return -1
    '        Dim t1 As Tesserato = DirectCast(x, Tesserato)
    '        Dim t2 As Tesserato = DirectCast(y, Tesserato)
    '        Return StrComp(t1.Cognome, t2.Cognome, CompareMethod.Text)
    '    End Function
    'End Class
    'Class ComparerByFirma
    '    Implements IComparer

    '    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare
    '        If x Is Nothing And y Is Nothing Then Return 0
    '        If x Is Nothing Then Return 1
    '        If y Is Nothing Then Return -1
    '        Dim t1 As Tesserato = DirectCast(x, Tesserato)
    '        Dim t2 As Tesserato = DirectCast(y, Tesserato)
    '        Return StrComp(t1.Azienda, t2.Azienda, CompareMethod.Text)
    '    End Function
    'End Class
End Class
