Public Class Form1

    Private MultiArray(2, 2) As String


    Private Sub BtnGetElement_Click(sender As Object, e As EventArgs) Handles BtnGetElement.Click
        MultiArray(0, 0) = " Position 0,0"
        MultiArray(0, 1) = " Position 0,1"
        MultiArray(0, 2) = " Position 0,2"
        MultiArray(1, 0) = " Position 1,2"
        MultiArray(1, 1) = " Position 1,1"
        MultiArray(1, 2) = " Position 1,2"
        MultiArray(2, 0) = " Position 2,0"
        MultiArray(2, 1) = " Position 2,1 Penis"
        MultiArray(2, 2) = " Position 2,2"
        Dim xpos As Integer = CType(TxtFirstDimension.Text, Integer)
        Dim ypos As Integer = CType(TxtSecondDimension.Text, Integer)
        MessageBox.Show(MultiArray(xpos, ypos))
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
