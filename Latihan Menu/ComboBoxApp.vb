Public Class ComboBoxApp


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Txt_selected.Text = ComboBox1.SelectedItem
    End Sub
End Class