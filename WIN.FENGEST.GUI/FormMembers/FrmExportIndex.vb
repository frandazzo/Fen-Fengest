Public Class FrmExportIndex

    Private m_Total As Int32 = 0


    Public Max As Int32
    Public Min As Int32



    Public Sub New(ByVal totalRows As Int32)

        InitializeComponent()

        m_Total = totalRows


        Min = 0
        Max = 499

        CorrectIndexes(0)



    End Sub

    Private Sub CorrectIndexes(ByVal start As Int32)

        If start > m_Total Then
            NumericUpDown1.Value = m_Total - 499
            Max = m_Total
            Min = m_Total - 499
            Return
        End If


        If (start + 499) >= m_Total Then

            lblMax.Text = (m_Total).ToString
            Max = (m_Total)
            Min = start
        Else
            lblMax.Text = (start + 499).ToString
            Max = start + 499
            Min = start
        End If
    End Sub



    Private Sub NumericUpDown1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumericUpDown1.ValueChanged

        CorrectIndexes(Convert.ToInt32(NumericUpDown1.Value))

    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()

    End Sub

    Private Sub cmdOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class