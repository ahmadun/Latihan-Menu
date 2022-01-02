Public Class MengenalScope


    Private Sub Btn_pub_Click(sender As Object, e As EventArgs) Handles Btn_pub.Click
        Txt_rsl.Text = ScopeVar.strPub
    End Sub

    Protected strPro As String = "DATA INI PROTECTED"
    Private Sub Btn_pro_Click(sender As Object, e As EventArgs) Handles Btn_pro.Click
        Txt_val.Text = strPro
    End Sub

    Private Sub Btn_fr_Click(sender As Object, e As EventArgs) Handles Btn_fr.Click
        Txt_fr.Text = ScopeVar.strFr
    End Sub

    Protected Friend prf As String = "INI DARA PROTECTED FRIEND"
    Private Sub Btn_pf_Click(sender As Object, e As EventArgs) Handles Btn_pf.Click
        Txt_pf.Text = prf
    End Sub

    Private prvt As String = "INI DATA PRIVATE"
    Private Sub Btn_prv_Click(sender As Object, e As EventArgs) Handles Btn_prv.Click
        Txt_prv.Text = prvt
    End Sub

    Private Sub Btn_local_Click(sender As Object, e As EventArgs) Handles Btn_local.Click
        Dim lcl As String = "INI DATA LOACL"
        Txt_local.Text = lcl
    End Sub
End Class