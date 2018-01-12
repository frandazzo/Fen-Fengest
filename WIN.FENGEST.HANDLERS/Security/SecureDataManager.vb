Imports WIN.SECURITY
Imports WIN.SECURITY.Core

Public Class SecureDataManager
    Implements ISecureDataAccess


    Dim ps As IPersistenceFacade

    Public Sub New()
        ps = DataAccessServices.Instance.PersistenceFacade
    End Sub


    Public Function GetUserById(id As Int32) As IUser

        Return ps.GetObject("User", id.ToString)

    End Function

    Public Function GetUser(ByVal username As String, ByVal password As String) As IUser Implements SECURITY.ISecureDataAccess.GetUser
        Dim query As Query = ps.CreateNewQuery("MapperUser")
        Dim mainCriteria As CompositeCriteria = New CompositeCriteria(AbstractBoolCriteria.Operatore.AndOp)


        mainCriteria.AddCriteria(Criteria.Equal("Username", "'" & username & "'"))

        mainCriteria.AddCriteria(Criteria.Equal("Password", "'" & password & "'"))



        query.AddWhereClause(mainCriteria)


        Dim list As IList = query.Execute(ps)
        If list.Count = 0 Then Return Nothing
        Return list.Item(0)

    End Function

    Public Function GetUsers() As System.Collections.Generic.IList(Of IUser) Implements SECURITY.ISecureDataAccess.GetUsers
        Dim list As IList = ps.GetAllObjects("User")

        Dim list1 As IList(Of IUser) = New List(Of IUser)
        For Each elem As IUser In list
            list1.Add(elem)
        Next
        Return list1
    End Function


    Public Function GetUsersList() As System.Collections.Generic.IList(Of IdDescriptionClass)
        Dim list As IList = ps.GetAllObjects("User")

        Dim list1 As IList(Of IdDescriptionClass) = New List(Of IdDescriptionClass)
        For Each elem As IUser In list
            Dim c As New IdDescriptionClass
            c.Id = elem.ID
            If DirectCast(elem, WIN.BASEREUSE.User).Name = "" Then
                'si tratta di admin
                c.Description = "Admin"
            Else
                c.Description = String.Format("{0} {1}", DirectCast(elem, WIN.BASEREUSE.User).Name, DirectCast(elem, WIN.BASEREUSE.User).SurName)

            End If

            list1.Add(c)
        Next
        Return list1
    End Function

    'Public Function GetProfiles() As System.Collections.Generic.IList(Of IProfile)
    '   Dim list As IList = ps.GetAllObjects("Profile")

    '   Dim list1 As IList(Of IProfile) = New List(Of IProfile)
    '   For Each elem As IProfile In list
    '      list1.Add(elem)
    '   Next
    '   Return list1
    'End Function


    Public Sub BeginTransaction()
        ps.BeginTransaction(New SecurityDBSortingServices)
    End Sub

    Public Sub MarkNew(ByVal obj As Object)
        ps.MarkNew(obj)
    End Sub

    Public Sub MarkDirty(ByVal obj As Object)
        ps.MarkDirty(obj)
    End Sub

    Public Sub MarkDelete(ByVal obj As Object)
        ps.MarkRemoved(obj)
    End Sub

    Public Sub CommitTransaction()
        Try
            ps.CommitTransaction()
        Catch ex As Exception
            ps.RollBackTRansaction()
            Throw
        End Try
    End Sub

    Public Sub DeleteProfile(ByVal profile As SECURITY.Core.IProfile) Implements SECURITY.ISecureDataAccess.DeleteProfile

    End Sub

    Public Sub DeleteRole(ByVal role As SECURITY.Core.IRole) Implements SECURITY.ISecureDataAccess.DeleteRole

    End Sub

    Public Function GetProfiles() As System.Collections.Generic.IList(Of SECURITY.Core.IProfile) Implements SECURITY.ISecureDataAccess.GetProfiles
        Dim list As IList = ps.GetAllObjects("Profile")

        Dim list1 As IList(Of IProfile) = New List(Of IProfile)
        For Each elem As IProfile In list
            list1.Add(elem)
        Next
        Return list1
    End Function



    Public Sub Save(ByVal profile As SECURITY.Core.IProfile) Implements SECURITY.ISecureDataAccess.Save

    End Sub

    Public Sub Save(ByVal user As SECURITY.Core.IUser) Implements SECURITY.ISecureDataAccess.Save

    End Sub

    Public Sub SaveRole(ByVal role As SECURITY.Core.IRole) Implements SECURITY.ISecureDataAccess.SaveRole

    End Sub

    Public Function GetRoles() As System.Collections.Generic.IList(Of SECURITY.Core.IRole) Implements SECURITY.ISecureDataAccess.GetRoles
        Dim list As IList = ps.GetAllObjects("Role")

        Dim list1 As IList(Of IRole) = New List(Of IRole)
        For Each elem As IRole In list
            list1.Add(elem)
        Next
        Return list1
    End Function


    Public Function GetNormalizedRoles() As System.Collections.Generic.IList(Of WIN.BASEREUSE.Role)
        Dim list As IList(Of WIN.BASEREUSE.Role) = New List(Of WIN.BASEREUSE.Role)

        'Try
        For Each elem As IRole In GetRoles()
            list.Add(DirectCast(elem, WIN.BASEREUSE.Role))
        Next
        Return list
        'Catch ex As Exception
        '   Return Nothing
        'End Try

    End Function

End Class
