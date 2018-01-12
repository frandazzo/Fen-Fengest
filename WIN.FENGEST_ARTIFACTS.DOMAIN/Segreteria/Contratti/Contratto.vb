Public Class Contratto
   Inherits AbstractPersistenceObject
   Private m_settore As Settore = New SettoreNullo
   Private m_TipoContratto As TipoContratto = New TipoContrattoNullo
   Public Sub New()
      MyBase.Key = New Key(-1, -1)
   End Sub
   Public Sub New(ByVal Settore As Settore, ByVal TipoContratto As TipoContratto)
      MyBase.Key = New Key(-1, -1)
      If Settore Is Nothing Then Throw New Exception("Impossibile creare il contratto. Settore nullo")
      If Settore.Descrizione = "" Then Throw New Exception("Impossibile creare il contratto. Tipo settore nullo")
      If TipoContratto Is Nothing Then Throw New Exception("Impossibile creare il contratto. Tipo contratto nullo")
      If TipoContratto.Descrizione = "" Then Throw New Exception("Impossibile creare il contratto. Tipo oggetto contratto nullo")
      m_settore = Settore
      m_TipoContratto = TipoContratto
      MyBase.Descrizione = TipoContratto.Descrizione
   End Sub
   Public Overrides Function ToString() As String
      Return Me.Descrizione
   End Function

   Public ReadOnly Property TipoContratto() As TipoContratto
      Get
         Return m_TipoContratto
      End Get
   End Property
   Public ReadOnly Property Settore() As Settore
      Get
         Return m_settore
      End Get
   End Property
End Class
