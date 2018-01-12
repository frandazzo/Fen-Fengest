Public Class ElectronicDocumentAzienda
   Inherits ElectronicDocument
   Protected m_Target As Azienda


   Public Property Target() As Azienda
      Get
         Return m_Target
      End Get
      Set(ByVal value As Azienda)
         m_Target = value
         m_DefaultPath = m_Target.DirectoryPreferenziale
      End Set
   End Property


   Protected Overrides Sub DoValidation()
      If m_TipoDocumento Is Nothing Then
         ValidationErrors.Add("Tipo documento nullo")
      End If

      If m_FileName Is Nothing Then
         ValidationErrors.Add("File non specifidato")
      End If

      If m_Target Is Nothing Then
         ValidationErrors.Add("Target nullo")
      End If
   End Sub
End Class
