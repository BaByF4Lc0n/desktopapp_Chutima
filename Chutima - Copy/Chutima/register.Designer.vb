﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class register
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtmajor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btedit = New System.Windows.Forms.Button()
        Me.btadd = New System.Windows.Forms.Button()
        Me.btreset = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btback = New System.Windows.Forms.Button()
        Me.btclose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btreset)
        Me.GroupBox1.Controls.Add(Me.btadd)
        Me.GroupBox1.Controls.Add(Me.btedit)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.txtmajor)
        Me.GroupBox1.Controls.Add(Me.txtlname)
        Me.GroupBox1.Controls.Add(Me.txtname)
        Me.GroupBox1.Controls.Add(Me.txtid)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(459, 224)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ลงทะเบียนนักเรียน"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "รหัสนักเรียน"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(99, 33)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(148, 20)
        Me.txtid.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ชื่อ"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(100, 72)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(147, 20)
        Me.txtname.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "นามสกุล"
        '
        'txtlname
        '
        Me.txtlname.Location = New System.Drawing.Point(99, 109)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(147, 20)
        Me.txtlname.TabIndex = 2
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(100, 145)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(44, 17)
        Me.RadioButton1.TabIndex = 3
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "ชาย"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(167, 145)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(46, 17)
        Me.RadioButton2.TabIndex = 3
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "หญิง"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "เพศ"
        '
        'txtmajor
        '
        Me.txtmajor.Location = New System.Drawing.Point(99, 183)
        Me.txtmajor.Name = "txtmajor"
        Me.txtmajor.Size = New System.Drawing.Size(147, 20)
        Me.txtmajor.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(47, 186)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "สายวิชา"
        '
        'btedit
        '
        Me.btedit.Location = New System.Drawing.Point(327, 31)
        Me.btedit.Name = "btedit"
        Me.btedit.Size = New System.Drawing.Size(75, 23)
        Me.btedit.TabIndex = 4
        Me.btedit.Text = "แก้ไข"
        Me.btedit.UseVisualStyleBackColor = True
        '
        'btadd
        '
        Me.btadd.Location = New System.Drawing.Point(327, 70)
        Me.btadd.Name = "btadd"
        Me.btadd.Size = New System.Drawing.Size(75, 23)
        Me.btadd.TabIndex = 4
        Me.btadd.Text = "เพิ่ม"
        Me.btadd.UseVisualStyleBackColor = True
        '
        'btreset
        '
        Me.btreset.Location = New System.Drawing.Point(327, 107)
        Me.btreset.Name = "btreset"
        Me.btreset.Size = New System.Drawing.Size(75, 23)
        Me.btreset.TabIndex = 4
        Me.btreset.Text = "ลบ"
        Me.btreset.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(38, 266)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(459, 150)
        Me.DataGridView1.TabIndex = 1
        '
        'btback
        '
        Me.btback.Location = New System.Drawing.Point(379, 500)
        Me.btback.Name = "btback"
        Me.btback.Size = New System.Drawing.Size(75, 23)
        Me.btback.TabIndex = 2
        Me.btback.Text = "ย้อนกลับ"
        Me.btback.UseVisualStyleBackColor = True
        '
        'btclose
        '
        Me.btclose.Location = New System.Drawing.Point(491, 500)
        Me.btclose.Name = "btclose"
        Me.btclose.Size = New System.Drawing.Size(83, 23)
        Me.btclose.TabIndex = 2
        Me.btclose.Text = "ปิดการทำงาน"
        Me.btclose.UseVisualStyleBackColor = True
        '
        'register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 535)
        Me.Controls.Add(Me.btclose)
        Me.Controls.Add(Me.btback)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "register"
        Me.Text = "register"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtid As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtlname As TextBox
    Friend WithEvents txtname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents btadd As Button
    Friend WithEvents btedit As Button
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents txtmajor As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btreset As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btback As Button
    Friend WithEvents btclose As Button
End Class
