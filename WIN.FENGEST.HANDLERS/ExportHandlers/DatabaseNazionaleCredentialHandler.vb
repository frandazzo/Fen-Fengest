Public Class DatabaseNazionaleCredentialHandler


    Public Shared Function RetrieveCredential() As Credenziali

        Dim c As New Credenziali


        Dim controller As New ControllerSegreteria


        controller.LoadById("1")

        c.Provincia = controller.ProvinciaLegale
        c.UserName = controller.Current.UtenteNazionale
        c.Password = controller.Current.PasswordNazionale


        Return c


    End Function
End Class
