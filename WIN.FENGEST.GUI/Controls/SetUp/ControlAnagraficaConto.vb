Public Class ControlAnagraficaConto
   Private controllerConti As New CONTI.ControllerConti
   Public Sub New()
      InitializeComponent()
      Try
         DoLoad()
      Catch ex As Exception
         'ErrorHandler.ShowError(ex)
         Throw New Exception(ex.Message)
      End Try
   End Sub
   Public Sub New(ByVal IdConto As Int32)
      InitializeComponent()
      Me.m_IdShowedObject = IdConto
      Try
         DoLoad()
      Catch ex As Exception
         'ErrorHandler.ShowError(ex)
         Throw New Exception(ex.Message)
      End Try
   End Sub
    Public Overrides Sub Nested_NotifyParent()
        MasterControl.Instance.ParentForm.Text = "" & MyBase.State.StateName & " Conto"
    End Sub

#Region "Metodi per la ricerca"
    Public Overrides Sub DoSearch()
        Me.TabControl1.Visible = False
        Me.IdContoTextBox1.TextValue = ""
        Me.IdContoTextBox1.Visible = True
        Me.IdContoTextBox1.Enabled = True
        Me.lblId.Visible = True
        MasterControl.Instance.ParentForm.Text = "Ricerca Conto"
        Me.cmdVisualizza.Visible = True
    End Sub
#End Region

#Region "Metodi per Load iniziale"
    Protected Overrides Sub Nested_PrepareLoading()
        Me.TabControl1.Visible = True
        Me.IdContoTextBox1.TextValue = ""
        Me.IdContoTextBox1.Enabled = False
        Me.IdContoTextBox1.Visible = True
        Me.lblId.Visible = True
        MasterControl.Instance.ParentForm.Text = "Visualizzazione Conto"
        Me.cmdVisualizza.Visible = False
        Me.cboValuta.Enabled = False
    End Sub
    Protected Overrides Sub Nested_ClearWindowEditors()
        'Qui pulisco tutti i campi della maschera
        txtDescrizione.Text = ""
        cboValuta.Text = "Euro"
        Me.IdContoTextBox1.TextValue = ""
    End Sub
    Protected Overrides Sub Nested_LoadDataFromDataSource()
        'qui carico ordino il caricamento dei dati e carico le possibili scelte
        controllerConti.LoadById(Me.m_IdShowedObject)
    End Sub
    Protected Overrides Sub Nested_LoadEditorsProperties()
        txtDescrizione.Text = controllerConti.Descrizione
        cboValuta.Text = controllerConti.Valuta
        Me.IdContoTextBox1.TextValue = controllerConti.IdConto
    End Sub
#End Region


#Region "Metodi per la creazione di un nuovo oggetto"
    Protected Overrides Sub Nested_PrepareForCreation()
        Me.IdContoTextBox1.Enabled = False
        Me.IdContoTextBox1.Visible = False
        Me.lblId.Visible = False
        Me.TabControl1.Visible = True
        Me.cmdVisualizza.Visible = False
    End Sub
#End Region



#Region "Metodi per il salvataggio"

   Protected Overrides Sub Navigate()
      Try
         Dim ParameterList As Hashtable = New Hashtable
         ParameterList.Add("Id", m_IdShowedObject)
         Me.NavigateTo("ViewConto", ParameterList)
      Catch ex As Exception
         Throw New Exception(ex.Message)
      End Try
   End Sub
   Protected Overloads Sub Navigate(ByVal ToId As Int32)
      Try
         Dim ParameterList As Hashtable = New Hashtable
         ParameterList.Add("Id", ToId)
         Me.NavigateTo("ViewConto", ParameterList)
      Catch ex As Exception
         Throw New Exception(ex.Message)
      End Try
   End Sub
    Public Overrides Sub Nested_InsertData()
        Try
            controllerConti.CreateNew(txtDescrizione.Text, cboValuta.Text, "Feneal")
            MyBase.m_IdShowedObject = controllerConti.IdConto
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub
#End Region

   Private Sub cmdVisualizza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVisualizza.Click
      Try
         Navigate(Me.IdContoTextBox1.TextValue)
      Catch ex As Exception
         If TypeOf (ex) Is InvalidCastException Then
            ex = New Exception("L'id di ricerca non ha un formato valido oppure è nullo. Inserire un id corretto")
         End If
         ErrorHandler.ShowError(ex)
      End Try
   End Sub


#Region "Metodi per l'aggiornamento"


#End Region

    Public Overrides Sub Nested_UpdateData()
        controllerConti.Descrizione = txtDescrizione.Text
        controllerConti.Save()
    End Sub
   Private Sub txtDescrizione_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescrizione.TextChanged
        Me.StartChangeOperation()
   End Sub
End Class
