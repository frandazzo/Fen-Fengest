Imports WIN.FENGEST_NAZIONALE.INTEGRATION_ENTITIES
Imports System.Text
Imports System.Text.RegularExpressions

Public Class ExportHeader
    Private _respoonsible As String = ""
    Private _sector As String = ""
    Private _entity As String = ""
    Private _mail As String = ""
    Private _year As Int32 = 2010
    Private _period As Int32 = 1
    Private _userName As String = ""
    Private _password As String = ""
    Private _province As String = ""
    Private _struttura As String = ""
    Public Sub New(ByVal resp As String, ByVal settore As String, ByVal ente As String, ByVal mail As String, ByVal anno As Int32, ByVal periodo As Int32, ByVal user As String, ByVal pass As String, ByVal province As String)
        _respoonsible = resp
        _sector = settore
        _entity = ente
        _mail = mail
        _year = anno
        _period = periodo
        _userName = user
        _password = pass
        _province = province

    End Sub


    Public Function CalculatePeriod() As SubscriptionPeriod
        If String.IsNullOrEmpty(_sector) Then
            Throw New Exception("Impossibile calcolare il periodo di iscrizione. Settore nullo")
        End If

        Dim p As SubscriptionPeriod

        If _sector = "EDILE" Then
            p = New SubscriptionPeriod(_period, _year, PeriodType.Semester)
        Else
            p = New SubscriptionPeriod(_year)
        End If

        Return p

    End Function


    Public Sub CheckValidity()
        Dim s As StringBuilder = New StringBuilder()

        If String.IsNullOrEmpty(_respoonsible) Then
            s.AppendLine("Responsabile esportazione non specificato")
        End If


        If String.IsNullOrEmpty(_province) Then
            s.AppendLine("Provincia non specificata")
        End If




        If (String.IsNullOrEmpty(_sector)) Then
            s.AppendLine("Settore non specificato")
        End If



        If (Not String.IsNullOrEmpty(_sector)) Then
            If (_sector = "EDILE") Then

                If (String.IsNullOrEmpty(_entity)) Then
                    s.AppendLine("Ente bilaterale per il settore edile non specificato")
                End If
                '        ;

                If (_period <> 1 And _period <> 2) Then
                    s.AppendLine("Semestre non corretto per il settore edile")
                End If
                '        ;

            End If

        End If

        If ((_year < 1980) And (_year > 2050)) Then
            s.AppendLine("Anno specificato non corretto")
        End If





        If (_mail = Nothing) Then
            _mail = ""
        End If


        If (Not String.IsNullOrEmpty(_mail)) Then
            'Mail regular exp pattern:\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*
            Dim MatchEmailPattern As String = "\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
            If (Not Regex.IsMatch(_mail, MatchEmailPattern)) Then
                s.AppendLine("Mail non valida")
            End If
        End If






        Dim ex As String = s.ToString()

        If (Not String.IsNullOrEmpty(ex)) Then
            Throw New Exception(ex)
        End If

    End Sub




    Public ReadOnly Property Anno() As Int32
        Get
            Return _year
        End Get
    End Property

    Public ReadOnly Property Periodo() As Int32
        Get
            Return _period
        End Get
    End Property



    Public ReadOnly Property Mail() As String
        Get
            Return _mail
        End Get
    End Property

    Public ReadOnly Property Province() As String
        Get
            Return _province
        End Get
    End Property


    Public ReadOnly Property Password() As String
        Get
            Return _password
        End Get
    End Property

    Public ReadOnly Property Username() As String
        Get
            Return _userName
        End Get
    End Property


    Public ReadOnly Property Entity() As String
        Get
            Return _entity
        End Get
    End Property


    Public ReadOnly Property Sector() As String
        Get
            Return _sector
        End Get
    End Property


    Public ReadOnly Property Responsible() As String
        Get
            Return _respoonsible
        End Get
    End Property



End Class
