Public Class ElectronicDocumentSegreteria
   Inherits ElectronicDocument
   Protected m_Target As Segreteria


   Public Property Target() As Segreteria
      Get
         Return m_Target
      End Get
      Set(ByVal value As Segreteria)
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
