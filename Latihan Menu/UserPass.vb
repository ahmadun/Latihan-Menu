Public Class UserPass



    Private Sub Btn_login_Click(sender As Object, e As EventArgs) Handles Btn_login.Click
        If Txt_user.Text = "admin" And Txt_pass.Text = "admin" Then
            MsgBox("Log in Successfully!", MsgBoxStyle.OkOnly, "Log in Form")
            Me.Hide()
        Else
            MsgBox("Sorry Incorrect Username and Password", MsgBoxStyle.OkOnly, "Invalid")
        End If
    End Sub
End Class