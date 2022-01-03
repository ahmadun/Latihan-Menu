Public Class RumusLuasPSG
    Private Sub Btn_hit_Click(sender As Object, e As EventArgs) Handles Btn_hit.Click
        Txt_luas.Text = HitungRumusLuas(Txt_leb.Text, Txt_pan.Text)
        Txt_kel.Text = HitungRumusKel(Txt_leb.Text, Txt_pan.Text)
    End Sub

    Function HitungRumusLuas(leb As Double, pan As Double) As Int32
        Return (leb * pan)
    End Function
    Function HitungRumusKel(leb As Double, pan As Double) As Int32
        Return (leb + pan) * 2
    End Function
End Class