Public Class PersistenceInfo




   Public Shared ReadOnly Property CustomPersistentServiceAssembly() As String
      Get
            Return DataAccessServices.Instance.CustomPersistentServiceAssembly
      End Get
   End Property

   Public Shared ReadOnly Property MaxCacheSize() As String
      Get
            Return DataAccessServices.Instance.MaxCacheSize
      End Get
   End Property

   Public Shared ReadOnly Property ServiceName() As String
      Get
            Return DataAccessServices.Instance.ServiceName
      End Get
   End Property


   Public Shared ReadOnly Property ConnectionStringParameters() As String()
      Get
            Return Split(DataAccessServices.Instance.ConnectionString, ";")
      End Get
   End Property

   Public Shared ReadOnly Property ConnectionString() As String
      Get
            Return DataAccessServices.Instance.ConnectionString
      End Get
   End Property

End Class
