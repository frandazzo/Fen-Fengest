Imports System.Drawing.Printing
Public Class FrmSelectPrinter
   Dim strOldPrinter As String
   Dim WshNetwork As Object
   Dim pd As New Printing.PrintDocument

    Dim m_printernName As String = ""

    Public ReadOnly Property PrinterName() As String
        Get
            Return m_printernName
        End Get
    End Property


   Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click

        m_printernName = pd.PrinterSettings.PrinterName

        ChangeDefaultPrinter(m_printernName)


      Me.DialogResult = Windows.Forms.DialogResult.OK
      Me.Close()
   End Sub

   Private Sub cmdAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAnnulla.Click
      Me.DialogResult = Windows.Forms.DialogResult.Cancel
      Me.Close()
   End Sub

   Private Sub FrmSelectPrinter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
      PopulateInstalledPrintersListBox()
   End Sub



   Private Sub PopulateInstalledPrintersListBox()
      ' Add list of installed printers found to the combo box.
      ' The pkInstalledPrinters string will be used to provide the display string.
      Dim i As Integer
      Dim pkInstalledPrinters As String

      ComboBox1.Items.Clear()

      For i = 0 To PrinterSettings.InstalledPrinters.Count - 1
         pkInstalledPrinters = PrinterSettings.InstalledPrinters.Item(i)
         'pd.PrinterSettings.PrinterName = pkInstalledPrinters
         ComboBox1.Items.Add(pkInstalledPrinters)
      Next
      Try
         ComboBox1.SelectedIndex = 0
      Catch ex As Exception

      End Try

   End Sub

   Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
      ' Set the printer to a printer in the combo box when the selection changes.

      If ComboBox1.SelectedIndex <> -1 Then
         ' The combo box's Text property returns the selected item's text, which is the printer name.
         pd.PrinterSettings.PrinterName = ComboBox1.SelectedItem
      End If
   End Sub





   Private Function ChangeDefaultPrinter(ByVal strPrinterName As String) As Boolean


      Try


         strOldPrinter = pd.PrinterSettings.PrinterName

         WshNetwork = Microsoft.VisualBasic.CreateObject("WScript.Network")

         WshNetwork.SetDefaultPrinter(strPrinterName)

         pd.PrinterSettings.PrinterName = strPrinterName

         If pd.PrinterSettings.IsValid Then

            Return True

         Else

            WshNetwork.SetDefaultPrinter(strOldPrinter)

            Return False

         End If

      Catch exptd As Exception

         WshNetwork.SetDefaultPrinter(strOldPrinter)

         Return False

      Finally

         WshNetwork = Nothing

         pd = Nothing

      End Try
   End Function







End Class