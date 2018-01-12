Public Class TipoPratica
    Inherits AbstractPersistenceObject
    Implements IComparable



    Private m_JollyUser As User
    Private m_restrictedPerimissions As Boolean
    Private m_ControlUser As User
    Private m_IntegrationUser As User
    Private m_DocumentationVerifiedUser As User
    Private m_ClosedPracticeuser As User
    Private m_RejectedPracticeUser As User

    Public Property RejectedPractice() As User
        Get
            Return m_RejectedPracticeUser
        End Get
        Set(ByVal value As User)
            m_RejectedPracticeUser = value
        End Set
    End Property



    Public Property ClosedPracticeuser() As User
        Get
            Return m_ClosedPracticeuser
        End Get
        Set(ByVal value As User)
            m_ClosedPracticeuser = value
        End Set
    End Property


    Public Overrides Function ToString() As String
        Return Me.Descrizione
    End Function


    Public Property DocumentationVerifiedUser() As User
        Get
            Return m_DocumentationVerifiedUser
        End Get
        Set(ByVal value As User)
            m_DocumentationVerifiedUser = value
        End Set
    End Property

    Public Property IntegrationUser() As User
        Get
            Return m_IntegrationUser
        End Get
        Set(ByVal value As User)
            m_IntegrationUser = value
        End Set
    End Property



    Public Property ControlUser() As User
        Get
            Return m_ControlUser
        End Get
        Set(ByVal value As User)
            m_ControlUser = value
        End Set
    End Property




    Public Property RestrictedPermissions() As Boolean
        Get
            Return m_restrictedPerimissions
        End Get
        Set(ByVal value As Boolean)
            m_restrictedPerimissions = value
        End Set
    End Property


    Protected Overrides Sub DoValidation()
        If String.IsNullOrEmpty(Me.Descrizione) Then
            ValidationErrors.Add("Descizione tipo pratica nulla")
        End If
    End Sub


    Public Property JollyUser() As User
        Get
            Return m_JollyUser
        End Get
        Set(ByVal value As User)
            m_JollyUser = value
        End Set
    End Property


    Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
        Return Me.Descrizione.CompareTo(DirectCast(obj, TipoPratica).Descrizione)
    End Function
End Class
