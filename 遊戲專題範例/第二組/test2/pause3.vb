Public Class pause3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form3.IsMdiContainer = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        My.Forms.Form3.Dispose()
        Form3.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
        My.Computer.Audio.Play("..\..\m_set_63.wav", AudioPlayMode.BackgroundLoop)
        My.Forms.Form3.Dispose()
        start.Show()
    End Sub
End Class