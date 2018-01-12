Public Class ControllerTipoContratto
   Inherits AbstractController
   Private ListLoaded As Boolean = False
   Private controllerSettori As New ControllerSettori
   Private Function Current() As TipoContratto
      Return DirectCast(m_current, TipoContratto)
   End Function
  

   Public Function GetListaContratti() As ArrayList

      Dim list As New ArrayList
      LoadAll()
      For Each elem As TipoContratto In Me.DomainObjectList
         list.Add(elem.Descrizione)
      Next
      list.Sort()
      Return list

   End Function
   Public Function GetIdTipoContrattoByDescrizione(ByVal Descrizione As String) As Int32

      LoadAll()
      For Each elem As TipoContratto In MyBase.DomainObjectList
            If elem.Descrizione = UCase(Descrizione) Then
                m_current = elem
                Return elem.Id
            End If
      Next
      Return -1

   End Function
   Public Function GetDescrizioneTipoContrattoById(ByVal Id As String) As String

      If Not IsNumeric(Id) Then Throw New Exception("Impossibile ottenere la descrizione del tipo contratto. L'id immesso non ha un formato corretto")
      MyBase.LoadAll()
      For Each elem As TipoContratto In MyBase.DomainObjectList
         If elem.Id = Id Then
            Return elem.Descrizione
         End If
      Next
      Return ""
      
   End Function
   Public ReadOnly Property IdTipoContratto() As Int32
      Get
         Return Current.Id
      End Get
   End Property

   Public ReadOnly Property DataInizioValiditaNormativa() As DateTime
      Get
         Return Current.ValiditaNormativa.Start
      End Get
   End Property
   Public ReadOnly Property DataFineValiditaNormativa() As DateTime
      Get
         Return Current.ValiditaNormativa.Finish
      End Get
   End Property

   Public Sub SetValiditaNormativa(ByVal DataInizio As DateTime, ByVal DataFine As DateTime)
      Current.ValiditaNormativa = New DataRange(DataInizio, DataFine)
   End Sub

   Public ReadOnly Property DataInizioValiditaEconomica() As DateTime
      Get
         Return Current.ValiditaEconomica.Start
      End Get
   End Property
   Public ReadOnly Property DataFineValiditaEconomica() As DateTime
      Get
         Return Current.ValiditaEconomica.Finish
      End Get
   End Property

   Public Sub SetValiditaEconomica(ByVal DataInizio As DateTime, ByVal DataFine As DateTime)
      Current.ValiditaEconomica = New DataRange(DataInizio, DataFine)
   End Sub



   Public Property Descrizione() As String
      Get
         Return Current.Descrizione
      End Get
      Set(ByVal value As String)
         Current.Descrizione = value
      End Set
   End Property
   Public Overrides Function GetCategoryObject() As String
      Return "TipoContratto"
   End Function

   Public ReadOnly Property IdSettore() As Int32
      Get
         Return Current.SettoreSpecifico.Id
      End Get
   End Property
   Public ReadOnly Property DescrizioneSettore() As String
      Get
         Return Current.SettoreSpecifico.Descrizione
      End Get
   End Property
   Public Sub SetSettore(ByVal IdSettore As String)
      Try
         If Not IsNumeric(IdSettore) Then Throw New Exception("Formato id settore errato")
         Current.SettoreSpecifico = controllerSettori.GetSettoreById(IdSettore)
      Catch ex As Exception
         Throw New Exception("Impossibile impostare il settore per il contratto" & vbCrLf & ex.Message)
      End Try
   End Sub
   Public Function GetListaContrattiByIdSettore(ByVal IdSettore As String) As ArrayList
      Try
         Dim qry As Query = Ps.CreateNewQuery("MapperTipoContratto")
            Dim criteria As Criteria = TECHNICAL.PERSISTENCE.Criteria.Equal("SETTORE_SPECIFICO", IdSettore)
         qry.AddWhereClause(criteria)
         Dim list As ArrayList = qry.Execute(Ps)
         Dim res As New ArrayList
         For Each elem As TipoContratto In list
            res.Add(elem.Descrizione)
         Next
         Return res
      Catch ex As Exception
         Throw New Exception("Impossibile ottenere la lista dei contratti per il settore con l'id specificato." & vbCrLf & ex.Message)
      End Try
   End Function

#Region "Metodi CRUD"
   Friend Function GetTipoContrattoById(ByVal IdTipoContratto As String)
      Try
         If Not IsNumeric(IdTipoContratto) Then Throw New Exception("L'id del tipo contratto ha un id nullo o non ha un formato corretto.")
         LoadById(IdTipoContratto)
         Return Current()
      Catch ex As Exception
         Throw New Exception("Impossibile ottenere il tipo contratto" & vbCrLf & ex.Message)
      End Try
   End Function
   Public Overrides Sub CreateNew()
      m_current = New TipoContratto
   End Sub
   ''' <summary>
   ''' Crea un nuovo tipo contratto e lo associa al settore
   ''' Salva il tipo contratto e l'associazione al settore di riferimento
   ''' </summary>
   ''' <param name="Descrizione"></param>
   ''' <param name="Settore"></param>
   ''' <remarks></remarks>
   Public Overloads Sub CreateNew(ByVal Descrizione As String, ByVal Settore As String)

      m_current = New TipoContratto(Descrizione, controllerSettori.GetSettoreById(controllerSettori.GetIdSettoreByDescrizione(Settore)))
      Save()


   End Sub

   

#End Region
End Class
