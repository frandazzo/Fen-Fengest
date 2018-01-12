Namespace ADMINISTRATION
   Public Class ControllerTipoPrestazione
      Inherits AbstractController

      Private Function Current() As TipoPrestazione
         Return DirectCast(m_current, TipoPrestazione)
      End Function

#Region "Proprietà oggetto"

      Public ReadOnly Property IdTipoPrestazione() As String
         Get
            Return Current.Id
         End Get
      End Property
      Public Property CodicePrestazione() As String
         Get
            Return Current.CodicePrestazione
         End Get
         Set(ByVal value As String)
            Current.CodicePrestazione = value
         End Set
      End Property
      Public Property NomeFileModello() As String
         Get
            Return Current.NomeFileModello
         End Get
         Set(ByVal value As String)
            Current.NomeFileModello = value
         End Set
      End Property
      Public ReadOnly Property OutputDir() As String
         Get
            Return Current.PathOutPut
         End Get
         'Set(ByVal value As String)
         '   Current.PathOutPut = value
         'End Set
      End Property
      Public Property DescrizioneTipoPrestazione() As String
         Get
            Return Current.Descrizione
         End Get
         Set(ByVal value As String)
            Current.Descrizione = value
         End Set
      End Property
#End Region
      Public Sub OpenFile(ByVal FileName As String)
         'Try
         '   If FileName = "" Then Throw New ArgumentException("Nome file vuoto")
         '   If Not System.IO.File.Exists(FileName) Then Throw New ArgumentException("File inesistente")
         '   Dim pInfo As New ProcessStartInfo()
         '   pInfo.FileName = FileName
         '   pInfo.UseShellExecute = True
         '   Dim p As Process = Process.Start(pInfo)
         'Catch ex As Exception
         '   Throw New ArgumentException("Impossibile aprire il file specificato" & vbCrLf & ex.Message, "Filename")
         'End Try
         SimpleFileSystemManager.ViewFile(FileName)
        End Sub
        Public Function ExistTipoPrestazione(ByVal Descrizione As String) As Boolean

            LoadAll()
            For Each elem As TipoPrestazione In Me.DomainObjectList
                If elem.Descrizione = Descrizione Then
                    Return True
                End If
            Next
            Return False
        End Function

      Public Function GetIdTipoPrestazioneByDescrizione(ByVal Descrizione As String) As Int32

         LoadAll()
         For Each elem As TipoPrestazione In Me.DomainObjectList
            If elem.Descrizione = Descrizione Then
               Return elem.Id
            End If
         Next
         Throw New Exception("Id tipo prestrazione non trovato")

      End Function
      Public Function GetListaTipiPrestazioni() As ArrayList

         Dim list As New ArrayList
         LoadAll()
         For Each elem As TipoPrestazione In Me.DomainObjectList
            list.Add(elem.Descrizione)
         Next
         list.Sort()
         Return list

      End Function
      Public Overrides Function GetCategoryObject() As String
         Return "TipoPrestazione"
      End Function
      Friend Function GetTipoPrestazioneById(ByVal Id As String) As TipoPrestazione

         If Id = -1 Then Return New TipoPrestazioneNulla
         Me.LoadById(Id)
         Return Current()

      End Function
      Public Overrides Sub CreateNew()
         m_current = New TipoPrestazione

         SetPathOutput()

      End Sub

      Public Sub SetPathOutput()
         Dim c As New ControllerSegreteria
         c.LoadById(1)
         Current.PathOutPut = c.DirectoryPreferenzialeUtenti
      End Sub

      Public Overloads Sub CreateNew(ByVal Descrizione As String, ByVal CodicePrestazione As String, _
                                     ByVal NomeFileModello As String)



         Dim c As New ControllerSegreteria
         c.LoadById(1)

         Dim TipoPrestazione As TipoPrestazione = New TipoPrestazione(Descrizione, CodicePrestazione, NomeFileModello, c.DirectoryPreferenzialeUtenti)
         m_current = TipoPrestazione
         Save()

      End Sub
   End Class
End Namespace