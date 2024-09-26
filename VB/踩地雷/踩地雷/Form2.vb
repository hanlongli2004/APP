Public Class Form2
    Const ROW = 4
    Const COL = 4
    Const BOOM = 3
    Dim BOT(ROW, COL) As PictureBox

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim block As Image = CType(My.Resources.ResourceManager.GetObject("Box"), Image)

        For i As Integer = 0 To ROW
            For j As Integer = 0 To COL
                BOT(i, j) = New PictureBox
                Me.Controls.Add(BOT(i, j))
                BOT(i, j).Name = "PictureBox" & ((COL + 1) * i + j).ToString()
                BOT(i, j).Image = CType(My.Resources.ResourceManager.GetObject("box"), Image)
                BOT(i, j).SizeMode = PictureBoxSizeMode.StretchImage
                BOT(i, j).BorderStyle = BorderStyle.Fixed3D
                BOT(i, j).Visible = True
                BOT(i, j).Width = 50
                BOT(i, j).Height = 50
                BOT(i, j).Top = 50 * i
                BOT(i, j).Left = 50 * j
                BOT(i, j).Tag = New Point(i, j) ' 保存行和列索引
                AddHandler BOT(i, j).Click, AddressOf abc_Click
            Next j

        Next i
        Randomize()
            GenBoom(BOOM)
    End Sub

    Sub CheckBoomNumber(row As Integer, col As Integer)
        Dim bombCount As Integer = 0

        For i As Integer = -1 To 1
            For j As Integer = -1 To 1
                Dim newRow As Integer = row + i
                Dim newCol As Integer = col + j

                If newRow >= 0 AndAlso newRow <= row And newCol >= 0 AndAlso newCol <= col Then
                    If BOT(newRow, newCol).Tag = "1" Then
                        bombCount += 1
                    End If
                End If
            Next
        Next

        If bombCount > 0 Then
            BOT(row, col).Image = Nothing
            BOT(row, col).Enabled = False
            BOT(row, col).Tag = bombCount.ToString()
        End If
    End Sub

    Sub GenBoom(BoomNumber As Integer)
        Dim r As New Random
        Do
            Dim Number = r.Next((ROW + 1) * (COL + 1) - 1)
            Dim No1 = Number \ (COL + 1)
            Dim No2 = Number Mod (COL + 1)

            If (BOT(No1, No2).Tag <> "1") Then
                BOT(No1, No2).Tag = "1"
                BOT(No1, No2).Image = My.Resources.ResourceManager.GetObject("boom")
                BOT(No1, No2).BackgroundImageLayout = ImageLayout.Stretch
                BoomNumber -= 1
            End If
        Loop While (BoomNumber <> 0)
    End Sub

    Sub abc_Click(sender As Object, e As EventArgs)
        Dim B = CType(sender, PictureBox)
        Dim location As Point = DirectCast(B.Tag, Point)
        Dim row As Integer = location.X
        Dim col As Integer = location.Y

        If B.Tag = "1" Then
            MessageBox.Show("Boom....")
        Else
            CheckBoomNumber(row, col)
        End If
    End Sub
End Class