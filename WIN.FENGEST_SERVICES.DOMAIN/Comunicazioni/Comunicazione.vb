Public Class Comunicazione
   Inherits AbstractPersistenceObject

   Private m_DataDocumento As DateTime
   Private m_Utente As Utente
   Private m_Allegato As String
   Private m_Causale As CausaleComunicazione
   Private m_Tipo As TipoComunicazione
   Private m_Note As String

    Public ReadOnly Property NomeUtente As String
        Get
            Return m_Utente.CompleteName
        End Get
    End Property
    Public ReadOnly Property NomeTipoComunicazione As String
        Get
            If m_Tipo Is Nothing Then
                Return ""
            End If
            Return m_Tipo.Descrizione
        End Get
    End Property
    Public ReadOnly Property NomeCausale As String
        Get
            If m_Causale Is Nothing Then
                Return ""
            End If
            Return m_Causale.Descrizione
        End Get
    End Property

   Protected Overrides Sub DoValidation()
      If m_Utente Is Nothing Then
         Me.ValidationErrors.Add("Utente nullo")
      End If
   End Sub

   Public Property Note() As String
      Get
         Return m_Note
      End Get
      Set(ByVal value As String)
         m_Note = value
      End Set
   End Property


   Public Property Tipo() As TipoComunicazione
      Get
         Return m_Tipo
      End Get
      Set(ByVal value As TipoComunicazione)
         m_Tipo = value
      End Set
   End Property


   Public Property Causale() As CausaleComunicazione
      Get
         Return m_Causale
      End Get
      Set(ByVal value As CausaleComunicazione)
         m_Causale = value
      End Set
   End Property

   Public Property Allegato() As String
      Get
         Return m_Allegato
      End Get
      Set(ByVal value As String)
         m_Allegato = value
      End Set
   End Property

   Public Property Utente() As Utente
      Get
         Return m_Utente
      End Get
      Set(ByVal value As Utente)
         m_Utente = value
      End Set
   End Property
   'Public Function CostruisciNomeAllegato(ByVal NomeModello As String) As String
   '   Dim outputFile As String = ""
   '   Dim i As Int32 = 1
   '   If m_Utente Is Nothing Then
   '      Throw New InvalidOperationException("Utente non specificato")
   '   End If
   '   If Not My.Computer.FileSystem.FileExists(NomeModello) Then
   '      Throw New ArgumentException("Nome modello")
   '   End If

   '   Dim ext As String = CalculateExtension(NomeModello)
   '   Dim name As String = IO.Path.GetFileNameWithoutExtension(NomeModello)

   '   name = m_Utente.CompleteName & "-" & name & ext

   '   Dim path As String
   '   If My.Computer.FileSystem.DirectoryExists(m_Utente.DirectoryPreferenziale) Then
   '      path = m_Utente.DirectoryPreferenziale
   '   Else
   '      path = m_Utente.Segreteria.DirectoryPreferenzialeUtenti
   '   End If
   '   outputFile = My.Computer.FileSystem.CombinePath(path, name)
   '   Do While My.Computer.FileSystem.FileExists(outputFile)
   '      Dim temp As String = i.ToString & "-" & name
   '      outputFile = My.Computer.FileSystem.CombinePath(path, temp)
   '      i = i + 1
   '      temp = ""
   '   Loop
   '   Return outputFile
   'End Function

   'Private Function CalculateExtension(ByVal nomeFile As String) As String
   '   Dim ext As String = ""
   '   If My.Computer.FileSystem.GetFileInfo(nomeFile).Extension = ".dot" Then
   '      ext = ".doc"
   '   End If
   '   If My.Computer.FileSystem.GetFileInfo(nomeFile).Extension = ".dotx" Then
   '      ext = ".docx"
   '   End If
   '   Return ext
   'End Function

   Public Property DataDocumento() As DateTime
      Get
         Return m_DataDocumento
      End Get
      Set(ByVal value As DateTime)
         m_DataDocumento = value
      End Set
   End Property

End Class
