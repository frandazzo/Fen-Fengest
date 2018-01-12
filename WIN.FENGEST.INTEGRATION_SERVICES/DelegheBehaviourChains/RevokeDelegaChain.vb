Public Class RevokeDelegaChain
   Inherits AbsctractChain
   Public Sub New(ByVal CancelDelega As CancelDelegaChain)
      MyBase.m_Chain = Canceldelega
   End Sub

   Public Overrides Sub Action(ByVal Parameters As System.Collections.Hashtable)
        If Parameters.Item("DATA_REVOCA") Is Nothing Then Parameters.Item("DATA_REVOCA") = ""
        Parameters.Item("DATA_REVOCA") = Parameters.Item("DATA_REVOCA").ToString.Replace(" 0.00.00", "")
      If IsDate(Parameters.Item("DATA_REVOCA")) Then
         Dim controller As WIN.APPLICATION.ADMINISTRATION.ControllerDeleghe = Parameters.Item("Controller")
         controller.RevocaDelega(CDate(Parameters.Item("DATA_REVOCA")), "", Parameters.Item("NOTE"))
         controller.Save()
      Else
         MyBase.m_Chain.Action(Parameters)
      End If
   End Sub
End Class
