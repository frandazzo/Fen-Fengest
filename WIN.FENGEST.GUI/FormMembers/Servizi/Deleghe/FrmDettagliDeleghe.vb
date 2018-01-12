Public Class FrmDettagliDeleghe

   Public Sub New(ByVal ControllerDeleghe As WIN.APPLICATION.ADMINISTRATION.ControllerDeleghe)
      InitializeComponent()
      Select Case ControllerDeleghe.StatoPrecedente
         Case "Sottoscritta"
            txtSott.Text = ControllerDeleghe.CausaleSottoscrizione
            txtRep.Text = ControllerDeleghe.Reparto
            txtInoltro.Text = "-"
            txtDataAcc.Text = "-"
            'txtAccettante.Text = "-"
            txtDataAtt.Text = "-"
            txtInc.Text = "-"
         Case "Inoltrata"
            txtSott.Text = ControllerDeleghe.CausaleSottoscrizione
            txtRep.Text = ControllerDeleghe.Reparto
            txtInoltro.Text = ControllerDeleghe.DataInoltro.Date
            txtDataAcc.Text = "-"
            'txtAccettante.Text = "-"
            txtDataAtt.Text = "-"
            txtInc.Text = "-"
         Case "Accettata"
            txtSott.Text = ControllerDeleghe.CausaleSottoscrizione
            txtRep.Text = ControllerDeleghe.Reparto
            txtInoltro.Text = ControllerDeleghe.DataInoltro.Date
            txtDataAcc.Text = ControllerDeleghe.DataAccettazione.Date
            'If ControllerDeleghe.IsSettoreEdile Then
            '   If ControllerDeleghe.AccettataEntrambiEntiBilaterali Then
            '      txtAccettante.Text = "ENTRAMBI"
            '   Else
            '      txtAccettante.Text = ControllerDeleghe.DescrizioneEnteAccettante1
            '   End If
            'Else
            '   txtAccettante.Text = ControllerDeleghe.DescrizioneEnteInoltro
            'End If
            txtDataAtt.Text = "-"
            txtInc.Text = "-"
         Case "Attivata"
            txtSott.Text = ControllerDeleghe.CausaleSottoscrizione
            txtRep.Text = ControllerDeleghe.Reparto
            txtInoltro.Text = ControllerDeleghe.DataInoltro.Date
            txtDataAcc.Text = ControllerDeleghe.DataAccettazione.Date
            'If ControllerDeleghe.IsSettoreEdile Then
            '   If ControllerDeleghe.AccettataEntrambiEntiBilaterali Then
            '      txtAccettante.Text = "ENTRAMBI"
            '   Else
            '      txtAccettante.Text = ControllerDeleghe.DescrizioneEnteAccettante1
            '   End If
            'Else
            '   txtAccettante.Text = ControllerDeleghe.DescrizioneEnteInoltro
            'End If
            txtDataAtt.Text = ControllerDeleghe.DataAttivazione.Date
            txtInc.Text = ControllerDeleghe.IdPagamento
      End Select

    







   End Sub

 
  
End Class