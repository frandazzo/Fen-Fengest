Public Class AcceptDelegaChain
   Inherits AbsctractChain
   Public Sub New(ByVal SubscribeDelega As AbsctractChain)
      MyBase.m_Chain = SubscribeDelega
   End Sub
   Public Overrides Sub Action(ByVal Parameters As System.Collections.Hashtable)
        If Parameters.Item("DATA_ACCETTAZIONE") Is Nothing Then Parameters.Item("DATA_ACCETTAZIONE") = ""
        Parameters.Item("DATA_ACCETTAZIONE") = Parameters.Item("DATA_ACCETTAZIONE").ToString.Replace(" 0.00.00", "")
      If IsDate(Parameters.Item("DATA_ACCETTAZIONE")) Then
         Dim controller As WIN.APPLICATION.ADMINISTRATION.ControllerDeleghe = Parameters.Item("Controller")
         controller.InoltraDelega(CDate(Parameters.Item("DATA_ACCETTAZIONE")))
         controller.AccettaDelega(CDate(Parameters.Item("DATA_ACCETTAZIONE")))
         controller.UpdateAllDeleghe()
      Else
         MyBase.m_Chain.Action(Parameters)
      End If
   End Sub
End Class
