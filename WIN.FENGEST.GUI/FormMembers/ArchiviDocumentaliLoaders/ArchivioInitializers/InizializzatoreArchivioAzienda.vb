Imports System.Windows.Forms
Public Class InizializzatoreArchivioAzienda
   Implements IInitializeFormArchivio






   Public Sub InitializeForm(ByVal frm As FrmArchivioDocumentale, ByVal lblCartella As System.Windows.Forms.Label, ByVal controller As ControllerArchivioDocumentale, ByVal split1 As SplitContainer, ByVal split3 As SplitContainer) Implements IInitializeFormArchivio.InitializeForm
      frm.Text += "  --  " & controller.Target.Descrizione
      lblCartella.Text += "  --  " & controller.Target.Descrizione
      lblCartella.Font = New Font(lblCartella.Font, FontStyle.Bold)
      split3.Panel1Collapsed = True
   End Sub

   Public Sub InitializeGrids(ByVal frm As FrmArchivioDocumentale) Implements IInitializeFormArchivio.InitializeGrids
      frm.InitializeGridArchivio()
   End Sub

   Public Sub LoadData(ByVal frm As FrmArchivioDocumentale, ByVal controller As ControllerArchivioDocumentale) Implements IInitializeFormArchivio.LoadData
      frm.LoadDirectoryPreferenziale()
      frm.LoadDatiArchivio()
      frm.lblNumDocs.Text = "Numero totale documenti trovati: " & controller.GetNumeroDocumenti.ToString

   End Sub
   Public Function GetSuggestedPath() As String Implements IInitializeFormArchivio.GetSuggestedPath
      Return My.Settings.PathDefaultCartelleAziende
   End Function

   Public Sub ResizeForm(ByVal frm As FrmArchivioDocumentale, ByVal split1 As System.Windows.Forms.SplitContainer, ByVal split2 As System.Windows.Forms.SplitContainer) Implements IInitializeFormArchivio.ResizeForm
      split1.SplitterDistance = 115
      'frm.SplitContainer2.SplitterDistance =frm.SplitContainer2.SplitterDistance 
      'frm.SplitContainer2.Size = New Size(frm.SplitContainer5.Width, frm.SplitContainer5.Height + 200)
      'frm.SplitContainer5.Size = New Size(frm.SplitContainer5.Width, frm.SplitContainer5.Height - 200)
      Dim d As Integer = frm.SplitContainer4.SplitterDistance
      frm.SplitContainer4.SplitterDistance = d + (frm.Size.Height - d - 115 - 100)
   End Sub
End Class
