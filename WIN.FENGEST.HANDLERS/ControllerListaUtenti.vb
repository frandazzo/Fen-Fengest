Public Class ControllerListaUtenti
   Inherits AbstractController
   Private m_ControllerUtenti As New UTENTI.ControllerUtenti

   'Private m_currentUtente As Utente

   Public Function Current() As ListaLavoroUtenti
      Return DirectCast(MyBase.m_current, ListaLavoroUtenti)
    End Function




    Public Sub SetCurrent(ByVal lista As ListaLavoroUtenti)
        MyBase.m_current = lista
    End Sub




    Public Sub StampaTessereLista()
        Dim ps1 As IPersistenceFacade = DataAccessServices.Instance.PersistenceFacade
        'ps.ExecuteNonQuery("Begin transaction PrintCards")

        ps1.ExecuteNonQuery("Delete from db_tesseramento")


        For Each elem As Utente In Current.ListaUtentiOrdinataPerCognome
            Try
                ps1.ExecuteNonQuery(String.Format("Insert into db_tesseramento (Cognome, Nome, " & _
                                           "Impresa, STAMPATA_DA, IdUtente, " & _
                                           "PROVINCIA, COMUNE, VIA, CAP,AZIENDA_OLD) " & _
                                           "values ('{0}', '{1}', '{2}', '{3}', {4}, '{5}' , '{6}', '{7}', '{8}', '{9}')", Replace(elem.Cognome, "'", "''"), Replace(elem.Nome, "'", "''"), Replace(elem.Segreteria.Provincia, "'", "''"), Replace("Admin", "'", "''"), elem.IdUtente, Replace(elem.Residenza.Provincia.Sigla, "'", "''"), Replace(elem.Residenza.Comune.Descrizione, "'", "''"), Replace(elem.Residenza.Via, "'", "''"), Replace(elem.Residenza.Cap, "'", "''"), Replace("", "'", "''")))

            Catch ex As Exception

            End Try

        Next


       
    End Sub



   Public Overridable Sub SortItems(ByVal PropertyName As String, Optional ByVal Descending As Boolean = False)

      If PropertyName = "" Then Throw New Exception("Selezionare una proprietà.")
      If TypeOf (Current.ListaUtenti) Is ArrayList Then
         DirectCast(Current.ListaUtenti, ArrayList).Sort(SortFactory.GetItemComparer(PropertyName, Descending, "Utenti"))

      Else
         DirectCast(Current.ListaUtenti, VirtualLazyList).Sort(SortFactory.GetItemComparer(PropertyName, Descending, "Utenti"))


      End If
     
   End Sub


   Public Function GetListaUtenti() As IList
      Return Current.ListaUtenti
   End Function

  

   Public Sub AddUtente(ByVal IdUtente As String)

      Dim utente As Utente = m_ControllerUtenti.GetUtenteById(IdUtente)
      Current.AddUtente(utente)
     
   End Sub

   Public ReadOnly Property UtenteAggiunto() As Boolean
      Get
         Return Current.HasAdded
      End Get
   End Property

   Public Sub RemoveUtente(ByVal IdUtente As String)

      Dim utente As Utente = m_ControllerUtenti.GetUtenteById(IdUtente)
      Current.RemoveUtente(utente)

   End Sub

   Public Property Descrizione() As String
      Get
         Return Current.Descrizione
      End Get
      Set(ByVal value As String)
         Current.Descrizione = value
      End Set
   End Property


   'Public Sub SelectUtente(ByVal IdUtente As String)
   '   m_currentUtente = Current.GetUtente(m_ControllerUtenti.GetUtenteById(IdUtente))
   'End Sub
   Public ReadOnly Property NumeroUtenti() As Int32
      Get
         Return Current.ListaUtenti.Count
      End Get
   End Property


   Public ReadOnly Property IdLista() As String
      Get
         Return Current.Id
      End Get
   End Property


   Public Sub New()

   End Sub
  



#Region "Metodi CRUD"
   Public Overrides Function GetCategoryObject() As String
      Return "ListaLavoroUtenti"
   End Function
   ''' <summary>
   ''' Crea un'istanza vuota dell'oggetto
   ''' </summary>
   ''' <remarks></remarks>
   Public Overrides Sub CreateNew()
   
      MyBase.m_current = New ListaLavoroUtenti
      
   End Sub
   

   Public Function GetListeByDescrizione(ByVal Descrizione As String) As IList
      Dim nome As String = Replace(Descrizione, "'", "''")


      Dim qry As Query = Ps.CreateNewQuery("MapperListaLavoroUtenti")
      Dim orderCriteria As AbstractBoolCriteria = New OrderByCriteria
      orderCriteria.AddCriteria(Criteria.SortCriteria("DESCRIZIONE", True))

      qry.AddWhereClause(Criteria.Matches("DESCRIZIONE", nome, Ps.DBType))
      qry.AddOrderByClause(orderCriteria)




      Return qry.Execute(Ps)

   End Function


   Friend Function GetListaById(ByVal IdLista As Int32) As ListaLavoroUtenti
      Try

         LoadById(IdLista)
         Return Current()
      Catch ex As Exception
         Return Nothing
      End Try
   End Function
   

#End Region



End Class

