Public Class StNull
   Implements IStatusDelega



   Public Shared Function Instance() As StRevocata
      Return New StRevocata
   End Function
   Public Sub Accetta(ByVal DataAccettazione As DateTime, ByVal Delega As Delega) Implements IStatusDelega.Accetta


   End Sub
   Public Sub Attiva(ByVal Pagamento As IDocumento, ByVal Delega As Delega) Implements IStatusDelega.Attiva


   End Sub
   Public Sub Inoltra(ByVal DataInoltro As DateTime, ByVal Delega As Delega) Implements IStatusDelega.Inoltra


   End Sub
   Public Sub Rifiuta(ByVal Delega As Delega) Implements IStatusDelega.Rifiuta


   End Sub
   Public Sub Revoca(ByVal Delega As Delega, ByVal Causale As CausaleRevocaDelega, ByVal DataRevoca As DateTime, ByVal Note As String) Implements IStatusDelega.Revoca


   End Sub
   Public Sub Annulla(ByVal Delega As Delega, ByVal DataAnnullamento As DateTime, ByVal DelegaAccettata As Delega) Implements IStatusDelega.Annulla

      '
   End Sub
   Public ReadOnly Property ReadyForPayment() As Boolean Implements IStatusDelega.ReadyForPayment
      Get
         Return False
      End Get
   End Property
   Public ReadOnly Property IsAccepted() As Boolean Implements IStatusDelega.IsAccepted
      Get
         Return False
      End Get
   End Property

   Public ReadOnly Property StatusName() As String Implements IStatusDelega.StatusName
      Get
         Return "Nullo"
      End Get
   End Property

   Public Sub RipristinaStatoPrecedente(ByVal Delega As Delega) Implements IStatusDelega.RipristinaStatoPrecedente
      '
   End Sub

   Public Sub Annulla1(ByVal Delega As Delega, ByVal DataAnnullamento As Date, ByVal Causale As AbstractPersistenceObject) Implements IStatusDelega.Annulla
      '
   End Sub
End Class
