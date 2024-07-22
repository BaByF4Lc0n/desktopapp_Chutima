Public Class cut
    Dim id As Integer
    Dim score1, score2, score3, mid, final As Integer
    Dim sum As Integer

    Private Sub bt_back_Click(sender As System.Object, e As System.EventArgs) Handles bt_back.Click
        Me.Hide()
        main.Show()

    End Sub

    Private Sub bt_end_Click(sender As System.Object, e As System.EventArgs) Handles bt_end.Click
        Me.Close()

    End Sub

    Private Sub txtid_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtid.TextChanged
        If (IsNumeric(txtid.Text)) Then
            id = txtid.Text
        Else
            txtid.Clear()
            MessageBox.Show("คุณกรอกข้อมูลไม่ถูกต้อง")
        End If
    End Sub

    Private Sub txtscor1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtscore1.TextChanged
        If (IsNumeric(txtscore1.Text)) Then
            If (txtscore1.Text > 20) Then
                txtscore1.Clear()
                MessageBox.Show("คะแนนไม่เกิน 20 คะแนน")
            ElseIf (txtscore1.Text < 0) Then
                txtscore1.Clear()
                MessageBox.Show("คะแนนไม่ต่ำกว่า 20 คะแนน")
            Else
                score1 = txtscore1.Text
            End If
        Else
            txtscore1.Clear()
            MessageBox.Show("คุณกรอกข้อมูลผิดประเภท")
        End If
    End Sub

    Private Sub txtscore2_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtscore2.TextChanged
        If (IsNumeric(txtscore2.Text)) Then
            If (txtscore2.Text > 20) Then
                txtscore2.Clear()
                MessageBox.Show("คะแนนไม่เกิน 20 คะแนน")
            ElseIf (txtscore2.Text < 0) Then
                txtscore2.Clear()
                MessageBox.Show("คะแนนไม่ต่ำกว่า 20 คะแนน")
            Else
                score2 = txtscore2.Text
            End If
        Else
            txtscore2.Clear()
            MessageBox.Show("คุณกรอกข้อมูลผิดประเภท")
        End If
    End Sub

    Private Sub btcut_Click(sender As Object, e As EventArgs) Handles btcut.Click
        If (sum >= 80) Then
            MessageBox.Show("ชื่อ:" & txtname.Text & vbNewLine &
                            "นามสกุล:" & txtlname.Text & vbNewLine &
                            "ชั้น:" & txtclass.Text & vbNewLine &
                            "เลขที่:" & txtid.Text & vbNewLine &
                            "วิชา:" & cbtid.Text & vbNewLine &
                            "คะแนนรวม:" & txtshow.Text & vbNewLine &
                            "เกรด:" & "4"
            )
        ElseIf (sum >= 70) Then
            MessageBox.Show("ชื่อ:" & txtname.Text & vbNewLine &
                            "นามสกุล:" & txtlname.Text & vbNewLine &
                            "ชั้น:" & txtclass.Text & vbNewLine &
                            "เลขที่:" & txtid.Text & vbNewLine &
                            "วิชา:" & cbtid.Text & vbNewLine &
                            "คะแนนรวม:" & txtshow.Text & vbNewLine &
                            "เกรด:" & "3"
                )
        ElseIf (sum >= 60) Then
            MessageBox.Show("ชื่อ:" & txtname.Text & vbNewLine &
                            "นามสกุล:" & txtlname.Text & vbNewLine &
                            "ชั้น:" & txtclass.Text & vbNewLine &
                            "เลขที่:" & txtid.Text & vbNewLine &
                            "วิชา:" & cbtid.Text & vbNewLine &
                            "คะแนนรวม:" & txtshow.Text & vbNewLine &
                            "เกรด:" & "2"
                )
        ElseIf (sum >= 50) Then
            MessageBox.Show("ชื่อ:" & txtname.Text & vbNewLine &
                            "นามสกุล:" & txtlname.Text & vbNewLine &
                            "ชั้น:" & txtclass.Text & vbNewLine &
                            "เลขที่:" & txtid.Text & vbNewLine &
                            "วิชา:" & cbtid.Text & vbNewLine &
                            "คะแนนรวม:" & txtshow.Text & vbNewLine &
                            "เกรด:" & "1"
                )
        ElseIf (sum < 50) Then
            MessageBox.Show("ชื่อ:" & txtname.Text & vbNewLine &
                            "นามสกุล:" & txtlname.Text & vbNewLine &
                            "ชั้น:" & txtclass.Text & vbNewLine &
                            "เลขที่:" & txtid.Text & vbNewLine &
                            "วิชา:" & cbtid.Text & vbNewLine &
                            "คะแนนรวม:" & txtshow.Text & vbNewLine &
                            "เกรด:" & "0"
                )
        End If
    End Sub

    Private Sub GroupBox5_Enter(sender As Object, e As EventArgs) Handles GroupBox5.Enter

    End Sub

    Private Sub btshow_Click(sender As Object, e As EventArgs) Handles btshow.Click
        If (sum >= 80) Then
            lbshow.Text = "ชื่อ:" & txtname.Text & vbNewLine &
                            "นามสกุล:" & txtlname.Text & vbNewLine &
                            "ชั้น:" & txtclass.Text & vbNewLine &
                            "เลขที่:" & txtid.Text & vbNewLine &
                            "วิชา:" & cbtid.Text & vbNewLine &
                            "คะแนนรวม:" & txtshow.Text & vbNewLine &
                            "เกรด:" & "4"
        ElseIf (sum >= 70) Then
            lbshow.Text = "ชื่อ:" & txtname.Text & vbNewLine &
                            "นามสกุล:" & txtlname.Text & vbNewLine &
                            "ชั้น:" & txtclass.Text & vbNewLine &
                            "เลขที่:" & txtid.Text & vbNewLine &
                            "วิชา:" & cbtid.Text & vbNewLine &
                            "คะแนนรวม:" & txtshow.Text & vbNewLine &
                            "เกรด:" & "3"
        ElseIf (sum >= 60) Then
            lbshow.Text = "ชื่อ:" & txtname.Text & vbNewLine &
                            "นามสกุล:" & txtlname.Text & vbNewLine &
                            "ชั้น:" & txtclass.Text & vbNewLine &
                            "เลขที่:" & txtid.Text & vbNewLine &
                            "วิชา:" & cbtid.Text & vbNewLine &
                            "คะแนนรวม:" & txtshow.Text & vbNewLine &
                            "เกรด:" & "2"
        ElseIf (sum >= 50) Then
            lbshow.Text = "ชื่อ:" & txtname.Text & vbNewLine &
                            "นามสกุล:" & txtlname.Text & vbNewLine &
                            "ชั้น:" & txtclass.Text & vbNewLine &
                            "เลขที่:" & txtid.Text & vbNewLine &
                            "วิชา:" & cbtid.Text & vbNewLine &
                            "คะแนนรวม:" & txtshow.Text & vbNewLine &
                            "เกรด:" & "1"
        ElseIf (sum < 50) Then
            lbshow.Text = "ชื่อ:" & txtname.Text & vbNewLine &
                            "นามสกุล:" & txtlname.Text & vbNewLine &
                            "ชั้น:" & txtclass.Text & vbNewLine &
                            "เลขที่:" & txtid.Text & vbNewLine &
                            "วิชา:" & cbtid.Text & vbNewLine &
                            "คะแนนรวม:" & txtshow.Text & vbNewLine &
                            "เกรด:" & "0"
        End If
    End Sub

    Private Sub txtscore3_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtscore3.TextChanged
        If (IsNumeric(txtscore3.Text)) Then
            If (txtscore3.Text > 20) Then
                txtscore3.Clear()
                MessageBox.Show("คะแนนไม่เกิน 20 คะแนน")
            ElseIf (txtscore3.Text < 0) Then
                txtscore3.Clear()
                MessageBox.Show("คะแนนไม่ต่ำกว่า 20 คะแนน")
            Else
                score3 = txtscore3.Text
            End If
        Else
            txtscore3.Clear()
            MessageBox.Show("คุณกรอกข้อมูลผิดประเภท")
        End If
    End Sub

    Private Sub txtmid_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtmid.TextChanged
        If (IsNumeric(txtmid.Text)) Then
            If (txtmid.Text > 20) Then
                txtmid.Clear()
                MessageBox.Show("คะแนนไม่เกิน 20 คะแนน")
            ElseIf (txtmid.Text < 0) Then
                txtmid.Clear()
                MessageBox.Show("คะแนนไม่ต่ำกว่า 20 คะแนน")
            Else
                mid = txtmid.Text
            End If
        Else
            txtmid.Clear()
            MessageBox.Show("คุณกรอกข้อมูลผิดประเภท")
        End If
    End Sub

    Private Sub txtfinal_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtfinal.TextChanged
        If (IsNumeric(txtfinal.Text)) Then
            If (txtfinal.Text > 20) Then
                txtfinal.Clear()
                MessageBox.Show("คะแนนไม่เกิน 20 คะแนน")
            ElseIf (txtfinal.Text < 0) Then
                txtfinal.Clear()
                MessageBox.Show("คะแนนไม่ต่ำกว่า 20 คะแนน")
            Else
                final = txtfinal.Text
            End If
        Else
            txtfinal.Clear()
            MessageBox.Show("คุณกรอกข้อมูลผิดประเภท")
        End If
    End Sub

    
    Private Sub btsum_Click(sender As System.Object, e As System.EventArgs) Handles btsum.Click
        sum = score1 + score2 + score3 + mid + final
        txtshow.Text = sum
    End Sub


End Class