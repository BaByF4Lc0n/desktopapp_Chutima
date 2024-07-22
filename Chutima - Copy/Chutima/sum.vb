Public Class sum
    Dim a As Integer
    Dim b As Integer
    Dim c As Integer
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        main.Show()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        a = txtnum1.Text
        b = txtnum2.Text
        c = a + b
        MessageBox.Show("ชื่อ-สกุล: " & txtname.Text &
                        "ระดับชั้น: " & txtc.Text &
                        "เลขที่: " & txtn.Text &
                        "คำตอบ = " & c)

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        a = txtnum1.Text
        b = txtnum2.Text
        c = a - b
        MessageBox.Show("ชื่อ-สกุล: " & txtname.Text &
                        "ระดับชั้น: " & txtc.Text &
                        "เลขที่: " & txtn.Text &
                        "คำตอบ = " & c)

    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        a = txtnum1.Text
        b = txtnum2.Text
        c = a * b
        MessageBox.Show("ชื่อ-สกุล: " & txtname.Text &
                        "ระดับชั้น: " & txtc.Text &
                        "เลขที่: " & txtn.Text &
                        "คำตอบ = " & c)

    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        a = txtnum1.Text
        b = txtnum2.Text
        c = a / b
        MessageBox.Show("ชื่อ-สกุล: " & txtname.Text &
                        "ระดับชั้น: " & txtc.Text &
                        "เลขที่: " & txtn.Text &
                        "คำตอบ = " & c)

    End Sub

End Class