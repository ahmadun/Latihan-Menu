Public Class TimerApp
    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
        Lb_time.Text = DateTime.Now
    End Sub

    Private Sub TimerApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer.Interval = 1000
    End Sub

    Private Sub Btn_start_Click(sender As Object, e As EventArgs) Handles Btn_start.Click
        If Timer.Enabled Then
            Timer.Stop()
            Btn_start.Text = "START"
        Else
            Timer.Start()
            Btn_start.Text = "STOP"
        End If
    End Sub
End Class