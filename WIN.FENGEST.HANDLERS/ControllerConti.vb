Namespace CONTI

   Public Class ControllerConti
      Inherits AbstractController
      Private Function Current() As Conto
         Return DirectCast(MyBase.m_current, Conto)
      End Function
#Region "Proprietà oggetto"
      Public Property Descrizione() As String
         Get
            Return current.Descrizione
         End Get
         Set(ByVal value As String)
            current.Descrizione = value
         End Set
      End Property
      Public Property Valuta() As String
         Get
            Return Moneta.GetTipoValutaToString(Current.Valuta)
         End Get
         Set(ByVal value As String)
            Current.Valuta = Moneta.GetTipoValuta(value)
         End Set
      End Property
      Public ReadOnly Property IdConto() As Int32
         Get
            Return current.IdConto
         End Get
      End Property
      Public ReadOnly Property TipoConto() As String
         Get
            Return Conto.GetTipoToString(Current.TipologiaConto)
         End Get
      End Property

#End Region

#Region "Metodi di gestione dei conti"
      Public Overloads Function Balance(ByVal UpTo As DateTime) As Moneta
         Try
            Return Current.Balance(UpTo)
         Catch ex As Exception
            Throw New Exception(ex.Message)
         End Try
      End Function
      Public Overloads Function BalanceAmount(ByVal UpTo As DateTime) As Double
         Try
            Return Current.Balance(UpTo).Importo
         Catch ex As Exception
            Throw New Exception(ex.Message)
         End Try
      End Function
      Public Overloads Function Balance(ByVal DataRange As DataRange) As Moneta
         Try
            Return Current.Balance(DataRange)
         Catch ex As Exception
            Throw New Exception(ex.Message)
         End Try
      End Function
      Public Overloads Function Balance(ByVal DataInizio As DateTime, ByVal Datafine As DateTime) As Moneta
         Try
            Dim DataRange As DataRange = New DataRange(DataInizio, Datafine)
            Return Current.Balance(DataRange)
         Catch ex As Exception
            Throw New Exception(ex.Message)
         End Try
      End Function
      Public Overloads Function BalanceAmount(ByVal DataInizio As DateTime, ByVal Datafine As DateTime) As Double
         Try
            Dim DataRange As DataRange = New DataRange(DataInizio, Datafine)
            Return Current.Balance(DataRange).Importo
         Catch ex As Exception
            Throw New Exception(ex.Message)
         End Try
      End Function
#End Region


#Region "Metodi CRUD"
      Public Overrides Function GetCategoryObject() As String
         Return "Conto"
      End Function
      ''' <summary>
      ''' Crea un'istanza vuota dell'oggetto
      ''' </summary>
      ''' <remarks></remarks>
      Public Overrides Sub CreateNew()
         MyBase.m_current = New Conto
      End Sub
      ''' <summary>
      ''' Crea e salva l'istanza dell'oggetto complato con i parametri necessari
      ''' </summary>
      ''' <param name="Descrizione"></param>
      ''' <param name="Valuta"></param>
      ''' <remarks></remarks>
      ''' 
      '''
      '''

      Public Overloads Sub CreateNew(ByVal Descrizione As String, ByVal Valuta As String, ByVal TipoConto As String)
         Try
            MyBase.m_current = New Conto(Descrizione, Moneta.GetTipoValuta(Valuta), Conto.GetTipoByDescrizione(TipoConto))
            Save()
         Catch ex As Exception
            Throw New Exception(ex.Message)
         End Try
      End Sub
      ''' <summary>
      ''' Restituisce il conto desiderato secondo il tipo specificato
      ''' </summary>
      ''' <param name="DescrizioneTipo">I valori ammessi sono: "Utenti", "Referenti", "Feneal"</param>
      ''' <returns></returns>
      ''' <remarks></remarks>
      Public Shared Function GetContoByType(ByVal DescrizioneTipo As String) As Conto
         Try
            Dim tipo As Conto.TipoConto = Conto.GetTipoByDescrizione(DescrizioneTipo)
            Dim query As Query = DataAccessServices.Instance.PersistenceFacade.CreateNewQuery("MapperConto")
                Dim criteria As Criteria = TECHNICAL.PERSISTENCE.Criteria.Equal("TIPO_CONTO", tipo)
            query.AddWhereClause(criteria)
            Dim list As ArrayList = query.Execute(DataAccessServices.Instance.PersistenceFacade)
            If list.Count > 0 Then
               Return list.Item(0)
            End If
            Return New ContoNullo
         Catch ex As Exception
            Throw New Exception("Impossibile ottenere il conto secondo il tipo " & DescrizioneTipo & vbCrLf & ex.Message)
         End Try
      End Function

      Friend Function GetContoById(ByVal IdConto As String) As Conto
         Try
            LoadById(IdConto)
            Return Current()
         Catch ex As Exception
            Throw New Exception(ex.Message)
         End Try
      End Function
#End Region



   End Class
End Namespace



