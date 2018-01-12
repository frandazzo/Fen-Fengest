Public Class ControllerSettori
   Inherits AbstractController
   Private ListLoaded As Boolean = False
   'Private m_Contratto As Contratto = New ContrattoNullo
   'Private ControllerTipoContratto As New ControllerTipoContratto
   Private Function Current() As Settore
      Return DirectCast(MyBase.m_current, Settore)
   End Function


#Region "Metodi d'ausilio per l'interfaccia"
   Public Function GetIdSettoreByDescrizione(ByVal Descrizione As String) As Int32
      Try
         If Descrizione = "" Then Return -1
         If Not ListLoaded Then
            Me.LoadAll()
            ListLoaded = True
         End If
         For Each elem As Settore In Me.DomainObjectList
            If elem.Descrizione = Descrizione Then
               m_current = elem
               Return elem.Id
            End If
         Next
         Throw New Exception("Settore con descrizione " & Descrizione & " non trovato")
      Catch ex As Exception
         Throw New Exception("Impossibile ottenere l'Id del settore." & vbCrLf & ex.Message)
      End Try
   End Function
   'Public Function GetIdSettoreByIdContratto(ByVal IdContratto As String) As Int32
   '   Try

   '      If IdContratto = "" Then Return -1
   '      If Not IsNumeric(IdContratto) Then Throw New Exception("Formato id contratto errato")
   '      If Not ListLoaded Then
   '         Me.LoadAll()
   '         ListLoaded = True
   '      End If
   '      For Each elem As Settore In Me.DomainObjectList
   '         If elem.GetContrattoById(IdContratto).Descrizione <> "" Then Return elem.Id
   '      Next
   '      Throw New Exception("Il contratto richiesto non appartiene ad alcun settore")
   '   Catch ex As Exception
   '      Throw New Exception("Impossibile ottenere l'id del settore." & vbCrLf & ex.Message)
   '   End Try
   'End Function
   Public Function GetDescrizioneSettoreById(ByVal Id As String) As String
      Try
         If Not ListLoaded Then
            Me.LoadAll()
            ListLoaded = True
         End If
         For Each elem As Settore In Me.DomainObjectList
            If elem.Id = Id Then Return elem.Descrizione
         Next
         Throw New Exception("Settore con id " & Id & " non trovato")
      Catch ex As Exception
         Throw New Exception("Impossibile ottenere la descrizione del settore." & vbCrLf & ex.Message)
      End Try
   End Function
   Public Function GetListaSettori() As Hashtable
      Try
         If Not ListLoaded Then
            Me.LoadAll()
            ListLoaded = True
         End If
         Dim map As New Hashtable
         For Each elem As Settore In Me.DomainObjectList
            map.Add(elem.Id, elem.Descrizione)
         Next
         Return map
      Catch ex As Exception
         Throw New Exception("Impossibile ottenere la hash map dei settori. " & vbCrLf & ex.Message)
      End Try
   End Function
#End Region


#Region "Proprietà settore"
   Public ReadOnly Property Id() As Int32
      Get
         Return Current.Id
      End Get
   End Property
   Public Property Descrizione() As String
      Get
         Return Current.Descrizione
      End Get
      Set(ByVal value As String)
         Current.Descrizione = value
      End Set
   End Property
   Public Property TipoSettore() As String
      Get
         Return Current.TipologiaSettore.ToString
      End Get
      Set(ByVal value As String)
         Current.TipologiaSettore = Settore.GetTipoSettoreByDescrizione(value)
      End Set
   End Property
   Public Overloads Function IsSettoreEdile(ByVal Descrizione As String) As Boolean
      Try
         If Not ListLoaded Then
            Me.LoadAll()
            ListLoaded = True
         End If
         For Each elem As Settore In Me.DomainObjectList
            If elem.Descrizione = Descrizione Then
               If elem.TipologiaSettore = Settore.TipoSettore.Edili Then Return True
            End If
         Next
         Return False
      Catch ex As Exception
         Throw New Exception(ex.Message)
      End Try

   End Function
   Public Overloads Function IsSettoreEdile() As Boolean
      Try
         If Current.TipologiaSettore = Settore.TipoSettore.Edili Then Return True
         Return False
      Catch ex As Exception
         Throw New Exception(ex.Message)
      End Try

   End Function
#End Region


#Region "Metodi CRUD "
   ''' <summary>
   ''' Restituisce il settore secondo il tipo specificato
   ''' </summary>
   ''' <param name="DescrizioneTipoSettore">I valori ammessi sono: "ImpiantiFissi" e "Edile"</param>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public Shared Function GetSettoreByTipo(ByVal DescrizioneTipoSettore As String) As Settore
      Try
         Dim tipo As Settore.TipoSettore = Settore.GetTipoSettoreByDescrizione(DescrizioneTipoSettore)
         Dim query As Query = DataAccessServices.Instance.PersistenceFacade.CreateNewQuery("MapperSettore")
            Dim criteria As Criteria = TECHNICAL.PERSISTENCE.Criteria.Equal("TIPO_SETTORE", tipo)
         query.AddWhereClause(criteria)
         Dim list As ArrayList = query.Execute(DataAccessServices.Instance.PersistenceFacade)
         If list.Count > 0 Then
            Return list.Item(0)
         End If
         Return New SettoreNullo
      Catch ex As Exception
         Throw New Exception("Impossibile ottenere il settore secondo il tipo " & DescrizioneTipoSettore & vbCrLf & ex.Message)
      End Try
   End Function
   Friend Function GetSettoreById(ByVal IdSettore As String) As Settore
      Try
         If Not IsNumeric(IdSettore) Then Throw New Exception("L'id del settore non è corretto")
         LoadById(IdSettore)
         Return Current()
      Catch ex As Exception
         Throw New Exception("Impossibile ottenere il settore." & vbCrLf & ex.Message)
      End Try
   End Function
   Public Overloads Overrides Sub CreateNew()
      m_current = New Settore
   End Sub
   ''' <summary>
   ''' Crea e salva un nuovo settore
   ''' </summary>
   ''' <param name="Descrizione">Descrizione settore</param>
   ''' <param name="TipoSettore">I valori ammessi sono: "ImpiantiFissi" e "Edile"</param>
   ''' <remarks></remarks>
   Public Overloads Sub CreateNew(ByVal Descrizione As String, ByVal TipoSettore As String)
      Try
         m_current = New Settore(Descrizione, Settore.GetTipoSettoreByDescrizione(TipoSettore))
         Save()
      Catch ex As Exception
         Throw New Exception(ex.Message)
      End Try

   End Sub
   Public Overrides Function GetCategoryObject() As String
      Return "Settore"
   End Function
   Friend Function GetSettoreById(ByVal IdSettore As Int32) As Settore
      Try
         LoadById(IdSettore)
         Return Current()
      Catch ex As Exception
         Throw New Exception("Impossibile ottenere il settore richiesto." & vbCrLf & ex.Message)
      End Try
   End Function
#End Region

End Class
