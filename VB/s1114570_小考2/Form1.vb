Public Class Form1
    Private gameStarted As Boolean = False
    Private isFirstPlayerTurn As Boolean = True
    Private firstPlayerSeconds As Integer = 0
    Private secondPlayerSeconds As Integer = 0

    Private Const TimerInterval As Integer = 1000

    Private WithEvents firstPlayerTimer As New Timer()
    Private WithEvents secondPlayerTimer As New Timer()

    Private Sub StartGameButton_Click(sender As Object, e As EventArgs) Handles Button1.Click

        gameStarted = True
        firstPlayerSeconds = 0
        secondPlayerSeconds = 0

        firstPlayerTimer.Interval = TimerInterval
        firstPlayerTimer.Start()

        For Each panel As Panel In Me.Controls.OfType(Of Panel)()
            panel.Enabled = True
        Next panel
    End Sub

    Private Sub firstPlayerTimer_Tick(sender As Object, e As EventArgs) Handles firstPlayerTimer.Tick
        firstPlayerSeconds += 1
        Label1.Text = firstPlayerSeconds.ToString() & " sec"
    End Sub

    Private Sub secondPlayerTimer_Tick(sender As Object, e As EventArgs) Handles secondPlayerTimer.Tick

        secondPlayerSeconds += 1
        Label2.Text = secondPlayerSeconds.ToString() & " sec"
    End Sub

    Private Sub Panel_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel3.MouseDown, Panel4.MouseDown, Panel5.MouseDown, Panel6.MouseDown, Panel7.MouseDown, Panel8.MouseDown, Panel9.MouseDown, Panel10.MouseDown, Panel11.MouseDown
        If gameStarted Then
            Dim clickedPanel As Panel = DirectCast(sender, Panel)

            If isFirstPlayerTurn AndAlso e.Button = MouseButtons.Left Then
                clickedPanel.BackgroundImage = My.Resources.a
                isFirstPlayerTurn = False

                firstPlayerTimer.Stop()
                secondPlayerTimer.Interval = TimerInterval
                secondPlayerTimer.Start()
            ElseIf Not isFirstPlayerTurn AndAlso e.Button = MouseButtons.Right Then

                clickedPanel.BackgroundImage = My.Resources.b
                isFirstPlayerTurn = True


                secondPlayerTimer.Stop()
                firstPlayerTimer.Interval = TimerInterval
                firstPlayerTimer.Start()
            Else

                If isFirstPlayerTurn Then
                    MessageBox.Show("先手請按左鍵!!!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    MessageBox.Show("後手請按右鍵!!!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        End If
    End Sub
End Class