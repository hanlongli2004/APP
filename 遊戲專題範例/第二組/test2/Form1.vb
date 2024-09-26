Imports System.Reflection.Emit
Imports System.Threading

Public Class Form1
#Region "全域變數"
    Dim upHasPressed, rightHasPressed, leftHasPressed, leftupHaspress, rightupHaspress As Boolean
    Dim x, y As Integer
    Dim stand_y, jump_y, jump_h As Integer
    Dim playerMoveSpeed As Integer
    Dim image_i = 1
    Dim t As Integer = 0
    Dim person As PictureBox
    Dim jump As Boolean = True
    Dim pass As Boolean = False
    Dim jumlimit As Boolean = False
    Property Stars1 As Integer = 0
#End Region
    Dim path = System.IO.Directory.GetParent(Application.StartupPath).FullName
    Dim path2 = System.IO.Directory.GetParent(path).FullName
    Declare Function SetParent Lib "user32" Alias "SetParent" (ByVal hWndChild As IntPtr, ByVal hWndNewParent As IntPtr) As Long


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.CenterToScreen()
        Me.KeyPreview = True
        ' My.Computer.Audio.Play("..\..\tamfu01.wav", AudioPlayMode.BackgroundLoop)
        ' AxWindowsMediaPlayer1.settings.autoStart = False
        Player1.URL = path2 & "\tamfu01.wav"
        Player1.settings.setMode("loop", True)
#Region "人物設定"
        person = New PictureBox
        Me.Controls.Add(person)
        person.Image = CType(My.Resources.idle_removebg_preview, System.Drawing.Image)
        person.Size = New Size(40, 80)
        person.Location = New Point(100, Me.ClientSize.Height - 20 - person.Height)
        person.Visible = True
        person.SizeMode = PictureBoxSizeMode.StretchImage
        person.BackColor = Color.Transparent
        person.BringToFront()
#End Region
        Timer2.Enabled = True
        WalkTime.Enabled = True
    End Sub

#Region "觸碰按鈕"
    Sub button_touch1()
        Dim PlayerPos As Rectangle = New Rectangle(person.Location, person.Size)
        Dim buttonBlue As Rectangle = New Rectangle(Blue.Location, Blue.Size)
        Dim buttonYellow As Rectangle = New Rectangle(Purple.Location, Purple.Size)
        Dim buttonPurple As Rectangle = New Rectangle(Yellow.Location, Yellow.Size)

        If PlayerPos.IntersectsWith(buttonBlue) And person.Left > Blue.Left Then
            If Blue.Tag <> 1 Then
                Timer2.Enabled = False
                Blue.Image = My.Resources.按鈕_藍_按下
                ' person.Top += 3

                Timer1_Tick(blueplat, 60)
                Blue.Tag = 1

                My.Computer.Audio.Play(My.Resources.按鈕,
           AudioPlayMode.WaitToComplete)
            End If
        ElseIf PlayerPos.IntersectsWith(buttonYellow) And person.Left > Purple.Left Then
            If Purple.Tag <> 1 Then
                Timer2.Enabled = False
                Purple.Image = My.Resources.按鈕_紫_按下
                ' person.Top += 3

                Timer1_Tick(purpleplat, -100)
                Purple.Tag = 1

                My.Computer.Audio.Play(My.Resources.按鈕,
           AudioPlayMode.WaitToComplete)
            End If
        ElseIf PlayerPos.IntersectsWith(buttonPurple) And person.Left > Yellow.Left Then
            If Yellow.Tag <> 1 Then
                Timer2.Enabled = False
                Yellow.Image = My.Resources.按鈕_黃_按下
                'person.Top += 3


                Timer1_Tick(Yellow_plat, -90)
                Yellow.Tag = 1

                My.Computer.Audio.Play(My.Resources.按鈕,
           AudioPlayMode.WaitToComplete)

            End If
        End If
    End Sub
#End Region
#Region "獲得星星"
    Sub Get_star()
        Dim PlayerPos As Rectangle = New Rectangle(person.Location, person.Size)
        Dim Star1 As Rectangle = New Rectangle(PictureBox27.Location, PictureBox27.Size)
        Dim Star2 As Rectangle = New Rectangle(PictureBox29.Location, PictureBox29.Size)
        Dim Star3 As Rectangle = New Rectangle(PictureBox28.Location, PictureBox28.Size)

        If PlayerPos.IntersectsWith(Star1) And PictureBox27.Tag <> 1 Then
            PictureBox27.Tag = 1
            Stars1 += 1
            PictureBox27.Dispose()
            My.Computer.Audio.Play(My.Resources.星星,
               AudioPlayMode.WaitToComplete)
        ElseIf PlayerPos.IntersectsWith(Star2) And PictureBox29.Tag <> 1 Then
            PictureBox29.Tag = 1

            Stars1 += 1
            PictureBox29.Dispose()
            My.Computer.Audio.Play(My.Resources.星星,
               AudioPlayMode.WaitToComplete)


        ElseIf PlayerPos.IntersectsWith(Star3) And PictureBox28.Tag <> 1 Then
            PictureBox28.Tag = 1

            Stars1 += 1
            PictureBox28.Dispose()
            My.Computer.Audio.Play(My.Resources.星星,
               AudioPlayMode.WaitToComplete)
        End If

    End Sub
#End Region
#Region "陷阱"
    Sub trap_touch()
        Dim Ground = Me.ClientSize.Height - 20 - person.Height
        Dim PlayerPos As Rectangle = New Rectangle(person.Location, person.Size)
        Dim Fencel As New Rectangle(Me.fence.Location.X, Me.fence.Location.Y + Me.fence.Height - 25, Me.fence.Width - 30, Me.fence.Height - 75)
        Dim chemPool1 As New Rectangle(toxic1.Location.X, toxic1.Location.Y - 3, toxic1.Width - 30, toxic1.Height - 10)


        If PlayerPos.IntersectsWith(Fencel) And fence.Tag = 1 Or PlayerPos.IntersectsWith(chemPool1) Then
            WalkTime.Enabled = False
            person.Dispose()
            Timer2.Enabled = False
            My.Computer.Audio.Play(My.Resources.死亡2, AudioPlayMode.WaitToComplete)
            If MsgBox("You lose" & vbCrLf & "要重來一次嗎?", MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton1, "Gameover") = MsgBoxResult.Yes Then

                Me.Dispose()
                start.StarScore -= Stars1
                My.Forms.Form1.Dispose()
                My.Forms.Form1.Show()

            Else
                Me.Close()
                My.Computer.Audio.Play("..\..\m_set_63.wav", AudioPlayMode.BackgroundLoop)
                start.Show()
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
                    purpose.Top += 50

                End While
            Else
                While (purpose.Location.Y > o + move)
                    purpose.Top -= 50

                End While


            End If
            purpose.Tag = 1
        End If
    End Sub
#End Region
#Region "柵欄"
    Private Sub fencetime_Tick(sender As Object, e As EventArgs) Handles fencetime.Tick

        t += 1
        If t Mod 2 = 0 Then
            fence.Tag = 1
            fence.Visible = True

        Else
            fence.Tag = 0
            fence.Visible = False

        End If
    End Sub
#End Region
#Region "門口"
    Sub door_open()
        Dim PlayerPos As Rectangle = New Rectangle(person.Location, person.Size)
        Dim Door As Rectangle = New Rectangle(Me.door.Location, Me.door.Size)
        If PlayerPos.IntersectsWith(Door) And Purple.Tag Then

            Me.door.Image = CType(My.Resources.門_開, System.Drawing.Image)

            Timer2.Enabled = False
            WalkTime.Enabled = False
            MsgBox("you pass the mission!",, "success")

            Application.DoEvents()
            System.Threading.Thread.Sleep(1)
            start.Pass1 = True
            start.StarScore += Stars1
            Me.Hide()
            start.Show()
        End If
    End Sub
#End Region

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        x = person.Location.X
        y = person.Location.Y
        button_touch1()

        trap_touch()
        Get_star()

    End Sub
#Region "角色移動"
    Sub playermove()

        ' Dim loc = person.Top + person.Height
        If person.Right > PictureBox5.Left + 5 And person.Right < PictureBox6.Right - 5 And person.Top + person.Height > PictureBox12.Top And person.Top < PictureBox5.Top Then
            playerMoveSpeed = 10
        Else
            playerMoveSpeed = 40
        End If
        '左
        If leftHasPressed Then


            person.Refresh()
            person.Left -= playerMoveSpeed
            If Timer1.Enabled = False Then
                Timer1.Start()
            End If

            Call changepic_left()
            Timer1.Stop()
            door_open()
        End If

        '右
        If rightHasPressed Then
            person.Left += playerMoveSpeed
            If Timer1.Enabled = False Then
                Timer1.Start()
            End If

            Call changepic_right()
            Timer1.Stop()
            door_open()
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

                    jump_y = stand_y - 115
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
        If person.Top < 0 Then
            person.Top = 0
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not pass And Yellow.Tag = 1 Then
            door_open()

        End If
    End Sub
#Region "暫停"
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Player2.URL = path2 & "\選擇.mp3"
        Player2.settings.autoStart = True
        Player2.settings.setMode("loop", False)
        Me.IsMdiContainer = True
        SetParent(pause1.Handle, Me.Handle)
        pause1.Show()
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

    Private Sub Walk_Tick(sender As Object, e As EventArgs) Handles WalkTime.Tick
        person.Refresh()
        Timer2.Enabled = True
        playermove()
        gravity()
        Limit()

    End Sub

    Sub changepic_left()
        person.Image = CType(My.Resources.ResourceManager.GetObject("0" & image_i), System.Drawing.Image)
        image_i += 1
        If image_i > 2 Then
            image_i = 1
        End If

    End Sub
#End Region

#Region "鍵盤操控"
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyValue = Keys.W Then
            upHasPressed = True
            y = person.Location.Y
        End If
        If e.KeyValue = Keys.A Then leftHasPressed = True
        If e.KeyValue = Keys.D Then rightHasPressed = True


    End Sub


    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
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
#Region "行走區域"
    Sub gravity()


        stand_y = y
        Dim Ground = Me.ClientSize.Height - 20 - person.Height
        If person.Top > Me.ClientSize.Height - 20 - person.Height Or person.Top > PictureBox3.Top Or (person.Left > PictureBox7.Right And person.Top + person.Height > PictureBox8.Top) Then
            person.Top = Ground

        End If
        If person.Top < 10 Then
            person.Top = 11
        End If


        If person.Right >= PictureBox3.Left And person.Right <= PictureBox7.Right And person.Top <= PictureBox3.Top And person.Top + person.Height > PictureBox12.Top Then
            If person.Top + person.Height > PictureBox2.Top And person.Left > PictureBox2.Right And person.Top > PictureBox16.Top And person.Top > PictureBox12.Top Then
                ' delay(0.15)

                stand_y = PictureBox3.Top
                person.Top = stand_y - person.Height

            End If

        ElseIf (person.Left < PictureBox3.Left And person.Top < PictureBox3.Top And person.Top + person.Height > PictureBox2.Top) Then

            ' delay(0.15)
            person.Top = Ground

        End If

        If person.Left < PictureBox2.Right And person.Left > toxic1.Left - 2 And person.Top <= PictureBox2.Top And person.Top > blueplat.Top Then
            ' delay(0.15)
            ' If person.Left > PictureBox15.Right And person.Top > PictureBox15.Top Then
            stand_y = PictureBox2.Top
            person.Top = stand_y - person.Height
            ' End If

        ElseIf person.Left > PictureBox2.Right And person.Right < PictureBox12.Left And person.Top <= PictureBox3.Top And person.Top > PictureBox16.Top And person.Top + person.Height > PictureBox12.Top And person.Top > blueplat.Top Then


            delay(0.15)
            stand_y = PictureBox3.Top
            person.Top = stand_y - person.Height

        End If

        If person.Left < blueplat.Right - 25 And person.Top < blueplat.Top Then
            stand_y = blueplat.Top
            person.Top = stand_y - person.Height

        ElseIf person.Left > blueplat.Right And person.Top > PictureBox15.Top + 5 And person.Left < PictureBox2.Right And person.Top <= PictureBox2.Top Then
            stand_y = PictureBox2.Top
            person.Top = stand_y - person.Height

        End If
        If person.Right >= PictureBox15.Left And person.Right <= PictureBox16.Right And person.Top < PictureBox15.Top + 5 And person.Top > 10 Then
            ' delay(0.15)
            stand_y = PictureBox15.Top
            person.Top = stand_y - person.Height

        ElseIf person.Left > PictureBox16.Right And person.Top <= PictureBox15.Top + PictureBox15.Height And person.Right < PictureBox25.Right And person.Top > 10 Then
            stand_y = PictureBox12.Top
            person.Top = stand_y - person.Height
        End If
        If (person.Left > PictureBox12.Left And person.Right < PictureBox14.Right) And person.Top < PictureBox12.Top And person.Top > PictureBox17.Top + 30 Then
            stand_y = PictureBox12.Top
            person.Top = stand_y - person.Height

        ElseIf (person.Right - 20 < PictureBox12.Left And person.Left > PictureBox2.Right) Then
            If person.Top > PictureBox16.Top And person.Top < PictureBox12.Top And person.Top > PictureBox17.Top + PictureBox17.Height Then
                stand_y = PictureBox3.Top
                person.Top = stand_y - person.Height

            End If

        End If
        If person.Right >= Yellow_plat.Left And person.Left < Yellow_plat.Right - 10 And person.Top < Yellow_plat.Top + Yellow_plat.Height Then
            stand_y = Yellow_plat.Top
            person.Top = stand_y - person.Height
        ElseIf (person.Right < fence.Left And person.Right > PictureBox14.Right) And person.Top > PictureBox18.Top And person.Top < PictureBox7.Top Then
            stand_y = PictureBox3.Top
            person.Top = stand_y - person.Height
        ElseIf person.Right > Yellow_plat.Right And person.Top < Yellow_plat.Top + Yellow_plat.Height And person.Right > PictureBox8.Left Then
            stand_y = PictureBox8.Top
            person.Top = stand_y - person.Height
        End If
        If person.Right >= PictureBox8.Left + 25 And person.Top > Yellow_plat.Top + Yellow_plat.Height And person.Top <= PictureBox8.Top Then
            stand_y = PictureBox8.Top
            person.Top = stand_y - person.Height

        End If
        If person.Left < PictureBox18.Right And person.Left > PictureBox25.Left And person.Top > 10 And person.Top < PictureBox18.Top Then
            stand_y = PictureBox18.Top
            person.Top = stand_y - person.Height

        ElseIf person.Left > PictureBox18.Right And person.Top <= PictureBox18.Top + PictureBox18.Height And person.Right < Yellow_plat.Left And person.Top > 10 Then
            stand_y = PictureBox12.Top
            person.Top = stand_y - person.Height
        ElseIf person.Left - 40 <= PictureBox25.Left And person.Left > PictureBox18.Right And person.Left > PictureBox17.Left And person.Top <= PictureBox18.Top + PictureBox18.Height And person.Top > 10 Then
            person.Left = PictureBox25.Right
        End If
    End Sub
#End Region
#Region "移動限制"
    Sub Limit()
        Dim y = person.Location.Y
        stand_y = y
        Dim Ground = Me.ClientSize.Height - 20 - person.Height
        If person.Left > PictureBox3.Left And person.Right < PictureBox6.Right And person.Top > PictureBox3.Top + PictureBox3.Height Then
            jumlimit = True
            jump_h = 5
        ElseIf person.Left > PictureBox12.Left And person.Right < PictureBox14.Right And person.Top > PictureBox12.Top + PictureBox12.Height And person.Top <= PictureBox3.Top Then
            jumlimit = True
            jump_h = 60
        ElseIf person.Left > PictureBox15.Left And person.Right < PictureBox16.Right And person.Top > PictureBox15.Top + PictureBox15.Height And person.Top <= PictureBox2.Top Then
            jumlimit = True
            jump_h = 95
        ElseIf person.Left > toxic2.Left And person.Right < PictureBox10.Right And person.Top > PictureBox10.Top + PictureBox10.Height Then
            jumlimit = True
            jump_h = 80
        ElseIf person.Left > PictureBox17.Left And person.Right < PictureBox18.Right And person.Top > PictureBox17.Top And person.Top < PictureBox12.Top Then
            jumlimit = True
            jump_h = 10

        Else
            jumlimit = False
        End If

    End Sub

#End Region
End Class

