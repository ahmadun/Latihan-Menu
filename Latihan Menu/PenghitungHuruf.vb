Public Class PenghitungHuruf
    Private Sub Txt_box_TextChanged(sender As Object, e As EventArgs) Handles Txt_box.TextChanged
        Lb_count_huruf.Text = Txt_box.Text.Replace(" ", "").Replace("\r\n", "").Count.ToString
    End Sub
End Class