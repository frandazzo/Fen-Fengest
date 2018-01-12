Public Class Avvocato
   Inherits AbstractAzienda
  
   Protected m_PartitaIva As String = ""


   Public Property PartitaIva() As String
      Get
         Return m_PartitaIva
      End Get
      Set(ByVal value As String)
         m_PartitaIva = value
      End Set
   End Property



   Protected Overrides Sub DoValidation()
      If MyBase.Descrizione = "" Then
         ValidationErrors.Add("Impossibile registrare i dati dell'avvocato con una ragione sociale nulla")
      End If
     
   End Sub

End Class
