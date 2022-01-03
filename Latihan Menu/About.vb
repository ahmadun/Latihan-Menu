Public Class About
    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Lb_nama.Text = "Reni Wahdini"
        Lb_No.Text = "081285265466"
        Lb_fc.Text = "kepo"
        Lb_ins.Text = "kepo"


        Dim paths As String
        paths = "..\..\Assets\img\"
        Pc_foto.Image = Image.FromFile(System.IO.Path.Combine(paths + "baju.JPG"))
    End Sub

    Private Sub Pc_foto_Click(sender As Object, e As EventArgs) Handles Pc_foto.Click

    End Sub
End Class