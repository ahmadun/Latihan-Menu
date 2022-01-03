Public Class ForNextLoop
    Private Sub Btn_run_Click(sender As Object, e As EventArgs) Handles Btn_run.Click
        Dim a As Byte
        ' for loop execution 
        For a = 10 To 20
            Listboxs.Items.Add("value of " + a.ToString)
        Next
        Console.ReadLine()
    End Sub
End Class