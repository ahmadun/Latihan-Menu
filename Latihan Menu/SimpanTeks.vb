Imports System.IO

Public Class SimpanTeks
    Private Sub Btn_save_Click(sender As Object, e As EventArgs) Handles Btn_save.Click
        Dim strFile As String = System.IO.Path.Combine("..\..\Data\file.txt")
        Dim fileExists As Boolean = File.Exists(strFile)
        Using sw As New StreamWriter(File.Open(strFile, FileMode.OpenOrCreate))

            For Each line As String In Txt_teksin.Lines
                sw.WriteLine(line)
            Next
        End Using
        GetTxt()
    End Sub

    Private Sub GetTxt()
        Dim strFile As String = System.IO.Path.Combine("..\..\Data\file.txt")
        Dim fileExists As Boolean = File.Exists(strFile)
        If fileExists = True Then
            Txt_boxout.Text = System.IO.File.ReadAllText(System.IO.Path.Combine("..\..\Data\file.txt"))
        End If

    End Sub

    Private Sub SimpanTeks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetTxt()
    End Sub
End Class