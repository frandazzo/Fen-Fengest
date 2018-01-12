Public Interface IDomainObjectExistenceChecker
   ReadOnly Property GetId() As Int32
   Function Exist(ByVal Parameters As Hashtable) As Boolean
End Interface
