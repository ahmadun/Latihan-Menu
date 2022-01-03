Public Class DoLooping
    Private Sub Btn_run_Click(sender As Object, e As EventArgs) Handles Btn_run.Click
        Dim a As Integer = 10
        Do
            Listboxs.Items.Add("value of " + a.ToString)
            a = a + 1
        Loop While (a < 20)
        Console.ReadLine()
    End Sub
End Class