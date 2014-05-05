Public Class Form1

    Private rand As New System.Random(Environment.TickCount)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim part1 As Integer = rand.Next(0, &HFFF)
        Dim part2 As Integer = rand.Next(0, &HFFF)
        Dim part3 As Integer = rand.Next(0, &HFFF)
        Dim part4 As Integer = rand.Next(0, &HFFF)
        Dim i As Integer = 1
        Dim _mod As Integer = 9

        part3 = part3 * 10 + 5
        While (part3 Mod 9 <> 1)
            part3 = rand.Next(0, &HFF)
            part3 = part3 * 10 + 5
        End While

        part1 = part1 * 10 + _mod - 1
        part2 = part2 * _mod + 3
        part4 = part4 * _mod + 7

        TextBox1.Text = "WYMTGGP-" + part1.ToString("X4") + "-" + part2.ToString("X4") + "-" + part3.ToString("X4") + "-" + part4.ToString("X4") + "-QKWU"
    End Sub
End Class
