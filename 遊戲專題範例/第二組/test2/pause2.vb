Public Class pause2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.IsMdiContainer = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        My.Forms.Form2.Dispose()
        Form2.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        My.Forms.Form2.Dispose()
        My.Computer.Audio.Play("..\..\m_set_63.wav", AudioPlayMode.BackgroundLoop)
        start.Show()
    End Sub
End Class