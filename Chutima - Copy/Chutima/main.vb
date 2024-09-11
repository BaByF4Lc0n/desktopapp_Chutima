Public Class main

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles bt_sum.Click
        Me.Hide()
        sum.Show()

    End Sub

    Private Sub bt_cutgrade_Click(sender As System.Object, e As System.EventArgs) Handles bt_cutgrade.Click
        Me.Hide()
        cut.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        register.Show()
    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
