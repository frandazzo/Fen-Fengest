Public Class FrmDatiFiscali


   Private m_DatiFiscali As DatiFiscali

   Public ReadOnly Property DatiFiscali() As DatiFiscali
      Get
         Return m_DatiFiscali
      End Get
   End Property

   Public Sub New(ByVal DatiFiscali As DatiFiscali)

      ' Chiamata richiesta da Progettazione Windows Form.
      InitializeComponent()

      ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
      m_DatiFiscali = DatiFiscali
   End Sub



   Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
      Me.DialogResult = Windows.Forms.DialogResult.OK
      Me.Close()

   End Sub

   Private Sub cmdAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnnulla.Click
      Me.DialogResult = Windows.Forms.DialogResult.Cancel
      Me.Close()
   End Sub

   Private Sub FrmDatiFiscali_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      If m_DatiFiscali.SessoPersona.ToString = "0" Then
         txtSesso.Text = "MASCHIO"
      Else
         txtSesso.Text = "FEMMINA"
      End If
      txtComune.Text = m_DatiFiscali.Comune.Descrizione
      txtProvincia.Text = m_DatiFiscali.Provincia.Descrizione
      txtNazione.Text = m_DatiFiscali.Nazione.Descrizione
      txtData.Text = m_DatiFiscali.DataNascita.ToShortDateString


   End Sub
End Class