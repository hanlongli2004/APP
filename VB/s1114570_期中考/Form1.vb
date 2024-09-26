Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar

Public Class Form1
    Const ROW = 4
    Const COL = 4
    Const BOOM = 3
    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        Dim ret1
        Dim ret2

        PictureBox17.Image = My.Resources.boom
        ret1 = MsgBox("遊戲結束 ~ ", MsgBoxStyle.OkOnly)

        If ret1 = MsgBoxResult.Ok Then
            ret2 = MsgBox("是否重開一局 ?", MsgBoxStyle.YesNo)

            If ret2 = MsgBoxResult.No Then
                End
            End If
        End If
    End Sub
    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        Dim ret1
        Dim ret2

        PictureBox18.Image = My.Resources.boom
        ret1 = MsgBox("遊戲結束 ~ ", MsgBoxStyle.OkOnly)

        If ret1 = MsgBoxResult.Ok Then
            ret2 = MsgBox("是否重開一局 ?", MsgBoxStyle.YesNo)

            If ret2 = MsgBoxResult.No Then
                End
            End If
        End If
    End Sub
    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click
        Dim ret1
        Dim ret2

        PictureBox20.Image = My.Resources.boom
        ret1 = MsgBox("遊戲結束 ~ ", MsgBoxStyle.OkOnly)

        If ret1 = MsgBoxResult.Ok Then
            ret2 = MsgBox("是否重開一局 ?", MsgBoxStyle.YesNo)

            If ret2 = MsgBoxResult.No Then
                End
            End If
        End If
    End Sub
    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        PictureBox6.Image = My.Resources.ResourceManager.GetObject("02")
    End Sub
    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        PictureBox7.Image = My.Resources.ResourceManager.GetObject("02")
    End Sub
    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        PictureBox14.Image = My.Resources.ResourceManager.GetObject("02")
    End Sub
    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        PictureBox15.Image = My.Resources.ResourceManager.GetObject("02")
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        PictureBox3.Image = My.Resources.ResourceManager.GetObject("01")
    End Sub
    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        PictureBox4.Image = My.Resources.ResourceManager.GetObject("01")
    End Sub
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        PictureBox5.Image = My.Resources.ResourceManager.GetObject("01")
    End Sub
    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        PictureBox16.Image = My.Resources.ResourceManager.GetObject("01")
    End Sub
    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        PictureBox19.Image = My.Resources.ResourceManager.GetObject("01")
    End Sub
    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        PictureBox11.Image = My.Resources.ResourceManager.GetObject("01")
    End Sub
    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        PictureBox12.Image = My.Resources.ResourceManager.GetObject("01")
    End Sub
    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        PictureBox13.Image = My.Resources.ResourceManager.GetObject("01")
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PictureBox1.Image = My.Resources.ResourceManager.GetObject("")
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PictureBox2.Image = My.Resources.ResourceManager.GetObject("")
    End Sub
    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        PictureBox8.Image = My.Resources.ResourceManager.GetObject("")
    End Sub
    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        PictureBox9.Image = My.Resources.ResourceManager.GetObject("")
    End Sub
    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        PictureBox10.Image = My.Resources.ResourceManager.GetObject("")
    End Sub
    Private Sub PictureBox21_Click(sender As Object, e As EventArgs) Handles PictureBox21.Click
        PictureBox21.Image = My.Resources.ResourceManager.GetObject("")
    End Sub
    Private Sub PictureBox22_Click(sender As Object, e As EventArgs) Handles PictureBox22.Click
        PictureBox22.Image = My.Resources.ResourceManager.GetObject("")
    End Sub
    Private Sub PictureBox23_Click(sender As Object, e As EventArgs) Handles PictureBox23.Click
        PictureBox23.Image = My.Resources.ResourceManager.GetObject("")
    End Sub
    Private Sub PictureBox24_Click(sender As Object, e As EventArgs) Handles PictureBox24.Click
        PictureBox24.Image = My.Resources.ResourceManager.GetObject("")
    End Sub
    Private Sub PictureBox25_Click(sender As Object, e As EventArgs) Handles PictureBox25.Click
        PictureBox25.Image = My.Resources.ResourceManager.GetObject("")
    End Sub
End Class
