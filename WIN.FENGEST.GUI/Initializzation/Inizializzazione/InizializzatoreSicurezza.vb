Public Class InizializzatoreSicurezza


    Public Sub Inizilaizza()
        SecurityManager.Instance.AddAssembly(GetType(Applicazione).Assembly)
        SecurityManager.Instance.AddAssembly(GetType(MDIForm).Assembly)
        SecurityManager.Instance.AddAssembly(GetType(AbstractController).Assembly)
        SecurityManager.Instance.SecureDataAccess = New WIN.APPLICATION.SecureDataManager

    End Sub
End Class
