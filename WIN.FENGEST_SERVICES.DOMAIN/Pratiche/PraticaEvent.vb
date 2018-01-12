Public Class PraticaEvent
    Inherits AbstractPersistenceObject


    Private m_State As IPracticeState
    Private m_Notes As String
    Private m_Data As DateTime
    Private m_Operator As User

    Public ReadOnly Property NomeOperatore As String
        Get
            If m_Operator.Username = "Admin" Then
                Return "Admin"
            End If
            Return m_Operator.Name + " " + m_Operator.SurName
        End Get
    End Property
    Public ReadOnly Property StateName As String
        Get
            Return m_State.StateName
        End Get
    End Property

    Public Property Operatore() As User
        Get
            Return m_Operator
        End Get
        Set(ByVal value As User)
            m_Operator = value
        End Set
    End Property

    Public Property Data() As DateTime
        Get
            Return m_Data
        End Get
        Set(ByVal value As DateTime)
            m_Data = value
        End Set
    End Property



    Public Property Notes() As String
        Get
            Return m_Notes
        End Get
        Set(ByVal value As String)
            m_Notes = value
        End Set
    End Property


    Public Property State() As IPracticeState
        Get
            Return m_State
        End Get
        Set(ByVal value As IPracticeState)
            m_State = value
        End Set
    End Property

    Protected Overloads Sub DoValidation()

        If m_State Is Nothing Then
            Me.m_ValidationErrors.Add("Stato non specificato")
        End If

        If m_Operator Is Nothing Then
            Me.m_ValidationErrors.Add("Operatore non specificato")
        End If

    End Sub


End Class
