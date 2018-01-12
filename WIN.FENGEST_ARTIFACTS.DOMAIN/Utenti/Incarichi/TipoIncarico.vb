Public Class TipoIncarico
    Inherits AbstractPersistenceObject



    Protected Overrides Sub DoValidation()

        If String.IsNullOrEmpty(Me.Descrizione) Then
            ValidationErrors.Add("Descrizione non specificata")
        End If

      

    End Sub

End Class
