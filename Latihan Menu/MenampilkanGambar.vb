Imports System.IO

Public Class MenampilkanGambar
    Private Sub Btn_load_Click(sender As Object, e As EventArgs) Handles Btn_load.Click
        Dim mystream As Stream = Nothing

        'Open the File to pickup icon for Loan Calculator
        Dim OpenFileDialog1 As New OpenFileDialog

        'Set up and display the open File Dialog
        With OpenFileDialog1
            'Begin in the current Directory
            .InitialDirectory = "C:\"
            .Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        End With

        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                mystream = OpenFileDialog1.OpenFile()
                If (mystream IsNot Nothing) Then
                    Txt_box.Text = OpenFileDialog1.FileName
                    PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)

                End If
            Catch Ex As Exception
                MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
            Finally
                ' Check this again, since we need to make sure we didn't throw an exception on open. 
                If (mystream IsNot Nothing) Then
                    mystream.Close()
                End If
            End Try
        End If
    End Sub
End Class