Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = ComboBox1.Text Then
            Me.Hide()
            Form2.Show()
        Else
            MsgBox("密碼錯誤")
        End If
    End Sub

End Class
