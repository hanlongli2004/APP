Public Class start
    Property StarScore As Integer = 0
    Property Pass1 As Boolean = False
    Property Pass2 As Boolean = False
    Property Pass3 As Boolean = False
    Dim clear As PictureBox
    Dim but As Button() = New Button(2) {}
    Dim path = System.IO.Directory.GetParent(Application.StartupPath).FullName
    Dim path2 = System.IO.Directory.GetParent(path).FullName
    Private Sub start_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        My.Computer.Audio.Play("..\..\m_set_63.wav", AudioPlayMode.BackgroundLoop)

    End Sub
#Region "選擇關卡"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Audio.Stop()
        Me.Hide()
        Form2.Close()
        Form3.Close()
        Form1.Show()

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Computer.Audio.Stop()
        Me.Hide()
        Form3.Close()
        Form1.Close()
        Form2.Show()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Computer.Audio.Stop()
        Me.Hide()
        Form1.Close()
        Form2.Close()
        Form3.Show()
    End Sub
#End Region

#Region "選擇按鈕"
    Private Sub Mouse1_enter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        If Button1.Tag <> 1 Then
            Button1.Width += 4
            Button1.Height += 4
            Button1.Top -= 2
            Button1.Left -= 2
            Button1.Tag = 1
            Player1.URL = path2 & "\開始按鈕.mp3"

        End If
    End Sub
    Private Sub Mouse2_enter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        If Button2.Tag <> 1 Then
            Button2.Width += 4
            Button2.Height += 4
            Button2.Top -= 2
            Button2.Left -= 2
            Button2.Tag = 1
            Player1.URL = path2 & "\開始按鈕.mp3"
        End If
    End Sub
    Private Sub Mouse3_enter(sender As Object, e As EventArgs) Handles Button3.MouseEnter

        If Button3.Tag <> 1 Then
            Button3.Width += 4
            Button3.Height += 4
            Button3.Top -= 2
            Button3.Left -= 2
            Button3.Tag = 1
            Player1.URL = path2 & "\開始按鈕.mp3"
        End If
    End Sub
    Private Sub Mouse1_leave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        If Button1.Tag <> 0 Then
            Button1.Width -= 4
            Button1.Height -= 4

            Button1.Top += 2
            Button1.Left += 2
            Button1.Tag = 0
        End If
    End Sub
    Private Sub Mouse2_leave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        If Button2.Tag <> 0 Then
            Button2.Width -= 4
            Button2.Height -= 4
            Button2.Top += 2
            Button2.Left += 2
            Button2.Tag = 0
        End If
    End Sub
    Private Sub Mouse3_leave(sender As Object, e As EventArgs) Handles Button3.MouseLeave

        If Button3.Tag <> 0 Then
            Button3.Width -= 4
            Button3.Height -= 4
            Button3.Top += 2
            Button3.Left += 2
            Button3.Tag = 0
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = StarScore.ToString
        If Pass1 = True Then
            Button1.Enabled = False
        End If
        If Pass2 = True Then
            Button2.Enabled = False
        End If
        If Pass3 = True Then
            Button3.Enabled = False
        End If
        allpass()
    End Sub

#End Region

#Region "全部通關"
    Sub allpass()
        If Pass1 And Pass2 And Pass3 Then
            clear = New PictureBox
            Me.Controls.Add(clear)

            With clear
                .Image = CType(My.Resources.win, Image)
                .Size = New Size(400, 300)
                .Location = New Point(GroupBox1.Left - 60, GroupBox1.Top)
                .SizeMode = PictureBoxSizeMode.StretchImage
                .BorderStyle = BorderStyle.FixedSingle
            End With
            clear.BringToFront()
            For i = 0 To 1
                but(i) = New Button
                Me.Controls.Add(but(i))
                but(i).Size = New Size(100, 40)
                but(i).Location = New Point(clear.Left + (i + 1) * 150 - 70, clear.Top + 250)
                but(i).BringToFront()
            Next
            but(0).Text = "重新闖關"
            but(1).Text = "結束遊戲"
            AddHandler but(0).Click, AddressOf restart
            AddHandler but(1).Click, AddressOf CloseGame
        End If

    End Sub
    Sub restart()
        Me.Dispose()
        Application.Restart()
    End Sub
    Sub CloseGame()
        Me.Close()
    End Sub
#End Region
End Class