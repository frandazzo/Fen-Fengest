Imports System.Windows.Forms
Public Class InizializzatoreArchivioSegreteria
   Implements IInitializeFormArchivio






   Public Sub InitializeForm(ByVal frm As FrmArchivioDocumentale, ByVal lblCartella As System.Windows.Forms.Label, ByVal controller As ControllerArchivioDocumentale, ByVal split1 As SplitContainer, ByVal split3 As SplitContainer) Implements IInitializeFormArchivio.InitializeForm
      frm.Text += "  --  Segreteria provinciale "
      split1.Panel1Collapsed = True
      split3.Panel1Collapsed = True
   End Sub

   Public Sub InitializeGrids(ByVal frm As FrmArchivioDocumentale) Implements IInitializeFormArchivio.InitializeGrids
      frm.InitializeGridArchivio()
   End Sub

   Public Sub LoadData(ByVal frm As FrmArchivioDocumentale, ByVal controller As ControllerArchivioDocumentale) Implements IInitializeFormArchivio.LoadData
      'frm.LoadDirectoryPreferenziale()
      frm.LoadDatiArchivio()
      'frm.LoadDatiAttivita()
      frm.lblNumDocs.Text = "Numero totale documenti trovati: " & controller.GetNumeroDocumenti.ToString

   End Sub

   Public Function GetSuggestedPath() As String Implements IInitializeFormArchivio.GetSuggestedPath
      Return ""
   End Function

   Public Sub ResizeForm(ByVal frm As FrmArchivioDocumentale, ByVal split1 As System.Windows.Forms.SplitContainer, ByVal split2 As System.Windows.Forms.SplitContainer) Implements IInitializeFormArchivio.ResizeForm
      split2.SplitterDistance = frm.Size.Height - 100
      frm.SplitContainer5.Size = New Size(frm.SplitContainer5.Width, 100)
   End Sub
End Class
