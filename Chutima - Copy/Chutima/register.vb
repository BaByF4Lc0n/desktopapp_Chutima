Imports System.Data.OleDb

Imports System.IO


Public Class register
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Directory.GetCurrentDirectory() + "\std.accdb")
    Dim da As New OleDbDataAdapter
    Dim dt As New DataTable
    Dim ds As New DataSet
    Private Sub Register_load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If con.State = ConnectionState.Closed Then
            con.Open()
            MsgBox("open")
        End If
    End Sub
    Private Function Checkdata()
        Dim result As Boolean
        If txtid.Text = "" Or txtname.Text = "" Or txtlname.Text = "" Or txtgender.Text = "" Or txtmajor.Text = "" Then
            MessageBox.Show("กรุณาใส่ข้อมูลให้ครบ")
            result = False
        Else
            result = True
        End If
        Return result
    End Function
    Private Sub showtable()
        Dim sqlQuery As String
        Dim da As New OleDb.OleDbDataAdapter
        Dim ds As New DataSet
        sqlQuery = "select * from std"
        da = New OleDbDataAdapter(sqlQuery, con)
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.Columns.Item(0).HeaderText() = "รหัสนักเรียน"
        DataGridView1.Columns.Item(1).HeaderText() = "ชื่อ"
        DataGridView1.Columns.Item(2).HeaderText() = "นามสกุล"
        DataGridView1.Columns.Item(3).HeaderText() = "เพศ"
        DataGridView1.Columns.Item(4).HeaderText() = "ภาควิชา"
    End Sub
    Private Sub textboxid_TextChanged(sender As Object, e As EventArgs) Handles txtid.TextChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btadd_Click(sender As Object, e As EventArgs) Handles btclear.Click
        txtid.Clear()
        txtname.Clear()
        txtlname.Clear()
        txtgender.Clear()
        txtmajor.Clear()
    End Sub

    Private Sub btback_Click(sender As Object, e As EventArgs) Handles btback.Click
        Me.Hide()
        main.Show()
    End Sub

    Private Sub btclose_Click(sender As Object, e As EventArgs) Handles btclose.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        txtid.Text = DataGridView1.Item(0, i).Value
        txtname.Text = DataGridView1.Item(1, i).Value
        txtlname.Text = DataGridView1.Item(2, i).Value
        txtgender.Text = DataGridView1.Item(3, i).Value
        txtmajor.Text = DataGridView1.Item(4, i).Value
    End Sub

    Private Sub btedit_Click(sender As Object, e As EventArgs) Handles btedit.Click
        Dim sqlQuery As String
        Dim result As Boolean
        result = Checkdata()
        If result = True Then
            Try
                sqlQuery = "UPDATE std SET std_Name = '" & txtname.Text & "', std_Lname = '" & txtlname.Text & "',std_Gender = '" & txtgender.Text & "',std_Major = '" & txtmajor.Text & "' WHERE std_id = '" & txtid.Text & "'"
                Dim cmd As New OleDbCommand(sqlQuery, con)
                cmd.ExecuteNonQuery()
                MsgBox("แก้ไขข้อมูลสำเร็จ", vbInformation)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
        showtable()
    End Sub

    Private Sub btadd_Click_1(sender As Object, e As EventArgs) Handles btadd.Click
        Dim sqlQuery As String
        Dim result As Boolean
        result = Checkdata()
        If result = True Then
            Try
                sqlQuery = "INSERT INTO std(std_id,std_Name,std_Lname,std_Gender,std_Major) VALUES ('" & txtid.Text & "','" & txtname.Text & "','" & txtlname.Text & "','" & txtgender.Text & "','" & txtmajor.Text & "')"
                Dim cmd As New OleDbCommand(sqlQuery, con)
                cmd.ExecuteNonQuery()
                MsgBox("บันทีกข้อมูลสำเร็จ", vbInformation)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
        showtable()
    End Sub

    Private Sub btreset_Click(sender As Object, e As EventArgs) Handles btdel.Click
        Dim sqlQuery As String
        Dim result As Boolean
        result = Checkdata()
        If result = True Then
            Try
                sqlQuery = "DELETE FROM std WHERE std_id = '" & txtid.Text & "'" '& textboxgetname.Text & "','" & textboxgetlname.Text & "','" & textboxgetgender.Text & "','" & textboxgetmajor.Text & "')"
                Dim cmd As New OleDbCommand(sqlQuery, con)
                cmd.ExecuteNonQuery()
                MsgBox("ลบข้อมูลสำเร็จ", vbInformation)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
        showtable()
    End Sub
End Class