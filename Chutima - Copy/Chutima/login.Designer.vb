<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtuser = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.lgin = New System.Windows.Forms.Button()
        Me.txtclose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ชื่อ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(41, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "รหัส"
        '
        'txtuser
        '
        Me.txtuser.Location = New System.Drawing.Point(73, 33)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Size = New System.Drawing.Size(180, 20)
        Me.txtuser.TabIndex = 1
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(73, 83)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(180, 20)
        Me.txtpass.TabIndex = 1
        '
        'lgin
        '
        Me.lgin.Location = New System.Drawing.Point(119, 144)
        Me.lgin.Name = "lgin"
        Me.lgin.Size = New System.Drawing.Size(75, 23)
        Me.lgin.TabIndex = 2
        Me.lgin.Text = "เข้าสู่ระบบ"
        Me.lgin.UseVisualStyleBackColor = True
        '
        'txtclose
        '
        Me.txtclose.Location = New System.Drawing.Point(263, 217)
        Me.txtclose.Name = "txtclose"
        Me.txtclose.Size = New System.Drawing.Size(100, 23)
        Me.txtclose.TabIndex = 3
        Me.txtclose.Text = "ปิดการทำงาน"
        Me.txtclose.UseVisualStyleBackColor = True
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 252)
        Me.Controls.Add(Me.txtclose)
        Me.Controls.Add(Me.lgin)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtuser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "login"
        Me.Text = "เข้าสู่ระบบการใช้งาน: นางสาวชุติมา ปักกะสีนัง"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtuser As TextBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents lgin As Button
    Friend WithEvents txtclose As Button
End Class
