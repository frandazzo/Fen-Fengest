Public Class CancelDelegaChain
   Inherits AbsctractChain
   Public Sub New(ByVal AcceptDelega As AcceptDelegaChain)
      MyBase.m_Chain = AcceptDelega
   End Sub
   Public Overrides Sub Action(ByVal Parameters As System.Collections.Hashtable)
        If Parameters.Item("DATA_ANNULLAMENTO") Is Nothing Then Parameters.Item("DATA_ANNULLAMENTO") = ""
        Parameters.Item("DATA_ANNULLAMENTO") = Parameters.Item("DATA_ANNULLAMENTO").ToString.Replace(" 0.00.00", "")
      If IsDate(Parameters.Item("DATA_ANNULLAMENTO")) Then
         Dim controller As WIN.APPLICATION.ADMINISTRATION.ControllerDeleghe = Parameters.Item("Controller")
         controller.AnnullaDelega(CDate(Parameters.Item("DATA_ANNULLAMENTO")), "")
         controller.Save()
      Else
         MyBase.m_Chain.Action(Parameters)
      End If
   End Sub
End Class
