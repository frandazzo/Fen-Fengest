
Imports System.Windows.Forms
Imports WIN.APPLICATION.FINANCIAL_ARTIFACTS

Public Class GridLoaderRicerchePGR
   Inherits GridLoaderNewPGR

   Public Sub New(ByVal Grid As DataGridView)
      MyBase.New(Grid)
   End Sub
   Protected Overrides Sub LoadCustomListProperties(ByVal list As System.Collections.IList)
      MyBase.LoadCustomListProperties(list)
      'If Not m_Grid.Columns.Contains("Selezione") Then
      '   Dim selCol As New DataGridViewCheckBoxColumn(False)
      '   selCol.IndeterminateValue = False
      '   MyBase.m_Grid.Columns.Add(selCol)
      '   selCol.Name = "Selezione"
      '   selCol.HeaderText = "Seleziona"
      '   selCol.DisplayIndex = 0
      '   selCol.FalseValue = False
      '   selCol.TrueValue = True
      'End If
      'm_Grid.Columns("ImpRist").ReadOnly = True
      'selCol.IndeterminateValue = ""
      m_Grid.Columns("Selezione").Visible = True
      m_Grid.Columns("Selezione").DisplayIndex = 0
      If m_Grid.Columns.Contains("ImpRist") Then
         m_Grid.Columns("ImpRist").Visible = False
      End If
      If m_Grid.Columns.Contains("ImportoRistorno") Then
         m_Grid.Columns("ImportoRistorno").Visible = False
      End If


   End Sub
End Class
