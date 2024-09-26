Imports System.Threading
Imports System.Timers
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar
Imports AxWMPLib
Imports Microsoft.VisualBasic.Logging

Public Class Form2
#Region "全域變數"
    Dim butColor As Windows.Forms.Button() = New Windows.Forms.Button(3) {}
    Dim PlayMode As AudioPlayMode
    Dim distance = 20
    Dim timer_2 As Integer = 0
    Dim timer_3 As Integer = 0
    Dim timer_4 As Integer = 0
    Dim Count = 0, Count_2 = 0

    Dim i = 1
    Dim upHasPressed, rightHasPressed, leftHasPressed, leftupHaspress, rightupHaspress As Boolean
    Dim x, y As Integer
    Dim stand_y, jump_y, jump_h As Integer
    Dim playerMoveSpeed As Integer
    Dim image_i = 1, TButton
    Dim person As PictureBox
    Dim jump As Boolean = True
    Dim block, jumlimit As Boolean
    Property Stars2 As Integer = 0
#End Region
    Dim path = System.IO.Directory.GetParent(Application.StartupPath).FullName
    Dim path2 = System.IO.Directory.GetParent(path).FullName
    Declare Function SetParent Lib "user32" Alias "SetParent" (ByVal hWndChild As IntPtr, ByVal hWndNewParent As IntPtr) As Long
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Me.KeyPreview = True
        person = New PictureBox
        Me.Controls.Add(person)
#Region "角色設定"
        With person
            .Image = CType(My.Resources.idle_removebg_preview, System.Drawing.Image)
            .Size = New Size(40, 80)
            .Location = New Point(30, Me.ClientSize.Height - 20 - person.Height)
            .Visible = True
            .SizeMode = PictureBoxSizeMode.StretchImage
            person.BackColor = Color.Transparent
            person.BringToFront()
        End With
#End Region

        Player1.URL = path2 & "\tamfu01.wav"
        Player1.settings.autoStart = True
        Player1.settings.setMode("loop", True)
        Button2.Enabled = True
        Button3.Enabled = False
        Button1.Enabled = False

    End Sub
#Region "機關觸發"
    Sub Fish_Activated()
        Dim PlayerPos As Rectangle = New Rectangle(person.Location, person.Size)
        Dim chemPool1 As New Rectangle(toxic.Location.X + 10, toxic.Location.Y - 3, toxic.Width - 10, toxic.Height - 10)
        '黃色平台觸發
        If Touch(person, Yellow) And Yellow.Tag <> 1 Then
            My.Computer.Audio.Play(My.Resources.按鈕,
            AudioPlayMode.WaitToComplete)
            Yellow.Tag = 1
            Timer1.Start()

        End If

        '傳送門1觸發
        If Touch(person, protrol) And person.Left < protrol.Left + 30 Then

            My.Computer.Audio.Play(My.Resources.傳送門, AudioPlayMode.WaitToComplete)
            person.Location = New Point(protrol2.Left - 30, protrol2.Top)

        End If
        '傳送門2觸發
        If Touch(person, protrol2) And person.Right > protrol2.Left + 10 Then
            My.Computer.Audio.Play(My.Resources.傳送門, AudioPlayMode.WaitToComplete)
            person.Location = New Point(protrol.Left + 30, protrol.Top)

        End If

        '紫色藥劑獲得,柵欄打開
        If Touch(person, P1) Then
            P1.Tag = 1
            P1.Dispose()
            'Count = 1
        End If
        If Touch(person, P2) Then
            P2.Tag = 1
            P2.Dispose()

        End If

        If (P1.Tag And P2.Tag) Then
            fence1.Tag = 1
            fence1.Dispose()
            Count = 2
        End If



        '藍色平台觸發
        If Touch(person, Blue) And Blue.Tag <> 1 Then
            Blue.Image = CType(My.Resources.按鈕_藍_按下, System.Drawing.Image)
            Blue.Tag = 1
            Timer3.Start()
            My.Computer.Audio.Play(My.Resources.按鈕,
             AudioPlayMode.WaitToComplete)
        ElseIf Touch(person, Blueplat) Then
            Timer3.Stop()
        End If
        '紫色平台出現消失
        If Touch(person, Purple) And Purple.Tag <> 1 Then
            Purple.Tag = 1
            Purple.Image = CType(My.Resources.按鈕_紫_按下, System.Drawing.Image)
            Timer4.Start()
            My.Computer.Audio.Play(My.Resources.按鈕,
              AudioPlayMode.WaitToComplete)
        End If
        If PlayerPos.IntersectsWith(chemPool1) Then
            start_1.Stop()
            person.Dispose()
            die()
        End If
        If Touch(person, PictureBox39) Then
            Button5.Enabled = True
            Button3.Enabled = True
            Button1.Enabled = True

        End If

    End Sub
#End Region
    Sub voice()
        My.Computer.Audio.Play(My.Resources.柵欄1,
         AudioPlayMode.WaitToComplete)
    End Sub
    Sub voice1()
        My.Computer.Audio.Stop()
    End Sub
#Region "獲得星星"
    Sub Get_star()

        If Touch(person, PictureBox42) And PictureBox42.Tag <> 1 Then
            PictureBox42.Tag = 1
            Stars2 += 1
            PictureBox42.Dispose()
            My.Computer.Audio.Play(My.Resources.星星, AudioPlayMode.WaitToComplete)

        ElseIf Touch(person, PictureBox43) And PictureBox43.Tag <> 1 Then
            PictureBox43.Tag = 1
            Stars2 += 1
            PictureBox43.Dispose()
            My.Computer.Audio.Play(My.Resources.星星, AudioPlayMode.WaitToComplete)
        ElseIf Touch(person, PictureBox44) And PictureBox44.Tag <> 1 Then
            PictureBox44.Tag = 1
            Stars2 += 1
            PictureBox44.Dispose()
            My.Computer.Audio.Play(My.Resources.星星, AudioPlayMode.WaitToComplete)
        End If
    End Sub
#End Region
#Region "門口"
    Sub door_open()

        If Touch(person, door) And Purple.Tag And door.Tag <> 1 Then
            door.Image = CType(My.Resources.門_開, System.Drawing.Image)
            door.Tag = 1
            My.Computer.Audio.Play(My.Resources.門開, AudioPlayMode.WaitToComplete)
            WalkTime.Enabled = False
            MsgBox("you pass the mission!",, "success")
            start.Pass2 = True
            start.StarScore += Stars2
            Application.DoEvents()
            System.Threading.Thread.Sleep(1)

            Me.Dispose()
            My.Computer.Audio.Play("..\..\m_set_63.wav", AudioPlayMode.BackgroundLoop)
            start.Show()
        End If
    End Sub
#End Region

#Region "遊戲死亡"

    Sub die()
        My.Computer.Audio.Play(My.Resources.死亡2, AudioPlayMode.WaitToComplete)
        start_1.Stop()
        If MsgBox("你死掉了!要重新嗎?", MsgBoxStyle.YesNo, "遊戲結束") = MsgBoxResult.Yes Then

            My.Forms.Form2.Dispose()
            My.Forms.Form2.Show()
        Else
            Me.Close()
            My.Computer.Audio.Play("..\..\m_set_63.wav", AudioPlayMode.BackgroundLoop)
            start.Show()

        End If

    End Sub
#End Region
#Region "人物移動"
    Sub playermove()

        playerMoveSpeed = 35
        '左
        If leftHasPressed Then

            person.Refresh()
            person.Image = My.Resources.站_左_

            If person.Left - 35 < PictureBox2.Right And person.Left > PictureBox2.Left And person.Top > PictureBox1.Top Then
                person.Left -= 0
            Else
                person.Left -= playerMoveSpeed
            End If

            If Timer5.Enabled = False Then
                Timer5.Start()
            End If

            Call changepic_left()
            Timer5.Stop()

        End If

        '右
        If rightHasPressed Then

            If person.Left + 40 > PictureBox23.Left And person.Right < PictureBox21.Left + 5 And person.Top + person.Height > PictureBox21.Top And Not upHasPressed Or person.Left + 40 > PictureBox18.Left And person.Right < PictureBox18.Right And person.Top + person.Height > PictureBox21.Top Then
                person.Left += 0
            Else
                person.Left += playerMoveSpeed
            End If
            If Timer5.Enabled = False Then
                Timer5.Start()
            End If
            Call changepic_right()
            Timer5.Stop()
        End If

        '上
        If upHasPressed Then

            stand_y = y
            If jump Then
                If jumlimit Then
                    jump_y = stand_y - jump_h
                    jump = False
                    jumlimit = False
                Else
                    jump_y = stand_y - 112
                    jump = False
                End If
            Else
                jump_y = y
            End If



            person.Top = jump_y
            delay(0.25)
            person.Top = stand_y



        End If
        '超出畫面(右)
        If person.Right > Me.ClientSize.Width - 20 Then
            person.Left = ClientSize.Width - 20 - person.Width
        End If
        '超出畫面(左)
        If person.Left < 20 Then
            person.Left = 20
        End If
        '超出畫面(上)
        If person.Top < 20 Then
            person.Top = 20
        End If

    End Sub
#End Region
#Region "延遲"
    Sub delay(T As Single)
        Dim Start As Integer = Environment.TickCount()
        Dim TimeLast As Integer = T * 1000
        Do
            If Environment.TickCount() - Start > TimeLast Then Exit Do
            Application.DoEvents()
        Loop
    End Sub
#End Region
#Region "走路"
    Sub changepic_right()
        person.Image = CType(My.Resources.ResourceManager.GetObject(image_i), System.Drawing.Image)
        image_i += 1
        If image_i > 2 Then
            image_i = 1
        End If
    End Sub

    Sub changepic_left()
        person.Image = CType(My.Resources.ResourceManager.GetObject("0" & image_i), System.Drawing.Image)
        image_i += 1
        If image_i > 2 Then
            image_i = 1
        End If

    End Sub
    Private Sub Walk_Tick(sender As Object, e As EventArgs) Handles WalkTime.Tick


        playermove()
        gravity()
        door_open()
        Get_star()
        ' trap_touch()
    End Sub
#End Region

#Region "鍵盤操控"
    Private Sub Form4_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyValue = Keys.W Then
            upHasPressed = True
            block = False
        End If


        If e.KeyValue = Keys.A Then leftHasPressed = True
        If e.KeyValue = Keys.D Then
            rightHasPressed = True
            block = False
        End If


    End Sub

    Private Sub Form4_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyValue = Keys.W Then
            upHasPressed = False
            jump = True

        End If
        If e.KeyValue = Keys.A Then
            leftHasPressed = False
            person.Image = CType(My.Resources.站_左_, System.Drawing.Image)
        End If
        If e.KeyValue = Keys.D Then
            rightHasPressed = False
            person.Image = CType(My.Resources.站, System.Drawing.Image)
        End If




    End Sub
#End Region

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Yellow_plat.Top + Yellow_plat.Height < toxic.Top Then
            Yellow_plat.Top = Yellow_plat.Top + distance

        Else
            Timer1.Stop()

        End If
    End Sub
#Region "暫停"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Player2.URL = path2 & "\選擇.mp3"
        Player2.settings.autoStart = True
        Player2.settings.setMode("loop", False)
        Me.IsMdiContainer = True
        SetParent(pause2.Handle, Me.Handle)
        pause2.Show()
    End Sub
#End Region

    Private Sub Start_Tick(sender As Object, e As EventArgs) Handles start_1.Tick
        Fish_Activated()
        ' trap_touch()
        limit()
        ' blockit()
        x = person.Location.X
        y = person.Location.Y
    End Sub

#Region "提示圖"
    Private Sub PictureBox39_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox39.MouseEnter
        PictureBox39.Height = PictureBox39.Height + 100
        PictureBox39.Width = PictureBox39.Width + 100
    End Sub
    Private Sub PictureBox39_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox39.MouseLeave
        PictureBox39.Height = PictureBox39.Height - 100
        PictureBox39.Width = PictureBox39.Width - 100
    End Sub
#End Region

#Region "平台出現"
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Timer3.Interval = 1000
        timer_3 = timer_3 + 1
        If timer_3 Mod 2 = 1 Then
            Blueplat.Visible = True
        Else
            Blueplat.Visible = False
        End If

    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Timer4.Interval = 1000

        timer_4 = timer_4 + 1
        If timer_4 Mod 2 = 1 Then
            Purpleplat.Visible = False
        Else
            Purpleplat.Visible = True
        End If
    End Sub
#End Region
    Function Touch(m As PictureBox, n As PictureBox) As Boolean
        Dim a As Rectangle = New Rectangle(m.Location, m.Size)
        Dim b As Rectangle = New Rectangle(n.Location, n.Size)
        Return a.IntersectsWith(b)
    End Function
#Region "按鈕機關"
    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button3.Click, Button1.Click, Button2.Click
        My.Computer.Audio.Play(My.Resources.功能按鈕,
             AudioPlayMode.WaitToComplete)
        If sender.tag = i Then
            i += 1
            If i > 3 Then
                fence2.Visible = False
                My.Computer.Audio.Play(My.Resources.柵欄1,
             AudioPlayMode.WaitToComplete)
                fence2.Tag = 1
            End If
        Else

            If MsgBox("順序錯誤" & vbCrLf & "要重來一次嗎?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1, "Gameover") = MsgBoxResult.Yes Then

                Me.Dispose()
                My.Forms.Form2.Dispose()
                My.Forms.Form2.Show()


            Else
                Me.Close()
                start.Show()
            End If

        End If

    End Sub
#End Region
#Region "角色行走區域"
    Sub gravity()          '


        '  Dim y = person.Location.Y
        stand_y = y
        Dim Ground = Me.ClientSize.Height - 20 - person.Height
        If person.Top > Me.ClientSize.Height - 20 - person.Height Or (person.Left > PictureBox22.Right And person.Right < PictureBox18.Left And person.Top > PictureBox1.Top + 20) Then
            person.Top = Ground
        End If
        If person.Right >= PictureBox17.Left + 5 And person.Right < PictureBox17.Right And person.Top < PictureBox17.Top + 5 And person.Top + person.Height > PictureBox12.Top Then
            If person.Right < PictureBox21.Left Then
                stand_y = PictureBox17.Top
                person.Top = stand_y - person.Height
            End If
        ElseIf person.Left < PictureBox17.Left + 10 And person.Top > PictureBox11.Top And person.Top <= PictureBox17.Top Then
            person.Top = Ground
        End If

        If person.Right > PictureBox21.Left + 15 And person.Left < PictureBox22.Right - 10 And person.Top < PictureBox21.Top And person.Top > PictureBox9.Top Then

            stand_y = PictureBox21.Top
            person.Top = PictureBox21.Top - person.Height

        ElseIf person.Right > PictureBox22.Right + 25 And person.Right < PictureBox18.Left And person.Top <= PictureBox21.Top And person.Top > PictureBox1.Top + 20 Then
            person.Top = Ground

        End If
        If person.Left < Yellow_plat.Right And person.Right > Yellow_plat.Left And person.Top + person.Height < Yellow_plat.Top + Yellow_plat.Height And person.Top > PictureBox9.Top Then
            If Yellow.Tag = 1 Then

                stand_y = Yellow_plat.Top
                person.Top = stand_y - person.Height
            End If
        End If
        If person.Left < PictureBox9.Right + 50 And person.Left > PictureBox12.Left And person.Top + person.Height < PictureBox9.Top And person.Top > PictureBox7.Top + 20 Then
            If person.Top + person.Height < PictureBox9.Top + PictureBox9.Height Then
                stand_y = PictureBox9.Top
                person.Top = stand_y - person.Height
            End If
        End If
        If person.Left < Blueplat.Right - 15 And person.Right > Blueplat.Left And person.Top + person.Height < Blueplat.Top + Blueplat.Height Then
            Timer3.Stop()
            Blueplat.Visible = True
            stand_y = Blueplat.Top
            person.Top = stand_y - person.Height

            If person.Top + person.Height > PictureBox7.Top And person.Right < PictureBox7.Left And person.Left > Blueplat.Right And person.Top < PictureBox9.Top Or person.Right < Blueplat.Left And person.Top + person.Height > PictureBox8.Top And person.Top + person.Height < PictureBox9.Top Then

                stand_y = PictureBox9.Top
                person.Top = stand_y - person.Height
            End If



        End If

        If person.Top + person.Height < PictureBox7.Top + 20 And person.Right >= PictureBox7.Left + 20 And person.Right < PictureBox1.Right Then


            stand_y = PictureBox7.Top
            person.Top = stand_y - person.Height
        End If


        If person.Top + person.Height > PictureBox7.Top And person.Right < PictureBox7.Left And person.Left > Blueplat.Right And person.Top < PictureBox9.Top Then
            stand_y = PictureBox9.Top
            person.Top = stand_y - person.Height
        End If


        If person.Top + person.Height < PictureBox8.Top + 20 And person.Left <= PictureBox8.Right - 10 Then

            stand_y = PictureBox8.Top
            person.Top = stand_y - person.Height
        End If
        If person.Right > PictureBox1.Right + 25 And person.Top < PictureBox1.Top Then
            If person.Right < PictureBox15.Left And person.Top < PictureBox14.Top Then
                delay(0.15)
                stand_y = PictureBox14.Top
                person.Top = stand_y - person.Height
            End If
            If person.Right > PictureBox14.Right + 25 And person.Top < PictureBox14.Top Then
                delay(0.15)
                stand_y = PictureBox15.Top
                person.Top = stand_y - person.Height

            End If
        End If
        If person.Right < PictureBox15.Left And person.Top < PictureBox15.Top And person.Left > PictureBox18.Right And person.Top > PictureBox14.Top Then
            delay(0.2)

            person.Top = Ground
        End If

    End Sub
#End Region
#Region "移動限制"

    Sub limit()
        If person.Top < PictureBox21.Top And person.Top > PictureBox9.Top And person.Right > PictureBox21.Left And person.Right < PictureBox22.Right Then
            jumlimit = True
            jump_h = 60
        ElseIf person.Left < PictureBox19.Right And person.Right > Yellow_plat.Left And person.Top < Yellow_plat.Top + Yellow_plat.Height And person.Top > PictureBox9.Top Then
            If Yellow.Tag = 1 Then
                jumlimit = True
                jump_h = 30
            End If
        End If
    End Sub
#End Region
End Class

