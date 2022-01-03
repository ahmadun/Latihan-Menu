Public Class MainForm
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutMenu.Click
        About.Show()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim paths As String
        paths = "..\..\Assets\img\"
        Pc.Image = Image.FromFile(System.IO.Path.Combine(paths + "Neapolitan.JPG"))
    End Sub

    Private Sub MengenalMethodsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MengenalMethodsToolStripMenuItem.Click
        MengenalMethode.Show()
    End Sub

    Private Sub MengenalScopeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MengenalScopeToolStripMenuItem.Click
        MengenalScope.Show()
    End Sub

    Private Sub AplikasiPenjumlahanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AplikasiPenjumlahanToolStripMenuItem.Click
        PenjumlahanCls.Show()
    End Sub

    Private Sub AplikasiPenghitungHurufToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AplikasiPenghitungHurufToolStripMenuItem.Click
        PenghitungHuruf.Show()
    End Sub

    Private Sub AplikasiMemilihJenisPizzaDenganGroupBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AplikasiMemilihJenisPizzaDenganGroupBoxToolStripMenuItem.Click
        MemilihPizza.Show()
    End Sub

    Private Sub AplikasiPilihBukuDenganListBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AplikasiPilihBukuDenganListBoxToolStripMenuItem.Click
        PemilihanBuku.Show()
    End Sub

    Private Sub AplikasiMenampilkanGambarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AplikasiMenampilkanGambarToolStripMenuItem.Click
        MenampilkanGambar.Show()
    End Sub

    Private Sub AplikasiSimpanTeksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AplikasiSimpanTeksToolStripMenuItem.Click
        SimpanTeks.Show()
    End Sub

    Private Sub AplikasiTimerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AplikasiTimerToolStripMenuItem.Click
        TimerApp.Show()
    End Sub

    Private Sub EnumerationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnumerationToolStripMenuItem.Click
        KenalEnum.Show()
    End Sub

    Private Sub UsernameDanPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsernameDanPasswordToolStripMenuItem.Click
        UserPass.Show()
    End Sub

    Private Sub AplikasiMenghitungDepositoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AplikasiMenghitungDepositoToolStripMenuItem.Click
        HitungDeposito.Show()
    End Sub

    Private Sub AplikasiForNextToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AplikasiForNextToolStripMenuItem.Click
        ForNextLoop.Show()
    End Sub

    Private Sub AplikasiDoLoopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AplikasiDoLoopToolStripMenuItem.Click
        DoLooping.Show()
    End Sub

    Private Sub MencariLuasDanKelilingPersegiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MencariLuasDanKelilingPersegiToolStripMenuItem.Click
        RumusLuasPSG.Show()
    End Sub
End Class
