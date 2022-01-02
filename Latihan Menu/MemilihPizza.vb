Imports System.Drawing.Imaging
Imports System.IO

Public Class MemilihPizza
    Private Sub MemilihPizza_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim paths As String
        paths = "..\..\Assets\img\"
        Pc_nea.Image = Image.FromFile(System.IO.Path.Combine(paths + "Neapolitan.JPG"))
        Pc_calz.Image = Image.FromFile(System.IO.Path.Combine(paths + "Kelzone.JPG"))
        Pc_ch.Image = Image.FromFile(System.IO.Path.Combine(paths + "Chichago.JPG"))
        Pc_gre.Image = Image.FromFile(System.IO.Path.Combine(paths + "Greek.JPG"))
        Pc_new.Image = Image.FromFile(System.IO.Path.Combine(paths + "NewYork.JPG"))
        Pc_kebab.Image = Image.FromFile(System.IO.Path.Combine(paths + "Kebab.JPG"))
        Pc_sic.Image = Image.FromFile(System.IO.Path.Combine(paths + "Sicilian.JPG"))
        Pc_cali.Image = Image.FromFile(System.IO.Path.Combine(paths + "California.JPG"))
        Pc_piss.Image = Image.FromFile(System.IO.Path.Combine(paths + "Pizzaldire.JPG"))
        Pc_tom.Image = Image.FromFile(System.IO.Path.Combine(paths + "Tomatto.JPG"))
    End Sub

    Private Sub SelectedPizzaPitc(sender As Object)
        Pc_selected.Image = sender.Image.Clone
    End Sub
    Private Sub Pc_nea_Click(sender As Object, e As EventArgs) Handles Pc_nea.Click
        SelectedPizzaPitc(sender)
        Lb_selected.Text = "Neapolitan"
    End Sub

    Private Sub Pc_calz_Click(sender As Object, e As EventArgs) Handles Pc_calz.Click
        SelectedPizzaPitc(sender)
        Lb_selected.Text = "Calzone"
    End Sub

    Private Sub Pc_ch_Click(sender As Object, e As EventArgs) Handles Pc_ch.Click
        SelectedPizzaPitc(sender)
        Lb_selected.Text = "Chicago-style"
    End Sub

    Private Sub Pc_gre_Click(sender As Object, e As EventArgs) Handles Pc_gre.Click
        SelectedPizzaPitc(sender)
        Lb_selected.Text = "Greek Pizza"
    End Sub

    Private Sub Pc_new_Click(sender As Object, e As EventArgs) Handles Pc_new.Click
        SelectedPizzaPitc(sender)
        Lb_selected.Text = "New York-style"
    End Sub

    Private Sub Pc_kebab_Click(sender As Object, e As EventArgs) Handles Pc_kebab.Click
        SelectedPizzaPitc(sender)
        Lb_selected.Text = "Kebab Pizza"
    End Sub

    Private Sub Pc_sic_Click(sender As Object, e As EventArgs) Handles Pc_sic.Click
        SelectedPizzaPitc(sender)
        Lb_selected.Text = "Sicilian"
    End Sub

    Private Sub Pc_cali_Click(sender As Object, e As EventArgs) Handles Pc_cali.Click
        SelectedPizzaPitc(sender)
        Lb_selected.Text = "California-style"
    End Sub

    Private Sub Pc_piss_Click(sender As Object, e As EventArgs) Handles Pc_piss.Click
        SelectedPizzaPitc(sender)
        Lb_selected.Text = "Pissaladière"
    End Sub

    Private Sub Pc_tom_Click(sender As Object, e As EventArgs) Handles Pc_tom.Click
        SelectedPizzaPitc(sender)
        Lb_selected.Text = "Tomato Pie"
    End Sub
End Class