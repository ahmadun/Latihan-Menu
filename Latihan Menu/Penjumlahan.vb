Public Class PenjumlahanCls
    Private Sub Btn_tambah_Click(sender As Object, e As EventArgs) Handles Btn_tambah.Click
        Lb_operasi.Text = "+"
        Txt_bil2.Select()
    End Sub

    Private Sub Btn_hasil_Click(sender As Object, e As EventArgs) Handles Btn_hasil.Click
        If Txt_bil1.Text = "" Or Txt_bil2.Text = "" Or Lb_operasi.Text = "" Then
            Return
        End If

        Dim oper As String
        Dim bil1 As Int32
        Dim bil2 As Int32

        bil1 = Convert.ToInt32(Txt_bil1.Text)
        bil2 = Convert.ToInt32(Txt_bil2.Text)

        oper = Lb_operasi.Text
        Select Case oper
            Case "+"
                Txt_hasil.Text = (bil1 + bil2).ToString
            Case "-"
                Txt_hasil.Text = (bil1 - bil2).ToString
            Case "X"
                Txt_hasil.Text = (bil1 * bil2).ToString
            Case "/"
                Txt_hasil.Text = (bil1 / bil2).ToString

        End Select


    End Sub

    Private Sub Btn_bagi_Click(sender As Object, e As EventArgs) Handles Btn_bagi.Click
        Lb_operasi.Text = "/"
        Txt_bil2.Select()
    End Sub

    Private Sub Btn_kali_Click(sender As Object, e As EventArgs) Handles Btn_kali.Click
        Lb_operasi.Text = "X"
        Txt_bil2.Select()
    End Sub

    Private Sub Btn_kurang_Click(sender As Object, e As EventArgs) Handles Btn_kurang.Click
        Lb_operasi.Text = "-"
        Txt_bil2.Select()
    End Sub

    Private Sub Btn_7_Click(sender As Object, e As EventArgs) Handles Btn_7.Click
        If Lb_operasi.Text = "" Then
            Txt_bil1.Text += "7"
        Else
            Txt_bil2.Text += "7"
        End If


    End Sub

    Private Sub Btn_4_Click(sender As Object, e As EventArgs) Handles Btn_4.Click
        If Lb_operasi.Text = "" Then
            Txt_bil1.Text += "4"
        Else
            Txt_bil2.Text += "4"
        End If
    End Sub

    Private Sub Btn_8_Click(sender As Object, e As EventArgs) Handles Btn_8.Click
        If Lb_operasi.Text = "" Then
            Txt_bil1.Text += "8"
        Else
            Txt_bil2.Text += "8"
        End If
    End Sub

    Private Sub Btn_9_Click(sender As Object, e As EventArgs) Handles Btn_9.Click
        If Lb_operasi.Text = "" Then
            Txt_bil1.Text += "9"
        Else
            Txt_bil2.Text += "9"
        End If
    End Sub

    Private Sub Btn_5_Click(sender As Object, e As EventArgs) Handles Btn_5.Click
        If Lb_operasi.Text = "" Then
            Txt_bil1.Text += "5"
        Else
            Txt_bil2.Text += "5"
        End If
    End Sub

    Private Sub Btn_6_Click(sender As Object, e As EventArgs) Handles Btn_6.Click
        If Lb_operasi.Text = "" Then
            Txt_bil1.Text += "6"
        Else
            Txt_bil2.Text += "76"
        End If
    End Sub

    Private Sub Btn_1_Click(sender As Object, e As EventArgs) Handles Btn_1.Click
        If Lb_operasi.Text = "" Then
            Txt_bil1.Text += "1"
        Else
            Txt_bil2.Text += "1"
        End If
    End Sub

    Private Sub Btn_2_Click(sender As Object, e As EventArgs) Handles Btn_2.Click
        If Lb_operasi.Text = "" Then
            Txt_bil1.Text += "2"
        Else
            Txt_bil2.Text += "2"
        End If
    End Sub

    Private Sub Btn_3_Click(sender As Object, e As EventArgs) Handles Btn_3.Click
        If Lb_operasi.Text = "" Then
            Txt_bil1.Text += "3"
        Else
            Txt_bil2.Text += "3"
        End If
    End Sub

    Private Sub Btn_0_Click(sender As Object, e As EventArgs) Handles Btn_0.Click
        If Lb_operasi.Text = "" Then
            Txt_bil1.Text += "0"
        Else
            Txt_bil2.Text += "0"
        End If
    End Sub

    Private Sub Btn_koma_Click(sender As Object, e As EventArgs) Handles Btn_koma.Click
        If Lb_operasi.Text = "" Then
            Txt_bil1.Text += ","
        Else
            Txt_bil2.Text += ","
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Txt_bil1.Text = ""
        Txt_bil2.Text = ""
        Txt_hasil.Text = ""
        Lb_operasi.Text = ""
    End Sub
End Class