Public Class Conto
   Inherits AbstractPersistenceObject
   Implements IConto
   Private m_TipoConto As TipoConto = TipoConto.Feneal
   Private m_Valuta As Moneta.Valuta
   Private m_ItemList As New VirtualLazyList
   Public Enum TipoConto
      Utenti
      Feneal
      Referenti
   End Enum

#Region "Costruttori"
   Public Sub New()

   End Sub
   Public Sub New(ByVal Descrizione As String, ByVal Valuta As Moneta.Valuta, ByVal TipoConto As TipoConto)
      If Descrizione = "" Then Throw New Exception("Impossibile creare un conto con una descrizione nulla.")
      MyBase.Descrizione = Descrizione
      m_Valuta = Valuta
      m_TipoConto = TipoConto
   End Sub
   Public Sub New(ByVal Descrizione As String, ByVal Valuta As Moneta.Valuta, ByVal DescrizioneTipoConto As String)
      If Descrizione = "" Then Throw New Exception("Impossibile creare un conto con una descrizione nulla.")
      MyBase.Descrizione = Descrizione
      m_Valuta = Valuta
      m_TipoConto = Conto.GetTipoByDescrizione(DescrizioneTipoConto)
   End Sub
#End Region

#Region "Gestione posizioni"
   Friend Overridable Sub AddItem(ByVal Item As ItemContabile)
      'Solo le posizioni del pagamento possono registrarsi
      If Item.Importo.GetValuta = m_Valuta Then
         m_ItemList.Add(Item)
      Else
         Throw New Exception("Non è possibile registrare una nuova posizione nel conto a causa della valuta differente")
      End If
   End Sub
   Public ReadOnly Property ItemList() As IList
      Get
         Return m_ItemList
      End Get
   End Property
   Public Sub SetItemList(ByVal List As VirtualLazyList)
      m_ItemList = List
   End Sub
#End Region


#Region "Proprietà"
   Public ReadOnly Property TipologiaConto() As TipoConto
      Get
         Return m_TipoConto
      End Get
   End Property
   Public Shared Function GetTipoToString(ByVal Tipo As TipoConto) As String
      Select Case Tipo
         Case TipoConto.Feneal
            Return "Conto Feneal"
         Case TipoConto.Referenti
            Return "Conto Referenti"
         Case TipoConto.Utenti
            Return "Conto Utenti"
      End Select
      Throw New Exception("Impossibile ritornare la descrizione del tipo conto. Tipo sconosciuto")
   End Function
   ''' <summary>
   ''' Restituisce il tipo conto data la descrizione
   ''' </summary>
   ''' <param name="Descrizione">I valori ammessi sono: "Utenti", "Referenti", "Feneal"</param>
   ''' <returns></returns>
   ''' <remarks></remarks>
   Public Shared Function GetTipoByDescrizione(ByVal Descrizione As String) As TipoConto
      Select Case Descrizione
         Case "Feneal"
            Return TipoConto.Feneal
         Case "Referenti"
            Return TipoConto.Referenti
         Case "Utenti"
            Return TipoConto.Utenti
      End Select
      Throw New Exception("Impossibile ritornare il tipo conto. Descrizione  sconosciuta")
   End Function

   Public Sub SetTipoConto(ByVal Tipo As TipoConto)
      m_TipoConto = Tipo
   End Sub

   Public Overloads Property Descrizione() As String Implements IConto.Descrizione
      Get
         Return MyBase.Descrizione
      End Get
      Set(ByVal value As String)
         If value = "" Then Throw New Exception("Impossibile creare un conto con una descrizione nulla.")
         MyBase.Descrizione = value
      End Set
   End Property
   Public Property Valuta() As Moneta.Valuta Implements IConto.Valuta
      Get
         Return m_Valuta
      End Get
      Set(ByVal value As Moneta.Valuta)
         If m_ItemList.Count = 0 Then
            m_Valuta = value
         End If
      End Set
   End Property
   Public ReadOnly Property IdConto() As Int32 Implements IConto.IdConto
      Get
         Return MyBase.Key.LongValue
      End Get

   End Property
#End Region



#Region "Funzioni per il calcolo dei bilanci contabili per data registrazione"
   Public Overloads Function Balance(ByVal DataRange As DataRange) As Moneta
      Dim Money As Moneta = New Moneta(0, m_Valuta)
      For Each elem As ItemContabile In m_ItemList
         If DataRange.Includes(elem.DataRegistrazione) Then
            Money = Money.Add(elem.Importo)
         End If
      Next
      Return Money
   End Function
   Public Overloads Function Balance(ByVal UpTo As DateTime) As Moneta
      Dim Range As DataRange = DataRange.CreateOpenEnded(UpTo)
      Dim Money As Moneta = New Moneta(0, m_Valuta)
      For Each elem As ItemContabile In m_ItemList
         If Range.Includes(elem.DataRegistrazione) Then
            Money = Money.Add(elem.Importo)
         End If
      Next
      Return Money
   End Function

#End Region






End Class
