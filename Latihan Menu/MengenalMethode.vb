Public Class MengenalMethode
    Private Sub Btn_check_Click(sender As Object, e As EventArgs) Handles Btn_check.Click
        Lb_hasil.Text = FindMax(Txt_bil1.Text, Txt_bil2.Text)
    End Sub

    Function FindMax(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
        Dim result As Integer

        If (num1 > num2) Then
            result = num1
        Else
            result = num2
        End If
        FindMax = result
    End Function
End Class