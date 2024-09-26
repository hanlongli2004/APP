Imports System.Reflection.Emit
Imports System.Threading
Imports System.Timers
Imports AxWMPLib

Public Class Form3
#Region "全域變數"
    Dim dn As Boolean
    Dim jump As Boolean = True
    Dim block As Boolean = False
    Dim count As Integer = 0
    Dim x, y, jump_h, a, b As Integer
    Dim Image_i = 1
    Dim PersonPos(1) As Integer
    Dim person As PictureBox
    Dim jumlimit As Boolean = False
    Dim stand_y, jump_y As Integer
    Dim playerMoveSpeed As Integer
    Dim upHasPressed, rightHasPressed, leftHasPressed, leftupHaspress, rightupHaspress As Boolean
    Property Stars3 As Integer = 0
#End Region
    Dim path = System.IO.Directory.GetParent(Application.StartupPath).FullName
    Dim path2 = System.IO.Directory.GetParent(path).FullName

    Declare Function SetParent Lib "user32" Alias "SetParent" (ByVal hWndChild As IntPtr, ByVal hWndNewParent As IntPtr) As Long

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


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
        Player1.settings.setMode("loop", True)
    End Sub
#Region "按下按鈕"

    Sub button_touch1()
        Dim PlayerPos As Rectangle = New Rectangle(person.Location, person.Size)
        Dim buttonBlue As Rectangle = New Rectangle(Blue.Location, Blue.Size)
        Dim buttonYellow As Rectangle = New Rectangle(Yellow.Location, Yellow.Size)
        Dim buttonPurple As Rectangle = New Rectangle(Purple.Location, Purple.Size)
        If PlayerPos.IntersectsWith(buttonBlue) Then

            If Blue.Tag <> 1 And person.Top < Blue.Top Then
                My.Computer.Audio.Play(My.Resources.按鈕, AudioPlayMode.WaitToComplete)

                Blue.Image = My.Resources.按鈕_藍_按下
                Timer1_Tick(blueplat, 100)
                Blue.Tag = 1

            End If
        ElseIf PlayerPos.IntersectsWith(buttonPurple) And person.Top < Purple.Top Then

            If Purple.Tag <> 1 Then
                My.Computer.Audio.Play(My.Resources.按鈕, AudioPlayMode.WaitToComplete)

                Purple.Image = My.Resources.按鈕_紫_按下
                Timer1_Tick(purpleplat, -100)
                Purple.Tag = 1
            End If
        ElseIf PlayerPos.IntersectsWith(buttonYellow) And person.Top < Yellow.Top Then

            If Yellow.Tag <> 1 Then
                My.Computer.Audio.Play(My.Resources.按鈕, AudioPlayMode.WaitToComplete)

                Yellow.Image = My.Resources.按鈕_黃_按下
                yellow_plat_橫.Left -= 230
                Timer1_Tick(yellow_plat_直, -120)
                box.Top = PictureBox2.Top - 40
                Yellow.Tag = 1

            End If
        End If
    End Sub
#End Region
#Region "平台移動"
    Private Sub Timer1_Tick(purpose As PictureBox, move As Integer)
        Dim o As Integer = purpose.Location.Y
        If purpose.Tag <> 1 Then

            If move > 0 Then
                While (purpose.Location.Y < o + move)
                    purpose.Top += 10

                End While
            Else
                While (purpose.Location.Y > o + move)
                    purpose.Top -= 10

                End While


            End If
            purpose.Tag = 1
        End If
    End Sub
#End Region
#Region "化學池"

    Sub chemPool_drop()
        '碰觸化學池
        If Touch(person, Toxic1) Then
            person.Dispose()
            Timer1.Stop()

            die()

        End If
        If Touch(person, Toxic2) Then
            person.Dispose()
            Timer1.Stop()

            die()
        End If

    End Sub
#End Region

#Region "角色死亡"
    Sub die()
        My.Computer.Audio.Play(My.Resources.死亡2, AudioPlayMode.WaitToComplete)
        If MsgBox("你死掉了!要重新嗎?", MsgBoxStyle.YesNo, "遊戲結束") = MsgBoxResult.Yes Then
            Me.Dispose()
            My.Forms.Form2.Dispose()
            My.Forms.Form3.Show()
        Else
            Me.Close()
            My.Computer.Audio.Play("..\..\m_set_63.wav", AudioPlayMode.BackgroundLoop)
            start.Show()
        End If

    End Sub
#End Region

#Region "門口"
    Sub door_open()

        If Touch(person, door) And purpleplat.Tag And door.Tag <> 1 Then
            door.Image = CType(My.Resources.門_開, System.Drawing.Image)
            door.Tag = 1
            start.Pass3 = True
            start.StarScore += Stars3
            WalkTime.Enabled = False
            MsgBox("you pass the mission!",, "success")

            Application.DoEvents()
            System.Threading.Thread.Sleep(1)
            Timer1.Stop()
            Me.Hide()
            start.Show()
        End If
    End Sub
#End Region
#Region "獲得星星"
    Sub Get_star()

        If Touch(person, PictureBox22) And PictureBox22.Tag <> 1 Then
            PictureBox22.Tag = 1
            Stars3 += 1
            PictureBox22.Dispose()
            My.Computer.Audio.Play(My.Resources.星星, AudioPlayMode.WaitToComplete)

        ElseIf Touch(person, PictureBox23) And PictureBox23.Tag <> 1 Then
            PictureBox23.Tag = 1
            Stars3 += 1
            PictureBox23.Dispose()
            My.Computer.Audio.Play(My.Resources.星星, AudioPlayMode.WaitToComplete)
        ElseIf Touch(person, PictureBox25) And PictureBox25.Tag <> 1 Then
            PictureBox25.Tag = 1
            Stars3 += 1
            PictureBox25.Dispose()
            My.Computer.Audio.Play(My.Resources.星星, AudioPlayMode.WaitToComplete)
        End If
    End Sub
#End Region
    '碰觸
    Function Touch(m, n) As Boolean
        Dim a As Rectangle = New Rectangle(m.Location, m.Size)
        Dim b As Rectangle = New Rectangle(n.Location, n.Size)

        Return a.IntersectsWith(b)

    End Function


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        button_touch1()
        chemPool_drop()
        door_open()
        Get_star()
        'blockit()
        'stand()
        'audio_play()

    End Sub
#Region "暫停"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Player2.URL = path2 & "\選擇.mp3"
        Player2.settings.autoStart = True
        Player2.settings.setMode("loop", False)
        Me.IsMdiContainer = True
        SetParent(pause3.Handle, Me.Handle)
        pause3.Show()
    End Sub
#End Region

    '人物位置
    Private Sub PersonPos_Tick(sender As Object, e As EventArgs) Handles PersonPosition.Tick

        x = person.Location.X
        y = person.Location.Y
        jump_h = 112

    End Sub
#Region "延遲"
    Sub Delay(T As Single)
        Dim Start As Integer = Environment.TickCount()
        Dim TimeLast As Integer = T * 1000
        Do
            If Environment.TickCount() - Start > TimeLast Then Exit Do
            Application.DoEvents()
        Loop
    End Sub
#End Region

#Region "人物移動"
    Sub playermove()
        limit()
        If person.Right > PictureBox5.Left + 5 And person.Right < PictureBox6.Right - 5 And person.Top + person.Height > PictureBox24.Top Then
            playerMoveSpeed = 10
        Else
            playerMoveSpeed = 40
        End If

        '左
        If leftHasPressed Then

            person.Image = My.Resources.站_左_
            person.Left -= playerMoveSpeed

            If changepic.Enabled = False Then
                changepic.Start()
            End If

            Call changepic_left()
            changepic.Stop()

        End If

        '右
        If rightHasPressed Then


            person.Left += playerMoveSpeed
            If changepic.Enabled = False Then
                changepic.Start()
            End If

            Call changepic_right()
            changepic.Stop()

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

            Delay(0.35)
            person.Top = stand_y

        End If




        '超出畫面(右)
        If person.Left + person.Width > Me.ClientSize.Width - 20 Then
            person.Left = ClientSize.Width - person.Width - 20
        End If
        '超出畫面(左)
        If person.Left < 20 Then
            person.Left = 20
        End If
        '超出畫面(上)
        If person.Top < 10 Then
            person.Top = 10
        End If

    End Sub
#End Region
#Region "走路"
    Sub changepic_right() Handles changepic.Tick
        person.Image = CType(My.Resources.ResourceManager.GetObject(Image_i), System.Drawing.Image)
        Image_i += 1
        If Image_i > 2 Then
            Image_i = 1
        End If
    End Sub

    Private Sub Walk_Tick(sender As Object, e As EventArgs) Handles WalkTime.Tick

        playermove()
        gravity()
    End Sub

    Sub changepic_left() Handles changepic.Tick
        person.Image = CType(My.Resources.ResourceManager.GetObject("0" & Image_i), System.Drawing.Image)
        Image_i += 1
        If Image_i > 2 Then
            Image_i = 1
        End If

    End Sub
#End Region
#Region "鍵盤操控"
    Private Sub Form3_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyValue = Keys.W Then
            upHasPressed = True

        End If
        If e.KeyValue = Keys.A Then
            leftHasPressed = True

        End If
        If e.KeyValue = Keys.D Then
            rightHasPressed = True

        End If


    End Sub

    Private Sub Form3_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If e.KeyValue = Keys.W Then

            upHasPressed = False
            jump = True

        End If
        If e.KeyValue = Keys.A Then
            leftHasPressed = False
            person.Image = My.Resources.站_左_
        End If
        If e.KeyValue = Keys.D Then
            rightHasPressed = False
            person.Image = My.Resources.站
        End If

    End Sub
#End Region

#Region "角色行走區域"
    Sub gravity()

        stand_y = y
        Dim Ground = Me.ClientSize.Height - 20 - person.Height
        If person.Top > Me.ClientSize.Height - 20 - person.Height Or (person.Top + person.Height > PictureBox9.Top And person.Right < PictureBox9.Right) Or (person.Top > blueplat.Top And blueplat.Tag = 1 And person.Left > blueplat.Left And person.Right < blueplat.Right) Or (person.Left > yellow_plat_橫.Right - 5 And person.Right < PictureBox1.Left + 5 And Yellow.Tag = 1 And person.Top > yellow_plat_橫.Top) Then
            person.Top = Ground

        End If
        If person.Top < PictureBox24.Top And person.Right >= PictureBox24.Left And person.Top > PictureBox12.Top Then

            stand_y = PictureBox24.Top
            person.Top = stand_y - person.Height
        ElseIf person.Top < PictureBox24.Top And person.Right < PictureBox24.Left And person.Left > PictureBox9.Right Then
            If (person.Left < blueplat.Left - 5 And person.Left > PictureBox9.Right - 5 And person.Top + person.Height > PictureBox9.Top) Or
                (person.Left > blueplat.Right - 5 And person.Left < PictureBox24.Left + 5 And person.Top + person.Height > PictureBox1.Top) Then
                person.Top = Ground
            End If
        End If
        If person.Top < blueplat.Top And person.Left < blueplat.Right - 8 And person.Left > blueplat.Left Then
            If person.Top > yellow_plat_橫.Top Then
                stand_y = blueplat.Top
                person.Top = stand_y - person.Height
            End If
        End If
        If person.Top + person.Height < PictureBox9.Top And person.Left < PictureBox9.Right Then
            If person.Top > PictureBox26.Top Then
                stand_y = PictureBox9.Top
                person.Top = stand_y - person.Height
            End If
        End If
        If person.Top + person.Height < yellow_plat_橫.Top And person.Left < yellow_plat_橫.Right And person.Left > yellow_plat_橫.Left Then
            If person.Top + person.Height > PictureBox26.Top Then
                stand_y = yellow_plat_橫.Top
                person.Top = stand_y - person.Height
            End If
        ElseIf person.Right < yellow_plat_橫.Left And person.Top < yellow_plat_橫.Top Then
            If person.Left > blueplat.Left - 8 Then
                stand_y = blueplat.Top
                person.Top = stand_y - person.Height
            ElseIf person.Left < blueplat.Left - 8 And person.Top + person.Height > Picturebox26.top Then
                person.Top = Ground
            End If

        End If
        If person.Top < PictureBox26.Top And person.Right >= PictureBox26.Left And person.Left < PictureBox26.Right Then

            stand_y = PictureBox26.Top
            person.Top = stand_y - person.Height
        ElseIf person.Top < PictureBox26.Top And person.Left < PictureBox26.Left Then
            stand_y = PictureBox9.Top
            person.Top = stand_y - person.Height
        End If
        If person.Left > PictureBox26.Right And person.Top + person.Height < yellow_plat_橫.Top And person.Left < yellow_plat_橫.Right Then
            stand_y = yellow_plat_橫.Top
            person.Top = stand_y - person.Height

        End If
        If person.Top + person.Height < PictureBox1.Top And person.Right > PictureBox1.Left + 8 And person.Left < PictureBox3.Right Then
            If Yellow.Tag = 1 Then

                If person.Right > box.Left And person.Left < box.Right And person.Top + person.Height < box.Top + box.Height Then

                    stand_y = box.Top
                    person.Top = stand_y - person.Height
                ElseIf (person.Right < box.Left And person.Left > PictureBox1.Left And person.Top < PictureBox1.Top) Then
                    stand_y = PictureBox1.Top
                    person.Top = stand_y - person.Height
                ElseIf (person.Left > box.Right - 10 And person.Right < PictureBox11.Left + 5 And person.Top < PictureBox1.Top) Then
                    stand_y = PictureBox1.Top
                    person.Top = stand_y - person.Height
                End If
            Else
                stand_y = PictureBox1.Top
                person.Top = stand_y - person.Height


            End If
        ElseIf person.Left > PictureBox3.Right - 8 And person.Top + person.Height > PictureBox11.Top And person.Right < PictureBox14.Left + 5 Then
            person.Top = Ground
        End If
        If person.Top < PictureBox11.Top And person.Right < PictureBox11.Right And person.Right > PictureBox11.Left Then

            stand_y = PictureBox11.Top
            person.Top = stand_y - person.Height

        End If
        If person.Left > PictureBox14.Left And person.Top < PictureBox12.Top And person.Right < PictureBox15.Left Then
            stand_y = PictureBox12.Top
            person.Top = stand_y - person.Height
        End If
        If person.Top + person.Height < PictureBox15.Top And person.Right > PictureBox15.Left + 5 Then
            stand_y = PictureBox15.Top
            person.Top = stand_y - person.Height
        End If
    End Sub
#End Region
#Region "移動限制"
    Sub limit()

        '設定角色不能穿過磚塊
        If person.Top > PictureBox9.Top And person.Left < PictureBox9.Right - 3 Then
            jumlimit = True
            jump_h = 80
        End If
        If person.Left > PictureBox1.Left + 1 And person.Right < PictureBox3.Right - 1 And person.Top > PictureBox3.Top Then
            jumlimit = True
            jump_h = 100
        End If
        If person.Left > PictureBox24.Left + 1 And person.Top > PictureBox24.Top Then
            jumlimit = True
            jump_h = 1
        End If
        If person.Left > PictureBox24.Left + 1 And person.Top < PictureBox24.Top And person.Top > Toxic2.Top Then
            jumlimit = True
            jump_h = 40
        End If
        If blueplat.Tag = 1 And person.Left > blueplat.Left And person.Right < blueplat.Right And person.Top > blueplat.Top Then
            jumlimit = True
            jump_h = 7
        End If
        If Yellow.Tag = 1 And person.Top > yellow_plat_橫.Top And person.Top < blueplat.Top And person.Left > yellow_plat_橫.Left + 2 And person.Right < yellow_plat_橫.Right - 1 Then
            jumlimit = True
            jump_h = 85

        End If
        If person.Left > PictureBox11.Left + 5 And person.Right < PictureBox3.Right And person.Top > PictureBox11.Top And person.Top < PictureBox3.Top Then
            jumlimit = True
            jump_h = 40
        End If

        '防止穿越箱子
        ' If Touch(person, box) Then
        'If person.Top + person.Height > box.Top And person.Left < box.Right Then
        'person.Left = box.Left - 40
        'End If
        'If person.Top + person.Height < box.Top And person.Left > box.Left Then

        '  person.Top = box.Top - person.Height
        ''  If person.Top + person.Height >= box.Top And person.Left > box.Right Then
        'person.Left = box.Right
        ''person.Top = PictureBox1.Top - person.Height

        'End If
        ' If person.Top + person.Height > box.Top And person.Right > box.Left Then
        'person.Left = box.Right
        'person.Top = PictureBox3.Top - person.Height

        'End If
        ' End If
    End Sub
#End Region
End Class


