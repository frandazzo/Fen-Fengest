Imports System.Windows.Forms
Public Interface IInitializeFormArchivio

   Sub InitializeForm(ByVal frm As FrmArchivioDocumentale, ByVal lblCartella As Label, ByVal controller As ControllerArchivioDocumentale, ByVal split1 As SplitContainer, ByVal split3 As SplitContainer)
   Sub InitializeGrids(ByVal frm As FrmArchivioDocumentale)
   Sub LoadData(ByVal frm As FrmArchivioDocumentale, ByVal controller As ControllerArchivioDocumentale)
   Function GetSuggestedPath() As String
   Sub ResizeForm(ByVal frm As FrmArchivioDocumentale, ByVal split1 As SplitContainer, ByVal split2 As SplitContainer)


End Interface
