Public Class FrmFiglio
   Private m_IsItemAdded As Boolean = False
   Private m_IsItemUpdated As Boolean = False
   Public Event InfoAdded()
   Public Event InfoUpdate()
   Private IsLoading As Boolean = False

   Protected m_Operation As String = "View"
   Private controllerUtenti As WIN.APPLICATION.UTENTI.ControllerUtenti



   Public ReadOnly Property IsItemUpdated()
      Get
         Return m_IsItemUpdated
      End Get
   End Property

   Public ReadOnly Property IsItemAdded()
      Get
         Return m_IsItemAdded
      End Get
   End Property





 

   ''' <summary>
   ''' 
   ''' </summary>
   ''' <param name="Operation">I valori ammessi sono: "View", "Update", "Add"</param>
   ''' <param name="Controller"></param>
   ''' <remarks></remarks>
   Public Sub New(ByVal Operation As String, ByVal Controller As WIN.APPLICATION.UTENTI.ControllerUtenti)
      InitializeComponent()
      m_Operation = Operation
      controllerUtenti = Controller
   End Sub

   Private Sub FrmFiglio_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        


      Select Case m_Operation
         Case "View"
            IsLoading = True
            LoadItem()
            IsLoading = False
         Case "Add"
            ClearWindow()
            Me.cmdAdd.Enabled = True
            Me.cmdOk.Enabled = False
      End Select
   End Sub

   Private Sub LoadItem()
      txtNome.TextValue = controllerUtenti.NomeFiglio
      txtCognome.TextValue = controllerUtenti.CognomeFiglio
      txtCF.TextValue = controllerUtenti.FiscaleFiglio
      dtpData.DataValue = controllerUtenti.DataNascitaFiglio
      txtAnno.TextValue = controllerUtenti.AnnoFrequentazione
      txtScuola.TextValue = controllerUtenti.Scuola
      Me.cmdAdd.Enabled = False
      Me.cmdOk.Enabled = True
   End Sub

   Private Sub ClearWindow()

      dtpData.DataValue = DateTime.Today
      txtScuola.Text = ""
      txtNome.TextValue = ""
      txtCognome.TextValue = ""
      txtCF.TextValue = ""
      txtAnno.Text = ""

   End Sub

   Private Sub Change()
      If Not m_Operation = "Add" Then
         If Not IsLoading Then
            m_Operation = "Update"
            m_IsItemUpdated = True
            Me.Invalidate()
         End If
      End If
   End Sub



   Private Sub dtpData_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
      Change()
   End Sub

   Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
      Try
         If m_IsItemUpdated Then
            controllerUtenti.NomeFiglio = txtNome.TextValue
            controllerUtenti.CognomeFiglio = txtCognome.TextValue
            controllerUtenti.FiscaleFiglio = txtCF.TextValue
            controllerUtenti.DataNascitaFiglio = dtpData.DataValue
            controllerUtenti.AnnoFrequentazione = txtAnno.TextValue
            controllerUtenti.Scuola = txtScuola.TextValue
            RaiseEvent InfoUpdate()
         End If
         Me.Close()
      Catch ex As Exception
         ErrorHandler.ShowError(ex)
      End Try
   End Sub

   Private Sub cmdAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnnulla.Click
      Me.Close()
   End Sub

   Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
      Try
         Dim controllerenti As New AZIENDE.ControllerEntiBilaterali

         controllerUtenti.AddFiglio(txtNome.TextValue, txtCognome.TextValue, txtCF.TextValue, txtScuola.TextValue, txtAnno.TextValue, dtpData.DataValue)
         Me.m_IsItemAdded = True
         RaiseEvent InfoAdded()
         Me.Close()
      Catch ex As Exception
         Me.m_IsItemAdded = False
         ErrorHandler.ShowError(ex)
      End Try
   End Sub



  

 

   Private Sub txtAnno_TextChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAnno.TextChange
      Change()
   End Sub

   Private Sub txtScuola_TextChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtScuola.TextChange
      Change()
   End Sub

   Private Sub UsabilityDtPicker1_ValueChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpData.ValueChange
      Change()
   End Sub

 
   Private Sub txtCognome_TextChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCognome.TextChange
      Change()
   End Sub

   Private Sub txtNome_TextChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNome.TextChange
      Change()
   End Sub

   Private Sub UsabilityTextBox1_TextChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCF.TextChange
      Change()
   End Sub

    Private Sub SpCf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpCf.Click
        Try
            Dim frmcalc As New FrmCacolatoreCF(txtCognome.TextValue, txtNome.TextValue, dtpData.DataValue)

            If frmcalc.ShowDialog = Windows.Forms.DialogResult.OK Then
                If Not String.IsNullOrEmpty(frmcalc.CodiceFiscale) Then
                    txtCF.TextValue = frmcalc.CodiceFiscale
                    dtpData.DateTimePicker1.Value = frmcalc.Data
                End If
            End If
            frmcalc.Dispose()

        Catch ex As Exception
            ErrorHandler.ShowError(ex)
        End Try
    End Sub
End Class