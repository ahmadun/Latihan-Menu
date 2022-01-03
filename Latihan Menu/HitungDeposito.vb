Public Class HitungDeposito
    Private Sub Btn_count_Click(sender As Object, e As EventArgs) Handles Btn_count.Click

        Dim skb As Double = Txt_sukubunga.Text / 100
        Dim rslt As Double
        rslt = (Txt_tabungan.Text * skb * 0.8 * 30) / 365
        Txt_rslt.Text = rslt.ToString("C2")
    End Sub
End Class