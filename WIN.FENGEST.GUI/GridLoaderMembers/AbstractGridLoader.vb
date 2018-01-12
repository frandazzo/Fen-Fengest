Imports System.Windows.Forms
Public MustInherit Class AbstractGridLoader
   Protected m_Grid As DataGridView
    Protected m_SelectionMode As DataGridViewSelectionMode = DataGridViewSelectionMode.CellSelect

   Protected m_RowHeadersWidthSizeMode As DataGridViewRowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.EnableResizing
   Protected m_AutoSizeColumnsMode As DataGridViewAutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

   Public Property SelectionMode() As DataGridViewSelectionMode
      Get
         Return m_SelectionMode
      End Get
      Set(ByVal value As DataGridViewSelectionMode)
         m_SelectionMode = value
      End Set
   End Property
   Public Property RowHeadersWidthSizeMode() As DataGridViewRowHeadersWidthSizeMode
      Get
         Return m_RowHeadersWidthSizeMode
      End Get
      Set(ByVal value As DataGridViewRowHeadersWidthSizeMode)
         m_RowHeadersWidthSizeMode = value
      End Set
   End Property
   Public Property AutoSizeColumnsMode() As DataGridViewAutoSizeColumnsMode
      Get
         Return m_AutoSizeColumnsMode
      End Get
      Set(ByVal value As DataGridViewAutoSizeColumnsMode)
         m_AutoSizeColumnsMode = value
      End Set
   End Property

   Public Sub New(ByVal DataGrid As DataGridView)
      m_Grid = DataGrid
   End Sub
   Public Sub LoadGrid(ByVal Lista As IList)
      Try
         With m_Grid

            'Dim bind As New BindingSource
            'bind.DataSource = Lista
            '.DataSource = bind

            .DataSource = Lista
                If Lista.Count > 0 Then
                    .AutoGenerateColumns = False
                    HideSupertupeProperties()
                    LoadCustomListProperties(Lista)
                End If
                SetMainSettings()
         End With
      Catch ex As Exception
         Throw New Exception("Impossibile caricare la lista nella griglia." & vbCrLf & ex.Message)
      End Try
   End Sub

   Protected MustOverride Sub LoadCustomListProperties(ByVal list As IList)
   Protected Overridable Sub HideSupertupeProperties()
      m_Grid.Columns("Key").Visible = False
      m_Grid.Columns("Versione").Visible = False
      m_Grid.Columns("CreatoDa").Visible = False
      m_Grid.Columns("ModificatoDa").Visible = False
      m_Grid.Columns("DataCreazione").Visible = False
      m_Grid.Columns("DataModifica").Visible = False
      m_Grid.Columns("Descrizione").Visible = False
      m_Grid.Columns("Id").Visible = False
   End Sub

   Protected Overridable Sub SetMainSettings()
      m_Grid.SelectionMode = m_SelectionMode
      m_Grid.RowHeadersWidthSizeMode = m_RowHeadersWidthSizeMode
      m_Grid.AutoSizeColumnsMode = m_AutoSizeColumnsMode
      m_Grid.Visible = True
   End Sub
End Class
