Public Class SecurityDBSortingServices
   Implements ISortStrategy


   Public Function SortList(ByVal ListToSort As Object) As System.Collections.ArrayList Implements TECHNICAL.PERSISTENCE.ISortStrategy.SortList
      Dim list As IList = DirectCast(ListToSort, ArrayList)
      Dim result As IList = New ArrayList

      Dim profiliDirty As New ArrayList
      Dim profiliDeleted As New ArrayList
      Dim profiliNew As New ArrayList


      Dim rpDirty As New ArrayList
      Dim rpDeleted As New ArrayList
      Dim rpNew As New ArrayList

      Dim permessiDirty As New ArrayList
      Dim permessiDeleted As New ArrayList
      Dim permessiNew As New ArrayList


      Dim ruoliDirty As New ArrayList
      Dim ruoliDeleted As New ArrayList
      Dim ruoliNew As New ArrayList


      Dim utentiDirty As New ArrayList
      Dim utentiDeleted As New ArrayList
      Dim utentiNew As New ArrayList



      For Each elem As Object In list

         If elem.GetObjectType.Name = "Role" And TypeOf (elem) Is DBInsertCommand Then
            ruoliNew.Add(elem)
         End If

         If elem.GetObjectType.Name = "Role" And TypeOf (elem) Is DBUpdateCommand Then
            ruoliDirty.Add(elem)
         End If

         If elem.GetObjectType.Name = "Role" And TypeOf (elem) Is DBDeleteCommand Then
            ruoliDeleted.Add(elem)
         End If


         If elem.GetObjectType.Name = "User" And TypeOf (elem) Is DBInsertCommand Then
            utentiNew.Add(elem)
         End If

         If elem.GetObjectType.Name = "User" And TypeOf (elem) Is DBUpdateCommand Then
            utentiDirty.Add(elem)
         End If

         If elem.GetObjectType.Name = "User" And TypeOf (elem) Is DBDeleteCommand Then
            utentiDeleted.Add(elem)
         End If


         If elem.GetObjectType.Name = "RoleProfile" And TypeOf (elem) Is DBInsertCommand Then
            rpNew.Add(elem)
         End If



         If elem.GetObjectType.Name = "RoleProfile" And TypeOf (elem) Is DBDeleteCommand Then
            rpDeleted.Add(elem)
         End If




         If elem.GetObjectType.Name = "Profile" And TypeOf (elem) Is DBInsertCommand Then
            profiliNew.Add(elem)
         End If

         If elem.GetObjectType.Name = "Profile" And TypeOf (elem) Is DBUpdateCommand Then
            profiliDirty.Add(elem)
         End If

         If elem.GetObjectType.Name = "Profile" And TypeOf (elem) Is DBDeleteCommand Then
            profiliDeleted.Add(elem)
         End If



         If elem.GetObjectType.Name = "Permission" And TypeOf (elem) Is DBInsertCommand Then
            permessiNew.Add(elem)
         End If

         If elem.GetObjectType.Name = "Permission" And TypeOf (elem) Is DBUpdateCommand Then
            permessiDirty.Add(elem)
         End If

         If elem.GetObjectType.Name = "Permission" And TypeOf (elem) Is DBDeleteCommand Then
            permessiDeleted.Add(elem)
         End If

      Next


      '******************************
      For Each elem As AbstractDbCommand In ruoliNew
         result.Add(elem)
      Next

      For Each elem As AbstractDbCommand In utentiNew
         result.Add(elem)
      Next

      For Each elem As AbstractDbCommand In rpNew
         result.Add(elem)
      Next

      For Each elem As AbstractDbCommand In profiliNew
         result.Add(elem)
      Next

      For Each elem As AbstractDbCommand In permessiNew
         result.Add(elem)
      Next

      '******************************
      For Each elem As AbstractDbCommand In ruoliDirty
         result.Add(elem)
      Next

      For Each elem As AbstractDbCommand In utentiDirty
         result.Add(elem)
      Next



      For Each elem As AbstractDbCommand In profiliDirty
         result.Add(elem)
      Next

      For Each elem As AbstractDbCommand In permessiDirty
         result.Add(elem)
      Next



      '******************************
      For Each elem As AbstractDbCommand In ruoliDeleted
         result.Add(elem)
      Next


      For Each elem As AbstractDbCommand In utentiDeleted
         result.Add(elem)
      Next

      For Each elem As AbstractDbCommand In rpDeleted
         result.Add(elem)
      Next

      For Each elem As AbstractDbCommand In profiliDeleted
         result.Add(elem)
      Next

      For Each elem As AbstractDbCommand In permessiDeleted
         result.Add(elem)
      Next





      Return result
   End Function
End Class
