Public Class PemilihanBuku
    Private Sub PemilihanBuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckedListBox1.Items.Add("VB.NET")
        CheckedListBox1.Items.Add("Java")
        CheckedListBox1.Items.Add("Python")
        CheckedListBox1.Items.Add("C")
        CheckedListBox1.Items.Add("C#")
        CheckedListBox1.Items.Add("PHP")
        CheckedListBox1.Items.Add("JavaScript")
        CheckedListBox1.Items.Add("Ruby Language")
        CheckedListBox1.Items.Add("Android")
        CheckedListBox1.Items.Add("Perl")
    End Sub

    Private Sub Btn_select_Click(sender As Object, e As EventArgs) Handles Btn_select.Click
        Dim cheq As New System.Text.StringBuilder
        For Each item In CheckedListBox1.CheckedItems
            cheq.Append(item)
            cheq.Append(" ")
        Next
        Txt_box.Text = " Your Checked Items are : " & cheq.ToString()
    End Sub
End Class