Public Class TipoContratto
   Inherits AbstractPersistenceObject
   Protected m_SettoreSpecifico As Settore = New SettoreNullo
   Protected m_Validita_Economica As DataRange
   Protected m_Validita_Normativa As DataRange


   Public Property ValiditaEconomica() As DataRange
      Get
         Return m_Validita_Economica
      End Get
      Set(ByVal value As DataRange)
         m_Validita_Economica = value
      End Set
   End Property


   Public Property ValiditaNormativa() As DataRange
      Get
         Return m_Validita_Normativa
      End Get
      Set(ByVal value As DataRange)
         m_Validita_Normativa = value
      End Set
   End Property




   Public Sub New()
   End Sub
   Public Sub New(ByVal Descrizione As String, ByVal SettoreSpecifico As Settore)
      If Descrizione = "" Then Throw New Exception("Impossibile creare un oggetto contratto. Descrizione vuota.")
      If SettoreSpecifico Is Nothing Then Throw New Exception("Impossibile creare un tipo contratto. Settore nullo")
      If SettoreSpecifico.Id = -1 Then Throw New Exception("Impossibile creare un tipo contratto. Tipo settore nullo")
      MyBase.Descrizione = UCase(Descrizione)
      m_SettoreSpecifico = SettoreSpecifico
      m_Validita_Economica = New DataRange(DateTime.Now, DateTime.Now.AddYears(1))
      m_Validita_Normativa = New DataRange(DateTime.Now, DateTime.Now.AddYears(1))
   End Sub
   Public Property SettoreSpecifico() As Settore
      Get
         Return m_SettoreSpecifico
      End Get
      Set(ByVal value As Settore)
         If value Is Nothing Then Throw New Exception("Impossibile impostare un tipo contratto. Settore nullo")
         If value.Id = -1 Then Throw New Exception("Impossibile impostare un tipo contratto. Tipo settore nullo")
         m_SettoreSpecifico = value
      End Set
   End Property
   Public Overrides Function ToString() As String
      Return Me.Descrizione
   End Function



   Protected Overrides Sub DoValidation()
      If m_Validita_Economica.IsEmpty Then
         ValidationErrors.Add("Validità economica non corretta")
      End If
      If m_Validita_Normativa.IsEmpty Then
         ValidationErrors.Add("Validità normativa non corretta")
      End If
   End Sub


End Class

